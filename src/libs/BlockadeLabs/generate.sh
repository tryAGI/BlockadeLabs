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
