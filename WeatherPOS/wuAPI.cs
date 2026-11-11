using System;

namespace WeatherPOS
{
    public class wuAPI
    {
        public class Error
        {
            public string type { get; set; }
            public string description { get; set; }
        }
        public class Features
        {
            public int conditions { get; set; }
            public int alerts { get; set; }
            public int astronomy { get; set; }
        }

        public class Response
        {
            public string version { get; set; }
            public string termsofService { get; set; }
            public Features features { get; set; }
            public Error error { get; set; }
        }

        public class Image
        {
            public string url { get; set; }
            public string title { get; set; }
            public string link { get; set; }
        }
        public class CurrentTime
        {
            public string hour { get; set; }
            public string Minute { get; set; }
        }

        public class Sunrise
        {
            public override string ToString()
            {
                return String.Format("{0}:{1}", hour, minute);
            }
            public string hour { get; set; }
            public string minute { get; set; }
        }

        public class Sunset
        {
            public override string ToString()
            {
                return String.Format("{0}:{1}", hour, minute);
            }
            public string hour { get; set; }
            public string minute { get; set; }
        }

        /*   public class MoonPhase
           {
               public string percentIlluminated { get; set; }
               public string ageOfMoon { get; set; }
               public CurrentTime current_time { get; set; }
               public Sunrise sunrise { get; set; }
               public Sunset sunset { get; set; }
           }
        */
        public class DisplayLocation
        {
            public string full { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string state_name { get; set; }
            public string country { get; set; }
            public string country_iso3166 { get; set; }
            public string zip { get; set; }
            public string magic { get; set; }
            public string wmo { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
            public string elevation { get; set; }
        }

        /*   public class ObservationLocation
           {
               public string full { get; set; }
               public string city { get; set; }
               public string state { get; set; }
               public string country { get; set; }
               public string country_iso3166 { get; set; }
               public string latitude { get; set; }
               public string longitude { get; set; }
               public string elevation { get; set; }
           }
        */

        /*   public class Estimated
           {
           }
        */
        public class CurrentObservation
        {
            public Image image { get; set; }
            public DisplayLocation display_location { get; set; }
            //public ObservationLocation observation_location { get; set; }
            //public Estimated estimated { get; set; }
            public string station_id { get; set; }
            public string observation_time { get; set; }
            public string observation_time_rfc822 { get; set; }
            public string observation_epoch { get; set; }
            public string local_time_rfc822 { get; set; }
            public string local_epoch { get; set; }
            public string local_tz_short { get; set; }
            public string local_tz_long { get; set; }
            public string local_tz_offset { get; set; }
            public string weather { get; set; }
            public string temperature_string { get; set; }
            public double temp_f { get; set; }
            public double temp_c { get; set; }
            public string relative_humidity { get; set; }
            public string wind_string { get; set; }
            public string wind_dir { get; set; }
            public int wind_degrees { get; set; }
            public double wind_mph { get; set; }
            public string wind_gust_mph { get; set; }
            public double wind_kph { get; set; }
            public string wind_gust_kph { get; set; }
            public string pressure_mb { get; set; }
            public string pressure_in { get; set; }
            public string pressure_trend { get; set; }
            public string dewpoint_string { get; set; }
            public int dewpoint_f { get; set; }
            public int dewpoint_c { get; set; }
            public string heat_index_string { get; set; }
            public string heat_index_f { get; set; }
            public string heat_index_c { get; set; }
            public string windchill_string { get; set; }
            public string windchill_f { get; set; }
            public string windchill_c { get; set; }
            public string feelslike_string { get; set; }
            public string feelslike_f { get; set; }
            public string feelslike_c { get; set; }
            public string visibility_mi { get; set; }
            public string visibility_km { get; set; }
            public string solarradiation { get; set; }
            public string UV { get; set; }
            public string precip_1hr_string { get; set; }
            public string precip_1hr_in { get; set; }
            public string precip_1hr_metric { get; set; }
            public string precip_today_string { get; set; }
            public string precip_today_in { get; set; }
            public string precip_today_metric { get; set; }
            public string icon { get; set; }
            public string icon_url { get; set; }
            public string forecast_url { get; set; }
            public string history_url { get; set; }
            public string ob_url { get; set; }
            public string nowcast { get; set; }




        }

        /*  public class CurrentObservation
        {
            public Image image { get; set; }
            public DisplayLocation display_location { get; set; }
            public ObservationLocation observation_location { get; set; }
            public Estimated estimated { get; set; }
            public string station_id { get; set; }
            public string observation_time { get; set; }
            public string observation_time_rfc822 { get; set; }
            public string observation_epoch { get; set; }
            public string local_time_rfc822 { get; set; }
            public string local_epoch { get; set; }
            public string local_tz_short { get; set; }
            public string local_tz_long { get; set; }
            public string local_tz_offset { get; set; }
            public string weather { get; set; }
            public string temperature_string { get; set; }
            public double temp_f { get; set; }
            public double temp_c { get; set; }
            public string relative_humidity { get; set; }
            public string wind_string { get; set; }
            public string wind_dir { get; set; }
            public int wind_degrees { get; set; }
            public double wind_mph { get; set; }
            public string wind_gust_mph { get; set; }
            public double wind_kph { get; set; }
            public string wind_gust_kph { get; set; }
            public string pressure_mb { get; set; }
            public string pressure_in { get; set; }
            public string pressure_trend { get; set; }
            public string dewpoint_string { get; set; }
            public int dewpoint_f { get; set; }
            public int dewpoint_c { get; set; }
            public string heat_index_string { get; set; }
            public string heat_index_f { get; set; }
            public string heat_index_c { get; set; }
            public string windchill_string { get; set; }
            public string windchill_f { get; set; }
            public string windchill_c { get; set; }
            public string feelslike_string { get; set; }
            public string feelslike_f { get; set; }
            public string feelslike_c { get; set; }
            public string visibility_mi { get; set; }
            public string visibility_km { get; set; }
            public string solarradiation { get; set; }
            public string UV { get; set; }
            public string precip_1hr_string { get; set; }
            public string precip_1hr_in { get; set; }
            public string precip_1hr_metric { get; set; }
            public string precip_today_string { get; set; }
            public string precip_today_in { get; set; }
            public string precip_today_metric { get; set; }
            public string icon { get; set; }
            public string icon_url { get; set; }
            public string forecast_url { get; set; }
            public string history_url { get; set; }
            public string ob_url { get; set; }
            public string nowcast { get; set; }
        }
      */

        /* public class ZONE
         {
             public string state { get; set; }
         }*/

        /*public class Vertex
        {
            public string lat { get; set; }
            public string lon { get; set; }
        }
        */

        /* public class StormInfo
         {
             public int time_epoch { get; set; }
             public int Motion_deg { get; set; }
             public int Motion_spd { get; set; }
             public double position_lat { get; set; }
             public double position_lon { get; set; }
         }*/

        /*public class StormBased
        {
            public List<Vertex> vertices { get; set; }
            public int Vertex_count { get; set; }
            public StormInfo stormInfo { get; set; }
        }*/

        /*public class Alert
        {
            public string type { get; set; }
            public string description { get; set; }
            public string date { get; set; }
            public string date_epoch { get; set; }
            public string expires { get; set; }
            public string expires_epoch { get; set; }
            public string message { get; set; }
            public string phenomena { get; set; }
            public string significance { get; set; }
            public List<ZONE> ZONES { get; set; }
            public StormBased StormBased { get; set; }
        }*/
        public class RootObject
        {
            public Response response { get; set; }
            public CurrentObservation current_observation { get; set; }
            public string query_zone { get; set; }
            // public List<Alert> alerts { get; set; }
            // public MoonPhase moon_phase { get; set; }
        }
    }
}
