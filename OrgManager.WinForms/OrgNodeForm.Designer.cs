namespace OrgManager.WinForms
{
    partial class OrgNodeForm
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
            cmbType = new ComboBox();
            txtCode = new TextBox();
            txtName = new TextBox();
            cmbLeader = new ComboBox();
            btnOk = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(42, 26);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(170, 23);
            cmbType.TabIndex = 0;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(42, 70);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(170, 23);
            txtCode.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(42, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 23);
            txtName.TabIndex = 2;
            // 
            // cmbLeader
            // 
            cmbLeader.FormattingEnabled = true;
            cmbLeader.Location = new Point(42, 156);
            cmbLeader.Name = "cmbLeader";
            cmbLeader.Size = new Size(170, 23);
            cmbLeader.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(42, 193);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 4;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(137, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 8);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "Štruktúra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 7;
            label2.Text = "Názov:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 96);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "Popisa:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 138);
            label4.Name = "label4";
            label4.Size = new Size(149, 15);
            label4.TabIndex = 9;
            label4.Text = "Zodpovedný zamestnanec:";
            // 
            // OrgNodeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 250);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cmbLeader);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            Controls.Add(cmbType);
            Name = "OrgNodeForm";
            Text = "OrgNodeForm";
            Load += OrgNodeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbType;
        private TextBox txtCode;
        private TextBox txtName;
        private ComboBox cmbLeader;
        private Button btnOk;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}