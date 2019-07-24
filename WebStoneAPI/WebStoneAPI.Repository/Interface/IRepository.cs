using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoneAPI.Repository.Interface
{
    public interface IRepository<T>
    {
        void Insert(T t);
        List<T> GetList();

    }
}
