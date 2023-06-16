using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes = type.GetCustomAttributes<MethodInterceptionBaseAttribute>
                (true).ToList();
            var methodAttributes = type.GetMethod(method.Name)
                .GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            classAttributes.AddRange(methodAttributes);
            //PERFORMANCE ASPECT'İ ADDRANGE GİBİ BURAYA EKLERSEN MEVCUTTA VE İLERDE EKLEYECEĞİN BÜTÜN METODLARA EKLENMİŞ OLUR
            //VE BU SAYEDE  BÜTÜN PROJENİN PERFORMANSINI KONTROL ETMİŞ OLURSUN

            return classAttributes.OrderBy(x => x.Priority).ToArray();
        }
    }
}
