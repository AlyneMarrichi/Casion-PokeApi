using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Casion_PokeApi.Models
{
    public class Type
    {

        [JsonProperty("name")]
        public List<Type> Names { get; set; }

        //List<Type> listaNome = new List<Type>();

    }
}