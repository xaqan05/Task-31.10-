using System.Net;

namespace Task_31._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();

            list.Add("Xaqan");
            list.Add("Xaqan");
            list.Add("Xaqan");
            list.Add("Xaqan");
            list.Add("Xaqan");
            list.Add("Xaqan");
            list.Add("Xaqan");
            list.Add("Xaqan");
            list.Add("Xaqan");





            Console.WriteLine(list.arr.Length);

            foreach (var item in list.arr)
            {
                if(item != null)
                {
                    Console.WriteLine(item);
                }
            }


            //string s = list.Find(x => x.EndsWith("n"));
            //Console.WriteLine(s);
        }
    }
}