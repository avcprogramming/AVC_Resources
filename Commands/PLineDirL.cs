// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Ccw

namespace AVC
{
  public static class 
  PLineDirL
  {

    public static readonly string[,] PLineDirStyleNames = {
/* 0 */ {
        CommandL.PLineDir[0],
        CommandL.PLineDir[1],
        CommandL.PLineDir[2],
        CommandL.PLineDir[3],
        CommandL.PLineDir[4] },
/* 1 */ {
        CommandL.PLineDir[0],
        CommandL.PLineDir[1],
        CommandL.PLineDir[2],
        CommandL.PLineDir[3],
        CommandL.PLineDir[4] },
    };

    public static readonly string[] ClickForReverseKw = {
      "REVERSE",
      "РЕВЕРС",
      "INVERSione",
      "UMKEHREN",
      "反向(REV)"};

    public static readonly string[]  AllCwKw = {
      "CW",
      "ПОЧасовой",
      "ORARIO",
      "UHRzigersinn",
      "顺时针发送(CW)"};

    public static readonly string[]  AllCcwKw = {
      "CCW",
      "ПРОТИВЧасовой",
      "ANTIorario",
      "GEGENuhrzeigersinn",
      "逆时针直接(CCW)"};

    public static readonly string[]  ClickStartKw = {
      "START",
      "НАЧАЛО",
      "INIZIO",
      "START",
      "设定起点(ST)"};

    public static readonly string[] AllStartAtMidKw = {
      "MIDLongest",
      "СЕРЕДИНАДлинной",
      "MEZZOLungo",
      "MITTELängsten",
      "中点(MIDL)"};

    public static readonly string[] AllStartAtMinKw = {
      "MINPoint",
      "МИНТочка",
      "MINPunto",
      "MINPunkt",
      "最低点(MINP)"};

    public static readonly string[] AllStartAtMaxKw = {
      "MAXPoint",
      "МАКСТочка",
      "MASPunto",
      "MAXPunkt",
      "最大点(MAXP)"};

    public static readonly string[] ClickForReverseQuery = {
      "Click on the curves that need to be reversed",
      "Кликните по кривым, которые надо развернуть",
      "Fai clic sulle curve che devono essere invertite",
      "Klicken Sie auf die Kurven, die umgekehrt werden müssen",
      "点击需要反转的曲线"    };

    public static readonly string[] AllCwQuery = {
      "Select all curves that should be oriented clockwise",
      "Выберите все кривые, которые должны быть развернуты по часовой стрелке",
      "Seleziona tutte le curve che devono essere orientate in senso orario",
      "Wählen Sie alle Kurven aus, die im Uhrzeigersinn orientiert werden sollen",
      "选择所有需要顺时针方向排列的曲线"    };

    public static readonly string[] AllCcwQuery = {
      "Select all curves that should be oriented counterclockwise",
      "Выберите все кривые, которые должны быть развернуты против часовой стрелке",
      "Seleziona tutte le curve che devono essere orientate in senso antiorario",
      "Wählen Sie alle Kurven aus, die gegen den Uhrzeigersinn orientiert werden sollen",
      "选择所有需要逆时针方向排列的曲线" };

    public static readonly string[] ClickStartQuery = {
      "Click on the curve to set the starting point",
      "Кликните по кривой выбора точки старта",
      "Fare clic sulla curva per impostare il punto di inizio",
      "Klicken Sie auf die Kurve, um den Startpunkt festzulegen",
      "点击曲线以设置起点" };

    public static readonly string[] AllStartAtMidQuery = {
      "Select curves whose starting point should be moved to the middle of the longest straight segment",
      "Выберите кривые, которым надо перенести точку старта на середину длинной линии",
      "Seleziona le curve di cui spostare il punto di inizio al centro del segmento dritto più lungo",
      "Wählen Sie Kurven, deren Startpunkt in die Mitte des längsten geraden Segments verschoben werden soll",
      "选择需要将起点移动到最长直线段中点的曲线"  };

    public static readonly string[] AllStartAtMinQuery = {
      "Select curves whose starting point should be moved to the minimum coordinate node",
      "Выберите кривые, которым надо перенести точку старта на минимальный узел",
      "Seleziona le curve di cui spostare il punto di inizio al nodo di coordinata minima",
      "Wählen Sie Kurven, deren Startpunkt auf den Knoten mit den minimalen Koordinaten verschoben werden soll",
      "选择需要将起点移动到最小坐标节点的曲线" };

    public static readonly string[] AllStartAtMaxQuery = {
      "Select curves whose starting point should be moved to the maximum coordinate node",
      "Выберите кривые, которым надо перенести точку старта на максимальный узел",
      "Seleziona le curve di cui spostare il punto di inizio al nodo di coordinata massima",
      "Wählen Sie Kurven, deren Startpunkt auf den Knoten mit den maximalen Koordinaten verschoben werden soll",
      "选择需要将起点移动到最大坐标节点的曲线" };

    public static readonly string[] ChangeStartError = {
      "Failed to change the starting point of the curve {0}",
      "Не удалось заменить стартовую точку у кривой {0}",
      "Impossibile sostituire il punto di inizio della curva {0}",
      "Der Startpunkt der Kurve {0} konnte nicht ersetzt werden",
      "无法替换曲线 {0} 的起点" };

    public static readonly string[] MidPointError = {
      "Failed to select the best midpoint for the curve {0}",
      "Не удалось выбрать лучшую среднюю точку у кривой {0}",
      "Impossibile selezionare il miglior punto medio per la curva {0}",
      "Der beste Mittelpunkt für die Kurve {0} konnte nicht ausgewählt werden",
      "无法选择曲线 {0} 的最佳中点" };

    public static readonly string[] ExtentsError = {
      "Failed to get the extents of the curve {0}",
      "Не удалось получить габариты кривой {0}",
      "Impossibile ottenere le dimensioni della curva {0}",
      "Die Abmessungen der Kurve {0} konnten nicht ermittelt werden",
      "无法获取曲线 {0} 的范围" };

    public static readonly string[] DirectionError = {
      "Failed to determine the direction of the curve {0}",
      "Не удалось определить направление кривой {0}",
      "Impossibile determinare la direzione della curva {0}",
      "Die Richtung der Kurve {0} konnte nicht bestimmt werden",
      "无法确定曲线 {0} 的方向" };

    public static readonly string[] PointError = {
      "No curve found at the specified point",
      "Не найдена кривая под заданной точкой",
      "Nessuna curva trovata nel punto specificato",
      "Keine Kurve an der angegebenen Stelle gefunden",
      "在指定点处未找到曲线" };

    public static readonly string[] ShowDirection = {
      "Show direction",
      "Показ направлений",
      "Mostra direzione",
      "Richtung anzeigen",
      "显示方向" };

    public static readonly string[] Processing = {
      "Processing",
      "Обработка",
      "Elaborazione",
      "Verarbeitung",
      "处理" };

    //=================================================== для диалога настройки ===================================================

    public static readonly string[] ClickForReverse = {
      "Click to reverse",
      "Кликнуть для разворота",
      "Fare clic per invertire",
      "Zum Umkehren klicken",
      "点击反转" };

    public static readonly string[] AllCw = {
      "All clockwise",
      "Все по часовой стрелке",
      "Tutto in senso orario",
      "Alle im Uhrzeigersinn",
      "全部顺时针" };

    public static readonly string[] AllCcw = {
      "All counterclockwise",
      "Все против часовой стрелки",
      "Tutto in senso antiorario",
      "Alle gegen den Uhrzeigersinn",
      "全部逆时针" };

    public static readonly string[] ClickStart = {
      "Click start point",
      "Кликнуть точку старта",
      "Fare clic sul punto di inizio",
      "Startpunkt anklicken",
      "点击起点" };

    public static readonly string[] AllStartAtMid = {
      "Start at middle of line",
      "Стартовать в середине линии",
      "Iniziare al centro della linea",
      "Start in der Mitte der Linie",
      "从线的中点开始" };

    public static readonly string[] AllStartAtMin = {
      "Start at minimum node",
      "Стартовать на минимальном узле",
      "Iniziare al nodo minimo",
      "Start am minimalen Knoten",
      "从最小节点开始" };

    public static readonly string[] AllStartAtMax = {
      "Start at maximum node",
      "Стартовать на максимальном узле",
      "Iniziare al nodo massimo",
      "Start am maximalen Knoten",
      "从最大节点开始" };

    public static readonly string[] ClickForReverseTip = {
      "The program will prompt you to select a single curve to reverse.\r\n" +
        "Selection with a frame does not work. " +
        "You can reverse open curves.",
      "Программа будет запрашивать выбор одной кривой, которую надо развернуть. \r\n" +
        "Выбор рамкой не работает. " +
        "Можно разворачивать незамкнутые кривые.",
      "Il programma ti chiederà di selezionare una singola curva da invertire.\r\n" +
        "La selezione con finestra non funziona. " +
        "Puoi invertire curve aperte.",
      "Das Programm fordert Sie auf, eine einzelne Kurve zum Umkehren auszuwählen.\r\n" +
        "Die Fensterauswahl funktioniert nicht. " +
        "Sie können offene Kurven umkehren.",
      "程序将提示您选择一条要反转的曲线。\r\n" +
        "无法使用窗口选择。 " +
        "您可以反转未闭合的曲线。"  };

    public static readonly string[] AllCwTip = {
      "The program will prompt you to select multiple curves, and will set them all to have a clockwise orientation.\r\n" +
        "Open curves are ignored.",
      "Программа будет запрашивать выбор нескольких кривых, и всем им назначит направление обхода по часовой стрелке.\r\n" +
        "Незамкнутые кривые игнорируются.",
      "Il programma ti chiederà di selezionare più curve, e assegnerà a tutte un orientamento in senso orario.\r\n" +
        "Le curve aperte sono ignorate.",
      "Das Programm fordert Sie auf, mehrere Kurven auszuwählen, und setzt bei allen eine Ausrichtung im Uhrzeigersinn.\r\n" +
        "Offene Kurven werden ignoriert.",
      "程序将提示您选择多条曲线，并将它们全部设置为顺时针方向。\r\n" +
        "未闭合的曲线将被忽略。" };

    public static readonly string[] AllCcwTip = {
      "The program will prompt you to select multiple curves, and will set them all to have a counterclockwise orientation.\r\n" +
        "Open curves are ignored.",
      "Программа будет запрашивать выбор нескольких кривых, и всем им назначит направление обхода против часовой стрелки.\r\n" +
        "Незамкнутые кривые игнорируются.",
      "Il programma ti chiederà di selezionare più curve, e assegnerà a tutte un orientamento in senso antiorario.\r\n" +
        "Le curve aperte sono ignorate.",
      "Das Programm fordert Sie auf, mehrere Kurven auszuwählen, und setzt bei allen eine Ausrichtung gegen den Uhrzeigersinn.\r\n" +
        "Offene Kurven werden ignoriert.",
      "程序将提示您选择多条曲线，并将它们全部设置为逆时针方向。\r\n" +
        "未闭合的曲线将被忽略。" };

    public static readonly string[] ClickStartTip = {
      "The program will prompt you for a point on a curve and will move the start of the curve to that point.\r\n" +
        "Open curves will be split into two parts.",
      "Программа будет запрашивать одну точку на кривой и перенесет начало кривой в эту точку.\r\n" +
        "Незамкнутые кривые будут разорваны на две части.",
      "Il programma ti chiederà un punto su una curva e sposterà l'inizio della curva a quel punto.\r\n" +
        "Le curve aperte saranno divise in due parti.",
      "Das Programm fordert Sie auf, einen Punkt auf einer Kurve auszuwählen, und verschiebt den Anfang der Kurve an diesen Punkt.\r\n" +
        "Offene Kurven werden in zwei Teile geteilt.",
      "程序将提示您在曲线上选择一个点，并将曲线的起点移动到该点。\r\n" +
        " 未闭合的曲线将被分成两部分。" };

    public static readonly string[] AllStartAtMidTip = {
      "The program will prompt you to select multiple curves and will set the start of each at the middle of the longest straight segment.\r\n" +
        "Splines, arcs, ellipses, and open curves are ignored.",
      "Программа будет запрашивать выбор нескольких кривых, и всем им назначит старт в середине длинного прямого сегмента.\r\n" +
        "Сплайны, дуги, эллипсы и незамкнутые кривые игнорируются.",
      "Il programma ti chiederà di selezionare più curve e imposterà l'inizio di ciascuna al centro del segmento rettilineo più lungo.\r\n" +
        "Spline, archi, ellissi e curve aperte sono ignorate.",
      "Das Programm fordert Sie auf, mehrere Kurven auszuwählen, und setzt den Startpunkt jeder Kurve in die Mitte des längsten geraden Segments.\r\n" +
        "Splines, Bögen, Ellipsen und offene Kurven werden ignoriert.",
      "程序将提示您选择多条曲线，并将每条曲线的起点设置在最长直线段的中点。\r\n" +
        "样条曲线、弧线、椭圆和未闭合的曲线将被忽略。" };

    public static readonly string[] AllStartAtMinTip = {
      "The program will prompt you to select multiple curves and will set the start of each at the node with the minimum UCS coordinates.",
      "Программа будет запрашивать выбор нескольких кривых, и всем им назначит старт в узле с минимальными координатами UCS.",
      "Il programma ti chiederà di selezionare più curve e imposterà l'inizio di ciascuna al nodo con le coordinate UCS minime.",
      "Das Programm fordert Sie auf, mehrere Kurven auszuwählen, und setzt den Startpunkt jeder Kurve auf den Knoten mit den minimalen UCS-Koordinaten.",
      "程序将提示您选择多条曲线，并将每条曲线的起点设置在具有最小UCS坐标的节点。"};

    public static readonly string[] AllStartAtMaxTip = {
      "The program will prompt you to select multiple curves and will set the start of each at the node with the maximum UCS coordinates.",
      "Программа будет запрашивать выбор нескольких кривых, и всем им назначит старт в узле с максимальными координатами UCS.",
      "Il programma ti chiederà di selezionare più curve e imposterà l'inizio di ciascuna al nodo con le coordinate UCS massime.",
      "Das Programm fordert Sie auf, mehrere Kurven auszuwählen, und setzt den Startpunkt jeder Kurve auf den Knoten mit den maximalen UCS-Koordinaten.",
      "程序将提示您选择多条曲线，并将每条曲线的起点设置在具有最大UCS坐标的节点。" };

    public static readonly string[] Mode = {
      "Mode of operation",
      "Режим работы команды",
      "Modalità di funzionamento",
      "Betriebsmodus",
      "操作模式"    };
    public static readonly string[] StyleNameTip = {
      "Style name for command settings. Does not affect the operation of the command.",
      "Название для стиля настроек команды. Не влияет на работу команды.",
      "Nome dello stile per le impostazioni del comando. Non influisce sul funzionamento del comando.",
      "Stilname für Befehls-Einstellungen. Beeinflusst nicht den Betrieb des Befehls.",
      "命令设置的样式名称。 不影响命令的操作。"    };
    public static readonly string[] UseColor = {
      "Show direction with color",
      "Показать направление цветом",
      "Mostra direzione con colore",
      "Richtung mit Farbe anzeigen",
      "用颜色显示方向"    };
    public static readonly string[] UseColorTip = {
      "Change the color of all curves during the command. The original color will be restored after the command ends. \r\n" +
        "Flat closed curves with clockwise direction - green. \r\n" +
        "Flat closed curves with counterclockwise direction - purple. \r\n" +
        "Circles or non-flat or non-closed - yellow.",
      "На время работы команды менять цвет всех кривых. После окончания команды будет возвращен исходный цвет. \r\n" +
        "Плоские замкнутые кривые с обходом по часовой стрелке - зеленые. \r\n" +
        "Плоские замкнутые кривые с обходом против часовой стрелки - фиолетовые. \r\n" +
        "Окружности или не плоские или не замкнутые - желтый.",
      "Cambia il colore di tutte le curve durante il comando. Il colore originale verrà ripristinato al termine del comando. \r\n" +
        "Curve chiuse piatte con direzione oraria - verde. \r\n" +
        "Curve chiuse piatte con direzione antioraria - viola. \r\n" +
        "Cerchi o non piatti o non chiusi - giallo.",
      "Ändern Sie die Farbe aller Kurven während des Befehls. Die ursprüngliche Farbe wird nach dem Ende des Befehls wiederhergestellt. \r\n" +
        "Flache geschlossene Kurven mit Uhrzeigersinn - grün. \r\n" +
        "Flache geschlossene Kurven gegen den Uhrzeigersinn - lila. \r\n" +
        "Kreise oder nicht flach oder nicht geschlossen - gelb.",
      "在命令期间更改所有曲线的颜色。 命令结束后将恢复原始颜色。 \r\n" +
        "顺时针方向的平面闭合曲线 - 绿色。 \r\n" +
        "逆时针方向的平面闭合曲线 - 紫色。 \r\n" +
        "圆形或非平面或非闭合 - 黄色。"    };

    public static readonly string[] SelectQuery = {
      "Request for highlighting",
      "Запрашивать для подсветки",
      "Richiesta di evidenziazione",
      "Anfrage zur Hervorhebung",
      "请求突出显示"    };
    public static readonly string[] SelectQueryTip = {
      "Usually, the command changes the color and draws arrows for all curves in the visible part of the screen. \r\n" +
        "But you can set a request to select the curves to indicate the direction.",
      "Обычно команда меняет цвет и рисует стрелки у всех кривых в видимой части экрана. \r\n" +
        "Но вы можете настроить запрос на выбор кривых, которым надо обозначить направление.",
      "Di solito, il comando cambia il colore e disegna frecce per tutte le curve nella parte visibile dello schermo. \r\n" +
        "Ma puoi impostare una richiesta per selezionare le curve per indicare la direzione.",
      "Normalerweise ändert der Befehl die Farbe und zeichnet Pfeile für alle Kurven im sichtbaren Teil des Bildschirms. \r\n" +
        "Aber Sie können eine Anfrage stellen, um die Kurven auszuwählen, um die Richtung anzuzeigen.",
      "通常，命令会更改屏幕可见部分中所有曲线的颜色并绘制箭头。 \r\n" +
        "但您可以设置请求以选择要指示方向的曲线。"    };
    public static readonly string[] DrawPoint = {
      "Starting point",
      "Стартовая точка",
      "Punto di partenza",
      "Startpunkt",
      "起点"  };
    public static readonly string[] DrawPointTip = {
      "A cross will be drawn at the starting point of all curves.",
      "У всех кривых будет нарисован крестик в точке старта.",
      "Un croce sarà disegnata nel punto di partenza di tutte le curve.",
      "Ein Kreuz wird am Startpunkt aller Kurven gezeichnet.",
      "所有曲线的起点将绘制一个十字。"  };
    public static readonly string[] DrawStartArrow = {
      "Arrow from the start",
      "Стрелка в начале",
      "Freccia all'inizio",
      "Pfeil am Anfang",
      "起点的箭头"  };
    public static readonly string[] DrawStartArrowTip = {
      "An arrow will be drawn from the starting point in the direction of the curve.",
      "У всех кривых будет нарисована стрелка из стартовой точке в направлении обхода кривой",
      "Una freccia sarà disegnata dal punto di partenza nella direzione della curva.",
      "Ein Pfeil wird vom Startpunkt in Richtung der Kurve gezeichnet.",
      "将从起点沿曲线方向绘制一个箭头。" };
    public static readonly string[] DrawEndArrow = {
      "Arrow to the end",
      "Стрелка в конце",
      "Freccia alla fine",
      "Pfeil am Ende",
      "终点的箭头" };
    public static readonly string[] DrawEndArrowTip = {
      "An arrow will be drawn to the end point of all curves.",
      "У всех кривых будет нарисована стрелка к конечной точке",
      "Una freccia sarà disegnata al punto finale di tutte le curve.",
      "Ein Pfeil wird zum Endpunkt aller Kurven gezeichnet.",
      "将绘制一个箭头到所有曲线的终点。" };
    public static readonly string[] ArrowColor = {
      "Arrow color",
      "Цвет стрелок",
      "Colore della freccia",
      "Pfeilfarbe",
      "箭头颜色" };
    public static readonly string[] ArrowColorTip = {
      "Color of temporary crosses and arrows. \r\n" +
        "Choose one of the standard indexed colors from 1 to 255. 1 is red.",
      "Цвет временных крестиков и стрелок. \r\n" +
        "Выберите один из стандартных индексированных цветов от 1 до 255. 1 - это красный цвет.",
      "Colore delle croci e delle frecce temporanee. \r\n" +
        "Scegli uno dei colori indicizzati standard da 1 a 255. 1 è rosso.",
      "Farbe der temporären Kreuze und Pfeile. \r\n" +
        "Wählen Sie eine der standardmäßigen indizierten Farben von 1 bis 255. 1 ist rot.",
      "临时十字和箭头的颜色。 \r\n" +
        "选择1到255之间的标准索引颜色之一。 1是红色。"};

  }
}
