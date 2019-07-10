#!/bin/bash

# Requires Jenkins Go Plugin to be enabled in build environment

#exit on error
set -e
set -x

#make script exit if there is no variable passed in. Jenkins passes in a github token during CI/CD.
if [ -z $1 ]; then exit
fi

#make script exit if the steup file isn't present for some reason
if [ ! -f ./Output/usfmsetup.exe ]; then exit;
fi

export GOPATH=$(pwd)
export GITHUB_USER=WycliffeAssociates
export GITHUB_TOKEN=$1
export GITHUB_REPO=quick_usfm_converter
export PATH=$PATH:$GOPATH/bin

#Get the latest tag
TAG=$(git describe --tags --abbrev=0)

#Make sure we actually grabbed a tag
if [ -z $TAG ]; then exit
fi

#Check if there is a release for the latest tag
#Exit if a release already exists
DOES_RELEASE_EXIST=$(curl -s https://api.github.com/repos/wycliffeassociates/quick_usfm_converter/releases/tags/$TAG | grep '"message": "Not Found"')
if [ -z "$DOES_RELEASE_EXIST" ]; then exit;
fi

#Check for the gothub Github release go package, if not there, go get it
if [ ! -f "$GOPATH/bin/gothub" ]; then
go get github.com/itchio/gothub; else exit;
fi

#create the release
gothub release --tag $TAG -p

#Upload asset
gothub upload --tag $TAG --name "usfmsetup.exe" --file ./Output/usfmsetup.exe
