using Microsoft.EntityFrameworkCore;
using System;

namespace Emploees.Models
{
    public class Context:DbContext
    {
        public DbSet<Staff> Emploees { get; set; } 

        public Context(DbContextOptions<Context> options):base(options) 
        {
            //Database.EnsureDeleted(); // удаляет БД 
            Database.EnsureCreated(); // создает БД
            //Database.Migrate(); // Применение созданной миграции
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=Manager;Username=postgres;Password=User1234")
        //        //.LogTo(Console.WriteLine) // можно подсмотреть сформированный EF запрос
        //        ;
        //    /*Строка подключения содержит адрес сервера (параметр Host), порт (Port), 
        //     * название базы данных на сервере (Database),
        //     * имя пользователя в рамках сервера PostgreSQL (Username) и его пароль (Password).*/
        //}
    }
}
