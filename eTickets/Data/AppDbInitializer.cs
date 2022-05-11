using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var servicescope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = servicescope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                        {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo ="http://dotnethow.net/images/cinemas/cinema-1.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpg",
                            Description = "This is the description of the Second cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpg",
                            Description = "This is the description of the third cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpg",
                            Description = "This is the description of the fourth cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpg",
                            Description = "This is the description of the fifth cinema"
                        },
                });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first Actor",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second Actor",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the third Actor",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the fourth Actor",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fifth Actor",
                            ProfilePicturesURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        },
                    });
                        context.SaveChanges();
                

                }
                //Producers
                if (!context.Producers.Any())
                {
                context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first producer",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second producer",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the third producer",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the forth producer",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the fifth producer",
                            ProfilePicturesURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        },
                    });
                context.SaveChanges();
                }
            //Movies
            if (!context.Movies.Any())
                context.Movies.AddRange(new List<Movie>()
                {
                    new Movie()
                    {
                        Name = "Life",
                        Description = "This is the life movie description",
                        Price = 39.50,
                        ImageUrl = "http://dotnetshow.net/images/movies/movie-3.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(10),
                        CinemaId = 3,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Drama
                    },
                    new Movie()
                     {
                        Name = "The Shawshank Redemption",
                        Description = "This is The Shawshank Redemption movie description",
                        Price = 29.50,
                        ImageUrl = "http://dotnetshow.net/images/movies/movie-1.jpeg",
                        StartDate = DateTime.Now.AddDays(-3),
                        EndDate = DateTime.Now.AddDays(3),
                        CinemaId = 1,
                        ProducerId = 1,
                        MovieCategory = MovieCategory.Action
                    },
                    new Movie()
                      {
                        Name = "Ghost",
                        Description = "This is the Ghost movie description",
                        Price = 39.50,
                        ImageUrl = "http://dotnetshow.net/images/movies/movie-4.jpeg",
                        StartDate = DateTime.Now,
                        EndDate = DateTime.Now.AddDays(7),
                        CinemaId = 4,
                        ProducerId = 4,
                        MovieCategory = MovieCategory.Thriller
                    },
                    new Movie()
                       {
                        Name = "Race",
                        Description = "This is the Race movie description",
                        Price = 39.50,
                        ImageUrl = "http://dotnetshow.net/images/movies/movie-6.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(10),
                        CinemaId = 1,
                        ProducerId = 2,
                        MovieCategory = MovieCategory.Drama
                    },
                    new Movie()
                        {
                        Name = "Scoob",
                        Description = "This is the Scoob movie description",
                        Price = 39.50,
                        ImageUrl = "http://dotnetshow.net/images/movies/movie-7.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(10),
                        CinemaId = 1,
                        ProducerId = 3,
                        MovieCategory = MovieCategory.Comedy
                    },
                    new Movie
                         {
                        Name = "Cold",
                        Description = "This is the Cold movie description",
                        Price = 39.50,
                        ImageUrl = "http://dotnetshow.net/images/movies/movie-8.jpeg",
                        StartDate = DateTime.Now.AddDays(-10),
                        EndDate = DateTime.Now.AddDays(10),
                        CinemaId = 1,
                        ProducerId = 5,
                        MovieCategory = MovieCategory.Drama
                    },

                });
                //Actors & Movies
                if (!context.Actor_Movies.Any())
                {
                   
                }
            }
        }
    }
}
