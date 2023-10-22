using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    //阻塞同步是最常見和基本的一種操作模式。在這種模式下，當一個操作（如檔案讀取、網絡請求等）正在進行時，程式將會停下來等待該操作完成。
    internal class Program
    {
        static void Main(string[] args)
        {
            //sleep、IO操作 ex:寫很大檔
            Thread.Sleep(10000);
            Console.WriteLine("Hello world!");
        }
    }
}