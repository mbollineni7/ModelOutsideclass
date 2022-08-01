
using System.Xml.Serialization;

namespace DSHS.CMBHS.Model 
{
	public class SuAsmtLegal : SuAsmtLegalBase
	{ 
       // public SuAsmtHouseHoldMember SuAsmtHouseHoldMember { get; set; }

        public string SuAsmtHouseHoldMember { get; set; }

        public string SuAsmtPastLegalStatus { get; set; }
	}
} 
