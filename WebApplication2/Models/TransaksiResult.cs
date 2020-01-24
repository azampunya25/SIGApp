using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class TransaksiResult
    {
        public int StatusCode { get; set; }
        public string errCode { get; set; }
        public TSummary retData { get; set; }
    }
    
    public class TSummary
    {
        public int IDSummary { get; set; }
        public List<TSummaryDetail> TSummaryDetails { get; set; }
    }

    public class TSummaryDetail
    {
        public int IDSummaryDetail { get; set; }
        public string NameSummary { get; set; }
    }
}