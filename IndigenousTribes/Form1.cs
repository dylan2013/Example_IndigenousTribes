using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FISCA.Presentation.Controls;

namespace IndigenousTribes
{
    public partial class Form1 : BaseForm
    {
        public Form1()
        {
            InitializeComponent();

            Column1.Items.Add("阿美族");
            Column1.Items.Add("布農族");
            Column1.Items.Add("排灣族");
            Column1.Items.Add("泰雅族");

            Column2.Items.Add("原住民:阿美族");
            Column2.Items.Add("原住民:布農族");
            Column2.Items.Add("原住民:排灣族");
            Column2.Items.Add("原住民:泰雅族");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridViewX1);
            row.Cells[0].Value = "阿美族";
            row.Cells[1].Value = "原住民:阿美族";
            row.Cells[2].Value = "1";
            dataGridViewX1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridViewX1);
            row.Cells[0].Value = "布農族";
            row.Cells[1].Value = "原住民:布農族";
            row.Cells[2].Value = "2";
            dataGridViewX1.Rows.Add(row);

            row = new DataGridViewRow();
            row.CreateCells(dataGridViewX1);
            row.Cells[0].Value = "排灣族";
            row.Cells[1].Value = "原住民:排灣族";
            row.Cells[2].Value = "3";
            dataGridViewX1.Rows.Add(row);
        }
    }
}
