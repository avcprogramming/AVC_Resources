// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Viewports

namespace AVC
{
  public static class
  DataTableL
  {
    public static readonly string[,] DTStyleNames = { 
/*0*/   { CommandL.DataTable[0],
          CommandL.DataTable[1],
          CommandL.DataTable[2],
          CommandL.DataTable[3],
          CommandL.DataTable[4] },
/*1*/   { "Bill of Material",
          "Спецификация",
          "Distinta base",
          "Stückliste",
          "物料清单" },
/*2*/   { "Object Area Table",
          "Таблица площади объектов",
          "Tabella area oggetto",
          "Objektbereichstabelle",
          "对象区域表" },
/*3*/   { "Number of blocks",
          "Количество блоков",
          "Numero di blocchi",
          "Anzahl der Blöcke",
          "块数" },
/*4*/   { "Line Length Table",
          "Таблица длин линий",
          "Tabella delle lunghezze delle linee",
          "Zeilenlängentabelle",
          "线长表" },
/*5*/   { "Sawing Table",
          "Таблица напилки",
          "Segare",
          "Sägen",
          "锯床" },
/*6*/   { "Point Coordinate Table",
          "Таблица координат точек",
          "Tabella coordinate punto",
          "Punktkoordinatentabelle",
          "点坐标表" },
      };

    public static readonly string[,] DrillTableStyleNames = {
/*0*/   { CommandL.DrillTable[0],
          CommandL.DrillTable[1],
          CommandL.DrillTable[2],
          CommandL.DrillTable[3],
          CommandL.DrillTable[4]  },

/*1*/   { CommandL.DrillTable[0],
          "Присадка",
          CommandL.DrillTable[2],
          CommandL.DrillTable[3],
          CommandL.DrillTable[4] },

/*2*/   { "Drilling",
          "Сверления",
          "Foratura",
          "Bohren",
          "钻孔" },
/*3*/   { "Drill Table to Excel",
          "Таблица сверлений в Excel",
          "Tabella di perforazione Excel",
          "Bohrtisch Excel",
          "钻取表到 Excel" },
/*4*/   { "Drill Table with countersink",
          "Таблица сверлений с зенковкой",
          "Tavolo per trapano con svasatore",
          "Bohrtisch mit Senker",
          "带埋头孔的钻台" },
      };

    public static readonly string[] DrillTableGroup = {
      "Part %name%. Drilling %drill%",
      "Поз.%name%. Сверление %drill%",
      "Dettaglio %name%. Foratura %drill%",
      "Detail %name%. Bohren %drill%",
      "部分 %name%。钻孔 %drill%"};

    public static readonly string[,] MatTableStyleNames = {
/*0*/   { "Material Table",
          "Таблица материалов",
          "Tabella dei materiali",
          "Materialtabelle",
          "材料表" },
/*1*/   { "Material Table",
          "Таблица материалов",
          "Tabella dei materiali",
          "Materialtabelle",
          "材料表"},
/*2*/   { "Material Indexes",
          "Индексы материалов",
          "Indici materiali",
          "Materialindizes",
          "材料指标"},
/*3*/   { "Cutting3 materials",
          "Cutting3 материалы",
          "Cutting3 materiali",
          "Cutting3 Material",
          "Cutting3 种材料" },
/*4*/   { "OptiCut panels",
          "OptiCut панели",
          "OptiCut pannelli",
          "OptiCut Paneele",
          "OptiCut 面板" },
/*5*/   { "OptiCut bars",
          "OptiCut бруски",
          "OptiCut barre",
          "OptiCut Riegel",
          "OptiCut 磨料" },
      };

    public static readonly string[,] SawStyleNames = {
      { CommandL.Saw[0],
        CommandL.Saw[1],
        CommandL.Saw[2],
        CommandL.Saw[3],
        CommandL.Saw[4] },
      { CommandL.Saw[0],
        CommandL.Saw[1],
        CommandL.Saw[2],
        CommandL.Saw[3],
        CommandL.Saw[4] },
      { "Detailing Table",
        "Деталировка",
        "Tabella dei dettagli",
        "Detaillierung",
        "详细表" },
      { "Rib cutting",
        "Погонажная нарезка",
        "Taglio delle costole",
        "Rippenschneiden",
        "切肋"},
      { "Nesting in Cutting3",
        "Раскрой в Cutting3",
        "Taglio nel Cutting3",
        "Schneiden in Cutting3",
        "在 Cutting3 中嵌套"},
      { "Panels for OptiCut",
        "Панели для OptiCut",
        "Pannelli per OptiCut",
        "Panels für OptiCut",
        "OptiCut 面板"},
      { "Bars for OptiCut",
        "Бруски для OptiCut",
        "Barre per OptiCut",
        "Balken für OptiCut",
        "OptiCut 棒材"},
      { "Details for Viyar",
        "Детали Вияр",
        "Dettagli per Viyar",
        "Details für Viyar",
        "Viyar 的详细信息"},
      };

    public static readonly string[] SortAZ = {
      "A-Z",
      "А-Я",
      "A-Z",
      "A-Z",
      "升序"};
    public static readonly string[] SortZA = {
      "Z-A",
      "Я-А",
      "Z-A",
      "Z-A",
      "降序排列" };
    public static readonly string[] SortSum = {
      "Sum",
      "Сумма",
      "Somma",
      "Summe",
      "求和" };
    public static readonly string[] SortSumTotal = {
      "Sum&Total",
      "Сумма+Итог",
      "Somma&Totale",
      "Summe&Total",
      "总结和结果" };

    // ===================================== Command Line =========================================
    public static readonly string[]
    Sorting = {
      "  Row sorting...",
      "  Сортировка строк...",
      "  Ordinamento di righe...",
      "  Zeilensortierung...",
      "  行排序..."};
    public static readonly string[]
    ObjCount = {
      "  Received {0} objects by {1}s",
      "  Получено {0} объектов за {1}c",
      "  Ha ricevuto {0} oggetti - {1}s",
      "  Empfangene {0} Objekte - {1}s",
      "  {1}s 收到了 {0} 个对象" };
    public static readonly string[]
    Extracting = {
      "Data extraction",
      "Извлечение данных",
      "Estrazione dei dati",
      "Datenextraktion",
      "数据提取" };
    public static readonly string[]
    Grouping = {
      "Row grouping",
      "Группировка строк",
      "Raggruppamento di righe",
      "Zeilengruppierung",
      "行分组"};
    public static readonly string[]
    Creating = {
      "Creating a table",
      "Создание таблицы",
      "Creazione di una tabella",
      "Eine Tabelle erstellen",
      "创建表"};
    public static readonly string[]
    HappenedRows = {
      "  Happened {0} rows in {1} groups",
      "  Получилось строк - {0}, групп - {1}",
      "  Si è scoperto righe - {0}, gruppi - {1}",
      "  Es sind {0} Zeilen passiert, Gruppen - {1}",
      "  {1} 组中发生了 {0} 行" };
    public static readonly string[]
    Inserted = {
      "  Inserted data rows {0}",
      "  Вставлено строк данных {0}",
      "  Le righe di dati inserite {0}",
      "  Eingefügte Datenzeilen {0}",
      "  插入的数据行 {0}" };
    public static readonly string[]
    TextLocation = {
      "Specify the insertion point for the new text.",
      "Укажите точку вставки нового текста",
      "Specificare il punto di inserimento per il nuovo testo.",
      "Geben Sie die Einfügemarke des neuen Textes an",
      "指定新文本的插入点。" };
    public static readonly string[]
    Failed = {
      "Failed to make a table.",
      "Не удалось сделать таблицу",
      "Impossibile creare una tabella.",
      "Fehler beim Erstellen einer Tabelle.",
      "无法制作表格。" };
    public static readonly string[]
    FailedToWrite = {
      "Failed to write extracted data to {0}",
      "Не удалось записать извлеченные данные в {0}",
      "Impossibile scrivere i dati estratti su {0}",
      "Extrahierte Daten konnten nicht nach {0} geschrieben werden.",
      "无法将表写入 {0}" };
    public static readonly string[]
    Multiply = {
      "Multiply the amount by ",
      "Умножить количество на ",
      "Moltiplicando questo numero per ",
      "Multipliziere die Anzahl mit ",
      "将金额乘以"};
    public static readonly string[]
    MultiplyIs = {
      "  The amount will be multiplied by {0}",
      "  Количество будет умножено на {0}",
      "  L'importo verrà moltiplicato per {0}",
      "  Der Betrag wird mit {0} multipliziert",
      "  金额将乘以 {0}"};
    public static readonly string[] SelectOptions = {
      "  Choice way of use command with set of options #{0}",
      "  Выберите действие с набором настроек №{0}",
      "  Seleziona l'azione con il numero di preselezione #{0}",
      "  Befehl zur Verwendung der Auswahl mit einer Reihe von Optionen #{0}",
      "  使用带选项集的命令的选择方式 #{0}"};
    public static readonly string[] ColumnsKW = {
      "TAbleColumns",
      "СТолбцы",
      "СOlonne",
      "Tabellenspalten",
      "表列(TA)" };
    public static readonly string[] MirrorKW = {
      "MIrror",
      "ЗЕркальные",
      "SPecchio",
      "SPiegeln",
      "镜像的(MI)" };
    public static readonly string[] GroupKW = {
      "GRoup",
      "ГРуппировка",
      "GRuppo",
      "Gruppe",
      "分组(GR)" };
    public static readonly string[] FormatKW = {
      "FOrmatOfDimension",
      "ФОрматРазмеров",
      "FOrmatoDiDimensioni",
      "FOrmatDerDimension",
      "维度格式(FO)" };
    public static readonly string[] NumberingKW = {
      "NUmbering",
      "НУмерация",
      "NUmerazione",
      "NUmmerierung",
      "编号(NU)" };
    public static readonly string[] MultiplierKW = {
      "MUltiplier",
      "Множитель",
      "MOltiplicatore",
      "Multiplikator",
      "因素(MU)" };
    public static readonly string[] AllTablesKW = {
      "allTABLES",
      "всеТАБЛИЦЫ",
      "tuttiTAVOLI",
      "alleTISCHE",
      "所有桌子(TABLES)" };
    public static readonly string[] ColumnsQuery = {
      "Enter a list of column through ;",
      "Введите подстановки для столбцов через ;",
      "Inserisci i nomi delle colonne desiderate facendo ;",
      "Geben Sie die Namen der erforderlichen Spalten durch ;",
      "通过 ; 输入列列表" };
    public static readonly string[] MirroredQuery = {
      "Lay mirrored solid separately (not group)?",
      "Выкладывать зеркальные солиды отдельно (не группировать)?",
      "Diffusione specchiata solidi separatamente (non di gruppo)?",
      "Gespiegelte Teile separat verteilen (nicht gruppieren)?",
      "单独放置镜像实体（不是组）？"};
    public static readonly string[] GroupQuery = {
      "Group the same (Lay the same parts only once and write their number in the header)?",
      "Группировать одинаковые (Выкладывать одинаковые детали только один раз и писать в заголовке их количество) ?",
      "Creare gruppi parti identiche? (verrà scritto il numero delle parti nel titolo)",
      "Gleiche gruppieren (gleiche Teile nur einmal verteilen und deren Nummer in die Kopfzeile schreiben)?",
      "分组相同（只放置一次相同的零件并在标题中写下它们的编号）？"};
    public static readonly string[] FormatQuery = {
      "Enter dimension format. 0 - digit or zero, # - digit or nothing" ,
      "Введите формат для размеров. 0 - цифра или ноль, # - цифра или ничего, . - разделитель дробной части",
      "Introduce il formato dimensione. 0 - cifre o pari a zero, # - cifre o niente",
      "Geben Sie ein Format für die Größen ein. 0 - Ziffer oder Null, # - Ziffer oder nichts, . - Bruchteilabscheider",
      "输入维度格式。 0 - 数字或零，# - 数字或无"};
    public static readonly string[] NumberingQuery = {
      "Numbering of solids",
      "Нумерация солидов",
      "Numerazione dei solidi",
      "Nummerierung der Details",
      "实体编号" };
    public static readonly string[] MultiQuery = {
      "Request multiplier every time",
      "Запрашивать множитель каждый раз",
      "Richiedere moltiplicatore ogni volta",
      "Fordern Sie jedes Mal einen Multiplikator an.",
      "每次请求乘数"  };
    public static readonly string[] NoViewport =    {
      "There are no viewports on layout {0}.",
      "Нет ни одного вьюпорта на листе {0}.",
      "Non sono presenti finestre nel layout {0}.",
      "Es gibt keine Ansichtsfenster im Layout {0}.",
      "布局 {0} 上没有视口。"    };
    public static readonly string[] NoViewportAtPoint =    {
      "No visible view or viewport found below the given point.",
      "Не найден видимый вид или вьюпорт под заданной точкой.",
      "Non è stata trovata alcuna vista o finestra visibile nel punto specificato.",
      "Unter dem angegebenen Punkt wurde keine sichtbare Ansicht oder kein sichtbares Ansichtsfenster gefunden.",
      "在指定点下未找到可见视图或视口。"    };
    public static readonly string[] ViewBorderPointQuery = {
      "Click anywhere above the ModelDoc view or viewport",
      "Кликните по любой точке над видом ModelDoc или вьюпортом",
      "Fare clic in un punto qualsiasi sopra la vista o il viewport ModelDoc",
      "Klicken Sie auf eine beliebige Stelle oberhalb der ModelDoc-Ansicht oder des Ansichtsfensters",
      "单击 ModelDoc 视图或视口上方的任意位置"  };
    public static readonly string[] TableUpdatedCount = {
      "Updated tables: {0}",
      "Обновлено таблиц: {0}",
      "Tabelle aggiornate: {0}",
      "Aktualisierte Tabellen: {0}",
      "更新的表格：{0}"};
    public static readonly string[] StyleErr = {
      "Style '{0}' not found",
      "Стиль '{0}' не найден",
      "Stile '{0}' non trovato",
      "Stil „{0}“ nicht gefunden",
      "未找到样式“{0}”" };
    public static readonly string[] TableUpdate = {
      "Updating table {0}, '{1}' style",
      "Обновление таблицы {0}, стиль “{1}”",
      "Tavolo di rifornimento {0}. Stile: '{1}'",
      "Tabelle {0} wird aufgefüllt. Stil: „{1}“",
      "重新填充表{0}。样式“{1}”" };
    public static readonly string[] ModelObjectsInfo = {
      "  The command is set to process all objects in the model. Pre-selected objects will be ignored!",
      "  Команда настроена на обработку всех объектов модели. Предварительно выбранные объекты будут проигнорированы!",
      "  Il comando è configurato per elaborare tutti gli oggetti del modello. Gli oggetti preselezionati verranno ignorati!",
      "  Der Befehl ist so konfiguriert, dass er alle Modellobjekte verarbeitet. Vorab ausgewählte Objekte werden ignoriert!",
      "  该命令配置为处理所有模型对象。预先选择的对象将被忽略！" };
    public static readonly string[] ViewportObjectsInfo = {
      "  The command is set to process all visible objects from all viewports. Pre-selected objects will be ignored!",
      "  Команда настроена на обработку всех видимых объектов из всех вьюпортов. \r\n" +
        "  Предварительно выбранные объекты будут проигнорированы!",
      "  Il comando è configurato per elaborare tutti gli oggetti visibili da tutte le finestre. \r\n" +
        "  Gli oggetti preselezionati verranno ignorati!",
      "  Der Befehl ist so konfiguriert, dass er alle sichtbaren Objekte aus allen Ansichtsfenstern verarbeitet. \r\n" +
        "  Vorab ausgewählte Objekte werden ignoriert!",
      "  该命令配置为处理所有视口中的所有可见对象。预先选择的对象将被忽略！" };
    public static readonly string[] SelectFile = {
      "Select drawings to extract data from model objects",
      "Выберите чертежи для извлечения данных из объектов модели",
      "Seleziona i disegni per estrarre i dati dagli oggetti del modello",
      "Wählen Sie Zeichnungen aus, um Daten aus Modellobjekten zu extrahieren",
      "选择图形以从模型对象中提取数据"};

    //============================= Dialog Box ===============================================

    public static readonly string[] AddColumnText = {
      "Add",
      "Добавить",
      "Inserisci",
      "Hinzufügen",
      "添加" };

    public static readonly string[] AddColumnTip = {
      "Add a column to the table. \r\n" +
        "Choose one of the substitutions from the list.",
      "Добавить колонку к таблице. \r\n" +
        "Выберите одну из подстановок из списка.",
      "Aggiungi una colonna alla tabella. \r\n" +
        "Seleziona una delle sostituzioni da inserire in una nuova colonna.",
      "Fügen Sie der Tabelle eine Spalte hinzu. \r\n" +
        "Wählen Sie eine der Vertretungen aus der Liste aus.",
      "向表中添加一列。 \r\n" +
        "从列表中选择一种替换。" };
    public static readonly string[] CopyLayText = {
      "Copy from LAY",
      "Копировать с LAY",
      "Copia da LAY",
      "Kopie von LAY",
      "从 LAY 复制" };
    public static readonly string[] CopyLayTip = {
      "Copy all settings from the current LAY style",
      "Копировать все настройки из текущего стиля Выкладки",
      "Copia tutte le impostazioni dallo stile di comando LAY corrente",
      "Alle Einstellungen aus dem aktuellen Layoutstil kopieren (LAY-Befehle)",
      "从当前布局样式复制所有设置（LAY 命令）" };
    public static readonly string[] CopySawText = {
      "Copy from SAW",
      "Копировать с SAW",
      "Copia da SAW",
      "Kopie von SAW",
      "从 SAW 复制" };
    public static readonly string[] CopySawTip = {
      "Copy all settings from the current Sawing Table style",
      "Копировать все настройки из текущего стиля Таблицы Напилки",
      "Copia tutte le impostazioni dallo stile corrente di Tabelle Sega (comando SAW)",
      "Kopieren Sie alle Einstellungen aus dem aktuellen Sägetischstil",
      "复制当前锯床样式的所有设置" };
    public static readonly string[] DelColumnText = {
      "Delete",
      "Удалить",
      "Elimina",
      "Löschen",
      "删除" };
    public static readonly string[] DelColumnTip = {
      "Delete current column",
      "Удалить текущую колонку",
      "Elimina la colonna corrente",
      "Aktuelle Spalte löschen",
      "删除当前列" };
    public static readonly string[] MoveLeftTip = {
      "Move the column to the left, to the beginning of the table.",
      "Передвинуть колонку влево, к началу таблицы.",
      "Sposta la colonna corrente a sinistra",
      "Verschieben Sie die Spalte nach links an den Anfang der Tabelle.",
      "将列向左移动到表格的开头。" };
    public static readonly string[] MoveRightTip = {
      "Move the column to the right, to the end of the table.",
      "Передвинуть колонку вправо, к концу таблицы.",
      "Sposta la colonna corrente a destra",
      "Verschieben Sie die Spalte nach rechts an das Ende der Tabelle.",
      "将列向右移动到表的末尾。" };
    public static readonly string[] HeaderText = {
      "Header",
      "Заголовок",
      "Intestazione",
      "Header",
      "标题" };
    public static readonly string[] HeaderTip = {
      "Header for column of table",
      "Заголовок для столбца таблицы",
      "Intestazione per la colonna della tabella",
      "Überschrift für Tabellenspalte",
      "表格列的标题" };
    public static readonly string[] MaskText = {
      "Data substitutions",
      "Подстановки данных",
      "Sostituzioni di dati",
      "Datenersetzungen",
      "数据替换" };
    public static readonly string[] MaskTip = {
      "Data for column of table.\r\n" +
        "String must contain substitutions of object properties.",
      "Данные для ячеек таблицы. \r\n" +
        "В строке должна быть одна или много подстановок свойств объектов.",
      "Dati per la colonna della tabella. \r\n" +
        "La stringa deve contenere sostituzioni di proprietà dell'oggetto.",
      "Daten für Spalte der Tabelle. \r\n" +
        "Zeichenfolge muss Ersetzungen von Objekteigenschaften enthalten.",
      "表格列的数据。 \r\n" +
        "字符串必须包含对象属性的替换。" };
    public static readonly string[] SortText = {
      "Sort",
      "Сортировка",
      "Ordinare",
      "Sortierung",
      "排序" };
    public static readonly string[] SortTip = {
      "A column can be sorted in ascending or descending order. \r\n" +
        "Objects with the same properties from the sorted columns \r\n" +
        "are considered the same and fall into the same row of the table. \r\n" +
        "Unsorted columns will summarize the properties of all objects that fall into this row.\r\n" +
        "For such total columns, you can calculate the total.",
      "Столбец может быть отсортирован в порядке возрастания или убывания. \r\n" +
        "Объекты с одинаковыми свойствами из отсортированных столбцов считаются одинаковыми \r\n" +
        "и попадают в одну и ту же строку таблицы. \r\n" +
        "Несортированные столбцы будут суммировать свойства всех объектов, попадающих в эту строку. \r\n" +
        "Для таких суммарных столбцов можно вычислить итог.",
      "Una colonna può essere ordinata in ordine crescente o decrescente. \r\n" +
        "Gli oggetti con le stesse proprietà delle colonne ordinate sono considerati uguali \r\n" +
        "e rientrano nella stessa riga della tabella. \r\n" +
        "Le colonne non ordinate riassumono le proprietà di tutti gli oggetti che rientrano in questa riga. \r\n" +
        "Per tali colonne totali, è possibile calcolare il totale.",
      "Eine Spalte kann aufsteigend oder absteigend sortiert werden. \r\n" +
        "Objekte mit denselben Eigenschaften aus den sortierten Spalten werden als gleich betrachtet \r\n" +
        "und fallen in dieselbe Zeile der Tabelle. \r\n" +
        "Unsortierte Spalten fassen die Eigenschaften aller Objekte zusammen, die in diese Zeile fallen. \r\n" +
        "Für solche Summenspalten können Sie die Summe berechnen.",
      "列可以按升序或降序排序。 \r\n" +
        "排序列中具有相同属性的对象被认为是相同的并且属于表的同一行。 \r\n" +
        "未排序的列将汇总所有落入该行的对象的属性。\r\n" +
        "对于此类总计列，您可以计算总计。" };
    public static readonly string[] GroupText = {
      "Group",
      "Группа",
      "Gruppo",
      "Gruppe",
      "团体" };
    public static readonly string[] GroupTip = {
      "Substitution for group headings. \r\n" +
        "If you do not need any grouping, then leave the field blank.",
      "Подстановки для заголовка групп данных в таблице. \r\n" +
        "Оставьте строку пустой, если не нужна никакая группировка.",
      "Sostituzione delle intestazioni di gruppo. \r\n" +
        "Se non è necessario alcun raggruppamento, lasciare il campo vuoto.",
      "Ersatz für Gruppenüberschriften.\r\n" +
        " Wenn Sie keine Gruppierung benötigen, lassen Sie das Feld leer.",
      "替换组标题。 \r\n" +
        "如果您不需要任何分组，则将该字段留空。" };
    public static readonly string[] StyleNameTip = {
      "Name of Data Table style. \r\n" +
        "Can be used like title of table. \r\n" +
        "The title may contain substitutions from the properties of the drawing or time.",
      "Имя стиля Таблицы данных. \r\n" +
        "Можно использовать как заголовок таблицы. \r\n" +
        "В заголовке можно использовать подстановки свойств чертежа и времени.",
      "Nome dello stile della tabella dei dati. \r\n" +
        "Può essere usato come il titolo della tabella. \r\n" +
        "Il titolo può contenere sostituzioni dalle proprietà del disegno o del tempo.",
      "Name des Datentabellenstils. \r\n" +
        "Kann als Tabellentitel verwendet werden. \r\n" +
        "Der Titel kann Ersetzungen aus den Eigenschaften der Zeichnung oder Zeit enthalten.",
      "数据表样式的名称。 \r\n" +
        "可以用作表格的标题。 \r\n" +
        "标题可能包含来自绘图或时间属性的替换。" };
    public static readonly string[] Source = {
      "Data Source",
      "Источник данных",
      "Fonte di dati",
      "Datenquelle",
      "資料來源"};
    public static readonly string[] Select = {
      "Select objects",
      "Выбрать объекты",
      "Seleziona oggetti",
      "Wählen Sie Objekte aus",
      "選擇對象"};
    public static readonly string[] SelectTip = {
      "Specify drawing objects from which information for the table will be retrieved.",
      "Указать объекты чертежа, из которых будет извлекаться информация для таблицы.",
      "Specificare gli oggetti della Carta da cui verranno recuperate le informazioni per la tabella.",
      "Geben Sie Zeichnungsobjekte an, aus denen Informationen für die Tabelle abgerufen werden.",
      "指定將從中檢索表格資訊的圖形物件。"};
    public static readonly string[] SelectView = {
      "Select view or viewport",
      "Выбрать вид или вьюпорт",
      "Seleziona vista o viewport",
      "Ansicht oder Ansichtsfenster auswählen",
      "选择视图或视口"};
    public static readonly string[] SelectViewTip = {
      "Process all objects that are visible in one view ModelDoc=ViewBase or in one viewport. \r\n" +
        "When called from the model - request a selection of objects.",
      "Обрабатывать все объекты, которые видны на одном виде ModelDoc=ВидБаз или в одном вьюпорте. \r\n" +
        "При вызове из модели - запросить выбор объектов.",
      "Elabora tutti gli oggetti visibili in una vista ModelDoc=ViewBase o in una finestra. \r\n" +
        "Quando viene chiamato da un modello, richiede una selezione di oggetti.",
      "Verarbeiten Sie alle Objekte, die in einer ModelDoc=ViewBase-Ansicht oder in einem Ansichtsfenster sichtbar sind. \r\n" +
        "Fordern Sie beim Aufruf von einem Modell eine Auswahl von Objekten an.",
      "处理在一个 ModelDoc=ViewBase 视图或一个视口中可见的所有对象。\r\n" +
        "当从模型调用时，请求选择对象。"};
    public static readonly string[] Model = {
      "All model objects",
      "Все объекты модели",
      "Tutti gli oggetti del modello",
      "Alle Modellobjekte",
      "所有模型對象"};
    public static readonly string[] ModelTip = {
      "Extract data from all model objects that match the filtering conditions.",
      "Извлечь данные из всех объектов модели, которые подходят под условия фильтрации.",
      "Estrai i dati da tutti gli oggetti del modello che corrispondono alle condizioni di filtro.",
      "Extrahieren Sie Daten aus allen Modellobjekten, die den Filterbedingungen entsprechen.",
      "從所有符合篩選條件的模型物件中擷取資料。"};
    public static readonly string[] Viewports = {
      "Layout Viewports",
      "Вьюпорты листа",
      "Viste di layout",
      "Layout-Ansichtsfenster",
      "佈局視窗"};
    public static readonly string[] ViewportsTip = {
      "Extract data into a table from all objects that are at least slightly visible in any viewport of the current sheet. \r\n" +
        "When called from a model, all model objects.",
      "Извлечь данные в таблицу из всех объектов, которые хоть немного видны в любом вьюпорте текущего листа. \r\n" +
        "При вызове из модели - все объекты модели.",
      "Estrai i dati in una tabella da tutti gli oggetti che sono almeno leggermente visibili in qualsiasi finestra \r\n" +
        "del foglio corrente. Quando chiamati da un modello, tutti gli oggetti del modello.",
      "Extrahieren Sie Daten aus allen Objekten, die in einem beliebigen Ansichtsfenster des aktuellen Blatts zumindest \r\n" +
        "leicht sichtbar sind, in eine Tabelle. Bei Aufruf aus einem Modell alle Modellobjekte.",
      "从当前工作表的任何视口中至少稍微可见的所有对象中将数据提取到表中。\r\n" +
        "当从模型调用时，所有模型对象。"};
    public static readonly string[] Files = {
      "DWG Files",
      "DWG-Файлы",
      "File DWG",
      "DWG-Dateien",
      "DWG 文件"};
    public static readonly string[] FilesTip = {
      "Extract data into a table from all objects of all models from multiple drawings. \r\n" +
        "The program will prompt you to select DWG or DXF files.",
      "Извлечь данные в таблицу из всех объектов всех моделей из нескольких чертежей. \r\n" +
        "Программа предложит выбрать DWG или DXF файлы.",
      "Estrai i dati in una tabella da tutti gli oggetti di tutti i modelli da più disegni. \r\n" +
        "Il programma ti chiederà di selezionare file DWG o DXF.",
      "Extrahieren Sie Daten aus allen Objekten aller Modelle aus mehreren Zeichnungen in eine Tabelle. \r\n" +
        "Das Programm fordert Sie auf, DWG- oder DXF-Dateien auszuwählen.",
      "将多个图纸中所有模型的所有对象的数据提取到表中。\r\n" +
        "程序将提示您选择 DWG 或 DXF 文件。"};


  }
}
