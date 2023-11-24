namespace NavalBattle.Forms;

partial class Login
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
        panel1 = new Panel();
        label3 = new Label();
        label2 = new Label();
        textBox2 = new TextBox();
        textBox1 = new TextBox();
        label1 = new Label();
        button1 = new Button();
        panel2 = new Panel();
        button3 = new Button();
        label7 = new Label();
        textBox5 = new TextBox();
        label4 = new Label();
        label5 = new Label();
        textBox3 = new TextBox();
        textBox4 = new TextBox();
        label6 = new Label();
        button2 = new Button();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.GradientActiveCaption;
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(textBox2);
        panel1.Controls.Add(textBox1);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(button1);
        panel1.Location = new Point(12, 12);
        panel1.Name = "panel1";
        panel1.Size = new Size(300, 226);
        panel1.TabIndex = 0;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(28, 94);
        label3.Name = "label3";
        label3.Size = new Size(76, 21);
        label3.TabIndex = 5;
        label3.Text = "Password";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(28, 33);
        label2.Name = "label2";
        label2.Size = new Size(80, 21);
        label2.TabIndex = 4;
        label2.Text = "Nickname";
        // 
        // textBox2
        // 
        textBox2.Location = new Point(28, 118);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(244, 23);
        textBox2.TabIndex = 3;
        textBox2.TextChanged += textBox2_TextChanged;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(28, 57);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(244, 23);
        textBox1.TabIndex = 2;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
        label1.Location = new Point(99, 201);
        label1.Name = "label1";
        label1.Size = new Size(90, 15);
        label1.TabIndex = 1;
        label1.Text = "+ New Account";
        label1.Click += label1_Click;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.ButtonHighlight;
        button1.Location = new Point(99, 169);
        button1.Name = "button1";
        button1.Size = new Size(90, 29);
        button1.TabIndex = 0;
        button1.Text = "Login";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // panel2
        // 
        panel2.BackColor = SystemColors.GradientActiveCaption;
        panel2.Controls.Add(button3);
        panel2.Controls.Add(label7);
        panel2.Controls.Add(textBox5);
        panel2.Controls.Add(label4);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(textBox3);
        panel2.Controls.Add(textBox4);
        panel2.Controls.Add(label6);
        panel2.Controls.Add(button2);
        panel2.Location = new Point(12, 12);
        panel2.Name = "panel2";
        panel2.Size = new Size(300, 226);
        panel2.TabIndex = 6;
        panel2.Visible = false;
        // 
        // button3
        // 
        button3.Location = new Point(28, 175);
        button3.Name = "button3";
        button3.Size = new Size(90, 29);
        button3.TabIndex = 8;
        button3.Text = "Cancel";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(28, 71);
        label7.Name = "label7";
        label7.Size = new Size(52, 21);
        label7.TabIndex = 7;
        label7.Text = "Name";
        label7.Click += label7_Click;
        // 
        // textBox5
        // 
        textBox5.Location = new Point(28, 96);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(244, 23);
        textBox5.TabIndex = 6;
        textBox5.TextChanged += textBox5_TextChanged;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(28, 122);
        label4.Name = "label4";
        label4.Size = new Size(76, 21);
        label4.TabIndex = 5;
        label4.Text = "Password";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(28, 21);
        label5.Name = "label5";
        label5.Size = new Size(80, 21);
        label5.TabIndex = 4;
        label5.Text = "Nickname";
        // 
        // textBox3
        // 
        textBox3.Location = new Point(28, 146);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(244, 23);
        textBox3.TabIndex = 3;
        textBox3.TextChanged += textBox3_TextChanged;
        // 
        // textBox4
        // 
        textBox4.Location = new Point(28, 45);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(244, 23);
        textBox4.TabIndex = 2;
        textBox4.TextChanged += textBox4_TextChanged;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
        label6.Location = new Point(105, 201);
        label6.Name = "label6";
        label6.Size = new Size(0, 15);
        label6.TabIndex = 1;
        // 
        // button2
        // 
        button2.Location = new Point(182, 175);
        button2.Name = "button2";
        button2.Size = new Size(90, 29);
        button2.TabIndex = 0;
        button2.Text = "Register";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(326, 250);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Login";
        Text = "Form1";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Button button1;
    private Label label3;
    private Label label2;
    private TextBox textBox2;
    private TextBox textBox1;
    private Label label1;
    private Panel panel2;
    private Label label7;
    private TextBox textBox5;
    private Label label4;
    private Label label5;
    private TextBox textBox3;
    private TextBox textBox4;
    private Label label6;
    private Button button2;
    private Button button3;
}
