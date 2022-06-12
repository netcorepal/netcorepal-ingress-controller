# NetCorePal.IngressController

基于`Yarp.ReverseProxy`打造的`Kubernetes Ingress Controller`。

## 安装使用

```
# 创建命名空间
kubectl create namespace yarp


# 创建ingress controller
kubectl apply -f .\ingress-controller.yaml -n yarp


# 卸载
kubectl delete -f .\ingress-controller.yaml -n yarp
```
