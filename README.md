# Rock Seeker

Mój projekt strony internetowej, która pozwala użytkownikom na zarządzanie biblioteką swoich okazów kamieni.

## Funkcjonalność
- Przeglądanie wszystkich oraz ulubionych kamieni
- Dodawanie nowych kamieni
- Wgrywanie nowych zdjęć
- Edycja wcześniej dodanych kamieni

## Technologie
- ASP.NET Core
- Entity Framework Core
- Bootstrap
- jQuery
- SQLite

## Jak uruchomić

### **Wymagania**
- .NET SDK 8.0 lub nowszy

### **Instalacja**
1. Sklonuj repozytorium:
    ```sh
    git clone https://github.com/dawid-poradzinski/RockSetter.git
    cd RockSetter
    ```

### **Konfiguracja bazy danych**
1. Baza danych SQLite jest automatycznie tworzona w katalogu wwwroot przy pierwszym uruchomieniu aplikacji. Ścieżka do bazy danych jest ustawiona w pliku Models/AppDbContext.cs:

    ```csharp
    ...
    public AppDbContext()
    {
        DbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "rocks.db");
    }
    ...
    ```

### Uruchomienie aplikacji

1. Zbuduj projekt:
`dotnet build`
2. Uruchom migracje bazy danych:
`dotnet ef database update`
3. Uruchom aplikację:
`dotnet run`

### Aplikacja będzie dostępna pod adresem
`https://localhost:5001`

### Połączenie z bazą danych
Aplikacja używa Entity Framework Core do zarządzania bazą danych SQLite. Konfiguracja połączenia znajduje się w metodzie ``OnConfiguring`` klasy ``AppDbContext``.

## Autor
Projekt stworzony przez [Dawid Poradziński](https://github.com/dawid-poradzinski).

## Przyszłość
W przyszłości planowane jest uruchomienie podstrony v1, która będzie wykonana na Razor Pages.
