// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  OffsetL
  {
    public static readonly string[] Offset = {
      "Offset",
      "Смещение",
      "Offset",
      "Offset",
      "抵消" };

    public static readonly string[,] OffsetStyleNames = {
/* 0 */{ Offset[0], Offset[1], Offset[2], Offset[3], Offset[4] },
/* 1 */{ Offset[0], Offset[1], Offset[2], Offset[3], Offset[4] },
/* 2 */{ "Ribbon", "Лента", "Nastro", "Band", "丝带" },
      };

    public static readonly string[] Select = {
      "Select curves for Offset",
      "Выберите кривые для смещения",
      "Seleziona le curve",
      "Wählen Sie Kurven zum Versetzen",
      "选择要偏移的曲线"};
    public static readonly string[] DistStr = {
      "Enter offset distance",
      "Укажите дистанцию офсета",
      "Inserisci la distanza di offset",
      "Versatzabstand eingeben",
      "输入偏移距离"};
    public static readonly string[] PointStr = {
      "Click on a point in the desired direction",
      "Кликните по точке в нужном направлении",
      "Fare clic su un punto nella direzione desiderata",
      "Klicken Sie auf einen Punkt in die gewünschte Richtung",
      "单击所需方向的一个点"};

    // опции запроса выбора
    public static readonly string[] DistanceKW = {
      "Distance",
      "ДИстанция",
      "DIstanza",
      "ENntfernung",
      "距离(D)" };
    public static readonly string[] InsideKW = {
      "INSIDE",
      "ВНутрь",
      "DEntro",
      "INnerhalb",
      "里面(INSIDE)" };
    public static readonly string[] OutsideKW = {
      "OUtside",
      "НАружу",
      "FUori",
      "Draußen",
      "外部(OU)" };
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

    public static readonly string[] 
      Processed = {
      "Processed objects: {0}",
      "Обработано объектов: {0}",
      "Oggetti elaborati: {0}",
      "Verarbeitete Objekte: {0}",
      "已处理的对象：{0}"};
    public static readonly string[] 
      Errors = {
      "Errors: {0}",
      "Ошибок: {0}",
      "Errori: {0}",
      "Fehler: {0}",
      "错误：{0}" };
    public static readonly string[] 
      Search = {
      "Search for matching properties",
      "Поиск подходящих объектов",
      "Cerca proprietà corrispondenti",
      "Suche nach geeigneten Objekten",
      "寻找合适的对象"};

    //======================= Dialog Box =============================================================


    public static readonly string[] 
      DelSourceText = {
      "Delete Sources",
      "Удалить исходные",
      "Elimina fonte",
      "Quellen löschen",
      "删除来源" };
    public static readonly string[] 
      DelSourceTip = {
      "At the end of the command, all successfully processed source curves will be deleted.\r\n" +
        "If the offset failed, then the deletion will not be done.",
      "В конце работы команды все удачно обработанные исходные кривые будут удалены. \r\n" +
        "Если офсет не удался, то и удаление не будет сделано.",
      "Alla fine del comando, tutte le curve di origine elaborate correttamente verranno eliminate.\r\n" +
        "Se l'offset non è riuscito, la cancellazione non verrà eseguita.",
      "Am Ende des Befehls werden alle erfolgreich verarbeiteten Quellkurven gelöscht.\r\n" +
         "Wenn der Offset fehlgeschlagen ist, wird die Löschung nicht durchgeführt.",
      "在命令结束时，所有成功处理的源曲线将被删除。\r\n" +
         "如果偏移失败，则删除不会完成。" };
    public static readonly string[] 
      DistanceQueryText = {
      "Distance Query",
      "Запрос дистанции",
      "Richiesta di distanza",
      "Entfernungsabfrage",
      "距离查询" };
    public static readonly string[] 
      DistanceQueryTip = {
      "Display offset distance request before selecting objects.\r\n" +
        "If you disable this option, the command will use the distance from the current style.",
      "Выводить запрос дистанции офсета перед выбором объектов.\r\n" +
        "Если выключить эту опцию, то команда будет использовать дистанцию из текущего стиля.",
      "Visualizza la richiesta della distanza di offset prima di selezionare gli oggetti. \r\n" +
        "Se disabiliti questa opzione, il comando utilizzerà la distanza dallo stile corrente.",
      "Abstandsanforderung anzeigen, bevor Objekte ausgewählt werden.\r\n" +
         "Wenn Sie diese Option deaktivieren, verwendet der Befehl den Abstand vom aktuellen Stil.",
      "选择对象前显示偏移距离请求。\r\n" +
         "如果禁用此选项，该命令将使用距当前样式的距离。" };
    public static readonly string[] 
      NCLayerText = {
      "By NC Layer",
      "По NC-слою",
      "Per NC layer",
      "Durch NC-Layer",
      "按 NC 层" };
    public static readonly string[] 
      NCLayerTip = {
      "The program will take into account the NC layers assigned by the OSL and NCP commands. \r\n" +
        "Inside contours (dadoes, windows, holes) will be offset in the opposite direction.",
      "Программа будет учитывать NC-слои, назначенные командами OSL и NCP. \r\n" +
        "Внутренние контуры (выборки, окна, отверстия) будут офсетиться в обратном направлении",
      "Il programma terrà conto dei layer NC assegnati dai comandi OSL e NCP. \r\n" +
        "I contorni interni (dado, finestre, fori) saranno sfalsati nella direzione opposta.",
      "Das Programm berücksichtigt die von den OSL- und NCP-Befehlen zugewiesenen NC-Layer.\r\n"+
         "Innenkonturen (Dados, Fenster, Löcher) werden in die entgegengesetzte Richtung versetzt.",
      "该程序将考虑由 OSL 和 NCP 命令分配的 NC 层。 \r\n" +
         "内部轮廓（墙裙、窗户、洞）将向相反方向偏移。" };
    public static readonly string[] 
      NotAnnotationsText = {
      "Not Annotations",
      "Кроме аннотаций",
      "Oltre alle annotazioni",
      "Nicht Anmerkungen",
      "不是注解" };
    public static readonly string[] 
      NotAnnotationsTip = {
      "Ignore curves in the Annotations layer.",
      "Игнорировать кривые слоя Аннотации.",
      "Ignora le curve nel livello Annotazioni.	",
      "Ignorieren Sie Kurven in der Anmerkungsebene.",
      "忽略注释层中的曲线。" };
    public static readonly string[] 
      OpenedText = {
      "Open Curves",
      "Разомкнутые",
      "Сurve aperte",
      "Offene Kurven",
      "打开曲线" };
    public static readonly string[] 
      OpenedTip = {
      "Offset open curves. \r\n" +
        "Typically, a command only works with closed curves, while open ones are ignored.\r\n" +
        "For open curves you need to specify the point in the direction of which offset will be done.",
      "Делать офсет разомкнутых кривых. \r\n" +
        "Обычно команда работает только с замкнутыми кривыми, а разомкнутые игнорируются.\r\n" +
        "Для офсета разомкнутых кривых вам понадобиться указать точку,\r\n" +
        "в направлении которой будет делаться офсет.",
      "Offset curve aperte. \r\n" +
        "In genere, un comando funziona solo con curve chiuse, mentre quelle aperte vengono ignorate.\r\n" +
        "Per le curve aperte è necessario specificare il punto nella direzione in cui verrà eseguito l'offset.",
      "Offene Kurven versetzen. "+
         "Normalerweise funktioniert ein Befehl nur mit geschlossenen Kurven, während offene ignoriert werden.\r\n" +
         "Für offene Kurven müssen Sie den Punkt angeben, in dessen Richtung die Verschiebung erfolgen soll.",
      "偏移开放曲线。\r\n" +
         "通常，命令仅适用于闭合曲线，而忽略开放曲线。\r\n" +
         "对于开放曲线，您需要指定偏移方向的点。" };
    public static readonly string[] 
      SelectErrorsText = {
      "Select Errors",
      "Выбрать ошибки",
      "Scegli errato",
      "Wählen Sie Fehler aus",
      "选择错误" };
    public static readonly string[] 
      SelectErrorsTip = {
      "After the work of the command, \r\n" +
        "all the curves that caused the offset errors will remain selected and highlighted.",
      "После работы команды все кривые, \r\n" +
        "которые вызвали ошибки офсета останутся выбранными и подсвеченными.",
      "Dopo il lavoro, tutte le curve che hanno causato gli errori di offset \r\n" +
        "rimarranno selezionate ed evidenziate.",
      "Nach der Arbeit des Befehls \r\n" +
         "Alle Kurven, die die Offset-Fehler verursacht haben, bleiben ausgewählt und hervorgehoben.",
      "命令生效后，\r\n" +
         "导致偏移错误的所有曲线将保持选中状态并突出显示。" };
    public static readonly string[] 
      SetLayerText = {
      "Set Layer",
      "На слой",
      "Assegna livello",
      "Ebene festlegen",
      "设置图层" };
    public static readonly string[] 
      SetLayerTip = {
      "Assign layer to all offseted curves. \r\n" +
        "If you enter the name of a nonexistent layer, the program will create a new layer.",
      "Присвоить слой всем офсеченым кривым. \r\n" +
        "Если ввести имя несуществующего слоя - программа создаст новый слой.",
      "Assegna il livello a tutte le curve tagliate. \r\n" +
        "Se inserisci il nome di un livello inesistente, il programma creerà un nuovo livello.",
      "Layer allen versetzten Kurven zuweisen.\r\n"+
         "Wenn Sie den Namen einer nicht vorhandenen Ebene eingeben, erstellt das Programm eine neue Ebene.",
      "将图层分配给所有偏移曲线。 \r\n" +
         "如果您输入一个不存在的层的名称，程序将创建一个新层。" };
    public static readonly string[] 
      LayerTip = {
      "You can enter layer name for new objects. \r\n" +
        "Layer will created if it not exists",
      "Вы можете ввести имя слоя для новых объектов. \r\n" +
         "Слой будет создан, если он не существует",
      "Assegna il livello a tutte le curve tagliate. \r\n" +
        "Se inserisci il nome di un livello inesistente, il programma creerà un nuovo livello.",
      "Sie können Layer-Namen für neue Objekte eingeben.\r\n"+
         "Ebene wird erstellt, wenn sie nicht existiert",
      "您可以为新对象输入图层名称。 \r\n" +
         "层将创建，如果它不存在" };
    public static readonly string[] 
      RepeatTip = {
      "Offset for offseted contour again and again.",
      "Сделать офсет офсеченого контура еще раз и еще.",
      "Contorno sfalsato offset ancora e ancora.",
      "Offset für versetzte Kontur immer wieder.",
      "一次又一次地偏移偏移轮廓。" };
    public static readonly string[] 
      DirectionText = {
      "Direction",
      "Направление",
      "Direzione",
      "Richtung",
      "方向" };
    public static readonly string[] 
      DistanceText = {
      "Distance",
      "Дистанция",
      "Distanza",
      "Distanz",
      "距离" };
    public static readonly string[] 
      RepeatText = {
      "Repeat",
      "Повторять",
      "Ripetizione",
      "Wiederholen",
      "重复" };
    public static readonly string[] 
      BothText = {
      "Both",
      "Обе стороны",
      "In entrambe",
      "Wiederholen",
      "重复" };
    public static readonly string[] 
      BothTip = {
      "All curves (both closed and open) will be offseted in both directions. \r\n" +
        "A direction request (for open curves) will not be displayed.",
      "Все кривые (и замкнутые и разомкнутые) будут отофсечены сразу в обе стороны. \r\n" +
        "Запрос направления (для разомкнутых кривых) выводится не будет.",
      "Tutte le curve (sia chiuse che aperte) verranno immediatamente tagliate in entrambe le direzioni.\r\n" +
        "Non verrà visualizzata una richiesta di direzione (per curve aperte).",
      "Alle Kurven (sowohl geschlossene als auch offene) werden in beide Richtungen versetzt.\r\n"+
         "Eine Richtungsabfrage (für offene Kurven) wird nicht angezeigt.",
      "所有曲线（闭合和开放）都将在两个方向上偏移。 \r\n" +
         "将不会显示方向请求（对于开放曲线）。" };
    public static readonly string[] 
      InsideText = {
      "Inward",
      "Внутрь",
      "Dentro",
      "Innere",
      "向内的" };
    public static readonly string[] 
      InsideTip = {
      "Offset all closed curves inward. \r\n" +
        "The setting does not apply to open curves.",
      "Все замкнутые кривые офсетить внутрь. \r\n" +
        "Настройка не касается разомкнутых кривых.",
      "Offset verso l'interno tutte le curve chiuse. \r\n" +
        "L'impostazione non si applica alle curve aperte.",
      "Versetzen Sie alle geschlossenen Kurven nach innen.\r\n"+
         "Die Einstellung gilt nicht für offene Kurven.",
      "向内偏移所有闭合曲线。 \r\n" +
         "该设置不适用于开放曲线。" };
    public static readonly string[] 
      OutsideText = {
      "Outward",
      "Наружу",
      "Fuori",
      "Nach außen",
      "向外" };
    public static readonly string[] 
      OutsideTip = {
      "Offset all closed curves outward. \r\n" +
        "The setting does not apply to open curves.",
      "Все замкнутые кривые офсетить наружу. \r\n" +
        "Настройка не касается разомкнутых кривых.",
      "Tutte le curve chiuse sono sfalsate verso l'esterno. \r\n" +
        "L'impostazione non si applica alle curve aperte.",
      "Versetzen Sie alle geschlossenen Kurven nach außen.\r\n"+
         "Die Einstellung gilt nicht für offene Kurven.",
      "向外偏移所有闭合曲线。 \r\n" +
         "该设置不适用于开放曲线。" };
    public static readonly string[] 
      DistanceTip = {
      "The distance from the original curve at which the new curve will be drawn.",
      "Расстояние от исходной кривой, на котором будет сделана новая кривая.",
      "La distanza dalla curva originale alla quale verrà disegnata la nuova curva.",
      "Der Abstand von der ursprünglichen Kurve, bei dem die neue Kurve gezeichnet wird.",
      "绘制新曲线时与原始曲线的距离。" };
    public static readonly string[] 
      StileNameTip = {
      "The name for this style. \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Имя этого стиля настроек.\r\n" +
        "Имя не используется в программе. Просто для удобства выбора.",
      "Il nome per questo stile.\r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Stil.\r\n"+
         "Nicht im Programm verwendet. Nur zur Vereinfachung der Auswahl.",
      "此样式的名称。 \r\n" +
         "未在程序中使用，仅供选择方便。" };

  }
}
