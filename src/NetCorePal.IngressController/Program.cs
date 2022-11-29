using Prometheus;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("/app/config/yarp.json", optional: true);

var netcorepalConfig = builder.Configuration.GetSection("netcorepal");
var useMetricServer = netcorepalConfig.GetValue<bool>("UseMetricServer", false);
var useHttpMetrics = netcorepalConfig.GetValue<bool>("UseHttpMetrics", false);
var useYarpProxyStateUI = netcorepalConfig.GetValue<bool>("UseYarpProxyStateUI", false);

builder.Services.AddKubernetesReverseProxy(builder.Configuration);
if (!builder.Environment.IsDevelopment())
{
    builder.WebHost.UseKubernetesReverseProxyCertificateSelector();
}
builder.Services.AddHealthChecks();
builder.Services.AddYarpProxyStateUI();
var app = builder.Build();

app.UseHealthChecks(path: "/healthz");
if (useMetricServer || useHttpMetrics)
{
    app.UseMetricServer(url: "/metrics");
}
if (useYarpProxyStateUI)
{
    app.UseYarpProxyStateUIStaticFiles();
}
app.UseRouting();
if (useHttpMetrics)
{
    app.UseHttpMetrics();
}
if (useYarpProxyStateUI)
{
    app.UseYarpProxyStateUI(); // YARP Proxy State UI  http://yourip/_state
}
app.MapReverseProxy();

app.Run();
