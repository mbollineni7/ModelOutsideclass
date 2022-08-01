using System;

namespace DSHS.CMBHS.Model
{
    public interface ITreatmentPlanRuleView
    {
        int AdmissionServiceNbr { get; set; }
        short ServiceTypeNbr { get; set; }
        short FundingSource { get; set; }
        string TreatmentPlanRequired { get; set; }
        DateTime TreatmentPlanDocStatusDate { get; set; }
        DateTime ServiceDate { get; set; }
        int DocumentNbr { get; set; }
    }

    public class TreatmentPlanRuleView : TreatmentPlanRuleViewBase
    {
        public DateTime ServiceDate { get; set; }
        public int MinDocumentNbr { get; set; }
        public int ServiceDateDocumentCount { get; set; }
    }
}