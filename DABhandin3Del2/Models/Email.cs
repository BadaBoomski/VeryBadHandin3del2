using Newtonsoft.Json;

namespace DABhandin3Del2.Models
{
    public class Email
    {
        [JsonProperty(PropertyName = "EmailID")]
        public int EmailID { get; set; }

        [JsonProperty(PropertyName = "Emailaddress")]
        public string Emailaddress { get; set; }

        [JsonProperty(PropertyName = "Person")]
        public Person Person { get; set; }
    }
}
