using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNoteBook
{
    public partial class frmSearch : Form
    {/// <summary>
     /// 公共参数，用于窗体间传参
     /// </summary>
        private string mstrMyText;
        //委托类型声明
        public delegate void searchString(string strSearchText,bool IsUp,bool IsCaseSensitive);
        //事件声明
        public event searchString Search;
        private void btn查询_Click(object sender, EventArgs e)
        {
          
        }
        public string strMyText
        {
            get
            {
                return mstrMyText;
            }
            set
            {
                mstrMyText = value;
                //根据参数变化，要执行的代码 
            }
        }
        public frmSearch()
        {
            InitializeComponent();

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// “取消”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// “查找下一个”响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text != "")
            {
                Search(this.txtSearch.Text, this.rdbUp.Checked, this.ckbCase.Checked);
            }
         
        }
    }
}
