# Projekt-Dokumentation


Gruppe Alpaca Nursiwat

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   08/11/22    | 0.1.0     |                                                            |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen einen Vokabelfragesystem, wo man auf Deutsch oder auf der Fremdsprache beantworten kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            |  Funktionale |Als User möchte ich dass meine Daten gespeichert werden, damit ich später das Programm wieder benutzten kann.|
|2|muss|funktional|      Als User möchte Ich, dass mich min. 20 Vocis abgefragt werden. |
|3|muss|funktional|      Als User möchte ich, dass ich auswählen kann ob ich auf Deutsch oder auf Englisch antworten kann, damit ich auf verschiedener Art lernen kann.|
|4|muss|funktional|      Als User möchte ich ein Punktesystem, dass mir zeigt wie viele ich richtig und falsch gemacht habe, damit ich eine Übersicht habe wo ich Schwierigkeiten habe und auf welchem Level ich mich befinde.|
|5|muss|funktional|      Als User möchte ich, dass das Punktesystem einen Highscore anzeigt, damit mich das Programm motiviert bessere Leistungen zu erzielen. |
|6|muss|funktional|      Als User möchte ich wissen, wie lange ich für das Beantworten der Vokabeln gebraucht habe, damit ich eine Übersicht habe, ob ich länger oder kürzer brauchte.|
|7|muss|funktional|      Als User möchte ich, dass Wörter, die ich falsch beantwortet habe, nochmal abgefragt werden, damit ich meine Fehler besser lernen und auch testen kann|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | 
| ---- | ------------ | ------- | ----------------- |
| 1    |Pogramm ist geöffnet              |Der User gibt seinen Namen ein     |Es wird gepseichert und es zeigtr den Hihgscore an.         |
| 2    |Pogramm ist geöffnet              | Der User bestätigt dass er 20 Mal abgefragt werden will      |man wird 20 mal abgefragt                   |
| 3    |Programm gibt eine Sprachauswahl aus| Der User gibt ein ob er auf Deutsch oder English antworten will| Es wird die ausgewählte Sprache ausgewählt|
| 4    | Der User will seinen Highscore wissen  |   Highscore anzeigen | Der Highscore wird angezeigt.|
| 5   |Programm ist geöffnet          |nichts         |Es wird ein Timer gemacht|
| 6   |man beantwortet eine Frage falsch        |man bestägtigt dass man weiter macht         |Es wird die selbe Frage nochmals gestellt.|
|7    | User wird nach Alter gefragt  | User gibt Alter ein | es wird gespeichert |



### 1.4 Diagramme

![Vokabelabfragesystem](https://user-images.githubusercontent.com/110892683/199191825-54e9a86f-454f-4414-8c04-3a19e41bbdf0.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A|         |  Bühler     |  Der User wird nach seinem Alter gefragt.            |   25 min            |
| 2.A  |       |   Bühler        |   Der User wird nach seinem Namen gefragt.           |  25 min            |
| 3.A  |       |   Bühler        |  Der User wird gefragt ob er einige Persönliche Fragen beantworten möchte.            |     25 min          |
|  4.A |       |   Bühler        |   Dem User wird eine Übersicht gegeben wie viele Punkte er hat.         |      45 min         |
|  5.A |       |   Bühler        |   Dem User wird eine Übersicht gegeben wie lange er gebraucht hat.           |   45 min            |
|  6.A |       |   Bühler        |   Dem User wird eine Übersicht gegeben wie viele Wörter beim 1. mal richtig beim 2. mal richtig ect.           | 90 min       |     
|    7.A|      | Nursiwat         |Dem User wird eine Wahl gegeben ob er auf English oder auf Deutsch antworten möchte. |45 min|
|    8.A|     |Nursiwat            |Dem User wird eine 2. Chance gegeben, wenn er das Wort beim ersten Mal falsch geantwortet hat.|60 min|
| 9.A   |      | Kritzner         |Das Punktesystem kann falsche Übersetzungen speichern.|20 min|
|  10.A  |      | Kritzner         |Das Punktesystem kann einen Highscore berechnen. |10 min|
|   11.A |      | Kritzner         |Am Ende wird der höchste Highscore angezeigt.|5 min|
|  12.A  |      | Kritzner         |Das Punktesystem kann falsche Übersetzungen speichern.|20 min|
|  13.A  |      | Kritzner         |Die Stoppuhr wird nach einem Durchgang gestoppt und das Resultat gespeichert.|20 min|
| 14.A   |      | Kritzner         |Am Schluss wird der beste Versuch angezeigt.|20 min|
| 15.A   |      | Mitrovic         |Dem User wird angezeigt ob seine Antwort richtig oder falsch ist.|15 min|
| 16.A    |      |Mitrovic| Das Programm fragt zufällige Vocis aus unserer Liste ab.|30 min|
| 17.A  |       |Mitrovic|Dem User werden mindestens 20 Vocis abgefragt. |30 min| 
| 18.A    |    |Grigioni |Das program zeigt die punkte an.|40 min|
| 19.A    |      |Mitrovic |Das Programm startet eine Stoppuhr wenn der User mit den Voci abfragen startet.|40 min|
| 20.A    |      |Grigioni |Das program crasht nicht bei falschen antworten.|20 min|
| 21.A    |      |Grigioni |Das program hat ein throw catch system um nicht abzustürzen.|50 min|
| 22.A    |      |Grigioni |Man kann das Programm beenden wenn man es will.|10 min|
| 23.A|      |Mitrovic|Nach dem beenden der Voci Abfrage wird dem User eine Möglichkeit gegeben einen Feedback zu machen.|20 min|
| 24.A  |      |Mitrovic |Der User kann, aber muss nicht ein Feedback abgeben.|20 min|
|25.A|      |Mitrovic| Das Programm gibt pro richtige Antwort +1 Punkt und pro falschen Antwort -1 Punkt.|30 min|
|26.A|      |Nursiwat|Das Programm fragt den User ob er seine falschen Antworten verbessern möchte|10 min|
|27.A|      |Nursiwat|Der User kann entscheiden ob er seine falschen Antworten direkt wieder testen möchte oder eine pause macht.|10 min|
|28.A|      |Grigioni|||
Total: 


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

