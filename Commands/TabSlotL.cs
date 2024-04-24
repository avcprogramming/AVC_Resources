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

    public static readonly string[] DepthTip = {
      "The parameter sets the tenon height and slot depth.\r\n" +
        "If you set it to 0, then the program will cut through the window instead of the slot. \r\n" +
        "A negative value specifies the remaining material thickness after slot milling,\r\n" +
        "and the depth will be calculated for each part as Part Thickness - |Depth|.\r\n",
      "Параметр задает длину шипа и глубину паза.\r\n" +
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

    public static readonly string[] MaxStep = {
      "Max step",
      "Максимальный шаг",
      "Passo massimo",
      "Maximaler Schritt",
      "最大步长"};

    public static readonly string[] MaxStepTip = {
      "The program always divides the joint into equal parts. \r\n" +
        "You can't set the exact tenon length - it is calculated individually for each joint.\r\n" +
        "But the length of each slot and stop should not exceed this value.",
      "Программа всегда делит стык на равные части. \r\n" +
        "Вы не можете задать точную длину шипа - она вычисляется индивидуально для каждого стыка.\r\n" +
        "Но длина каждого шипа и упора не должна превышать это значение.",
      "Il programma divide sempre il giunto in parti uguali. \r\n" +
        "Non è possibile impostare la lunghezza esatta del tenone: viene calcolata individualmente per ogni giunzione.\r\n" +
        "Ma la lunghezza di ogni picco e stop non deve superare questo valore.",
      "Das Programm teilt die Fuge immer in gleiche Teile. \r\n" +
        "Die exakte Zapfenlänge kann man nicht einstellen - sie wird für jedes Gelenk individuell berechnet.\r\n" +
        "Aber die Länge jeder Spitze und jedes Stopps sollte diesen Wert nicht überschreiten.",
      "程序总是将榫头分成相等的尺寸。 \r\n" +
        "您无法设置确切的榫齿尺寸 - 因为它是根据板长度独立计算的。\r\n" +
        "每个榫齿的尺寸不会超过此值。"};

    public static readonly string[] MinStepNum = {
      "Minimum number of steps",
      "Минимальное количество шагов",
      "Numero minimo di passaggi",
      "Minimale Anzahl von Schritten",
      "最小步长"};

    public static readonly string[] MinStepNumTip = {
      "Prevent the program from taking too few steps on short joint.",
      "Запретить программе делать слишком мало шагов на коротких стыках.",
      "Impedire al programma di fare pochi passi sulle cuciture corte.",
      "Verhindern Sie, dass das Programm bei kurzen Nähten zu wenige Schritte macht.",
      "防止接头上齿数偏少。"};

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
        "If the option is disabled, then the stop pad remains at the first step. \r\n" +
        "The setting is meaningless if the joint is divided into an even number of steps.",
      "На первом шаге делать шип и паз. \r\n" +
        "Если опция выключена, то на первом шаге остается упорная площадка. \r\n" +
        "Настройка не имеет смысла, если стык разделен на четное число шагов.",
      "Il primo passo è creare un maschio e femmina. \r\n" +
        "Se l'opzione è disabilitata, il pad di arresto rimane al primo passaggio. \r\n" +
        "L'impostazione non ha senso se la cucitura è divisa in un numero pari di passaggi.",
      "Der erste Schritt besteht darin, eine Nut und Feder zu machen. \r\n" +
        "Wenn die Option deaktiviert ist, bleibt das Stopp-Pad beim ersten Schritt. \r\n" +
        "Die Einstellung ist ohne Bedeutung, wenn die Naht in eine gerade Anzahl von Schritten unterteilt ist.",
      "第一步是盖板制作榫槽。 \r\n" +
        "如果该选项被禁用，则短板第一步是制作榫槽。 \r\n" +
        "如果榫齿数量被指定为偶数，此设置没有意义。"};

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
        "А если настроено 'Начинать с шипа', то с обоих концов будут сделаны шипы и пазы.",
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
