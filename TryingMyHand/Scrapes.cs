using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using HtmlAgilityPack;
using MoreLearning;

public class Scrapes
{

    public static void RunScrapes()
    {
        int selection=0;

        UserPrompts.ScrapePrompt();


        while (selection == 0)
        {

            Console.WriteLine("Please make another choice.");

            Console.WriteLine();
            selection = Convert.ToInt32(Console.ReadLine());


            switch (selection)
            {
                case 1:
                    Greece();
                    break;
                case 2:
                    AoS_DoK();
                    break;
                case 9:
                    UserPrompts.ExitApp();
                    Environment.Exit(0);
                    break;
                default:
                    UserPrompts.Prompt();
                    selection = 0;
                    break;
            }

            UserPrompts.ExitApp();

        }
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

        static void AoS_DoK()
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load("https://wahapedia.ru/aos3/factions/daughters-of-khaine/warscrolls.html");

            var UnitName =
            doc.DocumentNode.SelectNodes("//h3[@class='wsHeader']");

            var UnitWounds =
doc.DocumentNode.SelectNodes("//div[@class='wsWounds']");

            var titles = new List<Row>();
            var wounds = new List<Row>();

            foreach (var item in UnitName)
            {
                titles.Add(new Row { Title = item.InnerText });
            }

            foreach(var item in UnitWounds)
            {
                wounds.Add(new Row { Wounds = item.InnerText });
            }
            using (var writer = new StreamWriter("Scraping_Results/AoS_DoK.txt"))
            using (var writer2 = new StreamWriter("Scraping_Results/AoS_DoK.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))

            {
                csv.WriteRecords(titles);
                Console.WriteLine("Got Names");
                csv.WriteRecords(wounds);
                Console.WriteLine("Got Wounds");
            }



        }

    }
    public class Row
    {
        public string Title { get; set; }
        public string Wounds { get; set; }
    }
}
