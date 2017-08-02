using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1._2_Växelpengar
{


    class Program
    {

        // Variables with get set Properties in one
        public double cost { get; private set; }
        public double cashReceived { get; private set; }
        public double toBeReturned { get; private set; }
        public double outputValue { get; private set; }
        public int amountOfMoneyBack { get; private set; }

        public double remainderAmountThousends { get; private set; }
        public double remainderAmountFivehundred { get; private set; }
        public double remainderAmountOfHundred { get; private set; }
        public double remainderAmountOfFifty { get; private set; }
        public double remainderAmountOfTwenty { get; private set; }
        public double remainderAmountOfTen { get; private set; }
        public double remainderAmountOfFive { get; private set; }
        public double remainderAmountOfOne { get; private set; }
        public double remainderAmountFiftyOre { get; private set; }

        public int amountOfThousends { get; private set; }
        public int amountOfFiveHundred { get; private set; }
        public int amountOfHundred { get; private set; }
        public int amountOfFifty { get; private set; }
        public int amountOfTwenty { get; private set; }
        public int amountOfTen { get; private set; }
        public int amountOfFive { get; private set; }
        public int amountOfOne { get; private set; }
        public int amountOfFiftyOre { get; private set; }

        // Round the ören up or down. If a customer buys for 371,28 this should be rounded up to 371,50. 
        // And if the customer pays 1000 kr he should get 628,50 kr back.
        private static double RoundOrenUpOrDown(double inputValue)
        {
            double convertedValue = Math.Round(inputValue * 2.0d) / 2.0d;
            return convertedValue;
        }

        // Round value to two decimals
        private static double RoundValueToTwoDecimals(double inputValue)
        {

            double convertedValue = Math.Round(inputValue, 2);
            // Math.Round(inputValue, 2, MidpointRounding.AwayFromZero)
            return convertedValue;
        }


        // Gemensam metod för att beräkna antal sedlar att returnera
        /*  private int numberOfMoneyBackMethod(double moneyRemaining, double inputValue)
          {
              Program vl = new Program();
              int amountOfMoneyback;
              amountOfMoneyback = (int)(moneyRemaining / inputValue);
              if (amountOfMoneyback != 0)
              {
                  Console.WriteLine(amountOfMoneyback);

              }
              return amountOfMoneyback;
          }
          */




        static void Main(string[] args)
        {
            while (1 > 0) { 
            Program vl = new Program();

            Console.WriteLine("Ange en kostnad och erhållen belopp där differense är max 2 147 483 647");
            Console.Write("Ange kostnaden: ");

            // Eventuella fel i samband med inmatningen ska tas om hand.Använd try/catch och fånga lämpligt undantag (exception).
            try
            {
                vl.cost = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Felaktigt formaterad värde inmatad, mata in värdet med formatet XXX,XX");
                    //throw;
                Console.WriteLine("Tryck på enter tills det står 'Ange kostnad:' för att försöka igen.");

                    /*
                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                    Console.WriteLine(
                        "\nHelpLink ---\n{0}", e.HelpLink);
                    Console.WriteLine("\nSource ---\n{0}", e.Source);
                    Console.WriteLine(
                        "\nStackTrace ---\n{0}", e.StackTrace);
                    Console.WriteLine(
                        "\nTargetSite ---\n{0}", e.TargetSite);
                        */
                }

            // Round the ören up or down. If a customer buys for 371,28 this should be rounded up to 371,50. And if the customer pays 1000 kr he should get 628,50 kr back. 
            vl.cost = RoundOrenUpOrDown(vl.cost);

            Console.Write("Ange erhållet belopp: ");
            // Eventuella fel i samband med inmatningen ska tas om hand.Använd try/catch och fånga lämpligt undantag (exception).
            // Hanteror om fel decimal avskiljare används men inte om stort värde anges som flöder över int datatypen. Se separate
            // hantering av int overflow.
            try
            {
                vl.cashReceived = double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Felaktigt formaterad värde inmatad, mata in värdet med formatet XXX,XX");
                    //  throw;
                    Console.WriteLine("Tryck på enter tills det står 'Ange kostnad:' för att försöka igen.");


                    /*
                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                    Console.WriteLine(
                        "\nHelpLink ---\n{0}", e.HelpLink);
                    Console.WriteLine("\nSource ---\n{0}", e.Source);
                    Console.WriteLine(
                        "\nStackTrace ---\n{0}", e.StackTrace);
                    Console.WriteLine(
                        "\nTargetSite ---\n{0}", e.TargetSite);
                        */
                }

            vl.toBeReturned = vl.cashReceived - vl.cost;
            vl.outputValue = RoundValueToTwoDecimals(vl.toBeReturned);

            // Print the text to the console, print the return value and formatting it to print two decimal number including the 0 to the console.
            Console.Write("Tillbaka    : " + "{0:F2}", vl.outputValue);
            Console.WriteLine(" kr");
            // Console.WriteLine(vl.toBeReturned);

            /*
             *  När du handlar i en affär och betalar kontant får du kanske växel tillbaka. I regel får affärsbiträdet
                hjälp av kassaapparaten med att beräkna summan man ska få tillbaka, men inte alltid vilka sedlar
                och mynt som ska lämnas tillbaka. Skriv ett program som beräknar den växel biträdet ska ge
                tillbaka i samband med ett köp. Programmet ska, förutom att presentera beloppet kunden får
                tillbaka avrundat till närmsta 50-öring, även bestämma vilka, och antalet, sedlar och mynt. Kunden
                ska få så få sedlar och mynt som möjligt tillbaka. 


            Programmet ska kunna ge växel tillbaka medsedlar av valörerna 
            */
            // 1000 
            try
            {
                vl.amountOfThousends = (checked ((int)(vl.outputValue / 1000)));


                if (vl.amountOfThousends != 0)
                {
                    Console.WriteLine("1000-lappar: " + vl.amountOfThousends);
                }

                if (vl.amountOfThousends >= 1)
                {
                    vl.remainderAmountThousends = (vl.outputValue - (vl.amountOfThousends * 1000));
                    //    Console.WriteLine("remainderAmountOfThousends: " + vl.remainderAmountThousends);
                }
                else
                {
                    vl.remainderAmountThousends = vl.outputValue;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");

                    /*
                Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);
                    */
            }
        

            //500,
            try
            {
                vl.amountOfFiveHundred = (checked ((int)(vl.remainderAmountThousends / 500)));

                if (vl.amountOfFiveHundred != 0)
                {
                    Console.WriteLine(" 500-lappar: " + vl.amountOfFiveHundred);
                }

                if (vl.amountOfFiveHundred >= 1)
                {
                    vl.remainderAmountFivehundred = vl.remainderAmountThousends - (vl.amountOfFiveHundred * 500);
                    //   Console.WriteLine("remainderAmountFivehundred" + vl.remainderAmountFivehundred);
                }
                else
                {
                    vl.remainderAmountFivehundred = vl.remainderAmountThousends;
                }
            }
            catch (OverflowException e)
            {
                    Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                    Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");
                    /*
                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);
                    */
                }

            //100, 
            try
            {
                
                vl.amountOfHundred = (checked ((int)(vl.remainderAmountFivehundred / 100)));

                if (vl.amountOfHundred != 0)
                {
                    Console.WriteLine(" 100-lappar: " + vl.amountOfHundred);
                }

                if (vl.amountOfHundred >= 1)
                {
                    vl.remainderAmountOfHundred = vl.remainderAmountFivehundred - (vl.amountOfHundred * 100);
                    //      Console.WriteLine("remainderAmountOfHundred: " + vl.remainderAmountOfHundred);
                }
                else
                {
                    vl.remainderAmountOfHundred = vl.remainderAmountFivehundred;
                }
            }
            catch (Exception e)
            {

                    Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                    Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");

                    /*

                        Console.WriteLine("\nMessage ---\n{0}", e.Message);
                    Console.WriteLine(
                        "\nHelpLink ---\n{0}", e.HelpLink);
                    Console.WriteLine("\nSource ---\n{0}", e.Source);
                    Console.WriteLine(
                        "\nStackTrace ---\n{0}", e.StackTrace);
                    Console.WriteLine(
                        "\nTargetSite ---\n{0}", e.TargetSite);
                        */
                }

            //50 och 
            try
            {
                int amountOfFifty = (checked ((int)(vl.remainderAmountOfHundred / 50)));

                if (amountOfFifty != 0)
                {
                    Console.WriteLine("  50-lappar: " + amountOfFifty);
                }

                if (amountOfFifty >= 1)
                {
                    vl.remainderAmountOfFifty = vl.remainderAmountOfHundred - (amountOfFifty * 50);
                    //  Console.WriteLine("remainderAmountOfFifty: " + vl.remainderAmountOfFifty);
                }
                else
                {
                    vl.remainderAmountOfFifty = vl.remainderAmountOfHundred;
                }
            }

            catch (OverflowException e)
            {

                    Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                    Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");

                    /*

                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);

                    */
                }



            //20 samt 
            try
            {
                int amountOfTwenty = (checked ((int)(vl.remainderAmountOfFifty / 20)));

                if (amountOfTwenty != 0)
                {
                    Console.WriteLine("  20-lappar: " + amountOfTwenty);

                }

                if (amountOfTwenty >= 1)
                {
                    vl.remainderAmountOfTwenty = vl.remainderAmountOfFifty - (amountOfTwenty * 20);
                    //  Console.WriteLine("remainderAmountOfTwenty: " + vl.remainderAmountOfTwenty);
                }
                else
                {
                    vl.remainderAmountOfTwenty = vl.remainderAmountOfFifty;
                }
            }

            catch (OverflowException e)
            {

                    Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                    Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");

                    /*

                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);

                    */
                }

            //mynten 10, 
            try
            {
                int amountOfTen = (checked ((int)(vl.remainderAmountOfTwenty / 10)));

                if (amountOfTen != 0)
                {
                    Console.WriteLine("  10-kronor: " + amountOfTen);
                }

                if (amountOfTen >= 1)
                {
                    vl.remainderAmountOfTen = vl.remainderAmountOfTwenty - (amountOfTen * 10);
                    //   Console.WriteLine("remainderAmountOfTen: " + vl.remainderAmountOfTen);
                }
                else
                {
                    vl.remainderAmountOfTen = vl.remainderAmountOfTwenty;
                }
            }
            catch (OverflowException e)
            {
                    Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                    Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");

                    /*

                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);

                    */
                }


            //5, 
            try // check for int overflow
            {
                int amountOfFive = (checked ((int)(vl.remainderAmountOfTen / 5)));
                if (amountOfFive != 0)
                {
                    Console.WriteLine("   5-kronor: " + amountOfFive);
                }


                if (amountOfFive >= 1)
                {
                    vl.remainderAmountOfFive = vl.remainderAmountOfTen - (amountOfFive * 5);
                    //   Console.WriteLine("remainderAmountOfFive: " + vl.remainderAmountOfFive);
                }
                else
                {
                    vl.remainderAmountOfFive = vl.remainderAmountOfTen;
                }
            }
            catch (OverflowException e)
            {
                    Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                    Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");

                    /*

                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);

                    */
                }


            //1 och 
            try // check for int overflow etc.
            {
                vl.amountOfOne = (checked ((int)(vl.remainderAmountOfFive / 1)));
                if (vl.amountOfOne != 0)
                {
                    Console.WriteLine("   1-kronor: " + vl.amountOfOne);
                }

                if (vl.amountOfOne >= 1)
                {
                    vl.remainderAmountOfOne = vl.remainderAmountOfFive - (vl.amountOfOne * 1);
                    // Console.WriteLine("remainderAmountOfOne: " + vl.remainderAmountOfOne);
                }
                else
                {
                    vl.remainderAmountOfOne = vl.remainderAmountOfFive;
                }
            }
            catch (OverflowException e)
            {

                    /*
                Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);

                    */
            }


            //50-öring. 
            try // the keyword checked makes this part of the code to throw and exception error if the amount calculation exceeds int max
            {
                int amountOfFiftyOre = (checked ((int)((vl.remainderAmountOfOne * 10) / 5)));
                if (amountOfFiftyOre != 0)
                {
                    Console.WriteLine("   50-öring: " + amountOfFiftyOre);
                }
            }

            catch (OverflowException e)
            {
                    Console.WriteLine("Differensen mellan kostnad och erhållen belopp får vara max 2 147 483 647.");
                    Console.WriteLine("men du har angivit värden med en större differens än detta. Tryck enter och försök igen");


                    /*
                    Console.WriteLine("\nMessage ---\n{0}", e.Message);
                Console.WriteLine(
                    "\nHelpLink ---\n{0}", e.HelpLink);
                Console.WriteLine("\nSource ---\n{0}", e.Source);
                Console.WriteLine(
                    "\nStackTrace ---\n{0}", e.StackTrace);
                Console.WriteLine(
                    "\nTargetSite ---\n{0}", e.TargetSite);

                    */
                }
            /*  Du kan anta att
              det alltid finns tillräckligt antal av de sedlar och mynt som krävs.
              Skriv endast ut de valörer som ska lämnas tillbaka. 




          Glöm inte att testa programmet. 

          Om t.ex. en kund handlar för 371,38 kr avrundas beloppet till 371,50 kr. 

          Om kunden betalar med en 1000 kr sedel ska kunden få 628,50 kr tillbaka, fördelat enligt figuren.
           */

            Console.ReadKey();
            }
        }
    }
}
