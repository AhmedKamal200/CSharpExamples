using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AsyncFunctions
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // --- Main Entry Point ---
            // Demonstrates asynchronous programming in C#
            // Option 1: Using Task and GetAwaiter (Commented out for now)
            // Option 2: Using async/await for a cleaner, more modern approach

            // -- Option 1: Task and GetAwaiter (Commented out) --
            // Creates a task that executes the ReadContent method
            // var task = Task.Run(() => ReadContent("https://www.youtube.com/c/Metigator"));

            // Obtains the awaiter for the task
            // var awaiter = task.GetAwaiter();

            // Defines an action to run when the task is completed
            // Outputs the task result to the console
            // awaiter.OnCompleted(() => Console.WriteLine(awaiter.GetResult()));

            // -- Option 2: Using async/await (Active) --
            // Calls the asynchronous version of ReadContentAsync and waits for the result
            Console.WriteLine(await ReadContentAsync("https://www.youtube.com/c/Metigator"));

            // Prevents the console from closing immediately
            Console.ReadKey();
        }

        // --- Synchronous Task-Based Method ---
        // Returns a Task<string> that fetches the content of a URL
        // This method does not use async/await and directly returns the task
        static Task<string> ReadContent(string url)
        {
            // Creates an HTTP client for sending requests
            var client = new HttpClient();

            // Starts an asynchronous operation to get the string content of the URL
            var task = client.GetStringAsync(url);

            // Returns the ongoing task to the caller
            return task;
        }

        // --- Asynchronous Method ---
        // Uses async/await to fetch the content of a URL and return it as a string
        static async Task<string> ReadContentAsync(string url)
        {
            // Creates an HTTP client for sending requests
            var client = new HttpClient();

            // Awaits the asynchronous operation to fetch the string content of the URL
            var content = await client.GetStringAsync(url);

            // Returns the downloaded content to the caller
            return content;
        }
    }
}
