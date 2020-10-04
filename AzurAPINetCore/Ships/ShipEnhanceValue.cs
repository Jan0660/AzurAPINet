﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jan0660.AzurAPINetCore.Ships
{
    //[JsonConverter(typeof(EnhanceValueConverter))]
    public class ShipEnhanceValue
    {
        [JsonIgnore]
        public bool CanEnhance = true;
        [JsonProperty("firepower")]
        public int Firepower;
        [JsonProperty("torpedo")]
        public int Torpedo;
        [JsonProperty("aviation")]
        public int Aviation;
        [JsonProperty("reload")]
        public int Reload;
    }
}