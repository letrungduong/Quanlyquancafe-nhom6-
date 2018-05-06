using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyQuanCafe
{
    public partial class dstable : Form
    {
        public dstable()
        {
            InitializeComponent();

            LoadTable();
            LoadCategory();
        }




        #region Method
        void LoadCategory()
        {



        }
        void LoaddrinksListByCategoryID(int id)
        {

        }
        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightPink;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {




        }

        #endregion
        #region Events
        private void btn_Click(object sender, EventArgs e)
        {

            int tableID = ((sender as Button).Tag as Table).ID;

            ShowBill(tableID);
        }
        private void flpTable_Paint(object sender, PaintEventArgs e)
        {

        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bntDiscount_Click(object sender, EventArgs e)
        {

        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoaddrinksListByCategoryID(id);
        }
        private void btnAddFoot_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           fTableManager f = new fTableManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }




    }

}
