using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    /// <summary>
    /// 課程描述
    /// </summary>
    class CourseDescription
    {
        /// <summary>
        /// 課程編碼
        /// </summary>
        private uint _code;
        /// <summary>
        /// 課號
        /// </summary>
        private uint _number;
        /// <summary>
        /// 課程名稱
        /// </summary>
        private uint _name;
        /// <summary>
        /// 階段
        /// </summary>
        private uint _phase;
        /// <summary>
        /// 總學分數
        /// </summary>
        private uint _credits;
        /// <summary>
        /// 總時數
        /// </summary>
        private float _hours;
        /// <summary>
        /// 必修/選修
        /// </summary>
        private string _requireElective;
    }
}
