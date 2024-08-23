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
    public partial class Form3 : Form
    {
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
            dt.Columns.Add("번호");
            dt.Columns.Add("제목");
            dt.Columns.Add("작성자");
            dt.Columns.Add("작성일");
            dt.Columns.Add("조회수");
        }

        

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int start = Int32.Parse(tbStart.Text);
            int end = Int32.Parse(tbFinish.Text);

            for (int i = start; i <= end; i++)
            {
                string url = "https://ce.daegu.ac.kr/hakgwa_home/ce/sub.php?page=" + i + "&menu=page&menu_id=1023&search_field=&search_key=&search_cate=";
                HtmlWeb web = new HtmlWeb();
                web.OverrideEncoding = Encoding.UTF8;
                HtmlAgilityPack.HtmlDocument doc = web.Load(url);

                

                HtmlNodeCollection Number = doc.DocumentNode.SelectNodes("//*[@class='board_list']/tbody/tr/td[1]");
                HtmlNodeCollection Name = doc.DocumentNode.SelectNodes("//*[@class='board_list']/tbody/tr/td[2]/a");
                HtmlNodeCollection Writer = doc.DocumentNode.SelectNodes("//*[@class='board_list']/tbody/tr/td[3]");
                HtmlNodeCollection Date = doc.DocumentNode.SelectNodes("//*[@class='board_list']/tbody/tr/td[4]");
                HtmlNodeCollection SearchNumber = doc.DocumentNode.SelectNodes("//*[@class='board_list']/tbody/tr/td[5]");

                for (int k = 0; k < Number.Count; k++)
                {
                    
                    dt.Rows.Add(Number[k].InnerText, Name[k].InnerText, Writer[k].InnerText, Date[k].InnerText, SearchNumber[k].InnerText);
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        
    }
}
