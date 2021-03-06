﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LET.Panopto.Scheduler.Models
{
    public class ScheduleBlockResult
    {
        public Guid Id { get; set; }
        public Guid SessionID { get; set; }
        public string SessionName { get; set; }
        public DateTime SessionStart { get; set; }
        public DateTime SessionEnd { get; set; }
        public string SessionMessage { get; set; }
        public bool ConflictExists { get; set; }
    }
}
