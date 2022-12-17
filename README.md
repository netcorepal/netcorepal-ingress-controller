# NetCorePal Ingress Controller

NetCorePal Ingress Controller Project based on YARP.  

More info: <https://github.com/microsoft/reverse-proxy>

## install

```shell
helm repo add netcorepal https://netcorepal.github.io/helm-charts/
helm repo update

# Install a `NetCorePal Ingress Controller` use release name `myrelease`.
helm install myrelease netcorepal/netcorepal-ingress-controller   
```

See <https://github.com/netcorepal/helm-charts/tree/main/charts/netcorepal-ingress-controller>

## Build

```shell
docker build -f src/NetCorePal.IngressController/Dockerfile -t netcorepal:latest .
```

