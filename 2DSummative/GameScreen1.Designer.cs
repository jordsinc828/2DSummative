namespace _2DSummative
{
    partial class GameScreen1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.replayLabel = new System.Windows.Forms.Label();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 16;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // replayLabel
            // 
            this.replayLabel.AutoSize = true;
            this.replayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replayLabel.Location = new System.Drawing.Point(279, 220);
            this.replayLabel.Name = "replayLabel";
            this.replayLabel.Size = new System.Drawing.Size(218, 42);
            this.replayLabel.TabIndex = 0;
            this.replayLabel.Text = "Play Again?";
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(200, 311);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(169, 103);
            this.yesButton.TabIndex = 2;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(393, 311);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(169, 103);
            this.noButton.TabIndex = 3;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.Location = new System.Drawing.Point(191, 169);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(197, 51);
            this.resultsLabel.TabIndex = 4;
            this.resultsLabel.Text = "You Win!";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(3, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(65, 25);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "Time:";
            // 
            // GameScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.replayLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen1";
            this.Size = new System.Drawing.Size(831, 528);
            this.Load += new System.EventHandler(this.gameTimer_Tick);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen1_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen1_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen1_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label replayLabel;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label TimeLabel;
    }
}
