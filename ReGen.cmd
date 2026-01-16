@echo off
rem on next line " Win64 Development Nyet" is Platform, Configuration, Target
@echo on
rem "c:\EpicGames\UE_5.7\Engine\Binaries\DotNET\UnrealBuildTool\UnrealBuildTool.exe" -mode=Clean -project=%cd%\Nyet.uproject Win64 Development Nyet -2026
"c:\EpicGames\UE_5.7\Engine\Binaries\DotNET\UnrealBuildTool\UnrealBuildTool.exe" -mode=GenerateProjectFiles -2026 -VeryVerbose -project=%cd%\OceanTutorial.uproject -game -rocket -progress 