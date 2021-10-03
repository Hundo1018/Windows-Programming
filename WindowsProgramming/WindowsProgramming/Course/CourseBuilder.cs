using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    class CourseBuilder : ICourseBuilder
    {
        private Course _course;

        /// <summary>
        /// 重設
        /// </summary>
        public void Reset()
        {
            _course = new Course();
        }

        /// <summary>
        /// 設定教室
        /// </summary>
        /// <param name="classroom"></param>
        /// <returns></returns>
        public ICourseBuilder SetClassroom(HyperLink classroom)
        {
            _course.SetClassroom(classroom);
            return this;
        }

        /// <summary>
        /// 設定課程編碼
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public ICourseBuilder SetCode(HyperLink code)
        {
            _course.SetCode(code);
            return this;
        }

        /// <summary>
        /// 設定學分
        /// </summary>
        /// <param name="credits"></param>
        /// <returns></returns>
        public ICourseBuilder SetCredits(uint credits)
        {
            _course.SetCredits(credits);
            return this;
        }

        /// <summary>
        /// 設定
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public ICourseBuilder SetDescription(string description)
        {
            _course.SetDescription(description);
            return this;
        }

        /// <summary>
        /// 設定時數
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        public ICourseBuilder SetHours(uint hours)
        {
            _course.SetHours(hours);
            return this;
        }

        /// <summary>
        /// 設定教師
        /// </summary>
        /// <param name="instructor"></param>
        /// <returns></returns>
        public ICourseBuilder SetInstructor(HyperLink instructor)
        {
            _course.SetInstructor(instructor);
            return this;
        }

        /// <summary>
        /// 設定語言
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public ICourseBuilder SetLanguage(string language)
        {
            _course.SetLanguage(language);
            return this;
        }

        /// <summary>
        /// 設定課程名稱
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public ICourseBuilder SetName(HyperLink name)
        {
            _course.SetName(name);
            return this;
        }

        /// <summary>
        /// 設定課號
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public ICourseBuilder SetNumber(HyperLink number)
        {
            _course.SetNumber(number);
            return this;
        }

        /// <summary>
        /// 設定階段
        /// </summary>
        /// <param name="phase"></param>
        /// <returns></returns>
        public ICourseBuilder SetPhase(uint phase)
        {
            _course.SetPhase(phase);
            return this;
        }

        /// <summary>
        /// 設定實驗實習
        /// </summary>
        /// <param name="pratice"></param>
        /// <returns></returns>
        public ICourseBuilder SetPratice(string pratice)
        {
            _course.SetPratice(pratice);
            return this;
        }

        /// <summary>
        /// 設定備註
        /// </summary>
        /// <param name="remarks"></param>
        /// <returns></returns>
        public ICourseBuilder SetRemarks(string remarks)
        {
            _course.SetRemarks(remarks);
            return this;
        }

        /// <summary>
        /// 設定必修/選修
        /// </summary>
        /// <param name="require"></param>
        /// <returns></returns>
        public ICourseBuilder SetRequireElective(HyperLink require)
        {
            _course.SetRequireElective(require);
            return this;
        }

        /// <summary>
        /// 設定修課人數
        /// </summary>
        /// <param name="studentNo"></param>
        /// <returns></returns>
        public ICourseBuilder SetStudentNo(uint studentNo)
        {
            _course.SetStudentNo(studentNo);
            return this;
        }

        /// <summary>
        /// 設定課程大綱
        /// </summary>
        /// <param name="syllabus"></param>
        /// <returns></returns>
        public ICourseBuilder SetSyllabus(HyperLink syllabus)
        {
            _course.SetSyllabus(syllabus);
            return this;
        }

        /// <summary>
        /// 設定授課時間
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public ICourseBuilder SetTime(Dictionary<uint, List<char>> time)
        {
            _course.SetTime(time);
            return this;
        }

        /// <summary>
        /// 設定withdraw
        /// </summary>
        /// <param name="withdraw"></param>
        /// <returns></returns>
        public ICourseBuilder SetWithdraw(uint withdraw)
        {
            _course.SetWithdraw(withdraw);
            return this;
        }

        /// <summary>
        /// 設定隨班附讀
        /// </summary>
        /// <param name="audit"></param>
        /// <returns></returns>
        public ICourseBuilder SetAudit(string audit)
        {
            _course.SetAudit(audit);
            return this;
        }

        /// <summary>
        /// 取得物件
        /// </summary>
        /// <returns></returns>
        public Course GetCourse()
        {
            return _course;
        }
    }
}
