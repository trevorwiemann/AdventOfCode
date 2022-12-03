using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Day2Part2();
	}
	
	public static void Day2Part2 () {
	string input = @"A Y
B X
C Z";
		var translations = new Dictionary<string, string>(){
			{"A","Rock"},
			{"B","Paper"},
			{"C","Scissors"},
			{"X","Lose"},
			{"Y","Draw"},
			{"Z","Win"}
		};
		var rubric = new Dictionary<string, int>(){
			{"Rock",1},
			{"Paper",2},
			{"Scissors",3}
		};
		var loseRules = new Dictionary<string, string>(){
			{"Rock","Scissors"},
			{"Paper","Rock"},
			{"Scissors","Paper"}
		};
		var winRules = new Dictionary<string, string>(){
			{"Rock","Paper"},
			{"Paper","Scissors"},
			{"Scissors","Rock"}
		};
		int score = 0;
		string[] stratGuide = input.Split("\n");
				Console.WriteLine("test");

		foreach (var item in stratGuide) {
			string oppPlay = translations[item.Split(' ')[0]];
			string scenario = translations[item.Split(' ')[1]];
			if (scenario == "Win") {
				score += 6;
				score += rubric[winRules[oppPlay]];
			}
			else if (scenario == "Lose") {
				score += rubric[loseRules[oppPlay]];
			}
			else {
								score += 3;
				score += rubric[oppPlay];
			}
		}
		Console.WriteLine(score);		
	}
	
	public static void Day2Part1 () {
	string input = @"";
		var translations = new Dictionary<string, string>(){
			{"A","Rock"},
			{"B","Paper"},
			{"C","Scissors"},
			{"X","Rock"},
			{"Y","Paper"},
			{"Z","Scissors"}
		};
		var rubric = new Dictionary<string, int>(){
			{"Rock",1},
			{"Paper",2},
			{"Scissors",3}
		};
		var rules = new Dictionary<string, string>(){
			{"Rock","Scissors"},
			{"Paper","Rock"},
			{"Scissors","Paper"}
		};
		int score = 0;
		string[] stratGuide = input.Split("\n");
				Console.WriteLine("test");

		foreach (var item in stratGuide) {
			string oppPlay = translations[item.Split(' ')[0]];
			string myPlay = translations[item.Split(' ')[1]];
			score += rubric[myPlay];
			if (oppPlay == myPlay) {
				score += 3;
			}
			else if (rules[myPlay] == oppPlay) {
				score += 6;
			} 
		}
		Console.WriteLine(score);		
	}
}