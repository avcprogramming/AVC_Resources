// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  DadoJointL
  {
    public static string[][]
    DadoJointStyleNames =
    {
/* 0 */ CommandL.DDJ,  
/* 1 */ CommandL.DDJ,
/* 2 */ new []{
         "Fachwerk",
         "Фахверк",
         "Graticcio",
         "Fachwerk",
         "半木造房屋",
         "Entramado",                                            // ES
         "Colombage",                                            // FR
         "Yarı ahşap"                                            // TR
      }
    };

    public static readonly string[] Select = {
      "  Select assembly consisting of Solid",
      "  Выберите сборку из деталей типа 3DSolid",
      "  Scegliere un assemblaggio da 3DSolid parts",
      "  Wählen Sie eine Baugruppe aus 3DSolid-Teilen",
      "  选择由零件组成的装配体",
      "  Seleccione el ensamblaje que consta de sólidos",        // ES
      "  Sélectionnez l'assemblage composé de solides",          // FR
      "  Katılardan oluşan montajı seçin"};                      // TR

    public static readonly string[] Nothing = {
      "  Nothing to cut",
      "  Нечего вырезать",
      "  Niente da tagliare",
      "  Nichts zu schneiden",
      "  没什么可剪的",
      "  Nada que cortar",                                       // ES
      "  Rien à couper",                                         // FR
      "  Kesilecek bir şey yok"};                                // TR

    public static readonly string[] DepthQuery = {
      "\n  Dado depth",
      "\n  Глубина паза",
      "\n  Profondità della scanalatura",
      "\n  Rillentiefe",
      "\n  给定深度",
      "\n  Profundidad de la ranura",                            // ES
      "\n  Profondeur de la rainure",                            // FR
      "\n  Oluk derinliği"};                                     // TR

    public static readonly string[] Finding = {
      "Finding contacts",
      "Поиск контактов",
      "Cerca contatti",
      "Suche nach Kontakten",
      "查找联系人",
      "Encontrando contactos",                                   // ES
      "Recherche de contacts",                                   // FR
      "Kontak bulma"};                                           // TR

    public static readonly string[] CombinationsErr = {
      "  Too many combinations",
      "  Слишком много комбинаций",
      "  Troppe combinazioni",
      "  Zu viele Kombinationen",
      "  组合太多",
      "  Demasiadas combinaciones",                              // ES
      "  Trop de combinaisons",                                  // FR
      "  Çok fazla kombinasyon"};                                // TR

    public static readonly string[] StopErr = {
      "  Unable to create Stop {0}",
      "  Не получается создать Упор {0}",
      "  Impossibile creare la Supporto {0}",
      "  Knaggen {0} kann nicht erstellt werden",
      "  无法创建宽度为 {0} 的推力垫",
      "  No se puede crear el tope {0}",                         // ES
      "  Impossible de créer la butée {0}",                      // FR
      "  Dayanak {0} oluşturulamıyor"};                          // TR

    public static readonly string[] Least2Err = {
      "  Requires at least 2 solids",
      "  Требуется хотя бы 2 солида",
      "  Richiede almeno 2 solidi",
      "  Benötigt mindestens 2 Volumenkörper",
      "  至少需要 2 个固体",
      "  Requiere al menos 2 sólidos",                           // ES
      "  Nécessite au moins 2 solides",                          // FR
      "  En az 2 katıya ihtiyaç var"};                           // TR

    public static readonly string[] Skipping = {
      "  Discovered contact the same planes. Skipping.",
      "  Обнаружен контакт одинаковыми плоскостями. Пропускаем.",
      "  Contatto rilevato dagli stessi aerei. La signorina.",
      "  Kontakt von denselben Flugzeugen erkannt. Überspringen.",
      "  发现接触同一架飞机。 跳过。",
      "  Se descubrió el contacto con los mismos planos. Saltando.",  // ES
      "  Contact découvert avec les mêmes plans. Ignorer.",      // FR
      "  Aynı düzlemlerle temas tespit edildi. Atlanıyor."};     // TR

    public static readonly string[] Contacts = {
      "  Found contacts: {0}",
      "  Найдено контактов: {0}",
      "  Contatti trovati: {0}",
      "  Gefundene Kontakte: {0}",
      "  找到的联系人：{0}",
      "  Contactos encontrados: {0}",                            // ES
      "  Contacts trouvés : {0}",                                // FR
      "  Bulunan kontaklar: {0}"};                               // TR

    public static readonly string[] Making = {
      "Making joints",
      "Изготовление соединений",
      "Produrre composti",
      "Verbindungen herstellen",
      "制作关节",
      "Haciendo juntas",                                         // ES
      "Fabrication de joints",                                   // FR
      "Bağlantı yapımı"};                                        // TR

    public static readonly string[] ContinueQuery = {
      "Error: {0}\nContinue?",
      "Ошибка: {0}\nПродолжать?",
      "Errore: {0}\nContinua?",
      "Fehler: {0}\nWeiter?",
      "错误：{0}。\n继续？",
      "Error: {0}\n¿Continuar?",                                 // ES
      "Erreur : {0}\nContinuer ?",                               // FR
      "Hata: {0}\nDevam et?"};                                   // TR

    public static readonly string[] JointErr = {
      "Failed to connect between parts {0} and {1}",
      "Не получилось сделать соединение между деталями {0} и {1}",
      "Impossibile connettersi tra le parti {0} e {1}",
      "Verbindung zwischen den Teilen {0} und {1} fehlgeschlagen",
      "未能在 {0} 和 {1} 部分之间连接",
      "No se pudo conectar entre las piezas {0} y {1}",          // ES
      "Échec de la connexion entre les pièces {0} et {1}",      // FR
      "{0} ve {1} parçaları arasında bağlantı kurulamadı"};     // TR

    public static readonly string[] ThicknessErr = {
      "Unable to measure the thickness of part {0}",
      "Не получилось померить толщину детали {0}",
      "Impossibile misurare lo spessore della parte {0}",
      "Die Dicke des Teils {0} kann nicht gemessen werden",
      "无法测量部件 {0} 的厚度",
      "No se puede medir el espesor de la pieza {0}",            // ES
      "Impossible de mesurer l'épaisseur de la pièce {0}",      // FR
      "Parça {0}'ın kalınlığı ölçülemiyor"};                     // TR

    public static readonly string[] TooBigGapErr = {
      "The dado depth ({0}) is less than the Gap.",
      "Глубина паза ({0}) меньше зазора.",
      "La profondità della scanalatura ({0}) è inferiore allo spazio.",
      "Die Nuttiefe ({0}) ist kleiner als der Spalt.",
      "凹槽深度（{0}）小于间隙。",
      "La profundidad de la ranura ({0}) es menor que el espacio.",  // ES
      "La profondeur de la rainure ({0}) est inférieure à l'écart.",  // FR
      "Oluk derinliği ({0}) boşluktan küçük."};                 // TR

    public static readonly string[] TooBigBacklashErr = {
      "The dado depth ({0}) is less than the Backlash.",
      "Глубина паза ({0}) меньше, чем люфт.",
      "La profondità della scanalatura ({0}) è inferiore al gioco.",
      "Die Nuttiefe ({0}) ist kleiner als das Spiel.",
      "凹槽深度（{0}）小于间隙。",
      "La profundidad de la ranura ({0}) es menor que la holgura.",  // ES
      "La profondeur de la rainure ({0}) est inférieure au jeu.",  // FR
      "Oluk derinliği ({0}) boşluktan küçük."};                 // TR

    public static readonly string[] SplitWarning = {
      "The dado cut the solid {0} into pieces. The remaining connections will be made only for one of the pieces.",
      "Паз разрезал солид {0} на части. Остальные соединения будут выполнены только для одной из частей.",
      "La scanalatura taglia il solido {0} in pezzi. I collegamenti rimanenti verranno effettuati solo per una delle parti.",
      "Die Nut schnitt den festen {0} in Stücke. Die restlichen Verbindungen werden nur für eines der Teile hergestellt.",
      "凹槽将实体{0}切成碎片。其余连接仅针对其中一个部件进行。",
      "La ranura cortó el sólido {0} en piezas. Las conexiones restantes se realizarán solo para una de las piezas.",  // ES
      "La rainure a coupé le solide {0} en morceaux. Les connexions restantes ne seront faites que pour l'un des morceaux.",  // FR
      "Oluk, katı {0}'ı parçalara ayırdı. Kalan bağlantılar yalnızca parçalardan biri için yapılacaktır."};  // TR

    public static readonly string[] MinAreaKW = {
      "MINArea",
      "МИНПлощадь",
      "AREAMinima",
      "MINFläche",
      "最小接触面积(M)",
      "ÁREAMínima",                                              // ES
      "SURfaceMinimale",                                         // FR
      "MİNAlan"};                                                // TR

    public static readonly string[] StopKW = {
      "STOP",
      "УПОР",
      "SUPPORTO",
      "KNAGGEN",
      "推力垫(S)",
      "TOPE",                                                    // ES
      "BUTée",                                                   // FR
      "DAYANAK"};                                                // TR

    public static readonly string[] StopQuery = {
      "  Enter Stop value or zero",
      "  Введите ширину Упора или ноль",
      "  Inserisci la larghezza del Supporto o zero",
      "  Geben Sie einen Knaggen oder Null ein",
      "  输入停止垫的宽度或零",
      "  Ingrese el valor del tope o cero",                      // ES
      "  Entrez la valeur de la butée ou zéro",                  // FR
      "  Dayanak değerini veya sıfır girin"};                    // TR

    public static readonly string[] MinAreaQuery = {
      "  Ignore the contact area is less than:",
      "  Игнорировать контакты площадью меньше чем:",
      "  Ignora i contatti più piccoli di:",
      "  Kontakte ignorieren, die kleiner sind als:",
      "  忽略接触面积小于：",
      "  Ignorar el área de contacto menor que:",                // ES
      "  Ignorer la zone de contact inférieure à :",             // FR
      "  Temas alanı şundan küçükse yoksay:"};                   // TR

    public static readonly string[] SmallContactErr = {
      "  Found the contact is too small. Skipping." ,
      "  Найденный контакт слишком мал. Пропускаем.",
      "  Il contatto trovato è troppo piccolo. La signorina.",
      "  Der gefundene Kontakt ist zu klein. Überspringen.",
      "  发现触点太小。 跳过。",
      "  El contacto encontrado es demasiado pequeño. Saltando.",  // ES
      "  Le contact trouvé est trop petit. Ignorer.",            // FR
      "  Bulunan temas çok küçük. Atlanıyor."};                  // TR

    public static readonly string[] ExpandDadoErr = {
      "  It was not possible to expand the dado.",
      "  Не получилось удлинить паз.",
      "  Non è stato possibile estendere la scanalatura.",
      "  Eine Erweiterung der Nut war nicht möglich.",
      "  无法延长凹槽。",
      "  No fue posible expandir la ranura.",                    // ES
      "  Il n'a pas été possible d'étendre la rainure.",         // FR
      "  Oluk genişletilemedi."};                                // TR

    public static readonly string[] Result = {
      "  Made joints: {0}" ,
      "  Сделано соединений: {0}",
      "  Collegamenti effettuati: {0}",
      "  Verbindungen hergestellt: {0}",
      "  制作接头：{0}",
      "  Juntas realizadas: {0}",                                // ES
      "  Joints réalisés : {0}",                                 // FR
      "  Yapılan bağlantılar: {0}"};                             // TR

    public static readonly string[] SettingsInfo = {
      "  Current settings: Depth = {0}, MinArea = {1}, Gap = {2}, Backlash = {3}, Stop = {4}, Along = {5}",
      "  Текущие настройки: Глубина = {0}, МинПлощадь = {1}, Зазор = {2}, Люфт = {3}, Упор = {4}, Вдоль = {5}",
      "  Impostazioni correnti: Profondità = {0}, AreaMinima = {1}, Liquidazione = {2}, Gioco = {3}, Supporto = {4}, Lungo = {5}",
      "  Aktuelle Einstellungen: Tiefe = {0}, Mindestfläche = {1}, Spiel = {2}, Gegenreaktion = {3}, Knaggen = {4}, Entlang = {5}",
      "  当前设置：深度 = {0}，最小接触面积 = {1}，各个方向的间隙 = {2}, 深度反弹 = {3}, 推力垫 = {4}, 沿着 = {5}",
      "  Configuración actual: Profundidad = {0}, ÁreaMín = {1}, Espacio = {2}, Holgura = {3}, Tope = {4}, A lo largo = {5}",  // ES
      "  Paramètres actuels : Profondeur = {0}, SurfaceMin = {1}, Écart = {2}, Jeu = {3}, Butée = {4}, Le long = {5}",  // FR
      "  Mevcut ayarlar: Derinlik = {0}, MinAlan = {1}, Boşluk = {2}, Gevşeklik = {3}, Dayanak = {4}, Boyunca = {5}"};  // TR

    //======================= Dialog Box =============================================================

    public static readonly string[] StyleNameTip = {
      "The name for this DadoJoint-style (set of settings). \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Название для этого стиля команды Паз. \r\n" +
        "Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile DadoJoint (set di impostazioni). \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen DadoJoint-Stil (Satz von Einstellungen). \r\n" +
        "Wird im Programm nicht verwendet. Nur zur Bequemlichkeit der Wahl.",
      "此 凹槽连接 样式（设置集）的名称。\r\n" +
         "在程序中没有使用。只是为了方便阅读。",
      "El nombre de este estilo DadoJoint (conjunto de configuraciones). \r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia de elección.",
      "Le nom de ce style DadoJoint (ensemble de paramètres). \r\n" +  // FR
        "Non utilisé dans le programme. Seulement pour la commodité du choix.",
      "Bu DadoJoint stili için ad (ayar kümesi). \r\n" +  // TR
        "Programda kullanılmaz. Sadece seçim kolaylığı için."};

    public static string[] Stop = {
      "Stop pad",
      "Упорная площадка",
      "Pattino di spinta (Supporto)",
      "Druckstück (Knaggen)",
      "推力垫",
      "Almohadilla de tope",                                     // ES
      "Patin de butée",                                          // FR
      "Dayanak yastığı"};                                        // TR

    public static string[] AlongEdges = {
      "Extrude along the beam",
      "Вытягивать вдоль балки",
      "Tirare lungo la trave",
      "Den Balken entlang ziehen",
      "沿横梁拉",
      "Extruir a lo largo de la viga",                           // ES
      "Extruder le long de la poutre",                           // FR
      "Kiriş boyunca çıkart"};                                   // TR

    public static string[] DepthRequest = {
      "Request depth every time",
      "Запрашивать глубину каждый раз",
      "Richiedi profondità ogni volta",
      "Fordern Sie jedes Mal die Tiefe an",
      "每次都请求深度",
      "Solicitar profundidad cada vez",                          // ES
      "Demander la profondeur à chaque fois",                    // FR
      "Her seferinde derinlik iste"};                            // TR

    public static string[] StopTip = {
      "If you set a size greater than zero, the program will make an emphasis along the perimeter of the tenon. \r\n" +
        "That is, the tenon and dado will be smaller than the region of contact of the parts.",
      "Если задать размер больше ноля, то программа сделает упор по периметру шипа. \r\n" +
        "То есть шип и паз будут меньше региона контакта деталей.",
      "Se si imposta una dimensione maggiore di zero, il programma porrà l'enfasi lungo il perimetro del tenone. \r\n" +
        "Ciò significa che il tenone e la scanalatura saranno più piccoli della zona di contatto tra le parti.",
      "Wenn Sie eine Größe größer als Null einstellen, legt das Programm den Schwerpunkt entlang des Zapfenumfangs. \r\n" +
        "Das heißt, Zapfen und Nut sind kleiner als der Kontaktbereich zwischen den Teilen.",
      "如果设置的尺寸大于零，程序将重点放在榫头的周边。也就是说，榫头和槽口将小于零件之间的接触区域。",
      "Si establece un tamaño mayor que cero, el programa hará énfasis a lo largo del perímetro de la espiga. \r\n" +  // ES
        "Es decir, la espiga y la ranura serán más pequeñas que la región de contacto de las piezas.",
      "Si vous définissez une taille supérieure à zéro, le programme mettra l'accent sur le périmètre du tenon. \r\n" +  // FR
        "C'est-à-dire que le tenon et la rainure seront plus petits que la région de contact des pièces.",
      "Sıfırdan büyük bir boyut ayarlarsanız, program zıvana çevresinde vurgu yapacaktır. \r\n" +  // TR
        "Yani zıvana ve oluk, parçaların temas bölgesinden daha küçük olacaktır."};

    public static string[] AlongEdgesTip = {
      "Extrude the tenon along the edges or axis of the beam being joined. \r\n" +
        "The option works only on rectangular or round beams that are not connected at a right angle to the second part. \r\n" +
        "If the option is disabled, the tenon is pulled perpendicular to the plane of contact of the parts.",
      "Вытягивать шип вдоль ребер или оси соединяемой балки. \r\n" +
        "Опция сработает только на прямоугольных или круглых балках, соединяемых не под прямым углом ко второй детали. \r\n" +
        "Если опция отключена, то вытягивание шипа производится перпендикулярно плоскости контакта деталей.",
      "Tirare il tenone lungo i bordi o l'asse della trave da collegare. \r\n" +
        "L'opzione funziona solo su travi rettangolari \r\n" +
        "o rotonde che non siano collegate ad angolo retto alla seconda parte. \r\n" +
        "Se l'opzione è disattivata, il tenone viene estratto perpendicolarmente al piano di contatto delle parti.",
      "Ziehen Sie den Zapfen entlang der Kanten oder Achse des zu verbindenden Balkens. \r\n" +
        "Die Option funktioniert nur bei rechteckigen oder runden Balken, \r\n" +
        "die nicht im rechten Winkel mit dem zweiten Teil verbunden sind. \r\n" +
        "Ist die Option deaktiviert, wird der Zapfen senkrecht zur Kontaktebene der Teile herausgezogen.",
      "沿着被连接梁的边缘或轴线拉动榫头。\r\n" +
        "该选项仅适用于未以直角连接到第二部件的矩形或圆形梁。 \r\n" +
        "如果禁用该选项，榫头将垂直于零件接触平面被拉出。",
      "Extruir la espiga a lo largo de los bordes o el eje de la viga que se está uniendo. \r\n" +  // ES
        "La opción funciona solo en vigas rectangulares o redondas que no están conectadas en ángulo recto a la segunda pieza. \r\n" +
        "Si la opción está deshabilitada, la espiga se extrae perpendicular al plano de contacto de las piezas.",
      "Extruder le tenon le long des bords ou de l'axe de la poutre à assembler. \r\n" +  // FR
        "L'option ne fonctionne que sur les poutres rectangulaires ou rondes qui ne sont pas reliées à angle droit à la deuxième pièce. \r\n" +
        "Si l'option est désactivée, le tenon est extrait perpendiculairement au plan de contact des pièces.",
      "Zıvanayı birleştirilen kirişin kenarları veya ekseni boyunca çıkartın. \r\n" +  // TR
        "Seçenek yalnızca ikinci parçaya dik açıyla bağlanmayan dikdörtgen veya yuvarlak kirişlerde çalışır. \r\n" +
        "Seçenek devre dışı bırakılırsa, zıvana parçaların temas düzlemine dik olarak çekilir."};

    public static string[] DepthQueryTip = {
      "Prompt for depth and show command line options each time the command is called.",
      "При каждом вызове команды запрашивать глубину и показывать опции в командной строке.",
      "Richiedi profondità e mostra le opzioni della riga di comando ogni volta che viene chiamato il comando.",
      "Bei jedem Aufruf des Befehls wird nach der Tiefe gefragt und es werden Befehlszeilenoptionen angezeigt.",
      "每次调用命令时提示深度并显示命令行选项。",
      "Solicitar profundidad y mostrar opciones de línea de comandos cada vez que se llama al comando.",  // ES
      "Demander la profondeur et afficher les options de ligne de commande à chaque appel de la commande.",  // FR
      "Komut her çağrıldığında derinlik iste ve komut satırı seçeneklerini göster."};  // TR

    public static readonly string[] ExpandDado = {
      "Dado across the entire part",
      "Паз на вылет",
      "Scanalatura sui bordi della parte",
      "Nut bis zu den Kanten des Teils",
      "凹槽至零件边缘",
      "Ranura a través de toda la pieza",                        // ES
      "Rainure sur toute la pièce",                              // FR
      "Parçanın tamamına oluk"};                                 // TR

    public static readonly string[] ExpandDadoTip = {
      "Extend the dado along its long side to the edges of the part \r\n" +
        "so that it can be made with a circular saw. \r\n" +
        "This option only works with rectangular dadoes \r\n" +
        "and is automatically disabled if the result is not a dado but a through window.",
      "Удлинить паз по его длинной стороне до краев детали, так чтоб можно было изготовить его циркулярной пилой. \r\n" +
        "Работает только с прямоугольными пазами",
      "Estendere la scanalatura lungo il lato lungo fino ai bordi del pezzo, \r\n" +
        "in modo da poterla realizzare con una sega circolare. \r\n" +
        "Funziona solo con slot rettangolari.",
      "Verlängern Sie die Nut entlang der Längsseite bis an die Kanten des Teils, \r\n" +
        "sodass diese mit einer Kreissäge eingearbeitet werden kann. \r\n" +
        "Funktioniert nur mit rechteckigen Schlitzen.",
      "将凹槽沿其长边延伸至零件的边缘，以便可以用圆锯制作。\r\n" +
        "仅适用于矩形槽。",
      "Extender la ranura a lo largo de su lado largo hasta los bordes de la pieza \r\n" +  // ES
        "para que pueda hacerse con una sierra circular. \r\n" +
        "Esta opción solo funciona con ranuras rectangulares \r\n" +
        "y se deshabilita automáticamente si el resultado no es una ranura sino una ventana pasante.",
      "Étendre la rainure le long de son côté long jusqu'aux bords de la pièce \r\n" +  // FR
        "afin qu'elle puisse être réalisée avec une scie circulaire. \r\n" +
        "Cette option ne fonctionne qu'avec les rainures rectangulaires \r\n" +
        "et est automatiquement désactivée si le résultat n'est pas une rainure mais une fenêtre traversante.",
      "Oluğu uzun kenarı boyunca parçanın kenarlarına kadar genişletin \r\n" +  // TR
        "böylece dairesel testerle yapılabilir. \r\n" +
        "Bu seçenek yalnızca dikdörtgen oluklar için çalışır \r\n" +
        "ve sonuç bir oluk değil de geçişli bir pencere ise otomatik olarak devre dışı bırakılır."};

  }
}