﻿using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<-----Hash Table----->");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] para = paragraph.Split(" ");
            //Create object for MyMapNode
            MyMapNode<string, string> hash = new MyMapNode<string, string>(para.Length);
            int keys = 0;
            foreach (string word in para)
            {
                int k = keys++;
                string key = k.ToString();
                hash.Add(word, key);
            }
            string value = hash.Get("Paranoids");
            hash.GetArrayPosition(value);
            hash.Remove("avoidable");
        }
    }
}
