using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;

namespace HRS.Projects.MySociety.WebApp.Models
{
    public class FlatModel
    {
        public short Id { get; set; }
        public string FlatNo { get; set; }
        public Nullable<byte> NoOfResidents { get; set; }
        public string WingName { get; set; }
        public string PrimaryOwner { get; set; }
        public string SecondaryOwner { get; set; }
    }
}