using System;
using System.Threading;
//非阻塞同步通常指的是使用像是多執行緒、事件或回調等機制，來達成多個操作可以並行執行但不需要等待各自完成的目標。這些操作是同步的，因為它們不使用非同步編程的async和await關鍵字。
class Program
{
    static void Main(string[] args)
    {
        // 開始一個新的執行緒來執行耗時的操作
        Thread newThread = new Thread(DoSomethingTimeConsuming);
        newThread.Start();

        // 主執行緒繼續執行其他工作
        DoSomethingElse();

        // 等待新執行緒完成（可選，視需求而定）
        newThread.Join();

        Console.WriteLine("All tasks are complete.");
    }

    static void DoSomethingTimeConsuming()
    {
        // 模擬耗時的操作
        Thread.Sleep(3000);
        Console.WriteLine("Time-consuming task is complete.");
    }

    static void DoSomethingElse()
    {
        Console.WriteLine("Doing something else...");
    }
}