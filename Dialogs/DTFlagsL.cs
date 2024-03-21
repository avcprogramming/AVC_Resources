// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class 
  DTFlagsL
  {
    public static readonly string[] AppearanceSimilarity = {
      "Appearance similarity",
      "Проверять внешний вид",
      "Somiglianza nell'aspetto",
      "Äußerliche Ähnlichkeit",
      "外观相似度"};
    public static readonly string[] AppearanceSimilarityTip = {
      "When combining rows, program should consider not only the sorting columns,\r\n" +
        "but also color, layer, linetype, material of the solids and covers.\r\n" +
        "Material is checked only for solids with metric.",
      "При объединении строк программа должна учитывать не только сортировку столбцов,\r\n" +
        "но также цвет, слой, тип линии, материал твердых тел и их покрытия.\r\n" +
        "Материал поверхностей проверяется только у солидов с метрикой.",
      "Nel concatenare le righe, il programma deve considerare non solo l'ordinamento delle colonne,\r\n" +
        "ma anche il colore, lo strato, il tipo di linea, il materiale dei solidi e i loro rivestimenti.\r\n" +
        "Il materiale viene controllato solo per i solidi metrici.",
      "Beim Kombinieren von Zeilen sollte das Programm nicht nur die Sortierspalten berücksichtigen,\r\n" +
        "sondern auch Farbe, Layer, Linientyp, Material der Volumenkörper und Abdeckungen.\r\n" +
         "Material wird nur bei Volumenkörpern mit metrisch geprüft.",
      "合并时，程序不仅会考虑排序，还会考虑颜色、图层、线型、实体和封面的材质。\r\n" +
         "仅检查具有公制单位的三维实体表面材料。"};
    public static readonly string[] DescendSize = {
      "Descending size",
      "По убыванию размера",
      "Dimensione decrescente",
      "Absteigende Größe",
      "降序大小"};
    public static readonly string[] DescendSizeTip = {
      "Sort objects in the table and in numbering in descending order of size, from large to small.\r\n" +
        "This option is only used if all the sorted columns of the Data Table are the same.\r\n" +
        "The lengths and areas of curves, the volume and dimensions of the solid, the scale of the blocks are taken into account.\r\n" +
        "If you turn off the option, then first there will be small details, and then large ones.",
      "Сортировать объекты в таблице и в нумерации по убыванию размеров, от больших к маленьким.\r\n" +
        "Эта опция используется только если все сортированные столбцы Таблицы Данных одинаковые.\r\n" +
        "Учитываются длины и площади кривых, объем и габариты солидов, масштаб блоков.\r\n" +
        "Если выключить опцию, то сначала  будут маленькие детали, а потом большие.",
      "Ordina gli oggetti nella tabella e in numerazione in ordine decrescente di dimensioni, da grande a piccolo.\r\n" +
        "Questa opzione viene utilizzata solo se tutte le colonne ordinate della Tabella dati sono uguali.\r\n" +
        "Vengono prese in considerazione le lunghezze e le aree delle curve,\r\n" +
        "il volume e le dimensioni del solido, la scala dei blocchi.\r\n" +
        "Se disattivi l'opzione, prima ci saranno piccoli dettagli e poi grandi.",
      "Objekte in der Tabelle und in der Nummerierung in absteigender Reihenfolge der Größe sortieren, von groß nach klein.\r\n" +
         "Diese Option wird nur verwendet, wenn alle sortierten Spalten der Datentabelle gleich sind.\r\n" +
         "Die Längen und Flächen von Kurven, das Volumen und die Abmessungen des Körpers, der Maßstab der Blöcke werden berücksichtigt.\r\n" +
         "Wenn Sie die Option deaktivieren, werden zuerst kleine Details und dann große angezeigt.",
      "对表格中的对象进行排序，并按照从大到小的顺序编号。\r\n" +
         "仅当数据表的所有排序列都相同时才使用此选项。\r\n" +
         "曲线的长度和面积、三维实体的体积和尺寸、块的比例都被考虑在内。\r\n" +
         "如果你关闭这个选项，那么首从小到大排序。"};
    public static readonly string[] Geometric = {
      "Geometric similarity",
      "Проверять геометрию",
      "Somiglianza geometrica",
      "Geometrische Ähnlichkeit",
      "几何相似度"};
    public static readonly string[] GeometricTip = {
      "When combining rows, program should consider not only the sorting columns,\r\n" +
        "but also the geometry of the drawing objects.\r\n" +
        "Geometrically different objects should be written in different lines.\r\n" +
        "Geometry is checked only for lines, curves, and solids.\r\n" +
        "The geometry check ignores the position and rotation of objects in space.",
      "При объединении строк следует учитывать не только столбцы сортировки,\r\n" +
        "но и геометрию объектов чертежа.\r\n" +
        "Геометрически разные объекты следует записывать в разные строки.\r\n" +
        "Геометрия проверяется только у линий, кривых и солидов.\r\n" +
        "Проверка геометрии игнорирует положение и разворот объектов в пространстве.",
      "Quando si combinano le righe, il programma dovrebbe considerare non solo le colonne di ordinamento,\r\n" +
        "ma anche la geometria degli oggetti di disegno.\r\n" +
        "Gli oggetti geometricamente diversi dovrebbero essere scritti in righe diverse.\r\n" +
        "La geometria viene controllata solo per linee, curve e solidi.\r\n" +
        "Il controllo della geometria ignora la posizione e la rotazione degli oggetti nello spazio.",
      "Beim Kombinieren von Zeilen sollte das Programm nicht nur die Sortierspalten berücksichtigen,\r\n" +
        "sondern auch die Geometrie der Zeichenobjekte.\r\n" +
         "Geometrisch unterschiedliche Objekte sollten in verschiedenen Zeilen geschrieben werden.\r\n" +
         "Geometrie wird nur auf Linien, Kurven und Volumenkörper geprüft.\r\n" +
         "Die Geometrieprüfung ignoriert die Position und Drehung von Objekten im Raum.",
      "合并行时，程序不仅要考虑排序列，还要考虑绘图对象的几何形状。\r\n" +
         "几何上不同的物体会写在不同的行中。\r\n" +
         "仅检查直线、曲线和三维实体的几何图形。\r\n" +
         "几何检查忽略了对象在模型空间中的位置和旋转方向。"};
    public static readonly string[] MergeSameData = {
      "Merge the same data",
      "Объединять одинаковые",
      "Unisci gli stessi dati",
      "Dieselben Daten zusammenführen",
      "合并相同的数据"};
    public static readonly string[] MergeSameDataTip = {
      "Do not write identical rows to the table, but combine the data into one row.\r\n" +
        "Only sorted columns are checked for similarity; total columns are ignored.\r\n" +
        "The number of objects in the concatenated string can be shown using the %count% substitution.",
      "Не записывать в таблицу одинаковые строки, а объединять данные в одну строку.\r\n" +
        "Только сортированные столбцы проверяются на сходство, суммарные игнорируются.\r\n" +
        "Количество объектов в объединенной строке можно показать с помощью подстановки %count%",
      "Non scrivere righe identiche nella tabella, ma combinare i dati in una riga.\r\n" +
        "Solo le colonne ordinate vengono verificate per somiglianza; le colonne totali vengono ignorate.\r\n" +
        "Il numero di oggetti nella stringa concatenata può essere mostrato usando la sostituzione %count%.",
      "Schreiben Sie keine identischen Zeilen in die Tabelle, sondern fassen Sie die Daten zu einer Zeile zusammen.\r\n" +
         "Nur sortierte Spalten werden auf Ähnlichkeit geprüft; Gesamtspalten werden ignoriert.\r\n" +
         "Die Anzahl der Objekte in der verketteten Zeichenfolge kann mit der Substitution %count% angezeigt werden.",
      "将相同的数据合并为一行。\r\n" +
         "仅检查排序列的相似性；忽略总列。\r\n" +
         "可以使用 %count% 替换来显示连接字符串中的对象数量。"};
    public static readonly string[] Mirror = {
      "Separate mirrored",
      "Зеркальные отдельно",
      "Separato a specchio",
      "Separat gespiegelt",
      "独立镜像"};
    public static readonly string[] MirrorTip = {
      "Write mirrored solid and polyline separate.\r\n" +
        "Mark solid like 'mirrored' using A>V>C> Palette.",
      "Записывать зеркальные полилинии и солиды отдельно.\r\n" +
        "Используйте Палитру A>V>C> для сохранения метки зеркальности у солидов.",
      "Scrivi solido speculare e polilinea separati.\r\n" +
        "Contrassegna il solido come 'specchiato' usando A>V>C> Palette.",
      "Schreiben Sie gespiegelten Volumenkörper und Polylinie getrennt. "+
         "Markieren Sie solide wie 'gespiegelt' mit A>V>C> Palette.",
      "将镜像实体和多段线分开。\r\n" +
         "使用 A>V>C> 属性板(特性板)将实体标记为‘镜像’。"};
    public static readonly string[] MultiplyRequest = {
      "Multiplication request",
      "Запрос умножения",
      "Richiesta di moltiplicazione",
      "Multiplikationsanfrage",
      "乘法请求"};
    public static readonly string[] MultiplyRequestTip = {
      "Multiply the number of parts by an integer.\r\n" +
        "This will help fill the table for making a large series of identical products.",
      "Запрашивать число, на которое будет умножено количество объектов.\r\n" +
        "Используйте для вычисления количества деталей в партии.",
      "Moltiplicare il numero di parti per un numero intero.\r\n" +
        "Ciò contribuirà a riempire il tavolo per realizzare una grande serie di prodotti identici.",
      "Multiplizieren Sie die Anzahl der Teile mit einer ganzen Zahl. "+
         "Dies wird dazu beitragen, den Tisch für die Herstellung einer großen Serie identischer Produkte zu füllen.",
      "将零件数乘以一个整数。 " };
    public static readonly string[] NumberingTip = {
      "Call NUMBERING command before.\r\n" +
        "Use this to automatically assign a name to objects.\r\n" +
        "Numbering command is configured separately.",
      "Дать всем объектам имена в виде номеров по порядку.\r\n" +
        "Имена сохранятся в xData объектов и могут быть использованы на Умных выносках.\r\n" +
        "Нумерация настраивается отдельно.",
      "Chiamare prima il comando NUMBERING.\r\n" +
        "Usalo per assegnare automaticamente un nome agli oggetti.\r\n" +
        "Il comando di numerazione è configurato separatamente.",
      "Rufen Sie vorher den NUMBERING-Befehl auf.\r\n" +
         "Verwenden Sie dies, um Objekten automatisch einen Namen zuzuweisen.",
      "在平铺命令之前调用(NUMBERING)编号命令进行命名。\r\n" +
         "使用它可以自动为对象编号(名称)。"};

  }
}
