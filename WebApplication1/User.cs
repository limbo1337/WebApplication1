using Supabase.Postgrest.Models;
using Supabase.Postgrest.Attributes;
using System.Reflection;
using Newtonsoft.Json;

namespace WebApplication2
{
    [Table("users")]
    public class User : BaseModel
    {
        [PrimaryKey]
        public int id { get; set; }
        [Column("name")]
        public string name { get; set; }
        [Column("password")]
        public string password { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("age")]
        public int age { get; set; }

        [Column("city")]
        public int? city { get; set; }
    }

    [Table("cities")]
    public class Cities : BaseModel
    {
        [PrimaryKey]
        public int id { get; set; }

        [Column("name")]
        public string name { get; set; }

        [Column("population")]
        public int population { get; set; }

        [Column("country")]
        public string country { get; set; }
    }

    public class updatingName
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }

    }

    public class updatingEmail
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }

    }

    public class updatingPassword
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("password")]
        public string password { get; set; }

    }

    public class delete
    {
        [JsonProperty("id")]
        public int id { get; set; }
    }

    public class addCity
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("population")]
        public int population { get; set; }

        [JsonProperty("country")]
        public string country { get; set; }
    }

    public class updateNameCity
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }

    }

    public class updatePopulationCity
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("population")]
        public int populaiton { get; set; }
    }


    public class updateCountryCity
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("country")]
        public string country { get; set; }
    }
}