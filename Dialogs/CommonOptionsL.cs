// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Multisolid Cuix Popup

namespace AVC
{
  /// <summary>
  /// Локализация диалога Общих Настроек плагинов AVC
  /// </summary>
  public static class
  CommonOptionsL
  {

    public static readonly string[] OpenTemplate = {
      "Select template",
      "Выбрать шаблон",
      "Seleziona modello",
      "Wählen Sie eine Vorlage",
      "选择一个模板",
      "Seleccionar plantilla",
      "Sélectionner un modèle",
      "Şablon seç"};

    public static readonly string[] Template = {
      "Template",
      "Шаблон",
      "Modello",
      "Schablone",
      "模板",
      "Plantilla",
      "Modèle",
      "Şablon"};

    public static readonly string[] ChooseTemplate = {
      "Choose a template for layers, materials, blocks and styles",
      "Выберите шаблон для слоев, материалов, блоков и стилей",
      "Scegli un modello per livelli, materiali, blocchi e stili",
      "Wählen Sie eine Vorlage für Ebenen, Materialien, Blöcke und Stile.",
      "为图层、材质、块和样式选择模板",
      "Elija una plantilla para capas, materiales, bloques y estilos",
      "Choisissez un modèle pour les calques, les matériaux, les blocs et les styles",
      "Katmanlar, malzemeler, bloklar ve stiller için bir şablon seçin"};

    public static readonly string[] ReloadCUIX = {
      "Reload menu",
      "Перезагрузить меню",
      "Ricarica menu",
      "Menü neu laden",
      "重新加载菜单",
      "Recargar menú",
      "Recharger le menu",
      "Menüyü yeniden yükle"};

    public static readonly string[] ReloadCuixTip = {
      "For all A>V>C> plugins unload their partial CUIX customization files from AutoCAD and load them again.\r\n" +
        "This will help you see the menus and buttons of all commands if they haven't loaded themselves.",
      "Для всех плагинов A>V>C> файлы частичной настройки CUIX выгружаются из AutoCAD и загружаются снова.\r\n" +
         "Это поможет вам увидеть меню и кнопки всех команд, если они сами не загрузились.",
      "Per tutti i plug-in A>V>C> scarica i file di personalizzazione CUIX parziali da AutoCAD e caricali di nuovo.\r\n" +
         "Questo ti aiuterà a vedere i menu e i pulsanti di tutti i comandi se non si sono caricati da soli.",
      "Entladen Sie für alle A>V>C>-Plugins ihre partiellen CUIX-Anpassungsdateien aus AutoCAD und laden Sie sie erneut.\r\n" +
         "Dies hilft Ihnen, die Menüs und Schaltflächen aller Befehle zu sehen, wenn sie nicht selbst geladen wurden.",
      "对于所有 A>V>C> 插件，从 AutoCAD 中卸载其部分 CUIX 自定义文件并再次加载它们。\r\n" +
         "这将帮助您查看所有命令的菜单和按钮（如果它们尚未自行加载）。",
      "Para todos los complementos A>V>C>, descargue sus archivos de personalización CUIX parciales de AutoCAD y cárguelos nuevamente.\r\n" +
        "Esto le ayudará a ver los menús y botones de todos los comandos si no se han cargado por sí mismos.",
      "Pour tous les plug-ins A>V>C>, déchargez leurs fichiers de personnalisation CUIX partiels d'AutoCAD et rechargez-les.\r\n" +
        "Cela vous aidera à voir les menus et boutons de toutes les commandes s'ils ne se sont pas chargés eux-mêmes.",
      "Tüm A>V>C> eklentileri için kısmi CUIX özelleştirme dosyalarını AutoCAD'den kaldırın ve tekrar yükleyin.\r\n" +
        "Bu, kendileri yüklenmediyse tüm komutların menülerini ve düğmelerini görmenize yardımcı olacaktır."};

    public static readonly string[] BandingTip = {
      "An addition to the length of the edge to account for the margin for the cut from the two ends of the edge of the part.\r\n" +
        "Used to calculate the price of edge bandings. In drawing units (millimeters or inches).",
      "Добавка к длине кромки для учета запаса на отрез с двух концов торца детали.\r\n" +
        "Используется для вычисления цены кромочных материалов. В единицах чертежа (миллиметры или дюймы).",
      "Un'aggiunta alla lunghezza del bordo per tenere conto\r\n" +
        "del margine per il taglio dalle due estremità dell'estremità della parte.\r\n" +
        "Utilizzato per calcolare il prezzo dei bordi.\r\n" +
        "Nelle unità di disegno (millimetri o pollici).\r\n",
      "Eine Addition zur Länge der Kante, um den Rand für den Schnitt von den beiden Enden der Kante des Teils zu berücksichtigen.\r\n"+
         "Wird verwendet, um den Preis von Kantenbändern zu berechnen. In Zeichnungseinheiten (Millimeter oder Zoll).",
      "边缘长度的补充，以说明从零件边缘两端切割的边距。\r\n" +
         "用于计算封边条的价格。以绘图单位（毫米或英寸）为单位。",
      "Una adición a la longitud del borde para tener en cuenta el margen de corte desde los dos extremos del borde de la pieza.\r\n" +
        "Se utiliza para calcular el precio de los cantos. En unidades de dibujo (milímetros o pulgadas).",
      "Un ajout à la longueur du bord pour tenir compte de la marge de coupe des deux extrémités du bord de la pièce.\r\n" +
        "Utilisé pour calculer le prix des chants. En unités de dessin (millimètres ou pouces).",
      "Parçanın kenarının iki ucundan kesim için kenar boşluğunu hesaba katmak için kenara ekleme.\r\n" +
        "Kenar bantlarının fiyatını hesaplamak için kullanılır. Çizim birimlerinde (milimetre veya inç)."};

    public static readonly string[] CoverTip = {
      "Additive to surface area to calculate the price of coatings (paint, film, laminate).",
      "Добавка к площади поверхности для вычисления цены покрытий (краски, пленки, ламината).",
      "Additivo alla superficie per calcolare il prezzo dei rivestimenti (vernice, film, laminato).",
      "Flächenzuschlag zur Preiskalkulation von Beschichtungen (Lack, Folie, Laminat).",
      "添加到表面积以计算涂料（油漆、薄膜、层压板）的价格。",
      "Aditivo al área de superficie para calcular el precio de los recubrimientos (pintura, película, laminado).",
      "Additif à la surface pour calculer le prix des revêtements (peinture, film, stratifié).",
      "Kaplamaların fiyatını hesaplamak için yüzey alanına katkı maddesi (boya, film, laminat)."};

    public static readonly string[] KeepSelection = {
      "Keep selection",
      "Сохранить выбор",
      "Mantenere selezione",
      "Auswahl behalten",
      "保持选择",
      "Mantener selección",
      "Conserver la sélection",
      "Seçimi koru"};

    public static readonly string[] KeepSelectionTip = {
      "Keep selection set after end of any A>V>C> command",
      "Оставить объекты выделенными после окончания команд A>V>C>",
      "Mantenere insieme di selezione dopo la fine di ogni comando A>V>C>",
      "Behalten Sie die Auswahl nach dem Ende eines beliebigen AVC-Befehls bei",
      "在任何 AVC 命令结束后保持选择集",
      "Mantener el conjunto de selección después del final de cualquier comando A>V>C>",
      "Conserver le jeu de sélection après la fin de toute commande A>V>C>",
      "Herhangi bir A>V>C> komutunun sonundan sonra seçim kümesini koru"};

    public static readonly string[] ListValues = {
      "List of values",
      "Список значений",
      "Elenco di valori",
      "Liste von Werten",
      "值列表",
      "Lista de valores",
      "Liste de valeurs",
      "Değerler listesi"};

    public static readonly string[] ListValuesTip = {
      "If parts with different properties fall on one line,\r\n" +
        "then all values will be listed in the list through the '/' symbol.\r\n" +
        "If the option unchecked, the word *VARIES* will be substituted.",
      "Если в одну строку попадут детали с разными свойствами,\r\n" +
        "то все значения будут перечислены списком через символ '/'.\r\n" +
        "Если опция сброшена, то будет подставлено слово *РАЗЛИЧНЫЕ*",
      "Se le parti con proprietà diverse cadono su una riga,\r\n" +
        "tutti i valori verranno elencati nell'elenco tramite il simbolo /.\r\n" +
        "Se l'opzione è ripristinata, la parola *VARIE* verrà sostituita.",
      "Wenn Teile mit unterschiedlichen Eigenschaften auf eine Zeile fallen, wird\r\n" +
         "dann werden alle Werte in der Liste durch das '/'-Symbol aufgelistet.\r\n" +
         "Wenn die Option deaktiviert ist, wird das Wort *VARIES* ersetzt.",
      "如果具有不同属性的部分落在一条线上，\r\n" +
         "那么所有值都将通过'/'符号列在列表中。\r\n" +
         "如果未选中该选项，*VARIES* 将被替换。",
      "Si las piezas con diferentes propiedades caen en una línea,\r\n" +
        "entonces todos los valores se enumerarán en la lista a través del símbolo '/'.\r\n" +
        "Si la opción no está marcada, se sustituirá la palabra *VARIES*.",
      "Si des pièces avec des propriétés différentes tombent sur une ligne,\r\n" +
        "alors toutes les valeurs seront répertoriées dans la liste via le symbole '/'.\r\n" +
        "Si l'option n'est pas cochée, le mot *VARIES* sera substitué.",
      "Farklı özelliklere sahip parçalar bir satıra düşerse,\r\n" +
        "o zaman tüm değerler listede '/' sembolü aracılığıyla listelenecektir.\r\n" +
        "Seçenek işaretlenmezse, *VARIES* kelimesi yerine geçecektir."};

    public static readonly string[] ManageLayers = {
      "Manage layers",
      "Назначать слой",
      "Gestire i layer",
      "Ebenen verwalten",
      "管理图层",
      "Administrar capas",
      "Gérer les calques",
      "Katmanları yönet"};

    public static readonly string[] ManageLayersTip = {
      "Automatically assign layers for circuits, solids and texts.",
      "Автоматически назначать слой контурам",
      "Assegnare automaticamente i layer per i percorsi.",
      "Weisen Sie automatisch Ebenen für Schaltkreise, Volumenkörper und Texte zu.",
      "自动为电路、实体和文本分配层。",
      "Asignar automáticamente capas para circuitos, sólidos y textos.",
      "Attribuer automatiquement des calques pour les circuits, les solides et les textes.",
      "Devreler, katılar ve metinler için otomatik olarak katman ata."};

    public static readonly string[] MarkPriority = {
      "Colored face priority",
      "Приоритет цветной грани",
      "Superficie verniciata prioritaria",
      "Priorität für farbige Gesichter",
      "有色人脸优先",
      "Prioridad de cara coloreada",
      "Priorité de face colorée",
      "Renkli yüz önceliği"};

    public static readonly string[] MarkPriorityTip = {
      "If you assign a color different from the color of the solid itself to one flat face of a solid,\r\n" +
        "then this face will be considered a FRONT (main) despite its size.\r\n" +
        "This will prevent the solid from turning over on the layout (in the LAY command).\r\n" +
        "Be sure to color-mark all identical parts.",
      "Если присвоить одной плоской грани солида цвет отличный от цвета самого солида,\r\n" +
        "то эта грань будет считаться фасадом не смотря на ее размер.\r\n" +
        "Это предотвратит переворачивание солидов на выкладке (в команде LAY).\r\n" +
        "Обязательно промаркируйте цветом все одинаковые детали.",
      "Se si assegna un colore diverso dal colore del solido stesso a una faccia piana di un solido,\r\n" +
        "questa faccia sarà considerata una facciata nonostante le sue dimensioni.\r\n" +
        "Ciò impedirà al solido di ribaltarsi sul layout (nel comando LAY).\r\n" +
        "Assicurati di marcare a colori tutte le parti identiche.",
      "Wenn Sie einer flachen Seite eines Volumenkörpers eine andere Farbe als die Farbe des Volumenkörpers zuweisen, wird\r\n" +
         "Dann wird diese Fläche trotz ihrer Größe als FRONT (Hauptfläche) betrachtet.\r\n" +
         "Dies wird verhindern, dass sich der Volumenkörper auf dem Layout umdreht (im LAY-Befehl).\r\n" +
         "Achten Sie darauf, alle identischen Teile farblich zu markieren.",
      "如果将与实体本身的颜色不同的颜色分配给实体的一个平面，\r\n" +
         "那么尽管它的大小，这张脸将被视为 FRONT（主）。\r\n" +
         "这将防止实体在布局上翻转（在 LAY 命令中）。\r\n" +
         "一定要对所有相同的部分进行颜色标记。",
      "Si asigna un color diferente al color del sólido mismo a una cara plana de un sólido,\r\n" +
        "entonces esta cara se considerará FRONTAL (principal) a pesar de su tamaño.\r\n" +
        "Esto evitará que el sólido se voltee en el diseño (en el comando LAY).\r\n" +
        "Asegúrese de marcar con color todas las piezas idénticas.",
      "Si vous attribuez une couleur différente de la couleur du solide lui-même à une face plane d'un solide,\r\n" +
        "alors cette face sera considérée comme AVANT (principale) malgré sa taille.\r\n" +
        "Cela empêchera le solide de se retourner sur la mise en page (dans la commande LAY).\r\n" +
        "Assurez-vous de marquer en couleur toutes les pièces identiques.",
      "Bir katının düz yüzüne katının kendisinin renginden farklı bir renk atarsanız,\r\n" +
        "o zaman bu yüz boyutuna rağmen ÖN (ana) olarak kabul edilecektir.\r\n" +
        "Bu, katının düzende devrilmesini önleyecektir (LAY komutunda).\r\n" +
        "Tüm özdeş parçaları renkle işaretlediğinizden emin olun."};

    public static readonly string[] NoAvailableTip = {
      "The text to be written at the place of substitution\r\n" +
        "when the object did not find such a property.\r\n" +
        "You can leave the field blank.",
      "Текст, который следует писать на месте подстановки,\r\n" +
        "когда у объекта не нашлось такого свойства. Можно оставить поле пустым.",
      "Il testo da scrivere nel luogo di sostituzione quando l'oggetto non ha trovato tale proprietà.\r\n" +
        "Puoi lasciare il campo vuoto.",
      "Der Text, der an der Substitutionsstelle geschrieben werden soll,\r\n" +
        "wenn das Objekt keine solche Eigenschaft gefunden hat.\r\n" +
         "Sie können das Feld leer lassen.",
      "当对象没有找到这样的属性时要在替换位置写入的文本。\r\n" +
         "您可以将该字段留空。",
      "El texto que se escribirá en el lugar de sustitución\r\n" +
        "cuando el objeto no encontró tal propiedad.\r\n" +
        "Puede dejar el campo en blanco.",
      "Le texte à écrire à l'emplacement de substitution\r\n" +
        "lorsque l'objet n'a pas trouvé une telle propriété.\r\n" +
        "Vous pouvez laisser le champ vide.",
      "Nesne böyle bir özellik bulamadığında yerine yazılacak metin.\r\n" +
        "Alanı boş bırakabilirsiniz."};

    public static readonly string[] RightAngle = {
      "Right-angle priority",
      "Приоритет прямого угла",
      "La priorità di un angolo retto",
      "Rechtwinklige Priorität",
      "直角优先",
      "Prioridad de ángulo recto",
      "Priorité d'angle droit",
      "Dik açı önceliği"};

    public static readonly string[] RightAngleTip = {
      "When calculating the size of the solid, the program must turn it at a right angle. \r\n" +
        "If this is disabled, the benefit will have the longest line or arc.\r\n" +
        "It allows you to configure commands LAY, SAW and Smart Leader.",
      "При вычислении размеров тела надо поворачивать его прямым углом.\r\n" +
        "Если это отключить, то преимущество будет у самой длинной линии или дуги.\r\n" +
        "Позволяет настроить команды Выкладка, Таблица напилки и Умные выноски.",
      "Calcola la dimensione del corpo partendo da un angolo retto.\r\n" +
        "Se disabilitato, il riferimento verrà preso dalla linea o arco più lungo.\r\n" +
        "Questo consente di configurare i comandi LAY, SAW e SmartLeader.",
      "Wenn Sie die Größe des Festkörpers berechnen, müssen Sie ihn im rechten Winkel drehen.\r\n"+
         "Wenn dies deaktiviert ist, hat der Vorteil die längste Linie oder den längsten Bogen.\r\n" +
         "Es ermöglicht Ihnen, die Befehle LAY, SAW und Smart Leader zu konfigurieren.",
      "计算固体尺寸时需要将其旋转成直角。\r\n" +
         "如果禁用此功能，则收益将具有最长的线或弧。\r\n" +
         "它允许您配置命令 LAY、SAW 和 Smart Leader。",
      "Al calcular el tamaño del sólido, el programa debe girarlo en ángulo recto. \r\n" +
        "Si esto está deshabilitado, el beneficio tendrá la línea o arco más largo.\r\n" +
        "Le permite configurar los comandos LAY, SAW y Smart Leader.",
      "Lors du calcul de la taille du solide, le programme doit le tourner à angle droit. \r\n" +
        "Si cela est désactivé, l'avantage aura la ligne ou l'arc le plus long.\r\n" +
        "Il vous permet de configurer les commandes LAY, SAW et Smart Leader.",
      "Katının boyutunu hesaplarken, program onu dik açıyla döndürmelidir. \r\n" +
        "Bu devre dışı bırakılırsa, fayda en uzun çizgi veya yaya sahip olacaktır.\r\n" +
        "LAY, SAW ve Smart Leader komutlarını yapılandırmanıza olanak tanır."};

    public static readonly string[] Reduce = {
      "Reduce size by bandings",
      "Уменьшить габарит на кромки",
      "Riduci la parte per bordo",
      "Reduzieren Sie die Größe durch Bandings",
      "通过封边条减小尺寸",
      "Reducir tamaño por cantos",
      "Réduire la taille par les chants",
      "Kenar bantlarıyla boyutu küçült"};

    public static readonly string[] ReduceTip = {
      "Subtract the edge-banding thicknesses from the length and width of the part.\r\n" +
        "This will only work for simple rectangular parts.",
      "Вычесть из длины и ширины детали толщины кромок.\r\n" +
        "Это сработает только для простых прямоугольных деталей.",
      "Sottrai gli spessori della bordatura dalla lunghezza e dalla larghezza della parte.\r\n" +
        "Funzionerà solo per parti rettangolari semplici.",
      "Ziehen Sie die Kantenbandstärken von der Länge und Breite des Teils ab.\r\n" +
         "Das funktioniert nur bei einfachen rechteckigen Teilen.",
      "从零件的长度和宽度中减去封边带的厚度。\r\n" +
         "这仅适用于简单的矩形零件。",
      "Restar los espesores de los cantos de la longitud y el ancho de la pieza.\r\n" +
        "Esto solo funcionará para piezas rectangulares simples.",
      "Soustraire les épaisseurs des chants de la longueur et de la largeur de la pièce.\r\n" +
        "Cela ne fonctionnera que pour les pièces rectangulaires simples.",
      "Kenar bantı kalınlıklarını parçanın uzunluğundan ve genişliğinden çıkarın.\r\n" +
        "Bu yalnızca basit dikdörtgen parçalar için çalışacaktır."};

    public static readonly string[] RodTip = {
      "Additive to the length to account for the margin for the cut from two ends of the part.\r\n" +
        "Used to calculate the price of molded materials (bar, rod, pipes).\r\n" +
        "In drawing units (millimeters or inches).",
      "Добавка к длине для учета запаса на отрез с двух концов детали.\r\n" +
        "Используется для вычисления цены погонажных материалов (трубы, прокат, хлысты, молдинги).\r\n" +
        "В единицах чертежа (миллиметры или дюймы).",
      "Additivo alla lunghezza per tenere conto del margine per il taglio da due estremità della parte.\r\n" +
        "Utilizzato per calcolare il prezzo dei materiali stampati (asta, tubi).\r\n" +
        "Nelle unità di disegno (millimetri o pollici).",
      "Additiv zur Länge, um den Rand für den Schnitt von zwei Enden des Teils zu berücksichtigen.\r\n" +
         "Wird verwendet, um den Preis von geformten Materialien (Stangen, Stangen, Rohre) zu berechnen.\r\n" +
         "In Zeichnungseinheiten (Millimeter oder Zoll).",
      "添加到长度以考虑从零件两端切割的余量。\r\n" +
         "用于计算成型材料（棒材、棒材、管材）的价格。\r\n" +
         "以绘图单位（毫米或英寸）。",
      "Aditivo a la longitud para tener en cuenta el margen de corte desde los dos extremos de la pieza.\r\n" +
        "Se utiliza para calcular el precio de materiales moldeados (barra, varilla, tubos).\r\n" +
        "En unidades de dibujo (milímetros o pulgadas).",
      "Additif à la longueur pour tenir compte de la marge de coupe des deux extrémités de la pièce.\r\n" +
        "Utilisé pour calculer le prix des matériaux moulés (barre, tige, tuyaux).\r\n" +
        "En unités de dessin (millimètres ou pouces).",
      "Parçanın iki ucundan kesim için kenar boşluğunu hesaba katmak için uzunluğa ekleme.\r\n" +
        "Kalıplanmış malzemelerin fiyatını hesaplamak için kullanılır (çubuk, çubuk, borular).\r\n" +
        "Çizim birimlerinde (milimetre veya inç)."};

    public static readonly string[] SaveMultiplier = {
      "Save Multiplier",
      "Сохранять множитель",
      "Salva moltiplicatore",
      "Multiplikator speichern",
      "保存乘数",
      "Guardar multiplicador",
      "Enregistrer le multiplicateur",
      "Çarpanı kaydet"};

    public static readonly string[] SaveMultiplierTip = {
      "Save multiplier for part count in the Multiplier drawing property",
      "Сохранять множитель количества деталей в свойстве чертежа Multiplier",
      "Salvare il moltiplicatore del numero di parti nella proprietà del disegno 'Moltiplicatore'",
      "Speichern Sie den Multiplikator für die Teileanzahl in der Zeichnungseigenschaft Multiplikator",
      "在乘数绘图属性中保存零件计数的乘数",
      "Guardar el multiplicador para el recuento de piezas en la propiedad de dibujo Multiplicador",
      "Enregistrer le multiplicateur pour le nombre de pièces dans la propriété de dessin Multiplicateur",
      "Parça sayısı için çarpanı Çarpan çizim özelliğinde kaydedin"};

    public static readonly string[] SawOnlyRectangles = {
      "Saw only rectangles",
      "Пилить только прямоуг-ки",
      "Sega - solo rettangoli",
      "Nur Rechtecke gesehen",
      "只看到矩形",
      "Serrar solo rectángulos",
      "Scier uniquement les rectangles",
      "Sadece dikdörtgenleri kes"};

    public static readonly string[] SawOnlyRectanglesTip = {
      "When program analyzes solids and chooses technology, triangles and trapezoids will be used for milling,\r\n" +
        "and only parts with a rectangular front face will be used for sawing.",
      "При выборе технологии треугольники и трапеции пойдут на фрезеровку,\r\n" +
        "а в напилку только детали с прямоугольным фасадом",
      "Quando si sceglie la tecnologia, per la fresatura verranno utilizzati triangoli e trapezoidali\r\n" +
        "e solo le parti con facciata rettangolare verranno utilizzate per la segatura.",
      "Bei der Auswahl der Technologie werden Dreiecke und Trapeze zum Fräsen verwendet,\r\n" +
         "und es werden nur Teile mit rechteckiger Stirnfläche gesägt.",
      "在选择工艺时，会使用三角形和梯形进行铣削，\r\n" +
         "并且只有具有矩形正面的零件才能用于锯切。",
      "Cuando el programa analiza sólidos y elige tecnología, se usarán triángulos y trapecios para fresado,\r\n" +
        "y solo se usarán piezas con cara frontal rectangular para aserrado.",
      "Lorsque le programme analyse les solides et choisit la technologie, les triangles et trapèzes seront utilisés pour le fraisage,\r\n" +
        "et seules les pièces avec face avant rectangulaire seront utilisées pour le sciage.",
      "Program katıları analiz edip teknolojiyi seçtiğinde, üçgenler ve yamuklar frezeleme için kullanılacak,\r\n" +
        "ve yalnızca dikdörtgen ön yüze sahip parçalar kesme için kullanılacaktır."};

    public static readonly string[] Multisolid = {
      "Work with multi-solids",
      "Работать с мульти-солидами",
      "Lavora con multi-solidi",
      "Arbeiten Sie mit mehreren Volumenkörpern",
      "使用多实体",
      "Trabajar con multi-sólidos",
      "Travailler avec des multi-solides",
      "Çoklu katılarla çalış"};

    public static readonly string[] MultisolidTip = {
      "Working with solids consisting of several separate bodies can lead to erroneous dimensions, \r\n" +
        "strange laying out and incorrect milling contours. \r\n" +
        "It is recommended to disable this option and split multi-solids into individual solids.",
      "Работа с солидами, состоящими из нескольких отдельных тел, может привести к ошибочным размерам, \r\n" +
        "странной выкладке и неверным контурам фрезерования. \r\n" +
        "Рекомендуется отключать эту опцию и разделять мульти-солиды на отдельные солиды.",
      "Lavorare con solidi costituiti da più corpi separati può portare a dimensioni errate, \r\n" +
        "layout strani e contorni di fresatura errati. \r\n" +
        "Si consiglia di disabilitare questa opzione e dividere i multisolidi in singoli solidi.",
      "Das Arbeiten mit Solids, die aus mehreren separaten Körpern bestehen, \r\n" +
        "kann zu fehlerhaften Abmessungen, merkwürdigem Layout und falschen Fräskonturen führen. \r\n" +
        "Es wird empfohlen, diese Option zu deaktivieren und Multi-Solids in einzelne Solids aufzuteilen.",
      "使用由多个独立实体组成的实体可能会导致错误的尺寸、奇怪的布局和不正确的铣削轮廓。 \r\n" +
        "建议禁用此选项并将多实体拆分为单个实体。",
      "Trabajar con sólidos que constan de varios cuerpos separados puede conducir a dimensiones erróneas, \r\n" +
        "disposición extraña y contornos de fresado incorrectos. \r\n" +
        "Se recomienda deshabilitar esta opción y dividir multi-sólidos en sólidos individuales.",
      "Travailler avec des solides constitués de plusieurs corps séparés peut conduire à des dimensions erronées, \r\n" +
        "une disposition étrange et des contours de fraisage incorrects. \r\n" +
        "Il est recommandé de désactiver cette option et de diviser les multi-solides en solides individuels.",
      "Birkaç ayrı gövdeden oluşan katılarla çalışmak hatalı boyutlara, \r\n" +
        "garip düzenlemeye ve yanlış frezeleme konturlarına yol açabilir. \r\n" +
        "Bu seçeneği devre dışı bırakmanız ve çoklu katıları tek tek katılara ayırmanız önerilir."};

    public static readonly string[] SheetTip = {
      "Additive to sheet area to calculate the price of sheet materials.",
      "Добавка к площади листа для вычисления цены листовых материалов.",
      "Additivo all'area del foglio per calcolare il prezzo dei materiali del foglio.",
      "Additiv zur Plattenfläche, um den Preis von Plattenmaterialien zu berechnen.",
      "添加到板材面积以计算板材的价格。",
      "Aditivo al área de la hoja para calcular el precio de los materiales de hoja.",
      "Additif à la surface de la feuille pour calculer le prix des matériaux en feuille.",
      "Levha malzemelerinin fiyatını hesaplamak için levha alanına katkı maddesi."};

    public static readonly string[] TopSide = {
      "Top-side priority",
      "Приоритет верхней грани",
      "Priorità in primo piano",
      "Oberste Priorität",
      "顶部优先",
      "Prioridad de cara superior",
      "Priorité face supérieure",
      "Üst yüz önceliği"};

    public static readonly string[] TopSideTip = {
      "If the solid has 2 sides of the same size, the upward side will be selected as the facade side. \r\n" +
        "Use this option so that the details of floors and podiums do not turn on the layout\r\n" +
        "(in the LAY command).",
      "Если солид имеет 2 стороны одного размера,\r\n" +
        "то фасадной стороной будет выбрана сторона, направленная вверх.\r\n" +
        "Используйте эту опцию, чтоб детали полов и подиумов\r\n" +
        "не переворачивались на выкладке (в команде LAY).",
      "Se il solido ha 2 lati della stessa dimensione,\r\n" +
        "il lato verso l'alto verrà selezionato come lato della facciata.\r\n" +
        "Utilizzare questa opzione in modo che i dettagli di piani e podi\r\n" +
        "non attivino il layout (nel comando LAY).",
      "Wenn der Körper 2 gleich große Seiten hat, wird die obere Seite als Fassadenseite ausgewählt."+
        "Verwenden Sie diese Option, damit die Details von Böden und Podesten das Layout nicht einschalten\r\n" +
        "(im LAY-Befehl).",
      "如果实体有两个大小相同的边，则选择向上的一侧作为立面。\r\n" +
        "使用此选项，使楼层和裙楼的细节不会打开布局\r\n" +
        "（在 LAY 命令中）。",
      "Si el sólido tiene 2 lados del mismo tamaño, se seleccionará el lado hacia arriba como lado de fachada. \r\n" +
        "Use esta opción para que los detalles de pisos y podios no se giren en el diseño\r\n" +
        "(en el comando LAY).",
      "Si le solide a 2 côtés de la même taille, le côté vers le haut sera sélectionné comme côté façade. \r\n" +
        "Utilisez cette option pour que les détails des sols et podiums ne se retournent pas sur la mise en page\r\n" +
        "(dans la commande LAY).",
      "Katının aynı boyutta 2 tarafı varsa, yukarı bakan taraf cephe tarafı olarak seçilecektir. \r\n" +
        "Zemin ve podyumların detaylarının düzende dönmemesi için bu seçeneği kullanın\r\n" +
        "(LAY komutunda)."};

    public static readonly string[] UseEdgeLetter = {
      "Use edge letter",
      "Буквы торцов",
      "Usa la lettera sul bordo",
      "Kantenbuchstaben verwenden",
      "使用边缘字母",
      "Usar letra de borde",
      "Utiliser une lettre de bord",
      "Kenar harfi kullan"};

    public static readonly string[] UseEdgeLetterTip = {
      "To indicate the edges (ends) of the part, instead of the length of the edge, write the letter:\r\n" +
         "L - the left side of the quadrangular part on the layout (facade down).\r\n"+
         "T - the top side.\r\n"+
         "R - the right side.\r\n"+
         "B - the bottom side.\r\n"+
         "Len - for a complex part, the end length coincides with the length dimension of the part.\r\n" +
         "W - -//- in width.",
      "Для обозначения торцов детали вместо длинны торца писать букву:\r\n" +
        "Л - левая сторона четырехугольной детали на выкладке (фасадом вниз).\r\n"+
        "В - верхняя сторона.\r\n"+
        "П - правая сторона.\r\n"+
        "Н - нижняя сторона.\r\n"+
        "Д - у сложной детали длина торца совпадает с габаритом детали по длине.\r\n" +
        "Ш - -//- по ширине.",
      "Per indicare le estremità della parte, anziché la lunghezza della fine, scrivi la lettera:\r\n" +
         "S - il lato sinistro della parte quadrangolare sul layout rivolto verso il basso.\r\n"+
         "A - il lato superiore (in alto).\r\n"+
         "D - il lato destro.\r\n"+
         "B - il lato inferiore (in basso).\r\n"+
         "Lun - per una parte complessa, la lunghezza finale coincide con la dimensione della lunghezza della parte.\r\n" +
         "Lar - in larghezza.",
      "Um die Kanten (Enden) des Teils anzugeben, schreiben Sie anstelle der Kantenlänge den Buchstaben:\r\n" +
         "L - die linke Seite des viereckigen Teils auf dem Grundriss (Fassade nach unten).\r\n"+
         "H - die Oberseite.\r\n"+
         "R - die rechte Seite.\r\n"+
         "V - die Unterseite.\r\n"+
         "Län - bei einem komplexen Teil stimmt die Endlänge mit der Längenabmessung des Teils überein.\r\n" +
         "W - in der Breite.\r\n",
      "要表示零件的边（端），而不是边的长度，写字母：\r\n" +
         "左 - 布局上四边形部分的左侧朝下。\r\n"+
         "上 - 是顶部。\r\n"+
         "右 - 是右边。\r\n"+
         "下 - 是底边。\r\n"+
         "长 - 对于复杂零件，末端长度与零件的长度尺寸一致。\r\n" +
         "宽 - 宽度。",
      "Para indicar los bordes (extremos) de la pieza, en lugar de la longitud del borde, escriba la letra:\r\n" +
         "I - el lado izquierdo de la pieza cuadrangular en el diseño (fachada hacia abajo).\r\n"+
         "S - el lado superior.\r\n"+
         "D - el lado derecho.\r\n"+
         "B - el lado inferior.\r\n"+
         "Lon - para una pieza compleja, la longitud del extremo coincide con la dimensión de longitud de la pieza.\r\n" +
         "A - -//- en ancho.",
      "Pour indiquer les bords (extrémités) de la pièce, au lieu de la longueur du bord, écrivez la lettre:\r\n" +
         "G - le côté gauche de la pièce quadrangulaire sur la mise en page (façade vers le bas).\r\n"+
         "H - le côté supérieur.\r\n"+
         "D - le côté droit.\r\n"+
         "B - le côté inférieur.\r\n"+
         "Lon - pour une pièce complexe, la longueur d'extrémité coïncide avec la dimension de longueur de la pièce.\r\n" +
         "L - -//- en largeur.",
      "Parçanın kenarlarını (uçlarını) belirtmek için, kenar uzunluğu yerine harfi yazın:\r\n" +
         "S - düzende dörtgen parçanın sol tarafı (cephe aşağıda).\r\n"+
         "Ü - üst taraf.\r\n"+
         "S - sağ taraf.\r\n"+
         "A - alt taraf.\r\n"+
         "Uz - karmaşık bir parça için, uç uzunluğu parçanın uzunluk boyutuyla çakışır.\r\n" +
         "G - -//- genişlikte."};

    public static readonly string[] EdgeLettersTip = {
      "You can replace part end symbols. \r\n" +
         "Make your list in the following order:\r\n" +
         "left, top, right, bottom, lengthwise, widthwise.\r\n" +
         "Use a comma as separator and don't use spaces.\r\n" +
         "The setting is used in the %bandings% and %slopes% substitutions.",
      "Можно заменить обозначения торцов детали. \r\n" +
         "Составьте свой список в следующей последовательности:\r\n" +
         "левая, верхняя, правая, нижняя, по длине, по ширине.\r\n" +
         "Используйте запятую как разделитель и не делайте пробелов.\r\n" +
         "Настройка используется в подстановках %bandings% и %slopes%.",
      "È possibile sostituire i simboli delle estremità della parte. \r\n" +
         "Crea la tua lista nel seguente ordine:\r\n" +
         "sinistra, in alto, a destra, in basso, nel senso della lunghezza, nel senso della larghezza.\r\n" +
         "Usa una virgola come separatore e niente spazi.\r\n" +
         "L'impostazione viene utilizzata nelle sostituzioni %bandings% e %slopes%.",
      "Sie können Teile-Endsymbole ersetzen. \r\n" +
         "Erstellen Sie Ihre Liste in der folgenden Reihenfolge:\r\n" +
         "links, oben, rechts, unten, längs, quer.\r\n" +
         "Verwenden Sie ein Komma als Trennzeichen und keine Leerzeichen.\r\n" +
         "Die Einstellung wird in den Substitutionen %bandings% und %slopes% verwendet.",
      "您可以替换零件末端符号。 \r\n" +
         "按以下顺序列出您的列表：\r\n" +
         "左、上、右、下、长，宽。\r\n" +
         "使用逗号作为分隔符，没有空格。\r\n" +
         "该设置用于 %bandings%（零件末端的涂层清单）和 %slopes%（通过倾斜锯片进行切割的零件末端列表）替换。",
      "Puede reemplazar los símbolos de extremo de pieza. \r\n" +
         "Haga su lista en el siguiente orden:\r\n" +
         "izquierda, arriba, derecha, abajo, a lo largo, a lo ancho.\r\n" +
         "Use una coma como separador y no use espacios.\r\n" +
         "La configuración se usa en las sustituciones %bandings% y %slopes%.",
      "Vous pouvez remplacer les symboles d'extrémité de pièce. \r\n" +
         "Faites votre liste dans l'ordre suivant:\r\n" +
         "gauche, haut, droite, bas, dans le sens de la longueur, dans le sens de la largeur.\r\n" +
         "Utilisez une virgule comme séparateur et n'utilisez pas d'espaces.\r\n" +
         "Le paramètre est utilisé dans les substitutions %bandings% et %slopes%.",
      "Parça uç sembollerini değiştirebilirsiniz. \r\n" +
         "Listenizi şu sırayla yapın:\r\n" +
         "sol, üst, sağ, alt, uzunlamasına, genişlemesine.\r\n" +
         "Ayırıcı olarak virgül kullanın ve boşluk kullanmayın.\r\n" +
         "Ayar %bandings% ve %slopes% ikamelerinde kullanılır."};

    public static readonly string[] UseEdgeArrowsTip = {
      "Use arrow symbols instead of letter symbols. But make sure these arrows are included in the fonts you choose.",
      "Использовать символы-стрелки вместо буквенных обозначений. Но убедитесь, что эти стрелки есть в выбранных вами шрифтах.",
      "Utilizza i simboli delle frecce invece dei simboli delle lettere. Assicurati però che queste frecce siano incluse nei caratteri che scegli.",
      "Verwenden Sie Pfeilsymbole anstelle von Buchstabensymbolen. Stellen Sie jedoch sicher, dass diese Pfeile in den von Ihnen ausgewählten Schriftarten enthalten sind.",
      "使用箭头符号代替字母符号。 但请确保这些箭头包含在您选择的字体中。",
      "Use símbolos de flecha en lugar de símbolos de letra. Pero asegúrese de que estas flechas estén incluidas en las fuentes que elija.",
      "Utilisez des symboles de flèche au lieu de symboles de lettre. Mais assurez-vous que ces flèches sont incluses dans les polices que vous choisissez.",
      "Harf sembolleri yerine ok sembolleri kullanın. Ancak bu okların seçtiğiniz yazı tiplerine dahil olduğundan emin olun."};

    public static readonly string[] UseEdgeNumber = {
      "Use edge number",
      "Номера торцов",
      "Usa il numero del bordo",
      "Kantenzahl verwenden",
      "使用边号",
      "Usar número de borde",
      "Utiliser le numéro de bord",
      "Kenar numarası kullan"};

    public static readonly string[] UseEdgeNumberTip = {
      "To indicate the edges (ends) of the part, use the number in order, starting from the longest edge.\r\n" +
        "Edge lengths are commonly used.\r\n" +
        "The setting is used in the %bandings% and %slopes% substitutions.",
      "Для обозначения торцов детали использовать номер по порядку, начиная от самого длинного торца.\r\n" +
        "Обычно используются длины торцов.\r\n" +
        "Настройка используется в подстановках Кромки %bandings% и Наклоны %slopes%.",
      "Per indicare le estremità della parte, utilizzare il numero in ordine, a partire dalla fine più lunga.\r\n" +
        "Le lunghezze finali sono comunemente utilizzate.\r\n" +
        "L'impostazione viene utilizzata nelle sostituzioni %bandings% e %slopes%.",
      "Um die Kanten (Enden) des Teils anzugeben, verwenden Sie die Nummer der Reihe nach, beginnend mit der längsten Kante. "+
         "Kantenlängen werden häufig verwendet.\r\n" +
         "Die Einstellung wird in den Ersetzungen %bandings% und %slopes% verwendet.",
      "要指示零件的边（端），请按顺序使用数字，从最长的边开始。\r\n" +
         "通常使用边长。该设置用于 %bandings%（零件末端的涂层清单）和 %slopes%（通过倾斜锯片进行切割的零件末端列表） 替换。",
      "Para indicar los bordes (extremos) de la pieza, use el número en orden, comenzando desde el borde más largo.\r\n" +
        "Las longitudes de borde se usan comúnmente.\r\n" +
        "La configuración se usa en las sustituciones %bandings% y %slopes%.",
      "Pour indiquer les bords (extrémités) de la pièce, utilisez le numéro dans l'ordre, en commençant par le bord le plus long.\r\n" +
        "Les longueurs de bord sont couramment utilisées.\r\n" +
        "Le paramètre est utilisé dans les substitutions %bandings% et %slopes%.",
      "Parçanın kenarlarını (uçlarını) belirtmek için, en uzun kenardan başlayarak sırayla numarayı kullanın.\r\n" +
        "Kenar uzunlukları yaygın olarak kullanılır.\r\n" +
        "Ayar %bandings% ve %slopes% ikamelerinde kullanılır."};

    public static readonly string[] VolumeTip = {
      "Add to the part volume to calculate the price of other materials.",
      "Добавка к объему детали для вычисления цены прочих материалов.",
      "Aggiungi al volume della parte per calcolare il prezzo di altri materiali.",
      "Fügen Sie dem Teilvolumen hinzu, um den Preis anderer Materialien zu berechnen.",
      "添加到零件体积以计算其他材料的价格。",
      "Agregar al volumen de la pieza para calcular el precio de otros materiales.",
      "Ajouter au volume de la pièce pour calculer le prix des autres matériaux.",
      "Diğer malzemelerin fiyatını hesaplamak için parça hacmine ekleyin."};

    public static readonly string[] DecimalTip = {
      "The number of significant decimal digits in the calculation.\r\n" +
        "The more - the more precise calculations. But AutoCAD|BricsCAD cruel lie since the seventh digit.\r\n" +
        "Change with caution!",
      "Количество значащих десятичных цифр в геометрических расчетах.\r\n" +
        "Чем больше - тем точнее расчеты.  Но Автокад жестоко врет начиная с 7ого знака.\r\n" +
        "Изменять с осторожностью!",
      "Il numero di cifre decimali significative nel calcolo.\r\n" +
        "Maggiore è il numero - più preciso è il calcolo. Ma AutoCAD|BricsCAD crudele menzogna dal momento che la settima cifra.\r\n" +
        "Modificare con cautela!",
      "Die Anzahl signifikanter Dezimalstellen in der Berechnung."+
         "Je mehr - desto genauere Berechnungen. Aber AutoCAD|BricsCAD liegt grausam seit der siebten Ziffer.\r\n" +
         "Umsteigen mit Vorsicht!",
      "计算中的有效小数位数。\r\n" +
         "越多 - 计算越精确。但 AutoCAD|BricsCAD 残酷的谎言从第七位开始。\r\n" +
         "谨慎改变！",
      "El número de dígitos decimales significativos en el cálculo.\r\n" +
        "Cuanto más - más precisos son los cálculos. Pero AutoCAD|BricsCAD miente cruelmente desde el séptimo dígito.\r\n" +
        "¡Cambie con precaución!",
      "Le nombre de chiffres décimaux significatifs dans le calcul.\r\n" +
        "Plus il y en a - plus les calculs sont précis. Mais AutoCAD|BricsCAD ment cruellement depuis le septième chiffre.\r\n" +
        "Changez avec prudence!",
      "Hesaplamadaki önemli ondalık basamak sayısı.\r\n" +
        "Ne kadar çok - hesaplamalar o kadar hassas. Ancak AutoCAD|BricsCAD yedinci basamaktan beri acımasızca yalan söylüyor.\r\n" +
        "Dikkatli değiştirin!"};

    public static readonly string[] LinearTip = {
      "The maximum allowable deviation.\r\n" +
        "It is used to compare the distances between points to define linearity and plane.\r\n" +
        "It uses current drawing units (mm or inch).\r\n" +
        "Change with caution!",
      "Максимально допустимое отклонение.\r\n" +
        "В единицах текущего чертежа (мм или дюймы).\r\n" +
        "Используется для сравнения расстояний между точками, для определения линейности и плоскости.\r\n" +
        "Изменять с осторожностью!",
      "La deviazione massima consentita.\r\n" +
        "Nelle unità di disegno correnti (mm o pollici).\r\n" +
        "Viene utilizzato per confrontare le distanze tra i punti, per definire linearità e area.\r\n" +
        "Modificare con cautela!",
      "Die maximal zulässige Abweichung. In den aktuellen Zeichnungseinheiten (mm oder Zoll).\r\n" +
         "Es wird verwendet, um die Abstände zwischen Punkten zu vergleichen, um Linearität und Ebene zu definieren.\r\n" +
         "Umsteigen mit Vorsicht!",
      "最大允许偏差。 以当前的绘图单位（毫米或英寸）。\r\n" +
         "它用于比较点之间的距离，用于定义线性和平面。\r\n" +
         "谨慎改变！",
      "La desviación máxima permitida.\r\n" +
        "Se utiliza para comparar las distancias entre puntos para definir linealidad y plano.\r\n" +
        "Utiliza unidades de dibujo actuales (mm o pulgadas).\r\n" +
        "¡Cambie con precaución!",
      "L'écart maximal autorisé.\r\n" +
        "Il est utilisé pour comparer les distances entre les points pour définir la linéarité et le plan.\r\n" +
        "Il utilise les unités de dessin actuelles (mm ou pouces).\r\n" +
        "Changez avec prudence!",
      "İzin verilen maksimum sapma.\r\n" +
        "Doğrusallık ve düzlemi tanımlamak için noktalar arasındaki mesafeleri karşılaştırmak için kullanılır.\r\n" +
        "Geçerli çizim birimlerini kullanır (mm veya inç).\r\n" +
        "Dikkatli değiştirin!"};

    public static readonly string[] MarkingColorTip = {
      "The color index used to mark the front side. From 1 to 255.\r\n" +
        "Write 0 so that any color is used to mark the front.\r\n" +
        "Do not use this color for layers and solids themselves.\r\n" +
        "You can peek color indices in the standard color selection dialog.\r\n" +
        "For example, 1 is red.",
      "Индекс цвета, используемый для маркировки фасадной стороны. От 1 до 255.\r\n" +
        "Напишите 0, чтоб любой цвет раскраски использовался для маркировки фасадов.\r\n" +
        "Не используйте этот цвет для слоев и самих солидов.\r\n" +
        "Индексы цветов вы можете подсмотреть в стандартном диалоге выбора цвета.\r\n" +
        "Например, 1 - это красный цвет.",
      "L'indice di colore utilizzato per contrassegnare il lato anteriore. Da 1 a 255.\r\n" +
        "Scrivi 0 in modo che ogni colore di colore venga utilizzato per contrassegnare le facciate.\r\n" +
        "Non utilizzare questo colore per strati e solidi stessi.\r\n" +
        "È possibile visualizzare gli indici di colore nella finestra di dialogo di selezione dei colori standard.\r\n" +
        "Ad esempio, 1 è rosso.",
      "Der Farbindex, der zur Kennzeichnung der Vorderseite verwendet wird. Von 1 bis 255.\r\n" +
         "Schreiben Sie 0, damit eine beliebige Farbe verwendet wird, um die Vorderseite zu markieren.\r\n" +
         "Verwenden Sie diese Farbe nicht für Ebenen und Volumenkörper selbst.\r\n" +
         "Sie können Farbindizes im Standard-Farbauswahldialog einsehen.\r\n" +
         "Zum Beispiel ist 1 rot.",
      "用于标记正面的颜色索引。 从 1 到 255。\r\n" +
         "写0，这样任何颜色都可以用来标记前面。\r\n" +
         "不要将这种颜色用于图层和实体本身。\r\n" +
         "您可以在标准颜色选择对话框中查看颜色索引。\r\n" +
         "例如，1 是红色的。",
      "El índice de color utilizado para marcar el lado frontal. De 1 a 255.\r\n" +
        "Escriba 0 para que cualquier color se use para marcar el frente.\r\n" +
        "No use este color para capas y sólidos en sí mismos.\r\n" +
        "Puede ver los índices de color en el cuadro de diálogo de selección de color estándar.\r\n" +
        "Por ejemplo, 1 es rojo.",
      "L'indice de couleur utilisé pour marquer la face avant. De 1 à 255.\r\n" +
        "Écrivez 0 pour que n'importe quelle couleur soit utilisée pour marquer l'avant.\r\n" +
        "N'utilisez pas cette couleur pour les calques et les solides eux-mêmes.\r\n" +
        "Vous pouvez consulter les indices de couleur dans la boîte de dialogue de sélection de couleur standard.\r\n" +
        "Par exemple, 1 est rouge.",
      "Ön tarafı işaretlemek için kullanılan renk dizini. 1'den 255'e kadar.\r\n" +
        "Herhangi bir rengin ön tarafı işaretlemek için kullanılması için 0 yazın.\r\n" +
        "Bu rengi katmanlar ve katıların kendileri için kullanmayın.\r\n" +
        "Standart renk seçim iletişim kutusunda renk dizinlerine göz atabilirsiniz.\r\n" +
        "Örneğin, 1 kırmızıdır."};

    public static readonly string[] TemplateTip = {
      "Drawing from which to take the layers settings, blocks, materials, layouts...\r\n" +
        "Leave blank to use the template settings from QNew template.",
      "Чертеж, из которого следует брать типовые слои, материалы, стили, листы, таблицы и блоки.\r\n" +
        "Оставьте поле пустым, чтоб использовать шаблон из настроек AutoCAD|BricsCAD (Шаблон для QNew)",
      "Disegno da cui prendere le impostazioni layer.\r\n" +
        "Lasciare vuoto per utilizzare le impostazioni del modello da modello QNew",
      "Zeichnung, aus der die Ebeneneinstellungen, Blöcke, Materialien, Layouts ...\r\n" +
         "Leer lassen, um die Vorlageneinstellungen aus der QNew-Vorlage zu verwenden.",
      "从中获取图层设置、块、材料、布局的绘图...\r\n" +
         "留空以使用 QNew 模板中的模板设置。",
      "Dibujo del cual tomar la configuración de capas, bloques, materiales, diseños...\r\n" +
        "Deje en blanco para usar la configuración de plantilla de la plantilla QNew.",
      "Dessin à partir duquel prendre les paramètres de calques, blocs, matériaux, mises en page...\r\n" +
        "Laissez vide pour utiliser les paramètres de modèle du modèle QNew.",
      "Katman ayarlarının, blokların, malzemelerin, düzenlerin alınacağı çizim...\r\n" +
        "QNew şablonundan şablon ayarlarını kullanmak için boş bırakın."};

    public static readonly string[] Cost = {
      "Cost calculation",
      "Вычисление цены",
      "Calcolo dei costi",
      "Kostenkalkulation",
      "成本计算",
      "Cálculo de costos",
      "Calcul des coûts",
      "Maliyet hesaplama"};

    public static readonly string[] Measurement = {
      "Solid Measurement Priorities",
      "Приоритеты обмера и выкладки деталей",
      "Priorità di misurazione solide",
      "Solide Messprioritäten",
      "可靠的测量优先级",
      "Prioridades de medición de sólidos",
      "Priorités de mesure solide",
      "Katı ölçüm öncelikleri"};

    public static readonly string[] Substitutions = {
      "Substitution",
      "Подстановки",
      "Sostituzioni",
      "Auswechslung",
      "替代",
      "Sustitución",
      "Substitution",
      "İkame"};

    public static readonly string[] Tolerance = {
      "Tolerance",
      "Точность",
      "Precisione",
      "Toleranz",
      "宽容",
      "Tolerancia",
      "Tolérance",
      "Tolerans"};

    public static readonly string[] Banding = {
      "Offcut for Banding",
      "Обрезок кромки",
      "Rifilatura dei bordi",
      "Verschnitt zum Banderolieren",
      "带边裁切",
      "Desperdicio para canto",
      "Chute pour chant",
      "Kenar için kesinti"};

    public static readonly string[] Cover = {
      "% of Cover",
      "% покрытия",
      "% di rivestimente",
      "% der Abdeckung",
      "保险百分比",
      "% de cobertura",
      "% de couverture",
      "% kaplama"};

    public static readonly string[] MarkingColor = {
      "Marking color index",
      "Цвет маркировки",
      "Colore di marcatura",
      "Markierungsfarbindex",
      "标记颜色指数",
      "Índice de color de marcado",
      "Indice de couleur de marquage",
      "İşaretleme renk dizini"};

    public static readonly string[] NoAvailable = {
      "No Available",
      "Нет данных",
      "Non disponibile",
      "Nicht verfügbar",
      "不可用",
      "No disponible",
      "Non disponible",
      "Mevcut değil"};

    public static readonly string[] Rod = {
      "Offcut for Rod",
      "Обрезок хлыста",
      "Scarti di asta",
      "Verschnitt für Rod",
      "杆的边角料",
      "Desperdicio para varilla",
      "Chute pour tige",
      "Çubuk için kesinti"};

    public static readonly string[] Sheet = {
      "% of Sheet",
      "% листа",
      "% del foglio",
      "% des Blattes",
      "纸张百分比",
      "% de hoja",
      "% de feuille",
      "% levha"};

    public static readonly string[] Technologies = {
      "Technologies",
      "Технологии",
      "Tecnologia",
      "Technologien",
      "技术",
      "Tecnologías",
      "Technologies",
      "Teknolojiler"};

    public static readonly string[] Texture = {
      "Textures",
      "Текстуры",
      "Texture",
      "Textures",
      "纹理",
      "Texturas",
      "Textures",
      "Dokular"};

    public static readonly string[] Volume = {
      "% of Volume",
      "% объема",
      "% di volume",
      "% des Volumens",
      "体积百分比",
      "% de volumen",
      "% de volume",
      "% hacim"};

    public static readonly string[] Decimal = {
      "Decimal digit round",
      "Десятичных знаков",
      "Tondo cifre decimali",
      "Dezimalziffer rund",
      "小数位圆",
      "Redondeo de dígitos decimales",
      "Arrondi de chiffres décimaux",
      "Ondalık basamak yuvarlama"};

    public static readonly string[] LinearTolerance = {
      "InSize tolerance",
      "Линейная точность",
      "Precisione lineare",
      "InSize-Toleranz",
      "衬垫公差",
      "Tolerancia InSize",
      "Tolérance InSize",
      "InSize toleransı"};

    public static readonly string[] TextureTip = {
      "List of texture names: no texture,along,across.\r\n" +
        "The list should have strictly three options separated by semicolons.",
      "Список названий текстур: нет текстуры,вдоль,поперек\r\n" +
        "В списке должно быть строго три варианта, разделенных точкой с запятой без лишних пробелов.",
      "Elenco dei nomi delle texture:\r\n" +
        "nessuna texture,lungo,traverso\r\n" +
        "L'elenco dovrebbe avere rigorosamente tre opzioni separate da punto e virgola.",
      "Liste der Texturnamen: keine Textur,eine lange,über.\r\n"+
         "Die Liste sollte genau drei Optionen haben, die durch Semikolons getrennt sind.",
      "纹理名称列表：无纹理,沿着,穿过。\r\n" +
         "该列表应严格包含三个用分号分隔的选项。",
      "Lista de nombres de texturas: sin textura,a lo largo,a través.\r\n" +
        "La lista debe tener estrictamente tres opciones separadas por punto y coma.",
      "Liste des noms de texture: pas de texture,le long,à travers.\r\n" +
        "La liste doit avoir strictement trois options séparées par des points-virgules.",
      "Doku adları listesi: doku yok,boyunca,karşıdan.\r\n" +
        "Liste kesinlikle noktalı virgülle ayrılmış üç seçeneğe sahip olmalıdır."};

    public static readonly string[] TechnoTip = {
      "List of technology names: Box;Sweep;Saw;Milling;Double-side;3D Milling;Cut Pipe;Processed Pipe;Unknown.\r\n" +
        "The list should have strictly 9 variants separated by semicolons without extra spaces.",
      "Список названий технологий:\r\n" +
        "Бокс;Развертка;Напилка;Фрезеровка;Двусторонняя;3D Фрезеровка;Резка трубы;Обработка трубы;Не распознано\r\n" +
        "В списке должно быть строго 9 вариантов, разделенных точкой с запятой без лишних пробелов.",
      "Elenco dei nomi delle tecnologie:\r\n" +
        "Parallelepipedo;Scansione;Sega;Fresatura;Due lati;3D Fresatura;Tagliare il tubo;Tubo lavorato;Sconosciuto\r\n" +
        "L'elenco dovrebbe avere rigorosamente 9 varianti separate da punto e virgola senza spazi aggiuntivi.",
      "Liste der Technologienamen: Box;Fegen;Sah;Mahlen;Doppelseitig;3D-Fräsen;Rohr abschneiden;Bearbeitetes Rohr;Unbekannt.\r\n" +
         "Die Liste sollte streng 9 Varianten haben, die durch Semikolons ohne zusätzliche Leerzeichen getrennt sind.",
      "技术名称列表：盒子;扫;锯;铣削;双面;3D 铣削;切管;加工管材;未知。\r\n" +
         "该列表应该有严格的 9 个变体，用分号分隔，没有多余的空格。",
      "Lista de nombres de tecnología: Caja;Barrido;Sierra;Fresado;Doble cara;Fresado 3D;Cortar tubo;Tubo procesado;Desconocido.\r\n" +
        "La lista debe tener estrictamente 9 variantes separadas por punto y coma sin espacios adicionales.",
      "Liste des noms de technologie: Boîte;Balayage;Scie;Fraisage;Double face;Fraisage 3D;Couper le tuyau;Tuyau traité;Inconnu.\r\n" +
        "La liste doit avoir strictement 9 variantes séparées par des points-virgules sans espaces supplémentaires.",
      "Teknoloji adları listesi: Kutu;Süpürme;Testere;Frezeleme;Çift taraflı;3D Frezeleme;Boru kesme;İşlenmiş boru;Bilinmeyen.\r\n" +
        "Liste kesinlikle noktalı virgülle ayrılmış, fazladan boşluk olmayan 9 varyanta sahip olmalıdır."};

    public static readonly string[] ResetDialogs = {
      "Reset Dialogs",
      "Сбросить Диалоги",
      "Ripristina finestre di dialogo",
      "Dialoge zurücksetzen",
      "重置对话框",
      "Restablecer diálogos",
      "Réinitialiser les dialogues",
      "İletişim kutularını sıfırla"};

    public static readonly string[] ResetDialogsTip = {
      "Delete the saved dimensions and positions of the A>V>C> command setup dialogs. \r\n" +
        "This procedure saves you when dialog windows accidentally end up off the screen. \r\n" +
        "The procedure can be called with the command AvcResetDialogs",
      "Удалить сохраненные размеры и положение диалогов настройки команд A>V>C>. \r\n" +
        "Данная процедура спасает, когда окна диалогов случайно оказываются за пределами экрана. \r\n" +
        "Процедуру можно вызвать командой AvcResetDialogs",
      "Elimina le dimensioni e le posizioni salvate delle finestre di dialogo delle impostazioni del comando A>V>C>. \r\n" +
        "Questa procedura ti salva quando le finestre di dialogo finiscono accidentalmente fuori dallo schermo. \r\n" +
        "La procedura può essere richiamata con il comando AvcResetDialogs",
      "Löschen Sie die gespeicherten Abmessungen und Positionen der A>V>C>-Befehlseinstellungsdialoge. \r\n" +
        "Dieses Verfahren erspart Ihnen den Fall, dass Dialogfenster versehentlich nicht auf dem Bildschirm angezeigt werden. \r\n" +
        "Die Prozedur kann mit dem Befehl AvcResetDialogs aufgerufen werden",
      "删除 A>V>C> 命令设置对话框中保存的尺寸和位置。 \r\n" +
        "当对话框窗口意外地从屏幕上消失时，此过程可以为您提供帮助。 \r\n" +
        "可以使用命令 AvcResetDialogs 调用该过程",
      "Eliminar las dimensiones y posiciones guardadas de los diálogos de configuración de comandos A>V>C>. \r\n" +
        "Este procedimiento te salva cuando las ventanas de diálogo terminan accidentalmente fuera de la pantalla. \r\n" +
        "El procedimiento puede ser llamado con el comando AvcResetDialogs",
      "Supprimer les dimensions et positions enregistrées des boîtes de dialogue de configuration de commande A>V>C>. \r\n" +
        "Cette procédure vous sauve lorsque les fenêtres de dialogue se retrouvent accidentellement hors de l'écran. \r\n" +
        "La procédure peut être appelée avec la commande AvcResetDialogs",
      "A>V>C> komut kurulum iletişim kutularının kaydedilmiş boyutlarını ve konumlarını silin. \r\n" +
        "Bu prosedür, iletişim kutusu pencereleri yanlışlıkla ekran dışında kaldığında sizi kurtarır. \r\n" +
        "Prosedür AvcResetDialogs komutuyla çağrılabilir"};

    public static readonly string[] ResetDialogsDone = {
      "Settings have been reset. All dialogs will open in the middle of the screen.",
      "Настройки сброшены. Все диалоги будут открываться в середине экрана.",
      "Le impostazioni sono state ripristinate. Tutte le finestre di dialogo si apriranno al centro dello schermo.",
      "Die Einstellungen wurden zurückgesetzt. Alle Dialoge werden in der Mitte des Bildschirms geöffnet.",
      "设置已重置。 所有对话框都将在屏幕中间打开。",
      "Los ajustes han sido restablecidos. Todos los diálogos se abrirán en el centro de la pantalla.",
      "Les paramètres ont été réinitialisés. Toutes les boîtes de dialogue s'ouvriront au milieu de l'écran.",
      "Ayarlar sıfırlandı. Tüm iletişim kutuları ekranın ortasında açılacak."};

    public static readonly string[] InfoLog = {
      "Info message to Events Log",
      "Информация в системный лог",
      "Informazioni nel registro di sistema",
      "Informationen im Systemprotokoll",
      "系统日志中的信息",
      "Mensaje de información al registro de eventos",
      "Message d'information dans le journal des événements",
      "Olay Günlüğüne bilgi mesajı"};

    public static readonly string[] InfoLogTip = {
      "Save information about programs work in Windows Event Log.\r\n" +
        "Not recomended. Use only for debugging.",
      "Сохранение всех сообщений программ A>V>C> \r\n" +
        "в системный лог Windows (Журнал событий).\r\n" +
        "Не рекомендуется включать. Предназначено только для отладки программ.",
      "Salva le informazioni sul lavoro dei programmi nel registro eventi di Windows.\r\n" +
         "Non consigliato. Utilizzare solo per il debug.",
      "Speichern Sie Informationen über die Programmarbeit im Windows-Ereignisprotokoll.\r\n" +
         "Nicht empfohlen. Nur zum Debuggen verwenden.",
      "将有关程序工作的信息保存在 Windows 事件日志中。\r\n" +
         "不推荐。仅用于调试。",
      "Guardar información sobre el trabajo de los programas en el Registro de eventos de Windows.\r\n" +
        "No recomendado. Usar solo para depuración.",
      "Enregistrer des informations sur le travail des programmes dans le Journal des événements Windows.\r\n" +
        "Non recommandé. À utiliser uniquement pour le débogage.",
      "Windows Olay Günlüğüne program çalışması hakkında bilgi kaydedin.\r\n" +
        "Önerilmez. Yalnızca hata ayıklama için kullanın."};

    public static readonly string[] WarningPopup = {
      "Warning message to pop-up window",
      "Предупреждения во всплывающих окнах",
      "Messaggio di avviso alla finestra pop-up",
      "Warnmeldung im Popup-Fenster",
      "弹出窗口的警告信息",
      "Mensaje de advertencia en ventana emergente",
      "Message d'avertissement dans la fenêtre contextuelle",
      "Açılır pencerede uyarı mesajı"};

    public static readonly string[] WarningPopupTip = {
      "A>V>C> warning messages will be displayed not only in the command line,\r\n" +
        "but also displayed on the screen a separate window (recommended)",
      "Предупреждения программ A>V>C> будут выводится не только в командную строку,\r\n" +
        "но и отдельным всплывающим окном. Рекомендуется включать. ",
      "I messaggi di avviso A>V>C> verranno visualizzati non solo nella riga di comando,\r\n" +
         "ma mostrava anche sullo schermo una finestra separata (consigliato)",
      "A>V>C> Warnmeldungen werden nicht nur in der Kommandozeile angezeigt\r\n" +
         "aber auch auf dem Bildschirm ein separates Fenster angezeigt (empfohlen)",
      "A>V>C> 警告信息不仅会显示在命令行中，"+
         "还能在屏幕上显示一个单独的窗口（推荐）",
      "Los mensajes de advertencia A>V>C> se mostrarán no solo en la línea de comandos,\r\n" +
        "sino también en una ventana separada en la pantalla (recomendado)",
      "Les messages d'avertissement A>V>C> seront affichés non seulement dans la ligne de commande,\r\n" +
        "mais aussi affichés à l'écran dans une fenêtre séparée (recommandé)",
      "A>V>C> uyarı mesajları yalnızca komut satırında değil,\r\n" +
        "aynı zamanda ekranda ayrı bir pencerede görüntülenecektir (önerilir)"};

    public static readonly string[] ErrPopup = {
      "Error message to pop-up window",
      "Ошибки во всплывающих окнах",
      "Messaggio di errore nella finestra pop-up",
      "Fehlermeldung im Popup-Fenster",
      "弹出窗口的错误信息",
      "Mensaje de error en ventana emergente",
      "Message d'erreur dans la fenêtre contextuelle",
      "Açılır pencerede hata mesajı"};

    public static readonly string[] ErrPopupTip = {
      "A>V>C> error messages will be displayed not only in the command line,\r\n" +
        "but also displayed on the screen a separate window (recommended)",
      "Сообщения об ошибках программ A>V>C> будут выводится не только в командную строку,\r\n" +
        "но и отдельным всплывающим окном. Рекомендуется включать. ",
      "I messaggi di errore A>V>C> verranno visualizzati non solo nella riga di comando,\r\n" +
         "ma mostrava anche sullo schermo una finestra separata (consigliato)",
      "A>V>C> Fehlermeldungen werden nicht nur in der Kommandozeile angezeigt\r\n" +
         "aber auch auf dem Bildschirm ein separates Fenster angezeigt (empfohlen)",
      "A>V>C> 错误信息不仅会显示在命令行中，"+
         "还能在屏幕上显示一个单独的窗口（推荐）",
      "Los mensajes de error A>V>C> se mostrarán no solo en la línea de comandos,\r\n" +
        "sino también en una ventana separada en la pantalla (recomendado)",
      "Les messages d'erreur A>V>C> seront affichés non seulement dans la ligne de commande,\r\n" +
        "mais aussi affichés à l'écran dans une fenêtre séparée (recommandé)",
      "A>V>C> hata mesajları yalnızca komut satırında değil,\r\n" +
        "aynı zamanda ekranda ayrı bir pencerede görüntülenecektir (önerilir)"};

    public static readonly string[] MailErr = {
      "Error message to programmer e-mail",
      "Отправка ошибок разработчику",
      "Invio di bug allo sviluppatore",
      "Senden von Fehlern an den Entwickler",
      "向开发人员提交错误",
      "Mensaje de error al correo electrónico del programador",
      "Message d'erreur à l'e-mail du programmeur",
      "Programcı e-postasına hata mesajı"};

    public static readonly string[] MailErrTip = {
      "A>V>C> error messages will be send to author of this program (to avc.programming@gmail.com).\r\n" +
        "The letter will contain all the details of the error,\r\n" +
        "the information about the version of program and OS.\r\n" +
        "The letter will NOT have any data on the purity of the licensed AutoCAD, BricsCAD, Windows.\r\n" +
        "(recommended, if you're not paranoid)",
      "Сообщения об ошибках в работе программ A>V>C> будут автоматически отправляться \r\n" +
        "на почтовый адрес разработчика avc.programming@gmail.com. \r\n" +
        "В сообщении будет подробная информация об ошибке, версия программы и ОС. В сообщении НЕ передается никакой\r\n" +
        "информации о лицензионности AutoCAD|BricsCAD, Windows.\r\n" +
        "(Рекомендуется включать, если вы не параноик)",
      "A>V>C> I messaggi di errore verranno inviati all'autore del programma (inviato a avc.programming@gmail.com). "+
          "Questa lettera conterrà tutti i dettagli dell'errore,\r\n" +
          "Informazioni su programmi e versioni del sistema operativo.\r\n" +
          "Questa lettera non conterrà alcun dato relativo alla purezza di AutoCAD, BricsCAD, Windows con licenza.\r\n" +
          "(consigliato, se non sei paranoico)",
      "A>V>C> Fehlermeldungen werden an den Autor des Programms gesendet (gesendet an avc.programming@gmail.com)."+
          "Dieser Brief enthält alle Einzelheiten des Fehlers,\r\n" +
          "Informationen zu Programmen und Betriebssystemversionen.\r\n" +
          "Dieses Schreiben enthält keine Angaben zur Reinheit von lizenziertem AutoCAD, BricsCAD, Windows.\r\n" +
          "(empfohlen, wenn Sie nicht paranoid sind)",
      "A>V>C> 错误消息将发送给该程序的作者（发送至 avc.programming@gmail.com）。\r\n" +
         "这封信将包含错误的所有详细信息，\r\n" +
         "有关程序和操作系统版本的信息。\r\n" +
         "这封信不会包含任何关于许可 AutoCAD、BricsCAD、Windows 纯度的数据。\r\n" +
         "（推荐，如果你不是偏执狂的话）",
      "Los mensajes de error A>V>C> se enviarán al autor de este programa (a avc.programming@gmail.com).\r\n" +
        "La carta contendrá todos los detalles del error,\r\n" +
        "la información sobre la versión del programa y el sistema operativo.\r\n" +
        "La carta NO tendrá ningún dato sobre la pureza de AutoCAD, BricsCAD, Windows con licencia.\r\n" +
        "(recomendado, si no eres paranoico)",
      "Les messages d'erreur A>V>C> seront envoyés à l'auteur de ce programme (à avc.programming@gmail.com).\r\n" +
        "La lettre contiendra tous les détails de l'erreur,\r\n" +
        "les informations sur la version du programme et du système d'exploitation.\r\n" +
        "La lettre n'aura AUCUNE donnée sur la pureté d'AutoCAD, BricsCAD, Windows sous licence.\r\n" +
        "(recommandé, si vous n'êtes pas paranoïaque)",
      "A>V>C> hata mesajları bu programın yazarına gönderilecektir (avc.programming@gmail.com'a).\r\n" +
        "Mektup hatanın tüm ayrıntılarını içerecektir,\r\n" +
        "program ve işletim sistemi sürümü hakkında bilgi.\r\n" +
        "Mektup lisanslı AutoCAD, BricsCAD, Windows'un saflığı hakkında herhangi bir veri içermeyecektir.\r\n" +
        "(paranoyak değilseniz önerilir)"};

    public static readonly string[] SweepMeasure = {
      "Sweep Measurement Mode",
      "Способ обмера разверток",
      "Modalità di misurazione a scansione",
      "Sweep-Messmodus",
      "扫描测量模式",
      "Modo de medición de barrido",
      "Mode de mesure de balayage",
      "Süpürme ölçüm modu"};

    public static readonly string[] LongerSide = {
      "Longer side",
      "Длинная сторона",
      "Lato più lungo",
      "Längere Seite",
      "较长的一边",
      "Lado más largo",
      "Côté plus long",
      "Daha uzun taraf"};

    public static readonly string[] LongerSideTip = {
      "The longer one is selected from the two sides of the bent part.",
      "Из двух сторон согнутой детали выбирается более длинная",
      "Tra i due lati della parte piegata si sceglie quello più lungo.",
      "Aus den beiden Seiten des gebogenen Teils wird die längere ausgewählt.",
      "从弯曲部分的两侧选择较长的一个。",
      "Se selecciona el más largo de los dos lados de la pieza doblada.",
      "Le plus long est sélectionné parmi les deux côtés de la pièce courbée.",
      "Bükülmüş parçanın iki tarafından daha uzun olanı seçilir."};

    public static readonly string[] LongerSegments = {
      "Longer segments",
      "Длинные сегменты",
      "Segmenti più lunghi",
      "Längere Segmente",
      "较长的段",
      "Segmentos más largos",
      "Segments plus longs",
      "Daha uzun segmentler"};

    public static readonly string[] LongerSegmentsTip = {
      "For parts with many bends in different directions, \r\n" +
        "the longer side is selected on each part segment and the sum of the segment lengths is calculated.",
      "Для деталей с множеством изгибов в разные стороны, \r\n" +
        "на каждом сегменте детали выбирается более длинная сторона и вычисляется сумма длин сегментов.",
      "Per le parti con molte pieghe in direzioni diverse, \r\n" +
        "viene selezionato il lato più lungo su ciascun segmento della parte \r\n" +
        "e viene calcolata la somma delle lunghezze dei segmenti.",
      "Bei Teilen mit vielen Biegungen in verschiedene Richtungen wird für jedes \r\n" +
        "Teilsegment die längere Seite ausgewählt und die Summe der Segmentlängen berechnet.",
      "对于在不同方向上有多个折弯的零件，\r\n" +
        "在每个零件段上选择较长的一侧，并计算段长度的总和。",
      "Para piezas con muchas curvas en diferentes direcciones, \r\n" +
        "se selecciona el lado más largo en cada segmento de pieza y se calcula la suma de las longitudes de los segmentos.",
      "Pour les pièces avec de nombreuses courbures dans différentes directions, \r\n" +
        "le côté le plus long est sélectionné sur chaque segment de pièce et la somme des longueurs de segments est calculée.",
      "Farklı yönlerde birçok bükülmeye sahip parçalar için, \r\n" +
        "her parça segmentinde daha uzun taraf seçilir ve segment uzunluklarının toplamı hesaplanır."};

    public static readonly string[] MiddleLine = {
      "Middle line",
      "Средняя линия",
      "Linea di mezzo",
      "Mittellinie",
      "中线",
      "Línea media",
      "Ligne médiane",
      "Orta çizgi"};

    public static readonly string[] MiddleLineTip = {
      "The average value between the lengths of both sides of the part is used",
      "Используется среднее значение между длинами обоих сторон детали",
      "Usiamo il valore medio tra le lunghezze di entrambi i lati della parte",
      "Wir verwenden den Durchschnittswert zwischen den Längen beider Seiten des Teils",
      "我们使用零件两侧长度之间的平均值",
      "Se utiliza el valor promedio entre las longitudes de ambos lados de la pieza",
      "La valeur moyenne entre les longueurs des deux côtés de la pièce est utilisée",
      "Parçanın her iki tarafının uzunlukları arasındaki ortalama değer kullanılır"};
  }
}

