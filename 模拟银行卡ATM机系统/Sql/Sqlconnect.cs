using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模拟银行卡ATM机系统
{
    class Sqlconnect
    {
        private string connStr = "Data Source=.;Integrated Security=true;Initial Catalog=ATM;User Id=sa;Password=123456";
        private SqlConnection conn = null;
        private SqlDataReader dr = null;

        private SqlCommand initsql(string sql)
        {
            conn = new SqlConnection(connStr); //打开数据库连接
            conn.Open();
            Random r = new Random();

            return new SqlCommand(sql, conn);
        }

        public BankCard init(string card_id)
        {
            BankCard bankCard = null; 
            try
            {
                string sql = "SELECT * from Card where Card_id = ";
                sql += card_id;
                SqlCommand cmd = initsql(sql);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    bankCard = new BankCard((string)dr["Card_id"],(string)dr["Card_password"],(Decimal)dr["Card_money"], (Decimal)dr["One_day_fetchmoney"], DateTime.ParseExact((string)dr["Last_time"], "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture), (string)dr["User_id"]);
                    //Console.WriteLine(bankCard.Last_time);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("查询失败！" + ex.Message);
            }
            finally
            {
                if (conn != null) conn.Close();
            }

            return bankCard;
        }
            
        // 判断登录是否成功 传入卡号和密码，判断是否存在
            public bool login(string card_id, string passwd)
            {
                try
                {
                    string sql = "SELECT Card_password from Card where Card_id = ";
                    sql += card_id;
                    SqlCommand cmd = initsql(sql);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if ((string)dr[0] == passwd)
                        {
                            if (conn != null) conn.Close();
                            return true;
                        }
                        break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("失败！" + ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                    dr.Close();
                }
                return false;
            }

            //判断是否有该卡号 传入卡号，判断是否存在该用户
            public bool Isexsit(string card_id)
            {
                try
                {
                    string sql = "SELECT * from Card where Card_id = ";
                    sql += card_id;
                    SqlCommand cmd = initsql(sql);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        if (conn != null) conn.Close();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("失败！" + ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                    dr.Close();
                }
                return false;
            }

            //修改当前银行卡金额,传入卡号，修改金额，和操作,opt=1就存款money元,opt=2就取出money元
            public bool updatamoney(string card_id, decimal money, int opt)
            {
                try
                {
                    string sql = "SELECT Card_money from Card where Card_id = ";
                    sql += card_id;
                    SqlCommand cmd = initsql(sql);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Decimal nowmoney = Convert.ToDecimal(dr[0].ToString());
                        if (opt == 1) nowmoney += money;
                        else nowmoney -= money;

                        string sql1 = @"update Card set Card_money = @money where card_id = @card_id";
                        SqlParameter para1 = new SqlParameter() { ParameterName = "@money", Value = nowmoney };
                        SqlParameter para2 = new SqlParameter() { ParameterName = "@card_id", Value = card_id };
                        SqlConnection conn1 = new SqlConnection(connStr); //打开数据库连接
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                        cmd1.Parameters.Add(para1);
                        cmd1.Parameters.Add(para2);
                        cmd1.ExecuteReader();
                       
                        if (conn1 != null) conn1.Close();

                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("失败！" + ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                    dr.Close();
                }
                return false;
            }
                
            //取款额度
            public bool updat_one_day_fetchmoney(string card_id, decimal one_day_fetchmoney)
            {
                try
                {
                    string sql = "SELECT One_day_fetchmoney from Card where Card_id = ";
                    sql += card_id;
                    SqlCommand cmd = initsql(sql);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string sql1 = @"update Card set One_day_fetchmoney = @One_day_fetchmoney where card_id = @card_id";
                        SqlParameter para1 = new SqlParameter() { ParameterName = "@one_day_fetchmoney", Value = one_day_fetchmoney };
                        SqlParameter para2 = new SqlParameter() { ParameterName = "@card_id", Value = card_id };
                        SqlConnection conn1 = new SqlConnection(connStr); //打开数据库连接
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                        cmd1.Parameters.Add(para1);
                        cmd1.Parameters.Add(para2);
                        cmd1.ExecuteReader();
                        
                        if (conn1 != null) conn1.Close();

                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("查询失败！" + ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                }

                return false;
            }

        //更新上次取钱时间，传入卡号，将数据库中last_time修改成last_time
        public bool updata_last_time(string card_id, string last_time)
            {
                try
                {
                    string sql = "SELECT Card_money from Card where Card_id = ";
                    sql += card_id;
                    SqlCommand cmd = initsql(sql);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                       // DateTime nowtime = Convert.ToDateTime(dr[0].ToString());

                        string sql1 = @"update Card set Last_time = @nowtime where card_id = @card_id";
                        SqlParameter para1 = new SqlParameter() { ParameterName = "@nowtime", Value = last_time};
                        SqlParameter para2 = new SqlParameter() { ParameterName = "@card_id", Value = card_id };
                        SqlConnection conn1 = new SqlConnection(connStr); //打开数据库连接
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                        cmd1.Parameters.Add(para1);
                        cmd1.Parameters.Add(para2);
                        cmd1.ExecuteReader();

                        if (conn1 != null) conn1.Close();

                        return true;
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("失败！" + ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                    dr.Close();
                }

                return false;
            }

            //更新当前银行卡密码，传入卡号，新密码，将数据库中的passwd修改成newpassed
            public bool modifypasswd(string card_id, string newpasswd)
            {
                try
                {
                    string sql = "SELECT Card_money from Card where Card_id = ";
                    sql += card_id;
                    SqlCommand cmd = initsql(sql);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        string sql1 = @"update Card set Card_password = @newpasswd where card_id = @card_id";
                        SqlParameter para1 = new SqlParameter() { ParameterName = "@newpasswd", Value = newpasswd };
                        SqlParameter para2 = new SqlParameter() { ParameterName = "@card_id", Value = card_id };

                        SqlConnection conn1 = new SqlConnection(connStr); //打开数据库连接
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand(sql1, conn1);
                        cmd1.Parameters.Add(para1);
                        cmd1.Parameters.Add(para2);
                        cmd1.ExecuteReader();

                        if (conn1 != null) conn1.Close();

                        return true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("失败！" + ex.Message);
                }
                finally
                {
                    if (conn != null) conn.Close();
                    dr.Close();
                }

                return false;
            }
        
    }

}
