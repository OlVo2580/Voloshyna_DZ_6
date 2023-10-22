using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DZ_6
{
    internal class Book
    {
        [JsonIgnore]
        public int PublishingHouseId { get; set; }

        [JsonPropertyName("Name")]
        public string Title { get; }

        public PublishingHouse PublishingHouse { get; set; }
    }

}
