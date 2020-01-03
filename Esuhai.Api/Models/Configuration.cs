using System;
using System.Collections.Generic;

namespace Esuhai.Api.Models
{
    public partial class Configuration
    {
        public int Id { get; set; }
        public string CfgKey { get; set; }
        public string CfgValue { get; set; }
        public string Description { get; set; }
    }
}
