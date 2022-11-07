@echo off

Taskkill /f /im autoUpdate.exe
:exit
REM -- INSTALL THE DOWNLOADED/UPDATED APP
msiexec.exe /i "C:\Users\Acer\Downloads\location\update.msi" /QN
REM -- delete the installer
del "C:\Users\Acer\Downloads\location\update.msi"
rem start the application when the installation complete
cd "C:\Program Files\JeovDev\autoUpdateInstaller"
start autoUpdate.exe