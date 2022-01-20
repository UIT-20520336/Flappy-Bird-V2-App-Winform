namespace Flappy_Bird
{
    partial class frm_ZoneJeu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ZoneJeu));
            this.timerBird = new System.Windows.Forms.Timer(this.components);
            this.timerBattementAileBird = new System.Windows.Forms.Timer(this.components);
            this.picPlantDown = new System.Windows.Forms.PictureBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.picPipeUp2 = new System.Windows.Forms.PictureBox();
            this.picPipeDown2 = new System.Windows.Forms.PictureBox();
            this.picPipeDown = new System.Windows.Forms.PictureBox();
            this.picPlant = new System.Windows.Forms.PictureBox();
            this.picPipeUp = new System.Windows.Forms.PictureBox();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.btnUpBird = new System.Windows.Forms.Button();
            this.lblScoreGame = new System.Windows.Forms.Label();
            this.panelGameOver = new System.Windows.Forms.Panel();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBestScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlantDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            this.panelGameOver.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerBird
            // 
            this.timerBird.Interval = 20;
            this.timerBird.Tick += new System.EventHandler(this.timerBird_Tick);
            // 
            // timerBattementAileBird
            // 
            this.timerBattementAileBird.Interval = 80;
            this.timerBattementAileBird.Tick += new System.EventHandler(this.timerBattementAileBird_Tick);
            // 
            // picPlantDown
            // 
            this.picPlantDown.BackColor = System.Drawing.Color.Transparent;
            this.picPlantDown.BackgroundImage = global::Flappy_Bird.Properties.Resources.plantDown;
            this.picPlantDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlantDown.Location = new System.Drawing.Point(300, -91);
            this.picPlantDown.Name = "picPlantDown";
            this.picPlantDown.Size = new System.Drawing.Size(90, 110);
            this.picPlantDown.TabIndex = 54;
            this.picPlantDown.TabStop = false;
            // 
            // picBird
            // 
            this.picBird.BackColor = System.Drawing.Color.Transparent;
            this.picBird.BackgroundImage = global::Flappy_Bird.Properties.Resources.birdUp;
            this.picBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBird.Location = new System.Drawing.Point(64, 228);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(53, 44);
            this.picBird.TabIndex = 40;
            this.picBird.TabStop = false;
            // 
            // picPipeUp2
            // 
            this.picPipeUp2.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipe;
            this.picPipeUp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPipeUp2.Location = new System.Drawing.Point(300, 360);
            this.picPipeUp2.Name = "picPipeUp2";
            this.picPipeUp2.Size = new System.Drawing.Size(90, 421);
            this.picPipeUp2.TabIndex = 62;
            this.picPipeUp2.TabStop = false;
            // 
            // picPipeDown2
            // 
            this.picPipeDown2.BackColor = System.Drawing.Color.Transparent;
            this.picPipeDown2.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipedown;
            this.picPipeDown2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPipeDown2.Location = new System.Drawing.Point(300, -232);
            this.picPipeDown2.Name = "picPipeDown2";
            this.picPipeDown2.Size = new System.Drawing.Size(90, 421);
            this.picPipeDown2.TabIndex = 64;
            this.picPipeDown2.TabStop = false;
            // 
            // picPipeDown
            // 
            this.picPipeDown.BackColor = System.Drawing.Color.Transparent;
            this.picPipeDown.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipedown;
            this.picPipeDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPipeDown.Location = new System.Drawing.Point(420, -232);
            this.picPipeDown.Name = "picPipeDown";
            this.picPipeDown.Size = new System.Drawing.Size(90, 421);
            this.picPipeDown.TabIndex = 65;
            this.picPipeDown.TabStop = false;
            // 
            // picPlant
            // 
            this.picPlant.BackColor = System.Drawing.Color.Transparent;
            this.picPlant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPlant.BackgroundImage")));
            this.picPlant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPlant.Location = new System.Drawing.Point(420, 499);
            this.picPlant.Name = "picPlant";
            this.picPlant.Size = new System.Drawing.Size(90, 110);
            this.picPlant.TabIndex = 68;
            this.picPlant.TabStop = false;
            // 
            // picPipeUp
            // 
            this.picPipeUp.BackgroundImage = global::Flappy_Bird.Properties.Resources.pipe;
            this.picPipeUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPipeUp.Location = new System.Drawing.Point(420, 360);
            this.picPipeUp.Name = "picPipeUp";
            this.picPipeUp.Size = new System.Drawing.Size(90, 421);
            this.picPipeUp.TabIndex = 69;
            this.picPipeUp.TabStop = false;
            // 
            // picGround
            // 
            this.picGround.BackgroundImage = global::Flappy_Bird.Properties.Resources.z_ground;
            this.picGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGround.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picGround.Location = new System.Drawing.Point(0, 507);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(510, 123);
            this.picGround.TabIndex = 70;
            this.picGround.TabStop = false;
            // 
            // btnUpBird
            // 
            this.btnUpBird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.btnUpBird.FlatAppearance.BorderColor = System.Drawing.Color.Ivory;
            this.btnUpBird.FlatAppearance.BorderSize = 0;
            this.btnUpBird.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.btnUpBird.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.btnUpBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpBird.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpBird.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnUpBird.Location = new System.Drawing.Point(0, 531);
            this.btnUpBird.Name = "btnUpBird";
            this.btnUpBird.Size = new System.Drawing.Size(510, 99);
            this.btnUpBird.TabIndex = 72;
            this.btnUpBird.Text = " UP";
            this.btnUpBird.UseVisualStyleBackColor = false;
            this.btnUpBird.Click += new System.EventHandler(this.btnUpBird_Click);
            // 
            // lblScoreGame
            // 
            this.lblScoreGame.AutoSize = true;
            this.lblScoreGame.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreGame.ForeColor = System.Drawing.Color.MintCream;
            this.lblScoreGame.Location = new System.Drawing.Point(226, 67);
            this.lblScoreGame.Name = "lblScoreGame";
            this.lblScoreGame.Size = new System.Drawing.Size(39, 44);
            this.lblScoreGame.TabIndex = 73;
            this.lblScoreGame.Text = "0";
            // 
            // panelGameOver
            // 
            this.panelGameOver.BackColor = System.Drawing.Color.SkyBlue;
            this.panelGameOver.Controls.Add(this.lblBestScore);
            this.panelGameOver.Controls.Add(this.label4);
            this.panelGameOver.Controls.Add(this.btnQuit);
            this.panelGameOver.Controls.Add(this.btnReplay);
            this.panelGameOver.Controls.Add(this.lblScore);
            this.panelGameOver.Controls.Add(this.label6);
            this.panelGameOver.Controls.Add(this.label3);
            this.panelGameOver.Controls.Add(this.label2);
            this.panelGameOver.Controls.Add(this.label1);
            this.panelGameOver.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelGameOver.Location = new System.Drawing.Point(0, 44);
            this.panelGameOver.Name = "panelGameOver";
            this.panelGameOver.Size = new System.Drawing.Size(510, 463);
            this.panelGameOver.TabIndex = 74;
            this.panelGameOver.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnQuit.Font = new System.Drawing.Font("Gill Sans Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.SeaShell;
            this.btnQuit.Location = new System.Drawing.Point(324, 439);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(103, 51);
            this.btnQuit.TabIndex = 40;
            this.btnQuit.Text = "LEFT";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReplay.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnReplay.FlatAppearance.BorderSize = 0;
            this.btnReplay.Font = new System.Drawing.Font("Gill Sans Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplay.ForeColor = System.Drawing.Color.SeaShell;
            this.btnReplay.Location = new System.Drawing.Point(64, 439);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(112, 51);
            this.btnReplay.TabIndex = 39;
            this.btnReplay.Text = "REPLAY";
            this.btnReplay.UseVisualStyleBackColor = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Gill Sans Nova", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblScore.Location = new System.Drawing.Point(351, 242);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 44);
            this.lblScore.TabIndex = 37;
            this.lblScore.Text = "0";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(58, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(369, 10);
            this.label6.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(69, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 44);
            this.label3.TabIndex = 33;
            this.label3.Text = "SCORE";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(61, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 10);
            this.label2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 87);
            this.label1.TabIndex = 31;
            this.label1.Text = "GAME OVER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(69, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 44);
            this.label4.TabIndex = 41;
            this.label4.Text = "BEST SCORE";
            // 
            // lblBestScore
            // 
            this.lblBestScore.AutoSize = true;
            this.lblBestScore.Font = new System.Drawing.Font("Gill Sans Nova", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblBestScore.Location = new System.Drawing.Point(351, 328);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(38, 44);
            this.lblBestScore.TabIndex = 42;
            this.lblBestScore.Text = "0";
            // 
            // frm_ZoneJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(510, 630);
            this.Controls.Add(this.panelGameOver);
            this.Controls.Add(this.lblScoreGame);
            this.Controls.Add(this.btnUpBird);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.picPipeUp);
            this.Controls.Add(this.picPlant);
            this.Controls.Add(this.picPipeDown);
            this.Controls.Add(this.picPipeDown2);
            this.Controls.Add(this.picPipeUp2);
            this.Controls.Add(this.picPlantDown);
            this.Controls.Add(this.picBird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_ZoneJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picPlantDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            this.panelGameOver.ResumeLayout(false);
            this.panelGameOver.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerBird;
        private System.Windows.Forms.Timer timerBattementAileBird;
        private System.Windows.Forms.PictureBox picPlantDown;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.PictureBox picPipeUp2;
        private System.Windows.Forms.PictureBox picPipeDown2;
        private System.Windows.Forms.PictureBox picPipeDown;
        private System.Windows.Forms.PictureBox picPlant;
        private System.Windows.Forms.PictureBox picPipeUp;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.Button btnUpBird;
        private System.Windows.Forms.Label lblScoreGame;
        private System.Windows.Forms.Panel panelGameOver;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label label4;
    }
}

