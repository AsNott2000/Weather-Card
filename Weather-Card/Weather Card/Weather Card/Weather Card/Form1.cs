using System.Xml.Linq;


namespace Weather_Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sehir_cbox.SelectedIndex = 0;
            string api = "70f064257e7bd7889327a0eaa02ff843";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=" + sehir_cbox.SelectedItem + "&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var havaDurumu = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var rüzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            degree_lbl.Text = sicaklik + " C";
            havaDurumu_lbl.Text = havaDurumu;
            nemYuzdesi_lbl.Text = nem + " %";
            ruzgarHizi_lbl.Text = rüzgar + " m/s";
            if (havaDurumu == "açýk")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\gunesli.png";
            }
            else if (havaDurumu == "kapalý")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\bulutlu.png";
            }
            else if (havaDurumu == "parçalý bulutlu")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\az-bulutlu.png";
            }
            else if (havaDurumu == "yaðmurlu" || havaDurumu == "saðanak")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\yagmurlu.png";
            }
        }

        private void sehir_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string api = "70f064257e7bd7889327a0eaa02ff843";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=" + sehir_cbox.SelectedItem + "&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var sicaklik = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            var havaDurumu = hava.Descendants("weather").ElementAt(0).Attribute("value").Value;
            var nem = hava.Descendants("humidity").ElementAt(0).Attribute("value").Value;
            var rüzgar = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            degree_lbl.Text = sicaklik + " C";
            havaDurumu_lbl.Text = havaDurumu;
            nemYuzdesi_lbl.Text = nem + " %";
            ruzgarHizi_lbl.Text = rüzgar + " m/s";

            if (havaDurumu == "açýk")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\gunesli.png";
            }
            else if (havaDurumu == "kapalý")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\bulutlu.png";
            }
            else if (havaDurumu == "parçalý bulutlu")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\az-bulutlu.png";
            }
            else if (havaDurumu == "yaðmurlu" || havaDurumu == "saðanak")
            {
                hava_pcbx.ImageLocation = @"C:\Users\busin\OneDrive\Masaüstü\Weather Card\hava durumu resimleri\yagmurlu.png";
            }

        }
    }
}