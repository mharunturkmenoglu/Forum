using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        Admin GetByValues(Admin admin);
        Admin EncyrptAdminValues(Admin admin);
        string ComputeSha256Hash(string rawData);
    }
}
