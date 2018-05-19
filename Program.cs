using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace src
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] input = new int[]{2,7,11,15};
            //int target = 9;
            //sumoftwo(input, target);
            //reverseint(421);
            //bool valid = permutationpalindrome("TACT COA");
            //bool valid = oneaway("PALE", "PSLA");

            //string compressedString = stringcompression("aaabbcccccaa");

            //rotatematrix();

            // LinkedList.AddNodeStart(5);
            // LinkedList.AddNodeStart(6);
            // LinkedList.AddNodeStart(2);
            // LinkedList.AddNodeStart(1);
            // LinkedList.AddNodeStart(5);
            // LinkedList.AddNodeStart(12);

            // LinkedList.insertatnth(11, 3);
            // LinkedList.printlist();

            // LinkedList.delete(3);
            
            // LinkedList.printlist();

            //LinkedList.reverse();

            //LinkedList.printll();

            //LinkedList.removedups();

            //LinkedList.findkthtolast(4);

            //LinkedList.partition(5);

            // Node node1 = new Node();
            // node1.AddNodeStart(node1, 3);
            // node1.AddNodeStart(node1, 2);
            // node1.AddNodeStart(node1, 1);

            // Node node2 = new Node();
            // node2.AddNodeStart(node2, 8);
            // node2.AddNodeStart(node2, 9);
            // node2.AddNodeStart(node2, 9);

            // LinkedList.addLists(node1, node2);

            LinkedList.printlist();

            Console.ReadLine();
        }

        

        private static void rotatematrix()
        {
            int N=4;

            int[,] mat = { {1, 2, 3, 4},
                         {5, 6, 7, 8},
                         {9, 10, 11, 12},
                         {13, 14, 15, 16}
                        };
            
            for (int i=0; i< N/2; i++)
            {
                for (int j=i; j< N-i-1; j++)
                {
                    int temp = mat[i,j];

                    mat[i,j] = mat[j, N-i-1];

                    mat[j, N-i-1] = mat[N-1-i, N-1-j];

                    mat[N-1-i, N-1-j] = mat[N-1-j, i];

                    mat[N-1-j, i] = temp;
                    
                }
            }
        }

        private static string stringcompression(string str)
        {
            StringBuilder sb = new StringBuilder();
            int counter=0;

            for(int i=0; i< str.Length; i++)
            {
                counter ++;

                if(i+1 >= str.Length || str[i+1] != str[i])
                {
                    sb.Append(str[i]);
                    sb.Append(counter);

                    counter = 0;
                }
            }

            return sb.Length < str.Length ? sb.ToString() : str;
        }

        private static bool oneaway(string str1, string str2)
        {
            int index1  = 0;
            int index2 = 0;


            while (index2 < str2.Length && index1 < str1.Length) 
            {
                if (str1[index1] != str2[index2]) 
                { 
                    if (index1 != index2) 
                    {
                        return false;
                    }
                    index2++; 
                }
                else {
                    index1++;
                    index2++; 
                    }
            }
            return true;
        }

            // var ds = new Dictionary<char, int>();
            // int countodd = 0;

            // foreach (char c in str1)
            // {
            //     if(ds.ContainsKey(c)) {
            //         ds[c] = ++ds[c];
            //         countodd--;
            //         }
            //     else { 
            //         ds.Add(c, 1); 
            //         countodd++;
            //         }
            // }
            // foreach (char c in str2)
            // {
            //     if(ds.ContainsKey(c)) {
            //         ds[c] = ++ds[c];
            //         countodd--;
            //         }
            //     else { 
            //         ds.Add(c, 1); 
            //         countodd++;
            //         }
            // }

            // int diff = Math.Abs(str1.Length - str2.Length);

            // if(diff == 0 && countodd==2) return true;
            // if(diff == 1 && countodd==1) return true;
            // else return false;

        private static bool permutationpalindrome(string str)
        {
            bool valid = false;
            var hash = new HashSet<char>();
            var ds = new Dictionary<char, int>();
            int countodd = 0;

            foreach (char c in str)
            {
                if(c != ' ')
                {
                    if(ds.ContainsKey(c))
                    {
                        ds[c] = ++ds[c];
                        countodd--;
                    }
                    else
                    {
                        ds.Add(c, 1);
                        countodd ++;
                    }
                    if(ds[c] > 2 )
                        valid = false;
                }

            }
            
                if(countodd <=1)
                    valid = true;

                    return valid;
        }

        private static void sumoftwo(int[] arr, int target)
        {
            if(arr.Length <2)
            {
                Console.WriteLine("invalid input");
            }
            Dictionary<int, int> ht = new Dictionary<int, int>();
            
            for(int i=0; i<arr.Length; i++)
            {
                int complement = target-arr[i];
                if(ht.ContainsKey(complement))
                {
                    Console.WriteLine(ht[complement]);
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    ht.Add(arr[i], i);
                }
            }
        }

//421
        private static void reverseint(int val)
        {
            int rem = 0;
            int mul = 1;
            int newval = 0;
            while(val >0)
            {
                val = val/10; // 21
                rem = val%10; // 4
                newval = rem * mul + newval;
                mul = mul *10;
            }
        }

    }
}
