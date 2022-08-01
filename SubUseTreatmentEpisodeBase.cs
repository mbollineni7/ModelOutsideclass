using System;
using System.ComponentModel;

namespace DSHS.CMBHS.Model 
{
//   <summary>
	// Generated By:   lactbprakash581 using CMBHS Generator v2.6
	// Schema:         CMBHS_TEST3
	// Date Generated: Wednesday, August 09, 2017
//   
/// Template Name:		CMBHSDomainObject.cs	
/// Template Version:	1.0
/// Template Date:		Dec 19, 2007
///
/// Template Description:
/// 	This template is used to generate
/// 	the base Domain objects for the DSHS.CMBHS.Model
///
/// Base Object Name:        SUB_USE_TREATMENT_EPISODE
/// Base Object Type:        Table
///
///  Class Information:
/// 	Base ClassName:      AbstractDomainObject
/// 	ClassName:           SubUseTreatmentEpisodeBase
/// 	Name Space Name:     DSHS.CMBHS.Model
///
///  File Information:
/// 	Template File Name:  CMBHSTableDomain
/// 	Class File Name:         SubUseTreatmentEpisodeBase.cs
///
/// Primary Key Name	PrimaryKeyColumnName 
/// SUBUSETREATMENTEPISODE_PK SUB_USE_TREATMENT_EPISODE_NBR
///   </summary>

	public class SubUseTreatmentEpisodeBase : AbstractDomainObject
	{

		#region Table Attribute Accessors

		/// <summary>
		/// PrimaryKey property accessor
		/// </summary>
		[System.Xml.Serialization.XmlIgnore]
		public virtual String PrimaryKey{ get; set; }

		/// <summary>
		/// SubUseTreatmentEpisodeNbr property accessor
		/// </summary>
		public virtual int SubUseTreatmentEpisodeNbr{ get; set;}

		/// <summary>
		/// AssessmentSubstanceUseNbr property accessor
		/// </summary>
		[CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.SuAsmtSubstanceUseBase,DSHS.CMBHS.Model")]
		public virtual int AssessmentSubstanceUseNbr{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool AssessmentSubstanceUseNbrSpecified
		{
			get { return AssessmentSubstanceUseNbr != int.MinValue; }
		}


		/// <summary>
		/// NumberOfEpisodes property accessor
		/// </summary>
		public virtual short NumberOfEpisodes{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool NumberOfEpisodesSpecified
		{
			get { return NumberOfEpisodes != short.MinValue; }
		}


		/// <summary>
		/// TreatmentServiceReceived property accessor
		/// </summary>
		[CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.TreatmentServicesReceivedBase,DSHS.CMBHS.Model")]
		public virtual short TreatmentServiceReceived{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool TreatmentServiceReceivedSpecified
		{
			get { return TreatmentServiceReceived != short.MinValue; }
		}


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
