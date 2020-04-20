
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
RUN sed -i 's/TLSv1.2/TLSv1.0/g' /etc/ssl/openssl.cnf



COPY dist /app 


COPY node_modules/wait-for-it.sh/bin/wait-for-it /app/wait-for-it.sh
RUN chmod +x /app/wait-for-it.sh

WORKDIR /app
EXPOSE 80

ENV WAITHOST=mysql WAITPORT=3306

## 接口ok后再执行dotnet入口
ENTRYPOINT ./wait-for-it.sh $WAITHOST:$WAITPORT --timeout=0 \
&& exec dotnet YoyoMooc.StuManagement.Web.dll
