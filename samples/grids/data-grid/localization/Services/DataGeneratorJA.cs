using System;
using System.Collections.Generic;
using System.Linq;

namespace Infragistics.Samples
{
    public static class DataGeneratorJA
    {
        readonly static string[] websites = { ".com", ".gov", ".edu", ".org" };
        readonly static string[] emails = { "gmail.com", "yahoo.com", "twitter.com" };
        readonly static string[] genders = { "男", "女" };
        readonly static string[] maleNames = { "カイル", "オスカー", "ラルフ", "マイク", "ビル", "フランク", "ハワード", "ジャック", "ラリー", "ピート", "スティーブ", "ヴィンス", "マーク", "アレックス", "マックス", "ブライアン", "クリス", "アンドリュー", "マーティン", "マイク", "スティーブ", "グレン", "ブルース" };
        readonly static string[] femaleNames = { "ジーナ", "アイリーン", "ケイティー", "ブレンダ", "ケイシー", "フィオーナ", "ホリー", "ケイト", "リズ", "パメラ", "ネリー", "マルサ", "モニカ", "アンナ", "ジェシカ", "ソフィア", "イザベラ", "マーゴ", "ジェーン", "オードリー", "サリー", "メラニー", "グレタ", "オーロラ", "サリー" };
        readonly static string[] lastNames = { "アダムス", "クローリー", "エリス", "マルチネス", "アーバイン", "マクスウェル", "クラーク", "オーエンス", "ルーニー", "リンカーン", "トーマス", "スペーシー", "モーガン", "キング", "ニュートン", "フィッツジェラルド", "ホームズ", "ジェファーソン", "ランドリー", "ベリー", "ペレス", "スペンサー", "スター", "カーター", "エドワーズ", "スターク", "ジョンソン", "フィッツ", "チーフ", "ブランク", "ペリー", "ストーン", "ウィリアムズ", "レーン", "ジョブズ", "アダムス", "パワー", "テスラ" };
        readonly static string[] countries = { "アメリカ合衆国", "イギリス", "フランス", "カナダ", "ポーランド" };
        readonly static string[] citiesUS = { "ニューヨーク", "ロサンゼルス", "マイアミ", "サンフランシスコ", "サンディエゴ", "ラスベガス" };
        readonly static string[] citiesUK = { "ロンドン", "リバプール", "マンチェスター" };
        readonly static string[] citiesFR = { "パリ", "マルセイユ", "リヨン" };
        readonly static string[] citiesCA = { "トロント", "バンクーバー", "モントリオール" };
        readonly static string[] citiesPL = { "クラクフ", "ワルシャワ", "ヴロツワフ", "グダニスク" };
        readonly static string[] citiesJP = { "東京", "大阪", "京都", "横浜" };
        readonly static string[] citiesGR = { "ベルリン", "ボン", "ケルン", "ミュンヘン", "ハンブルク" };
        readonly static string[] roadSuffixes = { "通り", "通り", "通り" };
        readonly static string[] roadNames = { "メイン", "ガーデン", "ブロード", "オーク", "シダー", "パーン", "パイン", "エルム", "マーケット", "ヒル" };

        public static Random Rand = new Random();

        public static string GetWebsite()
        {
            return GetItem(websites);
        }

        public static string GetEmail()
        {
            return GetItem(emails);
        }

        public static double GetNumber(double min, double max)
        {
            return Math.Round(min + (Rand.NextDouble() * (max - min)));
        }

        public static int GetInteger(double min, double max)
        {
            return (int)GetNumber(min, max);
        }

        public static string GetPhone()
        {
            var phoneCode = GetNumber(100, 900);
            var phoneNum1 = GetNumber(100, 900);
            var phoneNum2 = GetNumber(1000, 9000);
            var phone = phoneCode + "-" + phoneNum1 + "-" + phoneNum2;
            return phone;
        }

        public static string GetGender()
        {
            return GetItem(genders);
        }

        public static string GetNameFirst(string gender)
        {
            if (gender == "男")
                return GetItem(maleNames);
            else
                return GetItem(femaleNames);
        }

        public static string GetNameLast()
        {
            return GetItem(lastNames);
        }

