using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNV_RapChieuPhim.Singleton_Pattern
{
    class DataLogin
    {
        static DataLogin lg;
        private string username, password;
        public static DataLogin getInstance()
        {
            if(lg == null)
            {
                lg = new DataLogin();
            }
            return lg;

        }
        public DataLogin()
        {

        }
        public string getUsername()
        {
            return this.username;
        }
        public string getPassword()
        {
            return this.password;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
