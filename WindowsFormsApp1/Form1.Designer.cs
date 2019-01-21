namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.data_tb = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ports_cb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.baud_cb = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.currentSpeed = new System.Windows.Forms.Label();
            this.heightchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.speedchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.currentHeight = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.timeElapsed = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightchart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedchart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_tb
            // 
            this.data_tb.Location = new System.Drawing.Point(4, 17);
            this.data_tb.Margin = new System.Windows.Forms.Padding(2);
            this.data_tb.Multiline = true;
            this.data_tb.Name = "data_tb";
            this.data_tb.ReadOnly = true;
            this.data_tb.Size = new System.Drawing.Size(201, 565);
            this.data_tb.TabIndex = 0;
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(179, 16);
            this.start_btn.Margin = new System.Windows.Forms.Padding(2);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(145, 56);
            this.start_btn.TabIndex = 1;
            this.start_btn.Text = "Start Monitoring";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Enabled = false;
            this.stop_btn.Location = new System.Drawing.Point(328, 16);
            this.stop_btn.Margin = new System.Windows.Forms.Padding(2);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(145, 56);
            this.stop_btn.TabIndex = 2;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Enabled = false;
            this.save_btn.Location = new System.Drawing.Point(478, 16);
            this.save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(145, 56);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Port Name";
            // 
            // ports_cb
            // 
            this.ports_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ports_cb.FormattingEnabled = true;
            this.ports_cb.Location = new System.Drawing.Point(85, 26);
            this.ports_cb.Margin = new System.Windows.Forms.Padding(2);
            this.ports_cb.Name = "ports_cb";
            this.ports_cb.Size = new System.Drawing.Size(76, 21);
            this.ports_cb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Baud Rate";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // baud_cb
            // 
            this.baud_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baud_cb.FormattingEnabled = true;
            this.baud_cb.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "200000"});
            this.baud_cb.Location = new System.Drawing.Point(85, 53);
            this.baud_cb.Margin = new System.Windows.Forms.Padding(2);
            this.baud_cb.Name = "baud_cb";
            this.baud_cb.Size = new System.Drawing.Size(76, 21);
            this.baud_cb.TabIndex = 12;
            this.baud_cb.SelectedIndexChanged += new System.EventHandler(this.baud_cb_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.baud_cb);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.ports_cb);
            this.groupBox1.Controls.Add(this.stop_btn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.start_btn);
            this.groupBox1.Location = new System.Drawing.Point(11, 136);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(634, 92);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_tb);
            this.groupBox2.Location = new System.Drawing.Point(658, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(209, 582);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Output";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // currentSpeed
            // 
            this.currentSpeed.AutoSize = true;
            this.currentSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSpeed.Location = new System.Drawing.Point(48, 51);
            this.currentSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentSpeed.Name = "currentSpeed";
            this.currentSpeed.Size = new System.Drawing.Size(46, 51);
            this.currentSpeed.TabIndex = 3;
            this.currentSpeed.Text = "0";
            // 
            // heightchart
            // 
            this.heightchart.BackColor = System.Drawing.Color.Transparent;
            this.heightchart.BorderlineColor = System.Drawing.Color.Transparent;
            this.heightchart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea13.Name = "ChartArea1";
            this.heightchart.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.heightchart.Legends.Add(legend13);
            this.heightchart.Location = new System.Drawing.Point(4, 17);
            this.heightchart.Margin = new System.Windows.Forms.Padding(2);
            this.heightchart.Name = "heightchart";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.heightchart.Series.Add(series13);
            this.heightchart.Size = new System.Drawing.Size(626, 153);
            this.heightchart.TabIndex = 21;
            this.heightchart.Text = "chart2";
            // 
            // speedchart
            // 
            this.speedchart.BackColor = System.Drawing.Color.Transparent;
            this.speedchart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea14.Name = "ChartArea1";
            this.speedchart.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.speedchart.Legends.Add(legend14);
            this.speedchart.Location = new System.Drawing.Point(4, 17);
            this.speedchart.Margin = new System.Windows.Forms.Padding(2);
            this.speedchart.Name = "speedchart";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.speedchart.Series.Add(series14);
            this.speedchart.Size = new System.Drawing.Size(626, 127);
            this.speedchart.TabIndex = 22;
            this.speedchart.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.heightchart);
            this.groupBox3.Location = new System.Drawing.Point(11, 390);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(634, 175);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Height Chart";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.speedchart);
            this.groupBox4.Location = new System.Drawing.Point(11, 569);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(634, 149);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Speed Chart";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.currentHeight);
            this.groupBox5.Location = new System.Drawing.Point(11, 247);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(142, 139);
            this.groupBox5.TabIndex = 25;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Water Height";
            // 
            // currentHeight
            // 
            this.currentHeight.AutoSize = true;
            this.currentHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHeight.Location = new System.Drawing.Point(45, 51);
            this.currentHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentHeight.Name = "currentHeight";
            this.currentHeight.Size = new System.Drawing.Size(46, 51);
            this.currentHeight.TabIndex = 1;
            this.currentHeight.Text = "0";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.currentSpeed);
            this.groupBox7.Location = new System.Drawing.Point(166, 247);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(142, 139);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Water Increase Speed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1241, 91);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.timeElapsed);
            this.groupBox6.Location = new System.Drawing.Point(321, 247);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(163, 139);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Time Elapsed";
            // 
            // timeElapsed
            // 
            this.timeElapsed.AutoSize = true;
            this.timeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeElapsed.Location = new System.Drawing.Point(9, 51);
            this.timeElapsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timeElapsed.Name = "timeElapsed";
            this.timeElapsed.Size = new System.Drawing.Size(46, 51);
            this.timeElapsed.TabIndex = 3;
            this.timeElapsed.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 729);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Flood Dodge";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightchart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedchart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox data_tb;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ports_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox baud_cb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart heightchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedchart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label currentHeight;
        private System.Windows.Forms.Label currentSpeed;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label timeElapsed;
    }
}

