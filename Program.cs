var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Projeto web - LH Pets versão 1");

app.UseStaticFiles();
app.MapGet("/index", (HttpContext contexto) => {
    contexto.Response.Redirect("index.html", false);
});

Banco dba = new Banco();
app.MapGet("/listaClientes", (HttpContext context) => {
    context.Response.WriteAsync(dba.GetListaString());
});

app.Run();
