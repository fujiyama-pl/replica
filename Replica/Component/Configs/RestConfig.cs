﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Schema;

namespace R.Component.Config
{
    public class RestConfig:IComponentConfig
    {
        public string Uri { get; set; }
        public bool Get { get; set; }
        public bool Put { get; set; }
        public bool Post{ get; set; }
        public bool Delete { get; set; }
        public bool All { get; set; }
        public string Schema { get; set; }
        public R.Public.HttpMethod Method { get; set; }
        public string Identity { get; set; }
        public JSchema JsonSchema { get; set; }
    }
}