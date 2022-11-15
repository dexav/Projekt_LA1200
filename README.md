# Lern-Bericht
`Gruppenname`: Alpaca 

`Mitglieder`: Xavier Nursiwat, Filip Kritzner, Filip Mitrovic, Lennard Bühler, Leonardo Grigioni 

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------
## Einleitung
Wir haben ein kleines Lernprogramm programmiert mit dem man die English Vocis Lernen kann.


## Was haben wir gelernt?


In diesem Projekt haben wir gelernt, eine Liste zu erstellen und diese in unserem Programm zu verwenden.
## Beschreibung

Wir wissen nun wie wir Daten in einer `.csv Datei` speichern und nachher abrufen können. Anhand des Codebeispiel (Siehe unten 👇🏼) kann man den Code sehen, welcher zum einlesen und speichern der Daten in einem `Array` gebraucht wird.
Unsere voci.csv Datei hat mehrere Spalten und Zeilen. Um die einzelnen Begriffe zu bekommen, muss man die Datei aufteilen und die einzelnen Begriffe in **mehreren Arrays** speichern. Die deutschen Begriffe müssen in das Array deutsch und die englischen Begriffe in das Array english. Zuerst muss man herausfinden wie viele `Zeilen` die Datei hat. Danach ist es wichtig zu wissen wie viele `Spalten` vorhanden sind. Wenn man diese Information hat, kann man anfangen die einzelnen Begriffe aus den jeweiligen Zeilen und Spalten auszulesen und im richtigen Array zu speichern. <br>
Also man liest den ersten Begriff aus der ersten Zeile und ersten Spalte und speichert ihn im array english auf der Position 0. Danach liest man den zweiten Begriff aus der ersten Zeile und ersten Spalte und speichert ihn im array deutsch auf der Position 0. Am Schluss speichert man noch die Punkte. Man liest den dritten Begriff (hier eine Zahl) der ersten Zeile und ersten Spalte und speichert ihn im array points. Man führt das weiter bis man alle Begriffe gespeichert hat.

`Code Besipiel:`


```csharp 
string inPath = @"Voci.csv";
string text = File.ReadAllText(inPath);

string[] lines = text.Split("\r\n");

int words = lines.Length;
string[] english = new string[words];
string[] deutsch = new string[words];
int[] points = new int[words];

for (int line = 0; line < lines.Length; line++)
{
    string[] items = lines[line].Split(',');
    english[line] = items[0];                     //Array english
    deutsch[line] = items[1];                    //Array deutsch
    points[line] = Convert.ToInt32(items[2]);   //Array Punkte
}

for (int line = 0; line < lines.Length; line++)
{
    string[] items = lines[line].Split(',');
    english[line] = items[0];
    deutsch[line] = items[1].Replace("\"", string.Empty);
    points[line] = Convert.ToInt32(items[2]);
}
```

`Gif:`


## Verifikation

* `Code Beispiel:` Das Codebeispiel zeigt ein Code beispiel für eine Liste.

* `Textbeschreibung:` Die Textbeschreibung dient zur verständlichkeit des Codes und des Gifs.

* `Gif:` Das Gif dient zur demonstration des Programmes.

# Reflexion zum Arbeitsprozess


Bei unserer Arbeit lief gut, dass wir unser Projekt sehr gut geplant haben und somit auch in guter Atmosphäre zusammen arbeiten konnten. Dadurch konnten wir auch als Team Erfolge erzielen.


Bei unserer Arbeit lief nicht gut, dass wir einige Probleme mit dem Code zusammenstellen hatten, weil wir noch nie solch eine Arbeit in einer Gruppe gemacht haben.


**VBV**: Ein Verbesserungsvorschlag für uns wäre, dass wir am ende jeder Arbeitssession uns zusammen setzen und den Code zusammen stellen.
