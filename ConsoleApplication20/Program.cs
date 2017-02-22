using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {

        static int ParityCalculation(int happyTicket)
        {
            int sum = 0;
            while (happyTicket != 0)
            {
                happyTicket = (happyTicket / 10);
                sum = sum + 1;
            }
            return sum;
        }
        //--------------------------------------------------------------------------------- 111111
        static int ConsiderHappiness(int halfHappyTicket)
        {
            int sum = 0;
            while (halfHappyTicket != 0)
            {
                sum = halfHappyTicket % 10;
                halfHappyTicket = halfHappyTicket / 10;
            }
            return sum;

        }
        //--------------------------------------------------------------------------------------------2222222
        static int Happiness(int happyTicket)
        {
            return happyTicket % (int)Math.Pow(10, ((ParityCalculation(happyTicket) / 2)));
        }
        //------------------------------------------------------------------------------------3333333
        static void HappinessAnalysis(int leftHappyTicket, int rightHappyTicket)
        {
            if (ConsiderHappiness(leftHappyTicket) == ConsiderHappiness(rightHappyTicket))

                Console.WriteLine("ТЫ СЧАЧТЛИВЧИК");

            else
                Console.WriteLine("ТЕБЕ НЕ ПОВИЗЛО");
        }
        //------------------------------------------------------------------------------------444444444

        static void CompressionAlgorithm(int happyTicket)
        {
            int leftHappyTicket = Happiness(happyTicket);
            int rightHappyTicket = Happiness(happyTicket);

            HappinessAnalysis(leftHappyTicket, rightHappyTicket);
        }

        //-----------------------------------------------------------------------55555555555

        static int SpecialHappiness(int happyTicket)
        {
            return happyTicket / (int)Math.Pow(10, ((ParityCalculation(happyTicket) / 2) + 1));
        }
        //---------------------------------------------------------------------------------------66666666666
        static void SpecialCompressionAlgorithm(int happyTicket)
        {
            int leftHappyTicket = SpecialHappiness(happyTicket);
            int rightHappyTicket = Happiness(happyTicket);

            HappinessAnalysis(leftHappyTicket, rightHappyTicket);
        }

        //-------------------------------777777777777

        static void AllAlgorithm(int happyTicket)
        {
            if ((ParityCalculation(happyTicket) % 2) == 0)
            {
                CompressionAlgorithm(happyTicket);
            }
            else
            {
                SpecialCompressionAlgorithm(happyTicket);
            }
        }
        //---------------------------------------------------------------------------888888888888



        //



        //



        static void Main(string[] args)
        {
            int happyTicket = Convert.ToInt32(Console.ReadLine());

            AllAlgorithm(happyTicket);

            Console.ReadLine();
        }
    }
}
