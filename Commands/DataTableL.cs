// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Viewports

namespace AVC
{
  public static class
  DataTableL
  {
    public static readonly string[][] DTStyleNames = { 
/*0*/   CommandL.DataTable,
/*1*/   new []{ "Bill of Material",
          "Спецификация",
          "Distinta base",
          "Stückliste",
          "物料清单",
          "Lista de materiales",                                 // ES
          "Nomenclature",                                        // FR
          "Malzeme listesi" },                                   // TR
/*2*/   new []{ "Object Area Table",
          "Таблица площади объектов",
          "Tabella area oggetto",
          "Objektbereichstabelle",
          "对象区域表",
          "Tabla de área de objetos",                            // ES
          "Tableau de surface d'objets",                         // FR
          "Nesne alan tablosu" },                                // TR
/*3*/   new []{ "Number of blocks",
          "Количество блоков",
          "Numero di blocchi",
          "Anzahl der Blöcke",
          "块数",
          "Número de bloques",                                   // ES
          "Nombre de blocs",                                     // FR
          "Blok sayısı" },                                       // TR
/*4*/   new []{ "Line Length Table",
          "Таблица длин линий",
          "Tabella delle lunghezze delle linee",
          "Zeilenlängentabelle",
          "线长表",
          "Tabla de longitud de línea",                          // ES
          "Tableau des longueurs de ligne",                      // FR
          "Çizgi uzunluğu tablosu" },                            // TR
/*5*/  new []{ "Sawing Table",
          "Таблица напилки",
          "Segare",
          "Sägen",
          "锯床",
          "Tabla de aserrado",                                   // ES
          "Tableau de sciage",                                   // FR
          "Kesim tablosu" },                                     // TR
/*6*/   new []{ "Point Coordinate Table",
          "Таблица координат точек",
          "Tabella coordinate punto",
          "Punktkoordinatentabelle",
          "点坐标表",
          "Tabla de coordenadas de puntos",                      // ES
          "Tableau de coordonnées de points",                    // FR
          "Nokta koordinat tablosu" },                           // TR
      };

    public static readonly string[][] DrillTableStyleNames = {
/*0*/  CommandL.DrillTable,
/*1*/  new []{ CommandL.DrillTable[0],
          "Присадка",
          CommandL.DrillTable[2],
          CommandL.DrillTable[3],
          CommandL.DrillTable[4],
          CommandL.DrillTable[5],                                // ES
          CommandL.DrillTable[6],                                // FR
          CommandL.DrillTable[7] },                              // TR
/*2*/   new []{ "Drilling",
          "Сверления",
          "Foratura",
          "Bohren",
          "钻孔",
          "Perforación",                                         // ES
          "Perçage",                                             // FR
          "Delme" },                                             // TR
/*3*/   new []{ "Drill Table to Excel",
          "Таблица сверлений в Excel",
          "Tabella di perforazione Excel",
          "Bohrtisch Excel",
          "钻取表到 Excel",
          "Tabla de perforación a Excel",                        // ES
          "Tableau de perçage vers Excel",                       // FR
          "Delme tablosu Excel'e" },                             // TR
/*4*/   new []{ "Drill Table with countersink",
          "Таблица сверлений с зенковкой",
          "Tavolo per trapano con svasatore",
          "Bohrtisch mit Senker",
          "带埋头孔的钻台",
          "Tabla de perforación con avellanado",                 // ES
          "Tableau de perçage avec fraisure",                    // FR
          "Havşalı delme tablosu" },                             // TR
      };

    public static readonly string[] DrillTableGroup = {
      "Part %name%. Drilling %drill%",
      "Поз.%name%. Сверление %drill%",
      "Dettaglio %name%. Foratura %drill%",
      "Detail %name%. Bohren %drill%",
      "部分 %name%。钻孔 %drill%",
      "Pieza %name%. Perforación %drill%",                       // ES
      "Pièce %name%. Perçage %drill%",                           // FR
      "Parça %name%. Delme %drill%"};                            // TR

    public static readonly string[][] MatTableStyleNames = {
/*0*/   new []{ "Material Table",
          "Таблица материалов",
          "Tabella dei materiali",
          "Materialtabelle",
          "材料表",
          "Tabla de materiales",                                 // ES
          "Tableau des matériaux",                               // FR
          "Malzeme tablosu" },                                   // TR
/*1*/   new []{ "Material Table",
          "Таблица материалов",
          "Tabella dei materiali",
          "Materialtabelle",
          "材料表",
          "Tabla de materiales",                                 // ES
          "Tableau des matériaux",                               // FR
          "Malzeme tablosu"},                                    // TR
/*2*/   new []{ "Material Indexes",
          "Индексы материалов",
          "Indici materiali",
          "Materialindizes",
          "材料指标",
          "Índices de materiales",                               // ES
          "Index de matériaux",                                  // FR
          "Malzeme indeksleri"},                                 // TR
/*3*/   new []{ "Cutting3 materials",
          "Cutting3 материалы",
          "Cutting3 materiali",
          "Cutting3 Material",
          "Cutting3 种材料",
          "Materiales Cutting3",                                 // ES
          "Matériaux Cutting3",                                  // FR
          "Cutting3 malzemeleri" },                              // TR
/*4*/   new []{ "OptiCut panels",
          "OptiCut панели",
          "OptiCut pannelli",
          "OptiCut Paneele",
          "OptiCut 面板",
          "Paneles OptiCut",                                     // ES
          "Panneaux OptiCut",                                    // FR
          "OptiCut panelleri" },                                 // TR
/*5*/   new []{ "OptiCut bars",
          "OptiCut бруски",
          "OptiCut barre",
          "OptiCut Riegel",
          "OptiCut 磨料",
          "Barras OptiCut",                                      // ES
          "Barres OptiCut",                                      // FR
          "OptiCut çubukları" },                                 // TR
      };

    public static readonly string[][] SawStyleNames = {
      CommandL.Saw,
      CommandL.Saw,
      new []{ "Detailing Table",
        "Деталировка",
        "Tabella dei dettagli",
        "Detaillierung",
        "详细表",
        "Tabla de detalles",                                     // ES
        "Tableau de détails",                                    // FR
        "Detay tablosu" },                                       // TR
      new []{ "Rib cutting",
        "Погонажная нарезка",
        "Taglio delle costole",
        "Rippenschneiden",
        "切肋",
        "Corte de nervaduras",                                   // ES
        "Coupe de nervures",                                     // FR
        "Kaburga kesme"},                                        // TR
      new []{ "Nesting in Cutting3",
        "Раскрой в Cutting3",
        "Taglio nel Cutting3",
        "Schneiden in Cutting3",
        "在 Cutting3 中嵌套",
        "Anidamiento en Cutting3",                               // ES
        "Imbrication dans Cutting3",                             // FR
        "Cutting3'te yerleştirme"},                              // TR
      new []{ "Panels for OptiCut",
        "Панели для OptiCut",
        "Pannelli per OptiCut",
        "Panels für OptiCut",
        "OptiCut 面板",
        "Paneles para OptiCut",                                  // ES
        "Panneaux pour OptiCut",                                 // FR
        "OptiCut için paneller"},                                // TR
      new []{ "Bars for OptiCut",
        "Бруски для OptiCut",
        "Barre per OptiCut",
        "Balken für OptiCut",
        "OptiCut 棒材",
        "Barras para OptiCut",                                   // ES
        "Barres pour OptiCut",                                   // FR
        "OptiCut için çubuklar"},                                // TR
      new []{ "Details for Viyar",
        "Детали Вияр",
        "Dettagli per Viyar",
        "Details für Viyar",
        "Viyar 的详细信息",
        "Detalles para Viyar",                                   // ES
        "Détails pour Viyar",                                    // FR
        "Viyar için detaylar"},                                  // TR
      };

    public static readonly string[] SortAZ = {
      "A-Z",
      "А-Я",
      "A-Z",
      "A-Z",
      "升序",
      "A-Z",                                                     // ES
      "A-Z",                                                     // FR
      "A-Z"};                                                    // TR

    public static readonly string[] SortZA = {
      "Z-A",
      "Я-А",
      "Z-A",
      "Z-A",
      "降序排列",
      "Z-A",                                                     // ES
      "Z-A",                                                     // FR
      "Z-A" };                                                   // TR

    public static readonly string[] SortSum = {
      "Sum",
      "Сумма",
      "Somma",
      "Summe",
      "求和",
      "Suma",                                                    // ES
      "Somme",                                                   // FR
      "Toplam" };                                                // TR

    public static readonly string[] SortSumTotal = {
      "Sum&Total",
      "Сумма+Итог",
      "Somma&Totale",
      "Summe&Total",
      "总结和结果",
      "Suma y Total",                                            // ES
      "Somme et Total",                                          // FR
      "Toplam ve Genel Toplam" };                                // TR

    // ===================================== Command Line =========================================
    public static readonly string[]
    Sorting = {
      "  Row sorting...",
      "  Сортировка строк...",
      "  Ordinamento di righe...",
      "  Zeilensortierung...",
      "  行排序...",
      "  Ordenación de filas...",                                // ES
      "  Tri des lignes...",                                     // FR
      "  Satır sıralama..."};                                    // TR

    public static readonly string[]
    ObjCount = {
      "  Received {0} objects by {1}s",
      "  Получено {0} объектов за {1}c",
      "  Ha ricevuto {0} oggetti - {1}s",
      "  Empfangene {0} Objekte - {1}s",
      "  {1}s 收到了 {0} 个对象",
      "  Se recibieron {0} objetos en {1}s",                     // ES
      "  {0} objets reçus en {1}s",                              // FR
      "  {1}s içinde {0} nesne alındı" };                        // TR

    public static readonly string[]
    Extracting = {
      "Data extraction",
      "Извлечение данных",
      "Estrazione dei dati",
      "Datenextraktion",
      "数据提取",
      "Extracción de datos",                                     // ES
      "Extraction de données",                                   // FR
      "Veri çıkarma" };                                          // TR

    public static readonly string[]
    Grouping = {
      "Row grouping",
      "Группировка строк",
      "Raggruppamento di righe",
      "Zeilengruppierung",
      "行分组",
      "Agrupación de filas",                                     // ES
      "Regroupement de lignes",                                  // FR
      "Satır gruplama"};                                         // TR

    public static readonly string[]
    Creating = {
      "Creating a table",
      "Создание таблицы",
      "Creazione di una tabella",
      "Eine Tabelle erstellen",
      "创建表",
      "Creando una tabla",                                       // ES
      "Création d'une table",                                    // FR
      "Tablo oluşturma"};                                        // TR

    public static readonly string[]
    HappenedRows = {
      "  Happened {0} rows in {1} groups",
      "  Получилось строк - {0}, групп - {1}",
      "  Si è scoperto righe - {0}, gruppi - {1}",
      "  Es sind {0} Zeilen passiert, Gruppen - {1}",
      "  {1} 组中发生了 {0} 行",
      "  Ocurrieron {0} filas en {1} grupos",                    // ES
      "  {0} lignes créées dans {1} groupes",                    // FR
      "  {1} grupta {0} satır oluştu" };                         // TR

    public static readonly string[]
    Inserted = {
      "  Inserted data rows {0}",
      "  Вставлено строк данных {0}",
      "  Le righe di dati inserite {0}",
      "  Eingefügte Datenzeilen {0}",
      "  插入的数据行 {0}",
      "  Filas de datos insertadas {0}",                         // ES
      "  Lignes de données insérées {0}",                        // FR
      "  Eklenen veri satırları {0}" };                          // TR

    public static readonly string[]
    TextLocation = {
      "Specify the insertion point for the new text.",
      "Укажите точку вставки нового текста",
      "Specificare il punto di inserimento per il nuovo testo.",
      "Geben Sie die Einfügemarke des neuen Textes an",
      "指定新文本的插入点。",
      "Especifique el punto de inserción para el nuevo texto.",  // ES
      "Spécifiez le point d'insertion pour le nouveau texte.",   // FR
      "Yeni metin için ekleme noktasını belirtin." };            // TR

    public static readonly string[]
    Failed = {
      "Failed to make a table.",
      "Не удалось сделать таблицу",
      "Impossibile creare una tabella.",
      "Fehler beim Erstellen einer Tabelle.",
      "无法制作表格。",
      "Error al crear una tabla.",                               // ES
      "Échec de la création d'une table.",                       // FR
      "Tablo oluşturulamadı." };                                 // TR

    public static readonly string[]
    FailedToWrite = {
      "Failed to write extracted data to {0}",
      "Не удалось записать извлеченные данные в {0}",
      "Impossibile scrivere i dati estratti su {0}",
      "Extrahierte Daten konnten nicht nach {0} geschrieben werden.",
      "无法将表写入 {0}",
      "Error al escribir datos extraídos en {0}",                // ES
      "Échec de l'écriture des données extraites dans {0}",     // FR
      "Çıkarılan veriler {0}'a yazılamadı" };                    // TR

    public static readonly string[]
    Multiply = {
      "Multiply the amount by ",
      "Умножить количество на ",
      "Moltiplicando questo numero per ",
      "Multipliziere die Anzahl mit ",
      "将金额乘以",
      "Multiplicar la cantidad por ",                            // ES
      "Multiplier le montant par ",                              // FR
      "Miktarı şununla çarp: "};                                 // TR

    public static readonly string[]
    MultiplyIs = {
      "  The amount will be multiplied by {0}",
      "  Количество будет умножено на {0}",
      "  L'importo verrà moltiplicato per {0}",
      "  Der Betrag wird mit {0} multipliziert",
      "  金额将乘以 {0}",
      "  La cantidad se multiplicará por {0}",                   // ES
      "  Le montant sera multiplié par {0}",                     // FR
      "  Miktar {0} ile çarpılacak"};                            // TR

    public static readonly string[] SelectOptions = {
      "  Choice way of use command with set of options #{0}",
      "  Выберите действие с набором настроек №{0}",
      "  Seleziona l'azione con il numero di preselezione #{0}",
      "  Befehl zur Verwendung der Auswahl mit einer Reihe von Optionen #{0}",
      "  使用带选项集的命令的选择方式 #{0}",
      "  Elija la forma de usar el comando con el conjunto de opciones #{0}",  // ES
      "  Choisissez la manière d'utiliser la commande avec l'ensemble d'options #{0}",  // FR
      "  #{0} seçenekleri kümesiyle komutu kullanma şeklini seçin"};  // TR

    public static readonly string[] ColumnsKW = {
      "TAbleColumns",
      "СТолбцы",
      "СOlonne",
      "Tabellenspalten",
      "表列(TA)",
      "COlumnasTabla",                                           // ES
      "COlonnesTable",                                           // FR
      "TABloSütunları" };                                        // TR

    public static readonly string[] MirrorKW = {
      "MIrror",
      "ЗЕркальные",
      "SPecchio",
      "SPiegeln",
      "镜像的(MI)",
      "ESPejo",                                                  // ES
      "MIroir",                                                  // FR
      "AYna" };                                                  // TR

    public static readonly string[] GroupKW = {
      "GRoup",
      "ГРуппировка",
      "GRuppo",
      "Gruppe",
      "分组(GR)",
      "GRupo",                                                   // ES
      "GRoupe",                                                  // FR
      "GRup" };                                                  // TR

    public static readonly string[] FormatKW = {
      "FOrmatOfDimension",
      "ФОрматРазмеров",
      "FOrmatoDiDimensioni",
      "FOrmatDerDimension",
      "维度格式(FO)",
      "FOrmatoDeDimensión",                                      // ES
      "FOrmatDeDimension",                                       // FR
      "BOyutFormatı" };                                          // TR

    public static readonly string[] NumberingKW = {
      "NUmbering",
      "НУмерация",
      "NUmerazione",
      "NUmmerierung",
      "编号(NU)",
      "NUmeración",                                              // ES
      "NUmérotation",                                            // FR
      "NUmaralandırma" };                                        // TR

    public static readonly string[] MultiplierKW = {
      "MUltiplier",
      "Множитель",
      "MOltiplicatore",
      "Multiplikator",
      "因素(MU)",
      "MUltiplicador",                                           // ES
      "MUltiplicateur",                                          // FR
      "ÇArpan" };                                                // TR

    public static readonly string[] AllTablesKW = {
      "allTABLES",
      "всеТАБЛИЦЫ",
      "tuttiTAVOLI",
      "alleTISCHE",
      "所有桌子(TABLES)",
      "todasLASTABLAs",                                          // ES
      "toutesLesTABLEs",                                         // FR
      "tümTABLOlar" };                                           // TR

    public static readonly string[] ColumnsQuery = {
      "Enter a list of column through ;",
      "Введите подстановки для столбцов через ;",
      "Inserisci i nomi delle colonne desiderate facendo ;",
      "Geben Sie die Namen der erforderlichen Spalten durch ;",
      "通过 ; 输入列列表",
      "Ingrese una lista de columnas a través de ;",             // ES
      "Entrez une liste de colonnes via ;",                      // FR
      "; ile sütun listesi girin" };                             // TR

    public static readonly string[] MirroredQuery = {
      "Lay mirrored solid separately (not group)?",
      "Выкладывать зеркальные солиды отдельно (не группировать)?",
      "Diffusione specchiata solidi separatamente (non di gruppo)?",
      "Gespiegelte Teile separat verteilen (nicht gruppieren)?",
      "单独放置镜像实体（不是组）？",
      "¿Colocar sólido reflejado por separado (no agrupar)?",    // ES
      "Disposer le solide en miroir séparément (pas grouper) ?", // FR
      "Aynalı katıyı ayrı olarak yerleştir (gruplamadan)?"};     // TR

    public static readonly string[] GroupQuery = {
      "Group the same (Lay the same parts only once and write their number in the header)?",
      "Группировать одинаковые (Выкладывать одинаковые детали только один раз и писать в заголовке их количество) ?",
      "Creare gruppi parti identiche? (verrà scritto il numero delle parti nel titolo)",
      "Gleiche gruppieren (gleiche Teile nur einmal verteilen und deren Nummer in die Kopfzeile schreiben)?",
      "分组相同（只放置一次相同的零件并在标题中写下它们的编号）？",
      "¿Agrupar iguales (Colocar las mismas piezas solo una vez y escribir su número en el encabezado)?",  // ES
      "Regrouper les identiques (Disposer les mêmes pièces une seule fois et écrire leur nombre dans l'en-tête) ?",  // FR
      "Aynıları grupla (Aynı parçaları yalnızca bir kez yerleştir ve başlıkta sayılarını yaz)?"};  // TR

    public static readonly string[] FormatQuery = {
      "Enter dimension format. 0 - digit or zero, # - digit or nothing" ,
      "Введите формат для размеров. 0 - цифра или ноль, # - цифра или ничего, . - разделитель дробной части",
      "Introduce il formato dimensione. 0 - cifre o pari a zero, # - cifre o niente",
      "Geben Sie ein Format für die Größen ein. 0 - Ziffer oder Null, # - Ziffer oder nichts, . - Bruchteilabscheider",
      "输入维度格式。 0 - 数字或零，# - 数字或无",
      "Ingrese el formato de dimensión. 0 - dígito o cero, # - dígito o nada",  // ES
      "Entrez le format de dimension. 0 - chiffre ou zéro, # - chiffre ou rien",  // FR
      "Boyut formatını girin. 0 - rakam veya sıfır, # - rakam veya hiçbir şey"};  // TR

    public static readonly string[] NumberingQuery = {
      "Numbering of solids",
      "Нумерация солидов",
      "Numerazione dei solidi",
      "Nummerierung der Details",
      "实体编号",
      "Numeración de sólidos",                                   // ES
      "Numérotation des solides",                                // FR
      "Katıların numaralandırılması" };                          // TR

    public static readonly string[] MultiQuery = {
      "Request multiplier every time",
      "Запрашивать множитель каждый раз",
      "Richiedere moltiplicatore ogni volta",
      "Fordern Sie jedes Mal einen Multiplikator an.",
      "每次请求乘数",
      "Solicitar multiplicador cada vez",                        // ES
      "Demander le multiplicateur à chaque fois",                // FR
      "Her seferinde çarpan iste"  };                            // TR

    public static readonly string[] NoViewport = {
      "There are no viewports on layout {0}.",
      "Нет ни одного вьюпорта на листе {0}.",
      "Non sono presenti finestre nel layout {0}.",
      "Es gibt keine Ansichtsfenster im Layout {0}.",
      "布局 {0} 上没有视口。",
      "No hay ventanas gráficas en el diseño {0}.",              // ES
      "Il n'y a pas de fenêtres dans la présentation {0}.",     // FR
      "Düzen {0}'de görünüm penceresi yok."    };                // TR

    public static readonly string[] NoViewportAtPoint = {
      "No visible view or viewport found below the given point.",
      "Не найден видимый вид или вьюпорт под заданной точкой.",
      "Non è stata trovata alcuna vista o finestra visibile nel punto specificato.",
      "Unter dem angegebenen Punkt wurde keine sichtbare Ansicht oder kein sichtbares Ansichtsfenster gefunden.",
      "在指定点下未找到可见视图或视口。",
      "No se encontró ninguna vista o ventana gráfica visible debajo del punto dado.",  // ES
      "Aucune vue ou fenêtre visible trouvée sous le point donné.",  // FR
      "Verilen noktanın altında görünür görünüm veya pencere bulunamadı."    };  // TR

    public static readonly string[] ViewBorderPointQuery = {
      "Click anywhere above the ModelDoc view or viewport",
      "Кликните по любой точке над видом ModelDoc или вьюпортом",
      "Fare clic in un punto qualsiasi sopra la vista o il viewport ModelDoc",
      "Klicken Sie auf eine beliebige Stelle oberhalb der ModelDoc-Ansicht oder des Ansichtsfensters",
      "单击 ModelDoc 视图或视口上方的任意位置",
      "Haga clic en cualquier lugar sobre la vista ModelDoc o ventana gráfica",  // ES
      "Cliquez n'importe où au-dessus de la vue ModelDoc ou de la fenêtre",  // FR
      "ModelDoc görünümü veya penceresinin üzerinde herhangi bir yere tıklayın"  };  // TR

    public static readonly string[] TableUpdatedCount = {
      "Updated tables: {0}",
      "Обновлено таблиц: {0}",
      "Tabelle aggiornate: {0}",
      "Aktualisierte Tabellen: {0}",
      "更新的表格：{0}",
      "Tablas actualizadas: {0}",                                // ES
      "Tables mises à jour : {0}",                               // FR
      "Güncellenen tablolar: {0}"};                              // TR

    public static readonly string[] StyleErr = {
      "Style for table fill '{0}' not found.",
      "Стиль для заполнения таблицы '{0}' не найден.",
      "Stile per il riempimento della tabella '{0}' non trovato.",
      "Tabellenfüllstil '{0}' nicht gefunden.",
      "未找到表格填充样式'{0}'。",
      "No se encontró el estilo para relleno de tabla '{0}'.",   // ES
      "Style de remplissage de table '{0}' introuvable.",        // FR
      "Tablo doldurma stili '{0}' bulunamadı." };                // TR

    public static readonly string[] TableUpdate = {
      "Updating table {0}, '{1}' style",
      "Обновление таблицы {0}, стиль '{1}'",
      "Tavolo di rifornimento {0}. Stile: '{1}'",
      "Tabelle {0} wird aufgefüllt. Stil: '{1}'",
      "重新填充表{0}。样式'{1}'",
      "Actualizando tabla {0}, estilo '{1}'",                    // ES
      "Mise à jour de la table {0}, style '{1}'",                // FR
      "Tablo {0} güncelleniyor, '{1}' stili" };                  // TR

    public static readonly string[] ModelObjectsInfo = {
      "  The command is set to process all objects in the model. Pre-selected objects will be ignored!",
      "  Команда настроена на обработку всех объектов модели. Предварительно выбранные объекты будут проигнорированы!",
      "  Il comando è configurato per elaborare tutti gli oggetti del modello. Gli oggetti preselezionati verranno ignorati!",
      "  Der Befehl ist so konfiguriert, dass er alle Modellobjekte verarbeitet. Vorab ausgewählte Objekte werden ignoriert!",
      "  该命令配置为处理所有模型对象。预先选择的对象将被忽略！",
      "  El comando está configurado para procesar todos los objetos del modelo. ¡Los objetos preseleccionados serán ignorados!",  // ES
      "  La commande est configurée pour traiter tous les objets du modèle. Les objets présélectionnés seront ignorés !",  // FR
      "  Komut modeldeki tüm nesneleri işlemek üzere ayarlanmış. Önceden seçilen nesneler yok sayılacak!" };  // TR

    public static readonly string[] ViewportObjectsInfo = {
      "  The command is set to process all visible objects from all viewports. Pre-selected objects will be ignored!",
      "  Команда настроена на обработку всех видимых объектов из всех вьюпортов. \r\n" +
        "  Предварительно выбранные объекты будут проигнорированы!",
      "  Il comando è configurato per elaborare tutti gli oggetti visibili da tutte le finestre. \r\n" +
        "  Gli oggetti preselezionati verranno ignorati!",
      "  Der Befehl ist so konfiguriert, dass er alle sichtbaren Objekte aus allen Ansichtsfenstern verarbeitet. \r\n" +
        "  Vorab ausgewählte Objekte werden ignoriert!",
      "  该命令配置为处理所有视口中的所有可见对象。预先选择的对象将被忽略！",
      "  El comando está configurado para procesar todos los objetos visibles de todas las ventanas gráficas. \r\n" +
        "¡Los objetos preseleccionados serán ignorados!",  // ES
      "  La commande est configurée pour traiter tous les objets visibles de toutes les fenêtres. \r\n" +
        "Les objets présélectionnés seront ignorés !",  // FR
      "  Komut tüm görünüm pencerelerinden görünür tüm nesneleri işlemek üzere ayarlanmış. \r\n" +
        "Önceden seçilen nesneler yok sayılacak!" };  // TR

    public static readonly string[] SelectFile = {
      "Select drawings to extract data from model objects",
      "Выберите чертежи для извлечения данных из объектов модели",
      "Seleziona i disegni per estrarre i dati dagli oggetti del modello",
      "Wählen Sie Zeichnungen aus, um Daten aus Modellobjekten zu extrahieren",
      "选择图形以从模型对象中提取数据",
      "Seleccione dibujos para extraer datos de objetos del modelo",  // ES
      "Sélectionnez des dessins pour extraire des données d'objets du modèle",  // FR
      "Model nesnelerinden veri çıkarmak için çizimleri seçin"};  // TR

    public static readonly string[] SetLayoutErr = {
      "Failed to set current layout {0}",
      "Не удалось назначить текущий лист {0}",
      "Impossibile impostare il layout corrente {0}",
      "Aktuelles Layout konnte nicht festgelegt werden {0}",
      "无法设置当前布局 {0}",
      "Error al establecer el diseño actual {0}",                // ES
      "Échec de la définition de la présentation actuelle {0}",  // FR
      "Geçerli düzen {0} ayarlanamadı" };                        // TR

    public static readonly string[] NoLicense = {
      "There is no license for any of the table filling commands.",
      "Нет лицензии ни на одну команду заполнения таблиц.",
      "Non esiste alcuna licenza per nessuno dei comandi di riempimento delle tabelle.",
      "Für die Befehle zum Ausfüllen von Tabellen ist keine Lizenz erforderlich.",
      "任何表格填充命令均没有许可证。",
      "No hay licencia para ninguno de los comandos de llenado de tablas.",  // ES
      "Il n'y a pas de licence pour les commandes de remplissage de table.",  // FR
      "Tablo doldurma komutlarından hiçbiri için lisans yok."};  // TR

    //============================= Dialog Box ===============================================

    public static readonly string[] AddColumnText = {
      "Add",
      "Добавить",
      "Inserisci",
      "Hinzufügen",
      "添加",
      "Agregar",                                                 // ES
      "Ajouter",                                                 // FR
      "Ekle" };                                                  // TR

    public static readonly string[] AddColumnTip = {
      "Add a column to the table. \r\n" +
        "Choose one of the substitutions from the list.",
      "Добавить колонку к таблице. \r\n" +
        "Выберите одну из подстановок из списка.",
      "Aggiungi una colonna alla tabella. \r\n" +
        "Seleziona una delle sostituzioni da inserire in una nuova colonna.",
      "Fügen Sie der Tabelle eine Spalte hinzu. \r\n" +
        "Wählen Sie eine der Vertretungen aus der Liste aus.",
      "向表中添加一列。 \r\n" +
        "从列表中选择一种替换。",
      "Agregar una columna a la tabla. \r\n" +  // ES
        "Elija una de las sustituciones de la lista.",
      "Ajouter une colonne à la table. \r\n" +  // FR
        "Choisissez l'une des substitutions de la liste.",
      "Tabloya bir sütun ekle. \r\n" +  // TR
        "Listeden ikamelerden birini seçin." };

    public static readonly string[] CopyLayText = {
      "Copy from LAY",
      "Копировать с LAY",
      "Copia da LAY",
      "Kopie von LAY",
      "从 LAY 复制",
      "Copiar desde LAY",                                        // ES
      "Copier depuis LAY",                                       // FR
      "LAY'den kopyala" };                                       // TR

    public static readonly string[] CopyLayTip = {
      "Copy all settings from the current LAY style",
      "Копировать все настройки из текущего стиля Выкладки",
      "Copia tutte le impostazioni dallo stile di comando LAY corrente",
      "Alle Einstellungen aus dem aktuellen Layoutstil kopieren (LAY-Befehle)",
      "从当前布局样式复制所有设置（LAY 命令）",
      "Copiar todas las configuraciones del estilo LAY actual",  // ES
      "Copier tous les paramètres du style LAY actuel",          // FR
      "Mevcut LAY stilinden tüm ayarları kopyala" };             // TR

    public static readonly string[] CopySawText = {
      "Copy from SAW",
      "Копировать с SAW",
      "Copia da SAW",
      "Kopie von SAW",
      "从 SAW 复制",
      "Copiar desde SAW",                                        // ES
      "Copier depuis SAW",                                       // FR
      "SAW'dan kopyala" };                                       // TR

    public static readonly string[] CopySawTip = {
      "Copy all settings from the current Sawing Table style",
      "Копировать все настройки из текущего стиля Таблицы Напилки",
      "Copia tutte le impostazioni dallo stile corrente di Tabelle Sega (comando SAW)",
      "Kopieren Sie alle Einstellungen aus dem aktuellen Sägetischstil",
      "复制当前锯床样式的所有设置",
      "Copiar todas las configuraciones del estilo de tabla de aserrado actual",  // ES
      "Copier tous les paramètres du style de tableau de sciage actuel",  // FR
      "Mevcut Kesim Tablosu stilinden tüm ayarları kopyala" };   // TR

    public static readonly string[] DelColumnText = {
      "Delete",
      "Удалить",
      "Elimina",
      "Löschen",
      "删除",
      "Eliminar",                                                // ES
      "Supprimer",                                               // FR
      "Sil" };                                                   // TR

    public static readonly string[] DelColumnTip = {
      "Delete current column",
      "Удалить текущую колонку",
      "Elimina la colonna corrente",
      "Aktuelle Spalte löschen",
      "删除当前列",
      "Eliminar columna actual",                                 // ES
      "Supprimer la colonne actuelle",                           // FR
      "Geçerli sütunu sil" };                                    // TR

    public static readonly string[] MoveLeftTip = {
      "Move the column to the left, to the beginning of the table.",
      "Передвинуть колонку влево, к началу таблицы.",
      "Sposta la colonna corrente a sinistra",
      "Verschieben Sie die Spalte nach links an den Anfang der Tabelle.",
      "将列向左移动到表格的开头。",
      "Mover la columna a la izquierda, al inicio de la tabla.",  // ES
      "Déplacer la colonne vers la gauche, au début de la table.",  // FR
      "Sütunu sola, tablonun başlangıcına taşı." };              // TR

    public static readonly string[] MoveRightTip = {
      "Move the column to the right, to the end of the table.",
      "Передвинуть колонку вправо, к концу таблицы.",
      "Sposta la colonna corrente a destra",
      "Verschieben Sie die Spalte nach rechts an das Ende der Tabelle.",
      "将列向右移动到表的末尾。",
      "Mover la columna a la derecha, al final de la tabla.",    // ES
      "Déplacer la colonne vers la droite, à la fin de la table.",  // FR
      "Sütunu sağa, tablonun sonuna taşı." };                    // TR

    public static readonly string[] HeaderText = {
      "Header",
      "Заголовок",
      "Intestazione",
      "Header",
      "标题",
      "Encabezado",                                              // ES
      "En-tête",                                                 // FR
      "Başlık" };                                                // TR

    public static readonly string[] HeaderTip = {
      "Header for column of table",
      "Заголовок для столбца таблицы",
      "Intestazione per la colonna della tabella",
      "Überschrift für Tabellenspalte",
      "表格列的标题",
      "Encabezado para columna de tabla",                        // ES
      "En-tête pour colonne de table",                           // FR
      "Tablo sütunu için başlık" };                              // TR

    public static readonly string[] MaskText = {
      "Data substitutions",
      "Подстановки данных",
      "Sostituzioni di dati",
      "Datenersetzungen",
      "数据替换",
      "Sustituciones de datos",                                  // ES
      "Substitutions de données",                                // FR
      "Veri ikameleri" };                                        // TR

    public static readonly string[] MaskTip = {
      "Data for column of table.\r\n" +
        "String must contain substitutions of object properties.",
      "Данные для ячеек таблицы. \r\n" +
        "В строке должна быть одна или много подстановок свойств объектов.",
      "Dati per la colonna della tabella. \r\n" +
        "La stringa deve contenere sostituzioni di proprietà dell'oggetto.",
      "Daten für Spalte der Tabelle. \r\n" +
        "Zeichenfolge muss Ersetzungen von Objekteigenschaften enthalten.",
      "表格列的数据。 \r\n" +
        "字符串必须包含对象属性的替换。",
      "Datos para columna de tabla.\r\n" +  // ES
        "La cadena debe contener sustituciones de propiedades de objeto.",
      "Données pour colonne de table.\r\n" +  // FR
        "La chaîne doit contenir des substitutions de propriétés d'objet.",
      "Tablo sütunu için veri.\r\n" +  // TR
        "Dize nesne özelliklerinin ikamelerini içermelidir." };

    public static readonly string[] SortText = {
      "Sort",
      "Сортировка",
      "Ordinare",
      "Sortierung",
      "排序",
      "Ordenar",                                                 // ES
      "Trier",                                                   // FR
      "Sırala" };                                                // TR

    public static readonly string[] SortTip = {
      "A column can be sorted in ascending or descending order. \r\n" +
        "Objects with the same properties from the sorted columns \r\n" +
        "are considered the same and fall into the same row of the table. \r\n" +
        "Unsorted columns will summarize the properties of all objects that fall into this row.\r\n" +
        "For such total columns, you can calculate the total.",
      "Столбец может быть отсортирован в порядке возрастания или убывания. \r\n" +
        "Объекты с одинаковыми свойствами из отсортированных столбцов считаются одинаковыми \r\n" +
        "и попадают в одну и ту же строку таблицы. \r\n" +
        "Несортированные столбцы будут суммировать свойства всех объектов, попадающих в эту строку. \r\n" +
        "Для таких суммарных столбцов можно вычислить итог.",
      "Una colonna può essere ordinata in ordine crescente o decrescente. \r\n" +
        "Gli oggetti con le stesse proprietà delle colonne ordinate sono considerati uguali \r\n" +
        "e rientrano nella stessa riga della tabella. \r\n" +
        "Le colonne non ordinate riassumono le proprietà di tutti gli oggetti che rientrano in questa riga. \r\n" +
        "Per tali colonne totali, è possibile calcolare il totale.",
      "Eine Spalte kann aufsteigend oder absteigend sortiert werden. \r\n" +
        "Objekte mit denselben Eigenschaften aus den sortierten Spalten werden als gleich betrachtet \r\n" +
        "und fallen in dieselbe Zeile der Tabelle. \r\n" +
        "Unsortierte Spalten fassen die Eigenschaften aller Objekte zusammen, die in diese Zeile fallen. \r\n" +
        "Für solche Summenspalten können Sie die Summe berechnen.",
      "列可以按升序或降序排序。 \r\n" +
        "排序列中具有相同属性的对象被认为是相同的并且属于表的同一行。 \r\n" +
        "未排序的列将汇总所有落入该行的对象的属性。\r\n" +
        "对于此类总计列，您可以计算总计。",
      "Una columna se puede ordenar en orden ascendente o descendente. \r\n" +  // ES
        "Los objetos con las mismas propiedades de las columnas ordenadas \r\n" +
        "se consideran iguales y caen en la misma fila de la tabla. \r\n" +
        "Las columnas no ordenadas resumirán las propiedades de todos los objetos que caen en esta fila.\r\n" +
        "Para tales columnas totales, puede calcular el total.",
      "Une colonne peut être triée par ordre croissant ou décroissant. \r\n" +  // FR
        "Les objets ayant les mêmes propriétés des colonnes triées \r\n" +
        "sont considérés comme identiques et tombent dans la même ligne de la table. \r\n" +
        "Les colonnes non triées résumeront les propriétés de tous les objets qui tombent dans cette ligne.\r\n" +
        "Pour de telles colonnes totales, vous pouvez calculer le total.",
      "Bir sütun artan veya azalan sırada sıralanabilir. \r\n" +  // TR
        "Sıralanan sütunlardan aynı özelliklere sahip nesneler \r\n" +
        "aynı kabul edilir ve tablonun aynı satırına düşer. \r\n" +
        "Sıralanmamış sütunlar bu satıra düşen tüm nesnelerin özelliklerini özetleyecektir.\r\n" +
        "Bu tür toplam sütunlar için toplamı hesaplayabilirsiniz." };

    public static readonly string[] GroupTip = {
      "Substitution for group headings. \r\n" +
        "If you do not need any grouping, then leave the field blank.",
      "Подстановки для заголовка групп данных в таблице. \r\n" +
        "Оставьте строку пустой, если не нужна никакая группировка.",
      "Sostituzione delle intestazioni di gruppo. \r\n" +
        "Se non è necessario alcun raggruppamento, lasciare il campo vuoto.",
      "Ersatz für Gruppenüberschriften.\r\n" +
        " Wenn Sie keine Gruppierung benötigen, lassen Sie das Feld leer.",
      "替换组标题。 \r\n" +
        "如果您不需要任何分组，则将该字段留空。",
      "Sustitución de encabezados de grupo. \r\n" +  // ES
        "Si no necesita ninguna agrupación, deje el campo en blanco.",
      "Substitution pour les en-têtes de groupe. \r\n" +  // FR
        "Si vous n'avez pas besoin de regroupement, laissez le champ vide.",
      "Grup başlıkları için ikame. \r\n" +  // TR
        "Herhangi bir gruplama gerekmiyorsa alanı boş bırakın." };

    public static readonly string[] StyleNameTip = {
      "Name of Data Table style. \r\n" +
        "Can be used like title of table. \r\n" +
        "The title may contain substitutions from the properties of the drawing or time.",
      "Имя стиля Таблицы данных. \r\n" +
        "Можно использовать как заголовок таблицы. \r\n" +
        "В заголовке можно использовать подстановки свойств чертежа и времени.",
      "Nome dello stile della tabella dei dati. \r\n" +
        "Può essere usato come il titolo della tabella. \r\n" +
        "Il titolo può contenere sostituzioni dalle proprietà del disegno o del tempo.",
      "Name des Datentabellenstils. \r\n" +
        "Kann als Tabellentitel verwendet werden. \r\n" +
        "Der Titel kann Ersetzungen aus den Eigenschaften der Zeichnung oder Zeit enthalten.",
      "数据表样式的名称。 \r\n" +
        "可以用作表格的标题。 \r\n" +
        "标题可能包含来自绘图或时间属性的替换。",
      "Nombre del estilo de Tabla de Datos. \r\n" +  // ES
        "Se puede usar como título de tabla. \r\n" +
        "El título puede contener sustituciones de las propiedades del dibujo o el tiempo.",
      "Nom du style de Table de Données. \r\n" +  // FR
        "Peut être utilisé comme titre de table. \r\n" +
        "Le titre peut contenir des substitutions des propriétés du dessin ou du temps.",
      "Veri Tablosu stili adı. \r\n" +  // TR
        "Tablo başlığı gibi kullanılabilir. \r\n" +
        "Başlık çizim veya zaman özelliklerinden ikameleri içerebilir." };

    public static readonly string[] Source = {
      "Data Source",
      "Источник данных",
      "Fonte di dati",
      "Datenquelle",
      "資料來源",
      "Fuente de datos",                                         // ES
      "Source de données",                                       // FR
      "Veri kaynağı"};                                           // TR

    public static readonly string[] Select = {
      "Select objects",
      "Выбрать объекты",
      "Seleziona oggetti",
      "Wählen Sie Objekte aus",
      "選擇對象",
      "Seleccionar objetos",                                     // ES
      "Sélectionner des objets",                                 // FR
      "Nesneleri seç"};                                          // TR

    public static readonly string[] SelectTip = {
      "Specify drawing objects from which information for the table will be retrieved.",
      "Указать объекты чертежа, из которых будет извлекаться информация для таблицы.",
      "Specificare gli oggetti della Carta da cui verranno recuperate le informazioni per la tabella.",
      "Geben Sie Zeichnungsobjekte an, aus denen Informationen für die Tabelle abgerufen werden.",
      "指定將從中檢索表格資訊的圖形物件。",
      "Especifique los objetos de dibujo de los cuales se recuperará información para la tabla.",  // ES
      "Spécifiez les objets de dessin à partir desquels les informations pour la table seront récupérées.",  // FR
      "Tablo için bilgilerin alınacağı çizim nesnelerini belirtin."};  // TR

    public static readonly string[] SelectView = {
      "Select view or viewport",
      "Выбрать вид или вьюпорт",
      "Seleziona vista o viewport",
      "Ansicht oder Ansichtsfenster auswählen",
      "选择视图或视口",
      "Seleccionar vista o ventana gráfica",                     // ES
      "Sélectionner une vue ou une fenêtre",                     // FR
      "Görünüm veya pencere seç"};                               // TR

    public static readonly string[] SelectViewTip = {
      "Process all objects that are visible in one view ModelDoc=ViewBase or in one viewport. \r\n" +
        "When called from the model - request a selection of objects.",
      "Обрабатывать все объекты, которые видны на одном виде ModelDoc=ВидБаз или в одном вьюпорте. \r\n" +
        "При вызове из модели - запросить выбор объектов.",
      "Elabora tutti gli oggetti visibili in una vista ModelDoc=ViewBase o in una finestra. \r\n" +
        "Quando viene chiamato da un modello, richiede una selezione di oggetti.",
      "Verarbeiten Sie alle Objekte, die in einer ModelDoc=ViewBase-Ansicht oder in einem Ansichtsfenster sichtbar sind. \r\n" +
        "Fordern Sie beim Aufruf von einem Modell eine Auswahl von Objekten an.",
      "处理在一个 ModelDoc=ViewBase 视图或一个视口中可见的所有对象。\r\n" +
        "当从模型调用时，请求选择对象。",
      "Procesar todos los objetos que son visibles en una vista ModelDoc=ViewBase o en una ventana gráfica. \r\n" +  // ES
        "Cuando se llama desde el modelo, solicitar una selección de objetos.",
      "Traiter tous les objets visibles dans une vue ModelDoc=ViewBase ou dans une fenêtre. \r\n" +  // FR
        "Lorsqu'il est appelé depuis le modèle, demander une sélection d'objets.",
      "Bir ModelDoc=ViewBase görünümünde veya bir pencerede görünür olan tüm nesneleri işleyin. \r\n" +  // TR
        "Modelden çağrıldığında - nesnelerin seçimini isteyin."};

    public static readonly string[] Model = {
      "All model objects",
      "Все объекты модели",
      "Tutti gli oggetti del modello",
      "Alle Modellobjekte",
      "所有模型對象",
      "Todos los objetos del modelo",                            // ES
      "Tous les objets du modèle",                               // FR
      "Tüm model nesneleri"};                                    // TR

    public static readonly string[] ModelTip = {
      "Extract data from all model objects that match the filtering conditions.",
      "Извлечь данные из всех объектов модели, которые подходят под условия фильтрации.",
      "Estrai i dati da tutti gli oggetti del modello che corrispondono alle condizioni di filtro.",
      "Extrahieren Sie Daten aus allen Modellobjekten, die den Filterbedingungen entsprechen.",
      "從所有符合篩選條件的模型物件中擷取資料。",
      "Extraer datos de todos los objetos del modelo que coincidan con las condiciones de filtrado.",  // ES
      "Extraire des données de tous les objets du modèle qui correspondent aux conditions de filtrage.",  // FR
      "Filtreleme koşullarına uyan tüm model nesnelerinden veri çıkarın."};  // TR

    public static readonly string[] Viewports = {
      "Layout Viewports",
      "Вьюпорты листа",
      "Viste di layout",
      "Layout-Ansichtsfenster",
      "佈局視窗",
      "Ventanas gráficas de diseño",                             // ES
      "Fenêtres de présentation",                                // FR
      "Düzen pencereleri"};                                      // TR

    public static readonly string[] ViewportsTip = {
      "Extract data into a table from all objects that are at least slightly visible in any viewport of the current sheet. \r\n" +
        "When called from a model, all model objects.",
      "Извлечь данные в таблицу из всех объектов, которые хоть немного видны в любом вьюпорте текущего листа. \r\n" +
        "При вызове из модели - все объекты модели.",
      "Estrai i dati in una tabella da tutti gli oggetti che sono almeno leggermente visibili in qualsiasi finestra \r\n" +
        "del foglio corrente. Quando chiamati da un modello, tutti gli oggetti del modello.",
      "Extrahieren Sie Daten aus allen Objekten, die in einem beliebigen Ansichtsfenster des aktuellen Blatts zumindest \r\n" +
        "leicht sichtbar sind, in eine Tabelle. Bei Aufruf aus einem Modell alle Modellobjekte.",
      "从当前工作表的任何视口中至少稍微可见的所有对象中将数据提取到表中。\r\n" +
        "当从模型调用时，所有模型对象。",
      "Extraer datos en una tabla de todos los objetos que son al menos ligeramente visibles en cualquier ventana gráfica de la hoja actual. \r\n" +  // ES
        "Cuando se llama desde un modelo, todos los objetos del modelo.",
      "Extraire des données dans une table de tous les objets qui sont au moins légèrement visibles dans n'importe quelle fenêtre de la feuille actuelle. \r\n" +  // FR
        "Lorsqu'il est appelé depuis un modèle, tous les objets du modèle.",
      "Geçerli sayfanın herhangi bir penceresinde en azından biraz görünür olan tüm nesnelerden bir tabloya veri çıkarın. \r\n" +  // TR
        "Bir modelden çağrıldığında, tüm model nesneleri."};

    public static readonly string[] Files = {
      "DWG Files",
      "DWG-Файлы",
      "File DWG",
      "DWG-Dateien",
      "DWG 文件",
      "Archivos DWG",                                            // ES
      "Fichiers DWG",                                            // FR
      "DWG Dosyaları"};                                          // TR

    public static readonly string[] FilesTip = {
      "Extract data into a table from all objects of all models from multiple drawings. \r\n" +
        "The program will prompt you to select DWG or DXF files.",
      "Извлечь данные в таблицу из всех объектов всех моделей из нескольких чертежей. \r\n" +
        "Программа предложит выбрать DWG или DXF файлы.",
      "Estrai i dati in una tabella da tutti gli oggetti di tutti i modelli da più disegni. \r\n" +
        "Il programma ti chiederà di selezionare file DWG o DXF.",
      "Extrahieren Sie Daten aus allen Objekten aller Modelle aus mehreren Zeichnungen in eine Tabelle. \r\n" +
        "Das Programm fordert Sie auf, DWG- oder DXF-Dateien auszuwählen.",
      "将多个图纸中所有模型的所有对象的数据提取到表中。\r\n" +
        "程序将提示您选择 DWG 或 DXF 文件。",
      "Extraer datos en una tabla de todos los objetos de todos los modelos de múltiples dibujos. \r\n" +  // ES
        "El programa le pedirá que seleccione archivos DWG o DXF.",
      "Extraire des données dans une table de tous les objets de tous les modèles de plusieurs dessins. \r\n" +  // FR
        "Le programme vous demandera de sélectionner des fichiers DWG ou DXF.",
      "Birden çok çizimden tüm modellerin tüm nesnelerinden bir tabloya veri çıkarın. \r\n" +  // TR
        "Program DWG veya DXF dosyalarını seçmenizi isteyecektir."};

    public static readonly string[] NoDrilling = {
      "There is not a single drilling in solids.",
      "В солидах нет ни одного сверления.",
      "Non è stata effettuata alcuna perforazione nei solidi.",
      "Es erfolgt keine einzige Bohrung im Vollmaterial.",
      "固体中没有一个钻孔。",
      "No hay ni una sola perforación en los sólidos.",          // ES
      "Il n'y a pas un seul perçage dans les solides.",         // FR
      "Katılarda tek bir delme yok."};                           // TR

    public static readonly string[] NoMaterial = {
      "No materials or coatings assigned.",
      "Не назначено ни одного материала или покрытия.",
      "Nessun materiale o rivestimento assegnato.",
      "Keine Materialien oder Beschichtungen zugewiesen.",
      "未指定材料或涂层。",
      "No se asignaron materiales o recubrimientos.",            // ES
      "Aucun matériau ou revêtement attribué.",                  // FR
      "Malzeme veya kaplama atanmamış."};                        // TR

  }
}
