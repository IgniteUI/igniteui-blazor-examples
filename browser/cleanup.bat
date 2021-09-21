@echo off
REM ECHO cleanup %cd% ...
REM FOR %%I IN (.) DO set TARGET=%%~nxI
REM ECHO cleanup %TARGET%\bin ...
 
ECHO cleanup browser's folders ...
IF EXIST IgBlazorSamples.Client\bin\ (
   RMDIR /S /Q IgBlazorSamples.Client\bin
)  
IF EXIST IgBlazorSamples.Client\obj\ (
   RMDIR /S /Q IgBlazorSamples.Client\obj
)  

REM RMDIR /S /Q IgBlazorSamples.Client\bin
REM RMDIR /S /Q IgBlazorSamples.Client\obj
REM RMDIR /S /Q IgBlazorSamples.Core\bin
REM RMDIR /S /Q IgBlazorSamples.Core\obj
REM RMDIR /S /Q IgBlazorSamples.Server\bin
REM RMDIR /S /Q IgBlazorSamples.Server\obj
REM RMDIR /S /Q IgBlazorSamples.Shared\bin
REM RMDIR /S /Q IgBlazorSamples.Shared\obj

REM ECHO - removing %TARGET%\**\BIN folders in all samples:
REM REM FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin*') DO echo "%%G"
REM     FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin') DO RMDIR /S /Q "%%G"

REM ECHO - removing %TARGET%\**\OBJ folders in all samples:
REM FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj') DO RMDIR /S /Q "%%G"

ECHO cleanup browser's folders completed.
pause

 