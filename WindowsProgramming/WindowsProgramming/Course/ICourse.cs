using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    class ICourse
    {
        public enum CourseIndex
        {
            Number,
            Name,
            Phase,
            Credits,
            Hours,
            Require,
            Instructor,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Classroom,
            StudentNo,
            WithDrop,
            TeachingAssistant,
            Language,
            Syllabus,
            Remarks,
            Audit,
            Experiment
        }
        readonly private Dictionary<CourseIndex, object> _datas;

        /// <summary>
        /// 取得資料
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public virtual object GetData(CourseIndex index)
        {
            return _datas[index];
        }

        /// <summary>
        /// 設定資料
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
        public virtual void SetData(CourseIndex index, object data)
        {
            if (_datas.ContainsKey(index))
            {
                _datas[index] = data;
            }
            else
            {
                _datas.Add(index, data);
            }
        }

        /// <summary>
        /// 結合其他資訊
        /// </summary>
        /// <param name="course"></param>
        /// <returns></returns>
        public List<object> Combine(params object[] course)
        {
            return course.ToList();
        }

        /// <summary>
        /// 結合其他資訊
        /// </summary>
        /// <param name="list"></param>
        /// <param name="course"></param>
        /// <returns></returns>
        public List<object> Combine(List<object> list, params object[] course)
        {
            list.AddRange(course.ToList());
            return list;
        }

        public ICourse()
        {
            _datas = new Dictionary<CourseIndex, object>();
        }

        /// <summary>
        /// test
        /// </summary>
        /// <returns></returns>
        public ICourse GetList()
        {
            return this;
        }
    }
}
