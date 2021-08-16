using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using naturGuiderna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<NatureDbContext>();

                // Check that database exist
                context.Database.EnsureCreated();

                // Location
                if (!context.Locations.Any())
                {
                    context.Locations.AddRange(new List<Location>()
                    {
                        new Location()
                        {
                            PictureUrl = "https://www.skistar.com/globalassets/bilder-nya-skistar.com/skidorter_profilbilder/are/are_var.jpg?maxwidth=924&quality=80",
                            Name = "Åre",
                            Description = "Från Åre by startar många spännande aktiviter och guidade turer både på skutan och närliggande områden."
                        },
                        new Location()
                        {
                            PictureUrl = "https://www.ottsjo.se/wp-content/uploads/2018/10/fjallbynh%C3%B6stDSC_6147-1024x450.jpeg",
                            Name = "Ottsjö",
                            Description = "I södra Årefjällen ligger den pitoreska fjällbyn Ottsjö, härifrån startar flera fina vandringsleder och på vintern fina turleder."
                        },
                        new Location()
                        {
                            PictureUrl = "https://cdn-assets.alltrails.com/uploads/photo/image/31187012/large_bb4aa723262a9ecaea6f1c49b4bd853d.jpg",
                            Name = "Vålådalen",
                            Description = "Från klassiska Vålådalen utgår flera fina leder, både upp på Ottfjället och in i naturreservartet 'Vålådalens naturreservat'. Här vandrar man i både urskog och fjällmiljö. Leder in mot Lunndörrspasset startar härifrån.Cyckling, toppturer, offpist, vandring, Turskidåkning och forspaddling är bara några av de äventyr som går uppleva i Vålådalen."
                        }

                    });
                    context.SaveChanges();

                }
                // Experience
                if (!context.Experiences.Any())
                {
                    context.Experiences.AddRange(new List<Experience>()
                    {
                        new Experience()
                        {
                            Name = "Urskog"
                        },
                        new Experience()
                        {
                            Name = "Risk att bli blöt"
                        },
                         new Experience()
                        {
                            Name = "Stor chans att se vilt"
                        },
                         new Experience()
                        {
                            Name = "Lunch ingår"
                        },
                         new Experience()
                        {
                            Name = "Grilla"
                        },
                         new Experience()
                        {
                            Name = "Högfjällsmiljö"
                        },
                         new Experience()
                        {
                            Name = "Skog"
                        },
                         new Experience()
                        {
                            Name = "Lätt utmaning"
                        }
                         ,
                         new Experience()
                        {
                            Name = "Medelsvår utmaning"
                        },
                         new Experience()
                        {
                            Name = "Tuff Utmaning"
                        }
                    });
                    context.SaveChanges();

                }
                // Guide
                if (!context.Guides.Any())
                {
                    context.Guides.AddRange(new List<Guide>()
                    {
                        new Guide()
                        {
                            ProfilePictureUrl = "http://bjornedin.se/images/200411_bjorn.jpg",
                            FullName = "Björn Edin",
                            Age = 36,
                            GuideDescription = "Björn har åkt skidor sedan han var tre och har stor erfarenhet av fjällmiljö. Björn leder främst guidade turskidåkningsturer och toppturer med snowboard."
                        }
                    });
                    // Category
                    if (!context.Categories.Any())
                    {

                    }
                    // Activity
                    if (!context.Activities.Any())
                    {

                    }
                    // Experince & Activity
                    if (!context.Experience_Activities.Any())
                    {

                    }
                    //
                }
            }
        }
    }
}
