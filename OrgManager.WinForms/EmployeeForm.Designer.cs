namespace OrgManager.WinForms
{
    partial class EmployeeForm
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
            txtTitle = new TextBox();
            txtFirst = new TextBox();
            txtLast = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(45, 22);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(234, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(45, 66);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(234, 23);
            txtFirst.TabIndex = 1;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(45, 110);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(234, 23);
            txtLast.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(45, 150);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(234, 23);
            txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(45, 196);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(234, 23);
            txtEmail.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(45, 236);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 5;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(204, 236);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 5);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 7;
            label1.Text = "Titul :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 48);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 8;
            label2.Text = "Meno :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 92);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Priezvysko :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 136);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefon :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 178);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(326, 280);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(txtTitle);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtFirst;
        private TextBox txtLast;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnOk;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}