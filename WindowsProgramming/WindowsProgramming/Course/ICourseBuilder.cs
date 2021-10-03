using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem.Course
{
    /// <summary>
    /// CourseBuild介面
    /// </summary>
    interface ICourseBuilder
    {
        /// <summary>
        /// 重設所有資訊
        /// </summary>
        void Reset();

        /// <summary>
        /// 設定課程編碼
        /// </summary>
        /// <param name="code">課程編碼</param>
        /// <return></return>
        ICourseBuilder SetCode(HyperLink code);

        /// <summary>
        /// 設定課號
        /// </summary>
        /// <param name="number">課號</param>
        ICourseBuilder SetNumber(HyperLink number);

        /// <summary>
        /// 設定課程名稱
        /// </summary>
        /// <param name="name">課程名稱</param>
        ICourseBuilder SetName(HyperLink name);

        /// <summary>
        /// 設定階段
        /// </summary>
        /// <param name="phase">階段</param>
        ICourseBuilder SetPhase(uint phase);

        /// <summary>
        /// 設定學分
        /// </summary>
        /// <param name="credits">學分</param>
        ICourseBuilder SetCredits(uint credits);

        /// <summary>
        /// 設定總時數
        /// </summary>
        /// <param name="hours">總時數</param>
        ICourseBuilder SetHours(uint hours);

        /// <summary>
        /// 設定必修/選修 符號
        /// </summary>
        /// <param name="require">必/選修符號</param>
        ICourseBuilder SetRequireElective(HyperLink require);

        /// <summary>
        /// 設定授課語言
        /// </summary>
        /// <param name="language">授課語言</param>
        ICourseBuilder SetLanguage(string language);

        /// <summary>
        /// 設定課程大綱與進度表
        /// </summary>
        /// <param name="syllabus">課程大綱與進度表</param>
        ICourseBuilder SetSyllabus(HyperLink syllabus);

        /// <summary>
        /// 設定備註
        /// </summary>
        /// <param name="remarks">備註</param>
        ICourseBuilder SetRemarks(string remarks);

        /// <summary>
        /// 設定實驗實習
        /// </summary>
        /// <param name="pratice">實驗實習</param>
        ICourseBuilder SetPratice(string pratice);

        /// <summary>
        /// 設定課程描述
        /// </summary>
        /// <param name="description"></param>
        ICourseBuilder SetDescription(string description);

        /// <summary>
        /// 設定教授
        /// </summary>
        /// <param name="instructor"></param>
        ICourseBuilder SetInstructor(HyperLink instructor);

        /// <summary>
        /// 設定授課時間
        /// </summary>
        /// <param name="time"></param>
        ICourseBuilder SetTime(Dictionary<uint, List<char>> time);

        /// <summary>
        /// 設定教室
        /// </summary>
        /// <param name="classroom">教室</param>
        ICourseBuilder SetClassroom(HyperLink classroom);

        /// <summary>
        /// 設定修習人數
        /// </summary>
        /// <param name="studentNo">人數</param>
        ICourseBuilder SetStudentNo(uint studentNo);

        /// <summary>
        /// 設定撤選人數
        /// </summary>
        /// <param name="withdraw">撤選人數</param>
        ICourseBuilder SetWithdraw(uint withdraw);

        /// <summary>
        /// 設定隨班附讀
        /// </summary>
        /// <param name="audit"></param>
        /// <returns></returns>
        ICourseBuilder SetAudit(string audit);

        /// <summary>
        /// 取得課程物件
        /// </summary>
        Course GetCourse();
    }
}
