
using DSHS.CMBHS.Model.CustomAttribute;
using System;
using System.Xml.Serialization;
namespace DSHS.CMBHS.Model 
{
	public class SuAsmtPhysicalHealth : SuAsmtPhysicalHealthBase
	{

        public SuAsmtPhysicalHealth()
        {
            PhyHealthPrescription = new PhyHealthPrescription();
            PhyHealthAssistance = new PhyHealthAssistance();
            PhyHealthDetox = new PhyHealthDetox();
        }


        [XmlIgnore]
        public PhyHealthPrescription PhyHealthPrescription { get; set; }


        [XmlIgnore]
        public PhyHealthDetox PhyHealthDetox { get; set; }

        [XmlIgnore]
        public PhyHealthAssistance PhyHealthAssistance { get; set; }

        public String PhyHealthPresc { get; set; }

        public String PhyHealthAssit { get; set; }
	}
} 
