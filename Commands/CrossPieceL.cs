// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  CrossPieceL
  {
    public static readonly string[] Select = {
      "  Select crossed solids ",
      "  Выберите пересекающиеся детали типа 3DSolid ",
      "  Seleziona parti intersecanti di tipo 3DSolid ",
      "  Wählen Sie sich überschneidende Teile vom Typ 3DSolid aus ",
      "  选择交叉实体 "};
    public static readonly string[] SecondQuery = {
      "  Select second solid",
      "  Выберите вторую деталь",
      "  Scegli una seconda parte",
      "  Wählen Sie einen zweiten Teil",
      "  选择第二个实体"};
    public static readonly string[] SameErr = {
      "  Selected same solid",
      "  Выбран тот же самый солид",
      "  Lo stesso solido è selezionato",
      "  Gleiches Element ausgewählt",
      "  选择相同的实体"};
    public static readonly string[] CrossedErr = {
      "  Solids is not crossed",
      "  Солиды не пересекаются",
      "  I dettagli non si intersecano",
      "  Details überschneiden sich nicht",
      "  实体不交叉"};
    public static readonly string[] Need2 = {
      "  Need 2 crossed solids or more",
      "  Программе нужны 2 пересекающихся твердых тела (или больше)",
      "  Il programma richiede 2 solidi che si intersecano (o più)",
      "  Das Programm benötigt 2 sich überschneidende Volumenkörper (oder mehr)",
      "  该程序需要 2 个相交的刚体（或更多）"};
    public static readonly string[] Search = {
      "  Search all the intersections with all...",
      "  Поиск пересечений всех со всеми...",
      "  Cerca le intersezioni di tutti con tutti ...",
      "  Suche nach Schnittpunkten aller mit allen ...",
      "  用所有...搜索所有交叉路口" };
    public static readonly string[] CrossErr = {
      "  Can't do cross piece",
      "  Не удалось сделать крестовину",
      "  Incrocio fallito",
      "  Fehler beim Kreuzstücke",
      "  不能做交叉片" };
    public static readonly string[] NoCross = {
      "  Unable to make any crosses",
      "  Не удалось сделать ни одной крестовины",
      "  Impossibile effettuare una sola croce",
      "  Es ist fehlgeschlagen, ein einziges Kreuzstücke zu machen",
      "  无法进行任何交叉" };
    public static readonly string[] Result = {
      "  Made {0} crosses",
      "  Удалось сделать {0} крестовин",
      "  Gestito per fare {0} croci",
      "  Hat es geschafft, {0} Kreuzstücke zu machen",
      "  进行了 {0} 次交叉" };
    public static readonly string[] InverseOn = {
      "  Inverse mode ON",
      "  Включен режим вычитания НАОБОРОТ",
      "  Modalità inversa ON",
      "  Umkehren Modus EIN",
      "  反向切割现已启用" };
    public static readonly string[] InverseOff = {
      "  Inverse mode OFF",
      "  Отключен режим вычитания НАОБОРОТ",
      "  Modalità inversa Off",
      "  Umkehren Modus AUS",
      "  现在反向切割已关闭" };
    public static readonly string[] NoEdge ={
      "  No one linear edge on crossing found. May be not flat solids",
      "  Не найдено ни одной линейной грани на пересечении. Возможно детали не плоские?",
      "  Non sono state trovate facce lineari all'intersezione. Forse le parti non sono piatte?",
      "  An der Kreuzung wurden keine linearen Flächen gefunden. Vielleicht sind die Teile nicht flach?",
      "  未发现交叉点上的任何线性边缘。 可能不是扁平固体" };
    public static readonly string[] Process = { 
      "Make cross pieces", 
      "Изготовление крестовин", 
      "Fai dei pezzi incrociati", 
      "Kreuzstücke machen",
      "制作交叉件" };
    public static readonly string[] DirErr ={
      "  Not clear direction of dismantling cross-piece.\n  " +
        "One item likely surrounds another.\n  " +
        "Try bit move items in the direction of dismantling cross-piece",
      "  Непонятно куда выдвигать детали.\n  " +
        "Скорее всего одна деталь окружает другую.\n  " +
        "Попробуйте чуть сдвинуть детали в направлении разборки крестовины.",
      "  Non è chiaro dove spingere le parti.\n " +
        "Molto probabilmente, una parte circonda un'altra.\n " +
        "Prova a spostare leggermente le parti nella direzione di smontaggio della traversa.",
      "  Es ist nicht klar, wohin die Teile gedrückt werden sollen.\n " +
        "Höchstwahrscheinlich umgibt ein Teil das andere.\n " +
        "Versuchen Sie, die Teile leicht in Richtung der Demontage des Kreuzstücke zu bewegen.",
      "  横梁拆卸方向不明确\n " +
         "一个项目可能围绕着另一个。\n " +
         "试着往拆卸横梁的方向移动物品。" };
    public static readonly string[] SolidNotValid ={
      "This solid is not valid. It may be import error.\n " +
        "Recommended remodeling.",
      "Тело содержит ошибки моделирования.\nСкорее всего тело импортировано из другой программы с ошибками.\n" +
        "Рекомендуется моделировать тело заново.",
      "Il solido contiene errori di modellazione.\n " +
        "Molto probabilmente, il Solid3d è stato importato da un altro programma con errori.\n " +
        "Si consiglia di simulare nuovamente il solido.",
      "Der Volumenkörper enthält Modellierungsfehler.\n " +
        "Höchstwahrscheinlich wurde der Volumenkörper aus einem anderen Programm mit Fehlern importiert.\n " +
        "Es wird empfohlen, den Volumenkörper erneut zu simulieren.",
      "此实体无效。 可能是导入错误。\n " +
         "建议改造。" };
    public static readonly string[] BacklashQuery = {
      "  Enter backlash value or zero",
      "  Введите значение люфта или ноль",
      "  Immettere un valore di Backlash o zero",
      "  Geben Sie einen Luft oder Null ein",
      "  输入缩进大小或零" };
    public static readonly string[] OptionsInfo ={
      "  Current settings: Gap = {0}, Backlash = {1}, Inverse = {2}",
      "  Текущие настройки: Зазор = {0}, Люфт = {1}, Инвертирование = {2}",
      "  Impostazioni correnti: Liquidazione = {0}, Backlash = {1}, Inverti = {2}",
      "  Aktuelle Einstellungen: Spiel = {0}, Luft = {1}, Umkehren = {2}",
      "  当前设置：间隙 = {0}，凹槽 = {1}，反转 = {2}" };
    public static readonly string[] InverseKW = { 
      "INverse", 
      "НАоборот", 
      "INverti", 
      "UMkehren",
      "反之亦然(IN)" }; //select Options
    public static readonly string[] OffInverseKW = { 
      "OFfInverse", 
      "ВЫключитьНаоборот", 
      "SPEgniInverti", 
      "AUSschaltenInverser",
      "禁用反向模式(OF)" }; //select Options
    public static readonly string[] BacklashKW = { 
      "BAcklash", 
      "ЛЮФТ", 
      "BAcklash", 
      "LUFT",
      "深化(BA)" };
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

  }
}
