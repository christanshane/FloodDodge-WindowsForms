using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SerialPort myPort;
        private DateTime datetime;
        private string in_data;
        private DateTime monitored;
        private System.Windows.Forms.DataVisualization.Charting.Series heightseries = new System.Windows.Forms.DataVisualization.Charting.Series
        {
            Name = "Flood Height",
            Color = System.Drawing.Color.Blue,
            IsVisibleInLegend = false,
            IsXValueIndexed = true,
            ChartType = SeriesChartType.Line
        };
        private System.Windows.Forms.DataVisualization.Charting.Series speedseries = new System.Windows.Forms.DataVisualization.Charting.Series
        {
            Name = "Flood Speed",
            Color = System.Drawing.Color.Blue,
            IsVisibleInLegend = false,
            IsXValueIndexed = true,
            ChartType = SeriesChartType.Line
        };

        public Form1()
        {
            InitializeComponent();
            getPortNames();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baud_cb.SelectedItem = baud_cb.Items[baud_cb.Items.IndexOf("9600")];
            heightchart.Series.Clear();
            speedchart.Series.Clear();

            this.heightchart.Series.Add(heightseries);
            this.speedchart.Series.Add(speedseries);
                
            
            speedchart.Invalidate();
            heightchart.Invalidate();
        }

        private void addToHeightChart(DateTime time, String height)
        {
            heightseries.Points.AddXY(time.Minute, height);
        }

        private void addToSpeedChart(DateTime time, String speed)
        {
            speedseries.Points.AddXY(time.Minute, speed);
        }

        private void getPortNames()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ports_cb.Items.Add(port);
            }
            ports_cb.SelectedItem = ports_cb.Items[0];
        }

        private void portSetup()
        {
            myPort = new SerialPort();
            myPort.BaudRate = Convert.ToInt32(baud_cb.SelectedItem);
            myPort.PortName = ports_cb.Text;
            myPort.Parity = Parity.None;
            myPort.DataBits = 8;
            myPort.StopBits = StopBits.One;
            myPort.DataReceived += myPort_DataReceived;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            try
            {
                portSetup();
                try
                {
                    myPort.Open();
                    data_tb.Text = "";
                    start_btn.Enabled = false;
                    stop_btn.Enabled = true;
                    save_btn.Enabled = false;
                    monitored = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            } catch(Exception ee)
            {
                MessageBox.Show(ee.Message, "Error");
            }
        }

        private void myPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = myPort.ReadLine();
            System.Threading.Thread.Sleep(250);
            this.Invoke(new EventHandler(displaydata_event));
        }

        private void displaydata_event(object sender, EventArgs e)
        {
            string[] values = in_data.Split(',');
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
            data_tb.AppendText(time+ "---"+ in_data+"\n");
            addToHeightChart(datetime, values[0]);
            currentHeight.Text = values[0];
            addToSpeedChart(datetime, values[1]);
            currentSpeed.Text = values[1];
            TimeSpan diff = datetime - monitored;
            timeElapsed.Text = diff.Hours+":"+diff.Minutes+":"+diff.Seconds;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            try
            {
                myPort.Close();
                start_btn.Enabled = true;
                stop_btn.Enabled = false;
                save_btn.Enabled = true;
            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message, "Error");
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string pathfile = @"Data\";
                string filename = "potentiometer_data.txt";
                System.IO.File.WriteAllText(pathfile + filename, data_tb.Text);
                MessageBox.Show("Data saved");
            }
            catch(Exception ex3)
            {
                MessageBox.Show(ex3.Message, "Error");
            }
        }

        private void port_name_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void baud_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
