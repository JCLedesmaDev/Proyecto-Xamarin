using Proyecto_Xamarin.Models.Common;
using System.Collections.Generic;

namespace Proyecto_Xamarin.Models
{
    public class UserModel : IdComun
    {
        //ATRIBUTOS
        private string nombreCompleto { get; set; }
        private string email { get; set; }
        private string password { get; set; }

        //metodos get y set
        public string _NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
        public string _Email
        {
            get { return email; }
            set { email = value; }
        }
        public string _Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}