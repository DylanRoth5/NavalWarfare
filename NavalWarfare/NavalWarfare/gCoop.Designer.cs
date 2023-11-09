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
            // gCoop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 578);
            Controls.Add(btCoopClose);
            Name = "gCoop";
            Text = "gCoop";
            ResumeLayout(false);
        }

        #endregion

        private Button btCoopClose;
    }
}