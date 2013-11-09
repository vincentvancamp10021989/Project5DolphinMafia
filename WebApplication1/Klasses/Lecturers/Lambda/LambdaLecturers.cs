using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Web;
using System.Windows.Forms;
using WebApplication1.Klasses.Algemeen;
using WebApplication1.Klasses.Connection;

namespace WebApplication1.Klasses.Login.linq
{
    public class LambdaLecturers
    {
        #region Fields
        private SecureString password;
        public unsafe string Password
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
                    this.password = securityString.Copy();
                }
            }
            [SecurityCritical]
            get
            {
                string stringSafe;
                using (SecureString secureString = this.password.Copy())
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
        public string EMail { set; get; }
        //public string Password { set; get; }
        private string Firstname { set; get; }
        private string Lastname { set; get; }
        public Entity Entity { set; get; }
        #endregion

        #region Constructors
        public LambdaLecturers()
        {
            this.Entity = new Entity();
        }
        public LambdaLecturers(string email)
            :this()
        {
            this.EMail = email;
        }
        public LambdaLecturers(string email, string password)
            :this(email)
        {
            this.Password = password;
        }
        public LambdaLecturers(string email, string password, string firstname, string lastname)
            :this(email, password)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
        }
        #endregion

        public Boolean GetCheckLectorInfo()
        {
            var result = Entity.DB_Lecturers
                .Any(x =>
                        x.Password.Equals(Hash.Password_Encryption_md5(this.Password))
                        && x.EMail.Equals(this.EMail)
                    );
            return result;
        }
        public Lecturers GetCheckLecturersInfo_DatabaseFields()
        {
            Lecturers lector = Entity.DB_Lecturers
                .Where(x =>
                        x.Password.Equals(Hash.Password_Encryption_md5(this.Password))
                        && x.EMail.Equals(this.EMail)
                    ).First();
            return lector;
        }
        public Boolean GetCheckUniekEmail()
        {
            var result = Entity.DB_Lecturers
                .Any(x =>
                        !x.EMail.Equals(this.EMail)
                    );
            return result;
        }
        public Boolean GetCheckExistEmail()
        {
            var result = this.Entity.DB_Lecturers
                .Exists(x =>
                    x.EMail.Equals(this.EMail));
            return result;
        }
        public Lecturer SetChangeLecturerPasswordWithEmail()
        {
            var lecturer = Entity.dataClassContext.Lecturers
                .Where(z =>
                          z.Email.Equals(this.EMail)
                       ).ToList().First();
            lecturer.Password = Hash.Password_Encryption_md5("123456");
            Entity.dataClassContext.SubmitChanges();
            return lecturer;
        }

        public Lecturer SetLecturersInsertData()
        {
            Lecturer lecturers = new Lecturer()
            {
                Firstname = this.Firstname,
                Lastname = this.Lastname,
                Email = this.EMail,
                Access = 1,
                Password = Hash.Password_Encryption_md5(this.Password)
            };
            Entity.dataClassContext.Lecturers.InsertOnSubmit(lecturers);
            Entity.dataClassContext.SubmitChanges();

            return lecturers;
        }
    }
}































































/* public string EMail { set; get; }
 public string Password { set; get; }
 public LinqLecturers(string email, string password)
 {
     this.EMail = email;
     this.Password = password;
 }

 public Boolean GetCheckLectorInfo()
 {
     var list = new Entity();
     var result = list.DB_Lecturers.Any(x =>
                                         x.Password.Equals(this.Password)
                                         && x.EMail.Equals(this.EMail)
                                     );
     return result;
 }*/