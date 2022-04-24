CUR_DATE=$(date +%s) && GIT_COMMIT=$(git log -1 --format=%h) && docker-compose build web
