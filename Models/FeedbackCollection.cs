﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace FeedbackAPI.Models
{
    public class FeedbackCollection
    {
        [JsonProperty(PropertyName = "records")]
        public IEnumerable<Feedback> Records { get; set; }
    }
}
