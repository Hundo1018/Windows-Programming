using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    class CourseTeacher
    {
        private string _instructor;
        private string _teachingAssistant;
        private string _classroom;
        private string _language;

        public string Instructor
        {
            get
            {
                return _instructor;
            }
            set
            {
                _instructor = value;
            }
        }

        public string TeachingAssistant
        {
            get 
            {
                return _teachingAssistant;
            }
            set
            {
                _teachingAssistant = value;
            }
        }

        public string Classroom
        {
            get 
            {
                return _classroom;
            }
            set
            {
                _classroom = value;
            }
        }

        public string Language
        {
            get 
            {
                return _language;
            }
            set
            {
                _language = value;
            }
        }

        public CourseTeacher(string instructor, string teachingAssistant, string classroom, string language)
        {
            _instructor = instructor;
            _teachingAssistant = teachingAssistant;
            _classroom = classroom;
            _language = language;
        }

        public CourseTeacher(List<string> rawData, out List<string> trimmedData)
        {
            const int CLASSROOM = 7;
            const int LANGUAGE = 9;
            _instructor = rawData.First();
            rawData.RemoveAt(0);
            _teachingAssistant = rawData[CLASSROOM];
            rawData.RemoveAt(CLASSROOM);
            _classroom = rawData[LANGUAGE];
            rawData.RemoveAt(LANGUAGE);
            _language = rawData[LANGUAGE];
            rawData.RemoveAt(LANGUAGE);
            trimmedData = rawData;
        }
    }
}
