# Basic Tutorial - Prompt Responses
In this tutorial we will try to do the following

- Build a simple c# program that uses semantic kernel
- Connect to ollama model (we will use llama3)
- Send a user prompt and receive a response

## Prerequisites
### 1- .NET 8 SDK installed
Download and install if required from https://dotnet.microsoft.com/en-us/download/dotnet/8.0
### 2- Ollama running in docker
Verify ollama by using the curl command
```
curl http://localhost:11434/api/pull -d '{"name": "llama3"}'
```

## Step 1 - Create a new console application
```
dotnet new console -n Tutorial_Prompt_Code
cd Tutorial_Prompt_Code
```
## Step 2 - Add Semantic Kernel Package

```
dotnet add package Microsoft.SemanticKernel
dotnet add package Microsoft.SemanticKernel.Connectors.Ollama --version 1.61.0-alpha
```

## Step 3 - Lets do a basic code
### include libraries
```csharp
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Connectors.Ollama;
using System.Net.Http;
```
### define configuration
```csharp
// Define base URL and model
var baseUrl = "http://localhost:11434";
var model = "llama3";
```

### setup the kernel
```csharp
// Create the kernel
var builder = Kernel.CreateBuilder();
var builder = Kernel.CreateBuilder();
builder.AddOllamaChatCompletion(model,new Uri(baseUrl));
var kernel = builder.Build();
```
### simple prompt
```csharp
var prompt = "Tell me a fun fact about space.";
var result = await kernel.InvokePromptAsync(prompt);
```

### print the result
```csharp
Console.WriteLine("Model Response:\n" + result);
```

### Complete Code
```Program.cs```

```csharp
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
```
### Run the App
```
dotnet run
```