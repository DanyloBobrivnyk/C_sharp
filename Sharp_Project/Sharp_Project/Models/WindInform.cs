using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sharp_Project.Models
{
    class WindInform
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
    }
}
