namespace vcz.StudentDesktopWF
{
    partial class FormDBSettings
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelSrvName = new System.Windows.Forms.Label();
            this.labelDBName = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bSaveDBSettings = new System.Windows.Forms.Button();
            this.bCancelDbSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 0;
            // 
            // labelSrvName
            // 
            this.labelSrvName.AutoSize = true;
            this.labelSrvName.Location = new System.Drawing.Point(22, 35);
            this.labelSrvName.Name = "labelSrvName";
            this.labelSrvName.Size = new System.Drawing.Size(74, 13);
            this.labelSrvName.TabIndex = 1;
            this.labelSrvName.Text = "Имя сервера";
            // 
            // labelDBName
            // 
            this.labelDBName.AutoSize = true;
            this.labelDBName.Location = new System.Drawing.Point(22, 87);
            this.labelDBName.Name = "labelDBName";
            this.labelDBName.Size = new System.Drawing.Size(72, 13);
            this.labelDBName.TabIndex = 3;
            this.labelDBName.Text = "База данных";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 2;
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Location = new System.Drawing.Point(22, 141);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(103, 13);
            this.labelUserId.TabIndex = 5;
            this.labelUserId.Text = "Имя пользователя";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 20);
            this.textBox3.TabIndex = 4;
            // 
            // bSaveDBSettings
            // 
            this.bSaveDBSettings.Location = new System.Drawing.Point(24, 225);
            this.bSaveDBSettings.Name = "bSaveDBSettings";
            this.bSaveDBSettings.Size = new System.Drawing.Size(101, 23);
            this.bSaveDBSettings.TabIndex = 6;
            this.bSaveDBSettings.Text = "Сохранить";
            this.bSaveDBSettings.UseVisualStyleBackColor = true;
            // 
            // bCancelDbSettings
            // 
            this.bCancelDbSettings.Location = new System.Drawing.Point(220, 225);
            this.bCancelDbSettings.Name = "bCancelDbSettings";
            this.bCancelDbSettings.Size = new System.Drawing.Size(104, 23);
            this.bCancelDbSettings.TabIndex = 7;
            this.bCancelDbSettings.Text = "Отменить";
            this.bCancelDbSettings.UseVisualStyleBackColor = true;
            // 
            // FormDBSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 275);
            this.Controls.Add(this.bCancelDbSettings);
            this.Controls.Add(this.bSaveDBSettings);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelDBName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelSrvName);
            this.Controls.Add(this.textBox1);
            this.Name = "FormDBSettings";
            this.Text = "Настройки БД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSrvName;
        private System.Windows.Forms.Label labelDBName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button bSaveDBSettings;
        private System.Windows.Forms.Button bCancelDbSettings;
    }
}