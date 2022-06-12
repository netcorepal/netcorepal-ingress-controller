# NetCorePal.ApiGateway

基于`Yarp.ReverseProxy`打造的`Kubernetes Ingress Controller`。

## 安装使用

```
docker pull ghcr.io/netcorepal/apigateway:master
docker run --name apigateway -p 7788:80 -e ASPNETCORE_ENVIRONMENT="Development"  -d ghcr.io/netcorepal/apigateway:master 
```
访问地址： [http://localhost:7788](http://localhost:7788)
