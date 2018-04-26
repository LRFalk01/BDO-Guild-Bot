#FROM microsoft/dotnet:2.0-runtime AS base
#WORKDIR /app

FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /src
COPY Discord.Bdo.Guild.Bot.sln ./
COPY Discord.Bdo.Guild.Bot/Discord.Bdo.Guild.Bot.csproj Discord.Bdo.Guild.Bot/
RUN dotnet restore -nowarn:msb3202,nu1503
COPY . .
WORKDIR /src/Discord.Bdo.Guild.Bot
RUN dotnet build -c Release -o /app

#FROM build AS publish
#RUN dotnet publish -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "Discord.Bdo.Guild.Bot.dll"]
#