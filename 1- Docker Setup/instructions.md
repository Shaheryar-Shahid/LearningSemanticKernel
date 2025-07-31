## Enable Required Windows Features
Open PowerShell as Administrator and run:

``` 
dism.exe /online /enable-feature /featurename:Microsoft-Windows-Subsystem-Linux /all /norestart

dism.exe /online /enable-feature /featurename:VirtualMachinePlatform /all /norestart
```

Restart your computer after running the above commands.

## Install WSL 2 Kernel
Open PowerShell as Administrator and run:

```
wsl --install
```
This command:
- Enables required features (WSL and Virtual Machine Platform)
- Installs the WSL 2 kernel
- Installs Ubuntu (default)
- Sets WSL 2 as the default version

Now restart the PC once prompted

## Install Docker Desktop for Windows

- Visit: https://www.docker.com/products/docker-desktop
- Download the Windows Installer.
- Run the installer and follow the instructions.
- When prompted:
    - Enable WSL 2 as the backend
    - Select the distributions you want Docker to work with (if applicable)
