// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

using System.Collections.Generic;

namespace AVC
{
  public static class
  PageNoL
  {
    public static readonly HashSet<string> PageNoAttributes = new() {
      "SHEET", "SHEETNO", "PAGE",
      "ЛИСТ", "PAGENO","ЛИСТНОМЕР",
      "PAGINA", "FOGLIO", "NUMERODIFOGLIO",
      "SEITE", "LISTE", "BLATTNUMMER",
      "页", "页码" };
    public static readonly HashSet<string> PageCountAttributes = new() {
      "SHEETCOUNT","PAGECOUNT","PAGES","OF",
      "КОЛИЧЕСТВОЛИСТОВ","ЛИСТОВ","ИЗ",
      "SCHEDADILAVORO","PAGINACOUNT","SCHEDE","DALLA",
      "BLATTZÄHLUNG","SEITEN","VON",
      "页数"};
    public static readonly HashSet<string> PageNameAttributes = new() {
      "TITLE", "SHEETNAME", "SHEETTITLE", "PAGENAME", "DRAWING", "DRAWINGNAME", "NAME",
      "ЗАГОЛОВОК", "НАИМЕНОВАНИЕЛИСТА", "ЧЕРТЕЖ", "ЧЕРТЁЖ", "НАИМЕНОВАНИЕ", "НАЗВАНИЕ", "ЧАСТЬ_СТЕНДА",
      "TESTATA", "NOMEDELFOGLIO", "NOMEDELLOSCHEDA", "NOME",
      "TITEL", "BLATTNAME", "BLATTTITEL", "SEITENNAME", "ZEICHNUNGSNAME",
      "标题", "姓名" };
    public static readonly HashSet<string> ScaleAttributes = new () {
      "SCALE", "SCALING", "RATIO",
      "МАСШТАБ",
      "SCALA", "SCALATURA", "RAPPORTO",
      "SKALA", "MAßSTAB", "VERHÄLTNIS",
      "规模", "比例", "缩放", "比率"};
    public static readonly string[] Numbering ={
      "Layout numbering",
      "Нумерация листов",
      "Numerazione del layout",
      "Layoutnummerierung",
      "布局编号"};
    public static readonly string[] NoBlock = {
      "Layout {0} hasn't block for numbering" ,
      "Лист {0} не имеет блока для нумерации",
      "Layout {0} non ha blocco per la numerazione",
      "Layout {0} hat keinen Block für die Nummerierung",
      "布局 {0} 没有阻止编号"};
    public static readonly string[] NoLayout ={
      "None of the layout has block for numbering. The program will look for the blocks in model space.",
      "Ни один лист (layout) не имеет блоков для нумерации. Программа будет искать блоки в пространстве модели.",
      "Nessuno dei layout ha blocco per la numerazione. Il programma cercherà i blocchi nello spazio modello.",
      "Keines der Layouts hat einen Block zur Nummerierung. Das Programm sucht nach den Blöcken im Modellraum.",
      "所有布局都没有编号块。 该程序将在模型空间中寻找块。"};
    public static readonly string[] Copied = {
      "Table of contents copied to clipboard",
      "Оглавление скопировано в буфер",
      "Sommario copiato negli appunti",
      "Inhaltsverzeichnis in die Zwischenablage kopiert",
      "目录已复制到剪贴板" };
    public static readonly string[] NoModelBlock = {
      "None of model-space block has attribute for numbering",
      "Ни один блок из пространства модели не имеет атрибутов для нумерации",
      "Nessuno dei blocchi modello-spazio ha l'attributo per la numerazione",
      "Keiner der Model-Space-Block hat Attribut für die Nummerierung",
      "模型空间块都没有编号属性" };
    public static readonly string[] Content = {
      "Table of contents\n",
      "Содержание\n",
      "Sommario\n",
      "Inhaltsverzeichnis\n",
      "目录\n" };
    public static readonly string[] PageName = {
      "Page\tName\n",
      "Лист\tНаименование\n",
      "Pagina\tNome\n",
      "Seite\tName\n",
      "页面\t名称\n" };
    public static readonly string[] ClipboardErr = {
      "Error while working with the clipboard",
      "Ошибка при работе с буфером обмена",
      "Errore durante il lavoro con gli appunti",
      "Fehler beim Arbeiten mit der Zwischenablage",
      "使用剪贴板时出错" };

    // ================================ Settings Dialog ===================================================

    public static readonly string[] StartTip = {
      "Number for first page",
      "Номер для первой страницы",
      "Numero primo foglio",
      "Nummer für die erste Seite",
      "第一页的编号" };
    public static readonly string[] PageCountText = {
      "Count attribute",
      "Атрибут количества",
      "Attributo quantità",
      "Attribut zählen",
      "页数属性" };
    public static readonly string[] PageNameText = {
      "Title attribute",
      "Атрибут названия",
      "Attributo titolo",
      "Titel Attribut",
      "标题属性" };
    public static readonly string[] NumberText = {
      "Number attribute",
      "Атрибут номера",
      "Attributo numero",
      "Attribut Seitenzahl",
      "页码属性" };
    public static readonly string[] StartText = {
      "Start from",
      "Старт с",
      "Inizia da",
      "Beginne von",
      "从...开始" };
    public static readonly string[] NumberTip = {
      "Tag of attribute with number of sheet.\r\n" +
        "Set space for using default tags\r\n" +
        "(PageNo or SheetNo or Page or Sheet)",
      "Тег атрибута, в который будет записан номер листа.\r\n" +
        "Оставьте поле пустым, чтоб использовать атрибут по-умолчанию \r\n" +
        "(Лист или ЛистНомер)",
      "Un tag di attributo su cui verrà scritto il numero del foglio.\r\n" +
        "Lascia vuoto per utilizzare l'attributo predefinito\r\n" +
        "(PAGINA o FOGLIO o NUMERODIFOGLIO)",
      "Tag des Attributs mit Blattnummer.\r\n" +
         "Platz für die Verwendung von Standard-Tags festlegen\r\n" +
         "(SEITE oder LISTE oder BLATTNUMMER)",
      "带有页数的属性标签。\r\n" +
         "设置使用默认标签的空间\r\n" +
         "PageNo 或 Page 或 页 或 页码）" };
    public static readonly string[] PageCountTip = {
      "Tag of attribute for sheet count.\r\n" +
        "Set space for using default tags\r\n" +
        "(PageCount or SheetCount or Pages or From)",
      "Тег атрибута, в который будет записано общее количество листов.\r\n" +
        "Оставьте поле пустым, чтоб использовать атрибут по-умолчанию\r\n" +
        "(Листов или КоличествоЛистов или Из)",
      "Un tag di attributo su cui verrà scritto il numero totale di fogli.\r\n" +
        "Lascia vuoto per utilizzare l'attributo predefinito\r\n" +
        "(SCHEDADILAVORO o PAGINACOUNT o SCHEDE o DALLA)",
      "Tag des Attributs für die Blattanzahl.\r\n" +
         "Platz für die Verwendung von Standard-Tags festlegen\r\n" +
         "(BLATTZÄHLUNG oder SEITEN oder VON)",
      "页数属性标签。\r\n" +
         "设置使用默认标签的空间\r\n" +
         "(PageCount 或 页数)" };
    public static readonly string[] PageNameTip = {
      "Tag of attribute with sheet name for table of contents.\r\n" +
        "Set space for using default tags\r\n" +
        "(Title or Name or SheetName or SheetTitle or DrawingName)",
      "Тег атрибута, из которого будет извлечено название чертежа для оглавления.\r\n" +
        "Оставьте поле пустым, чтоб использовать атрибут по-умолчанию\r\n" +
        "(Чертеж или НаименованиеЛиста или Заголовок или Наименование или Название)",
      "Tag di attributo da cui estrarre il titolo del disegno per il sommario.\r\n" +
        "Lascia vuoto per utilizzare l'attributo predefinito\r\n" +
        "(TESTATA o NOMEDELFOGLIO o NOMEDELLOSCHEDA o NOME)",
      "Tag des Attributs mit dem Blattnamen für das Inhaltsverzeichnis.\r\n" +
         "Platz für die Verwendung von Standard-Tags festlegen \r\n" +
        "(TITEL oder BLATTNAME oder BLATTTITEL oder SEITENNAME oder ZEICHNUNGSNAME)",
      "带有目录工作表名称的属性标记。\r\n" +
        "设置使用默认标签的空间\r\n" +
        "(Title or Name or 标题 or 姓名)" };

    public static readonly string[] PasteTablePartText = {
      "Table of Contents settings",
      "Настройки таблицы оглавления",
      "Impostazioni del sommario",
      "Inhaltsverzeichnis Einstellungen",
      "目录设置" };
    public static readonly string[] StartNoQuery = {
      "Enter the number for the first page",
      "Введите номер для первой страницы",
      "Inserisci il numero per la prima pagina",
      "Geben Sie die Nummer für die erste Seite ein",
      "输入第一页的编号" };

    public static string[] StartQuery = {
      "Request number",
      "Запрашивать номер",
      "Richiedi il numero",
      "Fordern Sie eine Nummer an.",
      "请求第一页的编号" };
    public static string[] StartQueryTip = {
      "Request the starting number each time the command is called. \r\n" +
        "Useful if you always have different starting numbers.",
      "При каждом вызове команды запрашивать стартовый номер. \r\n" +
        "Полезно, если у вас всегда разные стартовые номера.",
      "Richiedi il numero iniziale ogni volta che viene chiamato il comando. \r\n" +
        "Utile se hai sempre numeri iniziali diversi.",
      "Fordern Sie die Startnummer jedes Mal an, wenn der Befehl aufgerufen wird. \r\n" +
        "Nützlich, wenn Sie immer unterschiedliche Startnummern haben.",
      "每次调用命令时请求起始编号。 如果您总是有不同的起始编号，这很有用。" };
    public static readonly string[] AllBlocks = {
      "Fill in all the blocks of the sheet",
      "Заполнять все блоки листа",
      "Compila tutti i blocchi del layout",
      "Füllen Sie alle Blöcke des Layouts aus",
      "填写布局的所有块" };
    public static readonly string[] AllBlocksTip = {
      "Search for and fill all blocks on the sheet. \r\n" +
        "If the option is disabled, the program will stop working with the sheet \r\n" +
        "as soon as it finds one block with the PageNumber attribute. \r\n" +
        "The option only works in layouts.",
      "Искать и заполнять все блоки на листе. \r\n" +
        "Если опция отключена, то программа перестанет работать с листом, \r\n"+
        "как только найдет один блок с атрибутом номера листа.\r\n" +
        "Опция работает только на листах (layout)",
      "Cerca e compila tutti i blocchi del layout. \r\n" +
        "Se l'opzione è disabilitata, il programma smetterà di lavorare con il layout \r\n" +
        "non appena trova un blocco con l'attributo PageNumber. \r\n" +
        "L'opzione funziona solo nei layout.",
      "Suchen und füllen Sie alle Blöcke des Layouts aus. \r\n" +
        "Wenn die Option deaktiviert ist, hört das Programm auf, mit dem Layout zu arbeiten, \r\n" +
        "sobald es einen Block mit dem Attribut Seitenzahl findet. \r\n" +
        "Die Option funktioniert nur in Layouts.",
      "在工作表上搜索并填写所有块。 \r\n" +
        "如果禁用此选项，则程序将在找到一个带有 PageNumber 属性的块后停止处理工作表。 \r\n" +
        "此选项仅适用于布局。" };
    public static readonly string[] AllAttributes = {
      "Fill all block attributes",
      "Заполнять все атрибуты блока",
      "Compila tutti gli attributi del blocco",
      "Füllen Sie alle Attribute des Blocks aus",
      "填写块的所有属性" };
    public static readonly string[] AllAttributesTip = {
      "Search for all attributes of the same name (tag) in the block, rather than stopping at the first one that comes up. \r\n" +
        "The option only works in blocks on layout",
      "Искать в блоке все одноименные атрибуты, а не останавливаться на первом попавшемся. \r\n" +
        "Опция работает только в блоках на листах (layout)",
      "Cerca tutti gli attributi con lo stesso nome nel blocco, invece di fermarsi al primo trovato. \r\n" +
        "L'opzione funziona solo nei blocchi dei layout",
      "Suchen Sie im Block nach allen gleichnamigen Attributen, anstatt beim ersten gefundenen zu stoppen. \r\n" +
        "Die Option funktioniert nur in Blöcken auf Layouts",
      "在块中查找所有同名属性，而不是在第一个找到的属性上停止。 \r\n" +
        "此选项仅适用于布局中的块" };
    public static readonly string[] LayoutRename = {
      "Rename layout",
      "Переименовать вкладку листа",
      "Rinomina il layout",
      "Layout umbenennen",
      "重命名布局" };
    public static readonly string[] LayoutRenameTip = {
      "Take the drawing name from the PageName block attribute and rename the layout tab.",
      "Взять имя чертежа из атрибута блока и переименовать вкладку листа (layout).",
      "Prendi il nome del disegno dall'attributo del blocco e rinomina la scheda del layout.",
      "Nehmen Sie den Namen der Zeichnung aus dem Attribut des Blocks und benennen Sie die Layout-Registerkarte um.",
      "从块属性中获取图纸名称并重命名布局选项卡。" };
    public static readonly string[] LayoutNumbering = {
      "Layout Tab Numbering",
      "Нумерация вкладок листов",
      "Numerazione del layout",
      "Layoutnummerierung",
      "工作表标签编号" };
    public static readonly string[] LayoutNumberingTip = {
      "Numbering layout tabs with the number of the sheet.",
      "Нумеровать вкладки листов (layout) по порядку их расположения",
      "Numerare le schede dei layout in base all'ordine in cui sono posizionate",
      "Nummerieren Sie die Layout-Tabs in der Reihenfolge, in der sie angeordnet sind",
      "按其位置顺序对布局选项卡进行编号" };
    public static readonly string[] SaveLayoutName = {
      "Keep old layout name when numbering",
      "Сохранять старое имя при нумерации",
      "Salva il nome del layout",
      "Layoutnamen speichern",
      "编号时保留旧图纸名称" };
    public static readonly string[] SaveLayoutNameTip = {
      "When numbering layout tabs, program should write the number at the end of the old tab name.\r\n" +
        "If there is a number at the end of the name, it will be replaced with the layout number.",
      "При нумерации вкладок листов следует записывать номер в конец старого имени вкладки. \r\n" +
        "При этом, если в конце имени найдется цифра, то она будет заменена на номер листа.",
      "Durante la numerazione delle schede dei layout, il numero deve essere scritto alla fine del vecchio nome della scheda. \r\n" +
        "In questo caso, se alla fine del nome viene trovato un numero, esso verrà sostituito con il numero del foglio.",
      "Beim Nummerieren der Layout-Tabs sollte die Nummer an das Ende des alten Tab-Namens geschrieben werden. \r\n" +
        "In diesem Fall wird, wenn am Ende des Namens eine Zahl gefunden wird, diese durch die Blattnummer ersetzt.",
      "在对布局选项卡进行编号时，应将编号写在旧选项卡名称的末尾。 \r\n" +
        "在这种情况下，如果在名称末尾找到数字，则将其替换为页数。" };
    public static readonly string[] ContentsList = {
      "Create Table of Contents",
      "Создать Оглавление",
      "Elenco sommario",
      "Inhaltsverzeichnis",
      "目录列表" };
    public static readonly string[] ContentsListTip = {
      "Create a list of page numbers and sheet names and paste them into the clipboard or table of contents.",
      "Создать список номеров страниц и наименований листов и вставить в буфере обмена или в таблицу оглавления.",
      "Crea un elenco di numeri di pagina e nomi di fogli e li inserisce negli appunti o nella tabella dei contenuti.",
      "Erstellt eine Liste von Seitennummern und Blattnamen \r\n" +
        "und fügt sie in die Zwischenablage oder in das Inhaltsverzeichnis ein.",
      "创建页码和工作表名称列表，并将其插入到剪贴板或目录表中。" };
    public static readonly string[] OtherAttributes = {
      "Other attributes",
      "Другие атрибуты",
      "Altri attributi",
      "Andere Attribute",
      "其他属性" };
    public static readonly string[] OtherAttributesTip = {
      "List of attributes to fill. \r\n" +
        "Each line of the list must contain a tag (name) of the attribute, the = sign and the attribute value. \r\n" +
        "Fields that refer to drawing properties can be specified as the attribute value. \r\n" +
        "The program will fill both variable and constant attributes. \r\n" +
        "Only blocks that have a page number attribute are processed.",
      "Список атрибутов для заполнения. \r\n" +
        "В каждой строке списка должен быть тег (имя) атрибута, знак = и значение атрибута. \r\n" +
        "В качестве значения атрибута можно указывать поля, ссылающиеся на свойства чертежа. \r\n" +
        "Программа заполнит как переменные, так и константные атрибуты. \r\n" +
        "Обрабатываются только блоки, у которых найден атрибут номера страницы.",
      "Elenco degli attributi da compilare. \r\n" + 
        "In ogni riga dell'elenco deve essere presente un tag (nome) dell'attributo, il segno = e il valore dell'attributo. \r\n" +
        "Come valore dell'attributo è possibile specificare i campi che fanno riferimento alle proprietà del disegno. \r\n" +
        "Il programma compilerà sia gli attributi variabili che quelli costanti. \r\n" +
        "Solo i blocchi con l'attributo PageNumber vengono elaborati.",
      "Liste der Attribute zum Ausfüllen. \r\n" +
        "In jeder Zeile der Liste muss ein Tag (Name) des Attributs, das Zeichen = und der Wert des Attributs vorhanden sein. \r\n" +
        "Als Attributwert können Felder angegeben werden, die auf die Eigenschaften der Zeichnung verweisen. \r\n" +
        "Das Programm füllt sowohl variable als auch konstante Attribute aus. \r\n" +
        "Es werden nur Blöcke verarbeitet, bei denen das Attribut Seitenzahl gefunden wurde.",
      "要填写的属性列表。 \r\n" +
        "列表中的每一行都必须有一个标签（属性名称）、等号和属性值。 \r\n" +
        "属性值可以是引用图纸属性的字段。 \r\n" +
        "程序将填写变量和常量属性。 \r\n" +
        "仅处理找到页码属性的块。" };
    public static readonly string[] DetermineScale = {
      "Determine and write the scale",
      "Определить и записать масштаб",
      "Determina e scrivi scala",
      "Skala bestimmen und schreiben",
      "确定并写入比例" };
    public static readonly string[] DetermineScaleTip = {
      "Define the scale of the drawing and write it to the Scale attribute. \r\n" +
        "The program will find all viewports and ModelDoc views on the sheet and take the minimum scale. \r\n" +
        "Thus, enlarged detail views will be ignored. \r\n" +
        "The option works only on sheets (layout).",
      "Определить масштаб чертежа и записать его в атрибут Масштаб. \r\n" +
        "Программа найдет все вьюпорты и виды ModelDoc на листе и возьмет минимальный масштаб. \r\n" +
        "Таким образом увеличенные выносные виды будут проигнорированы. \r\n" +
        "Опция работает только на листах (layout).",
      "Definisci la scala del disegno e scrivila nell'attributo Scala. \r\n" +
        "Il programma troverà tutte le finestre di visualizzazione e le viste ModelDoc sul layout e prenderà la scala minima. \r\n" +
        "In questo modo verranno ignorate le viste dei dettagli ingrandite. \r\n" +
        "L'opzione funziona solo nei layout.",
      "Bestimmen Sie die Skala der Zeichnung und schreiben Sie sie in das Attribut Skala. \r\n" +
        "Das Programm findet alle Ansichtsfenster und ModelDoc-Ansichten auf dem Layout und nimmt die kleinste Skala. \r\n" +
        "So werden vergrößerte Detailansichten ignoriert. \r\n" +
        "Die Option funktioniert nur auf Layouts.",
      "定义图纸的比例并将其写入 Scale 属性。 \r\n" +
        "程序将在工作表上找到所有视口和 ModelDoc 视图，并采用最小比例。 \r\n" +
        "因此，将忽略放大的细节视图。 \r\n" +
        "此选项仅适用于工作表（布局）。" };
    public static readonly string[] ScaleAttr = {
      "Scale attribute",
      "Атрибут масштаба",
      "Attributo scala",
      "Skala Attribut",
      "比例属性" };
    public static readonly string[] ScaleAttrTip =
    {
      "Tag of attribute with scale of sheet. \r\n" +
        "Set space for using default tags\r\n" +
        "(Scale or Ratio)",
      "Тег атрибута, в который будет записан масштаб листа. \r\n" +
        "Оставьте поле пустым, чтоб использовать атрибут по-умолчанию\r\n" +
        "(Масштаб или Scale)",
      "Tag di attributo su cui verrà scritto il numero della scala del foglio. \r\n" +
        "Lascia vuoto per utilizzare l'attributo predefinito\r\n" +
        "(SCALA o RAPPORTO)",
      "Tag des Attributs mit dem Maßstab des Blattes.\r\n" +
         "Platz für die Verwendung von Standard-Tags festlegen\r\n" +
         "(SKALA oder VERHÄLTNIS)",
      "带有工作表比例的属性标签。\r\n" +
         "设置使用默认标签的空间\r\n" +
         "(Scale 或 比例)"
    };
  }
}
