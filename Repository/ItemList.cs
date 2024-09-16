using Microsoft.AspNetCore.Mvc;
using Surfs_Up.Models;

namespace Surfs_Up.Repository
{
    public static class ItemList 
    {
        private static List<CatalogItem> catalogItems = new List<CatalogItem>()
        {
            new CatalogItem {
                CatalogItemId = 1,
                Name = "The Minilog",
                Length = 6,
                Width = 21,
                Thickness = 2.75,
                Volume = 38.8,
                Type = CATALOGTYPE.Shortboard,
                Price = 565.00,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardShortboard.png",
                Quantity = 10,
                Description = "Perfekt for hurtige vendinger og manøvrering. Udforsk vores sortiment af shortboards her"
            },
            new CatalogItem {
                CatalogItemId = 2,
                Name = "The Wide Glider",
                Length = 7.1,
                Width = 21.75,
                Thickness = 2.75,
                Volume = 44.16,
                Type = CATALOGTYPE.Funboard,
                Price = 685,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardFunboard.webp",
                Quantity = 10,
                Description = "Skør og sjovt board til alle aldre. Udforsk vores sortiment af funboards her"
            },
            new CatalogItem {
                CatalogItemId = 3,
                Name = "The Golden Ration",
                Length = 6.3,
                Width = 21.85,
                Thickness = 2,
                Volume = 43.22,
                Type = CATALOGTYPE.Funboard,
                Price = 695,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardFunboard.webp",
                Quantity = 11,
                Description = "Skør og sjovt board til alle aldre. Udforsk vores sortiment af funboards her"
            },
            new CatalogItem {
                CatalogItemId = 4,
                Name = "Mahi Mahi",
                Length = 5.4,
                Width = 20.75,
                Thickness = 2.3,
                Volume = 29.39,
                Type = CATALOGTYPE.Fish,
                Price = 645,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardFish.png",
                Quantity = 10,
                Description = "Lille og agil!. Udforsk vores sortiment af fish boards her"
            },
            new CatalogItem {
                CatalogItemId = 5,
                Name = "The Emerald Glider",
                Length = 9.2,
                Width = 22.8,
                Thickness = 2.8,
                Volume = 65.4,
                Type = CATALOGTYPE.Longboard,
                Price = 895,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardLongboard.png",
                Quantity = 5,   
                Description = "Langt og hurtigt. Udforsk vores sortiment af longboards her"
            },
            new CatalogItem {
                CatalogItemId = 6,
                Name = "The Bomb",
                Length = 5.5,
                Width = 21,
                Thickness = 2.5,
                Volume = 33.7,
                Type = CATALOGTYPE.Shortboard,
                Price = 645,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardShortboard.png",
                Quantity = 10,
                Description = "Perfekt for hurtige vendinger og manøvrering. Udforsk vores sortiment af shortboards her"
            },
            new CatalogItem {
                CatalogItemId = 7,
                Name = "Walden Magic",
                Length = 9.6,
                Width = 19.4,
                Thickness = 3,
                Volume = 80,
                Type = CATALOGTYPE.Longboard,
                Price = 1025,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardLongboard.png",
                Quantity = 4,
                Description = "Langt og hurtigt. Udforsk vores sortiment af longboards her"
            },
            new CatalogItem
            {
                CatalogItemId = 8,
                Name = "Naish One",
                Length = 12.6,
                Width = 30,
                Thickness = 6,
                Volume = 301,
                Type = CATALOGTYPE.SUP,
                Price = 854,
                Equipment = "Paddle",
                ImagePath = "~/images/SurfboardLongboard.png",
                Quantity = 2,
                Description = "Hvad er en SUP?. Udforsk vores sortiment af SUPs her"
            },
            new CatalogItem
            {
                CatalogItemId = 9,
                Name = "Six Tourer",
                Length = 11.6,
                Width = 32,
                Thickness = 6,
                Volume = 270,
                Type = CATALOGTYPE.SUP,
                Price = 611,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardLongboard.png",
                Quantity = 3,
                Description = "Hvad er en SUP?. Udforsk vores sortiment af SUPs her"
            },
            new CatalogItem
            {
                CatalogItemId = 10,
                Name = "Naish Maliko",
                Length = 14,
                Width = 25,
                Thickness = 6,
                Volume = 330,
                Type = CATALOGTYPE.SUP,
                Price = 1304,
                Equipment = "Fin, Paddle, Pump, Leash",
                ImagePath = "~/images/SurfboardLongboard.png",
                Quantity = 1,
                Description = "Hvad er en SUP?. Udforsk vores sortiment af SUPs her"
            },
        };

        public static List<CatalogItem> GetList() 
        {
            return catalogItems;
        }
    }
}

        