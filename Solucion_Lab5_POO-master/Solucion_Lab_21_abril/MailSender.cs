using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Solucion_Lab_21_abril
{
    public class MailSender
    {
        public void OnRegistered(object source, RegisterEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}: \n Gracias por registrarte, {e.Username}!\n Por favor, para poder verificar tu correo, has click en: {e.VerificationLink}\n");
            Thread.Sleep(2000);
            OnSended();
            Thread.Sleep(2000);
        }

        public void OnPasswordChanged(object source, ChangePasswordEventArgs e)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"\nCorreo enviado a {e.Email}:  \n {e.Username}, te notificamos que la contrasena de tu cuenta PlusCorp ha sido cambiada. \n");
            Thread.Sleep(2000);
        }




        // Paso 1: Creamos el delegate para el evento del registro
        public delegate void MailsendEventHandler(object source, EventArgs Empty);
        // Paso 2: Creamos el evento que se engatilla cuando el usuario se registra
        public event MailsendEventHandler Sended;
        // Paso 3: Publicamos el evento. Notar que cuando se quiere engatillar el evento, se llama OnRegistered(). 
        // Por definicion, debe ser protected virtual. Los parametros que recibe son los necesarios para crear una instancia
        // de la clase  RegisterEventArgs
        protected virtual void OnSended()
        {
            // Verifica si hay alguien suscrito al evento
            if (Sended != null)
            {
                // Engatilla el evento
                Sended(this, new MailsendEventArgs() {    });
            }
        }

    }
}
