


using System;

namespace DSHS.CMBHS.Model 
{
	#region SubstanceUsage Summary 
	/// <summary>
	/// 
	/// Template Name:           CMBHSDomainObject.cs	
	/// Template Version:        1.0
	/// Template Date:           Dec 19, 2007
	///
	/// Template Description:    This template is used to generate
	///	                         the base Domain objects for the DSHS.CMBHS.Model
	/// 
	/// Generator Version:       CMBHS v1.0
	/// Generated On:            6/25/2008 4:03:49 PM
	/// 
	/// 
	/// Base Object Name:        SUBSTANCE_USAGE
	/// Base Object Type:        Table
	///
	/// Class Information:
	/// 	Base ClassName:      DSHS.CMBHS.Model.AbstractDomainObject
	/// 	ClassName:           SubstanceUsageBase
	/// 	Name Space Name:     DSHS.CMBHS.Model
	/// 
	/// File Information:
	/// 	Template File Name:  CMBHSTableDomain
	///	Class File Name:         SubstanceUsageBase.cs
	/// 
	///	Primary Key Name	PrimaryKeyColumnName 
	///	SUBSTANCE_USAGE_PK VALUE_NBR
	/// </summary>
	#endregion

    public class SubstanceUsageBase : DSHS.CMBHS.Model.AbstractDomainObject
    {
		#region SubstanceUsageBase Constructor
		public SubstanceUsageBase () : base (){}
		#endregion

		#region Table data Accessors
		public enum Code : short
		{
  			No = 1,
  			YesAlcohol = 2,
  			YesOtherDrugs = 3,
  			YesPolysubstanceUse = 4,
  			YesUnspecified = 5,
  			Unknown = 6
		}

		public static short MapDescription(string value)
		{
            if (value.ToLower().CompareTo("no") == 0)
               return (short)Code.No;
            if (value.ToLower().CompareTo("yes-alcohol") == 0)
               return (short)Code.YesAlcohol;
            if (value.ToLower().CompareTo("yes-other drugs") == 0)
               return (short)Code.YesOtherDrugs;
            if (value.ToLower().CompareTo("yes-polysubstance use") == 0)
               return (short)Code.YesPolysubstanceUse;
            if (value.ToLower().CompareTo("yes-unspecified") == 0)
               return (short)Code.YesUnspecified;
            if (value.ToLower().CompareTo("unknown") == 0)
               return (short)Code.Unknown;
			return 0;
		}

		public static string GetDescription(Code value)
		{
			if(value == Code.No)
				return "no";
			if(value == Code.YesAlcohol)
				return "yes-alcohol";
			if(value == Code.YesOtherDrugs)
				return "yes-other drugs";
			if(value == Code.YesPolysubstanceUse)
				return "yes-polysubstance use";
			if(value == Code.YesUnspecified)
				return "yes-unspecified";
			if(value == Code.Unknown)
				return "unknown";
			return string.Empty;
		}
		#endregion Table data Accessors


        #region Table Attribute Accessors

        #region ValueNbr property accessor
        private System.Int16  _ValueNbr ;
        public virtual System.Int16 ValueNbr
        {
            get { return _ValueNbr; }
            set { _ValueNbr = value; }
        }
        #endregion ValueNbr property accessor

        #region ValueCode property accessor
        private System.String  _ValueCode ;
        public virtual System.String ValueCode
        {
            get { return _ValueCode; }
            set { _ValueCode = value; }
        }
        #endregion ValueCode property accessor

        #region ValueAbbrv property accessor
        private System.String  _ValueAbbrv ;
        public virtual System.String ValueAbbrv
        {
            get { return _ValueAbbrv; }
            set { _ValueAbbrv = value; }
        }
        #endregion ValueAbbrv property accessor

        #region ValueDescription property accessor
        private System.String  _ValueDescription ;
        public virtual System.String ValueDescription
        {
            get { return _ValueDescription; }
            set { _ValueDescription = value; }
        }
        #endregion ValueDescription property accessor

        #region CreatedBy property accessor
        private System.Int32  _CreatedBy ;
        public virtual System.Int32 CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }
        #endregion CreatedBy property accessor

        #region CreatedDate property accessor
        private System.DateTime  _CreatedDate ;
        public virtual System.DateTime CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        #endregion CreatedDate property accessor

        #region UpdatedBy property accessor
        private System.Int32  _UpdatedBy ;
        public virtual System.Int32 UpdatedBy
        {
            get { return _UpdatedBy; }
            set { _UpdatedBy = value; }
        }
        #endregion UpdatedBy property accessor

        #region UpdatedDate property accessor
        private System.DateTime  _UpdatedDate ;
        public virtual System.DateTime UpdatedDate
        {
            get { return _UpdatedDate; }
            set { _UpdatedDate = value; }
        }
        #endregion UpdatedDate property accessor
        #endregion Table Attribute Accessors

    }  //  SubstanceUsageBase
}      //  DSHS.CMBHS.Model
