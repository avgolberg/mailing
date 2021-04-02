
namespace Mailing__SMTP_
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.themesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addThemeButton = new System.Windows.Forms.Button();
            this.emailsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addMailButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // themesComboBox
            // 
            this.themesComboBox.BackColor = System.Drawing.Color.Snow;
            this.themesComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.themesComboBox.FormattingEnabled = true;
            this.themesComboBox.Location = new System.Drawing.Point(48, 63);
            this.themesComboBox.Name = "themesComboBox";
            this.themesComboBox.Size = new System.Drawing.Size(644, 29);
            this.themesComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(295, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Темы сообщений";
            // 
            // addThemeButton
            // 
            this.addThemeButton.AutoSize = true;
            this.addThemeButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.addThemeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addThemeButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addThemeButton.Location = new System.Drawing.Point(713, 63);
            this.addThemeButton.Name = "addThemeButton";
            this.addThemeButton.Size = new System.Drawing.Size(111, 34);
            this.addThemeButton.TabIndex = 2;
            this.addThemeButton.Text = "Добавить";
            this.addThemeButton.UseVisualStyleBackColor = false;
            this.addThemeButton.Click += new System.EventHandler(this.addThemeButton_Click);
            // 
            // emailsListBox
            // 
            this.emailsListBox.BackColor = System.Drawing.Color.Snow;
            this.emailsListBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailsListBox.FormattingEnabled = true;
            this.emailsListBox.ItemHeight = 21;
            this.emailsListBox.Location = new System.Drawing.Point(475, 207);
            this.emailsListBox.Name = "emailsListBox";
            this.emailsListBox.Size = new System.Drawing.Size(347, 361);
            this.emailsListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(513, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Список электронных почт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(74, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Электронная почта";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(48, 209);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(246, 30);
            this.emailTextBox.TabIndex = 6;
            // 
            // addMailButton
            // 
            this.addMailButton.AutoSize = true;
            this.addMailButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.addMailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMailButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMailButton.Location = new System.Drawing.Point(309, 207);
            this.addMailButton.Name = "addMailButton";
            this.addMailButton.Size = new System.Drawing.Size(111, 34);
            this.addMailButton.TabIndex = 7;
            this.addMailButton.Text = "Добавить";
            this.addMailButton.UseVisualStyleBackColor = false;
            this.addMailButton.Click += new System.EventHandler(this.addMailButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.AutoSize = true;
            this.sendButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.sendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(88, 522);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(175, 46);
            this.sendButton.TabIndex = 8;
            this.sendButton.Text = "Отправить всем";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(862, 607);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.addMailButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailsListBox);
            this.Controls.Add(this.addThemeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.themesComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox themesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addThemeButton;
        private System.Windows.Forms.ListBox emailsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button addMailButton;
        private System.Windows.Forms.Button sendButton;
    }
}

