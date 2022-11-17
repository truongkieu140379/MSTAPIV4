﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TutorSearchSystem.Filters
{
    public class TutorParameter: QueryStringParameter
    {
        public string TutorName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Status { get; set; } = "";
        public int ManagerId { get; set; } = 0;
    }
}
