using System;
namespace Bai3_1
{
    class BaiTapVeNha
    {
        public static Boolean checksonguyento(int n)
        {
            bool check = true;
            for (int i = 2; i < n; i++)
                if (n % i == 0) 
                    check = false;
                if (check) 
                    return true;
                else return false;
        }
        static void Main(string[] args)
        {
            int[] mang = { 1, 2, 3, 8, 5, 6, 7, 4, 9, 10 };
            int start = 0;
            int end = 9;
            int min = 0;
            float trungbinhcong = 0;
            int tongmang = 0;
            int arr;
            for (int i = 0; i < mang.Length; i++)
            {
                if(min > mang[i])
                    min = mang[i];
            }
            Console.WriteLine("Phan tu nho nhat cua mang tren la:{0}",min);
            while (start < end)
            {
                int a = mang[start];
                mang[start] = mang[end];
                mang[end] = a;
                start++;
                end--;

            }Console.WriteLine("Mang Dao Nguoc Lai La:");
            for (int i = 0;i < mang.Length;i++)
            {
                Console.WriteLine("{0 }",mang[i]);
            }
            for (int i = 0; i < mang.Length-1; i++)
            {
               for (int j = i+1; j < mang.Length; j++)
                {
                    if (mang[i] < mang[j])
                    {
                        arr = mang[i];
                        mang[i] = mang[j];
                        mang[j] = arr;
                    }
                }               
            }
            Console.Write("Mang Sap Xep Lai La:");
            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write("{0} ", mang[i]);
            }
            Console.Write("So nguyen to trong mang tren la la : ");
            for (int i = 0; i < mang.Length; i++)
            {
                if (checksonguyento(mang[i]))
                    Console.Write("{0} ",mang[i]);
            }
            for (int i = 0; i < mang.Length; i++)
            {
                tongmang += mang[i];
                trungbinhcong= tongmang/mang.Length;
            }
            Console.Write("\nTong trung binh cong :{0}", trungbinhcong);
        }        
    }
}
