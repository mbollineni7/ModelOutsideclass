using DSHS.CMBHS.Model.CustomAttribute;
using System;
using System.Xml.Serialization;

namespace DSHS.CMBHS.Model
{
    public class SuAssessment : SuAssessmentBase, IDiagnosis, IClinicalDocument
    {
        public SuAssessment()
        {
            SuAsmtLegal = new SuAsmtLegal();
            SuAsmtPhysicalHealth = new SuAsmtPhysicalHealth();
            SuAsmtRecommendation = new SuAsmtRecommendation();
            SuAsmtDiagnosis = new SuAsmtDiagnosis();
            SuAsmtFamilySocial = new SuAsmtFamilySocial();
            SuAsmtEduEmployment = new SuAsmtEduEmployment();
            SuAsmtSubstanceUse = new SuAsmtSubstanceUse();
            SuAsmtMentalHealth = new SuAsmtMentalHealth();
            SuAssessmentPrimaryPresentingProblem = new SuAsmtPresentingProblem();
            SuAssessmentSecondaryPresentingProblem = new SuAsmtPresentingProblem();
            SuAssessmentTertiaryPresentingProblem = new SuAsmtPresentingProblem();
            
            PaginationPage = "1";
            PaginationSize = "50";
            PaginationCount = "0";
        }

        [System.Xml.Serialization.XmlIgnore]
        public virtual bool TcReferralExist { get; set; }
        public SuAsmtEduEmployment SuAsmtEduEmployment { get; set; }
        public SuAsmtLegal SuAsmtLegal { get; set; }
        public SuAsmtPhysicalHealth SuAsmtPhysicalHealth { get; set; }
        public SuAsmtMentalHealth SuAsmtMentalHealth { get; set; }
        public SuAsmtSubstanceUse SuAsmtSubstanceUse { get; set; }
        public SuAsmtRecommendation SuAsmtRecommendation { get; set; }
        public SuAsmtDiagnosis SuAsmtDiagnosis { get; set; }
        public SuAsmtFamilySocial SuAsmtFamilySocial { get; set; }
        public TcReferral TcReferral { get; set; }
        [XmlIgnore]
        public String ClientFirstName { get; set; }
        [XmlIgnore]
        public String ClientLastName { get; set; }
        [XmlIgnore]
        public Int16 ClientRaceCode { get; set; }
        public short ClientGender { get; set; }
        public short ClientAge { get; set; }

        #region DetoxServiceBeginDate property accessor

        [Comment("This field identifies the Detox services Begin Date")]
        [XmlIgnore]
        public virtual DateTime DetoxServiceBeginDate { get; set; }

        #endregion DetoxServiceBeginDate property accessor

        [XmlIgnore]
        public string CurrentDiagControl { get; set; }

        [XmlIgnore]
        public SuAsmtProvider SuAssessmentServiceProvider { get; set; }

        public SuAsmtProvider[] SuAssessmentServiceProviders { get; set; }

        [XmlIgnore]
        public SuAsmtPresentingProblem SuAssessmentPrimaryPresentingProblem { get; set; }
        [XmlIgnore]
        public SuAsmtPresentingProblem SuAssessmentSecondaryPresentingProblem { get; set; }
        [XmlIgnore]
        public SuAsmtPresentingProblem SuAssessmentTertiaryPresentingProblem { get; set; }


        public string SearchKey { get; set; }
        public string PaginationPage { get; set; }
        public string PaginationSize { get; set; }
        public string PaginationCount { get; set; }
        public FamilySocialChild[] FamilySocialChildList { get; set; }

   
        public SubUseTreatmentEpisode[] SubUseTreatmentEpisodeList { get; set; }
        public short ActiveTabAssessment { get; set; }
        public int ParentOrganizationNbr { get; set; }

        public string SelectedAdmissionServiceNbrs { get; set; }

        /* For Attach documents */
        public short ClientActivityType
        {
            get { return IsSuDetoxAssessment ? (short)Model.ClientActivityTypeBase.Code.SuDetoxificationServices
                : (short)Model.ClientActivityTypeBase.Code.AssessmentSud; }
            set { ;}
        }
        public int DocumentNbr
        {
            get { return SuAssessmentNbr; }
            // this needs a setter for DOSS to render it, but we dont want a setter so make dummy
            set { ;}
        }

        #region private DateTime AdmissionDate

        public DateTime AdmissionDate { get; set; }

        #endregion


        #region string FollowupContactTime
        private string _FollowupContactTime;
        [System.Xml.Serialization.XmlIgnore]
        public string ContactTime
        {
            get
            {
                return !string.IsNullOrEmpty(_FollowupContactTime) ? _FollowupContactTime : ContactDate.ToString("hh:mm");
            }
            set { _FollowupContactTime = value; }
        }
        #endregion

        #region FollowupContactTimeAmPm property accessor
        private short _ContactTimeAmPm;
        [System.Xml.Serialization.XmlIgnore]
        public short ContactTimeAmPm
        {
            get
            {
                return _ContactTimeAmPm != short.MinValue ? _ContactTimeAmPm :
                    (short)(Meridiem.Code)Enum.Parse(typeof(Meridiem.Code), ContactDate.ToString("tt"), true);
            }
            set { _ContactTimeAmPm = value; }
        }
        #endregion 

        public bool MadeContactWithClient
        {
            get { return ContactType == (short)SuContactTypeBase.Code.WithClient; }
        }

        public bool DischargeFollowupNotAllowed {get;set;}
        public int DischargeAssessmentNbr { get; set; }

        public bool IsSuDetoxAssessment { get; set; }

        public override int PerformedBy
        {
            get { return Interviewer; }
            set { Interviewer = value; }
        }
        [XmlIgnore]
        public bool SuAgeAtFirstUseNum { get; set; }
    }
} 
