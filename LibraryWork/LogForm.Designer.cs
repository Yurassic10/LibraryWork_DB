

namespace LibraryWork
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            mainPanel = new Panel();
            singInButton = new Button();
            registerLabel = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            closeLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.SandyBrown;
            mainPanel.Controls.Add(singInButton);
            mainPanel.Controls.Add(registerLabel);
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(pictureBox2);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(passwordLabel);
            mainPanel.Controls.Add(emailLabel);
            mainPanel.Controls.Add(textBox2);
            mainPanel.Controls.Add(textBox1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(4, 3, 4, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(457, 450);
            mainPanel.TabIndex = 0;
            // 
            // singInButton
            // 
            singInButton.BackColor = Color.Chocolate;
            singInButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            singInButton.Location = new Point(99, 320);
            singInButton.Margin = new Padding(4, 3, 4, 3);
            singInButton.Name = "singInButton";
            singInButton.Size = new Size(273, 60);
            singInButton.TabIndex = 10;
            singInButton.Text = "Sign in";
            singInButton.UseVisualStyleBackColor = false;
            singInButton.Click += singInButton_Click;
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            registerLabel.Location = new Point(302, 413);
            registerLabel.Margin = new Padding(4, 0, 4, 0);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(59, 16);
            registerLabel.TabIndex = 9;
            registerLabel.Text = "Sing up";
            registerLabel.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(96, 413);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 15);
            label3.TabIndex = 8;
            label3.Text = "Don't have an account yet?";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Chocolate;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(closeLabel);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(455, 96);
            panel2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 48);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(361, 22);
            label2.TabIndex = 1;
            label2.Text = "Welcome, dear reader!";
            // 
            // closeLabel
            // 
            closeLabel.AutoSize = true;
            closeLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeLabel.Location = new Point(418, 10);
            closeLabel.Margin = new Padding(4, 0, 4, 0);
            closeLabel.Name = "closeLabel";
            closeLabel.Size = new Size(21, 20);
            closeLabel.TabIndex = 0;
            closeLabel.Text = "X";
            closeLabel.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 224);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 148);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            passwordLabel.Location = new Point(105, 254);
            passwordLabel.Margin = new Padding(4, 0, 4, 0);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            emailLabel.Location = new Point(144, 178);
            emailLabel.Margin = new Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(53, 20);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(212, 256);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 2;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(212, 178);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 1;
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            ClientSize = new Size(457, 450);
            Controls.Add(mainPanel);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LogForm";
            Text = "LogForm";
            Load += LogForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label closeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button singInButton;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label label3;
    }
}