using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    /// <summary>
    /// 課程
    /// </summary>
    class Course
    {
        private CourseDescription _courseDescription;//課號、課程名稱
        private CourseScore _courseScore;//階段、學分、時數、修
        private CourseTeacher _courseTeacher;//教師、教室、教學助理、授課語言
        private CourseNote _courseNote;//教學大綱、備註、隨班附讀、實驗實習
        private CourseStudent _courseStudent;//選修人數、撤選人數
        private CourseTime _courseTime;//0~6 星期日~星期六

        public Course(List<string> data)
        {
            CourseDescription = new CourseDescription(data, out data);//這裡或許可以改用IEnumerable來做
            CourseScore = new CourseScore(data, out data);
            CourseTeacher = new CourseTeacher(data, out data);
            CourseTime = new CourseTime(data, out data);
            CourseStudent = new CourseStudent(data, out data);
            CourseNote = new CourseNote(data);
        }

        /// <summary>
        /// 取得一個Row的資訊
        /// </summary>
        /// <returns></returns>
        public List<object> GetRow()
        {
            List<object> data = new List<object>();
            data.AddRange(GetTopHalfRow());
            data.AddRange(GetBottomHalfRow());
            return data;
        }

        /// <summary>
        /// 取得上半部的資料Row
        /// </summary>
        /// <returns></returns>
        private List<object> GetTopHalfRow()
        {
            List<object> data = new List<object>();
            data.AddRange(new List<object>()
            {
                _courseDescription.Number, _courseDescription.Name, _courseScore.Phase, _courseScore.Credits
            });
            data.AddRange(new List<object>()
            {
                _courseScore.Hours.ToString(), _courseScore.Require, _courseTeacher.Instructor
            });
            data.AddRange(_courseTime.GetWeek());
            return data;
        }

        /// <summary>
        /// 取得下半部的資料
        /// </summary>
        /// <returns></returns>
        private List<object> GetBottomHalfRow()
        {
            List<object> data = new List<object>();
            data.AddRange(new List<object>()
            {
                _courseTeacher.Classroom, _courseStudent.StudentNo, _courseStudent.WithDrop, _courseTeacher.TeachingAssistant
            });
            data.AddRange(new List<object>()
            {
                _courseTeacher.Language, _courseNote.Syllabus, _courseNote.Remarks, _courseNote.Audit
            });
            data.AddRange(new List<object>()
            {
                _courseNote.Experiment
            });
            return data;
        }

        public Course()
        {

        }

        public CourseDescription CourseDescription
        {
            get
            {
                return _courseDescription;
            }
            set
            {
                _courseDescription = value;
            }
        }

        public CourseScore CourseScore
        {
            get
            {
                return _courseScore;
            }
            set
            {
                _courseScore = value;
            }
        }

        public CourseTeacher CourseTeacher
        {
            get
            {
                return _courseTeacher;
            }
            set
            {
                _courseTeacher = value;
            }
        }

        public CourseNote CourseNote
        {
            get
            {
                return _courseNote;
            }
            set
            {
                _courseNote = value;
            }
        }

        public CourseStudent CourseStudent
        {
            get
            {
                return _courseStudent;
            }
            set
            {
                _courseStudent = value;
            }
        }

        public CourseTime CourseTime
        {
            get
            {
                return _courseTime;
            }
            set
            {
                _courseTime = value;
            }
        }

    }
}
