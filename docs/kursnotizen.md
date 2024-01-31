# Notizen zum Anwendungsentwickler C# 2024
Im Lauf des Kurses werden hier Notizen gesammelt, die über die Inhalte des Buches hinausgehen oder einzelne Zusammenhänge vertiefen bzw. kompakt zusammenfassen.

## Namenskonventionen
Um eine einheitliche Namensgebung zu gewährleisten, sollten die Standard-C#-Namenskonventionen eingehalten werden. Diese sind [hier](https://learn.microsoft.com/de-de/dotnet/csharp/fundamentals/coding-style/identifier-names#naming-conventions) zu finden. Wir werden sie im Lauf des Kurses  genauer kennenlernen und vielfach anwenden; es besteht daher noch kein Grund, sie auswendig zu lernen.

## Kommandozeilenbefehle
### dotnet
- `dotnet new sln --output <name>` erstellt eine neue Solution mit dem Namen `<name>` und legt sie in dem Ordner `<name>` ab.
- `dotnet new winforms --name <name>` erstellt ein neues WinForms-Projekt mit dem Namen `<name>` und legt es in dem Ordner `<name>` ab.
- `dotnet sln add (ls -r **/*.csproj)` fügt alle Projekte in dem aktuellen Ordner und allen Unterordnern zur Solution hinzu.

