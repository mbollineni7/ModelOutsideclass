using System.Collections.Generic;

namespace DSHS.CMBHS.Model 
{
	public class TcReferralDetailView : TcReferralDetailViewBase
	{        
        public string OrganizationFax { get; set; }      
        public string ClientBestTime { get; set; }
        public string ClientPrimaryPhone { get; set; }
        public string ClientSecondaryPhone { get; set; }       
	}

}
