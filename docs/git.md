
# Git
Git ist ein dezentrales Versionsverwaltungssystem. Es ermöglicht es, Änderungen an Dateien zu verfolgen und diese zu verwalten. Git arbeitet dezentral, das bedeutet, dass jeder Entwickler eine lokale Kopie des gesamten Repositorys hat. Änderungen werden lokal vorgenommen und dann mit dem zentralen Repository synchronisiert.

## GitHub
GitHub ist ein (der beliebteste) Online-Dienst, der Git-Repositories hostet. Um in diesem Kurs mitarbeiten zu können, benötigt ihr einen GitHub-Account. Diesen könnt ihr [hier](https://github.com/) erstellen.

## Git konfigurieren
2. Git Bash öffnen
3. `git config --global user.name "Vorname Nachname"` ausführen
4. `git config --global user.email "Email"` ausführen
5. [Visual Studio als merge und diff tool konfigurieren](https://www.codewrecks.com/post/old/2019/07/how-to-configure-visual-studio-as-diff-and-merge-tool-for-git/)

## Repository klonen
1. Git Bash öffnen
2. `git clone https://github.com/bengeisler/csharp_2024.git` ausführen

## Einen eigenen Branch erstellen
1. Git Bash öffnen
2. `git checkout -b <branch-name>` ausführen. Dabei `<branch-name>` durch euren Namen ersetzen.
3. `git push --set-upstream origin <branch-name>` ausführen.

Beim ersten Mal müsst ihr euch mit eurem GitHub-Account anmelden. Das geht entweder, indem ihr die Github CLI installiert und `gh auth login` ausführt oder indem ihr den ersten Push mit Visual Studio ausführt. Visual Studio wird euch dann auffordern, euch mit eurem GitHub-Account anzumelden.

## Auf mehreren Branches gleichzeitig arbeiten
Per Default arbeitet ihr auf dem Branch, den ihr zuletzt ausgecheckt habt. Euer Arbeitsverzeichnis, also der Ordner, in dem ihr eure Dateien bearbeitet, wird automatisch auf den Branch gesetzt, auf dem ihr arbeitet. Das bedeutet, dass ihr nur die Version der Dateien eures Branches seht.
Manchmal ist es aber nötig, dass ihr auf mehreren Branches gleichzeitig arbeitet. Das geht mit dem Befehl `git worktree`. Dieser Befehl erstellt einen neuen Ordner, in dem ihr auf einem anderen Branch arbeiten könnt. Im Rahmen dieses Kurses macht es Sinn, dies für den `main`-Branch zu tun, da ihr dort alle Aufgaben und Lösgungen findet.

1. Git Bash öffnen
2. `git worktree list` liefert euch eine Übersicht über alles Worktrees, die ihr bereits erstellt habt. Ihr solltet hier nur euren eigenen Branch sehen.
3. `git branch` ausführen. Ihr solltet euch jetzt auf eurem eigenen Branch befinden. Falls nicht, könnt ihr mit `git checkout <branch-name>` auf euren Branch wechseln. `<branch-name>` ist dabei der Name eures Branches, den ihr beim Erstellen angegeben habt.
4. `git worktree add ../chsharp_2024_wt/main main` ausführen. Dabei ist `../csharp_2024_wt` der Pfad zu dem Ordner, in dem ihr eure Worktrees speichern wollt. `main` ist der Name Hauptbranches, auf dem sich die Aufgabenstellungen und Lösungen befinden.
5. `git worktree list` ausführen. Ihr solltet jetzt zwei Worktrees sehen. Euren eigenen Branch und den `main`-Branch.

Am einfachsten ist es, wenn ihr in Visual Studio zwei Instanzen öffnet. Eine für euren eigenen Branch und eine für den `main`-Branch. So könnt ihr auf eurem Branch bleiben und trotzdem gleichzeitig die Aufgabenstellungen und Lösungen sehen.

## Links
- [git - Der einfache Einstieg](https://rogerdudler.github.io/git-guide/index.de.html)
- [Git Dokumentation](https://git-scm.com/)
- [kostenloses Ebook: Pro Git](https://git-scm.com/book/de/v2)
