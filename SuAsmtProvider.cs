
namespace DSHS.CMBHS.Model 
{
	public class SuAsmtProvider : SuAsmtProviderBase
	{
        #region public override string PhoneNumber
        public override string Phone
        {
            get
            {
                return base.Phone;
            }
            set
            {
                base.Phone = DSHS.CMBHS.Model.PropertyFormatProviders.PhoneFormatProviderAttribute.RemovePhoneFormat(value);
            }
        }
        #endregion
	}
} 
