using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByWriter(int id);
        List<Content> GetListByHeadingID(int id);
        void CategoryAddBL(Content content);
        Content GetByID(int id);
        void CategoryDelete(Content content);
        void CategoryUpdate(Content content);
    }
}
