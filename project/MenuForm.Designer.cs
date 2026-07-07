namespace Project
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            btnPlay = new Button();
            btnShop = new Button();
            btnOptions = new Button();
            lblTitle = new Label();
            btnAbout = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.Anchor = AnchorStyles.None;
            btnPlay.Font = new Font("Snap ITC", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPlay.Location = new Point(313, 130);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(201, 59);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnShop
            // 
            btnShop.Font = new Font("Snap ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShop.Location = new Point(313, 192);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(201, 59);
            btnShop.TabIndex = 1;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
            // 
            // btnOptions
            // 
            btnOptions.Font = new Font("Snap ITC", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnOptions.Location = new Point(313, 254);
            btnOptions.Name = "btnOptions";
            btnOptions.Size = new Size(201, 59);
            btnOptions.TabIndex = 2;
            btnOptions.Text = "Options";
            btnOptions.UseVisualStyleBackColor = true;
            btnOptions.Click += BtnOption_Click;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(130, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(566, 70);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Space Shooter";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Snap ITC", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAbout.Location = new Point(313, 316);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(201, 59);
            btnAbout.TabIndex = 4;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("Snap ITC", 27.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnQuit.Location = new Point(313, 378);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(201, 59);
            btnQuit.TabIndex = 5;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(810, 473);
            Controls.Add(btnQuit);
            Controls.Add(btnAbout);
            Controls.Add(lblTitle);
            Controls.Add(btnOptions);
            Controls.Add(btnShop);
            Controls.Add(btnPlay);
            DoubleBuffered = true;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini Space Shooter Simulation";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPlay;
        private Button btnShop;
        private Button btnOptions;
        private Label lblTitle;
        private Button btnAbout;
        private Button btnQuit;
    }
}
