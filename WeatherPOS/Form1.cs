using Newtonsoft.Json;
using SimpleTCP;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace WeatherPOS
{
    public partial class Form1 : Form
    {
        SimpleTCP.SimpleTcpServer posServer;
        //SimpleTCP.SimpleTcpClient posClient;
        //wuAPI.RootObject weatherObj;      

        openWeatherMapAPI.ResponseWeather weatherObj;

        public Form1()
        {
            InitializeComponent();
            //Console.WriteLine("timer is equals to: " + (int)updateIntms.Value);
            // Console.WriteLine("timer saved is equals to: " + (int)Properties.Settings.Default.updateIntMs);
            // updateTimer.Interval = Properties.Settings.Default.updateIntMs;
            updateIntms.Value = Properties.Settings.Default.updateIntMs;
            string tim = updateIntms.Value.ToString();
            int time = Int32.Parse(tim);
            updateTimer.Interval = time * 60000;
            api_key_tb.Text = Properties.Settings.Default.ApiKey;
            tcp_port_nm.Value = Properties.Settings.Default.tcpPort;
            city_tb.Text = Properties.Settings.Default.City;
            country_tb.Text = Properties.Settings.Default.Country;
            StopServer_btn.Enabled = false;
            chk_Api.Enabled = true;
            snd_Test_dta.Enabled = false;
            toolStripStatusLabel1.Text = "Not running";
            posServer = new SimpleTCP.SimpleTcpServer();
            posServer.ClientConnected += PosServer_ClientConnected;
            posServer.ClientDisconnected += PosServer_ClientDisconnected;
        }

        private void PosServer_ClientDisconnected(object sender, TcpClient e)
        {
            toolStripStatusLabel1.Text = "Running ACC Client Disconnected, waiting for reconnect";
            posServer.Stop();
        }

        private void PosServer_ClientConnected(object sender, System.Net.Sockets.TcpClient e)
        {
            toolStripStatusLabel1.Text = String.Format("Running ACC Client Connected @ {0}", DateTime.Now.ToString());
            Thread.Sleep(2000);
            BroadcastUpdate();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            BroadcastUpdate();
        }

        private void BroadcastUpdate()
        {
            try
            {
                if (posServer.ConnectedClientsCount > 0)
                {
                    // Console.WriteLine("Client connected");
                    // Console.WriteLine("Getting weather via api");

                    weatherObj = UpdateWeather();

                    /* if (weatherObj.response.error != null)
                     {
                         throw new Exception(String.Format("Error, Type: {0} Description: {1}", weatherObj.response.error.type, weatherObj.response.error.description));
                     }*/


                    posServer.BroadcastLine("!!");
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("City: {0}", weatherObj.name));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Temperature: {0}", weatherObj.main.temp));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Weather: {0}", weatherObj.weather[0].main));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Weather Description: {0}", weatherObj.weather[0].description));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Relative Humidity: {0} %", weatherObj.main.humidity));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Pressure Trend: {0} hPa", weatherObj.main.pressure));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Feels Like: {0}", weatherObj.main.feels_like));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Wind: {0} m/s", weatherObj.wind.speed));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Wind Deg: {0} °", weatherObj.wind.deg));
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine(String.Format("Visibility: {0} mts", weatherObj.visibility));
                    posServer.BroadcastLine("\n\r");
                   // posServer.BroadcastLine(String.Format("Sunrise: {0}", weatherObj.sys.sunrise));
                   // posServer.BroadcastLine("\n\r");
                   // posServer.BroadcastLine(String.Format("Sunset: {0}", weatherObj.sys.sunset));
                   // posServer.BroadcastLine("\n\r");

                    //posServer.BroadcastLine("\n\r");
                    //posServer.BroadcastLine(String.Format("Dewpoint: {0}", weatherObj.current_observation.dewpoint_string));
                    //posServer.BroadcastLine("\n\r");

                    //posServer.BroadcastLine("\n\r");
                    //posServer.BroadcastLine(String.Format("UV: {0}", weatherObj.current_observation.UV));
                    //posServer.BroadcastLine("\n\r");

                    //posServer.BroadcastLine("\n\r");
                    // posServer.BroadcastLine(String.Format("Precipitation 1hr: {0}", weatherObj.weather.description));
                    //posServer.BroadcastLine("\n\r");
                    //posServer.BroadcastLine(String.Format("Precipitation Today: {0}", weatherObj.current_observation.precip_today_string));
                    //posServer.BroadcastLine("\n\r");
                    //posServer.BroadcastLine(String.Format("Percent Illuminated: {0}", weatherObj.moon_phase.percentIlluminated));
                    //posServer.BroadcastLine("\n\r");
                    //posServer.BroadcastLine(String.Format("Temperature: {0}", weatherObj.current_observation.temperature_string));
                    //posServer.BroadcastLine(String.Format("Age of Moon: {0}", weatherObj.moon_phase.ageOfMoon));
                    //posServer.BroadcastLine(String.Format("Observation Time: {0}", weatherObj.current_observation.observation_time_rfc822));
                    //posServer.BroadcastLine(String.Format("Station ID: {0}", weatherObj.current_observation.station_id));
                    // posServer.BroadcastLine(String.Format("Weather: {0}", weatherObj.weather));
                    /*   if (weatherObj.alerts.Count > 0)
                       {
                           Console.WriteLine("There are weather alerts active");
                           posServer.BroadcastLine(String.Format("Weather Alerts:"));
                           posServer.BroadcastLine("\n\r");
                           foreach (wuAPI.Alert alert in weatherObj.alerts)
                           {
                               posServer.BroadcastLine(String.Format("Type:{0} Description: {1}", alert.type, alert.description));
                               posServer.BroadcastLine("\n\r");
                               posServer.BroadcastLine(String.Format("Message: {0}", alert.message));
                               posServer.BroadcastLine("\n\r");
                           }
                       }
                    */
                    posServer.BroadcastLine("##");
                    //posServer.BroadcastLine("\n\r");

                    try
                    {
                        toolStripStatusLabel1.Text = String.Format("Running. Last update occured at {0}", DateTime.Now);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(String.Format("Unable to update the tool strip from this tread. Exception: {0}", ex.Message.ToString()));
                    }

                }
                else
                {
                    Console.WriteLine("No Client Connected waiting for next interval");
                }
            }
            catch (Exception ex)
            {
                updateTimer.Stop();
                posServer.Stop();
                StartServer_btn.Enabled = true;
                StopServer_btn.Enabled = false;
                chk_Api.Enabled = true;
                SaveSettings_btn.Enabled = true;
                toolStripStatusLabel1.Text = "Not running";
                toolStripStatusLabel1.Text = "Error occured updating from Weather Underground. Closing";
                MessageBox.Show(String.Format("Message Broadcast : {0}", ex.Message.ToString()));
                

            }
        }

        private void StartServer_btn_Click(object sender, EventArgs e)
        {
            posServer.Stop();
            try
            {
                posServer.Start(Properties.Settings.Default.tcpPort);
                Console.WriteLine("TCP Server Started");
                StartServer_btn.Enabled = false;
                StopServer_btn.Enabled = true;
                SaveSettings_btn.Enabled = false;
                chk_Api.Enabled = false;
                snd_Test_dta.Enabled = true;
                toolStripStatusLabel1.Text = "Running waiting for ACC Client";
                updateTimer.Start();

            }
            catch (Exception ex)
            {
                posServer.Stop();
                toolStripStatusLabel1.Text = "Error Starting Server, Not Running";
                StartServer_btn.Enabled = true;
                StopServer_btn.Enabled = false;
                SaveSettings_btn.Enabled = true;
                chk_Api.Enabled = true;
                snd_Test_dta.Enabled = false;
                MessageBox.Show("Message start server", ex.Message.ToString());
            }

        }

        private openWeatherMapAPI.ResponseWeather UpdateWeather()
        {
            //string url = string.Format(@"http://api.wunderground.com/api/{0}/conditions/alerts/astronomy/q/{1}/{2}.json", Properties.Settings.Default.ApiKey, Properties.Settings.Default.State, Properties.Settings.Default.City);

            string url = string.Format(@"http://api.openweathermap.org/data/2.5/weather?q={0},{1}&appid={2}&units=metric", Properties.Settings.Default.City, Properties.Settings.Default.Country, Properties.Settings.Default.ApiKey);
            // string url = string.Format(@"http://api.wunderground.com/api/{0}/conditions/alerts/astronomy/q/{1}/{2}.json", Properties.Settings.Default.ApiKey, Properties.Settings.Default.State, Properties.Settings.Default.City);
            Uri uri = new Uri(url);
            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            // Convert the json reponse to weather underground object. 
            openWeatherMapAPI.ResponseWeather outObject = JsonConvert.DeserializeObject<openWeatherMapAPI.ResponseWeather>(responseData);
            return outObject;
        }

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ApiKey = api_key_tb.Text.Trim();
            Properties.Settings.Default.City = city_tb.Text.Trim();
            Properties.Settings.Default.Country = country_tb.Text.Trim();
            Properties.Settings.Default.tcpPort = (int)tcp_port_nm.Value;
            Properties.Settings.Default.updateIntMs = (int)updateIntms.Value;
            Properties.Settings.Default.Save();
            MessageBox.Show(String.Format("Saved:  APIKEY= {0}, City= {1}, Country= {2}", Properties.Settings.Default.ApiKey, Properties.Settings.Default.City, Properties.Settings.Default.Country));
        }

        private void StopServer_btn_Click(object sender, EventArgs e)
        {
            updateTimer.Stop();
            Console.WriteLine("Timer stopped");
            posServer.Stop();
            Console.WriteLine("TCP Server Stopped");
            StartServer_btn.Enabled = true;
            StopServer_btn.Enabled = false;
            chk_Api.Enabled = true;
            SaveSettings_btn.Enabled = true;
            toolStripStatusLabel1.Text = "Not running";
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check the weather API and ensure it is able to provide the update for your location and api key. 
            try
            {
                Properties.Settings.Default.ApiKey = api_key_tb.Text;
                Properties.Settings.Default.City = city_tb.Text;
                Properties.Settings.Default.Country = country_tb.Text;
                Properties.Settings.Default.tcpPort = (int)tcp_port_nm.Value;
                Properties.Settings.Default.Save();
                // MessageBox.Show(String.Format("Saved. APIKEY={0} , City={1}, State={2}", Properties.Settings.Default.ApiKey, Properties.Settings.Default.City, Properties.Settings.Default.State));
                // MessageBox.Show(String.Format("Saved. APIKEY={0} , City={1}", Properties.Settings.Default.ApiKey, Properties.Settings.Default.City));
                openWeatherMapAPI.ResponseWeather testData = UpdateWeather();
                /*  if (testData.response.error != null)
                  {
                      throw new Exception(String.Format("Error! Type: {0}, Description:{1}", testData.response.error.type, testData.response.error.description));
                  }*/
                MessageBox.Show(String.Format("Success getting weather from Station ID: {0}", testData.id));
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Unable to update weather. Exception info: {0}", ex.Message.ToString()));
            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (posServer.ConnectedClientsCount > 0)
                {
                    posServer.BroadcastLine("!!");
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine("Data sending success");
                    posServer.BroadcastLine("\n\r");
                    posServer.BroadcastLine("##");
                    posServer.BroadcastLine("\n\r");
                    MessageBox.Show("Data was sent check ACC");
                }
                else
                {
                    MessageBox.Show("ACC POS Interface is not currently connected to this server.");
                    posServer.Stop();
                }
            }
            catch (Exception ex)
            {
                posServer.Stop();
                MessageBox.Show("Message button2", ex.StackTrace);
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void startTCPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stopTCPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
