using Service;
using System;
using System.Windows.Forms;
using TODO.Domain;

namespace GUI
{
    public partial class MainGUI : Form
    {
        private TaskService _taskService;
        private Helper _helper;
        public TaskType Type { get; set; }
        public MainGUI()
        {
            InitializeComponent();
            _taskService = new TaskService();
            _helper = new Helper();
            Type = new TaskType();
        }

        #region DisplayTask
        public void DisplayTaskToListBox()
        {
            DisplayMember(lstBackLog);
            DisplayMember(lstResolved);
            DisplayMember(lstClosed);

            LoadTask();

            lstBackLog.ClearSelected();
            lstResolved.ClearSelected();
            lstClosed.ClearSelected();
        }

        private void DisplayMember(ListBox listBox)
        {
            listBox.DisplayMember = "title";
        }

        private void LoadTask()
        {
            lstBackLog.Items.Clear();
            lstResolved.Items.Clear();
            lstClosed.Items.Clear();

            foreach (var task in _taskService.GetTaskList())
            {
                if(_helper.ConvertToEnum(task.Type) == TaskType.BackLog)
                {
                    lstBackLog.Items.Add(task);
                }
                 else if (_helper.ConvertToEnum(task.Type) == TaskType.Resolved)
                {
                    lstResolved.Items.Add(task);
                }
               else
                {
                    lstClosed.Items.Add(task);
                }
            }
        }

        #endregion

        #region Mouse Event
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            var listBox = (ListBox)sender;
            var index = listBox.IndexFromPoint(e.X, e.Y);
            if (index != -1)
            {
                if (listBox.SelectedItem != null)
                {
                    var task = (Task)listBox.Items[index];
                    listBox.DoDragDrop(task, DragDropEffects.Copy);
                }
            }
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            var listBox = (ListBox)sender;
            if (e.Data.GetDataPresent(typeof(Task)))
            {
                var task = e.Data.GetData(typeof(Task)) as Task;
                task.Type = GetTaskType(listBox).ToString();

                _taskService.UpdateTask(task);
                DisplayTaskToListBox();
            }
        }

        private TaskType GetTaskType(ListBox listBox)
        {
            if (listBox == lstResolved)
            {
                return TaskType.Resolved;
            }
            else if (listBox == lstClosed)
            {
                return TaskType.Closed;
            }
            else
            {
                return TaskType.BackLog;
            }
        }

        void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listBox = (ListBox)sender;
            var index = listBox.IndexFromPoint(e.X, e.Y);
            var task = (Task)listBox.Items[index];
            if (index != -1)
            {
                using (var addForm = new AddTaskGUI(this))
                {
                    addForm.ShowDetailTask(task);
                    addForm.ShowDialog();
                    addForm.Dispose();
                }
            }
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addForm = new AddTaskGUI(this))
            {
                addForm.ShowDialog();
            }
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            DisplayTaskToListBox();
        }
    }
}
