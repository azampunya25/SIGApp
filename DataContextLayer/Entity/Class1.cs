using DataContextLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataContextLayer.Entity
{
    public class VoyageResult
    {
        public string status { get; set; }
        public string err { get; set; }
        public List<Department> data { get; set; }
    }
}
