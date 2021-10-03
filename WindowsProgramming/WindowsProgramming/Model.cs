using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem
{
    class Model
    {
        private List<Course.Course> _courses;

        public Model()
        {
            _courses = new List<Course.Course>();
        }

        /// <summary>
        /// 建構
        /// </summary>
        public void Build()
        {
            _courses = new List<Course.Course>();
            WebCrawler webCrawler = new WebCrawler();
            List<List<string>> rawData = webCrawler.Crawl();
            for (int i = 0; i < rawData.Count; i++)
            {
                _courses.Add(CreateData(rawData[i]));
            }
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
