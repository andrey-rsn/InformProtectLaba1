namespace InformProtectLaba1
{
    partial class ChangePasswordForm
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
            this.loginLabel = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cnacelBtn = new System.Windows.Forms.Button();
            this.newPassTextBox = new System.Windows.Forms.TextBox();
            this.confirmPassTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(12, 24);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(50, 20);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "label1";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(12, 150);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(94, 29);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Новый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Подтверждение";
            // 
            // cnacelBtn
            // 
            this.cnacelBtn.Location = new System.Drawing.Point(176, 150);
            this.cnacelBtn.Name = "cnacelBtn";
            this.cnacelBtn.Size = new System.Drawing.Size(94, 29);
            this.cnacelBtn.TabIndex = 3;
            this.cnacelBtn.Text = "Отмена";
            this.cnacelBtn.UseVisualStyleBackColor = true;
            this.cnacelBtn.Click += new System.EventHandler(this.cnacelBtn_Click);
            // 
            // newPassTextBox
            // 
            this.newPassTextBox.Location = new System.Drawing.Point(145, 65);
            this.newPassTextBox.Name = "newPassTextBox";
            this.newPassTextBox.Size = new System.Drawing.Size(125, 27);
            this.newPassTextBox.TabIndex = 4;
            this.newPassTextBox.UseSystemPasswordChar = true;
            // 
            // confirmPassTextBox
            // 
            this.confirmPassTextBox.Location = new System.Drawing.Point(145, 102);
            this.confirmPassTextBox.Name = "confirmPassTextBox";
            this.confirmPassTextBox.Size = new System.Drawing.Size(125, 27);
            this.confirmPassTextBox.TabIndex = 4;
            this.confirmPassTextBox.UseSystemPasswordChar = true;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 205);
            this.ControlBox = false;
            this.Controls.Add(this.confirmPassTextBox);
            this.Controls.Add(this.newPassTextBox);
            this.Controls.Add(this.cnacelBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.loginLabel);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label loginLabel;
        private Button okBtn;
        private Label label1;
        private Label label2;
        private Button cnacelBtn;
        private TextBox newPassTextBox;
        private TextBox confirmPassTextBox;
    }
}