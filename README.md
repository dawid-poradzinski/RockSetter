    03.12.24

Created db table in Models/Db/RockEntity

Added package Microsoft.EntityFrameworkCore.Sqlite to acces database
-- Created model AppDbContext
    Create variable, where db is stored
    Overrided two methods
    Registered RockEntity via DbSet
    Made two default entries to database

Added AppDbContext to builder in Program.cs

    05.12.24

Created interface IRockService that declare methods to be implemented by class EFRockService. This file will handle actual b usiness logic for database operations.

Used AddScoped method to register IRockService  interface with its implementation EFRockService in the Program.cs file.
Ths ensures that a new instance of EFrockService is created for each HTTP request and reused within the same request.

    10.12.24

Created RockBasicEntity class for basic rock informations (id,name,image,favorible) that are essential for showing all rocks on main page.
Created RockMapper class to convert detailed database entities into RockBasicEntity objest. Implemented it in EFRockSerivce getAll()

    11.12.24

Made basic layout for Rock0/index.cshtml using bootstrap

    16.12.24

Made basic layout for Rock0/details.cshtml and added migrations

    19.12.24

Tried to change from bootstrap to tailwind, but decided to stay. Added ImageFileName and loading image by it, and not by rock name. Added loading default image, if img file doesn't exist

    20.12.24

Made Add page, where we can add new rocks to our collection.
Made working delete button for rock.
Tried chaning update from post to put, but it's to much work something that's already working