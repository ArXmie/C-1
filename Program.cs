namespace RuhArteam;

class Program
{
    static void Main(string[] args)
    {
        int[] massive = [ 1, 1, 2 ];
        int uniquenum = 0;
        int[] massive_result = new int[] {};

        for (int i = 0; i < massive.Length; i++)
        {
            for (int j = 0; j < massive.Length; j++){
                if (i < massive.Length - 1 && massive[i] == massive[j]) {
                    massive_result[i - 1] = massive[i];
                    uniquenum++;
                }
            }
        }
        Console.WriteLine(uniquenum);
        
    }
}
