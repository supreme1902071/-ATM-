using System;
using System.Collections.Generic;
using System.Text;

namespace 模拟银行卡ATM机系统
{
    class User
    {
        private string user_name;  // 用户名

        private string user_id;    //  用户id (用于BankCard索引到User)


        public string User_name { get => user_name; set => user_name = value; }
        public string User_id { get => user_id; set => user_id = value; }
    }
}
