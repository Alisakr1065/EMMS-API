// Program.cs
using AutoMapper;
using Business.Interfaces;
using Business.Mapping;
using Business.Services;
using Data.Interfaces;
using Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// 1️⃣ اقرأ الـ Connection String
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 2️⃣ أضف Services
builder.Services.AddControllers();

// 3️⃣ أضف AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));  // أو اسم ملف Profile بتاعك

// 4️⃣ أضف Repository (Scoped = new instance per request)
builder.Services.AddScoped<IEquipmentRepository>(provider =>
    new EquipmentsRepository(connectionString));

builder.Services.AddScoped<IFaultRepository>(provider =>
    new FaultsRepository(connectionString));

builder.Services.AddScoped<IMaintenanceHistoryRepository>(provider =>
    new MaintnanceHistoryRepository(connectionString));

// 5️⃣ أضف Services
builder.Services.AddScoped<IEquipmentService, EquipmentsService>();
builder.Services.AddScoped<IFaultService, FaultsService>();
builder.Services.AddScoped<IMaintenanceHistoryService, MaintenanceHistoryService>();

// 6️⃣ Logging
builder.Services.AddLogging();

// 7️⃣ CORS (لو تحتاج Frontend)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

// 8️⃣ Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors("AllowAll");
app.UseAuthorization();

app.MapControllers();

app.Run();