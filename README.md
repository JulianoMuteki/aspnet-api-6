# aspnet-api-6
Authentication and Authorization

## User secrets 
dotnet user-secrets init
dotnet user-secrets list
dotnet user-secrets set "AuthorApiKey" "xyz1@3"

var authorApiKey = Configuration.GetValue<string>("AuthorApiKey");
