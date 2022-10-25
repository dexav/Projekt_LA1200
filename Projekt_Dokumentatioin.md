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



### 1.4 Diagramme


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
|   |       |Mitrovic          |Dem User werden mindestens 20 Vocis abgefragt. |30 min|    |      
|    |      | Nursiwat         |Dem User wird eine Wahl gegeben ob er auf English oder auf Deutsch antworten möchte |45 min|
|||Nursiwat|Dem User wird eine 2. Chance gegeben, wenn er das Wort beim ersten Mal falsch geantwortet hat|60 min|
|    |      | Kritzner         |Das Punktesystem kann falsche Übersetzungen speichern.|20 min|
|    |      | Kritzner         |Das Punktesystem kann einen Highscore berechnen. |10 min|
|    |      | Kritzner         |Am Ende wird der höchste Highscore angezeigt.|5 min|
|    |      | Kritzner         |Das Punktesystem kann falsche Übersetzungen speichern.|20 min|
|    |      | Kritzner         |Falsche Übersetzungen werden nochmal abgefragt.|20 min|
|    |      | Kritzner         |Das Programm startet einen Timer wenn der User beginnt zu übersetzten.|80 min|
|    |      | Kritzner         |Der Timer wird nach einem Durchgang gestoppt und das Resultat gespeichert.|20 min|
|    |      | Kritzner         |Am Schluss wird der beste Versuch angezeigt.|20 min|
|    |      | Mitrovic         |Dem User wird angezeigt ob seine Antwort richtig oder falsch ist|15 min|
|||Leonardo |die frage wird gestellt|10min|
|||Leonardo |man kann die frage beantworten|10min|
|||Leonardo |das program sagt ob es richtig oder falsch war|20|
|||Leonardo |das program zeigt die punket an|40|
|||Leonardo |das program hat ein timer|40|
|||Leonardo |das program crasht nicht bei falschen antworten|20|
|||Leonardo |das program hat ein throw catch system um nicht abzustürzen|50|
|||Leonardo |man kann das Programm beenden wenn man es will|10|
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

