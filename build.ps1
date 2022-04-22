$env:GIT_COMMIT=git log -1 --format=%h;
$env:CUR_DATE=get-date -format "yy-MM-dd-HH:mm:ss";
docker-compose build;