using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir Kategoride en fazla 10 ürün olabilir";
        public static string ProductUpdated = "Ürün Güncellendi";
        public static string ProductNameAlreadyExists="Böyle bir ürün zaten var";
        public static string CategoryLimitExceded = "Kategori Limiti Aşıldı";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string UserRegistered="Kayıt olundu";
        public static string UserNotFound= "Kullanıcı bulunamadı ";
        public static string PasswordError="Parola Hatası";
        public static string SuccessfulLogin="Başarılı Giriş";
        public static string UserAlreadyExists="Kullanıcı Mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
