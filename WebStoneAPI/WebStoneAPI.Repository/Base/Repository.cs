using System;
using System.Collections.Generic;
using WebStoneAPI.Repository.Interface;

namespace WebStoneAPI.Repository.Base
{
    public abstract class Repository<T> : IRepository<T>
    {
   

        private static List<T> _data;
        private static object _syncObj = new object();

        public Repository()
        {
            if (_data == null)
            {
                lock (_syncObj)
                {
                    if (_data == null)
                    {
                        _data = new List<T>();
                    }
                }
            }
        }

        public List<T> GetList()
        {
            return _data;
        }


        public void Insert(T t)
        {
            _data.Add(t);
        }
    }
}

