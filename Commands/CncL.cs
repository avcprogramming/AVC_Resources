// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Cnc Dxf Vert

namespace AVC
{
  public static class
  CncL
  {
    public static readonly string[][] CncStyleNames = {
      new[] { "CNC",
        "ЧПУ",
        "CNC",
        "CNC",
        "数控",
        "CNC",                                         // ES
        "CNC",                                         // FR
        "CNC"},                                        // TR
      new[] { "Milling",
        "Фрезеровка",
        "Fresatura",
        "Fräsen",
        "铣削",
        "Fresado",                                     // ES
        "Fraisage",                                    // FR
        "Frezeleme"},                                  // TR
      new[] { "Milling Through/Blind",
        "Фрезеровка Насквозь/Глухая",
        "Fresatura Passante/Сieco",
        "Fräsen Hindurch/Hohle",
        "铣削/盲铣",
        "Fresado Pasante/Ciego",                       // ES
        "Fraisage Traversant/Borgne",                 // FR
        "Frezeleme Geçmeli/Kör"},                     // TR
      new[] { "Milling Inlay",
        "Фрезеровка инкрустаций",
        "Fresatura Inlay",
        "Fräsen Inlay",
        "铣削 镶嵌",
        "Fresado Incrustación",                        // ES
        "Fraisage Incrustation",                       // FR
        "Frezeleme Kakma"},                            // TR
      new[] { "Milling Biesse CNI",
        "Фрезеровка Biesse CNI",
        "Fresatura Biesse CNI",
        "Fräsen Biesse CNI",
        "铣削 Biesse CNI",
        "Fresado Biesse CNI",                          // ES
        "Fraisage Biesse CNI",                         // FR
        "Frezeleme Biesse CNI"},                       // TR
      new[] { "Milling BiesseWorks TCH",
        "Фрезеровка BiesseWorks TCH",
        "Fresatura BiesseWorks TCH",
        "Fräsen BiesseWorks TCH",
        "铣削 BiesseWorks TCH",
        "Fresado BiesseWorks TCH",                     // ES
        "Fraisage BiesseWorks TCH",                    // FR
        "Frezeleme BiesseWorks TCH"},                  // TR
      new[] { "Milling Homag WoodWOP En",
        "Фрезеровка Homag WoodWOP Английский",
        "Fresatura Homag WoodWOP En",
        "Fräsen Homag WoodWOP En",
        "铣削 Homag WoodWOP En",
        "Fresado Homag WoodWOP En",                    // ES
        "Fraisage Homag WoodWOP En",                   // FR
        "Frezeleme Homag WoodWOP En"},                 // TR
      new[] { "Milling Homag WoodWOP Ge",
        "Фрезеровка Homag WoodWOP Немецкий",
        "Fresatura Homag WoodWOP Ge",
        "Fräsen Homag WoodWOP Ge",
        "铣削 Homag WoodWOP Ge",
        "Fresado Homag WoodWOP Ge",                    // ES
        "Fraisage Homag WoodWOP Ge",                   // FR
        "Frezeleme Homag WoodWOP Ge"},                 // TR
      new[] { "Milling Thermwood",
        "Фрезеровка Thermwood ",
        "Fresatura Thermwood ",
        "Fräsen Thermwood ",
        "铣削 Thermwood",
        "Fresado Thermwood",                           // ES
        "Fraisage Thermwood",                          // FR
        "Frezeleme Thermwood"},                        // TR
      new[] { "Laser",
        "Лазер",
        "Laser",
        "Laser",
        "激光",
        "Láser",                                       // ES
        "Laser",                                       // FR
        "Lazer"},                                      // TR
    };

    public static readonly string[] DefLayerMillOutside = {
      "Mill Outside",
      "Фрезер Наружа",
      "Fresa Fuori",
      "Fräser Out",
      "铣削 外部",
      "Fresa Exterior",                                // ES
      "Fraise Extérieur",                              // FR
      "Freze Dış"};                                    // TR

    public static readonly string[] DefLayerMillIsland = {
      "Mill Island",
      "Фрезер Остров",
      "Fresa Isoletta",
      "Fräser Insel",
      "铣削 岛",
      "Fresa Isla",                                    // ES
      "Fraise Îlot",                                   // FR
      "Freze Ada"};                                    // TR

    public static readonly string[] DefLayerMillDado = {
      "Mill Dado",
      "Фрезер Паз",
      "Fresa Gola",
      "Fräser Rillen",
      "铣削 槽",
      "Fresa Ranura",                                  // ES
      "Fraise Rainure",                                // FR
      "Freze Yuva"};                                   // TR

    public static readonly string[] DefLayerMillWindow = {
      "Mill Window",
      "Фрезер Окно",
      "Fresa Finestra",
      "Fräser Fenster",
      "铣削 窗口",
      "Fresa Ventana",                                 // ES
      "Fraise Fenêtre",                                // FR
      "Freze Pencere"};                                // TR

    public static readonly string[] DefLayerMillPocket = {
      "Mill Pocket",
      "Фрезер Выборка",
      "Fresa Tasca",
      "Fräser Tasche",
      "铣削 口袋",
      "Fresa Bolsillo",                                // ES
      "Fraise Poche",                                  // FR
      "Freze Cep"};                                    // TR

    public static readonly string[] DefLayerMillUnder = {
      "Mill Under",
      "Фрезер Снизу",
      "Fresa Basso",
      "Fräser Unten",
      "铣削 底部",
      "Fresa Debajo",                                  // ES
      "Fraise Dessous",                                // FR
      "Freze Alt"};                                    // TR

    public static readonly string[] DefLayerMillSwivel = {
      "Mill Swivel",
      "Фрезер Наклон",
      "Fresa Inclinata",
      "Fräser Schwenken",
      "铣削 倾斜",
      "Fresa Giratoria",                               // ES
      "Fraise Pivotante",                              // FR
      "Freze Döner"};                                  // TR

    public static readonly string[] DefLayerMillImpassable = {
      "Mill Impassable",
      "Фрезер Непроходимый",
      "Fresa Impraticabile",
      "Fräser Unpassierbar",
      "铣削 不可逾越",
      "Fresa Impasable",                               // ES
      "Fraise Infranchissable",                        // FR
      "Freze Geçilemez"};                              // TR

    public static readonly string[] DefLayerDrillBlind = {
      "Drill Blind",
      "Сверло Глухо",
      "Perforare Сieco",
      "Bohr Hohle",
      "钻孔 盲孔",
      "Taladro Ciego",                                 // ES
      "Perçage Borgne",                                // FR
      "Matkap Kör"};                                   // TR

    public static readonly string[] DefLayerDrillThrough = {
      "Drill Through",
      "Сверло Насквозь",
      "Perforare Passante",
      "Bohr Hindurch",
      "钻孔 通孔",
      "Taladro Pasante",                               // ES
      "Perçage Traversant",                            // FR
      "Matkap Geçmeli"};                               // TR

    public static readonly string[] DefLayerDrillLateral = {
      "Drill Lateral",
      "Сверло Торц",
      "Perforare Laterale",
      "Bohr Seitlich",
      "钻孔 侧",
      "Taladro Lateral",                               // ES
      "Perçage Latéral",                               // FR
      "Matkap Yanal"};                                 // TR

    public static readonly string[] DefLayerDrillUnder = {
      "Drill Under",
      "Сверло Снизу",
      "Perforare Basso",
      "Bohr Unten",
      "钻孔 底部",
      "Taladro Debajo",                                // ES
      "Perçage Dessous",                               // FR
      "Matkap Alt"};                                   // TR

    public static readonly string[] DefLayerDrillSwivel = {
      "Drill Swivel",
      "Сверло Наклон",
      "Perforare Inclinata",
      "Bohr Schwenken",
      "钻孔 倾斜",
      "Taladro Giratorio",                             // ES
      "Perçage Pivotant",                              // FR
      "Matkap Döner"};                                 // TR

    public static readonly string[] DefLayerSawDado = {
      "Saw Dado",
      "Пила Паз",
      "Sega Gola",
      "Säge Rillen",
      "锯 槽",
      "Sierra Ranura",                                 // ES
      "Scie Rainure",                                  // FR
      "Testere Yuva"};                                 // TR

    public static readonly string[] DefLayerSawThrough = {
      "Saw Through",
      "Пила Насквозь",
      "Sega Passante",
      "Säge Hindurch",
      "锯 锯通",
      "Sierra Pasante",                                // ES
      "Scie Traversante",                              // FR
      "Testere Geçmeli"};                              // TR

    public static readonly string[] DefLayerSawUnder = {
      "Saw Under",
      "Пила Снизу",
      "Sega Basso",
      "Säge Unten",
      "锯 底部",
      "Sierra Debajo",                                 // ES
      "Scie Dessous",                                  // FR
      "Testere Alt"};                                  // TR

    public static readonly string[] DefLayerSawSwivelUp = {
      "Saw Swivel Upward",
      "Пила Наклон вверх",
      "Sega Inclinata Rialzo",
      "Säge Schwenken Oben",
      "锯 向上旋转",
      "Sierra Giratoria Hacia Arriba",                 // ES
      "Scie Pivotante Vers le Haut",                   // FR
      "Testere Döner Yukarı"};                         // TR

    public static readonly string[] DefLayerSawSwivelDown = {
      "Saw Swivel Downward",
      "Пила Наклон вниз",
      "Sega Inclinata Ribasso",
      "Säge Schwenken Abwärts",
      "锯 向下旋转",
      "Sierra Giratoria Hacia Abajo",                  // ES
      "Scie Pivotante Vers le Bas",                    // FR
      "Testere Döner Aşağı"};                          // TR

    public static readonly string[] DefLayerSizeRectangle = {
      "Blank",
      "Заготовка",
      "Billetta",
      "Werkstk",
      "空白的",
      "Pieza en bruto",                                // ES
      "Ébauche",                                       // FR
      "Boş"};                                          // TR

    public static readonly string[] DefLayerTop = {
      "Top",
      "Верх",
      "Superiore",
      "Ober",
      "顶部",
      "Superior",                                      // ES
      "Haut",                                          // FR
      "Üst"};                                          // TR

    public static readonly string[] DefLayerBottom = {
      "Bottom",
      "Низ",
      "Inferiore",
      "Niedriger",
      "底部",
      "Inferior",                                      // ES
      "Bas",                                           // FR
      "Alt"};                                          // TR

    public static readonly string[] DefLayerHidden = {
      "Hidden",
      "Невидимые",
      "Nascosta",
      "Verdeckt",
      "隐",
      "Oculto",                                        // ES
      "Caché",                                         // FR
      "Gizli"};                                        // TR

    public static readonly string[] DefLayerBlind = {
      "Blind",
      "Глухая",
      "Сieco",
      "Hohle",
      "非切割加工",
      "Ciego",                                         // ES
      "Borgne",                                        // FR
      "Kör"};                                          // TR

    public static readonly string[] DefLayerThrough = {
      "Through",
      "Насквозь",
      "Passante",
      "Hindurch",
      "凿孔加工",
      "Pasante",                                       // ES
      "Traversant",                                    // FR
      "Geçmeli"};                                      // TR

    public static readonly string[] InfoLayerMillOutside = {
      "Milling the outside contour of a part through a part",
      "Фрезеровка наружного контура детали насквозь детали",
      "Fresatura del contorno esterno di una parte attraverso una parte",
      "Fräsen der Außenkontur eines Teils durch ein Teil",
      "通过零件铣削零件的外轮廓",
      "Fresado del contorno exterior de una pieza a través de una pieza",  // ES
      "Fraisage du contour extérieur d'une pièce à travers une pièce",     // FR
      "Bir parçanın dış konturunun parça boyunca frezelenmesi"};            // TR

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
           "选择内部的突起",
      "Fresado fuera del contorno, pero no a través de la pieza.\r\n" +  // ES
          "Salientes dentro de las ranuras",
      "Fraisage à l'extérieur du contour, mais pas à travers la pièce.\r\n" +  // FR
          "Protubérances à l'intérieur des rainures",
      "Konturun dışında frezeleme, ancak parçadan geçmeden.\r\n" +  // TR
          "Yuva içindeki çıkıntılar"};

    public static readonly string[] InfoLayerMillDado = {
      "Milling inside the contour. Not through the part. Dadoes, grooves",
      "Фрезеровка внутри контура не насквозь. Пазы, четверти",
      "Fresatura all'interno di un contorno non passante. Scanalature, gola, fessura",
      "Fräsen innerhalb einer Kontur nicht durch (Rillen)",
      "轮廓内的铣削未通过。",
      "Fresado dentro del contorno. No a través de la pieza. Ranuras, acanaladuras",  // ES
      "Fraisage à l'intérieur du contour. Pas à travers la pièce. Rainures, gorges",  // FR
      "Kontur içinde frezeleme. Parçadan geçmeden. Yuvalar, oluklar"};  // TR

