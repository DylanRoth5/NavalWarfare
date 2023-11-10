namespace NavalWarfare
{
    partial class gCoop
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
            btCoopClose = new Button();
            panel1 = new Panel();
            btCoopStart = new Button();
            SuspendLayout();
            // 
            // btCoopClose
            // 
            btCoopClose.Location = new Point(23, 30);
            btCoopClose.Name = "btCoopClose";
            btCoopClose.Size = new Size(94, 29);
            btCoopClose.TabIndex = 0;
            btCoopClose.Text = "CERRAR";
            btCoopClose.UseVisualStyleBackColor = true;
            btCoopClose.Click += btCoopClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Location = new Point(174, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 508);
            panel1.TabIndex = 1;
            // 
            // btCoopStart
            // 
            btCoopStart.Location = new Point(23, 111);
            btCoopStart.Name = "btCoopStart";
            btCoopStart.Size = new Size(94, 29);
            btCoopStart.TabIndex = 2;
            btCoopStart.Text = "START";
            btCoopStart.UseVisualStyleBackColor = true;
            btCoopStart.Click += btCoopStart_Click;
            // 
            // gCoop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 578);
            Controls.Add(btCoopStart);
            Controls.Add(panel1);
            Controls.Add(btCoopClose);
            Name = "gCoop";
            Text = "gCoop";
            ResumeLayout(false);
        }

        #endregion

        private Button btCoopClose;
        private Panel panel1;
        private Button btCoopStart;
    }
}