List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46, "Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
// PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!

// First eruption in Chile
Eruption? firstChile = eruptions.Where(e => e.Location == "Chile").OrderBy(e => e.Year).FirstOrDefault();
// Console.WriteLine(firstChile.ToString());

// First eruption from Hawaiian Is
Eruption? firstHawaiian = eruptions.Where(e => e.Location == "Hawaiian Is").OrderBy(e => e.Year).FirstOrDefault();
// if (firstHawaiian != null)
// {
//     Console.WriteLine(firstHawaiian.ToString());
// }
// else
// {
//     Console.WriteLine("No Hawaiian Is Eruption found.");
// }

// First eruption from Greenland
Eruption? firstGreenland = eruptions.Where(e => e.Location == "Greenland").OrderBy(e => e.Year).FirstOrDefault();
// if (firstGreenland != null)
// {
//     Console.WriteLine(firstGreenland.ToString());
// }
// else
// {
//     Console.WriteLine("No Greenland Eruption found.");
// }

// First New Zealand Eruption after 1900

Eruption? firstNZafter1900 = eruptions.Where(e => e.Year > 1900).Where(e => e.Location == "New Zealand").OrderBy(e => e.Year).FirstOrDefault();

// Console.WriteLine(firstNZafter1900);

//All eruptions from volcanos over 2000m

IEnumerable<Eruption> highEruptions = eruptions.Where(e => e.ElevationInMeters > 2000);

// PrintEach(highEruptions, "Eruptions over 2000m");

// All "L" volcanos

IEnumerable<Eruption> lVolcanos = eruptions.Where(e => e.Volcano[0] == 'L');
// PrintEach(lVolcanos, "L Volcanos");
// Console.WriteLine(lVolcanos.Count());

//Highest Elevation

int? highestElevation = eruptions.Max(e => e.ElevationInMeters);
// Console.WriteLine(highestElevation);

//Name of Volcano with highest elevation

Eruption? tallestVolcano = eruptions.FirstOrDefault(e => e.ElevationInMeters == highestElevation);
// Console.WriteLine(tallestVolcano?.Volcano);

//All volcano names

IEnumerable<Eruption> volcanos = eruptions.OrderBy(e => e.Volcano);
// foreach (Eruption erupt in volcanos)
// {
//     Console.WriteLine(erupt.Volcano);
// };

//Elevation sum

int? elevationSum = eruptions.Sum(e => e.ElevationInMeters);
// Console.WriteLine(elevationSum);

//Eruptions in 2000

IEnumerable<Eruption> year2000 = eruptions.Where(e => e.Year == 2000);
// PrintEach(year2000, "Eruptions in 2000");

//Three stratovolcano eruptions

IEnumerable<Eruption> firstThreeStrats = stratovolcanoEruptions.Take(3);
// PrintEach(firstThreeStrats, "Three Stratovolcano Eruptions");

//Eruptions before 1000 alphabetically

IEnumerable<Eruption> pre1000 = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano);
// PrintEach(pre1000, "All Eruptions before 1000CE");

// Volcano names for eruptions before 1000CE

IEnumerable<string> pre1000Names = eruptions.Where(e => e.Year < 1000).OrderBy(e => e.Volcano).Select(e => e.Volcano);
// foreach (string name in pre1000Names)
// {
//     Console.WriteLine(name);
// }




// Helper method to print each item in a List or IEnumerable. This should remain at the bottom of your class!
static void PrintEach(IEnumerable<Eruption> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (Eruption item in items)
    {
        Console.WriteLine(item.ToString());
    }
}
