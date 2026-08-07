public class Robot
{
 private static readonly HashSet<string> _usedNames = new HashSet<string>();
private static readonly Random _random = new Random();
private string _name;
public string Name
{
    get
    {
        if (string.IsNullOrEmpty(_name))
        {
            _name = GenerateUniqueRobotName();
        }
        return _name;
    }
    
}

private static string GenerateUniqueRobotName()
{
    string newName;
    do
    {
        var letters = new string(Enumerable.Range(0, 2).Select(_ => (char)_random.Next('A', 'Z' + 1)).ToArray());
        var digits = new string(Enumerable.Range(0, 3).Select(_ => (char)_random.Next('0', '9' + 1)).ToArray());
        newName = letters + digits;
    }
    while (!_usedNames.Add(newName)); // Keeps looping until a truly unique name is generated and added

    return newName;
}

public void Reset()
{
    if (!string.IsNullOrEmpty(_name))
    {
        _usedNames.Remove(_name); 
        _name = null;
    }
}
}