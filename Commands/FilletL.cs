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
      "要求选择实体的直边",
      "Se requiere seleccionar un borde recto del sólido",  // ES
      "Requis de sélectionner une arête droite du solide",  // FR
      "Katının düz bir kenarını seçmek gereklidir" };  // TR

    public static readonly string[] NoFlatFace = {
      "Faces on this edge is no flat",
      "Грани для выбранного ребра не являются плоскими",
      "I bordi per i bordi selezionati non sono piatti.",
      "Kanten für ausgewählte Kanten sind nicht flach.",
      "与该边相邻的实体的面不平坦",
      "Las caras del borde seleccionado no son planas",  // ES
      "Les faces de l'arête sélectionnée ne sont pas planes",  // FR
      "Seçilen kenarın yüzleri düz değildir" };  // TR

    public static readonly string[] NeedInsideCorner ={
      "It's outside corner. Required to select edge of inside corner",
      "Наружный угол. Необходимо выбрать ребро внутреннего угла",
      "Angolo esterno Devi selezionare il bordo dell'angolo interno",
      "Äußere Ecke. Sie müssen den Rand der inneren Ecke auswählen",
      "这是外角。 您必须选择内角的边缘",
      "Es una esquina exterior. Debe seleccionar el borde de la esquina interior",  // ES
      "C'est un coin extérieur. Vous devez sélectionner l'arête du coin intérieur",  // FR
      "Bu bir dış köşedir. İç köşenin kenarını seçmelisiniz" };  // TR

    public static readonly string[] InvalidVertexNo = {
      "Incorrect polyline vertex number in the corner processing procedure",
      "Ошибочный номер вершины полилинии в процедуре обработки углов.",
      "Numero di vertice della polilinea errato nella procedura di elaborazione degli angoli",
      "Falsche Scheitelpunktnummer der Polylinie im Eckenbearbeitungsverfahren",
      "拐角处理过程中的折线顶点数不正确",
      "Número de vértice de polilínea incorrecto en el procedimiento de procesamiento de esquinas",  // ES
      "Numéro de sommet de polyligne incorrect dans la procédure de traitement des coins",  // FR
      "Köşe işleme prosedüründe yanlış çoklu çizgi köşe numarası" };  // TR

    public static readonly string[] NoPrevSegment = {
      "Corner procedure failed to get the previous polyline segment",
      "Процедура обработки углов не смогла получить предыдущий сегмент полилинии",
      "La procedura d'angolo non è riuscita a ottenere il segmento di polilinea precedente",
      "Falsche Scheitelpunktnummer der Polylinie im Eckenbearbeitungsverfahren",
      "拐角程序未能获取上一个折线段",
      "El procedimiento de esquina no pudo obtener el segmento de polilínea anterior",  // ES
      "La procédure de coin n'a pas pu obtenir le segment de polyligne précédent",  // FR
      "Köşe prosedürü önceki çoklu çizgi segmentini alamadı" };  // TR

    public static readonly string[] BrokenPolyline = {
      "Polyline broken at vertex {0}",
      "Полилиния разорвана у вертекса {0}",
      "Polilinea interrotta al vertice {0}",
      "Polylinie an Scheitelpunkt {0} unterbrochen",
      "折线在顶点 {0} 处断开",
      "Polilínea rota en el vértice {0}",  // ES
      "Polyligne cassée au sommet {0}",  // FR
      "Çoklu çizgi {0} köşesinde koptu" };  // TR

    public static readonly string[] Acute ={
      "The angle is acute! The contour cannot be processed by milling",
      "Угол острый! Контур невозможно обработать фрезерованием",
      "L'angolo è nitido! Contour non può essere lavorato.",
      "Der Winkel ist scharf! Kontur kann nicht bearbeitet werden.",
      "尖角！ 轮廓无法铣削",
      "¡El ángulo es agudo! El contorno no se puede procesar mediante fresado",  // ES
      "L'angle est aigu ! Le contour ne peut pas être traité par fraisage",  // FR
      "Açı keskintir! Kontur frezeleme ile işlenemez"};  // TR

    public static readonly string[] Corner180 ={
      "The angle formed by the segments need not be equal to 180",
      "Угол образованный сегментами не должен быть равен 180",
      "L'angolo formato dai segmenti non deve essere uguale a 180",
      "Der von den Segmenten gebildete Winkel sollte nicht gleich 180 sein",
      "线段形成的角度不得等于 180",
      "El ángulo formado por los segmentos no debe ser igual a 180",  // ES
      "L'angle formé par les segments ne doit pas être égal à 180",  // FR
      "Segmentlerin oluşturduğu açı 180'e eşit olmamalıdır"};  // TR

    public static readonly string[] SegmentTooShort = {
      "The segment are too short for cutting corner. Skip.",
      "Сегмент слишком короткий для вырезания угла. Пропускаем.",
      "Segmento troppo corto per tagliare un angolo. Salta.",
      "Segment zu kurz, um eine Ecke zu schneiden. Überspringen Sie es.",
      "该段太短而不能切角。 我们跳过。",
      "El segmento es demasiado corto para cortar la esquina. Omitir.",  // ES
      "Le segment est trop court pour couper le coin. Passer.",  // FR
      "Segment köşe kesmek için çok kısa. Atla." };  // TR

    public static readonly string[] ICResult = {
      "{0} corners have been cut.",
      "Сделано {0} заходов в угол.",
      "Effettuate {0} chiamate d'angolo.",
      "{0} Eckenrufe gemacht.",
      "对角落进行了 {0} 次访问。",
      "Se han cortado {0} esquinas.",  // ES
      "{0} coins ont été coupés.",  // FR
      "{0} köşe kesildi." };  // TR

    public static readonly string[] NotIntersect = {
      "Cutter arc not intersect segment.",
      "Не найдено пересечение дуги фрезы с сегментом.",
      "Non è stata trovata l'intersezione dell'arco con un segmento.",
      "Der Schnittpunkt des Bogenschneiders mit einem Segment wurde nicht gefunden.",
      "未找到刀具弧与线段的交点。",
      "El arco de la fresa no interseca el segmento.",  // ES
      "L'arc de la fraise n'intersecte pas le segment.",  // FR
      "Kesici yay segment ile kesişmiyor." };  // TR

    public static readonly string[] ICLoop = {
      "The external corner program is stuck in a loop - processing corners creates new corners.",
      "Программа внешний угол зациклилась - обработка углов создает новые углы.",
      "Il programma degli angoli esterni è in loop: la lavorazione degli angoli crea nuovi angoli.",
      "Das Außeneckenprogramm befindet sich in einer Schleife – durch die Bearbeitung von Ecken entstehen neue Ecken.",
      "外角程序处于循环状态 - 处理角点会创建新的角点。",
      "El programa de esquina externa está atascado en un bucle: el procesamiento de esquinas crea nuevas esquinas.",  // ES
      "Le programme de coin externe est bloqué dans une boucle - le traitement des coins crée de nouveaux coins.",  // FR
      "Dış köşe programı bir döngüde takılı kaldı - köşeleri işlemek yeni köşeler oluşturur." };  // TR

    public static readonly string[] CutFailed = {
      "Corner processing failed.",
      "Процедура обработки углов не удалась.",
      "Elaborazione dell'angolo non riuscita.",
      "Eckenverarbeitung fehlgeschlagen.",
      "边角处理失败",
      "Falló el procesamiento de esquinas.",  // ES
      "Échec du traitement des coins.",  // FR
      "Köşe işleme başarısız oldu." };  // TR

    public static readonly string[] CutFailedReason = {
      "Corner processing failed. Reason: {0}",
      "Процедура обработки углов не удалась. Причина: {0}",
      "Elaborazione dell'angolo non riuscita. Motivo: {0}",
      "Eckenverarbeitung fehlgeschlagen. Grund: {0}",
      "边角处理失败。 原因：{0}",
      "Falló el procesamiento de esquinas. Razón: {0}",  // ES
      "Échec du traitement des coins. Raison : {0}",  // FR
      "Köşe işleme başarısız oldu. Neden: {0}" };  // TR

    public static readonly string[] OutsideQuery = {
      "Is this outside contour?",
      "Это наружный контур?",
      "È un contorno esterno?",
      "Ist es eine äußere Kontur?",
      "这是外轮廓吗？",
      "¿Es este un contorno exterior?",  // ES
      "Est-ce un contour extérieur ?",  // FR
      "Bu dış kontur mu?" };  // TR

    public static readonly string[] CarveCorners = {
      "Carve corners",
      "Обработка углов",
      "Elaborazione angolare",
      "Eckenbearbeitung",
      "雕刻角落",
      "Tallar esquinas",  // ES
      "Sculpter les coins",  // FR
      "Köşeleri oyma" };  // TR

    public static readonly string[] FilletResult = {
      "  {0} corners have been fillet. {1} no need to fillet. {2} errors.",
      "  Сделано {0} скруглений. Не нужно скруглять {1}. Ошибок {2}.",
      "  Fatto {0} raccordo. Non c'è bisogno di arrotondare {1}. Errori {2}.",
      "  {0} Abrunden gemacht. {1} muss nicht abgerundet werden. Fehler {2}.",
      "  {0} 个角已被圆角化。 {1} 无需圆角。 {2} 个错误。",
      "  {0} esquinas han sido redondeadas. {1} no necesita redondeo. {2} errores.",  // ES
      "  {0} coins ont été arrondis. {1} pas besoin d'arrondir. {2} erreurs.",  // FR
      "  {0} köşe yuvarlatıldı. {1} yuvarlama gerekmez. {2} hata." };  // TR

    public static readonly string[] DiamTooSmallErr = {
      "Cutter diameter is too small",
      "Слишком маленький диаметр фрезы",
      "Diametro dell'utensile troppo piccolo",
      "Fräserdurchmesser zu klein",
      "刀具直径太小",
      "El diámetro de la fresa es demasiado pequeño",  // ES
      "Le diamètre de la fraise est trop petit",  // FR
      "Kesici çapı çok küçük" };  // TR

    public static readonly string[] NoCommonPoint = {
      "Segments have no common point",
      "Сегменты не имеют общей точки",
      "I segmenti non hanno un punto in comune",
      "Segmente haben keinen gemeinsamen Punkt",
      "段没有共同点",
      "Los segmentos no tienen un punto común",  // ES
      "Les segments n'ont pas de point commun",  // FR
      "Segmentlerin ortak bir noktası yok" };  // TR

    public static readonly string[] FilletStraight = {
      "Impossible to build a fillet because the angle straight (180 degrees)",
      "Невозможно построить скругление, потому что угол развернутый (180 градусов)",
      "È impossibile costruire un percorso, perché l'angolo è diritto (180 gradi)",
      "Es ist unmöglich eine Abrunden zu bauen, da der Winkel entfaltet ist (180 Grad).",
      "无法构建圆角，因为角已旋转（180 度）",
      "Imposible construir un redondeo porque el ángulo es recto (180 grados)",  // ES
      "Impossible de construire un congé car l'angle est droit (180 degrés)",  // FR
      "Yuvarlatma oluşturulamıyor çünkü açı düz (180 derece)" };  // TR

    public static readonly string[] StraightSkip = {
      "The angle formed by the segments almost straight ({0}). Skip.",
      "Угол образованный сегментами почти развернутый ({0}). Пропускаем.",
      "L'angolo formato dai segmenti è quasi diritto ({0}). Salta.",
      "Der von den Segmenten gebildete Winkel ist nahezu entfaltet ({0}). Überspringen Sie es.",
      "由线段形成的角几乎是转弯 ({0})。 我们跳过。",
      "El ángulo formado por los segmentos es casi recto ({0}). Omitir.",  // ES
      "L'angle formé par les segments est presque droit ({0}). Passer.",  // FR
      "Segmentlerin oluşturduğu açı neredeyse düz ({0}). Atla." };  // TR

    public static readonly string[] SegmentErr = {
      "Segment does not belong to polyline",
      "Сегмент не принадлежит полилинии",
      "Il segmento non appartiene alla polilinea",
      "Segment gehört nicht zur Polylinie",
      "段不属于折线",
      "El segmento no pertenece a la polilínea",  // ES
      "Le segment n'appartient pas à la polyligne",  // FR
      "Segment çoklu çizgiye ait değil" };  // TR

    public static readonly string[] FilletImpossible = {
      "Impossible to build a fillet",
      "Невозможно построить скругление",
      "Impossibile creare arrotondamenti",
      "Abrunden nicht möglich",
      "无法创建回合",
      "Imposible construir un redondeo",  // ES
      "Impossible de construire un congé",  // FR
      "Yuvarlatma oluşturulamıyor" };  // TR

    public static readonly string[] NonClosed = {
      "On an non-closed polyline, the program will fillet all corners on both sides.",
      "На незамкнутой полилинии программа будет делать скругления всех углов с обоих сторон.",
      "Su una polilinea non chiusa, il programma raccorderà tutti gli angoli su entrambi i lati.",
      "Bei einer nicht geschlossenen Polylinie rundet das Programm alle Ecken auf beiden Seiten ab.",
      "在开放的多段线上，程序将圆角两侧的所有角。",
      "En una polilínea no cerrada, el programa redondeará todas las esquinas en ambos lados.",  // ES
      "Sur une polyligne non fermée, le programme arrondira tous les coins des deux côtés.",  // FR
      "Kapalı olmayan bir çoklu çizgide, program her iki taraftaki tüm köşeleri yuvarlatacaktır." };  // TR

    public static readonly string[] SelectDiam = {
      "Select object (D={0}) ",
      "Выберите объект (D={0}) ",
      "Seleziona l'oggetto (D={0}) ",
      "Wählen Sie ein Objekt aus (D={0}) ",
      "选择对象 (D={0})",
      "Seleccione objeto (D={0}) ",  // ES
      "Sélectionnez un objet (D={0}) ",  // FR
      "Nesne seçin (D={0}) "};  // TR

    public static readonly string[] SelectDiamSide = {
      "Select object for fillet (D={0}, {1}) ",
      "Выберите объект скругления (D={0}, {1}) ",
      "Seleziona l'oggetto da raccordare (D={0}, {1}) ",
      "Wählen Sie ein Abrundenobjekt aus (D={0}, {1}) ",
      "选择圆角对象（D={0}、{1}）",
      "Seleccione objeto para redondear (D={0}, {1}) ",  // ES
      "Sélectionnez un objet pour arrondir (D={0}, {1}) ",  // FR
      "Yuvarlatma için nesne seçin (D={0}, {1}) "};  // TR

    public static readonly string[] SelectSegment = {
      "Select second polyline segment",
      "Выберете второй сегмент полилинии",
      "Seleziona il secondo segmento di polilinea",
      "Wählen Sie das zweite Polyliniensegment aus",
      "选择第二条折线段",
      "Seleccione el segundo segmento de polilínea",  // ES
      "Sélectionnez le deuxième segment de polyligne",  // FR
      "İkinci çoklu çizgi segmentini seçin" };  // TR

    public static readonly string[] SelectPolyline = {
      "Select closed polyline or polyline segment. Use CTRL or 'subselectON'",
      "Выберите замкнутую полилинию или 1 сегмент полилинии. Для выбора используйте CTRL или включите режим 'частиВКЛ'",
      "Seleziona una polilinea chiusa o 1 segmento polilinea. Usa CTRL o seleziona la modalità 'subselectACCESO' per la selezione.",
      "Wählen Sie eine geschlossene Polylinie oder ein Polyliniensegment aus. " +
        "Verwenden Sie STRG oder wählen Sie den Modus 'UnterauswahlAN' zur Auswahl.",
      "选择闭合的多段线或 1 个多段线段。 使用 CTRL 选择或打开'部件开启'模式",
      "Seleccione polilínea cerrada o segmento de polilínea. Use CTRL o 'subselecciónACTIVADA'",  // ES
      "Sélectionnez une polyligne fermée ou un segment de polyligne. Utilisez CTRL ou 'soussélectionACTIVÉE'",  // FR
      "Kapalı çoklu çizgi veya çoklu çizgi segmenti seçin. CTRL veya 'altseçimAÇIK' kullanın"};  // TR

    public static readonly string[] IncorrectSegment = {
      "Incorrect selection of polyline segments",
      "Некорректный выбор сегментов полилинии",
      "Selezione non valida dei segmenti di polilinea",
      "Ungültige Auswahl von Polyliniensegmenten",
      "折线段选择不正确",
      "Selección incorrecta de segmentos de polilínea",  // ES
      "Sélection incorrecte de segments de polyligne",  // FR
      "Çoklu çizgi segmentlerinin yanlış seçimi"};  // TR

    public static readonly string[] Need2 = {
      "Need 2 segments with a common point.",
      "Нужны 2 сегмента с обшей точкой.",
      "Alla ricerca di 2 segmenti con un punto comune.",
      "Suche nach 2 Segmenten mit einem gemeinsamen Punkt.",
      "我们需要 2 个具有共同点的线段。",
      "Se necesitan 2 segmentos con un punto común.",  // ES
      "Besoin de 2 segments avec un point commun.",  // FR
      "Ortak noktaya sahip 2 segment gereklidir." };  // TR

    public static readonly string[] SegmentTwiceErr = {
      "Selected the same segment twice",
      "Был выбран один и тот же сегмент",
      "Lo stesso segmento è stato selezionato.",
      "Das gleiche Segment wurde ausgewählt.",
      "选择了相同的细分",
      "Se seleccionó el mismo segmento dos veces",  // ES
      "Le même segment a été sélectionné deux fois",  // FR
      "Aynı segment iki kez seçildi" };  // TR

    public static readonly string[] SelectLine = {
      "Select second line",
      "Выберете второй отрезок",
      "Scegli il secondo segmento",
      "Wählen Sie das zweite Segment",
      "选择第二段",
      "Seleccione la segunda línea",  // ES
      "Sélectionnez la deuxième ligne",  // FR
      "İkinci çizgiyi seçin" };  // TR

    public static readonly string[] NeedLine ={
      "Select incorrect type of object. Need line or arc.",
      "Был выбран неверный тип объекта. Нужна линия или дуга.",
      "È stato selezionato un tipo di oggetto non valido. Hai bisogno di una linea o arco.",
      "Ein ungültiger Objekttyp wurde ausgewählt. Benötigen Sie eine Linie oder einen Bogen.",
      "选择了错误的对象类型。 需要一条线或弧线。",
      "Tipo de objeto incorrecto seleccionado. Se necesita línea o arco.",  // ES
      "Type d'objet incorrect sélectionné. Besoin d'une ligne ou d'un arc.",  // FR
      "Yanlış nesne türü seçildi. Çizgi veya yay gereklidir." };  // TR

    public static readonly string[] ObjTwiceErr = {
      "Selected the same object twice",
      "Был выбран один и тот же объект",
      "Lo stesso oggetto è stato selezionato.",
      "Das gleiche Objekt wurde ausgewählt.",
      "选择了相同的对象",
      "Se seleccionó el mismo objeto dos veces",  // ES
      "Le même objet a été sélectionné deux fois",  // FR
      "Aynı nesne iki kez seçildi" };  // TR

    public static readonly string[] TooSmallErr ={
      "Incorrect segments\n(too small or not set the plane)",
      "Неподходящие сегменты\n(слишком мелкие или не задают плоскость)",
      "Segmenti non adatti\n(troppo piccoli o non definiscono un piano)",
      "Ungeeignete Segmente\n(zu klein oder definieren keine Ebene)",
      "不适当的段\n（太小或未定义平面）",
      "Segmentos incorrectos\n(demasiado pequeños o no definen un plano)",  // ES
      "Segments incorrects\n(trop petits ou ne définissent pas un plan)",  // FR
      "Yanlış segmentler\n(çok küçük veya düzlem tanımlamıyor)"};  // TR

    public static readonly string[] TypeErr = {
      "Incorrect selection of object type",
      "Команда не работает с таким типом объектов",
      "Il comando non funziona con questo tipo di oggetti." ,
      "Der Befehl funktioniert nicht mit dieser Art von Objekten.",
      "该命令不适用于此类对象",
      "El comando no funciona con este tipo de objetos",  // ES
      "La commande ne fonctionne pas avec ce type d'objets",  // FR
      "Komut bu nesne türüyle çalışmaz" };  // TR

    public static readonly string[] NeedSegment = {
      "Need another segment on the same polyline",
      "Нужен сегмент той же полилинии",
      "Hai bisogno di un segmento della stessa polilinea",
      "Benötigen Sie ein Segment derselben Polylinie",
      "需要一段相同的折线",
      "Se necesita otro segmento en la misma polilínea",  // ES
      "Besoin d'un autre segment sur la même polyligne",  // FR
      "Aynı çoklu çizgide başka bir segment gereklidir" };  // TR


    public static readonly string[] DiamKW =
      { "Diameter", "ДИаметр", "Diametro", "Durchmesser", "直径(D)",
        "Diámetro", "Diamètre", "Çap" }; // ES, FR, TR  // selection option!!
    public static readonly string[] SubOnKW =
      { "subselectON", "частиВКЛ", "subselectACCESO", "UnterauswahlAN", "子选择开(ON)",
        "subselecciónACTIVADA", "soussélectionACTIVÉE", "altseçimAÇIK" }; // ES, FR, TR  // selection option!!
    public static readonly string[] SubOffKW =
      { "subselectOFF", "частиВЫК", "subselectSPENTO", "UnterauswahlAUS", "子选择关闭(OFF)",
        "subselecciónDESACTIVADA", "soussélectionDÉSACTIVÉE", "altseçimKAPALI" }; // ES, FR, TR  // selection option!!
    public static readonly string[] MillSideKW =
      { "MIllSide", "СТоронаФрезы", "FReseLaterali", "SEitenschneider", "侧切刀(MI)",
        "LAdomolino", "CÔtéfraise", "FRezekenarı" }; // ES, FR, TR  // selection option!!
    public static readonly string[] BothSideKW =
      { "BOthSide", "ВСеУглы", "ENtrambiILati", "BEideSeiten", "从四面八方(BO)",
        "AMboslados", "LEsdeuxcôtés", "HErikikenar" }; // ES, FR, TR  // selection option!!


    // не добавлять стандартные ключевые слова 
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

  }
}