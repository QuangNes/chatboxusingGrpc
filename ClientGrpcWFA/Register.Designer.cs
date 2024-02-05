namespace ClientGrpcWFA
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSignin2 = new System.Windows.Forms.Button();
            this.textBoxUsename2 = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.textBoxConfirmpassword = new System.Windows.Forms.TextBox();
            this.buttonSignup2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usename";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirm Password";
            // 
            // buttonSignin2
            // 
            this.buttonSignin2.BackColor = System.Drawing.Color.Khaki;
            this.buttonSignin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignin2.Location = new System.Drawing.Point(652, 28);
            this.buttonSignin2.Name = "buttonSignin2";
            this.buttonSignin2.Size = new System.Drawing.Size(94, 41);
            this.buttonSignin2.TabIndex = 3;
            this.buttonSignin2.Text = "Sign In";
            this.buttonSignin2.UseVisualStyleBackColor = false;
            this.buttonSignin2.Click += new System.EventHandler(this.buttonSignin2_Click);
            // 
            // textBoxUsename2
            // 
            this.textBoxUsename2.Location = new System.Drawing.Point(365, 91);
            this.textBoxUsename2.Name = "textBoxUsename2";
            this.textBoxUsename2.Size = new System.Drawing.Size(200, 22);
            this.textBoxUsename2.TabIndex = 4;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(365, 182);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(200, 22);
            this.textBoxPassword2.TabIndex = 5;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmpassword
            // 
            this.textBoxConfirmpassword.Location = new System.Drawing.Point(365, 283);
            this.textBoxConfirmpassword.Name = "textBoxConfirmpassword";
            this.textBoxConfirmpassword.Size = new System.Drawing.Size(200, 22);
            this.textBoxConfirmpassword.TabIndex = 6;
            this.textBoxConfirmpassword.UseSystemPasswordChar = true;
            // 
            // buttonSignup2
            // 
            this.buttonSignup2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSignup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup2.Location = new System.Drawing.Point(329, 356);
            this.buttonSignup2.Name = "buttonSignup2";
            this.buttonSignup2.Size = new System.Drawing.Size(125, 51);
            this.buttonSignup2.TabIndex = 7;
            this.buttonSignup2.Text = "Sign Up";
            this.buttonSignup2.UseVisualStyleBackColor = false;
            this.buttonSignup2.Click += new System.EventHandler(this.ButtonSignup2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignup2);
            this.Controls.Add(this.textBoxConfirmpassword);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.textBoxUsename2);
            this.Controls.Add(this.buttonSignin2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSignin2;
        private System.Windows.Forms.TextBox textBoxUsename2;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.TextBox textBoxConfirmpassword;
        private System.Windows.Forms.Button buttonSignup2;
    }
}

