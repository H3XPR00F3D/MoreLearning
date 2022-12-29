using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using HtmlAgilityPack;


public class Scrapes
{
    static void Greece()
    {
        HtmlWeb web = new HtmlWeb();
        HtmlDocument doc = web.Load("https://en.wikipedia.org/wiki/Greece");

        var HeaderNames =
        doc.DocumentNode.SelectNodes("//span[@class='toctext']");

        var titles = new List<Row>();

        foreach (var item in HeaderNames)
        {
            titles.Add(new Row { Title = item.InnerText });
        }
        using (var writer = new StreamWriter("Scraping_Results/Greece.txt"))
        using (var writer2 = new StreamWriter("Scraping_Results/Greece.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))


        {
            csv.WriteRecords(titles);
        }

    }
    public class Row
    {
        public string Title { get; set; }
    }
}
