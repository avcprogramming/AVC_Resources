// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  FilletL
  {
    public static readonly string[] NeedLinerEdge = {
      "Required to select liner edge of solid",
      "Требуется выбрать прямое ребро солида",
      "Necessario per scegliere un lato dritto del solido",
      "Erforderlich, um eine gerade Kante eines Volumenkörpers zu wählen",
      "要求选择实体的直边" };
    public static readonly string[] NoFlatFace = {
      "Faces on this edge is no flat",
      "Грани для выбранного ребра не являются плоскими",
      "I bordi per i bordi selezionati non sono piatti.",
      "Kanten für ausgewählte Kanten sind nicht flach.",
      "与该边相邻的实体的面不平坦" };
    public static readonly string[] NeedInsideCorner ={
      "It's outside corner. Required to select edge of inside corner",
      "Наружный угол. Необходимо выбрать ребро внутреннего угла",
      "Angolo esterno Devi selezionare il bordo dell'angolo interno",
      "Äußere Ecke. Sie müssen den Rand der inneren Ecke auswählen",
      "这是外角。 您必须选择内角的边缘" };
    public static readonly string[] InvalidVertexNo = {
      "Incorrect polyline vertex number in the corner processing procedure",
      "Ошибочный номер вершины полилинии в процедуре обработки углов.",
      "Numero di vertice della polilinea errato nella procedura di elaborazione degli angoli",
      "Falsche Scheitelpunktnummer der Polylinie im Eckenbearbeitungsverfahren",
      "拐角处理过程中的折线顶点数不正确" };
    public static readonly string[] NoPrevSegment = {
      "Corner procedure failed to get the previous polyline segment",
      "Процедура обработки углов не смогла получить предыдущий сегмент полилинии",
      "La procedura d'angolo non è riuscita a ottenere il segmento di polilinea precedente",
      "Falsche Scheitelpunktnummer der Polylinie im Eckenbearbeitungsverfahren",
      "拐角程序未能获取上一个折线段" };
    public static readonly string[] BrokenPolyline = {
      "Polyline broken at vertex {0}",
      "Полилиния разорвана у вертекса {0}",
      "Polilinea interrotta al vertice {0}",
      "Polylinie an Scheitelpunkt {0} unterbrochen",
      "折线在顶点 {0} 处断开" };
    public static readonly string[] Acute ={
      "The angle is acute! The contour cannot be processed by milling",
      "Угол острый! Контур невозможно обработать фрезерованием",
      "L'angolo è nitido! Contour non può essere lavorato.",
      "Der Winkel ist scharf! Kontur kann nicht bearbeitet werden.",
      "尖角！ 轮廓无法铣削"};
    public static readonly string[] Corner180 ={
      "The angle formed by the segments need not be equal to 180",
      "Угол образованный сегментами не должен быть равен 180",
      "L'angolo formato dai segmenti non deve essere uguale a 180",
      "Der von den Segmenten gebildete Winkel sollte nicht gleich 180 sein",
      "线段形成的角度不得等于 180"};
    public static readonly string[] SegmentTooShort = {
      "The segment are too short for cutting corner. Skip.",
      "Сегмент слишком короткий для вырезания угла. Пропускаем.",
      "Segmento troppo corto per tagliare un angolo. Salta.",
      "Segment zu kurz, um eine Ecke zu schneiden. Überspringen Sie es.",
      "该段太短而不能切角。 我们跳过。" };
    public static readonly string[] ICResult = {
      "{0} corners have been cut.",
      "Сделано {0} заходов в угол.",
      "Effettuate {0} chiamate d'angolo.",
      "{0} Eckenrufe gemacht.",
      "对角落进行了 {0} 次访问。" };
    public static readonly string[] NotIntersect = {
      "Cutter arc not intersect segment.",
      "Не найдено пересечение дуги фрезы с сегментом.",
      "Non è stata trovata l'intersezione dell'arco con un segmento.",
      "Der Schnittpunkt des Bogenschneiders mit einem Segment wurde nicht gefunden.",
      "未找到刀具弧与线段的交点。" };
    public static readonly string[] CutFailed = {
      "Corner processing failed. Reason: {0}",
      "Процедура обработки углов не удалась. Причина: {0}",
      "Elaborazione dell'angolo non riuscita. Motivo: {0}",
      "Eckenverarbeitung fehlgeschlagen. Grund: {0}",
      "边角处理失败。 原因：{0}" };
    public static readonly string[] OutsideQuery = {
      "Is this outside contour?",
      "Это наружный контур?",
      "È un contorno esterno?",
      "Ist es eine äußere Kontur?",
      "这是外轮廓吗？" };
    public static readonly string[] CarveCorners = {
      "Carve corners",
      "Обработка углов",
      "Elaborazione angolare",
      "Eckenbearbeitung",
      "雕刻角落" };
    public static readonly string[] FilletResult = {
      "  {0} corners have been fillet. {1} no need to fillet. {2} errors.",
      "  Сделано {0} скруглений. Не нужно скруглять {1}. Ошибок {2}.",
      "  Fatto {0} raccordo. Non c'è bisogno di arrotondare {1}. Errori {2}.",
      "  {0} Abrunden gemacht. {1} muss nicht abgerundet werden. Fehler {2}.",
      "  {0} 个角已被圆角化。 {1} 无需圆角。 {2} 个错误。" };
    public static readonly string[] DiamTooSmallErr = {
      "Cutter diameter is too small",
      "Слишком маленький диаметр фрезы",
      "Diametro dell'utensile troppo piccolo",
      "Fräserdurchmesser zu klein",
      "刀具直径太小" };
    public static readonly string[] NoCommonPoint = {
      "Segments have no common point",
      "Сегменты не имеют общей точки",
      "I segmenti non hanno un punto in comune",
      "Segmente haben keinen gemeinsamen Punkt",
      "段没有共同点" };
    public static readonly string[] FilletStraight = {
      "Impossible to build a fillet because the angle straight (180 degrees)",
      "Невозможно построить скругление, потому что угол развернутый (180 градусов)",
      "È impossibile costruire un percorso, perché l'angolo è diritto (180 gradi)",
      "Es ist unmöglich eine Abrunden zu bauen, da der Winkel entfaltet ist (180 Grad).",
      "无法构建圆角，因为角已旋转（180 度）" };
    public static readonly string[] StraightSkip = {
      "The angle formed by the segments almost straight ({0}). Skip.",
      "Угол образованный сегментами почти развернутый ({0}). Пропускаем.",
      "L'angolo formato dai segmenti è quasi diritto ({0}). Salta.",
      "Der von den Segmenten gebildete Winkel ist nahezu entfaltet ({0}). Überspringen Sie es.",
      "由线段形成的角几乎是转弯 ({0})。 我们跳过。" };
    public static readonly string[] SegmentErr = {
      "Segment does not belong to polyline",
      "Сегмент не принадлежит полилинии",
      "Il segmento non appartiene alla polilinea",
      "Segment gehört nicht zur Polylinie",
      "段不属于折线" };
    public static readonly string[] FilletImpossible = {
      "Impossible to build a fillet",
      "Невозможно построить скругление",
      "Impossibile creare arrotondamenti",
      "Abrunden nicht möglich",
      "无法创建回合" };
    public static readonly string[] NonClosed = {
      "On an non-closed polyline, the program will fillet all corners on both sides.",
      "На незамкнутой полилинии программа будет делать скругления всех углов с обоих сторон.",
      "Su una polilinea non chiusa, il programma raccorderà tutti gli angoli su entrambi i lati.",
      "Bei einer nicht geschlossenen Polylinie rundet das Programm alle Ecken auf beiden Seiten ab.",
      "在开放的多段线上，程序将圆角两侧的所有角。" };
    public static readonly string[] SelectDiam = {
      "Select object (D={0}) ",
      "Выберите объект (D={0}) ",
      "Seleziona l'oggetto (D={0}) ",
      "Wählen Sie ein Objekt aus (D={0}) ",
      "选择对象 (D={0})"};
    public static readonly string[] SelectDiamSide = {
      "Select object for fillet (D={0}, {1}) ",
      "Выберите объект скругления (D={0}, {1}) ",
      "Seleziona l'oggetto da raccordare (D={0}, {1}) ",
      "Wählen Sie ein Abrundenobjekt aus (D={0}, {1}) ",
      "选择圆角对象（D={0}、{1}）"};
    public static readonly string[] SelectSegment = {
      "Select second polyline segment",
      "Выберете второй сегмент полилинии",
      "Seleziona il secondo segmento di polilinea",
      "Wählen Sie das zweite Polyliniensegment aus",
      "选择第二条折线段" };
    public static readonly string[] SelectPolyline = {
      "Select closed polyline or polyline segment. Use CTRL or 'subselectON'",
      "Выберите замкнутую полилинию или 1 сегмент полилинии. Для выбора используйте CTRL или включите режим 'частиВКЛ'",
      "Seleziona una polilinea chiusa o 1 segmento polilinea. Usa CTRL o seleziona la modalità 'subselectACCESO' per la selezione.",
      "Wählen Sie eine geschlossene Polylinie oder ein Polyliniensegment aus. " +
        "Verwenden Sie STRG oder wählen Sie den Modus 'UnterauswahlAN' zur Auswahl.",
      "选择闭合的多段线或 1 个多段线段。 使用 CTRL 选择或打开“部件开启”模式"};
    public static readonly string[] IncorrectSegment = {
      "Incorrect selection of polyline segments",
      "Некорректный выбор сегментов полилинии",
      "Selezione non valida dei segmenti di polilinea",
      "Ungültige Auswahl von Polyliniensegmenten",
      "Некорректный выбор сегментов полилинии",
      "折线段选择不正确"};
    public static readonly string[] Need2 = {
      "Need 2 segments with a common point.",
      "Нужны 2 сегмента с обшей точкой.",
      "Alla ricerca di 2 segmenti con un punto comune.",
      "Suche nach 2 Segmenten mit einem gemeinsamen Punkt.",
      "我们需要 2 个具有共同点的线段。" };
    public static readonly string[] SegmentTwiceErr = {
      "Selected the same segment twice",
      "Был выбран один и тот же сегмент",
      "Lo stesso segmento è stato selezionato.",
      "Das gleiche Segment wurde ausgewählt.",
      "选择了相同的细分" };
    public static readonly string[] SelectLine = {
      "Select second line",
      "Выберете второй отрезок",
      "Scegli il secondo segmento",
      "Wählen Sie das zweite Segment",
      "选择第二段" };
    public static readonly string[] NeedLine ={
      "Select incorrect type of object. Need line or arc.",
      "Был выбран неверный тип объекта. Нужна линия или дуга.",
      "È stato selezionato un tipo di oggetto non valido. Hai bisogno di una linea o arco.",
      "Ein ungültiger Objekttyp wurde ausgewählt. Benötigen Sie eine Linie oder einen Bogen.",
      "选择了错误的对象类型。 需要一条线或弧线。" };
    public static readonly string[] ObjTwiceErr = {
      "Selected the same object twice",
      "Был выбран один и тот же объект",
      "Lo stesso oggetto è stato selezionato.",
      "Das gleiche Objekt wurde ausgewählt.",
      "选择了相同的对象" };
    public static readonly string[] TooSmallErr ={
      "Incorrect segments\n(too small or not set the plane)",
      "Неподходящие сегменты\n(слишком мелкие или не задают плоскость)",
      "Segmenti non adatti\n(troppo piccoli o non definiscono un piano)",
      "Ungeeignete Segmente\n(zu klein oder definieren keine Ebene)",
      "不适当的段\n（太小或未定义平面）"};
    public static readonly string[] TypeErr = {
      "Incorrect selection of object type",
      "Команда не работает с таким типом объектов",
      "Il comando non funziona con questo tipo di oggetti." ,
      "Der Befehl funktioniert nicht mit dieser Art von Objekten.",
      "该命令不适用于此类对象" };
    public static readonly string[] NeedSegment = {
      "Need another segment on the same polyline",
      "Нужен сегмент той же полилинии",
      "Hai bisogno di un segmento della stessa polilinea",
      "Benötigen Sie ein Segment derselben Polylinie",
      "需要一段相同的折线" };


    public static readonly string[] DiamKW = 
      { "Diameter", "ДИаметр", "Diametro", "Durchmesser", "直径(D)" }; // selection option!!
    public static readonly string[] SubOnKW = 
      { "subselectON", "частиВКЛ", "subselectACCESO", "UnterauswahlAN", "子选择开(ON)" }; // selection option!!
    public static readonly string[] SubOffKW = 
      { "subselectOFF", "частиВЫК", "subselectSPENTO", "UnterauswahlAUS", "子选择关闭(OFF)" }; // selection option!!
    public static readonly string[] MillSideKW = 
      { "MIllSide", "СТоронаФрезы", "FReseLaterali", "SEitenschneider", "侧切刀(MI)" }; // selection option!!
    public static readonly string[] BothSideKW = 
      { "BOthSide", "ВСеУглы", "ENtrambiILati", "BEideSeiten", "从四面八方(BO)" }; // selection option!!
    // не добавлять стандартные ключевые слова 
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

  }
}
