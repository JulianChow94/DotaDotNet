#exit if any command fails
set -e

dotnet restore && dotnet build
cd DotaApiUnitTests
echo "***RUNNING UNIT TESTS***"
dotnet test 