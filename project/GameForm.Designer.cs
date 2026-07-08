namespace Project
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            GameTimer = new System.Windows.Forms.Timer(components);
            lblStageCounter = new Label();
            lblHP = new Label();
            SuspendLayout();
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Tick += GameTick;
            // 
            // lblStageCounter
            // 
            lblStageCounter.AutoSize = true;
            lblStageCounter.Location = new Point(750, 5);
            lblStageCounter.Margin = new Padding(2, 0, 2, 0);
            lblStageCounter.Name = "lblStageCounter";
            lblStageCounter.Size = new Size(13, 15);
            lblStageCounter.TabIndex = 0;
            lblStageCounter.Text = "1";
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.Location = new Point(169, 19);
            lblHP.Margin = new Padding(2, 0, 2, 0);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(38, 15);
            lblHP.TabIndex = 1;
            lblHP.Text = "label1";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 332);
            Controls.Add(lblHP);
            Controls.Add(lblStageCounter);
            KeyPreview = true;
            Margin = new Padding(2);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Paint += Paint_GameForm;
            KeyDown += KeyDown_GameForm;
            KeyUp += KeyUp_GameForm;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameTimer;
        private Label lblStageCounter;
        private Label lblHP;
    }
}
