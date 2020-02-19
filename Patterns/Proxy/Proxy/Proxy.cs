using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxy
{
    public interface PaymentServiceDescriptor
    {
        void PayForASubscription(string subsription, int money);
    }

    public class PaymentService : PaymentServiceDescriptor
    {
        public void PayForASubscription(string subscription, int money)
        {
            Console.WriteLine("Оплата в размере {0} рублей за подписку \"{1}\" прошла успешно!", money, subscription);
        }
    }

    public class PaymentServiceProxy : PaymentServiceDescriptor
    {
        private PaymentService paymentService;
        private int numberOfRequests = 0;
        public int NumberOfRequests
        {
            get
            {
                return numberOfRequests;
            }
        }
        private Logger logger;
        public PaymentServiceProxy()
        {
            logger = new Logger();
        }
        public void PayForASubscription(string subsription, int money)
        {
            numberOfRequests++;
            logger.Log(string.Format("Отправка запроса на оплату в размере {0} рублей за подписку \"{1}\"", money, subsription));
            MakeRequest(subsription, money);
            logger.Log(string.Format("Запрос на оплату в размере {0} рублей за подписку \"{1}\" завершен", money, subsription));
        }
        public void MakeRequest(string subscription, int money)
        {
            if (paymentService == null)
            {
                paymentService = new PaymentService();
            }
            paymentService.PayForASubscription(subscription, money);
        }
        public void ShowLoggedMessages()
        {
            logger.ShowLoggedMessages();
        }
    }

    public class Logger
    {
        private List<string> loggedMessages;
        public Logger()
        {
            loggedMessages = new List<string>();
        }
        public void Log(string message)
        {
            loggedMessages.Add(message);
        }
        public void ShowLoggedMessages()
        {
            foreach (string message in loggedMessages)
            {
                Console.WriteLine(message);
            }
        }
    }
}
