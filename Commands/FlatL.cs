// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  FlatL
  {
    public static readonly string[,] FlatStyleNames = {
/* 0 */ { CommandL.FLT[0],  CommandL.FLT[1],  CommandL.FLT[2], CommandL.FLT[3], CommandL.FLT[4] },
/* 1 */ { CommandL.FLT[0],  CommandL.FLT[1],  CommandL.FLT[2], CommandL.FLT[3], CommandL.FLT[4] },
/* 2 */ { "Contours of solids",
          "Контуры солидов",
          "Contorni dei solidi",
          "Konturen von Festkörpern",
          "实体的轮廓" } };
    public static string[] Skipped = {
      "  Object skipped",
      "  Объект пропущен",
      "  Saltato",
      "  Objekt übersprungen",
      "  程序不会处理这部分。"};
    public static string[] MaxMeshQuery = {
      "  Enter the maximum mesh size or 0",
      "  Введите максимальный размер сетей или 0",
      "  Inserire la dimensione massima della mesh o 0",
      "  Geben Sie die maximale Netzwerkgröße oder 0 ein",
      "  输入网格尺寸或 0" };
    public static string[] LayerManagementQuery = {
      "  Do assign layers?",
      "  Назначать слои?",
      "  Assegno i layer?",
      "  Assign Layer?",
      "  分配图层？" };
    public static string[] DeleteSourcesQuery = {
      "  Do delete the source objects?",
      "  Удалять исходные объекты?",
      "  Cancellare gli oggetti sorgente?",
      "  Löschen Sie die Quellobjekte?",
      "  删除源对象？" };
    public static string[] HiddenShowQuery = {
      "  Show invisible edges of solids?",
      "  Показывать невидимые ребра солидов?",
      "  Mostra bordi invisibili di oggetti solidi?",
      "  Unsichtbare Kanten von Volumenkörpern anzeigen?",
      "  显示隐藏线？" };
    public static string[] ShowTangencyQuery = {
      "  Show tangency edges of solids (imprinted in the plane)?",
      "  Показывать касательные ребра (впечатанные в плоскость)?",
      "  Se mostrare gli spigoli tangenti (impressi nel piano)?",
      "  Ob tangentiale Kanten (in die Ebene eingeprägt) angezeigt werden sollen?",
      "  是否显示切边（印在平面上）？" };
    public static string[] ContoursQuery = {
      "  Call the Outside Loop program?",
      "  Вызвать программу Внешний Контур?",
      "  Vuoi chiamare il programma Outside Loop?",
      "  Das Outside Loop-Programm aufrufen?",
      "  调用外循环程序？" };

    // ========================= Command Line Options ======================================================

    public static string[] kwDeleteSources = {
      "DeleteSources",
      "УдалятьИсходники",
      "ELiminaFonti",
      "QuellenLöschen",
      "删除源对象(D)" };
    public static string[] kwMaxMesh = {
      "MAxMesh",
      "МаксСеть",
      "MAxMesh",
      "MAxNetz",
      "网格大小(MA)" };
    public static string[] kwLayerManagement = {
      "LAYerManagement",
      "НАЗначатьСлой",
      "LAYerGestione",
      "LAYerManagement",
      "分配图层(LAY)" };
    public static string[] kwHiddenShow = {
      "HIddenShow",
      "СКрытыеПоказывать",
      "NAscosteMostra",
      "VErstecktAnzeigen",
      "隐藏线(HI)" };
    public static string[] kwShowTangency = {
      "TAngentialShow",
      "КАСательныеПоказывать",
      "TAngenzialiMostra",
      "TAngentenZeigen",
      "显示切线(TA)" };
    public static string[] kwContouring = {
      "CONTOURS",
      "КОНТУРЫ",
      "CONTORNI",
      "KONTUREN",
      "轮廓(CONT)" };

    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

    // ======================================= Options Dialog Box =========================================================
    public static readonly string[] StyleNameTip = {
      "The name for this style of Flat command. Not used in the program. Only for convenience of choice.",
      "Название для этого стиля настроек команды Плоский. \r\n" +
        "Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile. Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此样式的平面命令的名称。 程序中没有使用。 只为方便选择。"};
    public static string[] Ucs = {
      "Current coordinate system",
      "Текущая система координат",
      "Sistema di coordinate corrente",
      "Aktuelles Koordinatensystem",
      "当前坐标系" };
    public static string[] ShowHidden = {
      "Show invisible edges",
      "Показывать невидимые ребра",
      "Mostra bordi invisibili",
      "Unsichtbare Kanten anzeigen",
      "显示不可见的边缘" };
    public static string[] ShowTangency = {
      "Show tangency edges",
      "Показывать касательные ребра",
      "Mostra i bordi di tangenza",
      "Tangentialkanten anzeigen",
      "显示相切边" };
    public static string[] Contouring = {
      "Make contours",
      "Делать контуры",
      "Crea contorni",
      "Machen Sie Umrisse",
      "画出轮廓" };
    public static string[] UcsTip = {
      "Use the current user coordinate system (UCS). \r\n" +
        "If you disable this option, the program will always work in the world coordinate system (WCS)",
      "Использовать текущую пользовательскую систему координат (ПСК = UCS). \r\n" +
        "Если отключить опцию, то программа всегда будет работать в мировой системе координат (МСК = WCS)",
      "Utilizza il sistema di coordinate utente corrente (UCS). \r\n" +
        "Se disabiliti l'opzione, il programma funzionerà sempre nel sistema di coordinate mondiali (WCS)",
      "Verwenden Sie das aktuelle Benutzerkoordinatensystem (UCS). \r\n" +
        "Wenn Sie die Option deaktivieren, arbeitet das Programm immer im Weltkoordinatensystem (WCS).",
      "使用当前用户坐标系 (UCS)。如果禁用该选项，程序将始终在世界坐标系（WCS）中运行" };
    public static readonly string[] DeleteSourcesTip = {
      "Delete all original drawing objects from which it was possible to make a flatshot",
      "Удалить все исходные объекты чертежа, с которых удалось сделать плоский слепок",
      "Eliminare tutti gli oggetti di disegno originali da cui è stato possibile realizzare un flatshot",
      "Löschen Sie alle ursprünglichen Zeichenobjekte, von denen ein Flatshot erstellt werden konnte",
      "删除所有可以制作平面图的原始绘图对象" };
    public static string[] ShowHiddenTip = {
      "Show or hide invisible edges of solids and closed networks",
      "Показывать или скрыть невидимые ребра солидов и замкнутых сетей",
      "Mostra o nascondi i bordi invisibili di solidi e reti chiuse",
      "Blenden Sie unsichtbare Kanten von Volumenkörpern und geschlossenen Netzwerken ein oder aus",
      "显示或隐藏实体和封闭网络的不可见边缘" };
    public static string[] ShowTangencyTip = {
      "Show tangency edges of solids (imprinted in the plane)",
      "Показывать касательные ребра (впечатанные в плоскость)",
      "Mostra i bordi tangenti dei solidi (impressi nel piano)",
      "Tangentialkanten von Körpern anzeigen (in die Ebene eingeprägt)",
      "显示实体的切线边（印在平面上）" };
    public static string[] ContouringTip = {
      "Call the program External Contour to close and optimize the visible contours of each part. \r\n" +
        "The program will remove all curve overlaps and replace the layers with the layers of the current NC Preparation settings. \r\n" +
        "Invisible contours are not processed. \r\n" +
        "The option will only work if you have a license for the program Outside Loop.",
      "Вызвать программу Внешний Контур, чтоб замкнуть и оптимизировать видимые контуры каждой делали. \r\n" +
        "Программ удалит все наложения кривых и заменит слои на слои текущих настроек ЧПУ подготовки (NCP). \r\n" +
        "Невидимые контуры не обрабатываются. \r\n" +
        "Опция сработает только при наличии лицензии на программу Внешний Контур.",
      "Richiamare il programma Contorno Esterno per chiudere e ottimizzare i contorni visibili di ciascuno. \r\n" +
        "Il programma rimuoverà tutte le sovrapposizioni di curve e sostituirà gli strati con gli strati \r\n" +
        "delle attuali impostazioni di Preparazione CNC (NCP). I contorni invisibili non vengono elaborati. \r\n" +
        "L'opzione funzionerà solo se hai una licenza per il programma Outside Loop.",
      "Rufen Sie das Programm „Externe Kontur“ auf, um die sichtbaren Konturen jedes einzelnen zu schließen und zu optimieren. \r\n" +
        "Das Programm entfernt alle Kurvenüberlagerungen und ersetzt die Ebenen durch die Ebenen der aktuellen \r\n" +
        "CNC-Vorbereitungseinstellungen (NCP). \r\n" +
        "Unsichtbare Konturen werden nicht bearbeitet. \r\n" +
        "Die Option funktioniert nur, wenn Sie über eine Lizenz für das Programm Outside Loop verfügen.",
      "调用外部轮廓程序来关闭和优化每一个可见轮廓。\r\n" +
        "该程序将删除所有曲线叠加并用当前 CNC 准备设置的层替换这些层。\r\n" +
        "不处理不可见的轮廓。\r\n" +
        "仅当您拥有程序 Outside Loop 的许可证时，此选项才有效。" };
  }
}
