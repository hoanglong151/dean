using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddGoods : Form
    {
        public AddGoods()
        {
            InitializeComponent();
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            string code = this.txtCode.Text;
            string name = this.txtName.Text;
            DateTime date = this.dtpDate.Value;
            int number = Decimal.ToInt32(this.nudNumber.Value);
            string status = this.cbStatus.Text;

            var add = new QuanLyHH();
            add.date = date;
            add.code = code;
            add.name = name;
            add.number = number;
            add.status = status;
            var db = new QuanLyHHEntities();
            db.QuanLyHHs.Add(add);
            db.SaveChanges();
            this.Close();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
