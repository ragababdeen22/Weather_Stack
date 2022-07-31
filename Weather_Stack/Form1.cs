using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Stack
{
    public partial class Form1 : Form
    {
        string FullName;
        weatherData weather;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Location fRM_Location = new FRM_Location();
            fRM_Location.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            //try here 


            await Task.Run(() => load_Data());
            Set_Data();
        }
        private void load_Data()
        {
            FullName = Properties.Settings.Default.FullName;
            var url = "http://api.weatherstack.com/current?access_key=0b059063b0ba11604e04fd31779402bb&query=" + FullName;
            HttpHelper helper = new HttpHelper();
            var data = helper.Json_Convert(url);
            weather = Newtonsoft.Json.JsonConvert.DeserializeObject<weatherData>(data);
        }
        private void Set_Data()
        {
            lb_city.Text = weather.request.query;
            lb_des.Text = string.Join("", weather.current.weather_descriptions);
            pic_state.ImageLocation = string.Join("", weather.current.weather_icons);
            lb_tep.Text = weather.current.temperature.ToString();
            lb_wind.Text = weather.current.wind_speed.ToString();
            lb_hum.Text = weather.current.humidity.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            FullName = Properties.Settings.Default.FullName;
            await Task.Run(() => load_Data());
            Set_Data();
        }
    }
}
