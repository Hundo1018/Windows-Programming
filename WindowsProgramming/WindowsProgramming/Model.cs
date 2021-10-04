using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem
{
    public class Model
    {
        public delegate void CheckOneEventHandler(object sender, Course.CheckEventArguments eventArgs);
        public event CheckOneEventHandler CheckOneEvent;
        private List<Course.Course> _courses;
        private List<string> _headers;
        private List<bool> _checkList;
        public Model()
        {
            _courses = new List<Course.Course>();
            _checkList = new List<bool>();
            Build();
        }

        /// <summary>
        /// 建構
        /// </summary>
        public void Build()
        {
            _checkList = new List<bool>();
            _courses = new List<Course.Course>();
            WebCrawler webCrawler = new WebCrawler();
            List<List<string>> rawData = webCrawler.Crawl();
            const string SELECT = "選";
            _headers = new List<string>() 
            {
                SELECT };
            _headers.AddRange(rawData[0]);
            rawData.RemoveAt(0);
            for (int i = 0; i < rawData.Count; i++)
            {
                _courses.Add(CreateData(rawData[i]));
                _checkList.Add(false);
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
        /// 改變選課
        /// </summary>
        /// <param name="isChecked"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        public void Checked(int rowIndex, int columnIndex)
        {
            if (columnIndex == 0)
            {
                _checkList[rowIndex] = !_checkList[rowIndex];
                CheckAtLeastOne(_checkList);
            }
        }

        /// <summary>
        /// 確認至少有一個數值被設定了
        /// </summary>
        private void CheckAtLeastOne(List<bool> list)
        {
            bool isChecked = false;
            for (int i = 0; i < list.Count; i++)
            {
                isChecked |= (bool)list[i];
            }
            CheckOneEvent.Invoke(this, new Course.CheckEventArguments(isChecked));
        }

        /// <summary>
        /// 設定至少選取一的事件
        /// </summary>
        /// <param name="checkAtleastOneEventHandler"></param>
        public void SetCheckEvent(CheckOneEventHandler checkOneEventHandler)
        {
            CheckOneEvent += checkOneEventHandler;
            CheckAtLeastOne(_checkList);
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
                List<object> list = new List<object>()
                { 
                    false };
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
