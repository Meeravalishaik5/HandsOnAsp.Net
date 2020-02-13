using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartMvcCaseStudy.Models
{
    public class SellerViewmodel
    {
        public string SUSERNAME { get; set; }
        public string SPASSWORD { get; set; }
        public string SCOMPANYNAME { get; set; }
        public string SGSTIN { get; set; }
        public string SADDRESS { get; set; }
        public string SWEBSITE { get; set; }
        public double SMOBILENO { get; set; }
        public string SEMAILID { get; set; }
        public IFormFile Photo { get; set; }

    }
}
