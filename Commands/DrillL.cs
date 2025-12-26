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
      "  当前设置：间隙 = {0:0.####}",
      "  Configuración actual: Holgura = {0:0.####}",           // ES
      "  Paramètres actuels : Jeu = {0:0.####}",                // FR
      "  Mevcut ayarlar: Boşluk = {0:0.####}"};                 // TR

    public static readonly string[] NoSub = {
      "  Nothing to subtract. The subtraction procedure has been canceled.",
      "  Нечего вычитать. Процедура вычитания отменена.",
      "  Non c'è niente da sottrarre. La procedura di sottrazione è stata annullata.",
      "  Nichts abzuziehen. Der Subtraktionsvorgang wurde abgebrochen.",
      "  没有什么可减去的。 减法程序已被取消。",
      "  Nada que restar. El procedimiento de resta ha sido cancelado.",  // ES
      "  Rien à soustraire. La procédure de soustraction a été annulée.",  // FR
      "  Çıkarılacak bir şey yok. Çıkarma işlemi iptal edildi."};  // TR

    public static readonly string[] NoIntersections = {
      "  The holes do not intersect any detail.",
      "  Отверстия не пересекли ни одной детали.",
      "  I solidi taglienti non intersecano con nessun solido da tagliare.",
      "  Die Löcher kreuzten kein einziges Detail.",
      "  这些孔不与任何对象相交。",
      "  Los agujeros no intersectan ningún detalle.",  // ES
      "  Les trous n'intersectent aucun détail.",  // FR
      "  Delikler hiçbir detayla kesişmiyor."};  // TR

    public static readonly string[] SourceCount = {
      "  Details count: {0}. Holes count: {1}. Block-assemblies count: {2}",
      "  Найдено деталей: {0}. Дырок: {1}. Блоков-сборок: {2}",
      "  Dettagli contati: {0}. Fori contati: {1}. Conteggio blocchi: {2}",
      "  Anzahl der Details: {0}. Anzahl der Löcher: {1}. Anzahl der Blöcke: {2}",
      "  详细信息计数：{0}。 孔数量：{1}。 块数量：{2}",
      "  Cantidad de detalles: {0}. Cantidad de agujeros: {1}. Cantidad de bloques-ensamblajes: {2}",  // ES
      "  Nombre de détails : {0}. Nombre de trous : {1}. Nombre de blocs-assemblages : {2}",  // FR
      "  Detay sayısı: {0}. Delik sayısı: {1}. Blok-montaj sayısı: {2}"};  // TR

    public static readonly string[] NoHoles = {
      "  No solids in hole layer '{0}'. Drill command canceled.",
      "  Нет ни одного солида в слое отверстий '{0}'. Команда сверления отменена.",
      "  Non ci sono solidi sul layer tagliente '{0}'. Comando di perforazione annullato.",
      "  Keine Feststoffe in der LÖcherLayer '{0}'. Bohrbefehl abgebrochen.",
      "  孔图层'{0}'中没有三维实体。 演习命令取消",
      "  No hay sólidos en la capa de agujeros '{0}'. Comando de perforación cancelado.",  // ES
      "  Aucun solide dans la couche de trous '{0}'. Commande de perçage annulée.",  // FR
      "  Delik katmanında '{0}' katı yok. Delme komutu iptal edildi."};  // TR

    public static readonly string[] MadeHoles = {
      "  Drills performed: {0}",
      "  Выполнено сверлений: {0}",
      "  Fori ottenuti: {0}",
      "  Bohren machen: {0}",
      "  执行钻孔：{0}",
      "  Perforaciones realizadas: {0}",  // ES
      "  Perçages effectués : {0}",  // FR
      "  Gerçekleştirilen delmeler: {0}"};  // TR

    public static readonly string[] SameDetail = {
      "  The same solids are selected as a part and as a hole. Matches will be excluded from selection.",
      "  Одни и те же солиды выбраны как деталь и как отверстие. Совпадения будут исключены из выбора.",
      "  Gli stessi solidi vengono selezionati come parte e come foro. Le partite saranno escluse dalla selezione.",
      "  Dieselben Volumenkörper werden als Teil und als Bohrung ausgewählt. Spiele werden von der Auswahl ausgeschlossen.",
      "  选择相同的实体作为零件和孔。 匹配项将被排除在选择之外。",
      "  Los mismos sólidos se seleccionan como pieza y como agujero. Las coincidencias se excluirán de la selección.",  // ES
      "  Les mêmes solides sont sélectionnés comme pièce et comme trou. Les correspondances seront exclues de la sélection.",  // FR
      "  Aynı katılar hem parça hem de delik olarak seçildi. Eşleşmeler seçimden hariç tutulacaktır."};  // TR

    public static readonly string[] Drilling = {
      "Drilling",
      "Сверление",
      "Perforazione",
      "Bohren",
      "钻孔",
      "Perforación",  // ES
      "Perçage",  // FR
      "Delme"};  // TR

    public static readonly string[] SubError = {
      "Sub error. Hole more than detail. Look for very fine details. ",
      "Сбой при вычитании. Получается дырка больше детали. Поищите очень мелкие детали. ",
      "Sottrazione Errore. Si scopre che il foro è più rapido. Dettagliare meglio per dettagli molto piccoli. ",
      "Subtraktionsfehler. Es stellt sich heraus, dass das Loch detaillierter ist. Suchen Sie nach sehr kleinen Teilen.",
      "错误! 孔大于对象。",
      "Error de resta. El agujero es más grande que el detalle. Busque detalles muy pequeños. ",  // ES
      "Erreur de soustraction. Le trou est plus grand que le détail. Recherchez des détails très petits. ",  // FR
      "Çıkarma hatası. Delik detaydan daha büyük. Çok küçük detaylar arayın. "};  // TR

    public static readonly string[] HoleError = {
      "Crash when cloning a hole solid in a block: {0}",
      "Сбой при клонировании солида-отверстия в блоке: {0}",
      "Arresto anomalo durante la clonazione di un foro solido in un blocco: {0}",
      "Absturz beim Klonen eines Loch-Volumenkörpers in einem Block: {0}",
      "克隆块中的孔实体时崩溃：{0}",
      "Fallo al clonar un sólido de agujero en un bloque: {0}",  // ES
      "Erreur lors du clonage d'un solide de trou dans un bloc : {0}",  // FR
      "Bir blokta delik katısı klonlanırken hata: {0}"};  // TR

    public static readonly string[] DrillSelect = {
      "\n Select details and holes(3dSolid) or ",
      "\n Выберите детали типа 3dSolid (в том числе присадку) или ",
      "\n Selezionare solidi taglienti e solidi da tagliare o ",
      "\n Wählen Sie Details und Löcher (3dSolid) oder ",
      "\n 选择对象（三维实体和孔）或 ",
      "\n Seleccione detalles y agujeros (3dSolid) o ",  // ES
      "\n Sélectionnez les détails et les trous (3dSolid) ou ",  // FR
      "\n Detayları ve delikleri (3dSolid) seçin veya "};  // TR

    public static readonly string[] DetailSelect = {
      "\n Select details for subtraction or ",
      "\n Выберите детали типа 3dSolid для вычитания или ",
      "\n Selezionare i solidi da tagliare o ",
      "\n Wählen Sie 3dSolid-Teile zum Subtrahieren aus ",
      "\n 选择对象",
      "\n Seleccione detalles para resta o ",  // ES
      "\n Sélectionnez les détails pour la soustraction ou ",  // FR
      "\n Çıkarma için detayları seçin veya "};  // TR

    public static readonly string[] HolesSelect = {
      "\n Select subtrahend details ",
      "\n Выберите вычитаемые детали ",
      "\n Selezionare i solidi taglienti ",
      "\n Wählen Sie abzugsfähige Details ",
      "\n 选择要减去的三维实体",
      "\n Seleccione detalles sustraendos ",  // ES
      "\n Sélectionnez les détails à soustraire ",  // FR
      "\n Çıkarılacak detayları seçin "};  // TR

    public static readonly string[] DeleteHolesInfo = {
      "  Hole-solids will be removed after drilling",
      "  Солиды-отверстия вне блоков будут удалены после сверления",
      "  I solidi taglienti verranno rimossi dopo la sottrazione (blocco esterne)",
      "  Loch-Volumenkörper außerhalb der Blöcke werden nach dem Bohren entfernt",
      "  钻孔后将删除孔实体",
      "  Los sólidos de agujeros se eliminarán después de perforar",  // ES
      "  Les solides de trous seront supprimés après le perçage",  // FR
      "  Delik katıları delme sonrası kaldırılacaktır"};  // TR

    public static readonly string[] SaveHolesInfo = {
      "  Hole-solids will be saved after drilling",
      "  Солиды-отверстия будут сохранены после сверления",
      "  I solidi taglienti verranno mantenuti dopo la sottrazione",
      "  Loch-Volumenkörper werden nach dem Bohren eingespart",
      "  钻孔后将保留孔实体",
      "  Los sólidos de agujeros se guardarán después de perforar",  // ES
      "  Les solides de trous seront enregistrés après le perçage",  // FR
      "  Delik katıları delme sonrası kaydedilecektir"};  // TR

    public static readonly string[] NoHoleLayer = {
      "  Hole-layer {0} not found.\n  " +
        "Create it or use option HoleLayer to choose another layer for subtrahend solids.",
      "  Не найден слой отверстий '{0}'.\n  " +
        "Создайте его или используйте опцию ИмяСлоя, чтоб задать другой слой для вычитаемых тел.",
      "  Layer {0} non trovato.\n  " +
        "Creare layer tagliente o utilizzare l'opzione LayerTagliente per scegliere un altro layer",
      "  Lochebene {0} nicht gefunden.\n  " +
        "Erstellen Sie eine Ebene oder verwenden Sie die Option LÖcherLayer, " +
        "um eine andere Ebene für Subtrahend-Volumenkörper auszuwählen.",
      "  未找到孔图层 {0}。\n " +
         "创建孔图层或使用选项  孔图层(HoleLayer) 选择其它图层。",
      "  Capa de agujeros {0} no encontrada.\n  " +  // ES
        "Créela o use la opción HoleLayer para elegir otra capa para sólidos sustraendos.",
      "  Couche de trous {0} introuvable.\n  " +  // FR
        "Créez-la ou utilisez l'option HoleLayer pour choisir une autre couche pour les solides à soustraire.",
      "  Delik katmanı {0} bulunamadı.\n  " +  // TR
        "Oluşturun veya çıkarılacak katılar için başka bir katman seçmek üzere HoleLayer seçeneğini kullanın."};

    public static readonly string[] LayerNotSpecified = {
      "The hole layer is not specified in the Drilling command settings",
      "В настройках команды Сверление не задан слой отверстий",
      "Lo strato del foro non è specificato nelle impostazioni del comando di foratura",
      "Die Lochebene ist in den Bohrbefehlseinstellungen nicht angegeben",
      "钻孔命令设置中未指定孔层",
      "La capa de agujeros no está especificada en la configuración del comando de perforación",  // ES
      "La couche de trous n'est pas spécifiée dans les paramètres de la commande de perçage",  // FR
      "Delme komutu ayarlarında delik katmanı belirtilmemiş"};  // TR

    public static readonly string[] AllInOne = {
      "  All solids on one layer. You need to replace the layer at hole-solids.",
      "  Все солиды на одном слое. Вы должны заменить слой у солидов-отверстий.",
      "  Tutti i solidi su un unico layer. È necessario sostituire il layer del fori",
      "  Alles fest auf einer Layer. Sie müssen die Layer an den festen Löchern ersetzen.",
      "  所有固体在一个图层上。 您需要更换孔三维实体的图层。",
      "  Todos los sólidos en una capa. Debe reemplazar la capa en los sólidos de agujeros.",  // ES
      "  Tous les solides sur une seule couche. Vous devez remplacer la couche des solides de trous.",  // FR
      "  Tüm katılar bir katmanda. Delik katılarının katmanını değiştirmeniz gerekir."};  // TR

    public static readonly string[] InBlocksQuery = {
      "  Do you need to subtract from the solids inside the blocks?",
      "  Вычитать из солидов, находящихся внутри блоков?",
      "  Hai bisogno di sottrarre dai solidi all'interno dei blocchi?",
      "  Müssen Sie von den Feststoffen in den Blöcken subtrahieren?",
      "  你需要从块内的三维实体中减去吗？",
      "  ¿Necesita restar de los sólidos dentro de los bloques?",  // ES
      "  Devez-vous soustraire des solides à l'intérieur des blocs ?",  // FR
      "  Blokların içindeki katılardan çıkarmanız gerekiyor mu?"};  // TR

    public static readonly string[] LayerQuery = {
      "\nEnter layer name for solid holes or '?' to enter layer name each time: ",
      "\nВведите имя слоя для солидов-отверстий или '?', чтоб вводить имя слоя каждый раз: ",
      "\nImmettere il nome del livello per i fori solidi o '?' per immettere il nome del livello ogni volta: ",
      "\nGeben Sie den Layer-Namen für feste Löcher oder '?' ein, um den Layer-Namen jedes Mal einzugeben: ",
      "\n 输入实体孔的图层名称或'?' 每次输入图层名称：",
      "\nIngrese el nombre de la capa para agujeros sólidos o '?' para ingresar el nombre de la capa cada vez: ",  // ES
      "\nEntrez le nom de la couche pour les trous solides ou '?' pour entrer le nom de la couche à chaque fois : ",  // FR
      "\nKatı delikler için katman adını girin veya her seferinde katman adı girmek için '?' yazın: "};  // TR

    public static readonly string[] GapQuery = {
      "  Enter gap value or zero",
      "  Введите значение зазора или ноль",
      "  Digitare un valore per il divario o lasciare zero",
      "  Geben Sie den Lückenwert oder Null ein",
      "  输入间隙值或零",
      "  Ingrese el valor de holgura o cero",  // ES
      "  Entrez la valeur de jeu ou zéro",  // FR
      "  Boşluk değeri veya sıfır girin"};  // TR

    public static readonly string[] Query = {
      "<<Query>>",
      "<<Запрос>>",
      "<<Scegli>>",
      "<<Abfrage>>",
      "<<询问>>",
      "<<Consulta>>",  // ES
      "<<Requête>>",  // FR
      "<<Sorgu>>"};  // TR

    public static readonly string[] ZeroLayerWarning = {
      "Inadmissible to use a special layer '0' like the holes-layer",
      "Недопустимо использовать специальный слой '0' в качестве слоя отверстий",
      "È inammissibile utilizzare uno layer speciale '0' nello layer di fori",
      "Es ist nicht akzeptabel, eine spezielle Layer '0' als LÖcherLayer zu verwenden",
      "不允许使用像孔层这样的特殊层'0'",
      "Es inadmisible usar una capa especial '0' como la capa de agujeros",  // ES
      "Il est inadmissible d'utiliser une couche spéciale '0' comme couche de trous",  // FR
      "Delik katmanı olarak özel '0' katmanını kullanmak kabul edilemez"};  // TR

    // ================ Command Line options ==================================================
    // ================ Command Line options ==================================================
    public static readonly string[] GapKW = {
      "GAp",
      "Зазор",
      "Divario",
      "SPIEL",
      "间隙",
      "HOlgura",                                        // ES
      "JEu",                                           // FR
      "BOşluk"};                                       // TR

    public static readonly string[] DeleteHolesKW = {
      "DeleteHoles",
      "УдалитьОтверстия",
      "CAncellaSolidiTaglienti",
      "ENTfernenLöcher",
      "删除孔",
      "ELiminarAgujeros",                              // ES
      "SUpprimerTrous",                                // FR
      "DEliklerSil"};                                  // TR

    public static readonly string[] SaveHolesKW = {
      "SaveHoles",
      "СОхранитьОтверстия",
      "SalvareSolidiTaglienti",
      "REttenLöcher",
      "保存孔",
      "GUardarAgujeros",                               // ES
      "ENregistrerTrous",                              // FR
      "DEliklerKaydet"};                               // TR

    public static readonly string[] HoleLayerKW = {
      "HOleLayer",
      "ИМяСлоя",
      "LayerTagliente",
      "LÖcherLayer",
      "孔图层",
      "CApadeAgujeros",                                // ES
      "COuchedeTrous",                                 // FR
      "DElikKatmanı"};                                 // TR

    public static readonly string[] InBlocksKW = {
      "INBlocks",
      "ВБлоках",
      "INBlocchi",
      "INBlöcken",
      "内部块",
      "ENBloques",                                     // ES
      "DAnsBlocs",                                     // FR
      "BLokİçi"};                                      // TR


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
      "删除孔",
      "Eliminar agujeros",                             // ES
      "Supprimer les trous",                           // FR
      "Delikleri sil"};                                // TR

    public static readonly string[] DeleteHolesTip = {
      "Select whether to remove solid-holes at the end of the Drill program.\r\n" +
         "Solids inside the blocks will remain in any case. The GAP command always preserves subtracted solids.",
      "Выбелите удалять ли солиды-отверстия в конце работы программы сверления DRI.\r\n" +
        "Солиды внутри блоков в любом случае сохранятся. Команда GAP всегда сохраняет вычитаемые солиды.",
      "Seleziona se rimuovere i taglienti alla fine del DRI programma.\r\n" +
         "I solidi all'interno dei blocchi rimarranno comunque. Il comando GAP preserva sempre i solidi sottratti.",
      "Wählen Sie aus, ob Löcher am Ende des DRI Programms entfernt werden sollen.\r\n" +
         "Volumenkörpers in den Blöcken bleiben auf jeden Fall zurück. Der GAP-Befehl behält subtrahierte Volumenkörper immer bei.",
      "选择是否在程序结束时删除实体孔 DRI。无论如何设置，块内的孔实体都会保留下来。GAP 命令始终保留减去的实体。",
      "Seleccione si desea eliminar los sólidos de agujeros al final del programa de perforación.\r\n" +  // ES
         "Los sólidos dentro de los bloques permanecerán en cualquier caso. El comando GAP siempre conserva los sólidos sustraídos.",
      "Sélectionnez s'il faut supprimer les solides de trous à la fin du programme de perçage.\r\n" +  // FR
         "Les solides à l'intérieur des blocs resteront dans tous les cas. La commande GAP préserve toujours les solides soustraits.",
      "Delme programının sonunda delik katılarının kaldırılıp kaldırılmayacağını seçin.\r\n" +  // TR
         "Blokların içindeki katılar her durumda kalacaktır. GAP komutu her zaman çıkarılan katıları korur."};

    public static readonly string[] DrillBlocks = {
      "Drill inside block-assemblies",
      "Сверлить внутри блоков-сборок",
      "Praticare dei fori all'interno dei gruppi di blocchi.",
      "Bohren Sie Löcher in die Blockbaugruppen.",
      "在块组件内钻孔。",
      "Perforar dentro de bloques-ensamblajes",        // ES
      "Percer à l'intérieur des blocs-assemblages",    // FR
      "Blok-montajların içinde delme"};                // TR

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
        "孔图层上的三维实体不会相互减去。",
      "Si hay sólidos en los bloques, entonces reste \r\n" +  // ES
        "y perfórelos con todos los agujeros del modelo y de los bloques.\r\n" +
        "La opción no funciona para bloques anidados.\r\n" +
        "El programa no restará de los sólidos y bloques de la capa de agujeros.",
      "S'il y a des solides dans les blocs, alors soustrayez \r\n" +  // FR
        "et percez-les avec tous les trous du modèle et des blocs.\r\n" +
        "L'option ne fonctionne pas pour les blocs imbriqués.\r\n" +
        "Le programme ne soustraira pas des solides et blocs de la couche de trous.",
      "Bloklarda katılar varsa, çıkarın \r\n" +  // TR
        "ve model ve bloklardan gelen tüm deliklerle bunları delin.\r\n" +
        "Seçenek iç içe bloklar için çalışmaz.\r\n" +
        "Program, Delikler katmanının katılarından ve bloklarından çıkarmayacaktır."};

    public static readonly string[] HoleLayer = {
      "Holes layer",
      "Слой отверстий",
      "Layer Tagliente",
      "LÖcher Layer",
      "孔图层",
      "Capa de agujeros",                              // ES
      "Couche de trous",                               // FR
      "Delik katmanı"};                                // TR

    public static readonly string[] HoleLayerTip = {
      "You can enter nonstandard layer name for hole-solids",
      "В можете ввести свое имя для слоя вычитаемых солидов-отверстий (обычно 'Отверстия')",
      "È possibile immettere un nome di layer non standard per i solidi-Tagliente",
      "Sie können einen nicht standardmäßigen Layernamen für Löcher-Volumenkörpers eingeben",
      "您可以为孔三维实体输入非标准图层名称",
      "Puede ingresar un nombre de capa no estándar para sólidos de agujeros",  // ES
      "Vous pouvez entrer un nom de couche non standard pour les solides de trous",  // FR
      "Delik katıları için standart olmayan katman adı girebilirsiniz"};  // TR

    public static readonly string[] Gap = {
      "Gap",
      "Зазор",
      "Divario",
      "Lücke",
      "间隙",
      "Holgura",                                       // ES
      "Jeu",                                           // FR
      "Boşluk"};                                       // TR

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
        "默认为 0。",
      "Holgura entre detalles.\r\n" +  // ES
        "Si establece una holgura mayor que cero, el programa aumentará (inflará, hinchará) los sólidos de agujeros antes de la resta.\r\n" +
        "Usar en ambos comandos DRI y GAP.\r\n" +
        "Predeterminado 0.",
      "Jeu entre les détails.\r\n" +  // FR
        "Si vous définissez un jeu supérieur à zéro, le programme augmentera (gonflera, enflera) les solides de trous avant la soustraction.\r\n" +
        "À utiliser dans les commandes DRI et GAP.\r\n" +
        "Par défaut 0.",
      "Detaylar arasındaki boşluk.\r\n" +  // TR
        "Sıfırdan büyük bir boşluk ayarlarsanız, program çıkarmadan önce delik katılarını artıracaktır (şişirecek, büyütecek).\r\n" +
        "Hem DRI hem de GAP komutunda kullanın.\r\n" +
        "Varsayılan 0."};

    public static readonly string[] SaveGap = {
      "Save gap",
      "Сохранять зазор",
      "Salva divario",
      "Lücke speichern",
      "保持间隙",
      "Guardar holgura",                               // ES
      "Enregistrer le jeu",                            // FR
      "Boşluğu kaydet"};                               // TR

    public static readonly string[] SaveGapTip = {
      "Save the gap setting for subsequent command calls. \r\n" +
        "If you disable this option, then the gap can only be entered using the command line option, \r\n" +
        "and immediately after the command is executed, it will be reset to 0.",
      "Сохранять настройку зазора для последующих вызовов команды. \r\n" +
        "Если отключить эту опцию, то зазор можно ввести только с помощью опции командной строки, \r\n" +
        "и сразу после выполнения команды он будет сброшен на 0.",
      "Salvare l'impostazione dell'intervallo per le chiamate di comando successive. \r\n" +
        "Se disabiliti questa opzione, il gap può essere inserito solo utilizzando l'opzione della riga di comando e, \r\n" +
        "immediatamente dopo l'esecuzione del comando, verrà reimpostato su 0.",
      "Speichern Sie die Abstandseinstellung für nachfolgende Befehlsaufrufe. \r\n" +
        "Wenn Sie diese Option deaktivieren, kann die Lücke nur über die Befehlszeilenoption eingegeben werden \r\n" +
        "und wird sofort nach Ausführung des Befehls auf 0 zurückgesetzt.",
      "保存间隙设置以供后续命令调用。 \r\n" +
        "如果禁用此选项，则只能使用命令行选项输入间隙，\r\n" +
        "并在执行命令后立即将其重置为 0。",
      "Guardar la configuración de holgura para llamadas de comando posteriores. \r\n" +  // ES
        "Si deshabilita esta opción, la holgura solo se puede ingresar usando la opción de línea de comandos, \r\n" +
        "e inmediatamente después de ejecutar el comando, se restablecerá a 0.",
      "Enregistrer le paramètre de jeu pour les appels de commande ultérieurs. \r\n" +  // FR
        "Si vous désactivez cette option, le jeu ne peut être saisi qu'à l'aide de l'option de ligne de commande, \r\n" +
        "et immédiatement après l'exécution de la commande, il sera réinitialisé à 0.",
      "Sonraki komut çağrıları için boşluk ayarını kaydedin. \r\n" +  // TR
        "Bu seçeneği devre dışı bırakırsanız, boşluk yalnızca komut satırı seçeneği kullanılarak girilebilir \r\n" +
        "ve komut yürütüldükten hemen sonra 0'a sıfırlanacaktır."};

    public static readonly string[] HoleLayerSelection = {
      "Hole layer selection",
      "Выбор слоя отверстий",
      "Selezione del Layer",
      "Schichtauswahl",
      "孔层选择",
      "Selección de capa de agujeros",                 // ES
      "Sélection de couche de trous",                  // FR
      "Delik katmanı seçimi"};                         // TR

    public static readonly string[] HoleLayerSelectionTip = {
      "Select layer for subtrahend detail (hole-solid)",
      "Выберите слой вычитаемых тел (солидов-отверстий)",
      "Seleziona il layer dei solidi del foro",
      "Wählen Sie die Ebene der subtrahierten KLocher-Volumenkörpers",
      "选择减体层（实心孔）",
      "Seleccione la capa para detalle sustraendo (sólido de agujero)",  // ES
      "Sélectionnez la couche pour le détail à soustraire (solide de trou)",  // FR
      "Çıkarılacak detay için katman seçin (delik katısı)"};  // TR

    public static readonly string[] FindingDrills = {
      "  Finding drills",
      "  Поиск отверстий",
      "  Trovare buchi",
      "  Löcher finden",
      "  搜索演习",
      "  Buscando perforaciones",                      // ES
      "  Recherche de perçages",                       // FR
      "  Delikler aranıyor"};                          // TR

    public static readonly string[] TooSmallGapErr = {
      "Too Small Gap",
      "Слишком маленький зазор",
      "Divario troppo piccolo",
      "Zu kleiner Spalt",
      "间隙太小",
      "Holgura demasiado pequeña",                     // ES
      "Jeu trop petit",                                // FR
      "Boşluk çok küçük"};                             // TR

  }
}
