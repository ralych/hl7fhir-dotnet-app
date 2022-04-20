# A HL7 FHIR .Net APP

## create with visual studio code (Linux)
mkdir hl7fhir-dotnet-app
cd hl7fhir-dotnet-app
dotnet new console


## add FHIR .Net library
dotnet add package Hl7.Fhir.R4
dotnet add package Hl7.Fhir.Serialization


## run the app
dotnet run

