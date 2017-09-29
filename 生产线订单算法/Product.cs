using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace 生产线订单算法
{
    class Product
    {
        private string mo;
        private string startDate;
        private string endDate;
        private int producePower;

        public Product()
        {
        }

        public Product(string mo, string startDate, int producePower)
        {
            this.mo = mo;
            this.startDate = startDate;
            this.producePower = producePower;
        }

        public Product(string mo, string startDate, string endDate, int producePower)
        {
            this.mo = mo;
            this.startDate = startDate;
            this.endDate = endDate;
            this.producePower = producePower;
        }

        public string Mo
        {
            get { return mo; }
            set { mo = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int ProducePower
        {
            get { return producePower; }
            set { producePower = value; }
        }
    }
}
