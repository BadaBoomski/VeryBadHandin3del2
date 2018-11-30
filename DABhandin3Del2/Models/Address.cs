using System.Collections.Generic;
using Newtonsoft.Json;

namespace DABhandin3Del2.Models
{
    public class Address
    {
        [JsonProperty(PropertyName = "AddressID")]
        public int AddressID { get; set; }

        [JsonProperty(PropertyName = "Streetname")]
        public string Streetname { get; set; }

        [JsonProperty(PropertyName = "Housenumber")]
        public string Housenumber { get; set; }

        [JsonProperty(PropertyName = "City")]
        public City City { get; set; }

        [JsonProperty(PropertyName = "Persons")]
        public ICollection<Person> Persons { get; set; }
    }
}
