using System.Text.Json;

public class Functions
{
    public List<Person> PersonInfo()
    {
        if (File.Exists("data/randomPeople.json"))
        {
            return JsonSerializer.Deserialize<List<Person>>(File.ReadAllText("data/randomPeople.json"), new JsonSerializerOptions { WriteIndented = true, PropertyNameCaseInsensitive = true }) ?? new List<Person>();
        }
        return new List<Person>();
    }

    public List<Elves> CreateElves()
    {
        List<Elves> elves = new List<Elves> { };

        elves.Add(new Elves { Name = "Alvhild", Speciality = "Woodworking", Gifts = "carved animal figurine" });
        elves.Add(new Elves { Name = "Eirik", Speciality = "Electronics", Gifts = "Headset" });
        elves.Add(new Elves { Name = "Freya", Speciality = "Sewing", Gifts = "Kithcen towels" });
        elves.Add(new Elves { Name = "Bjørn", Speciality = "Blacksmithing", Gifts = "Lightsaber" });
        elves.Add(new Elves { Name = "Ingvild", Speciality = "Ceramics", Gifts = "Flowerpot with the letters Mom written in the air above it" });

        // For creating the elves
        return elves;
    }

    public void Naughty(List<Person> kids)
    {
        var random = new Random();
        foreach (Person kid in kids)
        {
            if (random.Next(0, 10) == 0)
            {
                Console.WriteLine($"{kid.Name} is eaten by Gryla!!! ({kid.NaughtyOrNiceScore})");
            }
            else
            {
                Console.WriteLine($"{kid.Name} recives coal from elves ({kid.NaughtyOrNiceScore})");
            }
        }

    }

    public void Nice(List<Person> kids)
    {
        List<Elves> elves = CreateElves();
        int a = 0;
        foreach (Person kid in kids)
        {
            Console.WriteLine($"{kid.Name} receives {elves[a].Gifts} from {elves[a].Name} ({kid.NaughtyOrNiceScore})");
        }
    }
}