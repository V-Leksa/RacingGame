using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RacingGame
{
    public partial class Form1 : Form
    {

        private Point pos; //координаты точки нажатия мыши
        private bool dragging,lose =false; //информация передвигаем окно или нет
        
        private int countMoney = 0;

        public Form1()
        {
            InitializeComponent();

            backgroundPB.MouseDown += MouseClickDown;
            backgroundPB.MouseUp += MouseClickUp;
            backgroundPB.MouseMove += MouseClickMove;

            backgroundSecondPB.MouseDown += MouseClickDown;
            backgroundSecondPB.MouseUp += MouseClickUp;
            backgroundSecondPB.MouseMove += MouseClickMove;

            labelLose.Visible = false;
            RestartBT.Visible = false;

            KeyPreview = true;
        }


        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;

        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point curretPoint=PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(curretPoint.X - pos.X, curretPoint.X - pos.Y + backgroundPB.Top);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            int speed = 15;
            //Перемещение объектов
            MoveObjectAsync(backgroundPB, speed);
            MoveObjectAsync(backgroundSecondPB, speed);
            MoveObjectAsync(enemyFirstPB, speed);
            MoveObjectAsync(enemySecondPB, speed);
            MoveObjectAsync(MoneyPB, speed);

            // Обработка граничных условий и перемещение объектов вниз

            int enemysSpeed = 7;
            enemyFirstPB.Top += enemysSpeed;
            enemySecondPB.Top += enemysSpeed;

            MoneyPB.Top += speed;

            if (backgroundPB.Top >= 650)
            {
                backgroundPB.Top = 0;
                backgroundSecondPB.Top = -650;
            }
            // появление монеток в разных местах
            if (MoneyPB.Top >= 650)
            {
                MoneyPB.Top = -50;
                Random rnd = new Random();
                MoneyPB.Left = rnd.Next(150, 560);
            }
            if (enemyFirstPB.Top>=650)
            {
                enemyFirstPB.Top = -130;
                //появление в случайном месте
                Random rnd = new Random();
                enemyFirstPB.Left = rnd.Next(150, 300);
            }
            if (enemySecondPB.Top >= 650)
            {
                enemySecondPB.Top = -400;
                //появление в случайном месте
                Random rnd = new Random();
                enemySecondPB.Left = rnd.Next(300, 560);
            }
            //соприкосновение с машинками
            if(CarPB.Bounds.IntersectsWith(enemyFirstPB.Bounds)|| CarPB.Bounds.IntersectsWith(enemySecondPB.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                RestartBT.Visible = true;
                lose = true;
            }
            if (CarPB.Bounds.IntersectsWith(MoneyPB.Bounds))
            {
                //при соприкосновении с монеткой увеличиваем счет
                countMoney++;
                MoneyLabel.Text = "Moнеты: " + countMoney.ToString();

                //перемещаем монетку обратно после соприкосновения
                MoneyPB.Top = -50;

                Random rnd = new Random();
                MoneyPB.Left = rnd.Next(150, 560);

            }

        }

        private async void MoveObjectAsync(PictureBox pictureBox, int speed)
        {
            await Task.Run(() =>
            {
                pictureBox.Invoke(new Action(() =>
                {
                    pictureBox.Top += speed;
                }));
            });
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose)
            {
                return;
            }
            int speedOfCar = 10;
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && CarPB.Left > 150)
            {
                CarPB.Left -= speedOfCar;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && CarPB.Right < 700)
            {
                CarPB.Left += speedOfCar;
            }

        }

        private void RestartBT_Click(object sender, EventArgs e)
        {
            enemyFirstPB.Top = -130;
            enemySecondPB.Top = -400;
            labelLose.Visible = false;
            RestartBT.Visible = false;
            timer.Enabled = true;
            lose = false;
            countMoney = 0;
            MoneyLabel.Text = "Moнеты: 0";
            MoneyPB.Top = -500;

        }
    }
}
