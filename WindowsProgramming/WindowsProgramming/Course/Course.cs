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
        /// <summary>
        /// 課程編碼
        /// </summary>
        private HyperLink _code;
        /// <summary>
        /// 課號
        /// </summary>
        private HyperLink _number;
        /// <summary>
        /// 課程名稱
        /// </summary>
        private HyperLink _name;
        /// <summary>
        /// 階段
        /// </summary>
        private uint _phase;
        /// <summary>
        /// 總學分數
        /// </summary>
        private float _credits;
        /// <summary>
        /// 總時數
        /// </summary>
        private uint _hours;
        /// <summary>
        /// 必修/選修
        /// </summary>
        private HyperLink _requireElective;

        /// <summary>
        /// 授課語言
        /// </summary>
        private string _language;
        /// <summary>
        /// 教學大綱與進度表
        /// </summary>
        private HyperLink _syllabus;
        /// <summary>
        /// 備註
        /// </summary>
        private string _remarks;
        /// <summary>
        /// 實驗實習
        /// </summary>
        private string _pratice;
        /// <summary>
        /// 課程描述
        /// </summary>
        private string _description;
        /// <summary>
        /// 教師
        /// </summary>
        private HyperLink _instructor;
        /// <summary>
        /// 授課時段 0 = 星期日, 1=  星期一, ..., 6 = 星期六
        /// </summary>
        private Dictionary<uint, List<char>> _time;
        /// <summary>
        /// 教室
        /// </summary>
        private HyperLink _classroom;
        /// <summary>
        /// 已選人數
        /// </summary>
        private uint _studentNo;

        /// <summary>
        /// 已撤人數
        /// </summary>
        private uint _withdraw;
        /// <summary>
        /// 隨班附讀
        /// </summary>
        private string _audit;
        
        /// <summary>
        /// 設定教室
        /// </summary>
        /// <param name="classroom"></param>
        public void SetClassroom(HyperLink classroom)
        {
            _classroom = classroom;
        }

        /// <summary>
        /// 設定課程編碼
        /// </summary>
        /// <param name="code"></param>
        public void SetCode(HyperLink code)
        {
            _code = code;
        }

        /// <summary>
        /// 設定學分
        /// </summary>
        /// <param name="credits"></param>
        public void SetCredits(uint credits)
        {
            _credits = credits;
        }

        /// <summary>
        /// 設定課程概述
        /// </summary>
        /// <param name="description"></param>
        public void SetDescription(string description)
        {
            _description = description;
        }

        /// <summary>
        /// 設定時數
        /// </summary>
        /// <param name="hours"></param>
        public void SetHours(uint hours)
        {
            _hours = hours;
        }

        /// <summary>
        /// 設定教師
        /// </summary>
        /// <param name="instructor"></param>
        public void SetInstructor(HyperLink instructor)
        {
            _instructor = instructor;
        }

        /// <summary>
        /// 設定授課語言
        /// </summary>
        /// <param name="language"></param>
        public void SetLanguage(string language)
        {
            _language = language;
        }

        /// <summary>
        /// 設定課程名稱
        /// </summary>
        /// <param name="name"></param>
        public void SetName(HyperLink name)
        {
            _name = name;
        }

        /// <summary>
        /// 設定課號
        /// </summary>
        /// <param name="number"></param>
        public void SetNumber(HyperLink number)
        {
            _number = number;
        }

        /// <summary>
        /// 設定階段
        /// </summary>
        /// <param name="phase"></param>
        public void SetPhase(uint phase)
        {
            _phase = phase;
        }

        /// <summary>
        /// 設定實驗實習
        /// </summary>
        /// <param name="pratice"></param>
        public void SetPratice(string pratice)
        {
            _pratice = pratice;
        }

        /// <summary>
        /// 設定備註
        /// </summary>
        /// <param name="remarks"></param>
        public void SetRemarks(string remarks)
        {
            _remarks = remarks;
        }

        /// <summary>
        /// 設定必修/選修
        /// </summary>
        /// <param name="require"></param>
        public void SetRequireElective(HyperLink require)
        {
            _requireElective = require;
        }

        /// <summary>
        /// 設定選課人數
        /// </summary>
        /// <param name="studentNo"></param>
        public void SetStudentNo(uint studentNo)
        {
            _studentNo = studentNo;
        }

        /// <summary>
        /// 設定課程大綱
        /// </summary>
        /// <param name="syllabus"></param>
        public void SetSyllabus(HyperLink syllabus)
        {
            _syllabus = syllabus;
        }

        /// <summary>
        /// 設定授課時間
        /// </summary>
        /// <param name="time"></param>
        public void SetTime(Dictionary<uint, List<char>> time)
        {
            _time = time;
        }

        /// <summary>
        /// 設定隨班附讀
        /// </summary>
        /// <param name="audit"></param>
        public void SetAudit(string audit)
        {
            _audit = audit;
        }

        /// <summary>
        /// 設定
        /// </summary>
        /// <param name="withdraw"></param>
        public void SetWithdraw(uint withdraw)
        {
            _withdraw = withdraw;
        }
        
    }
}
