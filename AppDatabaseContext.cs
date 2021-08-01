using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServer.Models;

namespace WebServer
{
    public class AppDatabaseContext : DbContext
    {

        AppDatabaseContext(DbContextOptions<AppDatabaseContext> o) : base(o) 
        { 
        }
        DbSet<User>Users { get; set; }
    }


    /*
     * Любая ORM должна иметь контекст и классы
     * Классы должны соответствовать таблицам
     * 
     * 
     * Context
     * Classes
     *   User - UserTable
     *   Manager - ManagerTable
     */

}
