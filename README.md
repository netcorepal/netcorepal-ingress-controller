# NetCorePal.ApiGateway

����`Yarp.ReverseProxy`�����`Kubernetes Ingress Controller`��

## ��װʹ��

```
docker pull ghcr.io/netcorepal/apigateway:master
docker run --name apigateway -p 7788:80 -e ASPNETCORE_ENVIRONMENT="Development"  -d ghcr.io/netcorepal/apigateway:master 
```
���ʵ�ַ�� [http://localhost:7788](http://localhost:7788)
