using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BookMarket.CustomControl
{

    public partial class Style : Component
    {
        #region -- Конструкторы --
            public Style()
            {
                InitializeComponent();
            }


            public Style(IContainer container)
            {
                container.Add(this);
                InitializeComponent();
            }
        #endregion
        #region -- Свойства элемента --
            private fStyle formStyle = fStyle.FullButton;
            public enum fStyle
            {
                FullButton,
                halfButton,
                SinglButton
            }
            public Form form;
            public Form Form { get => form; set { form = value; } }
            public fStyle FormStyle {
                get => formStyle;
                set { formStyle = value; Sign(); }
        }
            public Color _BorderLineColor = Color.DarkSlateGray;
            public Color BorderLineColor
            {
                get => _BorderLineColor;
                set { _BorderLineColor = value; }
            }
        #endregion

        private int headerHeight = 33;
        private void Form_Load(object sender, EventArgs e) => Init();
        private void Sign()
        {
            if(Form != null)
                Form.Load += Form_Load;
        }
        
        private void Init()
        {
            SF.Alignment = StringAlignment.Near;
            SF.LineAlignment = StringAlignment.Center;
            Form.FormBorderStyle = FormBorderStyle.None;
            OfsetControls();

            _style();           
            headerPanel.MouseMove += header_MouseMove;
            headerPanel.MouseDoubleClick += header_MouseDoubleClick;
            headerPanel.MouseDown += header_MouseDown;
        }
        private void OfsetControls()
        {
            Form.Height += headerHeight + 5;
            foreach(Control c in Form.Controls)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + headerHeight + 5);
                c.Refresh();
            }
        }

        #region -- Функционал формы --

        private void header_MouseDoubleClick(object sender, MouseEventArgs e) => resize();
        Point lastPoint;
        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            if (Form.Top <= 0 && maxSize)
            {
                resize();
                Form.Top = e.Y;
                Form.Left = e.X + (Form.Width / 2);
            }
            else lastPoint = new Point(e.X, e.Y);
        }
        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Form.Left += e.X - lastPoint.X;
                Form.Top += e.Y - lastPoint.Y;
                if (Form.Top <= -15 && !maxSize) resize();
            }
        }
        bool maxSize = false;
        private void resize()
        {
            if (formStyle == fStyle.FullButton)
            {
                Form.WindowState = maxSize ? FormWindowState.Normal : FormWindowState.Maximized;
                maxSize = !maxSize;
            }
        }
        #endregion
        #region -- Стилизация --

        Panel headerPanel,closeButtPanel, resizeButtPanel, hideButtPanel, borderLinePanel; 
        StringFormat SF = new StringFormat();
        Color BG = Color.FromArgb(30, 0, 0, 0);
        Pen whitePen = new Pen(Color.Azure) { Width = 1.55F };

        private void _style()
        {
            headerPanel = new Panel { Height = headerHeight,Dock = DockStyle.Top };
            borderLinePanel = new Panel { Height = 5,Dock = DockStyle.Top,BackColor = _BorderLineColor };
            closeButtPanel = new Panel { Height = headerHeight,Width = headerHeight,Dock = DockStyle.Right,Tag = "0" };
            resizeButtPanel = new Panel { Height = headerHeight,Width = headerHeight,Dock = DockStyle.Right,Tag = "1"};
            hideButtPanel = new Panel { Height = headerHeight,Width = headerHeight,Dock = DockStyle.Right,Tag = "2" };

            headerPanel.Paint += HeaderPanel_Paint;
            hideButtPanel.Paint += HideButtPanel_Paint;
            resizeButtPanel.Paint += ResizeButtPanel_Paint;
            closeButtPanel.Paint += CloseButtPanel_Paint;

            closeButtPanel.MouseEnter += iconButt_MouseEnter;
            hideButtPanel.MouseEnter += iconButt_MouseEnter;
            resizeButtPanel.MouseEnter += iconButt_MouseEnter;

            closeButtPanel.MouseLeave += iconButt_MouseLeave;
            hideButtPanel.MouseLeave += iconButt_MouseLeave;
            resizeButtPanel.MouseLeave += iconButt_MouseLeave;

            closeButtPanel.Click += iconButt_Click;
            hideButtPanel.Click += iconButt_Click;
            resizeButtPanel.Click += iconButt_Click;


            if (formStyle == fStyle.FullButton || formStyle == fStyle.halfButton) headerPanel.Controls.Add(hideButtPanel);
            if (formStyle == fStyle.FullButton) headerPanel.Controls.Add(resizeButtPanel);
            headerPanel.Controls.Add(closeButtPanel);

            Form.Controls.Add(borderLinePanel);
            Form.Controls.Add(headerPanel);
        }

        public virtual void iconButt_Click(object sender, EventArgs e)
        {
            switch((sender as Panel).Tag.ToString())
            {
                case "0": Form.Close(); break;
                case "1": resize(); break;
                case "2": Form.WindowState = FormWindowState.Minimized; break;
            }
        }
        private void iconButt_MouseLeave(object sender, EventArgs e) => (sender as Panel).BackColor = Form.BackColor;
        private void iconButt_MouseEnter(object sender, EventArgs e)
        {
            if ((sender as Panel).Tag.ToString() == "0")
                (sender as Panel).BackColor = Color.Red;
            else (sender as Panel).BackColor = BG;

        }
        #region -- Рисование UI элементов --
        private void CloseButtPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle closeButtonCrosshair = new Rectangle(
                closeButtPanel.Width / 2 - 5,
                closeButtPanel.Height / 2 - 5,
                10, 10);
            DrawCrosshair(e.Graphics, closeButtonCrosshair, whitePen);
        }
        private void ResizeButtPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle resizeButtonRect = new Rectangle(
                 resizeButtPanel.Width / 2 - 5,
                resizeButtPanel.Height / 2 - 5,
                10, 10);
            e.Graphics.DrawRectangle(whitePen, resizeButtonRect);
        }
        private void HideButtPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle hideButtonLine = new Rectangle(
                hideButtPanel.Width / 2 - 5,
                hideButtPanel.Height / 2 - 5,
                10, 10);
            e.Graphics.DrawLine(whitePen, hideButtonLine.X, hideButtonLine.Y + hideButtonLine.Width, hideButtonLine.X + hideButtonLine.Width, hideButtonLine.Y + hideButtonLine.Width);
        }
        private void HeaderPanel_Paint(object sender, PaintEventArgs e)
        {
            Rectangle title = new Rectangle(headerPanel.Location.X + 10, headerPanel.Location.Y, headerPanel.Width, headerPanel.Height);
            e.Graphics.DrawString(Form.Text, new Font("Segoe UI", 12F, FontStyle.Bold), new SolidBrush(Color.Azure), title, SF);
        }
        private void DrawCrosshair(Graphics g, Rectangle r, Pen p)
        {
            g.DrawLine(p, r.X, r.Y, r.X + r.Width, r.Y + r.Height);
            g.DrawLine(p, r.X + r.Width, r.Y, r.X, r.Y + r.Height);
        }
        #endregion
        #endregion
    }
}
