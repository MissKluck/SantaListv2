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
        // For creating the elves
        return null;
    }

    public void Naughty()
    {
        // For assigning coal and Gryla

    }

    public void Nice()
    {
        // For assigning elves and gifts to the kids

    }
}