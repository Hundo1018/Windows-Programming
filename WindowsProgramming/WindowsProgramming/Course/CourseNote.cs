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
    class CourseNote
    {
        private string _syllabus;
        private string _remarks;
        private string _audit;
        private string _pratice;

        public CourseNote(string syllabus, string remarks, string audit, string pratice)
        {
            _syllabus = syllabus;
            _remarks = remarks;
            _audit = audit;
            _pratice = pratice;
        }

        public CourseNote(List<string> rawData, out List<string> trimmedData)
        {
            _syllabus = rawData.First();
            rawData.RemoveAt(0);
            _remarks = rawData.First();
            rawData.RemoveAt(0);
            _audit = rawData.First();
            rawData.RemoveAt(0);
            _pratice = rawData.First();
            rawData.RemoveAt(0);
            trimmedData = rawData;
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

        public string Pratice
        {
            get 
            {
                return _pratice;
            }
            set
            {
                _pratice = value;
            }
        }
    }
}
