using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankTrans
{

    public class Account
    {
        public string user_name { get; set; }
        public string pass { get; set; }
        public int pin { get; set; }
        public long ballance { get; set; }

        public Account() { }

        public Account(string user, string pass, int pin, long ball)
        {
            this.user_name = user;
            this.pass = pass;
            this.pin = pin;
            this.ballance = ball;
        }
    }


}
