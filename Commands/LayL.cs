// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация команды LAY
  /// </summary>
  public static class LayL
  {
    public static readonly string[][] LayStyleNames = {
/* 0 */ CommandL.Lay,
/* 1 */ CommandL.Lay,
/* 2 */ new []{
        "Export",
        "Экспорт",
        "Esportare",
        "Export",
        "输出",
        "Exportar",                                              // ES
        "Exporter",                                              // FR
        "Dışa aktar" },                                          // TR
    };

    public static readonly string[] Select = {
      "  Select assembly consisting of 3DSolid",
      "  Выберите сборку из деталей типа 3DSolid",
      "  Selezionare l'assemblaggio costituito da 3DSolidi",
      "  Wählen Sie eine Baugruppe aus Teilen vom Typ 3DSolid aus",
      "  选择装配体或三维实体",
      "  Seleccione el ensamblaje que consta de 3DSolid",       // ES
      "  Sélectionnez l'assemblage composé de 3DSolid",         // FR
      "  3DSolid'den oluşan montajı seçin"};                    // TR

    public static readonly string[] Point = {
      "  Specify the coordinates to insert laid solids",
      "  Укажите координаты, где начинать выкладку деталей",
      "  Specificare coordinate di inserimento lista pezzi",
      "  Geben Sie die Koordinaten an, an denen die Berechnung der Teile beginnen soll",
      "  指定插入点",
      "  Especifique las coordenadas para insertar sólidos colocados",  // ES
      "  Spécifiez les coordonnées pour insérer les solides disposés",  // FR
      "  Yerleştirilen katıları eklemek için koordinatları belirtin"};  // TR

    public static readonly string[] StyleSelected = {
      "  LAY-style '{0}' selected",
      "  Выбран стиль выкладки '{0}'",
      "  LAY-Stile '{0}' selezionato",
      "  LAY-Stil '{0}' ausgewählt",
      "  平铺样式 '{0}' 选择",
      "  Estilo LAY '{0}' seleccionado",                         // ES
      "  Style LAY '{0}' sélectionné",                           // FR
      "  LAY stili '{0}' seçildi"};                              // TR

    public static readonly string[] StepQuery = {
      "Input step between details",
      "Введите шаг между выложенными деталями",
      "Inserire la distanza tra le parti disposte",
      "Geben Sie den Schritt zwischen den Teilen ein",
      "输入图形间距",
      "Ingrese el paso entre detalles",                          // ES
      "Entrez le pas entre les détails",                         // FR
      "Detaylar arasındaki adımı girin"};                        // TR

    public static readonly string[] MirroredQuery = {
      "Lay mirrored solid separately (not group)?",
      "Выкладывать зеркальные солиды отдельно (не группировать)?",
      "Diffusione specchiata solidi separatamente (non di gruppo)?",
      "Gespiegelte Teile separat verteilen (nicht gruppieren)?",
      "镜像图形单独放置",
      "¿Colocar sólido reflejado por separado (no agrupar)?",    // ES
      "Disposer le solide en miroir séparément (pas grouper) ?", // FR
      "Aynalı katıyı ayrı olarak yerleştir (gruplamadan)?"};     // TR

    public static readonly string[] MergeSameDataQuery = {
      "Group the same (Lay the same parts only once and write their number in the header)?",
      "Группировать одинаковые (Выкладывать одинаковые детали только один раз и писать в заголовке их количество) ?",
      "Creare gruppi parti identiche? (verrà scritto il numero delle parti nel titolo)",
      "Gleiche gruppieren (gleiche Teile nur einmal verteilen und deren Nummer in die Kopfzeile schreiben)?",
      "合并相同对象,文字相应合并.",
      "¿Agrupar iguales (Colocar las mismas piezas solo una vez y escribir su número en el encabezado)?",  // ES
      "Regrouper les identiques (Disposer les mêmes pièces une seule fois et écrire leur nombre dans l'en-tête) ?",  // FR
      "Aynıları grupla (Aynı parçaları yalnızca bir kez yerleştir ve başlıkta sayılarını yaz)?"};  // TR

    public static readonly string[] FlatShotQuery = {
      "Make FlatShot?",
      "Делать плоские контуры ?",
      "Creare geometrie piatte?",
      "Flache Konturen machen?",
      "生成二维图形?",
      "¿Hacer FlatShot?",                                        // ES
      "Faire FlatShot ?",                                        // FR
      "FlatShot yap?"};                                          // TR

    public static readonly string[] TitleQuery = {
      "Title template. Default '?'. Use parameters inside %",
      "Введите шаблон заголовка или пустую строку. Используйте подстановки в символах '%' ",
      "Modello di titolo predefinito?  Inserire modello di intestazione o una stringa vuota '%' ",
      "Geben Sie eine Titelvorlage oder eine leere Zeile ein. Verwenden Sie Platzhalter in den Zeichen '%'",
      "文字模板. 默认 '?'. 在%中使用参数",
      "Plantilla de título. Predeterminado '?'. Use parámetros dentro de %",  // ES
      "Modèle de titre. Par défaut '?'. Utilisez les paramètres dans %",  // FR
      "Başlık şablonu. Varsayılan '?'. % içinde parametreleri kullanın"};  // TR

    public static readonly string[] DefaultTitle = {
      "Default title saved",
      "Будет использован заголовок по умолчанию",
      "Intestazione predefinita salvata",
      "Будет использован заголовок по умолчанию",
      "默认文本已保存",
      "Título predeterminado guardado",                          // ES
      "Titre par défaut enregistré",                            // FR
      "Varsayılan başlık kaydedildi"};                          // TR

    public static readonly string[] CenterQuery = {
      "Align title to the center of detail",
      "Выравнивать заголовок по центру детали",
      "Allinea descrizione al centro della geometria",
      "Zentrieren Sie den Titel des Teils",
      "将文字与图形中心对齐",
      "Alinear título al centro del detalle",                    // ES
      "Aligner le titre au centre du détail",                    // FR
      "Başlığı detayın merkezine hizala"};                       // TR

    public static readonly string[] InsideQuery = {
      "Place the title inside a detail",
      "Располагать заголовок внутри детали",
      "Posiziona descrizione all'interno della geometria",
      "Positionieren Sie den Header im Innenteil",
      "将文字放在详细信息中",
      "Colocar el título dentro de un detalle",                  // ES
      "Placer le titre à l'intérieur d'un détail",              // FR
      "Başlığı bir detayın içine yerleştir"};                    // TR

    public static readonly string[] HeightQuery = {
      "Title text height. 0 - use _TEXTSIZE variable",
      "Высота текста заголовка. 0 - использовать переменную _TEXTSIZE",
      "Altezza del testo. 0 – Utilizzare la variabile _TEXTSIZE",
      "Die Höhe des Titeltextes. 0 - Verwenden Sie die Variable _TEXTSIZE",
      "文字高度。 0 - 使用 _TEXTSIZE 变量字高",
      "Altura del texto del título. 0 - usar variable _TEXTSIZE",  // ES
      "Hauteur du texte du titre. 0 - utiliser la variable _TEXTSIZE",  // FR
      "Başlık metin yüksekliği. 0 - _TEXTSIZE değişkenini kullan"};  // TR

    public static readonly string[] StyleQuery = {
      "Title text style",
      "Стиль текста заголовка",
      "Stile testo della descrizione",
      "Kopfzeilentextstil",
      "文字样式",
      "Estilo de texto del título",                              // ES
      "Style de texte du titre",                                 // FR
      "Başlık metin stili"};                                     // TR

    public static readonly string[] StyleInfo = {
      "Current style will use '{0}'",
      "Будет использован текущий стиль '{0}'",
      "Utilizza stile corrente '{0}'",
      "Verwendet den aktuellen Stil '{0}'",
      "当前样式'{0}'",
      "Se usará el estilo actual '{0}'",                         // ES
      "Le style actuel utilisera '{0}'",                         // FR
      "Mevcut stil '{0}' kullanılacak"};                         // TR

    public static readonly string[] TextureQuery = {
      "Write mark of texture",
      "Помечать текстуру",
      "Scrivere texture",
      "Schreiben Sie eine Markierung der Textur",
      "纹理标记",
      "Escribir marca de textura",                               // ES
      "Écrire la marque de texture",                             // FR
      "Doku işareti yaz"};                                       // TR

    public static readonly string[] NumberingQuery = {
      "Numbering of solids",
      "Нумерация солидов",
      "Numerazione dei solidi",
      "Nummerierung der Details",
      "编号",
      "Numeración de sólidos",                                   // ES
      "Numérotation des solides",                                // FR
      "Katıların numaralandırılması"};                           // TR

    public static readonly string[] MultiplierQuery = {
      "Request multiplier every time",
      "Запрашивать множитель каждый раз",
      "Richiedere moltiplicatore ogni volta",
      "Fordern Sie jedes Mal einen Multiplikator an.",
      "对象倍数",
      "Solicitar multiplicador cada vez",                        // ES
      "Demander le multiplicateur à chaque fois",                // FR
      "Her seferinde çarpanı iste"};                             // TR

    //------------- Command Line --------------------------------------------
    public static readonly string[] StepKW = {
      "Step",
      "Шаг",
      "PAsso",
      "SCHritt",
      "步(Step)",
      "PAso",                                                    // ES
      "PAs",                                                     // FR
      "ADım"};                                                   // TR

    public static readonly string[] MirrorKW = {
      "MIrror",
      "ЗЕркальные",
      "SPecchio",
      "SPiegeln",
      "镜像(MI)",
      "ESPejo",                                                  // ES
      "MIroir",                                                  // FR
      "AYna"};                                                   // TR

    public static readonly string[] MergeKW = {
      "GRoup",
      "ГРуппировка",
      "GRuppo",
      "Gruppe",
      "组(GR)",
      "GRupo",                                                   // ES
      "GRoupe",                                                  // FR
      "GRup"};                                                   // TR

    public static readonly string[] FlatShotKW = {
      "FLatShot",
      "ПЛоскийСлепок",
      "GEomPiatta",
      "Flachguss",
      "平面(FL)",
      "TOmaPlana",                                               // ES
      "PriseDePlat",                                             // FR
      "DÜzÇekim"};                                               // TR

    public static readonly string[] TitleKW = {
      "TItle",
      "ЗАголовок",
      "TItolo",
      "TItel",
      "标题(TI)",
      "TÍtulo",                                                  // ES
      "TItre",                                                   // FR
      "BAşlık"};                                                 // TR

    public static readonly string[] StyleKW = {
      "STYle",
      "СТиль",
      "STile",
      "STil",
      "样式(STY)",
      "ESTilo",                                                  // ES
      "STYle",                                                   // FR
      "STil"};                                                   // TR

    public static readonly string[] HeightKW = {
      "HEight",
      "ВЫсота",
      "ALTezza",
      "Höhe",
      "高度(HE)",
      "ALtura",                                                  // ES
      "HAuteur",                                                 // FR
      "YÜkseklik"};                                              // TR

    public static readonly string[] CenterKW = {
      "CEnter",
      "ЦЕнтрировать",
      "CEntro",
      "Zentrum",
      "中心(CE)",
      "CEntro",                                                  // ES
      "CEntre",                                                  // FR
      "MERkez"};                                                 // TR

    public static readonly string[] InsideKW = {
      "INside",
      "ВНутри",
      "INterno",
      "Innerhalb",
      "内部(IN)",
      "DEntro",                                                  // ES
      "INtérieur",                                               // FR
      "İÇinde"};                                                 // TR

    public static readonly string[] TextureKW = {
      "TExture",
      "ТЕкстура",
      "TExture",
      "TExtur",
      "纹理(TE)",
      "TExtura",                                                 // ES
      "TExture",                                                 // FR
      "DOku"};                                                   // TR

    public static readonly string[] NumberingKW = {
      "NUmbering",
      "НУмерация",
      "NUmerazione",
      "NUmmerierung",
      "编号(NU)",
      "NUmeración",                                              // ES
      "NUmérotation",                                            // FR
      "NUmaralandırma"};                                         // TR

    public static readonly string[] MultiplierKW = {
      "MUltiplier",
      "Множитель",
      "MOltiplicatore",
      "Multiplikator",
      "倍数(MU)",
      "MUltiplicador",                                           // ES
      "MUltiplicateur",                                          // FR
      "ÇArpan"};                                                 // TR

    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

    // ==================================== Options Dialog Box ===============================================

    public static readonly string[] DialogTitle = {
      "LAY options",
      "Настройки выкладки",
      "Opzioni di LAY",
      "LAY-optionen",
      "平铺 设置选项",
      "Opciones de LAY",                                         // ES
      "Options LAY",                                             // FR
      "LAY seçenekleri"};                                        // TR

    public static readonly string[] StyleNameTip = {
      "The name for this lay-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля выкладки. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile lay (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Lay-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此平铺样式名称作为备注使用，程序中使用前面的序号。",
      "El nombre de este estilo de disposición (conjunto de configuraciones). No se usa en el programa. Solo por conveniencia de elección.",  // ES
      "Le nom de ce style de disposition (ensemble de paramètres). Non utilisé dans le programme. Seulement pour la commodité du choix.",  // FR
      "Bu yerleşim stili için ad (ayar kümesi). Programda kullanılmaz. Sadece seçim kolaylığı için."};  // TR

    public static readonly string[] Grouping = {
      "Grouping",
      "Группировка",
      "Raggruppamento",
      "Gruppierung",
      "分组设置",
      "Agrupación",                                              // ES
      "Regroupement",                                            // FR
      "Gruplama"};                                               // TR

    public static readonly string[] GroupingTip = {
      "Grouping parts into separate columns.\r\n"+
        "Insert into the list of substitutions, when changing which\r\n"+
        "you want to create a separate column of parts.\r\n"+
        "If you do not need any grouping, then leave the field blank.",
      "Группирование деталей в отдельные столбики.\r\n" +
        "Вставьте в список подстановки, при изменении которых надо создавать отдельный столбик деталей.\r\n" +
        "Если группировка не нужна, то оставьте поле пустым.",
      "Raggruppamento di parti in colonne separate.\r\n" +
        "Inserire nell'elenco delle sostituzioni, \r\n" +
        "quando si cambia quale si desidera creare una colonna separata di parti.\r\n" +
        "Se non hai bisogno di alcun raggruppamento, lascia il campo vuoto.",
      "Gruppieren von Teilen in separaten Spalten.\r\n" +
        "Fügen Sie in die Liste der Substitutionen ein,\r\n" +
        "wenn Sie ändern möchten, welche Sie eine separate Spalte mit Teilen erstellen möchten.\r\n" +
        "Wenn Sie keine Gruppierung benötigen, lassen Sie das Feld leer.",
      "将图形按规则进行分组排列。如果留空将不分组，分组可以按 '块'  '颜色'  '图层' 等进行。注意：替换字符为英文。",
      "Agrupar piezas en columnas separadas.\r\n" +  // ES
        "Inserte en la lista de sustituciones, al cambiar las cuales\r\n" +
        "desea crear una columna separada de piezas.\r\n" +
        "Si no necesita ninguna agrupación, deje el campo en blanco.",
      "Regrouper les pièces en colonnes séparées.\r\n" +  // FR
        "Insérez dans la liste des substitutions, lors du changement desquelles\r\n" +
        "vous souhaitez créer une colonne séparée de pièces.\r\n" +
        "Si vous n'avez besoin d'aucun regroupement, laissez le champ vide.",
      "Parçaları ayrı sütunlara gruplandırma.\r\n" +  // TR
        "Değiştirirken ayrı bir parça sütunu oluşturmak istediğiniz\r\n" +
        "değiştirmelerin listesine ekleyin.\r\n" +
        "Herhangi bir gruplama gerekmiyorsa alanı boş bırakın."};

    public static readonly string[] TitleSort = {
      "Title and sorting",
      "Заголовок и сортировка",
      "Titolo e ordinamento",
      "Titel und Sortierung",
      "标题和排序",
      "Título y ordenación",                                     // ES
      "Titre et tri",                                            // FR
      "Başlık ve sıralama"};                                     // TR

    public static readonly string[] TitleTip = {
      "Detail header template.\r\n" +
        "Use property substitutions for solid, material, block-assembly and drawing.\r\n" +
        "You can add any text and formatting characters (eg \\P - line break).\r\n" +
        "Leave an empty line so that the program will automatically create a template \r\n" +
        "depending on the selection conditions.",
      "Шаблон заголовка детали.\r\n"+
        "Используйте подстановки свойств солида, материала, блока-сборки и чертежа.\r\n"+
        "В можете добавить любой текст и символы форматирования (например \\P - перенос строки).\r\n" +
        "Оставьте пустую строку, чтоб программа создала шаблон автоматически\r\n"+
        "в зависимости от условий отбора.",
      "Modello di intestazione di dettaglio.\r\n" +
        "Utilizza le sostituzioni di proprietà per solidi, materiali, assiemi di blocchi e disegni.\r\n" +
        "Puoi aggiungere qualsiasi testo e carattere di formattazione (ad es. \\P - interruzione di riga).\r\n" +
        "Lasciare una riga vuota in modo che il programma crei automaticamente un modello \r\n" +
        "in base alle condizioni di selezione.",
      "Detail-Header-Vorlage.\r\n" +
        "Verwenden Sie Eigenschaftsersetzungen für Volumenkörper, Materialien, Blockbaugruppen und Zeichnungen.\r\n" +
        "Sie können beliebigen Text und Formatierungszeichen hinzufügen (zB \\P - Zeilenumbruch).\r\n" +
        "Lassen Sie eine leere Zeile, damit das Programm abhängig von den Auswahlbedingungen \r\n" +
        "automatisch eine Vorlage erstellt.",
      "详细标题模板。\r\n" +
        "对实体、材料、块组件和工程图使用属性替换。\r\n" +
        "您可以添加任何文本和格式字符（例如 \\P - 换行符）。\r\n" +
        "保留一个空行，以便程序将根据选择条件自动创建模板。",
      "Plantilla de encabezado de detalle.\r\n" +  // ES
        "Use sustituciones de propiedades para sólido, material, ensamblaje de bloques y dibujo.\r\n" +
        "Puede agregar cualquier texto y caracteres de formato (por ejemplo, \\P - salto de línea).\r\n" +
        "Deje una línea vacía para que el programa cree automáticamente una plantilla \r\n" +
        "según las condiciones de selección.",
      "Modèle d'en-tête de détail.\r\n" +  // FR
        "Utilisez des substitutions de propriétés pour solide, matériau, assemblage de blocs et dessin.\r\n" +
        "Vous pouvez ajouter n'importe quel texte et caractères de formatage (par ex. \\P - saut de ligne).\r\n" +
        "Laissez une ligne vide pour que le programme crée automatiquement un modèle \r\n" +
        "en fonction des conditions de sélection.",
      "Detay başlığı şablonu.\r\n" +  // TR
        "Katı, malzeme, blok montajı ve çizim için özellik ikamelerini kullanın.\r\n" +
        "Herhangi bir metin ve biçimlendirme karakteri ekleyebilirsiniz (örn. \\P - satır sonu).\r\n" +
        "Programın seçim koşullarına bağlı olarak otomatik olarak bir şablon oluşturması için \r\n" +
        "boş bir satır bırakın."};

    public static readonly string[] DetailSpace = {
      "Part space",
      "Отступ детали",
      "Rientro di dettaglio",
      "Detaileinzug",
      "细节缩进",
      "Espacio de pieza",                                        // ES
      "Espace de pièce",                                         // FR
      "Parça boşluğu"};                                          // TR

    public static readonly string[] DetailSpaceTip = {
      "Distance between parts along the Y axis.\r\n" +
        "From the bottom of the previous part to the head of the next part.\r\n" +
        "Set it to 0 to have the program choose the indentation \r\n" +
        "based on the height of the title text and the dimensions of the part.",
      "Расстояние между деталями по оси Y. \r\n" +
        "От низа предыдущей детали до заголовка следующей детали.\r\n"+
        "Назначьте 0, чтоб программа сама выбрала отступ в зависимости от высоты текста заголовка и размеров детали.",
      "Distanza tra le parti lungo l'asse Y. \r\n" +
        "Dal fondo della parte precedente all'intestazione della parte successiva. \r\n" +
        "Impostalo a 0 per consentire al programma di scegliere il rientro \r\n" +
        "in base all'altezza del testo del titolo e alle dimensioni della parte.",
      "Abstand zwischen Teilen entlang der Y-Achse. \r\n" +
        "Von der Unterseite des vorherigen Teils bis zur Kopfzeile des nächsten Teils. \r\n" +
        "Setzen Sie ihn auf 0, damit das Programm den Einzug basierend \r\n" +
        "auf der Höhe des Titeltextes und den Abmessungen des Teils wählt.",
      "沿 Y 轴的部件之间的距离。\r\n" +
        "从上一个部件的底部到下一个部件的标题。 \r\n" +
        "将其设置为 0 以让程序根据标题文本的高度和零件的尺寸来选择缩进。",
      "Distancia entre piezas a lo largo del eje Y.\r\n" +  // ES
        "Desde la parte inferior de la pieza anterior hasta el encabezado de la siguiente pieza.\r\n" +
        "Establézcalo en 0 para que el programa elija la sangría \r\n" +
        "según la altura del texto del título y las dimensiones de la pieza.",
      "Distance entre les pièces le long de l'axe Y.\r\n" +  // FR
        "Du bas de la pièce précédente à l'en-tête de la pièce suivante.\r\n" +
        "Réglez-le sur 0 pour que le programme choisisse le retrait \r\n" +
        "en fonction de la hauteur du texte du titre et des dimensions de la pièce.",
      "Y ekseni boyunca parçalar arasındaki mesafe.\r\n" +  // TR
        "Önceki parçanın altından bir sonraki parçanın başlığına kadar.\r\n" +
        "Programın başlık metninin yüksekliğine ve parçanın boyutlarına göre girintiyi seçmesi için \r\n" +
        "0 olarak ayarlayın."};

    public static readonly string[] FrontTo = {
      "Lay the front",
      "Выложить фасадом",
      "AStenditi in",
      "Front nach auslegen",
      "面方向选项",
      "Colocar el frente",                                       // ES
      "Disposer la façade",                                      // FR
      "Ön yüzü yerleştir"};                                      // TR

    public static readonly string[] Up = {
      "Up",
      "Вверх",
      "Su",
      "Hoch",
      "面朝上",
      "Arriba",                                                  // ES
      "Haut",                                                    // FR
      "Yukarı"};                                                 // TR

    public static readonly string[] UpTip = {
      "Lay the parts with the main (best, facade) side up on the Z.\r\n"+
        "Optimal for processing parts on panel saw machines.",
      "Выложить детали главной (наилучшей, фасадной) стороной вверх по Z.\r\n"+
        "Оптимально для обработки деталей на форматно-раскроечных станках.",
      "Posare i pezzi con il lato principale (migliore, facciata) sulla Z.\r\n " +
        "Ottimale per la lavorazione di pezzi su macchine sezionatrici.",
      "Legen Sie die Teile mit der Haupt- (am besten Fassade) Seite nach oben auf das Z.\r\n" +
        "Optimal für die Bearbeitung von Teilen auf Plattensägemaschinen.",
      "将正面朝上平铺零件。\r\n" +
         "最适合在裁板锯机上加工零件。",
      "Colocar las piezas con el lado principal (mejor, fachada) hacia arriba en Z.\r\n" +  // ES
        "Óptimo para procesar piezas en máquinas de sierra de panel.",
      "Disposer les pièces avec le côté principal (meilleur, façade) vers le haut sur Z.\r\n" +  // FR
        "Optimal pour le traitement des pièces sur des scies à panneaux.",
      "Parçaları ana (en iyi, cephe) tarafı yukarıda olacak şekilde Z üzerine yerleştirin.\r\n" +  // TR
        "Panel testere makinelerinde parçaları işlemek için idealdir."};

    public static readonly string[] Down = {
      "Down",
      "Вниз",
      "Giù",
      "Runter",
      "面朝下",
      "Abajo",                                                   // ES
      "Bas",                                                     // FR
      "Aşağı"};                                                  // TR

    public static readonly string[] DownTip = {
      "Lay out the parts with the main (best, facade) side down Z.\r\n"+
        "Optimal for machining parts on CNC milling machines and machining centers.\r\n"+
        "The facade surface is selected: \r\n"+
        "1. Marked with color,\r\n"+
        "2. Maximum in area,\r\n"+
        "3. Coating material assigned,\r\n"+
        "4. Initially turned up.\r\n"+
        "1 and 4 can be disabled in the Common Options.",
      "Выложить детали главной (наилучшей, фасадной) стороной вниз по Z.\r\n"+
        "Оптимально для обработки деталей на фрезерах ЧПУ и обрабатывающих центрах.\r\n"+
        "Фасадная поверхности выбирается:\r\n"+
        "1. Помеченная цветом,\r\n"+
        "2. Максимальная по площади,\r\n"+
        "3. Присвоен материал покрытия,\r\n"+
        "4. Изначально повернутая вверх.\r\n"+
        "1 и 4 отключается в Общих настройках.",
      "Disporre le parti con il lato principale (migliore, anteriore) rivolto verso il basso in Z.\r\n" +
        "Ideale per la lavorazione di parti su router e centri di lavoro CNC.\r\n" +
        "La superficie della facciata è selezionata:\r\n"+
         "1. Colorato,\r\n"+
         "2. Area massima,\r\n"+
         "3. Materiale di rivestimento assegnato,\r\n"+
         "4. Inizialmente rivolto verso l'alto.\r\n"+
         "1 e 4 sono disabilitati nelle impostazioni generali.",
      "Legen Sie die Teile mit der Haupt- (besten, vorderen) Seite nach unten in Z.\r\n" +
        "Optimal für die Bearbeitung von Teilen auf CNC-Fräsen und Bearbeitungszentren.\r\n" +
        "Fassadenoberfläche ist ausgewählt:\r\n"+
         "1. Farbig,\r\n"+
         "2. Maximale Fläche,\r\n"+
         "3. Beschichtungsmaterial zugewiesen,\r\n"+
         "4. Anfänglich nach oben zeigend.\r\n"+
         "1 und 4 sind in den allgemeinen Einstellungen deaktiviert.",
      "将正面朝下平铺零件。工艺复杂的一面朝上，\r\n"+
         "最适合在 CNC 铣床和加工中心上加工零件。\r\n"+
         "选项方式：\r\n"+
         "1. 标有颜色，\r\n"+
         "2.面积最大，\r\n"+
         "3.指定的涂层材料，\r\n"+
         "4. 初始向上。\r\n"+
         "可以在通用选项中禁用 1 和 4。",
      "Colocar las piezas con el lado principal (mejor, fachada) hacia abajo en Z.\r\n" +  // ES
        "Óptimo para mecanizar piezas en fresadoras CNC y centros de mecanizado.\r\n" +
        "La superficie de fachada se selecciona: \r\n" +
        "1. Marcada con color,\r\n" +
        "2. Máxima en área,\r\n" +
        "3. Material de recubrimiento asignado,\r\n" +
        "4. Inicialmente hacia arriba.\r\n" +
        "1 y 4 se pueden desactivar en las Opciones Comunes.",
      "Disposer les pièces avec le côté principal (meilleur, façade) vers le bas sur Z.\r\n" +  // FR
        "Optimal pour l'usinage de pièces sur des fraiseuses CNC et des centres d'usinage.\r\n" +
        "La surface de façade est sélectionnée : \r\n" +
        "1. Marquée par couleur,\r\n" +
        "2. Maximale en surface,\r\n" +
        "3. Matériau de revêtement attribué,\r\n" +
        "4. Initialement vers le haut.\r\n" +
        "1 et 4 peuvent être désactivés dans les Options Communes.",
      "Parçaları ana (en iyi, cephe) tarafı aşağıda olacak şekilde Z üzerine yerleştirin.\r\n" +  // TR
        "CNC freze makinelerinde ve işleme merkezlerinde parçaları işlemek için idealdir.\r\n" +
        "Cephe yüzeyi seçilir: \r\n" +
        "1. Renkle işaretli,\r\n" +
        "2. Alandan maksimum,\r\n" +
        "3. Atanmış kaplama malzemesi,\r\n" +
        "4. Başlangıçta yukarı dönük.\r\n" +
        "1 ve 4, Ortak Seçeneklerde devre dışı bırakılabilir."};

    public static readonly string[] ByTechnology = {
      "by Technology",
      "Технологично",
      "Tecnologicamente",
      "Technologisch",
      "按加工面",
      "Por tecnología",                                          // ES
      "Par technologie",                                         // FR
      "Teknolojiye göre"};                                       // TR

    public static readonly string[] ByTechnologyTip = {
      "Lay front up simple parts that are suitable for sawing.\r\n"+
        "And all other details - the front down.\r\n"+
        "A part with six or less flat faces without holes is considered simple.",
      "Выложить фасадом вверх простые детали, пригодные для распилки\r\n"+
        "на форматно-раскроечном станке.\r\n"+
        "А все остальные детали - фасадом вниз.\r\n"+
        "Простой считается деталь с шестью и менее плоскими гранями без отверстий.",
      "Appoggia in avanti le parti semplici adatte al taglio.\r\n"+
         "E tutti gli altri dettagli: la parte anteriore in basso.\r\n"+
         "Una parte con sei facce o meno piatte senza fori è considerata semplice.",
      "Einfache Teile, die zum Sägen geeignet sind, vorne auflegen.\r\n"+
         "Und alle anderen Details - die Vorderseite nach unten.\r\n"+
         "Ein Teil mit sechs oder weniger flachen Flächen ohne Löcher wird als einfach angesehen.",
      "将加工工艺复杂的一面朝上放置。",
      "Colocar hacia arriba las piezas simples adecuadas para aserrado.\r\n" +  // ES
        "Y todos los demás detalles - el frente hacia abajo.\r\n" +
        "Se considera simple una pieza con seis o menos caras planas sin agujeros.",
      "Disposer vers le haut les pièces simples adaptées au sciage.\r\n" +  // FR
        "Et tous les autres détails - l'avant vers le bas.\r\n" +
        "Une pièce avec six faces planes ou moins sans trous est considérée comme simple.",
      "Kesmeye uygun basit parçaları ön yüzü yukarıda olacak şekilde yerleştirin.\r\n" +  // TR
        "Ve diğer tüm detaylar - ön yüzü aşağıda.\r\n" +
        "Delikleri olmayan altı veya daha az düz yüze sahip bir parça basit kabul edilir."};

    public static readonly string[] BothSide = {
      "Both side",
      "Обе стороны",
      "Entrambe le parti",
      "Beide Seiten",
      "双面",
      "Ambos lados",                                             // ES
      "Les deux côtés",                                          // FR
      "Her iki taraf"};                                          // TR

    public static readonly string[] BothSideTip = {
      "Lay on two sides if there is processing from below.",
      "Выкладывать деталь двумя сторонами, если есть обработка снизу",
      "Appoggiare su due lati se c'è lavorazione dal basso.",
      "Bei Bearbeitung von unten beidseitig auflegen.",
      "根据选项不同，合并或单独生成正反面。",
      "Colocar en ambos lados si hay procesamiento desde abajo.",  // ES
      "Disposer des deux côtés s'il y a un traitement par le bas.",  // FR
      "Alttan işleme varsa her iki tarafa yerleştirin."};       // TR

    public static readonly string[] AlongY = {
      "Along Y",
      "Вдоль Y",
      "Lungo Y",
      "Entlang Y",
      "沿Y轴",
      "A lo largo de Y",                                         // ES
      "Le long de Y",                                            // FR
      "Y boyunca"};                                              // TR

    public static readonly string[] AlongYTip = {
      "Rotate the parts with the long side along the Y axis. The texture will also be rotated vertically.",
      "Развернуть детали длинной стороной вдоль оси Y. Текстура тоже развернется по вертикали.",
      "Ruota le parti con il lato lungo lungo l'asse Y. La texture verrà anche ruotata verticalmente.",
      "Drehen Sie die Teile mit der langen Seite entlang der Y-Achse. Die Textur wird auch vertikal gedreht.",
      "纹理或长边,沿 Y 轴旋转，",
      "Rotar las piezas con el lado largo a lo largo del eje Y. La textura también se rotará verticalmente.",  // ES
      "Faire pivoter les pièces avec le côté long le long de l'axe Y. La texture sera également pivotée verticalement.",  // FR
      "Parçaları uzun tarafı Y ekseni boyunca olacak şekilde döndürün. Doku da dikey olarak döndürülecektir."};  // TR

    public static readonly string[] UpsideDown = {
      "Flip",
      "Перевернуть",
      "Flip",
      "Umdrehen",
      "翻动",
      "Voltear",                                                 // ES
      "Retourner",                                               // FR
      "Çevir"};                                                  // TR

    public static readonly string[] UpsideDownTip = {
      "Rotate the part around Z 180 degrees so that the best angle and the best edge are at the top of the drawing.",
      "Развернуть деталь вокруг Z на 180 градусов, чтоб лучший угол и лучшее ребро были сверху чертежа",
      "Ruota la parte attorno a Z di 180 gradi in modo che l'angolo e il bordo migliori si trovino nella parte superiore del disegno.",
      "Drehen Sie das Teil um 180 Grad um Z, sodass der beste Winkel und die beste Kante oben in der Zeichnung liegen.",
      "Ruota la parte attorno a Z di 180 gradi in modo che l'angolo e il bordo migliori si trovino nella parte superiore del disegno.",
      "Rotar la pieza alrededor de Z 180 grados para que el mejor ángulo y el mejor borde estén en la parte superior del dibujo.",  // ES
      "Faire pivoter la pièce autour de Z de 180 degrés pour que le meilleur angle et le meilleur bord soient en haut du dessin.",  // FR
      "Parçayı Z etrafında 180 derece döndürün, böylece en iyi açı ve en iyi kenar çizimin üst kısmında olsun."};  // TR

    public static readonly string[] MarkTexture = {
      "Mark texture",
      "Пометка текстуры",
      "Segna la trama",
      "Textur markieren",
      "标记纹理",
      "Marcar textura",                                          // ES
      "Marquer la texture",                                      // FR
      "Dokuyu işaretle"};                                        // TR

    public static readonly string[] MarkTextureTip = {
      "Write <<TEXTURE>> in a middle of a detail if solid Texture marked (along or across).",
      "Писать <<ТЕКСТУРА>> в центре детали, если солид помечен, как имеющий текстуру вдоль или поперек.",
      "Scrivi <<TEXTURE>> nel mezzo di un dettaglio se è contrassegnata una Texture solida (lungo o trasversalmente).",
      "Schreiben Sie <<TEXTURE>> in die Mitte eines Details, wenn eine solide Textur markiert ist (längs oder quer).",
      "如果三维实体属性值设置为 '纹理 = 长向(along) 或者 宽向(across)'," +
        "则在平铺后的图形中间写下 <<纹理方向>> (<<TEXTURE>>)",
      "Escribir <<TEXTURE>> en el medio de un detalle si la textura sólida está marcada (a lo largo o a través).",  // ES
      "Écrire <<TEXTURE>> au milieu d'un détail si la texture solide est marquée (dans le sens de la longueur ou de la largeur).",  // FR
      "Katı Doku işaretlenmişse (boydan veya enine) bir detayın ortasına <<TEXTURE>> yazın."};  // TR

    public static readonly string[] MakeFlatShot = {
      "Make FlatShot",
      "Плоские контуры",
      "Crea FlatShot",
      "Machen Sie FlatShot",
      "二维图形",
      "Hacer FlatShot",                                          // ES
      "Faire FlatShot",                                          // FR
      "FlatShot yap"};                                           // TR

    public static readonly string[] MakeFlatShotTip = {
      "Calling FlatShot command after LAY.\r\n"+
        "If layer management is enabled (in the Common Options),\r\n" +
        "then a layer for visible lines and a layer for hidden lines will be created.\r\n" +
        "If the option is disabled, the program will use the color and layer of the solid \r\n" +
        "and set the hidden line color to green.",
      "Вызов команды Плоский слепок (FlatShot) после Выкладки.\r\n"+
        "Если управление слоями включено (в Общих Настройках),\r\n" +
        "то будут созданы слой для видимых линий и слой для скрытых линий.\r\n" +
        "Если опция отключена, программа будет использовать цвет \r\n" +
        "и слой твердого тела и зеленый цвет для скрытых линий.",
      "Chiamare il comando FlatShot dopo Disposizione (LAY).\r\n"+
         "Se è abilitata la gestione dei livelli (nelle Opzioni comuni),\r\n" +
        "verrà creato un livello per le linee visibili e un livello per le linee nascoste.\r\n" +
         "Se l'opzione è disabilitata, il programma utilizzerà il colore \r\n" +
        "e il livello del solido e imposterà il colore della linea nascosta su verde.",
      "Aufruf des FlatShot-Befehls nach Layout (LAY).\r\n"+
        "Wenn die Ebenenverwaltung aktiviert ist (in den allgemeinen Optionen),\r\n" +
        "wird eine Ebene für sichtbare Linien und eine Ebene für verdeckte Linien erstellt.\r\n" +
        "Wenn die Option deaktiviert ist, verwendet das Programm die Farbe \r\n" +
        "und Ebene des Volltons und setzt die Farbe der verdeckten Linie auf Grün.",
      "在 LAY 命令之后调用 FlatShot（平面摄影) 命令。\r\n" +
        "生成的二维图形将放置到相应的图层, 可见图形放在'MD_Visible'图层，\r\n" +
        "隐藏图形放在'MD_Hidden'图层。",
      "Llamar al comando FlatShot después de LAY.\r\n" +  // ES
        "Si la gestión de capas está habilitada (en las Opciones Comunes),\r\n" +
        "se creará una capa para líneas visibles y una capa para líneas ocultas.\r\n" +
        "Si la opción está deshabilitada, el programa usará el color y la capa del sólido \r\n" +
        "y establecerá el color de línea oculta en verde.",
      "Appeler la commande FlatShot après LAY.\r\n" +  // FR
        "Si la gestion des couches est activée (dans les Options Communes),\r\n" +
        "une couche pour les lignes visibles et une couche pour les lignes cachées seront créées.\r\n" +
        "Si l'option est désactivée, le programme utilisera la couleur et la couche du solide \r\n" +
        "et définira la couleur de ligne cachée sur vert.",
      "LAY'den sonra FlatShot komutunu çağırın.\r\n" +  // TR
        "Katman yönetimi etkinse (Ortak Seçeneklerde),\r\n" +
        "görünür çizgiler için bir katman ve gizli çizgiler için bir katman oluşturulacaktır.\r\n" +
        "Seçenek devre dışıysa, program katının rengini ve katmanını kullanacak \r\n" +
        "ve gizli çizgi rengini yeşil olarak ayarlayacaktır."};

    public static readonly string[] GroupFrame = {
      "Frame around the group",
      "Рамка вокруг группы",
      "Inquadrare il gruppo",
      "Rahmen um die Gruppe herum",
      "围绕小组框架",
      "Marco alrededor del grupo",                               // ES
      "Cadre autour du groupe",                                  // FR
      "Grup etrafında çerçeve"};                                 // TR

    public static readonly string[] GroupFrameTip = {
      "Draw a rectangle around each group of laid out parts. \r\n" +
        "Just to visually separate the calculation from the main model. \r\n" +
        "The polyline will be created in the non-printable Info layer.",
      "Начертить прямоугольник вокруг каждой группы выложенных деталей. \r\n" +
        "Просто для наглядного отделения выкладки от основной модели. \r\n" +
        "Полилиния будет создана в непечатном слое Инфо",
      "Disegna un rettangolo attorno a ciascun gruppo di parti disposte. \r\n" +
        "Giusto per separare visivamente il calcolo dal modello principale. \r\n" +
        "La polilinea verrà creata nel livello Info non stampabile.",
      "Zeichnen Sie ein Rechteck um jede Gruppe von ausgelegten Teilen. \r\n" +
        "Nur um die Berechnung visuell vom Hauptmodell zu trennen. \r\n" +
        "Die Polylinie wird in der nicht druckbaren Infoebene erstellt.",
      "在每组布局的部分周围画一个矩形。 只是为了在视觉上将计算与主模型分开。 \r\n" +
        "折线将在不可打印的信息层中创建。",
      "Dibujar un rectángulo alrededor de cada grupo de piezas colocadas. \r\n" +  // ES
        "Solo para separar visualmente el cálculo del modelo principal. \r\n" +
        "La polilínea se creará en la capa Info no imprimible.",
      "Dessiner un rectangle autour de chaque groupe de pièces disposées. \r\n" +  // FR
        "Juste pour séparer visuellement le calcul du modèle principal. \r\n" +
        "La polyligne sera créée dans la couche Info non imprimable.",
      "Yerleştirilmiş her parça grubu etrafına bir dikdörtgen çizin. \r\n" +  // TR
        "Sadece hesaplamayı ana modelden görsel olarak ayırmak için. \r\n" +
        "Çoklu çizgi yazdırılamaz Bilgi katmanında oluşturulacaktır."};

    public static readonly string[] PartFrame = {
      "Frame around the part",
      "Рамка вокруг детали",
      "Cornice intorno alla parte",
      "Rahmen um das Teil",
      "零件周围的框架",
      "Marco alrededor de la pieza",                             // ES
      "Cadre autour de la pièce",                                // FR
      "Parça etrafında çerçeve"};                                // TR

    public static readonly string[] PartFrameTip = {
      "Draw a rectangle around the solid of the laid out part. \r\n" +
        "The frame can be useful when exporting solids to AlphaCAM.\r\n" +
        "The polyline will be created in the non-printable Info layer.",
      "Начертить прямоугольник вокруг солида выложенной детали. \r\n" +
        "Рамка может пригодится при экспорте солидов в AlphaCAM.\r\n" +
        "Полилиния будет создана в непечатном слое Инфо",
      "Disegna un rettangolo attorno al solido della parte stesa. \r\n" +
        "La cornice può essere utile quando si esportano solidi in AlphaCAM.\r\n" +
        "La polilinea verrà creata nel livello Info non stampabile.",
      "Zeichnen Sie ein Rechteck um den Körper des ausgelegten Teils. \r\n" +
        "Der Rahmen kann nützlich sein, wenn Sie Volumenkörper nach AlphaCAM exportieren.\r\n" +
        "Die Polylinie wird in der nicht druckbaren Infoebene erstellt.",
      "围绕布局部分的实体绘制一个矩形。 \r\n" +
        "将实体导出到 AlphaCAM 时，框架非常有用。\r\n" +
        "折线将在不可打印的信息层中创建。",
      "Dibujar un rectángulo alrededor del sólido de la pieza colocada. \r\n" +  // ES
        "El marco puede ser útil al exportar sólidos a AlphaCAM.\r\n" +
        "La polilínea se creará en la capa Info no imprimible.",
      "Dessiner un rectangle autour du solide de la pièce disposée. \r\n" +  // FR
        "Le cadre peut être utile lors de l'exportation de solides vers AlphaCAM.\r\n" +
        "La polyligne sera créée dans la couche Info non imprimable.",
      "Yerleştirilmiş parçanın katısı etrafına bir dikdörtgen çizin. \r\n" +  // TR
        "Çerçeve, katıları AlphaCAM'e dışa aktarırken yararlı olabilir.\r\n" +
        "Çoklu çizgi yazdırılamaz Bilgi katmanında oluşturulacaktır."};

    public static readonly string[] Block4Part = {
      "Make a block for every detail",
      "Сделать блок для каждой детали",
      "Crea un blocco per ogni dettaglio",
      "Machen Sie einen Block für jedes Detail",
      "为每个细节做一个块",
      "Hacer un bloque para cada detalle",                       // ES
      "Créer un bloc pour chaque détail",                        // FR
      "Her detay için bir blok yap"};                            // TR

    public static readonly string[] Block4PartTip = {
      "Merge the solid or all the contours of the part together with the title into a block. Make sure the parts have names - they will be used as the block name.",
      "Объединить солид или все контуры детали вместе с заголовком в блок. Убедитесь, что у деталей есть имена - они будут использованы как имя блока.",
      "Unisci il solido o tutti i contorni della parte insieme al titolo in un blocco. Assicurati che le parti abbiano nomi: verranno utilizzate come nome del blocco.",
      "Führen Sie den Körper oder alle Umrisse des Teils zusammen mit dem Titel zu einem Block zusammen. Stellen Sie sicher, dass die Teile Namen haben - sie werden als Blockname verwendet.",
      "将零件的实体或所有轮廓与标题合并成一个块。 确保零件有名称 - 它们将用作块名称。",
      "Fusionar el sólido o todos los contornos de la pieza junto con el título en un bloque. Asegúrese de que las piezas tengan nombres: se usarán como nombre del bloque.",  // ES
      "Fusionner le solide ou tous les contours de la pièce avec le titre dans un bloc. Assurez-vous que les pièces ont des noms - ils seront utilisés comme nom de bloc.",  // FR
      "Katıyı veya parçanın tüm konturlarını başlıkla birlikte bir bloğa birleştirin. Parçaların adları olduğundan emin olun - blok adı olarak kullanılacaklardır."};  // TR

    public static readonly string[] Block4Lay = {
      "Make a common block for the entire layout",
      "Сделать общий блок для всей выкладки",
      "Crea un blocco comune per l'intero layout",
      "Erstellen Sie einen gemeinsamen Block für das gesamte Layout",
      "为整个布局制作一个公共块",
      "Hacer un bloque común para todo el diseño",                // ES
      "Créer un bloc commun pour toute la disposition",          // FR
      "Tüm yerleşim için ortak bir blok yap"};                   // TR

    public static readonly string[] Block4LayTip = {
      "Combine all laid out details from all groups (outlines, titles and frames) into a single large block. The block will be given the same name as the LAY-style.",
      "Объединить все выложенные детали из всех групп (контуры, заголовки и рамки) в единый большой блок. Блоку будет дано имя как у стиля выкладки.",
      "Combina tutti i dettagli disposti da tutti i gruppi (contorni, titoli e cornici) in un unico grande blocco. Al blocco verrà assegnato lo stesso nome dello stile di LAY.",
      "Kombinieren Sie alle angeordneten Details aus allen Gruppen (Umrisse, Titel und Rahmen) in einem einzigen großen Block. Der Block erhält denselben Namen wie der LAYstil.",
      "将所有组（大纲、标题和框架）中的所有布局细节组合到一个大块中。 该块将被赋予与布局样式相同的名称。",
      "Combinar todos los detalles colocados de todos los grupos (contornos, títulos y marcos) en un solo bloque grande. El bloque tendrá el mismo nombre que el estilo LAY.",  // ES
      "Combiner tous les détails disposés de tous les groupes (contours, titres et cadres) en un seul grand bloc. Le bloc recevra le même nom que le style LAY.",  // FR
      "Tüm gruplardan (konturlar, başlıklar ve çerçeveler) yerleştirilmiş tüm detayları tek bir büyük bloğa birleştirin. Bloğa LAY stiliyle aynı ad verilecektir."};  // TR

  }
}
