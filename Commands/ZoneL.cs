// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class
  ZoneL
  {
    public static readonly string[,] ZoneStyleNames = {
/* 0 */ {
        CommandL.Zone[0],
        CommandL.Zone[1],
        CommandL.Zone[2],
        CommandL.Zone[3],
        CommandL.Zone[4] },
/* 1 */ {
        CommandL.Zone[0],
        CommandL.Zone[1],
        CommandL.Zone[2],
        CommandL.Zone[3],
        CommandL.Zone[4]},
/* 2 */ {
        "Arcs at the ends",
        "Дуги на концах",
        "Archi alle estremità",
        "Bögen an den Enden",
        "末端有弧线" },
/* 3 */ {
        "One-sided zone",
        "Односторонняя зона",
        "Zona a senso unico",
        "Einbahnzone",
        "單向區域" },
    };

    public static readonly string[]
    Select = {
      "Select the polylines around which you want to create a zone",
      "Выберите полилинии вокруг которых надо создать зону",
      "Selezionare le polilinee attorno alle quali si desidera creare una zona",
      "Wählen Sie die Polylinien aus, um die Sie eine Zone erstellen möchten",
      "选择要围绕其创建区域的折线"};
    public static readonly string[]
    Process = {
      "Creating zones",
      "Создание зон",
      "Creazione di zone",
      "Zonen erstellen",
      "创建区域"};
    //public static readonly string[]
    //ArcErr = {
    //  "Failed to construct arc of radius {0}",
    //  "Не удалось построить дугу радиуса {0}",
    //  "Impossibile costruire l'arco di raggio {0}",
    //  "Der Bogen mit dem Radius {0} konnte nicht erstellt werden.",
    //  "无法构造半径为 {0} 的圆弧" };
    public static readonly string[]
    NoZoneCreated = {
      "Failed to build any zone",
      "Не удалось построить не одной зоны",
      "Impossibile costruire qualsiasi zona",
      "Es konnte keine Zone erstellt werden",
      "无法建立任何区域" };
    public static readonly string[]
    UnionErr = {
      "Failed to merge zones",
      "Не удалось объединить зоны",
      "Impossibile unire le zone",
      "Zonen konnten nicht zusammengeführt werden",
      "合并区域失败" };
    public static readonly string[]
    StrangeOffsetErr = {
      "Strange offset result",
      "Странный результат офсета",
      "Strano risultato di offset",
      "Seltsames Offset-Ergebnis",
      "奇怪的偏移结果" };
    public static readonly string[]
    ReverseOffset = {
      "Reverse offset",
      "Обратное смещение",
      "Polarizzazione inversa",
      "Umgekehrte Voreingenommenheit",
      "反向偏压"};

    //============================ ZoneOptionsBox ==============================================

    public static readonly string[] StyleNameTip = {
      "The name for this zone-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля зоны. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile zone (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Zone-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此区域样式（设置集）的名称。 程序中没有使用。 只为方便选择。"};
    public static readonly string[] Symmetrical = {
      "Symmetrical zone",
      "Симметричная зона",
      "Zona simmetrica",
      "Symmetrische Zone",
      "对称区" };
    public static readonly string[] SymmetricalTip = {
      "The zone will be created with the same offset from the polyline in both directions",
      "Зона будет создана с одинаковым отступом от полилинии в обе стороны",
      "La zona verrà creata con lo stesso offset dalla polilinea in entrambe le direzioni",
      "Die Zone wird mit dem gleichen Versatz von der Kurve in beide Richtungen erstellt",
      "该区域将在两个方向上以与曲线相同的偏移量创建" };
    public static readonly string[] Offset = {
      "Offset from polyline",
      "Смещение от полилинии",
      "Offset dalla polilinea",
      "Versatz von der Polylinie",
      "距折線的偏移" };
    public static readonly string[] OffsetTip = {
      "Distance from a given curve to the zone boundary. Must be greater than zero. \r\n" +
        "For an asymmetrical zone, this is the distance outward from closed curves \r\n" +
        "and towards the specified point for non-closed ones.",
      "Расстояние от заданной кривой до границы зоны. Должно быть больше ноля. \r\n" +
        "Для несимметричной зоны это расстояние наружу от замкнутых кривых \r\n" +
        "и в сторону указанной точки для незамкнутых.",
      "Distanza da una data curva al confine della zona. Deve essere maggiore di zero. \r\n" +
        "Per una zona asimmetrica, questa è la distanza verso l'esterno dalle curve chiuse \r\n" +
        "e verso il punto specificato per quelle non chiuse.",
      "Abstand von einer bestimmten Kurve zur Zonengrenze. Muss größer als Null sein. \r\n" +
        "Bei einer asymmetrischen Zone ist dies der Abstand von geschlossenen Kurven nach außen \r\n" +
        "und bei nicht geschlossenen Kurven zum angegebenen Punkt hin.",
      "从给定曲线到区域边界的距离。必须大于零。\r\n" +
        "对于非对称区域，这是从闭合曲线向外的距离，对于非闭合曲线，这是到指定点的距离。" };
    public static readonly string[] ReverseOffsetTip = {
      "For asymmetrical zones, this is the distance from the given curve to the edge of the zone \r\n" +
        "in the opposite direction. For closed curves, the indentation is inward. \r\n" +
        "For open curves - in the opposite direction from a given point. \r\n" +
        "You can set 0 and the entire zone will be in one direction. \r\n" +
        "You can even specify a negative number.",
      "У несимметричных зон это расстояние от заданной кривой до края зоны в обратную сторону. \r\n" +
        "У замкнутых кривых - отступ внутрь. \r\n" +
        "У незамкнутых кривых - в обратном направлению от заданной точки. \r\n" +
        "Можно задать 0 и вся зона будет в одну сторону. Можно задать даже отрицательное число.",
      "Per le zone asimmetriche, questa è la distanza dalla curva data al bordo della zona nella direzione opposta. \r\n" +
        "Per le curve chiuse, il rientro è verso l'interno. \r\n" +
        "Per curve aperte - nella direzione opposta da un dato punto. \r\n" +
        "È possibile impostare 0 e l'intera zona sarà in una direzione. \r\n" +
        "Puoi anche specificare un numero negativo.",
      "Bei asymmetrischen Zonen ist dies der Abstand von der gegebenen Kurve \r\n" +
        "zum Rand der Zone in der entgegengesetzten Richtung. \r\n" +
        "Bei geschlossenen Kurven erfolgt die Einkerbung nach innen. \r\n" +
        "Für offene Kurven – in die entgegengesetzte Richtung von einem bestimmten Punkt. \r\n" +
        "Sie können 0 einstellen und die gesamte Zone verläuft in eine Richtung. \r\n" +
        "Sie können sogar eine negative Zahl angeben.",
      "对于非对称区域，这是从给定曲线到相反方向的区域边缘的距离。\r\n" +
        "对于闭合曲线，缩进是向内的。\r\n" +
        "对于开放曲线 - 与给定点相反的方向。您可以设置 0，整个区域将朝一个方向。\r\n" +
        "您甚至可以指定一个负数。" };
    public static readonly string[] OffsetQuery = {
      "Prompt for offset",
      "Запрашивать смещение",
      "Richiedi compensazione",
      "Offset anfordern",
      "请求偏移量" };
    public static readonly string[] OffsetQueryTip = {
      "Prompt for offset on every command call. \r\n" +
        "If the request is disabled, the indent value from this style will be used.",
      "Запрашивать смещение на каждом вызове команды. \r\n" +
        "Если запрос отключен, то будет использовано значение отступа из этого стиля.",
      "Richiedi l'offset a ogni chiamata di comando. \r\n" +
        "Se la richiesta è disabilitata, verrà utilizzato il valore del rientro di questo stile.",
      "Bei jedem Befehlsaufruf nach dem Offset fragen. \r\n" +
        "Wenn die Anfrage deaktiviert ist, wird der Einzugswert dieses Stils verwendet.",
      "每次命令调用时提示偏移量。\r\n" +
        "如果请求被禁用，则将使用此样式的缩进值。" };
    public static readonly string[] ReverseOffsetQuery = {
      "Prompt for reverse offset",
      "Запрашивать обратное смещение",
      "Richiedere l'offset inverso",
      "Rückwärts-Offset anfordern",
      "請求反向偏移" };
    public static readonly string[] ReverseOffsetQueryTip = {
      "Prompt for reverse offset on every command call. \r\n" +
        "If the request is disabled, the backspace value from this style will be used.",
      "Запрашивать обратный отступ на каждом вызове команды. \r\n" +
        "Если запрос отключен, то будет использовано значение обратного отступа из этого стиля.",
      "Richiedi l'offset inverso ad ogni chiamata di comando. \r\n" +
        "Se la richiesta è disabilitata, verrà utilizzato il valore backspace di questo stile.",
      "Bei jedem Befehlsaufruf wird nach dem umgekehrten Offset gefragt. \r\n" +
        "Wenn die Anforderung deaktiviert ist, wird der Backspace-Wert aus diesem Stil verwendet.",
      "每次命令呼叫時提示反向偏移。\r\n" +
        "如果請求被停用，則將使用此樣式的退格值。" };
    public static readonly string[] ZoneEnds = {
      "At the ends of the zone",
      "На концах зоны",
      "Alle estremità della zona",
      "An den Enden der Zone",
      "在区域的两端" };
    public static readonly string[] LineEndsTip = {
      "Connect the ends of two offset curves in a straight line. \r\n" +
        "This setting is not used on closed curves.",
      "Соединить концы двух смещенных кривых по прямой. \r\n" +
        "Эта настройка не используется на замкнутых кривых.",
      "Collega le estremità di due curve offset in una linea retta. \r\n" +
        "Questa impostazione non viene utilizzata su curve chiuse.",
      "Verbinden Sie die Enden zweier versetzter Kurven in einer geraden Linie. \r\n" +
        "Diese Einstellung wird nicht für geschlossene Kurven verwendet.",
      "将两条偏移曲线的端点连接成一条直线。 此设置不适用于闭合曲线。" };
    public static readonly string[] ArcEndsTip = {
      "Connect the ends of two offset curves with arcs. This setting is not used on closed curves.",
      "Соединить концы двух смещенных кривых дугами. Эта настройка не используется на замкнутых кривых.",
      "Collegare le estremità di due curve offset con archi. \r\n" +
        "Questa impostazione non viene utilizzata su curve chiuse.",
      "Verbinden Sie die Enden zweier versetzter Kurven mit Bögen. \r\n" +
        "Diese Einstellung wird nicht für geschlossene Kurven verwendet.",
      "用圆弧连接两条偏移曲线的末端。 此设置不适用于闭合曲线。" };
    public static readonly string[] LayerTip = {
      "Assign a layer to a new curve. \r\n" +
        "If the layer is not in the drawing, it will be created. \r\n" +
        "Leave the field blank to use the default layer.",
      "Назначить слой новой кривой. \r\n" +
        "Если слоя нет в чертеже - он будет создан. \r\n" +
        "Оставьте поле пустым, чтоб использовать слой по умолчанию.",
      "Assegna un livello a una nuova curva. \r\n" +
        "Se il layer non è nel disegno, verrà creato. \r\n" +
        "Lascia il campo vuoto per utilizzare il livello predefinito.",
      "Weisen Sie einer neuen Kurve eine Ebene zu. \r\n" +
        "Wenn der Layer nicht in der Zeichnung vorhanden ist, wird er erstellt. \r\n" +
        "Lassen Sie das Feld leer, um die Standardebene zu verwenden.",
      "将图层分配给新曲线。 \r\n" +
        "如果该图层不在绘图中，则会创建该图层。 \r\n" +
        "将该字段留空以使用默认图层。" };
    public static readonly string[] CreateRegionTip = {
      "Create a zone as a Region object rather than a polyline or spline",
      "Создать зону в виде объекта типа Region, а не полилинию или сплайн",
      "Crea una zona come oggetto Regione anziché come polilinea o spline",
      "Erstellen Sie eine Zone als Regionsobjekt und nicht als Polylinie oder Spline ",
      "创建区域作为区域对象而不是折线或样条线" };
    public static readonly string[] DeleteSourcesTip = {
      "Delete all original lines and curves around which it was possible to construct a zone",
      "Удалить все исходные линии и кривые, вокруг которых удалось построить зону",
      "Elimina tutte le linee e curve originali attorno alle quali era possibile costruire una zona",
      "Löschen Sie alle ursprünglichen Linien und Kurven, um die herum eine Zone konstruiert werden konnte",
      "删除所有可以围绕其构建区域的原始直线和曲线" };

  }
}
