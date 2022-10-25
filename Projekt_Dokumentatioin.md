# Projekt-Dokumentation


Gruppe Alpaca Nursiwat

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Wir machen einen Vokabelfragesystem, wo man auf Deutsch oder auf der Fremdsprache beantworten kann.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss            |  Funktionale |Als User möchte ich dass meine Daten gespeichert werden.|
|2|muss|funktional|      Als User möchte Ich dass mich min. 20 Vocis abgefragt werden. |
|3|muss|funktional|      Als User möchte ich dass ich auswählen kann ob ich auf Deutsch oder auf Englisch antworten kann.|
|4|muss|funktional|      Als User möchte ich ein Punktesystem, dass mir zeigt wie viele ich richtig und falsch gemacht habe.|
|5|muss|funktional|      Als User möchte ich, dass das Punktesystem einen Highscore anzeigt|
|6|muss|funktional|      Als User möchte ich wissen, wie lange ich für das Beantworten gebraucht habe.|
|7|muss|funktional|      Als User möchte ich, dass Wörter, die ich falsch beantwortet habe, nochmal abgefragt werden.|



### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | 
| ---- | ------------ | ------- | ----------------- |
| 1    |programm ist geöfnet              |name         |es speichert und zeigt den highscore an                   |
| 2    |programm ist geöfnet              | man bestätigt dass man 20 mal abgefragt werden will        |man wird 20 mal abgefragt                   |
| 3    |program fragt ob man deutsch oder englisch will              |man gibt die gewählte sprache ein         |man wird in der gewälten sprache abgefragt                   |
| 4    |programm ist geöfnet              |nichts         |es zeigt die punkte an                   |
| 5    |program ist geöfnet              |nichts         |es zeigt den highscore an                   |
| 6    |program ist geöfnet              |nichts         |es zeigt ein timer an                   |
| 7    |man beantwortet eine frage falsch              |man bestägtigt dass man weiter macht         |es fragt die selbe frage noch mal                   |


✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme

*Kritzner macht PAP* ✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.
![Vokabelabfragesystem](https://user-images.githubusercontent.com/110892637/197725481-310af2cc-4179-40df-b437-3969ae7eb789.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |           |              |               |
| ...  |       |           |              |               |
|   |       |  Lennard      |  Der User wird nach seinem Alter gefragt            |   25 min            |
|   |       |   Lennard        |   Der User wird nach seinem Namen gefragt           |  25 min            |
|   |       |   Lennard        |  Der User wird gefragt ob er einige Persönliche Fragen beantworrten möchte            |     25 min          |
|   |       |   Lennard        |   Dem User wird eine Übersicht gegeben wieviele Punke er hat          |      45 min         |
|   |       |   Lennard        |   Dem User wird eine Übersicht gegeben wie lange er gebraucht hat           |   45 min            |
|   |       |   Lennard        |   Dem User wird eine Übersicht gegeben wie viele Wörter beim 1. mal richtig beim 2. mal richtig ect.           | 90 min              |
|   |       |Mitrovic          |Dem User werden mindestens 20 Vocis abgefragt. |30 min|

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

