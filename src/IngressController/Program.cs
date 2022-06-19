namespace NetCorePal.IngressController
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddKubernetesReverseProxy(builder.Configuration);
            builder.Services.AddHealthChecks();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapHealthChecks("/healthz");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapReverseProxy();
            });

            app.Run();
        }
    }
}