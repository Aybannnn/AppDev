namespace Login
{
    partial class Form2
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
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            button1 = new Button();
            cmbTypeofUser = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            UsernameTextBox = new TextBox();
            label3 = new Label();
            PasswordTextBox = new TextBox();
            label2 = new Label();
            NameTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(601, 511);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(106, 28);
            linkLabel1.TabIndex = 31;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login Here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(368, 511);
            label7.Name = "label7";
            label7.Size = new Size(237, 28);
            label7.TabIndex = 30;
            label7.Text = "Already have an account?";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(433, 431);
            button1.Name = "button1";
            button1.Size = new Size(225, 64);
            button1.TabIndex = 29;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbTypeofUser
            // 
            cmbTypeofUser.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            cmbTypeofUser.FormattingEnabled = true;
            cmbTypeofUser.Items.AddRange(new object[] { "User", "Admin" });
            cmbTypeofUser.Location = new Point(586, 328);
            cmbTypeofUser.Name = "cmbTypeofUser";
            cmbTypeofUser.Size = new Size(471, 46);
            cmbTypeofUser.TabIndex = 26;
            cmbTypeofUser.Text = "Type of User";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(586, 287);
            label5.Name = "label5";
            label5.Size = new Size(190, 38);
            label5.TabIndex = 25;
            label5.Text = "Type of User:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(586, 157);
            label4.Name = "label4";
            label4.Size = new Size(156, 38);
            label4.TabIndex = 24;
            label4.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            UsernameTextBox.Location = new Point(586, 198);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(471, 45);
            UsernameTextBox.TabIndex = 23;
            UsernameTextBox.Text = "Enter Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 287);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 22;
            label3.Text = "Password:";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(45, 328);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(471, 45);
            PasswordTextBox.TabIndex = 21;
            PasswordTextBox.Text = "Enter Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 157);
            label2.Name = "label2";
            label2.Size = new Size(103, 38);
            label2.TabIndex = 20;
            label2.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 14F, FontStyle.Italic, GraphicsUnit.Point);
            NameTextBox.Location = new Point(45, 198);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(471, 45);
            NameTextBox.TabIndex = 19;
            NameTextBox.Text = "Enter First Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 42);
            label1.Name = "label1";
            label1.Size = new Size(361, 65);
            label1.TabIndex = 18;
            label1.Text = "Register Form";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 644);
            Controls.Add(linkLabel1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(cmbTypeofUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(UsernameTextBox);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(NameTextBox);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label7;
        private Button button1;
        private ComboBox cmbTypeofUser;
        private Label label5;
        private Label label4;
        private TextBox UsernameTextBox;
        private Label label3;
        private TextBox PasswordTextBox;
        private Label label2;
        private TextBox NameTextBox;
        private Label label1;
    }
}