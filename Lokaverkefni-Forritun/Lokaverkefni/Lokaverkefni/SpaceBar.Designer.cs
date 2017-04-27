namespace Lokaverkefni
{
    partial class fSpaceBar
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
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblMain_Timer = new System.Windows.Forms.Label();
            this.lblclicks = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(12, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 13);
            this.lblTimer.TabIndex = 0;
            // 
            // lblMain_Timer
            // 
            this.lblMain_Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain_Timer.Location = new System.Drawing.Point(12, 9);
            this.lblMain_Timer.Name = "lblMain_Timer";
            this.lblMain_Timer.Size = new System.Drawing.Size(153, 30);
            this.lblMain_Timer.TabIndex = 1;
            this.lblMain_Timer.Text = "Time left: 10";
            this.lblMain_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblclicks
            // 
            this.lblclicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclicks.Location = new System.Drawing.Point(279, 9);
            this.lblclicks.Name = "lblclicks";
            this.lblclicks.Size = new System.Drawing.Size(115, 30);
            this.lblclicks.TabIndex = 3;
            this.lblclicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pic1
            // 
            this.pic1.Image = global::Lokaverkefni.Properties.Resources.hand;
            this.pic1.InitialImage = global::Lokaverkefni.Properties.Resources.hand;
            this.pic1.Location = new System.Drawing.Point(37, 87);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(334, 339);
            this.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic1.TabIndex = 4;
            this.pic1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(126, 42);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 39);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(37, 432);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(152, 37);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Back to menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.Location = new System.Drawing.Point(219, 432);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(152, 37);
            this.btnInstructions.TabIndex = 7;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // fSpaceBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 481);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.lblclicks);
            this.Controls.Add(this.lblMain_Timer);
            this.Controls.Add(this.lblTimer);
            this.Name = "fSpaceBar";
            this.Text = "SpaceBar";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fSpaceBar_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblMain_Timer;
        private System.Windows.Forms.Label lblclicks;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnInstructions;
    }
}