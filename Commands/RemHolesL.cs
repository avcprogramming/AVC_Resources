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
      "去除孔",
      "Eliminando agujeros",                           // ES
      "Suppression des trous",                         // FR
      "Delikleri kaldırma"};                           // TR

    public static readonly string[] SelectAll = {
      "Select solids to remove all round holes",
      "Выберите солиды для удаления всех круглых отверстий",
      "Seleziona i solidi per rimuovere tutti i fori rotondi",
      "Wählen Sie Volumenkörper aus, um alle runden Löcher zu entfernen",
      "选择实体以移除所有圆孔",
      "Seleccione sólidos para eliminar todos los agujeros redondos",  // ES
      "Sélectionnez les solides pour supprimer tous les trous ronds",  // FR
      "Tüm yuvarlak delikleri kaldırmak için katıları seçin" };  // TR

    public static readonly string[] SelectSmall = {
      "Select solids to remove holes smaller than {0}",
      "Выберите солиды для удаления отверстий диаметром меньше чем {0}",
      "Seleziona i solidi per rimuovere i fori più piccoli di {0}",
      "Wählen Sie Volumenkörper aus, um Löcher zu entfernen, die kleiner als {0} sind",
      "选择实体以移除小于 {0} 的孔",
      "Seleccione sólidos para eliminar agujeros menores que {0}",  // ES
      "Sélectionnez les solides pour supprimer les trous inférieurs à {0}",  // FR
      "{0}'dan küçük delikleri kaldırmak için katıları seçin" };  // TR

    public static readonly string[] SelectDrill = {
      "Select solids for removal of drills (according to CNC settings)",
      "Выберите солиды для удаления сверлений (по настройкам ЧПУ)",
      "Selezionare i solidi per la rimozione delle punte (in base alle impostazioni del CNC)",
      "Festkörper zum Entfernen von Bohrern auswählen (je nach CNC-Einstellungen)",
      "选择要去除钻头的实体（根据 CNC 设置）",
      "Seleccione sólidos para eliminación de taladros (según la configuración CNC)",  // ES
      "Sélectionnez les solides pour la suppression des perçages (selon les paramètres CNC)",  // FR
      "Delme kaldırma için katıları seçin (CNC ayarlarına göre)" };  // TR

    public static readonly string[] Count = {
      "Total holes removed: {0}",
      "Итого удалено отверстий: {0}",
      "Fori totali rimossi: {0}",
      "Gesamte entfernte Löcher: {0}",
      "移除的孔总数：{0}",
      "Total de agujeros eliminados: {0}",            // ES
      "Total des trous supprimés : {0}",              // FR
      "Kaldırılan toplam delik: {0}" };               // TR

    public static readonly string[] ErrRem = {
      "  Failure to remove holes in solid {0:X}: {1}",
      "  Сбой при удалении отверстий в солиде {0:X}: {1}",
      "  Mancata rimozione dei fori nel solido {0:X}: {1}",
      "  Fehler beim Entfernen von Löchern im Volumenkörper {0:X}: {1}",
      "  无法去除实体 {0:X} 中的孔：{1}",
      "  Error al eliminar agujeros en el sólido {0:X}: {1}",  // ES
      "  Échec de la suppression des trous dans le solide {0:X} : {1}",  // FR
      "  {0:X} katısındaki delikleri kaldırma hatası: {1}" };  // TR

    public static readonly string[] MaxDiamQuery = {
      "Limit the maximum diameter of the removal hole:",
      "Ограничьте максимальный диаметр отверстия для удаления:",
      "Limitare il diametro massimo del foro di rimozione:",
      "Begrenzen Sie den maximalen Durchmesser des Entnahmelochs:",
      "限制去除孔的最大直径：",
      "Limite el diámetro máximo del agujero de eliminación:",  // ES
      "Limitez le diamètre maximum du trou de suppression :",  // FR
      "Kaldırma deliğinin maksimum çapını sınırlayın:" };  // TR

    public static readonly string[] InBlockQuery = {
      "Removing solid holes in blocks?",
      "Удалять отверстия солидов в блоках?",
      "Rimozione di fori solidi nei blocchi?",
      "Feste Löcher in Blöcken entfernen?",
      "Removing solid holes in blocks?",
      "¿Eliminar agujeros de sólidos en bloques?",     // ES
      "Supprimer les trous solides dans les blocs ?",  // FR
      "Bloklardaki katı delikleri kaldır?" };          // TR

    public static readonly string[] OneByOneQuery = {
      "Remove holes one at a time (slow)?",
      "Удалять отверстия по одному (медленно)?",
      "Rimuovere i fori uno alla volta (lento)?",
      "Löcher einzeln entfernen (langsam)?",
      "一次去除一个孔（慢）？",
      "¿Eliminar agujeros uno a la vez (lento)?",      // ES
      "Supprimer les trous un par un (lent) ?",        // FR
      "Delikleri tek tek kaldır (yavaş)?" };           // TR

    public static readonly string[] Progress = {
      "Removing holes",
      "Удаляем отверстия",
      "Rimozione dei fori",
      "Löcher entfernen",
      "去除孔",
      "Eliminando agujeros",                           // ES
      "Suppression des trous",                         // FR
      "Delikler kaldırılıyor" };                       // TR

    public static readonly string[] AllHolesKW = {
      "ALLHoles",
      "ВСЕ",
      "TUTTI",
      "ALLELöcher",
      "删除所有孔(ALLH)",
      "TODOSAgujeros",                                 // ES
      "TOUSTrous",                                     // FR
      "TÜMDelikler" };                                 // TR

    public static readonly string[] SmallHolesKW = {
      "SMALLHoles",
      "МАЛенькие",
      "PICcolo",
      "KLEIN",
      "去除小孔(SMALL)",
      "PEQueñosAgujeros",                              // ES
      "PETitsTrous",                                   // FR
      "KÜÇÜKDelikler" };                               // TR

    public static readonly string[] CNCDrillHolesKW = {
      "DRILLS",
      "СВЕРЛА",
      "TRapano",
      "BOHren",
      "钻头(DRI)",
      "TALadros",                                      // ES
      "PERçages",                                      // FR
      "DELmeler" };                                    // TR

    public static readonly string[] MaxDiamKW = {
      "MAXDiam",
      "МАКСДиаметр",
      "DIAMametroMax",
      "MAXDurchmesser",
      "最大直径(MAXD)",
      "DIÁMetroMáximo",                                // ES
      "DIAmètreMAX",                                   // FR
      "MAKSÇap" };                                     // TR

    public static readonly string[] InBlockKW = {
      "INBlock",
      "ВБлоках",
      "INBlocco",
      "INBlock",
      "内部块(INB)",
      "ENBloque",                                      // ES
      "DANSBloc",                                      // FR
      "BLOKİçinde" };                                  // TR

    public static readonly string[] OneByOneKW = {
      "1By1",
      "1За1",
      "1Per1",
      "1Von1",
      "逐个(1)",
      "1Por1",                                         // ES
      "1Par1",                                         // FR
      "1Tek1" };                                       // TR

    // ======================================== Options Dialog ====================================================
    public static readonly string[] OneBy1Text = {
      "Delete 1 by 1",
      "Удалять по одному",
      "Elimina uno per uno",
      "Nacheinander löschen",
      "一一删除",
      "Eliminar 1 por 1",                              // ES
      "Supprimer 1 par 1",                             // FR
      "1'er 1'er sil"};                                // TR

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
         "此选项在 BricsCAD 中没有意义。",
      "Llamar un comando de eliminación de superficie separado para cada agujero.\r\n" +  // ES
        "Esto aumentará significativamente el tiempo de ejecución del programa.\r\n" +
        "Pero en algunos casos, esto evitará la destrucción del sólido\r\n" +
        "y la aparición de superficies innecesarias debido a fallos en AutoCAD.\r\n" +
        "Esta opción no tiene sentido en BricsCAD.",
      "Appeler une commande de suppression de surface séparée pour chaque trou.\r\n" +  // FR
        "Cela augmentera considérablement le temps d'exécution du programme.\r\n" +
        "Mais dans certains cas, cela évitera la destruction du solide\r\n" +
        "et l'apparition de surfaces inutiles en raison de problèmes dans AutoCAD.\r\n" +
        "Cette option n'a aucun sens dans BricsCAD.",
      "Her delik için ayrı bir yüzey kaldırma komutu çağırın.\r\n" +  // TR
        "Bu, programın çalışma süresini önemli ölçüde artıracaktır.\r\n" +
        "Ancak bazı durumlarda, bu katının yok edilmesini\r\n" +
        "ve AutoCAD'deki hatalar nedeniyle gereksiz yüzeylerin görünmesini önleyecektir.\r\n" +
        "Bu seçenek BricsCAD'de anlamsızdır."};

    public static readonly string[] OptionsText = {
      "Hole selection options",
      "Настройка выбора отверстий",
      "Opzioni di selezione del foro",
      "Lochauswahloptionen",
      "孔选择选项",
      "Opciones de selección de agujeros",             // ES
      "Options de sélection des trous",                // FR
      "Delik seçim seçenekleri"};                      // TR

    public static readonly string[] AllText = {
      "All",
      "Все",
      "Tutto",
      "Alle",
      "全部",
      "Todos",                                         // ES
      "Tous",                                          // FR
      "Tümü"};                                         // TR

    public static readonly string[] AllTip = {
      "Remove all full cylindrical holes.",
      "Удалять все полные цилиндрические отверстия.",
      "Rimuovere tutti i fori cilindrici pieni.",
      "Entfernen Sie alle vollen zylindrischen Löcher.",
      "移除所有完整的圆柱形孔。",
      "Eliminar todos los agujeros cilíndricos completos.",  // ES
      "Supprimer tous les trous cylindriques complets.",  // FR
      "Tüm tam silindirik delikleri kaldırın."};      // TR

    public static readonly string[] DrillsText = {
      "Drills",
      "Сверловка",
      "Trapani",
      "Bohrer",
      "演习",
      "Taladros",                                      // ES
      "Perçages",                                      // FR
      "Delmeler"};                                     // TR

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
        "自定义 CNC 样式可用的钻头直径。",
      "Solo eliminar agujeros adecuados para la tecnología de taladrado. \r\n" +  // ES
        "Personalice los diámetros de los taladros disponibles en el estilo CNC.",
      "Supprimer uniquement les trous adaptés à la technologie de perçage. \r\n" +  // FR
        "Personnalisez les diamètres des forets disponibles dans le style CNC.",
      "Yalnızca delme teknolojisine uygun delikleri kaldırın. \r\n" +  // TR
        "CNC stilinde mevcut matkapların çaplarını özelleştirin."};

    public static readonly string[] SmallText = {
      "Less than",
      "Меньше чем",
      "Meno di",
      "Less than",
      "少于",
      "Menor que",                                     // ES
      "Inférieur à",                                   // FR
      "Daha az"};                                      // TR

    public static readonly string[] SmallTip = {
      "Only remove holes smaller than the specified diameter.",
      "Удалять только отверстия меньше, чем заданный диаметр.",
      "Rimuovere solo i fori più piccoli del diametro specificato.",
      "Entfernen Sie nur Löcher, die kleiner als der angegebene Durchmesser sind.",
      "只能去除小于指定直径的孔。",
      "Solo eliminar agujeros menores que el diámetro especificado.",  // ES
      "Supprimer uniquement les trous inférieurs au diamètre spécifié.",  // FR
      "Yalnızca belirtilen çaptan daha küçük delikleri kaldırın."};  // TR

    public static readonly string[] MaxDiamTip = {
      "Maximum hole diameter to be removed.",
      "Максимальный диаметр отверстия для удаления.",
      "Diametro massimo del foro da rimuovere.",
      "Maximal zu entfernender Lochdurchmesser.",
      "要移除的最大孔径。",
      "Diámetro máximo del agujero a eliminar.",       // ES
      "Diamètre maximum du trou à supprimer.",         // FR
      "Kaldırılacak maksimum delik çapı."};           // TR
  }
}