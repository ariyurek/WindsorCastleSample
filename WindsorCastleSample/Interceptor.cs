using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Castle.DynamicProxy;

namespace Windsor.Project
{
    class Interceptor:IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {  
            try  
            {    
                //Metoda gelen ilk isteği logluyoruz.    
                Console.WriteLine("{0} isimli metoda istek geldi", invocation.Method.Name);       
                
                //İsteği yapan kullanıcının işlemi yapma yetkisi var mı yok mu kontrolünü burada yapabiliriz.   
                
                //Eğer yetkisi varsa metodu çalıştır.

                invocation.Proceed();
                
                // Yoksa Exception fırlatılabilir.
                
                Console.WriteLine("{0} isimli metodun çalışması sona erdi.",invocation.Method.Name);               
            }  
            catch (Exception ex)  
            {    
                Console.WriteLine("Hata oluştu {0}",ex.ToString());  
            }
        }
    }
}
