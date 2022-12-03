using System;
using System.Collections.Generic;
using System.Linq;
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
string input =@“”;
       string[] calsArr = input.Split("\n");
		
		int runningTotal = 0;
		int currentHigh = 0;
		int intToAdd = 0;
		List<int> scoresList = new List<int>();
		foreach (string cal in calsArr) {
			if (int.TryParse(cal, out intToAdd)) {
				runningTotal += intToAdd;
			}
			else {
				scoresList.Add(runningTotal);
				runningTotal = 0;
			}
		}
		if (runningTotal != 0) {
							scoresList.Add(runningTotal);
		}
		scoresList.Sort();
		scoresList.Reverse();
		int total = 0;
		for (int i = 0; i < 3; i++) {
			total += scoresList[i];
		}
		Console.WriteLine("{0},{1},{2}",scoresList[0],scoresList[1],scoresList[2]);
		Console.WriteLine(total);
      
    }
  }
}