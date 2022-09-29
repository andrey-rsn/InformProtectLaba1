namespace InformProtectLaba1
{
    partial class ProgramInfoForm
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
            this.AuthorInfo = new System.Windows.Forms.Label();
            this.TaskInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AuthorInfo
            // 
            this.AuthorInfo.AutoSize = true;
            this.AuthorInfo.Location = new System.Drawing.Point(12, 9);
            this.AuthorInfo.Name = "AuthorInfo";
            this.AuthorInfo.Size = new System.Drawing.Size(332, 15);
            this.AuthorInfo.TabIndex = 0;
            this.AuthorInfo.Text = "Выполнил студент 4 курса группы ИДБ-19-01 Коровай А.А.";
            // 
            // TaskInfo
            // 
            this.TaskInfo.AutoSize = true;
            this.TaskInfo.Location = new System.Drawing.Point(12, 37);
            this.TaskInfo.Name = "TaskInfo";
            this.TaskInfo.Size = new System.Drawing.Size(38, 15);
            this.TaskInfo.TabIndex = 1;
            this.TaskInfo.Text = "label2";
            // 
            // ProgramInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 125);
            this.Controls.Add(this.TaskInfo);
            this.Controls.Add(this.AuthorInfo);
            this.Name = "ProgramInfoForm";
            this.Text = "Информация о программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AuthorInfo;
        private Label TaskInfo;
    }
}