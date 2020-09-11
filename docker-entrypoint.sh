#!/bin/bash
export ASPNETCORE_ENVIRONMENT=$ATLAS_ENVIRONMENT
./start-dependency.sh
if [ $? -eq 0 ]; then
	exec "$@"
fi
exit 1
