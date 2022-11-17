# Projekt-Dokumentation



Monkey        Bielski, Bischof, Innamorato und Martullo

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|    27.10   | 0.0.1   | Wir haben uns den Auftrag durchgelesen und die Planung gemacht. |
|  3.11     | 0.0.2     |    Planung überarbeitet und mit Arbeitspaketen angefangen.            |
|   10.11    | 1.0.0   |    Angefangen mit dem Realisieren und der Umsetztung.                 |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Programm erstellen, bei welchem man drei Kurse nach Prioriät auswählen kann und man einem danach zugeteilt wird.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    Funktional    | soll  | Als ein User möchte ich eine Liste ins Programm einfügen, damit diese Liste am Ende ausgewertet werden kann. |
| 2    |    Funktional   | soll    | Als ein User möchte ich, dass alle meine Prioriäten verarbeitet werden, damit die Wünsche der Schüler beachtet werden. |
| 3    |    Funktional    | soll    | Als ein User möchte ich, dass meine Prioritäten der Reihe nach bearbeitet werden, damit die erste Wünsch zuerst zugeteilt werden. |
| 4    |    Funktional   | soll    | Als ein User möchte ich das, wenn die erste Prioriät voll ist, dass die zweite Priorität verarbeitet wird, damit die Schüler nach Reihenfolge der Prioritäten bearbeitet werden. |   
| 5    |    Funktional    | soll    | Als ein User möchte ich das, wennd die zweite Prioriät voll ist das die dritte Priorität verarbeitet wird, damit die Schüler nach Reihenfolge der Prioritäten bearbeitet werden. |
| 6    |    Funktional    |soll    | Als ein User möchte ich das, wennd die dritte Prioriät voll ist, das ich in einen zufälligen Kurs eingeteilt werde, damit die Schüler nach Reihenfolge der Prioritäten bearbeitet werden und es fair für für jeden Fair bleibt. |
| 7    |    Funktional   | soll    | Als ein User möchte ich das wirklich jeder Schüler verarbeitet wird, damit am Schluss alle in einen Kurs eingeteilt werden können. |
| 8    |    Funktional    | soll    | Als ein User möchte ich das am schluss eine List mit allen zugteilten Schüler ausgegeben wird, damit die Schüler wissen in welchem Kurs sie eingeteilt worden sind. |
|9| funktional|soll|Als User möchte ich, dass die Datei richtig abgespeichert wird, damit sie später benutzt werden kann.|




### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Als User möchte ich Datei eingeben    |  C:/User/Joel/Download       |     Eingabe Erfolgreich              |
| 2.2  |  Als User möchte ich das meine Prioritäten verarbeitet werden             | C:/User/Joel/Download        |    "Sind die Workshops vorhanden?"     |
| 3.3  |  Als User möchte ich das meine Prioritäten nach der reihenfolge bearbeitet werden            | C:/User/Joel/Download        | "Sind die Workshops in der richtigen Reihenfolge?"         |
|4.4|Erste Priorität voll| Datei eingelesen|Zweite Priorität wird ausgewählt|
5.5|Zweite Pritorität voll|Datei eingelesen|Dritte Priorität wird ausgewählt|
|6.6|Alle Prioritäten voll|Datei eingelesen|Zufälliger Kurs wird zugeteilt|
|8.7|Datei wurde eingelesen und ausgewertet|/|Liste wird in geplantem Speicherort abgespeichert|
|9.8|Datei wurde eingelesen und ausgewertet|/|Datei wird im richtigen Speicherort abgespeichert|




### 1.4 Diagramme
![Hauptprogramm 1](https://user-images.githubusercontent.com/111045891/199693420-33d14673-0abe-4d3e-8605-ea2802d5f6f9.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.1 |  3.11.2022     |      Innamorato    |  Die Liste mit allen Schüler sollte vom Programm gelesen werden      |    90           |
| 1.2 |   3.11.2022     |    Innamorato, Bielski       |   Die Liste mit allen Schüler sollte vom Programm ausgewertet werden            |       45        |
|  2.1 |   3.11.2022     |     Innamorato     |  Das Programm soll jedem Schüler von der Liste eine Zahl, der Reihe nach zuweisen    |      45         |
|  2.2 |   3.11.2022     |     Martullo      |    Das Programm sollte eine Zufallszahl generieren           |    45           |
| 2.3  |   3.11.2022     |      Bielski     |       Das Programm sollte den Schüler mit der gleichen Zahl, wie die generierte Zufallszahl wählen       |       45        |
|  3.1 |  3.11     |    Innamorato      |Funktion für das Auswählen der Prioritäten|45|
| 6.1  |     3.11  |     Martullo      |Funktion, falls keine Priorität zutrifft|90|
| 8.1  |     10.11  |    Bischof       |   Datei wird mit dem richtigen Namen abgespeichert           |       45        |
| 8.2  |   10.11    |   Martullo, Bischof       |   Programm erstellen, welches die Liste erstellt           |        90       |
|  A | 10.11     |    Bielski       |       Workshop Anzahl abfragen       |     45          |
|B|10.11|Bielski |Dateipfad abfragen|45|
|C|10.11|Bischof|Workshopnamen abfragen|45|
|D|10.11|Innamorato|Priortäten werden zugeordnet nachdem ein Kurs voll ist|90|

Total: 
/ = Arbeitspaket wurde ohne Verbindung zu einer Userstory erstellt.


## 3 Entscheiden
Wir haben uns entschieden, unser Projekt anders anzugehen, als wir es anfangs geplant haben. Denn wir sind von allem selber eingeben, dazu gewechselt, dass, eine Liste vom Programm eingelesen wird.


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.1A  | 3.11      |   Innamorato    , Bischof    |     90          |       120          |
| 1.2B  |   3.11    |   Innamorato, Bielski        |     45          |     60              |
| 2.1C  |   3.11    |   Innamorato, Bielski        |     45          |   20              |
| 2.2D  |   3.11    |  Martullo        |     45          |     20              |
| 3.1E  |   3-10.11    |   Innamorato      |     45          |    180             |
| 6.1F |   10.11    |   Martullo       |     45          |     60              |
| 8.1 G |   10.11    |  Bischof        |     45          |     60              |
| 8.2H  |   10.11    |   Giuliano, Bischof          |     60              |20|
| A.I  |   10.11    |   Bielski          |     45              |35|
| B.J  |   10.11    |   Bielski        |     45             |40|
|C.K|10.11|Bischof|45|30|
|D.L|10.11|Innamorato|90|60|


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |   17.11    |    OK      |   Innamorato     |
|2.2  |   17.11    |   OK       |   Bielski     |
|4.4 |   17.11    |   OK       |   Bielski     |
|5.5 |   17.11    |   OK       |   Bielski     |
|6.6 |   17.11    |   OK       |   Bielski     |
|8.7 |   17.11    |   NOK       |   Bielski     |
|9.8 |   17.11    |   OK       |   Bielski     |


Fast alle Testfälle funktionieren oder sollten funktionieren Liste wird jedoch nicht korrekt abgespeichert



## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
