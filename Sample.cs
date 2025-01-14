using System.Security.Cryptography.X509Certificates;

class Sample
{

    public void Array()
    {
     // 1차 배열
        string[] players = new string[10];
        Console.WriteLine("players:" + players.Length);
        int[] intarray = new int[100];
        Console.WriteLine("intarray:" + intarray.Length);
        char[] cc = new char[5];    
        int[] abc = new int[3]{1,2,3};
        string[] Regions = new string[3]{"seoul", "kk", "busan"};
        
        //2
        string[,] Depts = new string[2,2];
        Console.WriteLine("Depts:" + Depts.Length);
        int[,] inta2 = new int[3,2]{{1,2},{2,3},{3,4}};
        Console.WriteLine("inta2:" + inta2.Length);

        //3
        string[,,] Cubes = new string[2,3,4];
        Console.WriteLine("Cubes:"+ Cubes.Length);

        int[][] ii = new int[2][];
        int[][] iii = new int[3][];   
        iii[0] = new int[2]{1,2};
        iii[1] = new int[2]{2,3};
        iii[2] = new int[2]{3,4};

        int sum = 0; 
        int[] scores = new int[]{80,78,60,90,100};
        for (int i = 0; i<scores.Length; i++)
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
            Console.WriteLine("nums["+i+"]:" + nums[i]);
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