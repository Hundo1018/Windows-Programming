using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem
{
    public class Model
    {
        private List<Course.Course> _courses;
        private List<string> _headers;
        public Model()
        {
            _courses = new List<Course.Course>();
            Build();
        }

        /// <summary>
        /// 建構
        /// </summary>
        public void Build()
        {
            _courses = new List<Course.Course>();
            WebCrawler webCrawler = new WebCrawler();
            List<List<string>> rawData = webCrawler.Crawl();
            const string SELECT = "選";
            _headers = new List<string>();
            _headers.Add(SELECT);

            _headers.AddRange(rawData[0]);
            rawData.RemoveAt(0);
            for (int i = 0; i < rawData.Count; i++)
            {
                _courses.Add(CreateData(rawData[i]));
            }
        }

        /// <summary>
        /// 取得column的標題
        /// </summary>
        /// <returns></returns>

        public List<string> GetHeaders()
        {
            
            return _headers;
        }

        /// <summary>
        /// 取得表格
        /// </summary>
        /// <returns>string[][23]</returns>
        public object[][] GetTable()
        {
            object[][] table = new object[_courses.Count][];
            for (int i = 0; i < _courses.Count; i++)
            {
                List<object> list = new List<object>();
                list.Add(false);
                list.AddRange(_courses[i].GetRow());
                table[i] = list.ToArray();
            }
            return table.ToArray();
        }

        /// <summary>
        /// 創建資料
        /// </summary>
        /// <param name="rawData"></param>
        /// <returns></returns>
        Course.Course CreateData(List<string>rawDataRow)
        {
            Course.Course course = new Course.Course(rawDataRow);
            return course;
        }
    }
}
