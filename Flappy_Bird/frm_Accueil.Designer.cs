namespace Flappy_Bird
{
    partial class frm_Accueil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Accueil));
            this.timerBirdTitle = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.picGround = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picCloud3 = new System.Windows.Forms.PictureBox();
            this.picCloud1 = new System.Windows.Forms.PictureBox();
            this.picCloud4 = new System.Windows.Forms.PictureBox();
            this.picBird = new System.Windows.Forms.PictureBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picCloud2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panelBienvenue = new System.Windows.Forms.Panel();
            this.lblPrésente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerPanelBienvenue = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud2)).BeginInit();
            this.panelBienvenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerBirdTitle
            // 
            this.timerBirdTitle.Tick += new System.EventHandler(this.timerBirdTitle_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::Flappy_Bird.Properties.Resources.playbtn;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlay.Location = new System.Drawing.Point(122, 280);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(239, 152);
            this.btnPlay.TabIndex = 37;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // picGround
            // 
            this.picGround.BackgroundImage = global::Flappy_Bird.Properties.Resources.z_ground;
            this.picGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picGround.Location = new System.Drawing.Point(0, 509);
            this.picGround.Name = "picGround";
            this.picGround.Size = new System.Drawing.Size(510, 121);
            this.picGround.TabIndex = 38;
            this.picGround.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(360, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 52);
            this.button1.TabIndex = 39;
            this.button1.Text = "LEFT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picCloud3
            // 
            this.picCloud3.BackColor = System.Drawing.Color.Transparent;
            this.picCloud3.BackgroundImage = global::Flappy_Bird.Properties.Resources.cloud;
            this.picCloud3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCloud3.Location = new System.Drawing.Point(-69, 12);
            this.picCloud3.Name = "picCloud3";
            this.picCloud3.Size = new System.Drawing.Size(138, 94);
            this.picCloud3.TabIndex = 45;
            this.picCloud3.TabStop = false;
            // 
            // picCloud1
            // 
            this.picCloud1.BackColor = System.Drawing.Color.Transparent;
            this.picCloud1.BackgroundImage = global::Flappy_Bird.Properties.Resources.cloud;
            this.picCloud1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCloud1.Location = new System.Drawing.Point(251, 12);
            this.picCloud1.Name = "picCloud1";
            this.picCloud1.Size = new System.Drawing.Size(121, 82);
            this.picCloud1.TabIndex = 46;
            this.picCloud1.TabStop = false;
            // 
            // picCloud4
            // 
            this.picCloud4.BackColor = System.Drawing.Color.Transparent;
            this.picCloud4.BackgroundImage = global::Flappy_Bird.Properties.Resources.cloud;
            this.picCloud4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCloud4.Location = new System.Drawing.Point(399, 1);
            this.picCloud4.Name = "picCloud4";
            this.picCloud4.Size = new System.Drawing.Size(112, 66);
            this.picCloud4.TabIndex = 47;
            this.picCloud4.TabStop = false;
            // 
            // picBird
            // 
            this.picBird.BackColor = System.Drawing.Color.Transparent;
            this.picBird.BackgroundImage = global::Flappy_Bird.Properties.Resources.birdUp;
            this.picBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBird.Location = new System.Drawing.Point(382, 106);
            this.picBird.Name = "picBird";
            this.picBird.Size = new System.Drawing.Size(80, 61);
            this.picBird.TabIndex = 50;
            this.picBird.TabStop = false;
            // 
            // picTitle
            // 
            this.picTitle.BackColor = System.Drawing.Color.Transparent;
            this.picTitle.BackgroundImage = global::Flappy_Bird.Properties.Resources.Flappy_Logo;
            this.picTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTitle.Location = new System.Drawing.Point(50, 86);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(311, 92);
            this.picTitle.TabIndex = 52;
            this.picTitle.TabStop = false;
            // 
            // picCloud2
            // 
            this.picCloud2.BackColor = System.Drawing.Color.Transparent;
            this.picCloud2.BackgroundImage = global::Flappy_Bird.Properties.Resources.cloud;
            this.picCloud2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCloud2.Location = new System.Drawing.Point(109, 1);
            this.picCloud2.Name = "picCloud2";
            this.picCloud2.Size = new System.Drawing.Size(119, 69);
            this.picCloud2.TabIndex = 53;
            this.picCloud2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Gill Sans Nova Cond Ultra Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(12, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 52);
            this.button2.TabIndex = 54;
            this.button2.Text = "CREATOR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnCreator_Click);
            // 
            // panelBienvenue
            // 
            this.panelBienvenue.BackColor = System.Drawing.Color.SkyBlue;
            this.panelBienvenue.Controls.Add(this.lblPrésente);
            this.panelBienvenue.Controls.Add(this.label3);
            this.panelBienvenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBienvenue.Location = new System.Drawing.Point(0, 0);
            this.panelBienvenue.Name = "panelBienvenue";
            this.panelBienvenue.Size = new System.Drawing.Size(510, 630);
            this.panelBienvenue.TabIndex = 55;
            // 
            // lblPrésente
            // 
            this.lblPrésente.Font = new System.Drawing.Font("Rockwell Nova Cond", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrésente.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrésente.Location = new System.Drawing.Point(0, 359);
            this.lblPrésente.Name = "lblPrésente";
            this.lblPrésente.Size = new System.Drawing.Size(507, 73);
            this.lblPrésente.TabIndex = 1;
            this.lblPrésente.Text = "Presents";
            this.lblPrésente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Rockwell Nova Cond", 55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label3.Location = new System.Drawing.Point(3, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(504, 119);
            this.label3.TabIndex = 0;
            this.label3.Text = "KIGAMES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerPanelBienvenue
            // 
            this.timerPanelBienvenue.Interval = 3000;
            this.timerPanelBienvenue.Tick += new System.EventHandler(this.timerPanelBienvenue_Tick);
            // 
            // frm_Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(510, 630);
            this.Controls.Add(this.panelBienvenue);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picCloud2);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.picBird);
            this.Controls.Add(this.picCloud4);
            this.Controls.Add(this.picCloud1);
            this.Controls.Add(this.picCloud3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picGround);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Accueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCloud2)).EndInit();
            this.panelBienvenue.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerBirdTitle;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox picGround;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picCloud3;
        private System.Windows.Forms.PictureBox picCloud1;
        private System.Windows.Forms.PictureBox picCloud4;
        private System.Windows.Forms.PictureBox picBird;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.PictureBox picCloud2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelBienvenue;
        private System.Windows.Forms.Label lblPrésente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerPanelBienvenue;
    }
}