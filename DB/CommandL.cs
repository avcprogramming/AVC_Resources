// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Ortho Poly Simp Unhide Dwg Det CRS NCP OSL SNN StSt TNT DDL DDJ DRI DXFExport MSL CNC Linetype

namespace AVC
{
  /// <summary>
  /// Локализация имен команд и программ
  /// </summary>
  public static class
  CommandL
  {
    public static readonly string[] Commands = {
      "Commands",
      "Команды",
      "Comandi",
      "Befehle",
      "命令列表",
      "Comandos",
      "Commandes",
      "Komutlar"};

    // =======================================================================================
    // Commands & Programs ===================================================================

    public static readonly string[] ASimp = {
      "Polyline Simplification",
      "Упрощение полилиний",
      "Semplificazione polilinea",
      "Polylinienvereinfachung",
      "折线简化",
      "Simplificación de polilíneas",
      "Simplification de polylignes",
      "Poliçizgi Basitleştirme"};
    public static readonly string[] ASL = {
      "A>V>C> Slice",
      "Отслоение",
      "Esfoliazione",
      "Kappen",
      "去角质",
      "Deslaminado",
      "Délamination",
      "Katman Ayırma" };
    public static readonly string[] AsmCreate = {
      "Create Assembly",
      "Создать сборку",
      "Crea Assemblaggio",
      "Baugruppe erstellen",
      "创建装配体",
      "Crear ensamblaje",
      "Créer un assemblage",
      "Montaj oluştur" };
    public static readonly string[] AsmNew = {
      "New Assembly",
      "Новая сборка",
      "Nuovo Assemblaggio",
      "Neue Baugruppe",
      "新组件",
      "Nuevo ensamblaje",
      "Nouvel assemblage",
      "Yeni montaj" };
    public static readonly string[] AsmDraw = {
      "Assembly drawings",
      "Сборочные чертежи",
      "Disegni di assemblaggio",
      "Montagezeichnungen",
      "装配图",
      "Planos de ensamblaje",
      "Plans d’assemblage",
      "Montaj çizimleri" };
    public static readonly string[] AutoOrtho = {
      "Shutdown Ortho",
      "Выключение Орто",
      "Spegnimento Orto",
      "Abschaltung Ortho",
      "关闭正交结构",
      "Desactivar Orto",
      "Désactiver Ortho",
      "Ortho’yu kapat" };
    public static readonly string[] AutoSnap = {
      "Shutdown Snap",
      "Выключение Привязки",
      "Spegnimento Snap",
      "Abschaltung OFang",
      "关闭所有绑定",
      "Desactivar snaps",
      "Désactiver l’accrochage",
      "Yakalamayı kapat" };
    public static readonly string[] AutoAnn = {
      "Annotation Layer",
      "Слой Аннотаций",
      "Layer Annotate",
      "Layer Beschriftung",
      "启用注释层",
      "Capa de anotación",
      "Calque d’annotation",
      "Açıklama katmanı" };
    public static readonly string[] AutoLng = {
      "Auto Language",
      "Авто Язык",
      "Lingua automatica",
      "Auto-Sprache",
      "自动语言切换",
      "Idioma automático",
      "Langue automatique",
      "Otomatik dil" };
    public static string[] AvcOptions = { // не readonly! изменяем в VARS
      "A>V>C> Options",
      "Настройки A>V>C>",
      "Impostazioni A>V>C>",
      "A>V>C>-Optionen",
      "A>V>C> 设置面板",
      "Opciones A>V>C>",
      "Options A>V>C>",
      "A>V>C> Seçenekleri" };
    public static readonly string[] AvcUpdate = {
      "A>V>C> Update",
      "Обновить A>V>C>",
      "Aggiorna A>V>C>",
      "A>V>C> aktualisieren",
      "更新 A>V>C> 插件",
      "Actualizar A>V>C>",
      "Mettre à jour A>V>C>",
      "A>V>C> Güncelle" };
    public static readonly string[] BlockMetric = {
      "Block Metric",
      "Метрика Блока",
      "Metrica del blocco",
      "Blockmetrik",
      "块指标",
      "Métrica del bloque",
      "Métrique du bloc",
      "Blok ölçüleri" };
    public static readonly string[] BoxToWall = {
      "Box To Wall",
      "Стена из бокса",
      "Scatola da murare",
      "Box zur Wand",
      "盒子到墙",
      "Caja a pared",
      "Boîte vers mur",
      "Kutudan duvara" };
    public static readonly string[] BoxToVector = {
      "Box To Vector",
      "Векторы из бокса",
      "Casella al vettore",
      "Box zu Vektor",
      "框到向量",
      "Caja a vector",
      "Boîte vers vecteur",
      "Kutu vektöre" };
    public static readonly string[] BoxFromTable = {
      "Box From Table",
      "Боксы по таблице",
      "Scatola Dalla Tabella",
      "Box aus Tabelle",
      "来自表格的框",
      "Cajas desde tabla",
      "Boîtes depuis tableau",
      "Tablodan kutular" };
    public static readonly string[] BUpdate = {
      "Block Update",
      "Обновить Блок",
      "Aggiorna blocco",
      "Block aktualisieren",
      "更新块",
      "Actualizar bloque",
      "Mettre à jour le bloc",
      "Bloğu güncelle" };
    public static readonly string[] Buben = {
      "Buben",
      "Бубен",
      "Buben",
      "Buben",
      "Buben",
      "Buben",
      "Buben",
      "Buben" };
    public static readonly string[] CH = {
      "Chop",
      "Нарезка",
      "Tritare",
      "Hacken",
      "切片",
      "Cortar",
      "Découper",
      "Doğra" };
    public static readonly string[] CHE = {
      "Chop Edge",
      "Нарезка вдоль ребра",
      "Tritare di un bordo",
      "Kante hacken",
      "沿着肋骨切片",
      "Cortar borde",
      "Découper le bord",
      "Kenar kes" };
    public static readonly string[] CNum = {
      "Numbering on Curve",
      "Нумерация по кривой",
      "Numerazione sulla curva",
      "Nummerierung auf Kurve",
      "沿曲线编号",
      "Numeración en curva",
      "Numérotation sur courbe",
      "Eğri üzerinde numaralama" };
    public static readonly string[] CPoly = {
      "Curve to Polyline",
      "Кривые в полилинии",
      "Curve in polilinee",
      "Kurven in Polylinien",
      "将曲线转换为多段线",
      "Curva a polilínea",
      "Courbe en polyligne",
      "Eğriyi çoklu çizgiye" };
    public static readonly string[] CRS = {
      "Cross-Piece",
      "Крестовина",
      "Traversa",
      "Kreuzstück",
      "叉",
      "Cruce",
      "Traverse",
      "Çapraz parça" };
    public static readonly string[] CurveInt = {
      "Curve Intersect",
      "Пересечение кривых",
      "Intersezione di curve",
      "Schnittpunkt von Kurven",
      "曲线相交",
      "Intersección de curvas",
      "Intersection de courbes",
      "Eğrileri kesiştir" };
    public static readonly string[] CurveSub = {
      "Curve Subtract",
      "Вычитание кривых",
      "Sottrarre le curve",
      "Kurven subtrahieren",
      "减去曲线",
      "Restar curvas",
      "Soustraire des courbes",
      "Eğrileri çıkar" };
    public static readonly string[] CurveUnion = {
      "Curve Union",
      "Объединение кривых",
      "Combinazione di curve",
      "Kurven kombinieren",
      "组合曲线",
      "Unión de curvas",
      "Union de courbes",
      "Eğrileri birleştir" };
    public static readonly string[] DataTable = {
      "Data Table",
      "Таблица Данных",
      "Tabella dati",
      "Datentabelle",
      "数据表",
      "Tabla de datos",
      "Table de données",
      "Veri tablosu" };
    public static readonly string[] DDJ = {
      "Dado Joint",
      "Паз",
      "Scanalatura",
      "Rille",
      "凹槽连接",
      "Ensamble ranurado",
      "Assemblage à rainure",
      "Yivli birleştirme"};
    public static readonly string[] DDL = {
      "Dado Loop",
      "Контур выборки",
      "Schema di campionamento",
      "Stichprobenübersicht",
      "缺口轮廓",
      "Contorno de ranura",
      "Contour d’usinage",
      "Yiv konturu" };
    public static readonly string[] DDraw = {
      "Detailing Drawings",
      "Деталировки",
      "Disegni dettagliati",
      "Detailzeichnungen",
      "详图",
      "Planos de detalle",
      "Dessins de détail",
      "Detay çizimleri" };
    public static readonly string[] DimDet = {
      "Dimensions",
      "Размеры",
      "Dimensioni",
      "Abmessungen",
      "细节尺寸",
      "Cotas",
      "Cotes",
      "Ölçülendirme" };
    public static readonly string[] DimOverall = {
      "Overall Dimensions",
      "Габариты",
      "Dimensioni generali",
      "Gesamtabmessungen",
      "方面",
      "Dimensiones generales",
      "Cotes d’encombrement",
      "Genel ölçüler" };
    public static readonly string[] DRI = {
      "Drill",
      "Сверловка",
      "Foratura",
      "Bohren",
      "钻孔",
      "Taladro",
      "Perçage",
      "Delme"};
    public static readonly string[] DrillTable = {
      "Drill Table",
      "Таблица Сверлений",
      "Tabella di perforazione",
      "Bohrtisch",
      "钻孔台",
      "Tabla de taladros",
      "Table des perçages",
      "Delik tablosu" };
    public static readonly string[] DwgTree = {
      "Drawing Tree",
      "Дерево чертежа",
      "Albero del progetto",
      "Blaupausenbaum",
      "蓝图树",
      "Árbol del dibujo",
      "Arbre du dessin",
      "Çizim ağacı" };
    public static readonly string[] DXFExport = {
      "DXF Export",
      "Экспорт DXF",
      "Esportazione DXF",
      "DXF-Export",
      "导出到 DXF",
      "Exportar DXF",
      "Exporter en DXF",
      "DXF Dışa Aktar" };
    public static readonly string[] Expose = {
      "Expose Assemblies",
      "Выставить сборки",
      "Allineare le assemblee",
      "Ordnen Sie Blöcke",
      "排列组件",
      "Exponer ensamblajes",
      "Exposer les assemblages",
      "Montajları yerleştir"};
    public static readonly string[] FP = {
      "Fillet Polyline",
      "Скруглить полилинии",
      "Filetto polilinea",
      "Filet Polylinie",
      "圆形折线角",
      "Redondear polilíneas",
      "Congé sur polylignes",
      "Poliçizgiyi yuvarla" };
    public static readonly string[] FindName = {
      "Find by Name",
      "Поиск по Имени",
      "Trova per nome",
      "Nach Namen suchen",
      "按名称查找对象",
      "Buscar por nombre",
      "Rechercher par nom",
      "Ada göre bul" };
    public static readonly string[] Fixture = {
      "Fixture",
      "Крепеж",
      "Apparecchio",
      "Befestigung",
      "紧固件",
      "Fijación",
      "Fixation",
      "Bağlantı elemanı" };
    public static readonly string[] FLT = {
      "Flat",
      "Плоский",
      "Piatto",
      "Eben",
      "平铸",
      "Plano",
      "Plat",
      "Düz" };
    public static readonly string[] GAP = {
      "Subtract with Gap",
      "Вычитание с Зазором",
      "Sottrazione con Gap",
      "Subtraktion mit Lücke",
      "带间隙减法",
      "Restar con holgura",
      "Soustraire avec jeu",
      "Boşlukla çıkar"};
    public static readonly string[] HideAvc = {
      "Hide AVC Palettes",
      "Скрыть палитры AVC",
      "Nascondi tavolozze AVC",
      "AVC-Paletten ausblenden",
      "隐藏 AVC 调色板",
      "Ocultar paletas AVC",
      "Masquer les palettes AVC",
      "AVC paletlerini gizle"};
    public static readonly string[] IC = {
      "Inside Corner",
      "Внутренний угол",
      "Angolo interno",
      "Innere Ecke",
      "切内角",
      "Esquina interior",
      "Angle intérieur",
      "İç köşe" };
    public static readonly string[] InfoPalette = {
      "Info Palette",
      "Палитра Информация",
      "Tavolozza Info",
      "Infopalette",
      "调色板信息",
      "Paleta Información",
      "Palette Info",
      "Bilgi paleti" };
    public static readonly string[] Invert = {
      "Invert visibility",
      "Инвертировать видимость",
      "Inverti visibilità",
      "Sichtbarkeit umkehren",
      "反转可见性",
      "Invertir visibilidad",
      "Inverser la visibilité",
      "Görünürlüğü ters çevir" };
    public static readonly string[] KindPalette = {
      "Kind Palette",
      "Палитра Тип",
      "Tavolozza Kind",
      "Art Palette",
      "调色板类型",
      "Paleta Tipo",
      "Palette Type",
      "Tür paleti" };
    public static readonly string[] Kit3d = {
      "A>V>C> 3D kit",
      "3D-инструменты A>V>C>",
      "A>V>C> Strumenti 3D",
      "A>V>C> 3D-Werkzeuge",
      "A>V>C> 3D 工具",
      "A>V>C> Kit 3D",
      "Outils 3D A>V>C>",
      "A>V>C> 3B araçları"};
    public static readonly string[] Kit2d = {
      "A>V>C> 2D kit",
      "2D-инструменты A>V>C>",
      "A>V>C> Strumenti 2D",
      "A>V>C> 2D-Werkzeuge",
      "A>V>C> 2D 工具",
      "A>V>C> Kit 2D",
      "Outils 2D A>V>C>",
      "A>V>C> 2B araçları" };
    public static readonly string[] Lay = {
      "Lay",
      "Выкладка",
      "Disposizione",
      "Layout",
      "平铺",
      "Disposición",
      "Disposition",
      "Döşeme"};
    public static readonly string[] LeaderUpdate = {
      "Update Smart Leaders",
      "Обновить умные выноски",
      "Aggiorna direttrici intelligenti",
      "Aktualisieren Sie Führungslinie",
      "更新智能引线",
      "Actualizar directrices inteligentes",
      "Mettre à jour les repères intelligents",
      "Akıllı işaret çizgilerini güncelle" };
    public static readonly string[] Mark = {
      "Mark",
      "Маркировка",
      "Marcatura",
      "Markierung",
      "打标",
      "Marcar",
      "Marquage",
      "İşaretle" };
    public static readonly string[] MatTable = {
      "Table of Materials",
      "Таблица Материалов",
      "Tabella dei Materiali",
      "Materialtabelle",
      "材料表",
      "Tabla de materiales",
      "Table des matériaux",
      "Malzeme tablosu" };
    public static readonly string[] MeshToSolid = {
      "Mesh to Solid",
      "Сеть в солид",
      "Da mesh a solido",
      "Netz in Volumenkörper",
      "将网格转换为三维实体",
      "Malla a sólido",
      "Maillage en solide",
      "Ağdan katı" };
    public static readonly string[] MeshExplode = {
      "Explode Mesh",
      "Взорвать сеть",
      "Esplodi mesh",
      "Explosionsnetz",
      "炸网",
      "Explotar malla",
      "Éclater le maillage",
      "Ağı patlat" };
    public static readonly string[] Miter = {
      "Miter Joint",
      "Соединение Под ус",
      "Mitre Joint",
      "Gehrungsfuge",
      "斜接",
      "Unión a inglete",
      "Assemblage en onglet",
      "Gönye birleştirme" };
    public static readonly string[] MNum = {
      "Manual Numbering",
      "Ручная Нумерация",
      "Numerazione manuale",
      "Manuelle Nummerierung",
      "手动编号",
      "Numeración manual",
      "Numérotation manuelle",
      "Manuel numaralama" };
    public static readonly string[] MSL = {
      "Multi Slice",
      "Мульти-Отслоение",
      "Multi Esfoliazione",
      "Multi Kappen",
      "多重剥离",
      "Corte por capas múltiple",
      "Multi‑délamination",
      "Çoklu katman ayırma" };
    public static readonly string[] NamePalette = {
      "Name Palette",
      "Палитра Имя",
      "Tavolozza Nome",
      "Namenspalette",
      "调色板名称",
      "Paleta Nombre",
      "Palette Nom",
      "İsim paleti" };
    public static readonly string[] NCP = {
      "NC Prepare",
      "ЧПУ Подготовка",
      "Preparazione CNC",
      "CNC-Vorbereitung",
      "数控准备",
      "Preparación CNC",
      "Préparation CNC",
      "CNC hazırlık" };
    public static readonly string[] Numbering = {
      "Numbering",
      "Нумерация",
      "Numerazione",
      "Nummerierung",
      "编号",
      "Numeración",
      "Numérotation",
      "Numaralandırma"};
    public static readonly string[] OMO = {
      "Offset of Many Objects",
      "Офсет многих объектов",
      "Offset di molti oggetti",
      "Versetz vieler Objekte",
      "许多对象的偏移",
      "Desfase de muchos objetos",
      "Décalage de plusieurs objets",
      "Birçok nesnenin ofseti" };
    public static readonly string[] OpenAvc = {
      "Open AVC Palettes",
      "Открыть палитры AVC",
      "Apri le tavolozze AVC",
      "Öffnen Sie AVC-Paletten",
      "打开 AVC 调色板",
      "Abrir paletas AVC",
      "Ouvrir les palettes AVC",
      "AVC paletlerini aç"};
    public static readonly string[] OSL = {
      "Outside Loop",
      "Внешний контур",
      "Ciclo esterno",
      "Außenschleife",
      "外环",
      "Contorno exterior",
      "Boucle extérieure",
      "Dış çevrim" };
    public static readonly string[] PageNo = {
      "Page Numbering",
      "Нумерация страниц",
      "Numerazione pagine",
      "Seitennummerierung",
      "分页",
      "Numeración de páginas",
      "Numérotation des pages",
      "Sayfa numaralandırma" };
    public static readonly string[] Palette = {
      "A>V>C> Properties Palette",
      "Палитра Свойств A>V>C>",
      "A>V>C> Tavolozza delle proprietà",
      "A>V>C> Eigenschaftenpalette",
      "A>V>C> 属性面板",
      "Paleta de propiedades A>V>C>",
      "Palette des propriétés A>V>C>",
      "A>V>C> Özellikler paleti" };
    public static readonly string[] PlaceLeaders = {
      "Place Leaders",
      "Разместить выноски",
      "Posiziona le direttrici",
      "Führungslinie platzieren",
      "放置引线",
      "Colocar directrices",
      "Placer les repères",
      "İşaret çizgilerini yerleştir" };
    public static readonly string[] PLineDir = {
      "Polyline Direction",
      "Направление полилинии",
      "Direzione polilinea",
      "Polylinienrichtung",
      "折线方向",
      "Dirección de polilínea",
      "Direction de polyligne",
      "Poliçizgi yönü" };
    public static readonly string[] ReduceW = {
      "Reduce Weight",
      "Уменьшить вес",
      "Riduci il peso",
      "Gewicht verlieren",
      "减轻体重",
      "Reducir peso",
      "Réduire le poids",
      "Ağırlığı azalt"  };
    public static readonly string[] RemHoles = {
      "Removing Holes",
      "Удаление отверстий",
      "Rimozione dei fori",
      "Löcher entfernen",
      "孔去除",
      "Eliminación de agujeros",
      "Suppression de trous",
      "Deliklerin kaldırılması" };
    public static readonly string[] Pro = {
      "A>V>C> Pro" };
    public static readonly string[] PTT = {
      "Paste To Table",
      "Вставка в таблицу",
      "Incolla nella tabella",
      "In Tabelle einfügen",
      "插入表格",
      "Pegar en tabla",
      "Coller dans le tableau",
      "Tabloya yapıştır" };
    public static readonly string[] QCleaning = {
      "Quick cleaning",
      "Быстрая чистка",
      "Pulizia rapida",
      "Schnelle Reinigung",
      "快速清洁",
      "Limpieza rápida",
      "Nettoyage rapide",
      "Hızlı temizlik" };
    public static readonly string[] Saw = {
      "Sawing Table",
      "Таблица Напилки",
      "Tavolo da Taglio",
      "Sägetisch",
      "锯床",
      "Tabla de corte",
      "Table de sciage",
      "Kesim tablosu" };
    public static readonly string[] SawRed = {
      "Saw Red",
      "Напилка красным",
      "Saw Rosso",
      "Sah Rot",
      "锯切红色",
      "Sierra roja",  
      "Scie rouge",   
      "Kırmızı kesim" };  
    public static readonly string[] SelectSame = {
      "Select Same",
      "Похожие",
      "Seleziona lo stesso",
      "Wählen Sie Gleich",
      "查找类似的",
      "Seleccionar similar",
      "Sélectionner similaire",
      "Benzerleri seç" };
    public static readonly string[] SelectSameAgain = {
      "Select Same Again",
      "Похожие Повтор",
      "Seleziona lo stesso. Ripetere",
      "Wählen Sie Gleich. Wiederholen",
      "查找相似的重复",
      "Seleccionar similar de nuevo",
      "Sélectionner similaire à nouveau",
      "Benzerlerini tekrar seç" };
    public static readonly string[] SimpInFiles = {
      "Simplifying contours in files",
      "Упрощение контуров в файлах",
      "Semplificazione dei contorni nei file",
      "Vereinfachen von Umrissen in Dateien",
      "简化文件中的轮廓",
      "Simplificación de contornos en archivos",
      "Simplification des contours dans les fichiers",
      "Dosyalarda konturları basitleştir" };
    public static readonly string[] SmartLeader = {
      "Smart Leader",
      "Умные Выноски",
      "Direttrice Intelligente",
      "Intelligenter Führungslinie",
      "智能引线",
      "Directriz inteligente",
      "Repère intelligent",
      "Akıllı işaret çizgisi" };
    public static readonly string[] SolidSub = {
      "Solid Subtract",
      "Вычитание солидов",
      "Sottrazione di solidi",
      "Volumenkörper subtrahieren",
      "减去实体",
      "Restar sólidos",
      "Soustraire des solides",
      "Katıları çıkar" };
    public static readonly string[] SolidUnion = {
      "Solid Union",
      "Объединение солидов",
      "Unione di solidi",
      "Volumenkörper vereinigen",
      "组合实体",
      "Unión de sólidos",
      "Union de solides",
      "Katıları birleştir" };
    public static readonly string[] SolidInt = {
      "Solid Intersect",
      "Пересечение солидов",
      "Intersezione di solidi",
      "Volumenkörper schneiden",
      "实体相交",
      "Intersección de sólidos",
      "Intersection de solides",
      "Katıları kesiştir" };
    public static readonly string[] SolSize = {
      "Size of Solid",
      "Размер солида",
      "Dimensione del solido",
      "Größe des Volumenkörpers",
      "详细指标",
      "Tamaño del sólido",
      "Taille du solide",
      "Katı boyutu" };
    public static readonly string[] SweepSize = {
      "Size of Sweep",
      "Размер развертки",  
      "Dimensione del solido arrotolato",
      "Größe des gerollten Volumenkörpers",
      "扫描尺寸",  
      "Tamaño del barrido",
      "Taille du développé",
      "Süpürme boyutu" };
    public static readonly string[] SumLen = {
      "Summary length",
      "Сумма длин",
      "Somma delle lunghezze",
      "Summe der Längen",
      "长度总和",
      "Longitud total",
      "Longueur totale",
      "Toplam uzunluk" };
    public static readonly string[] SumArea = {
      "Summary area",
      "Сумма площадей",
      "Somma delle aree",
      "Summe der Flächen",
      "总面积",
      "Área total",
      "Surface totale",
      "Toplam alan" };
    public static readonly string[] SNN = {
      "Select unnamed",
      "Выбрать безымянные",
      "Seleziona senza nome",
      "Wählen Sie unbenannt",
      "选择未命名",
      "Seleccionar sin nombre",
      "Sélectionner sans nom",
      "Adsızları seç" };
    public static readonly string[] StSt = {
      "Stair-Step",
      "Ступенчатый",
      "Scalino",
      "Treppenstufe",
      "做阶梯式末端",
      "Escalonado",
      "En escalier",
      "Basamaklı" };
    public static readonly string[] TableFill = {
      "Fill in Table",
      "Заполнить таблицу",
      "Compila la tabella",
      "Füllen Sie die Tabelle aus",
      "填写表格",
      "Rellenar tabla",
      "Remplir le tableau",
      "Tabloyu doldur" };
    public static readonly string[] TableSplit = {
      "Split Table",
      "Разделить таблицу",
      "Tabella divisa",
      "Geteilte Tabelle",
      "拆分表",
      "Dividir tabla",
      "Diviser le tableau",
      "Tabloyu böl" };
    public static readonly string[] TableUpdate = {
      "Update Tables",
      "Обновить таблицы",
      "Aggiorna tabelle",
      "Tabellen aktualisieren",
      "更新表",
      "Actualizar tablas",
      "Mettre à jour les tableaux",
      "Tabloları güncelle" };
    public static readonly string[] TabSlot = {
      "Tab-Slot Joint",
      "Шип-паз",
      "Perno alternato",
      "Stift-Nut-Verbindung",
      "指接榫",
      "Ensamble espiga‑ranura",
      "Assemblage tenon‑rainure",
      "Tırnak‑oyuk birleştirme" };
    public static readonly string[] TextHeight = {
      "Text Height Update",
      "Подбор высоты текстов",
      "Selezione dell'altezza del testo",
      "Auswahl der Texthöhe",
      "文字高度匹配",
      "Ajuste de altura del texto",
      "Ajuster la hauteur du texte",
      "Yazı yüksekliğini ayarla" };
    public static readonly string[] TNT = {
      "TNT - Explode assembly",
      "TNT - Взрыв сборки",
      "TNT - Esplodi assieme",
      "TNT - Baugruppe explodieren lassen",
      "TNT - 爆炸组件",
      "TNT - Explotar ensamblaje",
      "TNT - Exploser l’assemblage",
      "TNT - Montajı patlat" };
    public static readonly string[] TNTUpdate = {
      "TNT Update exploded",
      "TNT Обновить взорванные",
      "TNT Aggiorna esploso",
      "TNT Aktualisieren explodiert",
      "TNT 更新爆炸",
      "TNT Actualizar explosionados",
      "TNT Mettre à jour l’explosé",
      "TNT Patlatılmışları güncelle" };
    public static readonly string[] UnhideInverted = {
      "Unhide Inverted",
      "Показать Инвертированные",
      "Scopri invertito",
      "Invertiert anzeigen",
      "显示反转对象",
      "Mostrar invertidos",
      "Afficher inversés",
      "Ters çevrilenleri göster" };
    public static readonly string[] UnfoldRect = {
      "Unfold Rectangle",
      "Прямоугольник развертки",
      "Aprire il rettangolo",
      "Rechteck entfalten",
      "展开矩形",
      "Desplegar rectángulo",
      "Déplier le rectangle",
      "Dikdörtgeni aç" };
    public static readonly string[] Unpack = {
      "Unpack",
      "Распаковка",
      "Disimballaggio",
      "Auspacken",
      "拆箱",
      "Desempaquetar",
      "Déballer",
      "Paket aç" };
    public static readonly string[] UserPalette = {
      "User Property Palette",
      "Палитра пользовательских свойств",
      "Tavolozza proprietà personalizzate",
      "Benutzerdefinierte Eigenschaftenpalette",
      "自定义属性面板",
      "Paleta de propiedades de usuario",
      "Palette des propriétés utilisateur",
      "Kullanıcı özellikleri paleti" };
    public static readonly string[] Updater = {
      "Update programs",
      "Обновление программ",
      "Aggiorna i programmi",
      "Programme aktualisieren",
      "软件更新",
      "Actualizar programas",
      "Mettre à jour les programmes",
      "Programları güncelle" };
    public static readonly string[] Zone = {
      "Zone",
      "Зона",
      "Zona",
      "Zone",
      "区",
      "Zona",
      "Zone",
      "Bölge" };

    //public static readonly string[]
    //TClear = { "EraseAll Transient Drawings", "Удалить временные рисунки", "Cancella disegni transitori", "Transiente Zeichnungen löschen" };

    //public static readonly string[]
    //AVCMessage = { "A>V>C> Message", "A>V>C> Сообщения", "A>V>C> Messaggio", "A>V>C> Botschaft" };

    // ============================================================================================================
    // Button Tips ================================================================================================

    public static readonly string[] RunCmdTip = {
      "Run {0} command",
      "Запустить команду {0}",
      "Esegui comando {0}",
      "Befehl {0} ausführen",
      "运行命令 {0}",
      "Ejecutar comando {0}",
      "Exécuter la commande {0}",
      "Komutu çalıştır {0}" };
  }
}