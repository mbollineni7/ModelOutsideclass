using System;
using System.ComponentModel;

namespace DSHS.CMBHS.Model 
{
//   <summary>
	// Generated By:   VKakaraparthi118 using CMBHS Generator v2.6
	// Schema:         CMBHS_DEV3
	// Date Generated: Monday, April 11, 2022
//   
/// Template Name:		CMBHSDomainObject.cs	
/// Template Version:	1.0
/// Template Date:		Dec 19, 2007
///
/// Template Description:
/// 	This template is used to generate
/// 	the base Domain objects for the DSHS.CMBHS.Model
///
/// Base Object Name:        SU_ASMT_PHYSICAL_HEALTH
/// Base Object Type:        Table
///
///  Class Information:
/// 	Base ClassName:      AbstractDomainObject
/// 	ClassName:           SuAsmtPhysicalHealthBase
/// 	Name Space Name:     DSHS.CMBHS.Model
///
///  File Information:
/// 	Template File Name:  CMBHSTableDomain
/// 	Class File Name:         SuAsmtPhysicalHealthBase.cs
///
/// Primary Key Name	PrimaryKeyColumnName 
/// SUASSESSMENTPHYHEALTH_PK SU_ASMT_PHYSICAL_HEALTH_NBR
///   </summary>

	public class SuAsmtPhysicalHealthBase : AbstractDomainObject
	{

		#region Table Attribute Accessors

		/// <summary>
		/// PrimaryKey property accessor
		/// </summary>
		[System.Xml.Serialization.XmlIgnore]
		public virtual String PrimaryKey{ get; set; }

		/// <summary>
		/// SuAsmtPhysicalHealthNbr property accessor
		/// </summary>
		[CustomAttribute.Comment("Primary Key - Unique row identifier.")]
		public virtual int SuAsmtPhysicalHealthNbr{ get; set;}

