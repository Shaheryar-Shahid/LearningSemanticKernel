# Running Ollama in Docker
We have 3 different options to run ollama in the docker
- With CPU
- Nvidia GPU
- AMD GPU 

for more details visit https://hub.docker.com/r/ollama/ollama

## Running Ollama with CPU
- navigate to the `Ollama Setup` folder in the command line
- run the following command
```
docker compose u -d
```

This will download the docker image and then orchestrate and run the docker instance.
Once running run the following command to test:

```
curl http://localhost:11434
```

you can also run curl commands like

- Pull a model and chat
```
curl http://localhost:11434/api/pull -d '{"name": "llama3"}'
curl http://localhost:11434/api/chat -d '{
  "model": "llama3",
  "messages": [{"role": "user", "content": "Hello!"}]
}'
```