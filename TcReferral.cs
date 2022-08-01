
namespace DSHS.CMBHS.Model 
{
	public class TcReferral : TcReferralBase
	{
        public TcReferral()
        {
            TcReferralDetailView = new TcReferralDetailView();
        }
        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }
        public TcReferralDetailView TcReferralDetailView { get; set; }
        public TcReferralOutcome TcReferralOutcome { get; set; }
	}
} 
