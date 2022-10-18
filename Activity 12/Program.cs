StreamReader inputFile;
List<string> matchingWords = new List<string>();
try
{
    inputFile = File.OpenText("input.txt");
} catch
{
    // error out if file is not found
    Console.WriteLine("Error: file not found");
    return;
}
// split file into words
string[] words = inputFile.ReadToEnd().Split(' ');
for(int i = 0; i < words.Length; i++)
{
    if (isMatching(words[i]))
    {
        matchingWords.Add(words[i]);
    }
}

Console.WriteLine("In the file there were");
Console.WriteLine(words.Length + " words");
Console.WriteLine(matchingWords.Count + " words ended in t or e:");
for (int i = 0; i < matchingWords.Count; i++)
{
    Console.WriteLine(matchingWords[i]);
}

// check if last letter is e or t
bool isMatching(string word)
{
    // move back to last letter if last char is not a letter
    int i = word.Length - 1;
    while(!Char.IsLetter(word[i]))
    {
        i--;
    }
    
    if (word[i] == 'e' || word[i] == 't') return true;
    return false;
}

