using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DAL
{
    public class User
    {

        public int Login(string user, string password) {


            //dummy para prueba

            string _adm_user = "admin";
            string _adm_password = "admin";

            string _seller_user = "seller";
            string _seller_password = "seller";

            string _stock_user = "stock";
            string _stock_password = "stock";

            string _manager = "manager";
            string _manager_password = "manager";


            if (user.Equals(_adm_user) && password.Equals(_adm_password)) {
                return 1;
            }

            if (user.Equals(_seller_user) && password.Equals(_seller_password))
            {
                return 2;
            }

            if (user.Equals(_stock_user) && password.Equals(_stock_password))
            {
                return 3;
            }
            if (user.Equals(_manager) && password.Equals(_manager_password)) 
            {
                return 4;
            }



            return -1;
        
        }


    }
}
