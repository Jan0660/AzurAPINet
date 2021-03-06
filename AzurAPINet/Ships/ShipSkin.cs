﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jan0660.AzurAPINet.Ships
{
#nullable enable
#nullable disable warnings
    public class ShipSkin
    {
        [JsonProperty("name")]
        public readonly string Name;
        [JsonProperty("image")]
        public readonly string Image;
        /// <summary>
        /// in case of chinese censorship of waifus
        /// </summary>
        [JsonProperty("cn")]
        public readonly string? ImageCN;
        [JsonProperty("background")]
        public readonly string Background;
        [JsonProperty("nobg")]
        public readonly string? NoBackground;
        [JsonProperty("chibi")]
        public readonly string Chibi;
        [JsonProperty("info")]
        public readonly ShipSkinInfo Info;
        public List<string> GetSkinUrlsList()
        {
            List<string> list = new List<string> { Image, Chibi, Background };
            if (ImageCN != null)
                list.Add(ImageCN);
            if (NoBackground != null)
                list.Add(NoBackground);
            return list;
        }

        /// <summary>
        /// returns the name of the skin
        /// </summary>
        public override string ToString()
            => Name;
    }
}
