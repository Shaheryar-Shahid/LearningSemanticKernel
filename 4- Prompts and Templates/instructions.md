# Prompts and Templates

This module covers the use of **inline prompts** and **semantic prompt templates** in Semantic Kernel.

## Objectives

- Understand prompt types supported by Semantic Kernel
- Create and organize `.skprompt.txt` templates
- Use variables in prompts
- Bind templates as semantic functions

---

## Prompt Types

### 1. Inline Prompt (C#)

```csharp
var result = await kernel.InvokePromptAsync("What's the capital of Japan?");
```

### 2. Template Prompt (External File)
- File: MyPrompt.skprompt.txt
```
Give a brief description of {{$input}}.
```
- C# usage
```csharp
var function = kernel.CreateSemanticFunctionFromPromptFile("MyPrompt.skprompt.txt");
var result = await function.InvokeAsync("volcanoes");
```

### Some other examples could be 
```
4- Prompts and Templates/
├── DescribeThing.skprompt.txt
├── TranslateText.skprompt.txt
└── instructions.md

```