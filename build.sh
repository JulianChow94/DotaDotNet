#exit if any command fails
set -e

dotnet restore && dotnet build
cd DotaApiUnitTests
echo "***RUN DOTNET TEST***"
dotnet test 