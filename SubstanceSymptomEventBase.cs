using System;
	 
namespace DSHS.CMBHS.Model 
{
	#region SubstanceSymptomEventBase Summary 
	/// <summary>
	/// 
	/// Template Name DomainObject.cst		
	/// Template Version 1.0
	/// Template Date Feb 1, 2006
	///
	/// Template Description:
	///		this template is used to generate the base Domain objects for 
	///		the DSHS.CMBHS.Model
	/// 
	/// Generator Version CodeSmith 3.1.6.594
	/// Generated On 9/21/2007 4:57:56 PM
	/// 
	/// 
	/// Base Object Name		SubstanceSymptomEvent 
	/// Base Object Type		Table
	///
	/// Class Information:
	/// 	Base ClassName 		DSHS.CMBHS.Model.AbstractDomainObject
	/// 	ClassName 			SubstanceSymptomEventBase
	/// 	Name Space Name		DSHS.CMBHS.Model 
	/// 
	/// File Information:
	/// 	Template File Name	DomainObject.cst
	///	Class File Name		SubstanceSymptomEventBase.cs 
	/// 
	///	Primary Key Name	PrimaryKeyColumnName 
	///	PK_SubstanceSymptomEvent	ValueNbr
	/// </summary>
	#endregion 
		 
	public class SubstanceSymptomEventBase : DSHS.CMBHS.Model.AbstractDomainObject
	{
		#region SubstanceSymptomEventBase Constructor
		public SubstanceSymptomEventBase () : base (){}
		#endregion	
		
		#region Table data Accessors
		public enum Code : short
		{
  			StoppingUse = 1,
  			CuttingDownUse = 2,
  			PeriodOfNoUse = 3,
  			Overdose = 4,
  			Other = 5
		}
		
		public static short MapDescription(string value)
		{
			if(value.ToLower().CompareTo("stopping use") == 0 )
				return (short)Code.StoppingUse;
			if(value.ToLower().CompareTo("cutting down use") == 0 )
				return (short)Code.CuttingDownUse;
			if(value.ToLower().CompareTo("period of no use") == 0 )
				return (short)Code.PeriodOfNoUse;
			if(value.ToLower().CompareTo("overdose") == 0 )
				return (short)Code.Overdose;
			if(value.ToLower().CompareTo("other") == 0 )
				return (short)Code.Other;
			return 0;
		}
		
		public static string GetDescription(Code value)
		{
			if(value == Code.StoppingUse)
				return "stopping use";
			if(value == Code.CuttingDownUse)
				return "cutting down use";
			if(value == Code.PeriodOfNoUse)
				return "period of no use";
			if(value == Code.Overdose)
				return "overdose";
			if(value == Code.Other)
				return "other";
			return string.Empty;
		}		
		#endregion Table data Accessors
		
		#region Table Attribute Accessors
		#region ValueNbr property accessor
		private System.Int16 _ValueNbr ;
		public virtual System.Int16 ValueNbr
		{
			get { return _ValueNbr; }
			set { _ValueNbr = value; }
		}
		#endregion ValueNbr property accessor
		#region ValueAbbrv property accessor
		private System.String _ValueAbbrv ;
		public virtual System.String ValueAbbrv
		{
			get { return _ValueAbbrv; }
			set { _ValueAbbrv = value; }
		}
		#endregion ValueAbbrv property accessor
		#region ValueDescription property accessor
		private System.String _ValueDescription ;
		public virtual System.String ValueDescription
		{
			get { return _ValueDescription; }
			set { _ValueDescription = value; }
		}
		#endregion ValueDescription property accessor
		#endregion Table Attribute Accessors
		}	 
}
