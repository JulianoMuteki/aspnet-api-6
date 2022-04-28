# aspnet-api-6
Authentication and Authorization

## User secrets 
 - dotnet user-secrets init
 - dotnet user-secrets list
 - dotnet user-secrets set "AuthorApiKey" "fedaf7d8863b48e197b9287d492b708e"

var authorApiKey = Configuration.GetValue<string>("AuthorApiKey");
