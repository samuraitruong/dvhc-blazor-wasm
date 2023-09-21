# Makefile for running a .NET Core project with dotnet watch run

# Set the name of your .NET Core project here
PROJECT_NAME = .

.PHONY: run

dev:
	dotnet watch run --project $(PROJECT_NAME)

build:
	dotnet build

publish:
	dotnet publish  -o out