// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  FixtureL
  {
    public static readonly string[] SelectFile = {
      "Select a file with blocks",
      "Выберите файл с блоками",
      "Seleziona un file con blocchi",
      "Wählen Sie eine Datei mit Blöcken",
      "选择带块的文件"};
    public static readonly string[] ParseError = {
      "Field {0} contains invalid value '{1}'. The old value {2} will be used.",
      "Поле {0} содержит недопустимое значение '{1}'. Будет использовано старое значение {2}.",
      "Il campo {0} contiene un valore non valido '{1}'. Verrà utilizzato il vecchio valore {2}.",
      "Feld {0} enthält einen ungültigen Wert '{1}'. Der alte Wert {2} wird verwendet.",
      "字段 {0} 包含无效值“{1}”。 将使用旧值 {2}。"};

    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI
    public static readonly string[] BlockKW = {
      "BLock",
      "БЛок",
      "BLocco",
      "BLock",
      "堵塞(BL)"};

    public static readonly string[] Searching = {
      "Searching for connections",
      "Поиск соединений",
      "Alla ricerca di connessioni",
      "Verbindungssuche",
      "搜索连接" };
    public static readonly string[] Nothing = {
      "  Nothing to fix",
      "  Нечего соединять",
      "  Non c'è niente da collegare",
      "  Nichts zu reparieren",
      "  无事可修" };
    public static readonly string[] FaceFound = {
      "Flat faces found: {0}",
      "Найдено плоских граней: {0}",
      "Trovate facce piatte: {0}",
      "Flache Gesichter gefunden: {0}",
      "发现平面：{0}"};
    public static readonly string[] ContactsFound = {
      "End-to-face contacts found: {0}",
      "Найдено контактов торец-плать: {0}",
      "Fianchi volti trovati: {0}",
      "Gefundene End-to-Surface-Kontakte: {0}",
      "找到端对面联系人：{0}"};
    public static readonly string[] Points = {
      "The points for fixtures are selected: {0}",
      "Подобрано точек установки крепежа: {0}",
      "Punti di montaggio selezionati per elementi di fissaggio: {0}",
      "Ausgewählte Befestigungspunkte für Befestigungselemente: {0}",
      "已选择灯具的点：{0}"};
    public static readonly string[] Inserting = {
      "Inserting fixtures",
      "Вставка крепежей",
      "Inserimento di fissaggio",
      "Befestigungselemente einsetzen",
      "插入夹具" };
    public static readonly string[] Checking = {
      "Checking contacts",
      "Проверка контактов",
      "Controllo dei contatti",
      "Kontaktflächen prüfen",
      "检查联系人" };
    public static readonly string[] SearchFace = {
      "Search for face contacts",
      "Поиск контактов поверхностей",
      "Cerca superfici di contatto",
      "Kontaktflächen durchsuchen",
      "搜索人脸联系人" };
    public static readonly string[] NoObj ={
      "There are no objects in the mounting block for calculating the dimensions.\n" +
        "Checking the dimensions of the block will be disabled.",
      "В блоке-крепеже нет объектов для вычисления габаритов.\n" +
        "Проверка габаритов блока будет отключена.",
      "Nel blocco di fissaggio non ci sono oggetti per il calcolo delle dimensioni.\n" +
        "Il controllo delle dimensioni del blocco sarà disabilitato",
      "Der Montageblock enthält keine Objekte zum Berechnen der Abmessungen.\n" +
        "Das Überprüfen der Abmessungen des Blocks wird deaktiviert.",
      "安装块中没有用于计算尺寸的对象。\n" +
         "检查块的尺寸将被禁用。"};
    public static readonly string[] Installed = {
      "Installed fixtures: {0}",
      "Установлено крепежей: {0}",
      "Fissaggi installati: {0}",
      "Befestigungselemente wurden installiert: {0}",
      "安装的固定装置：{0}" };
    public static readonly string[] Used = {
      "will be used for fixing",
      "будет использован для крепления",
      "sarà usato per il fissaggio",
      "wird zur Montage verwendet",
      "将用于修复" };
    public static readonly string[] BlockQuery = {
      "\n  Enter the name of the fixture-block" ,
      "\n  Введите имя блока-крепежа",
      "\n  Inserire il nome degli elementi di fissaggio",
      "\n  Geben Sie den Namen des Blocks ein",
      "\n  输入夹具块的名称"};
    public static readonly string[] NoBlock = {
      "There is no block {0} in the drawing" ,
      "В чертеже нет блока {0}",
      "Non c'è uno blocco {0} nel disegno",
      "Die Zeichnung enthält keinen Block {0}",
      "绘图中没有块 {0}"};

    // =========================================== Options: Message and Errors ============================================
    public static readonly string[] MsgMaxGap = {
      "There is a joint not suitable for the maximum gap",
      "Есть стык не подходящий под максимальный зазор",
      "C'è un giunto non adatto per il gioco massimo",
      "Es gibt ein Gelenk, das nicht für das maximale Spiel geeignet ist",
      "有一个接头不适合最大间隙。"};
    public static readonly string[] MsgEndThickness = {
      "There is a joint not suitable for the thickness of the end",
      "Есть стык не подходящий по толщине торца",
      "C'è un giunto non adatto allo spessore dell'estremità.",
      "Es gibt eine Fuge, die nicht für die Dicke des Endes geeignet ist.",
      "有一个接头不适合端部的厚度。"};
    public static readonly string[] MsgFaceThickness = {
      "There is a joint not suitable for the thickness of the face.",
      "Есть стык не подходящий по толщине плати",
      "C'è un giunto non adatto allo spessore del viso.",
      "Es gibt eine Fuge, die nicht für die Dicke des Gesichts geeignet ist.",
      "有一个关节不适合脸的厚度。"};
    public static readonly string[] MsgFaceWidthEndWidth = {
      "There is an unsuitable joint because the end is wider than the face.",
      "Есть стык не подходящий потому, что торец шире плати",
      "C'è un giunto inadatto perché l'estremità è più larga della faccia.",
      "Es liegt eine ungeeignete Fuge vor, da das Ende breiter als das Gesicht ist.",
      "有一个不合适的接头，因为末端比面部宽。"};
    public static readonly string[] MsgConnectionDirection = {
      "There is an unsuitable joint due to the limitations of the joint direction (not vertical or horizontal)",
      "Есть стык не подходящий из-за ограничений направления стыка (не вертикальный или не горизонтальный)",
      "C'è un giunto inadatto a causa delle limitazioni della direzione del giunto (non verticale o orizzontale)",
      "Aufgrund der Begrenzung der Fugenrichtung (nicht vertikal oder horizontal) liegt eine ungeeignete Fuge vor.",
      "由于接头方向（不是垂直或水平）的限制，存在不合适的接头。"};
    public static readonly string[] MsgConnectionRegion = {
      "Failed to build contact region of parts",
      "Не удалось построить регион контакта деталей",
      "Impossibile creare la regione di contatto delle parti",
      "Kontaktbereich der Teile konnte nicht erstellt werden",
      "未能建立部件的接触区域。"};
    public static readonly string[] MsgDetermineOutside = {
      "Can't determine the outside of the assembly",
      "Не удалось определить наружу сборки",
      "Impossibile determinare l'esterno dell'assieme",
      "Fehler beim Bestimmen der Außenseite der Baugruppe",
      "无法确定程序集的外部。"};
    public static readonly string[] MsgShortLine = {
      "Fixture installation line is too short",
      "Линия расстановки крепежей слишком короткая",
      "La linea di installazione del dispositivo è troppo corta",
      "Die Ausrichtungslinie des Befestigungselements ist zu kurz",
      "夹具安装线太短。"};
    public static readonly string[] MsgEndSize = {
      "The size of the end-part does not allow to install fasteners",
      "Размер детали-торца не позволяет установить крепежи",
      "La dimensione del pezzo finale non consente di installare elementi di fissaggio",
      "Die Größe des Endteils erlaubt keine Installation von Befestigungselementen",
      "端部尺寸不允许安装紧固件。"};
    public static readonly string[] MsgFaceSize = {
      "The size of the face-part does not allow to install fasteners",
      "Размер детали-плати не позволяет установить крепежи",
      "La dimensione della parte anteriore non consente di installare elementi di fissaggio",
      "Die Größe des Hauptteils erlaubt nicht die Installation von Befestigungselementen",
      "面部的尺寸不允许安装紧固件。"};
    public static readonly string[] MsgAlignmentLine = {
      "The alignment line is outside the contact region",
      "Линия расстановки вне региона контакта",
      "La linea di allineamento è al di fuori dell'area di contatto",
      "Die Ausrichtungslinie liegt außerhalb des Kontaktbereichs",
      "对准线在接触区域之外。"};
    public static readonly string[] MsgStepMinMax = {
      "It was not possible to evenly arrange the fixtures, since the minimum step is close to the maximum",
      "Не получилось равномерно расставить крепежи, так как минимальный шаг близок к максимальному",
      "Non è stato possibile disporre uniformemente i dispositivi di fissaggio, poiché il passo minimo è vicino al massimo",
      "Es war nicht möglich, die Befestigungselemente gleichmäßig anzuordnen, da die minimale Stufe nahe an der maximalen liegt",
      "不可能均匀地布置固定装置，因为最小步长接近最大步长。"};
    public static readonly string[] MsgNoFixtures = {
      "Failed to place any fixtures on connection",
      "На стыке не удалось разместить ни одного крепежа",
      "Non è stato possibile posizionare elementi di fissaggio all'incrocio.",
      "An der Abzweigung konnten keine Befestigungsmittel angebracht werden.",
      "无法在连接上放置任何固定装置"};
    public static readonly string[] MsgContactTooFar = {
      "The contact area is too far from the corners of the end-piece.",
      "Зона контакта находится слишком далеко от углов торцевой детали",
      "L'area di contatto è troppo lontana dagli angoli del pezzo finale.",
      "Die Kontaktfläche ist zu weit von den Ecken des Endstücks entfernt.",
      "接触区域离端件的角太远。"};
    public static readonly string[] MsgUniformArrangement = {
      "The minimum step coincides with the maximum - uniform arrangement of fasteners is impossible",
      "Минимальный шаг совпадает с максимальным - равномерная расстановка крепежей невозможна",
      "Il passo minimo coincide con la disposizione del massimo - uniforme degli elementi di fissaggio è impossibile",
      "Die minimale Stufe fällt mit der maximal gleichmäßigen Anordnung der Befestigungselemente zusammen",
      "最小步长与最大步长重合 - 紧固件的均匀排列是不可能的。"};
    public static readonly string[] BlockNotFound = {
      "Block not found",
      "Блок не найден",
      "Blocco non trovato",
      "Block nicht gefunden",
      "未找到块" };
    public static readonly string[] InvalidValue ={
      "Attribute {0} contains an invalid {1} value. The default value of {2} will be used.",
      "Атрибут {0} содержит недопустимое значение {1}. Будет использовано значение по умолчанию {2}.",
      "L'attributo {0} contiene un valore {1} non valido. Verrà utilizzato il valore predefinito di {2}.",
      "Das Attribut {0} enthält einen ungültigen Wert {1}. Der Standardwert {2} wird verwendet.",
      "属性 {0} 包含无效的 {1} 值。 将使用默认值 {2}。" };
    public static readonly string[] AttrPrompt = {
      "AVC_Fixture plug-in. Don't change tag and default value of this attribute",
      "Плагин Крепеж (AVC_Fixture). Не меняйте таг и значение по умолчанию этого атрибута",
      "Plugin AVC_Fixture. Non modificare tag e il valore predefinito di questo attributo",
      "AVC_Fixture plugin. Ändern Sie nicht das Tag und den Standardwert dieses Attributs",
      "AVC_Fixture 插件。 不要更改此属性的标记和默认值" };
    public static readonly string[] DepthErr = {
      "The installation depth can not be less than zero",
      "Глубина установки не может быть меньше ноля",
      "La profondità di installazione non può essere inferiore a zero",
      "Die Installationstiefe darf nicht kleiner als Null sein",
      "安装深度不能小于零" };
    public static readonly string[] FurthestErr = {
      "The Furthest fixture can not be less than zero",
      "Дальний крепеж не может быть меньше ноля",
      "Gli elementi di fissaggio più lontano non può essere inferiore a zero",
      "Der Parameter Ferne Befestigungselemente darf nicht kleiner als Null sein.",
      "最远的夹具不能小于零" };
    public static readonly string[] MaxGapErr = {
      "MaxGap can not be less than zero",
      "Максимальный зазор не может быть меньше ноля",
      "La clearance massima non può essere inferiore a zero",
      "Der maximale Abstand darf nicht kleiner als Null sein." ,
      "最大间隙不能小于零。"};
    public static readonly string[] MaxStepErr = {
      "MaxStep can not be less than zero",
      "Максимальный шаг не может быть меньше ноля",
      "Il passo massimo non può essere inferiore a zero",
      "Der maximale Schritt kann nicht kleiner als Null sein",
      "最大步长不能小于零。" };
    public static readonly string[] MinStepErr = {
      "MinStep can not be less than zero",
      "Минимальный шаг не может быть меньше ноля",
      "Il passo minimo non può essere inferiore a zero",
      "Der minimale Schritt kann nicht kleiner als Null sein",
      "最小步长不能小于零"};
    public static readonly string[] StartErr = {
      "Start position can not be less than zero",
      "Стартовый шаг не может быть меньше ноля",
      "Il passo iniziale non può essere inferiore a zero",
      "Der Startschritt kann nicht kleiner als Null sein",
      "起始位置不能小于零" };
    public static readonly string[] ThicknessErr = {
      "Thickness can not be less than zero",
      "Толщина не может быть меньше ноля",
      "Lo spessore non può essere inferiore a zero",
      "Die Dicke darf nicht kleiner als Null sein" ,
      "厚度不能小于零"};
    public static readonly string[] MinThicknessErr = {
      "Min Thickness can not be more than Max Thickness",
      "Минимальная толщина не может быть больше максимальной",
      "Lo spessore minimo non può essere maggiore del massimo",
      "Die minimale Dicke darf nicht größer als die maximale sein" ,
      "最小厚度不能大于最大厚度"};
    public static readonly string[] StepErr = {
      "The starting step can not be less than the minimum",
      "Стартовый шаг не может быть меньше минимального",
      "Il passo iniziale non può essere inferiore al minimo",
      "Der Startschritt kann nicht kleiner als das Minimum sein",
      "起始步数不能小于最小值" };
    public static readonly string[] MaxMinStepErr = {
      "The maximum step can not be less than the minimum",
      "Максимальный шаг не может быть меньше минимального",
      "Il passo massimo non può essere inferiore al minimo",
      "Der maximale Schritt kann nicht kleiner als der minimale sein" ,
      "最大步长不能小于最小步长"};
    public static readonly string[] FurthestMinStepErr = {
      "Furthest fixture can not be less than the minimum step",
      "Дальний крепеж не может быть меньше минимального шага",
      "Gli elementi di fissaggio lontani non possono essere inferiori al gradino minimo",
      "Ferne Befestigungselemente können nicht kleiner als die Mindeststufe sein",
      "最远夹具不能小于最小步长" };
    public static readonly string[] FurthestStepErr = {
      "Furthest fixture can not be less than the maximum step + start step",
      "Дальний крепеж не может быть меньше максимального шага + стартовый шаг",
      "Gli elementi di fissaggio lontani non possono essere inferiori al gradino massimo + il passo iniziale",
      "Ferne Befestigungselemente können nicht kleiner sein als der maximale Schritt + Startschritt",
      "最远夹具不能小于最大步长+起始步长" };
    public static readonly string[] MaxStep32Err = {
      "The maximum step can not be less than 32mm",
      "Максимальный шаг не может быть меньше 32мм",
      "Il passo massimo non può essere inferiore a 32mm",
      "Die maximale Steigung darf 32mm nicht unterschreiten",
      "最大步距不能小于32mm" };
    public static readonly string[] MinStep32Err = {
      "The minimum step can not be less than 32mm",
      "Минимальный шаг не может быть меньше 32мм",
      "Il passo minimo non può essere inferiore a 32mm",
      "Der Mindestabstand darf 32mm nicht unterschreiten",
      "最小步距不能小于32mm" };
    public static readonly string[] Step32Err = {
      "Precisely set step must be a multiple of 32mm",
      "Заданный шаг должен быть кратен 32мм",
      "Il passo impostato con precisione deve essere un multiplo di 32mm",
      "Der eingestellte Abstand muss ein Vielfaches von 32mm sein",
      "精确设置步长必须是32mm的倍数" };

    // ====================================== Options Dialog ==============================================================
    public static readonly string[] CopyTip = {
      "Create a copy of the selected block to save other settings",
      "Создать копию выбранного блока для сохранения других настроек",
      "Crea una copia del blocco selezionato per salvare altre impostazioni",
      "Erstellen Sie eine Kopie des ausgewählten Blocks, um andere Einstellungen zu speichern",
      "创建所选块的副本以保存其他设置"};
    public static readonly string[] DefTip = {
      "Restore default settings for this fixture",
      "Восстановить настройки по умолчанию для этого крепежа",
      "Ripristina le impostazioni predefinite per questo dispositivo",
      "Stellen Sie die Standardeinstellungen für dieses Gerät wieder her",
      "恢复此灯具的默认设置"};
    public static readonly string[] LoadTip = {
      "Load a block from the selected block library into the current drawing. \r\n" +
        "You can edit settings only for fixtures from the current file",
      "Загрузить блок из выбранной библиотеки блоков в текущий чертеж. \r\n" +
        "Редактировать настройки можно только для крепежей из текущего файла",
      "Carica un blocco dalla libreria di blocchi selezionata nel disegno corrente. \r\n" +
         "È possibile modificare le impostazioni solo per i dispositivi del file corrente",
      "Laden Sie einen Block aus der ausgewählten Blockbibliothek in die aktuelle Zeichnung. \r\n" +
         "Sie können Einstellungen nur für Fixtures aus der aktuellen Datei bearbeiten",
      "将所选块库中的块加载到当前图形中。 \r\n" +
         "您只能为当前文件中的灯具编辑设置"};
    public static readonly string[] PreviewTip = {
      "Update all block previews",
      "Обновить все иконки блоков",
      "Aggiorna tutte le anteprime dei blocchi",
      "Aktualisieren Sie alle Blockvorschauen",
      "更新所有区块预览"};
    public static readonly string[] AllBlocksText = {
      "Show all blocks",
      "Показать все блоки",
      "Mostra tutti i blocchi",
      "Alle Blöcke anzeigen",
      "显示所有块"};
    public static readonly string[] AllBlocksTip = {
      "Show in the list all the blocks from the drawing,\r\n" +
        "not only those that have the attributes of the fixture settings recorded.",
      "Показывать все блоки, какие есть в файле, а не только те, в которых есть атрибуты fix_",
      "Mostra nell'elenco tutti i blocchi del disegno, \r\n" +
        "non solo quelli che hanno gli attributi delle impostazioni di fissaggio registrati.",
      "Zeigen Sie in der Liste alle Blöcke aus der Zeichnung an, nicht nur diejenigen, \r\n" +
        "die die Attribute der Fixture-Einstellungen aufgezeichnet haben.",
      "在列表中显示绘图中的所有块，\r\n" +
        "而不仅仅是那些记录了夹具设置属性的块。"};
    public static readonly string[] CheckFixSizeText = {
      "Check block size",
      "Проверить размер блока",
      "Controlla la dimensione del blocco",
      "Blockgröße prüfen",
      "检查块大小"};
    public static readonly string[] CheckFixSizeTip = {
      "Check the overall dimensions of the solids in the fixture-block in X and Z, \r\n" +
        "so that the end-part and the face-part are larger than the block.",
      "Проверить габаритные размеры солидов в блоке-крепеже по осям X и Z, \r\n" +
        "чтоб он поместился на обеих деталях.",
      "Controllare le dimensioni complessive dei solidi nel blocco di fissaggio in X e Z, \r\n" +
        "in modo che la parte terminale e la parte frontale siano più grandi del blocco.",
      "Überprüfen Sie die Gesamtabmessungen der Festkörper im Vorrichtungsblock in X und Z, \r\n" +
        "sodass das Endteil und das Stirnteil größer als der Block sind.",
      "在 X 和 Z 方向检查夹具块中实体的整体尺寸，以便端部和面部大于块。"};
    public static readonly string[] CurLayerText = {
      "Use current layer",
      "Использовать текущий слой",
      "Usa livello corrente",
      "Aktuelle Ebene verwenden",
      "使用当前图层"};
    public static readonly string[] CurLayerTip = {
      "Use the current layer to the blocks instead of the standard Fixture layer",
      "Использовать текущий слой для вставки блоков, вместо стандартного слоя 'Крепеж'",
      "Usa il livello corrente per i blocchi invece del livello Fixture standard",
      "Verwenden Sie den aktuellen Layer für die Blöcke anstelle des Standard-Fixture-Layers",
      "使用当前层到块而不是标准的 Fixture 层"};
    public static readonly string[] IgnoreUCSText = {
      "Ignore UCS",
      "Игнорировать ПСК (UCS)",
      "Ignora l'UCS",
      "UCS ignorieren",
      "忽略 UCS"};
    public static readonly string[] IgnoreUCSTip = {
      "Check the directions of the joints and the top of the part not in the current user coordinate system, \r\n" +
        "but in the world one.",
      "Проверять направления стыков и верх детали не в текущей пользовательской системе координат, а в мировой.",
      "Controlla le direzioni dei giunti e della parte superiore della parte \r\n" +
        "non nel sistema di coordinate utente corrente, ma in quello mondiale.",
      "Überprüfen Sie die Richtungen der Verbindungen und der Oberseite des Teils \r\n" +
        "nicht im aktuellen Benutzerkoordinatensystem, sondern im Weltkoordinatensystem.",
      "检查关节和零件顶部的方向不是在当前用户坐标系中，而是在世界坐标系中。"};
    public static readonly string[] FileText = {
      "Block library file",
      "Файл с библиотекой блоков",
      "Block library file",
      "Bibliotheksdatei blockieren",
      "块库文件"};
    public static readonly string[] FileTip = {
      "Select a file to load blocks with fixtures",
      "Выберите файл для загрузки блоков с крепежами",
      "Seleziona un file per caricare i blocchi con i dispositivi",
      "Wählen Sie eine Datei aus, um Blöcke mit Vorrichtungen zu laden",
      "选择一个文件以加载带有夹具的块"};
    public static readonly string[] HorizontalText = {
      "Horizontal shelves only",
      "Только на полки",
      "Solo ripiani orizzontali",
      "Nur horizontale Regale",
      "仅限水平货架"};
    public static readonly string[] HorizontalTip = {
      "Place fasteners only if the joint line is horizontal and the joint plane is vertical.\r\n" +
        "That is, the horizontal shelf fits with its end to the vertical wall.\r\n" +
        "Suitable for arranging shelf supports.But not for the hinges on the lids.",
      "Расставлять крепежи только если линия стыка горизонтальна, а плоскость стыка вертикальна. \r\n" +
        "То есть горизонтальная полка подходит торцем к вертикальной стенке.\r\n" +
        "Используйте для расстановки полкодержателей. Но не для петель на крышки.",
      "Posizionare i fissaggi solo se la linea del giunto è orizzontale e il piano del giunto è verticale.\r\n" +
         "Cioè, la mensola orizzontale si adatta con la sua estremità alla parete verticale.\r\n" +
         "Adatto per sistemare i reggipiani. Ma non per le cerniere dei coperchi.",
      "Befestigungsmittel nur platzieren, wenn die Verbindungslinie horizontal und die Verbindungsebene vertikal ist.\r\n" +
         "Das heißt, das horizontale Regal passt mit seinem Ende an die vertikale Wand.\r\n" +
         "Geeignet zum Anordnen von Regalträgern. Nicht jedoch für die Scharniere an den Deckeln.",
      "仅当连接线水平且连接平面垂直时才放置紧固件。\r\n" +
         "也就是说，水平架子的末端适合垂直墙。\r\n" +
         "适用于安排搁板支撑。但不适用于盖子上的铰链。"};
    public static readonly string[] OnMidLineText = {
      "On mid-line",
      "Посередине",
      "Nel mezzo",
      "Mitten drin",
      "在中间"};
    public static readonly string[] OnMidLineTip = {
      "Place the fixtures in the middle of the end piece, regardless of its thickness",
      "Расставить крепежи в середине торцевой детали независимо от ее толщины",
      "Posizionare gli infissi al centro del pezzo terminale, indipendentemente dal suo spessore",
      "Platzieren Sie die Befestigungen in der Mitte des Endstücks, unabhängig von seiner Dicke",
      "将夹具放在端件的中间，无论其厚度如何"};
    public static readonly string[] RequestText = {
      "Request every time",
      "Запрашивать каждый раз",
      "Richiedi ogni volta",
      "Immer wieder anfordern",
      "每次请求"};
    public static readonly string[] RequestTip = {
      "Request block selection every time the command is called",
      "Запрашивать выбор крепежа при каждом вызове команды Fixture",
      "Richiedi la selezione del blocco ogni volta che viene chiamato il comando",
      "Fordern Sie bei jedem Aufruf des Befehls die Blockauswahl an",
      "每次调用命令时请求块选择"};
    public static readonly string[] FixedStepText = {
      "Fixed step",
      "Фиксированный шаг",
      "Passo fisso.",
      "Feste Stufe.",
      "固定间距"};
    public static readonly string[] FixedStepTip = {
      "Symmetrical spacing with equal spacing between fasteners.\r\n" +
         "The distance from the beginning of the joint to the first fastener can be increased if the pitch is 32mm.\r\n" +
         "Use this spacing method for CNC drilling only.",
      "Симметричная расстановка c одинаковым шагом между крепежами. \r\n" +
        "Расстоянием от начала стыка до первого крепежа может быть увеличено, если задан шаг 32мм.\r\n" +
        "Используйте этот способ расстановки только для сверления на ЧПУ.\r\n",
      "Disposizione simmetrica con la stessa distanza tra i dispositivi di fissaggio.\r\n" +
         "La distanza dall'inizio del giunto al primo elemento di fissaggio può essere aumentata se il passo è di 32 mm.\r\n" +
         "Utilizzare questo metodo di spaziatura solo per la foratura CNC.",
      "Symmetrische Anordnung mit gleichem Abstand zwischen den Befestigungselementen.\r\n" +
         "Der Abstand vom Fugenanfang bis zum ersten Befestigungselement kann bei einer Steigung von 32 mm vergrößert werden.\r\n" +
         "Verwenden Sie diese Abstandsmethode nur für CNC-Bohrungen.",
      "紧固件之间具有相同间距的对称布置。\r\n"+
         "如果间距为 32 毫米，则可以增加从接头开始到第一个紧固件的距离。\r\n" +
         "仅将此间距方法用于 CNC 钻孔。"};
    public static readonly string[] Step32Text = {
      "Step 32mm",
      "Шаг 32мм",
      "Passo 32mm",
      "Schritt 32mm",
      "台阶 32mm"};
    public static readonly string[] Step32Tip = {
      "Adjust the distance from the corner of the end piece \r\n" +
        "to the fixture to the nearest multiple of 32 mm",
      "Подгонять расстояние от угла торцевой детали до крепежа к ближайшему кратному 32 мм.",
      "Regolare la distanza dall'angolo dell'elemento terminale al dispositivo al multiplo più vicino di 32 mm.",
      "Stellen Sie den Abstand von der Ecke des Endstücks zur Halterung auf das nächste Vielfache von 32 mm ein.",
      "将端件角部到夹具的距离调整为最接近 32 mm 的倍数。"};
    public static readonly string[] VerticalText = {
      "Vertical joints only",
      "Только вертикальные",
      "Solo giunti verticali",
      "Nur vertikale Fugen",
      "仅垂直接头"};
    public static readonly string[] VerticalTip = {
      "Work only with joints in which the connection line is strictly vertical. \r\n" +
        "Use for door hinges.",
      "Работать только со стыками у которых линия соединения расположена строго вертикально.\r\n" +
        "Используйте для петель на дверки.",
      "Lavorare solo con giunti in cui la linea di collegamento è rigorosamente verticale.\r\n" +
         "Utilizzare per i cardini delle porte.",
      "Arbeiten Sie nur mit Fugen, bei denen die Verbindungslinie streng senkrecht verläuft.\r\n" +
         "Für Türscharniere verwenden.",
      "仅使用连接线严格垂直的接头。\r\n" +
         "用于门铰链。"};
    public static readonly string[] ConnectionText = {
      "Connection filter",
      "Отбор стыков",
      "Selezione della cucitura",
      "Nahtauswahl",
      "接缝选择"};
    public static readonly string[] ZPositionText = {
      "Z Position",
      "Положение по Z",
      "Posizione Z",
      "Z-Position",
      "Z 位置"};
    public static readonly string[] YPositionsText = {
      "Y Positions",
      "Расстановка по Y",
      "Posizioni Y",
      "Y-Positionen",
      "Y 位置"};
    public static readonly string[] GapText = {
      "If there is a gap",
      "Если есть зазор",
      "Se c'è un divario",
      "Wenn es eine Lücke gibt",
      "如果有差距"};
    public static readonly string[] ZOrientationText = {
      "Z orientation",
      "Направление Z",
      "Direzione Z",
      "Richtung Z",
      "Z方向"};
    public static readonly string[] Lb90Text = {
      "90°"};
    public static readonly string[] FurthestText = {
      "Furthest",
      "Дальний",
      "Più lontano",
      "Am weitesten",
      "最远"};
    public static readonly string[] InsertText = {
      "Insert the block into the current file to edit the settings",
      "Вставьте блок в текущий файл для редактирования настроек",
      "Inserisci il blocco nel file corrente per modificare le impostazioni",
      "Fügen Sie den Block in die aktuelle Datei ein, um die Einstellungen zu bearbeiten",
      "将块插入当前文件以编辑设置"};
    public static readonly string[] MaxEndText = {
      "Max End",
      "Max Торец",
      "Fine Mass",
      "Max Ende",
      "最大结束"};
    public static readonly string[] MaxFaceText = {
      "Max Face",
      "Max Плать",
      "Bordo Mass",
      "Max Kante",
      "最大边"};
    public static readonly string[] MaxGapText = {
      "Max Gap",
      "Max Зазор",
      "Slot Mass",
      "Max Steckplatz",
      "最大间隙"};
    public static readonly string[] MaxStepText = {
      "Max Step",
      "Max шаг",
      "Passo Mass",
      "Max Schritt",
      "最大步数"};
    public static readonly string[] MinEndText = {
      "Min End",
      "Min Торец",
      "Fine Min",
      "Min Ende",
      "最低端"};
    public static readonly string[] MinFaceText = {
      "Min Face",
      "Min Плать",
      "Bordo Min",
      "Min Kante",
      "最小边"};
    public static readonly string[] MinStepText = {
      "Min Step",
      "Min шаг",
      "Passo Min",
      "Min Schritt",
      "最小步数"};
    public static readonly string[] StartText = {
      "Start",
      "Старт",
      "Inizio",
      "Anfang",
      "开始"};
    public static readonly string[] DownwardText = {
      "Downward",
      "Вниз",
      "Verso il basso",
      "Nach unten",
      "向下"};
    public static readonly string[] DownwardTip = {
      "The Z axis of the block will be deployed closer to the direction opposite to the Z axis of the current UCS",
      "ось Z блока будет развернута ближе к направлению противоположному оси Z \r\n" +
        "текущей пользовательской системы координат (UCS). ",
      "L'asse Z del blocco verrà distribuito più vicino alla direzione opposta all'asse Z del sistema di coordinate corrente.",
      "Die Z-Achse des Blocks wird näher an der Richtung eingesetzt, \r\n" +
        "die der Z-Achse des aktuellen Koordinatensystems entgegengesetzt ist.",
      "块的 Z 轴将更靠近与当前坐标系 Z 轴相反的方向展开。"};
    public static readonly string[] InsideText = {
      "Inside",
      "Внутрь",
      "Dentro",
      "Innerhalb",
      "里面"};
    public static readonly string[] InsideTip = {
      "The Z axis of the block will be deployed towards the side of the LARGER (from the joint) part of the front panel.",
      "Ось Z блока будет развернута в сторону большей (от стыка) части фасадной панели. \r\n" +
        "Подходит для эксцентриков и большинства крепежей, которые надо разместить внутри ящика.",
      "L'asse Z del blocco sarà rivolto verso la parte più grande (dal giunto) del pannello della facciata.\r\n" +
         "Adatto per eccentrici e la maggior parte dei dispositivi di fissaggio che devono essere posizionati all'interno della scatola.",
      "Die Z-Achse des Blocks wird zum größeren (von der Fuge) Teil der Fassadenplatte gedreht.\r\n" +
         "Geeignet für Exzenter und die meisten Verbindungselemente, die in der Box platziert werden müssen.",
      "块的 Z 轴将转向立面面板的较大（从接头）部分。\r\n" +
         "适用于偏心件和大多数需要放在箱体内部的紧固件。"};
    public static readonly string[] OnEndText = {
      "On End",
      "На торце",
      "Sulla fine",
      "Am Ende",
      "最后"};
    public static readonly string[] OnEndTip = {
      "If there is a gap in the joint, the fixtures will be inserted at the end of the end piece",
      "При наличии зазора в стыке крепежи будут расставлены на конце торцевой детали",
      "Se c'è una fessura nel giunto, gli infissi verranno inseriti all'estremità del pezzo terminale",
      "Bei Fugenlücken werden die Beschläge am Ende des Endstücks eingesetzt",
      "如果接头有缝隙，夹具将插入端件的末端"};
    public static readonly string[] OnFaceText = {
      "On Face",
      "На плати",
      "Sul viso",
      "Auf Kante",
      "在脸上"};
    public static readonly string[] OnFaceTip = {
      "If there is a gap in the joint, the fixtures will be inserted on the surface of the front panel.",
      "При наличии зазора в стыке крепежи будут расставлены на плати фасадной детали.",
      "Se c'è una fessura nel giunto, i dispositivi verranno inseriti sulla superficie del pannello frontale.",
      "Bei Fugenspalt werden die Beschläge auf der Oberfläche der Frontplatte eingesetzt.",
      "如果接缝处有缝隙，夹具将插入前面板表面。"};
    public static readonly string[] OutsideText = {
      "Outside",
      "Наружу",
      "Fuori",
      "aus",
      "出去"};
    public static readonly string[] OutsideTip = {
      "The Z axis of the block will be deployed towards the side of the SMALLER \r\n" +
        "(from the joint) part of the front panel.",
      "Ось Z блока будет развернута в сторону меньшей (от стыка) части фасадной панели",
      "L'asse Z del blocco verrà dispiegato verso il lato della parte PIÙ PICCOLA (dal giunto) del pannello frontale.",
      "Die Z-Achse des Blocks wird zur Seite des KLEINEREN (vom Gelenk) Teils der Frontplatte ausgefahren.",
      "块的 Z 轴将朝向前面板的较小（从接头）部分的一侧展开。"};
    public static readonly string[] UpwardText = {
      "Upward",
      "Вверх",
      "Su",
      "Hoch",
      "向上"};
    public static readonly string[] UpwardTip = {
      "The Z axis of the block will be deployed closer to the Z direction of the current UCS",
      "Ось Z блока будет развернута ближе к направлению оси Z текущей пользовательской системы координат (UCS). ",
      "L'asse Z del blocco verrà distribuito più vicino alla direzione Z del sistema di coordinate corrente.",
      "Die Z-Achse des Blocks wird näher an der Z-Richtung des aktuellen Koordinatensystems eingesetzt.",
      "块的 Z 轴将部署得更靠近当前坐标系的 Z 方向。"};
    public static readonly string[] DepthTip = {
      "The depth of insertion of the block inside the end piece. \r\n" +
        "If 0 - fixtures will be installed on the surface of the parts.",
      "Задать глубину установки крепежа внутрь торцевой детали.\r\n" +
        "Ноль – крепеж будет установлен на поверхности деталей.",
      "La profondità di inserimento del blocco all'interno del pezzo finale. \r\n" +
         "Se 0 - i dispositivi verranno installati sulla superficie delle parti.",
      "Die Einstecktiefe des Blocks in das Endstück. \r\n" +
         "Wenn 0 - werden Vorrichtungen auf der Oberfläche der Teile installiert.",
      "块插入端块内的深度。 \r\n" +
         "如果为 0 - 固定装置将安装在零件的表面上。"};
    public static readonly string[] FurthestTip = {
      "Limit the insertion of fixtures from the corner of the end piece \r\n" +
        "to the width of the drilling machine (usually 800mm). \r\n" +
        "If the width of the machine is not enough for the entire joint,\r\n" +
        "the program will insert a maximum of fixtures from one corner\r\n" +
        "and begin to arrange the fixtures from the second.\r\n" +
        "Specify 0 to always set the fixtures from one corner to the end of the joint.",
      "Ограничить установку крепежей от угла торцевой детали до ширины сверлильного станка (обычно 800мм).\r\n" +
        "Если ширины станка не хватает для всего стыка, \r\n" +
        "то программа проставит максимум крепежей от одного угла и начнет расставлять крепежи от второго.\r\n" +
        "Задайте 0, чтоб всегда расставлять крепежи от одного угла и до конца стыка.",
      "Limitare l'inserimento dei fissaggi dall'angolo del pezzo terminale \r\n" +
        "alla larghezza della foratrice (normalmente 800mm). \r\n" +
         "Se la larghezza della macchina non è sufficiente per l'intero giunto,\r\n" +
         "il programma inserirà un massimo di apparecchi da un angolo e comincerà \r\n" +
        "a sistemare gli apparecchi dal secondo.\r\n" +
         "Specificare 0 per impostare sempre i fissaggi da un angolo all'estremità del giunto.",
      "Beschränken Sie das Einsetzen von Vorrichtungen von der Ecke des Endstücks \r\n" +
        "auf die Breite der Bohrmaschine (normalerweise 800 mm). \r\n" +
         "Wenn die Breite der Maschine nicht für die gesamte Fuge ausreicht,\r\n" +
         "das programm fügt maximal einbauten von einer ecke ein und beginnt mit \r\n" +
        "der anordnung der einbauten von der zweiten.\r\n" +
         "Geben Sie 0 an, um die Befestigungen immer von einer Ecke bis zum Ende der Verbindung zu setzen.",
      "将夹具的插入从端件的角部限制在钻孔机的宽度范围内（通常为 800mm）。 \r\n" +
         "如果机器的宽度不足以容纳整个接头，\r\n" +
         "该程序将从一个角插入最多的固定装置，并从第二个角开始排列固定装置。\r\n" +
         "指定 0 以始终将固定装置设置为从一个角到关节的末端。"};
    public static readonly string[] MaxEndTip = {
      "The maximum permissible thickness of the carcass part (end-part). \r\n" +
        "Write zero if this size does not matter.",
      "Максимально допустимая толщина детали каркаса (торцевой детали).\r\n" +
        "Пишите 0 если не надо проверять этот размер.",
      "Lo spessore massimo consentito della parte della carcassa (parte terminale). \r\n" +
         "Scrivi zero se questa dimensione non ha importanza.",
      "Die maximal zulässige Dicke des Karkassenteils (Endteil). \r\n" +
         "Schreiben Sie Null, wenn diese Größe keine Rolle spielt.",
      "胎体部分（端部）的最大允许厚度。 \r\n" +
         "如果这个大小无关紧要，请写零。"};
    public static readonly string[] MaxFaceTip = {
      "The maximum permissible thickness of the facade part. \r\n" +
        "Write zero if this size does not matter.",
      "Максимально допустимая толщина фасадной детали.\r\n" +
        "Пишите 0 если не надо проверять этот размер.",
      "Lo spessore massimo consentito della parte della facciata. \r\n" +
         "Scrivi zero se questa dimensione non ha importanza.",
      "Die maximal zulässige Dicke des Fassadenteils. \r\n" +
         "Schreiben Sie Null, wenn diese Größe keine Rolle spielt.",
      "立面部分的最大允许厚度。 \r\n" +
         "如果这个大小无关紧要，请写零。"};
    public static readonly string[] MaxGapTip = {
      "Maximum allowable clearance between parts. \r\n" +
        "Write 0 if the gap is not valid.",
      "Максимально допустимый зазор между деталями. \r\n" +
        "Пишите 0, если зазор недопустим.",
      "Gioco massimo consentito tra le parti. \r\n" +
         "Scrivi 0 se il gap non è valido.",
      "Maximal zulässiger Abstand zwischen den Teilen. \r\n" +
         "Schreiben Sie 0, wenn die Lücke nicht gültig ist.",
      "部件之间的最大允许间隙。 \r\n" +
         "如果间隙无效，则写入 0。"};
    public static readonly string[] MaxStepTip = {
      "Specifies the number of fixtures at the joint. \r\n" +
        "The program tries to arrange the fixtures evenly, \r\n" +
        "but no further than the max. step from each other. \r\n" +
        "If set to 0, the program will supply the fixtures only at the ends of the joint.",
      "Задает количество крепежей на стыке. \r\n" +
        "Программа пытается расставить крепежи равномерно, но не дальше макс. шага друг от друга.\r\n" +
        "Если задать 0, то программа поставит крепежи только по концам стыка.",
      "Specifica il numero di dispositivi in corrispondenza del giunto. \r\n" +
         "Il programma cerca di disporre gli apparecchi in modo uniforme, \r\n" +
        "ma non oltre il passo massimo l'uno dall'altro. \r\n" +
         "Se impostato a 0 il programma fornirà gli infissi solo alle estremità del giunto.",
      "Gibt die Anzahl der Befestigungen am Gelenk an. \r\n" +
         "Das Programm versucht, die Fixtures gleichmäßig anzuordnen, aber nicht weiter als den max. \r\n" +
        "Schritt voneinander entfernt.\r\n" +
         "Wenn auf 0 gesetzt, liefert das Programm die Vorrichtungen nur an den Enden der Verbindung.",
      "指定关节处的夹具数量。 \r\n" +
         "程序试图均匀地排列灯具，但彼此之间的距离不超过最大步长。\r\n" +
         "如果设置为 0，程序将只在关节的末端提供夹具。"};
    public static readonly string[] MinEndTip = {
      "The minimum permissible thickness of the carcass part (end-part). \r\n" +
        "Write zero if this size does not matter.",
      "Минимально допустимая толщина детали каркаса (торцевой детали).\r\n" +
        "Пишите 0 если не надо проверять этот размер.",
      "Lo spessore minimo consentito della parte della carcassa (parte terminale). \r\n" +
         "Scrivi zero se questa dimensione non ha importanza.",
      "Die minimal zulässige Dicke des Karkassenteils (Endteil). \r\n" +
         "Schreiben Sie Null, wenn diese Größe keine Rolle spielt.",
      "胎体部分（端部）的最小允许厚度。 \r\n" +
         "如果这个大小无关紧要，请写零。"};
    public static readonly string[] MinFaceTip = {
      "The minimum permissible thickness of the facade part. \r\n" +
        "Write zero if this size does not matter.",
      "Минимально допустимая толщина фасадной детали.\r\n" +
        "Пишите 0 если не надо проверять этот размер.",
      "Lo spessore minimo consentito della parte della facciata. \r\n" +
         "Scrivi zero se questa dimensione non ha importanza.",
      "Die minimal zulässige Dicke des Fassadenteils. \r\n" +
         "Schreiben Sie Null, wenn diese Größe keine Rolle spielt.",
      "立面部分的最小允许厚度。 \r\n" +
         "如果这个大小无关紧要，请写零。"};
    public static readonly string[] MinStepTip = {
      "Limits the distance between the fixtures and from the fixture to the edge of the joint. \r\n" +
        "You can write 0 to ignore this restriction.",
      "Ограничивает расстояние между крепежами и от крепежа до края стыка. \r\n" +
        "Можно написать 0, чтоб игнорировать это ограничение.",
      "Limita la distanza tra le attrezzature e dall'attrezzatura al bordo del giunto. \r\n" +
         "Puoi scrivere 0 per ignorare questa restrizione.",
      "Begrenzt den Abstand zwischen den Befestigungen und von der Befestigung zum Fugenrand. \r\n" +
         "Sie können 0 schreiben, um diese Einschränkung zu ignorieren.",
      "限制固定装置之间以及从固定装置到接头边缘的距离。 \r\n" +
         "你可以写 0 来忽略这个限制。"};
    public static readonly string[] BlockNameTip = {
      "The name of the selected block. \r\n" +
        "You can rename the block right here.",
      "Имя выбранного блока. Можно переименовать блок прямо тут.",
      "Il nome del blocco selezionato. \r\n" +
         "Puoi rinominare il blocco proprio qui.",
      "Der Name des ausgewählten Blocks. \r\n" +
         "Sie können den Block gleich hier umbenennen.",
      "所选块的名称。 \r\n" +
         "您可以在这里重命名该块。"};
    public static readonly string[] StartTip = {
      "The position of the first fixture from the edge of the joint. \r\n" +
        "The program tries to put at least two fasteners on the joint.\r\n" +
        "The second fastener will be installed at the same distance from the second end. \r\n" +
        "You can set 0 to place the fixture at the very end of the joint.",
      "Положение первого крепежа от края стыка.\r\n" +
        "Программа старается поставить на стык хотя бы 2 крепежа.\r\n" +
        "Второй крепеж будет установлен на том же самом расстоянии от второго конца.\r\n" +
        "Можно задать 0, чтоб разместить крепление в самом конце стыка. ",
      "La posizione del primo dispositivo dal bordo del giunto. \r\n" +
         "Il programma cerca di mettere almeno due elementi di fissaggio sul giunto.\r\n" +
         "Il secondo dispositivo di fissaggio verrà installato alla stessa distanza dalla seconda estremità. \r\n" +
         "Puoi impostare 0 per posizionare il dispositivo all'estremità del giunto.",
      "Die Position der ersten Befestigung von der Fugenkante. \r\n" +
         "Das Programm versucht, mindestens zwei Verbindungselemente an der Verbindung anzubringen.\r\n" +
         "Das zweite Befestigungselement wird im gleichen Abstand vom zweiten Ende installiert. \r\n" +
         "Sie können 0 einstellen, um das Fixture ganz am Ende des Gelenks zu platzieren.",
      "从关节边缘开始的第一个夹具的位置。 \r\n" +
         "该程序试图在接头上放置至少两个紧固件。\r\n" +
         "第二个紧固件将安装在与第二端相同的距离处。\r\n" +
         "您可以设置 0 以将夹具放置在关节的最末端。"};
    public static readonly string[] EvenNumberText = {
      "Even Number",
      "Четное количество",
      "Numero pari",
      "Gerade Zahl",
      "偶数" };
    public static readonly string[] EvenNumberTip = {
      "Choose a step to get an even number of fasteners. \r\n" +
        "This option is useful for obtaining symmetrical parts when placing non-symmetrical fasteners. \r\n" +
        "For example, for a pair of dowel-minifix.",
      "Подбирать шаг, чтоб получилось четное количество крепежей. \r\n" +
        "Опция полезна для получения симметричных деталей при расстановке несимметричных крепежей. \r\n" +
        "Например, для пары шкант-минификс.",
      "Scegli un passaggio per ottenere un numero pari di elementi di fissaggio. \r\n" +
        "Questa opzione è utile per ottenere parti simmetriche quando si posizionano fissaggi non simmetrici. \r\n" +
        "Ad esempio, per un paio di tasselli minifix.",
      "Wählen Sie einen Schritt, um eine gerade Anzahl an Verbindungselementen zu erhalten. \r\n" +
        "Diese Option ist nützlich, um beim Platzieren nicht symmetrischer Verbindungselemente symmetrische Teile zu erhalten. \r\n" +
        "Zum Beispiel für ein Paar Dübel-Minifix.",
      "选择一个步骤以获得偶数个紧固件。 \r\n" +
        "此选项对于在放置非对称紧固件时获得对称零件很有用。 \r\n" +
        "例如，对于一对定位销-minifix。" };
    public static readonly string[] MirrorText = {
      "Mirror blocks on the second half of the joint",
      "Зеркалить блоки на второй половине стыка",
      "Blocchi a specchio sulla seconda metà del giunto",
      "Spiegelklötze auf der zweiten Gelenkhälfte",
      "关节后半部分的镜面块" };
    public static readonly string[] MirrorTip = {
      "Apply the Mirror operation to the fastening blocks on the second half of the connecting line. \r\n" +
        "This option is useful for obtaining symmetrical parts when placing non-symmetrical fasteners. \r\n" +
        "For example, for a pair of dowel-minifix.",
      "Применять операцию Зеркало к крепежным блокам на второй половине линии соединения.\r\n" +
        "Опция полезна для получения симметричных деталей при расстановке несимметричных крепежей. \r\n" +
        "Например, для пары шкант-минификс.",
      "Applicare l'operazione Mirror ai blocchi di fissaggio sulla seconda metà della linea di collegamento. \r\n" +
        "Questa opzione è utile per ottenere parti simmetriche quando si posizionano fissaggi non simmetrici. \r\n" +
        "Ad esempio, per un paio di tasselli minifix.",
      "Wenden Sie den Vorgang „Spiegeln“ auf die Befestigungsblöcke in der zweiten Hälfte der Verbindungslinie an. \r\n" +
        "Diese Option ist nützlich, um beim Platzieren nicht symmetrischer Verbindungselemente symmetrische Teile zu erhalten. \r\n" +
        "Zum Beispiel für ein Paar Dübel-Minifix.",
      "对连接线后半部分的紧固块应用镜像操作。 \r\n" +
        "此选项对于在放置非对称紧固件时获得对称零件很有用。 \r\n" +
        "例如，对于一对定位销-minifix。" };
    public static readonly string[] FacePriorityText = {
      "Trim on the face part, not the end",
      "Ровнять от края плати, а не торца",
      "Tagliare sulla parte anteriore",
      "Beschneiden Sie den vorderen Teil",
      "从板的边缘而不是末端布置紧固件" };
    public static readonly string[] FacePriorityTip = {
      "Typically, the program counts a 32mm pitch from the edge of the end part. \r\n" +
        "But you can switch the program to align with the face part.\r\n" +
        "In Fixed Step mode, this option determines which part the program will try to make symmetrical. \r\n" +
        "The option makes sense only for joining offset parts.",
      "Обычно программа отсчитывает шаг 32мм от края торцевой детали. \r\n" +
        "Но вы можете переключить программу на выравнивание относительно фасадной детали. \r\n" +
        "В режиме фиксированного шага эта опция назначает какую из деталей программа будет пытаться сделать симметричной. \r\n" +
        "Опция имеет смысл только для стыковки смещенных деталей.",
      "In genere, il programma conta un passo di 32 mm dal bordo del pezzo terminale. \r\n" +
        "Ma puoi cambiare il programma per allinearlo con la parte della facciata. \r\n" +
        "In modalità Fixed Pitch, questa opzione determina quale parte il programma cercherà di rendere simmetrica. \r\n" +
        "L'opzione ha senso solo per unire parti sfalsate.",
      "Normalerweise zählt das Programm einen Abstand von 32 mm ab der Kante des Endstücks. \r\n" +
        "Sie können das Programm jedoch so umstellen, dass es sich an den Fassadenteil anpasst. \r\n" +
        "Im Fixed Pitch-Modus bestimmt diese Option, welchen Teil das Programm symmetrisch zu machen versucht. \r\n" +
        "Die Option ist nur für die Verbindung versetzter Teile sinnvoll.",
      "通常，程序会从末端零件的边缘开始计算 32 毫米的间距。\r\n" +
        "但是您可以切换程序以与脸部对齐。\r\n" +
        "在固定步骤模式下，此选项决定程序将尝试使哪一部分对称。\r\n" +
        "该选项仅对连接偏移零件有意义。" };
    public static readonly string[] LayerTip = {
      "The name of the layer where the block will be inserted. \r\n" +
        "If the layer is not specified, the Fixture layer will be used. \r\n" +
        "If the layer does not exist, it will be created.",
      "Имя слоя, куда будет вставлен блок. \r\n " +
        "Если слой не указан, то будет использован слой Крепеж \r\n" +
        "Если слоя нет, он будет создан.",
      "Il nome del layer in cui verrà inserito il blocco. \r\n" +
        "Se il layer non è specificato, verrà utilizzato il layer Fissaggio. \r\n" +
        "Se il layer non esiste, verrà creato.",
      "Der Name der Ebene, in die der Block eingefügt wird. \r\n" +
        "Wenn die Ebene nicht angegeben ist, wird die Ebene Befestigungen verwendet. \r\n" +
        "Wenn die Ebene nicht vorhanden ist, wird sie erstellt.",
      "将块插入的图层的名称。 \r\n" +
        "如果未指定图层，则将使用夹具图层。 \r\n" +
        "如果图层不存在，则会创建它。" };
  }
}
