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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            btStart = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Location = new Point(199, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 535);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 96);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 2;
            label1.Text = "map size";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 142);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 186);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 234);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 5;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 282);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 6;
            label5.Text = "label5";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(102, 96);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(102, 234);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(70, 27);
            numericUpDown2.TabIndex = 8;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(102, 186);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(70, 27);
            numericUpDown3.TabIndex = 9;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(102, 142);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(70, 27);
            numericUpDown4.TabIndex = 10;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(102, 282);
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(70, 27);
            numericUpDown5.TabIndex = 11;
            // 
            // btStart
            // 
            btStart.Location = new Point(53, 337);
            btStart.Name = "btStart";
            btStart.Size = new Size(94, 29);
            btStart.TabIndex = 12;
            btStart.Text = "START";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // gSolo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 574);
            Controls.Add(btStart);
            Controls.Add(numericUpDown1);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btSoloClose);
            Name = "gSolo";
            Text = "gSolo";
            Load += gSolo_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSoloClose;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private Button btStart;
    }
}