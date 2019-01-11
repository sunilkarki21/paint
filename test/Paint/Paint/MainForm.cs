
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using Shapes;

namespace Paint
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        Graphics g;


        Pen p = new Pen(Color.Black, 1);
        Point sp = new Point(0, 0);
        Point ep = new Point(0, 0);
        int k = 0;
        string shape;
        private int cX, cY, x, y, dX, dY;
        Color color;
        ShapeFactory shapeFactory = new ShapeFactory();
        Shape shapes;
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
            color = Color.Black;
        }
        void MainFormMouseUp(object sender, MouseEventArgs e)
        {

        }


        void PcanvasMouseDown(object sender, MouseEventArgs e)
        {
            sp = e.Location;
            if (e.Button == MouseButtons.Left)
            {
                k = 1;
            }
            cX = e.X;
            cY = e.Y;
        }
        void btn_brushClick(object sender, EventArgs e)
        {
            shape = "brush";
        }

        void backcolorClick(object sender, EventArgs e)
        {
            //gets color dialog
            ColorDialog MyDialog = new ColorDialog();

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                backcolor.BackColor = MyDialog.Color;
                color = MyDialog.Color;

            }

        }
        void PcanvasMouseMove(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                ep = e.Location;
                x = e.X;
                y = e.Y;

                if (shape == "pencil")
                {
                    //this.Cursor = Cursors.Default;
                    p.Width = trackBar1.Value;
                    g.DrawLine(new Pen(color, p.Width), sp, ep);
                }
                else if (shape == "eraser")
                {
                    //   this.Cursor = Cursors.No;
                    g.FillRectangle(new SolidBrush(color), e.X, e.Y, 60, 60);


                }
                else if (shape == "brush")
                {

                    g.FillEllipse(new SolidBrush(color), e.X, e.Y, 60, 60);
                }


                sp = ep;
            }
        }
        void PcanvasMouseUp(object sender, MouseEventArgs e)
        {
            k = 0;
        }
        void MainFormLoad(object sender, EventArgs e)
        {
            g = Pcanvas.CreateGraphics();
        }

        void btn_pencilClick(object sender, EventArgs e)
        {
            shape = "pencil";
        }
        void btn_eraseClick(object sender, EventArgs e)
        {
            shape = "eraser";
            color = Color.White;
        }
        void btn_lineClick(object sender, EventArgs e)
        {
            shape = "line";
        }
        void btn_circleClick(object sender, EventArgs e)
        {
            shape = "circle";
        }
        void btn_rectClick(object sender, EventArgs e)
        {
            shape = "rectangle";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Pcanvas.Image = (Image)Image.FromFile(o.FileName).Clone();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Pcanvas.Width, Pcanvas.Height);
            Graphics g = Graphics.FromImage(bmp);
            Rectangle rect = Pcanvas.RectangleToScreen(Pcanvas.ClientRectangle);
            g.CopyFromScreen(rect.Location, Point.Empty, Pcanvas.Size);
            g.Dispose();
            SaveFileDialog s = new SaveFileDialog();
            s.Filter = "Png files|*.png|jpeg files|*jpg|bitmaps|*.bmp";
            if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (File.Exists(s.FileName))
                {
                    File.Delete(s.FileName);
                }
                if (s.FileName.Contains(".jpg"))
                {
                    bmp.Save(s.FileName, ImageFormat.Jpeg);
                }
                else if (s.FileName.Contains(".png"))
                {
                    bmp.Save(s.FileName, ImageFormat.Png);
                }
                else if (s.FileName.Contains(".bmp"))
                {
                    bmp.Save(s.FileName, ImageFormat.Bmp);
                }
                MessageBox.Show("Your File has been saved Sucessfully");

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_triangle_Click(object sender, EventArgs e)
        {
            shape = "triangle";
        }
        void PcanvasMouseClick(object sender, MouseEventArgs e)
        {
            if (k == 1)
            {
                x = e.X;
                y = e.Y;
                dX = e.X - cX;
                dY = e.Y - cY;
                if (shape == "line")
                {
                    g.DrawLine(new Pen(color, p.Width), cX, cY, e.X, e.Y);
                }
                if (shape == "circle")
                {


                    g.DrawEllipse(new Pen(color, p.Width), cX, cY, dX, dY);
                }
                if (shape == "rectangle")
                {

                    shapes = shapeFactory.getShape("RECTANGLE");
                    shapes.SetParam(cX, cY, dX, dY, color);

                    g.DrawRectangle(new Pen(color, p.Width), cX, cY, dX, dY);
                }
                if (shape == "triangle")
                {
                    Pen p = new Pen(color, 40);

                    Point[] pnt = new Point[3];
                    pnt[0].X = cX;
                    pnt[0].Y = cY - trackBar1.Value;

                    pnt[1].X = cX + trackBar1.Value;
                    pnt[1].Y = cY + trackBar1.Value;

                    pnt[2].X = cX - trackBar1.Value;
                    pnt[2].Y = cY + trackBar1.Value;

                    g.DrawPolygon(p, pnt);
                }
                if (shape == "polygon")
                {

                    Point[] pnt = new Point[6];
                    System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(color);


                    pnt[0].X = cX;
                    pnt[0].Y = cY;

                    pnt[1].X = cX + trackBar1.Value + 40;
                    pnt[1].Y = cY;

                    pnt[2].X = cX + trackBar1.Value + 40 + (trackBar1.Value + 40 / 2);
                    pnt[2].Y = cY + trackBar1.Value + 40;

                    pnt[3].X = cX - (trackBar1.Value + 40 / 2);
                    pnt[3].Y = cY + trackBar1.Value + 40;


                    pnt[4].X = cX;
                    pnt[4].Y = cY;
                    

                    g.FillPolygon(myBrush, pnt);

                }
            }
        }

        void btn_clearClick(object sender, EventArgs e)
        {
            Pcanvas.Refresh();
            Pcanvas.Image = null;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value;

        }

        private void btnpoly_Click(object sender, EventArgs e)
        {
            shape = "polygon";
        }
 



    }
}
