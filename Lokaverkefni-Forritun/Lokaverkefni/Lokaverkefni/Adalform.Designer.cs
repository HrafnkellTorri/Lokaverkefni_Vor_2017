namespace Lokaverkefni
{
    partial class Adalform
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.btnTypingGame = new System.Windows.Forms.Button();
            this.btnSpaceBar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose game:";
            // 
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Location = new System.Drawing.Point(236, 24);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(97, 13);
            this.lblPlaying.TabIndex = 4;
            this.lblPlaying.Text = "You are playing as:";
            // 
            // btnTypingGame
            // 
            this.btnTypingGame.BackColor = System.Drawing.Color.White;
            this.btnTypingGame.BackgroundImage = global::Lokaverkefni.Properties.Resources.typing;
            this.btnTypingGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTypingGame.Location = new System.Drawing.Point(12, 49);
            this.btnTypingGame.Name = "btnTypingGame";
            this.btnTypingGame.Size = new System.Drawing.Size(209, 93);
            this.btnTypingGame.TabIndex = 1;
            this.btnTypingGame.UseVisualStyleBackColor = false;
            this.btnTypingGame.Click += new System.EventHandler(this.btnTypingGame_Click);
            // 
            // btnSpaceBar
            // 
            this.btnSpaceBar.BackColor = System.Drawing.Color.White;
            this.btnSpaceBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpaceBar.Location = new System.Drawing.Point(12, 157);
            this.btnSpaceBar.Name = "btnSpaceBar";
            this.btnSpaceBar.Size = new System.Drawing.Size(209, 93);
            this.btnSpaceBar.TabIndex = 5;
            this.btnSpaceBar.UseVisualStyleBackColor = false;
            this.btnSpaceBar.Click += new System.EventHandler(this.btnSpaceBar_Click);
            // 
            // Adalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 355);
            this.Controls.Add(this.btnSpaceBar);
            this.Controls.Add(this.lblPlaying);
            this.Controls.Add(this.btnTypingGame);
            this.Controls.Add(this.label1);
            this.Name = "Adalform";
            this.Text = "Games";
            this.Load += new System.EventHandler(this.Adalform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTypingGame;
        private System.Windows.Forms.Label lblPlaying;
        private System.Windows.Forms.Button btnSpaceBar;

    }
}