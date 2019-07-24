using System;
using System.Collections.Generic;
using System.Text;

namespace WebStoneAPI.Repository.Interface
{
    public interface IBrandRepository<T>
    {
        T Get(string value);
    }
}
