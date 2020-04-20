FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime  
WORKDIR /app
COPY ./adminApp/out .
ENTRYPOINT ["dotnet", "adminApp.dll"]
# https://localhost:44304/