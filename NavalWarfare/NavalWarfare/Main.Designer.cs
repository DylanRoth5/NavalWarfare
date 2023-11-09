namespace NavalWarfare
{
    partial class Main
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
            pSolo = new Panel();
            pCoop = new Panel();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("OCR A Extended", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(24, 9);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(508, 63);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "NAVAL WARFARE";
            lbTitle.Click += lbTitle_Click;
            // 
            // btSolo
            // 
            btSolo.FlatStyle = FlatStyle.Flat;
            btSolo.Location = new Point(12, 224);
            btSolo.Name = "btSolo";
            btSolo.Size = new Size(220, 100);
            btSolo.TabIndex = 1;
            btSolo.Text = "SOLO";
            btSolo.UseVisualStyleBackColor = true;
            btSolo.Click += btSolo_Click;
            // 
            // btCoop
            // 
            btCoop.FlatStyle = FlatStyle.Flat;
            btCoop.Location = new Point(12, 362);
            btCoop.Name = "btCoop";
            btCoop.Size = new Size(220, 100);
            btCoop.TabIndex = 2;
            btCoop.Text = "COOP";
            btCoop.UseVisualStyleBackColor = true;
            btCoop.Click += btCoop_Click;
            // 
            // pSolo
            // 
            pSolo.BackColor = SystemColors.ControlDark;
            pSolo.Location = new Point(555, 37);
            pSolo.Name = "pSolo";
            pSolo.Size = new Size(698, 530);
            pSolo.TabIndex = 3;
            pSolo.Visible = false;
            // 
            // pCoop
            // 
            pCoop.BackColor = SystemColors.ActiveCaption;
            pCoop.Location = new Point(395, 95);
            pCoop.Name = "pCoop";
            pCoop.Size = new Size(62, 58);
            pCoop.TabIndex = 4;
            pCoop.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 580);
            Controls.Add(pCoop);
            Controls.Add(pSolo);
            Controls.Add(btCoop);
            Controls.Add(btSolo);
            Controls.Add(lbTitle);
            Name = "Main";
            Text = "Naval Warfare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btSolo;
        private Button btCoop;
        private Panel pSolo;
        private Panel pCoop;
    }
}