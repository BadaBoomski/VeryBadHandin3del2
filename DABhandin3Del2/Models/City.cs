using System.Collections.Generic;
using Newtonsoft.Json;

namespace DABhandin3Del2.Models
{
    public class City
    {
        [JsonProperty(PropertyName = "CityID")]
        public int CityID { get; set; }

        [JsonProperty(PropertyName = "Cityname")]
        public string Cityname { get; set; }

        [JsonProperty(PropertyName = "Postcode")]
        public string Postcode { get; set; }

        [JsonProperty(PropertyName = "Addresses")]
        public ICollection<Address> Addresses { get; set; }
    }
}
