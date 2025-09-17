namespace OrgManager.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitMain = new SplitContainer();
            btnDeleteNode = new Button();
            btnEditNode = new Button();
            btnAddNode = new Button();
            tvOrg = new TreeView();
            layoutRight = new TableLayoutPanel();
            dgvEmployees = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnAddEmp = new Button();
            btnEditEmp = new Button();
            btnDeleteEmp = new Button();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            layoutRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(btnDeleteNode);
            splitMain.Panel1.Controls.Add(btnEditNode);
            splitMain.Panel1.Controls.Add(btnAddNode);
            splitMain.Panel1.Controls.Add(tvOrg);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(layoutRight);
            splitMain.Size = new Size(985, 450);
            splitMain.SplitterDistance = 361;
            splitMain.TabIndex = 0;
            // 
            // btnDeleteNode
            // 
            btnDeleteNode.Location = new Point(214, 420);
            btnDeleteNode.Name = "btnDeleteNode";
            btnDeleteNode.Size = new Size(99, 23);
            btnDeleteNode.TabIndex = 2;
            btnDeleteNode.Text = "Delete Node";
            btnDeleteNode.UseVisualStyleBackColor = true;
            btnDeleteNode.Click += btnDeleteNode_Click;
            // 
            // btnEditNode
            // 
            btnEditNode.Location = new Point(109, 420);
            btnEditNode.Name = "btnEditNode";
            btnEditNode.Size = new Size(99, 23);
            btnEditNode.TabIndex = 1;
            btnEditNode.Text = "Edit Node";
            btnEditNode.UseVisualStyleBackColor = true;
            btnEditNode.Click += btnEditNode_Click;
            // 
            // btnAddNode
            // 
            btnAddNode.Location = new Point(4, 420);
            btnAddNode.Name = "btnAddNode";
            btnAddNode.Size = new Size(99, 23);
            btnAddNode.TabIndex = 0;
            btnAddNode.Text = "Add Node";
            btnAddNode.UseVisualStyleBackColor = true;
            btnAddNode.Click += btnAddNode_Click;
            // 
            // tvOrg
            // 
            tvOrg.Location = new Point(1, 0);
            tvOrg.Name = "tvOrg";
            tvOrg.Size = new Size(358, 411);
            tvOrg.TabIndex = 0;
            tvOrg.AfterSelect += tvOrg_AfterSelect;
            // 
            // layoutRight
            // 
            layoutRight.ColumnCount = 1;
            layoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutRight.Controls.Add(dgvEmployees, 0, 1);
            layoutRight.Controls.Add(flowLayoutPanel2, 0, 2);
            layoutRight.Dock = DockStyle.Fill;
            layoutRight.Location = new Point(0, 0);
            layoutRight.Name = "layoutRight";
            layoutRight.RowCount = 3;
            layoutRight.RowStyles.Add(new RowStyle());
            layoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutRight.RowStyles.Add(new RowStyle());
            layoutRight.Size = new Size(620, 450);
            layoutRight.TabIndex = 0;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Dock = DockStyle.Fill;
            dgvEmployees.Location = new Point(3, 3);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.Size = new Size(614, 408);
            dgvEmployees.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnAddEmp);
            flowLayoutPanel2.Controls.Add(btnEditEmp);
            flowLayoutPanel2.Controls.Add(btnDeleteEmp);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(3, 417);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(614, 30);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnAddEmp
            // 
            btnAddEmp.Location = new Point(3, 3);
            btnAddEmp.Name = "btnAddEmp";
            btnAddEmp.Size = new Size(120, 23);
            btnAddEmp.TabIndex = 0;
            btnAddEmp.Text = "Add Employee";
            btnAddEmp.UseVisualStyleBackColor = true;
            btnAddEmp.Click += btnAddEmp_Click;
            // 
            // btnEditEmp
            // 
            btnEditEmp.Location = new Point(129, 3);
            btnEditEmp.Name = "btnEditEmp";
            btnEditEmp.Size = new Size(120, 23);
            btnEditEmp.TabIndex = 1;
            btnEditEmp.Text = "Edit Employee";
            btnEditEmp.UseVisualStyleBackColor = true;
            btnEditEmp.Click += btnEditEmp_Click;
            // 
            // btnDeleteEmp
            // 
            btnDeleteEmp.Location = new Point(255, 3);
            btnDeleteEmp.Name = "btnDeleteEmp";
            btnDeleteEmp.Size = new Size(120, 23);
            btnDeleteEmp.TabIndex = 2;
            btnDeleteEmp.Text = "Delete Employee";
            btnDeleteEmp.UseVisualStyleBackColor = true;
            btnDeleteEmp.Click += btnDeleteEmp_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 450);
            Controls.Add(splitMain);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            layoutRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private TreeView tvOrg;
        private TableLayoutPanel layoutRight;
        private Button btnAddNode;
        private Button btnEditNode;
        private Button btnDeleteNode;
        private DataGridView dgvEmployees;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnAddEmp;
        private Button btnEditEmp;
        private Button btnDeleteEmp;
    }
}
