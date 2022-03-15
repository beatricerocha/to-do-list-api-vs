using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ToDoListApiVs.Models
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options)
           : base(options)
        {
        }

        public DbSet<Tarefa> Tarefas { get; set; } = null!;
    }
}
