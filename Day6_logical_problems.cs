using System;
using System.Diagnostics;
using System.Threading.Tasks;
public class FibonacciExample  
   {  
     public static void Main(string[] args)  
      {
        Console.WriteLine("Press 1 for Fibonacci series \n 2 for Perfect Number \n 3 for prime number \n 4 for Reversing a number \n 5 for Coupon numbers \n 6 for Stopwatch Simulation ");
        int user_input= int.Parse(Console.ReadLine());
        switch (user_input)
        {
            case 1:
                int n1 = 0, n2 = 1, n3, i, number;
                Console.Write("Enter the number of elements: ");
                number = int.Parse(Console.ReadLine());
                Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
                for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
                {
                    n3 = n1 + n2;
                    Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
                break;
            case 2:
                int n, i, sum;
                int mn, mx;

                Console.Write("\n\n");
                Console.Write("Find perfect numbers within a given number of range:\n");
                Console.Write("------------------------------------------------------");
                Console.Write("\n\n");

                Console.Write("Input the starting range or number : ");
                mn = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the ending range of number : ");
                mx = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Perfect numbers within the given range : ");
                for (n = mn; n <= mx; n++)
                {
                    i = 1;
                    sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.Write("{0} ", n);
                }
                break;
            case 3:
                int n, i, m = 0, flag = 0;
                Console.Write("Enter the Number to check Prime: ");
                n = int.Parse(Console.ReadLine());
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        Console.Write("Number is not Prime.");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                    Console.Write("Number is Prime.");
                break;
            case 4:
                int n, reverse = 0, rem;
                Console.Write("Enter a number: ");
                n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    rem = n % 10;
                    reverse = reverse * 10 + rem;
                    n /= 10;
                }
                Console.Write("Reversed Number: " + reverse);
                break;
            case 5:
                char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".toCharArray();
                int max = 100000000;
                int random = (int)(Math.random() * max);
                StringBuffer sb = new StringBuffer();

                while (random > 0)
                {
                    sb.append(chars[random % chars.length]);
                    random /= chars.length;
                }

                String couponCode = sb.toString();
                System.out.println("Coupon Code: " + couponCode);
                break;
            case 6:
                var watch = Stopwatch.StartNew();

                for (var i = 0; i < 2; i++)
                {
                    using (var task = Task.Delay(1000))
                    {
                        task.Wait();
                    }

                    watch.Stop();

                    using (var task = Task.Delay(1000))
                    {
                        task.Wait();
                    }

                    watch.Start();
                }

                watch.Stop();

                Console.WriteLine("Time elapsed: " + watch.Elapsed);
                break;
                default:
                Console.WriteLine("Wrong input");
                break;
        }

    }
}  


       
    
