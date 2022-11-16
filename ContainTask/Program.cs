Console.WriteLine("Enter your word");
string word = Console.ReadLine();
int len = word.Length;
Console.WriteLine("Enter your which you find");
string substr = Console.ReadLine();
bool Contain(string substr, int count = 0, bool answer = true)
{
    int a = 0;
    for (int i = 0; i < substr.Length; i++)
    {

        for (int j = a; j < word.Length; j++)
        {
            a++;
            if (substr[i] == word[j])
            {
                count++;
                break;
            }
            else
                count = 0;
        }
        if (count == substr.Length)
            return answer;
    }

    return false;
}
Console.WriteLine(Contain(substr));