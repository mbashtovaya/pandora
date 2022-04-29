#!/bin/bash

set -e

DIR="$(cd "$(dirname "$0")" && pwd)/.."

function buildAndInstallDependencies {
    echo "Installing the Go SDK Generator into the GOBIN.."
    cd "${DIR}/tools/generator-go-sdk"
    go install .
    cd "${DIR}"

    echo "Building Wrapper.."
    cd "${DIR}/tools/wrapper-go-sdk-generator"
    go build -o wrapper-go-sdk-generator
    cd "${DIR}"
}

function runWrapper {
  local dataApiAssemblyPath=$1
  local outputDirectory=$2

  echo "Running Wrapper.."
  cd "${DIR}/tools/wrapper-go-sdk-generator"
  ./wrapper-go-sdk-generator \
    -data-api-assembly-path="../../$dataApiAssemblyPath"\
    -output-dir="../../$outputDirectory"
}

function prepareGoSdk {
  local workingDirectory=$1
  local sdkRepo=$2

  echo "Removing any existing working directory.."
  cd "${DIR}"
  rm -rf "$workingDirectory"

  echo "Cloning SDK Repository into $workingDirectory.."
  git clone "$sdkRepo" "$workingDirectory"
}

function conditionallyCommitAndPushGoSdk {
  local workingDirectory=$1
  local sha=$2
  local branch="auto-pr/$sha"

  cd "${DIR}"
  cd "$workingDirectory"
  if [[ $(git status --porcelain | wc -l) -gt 0 ]]; then
    echo "Committing and Pushing the changes"
    git checkout -b "$branch"
    git add --all
    git commit -m "Updating based on $sha"
    # NOTE: we're intentionally force-pushing here in-case this PR is
    # open and other changes (e.g. to the generator) get included
    git push origin "$branch" -f
  else
    echo "No changes detected - skipping commit/push"
  fi
}

function getSwaggerSubmoduleSha {
  local submodulePath=$1

  cd "${DIR}"
  cd "$workingDirectory"
  git rev-parse --short HEAD
}

function cleanup {
  local outputDirectory=$1

  cd "${DIR}"
  echo "Removing temporary working directory $outputDirectory.."
  rm -rf "$outputDirectory"
}

function main {
  local dataApiAssemblyPath="data/Pandora.Api/bin/Debug/net6.0/Pandora.Api.dll"
  local swaggerSubmodule="./swagger"
  local outputDirectory="tmp/go-azure-sdk"
  local sdkRepo="git@github.com:hashicorp/go-azure-sdk.git"

  buildAndInstallDependencies
  local sha=$(getSwaggerSubmoduleSha "$swaggerSubmodule")
  prepareGoSdk "$outputDirectory" "$sdkRepo"
  runWrapper "$dataApiAssemblyPath" "$outputDirectory" "$sha"
  conditionallyCommitAndPushGoSdk "$outputDirectory" "$sha"
  cleanup "$outputDirectory"
}

main