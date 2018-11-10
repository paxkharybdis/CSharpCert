using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace Advanced
{
    public class AsyncUtility
    {
        public async Task<string> BottlesOfBeerSongAsync()
        {
            int beerNum = 99;
            string word = "bottles";
            string result = "";
            while (beerNum > 0)
            {
                if (beerNum == 1)
                {
                    word = "bottle";
                }

                Console.WriteLine(beerNum + " " + word + " of beer on the wall");
                Console.WriteLine(beerNum + " " + word + " of beer");
                Console.WriteLine("Take one down");
                Console.WriteLine("Pass it around");

                beerNum--;
                if (beerNum > 0)
                {
                    Console.WriteLine(beerNum + "  " + word + " of beer on the wall");

                }
                else
                {
                    result = await Task.FromResult<string>("No more bottles of beer on the wall");
                }
            }

            return result;
        }
    }
}
