// Dzień 5
int number = 1985202337;
string numberToString = number.ToString();
char[] letters = numberToString.ToArray();
int[] result = new int[10];

foreach (var oneLetter in letters)
{
    for (int i = 0; i < result.Length; i++)

    {
        string numberToString2 = i.ToString();
        char[] tmp = numberToString2.ToArray();

        if (oneLetter == tmp[0])
        {
            result[i]++;
        }
    }
}

for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(i + " => " + result[i]);
}