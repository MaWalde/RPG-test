using System;
using System.Threading;

namespace Övningar_2
{
    internal class Program
    {
        public static List<int> rolls = new List<int>();
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hit enter to roll a d6!");
            Console.ReadKey();
            Console.WriteLine($"It lands on {Die6()}");*/
            /*Console.WriteLine("Ange antal d6 du vill rulla och ha totalen från: ");
            int ant = int.Parse(Console.ReadLine());
            Console.WriteLine($"Totalen av {ant} rullade d6 blev {SumD6(ant)}");*/
            
            Console.WriteLine($"                                       Välkommen till äventyret!\n" +
                $"                Du har i en närliggande by hört rykten om en förbannad plats i skogen med en helt\n" +
                $"                otrolig skatt, ingen boende i byn vågar sig in i nämnda skog och du har på egen \n" +
                $"                hand hittat din väg till ingången av en antik krypta.\n" +
                $"                Det ser otroligt mörkt ut där inne och en känsla av oråd gnager i ditt bakhuvud.\n\n" +
                $"                Tryck på enter för att gå in i den mörka kryptan");
            Console.ReadKey();
            Console.Write($"\n                Mörkret sluter sig om dig och du ångrar att du inte packat någon fackla.\n" +
                $"                Du navigerar dig med en hand på väggen och det djupa mörkret gör att ljudet av dina \n" +
                $"                fotsteg ekar som trummor i dina ögon, plöstligt försvinner väggen under din hand och du \n" +
                $"                tittar instinktivt åt det hållet. Du ser hur korridoren svänger abrupt 10 meter bort och \n" +
                $"                hur ena väggen är svagt upplyst av en ljuskälla du ännu inte kan se, du tar dig fram mot \n" +
                $"                hörnet och kikar mot ljuskällan och där på ett podium står en gyllene idol, det är den som\n" +
                $"                skiner lika starkt som om den vore gjord av eld. Du närmar dig idolen och ser dig försiktigt\n" +
                $"                om för att inte hamna i ett bakhåll eller rycka aktivera någon fälla, du ser till att kusten \n" +
                $"                är klar och lyfter idolen från sitt podium, inser att du aldrig hittat något mer värdefullt \n" +
                $"                i ditt liv och du planerar att använda den som ljuskälla för din väg ut ur kryptan. När du \n" +
                $"                går tillbaka genom gången du kommit genom inser du att väggarna är täckta med ett antikt \n" +
                $"                bildspråk och du kan inte hjälpa att studera dessa på din vandring ut, när du ser utgången \n" +
                $"                närma sig ser du en bild som på ett oförklarligt sätt skickar kalla kårar längs din rygg, \n" +
                $"                avbildad är en ohygglig best som placerar vad som endast kan vara idolen på podiet. Du hinner\n" +
                $"                inte mer än registrera detta innan du hör ett ljud bakom dig som får ditt blod att frysa i\n" +
                $"                dina ådror. Du vänder dig om och lägger ögonen på besten, denna fyller hela korridoren från r\n" +
                $"                vägg till vägg och golv till tak med sin stora kroppshydda. Du inser att den borde ha svårt att\n" +
                $"                röra sig här inne i den trånga korridoren och släpper idolen samtidigt som du drar ditt \n" +
                $"                kortsvärd och gör ett utfall.");
            Thread.Sleep(1000);
            Console.ReadKey();
            Attack(); 
            Console.ReadKey(); 
            Defend(); 
            Console.ReadKey(); 
            Attack(); 
            Console.ReadKey(); 
            Defend(); 
            Console.ReadKey(); 
            Attack(); 
            Console.ReadKey(); 
            Defend();
        }
        static int Attack() 
        {
            int dam = Die.D4() + Die.D4() - 2;
            Monster.Skada(dam);
            return dam;
        }
        static void Defend()
        {
            int dam = Die.D6() + Die.D6() + Die.D6() - Die.D6() - 2;
            Player.Skada(dam);
        }
        /*static int SumD6(int ant)
        {
            rolls.Clear();
            int sum = 0;
            for (int i = 0; i < ant; i++)
            {
                int roll = Die.D6();
                rolls.Add(roll);
                sum += roll;
            }
            return sum;
        }*/
    }
    class Monster
    {
        private static int hp;
        public Monster() 
        {
            hp = 30;
        }
        public static void Skada(int skada)
        {
            bool time1 = false; bool time2 = false;
            hp -= skada;
            if (hp <= 0)
            {
                Console.WriteLine("\n                Besten tar ett sista rosslande andetag när du sänker din klinga i dess hals\n" +
                    "                och sjunker ihop i en stilla hög på korridorens golv. Du plockar upp idolen och bestämmer dig\n" +
                    "                för att återvända efter bestens kropp efter du tagit dig till den närliggande byn efter hjälp\n" +
                    "                med dina egna skador.\n" +
                    "                När du kommit en bit från kryptans ingång hör du ett dovt mullrande, du ser tillbaka mot ingången\n " +
                    "                och där öppningen till kryptan nyss var är nu bara en klippa lik hundratals andra i den här skogen,\n " +
                    "                när du vänder dig om för att fortsätta tillbaka mot byn har du glömt ditt äventyr helt och hållet.\n " +
                    "                Idolen i din säck har du haft så länge du kan minnas och dina skador har du ådragit dig när du ramlat\n " +
                    "                ut för en klippa under din genväg genom skogen." +
                    "\n\n                Tack för att du tagit del av detta äventyr. På återseende!");
                Console.ReadKey();
                Environment.Exit(0);
            } //Klar, dödsrycket.
            if (time1==false)
            {
                if (hp <= 10)
                {
                    Console.WriteLine($"Du skadar besten för ytterliggare {skada} och du ser hur den rör sig trögare och" +
                        $" dens svarta blod rinner ymningt från de ställen du tidigare attackerat");
                    time1 = true;
                }
            } //Engångs flavour när besten går under 10 hp
            if (time2==false)
            {
                if (hp <= 20)
                {
                    Console.WriteLine($"Besten vrålar i smärta när du gör {skada} till den, den rör " +
                        $"sig allt mer desperat i korridorens trånga utrymme.");
                    time2= true;
                }
            } //Engångs flavour när besten går under 20 hp
            Console.WriteLine($"Du svingar ditt svärd och gör {skada}");
        }
    }
    class Player
    {
        private static int hp;
        public Player()
        {
            hp = 20;
        }
        public static void Skada(int skada)
        {
            bool time1 = false;
            hp -= skada;
            if (hp <= 0)
            {
                Console.WriteLine("\n                Du dog och det sista du ser är hur besten sänker sina fruktansvärda klor i ditt \n" +
                    "                ben och släpar dig tillbaka in i mörkret. Bättre lycka nästa gång!\n\n GAME OVER");
                Environment.Exit(0);
            } //Klar, dödsrycket
            if (!time1)
            {
                if (hp <= 10)
                {
                    Console.WriteLine($"Du tar {skada} i skada, du känner hur kroppen pumpar " +
                        $"ut adrenalin, för att motverka dina allt svårare skador.");
                    time1 = true;
                }
            }
            Console.WriteLine($"Besten sveper med sina klor och gör {skada}");
        }
    }
    class Die
    {
        public static int D4()
        {
            Random roll = new Random();
            int d4 = roll.Next(1, 5);
            return d4;
        }
        public static int D6()
        {
            Random roll = new Random();
            int d6 = roll.Next(1, 7);
            return d6;
        }
        public static int D8()
        {
            Random roll = new Random();
            int d8 = roll.Next(1, 9);
            return d8;
        }
        public static int D10()
        {
            Random roll = new Random();
            int d10 = roll.Next(1, 11);
            return d10;
        }
        public static int D12()
        {
            Random roll = new Random();
            int d12 = roll.Next(1, 13);
            return d12;
        }
        public static int D20()
        {
            Random roll = new Random();
            int d20 = roll.Next(1, 21);
            return d20;
        }
    }
}