﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casion_PokeApi.Models
{
    public class Sprites
    {

        [JsonProperty("front_default")]
        public string Front_default{ get; set; }

    }
}