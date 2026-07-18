// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация команды Nesting
  /// </summary>
  public static class 
  NestingL
  {

    public static readonly string[][] NestingStyleNames = {
/* 0 */ CommandL.Nesting,
/* 1 */ CommandL.Nesting,
                                      
    };

    public static readonly string[] StyleSelected = {
      "  Nesting style '{0}' selected",
      "  Выбран стиль нестинга '{0}'",
      "  Nesting-Stile '{0}' selezionato",
      "  Nesting-Stil '{0}' ausgewählt",
      "  选择的嵌套样式为：'{0}'",
      "  Estilo Nesting '{0}' seleccionado",                         // ES
      "  Style Nesting '{0}' sélectionné",                           // FR
      "  Nesting stili '{0}' seçildi"};                              // TR

    public static readonly string[] StyleNameTip = {
      "Name of the current nesting style",
      "Имя текущего стиля нестинга",
      "Nome dello stile di nesting corrente",
      "Name des aktuellen Nesting-Stils",
      "当前嵌套样式的名称",
      "Nombre del estilo Nesting actual",
      "Nom du style Nesting actuel",
      "Geçerli nesting stilinin adı"};

    public static readonly string[] Grouping = {
      "Grouping by materials",
      "Группировка по материалам",
      "Raggruppamento per materiali",
      "Gruppierung nach Materialien",
      "按材料分组",
      "Agrupación por materiales",
      "Regroupement par matériaux",
      "Malzemelere göre gruplama"};

    public static readonly string[] GroupTip = {
      "Mask for the group title. Parts with the same group value are laid out on separate sheets.\r\n" +
        "It's very important that only parts made of the same material are included in a single group.\r\n" +
        "It's recommended to use the %mat% substitution.\"",
      "Маска заголовка группы. Детали с одинаковым значением группы раскладываются на отдельных листах.\r\n" +
        "Очень важно, чтоб в одну группу попали только детали из одинакового материала.\r\n" +
        "Рекомендуется использовать подстановку %mat%",
      "Maschera per il titolo del gruppo. Le parti con lo stesso valore di gruppo vengono disposte su fogli separati.\r\n" +
        "È molto importante che solo le parti realizzate con lo stesso materiale siano incluse in un unico gruppo.\r\n" +
        "Si consiglia di utilizzare la sostituzione %mat%",
      "Maske für den Gruppentitel. Teile mit demselben Gruppenwert werden auf separaten Blättern angeordnet.\r\n" +
        "Es ist sehr wichtig, dass nur Teile aus demselben Material in eine Gruppe aufgenommen werden.\r\n" +
        "Es wird empfohlen, die Substitution %mat% zu verwenden.",
      "组标题的掩码。具有相同组值的零件布置在单独的板材上。\r\n" +
        "非常重要的是，只有由相同材料制成的零件才包含在一个组中。\r\n" +
        "建议使用 %mat% 替换。",
      "Máscara para el título del grupo. Las piezas con el mismo valor de grupo se colocan en hojas separadas.\r\n" +
        "Es muy importante que solo las piezas hechas del mismo material se incluyan en un solo grupo.\r\n" +
        "Se recomienda utilizar la sustitución %mat%",
      "Masque pour le titre du groupe. Les pièces ayant la même valeur de groupe sont disposées sur des feuilles séparées.\r\n" +
        "Il est très important que seules les pièces fabriquées dans le même matériau soient incluses dans un seul groupe.\r\n" +
        "Il est recommandé d'utiliser la substitution %mat%",
      "Grup başlığı için maske. Aynı grup değerine sahip parçalar ayrı levhalara yerleştirilir.\r\n" +
        "Sadece aynı malzemeden yapılmış parçaların tek bir gruba dahil edilmesi çok önemlidir.\r\n" +
        "%mat% ikamesini kullanmanız önerilir."};

    public static readonly string[] PartLable = {
      "Part label",
      "Метка детали",
      "Etichetta della parte",
      "Teilebeschriftung",
      "零件标签",
      "Etiqueta de la pieza",
      "Étiquette de la pièce",
      "Parça etiketi"};

    public static readonly string[] PartLableOn = {
      "Make part labels",
      "Создать метки деталей",
      "Crea etichette delle parti",
      "Teilebeschriftungen erstellen",
      "创建零件标签",
      "Crear etiquetas de piezas",
      "Créer des étiquettes de pièces",
      "Parça etiketleri oluştur"};

    public static readonly string[] PartLableTextTip = {
      "Part label template with substitutions for 3d-solid and drawing properties. \r\n" +
        "Line breaks and text formatting codes are allowed.",
      "Шаблон метки детали с подстановками свойств солида и чертежа. \r\n" +
        "Допустимы переносы строк и коды форматирования теста. ",
      "Modello di etichetta della parte con sostituzioni per le proprietà del solido 3D e del disegno. \r\n" +
        "Sono consentiti interruzioni di riga e codici di formattazione del testo.",
      "Teilebeschriftungsvorlage mit Ersetzungen für 3D-Volumenkörper- und Zeichnungseigenschaften. \r\n" +
        "Zeilenumbrüche und Textformatierungscodes sind zulässig.",
      "带有 3D 实体和图纸属性替换的零件标签模板。允许换行和文本格式代码。",
      "Plantilla de etiqueta de pieza con sustituciones para propiedades de sólido 3D y dibujo. \r\n" +
        "Se permiten saltos de línea y códigos de formato de texto.",
      "Modèle d'étiquette de pièce avec substitutions pour les propriétés du solide 3D et du dessin. " +
        "Les sauts de ligne et les codes de formatage de texte sont autorisés.",
      "3D katı ve çizim özellikleri için ikamelerle parça etiketi şablonu. \r\n" +
        "Satır sonları ve metin biçimlendirme kodlarına izin verilir."};

    public static readonly string[] PartGapTip = {
      "Gap between parts on the sheet",
      "Зазор между деталями на листе",
      "Distanza tra le parti sul foglio",
      "Abstand zwischen den Teilen auf dem Blatt",
      "板材上零件之间的间距",
      "Espacio entre las piezas en la hoja",
      "Espace entre les pièces sur la feuille",
      "Levha üzerindeki parçalar arasındaki boşluk"};

    public static readonly string[] SheetGap = {
      "Sheet border gap",
      "Отступ от края листа",
      "Distanza dal bordo del foglio",
      "Blattrandabstand",
      "板材边缘间距",
      "Espacio del borde de la hoja",
      "Espace du bord de la feuille",
      "Levha kenar boşluğu"};

    public static readonly string[] SheetGapTip = {
      "The gap between the parts and the edge of the sheet on all sides of the sheet of material.",
      "Отступ между деталями и краем листа со всех сторон листа материала.",
      "La distanza tra le parti e il bordo del foglio su tutti i lati del foglio di materiale.",
      "Der Abstand zwischen den Teilen und dem Blattrand auf allen Seiten des Materialblatts.",
      "材料板所有边缘上零件与板材边缘之间的间距。",
      "La distancia entre las piezas y el borde de la hoja en todos los lados de la hoja de material.",
      "L'écart entre les pièces et le bord de la feuille sur tous les côtés de la feuille de matériau.",
      "Malzeme levhasının tüm kenarlarında parçalar ile levha kenarı arasındaki boşluk."};

    public static readonly string[] SheetSpace = {
      "Sheet space",
      "Отступ между листами",
      "Spazio tra i fogli",
      "Blattabstand",
      "板材间距",
      "Espacio entre hojas",
      "Espace entre les feuilles",
      "Levhalar arası boşluk"};

    public static readonly string[] SheetSpaceTip = {
      "Space between sheets and groups on the layout.",
      "Отступ между листами и группами на раскладке.",
      "Spazio tra fogli e gruppi nel layout.",
      "Abstand zwischen Blättern und Gruppen im Layout.",
      "布局中板材与组之间的间距。",
      "Espacio entre hojas y grupos en el diseño.",
      "Espace entre les feuilles et les groupes dans la mise en page.",
      "Düzendeki levhalar ve gruplar arasındaki boşluk."};

    public static readonly string[] DefaultSheetSize = {
      "Default sheet",
      "Лист по умолчанию",
      "Foglio predefinito",
      "Standardblatt",
      "默认板材",
      "Hoja predeterminada",
      "Feuille par défaut",
      "Varsayılan levha"};

    public static readonly string[] DefaultSheetSizeTip = {
      "Material sheet settings for cases where solids don't have materials assigned or configured. \r\n" +
        "Or solids in the same group have different material settings.",
      "Настройки листа материала для случаев, когда материалы солидов не заданы или не настроены.\r\n " +
        "Либо солиды в одной группе имеют разные настройки материалов.",
      "Impostazioni del foglio di materiale per i casi in cui i solidi non hanno materiali assegnati o configurati. \r\n" +
        "Oppure i solidi nello stesso gruppo hanno impostazioni di materiale diverse.",
      "Materialblatt-Einstellungen für Fälle, in denen Volumenkörpern keine Materialien zugewiesen oder konfiguriert sind. \r\n" +
        "Oder Volumenkörper in derselben Gruppe haben unterschiedliche Materialeinstellungen.",
      "材料板设置，用于固体未分配或配置材料的情况。 \r\n" +
         "或者同一组中的固体具有不同的材料设置。",
      "Configuración de la hoja de material para casos en los que los sólidos no tienen materiales asignados o configurados. \r\n" +
        "O los sólidos en el mismo grupo tienen diferentes configuraciones de material.",
      "Paramètres de la feuille de matériau pour les cas où les solides n'ont pas de matériaux attribués ou configurés. \r\n" +
        "Ou les solides dans le même groupe ont des paramètres de matériau différents.",
      "Katılara malzeme atanmadığı veya yapılandırılmadığı durumlar için malzeme levhası ayarları. \r\n" +
        "Veya aynı gruptaki katılar farklı malzeme ayarlarına sahiptir."};
    public static readonly string[] GrainTip = {
      "The material has a noticeable surface pattern (grain/texture) along the sheet.\r\n" +
        "This setting is only used when the solid material is not specified or configured.",
      "Материал имеет заметный рисунок на поверхности (зернистость/текстуру) вдоль листа. \r\n" +
        "Настройка используется только для случая, когда материал солида не задан или не настроен",
      "Il materiale ha un motivo superficiale evidente (grana/struttura) lungo il foglio.\r\n" +
        "Questa impostazione viene utilizzata solo quando il materiale solido non è specificato o configurato.",
      "Das Material hat ein auffälliges Oberflächenmuster (Korn/Textur) entlang des Blattes.\r\n" +
        "Diese Einstellung wird nur verwendet, wenn das Volumenkörpermaterial nicht angegeben oder konfiguriert ist.",
      "材料沿板材具有明显的表面图案（纹理/纹理）。\r\n" +
         "仅当未指定或配置固体材料时，才使用此设置。",
      "El material tiene un patrón de superficie notable (grano/textura) a lo largo de la hoja.\r\n" +
        "Esta configuración solo se utiliza cuando el material sólido no está especificado o configurado.",
      "Le matériau présente un motif de surface notable (grain/texture) le long de la feuille.\r\n" +
        "Ce paramètre n'est utilisé que lorsque le matériau solide n'est pas spécifié ou configuré.",
      "Malzeme, levha boyunca belirgin bir yüzey deseni (tane/doku) içerir.\r\n" +
        "Bu ayar yalnızca katı malzeme belirtilmediğinde veya yapılandırılmadığında kullanılır."};

    public static readonly string[] DefaultSheetLengthTip = {
      "The length of the material sheet for the case when the material from the solids is not specified, does not have sheet dimensions, \r\n" +
        "or the solids in one group have different material lengths.",
      "Длина листа материала для случая, когда материал с солидов не задан, не имеет размеров листа \r\n" +
        "или солиды в одной группе имеют разную длину материалов.",
      "La lunghezza del foglio di materiale per il caso in cui il materiale dai solidi non è specificato, non ha dimensioni del foglio, \r\n" +
        "o i solidi in un gruppo hanno lunghezze di materiale diverse.",
      "Die Länge des Materialbogens für den Fall, dass das Material von den Volumenkörpern nicht angegeben ist, keine Bogenabmessungen hat, \r\n" +
        "oder die Volumenkörper in einer Gruppe unterschiedliche Materiallängen haben.",
      "材料板的长度，以防从固体中未指定材料，没有板材尺寸，\r\n" +
         "或者一组中的固体具有不同的材料长度。",
      "La longitud de la hoja de material para el caso en que el material de los sólidos no está especificado, no tiene dimensiones de hoja, \r\n" +
        "o los sólidos en un grupo tienen longitudes de material diferentes.",
      "La longueur de la feuille de matériau pour le cas où le matériau des solides n'est pas spécifié, n'a pas de dimensions de feuille, \r\n" +
        "ou les solides dans un groupe ont des longueurs de matériau différentes.",
      "Malzeme levhasının uzunluğu, katılardan malzeme belirtilmediğinde, levha boyutları yoksa \r\n" +
        "veya bir gruptaki katılar farklı malzeme uzunluklarına sahipse." };

    public static readonly string[] DefaultSheetWidthTip = {
      "The width of the material sheet for the case when the material from the solids is not specified, does not have sheet dimensions, \r\n" +
        "or the solids in one group have different material widths.",
      "Ширина листа материала для случая, когда материал с солидов не задан, не имеет размеров листа \r\n" +
        "или солиды в одной группе имеют разную ширину материалов.",
      "La larghezza del foglio di materiale per il caso in cui il materiale dai solidi non è specificato, non ha dimensioni del foglio, \r\n" +
        "o i solidi in un gruppo hanno larghezze di materiale diverse.",
      "Die Breite des Materialbogens für den Fall, dass das Material von den Volumenkörpern nicht angegeben ist, keine Bogenabmessungen hat, \r\n" +
        "oder die Volumenkörper in einer Gruppe unterschiedliche Materialbreiten haben.",
      "材料板的宽度，以防从固体中未指定材料，没有板材尺寸，\r\n" +
         "或者一组中的固体具有不同的材料宽度。",
      "La anchura de la hoja de material para el caso en que el material de los sólidos no está especificado, no tiene dimensiones de hoja, \r\n" +
        "o los sólidos en un grupo tienen anchos de material diferentes.",
      "La largeur de la feuille de matériau pour le cas où le matériau des solides n'est pas spécifié, n'a pas de dimensions de feuille, \r\n" +
        "ou les solides dans un groupe ont des largeurs de matériau différentes.",
      "Malzeme levhasının genişliği, katılardan malzeme belirtilmediğinde, levha boyutları yoksa \r\n" +
        "veya bir gruptaki katılar farklı malzeme genişliklerine sahipse." };

    public static readonly string[] GroupTitle = {
      "Group title",
      "Заголовок группы",
      "Titolo del gruppo",
      "Gruppentitel",
      "组标题",
      "Título del grupo",
      "Titre du groupe",
      "Grup başlığı"};

    public static readonly string[] GroupTitleTip = {
      "Create an MText object with a title for each sheet group.",
      "Создавать объект MText с заголовком для каждой группы листов.",
      "Crea un oggetto MText con un titolo per ogni gruppo di fogli.",
      "Erstellen Sie ein MText-Objekt mit einem Titel für jede Blattgruppe.",
      "为每个板材组创建一个带标题的 MText 对象。",
      "Crea un objeto MText con un título para cada grupo de hojas.",
      "Créer un objet MText avec un titre pour chaque groupe de feuilles.",
      "Her levha grubu için başlıklı bir MText nesnesi oluşturun."};

    public static readonly string[] GroupFrame = {
      "Group frame",
      "Рамка группы",
      "Cornice del gruppo",
      "Gruppenrahmen",
      "组边框",
      "Marco del grupo",
      "Cadre du groupe",
      "Grup çerçevesi"};

    public static readonly string[] GroupFrameTip = {
      "Draw a frame around the layout of sheets from one group.",
      "Рисовать рамку вокруг раскладки листов одной группы.",
      "Disegna una cornice attorno al layout dei fogli di un gruppo.",
      "Zeichnen Sie einen Rahmen um das Layout der Blätter einer Gruppe.",
      "在同一组的板材布局周围绘制边框。",
      "Dibujar un marco alrededor del diseño de las hojas de un grupo.",
      "Dessiner un cadre autour de la disposition des feuilles d'un groupe.",
      "Bir gruptaki levhaların düzeni etrafına çerçeve çizin."};

    public static readonly string[] Contouring = {
      "Contouring (NC Prepare)",
      "Контуры (ЧПУ Подготовка)",
      "Contorni (NC Prepare)",
      "Konturen (NC Prepare)",
      "轮廓（NC Prepare）",
      "Contornos (NC Prepare)",
      "Contours (NC Prepare)",
      "Konturlar (NC Prepare)"};

    public static readonly string[] ContouringTip = {
      "Run the contour retrieval procedure for all parts (NC Prepare) at the end of the layout.",
      "Запускать процедуру получения контуров всех деталей (NC Prepare) в конце раскладки.",
      "Esegui la procedura di recupero dei contorni per tutte le parti (NC Prepare) al termine del layout.",
      "Führen Sie am Ende des Layouts die Konturerfassung für alle Teile (NC Prepare) aus.",
      "在布局结束时对所有零件运行轮廓获取程序（NC Prepare）。",
      "Ejecutar el procedimiento de obtención de contornos para todas las piezas (NC Prepare) al final del diseño.",
      "Exécuter la procédure de récupération des contours pour toutes les pièces (NC Prepare) à la fin de la mise en page.",
      "Düzenin sonunda tüm parçalar için kontur alma prosedürünü (NC Prepare) çalıştırın."};

    public static readonly string[] DeleteSources = {
      "Delete source solids",
      "Удалять исходные солиды",
      "Elimina i solidi di origine",
      "Quellkörper löschen",
      "删除源实体",
      "Eliminar sólidos de origen",
      "Supprimer les solides source",
      "Kaynak katıları sil"};

    public static readonly string[] DeleteSourcesTip = {
      "Delete the original parts' bodies after nesting is complete.\r\n" +
        "This will only happen for model space solids, not blocks.",
      "Удалять исходные тела деталей после завершения раскладки. \r\n" +
        "Удаление произойдет только для солидов пространства модели, но не из блоков.",
      "Elimina i corpi delle parti originali dopo che il nesting è completo. \r\n" +
        "Questo avverrà solo per i solidi dello spazio modello, non per i blocchi.",
      "Löschen Sie die Originalkörper der Teile, nachdem das Nesting abgeschlossen ist. \r\n" +
        "Dies geschieht nur für Volumenkörper im Modellbereich, nicht für Blöcke.",
      "在嵌套完成后删除原始零件的实体。 \r\n" +
         "这只会发生在模型空间的实体上，而不会发生在块上。",
      "Eliminar los cuerpos de las piezas originales después de que se complete el nesting. \r\n" +
        "Esto solo ocurrirá para los sólidos del espacio modelo, no para los bloques.",
      "Supprimez les corps des pièces originales une fois le nesting terminé. \r\n" +
        "Cela ne se produira que pour les solides de l'espace modèle, pas pour les blocs.",
      "Nesting tamamlandıktan sonra orijinal parçaların gövdelerini silin. \r\n" +
        "Bu yalnızca model alanı katıları için geçerli olacak, bloklar için değil."};

    public static readonly string[] Method = {
      "Nesting method",
      "Метод нестинга",
      "Metodo di nesting",
      "Nesting-Methode",
      "嵌套方法",
      "Método de nesting",
      "Méthode de nesting",
      "Nesting yöntemi"};

    public static readonly string[] SkylineDesc = {
      "Skyline, large to small",
      "Skyline, от больших к малым",
      "Skyline, dal grande al piccolo",
      "Skyline, groß nach klein",
      "轮廓线，从大到小",
      "Skyline, de grande a pequeño",
      "Skyline, du grand au petit",
      "Skyline, büyükten küçüğe"};

    public static readonly string[] SkylineDescTip = {
      "Skyline layout of parts on the sheets, from large to small (by size). \r\n" +
        "Remaining free areas are filled by the following small parts",
      "Шельфовая раскладка деталей на листах, от больших к малым (по убыванию размеров). \r\n" +
        "Свободные зоны заполняются следующими мелкими деталями",
      "Layout skyline delle parti sui fogli, dal grande al piccolo (per dimensione). \r\n" +
        "Le aree libere rimanenti vengono riempite dalle parti piccole successive",
      "Skyline-Layout der Teile auf den Blättern, von groß nach klein (nach Größe). \r\n" +
        "Verbleibende freie Bereiche werden durch die folgenden kleinen Teile gefüllt",
      "板材上零件的轮廓线布局，从大到小（按尺寸）。剩余的空闲区域由随后的小零件填充",
      "Diseño skyline de las piezas en las hojas, de grande a pequeño (por tamaño). \r\n" +
        "Las áreas libres restantes se rellenan con las siguientes piezas pequeñas",
      "Disposition skyline des pièces sur les feuilles, du plus grand au plus petit (par taille). \r\n" +
        "Les zones libres restantes sont remplies par les petites pièces suivantes",
      "Levhalardaki parçaların büyükten küçüğe (boyuta göre) skyline düzeni. \r\n" +
        "Kalan boş alanlar sonraki küçük parçalarla doldurulur"};

    public static readonly string[] SkylineAsc = {
      "Skyline, small to large",
      "Skyline, от малых к большим",
      "Skyline, dal piccolo al grande",
      "Skyline, klein nach groß",
      "轮廓线，从小到大",
      "Skyline, de pequeño a grande",
      "Skyline, du petit au grand",
      "Skyline, küçükten büyüğe"};

    public static readonly string[] SkylineAscTip = {
      "Skyline layout of parts on the sheets, from small to large (by size)",
      "Шельфовая раскладка деталей на листах, от малых к большим (по возрастанию размеров)",
      "Layout skyline delle parti sui fogli, dal piccolo al grande (per dimensione)",
      "Skyline-Layout der Teile auf den Blättern, von klein nach groß (nach Größe)",
      "板材上零件的轮廓线布局，从小到大（按尺寸）",
      "Diseño skyline de las piezas en las hojas, de pequeño a grande (por tamaño)",
      "Disposition skyline des pièces sur les feuilles, du plus petit au plus grand (par taille)",
      "Levhalardaki parçaların küçükten büyüğe (boyuta göre) skyline düzeni"};

    public static readonly string[] FindWindows = {
      "Find Windows",
      "Искать окна",
      "Trova finestre",
      "Fenster finden",
      "寻找窗口",
      "Buscar ventanas",                                          // ES
      "Trouver des fenêtres",                                     // FR
      "Pencereleri bul"};                                         // TR

    public static readonly string[] FindingWindows = {
      "Search for windows",
      "Поиск окон",
      "Ricerca di finestre",
      "Suche nach Fenstern",
      "搜索窗口",
      "Buscar ventanas",                                          // ES
      "Recherche de fenêtres",                                    // FR
      "Pencereleri arama"};                                       // TR

    public static readonly string[] FindWindowsTip =  {
      "Search for through-holes and cutouts in parts to nest small parts. \r\n" +
        "This search can significantly slow down nesting, so it's recommended to disable this option if parts don't have any holes.",
      "Искать сквозные окна и вырезы в деталях для раскладки в них мелких деталей. \r\n" +
        "Процедура поиска может сильно замедлить нестинг, поэтому рекомендуется отключать эту опцию, если у деталей нет окон.",
      "Cerca fori passanti e ritagli nelle parti per nidificare piccole parti. \r\n" +
        "Questa ricerca può rallentare significativamente il nesting, quindi si consiglia di disabilitare questa opzione se le parti non hanno fori.",
      "Suchen Sie nach Durchgangslöchern und Ausschnitten in Teilen, um kleine Teile zu verschachteln. \r\n" +
        "Diese Suche kann das Nesting erheblich verlangsamen, daher wird empfohlen, diese Option zu deaktivieren, wenn Teile keine Löcher haben.",
      "在零件中搜索通孔和切口以嵌套小零件。 \r\n" +
        "此搜索可能会显著减慢嵌套速度，因此如果零件没有孔，建议禁用此选项。",
      "Buscar orificios pasantes y recortes en piezas para anidar piezas pequeñas. \r\n" +  // ES
        "Esta búsqueda puede ralentizar significativamente el anidamiento, por lo que se recomienda desactivar esta opción si las piezas no tienen orificios.",
      "Rechercher des trous traversants et des découpes dans les pièces pour imbriquer de petites pièces. \r\n" +  // FR
        "Cette recherche peut ralentir considérablement l'imbrication, il est donc recommandé de désactiver cette option si les pièces n'ont pas de trous.",
      "Küçük parçaları yerleştirmek için parçalardaki geçiş deliklerini ve kesmeleri arayın. \r\n" +  // TR
        "Bu arama, yerleştirmeyi önemli ölçüde yavaşlatabilir, bu nedenle parçaların delikleri yoksa bu seçeneği devre dışı bırakmanız önerilir." };

    public static readonly string[] BaseCorner = {
      "Start corner",
      "Начальный угол",
      "Angolo di partenza",
      "Startecke",
      "起始角",
      "Esquina de inicio",
      "Coin de départ",
      "Başlangıç köşesi"};

    public static readonly string[] BaseCornerTip = {
      "The sheet corner from which the layout of parts starts. \r\n" +
        "Free space will remain on the opposite corner of the sheet.",
      "Угол листа, с которого начинается раскладка деталей. \r\n" +
        "Свободное место останется на противоположном углу листа.",
      "L'angolo del foglio da cui inizia il layout delle parti. \r\n" +
        "Lo spazio libero rimarrà nell'angolo opposto del foglio.",
      "Die Blattecke, an der die Anordnung der Teile beginnt. \r\n" +
        "Der freie Platz bleibt in der gegenüberliegenden Ecke des Blattes.",
      "零件布局开始的板材角. \r\n" +
        "空闲空间将保留在板材的对角处。",
      "La esquina de la hoja desde la que comienza el diseño de las piezas. \r\n" +
        "El espacio libre permanecerá en la esquina opuesta de la hoja.",
      "Le coin de la feuille à partir duquel commence la disposition des pièces. \r\n" +
        "L'espace libre restera dans le coin opposé de la feuille.",
      "Parçaların düzeninin başladığı levha köşesi. \r\n" +
        "Boş alan levhanın karşı köşesinde kalacaktır."};

    public static readonly string[] LeftBottom = {
      "Left bottom",
      "Левый нижний",
      "In basso a sinistra",
      "Unten links",
      "左下",
      "Inferior izquierda",
      "Bas gauche",
      "Sol alt"};

    public static readonly string[] RightBottom = {
      "Right bottom",
      "Правый нижний",
      "In basso a destra",
      "Unten rechts",
      "右下",
      "Inferior derecha",
      "Bas droit",
      "Sağ alt"};

    public static readonly string[] LeftTop = {
      "Left top",
      "Левый верхний",
      "In alto a sinistra",
      "Oben links",
      "左上",
      "Superior izquierda",
      "Haut gauche",
      "Sol üst"};

    public static readonly string[] RightTop = {
      "Right top",
      "Правый верхний",
      "In alto a destra",
      "Oben rechts",
      "右上",
      "Superior derecha",
      "Haut droit",
      "Sağ üst"};

    public static readonly string[] NestingEfficiency = {
      "Nesting efficiency {0:0.0}%",
      "Эффективность раскладки {0:0.0}%",
      "Efficienza del nesting {0:0.0}%",
      "Nesting-Effizienz {0:0.0}%",
      "嵌套效率 {0:0.0}%",
      "Eficiencia de nesting {0:0.0}%",
      "Efficacité du nesting {0:0.0}%",
      "Nesting verimliliği {0:0.0}%" };

    public static readonly string[] PartTooBig = {
      "⚠️ Part {0} ({1}x{2}) is larger than the sheet working area {3}x{4} and cannot be nested.",
      "⚠️ Деталь {0} ({1}x{2}) больше рабочей зоны листа {3}x{4} и не может быть разложена.",
      "⚠️ La parte {0} ({1}x{2}) è più grande dell'area di lavoro del foglio {3}x{4} e non può essere annidata.",
      "⚠️ Das Teil {0} ({1}x{2}) ist größer als der Arbeitsbereich der Platte {3}x{4} und kann nicht geschachtelt werden.",
      "⚠️ 零件 {0} ({1}x{2}) 大于板材工作区域 {3}x{4}，无法排样。",
      "⚠️ La pieza {0} ({1}x{2}) es más grande que el área de trabajo de la hoja {3}x{4} y no se puede anidar.",
      "⚠️ La pièce {0} ({1}x{2}) est plus grande que la zone de travail de la feuille {3}x{4} et ne peut pas être imbriquée.",
      "⚠️ {0} parçası ({1}x{2}) sac çalışma alanından {3}x{4} daha büyük ve yerleştirilemiyor." };

    public static readonly string[] PartNotPlaced = {
      "⚠️ Failed to nest part {0} ({1}x{2}).",
      "⚠️ Не удалось разместить деталь {0} ({1}x{2}).",
      "⚠️ Impossibile annidare la parte {0} ({1}x{2}).",
      "⚠️ Das Teil {0} ({1}x{2}) konnte nicht geschachtelt werden.",
      "⚠️ 无法排样零件 {0} ({1}x{2})。",
      "⚠️ No se pudo anidar la pieza {0} ({1}x{2}).",
      "⚠️ Échec de l'imbrication de la pièce {0} ({1}x{2}).",
      "⚠️ {0} parçası ({1}x{2}) yerleştirilemedi." };

    public static readonly string[] PartsNotPlaced = {
      "⚠️ {0} part(s) could not be nested.",
      "⚠️ Не удалось разложить деталей: {0}.",
      "⚠️ {0} parte/i non è stato possibile annidare.",
      "⚠️ {0} Teil(e) konnten nicht geschachtelt werden.",
      "⚠️ 有 {0} 个零件无法排样。",
      "⚠️ No se pudieron anidar {0} pieza(s).",
      "⚠️ {0} pièce(s) n'ont pas pu être imbriquées.",
      "⚠️ {0} parça yerleştirilemedi." };

    public static readonly string[] DeletingSources = {
      "Deleting source solids...",
      "Удаление исходных солидов...",
      "Eliminazione dei solidi di origine...",
      "Löschen der Quellkörper...",
      "正在删除源实体...",
      "Eliminando sólidos de origen...",
      "Suppression des solides source...",
      "Kaynak katıları siliniyor..."    };

    public static readonly string[] DeletedSources = {
      "✔ Deleted source solids: {0}",
      "✔ Удалены исходные солиды: {0}",
      "✔ Solidi di origine eliminati: {0}",
      "✔ Quellkörper gelöscht: {0}",
      "✔ 已删除源实体: {0}",
      "✔ Sólidos de origen eliminados: {0}",
      "✔ Solides source supprimés: {0}",
      "✔ Kaynak katıları silindi: {0}" };


  }
}
