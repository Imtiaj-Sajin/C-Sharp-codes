/*A sport club is willing to have their player information in a console-based system, for which they asked to build a simple console-based application which will have some basic player information. The club has 2 types of Players: Cricketer & Footballer. All the Players will have id, name, salary and joining date. Cricketer players will have totalRun and totalWicket, and Footballer will have totalGoal and totalAssist. ShowInfo() method will provide all the information for each type of Player. 
The Main method is already given for you, try to write other classes to make it happen, write appropriate fields, methods, properties etc. Use proper access modifiers, types etc. [Optional: For joining date if you can create custom type then it will be considered as bonus part.]  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public class Player
    {
        public string id;
        public string name;
        public int sal;
        public string dob;
        public int totalScore;
        public int matches;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        
        public void ShowInfo()
        {
            Console.Out.WriteLine("Player Id: " + id);
            Console.Out.WriteLine("Player Name: " + name);
            Console.Out.WriteLine("Salary: " + sal);
            Console.Out.WriteLine("Date Of Joining: " + dob);
            Console.Out.WriteLine("Score: " + totalScore);
            Console.Out.WriteLine("Total Matches: " + matches);
            Console.Out.WriteLine();
        }
        
    }
    public class Cricketer:Player
    {
        public Cricketer(string id, string name, int sal, string dob, int totalRun, int matches)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
            this.dob = dob;
            this.totalScore = totalRun;
            this.matches = matches;
        }

    }

    public class Footballer : Player
    {
        public Footballer(string id, string name, int sal, string dob, int totalScore, int matches)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
            this.dob = dob;
            this.totalScore = totalScore;
            this.matches = matches;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cricketer cr = new Cricketer("P-01", "Shakib", 70000, "06-08-2006", 6755, 285);
            Footballer ft = new Footballer("P-02", "Jamal", 50000, "13-06-2013", 20, 15);
            cr.ShowInfo();
            ft.ShowInfo();
        }
    }
}
