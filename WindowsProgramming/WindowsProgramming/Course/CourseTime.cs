using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    class CourseTime : ICourse
    {
        private readonly Dictionary<uint, List<string>> _week;
        private const int WEEK = 7;
        /// <summary>
        /// 指定加入授課時間
        /// </summary>
        /// <param name="week"></param>
        /// <param name="time"></param>
        public void Add(uint week, string time)
        {
            _week.Add(week, new List<string>());
            _week[week].Add(time);
            SetData((CourseIndex)(week + WEEK), time);
        }

        /// <summary>
        /// 目前未分割時間所以直接取得位置0的一整周資訊
        /// </summary>
        public List<string> GetWeek()
        {
            List<string> data = new List<string>();
            foreach (var item in _week.Values)
            {
                data.Add(item[0]);
            }
            return data;
        }

        public CourseTime()
        {
            _week = new Dictionary<uint, List<string>>();
        }
        public CourseTime(List<string> rawData, out List<string> trimmedData)
        {
            _week = new Dictionary<uint, List<string>>();
            
            for (uint i = 0; i < WEEK; i++)
            {
                Add(i, rawData.First());
                rawData.RemoveAt(0);
            }
            trimmedData = rawData;
        }
    }
}
