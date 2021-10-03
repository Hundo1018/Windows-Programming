using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSelectionSystem
{
    /// <summary>
    /// 超連結
    /// </summary>
    class HyperLink
    {
        private object _text;
        private string _link;

        /// <summary>
        /// 取得超連結的表面文字
        /// </summary>
        /// <returns>文字敘述</returns>
        public object GetText()
        {
            return _text;
        }

        /// <summary>
        /// 取得超連結的連結
        /// </summary>
        /// <returns>連結</returns>
        public string GetLink()
        {
            return _link;
        }

        /// <summary>
        /// 設定文字
        /// </summary>
        /// <param name="text">要顯示的文字</param>
        public void SetText(object text)
        {
            _text = text;
        }

        /// <summary>
        /// 設定超連結的連結
        /// </summary>
        /// <param name="link">連結</param>
        public void SetLink(string link)
        {
            _link = link;
        }

        public HyperLink(object text, string link)
        {
            _link = link;
            _text = text;
        }

        public HyperLink(object text)
        {
            _text = text;
        }
        public HyperLink()
        {

        }
    }
}
