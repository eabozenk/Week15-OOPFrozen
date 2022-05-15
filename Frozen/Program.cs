using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string who;
            string what;
            

            public Frozen(string _who, string _what)
            {
                who = _who;
                what = _what;
                
            }                       

            public string Who
            {
                get { return who; }
            }
            public string What
            {
                get { return what; }
            }
           
        }
        static void Main(string[] args)
        {
            List<Frozen> myFrozen = new List<Frozen>();
            string[] frozenFromFile = GetDataFromFile();

            foreach (string line in frozenFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newItem = new Frozen(tempArray[0], tempArray[1]);
                myFrozen.Add(newItem);
            }

            foreach (Frozen frozenFromList in myFrozen)
            {
                Console.WriteLine($"{frozenFromList.Who} wants {frozenFromList.What} for Christmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\eaboz\Downloads\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
