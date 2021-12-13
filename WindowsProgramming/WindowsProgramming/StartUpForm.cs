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
    public partial class StartUpForm : Form
    {
        public StartUpForm()
        {
            InitializeComponent();
        }
        private StartUpFormPresentationModel _model;
        public StartUpForm(StartUpFormPresentationModel model)
        {
            _model = model;
        }

    }
}
