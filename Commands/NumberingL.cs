// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  NumberingL
  {
    // ============================ Numbering Style ================================================================
    public static readonly string[,] NumCmdStyleNames = {
      { CommandL.Numbering[0], CommandL.Numbering[1], CommandL.Numbering[2], CommandL.Numbering[3], CommandL.Numbering[4] },
      { "Continuous numbering", 
        "Сквозная нумерация", 
        "Numerazione continua", 
        "Fortlaufende Nummerierung", 
        "连续编号" },
      { "Block numbering", 
        "Нумерация по блокам", 
        "Numerazione dei blocchi", 
        "Blocknummerierung", 
        "块编号" },
      { "Texts from left to right", 
        "Тексты с лева на право", 
        "Texts. Da sinistra a destra", 
        "Texte. Von links nach rechts", 
        "文本.从左到右" },
      };
    public static readonly string[,] MNumStyleNames = {
      { CommandL.MNum[0], CommandL.MNum[1], CommandL.MNum[2], CommandL.MNum[3], CommandL.MNum[4] },
      { "Number name or content",
        "Нумеровать имя или контент",
        "Nome del numero o contenuto",
        "Nummernname oder Inhalt",
        "号码名称或内容" },
      { "Number block attribute",
        "Нумеровать атрибут блока",
        "Attributo del blocco numerico",
        "Nummernblockattribut",
        "编号块属性" },
      };
    public static readonly string[,] CNumStyleNames = {
      { CommandL.CNum[0], CommandL.CNum[1], CommandL.CNum[2], CommandL.CNum[3], CommandL.CNum[4] },
      { "Number name or content",
        "Нумеровать имя или контент",
        "Nome del numero o contenuto",
        "Nummernname oder Inhalt",
        "号码名称或内容" },
      { "Number block attribute",
        "Нумеровать атрибут блока",
        "Attributo del blocco numerico",
        "Nummernblockattribut",
        "编号块属性" },
      { PropL.Texts[0], PropL.Texts[1], PropL.Texts[2], PropL.Texts[3], PropL.Texts[4] },
      };
    public static readonly string[] PrefixPrompt =    {
      "\n  Enter Prefix for numbering: ",
      "\n  Введите Префикс для нумерации: ",
      "\n  Inserisci il prefisso per la numerazione: ",
      "\n  Präfix für Nummerierung eingeben: ",
      "\n 输入编号前缀：" };
    public static readonly string[] NameOrText = {
      "Name or Text",
      "Имя или Текст",
      "Nome o Testo",
      "Name oder Text",
      "名称或文字" };
    public static readonly string[] PartNum = {
      "Part number",
      "Номер детали",
      "Detail number",
      "Detailnummer",
      "零件号"};
    public static readonly string[] SelectObjects = {
      "Select objects to number",
      "Выберите объекты для нумерации",
      "Seleziona gli oggetti da numerare",
      "Wählen Sie die zu nummerierenden Objekte aus",
      "选择要编号的对象"};

    //============================== Numbering Command Line & Warnings ========================================

    public static readonly string[] NoLicense = {
      "You are not licensed to use the Numbering command. The option will be disabled.",
      "У вас нет лицензии на использование команды Нумерация. Опция будет отключена.",
      "Non sei autorizzato a utilizzare il comando Numerazione. L'opzione sarà disabilitata.",
      "Sie sind nicht lizenziert, den Nummerierungsbefehl zu verwenden. Die Option wird deaktiviert.",
      "您没有使用编号命令的许可。 该选项将被禁用。" };
    public static readonly string[] NumberingOver = {
      "  Numbering over at the number {0}",
      "  Пронумеровано до детали номер {0}",
      "  Numerazione al numero {0}",
      "  Nummerierung bei der Nummer {0}",
      "  继续从 {0} 开始编号" };
    public static readonly string[] StyleSelected = {
      "  The style '{0}' will be used for selection, sorting and numbering.",
      "  Для отбора, сортировки и нумерации будет использован стиль '{0}'.",
      "  Lo stile '{0}' verrà utilizzato per la selezione, l'ordinamento e la numerazione.",
      "  Zur Auswahl, Sortierung und Nummerierung wird der Stil '{0}' verwendet.",
      "  将使用“{0}”样式用于选择、排序和编号。" };
    public static readonly string[] Info = {
      "  Property numbering {1} will start from number {0}. Overwriting = {2}",
      "  Нумерация свойства {1} начнется с номера {0}. Перезапись = {2}",
      "  La numerazione della proprietà {1} inizierà dal numero {0}. Sovrascrittura = {2}",
      "  Die Objektnummerierung {1} beginnt mit der Nummer {0}. Umschreiben = {2}",
      "  属性编号 {1} 将从编号 {0} 开始。 覆盖 = {2}" };
    public static readonly string[] HighlightErr = {
      "  Failed to highlight unnamed objects",
      "  Не удалось подсветить безымянные объекты",
      "  Impossibile evidenziare oggetti senza nome",
      "  Fehler beim Hervorheben unbenannter Objekte",
      "  无法突出显示未命名的对象" };
    public static readonly string[] SNNPrompt = {
      "Select objects you want to search for unnamed",
      "Выберите объекты для поиска безымянных",
      "Selezionare gli oggetti da cercare senza nome",
      "Wählen Sie Objekte aus, nach denen Sie unbenannt suchen möchten",
      "选择要搜索的未命名对象" };
    public static readonly string[] AllNamed = {
      "Ok. All objects have names",
      "Ок. Все объекты уже имеют имена",
      "Ok. Tutti gli oggetti hanno nomi",
      "In Ordnung. Alle Objekte haben Namen",
      "OK。 所有对象都有名称" };
    public static readonly string[] Found = {
      "Found objects: {0}",
      "Найдено объектов: {0}",
      "Oggetti trovati: {0}",
      "Gefundene Objekte: {0}",
      "找到的对象：{0}" };
    public static readonly string[] BlockNotForTextNumbering = {
      "Block '{0}' does not contain a single visible non-constant attribute and will therefore not be numbered.",
      "Блок '{0}' не содержит единственного видимого не-константного атрибута и поэтому не будет пронумерован",
      "Il blocco '{0}' non contiene un singolo attributo visibile non const e pertanto non verrà numerato",
      "Der Block „{0}“ enthält kein einziges sichtbares nicht-konstantes Attribut und wird daher nicht nummeriert",
      "块“{0}”不包含单个可见的非常量属性，因此不会被编号" };
    public static readonly string[] BlockHasNoAttribute = {
      "Block '{0}' does not contain the non-constant attribute {1} and therefore will not be numbered",
      "Блок '{0}' не содержит не-константного атрибута {1} и поэтому не будет пронумерован",
      "Il blocco '{0}' non contiene l'attributo non const {1} e pertanto non verrà numerato",
      "Der Block „{0}“ enthält nicht das nicht konstante Attribut {1} und wird daher nicht nummeriert",
      "块“{0}”不包含非常量属性 {1}，因此不会编号" };
    public static readonly string[] NotNumber = {
      "The old object name '{0}' does not look like a number and therefore object '{1}' will not be renumbered.",
      "Старое имя объекта '{0}' не похоже на цифру и поэтому объект '{1}' не будет перенумерован.",
      "Il vecchio nome dell'oggetto '{0}' non sembra un numero e pertanto l'oggetto '{1}' non verrà rinumerato.",
      "Der alte Objektname „{0}“ sieht nicht wie eine Zahl aus und daher wird das Objekt „{1}“ nicht neu nummeriert.",
      "旧对象名称“{0}”与数字不同，因此对象“{1}”不会被重新编号。" };

    //=============================== Manual Numbering =========================================================
    //=============================== Command Line & Warnings ==================================================

    public static readonly string[] ObjectQuery = {
      "Click on object number {0}",
      "Кликните по объекту номер {0}",
      "Fare clic sul numero dell'oggetto {0}",
      "Klicken Sie auf die Objektnummer {0}",
      "点击对象编号 {0}"};
    public static readonly string[] Numbered = {
      "Numbered {0}. {1}='{2}'",
      "Пронумерован {0}. {1}='{2}'",
      "Numerato {0}. {1}='{2}'",
      "Nummeriert {0}. {1}='{2}'",
      "编号为 {0}。{1}='{2}'"};
    public static readonly string[] TemplateErr = {
      "The numbering template produces the same names for different numbers. Correct the template.",
      "Шаблон нумерации выдает одинаковые имена для разных номеров. Исправьте шаблон.",
      "Il modello di numerazione produce gli stessi nomi per numeri diversi. Correggi il modello.",
      "Die Nummerierungsvorlage erzeugt die gleichen Namen für verschiedene Nummern. Korrigieren Sie die Vorlage.",
      "编号模板为不同的编号生成相同的名称。 更正模板。"};
    public static readonly string[] StartInfo = {
      "  Property numbering {1} will start from number {0}.",
      "  Нумерация свойства {1} начнется с номера {0}.",
      "  La numerazione della proprietà {1} inizierà dal numero {0}.",
      "  Die Objektnummerierung {1} beginnt mit der Nummer {0}.",
      "  属性编号 {1} 将从编号 {0} 开始。"};
    public static readonly string[] ReadObjErr = {
      "Failed to read data about object {0}",
      "Не удалось прочитать данные об объекте {0}",
      "Impossibile leggere i dati sull'oggetto {0}",
      "Fehler beim Lesen der Daten zu Objekt {0}",
      "无法读取有关对象 {0} 的数据"};
    public static readonly string[] PropErr = {
      "Object '{0}' cannot be substituted with a number in property {1}",
      "Объекту '{0}' невозможно подставить номер в свойство {1}",
      "L'oggetto '{0}' non può essere sostituito con un numero nella proprietà {1}",
      "Objekt '{0}' kann in Eigenschaft {1} nicht durch eine Zahl ersetzt werden",
      "对象 {0} 不能用属性 {1} 中的数字代替"};
    public static readonly string[] SameName = {
      "Block {0} will retain its old name",
      "Блок {0} сохранит свое старое имя",
      "Il blocco {0} manterrà il suo vecchio nome",
      "Block {0} behält seinen alten Namen",
      "块 {0} 将保留其旧名称"};
    public static readonly string[] RepeatKW = {
      "REPEAT",
      "ПОВТОРИТЬ",
      "RIPETERE",
      "Wiederholen",
      "重复(R)"};

    //=============================== Curve Numbering =========================================================
    //=============================== Command Line & Warnings ==================================================

    public static readonly string[] FindInterceptions = {
      "Finding intersections of all drawing objects with a given curve",
      "Поиск пересечений всех объектов чертежа с заданной кривой",
      "Trovare le intersezioni di tutti gli oggetti del disegno con una determinata curva",
      "Schnittpunkte aller Zeichnungsobjekte mit einer bestimmten Kurve finden",
      "查找所有绘图对象与给定曲线的交点" };
    public static readonly string[] NotOnCurve = {
      "Unable to get position of object '{0}' on curve. Object is not numbered.",
      "Не удалось получить положение объекта '{0}' на кривой. Объект не пронумерован.",
      "Impossibile ottenere la posizione dell'oggetto '{0}' sulla curva. L'oggetto non è numerato.",
      "Die Position des Objekts „{0}“ auf der Kurve konnte nicht ermittelt werden. Das Objekt ist nicht nummeriert.",
      "无法获取曲线上对象“{0}”的位置。该对象没有编号。" };

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
      "选择一种 %row% 替换格式。请注意，要更新非数字编号，您必须选择 全部覆盖。" };
    public static readonly string[] Continue = {
      "Continue from",
      "Продолжить с",
      "Continua da",
      "Weiter von",
      "继续从" };
    public static readonly string[] ContinueTip = {
      "Use the number specified earlier for the start of numbering, not one.",
      "Использовать для начала нумерации заданный ранее номер, а не единицу.",
      "Utilizzare il numero specificato in precedenza per l'inizio della numerazione, non uno.",
      "Verwenden Sie die zuvor angegebene Nummer für den Beginn der Nummerierung, nicht eine.",
      "使用指定的数字作为编号的开始，而不是从1开始。" };
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
        "默认情况下，这是对象的名称。" };
    public static readonly string[] PrefixQuery = {
      "Prompt for prefix",
      "Запрос Префикса",
      "Richiedi il prefisso",
      "Nach Präfix fragen",
      "提示输入前缀" };
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
        "使用此功能可避免每次更改模板。" };
    public static readonly string[] Rewrite = {
      "Update all",
      "Перезаписать",
      "Aggiorna tutti",
      "Alle aktualisieren",
      "全部更新" };
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
        "但仍然会错过这个数字。" };
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
        "%row:CIRYLLIC% - 俄语字母表。" };
    public static readonly string[] Through = {
      "Through",
      "Сквозная",
      "Attraverso",
      "Durch",
      "通过" };
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
        "通常，当部件分组为块时，当 %block% 替换写入组字段时，此选项被禁用。" };
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
        "编号保存在图纸属性中并在每次调用编号程序后自动更新。" };
    public static readonly string[] Alphabet = {
      "Numbers",
      "Цифры",
      "Numeri",
      "Zahlen",
      "数字" };
    public static readonly string[] Destination = {
      "Write into",
      "Записать в",
      "Scrivi in",
      "Schreiben Sie hinein",
      "写入" };
    public static readonly string[] Template = {
      "Template",
      "Шаблон",
      "Modello",
      "Schablone",
      "模板" };
    public static readonly string[] UpdateMetrics = {
      "Update metrics",
      "Обновить метрики",
      "Aggiorna metriche",
      "Metriken aktualisieren",
      "更新指标" };
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
        "这将大大减慢工作速度，但可以保证零件的正确尺寸。" };
    public static readonly string[] SelectCurve =    {
      "Select the curve along which the numbering will be performed",
      "Выберите кривую вдоль которой будет производится нумерация",
      "Selezionare la curva lungo la quale verrà effettuata la numerazione",
      "Wählen Sie die Kurve aus, entlang derer die Nummerierung erfolgen soll",
      "选择将沿其进行编号的曲线"};


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
        "程序中未使用。 只为方便选择。"};
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
        "程序中未使用。 只为方便选择。"};
    public static readonly string[] Hide = {
      "Hide numbered object",
      "Скрыть пронумерованный объект",
      "Nascondi oggetto numerato",
      "Nummeriertes Objekt ausblenden",
      "隐藏编号的对象" };
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
        "命令结束后，所有隐藏的对象将再次出现在图形中。" };
    public static readonly string[] ObjectsQuery = {
      "Select Objects",
      "Выбирать объекты",
      "Seleziona oggetti",
      "Wählen Sie Objekte aus",
      "选择对象" };
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
        "如果禁用该选项，所有与曲线相交的对象都将被编号。" };

  }
}
