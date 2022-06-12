# NetCorePal.IngressController

基于 [Yarp.ReverseProxy](https://github.com/microsoft/reverse-proxy) 打造的`Kubernetes Ingress Controller`，本项目以打造灵活的自己定义`Ingress Controller`工程模板为目标，以满足不同的系统场景。

## 安装使用

```
# 创建命名空间
kubectl create namespace yarp


# 创建ingress controller
kubectl apply -f .\ingress-controller.yaml -n yarp


# 卸载
kubectl delete -f .\ingress-controller.yaml -n yarp
```
