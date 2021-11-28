using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcceptanceAndRejection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input number of variates");
                float[] Variates = new float[Convert.ToInt32(Console.ReadLine())];
                float tX = 2.0736f;
                int counter = 0;
                for (int i = 0; ; i++)
                {
                    float randomNumber = (float)new Random().NextDouble();
                    float temp = ((float)(60 * Math.Pow(randomNumber, 3) * Math.Pow((1 - randomNumber), 2)))/tX;
                    if(randomNumber <= temp & !Variates.Contains(temp))
                    {
                        Variates[counter] = temp;
                        counter++;
                    }
                    if (counter == Variates.Length)
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
