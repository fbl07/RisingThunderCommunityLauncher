namespace UpdateServer.Code.DataAccess
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class PatchContext : DbContext
    {
        // Your context has been configured to use a 'PatchContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'UpdateServer.Code.DataAccess.PatchContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'PatchContext' 
        // connection string in the application configuration file.
        public PatchContext()
            : base("name=PatchContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public virtual DbSet<Patch> Patches { get; set; }
        public virtual DbSet<File> Files { get; set; }
    }

    public class Patch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public DateTime Date { get; set; }
    }

    public class File
    {
        [Key]
        public int Id { get; set; }
        [Index(IsUnique = true)]
        [StringLength(300)]
        [Required(AllowEmptyStrings = false)]
        public string Path { get; set; }
        //public int PatchIdLastUpdated { get; set; }
        public Patch PatchLastUpdated { get; set; }
    }


    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}