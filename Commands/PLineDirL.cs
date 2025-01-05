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
      "MID",
      "СЕРЕДИНА",
      "MEZZO",
      "MITTE",
      "中点(MID)"};

    public static readonly string[] AllStartAtMinKw = {
      "MIN",
      "МИНИМУМ",
      "MINIMO",
      "MINIMUM",
      "最低点(MIN)"};

    public static readonly string[] AllStartAtMaxKw = {
      "MAX",
      "МАКСИМУМ",
      "MASSIMO",
      "MAXIMAL",
      "最大点(MAX)"};

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
      "The program will prompt you to select multiple curves and will set the start of each at the node with the minimum UCS coordinates. \r\n" +
        "Open curves are ignored.",
      "Программа будет запрашивать выбор нескольких кривых, и всем им назначит старт в узле с минимальными координатами UCS.\r\n" +
        "Незамкнутые кривые игнорируются.",
      "Il programma ti chiederà di selezionare più curve e imposterà l'inizio di ciascuna al nodo con le coordinate UCS minime.\r\n" +
        "Le curve aperte sono ignorate.",
      "Das Programm fordert Sie auf, mehrere Kurven auszuwählen, und setzt den Startpunkt jeder Kurve auf den Knoten mit den minimalen UCS-Koordinaten.\r\n" +
        "Offene Kurven werden ignoriert.",
      "程序将提示您选择多条曲线，并将每条曲线的起点设置在具有最小UCS坐标的节点。\r\n" +
        "未闭合的曲线将被忽略。" };

    public static readonly string[] AllStartAtMaxTip = {
      "The program will prompt you to select multiple curves and will set the start of each at the node with the maximum UCS coordinates." +
        " Open curves are ignored.",
      "Программа будет запрашивать выбор нескольких кривых, и всем им назначит старт в узле с максимальными координатами UCS." +
        " Незамкнутые кривые игнорируются.",
      "Il programma ti chiederà di selezionare più curve e imposterà l'inizio di ciascuna al nodo con le coordinate UCS massime." +
        " Le curve aperte sono ignorate.",
      "Das Programm fordert Sie auf, mehrere Kurven auszuwählen, und setzt den Startpunkt jeder Kurve auf den Knoten mit den maximalen UCS-Koordinaten." +
        " Offene Kurven werden ignoriert.",
      "程序将提示您选择多条曲线，并将每条曲线的起点设置在具有最大UCS坐标的节点。" +
        " 未闭合的曲线将被忽略。" };


  }
}
