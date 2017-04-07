namespace testSI
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(328, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(555, 69);
            this.title.TabIndex = 0;
            this.title.Text = "SPACE INVADERS";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(330, 231);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(569, 55);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "**PLAY**";
            this.playButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highScore
            // 
            this.highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.Location = new System.Drawing.Point(330, 313);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(569, 55);
            this.highScore.TabIndex = 2;
            this.highScore.Text = "HIGH SCORE";
            this.highScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 664);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label playButton;
        private System.Windows.Forms.Label highScore;
    }
}

