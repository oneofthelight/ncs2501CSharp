using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.IO.Compression;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

class Sample
{
    public void Operator()
    {
        //조건 연산자
        //int val = (a>b) ? a : b;
        //int? iii = null;
        //i = iii ?? 0;
        string ss;
        int s = 0;
        if (s == null)
        {
            ss = string.Empty;
        }
        else 
        {
            //ss = s;
        }

    }

    enum City 
    {
        PyungYang,
        Seoul,
        Deajun,
        Busan = 5,
        Jeju = 10
    }
    [Flags]
    enum    Border
    {
        None = 0,
        Top = 1,
        Right = 2,
        Bottom = 4,
        Left = 8
    }
    public void EnumSample()
    {
        City myCity;
        myCity = City.Seoul;
        int cityValue = (int)myCity;
        if (myCity == City.Seoul)
        {
            Console.WriteLine("Welcome to Seoul");
        }
        Border b = Border.Top | Border.Bottom | Border.Left;
    // & 연산자로 플래그 체크
    if ((b & Border.Top) != 0)
        {
        //HasFlag()이용 플래그 체크
        if (b.HasFlag(Border.Bottom))
            {
            // "Top, Bottom" 출력
            Console.WriteLine(b.ToString());
            }
        }
    }

    public void StringSample()
    {
        string s1 = "C#";
        string s2 = "Programming";
        //char c1 = 'A';
        //char c2 = 'B';
        char [] c3 = new char[]{'a','b','c','d','e'};
        string s3 = s1 + " " + s2;
        //Console.WriteLine("String: {0} {1}", s3, 10);

        string s3substring = s3.Substring(1,5);
        //Console.WriteLine("Substring : {0}", s3substring);

        string s = "C# Studies";
        for (int i = 0; i < s1.Length; i++)
        {
            Console.WriteLine("{0}: {1}", i, s[i]);
        }

        string str = "Hello";
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++) 
        {
            Console.WriteLine(charArray[i]);
        }

        char[] charArray2 = {'A','B','C','B'};
        s = new string(charArray2);
        Console.WriteLine(s);

        char c1 = 'A';
        char c2 = (char)(c1 + 3);
        Console.WriteLine(c2);
    }
    public void Dictionary()
    {
        // var    
        var chr = new List<char>();
        var dic = new Dictionary<int, int>();

        // hashtable
        Hashtable ht = new Hashtable();
        ht.Add("irina", "Irina SP");
        ht.Add("tom", "Tom Cr");

        if (ht.Contains("tom"))
        {
            Console.WriteLine(ht["tom"]);
        }
        // Dictoinary
        Dictionary<int, string> emp = new Dictionary<int, string>();
        emp.Add(1001, "Jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");

        Console.WriteLine("Count:" + emp.Count);

        string name = emp[1002];
        Console.WriteLine(name);
        if (emp.ContainsKey(1004))
        {
            name = emp[1004];
            Console.WriteLine(name);
        }

    }
    public void Array()
    {


        // 1차 배열
        string[] players = new string[10];
        Console.WriteLine("players:" + players.Length);
        int[] intarray = new int[100];
        Console.WriteLine("intarray:" + intarray.Length);
        char[] cc = new char[5];
        int[] abc = new int[3] { 1, 2, 3 };
        string[] Regions = new string[3] { "seoul", "kk", "busan" };

        //2
        string[,] Depts = new string[2, 2];
        Console.WriteLine("Depts:" + Depts.Length);
        int[,] inta2 = new int[3, 2] { { 1, 2 }, { 2, 3 }, { 3, 4 } };
        Console.WriteLine("inta2:" + inta2.Length);

        //3
        string[,,] Cubes = new string[2, 3, 4];
        Console.WriteLine("Cubes:" + Cubes.Length);

        int[][] ii = new int[2][];
        int[][] iii = new int[3][];
        iii[0] = new int[2] { 1, 2 };
        iii[1] = new int[2] { 2, 3 };
        iii[2] = new int[2] { 3, 4 };

        int sum = 0;
        int[] scores = new int[] { 80, 78, 60, 90, 100 };
        for (int i = 0; i < scores.Length; i++)
        {
            // sum = sum + scores[i];
            // sum -= scores[i];
            // sum *= scores[i];
            // sum /= scores[i];
            sum += scores[i];
        }
        Console.WriteLine("sum : " + sum);

        int[] ss = new int[100];
        ss[0] = 90;
        int val = ss[0];
    }
    public void RandomSum()
    {
        // random
        int sum = 0;
        int[] nums = new int[10];

        Random rand = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next() % 100;
            Console.WriteLine("nums[" + i + "]:" + nums[i]);
        }
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        Console.WriteLine(sum);
    }
    void Datatype()
    {
        bool b = true;

        //Numberic
        short sh = -32768;
        int i = 2147483647;
        long l = 12341L;
        float f = 123.45F;
        double d1 = 123.45;
        double d2 = 123.45D;
        decimal d = 123.45M;

        //Char/Sting
        char c = 'A';
        string s = "Hello";

        if (s[1] == 'e')
            b = true;
        else
            b = false;

        //DateTime  2011 - 10 - 30 12:35
        DateTime dt = new DateTime(2011, 10, 30, 12, 35, 0);

        //max, min
        int i2 = int.MaxValue;
        float f2 = float.MinValue;

        //기억해야 되는 detatype
        //bool, char, int, short
    }

}