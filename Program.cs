 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 
 var rucksackList = new List<string>(); 
 var commonList = new List<string>();
 var commonElem = new StringBuilder();
 int total = 0;

foreach (string line in System.IO.File.ReadLines(@"/Users/dd/aoc_2022_q3_part2/input.txt"))
    {  
        rucksackList.Add(line); 
    }  
for (int i = 0; i<rucksackList.Count; i++)
    {
        char[] str_first = rucksackList[i].ToCharArray(); 
        char[] str_two =  rucksackList[i+1].ToCharArray();
        char[] str_three = rucksackList[i+2].ToCharArray();
        var common = str_first.Intersect(str_two).Intersect(str_three);
        foreach(char ch in common)
            {
                Console.WriteLine(ch); 
                if (ch == 'a')
                    {
                        total = total + 1;
                    }
                else if (ch == 'b')
                    {
                        total = total + 2;
                    }
                else if (ch == 'c')
                    {
                        total = total + 3;
                    }
                else if (ch == 'd')
                    {
                        total = total + 4;
                    }
                else if (ch == 'e')
                    {
                        total = total + 5;
                    }
                else if (ch == 'f')
                    {
                        total = total + 6;
                    }
                else if (ch == 'g')
                    {
                        total = total + 7;
                    }
                else if (ch == 'h')
                    {
                        total = total + 8;
                    }
                else if (ch == 'i')
                    {
                       total = total + 9;
                    }
                else if (ch == 'j')
                    {
                        total = total + 10;
                    }
                else if (ch == 'k')
                    {
                        total = total + 11;
                    }
                else if (ch == 'l')
                    {
                        total = total + 12;
                    }
                else if (ch == 'm')
                    {
                        total = total + 13;
                    }
                else if (ch == 'n')
                    {
                        total = total + 14;
                    }
                else if (ch == 'o')
                    {
                        total = total + 15;
                    }
                else if (ch == 'p')
                    {
                        total = total + 16;
                    }
                else if (ch == 'q')
                    {
                        total = total + 17;
                    }
                else if (ch == 'r')
                    {
                        total = total + 18;
                    }
                else if (ch == 's')
                    {
                        total = total + 19;
                    }
                else if (ch == 't')
                    {
                        total = total + 20;
                    }
                else if (ch == 'u')
                    {
                         total = total + 21;
                    }
                else if (ch == 'v')
                    {
                        total = total + 22;
                    }
                else if (ch == 'w')
                    {
                        total = total + 23;
                    }
                else if (ch == 'x')
                    {
                        total = total + 24;
                    }
                else if (ch == 'y')
                    {
                        total = total + 25;
                    }
                else if (ch == 'z')
                    {
                        total = total + 26;
                    }
                else if (ch == 'z')
                    {
                        total = total + 26;
                    }
                else if (ch == 'A')
                    {
                        total = total + 27;
                    }
                else if (ch == 'B')
                    {
                        total = total + 28;
                    }
                else if (ch == 'C')
                    {
                        total = total + 29;
                    }
                else if (ch == 'D')
                    {
                        total = total + 30;
                    }
                else if (ch == 'E')
                    {
                        total = total + 31;
                    }
                else if (ch == 'F')
                    {
                        total = total + 32;
                    }
                else if (ch == 'G')
                    {
                        total = total + 33;
                    }
                else if (ch == 'H')
                    {
                        total = total + 34;
                    }
                else if (ch == 'I')
                    {
                        total = total + 35;
                    }
                else if (ch == 'J')
                    {
                        total = total + 36;
                    }
                else if (ch == 'K')
                    {
                        total = total + 37;
                    }
                else if (ch == 'L')
                    {
                        total = total + 38;
                    }
                else if (ch == 'M')
                    {
                        total = total + 39;
                    }
                else if (ch == 'N')
                    {
                        total = total + 40;
                    }
                else if (ch == 'O')
                    {
                        total = total + 41;
                    }
                else if (ch == 'P')
                    {
                        total = total + 42;
                    }
                else if (ch == 'Q')
                    {
                        total = total + 43;
                    }
                else if (ch == 'R')
                    {
                        total = total + 44;
                    }
                else if (ch == 'S')
                    {
                        total = total + 45;
                    }
                else if (ch == 'T')
                    {
                        total = total + 46;
                    }
                else if (ch == 'U')
                    {
                        total = total + 47;
                    }
                else if (ch == 'V')
                    {
                        total = total + 48;
                    }
                else if (ch == 'W')
                    {
                        total = total + 49;
                    }
                else if (ch == 'X')
                    {
                        total = total + 50;
                    }
                else if (ch == 'Y')
                    {
                        total = total + 51;
                    }
                else if (ch == 'Z')
                    {
                        total = total + 52;
                    }
                }
                i = i+2;
            }
   Console.WriteLine(total);

