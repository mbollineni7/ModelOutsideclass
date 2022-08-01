
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DSHS.CMBHS.Model 
{
	public class SuAsmtDiagnosis : SuAsmtDiagnosisBase
	{
        [XmlIgnore]
        public List<IAxisDiagnosis> AxisDiagnosisList { get; set; }

        public void InitializeAxisDiagnosisList()
        {
            AxisDiagnosisList = new List<IAxisDiagnosis>(18);
            for (short j = 0; j < 18; j++)
            {
                var ad = new SuAsmtAxisDiagnosis()
                {
                    DiagnosisOrder = j,
                    Diagnosis = int.MinValue,
                    DiagnosisName = string.Empty,
                    AxisJustificationType = short.MinValue
                };
                AxisDiagnosisList.Add(ad);
            }
        }
	}
} 
