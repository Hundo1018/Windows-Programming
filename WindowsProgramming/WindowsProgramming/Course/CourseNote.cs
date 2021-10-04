using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    /// <summary>
    /// 課程備註資訊
    /// </summary>
    class CourseNote : ICourse
    {
        private string _syllabus;
        private string _remarks;
        private string _audit;
        private string _experiment;

        public CourseNote(string syllabus, string remarks, string audit, string experiment)
        {
            _syllabus = syllabus;
            _remarks = remarks;
            _audit = audit;
            _experiment = experiment;
            SetData(CourseIndex.Syllabus, _syllabus);
            SetData(CourseIndex.Remarks, _remarks);
            SetData(CourseIndex.Audit, _audit);
            SetData(CourseIndex.Experiment, _experiment);
        }

        public CourseNote(List<string> rawData)
        {
            _syllabus = rawData.First();
            rawData.RemoveAt(0);
            _remarks = rawData.First();
            rawData.RemoveAt(0);
            _audit = rawData.First();
            rawData.RemoveAt(0);
            _experiment = rawData.First();
            rawData.RemoveAt(0);
        }

        public string Syllabus
        {
            get 
            {
                return _syllabus;
            }
            set
            {
                _syllabus = value;
            }
        }

        public string Remarks
        {
            get 
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
            }
        }

        public string Audit
        {
            get 
            {
                return _audit;
            }
            set
            {
                _audit = value;
            }
        }

        public string Experiment
        {
            get 
            {
                return _experiment;
            }
            set
            {
                _experiment = value;
            }
        }
    }
}
