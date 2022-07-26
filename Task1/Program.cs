// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, 
// начинающихся на гласную букву.

// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

string[] RandomWords ={"qwe", 
                      "wer", 
                      "ert", 
                      "rty", 
                      "tyu",
                      "yuy",
                      "asdf"};

int FindWords(string[] words)
{
    int count = 0;
    for(int i = 0; i < words.Length; i++)
    {
        if(words[i][0] == 'a'||
           words[i][0] == 'e'||
           words[i][0] =='y'||
           words[i][0] == 'u'||
           words[i][0] == 'i'||
           words[i][0] == 'o')
        {
            count ++;
        }
    }
    return count;
}
Console.WriteLine(FindWords(RandomWords));