
namespace BookMarket
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.question = new System.Windows.Forms.PictureBox();
            this.wrapper = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.bgPanel = new System.Windows.Forms.Panel();
            this.bgPanel0 = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.style1 = new BookMarket.CustomControl.Style(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.question)).BeginInit();
            this.wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.bgPanel0.SuspendLayout();
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.question.Cursor = System.Windows.Forms.Cursors.Default;
            this.question.Image = global::BookMarket.Properties.Resources.qrpng;
            this.question.Location = new System.Drawing.Point(237, 40);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(28, 38);
            this.question.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.question.TabIndex = 6;
            this.question.TabStop = false;
            this.question.Visible = false;
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.wrapper.Controls.Add(this.question);
            this.wrapper.Controls.Add(this.pictureBox2);
            this.wrapper.Controls.Add(this.label1);
            this.wrapper.Controls.Add(this.label2);
            this.wrapper.Controls.Add(this.loginTextBox);
            this.wrapper.Controls.Add(this.buttonApply);
            this.wrapper.Controls.Add(this.bgPanel);
            this.wrapper.Controls.Add(this.bgPanel0);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(434, 200);
            this.wrapper.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::BookMarket.Properties.Resources.Eye;
            this.pictureBox2.Location = new System.Drawing.Point(237, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "showSecond";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(23, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.Color.Azure;
            this.loginTextBox.Location = new System.Drawing.Point(27, 45);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(181, 28);
            this.loginTextBox.TabIndex = 21;
            this.loginTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonApply.FlatAppearance.BorderSize = 0;
            this.buttonApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApply.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApply.Location = new System.Drawing.Point(323, 141);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Padding = new System.Windows.Forms.Padding(2);
            this.buttonApply.Size = new System.Drawing.Size(99, 47);
            this.buttonApply.TabIndex = 44;
            this.buttonApply.Text = "Войти";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buttonApply_KeyDown);
            // 
            // bgPanel
            // 
            this.bgPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bgPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.bgPanel.Location = new System.Drawing.Point(22, 40);
            this.bgPanel.Name = "bgPanel";
            this.bgPanel.Size = new System.Drawing.Size(190, 38);
            this.bgPanel.TabIndex = 8;
            // 
            // bgPanel0
            // 
            this.bgPanel0.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bgPanel0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(71)))));
            this.bgPanel0.Controls.Add(this.passwordTextBox);
            this.bgPanel0.Location = new System.Drawing.Point(22, 118);
            this.bgPanel0.Name = "bgPanel0";
            this.bgPanel0.Size = new System.Drawing.Size(190, 38);
            this.bgPanel0.TabIndex = 9;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Azure;
            this.passwordTextBox.Location = new System.Drawing.Point(5, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(181, 28);
            this.passwordTextBox.TabIndex = 23;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.loginTextBox_TextChanged);
            // 
            // style1
            // 
            this.style1.BorderLineColor = System.Drawing.Color.DarkSlateGray;
            this.style1.Form = this;
            this.style1.FormStyle = BookMarket.CustomControl.Style.fStyle.halfButton;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(434, 200);
            this.Controls.Add(this.wrapper);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.question)).EndInit();
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.bgPanel0.ResumeLayout(false);
            this.bgPanel0.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel bgPanel;
        private System.Windows.Forms.Panel bgPanel0;
        private System.Windows.Forms.PictureBox question;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BookMarket.CustomControl.Style style1;
    }
}

