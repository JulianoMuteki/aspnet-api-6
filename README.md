# aspnet-api-6
Authentication and Authorization

## User secrets 
 - dotnet user-secrets init
 - dotnet user-secrets list
 - dotnet user-secrets set "AuthorApiKey" "fedaf7d8863b48e197b9287d492b708e"
 or
 - dotnet user-secrets set SecretSettingsOptions:AuthorApiKey fedaf7d8863b48e197b9287d492b708e

Test
curl -X 'GET' -i -k 'https://localhost:7197/v1/account/authenticated' -H 'accept: text/plain' -H "Authorization: Bearer {TOKEN}"
