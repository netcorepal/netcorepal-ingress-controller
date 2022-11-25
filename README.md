# NetCorePal Ingress Controller

NetCorePal Ingress Controller Project based on YARP.  

More info: <https://github.com/microsoft/reverse-proxy>

## Build & Deploy

```shell
docker build -f src/NetCorePal.IngressController/Dockerfile -t netcorepal:latest .

helm upgrade netcorepal ./helm-chart --install -f values.yaml
```
