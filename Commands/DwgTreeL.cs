// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Dwg

namespace AVC
{
  public static class
  DwgTreeL
  {
    public static readonly string[][] DwgTreeStyleNames = {
/* 0 */ CommandL.DwgTree,
/* 1 */ CommandL.DwgTree,
    };

    public static readonly string[] LoadingTip = {
      "There is a background process of reading all objects in the drawing and getting metric of solids",
      "Идет фоновый процесс чтения всех объектов чертежа и получения метрик солидов",
      "Esiste un processo in background per leggere tutti gli oggetti nel disegno e ottenere metriche solide",
      "Es gibt einen Hintergrundprozess, bei dem alle Objekte in der Zeichnung gelesen und solide Metriken ermittelt werden",
      "有一个后台进程读取绘图中的所有对象并获取可靠的指标",
      "Hay un proceso en segundo plano de lectura de todos los objetos en el dibujo y obtención de métricas de sólidos",  // ES
      "Il y a un processus en arrière-plan de lecture de tous les objets du dessin et d'obtention des métriques des solides",  // FR
      "Çizimdeki tüm nesneleri okuma ve katıların metriklerini alma arka plan işlemi var" };  // TR

    public static readonly string[] TooLongList = {
      "Too many items...",
      "Слишком много элементов...",
      "Troppi articoli...",
      "Zu viele Dinge...",
      "过多的物品...",
      "Demasiados elementos...",                       // ES
      "Trop d'éléments...",                            // FR
      "Çok fazla öğe..."};                             // TR

    public static readonly string[] TooManyObjects = {
      "Too many objects selected ({0}). The Drawing Tree will not display the selected objects.",
      "Слишком много объектов выбрано ({0}). Дерево чертежа не будет показывать выбранные объекты.",
      "Troppi oggetti selezionati ({0}). L'albero del disegno non visualizzerà gli oggetti selezionati.",
      "Zu viele Objekte ausgewählt ({0}). Der Zeichnungsbaum wird die ausgewählten Objekte nicht anzeigen.",
      "选择的对象太多 ({0})。 绘图树将不显示所选对象。",
      "Demasiados objetos seleccionados ({0}). El árbol de dibujo no mostrará los objetos seleccionados.",  // ES
      "Trop d'objets sélectionnés ({0}). L'arbre de dessin n'affichera pas les objets sélectionnés.",  // FR
      "Çok fazla nesne seçildi ({0}). Çizim Ağacı seçili nesneleri göstermeyecek."};  // TR

    public static readonly string[] SelectionErr = {
      "Error! Objects cannot be selected",
      "Ошибка! Объекты не могут быть выбраны",
      "Errore! Gli oggetti non possono essere selezionati",
      "Fehler! Objekte können nicht ausgewählt werden",
      "错误！ 无法选择对象",
      "¡Error! Los objetos no se pueden seleccionar",  // ES
      "Erreur ! Les objets ne peuvent pas être sélectionnés",  // FR
      "Hata! Nesneler seçilemiyor"};                   // TR

    public static readonly string[] FindSelectedErrCount = {
      "Error! Objects not found in Drawing Tree - {0}",
      "Ошибка! В дереве чертежа не найдено объектов - {0}",
      "Errore! Oggetti non trovati nell'albero del disegno - {0}",
      "Fehler! Objekte wurden im Zeichnungsbaum nicht gefunden - {0}",
      "错误！ 在绘图树中找不到对象 - {0}",
      "¡Error! Objetos no encontrados en el árbol de dibujo - {0}",  // ES
      "Erreur ! Objets introuvables dans l'arbre de dessin - {0}",  // FR
      "Hata! Çizim Ağacında nesneler bulunamadı - {0}"};  // TR

    //==========================================================================================================================================================================
    public static readonly string[] StyleNameTip = {
      "The name for this Drawing Tree style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля дерева чертежа. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile dell'albero di disegno (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Zeichenbaumstil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此绘图树样式（设置集）的名称。 程序中没有使用。 只为方便选择。",
      "El nombre para este estilo de Árbol de dibujo (conjunto de configuraciones). No se usa en el programa. Solo por conveniencia de elección.",  // ES
      "Le nom de ce style d'Arbre de dessin (ensemble de paramètres). Non utilisé dans le programme. Uniquement pour la commodité du choix.",  // FR
      "Bu Çizim Ağacı stili için ad (ayar seti). Programda kullanılmaz. Sadece seçim kolaylığı için."};  // TR

    public static readonly string[] MaxListLength = {
      "Maximum length of lists",
      "Максимальная длина списков",
      "Lunghezza massima delle liste",
      "Maximale Länge von Listen",
      "列表的最大长度",
      "Longitud máxima de listas",                     // ES
      "Longueur maximale des listes",                  // FR
      "Listelerin maksimum uzunluğu" };                // TR

    public static readonly string[] MaxListLengthTip = {
      "Limit the length of lists in a tree. The more - the more noticeable the program will slow down your work.",
      "Ограничить длину списков в дереве. Чем больше - тем заметнее программа будет тормозить вашу работу.",
      "Limita la lunghezza degli elenchi in un albero. Più - più evidente il programma rallenterà il tuo lavoro.",
      "Begrenzen Sie die Länge von Listen in einem Baum. Je mehr, desto spürbarer verlangsamt das Programm Ihre Arbeit.",
      "限制树中列表的长度。 程序越多，就越明显地减慢您的工作速度。",
      "Limitar la longitud de las listas en un árbol. Cuanto más, más notablemente el programa ralentizará su trabajo.",  // ES
      "Limiter la longueur des listes dans un arbre. Plus il y en a, plus le programme ralentira sensiblement votre travail.",  // FR
      "Bir ağaçtaki listelerin uzunluğunu sınırlayın. Ne kadar fazla olursa, program çalışmanızı o kadar belirgin şekilde yavaşlatacaktır." };  // TR

    public static readonly string[] FoldersTip = {
      "Show folders containing drawings as a separate tree branch",
      "Показывать папки, в которых содержатся чертежи, как отдельную ветвь дерева",
      "Mostra le cartelle contenenti i disegni come ramo di un albero separato",
      "Zeigen Sie Ordner mit Zeichnungen als separaten Baumzweig an",
      "将包含绘图的文件夹显示为单独的树枝",
      "Mostrar carpetas que contienen dibujos como una rama de árbol separada",  // ES
      "Afficher les dossiers contenant des dessins comme une branche d'arbre séparée",  // FR
      "Çizimleri içeren klasörleri ayrı bir ağaç dalı olarak göster" };  // TR

    public static readonly string[] Files = {
      "Files",
      "Файлы",
      "File",
      "Dateien",
      "文件",
      "Archivos",                                      // ES
      "Fichiers",                                      // FR
      "Dosyalar" };                                    // TR

    public static readonly string[] FilesTip = {
      "Show all open drawings in the tree",
      "Показывать в дереве все открытые чертежи",
      "Mostra tutti i disegni aperti nell'albero",
      "Alle geöffneten Zeichnungen im Baum anzeigen",
      "显示树中所有打开的图纸",
      "Mostrar todos los dibujos abiertos en el árbol",  // ES
      "Afficher tous les dessins ouverts dans l'arbre",  // FR
      "Ağaçta açık tüm çizimleri göster" };            // TR

    public static readonly string[] AssembliesTip = {
      "Show a group with block references representing assemblies in the model and in other blocks. \r\n" +
        "All blocks that are allowed to explode, except annotative ones, are considered assemblies.",
      "Показывать группу с ссылками на блоки изображающие сборки в модели и в других блоках. \r\n" +
        "Сборками считаются все блоки, которые разрешено взрывать, кроме аннотативных.",
      "Mostra un gruppo con riferimenti a blocchi che rappresentano gli assemblaggi nel modello e in altri blocchi. \r\n" +
        "Tutti i blocchi che possono esplodere, ad eccezione di quelli annotativi, sono considerati assemblaggi.",
      "Zeigen Sie eine Gruppe mit Blockverweisen an, die Baugruppen im Modell und in anderen Blöcken darstellen. \r\n" +
        "Alle Blöcke, die explodieren dürfen, mit Ausnahme der Beschriftungsblöcke, gelten als Baugruppen.",
      "显示具有表示模型和其他块中的装配体的块引用的组。\r\n" +
        "除注释性块外，所有允许爆炸的块都被视为组件。",
      "Mostrar un grupo con referencias de bloques que representan ensamblajes en el modelo y en otros bloques. \r\n" +  // ES
        "Todos los bloques que se pueden explotar, excepto los anotativos, se consideran ensamblajes.",
      "Afficher un groupe avec des références de blocs représentant des assemblages dans le modèle et dans d'autres blocs. \r\n" +  // FR
        "Tous les blocs qui peuvent être explosés, sauf les annotatifs, sont considérés comme des assemblages.",
      "Modelde ve diğer bloklarda montajları temsil eden blok referanslarını içeren bir grup göster. \r\n" +  // TR
        "Açıklamalı olanlar dışında patlatılmasına izin verilen tüm bloklar montaj olarak kabul edilir." };

    public static readonly string[] ProductsTip = {
      "Show group with non-explosive block references (purchasable items, products)",
      "Показывать группу с невзрываемыми ссылками на блоки (покупными изделиями)",
      "Mostra gruppo con blocchi non esplosivi (oggetti acquistabili)",
      "Gruppe mit nicht-explosiven Blöcken anzeigen (käufliche Artikel)",
      "显示非爆炸块组（可购买物品）",
      "Mostrar grupo con referencias de bloques no explosivos (artículos comprables, productos)",  // ES
      "Afficher le groupe avec des références de blocs non explosifs (articles achetables, produits)",  // FR
      "Patlayıcı olmayan blok referanslarını içeren grubu göster (satın alınabilir öğeler, ürünler)" };  // TR

    public static readonly string[] ArraysTip = {
      "Show group with dynamic arrays",
      "Показывать группу с динамическими массивами",
      "Mostra gruppo con array dinamici",
      "Gruppe mit dynamischen Arrays anzeigen",
      "显示具有动态数组的组",
      "Mostrar grupo con matrices dinámicas",          // ES
      "Afficher le groupe avec des tableaux dynamiques",  // FR
      "Dinamik dizileri olan grubu göster" };          // TR

    public static readonly string[] DetailsTip = {
      "Show group for 3d-solids (details, parts). \r\n" +
        "Otherwise solids will be in the 3D group.",
      "Показывать группу для солидов (деталей). \r\n" +
        "Иначе солиды будут в группе 3D.",
      "Mostra gruppo per solidi 3d (dettagli, parti). \r\n" +
        "Altrimenti i solidi saranno nel gruppo 3D.",
      "Gruppe für 3D-Solids (Details, Teile) anzeigen. \r\n" +
        "Andernfalls befinden sich Volumenkörper in der 3D-Gruppe.",
      "显示 3d 实体组（细节、零件）。否则实体将属于 3D 组。",
      "Mostrar grupo para sólidos 3d (detalles, piezas). \r\n" +  // ES
        "De lo contrario, los sólidos estarán en el grupo 3D.",
      "Afficher le groupe pour les solides 3d (détails, pièces). \r\n" +  // FR
        "Sinon, les solides seront dans le groupe 3D.",
      "3d katılar için grubu göster (detaylar, parçalar). \r\n" +  // TR
        "Aksi takdirde katılar 3D grubunda olacaktır." };

    public static readonly string[] CurvesTip = {
      "Show group with lines and curves (2D and 3D)",
      "Показывать группу с линиями и кривыми (2D и 3D)",
      "Mostra gruppo con linee e curve (2D e 3D)",
      "Gruppe mit Linien und Kurven anzeigen (2D und 3D)",
      "显示直线和曲线组（2D 和 3D）",
      "Mostrar grupo con líneas y curvas (2D y 3D)",   // ES
      "Afficher le groupe avec des lignes et des courbes (2D et 3D)",  // FR
      "Çizgiler ve eğrilerle grubu göster (2D ve 3D)" };  // TR

    public static readonly string[] _3DTip = {
      "Show group with other 3D objects (except 3d-solids): meshes, surfaces, 3D curves",
      "Показывать группу с прочими трехмерными объектами (кроме солидов): \r\n" +
        "сетями, поверхностями, 3D-кривыми",
      "Mostra gruppo con altri oggetti 3D (tranne i solidi 3D): mesh, superfici, curve 3D",
      "Gruppe mit anderen 3D-Objekten anzeigen (außer 3D-Solids): Netze, Flächen, 3D-Kurven",
      "显示与其他 3D 对象（3D 实体除外）的组：网格、曲面、3D 曲线",
      "Mostrar grupo con otros objetos 3D (excepto sólidos 3d): mallas, superficies, curvas 3D",  // ES
      "Afficher le groupe avec d'autres objets 3D (sauf les solides 3d) : maillages, surfaces, courbes 3D",  // FR
      "Diğer 3D nesnelerle grubu göster (3d katılar hariç): ağlar, yüzeyler, 3D eğriler" };  // TR

    public static readonly string[] AnnotationsTip = {
      "Show group with drawing annotations: \r\n" +
        "texts, dimensions, leaders, hatching, tables, annotative blocks",
      "Показывать группу с аннотациями чертежа: \r\n" +
        "тексты, размеры, выноски, штриховки, таблицы, аннотативные блоки",
      "Mostra gruppo con annotazioni disegno: \r\n" +
        "testi, quote, didascalie, tratteggi, tabelle, blocchi annotativi",
      "Gruppe mit Zeichnungsanmerkungen anzeigen: \r\n" +
        "Texte, Bemaßungen, Beschriftungen, Schraffuren, Tabellen, Anmerkungsblöcke",
      "显示带有绘图注释的组：\r\n" +
        "文本、尺寸、标注、剖面线、表格、注释块",
      "Mostrar grupo con anotaciones de dibujo: \r\n" +  // ES
        "textos, dimensiones, directrices, sombreados, tablas, bloques anotativos",
      "Afficher le groupe avec des annotations de dessin : \r\n" +  // FR
        "textes, dimensions, lignes de repère, hachures, tableaux, blocs annotatifs",
      "Çizim açıklamalarıyla grubu göster: \r\n" +  // TR
        "metinler, boyutlar, işaret çizgileri, taramalar, tablolar, açıklamalı bloklar" };

    public static readonly string[] OthersTip = {
      "Show a group with objects that do not belong to any other group: \r\n" +
        "viewports, OLE, images, proxy objects",
      "Показывать группу с объектами, не относящимися ни к одной другой группе: \r\n" +
        "вьюпорты, OLE, картинки, прокси-объекты",
      "Mostra un gruppo con oggetti che non appartengono a nessun altro gruppo: \r\n" +
        "viewport, OLE, immagini, oggetti proxy",
      "Zeigen Sie eine Gruppe mit Objekten an, die zu keiner anderen Gruppe gehören: \r\n" +
        "Ansichtsfenster, OLE, Bilder, Proxy-Objekte",
      "显示包含不属于任何其他组的对象的组：\r\n" +
        "视口、OLE、图像、代理对象",
      "Mostrar un grupo con objetos que no pertenecen a ningún otro grupo: \r\n" +  // ES
        "ventanas gráficas, OLE, imágenes, objetos proxy",
      "Afficher un groupe avec des objets qui n'appartiennent à aucun autre groupe : \r\n" +  // FR
        "fenêtres, OLE, images, objets proxy",
      "Başka hiçbir gruba ait olmayan nesnelerle bir grup göster: \r\n" +  // TR
        "görünümler, OLE, resimler, proxy nesneler" };

    public static readonly string[] Namesake = {
      "Namesake",
      "Одноимённые",
      "Omonimo",
      "Namensvetter",
      "同名",
      "Homónimos",                                     // ES
      "Homonymes",                                     // FR
      "Adaş" };                                        // TR

    public static readonly string[] NamesakeTip = {
      "Create subgroups for objects with the same name. \r\n" +
        "The subgroup will get the same name as the objects in it, only in brackets <>. \r\n" +
        "The program does not check for geometric differences, but only looks at the name of the object.\r\n" +
        "A subgroup is not created if it is the only one in the parent group, \r\n" +
        "that is, if all objects in the list have the same name. \r\n" +
        "A subgroup is not created if it contains only one object.",
      "Создавать подгруппы для объектов с одинаковыми именами. \r\n" +
        "Подгруппа получит такое же имя как у объектов в ней, но в скобках <>. \r\n" +
        "Программа не проверяет геометрические различия, а смотрит только на имя объекта.\r\n" +
        "Подгруппа не создается если она одна в вышестоящей группе, то есть если все объекты списка одноименные. \r\n" +
        "Подгруппа не создается если в нее входит только один объект.",
      "Creare sottogruppi per oggetti con lo stesso nome. \r\n" +
        "Il sottogruppo avrà lo stesso nome degli oggetti in esso contenuti, solo tra parentesi <>. \r\n" +
        "Il programma non controlla le differenze geometriche, ma guarda solo il nome dell'oggetto.\r\n" +
        "Un sottogruppo non viene creato se è l'unico nel gruppo principale, \r\n" +
        "cioè se tutti gli oggetti nell'elenco hanno lo stesso nome. \r\n" +
        "Un sottogruppo non viene creato se contiene un solo oggetto.",
      "Erstellen Sie Untergruppen für Objekte mit demselben Namen. \r\n" +
        "Die Untergruppe erhält denselben Namen wie die darin enthaltenen Objekte, nur in Klammern <>. \r\n" +
        "Das Programm prüft nicht auf geometrische Unterschiede, sondern schaut nur auf den Namen des Objekts.\r\n" +
        "Eine Untergruppe wird nicht erstellt, wenn sie die einzige in der übergeordneten Gruppe ist, \r\n" +
        "d. h. wenn alle Objekte in der Liste denselben Namen haben. \r\n" +
        "Eine Untergruppe wird nicht erstellt, wenn sie nur ein Objekt enthält.",
      "为具有相同名称的对象创建子组。 \r\n" +
        "子组将获得与其中的对象相同的名称，只是在方括号 <> 中。\r\n" +
        " 该程序不检查几何差异，而仅查看对象的名称。\r\n" +
        "如果子组是父组中唯一的子组，即列表中的所有对象都具有相同的名称，则不会创建子组。 \r\n" +
        "如果子组仅包含一个对象，则不会创建子组。",
      "Crear subgrupos para objetos con el mismo nombre. \r\n" +  // ES
        "El subgrupo obtendrá el mismo nombre que los objetos en él, solo entre corchetes <>. \r\n" +
        "El programa no verifica diferencias geométricas, sino que solo mira el nombre del objeto.\r\n" +
        "No se crea un subgrupo si es el único en el grupo principal, \r\n" +
        "es decir, si todos los objetos de la lista tienen el mismo nombre. \r\n" +
        "No se crea un subgrupo si contiene solo un objeto.",
      "Créer des sous-groupes pour les objets portant le même nom. \r\n" +  // FR
        "Le sous-groupe portera le même nom que les objets qu'il contient, uniquement entre crochets <>. \r\n" +
        "Le programme ne vérifie pas les différences géométriques, mais ne regarde que le nom de l'objet.\r\n" +
        "Un sous-groupe n'est pas créé s'il est le seul dans le groupe parent, \r\n" +
        "c'est-à-dire si tous les objets de la liste ont le même nom. \r\n" +
        "Un sous-groupe n'est pas créé s'il ne contient qu'un seul objet.",
      "Aynı ada sahip nesneler için alt gruplar oluşturun. \r\n" +  // TR
        "Alt grup, içindeki nesnelerle aynı adı alacaktır, sadece <> parantezleri içinde. \r\n" +
        "Program geometrik farklılıkları kontrol etmez, sadece nesnenin adına bakar.\r\n" +
        "Üst grupta tek başına ise, yani listedeki tüm nesneler aynı ada sahipse alt grup oluşturulmaz. \r\n" +
        "Yalnızca bir nesne içeriyorsa alt grup oluşturulmaz." };

    public static readonly string[] LayersTip = {
      "Show a group with a list of layers in the drawing and in all blocks. \r\n" +
        "Even unused layers will be shown in the drawing",
      "Показывать группу со списком слоев в чертеже и во всех блоках. \r\n" +
        "В чертеже будут показаны даже неиспользованные слои",
      "Mostra un gruppo con un elenco di layer nel disegno e in tutti i blocchi. \r\n" +
        "Anche i livelli inutilizzati verranno visualizzati nel disegno",
      "Zeigen Sie eine Gruppe mit einer Liste der Layer in der Zeichnung und in allen Blöcken an. \r\n" +
        "Auch nicht verwendete Ebenen werden in der Zeichnung angezeigt",
      "显示图形和所有块中包含图层列表的组。 \r\n" +
        "即使未使用的图层也会显示在绘图中",
      "Mostrar un grupo con una lista de capas en el dibujo y en todos los bloques. \r\n" +  // ES
        "Incluso las capas no utilizadas se mostrarán en el dibujo",
      "Afficher un groupe avec une liste de calques dans le dessin et dans tous les blocs. \r\n" +  // FR
        "Même les calques non utilisés seront affichés dans le dessin",
      "Çizimde ve tüm bloklarda katman listesi içeren bir grup göster. \r\n" +  // TR
        "Kullanılmayan katmanlar bile çizimde gösterilecektir" };

    public static readonly string[] GroupsTip = {
      "Show named and unnamed groups in drawing branches.",
      "Показывать именованные и безымянные группы в ветви чертежа",
      "Mostra gruppi con nome e senza nome in un ramo del disegno.",
      "Zeigen Sie benannte und unbenannte Gruppen in einem Zeichnungszweig an.",
      "在绘图分支中显示已命名和未命名的组。",
      "Mostrar grupos con nombre y sin nombre en ramas de dibujo.",  // ES
      "Afficher les groupes nommés et non nommés dans les branches de dessin.",  // FR
      "Çizim dallarında adlandırılmış ve adlandırılmamış grupları göster." };  // TR

    public static readonly string[] MaterialsTip = {
      "Show a group with a list of materials in the drawing and in all blocks. \r\n" +
        "Even unused materials will be shown in the drawing",
      "Показывать группу со списком материалов в чертеже и во всех блоках. \r\n" +
        "В чертеже будут показаны даже неиспользованные материалы",
      "Mostra un gruppo con un elenco di materiali nel disegno e in tutti i blocchi. \r\n" +
        "Anche i materiali non utilizzati verranno mostrati nel disegno",
      "Zeigen Sie eine Gruppe mit einer Liste von Materialien in der Zeichnung und in allen Blöcken an. \r\n" +
        "Auch unbenutzte Materialien werden in der Zeichnung angezeigt",
      "显示图形和所有块中包含材料列表的组。 \r\n" +
        "即使未使用的材料也会显示在图纸中",
      "Mostrar un grupo con una lista de materiales en el dibujo y en todos los bloques. \r\n" +  // ES
        "Incluso los materiales no utilizados se mostrarán en el dibujo",
      "Afficher un groupe avec une liste de matériaux dans le dessin et dans tous les blocs. \r\n" +  // FR
        "Même les matériaux non utilisés seront affichés dans le dessin",
      "Çizimde ve tüm bloklarda malzeme listesi içeren bir grup göster. \r\n" +  // TR
        "Kullanılmayan malzemeler bile çizimde gösterilecektir" };

    public static readonly string[] MaterialGroups = {
      "Material groups",
      "Группы материалов",
      "Gruppi materiali",
      "Materialgruppen",
      "材料组",
      "Grupos de materiales",                          // ES
      "Groupes de matériaux",                          // FR
      "Malzeme grupları" };                            // TR

    public static readonly string[] MaterialGroupsTip = {
      "Divide the list of materials into groups according to their purpose: \r\n" +
        "sheets, coatings, edge bandings...",
      "Дробить список материалов на группы по их назначению: \r\n" +
        "листовые, покрытия, кромки...",
      "Dividi l'elenco dei materiali in gruppi in base alla loro destinazione: \r\n" +
        "lamiere, rivestimenti, bordature...",
      "Teilen Sie die Materialliste entsprechend ihrem Verwendungszweck in Gruppen ein: \r\n" +
        "Bleche, Beschichtungen, Kantenumleimer ...",
      "根据材料的用途将材料列表分为几组：板材、涂层、封边...",
      "Dividir la lista de materiales en grupos según su propósito: \r\n" +  // ES
        "hojas, recubrimientos, cantos...",
      "Diviser la liste des matériaux en groupes selon leur objectif : \r\n" +  // FR
        "feuilles, revêtements, chants...",
      "Malzeme listesini amaçlarına göre gruplara ayırın: \r\n" +  // TR
        "levhalar, kaplamalar, kenar bantları..." };

    public static readonly string[] BlockDefinitionsTip = {
      "Show a list of block definitions in the drawing, \r\n" +
        "even those not referenced in the model.",
      "Показать в чертеже список определений блоков, \r\n" +
        "даже тех, на которые нет ссылок в модели.",
      "Mostra un elenco di definizioni di blocco nel disegno, \r\n" +
        "anche quelle a cui non viene fatto riferimento nel modello.",
      "Zeigen Sie eine Liste der Blockdefinitionen in der Zeichnung an, \r\n" +
        "auch solche, auf die im Modell nicht verwiesen wird.",
      "显示图形中的块定义列表，\r\n" +
        "甚至是模型中未引用的块定义。",
      "Mostrar una lista de definiciones de bloques en el dibujo, \r\n" +  // ES
        "incluso aquellas a las que no se hace referencia en el modelo.",
      "Afficher une liste de définitions de blocs dans le dessin, \r\n" +  // FR
        "même celles non référencées dans le modèle.",
      "Çizimde blok tanımlarının listesini göster, \r\n" +  // TR
        "modelde referans gösterilmeyenler bile." };

    public static readonly string[] HiddenBlocks = {
      "Hidden blocks",
      "Скрытые блоки",
      "Blocchi nascosti",
      "Versteckte Blöcke",
      "隐藏块",
      "Bloques ocultos",                               // ES
      "Blocs cachés",                                  // FR
      "Gizli bloklar" };                               // TR

    public static readonly string[] HiddenBlocksTip = {
      "Show invisible unnamed blocks like spaces, arrays, dynamic block instances",
      "Показывать невидимые безымянные блоки, такие как пространства, массивы, экземпляры динамических блоков",
      "Mostra blocchi senza nome invisibili come spazi, array, istanze di blocchi dinamici",
      "Zeigen Sie unsichtbare unbenannte Blöcke wie Leerzeichen, Arrays und dynamische Blockinstanzen an",
      "显示不可见的未命名块，例如空间、数组、动态块实例",
      "Mostrar bloques sin nombre invisibles como espacios, matrices, instancias de bloques dinámicos",  // ES
      "Afficher les blocs non nommés invisibles comme les espaces, les tableaux, les instances de blocs dynamiques",  // FR
      "Boşluklar, diziler, dinamik blok örnekleri gibi görünmez adsız blokları göster" };  // TR

    public static readonly string[] ReferencesTip = {
      "Show a list of block reference in a block definition",
      "Показывать у определения блока список ссылок на него",
      "Mostra un elenco di riferimenti di blocco in una definizione di blocco",
      "Zeigt eine Liste der Blockreferenzen in einer Blockdefinition an",
      "显示块定义中的块引用列表",
      "Mostrar una lista de referencias de bloque en una definición de bloque",  // ES
      "Afficher une liste de références de bloc dans une définition de bloc",  // FR
      "Bir blok tanımında blok referanslarının listesini göster" };  // TR

    public static readonly string[] InstancesTip = {
      "Show a list of instances of dynamic blocks. \r\n" +
        "An instance is an invisible block with specific parameter values. \r\n" +
        "Dynamic blocks are never inserted directly into a drawing, \r\n" +
        "references to block instances are always inserted.",
      "Показывать у динамических блоков список их экземпляров. \r\n" +
        "Экземпляр - это невидимый блок с конкретными значениями параметров. \r\n" +
        "Динамические блоки никогда не вставляются в чертеж непосредственно, \r\n" +
        "всегда вставляются ссылки на экземпляры блока.",
      "Mostra un elenco di istanze di blocchi dinamici. \r\n" +
        "Un'istanza è un blocco invisibile con valori di parametro specifici. \r\n" +
        "I blocchi dinamici non vengono mai inseriti direttamente in un disegno, \r\n" +
        "i riferimenti alle istanze di blocco vengono sempre inseriti.",
      "Zeigt eine Liste von Instanzen dynamischer Blöcke an. \r\n" +
        "Eine Instanz ist ein unsichtbarer Block mit bestimmten Parameterwerten. \r\n" +
        "Dynamische Blöcke werden nie direkt in eine Zeichnung eingefügt, \r\n" +
        "Verweise auf Blockinstanzen werden immer eingefügt.",
      "显示动态块实例的列表。 \r\n" +
        "实例是具有特定参数值的不可见块。 \r\n" +
        "动态块永远不会直接插入到图形中，而是始终插入对块实例的引用。",
      "Mostrar una lista de instancias de bloques dinámicos. \r\n" +  // ES
        "Una instancia es un bloque invisible con valores de parámetros específicos. \r\n" +
        "Los bloques dinámicos nunca se insertan directamente en un dibujo, \r\n" +
        "siempre se insertan referencias a instancias de bloque.",
      "Afficher une liste d'instances de blocs dynamiques. \r\n" +  // FR
        "Une instance est un bloc invisible avec des valeurs de paramètres spécifiques. \r\n" +
        "Les blocs dynamiques ne sont jamais insérés directement dans un dessin, \r\n" +
        "les références aux instances de bloc sont toujours insérées.",
      "Dinamik blok örneklerinin listesini göster. \r\n" +  // TR
        "Bir örnek, belirli parametre değerlerine sahip görünmez bir bloktur. \r\n" +
        "Dinamik bloklar asla doğrudan bir çizime eklenmez, \r\n" +
        "blok örneklerine referanslar her zaman eklenir." };

    public static readonly string[] LayoutsTip = {
      "Show a group with all sheets (layouts) of the drawing",
      "Показать группу со всеми листами (лейаутами) чертежа",
      "Mostra un gruppo con tutti i fogli (layout) del disegno",
      "Zeigen Sie eine Gruppe mit allen Blättern (Layouts) der Zeichnung an",
      "显示包含绘图的所有图纸（布局）的组",
      "Mostrar un grupo con todas las hojas (presentaciones) del dibujo",  // ES
      "Afficher un groupe avec toutes les feuilles (présentations) du dessin",  // FR
      "Çizimin tüm sayfalarını (düzenler) içeren bir grup göster" };  // TR

    public static readonly string[] Highlight = {
      "Highlight objects",
      "Подсвечивать объекты",
      "Evidenzia gli oggetti",
      "Heben Sie Objekte hervor",
      "突出显示对象",
      "Resaltar objetos",                              // ES
      "Mettre en surbrillance les objets",             // FR
      "Nesneleri vurgula" };                           // TR

    public static readonly string[] HighlightTip = {
      "Enable highlighting of a drawing object when the mouse pointer is over its name in the drawing tree. \r\n" +
        "Highlighting will only work for objects inserted into model space",
      "Включать подсветку объекта чертежа, когда указатель мыши наводится на его имя в дереве чертежа. \r\n" +
        "Подсветка сработает только у объектов вставленных в пространство модели",
      "Abilita l'evidenziazione di un oggetto di disegno quando il puntatore del mouse \r\n" +
        "si trova sopra il suo nome nell'albero del disegno. \r\n" +
        "L'evidenziazione funzionerà solo sugli oggetti inseriti nello spazio modello",
      "Aktivieren Sie die Hervorhebung eines Zeichenobjekts, \r\n" +
        "wenn sich der Mauszeiger über seinem Namen im Zeichenbaum befindet. \r\n" +
        "Die Hervorhebung funktioniert nur bei Objekten, die in den Modellbereich eingefügt werden",
      "当鼠标指针位于绘图树中的绘图对象名称上方时，启用绘图对象的突出显示。 \r\n" +
        "突出显示仅适用于插入模型空间的对象",
      "Habilitar el resaltado de un objeto de dibujo cuando el puntero del mouse está sobre su nombre en el árbol de dibujo. \r\n" +  // ES
        "El resaltado solo funcionará para objetos insertados en el espacio modelo",
      "Activer la mise en surbrillance d'un objet de dessin lorsque le pointeur de la souris est sur son nom dans l'arbre de dessin. \r\n" +  // FR
        "La mise en surbrillance ne fonctionnera que pour les objets insérés dans l'espace modèle",
      "Fare işaretçisi çizim ağacındaki adının üzerindeyken bir çizim nesnesinin vurgulanmasını etkinleştirin. \r\n" +  // TR
        "Vurgulama yalnızca model alanına eklenen nesneler için çalışacaktır" };

    public static readonly string[] ZoomTip = {
      "By clicking on the name of an object in the tree, \r\n" +
        "the program will try to find this object in the drawing and zoom the screen to the dimensions of the object",
      "По клику на имени объекта в дереве, \r\n" +
        "программа попытается найти этот объект в чертеже и зуммировать экран под размеры объекта",
      "Cliccando sul nome di un oggetto nell'albero, \r\n" +
        "il programma cercherà di trovare questo oggetto nel disegno e ingrandirà lo schermo alla dimensione dell'oggetto",
      "Durch Klicken auf den Namen eines Objekts im Baum versucht das Programm, \r\n" +
        "dieses Objekt in der Zeichnung zu finden und den Bildschirm auf die Größe des Objekts zu vergrößern",
      "通过单击树中某个对象的名称，\r\n" +
        "程序将尝试在图形中找到该对象并将屏幕缩放到该对象的大小",
      "Al hacer clic en el nombre de un objeto en el árbol, \r\n" +  // ES
        "el programa intentará encontrar este objeto en el dibujo y hacer zoom en la pantalla a las dimensiones del objeto",
      "En cliquant sur le nom d'un objet dans l'arbre, \r\n" +  // FR
        "le programme essaiera de trouver cet objet dans le dessin et de zoomer l'écran aux dimensions de l'objet",
      "Ağaçta bir nesnenin adına tıklayarak, \r\n" +  // TR
        "program bu nesneyi çizimde bulmaya çalışacak ve ekranı nesnenin boyutlarına yakınlaştıracak" };

    public static readonly string[] Color = {
      "Coloring in names",
      "Раскрашивать имена",
      "Colorare nei nomi",
      "Namen einfärben",
      "名字上色",
      "Colorear nombres",                              // ES
      "Colorer les noms",                              // FR
      "Adları renklendirme" };                         // TR

    public static readonly string[] ColorTip = {
      "Change the color of the names of objects in the tree according to the color of the object. \r\n" +
        "For solids, the color of the material is used (if the material is not Global). \r\n" +
        "Colors close to the background are not applied, but still coloring can impair the readability of names",
      "Менять цвет имен объектов в дереве по цвету объекта. \r\n" +
        "Для солидов используется цвет материала (если материал не Global). \r\n" +
        "Цвета близкие к фону не применяются, но все равно раскраска может ухудшить читаемость имен",
      "Cambia il colore dei nomi degli oggetti nell'albero in base al colore dell'oggetto. \r\n" +
        "Per i solidi, viene utilizzato il colore del materiale (se il materiale non è Global). \r\n" +
        "I colori vicini allo sfondo non vengono applicati, ma la colorazione può comunque compromettere \r\n" +
        "la leggibilità dei nomi",
      "Ändern Sie die Farbe der Namen von Objekten in der Baumstruktur entsprechend der Farbe des Objekts. \r\n" +
        "Für Volumenkörper wird die Farbe des Materials verwendet (wenn das Material nicht global ist). \r\n" +
        "Farben nahe am Hintergrund werden nicht angewendet, dennoch kann die Farbgebung die Lesbarkeit \r\n" +
        "von Namen beeinträchtigen",
      "根据对象的颜色更改树中对象名称的颜色。 对于实体，使用材质的颜色（如果材质不是全局的）。 \r\n" +
        "不应用接近背景的颜色，但着色仍然会损害名称的可读性",
      "Cambiar el color de los nombres de los objetos en el árbol según el color del objeto. \r\n" +  // ES
        "Para sólidos, se usa el color del material (si el material no es Global). \r\n" +
        "Los colores cercanos al fondo no se aplican, pero aún así el coloreado puede afectar la legibilidad de los nombres",
      "Changer la couleur des noms d'objets dans l'arbre selon la couleur de l'objet. \r\n" +  // FR
        "Pour les solides, la couleur du matériau est utilisée (si le matériau n'est pas Global). \r\n" +
        "Les couleurs proches de l'arrière-plan ne sont pas appliquées, mais la coloration peut quand même nuire à la lisibilité des noms",
      "Ağaçtaki nesne adlarının rengini nesnenin rengine göre değiştirin. \r\n" +  // TR
        "Katılar için malzemenin rengi kullanılır (malzeme Global değilse). \r\n" +
        "Arka plana yakın renkler uygulanmaz, ancak renklendirme yine de adların okunabilirliğini bozabilir" };

    public static readonly string[] Handle = {
      "Show object number (Handle)",
      "Показывать номер объекта (Хэндл)",
      "Mostra numero oggetto (Handle)",
      "Objektnummer anzeigen (Handle)",
      "显示对象编号（Handle",
      "Mostrar número de objeto (Handle)",             // ES
      "Afficher le numéro d'objet (Handle)",           // FR
      "Nesne numarasını göster (Handle)" };            // TR

    public static readonly string[] HandleTip = {
      "After the name of the drawing object, write its public identification number (handle). " +
        "You will see the same number in the title of the Properties palette tab.",
      "После имени объекта чертежа написать его внутренний идентификационный номер (handle). " +
        "Этот же номер вы увидите в заголовке вкладки палитры свойств.",
      "Dopo il nome dell'oggetto di disegno, scrivi il suo numero identificativo interno (handle). " +
        "Vedrai lo stesso numero nel titolo della scheda della tavolozza Proprietà.",
      "Schreiben Sie nach dem Namen des Zeichenobjekts dessen interne Identifikationsnummer (Handle). " +
        "Die gleiche Nummer wird im Titel der Registerkarte 'Eigenschaften' der Palette angezeigt.",
      "在绘图对象的名称后面写上其内部标识号（句柄）。 " +
        "您将在'属性'选项板选项卡的标题中看到相同的数字。",
      "Después del nombre del objeto de dibujo, escriba su número de identificación público (handle). " +  // ES
        "Verá el mismo número en el título de la pestaña de la paleta Propiedades.",
      "Après le nom de l'objet de dessin, écrivez son numéro d'identification public (handle). " +  // FR
        "Vous verrez le même numéro dans le titre de l'onglet de la palette Propriétés.",
      "Çizim nesnesinin adından sonra, genel tanımlama numarasını (handle) yazın. " +  // TR
        "Aynı numarayı Özellikler paleti sekmesinin başlığında göreceksiniz." };

    public static readonly string[] HolesTo3d = {
      "Solid holes in 3D",
      "Солиды-отверстия в 3D",
      "Fori solidi in 3D",
      "Solide Löcher in 3D",
      "3D 实心孔",
      "Agujeros sólidos en 3D",                        // ES
      "Trous solides en 3D",                           // FR
      "3D'de katı delikler" };                         // TR

    public static readonly string[] HolesTo3dTip = {
      "Show Holes layer solids in 3D group instead of Details group",
      "Показывать солиды слоя Отверстия в группе 3D, а не в группе Детали",
      "Mostra Solidi del layer Fori nel gruppo 3D invece che nel gruppo Parti",
      "Zeigen Sie Volumenkörper der Ebene 'Löcher' in der 3D-Gruppe anstelle der Teilegruppe an",
      "在 3D 组而不是零件组中显示孔层实体",
      "Mostrar sólidos de capa Agujeros en grupo 3D en lugar de grupo Detalles",  // ES
      "Afficher les solides du calque Trous dans le groupe 3D au lieu du groupe Détails",  // FR
      "Delikler katmanı katılarını Detaylar grubu yerine 3D grubunda göster" };  // TR

    public static readonly string[] UpdateMetrics = {
      "Update all solid metrics",
      "Обновлять все метрики солидов",
      "Aggiorna tutte le metriche solide",
      "Aktualisieren Sie alle soliden Kennzahlen",
      "更新所有可靠指标",
      "Actualizar todas las métricas de sólidos",      // ES
      "Mettre à jour toutes les métriques solides",    // FR
      "Tüm katı metriklerini güncelle" };              // TR

    public static readonly string[] UpdateMetricsTip = {
      "Immediately after opening the drawing, \r\n" +
        "start updating all the metrics for all solids that previously had a metric in the background. \r\n" +
        "This ensures that no solids with erroneous, obsolete dimensions remain in the drawing. \r\n" +
        "However, the measurement process can cause slowdowns and even fatal crashes.",
      "Сразу после открытия чертежа начать в фоновом режиме обновлять все метрики у всех солидов, \r\n" +
        "которые ранее имели метрику. \r\n" +
        "Это гарантирует, что в чертеже не останется солидов с ошибочными, устаревшими размерами. \r\n" +
        "Однако процесс обмера может вызывать тормоза и даже фатальные сбои.",
      "Subito dopo aver aperto il disegno, \r\n" +
        "iniziare ad aggiornare tutte le metriche per tutti i solidi che in precedenza avevano una metrica in background. \r\n" +
        "Ciò garantisce che nel disegno non rimangano solidi con dimensioni errate e obsolete. \r\n" +
        "Tuttavia, il processo di misurazione può causare rallentamenti e persino incidenti mortali.",
      "Beginnen Sie unmittelbar nach dem Öffnen der Zeichnung mit der Aktualisierung aller Metriken für alle Volumenkörper, \r\n" +
        "die zuvor eine Metrik im Hintergrund hatten. \r\n" +
        "Dadurch wird sichergestellt, dass keine Volumenkörper mit fehlerhaften, \r\n" +
        "veralteten Abmessungen in der Zeichnung verbleiben. \r\n" +
        "Der Messvorgang kann jedoch zu Verlangsamungen und sogar tödlichen Abstürzen führen.",
      "打开图形后，立即开始更新先前在后台具有度量的所有实体的所有度量。 \r\n" +
        "这可确保绘图中不会保留尺寸错误、过时的实体。 \r\n" +
        "然而，测量过程可能会导致速度减慢，甚至致命的崩溃。",
      "Inmediatamente después de abrir el dibujo, \r\n" +  // ES
        "comience a actualizar todas las métricas de todos los sólidos que anteriormente tenían una métrica en segundo plano. \r\n" +
        "Esto asegura que no queden sólidos con dimensiones erróneas u obsoletas en el dibujo. \r\n" +
        "Sin embargo, el proceso de medición puede causar ralentizaciones e incluso fallos fatales.",
      "Immédiatement après l'ouverture du dessin, \r\n" +  // FR
        "commencez à mettre à jour toutes les métriques pour tous les solides qui avaient précédemment une métrique en arrière-plan. \r\n" +
        "Cela garantit qu'aucun solide avec des dimensions erronées ou obsolètes ne reste dans le dessin. \r\n" +
        "Cependant, le processus de mesure peut causer des ralentissements et même des plantages fatals.",
      "Çizimi açtıktan hemen sonra, \r\n" +  // TR
        "daha önce arka planda metriği olan tüm katılar için tüm metrikleri güncellemeye başlayın. \r\n" +
        "Bu, çizimde hatalı, eski boyutlara sahip katıların kalmamasını sağlar. \r\n" +
        "Ancak, ölçüm işlemi yavaşlamalara ve hatta ölümcül çökmelere neden olabilir." };

    public static readonly string[] MeasureSolids = {
      "Measure all solids",
      "Обмерять все солиды",
      "Misura tutti i solidi",
      "Messen Sie alle Feststoffe",
      "测量所有固体",
      "Medir todos los sólidos",                       // ES
      "Mesurer tous les solides",                      // FR
      "Tüm katıları ölç" };                            // TR

    public static readonly string[] MeasureSolidsTip = {
      "Immediately after opening the drawing, \r\n" +
        "start creating metrics for all solids in the background, \r\n" +
        "including even solids inside unused blocks. \r\n" +
        "After creating metrics, you will see the sizes of solids (parts) in the drawing tree and in the properties palette.\r\n" +
        " However, the measurement process can cause brakes and even fatal crashes .",
      "Сразу после открытия чертежа начать в фоновом режиме создавать метрики для всех солидов, \r\n" +
        "включая даже солиду внутри неиспользованных блоков. \r\n" +
        "После создания метрик вы увидите размеры солидов (деталей) в дереве чертежа и в палитре свойств. \r\n" +
        "Однако процесс обмера может вызывать тормоза и даже фатальные сбои.",
      "Subito dopo aver aperto il disegno, inizia a creare metriche per tutti i solidi in background, \r\n" +
        "incluso anche il solido all'interno dei blocchi inutilizzati. \r\n" +
        "Dopo aver creato le metriche, vedrai le dimensioni dei solidi (parti) \r\n" +
        "nell'albero del disegno e nella tavolozza delle proprietà. \r\n" +
        "Tuttavia, il processo di misurazione può causare rallentamenti e persino incidenti mortali.",
      "Beginnen Sie unmittelbar nach dem Öffnen der Zeichnung mit der Erstellung von Metriken für alle Volumenkörper im Hintergrund, \r\n" +
        "auch für den Volumenkörper in nicht verwendeten Blöcken. \r\n" +
        "Nachdem Sie Metriken erstellt haben, \r\n" +
        "sehen Sie die Größen von Volumenkörpern (Teilen) im Zeichnungsbaum und in der Eigenschaftenpalette. \r\n" +
        "Der Messvorgang kann jedoch zu Verlangsamungen und sogar tödlichen Abstürzen führen.",
      "打开图形后，立即开始为背景中的所有实体创建度量，甚至包括未使用的块内的实体。 \r\n" +
        "创建度量后，您将在绘图树和属性选项板中看到实体（零件）的大小。 \r\n" +
        "然而，测量过程可能会导致速度减慢，甚至致命的崩溃。",
      "Inmediatamente después de abrir el dibujo, \r\n" +  // ES
        "comience a crear métricas para todos los sólidos en segundo plano, \r\n" +
        "incluyendo incluso sólidos dentro de bloques no utilizados. \r\n" +
        "Después de crear métricas, verá los tamaños de los sólidos (piezas) en el árbol de dibujo y en la paleta de propiedades.\r\n" +
        " Sin embargo, el proceso de medición puede causar ralentizaciones e incluso fallos fatales.",
      "Immédiatement après l'ouverture du dessin, \r\n" +  // FR
        "commencez à créer des métriques pour tous les solides en arrière-plan, \r\n" +
        "y compris même les solides à l'intérieur de blocs non utilisés. \r\n" +
        "Après avoir créé des métriques, vous verrez les tailles des solides (pièces) dans l'arbre de dessin et dans la palette de propriétés.\r\n" +
        " Cependant, le processus de mesure peut causer des ralentissements et même des plantages fatals.",
      "Çizimi açtıktan hemen sonra, \r\n" +  // TR
        "kullanılmayan blokların içindeki katılar dahil olmak üzere arka planda tüm katılar için metrikler oluşturmaya başlayın. \r\n" +
        "Metrikleri oluşturduktan sonra, çizim ağacında ve özellikler paletinde katıların (parçaların) boyutlarını göreceksiniz.\r\n" +
        " Ancak, ölçüm işlemi yavaşlamalara ve hatta ölümcül çökmelere neden olabilir." };

    public static readonly string[] Collapse = {
      "Collapse tree branches",
      "Сворачивать ветви дерева",
      "Abbassa i rami degli alberi",
      "Baumzweige einstürzen lassen",
      "倒塌的树枝",
      "Contraer ramas del árbol",                       // ES
      "Réduire les branches de l'arbre",                // FR
      "Ağaç dallarını daralt" };                        // TR

    public static readonly string[] CollapseTip = {
      "When expanding a tree branch with the '+' button, all other expanded branches will be automatically collapsed.",
      "При раскрытии ветви дерева кнопкой '+', все прочие развернутые ветви будут автоматически свернуты.",
      "Quando si espande un ramo di un albero con il pulsante '+', tutti gli altri rami espansi verranno automaticamente compressi.",
      "Wenn Sie einen Baumzweig mit der Schaltfläche '+' erweitern, werden alle anderen erweiterten Zweige automatisch ausgeblendet.",
      "当使用"+"按钮展开树枝时，所有其他展开的分支将自动折叠。",
      "Al expandir una rama del árbol con el botón '+', todas las demás ramas expandidas se contraerán automáticamente.",  // ES
      "Lors de l'expansion d'une branche d'arbre avec le bouton '+', toutes les autres branches développées seront automatiquement réduites.",  // FR
      "'+' düğmesiyle bir ağaç dalını genişletirken, diğer tüm genişletilmiş dallar otomatik olarak daraltılacaktır." };  // TR

    public static readonly string[] ExpandBranches = {
      "Expand branches with selected",
      "Разворачивать ветви с выбранными",
      "Espandi i rami",
      "Zweige erweitern",
      "展开包含选定对象的分支",
      "Expandir ramas con seleccionados",               // ES
      "Développer les branches avec sélectionnés",      // FR
      "Seçililerle dalları genişlet"    };              // TR

    public static readonly string[] ExpandBranchesTip = {
      "When selecting objects in the drawing, expand tree branches to show all selected objects. \r\n" +
          "Disable this option to prevent the tree from changing its view without your input.",
      "При выборе объектов в чертеже, разворачивать ветви дерева, чтоб показать все выбранные объекты. \r\n" +
          "Отключите опцию, чтоб дерево не меняло свой вид без вашего участия.",
      "Quando si selezionano oggetti nel disegno, espandere i rami dell'albero per mostrare tutti gli oggetti selezionati. \r\n" +
          "Disabilitare questa opzione per impedire che l'albero cambi aspetto senza il tuo intervento.",
      "Beim Auswählen von Objekten in der Zeichnung die Baumzweige erweitern, um alle ausgewählten Objekte anzuzeigen. \r\n" +
          "Deaktivieren Sie diese Option, damit der Baum seine Ansicht nicht ohne Ihre Eingabe ändert.",
      "在图形中选择对象时，展开树分支以显示所有选定的对象。 \r\n" +
          "禁用此选项可防止树在没有您输入的情况下更改其视图。",
      "Al seleccionar objetos en el dibujo, expandir ramas del árbol para mostrar todos los objetos seleccionados. \r\n" +  // ES
          "Desactive esta opción para evitar que el árbol cambie su vista sin su entrada.",
      "Lors de la sélection d'objets dans le dessin, développer les branches de l'arbre pour afficher tous les objets sélectionnés. \r\n" +  // FR
          "Désactivez cette option pour empêcher l'arbre de changer de vue sans votre intervention.",
      "Çizimdeki nesneleri seçerken, seçilen tüm nesneleri göstermek için ağaç dallarını genişletin. \r\n" +  // TR
          "Ağacın girişiniz olmadan görünümünü değiştirmesini önlemek için bu seçeneği devre dışı bırakın."    };

    public static string[] LayerFiltersTip = {
      "You can enable this option so that the list of drawing layers is divided into filters and groups, \r\n" +
        "as configured in the layer manager window. \r\n" +
        "Filters are shown only in drawing layers, not inside blocks. \r\n" +
        "To update the filters you need to save the drawing. \r\n" +
        "By default, filters are disabled and all layers are shown in one list.",
      "Можно включить эту опцию, чтоб список слоев чертежа разделился на фильтры и группы, \r\n" +
        "как это настроено в окне менеджера слоев. \r\n" +
        "Фильтры показываются только в слоях чертежа, но не внутри блоков. \r\n" +
        "Чтоб обновить фильтры требуется сохранить чертеж. \r\n" +
        "По умолчанию фильтры отключены и все слои показаны одним списком.",
      "È possibile abilitare questa opzione in modo che l'elenco dei layer del disegno sia diviso in filtri e gruppi, \r\n" +
        "come configurato nella finestra del gestore layer. \r\n" +
        "I filtri vengono visualizzati solo nei layer del disegno, non all'interno dei blocchi. \r\n" +
        "Per aggiornare i filtri è necessario salvare il disegno. \r\n" +
        "Per impostazione predefinita, i filtri sono disabilitati e tutti i layer vengono visualizzati in un unico elenco.",
      "Sie können diese Option aktivieren, damit die Liste der Zeichnungsebenen in Filter und Gruppen unterteilt wird, \r\n" +
        "wie im Ebenenmanagerfenster konfiguriert. \r\n" +
        "Filter werden nur in Zeichnungsebenen angezeigt, nicht innerhalb von Blöcken. \r\n" +
        "Um die Filter zu aktualisieren, müssen Sie die Zeichnung speichern. \r\n" +
        "Standardmäßig sind Filter deaktiviert und alle Ebenen werden in einer Liste angezeigt.",
      "您可以启用此选项，以便将绘图图层列表分为过滤器和组，如图层管理器​​窗口中的配置。 \r\n" +
        "过滤器仅显示在绘图层中，而不显示在块内。 \r\n" +
        "要更新过滤器，您需要保存绘图。 \r\n" +
        "默认情况下，过滤器处于禁用状态，所有图层都显示在一个列表中。",
      "Puede habilitar esta opción para que la lista de capas de dibujo se divida en filtros y grupos, \r\n" +  // ES
        "según se configure en la ventana del administrador de capas. \r\n" +
        "Los filtros se muestran solo en capas de dibujo, no dentro de bloques. \r\n" +
        "Para actualizar los filtros necesita guardar el dibujo. \r\n" +
        "Por defecto, los filtros están deshabilitados y todas las capas se muestran en una lista.",
      "Vous pouvez activer cette option pour que la liste des calques de dessin soit divisée en filtres et groupes, \r\n" +  // FR
        "telle que configurée dans la fenêtre du gestionnaire de calques. \r\n" +
        "Les filtres ne sont affichés que dans les calques de dessin, pas à l'intérieur des blocs. \r\n" +
        "Pour mettre à jour les filtres, vous devez enregistrer le dessin. \r\n" +
        "Par défaut, les filtres sont désactivés et tous les calques sont affichés dans une seule liste.",
      "Bu seçeneği etkinleştirerek çizim katmanları listesinin, katman yöneticisi penceresinde yapılandırıldığı gibi \r\n" +  // TR
        "filtrelere ve gruplara bölünmesini sağlayabilirsiniz. \r\n" +
        "Filtreler yalnızca çizim katmanlarında gösterilir, blokların içinde gösterilmez. \r\n" +
        "Filtreleri güncellemek için çizimi kaydetmeniz gerekir. \r\n" +
        "Varsayılan olarak, filtreler devre dışıdır ve tüm katmanlar tek bir listede gösterilir." };
  }
}
