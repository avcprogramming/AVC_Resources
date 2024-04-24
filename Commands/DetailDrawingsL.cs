// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  DetailDrawingsL
  {
    public static readonly string[,] DDrawStyleNames = {
/* 0 */ {
        CommandL.DDraw[0],
        CommandL.DDraw[1],
        CommandL.DDraw[2],
        CommandL.DDraw[3],
        CommandL.DDraw[4]  },
/* 1 */ {
        CommandL.DDraw[0],
        CommandL.DDraw[1],
        CommandL.DDraw[2],
        CommandL.DDraw[3],
        CommandL.DDraw[4]  },
    };

    public static readonly string[] Select = {
      "Select parts or assembly-blocks",
      "Выберите детали или блоки-сборки",
      "Selezionare Parti o Blocchi di assieme",
      "Wählen Sie Teile oder Montageblöcke aus",
      "选择零件或装配体"};
    public static readonly string[] DDrawStyle = {
      "  Detailing-style will be used: {0}",
      "  Будет использован стиль деталировки: {0}",
      "  Stile di dettaglio sarà usato: {0}",
      "  Detaillierungsstil wird verwendet: {0}",
      "  将使用详细样式（DDraw): {0}" };
    public static readonly string[] LoadTemplate = {
      "  Loading a drawing template with sheets...",
      "  Загружается шаблон чертежа с листами...",
      "  Caricamento di un modello di disegno con fogli...",
      "  Laden einer Zeichnungsvorlage mit Plänen...",
      "  正在加载带有布局的图形样板文件..."};
    public static readonly string[] NoFileTemplate = {
      "The drawing template from which to retrieve the sheet template has not been specified",
      "Не задан шаблон чертежа, из которого следует извлекать шаблон листа",
      "Non è stato specificato il modello di disegno da cui recuperare il modello di foglio",
      "Die Zeichnungsvorlage, aus der die Blattvorlage abgerufen werden soll, wurde nicht angegeben",
      "未检索图形样板的布局"};
    public static readonly string[] NoLayoutTemplate = {
      "Sheet template not set",
      "Не задан шаблон листа",
      "Modello di foglio non impostato",
      "Blattvorlage nicht festgelegt",
      "未设置布局模板"};
    public static readonly string[] NoLayoutWithViewportErr = {
      "Error layout inserting: template {0} does not contain any viewport sheets",
      "Ошибка вставки листа: шаблон {0} не содержит ни одного листа с видовыми экранами",
      "Inserimento del layout di errore: il modello {0} non contiene fogli viewport",
      "Fehler beim Einfügen des Layouts: Vorlage {0} enthält keine Darstellungsfensterblätter",
      "插入布局时出错：模板 {0} 不包含任何视口"};
    public static readonly string[] LayoutFoundQuery = {
      "Layout {0} with viewports found in drawing template. \r\n" +
        "Use this layout?",
      "В шаблоне чертежа найден лист {0} с видовыми экранами. \r\n" +
        "Использовать этот лист?",
      "Foglio {0} con finestre trovate nel modello di disegno. \r\n" +
        "Utilizzare questo foglio?",
      "Blatt {0} mit Ansichtsfenstern in Zeichnungsvorlage gefunden. \r\n" +
        "Verwenden Sie dieses Blatt?",
      "图形样板的布局 {0} 中有视口。 \r\n" +
        "使用此模板？"};
    public static readonly string[] LayoutsCreating = {
      "Creating Layouts and Viewports",
      "Создание листов и вьюпортов",
      "Creazione di fogli e finestre",
      "Pläne und Ansichtsfenster erstellen",
      "创建布局和视口"};

    public static readonly string[] ViewportTargeting = {
      "Viewport targeting",
      "Нацеливание вьюпортов",
      "Targeting di visualizzazione",
      "Viewport-Targeting",
      "视口定位"};

    public static readonly string[] AddLayoutErr = {
      "Error creating layout {0}",
      "Ошибка при создании вкладки листа {0}",
      "Errore durante la creazione del foglio {0}",
      "Fehler beim Erstellen des Blatts {0}",
      "创建布局 {0} 时出错"};

    public static readonly string[] EmptyLayoutNameErr = {
      "Layout name pattern '{0}' returned an empty string. The layout will not be renamed.",
      "Шаблон имени листа '{0}' выдал пустую строку. Лист не будет переименован.",
      "Il modello del nome del layout '{0}' ha restituito una stringa vuota. Il layout non verrà rinominato.",
      "Layout-Namensmuster „{0}“ hat eine leere Zeichenfolge zurückgegeben. Das Layout wird nicht umbenannt.",
      "布局名称模式“{0}”返回了一个空字符串。 布局不会重命名。"};

    public static readonly string[] NeedLayoutWithVP = {
      "There are no viewports on sheet {0}. Select a sheet with viewports.",
      "На листе {0} нет ни одного видового экрана. Выбелите лист с видовыми экранами.",
      "Non ci sono finestre sul foglio {0}. Seleziona un foglio con finestre.",
      "Es gibt keine Darstellungsbereiche auf Blatt {0}. Wählen Sie ein Blatt mit Ansichtsfenstern aus.",
      "布局 {0} 上没有视口。 选择带有视口的布局。"};

    public static readonly string[] PartNumberErr = {
      "Too many details({0}). There can only be 255 sheets in one drawing.",
      "Слишком много деталей({0}). В одном чертеже может быть только 255 листов.",
      "Troppi dettagli({0}). Possono esserci solo 255 fogli in un disegno.",
      "Zu viele Details ({0}). Eine Zeichnung darf nur 255 Blätter enthalten.",
      "零件过多 ({0})。 一个dwg文件中只能有 255 个布局(图纸)。"};

    public static readonly string[] PartNumberWarning = {
      "{0} layouts are required to place all parts. \r\n" +
        "This will take a long time and may result in a fatal error. \r\n" +
        "Proceed?",
      "Для размещения всех деталей требуется создать {0} листов. \r\n" +
        "Это займет много времени и может привести к фатальной ошибке. \r\n" +
        "Продолжить?",
      "Sono necessari {0} fogli per posizionare tutte le parti. \r\n" +
        "Ciò richiederà molto tempo e potrebbe causare un errore irreversibile. \r\n" +
        "Procedere?",
      "{0} Blätter sind erforderlich, um alle Teile zu platzieren. \r\n" +
        "Dies dauert sehr lange und kann zu einem fatalen Fehler führen. \r\n" +
        "Fortfahren?",
      "放置所有部件需要 {0} 布局。 \r\n" +
        "这将花费很长时间，并可能导致致命错误。 \r\n" +
        "是否继续？"};

    public static string[] DefaultLayoutName = { // меняем в VARS
      "Det%viewname%",
      "Дет%viewname%",
      "Det%viewname%",
      "Det%viewname%",
      "图%viewname%"};

    // ============================================ Options Box =================================================
    public static readonly string[] DialogTitle = {
      "Detail Drawings command options",
      "Настройки команды Деталировка",
      "Opzioni del comando Disegni dettagliati",
      "Befehlsoptionen für Detailzeichnungen",
      "详图命令选项"};
    public static readonly string[] StyleNameTip = {
      "The name for this Detail Drawing style. Not used in the program. Only for convenience of choice.",
      "Название для этого стиля Деталировки. Не используется в программе. Только для удобства выбора.",
      "Il nome per questo stile Disegni dettagliati. Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Detailzeichnungen-Stil. Wird im Programm nicht verwendet. Nur aus Bequemlichkeit.",
      "此为样式的备注名称。 程序中未使用。 仅为备注。" };
    public static readonly string[] DrawingTemplate = {
      "Drawing template",
      "Шаблон чертежа",
      "Modello di disegno",
      "Zeichnungsvorlage",
      "图形样板"};
    public static readonly string[] DrawingTemplateTip = {
      "A dwg or dwt drawing file to copy sheets from. \r\n" +
        "You can leave it empty - then the template from the General Settings or the template for the _QNew command will be used",
      "Файл чертежа dwg или dwt для копирования из него листов. \r\n" +
        "Можно оставить пустым - тогда будет использован шаблон из Общих Настроек или шаблон для команды _QNew",
      "Un file di disegno dwg o dwt da cui copiare i fogli. \r\n" +
        "Può essere lasciato vuoto, quindi verrà utilizzato il modello delle Impostazioni generali o il modello per il comando _QNew",
      "Eine DWG- oder DWT-Zeichnungsdatei, aus der Pläne kopiert werden können. \r\n" +
        "Kann leer gelassen werden - dann wird die Vorlage aus den Allgemeinen Einstellungen oder die Vorlage für den Befehl _QNew verwendet",
      "用于复制dwt模板文件中的布局。 \r\n" +
        "如果留空 - 将使用 General Settings 中的模板或 _QNew 命令的模板"};
    public static readonly string[] LayoutTemplate = {
      "Layout template",
      "Шаблон листа",
      "Modello di foglio",
      "Blattvorlage",
      "图形样板的布局"};
    public static readonly string[] LayoutTemplateTip = {
      "The name of the sheet to be copied from the drawing template. \r\n" +
        "The sheet must have viewports (at least 1).",
      "Название вкладки листа, который надо копировать из шаблона чертежа. \r\n" +
        "На листе обязательно должны быть вьюпорты (хотя бы 1).",
      "Il nome del foglio da copiare dal modello di disegno. \r\n" +
        "Il foglio deve avere finestre (almeno 1).",
      "Der Name des Blatts, das aus der Zeichnungsvorlage kopiert werden soll. \r\n" +
        "Das Blatt muss Ansichtsfenster haben (mindestens 1).",
      "图形样板文件中的布局名称。 \r\n" +
        "布局中至少要有1个视口。"};
    public static readonly string[] LayoutName = {
      "Name of the new sheet",
      "Имя новой вкладки листа",
      "Nome del nuovo foglio",
      "Name des neuen Blattes",
      "新布局的名称"};
    public static readonly string[] LayoutNameTip = {
      "Rename inserted sheets (tabs). \r\n" +
        "You can use drawing, view, part properties here. \r\n" +
        "If the name matches other sheets, the program will add a number to the end of the name. \r\n" +
        "You can leave an empty line - the program will use the name of the sheet from the template drawing.",
      "Переименовывать вставленные листы (вкладки). \r\n" +
        "Вы можете использовать тут подстановки чертежа, вида, свойства деталей. \r\n" +
        "Если имя совпадет с другими листами, то программа добавит номер в конец названия. \r\n" +
        "Можно оставить пустую строку - программа будет использовать название вкладки из чертежа-шаблона.",
      "Rinomina i fogli inseriti (segnalibri). \r\n" +
        "È possibile utilizzare il disegno, la vista, le proprietà della parte qui. \r\n" +
        "Se il nome corrisponde ad altri fogli, il programma aggiungerà un numero alla fine del nome. \r\n" +
        "Puoi lasciare una riga vuota: il programma utilizzerà il nome del foglio dal disegno del modello.",
      "Eingefügte Blätter (Tab) umbenennen. \r\n" +
        "Sie können hier Zeichnungs-, Ansichts- und Teileeigenschaften verwenden. \r\n" +
        "Wenn der Name mit anderen Blättern übereinstimmt, fügt das Programm am Ende des Namens eine Zahl hinzu. \r\n" +
        "Sie können eine leere Zeile lassen - das Programm verwendet den Namen des Blattes aus der Vorlagenzeichnung.",
      "插入的布局名称（Tab）重命名。 \r\n" +
        "您可以在此处使用图纸、视图、零件属性。 \r\n" +
        "如果名称与其他工作表匹配，程序将在名称末尾添加一个数字。 \r\n" +
        "您可以留空 - 程序将使用模板图中的图纸名称。"};
    public static readonly string[] SameScale = {
      "Same scale",
      "Одинаковый масштаб",
      "Stessa scala",
      "Gleichen Maßstab",
      "相同的比例"};
    public static readonly string[] SameScaleTip = {
      "Same scale for all views on one sheet. \r\n" +
        "The parameter makes sense only if there are several viewports on the sheet.",
      "Одинаковый масштаб для всех видов на одном листе. \r\n" +
        "Параметр имеет смысл, только если на листе несколько вьюпортов.",
      "Stessa scala per tutte le viste su un foglio. \r\n" +
        "Il parametro ha senso solo se sul foglio sono presenti più finestre.",
      "Gleicher Maßstab für alle Ansichten auf einem Blatt. \r\n" +
        "Der Parameter ist nur sinnvoll, wenn mehrere Ansichtsfenster auf dem Blatt vorhanden sind.",
      "一个布局中所有视口的比例相同。 \r\n" +
        "仅当图形样板(模板)的布局中有多个视口时，该选项才有意义。"};
    public static readonly string[] StandardScale = {
      "Standard scale",
      "Стандартный масштаб",
      "Scala standard",
      "Standardmaßstab",
      "标准比例"};
    public static readonly string[] StandardScaleTip = {
      "Use only standard scales. \r\n" +
        "The list of standard scales cannot be edited.",
      "Использовать только стандартные масштабы. \r\n" +
        "Список стандартных масштабов нельзя редактировать.",
      "Utilizzare solo bilance standard. \r\n" +
        "L'elenco delle scale standard non può essere modificato.",
      "Verwenden Sie nur Standardwaagen. \r\n" +
        "Die Liste der Standardskalen kann nicht bearbeitet werden.",
      "仅使用标准比例。 \r\n" +
        "标准比例列表无法编辑。"};
    public static readonly string[] Contouring = {
      "Make 2D contours of parts for CNC",
      "Делать 2D-контуры деталей для ЧПУ",
      "Crea contorni 2D di parti per CNC",
      "Erstellen Sie 2D-Konturen von Teilen für CNC",
      "为 CNC 制作零件的 2D 轮廓"};
    public static readonly string[] ContouringTip = {
      "Make flat contours suitable for CNC machining. \r\n" +
        "Use the CNC-Prepare style to customize the outline and name the layers.",
      "Делать плоские контуры, пригодные для обработки на ЧПУ. \r\n" +
        "Для настройки оконтуривания и наименования слоев используйте стиль ЧПУ-Подготовки.",
      "Crea contorni piatti adatti alla lavorazione CNC. \r\n" +
        "Utilizzare lo stile CNC-Prepare per personalizzare il contorno e assegnare un nome ai livelli.",
      "Machen Sie flache Konturen für die CNC-Bearbeitung geeignet. \r\n" +
        "Verwenden Sie den CNC-Vorbereitungsstil, um den Umriss anzupassen und die Ebenen zu benennen.",
      "制作适合 CNC 加工的平面轮廓。 \r\n" +
        "使用 CNC-Prepare 样式自定义轮廓并命名图层。"};
    public static readonly string[] FillTables = {
      "Fill in the tables",
      "Заполнить таблицы",
      "Compila le tabelle",
      "Füllen Sie die Tabellen aus",
      "填写表格"};
    public static readonly string[] FillTablesTip = {
      "If there are tables in the sheet template and their title matches one of the styles of the data extraction commands, \r\n" +
        "then the program will try to fill the tables with data from all viewports.",
      "Если в шаблоне листа есть таблицы и их заголовок совпадает с одним из стилей команд извлечения данных, \r\n" +
        "то программа будет пытаться заполнить таблицы данными из всех вьюпортов.",
      "Se sono presenti tabelle nel modello di foglio e il loro titolo corrisponde a uno degli stili dei comandi di estrazione dei dati, \r\n" +
        "il programma proverà a riempire le tabelle con i dati di tutte le finestre.",
      "Wenn Tabellen in der Blattvorlage vorhanden sind und deren Titel mit einem der Stile der Datenextraktionsbefehle übereinstimmt, \r\n" +
        "versucht das Programm, die Tabellen mit Daten aus allen Ansichtsfenstern zu füllen.",
      "如果工作表模板中有表格并且它们的标题与数据提取命令的样式之一匹配，\r\n" +
        "则程序将尝试使用来自所有视口的数据填充表格。"};
    public static readonly string[] Attributes = {
      "Fill in block attributes",
      "Заполнить атрибуты блоков",
      "Compila gli attributi del blocco",
      "Füllen Sie die Blockattribute aus",
      "填写块属性"};
    public static readonly string[] AttributesTip = {
      "If there are blocks with variable attributes in the sheet template, \r\n" +
        "then the program will take the default values of these attributes and try to perform all substitutions. \r\n" +
        "You can use drawing, sheet, view and all parts substitutions",
      "Если в шаблоне листа есть блоки с изменяемыми атрибутами, \r\n" +
        "то программа возьмет значения по умолчанию этих атрибутов и попробует выполнить все подстановки. \r\n" +
        "Вы можете использовать подстановки чертежа, листа, вида и всех деталей",
      "Se il modello di foglio contiene blocchi con attributi variabili, \r\n" +
        "il programma prenderà i valori predefiniti di questi attributi e proverà a eseguire tutte le sostituzioni. \r\n" +
        "È possibile utilizzare il disegno, il foglio, la vista e tutte le sostituzioni delle parti",
      "Wenn die Blattvorlage Blöcke mit variablen Attributen enthält, \r\n" +
        "nimmt das Programm die Standardwerte dieser Attribute und versucht, alle Ersetzungen durchzuführen. \r\n" +
        "Sie können Zeichnungs-, Blatt-, Ansichts- und alle Teileersetzungen verwenden",
      "如果工作表模板包含具有可变属性的块，\r\n" +
        "则程序将采用这些属性的默认值并尝试执行所有替换。 \r\n" +
        "您可以使用图纸、图纸、视图和所有零件替换"};


    //public static readonly string[] _ = {
    //  "",
    //  "",
    //  "",
    //  "",
    //  ""};


  }
}
