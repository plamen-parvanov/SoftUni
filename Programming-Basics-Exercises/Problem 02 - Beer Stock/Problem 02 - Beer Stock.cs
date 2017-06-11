using System;


namespace Problem_02___Beer_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int beerReserved = int.Parse(Console.ReadLine());
            var text = Console.ReadLine();
            long beersIncome = 0;
            long beersLeft = 0;
            long cases = 0;
            long sixpacks = 0;
            long beers = 0;

            while (text != "Exam Over")
            {
                string[] parameters = text.Split();
                int amount = int.Parse(parameters[0]); // ako go napravq ot tip long - dava 100 ot 100
                var type = parameters[1];              // no za6to da go pravq long, kato v uslovieto ne zada4ata
                                                       // e kazano 4e max moje da e int.MaxValue t.e. vliza v tipa?!?!

                if (type == "beers")
                {
                    beersIncome += amount;
                }
                else if (type == "sixpacks")
                {
                    beersIncome += 6 * amount;          //zaradi umnojenieto li? no nali ako izpolzvam int.MaxValu 
                }                                       // i go umnoja po 100 i rezultata zapi6a v long, nqma da se 
                else if (type == "cases")               // zagubi ni6to?  ili pri samoto umnojenie na int.MaxValue s 100
                {                                       // 6te se zapi6e pak max.Value no v long format?
                    beersIncome += 24 * amount;
                }
                text = Console.ReadLine();
            }
            beersIncome -= beersIncome / 100;
            beersLeft = Math.Abs(beersIncome - beerReserved);
            cases = beersLeft / 24;
            sixpacks = (beersLeft - 24 * cases) / 6;
            beers = beersLeft - cases * 24 - sixpacks * 6;

            if (beerReserved > beersIncome)
            {
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers."
                    , cases, sixpacks, beers);
            }
            else
            {

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers."
                    , cases, sixpacks, beers);
            }
        }
    }
}
