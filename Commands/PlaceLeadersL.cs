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
      "  Der Stil 'MLeader platzieren' wird verwendet: {0}",
      "  将使用'放置标注'(PlaceLeaders)风格：{0}",
      "  Se utilizará el estilo PlaceLeader: {0}",      // ES
      "  Le style PlaceLeader sera utilisé : {0}",      // FR
      "  PlaceLeader stili kullanılacak: {0}" };        // TR

    public static readonly string[] DefHidden = {
      "Hidden:\\P",
      "Невидимые:\\P",
      "Nascosto:\\P",
      "Versteckt:\\P",
      "隐: ",
      "Ocultos:\\P",                                    // ES
      "Masqués:\\P",                                    // FR
      "Gizli:\\P"};                                     // TR

    public static readonly string[] Select = {
      "  Select the objects from which you want to make MultiLeaders",
      "  Выберите объекты от которых надо сделать выноски (MLeader)",
      "  Seleziona gli oggetti da cui desideri eseguire i direttrice (MultiLeader)",
      "  Wählen Sie die Objekte aus, für die Sie Führungslinie (MultiLeader) erstellen möchten",
      "  选择要从中进行标注的对象 (MultiLeader)",
      "  Seleccione los objetos desde los que desea crear directrices múltiples (MultiLeader)",  // ES
      "  Sélectionnez les objets à partir desquels vous souhaitez créer des lignes de repère multiples (MultiLeader)",  // FR
      "  Çoklu açıklama çizgileri (MultiLeader) oluşturmak istediğiniz nesneleri seçin"};  // TR

    public static readonly string[] FindPoints = {
      "Search for visible points on details for arrows.",
      "Поиск видимых точек на деталях для стрелок",
      "Cerca punti visibili sui dettagli per le punte delle frecce.",
      "Suchen Sie nach sichtbaren Punkten auf Details für Pfeilspitzen.",
      "搜索箭头细节上的可见点。",
      "Buscar puntos visibles en los detalles para las flechas.",  // ES
      "Rechercher des points visibles sur les détails pour les flèches.",  // FR
      "Oklar için ayrıntılarda görünür noktaları arayın." };  // TR

    public static readonly string[] CreateLeaders = {
      "Creating MLeaders",
      "Создание выносок",
      "Creazione di direttrice",
      "Führungslinie erstellen",
      "标注创建",
      "Creando directrices múltiples",                 // ES
      "Création de lignes de repère multiples",        // FR
      "Çoklu açıklama çizgileri oluşturuluyor" };      // TR

    public static readonly string[] RemoveCount = {
      "  Removed {0} old leaders.",
      "  Удалено {0} старых выносок.",
      "  Rimossi {0} vecchi direttrice.",
      "  {0} alte Führungslinie entfernt.",
      "  删除了 {0} 个旧领导人。",
      "  Se eliminaron {0} directrices antiguas.",      // ES
      "  {0} anciennes lignes de repère supprimées.",   // FR
      "  {0} eski açıklama çizgisi kaldırıldı."};      // TR

    public static readonly string[] NoObjInViewport = {
      "No objects were found in the viewport",
      "Во вьюпорте не найдено ни одного объекта",
      "Nessun oggetto trovato nella finestra",
      "Im Ansichtsfenster wurden keine Objekte gefunden",
      "视口中未找到任何对象",
      "No se encontraron objetos en la ventana gráfica",  // ES
      "Aucun objet trouvé dans la fenêtre",            // FR
      "Görünüm penceresinde hiçbir nesne bulunamadı"}; // TR

    public static readonly string[] Empty = {
      "  For object {0}, an empty leader is obtained. Change the substitutions in the content template.",
      "  Для объекта {0} получилась пустая выноска. Поменяйте подстановки в шаблоне контента.",
      "  Per l'oggetto {0} si ottiene una direttrice vuota. Modifica le sostituzioni nel modello di contenuto.",
      "  Für Objekt {0} wird ein leerer Führungslinie erhalten. Ändern Sie die Ersetzungen in der Inhaltsvorlage.",
      "  对于对象 {0}，获得一个空的领导者。 更改内容模板中的替换。",
      "  Para el objeto {0}, se obtuvo una directriz vacía. Cambie las sustituciones en la plantilla de contenido.",  // ES
      "  Pour l'objet {0}, une ligne de repère vide est obtenue. Modifiez les substitutions dans le modèle de contenu.",  // FR
      "  {0} nesnesi için boş bir açıklama çizgisi elde edildi. İçerik şablonundaki değiştirmeleri değiştirin."};  // TR

    public static readonly string[] ViewSizeErr = {
      "Failed to get the dimensions of the multileader placement area",
      "Не удалось получить габариты области расстановки мультивыносок",
      "Impossibile ottenere le dimensioni dell'area di posizionamento della multidirettrice",
      "Die Abmessungen des Führungslinie-Platzierungsbereichs konnten nicht abgerufen werden",
      "获取多引线放置区域的尺寸失败",
      "No se pudieron obtener las dimensiones del área de colocación de directrices múltiples",  // ES
      "Échec de l'obtention des dimensions de la zone de placement des lignes de repère multiples",  // FR
      "Çoklu açıklama çizgisi yerleştirme alanının boyutları alınamadı"};  // TR

    public static readonly string[] SpaceErr = {
      "Unable to get block space for inserting multileaders",
      "Не удалось получить блок-пространство для вставки мультивыносок",
      "Impossibile ottenere lo spazio di blocco per l'inserimento di multileader",
      "Es kann kein Blockplatz zum Einfügen von Multileadern abgerufen werden.",
      "无法获得用于插入多重引线的块空间",
      "No se puede obtener el espacio de bloque para insertar directrices múltiples",  // ES
      "Impossible d'obtenir l'espace de bloc pour insérer des lignes de repère multiples",  // FR
      "Çoklu açıklama çizgileri eklemek için blok alanı alınamıyor"};  // TR

    public static readonly string[] ObjectSizeErr = {
      "Failed to get dimensions for {0}",
      "Не удалось получить габариты для {0}",
      "Impossibile ottenere le dimensioni per {0}",
      "Abmessungen für '{0}' konnten nicht abgerufen werden",
      "未能获取 '{0}' 的维度",
      "No se pudieron obtener las dimensiones para {0}",  // ES
      "Échec de l'obtention des dimensions pour {0}",  // FR
      "{0} için boyutlar alınamadı"};                  // TR

    public static readonly string[] FindInViewport = {
      "  Searching for objects in the viewport...",
      "  Поиск объектов во вьюпорте...",
      "  Ricerca di oggetti nella finestra...",
      "  Suche nach Objekten im Ansichtsfenster...",
      "  在视口中搜索对象...",
      "  Buscando objetos en la ventana gráfica...",    // ES
      "  Recherche d'objets dans la fenêtre...",        // FR
      "  Görünüm penceresinde nesneler aranıyor..." };  // TR

    public static readonly string[] FoundInViewport = {
      "  Objects found in viewport {0}",
      "  Найдено объектов во вьюпорте {0}",
      "  Oggetti trovati nella finestra {0}",
      "  Objekte im Ansichtsfenster {0} gefunden",
      "  在视口 {0} 中找到对象",
      "  Objetos encontrados en la ventana gráfica {0}",  // ES
      "  Objets trouvés dans la fenêtre {0}",           // FR
      "  Görünüm penceresinde {0} nesne bulundu" };     // TR

    //========================================== Dialog Box =================================================================

    public static readonly string[] Format = {
      "Format for",
      "Формат для",
      "Formato per",
      "Das Format für",
      "格式为",
      "Formato para",                                  // ES
      "Format pour",                                   // FR
      "İçin format" };                                 // TR

    public static readonly string[] Step = {
      "Step",
      "Шаг",
      "Passo",
      "Schritt",
      "步",
      "Paso",                                          // ES
      "Pas",                                           // FR
      "Adım"};                                         // TR

    public static readonly string[] StepTip = {
      "The vertical distance between leader texts. Enter 0 for the program to choose the step itself.",
      "Расстояние между текстами выносок по вертикали. Напишите 0, чтоб программа сама подобрала шаг.",
      "La distanza verticale tra i testi con più direttrici. Immettere 0 affinché il programma scelga il passaggio stesso.",
      "Der vertikale Abstand zwischen mehrzeiligen Texten. Geben Sie 0 ein, damit das Programm den Schritt selbst auswählt.",
      "多引线文本之间的垂直距离。 输入 0 让程序自行选择步骤。",
      "La distancia vertical entre los textos de directrices. Ingrese 0 para que el programa elija el paso automáticamente.",  // ES
      "La distance verticale entre les textes de lignes de repère. Entrez 0 pour que le programme choisisse le pas automatiquement.",  // FR
      "Açıklama çizgisi metinleri arasındaki dikey mesafe. Programın adımı kendisinin seçmesi için 0 girin."};  // TR

    public static readonly string[] Horizontally = {
      "Opposite the arrow",
      "Напротив стрелки",
      "Di fronte alla freccia",
      "Gegenüber dem Pfeil",
      "箭头相对",
      "Frente a la flecha",                            // ES
      "En face de la flèche",                          // FR
      "Okun karşısında"};                              // TR

    public static readonly string[] HorizontallyTip = {
      "Position multi-leader texts horizontally opposite the arrow. \r\n" +
        "If the space is occupied, then place it below with an indent of no less than the specified step.",
      "Располагать тексты выносок горизонтально напротив стрелки. \r\n" +
        "Если место занято, то размещать ниже с отступом не меньше чем заданный шаг.",
      "Posiziona i testi con più direttrici orizzontalmente di fronte alla freccia. \r\n" +
        "Se lo spazio è occupato, posizionarlo sotto con un rientro non inferiore al passo specificato.",
      "Positionieren Sie mehrzeilige Texte horizontal gegenüber dem Pfeil. \r\n" +
        "Wenn der Platz belegt ist, platzieren Sie ihn unten mit einem Einzug von mindestens dem angegebenen Schritt.",
      "将多引线文本水平放置在箭头的对面。如果空间已被占用，则将其放在下面，缩进量不小于指定的步骤。",
      "Posicione los textos de directrices múltiples horizontalmente frente a la flecha. \r\n" +  // ES
        "Si el espacio está ocupado, colóquelo debajo con una sangría no menor que el paso especificado.",
      "Positionnez les textes de lignes de repère multiples horizontalement en face de la flèche. \r\n" +  // FR
        "Si l'espace est occupé, placez-le en dessous avec un retrait au moins égal au pas spécifié.",
      "Çoklu açıklama çizgisi metinlerini okun karşısında yatay olarak konumlandırın. \r\n" +  // TR
        "Alan doluysa, belirtilen adımdan az olmayan bir girintiyle aşağı yerleştirin."};

    public static readonly string[] IncreaseStep = {
      "Increase step",
      "Увеличить шаг",
      "Aumentare il passo",
      "Schritt erhöhen",
      "增加步数",
      "Aumentar paso",                                 // ES
      "Augmenter le pas",                              // FR
      "Adımı artır"};                                  // TR

    public static readonly string[] IncreaseStepTip = {
      "Allow the program to increase the step to distribute multi-leaders across the entire height of the drawing.",
      "Разрешить программе увеличить шаг для распределения мульти-выносок по всей высоте чертежа.",
      "Consentire al programma di aumentare il passo per distribuire le multi direttrici lungo l'intera altezza del disegno.",
      "Lassen Sie das Programm den Schritt erhöhen, um Mehrfachlinien über die gesamte Höhe der Zeichnung zu verteilen.",
      "允许程序增加步骤以将多个引线分布在绘图的整个高度上。",
      "Permitir que el programa aumente el paso para distribuir las directrices múltiples en toda la altura del dibujo.",  // ES
      "Permettre au programme d'augmenter le pas pour distribuer les lignes de repère multiples sur toute la hauteur du dessin.",  // FR
      "Programın çoklu açıklama çizgilerini çizimin tüm yüksekliğine dağıtmak için adımı artırmasına izin verin."};  // TR

    public static readonly string[] DelOld = {
      "Delete old multileaders",
      "Удалять старые выноски",
      "Elimina i vecchi direttrice",
      "Löschen Sie alte Führungslinie",
      "删除旧的多重领导者",
      "Eliminar directrices múltiples antiguas",       // ES
      "Supprimer les anciennes lignes de repère multiples",  // FR
      "Eski çoklu açıklama çizgilerini sil"};          // TR

    public static readonly string[] DelOldTip = {
      "Search for multileaders and texts created during the last run of the command and delete them",
      "Искать выноски и тексты, созданные при прошлом запуске команды, и удалять их",
      "Cerca multidirettrici e testi creati durante l'ultima esecuzione del comando ed eliminali",
      "Suchen Sie nach Führungslinie und Texten, \r\n" +
        "die während der letzten Ausführung des Befehls erstellt wurden, und löschen Sie sie",
      "搜索上次运行命令期间创建的多引线和文本并将其删除",
      "Buscar directrices múltiples y textos creados durante la última ejecución del comando y eliminarlos",  // ES
      "Rechercher les lignes de repère multiples et les textes créés lors de la dernière exécution de la commande et les supprimer",  // FR
      "Komutun son çalıştırılmasında oluşturulan çoklu açıklama çizgilerini ve metinleri arayın ve silin"};  // TR

    public static readonly string[] ArrowToDot = {
      "Replace arrow with dot",
      "Заменять стрелку на точку",
      "Sostituisci la freccia con il punto",
      "Pfeil durch Punkt ersetzen",
      "用点替换箭头",
      "Reemplazar flecha con punto",                   // ES
      "Remplacer la flèche par un point",              // FR
      "Oku nokta ile değiştir"};                       // TR

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
        "而是从零件中心的空白处出发，将箭头替换为圆圈。",
      "Para las directrices múltiples desde el centro de la pieza, que no parten del contorno de la pieza, \r\n" +  // ES
        "sino de un espacio vacío en el centro de la pieza, reemplace la flecha con un círculo.",
      "Pour les lignes de repère multiples depuis le centre de la pièce, qui ne partent pas du contour de la pièce, \r\n" +  // FR
        "mais d'un espace vide au centre de la pièce, remplacez la flèche par un cercle.",
      "Parçanın merkezinden gelen, parçanın konturundan değil, \r\n" +  // TR
        "parçanın merkezindeki boş bir alandan gelen çoklu açıklama çizgileri için oku bir daire ile değiştirin."};

    public static readonly string[] FromCenter = {
      "From the center of the part",
      "От центра детали",
      "Dal centro della parte",
      "Von der Mitte des Teils",
      "从零件的中心",
      "Desde el centro de la pieza",                   // ES
      "Depuis le centre de la pièce",                  // FR
      "Parçanın merkezinden"};                         // TR

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
        "那么首先从中心做一个多引线。",
      "Si el centro geométrico de la pieza es visible, \r\n" +  // ES
        "entonces primero haga una directriz múltiple desde el centro.",
      "Si le centre géométrique de la pièce est visible, \r\n" +  // FR
        "alors faites d'abord une ligne de repère multiple depuis le centre.",
      "Parçanın geometrik merkezi görünüyorsa, \r\n" +  // TR
        "önce merkezden bir çoklu açıklama çizgisi yapın."};

    public static readonly string[] FromFace = {
      "From part face",
      "От поверхности детали",
      "Dalla superficie della parte",
      "Von der Oberfläche",
      "从零件表面",
      "Desde la cara de la pieza",                     // ES
      "Depuis la face de la pièce",                    // FR
      "Parça yüzeyinden"};                             // TR

    public static readonly string[] FromFaceTip = {
      "Look for visible points of the part in the middle and near the middle of each of its surfaces",
      "Искать видимые точки детали в середине и около середины каждой ее грани (поверхности)",
      "Cerca i punti visibili della parte al centro e vicino al centro di ciascuna delle sue superfici",
      "Suchen Sie nach sichtbaren Punkten des Teils in der Mitte und in der Nähe der Mitte jeder seiner Flächen",
      "在每个表面的中间和接近中间搜索零件的可见点",
      "Busque puntos visibles de la pieza en el centro y cerca del centro de cada una de sus superficies",  // ES
      "Recherchez des points visibles de la pièce au milieu et près du milieu de chacune de ses surfaces",  // FR
      "Parçanın her yüzeyinin ortasında ve ortasına yakın görünür noktalarını arayın"};  // TR

    public static readonly string[] FromEdge = {
      "From part edge",
      "От ребра детали",
      "Dal bordo parziale",
      "Von Teilkante",
      "从零件边缘",
      "Desde el borde de la pieza",                    // ES
      "Depuis le bord de la pièce",                    // FR
      "Parça kenarından"};                             // TR

    public static readonly string[] FromEdgeTip = {
      "Search for visible points of the details in the middle of each of its edge. \r\n" +
        "And for long ribs, a pair of points on each edge.",
      "Искать видимые точки детали в середине каждого ее ребра. \r\n" +
        "А для длинных ребер еще в паре точек на каждом ребре.",
      "Cerca punti visibili dei dettagli nel mezzo di ciascuna delle sue costole. \r\n" +
        "E per le costole lunghe, un paio di punti su ogni bordo.",
      "Wenn der Platz belegt ist, \r\n" +
        "platzieren Sie ihn unten mit einem Einzug von mindestens dem angegebenen Schritt.",
      "在其每个肋骨的中间搜索细节的可见点。对于长肋骨，每个边缘都有一对点。",
      "Busque puntos visibles de los detalles en el medio de cada uno de sus bordes. \r\n" +  // ES
        "Y para bordes largos, un par de puntos en cada borde.",
      "Recherchez des points visibles des détails au milieu de chacun de ses bords. \r\n" +  // FR
        "Et pour les arêtes longues, une paire de points sur chaque bord.",
      "Ayrıntıların her kenarının ortasındaki görünür noktaları arayın. \r\n" +  // TR
        "Ve uzun kenarlar için, her kenarda bir çift nokta."};

    public static readonly string[] FromVertex = {
      "From part vertex",
      "От угла детали",
      "Dal vertice della parte",
      "Von Teilscheitel",
      "从零件顶点",
      "Desde el vértice de la pieza",                  // ES
      "Depuis le sommet de la pièce",                  // FR
      "Parça köşesinden"};                             // TR

    public static readonly string[] FromVertexTip = {
      "Search for visible vertices (corners) and make multi-leaders from them",
      "Искать видимые вертексы (вершины) и делать выноски от них",
      "Cerca i vertici visibili (angoli) e crea multidirettrici da essi",
      "Suchen Sie nach sichtbaren Scheitelpunkten (Ecken) und erstellen Sie daraus Führungslinie",
      "搜索可见顶点（角）并从中创建多引线",
      "Busque vértices visibles (esquinas) y cree directrices múltiples desde ellos",  // ES
      "Recherchez des sommets visibles (coins) et créez des lignes de repère multiples à partir d'eux",  // FR
      "Görünür köşeleri (köşeler) arayın ve bunlardan çoklu açıklama çizgileri oluşturun"};  // TR

    public static readonly string[] HiddenPartList = {
      "List of invisible parts",
      "Список невидимых деталей",
      "Elenco delle parti invisibili",
      "Liste der unsichtbaren Teile",
      "隐形零件清单",
      "Lista de piezas invisibles",                    // ES
      "Liste des pièces invisibles",                   // FR
      "Görünmez parçaların listesi"};                  // TR

    public static readonly string[] HiddenPartListTip = {
      "Create a text with a list of parts for which no visible point was found",
      "Создать текст со списком деталей, для которых не нашлось ни одной видимой точки",
      "Crea un testo con un elenco di parti per le quali non è stato trovato alcun punto visibile",
      "Erstellen Sie einen Text mit einer Liste von Teilen, für die kein sichtbarer Punkt gefunden wurde",
      "使用未找到可见点的部件列表创建文本",
      "Crear un texto con una lista de piezas para las que no se encontró ningún punto visible",  // ES
      "Créer un texte avec une liste de pièces pour lesquelles aucun point visible n'a été trouvé",  // FR
      "Görünür nokta bulunmayan parçaların listesini içeren bir metin oluşturun"};  // TR

    public static readonly string[] PlaceLeft = {
      "Place left",
      "Размещать слева",
      "Posto a sinistra",
      "Links platzieren",
      "向左放置",
      "Colocar a la izquierda",                        // ES
      "Placer à gauche",                               // FR
      "Sola yerleştir"};                               // TR

    public static readonly string[] PlaceLeftTip = {
      "Position multi-leader texts to the left of the view",
      "Располагать тексты выносок слева от вида",
      "Posiziona i testi con più direttrici a sinistra della vista",
      "Positionieren Sie Texte mit mehreren Führungslinien links von der Ansicht",
      "将多引线文本放置在视图的左侧",
      "Posicionar textos de directrices múltiples a la izquierda de la vista",  // ES
      "Positionner les textes de lignes de repère multiples à gauche de la vue",  // FR
      "Çoklu açıklama çizgisi metinlerini görünümün soluna yerleştirin"};  // TR

    public static readonly string[] PlaceRight = {
      "Place right",
      "Размещать справа",
      "Posto a destra",
      "Richtig platzieren",
      "正确放置",
      "Colocar a la derecha",                          // ES
      "Placer à droite",                               // FR
      "Sağa yerleştir"};                               // TR

    public static readonly string[] PlaceRightTip = {
      "Position multi-leader texts to the right of the view",
      "Располагать тексты выносок справа от вида",
      "Posiziona i testi con più direttrici a sinistra della vista",
      "Positionieren Sie Texte mit mehreren Führungslinien links von der Ansicht",
      "将多引线文本放置在视图的左侧",
      "Posicionar textos de directrices múltiples a la derecha de la vista",  // ES
      "Positionner les textes de lignes de repère multiples à droite de la vue",  // FR
      "Çoklu açıklama çizgisi metinlerini görünümün sağına yerleştirin"};  // TR

    public static readonly string[] SameBlocks = {
      "Repeat on same blocks",
      "Повторять на одинаковых блоках",
      "Ripetere sugli stessi blocchi",
      "Wiederholen Sie auf denselben Blöcken",
      "在相同的块上重复",
      "Repetir en bloques iguales",                    // ES
      "Répéter sur les mêmes blocs",                   // FR
      "Aynı bloklarda tekrarla"};                      // TR

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
        "如果该选项被禁用，那么只有一个（第一次遇到）块将有一个领导者",
      "Crear directrices múltiples desde todos los bloques, incluso si el bloque con el mismo nombre ya tiene una directriz. \r\n" +  // ES
        "Si la opción está deshabilitada, solo un bloque (el primero encontrado) tendrá una directriz",
      "Créer des lignes de repère multiples à partir de tous les blocs, même si le bloc portant le même nom a déjà une ligne de repère. \r\n" +  // FR
        "Si l'option est désactivée, un seul bloc (le premier rencontré) aura une ligne de repère",
      "Aynı ada sahip blok zaten bir açıklama çizgisine sahip olsa bile tüm bloklardan çoklu açıklama çizgileri oluşturun. \r\n" +  // TR
        "Seçenek devre dışı bırakılırsa, yalnızca bir blok (ilk karşılaşılan) bir açıklama çizgisine sahip olacaktır"};

    public static readonly string[] SameObjects = {
      "Repeat on identical objects",
      "Повторять на одинаковых объектах",
      "Ripetere su oggetti identici",
      "Wiederholen Sie auf identischen Objekten",
      "重复相同的对象",
      "Repetir en objetos idénticos",                  // ES
      "Répéter sur des objets identiques",             // FR
      "Aynı nesnelerde tekrarla"};                     // TR

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
        "如果该选项被禁用，那么只有一个（第一个找到的）零件将有一个多引线。",
      "Crear directrices múltiples desde todas las piezas, incluso si la misma pieza ya tiene una directriz. \r\n" +  // ES
        "Si la opción está deshabilitada, solo una pieza (la primera encontrada) tendrá una directriz múltiple.",
      "Créer des lignes de repère multiples à partir de toutes les pièces, même si la même pièce a déjà une ligne de repère. \r\n" +  // FR
        "Si l'option est désactivée, une seule pièce (la première trouvée) aura une ligne de repère multiple.",
      "Aynı parça zaten bir açıklama çizgisine sahip olsa bile tüm parçalardan çoklu açıklama çizgileri oluşturun. \r\n" +  // TR
        "Seçenek devre dışı bırakılırsa, yalnızca bir parça (ilk bulunan) çoklu açıklama çizgisine sahip olacaktır."};
  }
}