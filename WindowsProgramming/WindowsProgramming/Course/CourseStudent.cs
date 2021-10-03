using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    /// <summary>
    /// 學生資訊
    /// </summary>
    class CourseStudent
    {
        private uint _studentNo;
        private uint _withDrop;

        /// <summary>
        /// 選修人數
        /// </summary>
        public uint StudentNo
        {
            get
            {
                return _studentNo;
            }

            set
            {
                _studentNo = value;
            }
        }

        /// <summary>
        /// 撤選人數
        /// </summary>
        public uint WithDrop
        {
            get 
            {
                return _withDrop;
            }
            set
            {
                _withDrop = value;
            }
        }

        public CourseStudent(uint studentNo, uint withDrop)
        {
            _studentNo = studentNo;
            _withDrop = withDrop;
        }
        public CourseStudent(List<string> rawData, out List<string> trimmedData)
        {
            uint.TryParse(rawData.First(), out _studentNo);
            rawData.RemoveAt(0);
            uint.TryParse(rawData.First(), out _withDrop);
            rawData.RemoveAt(0);
            trimmedData = rawData;
        }
    }
}
