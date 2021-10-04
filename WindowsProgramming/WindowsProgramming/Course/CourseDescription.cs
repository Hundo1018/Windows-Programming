using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    /// <summary>
    /// 課程描述
    /// </summary>
    class CourseDescription : ICourse
    {
        string _number;
        string _name;

        /// <summary>
        /// 課號
        /// </summary>
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
            }
        }

        /// <summary>
        /// 課程名稱
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public CourseDescription(string number, string name)
        {
            _number = number;
            _name = name;
            SetData(CourseIndex.Number, _number);
            SetData(CourseIndex.Name, _name);
        }
        public CourseDescription(List<string> rawData, out List<string> trimmedData)
        {
            _number = rawData.First();
            rawData.RemoveAt(0);
            _name = rawData.First();
            rawData.RemoveAt(0);
            trimmedData = rawData;
        }
    }
}
