using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Audify.Model
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string BusinessName { get; set; }

    }
    public class Transactions
    {
        public string Id { get; set; }
        public string BatchId { get; set; }
        public string AccountId { get; set; }
        public string SubscriptionId { get; set; }
        public string ProviderId { get; set; }
        public string ProductId { get; set; }
        public Channel ChannelId { get; set; }
        public string ProductCategoryId { get; set; }
        public double Amount { get; set; }
        public string Value { get; set; }
        public Model mode { get; set; }


        public DateTime TransDay { get; set; }
        public TimeOfTheWeek TimeOfTheWeek { get; set; }

    }
    public enum Model
    {
        Credit,
        Debit
    }
    public enum TimeOfTheWeek
    {
        Weekend,
        Weekdays
    }
    public enum Channel
    {
        Web,
        Android,
        IOS,
        PayLater,
        CheckOut
    }
    public class Provider
    {
        public string Id { get; set; }
        public string ProviderName { get; set; }
        public string ProviderCategoryId { get; set; }
        public string UserId { get; set; }


    }
    public class HashStore
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Hash { get; set; }
   }
    public class Product
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string ProductName { get; set; }
        public string ProductShortCode { get; set; }
    }
    public class ProductCategory
    {
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string UserId { get; set; }


    }
}
