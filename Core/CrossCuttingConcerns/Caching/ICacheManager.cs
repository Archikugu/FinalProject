using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        //duraitonı saat yada dakika cinsinden tutabiliriz
        void Add(string key, object value,int duration);

        //Cache de var mı sorgusu için 
        bool IsAdd(string key);

        //Cacheden uçurmak için 
        void Remove(string key);
        void RemoveByPattern(string pattern);
    
    }
}
