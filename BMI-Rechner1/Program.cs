namespace BMI_Rechner1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your Weight (kg): ");                               //Nutze Write nicht WriteLine damit kein zeilenumbruch entsteht
            double weight = Convert.ToDouble(Console.ReadLine());             //Variable Weight für gewicht in double gespeichert, Convert to double damit mehrstellige nachkommastellen auch gelesem werden können 

            Console.Write("Your Size (m): ");
            double size = Convert.ToDouble(Console.ReadLine());

            Console.Write("Your Gender (w/m/n): ");                        //Geschlechtsangabe um eine zum Körper passenderes Ergebnis bekommt
            string gender = Console.ReadLine();

                                                 


            if (gender == "n")
            {
                double bmiN = weight / (size * size);                         //Formel um BMI zu berechnen
                Console.WriteLine("Your BMI:" + bmiN);                       //BMI ergebnis au8sgabe 
                Console.Write("Klassifizierung: ");                         //Ausgabe angegeben abhängig zu allgemein definierter Klassifizierun

                if (bmiN < 18.5)
                    Console.WriteLine("Untergewicht");                    //BMI tabelle nach neutralem geschlecht falls jemand nur den durchschnittn will 
                else if (bmiN < 25)                                      //nicht sein geschlecht angeben will
                    Console.WriteLine("Normalgewicht");
                else if (bmiN < 30)
                    Console.WriteLine("Übergewicht");
                else if (bmiN < 35)
                    Console.WriteLine("Adipositas Grad 1");
                else if (bmiN < 40)
                    Console.WriteLine("Adipositas Grad 2");
                 else
                    Console.WriteLine("Adipositas Grad 3");
            }


            if (gender == "w")
            {
                double bmiW = weight / (size * size);
                Console.WriteLine("Your BMI:" + bmiW);
                Console.Write("Klassifizierung: ");

                if (bmiW < 19)
                    Console.WriteLine("Untergewicht");                  //BMI tabelle nach weiblichem geschlecht 
                else if (bmiW < 24)
                    Console.WriteLine("Normalgewicht");
                else if (bmiW < 30)
                    Console.WriteLine("Übergewicht");
                else
                    Console.WriteLine("Adipositas");
            }


            if (gender == "m")                                           // wenn männlich gewählt
            {
                double bmiM = weight / (size * size);
                Console.WriteLine("Your BMI:" + bmiM);
                Console.Write("Klassifizierung: ");

                if (bmiM < 20)                                          //BMI tabelle nach männlichem geschlecht 
                    Console.WriteLine("Untergewicht");
                else if (bmiM < 25)
                    Console.WriteLine("Normalgewicht");
                else if (bmiM < 30)
                    Console.WriteLine("Übergewicht");
                else
                    Console.WriteLine("Adipositas");
            }
            
            


          

                                            

            

          


           
        }
    }
}