using System.Text.Json;

public class Functions
{
    public List<Person> PersonInfo()
    {
        // Added a function which calls in the json document and serializes it
        if (File.Exists("data/randomPeople.json"))
        {
            // returns the json document, writes it to a list which it reads through
            return JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("data/randomPeople.json"), new JsonSerializerOptions { WriteIndented = true, PropertyNameCaseInsensitive = true }) ?? new List<Person>();
            //adds the write intended which means that you can write to the json document and propertynamecaseinsensitive as json writes in camelCase while the model was written with PascalCase, so the json will overlook the difference
        }
        // if the json document doesn't exist, it returns an empty list
        return new List<Person>();
    }

    public List<Elves> CreateElves()
    {
        // creates a new list for the elves using properties from the model Elves.cs
        List<Elves> elves = new List<Elves> { };

        elves.Add(new Elves { Name = "Alvhild", Speciality = "Woodworking", Gifts = "carved animal figurine" });
        elves.Add(new Elves { Name = "Erik", Speciality = "Electronics", Gifts = "Headset" });
        elves.Add(new Elves { Name = "Freya", Speciality = "Sewing", Gifts = "Kitchen towels" });
        elves.Add(new Elves { Name = "Bjørn", Speciality = "Blacksmithing", Gifts = "Lightsaber" });
        elves.Add(new Elves { Name = "Ingvild", Speciality = "Ceramics", Gifts = "Flowerpot with the letters Mom written in the air above it" });

        // For creating the elves
        return elves;
    }

    public void Naughty(List<Person> kids)
    {
        // creates the naughty list using the properties from the Kids.cs model and initialises the random class
        var random = new Random();
        // loops through each kid on the naughty list
        foreach (Person kid in kids)
        {
            // assigns a random number between 0 and 9
            if (random.Next(0, 10) == 0)
            {
                // if the kid is assigned 0, it writes out to the console that they're eaten by Gryla
                Console.WriteLine($"{kid.Name} is eaten by Gryla!!! ({kid.NaughtyOrNiceScore})");
            }
            else
            {
                // if the kid is assigned a number between 1 and 9, it writes out to the console that they receive coal
                Console.WriteLine($"{kid.Name} recives coal from elves ({kid.NaughtyOrNiceScore})");
            }
        }

    }

    public void Nice(List<Person> kids)
    {
        // creates the nice list and calls in the list of elves
        List<Elves> elves = CreateElves();
        // is used to assign elf from the elves list
        int a = 0;
        foreach (Person kid in kids)
        {
            // stops the loop from exceeding the index of the elves list
            if (a == 5) a = 0;
            // writes out to the console which elf and gift the kid receives
            Console.WriteLine($"{kid.Name} receives {elves[a].Gifts} from {elves[a].Name} ({kid.NaughtyOrNiceScore})");
            // loops through each kid and assigns them an elf based on what index the elves are on the list
            a++;
        }
    }
}