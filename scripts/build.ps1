# 以上脚本均需要在powershell中使用

$buildFolder = (Get-Item -Path "./" -Verbose).FullName ## 当前文件所在目录
$slnFolder = Join-Path $buildFolder "../"   ## 当前解决方案所在文件夹
$outputFolder = Join-Path $buildFolder "outputs" ## 当前文件夹下的outputs文件夹
$webFolder = Join-Path $slnFolder "YoyoMooc.StuManagement.Web"  ## web项目所在文件夹路径
$apiFolder = Join-Path $slnFolder "YoyoMooc.StuManagement.Api"  ## web项目所在文件夹路径

 


 
# 设置路径到解决方案文件夹  ###################################################
Set-Location $webFolder

# 还原项目依赖的包然后发布###################################################

dotnet publish  --configuration Release --output (Join-Path $outputFolder "web")


# 设置路径到解决方案文件夹  ###################################################
Set-Location $apiFolder

# 还原项目依赖的包包然后发布###################################################

dotnet publish  --configuration Release --output (Join-Path $outputFolder "api")

# 创建Docker镜像 ####################

# web
Set-Location (Join-Path $outputFolder "web")

docker rmi yoyomoc/blazorwebdemo -f

docker build -t yoyomoc/blazorwebdemo .




## api

Set-Location (Join-Path $outputFolder "api")
docker rmi yoyomoc/blazorapiemo -f

docker build -t yoyomoc/blazorapiemo .
