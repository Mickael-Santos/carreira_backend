using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base 
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string ?Name { get; set; }

        public string ?Email { get; set; }

        public User ?User { get; set; }

        public List<Subscription> Subscriptions { get; set; }   

        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium","o aluno já tem uma assinatura ativa"));
                return;
            }

            Subscriptions.Add(subscription);
        }
    }
}