﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Project_Sample.Model
{
    public class APIResponse
    {
        public Class1[] Property1 { get; set; }
    }

    public class Class1
    {
        public string id { get; set; }
        public string name { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        public string color { get; set; }
        public string capacity { get; set; }
        public int capacityGB { get; set; }
        public float price { get; set; }
        public string generation { get; set; }
        public int year { get; set; }
        public string CPUmodel { get; set; }
        public string Harddisksize { get; set; }
        public string StrapColour { get; set; }
        public string CaseSize { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }
        public float Screensize { get; set; }
        public string Generation { get; set; }
        public string Price { get; set; }
    }

}