		/// <summary>
		/// SuAssessmentNbr property accessor
		/// </summary>
		[CustomAttribute.Comment("Unique row identifier for SU_ASSESSMENT table.")]
		[CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.SuAssessmentBase,DSHS.CMBHS.Model")]
		public virtual int SuAssessmentNbr{ get; set;}

		/// <summary>
		/// HistMedicalCondition property accessor
		/// </summary>
		[CustomAttribute.Comment("Do you have a history of medical conditions or medical problems?")]
		public virtual string HistMedicalCondition{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistMedicalConditionSpecified
		{
			get { return HistMedicalCondition != string.Empty; }
		}


		/// <summary>
		/// HistSubstanceUsedLonger property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you used larger amounts of alcohol or drugs or used them for a longer time than you planned?")]
		public virtual string HistSubstanceUsedLonger{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistSubstanceUsedLongerSpecified
		{
			get { return HistSubstanceUsedLonger != string.Empty; }
		}


		/// <summary>
		/// HistUnableToCutdown property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you tried to cut down on alcohol and drugs and were unable to do it?")]
		public virtual string HistUnableToCutdown{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistUnableToCutdownSpecified
		{
			get { return HistUnableToCutdown != string.Empty; }
		}


		/// <summary>
		/// HistAccidentDuetoHighUse property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you gotten so high or sick from alcohol or drugs that it caused an accident or became a danger to you or others?")]
		public virtual string HistAccidentDuetoHighUse{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistAccidentDuetoHighUseSpecified
		{
			get { return HistAccidentDuetoHighUse != string.Empty; }
		}


		/// <summary>
		/// HistSubUseMedicalIssue property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you gotten so high or sick from alcohol or drugs that it caused physical health or medical problems?")]
		public virtual string HistSubUseMedicalIssue{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistSubUseMedicalIssueSpecified
		{
			get { return HistSubUseMedicalIssue != string.Empty; }
		}


		/// <summary>
		/// HistSubUseIncreasEffect property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you increased the amount of alcohol or drugs you were taking so that you could get the same effects as before?")]
		public virtual string HistSubUseIncreasEffect{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistSubUseIncreasEffectSpecified
		{
			get { return HistSubUseIncreasEffect != string.Empty; }
		}


		/// <summary>
		/// HistWithdrawalEffect property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you gotten sick or had withdrawals when you quit drinking or missed taking a drug?")]
		public virtual string HistWithdrawalEffect{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistWithdrawalEffectSpecified
		{
			get { return HistWithdrawalEffect != string.Empty; }
		}


		/// <summary>
		/// HistContinuedAvoidWithdr property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you continued to drink or take drugs to avoid withdrawals or to keep from getting sick?")]
		public virtual string HistContinuedAvoidWithdr{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistContinuedAvoidWithdrSpecified
		{
			get { return HistContinuedAvoidWithdr != string.Empty; }
		}


		/// <summary>
		/// HistResultedHospitalization property accessor
		/// </summary>
		[CustomAttribute.Comment("Has your physical health been so bad that it resulted in hospitalization?")]
		public virtual string HistResultedHospitalization{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistResultedHospitalizationSpecified
		{
			get { return HistResultedHospitalization != string.Empty; }
		}


		/// <summary>
		/// HistComment property accessor
		/// </summary>
		[CustomAttribute.Comment("History section comments.")]
		public virtual string HistComment{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool HistCommentSpecified
		{
			get { return HistComment != string.Empty; }
		}


		/// <summary>
		/// CurrentChronicCondition property accessor
		/// </summary>
		[CustomAttribute.Comment("Do you currently have a chronic medical condition?")]
		public virtual string CurrentChronicCondition{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentChronicConditionSpecified
		{
			get { return CurrentChronicCondition != string.Empty; }
		}


		/// <summary>
		/// CurrentConditionExplain property accessor
		/// </summary>
		[CustomAttribute.Comment("Explain chronic medical condition, if you have.")]
		public virtual string CurrentConditionExplain{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentConditionExplainSpecified
		{
			get { return CurrentConditionExplain != string.Empty; }
		}


		/// <summary>
		/// CurrentPriscripMedication property accessor
		/// </summary>
		[CustomAttribute.Comment("Are you currently taking any prescribed medications for medical reasons?")]
		public virtual string CurrentPriscripMedication{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentPriscripMedicationSpecified
		{
			get { return CurrentPriscripMedication != string.Empty; }
		}


		/// <summary>
		/// CurrentPriscripMedList property accessor
		/// </summary>
		[CustomAttribute.Comment("Prescribed medications list.")]
		public virtual string CurrentPriscripMedList{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentPriscripMedListSpecified
		{
			get { return CurrentPriscripMedList != string.Empty; }
		}


		/// <summary>
		/// CurrentMatEnrolled property accessor
		/// </summary>
		[CustomAttribute.Comment("Are you enrolled in Medication Assisted Treatment?")]
		public virtual string CurrentMatEnrolled{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentMatEnrolledSpecified
		{
			get { return CurrentMatEnrolled != string.Empty; }
		}


		/// <summary>
		/// StoppedOpioidPescription property accessor
		/// </summary>
		[CustomAttribute.Comment("If any were marked, have you recently stopped prescription use of Vivitrol (naltrexone), methadone, or buprenorphine (Suboxone, Subutex)?")]
		public virtual string StoppedOpioidPescription{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool StoppedOpioidPescriptionSpecified
		{
			get { return StoppedOpioidPescription != string.Empty; }
		}


		/// <summary>
		/// NonFatalOpioidOverdose property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you experienced a non-fatal overdose?")]
		public virtual string NonFatalOpioidOverdose{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool NonFatalOpioidOverdoseSpecified
		{
			get { return NonFatalOpioidOverdose != string.Empty; }
		}


		/// <summary>
		/// EverAdministeredNaloxone property accessor
		/// </summary>
		[CustomAttribute.Comment("If yes, have you ever been administered naloxone or Narcan?")]
		public virtual string EverAdministeredNaloxone{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool EverAdministeredNaloxoneSpecified
		{
			get { return EverAdministeredNaloxone != string.Empty; }
		}


		/// <summary>
		/// CurrentMonthHospitalized property accessor
		/// </summary>
		[CustomAttribute.Comment("In the past 30 days, how many days have you been hospitalized?")]
		public virtual short CurrentMonthHospitalized{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentMonthHospitalizedSpecified
		{
			get { return CurrentMonthHospitalized != short.MinValue; }
		}


		/// <summary>
		/// DischargeHospitalized property accessor
		/// </summary>
		[CustomAttribute.Comment("How many days since discharge from Substance Use Treatment have you been hospitalized including emergency room visits?")]
		public virtual short DischargeHospitalized{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool DischargeHospitalizedSpecified
		{
			get { return DischargeHospitalized != short.MinValue; }
		}


		/// <summary>
		/// GaveBirthInLast18months property accessor
		/// </summary>
		[CustomAttribute.Comment("Have you given birth in the past 18 months?")]
		public virtual string GaveBirthInLast18months{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool GaveBirthInLast18monthsSpecified
		{
			get { return GaveBirthInLast18months != string.Empty; }
		}


		/// <summary>
		/// UsedOpioidLast3years property accessor
		/// </summary>
		[CustomAttribute.Comment("If yes, have you used opioids in the past 3 years?")]
		public virtual string UsedOpioidLast3years{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool UsedOpioidLast3yearsSpecified
		{
			get { return UsedOpioidLast3years != string.Empty; }
		}


		/// <summary>
		/// CurrentPregnant property accessor
		/// </summary>
		[CustomAttribute.Comment("Are you currently ????pregnant?")]
		public virtual string CurrentPregnant{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentPregnantSpecified
		{
			get { return CurrentPregnant != string.Empty; }
		}


		/// <summary>
		/// CurrentUsingTobacco property accessor
		/// </summary>
		[CustomAttribute.Comment("Are you using tobacco?")]
		[CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.AnswerTypeBase,DSHS.CMBHS.Model")]
		public virtual short CurrentUsingTobacco{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentUsingTobaccoSpecified
		{
			get { return CurrentUsingTobacco != short.MinValue; }
		}


		/// <summary>
		/// CurrentThinkPregnant property accessor
		/// </summary>
		[CustomAttribute.Comment("Do you think you could be pregnant?")]
		[CustomAttribute.ReferencedClass("DSHS.CMBHS.Model.AnswerTypeBase,DSHS.CMBHS.Model")]
		public virtual short CurrentThinkPregnant{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentThinkPregnantSpecified
		{
			get { return CurrentThinkPregnant != short.MinValue; }
		}


		/// <summary>
		/// CurrentAssistanceToQuit property accessor
		/// </summary>
		[CustomAttribute.Comment("Would you like assistance to cut back or quit?")]
		public virtual string CurrentAssistanceToQuit{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentAssistanceToQuitSpecified
		{
			get { return CurrentAssistanceToQuit != string.Empty; }
		}


		/// <summary>
		/// CurrentAnyAllergies property accessor
		/// </summary>
		[CustomAttribute.Comment("Do you have any allergies?")]
		public virtual string CurrentAnyAllergies{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentAnyAllergiesSpecified
		{
			get { return CurrentAnyAllergies != string.Empty; }
		}


		/// <summary>
		/// CurrentAllergiesList property accessor
		/// </summary>
		[CustomAttribute.Comment("List of allergies.")]
		public virtual string CurrentAllergiesList{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentAllergiesListSpecified
		{
			get { return CurrentAllergiesList != string.Empty; }
		}


		/// <summary>
		/// CurrentComment property accessor
		/// </summary>
		[CustomAttribute.Comment("Current section comment.")]
		public virtual string CurrentComment{ get; set;}

		// Used by XmlSerializer when serialized. We use a special pattern to create a Boolean field recognized
		// by the XmlSerializer, and to apply the XmlIgnoreAttribute to the field. The pattern is created in the
		// form of propertyNameSpecified. For example, if there is a field named "MyFirstName" you would also
		// create a field named "MyFirstNameSpecified" that instructs the XmlSerializer whether to generate the
		// XML element named "MyFirstName". We use this for all nullable properties. This will cause the property
		// to not render as an XmlElement (otherwise value types like short would render an element's text as -32768).
		[System.Xml.Serialization.XmlIgnore]
		public virtual bool CurrentCommentSpecified
		{
			get { return CurrentComment != string.Empty; }
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
