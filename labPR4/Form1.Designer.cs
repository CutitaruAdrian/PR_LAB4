namespace labPR4
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAttachments = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.mySubject = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recieveEmail = new System.Windows.Forms.TextBox();
            this.myPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.inboxPassword = new System.Windows.Forms.TextBox();
            this.inboxEmail = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Thistle;
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.buttonAttachments);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtbody);
            this.tabPage1.Controls.Add(this.mySubject);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.recieveEmail);
            this.tabPage1.Controls.Add(this.myPassword);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.myEmail);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send Email";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(704, 306);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "HTML";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonAttachments
            // 
            this.buttonAttachments.Location = new System.Drawing.Point(56, 253);
            this.buttonAttachments.Name = "buttonAttachments";
            this.buttonAttachments.Size = new System.Drawing.Size(188, 22);
            this.buttonAttachments.TabIndex = 18;
            this.buttonAttachments.Text = "Attachments";
            this.buttonAttachments.UseVisualStyleBackColor = true;
            this.buttonAttachments.Click += new System.EventHandler(this.buttonAttachments_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(816, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Message";
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(293, 49);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(620, 237);
            this.txtbody.TabIndex = 14;
            // 
            // mySubject
            // 
            this.mySubject.Location = new System.Drawing.Point(56, 196);
            this.mySubject.Name = "mySubject";
            this.mySubject.Size = new System.Drawing.Size(188, 20);
            this.mySubject.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Recieve\'s email";
            // 
            // recieveEmail
            // 
            this.recieveEmail.Location = new System.Drawing.Point(56, 146);
            this.recieveEmail.Name = "recieveEmail";
            this.recieveEmail.Size = new System.Drawing.Size(188, 20);
            this.recieveEmail.TabIndex = 4;
            // 
            // myPassword
            // 
            this.myPassword.Location = new System.Drawing.Point(56, 94);
            this.myPassword.Name = "myPassword";
            this.myPassword.PasswordChar = '*';
            this.myPassword.Size = new System.Drawing.Size(188, 20);
            this.myPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // myEmail
            // 
            this.myEmail.Location = new System.Drawing.Point(56, 49);
            this.myEmail.Name = "myEmail";
            this.myEmail.Size = new System.Drawing.Size(188, 20);
            this.myEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Wheat;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.Email);
            this.tabPage2.Controls.Add(this.inboxPassword);
            this.tabPage2.Controls.Add(this.inboxEmail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inbox";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(307, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 292);
            this.panel1.TabIndex = 12;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(635, 290);
            this.webBrowser1.TabIndex = 11;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(19, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(271, 220);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(188, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Inbox";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Message";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(75, 17);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 4;
            this.Email.Text = "Email";
            // 
            // inboxPassword
            // 
            this.inboxPassword.Location = new System.Drawing.Point(162, 33);
            this.inboxPassword.Name = "inboxPassword";
            this.inboxPassword.PasswordChar = '*';
            this.inboxPassword.Size = new System.Drawing.Size(128, 20);
            this.inboxPassword.TabIndex = 1;
            // 
            // inboxEmail
            // 
            this.inboxEmail.Location = new System.Drawing.Point(19, 33);
            this.inboxEmail.Name = "inboxEmail";
            this.inboxEmail.Size = new System.Drawing.Size(139, 20);
            this.inboxEmail.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Gmail Client";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.TextBox mySubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox recieveEmail;
        private System.Windows.Forms.TextBox myPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox inboxPassword;
        private System.Windows.Forms.TextBox inboxEmail;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonAttachments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

