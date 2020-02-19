using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.Proxy;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentServiceDescriptor paymentService = new PaymentService();
            paymentService.PayForASubscription("Безлимитные обучающие курсы на платформе Coursera", 5000);

            PaymentServiceDescriptor paymentServiceProxy = new PaymentServiceProxy();
            paymentServiceProxy.PayForASubscription("Курс по языку Go на платформе Intuit", 1500);

            PaymentServiceProxy paymentServiceProxyInstance = new PaymentServiceProxy();
            paymentServiceProxyInstance.PayForASubscription("Доступ к курсам по машинному обучению на платформе DataCamp", 2000);
            Console.WriteLine("Количество запросов к сервису: " + paymentServiceProxyInstance.NumberOfRequests);
            paymentServiceProxyInstance.ShowLoggedMessages();
        }
    }
}
