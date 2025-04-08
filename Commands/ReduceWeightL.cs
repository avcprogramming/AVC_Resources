// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class
  ReduceWeightL
  {
    public static readonly string[,] RWStyleNames = { 
/*0*/   {
        CommandL.ReduceW[0],
        CommandL.ReduceW[1],
        CommandL.ReduceW[2],
        CommandL.ReduceW[3],
        CommandL.ReduceW[4]  },
/*1*/   {
        "Window",
        "Окно",
        "Finestra",
        "Fenster" ,
        "窗户" },
/*2*/   {
        "Pocket",
        "Выборка",
        "Tasca",
        "Tasche" ,
        "口袋" },
      };

    public static readonly string[] Select = {
      "  Select the parts that need to be reduced in weight",
      "  Выберите детали, которые надо облегчить",
      "  Seleziona le parti che devono essere ridotte di peso",
      "  Wählen Sie die Teile aus, die im Gewicht reduziert werden müssen",
      "  选择需要减轻重量的部件"};

    public static readonly string[] SolidErr = {
      "Failed to get solid for editing",
      "Не удалось получить солид для редактирования",
      "Impossibile ottenere il solido per la modifica",
      "Solid zum Bearbeiten konnte nicht abgerufen werden",
      "无法进行编辑"};

    public static readonly string[] LayMatrixErr = {
      "It was not possible to measure the part to obtain the laying matrix.",
      "Не удалось обмерить деталь для получения матрицы выкладки",
      "Non è stato possibile misurare il pezzo per ottenere la matrice di posa.",
      "Eine Vermessung des Teils zur Gewinnung der Verlegematrize war nicht möglich.",
      "无法测量零件以获得铺设矩阵。"};

    public static readonly string[] AnalysisErr = {
      "Failed to analyze the part and get its contours.",
      "Не удалось проанализировать деталь и получить ее контуры.",
      "Impossibile analizzare la parte e ottenerne i contorni.",
      "Das Teil konnte nicht analysiert und seine Konturen abgerufen werden.",
      "未能分析零件并获得其轮廓。"};

    public static readonly string[] OffsetErr = {
      "Failed to get window outline. Perhaps the offset is too large.",
      "Не удалось получить контур окна. Возможно задан слишком большой отступ",
      "Impossibile ottenere il contorno della finestra. Forse l'offset è troppo grande.",
      "Fensterumriss konnte nicht abgerufen werden. Vielleicht ist der Versatz zu groß.",
      "获取窗口轮廓失败。 可能偏移量太大。"};

    public static readonly string[] RegionErr = {
      "Failed to create window region",
      "Не удалось создать регион окна",
      "Impossibile creare la regione della finestra",
      "Fensterbereich konnte nicht erstellt werden",
      "创建窗口区域失败"};

    public static readonly string[] DividedErr = {
      "The window was divided by jumpers into too small parts. There is no point in cutting such small windows.",
      "Окно разделилось перемычками на слишком мелкие части. Нет смысла вырезать такие маленькие окна.",
      "La finestra era divisa da ponticelli in parti troppo piccole. Non ha senso tagliare finestre così piccole.",
      "Das Fenster wurde durch Jumper in zu kleine Teile geteilt. Es hat keinen Sinn, so kleine Fenster zu schneiden.",
      "窗户被跳线分成太小的部分。 剪这么小的窗户是没有意义的。"};

    public static readonly string[] TooSmallWindowErr = {
      "The window is less offset. There is no point in cutting such small windows.",
      "Окно меньше отступа. Нет смысла вырезать такие маленькие окна.",
      "La finestra è meno rientrata. Non ha senso tagliare finestre così piccole.",
      "Das Fenster ist weniger eingerückt. Es hat keinen Sinn, so kleine Fenster zu schneiden.",
      "窗口缩进较少。 剪这么小的窗户是没有意义的。"};

    public static readonly string[] TooSmallSolidErr = {
      "The solid is too small to cut a window with a given offset. {0}",
      "Солид слишком мал, чтоб вырезать окно с заданным смещением. {0}",
      "Il solido è troppo piccolo per tagliare una finestra con un determinato offset. {0}",
      "Der Volumenkörper ist zu klein, um ein Fenster mit einem bestimmten Versatz zu schneiden. {0}",
      "实体太小，无法以给定的偏移量切割窗口。{0}"};

    public static readonly string[] ExtrudeErr = {
      "It was not possible to create a solid for subtraction. The window region is saved in the drawing.",
      "Не получилось создать солид для вычитания. Регион окна сохранен в чертеже.",
      "Non è stato possibile creare un solido per la sottrazione. La regione della finestra viene salvata nel disegno.",
      "Es war nicht möglich, einen Volumenkörper für die Subtraktion zu erstellen. Der Fensterbereich wird in der Zeichnung gespeichert.",
      "不可能为减法创建实体。 窗口区域保存在图形中。"};

    public static readonly string[] JumperErr = {
      "Jumper spacing {0} is too small for jumper width {1}",
      "Шаг расстановки перемычек {0} слишком мал для перемычек шириной {1}",
      "La spaziatura del ponticello {0} è troppo piccola per la larghezza del ponticello {1}",
      "Jumperabstand {0} ist zu klein für Jumperbreite {1}",
      "跳线间距 {0} 对于跳线宽度 {1} 来说太小"};

    public static readonly string[] SkipSmallWindowInfo = {
      "Part of the window will not be cut because it is too small",
      "Отдельная часть окна не будет вырезана, так как она слишком мелкая",
      "Parte della finestra non verrà tagliata perché troppo piccola",
      "Ein Teil des Fensters wird nicht geschnitten, da es zu klein ist",
      "部分窗口不会被切割，因为它太小了"};

    //======================= Dialog Box =============================================================

    public static readonly string[] StyleNameTip = {
      "The name for this reduce-style (set of settings). \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Название для этого стиля команды Уменьшения веса. \r\n" +
        "Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile ReduceW (set di impostazioni). \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen ReduceW-Stil (Satz von Einstellungen). \r\n" +
        "Wird im Programm nicht verwendet. Nur zur Bequemlichkeit der Wahl.",
      "这种重量损失命令样式的名称。 \r\n" +
        "程序中未使用。 仅为方便起见。"};

    public static readonly string[] Offset = {
      "Offset",
      "Отступ",
      "Offset",
      "Versatz",
      "抵消"};

    public static readonly string[] OffsetTip = {
      "The width of the strip of material to be left around the edge \r\n" +
        "of the part after the window has been cut. \r\n" +
        "The same width is used for jumpers.",
      "Ширина полосы материала, которую надо оставить по краю детали после вырезания окна. \r\n" +
        "Эта же ширина используется для перемычек.",
      "La larghezza della striscia di materiale da lasciare attorno al bordo della parte \r\n" +
        "dopo che la finestra è stata tagliata. La stessa larghezza viene utilizzata per i maglioni.",
      "Die Breite des Materialstreifens, der nach dem Schneiden des Fensters um \r\n" +
        "die Kante des Teils verbleibt. Die gleiche Breite wird für Jumper verwendet.",
      "窗口被切割后留在零件边缘周围的材料条的宽度。 \r\n" +
        "跳线使用相同的宽度。"};

    public static readonly string[] PocketDepth = {
      "Pocket Depth",
      "Глубина выборки",
      "Profondità tascabile",
      "Taschentiefe",
      "口袋深度"};

    public static readonly string[] DepthTip = {
      "Specify how much material to remove.\r\n" +
        "If you set it to 0, then the program will cut through the window.\r\n" +
        "The selection is cut from the back of the part, keeping the front side.\r\n" +
        "A negative value specifies the remaining material thickness after milling,\r\n" +
        "and the depth will be calculated for each part as Part Thickness - |Depth|.\r\n" +
        "You can help the program choose the front side with a color label.",
      "Укажите сколько материала надо удалить. \r\n" +
        "Если задать 0, то программа вырежет сквозное окно. \r\n" +
        "Отрицательное значение задает оставшуюся толщину материала после фрезерования, \r\n" +
        "а глубина будет вычислена для каждой детали, как Толщина детали - |Глубина|.\r\n" +
        "Выборка вырезается сзади детали, сохраняя фасадную сторону.\r\n" +
        "Вы можете помочь программе выбрать фасадную сторону с помощью цветовой метки.",
      "Specifica quanto materiale rimuovere.\r\n" +
         "Se lo imposti a 0, il programma taglierà la finestra.\r\n" +
         "La selezione viene tagliata dal retro del pezzo, mantenendo il lato anteriore.\r\n" +
        "Un valore negativo specifica lo spessore rimanente del materiale dopo la fresatura\r\n" +
        "e la profondità verrà calcolata per ciascuna parte come Spessore parte - |Profondità|.\r\n" +
         "Puoi aiutare il programma a scegliere il lato anteriore con un'etichetta colorata.",
      "Geben Sie an, wie viel Material entfernt werden soll.\r\n" +
         "Wenn Sie es auf 0 setzen, wird das Programm das Fenster durchschneiden.\r\n" +
        "Ein negativer Wert gibt die Restdicke des Materials nach dem Fräsen an,\r\n" +
        "und die Tiefe wird für jedes Teil als Teiledicke - |Tiefe| berechnet.\r\n" +
         "Die Auswahl wird von der Rückseite des Teils geschnitten, wobei die Vorderseite erhalten bleibt.\r\n" +
         "Sie können dem Programm mit einem Farbetikett helfen, die Vorderseite auszuwählen.",
      "指定要去除多少材料。\r\n" +
         "如果你把它设置为 0，那么程序会切穿窗口。\r\n" +
         "负值指定铣削后材料的剩余厚度，每个零件的深度将计算为零件厚度 - |深度|。\r\n" +
         "选择是从零件的背面切割的，保留正面。\r\n" +
         "你可以帮助程序选择带有颜色标签的正面。"};

    public static readonly string[] Jumper = {
      "Jumpers Step",
      "Шаг перемычек",
      "Passo del ponticello",
      "Jumper-Pitch",
      "跳投间距"};

    public static readonly string[] JumperTip = {
      "The maximum allowed window size.\r\n" +
         "If the window turns out to be larger than this size, then the program should leave a jumper for strength.\r\n" +
         "Jumpers are placed in an X and Y grid on a part laid out according to the rules of the LAY command.\r\n" +
         "If jumpers are not needed, then set the value to 0.\r\n" +
         "But jumpers to holes and slots will be made regardless of this setting.",
      "Максимально допустимый размер окна.\r\n" +
        "Если окно получается больше этого размера, то программа должна оставить перемычку для прочности.\r\n" +
        "Перемычки расставляются сеткой по X и по Y на детали, выложенной по правилам команды Вкладки (LAY).\r\n" +
        "Если перемычки не нужны, то задайте значение 0.\r\n" +
        "Но перемычки к отверстиям и пазам будут сделаны независимо от этой настройки.",
      "La dimensione massima consentita della finestra.\r\n" +
         "Se la finestra risulta essere più grande di queste dimensioni, il programma dovrebbe lasciare un ponticello per forza.\r\n" +
         "I ponticelli sono posizionati in una griglia X e Y su una parte disposta secondo le regole del comando LAY.\r\n" +
         "Se i ponticelli non sono necessari, impostare il valore su 0.\r\n" +
         "Ma i ponticelli per i fori e le fessure verranno realizzati indipendentemente da questa impostazione.",
      "Die maximal zulässige Fenstergröße.\r\n" +
         "Wenn sich herausstellt, dass das Fenster größer als diese Größe ist, sollte das Programm einen Jumper für die Stärke hinterlassen.\r\n" +
         "Jumper werden in einem X- und Y-Gitter auf einem Teil platziert, das gemäß den Regeln des LAY-Befehls ausgelegt ist.\r\n" +
         "Wenn Jumper nicht benötigt werden, setzen Sie den Wert auf 0.\r\n" +
         "Aber Jumper zu Löchern und Slots werden unabhängig von dieser Einstellung gemacht.",
      "允许的最大窗口大小。\r\n" +
         "如果窗口结果大于这个大小，那么程序应该留下一个跳线来增强力量。\r\n" +
         "跳线放置在根据 LAY 命令规则布局的零件上的 X 和 Y 网格中。\r\n" +
         "如果不需要跳线，则将值设置为 0。\r\n" +
         "但是无论这种设置如何，都会跳线到孔和槽。"};

  }
}
