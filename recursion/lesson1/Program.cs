//  Cоздать строку от a до b, a<=b

/* string Qwerty (int a, int b)
{
    if (a<=b) return Qwerty(a+1, b) +$"{a} ";
    return String.Empty;
}
System.Console.WriteLine(Qwerty(1, 10)); */



//  Сумма чисел от 1 до a

/* int SumRec (int a)
{
    if (a == 0) return 0;
    else return a + SumRec (a - 1);
}
System.Console.WriteLine(SumRec(10)); */



//   Найти факториал числа

/* int FactorialRec (int a)
{
    if(a == 1) return 1;
    else return a * FactorialRec(a - 1);
}
System.Console.WriteLine(FactorialRec(10));
 */


// Возведение в степень a^n

int PowerRec(int a, int n)
{  // return n ==0 ? 1 :PowerRec(a, n - 1) * a;   //  Вариант исполнения кода
    if (n==0) return 1;
    else return PowerRec (a, n - 1) * a;
}
System.Console.WriteLine(PowerRec(2, 10));


/* Имеется некоторый алфавит, состоящий из четырёх букв, 
и нас просят показать все возможные слова, состоящие из T букв. 
Т может равняться 1, 2, 3 и так далее.
 */

 /* 
int n = 1;
void FindWord (string alphabet, char[] word, int length = 0)
{
    if (length ==word.Length)
    {
        System.Console.WriteLine($"{ n ++} {new String(word)}"); return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWord(alphabet, word, length + 1);
    }
}

FindWord("аисв", new char[5]); */



//  Как смотреть содержимое папки
/* 
string path = "C:/Users/xapic/Desktop/python/Introduction_to_C#/leson5";
DirectoryInfo di = new DirectoryInfo (path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for(int i=0; i<fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
 */



 //  Как смотреть дерево папок и файлов

/*  void CatalogInfo (string path, string indent = "")
 {
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo [] catalogs =  catalog.GetDirectories();
    for(int i=0; i < catalogs.Length; i++)
    {
        System.Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");

    }
    FileInfo [] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        System.Console.WriteLine($"{indent}{files[i].Name}");
    }
    
 }

 string path = "C:/Users/xapic/Desktop/python/Introduction_to_C#/leson5";
 CatalogInfo(path); */



