using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAddedMessage = "Ürün Eklendi";
        public static string ProductNameInValid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride 10 dan fazla ürün olamaz";
        public static string CategoryLimitExceded = "Ürün Sayısı 15'i geçmiştir";
        public static string AuthorizationDenied = "Yetkin Yok";
    }
}