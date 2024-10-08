// See https://aka.ms/new-console-template for more information
using SistemaHotel.Persistencia.EFCore.Database.Contexts;
using SistemaHotel.Persistencia.EFCore.Repositorios;
using SistemaHotel.Modelo.Basicas;

Console.WriteLine("Hello, World!");


using (var efDbContext = new SqliteEFCoreContext())
{
    var usuariosEF = new RepositorioCRUDGenericoEFCore<UsuarioModelo>(efDbContext);
    usuariosEF.Adicionar(efDbContext.Usuarios, new UsuarioModelo(1, "712588482", "57755776", "Carlos", "carlos@gmail.com", "6299999876", "R Floripa"));

    foreach (var usuario in usuariosEF.ObterTodos(efDbContext.Usuarios)) 
    {
        Console.WriteLine("Usuários: " + usuario);
    }
}