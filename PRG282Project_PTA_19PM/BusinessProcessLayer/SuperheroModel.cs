using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project_PTA_19PM.BusinessProcessLayer
{
  
 internal class Superhero
 {
     // Properties
     public int HeroID { get; set; }
     public string Name { get; set; }
     public int Age { get; set; }
     public string Superpower { get; set; }
     public int ExamScore { get; set; }
     public string Rank { get; set; }
     public string ThreatLevel { get; set; }

     //Superhero Constructor
     public Superhero(int heroId, string name, int age, string superpower, int examScore)
     {
         HeroID = heroId;
         Name = name;
         Age = age;
         Superpower = superpower;
         ExamScore = examScore;
         CalculateRankAndThreat();
     }

     //Method to get rank and threat of hero
     public void CalculateRankAndThreat()
     {
         if (ExamScore >= 81 && ExamScore <= 100)
         {
             Rank = "S-Rank";
             ThreatLevel = "Finals Week";
         }
         else if (ExamScore >= 61 && ExamScore <= 80)
         {
             Rank = "A-Rank";
             ThreatLevel = "Midterm Madness";
         }
         else if (ExamScore >= 41 && ExamScore <= 60)
         {
             Rank = "B-Rank";
             ThreatLevel = "Group Project Gone Wrong";
         }
         else if (ExamScore >= 0 && ExamScore <= 40)
         {
             Rank = "C-Rank";
             ThreatLevel = "Pop Quiz";
         }
     }

     //Method to override main ToString to format superhero data before sending to txtfile
     public override string ToString()
     {
         return $"{HeroID},{Name},{Age},{Superpower},{ExamScore},{Rank},{ThreatLevel}";
     }

     //Method to format data into superhero object after retrieving from textfile
     public static Superhero FromString(string data)
     {
         string[] parts = data.Split(',');
         if (parts.Length == 7)
         {
             int heroId = int.Parse(parts[0]);
             string name = parts[1];
             int age = int.Parse(parts[2]);
             string superpower = parts[3];
             int examScore = int.Parse(parts[4]);

             return new Superhero(heroId, name, age, superpower, examScore);
         }
         throw new FormatException("Invalid superhero data format");
     }
 }
        
    }



