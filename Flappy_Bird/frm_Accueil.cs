using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class frm_Accueil : Form
    {
        #region Variable

        frm_ZoneJeu zoneJeu;
        int nbBirdChange;
        int valueMove;
        int value;
        int valueLeftCloud;
        bool panelKigames;

        #endregion

        public frm_Accueil()
        {
            InitializeComponent();
            nbBirdChange = 0;
            valueMove = 0;
            value = 3;
            panelKigames = true;
            valueLeftCloud = 2;
            zoneJeu = new frm_ZoneJeu();
            timerBirdTitle.Start();
            timerPanelBienvenue.Start();
        }

        #region Methode

        /// <summary>
        /// Timer logo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerPanelBienvenue_Tick(object sender, EventArgs e)
        {
            panelKigames = false;
            panelBienvenue.Visible = false;
            timerPanelBienvenue.Stop();
        }

        /// <summary>
        /// Timer move bird and title
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerBirdTitle_Tick(object sender, EventArgs e)
        {
            if (!panelKigames)
            {
                if (nbBirdChange % 2 == 0)
                {
                    picBird.BackgroundImage = Properties.Resources.birdUp;
                }
                else
                {
                    picBird.BackgroundImage = Properties.Resources.birdDown;
                }
                if (valueMove <= 10)
                {
                    picTitle.Top += value;
                    picBird.Top += value;
                }
                else
                {
                    value = -value;
                    valueMove = 0;
                }
                picCloud1.Left -= valueLeftCloud;
                picCloud2.Left -= valueLeftCloud;
                picCloud3.Left -= valueLeftCloud;
                picCloud4.Left -= valueLeftCloud;
                cloudMove(picCloud1);
                cloudMove(picCloud2);
                cloudMove(picCloud3);
                cloudMove(picCloud4);
                valueMove++;
                nbBirdChange++;
            }
        }

        /// <summary>
        /// Move cloud
        /// </summary>
        /// <param name="cloud">PictureBox cloud name</param>
        private void cloudMove(PictureBox cloud)
        {
            if(cloud.Left <= 0 - cloud.Width)
            {
                cloud.Left = this.Width;
            }
        }
        #endregion

        #region Click

        /// <summary>
        /// Button play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            timerBirdTitle.Stop();
            zoneJeu.ShowDialog();
        }

        /// <summary>
        /// Button quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            timerBirdTitle.Stop();
            Application.Exit();
        }


        /// <summary>
        /// Button creator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by KIGAMES", "Creator");
        }
        #endregion

    }
}
