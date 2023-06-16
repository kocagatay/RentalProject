using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        //General
        public static string MaintenanceTime = "Sistem bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok!";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string AccessTokenCreated = "Başarılı";

        //Brands
        public static string BrandAdded = "Marka eklendi";


        //Cars
        public static string CarsListed = "Araçlar listelendi";
        public static string CarAdded = "Araç eklendi";
        public static string CarImageAdded = "Araç fotoğrafı eklendi";
        public static string CarImageListed = "Araç fotoğrafları listelendi";

        //CarImages



        //CreditCard
        public static string CreditCardAdded = "Kart eklendi";
        public static string StringMustConsistOfNumbersOnly = "String, sadece sayilardan olusmalidir";
        public static string CreditCardNotValid = "Kredi kartı doğrulanamadı";
        public static string CreditCardListed = "Kredi kartları listelendi";
        public static string CreditCardNotFound = "Kredi kartı bulunamadı";
        public static string InsufficientCardBalance = "Yetersiz bakiye";
        public static string PaymentSuccessful = "Ödeme başarılı";

        public static string CustomersCreditCardsListed = "Müşterilerin kredi kartları listelendi";
        public static string CustomerCreditCardAlreadySaved = "Kredi karti zaten kaydedilmis";
        public static string CustomerCreditCardSaved = "Müsteri kredi karti basariyla kaydedildi";
        public static string CustomerCreditCardFailedToSave = "Müsteri kredi karti kaydedilemedi";
        public static string CustomerCreditCardDeleted = "Musteri kredi karti basariyla silindi";
        public static string CustomerCreditCardNotDeleted = "Musteri kredi karti silinemedi";
        public static string CustomerCreditCardNotFound = "Müsteri kredi karti bulunamadi";


        //Colors
        public static string ColorAdded = "Renk eklendi";
        public static string ColorListed = "Renkler listelendi";

        //Customers
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerListed = "Müşteriler listelendi";


        //Rentals
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentalFailed = "Kiralama hatalı";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";


        //Users
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string UserAdded ="Kullanıcı eklendi";
        public static string ClaimsListed = "Claimler listelendi";


        public static string ThisCarIsAlreadyRentedInSelectedDateRange = "Araç bu tarihlerde kiralanmış durumda";


        //Payment
        public static string PaymentAdded = "Ödeme eklendi";
        public static string PaymentDeleted = "Ödeme silindi";
        public static string PaymentListed = "Ödemeler listelendi";
        public static string PayIsSuccessfull = "Ödeme başarılı";
        public static string CardInformationIsIncorrect = "Kart bilgisi hatalı";
        public static string PaymentUpdated = "Ödeme güncellendi";
        
    }
}
