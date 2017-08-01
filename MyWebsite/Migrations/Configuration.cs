namespace MyWebsite.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using MyWebsite.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Security.Claims;

    internal sealed class Configuration : DbMigrationsConfiguration<MyWebsite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "MyWebsite.Models.ApplicationDbContext";
        }

        protected override void Seed(MyWebsite.Models.ApplicationDbContext context)
        {
            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);
            //if (System.Diagnostics.Debugger.IsAttached == false)
            //{
            //    System.Diagnostics.Debugger.Launch();
            //}
            if (!context.Users.Any(u => u.UserName == "quyhuyen.vu@gmail.com")) {
                var user = new ApplicationUser() {
                    FirstName = "Huyen",
                    LastName = "Vu",
                    Email = "quyhuyen.vu@gmail.com",
                    UserName = "quyhuyen.vu@gmail.com"
                };
                
                userManager.Create(user, "password**");

                context.Roles.AddOrUpdate(r => r.Name, new IdentityRole {Name = "Admin" });

                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),   
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10m
                });

                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });
                context.Movies.Add(new MovieEntity()
                {
                    Id = Guid.NewGuid(),
                    Title = "Spider-Man: Homecoming (2017)",
                    Genre = "Action",
                    ReleasedDate = DateTime.Now,
                    Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                    Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                    Price = 10
                });

                context.SaveChanges();

                userManager.AddToRole(user.Id, "Admin");
                userManager.AddClaim(user.Id, new Claim(ClaimTypes.GivenName, user.FirstName));
            }
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10m
            });

            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });
            context.Movies.Add(new MovieEntity()
            {
                Id = Guid.NewGuid(),
                Title = "Spider-Man: Homecoming (2017)",
                Genre = "Action",
                ReleasedDate = DateTime.Now,
                Image = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTk4ODQ1MzgzNl5BMl5BanBnXkFtZTgwMTMyMzM4MTI@._V1_UX182_CR0,0,182,268_AL_.jpg",
                Plot = "Thrilled by his experience with the Avengers, Peter returns home, where he lives with his Aunt May, under the watchful eye of his new mentor Tony Stark, Peter tries to fall back into his normal daily routine - distracted by thoughts of proving himself to be more than just your friendly neighborhood Spider-Man - but when the Vulture emerges as a new villain, everything that Peter holds most important will be threatened. Written by Benett Sullivan ",
                Price = 10
            });

            context.SaveChanges();



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
