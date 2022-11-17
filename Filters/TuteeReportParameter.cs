﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TutorSearchSystem.Global;

namespace TutorSearchSystem.Filters
{
    public class TuteeReportParameter: QueryStringParameter
    {
        [FromQuery(Name ="fromDate")]
        public DateTime FromDate { get; set; } = new DateTime(0001,1,1);
        [FromQuery(Name = "toDate")]
        public DateTime ToDate { get; set; } = DateTime.Now.AddDays(1);
        [FromQuery(Name = "status")]
        public string Status { get; set; } = "";
        [FromQuery(Name = "reportType")]
        public int ReportType { get; set; } = 0;
        [FromQuery(Name = "tuteeEmail")]
        public string TuteeEmail { get; set; } = "";
    }
}
