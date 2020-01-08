using System.Drawing;

namespace DragDropKruume
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 444);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            this.pictureBox1.MouseMove += PictureBox1_MouseMove;
            this.pictureBox1.MouseUp += PictureBox1_MouseUp;
            this.pictureBox1.MouseDown += PictureBox1_MouseDown;
            this.pictureBox1.Paint += PictureBox1_Paint;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(61, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(351, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 56);
            this.label2.TabIndex = 2;
            this.label2.Text = "Форма";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(630, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 56);
            this.label3.TabIndex = 3;
            this.label3.Text = "Информация";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void PictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (click1)
            {
                
                Rectangle.X = e.X - rectangleX;
                Rectangle.Y = e.Y - rectangleY;
                pictureBox1.Invalidate();
            }
            if (click2)
            {
                Circle.X = e.X - CircleX;
                Circle.Y = e.Y - CircleY;
                pictureBox1.Invalidate();
            }
            if (click3)
            {
                Square.X = e.X - SquareX;
                Square.Y = e.Y - SquareY;
                pictureBox1.Invalidate();
            }
        }

        private void PictureBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            click1 = false;
            click2 = false;
            click3 = false;
            if (LastClicked == 1)
            {
                if ((label2.Location.X < Rectangle.X + Rectangle.Width) && (label2.Location.X > Rectangle.X))
                {
                    if ((label2.Location.Y < Rectangle.Y + Rectangle.Height) && (label2.Location.Y > Rectangle.Y))
                    {
                        X = Rectangle.X;
                        Y = Rectangle.Y;
                        dX = rectangleX;
                        dY = rectangleY;
                        Rectangle.X = Square.X;
                        Rectangle.Y = SquareY;
                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }

            if (LastClicked == 2)
            {
                if((label2.Location.X < Circle.X + Circle.Width) && (label2.Location.X > Circle.X))
                {
                    if((label2.Location.Y < Circle.Y + Circle.Height) && (label2.Location.Y > Circle.Y))
                    {
                        X = Circle.X;
                        Y = Circle.Y;
                        dX = CircleX;
                        dY = CircleY;
                        Circle.X = Square.X;
                        Circle.Y = SquareY;
                        Square.X = X;
                        Square.Y = Y;
                        SquareX = dX;
                        SquareY = dY;
                    }
                }
            }
            if (LastClicked == 3)
            {
                if ((label2.Location.X < Square.X + Square.Width) && (label2.Location.X > Square.X))
                {
                    if ((label2.Location.Y < Square.Y + Square.Height) && (label2.Location.Y > Square.Y))
                    {
                        X = Square.X;
                        Y = Square.Y;
                        dX = SquareX;
                        dY = SquareY;
                        Square.X = Circle.X;
                        Square.Y = CircleY;
                        Circle.X = X;
                        Circle.Y = Y;
                        CircleX = dX;
                        CircleY = dY;
                    }
                }
            }

        }

        private void PictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if((e.X < Rectangle.X+Rectangle.Width) && (e.X > Rectangle.X))
            {
                if ((e.Y < Rectangle.Y + Rectangle.Height) && (e.Y > Rectangle.Y))
                {
                    LastClicked = 1;
                    click1 = true;
                    rectangleX = e.X - Rectangle.X;
                    CirlceY = e.Y - Rectangle.Y;

                }
            }
            if ((e.X < Circle.X + Circle.Width) && (e.X > Circle.X))
            {
                if ((e.Y < Circle.Y + Circle.Height) && (e.Y > Circle.Y))
                {
                    LastClicked = 2;
                    click2 = true;
                    CircleX = e.X - Circle.X;
                    CircleY = e.Y - Circle.Y;

                }
            }
            if ((e.X < Square.X + Square.Width) && (e.X > Square.X))
            {
                if ((e.Y < Square.Y + Square.Height) && (e.Y > Square.Y))
                {
                    LastClicked = 3;
                    click3 = true;
                    SquareX = e.X - Square.X;
                    SquareY = e.Y - Square.Y;

                }
            }
            if((label1.Location.X < Square.X+Square.Width) && (label1.Location.X > Square.X))
            {
                if((label1.Location.Y < Square.Y + Square.Height)&&(label1.Location.Y > Square.Y))
                {
                    label3.Text = "Синий квадрат";
                }
            }
            if ((label1.Location.X < Circle.X + Circle.Width) && (label1.Location.X > Circle.X))
            {
                if ((label1.Location.Y < Circle.Y + Circle.Height) && (label1.Location.Y > Circle.Y))
                {
                    label3.Text = "Красный круг";
                }
            }
            if ((label1.Location.X < Rectangle.X + Rectangle.Width) && (label1.Location.X > Rectangle.X))
            {
                if ((label1.Location.Y < Rectangle.Y + Rectangle.Height) && (label1.Location.Y > Rectangle.Y))
                {
                    label3.Text = "Желтый триугольник";
                }
            }
        }

        private void PictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
                e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
            if (click1 == true) {
               // e.Graphics.FillRectangle(Brushes.Blue, Square);
               // e.Graphics.FillEllipse(Brushes.Red, Circle);
                e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
            }
            if (click2 == true)
            {
                
                
               // e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                //e.Graphics.FillRectangle(Brushes.Blue, Square);
                e.Graphics.FillEllipse(Brushes.Red, Circle);
            }
            if (click3 == true)
            {

              //  e.Graphics.FillEllipse(Brushes.Red, Circle);
               // e.Graphics.FillRectangle(Brushes.Yellow, Rectangle);
                e.Graphics.FillRectangle(Brushes.Blue, Square);
            }


        }


        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

