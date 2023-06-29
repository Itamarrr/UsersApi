﻿using Microsoft.OpenApi.Models;
using System.Reflection;

namespace UsersAPI.Services.Extensions
{
    public static class SwaggerDocExtension
    {
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options => {
                options.SwaggerDoc("v1",
                new OpenApiInfo
                {
                    Title = "UsersAPI - ITAMAR Informática",
                    Description = "API para controle de usuários - Curso C# Avançado Formação Arquiteto",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Itamar Informática",
                        Email = "itamarsantos.dev@gmail.com",
                        Url = new Uri("https://portfolio-sigma-two-52.vercel.app/")
                    }
                });
                //configuração para o Swagger colocar os comentarios nome do arquivo
                //e caminho onde ele vai salvar o arquivo
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                //Para isso funcionar terei que mecher no arquivo csproj e perigoso isso
                //mais esse macete tem que mexer nele
                options.IncludeXmlComments(xmlPath);

                });

            return services;
        }

        public static IApplicationBuilder UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "UsersAPI");
            });

            return app;
        }

    }
}



