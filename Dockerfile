FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine as base

# Copy everything else and build
COPY ./ /opt/scms
WORKDIR /opt/scms

RUN ["dotnet","publish","./src/SCMS/SCMS.csproj","-o","./outputs" ]

FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine as run
COPY --from=base /opt/scms/outputs /opt/scms/outputs
WORKDIR /opt/scms/outputs
ENTRYPOINT ["dotnet", "SCMS.dll"]