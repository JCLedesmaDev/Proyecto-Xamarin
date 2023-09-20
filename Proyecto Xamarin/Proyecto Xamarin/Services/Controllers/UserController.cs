using Microsoft.AspNetCore.Mvc;
using Proyecto_Xamarin.BaseDatos;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;


namespace Proyecto_Xamarin.Controllers
{

    public class UserController
    {
        private IndexSP indexSP = new IndexSP();

        public ObjectResult Login(Models.UserModel usuario)
        {
            ObjectResult data = new ObjectResult(null);

            try
            {
                string email = "juanchi@gmail.com";
                //var response = indexSP.User.GetUser(usuario);
                if (usuario._Email == email)
                {
                    data.Value = usuario;
                }
                else
                {
                    data.StatusCode = 400;
                    data.Value = "Ocurrio un error al querer iniciar sesion";
                }


                //if (response.Value == null )
                if (data.Value == null )
                {
                    throw new Exception("Usuario inexistente. Intentelo nuevamente");
                }

                //data.Value = response.Value;
                return data;
            } 
            catch (Exception e)
            {
                data.StatusCode = 400;
                data.Value = e.Message;
                return data;
            }
        }


        public ObjectResult Registrarse(Models.UserModel usuario)
        {
            ObjectResult data = new ObjectResult(null);

            try
            {
                var fndUser = indexSP.User.GetUser(usuario);

                if (fndUser.Value != null)
                {
                    throw new Exception("Usuario existente. Intentelo nuevamente");
                }

                var result = indexSP.User.CreateUser(usuario);

                data.Value = result;
                return data;
            }
            catch(Exception e)
            {
                data.StatusCode = 400;
                data.Value = e.Message;
                return data;
            }
        }
    }
}