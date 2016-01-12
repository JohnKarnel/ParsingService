using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HtmlAgilityPack;
using System.Net;
using System.IO;

namespace ParsingService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ParsingService" in both code and config file together.
    public class ParsingService : IParsingService
    {
        //функция парсинга указаных страниц по их url адресах
        public List<Bank> ParseThePages(List<string> urls)
        {
            List<Bank> lstOfBanks = new List<Bank>();
            foreach (var bankUrl in urls)
            {
                lstOfBanks.Add(ParseTheCurrentPage(bankUrl));
            }
            return lstOfBanks;
        }
        //функция парсинга одной страницы по ее url адресу
        private static Bank ParseTheCurrentPage(string url)
        {
            var html = GetHtml(url);
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            return GetBank(doc);
        }

        //функция получения обьекта Банка по указаному HTML документу
        private static Bank GetBank(HtmlDocument doc)
        {
            //информация о валюте в формате строки
            string info = "";
            //информация о валюте ы формате масива строк
            string[] kursInfo = new string[7];
            //получение нужной нам таблицы с HTML страницы
            var table = doc.DocumentNode.SelectNodes("//table")[0];
            //получаем имя банка
            info = doc.DocumentNode.SelectNodes("//title")[0].InnerText.Substring(11);
            info = info.Replace("&nbsp;", ";");
            //перебираем все валюты в таблице
            foreach (var tr_element in table.ChildNodes)
            {
                if (tr_element.Name == "tr")
                {
                    //Проверка на соответствие тега <td>
                    if (tr_element.ChildNodes[1].Name == "td")
                    {
                        //добавляем инфомацмию о покупке валюты
                        info += tr_element.ChildNodes[3].FirstChild.InnerText + ";";
                        //добавляем инфомацмию о продаже валюты
                        info += tr_element.ChildNodes[5].FirstChild.InnerText + ";";
                    }
                }
            }
            //разбиваем строку с информацией о банке в масив строк для удобного создания обьекта Банка
            if (info != "")
                kursInfo = info.Split(';');
            //возращаем обьект Банка
            return new Bank()
            {
                Name = kursInfo[0],
                UsdBuy = kursInfo[1],
                UsdSale = kursInfo[2],
                EurBuy = kursInfo[3],
                EurSale = kursInfo[4],
                RubBuy = kursInfo[5],
                RubSale = kursInfo[6]
            };
        }

        //Функция для получения HTML страницы
        private static string GetHtml(string url)
        {
            //Делаем запрос по указаному url
            HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
            //Получаем ответ по запросу
            HttpWebResponse responce = request.GetResponse() as HttpWebResponse;
            //Считываем ответ и переводим его в string формат
            StreamReader sr = new StreamReader(responce.GetResponseStream(), Encoding.Default);
            var html = sr.ReadToEnd();
            sr.Close();
            return html;
        }
    }
}
