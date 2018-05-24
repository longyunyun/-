using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNoteBook
{
    public partial class frmMain : Form
    {/// <summary>
     /// 文件名属性，存储文件名
     /// </summary>
        private string mfileName;
        public string fileName
        {
            get
            {
                return mfileName;
            }
            set
            {
                mfileName = value;
                if (!string.IsNullOrEmpty(value))
                {
                    this.Text = string.Format("{0}-记事本", mfileName);
                }
                else
                {
                    this.Text = "无标题-记事本";

                }
            }
        }
        public frmMain()
        {
            InitializeComponent();
            this.contentStack = new Stack<string>();

           
        }
    



        private void frmMain_Load(object sender, EventArgs e)
        { 

        }

        private void 查看帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// "新建"菜单项响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //设置文本内容为空
            this.txtMainContent.Text = "";
            this.fileName = "";
            this.contentStack = new Stack<string>();//清空栈

        }
        /// <summary>
        /// “打开”菜单项程序响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "打开文本文件";
                openFileDialog.FileName = "*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open);
                    StreamReader streamReader = new StreamReader(fileStream, Encoding.Default);
                    this.txtMainContent.Text = streamReader.ReadToEnd();
                    streamReader.Close();
                    fileStream.Close();
                    //更新存储文件名
                    this.fileName = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.contentStack = new Stack<string>();//清空栈

        }
        /// <summary>
        /// 建立“保存”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //如果文件名不存在直接调用另存为
            if (string.IsNullOrEmpty(this.fileName))
            {
                另存为AToolStripMenuItem_Click(null, null);
            }
            else
            {
                try
                {
                    //文件名存在，直接存盘
                    FileStream fileStream = new FileStream(this.fileName, FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);
                    streamWriter.Close();
                    streamWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        /// <summary>
        /// 建立“另存为”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 另存为AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "保存文本文件";
                saveFileDialog.FileName = "*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                    StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.Default);
                    streamWriter.Write(this.txtMainContent.Text);
                    streamWriter.Close();
                    //更新存储的文件名
                    this.fileName = saveFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// “页面设置”响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        StringReader lineReader = null;

        private void 页面设置UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog1.ShowDialog();
        }
        /// <summary>
        /// 文档打印程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics; //获得绘图对象  
            float linesPerPage = 0; //页面的行号  
            float yPosition = 0;   //绘制字符串的纵向位置  
            int count = 0; //行计数器  
            float leftMargin = 1; //左边距  
            float topMargin = 1; //上边距  
            string line = ""; //行字符串  
            Font printFont = this.txtMainContent.Font; //当前的打印字体  
            SolidBrush myBrush = new SolidBrush(Color.Black);//刷子  
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(g);//每页可打印的行数  
                                                                          //逐行的循环打印一页  
            while (count < linesPerPage && ((line = lineReader.ReadLine()) != null))
            {
                yPosition = topMargin + (count * printFont.GetHeight(g));
                g.DrawString(line, printFont, myBrush, leftMargin, yPosition, new StringFormat());
                count++;
            }

            //如果本页打印完成而line不为空,说明还有没完成的页面,这将触发下一次的打印事件。在下一次的打印中lineReader会  
            //自动读取上次没有打印完的内容，因为lineReader是这个打印方法外的类的成员，它可以记录当前读取的位置  
            if (line != null)
                e.HasMorePages = true;
            else
            {
                e.HasMorePages = false;
                // 重新初始化lineReader对象，不然使用打印预览中的打印按钮打印出来是空白页  
                lineReader = new StringReader(txtMainContent.Text); // textBox是你要打印的文本框的内容  
            }
        }
        /// <summary>
        /// “打印”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                //将打印设置传给打印文档
                this.printDocument1.PrinterSettings = this.pageSetupDialog1.PrinterSettings;
                this.printDocument1.DefaultPageSettings = this.pageSetupDialog1.PageSettings;
                //打印
                this.printDocument1.Print();
            }
        }
        /// <summary>
        /// “退出”菜单项响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Stack<string> contentStack { get; set; }
        /// <summary>
        /// “撤销”菜单项响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 撤销UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.contentStack.Count > 0)
            { this.contentStack.Pop();
              this.txtMainContent.Text = this.contentStack.Pop();
            }

        }
        /// <summary>
        /// txtMainContent的TextChanged事件响应程序，将改变的内容压入栈
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMainContent_TextChanged(object sender, EventArgs e)
        {
            this.contentStack.Push(this.txtMainContent.Text);
            this.撤销UToolStripMenuItem.Enabled = (this.contentStack.Count > 0);
            //文本改变要进行检查
            CheckText();
        }
      /// <summary>
        /// 键盘按键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMainContent_KeyDown(object sender, KeyEventArgs e)
        {
            CheckSelection();

        }
        /// <summary> 
        /// 鼠标抬起事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TxtMainContent_MouseUp(object sender, MouseEventArgs e)
        {
            CheckSelection();


        }
        /// <summary>
        /// 检查文本框中信息选择状态，决定菜单可用项
        /// </summary>
        public void CheckSelection()
        {
            if (Clipboard.ContainsText())
            {
                this.粘贴PToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.粘贴PToolStripMenuItem.Enabled = false; 
            }
            if (this.txtMainContent.SelectedText!="")
            {

                this.剪切TToolStripMenuItem.Enabled = true;
                this.复制CToolStripMenuItem.Enabled = true;
                this.删除LToolStripMenuItem.Enabled = true;
            }
            else
            {   //如果没有选择信息
                this.剪切TToolStripMenuItem.Enabled = false;
                this.复制CToolStripMenuItem.Enabled = false;
                this.删除LToolStripMenuItem.Enabled = false;

            }
            if (this.txtMainContent.Text != "")
            {
                this.查找FToolStripMenuItem .Enabled= true;

                this.查找下一个NToolStripMenuItem.Enabled = true;
                this.替换RToolStripMenuItem.Enabled = true;
                this.全选AToolStripMenuItem.Enabled = true;
                this.转到GToolStripMenuItem.Enabled = true;

            }
            else
            {
                this.查找FToolStripMenuItem.Enabled = false;

                this.查找下一个NToolStripMenuItem.Enabled = false;
                this.替换RToolStripMenuItem.Enabled = false;
                this.转到GToolStripMenuItem.Enabled = false;
                this.全选AToolStripMenuItem.Enabled = false;

            }
            //
            //strLeft为光标前字符串
            string strLeft = this.txtMainContent.Text.Substring(0, this.txtMainContent.SelectionStart);
            strLeft = "\r\n" + strLeft;
            int lastIndex = strLeft.LastIndexOf('\n');
            int intCol = this.txtMainContent.SelectionStart - lastIndex + 1;
            var arrayString = strLeft.Split('\n');
            int intRow = arrayString.Length - 1;
            this.toolStripStatusLabel1_Message.Text = string.Format($"第{intRow}行，第{intCol}列");

                
        }

      
        /// <summary>
        /// “剪切”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 剪切TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtMainContent.SelectedText != "")
            {
                Clipboard.SetText(this.txtMainContent.SelectedText);
                this.txtMainContent.SelectedText = "";
                CheckSelection();
            }
        }
        /// <summary>
        /// “复制”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 复制CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtMainContent.SelectedText != "")
            {
                Clipboard.SetText(this.txtMainContent.SelectedText);
                CheckSelection();
            }
        }
        /// <summary>
        /// “粘贴”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 粘贴PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strInsertText = Clipboard.GetText();
            this.txtMainContent.SelectedText = strInsertText;
        }
        /// <summary>
        /// “删除”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtMainContent.SelectedText = "";
        }

        private void 查找FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsearch  = new frmSearch();
            frmsearch.Search += frm_Search;
            frmsearch.Show();

        } 
        /// <summary>
        /// 查询窗口 防止重复开窗口
        /// </summary>
        private static frmSearch frmsearch { get; set; }
       
      public struct SearchContent
        {
            public string text;
            public bool IsUp;
            public bool IsCaseSensitive;
            public SearchContent(string strSearchText,bool mIsUp,bool mIsCaseSensitive)
            {
                text = strSearchText;
                IsUp = mIsUp;
                IsCaseSensitive = mIsCaseSensitive;
            }
        }
        public SearchContent searchContent { get; set; }
        /// <summary>
        /// 当frmSearch激发查询时的响应程序
        /// </summary>
        /// <param name="strSearchText"></param>
        /// <param name="mIsUp"></param>
        /// <param name="mIsCaseSensitive"></param>
        private void frm_Search(string strSearchText, bool IsUp, bool IsCaseSensitive)
        {
            //现将查询条件存储起来
            this.searchContent = new SearchContent(strSearchText, IsUp, IsRestrictedWindow);
                searchNext();
        }
        private void searchNext()
        {
            int intAns = -1;
            int indexNow;
            if (this.searchContent.IsUp)
            {
                //向上搜索
                indexNow = this.txtMainContent.SelectionStart;
                string strSearchString = this.txtMainContent.Text.Substring(0, indexNow);
                //大小写是否敏感
                if (this.searchContent.IsCaseSensitive)
                {
                    intAns = strSearchString.LastIndexOf(this.searchContent.text, StringComparison.CurrentCulture);
                }
                else
                {
                    intAns = strSearchString.LastIndexOf(this.searchContent.text, StringComparison.CurrentCultureIgnoreCase);

                }
            }
            else
            {
                //向下搜索
                indexNow = this.txtMainContent.SelectionStart+this.txtMainContent.SelectionLength;
                string strSearchString = this.txtMainContent.Text.Substring(indexNow);
                //大小写是否敏感
                if (this.searchContent.IsCaseSensitive)
                {
                    intAns = strSearchString.IndexOf(this.searchContent.text, StringComparison.CurrentCulture);
                }
                else
                {
                    intAns = strSearchString.IndexOf(this.searchContent.text, StringComparison.CurrentCultureIgnoreCase);

                }
            }
            if (intAns<0) 
            {
                MessageBox.Show($"找不到{searchContent.text}");
            }
            else
            {
                this.Activate();
                if (!searchContent.IsUp)
                {
                    intAns += indexNow;
                }
                this.txtMainContent.SelectionStart = intAns;
                this.txtMainContent.SelectionLength = this.searchContent.text.Length;
            }
        }
        private void CheckText()
        {
            this.查找FToolStripMenuItem.Enabled = (this.txtMainContent.Text != "");
            this.查找下一个NToolStripMenuItem.Enabled = (this.txtMainContent.Text != "");
              

        }
        private void 替换RToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// “查找下一个”
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 查找下一个NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.searchContent.text))
            {
                searchNext();
            }
            else
            {
                查找FToolStripMenuItem_Click(null, null);
            }
            
        }
        /// <summary>
        /// “转到”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 转到GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoTo frm = new frmGoTo();
            if (frm.ShowDialog()==DialogResult.OK)
            {
                int intLine;
                if (int.TryParse(frm.Tag.ToString(),out intLine))
                {
                    if (intLine>0)
                    {
                        int intPostion = 0;
                        if (intLine>1)
                        {
                            for (int i = 0; i < intLine; i++)
                            {
                                int intNext = this.txtMainContent.Text.IndexOf('\n', intPostion);
                                if (intNext >= 0)
                                {
                                    intPostion = intNext + 1;
                                }
                                else
                                    break;
                            }
                        }
                        if (intPostion>=0)
                        {
                            this.txtMainContent.SelectionStart = intPostion;
                            this.txtMainContent.SelectionLength = 0;
                                this.txtMainContent.ScrollToCaret();
                            CheckSelection();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// “全选”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtMainContent.SelectionStart = 0;
            this.txtMainContent.SelectionLength = this.txtMainContent.Text.Length;
            CheckSelection();

        }

        private void 时间日期DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtMainContent.SelectionLength = 0;
            this.txtMainContent.SelectedText = System.DateTime.Now.ToString();
            this.txtMainContent.SelectionLength = 0;
        }
        /// <summary>
        /// “字体”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 字体FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog()==DialogResult.OK)
            {
                this.txtMainContent.Font = this.fontDialog1.Font;
            }
        }
        /// <summary>
        /// “自动换行”响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 自动换行WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtMainContent.WordWrap == false)
            {
                //自动换行状态
                this.转到GToolStripMenuItem.Enabled = false;
                this.状态栏SToolStripMenuItem.Checked = false;
                this.状态栏SToolStripMenuItem.Enabled = false;
                //自动换行
                this.自动换行WToolStripMenuItem.Checked = true;
                this.txtMainContent.WordWrap = true;
                //输出区只包括纵向滚动条
                this.txtMainContent.ScrollBars = ScrollBars.Vertical;

            }
            else
            {
                //不自动换行状态
                this.状态栏SToolStripMenuItem.Enabled = true;
                this.转到GToolStripMenuItem.Enabled = true;
                this.自动换行WToolStripMenuItem.Checked = false;
                this.txtMainContent.WordWrap = false;
                this.txtMainContent.ScrollBars = ScrollBars.Both;

            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// “状态栏”菜单响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 状态栏SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.状态栏SToolStripMenuItem.Checked = !this.状态栏SToolStripMenuItem.Checked;
            this.statusStrip1.Visible = this.状态栏SToolStripMenuItem.Checked;

        }
        /// <summary>
        /// “关于记事本”响应程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关于记事本AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmAbout()).ShowDialog();

        }
    }
}
