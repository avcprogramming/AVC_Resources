// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  ChopL
  {
    public static readonly string[][] ChopStyleNames = {
/* 0 */ CommandL.CH,
/* 1 */ new[]{
        "Chop from a plane",
        "Нарезка от плоскости",
        "Tritare da un aereo",
        "Hack von Oberfläche",
        "从切割平面切割",
        "Cortar desde un plano",           // ES
        "Découper depuis un plan",         // FR
        "Bir düzlemden kesmek"},           // TR
/* 2 */ CommandL.CHE,
/* 3 */ new[]{
        "Rib spacing",
        "Расстановка ребер (нервюр)",
        "Spaziatura delle costole",
        "Rippenabstand",
        "肋间距",
        "Espaciado de nervaduras",         // ES
        "Espacement des nervures",         // FR
        "Kaburga aralığı"},                // TR
    };

    public static readonly string[] PieceLengthQuery = {
      "  Enter the length of the pieces (cutting step)",
      "  Введите длину долек (шаг нарезки)",
      "  Inserisci la lunghezza delle fette (passo di taglio)",
      "  Geben Sie die Länge der Scheiben ein (Schnittschritt)",
      "  输入切片的长度（切割步骤）",
      "  Ingrese la longitud de las piezas (paso de corte)",      // ES
      "  Entrez la longueur des pièces (pas de coupe)",           // FR
      "  Parçaların uzunluğunu girin (kesme adımı)"};             // TR

    public static readonly string[] NoFace = {
      "None of selected face",
      "Нет выбранных поверхностей",
      "Nessuna superficie selezionata",
      "Keine Oberflächen ausgewählt",
      "没有选定的面",
      "Ninguna cara seleccionada",                                // ES
      "Aucune face sélectionnée",                                 // FR
      "Seçili yüz yok"};                                          // TR

    public static readonly string[] SurfErr = {
      "It was necessary to click on the surface of the solid. And you have selected: '{0}'",
      "Надо было кликать по поверхности солида, а выбран: '{0}'",
      "È stato necessario fare clic sulla superficie del solido e selezionare: '{0}'",
      "Es war notwendig, auf die Oberfläche des Volumenkörper zu klicken und Folgendes auszuwählen: '{0}'",
      "需要点击实体的表面。 并且您选择了：'{0}'",
      "Era necesario hacer clic en la superficie del sólido. Y ha seleccionado: '{0}'",  // ES
      "Il était nécessaire de cliquer sur la surface du solide. Et vous avez sélectionné : '{0}'",  // FR
      "Katının yüzeyine tıklamak gerekiyordu. Ve siz şunu seçtiniz: '{0}'"};  // TR

    public static readonly string[] FaceSelectErr = {
      "Can't select face",
      "Не получилось выбрать поверхность",
      "Impossibile selezionare la superficie",
      "Oberfläche konnte nicht ausgewählt werden",
      "无法选择面",
      "No se puede seleccionar la cara",                          // ES
      "Impossible de sélectionner la face",                       // FR
      "Yüz seçilemiyor"};                                         // TR
    public static readonly string[] PlaneErr = {
      "Can't get plane. May it not flat face",
      "Плоскость не определена. Возможно это не плоская поверхность",
      "L'aereo non è definito. Forse non è una superficie piana",
      "Das Flugzeug ist undefiniert. Vielleicht ist es keine flache Oberfläche",
      "无法获得平面，可能不是平面面",
      "No se puede obtener el plano. Puede que no sea una cara plana",  // ES
      "Impossible d'obtenir le plan. Ce n'est peut-être pas une face plane",  // FR
      "Düzlem alınamıyor. Düz yüzey olmayabilir" };  // TR

    public static readonly string[] EdgeSelected = {
      "Solid edge selected",
      "Выбрано ребро солида",
      "Bordo solido selezionato",
      "Kante ausgewählt",
      "选择实体边缘",
      "Borde de sólido seleccionado",  // ES
      "Arête de solide sélectionnée",  // FR
      "Katı kenarı seçildi" };  // TR

    public static readonly string[] BaseQuery = {
      "  Select base face of solid",
      "  Выберите базовую плоскость тела",
      "  Seleziona il piano di base della parte",
      "  Wählen Sie die Basisebene des Volumenkörper",
      "  选择实体的基面",
      "  Seleccione la cara base del sólido",  // ES
      "  Sélectionnez la face de base du solide",  // FR
      "  Katının taban yüzeyini seçin"};  // TR

    public static readonly string[] StartQuery = {
      "  Pick a point on the edge where the first cut will be made",
      "  Выберите точку на ребре, где будет сделан первый разрез",
      "  Scegli un punto sul bordo in cui verrà eseguito il primo taglio",
      "  Wählen Sie einen Punkt auf der Kante, wo der erste Schnitt gemacht wird",
      "  选择边缘上的一个点，进行第一次切割。",
      "  Elija un punto en el borde donde se realizará el primer corte",  // ES
      "  Choisissez un point sur le bord où la première coupe sera effectuée",  // FR
      "  İlk kesimin yapılacağı kenarda bir nokta seçin"};  // TR

    public static readonly string[] CutSolidErr = {
      "Could not cut the solid.",
      "Невозможно разрезать солид.",
      "Impossibile tagliare le parti",
      "Teile können nicht geschnitten werden",
      "无法切割实体.",
      "No se pudo cortar el sólido.",  // ES
      "Impossible de couper le solide.",  // FR
      "Katı kesilemedi." };  // TR

    public static readonly string[] Piece = {
      "Piece",
      "Дольки",
      "Pezzo",
      "Stück",
      "片",
      "Pieza",  // ES
      "Pièce",  // FR
      "Parça" };  // TR

    public static readonly string[] Stub = {
      "Stub",
      "Огрызки",
      "Mozzicone",
      "Stub",
      "存根",
      "Residuo",  // ES
      "Reste",  // FR
      "Kırpıntı" };  // TR

    public static readonly string[] ChopCount = {
      "Chop on {0} solids",
      "Нарезано на {0} долек",
      "Tritare su {0} pezzi",
      "{0} Stücke hacken",
      "切割 {0} 实体",
      "Cortado en {0} sólidos",  // ES
      "Découpé en {0} solides",  // FR
      "{0} katıya kesildi"};  // TR

    public static readonly string[] Formula = {
      "Cutting formula:",
      "Формула нарезки:",
      "Formula per tritare:",
      "Schnittformel:",
      "切片公式：",
      "Fórmula de corte:",  // ES
      "Formule de découpe :",  // FR
      "Kesme formülü:" };  // TR

    public static readonly string[] PieceCountQuery = {
      "Enter count of piece",
      "Введите количество долек",
      "Inserisci il conteggio del pezzo",
      "Stückzahl eingeben",
      "输入件数",
      "Ingrese el número de piezas",  // ES
      "Entrez le nombre de pièces",  // FR
      "Parça sayısını girin" };  // TR

    public static readonly string[] MaxLengthQuery = {
      "Enter a limit on the maximum allowable length of a piece",
      "Введите ограничение по максимально допустимой длине дольки ",
      "Immettere un limite per la lunghezza massima consentita di un segmento",
      "Geben Sie eine Grenze für die maximal zulässige Länge eines Segments ein",
      "输入段的最大允许长度限制",
      "Ingrese un límite en la longitud máxima permitida de una pieza",  // ES
      "Entrez une limite sur la longueur maximale autorisée d'une pièce",  // FR
      "Bir parçanın maksimum izin verilen uzunluğu için bir sınır girin"};  // TR

    public static readonly string[] MaxLengthInfo = {
      "Solid will chop on {0} pieces length {1}",
      "Солид будет нарезан на {0} долек длиной {1}",
      "Il solido taglierà su {0} pezzi di lunghezza {1}",
      "Volumenkörper hackt auf {0} Stücklänge {1}",
      "固体将切成 {0} 件长度 {1}",
      "El sólido se cortará en {0} piezas de longitud {1}",  // ES
      "Le solide sera découpé en {0} pièces de longueur {1}",  // FR
      "Katı {0} parçaya kesilecek, uzunluk {1}" };  // TR

    public static readonly string[] RibErrContinueQuery = {
      "Failed to take into account the thickness of the rib at the alignment of the cut planes. Continue?",
      "Не удалось учесть толщину ребра при расстановке плоскостей реза. Продолжить?",
      "Impossibile tenere conto dello spessore delle nervature quando si posizionano i piani del taglio. Continuare?",
      "Die Dicke der Rippen konnte beim Platzieren der Schnittebenen nicht berücksichtigt werden. Weiter?",
      "在对齐切割面时未能考虑到肋骨的厚度。继续？",
      "No se pudo tener en cuenta el grosor de la nervadura en la alineación de los planos de corte. ¿Continuar?",  // ES
      "Impossible de tenir compte de l'épaisseur de la nervure lors de l'alignement des plans de coupe. Continuer ?",  // FR
      "Kesim düzlemlerinin hizalanmasında kaburga kalınlığı dikkate alınamadı. Devam et?" };  // TR

    public static readonly string[] Need1RegionErr = {
      "Only one flat surface needs to be selected",
      "Требуется выбрать только одну плоскую поверхность",
      "È necessario selezionare solo una superficie piana",
      "Es muss nur eine flache Oberfläche ausgewählt werden",
      "只需选择一个平面",
      "Solo se necesita seleccionar una superficie plana",  // ES
      "Une seule surface plane doit être sélectionnée",  // FR
      "Yalnızca bir düz yüzey seçilmelidir" };  // TR

    public static readonly string[] StStProcess = {
      "Make stair-step solids...",
      "Делаем ступенчатые детали...",
      "Realizzazione di parti a gradini ...",
      "Stufenteile herstellen ...",
      "制作阶梯实体...",
      "Creando sólidos escalonados...",  // ES
      "Création de solides en escalier...",  // FR
      "Merdiven basamaklı katılar oluşturuluyor..." };  // TR

    public static readonly string[] StStErr = {
      "Failed to make stair-step solid.",
      "Не получилось сделать ступенчатый солид.",
      "Non ha funzionato per fare una parte a gradini.",
      "Es hat nicht geklappt, einen abgestuften Teil zu machen.",
      "无法制作阶梯实体。",
      "No se pudo crear el sólido escalonado.",  // ES
      "Échec de la création du solide en escalier.",  // FR
      "Merdiven basamaklı katı oluşturulamadı." };  // TR

    public static readonly string[] TwiceWarning = {
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
        "建议手动分割实体。",
      "El borde está doblado de modo que cruza el plano de corte dos veces.\n" +  // ES
        "Como resultado, se formaron piezas/nervaduras innecesarias.\n" +
        "Se recomienda dividir el sólido antes.",
      "Le bord est plié de sorte qu'il traverse le plan de coupe deux fois.\n" +  // FR
        "En conséquence, des pièces/nervures inutiles se sont formées.\n" +
        "Il est recommandé de diviser le solide avant.",
      "Kenar, kesim düzlemini iki kez geçecek şekilde bükülmüş.\n" +  // TR
        "Sonuç olarak, gereksiz parçalar/kaburgalar oluştu.\n" +
        "Katıyı önceden bölmek önerilir."};

    public static readonly string[] Saved = {
      "Saved {0} new solids.",
      "Сохранено {0} новых солидов.",
      "{0} nuovo solido salvato.",
      "{0} neuer Volumenkörper gespeichert.",
      "保存了 {0} 个新实体。",
      "Guardados {0} sólidos nuevos.",  // ES
      "Enregistré {0} nouveaux solides.",  // FR
      "{0} yeni katı kaydedildi."};  // TR

    public static readonly string[] CutErrTwice = {
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
        "建议手动分割实体。",
      "No se pudo realizar el corte.\n" +  // ES
        "El borde está doblado de modo que cruza el plano de corte dos veces.\n" +
        "Se recomienda dividir el sólido antes.",
      "Impossible d'effectuer la coupe.\n" +  // FR
        "Le bord est plié de sorte qu'il traverse le plan de coupe deux fois.\n" +
        "Il est recommandé de diviser le solide avant.",
      "Kesim yapılamadı.\n" +  // TR
        "Kenar, kesim düzlemini iki kez geçecek şekilde bükülmüş.\n" +
        "Katıyı önceden bölmek önerilir."};

    public static readonly string[] SectionMissing = {
      "Section {0} missing.",
      "Сечение {0} пропущено.",
      "Manca la sezione {0}.",
      "Abschnitt {0} fehlt.",
      "缺少第 {0} 节。",
      "Falta la sección {0}.",  // ES
      "Section {0} manquante.",  // FR
      "Bölüm {0} eksik." };  // TR

    public static readonly string[] SectionErr = {
      "  Section plane outside of base edge.",
      "  Секущая плоскость за пределами базовой кривой.",
      "  Piano di sezione esterno al bordo della base.",
      "  Schnittebene außerhalb der Basiskante.",
      "  基础边缘外的剖面。",
      "  Plano de sección fuera del borde base.",  // ES
      "  Plan de section en dehors du bord de base.",  // FR
      "  Kesit düzlemi taban kenarının dışında."};  // TR

    public static readonly string[] IntersectWithErr = {
      "  IntersectWith throw error.",
      "  IntersectWith выдал ошибку.",
      "  IntersectWith ha generato un errore.",
      "  IntersectWith hat einen Fehler ausgegeben.",
      "  IntersectWith 抛出错误。",
      "  IntersectWith arrojó error.",  // ES
      "  IntersectWith a généré une erreur.",  // FR
      "  IntersectWith hata verdi." };  // TR

    public static readonly string[] NothingToCut = {
      "  There is nothing to cut in this place.",
      "  В этом месте нечего резать.",
      "  Non c'è niente da tagliare in questo posto.",
      "  An dieser Stelle gibt es nichts zu schneiden.",
      "  这里没有东西可以切割。",
      "  No hay nada que cortar en este lugar.",  // ES
      "  Il n'y a rien à couper à cet endroit.",  // FR
      "  Bu yerde kesilecek bir şey yok." };  // TR

    public static readonly string[] StubErr = {
      "Could not calculate stub. {0}",
      "Невозможно вычислить обрезки. {0}",
      "Impossibile calcolare il ritaglio. {0}",
      "Ernte kann nicht berechnet werden. {0}",
      "无法计算残余部分。 {0}",
      "No se pudo calcular el residuo. {0}",  // ES
      "Impossible de calculer le reste. {0}",  // FR
      "Kırpıntı hesaplanamadı. {0}" };  // TR

    public static readonly string[] CutRibErr = {
      "Failed to cut rib",
      "Невозможно вырезать ребро.",
      "Impossibile tagliare le costole.",
      "Rippe kann nicht geschnitten werden.",
      "无法切割肋骨",
      "No se pudo cortar la nervadura",  // ES
      "Échec de la coupe de la nervure",  // FR
      "Kaburga kesilemedi" };  // TR

    public static readonly string[] PieceNameTemplate = {
      "'Piece'00",
      "'Часть '00",
      "'Pezzo '00",
      "'Stück '00",
      "'片'00",
      "'Pieza'00",  // ES
      "'Pièce'00",  // FR
      "'Parça'00"};  // TR

    public static readonly string[] SectionErrContinueQuery = {
      "Not possible to arrange all the cutting planes. Continue?",
      "Не получается расставить все секущие плоскости. Продолжить?",
      "Non è possibile disporre tutti gli aerei secanti. Continuare?",
      "Es ist nicht möglich, alle Sekantenebenen anzuordnen. Weiter?",
      "无法安排所有的切割平面。继续吗？",
      "No es posible organizar todos los planos de corte. ¿Continuar?",  // ES
      "Impossible d'organiser tous les plans de coupe. Continuer ?",  // FR
      "Tüm kesim düzlemlerini düzenlemek mümkün değil. Devam et?" };  // TR

    public static readonly string[] GapInfo = {
      "  Current settings: Gap = {0}",
      "  Текущие настройки: Зазор = {0}",
      "  Impostazioni correnti: Liquidazione = {0}",
      "  Aktuelle Einstellungen: Spiel = {0}",
      "  当前设置：间隙 = {0}",
      "  Configuración actual: Espacio = {0}",  // ES
      "  Paramètres actuels : Écart = {0}",  // FR
      "  Geçerli ayarlar: Boşluk = {0}" };  // TR

    public static readonly string[] PointOnEdgeErr = {
      "Start point does not belong to an edge",
      "Стартовая точка не принадлежит ребру",
      "Il punto iniziale non appartiene a uno spigolo",
      "Startpunkt gehört nicht zu einer Kante",
      "起点不属于边缘。",
      "El punto de inicio no pertenece a un borde",  // ES
      "Le point de départ n'appartient pas à un bord",  // FR
      "Başlangıç noktası bir kenara ait değil" };  // TR

    public static readonly string[] TooSmallSolidErr = {
      "Part or edge too small to cut",
      "Деталь или ребро слишком маленькое для разрезания",
      "Parte o bordo troppo piccolo per essere tagliato",
      "Teil oder Kante zu klein zum Schneiden",
      "零件或边缘太小,无法切割",
      "Pieza o borde demasiado pequeño para cortar",  // ES
      "Pièce ou bord trop petit pour couper",  // FR
      "Parça veya kenar kesmek için çok küçük" };  // TR

    public static readonly string[] TooManyPiecesErr = {
      "Too many part cuts configured",
      "Настроено слишком большое количество разрезов детали",
      "Troppi tagli di pezzi configurati",
      "Zu viele Teilschnitte konfiguriert",
      "配置的零件切割太多",
      "Demasiados cortes de piezas configurados",  // ES
      "Trop de coupes de pièces configurées",  // FR
      "Çok fazla parça kesimi yapılandırıldı" };  // TR

    public static readonly string[] TooBigMaxStepErr = {
      "The maximum allowable step is set greater than the part itself",
      "Задан максимально допустимый шаг больше чем сама деталь",
      "Il passo massimo consentito è impostato maggiore del pezzo stesso",
      "Der maximal zulässige Schritt ist größer eingestellt als das Teil selbst",
      "最大允许步长设置大于部件本身",
      "El paso máximo permitido está configurado mayor que la pieza misma",  // ES
      "Le pas maximal autorisé est défini plus grand que la pièce elle-même",  // FR
      "Maksimum izin verilen adım parçanın kendisinden daha büyük ayarlanmış" };  // TR

    public static readonly string[] TooSmallMaxStepErr = {
      "Max step too small",
      "Максимальный шаг слишком мал",
      "Passo massimo troppo piccolo",
      "Max. Schritt zu klein",
      "最大步长太小",
      "Paso máximo demasiado pequeño",  // ES
      "Pas maximal trop petit",  // FR
      "Maksimum adım çok küçük" };  // TR

    public static readonly string[] NumberOfPiecesErr = {
      "The number of pieces must be greater than or equal to two",
      "Количество долек должно быть больше или равно двум",
      "Il numero di fette deve essere maggiore o uguale a due",
      "Die Anzahl der Slices muss größer oder gleich zwei sein",
      "切片的数量必须大于或等于两个",
      "El número de piezas debe ser mayor o igual a dos",  // ES
      "Le nombre de pièces doit être supérieur ou égal à deux",  // FR
      "Parça sayısı ikiden büyük veya eşit olmalıdır" };  // TR

    public static readonly string[] TooBigGapErr = {
      "You won't be able to make cuts with such a huge gap.",
      "Не получится сделать разрезы с таким огромным зазором",
      "Non sarai in grado di fare tagli con un divario così grande.",
      "Mit einem so großen Abstand werden Sie keine Schnitte machen können.",
      "这么大的间隙无法进行切割。",
      "No podrá realizar cortes con un espacio tan grande.",  // ES
      "Vous ne pourrez pas effectuer de coupes avec un écart aussi important.",  // FR
      "Bu kadar büyük bir boşlukla kesim yapamazsınız." };  // TR

    public static readonly string[] TooBigRibErr = {
      "It will not be possible to arrange such thick ribs",
      "Не получится расставить такие толстые ребра",
      "Non sarà possibile disporre costole così spesse",
      "Es wird nicht möglich sein, so dicke Rippen anzuordnen",
      "无法安排这么厚的肋骨。",
      "No será posible organizar nervaduras tan gruesas",  // ES
      "Il ne sera pas possible d'organiser des nervures aussi épaisses",  // FR
      "Bu kadar kalın kaburgaları düzenlemek mümkün olmayacak" };  // TR

    public static readonly string[] TooShortStepErr = {
      "With these settings, the cut slices will be too small.",
      "При таких настройках разрезанные дольки будут слишком мелкие",
      "Con queste impostazioni, le fette tagliate saranno troppo piccole.",
      "Mit diesen Einstellungen werden die geschnittenen Scheiben zu klein.",
      "使用这些设置，切片会太小。",
      "Con esta configuración, las rebanadas cortadas serán demasiado pequeñas.",  // ES
      "Avec ces paramètres, les tranches coupées seront trop petites.",  // FR
      "Bu ayarlarla, kesilen dilimler çok küçük olacak." };  // TR

    public static readonly string[] TooBigStepErr = {
      "Slicing step set too large",
      "Настроен слишком большой шаг нарезки",
      "Passo di taglio impostato troppo alto",
      "Chopping-Pitch zu hoch eingestellt",
      "切片步长设置过大",
      "Paso de corte configurado demasiado grande",  // ES
      "Pas de découpe défini trop grand",  // FR
      "Kesim adımı çok büyük ayarlanmış" };  // TR

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
      "最大长度(MA)",
      "LONgitudMáxima",                              // ES
      "LONgueurMaximale",                            // FR
      "MAKsimumUzunluk" };                           // TR

    public static readonly string[] FixStepKW = {
      "FIXedStep",
      "ФИКСированныйШаг",
      "passoFISSO",
      "FESTERschritt",
      "固定步长(FIX)",
      "PasoFIJO",                                    // ES
      "PasFIXe",                                     // FR
      "SABitAdım"};                                  // TR

    public static readonly string[] KW3point = {
      "3points",
      "3точки",
      "3punti",
      "3punkte",
      "3点",
      "3puntos",                                     // ES
      "3points",                                     // FR
      "3nokta"};                                     // TR

    public static readonly string[] EdgeKW = {
      "EDGE",
      "РЕБРО",
      "BORDO",
      "KANTE",
      "选择边缘(EDG)",
      "BORDE",                                       // ES
      "ARÊTE",                                       // FR
      "KENAR"};                                      // TR

    public static readonly string[] PlaneKW = {
      "PLANE",
      "ПЛОСКОСТЬ",
      "PIANO",
      "FLÄCHE",
      "选择平面(PLN)",
      "PLANO",                                       // ES
      "PLAN",                                        // FR
      "DÜZLEM"};                                     // TR

    public static readonly string[] Repair = {
      "Try to repair the solid using the DMAUDIT command",
      "Попробуйте отремонтировать солид командой DMAUDIT",
      "Prova a riparare il solido con il DMAUDIT",
      "Versuchen Sie, den Feststoff mit dem DMAUDIT zu reparieren",
      "尝试使用 DMAUDIT 命令修复实体",
      "Intente reparar el sólido usando el comando DMAUDIT",     // ES
      "Essayez de réparer le solide en utilisant la commande DMAUDIT",  // FR
      "DMAUDIT komutunu kullanarak katıyı onarmayı deneyin" };  // TR

    // ====================================================================================================================================
    // ==================================================  Options Box ====================================================================

    public static readonly string[] OptionsDialog = {
      "Chop command settings",
      "Настройка команды Нарезка",
      "Personalizzazione del comando Tritare",
      "Anpassen des Hacken-Befehls",
      "切片命令设置",
      "Configuración del comando Cortar",          // ES
      "Paramètres de la commande Découper",        // FR
      "Kesme komutu ayarları"};                    // TR

    public static readonly string[] StyleNameTip = {
      "The name for this chop-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля нарезки. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile chop (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Chop-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "这种样式（设置）名称。 没有在程序中使用。 只为方便选择。",
      "El nombre de este estilo de corte (conjunto de configuraciones). No se usa en el programa. Solo por conveniencia de elección.",  // ES
      "Le nom de ce style de découpe (ensemble de paramètres). Non utilisé dans le programme. Seulement pour la commodité du choix.",  // FR
      "Bu kesme stili için ad (ayarlar kümesi). Programda kullanılmaz. Sadece seçim kolaylığı için."};  // TR

    public static readonly string[] Mode = {
      "Mode",
      "Режим",
      "Modalità",
      "Modus",
      "模式",
      "Modo",                                       // ES
      "Mode",                                       // FR
      "Mod"};                                       // TR

    public static readonly string[] Step = {
      "Step",
      "Шаг нарезки",
      "Fase di taglio",
      "Schritt",
      "切割步骤",
      "Paso",                                       // ES
      "Pas",                                        // FR
      "Adım"};                                      // TR

    public static readonly string[] StartFrom = {
      "Start from",
      "Старт от",
      "Inizia da",
      "Beginne von",
      "从...开始",
      "Comenzar desde",                             // ES
      "Commencer à partir de",                      // FR
      "Başlangıç noktası"};                         // TR

    public static readonly string[] ParallelPlanes = {
      "Parallel Planes",
      "Параллельные плоскости",
      "Piani paralleli",
      "Parallele Ebenen",
      "平行面",
      "Planos paralelos",                           // ES
      "Plans parallèles",                           // FR
      "Paralel düzlemler"};                         // TR

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
        "需要平面。 您可以一次切割多个实体。",
      "Corte el sólido con muchos planos paralelos. \r\n" +
        "Plano requerido. Puede cortar muchos sólidos a la vez.",  // ES
      "Coupez le solide avec de nombreux plans parallèles. \r\n" +
        "Plan requis. Vous pouvez couper plusieurs solides à la fois.",  // FR
      "Katıyı birçok paralel düzlemle kesin. \r\n" +
        "Düzlem gereklidir. Birçok katıyı aynı anda kesebilirsiniz."};  // TR

    public static readonly string[] AlongEdge = {
      "Along Edge",
      "Вдоль ребра",
      "Lungo la costola",
      "Entlang der Rippe",
      "沿边缘",
      "A lo largo del borde",                       // ES
      "Le long du bord",                            // FR
      "Kenar boyunca"};                             // TR

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
        "在此模式下，只能切割所选边缘所属的单个实体。",
      "Organice los planos de corte perpendiculares al borde del sólido. \r\n" +
        "Se requiere especificar un borde recto o curvo y un punto para construir el plano de inicio. \r\n" +
        "En este modo, es posible cortar solo un sólido al que pertenece el borde seleccionado.",  // ES
      "Disposez les plans de coupe perpendiculaires au bord du solide. \r\n" +
        "Il est nécessaire de spécifier un bord droit ou courbe et un point pour construire le plan de départ. \r\n" +
        "Dans ce mode, il est possible de couper un seul solide auquel appartient le bord sélectionné.",  // FR
      "Kesme düzlemlerini katının kenarına dik olarak düzenleyin. \r\n" +
        "Düz veya eğri bir kenar ve başlangıç düzlemini oluşturmak için bir nokta belirtmek gerekir. \r\n" +
        "Bu modda, seçilen kenarın ait olduğu yalnızca bir katı kesmek mümkündür."};  // TR

    public static readonly string[] FixStep = {
      "Fixed step",
      "Фиксированный шаг",
      "Passo fisso",
      "Fester Schritt",
      "固定步骤",
      "Paso fijo",                                  // ES
      "Pas fixe",                                   // FR
      "Sabit adım"};                                // TR

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
        "在切割实体结束时，可能会留下多余实体。",
      "Establezca el valor exacto del espaciado de los planos de corte. \r\n" +
        "Al final del sólido, puede quedar un residuo.",  // ES
      "Définissez la valeur exacte de l'espacement des plans de coupe. \r\n" +
        "À la fin du solide, un reste peut subsister.",  // FR
      "Kesme düzlemlerinin aralığının tam değerini ayarlayın. \r\n" +
        "Katının sonunda bir kırpıntı kalabilir."};  // TR

    public static readonly string[] NumberOfPieces = {
      "Number of pieces",
      "Заданное число долек",
      "Numero di sezioni",
      "Stückzahl",
      "指定切片数",
      "Número de piezas",                           // ES
      "Nombre de pièces",                           // FR
      "Parça sayısı"};                              // TR

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
        "如果有实体的部分在给定的边缘之外，则只能保留修剪。。",
      "Divida el sólido en un número determinado de piezas. \r\n" +
        "Se calculará el paso de corte. \r\n" +
        "Los recortes solo pueden quedar si hay partes del sólido fuera del borde dado.",  // ES
      "Divisez le solide en un nombre donné de pièces. \r\n" +
        "Le pas de coupe sera calculé. \r\n" +
        "Les chutes ne peuvent rester que s'il y a des parties du solide en dehors du bord donné.",  // FR
      "Katıyı belirli sayıda parçaya bölün. \r\n" +
        "Kesim adımı hesaplanacaktır. \r\n" +
        "Kırpıntılar yalnızca katının verilen kenarın dışında parçaları varsa kalabilir."};  // TR

    public static readonly string[] NoLonger = {
      "No longer",
      "Не длиннее",
      "Non più di",
      "Nicht länger",
      "不超过",
      "No más largo que",                           // ES
      "Pas plus long que",                          // FR
      "Daha uzun değil"};                           // TR

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
        "只有在给定边缘之外存在实体部分时，才能保留饰边。",
      "Establezca el número de piezas para que las piezas no sean más largas que el valor dado. \r\n" +
        "El paso de corte se calcula y será menor o igual al especificado. \r\n" +
        "Los recortes solo pueden quedar si hay partes del sólido fuera del borde dado.",  // ES
      "Définissez le nombre de pièces de sorte que les pièces ne soient pas plus longues que la valeur donnée. \r\n" +
        "Le pas de coupe est calculé et sera inférieur ou égal à celui spécifié. \r\n" +
        "Les chutes ne peuvent rester que s'il y a des parties du solide en dehors du bord donné.",  // FR
      "Parça sayısını, parçaların verilen değerden daha uzun olmaması için ayarlayın. \r\n" +
        "Kesim adımı hesaplanır ve belirtilenden küçük veya eşit olacaktır. \r\n" +
        "Kırpıntılar yalnızca katının verilen kenarın dışında parçaları varsa kalabilir."};  // TR

    public static readonly string[] CleanRibs = {
      "Rib cleaning",
      "Чистка ребер",
      "Pulire le costole",
      "Rippenreinigung",
      "肋条清除",
      "Limpieza de nervaduras",                     // ES
      "Nettoyage des nervures",                     // FR
      "Kaburga temizleme"};                         // TR

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
        "推荐用于高度弯曲的实体。",
      "Elimine las nervaduras innecesarias que no están en contacto con el borde base. \r\n" +
        "Recomendado para bordes muy curvados.",  // ES
      "Supprimez les nervures inutiles qui ne sont pas en contact avec le bord de base. \r\n" +
        "Recommandé pour les bords fortement courbés.",  // FR
      "Taban kenarıyla temas etmeyen gereksiz kaburga parçalarını silin. \r\n" +
        "Güçlü şekilde eğilmiş katılar için önerilir."};  // TR

    public static readonly string[] Numbering = {
      "Numbering",
      "Нумеровать",
      "Dai numeri",
      "Nummerierung",
      "编号",
      "Numeración",                                 // ES
      "Numérotation",                               // FR
      "Numaralama"};                                // TR

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
         "您可以使用 A>V>C> 属性面板查看实体的名称。",
      "Cree nombres para cualquier pieza y nervadura en orden de corte.\r\n" +
        "Puede ver los nombres de los sólidos usando la Paleta de Propiedades A>V>C>.",  // ES
      "Créez des noms pour chaque pièce et nervure dans l'ordre de découpe.\r\n" +
        "Vous pouvez voir les noms des solides en utilisant la Palette de Propriétés A>V>C>.",  // FR
      "Kesim sırasına göre her parça ve kaburga için isimler oluşturun.\r\n" +
        "A>V>C> Özellik Paleti'ni kullanarak katı adlarını görebilirsiniz."};  // TR

    public static readonly string[] MakeRib = {
      "Ribs",
      "Ребра (нервюры)",
      "Nervatura",
      "Rippen",
      "肋骨",
      "Nervaduras",                                 // ES
      "Nervures",                                   // FR
      "Kaburgalar"};                                // TR

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
      "此选项可用于构建弧形吧台等弯曲结构。",
      "El sólido no solo se cortará, sino que se colocarán nervaduras en los lugares donde pasan los planos secantes.\r\n" +  // ES
      "El espesor del material de las nervaduras se establece en el campo Espesor de nervadura.\r\n" +
      "Esta opción puede ser útil para enmarcar una estructura curva como un mostrador de bar arqueado.",
      "Le solide ne sera pas seulement coupé, mais des nervures seront placées aux endroits où passent les plans sécants.\r\n" +  // FR
      "L'épaisseur du matériau des nervures est définie dans le champ Épaisseur de nervure.\r\n" +
      "Cette option peut être utile pour encadrer une structure incurvée comme un comptoir de bar arqué.",
      "Katı sadece kesilmeyecek, aynı zamanda kesit düzlemlerinin geçtiği yerlere kaburgalar yerleştirilecektir.\r\n" +  // TR
      "Kaburga malzeme kalınlığı Kaburga Kalınlığı alanında ayarlanır.\r\n" +
      "Bu seçenek, kavisli bir bar tezgahı gibi eğri bir yapıyı çerçevelemek için yararlı olabilir."};

    public static readonly string[] SaveGap = {
      "Save Gaps",
      "Сохранять зазоры",
      "Mantenere gli spazi liberi",
      "Lücken pflegen",
      "保留间距实体",
      "Guardar espacios",                            // ES
      "Enregistrer les espaces",                     // FR
      "Boşlukları kaydet"};                          // TR

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
         "在任何情况下，无论如何，这些块都不会应用步进功能，层次保持与原始体相同。",
      "Si el espacio es mayor que cero, el programa puede guardar las piezas de sólido que quedan en los espacios.\r\n" +  // ES
         "En cualquier caso, no se aplica ninguna función escalonada a estas piezas \r\n" +
        "y la capa permanece igual que la del cuerpo original.",
      "Si l'espacement est supérieur à zéro, le programme peut enregistrer les morceaux de solide restant dans les espaces.\r\n" +  // FR
         "Dans tous les cas, aucune fonction d'escalier n'est appliquée à ces pièces \r\n" +
        "et le calque reste le même que celui du corps d'origine.",
      "Boşluk sıfırdan büyükse, program boşluklarda kalan katı parçalarını kaydedebilir.\r\n" +  // TR
         "Her halükarda, bu parçalara hiçbir basamaklama işlevi uygulanmaz \r\n" +
        "ve katman orijinal gövdedekiyle aynı kalır."};

    public static readonly string[] SaveSource = {
      "Save Source",
      "Сохранять исходное",
      "Mantieni l'originale",
      "Quelle speichern",
      "保留源实体",
      "Guardar origen",                              // ES
      "Enregistrer la source",                       // FR
      "Kaynağı kaydet"};                             // TR

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
        "切片和肋骨将在其中创建。",
      "Guardar el sólido de origen en el dibujo. " +  // ES
        "Las piezas y nervaduras se crearán dentro de él.",
      "Enregistrer le solide source dans le dessin. " +  // FR
        "Les pièces et nervures seront créées à l'intérieur.",
      "Kaynak katıyı çizimde kaydedin. " +           // TR
        "Parça ve kaburgalar içinde oluşturulacaktır."};

    public static readonly string[] Stair = {
      "Stair step",
      "Ступенчатый",
      "Facendo un passo",
      "Treppenstufe",
      "阶梯状",
      "Escalón",                                     // ES
      "Marche d'escalier",                           // FR
      "Merdiven basamağı"};                          // TR

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
         "此外，它们被切割成新的实体不会超过源实体。",
      "Cuando esta opción está habilitada, el programa reemplazará las rebanadas o nervaduras cortadas con piezas planas con extremos ortogonales.\r\n" +  // ES
         "Es decir, todos los extremos inclinados se cortarán.\r\n" +
         "Además, están cortados de modo que el nuevo cuerpo nunca sobresalga del original.",
      "Lorsque cette option est activée, le programme remplacera les tranches ou nervures coupées par des pièces plates avec des extrémités orthogonales.\r\n" +  // FR
         "C'est-à-dire que toutes les extrémités inclinées seront coupées.\r\n" +
         "De plus, ils sont coupés de sorte que le nouveau corps ne dépassera jamais de l'original.",
      "Bu seçenek etkinleştirildiğinde, program kesilen dilimleri veya kaburgaları dik uçlu düz parçalarla değiştirecektir.\r\n" +  // TR
         "Yani tüm eğik uçlar kesilecektir.\r\n" +
         "Ayrıca, yeni gövdenin asla orijinalin ötesine geçmeyeceği şekilde kesilirler."};

    public static readonly string[] StepOutward = {
      "Outward",
      "Наружу",
      "Verso l'esterno",
      "Nach außen",
      "向外",
      "Hacia afuera",                                // ES
      "Vers l'extérieur",                            // FR
      "Dışa doğru"};                                 // TR

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
         "通常这些台阶是在里面做的，这样方便填补。",
      "Haga los escalones hacia afuera del sólido original, luego para limarlos. \r\n" +  // ES
        "Normalmente los escalones se hacen hacia adentro para masillarlos.",
      "Faites les marches vers l'extérieur du solide d'origine, puis pour les poncer. \r\n" +  // FR
        "Habituellement, les marches sont faites vers l'intérieur pour les mastiquer.",
      "Basamakları orijinal katının dışına doğru yapın, sonra törpüleyerek düzeltin. \r\n" +  // TR
        "Genellikle basamaklar içe doğru yapılır ki macunlanabilsinler."};

    public static readonly string[] PieceLayer = {
      "Piece layer",
      "Слой деталей",
      "Layer di dettaglio",
      "Detailebene",
      "切片层",
      "Capa de piezas",                              // ES
      "Calque de pièces",                            // FR
      "Parça katmanı"};                              // TR

    public static readonly string[] PieceLayerTip = {
      "You can enter layer name for piece or rib. \r\n" +
        "When assigning a layer, all properties will be reset to ByLayer, and the face coloring will be cleared. \r\n" +
        "Layer will created if it not exists.",
      "Слой, который будет назначен долькам/ребрам. \r\n" +
        "Можно оставить поле пустым. \r\n" +
        "Программа сама создаст слой при необходимости.",
      "Il livello da assegnare alle fette / costole.\r\n" +
        "Quando si assegna un layer, tutte le proprietà verranno reimpostate su ByLayer e la colorazione delle facce verrà cancellata.\r\n"+
        "Puoi lasciare il campo vuoto.\r\n" +
        "Se necessario, il programma creerà il livello stesso.",
      "Die Schicht, die den Scheiben/Rippen zugewiesen werden soll.\r\n" +
        "Beim Zuweisen einer Ebene werden alle Eigenschaften auf 'Nach Ebene' zurückgesetzt und die Flächenfärbung gelöscht. \r\n" +
        "Sie können das Feld leer lassen.\r\n" +
        "Das Programm erstellt die Ebene bei Bedarf selbst.",
      "要分配给切片/肋骨的层。 您可以将该字段留空。\r\n" +
        "当指定图层时，所有属性将重置为ByLayer，并且面颜色将被清除。\r\n" +
        "如有必要，程序将自行创建图层。",
      "Puede ingresar el nombre de capa para pieza o nervadura. \r\n" +  // ES
        "Al asignar una capa, todas las propiedades se restablecerán a PorCapa, y el coloreado de caras se borrará. \r\n" +
        "La capa se creará si no existe.",
      "Vous pouvez saisir le nom du calque pour la pièce ou la nervure. \r\n" +  // FR
        "Lors de l'attribution d'un calque, toutes les propriétés seront réinitialisées à ParCalque, et la coloration des faces sera effacée. \r\n" +
        "Le calque sera créé s'il n'existe pas.",
      "Parça veya kaburga için katman adı girebilirsiniz. \r\n" +  // TR
        "Bir katman atanırken, tüm özellikler KatmanaGöre'ye sıfırlanacak ve yüz renklendirmesi temizlenecektir. \r\n" +
        "Katman mevcut değilse oluşturulacaktır."};

    public static readonly string[] Specify = {
      "Specify",
      "Указать",
      "Specificare",
      "Angeben",
      "指定",
      "Especificar",                                 // ES
      "Spécifier",                                   // FR
      "Belirle"};                                    // TR

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
        "对于曲线切割，将请求第一个切割点。",
      "Comenzar a cortar desde el plano especificado. \r\n" +  // ES
        "Para corte curvo, se solicitará el punto del primer corte.",
      "Commencer à couper à partir du plan spécifié. \r\n" +  // FR
        "Pour la coupe courbe, le point de la première coupe sera demandé.",
      "Belirtilen düzlemden kesmeye başlayın. \r\n" +  // TR
        "Eğri kesim için, ilk kesimin noktası istenecektir."};

    public static readonly string[] Min = {
      "Minimum",
      "Минимум",
      "Minimo",
      "Minimum",
      "最低限度",
      "Mínimo",                                      // ES
      "Minimum",                                     // FR
      "Minimum"};                                    // TR

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
        "切割将保留在实体的远端。",
      "Comenzar a cortar desde el punto extremo del sólido detrás del plano especificado \r\n" +  // ES
        "o desde el extremo más cercano del borde especificado.\r\n" +
        "El residuo permanecerá en el extremo lejano del sólido.",
      "Commencer à couper à partir du point extrême du solide derrière le plan spécifié \r\n" +  // FR
        "ou à partir de l'extrémité la plus proche du bord spécifié.\r\n" +
        "Le reste restera à l'extrémité éloignée du solide.",
      "Belirtilen düzlemin arkasındaki katının uç noktasından \r\n" +  // TR
        "veya belirtilen kenarın en yakın ucundan kesmeye başlayın.\r\n" +
        "Kırpıntı katının uzak ucunda kalacaktır."};

    public static readonly string[] Max = {
      "Maximum",
      "Максимум",
      "Massimo",
      "Maximum",
      "最大限度",
      "Máximo",                                      // ES
      "Maximum",                                     // FR
      "Maksimum"};                                   // TR

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
        "切割将保留在实体的近端。",
      "Comenzar a cortar desde el punto extremo de la pieza frente al plano especificado \r\n" +  // ES
        "o desde el extremo lejano del borde especificado.\r\n" +
        "El residuo permanecerá en el extremo cercano del sólido.",
      "Commencer à couper à partir du point extrême de la pièce devant le plan spécifié \r\n" +  // FR
        "ou à partir de l'extrémité éloignée du bord spécifié.\r\n" +
        "Le reste restera à l'extrémité proche du solide.",
      "Belirtilen düzlemin önündeki parçanın uç noktasından \r\n" +  // TR
        "veya belirtilen kenarın uzak ucundan kesmeye başlayın.\r\n" +
        "Kırpıntı katının yakın ucunda kalacaktır."};

    public static readonly string[] Mid = {
      "Middle",
      "Середина",
      "Mezzo",
      "Mitte",
      "中间",
      "Medio",                                       // ES
      "Milieu",                                      // FR
      "Orta"};                                       // TR

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
        "切割将保留在实体的两端。",
      "Comenzar a cortar desde el medio de la pieza \r\n" +  // ES
        "o desde el punto medio del borde especificado.\r\n" +
        "El residuo permanecerá en ambos extremos del sólido.",
      "Commencer à couper à partir du milieu de la pièce \r\n" +  // FR
        "ou à partir du point médian du bord spécifié.\r\n" +
        "Le reste restera aux deux extrémités du solide.",
      "Parçanın ortasından \r\n" +  // TR
        "veya belirtilen kenarın orta noktasından kesmeye başlayın.\r\n" +
        "Kırpıntı katının her iki ucunda da kalacaktır."};

    public static readonly string[] SaveStub = {
      "Save Stubs",
      "Сохранять обрезки",
      "Salva i ritagli",
      "Ausschnitte speichern",
      "保留残余",
      "Guardar residuos",                            // ES
      "Enregistrer les restes",                      // FR
      "Kırpıntıları kaydet"};                        // TR

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
        "它们可用共切成更薄的切片。",
      "Guardar residuos al final del sólido de origen y entre nervaduras. \r\n" +  // ES
        "Se pueden usar para cortar rebanadas más delgadas.",
      "Enregistrer les restes à la fin du solide source et entre les nervures. \r\n" +  // FR
        "Ils peuvent être utilisés pour couper des tranches plus fines.",
      "Kaynak katının sonunda ve kaburgalar arasındaki kırpıntıları kaydedin. \r\n" +  // TR
        "Daha ince dilimler kesmek için kullanılabilirler."};

    public static readonly string[] StubLayer = {
      "Stub layer",
      "Слой обрезков",
      "Layer di scarto",
      "Schnittschicht",
      "残余层",
      "Capa de residuos",                            // ES
      "Calque de restes",                            // FR
      "Kırpıntı katmanı"};                           // TR

    public static readonly string[] StubLayerTip = {
      "You can enter layer name for stub-solids. \r\n" +
        "When assigning a layer, all properties will be reset to ByLayer, and the face coloring will be cleared. \r\n" +
        "Leave the field blank so that the clippings remain in the original layer.\r\n" +
        "Layer will created if it not exists.",
      "Можно назначить отдельный слой обрезкам.\r\n" +
        "При назначении слоя все свойства будут сброшены на ПоСлою, раскраска граней очищена.\r\n" +
        "Оставьте поле пустым, чтоб обрезки остались в исходном слое.\r\n" +
        "Программа сама создаст слой при необходимости.",
      "È possibile assegnare un livello separato agli scarti.\r\n" +
        "Quando si assegna un layer, tutte le proprietà verranno reimpostate su ByLayer e la colorazione delle facce verrà cancellata. \r\n" +
        "Lascia il campo vuoto per mantenere i ritagli nel livello originale.\r\n" +
        "Se necessario, il programma creerà il livello stesso.",
      "Sie können den Ausschnitten eine separate Ebene zuweisen. \r\n" +
        "Beim Zuweisen einer Ebene werden alle Eigenschaften auf 'Nach Ebene' zurückgesetzt und die Flächenfärbung gelöscht. \r\n" +
        "Lassen Sie das Feld leer, damit die Ausschnitte in der ursprünglichen Ebene verbleiben.\r\n" +
        "Das Programm erstellt die Ebene bei Bedarf selbst.",
      "您可以为残余分配一个单独的图层。将该字段留空，以便残余实体保留在原图层中。\r\n" +
        "当指定图层时，所有属性将重置为ByLayer，并且面颜色将被清除。\r\n" +
        "如果层不存在，将创建该层。",
      "Puede ingresar el nombre de capa para residuos sólidos. \r\n" +  // ES
        "Al asignar una capa, todas las propiedades se restablecerán a PorCapa, y el coloreado de caras se borrará. \r\n" +
        "Deje el campo en blanco para que los residuos permanezcan en la capa original.\r\n" +
        "La capa se creará si no existe.",
      "Vous pouvez saisir le nom du calque pour les solides de reste. \r\n" +  // FR
        "Lors de l'attribution d'un calque, toutes les propriétés seront réinitialisées à ParCalque, et la coloration des faces sera effacée. \r\n" +
        "Laissez le champ vide pour que les restes restent dans le calque d'origine.\r\n" +
        "Le calque sera créé s'il n'existe pas.",
      "Kırpıntı katıları için katman adı girebilirsiniz. \r\n" +  // TR
        "Bir katman atanırken, tüm özellikler KatmanaGöre'ye sıfırlanacak ve yüz renklendirmesi temizlenecektir. \r\n" +
        "Kırpıntıların orijinal katmanda kalması için alanı boş bırakın.\r\n" +
        "Katman mevcut değilse oluşturulacaktır."};

    public static readonly string[] Gap = {
      "Gap",
      "Зазор",
      "Gap",
      "Lücke",
      "间距",
      "Espacio",                                     // ES
      "Écart",                                       // FR
      "Boşluk"};                                     // TR

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
        "如果间隙大于零，那么切割步骤将等于切片的厚度加上这个间隙。",
      "Espesor del espacio entre rebanadas.\r\n" +  // ES
         "Puede usar este espacio para tener en cuenta el espesor de la hoja de sierra, \r\n" +
        "o para formar un marco con espacios entre las nervaduras.\r\n" +
         "Si el espacio es mayor que cero, entonces el paso de corte será igual al espesor de la rebanada más este espacio.",
      "Épaisseur de l'écart entre les tranches.\r\n" +  // FR
         "Vous pouvez utiliser cet écart pour tenir compte de l'épaisseur de la lame de scie, \r\n" +
        "ou pour former un cadre avec des espaces entre les nervures.\r\n" +
         "Si l'écart est supérieur à zéro, alors le pas de coupe sera égal à l'épaisseur de la tranche plus cet écart.",
      "Dilimler arasındaki boşluk kalınlığı.\r\n" +  // TR
         "Bu boşluğu testere bıçağı kalınlığını hesaba katmak için \r\n" +
        "veya kaburgalar arasında boşluklarla bir çerçeve oluşturmak için kullanabilirsiniz.\r\n" +
         "Boşluk sıfırdan büyükse, kesme adımı dilim kalınlığı artı bu boşluğa eşit olacaktır."};

    public static readonly string[] RibThickness = {
      "Rib thickness",
      "Толщина ребер",
      "Spessore nervature",
      "Rippendicke",
      "肋骨厚度",
      "Espesor de nervadura",                        // ES
      "Épaisseur de nervure",                        // FR
      "Kaburga kalınlığı"};                          // TR

    public static readonly string[] RibThicknessTip = {
      "Thickness of rib. The thickness should be greater than zero.",
      "Толщина ребер (нервюр). Должна быть обязательно больше 0.",
      "Lo spessore dei nervature. Deve essere maggiore di 0.",
      "Die Dicke der Rippen. Muss größer als 0 sein.",
      "肋骨的厚度。必须大于 0。",
      "Espesor de la nervadura. El espesor debe ser mayor que cero.",  // ES
      "Épaisseur de la nervure. L'épaisseur doit être supérieure à zéro.",  // FR
      "Kaburga kalınlığı. Kalınlık sıfırdan büyük olmalıdır."};  // TR

    public static readonly string[] ShowDlg = {
      "Show dialog",
      "Показ диалога",
      "Mostra il dialogo",
      "Dialog Show",
      "对话显示",
      "Mostrar diálogo",                             // ES
      "Afficher le dialogue",                        // FR
      "İletişim kutusunu göster"};                   // TR

    public static readonly string[] ShowDlgTip = {
      "Show settings-window any times command calling.",
      "Показывать диалог настроек при каждом вызове команд.",
      "Mostra la finestra di dialogo delle impostazioni ad ogni chiamata di comando.",
      "Einstellungsdialog jedes Mal anzeigen, wenn Befehle aufgerufen werden.",
      "每次调用命令时显示设置对话框。",
      "Mostrar la ventana de configuración cada vez que se llama al comando.",  // ES
      "Afficher la fenêtre de paramètres à chaque appel de commande.",  // FR
      "Komut çağrıldığında her seferinde ayarlar penceresini göster."};  // TR

    public static readonly string[] StepQuery = {
      "Request the step or number of pieces",
      "Запрашивать шаг или количество долек",
      "Richiedi la lunghezza o il numero di pezzi",
      "Fragen Sie die Länge oder Stückzahl an",
      "请求步长或片数",
      "Solicitar el paso o número de piezas",        // ES
      "Demander le pas ou le nombre de pièces",      // FR
      "Adımı veya parça sayısını iste"};             // TR

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
        "在任何情况下，如果配置了设置对话框，则不会有任何请求。",
      "¿Necesito mostrar una consulta para el paso de corte cada vez? \r\n" +  // ES
        "Dependiendo de la configuración, el programa preguntará un paso fijo, o el número de piezas, \r\n" +
        "o la longitud máxima de las piezas. \r\n" +
        "Si esta opción está desactivada, el paso se toma del estilo de corte preconfigurado. \r\n" +
        "En cualquier caso, no habrá solicitud si el diálogo de configuración está configurado.",
      "Dois-je afficher une requête pour l'étape de découpe à chaque fois? \r\n" +  // FR
        "Selon les paramètres, le programme demandera soit un pas fixe, soit le nombre de pièces, \r\n" +
        "soit la longueur maximale des pièces. \r\n" +
        "Si cette option est désactivée, le pas est pris du style de découpe préconfiguré. \r\n" +
        "Dans tous les cas, il n'y aura pas de demande si le dialogue de paramètres est configuré.",
      "Her seferinde kesim adımı için bir sorgu görüntülemem gerekiyor mu? \r\n" +  // TR
        "Ayarlara bağlı olarak, program sabit bir adım, parça sayısı, \r\n" +
        "veya parçaların maksimum uzunluğunu soracaktır. \r\n" +
        "Bu seçenek devre dışıysa, adım önceden yapılandırılmış Kesme stilinden alınır. \r\n" +
        "Her halükarda, ayarlar iletişim kutusu yapılandırılmışsa hiçbir istek olmayacaktır."};
  }
}
