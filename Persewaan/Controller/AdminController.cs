using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persewaan.Controller
{
    class AdminController
    {
        private View.Login vLogin;
        private Model.AdminModel mAdmin;
        public static string id, nama, pass;

        public AdminController(View.Login vLogin)
        {
            this.vLogin = vLogin;
            mAdmin = new Model.AdminModel();
        }

        public bool LoginAdmin()
        {
            bool hasil = mAdmin.Login(vLogin.txtNama.Text, vLogin.pwdbox.Password);
            return hasil;
        }

    }
}
