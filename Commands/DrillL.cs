// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  DrillL
  {
    public static readonly string[] SettingsInfo = {
      "  Current settings: Gap = {0:0.####}",
      "  Текущие настройки: Зазор = {0:0.####}",
      "  Impostazioni correnti: Divario = {0:0.####}",
      "  Aktuelle Einstellungen: SPIEL = {0:0.####}",
      "  当前设置：间隙 = {0:0.####}"};
    public static readonly string[] NoSub = {
      "  Nothing to subtract. Drill command canceled",
      "  Нечего вычитать. Сверление отменено.",
      "  Non c’è niente da sottrarre. Comando di perforazione annullato",
      "  Nichts abzuziehen. Bohrbefehl abgebrochen",
      "  没有什么可减去的。 演习命令取消" };
    public static readonly string[] NoIntersections = {
      "  The holes do not intersect any detail.",
      "  Отверстия не пересекли ни одной детали.",
      "  I solidi taglienti non intersecano con nessun solido da tagliare.",
      "  Die Löcher kreuzten kein einziges Detail.",
      "  这些孔不与任何对象相交。" };
    public static readonly string[] SourceCount = {
      "  Details count: {0}. Holes count: {1}. Block-assemblies count: {2}",
      "  Найдено деталей: {0}. Дырок: {1}. Блоков-сборок: {2}",
      "  Dettagli contati: {0}. Fori contati: {1}. Conteggio blocchi: {2}",
      "  Anzahl der Details: {0}. Anzahl der Löcher: {1}. Anzahl der Blöcke: {2}",
      "  详细信息计数：{0}。 孔数量：{1}。 块数量：{2}" };
    public static readonly string[] NoHoles = {
      "  No solids in hole layer '{0}'. Drill command canceled.",
      "  Нет ни одного солида в слое отверстий '{0}'. Команда сверления отменена.",
      "  Non ci sono solidi sul layer tagliente '{0}'. Comando di perforazione annullato.",
      "  Keine Feststoffe in der LÖcherLayer '{0}'. Bohrbefehl abgebrochen.",
      "  孔图层“{0}”中没有三维实体。 演习命令取消" };
    public static readonly string[] MadeHoles = {
      "  Drills performed: {0}",
      "  Выполнено сверлений: {0}",
      "  Fori ottenuti: {0}",
      "  Bohren machen: {0}",
      "  执行钻孔：{0}" };
    public static readonly string[] SameDetail = {
      "  The same solids are selected as a part and as a hole. Matches will be excluded from selection.",
      "  Одни и те же солиды выбраны как деталь и как отверстие. Совпадения будут исключены из выбора.",
      "  Gli stessi solidi vengono selezionati come parte e come foro. Le partite saranno escluse dalla selezione.",
      "  Dieselben Volumenkörper werden als Teil und als Bohrung ausgewählt. " +
        "Spiele werden von der Auswahl ausgeschlossen."    ,
      "  选择相同的实体作为零件和孔。 匹配项将被排除在选择之外。"};
    public static readonly string[] Drilling = {
      "Drilling",
      "Сверление",
      "Perforazione",
      "Bohren",
      "钻孔" };
    public static readonly string[] SubError = {
      "Sub error. Hole more than detail. Look for very fine details. ",
      "Сбой при вычитании. Получается дырка больше детали. Поищите очень мелкие детали. ",
      "Sottrazione Errore. Si scopre che il foro è più rapido. Dettagliare meglio per dettagli molto piccoli. ",
      "Subtraktionsfehler. Es stellt sich heraus, dass das Loch detaillierter ist. " +
        "Suchen Sie nach sehr kleinen Teilen.",
      "错误! 孔大于对象。" };
    public static readonly string[] HoleError = {
      "Crash when cloning a hole solid in a block: {0}",
      "Сбой при клонировании солида-отверстия в блоке: {0}",
      "Arresto anomalo durante la clonazione di un foro solido in un blocco: {0}",
      "Absturz beim Klonen eines Loch-Volumenkörpers in einem Block: {0}",
      "克隆块中的孔实体时崩溃：{0}" };
    public static readonly string[] DrillSelect = {
      "\n Select details and holes(3dSolid) or ",
      "\n Выберите детали типа 3dSolid (в том числе присадку) или ",
      "\n Selezionare solidi taglienti e solidi da tagliare o ",
      "\n Wählen Sie Details und Löcher (3dSolid) oder ",
      "\n 选择对象（三维实体和孔）或 " };
    public static readonly string[] DetailSelect = {
      "\n Select details for subtraction or ",
      "\n Выберите детали типа 3dSolid для вычитания или " ,
      "\n Selezionare i solidi da tagliare o ",
      "\n Wählen Sie 3dSolid-Teile zum Subtrahieren aus ",
      "\n 选择对象"};
    public static readonly string[] HolesSelect = {
      "\n Select subtrahend details ",
      "\n Выберите вычитаемые детали ",
      "\n Selezionare i solidi taglienti ",
      "\n Wählen Sie abzugsfähige Details ",
      "\n 选择要减去的三维实体" };
    public static readonly string[] DeleteHolesInfo = {
      "  Hole-solids will be removed after drilling",
      "  Солиды-отверстия вне блоков будут удалены после сверления",
      "  I solidi taglienti verranno rimossi dopo la sottrazione (blocco esterne)",
      "  Loch-Volumenkörper außerhalb der Blöcke werden nach dem Bohren entfernt",
      "  钻孔后将删除孔实体" };
    public static readonly string[] SaveHolesInfo = {
      "  Hole-solids will be saved after drilling",
      "  Солиды-отверстия будут сохранены после сверления",
      "  I solidi taglienti verranno mantenuti dopo la sottrazione",
      "  Loch-Volumenkörper werden nach dem Bohren eingespart",
      "  钻孔后将保留孔实体" };
    public static readonly string[] NoHoleLayer = {
      "  Hole-layer {0} not found.\n  " +
        "Create it or use option HoleLayer to choose another layer for subtrahend solids.",
      "  Не найден слой отверстий '{0}'.\n  " +
        "Создайте его или используйте опцию ИмяСлоя, чтоб задать другой слой для вычитаемых тел.",
      "  Layer {0} non trovato.\n  " +
        "Creare layer tagliente o utilizzare l’opzione LayerTagliente per scegliere un altro layer",
      "  Lochebene {0} nicht gefunden.\n  " +
        "Erstellen Sie eine Ebene oder verwenden Sie die Option LÖcherLayer, " +
        "um eine andere Ebene für Subtrahend-Volumenkörper auszuwählen.",
      "  未找到孔图层 {0}。\n " +
         "创建孔图层或使用选项  孔图层(HoleLayer) 选择其它图层。"};
    public static readonly string[] LayerNotSpecified = {
      "The hole layer is not specified in the Drilling command settings",
      "В настройках команды Сверление не задан слой отверстий",
      "Lo strato del foro non è specificato nelle impostazioni del comando di foratura",
      "Die Lochebene ist in den Bohrbefehlseinstellungen nicht angegeben",
      "钻孔命令设置中未指定孔层" };
    public static readonly string[] AllInOne = {
      "  All solids on one layer. You need to replace the layer at hole-solids.",
      "  Все солиды на одном слое. Вы должны заменить слой у солидов-отверстий.",
      "  Tutti i solidi su un unico layer. È necessario sostituire il layer del fori",
      "  Alles fest auf einer Layer. Sie müssen die Layer an den festen Löchern ersetzen.",
      "  所有固体在一个图层上。 您需要更换孔三维实体的图层。"};
    public static readonly string[] InBlocksQuery = {
      "  Do you need to subtract from the solids inside the blocks?",
      "  Вычитать из солидов, находящихся внутри блоков?",
      "  Hai bisogno di sottrarre dai solidi all'interno dei blocchi?",
      "  Müssen Sie von den Feststoffen in den Blöcken subtrahieren?",
      "  你需要从块内的三维实体中减去吗？"};
    public static readonly string[] LayerQuery = {
      "\nEnter layer name for solid holes or '?' to enter layer name each time: ",
      "\nВведите имя слоя для солидов-отверстий или '?', чтоб вводить имя слоя каждый раз: ",
      "\nImmettere il nome del livello per i fori solidi o '?' per immettere il nome del livello ogni volta: ",
      "\nGeben Sie den Layer-Namen für feste Löcher oder „?“ ein, um den Layer-Namen jedes Mal einzugeben: ",
      "\n 输入实体孔的图层名称或“？” 每次输入图层名称："};
    public static readonly string[] GapQuery = {
      "  Enter gap value or zero",
      "  Введите значение зазора или ноль",
      "  Digitare un valore per il divario o lasciare zero",
      "  Geben Sie den Lückenwert oder Null ein",
      "  输入间隙值或零"};
    public static readonly string[] Query = { "<<Query>>", "<<Запрос>>", "<<Scegli>>", "<<Abfrage>>", "<<询问>>" };
    public static readonly string[] ZeroLayerWarning ={
      "Inadmissible to use a special layer '0' like the holes-layer",
      "Недопустимо использовать специальный слой '0' в качестве слоя отверстий",
      "È inammissibile utilizzare uno layer speciale '0' nello layer di fori",
      "Es ist nicht akzeptabel, eine spezielle Layer '0' als LÖcherLayer zu verwenden",
      "不允许使用像孔层这样的特殊层“0”"};

    // ================ Command Line options ==================================================
    public static readonly string[] GapKW = {
      "GAp",
      "Зазор",
      "Divario",
      "SPIEL",
      "间隙" };
    public static readonly string[] DeleteHolesKW = {
      "DeleteHoles",
      "УдалитьОтверстия",
      "CAncellaSolidiTaglienti",
      "ENTfernenLöcher",
      "删除孔" };
    public static readonly string[] SaveHolesKW = {
      "SaveHoles",
      "СОхранитьОтверстия",
      "SalvareSolidiTaglienti",
      "REttenLöcher",
      "保存孔" };
    public static readonly string[] HoleLayerKW = {
      "HOleLayer",
      "ИМяСлоя",
      "LayerTagliente",
      "LÖcherLayer",
      "孔图层" };
    public static readonly string[] InBlocksKW = {
      "INBlocks",
      "ВБлоках",
      "INBlocchi",
      "INBlöcken",
      "内部块" };
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI


    // ======================== Options Dialog  ===================================================
    public static readonly string[] DeleteHoles = {
      "Delete Holes",
      "Удалять 'дырки'",
      "Cancella taglienti",
      "Entfernen Löcher",
      "删除孔" };
    public static readonly string[] DeleteHolesTip = {
      "Select whether to remove solid-holes at the end of the program.\r\n" +
         "Solids inside the blocks will remain in any case.",
      "Выбелите удалять ли солиды-отверстия в конце работы программы.\r\n" +
        "Солиды внутри блоков в любом случае сохранятся.",
      "Seleziona se rimuovere i taglienti alla fine del programma.\r\n" +
         "I solidi all'interno dei blocchi rimarranno comunque.",
      "Wählen Sie aus, ob Löcher am Ende des Programms entfernt werden sollen.\r\n" +
         "Volumenkörpers in den Blöcken bleiben auf jeden Fall zurück.",
      "选择是否在程序结束时删除实体孔。无论如何设置，块内的孔实体都会保留下来。" };
    public static readonly string[] DrillBlocks = {
      "Drill inside block-assemblies",
      "Сверлить внутри блоков-сборок",
      "Praticare dei fori all'interno dei gruppi di blocchi.",
      "Bohren Sie Löcher in die Blockbaugruppen.",
      "在块组件内钻孔。" };
    public static readonly string[] DrillBlocksTip = {
      "If there are solids in the blocks, then subtract \r\n" +
        "and drill them with all holes from the model and from the blocks.\r\n" +
        "The option does not work for nested blocks.\r\n" +
        "The program will not subtract from the solids and blocks of the Holes layer.",
      "Если в блоках найдутся солиды, то вычитать и сверлить их всеми отверстиями из модели и из блоков.\r\n" +
        "Опция не работает для вложенных блоков.\r\n" +
        "Программа не будет вычитать из солидов и блоков слоя Отверстия.",
      "Se ci sono solidi nei blocchi, sottrarre e praticare tutti i fori dal modello e dai blocchi.\r\n" +
        "L'opzione non funziona per i blocchi nidificati.\r\n" +
        "Il programma non sottrarrà dai solidi e dai blocchi del layer Fori.",
      "Wenn sich in den Blöcken Feststoffe befinden, ziehen Sie sie ab \r\n" +
        "und bohren Sie sie mit allen Löchern aus dem Modell und aus den Blöcken.\r\n" +
        "Die Option funktioniert nicht für verschachtelte Blöcke.\r\n" +
        "Das Programm subtrahiert nicht von den Volumenkörpern und Blöcken der Ebene Löcher.",
      "如果块中有实体，则用模型和块中的所有孔减去并钻孔。\r\n" +
        "该选项不适用于嵌套块。\r\n" +
        "孔图层上的三维实体不会相互减去。" };
    public static readonly string[] HoleLayer = {
      "Holes layer",
      "Слой отверстий",
      "Layer Tagliente",
      "LÖcher Layer",
      "孔图层" };
    public static readonly string[] HoleLayerTip = {
      "You can enter nonstandard layer name for hole-solids",
      "В можете ввести свое имя для слоя вычитаемых солидов-отверстий (обычно 'Отверстия')",
      "È possibile immettere un nome di layer non standard per i solidi-Tagliente",
      "Sie können einen nicht standardmäßigen Layernamen für Löcher-Volumenkörpers eingeben",
      "您可以为孔三维实体输入非标准图层名称" };
    public static readonly string[] Gap = {
      "Gap",
      "Зазор",
      "Divario",
      "Spiel",
      "间隙" };
    public static readonly string[] GapTip = {
      "Gap between details.\r\n" +
        "If you set gap more than zero program will increase (inflate, swell) hole-solids before subtraction.\r\n" +
        "Use in both command DRI and GAP.\r\n" +
        "Default 0.",
      "Зазор между деталями.\r\n" +
        "Если будет больше 0, то вычитаемый солид будет увеличен на это число.\r\n" +
        "Используется обеими командами Сверловка и Зазор.\r\n" +
        "По умолчанию 0.",
      "Divario tra i dettagli.\r\n" +
        "Se si imposta uno spazio maggiore di zero, il programma aumenterà (gonfia, gonfia) \r\n" +
        "i solidi del foro prima della sottrazione.\r\n" +
        "Utilizzare in entrambi i comandi DRI e GAP.\r\n" +
        "Predefinito 0.",
      "Lücke zwischen Details.\r\n" +
        "Wenn Sie den Abstand auf mehr als Null einstellen, \r\n" +
        "wird das Programm die Locher-Volumenkörpers vor der Subtraktion erhöhen (aufblasen, anschwellen).\r\n" +
        "Verwenden Sie in beiden Befehlen DRI und GAP.\r\n" +
        "Standard 0.",
      "开孔间隙。\r\n" +
        "如果您设置的间隙大于零，程序将在减法之前增加（扩大）孔三维实体。" +
        "在命令 钻孔(DRI) 和 间隙(GAP) 中使用。" +
        "默认为 0。" };
    public static readonly string[] SaveGap = {
      "Save Gap",
      "Сохранять зазор",
      "Salva divario",
      "Spiel speichern",
      "保持间隙" };
    public static readonly string[] SaveGapTip = {
      "Maintain clearance for subsequent invocations of the command. \r\n" +
        "If you disable this option, then the gap can only be entered using the command line option, \r\n" +
        "and immediately after the command is executed, it will be reset to 0.",
      "Сохранять зазор для последующих вызовов команды. \r\n" +
        "Если отключить эту опцию, то зазор можно ввести только с помощью опции командной строки, \r\n" +
        "и сразу после выполнения команды он будет сброшен на 0.",
      "Mantenere l'autorizzazione per le successive invocazioni del comando. \r\n" +
        "Se disabiliti questa opzione, il gap può essere inserito solo utilizzando l'opzione della riga di comando e, \r\n" +
        "immediatamente dopo l'esecuzione del comando, verrà reimpostato su 0.",
      "Halten Sie die Freigabe für nachfolgende Aufrufe des Befehls aufrecht. \r\n" +
        "Wenn Sie diese Option deaktivieren, kann die Lücke nur über die Befehlszeilenoption eingegeben werden \r\n" +
        "und wird sofort nach Ausführung des Befehls auf 0 zurückgesetzt.",
      "为命令的后续调用保持许可。 \r\n" +
        "如果禁用此选项，则只能使用命令行选项输入间隙，\r\n" +
        "并在执行命令后立即将其重置为 0。" };
    public static readonly string[] HoleLayerSelection = {
      "Hole Layer Selection",
      "Выбор слоя",
      "Selezione del Layer",
      "Schichtauswahl",
      "孔层选择" };
    public static readonly string[] HoleLayerSelectionTip = {
      "Select layer for subtrahend detail (hole-solid)",
      "Выберите слой вычитаемых тел (солидов-отверстий)",
      "Seleziona il layer dei solidi del foro",
      "Wählen Sie die Ebene der subtrahierten KLocher-Volumenkörpers",
      "选择减体层（实心孔）" };
    public static readonly string[] FindingDrills = {
      "  Finding drills",
      "  Поиск отверстий",
      "  Trovare buchi",
      "  Löcher finden",
      "  搜索演习"};


  }
}
