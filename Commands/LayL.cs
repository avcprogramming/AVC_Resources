// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация команды LAY
  /// </summary>
  public static class LayL
  {
    public static readonly string[,] LayStyleNames = {
/* 0 */ {
        CommandL.Lay[0],
        CommandL.Lay[1],
        CommandL.Lay[2],
        CommandL.Lay[3],
        CommandL.Lay[4] },
/* 1 */ {
        CommandL.Lay[0],
        CommandL.Lay[1],
        CommandL.Lay[2],
        CommandL.Lay[3],
        CommandL.Lay[4]},
/* 2 */ {
        "Export",
        "Экспорт",
        "Esportare",
        "Export",
        "输出" },
    };

    public static readonly string[] Select = {
      "  Select assembly consisting of 3DSolid",
      "  Выберите сборку из деталей типа 3DSolid",
      "  Selezionare l’assemblaggio costituito da 3DSolidi",
      "  Wählen Sie eine Baugruppe aus Teilen vom Typ 3DSolid aus",
      "  选择装配体或三维实体"};
    public static readonly string[] Point = {
      "  Specify the coordinates to insert laid solids",
      "  Укажите координаты, где начинать выкладку деталей",
      "  Specificare coordinate di inserimento lista pezzi",
      "  Geben Sie die Koordinaten an, an denen die Berechnung der Teile beginnen soll",
      "  指定插入点" };
    public static readonly string[] StyleSelected = {
      "  LAY-style '{0}' selected",
      "  Выбран стиль выкладки '{0}'",
      "  LAY-Stile '{0}' selezionato",
      "  LAY-Stil '{0}' ausgewählt",
      "  平铺样式 '{0}' 选择"};
    public static readonly string[] StepQuery ={
      "Input step between details",
      "Введите шаг между выложенными деталями",
      "Inserire la distanza tra le parti disposte",
      "Geben Sie den Schritt zwischen den Teilen ein",
      "输入图形间距"};
    public static readonly string[] MirroredQuery ={
      "Lay mirrored solid separately (not group)?",
      "Выкладывать зеркальные солиды отдельно (не группировать)?",
      "Diffusione specchiata solidi separatamente (non di gruppo)?",
      "Gespiegelte Teile separat verteilen (nicht gruppieren)?",
      "镜像图形单独放置"};
    public static readonly string[] MergeSameDataQuery ={
      "Group the same (Lay the same parts only once and write their number in the header)?",
      "Группировать одинаковые (Выкладывать одинаковые детали только один раз и писать в заголовке их количество) ?",
      "Creare gruppi parti identiche? (verrà scritto il numero delle parti nel titolo)",
      "Gleiche gruppieren (gleiche Teile nur einmal verteilen und deren Nummer in die Kopfzeile schreiben)?",
      "合并相同对象,文字相应合并."};
    public static readonly string[] FlatShotQuery = {
      "Make FlatShot?",
      "Делать плоские контуры ?",
      "Creare geometrie piatte?",
      "Flache Konturen machen?",
      "生成二维图形?" };
    public static readonly string[] TitleQuery ={
      "Title template. Default '?'. Use parameters inside %",
      "Введите шаблон заголовка или пустую строку. Используйте подстановки в символах '%' ",
      "Modello di titolo predefinito?  Inserire modello di intestazione o una stringa vuota ‘%’ ",
      "Geben Sie eine Titelvorlage oder eine leere Zeile ein. Verwenden Sie Platzhalter in den Zeichen '%'",
      "文字模板. 默认 '?'. 在%中使用参数"};
    public static readonly string[] DefaultTitle = {
      "Default title saved",
      "Будет использован заголовок по умолчанию",
      "Intestazione predefinita salvata",
      "Будет использован заголовок по умолчанию",
      "默认文本已保存" };
    public static readonly string[] CenterQuery ={
      "Align title to the center of detail",
      "Выравнивать заголовок по центру детали",
      "Allinea descrizione al centro della geometria",
      "Zentrieren Sie den Titel des Teils",
      "将文字与图形中心对齐"};
    public static readonly string[] InsideQuery ={
      "Place the title inside a detail",
      "Располагать заголовок внутри детали",
      "Posiziona descrizione all’interno della geometria",
      "Positionieren Sie den Header im Innenteil",
      "将文字放在详细信息中"};
    public static readonly string[] HeightQuery ={
      "Title text height. 0 - use _TEXTSIZE variable",
      "Высота текста заголовка. 0 - использовать переменную _TEXTSIZE",
      "Altezza del testo. 0 – Utilizzare la variabile _TEXTSIZE",
      "Die Höhe des Titeltextes. 0 - Verwenden Sie die Variable _TEXTSIZE",
      "文字高度。 0 - 使用 _TEXTSIZE 变量字高"};
    public static readonly string[] StyleQuery = {
      "Title text style",
      "Стиль текста заголовка",
      "Stile testo della descrizione",
      "Kopfzeilentextstil",
      "文字样式" };
    public static readonly string[] StyleInfo ={
      "Current style will use '{0}'",
      "Будет использован текущий стиль '{0}'",
      "Utilizza stile corrente ‘{0}’",
      "Verwendet den aktuellen Stil '{0}'",
      "当前样式'{0}'"};
    public static readonly string[] TextureQuery = {
      "Write mark of texture",
      "Помечать текстуру",
      "Scrivere texture",
      "Schreiben Sie eine Markierung der Textur",
      "纹理标记" };
    public static readonly string[] NumberingQuery = {
      "Numbering of solids",
      "Нумерация солидов",
      "Numerazione dei solidi",
      "Nummerierung der Details",
      "编号" };
    public static readonly string[] MultiplierQuery = {
      "Request multiplier every time",
      "Запрашивать множитель каждый раз",
      "Richiedere moltiplicatore ogni volta",
      "Fordern Sie jedes Mal einen Multiplikator an.",
      "对象倍数" };

    //------------- Command Line --------------------------------------------
    public static readonly string[] StepKW = { "Step", "Шаг", "PAsso", "SCHritt" };
    public static readonly string[] MirrorKW = { "MIrror", "ЗЕркальные", "SPecchio", "SPiegeln" };
    public static readonly string[] MergeKW = { "GRoup", "ГРуппировка", "GRuppo", "Gruppe" };
    public static readonly string[] FlatShotKW = { "FLatShot", "ПЛоскийСлепок", "GEomPiatta", "Flachguss" };
    public static readonly string[] TitleKW = { "TItle", "ЗАголовок", "TItolo", "TItel" };
    public static readonly string[] StyleKW = { "STYle", "СТиль", "STile", "STil" };
    public static readonly string[] HeightKW = { "HEight", "ВЫсота", "ALTezza", "Höhe" };
    public static readonly string[] CenterKW = { "CEnter", "ЦЕнтрировать", "CEntro", "Zentrum" };
    public static readonly string[] InsideKW = { "INside", "ВНутри", "INterno", "Innerhalb" };
    public static readonly string[] TextureKW = { "TExture", "ТЕкстура", "TExture", "TExtur" };
    public static readonly string[] NumberingKW = { "NUmbering", "НУмерация", "NUmerazione", "NUmmerierung" };
    public static readonly string[] MultiplierKW = { "MUltiplier", "Множитель", "MOltiplicatore", "Multiplikator" };

    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

    // ==================================== Options Dialog Box ===============================================

    public static readonly string[] DialogTitle = {
      "LAY options",
      "Настройки выкладки",
      "Opzioni di LAY",
      "LAY-optionen",
      "平铺 设置选项"};
    public static readonly string[] StyleNameTip = {
      "The name for this lay-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля выкладки. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile lay (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Lay-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此平铺样式名称作为备注使用，程序中使用前面的序号。"};
    public static readonly string[] Grouping = {
      "Grouping",
      "Группировка",
      "Raggruppamento",
      "Gruppierung",
      "分组设置"}; // 组
    public static readonly string[] GroupingTip = {
      "Grouping parts into separate columns.\r\n"+
        "Insert into the list of substitutions, when changing which\r\n"+
        "you want to create a separate column of parts.\r\n"+
        "If you do not need any grouping, then leave the field blank.",
      "Группирование деталей в отдельные столбики.\r\n" +
        "Вставьте в список подстановки, при изменении которых надо создавать отдельный столбик деталей.\r\n" +
        "Если группировка не нужна, то оставьте поле пустым.",
      "Raggruppamento di parti in colonne separate.\r\n" +
        "Inserire nell'elenco delle sostituzioni, \r\n" +
        "quando si cambia quale si desidera creare una colonna separata di parti.\r\n" +
        "Se non hai bisogno di alcun raggruppamento, lascia il campo vuoto.",
      "Gruppieren von Teilen in separaten Spalten.\r\n" +
        "Fügen Sie in die Liste der Substitutionen ein,\r\n" +
        "wenn Sie ändern möchten, welche Sie eine separate Spalte mit Teilen erstellen möchten.\r\n" +
        "Wenn Sie keine Gruppierung benötigen, lassen Sie das Feld leer.",
      "将图形按规则进行分组排列。如果留空将不分组，分组可以按 “块”  “颜色”  “图层” 等进行。注意：替换字符为英文。"};
    public static readonly string[] TitleSort = {
      "Title and sorting",
      "Заголовок и сортировка",
      "Titolo e ordinamento",
      "Titel und Sortierung",
      "标题和排序"};
    public static readonly string[] MakeTitle = {
      "Title",
      "Создать",
      "Titolo",
      "Titel",
      "文字设置"};
    public static readonly string[] MakeTitleTip = {
      "Insert title for each part.",
      "Вставить текстовый заголовок к каждой детали.",
      "Inserisci il titolo per ogni parte.",
      "Titel für jeden Teil einfügen.",
      "为每个图形插入文本。"};
    public static readonly string[] TitleTip = {
      "Detail header template.\r\n" +
        "Use property substitutions for solid, material, block-assembly and drawing.\r\n" +
        "You can add any text and formatting characters (eg \\P - line break).\r\n" +
        "Leave an empty line so that the program will automatically create a template \r\n" +
        "depending on the selection conditions.",
      "Шаблон заголовка детали.\r\n"+
        "Используйте подстановки свойств солида, материала, блока-сборки и чертежа.\r\n"+
        "В можете добавить любой текст и символы форматирования (например \\P - перенос строки).\r\n" +
        "Оставьте пустую строку, чтоб программа создала шаблон автоматически\r\n"+
        "в зависимости от условий отбора.",
      "Modello di intestazione di dettaglio.\r\n" +
        "Utilizza le sostituzioni di proprietà per solidi, materiali, assiemi di blocchi e disegni.\r\n" +
        "Puoi aggiungere qualsiasi testo e carattere di formattazione (ad es. \\P - interruzione di riga).\r\n" +
        "Lasciare una riga vuota in modo che il programma crei automaticamente un modello \r\n" +
        "in base alle condizioni di selezione.",
      "Detail-Header-Vorlage.\r\n" +
        "Verwenden Sie Eigenschaftsersetzungen für Volumenkörper, Materialien, Blockbaugruppen und Zeichnungen.\r\n" +
        "Sie können beliebigen Text und Formatierungszeichen hinzufügen (zB \\P - Zeilenumbruch).\r\n" +
        "Lassen Sie eine leere Zeile, damit das Programm abhängig von den Auswahlbedingungen \r\n" +
        "automatisch eine Vorlage erstellt.",
      "详细标题模板。\r\n" +
        "对实体、材料、块组件和工程图使用属性替换。\r\n" +
        "您可以添加任何文本和格式字符（例如 \\P - 换行符）。\r\n" +
        "保留一个空行，以便程序将根据选择条件自动创建模板。"};
    public static readonly string[] TextStyle = {
      "Style",
      "Стиль",
      "Stile",
      "Stil",
      "样式"};
    public static readonly string[] TextStyleTip = {
      "Title text style. Set space for use current style.",
      "Стиль текста заголовка. В стилях задается шрифт и размер текста. Оставьте пустым, чтоб использовать текущий стиль текста.",
      "Stile del testo del titolo. Imposta lo spazio per l'uso dello stile corrente.",
      "Titeltextstil. Legen Sie Platz für die Verwendung des aktuellen Stils fest.",
      "文字样式。你可选择其它的文字样式置为当前。"};
    public static readonly string[] HeightTip = {
      "Text size. Set 0 for use system variable _TextSize",
      "Размер текста.\r\n"+
        "Назначьте 0, чтоб использовать системную переменную _TextSize.",
      "Dimensione del testo.\r\n" +
        "Impostare su 0 per utilizzare la variabile di sistema _TextSize.",
      "Textgröße.\r\n" +
        "Auf 0 setzen, um die Systemvariable _TextSize zu verwenden.",
      "字体大小。\r\n" +
         "设置 0 使用系统变量 _TextSize 的字体大小。"};
    public static readonly string[] TextFrame = {
      "Text Frame",
      "Рамка",
      "Cornice di testo",
      "Textrahmen",
      "文字框"};
    public static readonly string[] TextFrameTip = {
      "Draw a frame around the text.",
      "Прямоугольная рамка вокруг заголовка",
      "Disegna una cornice attorno al testo.",
      "Ziehen Sie einen Rahmen um den Text.",
      "在文字周围生成一个矩形框"};
    public static readonly string[] Center = {
      "Center",
      "Центр",
      "Centro",
      "Center",
      "居中"};
    public static readonly string[] CenterTip = {
      "Align the Title center for the middle of detail.\r\n"+
        "If the title is inside the details, program will be made and a vertical align to center too.",
      "Выравнивать центр заголовка по центру деталей.\r\n"+
        "Если заголовок внутри детали,\r\n"+
        "то будет производится и вертикальное выравнивание тоже.",
      "Allinea il centro del titolo per il centro del dettaglio.\r\n " +
        "Se il titolo è all'interno dei dettagli, verrà creato \r\n" +
        "un programma e anche un allineamento verticale al centro.",
      "Richten Sie die Titelmitte für die Mitte des Details aus.\r\n " +
        "Wenn sich der Titel innerhalb der Details befindet, \r\n" +
        "wird ein Programm erstellt und auch eine vertikale Ausrichtung zur Mitte vorgenommen.",
      "生成的文字与图形的中心对齐。"};
    public static readonly string[] Inside = {
      "Inside",
      "Внутри",
      "Dentro",
      "Innerhalb",
      "内部"};
    public static readonly string[] InsideTip = {
      "To place the text inside detail drawing. \r\n"+
        "The program does not pay attention to the details with complex contours and\r\n"+
        "place the text inside the rectangle conditional restricted with dimensions of parts.\r\n"+
        "If you turn on the rendering mode filled faces of solids, you will not see the headers,\r\n"+
        "as texts will be below details.",
      "Разместить текст внутри чертежа детали.\r\n"+
        "Программа не обращает внимания на детали со сложными контурами\r\n"+
        "и размещает текст внутри условного прямоугольника ограничивающего габариты детали.\r\n"+
        "Если вы включите режим визуализации с заливкой граней твердых тел,\r\n"+
        "то вы не увидите заголовки, т.к. тексты окажутся под деталями.",
      "Per posizionare il testo all'interno del disegno di dettaglio.\r\n" +
        "Il programma non presta attenzione ai dettagli con contorni complessi e \r\n" +
        "posiziona il testo all'interno del rettangolo condizionato con le \r\n" +
        "dimensioni delle parti. \r\n" +
        "Se attivi la modalità di rendering facce piene di solidi, non vedrai le intestazioni, \r\n" +
        "poiché i testi saranno sotto i dettagli.",
      "So platzieren Sie den Text in der Detailzeichnung. \r\n" +
        "Das Programm achtet nicht auf die Details mit komplexen Konturen und platziert \r\n" +
        "den Text innerhalb des Rechtecks, bedingt durch die Abmessungen der Teile. \r\n" +
        "Wenn Sie den Rendermodus für gefüllte Flächen von Volumenkörpern aktivieren, \r\n" +
        "werden Sie die Kopfzeilen nicht sehen, da die Texte unter den Details stehen.",
      "将文本放置在图形区域的内部。该程序不计算生成图形的形状。\r\n" +
        "如果您打开渲染模式或视觉样式，您可能看不到文字，\r\n" +
        "因为文本置于图形之下。"};
    public static readonly string[] DetailSpace = {
      "Part space",
      "Отступ детали",
      "Rientro di dettaglio",
      "Detaileinzug",
      "细节缩进"};
    public static readonly string[] DetailSpaceTip = {
      "Distance between parts along the Y axis.\r\n" +
        "From the bottom of the previous part to the head of the next part.\r\n" +
        "Set it to 0 to have the program choose the indentation \r\n" +
        "based on the height of the title text and the dimensions of the part.",
      "Расстояние между деталями по оси Y. \r\n" +
        "От низа предыдущей детали до заголовка следующей детали.\r\n"+
        "Назначьте 0, чтоб программа сама выбрала отступ в зависимости от высоты текста заголовка и размеров детали.",
      "Distanza tra le parti lungo l'asse Y. \r\n" +
        "Dal fondo della parte precedente all'intestazione della parte successiva. \r\n" +
        "Impostalo a 0 per consentire al programma di scegliere il rientro \r\n" +
        "in base all'altezza del testo del titolo e alle dimensioni della parte.",
      "Abstand zwischen Teilen entlang der Y-Achse. \r\n" +
        "Von der Unterseite des vorherigen Teils bis zur Kopfzeile des nächsten Teils. \r\n" +
        "Setzen Sie ihn auf 0, damit das Programm den Einzug basierend \r\n" +
        "auf der Höhe des Titeltextes und den Abmessungen des Teils wählt.",
      "沿 Y 轴的部件之间的距离。\r\n" +
        "从上一个部件的底部到下一个部件的标题。 \r\n" +
        "将其设置为 0 以让程序根据标题文本的高度和零件的尺寸来选择缩进。"};
    public static readonly string[] TitleSpace = {
      "Title space",
      "Отступ заголовка",
      "Rientro dell'intestazione",
      "Überschrift Einzug",
      "标题缩进"};
    public static readonly string[] TitleSpaceTip = {
      "Additional padding between title and detail to accommodate dimensions and leaders. \r\n" +
        "Set to 0 to use an indent equal to the height of the title text.\r\n" +
        "Only fires when the title is placed above the part and not in the center.\r\n" +
        "In the Detail Drawing command, this distance is plotted in paper space, not in the model.",
      "Дополнительный отступ между заголовком и деталью для размещения размеров и выносок. \r\n" +
        "Назначьте 0, чтоб использовать отступ равный высоте текста заголовка.\r\n" +
        "Срабатывает только когда заголовок размещается над деталью, а не в центре.\r\n" +
        "В команде Деталировки это расстояние откладывается в пространстве бумаги, а не в модели.",
      "Riempimento aggiuntivo tra titolo e dettaglio per adattarsi a dimensioni. \r\n" +
        "Impostare su 0 per utilizzare un rientro uguale all'altezza del testo del titolo.\r\n" +
        "Si attiva solo quando il titolo è posizionato sopra la parte e non al centro.\r\n" +
        "Nel comando Dettagli, questa distanza viene tracciata nello spazio carta, non nel modello.",
      "Zusätzliche Polsterung zwischen Titel und Detail, um Abmessungen und Beschriftungen aufzunehmen. \r\n" +
        "Auf 0 setzen, um einen Einzug gleich der Höhe des Titeltextes zu verwenden.\r\n" +
        "Wird nur ausgelöst, wenn der Titel über dem Teil und nicht in der Mitte platziert wird.\r\n" +
        "Im Befehl „Detail“ wird dieser Abstand im Papierbereich dargestellt, nicht im Modell.",
      "标题和详细信息之间的额外填充以适应尺寸和标注。\r\n" +
        "设置为 0 以使用等于标题文本高度的缩进。\r\n" +
        "仅当标题位于零件上方而不是中心时才会触发。\r\n" +
        "在“详细信息”命令中，此距离绘制在图纸空间中，而不是模型中。"};
    public static readonly string[] FrontTo = {
      "Lay the front",
      "Выложить фасадом",
      "AStenditi in",
      "Front nach auslegen",
      "面方向选项"};
    public static readonly string[] Up = {
      "Up",
      "Вверх",
      "Su",
      "Hoch",
      "面朝上"};
    public static readonly string[] UpTip = {
      "Lay the parts with the main (best, facade) side up on the Z.\r\n"+
        "Optimal for processing parts on panel saw machines.",
      "Выложить детали главной (наилучшей, фасадной) стороной вверх по Z.\r\n"+
        "Оптимально для обработки деталей на форматно-раскроечных станках.",
      "Posare i pezzi con il lato principale (migliore, facciata) sulla Z.\r\n " +
        "Ottimale per la lavorazione di pezzi su macchine sezionatrici.",
      "Legen Sie die Teile mit der Haupt- (am besten Fassade) Seite nach oben auf das Z.\r\n" +
        "Optimal für die Bearbeitung von Teilen auf Plattensägemaschinen.",
      "将正面朝上平铺零件。\r\n" +
         "最适合在裁板锯机上加工零件。"};
    public static readonly string[] Down = {
      "Down",
      "Вниз",
      "Giù",
      "Runter",
      "面朝下"};
    public static readonly string[] DownTip = {
      "Lay out the parts with the main (best, facade) side down Z.\r\n"+
        "Optimal for machining parts on CNC milling machines and machining centers.\r\n"+
        "The facade surface is selected: \r\n"+
        "1. Marked with color,\r\n"+
        "2. Maximum in area,\r\n"+
        "3. Coating material assigned,\r\n"+
        "4. Initially turned up.\r\n"+
        "1 and 4 can be disabled in the Common Options.",
      "Выложить детали главной (наилучшей, фасадной) стороной вниз по Z.\r\n"+
        "Оптимально для обработки деталей на фрезерах ЧПУ и обрабатывающих центрах.\r\n"+
        "Фасадная поверхности выбирается:\r\n"+
        "1. Помеченная цветом,\r\n"+
        "2. Максимальная по площади,\r\n"+
        "3. Присвоен материал покрытия,\r\n"+
        "4. Изначально повернутая вверх.\r\n"+
        "1 и 4 отключается в Общих настройках.",
      "Disporre le parti con il lato principale (migliore, anteriore) rivolto verso il basso in Z.\r\n" +
        "Ideale per la lavorazione di parti su router e centri di lavoro CNC.\r\n" +
        "La superficie della facciata è selezionata:\r\n"+
         "1. Colorato,\r\n"+
         "2. Area massima,\r\n"+
         "3. Materiale di rivestimento assegnato,\r\n"+
         "4. Inizialmente rivolto verso l'alto.\r\n"+
         "1 e 4 sono disabilitati nelle impostazioni generali.",
      "Legen Sie die Teile mit der Haupt- (besten, vorderen) Seite nach unten in Z.\r\n" +
        "Optimal für die Bearbeitung von Teilen auf CNC-Fräsen und Bearbeitungszentren.\r\n" +
        "Fassadenoberfläche ist ausgewählt:\r\n"+
         "1. Farbig,\r\n"+
         "2. Maximale Fläche,\r\n"+
         "3. Beschichtungsmaterial zugewiesen,\r\n"+
         "4. Anfänglich nach oben zeigend.\r\n"+
         "1 und 4 sind in den allgemeinen Einstellungen deaktiviert.",
      "将正面朝下平铺零件。工艺复杂的一面朝上，\r\n"+
         "最适合在 CNC 铣床和加工中心上加工零件。\r\n"+
         "选项方式：\r\n"+
         "1. 标有颜色，\r\n"+
         "2.面积最大，\r\n"+
         "3.指定的涂层材料，\r\n"+
         "4. 初始向上。\r\n"+
         "可以在通用选项中禁用 1 和 4。"};
    public static readonly string[] ByTechnology = {
      "by Technology",
      "Технологично",
      "Tecnologicamente",
      "Technologisch",
      "按加工面"};
    public static readonly string[] ByTechnologyTip = {
      "Lay front up simple parts that are suitable for sawing.\r\n"+
        "And all other details - the front down.\r\n"+
        "A part with six or less flat faces without holes is considered simple.",
      "Выложить фасадом вверх простые детали, пригодные для распилки\r\n"+
        "на форматно-раскроечном станке.\r\n"+
        "А все остальные детали - фасадом вниз.\r\n"+
        "Простой считается деталь с шестью и менее плоскими гранями без отверстий.",
      "Appoggia in avanti le parti semplici adatte al taglio.\r\n"+
         "E tutti gli altri dettagli: la parte anteriore in basso.\r\n"+
         "Una parte con sei facce o meno piatte senza fori è considerata semplice.",
      "Einfache Teile, die zum Sägen geeignet sind, vorne auflegen.\r\n"+
         "Und alle anderen Details - die Vorderseite nach unten.\r\n"+
         "Ein Teil mit sechs oder weniger flachen Flächen ohne Löcher wird als einfach angesehen.",
      "将加工工艺复杂的一面朝上放置。"};
    public static readonly string[] BothSide = {
      "Both side",
      "Обе стороны",
      "Entrambe le parti",
      "Beide Seiten",
      "双面"};
    public static readonly string[] BothSideTip = {
      "Lay on two sides if there is processing from below.",
      "Выкладывать деталь двумя сторонами, если есть обработка снизу",
      "Appoggiare su due lati se c'è lavorazione dal basso.",
      "Bei Bearbeitung von unten beidseitig auflegen.",
      "根据选项不同，合并或单独生成正反面。"};
    public static readonly string[] AlongY = {
      "Along Y",
      "Вдоль Y",
      "Lungo Y",
      "Entlang Y",
      "沿Y轴"};
    public static readonly string[] AlongYTip = {
      "Rotate the parts with the long side along the Y axis. The texture will also be rotated vertically.",
      "Развернуть детали длинной стороной вдоль оси Y. Текстура тоже развернется по вертикали.",
      "Ruota le parti con il lato lungo lungo l'asse Y. La texture verrà anche ruotata verticalmente.",
      "Drehen Sie die Teile mit der langen Seite entlang der Y-Achse. Die Textur wird auch vertikal gedreht.",
      "纹理或长边,沿 Y 轴旋转，"};
    public static readonly string[] UpsideDown = {
      "Flip",
      "Перевернуть",
      "Flip",
      "Umdrehen",
      "翻动"};
    public static readonly string[] UpsideDownTip = {
      "Rotate the part around Z 180 degrees so that the best angle and the best edge are at the top of the drawing.",
      "Развернуть деталь вокруг Z на 180 градусов, чтоб лучший угол и лучшее ребро были сверху чертежа",
      "Ruota la parte attorno a Z di 180 gradi in modo che l'angolo e il bordo migliori si trovino nella parte superiore del disegno.",
      "Drehen Sie das Teil um 180 Grad um Z, sodass der beste Winkel und die beste Kante oben in der Zeichnung liegen.",
      "Ruota la parte attorno a Z di 180 gradi in modo che l'angolo e il bordo migliori si trovino nella parte superiore del disegno."};
    public static readonly string[] MarkTexture = {
      "Mark texture",
      "Пометка текстуры",
      "Segna la trama",
      "Textur markieren",
      "标记纹理"};
    public static readonly string[] MarkTextureTip = {
      "Write <<TEXTURE>> in a middle of a detail if solid Texture marked (along or across).",
      "Писать <<ТЕКСТУРА>> в центре детали, если солид помечен, как имеющий текстуру вдоль или поперек.",
      "Scrivi <<TEXTURE>> nel mezzo di un dettaglio se è contrassegnata una Texture solida (lungo o trasversalmente).",
      "Schreiben Sie <<TEXTURE>> in die Mitte eines Details, wenn eine solide Textur markiert ist (längs oder quer).",
      "如果三维实体属性值设置为 '纹理 = 长向(along) 或者 宽向(across)'," +
        "则在平铺后的图形中间写下 <<纹理方向>> (<<TEXTURE>>)"};
    public static readonly string[] MakeFlatShot = {
      "Make FlatShot",
      "Плоские контуры",
      "Crea FlatShot",
      "Machen Sie FlatShot",
      "二维图形"};
    public static readonly string[] MakeFlatShotTip = {
      "Calling FlatShot command after LAY.\r\n"+
        "If layer management is enabled (in the Common Options),\r\n" +
        "then a layer for visible lines and a layer for hidden lines will be created.\r\n" +
        "If the option is disabled, the program will use the color and layer of the solid \r\n" +
        "and set the hidden line color to green.",
      "Вызов команды Плоский слепок (FlatShot) после Выкладки.\r\n"+
        "Если управление слоями включено (в Общих Настройках),\r\n" +
        "то будут созданы слой для видимых линий и слой для скрытых линий.\r\n" +
        "Если опция отключена, программа будет использовать цвет \r\n" +
        "и слой твердого тела и зеленый цвет для скрытых линий.",
      "Chiamare il comando FlatShot dopo Disposizione (LAY).\r\n"+
         "Se è abilitata la gestione dei livelli (nelle Opzioni comuni),\r\n" +
        "verrà creato un livello per le linee visibili e un livello per le linee nascoste.\r\n" +
         "Se l'opzione è disabilitata, il programma utilizzerà il colore \r\n" +
        "e il livello del solido e imposterà il colore della linea nascosta su verde.",
      "Aufruf des FlatShot-Befehls nach Layout (LAY).\r\n"+
        "Wenn die Ebenenverwaltung aktiviert ist (in den allgemeinen Optionen),\r\n" +
        "wird eine Ebene für sichtbare Linien und eine Ebene für verdeckte Linien erstellt.\r\n" +
        "Wenn die Option deaktiviert ist, verwendet das Programm die Farbe \r\n" +
        "und Ebene des Volltons und setzt die Farbe der verdeckten Linie auf Grün.",
      "在 LAY 命令之后调用 FlatShot（平面摄影) 命令。\r\n" +
        "生成的二维图形将放置到相应的图层, 可见图形放在“MD_Visible”图层，\r\n" +
        "隐藏图形放在“MD_Hidden ”图层。"};
    public static readonly string[] GroupFrame = {
      "Frame around the group",
      "Рамка вокруг группы",
      "Inquadrare il gruppo",
      "Rahmen um die Gruppe herum",
      "围绕小组框架"};
    public static readonly string[] GroupFrameTip = {
      "Draw a rectangle around each group of laid out parts. \r\n" +
        "Just to visually separate the calculation from the main model. \r\n" +
        "The polyline will be created in the non-printable Info layer.",
      "Начертить прямоугольник вокруг каждой группы выложенных деталей. \r\n" +
        "Просто для наглядного отделения выкладки от основной модели. \r\n" +
        "Полилиния будет создана в непечатном слое Инфо",
      "Disegna un rettangolo attorno a ciascun gruppo di parti disposte. \r\n" +
        "Giusto per separare visivamente il calcolo dal modello principale. \r\n" +
        "La polilinea verrà creata nel livello Info non stampabile.",
      "Zeichnen Sie ein Rechteck um jede Gruppe von ausgelegten Teilen. \r\n" +
        "Nur um die Berechnung visuell vom Hauptmodell zu trennen. \r\n" +
        "Die Polylinie wird in der nicht druckbaren Infoebene erstellt.",
      "在每组布局的部分周围画一个矩形。 只是为了在视觉上将计算与主模型分开。 \r\n" +
        "折线将在不可打印的信息层中创建。"};
    public static readonly string[] PartFrame = {
      "Frame around the part",
      "Рамка вокруг детали",
      "Cornice intorno alla parte",
      "Rahmen um das Teil",
      "零件周围的框架"};
    public static readonly string[] PartFrameTip = {
      "Draw a rectangle around the solid of the laid out part. \r\n" +
        "The frame can be useful when exporting solids to AlphaCAM.\r\n" +
        "The polyline will be created in the non-printable Info layer.",
      "Начертить прямоугольник вокруг солида выложенной детали. \r\n" +
        "Рамка может пригодится при экспорте солидов в AlphaCAM.\r\n" +
        "Полилиния будет создана в непечатном слое Инфо",
      "Disegna un rettangolo attorno al solido della parte stesa. \r\n" +
        "La cornice può essere utile quando si esportano solidi in AlphaCAM.\r\n" +
        "La polilinea verrà creata nel livello Info non stampabile.",
      "Zeichnen Sie ein Rechteck um den Körper des ausgelegten Teils. \r\n" +
        "Der Rahmen kann nützlich sein, wenn Sie Volumenkörper nach AlphaCAM exportieren.\r\n" +
        "Die Polylinie wird in der nicht druckbaren Infoebene erstellt.",
      "围绕布局部分的实体绘制一个矩形。 \r\n" +
        "将实体导出到 AlphaCAM 时，框架非常有用。\r\n" +
        "折线将在不可打印的信息层中创建。"};


    public static readonly string[] Block4Part = {
      "Make a block for every detail",
      "Сделать блок для каждой детали",
      "Crea un blocco per ogni dettaglio",
      "Machen Sie einen Block für jedes Detail",
      "为每个细节做一个块"};

    public static readonly string[] Block4PartTip = {
      "Merge the solid or all the contours of the part together with the title into a block. Make sure the parts have names - they will be used as the block name.",
      "Объединить солид или все контуры детали вместе с заголовком в блок. Убедитесь, что у деталей есть имена - они будут использованы как имя блока.",
      "Unisci il solido o tutti i contorni della parte insieme al titolo in un blocco. Assicurati che le parti abbiano nomi: verranno utilizzate come nome del blocco.",
      "Führen Sie den Körper oder alle Umrisse des Teils zusammen mit dem Titel zu einem Block zusammen. Stellen Sie sicher, dass die Teile Namen haben - sie werden als Blockname verwendet.",
      "将零件的实体或所有轮廓与标题合并成一个块。 确保零件有名称 - 它们将用作块名称。"};

    public static readonly string[] Block4Lay = {
      "Make a common block for the entire layout",
      "Сделать общий блок для всей выкладки",
      "Crea un blocco comune per l'intero layout",
      "Erstellen Sie einen gemeinsamen Block für das gesamte Layout",
      "为整个布局制作一个公共块"};

    public static readonly string[] Block4LayTip = {
      "Combine all laid out details from all groups (outlines, titles and frames) into a single large block. The block will be given the same name as the LAY-style.",
      "Объединить все выложенные детали из всех групп (контуры, заголовки и рамки) в единый большой блок. Блоку будет дано имя как у стиля выкладки.",
      "Combina tutti i dettagli disposti da tutti i gruppi (contorni, titoli e cornici) in un unico grande blocco. Al blocco verrà assegnato lo stesso nome dello stile di LAY.",
      "Kombinieren Sie alle angeordneten Details aus allen Gruppen (Umrisse, Titel und Rahmen) in einem einzigen großen Block. Der Block erhält denselben Namen wie der LAYstil.",
      "将所有组（大纲、标题和框架）中的所有布局细节组合到一个大块中。 该块将被赋予与布局样式相同的名称。"};

  }
}
