using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    public class CheckEventArguments : EventArgs
    {
        private bool _checked;
        public CheckEventArguments(bool check)
        {
            _checked = check;
        }

        public bool Checked
        {
            get
            {
                return _checked;
            }
            set
            {
                _checked = value;
            }
        }
    }
}