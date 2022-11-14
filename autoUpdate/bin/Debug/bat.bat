@echo off

Taskkill /f /im autoUpdate.exe
:exit
msiexec.exe /i "C:\Users\Acer\Downloads\location\update.msi" /QN
del "C:\Users\Acer\Downloads\location\update.msi";
cd "C:\Program Files\JeovDev\autoUpdateInstaller"
start autoUpdate.exe
