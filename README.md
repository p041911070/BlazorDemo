# YoyoMooc.BlazorDemo



网站Demo采用Blazor 开发完成,整个网站没有包含一行javascript和ts文件

- Angular、Vue、React 的SSO问题，Blazor 解决了
- 前端项目编译Angular、Vue、React慢的问题，Blazor解决了
- 传统MVC、RazorPage在Ajax上需要通过js进行Dom操作的问题，被Blazor解决了双向绑定问题解决了，优秀。

- Demo源代码：https://github.com/yoyomooc/BlazorDemo



## 运行环境

临时预览地址： http://106.13.51.165:3000/

后面切换为绑定域名。


运行在Docker容器中，没有错。都在Docker中。



数据库：SqlServer 2019

API地址：http://106.13.51.165:9898/api/student
 
门户： http://106.13.51.165:3000



## 运行方式

已经内置了docker-compose 脚本，可以通过`scripts\docker`文件夹启动

```

docker-compose -up

docker-compose -down 


``` 
搞定。。
> ps: 前提是你会docker。。。