using System;
	 
namespace DSHS.CMBHS.Model 
{
    public class TimaNotePrescribedMed : DSHS.CMBHS.Model.TimaNotePrescribedMedBase
	{
        #region public bool HasBeenEdited
        private bool _HasBeenEdited = false;
        public bool HasBeenEdited
        {
            get { return _HasBeenEdited; }
            set { _HasBeenEdited = value; }
        }
        #endregion

        #region public bool HasBeenDeleted
        private bool _HasBeenDeleted = false;
        public bool HasBeenDeleted
        {
            get { return _HasBeenDeleted; }
            set { _HasBeenDeleted = value; }
        }
        #endregion

	}	 
}
