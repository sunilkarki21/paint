
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
using System.Text.RegularExpressions;

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
        Boolean hasDrawOrMoveValue = false;
        int loopCounter = 0;
        Validation validate;
        String line = "";
        public int radius = 0;
        public int width = 0;
        public int height = 0;
        public int dSize = 0;
        public int counter = 0;

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


        private void btn_run_Click(object sender, EventArgs e)
        {
            hasDrawOrMoveValue = false;
            if (textBox1.Text != null && textBox1.Text != "")
            {
                validate = new Validation(textBox1);
                if (!validate.isSomethingInvalid)
                {
                    MessageBox.Show("Everything is working fine");
                    loadCommand();
                }

            }
        }
        private void loadCommand()
        {
            int numberOfLines = textBox1.Lines.Length;

            for (int i = 0; i < numberOfLines; i++)
            {
                String oneLineCommand = textBox1.Lines[i];
                oneLineCommand = oneLineCommand.Trim();
                if (!oneLineCommand.Equals(""))
                {
                    Boolean hasDrawto = Regex.IsMatch(oneLineCommand.ToLower(), @"\bdrawto\b");
                    Boolean hasMoveto = Regex.IsMatch(oneLineCommand.ToLower(), @"\bmoveto\b");
                    if (hasDrawto || hasMoveto)
                    {
                        String args = oneLineCommand.Substring(6, (oneLineCommand.Length - 6));
                        String[] parms = args.Split(',');
                        for (int j = 0; j < parms.Length; j++)
                        {
                            parms[j] = parms[j].Trim();
                        }
                        cX = int.Parse(parms[0]);
                        cY = int.Parse(parms[1]);
                        hasDrawOrMoveValue = true;
                    }
                    else
                    {
                        hasDrawOrMoveValue = false;
                    }
                    if (hasMoveto)
                    {
                        Pcanvas.Refresh();
                    }
                }
            }

            for (loopCounter = 0; loopCounter < numberOfLines; loopCounter++)
            {
                String oneLineCommand = textBox1.Lines[loopCounter];
                oneLineCommand = oneLineCommand.Trim();
                if (!oneLineCommand.Equals(""))
                {
                    RunCommand(oneLineCommand);
                }

            }
        }

        private void RunCommand(String oneLineCommand)
        {

            Boolean hasPlus = oneLineCommand.Contains('+');
            Boolean hasEquals = oneLineCommand.Contains("=");
            if (hasEquals)
            {
                oneLineCommand = Regex.Replace(oneLineCommand, @"\s+", " ");
                string[] words = oneLineCommand.Split(' ');
                //removing white spaces in between words
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].Trim();
                }
                String firstWord = words[0].ToLower();
                if (firstWord.Equals("if"))
                {
                    Boolean loop = false;
                    if (words[1].ToLower().Equals("radius"))
                    {
                        if (radius == int.Parse(words[3]))
                        {
                            loop = true;
                        }
                    }
                    else if (words[1].ToLower().Equals("width"))
                    {
                        if (width == int.Parse(words[3]))
                        {
                            loop = true;
                        }
                    }
                    else if (words[1].ToLower().Equals("height"))
                    {
                        if (height == int.Parse(words[3]))
                        {
                            loop = true;
                        }

                    }
                    else if (words[1].ToLower().Equals("counter"))
                    {
                        if (counter == int.Parse(words[3]))
                        {
                            loop = true;
                        }
                    }
                    int ifStartLine = (GetIfStartLineNumber());
                    int ifEndLine = (GetEndifEndLineNumber() - 1);
                    loopCounter = ifEndLine;
                    if (loop)
                    {
                        for (int j = ifStartLine; j <= ifEndLine; j++)
                        {
                            string oneLineCommand1 = textBox1.Lines[j];
                            oneLineCommand1 = oneLineCommand1.Trim();
                            if (!oneLineCommand1.Equals(""))
                            {
                                RunCommand(oneLineCommand1);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("If Statement is false");
                    }
                }
                else
                {
                    string[] words2 = oneLineCommand.Split('=');
                    for (int j = 0; j < words2.Length; j++)
                    {
                        words2[j] = words2[j].Trim();
                    }
                    if (words2[0].ToLower().Equals("radius"))
                    {
                        radius = int.Parse(words2[1]);
                    }
                    else if (words2[0].ToLower().Equals("width"))
                    {
                        width = int.Parse(words2[1]);
                    }
                    else if (words2[0].ToLower().Equals("height"))
                    {
                        height = int.Parse(words2[1]);
                    }
                    else if (words2[0].ToLower().Equals("counter"))
                    {
                        counter = int.Parse(words2[1]);
                    }
                }
            }
            else if (hasPlus)
            {
                oneLineCommand = System.Text.RegularExpressions.Regex.Replace(oneLineCommand, @"\s+", " ");
                string[] words = oneLineCommand.Split(' ');
                if (words[0].ToLower().Equals("repeat"))
                {
                    counter = int.Parse(words[1]);
                    if (words[2].ToLower().Equals("circle"))
                    {
                        int increaseValue = GetSize(oneLineCommand);
                        radius = increaseValue;
                        for (int j = 0; j < counter; j++)
                        {
                            DrawCircle(radius);
                            radius += increaseValue;
                        }
                    }
                    else if (words[2].ToLower().Equals("rectangle"))
                    {
                        int increaseValue = GetSize(oneLineCommand);
                        dSize = increaseValue;
                        for (int j = 0; j < counter; j++)
                        {
                            DrawRectangle(dSize, dSize);
                            dSize += increaseValue;
                        }
                    }
                    else if (words[2].ToLower().Equals("triangle"))
                    {
                        int increaseValue = GetSize(oneLineCommand);
                        dSize = increaseValue;
                        for (int j = 0; j < counter; j++)
                        {
                            DrawTriangle(dSize, dSize, dSize);
                            dSize += increaseValue;
                        }
                    }
                }
                else
                {
                    string[] words2 = oneLineCommand.Split('+');
                    for (int j = 0; j < words2.Length; j++)
                    {
                        words2[j] = words2[j].Trim();
                    }
                    if (words2[0].ToLower().Equals("radius"))
                    {
                        radius += int.Parse(words2[1]);
                    }
                    else if (words2[0].ToLower().Equals("width"))
                    {
                        width += int.Parse(words2[1]);
                    }
                    else if (words2[0].ToLower().Equals("height"))
                    {
                        height += int.Parse(words2[1]);
                    }
                }
            }
            else
            {
                sendDrawCommand(oneLineCommand);
            }


        }

        private int GetEndifEndLineNumber()
        {
            int numberOfLines = textBox1.Lines.Length;
            int lineNum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                String oneLineCommand = textBox1.Lines[i];
                oneLineCommand = oneLineCommand.Trim();
                if (oneLineCommand.ToLower().Equals("endif"))
                {
                    lineNum = i + 1;

                }
            }
            return lineNum;
        }

        private int GetIfStartLineNumber()
        {
            int numberOfLines = textBox1.Lines.Length;
            int lineNum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                String oneLineCommand = textBox1.Lines[i];
                oneLineCommand = Regex.Replace(oneLineCommand, @"\s+", " ");
                string[] words = oneLineCommand.Split(' ');
                //removing white spaces in between words
                for (int j = 0; j < words.Length; j++)
                {
                    words[j] = words[j].Trim();
                }
                String firstWord = words[0].ToLower();
                oneLineCommand = oneLineCommand.Trim();
                if (firstWord.Equals("if"))
                {
                    lineNum = i + 1;

                }
            }
            return lineNum;
        }

        private int GetLoopEndLineNumber()
        {
            int numberOfLines = textBox1.Lines.Length;
            int lineNum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                String oneLineCommand = textBox1.Lines[i];
                oneLineCommand = oneLineCommand.Trim();
                if (oneLineCommand.ToLower().Equals("endloop"))
                {
                    lineNum = i + 1;

                }
            }
            return lineNum;
        }

        private int GetLoopStartLineNumber()
        {
            int numberOfLines = textBox1.Lines.Length;
            int lineNum = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                String oneLineCommand = textBox1.Lines[i];
                oneLineCommand = Regex.Replace(oneLineCommand, @"\s+", " ");
                string[] words = oneLineCommand.Split(' ');
                //removing white spaces in between words
                for (int j = 0; j < words.Length; j++)
                {
                    words[j] = words[j].Trim();
                }
                String firstWord = words[0].ToLower();
                oneLineCommand = oneLineCommand.Trim();
                if (firstWord.Equals("loop"))
                {
                    lineNum = i + 1;

                }
            }
            return lineNum;

        }

        private int GetSize(string lineCommand)
        {
            int value = 0;
            if (lineCommand.ToLower().Contains("radius"))
            {
                int pos = (lineCommand.IndexOf("radius") + 6);
                int size = lineCommand.Length;
                String tempLine = lineCommand.Substring(pos, (size - pos));
                tempLine = tempLine.Trim();
                String newTempLine = tempLine.Substring(1, (tempLine.Length - 1));
                newTempLine = newTempLine.Trim();
                value = int.Parse(newTempLine);

            }
            else if (lineCommand.ToLower().Contains("size"))
            {
                int pos = (lineCommand.IndexOf("size") + 4);
                int size = lineCommand.Length;
                String tempLine = lineCommand.Substring(pos, (size - pos));
                tempLine = tempLine.Trim();
                String newTempLine = tempLine.Substring(1, (tempLine.Length - 1));
                newTempLine = newTempLine.Trim();
                value = int.Parse(newTempLine);
            }
            return value;
        }

        private void sendDrawCommand(string lineOfCommand)
        {
            String[] shapes = { "circle", "rectangle", "triangle", "polygon" };
            String[] variable = { "radius", "width", "height", "counter", "size" };

            lineOfCommand = System.Text.RegularExpressions.Regex.Replace(lineOfCommand, @"\s+", " ");
            string[] words = lineOfCommand.Split(' ');
            //removing white spaces in between words
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
            }
            String firstWord = words[0].ToLower();
            Boolean firstWordShape = shapes.Contains(firstWord);
            if (firstWordShape)
            {

                if (firstWord.Equals("circle"))
                {
                    Boolean secondWordIsVariable = variable.Contains(words[1].ToLower());
                    if (secondWordIsVariable)
                    {
                        if (words[1].ToLower().Equals("radius"))
                        {
                            DrawCircle(radius);
                        }
                    }
                    else
                    {
                        DrawCircle(Int32.Parse(words[1]));
                    }

                }
                else if (firstWord.Equals("rectangle"))
                {
                    String args = lineOfCommand.Substring(9, (lineOfCommand.Length - 9));
                    String[] parms = args.Split(',');
                    for (int i = 0; i < parms.Length; i++)
                    {
                        parms[i] = parms[i].Trim();
                    }
                    Boolean secondWordIsVariable = variable.Contains(parms[0].ToLower());
                    Boolean thirdWordIsVariable = variable.Contains(parms[1].ToLower());
                    if (secondWordIsVariable)
                    {
                        if (thirdWordIsVariable)
                        {
                            DrawRectangle(width, height);
                        }
                        else
                        {
                            DrawRectangle(width, Int32.Parse(parms[1]));
                        }

                    }
                    else
                    {
                        if (thirdWordIsVariable)
                        {
                            DrawRectangle(Int32.Parse(parms[0]), height);
                        }
                        else
                        {
                            DrawRectangle(Int32.Parse(parms[0]), Int32.Parse(parms[1]));
                        }
                    }
                }
                else if (firstWord.Equals("triangle"))
                {
                    String args = lineOfCommand.Substring(8, (lineOfCommand.Length - 8));
                    String[] parms = args.Split(',');
                    for (int i = 0; i < parms.Length; i++)
                    {
                        parms[i] = parms[i].Trim();
                    }
                    DrawTriangle(Int32.Parse(parms[0]), Int32.Parse(parms[1]), Int32.Parse(parms[2]));
                }
                else if (firstWord.Equals("polygon"))
                {
                    String args = lineOfCommand.Substring(8, (lineOfCommand.Length - 8));
                    String[] parms = args.Split(',');
                    for (int i = 0; i < parms.Length; i++)
                    {
                        parms[i] = parms[i].Trim();
                    }
                    if (parms.Length == 8)
                    {
                        DrawPolygon(Int32.Parse(parms[0]), Int32.Parse(parms[1]), Int32.Parse(parms[2]), Int32.Parse(parms[3]),
                            Int32.Parse(parms[4]), Int32.Parse(parms[5]), Int32.Parse(parms[6]), Int32.Parse(parms[7]));
                    }
                    else if (parms.Length == 10)
                    {
                        DrawPolygon(Int32.Parse(parms[0]), Int32.Parse(parms[1]), Int32.Parse(parms[2]), Int32.Parse(parms[3]),
                            Int32.Parse(parms[4]), Int32.Parse(parms[5]), Int32.Parse(parms[6]), Int32.Parse(parms[7]),
                            Int32.Parse(parms[8]), Int32.Parse(parms[9]));
                    }

                }

            }
            else
            {
                if (firstWord.Equals("loop"))
                {
                    counter = int.Parse(words[1]);
                    int loopStartLine = (GetLoopStartLineNumber());
                    int loopEndLine = (GetLoopEndLineNumber() - 1);
                    loopCounter = loopEndLine;
                    for (int i = 0; i < counter; i++)
                    {
                        for (int j = loopStartLine; j <= loopEndLine; j++)
                        {
                            String oneLineCommand = textBox1.Lines[j];
                            oneLineCommand = oneLineCommand.Trim();
                            if (!oneLineCommand.Equals(""))
                            {
                                RunCommand(oneLineCommand);
                            }
                        }
                    }
                }
                else if (firstWord.Equals("if"))
                {
                    Boolean loop = false;
                    if (words[1].ToLower().Equals("radius"))
                    {
                        if (radius == int.Parse(words[1]))
                        {
                            loop = true;
                        }
                    }
                    else if (words[1].ToLower().Equals("width"))
                    {
                        if (width == int.Parse(words[1]))
                        {
                            loop = true;
                        }
                    }
                    else if (words[1].ToLower().Equals("height"))
                    {
                        if (height == int.Parse(words[1]))
                        {
                            loop = true;
                        }

                    }
                    else if (words[1].ToLower().Equals("counter"))
                    {
                        if (counter == int.Parse(words[1]))
                        {
                            loop = true;
                        }
                    }
                    int ifStartLine = (GetIfStartLineNumber());
                    int ifEndLine = (GetEndifEndLineNumber() - 1);
                    loopCounter = ifEndLine;
                    if (loop)
                    {
                        for (int j = ifStartLine; j <= ifEndLine; j++)
                        {
                            String oneLineCommand = textBox1.Lines[j];
                            oneLineCommand = oneLineCommand.Trim();
                            if (!oneLineCommand.Equals(""))
                            {
                                RunCommand(oneLineCommand);
                            }
                        }
                    }
                }
            }
        }

        private void DrawPolygon(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8)
        {
            Pen myPen = new Pen(color);
            Point[] pnt = new Point[5];

            pnt[0].X = cX;
            pnt[0].Y = cY;

            pnt[1].X = cX - v1;
            pnt[1].Y = cY - v2;

            pnt[2].X = cX - v3;
            pnt[2].Y = cY - v4;

            pnt[3].X = cX - v5;
            pnt[3].Y = cY - v6;

            pnt[4].X = cX - v7;
            pnt[4].Y = cY - v8;

            g.DrawPolygon(myPen, pnt);
        }

        private void DrawPolygon(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9, int v10)
        {
            Pen myPen = new Pen(color);
            Point[] pnt = new Point[6];

            pnt[0].X = cX;
            pnt[0].Y = cY;

            pnt[1].X = cX - v1;
            pnt[1].Y = cY - v2;

            pnt[2].X = cX - v3;
            pnt[2].Y = cY - v4;

            pnt[3].X = cX - v5;
            pnt[3].Y = cY - v6;

            pnt[4].X = cX - v7;
            pnt[4].Y = cY - v8;

            pnt[5].X = cX - v9;
            pnt[5].Y = cY - v10;
            g.DrawPolygon(myPen, pnt);
        }
        private void DrawTriangle(int rBase, int adj, int hyp)
        {
            Pen myPen = new Pen(color);
            Point[] pnt = new Point[3];

            pnt[0].X = cX;
            pnt[0].Y = cY;

            pnt[1].X = cX - rBase;
            pnt[1].Y = cY;

            pnt[2].X = cX;
            pnt[2].Y = cY - adj;
            g.DrawPolygon(myPen, pnt);
        }
        private void DrawRectangle(int width, int height)
        {
            Pen myPen = new Pen(color);
            g.DrawRectangle(myPen, cX - width / 2, cY - height / 2, width, height);
        }

        private void DrawCircle(int radius)
        {
            Pen myPen = new Pen(color);
            g.DrawEllipse(myPen, cX - radius, cY - radius, radius * 2, radius * 2);
        }

    }
}
