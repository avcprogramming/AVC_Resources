// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/


// Ignore Spelling: Det

namespace AVC
{
  public static class
  DimDetailingL
  {
    public static readonly string[,] DimDetStyleNames = {
/* 0 */ {
        CommandL.DimDet[0],
        CommandL.DimDet[1],
        CommandL.DimDet[2],
        CommandL.DimDet[3],
        CommandL.DimDet[4] },
/* 1 */ {
        CommandL.DimDet[0],
        CommandL.DimDet[1],
        CommandL.DimDet[2],
        CommandL.DimDet[3],
        CommandL.DimDet[4] },
/* 2 */ {
        "Dimensions for DXF",
        "Размеры для DXF",
        "Dimensioni per DXF",
        "Abmessungen für DXF",
        "DXF 尺寸" },
/* 3 */ {
        "All Dimensions",
        "Все размеры",
        "Perché Dimensioni",
        "Also Abmessungen",
        "所有尺寸" },
    };

    public static readonly string[] DefBlindHoleFormat = {
      "%%c%diam%\\XDepth %depth%%countersink: {0}%",
      "%%c%diam%\\XГл.%depth%%countersink: {0}%",
      "%%c%diam%\\XPr.%depth%%countersink: {0}%",
      "%%c%diam%\\XTiefe %depth%%countersink: {0}%",
      "%%c%diam%\\X深度 %depth%%countersink: {0}%"};

    public static readonly string[] DefDadoFormat = {
      "W%diam%\\XDepth %depth%",
      "Ш%diam%\\XГл.%depth%",
      "Lar.%diam%\\XPr.%depth%",
      "B%diam%\\XTiefe %depth%",
      "宽度%diam%\\X深度 %depth%"};

    // ======================================== Dialog Box ===========================================================

    public static readonly string[] BandingAllLeaders = {
      "Even if everyone is the same",
      "Даже если все одинаковые",
      "Anche se tutti sono uguali",
      "Auch wenn alle gleich sind",
      "即使每个人都一样"};
    public static readonly string[] BandingAllLeadersTip = {
      "Make leaders with edge materials even if all edges are covered with the same material. \r\n" +
        "Usually, the coating of the edges is indicated in the description of the part \r\n" +
        "and it makes no sense to repeat it on the leaders at all edges. \r\n" +
        "The setting applies only to the ends on the outside of the part(edge bandings). \r\n" +
        "The rest of the coverings will be shown anyway." ,
      "Делать выноски с материалами торцев даже в том случае, \r\n" +
        "если все торцы покрыты одинаковым материалом. \r\n" +
        "Обычно покрытие торцев указано в описании детали \r\n" +
        "и его нет смысла повторять на выносках на всех торцах. \r\n" +
        "Настройка распространяется только на торцы снаружи детали. \r\n" +
        "Остальные покрытия будут показаны в любом случае.",
      "Crea direttrici con materiali per bordi anche se tutti \r\n" +
        "i bordi sono ricoperti con lo stesso materiale. \r\n" +
        "Solitamente il rivestimento dei bordi è indicato \r\n" +
        "nella descrizione del pezzo e non ha senso ripeterlo sui capi a tutti i bordi. \r\n" +
        "L'impostazione si applica solo alle estremità all'esterno del pezzo (bordature). \r\n" +
        "Il resto delle coperture sarà comunque mostrato.",
      "Erstellen Sie Führungslinien mit Kantenmaterialien, \r\n" +
        "auch wenn alle Kanten mit demselben Material bedeckt sind. \r\n" +
        "Normalerweise ist die Beschichtung der Kanten in \r\n" +
        "der Beschreibung des Teils angegeben und es macht keinen Sinn, \r\n" +
        "sie auf den Leitern an allen Kanten zu wiederholen. \r\n" +
        "Die Einstellung gilt nur für die Enden auf der Außenseite des Teils (Randstreifen). \r\n" +
        "Die restlichen Beläge werden trotzdem angezeigt.",
      "即使所有边缘都覆盖有相同的材料，也可以使用边缘材料制作引线。 \r\n" +
        "通常，边缘的涂层会在零件描述中注明，在所有边缘的引线上重复它是没有意义的。 \r\n" +
        "该设置仅适用于零件外侧的末端（封边条）。 \r\n" +
        "其余的覆盖物无论如何都会显示出来。"};
    public static readonly string[] BandingLeaders = {
      "Cover Leaders",
      "Выноски покрытий",
      "Leader della bordatura",
      "Führungslinie der Kante",
      "磨边的领导者"};
    public static readonly string[] BandingLeadersTip = {
      "Coating symbols for all surfaces of the part on the leaders. \r\n" +
        "For painting, laminating and edge bandings." ,
      "Обозначения покрытий всех поверхностей детали на выносках. \r\n" +
        "Для покраски, ламинирования и кромок.",
      "Simboli di rivestimento per tutte le superfici della parte sulle guide. \r\n" +
        "Per la verniciatura, la laminazione e la bordatura.",
      "Beschichtungssymbole für alle Oberflächen des Teils auf den Leitern. \r\n" +
        "Zum Lackieren, Kaschieren und Kantenanleimen.",
      "引线上零件所有表面的涂层符号。 \r\n" +
        "用于喷漆、层压和封边。"};
    public static readonly string[] DimStyleTip = {
      "Dimension style for overall dimensions. \r\n" +
        "Leave blank to use the current style." ,
      "Размерный стиль для габаритных размеров. \r\n" +
        "Оставьте поле пустым, чтобы использовать текущий стиль.",
      "Stile di quota per le dimensioni complessive. \r\n" +
        "Lascia vuoto per usare lo stile corrente.",
      "Bemaßungsstil für Gesamtbemaßungen. \r\n" +
        "Lassen Sie das Feld leer, um den aktuellen Stil zu verwenden.",
      "整体尺寸的尺寸样式。 \r\n" +
        "留空以使用当前样式。"};
    public static readonly string[] DimStyleFromBaseTip = {
      "Style 'from the base' for the chain of sizes from the base to the drill. \r\n" +
        "Leave the field blank to use the dimension style." ,
      "Стиль «от базы» для цепочки размеров от базы до сверления. \r\n" +
        "Оставьте поле пустым, чтобы использовать стиль габаритных размеров.",
      "Stile 'dalla base' per la catena di taglie dalla base al trapano. \r\n" +
        "Lascia vuoto il campo per utilizzare lo stile di quota.",
      "Stil „von der Basis“ für die Größenkette von der Basis bis zum Bohrer. \r\n" +
        "Lassen Sie das Feld leer, um den Bemaßungsstil zu verwenden.",
      "从底座到钻头的尺寸链样式“从底座”。 \r\n" +
        "将该字段留空以使用尺寸样式。"};
    public static readonly string[] FrontDrillPositions = {
      "Frontal drill positions",
      "Позиции лицевых",
      "Dimensioni d.foratura frontale",
      "Frontale Bohrpositionen",
      "正面钻孔位置"};
    public static readonly string[] FrontDrillPositionsTip = {
      "Put down a chain of measurements from the corner of the part to the frontal holes. \r\n" +
        "For a pair of holes with a pitch of 32, only one size is affixed." ,
      "Проставить цепочку размеров от угла детали до лицевых отверстий. \r\n" +
        "Для пары отверстий с шагом 32 проставляется только один размер.",
      "Metti giù una catena di misurazioni dall'angolo della parte ai fori frontali. \r\n" +
        "Per una coppia di fori con passo 32 viene applicata una sola misura.",
      "Legen Sie eine Messkette von der Ecke des Teils bis zu den vorderen Löchern an. \r\n" +
        "Bei einem Lochpaar mit einer Teilung von 32 wird nur eine Größe aufgeklebt.",
      "从零件的角落到前孔放下一系列测量。 \r\n" +
        "对于间距为 32 的一对孔，只贴一个尺寸。"};
    public static readonly string[] HiddenCoverLeaders = {
      "Hidden covers",
      "Невидимые покрытия",
      "Rivestimenti nascosti",
      "Versteckte Abdeckungen",
      "隐藏的封面"};
    public static readonly string[] HiddenCoverLeadersTip = {
      "Make leaders from invisible surfaces: \r\n" +
        "from the back of the part or inclined planes turned down in the drawing. \r\n" +
        "Note that the rear face leader will point to the same point as the facade leader." ,
      "Делать выноски с невидимых поверхностей: \r\n" +
        "с задней стороны детали или наклонных плоскостей, повернутых на чертеже вниз. \r\n" +
        "Обратите внимание, что выноска с задней поверхности будет показывать в ту же точку, что и выноска с фасада.",
      "Crea leader da superfici invisibili: \r\n" +
        "dal retro della parte o piani inclinati rivolti verso il basso nel disegno. \r\n" +
        "Si noti che la direttrice della faccia posteriore punterà allo stesso punto della direttrice della facciata.",
      "Machen Sie Führungen aus unsichtbaren Oberflächen: \r\n" +
        "von der Rückseite des Teils oder von geneigten Ebenen,\r\n" +
        " die in der Zeichnung nach unten gedreht sind. Beachten Sie, dass die Führungslinie der Rückseite auf denselben Punkt zeigt wie die Führungslinie der Fassade.",
      "从不可见的表面制作引线：\r\n" +
        "从零件的背面或在图纸中向下倾斜的平面。 \r\n" +
        "请注意，背面引线将指向与正面引线相同的点。"};
    public static readonly string[] HoleBlocks = {
      "Mark frontal drilling",
      "Лицевые сверления",
      "Segna la foratura frontale",
      "Frontalbohrung markieren",
      "标记正面钻孔"};
    public static readonly string[] HoleBlocksTip = {
      "Mark the frontal drilling with blocks,\r\n" +
        "and for other holes, put down the diameters.\r\n" +
        "The current dimension style is used."  ,
      "Обозначить отверстия блоками, \r\n" +
        "а для прочих отверстий проставить диаметры. \r\n" +
        "Используется текущий размерный стиль.",
      "Segnare la foratura frontale con blocchi, \r\n" +
        "e per gli altri fori, metti giù i diametri. \r\n" +
        "Viene utilizzato lo stile di quotatura corrente.",
      "Markieren Sie die stirnseitige Bohrung mit Klötzchen \r\n" +
        "und tragen Sie bei anderen Bohrungen die Durchmesser ein. \r\n" +
        "Der aktuelle Bemaßungsstil wird verwendet.",
      "用块标记正面钻孔，对于其他孔，记下直径。\r\n" +
        "使用当前的尺寸样式。"};
    public static readonly string[] LateralDrill = {
      "Mark lateral drilling",
      "Торцевые сверления",
      "Segna la foratura laterale",
      "Seitliche Bohrung markieren",
      "标记横向钻孔"};
    public static readonly string[] LateralDrillTip = {
      "Mark the lateral drilling with blocks,\r\n" +
        "and for other holes, put down the diameters.\r\n" +
        "The current dimension style is used."  ,
      "Отметить боковые сверления с помощью 2d-блоков (условных обозначений), \r\n" +
        "а для других отверстий проставить диаметры. \r\n" +
        "Используется текущий размерный стиль.",
      "Segnare la foratura laterale con blocchi, \r\n" +
        "e per gli altri fori, metti giù i diametri. \r\n" +
        "Viene utilizzato lo stile di quotatura corrente.",
      "Markieren Sie die seitlichen Bohrungen mit Blöcken \r\n" +
        "und tragen Sie für andere Bohrungen die Durchmesser ein. \r\n" +
        "Der aktuelle Bemaßungsstil wird verwendet.",
      "用块标记横向钻孔，对于其他孔，记下直径。使用当前的尺寸样式。"};
    public static readonly string[] LateralDrillPositions = {
      "Lateral drill positions",
      "Позиции торцевых",
      "Dimensioni d.foratura laterale",
      "Seitliche Bohrpositionen",
      "侧钻位置"};
    public static readonly string[] LateralDrillPositionsTip = {
      "Put down a chain of measurements from the corner of the part to the lateral holes.\r\n" +
        "For a pair of holes with a pitch of 32, only one size is affixed." ,
      "Проставить цепочку размеров от угла детали до торцевых отверстий. \r\n" +
        "Для пары отверстий с шагом 32 проставляется только один размер.",
      "Metti giù una catena di misure dall'angolo della parte ai fori laterali. \r\n" +
        "Per una coppia di fori con passo 32 viene applicata una sola misura.",
      "Legen Sie eine Maßkette von der Ecke des Teils bis zu den seitlichen Löchern an. \r\n" +
        "Bei einem Lochpaar mit einer Teilung von 32 wird nur eine Größe aufgeklebt.",
      "放下从零件角到侧面孔的一连串测量。\r\n" +
        "对于间距为32的一对孔，只贴一个尺寸。"};
    public static readonly string[] OverallDimensions = {
      "Overall dimensions",
      "Габаритные размеры",
      "Dimensioni generali",
      "Maße",
      "方面"};
    public static readonly string[] OverallDimensionsTip = {
      "Create 2 maximum part dimensions: length and width.",
      "Создать 2 максимальных размера детали: длину и ширину.",
      "Crea 2 dimensioni massime della parte: lunghezza e larghezza.",
      "Erstellen Sie 2 maximale Teileabmessungen: Länge und Breite.",
      "创建 2 个最大零件尺寸：长度和宽度。"};
    public static readonly string[] SlopeLeaders = {
      "Slope Leaders",
      "Выноски наклонов",
      "Direttrice su Inclinazione",
      "Neigung Führungslinie",
      "坡度角引线"};
    public static readonly string[] SlopeLeadersTip = {
      "Create markings for the ends of the details made with the incline of the saw.\r\n" +
        "The accuracy of the angle designation depends on the current dimension style.",
      "Создавать обозначения для плоских торцев детали сделанных с наклоном пилы. \r\n" +
        "Точность обозначения угла зависит от текущего размерного стиля.",
      "Crea segni per le estremità dei dettagli realizzati con l'inclinazione della sega.\r\n" +
        "La precisione della designazione dell'angolo dipende dallo stile di quotatura corrente.",
      "Erstellen Sie Markierungen für die Enden der Details, die mit der Neigung der Säge gemacht wurden.\r\n" +
        "Die Genauigkeit der Winkelbezeichnung hängt vom aktuellen Bemaßungsstil ab.",
      "用锯子的斜面为细节的末端创建标记。\r\n" +
        "角度指定的准确性取决于当前的标注样式。"};
    public static readonly string[] TextHeightUpdate = {
      "Height of MTexts for a viewport",
      "Размер текстов под вьюпорт",
      "Altezza del TestoM",
      "Höhe von MTexts für ein Ansichtsfenster",
      "视口的多行文字高度"};
    public static readonly string[] TextHeightUpdateTip = {
      "Adjusting the size of the text to the scale of the viewport. \r\n" +
        "Only non-annotative multitexts from model space are processed.\r\n" +
        "It is required to pre-adjust the height of the default texts to the size of the paper space. \r\n" +
        "The option works only when the command is called from the viewport." ,
      "Подгонка высоты всех текстов под масштаб вьюпорта. \r\n" +
        "Обрабатываются только не-аннотативные мультитексты из пространства модели.\r\n" +
        "Требуется предварительно настроить высоту текстов по умолчанию под размер пространства листа. \r\n" +
        "Опция срабатывает только при вызове команды из вьюпорта.",
      "Adattare la dimensione del testo alla scala della finestra. \r\n" +
        "Vengono elaborati solo i multitesti non annotativi dallo spazio modello. \r\n" +
        "È necessario preregolare l'altezza dei testi predefiniti in base alle dimensioni dello spazio carta. \r\n" +
        "L'opzione funziona solo quando il comando viene chiamato dalla finestra.",
      "Anpassen der Textgröße an den Maßstab des Ansichtsfensters. \r\n" +
        "Es werden nur nicht-annotative Multitexte aus dem Modellbereich verarbeitet. \r\n" +
        "Es ist erforderlich, die Höhe der Standardtexte an die Größe des Papierbereichs anzupassen. \r\n" +
        "Die Option funktioniert nur, wenn der Befehl aus dem Ansichtsfenster aufgerufen wird.",
      "将文本的大小调整为视口的比例。 \r\n" +
        "仅处理来自模型空间的非注释性多文本。\r\n" +
        "需要将默认文本的高度预先调整为图纸空间的大小。\r\n" +
        "该选项仅在从视口调用命令时有效。"};
    public static readonly string[] BlindHoleFormat = {
      "Blind format",
      "Формат глухих",
      "Modello cieco",
      "Sacklochformat",
      "盲孔格式"};
    public static readonly string[] BlocksForHoles = {
      "Blocks for drill",
      "Блоки сверлений",
      "Blocchi per foratura",
      "Blöcke für Bohrer",
      "钻块"};
    public static readonly string[] DimStyle = {
      "Style",
      "Стиль",
      "Stile",
      "Stil",
      "风格"};
    public static readonly string[] DimStyleFromBase = {
      "Style",
      "Стиль",
      "Stile",
      "Stil",
      "风格"};
    public static readonly string[] CoverLeaderFormat = {
      "Format",
      "Шаблон",
      "Modello",
      "Format",
      "格式"};
    public static readonly string[] MaxDrillWidth = {
      "Width of drilling machine",
      "Ширина сверлильного станка",
      "Larghezza d.foratrice multimandrino",
      "Breite der Bohrmaschine",
      "钻孔机宽度"};
    public static readonly string[] ThroughHoleFormat = {
      "Through format",
      "Формат сквозных",
      "Modello passante",
      "Durchgangslochformat",
      "通孔格式"};
    public static readonly string[] Tilt = {
      "Format",
      "Шаблон",
      "Modello",
      "Format",
      "格式"};
    public static readonly string[] TiltBelow = {
      "Downward",
      "Текст 'снизу'",
      "'dal basso'",
      "'Nach unten'",
      "向下"};
    public static readonly string[] CoverLeaderFormatTip = {
      "Use any surface property substitutions, \r\n" +
        "including properties of its coating material. \r\n" +
        "For example, %matindex% is the material index letter." ,
      "Используйте любые подстановки свойств поверхности, \r\n" +
        "в том числе свойства ее материала покрытия.\r\n" +
        "Например, %matindex% - буква индекса материала.",
      "Utilizzare qualsiasi sostituzione delle proprietà della superficie, \r\n" +
        "comprese le proprietà del materiale di rivestimento. \r\n" +
        "Ad esempio, %matindex% è la lettera di indice del materiale.",
      "Verwenden Sie alle Oberflächeneigenschaftssubstitutionen, \r\n" +
        "einschließlich der Eigenschaften des Beschichtungsmaterials. \r\n" +
        "Beispielsweise ist %matindex% der Materialindexbuchstabe.",
      "使用任何表面属性替换，包括其涂层材料的属性。 \r\n" +
        "例如，%matindex% 是材料索引字母。"};
    public static readonly string[] BlindHoleFormatTip = {
      "Dimension line text for blind holes. \r\n" +
        "You can use any part and contour property substitutions, such as: \r\n" +
        "%diam% - diameter \r\n" +
        "%depth% - depth" ,
      "Текст на размерной линии для глухих отверстий. \r\n" +
        "Можно использовать любые подстановки свойств детали и контуров, такие как: \r\n" +
        "%diam% - диаметер \r\n" +
        "%depth% - глубина.",      "",
      "Testo della linea di quotatura per fori ciechi. \r\n" +
        "È possibile utilizzare qualsiasi sostituzione di proprietà di parte e contorno, ad esempio: \r\n" +
        "%diam% - diametro \r\n" +
        "%depth% - profondità",
      "Maßlinientext für Sacklöcher. \r\n" +
        "Sie können beliebige Teil- und Kontureigenschaften ersetzen, wie z. B.: \r\n" +
        "%diam% - Durchmesser \r\n" +
        "%depth% - Tiefe",
      "盲孔的尺寸线文本。 \r\n" +
        "您可以使用任何零件和轮廓属性替换，例如：\r\n" +
        "%diam% - 直径 \r\n" +
        "%depth% - 深度"};
    public static readonly string[] BlocksForHolesTip = {
      "Blocks to indicate drilling. \r\n" +
        "List of pairs - Diameter; Name of the block. \r\n" +
        "The pairs are separated by a symbol | .\r\n" +
        "For drillings not included in the list, diameters will be indicated."  ,
      "Обозначения сверлений блоками вместо диаметров. \r\n" +
        "Список пар - диаметр; имя блока. \r\n" +
        "Пары разделяются символом | .\r\n" +
        "Для сверлений, не попавших в список будут проставлены диаметры.",
      "Blocchi per indicare la perforazione. \r\n" +
        "Elenco delle coppie - Diametro; Nome del blocco. \r\n" +
        "Le coppie sono separate da un simbolo '|'. \r\n" +
        "Per le forature non comprese nell'elenco verranno indicati i diametri.",
      "Blöcke zur Anzeige von Bohrungen. \r\n" +
        "Paarliste - Durchmesser; Name des Blocks. \r\n" +
        "Die Paare werden durch ein Symbol '|' getrennt.\r\n" +
        "Bei Bohrungen, die nicht in der Liste enthalten sind, werden die Durchmesser angegeben.",
      "指示钻孔的块。 \r\n" +
        "对列表 - 直径； 块的名称。 \r\n" +
        "这些对由符号“|”分隔.\r\n" +
        "对于未包含在列表中的钻孔，将显示直径。"};
    public static readonly string[] MaxDrillWidthTip = {
      "Width of the machine for lateral drilling. \r\n" +
        "It is taken into account when setting the dimensions of the lateral holes. \r\n" +
        "If the distance from the base is greater than this, \r\n" +
        "then the other end of the part is taken as the base."  ,
      "Ширина станка для сверления в торец. \r\n" +
        "Если расстояния от базы больше этого, \r\n" +
        "то для простановки размеров за базу берется другой конец детали.",
      "Larghezza della macchina per la foratura laterale. \r\n" +
        "Viene tenuto in considerazione quando si impostano le dimensioni dei fori laterali. \r\n" +
        "Se la distanza dalla base è maggiore di questa, \r\n" +
        "quindi l'altra estremità della parte viene presa come base.",
      "Breite der Maschine für seitliches Bohren. \r\n" +
        "Es wird bei der Einstellung der Abmessungen der seitlichen Löcher berücksichtigt. \r\n" +
        "Wenn der Abstand von der Basis größer ist, \r\n" +
        "wird das andere Ende des Teils als Basis genommen.",
      "横向钻孔的机器宽度。 \r\n" +
        "在设置横向孔的尺寸时会考虑到这一点。 \r\n" +
        "如果与底座的距离大于此值，则将零件的另一端作为底座。"};
    public static readonly string[] StyleNameTip = {
      "The name for this DimDet style. \r\n" +
        "Not used in the program. \r\n" +
        "Only for convenience of choice." ,
      "Название для этого стиля 'Размеров для Деталировки'. \r\n" +
        "Не используется в программе. \r\n" +
        "Только для удобства выбора.",
      "Il nome per questo stile DimDet. \r\n" +
        "Non utilizzato nel programma. \r\n" +
        "Solo per comodità di scelta."  ,
      "Der Name für diesen DimDet-Stil. \r\n" +
        "Wird im Programm nicht verwendet. \r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此 DimDet 样式的名称。 \r\n" +
        "程序中未使用。 \r\n" +
        "只为方便选择。"};
    public static readonly string[] ThroughHoleFormatTip = {
      "Dimension line text for through holes. \r\n" +
        "You can use any part and contour property substitutions, such as: \r\n" +
        "%diam% - diameter \r\n" +
        "%depth% - depth" ,
      "Текст на размерной линии для сквозных отверстий. \r\n" +
        "Можно использовать любые подстановки свойств детали и контуров, такие как: \r\n" +
        "%diam% - диаметер \r\n" +
        "%depth% - глубина",
      "Testo della linea di quotatura per fori passanti. \r\n" +
        "È possibile utilizzare qualsiasi sostituzione di proprietà di parte e contorno, ad esempio: \r\n" +
        "%diam% - diametro \r\n" +
        "%depth% - profondità",
      "Maßlinientext für Durchgangsbohrungen. \r\n" +
        "Sie können beliebige Teil- und Kontureigenschaften ersetzen, wie z. B.: \r\n" +
        "%diam% - Durchmesser \r\n" +
        "%depth% - Tiefe",
      "通孔的尺寸线文本。 \r\n" +
        "您可以使用任何零件和轮廓属性替换，例如：\r\n" +
        "%diam% - 直径 \r\n" +
        "%depth% - 深度"};
    public static readonly string[] TiltTip = {
      "Leader text template. \r\n" +
        "Any substitutions can be used in the text, including: \r\n" +
        "%angle% - tilt angle \r\n" +
        "%down% - text 'downward'"  ,
      "Шаблон текста для выноски. \r\n" +
        "В тексте могут быть использованы любые подстановки, включая: \r\n" +
        "%angle% - угол наклона \r\n" +
        "%down% - текст 'снизу'",
      "Modello di testo leader. \r\n" +
        "Eventuali sostituzioni possono essere utilizzate nel testo, tra cui: \r\n" +
        "%angolo% - angolo di inclinazione \r\n" +
        "%down% - testo 'dal basso'",
      "Führungstextvorlage. \r\n" +
        "Im Text können beliebige Ersetzungen verwendet werden, einschließlich: \r\n" +
        "%angle% - Neigungswinkel \r\n" +
        "%down% - Text 'nach unten'",
      "领导者文本模板。 \r\n" +
        "可以在文本中使用任何替换，包括： \r\n" +
        "%angle% - 倾斜角度 \r\n" +
        "%down% - 文本“向下”"};
    public static readonly string[] TiltBelowTip = {
      "Text to be inserted into leaders for invisible slope ends.",
      "Текст, который будет подставлен в выноски для невидимых наклонных торцев.",
      "Testo da inserire nelle direttrici per estremità inclinate invisibili.",
      "In Führungslinien einzufügender Text für unsichtbare Gefälleenden.",
      "要插入到不可见坡端引线中的文本。"};

    public static readonly string[] DimOffset = {
      "Dimensions offset",
      "Отступ размеров",
      "Rientro dimensioni",
      "Abmessungen eingerückt",
      "尺寸缩进"};
    public static readonly string[] DimOffsetTip = {
      "The distance from parts or from leaders to the dimension line. \r\n" +
        "Leave the value 0 so that the program indents half the font height.",
      "Расстояние от деталей или от выносок до линии габаритных размеров. \r\n" +
        "Оставьте значение 0, чтоб программа отступила половину высоты шрифта.",
      "La distanza dalle parti o dalle direttrici alla linea di quota. \r\n" +
        "Lasciare il valore 0 in modo che il programma rientri metà dell'altezza del carattere.",
      "Der Abstand von Teilen oder Hinweislinien zur Bemaßungslinie. \r\n" +
        "Belassen Sie den Wert 0, damit das Programm die halbe Schrifthöhe einrückt.",
      "从零件或引线到尺寸线的距离。 \r\n" +
        "保留值 0，以便程序缩进一半的字体高度。"};

  }
}
