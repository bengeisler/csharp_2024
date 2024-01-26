# Anwendungsentwickler der HWK Charlottenhof 2024
## Setup
- [Visual Studio](https://visualstudio.microsoft.com/de/downloads/) herunterladen und installieren
- [Visual Studio Code](https://code.visualstudio.com/download) herunterladen und installieren
- [Git](https://git-scm.com/downloads) herunterladen, installieren und konfigurieren
- [Exercism CLI](https://exercism.io/cli-walkthrough) herunterladen und installieren

## Git
Git ist ein dezentrales Versionsverwaltungssystem. Es ermöglicht es, Änderungen an Dateien zu verfolgen und diese zu verwalten. Git arbeitet dezentral, das bedeutet, dass jeder Entwickler eine lokale Kopie des gesamten Repositorys hat. Änderungen werden lokal vorgenommen und dann mit dem zentralen Repository synchronisiert.

### GitHub
GitHub ist ein (der beliebteste) Online-Dienst, der Git-Repositories hostet. Um in diesem Kurs mitarbeiten zu können, benötigt ihr einen GitHub-Account. Diesen könnt ihr [hier](https://github.com/) erstellen.

### Git konfigurieren
2. Git Bash öffnen
3. `git config --global user.name "Vorname Nachname"` ausführen
4. `git config --global user.email "Email"` ausführen

### Repository klonen
1. Git Bash öffnen
2. `git clone https://github.com/bengeisler/csharp_2024.git` ausführen

### Einen eigenen Branch erstellen
1. Git Bash öffnen
2. `git checkout -b <branch-name>` ausführen. Dabei `<branch-name>` durch euren Namen ersetzen.
3. `git push --set-upstream origin <branch-name>` ausführen.

### Links
- [Git](https://git-scm.com/)
- [git - Der einfache Einstieg](https://rogerdudler.github.io/git-guide/index.de.html)
- [kostenloses Ebook: Pro Git](https://git-scm.com/book/de/v2)

## Exercism
Programmieren lernt man wie Kochen oder ein Musikinstrument: durch Üben. Exercism ist eine Plattform, die euch dabei hilft, eure Programmierfähigkeiten zu verbessern. Sie stellt für eine Vielzahl von Sprachen, darunter auch C#, Übungsaufgaben zur Verfügung. Diese Aufgaben könnt ihr lösen. Für jede Aufgabe gibt es Tests die euch sofort sagen, ob eure Lösung richtig ist. Außerdem könnt ihr eure Lösung mit der Lösung anderer vergleichen. Das praktische: ihr könnt euch mit dem gerade erstellten GitHub-Account bei Exercism anmelden.

Hier geht es zu Exercism: https://exercism.io/

Um die Aufgaben zu lösen, müsst ihr euch den Exercism-Client herunterladen. Diesen findet ihr hier: https://exercism.io/cli-walkthrough

### CLI konfigurieren
Nachdem ihr den Client heruntergeladen habt, müsst ihr ihn konfigurieren. Dazu öffnet ihr das Terminal und führt folgende Befehle aus:

```bash
exercism configure --token=<TOKEN>
```

Erstellt nun einen Ordner für eure Aufgaben und wechselt in diesen Ordner:

```bash
mkdir exercism
cd exercism
```

Ladet euch die erste Aufgabe herunter, indem ihr folgenden Befehl ausführt:

```bash
exercism download --track=csharp --exercise=hello-world
```

Wenn ihr nun `tree /f .` ausführt, solltet ihr folgende Ordnerstruktur sehen:

```
C:\USERS\BENED\EXERCISM
└───csharp
    └───hello-world
        │   .editorconfig
        │   HelloWorld.cs
        │   HelloWorld.csproj
        │   HelloWorldTests.cs
        │   HELP.md
        │   README.md
        │
        └───.exercism
                config.json
                metadata.json
```

Gut. Wechselt nun in den Ordner `hello-world`

```bash
cd csharp/hello-world
```

und öffnet die Datei `HelloWorld.sln` mit Visual Studio.

### Aufgabe lösen
- Lest euch die Aufgabenstellung in der Datei `README.md` durch
- Versucht die Aufgabe zu lösen
- Führt die Tests aus, um zu sehen, ob eure Lösung richtig ist. Dazu öffnet ihr den Test-Explorer in Visual Studio und führt die Tests aus.
- Wenn die Tests erfolgreich sind, könnt ihr eure Lösung einreichen. Dazu führt ihr folgenden Befehl aus:

```bash
exercism submit HelloWorld.cs
```

- Wechselt zurück zur [Exercism-Website](https://exercism.io/) und schaut euch die Lösungen anderer an. Vergleicht eure Lösung mit den Lösungen anderer. Was ist anders? Was ist besser? Was ist könnte verbessert werden?
- Verbessert ggfs. eure Lösung und reicht sie erneut ein.
- Wenn ihr mit eurer Lösung zufrieden seid, könnt ihr die Aufgabe als abgeschlossen markieren.

Und schon könnt ihr mit der nächsten Aufgabe weitermachen. Viel Spaß!



