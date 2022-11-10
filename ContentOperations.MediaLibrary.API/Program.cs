namespace ContentOperations.MediaLibrary.API
{
    using ContentOperations.Domain.Core.Bus;
    using ContentOperations.Infrastructure.Bus;
    using ContentOperations.MediaLibrary.Application.Interfaces;
    using ContentOperations.MediaLibrary.Application.Mapper;
    using ContentOperations.MediaLibrary.Application.Services;
    using ContentOperations.MediaLibrary.Data;
    using ContentOperations.MediaLibrary.Data.Repositories;
    using ContentOperations.MediaLibrary.Domain.Interfaces;

    using MediatR;

    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.SqlServer;

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddMediatR(typeof(Program));

            builder.Services.AddDbContext<MediaLibraryContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("MediaLibraryConfigurationDatabase"),
                    x => x.MigrationsAssembly("ContentOperations.MediaLibrary.Data")
                )
            );

            //Domain Bus
            builder.Services.AddScoped<IEventBus, RabbitMQBus>();

            //Application Services
            builder.Services.AddScoped<IMediaLibraryConfigurationService, MediaLibraryConfigurationService>();

            //Data
            builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            builder.Services.AddScoped<DbContext, MediaLibraryContext>();

            //Mapper
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            //Services
            builder.Services.AddScoped<IMediaLibraryConfigurationService, MediaLibraryConfigurationService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}