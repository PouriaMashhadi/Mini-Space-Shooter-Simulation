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
            lblWave = new Label();
            lblHPTitle = new Label();
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
            lblStageCounter.BackColor = Color.Transparent;
            lblStageCounter.Font = new Font("Snap ITC", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblStageCounter.ForeColor = Color.OrangeRed;
            lblStageCounter.Location = new Point(720, 7);
            lblStageCounter.Margin = new Padding(2, 0, 2, 0);
            lblStageCounter.Name = "lblStageCounter";
            lblStageCounter.Size = new Size(26, 31);
            lblStageCounter.TabIndex = 0;
            lblStageCounter.Text = "1";
            // 
            // lblHP
            // 
            lblHP.AutoSize = true;
            lblHP.BackColor = Color.Transparent;
            lblHP.Font = new Font("Snap ITC", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHP.ForeColor = Color.Red;
            lblHP.Location = new Point(118, 10);
            lblHP.Margin = new Padding(2, 0, 2, 0);
            lblHP.Name = "lblHP";
            lblHP.Size = new Size(78, 27);
            lblHP.TabIndex = 1;
            lblHP.Text = "label1";
            // 
            // lblWave
            // 
            lblWave.AutoSize = true;
            lblWave.BackColor = Color.Transparent;
            lblWave.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWave.ForeColor = Color.OrangeRed;
            lblWave.Location = new Point(637, 14);
            lblWave.Name = "lblWave";
            lblWave.Size = new Size(78, 22);
            lblWave.TabIndex = 2;
            lblWave.Text = "Wave :";
            // 
            // lblHPTitle
            // 
            lblHPTitle.AutoSize = true;
            lblHPTitle.BackColor = Color.Transparent;
            lblHPTitle.Font = new Font("Snap ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHPTitle.ForeColor = Color.Red;
            lblHPTitle.Location = new Point(75, 16);
            lblHPTitle.Margin = new Padding(2, 0, 2, 0);
            lblHPTitle.Name = "lblHPTitle";
            lblHPTitle.Size = new Size(39, 22);
            lblHPTitle.TabIndex = 3;
            lblHPTitle.Text = "HP";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 332);
            Controls.Add(lblHPTitle);
            Controls.Add(lblWave);
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
        private Label lblWave;
        private Label lblHPTitle;
    }
}
