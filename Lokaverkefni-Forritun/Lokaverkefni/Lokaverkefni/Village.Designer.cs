namespace Lokaverkefni
{
    partial class Village
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnwood = new System.Windows.Forms.Button();
            this.btnsteel = new System.Windows.Forms.Button();
            this.btnmeat = new System.Windows.Forms.Button();
            this.btncoal = new System.Windows.Forms.Button();
            this.prbwood = new System.Windows.Forms.ProgressBar();
            this.prbsteel = new System.Windows.Forms.ProgressBar();
            this.prbmeat = new System.Windows.Forms.ProgressBar();
            this.prbcoal = new System.Windows.Forms.ProgressBar();
            this.lblcoins = new System.Windows.Forms.Label();
            this.piccoin1 = new System.Windows.Forms.PictureBox();
            this.lbllevel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblyear = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.picHouse_2 = new System.Windows.Forms.PictureBox();
            this.picHouse_3 = new System.Windows.Forms.PictureBox();
            this.picHouse_1 = new System.Windows.Forms.PictureBox();
            this.picBurnedhouse_1 = new System.Windows.Forms.PictureBox();
            this.picBurnedhouse_2 = new System.Windows.Forms.PictureBox();
            this.picBurnedhouse_3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piccoin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurnedhouse_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurnedhouse_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurnedhouse_3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnwood
            // 
            this.btnwood.BackColor = System.Drawing.Color.Lime;
            this.btnwood.BackgroundImage = global::Lokaverkefni.Properties.Resources.wood1;
            this.btnwood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnwood.Location = new System.Drawing.Point(250, 556);
            this.btnwood.Name = "btnwood";
            this.btnwood.Size = new System.Drawing.Size(75, 46);
            this.btnwood.TabIndex = 0;
            this.btnwood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnwood.UseVisualStyleBackColor = false;
            this.btnwood.Click += new System.EventHandler(this.btnwood_Click);
            // 
            // btnsteel
            // 
            this.btnsteel.BackColor = System.Drawing.Color.Lime;
            this.btnsteel.BackgroundImage = global::Lokaverkefni.Properties.Resources.steel1;
            this.btnsteel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsteel.ImageKey = "(none)";
            this.btnsteel.Location = new System.Drawing.Point(169, 556);
            this.btnsteel.Name = "btnsteel";
            this.btnsteel.Size = new System.Drawing.Size(75, 45);
            this.btnsteel.TabIndex = 1;
            this.btnsteel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsteel.UseVisualStyleBackColor = false;
            this.btnsteel.Click += new System.EventHandler(this.btnsteel_Click);
            // 
            // btnmeat
            // 
            this.btnmeat.BackColor = System.Drawing.Color.Lime;
            this.btnmeat.BackgroundImage = global::Lokaverkefni.Properties.Resources.meat;
            this.btnmeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnmeat.Location = new System.Drawing.Point(7, 555);
            this.btnmeat.Name = "btnmeat";
            this.btnmeat.Size = new System.Drawing.Size(75, 45);
            this.btnmeat.TabIndex = 2;
            this.btnmeat.UseVisualStyleBackColor = false;
            this.btnmeat.Click += new System.EventHandler(this.btnmeat_Click);
            // 
            // btncoal
            // 
            this.btncoal.BackColor = System.Drawing.Color.Lime;
            this.btncoal.BackgroundImage = global::Lokaverkefni.Properties.Resources.coal;
            this.btncoal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncoal.Location = new System.Drawing.Point(88, 556);
            this.btncoal.Name = "btncoal";
            this.btncoal.Size = new System.Drawing.Size(75, 46);
            this.btncoal.TabIndex = 3;
            this.btncoal.Text = "Coal";
            this.btncoal.UseVisualStyleBackColor = false;
            this.btncoal.Click += new System.EventHandler(this.btncoal_Click);
            // 
            // prbwood
            // 
            this.prbwood.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.prbwood.Location = new System.Drawing.Point(250, 531);
            this.prbwood.Maximum = 200;
            this.prbwood.Name = "prbwood";
            this.prbwood.Size = new System.Drawing.Size(75, 18);
            this.prbwood.Step = 1;
            this.prbwood.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbwood.TabIndex = 4;
            // 
            // prbsteel
            // 
            this.prbsteel.Location = new System.Drawing.Point(169, 531);
            this.prbsteel.Maximum = 30;
            this.prbsteel.Name = "prbsteel";
            this.prbsteel.Size = new System.Drawing.Size(75, 18);
            this.prbsteel.Step = 30;
            this.prbsteel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbsteel.TabIndex = 5;
            // 
            // prbmeat
            // 
            this.prbmeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.prbmeat.Location = new System.Drawing.Point(7, 531);
            this.prbmeat.Name = "prbmeat";
            this.prbmeat.Size = new System.Drawing.Size(75, 18);
            this.prbmeat.Step = 100;
            this.prbmeat.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbmeat.TabIndex = 6;
            // 
            // prbcoal
            // 
            this.prbcoal.Location = new System.Drawing.Point(88, 531);
            this.prbcoal.Name = "prbcoal";
            this.prbcoal.Size = new System.Drawing.Size(75, 18);
            this.prbcoal.Step = 100;
            this.prbcoal.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbcoal.TabIndex = 7;
            // 
            // lblcoins
            // 
            this.lblcoins.BackColor = System.Drawing.Color.Transparent;
            this.lblcoins.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcoins.Location = new System.Drawing.Point(816, 545);
            this.lblcoins.Name = "lblcoins";
            this.lblcoins.Size = new System.Drawing.Size(64, 49);
            this.lblcoins.TabIndex = 8;
            this.lblcoins.Text = "C";
            // 
            // piccoin1
            // 
            this.piccoin1.BackColor = System.Drawing.Color.Transparent;
            this.piccoin1.Enabled = false;
            this.piccoin1.Image = global::Lokaverkefni.Properties.Resources.Coin;
            this.piccoin1.Location = new System.Drawing.Point(750, 540);
            this.piccoin1.Name = "piccoin1";
            this.piccoin1.Size = new System.Drawing.Size(60, 58);
            this.piccoin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piccoin1.TabIndex = 9;
            this.piccoin1.TabStop = false;
            // 
            // lbllevel
            // 
            this.lbllevel.BackColor = System.Drawing.Color.Transparent;
            this.lbllevel.Font = new System.Drawing.Font("Onyx", 27.75F);
            this.lbllevel.Location = new System.Drawing.Point(670, 160);
            this.lbllevel.Name = "lbllevel";
            this.lbllevel.Size = new System.Drawing.Size(222, 49);
            this.lbllevel.TabIndex = 11;
            this.lbllevel.Text = "Level 1 : The Dark Age";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblyear
            // 
            this.lblyear.BackColor = System.Drawing.Color.Transparent;
            this.lblyear.Font = new System.Drawing.Font("Onyx", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(-1, 9);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(151, 37);
            this.lblyear.TabIndex = 12;
            this.lblyear.Text = "Year : 0";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // picHouse_2
            // 
            this.picHouse_2.BackColor = System.Drawing.Color.Transparent;
            this.picHouse_2.Enabled = false;
            this.picHouse_2.Image = global::Lokaverkefni.Properties.Resources.Blue_house;
            this.picHouse_2.Location = new System.Drawing.Point(435, 429);
            this.picHouse_2.Name = "picHouse_2";
            this.picHouse_2.Size = new System.Drawing.Size(133, 126);
            this.picHouse_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHouse_2.TabIndex = 14;
            this.picHouse_2.TabStop = false;
            this.picHouse_2.Visible = false;
            // 
            // picHouse_3
            // 
            this.picHouse_3.BackColor = System.Drawing.Color.Transparent;
            this.picHouse_3.Enabled = false;
            this.picHouse_3.Image = global::Lokaverkefni.Properties.Resources.Blue_house;
            this.picHouse_3.Location = new System.Drawing.Point(562, 429);
            this.picHouse_3.Name = "picHouse_3";
            this.picHouse_3.Size = new System.Drawing.Size(133, 126);
            this.picHouse_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHouse_3.TabIndex = 15;
            this.picHouse_3.TabStop = false;
            this.picHouse_3.Visible = false;
            // 
            // picHouse_1
            // 
            this.picHouse_1.BackColor = System.Drawing.Color.Transparent;
            this.picHouse_1.Enabled = false;
            this.picHouse_1.Image = global::Lokaverkefni.Properties.Resources.Blue_house;
            this.picHouse_1.Location = new System.Drawing.Point(331, 429);
            this.picHouse_1.Name = "picHouse_1";
            this.picHouse_1.Size = new System.Drawing.Size(133, 126);
            this.picHouse_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHouse_1.TabIndex = 13;
            this.picHouse_1.TabStop = false;
            this.picHouse_1.Visible = false;
            // 
            // picBurnedhouse_1
            // 
            this.picBurnedhouse_1.BackColor = System.Drawing.Color.Transparent;
            this.picBurnedhouse_1.Enabled = false;
            this.picBurnedhouse_1.Image = global::Lokaverkefni.Properties.Resources.Burning_House;
            this.picBurnedhouse_1.Location = new System.Drawing.Point(331, 429);
            this.picBurnedhouse_1.Name = "picBurnedhouse_1";
            this.picBurnedhouse_1.Size = new System.Drawing.Size(133, 126);
            this.picBurnedhouse_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurnedhouse_1.TabIndex = 16;
            this.picBurnedhouse_1.TabStop = false;
            this.picBurnedhouse_1.Visible = false;
            // 
            // picBurnedhouse_2
            // 
            this.picBurnedhouse_2.BackColor = System.Drawing.Color.Transparent;
            this.picBurnedhouse_2.Enabled = false;
            this.picBurnedhouse_2.Image = global::Lokaverkefni.Properties.Resources.Burning_House;
            this.picBurnedhouse_2.Location = new System.Drawing.Point(562, 429);
            this.picBurnedhouse_2.Name = "picBurnedhouse_2";
            this.picBurnedhouse_2.Size = new System.Drawing.Size(133, 126);
            this.picBurnedhouse_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurnedhouse_2.TabIndex = 17;
            this.picBurnedhouse_2.TabStop = false;
            this.picBurnedhouse_2.Visible = false;
            // 
            // picBurnedhouse_3
            // 
            this.picBurnedhouse_3.BackColor = System.Drawing.Color.Transparent;
            this.picBurnedhouse_3.Enabled = false;
            this.picBurnedhouse_3.Image = global::Lokaverkefni.Properties.Resources.Burning_House_2;
            this.picBurnedhouse_3.Location = new System.Drawing.Point(435, 429);
            this.picBurnedhouse_3.Name = "picBurnedhouse_3";
            this.picBurnedhouse_3.Size = new System.Drawing.Size(133, 126);
            this.picBurnedhouse_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBurnedhouse_3.TabIndex = 18;
            this.picBurnedhouse_3.TabStop = false;
            this.picBurnedhouse_3.Visible = false;
            // 
            // Village
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lokaverkefni.Properties.Resources.Backround3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 603);
            this.Controls.Add(this.picBurnedhouse_3);
            this.Controls.Add(this.picBurnedhouse_2);
            this.Controls.Add(this.picBurnedhouse_1);
            this.Controls.Add(this.picHouse_3);
            this.Controls.Add(this.picHouse_1);
            this.Controls.Add(this.picHouse_2);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lbllevel);
            this.Controls.Add(this.piccoin1);
            this.Controls.Add(this.lblcoins);
            this.Controls.Add(this.prbcoal);
            this.Controls.Add(this.prbmeat);
            this.Controls.Add(this.prbsteel);
            this.Controls.Add(this.prbwood);
            this.Controls.Add(this.btncoal);
            this.Controls.Add(this.btnmeat);
            this.Controls.Add(this.btnsteel);
            this.Controls.Add(this.btnwood);
            this.DoubleBuffered = true;
            this.Name = "Village";
            this.Text = "Village";
            this.Load += new System.EventHandler(this.Village_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piccoin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHouse_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurnedhouse_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurnedhouse_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurnedhouse_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnwood;
        private System.Windows.Forms.Button btnsteel;
        private System.Windows.Forms.Button btnmeat;
        private System.Windows.Forms.Button btncoal;
        private System.Windows.Forms.ProgressBar prbwood;
        private System.Windows.Forms.ProgressBar prbsteel;
        private System.Windows.Forms.ProgressBar prbmeat;
        private System.Windows.Forms.ProgressBar prbcoal;
        private System.Windows.Forms.Label lblcoins;
        private System.Windows.Forms.PictureBox piccoin1;
        private System.Windows.Forms.Label lbllevel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox picHouse_2;
        private System.Windows.Forms.PictureBox picHouse_3;
        private System.Windows.Forms.PictureBox picHouse_1;
        private System.Windows.Forms.PictureBox picBurnedhouse_1;
        private System.Windows.Forms.PictureBox picBurnedhouse_2;
        private System.Windows.Forms.PictureBox picBurnedhouse_3;
    }
}