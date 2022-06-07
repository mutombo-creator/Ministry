
namespace Ministry
{
    partial class Home_Page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pos_indicator = new System.Windows.Forms.Panel();
            this.Members = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Dashboad = new System.Windows.Forms.Button();
            this.home_control1 = new Ministry.Home_control();
            this.register_member1 = new Ministry.Register_member();
            this.data_Control1 = new Ministry.data_Control();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 28);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "P.Gondwe Ministry";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ministry.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(906, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.BackgroundImage = global::Ministry.Properties.Resources.cross;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(952, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 28);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pos_indicator);
            this.panel2.Controls.Add(this.Members);
            this.panel2.Controls.Add(this.Register);
            this.panel2.Controls.Add(this.Dashboad);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 510);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Ministry.Properties.Resources.IMG_20220115_WA0003;
            this.pictureBox7.Location = new System.Drawing.Point(12, 9);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(136, 96);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pos_indicator
            // 
            this.pos_indicator.BackColor = System.Drawing.Color.Blue;
            this.pos_indicator.Location = new System.Drawing.Point(2, 128);
            this.pos_indicator.Name = "pos_indicator";
            this.pos_indicator.Size = new System.Drawing.Size(10, 30);
            this.pos_indicator.TabIndex = 2;
            // 
            // Members
            // 
            this.Members.FlatAppearance.BorderSize = 0;
            this.Members.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Members.ForeColor = System.Drawing.Color.White;
            this.Members.Location = new System.Drawing.Point(12, 213);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(150, 33);
            this.Members.TabIndex = 2;
            this.Members.Text = "Members";
            this.Members.UseVisualStyleBackColor = true;
            this.Members.Click += new System.EventHandler(this.Members_Click);
            // 
            // Register
            // 
            this.Register.FlatAppearance.BorderSize = 0;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(12, 172);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(150, 30);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Dashboad
            // 
            this.Dashboad.FlatAppearance.BorderSize = 0;
            this.Dashboad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboad.ForeColor = System.Drawing.Color.White;
            this.Dashboad.Location = new System.Drawing.Point(12, 127);
            this.Dashboad.Name = "Dashboad";
            this.Dashboad.Size = new System.Drawing.Size(150, 30);
            this.Dashboad.TabIndex = 0;
            this.Dashboad.Text = "DashBoad";
            this.Dashboad.UseVisualStyleBackColor = true;
            this.Dashboad.Click += new System.EventHandler(this.Dashboad_Click);
            // 
            // home_control1
            // 
            this.home_control1.home = null;
            this.home_control1.Location = new System.Drawing.Point(171, 34);
            this.home_control1.Name = "home_control1";
            this.home_control1.Size = new System.Drawing.Size(801, 492);
            this.home_control1.TabIndex = 3;
            // 
            // register_member1
            // 
            this.register_member1.BackColor = System.Drawing.Color.White;
            this.register_member1.Location = new System.Drawing.Point(171, 37);
            this.register_member1.Name = "register_member1";
            this.register_member1.Size = new System.Drawing.Size(801, 492);
            this.register_member1.TabIndex = 2;
            // 
            // data_Control1
            // 
            this.data_Control1.Location = new System.Drawing.Point(164, 28);
            this.data_Control1.Name = "data_Control1";
            this.data_Control1.Size = new System.Drawing.Size(801, 492);
            this.data_Control1.TabIndex = 4;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(977, 538);
            this.Controls.Add(this.data_Control1);
            this.Controls.Add(this.home_control1);
            this.Controls.Add(this.register_member1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home_Page";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pos_indicator;
        private System.Windows.Forms.Button Members;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button Dashboad;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        public Register_member register_member1;
        public Home_control home_control1;
        private System.Windows.Forms.Label label1;
        private data_Control data_Control1;
    }
}