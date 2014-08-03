namespace Timing
{
    partial class Main_Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_H = new System.Windows.Forms.Label();
            this.label_M = new System.Windows.Forms.Label();
            this.label_S = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_timeing = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox_music = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "定时时间：";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(82, 199);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(93, 37);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(255, 199);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(93, 37);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(120, 53);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(198, 53);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown2.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(276, 53);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(55, 21);
            this.numericUpDown3.TabIndex = 3;
            this.numericUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "H";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "M";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "S";
            // 
            // label_H
            // 
            this.label_H.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_H.Location = new System.Drawing.Point(22, 18);
            this.label_H.MaximumSize = new System.Drawing.Size(68, 48);
            this.label_H.MinimumSize = new System.Drawing.Size(68, 48);
            this.label_H.Name = "label_H";
            this.label_H.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_H.Size = new System.Drawing.Size(68, 48);
            this.label_H.TabIndex = 5;
            this.label_H.Text = "00";
            this.label_H.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_H.UseMnemonic = false;
            // 
            // label_M
            // 
            this.label_M.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_M.Location = new System.Drawing.Point(134, 18);
            this.label_M.MaximumSize = new System.Drawing.Size(68, 48);
            this.label_M.MinimumSize = new System.Drawing.Size(68, 48);
            this.label_M.Name = "label_M";
            this.label_M.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_M.Size = new System.Drawing.Size(68, 48);
            this.label_M.TabIndex = 5;
            this.label_M.Text = "00";
            this.label_M.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_M.UseMnemonic = false;
            // 
            // label_S
            // 
            this.label_S.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_S.Location = new System.Drawing.Point(246, 18);
            this.label_S.MaximumSize = new System.Drawing.Size(68, 48);
            this.label_S.MinimumSize = new System.Drawing.Size(68, 48);
            this.label_S.Name = "label_S";
            this.label_S.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_S.Size = new System.Drawing.Size(68, 48);
            this.label_S.TabIndex = 5;
            this.label_S.Text = "00";
            this.label_S.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_S.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(90, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 48);
            this.label5.TabIndex = 5;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(202, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 48);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label_S);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label_H);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_M);
            this.panel1.Location = new System.Drawing.Point(51, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 84);
            this.panel1.TabIndex = 6;
            // 
            // label_timeing
            // 
            this.label_timeing.AutoEllipsis = true;
            this.label_timeing.Font = new System.Drawing.Font("幼圆", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_timeing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_timeing.Location = new System.Drawing.Point(12, 53);
            this.label_timeing.Name = "label_timeing";
            this.label_timeing.Size = new System.Drawing.Size(427, 101);
            this.label_timeing.TabIndex = 7;
            this.label_timeing.Text = "定时时间到了，请注意休息哦！！！";
            this.label_timeing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timeing.Visible = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "定时提醒小工具";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "极氷工作室@Hellc_V0.120140730";
            // 
            // checkBox_music
            // 
            this.checkBox_music.AutoSize = true;
            this.checkBox_music.Checked = true;
            this.checkBox_music.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_music.Location = new System.Drawing.Point(1, 248);
            this.checkBox_music.Name = "checkBox_music";
            this.checkBox_music.Size = new System.Drawing.Size(132, 16);
            this.checkBox_music.TabIndex = 9;
            this.checkBox_music.Text = "定时结束打开音乐？";
            this.checkBox_music.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBox_music.UseVisualStyleBackColor = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.checkBox_music);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_timeing);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 300);
            this.MinimumSize = new System.Drawing.Size(455, 300);
            this.Name = "Main_Form";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时提醒小工具";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.SizeChanged += new System.EventHandler(this.Main_Form_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_H;
        private System.Windows.Forms.Label label_M;
        private System.Windows.Forms.Label label_S;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_timeing;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox_music;
    }
}

