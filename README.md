# NetCorePal.IngressController

���� [Yarp.ReverseProxy](https://github.com/microsoft/reverse-proxy) �����`Kubernetes Ingress Controller`������Ŀ�Դ��������Լ�����`Ingress Controller`����ģ��ΪĿ�꣬�����㲻ͬ��ϵͳ������

## ��װʹ��

```

# ���ش���
git clone https://github.com/netcorepal/netcorepal-ingress-controller.git

cd netcorepal-ingress-controller


# ���������ռ�
kubectl create namespace yarp


# ����ingress controller
kubectl apply -f .\ingress-controller.yaml -n yarp


# ж��
kubectl delete -f .\ingress-controller.yaml -n yarp
```
