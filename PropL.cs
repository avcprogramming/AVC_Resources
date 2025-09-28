// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Viewports Nameds Dwg Bandings Asymmetry Uniscale Asym CNC CCW Plottable Linetype

using System;
using System.Collections.Generic;
using System.Reflection;

namespace AVC
{
  /// <summary>
  /// Localization of properties
  /// Имена и описания для всех свойств объектов чертежа на всех языках
  /// </summary>
  [Obfuscation(Exclude = true, Feature = "renaming")]
  public static class
  PropL
  {
    public static readonly string[] Meter = {
      "m",
      "м",
      "m",
      "m",
      "米" };
    public static readonly string[] Millimeter = {
      "mm",
      "мм",
      "mm",
      "mm",
      "毫米" };
    public static readonly string[] Inch = {
      "in",
      "дюйм",
      "pollice",
      "zol",
      "英寸" };
    public static readonly string[] Millimeters = {
      "Millimeters",
      "Миллиметры",
      "Millimetri",
      "Millimeter",
      "毫米" };
    public static readonly string[] Inches = {
      "Inches",
      "Дюймы",
      "Pollici",
      "Zoll",
      "英寸" };
    public static readonly string[] Default = {
      "Default",
      "По умолчанию",
      "Predefinito",
      "Standard",
      "默认" };
    public static readonly string[] NoSelected = {
      "Nothing selected",
      "Ничего не выбрано",
      "Niente di selezionato",
      "Nichts ausgewählt",
      "未选择任何内容" };
    public static readonly string[] ArabicNumerals = {
      "Arabic Numerals",
      "Арабские цифры",
      "Numeri arabi",
      "Numeri arabi",
      "阿拉伯数字" };
    public static readonly string[] RomanNumerals = {
      "Roman Numerals",
      "Римские цифры",
      "Numeri romani",
      "Römische Zahlen" ,
      "罗马数字"};
    public static readonly string[] EnglishAlphabet = {
      "English Alphabet",
      "Английский алфавит",
      "Alfabeto inglese",
      "Englisches Alphabet",
      "英文字母" };
    public static readonly string[] CyrillicAlphabet = {
      "Cyrillic Alphabet",
      "Кириллица",
      "Alfabeto cirillico",
      "Kyrillisches Alphabet",
      "西里尔字母/俄语字母" };
    public static readonly string[] SavePrepare = {
      "Checking for Changes",
      "Проверка изменений",
      "Verifica delle modifiche",
      "Änderungen überprüfen",
      "检查更改" };
    public static readonly string[] Search = {
      "Search",
      "Поиск",
      "Ricerca",
      "Suche",
      "搜索" };
    public static readonly string[] FoundObjectsTip = {
      "Found {0} objects with property {1}={2}",
      "Найдено {0} объектов со свойством {1}={2}",
      "Trovati {0} oggetti con proprietà {1}={2}",
      "{0} Objekte mit der Eigenschaft {1}={2} gefunden",
      "找到 {0} 个具有属性 {1}={2} 的对象" };
    public static readonly string[] SelectByTypeTip = {
      "Double click will leave only that object type selected",
      "Двойной клик оставит выбранными только этот тип объектов",
      "Un doppio clic lascerà selezionato solo quel tipo di oggetto",
      "Ein Doppelklick lässt nur diesen Objekttyp ausgewählt",
      "双击将只选择该对象类型" };
    public static readonly string[] DuplicateKeyErr = {
      "The name {0} has already been used.",
      "Имя {0} уже использовано.",
      "Il nome {0} è già stato usato.",
      "Der Name {0} wurde bereits verwendet.",
      "名称 {0} 已被使用。" };
    public static readonly string[] ExternalDataSizeExceeded = {
      "Too much data for one object. The xData size limit has been exceeded.",
      "Слишком много данных для одного объекта. Превышено ограничение на размер xData.",
      "Troppi dati per un oggetto. Il limite della dimensione xData è stato superato.",
      "Zu viele Daten für ein Objekt. Die Größenbeschränkung für xData wurde überschritten.",
      "一个对象的数据过多。已超出 xData 大小限制。"};
    public static readonly string[] AddPropertyTip = {
      "Add a property/attribute to this list.",
      "Добавить свойство/атрибут к этому списку.",
      "Aggiungi una proprietà/attributo a questo elenco.",
      "Fügen Sie dieser Liste eine Eigenschaft / ein Attribut hinzu.",
      "将属性/属性添加到此列表。" };
    public static readonly string[] FieldParsingErr = {
      "Error parsing field '{0}' : {1}",
      "Ошибка в поле '{0}' : {1}",
      "Errore durante l'analisi del campo '{0}' : {1}",
      "Fehler beim Parsen von Feld '{0}' : {1}",
      "解析字段“{0}”时出错：{1}" };
    public static readonly string[] ReadingProperties = {
      "  Reading drawing object properties",
      "  Чтение свойств объектов чертежа",
      "  Lettura di oggetti di disegno",
      "  Zeichnungsobjekte lesen",
      "  读取绘图对象的属性"};
    public static readonly string[] NoUserProperty =  {
      "You do not have any custom properties set. " +
        "To purchase a special version with the custom properties you need, write to AVC technical support.",
      "У вас не установлены никакие пользовательские свойства. " +
        "Для покупки специальной версии с нужными вам пользовательскими свойствами напишите в техподдержку AVC.",
      "Non hai impostato alcuna proprietà personalizzata. " +
        "Per acquistare una versione speciale con le proprietà personalizzate di cui hai bisogno, scrivi al supporto tecnico AVC.",
      "Sie haben keine benutzerdefinierten Eigenschaften festgelegt. " +
        "Um eine spezielle Version mit den von Ihnen benötigten benutzerdefinierten Eigenschaften zu erwerben, " +
        "schreiben Sie an den technischen Support von AVC.",
      "您没有设置任何自定义属性。要购买具有所需自定义属性的特殊版本，请写信给 AVC 技术支持。"};
    public static readonly string[] Properties = {
      "Properties",
      "Свойства",
      "Proprietà",
      "Eigenschaften",
      "特性" };
    public static readonly string[] Actions = {
      "Actions",
      "Действия",
      "Azioni",
      "Aktionen",
      "行动" };

    //public static readonly string[] Donation = { "", "Пожертвовать", "Donare", "Spenden" };
    //public static readonly string[] DonationTip = {
    //  "Donate any small amount for plugin development. You can donate at any time: simply because you like the A> V> C> plugins and want to motivate further development, or if you have a great new idea or like the updates in new versions. Remember that all new features and new versions of A> V> C> plugins are provided free of charge, but require a lot of development effort.", 
    //  "Пожертвуйте любую небольшую сумму на разработку плагинов.\r\n" +
    //  "Вы можете сделать пожертвование в любой момент:\r\n" +
    //  "просто потому что вам нравятся плагины A>V>C>,\r\n" +
    //  "и вы хотите мотивировать дальнейшую разработку,\r\n" +
    //  "или если вам пришла в голову прекрасная новая идея\r\n" +
    //  "или понравились обновления в новых версиях.\r\n" +
    //  "Помните, что все новые функции и новые версии\r\n" +
    //  "плагинов A>V>C> предоставляются бесплатно,\r\n" +
    //  "но требуют много сил для разработки.",
    //  "Dona una piccola somma per lo sviluppo di plugin. Puoi donare in qualsiasi momento: semplicemente perché ti piacciono i plugin A>V>C> e vuoi motivare ulteriori sviluppi, o se hai una nuova grande idea o se ti piacciono gli aggiornamenti nelle nuove versioni. Ricorda che tutte le nuove funzionalità e le nuove versioni dei plug-in A> V> C> sono fornite gratuitamente, ma richiedono un grande sforzo di sviluppo.",
    //  "Spende einen kleinen Betrag für die Plugin-Entwicklung. Sie können jederzeit spenden: einfach weil Ihnen die A>V>C>-Plugins gefallen und Sie zur Weiterentwicklung motivieren möchten, oder wenn Sie eine tolle neue Idee haben oder die Updates in neuen Versionen mögen. Denken Sie daran, dass alle neuen Funktionen und neuen Versionen von A> V> C>-Plugins kostenlos zur Verfügung gestellt werden, aber viel Entwicklungsaufwand erfordern." };

    // ================================================================================================
    // Object =====================================================================
    public static readonly string[] Object = {
      "Object",
      "Объект",
      "Oggetto",
      "Objekt",
      "对象"};
    public static readonly string[] Objects = {
      "Objects",
      "Объекты",
      "Gli oggetti",
      "Die Objekte",
      "多个对象" };
    public static readonly string[] Id = { "ID" };
    public static readonly string[] IdTip = {
      "Object identifier. Changes each time the drawing is loaded.",
      "Идентификатор объекта. Меняется при каждой загрузке чертежа.",
      "Identificatore di oggetto. Cambia ogni volta che viene caricato il disegno.",
      "Objektkennung. Ändert sich jedes Mal, wenn die Zeichnung geladen wird.",
      "对象标识符。 每次加载图形时都会更改。" };
    public static readonly string[] Handle = { "Handle", "Хэндл" };
    public static readonly string[] HandleTip = {
      "Object identifier. \r\n" +
        "It is immutable, but local, that is, it can be repeated in an external reference.",
      "Идентификатор объекта. \r\n" +
        "Неизменен, но локален, то есть может повториться во внешней ссылке.",
      "Identificatore di oggetto. \r\n" +
        "È immutabile, ma locale, cioè può essere ripetuto in un riferimento esterno.",
      "Objektkennung. \r\n" +
        "Es ist unveränderlich, aber lokal, dh es kann in einer externen Referenz wiederholt werden.",
      "对象标识符。 \r\n" +
         "它是不可变的，但是是局部的，也就是说，它可以在外部引用中重复。" };
    public static readonly string[] ObjectType = {
      "Object Type",
      "Тип объекта",
      "Tipo di oggetto",
      "Objekttyp",
      "对象类型" };
    public static readonly string[] ObjectTypeTip = {
      "The public name of this drawing object type.",
      "Внутреннее название данного типа объектов чертежа.",
      "Il nome interno di questo tipo di oggetto di disegno.",
      "Der interne Name dieses Zeichnungsobjekttyps.",
      "此图形对象类型的内部名称。" };
    public static readonly string[] xData = {
      "xData ",
      "хДанные ",
      "xData ",
      "xData ",
      "xData "};
    public static readonly string[] Name = {
      "Name",
      "Имя",
      "Nome",
      "Name",
      "姓名" };
    public static readonly string[] NameTip = {
      "The number or name for this object. \r\n" +
        "Use for detail headers in plugins A>V>C> (LAY, Sawing Table, Smart Leader)",
      "Номер позиции или наименование для этого объекта. \r\n" +
        "Используйте для заголовков деталей в плагинах A>V>C> (Выкладка, Таблица напилки, Умные выноски)",
      "Il numero o il nome per questo oggetto. \r\n" +
        "Utilizzare per le intestazioni dei dettagli nei plug-in A>V>C> (LAY, Sawing Table, Smart Leader)",
      "Die Nummer oder der Name für dieses Objekt. \r\n" +
        "Verwendung für Detailkopfzeilen in Plugins A>V>C> (LAY, Sägetabelle, Smart Leader)",
      "此对象的编号或名称。 \r\n" +
        "用于插件A>V>C>（LAY，Sawing Table，Smart Leader）中的详细标题"};
    public static readonly string[] Kind = {
      "Kind",
      "Сорт",
      "Tipo",
      "Art",
      "种类" };
    public static readonly string[] KindTip = {
      "Kind, type of object. \r\n" +
        "Use it for plugins Lay, Sawing Table, Smart Leader",
      "Тип, сорт, вид объекта. \r\n" +
        "Можно использовать для заметок и для плагинов Выкладка, Таблица напилки, Умные выноски",
      "Genere, tipo di oggetto. \r\n" +
        "Può essere utilizzato per note e plug-in LAY, Tavolo da Sega, Smart Leader",
      "Art, Typ des Objekts. \r\n" +
        "Kann für Notizen und Plug-Ins LAY, Sägetabelle, Smart Leader verwendet werden",
      "对象的种类和类型。 \r\n" +
        "用于插件 Lay(平铺), Sawing Table(数据表), Smart Leader(智能多重引线)"};
    public static readonly string[] Info = {
      "Info",
      "Информация",
      "Informazioni",
      "Info",
      "信息" };
    public static readonly string[] InfoTip = {
      "Description of this object.\r\n" +
        "You can write any text. You can insert line breaks.\r\n" +
        "Usually this data is not visible in the drawing, but can be used when extracting the data.",
      "Описание данного объекта. \r\n" +
        "Можно написать любой текст.  Можно вставлять переносы строки. \r\n" +
        "Обычно эти данные не видимы в чертеже, но могут быть использованы при извлечении данных.",
      "Descrizione di questo oggetto. \r\n" +
        "Puoi scrivere qualsiasi testo. È possibile inserire interruzioni di riga. \r\n" +
        "Solitamente questi dati non sono visibili nel disegno, \r\n" +
        "ma possono essere utilizzati durante l'estrazione dei dati.",
      "Beschreibung dieses Objekts. \r\n" +
        "Sie können jeden beliebigen Text schreiben. Sie können Zeilenumbrüche einfügen. \r\n" +
        "Normalerweise sind diese Daten in der Zeichnung nicht sichtbar, \r\n" +
        "können aber beim Extrahieren der Daten verwendet werden.",
      "此对象的描述说明。 你可以写任何文字。 您可以插入换行符。 \r\n" +
        "通常这些数据在绘图中是不可见的，但可以在提取数据时使用。"};
    public static readonly string[] CustomPropertyTip = {
      "Additional custom property for storing any text.",
      "Дополнительное пользовательское свойство для хранения любого текста.",
      "Proprietà personalizzata aggiuntiva per la memorizzazione di qualsiasi testo.",
      "Zusätzliche benutzerdefinierte Eigenschaft zum Speichern von beliebigem Text.",
      "用于存储任何文本的附加自定义属性。"};
    public static readonly string[] Named = {
      "Named",
      "Именованный",
      "Detto",
      "Benannt",
      "命名" };
    public static readonly string[] Nameds = {
      "Named",
      "Именованные",
      "Detto",
      "Benannt",
      "命名" };

    // ============================================================================================
    // Entity =====================================================================================
    public static readonly string[] Entity = {
      "Entity",
      "Примитив",
      "Entità",
      "Entität",
      "实体" };
    public static readonly string[] Entities = {
      "Entities",
      "Примитивы",
      "Entità",
      "Entitäten",
      "多个实体" };
    public static readonly string[] Area = {
      "Area",
      "Площадь",
      "Area",
      "Fläche",
      "面积" };
    public static readonly string[] AreaTip = {
      "The area of the front side of a solid or the area of a curve or surface.\r\n" +
        "In a millimeter drawing, the area will be converted to square meters.",
      "Площадь фасадной стороны солида или площадь кривой или поверхности.\r\n" +
        "В миллиметровом чертеже площадь будет пересчитана в квадратные метры.",
      "L'area del lato anteriore di un solido o l'area di una curva o superficie.\r\n" +
        "In un disegno millimetrico, l'area verrà convertita in metri quadrati.",
      "Die Fläche der Vorderseite eines Volumenkörpers oder die Fläche einer Kurve oder Fläche.\r\n" +
        "Bei einer Millimeterzeichnung wird die Fläche in Quadratmeter umgerechnet.",
      "实体正面的面积或曲线或曲面的面积。\r\n" +
         "在毫米单位图形中，面积将转换为平方米。" };
    public static readonly string[] BasePoint = {
      "Base Point",
      "Базовая Точка",
      "Punto base",
      "Basispunkt",
      "基点" };
    public static readonly string[] BasePointX = {
      "Base Point X",
      "Базовая Точка X",
      "Punto base X",
      "Basispunkt X",
      "基点 X" };
    public static readonly string[] BasePointY = {
      "Base Point Y",
      "Базовая Точка Y",
      "Punto base Y",
      "Basispunkt Y",
      "基点 Y" };
    public static readonly string[] BasePointZ = {
      "Base Point Z",
      "Базовая Точка Z",
      "Punto base Z",
      "Basispunkt Z",
      "基点 Z" };
    public static readonly string[] BasePointXTip = {
      "X coordinate of the base point = position, insertion point, first vertex.\r\n" +
        "In current user coordinate system (UCS)",
      "X координата базовой точки  = позиция, точка вставки, первый вертекс.\r\n" +
        "В текущей пользовательской системе координат (UCS)",
      "Coordinata X del punto base = posizione, punto di inserimento, primo vertice.\r\n" +
        "Nel sistema di coordinate utente corrente (UCS)",
      "X-Koordinate des Basispunktes = Position, Einfügepunkt, erster Eckpunkt.\r\n" +
        "Im aktuellen Benutzerkoordinatensystem (BKS)",
      "基点 X 坐标 = 位置、插入点、第一个顶点。\r\n" +
         "在当前用户坐标系 (UCS)" };
    public static readonly string[] BasePointYTip = {
      "Y coordinate of the base point = position, insertion point, first vertex.\r\n" +
        "In current user coordinate system (UCS)",
      "Y координата базовой точки  = позиция, точка вставки, первый вертекс.\r\n" +
        "В текущей пользовательской системе координат (UCS)",
      "Coordinata Y del punto base = posizione, punto di inserimento, primo vertice.\r\n" +
        "Nel sistema di coordinate utente corrente (UCS)",
      "Y-Koordinate des Basispunktes = Position, Einfügepunkt, erster Eckpunkt.\r\n" +
        "Im aktuellen Benutzerkoordinatensystem (BKS)",
      "基点 Y 坐标 = 位置、插入点、第一个顶点。\r\n" +
         "在当前用户坐标系 (UCS)" };
    public static readonly string[] BasePointZTip = {
      "Z coordinate of the base point = position, insertion point, first vertex.\r\n" +
        "In current user coordinate system (UCS)",
      "Z координата базовой точки  = позиция, точка вставки, первый вертекс.\r\n" +
        "В текущей пользовательской системе координат (UCS)",
      "Coordinata Z del punto base = posizione, punto di inserimento, primo vertice.\r\n" +
        "Nel sistema di coordinate utente corrente (UCS)",
      "Z-Koordinate des Basispunktes = Position, Einfügepunkt, erster Eckpunkt.\r\n" +
        "Im aktuellen Benutzerkoordinatensystem (BKS)",
      "基点 Y 坐标 = 位置、插入点、第一个顶点。\r\n" +
         "在当前用户坐标系 (UCS)" };
    public static readonly string[] ColorName = {
      "Color",
      "Цвет",
      "Colore",
      "Farbe",
      "颜色" };
    public static readonly string[] ColorNameTip = {
      "You can write any color name.\r\n" +
        "The program will try to recognize it.\r\n" +
        "The ByLayer color will be replaced with the layer color.",
      "Можете написать любое название цвета.\r\n" +
        "Программа постарается его распознать.\r\n" +
        "Цвет ПоСлою будет заменен на цвет слоя.",
      "Puoi scrivere qualsiasi nome di colore.\r\n" +
        "Il programma cercherà di riconoscerlo.\r\n" +
        "Il colore ByLayer verrà sostituito con il colore del livello.",
      "Sie können einen beliebigen Farbnamen schreiben.\r\n" +
        "Das Programm wird versuchen, es zu erkennen.\r\n" +
        "Die VonLayer-Farbe wird durch die Layer-Farbe ersetzt.",
      "您可以编写任何颜色名称。\r\n" +
         "程序将尝试识别它。\r\n" +
         "ByLayer 颜色将替换为图层颜色。" };
    public static readonly string[] ColorKey = {
      "Color",
      "Цвет",
      "Colore",
      "Farbe",
      "颜色" };
    public static readonly string[] ColorKeyTip = {
      "Color without specifying a color book. \r\n" +
        "If the color does not have a name, then the digital color index or RGB code. \r\n" +
        "The ByLayer color is replaced by the color of the layer.",
      "Цвет без указания цветовой книги. \r\n" +
        "Если у цвета нет имени – цифровой индекс цвета или RGB-код. \r\n" +
        "«По слою» - заменяется на цвет слоя.",
      "Colora senza specificare un libro dei colori. \r\n" +
        "Se il colore non ha un nome, allora l'indice di colore digitale o il codice RGB. \r\n" +
        "'ByLayer'- viene sostituito dal colore del layer.",
      "Farbe ohne Angabe eines Farbbuchs. \r\n" +
        "Wenn die Farbe keinen Namen hat, dann der digitale Farbindex oder RGB-Code. \r\n" +
        "Die VonLayer-Farbe wird durch die Layer-Farbe ersetzt.",
      "不指定配色系统的颜色。 \r\n" +
         "如果颜色没有名称，则为数字颜色索引或 RGB 代码。\r\n" +
         "ByLayer 颜色被图层颜色替换。" };
    public static readonly string[] ColorBook = {
      "Color Book",
      "Цветовая книга",
      "Libro a colori",
      "Farbbuch",
      "颜色库" };
    public static readonly string[] ColorBookTip = {
      "The full name of the color. \r\n" +
        "If the color does not have a name, then the digital color index or RGB code. \r\n" +
        "The ByLayer color will be replaced with the layer color. \r\n" +
        "If the color is selected from a color book, then the name of the book is indicated.",
      "Полное имя цвета. \r\n" +
        "Если у цвета нет имени – цифровой индекс цвета или RGB-код. \r\n" +
        "«По слою» -заменяется на цвет слоя. \r\n" +
        "Если цвет выбран из книги цветов, то указывается название книги.",
      "Il nome completo del colore. \r\n" +
        "Se il colore non ha un nome, allora l'indice di colore digitale o il codice RGB. \r\n" +
        "Il colore ByLayer verrà sostituito con il colore del livello. \r\n" +
        "Se il colore viene selezionato da un libro dei colori, viene indicato il nome del libro.",
      "Der vollständige Name der Farbe. \r\n" +
        "Wenn die Farbe keinen Namen hat, dann der digitale Farbindex oder RGB-Code. \r\n" +
        "Die VonLayer-Farbe wird durch die Layer-Farbe ersetzt. \r\n" +
        "Wenn die Farbe aus einem Farbbuch ausgewählt wird, wird der Name des Buches angezeigt.",
      "颜色的全称。 \r\n" +
         "如果颜色没有名称，则为数字颜色索引或 RGB 代码。\r\n" +
         "ByLayer 颜色将替换为图层颜色。\r\n" +
         "如果颜色是从颜色库中选择的，那么会显示该颜色的名称。" };
    public static readonly string[] LineType = {
      "Line Type",
      "Тип линий",
      "Tipo di linea",
      "Linientyp",
      "线型"};
    public static readonly string[] LineTypeTip = {
      "The style of strokes and spaces used to represent the lines of an object.",
      "Стиль штрихов и пробелов, которыми изображаются линии объекта.",
      "Lo stile dei tratti e degli spazi utilizzati per rappresentare le linee di un oggetto.",
      "Der Stil von Strichen und Leerzeichen, der zur Darstellung der Linien eines Objekts verwendet wird.",
      "用于表示对象线条的笔画和空格的样式。"};
    public static readonly string[] LinetypeScale = {
      "Linetype Scale",
      "Масштаб линий",
      "Scala della linea",
      "Linientypskalierung",
      "线型比例"};
    public static readonly string[] LinetypeScaleTip = {
      "The scale by which the line type is increased. Sets the sizes of strokes and spaces.",
      "Масштаб на который увеличивается тип линий. Задает размеры штрихов и пробелов.",
      "La scala in base alla quale viene aumentato il tipo di linea. Imposta le dimensioni dei tratti e degli spazi.",
      "Der Maßstab, um den der Linientyp vergrößert wird. Legt die Größe von Strichen und Leerzeichen fest.",
      "线型增加的比例。 设置笔画和空格的大小。"};
    public static readonly string[] LineWeight = {
      "Line Weight",
      "Вес линий",
      "Spessore",
      "Linienstärke",
      "线宽"};
    public static readonly string[] LineWeightTip = {
      "Line thickness when printing",
      "Толщина линий при печати",
      "Spessore della linea durante la stampa",
      "Linienstärke beim Drucken",
      "打印时线宽"};
    public static readonly string[] Transparency = {
      "Transparency",
      "Прозрачность",
      "Trasparenza",
      "Transparenz",
      "透明度"};
    public static readonly string[] TransparencyTip = {
      "The object's transparency percentage. From 0% (completely opaque) to 90% (almost invisible)",
      "Процент прозрачности объекта. От 0% (совсем непрозрачен) до 90% (почти невидимый)",
      "La percentuale di trasparenza dell'oggetto. Dallo 0% (completamente opaco) al 90% (quasi invisibile)",
      "Der Transparenzprozentsatz des Objekts. Von 0 % (völlig undurchsichtig) bis 90 % (fast unsichtbar)",
      "对象的透明度百分比。 从 0%（完全不透明）到 90%（几乎不可见）"};
    public static readonly string[] PlotStyleName = {
      "Plot Style",
      "Стиль печати",
      "Stile di trama",
      "Handlungsstil",
      "情节风格"};
    public static readonly string[] PlotStyleNameTip = {
      "The print style sets the color and thickness of the lines on the printer. \r\n" +
        "This property is available if the entire drawing is configured to print by style rather than by color.",
      "Стиль печати задает цвет и толщину линий на принтере. \r\n" +
        "Данное свойство доступно если весь чертеж настроен на печать по стилям, а не по цвету",
      "Lo stile di stampa imposta il colore e lo spessore delle linee sulla stampante. \r\n" +
        "Questa proprietà è disponibile se l'intero disegno è configurato per la stampa in base allo stile anziché al colore.",
      "Der Druckstil legt die Farbe und Stärke der Linien auf dem Drucker fest. \r\n" +
        "Diese Eigenschaft ist verfügbar, wenn die gesamte Zeichnung so konfiguriert ist, \r\n" +
        "dass sie nach Stil und nicht nach Farbe gedruckt wird.",
      "打印样式设置打印机上线条的颜色和粗细。 如果整个绘图配置为按样式而不是按颜色打印，则此属性可用。"};
    public static readonly string[] ExtentsX = {
      "Extents X",
      "Габарит X",
      "Dimensioni X",
      "Maße X",
      "范围 X" };
    public static readonly string[] Visible = {
      "Visible",
      "Видимый",
      "Visibile",
      "Sichtbar",
      "可见的"};
    public static readonly string[] VisibleTip = {
      "Showing an object in a drawing. Objects hidden in this way are only available in the Drawing Tree.",
      "Показ объекта в чертеже. Скрытые таким способом объекты доступны только в Дереве Чертежа.",
      "Mostrare un oggetto in un disegno. Gli oggetti nascosti in questo modo sono disponibili solo nell'Albero di disegno.",
      "Ein Objekt in einer Zeichnung anzeigen. Auf diese Weise ausgeblendete Objekte sind nur im Zeichnungsbaum verfügbar.",
      "在绘图中显示对象。 以这种方式隐藏的对象仅在绘图树中可用。"};
    public static readonly string[] ExtentsXTip = {
      "X dimensions of the dimensional box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Размеры по X габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "Dimensioni X della scatola dimensionale in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "X-Abmessungen des Maßkastens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的尺寸框的X尺寸。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] ExtentsY = {
      "Extents Y",
      "Габарит Y",
      "Dimensioni Y",
      "Maße Y",
      "范围 Y" };
    public static readonly string[] ExtentsYTip = {
      "Y dimensions of the dimensional box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Размеры по Y габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "Dimensioni Y della scatola dimensionale in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Y-Abmessungen des Maßkastens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的尺寸框的Y尺寸。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] ExtentsZ = {
      "Extents Z",
      "Габарит Z",
      "Dimensioni Z",
      "Maße Z",
      "范围 Z" };
    public static readonly string[] ExtentsZTip = {
      "Z dimensions of the dimensional box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Размеры по Z габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "Dimensioni Z della scatola dimensionale in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Z-Abmessungen des Maßkastens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的尺寸框的Z尺寸。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] Hyperlink = {
      "Hyperlink",
      "Гиперссылка",
      "Hyperlink",
      "Hyperlink",
      "超链接" };
    public static readonly string[] HyperlinkURL = {
      "Hyperlink URL",
      "Гиперссылка Адрес",
      "Hyperlink URL",
      "Hyperlink URL",
      "超链接 URL" };
    public static readonly string[] HyperlinkTip = {
      "Hyperlink to any site.\r\n" +
        "The beginning of the link (site address) can be common for all objects in the drawing.\r\n" +
        "To do this, write the site into the Link property of the drawing, and for objects,\r\n" +
        "write only the end of the URL (the name of the web page).\r\n" +
        "If you assign references to solids and polylines,\r\n" +
        "then you cannot use CTRL to select sub-objects (faces and segments).",
      "Гиперссылка на любой сайт.\r\n" +
        "Начало ссылки (адрес сайта) может быть общим у всех объектов чертежа.\r\n" +
        "Для этого запишите сайт в свойство Ссылка чертежа, а у объектов записывайте только конец URL (имя web-страницы).\r\n" +
        "Если вы присвоите ссылки солидам и полилиниям,\r\n" +
        "то вы не сможете использовать CTRL для выбора подобъектов (граней и сегментов).",
      "Collegamento ipertestuale a qualsiasi sito.\r\n" +
        "L'inizio del collegamento (indirizzo del sito) può essere comune a tutti gli oggetti nel disegno.\r\n" +
        "Per fare ciò, scrivi il sito nella proprietà Link del disegno e, \r\n" +
        "per gli oggetti, scrivi solo la fine dell'URL (il nome della pagina web).\r\n" +
        "Se assegni riferimenti a solidi e polilinee,\r\n" +
        "quindi non è possibile utilizzare CTRL per selezionare i sub-oggetti (facce e segmenti).",
      "Hyperlink zu einer beliebigen Site.\r\n" +
        "Der Anfang des Links (Site-Adresse) kann für alle Objekte in der Zeichnung gleich sein.\r\n" +
        "Schreiben Sie dazu die Site in die Link-Eigenschaft der Zeichnung \r\n" +
        "und schreiben Sie bei Objekten nur das Ende der URL (den Namen der Webseite).\r\n" +
        "Wenn Sie Volumenkörpern und Polylinien Referenzen zuweisen,\r\n" +
        "dann können Sie die STRG-Taste nicht verwenden, um Unterobjekte (Flächen und Segmente) auszuwählen.",
      "指向任何站点的超链接。\r\n" +
         "链接的开头（网站地址）对于绘图中的所有对象可以是通用的。\r\n" +
         "为此，将网址写入绘图的 Link 属性，对于对象，\r\n" +
         "只写 URL 的结尾（网页的名称）。\r\n" +
         "如果将引用指定给实体和多段线，\r\n" +
         "那么您不能使用 CTRL 来选择子对象（面和线段）。" };
    public static readonly string[] Layer = {
      "Layer",
      "Слой",
      "Layer",
      "Layer",
      "图层"};
    public static readonly string[] Layers = {
      "Layers",
      "Слои",
      "Layer",
      "Layer",
      "图层"};
    public static readonly string[] LayerTip = {
      "You can write any layer name.\r\n" +
        "The program will find the layer in the drawing or template.\r\n" +
        "Or create a new layer.",
      "Можете написать любое название слоя.\r\n" +
        "Программа найдет слой в чертеже или шаблоне.\r\n" +
        "Или создаст новый слой.",
      "Puoi scrivere qualsiasi nome di livello.\r\n" +
        "Il programma troverà il livello nel disegno o nel modello.\r\n" +
        "Oppure crea un nuovo livello.",
      "Sie können einen beliebigen Layernamen schreiben.\r\n" +
        "Das Programm findet die Ebene in der Zeichnung oder Vorlage.\r\n" +
        "Oder erstellen Sie eine neue Ebene.",
      "您可以编写任何图层名称。\r\n" +
         "程序将在绘图或模板中查找图层。\r\n" +
         "或者创建一个新图层。"};
    public static readonly string[] Length = {
      "Length",
      "Длина",
      "Lunghezza",
      "Länge",
      "长度" };
    public static readonly string[] LengthTip = {
      "The maximum of the overall dimensions of the solid or the length of the line.",
      "Максимальный из габаритных размеров солида или длина линии.",
      "Il massimo delle dimensioni complessive del solido o la lunghezza della linea.",
      "Das Maximum der Gesamtabmessungen des Volumenkörpers oder der Länge der Linie.",
      "三维实体整体尺寸的最大值或线的长度。"};
    public static readonly string[] MinExtentsX = {
      "Minimum point of extents X",
      "Минимальная точка габаритов X",
      "Punto minimo delle dimensioni X",
      "Mindestpunkt der Abmessungen X" ,
      "范围 X 的最小点"};
    public static readonly string[] MinExtentsXTip = {
      "The X-coordinate of the minimum point of the bounding box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Координата X минимальной точки габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "La coordinata X del punto minimo del riquadro di delimitazione in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Die X-Koordinate des kleinsten Punkts des Begrenzungsrahmens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的边界框最小点的 X 坐标。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] MinExtentsY = {
      "Minimum point of extents Y",
      "Минимальная точка габаритов Y",
      "Punto minimo delle dimensioni Y",
      "Mindestpunkt der Abmessungen Y",
      "范围 Y 的最小点" };
    public static readonly string[] MinExtentsYTip = {
      "The Y-coordinate of the minimum point of the bounding box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Координата Y минимальной точки габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "La coordinata Y del punto minimo del riquadro di delimitazione in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Die Y-Koordinate des kleinsten Punkts des Begrenzungsrahmens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte." ,
      "对象适合的边界框最小点的 Y 坐标。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。"};
    public static readonly string[] MinExtentsZ = {
      "Minimum point of extents Z",
      "Минимальная точка габаритов Z",
      "Punto minimo delle dimensioni Z",
      "Mindestpunkt der Abmessungen Z",
      "范围 Z 的最小点" };
    public static readonly string[] MinExtentsZTip = {
      "The Z-coordinate of the minimum point of the bounding box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Координата Z минимальной точки габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "La coordinata Z del punto minimo del riquadro di delimitazione in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Die Z-Koordinate des kleinsten Punkts des Begrenzungsrahmens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的边界框最小点的 Z 坐标。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] MaxExtentsX = {
      "Maximum point of extents X",
      "Максимальная точка габаритов X",
      "Punto massimo delle dimensioni X",
      "Maximaler Punkt der Abmessungen X",
      "范围 X 的最大点" };
    public static readonly string[] MaxExtentsXTip = {
      "The X coordinates of the maximum point of the bounding box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Координаты X максимальной точки габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "Le coordinate X del punto massimo del riquadro di delimitazione in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Die X-Koordinaten des höchsten Punkts des Begrenzungsrahmens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的边界框最大点的 X 坐标。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] MaxExtentsY = {
      "Maximum point of extents Y",
      "Максимальная точка габаритов Y",
      "Punto massimo delle dimensioni Y",
      "Maximaler Punkt der Abmessungen Y",
      "范围 Y 的最大点" };
    public static readonly string[] MaxExtentsYTip = {
      "The Y coordinates of the maximum point of the bounding box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Координаты Y максимальной точки габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "Le coordinate Y del punto massimo del riquadro di delimitazione in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Die Y-Koordinaten des höchsten Punkts des Begrenzungsrahmens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的边界框最大点的 Y 坐标。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] MaxExtentsZ = {
      "Maximum point of extents Z",
      "Максимальная точка габаритов Z",
      "Punto massimo delle dimensioni Z",
      "Maximaler Punkt der Abmessungen Z",
      "范围 Z 的最大点" };
    public static readonly string[] MaxExtentsZTip = {
      "The Z coordinates of the maximum point of the bounding box into which the object fits. \r\n" +
        "In WCS world coordinate system or owner block coordinate system. \r\n" +
        "Does not work for blocks and some auxiliary objects.",
      "Координаты Z максимальной точки габаритного бокса, в который влезает объект. \r\n" +
        "В мировой системе координат WCS или системе координат блока-владельца. \r\n" +
        "Не работает у блоков и некоторых вспомогательных объектов.",
      "Le coordinate z del punto massimo del riquadro di delimitazione in cui si inserisce l'oggetto. \r\n" +
        "Nel sistema di coordinate mondiali WCS o nel sistema di coordinate del blocco proprietario. \r\n" +
        "Non funziona per blocchi e alcuni oggetti ausiliari.",
      "Die Z-Koordinaten des höchsten Punkts des Begrenzungsrahmens, in den das Objekt passt. \r\n" +
        "Im WCS-Weltkoordinatensystem oder Eigentümerblock-Koordinatensystem. \r\n" +
        "Funktioniert nicht für Blöcke und einige Hilfsobjekte.",
      "对象适合的边界框最大点的 Z 坐标。 \r\n" +
         "在 WCS 世界坐标系或所有者块坐标系中。\r\n" +
         "不适用于块和一些辅助对象。" };
    public static readonly string[] Perimeter = {
      "Perimeter",
      "Периметр",
      "Perimetro",
      "Umfang",
      "周长" };
    public static readonly string[] PerimeterTip = {
      "The length of the perimeter of the front side of the solid or the length of the line. \r\n" +
        "In a millimeter drawing, the perimeter will be converted to meters.",
      "Длина периметра фасадной стороны солида или длина линии.\r\n" +
        " В миллиметровом чертеже периметр будет пересчитан в метры.",
      "La lunghezza del perimetro del lato anteriore del solido o la lunghezza della linea. \r\n" +
        "In un disegno millimetrico, il perimetro sarà convertito in metri.",
      "Die Länge des Umfangs der Vorderseite des Volumenkörpers oder die Länge der Linie. \r\n" +
        "In einer Millimeterzeichnung wird der Umfang in Meter umgerechnet.",
      "实体正面的周长或线的长度。 \r\n" +
         "在毫米单位图形中，周长将转换为米。" };

    // =====================================================================
    // Arc Circle ==========================================================
    public static readonly string[] Arc = {
      "Arc",
      "Дуга",
      "Arco",
      "Bogen",
      "弧" };
    public static readonly string[] Circle = {
      "Circle",
      "Окружность",
      "Cerchio",
      "Kreis",
      "圆" };
    public static readonly string[] Circles = {
      "Circles",
      "Окружности",
      "Cerchi",
      "Kreise",
      "圆圈" };
    public static readonly string[] Angle = {
      "Angle",
      "Угол",
      "Angolo",
      "Winkel",
      "角度" };
    public static readonly string[] Diameter = {
      "Diameter",
      "Диаметр",
      "Diametro",
      "Durchmesser",
      "直径" };
    public static readonly string[] Radius = {
      "Radius",
      "Радиус",
      "Raggio",
      "Radius",
      "半径" };

    // ================================================================================================
    // Attribute ================================================================================================
    public static readonly string[] Attribute = {
      "Attribute",
      "Атрибут",
      "Attributo",
      "Attribut",
      "属性" };
    public static readonly string[] Attributes = {
      "Attributes",
      "Атрибуты",
      "Attributo",
      "Attribut",
      "属性" };
    public static readonly string[] Constant = {
      "Constant",
      "Константный",
      "Costante",
      "Konstante",
      "持续的" };
    public static readonly string[] ConstantTip = {
      "The attribute is stored only in the block definition, it is not present in block references.\r\n" +
        "The value of the attribute is set at creation and is no longer mutable.",
      "Атрибут хранится только в определении блока, его нет у ссылок на блок.\r\n" +
        "Значение атрибута задано при создании. Менять его у разных ссылок нельзя.",
      "L'attributo è memorizzato solo nella definizione di blocco, non è presente nei riferimenti di blocco.\r\n" +
        "Il valore dell'attributo è impostato al momento della creazione e non è più modificabile.",
      "Das Attribut wird nur in der Blockdefinition gespeichert, es ist nicht in Blockreferenzen vorhanden.\r\n" +
        "Der Wert des Attributs wird bei der Erstellung festgelegt und ist nicht mehr änderbar.",
      "该属性仅存储在块定义中，不存在于块引用中。\r\n" +
         "属性的值是在创建时设置的，不再是可变的。" };
    public static readonly string[] Invisible = {
      "Invisible",
      "Невидимый",
      "Invisibile",
      "Unsichtbar",
      "不可见" };
    public static readonly string[] InvisibleTip = {
      "The attribute is hidden from view in the drawing,\r\n" +
        "is intended only for storing information for later retrieval of data.",
      "Атрибут скрыт от просмотра в чертеже,\r\n" +
        "предназначен только для хранения информации для последующего извлечения данных.",
      "L'attributo è nascosto alla vista nel disegno,\r\n" +
        "è inteso solo per la memorizzazione di informazioni per il successivo recupero dei dati.",
      "Das Attribut ist in der Zeichnung nicht sichtbar,\r\n" +
        "ist nur zum Speichern von Informationen zum späteren Abrufen von Daten bestimmt.",
      "该属性在绘图中被隐藏，\r\n" +
         "仅用于存储信息以供以后检索数据。" };

    // ================================================================================================
    // Block     // ================================================================================================
    public static readonly string[] Block = {
      "Block",
      "Блок",
      "Blocco",
      "Block",
      "块"};
    public static readonly string[] Blocks = {
      "Blocks",
      "Блоки",
      "Blocchi",
      "Mehrere Block",
      "块" };
    public static readonly string[] BlockDefinitions = {
      "Block definitions",
      "Определения блоков",
      "Definizioni di blocco",
      "Blockdefinitionen",
      "块定义" };
    public static readonly string[] BlockOwner = {
      "Block Owner",
      "Блок-владелец",
      "Blocca proprietario",
      "Blockbesitzer",
      "区块拥有者"};
    public static readonly string[] Array = {
      "Array",
      "Массив",
      "Serie",
      "Anordnung",
      "阵列"};
    public static readonly string[] Arrays = {
      "Arrays",
      "Массивы",
      "Serie",
      "Anordnung",
      "阵列" };
    public static readonly string[] Assembly = {
      "Assembly",
      "Сборка",
      "Assemblee",
      "Montage",
      "集会" };
    public static readonly string[] Assemblies = {
      "Assemblies",
      "Сборки",
      "Assemblea",
      "Montage",
      "装配体" };
    public static readonly string[] BlockInstance = {
      "Block Instance",
      "Экземпляр блока",
      "Istanza di blocco",
      "Blockinstanz",
      "块实例" };
    public static readonly string[] BlockInstances = {
      "Block Instances",
      "Экземпляры блока",
      "Istanze di blocco",
      "Instanzen von Block",
      "块的实例" };
    public static readonly string[] BlockNameTip = {
      "Name of selected block.\r\n" +
        "The name must be unique.\r\n" +
        "The following characters are not allowed in names\r\n" +
        ";,=\\|/:*?`\"<>",
      "Имя выбранного блока.\r\n" +
        "Имя должно быть уникальным в чертеже.\r\n" +
        "Следующие символы недопустимы в именах блоков:\r\n" +
        ";,=\\|/:*?`\"<>",
      "Nome del blocco selezionato.\r\n" +
        "Il nome deve essere univoco.\r\n" +
        "I seguenti caratteri non sono ammessi nei nomi\r\n" +
        ";,=\\|/:*?`\"<>",
      "Name des ausgewählten Blocks.\r\n" +
        "Der Name muss eindeutig sein.\r\n" +
        "Die folgenden Zeichen sind in Namen nicht erlaubt\r\n" +
        ";,=\\|/:*?`\"<>",
      "所选块的名称。\r\n" +
         "名称必须是唯一的。\r\n" +
         "名称中不允许出现以下字符\r\n" +
         ";,=\\|/:*?`\"<>" };
    public static readonly string[] BlockEditor = {
      "Block Editor",
      "Редактор блоков",
      "Editor di blocchi",
      "Blockeditor",
      "块编辑器" };
    public static readonly string[] Annotative = {
      "Annotative",
      "Аннотативный",
      "Annotativo",
      "Anmerkung",
      "注释性的" };
    public static readonly string[] AnnotativeTip = {
      "The block is annotative, that is, it is some kind of symbol, icon, label, and not an object of the real world.\r\n"+
         "In model space, such blocks can be automatically scaled depending on the print settings.\r\n" +
         "AVC programs ignore such blocks, do not consider them as assemblies or purchased items.",
      "Блок аннотативный, то есть это какое-то условное обозначение, значок, метка, а не предмет реального мира.\r\n" +
        "В пространстве модели, такие блоки могут автоматически масштабироваться в зависимости от настроек печати.\r\n" +
        "Программы AVC игнорирую такие блоки, не считают их ни сборками, ни покупными изделиями.",
      "Il blocco è annotativo, cioè è una sorta di simbolo, icona, etichetta e non un oggetto del mondo reale.\r\n" +
        "Nello spazio modello, tali blocchi possono essere ridimensionati automaticamente \r\n" +
        "a seconda delle impostazioni di stampa.\r\n" +
        "I programmi AVC ignorano tali blocchi, non li considerano come assemblaggi o articoli acquistati.",
      "Der Block ist annotativ, das heißt, er ist eine Art Symbol, Icon, Label und kein Objekt der realen Welt.\r\n" +
         "Im Modellbereich können solche Blöcke je nach Druckeinstellungen automatisch skaliert werden.\r\n" +
         "AVC-Programme ignorieren solche Blöcke, betrachten sie nicht als Baugruppen oder gekaufte Artikel.",
      "块是注释性的，即它是某种符号、图标、标签，而不是现实世界的对象。\r\n" +
         "在模型空间中，这些块可以根据打印设置自动缩放。\r\n" +
         "AVC 程序会忽略此类块，不会将它们视为程序集或购买的物品。" };

    public static readonly string[] Explodable = {
      "Explodable",
      "Взрываемый",
      "Consenti Esplodi",
      "Explodieren zulassen",
      "可分解的" };
    public static readonly string[] ExplodableTip = {
      "This block can be exploded into separate parts.\r\n" +
        "In AVC programs, such blocks are considered as assemblies, \r\n" +
        "and you can work with parts inside such blocks.\r\n" +
         "If the block is non-explosive, then AVC programs treat it as a purchased product \r\n" +
        "and do not attempt to work with the parts inside it.",
      "Данный блок можно взорвать на отдельные детали.\r\n" +
        "В программах AVC такие блоки считаются сборками и можно работать с деталями внутри таких блоков.\r\n" +
        "Если блок невзрываемый, то программы AVC считают его покупным изделием \r\n" +
        "и не пытаются работать с деталями внутри него.",
      "Questo blocco può essere esploso in parti separate.\r\n" +
        "Nei programmi AVC, tali blocchi sono considerati come assiemi \r\n" +
        "e puoi lavorare con parti all'interno di tali blocchi.\r\n" +
        "Se il blocco non è esplosivo, i programmi AVC lo trattano come un prodotto acquistato \r\n" +
        "e non tentano di lavorare con le parti al suo interno.",
      "Dieser Block kann in einzelne Teile zerlegt werden.\r\n" +
        "In AVC-Programmen werden solche Blöcke als Baugruppen betrachtet, \r\n" +
        "und Sie können mit Teilen in solchen Blöcken arbeiten.\r\n" +
        "Wenn der Block nicht explosiv ist, behandeln AVC-Programme ihn wie ein gekauftes Produkt \r\n" +
        "und versuchen nicht, mit den darin enthaltenen Teilen zu arbeiten.",
      "这个块可以分解成单独的零件。\r\n" +
         "在 AVC 程序中，此类块被视为组件，您可以在此类块内处理零件。\r\n" +
         "如果块是非爆炸性的，那么 AVC 程序会将其视为购买的产品，并且不会尝试使用其中的零件。" };
    public static readonly string[] NonExplodable = {
      "Prohibit exploding",
      "Не взрываемый",
      "Proibire l'esplosione",
      "Explodieren verbieten",
      "非爆炸性" };
    public static readonly string[] Units = {
      "Units",
      "Единицы",
      "Unità",
      "Einheiten",
      "单位" };
    public static readonly string[] UnitsTip = {
      "It is important to correctly set up drawing and block units.\r\n" +
        "Otherwise, there will be problems with the scale of inserting blocks into different drawings.",
      "Важно правильно настроить единицы чертежа и блоков.\r\n" +
        "Иначе будут проблемы с масштабом вставки блоков в разные чертежи.",
      "È importante impostare correttamente le unità di disegno e blocco.\r\n" +
        "In caso contrario, ci saranno problemi con la scala di inserimento di blocchi in disegni diversi.",
      "Es ist wichtig, Zeichnungs- und Blockeinheiten richtig einzurichten.\r\n" +
        "Andernfalls treten Probleme mit dem Maßstab beim Einfügen von Blöcken in verschiedene Zeichnungen auf.",
      "正确设置绘图和块单位很重要。\r\n" +
         "否则，在不同的图纸中插入块的比例会出现问题。" };
    public static readonly string[] Measure = {
      "Measure",
      "Обмерять",
      "Misurare",
      "Messen",
      "措施" };
    public static readonly string[] MeasureTip = {
      "Allow the program to replace the metric values when calling the commands SolSize, Lay, Saw and others.",
      "Разрешить программе подменять значения метрик при вызове SolSize, Lay, Saw и других команд.",
      "Consenti al programma di sostituire i valori metrici quando si chiamano i comandi SolSize, Lay, Saw e altri.",
      "Lassen Sie das Programm die Metrikwerte ersetzen, wenn Sie die Befehle SolSize, Lay, Saw und andere aufrufen.",
      "允许程序在调用 SolSize、Lay、Saw 等命令时替换度量值。" };
    public static readonly string[] MeasureBlockTip = {
      "Enable or disable block size analysis in the BlockMetric command.\r\n" +
        "If there is a nested block for which measurement is disabled, \r\n" +
        "the program will add those metrics that were previously recorded.",
      "Разрешить или блокированить анализ размеров блока в команде BlockMetric.\r\n" +
        "Если найдется вложенный блок, у которого запрещен обмер, \r\n" +
        "то программа прибавит те метрики, какие были ранее записаны.",
      "Abilita o disabilita l'analisi della dimensione del blocco nel comando BlockMetric.\r\n" +
        "Se è presente un blocco nidificato per il quale la misurazione è disabilitata, \r\n" +
        "il programma aggiungerà le metriche precedentemente registrate.",
      "Aktivieren oder deaktivieren Sie die Blockgrößenanalyse im BlockMetric-Befehl.\r\n" +
        "Wenn es einen verschachtelten Block gibt, für den die Messung deaktiviert ist, \r\n" +
        "fügt das Programm die zuvor aufgezeichneten Metriken hinzu.",
      "在 BlockMetric 命令中启用或禁用块大小分析。\r\n" +
         "如果存在禁用测量的嵌套块，\r\n" +
         "该程序将添加之前记录的那些指标。" };
    public static readonly string[] MeasureBlocked = {
      "Solid measurement prohibited",
      "Обмер солида запрещен",
      "Misurazione solida vietata",
      "Volumenkörper Messung verboten",
      "禁止固体测量"};
    //public static readonly string[] Extents = { "Extents", "Габарит", "Dimensioni", "Maße" };
    public static readonly string[] Size = {
      "Size",
      "Размер",
      "Dimensioni",
      "Größe",
      "尺寸" };
    public static readonly string[] BlockMetricAreaTip = {
      "Block metric. The total area of all objects in the block.\n " +
        "For solids, the area of the facade surface is taken into account.",
      "Метрика блока. Суммарная площадь всех объектов в блоке.\n " +
        "Для солидов учитывается площадь фасадной поверхности.",
      "Blocco metrica. L'area totale di tutti gli oggetti nel blocco.\n " +
        "Per i solidi, viene presa in considerazione l'area della superficie della facciata.",
      "Metrik blockieren. Die Gesamtfläche aller Objekte im Block.\n " +
        "Bei Volumenkörpern wird die Fläche der Fassadenfläche berücksichtigt.",
      "块指标。 块中所有对象的总面积。\n " +
         "对于三维实体，考虑了立面面积。"};
    public static readonly string[] BlockMetricCostTip = {
      "Block metric. The total price of parts, coatings and nested blocks.",
      "Метрика блока. Суммарная цена деталей, покрытий и вложенных блоков.",
      "Blocco metrica. Il prezzo totale di parti, rivestimenti e blocchi annidati.",
      "Metrik blockieren. Der Gesamtpreis von Teilen, Beschichtungen und verschachtelten Blöcken.",
      "块指标。 零件、涂层和嵌套块的总价格。"  };
    public static readonly string[] BlockMetricSizeXTip = {
      "Block metric. Overall dimension X in the public coordinate system of the block.",
      "Метрика блока. Габаритный размер X во внутренней системе координат блока.",
      "Blocca metrica. Dimensione complessiva X nel sistema di coordinate interne del blocco.",
      "Metrik blockieren. Gesamtmaß X im internen Koordinatensystem des Blocks.",
      "块指标。 块内部坐标系中的总尺寸(外形) X。"};
    public static readonly string[] BlockMetricSizeYTip = {
      "Block metric. Overall dimension Y in the public coordinate system of the block.",
      "Метрика блока. Габаритный размер Y во внутренней системе координат блока.",
      "Blocca metrica. Dimensione complessiva Y nel sistema di coordinate interne del blocco.",
      "Metrik blockieren. Gesamtmaß Y im internen Koordinatensystem des Blocks.",
      "块指标。 块内部坐标系中的总尺寸(外形) Y。"};
    public static readonly string[] BlockMetricSizeZTip = {
      "Block metric. Overall dimension Z in the public coordinate system of the block.",
      "Метрика блока. Габаритный размер Z во внутренней системе координат блока.",
      "Blocca metrica. Dimensione complessiva Z nel sistema di coordinate interne del blocco.",
      "Metrik blockieren. Gesamtmaß Z im internen Koordinatensystem des Blocks.",
      "块指标。 块内部坐标系中的总尺寸(外形) Z。"};
    public static readonly string[] BlockMetricPerimeterTip = {
      "Block metric. The total length of all curves in the block. \r\n" +
        "The sum of the perimeters of the facades of all solid.",
      "Метрика блока. Суммарная длина всех кривых в блоке. \r\n" +
        "Сумма периметров фасадов всех солидов.",
      "Blocco metrica. La lunghezza totale di tutte le curve nel blocco. \r\n" +
        "La somma dei perimetri delle facciate di tutti i solidi.",
      "Metrik blockieren. Die Gesamtlänge aller Kurven im Block. \r\n" +
        "Die Summe der Umfänge der Fassaden aller soliden.",
      "块指标。 块中所有曲线的总长度。 \r\n" +
         "所有实体立面的周长总和。"};
    public static readonly string[] BlockMetricMeasureTip = {
      "Setting the measurement procedure for this block.\n  " +
        "Yes - software measurement.\n  " +
        "No - use the metric values entered by the user.",
      "Настройка процедуры обмера для данного блока.\n  " +
        "Да - обмерять программно.\n  " +
        "Нет - использовать значения метрики, которые ввел пользователь.",
      "Impostazione della procedura di misurazione per questo blocco.\n  " +
        "Sì - misurazione software.\n  " +
        "No - utilizzare i valori metrici inseriti dall'utente.",
      "Einstellen des Messverfahrens für diesen Block.\n  " +
        "Ja - Softwaremessung.\n  " +
        "Nein - Verwenden Sie die vom Benutzer eingegebenen metrischen Werte.",
      "设置此块的测量程序。\n " +
         "是 - 软件测量。\n " +
         "否 - 使用用户输入的值。"};
    public static readonly string[] BlockMetricVolumeTip = {
      "Block metric. The total volume of all objects in the block.",
      "Метрика блока. Суммарный объем всех объектов в блоке.",
      "Blocco metrica. Il volume totale di tutti gli oggetti nel blocco.",
      "Metrik blockieren. Das Gesamtvolumen aller Objekte im Block.",
      "块指标。 块中所有对象的总体积。"};
    public static readonly string[] BlockMetricWeightTip = {
      "Block metric. \r\n" +
        "The weight of the parts for which the material is indicated, \r\n" +
        "and for the material the density is indicated.",
      "Метрика блока. \r\n" +
        "Вес деталей у которых указан материал, а у материала указана плотность.",
      "Blocco metrica. \r\n" +
        "Il peso delle parti per le quali è indicato il materiale e per il materiale è indicata la densità.",
      "Metrik blockieren. \r\n" +
        "Das Gewicht der Teile, für die das Material angegeben ist, \r\n" +
        "und für das Material wird die Dichte angegeben.",
      "块指标。\r\n" +
         "指定材料的零件重量，\r\n" +
         "对于材料，显示密度。"};
    public static readonly string[] BlockNameExistsErr = {
      "This block name already exists in the drawing: {0}",
      "Такое имя блока уже есть в чертеже: {0}",
      "Questo nome di blocco esiste già nel disegno: {0}",
      "Dieser Blockname ist bereits in der Zeichnung vorhanden: {0}",
      "图形中已存在此块名：{0}"};
    public static readonly string[] LayoutNameExistsErr = {
      "This layout name already exists in the drawing: {0}",
      "Такое имя листа уже есть в чертеже: {0}",
      "Questo nome di layout esiste già nel disegno: {0}",
      "Dieser Layoutname ist bereits in der Zeichnung vorhanden: {0}",
      "此布局名称已存在于绘图中：{0}"};
    public static readonly string[] AssignNameErr = {
      "Can not assign a name {0}",
      "Невозможно присвоить имя  {0}",
      "Non è possibile assegnare un nome  {0}",
      "Kann keinen Namen vergeben  {0}",
      "无法指定名称 {0}"};

    // ================================================================================================
    // Entity Filter for Blocks =======================================================================
    public static readonly string[] BlockAssembly = {
      "Block-Assembly",
      "Блок-Сборки",
      "Blocco-Assemblee",
      "Block-Montage",
      "块-集会"};
    public static readonly string[] BlockProduct = {
      "Block-Product",
      "Блок-Изделие",
      "Blocco-Prodotto",
      "Block-Produkt",
      "块-产品"};
    public static readonly string[] BlockAnnotation = {
      "Block-Annotation",
      "Блок-Аннотация",
      "Blocco-Annotazione",
      "Block-Anmerkung",
      "块-注解"};

    // ================================================================================================
    // BlockRef =======================================================================================
    public static readonly string[] BlockReference = {
      "Block Reference",
      "Ссылка на блок",
      "Riferimento di blocco",
      "Blockreferenz",
      "块参照" };
    public static readonly string[] BlockReferences = {
      "Block References",
      "Ссылки на блоки",
      "Riferimenti a blocchi",
      "Verweise blockieren",
      "块参照" };
    public static readonly string[] BlockRefNameTip = {
      "Block name.\r\n" +
        "Use the Block tab to edit the name\r\n" +
        "and other immutable block properties.",
      "Имя блока.\r\n" +
        "Используйте закладку Блок, чтоб редактировать имя\r\n" +
        "и другие неизменяемые свойства блока.",
      "Nome del blocco.\r\n" +
        "Utilizzare la scheda Blocca per modificare il nome\r\n" +
        "e altre proprietà di blocco immutabili.",
      "Blockname.\r\n" +
        "Verwenden Sie die Registerkarte Block, um den Namen zu bearbeiten\r\n" +
        "und andere unveränderliche Blockeigenschaften.",
      "块名称。\r\n" +
         "使用块选项卡编辑名称\r\n" +
         "和其他不可变的块属性。" };
    public static readonly string[] NonUniscale = {
      "Distorted",
      "Искажен",
      "Distorsione",
      "Verzerrt",
      "扭曲的" };
    public static readonly string[] Scale = {
      "Scale",
      "Масштаб",
      "Scale",
      "Rahmen",
      "比例" };
    public static readonly string[] ScaleTip = {
      "The scale for inserting the block into the model.\r\n" +
        "If scales differ on different axes, then 0. Negative scale (mirror) is set in a separate property.",
      "Масштаб вставки блока в модель. Если масштабы отличаются по разным осям, то 0.\r\n" +
        "Отрицательный масштаб (зеркальность) настраивается в отдельном свойстве.",
      "La scala per l'inserimento del blocco nel modello. Se le scale differiscono su assi diversi, allora 0.\r\n" +
        "La scala negativa (specchio) viene impostata in una proprietà separata.",
      "Die Skala zum Einfügen des Blocks in das Modell. Wenn Skalen auf verschiedenen Achsen unterschiedlich sind, dann 0.\r\n" +
        "Negative Skala (Spiegelung) wird in einer separaten Eigenschaft eingestellt.",
      "将块插入模型的比例。\r\n" +
         "如果不同轴上的比例不同，则为 0。负比例（镜像）在单独的属性中设置。" };
    public static readonly string[] StandardScale = {
      "Standard Scale",
      "Стандартный Масштаб",
      "Scala standard",
      "Standard-Skala",
      "标准比例" };
    public static readonly string[] Mirror = {
      "Mirror",
      "Зеркальный",
      "Specchio",
      "Spiegelbildlich",
      "镜像" };
    public static readonly string[] BlockMirrorTip = {
      "Inserting a mirrored block.\r\n" +
        "When this property is switched, the program changes the sign of the scale along the X axis",
      "Вставка отзеркаленного блока.\r\n" +
        "При пререключении этого свойства, программа меняет знак масштаба по оси X",
      "Inserimento di un blocco specchiato.\r\n" +
        "Quando questa proprietà viene cambiata, il programma cambia il segno della scala lungo l'asse X",
      "Einfügen eines gespiegelten Blocks.\r\n" +
        "Wenn diese Eigenschaft umgeschaltet wird, ändert das Programm das Vorzeichen der Skala entlang der X-Achse" ,
      "插入一个镜像块。\r\n" +
         "切换此属性时，程序沿X轴改变刻度的符号"};
    public static readonly string[] Instance = {
      "Instance",
      "Экземпляр",
      "Esempio",
      "Beispiel",
      "实例" };
    public static readonly string[] InstanceTip = {
      "Instance name of a dynamic block or mechanical component, set of parameters",
      "Имя экземпляра динамического блока или Mechanical-компонента, вариант набора параметров",
      "Nome istanza di un blocco dinamico o componente meccanico, set di parametri",
      "Instanzname eines dynamischen Blocks oder einer mechanischen Komponente, Parametersatz",
      "动态块或机械组件的实例名称，一组参数" };

    // ================================================================================================
    // Curve     
    // ================================================================================================
    public static readonly string[] Curve = {
      "Curve",
      "Кривая",
      "Curva",
      "Kurve",
      "曲线" };
    public static readonly string[] Curves = {
      "Curves",
      "Кривые",
      "Curve",
      "Kurven" ,
      "曲线"};
    public static readonly string[] Line = {
      "Line",
      "Линия",
      "Linea",
      "Linie" ,
      "线"};
    public static readonly string[] Ray = {
      "Ray",
      "Луч",
      "Raggio",
      "Strahl",
      "射线" };
    public static readonly string[] Spline = {
      "Spline",
      "Сплайн",
      "Spline",
      "Spline",
      "样条曲线" };
    public static readonly string[] Ellipse = {
      "Ellipse",
      "Эллипс",
      "Ellisse",
      "Ellipse",
      "椭圆" };
    public static readonly string[] Thickness3d = {
      "Thickness 3D",
      "3D толщина",
      "Spessore 3D",
      "Dicke 3D",
      "厚度 3D" };
    public static readonly string[] Thickness3dTip = {
      "Pseudo-3D curve height in the Z-axis direction. A curve with thickness looks like a surface.\r\n" +
        "Can be set to less than zero. Used to set the milling depth on some CNCs.",
      "Псевдо-3D высота кривой в направлении оси Z. Кривая с толщиной выглядит как поверхность.\r\n" +
        "Можно задать меньше ноля. Используется для задания глубины фрезерования на некоторых ЧПУ.",
      "Altezza pseudo-3D della curva lungo l'asse Z. Una curva con spessore appare come una superficie.\r\n" +
        "Puoi impostare un valore inferiore a zero. \r\n" +
        "Viene utilizzato per specificare la profondità di fresatura su alcuni CNC.",
      "Pseudo-3D-Höhe der Kurve in Richtung der Z-Achse. Eine Kurve mit Dicke sieht aus wie eine Oberfläche.\r\n" +
        "Sie können einen Wert kleiner als Null angeben. \r\n" +
        "Wird zum Festlegen der Frästiefe auf einigen CNCs verwendet.",
      "曲线在 Z 轴方向上的伪 3D 高度。具有厚度的曲线看起来像一个表面。\r\n" +
         "可以设置小于零的值。用于在某些 CNC 上指定铣削深度。" };
    public static readonly string[] EndPointX = {
      "End Point X",
      "Конечная Точка X",
      "Punto finale X",
      "Endpunkt X",
      "终点 X" };
    public static readonly string[] EndPointY = {
      "End Point Y",
      "Конечная Точка Y",
      "Punto finale Y",
      "Endpunkt Y",
      "终点 Y" };
    public static readonly string[] EndPointZ = {
      "End Point Z",
      "Конечная Точка Z",
      "Punto finale Z",
      "Endpunkt Z",
      "终点 Z" };
    public static readonly string[] MidPointX = {
      "Mid Point X",
      "Средняя Точка X",
      "Punto medio X",
      "Mittelpunkt X",
      "中点 X" };
    public static readonly string[] MidPointY = {
      "Mid Point Y",
      "Средняя Точка Y",
      "Punto medio Y",
      "Mittelpunkt Y",
      "中点 Y" };
    public static readonly string[] MidPointZ = {
      "Mid Point Z",
      "Средняя Точка Z",
      "Punto medio Z",
      "Mittelpunkt Z",
      "中点 Z" };

    // ================================================================================================
    // CNC Contours     
    // ================================================================================================
    public static readonly string[] CNC = {
      "CNC",
      "ЧПУ",
      "CNC",
      "CNC",
      "数控" };
    public static readonly string[] ZCoordinate = {
      "Z coordinate",
      "Координата Z",
      "Coordinata Z",
      "Z-Koordinate",
      "Z坐标" };
    public static readonly string[] ZFromTop = {
      "Z from top",
      "Z от верха",
      "Z dall'alto",
      "Z von oben",
      "从顶部开始的 Z 坐标" };
    public static readonly string[] Depth = {
      "Depth",
      "Глубина",
      "Profondità",
      "Tiefe",
      "深度" };
    public static readonly string[] Passage = {
      "Passage",
      "Проход",
      "Passaggio",
      "Passage",
      "頻道" };
    public static readonly string[] Number = {
      "Drilling Number",
      "Номер сверления",
      "Numero del trapano",
      "Bohrernummer",
      "鑽頭數量" };
    public static readonly string[] AngleFromVertical = {
      "Incline",
      "Наклон",
      "Inclinare",
      "Neigung",
      "倾斜" };
    public static readonly string[] AngleMinus = {
      "Incline. Inverted",
      "Наклон. Инверт.",
      "Inclinare. invertito",
      "Neigung. Invertiert",
      "倾斜。 倒" };
    public static readonly string[] Rotation = {
      "Rotation",
      "Разворот",
      "Rotazione",
      "Drehung",
      "旋转" };
    public static readonly string[] RotationMinus = {
      "Rotation from -X",
      "Вращение от -X",
      "Rotazione da -X",
      "Drehung von -X.",
      "从 -X 轴旋转" };
    public static readonly string[] Slope = {
      "Slope angle",
      "Угол уклона",
      "Pendio",
      "Steigung",
      "坡度角" };
    public static readonly string[] SlopeMinus = {
      "Slope angle. With sign change",
      "Угол уклона. С заменой знака",
      "Pendio. Con cambio di segno",
      "Steigung. Mit Vorzeichenwechsel",
      "坡度角。 随着符号变化" };
    public static readonly string[] DrillDirection = {
      "Drilling Direction",
      "Направление сверления",
      "Direzione di perforazione",
      "Bohrrichtung",
      "钻孔方向" };
    public static readonly string[] DrillType = {
      "Drilling Type",
      "Тип сверления",
      "Tipo di perforazione",
      "Bohrertyp",
      "钻孔类型" };
    public static readonly string[] Countersink = {
      "Countersink",
      "Зенковать",
      "Svasatore",
      "Versenken",
      "埋头孔" };
    public static readonly string[] CountersinkAngle = {
      "Countersink Angle",
      "Угол зенковки",
      "Angolo di svasatura",
      "Senkwinkel",
      "埋头孔角度" };
    public static readonly string[] CountersinkDiam = {
      "Countersink Diameter",
      "Диаметр зенковки",
      "Diametro svasatore",
      "Senkerdurchmesser",
      "埋头孔直径" };
    public static readonly string[] CountersinkDepth = {
      "Countersink Depth",
      "Глубина зенковки",
      "Profondità svasatore",
      "Senktiefe",
      "埋头孔深度" };
    public static readonly string[] DrillNumber = {
      "Drilling Number",
      "Номер сверления",
      "Numero di perforazione",
      "Bohrnummer" ,
      "钻孔编号"};
    public static readonly string[] EdgeLength = {
      "Edge length",
      "Длина торца",
      "Lunghezza",
      "Länge",
      "边长" };
    public static readonly string[] CutterDiameter = {
      "Cutter diameter",
      "Диаметр фрезы",
      "Diametro fresa",
      "Fräserdurchmesser",
      "刀具直径" };
    public static readonly string[] SawDiameter = {
      "Saw blade diameter",
      "Диаметр диска пилы",
      "Diametro della lama della sega",
      "Sägeblattdurchmesser",
      "锯片直径" };
    public static readonly string[] SawThickness = {
      "Saw blade thickness",
      "Толщина диска пилы",
      "Spessore della lama della sega",
      "Sägeblattdicke",
      "锯片厚度"};
    public static readonly string[] MillTool = {
      "Milling cutter",
      "Фреза",
      "Fresa",
      "Fräser",
      "铣刀" };
    public static readonly string[] MillToolTip = {
      "The name or number of the tool (cutter) as it is named in the CNC machine.\r\n" +
        "This name can be used in the %milltool% substitution in all NC-layer names.\r\n" +
        "The program will use this name from the material properties of the part,\r\n" +
        "even if a different tool name is specified in the CNC style.",
      "Имя или номер инструмента (фрезы), как он назван в станке ЧПУ.\r\n" +
        "Это имя можно использовать в подстановке %milltool% во всех именах слоев ЧПУ.\r\n" +
        "Программа будет использовать это имя из свойств материала детали,\r\n" +
        "даже если в стиле ЧПУ задано другое имя инструмента.",
      "Il nome o il numero dell'utensile (fresa) come viene chiamato nella macchina CNC.\r\n" +
        "Questo nome può essere utilizzato nella sostituzione %milltool% in tutti i nomi dei livelli NC.\r\n" +
        "Il programma utilizzerà questo nome dalle proprietà del materiale della parte,\r\n" +
        "anche se nello stile CNC è specificato un nome utensile diverso.",
      "Der Name oder die Nummer des Werkzeugs (Fräsers), wie es in der CNC-Maschine genannt wird.\r\n" +
        "Dieser Name kann in der %milltool%-Ersetzung in allen NC-Layer-Namen verwendet werden.\r\n" +
        "Das Programm verwendet diesen Namen aus den Materialeigenschaften des Teils,\r\n" +
        "auch wenn im CNC-Stil ein anderer Werkzeugname angegeben ist.",
      "CNC 机床中命名的刀具（刀具）的名称或编号。\r\n" +
         "此名称可用于所有 NC 图层名称中的 %milltool% 替换。\r\n" +
         "程序将从零件的材料属性中使用这个名称，\r\n" +
         "即使在 CNC 样式中指定了不同的刀具名称。" };
    public static readonly string[] SawTool = {
      "Saw blade",
      "Диск пилы",
      "Lama d/sega",
      "Sägeblatt",
      "锯片" };
    public static readonly string[] SawToolTip = {
      "The name or number of the tool (disk), as it is named in the CNC machine.\r\n" +
        "This name can be used in the %sawtool% substitution in all NC-layer names.\r\n" +
        "The program will use this name from the material properties of the part,\r\n" +
        "even if a different tool name is specified in the CNC style.",
      "Имя или номер инструмента (диска), как он назван в станке ЧПУ. \r\n" +
        "Это имя можно использовать в подстановке %sawtool% во всех именах слоев ЧПУ.\r\n" +
        "Программа будет использовать это имя из свойств материала детали,\r\n" +
        "даже если в стиле ЧПУ задано другое имя инструмента.",
      "Il nome o il numero dell'utensile (disco), come viene chiamato nella macchina CNC.\r\n" +
        "Questo nome può essere utilizzato nella sostituzione %sawtool% in tutti i nomi dei livelli NC.\r\n" +
        "Il programma utilizzerà questo nome dalle proprietà del materiale della parte,\r\n" +
        "anche se nello stile CNC è specificato un nome utensile diverso.",
      "Der Name oder die Nummer des Werkzeugs (Diskette), wie es in der CNC-Maschine genannt wird.\r\n" +
        "Dieser Name kann in der %sawtool%-Ersetzung in allen NC-Layer-Namen verwendet werden.\r\n" +
        "Das Programm verwendet diesen Namen aus den Materialeigenschaften des Teils,\r\n" +
        "auch wenn im CNC-Stil ein anderer Werkzeugname angegeben ist.",
      "刀具（盘）的名称或编号，与 CNC 机床中的名称相同。\r\n" +
         "此名称可用于所有 NC 图层名称中的 %sawtool% 替换。\r\n" +
         "程序将从零件的材料属性中使用这个名称，\r\n" +
         "即使在 CNC 样式中指定了不同的刀具名称。" };
    public static readonly string[] MillMode = {
      "Milling mode",
      "Режим фрезы",
      "Modalità di fres.",
      "Fräsmodus",
      "铣削方式" };
    public static readonly string[] MillModeTip = {
      "Processing mode (milling).\r\n" +
        "This text can be used in the %millmode% substitution in all NC layer names.",
      "Режим обработки (фрезеровки). \r\n" +
        "Этот текст можно использовать в подстановке %millmode% во всех именах слоев ЧПУ.",
      "Modalità di lavorazione (fresatura).\r\n" +
        "Questo testo può essere utilizzato nella sostituzione %millmode% in tutti i nomi dei livelli NC.",
      "Bearbeitungsmodus (Fräsen).\r\n" +
        "Dieser Text kann in der %millmode%-Ersetzung in allen NC-Layer-Namen verwendet werden.",
      "加工模式（铣削）。\r\n" +
         "此文本可用于所有 NC 图层名称中的 %millmode% 替换。" };
    public static readonly string[] SawMode = {
      "Sawing mode",
      "Режим пиления",
      "Modalità segatura",
      "Sägemodus",
      "锯切方式" };
    public static readonly string[] SawModeTip = {
      "Processing mode (sawing).\r\n" +
        "This text can be used in the %sawmode% substitution in all NC layer names.",
      "Режим обработки (напилки). \r\n" +
        "Этот текст можно использовать в подстановке %sawmode% во всех именах слоев ЧПУ.",
      "Modalità di lavorazione (segatura).\r\n" +
        "Questo testo può essere utilizzato nella sostituzione %sawmode% in tutti i nomi dei livelli NC.",
      "Bearbeitungsmodus (Sägen).\r\n" +
        "Dieser Text kann in der %sawmode%-Ersetzung in allen NC-Layer-Namen verwendet werden.",
      "加工模式（锯切）。\r\n" +
         "此文本可用于所有 NC 图层名称中的 %sawmode% 替换。" };
    public static readonly string[] Downward = {
      "Downward slope",
      "Наклон снизу",
      "Inclinazione inferiore",
      "Bodenneigung",
      "下坡" };
    public static readonly string[] CenterX = {
      "Center X",
      "Центр X",
      "Centro X",
      "Center X",
      "中心 X" };
    public static readonly string[] CenterY = {
      "Center Y",
      "Центр Y",
      "Centro Y",
      "Center Y",
      "中心 Y" };
    public static readonly string[] CenterZ = {
      "Center Z",
      "Центр Z",
      "Centro Z",
      "Center Z",
      "中心 Z" };


    // ==========================================================================================================
    // Dimension ================================================================================================
    public static readonly string[] Annotations = {
      "Annotations",
      "Аннотации",
      "Annotazioni",
      "Anmerkungen",
      "注释" };

    public static readonly string[] Dimension = {
      "Dimension",
      "Размер",
      "Dimensione",
      "Abmessungen",
      "尺寸" };
    public static readonly string[] Dimensions = {
      "Dimensions",
      "Размеры",
      "Dimensioni",
      "Abmessungen",
      "尺寸" };
    public static readonly string[] Measurement = {
      "Measurement",
      "Измерено",
      "Misurazione",
      "Messung",
      "测量" };
    public static readonly string[] MeasurementTip = {
      "Measured distance",
      "Измеренное расстояние",
      "Distanza misurata",
      "Gemessene Entfernung",
      "测量距离" };
    public static readonly string[] Style = {
      "Style",
      "Стиль",
      "Stile",
      "Stil",
      "样式" };
    public static readonly string[] StyleTip = {
      "A set of pre-made settings",
      "Набор предварительно сделанных настроек",
      "Una serie di impostazioni predefinite",
      "Eine Reihe von vorgefertigten Einstellungen",
      "一组预制设置" };
    public static readonly string[] DimTextStringTip = {
      "Content displayed on the drawing.\r\n" +
        "Use the <> characters to insert the measured distance into the text.",
      "Содержимое, выводимое на чертеж.\r\n" +
        "Используйте символы <> чтоб вставить в текст измеренное расстояние.",
      "Contenuto visualizzato nel disegno.\r\n" +
        "Utilizzare i simboli <> per inserire nel testo la distanza misurata.",
      "In der Zeichnung angezeigter Inhalt.\r\n" +
        "Verwenden Sie die Symbole <>, um die gemessene Entfernung in den Text einzufügen.",
      "绘图上显示的内容。\r\n" +
         "使用 <> 字符将测量的距离插入到文本中。" };

    // ================================================================================================
    // DWG ============================================================================================
    public static readonly string[] Author = {
      "Author",
      "Автор",
      "Autore",
      "Autor",
      "作者" };
    public static readonly string[] AuthorTip = {
      "Your name",
      "Ваше имя",
      "Il tuo nome",
      "Ihr Name",
      "你的名字" };
    public static readonly string[] ColorDialogTip = {
      "Color Picker Dialog",
      "Диалог выбора цвета",
      "Finestra di dialogo Selettore colore",
      "Dialogfeld „Farbauswahl“.",
      "颜色选择器对话框" };
    public static readonly string[] Comments = {
      "Comments",
      "Комментарии",
      "Commenti",
      "Bemerkungen",
      "注释" };
    public static readonly string[] CommentsTip = {
      "Any information about the drawing, comments from editors and reviewers.",
      "Любая информация о чертеже, комментарии редакторов и проверяющих.",
      "Qualsiasi informazione sul disegno, commenti da editori e revisori.",
      "Alle Informationen über die Zeichnung, Kommentare von Redakteuren und Rezensenten.",
      "有关绘图的任何信息、编辑和审稿人的评论。" };
    public static readonly string[] Drawing = {
      "Drawing",
      "Чертеж",
      "Disegno",
      "Zeichnen",
      "文件属性" };
    public static readonly string[] Drawings = {
      "Drawings",
      "Чертежи",
      "Disegni",
      "Zeichnungen",
      "文件属性" };
    public static readonly string[] DwgColorTip = {
      "Color for new drawing objects.\r\n" +
        "You can write any color name, the program will try to recognize it.",
      "Цвет для новых объектов чертежа.\r\n" +
        "Вы можете написать любое название цвета, программа попробует распознать его.",
      "Colore per nuovi oggetti di disegno.\r\n" +
        "Puoi scrivere qualsiasi nome di colore, il programma proverà a riconoscerlo.",
      "Farbe für neue Zeichnungsobjekte.\r\n" +
        "Sie können einen beliebigen Farbnamen eingeben, das Programm wird versuchen, ihn zu erkennen.",
      "新图形对象的颜色。\r\n" +
         "你可以写任何颜色名称，程序会尝试识别它。" };
    public static readonly string[] DwgCreated = {
      "Dwg Created",
      "DWG создан",
      "Dwg creato",
      "Dwg erstellt",
      "创建的图纸" };
    public static readonly string[] DwgCreatedTip = {
      "The date the drawing was created.",
      "Дата создания чертежа.",
      "La data di creazione del disegno.",
      "Das Datum, an dem die Zeichnung erstellt wurde.",
      "图纸 DXG 文件是何时创建的？" };
    public static readonly string[] DwgLayerTip = {
      "Layer for new drawing objects.\r\n" +
        "You can write any name.\r\n" +
        "The program will find the layer in the drawing or template.\r\n" +
        "And if it doesn't find it, a new layer will be created.",
      "Слой для новых объектов чертежа.\r\n" +
        "Вы можете написать любое название.\r\n" +
        "Программа найдет слой в чертеже или в шаблоне.\r\n" +
        "А если не найдет - будет создан новый слой.",
      "Layer per nuovi oggetti di disegno.\r\n" +
        "Puoi scrivere qualsiasi nome.\r\n" +
        "Il programma troverà il livello nel disegno o nel modello.\r\n" +
        "E se non lo trova, verrà creato un nuovo livello.",
      "Layer für neue Zeichenobjekte.\r\n" +
        "Sie können einen beliebigen Namen schreiben.\r\n" +
        "Das Programm findet die Ebene in der Zeichnung oder Vorlage.\r\n" +
        "Und wenn es sie nicht findet, wird eine neue Ebene erstellt.",
      "新绘图对象的图层。\r\n" +
         "你可以写任何名字。\r\n" +
         "程序将在绘图或模板中查找图层。\r\n" +
         "如果没有找到，就会创建一个新层。" };
    public static readonly string[] DwgMaterialTip = {
        "Material for new drawing objects.\r\n" +
            "You can write any name.\r\n" +
            "The program will find the material in the drawing or template.\r\n" +
            "And if it doesn't find it, a new material will be created.",
        "Материал для новых объектов чертежа.\r\n" +
            "Вы можете написать любое название.\r\n" +
            "Программа найдет материал в чертеже или в шаблоне.\r\n" +
            "А если не найдет - будет создан новый материал.",
        "Materiale per i nuovi oggetti di disegno.\r\n" +
            "Puoi scrivere qualsiasi nome.\r\n" +
            "Il programma troverà il materiale nel disegno o nel modello.\r\n" +
            "E se non lo trova, verrà creato un nuovo materiale.",
        "Material für neue Zeichnungsobjekte.\r\n" +
            "Sie können einen beliebigen Namen schreiben.\r\n" +
            "Das Programm findet das Material in der Zeichnung oder Vorlage.\r\n" +
            "Und wenn es es nicht findet, wird ein neues Material erstellt.",
        "新绘图对象的材料。\r\n" +
            "您可以写任何名称。\r\n" +
            "程序会在图纸或模板中找到材料。\r\n" +
            "如果没有找到，将创建一个新材料。"
    };
    public static readonly string[] DwgUnits = {
      "Dwg Units",
      "Единицы Dwg",
      "Unità Dwg",
      "Dwg-Einheiten",
      "单位" };
    public static readonly string[] DwgUnitsTip = {
      "The value of the INSUNITS system variable.\r\n" +
        "It is important to correctly set up drawing and block units.\r\n" +
        "Otherwise, there will be problems with the scale of inserting blocks into different drawings.\r\n" +
        "In addition plugins A>V>C> choose default values\r\n" +
        "for all settings based on drawing units.\r\n" +
        "Choose inches or millimeters.",
      "Значение системной переменной INSUNITS.\r\n" +
        "Важно правильно настроить единицы чертежа и блоков.\r\n" +
        "Иначе будут проблемы с масштабом вставки блоков в разные чертежи.\r\n" +
        "Кроме того плагины A>V>C> выбирают значения по умолчанию\r\n" +
        "для всех настроек исходя из единиц чертежа.\r\n" +
        "Выберите дюймы или миллиметры.",
      "Il valore della variabile di sistema INSUNITS.\r\n" +
        "È importante impostare correttamente le unità di disegno e blocco.\r\n" +
        "In caso contrario, ci saranno problemi con la scala di inserimento di blocchi in disegni diversi.\r\n" +
        "Inoltre i plugin A>V>C> scelgono i valori predefiniti\r\n" +
        "per tutte le impostazioni basate sulle unità di disegno.\r\n" +
        "Scegli pollici o millimetri.",
      "Der Wert der Systemvariablen INSUNITS.\r\n" +
        "Es ist wichtig, Zeichnungs- und Blockeinheiten richtig einzurichten.\r\n" +
        "Andernfalls treten Probleme mit dem Maßstab beim Einfügen von Blöcken in verschiedene Zeichnungen auf.\r\n" +
        "Außerdem wählen die Plugins A>V>C> Standardwerte\r\n" +
        "für alle Einstellungen basierend auf Zeichnungseinheiten.\r\n" +
        "Wählen Sie Zoll oder Millimeter.",
      "INSUNITS 系统变量的值。\r\n" +
         "正确设置绘图和块单位很重要。\r\n" +
         "否则在不同的图纸中插入方块会出现比例问题。\r\n" +
         "另外插件 A>V>C> 选择默认值\r\n" +
         "基于绘图单位的所有设置。\r\n" +
         "选择英寸或毫米。" };
    public static readonly string[] DwgUpdated = {
      "Dwg Updated",
      "DWG обновлен",
      "DWG aggiornato",
      "Dwg aktualisiert",
      "更新日期" };
    public static readonly string[] DwgUpdatedTip = {
      "The date the drawing was last saved.",
      "Дата последнего сохранения чертежа.",
      "La data dell'ultimo salvataggio del disegno.",
      "Das Datum, an dem die Zeichnung zuletzt gespeichert wurde.",
      "上次修改图形文件的日期。" };
    public static readonly string[] Filename = {
      "File Name",
      "Имя файла",
      "Nome del file",
      "Dateiname",
      "文件名" };
    public static readonly string[] FilenameTip = {
      "File Name",
      "Имя файла",
      "Nome del file",
      "Dateiname",
      "文件名" };
    public static readonly string[] Folder = {
      "Folder",
      "Папка",
      "Cartella",
      "Ordner",
      "文件夹" };
    public static readonly string[] FolderTip = {
      "The path to the file",
      "Путь к файлу",
      "Il percorso del file",
      "Der Pfad zur Datei",
      "文件路径" };
    public static readonly string[] HyperlinkBaseTip = {
      "The base address for all object hyperlinks in this drawing.\r\n" +
        "The URL of a site on the Internet or the address of a folder on disk.",
      "Базовый адрес для всех гиперссылок объектов данного чертежа.\r\n" +
        "URL сайта в интернете или адрес папки на диске.",
      "L'indirizzo di base per tutti i collegamenti ipertestuali agli oggetti in questo disegno.\r\n" +
        "L'URL di un sito su Internet o l'indirizzo di una cartella su disco.",
      "Die Basisadresse für alle Objekt-Hyperlinks in dieser Zeichnung.\r\n" +
        "Die URL einer Website im Internet oder die Adresse eines Ordners auf der Festplatte." ,
      "此图形中所有对象超链接的基地址。\r\n" +
        "Internet 上站点的 URL 或磁盘上文件夹的地址。"};
    public static readonly string[] InDwg = {
      "In Dwg",
      "В чертеже",
      "In Dwg",
      "In Dwg",
      "编辑时长" };
    public static readonly string[] InDwgTip = {
      "How long has the drawing been edited.",
      "Сколько времени уже редактируется чертеж.",
      "Da quanto tempo è stato modificato il disegno.",
      "Wie lange wurde die Zeichnung bearbeitet.",
      "绘图已编辑多长时间。" };
    public static readonly string[] Keywords = {
      "Keywords",
      "Ключевые слова",
      "Parole",
      "Schlüsselwörter",
      "关键词(标记)" };
    public static readonly string[] KeywordsTip = {
      "Any words for the convenience of finding a drawing",
      "Любые слова для удобства поиска чертежа",
      "Qualsiasi parola per la comodità di trovare un disegno",
      "Irgendwelche Worte für die Bequemlichkeit, eine Zeichnung zu finden",
      "关键字方便查找图形的任何单词,windows10中显示为标记列" };
    public static readonly string[] LastSavedBy = {
      "Saved by",
      "Сохранил",
      "Salvato da",
      "Gemerkt von",
      "保存者" };
    public static readonly string[] LastSavedByTip = {
      "Who last saved the drawing.",
      "Кто последним сохранил чертеж.",
      "Chi per ultimo ha salvato il disegno.",
      "Wer hat die Zeichnung zuletzt gespeichert?",
      "谁最后保存了绘图。" };
    public static readonly string[] Multiplier = {
      "Multiplier",
      "Множитель",
      "Moltiplicatore",
      "Multiplikator",
      "乘数" };
    public static readonly string[] MultiplierTip = {
      "The number by which the number of objects will be multiplied.\r\n" +
        "Use to calculate the number of parts in a batch.",
      "Число, на которое будет умножено количество объектов.\r\n" +
        "Используйте для вычисления количества деталей в партии.",
      "Il numero per il quale verrà moltiplicato il numero di oggetti.\r\n" +
        "Utilizzare per calcolare il numero di parti in una serie.",
      "Die Zahl, mit der die Anzahl der Objekte multipliziert wird.\r\n" +
        "Wird verwendet, um die Anzahl der Teile in einer Serie zu berechnen.",
      "对象数量将乘以的数字。\r\n" +
         "用于计算批次中的零件数量。" };
    public static readonly string[] NumberAssemblies = {
      "Number of Assemblies",
      "Количество сборок",
      "Numero di assemblee",
      "Anzahl Baugruppen",
      "组件数量" };
    public static readonly string[] NumberAssembliesTip = {
      "The number of assembly blocks in the drawing.\r\n" +
        "The numbering of assemblies will continue from this number.",
      "Количество блоков-сборок в чертеже.\r\n" +
        "С этой цифры будет продолжена нумерация сборок.",
      "Il numero di blocchi di assieme nel disegno.\r\n" +
        "La numerazione delle assemblee continuerà da questo numero.",
      "Die Anzahl der Montageblöcke in der Zeichnung.\r\n" +
        "Die Nummerierung der Baugruppen wird ab dieser Nummer fortgesetzt.",
      "绘图中的装配块数。\r\n" +
         "组件的编号将从这个编号继续。" };
    public static readonly string[] NumberDetails = {
      "Number of Details",
      "Количество деталей",
      "Numero di dettagli",
      "Anzahl der Details",
      "细节数量" };
    public static readonly string[] NumberDetailsTip = {
      "The number of parts in the drawing.\r\n" +
        "From this figure, the numbering of parts can be continued.",
      "Количество деталей в чертеже.\r\n" +
        "С этой цифры может быть продолжена нумерация деталей.",
      "Il numero di parti nel disegno.\r\n" +
        "Da questa figura si può continuare la numerazione delle parti.",
      "Die Anzahl der Teile in der Zeichnung.\r\n" +
        "Von dieser Figur aus kann die Nummerierung der Teile fortgesetzt werden.",
      "图形中的零件数。\r\n" +
         "根据此图，可以继续对部件进行编号。" };
    public static readonly string[] Revision = {
      "Revision",
      "Ревизия",
      "Revisione",
      "Revision",
      "修订" };
    public static readonly string[] RevisionTip = {
      "The number or index of the current version of the drawing changes.\r\n" +
        "The field has a built-in calculator for calculating mathematical expressions.",
      "Номер или индекс текущего варианта изменений чертежа.\r\n" +
        "В поле встроен калькулятор для вычисления математических выражений.",
      "Il numero o l'indice della versione corrente del disegno cambia.\r\n" +
        "Il campo ha una calcolatrice incorporata per il calcolo delle espressioni matematiche.",
      "Die Nummer oder der Index der aktuellen Version der Zeichnung ändert sich.\r\n" +
        "Das Feld verfügt über einen integrierten Taschenrechner zur Berechnung mathematischer Ausdrücke.",
      "图形当前版本的编号或索引更改。\r\n" +
         "该字段具有用于计算数学表达式的内置计算器。" };
    public static readonly string[] Subject = {
      "Subject",
      "Тема",
      "Soggetto",
      "Gegenstand",
      "主题" };
    public static readonly string[] SubjectTip = {
      "Purpose of the drawing. You can write down the customer's name.",
      "Предназначение чертежа. Можно записать имя заказчика.",
      "Scopo del disegno. Puoi scrivere il nome del cliente.",
      "Zweck der Zeichnung. Sie können den Namen des Kunden aufschreiben.",
      "绘图的目的。 您可以写下客户的姓名。" };
    public static readonly string[] Title = {
      "Title",
      "Заглавие",
      "Titolo",
      "Titel",
      "标题" };
    public static readonly string[] TitleTip = {
      "Project name, title",
      "Название проекта, заголовок",
      "Nome progetto, titolo",
      "Projektname, Titel",
      "项目名称、标题" };
    public static readonly string[] UserTimer = {
      "User Timer",
      "Таймер пользователя",
      "Timer utente",
      "Benutzer-Timer",
      "用户计时器" };
    public static readonly string[] UserTimerTip = {
      "How much time was spent editing the drawing.\r\n" +
        "This counter can be reset at any time with the _Time command.",
      "Сколько времени потрачено на редактирование чертежа.\r\n" +
        "Этот счетчик можно сбросить в любой момент командой _Time.",
      "Quanto tempo è stato dedicato alla modifica del disegno.\r\n" +
        "Questo contatore può essere azzerato in qualsiasi momento con il comando _Time.",
      "Wie viel Zeit wurde für die Bearbeitung der Zeichnung aufgewendet?\r\n" +
        "Dieser Zähler kann jederzeit mit dem Befehl _Time zurückgesetzt werden.",
      "编辑图形花费了多少时间。\r\n" +
         "此计时器可以随时使用 _Time 命令重置。" };
    public static readonly string[] DrawingProperties = {
      "Drawing properties",
      "Свойства чертежа",
      "Proprietà del disegno",
      "Zeichnungseigenschaften",
      "图纸属性" };
    public static readonly string[] CustomProperties = {
      "Custom",
      "Пользовательские",
      "Personalizzate",
      "Benutzerspezifisch",
      "习惯" };

    // ========================================================================================================
    // DTPart  ================================================================================================
    public static readonly string[] Part = {
      "Part",
      "Деталь",
      "Dettaglio",
      "Detail",
      "部分" };
    public static readonly string[] Details = {
      "Details",
      "Детали",
      "Dettagli",
      "Einzelheiten",
      "细节数量"};
    public static readonly string[] Row = {
      "#",
      "№",
      "#",
      "#",
      "#" };
    public static readonly string[] Quantity = {
      "Quantity",
      "Количество",
      "Quantità",
      "Menge",
      "数量" };
    public static readonly string[] RightQuantity = {
      "Right Quantity",
      "Кол-во прямых",
      "Numero di corretti",
      "Anzahl der Richtigen",
      "正确的数量" };
    public static readonly string[] MirrorQuantity = {
      "Mirror Quantity",
      "Кол-во зеркальных",
      "Numero di specchio",
      "Anzahl der Gespiegelten",
      "镜像数量" };
    public static readonly string[] QuantityPerAssembly = {
      "Quantity per assembly",
      "Кол-во в сборке",
      "Quantità per assemblaggio",
      "Menge pro Baugruppe",
      "每个组件的数量" };
    public static readonly string[] RightMirror = {
      "Right+Mirror",
      "Кол-во шт+Зеркальных",
      "Corretti+Specchio",
      "Richtige+Gespiegelte",
      "件+镜像" };
    public static readonly string[] Pcs = {
      "pcs",
      "шт.",
      "pezzi",
      "Stck",
      "件" };
    public static readonly string[] MirrorPcs = {
      "mirror",
      "зерк.",
      "specchio",
      "Spiegel",
      "镜像" };

    // =======================================================================================================
    // Leader ================================================================================================
    public static readonly string[] Leader = {
      "Leader",
      "Выноска",
      "Direttrice",
      "Führungslinie",
      "多重引线" };
    public static readonly string[] Leaders = {
      "Leaders",
      "Выноски",
      "Direttrice",
      "Führungslinie",
      "多重引线" };
    public static readonly string[] Format = {
      "Format",
      "Формат",
      "Formato",
      "Format",
      "格式" };
    public static readonly string[] FormatTip = {
      "Leader text.\r\n" +
        "For Leaders with a block, you can edit the attribute of the block if there is only one attribute.\r\n" +
        "If you write any substitution in the text, the Leader will become 'smart'\r\n" +
        "and will try to load the substitution value from the object under the arrow.",
      "Текст выноски.\r\n" +
        "У выносок с блоком, можно редактировать атрибут блока, еcли атрибут только один.\r\n" +
        "Если записать в текст любую подстановку, то выноска станет 'умной'\r\n" +
        "и попробует загрузить значение подстановки из объекта под стрелкой.",
      "Testo di Direttrice.\r\n" +
        "Per i Direttrice con un blocco, è possibile modificare l'attributo del blocco se è presente un solo attributo.\r\n" +
        "Se scrivi qualsiasi sostituzione nel testo, il Direttrice diventerà 'intelligente'\r\n" +
        "e proverà a caricare il valore di sostituzione dall'oggetto sotto la freccia.",
      "Führungslinie-Text.\r\n" +
        "Bei Führungslinie mit einem Block können Sie das Attribut des Blocks bearbeiten, wenn nur ein Attribut vorhanden ist.\r\n" +
        "Wenn Sie eine Ersetzung in den Text schreiben, wird das Führungslinie 'intelligent'\r\n" +
        "und versucht, den Ersatzwert aus dem Objekt unter dem Pfeil zu laden.",
      "引线文本。\r\n" +
         "对于具有块的引线，如果只有一个属性，则可以编辑块的属性。\r\n" +
         "如果你在文本中写任何替换，Leader 会变得'聪明'\r\n" +
         "并且会尝试从箭头下的对象加载替换值。" };

    // ================================================================================================================
    // Material, CoverId ================================================================================================
    public static readonly string[] Material = {
      "Material",
      "Материал",
      "Materiale",
      "Material",
      "材料" };
    public static readonly string[] Materials = {
      "Materials",
      "Материалы",
      "Materiale",
      "Material" ,
      "材料" };
    public static readonly string[] MaterialTip = {
      "The name of the rendering material that AVC plugins use as the material from which the part is made.",
      "Название материала рендеринга, который плагины AVC используют как материал из которого изготовлена деталь.",
      "Il nome del materiale di rendering utilizzato dai plugin AVC come materiale da cui è realizzata la parte.",
      "Der Name des Rendering-Materials, das AVC-Plugins als Material verwenden, aus dem das Teil erstellt wird.",
      "AVC 插件用作制作零件的材质的渲染材质的名称。" };
    public static readonly string[] Cover = {
      "Cover",
      "Покрытие",
      "Rivestimento",
      "Belag",
      "覆盖" };
    public static readonly string[] Covers = {
      "Covers",
      "Покрытия",
      "Rivestimenti",
      "Belag",
      "覆盖" };
    public static readonly string[] MaterialId = {
      "Material ID",
      "Материал - ID",
      "Materiale ID",
      "Material ID",
      "材料 ID" };
    public static readonly string[] MaterialHandle = {
      "Material Handle",
      "Материал - Хэндл",
      "Materiale Handle",
      "Material Handle",
      "材料 Handle" };
    public static readonly string[] Article = {
      "Article",
      "Артикул",
      "Articolo",
      "Code",
      "代码" };
    public static readonly string[] MaterialArticle = {
      "Material Article",
      "Материал - Артикул",
      "Materiale - Articolo",
      "Materialcode",
      "材料-代码" };
    public static readonly string[] ArticleTip = {
      "Long digital code of the material.\r\n" +
        "Use for procurement and for link with databases.\r\n" +
        "The article must be unique for all drawings.\r\n" +
        "And it should match the same materials in different drawings,\r\n" +
        "even if you are a little mistaken in the name of the material.",
      "Длинный цифровой код материала.\r\n" +
        "Используйте для закупок и для связи с базами данных.\r\n" +
        "Артикул должен быть уникальным для всех чертежей.\r\n" +
        "И он должен совпадать у одинаковых материалов в разных чертежах,\r\n" +
        "даже если вы немного ошиблись в названии материала.",
      "Codice digitale lungo del materiale.\r\n" +
        "Utilizzare per l'approvvigionamento e per il collegamento con i database.\r\n" +
        "L'articolo deve essere unico per tutti i disegni.\r\n" +
        "E dovrebbe corrispondere agli stessi materiali in diversi disegni,\r\n" +
        "anche se sbagli un po' nel nome del materiale.",
      "Langer digitaler Code des Materials.\r\n" +
        "Verwendung zur Beschaffung und zur Verknüpfung mit Datenbanken.\r\n" +
        "Der Artikel muss für alle Zeichnungen eindeutig sein.\r\n" +
        "Und es sollte mit den gleichen Materialien in verschiedenen Zeichnungen übereinstimmen,\r\n" +
        "auch wenn Sie sich im Namen des Materials ein wenig irren.",
      "材料的长数字代码。\r\n" +
         "用于采购和与数据库的链接。\r\n" +
         "对于所有图纸，代码必须是唯一的。\r\n" +
         "并且应该在不同的图纸中匹配相同的材料，\r\n" +
         "即使你对材料的名称有一点误解。" };
    public static readonly string[] MaterialColor = {
      "Material Color",
      "Материал - Цвет",
      "Materiale - Colore",
      "Materialfarbe" ,
      "材料-颜色"};
    public static readonly string[] MaterialColorTip = {
      "Diffuse color of the material. You can write any name for the color. The program will try to recognize it.\r\n" +
        "Write an empty line to show the inherited solid color (ByObject).\r\n" +
        "When changing this color, the program will also change the Ambient color of the material,\r\n" +
        "if it is not inherited from the object (not ByObject).\r\n" +
        "The same color can be assigned to solids and surfaces when changing materials (see General settings)\r\n" +
        "and then you will see this color in any visual style.",
      "Диффузный (diffuse) цвет материала. \r\n" +
        "Можете написать любое название цвета. Программа постарается его распознать.\r\n" +
        "Запишите пустую строку, чтоб показывать унаследованный цвет солида (Inherited = ByObject).\r\n" +
        "При смене этого цвета, программа также поменяет рассеянный (Ambient) цвет материала,\r\n" +
        "если тот не унаследован от объекта (не ByObject).\r\n" +
        "Этот же цвет можно присваивать солидам и поверхностям при смене материала\r\n" +
        "и тогда вы увидите этот цвет в любых визуальных стилях.",
      "Colore diffuso del materiale. Puoi scrivere qualsiasi nome per il colore. Il programma proverà a riconoscerlo.\r\n" +
        "Scrivi una riga vuota per mostrare il colore solido ereditato (ByObject).\r\n" +
        "Quando si cambia questo colore, il programma cambierà anche il colore Ambient del materiale,\r\n" +
        "se non è ereditato dall'oggetto (non ByObject).\r\n" +
        "Lo stesso colore può essere assegnato a solidi e superfici quando si cambiano i materiali (vedi Impostazioni generali)\r\n" +
        "e poi vedrai questo colore in qualsiasi stile visivo.",
      "Diffuse Farbe des Materials. Sie können einen beliebigen Namen für die Farbe schreiben. Das Programm wird versuchen, es zu erkennen.\r\n" +
        "Schreiben Sie eine leere Zeile, um die geerbte Volltonfarbe (ByObject) anzuzeigen.\r\n" +
        "Wenn Sie diese Farbe ändern, ändert das Programm auch die Umgebungsfarbe des Materials,\r\n" +
        "wenn sie nicht vom Objekt (nicht von ByObject) geerbt wird.\r\n" +
        "Beim Materialwechsel kann Volumenkörpern und Flächen die gleiche Farbe zugewiesen werden (siehe Allgemeine Einstellungen)\r\n" +
        "und dann sehen Sie diese Farbe in jedem visuellen Stil.",
      "材料的漫反射颜色。 您可以为颜色写任何名称。 程序将尝试识别它。\r\n" +
         "写一个空行来显示继承的纯色(ByObject)。\r\n" +
         "当改变这个颜色时，程序也会改变材质的Ambient颜色，\r\n" +
         "如果不是继承自对象（不是 ByObject）。\r\n" +
         "更改材质时可以为实体和曲面分配相同的颜色（请参阅常规设置）\r\n" +
         "然后你会在任何视觉风格中看到这种颜色。" };
    public static readonly string[] Density = {
      "Density",
      "Плотность",
      "Densità",
      "Dichte",
      "密度" };
    public static readonly string[] MaterialDensity = {
      "Material Density",
      "Материал - Плотность",
      "Materiale - Densità",
      "Materialdichte",
      "材料-密度" };
    public static readonly string[] DensityTip = {
      "Density of material to calculate the weight of products and assemblies.\r\n" +
        "It is important to choose the right units.\r\n" +
        "In a millimeter drawing you need to set the weight of one cubic meter of material.\r\n" +
        "In inches, the weight of one cubic inch.\r\n" +
        "A calculator for calculating mathematical expressions is built into this field.",
      "Плотность материала для расчета веса изделий и сборок.\r\n" +
        "Важно правильно выбрать единицы.\r\n" +
        "В миллиметровом чертеже требуется задавать плотность как вес одного кубометра материала.\r\n" +
        "В дюймовом -  вес одного кубического дюйма.\r\n" +
        "В поле встроен калькулятор для вычисления математических выражений.",
      "Densità del materiale per calcolare il peso di prodotti e assiemi.\r\n" +
        "È importante scegliere le unità giuste.\r\n" +
        "In un disegno millimetrico è necessario impostare il peso di un metro cubo di materiale.\r\n" +
        "In pollici, il peso di un pollice cubo.\r\n" +
        "In questo campo è integrato un calcolatore per il calcolo delle espressioni matematiche.",
      "Materialdichte zur Berechnung des Gewichts von Produkten und Baugruppen.\r\n" +
        "Es ist wichtig, die richtigen Einheiten zu wählen.\r\n" +
        "In einer Millimeterzeichnung müssen Sie das Gewicht von einem Kubikmeter Material angeben.\r\n" +
        "In Zoll, das Gewicht von einem Kubikzoll.\r\n" +
        "In dieses Feld ist ein Taschenrechner zur Berechnung mathematischer Ausdrücke integriert.",
      "用于计算产品和组件重量的材料密度。\r\n" +
         "选择正确的单位很重要。\r\n" +
         "在毫米单位图形中你需要设置一立方米材料的重量。\r\n" +
         "英寸，一立方英寸的重量。\r\n" +
         "此字段中内置了计算数学表达式的计算器。" };
    public static readonly string[] MaterialDescription = {
      "Material Description",
      "Материал - Описание",
      "Materiale - Descrizione",
      "Materialbeschreibung" ,
      "材料-描述"};
    public static readonly string[] Index = {
      "Index",
      "Индекс",
      "Indice",
      "Index" ,
      "索引"};
    public static readonly string[] MaterialIndex = {
      "Material #",
      "Материал №",
      "Materiale #",
      "Material #",
      "材料-#" };
    public static readonly string[] MaterialIndexTip = {
      "Brief designation or material number for leaders and tables.\r\n" +
        "To avoid confusion, the index should not be repeated in the same drawing.\r\n" +
        "The program itself can come up with indexes for materials.",
      "Краткое обозначение или номер материала для выносок и таблиц.\r\n" +
        "Во избежании путаницы индекс не должен повторяться в одном чертеже.\r\n" +
        "Программа может сама придумать индексы материалам.",
      "Designazione breve o numero materiale per direttrice e tabelle.\r\n" +
        "Per evitare confusione, l'indice non deve essere ripetuto nello stesso disegno.\r\n" +
        "Il programma stesso può fornire indici per i materiali.",
      "Kurzbezeichnung oder Materialnummer für Führungslinie und Tabellen.\r\n" +
        "Um Verwirrung zu vermeiden, sollte der Index in derselben Zeichnung nicht wiederholt werden.\r\n" +
        "Das Programm selbst kann Indizes für Materialien erstellen.",
      "引线和表格的简要名称或材料编号。\r\n" +
         "为避免混淆，索引不应在同一图形中重复。\r\n" +
         "程序本身可以提供材料索引。" };
    public static readonly string[] Grain = {
      "Grain|Texture",
      "Зернистость|Текстура",
      "Grano|Struttura",
      "Maserung|Textur",
      "粒度|质地" };
    public static readonly string[] MaterialGrain = {
      "Material Grain",
      "Материал - С текстурой",
      "Materiale - Struttura",
      "Material - hat Textur",
      "材料-粮食" };
    public static readonly string[] GrainTip = {
      "The material has a noticeable surface pattern (grain/texture) in a certain direction (usually along the sheet) \r\n" +
        "and for parts it is desirable to indicate the direction of this texture.",
      "Материал имеет заметный рисунок на поверхности (зернистость/текстуру) в определенном направлении (обычно вдоль листа) \r\n" +
        "и для деталей желательно указать направление этой текстуры.",
      "Il materiale presenta una struttura superficiale (grana/struttura) evidente in una determinata direzione (solitamente lungo la lamiera) \r\n" +
        "e per i pezzi è opportuno indicare la direzione di questa struttura.",
      "Das Material weist ein erkennbares Oberflächenmuster (Maserung/Textur) in einer bestimmten Richtung (normalerweise entlang der Platte) auf \r\n" +
        "und bei Teilen ist es wünschenswert, die Richtung dieser Textur anzugeben.",
      "该材料在某个方向（通常沿着板材）具有明显的表面图案（颗粒/纹理），\r\n" +
        "对于零件来说，需要指示该纹理的方向。"};
    public static readonly string[] MaterialSweep = {
      "Material for bending",
      "Материал для гибки",
      "Materiale per piegatura",
      "Material für Biegung",
      "材料-弯曲" };
    public static readonly string[] MaterialSweepTip = {
      "All parts from this material will be marked for measurement as Sweep.",
      "Все детали из этого материала будут помечены для обмера как Развертка.",
      "Tutti i pezzi realizzati con questo materiale saranno contrassegnati per la misurazione come Scansione.",
      "Alle Teile aus diesem Material werden für die Messung als Sweep markiert.",
      "所有使用此材料制成的零件都将标记为展开测量。" };
    public static readonly string[] MaterialLength = {
      "Material Length",
      "Материал - Длина",
      "Materiale - Lunghezza",
      "Materiallänge",
      "材料-长度" };
    public static readonly string[] MaterialLengthTip = {
      "The length of the original piece of material, blank, sheet, roll, whip.\r\n" +
        "The field has a built-in calculator for calculating mathematical expressions.",
      "Длина исходного куска материала, заготовки, листа, рулона, хлыста.\r\n" +
        "В поле встроен калькулятор для вычисления математических выражений.",
      "La lunghezza del pezzo di materiale originale, bianco, foglio, rotolo, frusta.\r\n" +
        "Il campo ha una calcolatrice incorporata per il calcolo delle espressioni matematiche.",
      "Die Länge des ursprünglichen Materialstücks, Zuschnitt, Bogen, Rolle, Peitsche.\r\n" +
        "Das Feld verfügt über einen integrierten Taschenrechner zur Berechnung mathematischer Ausdrücke.",
      "原始材料的长度，坯料、片材、卷材、鞭子。\r\n" +
         "该领域有一个用于计算数学表达式的内置计算器。" };
    public static readonly string[] MaterialNameTip = {
      "Name of selected material.\r\n" +
        "The name must be unique.\r\n" +
        "The following characters are not allowed in names\r\n" +
        ";,=\\|/:*?`\"<>",
      "Полное наименование выбранного материала.\r\n" +
        "Имя не может быть пустым и должно быть уникальным.\r\n" +
        "Следующие символы недопустимы в имени:\r\n" +
        ";,=\\|/:*?`\"<>",
      "Nome completo del materiale selezionato.\r\n" +
        "Il nome non può essere vuoto e deve essere univoco.\r\n" +
        "I seguenti caratteri non sono consentiti in un nome:\r\n" +
        ";,=\\|/:*?`\"<>",
      "Vollständiger Name des ausgewählten Materials.\r\n" +
        "Der Name darf nicht leer sein und muss eindeutig sein.\r\n" +
        "Die folgenden Zeichen sind in einem Namen nicht erlaubt:\r\n" +
        ";,=\\|/:*?`\"<>",
      "所选材料的名称。\r\n" +
         "名称必须是唯一的。\r\n" +
         "名称中不允许出现以下字符\r\n" +
         ";,=\\|/:*?`\"<>" };
    public static readonly string[] MaterialPiece = {
      "Material Piece",
      "Материал - Кусок",
      "Material - Pezzo",
      "Material - Stück",
      "材料-片" };
    public static readonly string[] Price = {
      "Price",
      "Цена",
      "Prezzo",
      "Preis",
      "价格" };
    public static readonly string[] MaterialPrice = {
      "Material Price",
      "Материал - Цена",
      "Materiale - Prezzo",
      "Materialpreis",
      "材料-价格" };
    public static readonly string[] PriceTip = {
      "Cost per unit of material. \r\n" +
        "It is important to choose the right units -\r\n" +
        "in a millimeter drawing you need to set the cost of one square meter of material.\r\n" +
        "In inches, the cost of one square inch.\r\n" +
        "For linear materials (rods) and edges - use the cost per linear meter or linear inch.\r\n" +
        "A calculator for calculating mathematical expressions is built into this field.",
      "Стоимость за единицу материала. \r\n" +
        "Важно правильно выбрать единицы.\r\n" +
        "В миллиметровом чертеже требуется задавать стоимость одного квадратного метра материала.\r\n" +
        "В дюймовом -  стоимость одного квадратного дюйма.\r\n" +
        "Для погонажных материалов и кромок - используйте стоимость за один погонный метр или дюйм.\r\n" +
        "В поле встроен калькулятор для вычисления математических выражений.",
      "Il costo per unità di materiale.\r\n" +
        "È importante scegliere le giuste unità di misura -\r\n" +
        "in un disegno millimetrico, è necessario impostare il costo di un metro quadrato di materiale.\r\n" +
        "In pollici è il costo di un pollice quadrato.\r\n" +
        "Per i materiali di linea (barre) e bordi, utilizzare il costo per metro lineare o pollice lineare.\r\n" +
        "Questo campo contiene una calcolatrice incorporata per il calcolo delle espressioni matematiche.",
      "Die Kosten pro Materialeinheit.\r\n" +
        "Es ist wichtig, die richtigen Maßeinheiten zu wählen -\r\n" +
        "In einer Millimeterzeichnung müssen Sie die Kosten für einen Quadratmeter Material festlegen.\r\n" +
        "In Zoll sind die Kosten für einen Quadratzoll angegeben.\r\n" +
        "Verwenden Sie für Linienmaterialien (Stäbe) und Kanten die Kosten pro Laufmeter oder Laufzoll.\r\n" +
        "Dieses Feld enthält einen integrierten Taschenrechner zum Berechnen mathematischer Ausdrücke.",
      "每单位材料的成本。 \r\n" +
         "选择正确的单位很重要 -\r\n" +
         "在毫米单位图形中，您需要设置一平方米材料的成本。\r\n" +
         "以英寸为单位，一平方英寸的成本。\r\n" +
         "对于线性材料（棒）和封边 - 使用每线性米或线性英寸的成本。\r\n" +
         "该领域内置了用于计算数学表达式的计算器。" };
    public static readonly string[] MaterialSize = {
      "Size: Length x Width x Thickness",
      "Размер: Длина х Ширина х Толщина",
      "Dimensioni: lunghezza x larghezza x spessore",
      "Größe: Länge x Breite x Dicke",
      "尺寸：长x宽x厚"};
    public static readonly string[] MaterialThickness = {
      "Material Thickness",
      "Материал - Толщина",
      "Materiale - Spessore",
      "Materialstärke",
      "材料-厚度" };
    public static readonly string[] MaterialThicknessTip = {
      "Material thickness.\r\n" +
        "The field has a built-in calculator for calculating mathematical expressions.",
      "Толщина материала.\r\n" +
        "В поле встроен калькулятор для вычисления математических выражений.",
      "Spessore materiale.\r\n" +
        "Il campo ha una calcolatrice incorporata per il calcolo delle espressioni matematiche.",
      "Materialstärke.\r\n" +
        "Das Feld verfügt über einen integrierten Taschenrechner zur Berechnung mathematischer Ausdrücke.",
      "材料厚度。\r\n" +
         "该领域有一个用于计算数学表达式的内置计算器。"};
    public static readonly string[] MaterialUnits = {
      "Material Units",
      "Материал - Единицы",
      "Materiale - Unità",
      "Material - Einheiten",
      "材料-单位" };
    public static readonly string[] Use = {
      "Use",
      "Использование",
      "Utilizzare",
      "Verwenden",
      "用法" };
    public static readonly string[] MaterialUse = {
      "Material Use",
      "Материал - Использование",
      "Materiale - Utilizzare",
      "Material verwenden",
      "材料-用法" };
    public static readonly string[] UseTip = {
      "The purpose of this type of material",
      "Предназначение данного типа материалов, способ использования",
      "Lo scopo di questo tipo di materiale",
      "Der Zweck dieser Art von Material",
      "此类材料的用途" };
    public static readonly string[] MaterialWidth = {
      "Material Width",
      "Материал - Ширина",
      "Materiale - Larghezza",
      "Materialbreite",
      "材料-宽度" };
    public static readonly string[] MaterialWidthTip = {
      "The width of the original piece of material, billet, sheet, roll, whip.\r\n" +
        "The field has a built-in calculator for calculating mathematical expressions.",
      "Ширина исходного куска материала, заготовки, листа, рулона, хлыста.\r\n" +
        "В поле встроен калькулятор для вычисления математических выражений.",
      "La larghezza del pezzo di materiale originale, billetta, foglio, rotolo, frusta.\r\n" +
        "Il campo ha una calcolatrice incorporata per il calcolo delle espressioni matematiche.",
      "Die Breite des ursprünglichen Stoffstücks, Knüppel, Blech, Walze, Peitsche.\r\n" +
        "Das Feld verfügt über einen integrierten Taschenrechner zur Berechnung mathematischer Ausdrücke." ,
      "原片材、坯料、片材、卷材、鞭子的宽度。\r\n" +
         "该领域有一个用于计算数学表达式的内置计算器。"};

    // MatUse
    public static readonly string[] UseVolume = {
      "Volume",
      "Массив",
      "Volume",
      "Volumen" ,
      "圈材"};
    public static readonly string[] Sheet = {
      "Sheet",
      "Лист",
      "Foglio",
      "Blatt",
      "板材" };
    public static readonly string[] Rod = {
      "Rod",
      "Погонаж",
      "Asta",
      "Stange",
      "线材" };
    public static readonly string[] Banding = {
      "Banding",
      "Кромка",
      "Bordo",
      "Kante",
      "封边" };
    public static readonly string[] Unknown = {
      "Unknown",
      "Неизвестно",
      "Sconosciuto",
      "Unbekannt",
      "未知" };

    // ============================================================================================================
    // MatQuantity ================================================================================================
    public static readonly string[] Cost = {
      "Cost",
      "Стоимость",
      "Costo",
      "Kosten",
      "价格" };
    public static readonly string[] Pieces = {
      "Pieces",
      "Кусков",
      "Pezzi",
      "Stücke",
      "件" };
    public static readonly string[] Weight = {
      "Weight",
      "Вес",
      "Peso",
      "Gewicht",
      "重量" };

    // ================================================================================================
    // Parameter   ================================================================================================
    public static readonly string[] Parameter = {
      "Parameter",
      "Параметр",
      "Parametro",
      "Parameter",
      "范围" };
    public static readonly string[] Parameters = {
      "Parameters",
      "Параметры",
      "Parametri",
      "Parameter",
      "范围" };
    public static readonly string[] Value = {
      "Value",
      "Значение",
      "Valore",
      "Wert",
      "价值" };
    public static readonly string[] ReadOnly = {
      "Read Only",
      "Только чтение",
      "Sola lettura",
      "Nur lesen",
      "只读" };
    public static readonly string[] DataType = {
      "Data Type",
      "Тип данных",
      "Tipo di dati",
      "Datentyp",
      "数据类型"};

    // ================================================================================================
    // Polyline   ================================================================================================
    public static readonly string[] Polyline = {
      "Polyline",
      "Полилиния",
      "Polilinea",
      "Polylinie",
      "多段线" };
    public static readonly string[] Polylines = {
      "Polylines",
      "Полилинии",
      "Polilinee",
      "Polylinien",
      "多段线" };
    public static readonly string[] Bypass = {
      "Bypass",
      "Обход",
      "Circonvallazione",
      "Bypass",
      "旁路" };
    public static readonly string[] BypassTip = {
      "Closed Loop Direction",
      "Направление обхода замкнутого контура",
      "Direzione ad anello chiuso",
      "Closed-Loop-Richtung",
      "闭合方向" };
    public static readonly string[] CW = {
      "Clockwise",
      "По часовой",
      "Senso orario",
      "Im Uhrzeigersinn",
      "顺时针" };
    public static readonly string[] CCW = {
      "Counter-clockwise",
      "Против часовой",
      "Antiorario",
      "Gegen den Uhrzeigersinn",
      "逆时针" };
    public static readonly string[] Closed = {
      "Closed",
      "Замкнута",
      "Chiuso",
      "Geschlossen",
      "关闭" };
    public static readonly string[] ClosedTip = {
      "Start and end are the same and a 'closed' flag is set",
      "Начало и конец совпадают и установлена метка замкнутости",
      "L'inizio e la fine sono gli stessi e viene impostata un'etichetta chiusa",
      "Anfang und Ende sind gleich und es wird ein geschlossenes Label gesetzt" ,
      "开始和结束相同，并且设置了“关闭”标志"};
    public static readonly string[] NumberOfSegments = {
      "Segments",
      "Сегментов",
      "Segmenti",
      "Segmente" ,
      "分段"};
    public static readonly string[] NumberOfSegmentsTip = {
      "Number of segments",
      "Число сегментов",
      "Numero di segmenti",
      "Anzahl der Segmente",
      "段数" };
    public static readonly string[] PolylineWidth = {
      "Width",
      "Ширина",
      "Larghezza",
      "Breite",
      "宽度" };
    public static readonly string[] PolylineWidthTip = {
      "Global width of the polyline across all segments. \r\n" +
        "Same as line weight, but you can set any values.",
      "Глобальная ширина полилинии по всем сегментам. \r\n" +
        "Тоже самое, что и вес линий, но можно задать любые значения.",
      "Larghezza globale della polilinea su tutti i segmenti. \r\n" +
        "Come per lo spessore della linea, ma è possibile impostare qualsiasi valore.",
      "Globale Breite der Polylinie über alle Segmente. \r\n" +
        "Entspricht der Linienstärke, Sie können jedoch beliebige Werte festlegen.",
      "折线所有线段的全局宽度。与线宽相同，但您可以设置任意值。"};

    // ================================================================================================
    // Solid, Метрика
    // ================================================================================================
    public static readonly string[] Solid = {
      "Solid",
      "3D-тело",
      "Solido 3D",
      "Volumenkörper",
      "三维实体" };
    public static readonly string[] Solids = {
      "Solids",
      "3D-тела",
      "Solidi 3D",
      "Volumenkörper",
      "三维实体" };
    public static readonly string[] Metric = {
      "Metric",
      "Метрика",
      "Metrico",
      "Metrisch" ,
      "公制"};
    //public static readonly string[] Calculations = {
    //"Calculations",
    //"Вычислено",
    //"Calcolato",
    //"Berechnungen" };
    public static readonly string[] MeteredSolid = {
      "Metered Solid",
      "Обмеренный солид",
      "Solido misurato",
      "Volumenkörper dosiert",
      "三维实体数据" };
    public static readonly string[] MeteredSolids = {
      "Metered Solids",
      "Обмеренные солиды",
      "Solido misurato",
      "Volumenkörper dosiert",
      "三维实体数据" };
    public static readonly string[] Asymmetry = {
      "Asymmetry",
      "Асимметрия",
      "Asimmetria",
      "Asymmetrie",
      "不对称" };
    public static readonly string[] AsymmetryTip = {
      "Indicator asymmetrical: the distance from the boxing center to the center of mass.\r\n" +
        "It allows you to identify the offset holes, and others.",
      "Показатель асимметричности: расстояние от центра бокса до центра масс.\r\n" +
        "Позволяет выявить смещения отверстий и др.отличия тел при одинаковом объеме.",
      "Indice di asimmetria: distanza dal centro della scatola al centro di massa.\r\n" +
        "Consente di identificare lo spostamento di fori e altre differenze di corpi aventi lo stesso volume.",
      "Asymmetrieindex: Abstand von der Mitte des Kastens zum Massenmittelpunkt.\r\n" +
        "Ermöglicht es Ihnen, die Verschiebung von Löchern \r\n" +
        "und andere Unterschiede von Körpern mit demselben Volumen zu identifizieren.",
      "指示不对称：中心到质心的距离。\r\n" +
         "它允许您识别偏移孔等。" };
    public static readonly string[] AsymVector = {
      "Asym.Vector",
      "Асим.Вектор",
      "Asim.Vettore",
      "Asym.Vektor",
      "不对称向量" };
    public static readonly string[] AsymVectorTip = {
      "Asymmetry vector.\r\n" +
        "Shows the direction of the shift of the center of gravity along three axes.\r\n" +
        "Used to calculate the specularity of parts to each other.",
      "Вектор асимметрии.\r\n" +
        "Направление от центра бокса к центру масс по трем координатам XYZ.\r\n" +
        "Отличается у зеркальных деталей",
      "Vettore di asimmetria.\r\n" +
        "Direzione dal centro della scatola al centro di massa in tre coordinate XYZ.\r\n" +
        "Differisce nelle parti dello specchio.",
      "Asymmetrie-Vektor.\r\n" +
        "Richtung vom Mittelpunkt der Box zum Massenmittelpunkt in drei XYZ-Koordinaten.\r\n" +
        "Unterscheidet sich in Spiegelteilen.",
      "不对称向量。\r\n" +
         "显示重心沿三个轴移动的方向。\r\n" +
         "用于计算零件之间的镜面反射度。" };
    public static readonly string[] Bandings = {
      "Edge Bandings",
      "Кромки на торцы",
      "Materiale del bordo",
      "Kantenanleimungen",
      "封边条" };
    public static readonly string[] Box = {
      "Box",
      "Бокс",
      "Parallelepipedo",
      "Quader",
      "盒子" };
    public static readonly string[] CostTip = {
      "Cost of material details.\r\n" +
        "Also, the cost of covers and edge-bandings will be added to the price.",
      "Стоимость материала детали.\r\n" +
        "Так же к цене будут добавлены стоимость покрытий и кромок.",
      "Costo del materiale della parte.\r\n" +
        "Inoltre, al prezzo verrà aggiunto il costo dei rivestimenti e dei bordi.",
      "Teile Materialkosten.\r\n" +
        "Außerdem werden die Kosten für Beschichtungen und Kanten zum Preis hinzugerechnet.",
      "材料成本明细。\r\n" +
         "此外，价格中还会增加面和封边条的成本。" };
    public static readonly string[] Edge = {
      "Edge",
      "Торец",
      "Bordo",
      "Kante",
      "边" };
    public static readonly string[] Face = {
      "Face",
      "Грань",
      "Faccia",
      "Fläche",
      "面" };
    public static readonly string[] FaceCount = {
      "Faces",
      "Граней",
      "Facce",
      "Gesichter",
      "面" };
    public static readonly string[] FaceCountTip = {
      "Number of faces of the solid",
      "Число граней солида",
      "Numero di facce solide",
      "Die Anzahl der Flächen des Volumenkörpers.",
      "三维实体的面数" };
    public static readonly string[] LengthMM = {
      "Length,mm",
      "Длина,мм",
      "Lunghezza,mm",
      "Länge,mm",
      "长度 mm",
      "长度，毫米" };
    public static readonly string[] SolidMaterialTip = {
      "Material of which the part is made.\r\n" +
        "You can write any name of the material. The program will find it in the drawing or template.\r\n" +
        "Or create new material. Press Enter after entering new material.",
      "Материал, из которого сделана эта деталь.\r\n" +
        "Можете написать любое название материала. Программа найдет его в чертеже или шаблоне.\r\n" +
        "Или создаст новый материал. Нажмите Enter после ввода нового материала.",
      "Materiale di cui è composta la parte.\r\n" +
        "Puoi scrivere qualsiasi nome del materiale. Il programma lo troverà nel disegno o nel modello.\r\n" +
        "Oppure crea nuovo materiale. Premi Invio dopo aver inserito il nuovo materiale.",
      "Material, aus dem das Teil besteht.\r\n" +
        "Sie können einen beliebigen Namen des Materials eingeben. Das Programm findet es in der Zeichnung oder Vorlage.\r\n" +
        "Oder erstellen Sie neues Material. Drücken Sie die Eingabetaste, nachdem Sie neues Material eingegeben haben.",
      "制造零件的材料。\r\n" +
         "您可以写任何材料的名称。程序会在图纸或模板中找到它。\r\n" +
         "或创建新材料。输入新材料后按回车键。" };
    public static readonly string[] MeasurementProcess = {
      "Measure",
      "Обмер",
      "Misurati",
      "Messung",
      "措施" };
    //public static readonly string[] MetricBlocked = { 
    //  "Solid blocked", 
    //  "Метрика заблокирована", 
    //  "Metrica bloccata", 
    //  "Messwert blockiert",
    //  "阻止计量" };
    public static readonly string[] SolidMirrorTip = {
      "The detail is mirror-symmetrical to other, similar details.\r\n" +
        "The 'Mirror' property is used when the same parts are grouped together.\r\n" +
        "If the parts are the same in size and additive, but colored differently from different sides,\r\n" +
        "or you need a neat cutter entry on one side, then you can pre-mark the mirrored parts yourself\r\n" +
        "by setting the Mirror = YES property to them.\r\n" +
        "Then the LAY command will be able to separately write the number of 'right' and 'mirror' parts in the part header.\r\n" +
        "You can configure the program so that the mirror details are laid out separately.",
      "Деталь зеркально-симметрична другим, похожим деталям.\r\n" +
        "Свойство Зеркальности используется, когда группируются одинаковые детали.\r\n" +
        "Если детали одинаковые по размерам и присадке, но окрашиваются по-разному с разных сторон\r\n" +
        "или требуется аккуратный вход фрезы с одной стороны, то вы можете сами заранее пометить отзеркаленные детали,\r\n" +
        "поставив им свойство Зеркальный = ДА.\r\n" +
        "Тогда в заголовке детали команда Выкладка (LAY) \r\n" +
        "сможет отдельно написать количество прямых и количество зеркальных деталей.\r\n" +
        "Можно настроить программу, чтоб зеркальные детали выкладывались отдельно.",
      "Il dettaglio è speculare ad altri dettagli simili.\r\n" +
        "La proprietà 'Specchio' viene utilizzata quando le stesse parti sono raggruppate insieme.\r\n" +
        "Se le parti hanno le stesse dimensioni e additivo, ma sono colorate in modo diverso da lati diversi,\r\n" +
        "o hai bisogno di un'entrata di taglio ordinata su un lato, puoi pre-marcare tu stesso le parti specchiate\r\n" +
        "impostando la proprietà Specchio = SÌ su di esse.\r\n" +
        "Quindi il comando LAY sarà in grado di scrivere separatamente\r\n" +
        "il numero di parti 'Corretti' e 'Specchio' nell'intestazione della parte.\r\n" +
        "È possibile configurare il programma in modo che i dettagli del mirror siano disposti separatamente.",
      "Das Detail ist spiegelsymmetrisch zu anderen, ähnlichen Details.\r\n" +
        "Die Specular-Eigenschaft wird verwendet, wenn dieselben Teile gruppiert werden.\r\n" +
        "Wenn die Teile in Größe und Additiv gleich, aber von verschiedenen Seiten unterschiedlich gefärbt sind,\r\n" +
        "oder Sie auf einer Seite einen sauberen Fräsereintritt benötigen,\r\n" +
        "dann können Sie die gespiegelten Teile selbst vormarkieren, indem Sie ihnen die Eigenschaft Mirror = YES setzen.\r\n" +
        "Dann kann der LAY-Befehl die Anzahl der geraden Richtige \r\n" +
        "und die Anzahl der Gespiegelte separat in den Teilekopf schreiben.\r\n" +
        "Sie können das Programm so konfigurieren, dass die Spiegeldetails separat angelegt werden.",
      "细节与其他类似细节镜像对称。\r\n" +
         "当相同的部分组合在一起时使用'Mirror'属性。\r\n" +
         "如果零件的大小和添加剂相同，但从不同的侧面颜色不同，\r\n" +
         "或者你需要在一侧有一个整齐的刀具入口，然后你可以自己预先标记镜像部分\r\n" +
         "通过将 Mirror = YES 属性设置为它们。\r\n" +
         "那么LAY命令就可以在part header中分别写入'right'和'mirror'部分的个数了。\r\n" +
         "您可以配置程序，以便单独布置镜像详细信息。" };
    public static readonly string[] NotBox = {
      "Not box",
      "Не бокс",
      "Nessun parallelepipedo",
      "Nicht Quader",
      "不是盒子" };
    public static readonly string[] Technology = {
      "Technology",
      "Технология",
      "Tecnologia",
      "Technologie",
      "工艺" };
    public static readonly string[] TechnologyTip = {
      "Method of manufacturing parts",
      "Технология, способ изготовления детали",
      "Tecnologia, metodo di fabbricazione di una parte.",
      "Technologie, Verfahren zur Herstellung eines Teils.",
      "零件制造方法" };
    public static readonly string[] Thickness = {
      "Thickness",
      "Толщина",
      "Spessore",
      "Dicke",
      "厚度" };
    public static readonly string[] ThicknessTip = {
      "Thickness = minimum of the three overall dimensions",
      "Меньший из трех габаритных размер бокса в который влезает солид",
      "La più piccola delle tre dimensioni complessive della scatola in cui si inserisce il solido.",
      "Die kleinste der drei Gesamtabmessungen der Kiste, in die der Volumenkörper passt.",
      "厚度 = 三个整体尺寸中的最小值"};
    public static readonly string[] ThicknessMM = {
      "Thickness,mm",
      "Толщина,мм",
      "Spessore,mm",
      "Dicke,mm",
      "厚度 mm" };
    public static readonly string[] TwoSideProcessing = {
      "Double-sided processing ",
      "Двусторонняя обработка ",
      "lavorazione su due lati ",
      "Doppelseitige Bearbeitung ",
      "双面加工"};
    public static readonly string[] Volume = {
      "Volume",
      "Объем",
      "Volume",
      "Volumen",
      "体积" };
    public static readonly string[] VolumeTip = {
      "Real volume of solid. Not product dimensions",
      "Объем тела в текущих единицах чертежа",
      "Volume reale di solido. Non dimensioni del prodotto",
      "Reales Volumen von 3D-Körper. Nicht Produktabmessungen",
      "三维实体的实际体积。 不是产品尺寸"};
    public static readonly string[] WeightTip = {
      "If a material is assigned to the part and the density is set for the material,\r\n" +
        "the program will calculate the weight as the product of density and volume.",
      "Если детали присвоен материал и у материала задана плотность,\r\n" +
        "то программа вычислит вес как произведение плотности на объем.",
      "Se alla parte è assegnato un materiale e il materiale ha una densità,\r\n" +
        "quindi il programma calcolerà il peso come prodotto di densità e volume.",
      "Wenn dem Teil ein Material zugeordnet ist und das Material eine Dichte hat,\r\n" +
        "dann berechnet das Programm das Gewicht als Produkt aus Dichte und Volumen.",
      "如果为零件分配了材料并为该材料设置了密度，\r\n" +
         "程序会将重量计算为密度和体积的乘积"};
    public static readonly string[] Width = {
      "Width",
      "Ширина",
      "Larghezza",
      "Breite",
      "宽度" };
    public static readonly string[] WidthTip = {
      "The second (average) of the three overall dimensions of the box into which the solid fits",
      "Средний из трех габаритных размер бокса в который влезает солид",
      "La media delle tre dimensioni complessive della scatola in cui si inserisce il solido",
      "Der Durchschnitt der drei Gesamtabmessungen des Kastens, in den der Volumenkörper passt",
      "三维实体包围盒的三个整体尺寸中的第二个（平均值）"};
    public static readonly string[] WidthMM = {
      "Width,mm",
      "Ширина,мм",
      "Larghezza,mm",
      "Breite,mm",
      "宽度 mm" };
    public static readonly string[] Slopes = {
      "Slope ends",
      "Наклоны торцев",
      "La pendenza delle estremità",
      "Neigung der Enden",
      "斜坡末端" };
    public static readonly string[] Sweep = {
      "Sweep",
      "Развертка",
      "Scansione",
      "Sweep",
      "扫掠" };
    public static readonly string[] SweepTip = {
      "Affects how other plugins will measure solid.\r\n" +
        "If you set the value YES, then the measurement program will attempt to measure this item,\r\n" +
        "as if it was made from a thin rectangle and smoothly (no fractures) curved in one plane.\r\n" +
        "Such measurement is suitable for the skins stretched on a cylinder\r\n" +
        "or combined cylindrical and flat faces without fractures.",
      "'Развертка' влияет на то, как другие плагины будут обмерять твердое тело.\r\n" +
        "Если вы поставите значение ДА, то программа будет пытаться обмерить эту деталь,\r\n" +
        "как будто она была изготовлена из тонкого прямоугольника и плавно (без изломов) изогнута в одной плоскости.\r\n" +
        "Такой обмер подходит для обшивок натянутых на цилиндр или сочетающий цилиндрические и плоские участки без изломов.",
      "'Scansione' influenza il modo in cui altri plugin misureranno un corpo solido.\r\n" +
        "Se si imposta il valore SÌ, il programma di misurazione tenterà di misurare questo articolo,\r\n" +
        "come se fosse fatto da un rettangolo sottile e senza intoppi (senza fratture) curva su un piano.\r\n" +
        "Tale misura è adatta per le pelli tese su un cilindro o combinate facce cilindriche e piatte senza fratture.",
      "'Sweep' beeinflusst, wie andere Plugins einen Volumenkörper messen.\r\n" +
        "Wenn Sie den Wert JA einstellen, dann das Messprogramm wird versuchen, diesen Gegenstand so zu messen,\r\n" +
        "als wäre er aus einem dünnen Rechteck und glatt (keine Brüche) in einer Ebene gekrümmt.\r\n" +
        "Eine solche Messung ist für auf einen Zylinder gespannte Häute geeignet\r\n" +
        "oder kombinierte zylindrische und flache Flächen ohne Brüche.",
      "影响其他插件如何测量实体。\r\n" +
         "如果你设置的值为YES，那么测量程序会尝试测量这个项目，\r\n" +
         "就好像它是由一个细长的矩形制成的，并且在一个平面上平滑地（没有断裂）弯曲。\r\n" +
         "这种测量适用于在圆柱体上拉伸的皮肤\r\n" +
         "或组合的圆柱面和平面没有断裂。" };
    public static readonly string[] Texture = {
      "Texture",
      "Текстура",
      "Struttura",
      "Textur",
      "纹理方向" };
    public static readonly string[] TextureTip = {
      "Invented for marking parts made of wood or a wood pattern.\r\n" +
        "Use it when you it is important to flag as the texture should be placed.\r\n" +
        "There are three options: when no matter what the part is placed on a sheet of material - use the value No.\r\n" +
        "When the wood fiber should be placed on the long side parts - use the value Along.\r\n" +
        "And when on the short side – value Across.\r\n" +
        "At the moment, this setting is purely virtual, it does not affect the rendering of the material.",
      "Укажите вдоль какой стороны детали направлен рисунок материала (волокна дерева).\r\n" +
        "На данный момент эта настройка чисто виртуальная, она не влияет на рендеринг материала.",
      "Specificare lungo quale lato della parte è diretto il motivo del materiale (fibre di legno).\r\n" +
        "Al momento questa impostazione è puramente virtuale, non pregiudica la resa del materiale.",
      "Geben Sie an, entlang welcher Seite des Teils das Muster des Materials (Holzfasern) ausgerichtet ist.\r\n" +
        "Im Moment ist diese Einstellung rein virtuell, sie hat keinen Einfluss auf das Rendern des Materials.",
      "用于标记由木头或木纹制成的零件。\r\n" +
         "当你需要标记纹理时使用它。\r\n" +
         "有三种选择：任何方向都可行时- 使用值 No.\r\n" +
         "当木纹方向在长度时 - 使用值Along。\r\n" +
         "当木纹方向在宽度时– 使用值Across。\r\n" +
         "目前，这个设置是纯虚拟的，不影响材质的渲染。" };
    public static readonly string[] Texture1 = {
      "Texture 1",
      "Есть текстура",
      "Struttura 1",
      "Textur 1",
      "纹理 1" };
    public static readonly string[] Texture2 = {
      "Texture 2",
      "Текстура 2",
      "Struttura 2",
      "Textur 2",
      "纹理 2" };
    public static readonly string[] TextureStar = {
      "Texture *",
      "Текстура *",
      "Struttura *",
      "Textur *",
      "纹理 *" };
    public static readonly string[] Letter = {
      "Letter",
      "Символ",
      "Lettera",
      "Buchstabe",
      "信" };
    public static readonly string[] OuterId = {
      "ID",
      "Код",
      "ID",
      "ID",
      "外部编号" };
    public static readonly string[] OuterIdTip = {
      "Part ID in external database, IMOS or Microvellum.",
      "Идентификатор детали во внешней базе данных, в IMOS или Microvellum.",
      "ID parte in database esterno, IMOS o Microvellum",
      "Teile-ID in externer Datenbank, IMOS oder Microvellum",
      "外部数据库、IMOS 或 Microvellum 中的零件 ID" };


    // ============================================================================================================
    // Solid Face  ================================================================================================
    public static readonly string[] Solid_Face = {
      "Solid & Face",
      "Солид и Поверхность",
      "Solido e Faccia",
      "Volumenkörper & Fläche",
      "实体和面" };
    public static readonly string[] Solids_Faces = {
      "Solids & Faces",
      "Солиды и Поверхности",
      "Solido e Facce",
      "Volumenkörper & Flächen",
      "实体和面" };
    public static readonly string[] SelectedFace = {
      "Selected Face",
      "Выбранная поверхность",
      "Faccia selezionata",
      "Ausgewählte Fläche",
      "选定的面" };
    public static readonly string[] All = {
      "All",
      "Все",
      "Tutti",
      "Alle",
      "全部" };
    public static readonly string[] FaceIntId = {
      "Id",
      "№",
      "ID",
      "Ausweis",
      "Id" };
    public static readonly string[] FaceIntIdTip = {
      "The surface number in the public structure of the 3d-solid.",
      "Номер поверхности во внутренней структуре солида",
      "Il numero di superficie nella struttura interna del solido 3D.",
      "Die Flächenzahl in der inneren Struktur des Volumenkörpers.",
      "3d 实体内部结构中的表面编号。" };
    public static readonly string[] FaceAreaTip = {
      "Surface area. On a millimeter drawing - in square meters.",
      "Площадь поверхности. На миллиметровом чертеже - в квадратных метрах.",
      "L'area di questa superficie. Su un disegno millimetrico - in metri quadrati.",
      "Oberfläche. Auf einer Millimeterzeichnung - in Quadratmetern.",
      "表面积。 在毫米单位图形中 - 以平方米为单位。" };
    public static readonly string[] FaceCoverTip = {
      "Material for coated surface.\r\n" +
        "Paint, film, laminate.\r\n" +
        "Enter any text. The program can create new materials.",
      "Материал покрытия поверхности.\r\n" +
        "Краска, пленка, ламинат.\r\n" +
        "Введите любой текст. Программа может создавать новые материалы.",
      "Materiale per superficie rivestita.\r\n" +
        "Vernice, pellicola, laminato.\r\n" +
        "Inserisci qualsiasi testo. Il programma può creare nuovi materiali.",
      "Material für beschichtete Oberfläche.\r\n" +
        "Lackieren, folieren, laminieren.\r\n" +
        "Geben Sie einen beliebigen Text ein. Das Programm kann neue Materialien erstellen.",
      "涂层表面材料。\r\n" +
         "油漆、胶片、层压板。\r\n" +
         "输入任何文本。程序可以创建新材料。" };
    public static readonly string[] LeftLetter = {
      "L",
      "Л",
      "S",
      "li",
      "左" };
    public static readonly string[] TopLetter = {
      "T",
      "В",
      "A",
      "hi",
      "上" };
    public static readonly string[] RightLetter = {
      "R",
      "П",
      "D",
      "re",
      "右" };
    public static readonly string[] BottomLetter = {
      "B",
      "Н",
      "B",
      "vo",
      "下" };
    public static readonly string[] LengthLetter = {
      "Len",
      "Д",
      "Lun",
      "lä",
      "长" };
    public static readonly string[] WidthLetter = {
      "W",
      "Ш",
      "Lar",
      "br",
      "宽" };

    public static readonly string[] FaceShape = {
      "Shape",
      "Форма",
      "Forma",
      "Gestalten",
      "形状" };
    public static readonly string[] FaceShapeTip = {
      "The geometric shape of the solid surface. Only planes can be used as front side",
      "Геометрическая форма поверхности солида. В качестве фасадной стороны могут быть использованы только плоскости (Plane)",
      "La forma geometrica della superficie solida. Solo gli aerei possono essere utilizzati come lato anteriore",
      "Die geometrische Form der festen Oberfläche. Als Vorderseite können nur Ebenen verwendet werden",
      "三维实体表面的几何形状。 只有平面可以用作正面" };
    public static readonly string[] FaceFrontColorMark = {
      "Marked as front",
      "Метка фасада",
      "Facciata",
      "Fassade",
      "标记为正面" };
    public static readonly string[] FaceFrontColorMarkTip = {
      "The color of the edge corresponds to the marking of the front side.\r\n" +
        "The color mark can be used by the program for measuring and layout solids.",
      "Цвет грани соответствует маркировке фасадной стороны.\r\n" +
        "Цветовая метка может быть использована программой обмера и выкладки солидов.",
      "Il colore di questa faccia indica il lato anteriore.\r\n" +
        "Il contrassegno colorato può essere utilizzato dal programma per la misurazione e la disposizione dei solidi.",
      "Die Farbe dieser Fläche zeigt die Vorderseite an.\r\n" +
        "Die Farbmarke kann vom Programm zum Messen und Anordnen von Volumenkörpern verwendet werden.",
      "边缘的颜色对应正面的标记。\r\n" +
         "程序可以使用颜色标记来测量和布局实体。" };
    public static readonly string[] FaceColor = {
      "Face color",
      "Цвет грани",
      "Colore di faccia",
      "Gesichtsfarbe",
      "边缘颜色"};
    public static readonly string[] FaceMaterial = {
      "Face material",
      "Материал грани",
      "Materiale di faccia",
      "Gesichtsmaterial",
      "面材" };

    // Covers
    public static readonly string[] CoversAllTip = {
    "Assign material to all surfaces at once.\n" +
        "Material will appear on the front, rear and all other surfaces\n" +
        "that previously already had a coating.\n" +
        "Press Enter after entering new material.",
    "Назначить материал для всех поверхностей сразу.\n" +
        "Материал появится у фасада, тыла и всех прочих поверхностей,\n" +
        "которые ранее уже имели покрытие.\n" +
        "Нажмите Enter после ввода нового материала.",
    "Assegna il materiale a tutte le superfici contemporaneamente.\n" +
        "Il materiale apparirà sulla facciata, sul posteriore\n" +
        "e su tutte le altre superfici che in precedenza avevano già un rivestimento.\n" +
        "Premi Enter dopo aver inserito il nuovo materiale.",
    "Ordnen Sie allen Oberflächen gleichzeitig Material zu.\n" +
        "Material erscheint auf der Fassade, der Rückseite \n" +
        "und allen anderen Oberflächen, die zuvor bereits beschichtet waren.\n" +
        "Drücken Sie Enter, nachdem Sie neues Material eingegeben haben.",
      "一次将材质分配给所有表面。\n" +
         "材质将出现在正面、背面和所有其他表面\n" +
         "以前已经有涂层了。\n" +
         "输入新材料后按 Enter。" };
    public static readonly string[] CoversIDTip = {
      "The surface number in the public structure of the 3d-solid.",
      "Номер поверхности во внутренней структуре солида.",
      "Il numero di superficie nella struttura interna del solido3d.",
      "Die Oberflächennummer in der inneren Struktur des Solid3D.",
      "实体内部结构中的表面数。" };
    public static readonly string[] CoversAreaTip = {
      "Surface area.\n" +
        "In a millimeter drawing it is calculated in square meters.",
      "Площадь поверхности.\n" +
        "На миллиметровом чертеже - в квадратных метрах.",
      "Superficie.\n" +
        "In un disegno millimetrico viene calcolato in metri quadrati.",
      "Oberfläche.\n" +
        "In einer Millimeterzeichnung wird es in Quadratmetern berechnet.",
      "表面积。\n" +
        "在毫米单位图形中，它以平方米计算。" };
    public static readonly string[] CoversMaterialTip = {
    "Material for coated surface.\n" +
        "Paint, film, laminate.\n" +
        "Enter any text. The program can create new materials.\n" +
        "Press Enter after entering new material.",
    "Материал для поверхности с покрытием.\n" +
        "Краска, пленка, ламинат.\n" +
        "Введите любой текст. Программа может создавать новые материалы.\n" +
        "Нажмите Enter после ввода нового материала.",
    "Materiale per superficie rivestita.\n" +
        "Vernice, pellicola, laminato.\n" +
        "Inserisci qualsiasi testo. Il programma può creare nuovi materiali.\n" +
        "Premi Enter dopo aver inserito il nuovo materiale.",
    "Material für beschichtete Oberfläche.\n" +
        "Farbe, Film, Laminat.\n" +
        "Geben Sie einen beliebigen Text ein. Das Programm kann neue Materialien erstellen.\n" +
        "Drücken Sie Enter, nachdem Sie neues Material eingegeben haben.",
      "涂层表面材料。 " +
        "油漆，薄膜，层压板。 " +
        "输入任何文本。 " +
        "该程序可以创建新材料。 " +
        "输入新材料后按 Enter。" };
    public static readonly string[] CoversOther = {
      "All other",
      "Все прочие",
      "Tutti gli altri",
      "Alles andere",
      "所有其他" };
    public static readonly string[] CoversOtherTip = {
      "Material for all other surfaces covered with a coating.",
      "Материал для всех остальных поверхностей, имеющих покрытие.",
      "Materiale per tutte le altre superfici coperte da un rivestimento.",
      "Material für alle anderen mit einer Beschichtung bedeckten Oberflächen.",
      "覆盖有涂层的所有其他表面的材料。" };

    // Bandings
    public static readonly string[] BandingsAllTip = {
      "All edges",
      "Покрытие для всех торцев",
      "Copertura per tutte le estremità.",
      "Abdeckung für alle Zwecke.",
      "所有边缘" };
    public static readonly string[] BandingsIDTip = {
      "The number of the edge in the order of going around the front surface.\r\n" +
        "The numbers are set for the part laid out with the front down. \r\n" +
        "Starting from the lower left corner and going clockwise. \r\n" +
        "For a rectangular part, you can specify side names instead of a number.",
      "Номер торца по порядку обхода фасадной поверхности солида.\r\n" +
        "Номера задаются для детали, выложенной фасадом вниз. \r\n" +
        "Начиная с левого нижнего угла и далее по часовой стрелке.\r\n" +
        "Для четырехугольной детали можно задать названия сторон вместо номера.",
      "Il numero del bordo nell'ordine di andare attorno alla superficie anteriore.\r\n" +
        "I numeri sono impostati per la parte disposta con la facciata abbassata. \r\n" +
        "Partendo dall'angolo in basso a sinistra e procedendo in senso orario. \r\n" +
        "Per una parte rettangolare, puoi specificare i nomi dei lati invece di un numero.",
      "Die Nummer der Kante in der Reihenfolge, in der sie um die Vorderseite herum verläuft.\r\n" +
        "Die Nummern werden für den mit der Fassade nach unten ausgelegten Teil festgelegt. \r\n" +
        "Beginnend in der unteren linken Ecke und im Uhrzeigersinn. \r\n" +
        "Für ein rechteckiges Teil können Sie Seitennamen anstelle einer Nummer angeben.",
      "以围绕前表面的顺序排列的边数。 \r\n" +
        "这些数字是为立面向下布置的部分设置的。 \r\n" +
        "从左下角开始，顺时针方向。 \r\n" +
        "对于矩形零件，您可以指定边名而不是数字。" };
    public static readonly string[] BandingsMaterialTip = {
      "The coating material of the end face of the part.\r\n" +
        "Enter any text. The program can create new materials.",
      "Материал покрытия или кромки на торец детали.\r\n" +
        "Введите любой текст. Программа может создавать новые материалы.",
      "Il materiale di rivestimento della faccia finale della parte.\r\n" +
        "Inserisci qualsiasi testo. Il programma può creare nuovi materiali.",
      "Das Beschichtungsmaterial der Stirnfläche des Teils.\r\n" +
        "Geben Sie einen beliebigen Text ein. Das Programm kann neue Materialien erstellen.",
      "零件端面的涂层材料。\r\n" +
         "输入任何文本。程序可以创建新材料。" };
    public static readonly string[] BandingsLength = {
      "The length of the banding.\r\n" +
        "It is calculated by the length of the edge of the front.",
      "Длина кромки. Рассчитывается по длине ребра фасада.",
      "La lunghezza della fascia.\r\n" +
        "È calcolato dalla lunghezza del bordo anteriore.",
      "Die Länge der Banderole.\r\n" +
        "Sie berechnet sich aus der Länge der Vorderkante.",
      "封边的长度。\r\n" +
         "它是由前面边缘的长度计算的。" };
    public static readonly string[] BandingsAngle = {
      "Saw angle for flat ends.",
      "Угол наклона пилы для плоских торцев.",
      "Angolo di sega per estremità piatte.",
      "Sägewinkel für flache Enden.",
      "平端锯切角度。" };

    // ================================================================================================
    // Table   ================================================================================================
    public static readonly string[] Section = {
      "Section",
      "Раздел",
      "Sezione",
      "Abschnitt",
      "部分" };
    public static readonly string[] SectionTip = {
      "Part of a table split into multiple sheets with the TableSplit command.",
      "Часть таблицы, разделенной на несколько листов командой TableSplit.",
      "Parte di una tabella divisa in più fogli con il comando Dividi tabella.",
      "Teil einer Tabelle, die mit dem Befehl TableSplit in mehrere Blätter aufgeteilt wurde.",
      "使用 TableSplit 命令将表格的一部分拆分为多个工作表。" };
    public static readonly string[] Table = {
      "Table",
      "Таблица",
      "Tabella",
      "Tabelle",
      "表" };
    public static readonly string[] Tables = {
      "Tables",
      "Таблицы",
      "Tabelle",
      "Tabellen",
      "表" };
    public static readonly string[] TableNameTip = {
      "First row of the table",
      "Первая строка таблицы",
      "Prima riga della tabella",
      "Erste Zeile der Tabelle",
      "表格的第一行" };
    public static readonly string[] Sources = {
      "Sources",
      "Источники",
      "Fonti",
      "Quellen",
      "来源" };
    public static readonly string[] SourcesTip = {
      "The AVC program that populated this table and the data sources",
      "Программа AVC, заполнившая эту таблицу и источники данных",
      "Programma AVC che ha popolato questa tabella e origini dati",
      "AVC-Programm, das diese Tabelle und Datenquellen gefüllt hat",
      "填充此表和数据源的 AVC 程序" };

    // ================================================================================================
    // Text  ================================================================================================
    public static readonly string[] Text = {
      "Text",
      "Текст",
      "Testo",
      "Text",
      "文本" };
    public static readonly string[] Contents = {
      "Contents",
      "Содержание",
      "Contenuti",
      "Inhalt",
      "内容" };
    public static readonly string[] TextStringTip = {
      "Content displayed on the drawing",
      "Содержимое, выводимое на чертеж",
      "Contenuto visualizzato nel disegno",
      "In der Zeichnung angezeigter Inhalt",
      "图形上显示的内容" };
    public static readonly string[] Texts = {
      "Texts",
      "Тексты",
      "Testi",
      "Texte",
      "文本" };
    public static readonly string[] TextHeight = {
      "Text Height",
      "Размер текста",
      "Altezza del testo",
      "Textgröße",
      "文字高度" };
    public static readonly string[] TextHeightTip = {
      "Font size",
      "Размер шрифта",
      "Dimensione del font",
      "Schriftgröße",
      "字体大小" };
    public static readonly string[] TextFrame = {
      "Text frame",
      "Рамка текста",
      "Cornice di testo",
      "Textrahmen",
      "文本框" };
    public static readonly string[] TextFrameTip = {
      "Create a rectangular frame around text",
      "Создавать прямоугольную рамку вокруг текста",
      "Crea una casella rettangolare attorno al testo",
      "Erstellen Sie einen rechteckigen Rahmen um den Text",
      "在文本周围创建一个矩形框" };

    // ================================================================================================
    // Time  ==================================================================================
    public static readonly string[] Time = {
      "Time",
      "Время",
      "Tempo",
      "Zeit",
      "时间" };
    public static readonly string[] TimeTip = {
      "This point in time. Without date",
      "Данный момент времени. Без даты",
      "Questo momento. Senza data",
      "Dieser Zeitpunkt. Ohne Datum",
      "这个时间点。 无日期" };
    public static readonly string[] Today = {
      "Today",
      "Сегодня",
      "Oggi",
      "Heute",
      "今天" };
    public static readonly string[] TodayTip = {
      "Today is the day of the calendar. Without time.",
      "Сегодняшний день календаря. Без времени.",
      "Oggi è il giorno del calendario. Senza tempo.",
      "Heute ist der Kalendertag. Ohne Zeit.",
      "今天是日历中的日子。 没有时间。" };
    public static readonly string[] Now = {
      "Now",
      "Сейчас",
      "Momento",
      "Jetzt" ,
      "现在"};
    public static readonly string[] NowTip = {
      "This point in time. Time and date.",
      "Данный момент времени. Время и дата.",
      "Questo momento. Ora e data.",
      "Dieser Zeitpunkt. Zeit und Datum.",
      "这个时间点。 时间和日期。" };
    public static readonly string[] TimeStamp = {
      "Time Stamp",
      "Метка времени",
      "Data e ora",
      "Zeitstempel",
      "时间戳" };
    public static readonly string[] TimeStampTip = {
      "The current moment in time in a format suitable for alphabetical sorting.",
      "Текущий момент времени в формате удобном для алфавитной сортировки.",
      "Il momento attuale in un formato adatto per l'ordinamento alfabetico.",
      "Der aktuelle Zeitpunkt in einem für die alphabetische Sortierung geeigneten Format.",
      "以适合字母排序的格式表示的当前时刻。" };


    // ================================================================================================
    // Viewport, LAY view     // ================================================================================================
    public static readonly string[] Viewport = {
      "Viewport",
      "Вид",
      "Viewport",
      "Viewport",
      "视口 Viewport" };
    public static readonly string[] Viewports = {
      "Viewports",
      "Виды",
      "Viewports",
      "Viewports",
      "视口 Viewports" };
    public static readonly string[] Views = {
      "Views",
      "Виды",
      "Visualizzazioni",
      "Ansichten",
      "视图" };
    public static readonly string[] ViewportNumber = {
      "Viewport Number",
      "Номер вьюпорта",
      "Numero di viewport",
      "Ansichtsfensternummer",
      "视口数量" };
    public static readonly string[] ViewportIndex = {
      "Viewport Index",
      "Индекс вьюпорта",
      "Indice di viewport",
      "Ansichtsfensterindex",
      "视口索引" };
    public static readonly string[] ViewDirection = {
      "View Direction",
      "Направление вида",
      "Visualizza direzione",
      "Blickrichtung",
      "查看方向" };
    public static readonly string[] ViewName = { // только для LAY
      "View Name",
      "Имя вида",
      "Visualizza nome",
      "Name anzeigen",
      "视图名称" };
    public static readonly string[] Locked = {
      "Locked",
      "Заблокирован",
      "Bloccato",
      "Gesperrt",
      "锁定"};
    public static readonly string[] LockedTip = {
      "Lock model view and scale from accidental shift",
      "Заблокировать вид модели и масштаб от случайного сдвига",
      "Blocca la visualizzazione e la scala del modello da spostamenti accidentali",
      "Sperren Sie die Modellansicht und den Maßstab, damit diese nicht versehentlich verschoben werden.",
      "锁定模型视图和比例以防止意外移位"};
    public static readonly string[] On = {
      "On",
      "Включен",
      "SU",
      "An",
      "在"};
    public static readonly string[] OnTip = {
      "Enable display of model objects",
      "Включить отображение объектов модели",
      "Abilita la visualizzazione degli oggetti del modello",
      "Anzeige von Modellobjekten aktivieren",
      "启用模型对象的显示"};
    public static readonly string[] CustomScale = {
      "Scale",
      "Масштаб",
      "Scale",
      "Rahmen",
      "比例" };
    public static readonly string[] CustomScaleTip = {
      "Scale factor: The ratio of the dimensions in the model to the dimensions on paper.",
      "Масштабный коэффициент: отношение размеров в модели к размерам на бумаге.",
      "Fattore di scala: il rapporto tra le dimensioni nel modello e le dimensioni sulla carta.",
      "Skalierungsfaktor: Das Verhältnis der Abmessungen im Modell zu den Abmessungen auf dem Papier.",
      "比例因子：模型中的尺寸与纸上的尺寸之比。" };
    public static readonly string[] VisualStyle = {
      "Visual Style",
      "Визуальный стиль",
      "Stili visivi",
      "Visuelle Stile",
      "视觉样式" };
    public static readonly string[] VisualStyleTip = {
      "Visual style of the viewport",
      "Визуальный стиль вьюпорта",
      "Stile visivo della vista",
      "Visueller Stil des Ansichtsfensters",
      "视口的视觉样式" };
    public static readonly string[] FrontView4Lay = {
      "FRONT VIEW",
      "ВИД СПЕРЕДИ",
      "VISTA FRONTALE",
      "VORNE",
      "正视图" };
    public static readonly string[] RearView4Lay = {
      "REAR VIEW",
      "ВИД СЗАДИ",
      "VISTA POSTERIORE",
      "HINTEN",
      "后视图" };
    public static readonly string[] FrontSide = {
      "Front",
      "Фасад",
      "Facciata",
      "Fassade",
      "正面" };
    public static readonly string[] RearSide = {
      "Rear",
      "Тыл",
      "Posteriore",
      "Hinten",
      "反面" };
    public static readonly string[] FrontView = { 
      "FRONT",
      "СПЕРЕДИ",
      "FRONTALE",
      "VORNE",
      "正面" };
    public static readonly string[] RearView = {
      "REAR",
      "СЗАДИ",
      "POSTERIORE",
      "HINTEN",
      "后面" };
    public static readonly string[] LeftView = {
      "LEFT",
      "СЛЕВА",
      "SINISTRA",
      "LINKS",
      "左侧" };
    public static readonly string[] RightView = {
      "RIGHT",
      "СПРАВА",
      "GIUSTA",
      "RECHTS",
      "右侧" };
    public static readonly string[] TopView = {
      "TOP",
      "СВЕРХУ",
      "ALTO",
      "OBEN",
      "顶部" };
    public static readonly string[] BottomView = {
      "BOTTOM",
      "СНИЗУ",
      "BASSO",
      "UNTEN",
      "底部" };
    public static readonly string[] SWView = {
      "SW",
      "ЮЗ",
      "SO",
      "SW",
      "西南" };
    public static readonly string[] NWView = {
      "NW",
      "СЗ",
      "NO",
      "NW",
      "西北" };
    public static readonly string[] SEView = {
      "SE",
      "ЮВ",
      "SE",
      "SE",
      "东南" };
    public static readonly string[] NEView = {
      "NE",
      "СВ",
      "NE",
      "NE",
      "东北" };
    public static readonly string[] Isometric = {
      "ISOMETRIC",
      "ИЗОМЕТРИЯ",
      "ISOMETRICO",
      "ISOMETRISCH",
      "等距" };
    public static readonly string[] PerspectiveOn = {
      "Perspective",
      "Перспектива",
      "Prospettiva",
      "Perspektive",
      "看法" };
    public static readonly string[] PerspectiveOnTip = {
      "Perspective projection",
      "Перспективная проекция",
      "Proiezione prospettica",
      "Perspektivische Projektion",
      "透视投影" };
    public static readonly string[] ClipFront = {
      "Front",
      "Фронт",
      "Davanti",
      "Vorne",
      "前面" };
    public static readonly string[] ClipFrontTip = {
      "Distance from viewpoint to front clipping plane",
      "Дистанция от точки вида до передней отсекающей плоскости",
      "Distanza dal punto di vista al piano di ritaglio anteriore",
      "Abstand vom Blickpunkt zur vorderen Schnittebene",
      "视点到前剪裁平面的距离" };
    public static readonly string[] ClipBack = {
      "Back",
      "Зад",
      "Indietro",
      "Zurück",
      "后退" };
    public static readonly string[] ClipBackTip = {
      "Distance from viewpoint to back clipping plane",
      "Дистанция от точки вида до задней отсекающей плоскости",
      "Distanza dal punto di vista al piano di ritaglio posteriore",
      "Abstand vom Blickpunkt zur hinteren Schnittebene",
      "视点到后剪裁平面的距离" };
    public static readonly string[] FrontClipOn = {
      "Clip Front",
      "Обрезать фронт",
      "Clip anteriore",
      "Clip vorne",
      "夹子正面" };
    public static readonly string[] FrontClipOnTip = {
      "Enable front clipping plane and hide all objects in front of it",
      "Включить переднюю отсекающую плоскость и скрыть все объекты перед ней",
      "Abilita il piano di ritaglio anteriore e nascondi tutti gli oggetti davanti ad esso",
      "Aktivieren Sie die vordere Schnittebene und verbergen Sie alle Objekte davor",
      "启用前剪裁平面并隐藏其前面的所有对象" };
    public static readonly string[] BackClipOn = {
      "Clip Back",
      "Обрезать зад",
      "Clip indietro",
      "Clip zurück",
      "夹回" };
    public static readonly string[] BackClipOnTip = {
      "Enable back clipping plane and hide all objects behind it",
      "Включить заднюю отсекающую плоскость и скрыть все объекты за ней",
      "Abilita il piano di ritaglio posteriore e nascondi tutti gli oggetti dietro di esso",
      "Aktivieren Sie die hintere Schnittebene und verbergen Sie alle Objekte dahinter",
      "启用后剪裁平面并隐藏其后面的所有对象" };

    // =======================================================================================================
    // Layout 
    // =======================================================================================================
    public static readonly string[] Layout = {
      "Layout",
      "Лист",
      "Layout",
      "Layout",
      "布局" };
    public static readonly string[] Layouts = {
      "Layouts",
      "Листы",
      "Layout",
      "Layout",
      "布局" };
    public static readonly string[] TabOrder = {
      "Tab order",
      "Номер закладки",
      "Ordine delle schede",
      "Tab-Reihenfolge",
      "标签顺序" };
    public static readonly string[] VPCount = {
      "Number of viewports ",
      "Количество вьюпортов",
      "Numero di finestre",
      "Anzahl der Ansichtsfenster",
      "视口数量" };

    // =======================================================================================================
    // Layer 
    // =======================================================================================================
    public static string[] LayerFilters = {
      "Layer Filters",
      "Фильтры слоев",
      "Filtri di layer",
      "Ebenenfilter",
      "图层过滤器" };
    public static readonly string[] IsLocked = {
      "Locked",
      "Заблокирован",
      "Bloccato",
      "Gesperrt",
      "锁定"};
    public static readonly string[] IsLockedTip = {
      "Layer objects cannot be edited",
      "Объекты слоя невозможно редактировать",
      "Gli oggetti livello non possono essere modificati",
      "Layer-Objekte können nicht bearbeitet werden",
      "图层对象无法编辑"};
    public static readonly string[] IsPlottable = {
      "Plottable",
      "Печатаемый",
      "Stampabile",
      "Plotbar",
      "可绘图"};
    public static readonly string[] IsPlottableTip = {
      "Objects from this layer will be printed.",
      "Объекты этого слоя будут выводиться на печать.",
      "Gli oggetti di questo livello verranno stampati.",
      "Objekte aus dieser Ebene werden gedruckt.",
      "将打印该层中的对象。"};
    public static readonly string[] IsOff = {
      "Off",
      "Отключен",
      "Spento",
      "Aus",
      "已关闭" };
    public static readonly string[] IsOffTip = {
      "The layer is disabled. Objects are not visible but can be selected",
      "Слой отключен. Объекты не видны, но могут быть выбраны",
      "Il livello è disabilitato. Gli oggetti non sono visibili ma possono essere selezionati",
      "Die Ebene ist deaktiviert. Objekte sind nicht sichtbar, können aber ausgewählt werden",
      "该层被禁用。 对象不可见但可以选择" };
    public static readonly string[] IsFrozen = {
      "Frozen",
      "Заморожен",
      "Congelato",
      "Gefroren",
      "被冻结" };
    public static readonly string[] IsFrozenTip = {
      "The layer is frozen. Layer objects are not visible, cannot be selected, and do not participate in any calculations.",
      "Слой заморожен. Объекты слоя не видны, не могут быть выбраны и не участвуют ни в каких расчетах.",
      "Lo strato è congelato. Gli oggetti layer non sono visibili, non possono essere selezionati e non partecipano ad alcun calcolo.",
      "Die Schicht ist eingefroren. Layer-Objekte sind nicht sichtbar, können nicht ausgewählt werden und nehmen an keiner Berechnung teil.",
      "该层被冻结。 图层对象不可见、无法选择、不参与任何计算。" };
    public static readonly string[] LayerMaterialTip = {
      "The material from which the details of this layer are made. \r\n" +
        "The material will be applied to all parts that have the material set to By Layer.\r\n" +
        "You can write any name of the material. The program will find it in the drawing or template.\r\n" +
        "Or create new material. Press Enter after entering new material.",
      "Материал, из которого сделаны детали этого слоя. \r\n" +
        "Материал будет применяться ко всем деталям у которых материал назначен По Слою.\r\n" +
        "Можете написать любое название материала. Программа найдет его в чертеже или шаблоне.\r\n" +
        "Или создаст новый материал. Нажмите Enter после ввода нового материала.",
      "Il materiale con cui sono realizzati i dettagli di questo Layer. \r\n" +
        "Il materiale verrà applicato a tutte le parti che hanno il materiale impostato su Per Layer.\r\n" +
        "Puoi scrivere qualsiasi nome del materiale. Il programma lo troverà nel disegno o nel modello.\r\n" +
        "Oppure crea nuovo materiale. Premi Invio dopo aver inserito il nuovo materiale.",
      "Das Material, aus dem die Details dieser Schicht bestehen. \r\n" +
        "Das Material wird auf alle Teile angewendet, für die das Material auf „Nach Ebene“ eingestellt ist.\r\n" +
        "Sie können einen beliebigen Namen des Materials eingeben. Das Programm findet es in der Zeichnung oder Vorlage.\r\n" +
        "Oder erstellen Sie neues Material. Drücken Sie die Eingabetaste, nachdem Sie neues Material eingegeben haben.",
      "制作该层细节的材料。 该材质将应用于材质设置为“按层”的所有零件。\r\n" +
         "您可以写任何材料的名称。程序会在图纸或模板中找到它。\r\n" +
         "或创建新材料。输入新材料后按回车键。" };
    public static readonly string[] IsReconciled = {
      "Reconciled",
      "Согласованный",
      "Riconciliato",
      "Versöhnt",
      "和解了"};
    public static readonly string[] IsReconciledTip = {
      "The xref layer is reconciled with its source file. \r\n" +
        "To match the layer, check the box and save the layer settings.",
      "Слой внешней ссылки согласован с его исходным файлом. \r\n" +
        "Чтоб согласовать слой, поставьте галочку и сохраните настройки слоя.",
      "Il layer xrif viene riconciliato con il relativo file di origine. \r\n" +
        "Per abbinare il livello, seleziona la casella e salva le impostazioni del livello.",
      "Der XRef-Layer wird mit seiner Quelldatei abgeglichen. \r\n" +
        "Um die Ebene anzupassen, aktivieren Sie das Kontrollkästchen und speichern Sie die Ebeneneinstellungen.",
      "外部参照图层与其源文件一致。要匹配图层，请选中该框并保存图层设置。"};
    public static readonly string[] IsUsed = {
      "Used",
      "Использован",
      "Usato",
      "Gebraucht",
      "用过的"};
    public static readonly string[] IsUsedTip = {
      "There are objects belonging to this layer in the drawing. If the layer is not used, then the layer can be deleted with the _Purge command",
      "В чертеже существуют объекты принадлежащие этому слою. Если слой не использован, то слой можно удалить командой _Purge",
      "Nel disegno sono presenti oggetti appartenenti a questo layer. Se il layer non viene utilizzato, il layer può essere cancellato con il comando _Purge",
      "Zu dieser Ebene gehören in der Zeichnung Objekte. Wenn die Ebene nicht verwendet wird, kann die Ebene mit dem Befehl _Purge gelöscht werden",
      "绘图中存在属于该图层的对象。 如果不使用该图层，则可以使用_Purge命令删除该图层" };
    public static readonly string[] ViewportVisibilityDefault = {
      "Frozen in new viewports",
      "Заморожен в новых вьюпортах",
      "Congelato in nuove viewport",
      "Gefroren in neuen viewport",
      "冻结在新视口中" };
    public static readonly string[] ViewportVisibilityDefaultTip = {
      "Freeze layer in newly created viewports by default.",
      "Замораживать слой во вновь созданных вьюпортах (видовых экранах) по умолчанию.",
      "Blocca il layer nelle finestre appena create per impostazione predefinita.",
      "Ebene in neu erstellten Ansichtsfenstern standardmäßig einfrieren.",
      "默认情况下，冻结新创建的视口中的图层。" };

    // =======================================================================================================
    // Group  
    // =======================================================================================================
    public static readonly string[] Group = {
      "Group",
      "Группа",
      "Gruppo",
      "Gruppe",
      "团体" };
    public static readonly string[] Groups = {
      "Groups",
      "Группы",
      "Gruppi",
      "Gruppen",
      "团体" };
    public static readonly string[] NumEntities = {
      "Number of Entities",
      "Количество объектов",
      "Numero di entità",
      "Anzahl der Entitäten",
      "实体数量" };
    public static readonly string[] NumEntitiesTip = {
      "Number of objects in the group",
      "Количество объектов в группе",
      "Numero di oggetti nel gruppo",
      "Anzahl der Objekte in der Gruppe",
      "组中对象的数量" };
    public static readonly string[] Selectable = {
      "Selectable",
      "Выбираемая",
      "Selezionabile",
      "Wählbar",
      "可选" };
    public static readonly string[] SelectableTip = {
      "All group objects are selected simultaneously with one click",
      "Все объекты группы выбираются одновременно одним кликом",
      "Tutti gli oggetti del gruppo vengono selezionati contemporaneamente con un clic",
      "Mit einem Klick werden alle Gruppenobjekte gleichzeitig ausgewählt",
      "一键同时选择所有组对象" };
    public static readonly string[] Anonymous = {
      "Anonymous",
      "Анонимная",
      "Anonimo",
      "Anonym",
      "匿名的" };


    // =======================================================================================================
    // Substitution Groups     
    // =======================================================================================================
    public static readonly string[] Owner = {
      "Owner",
      "Владелец",
      "Proprietario",
      "Inhaber",
      "所有者" };

    // ======================================================================================================
    // Other objects     
    // ======================================================================================================
    public static readonly string[] Mesh = {
      "Mesh",
      "Сеть",
      "Mesh",
      "Netz",
      "网格"};
    public static readonly string[] Point = {
      "Point",
      "Точка",
      "Punto",
      "Punkt",
      "点" };
    public static readonly string[] Region = {
      "Region",
      "Регион",
      "Regione",
      "Region",
      "区域" };
    public static readonly string[] Surface = {
      "Surface",
      "Поверхность",
      "Superficie",
      "Fläche",
      "表面" };
    public static readonly string[] Other = {
      "Other",
      "Прочее",
      "Altro",
      "Andere",
      "其他" };
    public static readonly string[] Height = {
      "Height",
      "Высота",
      "Altezza",
      "Höhe",
      "高度" };

    //=============================================================================================================================
    //============================================================================================================================

    public static Dictionary<string, string[]>
    PropNames = new(StringComparer.OrdinalIgnoreCase);

    public static Dictionary<string, string[]>
    PropTips = new(StringComparer.OrdinalIgnoreCase);

    static
    PropL()
    {
      Type th = typeof(PropL);
      foreach (FieldInfo fi in th.GetFields(BindingFlags.Static | BindingFlags.Public))
      {
        if (fi.FieldType == typeof(string[]))
          if (fi.Name.EndsWith("Tip")) PropTips.Add(fi.Name.Substring(0, fi.Name.Length - 3), (string[])fi.GetValue(null));
          else PropNames.Add(fi.Name, (string[])fi.GetValue(null));
      }
    }
  }
}
