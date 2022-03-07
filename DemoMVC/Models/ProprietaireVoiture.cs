namespace DemoMVC.Models
{
    //[Table("PersonneVoiture")] => Utilisation du FluentAPI au lieu du DataAnnotation. Par le DataAnnotation, cela ne fonctionnait pas, car il y est en relation avec d'autres tables.
    public class ProprietaireVoiture
    {
        public Personne Proprietaire { get; set; }

        //[Column("ProprietairesID")] => IDEM, voir la configuration avec le FluentAPI dans ApplicationDbContext.OnModelCreating()
        public int ProprietaireId { get; set; }

        public Voiture Voiture { get; set; }

        //[Column("VoituresID")] => IDEM, voir la configuration avec le FluentAPI dans ApplicationDbContext.OnModelCreating()
        public int VoitureId { get; set; }
    }
}
