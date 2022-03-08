// See https://aka.ms/new-console-template for more information




class MainClass
{

    public static string SearchingChallenge(string str)
    {
        string[] ary = new string[str.Split(' ').Length];
        int[] repeatNo = new int[15];
        int index = 0;
        ary = str.Split(' ');

        for (int i = 0; i < ary.Length; i++)
        {
            string word = ary[i];
            for (int k = 0; k < word.Length; k++)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    if (word[k]==word[j])
                    {
                        index++;
                    }
                }
                repeatNo[k] = index;
                index = 0;
            }
        }
        return ary[1];  

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(SearchingChallenge(Console.ReadLine()));
    }

}
