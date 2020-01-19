using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharp_Project.Models;

namespace Sharp_Project.Models
{
    class SysInform
    {
        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("sunrise")]
        public long Sunrise { get; set; }

        [JsonProperty("sunset")]
        public long Sunset { get; set; }
    }
}
