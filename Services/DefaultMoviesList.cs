using Movie_Hub_Backend.Models;

namespace Movie_Hub_Backend.Services
{
    public class DefaultMoviesList
    {
        public static List<Movie> movies;

        static DefaultMoviesList()
        {
            movies = new List<Movie>
            {
                new Movie
                {
                    Title = "The Grand Budapest Hotel",
                    Description = "The Grand Budapest Hotel is a 2014 comedy-drama film...",
                    Year = 2014,
                    Rate = 8.1,
                    Director = "Wes Anderson",
                    Actors = new List<string>
                    {
                        "Ralph Fiennes",
                        "F. Murray Abraham",
                        "Mathieu Amalric",
                        "Adrien Brody",
                        "Willem Dafoe",
                        "Jeff Goldblum",
                        "Harvey Keitel",
                        "Jude Law",
                        "Bill Murray",
                        "Edward Norton",
                        "Saoirse Ronan",
                        "Jason Schwartzman",
                        "Léa Seydoux",
                        "Tilda Swinton",
                        "Tom Wilkinson",
                        "Owen Wilson",
                        "Tony Revolori"
                    },
                    TeaserUrl = "https://www.youtube.com/watch?v=zru-1DbbcsA",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/1/1c/The_Grand_Budapest_Hotel.png"
                },

                new Movie
                {
                    Title = "American Psycho",
                    Description = "American Psycho is a 2000 satirical horror film...",
                    Year = 2000,
                    Rate = 7.1,
                    Director = "Mary Harron",
                    Actors = new List<string>
                    {
                        "Christian Bale",
                        "Willem Dafoe",
                        "Jared Leto",
                        "Josh Lucas",
                        "Samantha Mathis",
                        "Matt Ross",
                        "Bill Sage",
                        "Chloë Sevigny",
                        "Sara Seymour",
                        "Justin Theroux",
                        "Guinevere Turner",
                        "Reese Witherspoon"
                    },
                    TeaserUrl = "https://www.youtube.com/watch?v=5YnGhW4UEhc",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/American_Psycho.png"
                },
                new Movie
                {
                    Title = "Taxi",
                    Description = "Taxi is a 1998 French action-comedy film...",
                    Year = 1998,
                    Rate = 7.0,
                    Director = "Gérard Pirès",
                    Actors = new List<string>
                    {
                        "Samy Naceri",
                        "Frédéric Diefenthal",
                        "Marion Cotillard",
                        "Manuela Gourary",
                        "Emma Wiklund"
                    },
                    TeaserUrl = "https://www.youtube.com/watch?v=-hyvzoMYIxY",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/7/7e/TaxiPoster.jpg"
                },

                new Movie
                {
                    Title = "500 Days of Summer",
                    Description = "500 Days of Summer is a 2009 romantic comedy-drama film...",
                    Year = 2009,
                    Rate = 7.7,
                    Director = "Marc Webb",
                    Actors = new List<string>
                    {
                        "Joseph Gordon-Levitt",
                        "Zooey Deschanel",
                        "Geoffrey Arend",
                        "Chloë Grace Moretz",
                        "Matthew Gray Gubler"
                    },
                    TeaserUrl = "https://www.youtube.com/watch?v=PsD0NpFSADM",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/thumb/d/d1/Five_hundred_days_of_summer.jpg/220px-Five_hundred_days_of_summer.jpg"
                },

                new Movie
                {
                    Title = "Legally Blonde",
                    Description = "Legally Blonde is a 2001 comedy film directed by Robert Luketic...",
                    Year = 2001,
                    Rate = 6.3,
                    Director = "Robert Luketic",
                    Actors = new List<string>
                    {
                        "Reese Witherspoon",
                        "Luke Wilson",
                        "Selma Blair",
                        "Matthew Davis",
                        "Victor Garber"
                    },
                    TeaserUrl = "https://www.youtube.com/watch?v=E8I-Qzmbqnc",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/b/be/Legally_Blonde_film_poster.png"
                },

                new Movie
                {
                    Title = "Fight Club",
                    Description = "Fight Club is a 1999 film directed by David Fincher...",
                    Year = 1999,
                    Rate = 8.8,
                    Director = "David Fincher",
                    Actors = new List<string>
                    {
                        "Brad Pitt",
                        "Edward Norton",
                        "Helena Bonham Carter",
                        "Meat Loaf",
                        "Zach Grenier"
                    },
                    TeaserUrl = "https://www.youtube.com/watch?v=SUXWAEX2jlg",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/f/fc/Fight_Club_poster.jpg"
                },

                new Movie
                {
                    Title = "Midsommar",
                    Description = "Midsommar is a 2019 folk horror film written and directed by Ari Aster...",
                    Year = 2019,
                    Rate = 7.1,
                    Director = "Ari Aster",
                    Actors = new List<string>
                    {
                        "Florence Pugh",
                        "Jack Reynor",
                        "William Jackson Harper",
                        "Vilhelm Blomgren",
                        "Will Poulter"
                    },
                    TeaserUrl = "https://www.youtube.com/watch?v=I0UWIya-O0s",
                    PosterUrl = "https://upload.wikimedia.org/wikipedia/en/1/1a/Midsommar_%282019_film%29.png"
                }
            };
        }
    }
}
