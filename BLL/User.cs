﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class User 
    {
        private string _userName;
        private string _password;

        public string Password
        {
            //get { return _password; }
            set { _password = value; }
        }


        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public int Login(string user, string password) {

            //si existe en la bbdd -->  true
            //si no existe en la bbdd --> false

            //
            DAL.User databuff = new DAL.User();

            // si puedo traer un objeto...
            // preguntar por clase? si es sysadm --> una pantalla 
            //                      si es seller ---> otra pantalla
            //                      etc

            return databuff.Login(user, password);

                
      
        
        }

    }
}