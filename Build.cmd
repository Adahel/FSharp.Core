@echo off
cls
powershell -ExecutionPolicy ByPass -NoProfile -command "& """%~dp0eng\build.ps1""" -build -restore %*"
