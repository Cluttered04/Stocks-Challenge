using System;
using System.Collections.Generic;

namespace stocks
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("DOG", "Woof");
            stocks.Add("BIRD", "Chirp");
            stocks.Add("HORSE", "Neigh");

            Dictionary<string, List<int>> stockTrades = new Dictionary<string, List<int>>(){
                {"GM", new List<int>{1001, 3002, 4006}},
                {"CAT", new List<int>{946, 852, 1005}},
                {"DOG", new List<int>{2001, 2251, 456}},
                {"BIRD", new List<int>{ 256, 291, 274}}
            };


            foreach(KeyValuePair<string, List<int>> trade in stockTrades){
                int total = 0;
                string name = stocks[trade.Key];
                foreach(int number in trade.Value){
                    total = total + number;
                }
                Console.WriteLine(total);
                Console.WriteLine($"The position in {name} is worth {total}.");
            }





        }
    }
}
