namespace Lokaverkefni
{
    partial class TypingGame
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
            this.lblWord = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRorW = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWord.Location = new System.Drawing.Point(14, 148);
            this.lblWord.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(332, 59);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Word";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(14, 249);
            this.tbWord.Margin = new System.Windows.Forms.Padding(5);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(332, 26);
            this.tbWord.TabIndex = 1;
            this.tbWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbWord_KeyDown);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(109, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(147, 49);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.Location = new System.Drawing.Point(14, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(124, 36);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "Time left: 30";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(222, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "words";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRorW
            // 
            this.lblRorW.Location = new System.Drawing.Point(257, 216);
            this.lblRorW.Name = "lblRorW";
            this.lblRorW.Size = new System.Drawing.Size(89, 28);
            this.lblRorW.TabIndex = 5;
            this.lblRorW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TypingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 355);
            this.Controls.Add(this.lblRorW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.lblWord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TypingGame";
            this.Text = "TypingGame";
            this.Load += new System.EventHandler(this.TypingGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRorW;
    }
}