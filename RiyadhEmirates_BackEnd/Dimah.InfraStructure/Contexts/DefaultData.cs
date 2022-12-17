using Dimah.Core.Domain.Entities;
using System.Text;

namespace Dimah.InfraStructure.Contexts
{
    public static class DefaultData
    {
        public static Charity[] Charities()
        {
            Charity[] arrData = new Charity[1];
            arrData[0] = new Charity { Id = new Guid("22d0eeca-467a-48bc-a600-3624ff0887b6"), NameAr = "ديمه", NameEn = "Dimah", Address = "AddressAddressAddressAddress", Email = "dimah@d.org", PhoneNumber = "0501234567", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            return arrData;
        }
        public static ChartItemStatus[] ChartItemStatuses()
        {
            ChartItemStatus[] arrData = new ChartItemStatus[3];
            arrData[0] = new ChartItemStatus { Id = 1, NameAr = "جديد", NameEn = "New", IsActive = true,};
            arrData[1] = new ChartItemStatus { Id = 2, NameAr = "تم الدفع", NameEn = "Payed", IsActive = true,};
            arrData[2] = new ChartItemStatus { Id = 3, NameAr = "تم الحذف", NameEn = "Deleted", IsActive = true,};
            return arrData;
        }
        public static Nationality[] Nationalities()
        {
            Nationality[] arrData = new Nationality[190];
            arrData[0] = new Nationality { Id = 1, NameAr = "الامارات العربية", NameEn = "Arab Emirates", IsActive = true, Code = "101", Iso2 = "ae", DialCode = "971", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[1] = new Nationality { Id = 2, NameAr = "الاردن", NameEn = "Jordan", IsActive = true, Code = "102", Iso2 = "jo", DialCode = "962", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[2] = new Nationality { Id = 3, NameAr = "البحرين", NameEn = "Bahrain", IsActive = true, Code = "103", Iso2 = "bh", DialCode = "973", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[3] = new Nationality { Id = 4, NameAr = "سوريا", NameEn = "Syria", IsActive = true, Code = "104", Iso2 = "sy", DialCode = "963", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[4] = new Nationality { Id = 5, NameAr = "العراق", NameEn = "Iraq", IsActive = true, Code = "105", Iso2 = "iq", DialCode = "964", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[5] = new Nationality { Id = 6, NameAr = "عمان", NameEn = "Oman", IsActive = true, Code = "106", Iso2 = "om", DialCode = "968", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[6] = new Nationality { Id = 7, NameAr = "فلسطين", NameEn = "Palestine", IsActive = true, Code = "107", Iso2 = "ps", DialCode = "970", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[7] = new Nationality { Id = 8, NameAr = "قطر", NameEn = "Qatar", IsActive = true, Code = "108", Iso2 = "qa", DialCode = "974", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[8] = new Nationality { Id = 9, NameAr = "الكويت", NameEn = "Kuwait", IsActive = true, Code = "109", Iso2 = "kw", DialCode = "965", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[9] = new Nationality { Id = 10, NameAr = "لبنان", NameEn = "Lebanon", IsActive = true, Code = "110", Iso2 = "lb", DialCode = "961", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[10] = new Nationality { Id = 11, NameAr = "اليمن", NameEn = "Yemen", IsActive = true, Code = "111", Iso2 = "ye", DialCode = "967", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[11] = new Nationality { Id = 12, NameAr = "العربية السعودية", NameEn = "Saudi Arabia", IsActive = true, Code = "113", Iso2 = "sa", DialCode = "966", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[12] = new Nationality { Id = 13, NameAr = "تونس", NameEn = "Tunisia", IsActive = true, Code = "201", Iso2 = "tn", DialCode = "216", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[13] = new Nationality { Id = 14, NameAr = "الجزائر", NameEn = "Algeria", IsActive = true, Code = "202", Iso2 = "dz", DialCode = "213", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[14] = new Nationality { Id = 15, NameAr = "جيبوتى", NameEn = "Djibouti", IsActive = true, Code = "203", Iso2 = "dj", DialCode = "253", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[15] = new Nationality { Id = 16, NameAr = "السودان", NameEn = "Sudan", IsActive = true, Code = "204", Iso2 = "sd", DialCode = "249", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[16] = new Nationality { Id = 17, NameAr = "الصومال", NameEn = "Somalia", IsActive = true, Code = "205", Iso2 = "so", DialCode = "252", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[17] = new Nationality { Id = 18, NameAr = "ليبيا", NameEn = "Libya", IsActive = true, Code = "206", Iso2 = "ly", DialCode = "218", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[18] = new Nationality { Id = 19, NameAr = "مصر", NameEn = "Egypt", IsActive = true, Code = "207", Iso2 = "eg", DialCode = "20", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[19] = new Nationality { Id = 20, NameAr = "المغرب", NameEn = "Morocco", IsActive = true, Code = "208", Iso2 = "ma", DialCode = "212", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[20] = new Nationality { Id = 21, NameAr = "موريتانيا", NameEn = "Mauritania", IsActive = true, Code = "209", Iso2 = "mr", DialCode = "222", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[21] = new Nationality { Id = 22, NameAr = "افغانستان", NameEn = "Afghanistan", IsActive = true, Code = "301", Iso2 = "af", DialCode = "93", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[22] = new Nationality { Id = 23, NameAr = "اندونيسيا", NameEn = "Indonesia", IsActive = true, Code = "302", Iso2 = "id", DialCode = "62", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[23] = new Nationality { Id = 24, NameAr = "ايران", NameEn = "Iran", IsActive = true, Code = "303", Iso2 = "ir", DialCode = "98", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[24] = new Nationality { Id = 25, NameAr = "باكستان", NameEn = "Pakistan", IsActive = true, Code = "304", Iso2 = "pk", DialCode = "92", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[25] = new Nationality { Id = 26, NameAr = "بنجلاديش", NameEn = "Bangladesh", IsActive = true, Code = "305", Iso2 = "bd", DialCode = "880", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[26] = new Nationality { Id = 27, NameAr = "بروني", NameEn = "Brunei", IsActive = true, Code = "306", Iso2 = "bn", DialCode = "673", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[27] = new Nationality { Id = 28, NameAr = "جمهورية ميانمار", NameEn = "Myanmar", IsActive = true, Code = "307", Iso2 = "mm", DialCode = "95", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[28] = new Nationality { Id = 29, NameAr = "تايلند", NameEn = "Thailand", IsActive = true, Code = "308", Iso2 = "th", DialCode = "66", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[29] = new Nationality { Id = 30, NameAr = "تركيا", NameEn = "Turkey", IsActive = true, Code = "309", Iso2 = "tr", DialCode = "90", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[30] = new Nationality { Id = 31, NameAr = "جزر مالديف", NameEn = "Maldives", IsActive = true, Code = "310", Iso2 = "mv", DialCode = "960", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[31] = new Nationality { Id = 32, NameAr = "روسيا الاتحادية", NameEn = "Russia", IsActive = true, Code = "311", Iso2 = "ru", DialCode = "7", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[32] = new Nationality { Id = 33, NameAr = "سنغافورة", NameEn = "Singapore", IsActive = true, Code = "312", Iso2 = "sg", DialCode = "65", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[33] = new Nationality { Id = 34, NameAr = "سري لنكا", NameEn = "Sri Lanka", IsActive = true, Code = "313", Iso2 = "lk", DialCode = "94", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[34] = new Nationality { Id = 35, NameAr = "الفلبين", NameEn = "Philippines", IsActive = true, Code = "315", Iso2 = "ph", DialCode = "63", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[35] = new Nationality { Id = 36, NameAr = "فيتنام", NameEn = "Vietnam", IsActive = true, Code = "316", Iso2 = "vn", DialCode = "84", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[36] = new Nationality { Id = 37, NameAr = "كمبوديا", NameEn = "Cambodia", IsActive = true, Code = "317", Iso2 = "kh", DialCode = "855", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[37] = new Nationality { Id = 38, NameAr = "كوريا الجنوبية", NameEn = "South Korea", IsActive = true, Code = "318", Iso2 = "kr", DialCode = "82", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[38] = new Nationality { Id = 39, NameAr = "ماليزيا", NameEn = "Malaysia", IsActive = true, Code = "319", Iso2 = "my", DialCode = "60", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[39] = new Nationality { Id = 40, NameAr = "نيبال", NameEn = "Nepal", IsActive = true, Code = "320", Iso2 = "np", DialCode = "977", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[40] = new Nationality { Id = 41, NameAr = "الهند", NameEn = "India", IsActive = true, Code = "321", Iso2 = "in", DialCode = "91", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[41] = new Nationality { Id = 42, NameAr = "هونج كونج", NameEn = "Hong Kong", IsActive = true, Code = "322", Iso2 = "hk", DialCode = "852", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[42] = new Nationality { Id = 43, NameAr = "اليابان", NameEn = "Japan", IsActive = true, Code = "323", Iso2 = "jp", DialCode = "81", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[43] = new Nationality { Id = 44, NameAr = "بهوتان", NameEn = "Bhutan", IsActive = true, Code = "324", Iso2 = "bt", DialCode = "975", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[44] = new Nationality { Id = 45, NameAr = "الصين الشعبية", NameEn = "China", IsActive = true, Code = "325", Iso2 = "cn", DialCode = "86", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[45] = new Nationality { Id = 46, NameAr = "قبرص", NameEn = "Cyprus", IsActive = true, Code = "326", Iso2 = "cy", DialCode = "357", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[46] = new Nationality { Id = 47, NameAr = "كوريا الشمالية", NameEn = "North Korea", IsActive = true, Code = "328", Iso2 = "kp", DialCode = "850", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[47] = new Nationality { Id = 48, NameAr = "لاوس", NameEn = "Laos", IsActive = true, Code = "329", Iso2 = "la", DialCode = "856", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[48] = new Nationality { Id = 49, NameAr = "منغوليا", NameEn = "Mongolia", IsActive = true, Code = "330", Iso2 = "mn", DialCode = "976", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[49] = new Nationality { Id = 50, NameAr = "ماكاو", NameEn = "Macao", IsActive = true, Code = "331", Iso2 = "mo", DialCode = "853", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[50] = new Nationality { Id = 51, NameAr = "تركستان", NameEn = "Turkistan", IsActive = false, Code = "332", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[51] = new Nationality { Id = 52, NameAr = "القبائل النازحة", NameEn = "Tribes Emigrated", IsActive = false, Code = "335", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[52] = new Nationality { Id = 53, NameAr = "كازاخستان", NameEn = "Kazakhstan", IsActive = true, Code = "336", Iso2 = "kz", DialCode = "7", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[53] = new Nationality { Id = 54, NameAr = "ازبكستان", NameEn = "Uzbekistan", IsActive = true, Code = "337", Iso2 = "uz", DialCode = "998", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[54] = new Nationality { Id = 55, NameAr = "تركمانستان", NameEn = "Turkmenistan", IsActive = true, Code = "338", Iso2 = "tm", DialCode = "993", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[55] = new Nationality { Id = 56, NameAr = "طاجكستان", NameEn = "Tajikistan", IsActive = true, Code = "339", Iso2 = "tj", DialCode = "992", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[56] = new Nationality { Id = 57, NameAr = "قرغيزستان", NameEn = "kyrgyzstan", IsActive = false, Code = "340", Iso2 = "kg", DialCode = "996", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[57] = new Nationality { Id = 58, NameAr = "اذربيجان", NameEn = "Azerbaijan", IsActive = true, Code = "343", Iso2 = "az", DialCode = "994", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[58] = new Nationality { Id = 59, NameAr = "الشاشان", NameEn = "Chechnya", IsActive = false, Code = "344", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[59] = new Nationality { Id = 60, NameAr = "داغستان", NameEn = "Dagestan", IsActive = false, Code = "345", Iso2 = "da", DialCode = "872", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[60] = new Nationality { Id = 61, NameAr = "انقوش", NameEn = "Anquosh", IsActive = false, Code = "346", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[61] = new Nationality { Id = 62, NameAr = "تتارستان", NameEn = "Tatarstan", IsActive = false, Code = "347", Iso2 = "ta", DialCode = "7", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[62] = new Nationality { Id = 63, NameAr = "تيمور الشرقية", NameEn = "East Timor", IsActive = false, Code = "349", Iso2 = "tp", DialCode = "670", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[63] = new Nationality { Id = 64, NameAr = "اثيوبيا", NameEn = "Ethiopia", IsActive = true, Code = "401", Iso2 = "et", DialCode = "251", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[64] = new Nationality { Id = 65, NameAr = "اوغندة", NameEn = "Uganda", IsActive = true, Code = "402", Iso2 = "ug", DialCode = "256", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[65] = new Nationality { Id = 66, NameAr = "بوتسوانا", NameEn = "Botswana", IsActive = true, Code = "403", Iso2 = "bw", DialCode = "267", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[66] = new Nationality { Id = 67, NameAr = "بورندي", NameEn = "Burundi", IsActive = true, Code = "404", Iso2 = "bi", DialCode = "257", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[67] = new Nationality { Id = 68, NameAr = "تشاد", NameEn = "Chad", IsActive = true, Code = "405", Iso2 = "td", DialCode = "235", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[68] = new Nationality { Id = 69, NameAr = "تنزانيا", NameEn = "Tanzania", IsActive = true, Code = "406", Iso2 = "tz", DialCode = "255", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[69] = new Nationality { Id = 70, NameAr = "توجو", NameEn = "Togo", IsActive = true, Code = "407", Iso2 = "tg", DialCode = "228", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[70] = new Nationality { Id = 71, NameAr = "جابون", NameEn = "Answer", IsActive = true, Code = "408", Iso2 = "ga", DialCode = "241", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[71] = new Nationality { Id = 72, NameAr = "غامبيا", NameEn = "Gambia", IsActive = true, Code = "409", Iso2 = "gm", DialCode = "220", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[72] = new Nationality { Id = 73, NameAr = "جزر القمر", NameEn = "Comoros", IsActive = true, Code = "410", Iso2 = "km", DialCode = "269", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[73] = new Nationality { Id = 74, NameAr = "جنوب افريقيا", NameEn = "South Africa", IsActive = true, Code = "411", Iso2 = "za", DialCode = "27", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[74] = new Nationality { Id = 75, NameAr = "ناميبيا", NameEn = "Namibia", IsActive = true, Code = "412", Iso2 = "na", DialCode = "264", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[75] = new Nationality { Id = 76, NameAr = "بنين", NameEn = "Benin", IsActive = true, Code = "413", Iso2 = "bj", DialCode = "229", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[76] = new Nationality { Id = 77, NameAr = "رواندا", NameEn = "Rwanda", IsActive = true, Code = "414", Iso2 = "rw", DialCode = "250", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[77] = new Nationality { Id = 78, NameAr = "زمبابوي", NameEn = "Zimbabwe", IsActive = true, Code = "415", Iso2 = "zw", DialCode = "263", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[78] = new Nationality { Id = 79, NameAr = "زائير", NameEn = "Zaire", IsActive = false, Code = "416", Iso2 = "zr", DialCode = "243", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[79] = new Nationality { Id = 80, NameAr = "زامبيا", NameEn = "Zambia", IsActive = true, Code = "417", Iso2 = "zm", DialCode = "260", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[80] = new Nationality { Id = 81, NameAr = "ساحل العاج", NameEn = "Ivory Coast", IsActive = false, Code = "418", Iso2 = "ci", DialCode = "225", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[81] = new Nationality { Id = 82, NameAr = "السنغال", NameEn = "Senegal", IsActive = true, Code = "419", Iso2 = "sn  221", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[82] = new Nationality { Id = 83, NameAr = "سيراليون", NameEn = "Sierra Leone", IsActive = true, Code = "420", Iso2 = "sl", DialCode = "232", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[83] = new Nationality { Id = 84, NameAr = "غانا", NameEn = "Ghana", IsActive = true, Code = "421", Iso2 = "gh", DialCode = "233", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[84] = new Nationality { Id = 85, NameAr = "غينيا", NameEn = "Guinea", IsActive = true, Code = "422", Iso2 = "gn", DialCode = "224", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[85] = new Nationality { Id = 86, NameAr = "غينيابيساو", NameEn = "Guinea Bissau", IsActive = true, Code = "423", Iso2 = "gw", DialCode = "245", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[86] = new Nationality { Id = 87, NameAr = "بوركينافاسو", NameEn = "Burkina Faso", IsActive = true, Code = "424", Iso2 = "bf", DialCode = "226", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[87] = new Nationality { Id = 88, NameAr = "الكاميرون", NameEn = "Cameroon", IsActive = true, Code = "425", Iso2 = "cm", DialCode = "237", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[88] = new Nationality { Id = 89, NameAr = "جمهورية الكونغو الديمقراطية", NameEn = "Congo(DRC)", IsActive = true, Code = "426", Iso2 = "cd", DialCode = "243", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[89] = new Nationality { Id = 90, NameAr = "كينيا", NameEn = "Kenya", IsActive = true, Code = "427", Iso2 = "ke", DialCode = "254", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[90] = new Nationality { Id = 91, NameAr = "ليسوتو", NameEn = "Lesotho", IsActive = true, Code = "428", Iso2 = "ls", DialCode = "266", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[91] = new Nationality { Id = 92, NameAr = "ليبيريا", NameEn = "Liberia", IsActive = true, Code = "429", Iso2 = "lr", DialCode = "231", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[92] = new Nationality { Id = 93, NameAr = "مالي", NameEn = "Mali", IsActive = true, Code = "430", Iso2 = "ml", DialCode = "223", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[93] = new Nationality { Id = 94, NameAr = "ملاوي", NameEn = "Malawi", IsActive = true, Code = "432", Iso2 = "mw", DialCode = "265", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[94] = new Nationality { Id = 95, NameAr = "موريشيوس", NameEn = "Mauritius", IsActive = true, Code = "433", Iso2 = "mu", DialCode = "230", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[95] = new Nationality { Id = 96, NameAr = "موزمبيق", NameEn = "Mozambique", IsActive = true, Code = "434", Iso2 = "mz", DialCode = "258", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[96] = new Nationality { Id = 97, NameAr = "نيجيريا", NameEn = "Nigeria", IsActive = true, Code = "435", Iso2 = "ng", DialCode = "234", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[97] = new Nationality { Id = 98, NameAr = "النيجر", NameEn = "Niger", IsActive = true, Code = "436", Iso2 = "ne", DialCode = "227", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[98] = new Nationality { Id = 99, NameAr = "افريقيا الوسطى", NameEn = "Central Africa", IsActive = true, Code = "437", Iso2 = "cf", DialCode = "236", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[99] = new Nationality { Id = 100, NameAr = "انجولا", NameEn = "Angola", IsActive = true, Code = "438", Iso2 = "ao", DialCode = "244", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[100] = new Nationality { Id = 101, NameAr = "الجزر الكاريبية الهولندية", NameEn = "Caribbean Netherlands", IsActive = true, Code = "439", Iso2 = "bq", DialCode = "599", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[101] = new Nationality { Id = 102, NameAr = "غينيا الاستوائية", NameEn = "Equatorial Guinea", IsActive = true, Code = "440", Iso2 = "gq", DialCode = "240", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[102] = new Nationality { Id = 103, NameAr = "ملاجاسي", NameEn = "Mlajasi", IsActive = false, Code = "441", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[103] = new Nationality { Id = 104, NameAr = "ساوتومي/برنسبى", NameEn = "S? o Tomé and Pr? ncipe", IsActive = true, Code = "442", Iso2 = "st", DialCode = "239", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[104] = new Nationality { Id = 105, NameAr = "جزر سيشل", NameEn = "Seychelles Islands", IsActive = true, Code = "443", Iso2 = "sc", DialCode = "248", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[105] = new Nationality { Id = 106, NameAr = "سوزيلاند", NameEn = "Swaziland", IsActive = false, Code = "444", Iso2 = "sz", DialCode = "268", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[106] = new Nationality { Id = 107, NameAr = "ارتيريا", NameEn = "Eritrea", IsActive = true, Code = "449", Iso2 = "er", DialCode = "291", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[107] = new Nationality { Id = 108, NameAr = "جمهورية جنوب السودان", NameEn = "Republic of South Sudan", IsActive = false, Code = "453", Iso2 = "ss", DialCode = "211", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[108] = new Nationality { Id = 109, NameAr = "كاب فيرد(الراس الاخضر)", NameEn = "Cape Verde", IsActive = true, Code = "454", Iso2 = "cv", DialCode = "238", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[109] = new Nationality { Id = 110, NameAr = "اسبانيا", NameEn = "Spain", IsActive = true, Code = "501", Iso2 = "es", DialCode = "34", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[110] = new Nationality { Id = 111, NameAr = "البانيا", NameEn = "Albania", IsActive = true, Code = "502", Iso2 = "al", DialCode = "355", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[111] = new Nationality { Id = 112, NameAr = "المانيا", NameEn = "Germany", IsActive = true, Code = "503", Iso2 = "de", DialCode = "49", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[112] = new Nationality { Id = 113, NameAr = "ايرلندا", NameEn = "Ireland", IsActive = true, Code = "504", Iso2 = "ie", DialCode = "353", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[113] = new Nationality { Id = 114, NameAr = "ايطاليا", NameEn = "Italy", IsActive = true, Code = "505", Iso2 = "it", DialCode = "39", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[114] = new Nationality { Id = 115, NameAr = "المملكة المتحدة", NameEn = "United Kingdom", IsActive = true, Code = "506", Iso2 = "gb", DialCode = "44", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[115] = new Nationality { Id = 116, NameAr = "البرتغال", NameEn = "Portugal", IsActive = true, Code = "507", Iso2 = "pt", DialCode = "351", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[116] = new Nationality { Id = 117, NameAr = "بلغاريا", NameEn = "Bulgaria", IsActive = true, Code = "508", Iso2 = "bg", DialCode = "359", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[117] = new Nationality { Id = 118, NameAr = "بلجيكا", NameEn = "Belgium", IsActive = true, Code = "509", Iso2 = "be", DialCode = "32", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[118] = new Nationality { Id = 119, NameAr = "بولندا", NameEn = "Poland", IsActive = true, Code = "510", Iso2 = "pl", DialCode = "48", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[119] = new Nationality { Id = 120, NameAr = "الدانمارك", NameEn = "Denmark", IsActive = true, Code = "512", Iso2 = "dk", DialCode = "45", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[120] = new Nationality { Id = 121, NameAr = "رومانيا", NameEn = "Romania", IsActive = true, Code = "513", Iso2 = "ro", DialCode = "40", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[121] = new Nationality { Id = 122, NameAr = "السويد", NameEn = "Sweden", IsActive = true, Code = "514", Iso2 = "se", DialCode = "46", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[122] = new Nationality { Id = 123, NameAr = "سويسرا", NameEn = "Switzerland", IsActive = true, Code = "515", Iso2 = "ch", DialCode = "41", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[123] = new Nationality { Id = 124, NameAr = "فرنسا", NameEn = "France", IsActive = true, Code = "516", Iso2 = "fr", DialCode = "33", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[124] = new Nationality { Id = 125, NameAr = "فنلندا", NameEn = "Finland", IsActive = true, Code = "517", Iso2 = "fi", DialCode = "358", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[125] = new Nationality { Id = 126, NameAr = "صربيا", NameEn = "Serbia", IsActive = true, Code = "518", Iso2 = "rs", DialCode = "381", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[126] = new Nationality { Id = 127, NameAr = "هولندا", NameEn = "Netherlands", IsActive = true, Code = "519", Iso2 = "nl", DialCode = "31", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[127] = new Nationality { Id = 128, NameAr = "اليونان", NameEn = "Greece", IsActive = true, Code = "521", Iso2 = "gr", DialCode = "30", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[128] = new Nationality { Id = 129, NameAr = "اندورا", NameEn = "Andorra", IsActive = true, Code = "522", Iso2 = "ad", DialCode = "376", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[129] = new Nationality { Id = 130, NameAr = "النمسا", NameEn = "Austria", IsActive = true, Code = "523", Iso2 = "at", DialCode = "43", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[130] = new Nationality { Id = 131, NameAr = "الجبل الأ سود", NameEn = "Montenegro", IsActive = true, Code = "524", Iso2 = "me", DialCode = "382", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[131] = new Nationality { Id = 132, NameAr = "هنغاريا", NameEn = "Hungary", IsActive = true, Code = "525", Iso2 = "hu", DialCode = "36", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[132] = new Nationality { Id = 133, NameAr = "ايسلندا", NameEn = "Iceland", IsActive = true, Code = "526", Iso2 = "is", DialCode = "354", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[133] = new Nationality { Id = 134, NameAr = "ليختنشتين", NameEn = "Liechtenstein", IsActive = true, Code = "527", Iso2 = "li", DialCode = "423", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[134] = new Nationality { Id = 135, NameAr = "لوكسمبورغ", NameEn = "Luxembourg", IsActive = true, Code = "528", Iso2 = "lu", DialCode = "352", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[135] = new Nationality { Id = 136, NameAr = "مالطا", NameEn = "Malta", IsActive = true, Code = "529", Iso2 = "mt", DialCode = "356", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[136] = new Nationality { Id = 137, NameAr = "موناكو", NameEn = "Monaco", IsActive = true, Code = "530", Iso2 = "mc", DialCode = "377", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[137] = new Nationality { Id = 138, NameAr = "النرويج", NameEn = "Norway", IsActive = true, Code = "531", Iso2 = "no", DialCode = "47", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[138] = new Nationality { Id = 139, NameAr = "سان مارينو", NameEn = "San Marino", IsActive = true, Code = "532", Iso2 = "sm", DialCode = "378", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[139] = new Nationality { Id = 140, NameAr = "مدينة الفاتيكان", NameEn = "Vatican City", IsActive = true, Code = "533", Iso2 = "va", DialCode = "39", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[140] = new Nationality { Id = 141, NameAr = "جبل طارق", NameEn = "Gibraltar", IsActive = true, Code = "534", Iso2 = "gi", DialCode = "350", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[141] = new Nationality { Id = 142, NameAr = "اوكرانيا", NameEn = "Ukraine", IsActive = true, Code = "536", Iso2 = "ua", DialCode = "380", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[142] = new Nationality { Id = 143, NameAr = "روسيا البيضاء", NameEn = "Byelorussia", IsActive = false, Code = "537", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[143] = new Nationality { Id = 144, NameAr = "ارمينيا", NameEn = "Armenia", IsActive = true, Code = "539", Iso2 = "am", DialCode = "374", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[144] = new Nationality { Id = 145, NameAr = "مولدافيا", NameEn = "Moldova", IsActive = true, Code = "540", Iso2 = "md", DialCode = "373", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[145] = new Nationality { Id = 146, NameAr = "جورجيا", NameEn = "Georgia", IsActive = true, Code = "541", Iso2 = "ge", DialCode = "995", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[146] = new Nationality { Id = 147, NameAr = "ليتوانيا", NameEn = "Lithuania", IsActive = true, Code = "542", Iso2 = "lt", DialCode = "370", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[147] = new Nationality { Id = 148, NameAr = "استونيا", NameEn = "Estonia", IsActive = true, Code = "543", Iso2 = "ee", DialCode = "372", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[148] = new Nationality { Id = 149, NameAr = "لاتفيا", NameEn = "Latvia", IsActive = true, Code = "544", Iso2 = "lv", DialCode = "371", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[149] = new Nationality { Id = 150, NameAr = "البوسنة والهرسك", NameEn = "Bosnia / Herzegovina", IsActive = true, Code = "545", Iso2 = "ba", DialCode = "387", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[150] = new Nationality { Id = 151, NameAr = "كرواتيا", NameEn = "Croatia", IsActive = true, Code = "546", Iso2 = "hr", DialCode = "385", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[151] = new Nationality { Id = 152, NameAr = "سلوفينيا", NameEn = "Slovenia", IsActive = true, Code = "547", Iso2 = "si", DialCode = "386", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[152] = new Nationality { Id = 153, NameAr = "مقدونيا", NameEn = "Macedonia", IsActive = true, Code = "549", Iso2 = "mk", DialCode = "389", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[153] = new Nationality { Id = 154, NameAr = "تشيك", NameEn = "Czech Republic", IsActive = true, Code = "552", Iso2 = "cz", DialCode = "420", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[154] = new Nationality { Id = 155, NameAr = "سلوفاكيا", NameEn = "Slovakia", IsActive = true, Code = "553", Iso2 = "sk", DialCode = "421", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[155] = new Nationality { Id = 156, NameAr = "جزر فيرو", NameEn = "Faroe Islands", IsActive = true, Code = "554", Iso2 = "fo", DialCode = "298", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[156] = new Nationality { Id = 157, NameAr = "ميتروبوليتان فرنسية", NameEn = "France Metropolitan", IsActive = false, Code = "555", Iso2 = "fx", DialCode = "33", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[157] = new Nationality { Id = 158, NameAr = "الولايات المتحدة", NameEn = "United States", IsActive = true, Code = "601", Iso2 = "us", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[158] = new Nationality { Id = 159, NameAr = "الارجنتين", NameEn = "Argentina", IsActive = true, Code = "602", Iso2 = "ar", DialCode = "54", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[159] = new Nationality { Id = 160, NameAr = "بربادوس", NameEn = "Barbados", IsActive = true, Code = "603", Iso2 = "bb", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[160] = new Nationality { Id = 161, NameAr = "البرازيل", NameEn = "Brazil", IsActive = true, Code = "604", Iso2 = "br", DialCode = "55", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[161] = new Nationality { Id = 162, NameAr = "بنما", NameEn = "Panama", IsActive = true, Code = "605", Iso2 = "pa", DialCode = "507", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[162] = new Nationality { Id = 163, NameAr = "ترينداد وتوباجو", NameEn = "Trinidad and Tobago", IsActive = true, Code = "606", Iso2 = "tt", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[163] = new Nationality { Id = 164, NameAr = "جامايكا", NameEn = "Jamaica", IsActive = true, Code = "607", Iso2 = "jm", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[164] = new Nationality { Id = 165, NameAr = "جوانا", NameEn = "Joanna", IsActive = false, Code = "608", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[165] = new Nationality { Id = 166, NameAr = "فنزويلا", NameEn = "Venezuela", IsActive = true, Code = "609", Iso2 = "ve", DialCode = "58", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[166] = new Nationality { Id = 167, NameAr = "كندا", NameEn = "Canada", IsActive = true, Code = "610", Iso2 = "ca", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[167] = new Nationality { Id = 168, NameAr = "كولمبيا", NameEn = "Columbia", IsActive = true, Code = "611", Iso2 = "co", DialCode = "57", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[168] = new Nationality { Id = 169, NameAr = "جزر البهاما", NameEn = "Bahamas", IsActive = true, Code = "612", Iso2 = "bs", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[169] = new Nationality { Id = 170, NameAr = "كوستاريكا", NameEn = "Costa Rica", IsActive = true, Code = "613", Iso2 = "cr", DialCode = "506", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[170] = new Nationality { Id = 171, NameAr = "كوبا", NameEn = "Cuba", IsActive = true, Code = "614", Iso2 = "cu", DialCode = "53", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[171] = new Nationality { Id = 172, NameAr = "دومينيكا", NameEn = "Dominica", IsActive = true, Code = "615", Iso2 = "dm", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[172] = new Nationality { Id = 173, NameAr = "جمهورية دمينكان", NameEn = "Republic Dominica", IsActive = true, Code = "616", Iso2 = "do", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[173] = new Nationality { Id = 174, NameAr = "السلفادور", NameEn = "El Salvador", IsActive = true, Code = "617", Iso2 = "sv", DialCode = "503", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[174] = new Nationality { Id = 175, NameAr = "جرانادا", NameEn = "Granada", IsActive = true, Code = "618", Iso2 = "gd", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[175] = new Nationality { Id = 176, NameAr = "جواتيمالا", NameEn = "Guatemala", IsActive = true, Code = "619", Iso2 = "gt", DialCode = "502", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[176] = new Nationality { Id = 177, NameAr = "هايتي", NameEn = "Haiti", IsActive = true, Code = "620", Iso2 = "ht", DialCode = "509", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[177] = new Nationality { Id = 178, NameAr = "هوندوراس", NameEn = "Honduras", IsActive = true, Code = "621", Iso2 = "hn", DialCode = "504", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[178] = new Nationality { Id = 179, NameAr = "المكسيك", NameEn = "Mexico", IsActive = true, Code = "622", Iso2 = "mx", DialCode = "52", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[179] = new Nationality { Id = 180, NameAr = "نيكاراجوا", NameEn = "Nicaragua", IsActive = true, Code = "623", Iso2 = "ni", DialCode = "505", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[180] = new Nationality { Id = 181, NameAr = "سانت لوسيا", NameEn = "Saint Lucia", IsActive = true, Code = "624", Iso2 = "lc", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[181] = new Nationality { Id = 182, NameAr = "سان فينسنت", NameEn = "Saint Vincent", IsActive = true, Code = "625", Iso2 = "vc", DialCode = "1", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[182] = new Nationality { Id = 183, NameAr = "بوليفيا", NameEn = "Bolivia", IsActive = true, Code = "626", Iso2 = "bo", DialCode = "591", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[183] = new Nationality { Id = 184, NameAr = "شيلي", NameEn = "Chile", IsActive = true, Code = "627", Iso2 = "cl", DialCode = "56", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[184] = new Nationality { Id = 185, NameAr = "اكوادور", NameEn = "Ecuador", IsActive = true, Code = "628", Iso2 = "ec", DialCode = "593", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[185] = new Nationality { Id = 186, NameAr = "باراجواي", NameEn = "Paraguay", IsActive = true, Code = "629", Iso2 = "py", DialCode = "595", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[186] = new Nationality { Id = 187, NameAr = "بيرو", NameEn = "Peru", IsActive = true, Code = "630", Iso2 = "pe", DialCode = "51", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[187] = new Nationality { Id = 188, NameAr = "استراليا", NameEn = "Australia", IsActive = true, Code = "701", Iso2 = "au", DialCode = "61", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[188] = new Nationality { Id = 189, NameAr = "نيوزيلندا", NameEn = "New Zealand", IsActive = true, Code = "702", Iso2 = "nz", DialCode = "64", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[189] = new Nationality { Id = 190, NameAr = "أوروغواي", NameEn = "Uruguay", IsActive = true, Code = "703", Iso2 = "yu", DialCode = "598", CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };

            return arrData;
        }
        public static Poster[] Posters()
        {
            Poster[] arrData = new Poster[2];
            arrData[0] = new Poster { Id = new Guid("f760c6af-419a-4378-9348-d6742ee62f9d"), TitleAr = "حديث", TitleEn = "Hadieth", Order = 1, ImageName = "banner1.png", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[1] = new Poster { Id = new Guid("08a67378-487c-40f3-9d53-5c2acb9cb78d"), TitleAr = "تجربة", TitleEn = "test", Order = 2, ImageName = "banner2.jpg", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            return arrData;
        }
        public static ProjectType[] ProjectTypes()
        {
            ProjectType[] arrData = new ProjectType[4];
            arrData[0] = new ProjectType { Id = new Guid("7a24cdc2-0f48-4e34-9c8e-745a9b06d0d7"), NameAr = "سقيا الماء", NameEn = "Water", ImageName = "water-dot.svg", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[1] = new ProjectType { Id = new Guid("9830a808-b80b-41d6-84fb-b186bbec6d45"), NameAr = "وجبة معتمر", NameEn = "Eating", ImageName = "food-method.svg", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[2] = new ProjectType { Id = new Guid("3060bbf4-415c-4767-8ad6-ba49685a31e1"), NameAr = "إفطار صائم", NameEn = "Break Fast", ImageName = "food.svg", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[3] = new ProjectType { Id = new Guid("02fa2cc2-2c01-402b-91fa-84526ca51edc"), NameAr = "زواج", NameEn = "Marriage", ImageName = "maried.svg", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            return arrData;
        }
        public static Role[] Roles()
        {
            Role[] arrData = new Role[4];
            arrData[0] = new Role { Id = 1, NameAr = "مدير عام النظام", NameEn = "Super System Admin", IsActive = false, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[1] = new Role { Id = 2, NameAr = "مدير النظام", NameEn = "System Admin", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[2] = new Role { Id = 3, NameAr = "صلاحيات الاعدادات", NameEn = "Setting Permission", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[3] = new Role { Id = 4, NameAr = "صلاحيات المستخدمين", NameEn = "Users Permission", IsActive = true, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            return arrData;
        }
        public static User[] Users()
        {
            User[] arrData = new User[2];

            using var hmac = new System.Security.Cryptography.HMACSHA512();
            var passwordSalt = hmac.Key;
            var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123"));
            arrData[0] = new User
            {
                Id = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"),
                UserName = "superadmin",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FullNameAr = "مدير عام النظام",
                FullNameEn = "Super System Admin",
                IsMale = true,
                Email = "superadmin@gmail.com",
                PhoneNumber = "0500000000",
                TwoFactorEnabled = true,
                IsEmployee = true,
                IsActive = true
            };
            arrData[1] = new User
            {
                Id = new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80"),
                UserName = "admin",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                FullNameAr = "مدير النظام",
                FullNameEn = "System Admin",
                IsMale = true,
                Email = "admin@yahoo.com",
                PhoneNumber = "0500000001",
                TwoFactorEnabled = true,
                IsEmployee = false,
                IsActive = true
            };
            return arrData;
        }
        public static UserRole[] UserRoles()
        {
            UserRole[] arrData = new UserRole[2];
            arrData[0] = new UserRole { Id = new Guid("e8de7eaf-13f0-4c77-b341-45f3cc10bc00"), UserId = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), RoleId = 1, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            arrData[1] = new UserRole { Id = new Guid("0b93bea1-eee3-4838-8513-7ade73017e5a"), UserId = new Guid("aa42bf46-7255-4347-a10d-9a0f58fc1c80"), RoleId = 2, CreatedBy = new Guid("83ee0b03-015e-4441-9294-8a4421d3b124"), CreatedDate = new DateTime(2022, 12, 1) };
            return arrData;
        }
    }
}
