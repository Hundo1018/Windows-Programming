
namespace CourseSelectionSystem
{
    partial class SelectCourseForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView1
            // 
            this._dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView1.Location = new System.Drawing.Point(12, 12);
            this._dataGridView1.Name = "_dataGridView1";
            this._dataGridView1.RowTemplate.Height = 24;
            this._dataGridView1.Size = new System.Drawing.Size(776, 248);
            this._dataGridView1.TabIndex = 0;
            // 
            // SelectCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._dataGridView1);
            this.Name = "SelectCourseForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SelectCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView _dataGridView1;
    }
}

