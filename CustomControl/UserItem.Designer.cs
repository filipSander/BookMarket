
namespace BookMarket.CustomControl
{
    partial class UserItem
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.login = new System.Windows.Forms.Label();
            this.acclevel = new System.Windows.Forms.Label();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.Azure;
            this.login.Location = new System.Drawing.Point(19, 16);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(40, 17);
            this.login.TabIndex = 0;
            this.login.Text = "Login";
            this.login.MouseEnter += new System.EventHandler(this.acclevel_MouseEnter);
            this.login.MouseLeave += new System.EventHandler(this.bg_MouseLeave);
            // 
            // acclevel
            // 
            this.acclevel.AutoSize = true;
            this.acclevel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acclevel.ForeColor = System.Drawing.Color.Azure;
            this.acclevel.Location = new System.Drawing.Point(298, 16);
            this.acclevel.Name = "acclevel";
            this.acclevel.Size = new System.Drawing.Size(67, 17);
            this.acclevel.TabIndex = 2;
            this.acclevel.Text = "levelAcces";
            this.acclevel.MouseEnter += new System.EventHandler(this.acclevel_MouseEnter);
            this.acclevel.MouseLeave += new System.EventHandler(this.bg_MouseLeave);
            // 
            // DeleteUser
            // 
            this.DeleteUser.FlatAppearance.BorderSize = 0;
            this.DeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.DeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUser.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUser.Location = new System.Drawing.Point(493, 0);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(82, 50);
            this.DeleteUser.TabIndex = 3;
            this.DeleteUser.Text = "Удалить";
            this.DeleteUser.UseVisualStyleBackColor = true;
            this.DeleteUser.MouseEnter += new System.EventHandler(this.acclevel_MouseEnter);
            this.DeleteUser.MouseLeave += new System.EventHandler(this.bg_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 1);
            this.panel1.TabIndex = 8;
            // 
            // A7userItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.acclevel);
            this.Controls.Add(this.DeleteUser);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "A7userItem";
            this.Size = new System.Drawing.Size(575, 50);
            this.MouseEnter += new System.EventHandler(this.acclevel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.bg_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label acclevel;
        public System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Panel panel1;
    }
}
