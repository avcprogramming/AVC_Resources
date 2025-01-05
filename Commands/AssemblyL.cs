// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Unexplodable Ucs

namespace AVC
{
  public static class
  AssemblyL
  {
    public static readonly string[,] AsmStyleNames = {
/* 0 */ { PropL.Assembly[0], PropL.Assembly[1], PropL.Assembly[2], PropL.Assembly[3], PropL.Assembly[4] },
/* 1 */ { PropL.Assembly[0], PropL.Assembly[1], PropL.Assembly[2], PropL.Assembly[3], PropL.Assembly[4] },
/* 2 */ { "Product",
          "Изделие",
          "Product",
          "Produkt",
          "产品" },
/* 3 */ { "Renaming",
          "Переименование",
          "Ridenominazione",
          "Umbenennung",
          "重命名" },
        };
    public static readonly string[] DefNameTemplate = {
      "Asm#%row%",
      "Сб%row%",
      "Assemblaggio %row%",
      "Baugruppe %row%",
      "集会%row%"};
    public static readonly string[] DefProdTemplate = {
      "Art#%row:000%",
      "Арт.№%row:000%",
      "Art#%row:000%",
      "Art#%row:000%",
      "产品%row:000%"};
    public static readonly string[] SelectBlock = {
      "Select block",
      "Выберите блок",
      "Seleziona blocco",
      "Block auswählen",
      "选择块"};
    public static readonly string[] Creating = {
      "Creating new blocks",
      "Создание новых блоков",
      "Creazione di nuovi blocchi",
      "Neue Blöcke erstellen",
      "创建新块"};
    public static readonly string[] SelectObjects = {
      "Select objects to be assembled into a block assembly",
      "Выберите объекты для объединения в блок-сборку",
      "Seleziona gli oggetti da assemblare in un assieme di blocco",
      "Wählen Sie Objekte aus, die zu einer Blockbaugruppe zusammengefügt werden sollen",
      "选择要组装成块组件的对象"};
    public static readonly string[] PickPoint = {
      "Set the base point of the block (PickPoint)",
      "Задайте базовую точку блока (PickPoint)",
      "Imposta il punto base del blocco (PickPoint)",
      "Setzen Sie den Basispunkt des Blocks (PickPoint)",
      "设置块的基点（PickPoint)"};
    public static readonly string[] Ucs1point = {
      "Specify the first point of the X axis to rotate the block coordinate system around Z",
      "Задайте первую точку оси X для разворота системы координат блока вокруг Z",
      "Specificare il primo punto dell'asse X per ruotare il sistema di coordinate del blocco",
      "Geben Sie den ersten Punkt der X-Achse an, um das Blockkoordinatensystem zu drehen",
      "指定 X 轴的第一点旋转块坐标系"};
    public static readonly string[] Ucs2point = {
      "Specify the second X-axis point",
      "Задайте вторую точку оси X",
      "Specificare il secondo punto dell'asse X",
      "Geben Sie den zweiten X-Achsenpunkt an",
      "指定第二个X轴点"};
    public static readonly string[] ErrorPoint = {
      "Failed to build coordinate system. You have set the same points.",
      "Не удалось построить систему координат. Вы задали одинаковые точки.",
      "Impossibile creare il sistema di coordinate. Hai impostato gli stessi punti.",
      "Fehler beim Erstellen des Koordinatensystems. Sie haben die gleichen Punkte gesetzt.",
      "建立坐标系失败。 你已经设置了相同的点。"};
    public static readonly string[] ErrTemplate = {
      "The assembly name template produces the same names for different assembly numbers. Correct the template.",
      "Шаблон имени сборки выдает одинаковые имена для разных номеров сборок. Исправьте шаблон.",
      "Il modello del nome dell'assieme produce gli stessi nomi per i diversi numeri dell'assieme. Correggi il modello.",
      "Das Muster für Baugruppennamen erzeugt dieselben Namen für unterschiedliche Baugruppennummern. Korrigieren Sie die Vorlage.",
      "程序集名称模板为不同的程序集编号生成相同的名称。 更正模板。"};
    public static readonly string[] InsertErr = {
      "Failed to insert link to block {0}",
      "Не удалось вставить ссылку на блок {0}",
        "Impossibile inserire il collegamento per bloccare {0}",
        "Link zum Block {0} konnte nicht eingefügt werden",
        "无法插入阻止 {0} 的链接" };

    // ================================ Dialog Box ================================================================

    public static readonly string[] StyleNameTip = {
      "The name for this style (set of settings). Not used in the program. Only for convenience of choice.",
      "Просто название для этого набора настроек. Нигде не используется.",
      "Il nome di questo stile (insieme di impostazioni). \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Stil (Satz von Einstellungen). \r\n" +
        "Wird im Programm nicht verwendet. Nur zur Bequemlichkeit der Wahl.",
      "此样式（设置集）的名称。 没有在程序中使用。 只为方便选择。" };
    public static readonly string[] NameTemplateText = {
      "Name template",
      "Шаблон имени",
      "Modello di nome",
      "Namensvorlage",
      "名称模板" };
    public static readonly string[] NameTemplateTip = {
      "Assembly name pattern. The template must contain the %row% substitution. \r\n" +
        "The new assembly number will be inserted at this location.\r\n" +
        "The program uses the drawing property Number_of_assemblies and adds 1.\r\n" +
        "If the name is already taken, the program will increment the number until it finds a free name.\r\n" +
        "The substitution can be formatted as a Roman numeral or as an alphabetical letter.",
      "Шаблон имени сборки.\r\n" +
        "В шаблоне обязательно должна быть подстановка %row%. В это место будет вставлен номер новой сборки.\r\n" +
        "Программа использует свойство чертежа Number_of_assemblies и добавляет к нему 1.\r\n" +
        "Если имя уже занято, то программа будет увеличивать номер, пока не найдет свободное имя.\r\n" +
        "Подстановку можно форматировать как римскую цифру или как букву по алфавиту.",
      "Modello del nome dell'assieme. \r\n" +
        "Il modello deve contenere la sostituzione %row%.\r\n" +
        "Il nuovo numero di build verrà inserito in questa posizione.\r\n" +
        "Il programma utilizza la proprietà di disegno Number_of_assemblies e aggiunge 1.\r\n" +
        "Se il nome è già stato preso, il programma incrementerà il numero finché non trova un nome libero.\r\n" +
        "La sostituzione può essere formattata come numero romano o come lettera alfabetica.",
      "Assembly-Namensmuster. Die Vorlage muss die Ersetzung %row% enthalten. "+
         "Die neue Baugruppennummer wird an dieser Stelle eingefügt.\r\n" +
         "Das Programm verwendet die Zeichnungseigenschaft Number_of_assemblies und addiert 1.\r\n" +
         "Wenn der Name bereits vergeben ist, erhöht das Programm die Nummer, bis es einen freien Namen findet.\r\n" +
         "Die Substitution kann als römische Ziffer oder als alphabetischer Buchstabe formatiert werden.",
      "程序集名称模式。 模板必须包含 %row% 替换。 \r\n" +
         "新的装配编号将插入此位置。\r\n" +
         "程序使用绘图属性 Number_of_assemblies 并加 1。\r\n" +
         "如果这个名字已经被占用，程序会增加这个数字，直到找到一个空闲的名字。\r\n" +
         "替换可以格式化为罗马数字或字母。" };
    public static readonly string[] TemplateErr = {
      "Template must contain %row% substitution",
      "Шаблон должен содержать подстановку %row%",
      "Il modello deve contenere %row% sostituzione",
      "Vorlage muss %row%-Ersetzung enthalten",
      "模板必须包含 %row% 替换"};
    public static readonly string[] KeepBlockNumber = {
      "Keep block number",
      "Сохранять номер блока",
      "Numero di blocco del negozio",
      "Blocknummer speichern",
      "存储块号" };
    public static readonly string[] KeepBlockNumberTip = {
      "Save the number assigned to the block-assembly for numbering the next assembly. \r\n" +
        "The number is stored in the custom drawing properties. \r\n" +
        "If the option is disabled, then the program will always look for unused numbers starting from 1",
      "Сохранять назначенный блоку-сборке номер для нумерации следующей сборки. \r\n" +
        "Номер хранится в пользовательских свойствах чертежа. \r\n" +
        "Если опция отключена, то программа всегда будет искать неиспользованных номер начиная с 1",
      "Salvare il numero assegnato all'assieme del blocco per la numerazione dell'assieme successivo. \r\n" +
        "Il numero viene memorizzato nelle proprietà del disegno personalizzato. \r\n" +
        "Se l'opzione è disabilitata, il programma cercherà sempre i numeri inutilizzati a partire da 1",
      "Speichern Sie die der Blockbaugruppe zugewiesene Nummer, um die nächste Baugruppe zu nummerieren. \r\n" +
        "Die Nummer wird in den benutzerdefinierten Zeichnungseigenschaften gespeichert. \r\n" +
        "Wenn die Option deaktiviert ist, sucht das Programm immer nach unbenutzten Nummern beginnend bei 1",
      "保存分配给块组件的编号，以便为下一个组件编号。\r\n" +
        "该编号存储在自定义绘图属性中。 \r\n" +
        "如果禁用该选项，则程序将始终从 1 开始查找未使用的数字" };
    public static readonly string[] NumberOfAssemblies = {
      "Next number",
      "Следующий номер",
      "Numero successivo",
      "Nächste Nummer",
      "下一个号码" };
    public static readonly string[] NumberOfAssembliesTip = {
      "Substitute this number in the block name instead of substituting %row%. \r\n" +
        "This number is stored in the drawing properties and is not associated with a settings style.",
      "Подставлять в имя блока этот номер вместо подстановки %row%. \r\n" +
        "Этот номер сохраняется в свойствах чертежа и не связан со стилем настроек.",
      "Sostituisci questo numero nel nome del blocco invece di sostituire %row%. \r\n" +
        "Questo numero è memorizzato nelle proprietà del disegno e non è associato a uno stile di impostazioni.",
      "Ersetzen Sie diese Zahl im Blocknamen anstelle von %row%. \r\n" +
        "Diese Nummer wird in den Zeichnungseigenschaften gespeichert und ist keinem Einstellungsstil zugeordnet.",
      "在块名称中替换此数字而不是替换 %row%。 \r\n" +
        "此编号存储在图纸属性中，与设置样式无关。" };
    public static readonly string[] MinGrip = {
      "On the bottom grip",
      "На нижней ручке",
      "Su una presa inferiore",
      "Auf einem unteren Griff",
      "在较低的抓地力"};
    public static readonly string[] MinGripTip = {
      "Select base point automatically on the bottom left 'grip' of all block objects.",
      "Подбирать базовую точку автоматически на самой нижней левой 'ручке' всех объектов блока.",
      "Seleziona automaticamente il punto base sulla 'presa' in basso a sinistra di tutti gli oggetti di blocco.",
      "Wählen Sie den Basispunkt automatisch am unteren linken 'Griff' aller Blockobjekte.",
      "在所有块对象的左下角“夹点”上自动选择基点。"};
    public static readonly string[] Center = {
      "In the center",
      "В центре",
      "Al centro",
      "Im Zentrum",
      "在中心"};
    public static readonly string[] CenterTip = {
      "Select the base point automatically in the geometric center of the new block. \r\n" +
        "There may not be a single object at this point",
      "Подбирать базовую точку автоматически в геометрическом центре нового блока. \r\n" +
        "В этой точке может и не быть ни одного объекта",
      "Selezionare automaticamente il punto base nel centro geometrico del nuovo blocco. \r\n" +
        "Potrebbe non esserci un singolo oggetto a questo punto",
      "Wählen Sie den Basispunkt automatisch in der geometrischen Mitte des neuen Blocks aus. \r\n" +
        "Zu diesem Zeitpunkt befindet sich möglicherweise kein einziges Objekt",
      "自动在新块的几何中心选择基点。 此时可能没有单个对象"};
    public static readonly string[] BottomCenter = {
      "In the center of the bottom",
      "В центре дна",
      "Al centro del fondo",
      "In der Mitte des Bodens",
      "在底部的中央"};
    public static readonly string[] BottomCenterTip = {
      "Select a base point automatically in the geometric center of the new block \r\n" +
        "and project this point to the very bottom of the block dimensions. \r\n" +
        "There may not be a single object at this point.",
      "Подбирать базовую точку автоматически в геометрическом центре нового блока \r\n" +
        "и спроецировать эту точку в самый низ габаритов блока. \r\n" +
        "В этой точке может и не быть ни одного объекта.",
      "Selezionare automaticamente un punto base nel centro geometrico del nuovo blocco \r\n" +
        "e proiettare questo punto fino al fondo delle dimensioni del blocco. \r\n" +
        "Potrebbe non esserci un singolo oggetto a questo punto.",
      "Wählen Sie automatisch einen Basispunkt in der geometrischen Mitte des neuen Blocks \r\n" +
        "und projizieren Sie diesen Punkt ganz unten in die Blockabmessungen. \r\n" +
        "Zu diesem Zeitpunkt befindet sich möglicherweise kein einziges Objekt.",
      "在新块的几何中心自动选择一个基点，并将该点投影到块尺寸的最底部。 此时可能没有一个对象。"};
    public static readonly string[] BasePointQueryText = {
      "Base point query",
      "Запрос базовой точки",
      "Query punto base",
      "Basispunktabfrage",
      "基点查询" };
    public static readonly string[] BasePointQueryTip = {
      "The program will ask you to specify the base point of the block.\r\n" +
        "The zero of the block coordinate system will be moved to this point.\r\n"+
        "This point will become the grip of the block when inserted.",
      "Программа запросит указать базовую точку блока.\r\n" +
        "В эту точку будет перемещен ноль системы координат блока.\r\n" +
        "Эта точка станет ручкой блока при вставке.",
      "Il programma ti chiederà di specificare il punto base del blocco.\r\n" +
        "Lo zero del sistema di coordinate del blocco verrà spostato su questo punto.\r\n" +
        "Questo punto diventerà la maniglia del blocco una volta inserito.",
      "Das Programm fordert Sie auf, den Basispunkt des Blocks anzugeben.\r\n" +
        "Der Nullpunkt des Blockkoordinatensystems wird an diesen Punkt verschoben.",
      "该程序将要求您指定块的基点。\r\n" +
         "方块坐标系的零点将移动到该点。" };
    public static readonly string[] UcsOrigin = {
      "UCS origin",
      "Начало координат ПСК",
      "Origine dell'UCS",
      "UCS-Ursprung",
      "UCS起源"};
    public static readonly string[] UcsOriginTip = {
      "Assign the base point of the block to the origin point (zero) of the current user coordinate system.",
      "Назначить базовой точкой блока ноль текущей пользовательской системы координат.",
      "Assegnare il punto base del blocco al punto di origine (zero) del sistema di coordinate utente corrente.",
      "Weisen Sie den Basispunkt des Blocks dem Ursprungspunkt (Null) des aktuellen Benutzerkoordinatensystems zu.",
      "将块的基点分配给当前用户坐标系的原点（零）。"};
    public static readonly string[] WcsOrigin = {
      "WCS origin",
      "Начало координат МСК",
      "Origine dell'WCS",
      "WCS-Ursprung",
      "WCS起源"};
    public static readonly string[] WcsOriginTip = {
      "Assign the base point of the block to the zero of the world coordinate system. " +
        "That is, do not move the base point anywhere at all.",
      "Назначить базовой точкой блока ноль мировой системы координат. " +
        "То есть вообще никуда не двигать базовую точку.",
      "Assegnare il punto base del blocco allo zero del sistema di coordinate globali. " +
        "Cioè, non spostare affatto il punto base da nessuna parte.",
      "Ordnen Sie den Basispunkt des Blocks dem Nullpunkt des Weltkoordinatensystems zu. " +
        "Das heißt, den Basispunkt überhaupt nicht verschieben.",
      "将块的基点分配给世界坐标系的零点。 也就是说，根本不要将基点移动到任何地方。"};
    public static readonly string[] MaxFaceTip = {
      "Rotate the block around the Z-axis so that the largest flat surface is rotated in the opposite direction of the Y-axis.\r\n" +
        "For flat blocks, the longest line will be found and expanded along X.\r\n" +
        "It is not recommended to use the option in complex assemblies, \r\n" +
        "since it will take a long time to sort through all the faces of all solids.",
      "Вращать блок вокруг оси Z, так чтоб наибольшая плоская поверхность была развернута в направлении обратном оси Y.\r\n" +
        "Для плоских блоков будет найдена самая длинная линия и она будет развернута вдоль X.\r\n" +
        "Не рекомендуется использовать опцию в сложных сборках, так как потребуется долго перебирать все грани всех солидов.",
      "Ruota il blocco attorno all'asse Z \r\n" +
        "in modo che la superficie piana più grande venga ruotata nella direzione opposta all'asse Y.\r\n" +
        "Per i blocchi piatti, la linea più lunga verrà trovata ed espansa lungo X.\r\n" +
        "Non è consigliabile utilizzare l'opzione in assiemi complessi, \r\n" +
        "poiché richiederà molto tempo per selezionare tutte le facce di tutti i solidi.",
      "Drehen Sie den Block um die Z-Achse, sodass die größte flache Oberfläche \r\n" +
        "in die entgegengesetzte Richtung der Y-Achse gedreht wird.\r\n" +
         "Bei flachen Blöcken wird die längste Linie gefunden und entlang X erweitert.\r\n" +
         "Es wird nicht empfohlen, die Option in komplexen Baugruppen zu verwenden, \r\n" +
        "da es lange dauert, alle Flächen aller Volumenkörper zu durchlaufen." ,
      "围绕 Z 轴旋转块，使最大平面沿 Y 轴的相反方向旋转。\r\n" +
         "对于平面块，将找到最长的线并沿 X 展开。\r\n" +
         "不建议在复杂的装配体中使用该选项，因为遍历所有实体的所有面需要很长时间。"};
    public static readonly string[] XAxisQueryText = {
      "X-axis query",
      "Запрос оси X",
      "Query sull'asse X",
      "Abfrage der X-Achse",
      "X轴查询" };
    public static readonly string[] XAxisQueryTip = {
      "The program will ask for the X-axis direction for the block's internal coordinate system (BCS).\r\n" +
        "The Z axis will be taken from the world coordinate system WCS.\r\n" +
        "The coordinate system determines how the block will be rotated upon insertion.",
      "Программа запросит направление оси X для внутренней системы координат блока.\r\n" +
        "Ось Z будет взята из мировой системы координат WCS.\r\n" +
        "От системы координат зависит, как будет развернут блок при вставке.",
      "Il programma chiederà la direzione dell'asse X per il sistema di coordinate interno del blocco. \r\n" +
        "L'asse Z sarà preso dal sistema di coordinate mondiali WCS. \r\n" +
        "Il sistema di coordinate determina come verrà ruotato il blocco una volta inserito.",
      "Das Programm fragt nach der Richtung der X-Achse für das interne Koordinatensystem (BCS) des Blocks.\r\n" +
         "Die Z-Achse wird aus dem Weltkoordinatensystem WCS genommen.\r\n" +
         "Das Koordinatensystem bestimmt, wie der Block beim Einfügen gedreht wird.",
      "该程序将要求块的内部坐标系 (BCS) 的 X 轴方向。\r\n" +
         "Z 轴将取自世界坐标系 WCS。\r\n" +
         "坐标系决定了块在插入时如何旋转。" };
    public static readonly string[] Ucs = {
      "By current UCS",
      "По текущей ПСК",
      "In base all'attuale UCS",
      "Nach aktuellem UCS",
      "按当前 UCS"};
    public static readonly string[] UcsTip = {
      "Leave the block's coordinate system as the current user coordinate system (UCS).",
      "Оставить систему координат блока такой, как текущая пользовательская система координат (UCS).",
      "Lasciare il sistema di coordinate del blocco come sistema di coordinate dell'utente corrente (UCS).",
      "Belassen Sie das Koordinatensystem des Blocks als aktuelles Benutzerkoordinatensystem (BKS).",
      "将块的坐标系保留为当前用户坐标系 (UCS)。"};
    public static readonly string[] Wcs = {
      "Use WCS (do not rotate)",
      "Использовать МСК (не вращать)",
      "Usa WCS (non ruotare)",
      "WCS verwenden (nicht drehen)",
      "使用WCS（不旋转）"};
    public static readonly string[] WcsTip = {
      "Leave the block coordinate system as is, without rotations, \r\n" +
        "as it is in the world coordinate system (WCS).",
      "Оставить систему координат блока как есть, без вращений, \r\n" +
        "как есть в мировой системе координат (WCS).",
      "Lasciare il sistema di coordinate del blocco così com'è, senza rotazioni, \r\n" +
        "come nel sistema di coordinate globali (WCS).",
      "Belassen Sie das Blockkoordinatensystem unverändert, ohne Drehungen, \r\n" +
        "wie es im Weltkoordinatensystem (WCS) ist.",
      "保持块坐标系不变，不进行旋转，就像在世界坐标系 (WCS) 中一样。"};
    public static readonly string[] Invisible = {
      "Save invisible objects",
      "Сохранить невидимые объекты",
      "Salva oggetti invisibili",
      "Speichern Sie unsichtbare Objekte",
      "保存不可见的物体" };
    public static readonly string[] InvisibleTip = {
      "If there were invisible objects in the old block (disabled by the visibility parameter), then save them to the new block.",
      "Если в старом блоке были невидимые объекты (отключенные параметром видимости), то сохранить их в новый блок.",
      "Se nel vecchio blocco erano presenti oggetti invisibili (disabilitati dal parametro visibilità), salvali nel nuovo blocco.",
      "Wenn im alten Block unsichtbare Objekte vorhanden waren (durch den Sichtbarkeitsparameter deaktiviert), \r\n" +
        "speichern Sie sie im neuen Block.",
      "如果旧块中有不可见的对象（被可见性参数禁用），则将它们保存到新块中。" };
    public static readonly string[] LabelOnFront = {
      "Label on Front",
      "Метка на фасаде",
      "Etichetta sul lato anteriore",
      "Etikett auf der Vorderseite",
      "正面标签"};
    public static readonly string[] LabelOnFrontTip = {
      "Create text inside the block with the name of the block. \r\n" +
        "Place this text in front of the block in the XZ plane of the block's coordinate system.",
      "Создать внутри блока текст с именем блока. \r\n" +
        "Разместить этот текст перед блоком в плоскости XZ системы координат блока.",
      "Crea un testo all'interno del blocco con il nome del blocco. \r\n" +
        "Posiziona questo testo davanti al blocco nel piano XZ del sistema di coordinate del blocco.",
      "Erstellen Sie Text innerhalb des Blocks mit dem Namen des Blocks. \r\n" +
        "Platzieren Sie diesen Text vor dem Block in der XZ-Ebene des Koordinatensystems des Blocks.",
      "使用块的名称在块内创建文本。 \r\n" +
        "将此文本放置在块坐标系 XZ 平面中的块前面。"};
    public static readonly string[] LabelOnTop = {
      "Label on Top",
      "Метка сверху",
      "Etichetta in alto",
      "Etikett oben",
      "顶部标签"};
    public static readonly string[] LabelOnTopTip = {
      "Create text inside the block with the name of the block. \r\n" +
        "Position this text above the block in the XY plane of the block's coordinate system.",
      "Создать внутри блока текст с именем блока. \r\n" +
        "Разместить этот текст над блоком в плоскости XY системы координат блока.",
      "Crea un testo all'interno del blocco con il nome del blocco. \r\n" +
        "Posiziona questo testo sopra il blocco nel piano XY del sistema di coordinate del blocco.",
      "Erstellen Sie Text innerhalb des Blocks mit dem Namen des Blocks. \r\n" +
        "Positionieren Sie diesen Text über dem Block in der XY-Ebene des Koordinatensystems des Blocks.",
      "使用块的名称在块内创建文本。 \r\n" +
        "在块坐标系的 XY 平面中将此文本定位在块上方。"};
    public static readonly string[] LabelTurnOver = {
      "Flip front mark",
      "Перевернуть фасадную метку",
      "Capovolgi il segno anteriore",
      "Vordere Markierung umdrehen",
      "翻盖正面标记"};
    public static readonly string[] LabelTurnOverTip = {
      "Place the front mark on the back side upside down.\r\n" +
        "An option has been made to convert dynamic wall blocks modeled in a lying position.",
      "Разместить переднюю метку на задней стороне вверх ногами. \r\n" +
        "Опция сделана для преобразования динамических блоков стен, смоделированных в лежачем положении.",
      "Posiziona il segno anteriore sul lato posteriore capovolto. \r\n" +
        "È stata fatta un'opzione per convertire i blocchi murali dinamici modellati in posizione sdraiata.",
      "Platzieren Sie die vordere Markierung verkehrt herum auf der Rückseite. \r\n" +
        "Es besteht die Möglichkeit, dynamische Wandblöcke, die in liegender Position modelliert wurden, umzuwandeln.",
      "将正面标记倒置在背面。\r\n" +
        "可以选择转换以平躺位置建模的动态墙块。"};
    public static readonly string[] LabelField = {
      "Use Field for block name",
      "Поле для имени блока",
      "Usa Campo per il nome del blocco",
      "Feld für den Blocknamen",
      "使用“字段”作为块名称"};
    public static readonly string[] LabelFieldTip = {
      "Use an auto-updating 'field' to retrieve the block name. \r\n" +
        "If the option is disabled, then the labels will contain plain text and it will not change when the block is renamed.",
      "Использовать автообновляемое 'поле' для извлечения имени блока. \r\n" +
        "Если опция выключена, то метки будут содержать обычный текст и он не изменится при переименовании блока.",
      "Utilizza un 'campo' aggiornato automaticamente per recuperare il nome del blocco. \r\n" +
        "Se l'opzione è disabilitata, le etichette conterranno testo normale e non cambieranno quando il blocco viene rinominato.",
      "Verwenden Sie ein automatisch aktualisiertes „Feld“, um den Blocknamen abzurufen. \r\n" +
        "Wenn die Option deaktiviert ist, enthalten die Beschriftungen Klartext und ändern sich nicht, wenn der Block umbenannt wird.",
      "使用自动更新的“字段”来检索块名称。 \r\n" +
        "如果禁用该选项，则标签将包含纯文本，并且在重命名块时不会更改。"};
    public static readonly string[] LabelStyleTip = {
      "Text style for block labels. Enter an empty string to use the current text style.",
      "Стиль текста для меток блока. Введите пустую строку, чтоб использовать текущий стиль текста.",
      "Stile di testo per le etichette dei blocchi. Immettere una stringa vuota per utilizzare lo stile di testo corrente.",
      "Textstil für Blockbeschriftungen. Geben Sie eine leere Zeichenfolge ein, um den aktuellen Textstil zu verwenden.",
      "块标签的文本样式。 输入一个空字符串以使用当前文本样式。"};
    public static readonly string[] LabelHeightTip = {
      "The text height for block labels. \r\n" +
        "Enter 0 so that the program itself picks up the height of the text, focusing on the size of the block",
      "Высота текста для меток блока. Введите 0, \r\n" +
        "чтоб программа сама подобрала высоту текста, ориентируясь на размер блока.",
      "L'altezza del testo per le etichette dei blocchi. \r\n" +
        "Immettere 0 in modo che il programma stesso rilevi l'altezza del testo, concentrandosi sulla dimensione del blocco",
      "Die Texthöhe für Blockbeschriftungen. \r\n" +
        "Geben Sie 0 ein, damit das Programm selbst die Höhe des Textes übernimmt und sich auf die Größe des Blocks konzentriert",
      "块标签的文本高度。 输入0让程序自己拾取文字的高度，重点是块的大小"};
    public static readonly string[] BlockMetricTip = {
      "Call the 'Block Metric' command to measure the dimensions, \r\n" +
        "weight and price of the block and create invisible attributes.",
      "Вызвать команду 'Метрика Блока' для обмера габаритов, \r\n" +
        "веса и цены блока и создания невидимых атрибутов.",
      "Chiama il comando 'Block Metric' per misurare le dimensioni, \r\n" +
        "il peso e il prezzo del blocco e creare attributi invisibili.",
      "Rufen Sie den Befehl „Block Metric“ auf, um die Abmessungen, \r\n" +
        "das Gewicht und den Preis des Blocks zu messen und unsichtbare Attribute zu erstellen.",
      "调用“块度量”(BlockMetric)命令来测量块的尺寸、重量和价格，\r\n" +
        "并创建不可见的属性。"};
    public static readonly string[] ExplodeText = {
      "Explode all blocks",
      "Взорвать все блоки",
      "Esplodi tutti i blocchi",
      "Explodieren Sie alle Blöcke",
      "炸开所有方块" };
    public static readonly string[] ExplodeTip = {
      "If you plan to combine other blocks or arrays into an assembly, \r\n" +
        "the program can explode them all, including nested blocks.",
      "Если вы планируете объединить в сборку другие блоки или массивы,\r\n" +
        "то программа может взорвать их всех, включая вложенные блоки.",
      "Se prevedi di combinare altri blocchi o array in un assieme, \r\n" +
        "il programma può esploderli tutti, inclusi i blocchi nidificati.",
      "Wenn Sie andere Blöcke oder Arrays zu einer Baugruppe kombinieren möchten, \r\n" +
        "kann das Programm sie alle auflösen, einschließlich verschachtelter Blöcke.",
      "如果您计划将其他块或数组组合成一个程序集，\r\n" +
        "程序可以将它们全部分解，包括嵌套块。" };
    public static readonly string[] MeshToSolid = {
      "Convert mesh to solid",
      "Конвертировать сети в солиды",
      "Converti la mesh in solido",
      "Netz in Volumen umwandeln",
      "将网格转换为实体" };
    public static readonly string[] MeshToSolidTip = {
      "Call the MeshToSolid command to attempt to convert any meshes, 3D-faces, and pseudo-3D curves into 3D solids.",
      "Вызвать команду MeshToSolid, чтоб попытаться конвертировать любые сети, \r\n" +
        "3D-грани и псевдотрехмерные кривые в 3D-солиды.",
      "Chiamare il comando MeshToSolid per tentare di convertire qualsiasi mesh, faccia 3D e curve pseudo-3D in solidi 3D.",
      "Rufen Sie den Befehl „MeshToSolid“ auf, um zu versuchen, alle Netze, \r\n" +
        "3D-Flächen und Pseudo-3D-Kurven in 3D-Volumenkörper umzuwandeln.",
      "调用 MeshToSolid 命令尝试将任何网格、3D 面和伪 3D 曲线转换为 3D 实体。" };
    public static readonly string[] Layer0Text = {
      "Assign '0' layer",
      "Назначить слой '0'",
      "Assegna il layer '0'",
      "Ebene '0' zuweisen",
      "分配图层“0”" };
    public static readonly string[] Layer0Tip = {
      "The program can assign 0 (zero) layer to all objects.\r\n" +
        "0 layer is used inside blocks to inherit layer properties from a block reference.\r\n" +
        "That is, instead of the 'ByBlock' layer.\r\n" +
        "After that, you can change the color of the objects by changing the layer of the link to the block.\r\n" +
        "This does not change the layer Holes and Info.",
      "Программа может назначить всем объектам слой 0 (ноль).\r\n" +
        "Слой 0 используется внутри блоков для наследования свойств слоя от ссылки на блок (BlockReference).\r\n" +
        "То есть вместо слоя ПоБлоку (ByBlock).\r\n" +
        "Вы сможете менять цвет объектов просто меняя слой ссылки на блок.\r\n" +
        "При этом не меняется слой Отверстия и Инфо.",
      "Il programma può assegnare il layer 0 (zero) a tutti gli oggetti. \r\n" +
        "Il layer 0 viene utilizzato all'interno dei blocchi per ereditare le proprietà \r\n" +
        "del layer da un riferimento di blocco (BlockReference). Cioè, invece del layer DaBlocco.\r\n" +
        "Successivamente, puoi cambiare il colore degli oggetti cambiando il layer del collegamento al blocco.\r\n" +
        "Ciò non modifica il livello Fori e informazioni.",
      "Das Programm kann allen Objekten die Ebene 0 (Null) zuweisen.\r\n" +
         "0-Ebene wird innerhalb von Blöcken verwendet, um Ebeneneigenschaften von einer Blockreferenz zu erben.\r\n" +
         "Das heißt, anstelle der 'ByBlock'-Ebene.\r\n" +
         "Danach können Sie die Farbe der Objekte ändern, indem Sie die Ebene der Verknüpfung zum Block ändern.\r\n" +
        "Die Ebene Holes and Info ändert sich dadurch nicht.",
      "该程序可以为所有对象分配 0（零）层。\r\n" +
         "0 层用于块内部以从块参考继承层属性。\r\n" +
         "也就是说，而不是‘ByBlock’层。\r\n" +
         "之后，您可以通过更改链接到块的图层来更改对象的颜色。\r\n" +
        "这不会改变图层 Holes 和 Info。" };
    public static readonly string[] UniteText = {
      "Unite solids",
      "Склеить солиды",
      "Unisci i solidi",
      "Feststoffe vereinen",
      "合并实体" };
    public static readonly string[] UniteTip = {
      "The program can combine all the solid inside the block into one big solid.\r\n" +
        "This will drastically simplify the block geometry \r\n" +
        "and greatly improve the performance when displaying many blocks.\r\n" +
        "However, you will lose the ability to extract parts \r\n" +
        "and correctly calculate the amount of materials, weight and price\r\n" +
        "of an assembly consisting of different parts from different materials.",
      "Программа может объединить все солиды внутри блока в один большой солид.\r\n" +
        "Это резко упростит геометрию блока \r\n" +
        "и значительно повысит производительность при отображении многих блоков.\r\n" +
        "Однако вы потеряете возможность извлекать детали \r\n" +
        "и правильно подсчитать количество материалов,\r\n" +
        "вес и цену сборки, состоящей из разных деталей из разных материалов. ",
      "Il programma può combinare tutti i solidi all'interno del blocco in un unico grande solido. \r\n" +
        "Ciò semplificherà drasticamente la geometria del blocco e migliorerà notevolmente le prestazioni\r\n" +
        "durante la visualizzazione di molti blocchi.\r\n" +
        "Tuttavia, perderai la capacità di estrarre parti e calcolare correttamente la quantità di materiali,\r\n" +
        "peso e prezzo di un assieme composto da parti diverse di materiali diversi.",
      "Das Programm kann alle Körper innerhalb des Blocks zu einem großen Körper kombinieren.\r\n" +
         "Dies wird die Blockgeometrie drastisch vereinfachen \r\n" +
        "und die Leistung beim Anzeigen vieler Blöcke erheblich verbessern.\r\n" +
         "Sie verlieren jedoch die Fähigkeit, Teile zu extrahieren \r\n" +
        "und die Materialmenge, das Gewicht und den Preis korrekt zu berechnen\r\n" +
         "einer Baugruppe, die aus verschiedenen Teilen aus unterschiedlichen Materialien besteht.",
      "该程序可以将块内的所有实体组合成一个大实体。\r\n" +
         "这将大大简化块的几何形状，并在显示许多块时大大提高性能。\r\n" +
         "但是，你将失去提取零件和正确计算材料数量、重量和价格的能力\r\n" +
         "由不同材料制成的不同零件组成的组件。" };
    public static readonly string[] Unexplodable = {
      "Forbid explode the block",
      "Запретить взрывать блок",
      "Vieta esplodere il blocco",
      "Verbiete den Block zu explodieren",
      "禁止爆炸方块" };
    public static readonly string[] UnexplodableTip = {
      "Mark block as unexploded. \r\n" +
        "A>V>C> plugins consider exploded blocks as assemblies, and non-explosive - as ready-made purchased items.",
      "Пометить блок как невзрываемый. \r\n" +
        "Плагины A>V>C> рассматривают взрываемые блоки как сборки, а невзрываемые - как готовые покупные изделия.",
      "Contrassegnare il blocco come non esplosivo. \r\n" +
        "I plugin A>V>C> trattano i blocchi esplosi come assiemi e quelli non esplosivi come oggetti acquistati già pronti.",
      "Block als nicht explodiert markieren. \r\n" +
        "A>V>C>-Plugins behandeln explodierte Blöcke als Baugruppen und nicht explodierbare als fertige gekaufte Artikel.",
      "将方块标记为未爆炸。 \r\n" +
        "A>V>C> 插件将爆炸块视为组件，将非爆炸块视为现成的购买物品。" };


  }
}
