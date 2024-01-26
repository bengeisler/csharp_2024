# Anwendungsentwickler der HWK Charlottenhof 2024
## Git
Git ist ein dezentrales Versionsverwaltungssystem. Es ermöglicht es, Änderungen an Dateien zu verfolgen und diese zu verwalten. Git arbeitet dezentral, das bedeutet, dass jeder Entwickler eine lokale Kopie des gesamten Repositorys hat. Änderungen werden lokal vorgenommen und dann mit dem zentralen Repository synchronisiert.

### Git installieren
1. [Git](https://git-scm.com/downloads) herunterladen, installieren und konfigurieren
2. Git Bash öffnen
3. `git config --global user.name "Vorname Nachname"` ausführen
4. `git config --global user.email "Email"` ausführen

### Repository klonen
1. Git Bash öffnen
2. `git clone https://github.com/bengeisler/csharp_2024.git` ausführen

### Einen Branch erstellen
1. Git Bash öffnen
2. `git checkout -b <branch-name>` ausführen. Dabei `<branch-name>` durch euren Namen ersetzen.
3. `git push --set-upstream origin <branch-name>` ausführen. 

### Links
- [Git](https://git-scm.com/)
- [git - Der einfache Einstieg](https://rogerdudler.github.io/git-guide/index.de.html)