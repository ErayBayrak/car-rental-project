using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string SuccessAdded = "Başarıyla eklendi.";
        public static string SuccessDeleted = "Başarıyla silindi.";
        public static string SuccessUpdated = "Başarıyla güncellendi.";
        public static string FailedAdd = "Eklenemedi.";
        public static string SuccessGet = "Veri getirildi.";
        public static string ProductNameAlreadyExists = "Bu isme sahip bir ürün bulunmakta.";
        public static string CategoryLimitExceded = "Kategori sayısı 15'ten büyük olamaz.";
        public static string AuthorizationDenied = "Yetkiniz yoks.";
        public static string UserRegistered = "Kullanıcı kaydoldu.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı daha önce kaydolmuş.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
