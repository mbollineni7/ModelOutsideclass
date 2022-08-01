using System;
using System.Collections.Generic;
using System.Text;

namespace DSHS.CMBHS.Model
{
    public class SystemUserList : DSHS.CMBHS.Model.SystemUserListBase
    {
        public SystemUserList()
        {
            PaginationPage = 1;
            PaginationSize = 50;
            PaginationCount = 0;
        }

        private string _SecurityRoles;
        public string SecurityRoles
        {
            get { return _SecurityRoles; }
            set { _SecurityRoles = value; }
        }
        private string _Locations;
        public string Locations
        {
            get { return _Locations; }
            set { _Locations = value; }
        }
        public int PaginationPage { get; set; }
        public int PaginationSize { get; set; }
        public int PaginationCount { get; set; }
        public string OrderBy { get; set; }
        public string OrderAscDesc { get; set; }

    }
}