    public static readonly string[] InfoLayerMillWindow = {
      "Milling inside a path through the part (Window)",
      "Фрезеровка внутри контура насквозь детали (Окно)",
      "Fresatura all'interno di un percorso in tutto e per tutto (Finestra)",
      "Fräsen in einem Pfad durch und durch (Fenster)",
      "在通过零件的路径内铣削（窗口）",
      "Fresado dentro de un trayecto a través de la pieza (Ventana)",  // ES
      "Fraisage à l'intérieur d'un chemin à travers la pièce (Fenêtre)",  // FR
      "Parçadan geçen bir yol içinde frezeleme (Pencere)"};  // TR

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
          "需要通过扫描或螺旋来完成凹陷。",
      "El fresado dentro del contorno no es pasante,\r\n" +  // ES
          "en casos donde el diámetro de la fresa no es suficiente\r\n" +
          "y es necesario terminar la depresión mediante escaneo o en espiral",
      "Le fraisage à l'intérieur du contour n'est pas traversant,\r\n" +  // FR
          "dans les cas où le diamètre de la fraise n'est pas suffisant\r\n" +
          "et il est nécessaire de terminer la dépression par balayage ou en spirale",
      "Kontur içindeki frezeleme geçmeli değildir,\r\n" +  // TR
          "frezin çapının yeterli olmadığı durumlarda\r\n" +
          "ve çukurun tarama veya spiral şeklinde bitirilmesi gerekir"};

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
           "这意味着在继续加工的情况下停止机器以翻转零件",
      "Fresado desde la parte inferior de la pieza.\r\n " +  // ES
          "Solo para fresado vertical no pasante.\r\n" +
          "Implica detener la máquina para voltear la pieza\r\n" +
          "con la continuación del procesamiento",
      "Fraisage depuis le bas de la pièce.\r\n " +  // FR
          "Pour le fraisage vertical non traversant uniquement.\r\n" +
          "Cela implique l'arrêt de la machine pour retourner la pièce\r\n" +
          "avec la poursuite du traitement",
      "Parçanın altından frezeleme.\r\n " +  // TR
          "Yalnızca dikey, geçmeli olmayan frezeleme için.\r\n" +
          "İşlemin devamı ile parçayı çevirmek için makineyi durdurmayı gerektirir"};

    public static readonly string[] InfoLayerMillSwivel = {
      "Milling a flat inclined surface on a 5-axis machine",
      "Фрезеровка плоской наклонной поверхности на 5и-координатном станке",
      "Fresatura di una superficie piana inclinata",
      "Fräsen einer ebenen geneigten Fläche",
      "在 5 轴机床上铣削一个平坦的斜面",
      "Fresado de una superficie plana inclinada en una máquina de 5 ejes",  // ES
      "Fraisage d'une surface plane inclinée sur une machine 5 axes",  // FR
      "5 eksenli makinede düz eğimli yüzey frezeleme"};  // TR

    public static readonly string[] InfoLayerMillImpassable = {
      "Milling the dado does not work - the contour has a narrow spot, thinner than the cutter",
      "Фрезерование паза не получается - контур имеет узкое место, тоньше чем фреза",
      "La fresatura della scanalatura non funziona: il contorno ha un punto stretto, più sottile della fresa",
      "Das Fräsen der Nut funktioniert nicht - die Kontur hat eine schmale Stelle, die dünner als der Fräser ist",
      "铣削墙裙不起作用 - 轮廓有一个窄点，比刀具更薄",
      "El fresado de la ranura no funciona - el contorno tiene un punto estrecho, más delgado que la fresa",  // ES
      "Le fraisage de la rainure ne fonctionne pas - le contour a un point étroit, plus fin que la fraise",  // FR
      "Yuva frezeleme çalışmıyor - kontur frezeden daha ince dar bir noktaya sahip"};  // TR

    public static readonly string[] InfoLayerDrillBlind = {
      "Blind hole drilling in Z axis",
      "Сверление глухого отверстия по оси Z",
      "Esecuzione di fori ciechi sull'asse Z.",
      "Sacklochbohren in der Z-Achse",
      "盲孔钻 Z 轴",
      "Perforación de agujero ciego en el eje Z",  // ES
      "Perçage de trou borgne sur l'axe Z",  // FR
      "Z ekseninde kör delik delme"};  // TR

    public static readonly string[] InfoLayerDrillThrough = {
      "Drilling a through hole in the Z axis",
      "Сверление сквозного отверстия по оси Z",
      "Esecuzione di un foro passante sull'asse Z.",
      "Bohren eines Durchgangslochs in der Z-Achse",
      "沿 Z 轴钻一个通孔",
      "Perforación de un agujero pasante en el eje Z",  // ES
      "Perçage d'un trou traversant sur l'axe Z",  // FR
      "Z ekseninde geçmeli delik delme"};  // TR

    public static readonly string[] InfoLayerDrillLateral = {
      "Drilling from the side of the part, to the end",
      "Сверление сбоку детали, в торец",
      "Foratura dal lato del pezzo, fino alla fine",
      "Bohren von der Seite des Teils bis zum Ende",
      "在零件的侧面钻孔，最后",
      "Perforación desde el lado de la pieza, hasta el extremo",  // ES
      "Perçage depuis le côté de la pièce, jusqu'à l'extrémité",  // FR
      "Parçanın yan tarafından delme, uca kadar"};  // TR

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
           "假设机器停止工作以翻转零件并继续加工。",
      "Perforación de un agujero ciego desde la parte inferior de la pieza a lo largo del eje Z.\r\n" +  // ES
          "Se asume que la máquina deja de funcionar para voltear la pieza y continúa mecanizando.",
      "Perçage d'un trou borgne depuis le bas de la pièce le long de l'axe Z.\r\n" +  // FR
          "Il est supposé que la machine cesse de fonctionner pour retourner la pièce et continue l'usinage.",
      "Parçanın altından Z ekseni boyunca kör delik delme.\r\n" +  // TR
          "Makine parçayı çevirmek için durup işlemeye devam eder varsayılır."};

    public static readonly string[] InfoLayerDrillSwivel = {
      "Drilling at an angle to the vertical",
      "Сверление под углом к вертикали на 5и-координатном станке",
      "Foratura ad angolo rispetto alla verticale",
      "Bohren in einem Winkel zur Vertikalen",
      "在 5 轴机床上与垂直方向成一定角度钻孔",
      "Perforación en ángulo con respecto a la vertical",  // ES
      "Perçage en angle par rapport à la verticale",  // FR
      "Dikeyye açılı delme"};  // TR

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
           "该槽的铣削轮廓将被删除。",
      "Aserrado de una ranura recta (no pasante).\r\n" +  // ES
          "El programa buscará ranuras rectas a través de toda la pieza con un ancho de 1 a 2 espesores del disco.\r\n" +
          "Se trazarán 1 o dos líneas a lo largo del eje del disco.\r\nEl contorno de fresado de esta ranura se eliminará.",
      "Sciage d'une rainure droite (non traversante).\r\n" +  // FR
          "Le programme recherchera des rainures droites à travers toute la pièce avec une largeur de 1 à 2 épaisseurs du disque.\r\n" +
          "1 ou deux lignes seront tracées le long de l'axe du disque.\r\nLe contour de fraisage de cette rainure sera supprimé.",
      "Düz yuva kesimi (geçmeli değil).\r\n" +  // TR
          "Program, 1 ila 2 disk kalınlığı genişliğinde parçanın tamamında düz yuvalar arayacaktır.\r\n" +
          "Disk ekseni boyunca 1 veya iki çizgi çizilecektir.\r\nBu yuvanın frezeleme konturu silinecektir."};

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
           "保留所有铣削轮廓。",
      "Aserrado a través de una pieza\r\n" +  // ES
          "El programa buscará extremos lineales alrededor del perímetro de la pieza.\r\n" +
          "Se creará una línea en el centro del disco.\r\n" +
          "Se conservan todos los contornos de fresado.",
      "Sciage à travers une pièce\r\n" +  // FR
          "Le programme recherchera des extrémités linéaires autour du périmètre de la pièce.\r\n" +
          "Une ligne sera créée au centre du disque.\r\n" +
          "Tous les contours de fraisage sont conservés.",
      "Parçadan geçen kesim\r\n" +  // TR
          "Program, parçanın çevresi etrafında doğrusal uçlar arayacaktır.\r\n" +
          "Diskin merkezinde bir çizgi oluşturulacaktır.\r\n" +
          "Tüm frezeleme konturları korunur."};

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
           "假设机器停止工作翻转零件并继续加工",
      "Aserrado de una ranura recta (no pasante) desde la parte inferior de la pieza.\r\n" +  // ES
          "Se asume que la máquina deja de funcionar para voltear la pieza y continúa mecanizando",
      "Sciage d'une rainure droite (non traversante) depuis le bas de la pièce.\r\n" +  // FR
          "Il est supposé que la machine cesse de fonctionner pour retourner la pièce et continue l'usinage",
      "Parçanın altından düz yuva kesimi (geçmeli değil).\r\n" +  // TR
          "Makine parçayı çevirmek için durup işlemeye devam eder varsayılır"};

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
           "保留所有铣削轮廓。",
      "Aserrado con el disco inclinado hacia la vertical en una máquina de 5 ejes.\r\n" +  // ES
          "Para superficies inclinadas hacia arriba.\r\n" +
          "La línea de sierra se trazará sin desplazamiento.\r\n" +
          "Se requiere corrección del espesor de la herramienta.\r\n" +
          "Se conservan todos los contornos de fresado.",
      "Sciage avec le disque incliné vers la verticale sur une machine 5 axes.\r\n" +  // FR
          "Pour les surfaces inclinées vers le haut.\r\n" +
          "La ligne de scie sera tracée sans décalage.\r\n" +
          "Correction de l'épaisseur de l'outil requise.\r\n" +
          "Tous les contours de fraisage sont conservés.",
      "5 eksenli makinede diski dikeye eğik olarak kesme.\r\n" +  // TR
          "Yukarı eğimli yüzeyler için.\r\n" +
          "Testere çizgisi ofsetsiz çizilecektir.\r\n" +
          "Takım kalınlığı düzeltmesi gereklidir.\r\n" +
          "Tüm frezeleme konturları korunur."};

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
           "对于向下倾斜的面。",
      "Aserrado con el disco inclinado hacia la vertical. \r\n" +  // ES
          "Para caras inclinadas hacia abajo.",
      "Sciage avec le disque incliné vers la verticale. \r\n" +  // FR
          "Pour les faces inclinées vers le bas.",
      "Diski dikeye eğik olarak kesme. \r\n" +  // TR
          "Aşağı eğimli yüzeyler için."};

    public static readonly string[] InfoLayerSizeRectangle = {
      "Conditional rectangular contour of the workpiece to the size of the dimensions of the part",
      "Условный прямоугольный контур заготовки в размер габаритов детали",
      "Contorno rettangolare condizionale del pezzo in lavorazione alla dimensione delle dimensioni della parte",
      "Bedingte rechteckige Kontur des Werkstücks auf die Größe der Abmessungen des Teils",
      "有条件的工件矩形轮廓到零件尺寸的大小",
      "Contorno rectangular condicional de la pieza en bruto al tamaño de las dimensiones de la pieza",  // ES
      "Contour rectangulaire conditionnel de la pièce brute à la taille des dimensions de la pièce",  // FR
      "İş parçasının parça boyutlarına göre koşullu dikdörtgen konturu"};  // TR

    public static readonly string[] InfoLayerTop = {
      "Top plane contour of the top plane near the conical end or other complex surface. For 5-axis machining",
      "Контур верхней плоскости около конического торца или другой сложной поверхности. Для пяти-координатной обработки",
      "Contorno del piano superiore vicino all'estremità rastremata. Per la lavorazione a 5 assi",
      "Kontur der oberen Ebene in der Nähe des sich verjüngenden Endes. Für 5-Achs-Bearbeitung",
      "靠近圆锥端或其他复杂曲面的顶面轮廓。 用于5轴加工",
      "Contorno del plano superior cerca del extremo cónico u otra superficie compleja. Para mecanizado de 5 ejes",  // ES
      "Contour du plan supérieur près de l'extrémité conique ou autre surface complexe. Pour l'usinage 5 axes",  // FR
      "Konik uç veya diğer karmaşık yüzey yakınındaki üst düzlem konturu. 5 eksenli işleme için"};  // TR

    public static readonly string[] InfoLayerBottom = {
      "The contour of the bottom plane near the conical end or other complex surface. For 5-axis machining",
      "Контур нижней плоскости около конического торца или другой сложной поверхности. Для пяти-координатной обработки",
      "Il contorno del piano inferiore vicino all'estremità conica. Per la lavorazione a 5 assi",
      "Die Kontur der unteren Ebene nahe dem konischen Ende. Für 5-Achs-Bearbeitung",
      "靠近圆锥端或其他复杂曲面的底面轮廓。 用于5轴加工",
      "El contorno del plano inferior cerca del extremo cónico u otra superficie compleja. Para mecanizado de 5 ejes",  // ES
      "Le contour du plan inférieur près de l'extrémité conique ou autre surface complexe. Pour l'usinage 5 axes",  // FR
      "Konik uç veya diğer karmaşık yüzey yakınındaki alt düzlem konturu. 5 eksenli işleme için"};  // TR

    public static readonly string[] InfoLayerOther = {
      "Other visible ribs and silhouettes of complex surfaces",
      "Прочие видимые ребра и силуэты сложных поверхностей",
      "Altre nervature visibili e sagome di superfici complesse",
      "Andere sichtbare Rippen und Silhouetten komplexer Oberflächen",
      "复杂表面的其他可见筋和轮廓",
      "Otras nervaduras visibles y siluetas de superficies complejas",  // ES
      "Autres nervures visibles et silhouettes de surfaces complexes",  // FR
      "Karmaşık yüzeylerin diğer görünür kaburgaları ve siluetleri"};  // TR

    public static readonly string[] InfoLayerHidden = {
      "Other invisible edges, impassable bottom dadoes and invisible silhouettes of complex surfaces",
      "Прочие невидимые ребра, непроходимые выборки снизу и невидимые силуэты сложных поверхностей",
      "Altre nervature invisibili, solchi impraticabili sotto e sagome invisibili di superfici complesse",
      "Andere unsichtbare Rippen, undurchdringliche Rillen darunter und unsichtbare Silhouetten komplexer Oberflächen",
      "其他不可见的边缘、无法通行的裙边和复杂表面的不可见轮廓",
      "Otros bordes invisibles, ranuras inferiores impasables y siluetas invisibles de superficies complejas",  // ES
      "Autres bords invisibles, rainures inférieures infranchissables et silhouettes invisibles de surfaces complexes",  // FR
      "Diğer görünmez kenarlar, geçilmez alt yuvalar ve karmaşık yüzeylerin görünmez siluetleri"};  // TR

    public static readonly string[] CornerAsIs = {
      "As is",
      "не делать",
      "Non fare niente",
      "Tu nichts",
      "原样",
      "Como está",                                      // ES
      "Tel quel",                                      // FR
      "Olduğu gibi"};                                  // TR

    public static readonly string[] CornerIC = {
      "Inside corner",
      "Заход в угол",
      "Angoli Interni",
      "Innere Ecke",
      "内角",
      "Esquina interior",                              // ES
      "Coin intérieur",                                // FR
      "İç köşe"};                                      // TR

    public static readonly string[] CornerFillet = {
      "Fillet",
      "Скругление",
      "Raccordo",
      "Abrunden",
      "四舍五入",
      "Redondeo",                                      // ES
      "Congé",                                         // FR
      "Pah kırma"};                                    // TR

    public static readonly string[] Bisector = {
      "bisector",
      "биссектриса",
      "bisettrice",
      "Halbierende",
      "平分线",
      "bisectriz",                                     // ES
      "bissectrice",                                   // FR
      "açıortay"};                                     // TR

    public static readonly string[] LongSide = {
      "long side",
      "длинная сторона",
      "lato lungo",
      "Längsseite",
      "长边",
      "lado largo",                                    // ES
      "côté long",                                     // FR
      "uzun kenar"};                                   // TR

    public static readonly string[] ShortSide = {
      "short side",
      "короткая сторона",
      "lato corto",
      "kurze Seite",
      "短边",
      "lado corto",                                    // ES
      "côté court",                                    // FR
      "kısa kenar"};                                   // TR

    public static readonly string[] DefDirTypes = {
      "Through;Above;Under;H_left;H_front;H_right;H_back;H_other;Swivel",
      "скв.;лиц.;тыл;торц.;торц.;торц.;торц.;торц.;накл.",
      "Attraverso;Sopra;Sotto;H sinistra;H anteriore;H destra;H indietro;H altro;Girevole",
      "Durch;Oben;Unter;H links;H vorne;H richtig;H zurück;H andere;Schwenken",
      "通过;以上;在下面;H_left;H_front;H_right;H_back;H_other;旋转",
      "Pasante;Arriba;Abajo;H_izq;H_frente;H_der;H_atrás;H_otro;Giratorio",  // ES
      "Traversant;Au-dessus;En dessous;H_gauche;H_avant;H_droite;H_arrière;H_autre;Pivotant",  // FR
      "Geçmeli;Üst;Alt;H_sol;H_ön;H_sağ;H_arka;H_diğer;Döner"};  // TR

    public static readonly string[] DefSlope = {
      "Slope %angle%°%down%",
      "Угол %angle%°%down%",
      "Inclinazione %angle%°%down%",
      "Neigung %angle%°%down%",
      "坡 %angle%°%down%",
      "Pendiente %angle%°%down%",                      // ES
      "Pente %angle%°%down%",                          // FR
      "Eğim %angle%°%down%"};                          // TR

    public static readonly string[] DefSlopeDownward = {
      " downward",
      " снизу",
      " dal basso",
      " von unten",
      " 向下",
      " hacia abajo",                                  // ES
      " vers le bas",                                  // FR
      " aşağı"};                                       // TR

    public static readonly string[] Countersink = {
      "countersink",
      "зенковать",
      "svasatore",
      "versenken",
      "埋头孔",
      "avellanado",                                    // ES
      "fraisure",                                      // FR
      "havşa"};                                        // TR

    public static readonly string[] GetDepth = {
      "Enter depth for layer name",
      "Введите глубину для имени слоя",
      "Inserisci la profondità per il nome del layer",
      "Geben Sie die Tiefe für den Layer-Namen ein",
      "输入深度以将其插入图层名称",
      "Ingrese la profundidad para el nombre de la capa",  // ES
      "Entrez la profondeur pour le nom du calque",   // FR
      "Katman adı için derinlik girin"};              // TR

    public static readonly string[] SelectContours = {
      "Select the objects to search for the outside contour",
      "Выберите объекты для поиска наружного контура",
      "Seleziona gli oggetti per cercare il contorno esterno",
      "Wählen Sie die Objekte aus, die nach der Außenkontur gesucht werden sollen",
      "选择要搜索外轮廓的对象",
      "Seleccione los objetos para buscar el contorno exterior",  // ES
      "Sélectionnez les objets pour rechercher le contour extérieur",  // FR
      "Dış kontur aramak için nesneleri seçin"};      // TR

    public static string[] SelectPolylines = {
      "\n Select polylines",
      "\n Выберите полилинии",
      "\n Selezionare polilinee",
      "\n Wählen Sie ein beliebiges Polylinien",
      "\n 选择任意折线",
      "\n Seleccione polilíneas",                      // ES
      "\n Sélectionnez des polylignes",                // FR
      "\n Poliçizgileri seçin"};                       // TR

    public static string[] ProcessedPolylines = {
      "  Polylines processed: {0}. Removed nodes: {1}",
      "  Обработано полилиний: {0}. Удалено узлов: {1}",
      "  Polilinee elaborate: {0}. Nodi rimossi: {1}",
      "  Verarbeitete Polylinien: {0}. Entfernte Knoten: {1}",
      "  已处理的折线：{0}。 删除的节点：{1}",
      "  Polilíneas procesadas: {0}. Nodos eliminados: {1}",  // ES
      "  Polylignes traitées : {0}. Nœuds supprimés : {1}",  // FR
      "  İşlenen poliçizgiler: {0}. Kaldırılan düğümler: {1}"};  // TR

    public static readonly string[] Knots = {
      "  {0} isolated knots were found that can be processed individually.",
      "  Обнаружено {0} изолированных узлов, которые можно обрабатывать по отдельности.",
      "  Sono stati trovati {0} nodi isolati che possono essere elaborati singolarmente.",
      "  Es wurden {0} isolierte Knoten gefunden, die einzeln verarbeitet werden können.",
      "发现 {0} 个孤立的结，可以单独处理。",
      "  Se encontraron {0} nudos aislados que se pueden procesar individualmente.",  // ES
      "  {0} nœuds isolés ont été trouvés qui peuvent être traités individuellement.",  // FR
      "  Ayrı ayrı işlenebilecek {0} izole düğüm bulundu."};  // TR

    public static readonly string[] SaveContours = {
      "Save contours",
      "Сохранение контуров",
      "Salvataggio dei contorni",
      "Konturen speichern",
      "轮廓保存",
      "Guardar contornos",                             // ES
      "Enregistrer les contours",                     // FR
      "Konturları kaydet"};                            // TR

    public static readonly string[] CreatedLoops = {
      "Created loops: {0}",
      "Создано петель: {0}",
      "Ciclo creati: {0}",
      "Erstellte Schleifen: {0}",
      "创建的循环：{0}",
      "Bucles creados: {0}",                           // ES
      "Boucles créées : {0}",                          // FR
      "Oluşturulan döngüler: {0}"};                    // TR

    public static readonly string[] Optimization = {
      "  Optimization of contour",
      "  Оптимизация контура",
      "  Ottimizzazione del contorno",
      "  Konturoptimierung",
      "  轮廓优化",
      "  Optimización de contorno",                    // ES
      "  Optimisation du contour",                     // FR
      "  Kontur optimizasyonu"};                       // TR

    public static readonly string[] Contouring = {
      "Contouring",
      "Обработка контуров",
      "Elaborazione dei contorni",
      "Konturverarbeitung",
      "轮廓",
      "Contorneado",                                   // ES
      "Contournage",                                   // FR
      "Konturlama"};                                   // TR

    public static readonly string[] NoViewport = {
      "There is not a single solid in the viewport",
      "В видовом экране нет ни одного солида",
      "La finestra No Solidus",
      "Das Ansichtsfenster enthält keinen Volumenkörper",
      "视口中没有一个实体",
      "No hay un solo sólido en la ventana gráfica",   // ES
      "Il n'y a pas un seul solide dans la fenêtre",  // FR
      "Görünümde tek bir katı yok"};                   // TR

    public static readonly string[] Found = {
      "Found details {0}",
      "Найдено деталей {0}",
      "Trovati i dettagli {0}",
      "Teile gefunden {0}",
      "找到详细信息 {0}",
      "Detalles encontrados {0}",                      // ES
      "Détails trouvés {0}",                           // FR
      "Bulunan detaylar {0}"};                         // TR

    public static readonly string[] DiameterInfo = {
      "  A cutter diameter {0} is specified. The holes of such a diameter and less are considered as a drill",
      "  Задана фреза {0}. Отверстия такого диаметра и меньше рассматриваем как сверловку",
      "  L'insieme della taglierina {0}. I fori di tale diametro e meno sono considerati come un trapano",
      "  Die Mühle {0} ist angegeben. Löcher mit diesem Durchmesser und weniger gelten als Bohren",
      "  指定了刀具直径 {0}。 这种直径或更小的孔被认为是钻头",
      "  Se especifica un diámetro de fresa {0}. Los agujeros de tal diámetro y menores se consideran como perforación",  // ES
      "  Un diamètre de fraise {0} est spécifié. Les trous de ce diamètre et moins sont considérés comme un perçage",  // FR
      "  Bir freze çapı {0} belirtildi. Bu çaptaki ve daha küçük delikler delme olarak kabul edilir"};  // TR

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
      "在此绘图中找不到'{0}'块。\r\n" +
         "'{1}' 模板中也缺少它。\r\n" +
         "这个和其他类似的块的使用将被禁用。",
      "No se pudo encontrar el bloque '{0}' en este dibujo.\r\n" +  // ES
        "También falta en la plantilla '{1}'.\r\n" +
        "Se deshabilitará el uso de este y otros bloques similares.",
      "Le bloc '{0}' n'a pas pu être trouvé dans ce dessin.\r\n" +  // FR
        "Il manque également dans le modèle '{1}'.\r\n" +
        "L'utilisation de ce bloc et d'autres blocs similaires sera désactivée.",
      "'{0}' bloğu bu çizimde bulunamadı.\r\n" +  // TR
        "'{1}' şablonunda da eksik.\r\n" +
        "Bu ve diğer benzer blokların kullanımı devre dışı bırakılacaktır."};

    public static string[] Sizing = {
      "Sizing",
      "Простановка размеров",
      "Dimensionamento",
      "Bemaßung",
      "尺寸标注",
      "Acotado",                                       // ES
      "Cotation",                                      // FR
      "Ölçülendirme"};                                 // TR

    public static string[] NoSolid = {
      "There is not a single solid or curve",
      "Нет ни одного солида или кривой",
      "Non esiste un singolo solido o curva",
      "Es gibt keinen Volumenkörper oder eine Kurve",
      "没有单一的实体或曲线",
      "No hay un solo sólido o curva",                 // ES
      "Il n'y a pas un seul solide ou courbe",        // FR
      "Tek bir katı veya eğri yok"};                   // TR

    public static readonly string[] SelectDado = {
      "Select objects for dado loop: ",
      "Выберете объекты контура выборки: ",
      "Seleziona gli oggetti del contorno di selezione: ",
      "Wählen Sie die Objekte der Auswahlkontur aus: ",
      "选择选择轮廓对象：",
      "Seleccione objetos para el contorno de ranura: ",  // ES
      "Sélectionnez les objets pour le contour de rainure : ",  // FR
      "Yuva konturu için nesneleri seçin: "};  // TR

    public static readonly string[] OutsideErr = {
      "Main (outside) contour of detail not found",
      "Основной (внешний) контур детали не найден",
      "Il contorno principale (esterno) della parte non è stato trovato",
      "Die Hauptkontur (Außenkontur) des Teils wurde nicht gefunden",
      "未找到零件的主（外）轮廓",
      "No se encontró el contorno principal (exterior) de la pieza",  // ES
      "Contour principal (extérieur) de la pièce introuvable",  // FR
      "Parçanın ana (dış) konturu bulunamadı"};  // TR

    public static readonly string[] FewOutsideErr = {
      "Found a few outside contours of detail",
      "Найдено несколько контуров деталей",
      "Sono stati trovati diversi contorni delle parti",
      "Mehrere Teilkonturen gefunden",
      "发现多个零件轮廓",
      "Se encontraron varios contornos exteriores de la pieza",  // ES
      "Plusieurs contours extérieurs de la pièce trouvés",  // FR
      "Parçanın birkaç dış konturu bulundu"};  // TR

    public static readonly string[] DDLClosedErr =
    {
      "Program works only with open contours - the edges of the dadoes inside the part contour.",
      "Программа работает только с незамкнутыми контурами - краями пазов внутри контура детали.",
      "Il programma funziona solo con contorni aperti - i bordi delle scanalature all'interno del contorno della parte.",
      "Das Programm arbeitet nur mit offenen Konturen - den Kanten der Nuten innerhalb der Kontur des Teils.",
      "程序仅适用于开放轮廓 - 零件轮廓内的凹槽边缘。",
      "El programa funciona solo con contornos abiertos: los bordes de las ranuras dentro del contorno de la pieza.",  // ES
      "Le programme ne fonctionne qu'avec des contours ouverts - les bords des rainures à l'intérieur du contour de la pièce.",  // FR
      "Program yalnızca açık konturlarla çalışır - parçanın konturu içindeki yuvaların kenarları."};  // TR

    public static readonly string[] CloseErr = {
      "Unable to determine the part of main (outside) contour to close this loop.\r\n" +
        "Check the points of intersection",
      "Не удалось определить часть основного (внешнего) контура, чтоб замкнуть этот контур.\r\n" +
        "Проверьте точки пересечения",
      "Non è stato possibile determinare parte del circuito principale (esterno) per chiudere questo circuito.\r\n" +
        "Controlla i punti di intersezione",
      "Es war nicht möglich, einen Teil des Hauptstromkreises (externen Stromkreises) zum Schließen dieses Stromkreises zu bestimmen.\r\n" +
        "Überprüfen Sie die Schnittpunkte",
      "未能定义主（外）轮廓的一部分以关闭此轮廓。\r\n" +
         "检查交叉点",
      "No se pudo determinar la parte del contorno principal (exterior) para cerrar este bucle.\r\n" +  // ES
        "Verifique los puntos de intersección",
      "Impossible de déterminer la partie du contour principal (extérieur) pour fermer cette boucle.\r\n" +  // FR
        "Vérifiez les points d'intersection",
      "Bu döngüyü kapatmak için ana (dış) konturun bir parçası belirlenemedi.\r\n" +  // TR
        "Kesişim noktalarını kontrol edin"};

    public static readonly string[] NotPass = {
      "It looks like dado does not pass a given cutter!\r\n" +
        "Check it. The circuit in red.",
      "Похоже паз не проходим заданной фрезой!\r\n" +
        "Проверьте. Контур выделен красным.",
      "Sembra che la scanalatura non passi attraverso la fresa data!\r\n" +
        "Dai un'occhiata. Il contorno è evidenziato in rosso.",
      "Es sieht so aus, als würde die Nut nicht durch den gegebenen Fräser gehen!\r\n" +
        "Schau es dir an. Der Umriss ist rot hervorgehoben.",
      "使用给定的刀具似乎无法通过凹槽！\r\n" +
         "检查。轮廓以红色突出显示。",
      "¡Parece que la ranura no pasa con la fresa dada!\r\n" +  // ES
        "Verifíquelo. El contorno está resaltado en rojo.",
      "Il semble que la rainure ne passe pas avec la fraise donnée !\r\n" +  // FR
        "Vérifiez-le. Le contour est mis en surbrillance en rouge.",
      "Yuva verilen frez ile geçmiyor gibi görünüyor!\r\n" +  // TR
        "Kontrol edin. Kontur kırmızı ile vurgulanmıştır."};

    public static readonly string[] CheckErr = {
      "The program can automatically check for continuity contour for milling.\r\n" +
        "Check it! The circuit in red.",
      "Программа не может автоматически проверить контур на проходимость фрезы.\r\n" +
        "Проверьте! Контур выделен красным.",
      "Il programma non può controllare automaticamente il profilo per la passabilità della taglierina.\r\n" +
        "Dai un'occhiata! Il contorno è evidenziato in rosso.",
      "Das Programm kann die Kontur nicht automatisch auf Passierbarkeit des Fräsers überprüfen.\r\n" +
        "Probieren Sie es aus! Der Umriss ist rot hervorgehoben.",
      "程序无法自动检查轮廓是否能通过刀具。\r\n" +
         "检查！轮廓以红色突出显示。",
      "El programa no puede verificar automáticamente la continuidad del contorno para fresado.\r\n" +  // ES
        "¡Verifíquelo! El contorno está resaltado en rojo.",
      "Le programme ne peut pas vérifier automatiquement la continuité du contour pour le fraisage.\r\n" +  // FR
        "Vérifiez-le ! Le contour est mis en surbrillance en rouge.",
      "Program frezeleme için kontur sürekliliğini otomatik olarak kontrol edemiyor.\r\n" +  // TR
        "Kontrol edin! Kontur kırmızı ile vurgulanmıştır."};

    public static readonly string[] TwoErr = {
      "Unacceptable to choose once more than two contours (polylines)",
      "Недопустимо выбирать более двух контуров (полилиний) сразу",
      "È inaccettabile selezionare più di due contorni (polilinee) contemporaneamente",
      "Es ist nicht akzeptabel, mehr als zwei Konturen (Polylinien) gleichzeitig auszuwählen",
      "不允许同时选择两个以上的轮廓（折线）",
      "Es inaceptable seleccionar más de dos contornos (polilíneas) a la vez",  // ES
      "Il est inacceptable de sélectionner plus de deux contours (polylignes) à la fois",  // FR
      "Bir seferde ikiden fazla kontur (poliçizgi) seçmek kabul edilemez"};  // TR

    public static readonly string[] NeedContour = {
      "Need to select 1 or 2 contour from lines, arcs or splines",
      "Надо было выбрать 1 или 2 контура из линий, дуг и сплайнов",
      "Era necessario scegliere 1 o 2 contorni da linee, archi e spline",
      "Es war notwendig, 1 oder 2 Konturen aus Linien, Bögen und Splines auszuwählen",
      "有必要从直线、圆弧和样条曲线中选择 1 或 2 个轮廓",
      "Es necesario seleccionar 1 o 2 contornos de líneas, arcos o splines",  // ES
      "Il faut sélectionner 1 ou 2 contours à partir de lignes, arcs ou splines",  // FR
      "Çizgiler, yaylar veya spline'lardan 1 veya 2 kontur seçmek gerekir"};  // TR

    public static readonly string[] SearchOutside = {
      "Search the outside contour",
      "Поиск наружного контура",
      "Cerca il contorno esterno",
      "Suchen Sie die Außenkontur",
      "寻找外轮廓",
      "Buscar el contorno exterior",  // ES
      "Rechercher le contour extérieur",  // FR
      "Dış konturu ara"};  // TR

    public static readonly string[] LayStyle = {
      "  LAY-style will be used: {0}",
      "  Будет использован стиль Выкладки: {0}",
      "  LAY-stile sarà usato: {0}",
      "  Der Lay-stil wird verwendet: {0}",
      "  将使用布局(LAY)样式：{0}",
      "  Se utilizará el estilo LAY: {0}",  // ES
      "  Le style LAY sera utilisé : {0}",  // FR
      "  LAY stili kullanılacak: {0}"};  // TR

    public static readonly string[] CncStyle = {
      "  CNC-style will be used: {0}",
      "  Будет использован стиль ЧПУ: {0}",
      "  CNC-stile sarà usato: {0}",
      "  Der CNC-stil wird verwendet: {0}",
      "  将使用 CNC 样式：{0}",
      "  Se utilizará el estilo CNC: {0}",  // ES
      "  Le style CNC sera utilisé : {0}",  // FR
      "  CNC stili kullanılacak: {0}"};  // TR

    public static readonly string[] DxfStyle = {
      "  DXF-style will be used: {0}",
      "  Будет использован стиль DXF: {0}",
      "  DXF-stile sarà usato: {0}",
      "  Der DXF-stil wird verwendet: {0}",
      "  将使用 DXF 样式：{0}",
      "  Se utilizará el estilo DXF: {0}",  // ES
      "  Le style DXF sera utilisé : {0}",  // FR
      "  DXF stili kullanılacak: {0}"};  // TR

    public static readonly string[] DimStyle = {
      "  Dimensions-style will be used: {0}",
      "  Будет использован стиль размеров: {0}",
      "  Dimensioni-stile sarà usato: {0}",
      "  Dimensionaler-stil wird verwendet: {0}",
      "  将使用尺寸样式(DimDet)：{0}",
      "  Se utilizará el estilo de dimensiones: {0}",  // ES
      "  Le style de dimensions sera utilisé : {0}",  // FR
      "  Boyut stili kullanılacak: {0}"};  // TR

    public static readonly string[] CornerActivated = {
      "Temporarily turned on corner processing on all contours",
      "Временно включена обработка углов на всех контурах",
      "Temporaneamente attivato l'elaborazione degli angoli su tutti i contorni",
      "Eckenbearbeitung für alle Konturen vorübergehend aktiviert",
      "暂时打开所有轮廓的拐角处理",
      "Procesamiento de esquinas activado temporalmente en todos los contornos",  // ES
      "Traitement des coins temporairement activé sur tous les contours",  // FR
      "Tüm konturlarda köşe işleme geçici olarak açıldı"};  // TR

    public static readonly string[] SelectFile = {
      "Select drawing files with 2D outlines",
      "Выберите файлы чертежей с 2D-контурами",
      "Selezionare quadri con contorni 2D",
      "Wählen Sie Zeichnungsdateien mit 2D-Konturen aus",
      "选择具有 2D 轮廓的工程图文件",
      "Seleccione archivos de dibujo con contornos 2D",  // ES
      "Sélectionnez des fichiers de dessin avec des contours 2D",  // FR
      "2D konturları olan çizim dosyalarını seçin"};  // TR

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
      "轮廓优化和 CNC 准备",
      "Optimización de contornos y preparación CNC",  // ES
      "Optimisation des contours et préparation CNC",  // FR
      "Kontur optimizasyonu ve CNC hazırlığı"};  // TR

    public static readonly string[] AddEntryPoint = {
      "Add entry point",
      "Точка входа",
      "Punto d'entrata",
      "Eingangspunkt",
      "入口点",
      "Agregar punto de entrada",  // ES
      "Ajouter un point d'entrée",  // FR
      "Giriş noktası ekle"};  // TR

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
        "以便刀具进入零件（额外的多段线段）。",
      "Agregar un punto en la sección recta más grande de contornos cerrados para permitir que la fresa entre en la pieza\r\n" +  // ES
        "(segmento de polilínea adicional).",
      "Ajouter un point sur la section droite la plus grande des contours fermés pour permettre à la fraise d'entrer dans la pièce\r\n" +  // FR
        "(segment de polyligne supplémentaire).",
      "Frezenin parçaya girmesine izin vermek için kapalı konturların en büyük düz bölümüne bir nokta ekleyin\r\n" +  // TR
        "(ekstra poliçizgi segmenti)."};

    public static readonly string[] AllowSymbols = {
      "Allow Symbols",
      "Спецсимволы",
      "Consenti simboli",
      "Symbole zulassen",
      "允许符号",
      "Permitir símbolos",  // ES
      "Autoriser les symboles",  // FR
      "Sembollere izin ver"};  // TR

    public static readonly string[] AllowSymbolsTip = {
      "Allow to use symbols like ¼ ¾ ½ Ø... for conversion size to string",
      "Разрешить использовать символы типа ¼ ¾ ½ Ø ... для преобразования размера в строку",
      "Permetti di usare simboli come ¼ ¾ ½ Ø ... per le dimensioni della conversione in stringa",
      "Erlauben Sie die Verwendung von Symbolen wie ¼ ¾ ½ Ø ... \r\n" +
        "für die Konvertierung der Größe in eine Zeichenfolge",
      "允许使用 ¼ ¾ ½ Ø... 等符号将大小转换为字符串",
      "Permitir el uso de símbolos como ¼ ¾ ½ Ø... para la conversión de tamaño a cadena",  // ES
      "Autoriser l'utilisation de symboles comme ¼ ¾ ½ Ø... pour la conversion de taille en chaîne",  // FR
      "¼ ¾ ½ Ø... gibi sembollerin boyutu dizeye dönüştürmek için kullanılmasına izin ver"};  // TR

    public static readonly string[] Annotate = {
      "Dimensions for NCP",
      "Размеры для NCP",
      "Dimensioni per NCP",
      "Abmessungen für NCP",
      "NCP 的尺寸",
      "Dimensiones para NCP",  // ES
      "Dimensions pour NCP",  // FR
      "NCP için boyutlar"};  // TR

    public static readonly string[] AnnotateTip = {
      "The NC Prepare command will place dimensions and leaders on the parts.",
      "Команда NCPrepare будет расставлять размеры и выноски на деталях.",
      "NCPrepare posizionerà quote e didascalie sulle parti.",
      "Das NCPrepare-Team platziert Bemaßungen und Führungen auf den Teilen.",
      "NCPrepare 程序将在零件上放置尺寸和引线。",
      "El comando NC Prepare colocará dimensiones y directrices en las piezas.",  // ES
      "La commande NC Prepare placera des dimensions et des lignes de repère sur les pièces.",  // FR
      "NC Prepare komutu parçalara boyutlar ve işaret çizgileri yerleştirecektir."};  // TR

    public static readonly string[] CloseArcs = {
      "Close arcs to circles",
      "Замыкать дуги в круг",
      "Chiudi gli archi in cerchi",
      "Bögen zu einem Kreis schließen",
      "将圆弧闭合成一个圆",
      "Cerrar arcos en círculos",  // ES
      "Fermer les arcs en cercles",  // FR
      "Yayları çemberlere kapat"};  // TR

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
        "命令的情况下立即将选择轮廓（圆弧）闭合成一个完整的圆。",
      "Transformar arcos casi cerrados en un círculo. \r\n" +  // ES
        "Esto es útil cuando hay bolsillos redondos en el borde del detalle. \r\n" +
        "Esta opción le permite cerrar inmediatamente el bucle del bolsillo (arco) \r\n" +
        "en círculo completo sin usar el comando Dado Loop (DDL).",
      "Transformer les arcs presque fermés en cercle. \r\n" +  // FR
        "Ceci est utile lorsqu'il y a des poches rondes sur le bord du détail. \r\n" +
        "Cette option vous permet de fermer immédiatement la boucle de la poche (arc) \r\n" +
        "en cercle complet sans utiliser la commande Dado Loop (DDL).",
      "Neredeyse kapalı yayları bir çembere dönüştürün. \r\n" +  // TR
        "Bu, detayın kenarında yuvarlak cepler olduğunda kullanışlıdır. \r\n" +
        "Bu seçenek, Dado Loop (DDL) komutunu kullanmadan \r\n" +
        "cep (yay) döngüsünü tam çemberde hemen kapatmanıza olanak tanır."};

    public static readonly string[] CloseLateral = {
      "Close the lateral drilling into a rectangle.",
      "Замыкать торцевое сверление в прямоугольник",
      "Chiudere la foratura laterale in un rettangolo.",
      "Stirnlochbohren in ein Rechteck schließen",
      "封闭面钻孔成矩形",
      "Cerrar la perforación lateral en un rectángulo.",  // ES
      "Fermer le perçage latéral en un rectangle.",  // FR
      "Yanal delmeyi bir dikdörtgene kapat."};  // TR

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
        "如果启用此选项，在 Pseudo-3d 模式下，面钻不会变成平面圆，而是保持矩形。",
      "Cerrar el contorno de perforación lateral en un rectángulo. \r\n" +  // ES
        "Por lo general, un contorno en forma de U es suficiente. \r\n" +
        "Si esta opción está habilitada, \r\n" +
        "las perforaciones laterales no se convertirán en círculos planos en modo Pseudo 3d, \r\n" +
        "sino que permanecerán como rectángulos.",
      "Fermer le contour de perçage latéral en un rectangle. \r\n" +  // FR
        "Habituellement, un contour en forme de U est suffisant. \r\n" +
        "Si cette option est activée, \r\n" +
        "les perçages latéraux ne se transformeront pas en cercles plats en mode Pseudo 3d, \r\n" +
        "mais resteront des rectangles.",
      "Yanal delme konturunu bir dikdörtgene kapatın. \r\n" +  // TR
        "Genellikle U şeklinde bir kontur yeterlidir. \r\n" +
        "Bu seçenek etkinleştirilirse, \r\n" +
        "yanal delikler Pseudo 3d modunda düz çemberlere dönüşmez, \r\n" +
        "dikdörtgen olarak kalır."};

    public static readonly string[] CircleSwivelDrill = {
      "Replace the contours of swivel drilling with a circle",
      "Заменять контуры наклонного сверления на окружность",
      "Sostituisci i contorni della perforazione inclinata con un cerchio",
      "Ersetzen Sie die Konturen des Schrägbohrens durch einen Kreis",
      "将斜钻孔的轮廓替换为圆",
      "Reemplazar los contornos de perforación giratoria con un círculo",  // ES
      "Remplacer les contours de perçage pivotant par un cercle",  // FR
      "Döner delme konturlarını bir çemberle değiştir"};  // TR

    public static readonly string[] CircleSwivelDrillTip = {
      "A flatshot from a swivel (incline) drill looks like several ellipses.\r\n " +
        "But Biesse bSolid requires that one circle be drawn.",
      "Слепок с повернутого (наклонного) сверления выглядит как несколько эллипсов.\r\n " +
        "Но Biesse bSolid требует, чтоб была начерчена одна окружность.",
      "Un colpo piatto da un trapano girevole (inclinato) assomiglia a diverse ellissi.\r\n " +
        "Ma Biesse bSolid richiede che venga disegnato un cerchio.",
      "Ein Flachschuss einer Schwenkbohrmaschine (Schrägbohrmaschine) sieht aus wie mehrere Ellipsen.\r\n " +
        "Biesse bSolid erfordert jedoch, dass ein Kreis gezeichnet wird.",
      "旋转（倾斜）钻头的平钻看起来像几个椭圆形。但 Biesse bSolid 要求绘制一个圆。",
      "Una proyección plana de un taladro giratorio (inclinado) parece varias elipses.\r\n " +  // ES
        "Pero Biesse bSolid requiere que se dibuje un círculo.",
      "Une projection plane d'un foret pivotant (incliné) ressemble à plusieurs ellipses.\r\n " +  // FR
        "Mais Biesse bSolid nécessite qu'un cercle soit dessiné.",
      "Döner (eğimli) matkap düz görünümü birkaç elips gibi görünür.\r\n " +  // TR
        "Ancak Biesse bSolid bir çember çizilmesini gerektirir."};

    public static readonly string[] ConsiderDiam = {
      "Consider cutter diameter",
      "Учитывать диаметр",
      "Considerare diametro",
      "Durchmesser berücksichtigen",
      "考虑直径",
      "Considerar diámetro de fresa",  // ES
      "Considérer le diamètre de la fraise",  // FR
      "Freze çapını dikkate al"};  // TR

    public static readonly string[] AddToDepth = {
      "Add to depth",
      "Добавить к глубине",
      "Aggiungi alla profondità",
      "Zur Tiefe hinzufügen",
      "添加到深度",
      "Agregar a la profundidad",  // ES
      "Ajouter à la profondeur",  // FR
      "Derinliğe ekle" };  // TR

    public static readonly string[] AddToDepthTip = {
      "Add some depth to through-cut vertical operations (milling, drilling, sawing). \r\n" +
        "A positive value will ensure that the part is cut through to the substrate. \r\n" +
        "A negative value (undercut) will prevent damage to the underside of the part.",
      "Добавить немного глубины к сквозным вертикальным операциям (фрезеровка, сверление, напилка). \r\n" +
        "Положительная величина позволит гарантировано прорезать деталь насквозь с выходом на подложку. \r\n" +
        "Отрицательная величина (недорез) позволит не испортить покрытие нижней стороны детали.",
      "Aggiungi un po' di profondità alle operazioni verticali a tutto spessore (fresatura, foratura, segatura). \r\n" +
        "Un valore positivo garantirà che il pezzo venga tagliato fino al substrato. \r\n" +
        "Un valore negativo (sottospessore) impedirà danni al lato inferiore del pezzo.",
      "Fügen Sie einigen Tiefen zu vertikalen Durchgangsoperationen (Fräsen, Bohren, Sägen) hinzu. \r\n" +
        "Ein positiver Wert stellt sicher, dass das Teil bis zum Substrat durchtrennt wird. \r\n" +
        "Ein negativer Wert (Unterschnitt) verhindert Schäden an der Unterseite des Teils.",
      "为贯穿式垂直操作（铣削、钻孔、锯切）增加一些深度。 \r\n" +
        "正值将确保零件切割到底材。 \r\n" +
        "负值（下切）将防止损坏零件的底面。",
      "Agregue algo de profundidad a las operaciones verticales de corte completo (fresado, perforación, aserrado). \r\n" +  // ES
        "Un valor positivo asegurará que la pieza se corte hasta el sustrato. \r\n" +
        "Un valor negativo (subcorte) evitará daños en la parte inferior de la pieza.",
      "Ajoutez de la profondeur aux opérations verticales de coupe totale (fraisage, perçage, sciage). \r\n" +  // FR
        "Une valeur positive garantira que la pièce soit coupée jusqu'au substrat. \r\n" +
        "Une valeur négative (sous-coupe) évitera d'endommager le dessous de la pièce.",
      "Tam kesim dikey işlemlere biraz derinlik ekleyin (frezeleme, delme, testere). \r\n" +  // TR
        "Pozitif bir değer, parçanın alt tabakaya kadar kesilmesini sağlar. \r\n" +
        "Negatif bir değer (alt kesim), parçanın alt tarafına zarar vermesini önler."};

    public static readonly string[] ICDirection = {
      "Direction",
      "Направление",
      "Direzione",
      "Richtung",
      "方向",
      "Dirección",  // ES
      "Direction",  // FR
      "Yön"};  // TR

    public static readonly string[] ICDirectionTip = {
      "Usually the cutter entry into the inner corner is done along the angle bisector. \r\n" +
        "But you can choose the direction along one of the sides of the corner. \r\n" +
        "For equal sides, the X-axis direction is used instead of the long one.",
      "Обычно вход фрезы во внутренний угол делается по биссектрисе угла. \r\n" +
        "Но вы можете выбрать направление вдоль одной из сторон угла. \r\n" +
        "При равных сторонах вместо длинной используется направление оси X ",
      "Tipicamente, la fresa entra nell'angolo interno lungo la bisettrice dell'angolo. \r\n" +
        "Ma puoi scegliere una direzione lungo uno dei lati dell'angolo. \r\n" +
        "Per i lati uguali, viene utilizzata la direzione dell'asse X anziché il lato lungo",
      "Typischerweise dringt der Fräser entlang der Winkelhalbierenden in die Innenecke ein. \r\n" +
        "Sie können jedoch eine Richtung entlang einer der Seiten der Ecke wählen. \r\n" +
        "Bei gleichen Seiten wird die X-Achsenrichtung anstelle der langen Seite verwendet",
      "通常，刀具沿着角的平分线进入内角。\r\n" +
        "但您可以选择沿着角的一侧的方向。\r\n" +
        "对于等边，使用X轴方向而不是长边",
      "Normalmente, la entrada de la fresa en la esquina interior se realiza a lo largo de la bisectriz del ángulo. \r\n" +  // ES
        "Pero puede elegir la dirección a lo largo de uno de los lados de la esquina. \r\n" +
        "Para lados iguales, se usa la dirección del eje X en lugar del lado largo.",
      "Habituellement, l'entrée de la fraise dans le coin intérieur se fait le long de la bissectrice de l'angle. \r\n" +  // FR
        "Mais vous pouvez choisir la direction le long d'un des côtés du coin. \r\n" +
        "Pour des côtés égaux, la direction de l'axe X est utilisée au lieu du côté long.",
      "Genellikle frezenin iç köşeye girişi açının açıortayı boyunca yapılır. \r\n" +  // TR
        "Ancak köşenin bir kenarı boyunca yönü seçebilirsiniz. \r\n" +
        "Eşit kenarlar için, uzun kenar yerine X ekseni yönü kullanılır."};

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
      "在轮廓和图层名称中包括刀具直径。 扩槽并加工圆刀的轮廓角。 启用钻孔图层和口袋图层。",
      "Se tiene en cuenta el diámetro de la fresa.\r\n" +  // ES
        "Se realizará el redondeo o esquinado especificado.\r\n" +
        "Los bucles de ranura se expandirán según el diámetro de la fresa.\r\n" +
        "Se pueden usar las capas de perforación y bolsillo.",
      "Le diamètre de la fraise est pris en compte.\r\n" +  // FR
        "Le congé ou l'angle spécifié sera réalisé.\r\n" +
        "Les boucles de rainure seront étendues au diamètre de la fraise.\r\n" +
        "Les calques de perçage et de poche peuvent être utilisés.",
      "Freze çapı dikkate alınır.\r\n" +  // TR
        "Belirtilen pah veya köşe yapılacaktır.\r\n" +
        "Yuva döngüleri freze çapına göre genişletilecektir.\r\n" +
        "Delme ve Cep katmanı kullanılabilir."};

    public static readonly string[] DelSources = {
      "Delete sources",
      "Удалить исходные",
      "Elimina gli oggetti originali",
      "Original löschen",
      "删除原件",
      "Eliminar originales",  // ES
      "Supprimer les sources",  // FR
      "Kaynakları sil"};  // TR

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
        "如果禁用该选项，则处理后的多段线将叠加在原始曲线或原始实体上。",
      "Eliminar objetos originales (curvas, polilíneas, sólidos).\r\n" +  // ES
        "Si deshabilita la opción, la polilínea procesada se superpondrá a la curva original o al sólido original.",
      "Supprimer les objets originaux (courbes, polylignes, solides).\r\n" +  // FR
        "Si vous désactivez l'option, la polyligne traitée sera superposée à la courbe d'origine ou au solide d'origine.",
      "Orijinal nesneleri silin (eğriler, poliçizgiler, katılar).\r\n" +  // TR
        "Seçeneği devre dışı bırakırsanız, işlenmiş poliçizgi orijinal eğrinin veya orijinal katının üzerine bindirilecektir."};

    public static readonly string[] Pseudo3d = {
      "Pseudo 3d",
      "Псевдо 3D",
      "Pseudo 3d",
      "Pseudo-3D",
      "伪 3D",
      "Pseudo 3d",  // ES
      "Pseudo 3d",  // FR
      "Pseudo 3d"};  // TR

    public static readonly string[] Pseudo3dAbove = {
      "Above XY",
      "Выше XY",
      "Sopra XY",
      "Über XY",
      "高于 XY",
      "Por encima de XY",  // ES
      "Au-dessus de XY",  // FR
      "XY'nin üzerinde"};  // TR

    public static readonly string[] Pseudo3dTip = {
      "Write the depth to the polyline|circle property Thickness.\r\n" +
        "Draw lateral holes as rotated circles (if Close Lateral is not checked).\r\n" +
        "Move down the dadoes and drills from below.",
      "Записать глубину фрезеровки в свойство полилинии Толщина (Thickness). \r\n" +
        "Начертить торцевые отверстия, как развернутые окружности (если только не включено замыкание их в прямоугольник) \r\n" +
        "Сдвинуть по Z пазы и сверления.",
      "Scrive la profondità di fresatura sulla proprietà della polilinea Spessore (Thickness) \r\n" +
        "Disegna i fori laterali come cerchi aperti. \r\n" +
        "Spostare le scanalature e i trapani verso il basso.",
      "Schreiben Sie die Frästiefe in die Eigenschaft Dicke der Polylinie. \r\n" +
        "Zeichnen Sie Endlöcher als erweiterte Kreise (es sei denn, das Schließen zu einem Rechteck ist aktiviert). \r\n" +
        "Bewegen Sie die Schlitze und Bohrer von der Unterseite des Teils nach unten.",
      "将铣削深度写入折线的厚度属性。 \r\n" +
        "将端孔绘制为扩展圆（除非启用封闭到矩形） 向下移动槽并从零件底部钻孔。",
      "Escribir la profundidad en la propiedad Espesor de polilínea|círculo.\r\n" +  // ES
        "Dibujar agujeros laterales como círculos rotados (si no está marcado Cerrar lateral).\r\n" +
        "Mover hacia abajo las ranuras y perforaciones desde abajo.",
      "Écrire la profondeur dans la propriété Épaisseur de polyligne|cercle.\r\n" +  // FR
        "Dessiner les trous latéraux comme des cercles tournés (si Fermer latéral n'est pas coché).\r\n" +
        "Déplacer vers le bas les rainures et perçages depuis le dessous.",
      "Derinliği poliçizgi|daire özelliği Kalınlığa yazın.\r\n" +  // TR
        "Yanal delikleri döndürülmüş çemberler olarak çizin (Yanal Kapat işaretli değilse).\r\n" +
        "Yuvaları ve delikleri alttan aşağı taşıyın."};

    public static readonly string[] Pseudo3dAboveTip = {
      "Create pseudo-3D outlines above the XY plane, with positive 'Thickness' values. \r\n" +
        "Usually negative thicknesses are created and the part appears to be placed below the XY plane. \r\n" +
        "This setting also changes the Z offset direction of the slot and drill outlines.",
      "Создать псевдо-3D контуры выше плоскости XY, с положительными значениями 'Толщины'. \r\n" +
        "Обычно создаются отрицательные толщины и деталь выглядит размещенной ниже плоскости XY. \r\n" +
        "Эта настройка так же меняет направление сдвига контуров пазов и сверлений по Z.",
      "Crea contorni pseudo-3D sopra il piano XY, con valori di 'Spessore' positivi.\r\n " +
        "In genere, vengono creati spessori negativi e la parte sembra posizionata sotto il piano XY. \r\n" +
        "Questa impostazione modifica anche la direzione di spostamento dei contorni \r\n" +
        "delle scanalature e delle forature lungo Z.",
      "Erstellen Sie Pseudo-3D-Konturen über der XY-Ebene mit positiven 'Dicke'-Werten. \r\n" +
        "Normalerweise werden negative Dicken erzeugt \r\n" +
        "und das Teil scheint unterhalb der XY-Ebene platziert zu sein. \r\n" +
        "Diese Einstellung ändert auch die Richtung \r\n" +
        "der Verschiebung der Konturen der Nuten und Bohrungen entlang Z.",
      "在 XY 平面上方创建具有正'厚度'值的伪 3D 轮廓。\r\n" +
        "通常，会创建负厚度，并且零件看起来放置在 XY 平面下方。\r\n" +
        "此设置还会改变凹槽和钻孔轮廓沿 Z 轴的移动方向。",
      "Crear contornos pseudo-3D por encima del plano XY, con valores de 'Espesor' positivos. \r\n" +  // ES
        "Normalmente se crean espesores negativos y la pieza parece estar colocada debajo del plano XY. \r\n" +
        "Esta configuración también cambia la dirección de desplazamiento Z de los contornos de ranuras y perforaciones.",
      "Créer des contours pseudo-3D au-dessus du plan XY, avec des valeurs d''Épaisseur' positives. \r\n" +  // FR
        "Habituellement, des épaisseurs négatives sont créées et la pièce semble être placée sous le plan XY. \r\n" +
        "Ce paramètre modifie également la direction de décalage Z des contours de rainures et de perçages.",
      "XY düzleminin üzerinde pozitif 'Kalınlık' değerleriyle pseudo-3D konturlar oluşturun. \r\n" +  // TR
        "Genellikle negatif kalınlıklar oluşturulur ve parça XY düzleminin altına yerleştirilmiş gibi görünür. \r\n" +
        "Bu ayar aynı zamanda yuva ve delik konturlarının Z kayma yönünü de değiştirir."};

    public static readonly string[] DotTip = {
      "Replace the decimal point in the depth and diameter of this symbol.\r\n" +
        "You can use a comma, dot, or any letter.",
      "Заменять десятичную запятую на этот символ",
      "Sostituire il punto decimale nella profondità e nel diametro di questo simbolo.",
      "Dezimalpunkt durch dieses Zeichen ersetzen",
      "用这个字符替换小数点",
      "Reemplazar el punto decimal en la profundidad y el diámetro con este símbolo.\r\n" +  // ES
        "Puede usar una coma, punto o cualquier letra.",
      "Remplacer le point décimal dans la profondeur et le diamètre par ce symbole.\r\n" +  // FR
        "Vous pouvez utiliser une virgule, un point ou n'importe quelle lettre.",
      "Derinlik ve çaptaki ondalık noktayı bu sembolle değiştirin.\r\n" +  // TR
        "Virgül, nokta veya herhangi bir harf kullanabilirsiniz."};

    public static readonly string[] DrillThin = {
      "Drill thin holes",
      "Сверлить тонкие",
      "Praticare fori sottili",
      "Dünne Löcher bohren",
      "钻细孔",
      "Perforar agujeros delgados",  // ES
      "Percer des trous minces",  // FR
      "İnce delikler del"};  // TR

    public static readonly string[] DrillThinTip = {
      "Use drilling for all circles smaller than the milling cutter diameter.",
      "Использовать сверление для всех окружностей, диаметром менее диаметра фрезы.",
      "Utilizzare la perforazione per tutti i cerchi più piccoli del diametro della fresa.",
      "Verwenden Sie das Bohren für alle Kreise mit einem Durchmesser, \r\n" +
        "der kleiner ist als der Durchmesser des Fräsers.",
      "对所有直径小于刀具直径的圆进行钻孔。",
      "Usar perforación para todos los círculos más pequeños que el diámetro de la fresa.",  // ES
      "Utiliser le perçage pour tous les cercles plus petits que le diamètre de la fraise.",  // FR
      "Freze çapından daha küçük tüm çemberler için delme kullanın."};  // TR

    public static readonly string[] ExpandDado = {
      "Expand edge dadoes",
      "Расширять четверти",
      "Espandi i solchi",
      "Viertel erweitern",
      "扩大边界",
      "Expandir ranuras de borde",  // ES
      "Étendre les rainures de bord",  // FR
      "Kenar yuvalarını genişlet"};  // TR

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
        "刀具出口到零件外部的圆弧也将被制作出来。",
      "Expandir el contorno de la ranura hacia el exterior de la pieza, \r\n" +  // ES
        "si la fresa no pasa. \r\n" +
        "También se harán arcos de salida de la fresa fuera del detalle.",
      "Étendre le contour de la rainure vers l'extérieur de la pièce, \r\n" +  // FR
        "si la fraise ne passe pas. \r\n" +
        "Des arcs de sortie de la fraise seront également réalisés à l'extérieur du détail.",
      "Yuva konturunu parçanın dışına doğru genişletin, \r\n" +  // TR
        "freze geçmiyorsa. \r\n" +
        "Ayrıca frezenin detayın dışına çıkış yayları da yapılacaktır." };

    public static readonly string[] ExpandDadoEdge = {
      "Entire outer contour",
      "Весь наружный контур",
      "Tutto il contorno esterno",
      "Gesamte Außenkontur",
      "整个外轮廓",
      "Contorno exterior completo",                      // ES
      "Contour extérieur entier",                       // FR
      "Tüm dış kontur" };                               // TR

    public static readonly string[] ExpandDadoEdgeTip = {
      "The entire contour of the dado along the edge of the part must be moved outward by half the diameter of the cutter \r\n" +
        "so that the cutter does not fray the material.",
      "Весь контур четверти по краю детали надо отодвинуть наружу на пол диаметра фрезы, \r\n" +
        "чтоб фреза не лохматила материал.",
      "L'intero contorno del dado lungo il bordo del pezzo deve essere spostato verso l'esterno di metà del diametro della fresa, \r\n" +
        "in modo che quest'ultima non sfilacci il materiale.",
      "Die gesamte Kontur der Nut entlang der Teilekante muss um den halben Fräserdurchmesser nach außen verschoben werden, \r\n" +
        "damit der Fräser das Material nicht ausfranst.",
      "沿零件边缘的榫眼的整个轮廓必须向外移动刀具直径的一半，以使刀具不会磨损材料。",
      "El contorno completo de la ranura a lo largo del borde de la pieza debe moverse hacia afuera la mitad del diámetro de la fresa \r\n" +  // ES
        "para que la fresa no deshilache el material.",
      "Le contour entier de la rainure le long du bord de la pièce doit être déplacé vers l'extérieur de la moitié du diamètre de la fraise \r\n" +  // FR
        "afin que la fraise n'effiloche pas le matériau.",
      "Parça kenarı boyunca yuva konturunun tamamı, frezenin malzemeyi yıpratmaması için \r\n" +  // TR
        "freze çapının yarısı kadar dışa doğru kaydırılmalıdır."};

    public static readonly string[] FilletBothSides = {
      "Fillet on both sides",
      "С двух сторон",
      "Entrambe le parti",
      "Von zwei Seiten",
      "从两个方面",
      "Redondeo en ambos lados",  // ES
      "Congé des deux côtés",  // FR
      "Her iki tarafta pah kırma"};  // TR

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
        "在开放的多段线上，始终在两侧制作圆角。",
      "Crear redondeo en ambos lados de los contornos, y no solo en el lado de fresado.\r\n" +  // ES
        "No funciona con esquina interior. En una polilínea no cerrada, \r\n" +
        "siempre se redondea en ambos lados.",
      "Créer un congé des deux côtés des contours, et pas seulement du côté fraisage.\r\n" +  // FR
        "Ne fonctionne pas avec le coin intérieur. Sur une polyligne non fermée, \r\n" +
        "il y a toujours un congé des deux côtés.",
      "Konturların her iki tarafında pah kırma oluşturun, sadece frezeleme tarafında değil.\r\n" +  // TR
        "İç köşe ile çalışmaz. Kapalı olmayan bir poliçizgide, \r\n" +
        "her zaman her iki tarafta pah kırma yapılır."};

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
        "用于 %dir% 替换。",
      "5 caracteres para indicar la dirección de perforación lateral: \r\n" +  // ES
        "izquierda, frente, derecha, atrás y abajo.\r\n" +
        "Utilizado en la sustitución %dir%.",
      "5 caractères pour indiquer la direction du perçage latéral : \r\n" +  // FR
        "gauche, avant, droite, arrière et dessous.\r\n" +
        "Utilisé dans la substitution %dir%.",
      "Yanal delme yönünü belirtmek için 5 karakter: \r\n" +  // TR
        "sol, ön, sağ, arka ve alt.\r\n" +
        "%dir% değiştirmesinde kullanılır."};

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
        "此文本可用于所有图层名称中的 %millmode% 替换。",
      "Modo de procesamiento (fresado). \r\n" +  // ES
        "Este texto se puede usar en la sustitución %millmode% en todos los nombres de capas.",
      "Mode de traitement (fraisage). \r\n" +  // FR
        "Ce texte peut être utilisé dans la substitution %millmode% dans tous les noms de calques.",
      "İşleme (frezeleme) modu. \r\n" +  // TR
        "Bu metin tüm katman adlarında %millmode% değiştirmesinde kullanılabilir."};

    public static readonly string[] MillRight = {
      "Milling on the right",
      "Фреза справа",
      "Fresatura sulla destra",
      "Fräser rechts",
      "铣刀右",
      "Fresado a la derecha",  // ES
      "Fraisage à droite",  // FR
      "Sağda frezeleme"};  // TR

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
        "如果取消选中该框，则轮廓将反转 - 铣削到轮廓的左侧。",
      "Girar los contornos exteriores en sentido antihorario y los contornos interiores en sentido horario.\r\n" +  // ES
        "En este caso, la fresa debe ubicarse a la derecha del contorno,\r\n" +
        "si mira a lo largo del movimiento.\r\n" +
        "Si el husillo gira en sentido horario,\r\n" +
        "obtendrá una contracorriente al borde de corte y una disminución en la fibrosidad del corte.\r\n" +
        "Si desmarca las casillas, los contornos se invertirán (exterior en sentido horario).",
      "Tourner les contours extérieurs dans le sens antihoraire et les contours intérieurs dans le sens horaire.\r\n" +  // FR
        "Dans ce cas, la fraise doit être située à droite du contour,\r\n" +
        "si vous regardez le long du mouvement.\r\n" +
        "Si la broche tourne dans le sens horaire,\r\n" +
        "vous obtiendrez un contre-courant au bord de coupe et une diminution de la fibrosité de la coupe.\r\n" +
        "Si vous décochez les cases, les contours seront inversés (extérieur dans le sens horaire).",
      "Dış konturları saat yönünün tersine, iç konturları saat yönünde çevirin.\r\n" +  // TR
        "Bu durumda, hareket boyunca bakarsanız,\r\n" +
        "freze konturun sağında olmalıdır.\r\n" +
        "Mil saat yönünde dönüyorsa,\r\n" +
        "kesme kenarına karşı akım ve kesimdeki liflilik azalması elde edersiniz.\r\n" +
        "Onay kutularını temizlerseniz, konturlar tersine çevrilir (dış saat yönünde)."};

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
        "只有在未指定刀具名称时，程序才会使用此名称零件材料属性。",
      "El nombre o número de la herramienta (fresa) como se denomina en la máquina CNC. \r\n" +  // ES
        "Este nombre se puede usar en la sustitución %milltool% en todos los nombres de capas de fresado. \r\n" +
        "Use la sustitución para no cambiar los nombres de todas las capas al reemplazar la herramienta. \r\n" +
        "El programa usará este nombre solo si el nombre de la herramienta no está especificado en las propiedades del material de la pieza.",
      "Le nom ou le numéro de l'outil (fraise) tel qu'il est nommé dans la machine CNC. \r\n" +  // FR
        "Ce nom peut être utilisé dans la substitution %milltool% dans tous les noms de calques de fraisage. \r\n" +
        "Utilisez la substitution pour ne pas changer les noms de tous les calques lors du remplacement de l'outil. \r\n" +
        "Le programme utilisera ce nom uniquement si le nom de l'outil n'est pas spécifié dans les propriétés du matériau de la pièce.",
      "CNC makinesinde adlandırıldığı şekliyle takımın (frezin) adı veya numarası. \r\n" +  // TR
        "Bu ad, tüm frezeleme katmanı adlarında %milltool% değiştirmesinde kullanılabilir. \r\n" +
        "Takımı değiştirirken tüm katmanların adlarını değiştirmemek için değiştirmeyi kullanın. \r\n" +
        "Program bu adı yalnızca parçanın malzeme özelliklerinde takım adı belirtilmemişse kullanacaktır."};

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
        "钻孔表中不使用此设置。",
      "El diámetro y la profundidad se multiplicarán por este número antes de sustituirse en el nombre de la capa. \r\n" +  // ES
        "Esta configuración no se usa en la Tabla de perforación.",
      "Le diamètre et la profondeur seront multipliés par ce nombre avant substitution dans le nom du calque. \r\n" +  // FR
        "Ce paramètre n'est pas utilisé dans la Table de perçage.",
      "Çap ve derinlik katman adına yerleştirilmeden önce bu sayı ile çarpılacaktır. \r\n" +  // TR
        "Bu ayar Delme Tablosunda kullanılmaz."};

    public static readonly string[] NotDrillCircle = {
      "Use circles",
      "Использовать окружности",
      "Usa cerchi non per trapanare",
      "Verwenden Sie Kreise",
      "使用圆圈",
      "Usar círculos",  // ES
      "Utiliser des cercles",  // FR
      "Çember kullan"};  // TR

    public static readonly string[] NotDrillCircleTip = {
      "Create circles for round outside and inside contours even when the diameter is not in the drill bits list. \r\n" +
        "The problem with circles is that they have no traversing direction and the position of the cutter can be wrong. \r\n" +
        "It is recommended to disable this option and then the program will draw a polyline of two arcs \r\n" +
        "and keep the correct milling direction.",
      "Создавать окружности для круглых внешних и внутренних контуров, \r\n" +
        "даже когда диаметр отсутствует в списке свёрел. \r\n" +
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
        "建议禁用此选项，然后程序将绘制两条圆弧的折线并保持正确的铣削方向。",
      "Crear círculos para contornos redondos externos e internos incluso cuando el diámetro no está en la lista de brocas. \r\n" +  // ES
        "El problema con los círculos es que no tienen dirección de recorrido y la posición de la fresa puede ser incorrecta. \r\n" +
        "Se recomienda deshabilitar esta opción y luego el programa dibujará una polilínea de dos arcos \r\n" +
        "y mantendrá la dirección correcta de fresado.",
      "Créer des cercles pour les contours ronds extérieurs et intérieurs même lorsque le diamètre n'est pas dans la liste des forets. \r\n" +  // FR
        "Le problème avec les cercles est qu'ils n'ont pas de direction de parcours et la position de la fraise peut être incorrecte. \r\n" +
        "Il est recommandé de désactiver cette option et alors le programme dessinera une polyligne de deux arcs \r\n" +
        "et conservera la direction correcte de fraisage.",
      "Çap matkap listesinde olmasa bile yuvarlak dış ve iç konturlar için çemberler oluşturun. \r\n" +  // TR
        "Çemberlerin sorunu, geçiş yönleri olmaması ve frezenin konumunun yanlış olabilmesidir. \r\n" +
        "Bu seçeneği devre dışı bırakmanız önerilir ve ardından program iki yaydan oluşan bir poliçizgi çizer \r\n" +
        "ve doğru frezeleme yönünü korur."};

    public static readonly string[] OutsideCornersTip = {
      "Cut Inside Corners or make a Fillet on the corners of the outer contour of the detail.",
      "Делать дугу захода фрезы в угол или делать скругление углов на наружном контуре детали.",
      "Taglia Angoli Interni o crea un Raccordo sugli angoli dei contorni esterni del dettaglio.",
      "Machen Sie einen Bogen des Fräsereintritts in eine Ecke oder runden Sie die Ecken an der Außenkontur eines Teils ab.",
      "使刀具进入角的圆弧或在零件的外轮廓上圆角。",
      "Cortar esquinas interiores o hacer un redondeo en las esquinas del contorno exterior del detalle.",  // ES
      "Couper les coins intérieurs ou faire un congé sur les coins du contour extérieur du détail.",  // FR
      "İç köşeleri kesin veya detayın dış konturunun köşelerinde pah kırma yapın."};  // TR

    public static readonly string[] PocketCornersTip = {
      "Corner processing on internal blind contours of parts (dadoes / pockets / grooves). \r\n" +
        "When working with 3D solids, the Inside Corner (IC) command will process all internal contours, both blind and through windows.",
      "Обработка углов на всех внутренних глухих контурах (выборках, четвертях и пазах). \r\n" +
        "При работе с 3d-солидами команда Внутренний Угол (IC) будет обрабатывать все внутренние контуры, как глухие, так и сквозные окна.",
      "Elaborazione degli angoli su tutti i contorni ciechi interni (dado/tasche/scanalature). \r\n" +
        "Quando si lavora con solidi 3D, il comando Angolo interno (IC) elaborerà tutti i contorni interni, sia ciechi che passanti.",
      "Eckenbearbeitung an allen inneren Blindkonturen (Nuten/Taschen/Rillen). \r\n" +
        "Beim Arbeiten mit 3D-Vollkörpern bearbeitet der Befehl 'Innenecke' (IC) alle inneren Konturen, sowohl Blind- als auch Durchgangsfenster.",
      "对所有内部盲轮廓（榫眼/凹槽/凹槽）进行角处理。\r\n" +
        "处理 3D 实体时，内角 (IC) 命令将处理所有内部轮廓，包括盲窗和通孔。",
      "Procesamiento de esquinas en contornos ciegos internos de piezas (ranuras / bolsillos / acanaladuras). \r\n" +  // ES
        "Al trabajar con sólidos 3D, el comando Esquina interior (IC) procesará todos los contornos internos, tanto ciegos como pasantes.",
      "Traitement des coins sur les contours aveugles internes des pièces (rainures / poches / gorges). \r\n" +  // FR
        "Lorsque vous travaillez avec des solides 3D, la commande Coin intérieur (IC) traitera tous les contours internes, à la fois aveugles et traversants.",
      "Parçaların iç kör konturlarında köşe işleme (yuvalar / cepler / oluklar). \r\n" +  // TR
        "3D katılarla çalışırken, İç Köşe (IC) komutu hem kör hem de geçişli tüm iç konturları işleyecektir."};

    public static readonly string[] WindowCornersTip = {
      "Corner processing on internal through contours of parts (through holes, windows).\r\n" +
        "When working with 3D solids, the Inside Corner (IC) command will process all internal contours, both blind and through windows.",
      "Обработка углов на внутренних сквозных контурах деталей (сквозных пропилах, окнах). \r\n" +
        "При работе с 3d-солидами команда Внутренний Угол (IC) будет обрабатывать все внутренние контуры, как глухие, так и сквозные окна.",
      "Lavorazione degli angoli sui contorni interni passanti delle parti (tagli passanti, finestre).\r\n" +
        "Quando si lavora con solidi 3D, il comando Angolo interno (IC) elaborerà tutti i contorni interni, sia ciechi che passanti.",
      "Bearbeitung von Ecken an inneren Durchgangskonturen von Teilen (Durchschnitte, Fenster).\r\n" +
        "Beim Arbeiten mit 3D-Vollkörpern bearbeitet der Befehl 'Innenecke' (IC) alle inneren Konturen, sowohl Blind- als auch Durchgangsfenster.",
      "通过零件轮廓加工内部角（通过切口、窗口）。\r\n" +
        "处理 3D 实体时，内角 (IC) 命令将处理所有内部轮廓，包括盲窗和通孔。",
      "Procesamiento de esquinas en contornos internos pasantes de piezas (agujeros pasantes, ventanas).\r\n" +  // ES
        "Al trabajar con sólidos 3D, el comando Esquina interior (IC) procesará todos los contornos internos, tanto ciegos como pasantes.",
      "Traitement des coins sur les contours internes traversants des pièces (trous traversants, fenêtres).\r\n" +  // FR
        "Lorsque vous travaillez avec des solides 3D, la commande Coin intérieur (IC) traitera tous les contours internes, à la fois aveugles et traversants.",
      "Parçaların iç geçmeli konturlarında köşe işleme (geçmeli delikler, pencereler).\r\n" +  // TR
        "3D katılarla çalışırken, İç Köşe (IC) komutu hem kör hem de geçişli tüm iç konturları işleyecektir."};

    public static readonly string[] ReplaceNonVertDrill = {
      "Other drilling blocks",
      "Блоки др. сверлений:",
      "Blocchi di perforazione:",
      "Blöcke anderer Bohrungen:",
      "其他钻孔块：",
      "Bloques de perforación otros:",  // ES
      "Blocs de perçage autres :",  // FR
      "Diğer delme blokları:"};  // TR

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
        "替换是在模型中，而不是在工作表上。",
      "Reemplazar los contornos ocultos de las perforaciones laterales, giratorias e inferiores con bloques especiales.\r\n" +  // ES
        "El reemplazo está en el modelo, no en la hoja.",
      "Remplacer les contours cachés des perçages latéraux, pivotants et inférieurs par des blocs spéciaux.\r\n" +  // FR
        "Le remplacement se fait dans le modèle, pas sur la feuille.",
      "Yanal, döner ve alt deliklerin gizli konturlarını özel bloklarla değiştirin.\r\n" +  // TR
        "Değiştirme modelde, sayfada değil."};

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
        "此文本可用于所有图层名称的 %sawmode% 替换。",
      "Modo de procesamiento (aserrado). \r\n" +  // ES
        "Este texto se puede usar en la sustitución %sawmode% en todos los nombres de capas.",
      "Mode de traitement (sciage). \r\n" +  // FR
        "Ce texte peut être utilisé dans la substitution %sawmode% dans tous les noms de calques.",
      "İşleme (kesme) modu. \r\n" +  // TR
        "Bu metin tüm katman adlarında %sawmode% değiştirmesinde kullanılabilir."};

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
        "仅当零件的材料属性中未指定工具名称时，程序才会使用此名称。",
      "El nombre o número de la herramienta (disco de sierra) como se denomina en la máquina CNC. \r\n" +  // ES
        "Este nombre se puede usar en la sustitución %sawtool% en todos los nombres de capas. \r\n" +
        "Use la sustitución para no cambiar los nombres de todas las capas al reemplazar la herramienta. \r\n" +
        "El programa usará este nombre solo si el nombre de la herramienta no está especificado en las propiedades del material de la pieza.",
      "Le nom ou le numéro de l'outil (disque de scie) tel qu'il est nommé dans la machine CNC. \r\n" +  // FR
        "Ce nom peut être utilisé dans la substitution %sawtool% dans tous les noms de calques. \r\n" +
        "Utilisez la substitution pour ne pas changer les noms de tous les calques lors du remplacement de l'outil. \r\n" +
        "Le programme utilisera ce nom uniquement si le nom de l'outil n'est pas spécifié dans les propriétés du matériau de la pièce.",
      "CNC makinesinde adlandırıldığı şekliyle takımın (testere diski) adı veya numarası. \r\n" +  // TR
        "Bu ad, tüm katman adlarında %sawtool% değiştirmesinde kullanılabilir. \r\n" +
        "Takımı değiştirirken tüm katmanların adlarını değiştirmemek için değiştirmeyi kullanın. \r\n" +
        "Program bu adı yalnızca parçanın malzeme özelliklerinde takım adı belirtilmemişse kullanacaktır."};

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
        "您可以更改名称。",
      "Estilo CNC (conjunto de configuraciones). La clave y el nombre. \r\n" +  // ES
        "La clave se asigna automáticamente como un dígito del 1 al 9 y se usa para cambiar rápidamente el estilo desde la consola. \r\n" +
        "Puede cambiar el nombre.",
      "Style CNC (ensemble de paramètres). La clé et le nom. \r\n" +  // FR
        "La clé est attribuée automatiquement sous la forme d'un chiffre de 1 à 9 et est utilisée pour changer rapidement de style depuis la console. \r\n" +
        "Vous pouvez changer le nom.",
      "CNC stili (ayar seti). Anahtar ve ad. \r\n" +  // TR
        "Anahtar otomatik olarak 1'den 9'a kadar bir rakam olarak atanır ve konsoldan stili hızlı bir şekilde değiştirmek için kullanılır. \r\n" +
        "Adı değiştirebilirsiniz."};

    public static readonly string[] SkipObtuse = {
      "Skip obtuse angles",
      "Пропускать тупые",
      "Salta angoli ottusi",
      "Überspringen Sie stumpfe Ecken",
      "跳过钝角",
      "Omitir ángulos obtusos",  // ES
      "Ignorer les angles obtus",  // FR
      "Geniş açıları atla"};  // TR

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
        "程序可能会根据公差忽略这些角度。",
      "Si el ángulo es obtuso, entonces la esquina procesada por la fresa difiere muy poco de los contornos originales. \r\n" +  // ES
        "El programa puede no manejar esquinas donde la diferencia es menor que la variación permisible.",
      "Si l'angle est obtus, alors le coin traité par la fraise diffère très peu des contours d'origine. \r\n" +  // FR
        "Le programme peut ne pas traiter les coins où la différence est inférieure à la variation admissible.",
      "Açı geniş ise, freze tarafından işlenen köşe orijinal konturlardan çok az farklıdır. \r\n" +  // TR
        "Program, farkın izin verilen varyasyondan az olduğu köşeleri işlemeyebilir."};

    public static readonly string[] ICAcute = {
      "Acute angles",
      "Заход в острые",
      "Angoli acuti",
      "Spitze Winkel",
      "进入尖角",
      "Ángulos agudos",  // ES
      "Angles aigus",  // FR
      "Dar açılar"};  // TR

    public static readonly string[] ICAcuteTip = {
      "The Inside Corner command will make long slots to bring the cutter to the end of a sharp corner. \r\n" +
        "If the option is disabled, only obtuse and right angles are machined.",
      "Команда Заход в Угол будет делать длинные пазы, чтоб довести фрезу до конца острого угла. \r\n" +
        "Если опция отключена, то обрабатываются только тупые и прямые углы.",
      "Il comando Angolo interno creerà lunghe asole per portare la taglierina all'estremità di un angolo acuto. \r\n" +
        "Se l'opzione è disabilitata, verranno elaborati solo gli angoli ottusi e retti.",
      "Der Befehl 'Innenecke' erzeugt lange Schlitze, um den Fräser an das Ende einer scharfen Ecke zu bringen. \r\n" +
        "Wenn die Option deaktiviert ist, werden nur stumpfe und rechte Winkel verarbeitet.",
      "内角命令将制作长槽，将刀具带到尖角的末端。如果禁用该选项，则仅处理钝角和直角。",
      "El comando Esquina interior hará ranuras largas para llevar la fresa al final de una esquina afilada. \r\n" +  // ES
        "Si la opción está deshabilitada, solo se mecanizan ángulos obtusos y rectos.",
      "La commande Coin intérieur créera de longues fentes pour amener la fraise à l'extrémité d'un coin aigu. \r\n" +  // FR
        "Si l'option est désactivée, seuls les angles obtus et droits sont usinés.",
      "İç Köşe komutu frezeyi keskin bir köşenin sonuna getirmek için uzun yuvalar yapacaktır. \r\n" +  // TR
        "Seçenek devre dışı bırakılırsa, yalnızca geniş ve dik açılar işlenir."};

    public static readonly string[] SplineToLine = {
      "Approximation spline to lines",
      "Сплайн в линию",
      "Spline on line",
      "Spline zu Linie",
      "样条到线",
      "Aproximación de spline a líneas",  // ES
      "Approximation de spline en lignes",  // FR
      "Spline'ı çizgilere yaklaştırma"};  // TR

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
         "正在使用 PLINECONVERTMODE 系统变量。",
      "Prohibir el uso de arcos (solo líneas) para la aproximación de un spline. \r\n" +  // ES
        "Utiliza la variable del sistema PLINECONVERTMODE.",
      "Interdire l'utilisation d'arcs (lignes uniquement) pour l'approximation d'une spline. \r\n" +  // FR
        "Utilise la variable système PLINECONVERTMODE.",
      "Bir spline'ın yaklaştırılması için yayların kullanımını yasaklayın (yalnızca çizgiler). \r\n" +  // TR
        "PLINECONVERTMODE sistem değişkenini kullanır."};

    public static readonly string[] Corners = {
      "Corners milling",
      "Фрезеровка углов",
      "Fresatura degli spigoli",
      "Eckenfräsen",
      "角铣",
      "Fresado de esquinas",  // ES
      "Fraisage des coins",  // FR
      "Köşe frezeleme"};  // TR

    public static readonly string[] Drill = {
      "Drilling",
      "Сверловка",
      "Perforazione",
      "Bohren",
      "钻孔",
      "Perforación",                                   // ES
      "Perçage",                                       // FR
      "Delme"};                                        // TR

    public static readonly string[] DrillTip = {
      "Search for cylindrical holes of suitable diameters. Assignment of drilling layers.",
      "Поиск цилиндрических отверстий подходящих диаметров. Назначение слоев сверления.",
      "Cercare fori cilindrici di diametro adatto. Assegnazione degli strati di perforazione.",
      "Suchen Sie nach zylindrischen Löchern mit geeigneten Durchmessern. Zuordnung der Bohrebenen.",
      "寻找合适直径的圆柱孔。钻孔层的分配。",
      "Buscar agujeros cilíndricos de diámetros adecuados. Asignación de capas de perforación.",  // ES
      "Rechercher des trous cylindriques de diamètres appropriés. Attribution des calques de perçage.",  // FR
      "Uygun çaplarda silindirik delikler arayın. Delme katmanlarının atanması."};  // TR

    public static readonly string[] LayerName = {
      "Layer Naming",
      "Имена слоев",
      "Denominare i Layer",
      "Schichtnamen",
      "图层名称",
      "Nomenclatura de capas",                         // ES
      "Nomenclature des calques",                     // FR
      "Katman adlandırma"};                            // TR

    public static readonly string[] Milling = {
      "Milling",
      "Фрезеровка",
      "Fresatura",
      "Mahlen",
      "铣削",
      "Fresado",                                       // ES
      "Fraisage",                                      // FR
      "Frezeleme"};                                    // TR

    public static readonly string[] Saw = {
      "Sawing",
      "Напилка",
      "Segare",
      "Sägen",
      "锯切",
      "Aserrado",                                      // ES
      "Sciage",                                        // FR
      "Kesme"};                                        // TR

    public static readonly string[] SawTip = {
      "Finding straight lines on the outer contour and straight grooves. Assigning layers for filing on a circular saw.",
      "Поиск прямых линий на внешнем контуре и прямых пазов. назначение слоев для напилки на циркулярной пиле.",
      "Cercare linee rette sul contorno esterno e scanalature dritte. Assegnazione dei livelli per il taglio con una sega circolare.",
      "Achten Sie auf gerade Linien an der Außenkontur und gerade Rillen. Zuweisen von Ebenen zum Schneiden auf einer Kreissäge.",
      "寻找外轮廓上的直线和直凹槽。分配圆锯切割的层。",
      "Encontrar líneas rectas en el contorno exterior y ranuras rectas. Asignación de capas para aserrado en sierra circular.",  // ES
      "Trouver des lignes droites sur le contour extérieur et des rainures droites. Attribution des calques pour le sciage à la scie circulaire.",  // FR
      "Dış konturda düz çizgiler ve düz yuvalar bulun. Daire testere ile kesme için katman ataması."};  // TR

    public static readonly string[] Tolerance = {
      "Permissible variation",
      "Допустимое отклонение",
      "Variazione consentita",
      "Zulässige Abweichung",
      "允许的变化",
      "Variación permisible",                          // ES
      "Variation admissible",                          // FR
      "İzin verilen varyasyon"};                       // TR

    public static readonly string[] ToleranceTip = {
      "The errors of the original contours are ignored. Change with caution!",
      "Игнорируемые погрешности исходных контуров. Меняйте с осторожностью!",
      "Errori ignorati dei contorni originali. Cambia con cura!",
      "Ignorierte Fehler der Originalkonturen. Wechseln Sie mit Bedacht!",
      "忽略原始轮廓的错误。 谨慎修改！",
      "Se ignoran los errores de los contornos originales. ¡Cambie con precaución!",  // ES
      "Les erreurs des contours d'origine sont ignorées. Modifiez avec prudence !",  // FR
      "Orijinal konturların hataları yok sayılır. Dikkatli değiştirin!"};  // TR

    public static readonly string[] Angle = {
      "in Angle",
      "по углу",
      "dall'angolo",
      "nach Winkel",
      "按角度",
      "por ángulo",                                    // ES
      "par angle",                                     // FR
      "açıya göre"};                                   // TR

    public static readonly string[] ArcAngleForClosing = {
      "Arc angle for closing",
      "Угол дуги для замыкания",
      "Angolo dell'arco per la chiusura",
      "Bogenwinkel zum Schließen",
      "闭合弧度",
      "Ángulo de arco para cierre",                    // ES
      "Angle d'arc pour fermeture",                    // FR
      "Kapatma için yay açısı"};                       // TR

    public static readonly string[] ArcAngleForClosingTip = {
      "If the arc exceeds this angle, then it should be replaced by a circle",
      "Если дуга превышает этот угол, то ее следует заменить окружностью",
      "Se l'arco supera questo angolo, allora dovrebbe essere sostituito con un cerchio",
      "Wenn der Bogen diesen Winkel überschreitet, sollte er durch einen Kreis ersetzt werden",
      "如果圆弧超过这个角度，那么应该用圆代替",
      "Si el arco excede este ángulo, entonces debe ser reemplazado por un círculo",  // ES
      "Si l'arc dépasse cet angle, il doit être remplacé par un cercle",  // FR
      "Yay bu açıyı aşarsa, bir çemberle değiştirilmelidir"};  // TR

    public static readonly string[] BlankOffset = {
      "Offset of the blank rectangle",
      "Офсет прямоугольника заготовки",
      "Offset rettangolo vuoto",
      "Leerer Rechteckversatz",
      "空白矩形偏移",
      "Desplazamiento del rectángulo en bruto",        // ES
      "Décalage du rectangle d'ébauche",               // FR
      "Boş dikdörtgen ofseti"};                        // TR

    public static readonly string[] BlockLateral = {
      "Lateral",
      "Торцевое",
      "Laterale",
      "Seitlich",
      "侧",
      "Lateral",                                       // ES
      "Latéral",                                       // FR
      "Yanal"};                                        // TR

    public static readonly string[] BlockUnder = {
      "Under",
      "Снизу",
      "Basso",
      "Unter",
      "在下面",
      "Debajo",                                        // ES
      "Dessous",                                       // FR
      "Alt"};                                          // TR

    public static readonly string[] BlockUni = {
      "Swivel",
      "Наклонное",
      "Inclinata",
      "Schräg",
      "斜",
      "Giratorio",                                     // ES
      "Pivotant",                                      // FR
      "Döner"};                                        // TR

    public static readonly string[] CutterDiam = {
      "Cutter diameter",
      "Диаметр",
      "Diametro",
      "Fräserdurchmesser",
      "刀具直径",
      "Diámetro de fresa",                             // ES
      "Diamètre de fraise",                            // FR
      "Freze çapı"};                                   // TR

    public static readonly string[] CutterGap = {
      "Gap",
      "Зазор",
      "Divario",
      "Lücke",
      "差距",
      "Holgura",                                       // ES
      "Jeu",                                           // FR
      "Boşluk"};                                       // TR

    public static readonly string[] DirTypes = {
      "Direction names",
      "Направления",
      "Nomi di direzione",
      "Richtungsnamen",
      "方向名称",
      "Nombres de dirección",                          // ES
      "Noms de direction",                             // FR
      "Yön adları"};                                   // TR

    public static readonly string[] Dot = {
      "Decimal separator",
      "Разделитель",
      "Separatore decimale",
      "Dezimaltrennzeichen",
      "小数分隔符",
      "Separador decimal",                             // ES
      "Séparateur décimal",                            // FR
      "Ondalık ayırıcı"};                              // TR

    public static readonly string[] DrillBits = {
      "Bits diameters",
      "Диаметры сверл",
      "Diametri di punte",
      "Bohrerdurchmesser",
      "钻头直径",
      "Diámetros de brocas",                           // ES
      "Diamètres de forets",                           // FR
      "Matkap çapları"};                               // TR

    public static readonly string[] Letters = {
      "Direction Letters",
      "Знаки направления",
      "Simboli di direzione",
      "Richtungsbriefe",
      "方向信",
      "Letras de dirección",                           // ES
      "Lettres de direction",                          // FR
      "Yön harfleri"};                                 // TR

    public static readonly string[] MillMode = {
      "Mode",
      "Режим",
      "Modalità",
      "Modus",
      "模式",
      "Modo",                                          // ES
      "Mode",                                          // FR
      "Mod"};                                          // TR

    public static readonly string[] MillTool = {
      "Tool",
      "Фреза",
      "Attrezzo",
      "Cutter",
      "刀具",
      "Herramienta",                                   // ES
      "Outil",                                         // FR
      "Takım"};                                        // TR

    public static readonly string[] Multiplier = {
      "Size Multiplier",
      "Множитель",
      "Moltiplicatore",
      "Größenmultiplikator",
      "大小乘数",
      "Multiplicador de tamaño",                       // ES
      "Multiplicateur de taille",                      // FR
      "Boyut çarpanı"};                                // TR

    public static readonly string[] OutsideCorners = {
      "Outside",
      "Наружа",
      "Fuori",
      "Außen",
      "外部",
      "Exterior",                                      // ES
      "Extérieur",                                     // FR
      "Dış"};                                          // TR

    public static readonly string[] PocketCorners = {
      "Pockets",
      "Выборки",
      "Tasca",
      "Taschen",
      "口袋",
      "Bolsillos",                                     // ES
      "Poches",                                        // FR
      "Cepler"};                                       // TR

    public static readonly string[] SawDiam = {
      "Diameter",
      "Диаметр",
      "Diametro",
      "Durchmesser",
      "直径",
      "Diámetro",                                      // ES
      "Diamètre",                                      // FR
      "Çap"};                                          // TR

    public static readonly string[] SawMode = {
      "Mode",
      "Режим",
      "Modalità",
      "Modus",
      "模式",
      "Modo",                                          // ES
      "Mode",                                          // FR
      "Mod"};                                          // TR

    public static readonly string[] SawThickness = {
      "Thickness",
      "Толщина",
      "Spessore",
      "Dicke",
      "厚度",
      "Espesor",                                       // ES
      "Épaisseur",                                     // FR
      "Kalınlık"};                                     // TR

    public static readonly string[] SawTool = {
      "Tool",
      "Диск",
      "Attrezzo",
      "Sägeblatt",
      "锯片",
      "Herramienta",                                   // ES
      "Outil",                                         // FR
      "Takım"};                                        // TR

    public static readonly string[] WindowCorners = {
      "Windows",
      "Окна",
      "Finestra",
      "Fenster",
      "视窗",
      "Ventanas",                                      // ES
      "Fenêtres",                                      // FR
      "Pencereler"};                                   // TR

    public static readonly string[] DefaultDepth = {
      "Default depth",
      "Глубина",
      "Profondità",
      "Standardtiefe",
      "默认深度",
      "Profundidad predeterminada",                    // ES
      "Profondeur par défaut",                         // FR
      "Varsayılan derinlik"};                          // TR

    public static readonly string[] InSize = {
      "in Size",
      "по длине",
      "in formato",
      "nach Länge",
      "按长度",
      "por tamaño",                                    // ES
      "par taille",                                    // FR
      "boyuta göre"};                                  // TR

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
        "谨慎修改！",
      "El ángulo máximo (líneas de quiebre) que se puede ignorar. \r\n" +  // ES
        "Grados o radianes (según se establezca en la unidad de dibujo actual). \r\n" +
        "Se usa para combinar líneas, medir ángulos... \r\n" +
        "¡Cambie con precaución!",
      "L'angle maximum (lignes de pliage) qui peut être ignoré. \r\n" +  // FR
        "Degrés ou radians (tel que défini dans l'unité de dessin actuelle). \r\n" +
        "Utilisé pour combiner des lignes, mesurer des angles... \r\n" +
        "Modifiez avec prudence !",
      "Yoksayılabilecek maksimum açı (kırılma çizgileri). \r\n" +  // TR
        "Derece veya radyan (geçerli çizim biriminde ayarlandığı gibi). \r\n" +
        "Çizgileri birleştirmek, açıları ölçmek için kullanılır... \r\n" +
        "Dikkatle değiştirin!"};

    public static readonly string[] BlankOffsetTip = {
      "Offset of the workpiece rectangle from the dimensions of the part.",
      "Офсет прямоугольника заготовки наружу, от габаритов детали.",
      "Offset del rettangolo del pezzo rispetto alle dimensioni del pezzo.",
      "Versatz des Werkstückrechtecks ​​nach außen, von den Abmessungen des Teils.",
      "工件矩形从零件尺寸向外偏移。",
      "Desplazamiento del rectángulo de la pieza en bruto desde las dimensiones de la pieza.",  // ES
      "Décalage du rectangle de la pièce brute par rapport aux dimensions de la pièce.",  // FR
      "İş parçası dikdörtgeninin parça boyutlarından ofseti."};  // TR

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
        "块将被插入模型空间并沿钻孔沿 x 轴旋转，并按钻孔直径和钻孔深度进行缩放。",
      "Nombre del bloque para designación de perforación lateral (horizontal, extremo lateral). \r\n" +  // ES
        "El bloque se insertará solo si los contornos de perforación no verticales están deshabilitados. \r\n" +
        "El bloque se insertará en el espacio del modelo y se girará por el eje X a lo largo de la perforación.",
      "Nom du bloc pour la désignation du perçage latéral (horizontal, extrémité latérale). \r\n" +  // FR
        "Le bloc sera inséré uniquement si les contours de perçage non verticaux sont désactivés. \r\n" +
        "Le bloc sera inséré dans l'espace du modèle et tourné par l'axe X le long du perçage.",
      "Yanal (yatay, yan uç) delme tanımlaması için blok adı. \r\n" +  // TR
        "Blok yalnızca dikey olmayan delme konturları devre dışı bırakıldığında eklenecektir. \r\n" +
        "Blok model alanına eklenecek ve delme boyunca X ekseni tarafından döndürülecektir."};

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
        "块将插入到孔中心的模型空间中，并按比例缩放以适合钻孔直径。",
      "Nombre del bloque para designación de perforación inferior (trasera). \r\n" +  // ES
        "El bloque se insertará solo si los contornos de perforación no verticales están deshabilitados. \r\n" +
        "El bloque se insertará en el espacio del modelo.",
      "Nom du bloc pour la désignation du perçage inférieur (arrière). \r\n" +  // FR
        "Le bloc sera inséré uniquement si les contours de perçage non verticaux sont désactivés. \r\n" +
        "Le bloc sera inséré dans l'espace du modèle.",
      "Alt (arka) delme tanımlaması için blok adı. \r\n" +  // TR
        "Blok yalnızca dikey olmayan delme konturları devre dışı bırakıldığında eklenecektir. \r\n" +
        "Blok model alanına eklenecektir."};

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
        " 块将被插入模型空间并沿钻孔沿 x 轴旋转，并按钻孔直径和钻孔深度进行缩放。",
      "Nombre del bloque para designación de perforación giratoria (inclinada, universal). \r\n" +  // ES
        "El bloque se insertará solo si los contornos de perforación no verticales están deshabilitados. \r\n" +
        "El bloque se insertará en el espacio del modelo y se girará por el eje X a lo largo de la perforación.",
      "Nom du bloc pour la désignation du perçage pivotant (incliné, universel). \r\n" +  // FR
        "Le bloc sera inséré uniquement si les contours de perçage non verticaux sont désactivés. \r\n" +
        "Le bloc sera inséré dans l'espace du modèle et tourné par l'axe X le long du perçage.",
      "Döner (eğimli, evrensel) delme tanımlaması için blok adı. \r\n" +  // TR
        "Blok yalnızca dikey olmayan delme konturları devre dışı bırakıldığında eklenecektir. \r\n" +
        "Blok model alanına eklenecek ve delme boyunca X ekseni tarafından döndürülecektir."};

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
        "如果你用激光切割（切割宽度大约为零），那么只需关闭对切割器直径的考虑。",
      "El diámetro de la herramienta de corte. \r\n" +  // ES
        "Debe ser mayor que cero. \r\n" +
        "Si corta con láser (ancho de corte cercano a cero), simplemente desactive la medición del diámetro de la fresa.",
      "Le diamètre de l'outil de coupe. \r\n" +  // FR
        "Doit être supérieur à zéro. \r\n" +
        "Si vous coupez au laser (largeur de coupe proche de zéro), désactivez simplement la mesure du diamètre de la fraise.",
      "Kesici takımın çapı. \r\n" +  // TR
        "Sıfırdan büyük olmalıdır. \r\n" +
        "Lazer ile kesiyorsanız (kesim genişliği sıfıra yakın), frezenin çapının ölçümünü kapatın."};

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
        "您可以指定 0。",
      "Aumentar el diámetro de este número para obtener una holgura. \r\n" +  // ES
        "Puede asignar un 0.",
      "Augmenter le diamètre de ce nombre pour obtenir un jeu. \r\n" +  // FR
        "Vous pouvez attribuer un 0.",
      "Boşluk elde etmek için bu sayının çapını artırın. \r\n" +  // TR
        "0 atayabilirsiniz."};

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
        "写入 -1 以请求每个命令调用的深度。",
      "Agregar profundidad al final de los nombres de capas. \r\n" +  // ES
        "Usar para el comando DadoLoop (DDL) y para contornos internos del comando OutsideLoop (OSL). \r\n" +
        "Use 0 si no necesita profundidad. \r\n" +
        "Use -1 si desea ingresar la profundidad cada vez.",
      "Ajouter la profondeur à la fin des noms de calques. \r\n" +  // FR
        "À utiliser pour la commande DadoLoop (DDL) et pour les contours intérieurs de la commande OutsideLoop (OSL). \r\n" +
        "Utilisez 0 si vous n'avez pas besoin de profondeur. \r\n" +
        "Utilisez -1 si vous souhaitez saisir la profondeur à chaque fois.",
      "Katman adlarının sonuna derinlik ekleyin. \r\n" +  // TR
        "DadoLoop (DDL) komutu ve OutsideLoop (OSL) komutunun iç konturları için kullanın. \r\n" +
        "Derinliğe ihtiyacınız yoksa 0 kullanın. \r\n" +
        "Her seferinde derinlik girmek istiyorsanız -1 kullanın."};

    public static readonly string[] DirTypesTip = {
      "Drilling direction names for the drilling table. \r\n" +
        "Used in the %drill% substitution. \r\n" +
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
        "9 - 以任意角度倾斜钻孔。",
      "Nombres de dirección de perforación para la tabla de perforación. \r\n" +  // ES
        "Utilizado en la sustitución %drill%. \r\n" +
        "La lista debe contener 9 nombres separados por punto y coma: \r\n" +
        "1 - perforación vertical pasante, \r\n" +
        "2 - perforación vertical ciega desde la fachada, \r\n" +
        "3 - perforación vertical ciega desde atrás, \r\n" +
        "4 - perforación lateral a la izquierda (a lo largo de X), \r\n" +
        "5 - perforación lateral desde arriba (en -Y), \r\n" +
        "6 - perforación lateral a la derecha (por -X), \r\n" +
        "7 - perforación lateral desde abajo (a lo largo de Y), \r\n" +
        "8 - perforación lateral no a lo largo de los ejes, \r\n" +
        "9 - perforación oblicua en ángulos arbitrarios.",
      "Noms de direction de perçage pour la table de perçage. \r\n" +  // FR
        "Utilisé dans la substitution %drill%. \r\n" +
        "La liste doit contenir 9 noms séparés par des points-virgules : \r\n" +
        "1 - perçage vertical traversant, \r\n" +
        "2 - perçage vertical borgne depuis la façade, \r\n" +
        "3 - perçage vertical borgne depuis l'arrière, \r\n" +
        "4 - perçage latéral à gauche (le long de X), \r\n" +
        "5 - perçage latéral depuis le haut (en -Y), \r\n" +
        "6 - perçage latéral à droite (par -X), \r\n" +
        "7 - perçage latéral depuis le bas (le long de Y), \r\n" +
        "8 - perçage latéral pas le long des axes, \r\n" +
        "9 - perçage oblique à des angles arbitraires.",
      "Delme tablosu için delme yönü adları. \r\n" +  // TR
        "%drill% değiştirmesinde kullanılır. \r\n" +
        "Liste noktalı virgülle ayrılmış 9 ad içermelidir: \r\n" +
        "1 - dikey geçmeli delme, \r\n" +
        "2 - cepheden kör dikey delme, \r\n" +
        "3 - arkadan kör dikey delme, \r\n" +
        "4 - solda yanal delme (X boyunca), \r\n" +
        "5 - yukarıdan yanal delme (-Y'de), \r\n" +
        "6 - sağda yanal delme (-X ile), \r\n" +
        "7 - alttan yanal delme (Y boyunca), \r\n" +
        "8 - eksenler boyunca olmayan yanal delme, \r\n" +
        "9 - rastgele açılarda eğik delme."};

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
        "所有其他直径的孔都将落入铣削层。",
      "Lista de diámetros de broca disponibles. \r\n" +  // ES
        "Todos los agujeros de otros diámetros caerán en la capa de fresado.",
      "Liste des diamètres de foret disponibles. \r\n" +  // FR
        "Tous les trous d'autres diamètres tomberont dans la couche de fraisage.",
      "Mevcut matkap çaplarının listesi. \r\n" +  // TR
        "Diğer çaplardaki tüm delikler frezeleme katmanına düşecektir."};

    public static readonly string[] CountersinkTip = {
      "Substitution text %countersink% for countersink holes.",
      "Текст для подстановки %countersink% для отверстий с зенковкой.",
      "Testo di sostituzione %countersink% per fori con svasatura.",
      "Ersetzungstext %countersink% für Senkbohrungen.",
      "用于沉头孔的替换文本 %countersink%。",
      "Texto de sustitución %countersink% para agujeros avellanados.",  // ES
      "Texte de substitution %countersink% pour les trous fraisés.",  // FR
      "Gömme delikleri için %countersink% değiştirme metni." };

    public static readonly string[] FormatTip = {
      "Enter string for control the number of decimal places and insignificant zeros. \r\n" +
        "Symbol 0 - any digit or zero. \r\n" +
        "Symbol # - any digit or nothing. \r\n" +
        "Default '0.#' - interpreted like 1 decimal digit after float point if it not 0.\r\n" +
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
        "CU – wie die Einheiten in der aktuellen Zeichnung eingestellt sind (über das Dialogfeld 'Zeichnungseinheiten') \r\n" +
        "AR, EN, FR – amerikanische Bruchformate",
      "要写多少小数位以及是否写无意义的零。 \r\n" +
        "在格式中使用字符 0 和 #。 \r\n" +
        "0 是一个数字或 0，\r\n" +
        "# 是一个数字或什么都没有。 \r\n" +
        "例如，格式化为 00.00 的数字 1.111111 将显示为 01.11。 \r\n" +
        "并且格式化后的 0.#### 会显示为 1.1111。 \r\n" +
        "而数字 1.2 格式化为 0.#### 将显示为 1.2。 \r\n" +
        "有一些特殊格式： \r\n" +
        "CU - 如何在当前图形中设置单位（通过'图形单位'对话框） \r\n" +
        "AR、EN、FR - 美国分数格式",
      "Ingrese una cadena para controlar el número de lugares decimales y ceros insignificantes. \r\n" +  // ES
        "Símbolo 0 - cualquier dígito o cero. \r\n" +
        "Símbolo # - cualquier dígito o nada. \r\n" +
        "Predeterminado '0.#' - interpretado como 1 dígito decimal después del punto flotante si no es 0.\r\n" +
        "Además puede usar formatos fraccionarios: \r\n" +
        "CU - del dibujo actual (Configúrelo en el cuadro de diálogo Unidades de dibujo) \r\n" +
        "AR - Arquitectónico \r\n" +
        "EN - Ingeniería \r\n" +
        "FR - Fraccionario \r\n" +
        "Después de AR, EN, FR puede escribir precisión (0-8)",
      "Entrez une chaîne pour contrôler le nombre de décimales et de zéros non significatifs. \r\n" +  // FR
        "Symbole 0 - n'importe quel chiffre ou zéro. \r\n" +
        "Symbole # - n'importe quel chiffre ou rien. \r\n" +
        "Par défaut '0.#' - interprété comme 1 chiffre décimal après la virgule s'il n'est pas 0.\r\n" +
        "De plus, vous pouvez utiliser des formats fractionnaires : \r\n" +
        "CU - à partir du dessin actuel (Définissez-le dans la boîte de dialogue Unités de dessin) \r\n" +
        "AR - Architectural \r\n" +
        "EN - Ingénierie \r\n" +
        "FR - Fractionnaire \r\n" +
        "Après AR, EN, FR, vous pouvez écrire la précision (0-8)",
      "Ondalık basamak sayısını ve önemsiz sıfırları kontrol etmek için dize girin. \r\n" +  // TR
        "Sembol 0 - herhangi bir rakam veya sıfır. \r\n" +
        "Sembol # - herhangi bir rakam veya hiçbir şey. \r\n" +
        "Varsayılan '0.#' - 0 değilse kayan nokta sonrası 1 ondalık basamak olarak yorumlanır.\r\n" +
        "Ek olarak kesirli formatları kullanabilirsiniz: \r\n" +
        "CU - geçerli çizimden (Çizim birimleri iletişim kutusunda ayarlayın) \r\n" +
        "AR - Mimari \r\n" +
        "EN - Mühendislik \r\n" +
        "FR - Kesirli \r\n" +
        "AR, EN, FR'den sonra hassasiyeti yazabilirsiniz (0-8)"};

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
        "谨慎修改！",
      "La desviación máxima permitida. \r\n" +  // ES
        "En las unidades de dibujo actuales [mm o pulgadas]. \r\n" +
        "Se usa para eliminar obstrucciones, escombros, aproximar splines. \r\n" +
        "Mínimo 0.0000001, Máximo 5 mm. \r\n" +
        "¡Cambie con precaución!",
      "L'écart maximal autorisé. \r\n" +  // FR
        "Dans les unités de dessin actuelles [mm ou pouce]. \r\n" +
        "Utilisé pour éliminer les obstructions, les débris, approximer les splines. \r\n" +
        "Minimum 0,0000001, Maximum 5 mm. \r\n" +
        "Modifiez avec prudence !",
      "İzin verilen maksimum sapma. \r\n" +  // TR
        "Geçerli çizim birimlerinde [mm veya inç]. \r\n" +
        "Tıkanıklıkları, döküntüleri kaldırmak, spline'ları yaklaştırmak için kullanılır. \r\n" +
        "Minimum 0.0000001, Maksimum 5mm. \r\n" +
        "Dikkatle değiştirin!"};

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
        "仅为方便起见。",
      "El nombre para este estilo CNC. \r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia de elección.",
      "Le nom de ce style CNC. \r\n" +  // FR
        "Non utilisé dans le programme. Uniquement pour la commodité du choix.",
      "Bu CNC stili için ad. \r\n" +  // TR
        "Programda kullanılmaz. Sadece seçim kolaylığı için."};


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
        "多余切口的大小取决于这个参数和工件的厚度。",
      "Diámetro del disco de sierra. \r\n" +  // ES
        "El tamaño del aserrado excesivo depende de este parámetro y del espesor de la pieza.",
      "Diamètre du disque de scie. \r\n" +  // FR
        "La taille du sciage excédentaire dépend de ce paramètre et de l'épaisseur de la pièce.",
      "Testere diski çapı. \r\n" +  // TR
        "Fazla kesme boyutu bu parametreye ve parça kalınlığına bağlıdır."};

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
        "该值决定了允许的槽宽和锯片中心线偏移。",
      "El espesor del disco de sierra. \r\n" +  // ES
        "Debe ser mayor que cero. \r\n" +
        "Este valor determina el ancho de ranura permisible y el desplazamiento de la línea central de la sierra.",
      "L'épaisseur du disque de scie. \r\n" +  // FR
        "Doit être supérieur à zéro. \r\n" +
        "Cette valeur détermine la largeur de rainure admissible et le décalage de la ligne centrale de la scie.",
      "Testere diskinin kalınlığı. \r\n" +  // TR
        "Sıfırdan büyük olmalıdır. \r\n" +
        "Bu değer, izin verilen yuva genişliğini ve testerenin merkez çizgisi ofsetini belirler."};

    public static readonly string[] DiamQueryDiam = {
      "Enter milling cutter diameter",
      "Введите диаметр фрезы",
      "Digitare diametro della fresa",
      "Fräserdurchmesser eingeben",
      "输入刀具直径",
      "Ingrese el diámetro de la fresa",                // ES
      "Entrez le diamètre de la fraise",                // FR
      "Freze çapını girin"};                            // TR

    public static readonly string[] DiamQueryZero = {
      " or zero",
      " или ноль",
      " o lasciare zero",
      " oder null",
      " 或零",
      " o cero",                                         // ES
      " ou zéro",                                       // FR
      " veya sıfır"};                                   // TR

    public static readonly string[] DiamQueryTooSmall = {
      "Cutter diameter is too small",
      "Слишком маленький диаметр фрезы",
      "Diametro della fresa è troppo piccolo",
      "Fräserdurchmesser ist zu klein",
      "刀具直径太小",
      "El diámetro de la fresa es demasiado pequeño",   // ES
      "Le diamètre de la fraise est trop petit",        // FR
      "Freze çapı çok küçük"};                          // TR

  }
}
