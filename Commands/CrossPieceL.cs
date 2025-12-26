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
      "  选择交叉实体 ",
      "  Seleccione sólidos que se cruzan ",                     // ES
      "  Sélectionnez les solides qui se croisent ",             // FR
      "  Kesişen katıları seçin "};                              // TR

    public static readonly string[] SecondQuery = {
      "  Select second solid",
      "  Выберите вторую деталь",
      "  Scegli una seconda parte",
      "  Wählen Sie einen zweiten Teil",
      "  选择第二个实体",
      "  Seleccione el segundo sólido",                          // ES
      "  Sélectionnez le deuxième solide",                       // FR
      "  İkinci katıyı seçin"};                                  // TR

    public static readonly string[] SameErr = {
      "  Selected same solid",
      "  Выбран тот же самый солид",
      "  Lo stesso solido è selezionato",
      "  Gleiches Element ausgewählt",
      "  选择相同的实体",
      "  Se seleccionó el mismo sólido",                         // ES
      "  Même solide sélectionné",                               // FR
      "  Aynı katı seçildi"};                                    // TR

    public static readonly string[] CrossedErr = {
      "  Solids is not crossed",
      "  Солиды не пересекаются",
      "  I dettagli non si intersecano",
      "  Details überschneiden sich nicht",
      "  实体不交叉",
      "  Los sólidos no se cruzan",                              // ES
      "  Les solides ne se croisent pas",                        // FR
      "  Katılar kesişmiyor"};                                   // TR

    public static readonly string[] SliceErr = {
      "  Failed to slice solid",
      "  Не удалось разрезать солид",
      "  Impossibile tagliare il solido",
      "  3D-Solid konnte nicht geschnitten werden",
      "  无法切片 3d 实体",
      "  Error al cortar el sólido",                             // ES
      "  Échec de la découpe du solide",                         // FR
      "  Katı kesilemedi"};                                      // TR

    public static readonly string[] Need2 = {
      "  Need 2 crossed solids or more",
      "  Программе нужны 2 пересекающихся твердых тела (или больше)",
      "  Il programma richiede 2 solidi che si intersecano (o più)",
      "  Das Programm benötigt 2 sich überschneidende Volumenkörper (oder mehr)",
      "  该程序需要 2 个相交的刚体（或更多）",
      "  Se necesitan 2 sólidos que se cruzan o más",            // ES
      "  Nécessite 2 solides qui se croisent ou plus",           // FR
      "  2 veya daha fazla kesişen katıya ihtiyaç var"};         // TR

    public static readonly string[] Search = {
      "  Search all the intersections with all...",
      "  Поиск пересечений всех со всеми...",
      "  Cerca le intersezioni di tutti con tutti ...",
      "  Suche nach Schnittpunkten aller mit allen ...",
      "  用所有...搜索所有交叉路口",
      "  Buscar todas las intersecciones con todos...",          // ES
      "  Rechercher toutes les intersections avec tous...",      // FR
      "  Tüm kesişmeleri tümüyle ara..."};                       // TR

    public static readonly string[] CrossErr = {
      "  Can't do cross piece",
      "  Не удалось сделать крестовину",
      "  Incrocio fallito",
      "  Fehler beim Kreuzstücke",
      "  不能做交叉片",
      "  No se puede hacer la pieza cruzada",                    // ES
      "  Impossible de faire la pièce croisée",                  // FR
      "  Çapraz parça yapılamıyor"};                             // TR

    public static readonly string[] NoCross = {
      "  Unable to make any crosses",
      "  Не удалось сделать ни одной крестовины",
      "  Impossibile effettuare una sola croce",
      "  Es ist fehlgeschlagen, ein einziges Kreuzstücke zu machen",
      "  无法进行任何交叉",
      "  No se puede hacer ninguna cruz",                        // ES
      "  Impossible de faire des croix",                         // FR
      "  Hiçbir çapraz yapılamıyor"};                            // TR

    public static readonly string[] Result = {
      "  Made {0} crosses",
      "  Удалось сделать {0} крестовин",
      "  Gestito per fare {0} croci",
      "  Hat es geschafft, {0} Kreuzstücke zu machen",
      "  进行了 {0} 次交叉",
      "  Se hicieron {0} cruces",                                // ES
      "  {0} croix réalisées",                                   // FR
      "{0} çapraz yapıldı"};                                     // TR

    public static readonly string[] InverseOn = {
      "  Inverse mode ON",
      "  Включен режим вычитания НАОБОРОТ",
      "  Modalità inversa ON",
      "  Umkehren Modus EIN",
      "  反向切割现已启用",
      "  Modo inverso ACTIVADO",                                 // ES
      "  Mode inverse ACTIVÉ",                                   // FR
      "  Ters mod AÇIK"};                                        // TR

    public static readonly string[] InverseOff = {
      "  Inverse mode OFF",
      "  Отключен режим вычитания НАОБОРОТ",
      "  Modalità inversa Off",
      "  Umkehren Modus AUS",
      "  现在反向切割已关闭",
      "  Modo inverso DESACTIVADO",                              // ES
      "  Mode inverse DÉSACTIVÉ",                                // FR
      "  Ters mod KAPALI"};                                      // TR

    public static readonly string[] NoEdge = {
      "  No one linear edge on crossing found. May be not flat solids",
      "  Не найдено ни одной линейной грани на пересечении. Возможно детали не плоские?",
      "  Non sono state trovate facce lineari all'intersezione. Forse le parti non sono piatte?",
      "  An der Kreuzung wurden keine linearen Flächen gefunden. Vielleicht sind die Teile nicht flach?",
      "  未发现交叉点上的任何线性边缘。 可能不是扁平固体",
      "  No se encontró ningún borde lineal en el cruce. Pueden no ser sólidos planos",  // ES
      "  Aucun bord linéaire trouvé au croisement. Peut-être que ce ne sont pas des solides plats",  // FR
      "  Kesişmede doğrusal kenar bulunamadı. Düz katılar olmayabilir"};  // TR

    public static readonly string[] Process = {
      "Make cross pieces",
      "Изготовление крестовин",
      "Fai dei pezzi incrociati",
      "Kreuzstücke machen",
      "制作交叉件",
      "Hacer piezas cruzadas",                                   // ES
      "Faire des pièces croisées",                               // FR
      "Çapraz parçalar yap"};                                    // TR

    public static readonly string[] DirErr = {
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
         "试着往拆卸横梁的方向移动物品。",
      "  No está clara la dirección de desmontaje de la pieza cruzada.\n  " +  // ES
        "Un elemento probablemente rodea a otro.\n  " +
        "Intente mover un poco los elementos en la dirección de desmontaje de la pieza cruzada",
      "  Direction de démontage de la pièce croisée pas claire.\n  " +  // FR
        "Un élément entoure probablement un autre.\n  " +
        "Essayez de déplacer légèrement les éléments dans la direction du démontage de la pièce croisée",
      "  Çapraz parçanın sökme yönü net değil.\n  " +  // TR
        "Bir öğe muhtemelen diğerini çevreliyor.\n  " +
        "Öğeleri çapraz parçanın sökme yönünde biraz hareket ettirmeyi deneyin"};

    public static readonly string[] SolidNotValid = {
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
         "建议改造。",
      "Este sólido no es válido. Puede ser un error de importación.\n " +  // ES
        "Se recomienda remodelarlo.",
      "Ce solide n'est pas valide. Il peut s'agir d'une erreur d'importation.\n " +  // FR
        "Remodelage recommandé.",
      "Bu katı geçerli değil. İçe aktarma hatası olabilir.\n " +  // TR
        "Yeniden modelleme önerilir."};

    public static readonly string[] BacklashQuery = {
      "  Enter backlash value or zero",
      "  Введите значение люфта или ноль",
      "  Immettere un valore di Backlash o zero",
      "  Geben Sie einen Luft oder Null ein",
      "  输入缩进大小或零",
      "  Ingrese el valor de holgura o cero",                    // ES
      "  Entrez la valeur du jeu ou zéro",                       // FR
      "  Boşluk değerini veya sıfır girin"};                     // TR

    public static readonly string[] OptionsInfo = {
      "  Current settings: Gap = {0}, Backlash = {1}, Inverse = {2}",
      "  Текущие настройки: Зазор = {0}, Люфт = {1}, Инвертирование = {2}",
      "  Impostazioni correnti: Liquidazione = {0}, Backlash = {1}, Inverti = {2}",
      "  Aktuelle Einstellungen: Spiel = {0}, Luft = {1}, Umkehren = {2}",
      "  当前设置：间隙 = {0}，凹槽 = {1}，反转 = {2}",
      "  Configuración actual: Espacio = {0}, Holgura = {1}, Inverso = {2}",  // ES
      "  Paramètres actuels : Écart = {0}, Jeu = {1}, Inverse = {2}",  // FR
      "  Mevcut ayarlar: Boşluk = {0}, Gevşeklik = {1}, Ters = {2}"};  // TR

    public static readonly string[] InverseKW = {
      "INverse",
      "НАоборот",
      "INverti",
      "UMkehren",
      "反之亦然(IN)",
      "INverso",                                                  // ES
      "INverse",                                                  // FR
      "TERs"};                                                    // TR

    public static readonly string[] OffInverseKW = {
      "OFfInverse",
      "ВЫключитьНаоборот",
      "SPEgniInverti",
      "AUSschaltenInverser",
      "禁用反向模式(OF)",
      "DESactivarInverso",                                       // ES
      "DÉSactiverInverse",                                       // FR
      "TERsiKAPAt"};                                             // TR

    public static readonly string[] BacklashKW = {
      "BAcklash",
      "ЛЮФТ",
      "BAcklash",
      "LUFT",
      "深化(BA)",
      "HOlgura",                                                  // ES
      "JEu",                                                      // FR
      "BOşluk"};                                                  // TR


    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

  }
}