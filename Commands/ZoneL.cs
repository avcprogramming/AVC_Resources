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
    public static readonly string[]
    UnionProcess = {
      "Consolidation of zones",
      "Объединение зон",
      "Consolidamento delle zone",
      "Konsolidierung von Zonen",
      "区域整合"};
    public static readonly string[]
    ConnectProcess = {
      "Building closed polylines",
      "Построение замкнутых полилиний",
      "Costruire polilinee chiuse",
      "Erstellen geschlossener Polylinien",
      "构建闭合折线"};
    public static readonly string[]
    OffsetErr = {
      "Failed to offset",
      "Не удалось сделать офсет",
      "Impossibile compensare",
      "Der Ausgleich ist fehlgeschlagen",
      "抵消失败" };
    public static readonly string[]
    ArcErr = {
      "Failed to construct arc of radius {0}",
      "Не удалось построить дугу радиуса {0}",
      "Impossibile costruire l'arco di raggio {0}",
      "Der Bogen mit dem Radius {0} konnte nicht erstellt werden.",
      "无法构造半径为 {0} 的圆弧" };
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
    ExplodeErr = {
      "Failed to explode the region on the lines. Error {0}",
      "Не удалось взорвать регион на линии. Ошибка {0}",
      "Impossibile far saltare in aria la regione sulla linea. Errore {0}",
      "Der Bereich auf der Leitung konnte nicht gesprengt werden. Fehler {0}",
      "未能炸毁线上区域。 错误{0}" };

    //============================ ZoneOptionsBox ==============================================

    public static readonly string[] StyleNameTip = {
      "The name for this zone-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля зоны. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile zone (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Zone-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此区域样式（设置集）的名称。 程序中没有使用。 只为方便选择。"};
    public static readonly string[] Distance = {
      "Distance",
      "Дистанция",
      "Distanza",
      "Distanz",
      "距离" };
    public static readonly string[] DistanceTip = {
      "Distance from the original curve to the zone boundary. The program will indent (offset) in both directions at this distance.",
      "Расстояние от исходной кривой до границы зоны. На это расстояние программа сделает отступ (офсет) в обе стороны.",
      "Distanza dalla curva originale al confine della zona. A questa distanza il programma rientrerà (offset) in entrambe le direzioni.",
      "Abstand von der Originalkurve zur Zonengrenze. Das Programm wird in diesem Abstand in beide Richtungen einrücken (versetzen).",
      "原始曲线到区域边界的距离。 程序将按此距离在两个方向上缩进（偏移）。" };
    public static readonly string[] DistanceQuery = {
      "Request distance",
      "Запрашивать дистанцию",
      "Richiedi distanza",
      "Abstand anfordern",
      "请求距离" };
    public static readonly string[] DistanceQueryTip = {
      "Request distance on every command call. \r\n" +
        "If the request is disabled, the distance value from this style will be used.",
      "Запрашивать дистанцию на каждом вызове команды. \r\n" +
        "Если запрос отключен, то будет использовано значение дистанции из этого стиля.",
      "Richiedi la distanza ad ogni chiamata di comando. \r\n" +
        "Se la richiesta è disabilitata, verrà utilizzato il valore della distanza da questo stile.",
      "Fordern Sie bei jedem Befehlsaufruf die Entfernung an.\r\n" +
        "Wenn die Anforderung deaktiviert ist, wird der Abstandswert dieses Stils verwendet.",
      "每次命令调用时请求距离。 如果请求被禁用，则将使用此样式的距离值。" };
    public static readonly string[] ZoneEnds = {
      "At the ends of the zone",
      "На концах зоны",
      "Alle estremità della zona",
      "An den Enden der Zone",
      "在区域的两端" };
    public static readonly string[] LineEndsTip = {
      "Connect the ends of two offset curves in a straight line. This setting is not used on closed curves.",
      "Соединить концы двух смещенных кривых по прямой. Эта настройка не используется на замкнутых кривых.",
      "Collega le estremità di due curve offset in una linea retta. Questa impostazione non viene utilizzata su curve chiuse.",
      "Verbinden Sie die Enden zweier versetzter Kurven in einer geraden Linie. \r\n" +
        "Diese Einstellung wird nicht für geschlossene Kurven verwendet.",
      "将两条偏移曲线的端点连接成一条直线。 此设置不适用于闭合曲线。" };
    public static readonly string[] ArcEndsTip = {
      "Connect the ends of two offset curves with arcs. This setting is not used on closed curves.",
      "Соединить концы двух смещенных кривых дугами. Эта настройка не используется на замкнутых кривых.",
      "Collegare le estremità di due curve offset con archi. Questa impostazione non viene utilizzata su curve chiuse.",
      "Verbinden Sie die Enden zweier versetzter Kurven mit Bögen. \r\n" +
        "Diese Einstellung wird nicht für geschlossene Kurven verwendet.",
      "用圆弧连接两条偏移曲线的末端。 此设置不适用于闭合曲线。" };
    public static readonly string[] LayerTip = {
      "Assign a layer to a new curve. " +
        "If the layer is not in the drawing, it will be created. " +
        "Leave the field blank to use the default layer.",
      "Назначить слой новой кривой. " +
        "Если слоя нет в чертеже - он будет создан. " +
        "Оставьте поле пустым, чтоб использовать слой по-умолчанию.",
      "Assegna un livello a una nuova curva. " +
        "Se il layer non è nel disegno, verrà creato. " +
        "Lascia il campo vuoto per utilizzare il livello predefinito.",
      "Weisen Sie einer neuen Kurve eine Ebene zu. " +
        "Wenn der Layer nicht in der Zeichnung vorhanden ist, wird er erstellt. " +
        "Lassen Sie das Feld leer, um die Standardebene zu verwenden.",
      "将图层分配给新曲线。 " +
        "如果该图层不在绘图中，则会创建该图层。 " +
        "将该字段留空以使用默认图层。" };
    public static readonly string[] CreateRegion = {
      "Create a Region",
      "Создать регион",
      "Crea una regione",
      "Erstellen Sie eine Region",
      "创建区域 (Region)" };
    public static readonly string[] CreateRegionTip = {
      "Create a zone as a Region object rather than a polyline or spline",
      "Создать зону в виде объекта типа Region, а не полилинию или сплайн",
      "Crea una zona come oggetto Regione anziché come polilinea o spline",
      "Erstellen Sie eine Zone als Regionsobjekt und nicht als Polylinie oder Spline ",
      "创建区域作为区域对象而不是折线或样条线" };
    public static readonly string[] DeleteSources = {
      "Delete Sources",
      "Удалить исходные",
      "Elimina fonti",
      "Quellen löschen",
      "删除来源" };
    public static readonly string[] DeleteSourcesTip = {
      "Delete all original lines and curves around which it was possible to construct a zone",
      "Удалить все исходные линии и кривые, вокруг которых удалось построить зону",
      "Elimina tutte le linee e curve originali attorno alle quali era possibile costruire una zona",
      "Löschen Sie alle ursprünglichen Linien und Kurven, um die herum eine Zone konstruiert werden konnte",
      "删除所有可以围绕其构建区域的原始直线和曲线" };

  }
}
