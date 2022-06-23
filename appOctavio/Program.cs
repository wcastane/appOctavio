using libOctavio;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

Carro ibiza = new Carro();
ibiza.SKU = "IBI01";
ibiza.Puertas = 2;
ibiza.Ruedas = 4;
ibiza.NoSerie = "123456";

if (ibiza.EstaEncendido)
{
    ibiza.Apagar();
}
else
{
    ibiza.Encender();
}


Camion camion123 = new Camion { SKU = "CAM123", Puertas = 2, Ruedas = 6, TipoCaja = TipoCaja.CajaSeca, TamañoCaja = 48 };

//using (var db = new CarrosDB())
//{
//    db.Carros.Add(ibiza);
//    db.SaveChanges();
//}


//class CarrosDB : DbContext
//{
//    public DbSet<Carro> Carros { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder options)
//    => options.("DataSource=app.db");

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder .UseSqlServer(
//            @"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
//    }
//}