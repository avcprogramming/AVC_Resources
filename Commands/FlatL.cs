// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  FlatL
  {
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

    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI
  }
}
