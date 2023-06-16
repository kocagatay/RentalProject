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
        void Add(string key, object value, int duration);
        bool IsAdd(string key); //CACHE VAR MI METODU VARSA ORDAN GETİR YOKSA DB'DEN CACHE ÇEKİCEZ
        void Remove(string key); // UÇUR
        void RemoveByPattern(string pattern); // İÇİNDE GET OLANLARI VE YA CATEGORY OLANLARI VS. UÇUR
    }
}
 