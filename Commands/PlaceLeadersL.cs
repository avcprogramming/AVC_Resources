// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  PlaceLeadersL
  {
    public static readonly string[] PLStyle = {
      "  PlaceLeader-style will be used: {0}",
      "  Будет использован стиль расстановки выносок: {0}",
      "  Verrà utilizzato lo stile PlaceLeaders: {0}",
      "  Der Stil „MLeader platzieren“ wird verwendet: {0}",
      "  将使用“放置标注”(PlaceLeaders)风格：{0}" };

    public static readonly string[] DefHidden = {
      "Hidden:\\P",
      "Невидимые:\\P",
      "Nascosto:\\P",
      "Versteckt:\\P",
      "隐: "};

    public static readonly string[] Select = {
      "  Select the objects from which you want to make MultiLeaders",
      "  Выберите объекты от которых надо сделать выноски (MLeader)",
      "  Seleziona gli oggetti da cui desideri eseguire i direttrice (MultiLeader)",
      "  Wählen Sie die Objekte aus, für die Sie Führungslinie (MultiLeader) erstellen möchten",
      "  选择要从中进行标注的对象 (MultiLeader)"};

    public static readonly string[] FindPoints = {
      "Search for visible points on details for arrows.",
      "Поиск видимых точек на деталях для стрелок",
      "Cerca punti visibili sui dettagli per le punte delle frecce.",
      "Suchen Sie nach sichtbaren Punkten auf Details für Pfeilspitzen.",
      "搜索箭头细节上的可见点。" };

    public static readonly string[] CreateLeaders = {
      "Creating MLeaders",
      "Создание выносок",
      "Creazione di direttrice",
      "Führungslinie erstellen",
      "标注创建" };

    public static readonly string[] DataSubstitution = {
      "Data substitution",
      "Подстановка данных",
      "Sostituzione dei dati",
      "Datenersetzung",
      "数据替换" };

    public static readonly string[] RemoveCount = {
      "  Removed {0} old leaders.",
      "  Удалено {0} старых выносок.",
      "  Rimossi {0} vecchi direttrice.",
      "  {0} alte Führungslinie entfernt.",
      "  删除了 {0} 个旧领导人。"};

    public static readonly string[] NoObjInViewport = {
      "No objects were found in the viewport",
      "Во вьюпорте не найдено ни одного объекта",
      "Nessun oggetto trovato nella finestra",
      "Im Ansichtsfenster wurden keine Objekte gefunden",
      "视口中未找到任何对象"};

    public static readonly string[] Empty = {
      "  For object {0}, an empty leader is obtained. Change the substitutions in the content template.",
      "  Для объекта {0} получилась пустая выноска. Поменяйте подстановки в шаблоне контента.",
      "  Per l'oggetto {0} si ottiene una direttrice vuota. Modifica le sostituzioni nel modello di contenuto.",
      "  Für Objekt {0} wird ein leerer Führungslinie erhalten. Ändern Sie die Ersetzungen in der Inhaltsvorlage.",
      "  对于对象 {0}，获得一个空的领导者。 更改内容模板中的替换。"};

    public static readonly string[] ViewSizeErr = {
      "Failed to get the dimensions of the multileader placement area",
      "Не удалось получить габариты области расстановки мультивыносок",
      "Impossibile ottenere le dimensioni dell'area di posizionamento della multidirettrice",
      "Die Abmessungen des Führungslinie-Platzierungsbereichs konnten nicht abgerufen werden",
      "获取多引线放置区域的尺寸失败"};

    public static readonly string[] ObjectSizeErr = {
      "Failed to get dimensions for {0}",
      "Не удалось получить габариты для {0}",
      "Impossibile ottenere le dimensioni per {0}",
      "Abmessungen für '{0}' konnten nicht abgerufen werden",
      "未能获取 '{0}' 的维度"};

    //========================================== Dialog Box =================================================================

    public static readonly string[] Format = {
      "Format for",
      "Формат для",
      "Formato per",
      "Das Format für",
      "格式为" };
    public static readonly string[] Step = {
      "Step",
      "Шаг",
      "Passo",
      "Schritt",
      "步"};
    public static readonly string[] StepTip = {
      "The vertical distance between leader texts. Enter 0 for the program to choose the step itself.",
      "Расстояние между текстами выносок по вертикали. Напишите 0, чтоб программа сама подобрала шаг.",
      "La distanza verticale tra i testi con più direttrici. Immettere 0 affinché il programma scelga il passaggio stesso.",
      "Der vertikale Abstand zwischen mehrzeiligen Texten. Geben Sie 0 ein, damit das Programm den Schritt selbst auswählt.",
      "多引线文本之间的垂直距离。 输入 0 让程序自行选择步骤。"};
    public static readonly string[] IncreaseStep = {
      "Increase step",
      "Увеличить шаг",
      "Aumentare il passo",
      "Schritt erhöhen",
      "增加步数"};
    public static readonly string[] IncreaseStepTip = {
      "Allow the program to increase the step to distribute multi-leaders across the entire height of the drawing.",
      "Разрешить программе увеличить шаг для распределения мульти-выносок по всей высоте чертежа.",
      "Consentire al programma di aumentare il passo per distribuire le multi direttrici lungo l'intera altezza del disegno.",
      "Lassen Sie das Programm den Schritt erhöhen, um Mehrfachlinien über die gesamte Höhe der Zeichnung zu verteilen.",
      "允许程序增加步骤以将多个引线分布在绘图的整个高度上。"};
    public static readonly string[] DelOld = {
      "Delete old multileaders",
      "Удалять старые выноски",
      "Elimina i vecchi direttrice",
      "Löschen Sie alte Führungslinie",
      "删除旧的多重领导者"};
    public static readonly string[] DelOldTip = {
      "Search for multileaders and texts created during the last run of the command and delete them",
      "Искать выноски и тексты, созданные при прошлом запуске команды, и удалять их",
      "Cerca multidirettrici e testi creati durante l'ultima esecuzione del comando ed eliminali",
      "Suchen Sie nach Führungslinie und Texten, \r\n" +
        "die während der letzten Ausführung des Befehls erstellt wurden, und löschen Sie sie",
      "搜索上次运行命令期间创建的多引线和文本并将其删除"};
    public static readonly string[] ArrowToDot = {
      "Replace arrow with dot",
      "Заменять стрелку на точку",
      "Sostituisci la freccia con il punto",
      "Pfeil durch Punkt ersetzen",
      "用点替换箭头"};
    public static readonly string[] ArrowToDotTip = {
      "For multi-leaders from the center of the part, which do not go from the contour of the part, \r\n" +
        "but from an empty space in the center of the part, replace the arrow with a circle.",
      "Для выносок от центра детали, которые идут не от контура детали, \r\n" +
        "а от пустого места в центре детали, заменять стрелку на кружочек",
      "Per le multidirettrici dal centro della parte, che non vanno dal contorno della parte, \r\n" +
        "ma da uno spazio vuoto al centro della parte, sostituire la freccia con un cerchio.",
      "Für Führungslinie aus der Mitte des Teils, die nicht aus der Kontur des Teils stammen, \r\n" +
        "sondern aus einem leeren Raum in der Mitte des Teils, ersetzen Sie den Pfeil durch einen Kreis",
      "对于从零件中心出发的多引线，不是从零件的轮廓出发，\r\n" +
        "而是从零件中心的空白处出发，将箭头替换为圆圈。"};
    public static readonly string[] FromCenter = {
      "From the center of the part",
      "От центра детали",
      "Dal centro della parte",
      "Von der Mitte des Teils",
      "从零件的中心"};
    public static readonly string[] FromCenterTip = {
      "If the geometric center of the part is visible, \r\n" +
        "then first of all make a multi-leader from the center.",
      "Если геометрический цент детали видимый, \r\n" +
        "то в первую очередь делать выноску от центра",
      "Se il centro geometrico della parte è visibile, \r\n" +
        "creare prima di tutto una multidirettrice dal centro.",
      "Wenn die geometrische Mitte des Teils sichtbar ist, \r\n" +
        "erstellen Sie zunächst eine Führungslinie von der Mitte aus.",
      "如果零件的几何中心是可见的，\r\n" +
        "那么首先从中心做一个多引线。"};
    public static readonly string[] FromEdge = {
      "From part edge",
      "От ребра детали",
      "Dal bordo parziale",
      "Von Teilkante",
      "从零件边缘"};
    public static readonly string[] FromEdgeTip = {
      "Search for visible points of the part in the middle of each of its edges",
      "Искать видимые точки детали в середине каждого ее ребра",
      "Cerca i punti visibili della parte al centro di ciascuno dei suoi bordi",
      "Suchen Sie nach sichtbaren Punkten des Teils in der Mitte jeder seiner Kanten",
      "在每个边缘的中间搜索零件的可见点"};
    public static readonly string[] FromVertex = {
      "From part vertex",
      "От угла детали",
      "Dal vertice della parte",
      "Von Teilscheitel",
      "从零件顶点"};
    public static readonly string[] FromVertexTip = {
      "Search for visible vertices (corners) and make multi-leaders from them",
      "Искать видимые вертексы (вершины) и делать выноски от них",
      "Cerca i vertici visibili (angoli) e crea multidirettrici da essi",
      "Suchen Sie nach sichtbaren Scheitelpunkten (Ecken) und erstellen Sie daraus Führungslinie",
      "搜索可见顶点（角）并从中创建多引线"};
    public static readonly string[] HiddenPartList = {
      "List of invisible parts",
      "Список невидимых деталей",
      "Elenco delle parti invisibili",
      "Liste der unsichtbaren Teile",
      "隐形零件清单"};
    public static readonly string[] HiddenPartListTip = {
      "Create a text with a list of parts for which no visible point was found",
      "Создать текст со списком деталей, для которых не нашлось ни одной видимой точки",
      "Crea un testo con un elenco di parti per le quali non è stato trovato alcun punto visibile",
      "Erstellen Sie einen Text mit einer Liste von Teilen, für die kein sichtbarer Punkt gefunden wurde",
      "使用未找到可见点的部件列表创建文本"};
    public static readonly string[] PlaceLeft = {
      "Place left",
      "Размещать слева",
      "Posto a sinistra",
      "Links platzieren",
      "向左放置"};
    public static readonly string[] PlaceLeftTip = {
      "Position multi-leader texts to the left of the view",
      "Располагать тексты выносок слева от вида",
      "Posiziona i testi con più direttrici a sinistra della vista",
      "Positionieren Sie Texte mit mehreren Führungslinien links von der Ansicht",
      "将多引线文本放置在视图的左侧"};
    public static readonly string[] PlaceRight = {
      "Place right",
      "Размещать справа",
      "Posto a destra",
      "Richtig platzieren",
      "正确放置"};
    public static readonly string[] PlaceRightTip = {
      "Position multi-leader texts to the right of the view",
      "Располагать тексты выносок справа от вида",
      "Posiziona i testi con più direttrici a sinistra della vista",
      "Positionieren Sie Texte mit mehreren Führungslinien links von der Ansicht",
      "将多引线文本放置在视图的左侧"};
    public static readonly string[] SameBlocks = {
      "Repeat on same blocks",
      "Повторять на одинаковых блоках",
      "Ripetere sugli stessi blocchi",
      "Wiederholen Sie auf denselben Blöcken",
      "在相同的块上重复"};
    public static readonly string[] SameBlocksTip = {
      "Make multi-leaders from all blocks, even if the block with the same name already has a leader. \r\n" +
        "If the option is disabled, then only one (first encountered) block will have a leader",
      "Делать выноски от всех блоков, даже если блок с таким же именем уже имеет выноску. \r\n" +
        "Если опция выключена, то выноска будет только у одного (первого попавшегося) блока",
      "Crea multidirettrici da tutti i blocchi, anche se il blocco con lo stesso nome ha già una direttrice. \r\n" +
        "Se l'opzione è disabilitata, solo un blocco (incontrato per la prima volta) avrà un leader",
      "Machen Sie Multi-Leader aus allen Blöcken, auch wenn der Block mit demselben Namen bereits einen Leader hat. \r\n" +
        "Wenn die Option deaktiviert ist, hat nur ein (zuerst gefundener) Block einen Vorspann",
      "从所有块中创建多个领导者，即使同名的块已经有领导者。 \r\n" +
        "如果该选项被禁用，那么只有一个（第一次遇到）块将有一个领导者"};
    public static readonly string[] SameObjects = {
      "Repeat on identical objects",
      "Повторять на одинаковых объектах",
      "Ripetere su oggetti identici",
      "Wiederholen Sie auf identischen Objekten",
      "重复相同的对象"};
    public static readonly string[] SameObjectsTip = {
      "Make multi-leaders from all parts, even if the same part already has a leader. \r\n" +
        "If the option is disabled, then only one (first found) part will have a multi-leader.",
      "Делать выноски от всех деталей, даже если такая же деталь уже имеет выноску. \r\n" +
        "Если опция выключена, то выноска будет только у одной (первой попавшейся) детали.",
      "Crea multidirettrici da tutte le parti, anche se la stessa parte ha già una direttrice. \r\n" +
        "Se l'opzione è disabilitata, solo una parte (trovata per prima) avrà una multidirettrice.",
      "Erstellen Sie Multi-Leader aus allen Teilen, auch wenn derselbe Teil bereits einen Leader hat. \r\n" +
        "Wenn die Option deaktiviert ist, hat nur ein (zuerst gefundenes) Teil eine Mehrfach-Führungslinie.",
      "从所有部分创建多个领导者，即使同一部分已经有领导者。 \r\n" +
        "如果该选项被禁用，那么只有一个（第一个找到的）零件将有一个多引线。"};


  }
}
