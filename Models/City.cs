﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DropDownApp.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
    }
}
