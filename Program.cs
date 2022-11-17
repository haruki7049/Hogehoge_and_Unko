using System;

namespace fugafuga
{
    public class piyopiyo
    {
        public static int Main(string[] args)
        {
            try
            {
                switch (args[0])
                {
                    case "Unko":
                        Console.WriteLine("Unko!!");
                        break;
                    case "unko":
                        Console.WriteLine("unko...");
                        break;
                    case "hogehoge":
                        Console.WriteLine("hogehoge");
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
                return 0;
            }
            catch (IndexOutOfRangeException)
            {
                if (args.Length <= 0)//値がない場合の判定
                {
                    Console.WriteLine("何か文字をダブルクォーテーションに囲んで入れてください");
                    return -1;
                }
                else if (args.Length >= 2)//値が多すぎる
                {
                    Console.WriteLine("値を一つにしてください");
                    return -1;
                }
                else if (args[0] == String.Empty)//空文字の判定
                {
                    Console.WriteLine("空文字、ダブルクォーテーションに何も入っていない状態です。文字をシングル、ダブルクォーテーションに囲んで入れてください。e.g. hogehoge, Unko, unko");
                    return -1;
                }
                else//その他
                {
                    Console.WriteLine("値が不正です");
                    return -1;
                }
            }
        }
    }
}
