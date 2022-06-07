
namespace Ministry
{
    partial class Register_member
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lname = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.statusLb = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contact = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.location = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.age = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Gender = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.ForeColor = System.Drawing.Color.Gray;
            this.fname.Location = new System.Drawing.Point(46, 179);
            this.fname.Multiline = true;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(202, 36);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name";
            this.fname.MouseEnter += new System.EventHandler(this.fname_MouseEnter);
            this.fname.MouseLeave += new System.EventHandler(this.fname_MouseLeave_1);
            this.fname.MouseHover += new System.EventHandler(this.fname_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(46, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 2);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(273, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 2);
            this.panel2.TabIndex = 3;
            // 
            // mname
            // 
            this.mname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.ForeColor = System.Drawing.Color.Gray;
            this.mname.Location = new System.Drawing.Point(273, 179);
            this.mname.Multiline = true;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(202, 36);
            this.mname.TabIndex = 2;
            this.mname.Text = "Middle Name(Optional)";
            this.mname.Enter += new System.EventHandler(this.mname_Enter);
            this.mname.Leave += new System.EventHandler(this.mname_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(519, 215);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 2);
            this.panel3.TabIndex = 5;
            // 
            // lname
            // 
            this.lname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.ForeColor = System.Drawing.Color.Gray;
            this.lname.Location = new System.Drawing.Point(519, 179);
            this.lname.Multiline = true;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(202, 36);
            this.lname.TabIndex = 4;
            this.lname.Text = "Last Name";
            this.lname.Enter += new System.EventHandler(this.lname_Enter);
            this.lname.Leave += new System.EventHandler(this.lname_Leave);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.Silver;
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ForeColor = System.Drawing.Color.Gray;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Single",
            "Maried",
            "Divorced"});
            this.Status.Location = new System.Drawing.Point(191, 260);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(205, 33);
            this.Status.TabIndex = 6;
            // 
            // statusLb
            // 
            this.statusLb.AutoSize = true;
            this.statusLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLb.ForeColor = System.Drawing.Color.Gray;
            this.statusLb.Location = new System.Drawing.Point(41, 263);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(144, 25);
            this.statusLb.TabIndex = 7;
            this.statusLb.Text = "Marital Status";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(426, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(295, 2);
            this.panel4.TabIndex = 9;
            // 
            // contact
            // 
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.ForeColor = System.Drawing.Color.Gray;
            this.contact.Location = new System.Drawing.Point(426, 257);
            this.contact.Multiline = true;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(295, 36);
            this.contact.TabIndex = 8;
            this.contact.Text = "Contact";
            this.contact.Enter += new System.EventHandler(this.contact_Enter);
            this.contact.Leave += new System.EventHandler(this.contact_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(46, 380);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(252, 2);
            this.panel5.TabIndex = 11;
            // 
            // location
            // 
            this.location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.location.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.ForeColor = System.Drawing.Color.Gray;
            this.location.Location = new System.Drawing.Point(46, 344);
            this.location.Multiline = true;
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(252, 36);
            this.location.TabIndex = 10;
            this.location.Text = "Location";
            this.location.Enter += new System.EventHandler(this.location_Enter);
            this.location.Leave += new System.EventHandler(this.location_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(564, 382);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(157, 2);
            this.panel6.TabIndex = 13;
            // 
            // age
            // 
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.ForeColor = System.Drawing.Color.Gray;
            this.age.Location = new System.Drawing.Point(564, 346);
            this.age.Multiline = true;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(157, 36);
            this.age.TabIndex = 12;
            this.age.Text = "Age";
            this.age.Enter += new System.EventHandler(this.age_Enter);
            this.age.Leave += new System.EventHandler(this.age_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(334, 382);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(202, 2);
            this.panel7.TabIndex = 15;
            // 
            // Gender
            // 
            this.Gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.Color.Gray;
            this.Gender.Location = new System.Drawing.Point(334, 346);
            this.Gender.Multiline = true;
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(202, 36);
            this.Gender.TabIndex = 14;
            this.Gender.Text = "Gender(M or F)";
            this.Gender.Enter += new System.EventHandler(this.Gender_Enter);
            this.Gender.Leave += new System.EventHandler(this.Gender_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(46, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(502, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "ADD+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(564, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "REGISTER NEW";
            // 
            // Register_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.age);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.location);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fname);
            this.Name = "Register_member";
            this.Size = new System.Drawing.Size(801, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label statusLb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox Gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}
