using Microsoft.EntityFrameworkCore;
using OnionLibrary.Application.Interfaces.Repositories;
using OnionLibrary.Application.Interfaces.Services;
using OnionLibrary.Application.Repositories;
using OnionLibrary.Application.Services;
using OnionLibrary.Infrastructure;
using OnionLibrary.Infrastructure.Repositiries;

var builder = WebApplication.CreateBuilder(args);

// Register configuratrion
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add database service
builder.Services.AddDbContext<LibraryDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DevConnection"), 
    b => b.MigrationsAssembly("OnionLibraryService"))
);

// Add services
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<IBookRepository, BookRepository>();

builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IRoleRepository, RolesRepository>();

builder.Services.AddScoped<IRentedBookService, RentedBookService>();
builder.Services.AddScoped<IRentedBookRepository, RentedBookRepository>();

builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IOrderStatusService, OrderStatusService>();
builder.Services.AddScoped<IOrderStatusRepository, OrderStatusRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();

app.MapControllers();

app.Run();
