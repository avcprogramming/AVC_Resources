// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  NumberingL
  {
    // ============================ Numbering Style ================================================================
    public static readonly string[][] NumCmdStyleNames = {
      CommandL.Numbering,
      new []{ "Continuous numbering",
        "Сквозная нумерация",
        "Numerazione continua",
        "Fortlaufende Nummerierung",
        "连续编号",
        "Numeración continua",                         // ES
        "Numérotation continue",                       // FR
        "Sürekli numaralama" },                        // TR
      new []{ "Block numbering",
        "Нумерация по блокам",
        "Numerazione dei blocchi",
        "Blocknummerierung",
        "块编号",
        "Numeración de bloques",                       // ES
        "Numérotation des blocs",                      // FR
        "Blok numaralandırma" },                       // TR
      new []{ "Texts from left to right",
        "Тексты с лева на право",
        "Texts. Da sinistra a destra",
        "Texte. Von links nach rechts",
        "文本.从左到右",
        "Textos de izquierda a derecha",               // ES
        "Textes de gauche à droite",                   // FR
        "Soldan sağa metinler" },                      // TR
      };

    public static readonly string[][] MNumStyleNames = {
      CommandL.MNum,
      new []{ "Number name or content",
        "Нумеровать имя или контент",
        "Nome del numero o contenuto",
        "Nummernname oder Inhalt",
        "号码名称或内容",
        "Número nombre o contenido",                   // ES
        "Numéro nom ou contenu",                       // FR
        "Numara adı veya içerik" },                    // TR
      new []{ "Number block attribute",
        "Нумеровать атрибут блока",
        "Attributo del blocco numerico",
        "Nummernblockattribut",
        "编号块属性",
        "Atributo de bloque numérico",                 // ES
        "Attribut de bloc numérique",                  // FR
        "Blok öznitelik numarası" },                   // TR
      };

    public static readonly string[][] CNumStyleNames = {
      CommandL.CNum,
      new []{ "Number name or content",
        "Нумеровать имя или контент",
        "Nome del numero o contenuto",
        "Nummernname oder Inhalt",
        "号码名称或内容",
        "Número nombre o contenido",                   // ES
        "Numéro nom ou contenu",                       // FR
        "Numara adı veya içerik" },                    // TR
      new []{ "Number block attribute",
        "Нумеровать атрибут блока",
        "Attributo del blocco numerico",
        "Nummernblockattribut",
        "编号块属性",
        "Atributo de bloque numérico",                 // ES
        "Attribut de bloc numérique",                  // FR
        "Blok öznitelik numarası" },                   // TR
      PropL.Texts,
      };

    public static readonly string[] PrefixPrompt =    {
      "\n  Enter Prefix for numbering: ",
      "\n  Введите Префикс для нумерации: ",
      "\n  Inserisci il prefisso per la numerazione: ",
      "\n  Präfix für Nummerierung eingeben: ",
      "\n 输入编号前缀：",
      "\n  Ingrese el prefijo para la numeración: ",   // ES
      "\n  Entrez le préfixe pour la numérotation : ", // FR
      "\n  Numaralandırma için önek girin: " };        // TR

    public static readonly string[] NameOrText = {
      "Name or Text",
      "Имя или Текст",
      "Nome o Testo",
      "Name oder Text",
      "名称或文字",
      "Nombre o texto",                                // ES
      "Nom ou texte",                                  // FR
      "Ad veya metin" };                               // TR

    public static readonly string[] PartNum = {
      "Part number",
      "Номер детали",
      "Detail number",
      "Detailnummer",
      "零件号",
      "Número de pieza",                               // ES
      "Numéro de pièce",                               // FR
      "Parça numarası"};                               // TR

    public static readonly string[] SelectObjects = {
      "Select objects to number",
      "Выберите объекты для нумерации",
      "Seleziona gli oggetti da numerare",
      "Wählen Sie die zu nummerierenden Objekte aus",
      "选择要编号的对象",
      "Seleccione objetos para numerar",               // ES
      "Sélectionnez les objets à numéroter",           // FR
      "Numaralandırılacak nesneleri seçin"};           // TR

    //============================== Numbering Command Line & Warnings ========================================

    public static readonly string[] NoLicense = {
      "You are not licensed to use the Numbering command. The option will be disabled.",
      "У вас нет лицензии на использование команды Нумерация. Опция будет отключена.",
      "Non sei autorizzato a utilizzare il comando Numerazione. L'opzione sarà disabilitata.",
      "Sie sind nicht lizenziert, den Nummerierungsbefehl zu verwenden. Die Option wird deaktiviert.",
      "您没有使用编号命令的许可。 该选项将被禁用。",
      "No tiene licencia para usar el comando de Numeración. La opción se deshabilitará.",  // ES
      "Vous n'êtes pas autorisé à utiliser la commande de Numérotation. L'option sera désactivée.",  // FR
      "Numaralandırma komutunu kullanma lisansınız yok. Seçenek devre dışı bırakılacaktır." };  // TR

    public static readonly string[] NumberingOver = {
      "  Numbering over at the number {0}",
      "  Пронумеровано до детали номер {0}",
      "  Numerazione al numero {0}",
      "  Nummerierung bei der Nummer {0}",
      "  继续从 {0} 开始编号",
      "  Numeración hasta el número {0}",              // ES
      "  Numérotation jusqu'au numéro {0}",            // FR
      "  Numara {0}'a kadar numaralandırıldı" };       // TR

    public static readonly string[] StyleSelected = {
      "  The style '{0}' will be used for selection, sorting and numbering.",
      "  Для отбора, сортировки и нумерации будет использован стиль '{0}'.",
      "  Lo stile '{0}' verrà utilizzato per la selezione, l'ordinamento e la numerazione.",
      "  Zur Auswahl, Sortierung und Nummerierung wird der Stil '{0}' verwendet.",
      "  将使用'{0}'样式用于选择、排序和编号。",
      "  Se utilizará el estilo '{0}' para selección, ordenación y numeración.",  // ES
      "  Le style '{0}' sera utilisé pour la sélection, le tri et la numérotation.",  // FR
      "  Seçim, sıralama ve numaralandırma için '{0}' stili kullanılacaktır." };  // TR

    public static readonly string[] Info = {
      "  Property numbering {1} will start from number {0}. Overwriting = {2}",
      "  Нумерация свойства {1} начнется с номера {0}. Перезапись = {2}",
      "  La numerazione della proprietà {1} inizierà dal numero {0}. Sovrascrittura = {2}",
      "  Die Objektnummerierung {1} beginnt mit der Nummer {0}. Umschreiben = {2}",
      "  属性编号 {1} 将从编号 {0} 开始。 覆盖 = {2}",
      "  La numeración de propiedad {1} comenzará desde el número {0}. Sobrescribir = {2}",  // ES
      "  La numérotation de propriété {1} commencera à partir du numéro {0}. Écraser = {2}",  // FR
      "  Özellik numaralandırması {1} numara {0}'dan başlayacak. Üzerine yazma = {2}" };  // TR

    public static readonly string[] HighlightErr = {
      "  Failed to highlight unnamed objects",
      "  Не удалось подсветить безымянные объекты",
      "  Impossibile evidenziare oggetti senza nome",
      "  Fehler beim Hervorheben unbenannter Objekte",
      "  无法突出显示未命名的对象",
      "  No se pudieron resaltar objetos sin nombre",  // ES
      "  Échec de la mise en évidence des objets sans nom",  // FR
      "  Adsız nesneler vurgulanamadı" };              // TR

    public static readonly string[] SNNPrompt = {
      "Select objects you want to search for unnamed",
      "Выберите объекты для поиска безымянных",
      "Selezionare gli oggetti da cercare senza nome",
      "Wählen Sie Objekte aus, nach denen Sie unbenannt suchen möchten",
      "选择要搜索的未命名对象",
      "Seleccione objetos que desee buscar sin nombre",  // ES
      "Sélectionnez les objets que vous souhaitez rechercher sans nom",  // FR
      "Adsız aramak istediğiniz nesneleri seçin" };    // TR

    public static readonly string[] AllNamed = {
      "Ok. All objects have names",
      "Ок. Все объекты уже имеют имена",
      "Ok. Tutti gli oggetti hanno nomi",
      "In Ordnung. Alle Objekte haben Namen",
      "OK。 所有对象都有名称",
      "Ok. Todos los objetos tienen nombres",          // ES
      "Ok. Tous les objets ont des noms",              // FR
      "Tamam. Tüm nesnelerin adları var" };            // TR

    public static readonly string[] Found = {
      "Found objects: {0}",
      "Найдено объектов: {0}",
      "Oggetti trovati: {0}",
      "Gefundene Objekte: {0}",
      "找到的对象：{0}",
      "Objetos encontrados: {0}",                      // ES
      "Objets trouvés : {0}",                          // FR
      "Bulunan nesneler: {0}" };                       // TR

    public static readonly string[] BlockNotForTextNumbering = {
      "Block '{0}' does not contain a single visible non-constant attribute and will therefore not be numbered.",
      "Блок '{0}' не содержит единственного видимого не-константного атрибута и поэтому не будет пронумерован",
      "Il blocco '{0}' non contiene un singolo attributo visibile non const e pertanto non verrà numerato",
      "Der Block '{0}' enthält kein einziges sichtbares nicht-konstantes Attribut und wird daher nicht nummeriert",
      "块'{0}'不包含单个可见的非常量属性，因此不会被编号",
      "El bloque '{0}' no contiene un solo atributo visible no constante y, por lo tanto, no será numerado.",  // ES
      "Le bloc '{0}' ne contient pas un seul attribut visible non constant et ne sera donc pas numéroté.",  // FR
      "Blok '{0}' tek bir görünür sabit olmayan öznitelik içermiyor ve bu nedenle numaralandırılmayacaktır." };  // TR

    public static readonly string[] BlockHasNoAttribute = {
      "Block '{0}' does not contain the non-constant attribute {1} and therefore will not be numbered",
      "Блок '{0}' не содержит не-константного атрибута {1} и поэтому не будет пронумерован",
      "Il blocco '{0}' non contiene l'attributo non const {1} e pertanto non verrà numerato",
      "Der Block '{0}' enthält nicht das nicht konstante Attribut {1} und wird daher nicht nummeriert",
      "块'{0}'不包含非常量属性 {1}，因此不会编号",
      "El bloque '{0}' no contiene el atributo no constante {1} y, por lo tanto, no será numerado",  // ES
      "Le bloc '{0}' ne contient pas l'attribut non constant {1} et ne sera donc pas numéroté",  // FR
      "Blok '{0}' sabit olmayan {1} özniteliğini içermiyor ve bu nedenle numaralandırılmayacak" };  // TR

    public static readonly string[] NotNumber = {
      "The old object name '{0}' does not look like a number and therefore object '{1}' will not be renumbered.",
      "Старое имя объекта '{0}' не похоже на цифру и поэтому объект '{1}' не будет перенумерован.",
      "Il vecchio nome dell'oggetto '{0}' non sembra un numero e pertanto l'oggetto '{1}' non verrà rinumerato.",
      "Der alte Objektname '{0}' sieht nicht wie eine Zahl aus und daher wird das Objekt '{1}' nicht neu nummeriert.",
      "旧对象名称'{0}'与数字不同，因此对象'{1}'不会被重新编号。",
      "El nombre del objeto antiguo '{0}' no parece un número y, por lo tanto, el objeto '{1}' no será renumerado.",  // ES
      "L'ancien nom d'objet '{0}' ne ressemble pas à un nombre et par conséquent l'objet '{1}' ne sera pas renuméroté.",  // FR
      "Eski nesne adı '{0}' bir sayıya benzemiyor ve bu nedenle '{1}' nesnesi yeniden numaralandırılmayacak." };  // TR

    //=============================== Manual Numbering =========================================================
    //=============================== Command Line & Warnings ==================================================

    public static readonly string[] ObjectQuery = {
      "Click on object number {0}",
      "Кликните по объекту номер {0}",
      "Fare clic sul numero dell'oggetto {0}",
      "Klicken Sie auf die Objektnummer {0}",
      "点击对象编号 {0}",
      "Haga clic en el número de objeto {0}",          // ES
      "Cliquez sur le numéro d'objet {0}",             // FR
      "Nesne numarası {0}'e tıklayın"};                // TR

    public static readonly string[] Numbered = {
      "Numbered {0}. {1}='{2}'",
      "Пронумерован {0}. {1}='{2}'",
      "Numerato {0}. {1}='{2}'",
      "Nummeriert {0}. {1}='{2}'",
      "编号为 {0}。{1}='{2}'",
      "Numerado {0}. {1}='{2}'",                       // ES
      "Numéroté {0}. {1}='{2}'",                       // FR
      "Numaralandırıldı {0}. {1}='{2}'"};              // TR

    public static readonly string[] TemplateErr = {
      "The numbering template produces the same names for different numbers. Correct the template.",
      "Шаблон нумерации выдает одинаковые имена для разных номеров. Исправьте шаблон.",
      "Il modello di numerazione produce gli stessi nomi per numeri diversi. Correggi il modello.",
      "Die Nummerierungsvorlage erzeugt die gleichen Namen für verschiedene Nummern. Korrigieren Sie die Vorlage.",
      "编号模板为不同的编号生成相同的名称。 更正模板。",
      "La plantilla de numeración produce los mismos nombres para diferentes números. Corrija la plantilla.",  // ES
      "Le modèle de numérotation produit les mêmes noms pour différents numéros. Corrigez le modèle.",  // FR
      "Numaralandırma şablonu farklı numaralar için aynı adları üretir. Şablonu düzeltin."};  // TR

    public static readonly string[] StartInfo = {
      "  Property numbering {1} will start from number {0}.",
      "  Нумерация свойства {1} начнется с номера {0}.",
      "  La numerazione della proprietà {1} inizierà dal numero {0}.",
      "  Die Objektnummerierung {1} beginnt mit der Nummer {0}.",
      "  属性编号 {1} 将从编号 {0} 开始。",
      "  La numeración de propiedad {1} comenzará desde el número {0}.",  // ES
      "  La numérotation de propriété {1} commencera à partir du numéro {0}.",  // FR
      "  Özellik numaralandırması {1} numara {0}'dan başlayacak."};  // TR

    public static readonly string[] ReadObjErr = {
      "Failed to read data about object {0}",
      "Не удалось прочитать данные об объекте {0}",
      "Impossibile leggere i dati sull'oggetto {0}",
      "Fehler beim Lesen der Daten zu Objekt {0}",
      "无法读取有关对象 {0} 的数据",
      "No se pudieron leer los datos sobre el objeto {0}",  // ES
      "Échec de la lecture des données sur l'objet {0}",  // FR
      "Nesne {0} hakkında veri okunamadı"};            // TR

    public static readonly string[] PropErr = {
      "Object '{0}' cannot be substituted with a number in property {1}",
      "Объекту '{0}' невозможно подставить номер в свойство {1}",
      "L'oggetto '{0}' non può essere sostituito con un numero nella proprietà {1}",
      "Objekt '{0}' kann in Eigenschaft {1} nicht durch eine Zahl ersetzt werden",
      "对象 {0} 不能用属性 {1} 中的数字代替",
      "El objeto '{0}' no puede sustituirse con un número en la propiedad {1}",  // ES
      "L'objet '{0}' ne peut pas être remplacé par un nombre dans la propriété {1}",  // FR
      "Nesne '{0}' özellik {1}'de bir sayı ile değiştirilemez"};  // TR

    public static readonly string[] SameName = {
      "Block {0} will retain its old name",
      "Блок {0} сохранит свое старое имя",
      "Il blocco {0} manterrà il suo vecchio nome",
      "Block {0} behält seinen alten Namen",
      "块 {0} 将保留其旧名称",
      "El bloque {0} conservará su nombre antiguo",    // ES
      "Le bloc {0} conservera son ancien nom",         // FR
      "Blok {0} eski adını koruyacak"};                // TR

    public static readonly string[] RepeatKW = {
      "REPEAT",
      "ПОВТОРИТЬ",
      "RIPETERE",
      "Wiederholen",
      "重复(R)",
      "REPETIR",                                       // ES
      "RÉPÉTER",                                       // FR
      "TEKRARLA"};                                     // TR

    //=============================== Curve Numbering =========================================================
    //=============================== Command Line & Warnings ==================================================

    public static readonly string[] FindInterceptions = {
      "Finding intersections of all drawing objects with a given curve",
      "Поиск пересечений всех объектов чертежа с заданной кривой",
      "Trovare le intersezioni di tutti gli oggetti del disegno con una determinata curva",
      "Schnittpunkte aller Zeichnungsobjekte mit einer bestimmten Kurve finden",
      "查找所有绘图对象与给定曲线的交点",
      "Encontrando intersecciones de todos los objetos del dibujo con una curva dada",  // ES
      "Recherche des intersections de tous les objets du dessin avec une courbe donnée",  // FR
      "Belirli bir eğri ile tüm çizim nesnelerinin kesişimlerini bulma" };  // TR

    public static readonly string[] NotOnCurve = {
      "Unable to get position of object '{0}' on curve. Object is not numbered.",
      "Не удалось получить положение объекта '{0}' на кривой. Объект не пронумерован.",
      "Impossibile ottenere la posizione dell'oggetto '{0}' sulla curva. L'oggetto non è numerato.",
      "Die Position des Objekts '{0}' auf der Kurve konnte nicht ermittelt werden. Das Objekt ist nicht nummeriert.",
      "无法获取曲线上对象'{0}'的位置。该对象没有编号。",
      "No se puede obtener la posición del objeto '{0}' en la curva. El objeto no está numerado.",  // ES
      "Impossible d'obtenir la position de l'objet '{0}' sur la courbe. L'objet n'est pas numéroté.",  // FR
      "Eğri üzerinde '{0}' nesnesinin konumu alınamıyor. Nesne numaralandırılmamış." };  // TR

    //=============================== Numbering options ========================================================

    public static readonly string[] AlphabetTip = {
      "Select one of the %row% substitution formats.\r\n" +
        "Note that to update non-numeric numbering, you must select the Overwrite All.",
      "Выберите один из форматов для подстановки %row%.\r\n" +
        "Учтите, что для обновления нецифровой нумерации необходимо установить флажок 'Перезаписать все'.",
      "Seleziona uno dei formati di sostituzione %row%.\r\n" +
        "Si noti che per aggiornare la numerazione non numerica, è necessario selezionare il 'Aggiorna tutti'.",
      "Wählen Sie eines der %row%-Ersetzungsformate aus.\r\n" +
        "Beachten Sie, dass Sie zum Aktualisieren der nicht numerischen Nummerierung die auswählen müssen\r\n" +
        "Alles überschreiben.",
      "选择一种 %row% 替换格式。请注意，要更新非数字编号，您必须选择 全部覆盖。",
      "Seleccione uno de los formatos de sustitución %row%.\r\n" +  // ES
        "Tenga en cuenta que para actualizar la numeración no numérica, debe seleccionar Sobrescribir todo.",
      "Sélectionnez l'un des formats de substitution %row%.\r\n" +  // FR
        "Notez que pour mettre à jour la numérotation non numérique, vous devez sélectionner Écraser tout.",
      "%row% değiştirme biçimlerinden birini seçin.\r\n" +  // TR
        "Sayısal olmayan numaralandırmayı güncellemek için Tümünün Üzerine Yaz'ı seçmeniz gerektiğini unutmayın." };

    public static readonly string[] Continue = {
      "Continue from",
      "Продолжить с",
      "Continua da",
      "Weiter von",
      "继续从",
      "Continuar desde",                               // ES
      "Continuer depuis",                              // FR
      "Devam et" };                                    // TR

    public static readonly string[] ContinueTip = {
      "Use the number specified earlier for the start of numbering, not one.",
      "Использовать для начала нумерации заданный ранее номер, а не единицу.",
      "Utilizzare il numero specificato in precedenza per l'inizio della numerazione, non uno.",
      "Verwenden Sie die zuvor angegebene Nummer für den Beginn der Nummerierung, nicht eine.",
      "使用指定的数字作为编号的开始，而不是从1开始。",
      "Use el número especificado anteriormente para el inicio de la numeración, no uno.",  // ES
      "Utilisez le numéro spécifié précédemment pour le début de la numérotation, pas un.",  // FR
      "Numaralandırmanın başlangıcı için daha önce belirtilen numarayı kullanın, bir değil." };  // TR

    public static readonly string[] DestinationTip = {
      "You can select the property of the drawing object to which numbers will be written. \r\n" +
        "By default, this is the name of the object.",
      "Вы можете выбрать свойство объекта чертежа, в которое будут записываться номера. \r\n" +
        "По умолчанию - это имя объекта.",
      "È possibile selezionare la proprietà dell'oggetto di disegno su cui verranno scritti i numeri. \r\n" +
        "Per impostazione predefinita, questo è il nome dell'oggetto.",
      "Sie können die Eigenschaft des Zeichenobjekts auswählen, in die Zahlen geschrieben werden.\r\n" +
        "Standardmäßig ist dies der Name des Objekts.",
      "您可以选择要写入数字的图形对象属性。\r\n" +
        "默认情况下，这是对象的名称。",
      "Puede seleccionar la propiedad del objeto de dibujo en la que se escribirán los números. \r\n" +  // ES
        "De forma predeterminada, este es el nombre del objeto.",
      "Vous pouvez sélectionner la propriété de l'objet de dessin dans laquelle les numéros seront écrits. \r\n" +  // FR
        "Par défaut, c'est le nom de l'objet.",
      "Sayıların yazılacağı çizim nesnesinin özelliğini seçebilirsiniz. \r\n" +  // TR
        "Varsayılan olarak, bu nesnenin adıdır." };

    public static readonly string[] PrefixQuery = {
      "Prompt for prefix",
      "Запрос Префикса",
      "Richiedi il prefisso",
      "Nach Präfix fragen",
      "提示输入前缀",
      "Solicitar prefijo",                             // ES
      "Demander le préfixe",                           // FR
      "Önek iste" };                                   // TR

    public static readonly string[] PrefixQueryTip = {
      "The program may ask you for additional text (prefix), \r\n" +
        "which will be inserted before each number.\r\n" +
        "Use this function to avoid changing the template every time.",
      "Программа может запрашивать вас дополнительный текст (префикс), \r\n" +
        "который будет вставлен перед каждым номером.\r\n" +
        "Используйте эту функцию, чтоб не менять шаблон каждый раз.",
      "Il programma potrebbe richiedere del testo aggiuntivo (prefisso), \r\n" +
        "che verrà inserito prima di ogni numero.\r\n" +
        "Utilizzare questa funzione per evitare di cambiare ogni volta il modello.",
      "Das Programm fragt Sie möglicherweise nach zusätzlichem Text (Präfix),\r\n" +
        "die vor jeder Zahl eingefügt wird.\r\n" +
        "Verwenden Sie diese Funktion, um nicht jedes Mal die Vorlage ändern zu müssen.",
      "该程序会要求您输入其他文本（前缀），它将被插入到每个数字之前。\r\n" +
        "使用此功能可避免每次更改模板。",
      "El programa puede solicitarle texto adicional (prefijo), \r\n" +  // ES
        "que se insertará antes de cada número.\r\n" +
        "Use esta función para evitar cambiar la plantilla cada vez.",
      "Le programme peut vous demander du texte supplémentaire (préfixe), \r\n" +  // FR
        "qui sera inséré avant chaque numéro.\r\n" +
        "Utilisez cette fonction pour éviter de changer le modèle à chaque fois.",
      "Program sizden ek metin (önek) isteyebilir, \r\n" +  // TR
        "bu her sayıdan önce eklenecektir.\r\n" +
        "Her seferinde şablonu değiştirmekten kaçınmak için bu işlevi kullanın." };

    public static readonly string[] Rewrite = {
      "Update all",
      "Перезаписать",
      "Aggiorna tutti",
      "Alle aktualisieren",
      "全部更新",
      "Actualizar todo",                               // ES
      "Tout mettre à jour",                            // FR
      "Tümünü güncelle" };                             // TR

    public static readonly string[] RewriteTip = {
      "If uncheck the program check that solid have not the name or the name is a number. \r\n" +
        "Non-numeric names are not overwritten, because you gave name to solid manually.\r\n" +
        "But the number would still be missed.",
      "Если сбросить галочку, то программа, прежде чем дать имя солиду, \r\n" +
        "проверит, что у него нет имени или это имя является цифрой.\r\n" +
        "Нецифровые имена не перезаписываются, т.к. вы дали имя солиду\r\n" +
        "вручную. Это имя будет сохранено, но номер все равно будет пропущен.\r\n" +
        "В режиме алфавитной нумерации требуется всегда включать эту опцию.",
      "Se si deseleziona questa bandiera il programma controlla questo\r\n" +
        "il solido non ha il nome o il nome è un numero.\r\n" +
        "I nomi non numerici non vengono sovrascritti,\r\n" +
        "perché hai dato il nome a mani solide.\r\n" +
        "Ma il numero sarebbe ancora mancato.",
      "Wenn Sie das Programm deaktivieren, überprüfen Sie, \r\n" +
        "ob Solids nicht den Namen haben oder der Name eine Nummer ist.\r\n" +
        "Nicht-numerische Namen werden nicht überschrieben, \r\n" +
        "da Sie solid manuell einen Namen gegeben haben.\r\n" +
        "Aber die Nummer würde trotzdem fehlen.",
      "如果取消选中程序检查实体没有名称或名称是数字。\r\n" +
        "非数字名称不会被覆盖，因为您手动为三维实体 命名。\r\n" +
        "但仍然会错过这个数字。",
      "Si desmarca, el programa verifica que el sólido no tenga nombre o que el nombre sea un número. \r\n" +  // ES
        "Los nombres no numéricos no se sobrescriben, porque dio nombre al sólido manualmente.\r\n" +
        "Pero el número aún se omitirá.",
      "Si vous décochez, le programme vérifie que le solide n'a pas de nom ou que le nom est un nombre. \r\n" +  // FR
        "Les noms non numériques ne sont pas écrasés, car vous avez donné un nom au solide manuellement.\r\n" +
        "Mais le numéro sera toujours manqué.",
      "İşareti kaldırırsanız, program katının adının olmadığını veya adın bir sayı olduğunu kontrol eder. \r\n" +  // TR
        "Sayısal olmayan adlar üzerine yazılmaz, çünkü katıya manuel olarak ad verdiniz.\r\n" +
        "Ancak numara yine de kaçırılacaktır." };

    public static readonly string[] TemplateTip = {
      "The template must contain a %row% substitution, in which the number will be inserted. \r\n" +
        "You can also use any other substitutions for the properties of the drawing object and any text.\r\n" +
        "The %row% substitution can be formatted as an integer. For example:\r\n" +
        "%row:000% - always 3 characters with leading zeros.\r\n" +
        "%row:X% - hexadecimal numbers.\r\n" +
        "%row:ROMAN% - Roman numerals.\r\n" +
        "%row:ALPHABET% - Alphabetical english letters.\r\n" +
        "%row:CIRYLLIC% - Russian alphabet.",
      "Шаблон должен содержать подстановку %row%, на месте которой будет вставлен номер.\r\n" +
        "Так же вы можете использовать любые другие подстановки свойств объекта чертежа и любой текст.\r\n" +
        "Подстановку %row% можно форматировать как целое число. Например:\r\n" +
        "%row:000% - всегда 3 знака с нулями в начале.\r\n" +
        "%row:X% - шеснадцетиричные числа.\r\n" +
        "%row:ROMAN% - римские цифры.\r\n" +
        "%row:ALPHABET% - английские буквы по алфавилу.\r\n" +
        "%row:CIRYLLIC% - русский алфавит.",
      "Il modello deve contenere una sostituzione %row%, nella quale verrà inserito il numero.\r\n" +
        "È inoltre possibile utilizzare qualsiasi altra sostituzione \r\n" +
        "per le proprietà dell'oggetto disegno e qualsiasi testo.\r\n" +
        "La sostituzione %row% può essere formattata come un numero intero. Per esempio:\r\n" +
        "%row:000% - sempre 3 caratteri con zeri iniziali.\r\n" +
        "%row:X% - numeri esadecimali.\r\n" +
        "%row:ROMAN% - Numeri romani.\r\n" +
        "%row:ALPHABET% - Lettere alfabetiche inglesi.\r\n" +
        "%row:CIRYLLIC% - Alfabeto russo.",
      "Die Vorlage muss eine %row%-Ersetzung enthalten, in die die Zahl eingefügt wird.\r\n" +
        "Sie können auch beliebige andere Ersetzungen für die Eigenschaften \r\n" +
        "des Zeichenobjekts und beliebigen Text verwenden.\r\n" +
        "Die %row%-Ersetzung kann als ganze Zahl formatiert werden. Zum Beispiel:\r\n" +
        "%row:000% - immer 3 Zeichen mit führenden Nullen.\r\n" +
        "%row:X% - Hexadezimalzahlen.\r\n" +
        "%row:ROMAN% - Römische Ziffern.\r\n" +
        "%row:ALPHABET% - Alphabetische englische Buchstaben.\r\n" +
        "%row:CIRYLLIC% - Russisches Alphabet.",
      "模板必须包含 %row% 替换，其中将插入数字。\r\n" +
        "您还可以对绘图对象和任何文本的属性使用任何其他替换。\r\n" +
        "%row% 替换可以格式化为整数。 例如：\r\n" +
        "%row:000% - 总是 3 个带前导零的字符。\r\n" +
        "%row:X% - 十六进制数。\r\n" +
        "%row:ROMAN% - 罗马数字。\r\n" +
        "%row:ALPHABET% - 按字母顺序排列的英文字母。\r\n" +
        "%row:CIRYLLIC% - 俄语字母表。",
      "La plantilla debe contener una sustitución %row%, en la que se insertará el número. \r\n" +  // ES
        "También puede usar cualquier otra sustitución para las propiedades del objeto de dibujo y cualquier texto.\r\n" +
        "La sustitución %row% se puede formatear como un número entero. Por ejemplo:\r\n" +
        "%row:000% - siempre 3 caracteres con ceros a la izquierda.\r\n" +
        "%row:X% - números hexadecimales.\r\n" +
        "%row:ROMAN% - Números romanos.\r\n" +
        "%row:ALPHABET% - Letras alfabéticas en inglés.\r\n" +
        "%row:CIRYLLIC% - Alfabeto ruso.",
      "Le modèle doit contenir une substitution %row%, dans laquelle le numéro sera inséré. \r\n" +  // FR
        "Vous pouvez également utiliser toute autre substitution pour les propriétés de l'objet de dessin et tout texte.\r\n" +
        "La substitution %row% peut être formatée comme un entier. Par exemple :\r\n" +
        "%row:000% - toujours 3 caractères avec des zéros en tête.\r\n" +
        "%row:X% - nombres hexadécimaux.\r\n" +
        "%row:ROMAN% - Chiffres romains.\r\n" +
        "%row:ALPHABET% - Lettres alphabétiques anglaises.\r\n" +
        "%row:CIRYLLIC% - Alphabet russe.",
      "Şablon, numaranın ekleneceği bir %row% değiştirmesi içermelidir. \r\n" +  // TR
        "Ayrıca çizim nesnesinin özellikleri ve herhangi bir metin için başka değiştirmeler de kullanabilirsiniz.\r\n" +
        "%row% değiştirmesi bir tam sayı olarak biçimlendirilebilir. Örneğin:\r\n" +
        "%row:000% - her zaman başında sıfır olan 3 karakter.\r\n" +
        "%row:X% - onaltılık sayılar.\r\n" +
        "%row:ROMAN% - Roma rakamları.\r\n" +
        "%row:ALPHABET% - Alfabetik İngilizce harfler.\r\n" +
        "%row:CIRYLLIC% - Rus alfabesi." };

    public static readonly string[] Through = {
      "Through",
      "Сквозная",
      "Attraverso",
      "Durch",
      "通过",
      "Continua",                                      // ES
      "Continue",                                      // FR
      "Sürekli" };                                     // TR

    public static readonly string[] ThroughTip = {
      "End-to-end numbering of parts through all groups of parts. \r\n" +
        "If you disable this setting, then in each group the numbering will start from 1. \r\n" +
        "Usually, this option is disabled when parts are grouped into blocks, \r\n" +
        "when the %block% substitution is written in the Group field.",
      "Сквозная нумерация деталей через все группы деталей. \r\n" +
        "Если отключить эту настройку, то в каждой группе нумерация будет начинаться с 1.\r\n" +
        "Обычно эту опцию отключают, когда производится группировка деталей по блокам (в поле Группа подстановка %block%)",
      "Numerazione end-to-end delle parti attraverso tutti i gruppi di parti. \r\n" +
        "Se disabiliti questa impostazione, in ogni gruppo la numerazione inizierà da 1. \r\n" +
        "Di solito, questa opzione è disabilitata quando le parti sono raggruppate in blocchi, \r\n" +
        "quando la sostituzione %blocco% è scritta nel campo Gruppo.",
      "Durchgehende Nummerierung der Teile über alle Teilegruppen hinweg. \r\n" +
        "Wenn Sie diese Einstellung deaktivieren, beginnt die Nummerierung in jeder Gruppe bei 1. \r\n" +
        "Normalerweise ist diese Option deaktiviert, wenn Teile nach Blöcken gruppiert werden, \r\n" +
        "wenn die %block%-Ersetzung in das Gruppenfeld geschrieben wird.",
      "通过所有零件组对零件进行端到端编号。 \r\n" +
        "如果禁用此设置，则每个组中的编号将从 1 开始。\r\n" +
        "通常，当部件分组为块时，当 %block% 替换写入组字段时，此选项被禁用。",
      "Numeración continua de piezas a través de todos los grupos de piezas. \r\n" +  // ES
        "Si deshabilita esta configuración, en cada grupo la numeración comenzará desde 1. \r\n" +
        "Normalmente, esta opción se deshabilita cuando las piezas se agrupan en bloques, \r\n" +
        "cuando se escribe la sustitución %block% en el campo Grupo.",
      "Numérotation de bout en bout des pièces à travers tous les groupes de pièces. \r\n" +  // FR
        "Si vous désactivez ce paramètre, dans chaque groupe la numérotation commencera à partir de 1. \r\n" +
        "Généralement, cette option est désactivée lorsque les pièces sont regroupées en blocs, \r\n" +
        "lorsque la substitution %block% est écrite dans le champ Groupe.",
      "Tüm parça grupları boyunca parçaların uçtan uca numaralandırılması. \r\n" +  // TR
        "Bu ayarı devre dışı bırakırsanız, her grupta numaralandırma 1'den başlayacaktır. \r\n" +
        "Genellikle, parçalar bloklara gruplandığında bu seçenek devre dışı bırakılır, \r\n" +
        "%block% değiştirmesi Grup alanına yazıldığında." };

    public static readonly string[] StartTip = {
      "Number for the first detail.\r\n" +
        "For alphabetical numbering, 1 is A, 2 is B, and so on.\r\n" +
        "The number is saved in the drawing properties\r\n" +
        "and is automatically updated after each call to the numbering program.",
      "Номер для первой детали.\r\n" +
        "Для алфавитной нумерации 1 - это A, 2 - это B, и так далее.\r\n" +
        "Номер сохраняется в свойствах чертежа \r\n" +
        "и обновляется автоматически после каждого вызова программы нумерации.",
      "Numero per il primo dettaglio.\r\n" +
        "Per la numerazione alfabetica, 1 è A, 2 è B e così via.\r\n" +
        "Il numero viene salvato nelle proprietà del disegno\r\n" +
        "e viene aggiornato automaticamente dopo ogni chiamata al programma di numerazione.",
      "Nummer für das erste Detail.\r\n" +
        "Bei der alphabetischen Nummerierung ist 1 A, 2 B und so weiter.\r\n" +
        "Die Nummer wird in den Zeichnungseigenschaften gespeichert\r\n" +
        "und wird nach jedem Aufruf des Nummerierungsprogramms automatisch aktualisiert.",
      "第一个详细信息的编号。\r\n" +
        "对于字母编号，1 是 A，2 是 B，依此类推。\r\n" +
        "编号保存在图纸属性中并在每次调用编号程序后自动更新。",
      "Número para el primer detalle.\r\n" +  // ES
        "Para la numeración alfabética, 1 es A, 2 es B, y así sucesivamente.\r\n" +
        "El número se guarda en las propiedades del dibujo\r\n" +
        "y se actualiza automáticamente después de cada llamada al programa de numeración.",
      "Numéro pour le premier détail.\r\n" +  // FR
        "Pour la numérotation alphabétique, 1 est A, 2 est B, et ainsi de suite.\r\n" +
        "Le numéro est enregistré dans les propriétés du dessin\r\n" +
        "et est automatiquement mis à jour après chaque appel au programme de numérotation.",
      "İlk ayrıntı için numara.\r\n" +  // TR
        "Alfabetik numaralandırma için, 1 A'dır, 2 B'dir, vb.\r\n" +
        "Numara çizim özelliklerinde kaydedilir\r\n" +
        "ve numaralandırma programına her çağrıdan sonra otomatik olarak güncellenir." };

    public static readonly string[] Alphabet = {
      "Numbers",
      "Цифры",
      "Numeri",
      "Zahlen",
      "数字",
      "Números",                                       // ES
      "Nombres",                                       // FR
      "Sayılar" };                                     // TR

    public static readonly string[] Destination = {
      "Write into",
      "Записать в",
      "Scrivi in",
      "Schreiben Sie hinein",
      "写入",
      "Escribir en",                                   // ES
      "Écrire dans",                                   // FR
      "Yaz" };                                         // TR

    public static readonly string[] Template = {
      "Template",
      "Шаблон",
      "Modello",
      "Schablone",
      "模板",
      "Plantilla",                                     // ES
      "Modèle",                                        // FR
      "Şablon" };                                      // TR

    public static readonly string[] UpdateMetrics = {
      "Update metrics",
      "Обновить метрики",
      "Aggiorna metriche",
      "Metriken aktualisieren",
      "更新指标",
      "Actualizar métricas",                           // ES
      "Mettre à jour les métriques",                   // FR
      "Metrikleri güncelle" };                         // TR

    public static readonly string[] UpdateMetricsTip = {
      "Force measure even those parts that already have a metric. \r\n" +
        "This will greatly slow down the work, but guarantees the correct dimensions of the parts.",
      "Принудительно обмерить даже те детали, у которых уже есть метрика. \r\n" +
        "Это сильно замедлит работу, но гарантирует правильные размеры деталей.",
      "Forza misura anche quelle parti che hanno già una metrica. \r\n" +
        "Ciò rallenterà notevolmente il lavoro, ma garantisce le corrette dimensioni delle parti.",
      "Erzwingen Sie eine Messung auch der Teile, die bereits eine Metrik haben. \r\n" +
        "Dies verlangsamt die Arbeit erheblich, garantiert jedoch die korrekten Abmessungen der Teile.",
      "强制测量那些已经有度量标准的部分。 \r\n" +
        "这将大大减慢工作速度，但可以保证零件的正确尺寸。",
      "Forzar la medición incluso de aquellas piezas que ya tienen una métrica. \r\n" +  // ES
        "Esto ralentizará considerablemente el trabajo, pero garantiza las dimensiones correctas de las piezas.",
      "Forcer la mesure même des pièces qui ont déjà une métrique. \r\n" +  // FR
        "Cela ralentira considérablement le travail, mais garantit les dimensions correctes des pièces.",
      "Zaten metriği olan parçaları bile zorla ölçün. \r\n" +  // TR
        "Bu, işi büyük ölçüde yavaşlatacak, ancak parçaların doğru boyutlarını garanti edecektir." };

    public static readonly string[] SelectCurve =    {
      "Select the curve along which the numbering will be performed",
      "Выберите кривую вдоль которой будет производится нумерация",
      "Selezionare la curva lungo la quale verrà effettuata la numerazione",
      "Wählen Sie die Kurve aus, entlang derer die Nummerierung erfolgen soll",
      "选择将沿其进行编号的曲线",
      "Seleccione la curva a lo largo de la cual se realizará la numeración",  // ES
      "Sélectionnez la courbe le long de laquelle la numérotation sera effectuée",  // FR
      "Numaralandırmanın gerçekleştirileceği eğriyi seçin"};  // TR

    //================================ Manual Numbering Options Box ============================================
    public static readonly string[] MNumStyleNameTip = {
      "The name for this manual numbering style.\r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Имя стиля нумерации.\r\n" +
        "Не используется в программе, только для удобства выбора.",
      "Il nome per questo stile di numerazione manuale.\r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen manuellen Nummerierungsstil.\r\n" +
        "Wird im Programm nicht verwendet. Nur für die Bequemlichkeit der Wahl.",
      "此手动编号样式的名称。 " +
        "程序中未使用。 只为方便选择。",
      "El nombre para este estilo de numeración manual.\r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia de elección.",
      "Le nom de ce style de numérotation manuelle.\r\n" +  // FR
        "Non utilisé dans le programme. Uniquement pour la commodité du choix.",
      "Bu manuel numaralandırma stili için ad.\r\n" +  // TR
        "Programda kullanılmaz. Sadece seçim kolaylığı için."};

    public static readonly string[] CNumStyleNameTip = {
      "The name for this numbering style.\r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Имя стиля нумерации.\r\n" +
        "Не используется в программе, только для удобства выбора.",
      "Il nome per questo stile di numerazione.\r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Nummerierungsstil.\r\n" +
        "Wird im Programm nicht verwendet. Nur für die Bequemlichkeit der Wahl.",
      "此编号样式的名称。" +
        "程序中未使用。 只为方便选择。",
      "El nombre para este estilo de numeración.\r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia de elección.",
      "Le nom de ce style de numérotation.\r\n" +  // FR
        "Non utilisé dans le programme. Uniquement pour la commodité du choix.",
      "Bu numaralandırma stili için ad.\r\n" +  // TR
        "Programda kullanılmaz. Sadece seçim kolaylığı için."};

    public static readonly string[] Hide = {
      "Hide numbered object",
      "Скрыть пронумерованный объект",
      "Nascondi oggetto numerato",
      "Nummeriertes Objekt ausblenden",
      "隐藏编号的对象",
      "Ocultar objeto numerado",                       // ES
      "Masquer l'objet numéroté",                      // FR
      "Numaralı nesneyi gizle" };                      // TR

    public static readonly string[] HideTip = {
      "After numbering, the numbered object will disappear from the drawing to avoid re-numbering. \r\n" +
        "The object is not destroyed, it just became invisible. \r\n" +
        "After the end of the command, all hidden objects will again appear in the drawing.",
      "После нумерации пронумерованный объект исчезнет из чертежа во избежание повторной нумерации. \r\n" +
        "Объект не уничтожен, он просто стал невидимым. \r\n" +
        "После окончания команды все скрытые объекты опять появятся в чертеже.",
      "Dopo la numerazione, l'oggetto numerato scomparirà dal disegno per evitare la rinumerazione. \r\n" +
        "L'oggetto non viene distrutto, è semplicemente diventato invisibile. \r\n" +
        "Dopo la fine del comando, tutti gli oggetti nascosti appariranno nuovamente nel disegno.",
      "Nach der Nummerierung verschwindet das nummerierte Objekt aus der Zeichnung, um eine Neunummerierung zu vermeiden. \r\n" +
        "Das Objekt wird nicht zerstört, es wurde nur unsichtbar. \r\n" +
        "Nach Beendigung des Befehls erscheinen alle ausgeblendeten Objekte wieder in der Zeichnung.",
      "编号后，已编号的对象将暂时从图形中消失，以避免重新编号。 \r\n" +
        "该对象没有被破坏，它只是变得不可见。 \r\n" +
        "命令结束后，所有隐藏的对象将再次出现在图形中。",
      "Después de la numeración, el objeto numerado desaparecerá del dibujo para evitar la renumeración. \r\n" +  // ES
        "El objeto no se destruye, simplemente se volvió invisible. \r\n" +
        "Después del final del comando, todos los objetos ocultos volverán a aparecer en el dibujo.",
      "Après la numérotation, l'objet numéroté disparaîtra du dessin pour éviter la renumérotation. \r\n" +  // FR
        "L'objet n'est pas détruit, il est simplement devenu invisible. \r\n" +
        "Après la fin de la commande, tous les objets cachés apparaîtront à nouveau dans le dessin.",
      "Numaralandırmadan sonra, numaralı nesne yeniden numaralandırmayı önlemek için çizimden kaybolacaktır. \r\n" +  // TR
        "Nesne yok edilmez, sadece görünmez hale gelir. \r\n" +
        "Komutun sonundan sonra, tüm gizli nesneler çizimde tekrar görünecektir." };

    public static readonly string[] ObjectsQuery = {
      "Select Objects",
      "Выбирать объекты",
      "Seleziona oggetti",
      "Wählen Sie Objekte aus",
      "选择对象",
      "Seleccionar objetos",                           // ES
      "Sélectionner les objets",                       // FR
      "Nesneleri seç" };                               // TR

    public static readonly string[] ObjectsQueryTip = {
      "Prompt to select objects for numbering. \r\n" +
        "If you disable this option, all objects intersecting with the curve will be numbered.",
      "Запрашивать выбор объектов для нумерации. \r\n" +
        "Если отключить опцию, то будут пронумерованы все объекты, пересекающиеся с кривой",
      "Richiedere la selezione degli oggetti per la numerazione. \r\n" +
        "Se disabiliti l'opzione, tutti gli oggetti che si intersecano con la curva verranno numerati.",
      "Fordern Sie die Auswahl von Objekten zur Nummerierung an. \r\n" +
        "Wenn Sie die Option deaktivieren, werden alle Objekte, die die Kurve schneiden, nummeriert.",
      "请求选择要编号的对象。 \r\n" +
        "如果禁用该选项，所有与曲线相交的对象都将被编号。",
      "Solicitar seleccionar objetos para numerar. \r\n" +  // ES
        "Si deshabilita esta opción, se numerarán todos los objetos que se cruzan con la curva.",
      "Demander de sélectionner des objets à numéroter. \r\n" +  // FR
        "Si vous désactivez cette option, tous les objets qui se croisent avec la courbe seront numérotés.",
      "Numaralandırmak için nesneleri seçme istemi. \r\n" +  // TR
        "Bu seçeneği devre dışı bırakırsanız, eğri ile kesişen tüm nesneler numaralandırılacaktır." };

  }
}