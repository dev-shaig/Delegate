using System.Collections;

namespace Delegate
{
    internal class Program
    {
        //public delegate bool CheckNums(int num);
        //public delegate void ChangeString(string str);
        static void Main(string[] args)
        {
            #region Stack, Queue, Dictionary
            //Stack<int> stack = new();
            //stack.Push(1);
            //stack.Push(65);
            //stack.Push(999);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);

            //}

            //Queue<int> queue = new();
            //queue.Enqueue(1);
            //queue.Enqueue(65);
            //queue.Enqueue(999);

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<string, string> dictionary = new();
            //dictionary.Add("Adress", "Baku");
            //dictionary.Add("Email", "bilalabbasov@gmail.com");
            //dictionary.Add("Tel", "+994555678912");

            //foreach (KeyValuePair<string, string> item in dictionary)
            //{
            //    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            //}
            //Console.WriteLine(dictionary["Adress"]);
            #endregion

            #region Delegate 
            //int[] nums = { 2, 55, 69, 99 };

            //Console.WriteLine(CheckAndSumNum(CheckEven, nums));
            //Console.WriteLine(CheckAndSumNum(CheckOdd, nums));
            //Console.WriteLine(CheckAndSumNum(CheckGreaterFive, nums));

            //List<int> list = new() { 1, 3, 4, 999, 45, 739, 0, 2 };

            //var result = list.Find(n => n > 3);

            //Test();

            //Console.WriteLine(result);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);

            //}

            //StringToUpper("Nail");
            //StringToLower("Mail");
            //ChangeStr(StringToUpper, "Mail");

            //ChangeString stringChange = new(StringToUpper);
            //stringChange.Invoke("Avaz");

            //ChangeString stringChange = StringToUpper;
            //stringChange += delegate (string s)
            //{
            //    Console.WriteLine(s.ToLower());
            //};

            //stringChange("Mail");



            #endregion

            #region Task

            List<string> stringList = new() { "Mail", "Nail", "Zaur", "Zahir", "Abbas", "Eli", "MirRauf", "ElnurTalibovIlqarOglu", "Ibragimov" };

            var result = MatchString(CheckStringLength, stringList);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            #endregion


        }




        #region Practice
        //public static void ChangeStr(ChangeString match, string word)
        //{
        //    match(word);
        //}


        //public static void StringToUpper(string text)
        //{
        //    Console.WriteLine(text.ToUpper());
        //}

        //public static void StringToLower(string text)
        //{
        //    Console.WriteLine(text.ToLower());
        //}

        //public static void Test() => Console.WriteLine("Hello APA101"); 

        //public static bool CheckOdd(int number)
        //{
        //    return number % 2 != 0;
        //}

        //public static bool CheckEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public static bool CheckGreaterFive(int number)
        //{
        //    return number > 5;
        //}


        //public static int CheckAndSumNum(Predicate<int> func, int[] arr)
        //{
        //    int sum = 0;

        //    foreach (var item in arr)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;

        //        }

        //    }
        //    return sum;
        //}
        #endregion

        #region Task

        public static bool CheckStringLength(string str)
        {
            return str.Length < 5;
        }

        public static List<string> MatchString(Predicate<string> func, List<string> stringList)
        {
            List<string> filteredList = new();

            foreach (var item in stringList)
            {
                if (func(item))
                {
                    filteredList.Add(item);
                }
            }
            return filteredList;
        }

        #endregion

    }
}
