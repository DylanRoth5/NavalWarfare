namespace NavalWarfare
{
    partial class gSolo
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
            btSoloClose = new Button();
            SuspendLayout();
            // 
            // btSoloClose
            // 
            btSoloClose.Location = new Point(37, 27);
            btSoloClose.Name = "btSoloClose";
            btSoloClose.Size = new Size(94, 29);
            btSoloClose.TabIndex = 0;
            btSoloClose.Text = "CERRAR";
            btSoloClose.UseVisualStyleBackColor = true;
            btSoloClose.Click += btSoloClose_Click;
            // 
            // gSolo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 574);
            Controls.Add(btSoloClose);
            Name = "gSolo";
            Text = "gSolo";
            Load += gSolo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btSoloClose;
    }
}