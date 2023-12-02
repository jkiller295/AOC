//Part 1
string[] input = File.ReadAllLines("input.txt");
Dictionary<string, int> colourLimit = new Dictionary<string, int> { { "red", 12 }, { "green", 13 }, { "blue", 14 } };
int sum = 0;
foreach (string s in input)
{
    string[] content = s.Split(':');
    string[] gameSets = content[1].Split(';');
    bool possible = true;
    foreach (string colour in gameSets.Select(set => set.Split(',')).SelectMany(subset => subset))
    {
        if (colour.Contains("blue"))
        {
            int blue = int.Parse(colour.Trim().Split(' ')[0]);
            if (blue > colourLimit["blue"])
            {
                possible = false;
                break;
            }
        }
        if (colour.Contains("red"))
        {
            int red = int.Parse(colour.Trim().Split(' ')[0]);
            if (red > colourLimit["red"])
            {
                possible = false;
                break;
            }
        }
        if (colour.Contains("green"))
        {
            int green = int.Parse(colour.Trim().Split(' ')[0]);
            if (green > colourLimit["green"])
            {
                possible = false;
                break;
            }
        }
    }

    if (possible)
    {
        sum += int.Parse(content[0].Split(' ')[1]);
    }

}
Console.WriteLine(sum);

//Part 2
string[] input = File.ReadAllLines("input.txt");
int sum = 0;
foreach (string s in input)
{
    string[] content = s.Split(':');
    string[] gameSets = content[1].Split(';');
    int smallBlue = 1;
    int smallRed = 1;
    int smallGreen = 1;
    foreach (string colour in gameSets.Select(set => set.Split(',')).SelectMany(subset => subset))
    {
        if (colour.Contains("blue"))
        {
            int blue = int.Parse(colour.Trim().Split(' ')[0]);
            if (blue > smallBlue)
            {
                smallBlue = blue;
            }
        }
        if (colour.Contains("red"))
        {
            int red = int.Parse(colour.Trim().Split(' ')[0]);
            if (red > smallRed)
            {
                smallRed = red;
            }
        }
        if (colour.Contains("green"))
        {
            int green = int.Parse(colour.Trim().Split(' ')[0]);
            if (green > smallGreen)
            {
                smallGreen = green;
            }
        }
    }

    sum += smallGreen * smallBlue * smallRed;

}
Console.WriteLine(sum);