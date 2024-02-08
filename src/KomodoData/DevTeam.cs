using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace KomodoInsuranceDevManagement.src.KomodoData
{
    public class DevTeam
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<Dev> Devs { get; set; } = new List<Dev>();
    }
}