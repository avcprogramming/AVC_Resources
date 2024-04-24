// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  ChopL
  {
    public static readonly string[,] ChopStyleNames = {
/* 0 */ {
        CommandL.CH[0],
        CommandL.CH[1],
        CommandL.CH[2],
        CommandL.CH[3],
        CommandL.CH[4]},
/* 1 */ {
        "Chop from a plane",
        "Нарезка от плоскости",
        "Tritare da un aereo",
        "Hack von Oberfläche",
        "从切割平面切割" },
/* 2 */ {
        CommandL.CHE[0],
        CommandL.CHE[1],
        CommandL.CHE[2],
        CommandL.CHE[3],
        CommandL.CHE[4]},
/* 3 */ {
        "Rib spacing",
        "Расстановка ребер (нервюр)",
        "Spaziatura delle costole",
        "Rippenabstand",
        "肋间距" },
    };

    public static readonly string[] PieceLengthQuery = {
      "  Enter the length of the pieces (cutting step)",
      "  Введите длину долек (шаг нарезки)",
      "  Inserisci la lunghezza delle fette (passo di taglio)",
      "  Geben Sie die Länge der Scheiben ein (Schnittschritt)",
      "  输入切片的长度（切割步骤）" };
    public static readonly string[] NoFace = {
      "None of selected face",
      "Нет выбранных поверхностей",
      "Nessuna superficie selezionata",
      "Keine Oberflächen ausgewählt",
      "没有选定的面" };
    public static readonly string[] SurfErr = {
      "It was necessary to click on the surface of the solid. And you have selected: '{0}'",
      "Надо было кликать по поверхности солида, а выбран: '{0}'",
      "È stato necessario fare clic sulla superficie del solido e selezionare: '{0}'",
      "Es war notwendig, auf die Oberfläche des Volumenkörper zu klicken und Folgendes auszuwählen: '{0}'",
      "需要点击实体的表面。 并且您选择了：“{0}”"};
    public static readonly string[] FaceSelectErr = {
      "Can't select face",
      "Не получилось выбрать поверхность",
      "Impossibile selezionare la superficie",
      "Oberfläche konnte nicht ausgewählt werden",
      "无法选择面" };
    public static readonly string[] PlaneErr ={
      "Can't get plane. May it not flat face",
      "Плоскость не определена. Возможно это не плоская поверхность",
      "L'aereo non è definito. Forse non è una superficie piana",
      "Das Flugzeug ist undefiniert. Vielleicht ist es keine flache Oberfläche",
      "无法获得平面，可能不是平面面" };
    public static readonly string[] EdgeSelected ={
      "Solid edge selected",
      "Выбрано ребро солида",
      "Bordo solido selezionato",
      "Kante ausgewählt",
      "选择实体边缘" };
    public static readonly string[] BaseQuery = {
      "  Select base face of solid",
      "  Выберите базовую плоскость тела",
      "  Seleziona il piano di base della parte",
      "  Wählen Sie die Basisebene des Volumenkörper",
      "  选择实体的基面"};
    public static readonly string[] StartQuery = {
      "  Pick a point on the edge where the first cut will be made",
      "  Выберите точку на ребре, где будет сделан первый разрез",
      "  Scegli un punto sul bordo in cui verrà eseguito il primo taglio",
      "  Wählen Sie einen Punkt auf der Kante, wo der erste Schnitt gemacht wird",
      "  选择边缘上的一个点，进行第一次切割。"};
    public static readonly string[] CutSolidErr = {
      "Could not cut the solid.",
      "Невозможно разрезать солид.",
      "Impossibile tagliare le parti",
      "Teile können nicht geschnitten werden",
      "无法切割实体." };
    public static readonly string[] Piece = {
      "Piece",
      "Дольки",
      "Pezzo",
      "Stück",
      "片" }; // имя слоя
    public static readonly string[] Stub = {
      "Stub",
      "Огрызки",
      "Mozzicone",
      "Stub",
      "存根" }; // имя слоя
    public static readonly string[] ChopCount = {
      "Chop on {0} solids",
      "Нарезано на {0} долек",
      "Tritare su {0} pezzi",
      "{0} Stücke hacken",
      "切割 {0} 实体"};
    public static readonly string[] Formula = {
      "Cutting formula:",
      "Формула нарезки:",
      "Formula per tritare:",
      "Schnittformel:",
      "切片公式：" };
    public static readonly string[] PieceCountQuery = {
      "Enter count of piece",
      "Введите количество долек",
      "Inserisci il conteggio del pezzo",
      "Stückzahl eingeben",
      "输入件数" };
    public static readonly string[] MaxLengthQuery = {
      "Enter a limit on the maximum allowable length of a piece",
      "Введите ограничение по максимально допустимой длине дольки " ,
      "Immettere un limite per la lunghezza massima consentita di un segmento",
      "Geben Sie eine Grenze für die maximal zulässige Länge eines Segments ein",
      "输入段的最大允许长度限制"};
    public static readonly string[] MaxLengthInfo = {
      "Solid will chop on {0} pieces length {1}",
      "Солид будет нарезан на {0} долек длиной {1}",
      "Il solido taglierà su {0} pezzi di lunghezza {1}",
      "Volumenkörper hackt auf {0} Stücklänge {1}",
      "固体将切成 {0} 件长度 {1}" };
    public static readonly string[] RibErrContinueQuery ={
      "Failed to take into account the thickness of the rib at the alignment of the cut planes. Continue?",
      "Не удалось учесть толщину ребра при расстановке плоскостей реза. Продолжить?",
      "Impossibile tenere conto dello spessore delle nervature quando si posizionano i piani del taglio. Continuare?",
      "Die Dicke der Rippen konnte beim Platzieren der Schnittebenen nicht berücksichtigt werden. Weiter?",
      "在对齐切割面时未能考虑到肋骨的厚度。继续？" };
    public static readonly string[] Need1RegionErr ={
      "Only one flat surface needs to be selected",
      "Требуется выбрать только одну плоскую поверхность",
      "È necessario selezionare solo una superficie piana",
      "Es muss nur eine flache Oberfläche ausgewählt werden",
      "只需选择一个平面" };
    public static readonly string[] StStProcess = {
      "Make stair-step solids...",
      "Делаем ступенчатые детали...",
      "Realizzazione di parti a gradini ...",
      "Stufenteile herstellen ...",
      "制作阶梯实体..." };
    public static readonly string[] StStErr = {
      "Failed to make stair-step solid.",
      "Не получилось сделать ступенчатый солид.",
      "Non ha funzionato per fare una parte a gradini.",
      "Es hat nicht geklappt, einen abgestuften Teil zu machen.",
      "无法制作阶梯实体。" };
    public static readonly string[] TwiceWarning ={
      "The edge is bent so that it crosses the cutting plane twice.\n" +
        "As a result, formed the unnecessary pieces/ribs.\n" +
        "It is recommended to divide the solid before.",
      "Тело изогнуто так, что плоскость реза пересекает его дважды.\n" +
        "В результате образуются лишние дольки/ребра.\n" +
        "Рекомендуется разделить солид вручную.",
      "Il solido viene piegato in modo che il piano di taglio lo intersechi due volte.\n" +
        "As risultato, si formano segmenti/bordi extra.\n" +
        "Si consiglia di dividere il solido manualmente.",
      "Der Volumenkörper wird so gebogen, dass die Schnittebene ihn zweimal schneidet.\n" +
        "As als Ergebnis werden zusätzliche Scheiben/Kanten gebildet.\n" +
        "Es wird empfohlen, den Volumenkörper manuell zu teilen. ",
      "因为边缘弯曲，使得切割面两次穿过它。\n" +
        "结果形成了多余的片/边。\n" +
        "建议手动分割实体。"};
    public static readonly string[] Saved = {
      "Saved {0} new solids.",
      "Сохранено {0} новых солидов.",
      "{0} nuovo solido salvato.",
      "{0} neuer Volumenkörper gespeichert.",
      "保存了 {0} 个新实体。"};
    public static readonly string[] CutErrTwice ={
      "Could not make the cut.\n" +
        "The edge is bent so that it crosses the cutting plane twice.\n" +
        "It is recommended to divide the solid before.",
      "Не удалось сделать разрез.\n" +
        "Тело изогнуто так, что плоскость реза пересекает его дважды\n" +
        "Рекомендуется разделить солид вручную.",
      "Impossibile eseguire un taglio.\n" +
        "Il corpo è piegato in modo che il piano di taglio lo intersechi due volte\n" +
        "Si consiglia di dividere il solido manualmente.",
      "Es konnte kein Schnitt ausgeführt werden.\n" +
        "Der Volumenkörper ist so gebogen, dass die Schnittebene ihn zweimal schneidet\n" +
        "Es wird empfohlen, den Volumenkörper manuell zu teilen.",
      "无法进行切割。\n" +
        "因为边缘弯曲，使得切割面两次穿过它。\n" +
        "建议手动分割实体。"};
    public static readonly string[] SectionMissing = {
      "Section {0} missing.",
      "Сечение {0} пропущено.",
      "Manca la sezione {0}.",
      "Abschnitt {0} fehlt.",
      "缺少第 {0} 节。" };
    public static readonly string[] SectionErr = {
      "  Section plane outside of base edge.",
      "  Секущая плоскость за пределами базовой кривой.",
      "  Piano di sezione esterno al bordo della base.",
      "  Schnittebene außerhalb der Basiskante.",
      "  基础边缘外的剖面。"};
    public static readonly string[] IntersectWithErr = {
      "  IntersectWith throw error.",
      "  IntersectWith выдал ошибку.",
      "  IntersectWith ha generato un errore.",
      "  IntersectWith hat einen Fehler ausgegeben.",
      "  IntersectWith 抛出错误。" };
    public static readonly string[] NothingToCut = {
      "  There is nothing to cut in this place.",
      "  В этом месте нечего резать.",
      "  Non c'è niente da tagliare in questo posto.",
      "  An dieser Stelle gibt es nichts zu schneiden.",
      "  这里没有东西可以切割。" };
    public static readonly string[] CutCurveErr = {
      "Could not cut curve.",
      "Невозможно разрезать кривую.",
      "Impossibile tagliare la curva.",
      "Kurve kann nicht geschnitten werden.",
      "无法切割曲线。" };
    public static readonly string[] StubErr = {
      "Could not calculate stub. {0}",
      "Невозможно вычислить обрезки. {0}",
      "Impossibile calcolare il ritaglio. {0}",
      "Ernte kann nicht berechnet werden. {0}",
      "无法计算残余部分。 {0}" };
    public static readonly string[] CutRibErr = {
      "Failed to cut rib",
      "Невозможно вырезать ребро.",
      "Impossibile tagliare le costole.",
      "Rippe kann nicht geschnitten werden.",
      "无法切割肋骨" };
    public static readonly string[] PieceNameTemplate = {
      "'Piece'00",
      "'Часть '00",
      "'Pezzo '00",
      "'Stück '00",
      "'片'00"};
    public static readonly string[] SectionErrContinueQuery ={
      "Not possible to arrange all the cutting planes. Continue?",
      "Не получается расставить все секущие плоскости. Продолжить?",
      "Non è possibile disporre tutti gli aerei secanti. Continuare?",
      "Es ist nicht möglich, alle Sekantenebenen anzuordnen. Weiter?",
      "无法安排所有的切割平面。继续吗？" };
    public static readonly string[] GapInfo = {
      "  Current settings: Gap = {0}",
      "  Текущие настройки: Зазор = {0}",
      "  Impostazioni correnti: Liquidazione = {0}",
      "  Aktuelle Einstellungen: Spiel = {0}",
      "  当前设置：间隙 = {0}" };
    public static readonly string[] PointOnEdgeErr = {
      "Start point does not belong to an edge",
      "Стартовая точка не принадлежит ребру",
      "Il punto iniziale non appartiene a uno spigolo",
      "Startpunkt gehört nicht zu einer Kante",
      "起点不属于边缘。" };

    public static readonly string[] TooSmallSolidErr = {
      "Part or edge too small to cut",
      "Деталь или ребро слишком маленькое для разрезания",
      "Parte o bordo troppo piccolo per essere tagliato",
      "Teil oder Kante zu klein zum Schneiden",
      "零件或边缘太小,无法切割" };
    public static readonly string[] TooManyPiecesErr = {
      "Too many part cuts configured",
      "Настроено слишком большое количество разрезов детали",
      "Troppi tagli di pezzi configurati",
      "Zu viele Teilschnitte konfiguriert",
      "配置的零件切割太多" };
    public static readonly string[] TooBigMaxStepErr = {
      "The maximum allowable step is set greater than the part itself",
      "Задан максимально допустимый шаг больше чем сама деталь",
      "Il passo massimo consentito è impostato maggiore del pezzo stesso",
      "Der maximal zulässige Schritt ist größer eingestellt als das Teil selbst",
      "最大允许步长设置大于部件本身" };
    public static readonly string[] TooSmallMaxStepErr = {
      "Max step too small",
      "Максимальный шаг слишком мал",
      "Passo massimo troppo piccolo",
      "Max. Schritt zu klein",
      "最大步长太小" };
    public static readonly string[] NumberOfPiecesErr = {
      "The number of pieces must be greater than or equal to two",
      "Количество долек должно быть больше или равно двум",
      "Il numero di fette deve essere maggiore o uguale a due",
      "Die Anzahl der Slices muss größer oder gleich zwei sein",
      "切片的数量必须大于或等于两个" };
    public static readonly string[] TooBigGapErr = {
      "You won't be able to make cuts with such a huge gap.",
      "Не получится сделать разрезы с таким огромным зазором",
      "Non sarai in grado di fare tagli con un divario così grande.",
      "Mit einem so großen Abstand werden Sie keine Schnitte machen können.",
      "这么大的间隙无法进行切割。" };
    public static readonly string[] TooBigRibErr = {
      "It will not be possible to arrange such thick ribs",
      "Не получится расставить такие толстые ребра",
      "Non sarà possibile disporre costole così spesse",
      "Es wird nicht möglich sein, so dicke Rippen anzuordnen",
      "无法安排这么厚的肋骨。" };
    public static readonly string[] TooShortStepErr = {
      "With these settings, the cut slices will be too small.",
      "При таких настройках разрезанные дольки будут слишком мелкие",
      "Con queste impostazioni, le fette tagliate saranno troppo piccole.",
      "Mit diesen Einstellungen werden die geschnittenen Scheiben zu klein.",
      "使用这些设置，切片会太小。" };
    public static readonly string[] TooBigStepErr = {
      "Slicing step set too large",
      "Настроен слишком большой шаг нарезки",
      "Passo di taglio impostato troppo alto",
      "Chopping-Pitch zu hoch eingestellt",
      "切片步长设置过大" };

    // Далее опции командной строки - без пробелов и не должно совпадать со встроенными опциями соответствующей локализации AutoCAD
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI
    public static readonly string[] MaxLengthKW = {
      "MAxLength",
      "МаксДлина",
      "MAXLunghezza",
      "MAXLänge",
      "最大长度(MA)" }; //select Option
    public static readonly string[] FixStepKW = {
      "FIXedStep",
      "ФИКСированныйШаг",
      "passoFISSO",
      "FESTERschritt",
      "固定步长(FIX)"}; //select Option
    public static readonly string[] KW3point = {
      "3points",
      "3точки",
      "3punti",
      "3punkte",
      "3点"}; //select Option
    public static readonly string[] EdgeKW = {
      "EDGE",
      "РЕБРО",
      "BORDO",
      "KANTE",
      "选择边缘(EDG)"}; //select Option
    public static readonly string[] PlaneKW = {
      "PLANE",
      "ПЛОСКОСТЬ",
      "PIANO",
      "FLÄCHE",
      "选择平面(PLN)"}; //select Option

    public static readonly string[] Repair ={
      "Try to repair the solid using the DMAUDIT command",
      "Попробуйте отремонтировать солид командой DMAUDIT",
      "Prova a riparare il solido con il DMAUDIT",
      "Versuchen Sie, den Feststoff mit dem DMAUDIT zu reparieren",
      "尝试使用 DMAUDIT 命令修复实体" };

    // ====================================================================================================================================
    // ==================================================  Options Box ====================================================================

    public static readonly string[] OptionsDialog = {
      "Chop command settings",
      "Настройка команды Нарезка",
      "Personalizzazione del comando Tritare",
      "Anpassen des Hacken-Befehls",
      "切片命令设置"};
    public static readonly string[] StyleNameTip = {
      "The name for this chop-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля нарезки. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile chop (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Chop-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "这种样式（设置）名称。 没有在程序中使用。 只为方便选择。"};
    public static readonly string[] Mode = {
      "Mode",
      "Режим",
      "Modalità",
      "Modus",
      "模式"};
    public static readonly string[] Step = {
      "Step",
      "Шаг нарезки",
      "Fase di taglio",
      "Schritt",
      "切割步骤"};
    public static readonly string[] StartFrom = {
      "Start from",
      "Старт от",
      "Inizia da",
      "Beginne von",
      "从...开始"};
    public static readonly string[] ParallelPlanes = {
      "Parallel Planes",
      "Параллельные плоскости",
      "Piani paralleli",
      "Parallele Ebenen",
      "平行面"};
    public static readonly string[] ParallelPlanesTip = {
      "Cut the solid with many parallel planes. \r\n" +
        "Plane required. You can cut many solids at once.",
      "Нарезать солид множеством параллельных плоскостей. \r\n" +
        "Требуется задать плоскость. Можно резать сразу множество солидов.",
      "Taglia il solido con molti piani paralleli. Aereo richiesto. \r\n" +
        "Puoi tagliare molti solidi contemporaneamente.",
      "Schneiden Sie den Volumenkörper mit vielen parallelen Ebenen. \r\n" +
        "Flugzeug erforderlich. Sie können viele Feststoffe auf einmal schneiden.",
      "用许多平行面切割实体。 \r\n" +
        "需要平面。 您可以一次切割多个实体。"};
    public static readonly string[] AlongEdge = {
      "Along Edge",
      "Вдоль ребра",
      "Lungo la costola",
      "Entlang der Rippe",
      "沿边缘"};
    public static readonly string[] AlongEdgeTip = {
      "Arrange the cutting planes perpendicular to the edge of the solid. \r\n" +
        "It is required to specify a straight or curved edge and a point for constructing the starting plane. \r\n" +
        "In this mode, it is possible to cut only one solid to which the selected edge belongs.",
      "Расставить режущие плоскости перпендикулярно ребру солида. \r\n" +
        "Требуется задать прямое или кривое ребро и точку для построения стартовой плоскости. \r\n" +
        "В этом режиме можно разрезать только один солид, которому принадлежит выбранное ребро.",
      "Disporre i piani di taglio perpendicolarmente al bordo del solido. \r\n" +
        "È necessario specificare un bordo diritto o curvo e un punto per costruire il piano di partenza. \r\n" +
        "In questa modalità è possibile tagliare un solo solido a cui appartiene lo spigolo selezionato.",
      "Ordnen Sie die Schnittebenen senkrecht zur Kante des Volumenkörpers an. \r\n" +
        "Es ist erforderlich, eine gerade oder gekrümmte Kante und einen Punkt zum Konstruieren der Startebene anzugeben. \r\n" +
        "In diesem Modus ist es möglich, nur einen Volumenkörper zu schneiden, zu dem die ausgewählte Kante gehört.",
      "排列垂直于实体边缘的切割平面。 \r\n" +
        "需要指定一条直线或曲线的边缘和一个点来构建起始平面。 \r\n" +
        "在此模式下，只能切割所选边缘所属的单个实体。"};
    public static readonly string[] FixStep = {
      "Fixed step",
      "Фиксированный шаг",
      "Passo fisso",
      "Fester Schritt",
      "固定步骤"};
    public static readonly string[] FixStepTip = {
      "Set the exact value of the spacing of the cutting planes. \r\n" +
        "At the end of the solid, a stub may remain.",
      "Задать точное значение шага расстановки режущих плоскостей. \r\n" +
        "В конце солида может остаться обрезок.",
      "Impostare il valore esatto della spaziatura dei piani di taglio. \r\n" +
        "Alla fine del solido può rimanere uno scarto.",
      "Stellen Sie den genauen Wert des Abstands der Schnittebenen ein. \r\n" +
        "Am Ende des Festkörpers kann ein Schrott zurückbleiben.",
      "设置切割平面间距的精确值。 \r\n" +
        "在切割实体结束时，可能会留下多余实体。"};
    public static readonly string[] NumberOfPieces = {
      "Number of pieces",
      "Заданное число долек",
      "Numero di sezioni",
      "Stückzahl",
      "指定切片数"};
    public static readonly string[] NumberOfPiecesTip = {
      "Divide the solid into a given number of pieces. \r\n" +
        "The cutting pitch will be calculated. \r\n" +
        "Trimmings can only remain if there are parts of the solid outside the given edge.",
      "Разделить солид на заданное количество кусков. \r\n" +
        "Шаг резки будет вычислен. \r\n" +
        "Обрезки могут остаться, только если есть части солида за пределами заданного ребра.",
      "Dividi il solido in un dato numero di pezzi. \r\n" +
        "Verrà calcolato il passo di taglio. \r\n" +
        "I tagli possono rimanere solo se ci sono parti del solido al di fuori del dato bordo.",
      "Teilen Sie den Feststoff in eine bestimmte Anzahl von Stücken. \r\n" +
        "Die Schnittteilung wird berechnet. \r\n" +
        "Beschnitt kann nur verbleiben, wenn sich Teile des Volumenkörpers außerhalb der gegebenen Kante befinden.",
      "将固体分成给定数量的部分。 \r\n" +
        "将计算切割间距。 \r\n" +
        "如果有实体的部分在给定的边缘之外，则只能保留修剪。。"};
    public static readonly string[] NoLonger = {
      "No longer",
      "Не длиннее",
      "Non più di",
      "Nicht länger",
      "不超过"};
    public static readonly string[] NoLongerTip = {
      "Set the number of pieces so that the pieces are no longer than the given value. \r\n" +
        "The cutting step is calculated and will be less than or equal to the specified one. \r\n" +
        "Trimmings can only remain if there are parts of the solid outside the given edge.",
      "Задать количество кусков так, чтоб куски получились не длиннее чем заданное значение. \r\n" +
        "Шаг нарезки вычисляется и будет меньше или равен заданному. \r\n" +
        "Обрезки могут остаться, только если есть части солида за пределами заданного ребра.",
      "Impostare il numero di pezzi in modo che i pezzi non siano più lunghi del valore dato. \r\n" +
        "Il passo di taglio viene calcolato e sarà minore o uguale a quello specificato. \r\n" +
        "I tagli possono rimanere solo se ci sono parti del solido al di fuori del dato bordo.",
      "Stellen Sie die Stückzahl so ein, dass die Stücke nicht länger als der angegebene Wert sind. \r\n" +
        "Der Schnittschritt wird berechnet und ist kleiner oder gleich dem angegebenen. \r\n" +
        "Beschnitt kann nur verbleiben, wenn sich Teile des Volumenkörpers außerhalb der gegebenen Kante befinden.",
      "设置件数，使件数不超过给定值。 \r\n" +
        "切割步长被计算并且将小于或等于指定的步长。 \r\n" +
        "只有在给定边缘之外存在实体部分时，才能保留饰边。"};
    public static readonly string[] CleanRibs = {
      "Rib cleaning",
      "Чистка ребер",
      "Pulire le costole",
      "Rippenreinigung",
      "肋条清除"};
    public static readonly string[] CleanRibsTip = {
      "Delete unnecessary ribs not contacted with base edge. \r\n" +
        "Recommended for strongly bent edge.",
      "Удалять ненужные куски ребер, которые не касаются базовой кривой. \r\n" +
        "Рекомендуется для сильно изогнутых солидов.",
      "Rimuovere i pezzi di bordo non necessari che non toccano la curva di base. \r\n" +
        "Consigliato per solidi fortemente curvi.",
      "Löschen Sie unnötige Kantenstücke, die die Basiskurve nicht berühren. \r\n" +
        "Empfohlen für stark gekrümmte Volumenkörper.",
      "删除不与基础边缘接触的不必要的边。 \r\n" +
        "推荐用于高度弯曲的实体。"};
    public static readonly string[] Numbering = {
      "Numbering",
      "Нумеровать",
      "Dai numeri",
      "Nummerierung",
      "编号"};
    public static readonly string[] NumberingTip = {
      "Create names for any piece and ribs in order of cutting.\r\n" +
        "You can see names of solid using A>V>C> Property Palette.",
      "Для удобства сборки изделия можно дать имена всем отрезанным частям в порядке реза.\r\n" +
        "Имена солидов вы сможете увидеть только если вы установили плагин Палитра Свойств A>V>C>.",
      "Per comodità di assemblaggio del prodotto, puoi dare nomi a tutte le parti tagliate nell'ordine di taglio.\r\n" +
        "Puoi vedere i nomi dei solidi solo se hai installato il plugin Proprietà Palette A>V>C>. ",
      "Erstellen Sie Namen für jedes Stück und jede Rippe in der Reihenfolge des Schneidens.\r\n" +
         "Sie können Namen von Volumenkörpern mit A>V>C> Eigenschaftenpalette sehen.",
      "按切割顺序为任何部分和肋骨创建名称。\r\n" +
         "您可以使用 A>V>C> 属性面板查看实体的名称。"};
    public static readonly string[] MakeRib = {
      "Ribs",
      "Ребра (нервюры)",
      "Nervatura",
      "Rippen",
      "肋骨"};
    public static readonly string[] MakeRibTip = {
      "The solid will not just be cut, but ribs will be placed in those places where the secant planes pass.\r\n" +
      "The material thickness of the ribs is set in the Rib Thickness field.\r\n" +
      "This option can be useful for framing a curved structure like an arcuate bar counter.",
      "Солид будет не просто нарезан, а будут расставлены плоские ребра каркаса (нервюры) в тех местах, \r\n" +
      "где проходят секущие плоскости.\r\n" +
      "Толщина материала задается в поле Толщина Ребер.\r\n" +
      "Эта опция может быть удобна для формирования каркаса криволинейной конструкции,\r\n" +
      "типа дугообразной барной стойки.",
      "Il solido non verrà solo tagliato, ma verranno posizionate delle nervature nei punti in cui passano i piani di taglio.\r\n" +
      "Lo spessore del materiale della nervatura è specificato nel campo Spessore nervature.\r\n" +
      "Questa opzione può essere utile per formare lo scheletro di una struttura curva,\r\n" +
      "tipo di bancone bar ad arco.",
      "Der Körper wird nicht nur geschnitten, sondern es werden Rippen an den Stellen platziert, an denen die Sekanten verlaufen.\r\n" +
      "Die Materialstärke der Rippen wird im Feld Rippendicke eingestellt.\r\n" +
      "Diese Option kann nützlich sein, um eine geschwungene Struktur wie eine bogenförmige Bartheke einzurahmen.",
      "实体不仅会被切割，还会在割线经过的地方放置肋骨。\r\n" +
      "此选项可用于构建弧形吧台等弯曲结构。"};
    public static readonly string[] SaveGap = {
      "Save Gaps",
      "Сохранять зазоры",
      "Mantenere gli spazi liberi",
      "Lücken pflegen",
      "保留间距实体"};
    public static readonly string[] SaveGapTip = {
      "If the gap is greater than zero, then the program can save the pieces of solid remaining in the gaps.\r\n" +
         "In any case, no stepping function is applied to these pieces \r\n" +
        "and the layer remains the same as that of the original body.",
      "Если указаны зазор больше ноля, то программа  может сохранить куски солида, оставшиеся в зазорах.\r\n" +
        "В любом случае к этим кускам не применяется функция ступенчатости \r\n" +
        "и слой остается тот же, что и у исходного тела.",
      "Se lo spazio specificato è maggiore di zero, il programma può salvare \r\n" +
        "i pezzi di solido rimanenti negli spazi.\r\n" +
        "In ogni caso, la funzione stepping non viene applicata a questi pezzi \r\n" +
        "e lo strato rimane lo stesso del solido originale.",
      "Wenn die Lücke größer als Null ist, \r\n" +
        "kann das Programm die in den Lücken verbleibenden Festkörperstücke speichern.\r\n" +
         "In jedem Fall wird auf diese Teile keine Stepping-Funktion angewendet \r\n" +
        "und die Schicht bleibt die gleiche wie die des ursprünglichen Körpers.",
      "如果间距大于零，则程序可以保存间隙中剩余的实块。\r\n" +
         "在任何情况下，无论如何，这些块都不会应用步进功能，层次保持与原始体相同。"};
    public static readonly string[] SaveSource = {
      "Save Source",
      "Сохранять исходное",
      "Mantieni l'originale",
      "Quelle speichern",
      "保留源实体"};
    public static readonly string[] SaveSourceTip = {
      "Save source solid in drawing. " +
        "Piece and rib will create inside it.",
      "Сохранять нарезаемое тело в чертеже. " +
        "А дольки окажутся внутри него. ",
      "Mantieni il corpo tagliato nel disegno. " +
        "E le fette saranno dentro.",
      "Speichern Sie den geschnittenen Körper in der Zeichnung. " +
        "Und die Scheiben werden darin sein.",
      "将源切割体保留在图纸中。 " +
        "切片和肋骨将在其中创建。"};
    public static readonly string[] Stair = {
      "Stair step",
      "Ступенчатый",
      "Facendo un passo",
      "Treppenstufe",
      "阶梯状"};
    public static readonly string[] StairTip = {
      "When this option is enabled, the program will replace cut slices or ribs with flat parts with orthogonal ends.\r\n" +
         "That is, all slanted ends will be cut off.\r\n" +
         "Moreover, they are cut so that the new body will never protrude beyond the original.",
      "При включении этой опции программа будет подменять нарезанные дольки \r\n" +
        "или ребра на плоские детали с ортогональными торцами.\r\n" +
        "Т.е. все наклонные торцы будут срезаны.\r\n" +
        "Причем срезаны так, что новое тело нигде не будет выступать за пределы исходного. ",
      "Quando questa opzione è abilitata, il programma sostituirà le fette \r\n" +
        "\r\no le costolette su parti piane con estremità ortogonali.\r\n" +
        "Quelli. tutte le estremità inclinate verranno tagliate.\r\n" +
        "Inoltre, sono tagliati in modo che il nuovo corpo non sporga oltre l'originale da nessuna parte.",
      "Wenn diese Option aktiviert ist,\r\n" +
         "ersetzt das Programm geschnittene Scheiben oder Rippen durch flache Teile mit orthogonalen Enden.\r\n" +
         "Das heißt, alle schrägen Enden werden abgeschnitten.\r\n" +
         "Außerdem sind sie so geschnitten, dass die neue Karosserie niemals über die ursprüngliche hinausragt.",
      "启用此选项后，程序将用 具有正交末端的扁平部件替换切割切片或肋骨。\r\n" +
         "也就是说，所有倾斜的末端都将被切断(垂直)。\r\n" +
         "此外，它们被切割成新的实体不会超过源实体。"};
    public static readonly string[] StepOutward = {
      "Outward",
      "Наружу",
      "Verso l'esterno",
      "Nach außen",
      "向外"};
    public static readonly string[] StepOutwardTip = {
      "Make the steps outward of the original solid, then to whittle away them. \r\n" +
        "Usually the steps are made inside to putty them.",
      "Делать ступеньки наружу исходного солида. Чтоб можно было потом сточить напильником.\r\n" +
        "Обычно ступеньки делаются внутрь, чтоб их можно было зашпаклевать.",
      "Fai dei passi verso l'esterno del solido originale. In modo che tu possa poi macinare con un file.\r\n" +
        "Di solito i passaggi sono fatti verso l'interno in modo che possano essere stucco.",
      "Machen Sie Schritte außerhalb des ursprünglichen Volumenkörpers.\r\n" +
        "Damit Sie es später mit einer Feile abschleifen können.\r\n" +
         "Normalerweise werden die Stufen innen gemacht, damit sie gespachtelt werden können.",
      "在源实体之外制作台阶。 这样你以后就可以用工具把它削去。\r\n" +
         "通常这些台阶是在里面做的，这样方便填补。"};
    public static readonly string[] PieceLayer = {
      "Piece layer",
      "Слой деталей",
      "Layer di dettaglio",
      "Detailebene",
      "切片层"};
    public static readonly string[] PieceLayerTip = {
      "You can enter layer name for piece or rib. \r\n" +
        "Layer will created if it not exists.",
      "Слой, который будет назначен долькам/ребрам. \r\n" +
        "Можно оставить поле пустым. \r\n" +
        "Программа сама создаст слой при необходимости.",
      "Il livello da assegnare alle fette / costole.\r\n" +
        "Puoi lasciare il campo vuoto.\r\n" +
        "Se necessario, il programma creerà il livello stesso.",
      "Die Schicht, die den Scheiben/Rippen zugewiesen werden soll.\r\n" +
        "Sie können das Feld leer lassen.\r\n" +
         "Das Programm erstellt die Ebene bei Bedarf selbst.",
      "要分配给切片/肋骨的层。 您可以将该字段留空。\r\n" +
         "如有必要，程序将自行创建图层。"};
    public static readonly string[] Specify = {
      "Specify",
      "Указать",
      "Specificare",
      "Angeben",
      "指定" };
    public static readonly string[] SpecifyTip = {
      "Start cutting from the specified plane. \r\n" +
        "For curve cutting, the point of the first cut will be requested.",
      "Начинать нарезку с указанной плоскости. \r\n" +
        "Для нарезки по кривой будет запрошена точка первого разреза.",
      "Inizia a tagliare dal piano specificato. \r\n" +
        "Per il taglio curvo verrà richiesto il punto del primo taglio.",
      "Beginnen Sie mit dem Schneiden von der angegebenen Ebene. \r\n" +
        "Beim Kurvenschneiden wird der Punkt des ersten Schnitts abgefragt.",
      "从指定平面开始切割。 \r\n" +
        "对于曲线切割，将请求第一个切割点。" };
    public static readonly string[] Min = {
      "Minimum",
      "Минимум",
      "Minimo",
      "Minimum",
      "最低限度" };
    public static readonly string[] MinTip = {
      "Start cutting from the extreme point of the solid behind the specified plane \r\n" +
        "or from the nearest end of the specified edge.\r\n" +
        "The stub will remain at the far end of the solid.",
      "Начинать нарезку с крайней точки детали сзади указанной плоскости \r\n" +
        "или с ближайшего конца указанного ребра.\r\n" +
        "Обрезок останется в дальнем конце солида.",
      "Inizia a tagliare dal punto estremo del solido dietro il piano specificato \r\n" +
        "o dall'estremità più vicina del bordo specificato.\r\n" +
        "Lo stub rimarrà all'estremità del solido.",
      "Beginnen Sie mit dem Schneiden am äußersten Punkt des Volumenkörpers hinter der angegebenen Ebene \r\n" +
        "oder am nächstgelegenen Ende der angegebenen Kante.\r\n" +
        "Der Stummel bleibt am anderen Ende des Volumenkörpers.",
      "从指定平面后面实体的极值点或指定边缘的最近端开始切割。\r\n" +
        "切割将保留在实体的远端。" };
    public static readonly string[] Max = {
      "Maximum",
      "Максимум",
      "Massimo",
      "Maximum",
      "最大限度" };
    public static readonly string[] MaxTip = {
      "Start cutting from the extreme point of the part in front of the specified plane \r\n" +
        "or from the far end of the specified edge.\r\n" +
        "The stub will remain at the near end of the solid.",
      "Начинать нарезку с крайней точки детали перед указанной плоскостью \r\n" +
        "или с дальнего конца указанного ребра.\r\n" +
        "Обрезок останется в ближнем конце солида.",
      "Inizia a tagliare dal punto estremo della parte davanti al piano specificato \r\n" +
        "o dall'estremità più lontana del bordo specificato.\r\n" +
        "Lo stub rimarrà all'estremità vicina del solido.",
      "Beginnen Sie mit dem Schneiden am äußersten Punkt des Teils vor der angegebenen Ebene \r\n" +
        "oder am anderen Ende der angegebenen Kante." +
        "Der Stummel bleibt am nahen Ende des Volumenkörpers.",
      "从指定平面前面的零件极值点或指定边缘的远端开始切割。\r\n" +
        "切割将保留在实体的近端。" };
    public static readonly string[] Mid = {
      "Middle",
      "Середина",
      "Mezzo",
      "Mitte",
      "中间" };
    public static readonly string[] MidTip = {
      "Start cutting from the middle of the part \r\n" +
        "or from the midpoint of the specified edge.\r\n" +
        "The stub will remain at both ends of the solid.",
      "Начинать нарезку с середины детали \r\n" +
        "или со средней точки указанного ребра." +
        "Обрезки останутся с обоих концов солида.",
      "Inizia a tagliare dal centro della parte \r\n" +
        "o dal punto medio del bordo specificato.\r\n" +
        "Lo stub rimarrà su entrambe le estremità del solido.",
      "Beginnen Sie mit dem Schneiden in der Mitte des Teils \r\n" +
        "oder am Mittelpunkt der angegebenen Kante.\r\n" +
        "Der Stummel bleibt an beiden Enden des Volumenkörpers.",
      "从零件的中间或指定边的中点开始切割。\r\n" +
        "切割将保留在实体的两端。" };
    public static readonly string[] SaveStub = {
      "Save Stubs",
      "Сохранять обрезки",
      "Salva i ritagli",
      "Ausschnitte speichern",
      "保留残余"};
    public static readonly string[] SaveStubTip = {
      "Save stubs on end of source solid and between rib. \r\n" +
        "They can be used to cut thinner slices.",
      "Оставить в чертеже остатки от нарезки. \r\n" +
        "Их можно использовать для нарезки более тонкими ломтиками.",
      "Lascia i resti del taglio nel disegno. \r\n" +
        "Possono essere usati per tagliare a fette più sottili.",
      "Belassen Sie die Reste des Schnitts in der Zeichnung. \r\n" +
        "Sie können zum Schneiden in dünnere Scheiben verwendet werden.",
      "将切割的残余物留在图形中。 \r\n" +
        "它们可用共切成更薄的切片。"};
    public static readonly string[] StubLayer = {
      "Stub layer",
      "Слой обрезков",
      "Layer di scarto",
      "Schnittschicht",
      "残余层"};
    public static readonly string[] StubLayerTip = {
      "You can enter layer name for stub-solids. \r\n" +
        "Leave the field blank so that the clippings remain in the original layer.\r\n" +
        "Layer will created if it not exists.",
      "Можно назначить отдельный слой обрезкам.\r\n" +
        "Оставьте поле пустым, чтоб обрезки остались в исходном слое.\r\n" +
        "Программа сама создаст слой при необходимости.",
      "È possibile assegnare un livello separato agli scarti.\r\n" +
        "Lascia il campo vuoto per mantenere i ritagli nel livello originale.\r\n" +
        "Se necessario, il programma creerà il livello stesso.",
      "Sie können den Ausschnitten eine separate Ebene zuweisen. \r\n" +
        "Lassen Sie das Feld leer, damit die Ausschnitte in der ursprünglichen Ebene verbleiben.\r\n" +
        "Das Programm erstellt die Ebene bei Bedarf selbst.",
      "您可以为残余分配一个单独的图层。将该字段留空，以便残余实体保留在原图层中。\r\n" +
        "如果层不存在，将创建该层。"};
    public static readonly string[] Gap = {
      "Gap",
      "Зазор",
      "Gap",
      "Lücke",
      "间距"};
    public static readonly string[] GapTip = {
      "Gap thickness between slices.\r\n" +
         "You can use this gap to account for the thickness of the saw blade, \r\n" +
        "or to form a framework with gaps between the ribs.\r\n" +
         "If the gap is greater than zero, then the cutting step will be equal to the thickness of the slice plus this gap.",
      "Толщина зазора между ломтиками. \r\n" +
        "Вы можете использовать этот зазор для учета толщины пильного диска \r\n" +
        "или для формирования каркаса с зазорами между ребрами.\r\n" +
        "Если указан зазор больше нуля, то шаг нарезки будет равен толщине дольки плюс этот зазор. ",
      "Lo spessore dello spazio tra le fette.\r\n" +
        "È possibile utilizzare questo spazio per tenere conto dello spessore della lama della sega.\r\n" +
        "o per formare uno scheletro con spazi tra le costole.\r\n" +
        "Se la distanza specificata è maggiore di zero, \r\n" +
        "la fase di taglio sarà uguale allo spessore del cuneo più questa distanza.",
      "Die Dicke der Lücke zwischen den Slices.\r\n" +
        "Sie können diesen Spalt verwenden,\r\n" +
        "um die Dicke des Sägeblatts zu berücksichtigen \r\n" +
        "oder einen Rahmen mit Lücken zwischen den Rippen zu bilden.\r\n" +
        "Wenn die Lücke größer als Null ist, \r\n" +
        "entspricht der Schnittschritt der Dicke der Scheibe plus dieser Lücke.",
      "切片之间间隙的厚度。\r\n" +
        "你可以用这个间隙来设置成锯片的厚度，或者形成一个肋骨之间有间隙的框架。\r\n" +
        "“如果间隙大于零，那么切割步骤将等于切片的厚度加上这个间隙。"};
    public static readonly string[] RibThickness = {
      "Rib thickness",
      "Толщина ребер",
      "Spessore nervature",
      "Rippendicke",
      "肋骨厚度"};
    public static readonly string[] RibThicknessTip = {
      "Thickness of rib. The thickness should be greater than zero.",
      "Толщина ребер (нервюр). Должна быть обязательно больше 0.",
      "Lo spessore dei nervature. Deve essere maggiore di 0.",
      "Die Dicke der Rippen. Muss größer als 0 sein.",
      "肋骨的厚度。必须大于 0。"};
    public static readonly string[] ShowDlg = {
      "Show dialog",
      "Показ диалога",
      "Mostra il dialogo",
      "Dialog Show",
      "对话显示"};
    public static readonly string[] ShowDlgTip = {
      "Show settings-window any times command calling.",
      "Показывать диалог настроек при каждом вызове команд.",
      "Mostra la finestra di dialogo delle impostazioni ad ogni chiamata di comando.",
      "Einstellungsdialog jedes Mal anzeigen, wenn Befehle aufgerufen werden.",
      "每次调用命令时显示设置对话框。"};
    public static readonly string[] StepQuery = {
      "Request the step or number of pieces",
      "Запрашивать шаг или количество долек",
      "Richiedi la lunghezza o il numero di pezzi",
      "Fragen Sie die Länge oder Stückzahl an",
      "请求步长或片数"};
    public static readonly string[] StepQueryTip = {
      "Do I need to display a query for the slicing step every time? \r\n" +
        "Depending on the settings, the program will ask either a fixed step, or the number of pieces, \r\n" +
        "or the maximum length of the pieces. \r\n" +
        "If this option is disabled, then the pitch is taken from the preconfigured Chop-style. \r\n" +
        "In any case, there will be no request if the settings dialog is configured.",
      "Надо ли каждый раз выводить запрос шага нарезки? \r\n" +
        "В зависимости от настроек программа спросит либо фиксированный шаг, \r\n" +
        "либо количество долек, либо максимальную длину долек. \r\n" +
        "Если опция отключена, то шаг берется из предварительно настроенного стиля нарезки. \r\n" +
        "Запроса в любом случае не будет, если настроен показ диалога настроек.",
      "Devo visualizzare ogni volta una query per la fase di taglio? \r\n" +
        "A seconda delle impostazioni, il programma chiederà o un passo fisso, \r\n" +
        "o il numero di pezzi, o la lunghezza massima dei pezzi. \r\n" +
        "Se questa opzione è disabilitata, l'intonazione viene presa dallo stile preconfigurato. \r\n" +
        "In ogni caso, non ci sarà alcuna richiesta se la finestra di dialogo delle impostazioni è configurata.",
      "Muss ich jedes Mal eine Abfrage für den Slicing-Schritt anzeigen? \r\n" +
        "Abhängig von den Einstellungen fragt das Programm entweder einen festen Schritt, \r\n" +
        "oder die Stückzahl, oder die maximale Länge der Stücke. \r\n" +
        "Wenn diese Option deaktiviert ist, wird die Tonhöhe aus dem vorkonfigurierten Stil übernommen. \r\n" +
        "In jedem Fall erfolgt keine Abfrage, wenn der Einstellungsdialog konfiguriert ist.",
      "我是否需要每次都显示切片步骤的查询？ \r\n" +
        "根据设置，程序会询问实体步长，或块数，或块的最大长度。\r\n" +
        "如果此选项被禁用，将采用预配置的样式。\r\n" +
        "在任何情况下，如果配置了设置对话框，则不会有任何请求。"};
  }
}
