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
    public partial class CourseSelectingForm : Form
    {
        private CourseSelectingFormPresentationModel _model;
        public CourseSelectingForm(CourseSelectingFormPresentationModel model)
        {
            _model = model;
            InitializeComponent();
            _dataGridView1.CellValueChanged += ChangeCellValue;
            _dataGridView1.CurrentCellDirtyStateChanged += ChangeCurrentCellDirtyState;
            //_model.SetCheckEvent(Checked);
            _dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);

        }

        /// <summary>
        /// 這是一個很醜的讀取，需要被拉開、或是從資料觸發
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSelectCourseForm(object sender, EventArgs e)
        {
            /*
            _dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());
            List<string> headers = _model.GetHeaders();
            _dataGridView1.Columns[0].Name = headers.ElementAt(0);
            for (int i = 1; i < _model.GetHeaders().Count; i++)
            {
                _dataGridView1.Columns.Add(headers.ElementAt(i), headers.ElementAt(i));
            }
            foreach (var row in _model.GetTable())
            {
                _dataGridView1.Rows.Add(row);
            }
            */
        }

        /// <summary>
        /// 選取資料出現未認可的變更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ChangeCurrentCellDirtyState(object sender, EventArgs e)
        {
            _dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        /// <summary>
        /// 值改變時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeCellValue(object sender, DataGridViewCellEventArgs e)
        {
            //_model.Checked(e.RowIndex, e.ColumnIndex,((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
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
