#!/bin/bash

pushd $(pwd)/src/web/HomeChecklist/
yarn
ng build
popd