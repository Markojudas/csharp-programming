using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PA5_Draft
{
    public partial class MainForm : Form
    {
        private int Step = 1;
        private int ApplesEaten = 0;
        private readonly SnakeGame Game;
        private SoundPlayer eat_sound, hit_wall, hit_self;
        private SetApples setApples;
        private Size stateBar_height;
        StringFormat drawFormat;
        private bool isPaused = false;
        public bool isLost = false;
        private int NumberOfApples = 1;
        private int counter = 0;
        private int Alpha = 0;
        private const int MaxRadius = 15;
        private const int MinRadius = 10;
        private double radius;

        public MainForm()
        {
            setApples = new SetApples();
            DialogResult y = setApples.ShowDialog(this);

            if (y == DialogResult.OK)
            {
                if (setApples.num_of_apples >= 1000)
                    setApples.num_of_apples = 800;

                this.NumberOfApples = setApples.num_of_apples;
                
            }

            InitializeComponent();
            stateBar_height.Height = stateBar.Height;
            Game = new SnakeGame(new System.Drawing.Point((Field.Width - 20) / 2, (Field.Height - stateBar.Height) / 2), 40, NumberOfApples, Field.Size - stateBar_height);
            Field.Image = new Bitmap(Field.Width, Field.Height - stateBar.Height);
            num_eaten_apples.Text = Game.appleEaten.ToString();
            eat_sound = new SoundPlayer(Properties.Resources.Loud_Bite_Into_Toast_2___QuickSounds_com);
            hit_wall = new SoundPlayer(Properties.Resources.Car_Crash_1___QuickSounds_com);
            hit_self = new SoundPlayer(Properties.Resources.bonebreak);
            drawFormat = new StringFormat();
            Game.EatAndGrow += Game_EatAndGrow;
            Game.HitWallAndLose += Game_HitWallAndLose;
            Game.HitSnakeAndLose += Game_HitSnakeAndLose;
        }

        private void Game_HitWallAndLose()
        {
            hit_wall.Play();
            isLost = true;
            Field.Refresh();
            //mainTimer.Stop();
            //MessageBox.Show("Number of Apples Eaten: " + Game.appleEaten, "You Lose!");
        }
        private void Game_HitSnakeAndLose()
        {

            hit_self.Play();
            isLost = true;
            Field.Refresh();
            //mainTimer.Stop();
            //MessageBox.Show("Number of Apples Eaten: " + Game.appleEaten, "You Lose!");
        }

        private void Game_EatAndGrow()
        {
            ApplesEaten++;
            eat_sound.Play();
            num_eaten_apples.Text = ApplesEaten.ToString();
            Alpha = 205;
            if (ApplesEaten % 10 == 0 && Step <= 10)
            {
                Step++;
                step_pro_bar.PerformStep();
            }
            Field.Refresh();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            if(!isLost)
                Game.Move(Step);

            counter++;
            Field.Invalidate();
        }

        private void Field_Click(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                mainTimer.Stop();
                isPaused = true;
            }
            else
            {
                if (!isLost)
                {
                    mainTimer.Start();
                    isPaused = false;
                }
            }
        }

        private void Field_Paint(object sender, PaintEventArgs e)
        {

            

            Image apple = Properties.Resources.apple48;
            Pen PenForObstacles = new Pen(Color.FromArgb(40, 40, 40), 2);
            Pen PenForSnake = new Pen(Color.FromArgb(100, 100, 100), 2);
            Brush BackGroundBrush = new SolidBrush(Color.FromArgb(150, 250, 150));
            Brush AppleBrush = new SolidBrush(Color.FromArgb(250, 50, 50));
            using (Graphics g = Graphics.FromImage(Field.Image))
            {
                g.FillRectangle(BackGroundBrush, new Rectangle(0, 0, Field.Width, Field.Height - stateBar.Height));

                int j = 0;
                foreach (Point Apple in Game.Apples)
                {
                    long Counter2 = counter + (j++);
                    radius = (MaxRadius - MinRadius) * (Math.Sin(Counter2 * Math.PI / 40.0) + 1) / 2.0 + MinRadius;

                    if (NumberOfApples < 500)
                        g.DrawImage(apple, new Rectangle(Apple.X - (int)Math.Round(radius), Apple.Y - (int)Math.Round(radius),
                            2 * (int)Math.Round(radius), 2 * (int)Math.Round(radius)));
                    else
                        g.FillEllipse(AppleBrush, new Rectangle(Apple.X - (int)Math.Round(radius), Apple.Y - (int)Math.Round(radius),
                            2 * (int)Math.Round(radius), 2 * (int)Math.Round(radius)));
                }

                foreach (LineSeg Obstacle in Game.Obstacles)
                    g.DrawLine(PenForObstacles, new System.Drawing.Point(Obstacle.Start.X, Obstacle.Start.Y)
                        , new System.Drawing.Point(Obstacle.End.X, Obstacle.End.Y));
                foreach (LineSeg Body in Game.SnakeBody)
                    g.DrawLine(PenForSnake, new System.Drawing.Point((int)Body.Start.X, (int)Body.Start.Y)
                        , new System.Drawing.Point((int)Body.End.X, (int)Body.End.Y));

                if (isLost)
                {
                    Alpha = (Alpha + 1) % 256;
                    g.DrawString("Game Over!\nEaten Apples: " + ApplesEaten,
                       new Font(FontFamily.GenericSansSerif, 40, FontStyle.Bold),
                       new SolidBrush(Color.FromArgb(Alpha, Color.FromName("black"))),
                       new Point((Field.Width / 4) - 30, Field.Height - stateBar.Height).X,
                       new Point(1, (Field.Height - stateBar.Height) / 3).Y,
                       drawFormat);
                    Field.Invalidate();

                }
                else
                {
                    bool boost = ApplesEaten % 10 == 0 && Step <= 10;
                    Alpha = Alpha < 15 ? 0 : Alpha - 3;
                    g.DrawString(boost ? "BOOST!" : "+1",
                        new Font(FontFamily.GenericSansSerif, 40, FontStyle.Bold),
                        new SolidBrush(boost ? Color.FromArgb(Alpha, Color.FromName("violet")) : Color.FromArgb(Alpha, Color.FromName("white"))),
                        new Point((boost ? (Field.Width / 4) + 30: (Field.Width / 2) - 20), 1).X,
                        new Point(1, ((Field.Height - stateBar.Height) / 2) - 20).Y,
                        drawFormat);
                }
            }
        }

        private void Snakes_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isLost)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        Game.Move(Step, Direction.UP);
                        break;
                    case Keys.Down:
                        Game.Move(Step, Direction.DOWN);
                        break;
                    case Keys.Left:
                        Game.Move(Step, Direction.LEFT);
                        break;
                    case Keys.Right:
                        Game.Move(Step, Direction.RIGHT);
                        break;
                }
            }

        }
    }
}
