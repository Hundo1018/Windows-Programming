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
            CourseDescription = new CourseDescription(data, out data);
            CourseScore = new CourseScore(data, out data);
            CourseTeacher = new CourseTeacher(data, out data);
            CourseTime = new CourseTime(data, out data);
            CourseStudent = new CourseStudent(data, out data);
            CourseNote = new CourseNote(data, out data);
            data.Add("");
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
