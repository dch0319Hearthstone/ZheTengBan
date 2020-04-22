@echo off
set d=%date%
date 2020-1-24
cd /d %~dp0
start Hearthbuddy.exe
ping -n 5 127.0.0.1>nul
date %d%