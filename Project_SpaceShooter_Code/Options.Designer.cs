namespace WF1_Training
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            lblOption = new Label();
            pnlDivider = new Panel();
            grpAudio = new GroupBox();
            trkSFX = new TrackBar();
            chkSFX = new CheckBox();
            lblSFX = new Label();
            trkMusic = new TrackBar();
            chkAudio = new CheckBox();
            lblMusic = new Label();
            grpControls = new GroupBox();
            lblDes3 = new Label();
            lblPause = new Label();
            lblDes2 = new Label();
            lblShooting = new Label();
            lblDes = new Label();
            lblMove = new Label();
            btnBack = new Button();
            grpAudio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trkSFX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trkMusic).BeginInit();
            grpControls.SuspendLayout();
            SuspendLayout();
            // 
            // lblOption
            // 
            lblOption.BackColor = Color.Transparent;
            lblOption.Font = new Font("Tw Cen MT", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.ForeColor = Color.FromArgb(220, 240, 255);
            lblOption.Location = new Point(12, 9);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(760, 60);
            lblOption.TabIndex = 0;
            lblOption.Text = "Options";
            lblOption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDivider
            // 
            pnlDivider.BackColor = Color.FromArgb(58, 106, 170);
            pnlDivider.Location = new Point(69, 69);
            pnlDivider.Name = "pnlDivider";
            pnlDivider.Size = new Size(649, 1);
            pnlDivider.TabIndex = 1;
            // 
            // grpAudio
            // 
            grpAudio.BackColor = Color.Transparent;
            grpAudio.Controls.Add(trkSFX);
            grpAudio.Controls.Add(chkSFX);
            grpAudio.Controls.Add(lblSFX);
            grpAudio.Controls.Add(trkMusic);
            grpAudio.Controls.Add(chkAudio);
            grpAudio.Controls.Add(lblMusic);
            grpAudio.Font = new Font("Simplified Arabic Fixed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAudio.ForeColor = Color.FromArgb(122, 184, 245);
            grpAudio.Location = new Point(20, 85);
            grpAudio.Name = "grpAudio";
            grpAudio.Size = new Size(360, 220);
            grpAudio.TabIndex = 2;
            grpAudio.TabStop = false;
            grpAudio.Text = "Audio Setting";
            // 
            // trkSFX
            // 
            trkSFX.Anchor = AnchorStyles.None;
            trkSFX.AutoSize = false;
            trkSFX.BackColor = Color.FromArgb(5, 13, 26);
            trkSFX.LargeChange = 10;
            trkSFX.Location = new Point(10, 140);
            trkSFX.Margin = new Padding(0);
            trkSFX.Maximum = 100;
            trkSFX.Name = "trkSFX";
            trkSFX.Size = new Size(300, 30);
            trkSFX.TabIndex = 5;
            trkSFX.Value = 100;
            // 
            // chkSFX
            // 
            chkSFX.Checked = true;
            chkSFX.CheckState = CheckState.Checked;
            chkSFX.Location = new Point(320, 110);
            chkSFX.Margin = new Padding(0);
            chkSFX.Name = "chkSFX";
            chkSFX.Size = new Size(20, 20);
            chkSFX.TabIndex = 4;
            chkSFX.Text = "checkBox1";
            chkSFX.UseVisualStyleBackColor = true;
            chkSFX.CheckedChanged += chkSFX_CheckedChanged;
            // 
            // lblSFX
            // 
            lblSFX.Font = new Font("Simplified Arabic Fixed", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSFX.ForeColor = Color.FromArgb(232, 240, 255);
            lblSFX.Location = new Point(10, 110);
            lblSFX.Name = "lblSFX";
            lblSFX.Size = new Size(150, 20);
            lblSFX.TabIndex = 3;
            lblSFX.Text = "Sound Effects";
            // 
            // trkMusic
            // 
            trkMusic.Anchor = AnchorStyles.None;
            trkMusic.AutoSize = false;
            trkMusic.BackColor = Color.FromArgb(5, 13, 26);
            trkMusic.LargeChange = 10;
            trkMusic.Location = new Point(10, 60);
            trkMusic.Margin = new Padding(0);
            trkMusic.Maximum = 100;
            trkMusic.Name = "trkMusic";
            trkMusic.Size = new Size(300, 30);
            trkMusic.TabIndex = 2;
            trkMusic.Value = 80;
            // 
            // chkAudio
            // 
            chkAudio.Checked = true;
            chkAudio.CheckState = CheckState.Checked;
            chkAudio.Location = new Point(320, 30);
            chkAudio.Name = "chkAudio";
            chkAudio.Size = new Size(20, 20);
            chkAudio.TabIndex = 1;
            chkAudio.Text = "checkBox1";
            chkAudio.UseVisualStyleBackColor = true;
            chkAudio.CheckedChanged += chkAudio_CheckedChanged;
            // 
            // lblMusic
            // 
            lblMusic.ForeColor = Color.FromArgb(232, 240, 255);
            lblMusic.Location = new Point(10, 30);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(150, 20);
            lblMusic.TabIndex = 0;
            lblMusic.Text = "BG Music";
            // 
            // grpControls
            // 
            grpControls.BackColor = Color.Transparent;
            grpControls.Controls.Add(lblDes3);
            grpControls.Controls.Add(lblPause);
            grpControls.Controls.Add(lblDes2);
            grpControls.Controls.Add(lblShooting);
            grpControls.Controls.Add(lblDes);
            grpControls.Controls.Add(lblMove);
            grpControls.Font = new Font("Simplified Arabic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpControls.ForeColor = Color.FromArgb(122, 184, 245);
            grpControls.Location = new Point(400, 85);
            grpControls.Name = "grpControls";
            grpControls.Size = new Size(360, 220);
            grpControls.TabIndex = 3;
            grpControls.TabStop = false;
            grpControls.Text = "Controls Guide";
            // 
            // lblDes3
            // 
            lblDes3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDes3.ForeColor = Color.FromArgb(168, 196, 232);
            lblDes3.Location = new Point(194, 161);
            lblDes3.Name = "lblDes3";
            lblDes3.Size = new Size(160, 30);
            lblDes3.TabIndex = 5;
            lblDes3.Text = "Pause";
            lblDes3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPause
            // 
            lblPause.BackColor = Color.FromArgb(10, 31, 61);
            lblPause.BorderStyle = BorderStyle.FixedSingle;
            lblPause.Font = new Font("Snap ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPause.ForeColor = Color.FromArgb(232, 240, 255);
            lblPause.Location = new Point(16, 161);
            lblPause.Margin = new Padding(0);
            lblPause.Name = "lblPause";
            lblPause.Size = new Size(154, 30);
            lblPause.TabIndex = 4;
            lblPause.Text = "ESC";
            lblPause.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDes2
            // 
            lblDes2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDes2.ForeColor = Color.FromArgb(168, 196, 232);
            lblDes2.Location = new Point(194, 101);
            lblDes2.Name = "lblDes2";
            lblDes2.Size = new Size(160, 30);
            lblDes2.TabIndex = 3;
            lblDes2.Text = "Shooting";
            lblDes2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblShooting
            // 
            lblShooting.BackColor = Color.FromArgb(10, 31, 61);
            lblShooting.BorderStyle = BorderStyle.FixedSingle;
            lblShooting.Font = new Font("Snap ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblShooting.ForeColor = Color.FromArgb(232, 240, 255);
            lblShooting.Location = new Point(16, 101);
            lblShooting.Margin = new Padding(0);
            lblShooting.Name = "lblShooting";
            lblShooting.Size = new Size(154, 30);
            lblShooting.TabIndex = 2;
            lblShooting.Text = "Space";
            lblShooting.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDes
            // 
            lblDes.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDes.ForeColor = Color.FromArgb(168, 196, 232);
            lblDes.Location = new Point(194, 41);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(160, 30);
            lblDes.TabIndex = 1;
            lblDes.Text = "Move the spaceship";
            lblDes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMove
            // 
            lblMove.BackColor = Color.FromArgb(10, 31, 61);
            lblMove.BorderStyle = BorderStyle.FixedSingle;
            lblMove.Font = new Font("Snap ITC", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMove.ForeColor = Color.FromArgb(232, 240, 255);
            lblMove.Location = new Point(16, 41);
            lblMove.Margin = new Padding(0);
            lblMove.Name = "lblMove";
            lblMove.Size = new Size(154, 30);
            lblMove.TabIndex = 0;
            lblMove.Text = "W A S D";
            lblMove.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.FromArgb(232, 240, 255);
            btnBack.Location = new Point(340, 390);
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 35);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(grpControls);
            Controls.Add(grpAudio);
            Controls.Add(pnlDivider);
            Controls.Add(lblOption);
            Name = "Options";
            Text = "Options";
            grpAudio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trkSFX).EndInit();
            ((System.ComponentModel.ISupportInitialize)trkMusic).EndInit();
            grpControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblOption;
        private Panel pnlDivider;
        private GroupBox grpAudio;
        private GroupBox grpControls;
        private TrackBar trkMusic;
        private CheckBox chkAudio;
        private Label lblMusic;
        private Label lblSFX;
        private TrackBar trkSFX;
        private CheckBox chkSFX;
        private Label lblMove;
        private Label lblDes;
        private Label lblDes2;
        private Label lblShooting;
        private Label lblDes3;
        private Label lblPause;
        private Button btnBack;
    }
}