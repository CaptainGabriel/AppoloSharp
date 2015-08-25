using AppoloSharp.Model.interno;
using Newtonsoft.Json;

namespace AppoloSharp.Model
{
    public class LectiveSemester
    {
        [JsonProperty("lectiveSemesterId")]
        public int LectiveSemesterId { get; protected set; }
        [JsonProperty("shortName")]
        public string ShortName { get; protected set; }
        [JsonProperty("term")]
        public int Term { get; protected set; }
        [JsonProperty("startYear")]
        public int StartYear { get; protected set; }
        [JsonProperty("termName")]
        public string TermName { get; protected set; }
        [JsonProperty("_links")]
        public Links Links { get; protected set; }
    }
}
