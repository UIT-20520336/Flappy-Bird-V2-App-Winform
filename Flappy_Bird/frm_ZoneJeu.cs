using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Flappy_Bird
{
    public partial class frm_ZoneJeu : Form
    {
        #region Variable
        SqlConnection sqlConnection;
        SqlCommand command;
        SqlDataReader read;
        Random random;
        int valueDownBird;
        int valueLeftPipe;
        int countDownSpeed;
        int nombrePairImpair;
        int monteHaut;
        int score;
        int bestScore = 0;
        bool plantVisible;
        bool firstClickTimer;
        String position;
        Bird birdInstance;
        #endregion

        public frm_ZoneJeu()
        {
            InitializeComponent();
            random = new Random();
            sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\kamel\Documents\Slam\Flappy_Bird\Flappy_Bird\Score.mdf;Integrated Security=True");
            command = new SqlCommand();
            birdInstance = Bird.GetInstance();
            initialisation();
        }

        #region Methode

        /// <summary>
        /// Initialisation de la partie
        /// </summary>
        private void initialisation()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            lblScoreGame.SendToBack();
            picBird.Location = new Point(birdInstance.X, birdInstance.Y);
            panelGameOver.Visible = false;
            picPlant.Top = -15;
            picPlantDown.Top = this.Height;
            btnUpBird.Enabled = true;
            picPipeDown.Left = this.Width * 2;
            picPipeUp.Left = this.Width * 2;
            picPipeDown2.Left = this.Width * 2 + this.Width / 2 + 50;
            picPipeUp2.Left = this.Width * 2 + this.Width / 2 + 50;
            picPlantDown.Left = this.Width * 2;
            picPlant.Left = this.Width * 2 + this.Width / 2 + 50;
            this.BackColor = Color.SkyBlue;

            valueDownBird = 2;
            countDownSpeed = 0;
            valueLeftPipe = 5;
            score = 0;
            firstClickTimer = false;
            monteHaut = 0;
            nombrePairImpair = 0;
            plantVisible = false;
            position = "normal";

            lblScoreGame.Text = score.ToString();
            timerBattementAileBird.Start();
        }

        /// <summary>
        /// Timer permettant le mouvements des pipes et des plantes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBird_Tick(object sender, EventArgs e)
        {
            if (position == "haut")
            {
                if(monteHaut == 4)
                {
                    position = "normal"; 
                    monteHaut = 0;
                }
                monteHaut++;
                picBird.Top -= 10;
            }
            else
            {
                picBird.Top += valueDownBird;
            }
            
            picPipeDown.Left -= valueLeftPipe;
            picPipeUp.Left -= valueLeftPipe;
            picPipeDown2.Left -= valueLeftPipe;
            picPipeUp2.Left -= valueLeftPipe;
            picPlantDown.Left -= valueLeftPipe;
            picPlant.Left -= valueLeftPipe;
            countDownSpeed++;

            pipeBord();
            interactionBirdPipe();
            interactionBirdGround();
            switchScore();
        }

        /// <summary>
        /// Timer permettant le battements d'ailes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBattementAileBird_Tick(object sender, EventArgs e)
        {
            if (position == "normal" && countDownSpeed < 15)
            {
                if (nombrePairImpair % 2 == 0)
                    picBird.BackgroundImage = Properties.Resources.birdDown;

                else
                    picBird.BackgroundImage = Properties.Resources.birdUp;

                nombrePairImpair++;
            }
        }

        /// <summary>
        /// Move pipe
        /// </summary>
        private void pipeBord()
        {
            if(picPipeDown.Left <= 0 - picPipeDown.Width || picPipeUp.Left <= 0 - picPipeUp.Width)
            {
                picPipeDown.Left = this.Width + 10;
                picPipeUp.Left = this.Width + 10;
                picPlantDown.Left = picPipeDown.Left;
                heightPipe(picPipeUp, picPipeDown); 
                score++;
                if (plantVisible)
                    picPlantDown.Top = picPipeDown.Top + picPipeDown.Height - picPlantDown.Height + 30;

                lblScoreGame.Text = score.ToString();
                
            }
            if (picPipeDown2.Left <= 0 - picPipeDown2.Width || picPipeUp2.Left <= 0 - picPipeUp2.Width)
            {
                picPipeDown2.Left = this.Width + 10;
                picPipeUp2.Left = this.Width + 10;
                picPlant.Left = picPipeUp2.Left;
                heightPipe(picPipeUp2, picPipeDown2);
                score++;
                if (plantVisible)
                    picPlant.Top = picPipeUp2.Top - 30;

                lblScoreGame.Text = score.ToString();
            }
        }

        /// <summary>
        /// Height pipe
        /// </summary>
        /// <param name="up">PictureBox name UP</param>
        /// <param name="down">PictureBox name Down</param>
        private void heightPipe(PictureBox up, PictureBox down)
        {
            int heightPipe = down.Height;
            int entier = random.Next(-heightPipe + heightPipe/4 , -50);
            down.Top = entier;
            up.Top = entier + heightPipe + picBird.Height + 100 ;
        }

        /// <summary>
        /// Intersects with pipe or plant
        /// </summary>
        private void interactionBirdPipe()
        {
            if( picBird.Bounds.IntersectsWith(picPipeDown.Bounds) || picBird.Bounds.IntersectsWith(picPipeUp.Bounds) || 
                picBird.Bounds.IntersectsWith(picPipeDown2.Bounds) || picBird.Bounds.IntersectsWith(picPipeUp2.Bounds) || 
                picBird.Bounds.IntersectsWith(picPlant.Bounds) || picBird.Bounds.IntersectsWith(picPlantDown.Bounds))
            {
                valueLeftPipe = 0;
                btnUpBird.Enabled = false;
                if(picBird.Top + picBird.Height >= picGround.Top)
                {
                    timerBird.Stop();
                    timerBattementAileBird.Stop();
                    panelGameOver.Visible = true;
                    panelGameOver.Dock = DockStyle.Fill;
                    lblScore.Text = score.ToString();
                    openDatabase();
                }
            }
        }

        /// <summary>
        /// Ope database local == No
        /// </summary>
        private void openDatabase()
        {
            command.Connection = sqlConnection;
            command.CommandText = "select bestScore from score";
            read = command.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    bestScore = read.GetInt32(0);
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            read.Close();
            if (score > bestScore)
            {
                command.CommandText = "update score set bestScore = '"+score+"' where Id=0";
                command.ExecuteNonQuery();
                bestScore = score;
            }

            lblBestScore.Text = bestScore.ToString();
            sqlConnection.Close();
        }

        /// <summary>
        /// Intersect with ground
        /// </summary>
        private void interactionBirdGround()
        {
            if(picBird.Top + picBird.Height >= picGround.Top)
            {
                valueDownBird = 0;
                picBird.BackgroundImage = Properties.Resources.birdDown;
            }
            else
            {
                valueDownBird = 3;
                if(countDownSpeed >= 18)
                {
                    valueDownBird += 4;
                    picBird.BackgroundImage = Properties.Resources.birdDown2;
                }
            }
        }

        /// <summary>
        /// Score
        /// </summary>
        private void switchScore()
        {
            switch (score)
            {
                case 10:
                    plantVisible = true;
                    break;
                case 20:
                    this.BackColor = Color.SteelBlue;
                    break;
                case 60:
                    this.BackColor = Color.MidnightBlue;
                    break;
                case 100:
                    this.BackColor = Color.SteelBlue;
                    break;
                case 120:
                    this.BackColor = Color.SkyBlue;
                    break;
            }
        }

        #endregion

        #region Click

        /// <summary>
        /// Button up bird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpBird_Click(object sender, EventArgs e)
        {
            if (!firstClickTimer)
                timerBird.Start();
            picBird.BackgroundImage = Properties.Resources.birdUp2;
            monteHaut = 0;
            countDownSpeed = 0;
            position = "haut";
        }

        /// <summary>
        /// Button quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Button replay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReplay_Click(object sender, EventArgs e)
        {
            initialisation();
        }

        #endregion
    }
}

public class Bird
{
    private static Bird instance; // Singleton instance

    // Bird properties
    public int X { get; private set; }
    public int Y { get; private set; }

    private Bird()
    {
        // Initialize the bird properties
        X = 64;
        Y = 247;
    }

    // Method to get the Singleton instance
    public static Bird GetInstance()
    {
        if (instance == null)
        {
            instance = new Bird();
        }
        return instance;
    }

}