using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bg_lib.Data;
using System;
using System.Linq;

namespace bg_lib.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new bg_libContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<bg_libContext>>()))
                {
                    if (context.Game.Any())
                    {
                        //Data already exists
                        return; 
                    }
                    context.Game.AddRange(
                        new Game { Id = "CCC202409"     },
new Game { Id = "20905"          },
new Game { Id = "20651"          },
new Game { Id = "20557"          },
new Game { Id = "20903"          },
new Game { Id = "20246"          },
new Game { Id = "CCC202411"      },
new Game { Id = "20913"          },
new Game { Id = "20899"          },
new Game { Id = "20729"          },
new Game { Id = "CCC2024 - 0017" }
                    );
                }
    }
}
