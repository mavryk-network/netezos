build:
	dotnet build .

test:
	dotnet test Netmavryk.Tests --nologo --verbosity normal --filter FullyQualifiedName!~Rpc