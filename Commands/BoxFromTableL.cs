// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  BoxFromTableL
  {
    public static readonly string[,] BoxFromTableNames = {
/* 0 */ { CommandL.BoxFromTable[0], CommandL.BoxFromTable[1], CommandL.BoxFromTable[2], CommandL.BoxFromTable[3], CommandL.BoxFromTable[4] },
/* 1 */ { CommandL.BoxFromTable[0], CommandL.BoxFromTable[1], CommandL.BoxFromTable[2], CommandL.BoxFromTable[3], CommandL.BoxFromTable[4] },
        };

    public static readonly string[] BoxToWallProgress = {
      "Detailing",
      "Деталировка",
      "Dettagli",
      "Detaillierung",
      "細節處理"};
    public static readonly string[] RequestForBox = {
      "Request parts for the wall {0} from the web server...",
      "Запрашиваем на web-сервере деталировку для стены {0}...",
      "Richiedi parti per il muro {0} dal server web...",
      "Teile für die Wand {0} vom Webserver anfordern...",
      "从网络服务器请求墙体 {0} 的部件..."};
    public static readonly string[] RequestForVector = {
      "Request flat drawings for wall {0} from the web server...",
      "Запрашиваем на web-сервере плоские чертежи для стены {0}...",
      "Richiedi disegni piatti per il muro {0} dal server web...",
      "Fordern Sie vom Webserver Grundrisse für die Wand {0} an...",
      "从 Web 服务器请求墙壁 {0} 的平面图..."};
    public static readonly string[] RequestError = {
      "Error when requesting to the server.\r\n{0}",
      "Ошибка при запросе на сервер.\r\n{0}",
      "Errore durante la richiesta al server.\r\n{0}",
      "Fehler bei der Anfrage an den Server.\r\n{0}",
      "向伺服器請求時發生錯誤。\r\n{0}"};
    public static readonly string[] ZeroBoxDataError = {
      "Received empty parts list for wall {0}",
      "Получен пустой список деталей для стены {0}",
      "Ricevuto elenco delle parti vuoto per il muro {0}",
      "Leere Teileliste für Wand {0} erhalten",
      "收到牆 {0} 的空零件清單"};
    public static readonly string[] BoxDataReceived = {
      "Data received from the server to create {0} parts for wall {1}",
      "С сервера получены данные для создания {0} деталей для стены {1}",
      "Dati ricevuti dal server per creare {0} parti per il muro {1}",
      "Vom Server empfangene Daten zum Erstellen von {0} Teilen für die Wand {1}",
      "從伺服器接收的數據，用於為牆 {1} 建立 {0} 個部件"};
    public static readonly string[] PlanDataReceived = {
      "Data was received from the server to create the drawing {0}",
      "С сервера получены данные для создания чертежа {0}",
      "I dati sono stati ricevuti dal server per creare il disegno {0}",
      "Vom Server wurden Daten zum Erstellen der Zeichnung {0} empfangen.",
      "已從伺服器接收資料以建立繪圖 {0}"};
    public static readonly string[] ZeroSolidListError = {
      "Failed to create one wall {0} - failed to create any parts",
      "Не удалось создать одну стену {0} - не получилось создать ни одной детали",
      "Impossibile creare un muro {0} - impossibile creare nessuna parte",
      "Eine Wand {0} konnte nicht erstellt werden – es konnten keine Teile erstellt werden",
      "無法建立一堵牆 {0} - 無法建立任何部分"};
    public static readonly string[] ZeroPlanError = {
      "Failed to create drawing {0} - failed to create any objects",
      "Не удалось создать чертеж {0} - не получилось создать ни одного объекта",
      "Impossibile creare il disegno {0}: impossibile creare alcun oggetto",
      "Zeichnung {0} konnte nicht erstellt werden – es konnten keine Objekte erstellt werden",
      "未能建立繪圖 {0} - 未能建立任何對象"};
    public static readonly string[] BoxToWallResult = {
      "Managed to create walls {0}",
      "Удалось создать стен {0}",
      "Gestito per creare muri {0}",
      "Es ist mir gelungen, Wände zu erstellen {0}",
      "成功建造了牆壁{0}"};
    public static readonly string[] BoxToVectorResult = {
      "Successful creation of {0} drawings",
      "Удалось создать чертежей {0}",
      "Creazione riuscita di {0} disegni",
      "Erfolgreiche Erstellung von {0} Zeichnungen",
      "成功建立 {0} 個繪圖"};
    public static readonly string[] BoxtToVectorProgress = {
      "Creating Drawings",
      "Создание чертежей",
      "Creazione di disegni",
      "Zeichnungen erstellen",
      "建立繪圖"};
    public static readonly string[] SelectSolidOrBlock = {
      "Choose solid boxes to fit the wall or blocks of ready-made walls.",
      "Выберите солиды-боксы в габарит стены или блоки готовых стен.",
      "Scegli scatole solide da adattare al muro o blocchi di pareti già pronte.",
      "Wählen Sie feste, an die Wand angepasste Kästen oder Blöcke vorgefertigter Wände.",
      "選擇適合牆壁的實心盒子或現成的牆壁塊。"};
    public static readonly string[] LineWeightErr = {
      "Specified non-existent line weight {0}",
      "Задан несуществующий вес линий {0}",
      "Spessore di linea inesistente specificato {0}",
      "Angegebene nicht vorhandene Linienstärke {0}",
      "指定的不存在的線寬 {0}"};
    public static readonly string[] LineTypeErr = {
      "Specified non-existent linetype {0}",
      "Задан несуществующий тип линий {0}",
      "Tipo di linea {0} inesistente specificato",
      "Angegebener nicht vorhandener Linientyp {0}",
      "指定的不存在線型 {0}"};
    public static readonly string[] ColorErr = {
      "Failed to recognize color {0}",
      "Не удалось распознать цвет {0}",
      "Impossibile riconoscere il colore {0}",
      "Farbe {0} konnte nicht erkannt werden",
      "無法辨識顏色{0}"};
    public static readonly string[] PLineConversionErr = {
      "It was not possible to construct a polyline from the given points",
      "Не удалось построить полилинию по заданным точкам",
      "Non è stato possibile costruire una polilinea utilizzando i punti indicati",
      "Es war nicht möglich, aus den angegebenen Punkten eine Polylinie zu konstruieren",
      "無法從給定點構造折線"};
    public static readonly string[] NullPlanError = {
      "Received empty wall plan {0}",
      "Получен пустой план стены {0}",
      "Ricevuta una planimetria vuota {0}",
      "Leeren Wandplan {0} erhalten",
      "收到空牆平面圖 {0}"};
    public static readonly string[] RequestTime = {
      "The request to the server was processed in {0}s",
      "Запрос к серверу обработан за {0}c",
      "La richiesta al server è stata elaborata in {0}s",
      "Die Anfrage an den Server wurde in {0}s verarbeitet",
      "對伺服器的請求已在 {0} 秒內處理完畢"};
    public static readonly string[] PageNotExists = {
      "Page {0} is missing in Excel file",
      "Страница {0} отсутствует в Excel-файле",
      "La pagina {0} manca nel file Excel",
      "Seite {0} fehlt in der Excel-Datei",
      "Excel 文件中缺少第 {0} 页" };
    public static readonly string[] SkipsLine = {
      "Skips the line Shape = {0}",
      "Пропускает строку Shape = {0}",
      "Salta la riga Shape = {0}",
      "Überspringt die Zeile Shape = {0}",
      "跳过行 Shape = {0}"};
    public static readonly string[] ZeroSizeSolidError = {
      "An attempt to create a size zero solid. Let's skip it.",
      "Попытка создать солид нулевого размера. Пропускаем.",
      "Un tentativo di creare un solido di dimensione zero. Saltiamolo.",
      "Ein Versuch, einen Körper der Größe Null zu erstellen. Lass es uns überspringen.",
      "嘗試建立零尺寸實體。讓我們跳過它。"};
    public static readonly string[] BoxIsNull = {
      "Trying to create a block without a name",
      "Попытка создать блок без имени",
      "Tentativo di creare un blocco senza nome",
      "Ich versuche, einen Block ohne Namen zu erstellen",
      "尝试创建一个没有名称的块" };
    public static readonly string[] TableRowCount = {
      "A table of {0} rows has been read. Objects received {1}.",
      "Прочитана таблицы из {0} строк. Получено объектов {1}.",
      "Visualizza tabelle a partire da {0} pagina. {1} oggetti ricevuti.",
      "Eine Tabelle mit {0} Zeilen wurde gelesen. {1} Objekte empfangen.",
      "已讀取包含 {0} 行的表。收到 {1} 个对象。" };
    public static readonly string[] SelectFile = {
      "Specify the file with 3d-solid table",
      "Укажите файл с таблицей солидов",
      "Specificare il file con la tabella dei solidi 3D",
      "Geben Sie die Datei mit 3D-Solid-Tabelle an",
      "指定包含 3d-solid 表的文件" };
    public static readonly string[] CreateGroup = {
      "Create group {0}",
      "Создание группы {0}",
      "Crea gruppo {0}",
      "Gruppe {0} erstellen",
      "创建组 {0}"};
    public static readonly string[] CreateBoxes = {
      "Creation of solids and blocks according to the table",
      "Создание солидов и блоков по таблице",
      "Creazione di solidi e blocchi secondo la tabella",
      "Erstellung von Volumenkörpern und Blöcken gemäß Tabelle",
      "根据表创建实体和块。"};
    public static readonly string[] Done = {
      "Created drawing objects: {0}",
      "Удалось создать объектов чертежа: {0}",
      "Era possibile creare oggetti di disegno: {0}",
      "Es konnten Zeichnungsobjekte erstellt werden: {0}",
      "可以创建绘图对象：{0}" };
    public static readonly string[] DialogTitle = {
      "Selecting a table",
      "Выбор таблицы",
      "Selezione di una tabella",
      "Auswählen einer Tabelle",
      "选择表格" };
    public static readonly string[] StyleNameTip = {
      "The name for this Box From Table style. Not used in the program. Only for convenience of choice.",
      "Название для этого стиля команды Боксы по таблице. Не используется в программе. Только для удобства выбора.",
      "Il nome per questo stile BoxFromTable. Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für BoxFromTable-Stil. Wird im Programm nicht verwendet. Nur aus Bequemlichkeit.",
      "此表格框样式的名称。程序中未使用。仅为方便选择。" };
    public static readonly string[] StyleHint = {
      "Before calling the BoxFromTable command, create an Excel or CSV table with columns:\r\n" +
        "  ·Shape - solid shape: Box, Cone, Cylinder, Pyramid, Sphere. Another word is the line is ignored.\r\n" +
        "  ·X, Y, Z - insertion coordinates of the minimum point of the box or the center of the base of other shapes.\r\n" +
        "  ·SizeX, SizeY, SizeZ - dimensions of the solid along three axes.\r\n" +
        "  ·RotateX, Y, Z - rotation of the solid around three axes relative to the insertion point. Degrees.\r\n" +
        "  ·Layer, Color, Material - solid properties.\r\n" +
        "  ·Owner - the name of the group or new assembly block for this part.\r\n" +
        "  ·Name, Kind, Info - additional properties of the solid.\r\n" +
        "\r\n" +
        "Instead of creating a solid, you can insert an existing block into the drawing. Then the columns mean:\r\n" +
        "  ·Shape = Block.\r\n" +
        "  ·SizeX, SizeY, SizeZ - block insertion scale. Preferably 1. Less than zero - mirror block.\r\n" +
        "  ·Owner - the name of the old block where the specified block or Model should be inserted\r\n" +
        "  ·Name - the name of an existing block to insert or the name of a block from a dwt template.",
      "До вызова команды BoxFromTable создайте таблицу Excel или CSV со столбцами:\r\n" +
        " ·Shape - форма солида: Box, Cone, Cylinder, Pyramid, Sphere. Другое слово - строка игнорируется.\r\n" +
        " ·X, Y, Z - координаты вставки минимальной точки бокса или центра основания других фигур.\r\n" +
        " ·SizeX, SizeY, SizeZ - размеры солида по трем осям.\r\n" +
        " ·RotateX, Y, Z - вращение солида вокруг трех осей относительно точки вставки. Градусы.\r\n" +
        " ·Layer, Color, Material - свойства солида.\r\n" +
        " ·Owner - имя группы или нового блока-сборки для данной детали.\r\n" +
        " ·Name, Kind, Info - дополнительные свойства солида.\r\n" +
        "\r\n" +
        "Вместо создания солида можно вставить в чертеж существующий блок. Тогда столбцы означают:\r\n" +
        " ·Shape = Block.\r\nSizeX, SizeY, SizeZ - масштаб вставки блока. Желательно 1. Меньше ноля - зеркальный блок.\r\n" +
        " ·Owner - имя старого блок, куда надо вставить заданный блок или Model\r\n" +
        " ·Name - имя существующего блока для вставки или имя блока из dwt-шаблона. ",
      "Prima di chiamare il comando BoxFromTable, crea una tabella Excel o CSV con colonne:\r\n" +
        "  ·Forma - forma solida: Box, Cone, Cylinder, Pyramid, Sphere. Un'altra parola è che la linea viene ignorata.\r\n" +
        "  ·X, Y, Z - coordinate di inserimento del punto minimo della scatola o del centro della base di altre forme.\r\n" +
        "  ·SizeX, SizeY, SizeZ - dimensioni del solido lungo tre assi.\r\n" +
        "  ·RotateX, Y, Z: rotazione del solido attorno a tre assi rispetto al punto di inserimento. Gradi.\r\n" +
        "  ·Layer, Color, Material: proprietà del solido.\r\n" +
        "  ·Owner: il nome del gruppo o del nuovo blocco di assieme per questa parte.\r\n" +
        "  ·Name, Kind, Info: proprietà aggiuntive del solido.\r\n" +
        "\r\n" +
        "Invece di creare un solido, è possibile inserire un blocco esistente nel disegno. Quindi le colonne significano:\r\n" +
        "  ·Shape = Block.\r\n" +
        "  ·SizeX, SizeY, SizeZ - scala di inserimento del blocco. Preferibilmente 1. Meno di zero - blocco specchio.\r\n" +
        "  ·Owner: il nome del vecchio blocco in cui deve essere inserito il blocco o il modello specificato\r\n" +
        "  ·Name: il nome di un blocco esistente da inserire o il nome di un blocco da un modello dwt.",
      "Erstellen Sie vor dem Aufruf des Befehls BoxFromTable eine Excel- oder CSV-Tabelle mit Spalten:\r\n" +
        "  ·Shape – feste Form: Box, Cone, Cylinder, Pyramid, Sphere. Ein anderes Wort ist, dass die Zeile ignoriert wird.\r\n" +
        "  ·X, Y, Z – Einfügekoordinaten des Mindestpunkts des Kastens oder der Mitte der Basis anderer Formen.\r\n" +
        "  ·SizeX, SizeY, SizeZ – Abmessungen des Volumenkörpers entlang dreier Achsen.\r\n" +
        "  ·RotateX, Y, Z – Drehung des Volumenkörpers um drei Achsen relativ zum Einfügepunkt. Abschlüsse.\r\n" +
        "  ·Layer, Color, Material – feste Eigenschaften.\r\n" +
        "  ·Owner – der Name der Gruppe oder des neuen Baugruppenblocks für dieses Teil.\r\n" +
        "  ·Name, Kind, Info – zusätzliche Eigenschaften des Volumenkörpers.\r\n" +
        "\r\n" +
        "Anstatt einen Volumenkörper zu erstellen, können Sie einen vorhandenen Block in die Zeichnung einfügen. \r\n" +
        "Dann bedeuten die Spalten:\r\n" +
        "  ·Shape = Block.\r\n" +
        "  ·SizeX, SizeY, SizeZ – Blockeinfügungsskala. Vorzugsweise 1. Kleiner als Null – Spiegelblock.\r\n" +
        "  ·Owner – der Name des alten Blocks, in den der angegebene Block oder das angegebene Modell eingefügt werden soll\r\n" +
        "  ·Name – der Name eines vorhandenen Blocks, der eingefügt werden soll, oder der Name eines Blocks aus einer DWT-Vorlage.",
      "在调用 BoxFromTable 命令之前，请创建一个包含列的 Excel 或 CSV 表：\r\n" +
        "  ·Shape - 实体形状：Box, Cone, Cylinder, Pyramid, Sphere。另一个词是该行被忽略。\r\n" +
        "  ·X、Y、Z - 盒子最小点或其他形状底部中心的插入坐标。\r\n" +
        "  ·SizeX、SizeY、SizeZ - 实体沿三个轴的尺寸。\r\n" +
        "  ·RotateX、Y、Z - 实体相对于插入点绕三个轴旋转。度。\r\n" +
        "  ·Layer, Color, Material - 实体属性。\r\n" +
        "  ·Owner - 该零件的组或新装配块的名称。\r\n" +
        "  ·Name, Kind, Info - 实体的附加属性。\r\n" +
        "\r\n" +
        "您可以将现有块插入到图形中，而不是创建实体。那么各列的含义是：\r\n" +
        "  ·Shape = Block。\r\n" +
        "  ·SizeX、SizeY、SizeZ - 块插入比例。优选1.小于零镜块。\r\n" +
        "  ·Owner - 应插入指定块或模型的旧块的名称\r\n" +
        "  ·Name - 要插入的现有块的名称或 dwt 模板中的块的名称。" };
    public static readonly string[] Drill = {
      "Make Drilling",
      "Выполнить сверловку",
      "Effettuare la perforazione",
      "Bohren",
      "进行钻孔" };
    public static readonly string[] DrillTip = {
      "Call the drill command (DRI) to subtract all solids created on the Holes layer",
      "Вызвать команду сверления (DRI), чтоб вычесть все солиды, созданные на слое Отверстия",
      "Chiamare il comando di perforazione (DRI) per sottrarre tutti i solidi creati sul livello Fori",
      "Rufen Sie den Bohrbefehl (DRI) auf, um alle auf der Ebene „Löcher“ erstellten Volumenkörper zu subtrahieren",
      "调用钻孔命令 (DRI) 以减去在“孔”层上创建的所有实体" };
    public static readonly string[] MakeBlock = {
      "Create block assembly",
      "Создать блок-сборку",
      "Crea assieme di blocchi",
      "Blockbaugruppe erstellen",
      "创建块装配体" };
    public static readonly string[] MakeBlockTip = {
      "Create a block assembly from the obtained solids. \r\n" +
        "The AsmCreate command will be called. Check its settings.",
      "Создать из полученных солидов блок-сборку. Будет вызвана команду AsmCreate. Проверьте ее настройки.",
      "Creare un assieme di blocchi dai solidi ottenuti. Verrà richiamato il comando AsmCreate. \r\n" +
        "Controlla le sue impostazioni.",
      "Erstellen Sie aus den erhaltenen Volumenkörpern eine Blockbaugruppe. Der Befehl AsmCreate wird aufgerufen. \r\n" +
        "Überprüfen Sie die Einstellungen.",
      "从获得的实体创建块组件。将调用 AsmCreate 命令。检查其设置。" };
    public static readonly string[] MakeGroup = {
      "Create a group",
      "Создать группу",
      "创建群组",
      "Um eine Gruppe zu erstellen",
      "创建群组" };
    public static readonly string[] MakeGroupTip = {
      "Create a named selection group from the resulting solids",
      "Создать из полученных солидов именованную группу выбора",
      "Creare un gruppo di selezione con nome dai solidi risultanti",
      "Erstellen Sie aus den resultierenden Volumenkörpern eine benannte Auswahlgruppe",
      "从生成的实体创建命名选择组" };
    public static readonly string[] File = {
      "Table file",
      "Файл с таблицей",
      "Archivio di tabelle",
      "Table file",
      "表格文件" };
    public static readonly string[] FileTip = {
      "Load table from this file",
      "Загружать таблицу из этого файла",
      "Carica la tabella da questo file",
      "Tabelle aus dieser Datei laden",
      "从该文件加载表" };
    public static readonly string[] ServerAddress = {
      "Web server name",
      "Имя web-сервера",
      "Nome del server Web",
      "Name des Webservers",
      "网络服务器名称" };
    public static readonly string[] ServerAddressTip = {
      "The URL for the web server that processes requests to model wall assemblies. \r\n" +
        "Only for BoxToWall and BoxToVector commands",
      "URL-адрес для web-сервера, который обрабатывает запросы на моделирование сборок стен. \r\n" +
        "Только для команд BoxToWall и BoxToVector",
      "L'URL del server Web che elabora le richieste per modellare gli assiemi di muri. \r\n" +
        "Solo per i comandi BoxToWall e BoxToVector",
      "Die URL für den Webserver, der Anfragen zum Modellieren von Wandbaugruppen verarbeitet. \r\n" +
        "Nur für die Befehle BoxToWall und BoxToVector",
      "处理模型墙组件请求的 Web 服务器的 URL。仅适用于 BoxToWall 和 BoxToVector 命令" };
    public static readonly string[] RequestFile = {
      "Request file",
      "Запрашивать файл",
      "Richiedi file",
      "Datei anfordern",
      "请求文件" };
    public static readonly string[] RequestFileTip = {
      "Call the file open dialog every time you call the BoxFromTable command",
      "Вызывать диалог открытия файла при каждом вызове команды BoxFromTable",
      "Richiama la finestra di dialogo di apertura del file ogni volta che chiami il comando BoxFromTable",
      "Rufen Sie den Datei-Öffnen-Dialog jedes Mal auf, wenn Sie den BoxFromTable-Befehl aufrufen",
      "每次调用 BoxFromTable 命令时调用文件打开对话框" };
    public static readonly string[] Expose = {
      "Expose assemblies",
      "Выставить сборки",
      "Esporre le assemblee",
      "Baugruppen verfügbar machen",
      "暴露程序集" };
    public static readonly string[] ExposeTip = {
      "Call the Expose command to insert all created assemblies in a row in an empty space of the model",
      "Вызвать команду Expose для вставки всех созданных сборок в ряд в свободном месте модели",
      "Chiama il comando Esponi per inserire tutti gli assiemi creati in una riga in uno spazio vuoto del modello",
      "Rufen Sie den Befehl „Expose“ auf, \r\n" +
        "um alle erstellten Baugruppen in einer Reihe in einen leeren Bereich des Modells einzufügen",
      "调用 Expose 命令将所有创建的组件插入到模型空白区域的一行中" };
    public static readonly string[] Page = {
      "Excel page",
      "Страница Excel",
      "Pagina Excel",
      "Seite Excel",
      "页 Excel" };
    public static readonly string[] PageTip = {
      "An Excel file page containing a table containing a description of the solid parts. \r\n" +
        "If not specified, the search will be on the first page. Excel files only",
      "Страница файла Excel, на которой находится таблица в описанием солидов-деталей. \r\n" +
        "Если не указана, то поиск будет на первой странице. Только для файлов Excel",
      "Una pagina di file Excel contenente una tabella contenente la descrizione delle parti solide. \r\n" +
        "Se non specificato la ricerca avverrà nella prima pagina. Solo file Excel",
      "Eine Excel-Dateiseite mit einer Tabelle mit einer Beschreibung der Volumenkörperteile. \r\n" +
        "Wenn nicht angegeben, erfolgt die Suche auf der ersten Seite. Nur Excel-Dateien",
      "Excel 文件页面，其中包含一个表格，该表格包含实体零件的描述。如果未指定，搜索将在第一页。仅 Excel 文件" };
    public static readonly string[] Separator = {
      "CSV column separator",
      "Разделитель столбцов CSV",
      "Separatore di colonne CSV",
      "CSV-Spaltentrennzeichen",
      "CSV 列分隔符" };
    public static readonly string[] SeparatorTip = {
      "A character used as a column separator in CSV and TSV files. \r\n" +
        "If this character is used within a column, it must be preceded by a \\",
      "Символ, используемый как разделитель столбцов в файлах CSV и TSV. \r\n" +
        "Если этот символ используется внутри столбца, перед ним надо поставить \\",
      "Un carattere utilizzato come separatore di colonna nei file CSV e TSV. \r\n" +
        "Se questo carattere viene utilizzato all'interno di una colonna, deve essere preceduto da \\",
      "Ein Zeichen, das als Spaltentrennzeichen in CSV- und TSV-Dateien verwendet wird. \r\n" +
        "Wenn dieses Zeichen innerhalb einer Spalte verwendet wird, muss ihm ein \\ vorangestellt werden.",
      "在 CSV 和 TSV 文件中用作列分隔符的字符。\r\n" +
        "如果该字符在列中使用，则其前面必须带有 \\" };
    public static readonly string[] Comma = {
      "Comma",
      "Запятая",
      "Virgola",
      "Komma",
      "逗号" };
    public static readonly string[] Semicolon = {
      "Semicolon",
      "Точка с запятой",
      "Punto e virgola",
      "Punkt mit Komma",
      "分号" };
  }
}
