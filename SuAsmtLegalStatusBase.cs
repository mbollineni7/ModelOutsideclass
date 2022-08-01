using System;
using System.ComponentModel;

namespace DSHS.CMBHS.Model 
{
//   <summary>
	// Generated By:   LACTsthomas488 using CMBHS Generator v2.6
	// Schema:         CMBHS_DEV3
	// Date Generated: Monday, May 01, 2017
//   
/// Template Name:		CMBHSDomainObject.cs	
/// Template Version:	1.0
/// Template Date:		Dec 19, 2007
///
/// Template Description:
/// 	This template is used to generate
/// 	the base Domain objects for the DSHS.CMBHS.Model
///
/// Base Object Name:        SU_ASMT_LEGAL_STATUS
/// Base Object Type:        Table
///
///  Class Information:
/// 	Base ClassName:      AbstractDomainObject
/// 	ClassName:           SuAsmtLegalStatusBase
/// 	Name Space Name:     DSHS.CMBHS.Model
///
///  File Information:
/// 	Template File Name:  CMBHSTableDomain
/// 	Class File Name:         SuAsmtLegalStatusBase.cs
///
/// Primary Key Name	PrimaryKeyColumnName 
/// SU_ASMT_LEGAL_STATUS_PK VALUE_NBR
///   </summary>

	public class SuAsmtLegalStatusBase : AbstractDomainObject
	{

		#region Table data Accessors

		public enum Code : short
		{
			PastProbation = 1,
			PastParole = 2,
			PastIncarceration = 3,
			JailOrPrison = 4,
			Probation = 5,
			Parole = 6,
			DiversionProgram = 7,
			AwaitingTrial = 8,
			AwaitingSentencing = 9,
			NA = 10
		}

		public static short MapDescription(string value)
		{
			if (value.ToLower().CompareTo("past probation") == 0)
			return (short)Code.PastProbation;
			if (value.ToLower().CompareTo("past parole") == 0)
			return (short)Code.PastParole;
			if (value.ToLower().CompareTo("past incarceration") == 0)
			return (short)Code.PastIncarceration;
			if (value.ToLower().CompareTo("jail or prison") == 0)
			return (short)Code.JailOrPrison;
			if (value.ToLower().CompareTo("probation") == 0)
			return (short)Code.Probation;
			if (value.ToLower().CompareTo("parole") == 0)
			return (short)Code.Parole;
			if (value.ToLower().CompareTo("diversion program") == 0)
			return (short)Code.DiversionProgram;
			if (value.ToLower().CompareTo("awaiting trial") == 0)
			return (short)Code.AwaitingTrial;
			if (value.ToLower().CompareTo("awaiting sentencing") == 0)
			return (short)Code.AwaitingSentencing;
			if (value.ToLower().CompareTo("na") == 0)
			return (short)Code.NA;
			return 0;
		}

		public static string GetDescription(Code value)
		{
			if(value == Code.PastProbation)
				return "Past Probation";
			if(value == Code.PastParole)
				return "Past Parole";
			if(value == Code.PastIncarceration)
				return "Past Incarceration";
			if(value == Code.JailOrPrison)
				return "Jail or Prison";
			if(value == Code.Probation)
				return "Probation";
			if(value == Code.Parole)
				return "Parole";
			if(value == Code.DiversionProgram)
				return "Diversion Program";
			if(value == Code.AwaitingTrial)
				return "Awaiting Trial";
			if(value == Code.AwaitingSentencing)
				return "Awaiting Sentencing";
			if(value == Code.NA)
				return "NA";
			return string.Empty;
		}

		public static string GetValueCode(Code value)
		{
			if(value == Code.PastProbation)
				return "";
			if(value == Code.PastParole)
				return "";
			if(value == Code.PastIncarceration)
				return "";
			if(value == Code.JailOrPrison)
				return "";
			if(value == Code.Probation)
				return "";
			if(value == Code.Parole)
				return "";
			if(value == Code.DiversionProgram)
				return "";
			if(value == Code.AwaitingTrial)
				return "";
			if(value == Code.AwaitingSentencing)
				return "";
			if(value == Code.NA)
				return "";
			return string.Empty;
		}

		#endregion Table data Accessors

		#region Table Attribute Accessors

		/// <summary>
		/// PrimaryKey property accessor
		/// </summary>
		[System.Xml.Serialization.XmlIgnore]
		public virtual String PrimaryKey{ get; set; }

		/// <summary>
		/// ValueNbr property accessor
		/// </summary>
		public virtual short ValueNbr{ get; set;}

		/// <summary>
		/// ValueAbbrv property accessor
		/// </summary>
		public virtual string ValueAbbrv{ get; set;}

		/// <summary>
		/// ValueDescription property accessor
		/// </summary>
		public virtual string ValueDescription{ get; set;}

		/// <summary>
		/// ValueCode property accessor
		/// </summary>
		public virtual string ValueCode{ get; set;}

		/// <summary>
		/// EffectiveDate property accessor
		/// </summary>
		public virtual DateTime EffectiveDate{ get; set;}

		/// <summary>
		/// ExpirationDate property accessor
		/// </summary>
		public virtual DateTime ExpirationDate{ get; set;}

		/// <summary>
		/// CreatedBy property accessor
		/// </summary>
		[CustomAttribute.Comment("This is the tracking number of the person who created the record. This field can be associated with the PERSON table to obtain additional information about the person who created the record.")]
		[CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.PersonBase,DSHS.CMBHS.Model")]
		public virtual int CreatedBy{ get; set;}

		/// <summary>
		/// CreatedDate property accessor
		/// </summary>
		[CustomAttribute.Comment("Date record was created.")]
		public virtual DateTime CreatedDate{ get; set;}

		/// <summary>
		/// UpdatedBy property accessor
		/// </summary>
		[CustomAttribute.Comment("This is the tracking number of the person who updated the record. This field can be associated with the PERSON table to obtain additional information about the person who updated the record.")]
		[CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.PersonBase,DSHS.CMBHS.Model")]
		public virtual int UpdatedBy{ get; set;}

		/// <summary>
		/// UpdatedDate property accessor
		/// </summary>
		[CustomAttribute.Comment("Date record was updated.")]
		public virtual DateTime UpdatedDate{ get; set;}
		#endregion Table Attribute Accessors
	}
}