using System;
using System.Net.Http;
using System.Threading.Tasks;
//"阻塞非同步"是一個相對少見的情況，因為通常非同步操作都是為了避免阻塞。但有些時候，特殊的需求或者不熟悉非同步編程的開發者可能會創造出這種情境。
class Program
{
    static void Main(string[] args)
    {
        Task<string> task = FetchDataFromWebAsync("https://www.google.com");

        // 阻塞當前執行緒直到非同步操作完成
        task.Wait();

        // 使用非同步操作的結果
        string result = task.Result;

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
}
