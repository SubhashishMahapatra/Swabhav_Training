using System.Text;

public class StringDemo1
{
    static void Main(string[] args)
    {
        string name = new string("Ram");
        name.Concat("Patil"); 
        Console.WriteLine(name); //print Ram as name.Concate has been not assigned to any variable

        StringBuilder sb = new StringBuilder("Subhashish");
        sb.AppendLine(" Mahapatra");
        Console.WriteLine(sb); //prints Subhashish Mahapatra
    }
}

