using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
     class User
    {
        // Paso 1: Creamos el delegate para el evento del registro
        public delegate void EmailVerifiedEventHandler(object source, MailverifiedEventArgs Empty);
        // Paso 2: Creamos el evento que se engatilla cuando el usuario se registra
        public event EmailVerifiedEventHandler Verified;
        // Paso 3: Publicamos el evento. Notar que cuando se quiere engatillar el evento, se llama OnRegistered(). 
        // Por definicion, debe ser protected virtual. Los parametros que recibe son los necesarios para crear una instancia
        // de la clase  RegisterEventArgs
        protected virtual void OnVerified()
        {
            if (Verified != null)
            {
                // Engatilla el evento
                Verified(this, new MailverifiedEventArgs() { });
            }



        }

        public void OnEmailSent(object source, EventArgs e)
        {
            Console.WriteLine("Quiere verificar su correo? (Y/N)");
            string resp = Console.ReadLine();
            if (resp == "Y" || resp == "y")
                OnVerified();
            else
            {               
            }

            }








    }
}
