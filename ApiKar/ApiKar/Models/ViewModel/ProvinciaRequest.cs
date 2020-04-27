using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiKar.Models.Request
{
 
    public class ProvinciaRequest
    {
        public string ProvinciaABuscar { get; set; }
    }
     public class ProvinciasJs
    {
        public string cantidad  { get; set; }

        public provincias[] provincias { get; set; }

    }
    public class provincias
    {
        public centroide centroide { get; set; }

        public string id { get; set; }

        public string nombre { get; set; }

    }
    public class centroide
    {
        public string lat { get; set; }
        public string lon { get; set; }

    }
}