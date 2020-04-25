namespace OpenGL2D
{
    partial class Form1
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
            this.holst = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Line = new System.Windows.Forms.ToolStripMenuItem();
            this.Fill = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZero = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // holst
            // 
            this.holst.AccumBits = ((byte)(0));
            this.holst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.holst.AutoCheckErrors = false;
            this.holst.AutoFinish = false;
            this.holst.AutoMakeCurrent = true;
            this.holst.AutoSwapBuffers = true;
            this.holst.BackColor = System.Drawing.Color.Black;
            this.holst.ColorBits = ((byte)(32));
            this.holst.DepthBits = ((byte)(16));
            this.holst.Location = new System.Drawing.Point(-1, 33);
            this.holst.Margin = new System.Windows.Forms.Padding(4);
            this.holst.Name = "holst";
            this.holst.Size = new System.Drawing.Size(913, 809);
            this.holst.StencilBits = ((byte)(0));
            this.holst.TabIndex = 0;
            this.holst.Click += new System.EventHandler(this.Holst_Click);
            this.holst.Paint += new System.Windows.Forms.PaintEventHandler(this.Holst_Paint);
            this.holst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.holst_KeyDown);
            this.holst.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Holst_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line,
            this.Fill});
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // Line
            // 
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(119, 26);
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Fill
            // 
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(119, 26);
            this.Fill.Text = "Fill";
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelX.Location = new System.Drawing.Point(279, 11);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 17);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "X";
            this.labelX.Visible = false;
            this.labelX.Click += new System.EventHandler(this.LabelX_Click);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelY.Location = new System.Drawing.Point(404, 11);
            this.labelY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 17);
            this.labelY.TabIndex = 3;
            this.labelY.Text = "Y";
            this.labelY.Visible = false;
            // 
            // labelZero
            // 
            this.labelZero.AutoSize = true;
            this.labelZero.BackColor = System.Drawing.SystemColors.WindowText;
            this.labelZero.Location = new System.Drawing.Point(535, 9);
            this.labelZero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelZero.Name = "labelZero";
            this.labelZero.Size = new System.Drawing.Size(16, 17);
            this.labelZero.TabIndex = 4;
            this.labelZero.Text = "0";
            this.labelZero.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 804);
            this.Controls.Add(this.labelZero);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.holst);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(927, 851);
            this.MinimumSize = new System.Drawing.Size(927, 851);
            this.Name = "Form1";
            this.Text = "OpenGL2D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl holst;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Line;
        private System.Windows.Forms.ToolStripMenuItem Fill;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZero;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

