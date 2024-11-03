// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Cnc Dxf Vert

namespace AVC
{
  public static class
  CncL
  {
    public static readonly string[,] CncStyleNames = {
/* 0 */ { "CNC",
        "ЧПУ",
        "CNC",
        "CNC",
        "数控" },
/* 1 */ { "Milling",
        "Фрезеровка",
        "Fresatura",
        "Fräsen",
        "铣削" },
/* 2 */ { "Milling Through/Blind",
        "Фрезеровка Насквозь/Глухая",
        "Fresatura Passante/Сieco",
        "Fräsen Hindurch/Hohle",
        "铣削/盲铣" },
/* 3 */ { "Milling Inlay",
        "Фрезеровка инкрустаций",
        "Fresatura Inlay",
        "Fräsen Inlay",
        "铣削 镶嵌"},
/* 4 */ { "Milling Biesse CNI",
        "Фрезеровка Biesse CNI",
        "Fresatura Biesse CNI",
        "Fräsen Biesse CNI",
        "铣削 Biesse CNI" },
/* 5 */ { "Milling BiesseWorks TCH",
        "Фрезеровка BiesseWorks TCH",
        "Fresatura BiesseWorks TCH",
        "Fräsen BiesseWorks TCH",
        "铣削 BiesseWorks TCH" },
/* 6 */ { "Milling Homag WoodWOP En",
        "Фрезеровка Homag WoodWOP Английский",
        "Fresatura Homag WoodWOP En",
        "Fräsen Homag WoodWOP En",
        "铣削 Homag WoodWOP En" },
/* 7 */ { "Milling Homag WoodWOP Ge",
        "Фрезеровка Homag WoodWOP Немецкий",
        "Fresatura Homag WoodWOP Ge",
        "Fräsen Homag WoodWOP Ge",
        "铣削 Homag WoodWOP Ge" },
/* 8 */ { "Milling Thermwood",
        "Фрезеровка Thermwood ",
        "Fresatura Thermwood ",
        "Fräsen Thermwood ",
        "铣削 Thermwood" },
/* 9 */ { "Laser",
        "Лазер",
        "Laser",
        "Laser",
        "激光"},
    };

    public static readonly string[] DefLayerMillOutside = {
      "Mill Outside",
      "Фрезер Наружа",
      "Fresa Fuori",
      "Fräser Out",
      "铣削 外部" };
    public static readonly string[] DefLayerMillIsland = {
      "Mill Island",
      "Фрезер Остров",
      "Fresa Isoletta",
      "Fräser Insel",
      "铣削 岛" };
    public static readonly string[] DefLayerMillDado = {
      "Mill Dado",
      "Фрезер Паз",
      "Fresa Gola",
      "Fräser Rillen",
      "铣削 槽" };
    public static readonly string[] DefLayerMillWindow = {
      "Mill Window",
      "Фрезер Окно",
      "Fresa Finestra",
      "Fräser Fenster",
      "铣削 窗口" };
    public static readonly string[] DefLayerMillPocket = {
      "Mill Pocket",
      "Фрезер Выборка",
      "Fresa Tasca",
      "Fräser Tasche",
      "铣削 口袋" };
    public static readonly string[] DefLayerMillUnder = {
      "Mill Under",
      "Фрезер Снизу",
      "Fresa Basso",
      "Fräser Unten",
      "铣削 底部" };
    public static readonly string[] DefLayerMillSwivel = {
      "Mill Swivel",
      "Фрезер Наклон",
      "Fresa Inclinata",
      "Fräser Schwenken",
      "铣削 倾斜" };
    public static readonly string[] DefLayerMillImpassable = {
      "Mill Impassable",
      "Фрезер Непроходимый",
      "Fresa Impraticabile",
      "Fräser Unpassierbar",
      "铣削 不可逾越" };

    public static readonly string[] DefLayerDrillBlind = {
      "Drill Blind",
      "Сверло Глухо",
      "Perforare Сieco",
      "Bohr Hohle",
      "钻孔 盲孔" };
    public static readonly string[] DefLayerDrillThrough = {
      "Drill Through",
      "Сверло Насквозь",
      "Perforare Passante",
      "Bohr Hindurch",
      "钻孔 通孔" };
    public static readonly string[] DefLayerDrillLateral = {
      "Drill Lateral",
      "Сверло Торц",
      "Perforare Laterale",
      "Bohr Seitlich",
      "钻孔 侧" };
    public static readonly string[] DefLayerDrillUnder = {
      "Drill Under",
      "Сверло Снизу",
      "Perforare Basso",
      "Bohr Unten",
      "钻孔 底部" };
    public static readonly string[] DefLayerDrillSwivel = {
      "Drill Swivel",
      "Сверло Наклон",
      "Perforare Inclinata",
      "Bohr Schwenken",
      "钻孔 倾斜" };

    public static readonly string[] DefLayerSawDado = {
      "Saw Dado",
      "Пила Паз",
      "Sega Gola",
      "Säge Rillen",
      "锯 槽" };
    public static readonly string[] DefLayerSawThrough = {
      "Saw Through",
      "Пила Насквозь",
      "Sega Passante",
      "Säge Hindurch",
      "锯 锯通" };
    public static readonly string[] DefLayerSawUnder = {
      "Saw Under",
      "Пила Снизу",
      "Sega Basso",
      "Säge Unten",
      "锯 底部" };
    public static readonly string[] DefLayerSawSwivelUp = {
      "Saw Swivel Upward",
      "Пила Наклон вверх",
      "Sega Inclinata Rialzo",
      "Säge Schwenken Oben",
      "锯 向上旋转" };
    public static readonly string[] DefLayerSawSwivelDown = {
      "Saw Swivel Downward",
      "Пила Наклон вниз",
      "Sega Inclinata Ribasso",
      "Säge Schwenken Abwärts",
      "锯 向下旋转" };

    public static readonly string[] DefLayerSizeRectangle = {
      "Blank",
      "Заготовка",
      "Billetta",
      "Werkstk",
      "空白的" };
    public static readonly string[] DefLayerTop = {
      "Top",
      "Верх",
      "Superiore",
      "Ober",
      "顶部" };
    public static readonly string[] DefLayerBottom = {
      "Bottom",
      "Низ",
      "Inferiore",
      "Niedriger",
      "底部" };
    public static readonly string[] DefLayerHidden = {
      "Hidden",
      "Невидимые",
      "Nascosta",
      "Verdeckt" ,
      "隐"};

    public static readonly string[] DefLayerBlind = {
      "Blind",
      "Глухая",
      "Сieco",
      "Hohle",
      "非切割加工" };
    public static readonly string[] DefLayerThrough = {
      "Through",
      "Насквозь",
      "Passante",
      "Hindurch",
      "凿孔加工" };

    public static readonly string[] InfoLayerMillOutside = {
      "Milling the outside contour of a part through a part",
      "Фрезеровка наружного контура детали насквозь детали",
      "Fresatura del contorno esterno di una parte attraverso una parte",
      "Fräsen der Außenkontur eines Teils durch ein Teil",
      "通过零件铣削零件的外轮廓"};
    public static readonly string[] InfoLayerMillIsland = {
      "Milling outside the contour, but not through the part.\r\n" +
          "Protrusions inside dado",
      "Фрезеровка снаружи контура, но не насквозь детали.\r\n" +
          "Выступы внутри выборок",
      "Fresatura all'esterno del contorno, ma non attraverso il pezzo.\r\n" +
          "Sporgenze all'interno delle scanalature",
      "Fräsen außerhalb der Kontur, aber nicht durch das Teil.\r\n" +
          "Vorsprünge in den Rillen",
      "在轮廓外铣削，但不穿过零件。\r\n" +
           "选择内部的突起" };
    public static readonly string[] InfoLayerMillDado = {
      "Milling inside the contour. Not through the part. Dadoes, grooves",
      "Фрезеровка внутри контура не насквозь. Пазы, четверти",
      "Fresatura all'interno di un contorno non passante. Scanalature, gola, fessura",
      "Fräsen innerhalb einer Kontur nicht durch (Rillen)",
      "轮廓内的铣削未通过。" };
    public static readonly string[] InfoLayerMillWindow = {
      "Milling inside a path through the part (Window)",
      "Фрезеровка внутри контура насквозь детали (Окно)",
      "Fresatura all'interno di un percorso in tutto e per tutto (Finestra)",
      "Fräsen in einem Pfad durch und durch (Fenster)",
      "在通过零件的路径内铣削（窗口）" };
    public static readonly string[] InfoLayerMillPocket = {
      "Milling inside the contour is not through,\r\n" +
          "in cases where the diameter of the cutter is not enough\r\n" +
          "and it is necessary to finish the depression by scanning or in a spiral",
      "Фрезеровка внутри контура не насквозь,\r\n" +
          "в тех случаях когда диаметра фрезы недостаточно\r\n" +
          "и требуется доделывать углубление сканированием или по спирали",
      "La fresatura all'interno del contorno non è passante,\r\n" +
          "nei casi in cui il diametro della fresa non è sufficiente ed è necessario\r\n" +
          "terminare la depressione mediante scansione o in spirale",
      "Das Fräsen innerhalb der Kontur erfolgt nicht durch,\r\n" +
          "wenn der Durchmesser des Fräsers nicht ausreicht und die Vertiefung durch Scannen\r\n" +
          "oder spiralförmig beendet werden muss",
      "轮廓内铣不透，在刀具直径不够的情况下，\r\n" +
          "需要通过扫描或螺旋来完成凹陷。" };
    public static readonly string[] InfoLayerMillUnder = {
      "Milling from the bottom of the part.\r\n " +
          "For vertical, non-through milling only.\r\n" +
          "It implies stopping the machine to turn over the part\r\n" +
          "with the continuation of processing",
      "Фрезеровка снизу детали. Только для вертикальной не сквозной фрезеровки.\r\n" +
          "Подразумевается остановка работы станка на переворот детали с продолжением обработки",
      "Fresatura dal fondo del pezzo.\r\n " +
          "Solo per fresatura verticale non passante.\r\n" +
          "Implica l'arresto della macchina per girare il pezzo\r\n" +
          "con il proseguimento della lavorazione",
      "Fräsen von der Unterseite des Teils.\r\n " +
          "Nur zum vertikalen Fräsen ohne Durchgang.\r\n" +
          "Dies bedeutet, dass die Maschine angehalten wird,\r\n" +
          "um das Teil bei fortgesetzter Verarbeitung zu drehen",
      "从零件底部铣削。\r\n " +
           "仅用于垂直、非贯穿铣削。\r\n" +
           "这意味着在继续加工的情况下停止机器以翻转零件" };
    public static readonly string[] InfoLayerMillSwivel = {
      "Milling a flat inclined surface on a 5-axis machine",
      "Фрезеровка плоской наклонной поверхности на 5и-координатном станке",
      "Fresatura di una superficie piana inclinata",
      "Fräsen einer ebenen geneigten Fläche",
      "在 5 轴机床上铣削一个平坦的斜面" };
    public static readonly string[] InfoLayerMillImpassable = {
      "Milling the dado does not work - the contour has a narrow spot, thinner than the cutter",
      "Фрезерование паза не получается - контур имеет узкое место, тоньше чем фреза",
      "La fresatura della scanalatura non funziona: il contorno ha un punto stretto, più sottile della fresa",
      "Das Fräsen der Nut funktioniert nicht - die Kontur hat eine schmale Stelle, die dünner als der Fräser ist",
      "铣削墙裙不起作用 - 轮廓有一个窄点，比刀具更薄" };

    public static readonly string[] InfoLayerDrillBlind = {
      "Blind hole drilling in Z axis",
      "Сверление глухого отверстия по оси Z",
      "Esecuzione di fori ciechi sull'asse Z.",
      "Sacklochbohren in der Z-Achse",
      "盲孔钻 Z 轴" };
    public static readonly string[] InfoLayerDrillThrough = {
      "Drilling a through hole in the Z axis",
      "Сверление сквозного отверстия по оси Z",
      "Esecuzione di un foro passante sull'asse Z.",
      "Bohren eines Durchgangslochs in der Z-Achse",
      "沿 Z 轴钻一个通孔" };
    public static readonly string[] InfoLayerDrillLateral = {
      "Drilling from the side of the part, to the end",
      "Сверление сбоку детали, в торец",
      "Foratura dal lato del pezzo, fino alla fine",
      "Bohren von der Seite des Teils bis zum Ende",
      "在零件的侧面钻孔，最后" };
    public static readonly string[] InfoLayerDrillUnder = {
      "Drilling a blind hole from the bottom of the part along the Z axis.\r\n" +
          "It is assumed that the machine stops working to turn the part over and continues machining.",
      "Сверление глухого отверстия снизу детали по оси Z.\r\n" +
          "Подразумевается остановка работы станка на переворот детали с продолжением обработки",
      "Esecuzione di un foro cieco dal fondo del pezzo lungo l'asse Z.\r\n" +
          "Si presume che la macchina smetta di lavorare per capovolgere il pezzo e continui la lavorazione.",
      "Bohren eines Sacklochs von der Unterseite des Teils entlang der Z-Achse.\r\n" +
          "Es wird davon ausgegangen, dass die Maschine nicht mehr arbeitet, um das Teil umzudrehen, und die Bearbeitung fortsetzt.",
      "从零件底部沿 Z 轴钻一个盲孔。\r\n" +
           "假设机器停止工作以翻转零件并继续加工。" };
    public static readonly string[] InfoLayerDrillSwivel = {
      "Drilling at an angle to the vertical",
      "Сверление под углом к вертикали на 5и-координатном станке",
      "Foratura ad angolo rispetto alla verticale",
      "Bohren in einem Winkel zur Vertikalen",
      "在 5 轴机床上与垂直方向成一定角度钻孔" };

    public static readonly string[] InfoLayerSaw = {
      "Sawing a straight slot|dado (not through).\r\n" +
          "The program will search for straight grooves through the entire part with a width of 1 to 2 rim thicknesses.\r\n" +
          "1 or two lines will be drawn along the axis of the disk.\r\n" +
          "The milling contour of this slot will be deleted.",
      "Пропиливание прямого паза (не насквозь).\r\n" +
          "Программа будет искать прямые пазы через всю деталь шириной от 1 до двух толщин диска.\r\n" +
          "Будут построены одна или две линии по оси диска.\r\nКонтур фрезерования этого паза будет удален",
      "Segare una fessura diritta (non attraverso).\r\n" +
          "Il programma cercherà le scanalature diritte attraverso l'intera parte con una larghezza da 1 a 2 spessori del cerchio.\r\n" +
          "Una o due linee verranno tracciate lungo l'asse del disco.\r\nIl profilo di fresatura di questa cava verrà cancellato.",
      "Sägen eines geraden Schlitzes (nicht durch).\r\n" +
          "Das Programm sucht im gesamten Teil nach geraden Rillen mit einer Breite von 1 bis 2 Felgendicken.\r\n" +
          "Ein oder zwei Linien werden entlang der Achse der Platte gezeichnet.\r\nDie Fräskontur dieses Schlitzes wird gelöscht.",
      "锯直槽|dado（不通过）。\r\n" +
           "程序将在整个零件中搜索宽度为 1 到 2 轮辋厚度的直槽。\r\n" +
           "将沿着圆盘的轴绘制 1 或 2 条线。\r\n" +
           "该槽的铣削轮廓将被删除。"};
    public static readonly string[] InfoLayerSawThrough = {
      "Sawing through a part\r\n" +
          "The program will search for linear ends around the perimeter of the part.\r\n" +
          "One line will be created in the center of the disc.\r\n" +
          "All milling contours are retained.",
      "Пропиливание насквозь детали.\r\n" +
          "Программа будет искать прямые торцы по периметру детали.\r\n" +
          "Будет создана одна линия по центру диска.\r\n" +
          "Все контуры фрезеровки сохранятся.",
      "Segare una parte.\r\n" +
          "Il programma cercherà le estremità dritte attorno al perimetro della parte.\r\n" +
          "Verrà creata una linea al centro del disco.\r\n" +
          "Tutti i profili di fresatura vengono mantenuti.",
      "Durch ein Teil sägen.\r\n" +
          "Das Programm sucht nach geraden Enden um den Umfang des Teils.\r\n" +
          "In der Mitte der Disc wird eine Zeile erstellt.\r\n" +
          "Alle Fräskonturen bleiben erhalten.",
      "锯断零件\r\n" +
           "程序将搜索零件周边的直线末端。\r\n" +
           "将在圆盘中心创建一条线。\r\n" +
           "保留所有铣削轮廓。" };
    public static readonly string[] InfoLayerSawUnder = {
      "Sawing a straight groove (not through) from the bottom of the part.\r\n" +
          "It is assumed that the machine stops working to turn over the part and continues machining",
      "Пропиливание прямого паза (не насквозь) снизу детали.\r\n " +
          "Подразумевается остановка работы станка на переворот детали с продолжением обработки",
      "Segatura di una scanalatura diritta (non passante) dal fondo del pezzo.\r\n" +
          "Si presume che la macchina smetta di funzionare per capovolgere il pezzo e continui la lavorazione",
      "Sägen einer geraden Nut (nicht durch) von der Unterseite des Teils.\r\n" +
          "Es wird davon ausgegangen, dass die Maschine nicht mehr arbeitet, um das Teil umzudrehen, und die Verarbeitung fortsetzt",
      "从零件底部锯出一条直槽（不贯穿）。\r\n" +
           "假设机器停止工作翻转零件并继续加工"};
    public static readonly string[] InfoLayerSawSwivelUp = {
      "Sawing with the disc tilted to the vertical on a 5-axis rover.\r\n" +
          "For surfaces inclined upwards.\r\n" +
          "The saw line will be drawn without offset.\r\n" +
          "Tool thickness correction required.\r\n" +
          "All milling contours are retained.",
      "Пропиливание с наклоном диска к вертикали на 5и-координатном ровере.\r\n" +
          "Для поверхностей наклоненных вверх.\r\n" +
          "Линия пила будет начерчена без сдвигов.\r\n" +
          "Требуется коррекция толщины инструмента. Все контуры фрезеровки сохранятся.",
      "Segare con il disco inclinato in verticale su un rover a 5 assi.\r\n" +
          "Per superfici inclinate verso l'alto.\r\n" +
          "La linea della sega verrà tracciata senza offset.\r\n" +
          "È necessaria la correzione dello spessore dell'utensile.\r\n" +
          "Tutti i profili di fresatura vengono mantenuti.",
      "Sägen mit vertikal geneigter Scheibe auf einem 5-Achsen-Rover.\r\n" +
          "Für nach oben geneigte Flächen.\r\n" +
          "Die Sägelinie wird ohne Versatz gezeichnet.\r\n" +
          "Korrektur der Werkzeugdicke erforderlich.\r\n" +
          "Alle Fräskonturen bleiben erhalten.",
      "在5轴上以垂直倾斜的圆盘锯片进行锯切。\r\n" +
           "对于向上倾斜的表面。\r\n" +
           "将绘制没有偏移的锯线。\r\n" +
           "需要工具厚度校正。\r\n" +
           "保留所有铣削轮廓。"};
    public static readonly string[] InfoLayerSawSwivelDown = {
      "Sawing with the disc inclined to the vertical. \r\n" +
          "For faces tilted downwards.",
      "Пропиливание с наклоном диска к вертикали. \r\n" +
          "Для поверхностей наклоненных вниз.",
      "Segatura con il disco inclinato rispetto alla verticale.\r\n" +
          "Per le superfici inclinate verso il basso.",
      "Sägen mit der Neigung der Scheibe zur vertikalen.\r\n" +
          "Für nach oben geneigte Flächen. Für nach unten geneigte Flächen.",
      "锯片垂直倾斜。 \r\n" +
           "对于向下倾斜的面。" };

    public static readonly string[] InfoLayerSizeRectangle = {
      "Conditional rectangular contour of the workpiece to the size of the dimensions of the part",
      "Условный прямоугольный контур заготовки в размер габаритов детали",
      "Contorno rettangolare condizionale del pezzo in lavorazione alla dimensione delle dimensioni della parte",
      "Bedingte rechteckige Kontur des Werkstücks auf die Größe der Abmessungen des Teils",
      "有条件的工件矩形轮廓到零件尺寸的大小" };
    public static readonly string[] InfoLayerTop = {
      "Top plane contour of the top plane near the conical end or other complex surface. For 5-axis machining",
      "Контур верхней плоскости около конического торца или другой сложной поверхности. Для пяти-координатной обработки",
      "Contorno del piano superiore vicino all'estremità rastremata. Per la lavorazione a 5 assi",
      "Kontur der oberen Ebene in der Nähe des sich verjüngenden Endes. Für 5-Achs-Bearbeitung",
      "靠近圆锥端或其他复杂曲面的顶面轮廓。 用于5轴加工" };
    public static readonly string[] InfoLayerBottom = {
      "The contour of the bottom plane near the conical end or other complex surface. For 5-axis machining",
      "Контур нижней плоскости около конического торца или другой сложной поверхности. Для пяти-координатной обработки",
      "Il contorno del piano inferiore vicino all'estremità conica. Per la lavorazione a 5 assi",
      "Die Kontur der unteren Ebene nahe dem konischen Ende. Für 5-Achs-Bearbeitung",
      "靠近圆锥端或其他复杂曲面的底面轮廓。 用于5轴加工" };
    public static readonly string[] InfoLayerOther = {
      "Other visible ribs and silhouettes of complex surfaces",
      "Прочие видимые ребра и силуэты сложных поверхностей",
      "Altre nervature visibili e sagome di superfici complesse",
      "Andere sichtbare Rippen und Silhouetten komplexer Oberflächen",
      "复杂表面的其他可见筋和轮廓" };
    public static readonly string[] InfoLayerHidden = {
      "Other invisible edges, impassable bottom dadoes and invisible silhouettes of complex surfaces",
      "Прочие невидимые ребра, непроходимые выборки снизу и невидимые силуэты сложных поверхностей",
      "Altre nervature invisibili, solchi impraticabili sotto e sagome invisibili di superfici complesse",
      "Andere unsichtbare Rippen, undurchdringliche Rillen darunter und unsichtbare Silhouetten komplexer Oberflächen",
      "其他不可见的边缘、无法通行的裙边和复杂表面的不可见轮廓" };

    public static readonly string[] CornerAsIs = {
      "As is",
      "не делать",
      "Non fare niente",
      "Tu nichts",
      "原样" };
    public static readonly string[] CornerIC = {
      "Inside corner",
      "Заход в угол",
      "Angoli Interni",
      "Innere Ecke",
      "内角" };
    public static readonly string[] CornerFillet = {
      "Fillet",
      "Скругление",
      "Raccordo",
      "Abrunden",
      "四舍五入" };

    public static readonly string[] DefDirTypes = {
      "Through;Above;Under;H_left;H_front;H_right;H_back;H_other;Swivel",
      "скв.;лиц.;тыл;торц.;торц.;торц.;торц.;торц.;накл.",
      "Attraverso;Sopra;Sotto;H sinistra;H anteriore;H destra;H indietro;H altro;Girevole",
      "Durch;Oben;Unter;H links;H vorne;H richtig;H zurück;H andere;Schwenken",
      "通过;以上;在下面;H_left;H_front;H_right;H_back;H_other;旋转"};
    public static readonly string[] DefSlope = {
      "Slope %angle%°%down%",
      "Угол %angle%°%down%",
      "Inclinazione %angle%°%down%",
      "Neigung %angle%°%down%",
      "坡 %angle%°%down%" };
    public static readonly string[] DefSlopeDownward = {
      " downward",
      " снизу",
      " dal basso",
      " von unten",
      " 向下"};
    public static readonly string[] Countersink = {
      "countersink",
      "зенковать",
      "svasatore",
      "versenken",
      "埋头孔" };

    public static readonly string[] GetDepth = {
      "Enter depth for layer name",
      "Введите глубину для имени слоя",
      "Inserisci la profondità per il nome del layer",
      "Geben Sie die Tiefe für den Layer-Namen ein",
      "输入深度以将其插入图层名称"  };
    public static readonly string[] SelectContours ={
      "Select the objects to search for the outside contour",
      "Выберите объекты для поиска наружного контура",
      "Seleziona gli oggetti per cercare il contorno esterno",
      "Wählen Sie die Objekte aus, die nach der Außenkontur gesucht werden sollen",
      "选择要搜索外轮廓的对象" };
    public static string[] SelectPolylines = {
      "\n Select polylines",
      "\n Выберите полилинии",
      "\n Selezionare polilinee",
      "\n Wählen Sie ein beliebiges Polylinien",
      "\n 选择任意折线" };
    public static string[] ProcessedPolylines = {
      "  Polylines processed: {0}. Removed nodes: {1}",
      "  Обработано полилиний: {0}. Удалено узлов: {1}",
      "  Polilinee elaborate: {0}. Nodi rimossi: {1}",
      "  Verarbeitete Polylinien: {0}. Entfernte Knoten: {1}",
      "  已处理的折线：{0}。 删除的节点：{1}" };
    public static readonly string[] Knots ={
      "  {0} isolated knots were found that can be processed individually.",
      "  Обнаружено {0} изолированных узлов, которые можно обрабатывать по отдельности.",
      "  Sono stati trovati {0} nodi isolati che possono essere elaborati singolarmente.",
      "  Es wurden {0} isolierte Knoten gefunden, die einzeln verarbeitet werden können.",
        "发现 {0} 个孤立的结，可以单独处理。" };
    public static readonly string[] SaveContours = {
      "Save contours",
      "Сохранение контуров",
      "Salvataggio dei contorni",
      "Konturen speichern",
      "轮廓保存" };
    public static readonly string[] CreatedLoops = {
      "Created loops: {0}",
      "Создано петель: {0}",
      "Ciclo creati: {0}",
      "Erstellte Schleifen: {0}",
      "创建的循环：{0}" };
    public static readonly string[] Optimization = {
      "  Optimization of contour",
      "  Оптимизация контура",
      "  Ottimizzazione del contorno",
      "  Konturoptimierung",
      "  轮廓优化" };
    public static readonly string[] Contouring = {
      "Contouring",
      "Обработка контуров",
      "Elaborazione dei contorni",
      "Konturverarbeitung",
      "轮廓" };
    public static readonly string[] NoViewport ={
      "There is not a single solid in the viewport",
      "В видовом экране нет ни одного солида",
      "La finestra No Solidus",
      "Das Ansichtsfenster enthält keinen Volumenkörper",
      "视口中没有一个实体" };
    public static readonly string[] Found = {
      "Found details {0}",
      "Найдено деталей {0}",
      "Trovati i dettagli {0}",
      "Teile gefunden {0}",
      "找到详细信息 {0}" };
    public static readonly string[] DiameterInfo ={
      "  A cutter diameter {0} is specified. The holes of such a diameter and less are considered as a drill",
      "  Задана фреза {0}. Отверстия такого диаметра и меньше рассматриваем как сверловку",
      "  L'insieme della taglierina {0}. I fori di tale diametro e meno sono considerati come un trapano",
      "  Die Mühle {0} ist angegeben. Löcher mit diesem Durchmesser und weniger gelten als Bohren",
      "  指定了刀具直径 {0}。 这种直径或更小的孔被认为是钻头" };
    public static readonly string[] BlockNotFound = {
      "The '{0}' block could not be found in this drawing.\r\n" +
        "It is also missing in the '{1}' template.\r\n" +
        "The use of this and other similar blocks will be disabled.",
      "Не удалось найти блок '{0}' в данном чертеже.\r\n" +
        "В шаблоне '{1}' он тоже отсутствует.\r\n" +
        "Использование этого и других подобных блоков будет отключено.",
      "Impossibile trovare il blocco '{0}' in questo disegno.\r\n" +
        "Manca anche nel modello '{1}'.\r\n" +
        "L'uso di questo e di altri blocchi simili sarà disabilitato.",
      "Block '{0}' in dieser Zeichnung konnte nicht gefunden werden.\r\n" +
        "In der Vorlage '{1}' fehlt sie ebenfalls.\r\n" +
        "Die Verwendung dieses und anderer ähnlicher Blöcke wird deaktiviert.",
      "在此绘图中找不到“{0}”块。\r\n" +
         "'{1}' 模板中也缺少它。\r\n" +
         "这个和其他类似的块的使用将被禁用。"};
    public static string[] Sizing = {
      "Sizing",
      "Простановка размеров",
      "Dimensionamento",
      "Bemaßung",
      "尺寸标注" };
    public static string[] NoSolid = {
      "There is not a single solid or curve",
      "Нет ни одного солида или кривой",
      "Non esiste un singolo solido o curva",
      "Es gibt keinen Volumenkörper oder eine Kurve",
      "没有单一的实体或曲线" };

    public static readonly string[] SelectDado = {
      "Select objects for dado loop: ",
      "Выберете объекты контура выборки: ",
      "Seleziona gli oggetti del contorno di selezione: ",
      "Wählen Sie die Objekte der Auswahlkontur aus: ",
      "选择选择轮廓对象：" };
    public static readonly string[] OutsideErr = {
      "Main (outside) contour of detail not found",
      "Основной (внешний) контур детали не найден",
      "Il contorno principale (esterno) della parte non è stato trovato",
      "Die Hauptkontur (Außenkontur) des Teils wurde nicht gefunden",
      "未找到零件的主（外）轮廓" };
    public static readonly string[] FewOutsideErr = {
      "Found a few outside contours of detail",
      "Найдено несколько контуров деталей",
      "Sono stati trovati diversi contorni delle parti",
      "Mehrere Teilkonturen gefunden",
      "发现多个零件轮廓" };
    public static readonly string[] CloseErr ={
      "Unable to determine the part of main (outside) contour to close this loop.\r\n" +
        "Check the points of intersection",
      "Не удалось определить часть основного (внешнего) контура, чтоб замкнуть этот контур.\r\n" +
        "Проверьте точки пересечения"        ,
      "Non è stato possibile determinare parte del circuito principale (esterno) per chiudere questo circuito.\r\n" +
        "Controlla i punti di intersezione",
      "Es war nicht möglich, einen Teil des Hauptstromkreises (externen Stromkreises) zum Schließen dieses Stromkreises zu bestimmen.\r\n" +
        "Überprüfen Sie die Schnittpunkte",
      "未能定义主（外）轮廓的一部分以关闭此轮廓。\r\n" +
         "检查交叉点"};
    public static readonly string[] NotPass ={
      "It looks like dado does not pass a given cutter!\r\n" +
        "Check it. The circuit in red.",
      "Похоже паз не проходим заданной фрезой!\r\n" +
        "Проверьте. Контур выделен красным.",
      "Sembra che la scanalatura non passi attraverso la fresa data!\r\n" +
        "Dai un'occhiata. Il contorno è evidenziato in rosso.",
      "Es sieht so aus, als würde die Nut nicht durch den gegebenen Fräser gehen!\r\n" +
        "Schau es dir an. Der Umriss ist rot hervorgehoben.",
      "使用给定的刀具似乎无法通过凹槽！\r\n" +
         "检查。轮廓以红色突出显示。" };
    public static readonly string[] CheckErr ={
      "The program can automatically check for continuity contour for milling.\r\n" +
        "Check it! The circuit in red.",
      "Программа не может автоматически проверить контур на проходимость фрезы.\r\n" +
        "Проверьте! Контур выделен красным.",
      "Il programma non può controllare automaticamente il profilo per la passabilità della taglierina.\r\n" +
        "Dai un'occhiata! Il contorno è evidenziato in rosso.",
      "Das Programm kann die Kontur nicht automatisch auf Passierbarkeit des Fräsers überprüfen.\r\n" +
        "Probieren Sie es aus! Der Umriss ist rot hervorgehoben.",
      "程序无法自动检查轮廓是否能通过刀具。\r\n" +
         "检查！轮廓以红色突出显示。" };
    public static readonly string[] TwoErr ={
      "Unacceptable to choose once more than two contours (polylines)",
      "Недопустимо выбирать более двух контуров (полилиний) сразу",
      "È inaccettabile selezionare più di due contorni (polilinee) contemporaneamente",
      "Es ist nicht akzeptabel, mehr als zwei Konturen (Polylinien) gleichzeitig auszuwählen",
      "不允许同时选择两个以上的轮廓（折线）" };
    public static readonly string[] NeedContour ={
      "Need to select 1 or 2 contour from lines, arcs or splines",
      "Надо было выбрать 1 или 2 контура из линий, дуг и сплайнов",
      "Era necessario scegliere 1 o 2 contorni da linee, archi e spline",
      "Es war notwendig, 1 oder 2 Konturen aus Linien, Bögen und Splines auszuwählen",
      "有必要从直线、圆弧和样条曲线中选择 1 或 2 个轮廓" };
    public static readonly string[] SearchOutside = {
      "Search the outside contour",
      "Поиск наружного контура",
      "Cerca il contorno esterno",
      "Suchen Sie die Außenkontur",
      "寻找外轮廓" };
    public static readonly string[] LayStyle = {
      "  LAY-style will be used: {0}",
      "  Будет использован стиль Выкладки: {0}",
      "  LAY-stile sarà usato: {0}",
      "  Der Lay-stil wird verwendet: {0}" ,
      "  将使用布局(LAY)样式：{0}"};
    public static readonly string[] CncStyle = {
      "  CNC-style will be used: {0}",
      "  Будет использован стиль ЧПУ: {0}",
      "  CNC-stile sarà usato: {0}",
      "  Der CNC-stil wird verwendet: {0}",
      "  将使用 CNC 样式：{0}" };
    public static readonly string[] DxfStyle = {
      "  DXF-style will be used: {0}",
      "  Будет использован стиль DXF: {0}",
      "  DXF-stile sarà usato: {0}",
      "  Der DXF-stil wird verwendet: {0}",
      "  将使用 DXF 样式：{0}" };
    public static readonly string[] DimStyle = {
      "  Dimensions-style will be used: {0}",
      "  Будет использован стиль размеров: {0}",
      "  Dimensioni-stile sarà usato: {0}",
      "  Dimensionaler-stil wird verwendet: {0}",
      "  将使用尺寸样式(DimDet)：{0}" };
    public static readonly string[] CornerActivated = {
      "Temporarily turned on corner processing on all contours",
      "Временно включена обработка углов на всех контурах",
      "Temporaneamente attivato l'elaborazione degli angoli su tutti i contorni",
      "Eckenbearbeitung für alle Konturen vorübergehend aktiviert",
      "暂时打开所有轮廓的拐角处理" };
    public static readonly string[] SelectFile = {
      "Select drawing files with 2D outlines",
      "Выберите файлы чертежей с 2D-контурами",
      "Selezionare quadri con contorni 2D",
      "Wählen Sie Zeichnungsdateien mit 2D-Konturen aus",
      "选择具有 2D 轮廓的工程图文件"};

    //========================================== Dialogs ==========================================================
    //public static readonly string[] LayerTemplates = {
    //  "Layer Templates",
    //  "Шаблоны слоев",
    //  "Modelli di Layer",
    //  "Layer-Vorlagen",
    //  "图层模板" };
    public static readonly string[] OptionsTitle = {
      "Contour optimization and CNC preparation",
      "Оптимизация  контуров и ЧПУ подготовка",
      "Ottimizzazione del profilo e preparazione CNC",
      "Konturoptimierung und CNC-Vorbereitung",
      "轮廓优化和 CNC 准备" };
    public static readonly string[] AddEntryPoint = {
      "Add entry point",
      "Точка входа",
      "Punto d'entrata",
      "Eingangspunkt",
      "入口点" };
    public static readonly string[] AddEntryPointTip = {
      "Add a point on the largest straight section of closed contours to allow the cutter to enter the part\r\n" +
        "(extra polyline segment).",
      "Добавить на самом большом прямом участке замкнутых контуров точку для входа фрезы в деталь \r\n" +
        "(лишний сегмент полилинии).",
      "Aggiunge un punto sulla linea più lunga di contorni chiusi per consentire alla fresa di entrare nel pezzo \r\n" +
        "(segmento di polilinea extra).",
      "Fügen Sie einen Punkt auf dem größten geraden Abschnitt geschlossener Konturen hinzu, \r\n" +
        "damit der Fräser in das Teil eintritt (ein zusätzliches Polyliniensegment).",
      "在闭合轮廓的最大直线部分上添加一个点，\r\n" +
        "以便刀具进入零件（额外的多段线段）。" };
    public static readonly string[] AllowSymbols = {
      "Allow Symbols",
      "Спецсимволы",
      "Consenti simboli",
      "Symbole zulassen",
      "允许符号" };
    public static readonly string[] AllowSymbolsTip = {
      "Allow to use symbols like ¼ ¾ ½ Ø... for conversion size to string",
      "Разрешить использовать символы типа ¼ ¾ ½ Ø ... для преобразования размера в строку",
      "Permetti di usare simboli come ¼ ¾ ½ Ø ... per le dimensioni della conversione in stringa",
      "Erlauben Sie die Verwendung von Symbolen wie ¼ ¾ ½ Ø ... \r\n" +
        "für die Konvertierung der Größe in eine Zeichenfolge",
      "允许使用 ¼ ¾ ½ Ø... 等符号将大小转换为字符串" };
    public static readonly string[] Annotate = {
      "Dimensions for NCP",
      "Размеры для NCP",
      "Dimensioni per NCP",
      "Abmessungen für NCP",
      "NCP 的尺寸" };
    public static readonly string[] AnnotateTip = {
      "The NC Prepare command will place dimensions and leaders on the parts.",
      "Команда NCPrepare будет расставлять размеры и выноски на деталях.",
      "NCPrepare posizionerà quote e didascalie sulle parti.",
      "Das NCPrepare-Team platziert Bemaßungen und Führungen auf den Teilen.",
      "NCPrepare 程序将在零件上放置尺寸和引线。" };
    public static readonly string[] CloseArcs = {
      "Close arcs to circles",
      "Замыкать дуги в круг",
      "Chiudi gli archi in cerchi",
      "Bögen zu einem Kreis schließen",
      "将圆弧闭合成一个圆" };
    public static readonly string[] CloseArcsTip = {
      "Transform almost closed arcs in a circle. \r\n" +
        "This is useful when there are round pocket on the edge of the detail. \r\n" +
        "This option allows you to immediately close the loop of pocket (arc) \r\n" +
        "in full circle without using the Dado Loop(DDL) command.",
      "Превращать почти замкнутые дуги в окружности. \r\n" +
        "Полезно, когда есть круглые выборки на краю детали. \r\n" +
        "Данная опция позволит сразу замкнуть контур выборки (дугу) \r\n" +
        "в полный круг без использования команды Контур Выборки (DDL).",
      "Trasforma gli archi quasi chiusi in un cerchio. \r\n" +
        "Questo è utile quando c'è una tasca rotonda sul bordo della geometria. \r\n" +
        "Questa opzione ti consente di chiudere immediatamente il ciclo della tasca (arco) \r\n" +
        "in cerchio completo senza usare il comando Dado Loop (DDL).",
      "Verwandeln Sie fast geschlossene Bögen in Kreise. \r\n" +
        "Nützlich bei runden Schnitten an der Kante eines Teils. \r\n" +
        "Mit dieser Option können Sie die Auswahlkontur (Bogen) \r\n" +
        "sofort zu einem vollständigen Kreis schließen, \r\n" +
        "ohne den Befehl Auswahlkontur (DDL) zu verwenden.",
      "将几乎闭合的圆弧变成圆形。 \r\n" +
        "当零件边缘有圆形切口时很有用。 \r\n" +
        "此选项允许您在不使用选择轮廓 (DDL) \r\n" +
        "命令的情况下立即将选择轮廓（圆弧）闭合成一个完整的圆。" };
    public static readonly string[] CloseLateral = {
      "Close the lateral drilling into a rectangle.",
      "Замыкать торцевое сверление в прямоугольник",
      "Chiudere la foratura laterale in un rettangolo.",
      "Stirnlochbohren in ein Rechteck schließen",
      "封闭面钻孔成矩形" };
    public static readonly string[] CloseLateralTip = {
      "Close the lateral drilling contour into a rectangle. \r\n" +
        "Usually a U-shaped contour is sufficient. \r\n" +
        "If this option is enabled, \r\n" +
        "lateral drills will not turn into flat circles in Pseudo 3d mode, \r\n" +
        "but will remain rectangles.",
      "Замыкать контур торцевого сверления в прямоугольник. \r\n" +
        "Обычно достаточно П-образного контура. \r\n" +
        "Если включить опцию, то торцевые сверления не превратятся в развернутые окружности в режиме Псевдо-3d, \r\n" +
        "а останутся прямоугольниками.",
      "Chiudere il contorno di foratura frontale in un rettangolo. \r\n" +
        "Di solito è sufficiente un contorno a forma di U. \r\n" +
        "Se questa opzione è abilitata, \r\n" +
        "i trapani frontali non si trasformeranno in cerchi piatti in modalità Pseudo 3d, \r\n" +
        "ma rimarranno rettangoli.",
      "Schließen Sie die Planbohrkontur zu einem Rechteck. \r\n" +
        "Meist reicht eine U-förmige Kontur aus. \r\n" +
        "Wenn diese Option aktiviert ist, werden Stirnbohrungen im Pseudo-3D-Modus nicht zu flachen Kreisen, \r\n" +
        "sondern bleiben Rechtecke.",
      "将面钻孔轮廓闭合成一个矩形。 \r\n" +
        "通常，U 形轮廓就足够了。 \r\n" +
        "如果启用此选项，在 Pseudo-3d 模式下，面钻不会变成平面圆，而是保持矩形。" };
    public static readonly string[] CircleSwivelDrill = {
      "Replace the contours of swivel drilling with a circle",
      "Заменять контуры наклонного сверления на окружность",
      "Sostituisci i contorni della perforazione inclinata con un cerchio",
      "Ersetzen Sie die Konturen des Schrägbohrens durch einen Kreis",
      "将斜钻孔的轮廓替换为圆" };
    public static readonly string[] CircleSwivelDrillTip = {
      "A flatshot from a swivel (incline) drill looks like several ellipses.\r\n " +
        "But Biesse bSolid requires that one circle be drawn.",
      "Слепок с повернутого (наклонного) сверления выглядит как несколько эллипсов.\r\n " +
        "Но Biesse bSolid требует, чтоб была начерчена одна окружность.",
      "Un colpo piatto da un trapano girevole (inclinato) assomiglia a diverse ellissi.\r\n " +
        "Ma Biesse bSolid richiede che venga disegnato un cerchio.",
      "Ein Flachschuss einer Schwenkbohrmaschine (Schrägbohrmaschine) sieht aus wie mehrere Ellipsen.\r\n " +
        "Biesse bSolid erfordert jedoch, dass ein Kreis gezeichnet wird.",
      "旋转（倾斜）钻头的平钻看起来像几个椭圆形。但 Biesse bSolid 要求绘制一个圆。" };
    public static readonly string[] ConsiderDiam = {
      "Consider cutter diameter",
      "Учитывать диаметр",
      "Considerare diametro",
      "Durchmesser berücksichtigen",
      "考虑直径" };
    public static readonly string[] ConsiderDiamTip = {
      "The cutter diameter is taken into account.\r\n" +
        "The specified fillet or cornering will be made.\r\n" +
        "Dado loops will be expand on the cutter diameter.\r\n" +
        "Drill and Pocket layer can be used.",
      "Учитывать диаметр фрезы в контурах и именах слоев. \r\n" +
        "Расширять пазы и делать обрабатывать углы контуров под круглую фрезу. \r\n" +
        "Задействовать слои Сверлений и слой Выборка.",
      "Espande le scanalature e calcola il passaggio fresa negli angoli interni. \r\n" +
        "Interessa i comandi DDL e OSL.",
      "Fräserdurchmesser in Konturen und Schichtnamen einbeziehen. \r\n" +
        "Erweitern Sie die Nuten und bearbeiten Sie die Ecken der Konturen für einen Rundfräser. \r\n" +
        "Aktivieren Sie die Drilling-Layer und die Pocket-Layer.",
      "在轮廓和图层名称中包括刀具直径。 扩槽并加工圆刀的轮廓角。 启用钻孔图层和口袋图层。" };
    public static readonly string[] DelSources = {
      "Delete sources",
      "Удалить исходные",
      "Elimina gli oggetti originali",
      "Original löschen",
      "删除原件" };
    public static readonly string[] DelSourcesTip = {
      "Delete original objects (curves, polylines, solids).\r\n" +
        "If you disable the option, then the processed polyline will be superimposed on the original curve or the original solid.",
      "Удалять исходные объекты (кривые, полилинии, солиды). \r\n" +
        "Если отключить опцию, то обработанная полилиния наложится на исходную кривую или исходный солид.",
      "Elimina gli oggetti originali (curve, polilinee, solidi). \r\n" +
        "Se si disabilita l'opzione, la polilinea elaborata verrà sovrapposta alla curva originale o al solido originale.",
      "Löschen Sie Originalobjekte (Kurven, Polylinien, Körper). \r\n" +
        "Wenn Sie die Option deaktivieren, wird die bearbeitete Polylinie der ursprünglichen Kurve \r\n" +
        "oder dem ursprünglichen Volumenkörper überlagert.",
      "删除原始对象（曲线、多段线、实体）。 \r\n" +
        "如果禁用该选项，则处理后的多段线将叠加在原始曲线或原始实体上。" };
    public static readonly string[] DepthToThickness = {
      "Pseudo 3d",
      "Псевдо 3D",
      "Pseudo 3d",
      "Pseudo-3D",
      "伪 3D" };
    public static readonly string[] DepthToThicknessTip = {
      "Write the depth to the polyline|circle property Thickness.\r\n" +
        "Draw lateral holes as rotated circles (if Close Lateral is not checked).\r\n" +
        "Move down the dadoes and drills from below.",
      "Записать глубину фрезеровки в свойство полилинии Толщина (Thickness). \r\n" +
        "Начертить торцевые отверстия, как развернутые окружности (если только не включено замыкание их в прямоугольник) \r\n" +
        "Сдвинуть вниз пазы и сверления снизу детали.",
      "Scrive la profondità di fresatura sulla proprietà della polilinea Spessore (Thickness) \r\n" +
        "Disegna i fori laterali come cerchi aperti. \r\n" +
        "Spostare le scanalature e i trapani verso il basso.",
      "Schreiben Sie die Frästiefe in die Eigenschaft Dicke der Polylinie. \r\n" +
        "Zeichnen Sie Endlöcher als erweiterte Kreise (es sei denn, das Schließen zu einem Rechteck ist aktiviert). \r\n" +
        "Bewegen Sie die Schlitze und Bohrer von der Unterseite des Teils nach unten.",
      "将铣削深度写入折线的厚度属性。 \r\n" +
        "将端孔绘制为扩展圆（除非启用封闭到矩形） 向下移动槽并从零件底部钻孔。" };
    public static readonly string[] DotTip = {
      "Replace the decimal point in the depth and diameter of this symbol.\r\n" +
        "You can use a comma, dot, or any letter.",
      "Заменять десятичную запятую на этот символ",
      "Sostituire il punto decimale nella profondità e nel diametro di questo simbolo.",
      "Dezimalpunkt durch dieses Zeichen ersetzen",
      "用这个字符替换小数点" };
    public static readonly string[] DrillThin = {
      "Drill thin holes",
      "Сверлить тонкие",
      "Praticare fori sottili",
      "Dünne Löcher bohren",
      "钻细孔" };
    public static readonly string[] DrillThinTip = {
      "Use drilling for all circles smaller than the milling cutter diameter.",
      "Использовать сверление для всех окружностей, диаметром менее диаметра фрезы.",
      "Utilizzare la perforazione per tutti i cerchi più piccoli del diametro della fresa.",
      "Verwenden Sie das Bohren für alle Kreise mit einem Durchmesser, \r\n" +
        "der kleiner ist als der Durchmesser des Fräsers.",
      "对所有直径小于刀具直径的圆进行钻孔。" };
    public static readonly string[] ExpandDado = {
      "Expand edge dadoes",
      "Расширять четверти",
      "Espandi i solchi",
      "Viertel erweitern",
      "扩大边界" };
    public static readonly string[] ExpandDadoTip = {
      "Expand the dado contour to the outside of the part, \r\n" +
        "if the cutter does not pass. \r\n" +
        "It will also be made output arcs of the cutter outside the detail.",
      "Расширять контуры выборок на краю деталей (четвертей) наружу детали, \r\n" +
        "если не проходит фреза. \r\n" +
        "Так же будут сделаны дуги выхода фрезы наружу детали.",
      "Espandi i contorni della scanalatura all'esterno della parte se la taglierina non passa. \r\n" +
        "Verranno anche realizzate uscite della taglierina fuori dai dettagli.",
      "Erweitern Sie die Konturen der Schnitte an der Kante der Teile (Viertel) außerhalb des Teils, \r\n" +
        "wenn der Fräser nicht durchgeht. \r\n" +
        "Die Bögen des Austritts des Fräsers zur Außenseite des Teils werden ebenfalls hergestellt.",
      "如果刀具未通过，则将零件（四分之一）边缘上的切口轮廓向外扩展。 \r\n" +
        "刀具出口到零件外部的圆弧也将被制作出来。" };
    public static readonly string[] ExpandDadoEdge = {
      "Entire outer contour",
      "Весь наружный контур",
      "Tutto il contorno esterno",
      "Gesamte Außenkontur",
      "整个外轮廓" };
    public static readonly string[] ExpandDadoEdgeTip = {
      "The entire contour of the dado along the edge of the part must be moved outward by half the diameter of the cutter \r\n" +
        "so that the cutter does not fray the material.",
      "Весь контур четверти по краю детали надо отодвинуть наружу на пол диаметра фрезы, \r\n" +
        "чтоб фреза не лохматила материал.",
      "L'intero contorno del dado lungo il bordo del pezzo deve essere spostato verso l'esterno di metà del diametro della fresa, \r\n" +
        "in modo che quest'ultima non sfilacci il materiale.",
      "Die gesamte Kontur der Nut entlang der Teilekante muss um den halben Fräserdurchmesser nach außen verschoben werden, \r\n" +
        "damit der Fräser das Material nicht ausfranst.",
      "沿零件边缘的榫眼的整个轮廓必须向外移动刀具直径的一半，以使刀具不会磨损材料。" };
    public static readonly string[] FilletBothSides = {
      "Fillet on both sides",
      "С двух сторон",
      "Entrambe le parti",
      "Von zwei Seiten",
      "从两个方面" };
    public static readonly string[] FilletBothSidesTip = {
      "Create Fillet on both sides of the contours, and not just on the milling side.\r\n" +
        "Does not work with Inside corner.On an not closed polyline, \r\n" +
        "are always fillet on both sides.",
      "Создавать скругление с обеих сторон контуров, \r\n" +
        "а не только со стороны фрезерования. Не работает с заходами в угол. \r\n" +
        "На незамкнутой полилинии всегда делаются скругления с обоих сторон.",
      "Crea raccordo su entrambi i lati dei contorni, \r\n" +
        "e non solo dal lato fresato. Non funziona con Inside corner. \r\n" +
        "Su una polilinea non chiusa, vengono sempre raccordati entrambi i lati.",
      "Erstellen Sie Verrundungen auf beiden Seiten von Konturen, \r\n" +
        "nicht nur auf der Frässeite. Funktioniert nicht mit Eckeinstiegen. \r\n" +
        "Auf einer offenen Polylinie werden Verrundungen immer auf beiden Seiten erstellt.",
      "在轮廓的两侧创建圆角，而不仅仅是在铣削侧。 \r\n" +
        "不适用于角入口。 \r\n" +
        "在开放的多段线上，始终在两侧制作圆角。" };
    public static readonly string[] LettersTip = {
      "5 characters to indicate the direction of lateral drilling: \r\n" +
        "left, front, right, back and bottom.\r\n" +
        "Used in %dir% substitution.",
      "5 символов для обозначения направлений торцевого сверления: \r\n" +
        "слева, спереди, справа, сзади и снизу. \r\n" +
        "Используется в подстановке %dir%.",
      "5 caratteri per indicare la direzione della perforazione laterale: \r\n" +
        "sinistra, anteriore, destra, posteriore e inferiore.",
      "5 Symbole für Stirnbohrrichtungen: \r\n" +
        "links, vorne, rechts, hinten und unten. \r\n" +
        "Wird in %dir%-Ersetzung verwendet.",
      "面钻孔方向的 5 个符号：\r\n" +
        "左、前、右、后和下。 \r\n" +
        "用于 %dir% 替换。" };
    public static readonly string[] MillModeTip = {
      "Processing (milling) mode. \r\n" +
        "This text can be used in the %millmode% substitution in all layer names.",
      "Режим обработки (фрезеровки). \r\n" +
        "Этот текст можно использовать в подстановке %millmode% во всех именах слоев.",
      "Modalità di lavorazione (fresatura). \r\n" +
        "Questo testo può essere utilizzato nella sostituzione %millmode% in tutti i nomi dei layer.",
      "Bearbeitungsmodus (Fräsen). \r\n" +
        "Dieser Text kann in der %millmode%-Ersetzung in allen Layernamen verwendet werden.",
      "加工方式（铣削）。 \r\n" +
        "此文本可用于所有图层名称中的 %millmode% 替换。" };
    public static readonly string[] MillRight = {
      "Milling on the right",
      "Фреза справа",
      "Fresatura sulla destra",
      "Fräser rechts",
      "铣刀右" };
    public static readonly string[] MillRightTip = {
      "Turn the outer contours counterclockwise, and the inner contours clockwise.\r\n" +
        "In this case, the cutter should be located to the right of the contour,\r\n" +
        "if you look along the movement.\r\n" +
        "If the spindle rotates clockwise,\r\n" +
        "then you will get a countercurrent to the cutting edge and a decrease in the fibrousness of the cut.\r\n" +
        "If you clear the checkboxes, the contours will be reversed (outer clockwise).",
      "Разворачивать наружные контуры против часовой стрелки, а внутренние - по часовой. \r\n" +
        "В этом случае фреза должна находится справа от контура, если смотреть вдоль движения. \r\n" +
        "Если шпиндель вращается по часовой стрелке, то вы получите противоход режущей поверхности \r\n" +
        "и уменьшение волокнистости реза. \r\n" +
        "Если сбросить флажок, то контуры будут развернуты наоборот - для фрезеровки слева от контура.",
      "Ruota i contorni esterni in senso antiorario, e i contorni interni in senso orario. \r\n" +
        "In questo caso, la taglierina deve essere posizionata a destra del contorno, \r\n" +
        "se guardi lungo il movimento. \r\n" +
        "Se il mandrino ruota in senso orario, \r\n" +
        "quindi otterrai una controcorrente al limite e una diminuzione della fibrosità del taglio. \r\n" +
        "Se si deselezionano le caselle di controllo, \r\n" +
        "i contorni verranno invertiti (esterno in senso orario).",
      "Erweitern Sie die äußeren Konturen gegen den Uhrzeigersinn und die inneren im Uhrzeigersinn. \r\n" +
        "In diesem Fall sollte der Fräser entlang der Bewegung gesehen rechts von der Kontur stehen. \r\n" +
        "Wenn sich die Spindel im Uhrzeigersinn dreht, \r\n" +
        "erhalten Sie ein Spiel der Schneidfläche und eine Abnahme der Schnittfaser. \r\n" +
        "Wenn Sie das Kontrollkästchen deaktivieren, \r\n" +
        "werden die Konturen umgekehrt - für das Fräsen links von der Kontur.",
      "逆时针展开外轮廓，顺时针展开内轮廓。 \r\n" +
        "在这种情况下，当沿运动方向观察时，刀具应位于轮廓的右侧。 \r\n" +
        "如果主轴顺时针旋转，那么您将获得切割表面的齿隙和切割的纤维减少。 \r\n" +
        "如果取消选中该框，则轮廓将反转 - 铣削到轮廓的左侧。" };
    public static readonly string[] MillToolTip = {
      "The name or number of the tool (cutter) as it is named in the CNC machine. \r\n" +
        "This name can be used in the %milltool% substitution in all milling layer names. \r\n" +
        "Use the substitution so as not to change the names of all layers when replacing the tool. \r\n" +
        "The program will use this name only if the tool name is not specified in the material properties of the part.",
      "Имя или номер инструмента (фрезы), как он назван в станке ЧПУ. \r\n" +
        "Это имя можно использовать в подстановке %milltool% во всех именах слоев.\r\n" +
        "Используйте подстановку, чтоб не менять имена всех слоев при замене фрезы.\r\n" +
        "Программа будет использовать это имя, только если не задано имя инструмента в свойствах материала детали.",
      "Il nome o il numero dell'utensile (taglierina) così come è denominato nella macchina CNC. \r\n" +
        "Questo nome può essere utilizzato nella sostituzione %milltool% in tutti i nomi dei livelli (layer) di fresatura.\r\n" +
        "Utilizzare la sostituzione in modo da non modificare \r\n" +
        "i nomi di tutti i livelli quando si sostituisce lo strumento. \r\n" +
        "Il programma utilizzerà questo nome solo se il nome dell'utensile non è specificato nelle proprietà \r\n" +
        "del materiale della parte.",
      "Der Name oder die Nummer des Werkzeugs (Fräsers), \r\n" +
        "wie es in der CNC-Maschine genannt wird. \r\n" +
        "Dieser Name kann in der %milltool%-Ersetzung in allen Schichtnamen verwendet werden. \r\n" +
        "Verwenden Sie die Ersetzung, damit sich die Namen aller Schichten beim Wechseln des Fräsers nicht ändern. \r\n" +
        "Das Programm verwendet diesen Namen nur, \r\n" +
        "wenn der Werkzeugname nicht in der angegeben ist Materialeigenschaften des Teils.",
      "在 CNC 机床中命名的工具（刀具）的名称或编号。 \r\n" +
        "此名称可用于所有层名称的 %milltool% 替换。\r\n" +
        "使用此替换，以便在更改刀具时所有层的名称不会改变。\r\n" +
        "只有在未指定刀具名称时，程序才会使用此名称零件材料属性。" };
    public static readonly string[] MultiplierTip = {
      "Diameter and depth will be multiplied by this number before substituting in the layer name. \r\n" +
        "This setting is not used in the Drill Table. ",
      "Диаметр и глубина будут умножены на эту цифру перед подстановкой в имя слоя. \r\n" +
        "Используется в контурах для ЧПУ Biessa, так как bSolid не понимает десятичной запятой. \r\n" +
        "Эта настройка не используется в Таблице Сверлений.",
      "Il diametro e la profondità verranno moltiplicati per questo numero prima di essere sostituiti nel nome del layer. \r\n" +
        "Utilizzato nei contorni per i CNC Biessa, poiché bSolid non comprende il punto decimale. \r\n" +
        "Questa impostazione non viene utilizzata nella Tabella di Foratura.",
      "Durchmesser und Tiefe werden mit dieser Zahl multipliziert, bevor sie in den Schichtnamen eingesetzt werden. \r\n" +
        "Wird in Biessa CNC-Schleifen verwendet, da bSolid den Dezimalpunkt nicht versteht. \r\n" +
        "Diese Einstellung wird in der Bohrtabelle nicht verwendet.",
      "在代入图层名称之前，直径和深度将乘以该数字。 \r\n" +
        "在 Biessa CNC 循环中使用，因为 bSolid 不理解小数点。 \r\n" +
        "钻孔表中不使用此设置。" };
    public static readonly string[] NotDrillCircle = {
      "Use circles",
      "Использовать окружности",
      "Usa cerchi non per trapanare",
      "Verwenden Sie Kreise",
      "使用圆圈" };
    public static readonly string[] NotDrillCircleTip = {
      "Create circles for round outside and inside contours even when the diameter is not in the drill bits list. \r\n" +
        "The problem with circles is that they have no traversing direction and the position of the cutter can be wrong. \r\n" +
        "It is recommended to disable this option and then the program will draw a polyline of two arcs \r\n" +
        "and keep the correct milling direction.",
      "Создавать окружности для круглых внешних и внутренних контуров, даже когда диаметр отсутствует в списке свёрел. \r\n" +
        "Проблема окружностей в том, что у них нет направления обхода, \r\n" +
        "и положение фрезы может быть ошибочным. \r\n" +
        "Рекомендуется отключать эту опцию и тогда программа нарисует полилинию из двух дуг \r\n" +
        "и сохранит правильное направление фрезеровки.",
      "Creare cerchi per arrotondare i contorni esterni e interni anche quando il diametro non è nell'elenco di foratura. \r\n" +
        "Il problema con i cerchi è che non hanno direzione di movimento e la posizione della fresa può essere sbagliata. \r\n" +
        "Si consiglia di disabilitare questa opzione e quindi il programma disegnerà \r\n" +
        "una polilinea di due archi e manterrà la corretta direzione di fresatura.",
      "Erstellen Sie Kreise für runde Außen- und Innenkonturen, \r\n" +
        "auch wenn der Durchmesser nicht in der Liste der Bohrer steht. \r\n" +
        "Das Problem bei Kreisen ist, dass sie keine Bewegungsrichtung haben \r\n" +
        "und die Position des Schneidwerkzeugs fehlerhaft sein kann. \r\n" +
        "Es wird empfohlen, diese Option zu deaktivieren, \r\n" +
        "dann zeichnet das Programm eine Polylinie aus zwei Bögen und behält die richtige Fräsrichtung bei.",
      "为圆形外轮廓和内轮廓创建圆，即使直径不在钻孔列表中。 \r\n" +
        "圆的问题在于它们没有遍历方向，并且刀具的位置可能是错误的。 \r\n" +
        "建议禁用此选项，然后程序将绘制两条圆弧的折线并保持正确的铣削方向。" };
    public static readonly string[] OutsideCornersTip = {
      "Cut Inside Corners or make a Fillet on the corners of the outer contour of the detail.",
      "Делать дугу захода фрезы в угол или делать скругление углов на наружном контуре детали.",
      "Taglia Angoli Interni o crea un Raccordo sugli angoli dei contorni esterni del dettaglio.",
      "Machen Sie einen Bogen des Fräsereintritts in eine Ecke oder runden Sie die Ecken an der Außenkontur eines Teils ab.",
      "使刀具进入角的圆弧或在零件的外轮廓上圆角。" };
    public static readonly string[] PocketCornersTip = {
      "Cut Inside Corners or make a Fillet on all blind internal contours of the detail \r\n" +
        "(dadoes, blind holes, pockets).",
      "Делать дугу захода фрезы в угол или делать скругление углов на всех внутренних глухих контурах \r\n" +
        "(выборках, четвертях и пазах)",
      "Taglia Angoli Interni o crea un Raccordo su tutti i contorni interni ciechi del dettaglio \r\n" +
        "(fori ciechi, tasche).",
      "An allen inneren Blindkonturen (Proben, Viertel und Nuten) \r\n" +
        "einen bogenförmigen Fräsereintritt in eine Ecke ausführen oder Ecken verrunden",
      "在拐角处切入圆弧或在所有内部盲轮廓（样品、四分之一和凹槽）上圆角" };
    public static readonly string[] ReplaceNonVertDrill = {
      "Other drilling blocks",
      "Блоки др. сверлений:",
      "Blocchi di perforazione:",
      "Blöcke anderer Bohrungen:",
      "其他钻孔块：" };
    public static readonly string[] ReplaceNonVertDrillTip = {
      "Replace hidden contours of the lateral, swivel and under drills with special blocks.\r\n" +
        "The replacement is in the model, not on the sheet.",
      "Заменить невидимые контуры сверления на специальные блоки. \r\n" +
        "Для торцевых (горизонтальных), нижних и наклонных сверлений. \r\n" +
        "Замена в модели, а не на листе.",
      "Sostituisci i profili di perforazione invisibili con blocchi speciali.\r\n" +
        "Per foratura frontale (orizzontale), inferiore e inclinata.\r\n" +
        "La sostituzione è nel modello, non sul foglio.",
      "Ersetzen Sie unsichtbare Bohrkonturen durch spezielle Blöcke. \r\n" +
        "Für Stirn- (horizontal), Boden- und Schrägbohrungen. \r\n" +
        "Der Ersatz befindet sich im Modell, nicht auf dem Blatt.",
      "用特殊块替换不可见的钻孔轮廓。 \r\n" +
        "适用于工作面（水平）、底部和倾斜钻孔。 \r\n" +
        "替换是在模型中，而不是在工作表上。" };
    public static readonly string[] SawModeTip = {
      "Processing (sawing) mode. \r\n" +
        "This text can be used in the %sawmode% substitution in all layer names.",
      "Режим обработки (напилки). \r\n" +
        "Этот текст можно использовать в подстановке %sawmode% во всех именах слоев.",
      "Modalità di lavorazione (taglio). \r\n" +
        "Questo testo può essere utilizzato nella sostituzione %sawmode% in tutti i nomi dei layer.",
      "Bearbeitungsmodus (Sägen). \r\n" +
        "Dieser Text kann in der %sawmode%-Ersetzung in allen Ebenennamen verwendet werden.",
      "加工方式（锯切）。 \r\n" +
        "此文本可用于所有图层名称的 %sawmode% 替换。" };
    public static readonly string[] SawToolTip = {
      "The name or number of the tool (saw disk) as it is named in the CNC machine. \r\n" +
        "This name can be used in the %sawtool% substitution in all layer names. \r\n" +
        "Use the substitution so as not to change the names of all layers when replacing the tool. \r\n" +
        "The program will use this name only if the tool name is not specified in the material properties of the part.",
      "Имя или номер инструмента (диска), как он назван в станке ЧПУ. \r\n" +
        "Это имя можно использовать в подстановке %sawtool% во всех именах слоев. \r\n" +
        "Используйте подстановку, чтоб не менять имена всех слоев при замене диска. \r\n" +
        "Программа будет использовать это имя, только если не задано имя инструмента в свойствах материала детали.",
      "Il nome o il numero dell'utensile (disco sega) così come viene denominato nella macchina CNC. \r\n" +
        "Questo nome può essere utilizzato nella sostituzione %sawtool% in tutti i nomi di layer. \r\n" +
        "Utilizzare la sostituzione in modo da non modificare i nomi di tutti i livelli quando si sostituisce lo strumento. \r\n" +
        "Il programma utilizzerà questo nome solo \r\n" +
        "se il nome dell'utensile non è specificato nelle proprietà del materiale della parte.",
      "Der Name oder die Nummer des Werkzeugs (Diskette), wie es in der CNC-Maschine benannt ist. \r\n" +
        "Dieser Name kann in der %sawtool%-Ersetzung in allen Ebenennamen verwendet werden. \r\n" +
        "Verwenden Sie die Substitution, damit Sie beim Ersetzen einer Festplatte nicht die Namen aller Layer ändern. \r\n" +
        "Das Programm verwendet diesen Namen nur, wenn in den Materialeigenschaften des Teils kein Werkzeugname angegeben ist.",
      "在 CNC 机床中命名的工具（磁盘）的名称或编号。 \r\n" +
        "此名称可用于所有图层名称中的 %sawtool% 替换。 \r\n" +
        "使用替换，这样您在更换磁盘时就不会更改所有层的名称。 \r\n" +
        "仅当零件的材料属性中未指定工具名称时，程序才会使用此名称。" };
    public static readonly string[] SetTip = {
      "CNC style (Set of settings). The key and the name. \r\n" +
        "The key is assigned automatically as a digit from 1 to 9 and is used to quickly switch style from the console. \r\n" +
        "You can change the name.",
      "Стиль ЧПУ (набор настроек). Ключ и имя. \r\n" +
        "Ключ назначается автоматически в виде цифры от 1 до 9 \r\n" +
        "и используется для быстрого переключения стиля из командной строки. \r\n" +
        "Вы можете изменить имя.",
      "Stile CNC (set di impostazioni). La chiave e il nome. \r\n" +
        "Il tasto viene assegnato automaticamente con una cifra da 1 a 9 \r\n" +
        "ed è usato per cambiare rapidamente stile dalla console. \r\n" +
        "Puoi cambiare il nome.",
      "CNC-Stil (Satz von Einstellungen). Schlüssel und Name. \r\n" +
        "Die Taste wird automatisch als Zahl von 1 bis 9 \r\n" +
        "zugewiesen und dient zum schnellen Umschalten von Stilen über die Befehlszeile. \r\n" +
        "Sie können den Namen ändern.",
      "CNC 样式（设置集）。 键和名称。 \r\n" +
        "该键被自动分配为从 1 到 9 的数字，用于从命令行快速切换样式。 \r\n" +
        "您可以更改名称。" };
    public static readonly string[] SkipObtuse = {
      "Skip obtuse angles",
      "Пропускать тупые",
      "Salta angoli ottusi",
      "Überspringen Sie stumpfe Ecken",
      "跳过钝角" };
    public static readonly string[] SkipObtuseTip = {
      "If the angle is obtuse, then the corner processed by the cutter differs very little from the original contours. \r\n" +
        "The program may not handle corners where the difference is less than the permissible variation.",
      "Если угол слишком тупой, то обработанный контур может почти совпадать с исходным. \r\n" +
        "Программа может игнорировать такие углы в зависимости от допустимого отклонения.",
      "Se l'angolo è ottuso, l'angolo elaborato dall' utensile  differisce molto poco dai contorni originali. \r\n" +
        "Il programma non può gestire angoli in cui la differenza è inferiore alla variazione consentita.",
      "Wenn der Winkel zu stumpf ist, kann die bearbeitete Kontur fast mit dem Original übereinstimmen. \r\n" +
        "Abhängig von der Toleranz kann das Programm solche Winkel ignorieren.",
      "如果角度太钝，则加工轮廓可能几乎与原始轮廓重合。 \r\n" +
        "程序可能会根据公差忽略这些角度。" };
    public static readonly string[] SplineToLine = {
      "Approximation spline to lines",
      "Сплайн в линию",
      "Spline on line",
      "Spline zu Linie",
      "样条到线" };
    public static readonly string[] SplineToLineTip = {
      "Prohibit the use of arcs (only lines) for the approximation of a spline. \r\n" +
        "It use system variable PLINECONVERTMODE.",
      "Запретить использование дуг (только линии) при аппроксимации сплайна. \r\n" +
        "Используется системная переменная PLINECONVERTMODE.",
      "Vietare l'uso di archi (solo le linee) per l'approssimazione di una spline. \r\n" +
        "Utilizzare la variabile di sistema PLINECONVERTMODE.",
      "Deaktivieren Sie die Verwendung von Bögen (nur Linien), wenn Sie einen Spline approximieren.\r\n" +
         "Die Systemvariable PLINECONVERTMODE wird verwendet.",
      "逼近样条曲线时禁用圆弧（仅线）。\r\n" +
         "正在使用 PLINECONVERTMODE 系统变量。" };
    public static readonly string[] WindowCornersTip = {
      "Cut Inside Corners or make a Fillet on all through internal contours of the detail \r\n" +
        "(through holes, windows).",
      "Делать дугу захода фрезы в угол или делать скругление углов на всех внутренних сквозных контурах деталей \r\n" +
        "(сквозных пропилах, окнах).",
      "Taglia Angoli Interni o crea un Raccordo su tutti i contorni interni del dettaglio \r\n" +
        "(attraverso fori, finestre).",
      "Schneiden Sie Innenecken oder machen Sie eine Verrundung an allen Innenkonturen des Details \r\n" +
        "(Durchgangslöcher, Fenster).",
      "切割内部角落或在细节的所有内部轮廓（通孔，窗户）上制作圆角。" };
    public static readonly string[] Corners = {
      "Corners milling",
      "Фрезеровка углов",
      "Fresatura degli spigoli",
      "Eckenfräsen",
      "角铣" };
    public static readonly string[] Drill = {
      "Drilling",
      "Сверловка",
      "Perforazione",
      "Bohren",
      "钻孔" };
    public static readonly string[] LayerName = {
      "Layer Naming",
      "Имена слоев",
      "Denominare i Layer",
      "Schichtnamen",
      "图层名称" };
    public static readonly string[] Milling = {
      "Milling",
      "Фрезеровка",
      "Fresatura",
      "Mahlen",
      "铣削" };
    public static readonly string[] Saw = {
      "Sawing",
      "Напилка",
      "Segare",
      "Sägen",
      "锯切" };
    public static readonly string[] Tolerance = {
      "Permissible variation",
      "Допустимое отклонение",
      "Variazione consentita",
      "Zulässige Abweichung",
      "允许的变化" };
    public static readonly string[] ToleranceTip = {
      "The errors of the original contours are ignored. Change with caution!",
      "Игнорируемые погрешности исходных контуров. Меняйте с осторожностью!",
      "Errori ignorati dei contorni originali. Cambia con cura!",
      "Ignorierte Fehler der Originalkonturen. Wechseln Sie mit Bedacht!",
      "忽略原始轮廓的错误。 谨慎修改！" };
    public static readonly string[] Angle = {
      "in Angle",
      "по углу",
      "dall'angolo",
      "nach Winkel",
      "按角度" };
    public static readonly string[] ArcAngleForClosing = {
      "Arc angle for closing",
      "Угол дуги для замыкания",
      "Angolo dell'arco per la chiusura",
      "Bogenwinkel zum Schließen",
      "闭合弧度" };
    public static readonly string[] ArcAngleForClosingTip = {
      "If the arc exceeds this angle, then it should be replaced by a circle",
      "Если дуга превышает этот угол, то ее следует заменить окружностью",
      "Se l'arco supera questo angolo, allora dovrebbe essere sostituito con un cerchio",
      "Wenn der Bogen diesen Winkel überschreitet, sollte er durch einen Kreis ersetzt werden",
      "如果圆弧超过这个角度，那么应该用圆代替" };
    public static readonly string[] BlankOffset = {
      "Offset of the blank rectangle",
      "Офсет прямоугольника заготовки",
      "Offset rettangolo vuoto",
      "Leerer Rechteckversatz",
      "空白矩形偏移" };
    public static readonly string[] BlockLateral = {
      "Lateral",
      "Торцевое",
      "Laterale",
      "Seitlich",
      "侧" };
    public static readonly string[] BlockUnder = {
      "Under",
      "Снизу",
      "Basso",
      "Unter",
      "在下面" };
    public static readonly string[] BlockUni = {
      "Swivel",
      "Наклонное",
      "Inclinata",
      "Schräg",
      "斜" };
    public static readonly string[] CutterDiam = {
      "Cutter diameter",
      "Диаметр",
      "Diametro",
      "Fräserdurchmesser",
      "刀具直径" };
    public static readonly string[] CutterGap = {
      "Gap",
      "Зазор",
      "Divario",
      "Lücke",
      "差距" };
    public static readonly string[] DirTypes = {
      "Direction names",
      "Направления",
      "Nomi di direzione",
      "Richtungsnamen",
      "方向名称" };
    public static readonly string[] Dot = {
      "Decimal separator",
      "Разделитель",
      "Separatore decimale",
      "Dezimaltrennzeichen",
      "小数分隔符" };
    public static readonly string[] DrillBits = {
      "Bits diameters",
      "Диаметры сверл",
      "Diametri di punte",
      "Bohrerdurchmesser",
      "钻头直径" };
    public static readonly string[] Letters = {
      "Direction Letters",
      "Знаки направления",
      "Simboli di direzione",
      "Richtungsbriefe",
      "方向信" };
    public static readonly string[] MillMode = {
      "Mode",
      "Режим",
      "Modalità",
      "Modus",
      "模式" };
    public static readonly string[] MillTool = {
      "Tool",
      "Фреза",
      "Attrezzo",
      "Cutter",
      "刀具" };
    public static readonly string[] Multiplier = {
      "Size Multiplier",
      "Множитель",
      "Moltiplicatore",
      "Größenmultiplikator",
      "大小乘数" };
    public static readonly string[] OutsideCorners = {
      "Outside",
      "Наружа",
      "Fuori",
      "Außen",
      "外部" };
    public static readonly string[] PocketCorners = {
      "Pockets",
      "Выборки",
      "Tasca",
      "Taschen",
      "口袋" };
    public static readonly string[] SawDiam = {
      "Diameter",
      "Диаметр",
      "Diametro",
      "Durchmesser",
      "直径" };
    public static readonly string[] SawMode = {
      "Mode",
      "Режим",
      "Modalità",
      "Modus",
      "模式" };
    public static readonly string[] SawThickness = {
      "Thickness",
      "Толщина",
      "Spessore",
      "Dicke",
      "厚度" };
    public static readonly string[] SawTool = {
      "Tool",
      "Диск",
      "Attrezzo",
      "Sägeblatt",
      "锯片" };
    public static readonly string[] WindowCorners = {
      "Windows",
      "Окна",
      "Finestra",
      "Fenster",
      "视窗" };
    public static readonly string[] Depth = {
      "Default depth",
      "Глубина",
      "Profondità",
      "Standardtiefe",
      "默认深度" };
    public static readonly string[] Liner = {
      "in Size",
      "по длине",
      "in formato",
      "nach Länge",
      "按长度" };
    public static readonly string[] AngleTip = {
      "The maximum angle (bend lines), which can be ignored. \r\n" +
        "Degrees or radians (as set in the current drawing unit). \r\n" +
        "Used to combine lines, measuring angles... \r\n" +
        "Change with caution! ",
      "Максимальный угол (излом линии), который можно игнорировать. \r\n" +
        "Градусы или радианы (как установлено в текущем чертеже). \r\n" +
        "Используется для объединения линий, измерения углов ... \r\n" +
        "Изменяйте с осторожностью!",
      "L'angolo massimo (linee di piega), che può essere ignorato. \r\n" +
        "Gradi o radianti (come impostati nell'unità di disegno corrente). \r\n" +
        "Utilizzato per combinare linee, misurare angoli ... \r\n" +
        "Cambia con cautela!",
      "Der maximale Winkel (Zeilenumbruch), der ignoriert werden kann. \r\n" +
        "Grad oder Bogenmaß (wie in der aktuellen Zeichnung festgelegt). \r\n" +
        "Wird verwendet, um Linien zu verbinden, Winkel zu messen... \r\n" +
        "Mit Vorsicht modifizieren!",
      "可以忽略的最大角度（换行符）。 \r\n" +
        "度数或弧度（在当前图形中设置）。 \r\n" +
        "用于连接线、测量角度……\r\n" +
        "谨慎修改！" };
    public static readonly string[] BlankOffsetTip = {
      "Offset of the workpiece rectangle from the dimensions of the part.",
      "Офсет прямоугольника заготовки наружу, от габаритов детали.",
      "Offset del rettangolo del pezzo rispetto alle dimensioni del pezzo.",
      "Versatz des Werkstückrechtecks ​​nach außen, von den Abmessungen des Teils.",
      "工件矩形从零件尺寸向外偏移。" };
    public static readonly string[] BlockLateralTip = {
      "Name of block for designation lateral (horizontal, side end) drilling. \r\n" +
        "The block will be inserted only if non-vertical drilling contours are disabled. \r\n" +
        "The block will be inserted into the model space and turned by the X axis along the drilling. ",
      "Имя блока для торцевого (горизонтального) сверления. \r\n" +
        "Блоки будут расставлены, только если отключены контуры не-вертикальных сверлений. \r\n" +
        "Блоки будут вставлены в пространство модели и развернуты осью X \r\n" +
        "вдоль сверления и масштабированы по диаметру сверла и глубине сверления.",
      "Nome del blocco per la foratura di designazione laterale (orizzontale). \r\n" +
        "Il blocco verrà inserito solo se i profili di perforazione non verticali sono disabilitati. \r\n" +
        "Il blocco verrà inserito nello spazio del modello e ruotato dall'asse X lungo la perforazione.",
      "Blockname für stirnseitiges (horizontales) Bohren. \r\n" +
        "Blöcke werden nur platziert, wenn nicht vertikale Bohrkonturen deaktiviert sind. \r\n" +
        "Die Blöcke werden in den Modellbereich eingefügt und entlang \r\n" +
        "der x-Achse entlang des Bohrers gedreht und durch den Bohrerdurchmesser und die Bohrtiefe skaliert.",
      "面（水平）钻孔的块名称。 \r\n" +
        "仅当禁用非垂直钻孔轮廓时才会放置块。 \r\n" +
        "块将被插入模型空间并沿钻孔沿 x 轴旋转，并按钻孔直径和钻孔深度进行缩放。" };
    public static readonly string[] BlockUnderTip = {
      "Name of block for designation under (rear) drilling. \r\n" +
        "The block will be inserted only if non-vertical drilling contours are disabled. \r\n" +
        "The block will be inserted into the model space.",
      "Имя блока для сверления снизу. \r\n" +
        "Блоки будут расставлены, только если отключены контуры не-вертикальных сверлений. \r\n" +
        "Блоки будут вставлены в пространство модели в центр отверстия и масштабированы по диаметру сверла.",
      "Nome del blocco per la designazione sotto la perforazione (posteriore). \r\n" +
        "Il blocco verrà inserito solo se i profili di perforazione non verticali sono disabilitati. \r\n" +
        "Il blocco verrà inserito nello spazio del modello.",
      "Name des Blocks, der von unten gebohrt werden soll. \r\n" +
        "Blöcke werden nur platziert, wenn nicht vertikale Bohrkonturen deaktiviert sind. \r\n" +
        "Die Blöcke werden in der Mitte des Lochs in den Modellbereich eingefügt und entsprechend dem Bohrerdurchmesser skaliert.",
      "要从下方钻取的块的名称。 \r\n" +
        "仅当禁用非垂直钻孔轮廓时才会放置块。 \r\n" +
        "块将插入到孔中心的模型空间中，并按比例缩放以适合钻孔直径。" };
    public static readonly string[] BlockUniTip = {
      "Name of block for designation swivel (sloped, universal) drilling. \r\n" +
        "The block will be inserted only if non-vertical drilling contours are disabled. \r\n" +
        "The block will be inserted into the model space and turned by the X axis along the drilling. ",
      "Имя блока для наклонного сверления. \r\n" +
        "Блоки будут расставлены, только если отключены контуры не-вертикальных сверлений. \r\n" +
        "Блоки будут вставлены в пространство модели и развернуты осью X вдоль сверления и масштабированы по диаметру сверла и глубине сверления.",
      "Nome del blocco per la foratura designazione girevole (universale, inclinata). \r\n" +
        "Il blocco verrà inserito solo se i profili di perforazione non verticali sono disabilitati. \r\n" +
        "Il blocco verrà inserito nello spazio del modello e ruotato dall'asse X lungo la perforazione.",
      "Name des Blocks für geneigtes Bohren. \r\n" +
        "Blöcke werden nur platziert, wenn nicht vertikale Bohrkonturen deaktiviert sind. \r\n" +
        "Die Blöcke werden in den Modellbereich eingefügt und entlang \r\n" +
        "der x-Achse entlang des Bohrers gedreht und durch den Bohrerdurchmesser und die Bohrtiefe skaliert.",
      "斜钻块的名称。 \r\n" +
        "仅当禁用非垂直钻孔轮廓时才会放置块。\r\n" +
        " 块将被插入模型空间并沿钻孔沿 x 轴旋转，并按钻孔直径和钻孔深度进行缩放。" };
    public static readonly string[] CutterDiamTip = {
      "The diameter of the cutting tool. \r\n" +
        "Must be greater than zero. \r\n" +
        "If you cut with a laser (cutting width near zero) then simply turn off the metering of the cutter diameter.",
      "Диаметр режущего инструмента. \r\n" +
        "Должно быть больше нуля. \r\n" +
        "Если вы режете лазером (ширина реза около ноля), то просто отключите учет диаметра фрезы.",
      "Il diametro dell'utensile da taglio. \r\n" +
        "Deve essere maggiore di zero. \r\n" +
        "Se tagli con un laser (larghezza di taglio vicino allo zero) \r\n" +
        "quindi semplicemente disattivare la misurazione del diametro della fresa.",
      "Durchmesser des Schneidwerkzeugs. \r\n" +
        "Muss größer als Null sein. \r\n" +
        "Wenn Sie mit einem Laser schneiden (Schnittbreite ist ungefähr Null), \r\n" +
        "dann schalten Sie einfach die Berücksichtigung des Durchmessers des Messers aus.",
      "切削刀具直径。 必须大于零。 \r\n" +
        "如果你用激光切割（切割宽度大约为零），那么只需关闭对切割器直径的考虑。" };
    public static readonly string[] CutterGapTip = {
      "Increasing the diameter of this number to get a gap. \r\n" +
        "You can assign a 0.",
      "Увеличить диаметр фрезы для обеспечения свободного прохода. \r\n" +
        "Можно назначить 0.",
      "Divario su raccordo tra fresa e pezzo. \r\n" +
        "Aumentando il diametro di questo numero per ottenere un divario. \r\n" +
        "Puoi assegnare uno 0.",
      "Fräserdurchmesser vergrößern, um freien Durchgang zu gewährleisten. \r\n" +
        "Sie können 0 zuweisen.",
      "增加刀具直径以确保自由通过。 \r\n" +
        "您可以指定 0。" };
    public static readonly string[] DepthTip = {
      "Add it depth at end of layer names. \r\n" +
        "Use for DadoLoop (DDL) command and for inner contours of OutsideLoop (OSL) command. \r\n" +
        "Use 0 if you not need depth. \r\n" +
        "Use -1 if you want to enter depth each time.",
      "Команды, которые работают с плоскими чертежами, \r\n" +
        "а не с солидами (Внешний контур OSL и Контур выборки DDL) \r\n" +
        "могут добавить эту цифру к названию слоя. \r\n" +
        "Если не надо добавлять глубину - напишите ноль. \r\n" +
        "Напишите -1, чтоб глубина запрашивалась при каждом вызове команд.",
      "Aggiunge la Profondità alla fine dei nomi dei Layer. \r\n" +
        "Da utilizzare con il comando DadoLoop (DDL) e con il comando  OutsideLoop (OSL). \r\n" +
        "Mettere 0 se non si ha bisogno di indicare la profondità. \r\n" +
        "Mettere -1 se si desidera inserire la profondità ogni volta.",
      "Befehle, die eher mit 2D-Zeichnungen als mit Volumenkörpern funktionieren (OSL-Umriss und DDL-Auswahlumriss), \r\n" +
        "können diese Nummer zum Ebenennamen hinzufügen. \r\n" +
        "Wenn Sie keine Tiefe hinzufügen müssen, schreiben Sie Null. \r\n" +
        "Schreiben Sie -1, um bei jedem Befehlsaufruf die Tiefe anzufordern.",
      "使用 2D 绘图而不是实体的命令（OSL 轮廓和 DDL 选择轮廓）可以将此编号添加到图层名称中。 \r\n" +
        "如果您不需要添加深度 - 写零。 \r\n" +
        "写入 -1 以请求每个命令调用的深度。" };
    public static readonly string[] DirTypesTip = {
      "Drilling direction names for the drilling table. \r\n" +
        "Used in the% drill% substitution. \r\n" +
        "The list should contain 9 names separated by semicolons: \r\n" +
        "1 - vertical through drilling, \r\n" +
        "2 - blind vertical drilling from the facade, \r\n" +
        "3 - blind vertical drilling from the rear, \r\n" +
        "4 - lateral drilling on the left (along X), \r\n" +
        "5 - lateral drilling from above (in -Y), \r\n" +
        "6 - lateral drilling on the right (by -X), \r\n" +
        "7 - lateral drilling from the bottom (along Y), \r\n" +
        "8 - lateral drilling not along the axes, \r\n" +
        "9 - oblique drilling at arbitrary angles.",
      "Названия направлений сверления для таблицы сверлений. \r\n" +
        "Используются в подстановке %drill%. \r\n" +
        "В списке должно быть 9 названий разделенных точкой с запятой: \r\n" +
        "1 - сквозное вертикальное сверление, \r\n" +
        "2 - глухое вертикальное сверление с фасада, \r\n" +
        "3 - глухое вертикальное сверление с тыла, \r\n" +
        "4 - торцевое сверление слева (по X), \r\n" +
        "5 - торцевое сверление сверху (по -Y), \r\n" +
        "6 - торцевое сверление справа (по -X), \r\n" +
        "7 - торцевое сверление снизу (по Y), \r\n" +
        "8 - торцевое сверление не по осям, \r\n" +
        "9 - наклонное сверление под произвольными углами.",
      "Nomi delle direzioni di foratura per la tabella di foratura. \r\n" +
        "Utilizzato nella ricerca %drill%. \r\n" +
        "L'elenco dovrebbe contenere 9 nomi separati da punto e virgola: \r\n" +
        "1 - foratura passante verticale, \r\n" +
        "2 - perforazione verticale cieca dalla facciata, \r\n" +
        "3 - foratura verticale cieca dal retro, \r\n" +
        "4 - foratura laterale a sinistra (lungo X), \r\n" +
        "5 - foratura laterale dall'alto (in -Y), \r\n" +
        "6 - foratura laterale a destra (lungo -X), \r\n" +
        "7 - foratura laterale dal basso (lungo Y), \r\n" +
        "8 - foratura laterale non lungo gli assi, \r\n" +
        "9 - perforazione obliqua ad angoli arbitrari.",
      "Namen von Bohrrichtungen für die Bohrtabelle. \r\n" +
        "Wird in der %drill%-Ersetzung verwendet. \r\n" +
        "Die Liste sollte 9 durch Semikolon getrennte Bezeichnungen enthalten: \r\n" +
        "1 - durchgehende Vertikalbohrung, \r\n" +
        "2 - blinde Vertikalbohrung von der Fassade, \r\n" +
        "3 - blinde Vertikalbohrung von hinten, \r\n" +
        "4 - Endbohrung links (X), \r\n" +
        "5 - Endbohrung von oben (entlang -Y), \r\n" +
        "6 - Stirnbohrung rechts (entlang -X), \r\n" +
        "7 - Stirnbohrung von unten (entlang Y), \r\n" +
        "8 - Stirnbohrung nicht entlang der Achsen, \r\n" +
        "9 - Schrägbohrung in beliebigen Winkeln.",
      "钻孔表的钻孔方向名称。 用于 %drill% 替换。 \r\n" +
        "该列表应包含用分号分隔的 9 个名称：\r\n" +
        "1 - 贯穿垂直钻孔，\r\n" +
        "2 - 从正面垂直钻孔，\r\n" +
        "3 - 从后部垂直钻孔，\r\n" +
        "4 - 左侧末端钻孔 (X)，\r\n" +
        "5 - 末端钻孔从上方（沿 -Y），\r\n" +
        "6 - 右侧面钻孔（沿 -X），\r\n" +
        "7 - 从下方（沿 Y）钻孔，\r\n" +
        "8 - 不沿轴的面钻孔，\r\n" +
        "9 - 以任意角度倾斜钻孔。" };
    public static readonly string[] DrillBitsTip = {
      "List of available drill diameters. \r\n" +
        "All holes of other diameters will fall into the milling layer. ",
      "Список диаметров имеющихся сверл. \r\n" +
        "Разделяйте список точками с запятой. \r\n" +
        "Все отверстия других диаметров попадут в слой фрезеровки.",
      "Elenco dei diametri di trapano disponibili. \r\n" +
        "Tutti i fori di altri diametri cadranno nello strato di fresatura.",
      "Liste der verfügbaren Bohrdurchmesser. \r\n" +
        "Trennen Sie die Liste mit Semikolons. \r\n" +
        "Alle Löcher mit anderen Durchmessern fallen in die Frässchicht.",
      "可用钻头直径列表。 用分号分隔列表。 \r\n" +
        "所有其他直径的孔都将落入铣削层。" };
    public static readonly string[] CountersinkTip = {
      "",
      "Текст для подстановки %countersink% для отверстий с зенковкой.",
      "",
      "",
      "" };
    public static readonly string[] FormatTip = {
      "Enter string for control the number of decimal places and insignificant zeros. \r\n" +
        "Symbol 0 - any digit or zero. \r\n" +
        "Symbol # - any digit or nothing. \r\n" +
        "Default “0.#” - interpreted like 1 decimal digit after float point if it not 0.\r\n" +
        "Additional you can use fractional formats: \r\n" +
        "CU - from current drawing (Set it in Drawing units dialog box) \r\n" +
        "AR - Architectural \r\n" +
        "EN - Engineering \r\n" +
        "FR - Fractional \r\n" +
        "After AR, EN, FR you can write precision (0-8)",
      "Сколько знаков после запятой писать и писать ли незначащие нули. \r\n" +
        "В формате используйте символы 0 и #. \r\n" +
        "0 - это цифра или 0, \r\n" +
        "# - это цифра или ничего.  \r\n" +
        "Например, цифра 1.111111 отформатированная 00.00 выведется как 01.11. \r\n" +
        "А отформатированная 0.#### выведется как 1.1111.  \r\n" +
        "А цифра 1.2 отформатированная 0.#### выведется как 1.2.   \r\n" +
        "Есть специальные форматы:  \r\n" +
        "CU - как настроены единицы в текущем чертеже (через диалог Единицы чертежа) \r\n" +
        "AR, EN, FR - американские дробные форматы",
      "Formattare la profondità delle cifre e altre cifre. \r\n" +
        "Quante cifre decimali per scrivere e scrivere zeri insignificanti. \r\n" +
        "Simbolo 0 - qualsiasi cifra o pari a zero. \r\n" +
        "Simbolo # - qualsiasi cifra o nulla.  \r\n" +
        "Predefinito 0.# - interpretato come 1 cifra decimale dopo il punto flottante, se non 0. \r\n" +
        "In agiunta è possibile utilizzare i seguenti formati frazionari:  \r\n" +
        "CU - da disegno corrente \r\n" +
        "AR - Architectural \r\n" +
        "IT - Ingegneria \r\n" +
        "FR - frazionale \r\n" +
        "Dopo AR, EN, FR è possibile scrivere precisione (0-8)",
      "Wie viele Dezimalstellen zu schreiben sind und ob unbedeutende Nullen geschrieben werden sollen. \r\n" +
        "Verwenden Sie im Format die Zeichen 0 und #. \r\n" +
        "0 ist eine Zahl oder 0, \r\n" +
        "# ist eine Zahl oder nichts. \r\n" +
        "Beispielsweise wird die als 00.00 formatierte Zahl 1.111111 als 01.11 angezeigt. \r\n" +
        "Und die formatierte 0.#### wird als 1.1111 angezeigt. \r\n" +
        "Und die Zahl 1.2 im Format 0.#### wird als 1.2 angezeigt. \r\n" +
        "Es gibt spezielle Formate: \r\n" +
        "CU – wie die Einheiten in der aktuellen Zeichnung eingestellt sind (über das Dialogfeld „Zeichnungseinheiten“) \r\n" +
        "AR, EN, FR – amerikanische Bruchformate",
      "要写多少小数位以及是否写无意义的零。 \r\n" +
        "在格式中使用字符 0 和 #。 \r\n" +
        "0 是一个数字或 0，\r\n" +
        "# 是一个数字或什么都没有。 \r\n" +
        "例如，格式化为 00.00 的数字 1.111111 将显示为 01.11。 \r\n" +
        "并且格式化后的 0.#### 会显示为 1.1111。 \r\n" +
        "而数字 1.2 格式化为 0.#### 将显示为 1.2。 \r\n" +
        "有一些特殊格式： \r\n" +
        "CU - 如何在当前图形中设置单位（通过“图形单位”对话框） \r\n" +
        "AR、EN、FR - 美国分数格式" };
    public static readonly string[] LinerTip = {
      "The maximum allowable deviation. \r\n" +
        "In the current drawing units [mm or inch]. \r\n" +
        "Used to remove obstructions, debris, approximating splines. \r\n" +
        "Minimum 0.0000001, Maximum 5мм. \r\n" +
        "Change with caution! ",
      "Максимально допустимое отклонение. \r\n" +
        "В текущих единицах чертежа [мм или дюйм]. \r\n" +
        "Используется для удаления зазоров, мусора, аппроксимации сплайнов. \r\n" +
        "Минимум 0.0000001, Максимум 5мм. \r\n" +
        "Изменяйте с осторожностью! ",
      "La deviazione massima consentita. \r\n" +
        "Nelle unità di disegno correnti [mm o pollici]. \r\n" +
        "Usato per rimuovere ostruzioni, detriti, spline approssimative. \r\n" +
        "Minimo 0,0000001, Massimo 5 mm. \r\n" +
        "Cambia con cautela!",
      "Die maximal zulässige Abweichung. \r\n" +
        "In aktuellen Zeichnungseinheiten [mm oder Zoll]. \r\n" +
        "Wird verwendet, um Lücken, Ablagerungen und Spline-Annäherungen zu entfernen. \r\n" +
        "Minimum 0,0000001, Maximum 5 mm. \r\n" +
        "Vorsichtig modifizieren!",
      "最大允许偏差。 以当前绘图单位 [mm 或 inch]。 \r\n" +
        "用于去除间隙、碎屑、样条逼近。 \r\n" +
        "最小 0.0000001，最大 5mm。 \r\n" +
        "谨慎修改！" };
    public static readonly string[] NameTip = {
      "The name for this CNC style. \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Название для этого стиля ЧПУ. \r\n" +
        "Не используется в программе. Только для удобства выбора.",
      "Il nome per questo stile CNC. \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen CNC-Stil. \r\n" +
        "Wird im Programm nicht verwendet. Nur aus Bequemlichkeit.",
      "此 CNC 样式的名称。 程序中未使用。 \r\n" +
        "仅为方便起见。" };
    public static readonly string[] SawDiamTip = {
      "Saw disk diameter. \r\n" +
        "The size of the excess sawing depends on this parameter and on the thickness of the part.",
      "Диаметр пильного диска. \r\n" +
        "Размер лишнего пропила (вылета) зависит от этого параметра и от толщины детали.",
      "Diametro disco sega. \r\n" +
        "La dimensione del taglio in eccesso dipende da questo parametro e dallo spessore del pezzo.",
      "Sägeblattdurchmesser. \r\n" +
        "Die Größe des Überschusses hängt von diesem Parameter und der Dicke des Werkstücks ab.",
      "锯片直径。 \r\n" +
        "多余切口的大小取决于这个参数和工件的厚度。" };
    public static readonly string[] SawThicknessTip = {
      "The thickness of the sawing disk. \r\n" +
        "Must be greater than zero. \r\n" +
        "This value determines the permissible dado width and the offset of the center line of the saw.",
      "Толщина пильного диска. \r\n" +
        "Должно быть больше нуля. \r\n" +
        "Это значение определяет допустимую ширину паза и смещение центральной линии пилы.",
      "Lo spessore del disco di taglio. \r\n" +
        "Deve essere maggiore di zero. \r\n" +
        "Questo valore determina l'ampiezza del dado consentita e l'offset della linea centrale della sega.",
      "Sägeblattstärke. \r\n" +
        "Muss größer als Null sein. \r\n" +
        "Dieser Wert bestimmt die zulässige Schlitzbreite und den Mittellinienversatz des Sägeblatts.",
      "锯片厚度。 必须大于零。 \r\n" +
        "该值决定了允许的槽宽和锯片中心线偏移。" };
    public static readonly string[] DiamQueryDiam = {
      "Enter milling cutter diameter",
      "Введите диаметр фрезы",
      "Digitare diametro della fresa",
      "Fräserdurchmesser eingeben",
      "输入刀具直径"};
    public static readonly string[] DiamQueryZero = {
      " or zero",
      " или ноль",
      " o lasciare zero",
      " oder null",
      " 或零"};
    public static readonly string[] DiamQueryTooSmall = {
      "Cutter diameter is too small",
      "Слишком маленький диаметр фрезы",
      "Diametro della fresa è troppo piccolo",
      "Fräserdurchmesser ist zu klein",
      "刀具直径太小"};

  }
}
