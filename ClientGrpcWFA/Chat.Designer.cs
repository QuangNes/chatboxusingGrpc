namespace ClientGrpcWFA
{
    partial class Chat
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
            this.NameUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSendInvite = new System.Windows.Forms.Button();
            this.buttonSendMess = new System.Windows.Forms.Button();
            this.textBoxInvite = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.listBoxGroup = new System.Windows.Forms.ListBox();
            this.listBoxMessage = new System.Windows.Forms.ListBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameUser
            // 
            this.NameUser.BackColor = System.Drawing.Color.Aquamarine;
            this.NameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameUser.Location = new System.Drawing.Point(21, 16);
            this.NameUser.MaximumSize = new System.Drawing.Size(150, 60);
            this.NameUser.Name = "NameUser";
            this.NameUser.Size = new System.Drawing.Size(81, 28);
            this.NameUser.TabIndex = 0;
            this.NameUser.Text = "Name";
            this.NameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Invite";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Message";
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Khaki;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(681, 16);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 36);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSendInvite
            // 
            this.buttonSendInvite.BackColor = System.Drawing.Color.MediumTurquoise;
            this.buttonSendInvite.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendInvite.Location = new System.Drawing.Point(554, 87);
            this.buttonSendInvite.Name = "buttonSendInvite";
            this.buttonSendInvite.Size = new System.Drawing.Size(112, 33);
            this.buttonSendInvite.TabIndex = 4;
            this.buttonSendInvite.Text = "Send invite";
            this.buttonSendInvite.UseVisualStyleBackColor = false;
            this.buttonSendInvite.Click += new System.EventHandler(this.buttonSendInvite_Click);
            // 
            // buttonSendMess
            // 
            this.buttonSendMess.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSendMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendMess.Location = new System.Drawing.Point(554, 146);
            this.buttonSendMess.Name = "buttonSendMess";
            this.buttonSendMess.Size = new System.Drawing.Size(112, 35);
            this.buttonSendMess.TabIndex = 5;
            this.buttonSendMess.Text = "Send";
            this.buttonSendMess.UseVisualStyleBackColor = false;
            this.buttonSendMess.Click += new System.EventHandler(this.buttonSendMess_Click);
            // 
            // textBoxInvite
            // 
            this.textBoxInvite.Location = new System.Drawing.Point(267, 87);
            this.textBoxInvite.Name = "textBoxInvite";
            this.textBoxInvite.Size = new System.Drawing.Size(250, 22);
            this.textBoxInvite.TabIndex = 6;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(267, 152);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(250, 22);
            this.textBoxMessage.TabIndex = 7;
            // 
            // listBoxGroup
            // 
            this.listBoxGroup.FormattingEnabled = true;
            this.listBoxGroup.HorizontalScrollbar = true;
            this.listBoxGroup.ItemHeight = 16;
            this.listBoxGroup.Location = new System.Drawing.Point(73, 204);
            this.listBoxGroup.Name = "listBoxGroup";
            this.listBoxGroup.ScrollAlwaysVisible = true;
            this.listBoxGroup.Size = new System.Drawing.Size(187, 212);
            this.listBoxGroup.TabIndex = 8;
            this.listBoxGroup.SelectedIndexChanged += new System.EventHandler(this.listBoxGroup_SelectedIndexChanged);
            // 
            // listBoxMessage
            // 
            this.listBoxMessage.FormattingEnabled = true;
            this.listBoxMessage.HorizontalScrollbar = true;
            this.listBoxMessage.ItemHeight = 16;
            this.listBoxMessage.Location = new System.Drawing.Point(321, 204);
            this.listBoxMessage.Name = "listBoxMessage";
            this.listBoxMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBoxMessage.ScrollAlwaysVisible = true;
            this.listBoxMessage.Size = new System.Drawing.Size(392, 212);
            this.listBoxMessage.TabIndex = 9;
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(681, 58);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(94, 34);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(708, 425);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(80, 16);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "time";
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.listBoxMessage);
            this.Controls.Add(this.listBoxGroup);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxInvite);
            this.Controls.Add(this.buttonSendMess);
            this.Controls.Add(this.buttonSendInvite);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameUser);
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSendInvite;
        private System.Windows.Forms.Button buttonSendMess;
        private System.Windows.Forms.TextBox textBoxInvite;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.ListBox listBoxGroup;
        private System.Windows.Forms.ListBox listBoxMessage;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTime;
    }
}