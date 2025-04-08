// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class
  TabSlotL
  {
    public static readonly string[,] TabSlotStyleNames = { 
/*0*/   { CommandL.TabSlot[0], CommandL.TabSlot[1], CommandL.TabSlot[2], CommandL.TabSlot[3], CommandL.TabSlot[4]  },
/*1*/   {
          "Through",
          "Сквозной",
          "Attraverso",
          "Durch" ,
          "通过" },
/*2*/   {
          "Blind slot",
          "Глухой паз",
          "Fessura cieca",
          "Blinder Schlitz" ,
          "盲槽" },
      };


    //======================= Dialog Box =============================================================

    public static readonly string[] StyleNameTip = {
      "The name for this TabSlot-style (set of settings). \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Название для этого стиля команды Шип-паз. \r\n" +
        "Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile TabSlot (set di impostazioni). \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen TabSlot-Stil (Satz von Einstellungen). \r\n" +
        "Wird im Programm nicht verwendet. Nur zur Bequemlichkeit der Wahl.",
      "此处只作为备注使用的名称。 \r\n" +
         "在程序中没有使用。只是为了方便阅读。"};

    public static readonly string[] Depth = {
      "Depth",
      "Глубина",
      "Profondità",
      "Standardtiefe",
      "默认深度" };

    public static readonly string[] DepthTip = {
      "The parameter sets the dado (slot) depth.\r\n" +
        "If you set it to 0, then the program will cut through the window instead of the slot. \r\n" +
        "A negative value specifies the remaining material thickness after slot milling,\r\n" +
        "and the depth will be calculated for each part as Part Thickness - |Depth|.\r\n",
      "Параметр задает глубину паза.\r\n" +
        "Если задать 0, то программа вырежет сквозное окно вместо паза. \r\n" +
        "Отрицательное значение задает оставшуюся толщину материала после фрезерования паза, \r\n" +
        "а глубина будет вычислена для каждой детали, как Толщина детали - |Глубина|.",
      "Il parametro imposta l'altezza del tenone e la profondità della fessura.\r\n" +
        "Se lo imposti su 0, il programma taglierà la finestra invece del solco. \r\n" +
        "Un valore negativo specifica lo spessore del materiale rimanente dopo la fresatura di cave,\r\n" +
        "e la profondità verrà calcolata per ciascuna parte come Spessore parte - |Profondità|.",
      "Der Parameter legt die Zapfenhöhe und Schlitztiefe fest.\r\n" +
        "Wenn Sie es auf 0 setzen, dann wird das Programm durch das Fenster statt durch die Rille schneiden. \r\n" +
        "Ein negativer Wert gibt die verbleibende Materialstärke nach dem Schlitzfräsen an,\r\n" +
        "und die Tiefe wird für jedes Teil als Teiledicke - |Tiefe| berechnet.",
      "该参数设置榫高度和槽深度。\r\n" +
         "如果你把它设置为 0，那么程序会贯穿槽孔。\r\n" +
         "负值是铣削后材料的剩余厚度。"};

    public static readonly string[] GapTip = {
      "Gap between details.\r\n" +
        "If you specify a value greater than 0, then the cut slot will be enlarged in all directions.\r\n" +
        "This will allow the tenon to slide freely into the slot without any effort.\r\n" +
        "Default 0.",
      "Зазор между деталями.\r\n" +
        "Если вы укажете значение больше 0, то вырезаемый паз будет увеличен во все стороны. \r\n" +
        "Это позволит шипу свободно входить в паз без усилий.\r\n" +
        "По умолчанию 0.",
      "Divario tra i dettagli.\r\n" +
        "Se si specifica un valore maggiore di 0, l'asola di taglio verrà ingrandita in tutte le direzioni.\r\n" +
         "Ciò consentirà al tenone di scivolare liberamente nella scanalatura senza alcuno sforzo.\r\n" +
        "Predefinito 0.",
      "Lücke zwischen Details.\r\n" +
        "Wenn Sie einen Wert größer als 0 angeben, wird der Schnittschlitz in alle Richtungen vergrößert.\r\n" +
        "Dadurch gleitet der Zapfen mühelos frei in die Nut.\r\n" +
        "Standard 0.",
      "开孔间隙。\r\n" +
        "如果你指定一个大于 0 的值，那么切割槽会向各个方向放大。\r\n" +
        "这将使榫头可以毫不费力插入凹槽中。\r\n" +
        "默认为 0。" };

    public static readonly string[] Backlash = {
      "Backlash",
      "Люфт",
      "Gioco",
      "Luft",
      "间隙"};

    public static readonly string[] BacklashTip = {
      "Backlash in the depth of the slot.\r\n" +
        "If you specify a value greater than 0, the tenon will be shortened. \r\n" +
        "This will allow for a tight fit of the parts, even if there are chips left in the slot.\r\n" +
        "The program does not sum Backlash and Gap, but the larger value is chosen.\r\n" +
        "Default 0.",
      "Люфт по глубине паза.\r\n" +
        "Если вы укажете значение больше 0, то шип будет укорочен. \r\n" +
        "Это позволит плотно стыковать детали, даже если в пазу остались опилки.\r\n" +
        "Программа не суммирует Люфт и Зазор, а выбирается большее значение.\r\n" +
        "По умолчанию 0.",
      "Gioco nella profondità della fessura.\r\n" +
        "Se si specifica un valore maggiore di 0, il tenone verrà accorciato. \r\n" +
        "Ciò consentirà un adattamento stretto delle parti, anche se ci sono trucioli rimasti nella fessura.\r\n" +
        "Il programma non somma Gioco e Divario, ma viene scelto il valore maggiore.\r\n" +
        "Predefinito 0.",
      "Luft in der Tiefe des Schlitzes.\r\n" +
        "Wenn Sie einen Wert größer 0 angeben, wird der Zapfen gekürzt. \r\n" +
        "Dies ermöglicht eine enge Passung der Teile, auch wenn sich Späne im Schlitz befinden.\r\n" +
        "Das Programm summiert nicht Luft und Spiel, sondern wählt den größeren Wert.\r\n" +
        "Standard 0.",
      "槽深度的间隙。\r\n" +
        "如果指定大于 0 的值，榫头将会缩短。\r\n" +
        "这将允许零件紧密配合，即使槽中有残留的碎屑。\r\n" +
        "程序不会将深度差距和各个方向的差距相加，而是选择一个较大的值。\r\n" +
        "默认为 0。"};

    public static readonly string[] MaxStep = {
      "Max step",
      "Максимальный шаг",
      "Passo massimo",
      "Maximaler Schritt",
      "最大步长"};

    public static readonly string[] MaxStepTip = {
      "Maximum allowable length of the gap (stop) between the tabs (tenons). \r\n" +
        "If the tab length is not specified, the tab will be exactly the same.\r\n" +
        "The entire joint (excluding the end stops) will be divided into equal steps.\r\n" +
        "If the joint is shorter than this value, one tab will be made for the entire joint, \r\n" +
        "ignoring the tab length setting.",
      "Максимально допустимая длина пробела (упора) между шипами. \r\n" +
        "Если не задана длина шипа, то шип буде точно такой же.\r\n" +
        "Весь стык (за исключением крайних упоров) будет разделен на равные шаги.\r\n" +
        "Если стык короче этого значения, то будет сделан один шип во весь стык, игнорируя настройку длины шипа.",
      "Lunghezza massima consentita dello spazio (fermo) tra i tenoni. \r\n" +
        "Se non viene specificata la lunghezza del tenone, il tenone sarà esattamente lo stesso.\r\n" +
        "L'intera giunzione (esclusi i fermi finali) sarà divisa in passi uguali.\r\n" +
        "Se la giunzione è più corta di questo valore, verrà realizzato un solo tenone per l'intera giunzione, \r\n" +
        "ignorando l'impostazione della lunghezza del tenone.",
      "Maximal zulässige Länge des Spalts (Anschlags) zwischen den Zapfen. \r\n" +
        "Wenn keine Zapfenlänge angegeben ist, ist der Zapfen genau gleich.\r\n" +
        "Die gesamte Verbindung (außer den Endanschlägen) wird in gleiche Schritte unterteilt.\r\n" +
        "Wenn die Verbindung kürzer als dieser Wert ist, wird ein Zapfen für die gesamte Verbindung hergestellt, \r\n" +
        "wobei die Zapfenlängeneinstellung ignoriert wird.",
      "榫头之间允许的最大间隙（止动）。\r\n" +
        "如果未指定榫头长度，则榫头长度相同。\r\n" +
        "整个接头（不包括末端止动）将被分成相等的步长。\r\n" +
        "如果接头短于此值，则将制作一个榫头以覆盖整个接头，忽略榫头长度设置。"};

    public static readonly string[] MinStepNum = {
      "Minimum number of steps",
      "Минимальное количество шагов",
      "Numero minimo di passaggi",
      "Minimale Anzahl von Schritten",
      "最小步长"};

    public static readonly string[] MinStepNumTip = {
      "Prevent the program from taking too few steps on short joints.\r\n" +
        "Both tabs and gaps between them (stops) are counted. End stops are not counted.\r\n" +
        "1 step will mean a solid tab for the entire joint.",
      "Запретить программе делать слишком мало шагов на коротких стыках.\r\n" +
        "Считаются и шипы, и пробелы между ними (упоры). Упоры по краям не считаются.\r\n" +
        "1 шаг будет означать цельный шип во весь стык.",
      "Impedire al programma di fare pochi passi sulle giunzioni corte.\r\n" +
        "Sia i tenoni che gli spazi tra di essi (fermi) sono conteggiati. I fermi finali non sono conteggiati.\r\n" +
        "1 passo significherà un tenone solido per l'intera giunzione.",
      "Verhindern Sie, dass das Programm bei kurzen Verbindungen zu wenige Schritte macht.\r\n" +
        "Sowohl die Zapfen als auch die Lücken zwischen ihnen (Anschläge) werden gezählt. \r\n" +
        "Endanschläge werden nicht gezählt.\r\n" +
        "1 Schritt bedeutet einen durchgehenden Zapfen für die gesamte Verbindung.",
      "防止程序在短接头上执行太少的步骤。\r\n" +
        "计算榫头和它们之间的间隙（止动）。末端止动不计算在内。\r\n" +
        "1 步将意味着整个接头的实心榫头。" };

    public static readonly string[] TabLength = {
      "Tab length",
      "Длина шипа",
      "Lunghezza del tenone",
      "Zapfenlänge",
      "榫头长度"};

    public static readonly string[] TabLengthTip = {
      "Fixed tab length. The slot will be larger by the gap. \r\n" +
        "If set to 0, the tab will be equal to the space (stop) and will vary on different joints, \r\n" +
        "but not longer than the maximum step.",
      "Фиксированная длина шипа. Паз будет больше на зазор. \r\n" +
        "Если назначить 0, то шип будет равен пробелу (упору) и будет меняться на разных стыках, \r\n" +
        "но не длиннее максимального шага.",
      "Lunghezza fissa del tenone. La fessura sarà più grande dello spazio. \r\n" +
        "Se impostato su 0, il tenone sarà uguale allo spazio (fermo) e varierà su giunzioni diverse, \r\n" +
        "ma non più lungo del passo massimo.",
      "Feste Zapfenlänge. Der Schlitz wird um den Spalt größer. \r\n" +
        "Wenn auf 0 gesetzt, ist der Zapfen gleich dem Spalt (Anschlag) und variiert bei verschiedenen Verbindungen, \r\n" +
        "aber nicht länger als der maximale Schritt.",
      "固定榫头长度。槽将因间隙而变大。\r\n" +
        "如果设置为 0，榫头将等于间隙（止动），并在不同的接头上变化，\r\n" +
        "但不超过最大步长。"};

    public static readonly string[] Start = {
      "Start pad",
      "Упоры по краям",
      "Fermi iniziali",
      "Anfangsanschläge",
      "起始垫片" };

    public static readonly string[] StartTip = {
      "Indent a fixed distance from both ends of the joint. \r\n" +
        "If set to more than 0, there will be a stop at the edge of all joints, not a tab/slot connection. \r\n" +
        "And this stop will not be the same size as the other spaces between the tabs. \r\n" +
        "The indent is made even if the connection starts with a space, \r\n" +
        "that is, the first space is simply increased to the tab.",
      "Отступить от обоих концов стыка фиксированное расстояние. \r\n" +
        "Если назначить больше 0, то на всех стыках с краю будет упор, а не соединение шип/паз. \r\n" +
        "И этот упор будет не такого размера как остальные пробелы между шипами. \r\n" +
        "Отступ делается даже если соединение начинается с пробела, \r\n" +
        "то есть просто увеличивается первый пробел до шипа.",
      "Indentare una distanza fissa da entrambe le estremità della giunzione. \r\n" +
        "Se impostato su più di 0, ci sarà un fermo al bordo di tutte le giunzioni, non una connessione maschio/femmina. \r\n" +
        "E questo fermo non sarà della stessa dimensione degli altri spazi tra i tenoni. \r\n" +
        "L'indentazione viene eseguita anche se la connessione inizia con uno spazio, \r\n" +
        "cioè il primo spazio viene semplicemente aumentato fino al tenone.",
      "Einen festen Abstand von beiden Enden der Verbindung einrücken. \r\n" +
        "Wenn auf mehr als 0 gesetzt, gibt es einen Anschlag am Rand aller Verbindungen, keine Zapfen/Nut-Verbindung. \r\n" +
        "Und dieser Anschlag wird nicht die gleiche Größe wie die anderen Lücken zwischen den Zapfen haben. \r\n" +
        "Der Einzug wird auch gemacht, wenn die Verbindung mit einer Lücke beginnt, \r\n" +
        "das heißt, die erste Lücke wird einfach auf den Zapfen vergrößert.",
      "从接头的两端缩进固定距离。\r\n" +
        "如果设置为大于 0，则在所有接头的边缘都会有一个止动，而不是榫/槽连接。\r\n" +
        "并且这个止动的尺寸不会与榫头之间的其他间隙相同。\r\n" +
        "即使连接从间隙开始，也会进行缩进，\r\n" +
        "即第一个间隙只是增加到榫头。"};

    public static readonly string[] MinArea = {
      "Minimum area",
      "Минимальная площадь",
      "Area minima",
      "Mindestfläche",
      "最小面积"};

    public static readonly string[] MinAreaTip = {
      "Do not process joints with an area smaller than the specified one. \r\n" +
        "It makes sense to adjust this value when the entire assembly is being processed at once.",
      "Не обрабатывать стыки площадью меньше заданной. \r\n" +
        "Имеет смысл настроить это значение, когда обрабатывается сразу вся сборка.",
      "Do not process joints with an area smaller than the specified one. \r\n" +
        "It makes sense to adjust this value when the entire assembly is being processed at once.",
      "Verarbeiten Sie keine Fugen mit einer kleineren Fläche als der angegebenen. \r\n" +
        "Es ist sinnvoll, diesen Wert anzupassen, wenn die gesamte Baugruppe auf einmal bearbeitet wird.",
      "小于此最小面积将不生成指接榫。 在一次处理多个指接榫时此值是有意义的。"};

    public static readonly string[] StartFromTab = {
      "Start with tab",
      "Начинать с шипа",
      "Inizia con un picco",
      "Beginnen Sie mit einer Spitze",
      "从盖板开始"};

    public static readonly string[] StartFromTabTip = {
      "The first step is to make a tab and slot. \r\n" +
        "If the option is disabled, then the stop pad remains at the first step.",
      "На первом шаге делать шип и паз. \r\n" +
        "Если опция выключена, то на первом шаге остается упорная площадка (пробел).",
      "Il primo passo è creare un maschio e femmina. \r\n" +
        "Se l'opzione è disabilitata, il pad di arresto rimane al primo passaggio.",
      "Der erste Schritt besteht darin, eine Nut und Feder zu machen. \r\n" +
        "Wenn die Option deaktiviert ist, bleibt das Stopp-Pad beim ersten Schritt.",
      "第一步是盖板制作榫槽。 \r\n" +
        "如果该选项被禁用，则短板第一步是制作榫槽。"};

    public static readonly string[] Odd = {
      "Odd number of steps",
      "Нечетное количество шагов",
      "Numero dispari di passaggi",
      "Ungerade Anzahl von Schritten",
      "奇数步数"};

    public static readonly string[] OddTip = {
      "Always divide the joint into an odd number of steps. \r\n" +
        "Then two stop pads will remain at both ends of the joint. \r\n" +
        "And if 'Start with tab' is set, then tenons and slot will be made at both ends.",
      "Всегда делить стык на нечетное число шагов. \r\n" +
        "Тогда с обоих концов стыка останутся две упорные площадки. \r\n" +
        "А если настроено 'Начинать с шипа', то с обоих концов будет сделаны шипы и пазы.",
      "Dividi sempre la cucitura in un numero dispari di passaggi. \r\n" +
        "Quindi due cuscinetti di spinta rimarranno su entrambe le estremità del giunto. \r\n" +
        "E se è impostato 'Inizia con tenone', i tenoni e le scanalature verranno eseguiti su entrambe le estremità.",
      "Teilen Sie die Naht immer in eine ungerade Anzahl von Schritten. \r\n" +
        "Dann verbleiben zwei Druckstücke an beiden Enden des Gelenks. \r\n" +
        "Und wenn „Mit Zapfen beginnen“ eingestellt ist, werden Zapfen und Nuten an beiden Enden hergestellt.",
      "始终将榫齿分成奇数个。 \r\n" +
        "两个榫齿将保留在接头的两端。 \r\n" +
        "如果设置了“从盖板开始”，则在盖板和短板之间切换凹槽和榫齿的顺序。"};
  }
}
