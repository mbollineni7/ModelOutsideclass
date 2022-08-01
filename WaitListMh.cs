
using System; 

namespace DSHS.CMBHS.Model 
{
    public class WaitListMh : WaitListMhBase, IDownloadDocument, IClinicalData 
	{
        public WaitListMh() : base()
        {		
        }

        private short _OrganizationType;
        [System.Xml.Serialization.XmlIgnore]
        public short OrganizationType
        {
            get { return _OrganizationType; }
            set { _OrganizationType = value; }
        }
        private string _ClientName;
        [System.Xml.Serialization.XmlIgnore]
        public string ClientName
        {
            get { return _ClientName; }
            set { _ClientName = value; }
        }
        private short _ClientGender;
        [System.Xml.Serialization.XmlIgnore]
        public short ClientGender
        {
            get { return _ClientGender; }
            set { _ClientGender = value; }
        }
        private string _ClientPhone;
        [System.Xml.Serialization.XmlIgnore]
        public string ClientPhone
        {
            get { return _ClientPhone; }
            set { _ClientPhone = value; }
        }
        private string _ClientPhoneExt;
        [System.Xml.Serialization.XmlIgnore]
        public string ClientPhoneExt
        {
            get { return _ClientPhoneExt; }
            set { _ClientPhoneExt = value; }
        }
        private string _CareId;
        [System.Xml.Serialization.XmlIgnore]
        public string CareId
        {
            get { return _CareId; }
            set { _CareId = value; }
        }
        private string _WaitListInterims;
        [DSHS.CMBHS.Model.CustomAttribute.MultiChoiceReferencedClassAttribute("DSHS.CMBHS.Model.InterimServiceMhBase,DSHS.CMBHS.Model")]
        public string WaitListInterims
        {
            get { return _WaitListInterims; }
            set { _WaitListInterims = value; }
        }

        private short _ageType;
        [System.Xml.Serialization.XmlIgnore]
        public short AgeType
        {
            get { return _ageType; }
            set { _ageType = value; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public int ParentOrganizationNbr { get; set; }
        [System.Xml.Serialization.XmlIgnore]
        public int OriginalOrganizationNbr { get; set; }
        public int Age { get; set; }

        #region IDownloadDocument Properties
        [System.Xml.Serialization.XmlIgnore]
        public string DocumentDateFromColumnName
        {
            get { return "StartDate"; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string DocumentDateToColumnName
        {
            get { return "StartDate"; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public DateTime DocumentDateFrom
        {
            get { return StartDate; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public DateTime DocumentDateTo
        {
            get { return StartDate; }
        }
        #region DocumentStatus
        [System.Xml.Serialization.XmlIgnore]
        public string DocumentStatusFromColumnName
        {
            get { return "UpdatedDate"; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string DocumentStatusToColumnName
        {
            get { return "UpdatedDate"; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public DateTime DocumentStatusDateFrom
        {
            get { return UpdatedDate; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public DateTime DocumentStatusDateTo
        {
            get { return UpdatedDate; }
        }
        #endregion
        #region Updated Date
        [System.Xml.Serialization.XmlIgnore]
        public string UpdatedDateFromColumnName
        {
            get { return "UpdatedDate"; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public string UpdatedDateToColumnName
        {
            get { return "UpdatedDate"; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public DateTime UpdatedDateFrom
        {
            get { return UpdatedDate; }
        }
        [System.Xml.Serialization.XmlIgnore]
        public DateTime UpdatedDateTo
        {
            get { return UpdatedDate; }
        }
        #endregion
        [System.Xml.Serialization.XmlIgnore]
        public string UnderlyingDatabaseStructure
        {
            get { return "Table"; }
        }
        #endregion

        #region IClinicalData Properties

        #region int DocumentNbr property accessor
        public System.Int32 DocumentNbr
        {
            get { return WaitListMhNbr; }
            // this needs a setter for DOSS to render it, but we dont want a setter so make dummy
            set { }
        }
        #endregion

        #region public short ClientActivityType property accessor
        [System.Xml.Serialization.XmlIgnore]
        public short ClientActivityType
        {
            get { return (short)Model.ClientActivityType.Code.WaitListMh; }
            // this needs a setter for DOSS to render it and we need it in html source, but we dont want a setter so make dummy
            set { }
        }
        #endregion

        #endregion


	}
} 
