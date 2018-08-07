using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    class Login
    {
        private String usuario ;
        private String senha ;
        


        public void setUsuario(String usuario) {
            this.usuario = usuario;
        }

        public void setSenha(String senha) {
            this.senha = senha;
        }

        public Boolean validarUsuario() {
            if (this.usuario == "admin" && this.senha == "123")
            {
                return true;
            }
            return false;
        }
    }
}
