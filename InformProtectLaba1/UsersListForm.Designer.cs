namespace InformProtectLaba1
{
    partial class UsersListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.isBlocked = new System.Windows.Forms.CheckBox();
            this.isPasswordConstraint = new System.Windows.Forms.CheckBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.prevBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(172, 26);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(127, 27);
            this.loginTextBox.TabIndex = 1;
            // 
            // isBlocked
            // 
            this.isBlocked.AutoSize = true;
            this.isBlocked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isBlocked.Location = new System.Drawing.Point(12, 82);
            this.isBlocked.Name = "isBlocked";
            this.isBlocked.Size = new System.Drawing.Size(114, 24);
            this.isBlocked.TabIndex = 2;
            this.isBlocked.Text = "Блокировка";
            this.isBlocked.UseVisualStyleBackColor = true;
            // 
            // isPasswordConstraint
            // 
            this.isPasswordConstraint.AutoSize = true;
            this.isPasswordConstraint.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isPasswordConstraint.Location = new System.Drawing.Point(12, 128);
            this.isPasswordConstraint.Name = "isPasswordConstraint";
            this.isPasswordConstraint.Size = new System.Drawing.Size(206, 24);
            this.isPasswordConstraint.TabIndex = 2;
            this.isPasswordConstraint.Text = "Парольное ограничение";
            this.isPasswordConstraint.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(172, 182);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(127, 33);
            this.nextBtn.TabIndex = 3;
            this.nextBtn.Text = "Следующий";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(12, 182);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(127, 33);
            this.prevBtn.TabIndex = 3;
            this.prevBtn.Text = "Предыдущий";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(12, 221);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(127, 33);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(172, 221);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(127, 33);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(91, 260);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(127, 33);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // UsersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 308);
            this.Controls.Add(this.prevBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.isPasswordConstraint);
            this.Controls.Add(this.isBlocked);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UsersListForm";
            this.Text = "UsersListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox loginTextBox;
        private CheckBox isBlocked;
        private CheckBox isPasswordConstraint;
        private Button nextBtn;
        private Button prevBtn;
        private Button saveBtn;
        private Button cancelBtn;
        private Button okBtn;
    }
}