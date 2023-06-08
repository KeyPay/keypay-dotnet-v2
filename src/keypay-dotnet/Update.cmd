@echo off
@echo.
@echo *********************
@echo Copying generated code to source tree
@echo *********************

robocopy . C:\projects\keypay-dev\Basics\Payroll\KeyPayAPIClient *.cs *.csproj /XD bin /XD obj /MIR
