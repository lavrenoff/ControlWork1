Console.Write("Введите количество массивов:");
int massivLength= Convert.ToInt32(Console.ReadLine());

string[] str=new string[massivLength];
for (int i =0; i < massivLength; i++)
     {
     Console.Write((i+1)+" массив=");
     str[i]=Console.ReadLine();
     }


Console.Write(PrintMassiv(str));

string PrintMassiv(string[] massiv)     
{
string str = "";    
for (int i =0; i < massiv.Length; i++)
    if (massiv[i].Length <= 3)
        str=str+massiv[i]+" ";

return str;        
}

