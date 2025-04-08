// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  DadoJointL
  {
    public static string[,]
    DadoJointStyleNames =
    {
/* 0 */ {
        CommandL.DDJ[0],
        CommandL.DDJ[1],
        CommandL.DDJ[2],
        CommandL.DDJ[3],
        CommandL.DDJ[4] },
/* 1 */ {
        CommandL.DDJ[0],
        CommandL.DDJ[1],
        CommandL.DDJ[2],
        CommandL.DDJ[3],
        CommandL.DDJ[4] },
/* 2 */ {
         "Fachwerk",
         "Фахверк",
         "Graticcio",
         "Fachwerk",
         "半木造房屋"
      }
    };

    public static readonly string[] Select = {
      "  Select assembly consisting of Solid",
      "  Выберите сборку из деталей типа 3DSolid",
      "  Scegliere un assemblaggio da 3DSolid parts",
      "  Wählen Sie eine Baugruppe aus 3DSolid-Teilen",
      "  选择由零件组成的装配体" };
    public static readonly string[] Nothing = {
      "  Nothing to cut",
      "  Нечего вырезать",
      "  Niente da tagliare",
      "  Nichts zu schneiden",
      "  没什么可剪的" };
    public static readonly string[] DepthQuery = {
      "\n  Dado depth",
      "\n  Глубина паза",
      "\n  Profondità della scanalatura",
      "\n  Rillentiefe",
      "\n  给定深度" };
    public static readonly string[] Finding = {
      "Finding contacts",
      "Поиск контактов",
      "Cerca contatti",
      "Suche nach Kontakten",
      "查找联系人" };
    public static readonly string[] CombinationsErr = {
      "  Too many combinations",
      "  Слишком много комбинаций",
      "  Troppe combinazioni",
      "  Zu viele Kombinationen",
      "  组合太多" };
    public static readonly string[] StopErr = {
      "  Unable to create Stop {0}",
      "  Не получается создать Упор {0}",
      "  Impossibile creare la Supporto {0}",
      "  Knaggen {0} kann nicht erstellt werden",
      "  无法创建宽度为 {0} 的推力垫" };
    public static readonly string[] Least2Err = {
      "  Requires at least 2 solids",
      "  Требуется хотя бы 2 солида",
      "  Richiede almeno 2 solidi",
      "  Benötigt mindestens 2 Volumenkörper",
      "  至少需要 2 个固体" };
    public static readonly string[] Skipping = {
      "  Discovered contact the same planes. Skipping.",
      "  Обнаружен контакт одинаковыми плоскостями. Пропускаем.",
      "  Contatto rilevato dagli stessi aerei. La signorina.",
      "  Kontakt von denselben Flugzeugen erkannt. Überspringen.",
      "  发现接触同一架飞机。 跳过。" };
    public static readonly string[] Contacts = {
      "  Found contacts: {0}",
      "  Найдено контактов: {0}",
      "  Contatti trovati: {0}",
      "  Gefundene Kontakte: {0}",
      "  找到的联系人：{0}" };
    public static readonly string[] Making = {
      "Making joints",
      "Изготовление соединений",
      "Produrre composti",
      "Verbindungen herstellen",
      "制作关节" };
    public static readonly string[] ContinueQuery = {
      "Error: {0}\nContinue?",
      "Ошибка: {0}\nПродолжать?",
      "Errore: {0}\nContinua?",
      "Fehler: {0}\nWeiter?",
      "错误：{0}。\n继续？" };
    public static readonly string[] JointErr = {
      "Failed to connect between parts {0} and {1}",
      "Не получилось сделать соединение между деталями {0} и {1}",
      "Impossibile connettersi tra le parti {0} e {1}",
      "Verbindung zwischen den Teilen {0} und {1} fehlgeschlagen",
      "未能在 {0} 和 {1} 部分之间连接"};
    public static readonly string[] ThicknessErr = {
      "Unable to measure the thickness of part {0}",
      "Не получилось померить толщину детали {0}",
      "Impossibile misurare lo spessore della parte {0}",
      "Die Dicke des Teils {0} kann nicht gemessen werden",
      "无法测量部件 {0} 的厚度"};
    public static readonly string[] TooBigGapErr = {
      "The dado depth ({0}) is less than the Gap.",
      "Глубина паза ({0}) меньше зазора.",
      "La profondità della scanalatura ({0}) è inferiore allo spazio.",
      "Die Nuttiefe ({0}) ist kleiner als der Spalt.",
      "凹槽深度（{0}）小于间隙。"};
    public static readonly string[] TooBigBacklashErr = {
      "The dado depth ({0}) is less than the Backlash.",
      "Глубина паза ({0}) меньше, чем люфт.",
      "La profondità della scanalatura ({0}) è inferiore al gioco.",
      "Die Nuttiefe ({0}) ist kleiner als das Spiel.",
      "凹槽深度（{0}）小于间隙。"};
    public static readonly string[] SplitWarning = {
      "The dado cut the solid {0} into pieces. The remaining connections will be made only for one of the pieces.",
      "Паз разрезал солид {0} на части. Остальные соединения будут выполнены только для одной из частей.",
      "La scanalatura taglia il solido {0} in pezzi. I collegamenti rimanenti verranno effettuati solo per una delle parti.",
      "Die Nut schnitt den festen {0} in Stücke. Die restlichen Verbindungen werden nur für eines der Teile hergestellt.",
      "凹槽将实体{0}切成碎片。其余连接仅针对其中一个部件进行。"};
    public static readonly string[] MinAreaKW = {
      "MINArea",
      "МИНПлощадь",
      "AREAMinima",
      "MINFläche",
      "最小接触面积(M)" }; //Command line option
    public static readonly string[] StopKW = {
      "STOP",
      "УПОР",
      "SUPPORTO",
      "KNAGGEN",
      "推力垫(S)" }; //Command line option
    public static readonly string[] StopQuery = {
      "  Enter Stop value or zero",
      "  Введите ширину Упора или ноль",
      "  Inserisci la larghezza del Supporto o zero",
      "  Geben Sie einen Knaggen oder Null ein",
      "  输入停止垫的宽度或零" };
    public static readonly string[] MinAreaQuery = {
      "  Ignore the contact area is less than:",
      "  Игнорировать контакты площадью меньше чем:",
      "  Ignora i contatti più piccoli di:",
      "  Kontakte ignorieren, die kleiner sind als:",
      "  忽略接触面积小于："};
    public static readonly string[] SmallContactErr = {
      "  Found the contact is too small. Skipping." ,
      "  Найденный контакт слишком мал. Пропускаем.",
      "  Il contatto trovato è troppo piccolo. La signorina.",
      "  Der gefundene Kontakt ist zu klein. Überspringen.",
      "  发现触点太小。 跳过。"};
    public static readonly string[] ExpandDadoErr =    {
      "  It was not possible to expand the dado.",
      "  Не получилось удлинить паз.",
      "  Non è stato possibile estendere la scanalatura.",
      "  Eine Erweiterung der Nut war nicht möglich.",
      "  无法延长凹槽。" };
    public static readonly string[] Result = {
      "  Made joints: {0}" ,
      "  Сделано соединений: {0}",
      "  Collegamenti effettuati: {0}",
      "  Verbindungen hergestellt: {0}",
      "  制作接头：{0}"};
    public static readonly string[] SettingsInfo = {
      "  Current settings: Depth = {0}, MinArea = {1}, Gap = {2}, Backlash = {3}, Stop = {4}, Along = {5}",
      "  Текущие настройки: Глубина = {0}, МинПлощадь = {1}, Зазор = {2}, Люфт = {3}, Упор = {4}, Вдоль = {5}",
      "  Impostazioni correnti: Profondità = {0}, AreaMinima = {1}, Liquidazione = {2}, Gioco = {3}, Supporto = {4}, Lungo = {5}",
      "  Aktuelle Einstellungen: Tiefe = {0}, Mindestfläche = {1}, Spiel = {2}, Gegenreaktion = {3}, Knaggen = {4}, Entlang = {5}",
      "  当前设置：深度 = {0}，最小接触面积 = {1}，各个方向的间隙 = {2}, 深度反弹 = {3}, 推力垫 = {4}, 沿着 = {5}" };

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
         "在程序中没有使用。只是为了方便阅读。"};
    public static string[] Stop = {
      "Stop pad",
      "Упорная площадка",
      "Pattino di spinta (Supporto)",
      "Druckstück (Knaggen)",
      "推力垫" };
    public static string[] AlongEdges = {
      "Extrude along the beam",
      "Вытягивать вдоль балки",
      "Tirare lungo la trave",
      "Den Balken entlang ziehen",
      "沿横梁拉" };
    public static string[] DepthRequest = {
      "Request depth every time",
      "Запрашивать глубину каждый раз",
      "Richiedi profondità ogni volta",
      "Fordern Sie jedes Mal die Tiefe an",
      "每次都请求深度" };
    public static string[] StopTip = {
      "If you set a size greater than zero, the program will make an emphasis along the perimeter of the tenon. \r\n" +
        "That is, the tenon and dado will be smaller than the region of contact of the parts.",
      "Если задать размер больше ноля, то программа сделает упор по периметру шипа. \r\n" +
        "То есть шип и паз будут меньше региона контакта деталей.",
      "Se si imposta una dimensione maggiore di zero, il programma porrà l'enfasi lungo il perimetro del tenone. \r\n" +
        "Ciò significa che il tenone e la scanalatura saranno più piccoli della zona di contatto tra le parti.",
      "Wenn Sie eine Größe größer als Null einstellen, legt das Programm den Schwerpunkt entlang des Zapfenumfangs. \r\n" +
        "Das heißt, Zapfen und Nut sind kleiner als der Kontaktbereich zwischen den Teilen.",
      "如果设置的尺寸大于零，程序将重点放在榫头的周边。也就是说，榫头和槽口将小于零件之间的接触区域。" };
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
        "如果禁用该选项，榫头将垂直于零件接触平面被拉出。" };
    public static string[] DepthQueryTip = {
      "Prompt for depth and show command line options each time the command is called.",
      "При каждом вызове команды запрашивать глубину и показывать опции в командной строке.",
      "Richiedi profondità e mostra le opzioni della riga di comando ogni volta che viene chiamato il comando.",
      "Bei jedem Aufruf des Befehls wird nach der Tiefe gefragt und es werden Befehlszeilenoptionen angezeigt.",
      "每次调用命令时提示深度并显示命令行选项。" };

    public static readonly string[] ExpandDado = {
      "Dado across the entire part",
      "Паз на вылет",
      "Scanalatura sui bordi della parte",
      "Nut bis zu den Kanten des Teils",
      "凹槽至零件边缘" };
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
        "仅适用于矩形槽。" };

  }
}
