using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class SetUp
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string number { get; set; }
        public string status { get; set; }
        public SetUp(QuanLyHH view1)
        {
            this.id = view1.id;
            this.code = view1.code;
            this.name = view1.name;
            this.date = String.Format("Ngay {0}/{1}",
                view1.date.Day, view1.date.Month);
            this.number = String.Format("{0:n0}", view1.number);
            this.status = view1.status;
        }
    }
}
