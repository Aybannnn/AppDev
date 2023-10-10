namespace Login
{
    partial class Form1
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
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            UsernameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(270, 412);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(237, 32);
            linkLabel2.TabIndex = 17;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Connect to Database";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(432, 541);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(128, 28);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(191, 541);
            label4.Name = "label4";
            label4.Size = new Size(244, 28);
            label4.TabIndex = 15;
            label4.Text = "Dont have an account yet?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(301, 466);
            button1.Name = "button1";
            button1.Size = new Size(160, 63);
            button1.TabIndex = 14;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(120, 316);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(120, 184);
            label2.Name = "label2";
            label2.Size = new Size(156, 38);
            label2.TabIndex = 12;
            label2.Text = "Username:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Wingdings", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(120, 357);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = 'l';
            PasswordTextBox.Size = new Size(523, 39);
            PasswordTextBox.TabIndex = 11;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            UsernameTextBox.Location = new Point(120, 225);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(523, 45);
            UsernameTextBox.TabIndex = 10;
            UsernameTextBox.Text = "Enter Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 65);
            label1.Name = "label1";
            label1.Size = new Size(296, 65);
            label1.TabIndex = 9;
            label1.Text = "Login Form";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 717);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button button1;
        private Label label3;
        private Label label2;
        private TextBox PasswordTextBox;
        private TextBox UsernameTextBox;
        private Label label1;
    }
}