
namespace BookMarket
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.wrapper = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.workArea = new System.Windows.Forms.Panel();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuItem7 = new BookMarket.CustomControl.MenuItem();
            this.menuItem6 = new BookMarket.CustomControl.MenuItem();
            this.menuItem5 = new BookMarket.CustomControl.MenuItem();
            this.menuItem4 = new BookMarket.CustomControl.MenuItem();
            this.menuItem3 = new BookMarket.CustomControl.MenuItem();
            this.menuItem2 = new BookMarket.CustomControl.MenuItem();
            this.menuItem1 = new BookMarket.CustomControl.MenuItem();
            this.statusBar = new System.Windows.Forms.Panel();
            this.partDescr = new System.Windows.Forms.Label();
            this.spPart = new System.Windows.Forms.Label();
            this.spData = new System.Windows.Forms.Label();
            this.accessLvl = new System.Windows.Forms.Label();
            this.DescripteionAcc = new System.Windows.Forms.Label();
            this.style1 = new BookMarket.CustomControl.Style(this.components);
            this.wrapper.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.wrapper.Controls.Add(this.mainPanel);
            this.wrapper.Cursor = System.Windows.Forms.Cursors.Default;
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Size = new System.Drawing.Size(984, 761);
            this.wrapper.TabIndex = 5;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.mainPanel.Controls.Add(this.workArea);
            this.mainPanel.Controls.Add(this.sidebar);
            this.mainPanel.Controls.Add(this.statusBar);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(984, 761);
            this.mainPanel.TabIndex = 3;
            // 
            // workArea
            // 
            this.workArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.workArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workArea.Location = new System.Drawing.Point(322, 0);
            this.workArea.Name = "workArea";
            this.workArea.Size = new System.Drawing.Size(662, 742);
            this.workArea.TabIndex = 3;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.menuItem6);
            this.sidebar.Controls.Add(this.menuItem5);
            this.sidebar.Controls.Add(this.menuItem4);
            this.sidebar.Controls.Add(this.menuItem3);
            this.sidebar.Controls.Add(this.menuItem2);
            this.sidebar.Controls.Add(this.menuItem1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(322, 742);
            this.sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuItem7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 682);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 60);
            this.panel1.TabIndex = 6;
            // 
            // menuItem7
            // 
            this.menuItem7.Active = false;
            this.menuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.menuItem7.Icon = null;
            this.menuItem7.Location = new System.Drawing.Point(0, 0);
            this.menuItem7.Name = "menuItem7";
            this.menuItem7.Size = new System.Drawing.Size(320, 60);
            this.menuItem7.TabIndex = 7;
            this.menuItem7.Title = "Администрирование приложения ";
            this.menuItem7.Visible = false;
            // 
            // menuItem6
            // 
            this.menuItem6.Active = false;
            this.menuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.menuItem6.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem6.Icon")));
            this.menuItem6.Location = new System.Drawing.Point(0, 300);
            this.menuItem6.Name = "menuItem6";
            this.menuItem6.Size = new System.Drawing.Size(320, 60);
            this.menuItem6.TabIndex = 5;
            this.menuItem6.Title = "Статистика продаж";
            this.menuItem6.Visible = false;
            // 
            // menuItem5
            // 
            this.menuItem5.Active = false;
            this.menuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.menuItem5.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem5.Icon")));
            this.menuItem5.Location = new System.Drawing.Point(0, 240);
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(320, 60);
            this.menuItem5.TabIndex = 4;
            this.menuItem5.Title = "Статистика прихода";
            this.menuItem5.Visible = false;
            // 
            // menuItem4
            // 
            this.menuItem4.Active = false;
            this.menuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.menuItem4.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem4.Icon")));
            this.menuItem4.Location = new System.Drawing.Point(0, 180);
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(320, 60);
            this.menuItem4.TabIndex = 3;
            this.menuItem4.Title = "Справочники";
            // 
            // menuItem3
            // 
            this.menuItem3.Active = false;
            this.menuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.menuItem3.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem3.Icon")));
            this.menuItem3.Location = new System.Drawing.Point(0, 120);
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(320, 60);
            this.menuItem3.TabIndex = 2;
            this.menuItem3.Title = "Склад ( Библиотека )";
            // 
            // menuItem2
            // 
            this.menuItem2.Active = false;
            this.menuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.menuItem2.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem2.Icon")));
            this.menuItem2.Location = new System.Drawing.Point(0, 60);
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(320, 60);
            this.menuItem2.TabIndex = 1;
            this.menuItem2.Title = "Продажа товара";
            // 
            // menuItem1
            // 
            this.menuItem1.Active = false;
            this.menuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.menuItem1.Icon = ((System.Drawing.Image)(resources.GetObject("menuItem1.Icon")));
            this.menuItem1.Location = new System.Drawing.Point(0, 0);
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(320, 60);
            this.menuItem1.TabIndex = 0;
            this.menuItem1.Title = "Приход товара";
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(56)))));
            this.statusBar.Controls.Add(this.partDescr);
            this.statusBar.Controls.Add(this.spPart);
            this.statusBar.Controls.Add(this.spData);
            this.statusBar.Controls.Add(this.accessLvl);
            this.statusBar.Controls.Add(this.DescripteionAcc);
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Location = new System.Drawing.Point(0, 742);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(984, 19);
            this.statusBar.TabIndex = 2;
            // 
            // partDescr
            // 
            this.partDescr.AutoSize = true;
            this.partDescr.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescr.ForeColor = System.Drawing.Color.SlateGray;
            this.partDescr.Location = new System.Drawing.Point(323, 0);
            this.partDescr.Name = "partDescr";
            this.partDescr.Size = new System.Drawing.Size(50, 13);
            this.partDescr.TabIndex = 7;
            this.partDescr.Text = "Раздел: ";
            // 
            // spPart
            // 
            this.spPart.AutoSize = true;
            this.spPart.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spPart.ForeColor = System.Drawing.Color.SlateGray;
            this.spPart.Location = new System.Drawing.Point(372, 0);
            this.spPart.Name = "spPart";
            this.spPart.Size = new System.Drawing.Size(27, 13);
            this.spPart.TabIndex = 6;
            this.spPart.Text = "Part";
            // 
            // spData
            // 
            this.spData.AutoSize = true;
            this.spData.Dock = System.Windows.Forms.DockStyle.Right;
            this.spData.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spData.ForeColor = System.Drawing.Color.SlateGray;
            this.spData.Location = new System.Drawing.Point(953, 0);
            this.spData.Name = "spData";
            this.spData.Size = new System.Drawing.Size(31, 13);
            this.spData.TabIndex = 5;
            this.spData.Text = "Data";
            // 
            // accessLvl
            // 
            this.accessLvl.AutoSize = true;
            this.accessLvl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accessLvl.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessLvl.ForeColor = System.Drawing.Color.SlateGray;
            this.accessLvl.Location = new System.Drawing.Point(100, 0);
            this.accessLvl.Name = "accessLvl";
            this.accessLvl.Size = new System.Drawing.Size(76, 13);
            this.accessLvl.TabIndex = 3;
            this.accessLvl.Text = "Identification";
            // 
            // DescripteionAcc
            // 
            this.DescripteionAcc.AutoSize = true;
            this.DescripteionAcc.Dock = System.Windows.Forms.DockStyle.Left;
            this.DescripteionAcc.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripteionAcc.ForeColor = System.Drawing.Color.SlateGray;
            this.DescripteionAcc.Location = new System.Drawing.Point(0, 0);
            this.DescripteionAcc.Name = "DescripteionAcc";
            this.DescripteionAcc.Size = new System.Drawing.Size(100, 13);
            this.DescripteionAcc.TabIndex = 2;
            this.DescripteionAcc.Text = "Уровень доступа: ";
            // 
            // style1
            // 
            this.style1.BorderLineColor = System.Drawing.Color.DarkSlateGray;
            this.style1.Form = this;
            this.style1.FormStyle = BookMarket.CustomControl.Style.fStyle.FullButton;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.wrapper);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжный магазин";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.wrapper.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.Panel sidebar;

        private System.Windows.Forms.Panel statusBar;
        private System.Windows.Forms.Label accessLvl;
        private System.Windows.Forms.Label DescripteionAcc;

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label spData;
        private System.Windows.Forms.Panel workArea;
        private System.Windows.Forms.Label spPart;
        private System.Windows.Forms.Label partDescr;
        private CustomControl.MenuItem menuItem6;
        private CustomControl.MenuItem menuItem5;
        private CustomControl.MenuItem menuItem4;
        private CustomControl.MenuItem menuItem3;
        private CustomControl.MenuItem menuItem2;
        private CustomControl.MenuItem menuItem1;
        private System.Windows.Forms.Panel panel1;
        private CustomControl.MenuItem menuItem7;
        private CustomControl.Style style1;
    }
}