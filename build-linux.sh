#!/bin/bash
rm -rf ./publish/linux-x64
dotnet publish -c Release -r linux-x64 --self-contained false -o ./publish/linux-x64