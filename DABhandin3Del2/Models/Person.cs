using System.Collections.Generic;
using Newtonsoft.Json;

namespace DABhandin3Del2.Models
{
    public class Person
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }
        [JsonProperty(PropertyName = "PersonID")]
        public int PersonID { get; set; }

        [JsonProperty(PropertyName = "Fornavn")]
        public string Fornavn { get; set; }

        [JsonProperty(PropertyName = "Mellemnavn")]
        public string Mellemnavn { get; set; }

        [JsonProperty(PropertyName = "Efternavn")]
        public string Efternavn { get; set; }

        [JsonProperty(PropertyName = "AddressCon")]
        public Address AddressCon { get; set; }

        [JsonProperty(PropertyName = "Emails")]
        public ICollection<Email> Emails { get; set; }
    }
}
