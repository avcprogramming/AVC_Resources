// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Subobject

namespace AVC
{
  public static class 
  SmartLeaderL
  {
    //==================================== Command Line ===========================================================
    public static readonly string[] SolidTemplateKW = {
      "SolidTemplate",
      "СолидШаблон",
      "SOlidoSchema",
      "SolidMuster",
      "三维实体模板(S)" };
    public static readonly string[] BlockTemplateKW = {
      "BlockTemplate",
      "БлокШаблон",
      "BlocchiSchema",
      "BlockMuster",
      "块模板(B)" };
    public static readonly string[] OtherTemplateKW = {
      "OTherTemplate",
      "ПРочееШаблон",
      "AltroSchema",
      "ANdereMuster",
      "其他对象的模板(O)" };
    public static readonly string[] MultiObjectKW = {
      "MultiObject",
      "МногоОбъектов",
      "MultiOggetto",
      "MUltiObjekt",
      "多个对象(M)" };
    public static readonly string[] FaceOfSolidKW = {
      "FaceOfSolid",
      "ГраниТел",
      "FAcciaDiSolido",
      "Gesicht",
      "三维实体面(F)" };
    public static readonly string[] NotAnnotationKW = {
      "NotAnnotation",
      "НеАннотации",
      "NonAnnotazione",
      "KeineAnmerkung" ,
      "排除注释(N)"};
    public static readonly string[] InBlockKW = {
      "InBlock",
      "ВБлоках",
      "InBlocchi",
      "InBlöcken" ,
      "块内搜索(I)"};
    public static readonly string[] HighlightKW = {
      "Highlight",
      "ПОдсветка",
      "Evidenziare",
      "MArkieren",
      "高亮(H)" };
    public static readonly string[] DimensionFormatKW = {
      "DimensionFormat",
      "ФорматРазмеров",
      "FOrmatoDimensionale",
      "Bemaßungsformat",
      "尺寸格式(D)"};
    public static readonly string[] SolidTemplateQuery ={
      "Solid description template with substitutions. Return to default - *",
      "Формат описания солида с подстановками. Возврат к дефолту - *",
      "Modello di descrizione solido con sostituzioni. Torna ai valori predefiniti - *",
      "Volumenkörper Beschreibungsvorlage mit Substitutionen. Zurück zum Standard - *",
      "带有替换的可靠描述格式。 返回默认值 - *" };
    public static readonly string[] BlockTemplateQuery ={
      "Block description template. Use %...% for substitute attribute. Return to default - *",
      "Формат описания блока включая подстановки и атрибуты. Возврат к дефолту - *",
      "Modello di descrizione del blocco. Usa %...% per l'attributo sostitutivo. Torna ai valori predefiniti - *",
      "Blockbeschreibungsvorlage. Verwenden Sie %...% als Ersatzattribut. Zurück zum Standard - *" ,
      "块描述格式，包括替换和属性。 返回默认值 - *"};
    public static readonly string[] OtherQuery ={
      "Other objects template with substitutions. Return to default - *",
      "Формат описания прочих объектов с подстановками. Возврат к дефолту - *",
      "Modello di altri oggetti con sostituzioni. Torna ai valori predefiniti - *",
      "Vorlage für andere Objekte mit Ersetzungen. Zurück zum Standard - *",
      "用替换描述其他对象的格式。 返回默认值 - *" };
    public static readonly string[] InBlockQuery ={
      "Do find inside blocks and external references?",
      "Искать внутри блоков и внешних ссылок?",
      "Trova blocchi interni e riferimenti esterni?",
      "Finden Sie innere Blöcke und externe Referenzen?",
      "搜索内部块和外部链接？" };
    public static readonly string[] HighlightQuery ={
      "Do highlight a found object?",
      "Подсвечивать найденный объект?",
      "Evidenzia un oggetto trovato?",
      "Markieren Sie ein gefundenes Objekt?",
      "突出显示找到的对象？" };
    public static readonly string[] DimensionFormatQuery ={
      "Enter dimension format. Default - 0.#",
      "Введите формат для размеров. По-умолчанию 0.#",
      "Inserisci il formato della dimensione. Predefinito - 0. #",
      "Geben Sie ein Format für die Abmessungen ein. Standard - 0. #",
      "输入尺寸的格式。 默认 0.#" };
    public static readonly string[] OnInfo = {
      "Smart Leader ON",
      "Умные выноски включены",
      "Smart Leader Permettere",
      "Smart Leader Aktivieren",
      "启用聪明的多重引线" };
    public static readonly string[] OffInfo = {
      "Smart Leader OFF",
      "Умные выноски отключены",
      "Smart Leader Spegnere",
      "Smart Leader Deaktivieren",
      "禁用聪明的多重引线" };
    public static readonly string[] NoObject ={
      "No object under leader found",
      "Под выноской нет подходящих объектов",
      "Nessun oggetto trovato sotto la freccia",
      "Kein Objekt unter Pfeil gefunden",
      "标注箭头下没有匹配的对象" };
    public static readonly string[] NotWork ={
      "Smart Leader did not work",
      "Умная выноска не сработала",
      "Smart Leader non ha funzionato",
      "Smart Leader hat nicht funktioniert",
      "智能标注不起作用" };
    public static readonly string[] SubstitutionInfo ={
      "Substitution performed for object #{0:X} to leader #{1:X}",
      "Подстановки выполнены для объекта #{0:X} в выноске #{1:X}",
      "Sostituzioni eseguite per l'oggetto #{0: X} al leader #{1: X}",
      "Ersetzungen für Objekt #{0: X} in Führungslinien#{1: X} durchgeführt",
      "在标注 #{1:X} 中对对象 #{0:X} 进行了替换" };
    public static readonly string[] LeaderCount = {
      "Found smart leaders: {0}",
      "Найдено умных выносок: {0}",
      "Smart Leader trovati: {0}",
      "Gefundene Smart Leaders: {0}",
      "找到的智能标注：{0}" };
    public static readonly string[] NoLeader = {
      "Smart leaders not found",
      "Не найдено ни одной Умной Выноски",
      "Nessun Smart Leader trovato",
      "Keine Smart Leader gefunden",
      "未找到智能标注" };
    public static readonly string[] LeaderUpdatedCount = {
      "Updated leaders: {0}",
      "Обновлено выносок: {0}",
      "Smart Leader aggiornato: {0}",
      "Aktualisiertes durchgeführt: {0}",
      "更新的标注：{0}"};
    public static readonly string[] FailedCount = {
      "Failed to update: {0}",
      "Не удалось обновить: {0}",
      "Aggiornamento non riuscito: {0}",
      "Fehler beim Aktualisieren: {0}",
      "更新失败：{0}" };
    public static readonly string[] NoProperty ={
      "The object {0} has no required property",
      "Объект {0} не имеет запрошенных свойств",
      "L'oggetto {0} non ha proprietà richieste",
      "Das Objekt {0} hat keine erforderliche Eigenschaft",
      "对象 {0} 没有请求的属性"};
    public static readonly string[] Updating = {
      "Updating",
      "Обновление",
      "In aggiornamento",
      "Aktualisierung",
      "更新" };
    public static readonly string[] FindAll ={
      "Find all smart leader in this drawing?",
      "Найти все умные выноски в чертеже?",
      "Trova tutti gli Smart Leader in questo disegno?",
      "Finden Sie alle Smart Leader in dieser Zeichnung?",
      "查找绘图中的所有智能标注？" };
    public static readonly string[] SelectLeaders ={
      "Select smart leaders that requires to update",
      "Выберите выноски, которые надо обновить",
      "Seleziona Smart Leader che richiedono l'aggiornamento",
      "Wählen Sie Smart Leaders aus, die aktualisiert werden müssen",
      "选择要更新的标注" };
    public static readonly string[] Default ={
      "Return to the default template {0}",
      "Возврат к шаблону по умолчанию {0}",
      "Ritorna al modello predefinito {0}",
      "Kehren Sie zur Standardvorlage zurück {0}",
      "返回默认模板 {0}" };
    public static readonly string[] Activated = {
      "Smart leader activated",
      "Умная выноска активирована",
      "Smart Leader attivato.",
      "Smart Leader aktiviert.",
      "智能标注已激活" };
    public static readonly string[] Error ={
      "Error: {0}\n\nWould you like to continue updating the SmartLeaders?",
      "Ошибка: {0}\n\nПродолжить обновление выносок?",
      "Errore: {0}\n\nDesideri continuare ad aggiornare gli SmartLeader?",
      "Fehler: {0}\n\nMöchten Sie die SmartLeaders weiter aktualisieren?",
      "错误： {0}\n\n是否要继续更新标注？" };
    public static readonly string[] MultiObjectQuery ={
      "Do display a description of all the objects that are under the arrow, and not just the top one?",
      "Вывести описание всех объектов, которые окажутся под стрелкой, а не только самого верхнего?",
      "Visualizza una descrizione di tutti gli oggetti che si trovano sotto la freccia e non solo quello in alto?",
      "Zeigen Sie eine Beschreibung aller Objekte an, die sich unter dem Pfeil befinden, und nicht nur des obersten?",
      "显示箭头下方所有对象的描述，而不仅仅是顶部的对象？" };
    public static readonly string[] FaceOfSolidQuery ={
      "Do we derive the properties of sub-objects inside solids: surfaces, edges?",
      "Выводить свойства под-объектов внутри твердых тел: поверхностей, ребер?",
      "Deriviamo le proprietà dei sotto-oggetti all'interno dei solidi: superfici, bordi?",
      "Leiten wir die Eigenschaften von Unterobjekten innerhalb von Volumenkörpern ab: Oberflächen, Kanten?",
      "显示实体内部子对象的属性：面、边？" };
    public static readonly string[] NotAnnotationQuery ={
      "Do ignore all annotations and annotative blocks?",
      "Игнорировать все аннотации и аннотативные блоки?",
      "Ignora tutte le annotazioni e i blocchi annotativi?",
      "Ignorieren Sie alle Anmerkungen und Anmerkungsblöcke?",
      "忽略所有注释和注释块？" };
    public static readonly string[] ArrowPosition ={
      "Specify the arrow position for the new leader",
      "Укажите позицию стрелки для новой выноски",
      "Specifica la posizione della freccia",
      "Geben Sie die Pfeilposition an",
      "指定新标注的箭头位置" };
    public static readonly string[] TextPosition = {
      "Specify the text position",
      "Укажите позицию текста",
      "Specifica la posizione del testo",
      "Geben Sie die Textposition an",
      "指定文本位置" };
    public static readonly string[] Failed = {
      "Failed to create MLeader",
      "Не удалось создать MLeader",
      "Impossibile creare MLeader",
      "Führungslinien konnte nicht erstellt werden",
      "创建 MLeader 智能标注 失败"};
    public static readonly string[] PointsErr ={
      "To build a MLeader, you need 2 DIFFERENT points",
      "Для построения выноски требуются 2 РАЗНЫЕ точки",
      "Per costruire un MLeader, hai bisogno di 2 DIVERSI punti.",
      "Um einen Führungslinien zu erstellen, benötigen Sie 2 VERSCHIEDENE Punkte." ,
      "要构建标注，需要 2 个不同的点"};
    public static readonly string[] SwitchOn = {
      "Smart leaders are disabled in the {0} leader style.\n\rTurn on?",
      "Умные выноски отключены в стиле выносок {0}.\n\nВключить?",
      "I leader intelligenti sono disattivati ​​nello stile di leader {0}.\n\rAccendere?",
      "Intelligente Führungslinien sind im Führungsstil {0} deaktiviert.\n\rAnmachen?",
      "在标注样式 {0} 中禁用智能标注。\n\n启用？" };
    public static readonly string[] Style = {
      "Options for Smart Leaders for style {0}",
      "Настройка умных выносок для стиля {0}",
      "Opzioni per Smart Leaders per stile {0}",
      "Optionen für Smart Leaders für Stil {0}",
      "为样式 {0} 设置智能标注" };

    //======================================= Dialog Box ===================================================================

    public static readonly string[] BlinkText = {
      "Blinking highlight",
      "Мерцающая подсветка",
      "Luce lampeggiante",
      "Hintergrundbeleuchtung",
      "闪烁的背光" };
    public static readonly string[] BlinkTip = {
      "The found object will be highlighted in order to avoid errors. \r\n" +
        "You can turn it off if the blinking light prevents you.",
      "Найденный объект будет подсвечен во избежании ошибок. \r\n" +
        "Можно отключить если вам мешает моргание." ,
      "L'oggetto trovato verrà evidenziato per evitare errori. \r\n" +
        "Puoi spegnerlo se la luce lampeggiante te lo impedisce.",
      "Das gefundene Objekt wird hervorgehoben, um Fehler zu vermeiden. \r\n" +
        "Sie können es ausschalten, wenn Sie das Blinken stört.",
      "找到的对象将突出显示以避免错误。 \r\n" +
        "如果闪烁干扰您，您可以将其关闭。" };
    public static readonly string[] InBlockText = {
      "Inside blocks",
      "Искать в блоках",
      "Blocchi interni",
      "Suchen Sie in Blöcken",
      "块内搜索" };
    public static readonly string[] InBlockTip = {
      "Finding objects inside blocks and external references	",
      "Искать объекты внутри блоков и внешних ссылок",
      "Trovare oggetti all'interno di blocchi e riferimenti esterni",
      "Suche nach Objekten innerhalb von Blöcken und externen Links",
      "搜索块内的对象和外部链接" };
    public static readonly string[] MultiObjectText = {
      "Many objects",
      "Много объектов",
      "Molti oggetti",
      "Viele Objekte",
      "多个对象" };
    public static readonly string[] MultiObjectTip = {
      "Output on one leader a description of all the objects that will be under the arrow, \r\n" +
        "and not only the top one.",
      "Вывести на одной ссылке описание всех объектов, которые окажутся под стрелкой, \r\n" +
        "а не только одного самого верхнего.",
      "Emette su una guida una descrizione di tutti gli oggetti quello sarà sotto la freccia, \r\n" +
        "e non solo quella in alto.",
      "Zeigen Sie auf einem Link eine Beschreibung aller Objekte an, \r\n" +
        "die sich unter dem Pfeil befinden, und nicht nur das oberste.",
      "在一个智能标注上显示箭头下方所有对象的描述，\r\n" +
        "而不仅仅是顶部的对象。" };
    public static readonly string[] NativeText = {
      "Native search method",
      "Встроенный поиск",
      "Metodo di ricerca nativo",
      "Native Suchmethode",
      "旧搜索方法" };
    public static readonly string[] NativeTip = {
      "Use the old method of searching for objects under the leader built into the program. \r\n" +
        "The method does not allow to find many objects at once, it does not allow selecting subobjects.\r\n" +
        "The search depends on the settings of the visual style.\r\n" +
        "However, it works quickly and does not cause fatal errors.\r\n" +
        "This setting is common for all leader styles.",
      "Использовать старый метод поиска объектов под выноской, встроенный в Автокад. \r\n" +
        "Метод не позволяет находить сразу много объектов, не позволяет выбрать подобъекты. \r\n" +
        "Поиск зависит от настроек визуального стиля. \r\n" +
        "Однако работает быстро и не вызывает фатальных ошибок Автокада. Недоступно в БриксКАД. \r\n" +
        "Эта настройка общая для всех стилей выносок.",
      "Usa il vecchio metodo di ricerca di oggetti sotto il leader integrato nel programma. \r\n" +
        "Il metodo non consente di trovare molti oggetti contemporaneamente, non consente di selezionare sottooggetti.\r\n" +
        "La ricerca dipende dalle impostazioni dello stile visivo.\r\n" +
        "Tuttavia, funziona rapidamente e non causa errori irreversibili.\r\n" +
        "Questa impostazione è comune a tutti gli stili direttrice.",
      "Verwenden Sie die alte Methode zur Suche nach Objekten unter dem im Programm integrierten Leader. \r\n" +
        "Die Methode erlaubt es nicht, viele Objekte auf einmal zu finden, sie erlaubt keine Auswahl von Unterobjekten.\r\n" +
        "Die Suche hängt von den Einstellungen des visuellen Stils ab.\r\n" +
        "Aber es funktioniert schnell und verursacht keine fatalen Fehler.\r\n" +
        "Diese Einstellung gilt für alle Führungsstile.",
      "智能标注使用旧的对象搜索方法。\r\n" +
        "该方法不允许一次找到多个对象，也不允许选择子对象(块内对象)。\r\n" +
        "搜索取决于视觉风格的设置。\r\n" +
        "但是，它运行迅速，不会导致致命错误。\r\n" +
        "这种设置适用于所有领导风格。" };
    public static readonly string[] NotAnnotationsText = {
      "Not Annotations",
      "Не аннотации",
      "Non annotazioni	",
      "Nicht Anmerkungen",
      "排除注释" };
    public static readonly string[] NotAnnotationsTip = {
      "Ignore annotations under the leader.\r\n" +
        "Will be excluded: \r\n" +
        "- annotation objects (texts, multi leaders, dimensions, tables, views)\r\n" +
        "- all objects on the Annotation, Hatching, Axis, Viewport layers\r\n" +
        "- annotative blocks",
      "Игнорировать аннотации под выноской. \r\n" +
        "Будут исключены объекты аннотаций \r\n" +
        "(тексты, выноски, размеры, таблицы, виды, штриховки), \r\n" +
        "все объекты на слоях Аннотации, Штриховка, Оси, Viewport \r\n" +
        "и аннотативные блоки.",
      "Ignora le annotazioni sotto la direttrice. \r\n" +
        "Saranno esclusi:\r\n" +
        "- oggetti di annotazione (testi, multi leaders, dimensioni, tabelle, viste)\r\n" +
        "- tutti gli oggetti sui layer Annotation, Hatching, Axis, Viewport\r\n" +
        "- blocchi annotativi",
      "Anmerkungen unter der Führungslinie ignorieren.\r\n" +
        "Ausgeschlossen werden:\r\n" +
        "- Anmerkungsobjekte (Texte, MLeader, Bemaßungen, Tabellen, Ansichten),\r\n" +
        "- alle Objekte auf den Ebenen Beschriftung, Schraffur, Achse, Ansichtsfenster,\r\n" +
        "- abstrakte Blöcke",
      "忽略引线下的注释。\r\n" +
        "忽略对象：\r\n" +
        "- 注释对象（文本、标注 (MLeader)、尺寸、表格、视图），\r\n" +
        "- Annotation、Hatching、Axis、Viewport 图层上的所有对象，\r\n" +
        "- 抽象块" };
    public static readonly string[] OnText = {
      "Enable Smart Leader",
      "Включить Умные Выноски",
      "Abilita Smart Leader",
      "Aktivieren Sie Smart Leader",
      "启用聪明的多重引线" };
    public static readonly string[] OnTextTip = {
      "Enable search for objects under MLeader of this style when creating and editing MLeader. \r\n" +
        "If the option is disabled, then the search and substitution program will not be launched automatically \r\n" +
        "by the _MLD command and when the MLeader are moved.",
      "Выключить поиск объектов под выносками этого стиля при создании и редактировании выносок. \r\n" +
        "Если опция отключена, то программа поиска и подстановки \r\n" +
        "не будет запускаться автоматически по команде _MLD и при перемещениях выносок.",
      "Abilita la ricerca di oggetti in Multi Leader \r\n" +
        "di questo stile durante la creazione e la modifica di Multi Leader. \r\n" +
        "Se l'opzione è disabilitata, il programma di ricerca \r\n" +
        "e sostituzione non verrà avviato automaticamente \r\n" +
        "dal comando _MLD e quando si sposta la Multi Leader.",
      "Aktivieren Sie die Suche nach Objekten unter Multi-Führungslinien dieses Stils, \r\n" +
        "wenn Sie Multi-Führungslinien erstellen und bearbeiten. \r\n" +
        "Wenn die Option deaktiviert ist, \r\n" +
        "wird das Such- und Substitutionsprogramm nicht automatisch durch den Befehl _MLD \r\n" +
        "und beim Verschieben der Multi-Leader gestartet.",
      "创建和编辑多引线时启用在此样式的多引线下搜索对象。 \r\n" +
        "如果禁用该选项，则搜索和替换程序将不会由 _MLD \r\n" +
        "命令自动启动，并且在移动多引线时不会自动启动。" };
    public static readonly string[] StyleTip = {
      "Select MultiLeader style to configure it. \r\n" +
        "Use command  _MLeaderStyle to add or delete style.",
      "Стиль мультивыноски. \r\n" +
        "Используйте для быстрого переключения всех настроек сразу. \r\n" +
        "Добавить и удалить стиль в этом окне нельзя. \r\n" +
        "Используйте команду  _MLeaderStyle",
      "Seleziona lo stile MultiLeader per configurarlo. \r\n" +
        "Utilizza il comando _MLeaderStyle per aggiungere o eliminare lo stile.",
      "Wählen Sie den MultiLeader-Stil aus, um ihn zu konfigurieren. \r\n" +
        "Verwenden Sie den Befehl _MLeaderStyle, um Stile hinzuzufügen oder zu löschen.",
      "选择 MultiLeader 多重引线样式进行配置。 \r\n" +
        "使用命令 _MLeaderStyle 多重引线样式管理器 添加或删除样式。" };
    public static readonly string[] SubobjectText = {
      "Face of solid",
      "Поверхности тел",
      "Faccia di solido",
      "Gesicht von 3D-Körper",
      "实体面" };
    public static readonly string[] SubobjectTip = {
      "Output properties of subobjects: surfaces, edges, vertices of solid.\r\n" +
        "Each face of the solid can have its own color, material, area and perimeter.\r\n" +
        "The rest of the properties will be taken as usual from the solid.\r\n" +
        "Use this option for mark materials of coating, edges, etc.",
      "Выводить свойства подобъектов: \r\n" +
        "поверхностей, ребер, вершин солида. \r\n" +
        "Каждая грань солида может иметь собственные цвет, материал, площадь и периметр.\r\n" +
        "Остальные свойства будут взяты как обычно у солида. \r\n" +
        "Используйте для маркировки материалов покрытия, кромок и т.п.",
      "Proprietà di output dei suboggetti: superfici, bordi, vertici del solido.\r\n" +
        "Ciascuna faccia del solido può avere il proprio colore, materiale, area e perimetro.\r\n" +
        "Il resto delle proprietà verrà preso come al solito dal solido.\r\n" +
        "Utilizzare questa opzione per contrassegnare materiali di rivestimento, bordi, ecc.",
      "Eigenschaften von Unterobjekten anzeigen: \r\n" +
        "Flächen, Kanten, solide Scheitelpunkte. \r\n" +
        "Jede Fläche eines Solids kann ihre eigene Farbe, Material, Fläche und Umfang haben, \r\n" +
        "die restlichen Eigenschaften werden wie gewohnt vom Solid übernommen. \r\n" +
        "Zum Markieren von Beschichtungsmaterialien, Kanten etc.",
      "显示对象的属性：面、边、实体顶点。 \r\n" +
        "三维实体的每个面都可以有自己的颜色、材质、面积和周长。\r\n" +
        "其余属性将照常取自实体。 \r\n" +
        "用于标记涂层材料、边缘等。" };
    public static readonly string[] SeparatorText = {
      "Separator",
      "Разделитель",
      "Separatore",
      "Separator",
      "分隔符" };
    public static readonly string[] SeparatorItems3 = {
      " and ",
      " и ",
      " e ",
      " und ",
      "和" };
    public static readonly string[] SeparatorTip = {
      "Select which symbol to insert between the descriptions of objects \r\n" +
        "when several objects are found under the leader",
      "Выберите из списка или введите символ, \r\n" +
        "который надо вставлять между описаниями объектов, когда найдено несколько объектов под выноской. \r\n" +
        "/P - это символ переноса строки. \r\n" +
        "Не забудьте про необходимые символы пробела.",
      "Seleziona dall'elenco o inserisci un carattere, \r\n" +
         "da inserire tra le descrizioni degli oggetti quando si trovano più oggetti sotto il MultiLeader.\r\n" +
         "/P è il carattere di interruzione di riga. \r\n" +
         "Non dimenticare i caratteri spaziali necessari.",
      "Wählen Sie aus der Liste aus oder geben Sie ein Zeichen ein, \r\n" +
        "das zwischen Funktionsbeschreibungen eingefügt werden soll, \r\n" +
        "wenn mehrere Funktionen unter der Legende gefunden werden. \r\n" +
        "/P ist das Zeilenumbruchzeichen. \r\n" +
        "Vergessen Sie nicht die erforderlichen Leerzeichen.",
      "当在智能标注下找到多个特征时，\r\n" +
        "从列表中选择或输入要在特征描述之间插入的字符。 \r\n" +
        "/P 是换行符。 \r\n" +
        "不要忘记所需的空格字符。" };
    public static readonly string[] BlockTip = {
      "Template for block. \r\n" +
        "You can use the attributes and parameters of the block. \r\n" +
        "Write the name (tag) of the attribute or parameter within the characters '%'.",
      "Шаблон для блоков. \r\n" +
        "Кроме обычных подстановок вы можете использовать атрибуты и параметры блока.\r\n" +
        "Напишите имя (тег) атрибута или параметра внутри символов %.",
      "Modello per blocco. \r\n" +
        "È possibile utilizzare gli attributi e i parametri del blocco. \r\n" +
        "Scrivi il nome (tag) dell'attributo o del parametro all'interno dei caratteri '%'.",
      "Vorlage für Block. \r\n" +
        "Sie können die Attribute und Parameter des Blocks verwenden. \r\n" +
        "Schreiben Sie den Namen (Tag) des Attributs oder Parameters innerhalb der Zeichen '%'.",
      "块模板。 \r\n" +
         "可以使用块的属性和参数。\r\n" +
        "将属性或参数的名称（标记）写在字符‘%’内。" };
    public static readonly string[] OtherToolTip = {
      "Template for all other objects.",
      "Шаблон для всех остальных объектов.",
      "Modello per tutti gli altri oggetti.",
      "Vorlage für alle anderen Objekte.",
      "所有其他对象的模板。" };
    public static readonly string[] SolidTip = {
      "String for formatting MultiLeader text for solids.\r\n" +
         "May contain any substitutions of 3d-solid and drawing properties.",
      "Строка для форматирования текста выноски для солидов.\r\n" +
        "Может содержать любые подстановки свойств 3d-солида и чертежа.",
      "Stringa per la formattazione del testo del MultiLeader per i solidi.\r\n" +
         "Può contenere eventuali sostituzioni di proprietà del solido 3d e del progetto.",
      "Zeichenfolge zum Formatieren von MultiLeader-Text für Volumenkörper.\r\n" +
         "Kann beliebige Ersetzungen von 3D-Festkörper- und Blaupausen-Eigenschaften enthalten.",
      "三维实体智能标注文本的字符串。\r\n" +
         "包含三维实体和绘图属性的任何替换。" };
    public static readonly string[] FormatText = {
      "Default format for",
      "Формат по умолчанию для",
      "Formato predefinito per	",
      "Das Standardformat für",
      "默认格式" };
    public static readonly string[] FormatToolTip = {
      "These formats will be used if you type '?' or leave the leader empty.",
      "Эти форматы будут использованы если вы введете '?' или если вы оставите выноску пустой.",
      "Questi formati verranno utilizzati se digiti '?' o lasciare vuoto il MultiLeader.",
      "Diese Formate werden verwendet, wenn Sie '?' oder wenn Sie das MultiLeader leer lassen.",
      "如果您输入“？”，将使用这些格式。 或者如果您将标注留空。" };

    public static readonly string[] DialogTitle = {
      "Smart Leader Options",
      "Настройки Умных Выносок",
      "Opzioni di Leader Intelligente",
      "Intelligenter Führungslinie-Optionen",
      "智能标注。设置选项"};
  }
}
