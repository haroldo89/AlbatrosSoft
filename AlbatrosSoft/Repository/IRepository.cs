using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbatrosSoft.Repository
{
    public interface IRepository<T> where T : new()
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity, out string resultMessage);
        void Update(T entity, out string resultMessage);
        void Delete(int entityId, out string resultMessage);
        void Save();
    }
}