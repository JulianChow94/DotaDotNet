@echo off

dotnet restore && dotnet build || CALL: DetectErrors

echo.
echo.
echo.

echo ***RUNNING UNIT TESTS***
echo.
dotnet test DotaApiUnitTests/DotaApiUnitTests.csproj || CALL: DetectErrors

:DetectErrors
if %ERRORLEVEL% == 0 exit

