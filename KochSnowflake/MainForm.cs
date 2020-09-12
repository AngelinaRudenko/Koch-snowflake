using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KochSnowflake
{
    public partial class MainForm : Form
    {
        Bitmap bitmap;
        Graphics g;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Fractal(MyPoint A, MyPoint B, byte iterations)
        {
            if (iterations == 0)
            {
                //----------------------------------
                //MyPoint X = GetThirdPoint(A, B); //X - вершина будующего треугольника
                MyPoint X = GetThirdPointWithRotationMatrix(A, B);
                //----------------------------------
                DrawLine(A, X); //Рисуется /\
                DrawLine(X, B);
            }
            else
            {
                iterations--;

                MyPoint pt13AB = Get13Point(A, B); //Координата 1/3 отрезка AB
                MyPoint pt23AB = Get23Point(A, B); //Координата 2/3 отрезка AB              

                if (iterations != 0) //Если предвидятся итерации, то происходит расчет координат
                {
                    Fractal(A, pt13AB, iterations);
                    Fractal(pt23AB, B, iterations);

                    //----------------------------------
                    //MyPoint X = GetThirdPoint(pt13AB, pt23AB); //X - вершина будующего треугольника
                    MyPoint X = GetThirdPointWithRotationMatrix(pt13AB, pt23AB);
                    //----------------------------------

                    Fractal(pt13AB, X, iterations); //Тут происходит рекурсия, тем самым пускаются ветки
                    Fractal(X, pt23AB, iterations);
                }
                else
                {
                    Fractal(pt13AB, pt23AB, iterations);

                    DrawLine(A, pt13AB); //Рисуем
                    DrawLine(pt23AB, B); // _ _
                }
            }
        }

        private void DrawLine(MyPoint pt1, MyPoint pt2) //Рисуем линию
        {
            g.DrawLine(new Pen(Color.GreenYellow), pt1.X, pt1.Y, pt2.X, pt2.Y);
        }

        private void DrawLine(Color penColor, Point pt1, Point pt2)
        {
            g.DrawLine(new Pen(penColor), pt1, pt2); //Рисуем линию своим цветом
        }

        private MyPoint GetThirdPoint(MyPoint A, MyPoint B) //Нахождение третьей точки равностороннего треугольника
        {
            double sixtyGraduses = Math.PI / 3;
            double sixtyGradusesSin = Math.Sin(sixtyGraduses);
            double sixtyGradusesCos = Math.Cos(sixtyGraduses);
            MyPoint point = new MyPoint();
            point.X = (float)((B.X - A.X) * sixtyGradusesCos - (B.Y - A.Y) * sixtyGradusesSin + A.X);
            point.Y = (float)((B.X - A.X) * sixtyGradusesSin + (B.Y - A.Y) * sixtyGradusesCos + A.Y);
            return point;
        }

        //----------------------------------------------------------------------------------------
        //Нахождение третьей точки равностороннего треугольника С ПОМОЩЬЮ МАТРИЦЫ ПРЕОБРАЗОВАНИЯ
        private MyPoint GetThirdPointWithRotationMatrix(MyPoint A, MyPoint B)
        {
            return ForComputerGraphicsLesson.PerGraduses(A, B, 60); ;
        }
        //----------------------------------------------------------------------------------------

        private MyPoint Get13Point(MyPoint A, MyPoint B) //Нахождение 1/3 отрезка
        {
            MyPoint point = new MyPoint(
                            (2 * A.X + B.X) / 3,
                            (2 * A.Y + B.Y) / 3);
            return point;
        }

        private MyPoint Get23Point(MyPoint A, MyPoint B) //Нахождение 2/3 отрезка
        {
            MyPoint point = new MyPoint(
                             (A.X + 2 * B.X) / 3,
                             (A.Y + 2 * B.Y) / 3);
            return point;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            g = CreateGraphics();

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            bitmap = new Bitmap(1920, 1080, PixelFormat.Format32bppArgb);
            bitmap.SetResolution(300, 300);
            g = Graphics.FromImage(bitmap);

            g.Clear(Color.Black);

            float x = 6 * bitmap.Width / 10;
            float y = bitmap.Height / 10;
            float x2 = 6 * bitmap.Width / 10;
            float y2 = 9 * bitmap.Height / 10;
            MyPoint A = new MyPoint(x, y);
            MyPoint B = new MyPoint(x2, y2);
            MyPoint C = GetThirdPoint(A, B);
            byte iterations = Convert.ToByte(numericUpDownIterations.Value);
            if (radioButtonOutside.Checked)
            {
                Fractal(B, A, iterations);
                Fractal(C, B, iterations);
                Fractal(A, C, iterations);
            }
            else
            {
                Fractal(A, B, iterations);
                Fractal(B, C, iterations);
                Fractal(C, A, iterations);
            }

            this.BackgroundImage = bitmap;

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;

            // Формат отображения содержимого TimeSpan
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            labelSpent.Text = "Затраченное время: " + elapsedTime;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            bitmap.Save("Result.png", ImageFormat.Png);
        }
    }
}
