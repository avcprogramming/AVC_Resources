// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  RemHolesL
  {
    // ======================================== Command Line ======================================================
    public static readonly string[] RemHoles = {
      "Removing holes",
      "Удаление отверстий",
      "Rimozione dei fori",
      "Löcher entfernen",
      "去除孔"};
    public static readonly string[] SelectAll = {
      "Select solids to remove all round holes",
      "Выберите солиды для удаления всех круглых отверстий",
      "Seleziona i solidi per rimuovere tutti i fori rotondi",
      "Wählen Sie Volumenkörper aus, um alle runden Löcher zu entfernen",
      "选择实体以移除所有圆孔" };
    public static readonly string[] SelectSmall = {
      "Select solids to remove holes smaller than {0}",
      "Выберите солиды для удаления отверстий диаметром меньше чем {0}",
      "Seleziona i solidi per rimuovere i fori più piccoli di {0}",
      "Wählen Sie Volumenkörper aus, um Löcher zu entfernen, die kleiner als {0} sind",
      "选择实体以移除小于 {0} 的孔" };
    public static readonly string[] SelectDrill = {
      "Select solids for removal of drills (according to CNC settings)",
      "Выберите солиды для удаления сверлений (по настройкам ЧПУ)",
      "Selezionare i solidi per la rimozione delle punte (in base alle impostazioni del CNC)",
      "Festkörper zum Entfernen von Bohrern auswählen (je nach CNC-Einstellungen)",
      "选择要去除钻头的实体（根据 CNC 设置）" };
    public static readonly string[] Count = {
      "Total holes removed: {0}",
      "Итого удалено отверстий: {0}",
      "Fori totali rimossi: {0}",
      "Gesamte entfernte Löcher: {0}",
      "移除的孔总数：{0}" };
    public static readonly string[] ErrRem = {
      "  Failure to remove holes in solid {0:X}: {1}",
      "  Сбой при удалении отверстий в солиде {0:X}: {1}",
      "  Mancata rimozione dei fori nel solido {0:X}: {1}",
      "  Fehler beim Entfernen von Löchern im Volumenkörper {0:X}: {1}",
      "  无法去除实体 {0:X} 中的孔：{1}" };
    public static readonly string[] MaxDiamQuery = {
      "Limit the maximum diameter of the removal hole:",
      "Ограничьте максимальный диаметр отверстия для удаления:",
      "Limitare il diametro massimo del foro di rimozione:",
      "Begrenzen Sie den maximalen Durchmesser des Entnahmelochs:",
      "限制去除孔的最大直径：" };
    public static readonly string[] InBlockQuery = {
      "Removing solid holes in blocks?",
      "Удалять отверстия солидов в блоках?",
      "Rimozione di fori solidi nei blocchi?",
      "Feste Löcher in Blöcken entfernen?",
      "Removing solid holes in blocks?" };
    public static readonly string[] OneByOneQuery = {
      "Remove holes one at a time (slow)?",
      "Удалять отверстия по одному (медленно)?",
      "Rimuovere i fori uno alla volta (lento)?",
      "Löcher einzeln entfernen (langsam)?",
      "一次去除一个孔（慢）？" };
    public static readonly string[] Progress = {
      "Removing holes",
      "Удаляем отверстия",
      "Rimozione dei fori",
      "Löcher entfernen",
      "去除孔" };
    public static readonly string[] AllHolesKW = {
      "ALLHoles",
      "ВСЕ",
      "TUTTI",
      "ALLELöcher",
      "删除所有孔(ALLH)" };
    public static readonly string[] SmallHolesKW = {
      "SMALLHoles",
      "МАЛенькие",
      "PICcolo",
      "KLEIN",
      "去除小孔(SMALL)" };
    public static readonly string[] CNCDrillHolesKW = {
      "DRILLS",
      "СВЕРЛА",
      "TRapano",
      "BOHren",
      "钻头(DRI)" };
    public static readonly string[] MaxDiamKW = {
      "MAXDiam",
      "МАКСДиаметр",
      "DIAMametroMax",
      "MAXDurchmesser",
      "最大直径(MAXD)" };
    public static readonly string[] InBlockKW = {
      "INBlock",
      "ВБлоках",
      "INBlocco",
      "INBlock",
      "内部块(INB)" };
    public static readonly string[] OneByOneKW = {
      "1By1",
      "1За1",
      "1Per1",
      "1Von1",
      "逐个(1)" };
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

    // ======================================== Options Dialog ====================================================
    public static readonly string[] OneBy1Text = {
      "Delete 1 by 1",
      "Удалять по одному",
      "Elimina uno per uno",
      "Nacheinander löschen",
      "一一删除"};
    public static readonly string[] OneBy1Tip = {
      "Call a separate surface removal command for each hole.\r\n" +
        "This will significantly increase the running time of the program.\r\n" +
        "But in some cases, this will avoid the destruction of the solid\r\n" +
        "and the appearance of unnecessary surfaces due to glitches in AutoCAD.\r\n" +
        "This option is meaningless in BricsCAD.",
      "Вызывать отдельную команду удаления поверхности для каждого отверстия. \r\n" +
        "Это значительно увеличит время работы программы.\r\n" +
        "Но, в некоторых случаях, это позволит избежать разрушения солида\r\n" +
        "и появления лишних поверхностей из-за глюков в AutoCAD.\r\n" +
        "В BricsCAD эта опция не имеет смысла.",
      "Chiamare un comando di rimozione della superficie separato per ogni foro. \r\n" +
        "Ciò aumenterà notevolmente il tempo di esecuzione del programma.\r\n" +
        "Ma in alcuni casi, ciò eviterà la distruzione del solido\r\n" +
        "e la comparsa di superfici non necessarie a causa di problemi tecnici in AutoCAD.\r\n" +
        "Questa opzione non ha senso in BricsCAD.",
      "Rufen Sie für jedes Loch einen separaten Oberflächenentfernungsbefehl auf.\r\n" +
        "Dadurch wird die Laufzeit des Programms deutlich erhöht.\r\n" +
        "Aber in einigen Fällen wird dies die Zerstörung des Volumenkörpers \r\n" +
        "und das Auftreten unnötiger Oberflächen aufgrund von Störungen in AutoCAD vermeiden.\r\n" +
        "Diese Option ist in BricsCAD bedeutungslos.",
      "为每个孔调用一个单独的表面去除命令。\r\n" +
         "这将显着增加程序的运行时间。\r\n" +
         "但在某些情况下，这将避免由于 AutoCAD 中的故障而破坏实体和出现不必要的曲面。\r\n" +
         "此选项在 BricsCAD 中没有意义。"};
    public static readonly string[] OptionsText = {
      "Hole selection options",
      "Настройка выбора отверстий",
      "Opzioni di selezione del foro",
      "Lochauswahloptionen",
      "孔选择选项"};
    public static readonly string[] AllText = {
      "All",
      "Все",
      "Tutto",
      "Alle",
      "全部"};
    public static readonly string[] AllTip = {
      "Remove all full cylindrical holes.",
      "Удалять все полные цилиндрические отверстия.",
      "Rimuovere tutti i fori cilindrici pieni.",
      "Entfernen Sie alle vollen zylindrischen Löcher.",
      "移除所有完整的圆柱形孔。"};
    public static readonly string[] DrillsText = {
      "Drills",
      "Сверловка",
      "Trapani",
      "Bohrer",
      "演习"};
    public static readonly string[] DrillsTip = {
      "Only remove holes that are suitable for the drilling technology. \r\n" +
        "Customize the diameters of the drills available in the CNC style.",
      "Удалять только отверстия, которые подходят под технологию сверления. \r\n" +
        "Диаметры имеющихся свёрел настраивайте в стиле  ЧПУ.",
      "Rimuovere solo i fori adatti alla tecnologia di foratura. \r\n" +
        "Personalizza i diametri delle punte disponibili in stile CNC.",
      "Entfernen Sie nur Löcher, die für die Bohrtechnik geeignet sind. \r\n" +
        "Passen Sie die Durchmesser der im CNC-Stil verfügbaren Bohrer an.",
      "只去除适合钻孔技术的孔。 \r\n" +
        "自定义 CNC 样式可用的钻头直径。"};
    public static readonly string[] SmallText = {
      "Less than",
      "Меньше чем",
      "Meno di",
      "Less than",
      "少于"};
    public static readonly string[] SmallTip = {
      "Only remove holes smaller than the specified diameter.",
      "Удалять только отверстия меньше, чем заданный диаметр.",
      "Rimuovere solo i fori più piccoli del diametro specificato.",
      "Entfernen Sie nur Löcher, die kleiner als der angegebene Durchmesser sind.",
      "只能去除小于指定直径的孔。"};
    public static readonly string[] MaxDiamTip = {
      "Maximum hole diameter to be removed.",
      "Максимальный диаметр отверстия для удаления.",
      "Diametro massimo del foro da rimuovere.",
      "Maximal zu entfernender Lochdurchmesser.",
      "要移除的最大孔径。"};

  }
}
