
# Git
Git ist ein dezentrales Versionsverwaltungssystem. Es ermöglicht es, Änderungen an Dateien zu verfolgen und diese zu verwalten. Git arbeitet dezentral, das bedeutet, dass jeder Entwickler eine lokale Kopie des gesamten Repositorys hat. Änderungen werden lokal vorgenommen und dann mit dem zentralen Repository synchronisiert.

## GitHub
GitHub ist ein (der beliebteste) Online-Dienst, der Git-Repositories hostet. Um in diesem Kurs mitarbeiten zu können, benötigt ihr einen GitHub-Account. Diesen könnt ihr [hier](https://github.com/) erstellen.

## Git konfigurieren
2. Git Bash öffnen
3. `git config --global user.name "Vorname Nachname"` ausführen
4. `git config --global user.email "Email"` ausführen

## Repository klonen
1. Git Bash öffnen
2. `git clone https://github.com/bengeisler/csharp_2024.git` ausführen

## Einen eigenen Branch erstellen
1. Git Bash öffnen
2. `git checkout -b <branch-name>` ausführen. Dabei `<branch-name>` durch euren Namen ersetzen.
3. `git push --set-upstream origin <branch-name>` ausführen.

Beim ersten Mal müsst ihr euch mit eurem GitHub-Account anmelden. Das geht entweder, indem ihr die Github CLI installiert und `gh auth login` ausführt oder indem ihr den ersten Push mit Visual Studio ausführt. Visual Studio wird euch dann auffordern, euch mit eurem GitHub-Account anzumelden.

## Links
- [git - Der einfache Einstieg](https://rogerdudler.github.io/git-guide/index.de.html)
- [Git Dokumentation](https://git-scm.com/)
- [kostenloses Ebook: Pro Git](https://git-scm.com/book/de/v2)
