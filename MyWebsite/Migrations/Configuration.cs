namespace MyWebsite.Migrations
{
    using MyWebsite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyWebsite.Models.ApplicationDbContext>
    {
        public readonly IApplicationDbContext _context;
        public Configuration():this(new ApplicationDbContext())
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        public Configuration(IApplicationDbContext context) {
            _context = context;
        }

        protected override void Seed(MyWebsite.Models.ApplicationDbContext context)
        {
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });
            _context.Movies.AddOrUpdate(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "From the Land of the Moon (2016) ",
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BN2Q2OTEyZWItYmVmMi00NzYyLWI4YTAtMjJjMWMzZjBjYzM4XkEyXkFqcGdeQXVyNDAyODU1Njc@._V1_UY268_CR10,0,182,268_AL_.jpg",
                Genre = "Drama",
                ReleasedDate = DateTime.Now,
                Price = 10m
            });

            _context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
