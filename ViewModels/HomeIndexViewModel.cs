﻿using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Child> children { get; set; }
        public string messageOfTheDay { get; set; }
    }
}
