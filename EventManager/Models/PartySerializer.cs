using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManager.Models
{
    public class PartySerializer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("university")]
        public string University { get; set; }

        [JsonProperty("course")]
        public string Course { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

    };
}



