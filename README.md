# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Monkey        Bielski, Bischof, Innamorato und Martullo

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | 0.0.1   | ✍️ Jedes Mal, wenn Sie an dem Projekt arbeiten, fügen Sie hier eine neue Zeile ein und beschreiben in *einem* Satz, was Sie erreicht haben. |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ein Programm erstellen, bei welchem man drei Kurse nach Prioriät auswählen kann und man einem danach zugeteilt wird.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |    Funktional    | soll  | Als ein User möchte ich eine Liste ins Programm einfügen, damit diese Liste am Ende ausgewertet werden kann. |
| 2    |    Funktional   | soll    | Als ein User möchte ich, dass alle meine Prioriäten verarbeitet werden, damit die Wünsche der Schüler beachtet werden. |
| 3    |    Funktional    | soll    | Als ein User möchte ich, dass meine Prioritäten nach reihen folge bearbeitet werden, damit die erste Wünsch zuerst zugeteilt werden |
| 4    |    Funktional   | soll    | Als ein User möchte ich das, wenn die erste Prioriät voll ist, dass die zweite Priorität verarbeitet wird, damit die Schüler nach Reihenfolge der Prioritäten bearbeitet werden. |   
| 5    |    Funktional    | soll    | Als ein User möchte ich das, wennd die zweite Prioriät voll ist das die dritte Priorität verarbeitet wird, damit die Schüler nach Reihenfolge der Prioritäten bearbeitet werden. |
| 6    |    Funktional    |soll    | Als ein User möchte ich das, wennd die dritte Prioriät voll ist, das ich in einen zufälligen Kurs eingeteilt werde, damit die Schüler nach Reihenfolge der Prioritäten bearbeitet werden und es fair für für jeden Fair bleibt. |
| 7    |    Funktional   | soll    | Als ein User möchte ich das wirklich jeder Schüler verarbeitet wird, damit am schluss alle in einen Kurs eingeteilt werden können. |
| 8    |    Funktional    | soll    | Als ein User möchte ich das am schluss eine List mit allen zugteilten Schüler ausgegeben wird, damit die Schüler wissen in welchen Kurs sie eingeteilt worden sind |
|9| funktional|soll|Als User möchte ich, dass die Datei richtig abgespeichert wird, damit sie später benutzt werden kann|


✍️ Jede User Story hat eine ganzzahlige Nummer (1, 2, 3 etc.), eine Verbindlichkeit (Muss oder Kann?), und einen Typ (Funktional, Qualität, Rand). Die User Story selber hat folgende Form: *Als ein 🤷‍♂️ möchte ich 🤷‍♂️, damit 🤷‍♂️*.

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Als User möchte ich Datei eingeben    |  C:/User/Joel/Download       |     Eingabe Erfolgreich              |
| 1.2  |  Als User möchte ich das meine Prioritäten verarbeitet werden             | C:/User/Joel/Download        |    "Sind die Workshops vorhanden?"     |
| 1.3  |  Als User möchte ich das meine Prioritäten verarbeitet werden             | C:/User/Joel/Download        |    "Sind die Workshops vorhanden?"     |
| 1.4  |  Als User möchte ich das meine Prioritäten nach der reihenfolge bearbeitet werden            | C:/User/Joel/Download        | "Sind die Workshops in der richtigen Reihenfolge?"         |


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme
![Hauptprogramm 1](https://user-images.githubusercontent.com/111045891/199693420-33d14673-0abe-4d3e-8605-ea2802d5f6f9.png)



## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |  3.11.2022     |      Innamorato    |  Die Liste mit allen Schüler sollte von dem Programm gelesen werden      |    90           |
| ....  |   3.11.2022     |    Innamorato, Bielski       |   Die Liste mit allen Schüler sollte von dem Programm ausgewertet werden            |       45        |
| ...  |   3.11.2022     |     Innamorato     |  Das Programm soll jeden Schüler von der Liste eine Zahl, der Reihe nach geben    |      45         |
| ...  |   3.11.2022     |     Martullo      |    Das Programm sollte eine Zufallszahl generieren           |    45           |
| ...  |   3.11.2022     |      Bielski     |       Das Programm sollte den Schüler mit den gleichen zahl wie die generierten zahl Zufallszahl wählen       |       45        |
| ...  |  3.11     |    Innamorato      |Funktion für das Auswählen der Prioritäten|45|
| ...  |     3.11  |     Martullo      |Funktion, falls keine Priorität zutrifft|90|
| ...  |     10.11  |    Bischof       |   Datei wird mit dem richtigen Namen abgespeichert           |       45        |
| ...  |   10.11    |   Bielski, Bischof       |   Programm erstellen welches die Liste erstellt           |        90       |
| ...  |  10.11     |    Martullo       |       Workshop Anzahl abfragen       |     45          |
|...|10.11|Bielski |Dateipfad abfragen|45|
|...|10.11|Martullo|Workshopnamen abfragen|45|
|...|10.11|Innamorato|Priortäten werden zugeordnet nachdem ein Kurs voll ist|90|

Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
