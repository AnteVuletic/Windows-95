using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Windows95.Models
{
    public class Application : IModel
    {
        public int PrimaryId { get; set; }
        public string Name { get; set; }
        public byte[] Icon { get; set; }

    }
}