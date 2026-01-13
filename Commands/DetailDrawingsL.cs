// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  DetailDrawingsL
  {
    public static readonly string[][] DDrawStyleNames = {
/* 0 */ CommandL.DDraw,                   
/* 1 */ CommandL.DDraw, };

    public static readonly string[] Select = {
      "Select parts or assembly-blocks",
      "Выберите детали или блоки-сборки",
      "Selezionare Parti o Blocchi di assieme",
      "Wählen Sie Teile oder Montageblöcke aus",
      "选择零件或装配体",
      "Seleccionar piezas o bloques de ensamblaje",              // ES
      "Sélectionner des pièces ou des blocs d'assemblage",       // FR
      "Parçaları veya montaj bloklarını seçin"};                 // TR

    public static readonly string[] DDrawStyle = {
      "  Detailing-style will be used: {0}",
      "  Будет использован стиль деталировки: {0}",
      "  Stile di dettaglio sarà usato: {0}",
      "  Detaillierungsstil wird verwendet: {0}",
      "  将使用详细样式（DDraw): {0}",
      "  Se utilizará el estilo de detalle: {0}",                // ES
      "  Le style de détail sera utilisé : {0}",                 // FR
      "  Detaylandırma stili kullanılacak: {0}" };               // TR

    public static readonly string[] LoadTemplate = {
      "  Loading a drawing template with sheets...",
      "  Загружается шаблон чертежа с листами...",
      "  Caricamento di un modello di disegno con fogli...",
      "  Laden einer Zeichnungsvorlage mit Plänen...",
      "  正在加载带有布局的图形样板文件...",
      "  Cargando una plantilla de dibujo con hojas...",         // ES
      "  Chargement d'un modèle de dessin avec feuilles...",     // FR
      "  Sayfalı çizim şablonu yükleniyor..."};                  // TR

    public static readonly string[] NoFileTemplate = {
      "The drawing template from which to retrieve the sheet template has not been specified",
      "Не задан шаблон чертежа, из которого следует извлекать шаблон листа",
      "Non è stato specificato il modello di disegno da cui recuperare il modello di foglio",
      "Die Zeichnungsvorlage, aus der die Blattvorlage abgerufen werden soll, wurde nicht angegeben",
      "未检索图形样板的布局",
      "No se ha especificado la plantilla de dibujo desde la cual recuperar la plantilla de hoja",  // ES
      "Le modèle de dessin à partir duquel récupérer le modèle de feuille n'a pas été spécifié",   // FR
      "Sayfa şablonunun alınacağı çizim şablonu belirtilmedi"};  // TR

    public static readonly string[] NoLayoutTemplate = {
      "Sheet template not set",
      "Не задан шаблон листа",
      "Modello di foglio non impostato",
      "Blattvorlage nicht festgelegt",
      "未设置布局模板",
      "Plantilla de hoja no establecida",                        // ES
      "Modèle de feuille non défini",                            // FR
      "Sayfa şablonu ayarlanmadı"};                              // TR

    public static readonly string[] NoLayoutWithViewportErr = {
      "Error layout inserting: template '{0}' does not contain any viewport sheets",
      "Ошибка вставки листа: шаблон '{0}' не содержит ни одного листа с видовыми экранами",
      "Inserimento del layout di errore: il modello '{0}' non contiene fogli viewport",
      "Fehler beim Einfügen des Layouts: Vorlage '{0}' enthält keine Darstellungsfensterblätter",
      "插入布局时出错：模板 '{0}' 不包含任何视口",
      "Error al insertar diseño: la plantilla '{0}' no contiene ninguna hoja con ventanas gráficas",  // ES
      "Erreur d'insertion de mise en page : le modèle '{0}' ne contient aucune feuille avec fenêtres",  // FR
      "Düzen ekleme hatası: '{0}' şablonu hiçbir görünüm penceresi sayfası içermiyor"};  // TR

    public static readonly string[] NoLayoutWithViewport = {
      "There are no viewport sheets to use as a template. The program will use sheet {0}.",
      "Нет листов с вьюпортами для использования в качестве шаблона. Программа будет использовать лист {0}.",
      "Non ci sono fogli di visualizzazione da utilizzare come modello. Il programma utilizzerà il foglio {0}.",
      "Es sind keine Ansichtsfensterblätter als Vorlage vorhanden. Das Programm verwendet Blatt {0}.",
      "没有可用作模板的视口表。程序将使用表 {0}。",
      "No hay hojas de ventana gráfica para usar como plantilla. El programa usará la hoja {0}.",  // ES
      "Il n'y a pas de feuilles de fenêtre à utiliser comme modèle. Le programme utilisera la feuille {0}.",  // FR
      "Şablon olarak kullanılacak görünüm penceresi sayfası yok. Program {0} sayfasını kullanacak." };  // TR

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
        "使用此模板？",
      "Diseño {0} con ventanas gráficas encontrado en plantilla de dibujo. \r\n" +  // ES
        "¿Usar este diseño?",
      "Mise en page {0} avec fenêtres trouvée dans le modèle de dessin. \r\n" +     // FR
        "Utiliser cette mise en page ?",
      "Çizim şablonunda görünüm pencereleri olan {0} düzeni bulundu. \r\n" +        // TR
        "Bu düzeni kullan?"};

    public static readonly string[] LayoutsCreating = {
      "Creating Layouts and Viewports",
      "Создание листов и вьюпортов",
      "Creazione di fogli e finestre",
      "Pläne und Ansichtsfenster erstellen",
      "创建布局和视口",
      "Creando diseños y ventanas gráficas",                     // ES
      "Création de mises en page et de fenêtres",                // FR
      "Düzenler ve görünüm pencereleri oluşturuluyor"};          // TR

    public static readonly string[] VPForAssembliesCreating = {
      "Creating Viewports for Assemblies",
      "Создание вьюпортов для сборок",
      "Creazione di finestre per assiemi",
      "Erstellen von Ansichtsfenstern für Baugruppen",
      "为装配体创建视口",
      "Creando ventanas gráficas para ensamblajes",              // ES
      "Création de fenêtres pour les assemblages",               // FR
      "Montajlar için görünüm pencereleri oluşturuluyor"};       // TR

    public static readonly string[] ViewportTargeting = {
      "Viewport targeting",
      "Нацеливание вьюпортов",
      "Targeting di visualizzazione",
      "Viewport-Targeting",
      "视口定位",
      "Orientación de ventanas gráficas",                        // ES
      "Ciblage des fenêtres",                                    // FR
      "Görünüm penceresi hedefleme"};                            // TR

    public static readonly string[] AddLayoutErr = {
      "Error creating layout {0}",
      "Ошибка при создании вкладки листа {0}",
      "Errore durante la creazione del foglio {0}",
      "Fehler beim Erstellen des Blatts {0}",
      "创建布局 {0} 时出错",
      "Error al crear diseño {0}",                               // ES
      "Erreur lors de la création de la mise en page {0}",       // FR
      "Düzen {0} oluşturulurken hata"};                          // TR

    public static readonly string[] EmptyLayoutNameErr = {
      "Layout name pattern '{0}' returned an empty string. The layout will not be renamed.",
      "Шаблон имени листа '{0}' выдал пустую строку. Лист не будет переименован.",
      "Il modello del nome del layout '{0}' ha restituito una stringa vuota. Il layout non verrà rinominato.",
      "Layout-Namensmuster '{0}' hat eine leere Zeichenfolge zurückgegeben. Das Layout wird nicht umbenannt.",
      "布局名称模式'{0}'返回了一个空字符串。 布局不会重命名。",
      "El patrón de nombre de diseño '{0}' devolvió una cadena vacía. El diseño no se renombrará.",  // ES
      "Le modèle de nom de mise en page '{0}' a retourné une chaîne vide. La mise en page ne sera pas renommée.",  // FR
      "Düzen adı deseni '{0}' boş bir dize döndürdü. Düzen yeniden adlandırılmayacak."};  // TR

    public static readonly string[] NeedLayoutWithVP = {
      "There are no viewports on sheet {0}. Select a sheet with viewports.",
      "На листе {0} нет ни одного видового экрана. Выберите лист с видовыми экранами.",
      "Non ci sono finestre sul foglio {0}. Seleziona un foglio con finestre.",
      "Es gibt keine Darstellungsbereiche auf Blatt {0}. Wählen Sie ein Blatt mit Ansichtsfenstern aus.",
      "布局 {0} 上没有视口。 选择带有视口的布局。",
      "No hay ventanas gráficas en la hoja {0}. Seleccione una hoja con ventanas gráficas.",  // ES
      "Il n'y a pas de fenêtres sur la feuille {0}. Sélectionnez une feuille avec des fenêtres.",  // FR
      "Sayfa {0} üzerinde görünüm penceresi yok. Görünüm pencereleri olan bir sayfa seçin."};  // TR

    public static readonly string[] PartNumberErr = {
      "Too many details({0}). There can only be 255 sheets in one drawing.",
      "Слишком много деталей({0}). В одном чертеже может быть только 255 листов.",
      "Troppi dettagli({0}). Possono esserci solo 255 fogli in un disegno.",
      "Zu viele Details ({0}). Eine Zeichnung darf nur 255 Blätter enthalten.",
      "零件过多 ({0})。 一个dwg文件中只能有 255 个布局(图纸)。",
      "Demasiados detalles ({0}). Solo puede haber 255 hojas en un dibujo.",  // ES
      "Trop de détails ({0}). Il ne peut y avoir que 255 feuilles dans un dessin.",  // FR
      "Çok fazla detay ({0}). Bir çizimde yalnızca 255 sayfa olabilir."};  // TR

    public static readonly string[] LayoutNumberWarning = {
      "{0} layouts are required to place all drawings. \r\n" +
        "This will take a long time and may result in a fatal error. \r\n" +
        "Proceed?",
      "Для размещения всех чертежей требуется создать {0} листов. \r\n" +
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
        "是否继续？",
      "Se requieren {0} diseños para colocar todos los dibujos. \r\n" +                // ES
        "Esto llevará mucho tiempo y puede resultar en un error fatal. \r\n" +
        "¿Continuar?",
      "{0} mises en page sont nécessaires pour placer tous les dessins. \r\n" +        // FR
        "Cela prendra beaucoup de temps et peut entraîner une erreur fatale. \r\n" +
        "Continuer ?",
      "Tüm çizimleri yerleştirmek için {0} düzen gereklidir. \r\n" +                   // TR
        "Bu uzun zaman alacak ve ölümcül bir hataya neden olabilir. \r\n" +
        "Devam et?"};

    public static string[] DefaultLayoutName = { // меняем в VARS
      "Det%viewtargetname%",
      "Дет%viewtargetname%",
      "Det%viewtargetname%",
      "Det%viewtargetname%",
      "图%viewtargetname%",
      "Det%viewtargetname%",                                     // ES
      "Dét%viewtargetname%",                                     // FR
      "Det%viewtargetname%"};                                    // TR

    // ============================================ Options Box =================================================
    public static readonly string[] DialogTitle = {
      "Detail Drawings command options",
      "Настройки команды Деталировка",
      "Opzioni del comando Disegni dettagliati",
      "Befehlsoptionen für Detailzeichnungen",
      "详图命令选项",
      "Opciones del comando de dibujos de detalle",              // ES
      "Options de la commande de dessins de détail",             // FR
      "Detay çizimleri komutu seçenekleri"};                     // TR

    public static readonly string[] StyleNameTip = {
      "The name for this Detail Drawing style. Not used in the program. Only for convenience of choice.",
      "Название для этого стиля Деталировки. Не используется в программе. Только для удобства выбора.",
      "Il nome per questo stile Disegni dettagliati. Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Detailzeichnungen-Stil. Wird im Programm nicht verwendet. Nur aus Bequemlichkeit.",
      "此为样式的备注名称。 程序中未使用。 仅为备注。",
      "El nombre para este estilo de Dibujos de Detalle. No se usa en el programa. Solo por conveniencia de elección.",  // ES
      "Le nom de ce style de Dessins de Détail. Non utilisé dans le programme. Seulement pour la commodité du choix.",  // FR
      "Bu Detay Çizimleri stili için ad. Programda kullanılmaz. Sadece seçim kolaylığı için." };  // TR

    public static readonly string[] DrawingTemplate = {
      "Drawing template",
      "Шаблон чертежа",
      "Modello di disegno",
      "Zeichnungsvorlage",
      "图形样板",
      "Plantilla de dibujo",                                     // ES
      "Modèle de dessin",                                        // FR
      "Çizim şablonu"};                                          // TR

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
        "如果留空 - 将使用 General Settings 中的模板或 _QNew 命令的模板",
      "Un archivo de dibujo dwg o dwt desde el cual copiar hojas. \r\n" +              // ES
        "Puede dejarlo vacío; entonces se usará la plantilla de Configuración general o la plantilla para el comando _QNew",
      "Un fichier de dessin dwg ou dwt à partir duquel copier des feuilles. \r\n" +    // FR
        "Vous pouvez le laisser vide - alors le modèle des Paramètres généraux ou le modèle pour la commande _QNew sera utilisé",
      "Sayfaların kopyalanacağı bir dwg veya dwt çizim dosyası. \r\n" +                // TR
        "Boş bırakabilirsiniz - o zaman Genel Ayarlar'dan şablon veya _QNew komutu için şablon kullanılacaktır"};

    public static readonly string[] LayoutTemplate = {
      "Layout template",
      "Шаблон листа",
      "Modello di foglio",
      "Blattvorlage",
      "图形样板的布局",
      "Plantilla de diseño",                                     // ES
      "Modèle de mise en page",                                  // FR
      "Düzen şablonu"};                                          // TR

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
        "布局中至少要有1个视口。",
      "El nombre de la hoja que se copiará de la plantilla de dibujo. \r\n" +          // ES
        "La hoja debe tener ventanas gráficas (al menos 1).",
      "Le nom de la feuille à copier à partir du modèle de dessin. \r\n" +             // FR
        "La feuille doit avoir des fenêtres (au moins 1).",
      "Çizim şablonundan kopyalanacak sayfanın adı. \r\n" +                            // TR
        "Sayfada görünüm pencereleri olmalıdır (en az 1)."};

    public static readonly string[] LayoutName = {
      "Name of the new sheet",
      "Имя новой вкладки листа",
      "Nome del nuovo foglio",
      "Name des neuen Blattes",
      "新布局的名称",
      "Nombre de la nueva hoja",                                 // ES
      "Nom de la nouvelle feuille",                              // FR
      "Yeni sayfanın adı"};                                      // TR

    public static readonly string[] LayoutNameTip = {
      "Rename inserted sheets (tabs). \r\n" +
        "You can use drawing, layout, view, part properties here. \r\n" +
        "If the name matches other sheets, the program will add a number to the end of the name. \r\n" +
        "You can leave an empty line - the program will use the name of the sheet from the template drawing.",
      "Переименовывать вкладки новых листов. \r\n" +
        "Вы можете использовать тут подстановки чертежа, листа, видов, свойства деталей. \r\n" +
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
        "您可以留空 - 程序将使用模板图中的图纸名称。",
      "Renombrar hojas insertadas (pestañas). \r\n" +                                   // ES
        "Puede usar aquí propiedades de dibujo, diseño, vista, pieza. \r\n" +
        "Si el nombre coincide con otras hojas, el programa agregará un número al final del nombre. \r\n" +
        "Puede dejar una línea vacía: el programa usará el nombre de la hoja de la plantilla de dibujo.",
      "Renommer les feuilles insérées (onglets). \r\n" +                               // FR
        "Vous pouvez utiliser ici les propriétés de dessin, de mise en page, de vue, de pièce. \r\n" +
        "Si le nom correspond à d'autres feuilles, le programme ajoutera un numéro à la fin du nom. \r\n" +
        "Vous pouvez laisser une ligne vide - le programme utilisera le nom de la feuille du dessin modèle.",
      "Eklenen sayfaları (sekmeleri) yeniden adlandırın. \r\n" +                       // TR
        "Burada çizim, düzen, görünüm, parça özelliklerini kullanabilirsiniz. \r\n" +
        "Ad diğer sayfalarla eşleşirse, program adın sonuna bir sayı ekleyecektir. \r\n" +
        "Boş bir satır bırakabilirsiniz - program şablon çiziminden sayfanın adını kullanacaktır."};

    public static readonly string[] SameScale = {
      "Same scale",
      "Одинаковый масштаб",
      "Stessa scala",
      "Gleichen Maßstab",
      "相同的比例",
      "Misma escala",                                            // ES
      "Même échelle",                                            // FR
      "Aynı ölçek"};                                             // TR

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
        "仅当图形样板(模板)的布局中有多个视口时，该选项才有意义。",
      "Misma escala para todas las vistas en una hoja. \r\n" +                         // ES
        "El parámetro tiene sentido solo si hay varias ventanas gráficas en la hoja.",
      "Même échelle pour toutes les vues sur une feuille. \r\n" +                      // FR
        "Le paramètre n'a de sens que s'il y a plusieurs fenêtres sur la feuille.",
      "Bir sayfadaki tüm görünümler için aynı ölçek. \r\n" +                           // TR
        "Parametre yalnızca sayfada birden fazla görünüm penceresi varsa anlamlıdır."};

    public static readonly string[] StandardScale = {
      "Standard scale",
      "Стандартный масштаб",
      "Scala standard",
      "Standardmaßstab",
      "标准比例",
      "Escala estándar",                                         // ES
      "Échelle standard",                                        // FR
      "Standart ölçek"};                                         // TR

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
        "标准比例列表无法编辑。",
      "Usar solo escalas estándar. \r\n" +                                             // ES
        "La lista de escalas estándar no se puede editar.",
      "Utiliser uniquement des échelles standard. \r\n" +                              // FR
        "La liste des échelles standard ne peut pas être modifiée.",
      "Yalnızca standart ölçekleri kullanın. \r\n" +                                   // TR
        "Standart ölçekler listesi düzenlenemez."};

    public static readonly string[] Contouring = {
      "Make 2D contours of parts for CNC",
      "Делать 2D-контуры деталей для ЧПУ",
      "Crea contorni 2D di parti per CNC",
      "Erstellen Sie 2D-Konturen von Teilen für CNC",
      "为 CNC 制作零件的 2D 轮廓",
      "Hacer contornos 2D de piezas para CNC",                   // ES
      "Créer des contours 2D de pièces pour CNC",                // FR
      "CNC için parçaların 2D konturlarını yapın"};              // TR

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
        "使用 CNC-Prepare 样式自定义轮廓并命名图层。",
      "Hacer contornos planos adecuados para mecanizado CNC. \r\n" +                   // ES
        "Use el estilo CNC-Prepare para personalizar el contorno y nombrar las capas.",
      "Créer des contours plats adaptés à l'usinage CNC. \r\n" +                       // FR
        "Utilisez le style CNC-Prepare pour personnaliser le contour et nommer les calques.",
      "CNC işleme için uygun düz konturlar yapın. \r\n" +                              // TR
        "Konturu özelleştirmek ve katmanları adlandırmak için CNC-Prepare stilini kullanın."};

    public static readonly string[] FillTables = {
      "Fill in the tables",
      "Заполнить таблицы",
      "Compila le tabelle",
      "Füllen Sie die Tabellen aus",
      "填写表格",
      "Llenar las tablas",                                       // ES
      "Remplir les tableaux",                                    // FR
      "Tabloları doldurun"};                                     // TR

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
        "则程序将尝试使用来自所有视口的数据填充表格。",
      "Si hay tablas en la plantilla de hoja y su título coincide con uno de los estilos de los comandos de extracción de datos, \r\n" +  // ES
        "entonces el programa intentará llenar las tablas con datos de todas las ventanas gráficas.",
      "S'il y a des tableaux dans le modèle de feuille et que leur titre correspond à l'un des styles des commandes d'extraction de données, \r\n" +  // FR
        "alors le programme essaiera de remplir les tableaux avec des données de toutes les fenêtres.",
      "Sayfa şablonunda tablolar varsa ve başlıkları veri çıkarma komutlarının stillerinden biriyle eşleşiyorsa, \r\n" +  // TR
        "o zaman program tabloları tüm görünüm pencerelerinden gelen verilerle doldurmaya çalışacaktır."};

    public static readonly string[] FillAttributes = {
      "Fill in block attributes",
      "Заполнить атрибуты блоков",
      "Compila gli attributi del blocco",
      "Füllen Sie die Blockattribute aus",
      "填写块属性",
      "Llenar atributos de bloques",                             // ES
      "Remplir les attributs de blocs",                          // FR
      "Blok özniteliklerini doldurun"};                          // TR

    public static readonly string[] FillAttributesTip = {
      "If there are blocks with variable attributes in the sheet template, \r\n" +
        "then the program will perform all the substitutions and fill in these attributes. \r\n" +
        "You can use drawing, sheet, view and all parts substitutions",
      "Если в шаблоне листа есть блоки с изменяемыми атрибутами, \r\n" +
        "то программа выполнить все подстановки и заполнит эти атрибуты. \r\n" +
        "Вы можете использовать подстановки чертежа, листа, вида и всех деталей",
      "Se il modello di foglio contiene blocchi con attributi variabili, \r\n" +
        "quindi il programma eseguirà tutte le sostituzioni e compilerà questi attributi. \r\n" +
        "È possibile utilizzare il disegno, il foglio, la vista e tutte le sostituzioni delle parti",
      "Wenn die Blattvorlage Blöcke mit variablen Attributen enthält, \r\n" +
        "dann führt das Programm alle Ersetzungen durch und füllt diese Attribute aus. \r\n" +
        "Sie können Zeichnungs-, Blatt-, Ansichts- und alle Teileersetzungen verwenden",
      "如果工作表模板包含具有可变属性的块，\r\n" +
        "然后程序将执行所有替换并填充这些属性。 \r\n" +
        "您可以使用图纸、图纸、视图和所有零件替换",
      "Si hay bloques con atributos variables en la plantilla de hoja, \r\n" +          // ES
        "entonces el programa realizará todas las sustituciones y llenará estos atributos. \r\n" +
        "Puede usar sustituciones de dibujo, hoja, vista y todas las piezas",
      "S'il y a des blocs avec des attributs variables dans le modèle de feuille, \r\n" +  // FR
        "alors le programme effectuera toutes les substitutions et remplira ces attributs. \r\n" +
        "Vous pouvez utiliser les substitutions de dessin, de feuille, de vue et de toutes les pièces",
      "Sayfa şablonunda değişken özniteliklere sahip bloklar varsa, \r\n" +             // TR
        "o zaman program tüm ikameleri gerçekleştirecek ve bu öznitelikleri dolduracaktır. \r\n" +
        "Çizim, sayfa, görünüm ve tüm parça ikamelerini kullanabilirsiniz"};

  }
}