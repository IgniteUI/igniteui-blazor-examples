@echo off
REM ECHO cleanup %cd% ...
FOR %%I IN (.) DO set TARGET=%%~nxI
ECHO cleanup %TARGET% ...

ECHO - removing %TARGET%\**\BIN folders in all samples:
REM FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin*') DO echo "%%G"
    FOR /F "tokens=*" %%G IN ('DIR /B /AD /S bin') DO RMDIR /S /Q "%%G"

ECHO - removing %TARGET%\**\OBJ folders in all samples:
FOR /F "tokens=*" %%G IN ('DIR /B /AD /S obj') DO RMDIR /S /Q "%%G"

ECHO cleanup %TARGET% completed.
pause

 