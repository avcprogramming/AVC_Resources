// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Dwg

namespace AVC
{
  /// <summary>
  /// Локализация диалога AvcPaletteOptionBox
  /// </summary>
  public static class
  AvcPaletteOptionsL
  {
    public static readonly string[] Tabs = {
      "Tabs",
      "Вкладки",
      "Schede",
      "Tabs",
      "选项卡" };
    public static readonly string[] PaletteDwgAlways = {
      "Always show Dwg",
      "Всегда показывать DWG",
      "Mostra sempre Dwg",
      "DWG immer anzeigen",
      "始终显示 DWG"};
    public static readonly string[] DwgAlwaysTip = {
      "Always show DWG file properties even if nothing is selected.",
      "Всегда показывать свойства файла DWG, даже если ничего не выбрано.",
      "Mostra sempre le proprietà del file DWG anche se non è selezionato nulla.",
      "DWG-Dateieigenschaften immer anzeigen, auch wenn nichts ausgewählt ist.",
      "即使未选择任何内容，也始终显示 DWG 文件属性。" };
    public static readonly string[] BlockMetricTip = {
      "Show block metric attributes as separate block properties.",
      "Показывать атрибуты метрики блока как отдельные свойства блока.",
      "Mostra gli attributi della metrica del blocco come proprietà del blocco separate.",
      "Blockmetrik-Attribute als separate Blockeigenschaften anzeigen.",
      "将块度量属性显示为单独的块属性。" };
    public static readonly string[] EntitiesTip = {
      "Show general properties of all entities (layer and color) on a separate tab.",
      "Показывать общие свойства всех прмитивов чертежа (слой и цвет) на отдельной закладке.",
      "Mostra le proprietà generali di tutti gli oggetti di disegno (livello e colore) in una scheda separata.",
      "Zeigen Sie gemeinsame Eigenschaften aller Zeichenelemente (Layer und Farbe) auf einer separaten Registerkarte an.",
      "在单独的选项卡上显示所有绘图图元（图层和颜色）的通用属性。" };
    public static readonly string[] CurvesTip = {
      "Show tabs with curve properties",
      "Показывать закладки со свойствами кривых",
      "Mostra pagine con le proprietà della curva",
      "Registerkarten mit Kurveneigenschaften anzeigen",
      "显示具有曲线属性的选项卡" };
    public static readonly string[] AnnotationsTip = {
      "Show tabs with annotation properties",
      "Показывать закладки со свойствами аннотаций",
      "Mostra pagine con proprietà di annotazione",
      "Lesezeichen mit Anmerkungseigenschaften anzeigen",
      "显示带有注释属性的书签" };
    public static readonly string[] KindTip = {
      "Show the Kind (Type, Sort) property for all drawing entities (%kind% substitution). \r\n" +
        "This property is convenient to use for generic names of parts, such as “Shelf”, “Rib”. \r\n" +
        "Unlike the Name property, there is a drop-down list with all used values.",
      "Показывать свойство Сорт (Тип) у всех примитивов чертежа (подстановка %kind%). \r\n" +
        "Это свойство удобно использовать для обобщенных названий деталей, таких как \"Полка\", \"Ребро\". \r\n" +
        "В отличие от свойства Имя тут есть выпадающий список со всеми использованными значениями.",
      "Mostra la proprietà Tipo (Kind, Ordina) per tutte le entità di disegno (sostituzione %kind%). \r\n" +
        "Questa proprietà è comoda da utilizzare per nomi generici di parti, come \"Mensola\", \"Rib\". \r\n" +
        "A differenza della proprietà Nome, è presente un elenco a discesa con tutti i valori utilizzati.",
      "Zeigt die Eigenschaft „Kind“ (Typ, Sortierung) für alle Zeichnungselemente an (%kind% Ersetzung). \r\n" +
        "Diese Eigenschaft lässt sich bequem für allgemeine Namen von Teilen verwenden, z. B. „Shelf“ oder „Rib“. \r\n" +
        "Im Gegensatz zur Name-Eigenschaft gibt es eine Dropdown-Liste mit allen verwendeten Werten.",
      "显示所有绘图实体的种类（类型、排序）属性（%kind% 替换）。 \r\n" +
        "此属性可方便地用于零件的通用名称，例如架子或肋骨。\r\n" +
        "与“名称”属性不同，有一个包含所有使用值的下拉列表。" };
    public static readonly string[] InfoTip = {
      "Show Description or Comments property",
      "Показывать свойство Описание или Комментарии",
      "Mostra la proprietà Descrizione",
      "Eigenschaftsbeschreibung und Kommentare anzeigen",
      "显示属性描述和评论" };
    public static readonly string[] BasePointTip = {
      "Show BasePoint property",
      "Показывать свойство Базовая точка",
      "Mostra proprietà 'Punto base'",
      "Eigenschaft 'Basispunkt' anzeigen",
      "显示属性“基点”" };
    public static readonly string[] HyperlinkTip = {
      "Show Hyperlink property",
      "Показывать свойство Ссылка",
      "Mostra proprietà Hyperlink",
      "Hyperlink-Eigenschaft anzeigen",
      "显示超链接属性" };
    public static readonly string[] EvalExpressions = {
      "Calculate expressions",
      "Вычислять выражения",
      "Calcola espressioni",
      "Ausdrücke auswerten",
      "评估表达式" };
    public static readonly string[] EvalExpressionsTip = {
      "Attempts to calculate mathematical expressions in all attributes and custom properties of a drawing.\r\n" +
        "The result of the calculation is formatted as length. Calculation error messages are displayed on the command line.\r\n"+
        "Regardless of this setting, expressions are calculated in the Density, Price, Size and block parameters.",
      "Пытаться вычислять математические выражения во всех атрибутах и пользовательских свойствах чертежа.\r\n" +
        "Результат вычисления форматируется как длина.\r\n" +
        "Сообщения об ошибках вычисления выводятся в командную строку.\r\n" +
        "Независимо от этой настройки вычисляются выражения в свойствах\r\n" +
        "Плотность, Цена, Размеры и в параметрах блоков.",
      "Tentativi di calcolare espressioni matematiche in tutti gli attributi e le proprietà personalizzate di un disegno.\r\n" +
        "Il risultato del calcolo è formattato come lunghezza.\r\n" +
        "I messaggi di errore di calcolo vengono visualizzati sulla riga di comando.\r\n" +
        "Indipendentemente da questa impostazione, le espressioni vengono calcolate nei parametri\r\n" +
        "Densità, Prezzo, Dimensioni e blocco.",
      "Versuchen Sie, mathematische Ausdrücke in allen Attributen und benutzerdefinierten Zeichnungseigenschaften\r\n" +
        "zu berechnen. Das Ergebnis der Berechnung wird als Länge formatiert.\r\n" +
        "Berechnungsfehlermeldungen werden auf der Befehlszeile ausgegeben.\r\n" +
        "Unabhängig von dieser Einstellung werden Eigenschaftsausdrücke ausgewertet.\r\n" +
        "Dichte, Preis, Abmessungen und in Blockparametern.",
      "尝试计算所有属性和自定义图纸属性中的数学表达式。 计算结果被格式化为长度。 \r\n" +
        "计算错误消息打印到命令行。 无论此设置如何，都会评估属性表达式。 密度、价格、尺寸和块内参数。" };
    public static readonly string[] ColorByMaterial = {
      "Color by Material",
      "Цвет по материалу",
      "Imposta colore per materiale",
      "Farbe nach Material",
      "按材质着色" };
    public static readonly string[] ColorByMaterialTip = {
      "Replace the color of the object when assigning a new material.\r\n" +
        "An indexed color similar to the 'diffuse' RGB color of the material will be used.\r\n" +
        "If the color of the material is 'inherited' from the solid (= ByObject),\r\n" +
        "then the solid colors will not be marked for this material.\r\n" +
        "If the material color is ByLayer or ByBlock, then the color will be assigned ByLayer/ByBlock.\r\n" +
        "Please note that this setting also affects the behavior of the AvcUpdate command -\r\n" +
        "it will also change the solid colors to match the color of the material.\r\n" +
        "When this option is enabled, the button for updating the solid color appears \r\n" +
        "in the Material panel header.",
      "Заменять цвет объекта при присвоении нового материала.\r\n" +
        "Будет использован индексированный цвет похожий на 'дифузный' RGB-цвет материала.\r\n" +
        "Если цвет материала 'унаследован' от солида (Inherited = ByObject),\r\n" +
        "то для такого материала не будет замены цвета солидов.\r\n" +
        "Если цвет материала По Слою или По Блоку (ByLayer, ByBlock),\r\n" +
        "то и цвет будет присвоен ByLayer/ByBlock.\r\n" +
        "Обратите внимание, что эта настройка влияет так же на поведение команды AvcUpdate -\r\n" +
        "она тоже будет менять цвета солидов под цвет материала.\r\n" +
        "При включенной опции в заголовке панели Материал появляется кнопка обновления цвета солидов.",
      "Sostituisci il colore dell'oggetto quando assegna un nuovo materiale.\r\n" +
        "Verrà utilizzato un colore indicizzato simile al colore RGB 'diffuso' del materiale.\r\n" +
        "Se il colore del materiale è 'ereditato' dal solido (= PerOggetto),\r\n" +
        "i colori solidi non verranno contrassegnati per questo materiale.\r\n" +
        "Se il colore del materiale è PerLayer o PerBlocco, il colore verrà assegnato PerLayer/PerBlocco.\r\n" +
        "Si noti che questa impostazione influisce anche sul comportamento del comando AvcUpdate:\r\n" +
        "cambierà anche i colori solidi in modo che corrispondano al colore del materiale.\r\n" +
        "Quando questa opzione è abilitata, nell'intestazione del pannello Materiale\r\n" +
        "viene visualizzato il pulsante per l'aggiornamento della tinta unita.",
      "Ersetzen Sie die Farbe des Objekts, wenn Sie ein neues Material zuweisen.\r\n" +
        "Es wird eine indizierte Farbe ähnlich der „diffusen“ RGB-Farbe des Materials verwendet.\r\n" +
        "Wenn die Farbe des Materials vom Solid (= ByObject) 'geerbt' wird, dann werden die Solid-Farben\r\n" +
        "für dieses Material nicht markiert. Wenn die Materialfarbe VonLayer oder VonBlock ist,\r\n" +
        "wird die Farbe VonLayer/VonBlock zugewiesen. Bitte beachten Sie, dass diese Einstellung auch das Verhalten\r\n" +
        "des AvcUpdate-Befehls beeinflusst – es ändert auch die Volltonfarben, um sie an die Farbe des Materials anzupassen.\r\n" +
        "Wenn diese Option aktiviert ist, wird die Schaltfläche zum Aktualisieren der Volltonfarbe in der Kopfzeile\r\n" +
        " es Materialbedienfelds angezeigt.",
      "指定新材质时替换对象的颜色。 将使用类似于材质的“漫反射”RGB 颜色的索引颜色。 \r\n" +
        "如果材质的颜色是从纯色“继承”的（= ByObject），则不会为该材质标记纯色。 如果材质颜色为 ByLayer 或 ByBlock，\r\n" +
        "则颜色将分配为 ByLayer/ByBlock。 请注意，此设置也会影响 AvcUpdate 命令的行为 - 它还会更改纯色以匹配材质的颜色。\r\n" +
        " 启用此选项后，用于更新纯色的按钮会出现在“材质”面板标题中。"};
    public static readonly string[] TextureByMaterial = {
      "Texture by Material",
      "Текстура по материалу",
      "Texture per materiale",
      "Textur nach Material",
      "材质纹理" };
    public static readonly string[] TextureByMaterialTip = {
      "Replace the Texture property of a solid when assigning a new material." +
        "If a material is marked as Grain|Texture, then the solid is assigned Texture = Along." +
        "And if the material does not have a Grain|Texture, then the solid is assigned Texture = No." +
        "Please note that this setting also affects the behavior of the AvcUpdate command and the color change button on the Material tab." +
        "They will also change the texture of the solids.",
      "Заменять свойство Текстура у солида при присвоении нового материала." +
        "Если материал помечен как имеющий Зернистость|Текстура, то солиду назначается Текстура = Вдоль." +
        "А если у материала нет текстуры, то солиду назначается Текстура = Нет." +
        "Обратите внимание, что эта настройка влияет так же на поведение команды AvcUpdate и кнопки замены цвета на вкладке Материал." +
        "Они тоже будут менять текстуру солидов.",
      "Sostituisci la proprietà Texture di un solido quando assegni un nuovo materiale. " +
        "Se un materiale è contrassegnato come dotato di Grano|Struttura, al solido viene assegnato Texture = Lungo. " +
        "E se il materiale non ha Grano|Struttura, al solido viene assegnato Texture = Nessuna. " +
        "Tieni presente che questa impostazione influisce anche sul comportamento del comando AvcUpdate " +
        "e del pulsante di sostituzione del colore nella scheda Materiale. " +
        "Cambieranno anche la consistenza dei solidi.",
      "Ersetzen Sie die Textureigenschaft eines Volumenkörpers, wenn Sie ein neues Material zuweisen. " +
        "Wenn ein Material als „Maserung|Textur“ gekennzeichnet ist, wird dem Volumenkörper „Textur = Entlang“ zugewiesen. " +
        "Und wenn das Material keine Maserung|Textur aufweist, wird dem Volumenkörper Textur = None zugewiesen. " +
        "Bitte beachten Sie, dass diese Einstellung auch das Verhalten des AvcUpdate-Befehls " +
        "und der Schaltfläche zum Ersetzen von Farben auf der Registerkarte „Material“ beeinflusst. " +
        "Sie verändern auch die Textur der Feststoffe.",
      "分配新材质时替换实体的纹理属性。 " +
        "如果材质被标记为具有颗粒，则实体将被指定为纹理 = 沿。 " +
        "如果材质没有 “Grain”（颗粒），则实体将被指定为 “Texture”（纹理）= “None”（无）。 " +
        "请注意，此设置还会影响 AvcUpdate 命令和“材质”选项卡上的颜色替换按钮的行为。 " +
        "它们还会改变固体的质地。" };
    public static readonly string[] CreateIndex = {
      "Create Index",
      "Создавать индекс",
      "Crea indici",
      "Index erstellen",
      "创建索引" };
    public static readonly string[] CreateIndexTip = {
      "Automatically create unique indexes for materials and replace duplicate indexes.",
      "Автоматически создавать уникальные индексы материалам и заменять дублирующиеся индексы.",
      "Crea automaticamente indici univoci per nuovi materiali e sostituisci gli indici duplicati.",
      "Erstellen Sie automatisch eindeutige Indizes für neue Materialien und ersetzen Sie doppelte Indizes.",
      "自动为新材料创建唯一索引并替换重复索引。" };
    public static readonly string[] ZoomObj = {
      "Zoom Model",
      "Зуммировать модель",
      "Modello zoom",
      "Zoom-Modell" ,
      "缩放模型"};
    public static readonly string[] ZoomObjTip = {
      "Zoom model to selected objects. \r\n" +
        "Zooming is triggered by double clicking on the tab title and when searching for objects by one of the properties.",
      "Показать найденные объекты во весь экран. \r\n" +
        "Зуммирование срабатывает по двойному клику на заголовок вкладки и при поиске объектов по одному из свойств.",
      "Mostra gli oggetti trovati a schermo intero. \r\n" +
        "Lo zoom viene attivato facendo doppio clic sul titolo della scheda e durante la ricerca di oggetti da una delle proprietà.",
      "Im Modellbereich gefundene Objekte im Vollbildmodus anzeigen. \r\n" +
        "Das Zoomen wird durch einen Doppelklick auf den Tab-Titel und bei der Suche nach Objekten über eine der Eigenschaften ausgelöst.",
      "全屏显示在模型空间中找到的对象。\r\n" +
        "双击选项卡标题以及按属性之一搜索对象时会触发缩放。" };
    public static readonly string[] HighlightTip = {
      "Highlight surfaces and edges of a solid when moving the mouse over their properties on the Solid Metrics tab",
      "Подсветить поверхности и кромки солида при движении мыши над их свойствами на закладке Метрика солида",
      "Evidenziare le superfici e gli spigoli di un solido quando si sposta il mouse sulle relative proprietà nella scheda Metriche solidi",
      "Heben Sie Oberflächen und Kanten eines Volumenkörpers hervor, wenn Sie die Maus über deren Eigenschaften auf der Registerkarte „Volumenkörpermetriken“ bewegen",
      "将鼠标移到“实体度量”选项卡上实体的属性上时，突出显示实体的表面和边缘。" };
    public static readonly string[] HideImage = {
      "Hide extra buttons",
      "Скрыть лишние кнопки",
      "Hide extra buttons",
      "Zusätzliche Schaltflächen ausblenden",
      "隐藏额外按钮" };
    public static readonly string[] HideImageTip = {
      "Remove pictures from unused palette tab switching buttons. \r\n" +
        "Extra tab buttons are never removed so that all buttons are always in their place.",
      "Убирать картинки с неиспользованных кнопок переключения вкладок палитры. \r\n" +
        "Лишние кнопки вкладок никогда не удаляются, чтоб все кнопки всегда были на своих местах.",
      "Rimuovi le immagini dai pulsanti di commutazione delle schede della tavolozza inutilizzati. \r\n" +
        "I pulsanti delle schede extra non vengono mai rimossi in modo che tutti i pulsanti siano sempre al loro posto.",
      "Entfernen Sie Bilder von nicht verwendeten Schaltflächen zum Wechseln der Palettenregisterkarten. \r\n" +
        "Zusätzliche Tabulatorschaltflächen werden niemals entfernt, sodass alle Schaltflächen immer an ihrem Platz sind.",
      "从未使用的调色板选项卡切换按钮中删除图片。 \r\n" +
        "额外的选项卡按钮永远不会被删除，因此所有按钮始终位于其位置。" };
    public static readonly string[] KeepFocus = {
      "Keep focus",
      "Сохранять фокус ввода",
      "Mantieni il focus attivo",
      "Behalten Sie den Eingabefokus bei",
      "保持输入焦点" };
    public static readonly string[] KeepFocusTip = {
      "When you move the mouse pointer from the panel to the drawing, \r\n" +
        "text input from the keyboard will continue to flow into the field on the panel,\r\n" +
        "and not into the command line.",
      "При переносе указателя мыши с панели на чертеж,\r\n" +
        "ввод текста с клавиатуры продолжит поступать в поле на панели,\r\n" +
        "а не в командную строку.",
      "Quando si sposta il puntatore del mouse dal pannello al disegno,\r\n" +
        "l'immissione di testo dalla tastiera continuerà a fluire nel campo \r\n" +
        "sul pannello e non nella riga di comando.",
      "Wenn Sie den Mauszeiger von einem Panel zu einer Zeichnung bewegen,\r\n" +
        " fließt die Tastatureingabe weiterhin in ein Feld im Panel und nicht in die Befehlszeile.",
      "将鼠标指针从面板移动到图形时，键盘输入将继续流入面板上的字段而不是命令行。" };
    public static readonly string[] DwgReader = {
      "Read entire drawing",
      "Считывать весь чертеж",
      "Leggi l'intero disegno",
      "Lesen Sie die gesamte Zeichnung",
      "阅读整张图" };
    public static readonly string[] DwgReaderTip = {
      "Read all drawing objects immediately after opening the file and at each modification to display values faster in the palette. \r\n" +
        "The same list of objects is used as in the Drawing Tree. \r\n" +
        "In the settings of the Drawing Tree, you can enable background measurement of solids. \r\n" +
        "Reading occurs in small portions at times of idle time of the program, but slight brakes are possible. \r\n" +
        "Measuring solids sometimes causes AutoCAD to crash.",
      "Прочитать все объекты чертежа сразу после открытия файла и при каждой модификации, \r\n" +
        "чтоб быстрее отображать значения в палитре. \r\n" +
        "Используется тот же список объектов, что и в Дереве Чертежа. \r\n" +
        "В настройках Дерева Чертежа можно включить фоновый обмер солидов. \r\n" +
        "Чтение происходит маленькими порциями в моменты простоя программы, но возможны небольшие тормоза. \r\n" +
        "Обмер солидов иногда приводит к фатальным сбоям AutoCAD.",
      "Leggi tutti gli oggetti di disegno subito dopo l'apertura del file \r\n" +
        "e ad ogni modifica per visualizzare più velocemente i valori nella tavolozza. \r\n" +
        "Viene utilizzato lo stesso elenco di oggetti dell'Albero di disegno. \r\n" +
        "Nelle impostazioni dell'Albero di disegno, \r\n" +
        "è possibile abilitare la misurazione dello sfondo dei solidi. \r\n" +
        "La lettura avviene in piccole porzioni nei momenti di inattività del programma, \r\n" +
        "ma sono possibili leggere frenate. \r\n" +
        "La misurazione dei solidi a volte causa l'arresto anomalo di AutoCAD.",
      "Lesen Sie alle Zeichnungsobjekte sofort nach dem Öffnen der Datei und bei jeder Änderung, \r\n" +
        "um Werte schneller in der Palette anzuzeigen. \r\n" +
        "Es wird die gleiche Objektliste wie im Zeichnungsbaum verwendet. \r\n" +
        "In den Einstellungen des Zeichnungsbaums können Sie die Hintergrundmessung von Volumenkörpern aktivieren. \r\n" +
        "Das Lesen erfolgt in kleinen Portionen während der Leerlaufzeit des Programms, \r\n" +
        "leichte Verzögerungen sind jedoch möglich. \r\n" +
        "Das Messen von Volumenkörpern führt manchmal zum Absturz von AutoCAD.",
      "打开文件后以及每次修改时立即读取所有绘图对象，以便在调色板中更快地显示值。 \r\n" +
        "使用与绘图树中相同的对象列表。 \r\n" +
        "在绘图树的设置中，您可以启用实体的背景测量。 \r\n" +
        "读取发生在程序空闲时间的小部分，但轻微的制动是可能的。 \r\n" +
        "测量实体有时会导致 AutoCAD 崩溃。" };
    public static readonly string[] NewMaterial = {
      "New material",
      "Новый материал",
      "Nuovo materiale",
      "Neues Material",
      "新材料" };
    public static readonly string[] NewMaterialTip = {
      "When new solid materials are introduced, the material will be assigned this purpose (type of use)",
      "При вводе новых материалов солидов, материалу будет присвоено это предназначение (тип использования)",
      "Quando verranno introdotti nuovi materiali solidi, al materiale verrà assegnato questo scopo (tipo di utilizzo)",
      "Bei Einführung neuer Feststoffe wird dem Material dieser Zweck (Verwendungsart) zugeordnet",
      "当引入新的固体材料时，该材料将被分配这个用途（使用类型）"};
    public static readonly string[] EdgeOrder = {
      "Edge order",
      "Порядок кромок",
      "Ordine di bordo",
      "Randreihenfolge",
      "边缘顺序" };
    public static readonly string[] EdgeOrderTip = {
      "Typically, the end list starts at the bottom left corner of the part and goes clockwise." +
         "But for quad parts, you can rearrange the ends however you like." +
         "Write a list of four numbers from 1 to 4 separated by commas." +
         "This order only works in the Properties Palette and has no effect on substitutions.",
      "Обычно список торцев начинается с левого нижнего угла детали и далее по часовой стрелке." +
        "Но для четырехугольных деталей вы можете переставить торцы как вам нравится." +
        "Напишите список из четырех чисел от 1 до 4 через запятую." +
        "Данный порядок работает только в Палитре Свойств и никак не влияет на подстановки.",
      "In genere, l'elenco finale inizia nell'angolo inferiore sinistro della parte e va in senso orario." +
         "Ma per le parti quad, puoi riorganizzare le estremità come preferisci." +
         "Scrivi un elenco di quattro numeri da 1 a 4 separati da virgole." +
         "Questo ordine funziona solo nella tavolozza delle proprietà e non ha effetto sulle sostituzioni.",
      "Normalerweise beginnt die Endliste in der unteren linken Ecke des Teils und geht im Uhrzeigersinn." +
         "Aber bei Quad-Teilen können Sie die Enden nach Belieben neu anordnen." +
         "Schreiben Sie eine Liste mit vier Zahlen von 1 bis 4, die durch Kommas getrennt sind." +
         "Diese Reihenfolge funktioniert nur in der Eigenschaftenpalette und hat keine Auswirkung auf Ersetzungen.",
      "通常，结束列表从零件的左下角开始，顺时针方向。" +
         "但对于四边形零件，您可以随意重新排列末端。" +
         "写一个从 1 到 4 的四个数字的列表，用逗号分隔。" +
         "此顺序仅在属性面板中有效，对替换无效。" };
    public static readonly string[] LineStyle = {
      "Line Style",
      "Стиль линий",
      "Stile linea",
      "Linienstil",
      "线条样式" };
    public static readonly string[] LineStyleTip = {
      "Show Line Type, Line Scale, and Line Weight for all curves. \r\n" +
        "On the Layer tab, these properties will be shown in any case.",
      "Показывать у всех кривых тип линий, масштаб линий и вес линий. \r\n" +
        "На вкладке Слой эти свойства будут показаны в любом случае.",
      "Mostra tipo di linea, scala di linea e spessore di linea per tutte le curve. \r\n" +
        "Nella scheda Layer, queste proprietà verranno comunque mostrate.",
      "Linientyp, Linienskalierung und Linienstärke für alle Kurven anzeigen. \r\n" +
        "Auf der Registerkarte Layer werden diese Eigenschaften in jedem Fall angezeigt.",
      "显示所有曲线的线型、线比例和线宽。 \r\n" +
        "在“图层”选项卡上，这些属性在任何情况下都会显示。" };
    public static readonly string[] TransparencyTip = {
      "Show the Transparency property for all drawing primitives",
      "Показывать свойство Прозрачность у всех примитивов чертежа",
      "Mostra la proprietà Trasparenza per tutte le primitive di disegno",
      "Zeigt die Transparenzeigenschaft für alle Zeichnungsgrundelemente an",
      "显示所有绘图基元的透明度属性" };
    public static readonly string[] PlotStyleNameTip = {
      "In drawings with print style control (not by color scheme), \r\n" +
        "show the Print Style property for all drawing primitives",
      "В чертежах со стилевым управлением печатью (не по цветовой схеме) \r\n" +
        "показывать свойство Стиль Печати у всех примитивов чертежа",
      "Nei disegni con controllo dello stile di stampa (non per combinazione di colori), \r\n" +
        "mostra la proprietà Stile di stampa per tutte le primitive di disegno",
      "Zeigen Sie in Zeichnungen mit Druckstilsteuerung (nicht nach Farbschema) \r\n" +
        "die Eigenschaft „Druckstil“ für alle Zeichnungsgrundelemente an",
      "在具有打印样式控制（不按配色方案）的绘图中，\r\n" +
        "显示所有绘图基元的打印样式属性" };
    public static readonly string[] TabHistory = {
      "Use tab history",
      "Использовать историю вкладок",
      "Utilizza la cronologia delle schede",
      "Verwenden Sie den Tab-Verlauf",
      "使用标签历史记录" };
    public static readonly string[] TabHistoryTip = {
      "Save the history of switching palette tabs to show the user the most recently used tab. \r\n" +
        "If the option is disabled, the first available tab will be opened.",
      "Сохранять историю переключения вкладок палитры, чтоб показывать пользователю недавно использованную вкладку. \r\n" +
        "Если опция отключена, то будет открыта первая доступная вкладка.",
      "Salva la cronologia dei cambi di scheda della tavolozza per mostrare all'utente la scheda utilizzata più di recente. \r\n" +
        "Se l'opzione è disabilitata, verrà aperta la prima scheda disponibile.",
      "Speichern Sie den Verlauf des Wechsels der Palettenregisterkarten, \r\n" +
        "um dem Benutzer die zuletzt verwendete Registerkarte anzuzeigen. \r\n" +
        "Wenn die Option deaktiviert ist, wird die erste verfügbare Registerkarte geöffnet.",
      "保存切换调色板选项卡的历史记录，以向用户显示最近使用的选项卡。 \r\n" +
        "如果禁用该选项，将打开第一个可用选项卡。" };
  }
}
