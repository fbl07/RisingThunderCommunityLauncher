namespace RTCE_Launcher
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartXOutput = new System.Windows.Forms.Button();
            this.btnSlimDX = new System.Windows.Forms.Button();
            this.btnSCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbP2 = new System.Windows.Forms.RadioButton();
            this.rbP1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnStartXOutput);
            this.groupBox1.Controls.Add(this.btnSlimDX);
            this.groupBox1.Controls.Add(this.btnSCP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DInput / Fighting Sticks / PS3 / PS4 Support";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Note : XOutput only works for 1 player";
            // 
            // btnStartXOutput
            // 
            this.btnStartXOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.btnStartXOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartXOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartXOutput.Location = new System.Drawing.Point(6, 82);
            this.btnStartXOutput.Name = "btnStartXOutput";
            this.btnStartXOutput.Size = new System.Drawing.Size(234, 23);
            this.btnStartXOutput.TabIndex = 3;
            this.btnStartXOutput.Text = "Start XOutput";
            this.btnStartXOutput.UseVisualStyleBackColor = false;
            this.btnStartXOutput.Click += new System.EventHandler(this.btnStartXOutput_Click);
            // 
            // btnSlimDX
            // 
            this.btnSlimDX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.btnSlimDX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSlimDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlimDX.Location = new System.Drawing.Point(126, 43);
            this.btnSlimDX.Name = "btnSlimDX";
            this.btnSlimDX.Size = new System.Drawing.Size(114, 23);
            this.btnSlimDX.TabIndex = 2;
            this.btnSlimDX.Text = "Install SlimDX SDK";
            this.btnSlimDX.UseVisualStyleBackColor = false;
            this.btnSlimDX.Click += new System.EventHandler(this.btnSlimDX_Click);
            // 
            // btnSCP
            // 
            this.btnSCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.btnSCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSCP.Location = new System.Drawing.Point(6, 43);
            this.btnSCP.Name = "btnSCP";
            this.btnSCP.Size = new System.Drawing.Size(114, 23);
            this.btnSCP.TabIndex = 1;
            this.btnSCP.Text = "Install SCP Driver";
            this.btnSCP.UseVisualStyleBackColor = false;
            this.btnSCP.Click += new System.EventHandler(this.btnSCP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XOutput Requirements";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rbP2);
            this.groupBox2.Controls.Add(this.rbP1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtServerAddress);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(311, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Local and Online Play";
            // 
            // rbP2
            // 
            this.rbP2.AutoSize = true;
            this.rbP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbP2.Location = new System.Drawing.Point(10, 123);
            this.rbP2.Name = "rbP2";
            this.rbP2.Size = new System.Drawing.Size(211, 17);
            this.rbP2.TabIndex = 4;
            this.rbP2.Text = "Gamepad / XInput / DInput as Player 2";
            this.rbP2.UseVisualStyleBackColor = true;
            // 
            // rbP1
            // 
            this.rbP1.AutoSize = true;
            this.rbP1.Checked = true;
            this.rbP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbP1.Location = new System.Drawing.Point(10, 99);
            this.rbP1.Name = "rbP1";
            this.rbP1.Size = new System.Drawing.Size(211, 17);
            this.rbP1.TabIndex = 3;
            this.rbP1.TabStop = true;
            this.rbP1.Text = "Gamepad / XInput / DInput as Player 1";
            this.rbP1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Local Play";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.BackColor = System.Drawing.Color.Black;
            this.txtServerAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerAddress.ForeColor = System.Drawing.Color.White;
            this.txtServerAddress.Location = new System.Drawing.Point(6, 42);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(230, 20);
            this.txtServerAddress.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Server Address";
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.btnLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaunch.ForeColor = System.Drawing.Color.White;
            this.btnLaunch.Location = new System.Drawing.Point(207, 369);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(218, 23);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "LAUNCH RISING THUNDER !!";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RTCE_Launcher.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RTCE_Launcher.Properties.Resources.app_bg;
            this.ClientSize = new System.Drawing.Size(616, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(632, 448);
            this.Name = "frmMain";
            this.Text = "Rising Thunder CE Launcher";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSlimDX;
        private System.Windows.Forms.Button btnSCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartXOutput;
        private System.Windows.Forms.RadioButton rbP2;
        private System.Windows.Forms.RadioButton rbP1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

