// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Dwg

namespace AVC
{
  /// <summary>
  /// Localization strings for PTT(Paste To Table), TableSplit commands. PasteToTableOptions dialog box
  /// </summary>
  public static class 
  PasteToTableL
  {
    // ============================= Paste To Table style ===========================
    public static readonly string[] DestinationTable = { 
      "Dwg Table", 
      "Dwg Таблица", 
      "Dwg Tabella", 
      "Dwg Tabelle",
      "Dwg 表"};
    public static readonly string[] DestinationMText = { 
      "Dwg MText", 
      "Dwg Текст", 
      "Dwg Testo", 
      "Dwg Text",
      "Dwg 文本" };
    public static readonly string[] DestinationExcel = { "Excel" };
    public static readonly string[] DestinationCSV = { 
      "File CSV", 
      "Файл CSV", 
      "File CSV", 
      "Datei CSV",
      "文件 CSV" };
    public static readonly string[] DestinationXML = { 
      "File XML", 
      "Файл XML", 
      "File XML", 
      "Datei XML",
      "文件 XML" };
    public static readonly string[] DestinationClipboard = { 
      "Clipboard", 
      "Буфер", 
      "Appunti", 
      "Zwischenablage",
      "剪贴板" };

    // =============================   Table Split ==================================
    public static readonly string[] Split = { 
      "Split table", 
      "Разбиение таблицы", 
      "Tavolo separato", 
      "Split-Tabelle",
      "拆分表"};
    public static readonly string[] NoSplit = { 
      "Could not split the table", 
      "Не получилось разделить таблицу", 
      "Impossibile dividere la tabella", 
      "Die Tabelle konnte nicht geteilt werden",
      "无法拆分表格" };
    public static readonly string[] Divided = { 
      "The table is divided into {0} layouts", 
      "Таблица разделена на {0} листов", 
      "La tabella è divisa in layout di {0}", 
      "Die Tabelle ist in {0} Layouts unterteilt",
      "该表分为 {0} 个布局" };
    public static readonly string[] Merge = { 
      "Merge table", 
      "Объединение таблицы", 
      "Unisci tabella", 
      "Zusammenführungstabelle",
      "合并表" };

    // ============================= Paste To Table ====================================

    public static readonly string[] ClipboardErr = {
      "Error while working with the clipboard: {0}",
      "Ошибка при работе с буфером обмена: {0}",
      "Errore mentre si lavora con gli appunti: {0}",
      "Fehler beim Arbeiten mit der Zwischenablage: {0}",
      "使用剪贴板时出错：{0}"};
    public static readonly string[] CopiedToClipboard = {
      "  Results are copied to the clipboard",
      "  Результаты скопированы в буфер",
      "  I risultati vengono copiati negli appunti",
      "  Ergebnisse in die Zwischenablage kopiert.",
      "  结果被复制到剪贴板"};
    public static readonly string[] Writing = {
      "Writing to table", 
      "Запись в таблицу", 
      "Scrivere a tavola", 
      "Auf den Tisch schreiben",
      "写到表" };
    public static readonly string[] SelectTable = {
      "Select Table. All data will be overwritten" ,
      "Выберите таблицу. Все данные будут затерты",
      "Seleziona tabella. Tutti i dati verranno sovrascritti",
      "Wählen Sie Tabelle. Alle Daten werden überschrieben",
      "选择表。 所有数据将被覆盖" };
    public static readonly string[] NeedTable = {
      "\nNeed selected a Table!\n",
      "\nНужно выбрать таблицу!\n",
      "\nHai selezionato una tavola!\n",
      "\nNeed ausgewählt eine Tabelle!\n",
      "\n需要选择一个表！\n" };
    public static readonly string[] NoText = {
      "Clipboard not contain text for paste" ,
      "В буфере обмена не содержится текста для вставки",
      "Gli appunti non contengono il testo per la colla",
      "Zwischenablage enthält keinen Text zum Einfügen",
      "剪贴板不包含用于粘贴的文本"};
    public static readonly string[] Inserted = {
      "Inserted data rows {0}",
      "Вставлено строк данных {0}",
      "Le righe di dati inserite {0}",
      "Eingefügte Datenzeilen {0}",
      "插入的数据行 {0}" };
    public static readonly string[] TableFound = {
      "  A table entitled '{0}' was found in the drawing '{1}'. It will be used to insert new data.",
      "  В чертеже '{1}' найдена таблица с заголовком '{0}'. Она будет использована для вставки новых данных.",
      "  Una tabella intitolata '{0}' è stata trovata nel disegno '{1}'. Sarà utilizzato per inserire nuovi dati.",
      "  Eine Tabelle mit dem Titel '{0}' wurde in der Zeichnung '{1}' gefunden. Es wird verwendet, um neue Daten einzufügen.",
      "  在绘图“{1}”中找到标题为“{0}”的表。 它将用于插入新数据。" };
    public static readonly string[] NewKW = { 
      "New", 
      "НОвая", 
      "NUovo", 
      "Neu",
      "新的(N)" };

    // ===================================== Dialog Box =======================================================

    public static readonly string[] EditStyleText = {
      "Edit Style",
      "Редактор стиля",
      "Modifica stile",
      "Stil bearbeiten",
      "编辑样式" };
    public static readonly string[] EditStyleTip = {
      "Close this window and call the TableStyle command \r\n" +
        "to configure all the parameters of the new dwg-table.",
      "Закрыть это окно и вызвать команду TableStyle, \r\n" +
        "чтобы настроить стиль новой таблицы.",
      "Chiudi questa finestra e chiama il comando TableStyle \r\n" +
        "per configurare tutti i parametri della nuova tabella DWG.",
      "Verlieren Sie dieses Fenster und rufen Sie den Befehl TableStyle auf, \r\n" +
        "um alle Parameter der neuen DWG-Tabelle zu konfigurieren.",
      "丢掉这个窗口，调用 TableStyle 命令配置新 dwg-table 的所有参数。" };
    public static readonly string[] FileOpenTip = {
      "Select a folder for saving file",
      "Диалог выбора папки для сохранения.",
      "Seleziona una cartella per il salvataggio del file",
      "Wählen Sie einen Ordner zum Speichern der Datei",
      "选择保存文件的文件夹" };
    public static readonly string[] AdaptWidthText = {
      "Adapt Width",
      "Авто ширина",
      "Adatta larghezza",
      "Breite anpassen",
      "适应宽度" };
    public static readonly string[] AdaptWidthTip = {
      "Adapt the width of the columns by content.",
      "Адаптировать ширину колонок по содержимому",
      "Adatta la larghezza delle colonne in base al contenuto.",
      "Passen Sie die Breite der Spalten nach Inhalt an.",
      "按内容调整列的宽度。" };
    public static readonly string[] ClearCellsText = {
      "Clear Columns",
      "Очищать колонки",
      "Cancella colonne",
      "Spalten löschen",
      "清除列" };
    public static readonly string[] ClearCellsTip = {
      "If there are more columns in the table than necessary - clear extra cells.",
      "Если в таблице больше столбцов, чем надо - очистить лишние",
      "Se nella tabella sono presenti più colonne del necessario, cancella le celle extra.	",
      "Wenn die Tabelle mehr Spalten als nötig enthält, löschen Sie zusätzliche Zellen.",
      "如果表格中的列多于必要的列 - 清除多余的单元格。" };
    public static readonly string[] ClearStyleOverridesText = {
      "Clear Style",
      "Очищать стиль",
      "Stile chiaro",
      "Klarer Stil",
      "清晰的风格" };
    public static readonly string[] ClearStyleOverridesTip = {
      "Clear format settings for all table cells. \r\n" +
        "Cell style settings will be used.",
      "Очистить настройки формата всех ячеек таблицы. \r\n" +
        "Будут использованы настройки по стилю ячеек.",
      "Cancella le impostazioni di formato per tutte le celle della tabella. \r\n" +
        "Verranno utilizzate le impostazioni dello stile della cella.",
      "Formateinstellungen für alle Tabellenzellen löschen. \r\n" +
        "Zellenstileinstellungen werden verwendet.",
      "清除所有表格单元格的格式设置。 \r\n" +
        "将使用单元格样式设置。" };
    public static readonly string[] DelRowsText = {
      "Delete Rows",
      "Удалять строки",
      "Elimina righe",
      "Zeilen löschen",
      "删除行" };
    public static readonly string[] DelRowsTip = {
      "If there are more rows in the table than necessary, delete the extra lines.",
      "Если в таблице больше строк, чем надо - удалить лишние строки.",
      "Se nella tabella sono presenti più righe del necessario, eliminare le righe extra.",
      "Wenn die Tabelle mehr Zeilen als nötig enthält, löschen Sie die zusätzlichen Zeilen.",
      "如果表中的行数超过必要行数，请删除多余的行。" };
    public static readonly string[] DestinationTip = {
      "Where to insert the received data.",
      "Куда вставлять полученные данные.",
      "Dove inserire i dati ricevuti.",
      "Wo die empfangenen Daten einzufügen sind.",
      "在哪里插入接收到的数据。" };
    public static readonly string[] DialogText = {
      "Show Dialog",
      "Показ диалога",
      "Mostra di dialogo",
      "Dialog anzeigen",
      "显示对话框" };
    public static readonly string[] DialogTip = {
      "Show the dialog for selecting a table before inserting data, \r\n" +
        "or simply query the selection of a table in a drawing.",
      "Показывать диалог выбора таблицы перед вставкой данных.	",
      "Mostra la finestra di dialogo per selezionare una tabella prima di inserire dati, \r\n" +
        "o semplicemente interrogare la selezione di una tabella in un disegno.",
      "Zeigen Sie den Dialog zum Auswählen einer Tabelle vor dem Einfügen \r\n" +
        "von Daten an oder fragen Sie einfach die Auswahl einer Tabelle in einer Zeichnung ab.",
      "在插入数据之前显示用于选择表格的对话框，\r\n" +
        "或者只是在图纸中查询表格的选择。" };
    public static readonly string[] DwgFolderText = {
      "Dwg Folder",
      "Папка Dwg",
      "Dwg Cartella",
      "Dwg-Ordner",
      "Dwg 文件夹" };
    public static readonly string[] DwgFolderTip = {
      "Create a subfolder in the specified folder with the same name as the drawing.",
      "Создать в указанной папке подпапку с таким же именем как у чертежа.",
      "Creare una sottocartella nella cartella specificata con lo stesso nome del disegno.",
      "Erstellen Sie im angegebenen Ordner einen Unterordner mit demselben Namen wie die Zeichnung.",
      "在指定文件夹中创建与图形同名的子文件夹。" };
    public static readonly string[] FrameText = {
      "Text Frame",
      "Рамка текста",
      "Cornice di testo",
      "Textrahmen",
      "文本框" };
    public static readonly string[] FrameTip = {
      "Draw a frame around the text.",
      "Прямоугольная рамка вокруг текста",
      "Disegna una cornice attorno al testo.",
      "Ziehen Sie einen Rahmen um den Text.",
      "在文本周围画一个框架。" };
    public static readonly string[] GroupTitlesText = {
      "Group Titles",
      "Имя группы",
      "Titoli di gruppo",
      "Gruppentitel",
      "组标题" };
    public static readonly string[] GroupTitlesTip = {
      "Insert rows with group headers before any group. \r\n" +
        "And set cell-style TITLE",
      "Вставлять строки с заголовками групп перед каждой группой. \r\n" +
        "И присвоить строке стиль НАЗВАНИЕ",
      "Inserisci le righe con le intestazioni di gruppo prima di qualsiasi gruppo. \r\n" +
        "E imposta lo stile cella  TITLE",
      "Zeilen mit Gruppenüberschriften vor jeder Gruppe einfügen. \r\n" +
        "Und setzen Sie TITLE im Zellenstil",
      "在任何组之前插入带有组标题的行。 \r\n" +
        "并设置单元格样式的 TITLE" };
    public static readonly string[] HeadersText = {
      "Headers",
      "Заголовки",
      "Intestazioni",
      "Überschriften",
      "标头" };
    public static readonly string[] HeadersTip = {
      "Write column headers in second row of table. \r\n" +
        "Set cell-style HEADER",
      "Вставлять заголовки столбцов во вторую строку таблицы. \r\n" +
        "И присвоить стиль ячеек ЗАГОЛОВОК",
      "Scrivi le intestazioni di colonna nella seconda riga della tabella. \r\n" +
        "Imposta lo stile cella HEADER",
      "Schreiben Sie die Spaltenüberschriften in die zweite Zeile der Tabelle. \r\n" +
        "Legen Sie HEADER im Zellenstil fest",
      "在表格的第二行写入列标题。 \r\n" +
        "设置单元格样式的 HEADER" };
    public static readonly string[] MergeGroupTitlesText = {
      "Merge Titles",
      "Объединять",
      "Unisci titoli",
      "Titel zusammenführen",
      "合并标题" };
    public static readonly string[] MergeGroupTitlesTip = {
      "Merge all cells in Title and Group headers rows.",
      "Объединить название таблицы и заголовки групп в одну ячейку.",
      "Unisci tutte le celle nelle righe delle intestazioni Titolo e Gruppo.",
      "Führen Sie alle Zellen in den Titel- und Gruppenkopfzeilen zusammen.",
      "合并标题和组标题行中的所有单元格。" };
    public static readonly string[] OpenFileText = {
      "Open file",
      "Открыть",
      "Apri il file",
      "Datei öffnen",
      "打开文件" };
    public static readonly string[] OpenFileTip = {
      "Run the program associated with this file type.",
      "Запустить программу ассоциированную с данным типом файлов.",
      "Esegui il programma associato a questo tipo di file.",
      "Führen Sie das diesem Dateityp zugeordnete Programm aus.",
      "运行与此文件类型关联的程序。" };
    public static readonly string[] ReplaceFileText = {
      "Replace old files",
      "Заменять старые файлы",
      "Sostituisci i vecchi file",
      "Alte Dateien ersetzen",
      "替换旧文件" };
    public static readonly string[] ReplaceFileTip = {
      "If the file already exists, it must be replaced with a new one. \r\n" +
        "Otherwise, the program will add the version number to the end of the file name.",
      "Если файл с таблицей уже существует, то заменить его. \r\n" +
        "Если не включать данную опцию, то программа сохранит старый файл, \r\n" +
        "а у новой таблицы будет дописан номер версии в конце имени.",
      "Se il file esiste già, deve essere sostituito con uno nuovo. \r\n" +
        "Altrimenti, il programma aggiungerà il numero di versione alla fine del nome del file.",
      "Wenn die Datei bereits existiert, muss sie durch eine neue ersetzt werden. \r\n" +
        "Andernfalls fügt das Programm die Versionsnummer an das Ende des Dateinamens an.",
      "如果该文件已经存在，则必须用新文件替换它。 \r\n" +
        "否则，程序会将版本号添加到文件名的末尾。" };
    public static readonly string[] SplitText = {
      "Split Table",
      "Разбить таблицу",
      "Tavolo diviso",
      "Split-Tabelle",
      "拆分表" };
    public static readonly string[] SplitTip = {
      "Split the table into several sheets (layout) if it does not fit into one sheet. \r\n" +
        "The new sheets will be a copy of the table sheet.",
      "Разбить таблицу на несколько листов (layout), если она не лезет в один лист. \r\n" +
        "Новые листы будут копией листа с таблицей.",
      "Dividi la tabella in più fogli (layout) se non si adatta a un foglio. \r\n" +
        "I nuovi fogli saranno una copia del foglio del tavolo.",
      "Teilen Sie die Tabelle in mehrere Blätter (Layout) auf, wenn sie nicht in ein Blatt passt. \r\n" +
        "Die neuen Blätter sind eine Kopie des Tabellenblatts.",
      "如果表格不适合一张纸，请将其拆分为多张纸（布局）。 \r\n" +
        "新工作表将是表格工作表的副本。" };
    public static readonly string[] SplitterText = {
      "Field separator",
      "Разделитель полей",
      "Spaccalegna",
      "Feldtrenner",
      "字段分隔符" };
    public static readonly string[] SplitterTip = {
      "A character to separate columns in one row.",
      "Символ для разделения столбцов в каждой строке.",
      "Un personaggio per separare le colonne in una riga.",
      "Ein Zeichen zum Trennen von Spalten in einer Zeile.",
      "用于分隔一行中的列的字符。" };
    public static readonly string[] TableStyleText = {
      "Style",
      "Стиль",
      "Stile",
      "Stil",
      "风格" };
    public static readonly string[] TableStyleTip = {
      "Style for creating new tables. \r\n" +
        "Leave the field blank to use the current table style.",
      "Стиль для создания новых таблиц. \r\n" +
        "Оставьте поле пустым, чтоб использовать текущий стиль таблиц.",
      "Stile per la creazione di nuove tabelle. \r\n" +
        "Lascia vuoto il campo per utilizzare lo stile di tabella corrente.",
      "Stil zum Erstellen neuer Tabellen. \r\n" +
        "Lassen Sie das Feld leer, um den aktuellen Tabellenstil zu verwenden.",
      "创建新表的样式。 \r\n" +
        "将该字段留空以使用当前表格样式。" };
    public static readonly string[] TextStyleText = {
      "Text style",
      "Стиль текста",
      "Stile del testo",
      "Textstil",
      "文字样式" };
    public static readonly string[] TextStyleTip = {
      "Style for creating new MText. \r\n" +
        "Leave the field blank to use the current text style.",
      "Стиль для нового MText. \r\n" +
        "Оставьте поле пустым, чтоб использовать текущий стиль текстов.",
      "Stile per la creazione di nuovi MText. \r\n" +
        "Lascia vuoto il campo per utilizzare lo stile di testo corrente.",
      "Stil zum Erstellen von neuem MText. \r\n" +
        "Lassen Sie das Feld leer, um den aktuellen Textstil zu verwenden.",
      "用于创建新 MText 的样式。 \r\n" +
        "将该字段留空以使用当前文本样式。" };
    public static readonly string[] TitleTip = {
      "Write the table title (name of setting set) in the first row of table. \r\n" +
        "And set cell-style TITLE",
      "Записать заголовок таблицы (имя набора настроек) в первой строке. \r\n" +
        "Присвоить стиль ячеек НАЗВАНИЕ",
      "Scrivi il titolo della tabella (nome del set di impostazioni) nella prima riga della tabella. \r\n" +
        "E imposta lo stile cella TITLE",
      "Schreiben Sie den Tabellentitel (Name des Einstellungssatzes) in die erste Zeile der Tabelle. \r\n" +
        "Und setzen Sie TITLE im Zellenstil",
      "在表的第一行写表标题（设置集的名称）。 \r\n" +
        "并设置单元格样式的 TITLE" };
    public static readonly string[] DwgTableText = {
      "DWG Table",
      "DWG-Таблица",
      "DWG Tavolo",
      "DWG-Tabelle",
      "DWG 表" };
    public static readonly string[] CreateFileText = {
      "Create file",
      "Создание файла",
      "Crea file",
      "Erstelle Datei",
      "创建文件" };
    public static readonly string[] FillingText = {
      "Table filling",
      "Заполнение таблицы",
      "Riempimento da tavola",
      "Tischfüllung",
      "表格填充" };
    public static readonly string[] PTTText = {
      "Paste data",
      "Вставка данных",
      "Incolla",
      "Osterdatum",
      "复活节日期" };
    public static readonly string[] TextText = {
      "Text options",
      "Настройка текста",
      "Opzioni di testo",
      "Textoptionen",
      "文本选项" };
    public static readonly string[] DestinationText = {
      "Destination",
      "Назначение",
      "Destinazione",
      "Ziel",
      "目的地" };
    public static readonly string[] DirTip = {
      "The name of the folder for saving file with table. \r\n" +
        "If you leave the field blank, the dwg-drawing folder will be used.\r\n" +
        "You can use substitutions of drawing in the folder name.",
      "Имя папки для хранения файлов. \r\n" +
        "Если оставить поле пустым, то будет использована папка dwg-файла. \r\n" +
        "В имени папки можно использовать подстановки свойств файла и времени.",
      "Il nome della cartella per il salvataggio del file con la tabella. \r\n" +
        "Se si lascia il campo vuoto, verrà utilizzata la cartella dwg-drawing. \r\n" +
        "È possibile utilizzare le sostituzioni nel nome della cartella.",
      "Der Name des Ordners zum Speichern der Datei mit Tabelle. \r\n" +
        "Wenn Sie das Feld leer lassen, wird der dwg-Zeichnungsordner verwendet. \r\n" +
        "Sie können Zeichnungsersetzungen im Ordnernamen verwenden.",
      "用于保存文件的文件夹的名称。 \r\n" +
        "如果您将该字段留空，将使用 dwg-drawing 文件夹。\r\n" +
        "您可以在文件夹名称中使用图纸替换。" };
    public static readonly string[] FileTip = {
      "String for you own file name mask. \r\n" +
        "You can use substitutions of drawing and time. \r\n" +
        "Input space string for use the dwg-file name and table title.",
      "Строка для вашей собственной маски имени файла. \r\n" +
        "Вы можете использовать подстановки свойств чертежа и времени. \r\n" +
        "Оставьте поле пустым, чтоб использовать имя dwg-файла и заголовок таблицы.",
      "Stringa per la propria maschera del nome file. \r\n" +
        "È possibile utilizzare sostituzioni di disegno e tempo. \r\n" +
        "Stringa di spazio di input per utilizzare il nome dello stile come il nome del file.",
      "String für Ihre eigene Dateinamensmaske. \r\n" +
        "Sie können Substitutionen von Zeichnung und Zeit verwenden. \r\n" +
        "Geben Sie eine Leerzeichenfolge ein, um den Namen der DWG-Datei und den Tabellentitel zu verwenden.",
      "您自己的文件名掩码的字符串。 \r\n" +
        "您可以使用绘图和时间的替换。 \r\n" +
        "用于使用 dwg 文件名和表标题的输入空间字符串。" };
    public static readonly string[] HeightTip = {
      "Text size. \r\n" +
        "Set 0 for use system variable TextSize",
      "Размер шрифта. \r\n" +
        "Назначьте 0, чтоб использовать системную переменную TextSize.",
      "Dimensione del testo. \r\n" +
        "Impostare 0 per l'uso del sistema TextSize variabile",
      "Textgröße. \r\n" +
        "Legen Sie 0 fest, um die Systemvariable TextSize zu verwenden",
      "字体大小。 \r\n" +
        "设置 0 使用系统变量 TextSize" };



}
}
