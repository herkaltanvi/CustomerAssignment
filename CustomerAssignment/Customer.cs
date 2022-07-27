using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAssignment
{
    class Customer
    {
        
       /* protected int phone_no, pincode, customer_id;
        protected string name, address, city, state, email_id;*/

        public int CUSTOMER_ID { get; set; }
        public int PHONE_NO { get; set; }
        public int PINCODE { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string STATE { get; set; }
        public string EMAIL_ID { get; set; }
    }
}
