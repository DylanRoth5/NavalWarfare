namespace NavalBattle.Forms
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
            lbTitle = new Label();
            btSolo = new Button();
            btCoop = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("OCR A Extended", 50F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(12, 44);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(563, 69);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "NAVAL WARFARE";
            lbTitle.Click += lbTitle_Click;
            // 
            // btSolo
            // 
            btSolo.FlatStyle = FlatStyle.Flat;
            btSolo.ImageAlign = ContentAlignment.MiddleRight;
            btSolo.Location = new Point(12, 173);
            btSolo.Margin = new Padding(3, 2, 3, 2);
            btSolo.Name = "btSolo";
            btSolo.Size = new Size(192, 37);
            btSolo.TabIndex = 1;
            btSolo.Text = "SOLO";
            btSolo.TextAlign = ContentAlignment.MiddleLeft;
            btSolo.UseVisualStyleBackColor = true;
            btSolo.Click += btSolo_Click;
            // 
            // btCoop
            // 
            btCoop.FlatStyle = FlatStyle.Flat;
            btCoop.Location = new Point(12, 214);
            btCoop.Margin = new Padding(3, 2, 3, 2);
            btCoop.Name = "btCoop";
            btCoop.Size = new Size(192, 37);
            btCoop.TabIndex = 2;
            btCoop.Text = "COOP";
            btCoop.TextAlign = ContentAlignment.MiddleLeft;
            btCoop.UseVisualStyleBackColor = true;
            btCoop.Click += btCoop_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 113);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 3;
            label1.Text = ">User";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 132);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(192, 37);
            button1.TabIndex = 4;
            button1.Text = "CONTINUE";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 435);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btCoop);
            Controls.Add(btSolo);
            Controls.Add(lbTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenu";
            Text = "Naval Warfare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btSolo;
        private Button btCoop;
        public Label label1;
        public Button button1;
    }
}