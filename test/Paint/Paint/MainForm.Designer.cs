 
namespace Paint
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox Colores;
		private System.Windows.Forms.Button backcolor;
		private System.Windows.Forms.PictureBox Pcanvas;
		private System.Windows.Forms.GroupBox Figuras;
		private System.Windows.Forms.Button btn_line;
		private System.Windows.Forms.Button btn_circle;
		private System.Windows.Forms.Button btn_rect;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_erase;
		private System.Windows.Forms.Button btn_pencil;
		private System.Windows.Forms.Button btn_brush;
		private System.Windows.Forms.Button btn_clear;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Colores = new System.Windows.Forms.GroupBox();
            this.backcolor = new System.Windows.Forms.Button();
            this.Figuras = new System.Windows.Forms.GroupBox();
            this.btnpoly = new System.Windows.Forms.Button();
            this.btn_triangle = new System.Windows.Forms.Button();
            this.btn_circle = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_brush = new System.Windows.Forms.Button();
            this.btn_erase = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.Pcanvas = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_run = new System.Windows.Forms.Button();
            this.Colores.SuspendLayout();
            this.Figuras.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pcanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Colores
            // 
            this.Colores.BackColor = System.Drawing.Color.Transparent;
            this.Colores.Controls.Add(this.backcolor);
            this.Colores.Location = new System.Drawing.Point(12, 39);
            this.Colores.Name = "Colores";
            this.Colores.Size = new System.Drawing.Size(98, 73);
            this.Colores.TabIndex = 0;
            this.Colores.TabStop = false;
            this.Colores.Text = "Colors";
            // 
            // backcolor
            // 
            this.backcolor.BackColor = System.Drawing.Color.Black;
            this.backcolor.Location = new System.Drawing.Point(6, 20);
            this.backcolor.Name = "backcolor";
            this.backcolor.Size = new System.Drawing.Size(65, 53);
            this.backcolor.TabIndex = 0;
            this.backcolor.UseVisualStyleBackColor = false;
            this.backcolor.Click += new System.EventHandler(this.backcolorClick);
            // 
            // Figuras
            // 
            this.Figuras.Controls.Add(this.btnpoly);
            this.Figuras.Controls.Add(this.btn_triangle);
            this.Figuras.Controls.Add(this.btn_circle);
            this.Figuras.Controls.Add(this.btn_rect);
            this.Figuras.Controls.Add(this.btn_line);
            this.Figuras.Location = new System.Drawing.Point(252, 45);
            this.Figuras.Name = "Figuras";
            this.Figuras.Size = new System.Drawing.Size(299, 67);
            this.Figuras.TabIndex = 2;
            this.Figuras.TabStop = false;
            this.Figuras.Text = "Shapes";
            // 
            // btnpoly
            // 
            this.btnpoly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpoly.BackgroundImage")));
            this.btnpoly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpoly.Location = new System.Drawing.Point(223, 14);
            this.btnpoly.Name = "btnpoly";
            this.btnpoly.Size = new System.Drawing.Size(55, 42);
            this.btnpoly.TabIndex = 11;
            this.btnpoly.UseVisualStyleBackColor = true;
            this.btnpoly.Click += new System.EventHandler(this.btnpoly_Click);
            // 
            // btn_triangle
            // 
            this.btn_triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_triangle.BackgroundImage")));
            this.btn_triangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_triangle.Location = new System.Drawing.Point(167, 14);
            this.btn_triangle.Name = "btn_triangle";
            this.btn_triangle.Size = new System.Drawing.Size(49, 42);
            this.btn_triangle.TabIndex = 10;
            this.btn_triangle.UseVisualStyleBackColor = true;
            this.btn_triangle.Click += new System.EventHandler(this.btn_triangle_Click);
            // 
            // btn_circle
            // 
            this.btn_circle.BackColor = System.Drawing.Color.Transparent;
            this.btn_circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_circle.BackgroundImage")));
            this.btn_circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_circle.Location = new System.Drawing.Point(52, 14);
            this.btn_circle.Margin = new System.Windows.Forms.Padding(1);
            this.btn_circle.Name = "btn_circle";
            this.btn_circle.Size = new System.Drawing.Size(53, 42);
            this.btn_circle.TabIndex = 9;
            this.btn_circle.UseVisualStyleBackColor = false;
            this.btn_circle.Click += new System.EventHandler(this.btn_circleClick);
            // 
            // btn_rect
            // 
            this.btn_rect.BackColor = System.Drawing.Color.Transparent;
            this.btn_rect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rect.BackgroundImage")));
            this.btn_rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rect.Location = new System.Drawing.Point(107, 14);
            this.btn_rect.Margin = new System.Windows.Forms.Padding(1);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(55, 42);
            this.btn_rect.TabIndex = 8;
            this.btn_rect.UseVisualStyleBackColor = false;
            this.btn_rect.Click += new System.EventHandler(this.btn_rectClick);
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.Transparent;
            this.btn_line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_line.BackgroundImage")));
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_line.Location = new System.Drawing.Point(4, 14);
            this.btn_line.Margin = new System.Windows.Forms.Padding(1);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(46, 42);
            this.btn_line.TabIndex = 7;
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_lineClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_brush);
            this.groupBox1.Controls.Add(this.btn_erase);
            this.groupBox1.Controls.Add(this.btn_pencil);
            this.groupBox1.Location = new System.Drawing.Point(116, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // btn_brush
            // 
            this.btn_brush.BackColor = System.Drawing.Color.Transparent;
            this.btn_brush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_brush.BackgroundImage")));
            this.btn_brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_brush.Location = new System.Drawing.Point(83, 20);
            this.btn_brush.Margin = new System.Windows.Forms.Padding(1);
            this.btn_brush.Name = "btn_brush";
            this.btn_brush.Size = new System.Drawing.Size(37, 38);
            this.btn_brush.TabIndex = 13;
            this.btn_brush.UseVisualStyleBackColor = false;
            this.btn_brush.Click += new System.EventHandler(this.btn_brushClick);
            // 
            // btn_erase
            // 
            this.btn_erase.BackColor = System.Drawing.Color.Transparent;
            this.btn_erase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_erase.BackgroundImage")));
            this.btn_erase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_erase.Location = new System.Drawing.Point(44, 20);
            this.btn_erase.Margin = new System.Windows.Forms.Padding(1);
            this.btn_erase.Name = "btn_erase";
            this.btn_erase.Size = new System.Drawing.Size(37, 39);
            this.btn_erase.TabIndex = 12;
            this.btn_erase.UseVisualStyleBackColor = false;
            this.btn_erase.Click += new System.EventHandler(this.btn_eraseClick);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.Color.Transparent;
            this.btn_pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_pencil.BackgroundImage")));
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pencil.Location = new System.Drawing.Point(4, 20);
            this.btn_pencil.Margin = new System.Windows.Forms.Padding(1);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(38, 39);
            this.btn_pencil.TabIndex = 10;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencilClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Location = new System.Drawing.Point(794, 45);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(136, 39);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clearClick);
            // 
            // Pcanvas
            // 
            this.Pcanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pcanvas.BackColor = System.Drawing.Color.White;
            this.Pcanvas.Location = new System.Drawing.Point(-566, 118);
            this.Pcanvas.Name = "Pcanvas";
            this.Pcanvas.Size = new System.Drawing.Size(1158, 357);
            this.Pcanvas.TabIndex = 24;
            this.Pcanvas.TabStop = false;
            this.Pcanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PcanvasMouseClick);
            this.Pcanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PcanvasMouseDown);
            this.Pcanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PcanvasMouseMove);
            this.Pcanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PcanvasMouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(557, 56);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(149, 45);
            this.trackBar1.TabIndex = 26;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(599, 118);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 357);
            this.textBox1.TabIndex = 28;
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(957, 138);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 23);
            this.btn_run.TabIndex = 29;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1042, 493);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Pcanvas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Figuras);
            this.Controls.Add(this.Colores);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
            this.Colores.ResumeLayout(false);
            this.Figuras.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pcanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btn_triangle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnpoly;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_run;
    }
}
