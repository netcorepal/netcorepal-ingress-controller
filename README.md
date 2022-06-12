# NetCorePal.ApiGateway

基于`Yarp.ReverseProxy`打造的API网关，具备强大的可定制性和扩展性，并基于`Blazor`和`AntDesign`打造的配置界面。

## 安装使用

```
docker pull ghcr.io/netcorepal/apigateway:master
docker run --name apigateway -p 7788:80 -e ASPNETCORE_ENVIRONMENT="Development"  -d ghcr.io/netcorepal/apigateway:master 
```
访问地址： [http://localhost:7788](http://localhost:7788)
