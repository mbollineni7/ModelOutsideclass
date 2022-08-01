
using System.Xml.Serialization;
namespace DSHS.CMBHS.Model 
{
	public class SuAsmtSubstanceUse : SuAsmtSubstanceUseBase
	{
        public SuAsmtSubstanceUse()
        {
            WithDrawlEffect = new WithdrawalEffect();
            SubUseTreatmentEpisode = new SubUseTreatmentEpisode();
        }


        [XmlIgnore]
        public WithdrawalEffect WithDrawlEffect { get; set; }


        [XmlIgnore]
        public SubUseTreatmentEpisode SubUseTreatmentEpisode { get; set; }
        
        public string WithdrawalEffect { get; set; }

        public int SumOfTreatmentEpisodes { get; set; }


	}
} 
