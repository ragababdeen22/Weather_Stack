
namespace Weather_Stack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_state = new System.Windows.Forms.PictureBox();
            this.lb_des = new System.Windows.Forms.Label();
            this.lb_city = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_wind = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_hum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_tep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_state)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 51);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(755, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 37);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "Weather$";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(817, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 37);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.pic_state);
            this.panel2.Controls.Add(this.lb_des);
            this.panel2.Controls.Add(this.lb_city);
            this.panel2.Location = new System.Drawing.Point(249, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 230);
            this.panel2.TabIndex = 2;
            // 
            // pic_state
            // 
            this.pic_state.BackColor = System.Drawing.Color.Transparent;
            this.pic_state.Image = ((System.Drawing.Image)(resources.GetObject("pic_state.Image")));
            this.pic_state.Location = new System.Drawing.Point(88, 66);
            this.pic_state.Name = "pic_state";
            this.pic_state.Size = new System.Drawing.Size(174, 111);
            this.pic_state.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_state.TabIndex = 2;
            this.pic_state.TabStop = false;
            // 
            // lb_des
            // 
            this.lb_des.AutoSize = true;
            this.lb_des.BackColor = System.Drawing.Color.Transparent;
            this.lb_des.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_des.ForeColor = System.Drawing.Color.White;
            this.lb_des.Location = new System.Drawing.Point(101, 180);
            this.lb_des.Name = "lb_des";
            this.lb_des.Size = new System.Drawing.Size(147, 33);
            this.lb_des.TabIndex = 1;
            this.lb_des.Text = "Description";
            // 
            // lb_city
            // 
            this.lb_city.AutoSize = true;
            this.lb_city.BackColor = System.Drawing.Color.Transparent;
            this.lb_city.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_city.ForeColor = System.Drawing.Color.White;
            this.lb_city.Location = new System.Drawing.Point(101, 19);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(136, 33);
            this.lb_city.TabIndex = 0;
            this.lb_city.Text = "City Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.lb_wind);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(355, 359);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 118);
            this.panel4.TabIndex = 6;
            // 
            // lb_wind
            // 
            this.lb_wind.AutoSize = true;
            this.lb_wind.BackColor = System.Drawing.Color.Transparent;
            this.lb_wind.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_wind.ForeColor = System.Drawing.Color.White;
            this.lb_wind.Location = new System.Drawing.Point(71, 62);
            this.lb_wind.Name = "lb_wind";
            this.lb_wind.Size = new System.Drawing.Size(51, 39);
            this.lb_wind.TabIndex = 1;
            this.lb_wind.Text = "35";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 33);
            this.label6.TabIndex = 0;
            this.label6.Text = "Wind";
            // 
            // lb_hum
            // 
            this.lb_hum.AutoSize = true;
            this.lb_hum.BackColor = System.Drawing.Color.Transparent;
            this.lb_hum.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hum.ForeColor = System.Drawing.Color.White;
            this.lb_hum.Location = new System.Drawing.Point(71, 62);
            this.lb_hum.Name = "lb_hum";
            this.lb_hum.Size = new System.Drawing.Size(51, 39);
            this.lb_hum.TabIndex = 1;
            this.lb_hum.Text = "35";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Humidality";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel5.Controls.Add(this.lb_hum);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(577, 359);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(188, 118);
            this.panel5.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.lb_tep);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(133, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 118);
            this.panel3.TabIndex = 5;
            // 
            // lb_tep
            // 
            this.lb_tep.AutoSize = true;
            this.lb_tep.BackColor = System.Drawing.Color.Transparent;
            this.lb_tep.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tep.ForeColor = System.Drawing.Color.White;
            this.lb_tep.Location = new System.Drawing.Point(71, 62);
            this.lb_tep.Name = "lb_tep";
            this.lb_tep.Size = new System.Drawing.Size(51, 39);
            this.lb_tep.TabIndex = 1;
            this.lb_tep.Text = "35";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 33);
            this.label4.TabIndex = 0;
            this.label4.Text = "Temprature";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(756, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 37);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(17, 82);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 48);
            this.button4.TabIndex = 9;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 533);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_state)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_state;
        private System.Windows.Forms.Label lb_des;
        private System.Windows.Forms.Label lb_city;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lb_wind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_hum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_tep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

