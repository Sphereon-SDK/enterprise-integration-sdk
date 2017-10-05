#!/usr/bin/env bash
#
# Generated by: https://github.com/swagger-api/swagger-codegen.git
#

wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync

echo "[INFO] remove bin/Debug/SwaggerClientTest.dll"
rm src/Sphereon.SDK.EIP.Test/bin/Debug/Sphereon.SDK.EIP.Test.dll 2> /dev/null

echo "[INFO] install NUnit runners via NuGet"
wget -nc https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
mozroots --import --sync
mono nuget.exe install src/Sphereon.SDK.EIP.Test/packages.config -o packages

echo "[INFO] Install NUnit runners via NuGet"
mono nuget.exe install NUnit.Runners -Version 2.6.4 -OutputDirectory packages 

echo "[INFO] Build the solution and run the unit test"
xbuild Sphereon.SDK.EIP.sln && \
    mono ./packages/NUnit.Runners.2.6.4/tools/nunit-console.exe src/Sphereon.SDK.EIP.Test/bin/Debug/Sphereon.SDK.EIP.Test.dll
