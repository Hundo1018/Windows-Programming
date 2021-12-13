using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSelectionSystem
{
    public partial class CourseManagementForm : Form
    {
        private CourseManagementFormPresentationModel _model;
        public CourseManagementForm()
        {
            InitializeComponent();
        }
        public CourseManagementForm(CourseManagementFormPresentationModel model)
        {
            _model = model;
        }
    }
}
