namespace GUI
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picToDo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbBacklog = new System.Windows.Forms.Label();
            this.lbClosed = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstResolved = new System.Windows.Forms.ListBox();
            this.lstClosed = new System.Windows.Forms.ListBox();
            this.lstBackLog = new System.Windows.Forms.ListBox();
            this.lbResolved = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToDo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1294, 57);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(86, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 115);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(86, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 112);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(27)))), ((int)(((byte)(52)))));
            this.panel4.Controls.Add(this.picToDo);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(124, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 204);
            this.panel4.TabIndex = 4;
            // 
            // picToDo
            // 
            this.picToDo.Image = ((System.Drawing.Image)(resources.GetObject("picToDo.Image")));
            this.picToDo.Location = new System.Drawing.Point(26, 32);
            this.picToDo.Name = "picToDo";
            this.picToDo.Size = new System.Drawing.Size(105, 99);
            this.picToDo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picToDo.TabIndex = 6;
            this.picToDo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(44, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "TO-DO";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel5.Location = new System.Drawing.Point(0, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(129, 579);
            this.panel5.TabIndex = 5;
            // 
            // lbBacklog
            // 
            this.lbBacklog.AutoSize = true;
            this.lbBacklog.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBacklog.ForeColor = System.Drawing.Color.Black;
            this.lbBacklog.Location = new System.Drawing.Point(374, 106);
            this.lbBacklog.Name = "lbBacklog";
            this.lbBacklog.Size = new System.Drawing.Size(100, 28);
            this.lbBacklog.TabIndex = 6;
            this.lbBacklog.Text = "Backlog";
            // 
            // lbClosed
            // 
            this.lbClosed.AutoSize = true;
            this.lbClosed.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClosed.ForeColor = System.Drawing.Color.Black;
            this.lbClosed.Location = new System.Drawing.Point(1006, 106);
            this.lbClosed.Name = "lbClosed";
            this.lbClosed.Size = new System.Drawing.Size(86, 28);
            this.lbClosed.TabIndex = 8;
            this.lbClosed.Text = "Closed";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(688, 552);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 53);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstResolved
            // 
            this.lstResolved.AllowDrop = true;
            this.lstResolved.FormattingEnabled = true;
            this.lstResolved.ItemHeight = 15;
            this.lstResolved.Location = new System.Drawing.Point(648, 179);
            this.lstResolved.Name = "lstResolved";
            this.lstResolved.Size = new System.Drawing.Size(211, 334);
            this.lstResolved.TabIndex = 11;
            this.lstResolved.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.lstResolved.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstResolved.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            this.lstResolved.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lstClosed
            // 
            this.lstClosed.AllowDrop = true;
            this.lstClosed.FormattingEnabled = true;
            this.lstClosed.ItemHeight = 15;
            this.lstClosed.Location = new System.Drawing.Point(951, 179);
            this.lstClosed.Name = "lstClosed";
            this.lstClosed.Size = new System.Drawing.Size(203, 334);
            this.lstClosed.TabIndex = 12;
            this.lstClosed.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.lstClosed.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstClosed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            this.lstClosed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lstBackLog
            // 
            this.lstBackLog.AllowDrop = true;
            this.lstBackLog.FormattingEnabled = true;
            this.lstBackLog.ItemHeight = 15;
            this.lstBackLog.Location = new System.Drawing.Point(322, 179);
            this.lstBackLog.Name = "lstBackLog";
            this.lstBackLog.Size = new System.Drawing.Size(218, 334);
            this.lstBackLog.TabIndex = 10;
            this.lstBackLog.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox_DragDrop);
            this.lstBackLog.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lstBackLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            this.lstBackLog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lbResolved
            // 
            this.lbResolved.AutoSize = true;
            this.lbResolved.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResolved.ForeColor = System.Drawing.Color.Black;
            this.lbResolved.Location = new System.Drawing.Point(691, 106);
            this.lbResolved.Name = "lbResolved";
            this.lbResolved.Size = new System.Drawing.Size(111, 28);
            this.lbResolved.TabIndex = 7;
            this.lbResolved.Text = "Resolved";
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 636);
            this.Controls.Add(this.lstBackLog);
            this.Controls.Add(this.lstClosed);
            this.Controls.Add(this.lstResolved);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbClosed);
            this.Controls.Add(this.lbResolved);
            this.Controls.Add(this.lbBacklog);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1310, 675);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TO-DO application";
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picToDo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbBacklog;
        private System.Windows.Forms.Label lbClosed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstResolved;
        private System.Windows.Forms.ListBox lstClosed;
        private System.Windows.Forms.ListBox lstBackLog;
        private System.Windows.Forms.Label lbResolved;
    }
}

