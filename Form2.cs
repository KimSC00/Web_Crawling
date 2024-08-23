using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        DataTable dt = new DataTable();

        public Form2()
        {
            InitializeComponent();

            dt.Columns.Add("번호");
            dt.Columns.Add("분류");
            dt.Columns.Add("제목");
            dt.Columns.Add("글쓴이");
            dt.Columns.Add("작성일");
            dt.Columns.Add("조회수");
        }
       

        private void tbStart_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbFinish_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int start = Int32.Parse(tbStart.Text);
            int end = Int32.Parse(tbFinish.Text);

            
            for (int i = start; i <= end; i++)
            {
                string url = "https://daegu.ac.kr/article/DG163/list?pageIndex=" + i + "&";
                HtmlWeb web = new HtmlWeb();
                web.OverrideEncoding = Encoding.UTF8;
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                ////*[@id="sub_contents"]/div/table/tbody[1]/tr[3]/td[1]

                HtmlNodeCollection Number = doc.DocumentNode.SelectNodes("//*[@class='board_tbl_list']/tbody/tr/td[1]");
                HtmlNodeCollection Configuration = doc.DocumentNode.SelectNodes("//*[@class='board_tbl_list']/tbody/tr/td[2]");
                HtmlNodeCollection Name = doc.DocumentNode.SelectNodes("//*[@class='board_tbl_list']/tbody/tr/td[3]");
                HtmlNodeCollection Writer = doc.DocumentNode.SelectNodes("//*[@class='board_tbl_list']/tbody/tr/td[4]");
                HtmlNodeCollection Date = doc.DocumentNode.SelectNodes("//*[@class='board_tbl_list']/tbody/tr/td[5]");
                HtmlNodeCollection SearchNumber = doc.DocumentNode.SelectNodes("//*[@class='board_tbl_list']/tbody/tr/td[6]");



                for (int k = 2; k < Number.Count; k++)
                {
                    string name = Name[k].InnerText.Replace(" ", "");
                    

                   // dt.Rows.Add(Number[k].InnerText);
                    dt.Rows.Add(Number[k].InnerText, Configuration[k].InnerText, name, Writer[k].InnerText, Date[k].InnerText, SearchNumber[k].InnerText);
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
