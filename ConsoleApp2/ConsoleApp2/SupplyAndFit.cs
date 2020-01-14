using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class SupplyAndFit : Service
    {
        //PROPERTIES
        
        //Properties unique to the SupplyAndFit class (and subseqent derivative classes)

        //Properties with default values upon initialisation of SupplyAndFit objects
        public string SF_JobNotes { get; set; }

        //CONSTRUCTOR(S)

        public SupplyAndFit(string name, string code, string description, decimal cost, decimal tax, int orderQuantity)
            : base(name, code, description, cost, tax, orderQuantity)
        {}  //end CONSTRUCTOR(S)

        //METHODS

        //Overridden ToString() method

        public override string ToString()
        {
            return
                base.ToString() +
                $"{Environment.NewLine}" +
                $"Job Notes:\t\t\t\t{SF_JobNotes}{Environment.NewLine}";
        }

        //Virtual method AddJobNotes()
        public virtual void AddJobNotes()
        {
            Console.WriteLine($"Please enter any comments/ observations below for the Supply & Fit of your selected {Name}.");
            string comment = Console.ReadLine();
            SF_JobNotes += comment;

            Console.WriteLine($"\nCurrent notes for this {Name} updated as follows:\n\n{SF_JobNotes}.");
        }

        //Virtual method RemoveJobNotes()
        public virtual void RemoveJobNotes()
        {
            DisplayJobNotes();

            Console.WriteLine("\nPlease enter the character position at which you would like to begin removal");
            int startIndex = int.Parse(Console.ReadLine());

            Console.WriteLine("Now please enter the number of character spaces that you would like to remove");
            int count = int.Parse(Console.ReadLine());

            SF_JobNotes = SF_JobNotes.Remove(startIndex, count);

            Console.WriteLine($"\nCurrent notes for this {Name} updated as follows:\n\n{SF_JobNotes}");
        }

        //Virtual method DisplayJobNotes()
        public virtual void DisplayJobNotes()
        {
            Console.WriteLine($"Current notes for this {Name}:\n\n{SF_JobNotes}");
        }
    }   //end class SupplyAndFit
}
