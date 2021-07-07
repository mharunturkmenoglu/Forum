using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _admin;

        public AdminManager(IAdminDal admin)
        {
            _admin = admin;
        }

        public void AdminAddBL(Admin admin)
        {
            _admin.Insert(admin);
        }

        public void AdminDelete(Admin admin)
        {
            _admin.Delete(admin);
        }

        public void AdminUpdate(Admin admin)
        {
            _admin.Update(admin);
        }

        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public Admin EncyrptAdminValues(Admin admin)
        {
            admin.AdminPassword = ComputeSha256Hash(admin.AdminPassword);
            return admin;
        }

        public Admin GetByID(int id)
        {
            return _admin.Get(x => x.AdminID == id);
        }

        public Admin GetByValues(Admin admin)
        {
            return _admin.Get(x => x.AdminUserName == admin.AdminUserName && x.AdminPassword == admin.AdminPassword);
        }

        public List<Admin> GetList()
        {
            return _admin.List();
        }
    }
}
