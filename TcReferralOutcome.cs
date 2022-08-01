
namespace DSHS.CMBHS.Model 
{
	public class TcReferralOutcome : TcReferralOutcomeBase
	{
        public string ReferrralOutcomeStatusDescription
        {
            get { return TcReferralOutcomeStatus.GetDescription((TcReferralOutcomeStatusBase.Code)ReferrralOutcomeStatus); }
        }
	}
} 
