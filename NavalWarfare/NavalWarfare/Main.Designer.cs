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
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("OCR A Extended", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbTitle.Location = new Point(21, 7);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(412, 50);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "NAVAL WARFARE";
            lbTitle.Click += lbTitle_Click;
            // 
            // btSolo
            // 
            btSolo.FlatStyle = FlatStyle.Flat;
            btSolo.Location = new Point(10, 168);
            btSolo.Margin = new Padding(3, 2, 3, 2);
            btSolo.Name = "btSolo";
            btSolo.Size = new Size(192, 75);
            btSolo.TabIndex = 1;
            btSolo.Text = "SOLO";
            btSolo.UseVisualStyleBackColor = true;
            btSolo.Click += btSolo_Click;
            // 
            // btCoop
            // 
            btCoop.FlatStyle = FlatStyle.Flat;
            btCoop.Location = new Point(10, 272);
            btCoop.Margin = new Padding(3, 2, 3, 2);
            btCoop.Name = "btCoop";
            btCoop.Size = new Size(192, 75);
            btCoop.TabIndex = 2;
            btCoop.Text = "COOP";
            btCoop.UseVisualStyleBackColor = true;
            btCoop.Click += btCoop_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 435);
            Controls.Add(btCoop);
            Controls.Add(btSolo);
            Controls.Add(lbTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "Naval Warfare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Button btSolo;
        private Button btCoop;
    }
}