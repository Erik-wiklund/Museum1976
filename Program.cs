using System;

namespace Museet
{
    class Program
    {
        static void Main(string[] args)
        {

            bool loop = true;

            Console.WriteLine("*********************************");
            Console.WriteLine("Välkommen till museet för konst!");
            Console.WriteLine("Välj det rum du vill gå till!");
            Console.WriteLine("[1] Renässansen!");
            Console.WriteLine("[2] Poesi!");
            Console.WriteLine("[3] Kända fotografier!");
            Console.WriteLine("[4] Under uppbyggnad!");
            Console.WriteLine("[5] Fikarummet!");
            Console.WriteLine("[6] Realism!");
            Console.WriteLine("[7] Skulpturer!");
            Console.WriteLine("[8] Gå ut från museet!");
            Console.WriteLine("*********************");

            while (loop == true)
            {

                Console.Write("Val: ");
                string väljrum = Console.ReadLine();
                Console.WriteLine();

                if (väljrum == "1" || väljrum == "ett" || väljrum == "Ett")
                {
                    Console.WriteLine("Välkommen till renässansrummet!");
                    Console.WriteLine("I detta rum kommer du få läsa om Nattvarden av Leonardo da Vinci.");
                    Console.WriteLine();
                    Console.WriteLine("Nattvarden är konstnärens visuella representation av en händelse ");
                    Console.WriteLine("nedskriven i alla fyra av bibelns evangelier. Nämligen kvällen ");
                    Console.WriteLine("då Jesus blev förrådd av en av sina lärjungar. ");
                    Console.WriteLine("I mitten ser vi Jesus framför ett fulldukat bort med sina lärjungar omkring sig.");
                    Console.WriteLine();

                    Console.WriteLine("Även i rummet kan vi läsa om Mona Lisa, också av Leonardo da Vinci.");
                    Console.WriteLine();
                    Console.WriteLine("Ett av världens mest berömda porträtt som enligt traditionen ska ");
                    Console.WriteLine("föreställa florentinskan Lisa Gherardini.");
                    Console.WriteLine();

                    Console.WriteLine("Tryck på Enter för att se menyn igen. . .");
                    Console.ReadKey();

                    Console.WriteLine("Välj ett annat rum att gå till, eller lämna museet.");
                    Console.WriteLine();

                    Console.WriteLine("[2] Poesi!");
                    Console.WriteLine("[3] Kända fotografier!");
                    Console.WriteLine("[4] Under uppbyggnad!");
                    Console.WriteLine("[5] Fikarummet!");
                    Console.WriteLine("[6] Realism!");
                    Console.WriteLine("[7] Skulpturer!");
                    Console.WriteLine("[8] Gå ut från museet!");
                    Console.WriteLine();

                }
                else if (väljrum == "2" || väljrum == "två" || väljrum == "Två")
                {
                    Console.WriteLine("Välkommen till poesirummet!");
                    Console.WriteLine("Här inne kommer du att få läsa om några kända författare och deras dikter.");
                    Console.WriteLine();
                    Console.WriteLine("Tom Sharpe, född 1928 i London. Var en brittisk författare.");
                    Console.WriteLine("En av hans dikter kunde låta såhär: KÄRLEK ÄR BRA OM DU INTE LÅTER DIG SKADAS.");
                    Console.WriteLine();

                    Console.WriteLine("J.Galsworthy, född 1867 i sydvästra London. Brittisk författare, som mottog nobelpriset i litteratur 1932.");
                    Console.WriteLine("En av hans dikter kunde låta såhär: KÄRLEK SOM FRUKTAR ETT HINDER ÄR INTE KÄRLEK");
                    Console.WriteLine();

                    Console.WriteLine("Byron, även känd som Lord Byron. Född 1788 i London, död 1824 i Grekland. Brittisk poet och känd för sin så kallade satir.");
                    Console.WriteLine("En av hans dikter kunde låta såhär: DÄR DE ÄLSKAR OSS - DET FINNS BARA ETT HJÄRTAT CENTRUM.");
                    Console.WriteLine();

                    Console.WriteLine("Tryck på Enter för att se menyn igen. . .");
                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine("Välj ett annat rum att gå till, eller lämna museet.");
                    Console.WriteLine("[1] Renässansen!");
                    Console.WriteLine("[3] Kända fotografier!");
                    Console.WriteLine("[4] Under uppbyggnad!");
                    Console.WriteLine("[5] Fikarummet!");
                    Console.WriteLine("[6] Realism!");
                    Console.WriteLine("[7] Skulpturer!");
                    Console.WriteLine("[8] Gå ut från museet!");
                    Console.WriteLine();
                }
                else if (väljrum == "3" || väljrum == "tre" || väljrum == "Tre")
                {
                    Console.WriteLine("Välkommen till kända fotografier!");
                    Console.WriteLine("Här kommer du att få läsa om några av värdlens mest kända fotografier och lite fakta om dem.");
                    Console.WriteLine();

                    Console.WriteLine("Neil Armstrong på månen!");
                    Console.WriteLine("Första människa att gå på månen. Åkte då upp med Apollo 11 1969, vilket vi alla fick lära oss det kända citatet: That's one small step for (a) man, one giant leap for mankind");
                    Console.WriteLine();

                    Console.WriteLine("Mohammed Ali vs Sonny Liston!");
                    Console.WriteLine("I ett av dom största sporthändelserna genom tiderna, 1965 och 1965, ser vi här ");
                    Console.WriteLine("Mohammed Ali stå segrande över sin motståndare, Sonny Liston.");
                    Console.WriteLine();

                    Console.WriteLine("The Beatles Abbey road!");
                    Console.WriteLine("Den mycket kända bilden i samband med deras album 1969, ");
                    Console.WriteLine("albumet är även uppkallat efter studion där dom spelade in deras kända låtar.");
                    Console.WriteLine();

                    Console.WriteLine("Tryck på Enter för att se menyn igen. . .");
                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine("Välj ett annat rum att gå till, eller lämna museet.");
                    Console.WriteLine("[1] Renässansen!");
                    Console.WriteLine("[2] Poesi!");
                    Console.WriteLine("[4] Under uppbyggnad!");
                    Console.WriteLine("[5] Fikarummet!");
                    Console.WriteLine("[6] Realism!");
                    Console.WriteLine("[7] Skulpturer!");
                    Console.WriteLine("[8] Gå ut från museet!");
                    Console.WriteLine();

                }
                else if (väljrum == "4" || väljrum == "fyra" || väljrum == "Fyra")
                {
                    Console.WriteLine("Välkommen till rummet som är under uppbyggnad!");
                    Console.WriteLine("Om du väljer att vänta så läs då en bok så länge!");
                    Console.WriteLine("Men i framtiden så kommer detta rum innehålla ännu ett konstverk!");
                    Console.WriteLine();

                    Console.WriteLine("Tryck på Enter för att se menyn igen. . .");
                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine("Välj ett annat rum att gå till, eller lämna museet.");
                    Console.WriteLine("[1] Renässansen!");
                    Console.WriteLine("[3] Kända fotografier!");
                    Console.WriteLine("[2] Poesi!");
                    Console.WriteLine("[5] Fikarummet!");
                    Console.WriteLine("[6] Realism!");
                    Console.WriteLine("[7] Skulpturer!");
                    Console.WriteLine("[8] Gå ut från museet!");
                    Console.WriteLine();
                }
                else if (väljrum == "5" || väljrum == "fem" || väljrum == "Fem")
                {
                    Console.WriteLine("Välkommen till fikarummet!");
                    Console.WriteLine("Tyvärr måste vi meddela att vi än inte kan erbjuda fika genom datorn.");
                    Console.WriteLine("Men varför inte ta en kopp kaffe hemma och fortsätta din tur i museet?");
                    Console.WriteLine();

                    Console.WriteLine("Tryck på Enter för att se menyn igen. . .");
                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine("Välj ett annat rum att gå till, eller lämna museet.");
                    Console.WriteLine("[1] Renässansen!");
                    Console.WriteLine("[2] Poesi!");
                    Console.WriteLine("[3] Kända fotografier!");
                    Console.WriteLine("[4] Under uppbyggnad!");
                    Console.WriteLine("[6] Realism!");
                    Console.WriteLine("[7] Skulpturer!");
                    Console.WriteLine("[8] Gå ut från museet!");
                    Console.WriteLine();
                }
                else if (väljrum == "6" || väljrum == "sex" || väljrum == "Sex")
                {
                    Console.WriteLine("Välkommen till realism!");
                    Console.WriteLine("Här inne kommer du få läsa om konst som handlar om att den sanningsenlig och inte på något sätt förskönad");
                    Console.WriteLine();

                    Console.WriteLine("Första målningen handlar om Stenbrytarna, av Gustave Courbet.");
                    Console.WriteLine();
                    Console.WriteLine("Tavlan föreställer två bönder, en ung och en äldre, arbetande i ett stenbrott.");
                    Console.WriteLine("Tavlan blev dessvärre förstör under en flybombning under andra världskriget.");
                    Console.WriteLine("Det vi uppvisar här är en väldigt välgjord kopia.");
                    Console.WriteLine();

                    Console.WriteLine("Den andra målningen heter Cimabues celebrated Madonna!");
                    Console.WriteLine("Tavlan visar en scen från 1500-talets konsthistoriker Giorgio Vasaris beskrivning av");
                    Console.WriteLine("processionen från 1200-talet av en altartavla av Madonna och Child genom gatorna i Florens");
                    Console.WriteLine("Är en målning gjord av Lord Eighton mellan 1853 till 1855. Den är fem meter bred och över två meter hög.");
                    Console.WriteLine("Sedan 1988 har den funnits att skåda vid National Gallery i London,");
                    Console.WriteLine("vilket är ett lån från Ryoal Collection där den har hängt tidigare.");
                    Console.WriteLine("Dock så fick vårat museum låna den ett tag.");
                    Console.WriteLine();

                    Console.WriteLine("Tryck på Enter för att se menyn igen. . .");
                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine("Välj ett annat rum att gå till, eller lämna museet.");
                    Console.WriteLine("[1] Renässansen!");
                    Console.WriteLine("[2] Poesi!");
                    Console.WriteLine("[3] Kända fotografier!");
                    Console.WriteLine("[4] Under uppbyggnad!");
                    Console.WriteLine("[5] Fikarummet!");
                    Console.WriteLine("[7] Skulpturer!");
                    Console.WriteLine("[8] Gå ut från museet!");
                    Console.WriteLine();
                }
                else if (väljrum == "7" || väljrum == "sju" || väljrum == "Sju")
                {
                    Console.WriteLine("Välkommen till skulpturer!");
                    Console.WriteLine("Davidstatyn!");
                    Console.WriteLine("Statyn är utförd av skulptören Michelangelo. Föreställer David i Gamla Testamentet.");
                    Console.WriteLine("Är huggen i Carraramarmor och kom till mellan 1501 och 1504, den är 5.17 meter hög.");
                    Console.WriteLine();

                    Console.WriteLine("Frihetsgudinnan!");
                    Console.WriteLine("Är en staty på Liberty Island vid Hudsonfloden i New Yourk. Invigdes 28 oktober 1886.");
                    Console.WriteLine("Var en gåva från det franska folket som en symbol för att fira hundraårsminnet av USA:s självständighet.");
                    Console.WriteLine("Dock så får ju inte statyn plats här inne, så det ni får skåda är en staty i mindre skala");
                    Console.WriteLine();

                    Console.WriteLine("Tryck på Enter för att se menyn igen. . .");
                    Console.ReadKey();
                    Console.WriteLine();

                    Console.WriteLine("Välj ett annat rum att gå till, eller lämna museet.");
                    Console.WriteLine("[1] Renässansen!");
                    Console.WriteLine("[2] Poesi!");
                    Console.WriteLine("[3] Kända fotografier!");
                    Console.WriteLine("[4] Under uppbyggnad!");
                    Console.WriteLine("[5] Fikarummet!");
                    Console.WriteLine("[6] Realism!");
                    Console.WriteLine("[8] Gå ut från museet!");
                    Console.WriteLine();
                }
                else if (väljrum == "8" || väljrum == "åtta" || väljrum == "Åtta")
                {
                    Console.WriteLine("Hoppas du haft en trevlig tid på museet.");
                    Console.WriteLine("Vi ser fram emot ditt nästa besök.");
                    Console.WriteLine();
                    Console.WriteLine("Tryck på Enter för att avsluta ditt virtuella besök...");
                    Console.ReadKey();

                    loop = false;
                }
                else
                {
                    Console.WriteLine("Du gjorde ett felaktigt val, vänligen gör ett nytt val.");
                }

            }

        }

    }
}