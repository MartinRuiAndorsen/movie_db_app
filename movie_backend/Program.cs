
using movie_backend.Model;

namespace movie_backend
{
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

            string zipPath = "./movie_metadata.zip";
            string zipFilename = "movie_metadata.csv";
            string extractDirectory = "./";

            bool b = Datasets.Unzip(zipPath, zipFilename, extractDirectory);
            Console.WriteLine($"unzip was sucessfull? { b }");








            app.Run();

        }
    }
}