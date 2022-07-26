// Задайте массив строк. Напишите программу, которая 
// генерирует новый массив, объединяя элементы исходного массива попарно.

// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] Massive = {"qwe", "wer", "ert", "rty", "tyu", "yui"};

string[] AddElement(string[] massive)
{
    string[] result = new string[massive.Length /2];

    for(int i =0; i < massive.Length/2; i++)
    {
        result[i] = massive[i]+ massive[i+1];
    }
    return result;
}

void ShowResult(string[] res)
{
    for(int i = 0; i < res.Length; i++)
        Console.Write(res[i] + " ");
}
ShowResult(AddElement(Massive));