using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunYonetimi.Model.Models;

namespace UrunYonetimi.Islem.Services
{
    public interface IDataService<T> where T : BaseModel
    {
        bool Add(T model);
        bool Update(T model);
        bool Delete(T model);
        List<T> GetAll();
        T Get(Guid id);

    }
}
