// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  BoxFromTableL
  {
    public static readonly string[][] BoxFromTableNames = {
/* 0 */ CommandL.BoxFromTable,
/* 1 */ CommandL.BoxFromTable,
        };

    public static readonly string[] BoxToWallProgress = {
      "Detailing",
      "Деталировка",
      "Dettagli",
      "Detaillierung",
      "細節處理",
      "Detallado",                                               // ES
      "Détaillage",                                              // FR
      "Detaylandırma"};                                          // TR

    public static readonly string[] RequestForBox = {
      "Request parts for the wall {0} from the web server...",
      "Запрашиваем на web-сервере деталировку для стены {0}...",
      "Richiedi parti per il muro {0} dal server web...",
      "Teile für die Wand {0} vom Webserver anfordern...",
      "从网络服务器请求墙体 {0} 的部件...",
      "Solicitar piezas para el muro {0} del servidor web...",   // ES
      "Demander des pièces pour le mur {0} au serveur web...",   // FR
      "Web sunucusundan duvar {0} için parçalar isteyin..."};    // TR

    public static readonly string[] RequestForVector = {
      "Request flat drawings for wall {0} from the web server...",
      "Запрашиваем на web-сервере плоские чертежи для стены {0}...",
      "Richiedi disegni piatti per il muro {0} dal server web...",
      "Fordern Sie vom Webserver Grundrisse für die Wand {0} an...",
      "从 Web 服务器请求墙壁 {0} 的平面图...",
      "Solicitar dibujos planos para el muro {0} del servidor web...",  // ES
      "Demander des dessins plats pour le mur {0} au serveur web...",  // FR
      "Web sunucusundan duvar {0} için düz çizimler isteyin..."};  // TR

    public static readonly string[] RequestError = {
      "Error when requesting to the server.\r\n{0}",
      "Ошибка при запросе на сервер.\r\n{0}",
      "Errore durante la richiesta al server.\r\n{0}",
      "Fehler bei der Anfrage an den Server.\r\n{0}",
      "向伺服器請求時發生錯誤。\r\n{0}",
      "Error al solicitar al servidor.\r\n{0}",                  // ES
      "Erreur lors de la demande au serveur.\r\n{0}",            // FR
      "Sunucuya istek gönderilirken hata oluştu.\r\n{0}"};       // TR

    public static readonly string[] ZeroBoxDataError = {
      "Received empty parts list for wall {0}",
      "Получен пустой список деталей для стены {0}",
      "Ricevuto elenco delle parti vuoto per il muro {0}",
      "Leere Teileliste für Wand {0} erhalten",
      "收到牆 {0} 的空零件清單",
      "Se recibió lista de piezas vacía para el muro {0}",       // ES
      "Liste de pièces vide reçue pour le mur {0}",              // FR
      "Duvar {0} için boş parça listesi alındı"};                // TR

    public static readonly string[] BoxDataReceived = {
      "Data received from the server to create {0} parts for wall {1}",
      "С сервера получены данные для создания {0} деталей для стены {1}",
      "Dati ricevuti dal server per creare {0} parti per il muro {1}",
      "Vom Server empfangene Daten zum Erstellen von {0} Teilen für die Wand {1}",
      "從伺服器接收的數據，用於為牆 {1} 建立 {0} 個部件",
      "Datos recibidos del servidor para crear {0} piezas para el muro {1}",  // ES
      "Données reçues du serveur pour créer {0} pièces pour le mur {1}",  // FR
      "Duvar {1} için {0} parça oluşturmak üzere sunucudan veri alındı"};  // TR

    public static readonly string[] PlanDataReceived = {
      "Data was received from the server to create the drawing {0}",
      "С сервера получены данные для создания чертежа {0}",
      "I dati sono stati ricevuti dal server per creare il disegno {0}",
      "Vom Server wurden Daten zum Erstellen der Zeichnung {0} empfangen.",
      "已從伺服器接收資料以建立繪圖 {0}",
      "Se recibieron datos del servidor para crear el dibujo {0}",  // ES
      "Les données ont été reçues du serveur pour créer le dessin {0}",  // FR
      "Çizim {0} oluşturmak için sunucudan veri alındı"};        // TR

    public static readonly string[] ZeroSolidListError = {
      "Failed to create one wall {0} - failed to create any parts",
      "Не удалось создать одну стену {0} - не получилось создать ни одной детали",
      "Impossibile creare un muro {0} - impossibile creare nessuna parte",
      "Eine Wand {0} konnte nicht erstellt werden – es konnten keine Teile erstellt werden",
      "無法建立一堵牆 {0} - 無法建立任何部分",
      "Error al crear un muro {0}: no se pudo crear ninguna pieza",  // ES
      "Échec de la création d'un mur {0} - impossible de créer des pièces",  // FR
      "Bir duvar {0} oluşturulamadı - hiçbir parça oluşturulamadı"};  // TR

    public static readonly string[] ZeroPlanError = {
      "Failed to create drawing {0} - failed to create any objects",
      "Не удалось создать чертеж {0} - не получилось создать ни одного объекта",
      "Impossibile creare il disegno {0}: impossibile creare alcun oggetto",
      "Zeichnung {0} konnte nicht erstellt werden – es konnten keine Objekte erstellt werden",
      "未能建立繪圖 {0} - 未能建立任何對象",
      "Error al crear el dibujo {0}: no se pudo crear ningún objeto",  // ES
      "Échec de la création du dessin {0} - impossible de créer des objets",  // FR
      "Çizim {0} oluşturulamadı - hiçbir nesne oluşturulamadı"};  // TR

    public static readonly string[] ColumnReadError = {
      "Failed to read data in column {0}",
      "Не удалось прочитать данные в столбце {0}",
      "Impossibile leggere i dati nella colonna {0}",
      "Daten in Spalte {0} konnten nicht gelesen werden",
      "无法读取第 {0} 列中的数据",
      "Error al leer datos en la columna {0}",                   // ES
      "Échec de la lecture des données dans la colonne {0}",     // FR
      "Sütun {0}'daki veriler okunamadı"};                       // TR

    public static readonly string[] BoxToWallResult = {
      "Managed to create walls {0}",
      "Удалось создать стен {0}",
      "Gestito per creare muri {0}",
      "Es ist mir gelungen, Wände zu erstellen {0}",
      "成功建造了牆壁{0}",
      "Se lograron crear muros {0}",                             // ES
      "Création de murs réussie {0}",                            // FR
      "Duvar oluşturma başarılı {0}"};                           // TR

    public static readonly string[] BoxToVectorResult = {
      "Successful creation of {0} drawings",
      "Удалось создать чертежей {0}",
      "Creazione riuscita di {0} disegni",
      "Erfolgreiche Erstellung von {0} Zeichnungen",
      "成功建立 {0} 個繪圖",
      "Creación exitosa de {0} dibujos",                         // ES
      "Création réussie de {0} dessins",                         // FR
      "{0} çizim başarıyla oluşturuldu"};                        // TR

    public static readonly string[] BoxtToVectorProgress = {
      "Creating Drawings",
      "Создание чертежей",
      "Creazione di disegni",
      "Zeichnungen erstellen",
      "建立繪圖",
      "Creando dibujos",                                         // ES
      "Création de dessins",                                     // FR
      "Çizimler oluşturuluyor"};                                 // TR

    public static readonly string[] SelectSolidOrBlock = {
      "Choose solid boxes to fit the wall or blocks of ready-made walls.",
      "Выберите солиды-боксы в габарит стены или блоки готовых стен.",
      "Scegli scatole solide da adattare al muro o blocchi di pareti già pronte.",
      "Wählen Sie feste, an die Wand angepasste Kästen oder Blöcke vorgefertigter Wände.",
      "選擇適合牆壁的實心盒子或現成的牆壁塊。",
      "Elija cajas sólidas para ajustar al muro o bloques de muros prefabricados.",  // ES
      "Choisissez des boîtes solides pour s'adapter au mur ou des blocs de murs préfabriqués.",  // FR
      "Duvara uyacak katı kutular veya hazır duvar blokları seçin."};  // TR

    public static readonly string[] LineWeightErr = {
      "Specified non-existent line weight {0}",
      "Задан несуществующий вес линий {0}",
      "Spessore di linea inesistente specificato {0}",
      "Angegebene nicht vorhandene Linienstärke {0}",
      "指定的不存在的線寬 {0}",
      "Se especificó un grosor de línea inexistente {0}",        // ES
      "Épaisseur de ligne inexistante spécifiée {0}",            // FR
      "Var olmayan çizgi kalınlığı belirtildi {0}"};             // TR

    public static readonly string[] LineTypeErr = {
      "Specified non-existent linetype {0}",
      "Задан несуществующий тип линий {0}",
      "Tipo di linea {0} inesistente specificato",
      "Angegebener nicht vorhandener Linientyp {0}",
      "指定的不存在線型 {0}",
      "Se especificó un tipo de línea inexistente {0}",          // ES
      "Type de ligne inexistant spécifié {0}",                   // FR
      "Var olmayan çizgi tipi belirtildi {0}"};                  // TR

    public static readonly string[] ColorErr = {
      "Failed to recognize color {0}",
      "Не удалось распознать цвет {0}",
      "Impossibile riconoscere il colore {0}",
      "Farbe {0} konnte nicht erkannt werden",
      "無法辨識顏色{0}",
      "No se pudo reconocer el color {0}",                       // ES
      "Impossible de reconnaître la couleur {0}",                // FR
      "Renk {0} tanınamadı"};                                    // TR

    public static readonly string[] DimScaleErr = {
      "Failed to set dimension scale {0}",
      "Не удалось настроить масштаб размера {0}",
      "Impossibile impostare la scala delle dimensioni {0}",
      "Größenskala konnte nicht festgelegt werden {0}",
      "无法设置尺寸比例 {0}",
      "Error al establecer escala de dimensión {0}",             // ES
      "Échec de la définition de l'échelle de dimension {0}",    // FR
      "Boyut ölçeği ayarlanamadı {0}"};                          // TR

    public static readonly string[] PLineConversionErr = {
      "It was not possible to construct a polyline from the given points",
      "Не удалось построить полилинию по заданным точкам",
      "Non è stato possibile costruire una polilinea utilizzando i punti indicati",
      "Es war nicht möglich, aus den angegebenen Punkten eine Polylinie zu konstruieren",
      "無法從給定點構造折線",
      "No fue posible construir una polilínea a partir de los puntos dados",  // ES
      "Il n'a pas été possible de construire une polyligne à partir des points donnés",  // FR
      "Verilen noktalardan çoklu çizgi oluşturulamadı"};         // TR

    public static readonly string[] NullPlanError = {
      "Received empty wall plan {0}",
      "Получен пустой план стены {0}",
      "Ricevuta una planimetria vuota {0}",
      "Leeren Wandplan {0} erhalten",
      "收到空牆平面圖 {0}",
      "Se recibió plano de muro vacío {0}",                      // ES
      "Plan de mur vide reçu {0}",                               // FR
      "Boş duvar planı alındı {0}"};                             // TR

    public static readonly string[] RequestTime = {
      "The request to the server was processed in {0}s",
      "Запрос к серверу обработан за {0}c",
      "La richiesta al server è stata elaborata in {0}s",
      "Die Anfrage an den Server wurde in {0}s verarbeitet",
      "對伺服器的請求已在 {0} 秒內處理完畢",
      "La solicitud al servidor se procesó en {0}s",             // ES
      "La demande au serveur a été traitée en {0}s",             // FR
      "Sunucuya yapılan istek {0}s içinde işlendi"};             // TR

    public static readonly string[] PageNotExists = {
      "Page {0} is missing in Excel file",
      "Страница {0} отсутствует в Excel-файле",
      "La pagina {0} manca nel file Excel",
      "Seite {0} fehlt in der Excel-Datei",
      "Excel 文件中缺少第 {0} 页",
      "Falta la página {0} en el archivo de Excel",              // ES
      "La page {0} est manquante dans le fichier Excel",         // FR
      "Excel dosyasında {0} sayfası eksik"};                     // TR

    public static readonly string[] SkipsLine = {
      "Skips the line Shape = {0}",
      "Пропускает строку Shape = {0}",
      "Salta la riga Shape = {0}",
      "Überspringt die Zeile Shape = {0}",
      "跳过行 Shape = {0}",
      "Omite la línea Shape = {0}",                              // ES
      "Ignore la ligne Shape = {0}",                             // FR
      "Shape = {0} satırını atlar"};                             // TR

    public static readonly string[] ZeroSizeSolidError = {
      "An attempt to create a size zero solid. Let's skip it.",
      "Попытка создать солид нулевого размера. Пропускаем.",
      "Un tentativo di creare un solido di dimensione zero. Saltiamolo.",
      "Ein Versuch, einen Körper der Größe Null zu erstellen. Lass es uns überspringen.",
      "嘗試建立零尺寸實體。讓我們跳過它。",
      "Intento de crear un sólido de tamaño cero. Lo omitiremos.",  // ES
      "Tentative de créer un solide de taille zéro. Ignorons-le.",  // FR
      "Sıfır boyutlu katı oluşturma girişimi. Atlayalım."};      // TR

    public static readonly string[] BoxIsNull = {
      "Trying to create a block without a name",
      "Попытка создать блок без имени",
      "Tentativo di creare un blocco senza nome",
      "Ich versuche, einen Block ohne Namen zu erstellen",
      "尝试创建一个没有名称的块",
      "Intentando crear un bloque sin nombre",                   // ES
      "Tentative de créer un bloc sans nom",                     // FR
      "İsimsiz bir blok oluşturmaya çalışılıyor"};               // TR

    public static readonly string[] TableRowCount = {
      "  A table of {0} rows has been read. Objects received {1}.",
      "  Прочитана таблицы из {0} строк. Получено объектов {1}.",
      "  Visualizza tabelle a partire da {0} pagina. {1} oggetti ricevuti.",
      "  Eine Tabelle mit {0} Zeilen wurde gelesen. {1} Objekte empfangen.",
      "  已讀取包含 {0} 行的表。收到 {1} 个对象。",
      "  Se ha leído una tabla de {0} filas. Se recibieron {1} objetos.",  // ES
      "  Une table de {0} lignes a été lue. {1} objets reçus.",  // FR
      "  {0} satırlık bir tablo okundu. {1} nesne alındı."};     // TR

    public static readonly string[] SelectFile = {
      "Specify the file with 3d-solid table",
      "Укажите файл с таблицей солидов",
      "Specificare il file con la tabella dei solidi 3D",
      "Geben Sie die Datei mit 3D-Solid-Tabelle an",
      "指定包含 3d-solid 表的文件",
      "Especifique el archivo con la tabla de sólidos 3D",       // ES
      "Spécifiez le fichier avec la table de solides 3D",        // FR
      "3D katı tablosu içeren dosyayı belirtin"};                // TR

    public static readonly string[] CreateGroup = {
      "Create group {0}",
      "Создание группы {0}",
      "Crea gruppo {0}",
      "Gruppe {0} erstellen",
      "创建组 {0}",
      "Crear grupo {0}",                                         // ES
      "Créer le groupe {0}",                                     // FR
      "Grup {0} oluştur"};                                       // TR

    public static readonly string[] CreateBoxes = {
      "Creation of solids and blocks according to the table",
      "Создание солидов и блоков по таблице",
      "Creazione di solidi e blocchi secondo la tabella",
      "Erstellung von Volumenkörpern und Blöcken gemäß Tabelle",
      "根据表创建实体和块。",
      "Creación de sólidos y bloques según la tabla",            // ES
      "Création de solides et de blocs selon le tableau",        // FR
      "Tabloya göre katılar ve blokların oluşturulması"};        // TR

    public static readonly string[] Done = {
      "Created drawing objects: {0}",
      "Удалось создать объектов чертежа: {0}",
      "Era possibile creare oggetti di disegno: {0}",
      "Es konnten Zeichnungsobjekte erstellt werden: {0}",
      "可以创建绘图对象：{0}",
      "Objetos de dibujo creados: {0}",                          // ES
      "Objets de dessin créés : {0}",                            // FR
      "Oluşturulan çizim nesneleri: {0}"};                       // TR

    public static readonly string[] DialogTitle = {
      "Selecting a table",
      "Выбор таблицы",
      "Selezione di una tabella",
      "Auswählen einer Tabelle",
      "选择表格",
      "Seleccionando una tabla",                                 // ES
      "Sélection d'une table",                                   // FR
      "Bir tablo seçme"};                                        // TR

    public static readonly string[] StyleNameTip = {
      "The name for this Box From Table style. Not used in the program. Only for convenience of choice.",
      "Название для этого стиля команды Боксы по таблице. Не используется в программе. Только для удобства выбора.",
      "Il nome per questo stile BoxFromTable. Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für BoxFromTable-Stil. Wird im Programm nicht verwendet. Nur aus Bequemlichkeit.",
      "此表格框样式的名称。程序中未使用。仅为方便选择。",
      "El nombre de este estilo Box From Table. No se usa en el programa. Solo por conveniencia de elección.",  // ES
      "Le nom de ce style Box From Table. Non utilisé dans le programme. Seulement pour la commodité du choix.",  // FR
      "Bu Box From Table stili için ad. Programda kullanılmaz. Sadece seçim kolaylığı için."};  // TR


    public static readonly string[] StyleHint = {
      "Before calling the BoxFromTable command, create an Excel or CSV table with columns:\r\n" +
        "  ·Shape - solid shape: Box, Cone, Cylinder, Pyramid, Sphere. Another word is the line is ignored.\r\n" +
        "  ·X, Y, Z - insertion coordinates of the minimum point of the box or the center of the base of other shapes.\r\n" +
        "  ·SizeX, SizeY, SizeZ - dimensions of the solid along three axes.\r\n" +
        "  ·RotateX, Y, Z - rotation of the solid around three axes relative to the insertion point. Degrees.\r\n" +
        "  ·Owner - the name of the group or new assembly block for this part.\r\n" +
        "  ·Layer, Color, Material, Texture - solid properties.\r\n" +
        "  ·Name, Kind, Info - additional properties of the solid.\r\n" +
        "  ·Commands - a list of commands that need to be called for this solid.\r\n" +
        "\r\n" +
        "Instead of creating a solid, you can insert a block, text, or 2D curve into the drawing. Then the columns change their purpose. \r\n" +
        "See the documentation for details.",
      "До вызова команды BoxFromTable создайте таблицу Excel или CSV со столбцами:\r\n" +
        " ·Shape - форма солида: Box, Cone, Cylinder, Pyramid, Sphere. Другое слово - строка игнорируется.\r\n" +
        " ·X, Y, Z - координаты вставки минимальной точки бокса или центра основания других фигур.\r\n" +
        " ·SizeX, SizeY, SizeZ - размеры солида по трем осям.\r\n" +
        " ·RotateX, Y, Z - вращение солида вокруг трех осей относительно точки вставки. Градусы.\r\n" +
        " ·Owner - имя группы или нового блока-сборки для данной детали.\r\n" +
        " ·Layer, Color, Material, Texture - свойства солида.\r\n" +
        " ·Name, Kind, Info - дополнительные свойства солида.\r\n" +
        " ·Commands - список команд, которые надо вызвать для этого солида.\r\n" +
        "\r\n" +
        "Вместо создания солида можно вставить в чертеж блок, текст, 2D фигуру. Тогда столбцы меняют свое назначение.\r\n" +
        "Подробности смотрите в документации.",
      "Prima di chiamare il comando BoxFromTable, crea una tabella Excel o CSV con colonne:\r\n" +
        "  ·Forma - forma solida: Box, Cone, Cylinder, Pyramid, Sphere. Un'altra parola è che la linea viene ignorata.\r\n" +
        "  ·X, Y, Z - coordinate di inserimento del punto minimo della scatola o del centro della base di altre forme.\r\n" +
        "  ·SizeX, SizeY, SizeZ - dimensioni del solido lungo tre assi.\r\n" +
        "  ·RotateX, Y, Z: rotazione del solido attorno a tre assi rispetto al punto di inserimento. Gradi.\r\n" +
        "  ·Owner: il nome del gruppo o del nuovo blocco di assieme per questa parte.\r\n" +
        "  ·Layer, Color, Material, Texture: proprietà del solido.\r\n" +
        "  ·Name, Kind, Info: proprietà aggiuntive del solido.\r\n" +
        "  ·Comandi: un elenco di comandi che devono essere chiamati per questo solido.\r\n" +
        "\r\n" +
        "Invece di creare un solido, puoi inserire un blocco, un testo o una forma 2D nel disegno. Quindi le colonne cambiano il loro scopo. \r\n" +
        "Guarda la documentazione per dettagli.",
      "Erstellen Sie vor dem Aufruf des Befehls BoxFromTable eine Excel- oder CSV-Tabelle mit Spalten:\r\n" +
        "  ·Shape – feste Form: Box, Cone, Cylinder, Pyramid, Sphere. Ein anderes Wort ist, dass die Zeile ignoriert wird.\r\n" +
        "  ·X, Y, Z – Einfügekoordinaten des Mindestpunkts des Kastens oder der Mitte der Basis anderer Formen.\r\n" +
        "  ·SizeX, SizeY, SizeZ – Abmessungen des Volumenkörpers entlang dreier Achsen.\r\n" +
        "  ·RotateX, Y, Z – Drehung des Volumenkörpers um drei Achsen relativ zum Einfügepunkt. Abschlüsse.\r\n" +
        "  ·Owner – der Name der Gruppe oder des neuen Baugruppenblocks für dieses Teil.\r\n" +
        "  ·Layer, Color, Material, Texture – feste Eigenschaften.\r\n" +
        "  ·Name, Kind, Info – zusätzliche Eigenschaften des Volumenkörpers.\r\n" +
        "  ·Commands - eine Liste der Befehle, die für diesen Solid aufgerufen werden müssen.\r\n" +
        "\r\n" +
        "Anstatt einen Volumenkörper zu erstellen, können Sie einen Block, Text oder eine 2D-Form in die Zeichnung einfügen. \r\n" +
        "Dann ändern die Säulen ihren Zweck. Einzelheiten finden Sie in der Dokumentation.",
      "在调用 BoxFromTable 命令之前，请创建一个包含列的 Excel 或 CSV 表：\r\n" +
        "  ·Shape - 实体形状：Box, Cone, Cylinder, Pyramid, Sphere。另一个词是该行被忽略。\r\n" +
        "  ·X、Y、Z - 盒子最小点或其他形状底部中心的插入坐标。\r\n" +
        "  ·SizeX、SizeY、SizeZ - 实体沿三个轴的尺寸。\r\n" +
        "  ·RotateX、Y、Z - 实体相对于插入点绕三个轴旋转。度。\r\n" +
        "  ·Owner - 该零件的组或新装配块的名称。\r\n" +
        "  ·Layer, Color, Material, Texture - 实体属性。\r\n" +
        "  ·Name, Kind, Info - 实体的附加属性。\r\n" +
        "  ·Commands - 需要为此实体调用的命令列表。\r\n"+
        "\r\n" +
        "您可以将块、文本或 2D 形状插入到绘图中，而不是创建实体。然后专栏改变了它们的目的。 有关详细信息，请参阅文档。",
      "Antes de llamar al comando BoxFromTable, cree una tabla de Excel o CSV con columnas:\r\n" +  // ES
        "  ·Shape - forma del sólido: Box, Cone, Cylinder, Pyramid, Sphere. Otra palabra: la línea se ignora.\r\n" +
        "  ·X, Y, Z - coordenadas de inserción del punto mínimo de la caja o del centro de la base de otras formas.\r\n" +
        "  ·SizeX, SizeY, SizeZ - dimensiones del sólido a lo largo de tres ejes.\r\n" +
        "  ·RotateX, Y, Z - rotación del sólido alrededor de tres ejes con respecto al punto de inserción. Grados.\r\n" +
        "  ·Owner - el nombre del grupo o nuevo bloque de ensamblaje para esta pieza.\r\n" +
        "  ·Layer, Color, Material, Texture - propiedades del sólido.\r\n" +
        "  ·Name, Kind, Info - propiedades adicionales del sólido.\r\n" +
        "  ·Commands - una lista de comandos que deben llamarse para este sólido.\r\n" +
        "\r\n" +
        "En lugar de crear un sólido, puede insertar un bloque, texto o curva 2D en el dibujo. Entonces las columnas cambian su propósito. \r\n" +
        "Consulte la documentación para obtener más detalles.",
      "Avant d'appeler la commande BoxFromTable, créez une table Excel ou CSV avec des colonnes :\r\n" +  // FR
        "  ·Shape - forme solide : Box, Cone, Cylinder, Pyramid, Sphere. Un autre mot : la ligne est ignorée.\r\n" +
        "  ·X, Y, Z - coordonnées d'insertion du point minimum de la boîte ou du centre de la base d'autres formes.\r\n" +
        "  ·SizeX, SizeY, SizeZ - dimensions du solide le long de trois axes.\r\n" +
        "  ·RotateX, Y, Z - rotation du solide autour de trois axes par rapport au point d'insertion. Degrés.\r\n" +
        "  ·Owner - le nom du groupe ou du nouveau bloc d'assemblage pour cette pièce.\r\n" +
        "  ·Layer, Color, Material, Texture - propriétés du solide.\r\n" +
        "  ·Name, Kind, Info - propriétés supplémentaires du solide.\r\n" +
        "  ·Commands - une liste de commandes qui doivent être appelées pour ce solide.\r\n" +
        "\r\n" +
        "Au lieu de créer un solide, vous pouvez insérer un bloc, un texte ou une courbe 2D dans le dessin. Ensuite, les colonnes changent de but. \r\n" +
        "Consultez la documentation pour plus de détails.",
      "BoxFromTable komutunu çağırmadan önce, sütunları içeren bir Excel veya CSV tablosu oluşturun:\r\n" +  // TR
        "  ·Shape - katı şekil: Box, Cone, Cylinder, Pyramid, Sphere. Başka bir kelime: satır yok sayılır.\r\n" +
        "  ·X, Y, Z - kutunun minimum noktasının veya diğer şekillerin taban merkezinin ekleme koordinatları.\r\n" +
        "  ·SizeX, SizeY, SizeZ - katının üç eksen boyunca boyutları.\r\n" +
        "  ·RotateX, Y, Z - katının ekleme noktasına göre üç eksen etrafında dönüşü. Derece.\r\n" +
        "  ·Owner - bu parça için grubun veya yeni montaj bloğunun adı.\r\n" +
        "  ·Layer, Color, Material, Texture - katı özellikleri.\r\n" +
        "  ·Name, Kind, Info - katının ek özellikleri.\r\n" +
        "  ·Commands - bu katı için çağrılması gereken komutların listesi.\r\n" +
        "\r\n" +
        "Katı oluşturmak yerine, çizime bir blok, metin veya 2D eğri ekleyebilirsiniz. Ardından sütunlar amaçlarını değiştirir. \r\n" +
        "Ayrıntılar için belgelere bakın."};

    public static readonly string[] Drill = {
      "Make Drilling",
      "Выполнить сверловку",
      "Effettuare la perforazione",
      "Bohren",
      "进行钻孔",
      "Hacer perforación",                                       // ES
      "Faire le perçage",                                        // FR
      "Delme yap"};                                              // TR

    public static readonly string[] DrillTip = {
      "Call the drill command (DRI) to subtract all solids created on the Holes layer",
      "Вызвать команду сверления (DRI), чтоб вычесть все солиды, созданные на слое Отверстия",
      "Chiamare il comando di perforazione (DRI) per sottrarre tutti i solidi creati sul livello Fori",
      "Rufen Sie den Bohrbefehl (DRI) auf, um alle auf der Ebene 'Löcher' erstellten Volumenkörper zu subtrahieren",
      "调用钻孔命令 (DRI) 以减去在'孔'层上创建的所有实体",
      "Llamar al comando de perforación (DRI) para restar todos los sólidos creados en la capa Agujeros",  // ES
      "Appeler la commande de perçage (DRI) pour soustraire tous les solides créés sur la couche Trous",  // FR
      "Delikler katmanında oluşturulan tüm katıları çıkarmak için delme komutunu (DRI) çağırın"};  // TR

    public static readonly string[] MakeBlock = {
      "Create block assembly",
      "Создать блок-сборку",
      "Crea assieme di blocchi",
      "Blockbaugruppe erstellen",
      "创建块装配体",
      "Crear ensamblaje de bloques",                             // ES
      "Créer un assemblage de blocs",                            // FR
      "Blok montajı oluştur"};                                   // TR

    public static readonly string[] MakeBlockTip = {
      "Create a block assembly from the obtained solids. \r\n" +
        "The AsmCreate command will be called. Check its settings.",
      "Создать из полученных солидов блок-сборку. Будет вызвана команду AsmCreate. Проверьте ее настройки.",
      "Creare un assieme di blocchi dai solidi ottenuti. Verrà richiamato il comando AsmCreate. \r\n" +
        "Controlla le sue impostazioni.",
      "Erstellen Sie aus den erhaltenen Volumenkörpern eine Blockbaugruppe. Der Befehl AsmCreate wird aufgerufen. \r\n" +
        "Überprüfen Sie die Einstellungen.",
      "从获得的实体创建块组件。将调用 AsmCreate 命令。检查其设置。",
      "Crear un ensamblaje de bloques a partir de los sólidos obtenidos. \r\n" +  // ES
        "Se llamará al comando AsmCreate. Verifique su configuración.",
      "Créer un assemblage de blocs à partir des solides obtenus. \r\n" +  // FR
        "La commande AsmCreate sera appelée. Vérifiez ses paramètres.",
      "Elde edilen katılardan bir blok montajı oluşturun. \r\n" +  // TR
        "AsmCreate komutu çağrılacaktır. Ayarlarını kontrol edin."};

    public static readonly string[] MakeGroup = {
      "Create a group",
      "Создать группу",
      "创建群组",
      "Um eine Gruppe zu erstellen",
      "创建群组",
      "Crear un grupo",                                          // ES
      "Créer un groupe",                                         // FR
      "Bir grup oluştur"};                                       // TR

    public static readonly string[] MakeGroupTip = {
      "Create a named selection group from the resulting solids",
      "Создать из полученных солидов именованную группу выбора",
      "Creare un gruppo di selezione con nome dai solidi risultanti",
      "Erstellen Sie aus den resultierenden Volumenkörpern eine benannte Auswahlgruppe",
      "从生成的实体创建命名选择组",
      "Crear un grupo de selección con nombre a partir de los sólidos resultantes",  // ES
      "Créer un groupe de sélection nommé à partir des solides résultants",  // FR
      "Sonuçtaki katılardan adlandırılmış bir seçim grubu oluşturun"};  // TR

    public static readonly string[] File = {
      "Table file",
      "Файл с таблицей",
      "Archivio di tabelle",
      "Table file",
      "表格文件",
      "Archivo de tabla",                                        // ES
      "Fichier de table",                                        // FR
      "Tablo dosyası"};                                          // TR

    public static readonly string[] FileTip = {
      "Load table from this file",
      "Загружать таблицу из этого файла",
      "Carica la tabella da questo file",
      "Tabelle aus dieser Datei laden",
      "从该文件加载表",
      "Cargar tabla desde este archivo",                         // ES
      "Charger la table à partir de ce fichier",                 // FR
      "Bu dosyadan tablo yükle"};                                // TR

    public static readonly string[] ServerAddress = {
      "Web server name",
      "Имя web-сервера",
      "Nome del server Web",
      "Name des Webservers",
      "网络服务器名称",
      "Nombre del servidor web",                                 // ES
      "Nom du serveur web",                                      // FR
      "Web sunucusu adı"};                                       // TR

    public static readonly string[] ServerAddressTip = {
      "The URL for the web server that processes requests to model wall assemblies. \r\n" +
        "Only for BoxToWall and BoxToVector commands",
      "URL-адрес для web-сервера, который обрабатывает запросы на моделирование сборок стен. \r\n" +
        "Только для команд BoxToWall и BoxToVector",
      "L'URL del server Web che elabora le richieste per modellare gli assiemi di muri. \r\n" +
        "Solo per i comandi BoxToWall e BoxToVector",
      "Die URL für den Webserver, der Anfragen zum Modellieren von Wandbaugruppen verarbeitet. \r\n" +
        "Nur für die Befehle BoxToWall und BoxToVector",
      "处理模型墙组件请求的 Web 服务器的 URL。仅适用于 BoxToWall 和 BoxToVector 命令",
      "La URL del servidor web que procesa solicitudes para modelar ensamblajes de muros. \r\n" +  // ES
        "Solo para los comandos BoxToWall y BoxToVector",
      "L'URL du serveur web qui traite les demandes de modélisation d'assemblages de murs. \r\n" +  // FR
        "Uniquement pour les commandes BoxToWall et BoxToVector",
      "Duvar montajlarını modellemek için istekleri işleyen web sunucusunun URL'si. \r\n" +  // TR
        "Yalnızca BoxToWall ve BoxToVector komutları için"};

    public static readonly string[] RequestFile = {
      "Request file",
      "Запрашивать файл",
      "Richiedi file",
      "Datei anfordern",
      "请求文件",
      "Solicitar archivo",                                       // ES
      "Demander le fichier",                                     // FR
      "Dosya iste"};                                             // TR

    public static readonly string[] RequestFileTip = {
      "Call the file open dialog every time you call the BoxFromTable command",
      "Вызывать диалог открытия файла при каждом вызове команды BoxFromTable",
      "Richiama la finestra di dialogo di apertura del file ogni volta che chiami il comando BoxFromTable",
      "Rufen Sie den Datei-Öffnen-Dialog jedes Mal auf, wenn Sie den BoxFromTable-Befehl aufrufen",
      "每次调用 BoxFromTable 命令时调用文件打开对话框",
      "Llamar al diálogo de apertura de archivo cada vez que se llama al comando BoxFromTable",  // ES
      "Appeler la boîte de dialogue d'ouverture de fichier à chaque appel de la commande BoxFromTable",  // FR
      "BoxFromTable komutu her çağrıldığında dosya açma iletişim kutusunu çağırın"};  // TR

    public static readonly string[] Expose = {
      "Expose assemblies",
      "Выставить сборки",
      "Esporre le assemblee",
      "Baugruppen verfügbar machen",
      "暴露程序集",
      "Exponer ensamblajes",                                     // ES
      "Exposer les assemblages",                                 // FR
      "Montajları ortaya çıkar"};                                // TR

    public static readonly string[] ExposeTip = {
      "Call the Expose command to insert all created assemblies in a row in an empty space of the model.\r\n" +
        "The quantity will always be indicated as 1, even if the table is set to insert new blocks into the drawing.",
      "Вызвать команду Expose для вставки всех созданных сборок в ряд в свободном месте модели.\r\n" +
        "Количество всегда будет указано 1, даже если в таблице задана вставка новых блоков в чертеж.",
      "Chiama il comando Esponi per inserire tutti gli assiemi creati in una riga in uno spazio vuoto del modello.\r\n" +
        "La quantità verrà sempre indicata come 1, \r\n" +
        "anche se la tabella è predisposta per inserire nuovi blocchi nel disegno.",
      "Rufen Sie den Befehl 'Expose' auf, \r\n" +
        "um alle erstellten Baugruppen in einer Reihe in einen leeren Bereich des Modells einzufügen.\r\n" +
        "Die Menge wird immer als 1 angegeben, auch wenn die Tabelle so eingestellt ist, \r\n" +
        "dass neue Blöcke in die Zeichnung eingefügt werden.",
      "调用 Expose 命令将所有创建的组件插入到模型空白区域的一行中.\r\n" +
        "即使表设置为将新块插入到图形中，数量也将始终指示为 1。",
      "Llamar al comando Expose para insertar todos los ensamblajes creados en una fila en un espacio vacío del modelo.\r\n" +  // ES
        "La cantidad siempre se indicará como 1, incluso si la tabla está configurada para insertar nuevos bloques en el dibujo.",
      "Appeler la commande Expose pour insérer tous les assemblages créés dans une rangée dans un espace vide du modèle.\r\n" +  // FR
        "La quantité sera toujours indiquée comme 1, même si le tableau est configuré pour insérer de nouveaux blocs dans le dessin.",
      "Oluşturulan tüm montajları modelin boş bir alanına bir sıra halinde eklemek için Expose komutunu çağırın.\r\n" +  // TR
        "Tablo yeni blokları çizime eklemeye ayarlanmış olsa bile miktar her zaman 1 olarak belirtilecektir."};

    public static readonly string[] Page = {
      "Excel page",
      "Страница Excel",
      "Pagina Excel",
      "Seite Excel",
      "页 Excel",
      "Página de Excel",                                         // ES
      "Page Excel",                                              // FR
      "Excel sayfası"};                                          // TR

    public static readonly string[] PageTip = {
      "An Excel file page containing a table containing a description of the solid parts. \r\n" +
        "If not specified, the search will be on the first page. Excel files only",
      "Страница файла Excel, на которой находится таблица в описанием солидов-деталей. \r\n" +
        "Если не указана, то поиск будет на первой странице. Только для файлов Excel",
      "Una pagina di file Excel contenente una tabella contenente la descrizione delle parti solide. \r\n" +
        "Se non specificato la ricerca avverrà nella prima pagina. Solo file Excel",
      "Eine Excel-Dateiseite mit einer Tabelle mit einer Beschreibung der Volumenkörperteile. \r\n" +
        "Wenn nicht angegeben, erfolgt die Suche auf der ersten Seite. Nur Excel-Dateien",
      "Excel 文件页面，其中包含一个表格，该表格包含实体零件的描述。如果未指定，搜索将在第一页。仅 Excel 文件",
      "Una página de archivo de Excel que contiene una tabla con la descripción de las piezas sólidas. \r\n" +  // ES
        "Si no se especifica, la búsqueda se realizará en la primera página. Solo archivos de Excel",
      "Une page de fichier Excel contenant un tableau avec la description des pièces solides. \r\n" +  // FR
        "Si non spécifié, la recherche se fera sur la première page. Fichiers Excel uniquement",
      "Katı parçaların açıklamasını içeren bir tablo içeren Excel dosyası sayfası. \r\n" +  // TR
        "Belirtilmezse, arama ilk sayfada yapılacaktır. Yalnızca Excel dosyaları"};

    public static readonly string[] Separator = {
      "CSV column separator",
      "Разделитель столбцов CSV",
      "Separatore di colonne CSV",
      "CSV-Spaltentrennzeichen",
      "CSV 列分隔符",
      "Separador de columnas CSV",                               // ES
      "Séparateur de colonnes CSV",                              // FR
      "CSV sütun ayırıcı"};                                      // TR

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
        "如果该字符在列中使用，则其前面必须带有 \\",
      "Un carácter usado como separador de columnas en archivos CSV y TSV. \r\n" +  // ES
        "Si este carácter se usa dentro de una columna, debe ir precedido por \\",
      "Un caractère utilisé comme séparateur de colonnes dans les fichiers CSV et TSV. \r\n" +  // FR
        "Si ce caractère est utilisé dans une colonne, il doit être précédé de \\",
      "CSV ve TSV dosyalarında sütun ayırıcı olarak kullanılan bir karakter. \r\n" +  // TR
        "Bu karakter bir sütun içinde kullanılırsa, önünde \\ olmalıdır"};

    public static readonly string[] Comma = {
      "Comma",
      "Запятая",
      "Virgola",
      "Komma",
      "逗号",
      "Coma",                                                    // ES
      "Virgule",                                                 // FR
      "Virgül"};                                                 // TR

    public static readonly string[] Semicolon = {
      "Semicolon",
      "Точка с запятой",
      "Punto e virgola",
      "Punkt mit Komma",
      "分号",
      "Punto y coma",                                            // ES
      "Point-virgule",                                           // FR
      "Noktalı virgül"};                                         // TR

    public static readonly string[] BlockLayer = {
      "Block layer",
      "Слой блоков",
      "Strato di blocchi",
      "Blockebene",
      "块层",
      "Capa de bloques",                                         // ES
      "Couche de blocs",                                         // FR
      "Blok katmanı"};                                           // TR

    public static readonly string[] BlockLayerTip = {
      "The layer on which the wall blocks will be inserted in the BoxToWall command. If not specified, the current layer is used.",
      "Слой, на котором будут вставлены блоки стен в команде BoxToWall. Если не указан, используется текущий слой.",
      "Il livello su cui verranno inseriti i blocchi delle pareti nel comando BoxToWall. Se non specificato, viene utilizzato il livello corrente.",
      "Die Ebene, auf der die Wandblöcke im Befehl BoxToWall eingefügt werden. Wenn nicht angegeben, wird die aktuelle Ebene verwendet.",
      "在 BoxToWall 命令中插入墙块的图层。如果未指定，则使用当前图层。",
      "La capa en la que se insertarán los bloques de muro en el comando BoxToWall. Si no se especifica, se usa la capa actual.",  // ES
      "La couche sur laquelle les blocs de mur seront insérés dans la commande BoxToWall. Si non spécifié, la couche actuelle est utilisée.",  // FR
      "BoxToWall komutunda duvar bloklarının ekleneceği katman. Belirtilmezse, mevcut katman kullanılır."};  // TR

    public static readonly string[] UnknownCommand = {
      "Unknown command '{0}'",
      "Неизвестная команда '{0}'",
      "Comando sconosciuto '{0}'",
      "Unbekannter Befehl '{0}'",
      "未知命令'{0}'",
      "Comando desconocido '{0}'",                               // ES
      "Commande inconnue '{0}'",                                 // FR
      "Bilinmeyen komut '{0}'"};                                 // TR

    public static readonly string[] NotImplementedCommand = {
      "The command {0} is not available for calling yet. However, you can request that the program be modified to call this command.",
      "Команда {0} пока не доступна для вызова. Но вы можете запросить доработку программы для вызова этой команды.",
      "Il comando {0} non è ancora disponibile per essere richiamato. Tuttavia, è possibile richiedere che il programma venga modificato per richiamare questo comando.",
      "Der Befehl {0} kann noch nicht aufgerufen werden. Sie können jedoch eine Programmänderung anfordern, um diesen Befehl aufrufen zu können.",
      "命令 {0} 尚不可调用。但是，您可以请求修改程序以调用此命令。",
      "El comando {0} aún no está disponible para llamarse. Sin embargo, puede solicitar que se modifique el programa para llamar a este comando.",  // ES
      "La commande {0} n'est pas encore disponible pour être appelée. Cependant, vous pouvez demander que le programme soit modifié pour appeler cette commande.",  // FR
      "Komut {0} henüz çağrılmak için mevcut değil. Ancak, bu komutu çağırmak için programın değiştirilmesini talep edebilirsiniz."};  // TR
  }
}
