# Projekt-Dokumentation


Gruppe Alpaca Nursiwat

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|   25.10.2022    |  0.0.1  |       Dokumentation angefangen und Planen des Projektes.                            |
|    01.11.2022   | 0.0.2   |       Dokumentation erweitert, Liste für das Voci, Stoppuhr, Startfragen und Feedback am Ende.                                                       |
|    07.11.2022   | 0.0.3   |       Dokumentation erweietert, am Programm weiter gearbeitet.              |
|    15.11.2022   | 1.0.0   |            Programm ist fertig.                                                   |




## 1 Informieren

### 1.1 Ihr Projekt

Wir machen einen Vokabelfragesystem, wo man auf Deutsch oder auf der Fremdsprache beantworten kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            |  funktional |Als User möchte ich dass meine Daten gespeichert werden, damit ich später das Programm wieder benutzten kann.|
|2|muss|funktional|      Als User möchte Ich, dass mich min. 20 Vocis abgefragt werden. |
|3|muss|funktional|      Als User möchte ich, dass ich auswählen kann ob ich auf Deutsch oder auf Englisch antworten kann, damit ich auf verschiedener Art lernen kann.|
|4|muss|funktional|      Als User möchte ich ein Punktesystem, dass mir zeigt wie viele ich richtig und falsch gemacht habe, damit ich eine Übersicht habe wo ich Schwierigkeiten habe und auf welchem Level ich mich befinde.|
|5|muss|funktional|      Als User möchte ich, dass das Punktesystem einen Highscore anzeigt, damit mich das Programm motiviert bessere Leistungen zu erzielen. |
|6|muss|funktional|      Als User möchte ich wissen, wie lange ich für das Beantworten der Vokabeln gebraucht habe, damit ich eine Übersicht habe, ob ich länger oder kürzer brauchte.|
|7|muss|funktional|      Als User möchte ich, dass Wörter, die ich falsch beantwortet habe, nochmal abgefragt werden, damit ich an meinen Fehlern arbeiten kann.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | 
| ---- | ------------ | ------- | ----------------- |
| 1.1   |Pogramm wird geöffnet              |Der User gibt seinen Namen ein     |Es wird gepseichert und es zeigt den Highscore an         |
| 2.1    |Pogramm wird geöffnet              | Der User bestätigt dass er 20 Mal abgefragt werden will      |man wird 20 mal abgefragt                   |
| 3.1    |Programm gibt eine Sprachauswahl aus| Der User gibt ein ob er auf Deutsch oder English antworten will| Es wird die ausgewählte Sprache ausgewählt|
| 4.1    | Der User will seinen Highscore wissen  |   Highscore anzeigen | Der Highscore wird angezeigt|
| 5.1   |Programm wird gestartet          |   Der User fängt an mit dem Übersetzen      |Es wird ein Timer gestartet|
| 6.1   |man beantwortet eine Frage falsch        |Man bestägtigt dass man weiter macht         |Es wird die selbe Frage nochmals gestellt|
|7.1    | User wird nach Alter gefragt  | User gibt Alter ein | Es wird gespeichert |



### 1.4 Diagramme