        public static string GetItem(string[] array)
        {
            var index = (int)Math.Round(GetNumber(0, array.Length - 1));
            return array[index];
        }

        public static string GetCountry()
        {
            return GetItem(countries);
        }

        public static string GetCity(string country)
        {
            if (country == "カナダ")
            {
                return GetItem(citiesCA);
            }
            else if (country == "フランス")
            {
                return GetItem(citiesFR);
            }
            else if (country == "ポーランド")
            {
                return GetItem(citiesPL);
            }
            else if (country == "アメリカ合衆国")
            {
                return GetItem(citiesUS);
            }
            else if (country == "Japan")
            {
                return GetItem(citiesJP);
            }
            else if (country == "Germany")
            {
                return GetItem(citiesGR);
            }
            else
            {
                return GetItem(citiesUK);
            }
        }

        public static string GetStreet()
        {
            var num = Math.Round(GetNumber(100, 300)).ToString();
            var road = GetItem(roadNames);
            var suffix = GetItem(roadSuffixes);
            return num + " " + road + " " + suffix;
        }

        public static DateTime GetBirthday()
        {
            var year = DateTime.Now.Year - GetInteger(30, 50);
            var month = GetNumber(10, 12);
            var day = GetNumber(20, 27);
            return new DateTime(year, (int)month, (int)day);
        }

        public static DateTime GetDate()
        {
            var year = DateTime.Now.Year;
            var month = GetNumber(10, 12);
            var day = GetNumber(20, 27);
            return new DateTime(year, (int)month, (int)day);
        }

        public static string Pad(int num, int size)
        {
            var s = num + "";
            while (s.Length < size)
            {
                s = "0" + s;
            }
            return s;
        }

        public static string GetPhotoMale(int id)
        {
            return "https://static.infragistics.com/xplatform/images/people/GUY" + Pad(id, 2) + ".png";
        }

        public static string GetPhotoFemale(int id)
        {
            return "https://static.infragistics.com/xplatform/images/people/GIRL" + Pad(id, 2) + ".png";
        }

        private static int maleCount = 0;
        private static int femaleCount = 0;
        public static string GetPhoto(string gender)
        {
            if (gender == "男")
            {
                maleCount++;
                if (maleCount > 24) maleCount = 1;
                return GetPhotoMale(maleCount);
            }
            else
            {
                femaleCount++;
                if (femaleCount > 24) femaleCount = 1;
                return GetPhotoFemale(femaleCount);
            }
        }

        public static string GetGenderPhoto(string gender)
        {
            // Note: Mapping between En and Ja.
            // This comment is for the sake of coding and debugging.
            // readonly static string[] gendersEn = { "male", "female" };
            // readonly static string[] genders = { "男", "女" };

            string genderEn = (gender == "男" ? "male" : "female");
            return "https://static.infragistics.com/xplatform/images/genders/" + genderEn + ".png";
        }

        public static string GetCountryFlag(string country)
        {
            // Note: Mapping between En and Ja.
            // This comment is for the sake of coding and debugging.
            // readonly static string[] countriesEn = { "USA", "UK", "France", "Canada", "Poland" };
            // readonly static string[] countries = { "アメリカ合衆国", "イギリス", "フランス", "カナダ", "ポーランド" };

            string countryEn = "";
            if (country == "カナダ")
            {
                countryEn = "Canada";
            }
            else if (country == "フランス")
            {
                countryEn = "France";
            }
            else if (country == "ポーランド")
            {
                countryEn = "Poland";
            }
            else if (country == "アメリカ合衆国")
            {
                countryEn = "USA";
            }
            else if (country == "Japan")
            {
                countryEn = "Japan";
            }
            else if (country == "Germany")
            {
                countryEn = "Germany";
            }
            else
            { // if (country === "United Kingdom") {
                countryEn = "UK";
            }
            return "https://static.infragistics.com/xplatform/images/flags/" + countryEn + ".png";
        }

        public static string GetIncomeRange(double salary)
        {
            if (salary < 50000)
            {
                return "低い";
            }
            else if (salary < 100000)
            {
                return "平均";
            }
            else
            {
                return "高い";
            }
        }

    }

}