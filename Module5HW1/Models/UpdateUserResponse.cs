﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Module5HW1.Models
{
    public class UpdateUserResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; } = null!;
        [JsonProperty("job")]
        public string Job { get; set; } = null!;
        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }
    }
}
