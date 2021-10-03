using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    class CourseTime
    {
        private readonly Dictionary<uint, List<string>> _week;

        /// <summary>
        /// 指定加入授課時間
        /// </summary>
        /// <param name="week"></param>
        /// <param name="time"></param>
        public void Add(uint week, string time)
        {
            _week.Add(week, new List<string>());
            _week[week].Add(time);
        }

        public CourseTime()
        {
            _week = new Dictionary<uint, List<string>>();
        }
        public CourseTime(List<string> rawData, out List<string> trimmedData)
        {
            _week = new Dictionary<uint, List<string>>();
            const int WEEK = 7;
            for (uint i = 0; i < WEEK; i++)
            {
                Add(i, rawData.First());
                rawData.RemoveAt(0);
            }
            trimmedData = rawData;
        }
    }
}
