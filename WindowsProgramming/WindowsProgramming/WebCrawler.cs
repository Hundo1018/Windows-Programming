using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace CourseSelectionSystem
{
    /// <summary>
    /// 網頁爬蟲
    /// </summary>
    class WebCrawler
    {
        /// <summary>
        /// 資料清洗方式
        /// </summary>
        private Func<HtmlDocument, List<List<string>>> _dataCleansingMethod;
        /// <summary>
        /// 網址
        /// </summary>
        private string _path;
        /// <summary>
        /// 預設網址 for 第一次作業
        /// </summary>
        private const string DEFAULT_PATH = "https://aps.ntut.edu.tw/course/tw/Subj.jsp?format=-4&year=110&sem=1&code=2433";
        private readonly HtmlWeb _webClient;

        /// <summary>
        /// 爬網頁
        /// </summary>
        /// <param name="path"></param>
        /// <returns>包含課程所有資訊</returns>
        public List<List<string>> Crawl()
        {
            HtmlDocument document = GetData();
            _dataCleansingMethod = CleansingCourseData;//指定清洗方式
            List<List<string>> data = _dataCleansingMethod.Invoke(document);
            return data;
        }

        /// <summary>
        /// 課程資料清洗
        /// </summary>
        private List<List<string>> CleansingCourseData(HtmlDocument document)
        {
            List<List<string>> cleanData = new List<List<string>>();
            const string BODY_AND_TABLE = "//body/table";//砍頭
            HtmlNodeCollection nodeTableRow = document.DocumentNode.SelectSingleNode(BODY_AND_TABLE).ChildNodes;
            const int DELETE_COUNT = 2;//第四個開始是課程，第三個開始是Header
            for (int i = 0; i < DELETE_COUNT; i++)
            {
                nodeTableRow.RemoveAt(0);
            }
            nodeTableRow.RemoveAt(nodeTableRow.Count() - 1);
            cleanData.Add(GetDataFromNodeCollection(nodeTableRow[0].ChildNodes));
            nodeTableRow.RemoveAt(0);
            foreach (var node in nodeTableRow)
            {
                HtmlNodeCollection nodeTableDatas = node.ChildNodes;
                nodeTableDatas.RemoveAt(0);
                cleanData.Add(GetDataFromNodeCollection(nodeTableDatas));
            }
            return cleanData;
        }

        /// <summary>
        /// 從HtmlNodeCollection內取出資料
        /// </summary>
        /// <param name="nodeTableDatas">目標資料</param>
        /// <returns></returns>
        private List<string> GetDataFromNodeCollection(HtmlNodeCollection nodeTableDatas)
        {
            List<string> data = new List<string>();
            for (int i = 0; i < nodeTableDatas.Count; i++)
            {
                data.Add(nodeTableDatas[i].InnerText.Trim());
            }
            return data;
        }

        /// <summary>
        /// 資料載入
        /// </summary>
        /// <param name="path"></param>
        /// <returns>回傳載入目標網頁的HtmlDocument</returns>
        private HtmlDocument GetData()
        {
            return _webClient.Load(_path);
        }

        /// <summary>
        /// 設定網址
        /// </summary>
        /// <param name="path">爬的目標網頁</param>
        public void SetPath(string path)
        {
            _path = path;
        }

        /// <summary>
        /// 設定資料清洗函式
        /// </summary>
        /// <param name="func">資料清洗函式，以HtmlDoc輸入，並以巢狀list模擬Table</param>
        public void SetMethod(Func<HtmlDocument, List<List<string>>> cleansingMethod)
        {
            _dataCleansingMethod = cleansingMethod;
        }

        /// <summary>
        /// 建構網頁爬蟲
        /// </summary>
        /// <param name="path">目標網頁</param>
        public WebCrawler(string path)
        {
            _webClient = new HtmlWeb
            {
                OverrideEncoding = Encoding.Default
            };
            _path = path;
        }

        /// <summary>
        /// 建構網頁爬蟲
        /// </summary>
        public WebCrawler() : this(DEFAULT_PATH)
        {
        }
    }
}
