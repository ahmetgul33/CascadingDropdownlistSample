using CascadingDropdownlistSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadingDropdownlistSample.Data
{
    public class DataManager
    {
        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
                new City { CityId = 01, CityName=" Adana" },
                new City { CityId = 02, CityName=" Adıyaman" },
                new City { CityId = 03, CityName=" Afyon" },
                new City { CityId = 04, CityName=" Ağrı" },
                new City { CityId = 05, CityName=" Amasya" },
                new City { CityId = 06, CityName=" Ankara" },
                new City { CityId = 07, CityName=" Antalya" },
                 new City { CityId = 07, CityName=" Antalya" },
                 new City { CityId = 08, CityName=" Artvin" },
                 new City { CityId = 09, CityName=" Aydın" },
                 new City { CityId = 10, CityName=" Balıkesir" },
                 new City { CityId = 11, CityName=" Bilecik" },
                new City { CityId = 12, CityName=" Bingöl" },
                new City { CityId = 13, CityName=" Bitlis" },
                new City { CityId = 14, CityName=" Bolu" },
                new City { CityId = 15, CityName=" Burdur" },
                new City { CityId = 16, CityName=" Bursa" },
                new City { CityId = 17, CityName=" Çanakkale" },
                 new City { CityId = 18, CityName=" Çankırı" },
                 new City { CityId = 19, CityName=" Çorum" },
                 new City { CityId = 20, CityName=" Denizli" },
                 new City { CityId = 21, CityName=" Diyarbakır" },
                 new City { CityId = 22, CityName=" Edirne" },
                new City { CityId = 23, CityName=" Elazığ" },
                new City { CityId = 24, CityName=" Erzincan" },
                new City { CityId = 25, CityName=" Erzurum" },
                new City { CityId = 26, CityName=" Eskişehir" },
                new City { CityId = 27, CityName=" Gaziantep" },
                new City { CityId = 28, CityName=" Giresun" },
                 new City { CityId = 29, CityName=" Gümüşhane" },
                 new City { CityId = 30, CityName=" Hakkari" },
                 new City { CityId = 31, CityName=" Hatay" },
                 new City { CityId = 32, CityName=" Isparta" },
                new City { CityId = 33, CityName="  İçel (Mersin)" },
                new City { CityId = 34, CityName=" İstanbul" },
                new City { CityId = 35, CityName=" İzmir" },
                new City { CityId = 36, CityName=" Kars" },
                new City { CityId = 37, CityName=" Kastamonu" },
                new City { CityId = 38, CityName=" Kayseri" },
                new City { CityId = 39, CityName=" Kırklareli" },
                 new City { CityId = 40, CityName=" Kırşehir" },
                 new City { CityId = 41, CityName=" Kocaeli" },
                 new City { CityId = 42, CityName=" Konya" },
                 new City { CityId = 43, CityName=" Kütahya" },
                 new City { CityId = 44, CityName=" Malatya" },
                  new City { CityId = 45, CityName=" Manisa" },
                new City { CityId = 46, CityName="  K.maraş" },
                new City { CityId = 47, CityName=" Mardin" },
                new City { CityId = 48, CityName=" Muğla" },
                new City { CityId = 49, CityName=" Muş" },
                new City { CityId = 50, CityName=" Nevşehir" },
                new City { CityId = 51, CityName=" Niğde" },
                new City { CityId = 52, CityName=" Ordu" },
                 new City { CityId = 53, CityName=" Rize" },
                   new City { CityId = 54, CityName=" Sakarya" },
                 new City { CityId = 55, CityName=" Samsun" },
                 new City { CityId = 56, CityName=" Siirt" },
                 new City { CityId = 57, CityName=" Sinop" },
                  new City { CityId = 58, CityName=" Sivas" },
                new City { CityId = 59, CityName=" Tekirdağ" },
                new City { CityId = 60, CityName=" Tokat" },
                new City { CityId = 61, CityName=" Trabzon" },
                new City { CityId = 62, CityName=" Tunceli" },
                new City { CityId = 63, CityName=" Şanlıurfa" },
                new City { CityId = 64, CityName=" Uşak" },
                new City { CityId = 65, CityName=" Van" },
                 new City { CityId = 66, CityName=" Yozgat" },
                   new City { CityId = 67, CityName=" Zonguldak" },
                 new City { CityId = 68, CityName=" Aksaray" },
                 new City { CityId = 69, CityName=" Bayburt" },
                 new City { CityId = 70, CityName=" Karaman" },
                   new City { CityId = 71, CityName=" Kırıkkale" },
                new City { CityId = 72, CityName=" Batman" },
                new City { CityId = 73, CityName=" Şırnak" },
                new City { CityId = 74, CityName=" Bartın" },
                new City { CityId = 75, CityName=" Ardahan" },
                new City { CityId = 76, CityName=" Iğdır" },
                new City { CityId = 77, CityName=" Yalova" },
                new City { CityId = 78, CityName=" Karabük" },
                 new City { CityId = 79, CityName=" Kilis" },
                   new City { CityId = 80, CityName=" Osmaniye" },
                 new City { CityId = 81, CityName=" Düzce" },
              







            };

            return cities;
        }

        public static List<District> GetDistrict(int cityId)
        {
            List<District> districts = new List<District>() {
                 new District { DistrictId=4 , CityId = 34, DistrictName="Seçiniz" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Adalar" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Arnavutköy" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Ataşehir" },
               new District { DistrictId=4, CityId = 34, DistrictName="Avcılar" },
               new District { DistrictId=4 , CityId = 34, DistrictName="Bağcılar" },
               new District { DistrictId=4, CityId = 34, DistrictName="Bahçelievler" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Bakırköy" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Başakşehir" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Bayrampaşa" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Beşiktaş" },
                new District { DistrictId=4, CityId = 34, DistrictName="Beykoz" },
                new District { DistrictId=4, CityId = 34, DistrictName="Beylikdüzü" },
                new District { DistrictId=4, CityId = 34, DistrictName="Beyoğlu" },
                new District { DistrictId=4, CityId = 34, DistrictName="Büyükçekmece" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Çatalca" },
                 new District { DistrictId=4 , CityId = 34, DistrictName="Çekmeköy" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Esenler" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Esenyurt" },
               new District { DistrictId=4 , CityId = 34, DistrictName="Eyüp" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Fatih" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Gaziosmanpaşa" },
                 new District { DistrictId=4 , CityId = 34, DistrictName="Güngören" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Kadıköy" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Kağıthane" },
                 new District { DistrictId=4 , CityId = 34, DistrictName="Kartal" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Küçükçekmece" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Maltepe" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Pendik" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Sancaktepe" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Sarıyer" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Silivri" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Sultanbeyli" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Sultangazi" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Şile" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Şişli" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Tuzla" },
               new District { DistrictId=4 , CityId = 34, DistrictName="Ümraniye" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Üsküdar" },
                new District { DistrictId=4 , CityId = 34, DistrictName="Zeytinburnu" },
                new District { DistrictId=2, CityId = 6, DistrictName="Etimesgut" },
                new District { DistrictId=3 ,CityId = 35, DistrictName="Konak" },

            };

            
            return districts.Where(x=> x.CityId == cityId).ToList();
        }
    }
}