![La1200PAP](https://user-images.githubusercontent.com/110892637/201883222-0bd2a337-b931-4d8c-97ae-d6d8b876aedf.png)


## 2 Planen

| AP-№ |  Zuständig | Beschreibung | geplante Zeit |
| ---- | --------- | ------------ | ------------- |
| 1.A|           Bühler     |  Der User wird nach seinem Alter gefragt.            |   25 min            |
| 2.A  |          Bühler        |   Der User wird nach seinem Namen gefragt.           |  25 min            |
| 3.A  |          Bühler        |  Der User wird gefragt ob er einige Persönliche Fragen beantworten möchte.            |     25 min          |
|  4.A |          Bühler        |   Dem User wird eine Übersicht gegeben wie viele Punkte er hat.         |      45 min         |
|  5.A |          Bühler        |   Dem User wird eine Übersicht gegeben wie lange er gebraucht hat.           |   45 min            |
|  6.A |          Bühler        |   Dem User wird eine Übersicht gegeben wie viele Wörter beim 1. mal richtig beim 2. mal richtig ect.           | 90 min       |     
|    7.A|       Nursiwat         |Dem User wird eine Wahl gegeben ob er auf English oder auf Deutsch antworten möchte. |45 min|
|    8.A|     Nursiwat            |Dem User wird eine 2. Chance gegeben, wenn er das Wort beim ersten Mal falsch geantwortet hat.|60 min|
| 9.A   |       Kritzner         |Das Punktesystem kann falsche Übersetzungen speichern.|20 min|
|  10.A  |       Kritzner         |Das Punktesystem kann einen Highscore berechnen. |10 min|
|   11.A |       Kritzner         |Am Ende wird der höchste Highscore angezeigt.|5 min|
|  12.A  |       Kritzner         |Das Punktesystem kann falsche Übersetzungen speichern.|20 min|
|  13.A  |       Kritzner         |Die Stoppuhr wird nach einem Durchgang gestoppt und das Resultat gespeichert.|20 min|
| 14.A   |       Kritzner         |Am Schluss wird der beste Versuch angezeigt.|20 min|
| 15.A   |       Mitrovic         |Dem User wird angezeigt ob seine Antwort richtig oder falsch ist.|15 min|
| 16.A    |      Mitrovic| Das Programm fragt zufällige Vocis aus unserer Liste ab.|30 min|
| 17.A  |       Mitrovic|Dem User werden mindestens 20 Vocis abgefragt. |30 min| 
| 18.A    |    Grigioni |Das Programm zeigt die punkte an.|40 min|
| 19.A    |      Mitrovic |Das Programm startet eine Stoppuhr wenn der User mit den Voci abfragen startet.|40 min|
| 20.A    |      Grigioni |Das Programm crasht nicht bei falschen antworten.|20 min|
| 21.A    |      Grigioni |Das Programm hat ein throw catch system um nicht abzustürzen.|50 min|
| 22.A    |      Grigioni |Man kann das Programm beenden wenn man es will.|10 min|
| 23.A|      Mitrovic|Nach dem beenden der Voci Abfrage wird dem User eine Möglichkeit gegeben einen Feedback zu machen.|20 min|
| 24.A  |      Mitrovic |Der User kann, aber muss nicht ein Feedback abgeben.|20 min|
|25.A|      Mitrovic| Das Programm gibt pro richtige Antwort +1 Punkt und pro falschen Antwort -1 Punkt.|30 min|
|26.A|      Nursiwat|Das Programm fragt den User ob er seine falschen Antworten verbessern möchte.|10 min|
|27.A|      Nursiwat|Der User kann entscheiden ob er seine falschen Antworten direkt wieder testen möchte oder eine pause macht.|10 min|
|Total:| ||780min|


## 3 Entscheiden


Wir haben uns entschieden eine Stoppuhr einzubauen, weil wir denken dass es den User mehr motiviert zu lernen.

Wir haben uns entschieden einen Highscore einzubauen, damit der User sehen wie gut er gelernt hat.

Wir haben uns entschieden flasche Antworten wiederholen zu lassen, damit der User schnell die Vokabeln lernt.


## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |   1.11.22    |     Bühler      |   25 min            | 30min                  |
| 2.A  |     1.11.22    |         Bühler  |       25min        |     20min              |
| 3.A  |     1.11.22    |  Bühler         |            25min   |          20min         |
| 4.A  |       1.11.22  |  Bühler         |         45min      |               50min    |
| 5.A  |        1.11.22 |  Bühler         |           45min    |           40min        |
| 6.A  |     1.11.22    |       Bühler    |         90min      |           100min        |
| 7.A  |     1.11.22    |     Nursiwat      |         45min      |           50min        |
| 8.A  |      1.11.22   |      Nursiwat     |          60min     |          65min         |
| 9.A  |     8.11.22    |  Kritzner          |             20min  |           20min        |
| 10.A  |      8.11.22   |        Kritzner    |   10min            |            15min       |
| 11.A  |     8.11.22    |   Kritzner         |        5min       |            10min       |
| 12.A  |     8.11.22    |     Kritzner       | 20min              |         20min          |
| 13.A  |    8.11.22     |    Kritzner        |      20min         |         30min          |
| 14.A  |    8.11.22     |Kritzner            |        20min       |       25min            |
| 15.A  |    8.11.22     |  Mitrovic         |        15min       |         20min          |
| 16.A  |        8.11.22 |   Mitrovic         |           30min    |        35min           |
| 17.A  |     8.11.22    |   Mitrovic         |    30min           |          35min         |
| 18.A  |     8.11.22    |      Grigioni     | 40min              |           45min        |
| 19.A  |    8.11.22     |        Mitrovic    |      40min         |          45min         |
| 20.A  |   8.11.22      |     Grigioni      |  20 min             |           30min        |
| 21.A  |   8.11.22      |    Grigioni       | 50 min              |          60min         |
| 22.A  |   8.11.22      |         Grigioni  |  10 min             |          20min         |
| 23.A  |   8.11.22      |      Mitrovic     |   20 min            |           25min        |
| 24.A  |   8.11.22      |      Mitrovic     |   20 min            |          25min         |
| 25.A  |   8.11.22      |      Mitrovic     | 30 min              |         25min          |
| 26.A  |  8.11.22        |      Nursiwat      |     10 min          |         15min          |
| 27.A  |  8.11.22        |    Nursiwat        |  10 min             |          15min         |
|Total:|  ||780 min|890 min|



## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |    15.11.2022   |      funktioniert   |    Nursiwat+Kritzner    |
| 2.1  | 15.11.2022         |   funktioniert       |    Nursiwat+Kritzner      |
| 3.1  |  15.11.2022        |funktioniert          |    Nursiwat+Kritzner      |
| 4.1  | 15.11.2022         | funktioniert nicht         |    Nursiwat+Kritzner      |
| 5.1  | 15.11.2022         |   funktioniert       |       Nursiwat+Kritzner   |
| 6.1  |  15.11.2022        |  funktioniert        |      Nursiwat+Kritzner    |
| 7.1  |  15.11.2022        |     funktioniert     |     Nursiwat+Kritzner     |

Das meiste vom Programm funktioniert einwandfrei und wir sind alle stolz drauf. Das einzige was nicht funktioniert ist der Highscore, aber das ist nicht so tragisch.



## 6 Auswerten


