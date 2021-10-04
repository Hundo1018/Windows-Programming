using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSelectionSystem
{
    public partial class SelectCourseForm : Form
    {
        readonly Model _model;
        public SelectCourseForm(Model model)
        {
            _model = model;
            InitializeComponent();
            _dataGridView1.CellValueChanged += ChangeCellValue;
            _model.SetCheckEvent(Checked);
        }

        /// <summary>
        /// 這是一個很醜的讀取，需要被拉開、或是從資料觸發
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSelectCourseForm(object sender, EventArgs e)
        {
            _dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());
            _dataGridView1.Columns[0].Name = _model.GetHeaders()[0];
            for (int i = 1; i < _model.GetHeaders().Count; i++)
            {
                string header = _model.GetHeaders()[i];
                _dataGridView1.Columns.Add(header, header);
            }
            foreach (var row in _model.GetTable())
            {
                _dataGridView1.Rows.Add(row);
            }
        }

        /// <summary>
        /// 值改變時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeCellValue(object sender, DataGridViewCellEventArgs e)
        {
            _model.Checked(e.RowIndex, e.ColumnIndex);
        }

        /// <summary>
        /// 至少有一個被選擇
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="isChecked"></param>
        private void Checked(object sender, Course.CheckEventArguments eventArguments)
        {
            _buttonSend.Enabled = eventArguments.Checked;
        }
    }
}
