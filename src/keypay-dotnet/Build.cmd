@echo off
@echo.
@echo *********************
@echo Building KeyPayDotNet
@echo *********************
dotnet build
@echo.
@echo ***************************
@echo Copying files to lib folder
@echo ***************************
@echo on
if exist "<c:\mail>\parameters.txt" (
    set /p Var=<"<c:\mail>\parameters.txt"
	copy bin\Debug\netstandard2.0\KeyPayV2.* %Var% 
) else (
    copy bin\Debug\netstandard2.0\KeyPayV2.* c:\Projects\keypay-dev\lib /y
)
