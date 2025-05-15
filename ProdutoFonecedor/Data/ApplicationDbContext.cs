namespace ProdutoFonercedor.Data;



using Microsoft.EntityFrameworkCore;
using ProdutoFonecedor.Models;

public class ApplicationDbContext : DbContext

{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

        : base(options)

    {

    }



    public DbSet<Fornecedor> Fornecedores { get; set; }

    public DbSet<Produto> Produtos { get; set; }

}
