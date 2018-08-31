namespace DeleteMeNow.Models
{
    public class DataContextLocal : DataContext
    {
        public System.Data.Entity.DbSet<DeleteMeNow.Models.Product> Products { get; set; }
    }
}