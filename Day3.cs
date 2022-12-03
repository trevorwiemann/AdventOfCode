using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Day3();
	}
	
	public static void Day3() {
		string input = @"vJrwpWtwJgWrhcsFMMfFFhFp
jqHRNqRjqzjGDLGLrsFMfFZSrLrFZsSL
PmmdzqPrVvPwwTWBwg
wMqvLMZHhHMvwLHjbvcjnnSBnvTQFn
ttgJtRGJQctTZtZT
CrZsJsPPZsGzwwsLwLmpwMDw";
	       string[] rucksacks = input.Split("\n");
	       List<string> compartments = new List<string>();
	       List<char> itemsList = new List<char>();
	       string letters = "abcdefghijklmnopqrstuvwxyz";
	       Dictionary<char, int> priorities = new Dictionary<char, int>();
	       
	       for (int i =0; i <letters.Length; i++) {
	       	priorities.Add(letters[i],i+1);
	       	char upperLetter = letters[i].ToString().ToUpper().ToCharArray()[0];
	       	priorities.Add(upperLetter,i+27);
	       
	       }
	       
	       foreach (string sack in rucksacks){
	       		string compartmentOne = sack.Substring(0,(sack.Length/2));
	       		string compartmentTwo = sack.Substring((sack.Length/2),sack.Length/2);
	       		foreach (var item in compartmentOne) {
	       		if (compartmentTwo.Contains(item)) {
	       			itemsList.Add(item);
	       			break;
	       			}
	       		}
	     }
	     int total = 0;
	     foreach (var item in itemsList) {
	     	total += priorities[item];
	     	}
	     	Console.WriteLine(total);
				itemsList.Clear();
		
		// part 2
		 for (int i = 0; i < rucksacks.Length; i +=3) {
	     	foreach (char letter in rucksacks[i]) {
	     		if (rucksacks[i+1].IndexOf(letter) != -1) {
	     			if (rucksacks[i+2].IndexOf(letter) != -1) {
	     				itemsList.Add(letter);
						break;
	     				}
	     			}
	     	}
	     }     

	     	total = 0;
	     foreach (var item in itemsList) {
			 	     	Console.WriteLine(item);

	     	total += priorities[item];
	     	}
	     	Console.WriteLine(total);
	}
}