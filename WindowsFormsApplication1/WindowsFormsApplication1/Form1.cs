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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnAdd.Click += btnAdd_Click;
            this.grdView.KeyDown += grdView_KeyDown;
        }

        void grdView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 46)
            {
                if (this.grdView.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Do you want to delete this") == System.Windows.Forms.DialogResult.OK)
                    {
                        SetUp selected = (SetUp)this.grdView.SelectedRows[0].DataBoundItem;
                        var db = new QuanLyHHEntities();
                        QuanLyHH deleted = db.QuanLyHHs.Find(selected.id);
                        db.QuanLyHHs.Remove(deleted);
                        db.SaveChanges();
                        this.form1();
                    }
                }
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            (new AddGoods()).ShowDialog();
            this.form1();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            this.form1();
        }

      public void form1()
        {
            var db = new QuanLyHHEntities();
            var view = db.QuanLyHHs.ToArray();
            this.grdView.DataSource = view;
        }
    }
}
