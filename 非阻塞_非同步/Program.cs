using System;
using System.Net.Http;
using System.Threading.Tasks;
//在C#中，非阻塞非同步（Non-blocking Asynchronous）通常是透過async和await關鍵字來實現的。以下是一個簡單的非阻塞非同步的範例，這個範例中會進行一個耗時的網路請求，同時也會執行其他任務。
class Program
{
    static async Task Main(string[] args)
    {
        // 非阻塞非同步的網路請求
        Task<string> getStringTask = FetchDataFromWebAsync("https://www.example.com");

        // 在等待網路請求完成的同時，做其他事情
        DoSomethingElse();

        // 現在等待非同步任務完成，並獲取結果
        string result = await getStringTask;

        // 使用網路請求的結果
        Console.WriteLine(result);
    }

    static async Task<string> FetchDataFromWebAsync(string url)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            string result = await httpClient.GetStringAsync(url);
            return result;
        }
    }

    static void DoSomethingElse()
    {
        Console.WriteLine("Doing something else...");
    }
}
