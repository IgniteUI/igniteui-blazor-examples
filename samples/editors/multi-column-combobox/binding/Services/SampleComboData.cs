﻿using System;
using System.Collections.Generic;

namespace Infragistics.Samples
{
    public class ComboBoxItem
    {
        public string Country { get; set; }
        public string Continent { get; set; }
        public double Pop { get; set; }
    }

    public static class SampleComboData
    {
        public static List<ComboBoxItem> Create()
        {
            var data = new List<ComboBoxItem>
            {
                new ComboBoxItem { Continent = "Africa", Country = "Angola", Pop = 19618432 },
                new ComboBoxItem { Continent = "Africa", Country = "Benin", Pop = 9099922 },
                new ComboBoxItem { Continent = "Africa", Country = "Botswana", Pop = 2030738 },
                new ComboBoxItem { Continent = "Africa", Country = "Burkina Faso", Pop = 16967845 },
                new ComboBoxItem { Continent = "Africa", Country = "Burundi", Pop = 8575172 },
                new ComboBoxItem { Continent = "Africa", Country = "Cameroon", Pop = 20030362 },
                new ComboBoxItem { Continent = "Africa", Country = "Cape Verde", Pop = 500585 },
                new ComboBoxItem { Continent = "Africa", Country = "Central African Republic", Pop = 4486837 },
                new ComboBoxItem { Continent = "Africa", Country = "Chad", Pop = 11525496 },
                new ComboBoxItem { Continent = "Africa", Country = "Comoros", Pop = 753943 },
                new ComboBoxItem { Continent = "Africa", Country = "Cote Ivoire", Pop = 20152894 },
                new ComboBoxItem { Continent = "Africa", Country = "Djibouti", Pop = 905564 },
                new ComboBoxItem { Continent = "Africa", Country = "Equatorial Guinea", Pop = 720213 },
                new ComboBoxItem { Continent = "Africa", Country = "Eritrea", Pop = 5415280 },
                new ComboBoxItem { Continent = "Africa", Country = "Ethiopia", Pop = 84734262 },
                new ComboBoxItem { Continent = "Africa", Country = "Gabon", Pop = 1534262 },
                new ComboBoxItem { Continent = "Africa", Country = "Gambia", Pop = 1776103 },
                new ComboBoxItem { Continent = "Africa", Country = "Ghana", Pop = 24965816 },
                new ComboBoxItem { Continent = "Africa", Country = "Guinea", Pop = 10221808 },
                new ComboBoxItem { Continent = "Africa", Country = "Guinea-Bissau", Pop = 1547061 },
                new ComboBoxItem { Continent = "Africa", Country = "Kenya", Pop = 41609728 },
                new ComboBoxItem { Continent = "Africa", Country = "Lesotho", Pop = 2193843 },
                new ComboBoxItem { Continent = "Africa", Country = "Liberia", Pop = 4128572 },
                new ComboBoxItem { Continent = "Africa", Country = "Madagascar", Pop = 21315135 },
                new ComboBoxItem { Continent = "Africa", Country = "Malawi", Pop = 15380888 },
                new ComboBoxItem { Continent = "Africa", Country = "Mali", Pop = 15839538 },
                new ComboBoxItem { Continent = "Africa", Country = "Mauritania", Pop = 3541540 },
                new ComboBoxItem { Continent = "Africa", Country = "Mauritius", Pop = 1286051 },
                new ComboBoxItem { Continent = "Africa", Country = "Mozambique", Pop = 23929708 },
                new ComboBoxItem { Continent = "Africa", Country = "Namibia", Pop = 2324004 },
                new ComboBoxItem { Continent = "Africa", Country = "Niger", Pop = 16068994 },
                new ComboBoxItem { Continent = "Africa", Country = "Nigeria", Pop = 162470737 },
                new ComboBoxItem { Continent = "Africa", Country = "Rwanda", Pop = 10942950 },
                new ComboBoxItem { Continent = "Africa", Country = "Sao Tome and Principe", Pop = 168526 },
                new ComboBoxItem { Continent = "Africa", Country = "Senegal", Pop = 12767556 },
                new ComboBoxItem { Continent = "Africa", Country = "Seychelles", Pop = 86000 },
                new ComboBoxItem { Continent = "Africa", Country = "Sierra Leone", Pop = 5997486 },
                new ComboBoxItem { Continent = "Africa", Country = "South Africa", Pop = 50586757 },
                new ComboBoxItem { Continent = "Africa", Country = "South Sudan", Pop = 10314021 },
                new ComboBoxItem { Continent = "Africa", Country = "Sudan", Pop = 34318385 },
                new ComboBoxItem { Continent = "Africa", Country = "Swaziland", Pop = 1067773 },
                new ComboBoxItem { Continent = "Africa", Country = "Tanzania", Pop = 46218486 },
                new ComboBoxItem { Continent = "Africa", Country = "Togo", Pop = 6154813 },
                new ComboBoxItem { Continent = "Africa", Country = "Uganda", Pop = 34509205 },
                new ComboBoxItem { Continent = "Africa", Country = "Zambia", Pop = 13474959 },
                new ComboBoxItem { Continent = "Africa", Country = "Zimbabwe", Pop = 12754378 } ,
                new ComboBoxItem { Continent = "Africa", Country = "Congo", Pop = 4139748 },
                new ComboBoxItem { Continent = "Africa", Country = "Congo, Dem. Rep.", Pop = 67757577 },
                new ComboBoxItem { Continent = "Asia", Country = "Bangladesh", Pop = 150493658 },
                new ComboBoxItem { Continent = "Asia", Country = "Bhutan", Pop = 738267 },
                new ComboBoxItem { Continent = "Asia", Country = "Brunei", Pop = 405938 },
                new ComboBoxItem { Continent = "Asia", Country = "Cambodia", Pop = 14305183 },
                new ComboBoxItem { Continent = "Asia", Country = "China", Pop = 1344130000 },
                new ComboBoxItem { Continent = "Asia", Country = "India", Pop = 1241491960 },
                new ComboBoxItem { Continent = "Asia", Country = "Indonesia", Pop = 242325638 },
                new ComboBoxItem { Continent = "Asia", Country = "Japan", Pop = 127817277 },
                new ComboBoxItem { Continent = "Asia", Country = "Kazakhstan", Pop = 16558676 },
                new ComboBoxItem { Continent = "Asia", Country = "Kyrgyz Republic", Pop = 5514600 },
                new ComboBoxItem { Continent = "Asia", Country = "Noth Korea", Pop = 24451285 },
                new ComboBoxItem { Continent = "Asia", Country = "South Korea", Pop = 49779000 },
                new ComboBoxItem { Continent = "Asia", Country = "Macao", Pop = 555731 },
                new ComboBoxItem { Continent = "Asia", Country = "Hong Kong", Pop = 7071600 },
                new ComboBoxItem { Continent = "Asia", Country = "Lao PDR", Pop = 6288037 },
                new ComboBoxItem { Continent = "Asia", Country = "Malaysia", Pop = 28859154 },
                new ComboBoxItem { Continent = "Asia", Country = "Maldives", Pop = 320081 },
                new ComboBoxItem { Continent = "Asia", Country = "Mongolia", Pop = 2800114 },
                new ComboBoxItem { Continent = "Asia", Country = "Myanmar", Pop = 48336763 },
                new ComboBoxItem { Continent = "Asia", Country = "Nepal", Pop = 30485798 },
                new ComboBoxItem { Continent = "Asia", Country = "Philippines", Pop = 94852030 },
                new ComboBoxItem { Continent = "Asia", Country = "Singapore", Pop = 5183700 },
                new ComboBoxItem { Continent = "Asia", Country = "Sri Lanka", Pop = 20869000 },
                new ComboBoxItem { Continent = "Asia", Country = "Tajikistan", Pop = 6976958 },
                new ComboBoxItem { Continent = "Asia", Country = "Thailand", Pop = 69518555 },
                new ComboBoxItem { Continent = "Asia", Country = "Turkmenistan", Pop = 5105301 },
                new ComboBoxItem { Continent = "Asia", Country = "Uzbekistan", Pop = 29341200 },
                new ComboBoxItem { Continent = "Asia", Country = "Vietnam", Pop = 87840000 },
                new ComboBoxItem { Continent = "Central America", Country = "Antigua and Barbuda", Pop = 89612 },
                new ComboBoxItem { Continent = "Central America", Country = "Aruba", Pop = 108141 },
                new ComboBoxItem { Continent = "Central America", Country = "Bahamas", Pop = 347176 },
                new ComboBoxItem { Continent = "Central America", Country = "Barbados", Pop = 273925 },
                new ComboBoxItem { Continent = "Central America", Country = "Belize", Pop = 356600 },
                new ComboBoxItem { Continent = "Central America", Country = "Bermuda", Pop = 64700 },
                new ComboBoxItem { Continent = "Central America", Country = "Cayman Islands", Pop = 56729 },
                new ComboBoxItem { Continent = "Central America", Country = "Costa Rica", Pop = 4726575 },
                new ComboBoxItem { Continent = "Central America", Country = "Cuba", Pop = 11253665 },
                new ComboBoxItem { Continent = "Central America", Country = "Curacao", Pop = 145619 },
                new ComboBoxItem { Continent = "Central America", Country = "Dominica", Pop = 67675 },
                new ComboBoxItem { Continent = "Central America", Country = "Dominican Republic", Pop = 10056181 },
                new ComboBoxItem { Continent = "Central America", Country = "Faeroe Islands", Pop = 48863 },
                new ComboBoxItem { Continent = "Central America", Country = "Grenada", Pop = 104890 },
                new ComboBoxItem { Continent = "Central America", Country = "Guam", Pop = 182111 },
                new ComboBoxItem { Continent = "Central America", Country = "Guatemala", Pop = 14757316 },
                new ComboBoxItem { Continent = "Central America", Country = "Haiti", Pop = 10123787 },
                new ComboBoxItem { Continent = "Central America", Country = "Honduras", Pop = 7754687 },
                new ComboBoxItem { Continent = "Central America", Country = "Jamaica", Pop = 2706500 },
                new ComboBoxItem { Continent = "Central America", Country = "Nicaragua", Pop = 5869859 },
                new ComboBoxItem { Continent = "Central America", Country = "Northern Mariana Islands", Pop = 61174 },
                new ComboBoxItem { Continent = "Central America", Country = "Panama", Pop = 3571185 },
                new ComboBoxItem { Continent = "Central America", Country = "St. Kitts and Nevis", Pop = 53051 },
                new ComboBoxItem { Continent = "Central America", Country = "St. Lucia", Pop = 176000 },
                new ComboBoxItem { Continent = "Central America", Country = "St. Vincent and the Grenadines", Pop = 109365 },
                new ComboBoxItem { Continent = "Central America", Country = "Trinidad and Tobago", Pop = 1346350 },
                new ComboBoxItem { Continent = "Central America", Country = "Turks and Caicos Islands", Pop = 39184 },
                new ComboBoxItem { Continent = "Central America", Country = "Virgin Islands (U.S.)", Pop = 109666 },
                new ComboBoxItem { Continent = "Central America", Country = "El Salvador", Pop = 6227491 },
                new ComboBoxItem { Continent = "Central America", Country = "Puerto Rico", Pop = 3706690 },
                new ComboBoxItem { Continent = "Europe", Country = "Albania", Pop = 3215988 },
                new ComboBoxItem { Continent = "Europe", Country = "Andorra", Pop = 86165 },
                new ComboBoxItem { Continent = "Europe", Country = "Armenia", Pop = 3100236 },
                new ComboBoxItem { Continent = "Europe", Country = "Austria", Pop = 8423635 },
                new ComboBoxItem { Continent = "Europe", Country = "Belarus", Pop = 9473000 },
                new ComboBoxItem { Continent = "Europe", Country = "Belgium", Pop = 11020952 },
                new ComboBoxItem { Continent = "Europe", Country = "Bosnia and Herzegovina", Pop = 3752228 },
                new ComboBoxItem { Continent = "Europe", Country = "Bulgaria", Pop = 7348328 },
                new ComboBoxItem { Continent = "Europe", Country = "Channel Islands", Pop = 153876 },
                new ComboBoxItem { Continent = "Europe", Country = "Croatia", Pop = 4403000 },
                new ComboBoxItem { Continent = "Europe", Country = "Cyprus", Pop = 1116564 },
                new ComboBoxItem { Continent = "Europe", Country = "Czechia", Pop = 10496088 },
                new ComboBoxItem { Continent = "Europe", Country = "Denmark", Pop = 5570572 },
                new ComboBoxItem { Continent = "Europe", Country = "Estonia", Pop = 1339928 },
                new ComboBoxItem { Continent = "Europe", Country = "Finland", Pop = 5388272 },
                new ComboBoxItem { Continent = "Europe", Country = "France", Pop = 65433714 },
                new ComboBoxItem { Continent = "Europe", Country = "Georgia", Pop = 4486000 },
                new ComboBoxItem { Continent = "Europe", Country = "Germany", Pop = 81797673 },
                new ComboBoxItem { Continent = "Europe", Country = "Greece", Pop = 11300410 },
                new ComboBoxItem { Continent = "Europe", Country = "Hungary", Pop = 9971727 },
                new ComboBoxItem { Continent = "Europe", Country = "Iceland", Pop = 319014 },
                new ComboBoxItem { Continent = "Europe", Country = "Ireland", Pop = 4576317 },
                new ComboBoxItem { Continent = "Europe", Country = "Isle of Man", Pop = 83327 },
                new ComboBoxItem { Continent = "Europe", Country = "Italy", Pop = 60723603 },
                new ComboBoxItem { Continent = "Europe", Country = "Kosovo", Pop = 1802765 },
                new ComboBoxItem { Continent = "Europe", Country = "Latvia", Pop = 2058184 },
                new ComboBoxItem { Continent = "Europe", Country = "Liechtenstein", Pop = 36304 },
                new ComboBoxItem { Continent = "Europe", Country = "Lithuania", Pop = 3030173 },
                new ComboBoxItem { Continent = "Europe", Country = "Luxembourg", Pop = 518252 },
                new ComboBoxItem { Continent = "Europe", Country = "Malta", Pop = 415654 },
                new ComboBoxItem { Continent = "Europe", Country = "Moldova", Pop = 3559000 },
                new ComboBoxItem { Continent = "Europe", Country = "Monaco", Pop = 35427 },
                new ComboBoxItem { Continent = "Europe", Country = "Montenegro", Pop = 632261 },
                new ComboBoxItem { Continent = "Europe", Country = "Netherlands", Pop = 16693074 },
                new ComboBoxItem { Continent = "Europe", Country = "Norway", Pop = 4953088 },
                new ComboBoxItem { Continent = "Europe", Country = "Poland", Pop = 38534157 },
                new ComboBoxItem { Continent = "Europe", Country = "Portugal", Pop = 10556999 },
                new ComboBoxItem { Continent = "Europe", Country = "Romania", Pop = 21384832 },
                new ComboBoxItem { Continent = "Europe", Country = "Russian", Pop = 142960000 },
                new ComboBoxItem { Continent = "Europe", Country = "San Marino", Pop = 31735 },
                new ComboBoxItem { Continent = "Europe", Country = "Serbia", Pop = 7258745 },
                new ComboBoxItem { Continent = "Europe", Country = "Sint Maarten", Pop = 36609 },
                new ComboBoxItem { Continent = "Europe", Country = "Slovak Republic", Pop = 5398384 },
                new ComboBoxItem { Continent = "Europe", Country = "Slovenia", Pop = 2052843 },
                new ComboBoxItem { Continent = "Europe", Country = "Spain", Pop = 46174601 },
                new ComboBoxItem { Continent = "Europe", Country = "St. Martin (French part)", Pop = 30615 },
                new ComboBoxItem { Continent = "Europe", Country = "Sweden", Pop = 9449213 },
                new ComboBoxItem { Continent = "Europe", Country = "Switzerland", Pop = 7912398 },
                new ComboBoxItem { Continent = "Europe", Country = "Ukraine", Pop = 45706100 },
                new ComboBoxItem { Continent = "Europe", Country = "United Kingdom", Pop = 62744081 },
                new ComboBoxItem { Continent = "Europe", Country = "Macedonia, FYR", Pop = 2063893 },
                new ComboBoxItem { Continent = "Middle East", Country = "Afghanistan", Pop = 35320445 },
                new ComboBoxItem { Continent = "Middle East", Country = "Algeria", Pop = 35980193 },
                new ComboBoxItem { Continent = "Middle East", Country = "Azerbaijan", Pop = 9173082 },
                new ComboBoxItem { Continent = "Middle East", Country = "Bahrain", Pop = 1323535 },
                new ComboBoxItem { Continent = "Middle East", Country = "Iraq", Pop = 32961959 },
                new ComboBoxItem { Continent = "Middle East", Country = "Israel", Pop = 7765900 },
                new ComboBoxItem { Continent = "Middle East", Country = "Jordan", Pop = 6181000 },
                new ComboBoxItem { Continent = "Middle East", Country = "Kuwait", Pop = 2818042 },
                new ComboBoxItem { Continent = "Middle East", Country = "Lebanon", Pop = 4259405 },
                new ComboBoxItem { Continent = "Middle East", Country = "Libya", Pop = 6422772 },
                new ComboBoxItem { Continent = "Middle East", Country = "Morocco", Pop = 32272974 },
                new ComboBoxItem { Continent = "Middle East", Country = "Oman", Pop = 2846145 },
                new ComboBoxItem { Continent = "Middle East", Country = "Pakistan", Pop = 176745364 },
                new ComboBoxItem { Continent = "Middle East", Country = "Qatar", Pop = 1870041 },
                new ComboBoxItem { Continent = "Middle East", Country = "Saudi Arabia", Pop = 28082541 },
                new ComboBoxItem { Continent = "Middle East", Country = "Somalia", Pop = 9556873 },
                new ComboBoxItem { Continent = "Middle East", Country = "Syrian Arab Republic", Pop = 20820311 },
                new ComboBoxItem { Continent = "Middle East", Country = "Tunisia", Pop = 10673800 },
                new ComboBoxItem { Continent = "Middle East", Country = "Turkey", Pop = 73639596 },
                new ComboBoxItem { Continent = "Middle East", Country = "United Arab Emirates", Pop = 7890924 },
                new ComboBoxItem { Continent = "Middle East", Country = "West Bank and Gaza", Pop = 3927051 },
                new ComboBoxItem { Continent = "Middle East", Country = "Yemen", Pop = 24799880 },
                new ComboBoxItem { Continent = "Middle East", Country = "Iran", Pop = 74798599 },
                new ComboBoxItem { Continent = "Middle East", Country = "Egypt.", Pop = 82536770 },
                new ComboBoxItem { Continent = "North America", Country = "Canada", Pop = 34483975 },
                new ComboBoxItem { Continent = "North America", Country = "Greenland", Pop = 56840 },
                new ComboBoxItem { Continent = "North America", Country = "Mexico", Pop = 114793341 },
                new ComboBoxItem { Continent = "North America", Country = "United States", Pop = 311591917 },
                new ComboBoxItem { Continent = "Oceania", Country = "American Samoa", Pop = 69543 },
                new ComboBoxItem { Continent = "Oceania", Country = "Australia", Pop = 22323900 },
                new ComboBoxItem { Continent = "Oceania", Country = "Fiji", Pop = 868406 },
                new ComboBoxItem { Continent = "Oceania", Country = "French Polynesia", Pop = 273777 },
                new ComboBoxItem { Continent = "Oceania", Country = "Kiribati", Pop = 101093 },
                new ComboBoxItem { Continent = "Oceania", Country = "Marshall Islands", Pop = 54816 },
                new ComboBoxItem { Continent = "Oceania", Country = "New Caledonia", Pop = 254024 },
                new ComboBoxItem { Continent = "Oceania", Country = "New Zealand", Pop = 4405200 },
                new ComboBoxItem { Continent = "Oceania", Country = "Palau", Pop = 20609 },
                new ComboBoxItem { Continent = "Oceania", Country = "Papua New Guinea", Pop = 7013829 },
                new ComboBoxItem { Continent = "Oceania", Country = "Samoa", Pop = 183874 },
                new ComboBoxItem { Continent = "Oceania", Country = "Timor-Leste", Pop = 1175880 },
                new ComboBoxItem { Continent = "Oceania", Country = "Tonga", Pop = 104509 },
                new ComboBoxItem { Continent = "Oceania", Country = "Tuvalu", Pop = 9847 },
                new ComboBoxItem { Continent = "Oceania", Country = "Vanuatu", Pop = 245619 },
                new ComboBoxItem { Continent = "Oceania", Country = "Micronesia", Pop = 111542 },
                new ComboBoxItem { Continent = "Oceania", Country = "Solomon Islands", Pop = 552267 },
                new ComboBoxItem { Continent = "South America", Country = "Argentina", Pop = 40764561 },
                new ComboBoxItem { Continent = "South America", Country = "Bolivia", Pop = 10088108 },
                new ComboBoxItem { Continent = "South America", Country = "Brazil", Pop = 196655014 },
                new ComboBoxItem { Continent = "South America", Country = "Chile", Pop = 17269525 },
                new ComboBoxItem { Continent = "South America", Country = "Colombia", Pop = 46927125 },
                new ComboBoxItem { Continent = "South America", Country = "Ecuador", Pop = 14666055 },
                new ComboBoxItem { Continent = "South America", Country = "Guyana", Pop = 756040 },
                new ComboBoxItem { Continent = "South America", Country = "Paraguay", Pop = 6568290 },
                new ComboBoxItem { Continent = "South America", Country = "Peru", Pop = 29399817 },
                new ComboBoxItem { Continent = "South America", Country = "Suriname", Pop = 529419 },
                new ComboBoxItem { Continent = "South America", Country = "Uruguay", Pop = 3368595 },
                new ComboBoxItem { Continent = "South America", Country = "Venezuela", Pop = 29278000 },
            };

            return data;
        }
    }
}