# Notizen zum Anwendungsentwickler C# 2024
Im Lauf des Kurses werden hier Notizen gesammelt, die über die Inhalte des Buches hinausgehen oder einzelne Zusammenhänge vertiefen bzw. kompakt zusammenfassen.

## Namenskonventionen
Um eine einheitliche Namensgebung zu gewährleisten, sollten die Standard-C#-Namenskonventionen eingehalten werden. Diese sind [hier](https://learn.microsoft.com/de-de/dotnet/csharp/fundamentals/coding-style/identifier-names#naming-conventions) zu finden. Wir werden sie im Lauf des Kurses  genauer kennenlernen und vielfach anwenden; es besteht daher noch kein Grund, sie auswendig zu lernen.

## Kommandozeilenbefehle
Wenn etwas in eckigen Klammern steht, z.B. `<Ordnername>`, dann bedeutet das, dass hier ein selbst gewählter Ordnername vergeben werden kann. Im Terminal soll also 
nicht 
```
mkdir <Ordnername>
```
sondern 
```
mkdir Mein_Ordner
```
eingeben werden, wobei `Mein_Ordner` hier natürlich nur ein Beispiel ist und von euch frei gewählt werden kann.

### dotnet
- `dotnet new sln --output <name>` erstellt eine neue Solution mit dem Namen `<name>` und legt sie in dem Ordner `<name>` ab.
- `dotnet new winforms --name <name>` erstellt ein neues WinForms-Projekt mit dem Namen `<name>` und legt es in dem Ordner `<name>` ab.
- `dotnet sln add (ls -r **/*.csproj)` fügt alle Projekte in dem aktuellen Ordner und allen Unterordnern zur Solution hinzu.

### Linux allgemein
- `ls` zeigt den Inhalt des aktuellen Verzeichnisses an
- `mkdir <Ordnername>` erstellt einen Ordner im aktuellen Verzeichnis
- `cd <Ordnername>` wechselt in den Ordner mit dem angegebenen Namen
- `cd ..` wechselt in das übergeordnete Verzeichnis
- `cat <Dateiname>` gibt den Inhalt der Datei im Terminal aus
- `echo "<Dateiinhalt>" > <Dateiname>` erstellt eine neue Datei mit dem vorgegebenen Namen und Inhalt
- `echo "<Dateiinhalt>" >> <Dateiname>` fügt den vorgegebenen Dateiinhalt zu der bestehenden Datei mit dem angegebenen Namen hinzu

## Visual Studio 2022
### Tastenkürzel
| Kürzel | Bedeutung |
|-|-|
|<kbd>Alt</kbd> + <kbd>Shift</kbd>| Spalten auswählen |
|<kbd>Strg</kbd> + <kbd>E</kbd>, <kbd>V</kbd> | Zeile nach unten kopieren |
|<kbd>Strg</kbd> + <kbd>Shift</kbd> + <kbd>L</kbd>| Zeile löschen |
|<kbd>Strg</kbd> + <kbd>K</kbd>, <kbd>Strg</kbd> + <kbd>C</kbd>| Auswahl als Kommentar |
|<kbd>Strg</kbd> + <kbd>K</kbd>, <kbd>Strg</kbd> + <kbd>U</kbd>| Auswahl nicht mehr als Kommentar |
|<kbd>Alt</kbd> + <kbd>Shift</kbd> + <kbd>.</kbd>| Nächstes Vorkommen zur Auswahl hinzufügen |
|<kbd>Strg</kbd> + <kbd>Q</kbd> | Schnellsuche |
|<kbd>F5</kbd>| Anwendung starten |
|<kbd>F4</kbd>| Eigenschaften |
|<kbd>F7</kbd>| Von Entwurfsansicht zum Code wechseln |
|<kbd>Shift</kbd> + <kbd>F7</kbd>| Vom Code zur Entwurfsansicht wechseln |
|<kbd>Strg</kbd> + <kbd>Alt</kbd> + <kbd>L</kbd>| Projektmappen-Explorer |
|<kbd>Strg</kbd> + <kbd>Alt</kbd> + <kbd>X</kbd>| Toolbox |
|<kbd>Strg</kbd> + <kbd>0</kbd>, <kbd>Strg</kbd> + <kbd>G</kbd>| Git-Änderungen |
|<kbd>Strg</kbd> + <kbd>ö</kbd>| Powershell |
