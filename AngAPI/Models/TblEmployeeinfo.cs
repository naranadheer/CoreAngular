using System;
using System.Collections.Generic;

namespace AngAPI.Models
{
    public partial class TblEmployeeinfo
    {
        public int ReportId { get; set; }
        public string Sno { get; set; }
        public int? Hours { get; set; }
        public string Project { get; set; }
        public string Comment { get; set; }
        public string Worktype { get; set; }
        public int? UserId { get; set; }
        public int? Leave { get; set; }
        public DateTime? LeaveDate { get; set; }
        public string LeaveReason { get; set; }
    }
}
