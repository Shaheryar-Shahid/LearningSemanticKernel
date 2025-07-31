using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.Ollama;
using System.Net.Http;

class Program
{
    static async Task Main(string[] args)
    {
        // Define base URL and model
        var baseUrl = "http://localhost:11434";
        var model = "llama3";

        // Create the kernel
        var builder = Kernel.CreateBuilder();
        builder.AddOllamaChatCompletion(model,new Uri(baseUrl));
        var kernel = builder.Build();

        // Simple user prompt
        var prompt = "Tell me a fun fact about space.";
        var result = await kernel.InvokePromptAsync(prompt);

        Console.WriteLine("Model Response:\n" + result);
    }
}