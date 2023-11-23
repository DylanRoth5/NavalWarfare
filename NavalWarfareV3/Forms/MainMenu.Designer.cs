namespace NavalWarfareV3.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            lbTitle = new Label();
            btSolo = new Button();
            btCoop = new Button();
            plSolo = new Panel();
            btPause = new Button();
            plTools = new Panel();
            plJuego = new Panel();
            plPause = new Panel();
            btSave = new Button();
            llPause = new Label();
            btBackToGame = new Button();
            plCoop = new Panel();
            plPlayer2 = new Panel();
            btPauseCoop = new Button();
            plToolsCoop = new Panel();
            plPlayer1 = new Panel();
            plSolo.SuspendLayout();
            plPause.SuspendLayout();
            plCoop.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BackColor = Color.Transparent;
            lbTitle.Font = new Font("OCR A Extended", 45F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.WhiteSmoke;
            lbTitle.Location = new Point(60, 89);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(508, 63);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "NAVAL WARFARE";
            lbTitle.Click += lbTitle_Click;
            // 
            // btSolo
            // 
            btSolo.BackColor = Color.Transparent;
            btSolo.FlatAppearance.BorderSize = 0;
            btSolo.FlatStyle = FlatStyle.Flat;
            btSolo.Font = new Font("OCR A Extended", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btSolo.ForeColor = Color.WhiteSmoke;
            btSolo.Location = new Point(209, 201);
            btSolo.Margin = new Padding(3, 2, 3, 2);
            btSolo.Name = "btSolo";
            btSolo.Size = new Size(192, 75);
            btSolo.TabIndex = 1;
            btSolo.Text = "SOLO";
            btSolo.UseVisualStyleBackColor = false;
            btSolo.Click += btSolo_Click;
            // 
            // btCoop
            // 
            btCoop.BackColor = Color.Transparent;
            btCoop.FlatAppearance.BorderSize = 0;
            btCoop.FlatStyle = FlatStyle.Flat;
            btCoop.Font = new Font("OCR A Extended", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btCoop.ForeColor = Color.WhiteSmoke;
            btCoop.Location = new Point(209, 329);
            btCoop.Margin = new Padding(3, 2, 3, 2);
            btCoop.Name = "btCoop";
            btCoop.Size = new Size(192, 75);
            btCoop.TabIndex = 2;
            btCoop.Text = "COOP";
            btCoop.UseVisualStyleBackColor = false;
            btCoop.Click += btCoop_Click;
            // 
            // plSolo
            // 
            plSolo.BackColor = Color.DimGray;
            plSolo.Controls.Add(btPause);
            plSolo.Controls.Add(plTools);
            plSolo.Controls.Add(plJuego);
            plSolo.Location = new Point(810, 12);
            plSolo.Name = "plSolo";
            plSolo.Size = new Size(636, 272);
            plSolo.TabIndex = 3;
            plSolo.Visible = false;
            // 
            // btPause
            // 
            btPause.BackColor = Color.FromArgb(150, 0, 0, 0);
            btPause.BackgroundImageLayout = ImageLayout.None;
            btPause.FlatAppearance.BorderSize = 0;
            btPause.FlatStyle = FlatStyle.Flat;
            btPause.Font = new Font("OCR A Extended", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btPause.ForeColor = Color.WhiteSmoke;
            btPause.Location = new Point(1128, 12);
            btPause.Name = "btPause";
            btPause.Size = new Size(45, 45);
            btPause.TabIndex = 2;
            btPause.Text = "||";
            btPause.UseVisualStyleBackColor = false;
            btPause.Click += btPause_Click;
            // 
            // plTools
            // 
            plTools.BackColor = Color.FromArgb(150, 0, 0, 0);
            plTools.Location = new Point(60, 12);
            plTools.Name = "plTools";
            plTools.Size = new Size(204, 487);
            plTools.TabIndex = 1;
            // 
            // plJuego
            // 
            plJuego.BackColor = Color.FromArgb(150, 0, 0, 0);
            plJuego.Location = new Point(283, 12);
            plJuego.Name = "plJuego";
            plJuego.Size = new Size(626, 487);
            plJuego.TabIndex = 0;
            // 
            // plPause
            // 
            plPause.BackColor = Color.FromArgb(12, 22, 48);
            plPause.BorderStyle = BorderStyle.FixedSingle;
            plPause.Controls.Add(btSave);
            plPause.Controls.Add(llPause);
            plPause.Controls.Add(btBackToGame);
            plPause.Location = new Point(466, 129);
            plPause.Name = "plPause";
            plPause.Size = new Size(253, 253);
            plPause.TabIndex = 0;
            plPause.Visible = false;
            // 
            // btSave
            // 
            btSave.BackColor = Color.Transparent;
            btSave.FlatAppearance.BorderSize = 0;
            btSave.FlatStyle = FlatStyle.Flat;
            btSave.Font = new Font("OCR A Extended", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btSave.ForeColor = Color.WhiteSmoke;
            btSave.Location = new Point(42, 133);
            btSave.Margin = new Padding(3, 2, 3, 2);
            btSave.Name = "btSave";
            btSave.Size = new Size(167, 76);
            btSave.TabIndex = 5;
            btSave.Text = "SAVE AND BACK";
            btSave.UseVisualStyleBackColor = false;
            btSave.Click += btSave_Click;
            // 
            // llPause
            // 
            llPause.AutoSize = true;
            llPause.Font = new Font("OCR A Extended", 35F, FontStyle.Bold, GraphicsUnit.Point);
            llPause.ForeColor = Color.WhiteSmoke;
            llPause.Location = new Point(42, 51);
            llPause.Name = "llPause";
            llPause.Size = new Size(167, 49);
            llPause.TabIndex = 4;
            llPause.Text = "PAUSE";
            // 
            // btBackToGame
            // 
            btBackToGame.BackColor = Color.Transparent;
            btBackToGame.BackgroundImageLayout = ImageLayout.None;
            btBackToGame.FlatAppearance.BorderSize = 0;
            btBackToGame.FlatStyle = FlatStyle.Flat;
            btBackToGame.Font = new Font("OCR A Extended", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btBackToGame.ForeColor = Color.WhiteSmoke;
            btBackToGame.Location = new Point(204, 3);
            btBackToGame.Name = "btBackToGame";
            btBackToGame.Size = new Size(45, 45);
            btBackToGame.TabIndex = 3;
            btBackToGame.Text = "X";
            btBackToGame.UseVisualStyleBackColor = false;
            btBackToGame.Click += btBackToGame_Click;
            // 
            // plCoop
            // 
            plCoop.BackColor = Color.DimGray;
            plCoop.Controls.Add(plPlayer2);
            plCoop.Controls.Add(btPauseCoop);
            plCoop.Controls.Add(plToolsCoop);
            plCoop.Controls.Add(plPlayer1);
            plCoop.Location = new Point(810, 314);
            plCoop.Name = "plCoop";
            plCoop.Size = new Size(1184, 511);
            plCoop.TabIndex = 4;
            plCoop.Visible = false;
            // 
            // plPlayer2
            // 
            plPlayer2.BackColor = Color.FromArgb(150, 0, 0, 0);
            plPlayer2.Location = new Point(681, 12);
            plPlayer2.Name = "plPlayer2";
            plPlayer2.Size = new Size(441, 487);
            plPlayer2.TabIndex = 1;
            // 
            // btPauseCoop
            // 
            btPauseCoop.BackColor = Color.FromArgb(150, 0, 0, 0);
            btPauseCoop.BackgroundImageLayout = ImageLayout.None;
            btPauseCoop.FlatAppearance.BorderSize = 0;
            btPauseCoop.FlatStyle = FlatStyle.Flat;
            btPauseCoop.Font = new Font("OCR A Extended", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btPauseCoop.ForeColor = Color.WhiteSmoke;
            btPauseCoop.Location = new Point(1128, 12);
            btPauseCoop.Name = "btPauseCoop";
            btPauseCoop.Size = new Size(45, 45);
            btPauseCoop.TabIndex = 2;
            btPauseCoop.Text = "||";
            btPauseCoop.UseVisualStyleBackColor = false;
            btPauseCoop.Click += btPauseCoop_Click;
            // 
            // plToolsCoop
            // 
            plToolsCoop.BackColor = Color.FromArgb(150, 0, 0, 0);
            plToolsCoop.Location = new Point(12, 12);
            plToolsCoop.Name = "plToolsCoop";
            plToolsCoop.Size = new Size(216, 487);
            plToolsCoop.TabIndex = 1;
            // 
            // plPlayer1
            // 
            plPlayer1.BackColor = Color.FromArgb(150, 0, 0, 0);
            plPlayer1.Location = new Point(234, 12);
            plPlayer1.Name = "plPlayer1";
            plPlayer1.Size = new Size(441, 487);
            plPlayer1.TabIndex = 0;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1184, 511);
            Controls.Add(plPause);
            Controls.Add(plCoop);
            Controls.Add(plSolo);
            Controls.Add(btCoop);
            Controls.Add(btSolo);
            Controls.Add(lbTitle);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1200, 550);
            MinimumSize = new Size(1200, 550);
            Name = "MainMenu";
            Text = "Naval Warfare";
            plSolo.ResumeLayout(false);
            plPause.ResumeLayout(false);
            plPause.PerformLayout();
            plCoop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btSolo;
        private Button btCoop;
        private Panel plSolo;
        private Panel plJuego;
        private Panel plTools;
        private Button btPause;
        private Panel plPause;
        private Button btBackToGame;
        private Label llPause;
        private Button btSave;
        private Panel plCoop;
        private Panel plPlayer2;
        private Button btPauseCoop;
        private Panel plToolsCoop;
        private Panel plPlayer1;
    }
}