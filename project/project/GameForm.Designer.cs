namespace project
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
            GameTimer = new System.Windows.Forms.Timer(components);
            lblStageCounter = new Label();
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
            lblStageCounter.Location = new Point(1072, 9);
            lblStageCounter.Name = "lblStageCounter";
            lblStageCounter.Size = new Size(22, 25);
            lblStageCounter.TabIndex = 0;
            lblStageCounter.Text = "1";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Options2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1143, 554);
            Controls.Add(lblStageCounter);
            KeyPreview = true;
            Name = "GameForm";
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
    }
}
