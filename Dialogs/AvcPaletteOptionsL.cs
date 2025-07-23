// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Dwg Perim Cim

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
      "Replace Texture and Sweep property of a solid when assigning a new material. \r\n" +
        "If a material is marked as Grain|Texture, then the solid is assigned Texture = Along. \r\n" +
        "And if the material does not have a Grain|Texture, then the solid is assigned Texture = No. \r\n" +
        "If the material is marked as Sweep, the same check mark will appear on the parts. \r\n" +
        "Please note that this setting also affects the behavior of the AvcUpdate command and the color change button on the Material tab. \r\n" +
        "They will also change the solid properties Texture and Sweep.",
      "Заменять свойства Текстура и Развертка у солида при присвоении нового материала.\r\n" +
        "Если материал помечен как имеющий Зернистость|Текстура, то солиду назначается Текстура = Вдоль.\r\n" +
        "А если у материала нет текстуры, то солиду назначается Текстура = Нет.\r\n" +
        "Если материал помечен как Развертка, то такая же галочка появится и у деталей.\r\n" +
        "Обратите внимание, что эта настройка влияет так же на поведение команды AvcUpdate и кнопки замены цвета на вкладке Материал.\r\n" +
        "Они тоже будут менять у солидов свойства Текстура и Развертка. ",
      "Sostituisci le proprietà Texture e Sweep di un solido quando assegni un nuovo materiale. \r\n" +
        "Se un materiale è contrassegnato come Grana|Texture, al solido viene assegnata Texture = Lungo. \r\n" +
        "Se il materiale non ha una Grana|Texture, al solido viene assegnata Texture = No. \r\n" +
        "Se il materiale è contrassegnato come Sweep, lo stesso segno di spunta apparirà sulle parti. \r\n" +
        "Si noti che questa impostazione influisce anche sul comportamento del comando AvcUpdate e sul pulsante di cambio colore nella scheda Materiale. \r\n" +
        "Modificheranno anche le proprietà Texture e Sweep del solido.",
      "Ersetzen Sie die Textur- und Sweep-Eigenschaften eines Volumenkörpers beim Zuweisen eines neuen Materials. \r\n" +
        "Ist ein Material als Körnung/Textur gekennzeichnet, erhält der Volumenkörper die Textur „Längs“. \r\n" +
        "Ist das Material nicht als Körnung/Textur gekennzeichnet, erhält der Volumenkörper die Textur „Nein“. \r\n" +
        "Ist das Material als Sweep gekennzeichnet, erscheint das gleiche Häkchen auf den Teilen. \r\n" +
        "Beachten Sie, dass diese Einstellung auch das Verhalten des Befehls „AvcUpdate“ und der Schaltfläche „Farbänderung“ auf der Registerkarte „Material“ beeinflusst. \r\n" +
        "Sie ändern auch die Volumenkörpereigenschaften „Textur“ und „Sweep“.",
      "分配新材质时，替换实体的“纹理”和“扫掠”属性。\r\n" +
        "如果材质标记为“纹理”，则实体的“纹理”属性将被指定为“沿”。\r\n" +
        "如果材质没有“纹理”，则实体的“纹理”属性将被指定为“否”。\r\n" +
        "如果材质标记为“扫掠”，则零件上将显示相同的复选标记。\r\n" +
        "请注意，此设置还会影响 AvcUpdate 命令的行为以及“材质”选项卡上的颜色更改按钮。\r\n" +
        "它们还会更改实体的“纹理”和“扫掠”属性。" };
    public static readonly string[] SetByLayer = {
      "Set ByLayer",
      "Назначать ПоСлою",
      "Imposta DaLayer",
      "Nach VonLayer einstellen",
      "按图层设置 ByLayer" };
    public static readonly string[] SetByLayerTip = {
      "Assign color, line type, line weight, and material ByLayer when assigning a layer.",
      "Назначать цвет, тип и вес линий, материал ПоСлою, когда назначается слой",
      "Assegna colore, tipo di linea, spessore della linea e materiale DaLayer quando si assegna un layer.",
      "Weisen Sie Farbe, Linientyp, Liniengewicht und Material Nach VonLayer zu, wenn Sie eine Layer zuweisen.",
      "分配图层时，按图层分配颜色、线型、线宽和材质。" };
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
    public static readonly string[] CimNames = {
      "Router-CIM Part Names",
      "Имена деталей Router-CIM",
      "Nomi delle parti Router-CIM",
      "Router-CIM-Teilenamen",
      "部件名称“Router-CIM”" };
    public static readonly string[] CimNamesTip = {
      "Read and write to XData part names used by the Router-CIM plugin",
      "Считывать и записывать в XData имена деталей, используемые плагином Router-CIM",
      "Leggi e scrivi in XData i nomi delle parti utilizzati dal plug-in Router-CIM", 
      "Lese und schreibe in XData die von Router-CIM verwendeten Teilenamen",
      "读取和写入 XData 中 Router-CIM 插件使用的部件名称" };
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
      "Typically, the end list starts at the bottom left corner of the part and goes clockwise.\r\n" +
         "But for quad parts, you can rearrange the ends however you like.\r\n" +
         "Write a list of four numbers from 1 to 4 separated by commas.\r\n" +
         "This order only works in the Properties Palette and has no effect on substitutions.",
      "Обычно список торцев начинается с левого нижнего угла детали и далее по часовой стрелке.\r\n" +
        "Но для четырехугольных деталей вы можете переставить торцы как вам нравится.\r\n" +
        "Напишите список из четырех чисел от 1 до 4 через запятую.\r\n" +
        "Данный порядок работает только в Палитре Свойств и никак не влияет на подстановки.",
      "In genere, l'elenco finale inizia nell'angolo inferiore sinistro della parte e va in senso orario.\r\n" +
         "Ma per le parti quad, puoi riorganizzare le estremità come preferisci.\r\n" +
         "Scrivi un elenco di quattro numeri da 1 a 4 separati da virgole.\r\n" +
         "Questo ordine funziona solo nella tavolozza delle proprietà e non ha effetto sulle sostituzioni.",
      "Normalerweise beginnt die Endliste in der unteren linken Ecke des Teils und geht im Uhrzeigersinn.\r\n" +
         "Aber bei Quad-Teilen können Sie die Enden nach Belieben neu anordnen.\r\n" +
         "Schreiben Sie eine Liste mit vier Zahlen von 1 bis 4, die durch Kommas getrennt sind.\r\n" +
         "Diese Reihenfolge funktioniert nur in der Eigenschaftenpalette und hat keine Auswirkung auf Ersetzungen.",
      "通常，结束列表从零件的左下角开始，顺时针方向。\r\n" +
         "但对于四边形零件，您可以随意重新排列末端。\r\n" +
         "写一个从 1 到 4 的四个数字的列表，用逗号分隔。\r\n" +
         "此顺序仅在属性面板中有效，对替换无效。" };
    public static readonly string[] LineStyle = {
      "Line Style",
      "Стиль линий",
      "Stile della linea",
      "Linienstil",
      "线条样式"};
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
    public static readonly string[] AreaPerim = {
      "Area and perimeter",
      "Площадь и периметр",
      "Area e perimetro",
      "Fläche und Umfang",
      "面积和周长"};
    public static readonly string[] AreaPerimTip = {
      "If possible, show area and perimeter (or length). \r\n" +
        "Also enables area and length columns in the lists of solid Covers and Edges Bandings. \r\n" +
        "In the solid metric, these properties are not disabled.",
      "По возможности показывать площадь и периметр (или длину).\r\n " +
        "Так же включаются столбцы площади и длины в списках покрытий и кромок солида.\r\n" +
        "В метрике солида эти свойства не отключаются.",
      "Mostra l'area e il perimetro (o la lunghezza) quando possibile. \r\n" +
        "Abilita inoltre le colonne di area e lunghezza negli elenchi di Coperture solide e Bande di bordi.\r\n" +
        "Nella metrica solida, queste proprietà non sono disabilitate.",
      "Zeigen Sie nach Möglichkeit Fläche und Umfang (oder Länge) an. \r\n" +
        "Aktiviert außerdem Flächen- und Längenspalten in den Listen mit festen Abdeckungen und Kantenbändern.\r\n" +
        "In der soliden Metrik sind diese Eigenschaften nicht deaktiviert.",
      "尽可能显示面积和周长（或长度）。\r\n" +
        "还可以在实体覆盖和边缘带列表中启用面积和长度列。\r\n" +
        "在实体度量中，这些属性不会被禁用。"};
    public static readonly string[] LayerTip = {
      "Show drawing object layer.",
      "Показывать слой объектов чертежа.",
      "Mostra il layer degli oggetti di disegno.",
      "Zeichenobjektebene anzeigen.",
      "显示绘图对象层。"};
    public static readonly string[] ColorTip = {
      "Show color of drawing objects.",
      "Показывать цвет объектов чертежа.",
      "Mostra il colore degli oggetti del disegno.",
      "Zeigen Sie die Farbe von Zeichenobjekten an.",
      "显示绘图对象的颜色。"};
    public static readonly string[] MaterialTip = {
      "Show material for all drawing objects",
      "Показывать материал у всех объектов чертежа",
      "Mostra il materiale per tutti gli oggetti di disegno",
      "Material für alle Zeichenobjekte anzeigen",
      "显示所有绘图对象的材质"};
    public static readonly string[] VisibleTip = {
      "Show visibility checkbox for all drawing objects",
      "Показывать галочку видимости у всех объектов чертежа",
      "Mostra casella di controllo visibilità per tutti gli oggetti di disegno",
      "Kontrollkästchen Sichtbarkeit für alle Zeichnungsobjekte anzeigen",
      "显示所有绘图对象的可见性复选框"};
    public static readonly string[] OrdinaryProperties = {
      "Ordinary properties",
      "Обычные свойства",
      "Proprietà comuni",
      "Gemeinsame Eigenschaften",
      "共同属性"};
    public static readonly string[] OrdinaryPropertiesTip = {
      "Show all common properties that all objects in the drawing have. \r\n" +
          "If you disable this option, only specific properties of individual objects and AVC properties will remain in the palette.",
      "Показывать все обычные свойства, которые есть у всех объектов чертежа. \r\n" +
          "При отключении этой опции в палитре останутся только специфические свойства отдельных объектов и свойства AVC.",
      "Mostra tutte le solite proprietà di tutti gli oggetti di disegno.\r\n" +
          "Se disabiliti questa opzione, nella tavolozza rimarranno solo le proprietà specifiche dei singoli oggetti e le proprietà AVC.",
      "Zeigt alle üblichen Eigenschaften an, die alle Zeichnungsobjekte haben. \r\n" +
          "Wenn Sie diese Option deaktivieren, bleiben nur die spezifischen Eigenschaften einzelner Objekte und AVC-Eigenschaften in der Palette.",
      "显示所有绘图对象具有的所有常用属性。\r\n" +
          "如果禁用此选项，则调色板中将仅保留单个对象的特定属性和 AVC 属性。"};
    public static readonly string[] ObjectTypeTip = {
      "Show the object type in the drawing on tabs that can show different types of objects.",
      "Показывать тип объекта чертеже на вкладках, которые могут показывать разнотипные объекты.",
      "Mostra il tipo di oggetto nel disegno nelle schede che possono mostrare diversi tipi di oggetti.",
      "Zeigen Sie den Objekttyp in der Zeichnung auf Registerkarten an, auf denen verschiedene Objekttypen angezeigt werden können.",
      "在可以显示不同类型对象的选项卡上显示图形中的对象类型。"};
    public static readonly string[] CoversTip = {
      "Show a list of solid surfaces that have a coating material assigned to them \r\n" +
          "(if the solid has a metric created by the SolSize command)",
      "Показывать список поверхностей солида, \r\n" +
          "которым назначен материал покрытия (если солид имеет метрику, созданную командой SolSize)",
      "Mostra un elenco di superfici solide a cui è assegnato un materiale di rivestimento \r\n" +
          "(se il solido ha una metrica creata dal comando SolSize)",
      "Zeigt eine Liste von Volumenkörperoberflächen an, denen ein Beschichtungsmaterial zugewiesen ist \r\n" +
          "(wenn der Körper über eine durch den Befehl „SolSize“ erstellte Metrik verfügt).",
      "显示分配了涂层材料的实体表面列表（如果实体具有由 SolSize 命令创建的公制）"};
    public static readonly string[] BandingsTip = {
    "Create and display a list of coatings on the ends of the part (Edge Bandings). \r\n" +
        "If you disable this option, the solid metric creation program will not search for end surfaces \r\n" +
        "and you will not see them not only in the AVC Properties Palette, but also in tables and MLeaders.",
    "Создавать и показывать список покрытий на торцах детали (кромки). \r\n" +
        "При отключении этой опции программа создания метрики солида не будет искать торцевые поверхности \r\n" +
        "и вы не увидите их не только в Палитре Свойств, но и в таблицах и на выносках.",
    "Creare e visualizzare un elenco di rivestimenti sulle estremità di una parte. \r\n" +
        "Se disabiliti questa opzione, il programma di creazione metrica solida non cercherà le superfici finali \r\n" +
        "e non le vedrai solo nella tavolozza Proprietà, ma anche nelle tabelle e nei richiami.",
    "Erstellen Sie eine Liste der Beschichtungen an den Enden eines Teils und zeigen Sie sie an. \r\n" +
        "Wenn Sie diese Option deaktivieren, sucht das Programm zur Erstellung von Volumenmetriken nicht nach Endflächen \r\n" +
        "und Sie werden diese nicht nur in der Eigenschaftenpalette, sondern auch in Tabellen und Beschriftungen sehen.",
    "创建并显示零件末端的涂层列表。\r\n" +
        "如果禁用此选项，实体公制创建程序将不会搜索端面，\r\n" +
        "您不仅在属性选项板中看不到它们，而且在表和标注中也看不到它们。"};
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
    public static readonly string[] VirtualAttributes = {
      "Virtual block attributes",
      "Виртуальные атрибуты блоков",
      "Attributi del blocco virtuale",
      "Virtuelle Blockattribute",
      "虚拟块属性" };
    public static readonly string[] VirtualConstAttributes = {
      "Virtual constant block attributes",
      "Виртуальные константные атрибуты блоков",
      "Attributi del blocco costante virtuale",
      "Blockattribute virtueller Konstanten",
      "虚拟常量块属性" };
    public static readonly string[] VirtualAttributesTip = {
      "Always show virtual attributes in block properties, even if the block does not have them. \r\n" +
        "Write a list of one attribute per line.\r\n" +
        "You can also write the default attribute value. Write it after the equal sign, without spaces.\r\n" +
        "Not for annotative blocks.",
      "Всегда показывать в свойствах блока виртуальные атрибуты, даже если у блока их нет.\r\n" +
        "Напишите список по одному атрибуту в строке.\r\n" +
        "Можно написать так же значение атрибута по умолчанию. Пишите его после знака равно, без пробелов. \r\n" +
        "Не для аннотативных блоков.",
      "Mostra sempre gli attributi virtuali nelle proprietà del blocco, anche se il blocco non li possiede. \r\n" +
        "Scrivi un elenco di un attributo per riga.\r\n" +
        "Puoi anche scrivere il valore dell'attributo predefinito. Scrivilo dopo il segno uguale, senza spazi.\r\n" +
        "Non per i blocchi annotativi.",
      "Zeigen Sie virtuelle Attribute immer in den Blockeigenschaften an, auch wenn der Block sie nicht hat. \r\n" +
        "Schreiben Sie eine Liste mit einem Attribut pro Zeile.\r\n" +
        "Sie können auch den Standardattributwert schreiben. \r\n" +
        "Schreiben Sie es nach dem Gleichheitszeichen, ohne Leerzeichen.\r\n" +
        "Nicht für Anmerkungsblöcke.",
      "始终在块属性中显示虚拟属性，即使该块没有虚拟属性。\r\n" +
        "不适用于注释性块。\r\n" +
        "编写每行一个属性的列表。\r\n" +
        "您还可以编写默认属性值。写在等号后面，不要有空格。"};
    public static readonly string[] VirtualConstAttributesTip = {
      "Always show virtual constant attributes in block definition properties, even if the block does not have them. " +
        "Not for annotative blocks.",
      "Всегда показывать в свойствах определения блока виртуальные константные атрибуты, даже если у блока их нет. " +
        "Не для аннотативных блоков.",
      "Mostra sempre gli attributi costanti virtuali nelle proprietà di definizione del blocco, anche se il blocco non li dispone. " +
        "Non per i blocchi annotativi.",
      "Zeigen Sie virtuelle Konstantenattribute immer in den Blockdefinitionseigenschaften an, auch wenn der Block sie nicht hat. " +
        "Nicht für Anmerkungsblöcke.",
      "始终在块定义属性中显示虚拟常量属性，即使该块没有这些属性。" +
        "不适用于注释性块。"};
    public static readonly string[] UserProperties = {
      "User properties",
      "Пользовательские свойства",
      "Proprietà personalizzate",
      "Benutzerdefinierte Eigenschaften",
      "自定义属性" };
    public static readonly string[] UserPropertiesTip = {
      "Show additional properties of parts and save them in xData of drawing objects. \r\n" +
        "Write a list of one property per line. \r\n" +
        "You can also write the default property value. Write it after the equal sign, without spaces.",
      "Показывать дополнительные свойства деталей и сохранять их в xData объектов чертежа.\r\n" +
        "Напишите список по одному свойству в строке.\r\n" +
        "Можно написать так же значение свойства по умолчанию. Пишите его после знака равно, без пробелов.",
      "Mostra proprietà aggiuntive delle parti e salvale in xData degli oggetti di disegno. \r\n" +
        "Scrivi un elenco di una proprietà per riga. Puoi anche scrivere il valore della proprietà predefinito. \r\n" +
        "Scrivilo dopo il segno uguale, senza spazi.",
      "Zeigen Sie zusätzliche Eigenschaften von Teilen an und speichern Sie sie in xData von Zeichnungsobjekten. \r\n" +
        "Schreiben Sie eine Liste mit einer Eigenschaft pro Zeile. Sie können auch den Standardeigenschaftswert schreiben. \r\n" +
        "Schreiben Sie es nach dem Gleichheitszeichen, ohne Leerzeichen.",
      "显示零件的附加属性并将其保存在绘图对象的 xData 中。\r\n" +
        "每行写一个属性的列表。您还可以编写默认属性值。写在等号后面，不要有空格。" };

    public static readonly string[] DwgMaterialErr = {
      "Failed to assign default material {0}",
      "Не удалось назначить материал по-умолчанию {0}",
      "Impossibile assegnare il materiale predefinito {0}",
      "Fehler beim Zuweisen des Standardmaterials {0}.",
      "无法分配默认材质 {0}" };
    public static readonly string[] Thickness3dTip = {
      "Show 3D thickness field for all curves and polylines.",
      "Показывать поле 3д-толщины у всех кривых и полилиний.",
      "Mostra il campo dello spessore 3D per tutte le curve e le polilinee.",
      "Zeigen Sie das 3D-Dicke-Feld für alle Kurven und Polylinien an.",
      "显示所有曲线和多段线的 3D 厚度字段。" };
    public static readonly string[] PolylineWidth = {
      "Polyline Width",
      "Ширина полилинии",
      "Larghezza polilinea",
      "Polylinienbreite",
      "多段线宽度" };
    public static readonly string[] PolylineWidthTip = {
      "Show Global Width field (analogous to line weight) for polylines and 2D polylines." ,
      "Показывать поле Глобальной Ширины (аналог веса линий) у полилиний и 2D-полилиний." ,
      "Mostra il campo Larghezza globale (analogo allo spessore della linea) per polilinee e polilinee 2D." ,
      "Zeigt das Feld „Globale Breite“ (analog zur Linienstärke) für Polylinien und 2D-Polylinien an." ,
      "显示折线和二维折线的全局宽度字段（类似于线宽）。" };
  }
}
