using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Caching
{
    public class CacheAspect : MethodInterception
    {
        private int _duration;
        private ICacheManager _cacheManager;

        public CacheAspect(int duration = 60)
        {
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation) 
        {
            //BURADA YAPTIĞIMIZ HAREKET -- ÇALIŞTIRDIĞIMIZ METODUN NAMESPACE'İ İSMİ METOD İSMİ PARAMETRELERİNE GÖRE KEY OLUŞTURUYOR
            //EĞER BU KEY DAHA ÖNCE VARSA DİREKT CACHE'DEN AL YOKSA VERİTABANINDAN AL AMA CACHE DE EKLE.
            var methodName = string.Format($"{invocation.Method.ReflectedType.FullName}.{invocation.Method.Name}"); //{invocation.Method.ReflectedType.FullName} --BURASI NAMESPACCE + CLASS'IN ADINI VERİR . {invocation.Method.Name} ÇALIŞTIRDIĞIN METODUN İSMİ (GETALL)
            var arguments = invocation.Arguments.ToList(); // METODUN PARAMETRELERİNİ LİSTEYE ÇEVİR.
            var key = $"{methodName}({string.Join(",", arguments.Select(x => x?.ToString() ?? "<Null>"))})"; // METODUN PARAMETRELERİNİ EĞER PARAMETRE DEĞERİ VARSA O PARAMETRE DEĞERİNİ YUKARIDAKİ GETALL'IN İÇİNE EKLİYOR
            if (_cacheManager.IsAdd(key)) // GİT BAK BAKALIM BELLEKTE BÖYLE BİR CACHE ANAHTARI VAR MI?
            {
                invocation.ReturnValue = _cacheManager.Get(key); // EĞER VARSA METODU ÇALIŞTIRMADAN GERİ DÖN. CACHE MANAGERDAN GET ED
                return;
            }
            invocation.Proceed(); // YOKSA METODU ÇALIŞTIR DEVAM ETTİR. VERİTABANINDAN DATAYI GETİR.
            _cacheManager.Add(key, invocation.ReturnValue, _duration); // BURAYA KADAR GELDİĞİNDE DEMEKKİ DAHA ÖNCE CACHE'E EKLENMEMİŞ O YÜZDEN BURDA EKLEME YAPIYOR. BU DEĞERLER BURAYA EKLENMİŞ OLUYOR
        }
    }

}
