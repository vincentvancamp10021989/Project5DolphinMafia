using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security;
using System.Runtime.InteropServices;
using WebApplication1.Klasses.Login;

namespace WebApplication1.Klasses.Algemeen
{
    public class Mail
    {
        private SecureString passwordEmailAdmin;
        public unsafe readonly string PasswordEmailAdmin
        {
            [SecurityCritical]
            set
            {
                if (value == null)
                    value = string.Empty;
                using (SecureString securityString = new SecureString())
                {
                    var length = value.Length;
                    for (int i = 0; i < length; i++)
                        securityString.AppendChar(value[i]);
                    this.passwordEmailAdmin = securityString.Copy();
                }
            }
            [SecurityCritical]
            get
            {
                string stringSafe;
                using (SecureString secureString = this.passwordEmailAdmin.Copy())
                {
                    IntPtr interPreter = Marshal.SecureStringToBSTR(secureString);
                    try
                    {
                        stringSafe = new string((char*)interPreter);
                    }
                    finally
                    {
                        Marshal.ZeroFreeBSTR(interPreter);
                    }
                }
                return stringSafe;
            }
        }

        private SecureString emailAdmin;
        public unsafe readonly string EmailAdmin
        {
            [SecurityCritical]
            set
            {
                if (value == null)
                    value = string.Empty;
                using (SecureString securityString = new SecureString())
                {
                    var length = value.Length;
                    for (int i = 0; i < length; i++)
                        securityString.AppendChar(value[i]);
                    this.emailAdmin = securityString.Copy();
                }
            }
            [SecurityCritical]
            get
            {
                string stringSafe;
                using (SecureString secureString = this.emailAdmin.Copy())
                {
                    IntPtr interPreter = Marshal.SecureStringToBSTR(secureString);
                    try
                    {
                        stringSafe = new string((char*)interPreter);
                    }
                    finally
                    {
                        Marshal.ZeroFreeBSTR(interPreter);
                    }
                }
                return stringSafe;
            }
        }

        // Maak een regex classe aan in property's en controlleer of er een @ in steekt.
        private const string EMAIL_SENDER_HOST = "smtp.gmail.com";
        private const short EIMAIL_SENDER_PORT = 587;

        public string ToMailAdress { set; get; }
        public readonly MailMessage MailMessager { set; get; }
        public readonly SmtpClient SmtpClients { set; get; }
        public Lecturers Lecturer { set; get; }

        public Mail()
        {
            this.MailMessager = new MailMessage();
            this.SmtpClients = new SmtpClient();
            this.ToMailAdress = "jimbo_mt_18@hotmail.com";
            this.PasswordEmailAdmin = "......";
        }
        public Mail(string toMailAdress)
        {
            this.ToMailAdress = toMailAdress;
        }

        public void SendEmailWithNewPassword()
        {

        }


    }
}