using Service;
using System;
using System.Windows.Forms;
using TODO.Domain;

namespace GUI
{
    public partial class AddTaskGUI : Form
    {
        private MainGUI _mainGUI;
        private TaskService _taskService;
        private Validate _validate;

        public AddTaskGUI(MainGUI mainGUI)
        {
            InitializeComponent();
            _mainGUI = mainGUI;
            _validate = new Validate();
            _taskService = new TaskService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var task = InputTask();
            var validateInput = ValidateInputTask(task);
            if (validateInput.Equals(ValidateInput.Default))
            {
                {
                    AddTask(task);
                    Close();
                }
            }
            else
            {
                DisplayWarning(ValidateInputTask(task));
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _taskService.DeleteTask(txtTitle.Text);
            _mainGUI.DisplayTaskToListBox();
            Close();
        }
        private void AddTask(Task task)
        {
            _taskService.AddTask(task);
            _mainGUI.DisplayTaskToListBox();
        }

        public Task InputTask()
        {
            return new Task()
            {
                Title = txtTitle.Text,
                Description = txtDescription.Text,
                DateCreate = dtpCreate.Value,
                DateFinish = dtpFinish.Value,
                Type = "BackLog"
            };
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        internal void ShowDetailTask(Task task)
        {
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            dtpCreate.Value = task.DateCreate;
            dtpFinish.Value = task.DateFinish;

            btnAdd.Visible = false;
            btnDelete.Visible = true;
            btnSave.Visible = true;
        }

        private void AddTaskForm_KeyDown(object sender, KeyEventArgs e)
        {
            var button = new Button();
            if (e.KeyCode == Keys.Enter) button.PerformClick();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var task = GetTaskToUpdate();
            //var validateInput = ValidateInputTask(task);
            //if (validateInput.Equals(ValidateInput.Default))
            //{
            //{
            //validate task when add a task
                UpdateTask(task);
                _mainGUI.DisplayTaskToListBox();
                Close();      
            //if the title in the title field diffrent the current title ==> add new task and remove a task
            //}
            //}
            //else
            //{
            //    DisplayWarning(ValidateInputTask(task));
            //}
        }


        private Task GetTaskToUpdate()
        {
            var taskTitle = txtTitle.Text;
            var task = _taskService.GetTaskByTitle(taskTitle);

            return task;
        }

        private void UpdateTask(Task task)
        {
            task.Description = txtDescription.Text;
            task.DateCreate = dtpCreate.Value;
            task.DateFinish = dtpFinish.Value;

            _taskService.UpdateTask(task);
        }

        private Enum ValidateInputTask(Task task)
        {
            if (!_validate.ValidateTask(task, _taskService.GetTaskList()))
            {
                return ValidateInput.TaskExist;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                return ValidateInput.NullTitle;
            }

            else if (dtpCreate.Value >= dtpFinish.Value)
            {
                return ValidateInput.InvalidDate;
            }

            return ValidateInput.Default;
        }

        private void DisplayWarning(Enum InputStatus)
        {
            if (InputStatus.Equals(ValidateInput.NullTitle))
            {
                MessageBox.Show(Message.title, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (InputStatus.Equals(ValidateInput.TaskExist))
            {
                MessageBox.Show(Message.DuplicatedTitle, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (InputStatus.Equals(ValidateInput.InvalidDate))
            {
                MessageBox.Show(Message.dateInvalid, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
