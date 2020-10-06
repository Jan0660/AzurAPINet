﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jan0660.AzurAPINet.Ships
{
    public class ShipStars
    {
        [JsonProperty("stars")]
        public readonly string Stars;
        [JsonProperty("value")]
        public readonly int Count;
    }
}