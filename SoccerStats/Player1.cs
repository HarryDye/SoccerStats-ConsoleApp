using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SoccerStats
{

    public class RootObject
    {
        public Player[] Player { get; set; }
    }

    public class Player
    {
        
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }
       
        public int id { get; set; }
       
        public string points_per_game { get; set; }
        
        public string second_name { get; set; }
        
        public string team_name { get; set; }
        
    }

}