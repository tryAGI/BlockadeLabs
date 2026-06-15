#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://api-documentation.blockadelabs.com/blockade-labs-openapi.yaml
autosdk generate openapi.yaml \
  --namespace BlockadeLabs \
  --clientClassName BlockadeLabsClient \
  --targetFramework net10.0 \
  --security-scheme ApiKey:Header:x-api-key \
  --output Generated \
  --exclude-deprecated-operations

rm -rf ../../cli/BlockadeLabs.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/BlockadeLabs.CLI \
  --sdk-project ../../libs/BlockadeLabs/BlockadeLabs.csproj \
  --targetFramework net10.0 \
  --namespace BlockadeLabs \
  --clientClassName BlockadeLabsClient \
  --package-id BlockadeLabs.CLI \
  --tool-command-name blockade-labs \
  --user-secrets-id BlockadeLabs.CLI \
  --api-key-env-var BLOCKADELABS_API_KEY \
  --base-url-env-var BLOCKADELABS_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:x-api-key
