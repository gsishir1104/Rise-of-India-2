using System;

namespace RiseOfIndia2
{
    public class Artifact : IInteractable
    {
        public string Name;
        public string Description;
        public int HistoricalYear;
        public int Points;

        public Artifact(
            string name,
            string description,
            int historicalYear,
            int points)
        {
            Name = name;
            Description = description;
            HistoricalYear = historicalYear;
            Points = points;
        }

        public void Interact()
        {
            Console.WriteLine("You discovered: " + Name);
            Console.WriteLine(Description);
        }
    }
}