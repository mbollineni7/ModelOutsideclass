using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHS.CMBHS.Model
{
    public class TletsProviderEmailResult
    {

        public string EmailAddress { get; set; }

        public string CompCode { get; set; }

        public short MatchArea { get; set; }

        public string MatchType { get; set; }

        public int Count { get; set; }
    }
}
