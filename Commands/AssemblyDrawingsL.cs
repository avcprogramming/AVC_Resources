namespace AVC
{
  public class
  AssemblyDrawingsL
  {

    public static readonly string[][] AsmDrawStyleNames = {
/* 0 */ CommandL.AsmDraw,
/* 1 */ CommandL.AsmDraw,
/* 2 */ new []{
        "4 assembly per sheet",
        "4 сборки на лист",
        "4 assemblaggi per foglio",
        "4 Baugruppen pro Blatt",
        "每张板 4 个组件",
        "4 ensamblajes por hoja",
        "4 assemblages par feuille",
        "Sayfa başına 4 montaj"},
        };

    //public static string[] DefaultLayoutName = {
    //  "Asm%viewtargetname%",
    //  "СБ%viewtargetname%",
    //  "Asm%viewtargetname%",
    //  "Asm%viewtargetname%",
    //  "集会%viewtargetname%"};

    public static readonly string[] AsmStyle = {
      "  Assembly drawing style will be used: {0}",
      "  Будет использован стиль сборочных чертежей: {0}",
      "  Verrà utilizzato lo stile di disegno dell'assemblaggio: {0}",
      "  Es wird folgender Montagezeichnungsstil verwendet: {0}",
      "  将使用装配绘图样式：{0}",
      "  Se utilizará el estilo de dibujo de ensamblaje: {0}",
      "  Le style de dessin d’assemblage sera utilisé : {0}",
      "  Montaj çizim stili kullanılacak: {0}" };

    public static readonly string[] AsmNumberErr = {
      "Too many assemblies({0}). There can only be 255 sheets in one drawing.",
      "Слишком много сборок({0}). В одном чертеже может быть только 255 листов.",
      "Troppi assembly ({0}). Possono esserci solo 255 fogli in un disegno.",
      "Zu viele Assemblys ({0}). Eine Zeichnung darf nur 255 Blätter enthalten.",
      "程序集过多（{0}）。 一个dwg文件中只能有 255 个布局(图纸)。",
      "Demasiados ensamblajes ({0}). Solo puede haber 255 hojas en un dibujo.",
      "Trop d’assemblages ({0}). Il ne peut y avoir que 255 feuilles dans un dessin.",
      "Çok fazla montaj ({0}). Bir çizimde en fazla 255 sayfa olabilir." };

    public static readonly string[] AsmDrawStyleKW = {
      "ASMDRAWstyle",
      "ASMDRAWcтиль",
      "ASMDRAWstile",
      "ASMDRAWstil",
      "ASMDRAW风格",
      "ASMDRAWestilo",
      "ASMDRAWstyle (FR)",
      "ASMDRAWstil (TR)" };
    public static readonly string[] ExposeStyleKW = {
      "EXPOSEstyle",
      "EXPOSEcтиль",
      "EXPOSEstile",
      "EXPOSEstil",
      "EXPOSE风格",
      "EXPOSEestilo",
      "EXPOSEstyle (FR)",
      "EXPOSEstil (TR)" };
    public static readonly string[] PlaceLeaderStyleKW = {
      "PLACEstyle",
      "PLACEcтиль",
      "PLACEstile",
      "PLACEstil",
      "PLACE风格",
      "PLACEestilo",
      "PLACEstyle (FR)",
      "PLACEstil (TR)" };
    public static readonly string[] DefViewAttributes = { // взято у 1220
      "#=%index%\r\n" +
        "VIEWNAME=%direction% %isometric:{0} %VIEW\r\n" +
        "VPSCALE=Scale: %scale%",
      "#=%index%\r\n" +
        "VIEWNAME=ВИД %direction%%isometric: {0}%\r\n" +
        "VPSCALE=Масштаб: %scale%",
      "#=%index%\r\n" +
        "VIEWNAME=VISTA %direction%%isometric: {0}%\r\n" +
        "VPSCALE=Scala: %scale%",
      "#=%index%\r\n" +
        "VIEWNAME=%direction%%isometric%ANSICHT\r\n" +
        "VPSCALE=Skala: %scale%",
      "#=%index%\r\n" +
        "VIEWNAME=%direction%%isometric%视图\r\n" +
        "VPSCALE=规模: %scale%",
      "#=%index%\r\n" +
        "VIEWNAME=VISTA %direction%%isometric: {0}%\r\n" +
        "VPSCALE=Escala: %scale%",
      "#=%index%\r\n" +
        "VIEWNAME=VUE %direction%%isometric: {0}%\r\n" +
        "VPSCALE=Échelle : %scale%",
      "#=%index%\r\n" +
        "VIEWNAME=GÖRÜNÜM %direction%%isometric: {0}%\r\n" +
        "VPSCALE=Ölçek: %scale%" };
    public static readonly string[] DefLayoutAttributes = {
      "DRAWING=%viewtargetname%\r\n" +
        "SCALE=%viewstandardscale%\r\n" +
        "DETAILER=%<\\AcVar Author>%\r\n"+
        "TECHLEAD=\r\n" +
        "PROJECT=%<\\AcVar Filename \\f \"%fn2\">%\r\n" +
        "CLIENT=%<\\AcVar Subject>%",
      "ЧЕРТЕЖ=%viewtargetname%\r\n" +
        "МАСШТАБ=%viewstandardscale%\r\n" +
        "РАЗРАБ=%<\\AcVar Author>%\r\n"+
        "ПРОВЕРИЛ=\r\n" +
        "ПРОЕКТ=%<\\AcVar Filename \\f \"%fn2\">%\r\n" +
        "ЗАКАЗЧИК=%<\\AcVar Subject>%" };

    public static readonly string[] CreatingViewports = {
      "There are no viewports on sheet {0}. The program will create viewports to accommodate {1} assemblies.",
      "На листе {0} нет ни одного вьюпорта (видового экрана). Программа создаст вьюпорты для размещения {1} сборок.",
      "Non ci sono finestre di visualizzazione sul foglio {0}. Il programma creerà finestre di visualizzazione per ospitare gli assiemi {1}.",
      "Auf Blatt {0} sind keine Ansichtsfenster vorhanden. Das Programm erstellt Ansichtsfenster für {1} Baugruppen.",
      "图纸 {0} 上没有视口。程序将创建视口以容纳 {1} 个组件。",
      "No hay viewports en la hoja {0}. El programa creará viewports para {1} ensamblajes.",
      "Il n’y a aucun viewport sur la feuille {0}. Le programme créera des viewports pour {1} assemblages.",
      "Sayfa {0} üzerinde hiç viewport yok. Program {1} montaj için viewport’lar oluşturacak." };
    public static readonly string[] ChangeViewports = {
      "The number of viewports on the sheet {0} does not match the program settings: there is {1}, we need {2}. " +
        "The program will recreate all viewports again.",
      "Количество вьюпортов на листе {0} не соответствует настройке программы: есть {1}, надо {2}. " +
        "Программа пересоздаст все вьюпорты заново.",
      "Il numero di finestre di visualizzazione sul foglio {0} non corrisponde alle impostazioni del programma: ce n'è {1}, ne servono {2}. " +
        "Il programma ricreerà tutte le finestre di visualizzazione.",
      "Die Anzahl der Ansichtsfenster auf dem Blatt {0} entspricht nicht den Programmeinstellungen: Es gibt {1}, wir benötigen {2}. " +
        "Das Programm erstellt alle Ansichtsfenster erneut.",
      "图纸 {0} 上的视口数量与程序设置不符：有 {1}，需要 {2}。程序将重新创建所有视口。",
      "El número de viewports en la hoja {0} no coincide con la configuración: hay {1}, se necesitan {2}. " +
        "El programa volverá a crearlos.",
      "Le nombre de viewports sur la feuille {0} ne correspond pas aux paramètres : il y en a {1}, il en faut {2}. " +
        "Le programme les recréera.",
      "Sayfa {0} üzerindeki viewport sayısı ayarlarla uyuşmuyor: {1} var, {2} gerekli. " +
        "Program tüm viewport’ları yeniden oluşturacaktır." };
    public static readonly string[] VisualStyleNotFound = {
      "Visual style '{0}' not found. The program will use the default visual style. ",
      "Визуальный стиль '{0}' не найден. Программа будет использовать стандартный визуальный стиль.",
      "Stile visivo '{0}' non trovato. Il programma utilizzerà lo stile visivo predefinito.",
      "Der Visualisierungsstil '{0}' wurde nicht gefunden. Das Programm verwendet den Standard-Visualisierungsstil.",
      "未找到视觉样式“{0}”。程序将使用默认的视觉样式。",
      "Estilo visual '{0}' no encontrado. Se usará el estilo predeterminado.",
      "Style visuel « {0} » introuvable. Le style par défaut sera utilisé.",
      "Görsel stil '{0}' bulunamadı. Varsayılan stil kullanılacak." };

    public static readonly string[] NoFileTemplate = {
      "The drawing template from which to retrieve the sheet template has not been specified. The program will use the current drawing as a template.",
      "Не задан шаблон чертежа, из которого следует извлекать шаблон листа. Программа будет использовать текущий чертеж как шаблон.",
      "Non è stato specificato il modello di disegno da cui recuperare il modello di foglio. Il programma utilizzerà il disegno corrente come modello.",
      "Die Zeichnungsvorlage, aus der die Blattvorlage abgerufen werden soll, wurde nicht angegeben. Das Programm verwendet die aktuelle Zeichnung als Vorlage.",
      "未检索图形样板的布局。该程序将使用当前绘图作为模板。",
      "No se especificó la plantilla de dibujo. Se usará el dibujo actual como plantilla.",
      "Aucun modèle de dessin n’a été spécifié. Le dessin actuel sera utilisé comme modèle.",
      "Sayfa şablonunun alınacağı çizim şablonu belirtilmedi. Mevcut çizim şablon olarak kullanılacak." };

    public static readonly string[] NoLayoutTemplate = {
      "The name of the template sheet (layout) for creating new sheets is not specified. The program will use the first sheet with viewports it encounters.",
      "Не задано имя листа-шаблона для создания новых листов. Программа будет использовать первый попавшийся лист с вьюпортами.",
      "Il nome del foglio modello per la creazione di nuovi fogli non è specificato. Il programma utilizzerà il primo foglio con viewport che incontra.",
      "Der Name des Vorlagenblatts zum Erstellen neuer Blätter ist nicht angegeben. Das Programm verwendet das erste Blatt mit Ansichtsfenstern, das es findet.",
      "未指定用于创建新图纸的模板图纸名称。程序将使用遇到的第一个带有视口的图纸。",
      "No se especificó el nombre del layout. Se usará el primero con viewports.",
      "Le nom du layout modèle n’est pas spécifié. Le premier layout avec viewports sera utilisé.",
      "Yeni sayfalar için şablon sayfa adı belirtilmedi. Program, viewportun bulunduğu ilk sayfayı kullanacak." };

    public static readonly string[] LayoutNotFound = {
      "The sheet (layout) with the name '{0}' was not found in template '{1}'. The program will use the first sheet with viewports it encounters.",
      "Лист с именем '{0}' не найден в шаблоне '{1}'. Программа будет использовать первый попавшийся лист с вьюпортами.",
      "Il foglio (layout) con il nome '{0}' non è stato trovato nel modello '{1}'. Il programma utilizzerà il primo foglio con viewport che incontra.",
      "Das Blatt (Layout) mit dem Namen '{0}' wurde in der Vorlage '{1}' nicht gefunden. Das Programm verwendet das erste Blatt mit Ansichtsfenstern, das es findet.",
      "未找到名称为“{0}”的图纸（布局）在模板 '{1}' 中。程序将使用遇到的第一个带有视口的图纸。",
      "No se encontró la hoja '{0}' en la plantilla '{1}'. Se usará la primera con viewports.",
      "La feuille « {0} » est introuvable dans le modèle « {1} ». La première feuille avec viewports sera utilisée.",
      "Şablon '{1}' içinde '{0}' adlı sayfa bulunamadı. İlk bulunan viewport’lu sayfa kullanılacak."  };
    public static readonly string[] PartsWOLeader = {
      "Failed to place all MLeader for assembly '{0}' : {1}",
      "Не удалось разместить все выноски для сборки '{0}' : {1}",
      "Impossibile posizionare tutte le chiamate per l'assembly '{0}': {1}",
      "Es konnten nicht alle Callouts für die Baugruppe „{0}“ platziert werden: {1}",
      "无法放置程序集“{0}”的所有标注：{1}",
      "No se pudieron colocar todos los MLeader para el ensamblaje «{0}»: {1}",
      "Impossible de placer tous les MLeader pour l’assemblage « {0} » : {1}",
      "Montaj '{0}' için tüm MLeader yerleştirilemedi: {1}"};
    public static readonly string[] Process =    {
      "Creating viewports and annotations",
      "Создание видов и аннотаций",
      "Creazione di viste e annotazioni",
      "Erstellen von Ansichtsfenstern und Anmerkungen",
      "创建视口和注释",
      "Creando viewports y anotaciones",
      "Création des viewports et des annotations",
      "Viewport ve açıklamaların oluşturulması" };
    public static readonly string[] BlockExtentsErr = {
      "Unable to measure the dimensions of block '{0}'. The block will be overlaid on the drawing.",
      "Не удалось измерить размеры блока '{0}'. Блок будет наложен на чертеж.",
      "Impossibile misurare le dimensioni del blocco '{0}'. Il blocco verrà sovrapposto al disegno.",
      "Die Abmessungen des Blocks '{0}' konnten nicht gemessen werden. Der Block wird auf die Zeichnung gelegt.",
      "无法测量块“{0}”的尺寸。该块将覆盖在图纸上。",
      "No se pueden medir las dimensiones del bloque «{0}». Se superpondrá al dibujo.",
      "Impossible de mesurer les dimensions du bloc « {0} ». Le bloc sera superposé au dessin.",
      "‘{0}’ bloğunun ölçüleri alınamadı. Blok çizimin üzerine bindirilecek." };
    public static readonly string[] BlockAttrErr = {
      "There is no attribute '{1}' in the view name block '{0}'.",
      "В блоке названия вида '{0}' нет атрибута '{1}'.",
      "Non esiste l'attributo '{1}' nel blocco del nome della vista '{0}'.",
      "Im Ansichtsname-Block '{0}' ist kein Attribut '{1}' vorhanden.",
      "视图名称块“{0}”中没有属性“{1}”。",
      "No existe el atributo «{1}» en el bloque de nombre de vista «{0}».",
      "L’attribut « {1} » n’existe pas dans le bloc de nom de vue « {0} ».",
      "‘{0}’ görünüm adı bloğunda ‘{1}’ özniteliği yok."    };
    public static readonly string[] NoAttributesErr = {
      "The view name block '{0}' does not have any attributes to fill. \r\n" +
        "Reconfigure the attribute list.",
      "В блоке названия вида '{0}' нет ни одного атрибута для заполнения. \r\n" +
        "Перенастройте список атрибутов.",
      "Il blocco del nome della vista '{0}' non dispone di attributi da compilare. \r\n" +
        "Riconfigurare l'elenco degli attributi.",
      "Im Ansichtsname-Block '{0}' sind keine Attribute zum Ausfüllen vorhanden. \r\n" +
        "Konfigurieren Sie die Attributliste neu.",
      "视图名称块“{0}”没有任何要填写的属性。重新配置属性列表。",
      "El bloque de nombre de vista «{0}» no tiene atributos que completar. \r\n" +
        "Vuelva a configurar la lista.",
      "Le bloc nom de vue « {0} » n’a aucun attribut à renseigner. \r\n" +
        "Reconfigurez la liste.",
      "‘{0}’ görünüm adı bloğunda doldurulacak hiçbir öznitelik yok. \r\n" +
        "Öznitelik listesini yeniden yapılandırın." };

    //=============================================== AsmDrawOptionsBox ================================================
    public static readonly string[] DialogTitle = {
      "Assembly Drawings command options",
      "Настройки команды Сборочные Чертежи",
      "Opzioni di comando Disegni di assemblaggio",
      "Befehlsoptionen für Montagezeichnungen",
      "装配图命令选项",
      "Opciones del comando Dibujos de ensamblaje",
      "Options de la commande Dessins d’assemblage",
      "Montaj Çizimleri komut seçenekleri" };

    public static readonly string[] StyleNameTip = {
      "The name for this Assembly Drawing style. Not used in the program. Only for convenience of choice.",
      "Название для этого стиля Сборочных Чертежей. Не используется в программе. Только для удобства выбора.",
      "Il nome per questo stile Disegni di assemblaggio. Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Montagezeichnungen-Stil. Wird im Programm nicht verwendet. Nur aus Bequemlichkeit.",
      "此装配图样式的名称。程序中未使用。仅为方便选择。",
      "Nombre para este estilo de dibujo de ensamblaje. No se usa en el programa.",
      "Nom pour ce style de dessin d’assemblage. Non utilisé par le programme.",
      "Bu Montaj Çizimi stili için ad. Programda kullanılmaz." };
    public static readonly string[] ExposeTip = {
      "Run the Expose Assemblies command to arrange assemblies in the model.\r\n"+
        "If this option is disabled, the program will not make copies of assemblies, \r\n" +
        "the selected blocks will be used, as they are located in the model.\r\n" +
        "It is possible that assemblies will block each other in viewports.",
      "Запускать команду Выставка Сборок (Expose) для расстановки сборок в модели.\r\n" +
        "Если опция выключена, то программа не будет делать копии сборок, \r\n" +
        "будут использованы выбранные блоки, так как они расположены в модели.\r\n" +
        "При этом возможно, что сборки будут перегораживать друг друга во вьюпортах.",
      "Esegui il comando Expose Assemblies per disporre gli assiemi nel modello.\r\n" +
        "Se questa opzione è disabilitata, il programma non copierà gli assiemi, \r\n" +
        "verranno utilizzati i blocchi selezionati, così come sono posizionati nel modello.\r\n" +
        "È possibile che gli assiemi si blocchino a vicenda nelle finestre di visualizzazione.",
      "Führen Sie den Befehl Expose Assemblies aus, um Baugruppen im Modell anzuordnen.\r\n" +
        "Wenn diese Option deaktiviert ist, erstellt das Programm keine Kopien von Baugruppen, \r\n" +
        "es werden die ausgewählten Blöcke verwendet, so wie sie im Modell positioniert sind.\r\n" +
        "Es ist möglich, dass sich Baugruppen in Ansichtsfenstern gegenseitig blockieren.",
      "运行 Expose Assemblies 命令以在模型中排列组件。\r\n" +
        "如果禁用此选项，程序将不会复制组件，\r\n" +
        "将使用所选块，就像它们在模型中定位一样。\r\n" +
        "组件可能会在视口中相互阻塞。",
      "Ejecute el comando Expose Assemblies para distribuir los ensamblajes.\r\n" +
        "Si está desactivado, no se copiarán ensamblajes; se usarán los bloques tal como están.\r\n" +
        "Es posible que se tapen entre sí en los viewports.",
      "Exécutez la commande Expose Assemblies pour disposer les assemblages.\r\n" +
        "Si désactivé, pas de copies ; les blocs sélectionnés seront utilisés tels quels.\r\n" +
        "Les assemblages peuvent se masquer entre eux dans les viewports.",
      "Montajları yerleştirmek için Expose Assemblies komutunu çalıştırın.\r\n" +
        "Devre dışıysa, kopya yapılmaz; modeldeki konumlarıyla seçili bloklar kullanılır.\r\n" +
        "Viewport’larda montajlar birbirini kapatabilir." };
    public static readonly string[] LayoutTemplateTip = {
      "The name of the layout to be copied from the drawing template. \r\n" +
        "This layout may contain viewports - each of them will contain one assembly. \r\n" +
        "If there are no viewports, then you must specify a number of assemblies on the sheet greater than zero.",
      "Название вкладки листа, который надо копировать из шаблона чертежа. \r\n" +
        "На этом листе могут быть вьюпорты - в каждом из них будет размещена одна сборка. \r\n" +
        "Если вьюпортов нет, то нужно указать количество сборок на листе больше ноля.",
      "Il nome del foglio da copiare dal modello di disegno. \r\n" +
        "Questo foglio può contenere delle finestre di visualizzazione, ognuna delle quali conterrà un assieme. \r\n" +
        "Se non ci sono finestre di visualizzazione, \r\n" +
        "è necessario specificare un numero di assiemi sul foglio maggiore di zero.",
      "Der Name des Blatts, das aus der Zeichnungsvorlage kopiert werden soll. \r\n" +
        "Dieses Blatt kann Ansichtsfenster enthalten – jedes davon enthält eine Baugruppe. \r\n" +
        "Wenn keine Ansichtsfenster vorhanden sind, müssen Sie eine Anzahl von Baugruppen auf dem Blatt angeben, \r\n" +
        "die größer als Null ist.",
      "图形样板文件中的布局名称。 \r\n" +
        "此工作表可能包含视口 - 每个视口将包含一个组件。\r\n" +
        "如果没有视口，则必须在工作表上指定大于零的组件数量。",
      "Nombre del layout a copiar del template.\r\n" +
        "Puede contener viewports; cada uno contendrá un ensamblaje.\r\n" +
        "Si no hay viewports, indique un número de ensamblajes mayor que cero.",
      "Nom du layout à copier depuis le modèle.\r\n" +
        "Il peut contenir des viewports ; chacun contiendra un assemblage.\r\n" +
        "S’il n’y en a pas, précisez un nombre d’assemblages > 0.",
      "Şablondan kopyalanacak yerleşim adı.\r\n" +
        "Viewportun olabilir; her biri bir montaj içerir.\r\n" +
        "Viewport yoksa, sayfada sıfırdan büyük montaj sayısı belirtin." };
    public static readonly string[] CountPerLayout = {
      "Number of assemblies per layout",
      "Количество сборок на лист",
      "Numero di assiemi per foglio",
      "Anzahl der Baugruppen pro Blatt",
      "每张图纸的组件数量",
      "Número de ensamblajes por layout",
      "Nombre d’assemblages par layout",
      "Yerleşim başına montaj sayısı"};
    public static readonly string[] CountPerLayoutTip = {
      "Ignore viewports in the sheet template and place no more than this number of assemblies. \r\n" +
        "If 0, then use the old viewports of the layout template as the location of each assembly.",
      "Игнорировать вьюпорты в шаблоне листа и разместить не более этого количества сборок. \r\n" +
        "Если 0, то использовать старые вьюпорты шаблона листа, как расположение каждой сборки.",
      "Ignorare le finestre nel modello di foglio e non posizionare più di questo numero di assiemi. \r\n" +
        "Se 0, utilizzare le vecchie finestre di visualizzazione del modello di foglio come posizione di ogni assemblaggio.",
      "Ignorieren Sie Ansichtsfenster in der Blattvorlage und platzieren Sie nicht mehr als diese Anzahl an Baugruppen. \r\n" +
        "Wenn 0, verwenden Sie die alten Ansichtsfenster der Blattvorlage als Position jeder Baugruppe.",
      "忽略图纸模板中的视口，并且放置的组件数量不得超过此数量。 \r\n" +
        "如果为 0，则使用图纸模板的旧视口作为每个组件的位置。",
      "Ignore los viewports del template y no coloque más de este número de ensamblajes.\r\n" +
        "Si es 0, use los viewports existentes como posición de cada ensamblaje.",
      "Ignorez les viewports du modèle et ne dépassez pas ce nombre d’assemblages.\r\n" +
        "Si 0, utilisez les anciens viewports comme emplacement de chaque assemblage.",
      "Şablondaki viewportları yok sayın ve bu sayıyı aşmayın.\r\n" +
        "0 ise, her montajın konumu için eski viewportlar kullanılır." };
    public static readonly string[] LeftField = {
      "Left field",
      "Поле слева",
      "Campo a sinistra",
      "Linkes Feld",
      "左字段",
      "Margen izquierdo",
      "Marge gauche",
      "Sol boşluk" };
    public static readonly string[] LeftFieldTip = {
      "Indent from the left edge of the paper space to the assembly drawings. For placing the frame and other sheet objects.",
      "Отступ от левого края пространства бумаги до чертежей сборок. Для размещения рамки и прочих объектов листа.",
      "Rientro dal bordo sinistro dello spazio carta ai disegni di assemblaggio. Per posizionare il telaio e altri oggetti del foglio.",
      "Einzug vom linken Rand des Papierbereichs zu den Montagezeichnungen. Zum Platzieren des Rahmens und anderer Blattelemente.",
      "从图纸空间的左边缘到装配图的缩进。用于放置框架和其他图纸对象。",
      "Sangría desde el borde izquierdo del papel hasta los dibujos. Para el marco y otros objetos.",
      "Marge depuis le bord gauche jusqu’aux dessins. Pour le cartouche et autres objets.",
      "Kağıt alanının solundan montaj çizimlerine girinti. Çerçeve ve diğer nesneler için." };
    public static readonly string[] RightField = {
      "Right",
      "Справа",
      "Destra",
      "Rechtes",
      "右字段",
      "Derecha",
      "Droite",
      "Sağ" };
    public static readonly string[] RightFieldTip = {
      "Indent from the right edge of the paper space to the assembly drawings. For placing the frame and other sheet objects.",
      "Отступ от правого края пространства бумаги до чертежей сборок. Для размещения рамки и прочих объектов листа.",
      "Rientro dal bordo destro dello spazio carta ai disegni di assemblaggio. Per posizionare il telaio e altri oggetti del foglio.",
      "Einzug vom rechten Rand des Papierbereichs zu den Montagezeichnungen. Zum Platzieren des Rahmens und anderer Blattelemente.",
      "从图纸空间的右边缘到装配图的缩进。用于放置框架和其他图纸对象。",
      "Sangría desde el borde derecho del papel hasta los dibujos.",
      "Marge depuis le bord droit jusqu’aux dessins.",
      "Kağıt alanının sağından girinti." };
    public static readonly string[] TopField = {
      "Top field",
      "Поле сверху",
      "Campo in alto",
      "Oberes Feld",
      "顶部字段",
      "Margen superior",
      "Marge supérieure",
      "Üst boşluk" };
    public static readonly string[] TopFieldTip = {
      "Indent from the top edge of the paper space to the assembly drawings. For placing the frame and other sheet objects.",
      "Отступ от верхнего края пространства бумаги до чертежей сборок. Для размещения рамки и прочих объектов листа.",
      "Rientro dal bordo superiore dello spazio carta ai disegni di assemblaggio. Per posizionare il telaio e altri oggetti del foglio.",
      "Einzug vom oberen Rand des Papierbereichs zu den Montagezeichnungen. Zum Platzieren des Rahmens und anderer Blattelemente.",
      "从图纸空间的上边缘到装配图的缩进。用于放置框架和其他图纸对象。",
      "Sangría desde el borde superior del papel hasta los dibujos.",
      "Marge depuis le bord supérieur jusqu’aux dessins.",
      "Kağıt alanının üstünden girinti." };
    public static readonly string[] BottomField = {
      "Bottom",
      "Снизу",
      "Basso",
      "Unteres",
      "底部字段",
      "Inferior",
      "Bas",
      "Alt" };
    public static readonly string[] BottomFieldTip = {
      "Indent from the bottom edge of the paper space to the assembly drawings. For placing the frame and other sheet objects.",
      "Отступ от нижнего края пространства бумаги до чертежей сборок. Для размещения рамки и прочих объектов листа.",
      "Rientro dal bordo inferiore dello spazio carta ai disegni di assemblaggio. Per posizionare il telaio e altri oggetti del foglio.",
      "Einzug vom unteren Rand des Papierbereichs zu den Montagezeichnungen. Zum Platzieren des Rahmens und anderer Blattelemente.",
      "从图纸空间的下边缘到装配图的缩进。用于放置框架和其他图纸对象。",
      "Sangría desde el borde inferior del papel hasta los dibujos.",
      "Marge depuis le bord inférieur jusqu’aux dessins.",
      "Kağıt alanının altından girinti." };
    public static readonly string[] TooManyViews = {
      "{0} viewports on sheet! Sheet will slow down and crash possible.",
      "{0} вьюпортов на листе! Лист будет тормозить и возможен фатальный сбой.",
      "{0} finestre di visualizzazione sul foglio! Il foglio rallenterà e potrebbe verificarsi un arresto anomalo.",
      "{0} Ansichtsfenster auf dem Blatt! Das Blatt wird verlangsamt und es kann zu einem Absturz kommen.",
      "图纸上有 {0} 个视口！ 图纸将变慢并可能发生崩溃。",
      "¡{0} viewports en la hoja! Puede ir lento y fallar.",
      "{0} viewports sur la feuille ! Ralentissements et crash possibles.",
      "Sayfada {0} viewport var! Yavaşlama ve çökme olabilir." };
    public static readonly string[] Title = {
      "Assembly Title",
      "Заголовок сборки",
      "Titolo dell'assemblaggio",
      "Baugruppentitel",
      "组件标题",
      "Título del ensamblaje",
      "Titre de l’assemblage",
      "Montaj başlığı" };
    public static readonly string[] TitleMaskTip = {
      "Assembly property substitution template for assembly header. Sheet and viewport property substitutions will not work.",
      "Шаблон подстановок свойств сборки для заголовка сборки. Подстановки свойств листа и вьюпортов не сработают.",
      "Modello di sostituzione delle proprietà di assemblaggio per l'intestazione dell'assemblaggio. Le sostituzioni delle proprietà del foglio e della finestra di visualizzazione non funzioneranno.",
      "Vorlagen für den Austausch von Baugruppeneigenschaften für die Baugruppenüberschrift. Blatt- und Ansichtsfenstereigenschaften funktionieren nicht.",
      "组件标题的组件属性替换模板。图纸和视口属性替换将不起作用。",
      "Plantilla de sustitución de propiedades del ensamblaje para el encabezado. No funcionan las del layout/viewport.",
      "Modèle de substitution des propriétés d’assemblage pour l’en‑tête. Pas de substitution de feuille/viewport.",
      "Montaj başlığı için özellik değiştirme şablonu. Sayfa/viewport özellikleri işlemez." };
    public static readonly string[] ThirdAngleProjection = {
      "Third Angle Projection",
      "Проекция из 'Третьего Угла'",
      "Proiezione del Terzo Angolo",
      "Dritte Winkelprojektion",
      "第三角投影",
      "Proyección de tercer ángulo",
      "Projection du troisième angle",
      "Üçüncü dik izdüşüm" };
    public static readonly string[] ThirdAngleProjectionTip = {
      "Place views using the Third Angle Projection type.\r\n" +
        "This is the standard for placing views in the US and Japan: ANSI, ASME, CSA, JIS.\r\n" +
        "1st angle - the object is located between the observer and the projection plane.\r\n" +
        "3rd angle - the projection plane is located between the observer and the object.",
      "Размещать виды по типу проекции «третий угол» (Third Angle Projection).\r\n" +
        "Первый угол (1st angle) — объект расположен между наблюдателем и плоскостью проекции (ГОСТ, ЕСКД, DIN).\r\n" +
        "Третий угол (3rd angle) — плоскость проекции находится между наблюдателем и объектом.\r\n"+
        "Это стандарт размещения видов в США и Японии: ANSI, ASME, CSA, JIS.\r\n",
      "Posizionare le viste utilizzando il tipo di proiezione del terzo angolo.\r\n" +
        "Questo è lo standard per il posizionamento delle viste negli Stati Uniti e in Giappone: ANSI, ASME, CSA, JIS.\r\n" +
        "1st angle - l'oggetto si trova tra l'osservatore e il piano di proiezione (DIN, GOST).\r\n" +
        "3rd angle - il piano di proiezione si trova tra l'osservatore e l'oggetto.",
      "Platzieren Sie Ansichten mit dem Projektionstyp Dritte Winkelprojektion.\r\n" +
        "Dies ist der Standard für die Platzierung von Ansichten in den USA und Japan: ANSI, ASME, CSA, JIS.\r\n" +
        "1st angle - das Objekt befindet sich zwischen dem Beobachter und der Projektionsfläche (DIN, GOST).\r\n" +
        "3rd angle - die Projektionsfläche befindet sich zwischen dem Beobachter und dem Objekt.",
      "使用第三角投影类型放置视图。\r\n" +
        "第一角 - 物体位于观察者和投影平面之间 (DIN, GOST)。\r\n" +
        "第三角 - 投影平面位于观察者和物体之间 (ANSI、ASME、CSA、JIS)。",
      "Ubique las vistas con proyección de tercer ángulo (EE. UU./Japón).",
      "Placer les vues selon la projection du troisième angle (ANSI/ASME/CSA/JIS).",
      "Görünümleri Üçüncü açı izdüşümü ile yerleştirin (ANSI/ASME/CSA/JIS)." };
    public static readonly string[] PlaceRearViewRight ={
      "Place the rear view to the right",
      "Размещать вид сзади правее.",
      "Posizionare la vista posteriore a destra.",
      "Platzieren Sie die Rückansicht nach rechts.",
      "后视图应放置在右边缘。",
      "Colocar la vista trasera a la derecha.",
      "Placer la vue arrière à droite.",
      "Arka görünümü sağa yerleştir." };
    public static readonly string[] PlaceRearViewRightTip = {
      "The rear view will be placed to the right of the side view. \r\n" +
        "If this option is disabled, the rear view will be placed below the front view.",
      "Вид сзади будет помещаться правее от вида сбоку. \r\n" +
        "Если опция выключена, то вид сзади помещается ниже вида спереди.",
      "La vista posteriore verrà posizionata a destra della vista laterale. \r\n" +
        "Se questa opzione è disabilitata, la vista posteriore verrà posizionata sotto la vista frontale.",
      "Die Rückansicht wird rechts von der Seitenansicht platziert. \r\n" +
        "Wenn diese Option deaktiviert ist, wird die Rückansicht unter der Vorderansicht platziert.",
      "后视图将放置在侧视图的右侧。如果禁用此选项，后视图将放置在前视图下方。",
      "La vista trasera se colocará a la derecha de la vista lateral.\r\n" +
        "Si está desactivado, irá debajo de la vista frontal.",
      "La vue arrière sera à droite de la vue latérale.\r\n" +
        "Si désactivé, elle sera sous la vue frontale.",
      "Arka görünüm, yan görünümün sağına yerleştirilir.\r\n" +
        "Kapalıysa, ön görünümün altına yerleştirilir." };
    public static readonly string[] SWIfSingle = {
      "Make SW view instead of any isometric view",
      "Делать ЮЗ-вид вместо любой изометрии",
      "Fare la vista SW invece di qualsiasi vista isometrica",
      "SW-Ansicht anstelle einer isometrischen Ansicht erstellen",
      "制作 SW 视图而不是任何等轴测视图",
      "Hacer vista SO en lugar de cualquier isométrica",
      "Faire une vue SO au lieu d’une isométrique",
      "Herhangi bir izometrik yerine G‑B görünüm yap" };
    public static readonly string[] SWIfSingleTip = {
      "If only one isometric view is configured, then replace it with a view from the South-West (+X,+Y), \r\n" +
        "violating the rules of projection directions.",
      "Если настроена только одна изометрия, то заменить ее на вид с Юго-Запада (+X,+Y), " +
        "нарушая правила направлений проецирования.",
      "Se è configurata una sola vista isometrica, sostituirla con una vista da Sud-Ovest (+X,+Y), \r\n" +
        "violando le regole delle direzioni di proiezione.",
      "Wenn nur eine isometrische Ansicht konfiguriert ist, \r\n" +
        "ersetzen Sie sie durch eine Ansicht aus Südwesten (+X,+Y), \r\n" +
        "wodurch die Regeln für Projektionsrichtungen verletzt werden.",
      "如果只配置了一个等轴测视图，则将其替换为来自西南方向的视图（+X，+Y），\r\n" +
        "违反投影方向的规则。",
      "Si solo hay una isométrica, cámbiela por una vista Suroeste (+X,+Y).",
      "S’il n’y a qu’une isométrique, remplacez‑la par une vue Sud‑Ouest (+X,+Y).",
      "Tek bir izometrik varsa, Güney‑Batı (+X,+Y) görünümüyle değiştirin." };
    public static readonly string[] SameScaleTip = {
      "Same scale for all assemblies on one sheet. \r\n" +
        "The option affects only the scale of orthogonal views. \r\n" +
        "All orthogonal views of one assembly will be adjusted to the same scale in any case.",
      "Одинаковый масштаб для всех сборок на одном листе. \r\n" +
        "Опция влияет только на масштаб ортогональных видов. \r\n" +
        "Все ортогональные виды одной сборки в любом случае будут подгоняться под один масштаб.",
      "Stessa scala per tutti gli assiemi su un foglio.\r\n" +
        "L'opzione influisce solo sulla scala delle viste ortogonali.\r\n" +
        "Tutte le viste ortogonali di un assieme verranno comunque adattate alla stessa scala.",
      "Gleicher Maßstab für alle Baugruppen auf einem Blatt.\r\n" +
        "Die Option wirkt sich nur auf den Maßstab orthogonaler Ansichten aus.\r\n" +
        "Alle orthogonalen Ansichten einer Baugruppe werden in jedem Fall auf den gleichen Maßstab eingestellt.",
      "同一张图纸上所有组件的比例相同。\r\n" +
        "此选项仅影响正交视图的比例。\r\n" +
        "无论如何，一个组件的所有正交视图都将调整为相同比例。",
      "Misma escala para todos los ensamblajes de la hoja.\r\n" +
        "Solo afecta a vistas ortogonales.\r\n" +
        "Todas las vistas ortogonales de un ensamblaje se ajustan a la misma escala.",
      "Même échelle pour tous les assemblages de la feuille.\r\n" +
        "N’affecte que les vues orthogonales.\r\n" +
        "Toutes les vues orthogonales d’un assemblage seront à la même échelle.",
      "Sayfadaki tüm montajlar için aynı ölçek.\r\n" +
        "Yalnızca ortogonal görünümleri etkiler.\r\n" +
        "Bir montajın tüm ortogonal görünümleri aynı ölçeğe ayarlanır." };
    public static readonly string[] ViewGap = {
      "Gap between views",
      "Зазор между видами",
      "Spazio tra le viste",
      "Lücke zwischen Ansichten",
      "视图之间的间隙",
      "Espacio entre vistas",
      "Espacement entre vues",
      "Görünümler arası boşluk" };
    public static readonly string[] ViewGapTip = {
      "How much minimum space to leave between the views of one assembly. \r\n" +
        "This gap is also used between assemblies.",
      "Сколько минимально оставить места между видами одной сборки. \r\n" +
        "Этот зазор так же используется между сборками.",
      "Quanto spazio minimo lasciare tra le viste di un assemblaggio. \r\n" +
        "Questo spazio viene utilizzato anche tra gli assiemi.",
      "Wie viel Mindestabstand zwischen den Ansichten einer Baugruppe gelassen werden soll. \r\n" +
        "Dieser Abstand wird auch zwischen Baugruppen verwendet.",
      "在一个组件的视图之间留出多少最小空间。 \r\n" +
        "此间隙也用于组件之间。",
      "Espacio mínimo entre vistas de un ensamblaje.\r\n" +
        "Se usa también entre ensamblajes.",
      "Espace minimal entre les vues d’un assemblage.\r\n" +
        "Utilisé également entre assemblages.",
      "Bir montajın görünümleri arasındaki en az boşluk.\r\n" +
        "Montajlar arasında da kullanılır." };
    public static readonly string[] AsmToViewGap = {
        "Gap from assembly to viewport",
        "Зазор от сборки до вьюпорта",
        "Spazio dall'assemblaggio alla finestra di visualizzazione",
        "Lücke von der Baugruppe zum Ansichtsfenster",
        "从组件到视口的间隙",
        "Espacio del ensamblaje al viewport",
        "Espace entre l’assemblage et le viewport",
        "Montajdan viewport’a boşluk" };
    public static readonly string[] AsmToViewGapTip = {
      "How much space to leave between the assembly outlines and the viewport. \r\n" +
        "If the value is zero, the assembly outlines may not be printed.",
      "Сколько места оставить между крайними контурами сборки и вьюпортом. \r\n" +
        "При нулевом значении возможно не будут печататься контуры сборки.",
      "Quanto spazio lasciare tra i contorni estremi dell'assieme e la finestra di visualizzazione. \r\n" +
        "Se il valore è zero, i contorni dell'assieme potrebbero non essere stampati.",
      "Wie viel Platz zwischen den äußeren Konturen der Baugruppe und dem Ansichtsfenster gelassen werden soll. \r\n" +
        "Wenn der Wert null ist, werden die Konturen der Baugruppe möglicherweise nicht gedruckt.",
      "在组件轮廓和视口之间留出多少空间。 \r\n" +
        "如果值为零，则可能不会打印组件轮廓。",
      "Espacio entre contornos del ensamblaje y el viewport.\r\n" +
        "Si es 0, puede que no se impriman.",
      "Espace entre les contours de l’assemblage et le viewport.\r\n" +
        "Si 0, l’impression peut omettre les contours.",
      "Montaj konturları ile viewport arasındaki boşluk.\r\n" +
        "0 ise konturlar basılmayabilir." };
    public static readonly string[] VisualStyleTip = {
      "Assign this visual style to all orthogonal views (except isometric). \r\n" +
        "Empty line - keep the visual style of the old viewports from the sheet template.",
      "Назначить этот визуальный стиль всем ортогональным видам (кроме изометрических). \r\n" +
        "Пустая строка - оставить визуальный стиль старых вьюпортов из шаблона листа.",
      "Assegnare questo stile visivo a tutte le viste ortogonali (escluse le isometriche). \r\n" +
        "Riga vuota: mantiene lo stile visivo delle vecchie finestre del modello di foglio.",
      "Weisen Sie diesen Visualisierungsstil allen orthogonalen Ansichten zu (außer isometrischen). \r\n" +
        "Leere Zeile – Behalten Sie den visuellen Stil der alten Ansichtsfenster aus der Blattvorlage bei.",
      "将此视觉样式分配给所有正交视图（等轴测视图除外）\r\n" +
        "空行 - 保留图纸模板中旧视口的视觉样式。",
      "Asigne este estilo visual a las vistas ortogonales (no iso).\r\n" +
        "Vacío: conservar el del template.",
      "Affectez ce style visuel aux vues orthogonales (hors isométriques).\r\n" +
        "Vide : conserver celui du modèle.",
      "Bu görsel stili tüm ortogonal görünümlere atayın (izometrik hariç).\r\n" +
        "Boşsa: şablondaki eski stil korunur." };
    public static readonly string[] Isometric = {
      "Isometric",
      "Изометрии",
      "Isometric",
      "Isometric",
      "等轴测",
      "Isométrica",
      "Isométrique",
      "İzometrik" };
    public static readonly string[] IsoVisualStyleTip = {
      "Assign this visual style to isometric views. \r\n" +
        "Leave empty to use the style of the old viewports of the sheet template.",
      "Назначить этот визуальный стиль изометрическим видам. \r\n" +
        "Оставьте пустым, чтоб использовать стиль старых вьюпортов шаблона листа.",
      "Assegnare questo stile visivo alle viste isometriche. \r\n" +
        "Lascia vuoto per utilizzare lo stile delle vecchie finestre del modello di foglio.",
      "Weisen Sie diesen Visualisierungsstil isometrischen Ansichten zu. \r\n" +
        "Lassen Sie es leer, um den Stil der alten Ansichtsfenster der Blattvorlage zu verwenden.",
      "将此视觉样式分配给等轴测视图。\r\n留空则使用旧图纸模板视口的样式。",
      "Asigne este estilo a las vistas isométricas.\r\nVacío: usar el del template.",
      "Affectez ce style aux vues isométriques.\r\nVide : utiliser celui du modèle.",
      "Bu görsel stili izometrik görünümlere atayın.\r\nBoşsa: şablondaki stili kullan." };
    public static readonly string[] LegacyHidden = {
      "Legacy Hidden",
      "Скрытые линии (Legacy Hidden)",
      "Nascosto Legacy",
      "Versteckte Linien (Legacy Hidden)",
      "传统隐藏线",
      "Oculto heredado",
      "Lignes cachées (hérité)",
      "Eski Gizli" };
    public static readonly string[] LegacyHiddenTip = {
      "If the visual style is 'Hidden', then set Shade Plot to 'Legacy Hidden'. \r\n" +
        "The setting allows you to print the 3D model in a monochrome print style. \r\n" +
        "But the view depth clipping (_3dClip) will have to be disabled.",
      "Если визуальный стиль 'Скрытые линии' (Hidden), то назначать Тонирование при печати как 'Legacy Hidden'. \r\n" +
        "Настройка позволяет печатать 3D-модель в монохромном стиле печати. \r\n" +
        "Но отсечение по глубине вида (_3dClip) придется отключить.",
      "Se lo stile visivo è 'Nascosto', impostare Shade Plot su 'Nascosto Legacy'. \r\n" +
        "L'impostazione consente di stampare il modello 3D in uno stile di stampa monocromatico. \r\n" +
        "Ma il ritaglio della profondità di visualizzazione (_3dClip) dovrà essere disabilitato.",
      "Wenn der Visualisierungsstil 'Versteckte Linien' (Hidden) ist, \r\n" +
        "dann setzen Sie Shade Plot auf 'Versteckte Linien (Legacy Hidden)'. \r\n" +
        "Die Einstellung ermöglicht das Drucken des 3D-Modells in einem monochromen Druckstil. \r\n" +
        "Aber das Tiefen-Clipping der Ansicht (_3dClip) muss deaktiviert werden.",
      "如果视觉样式为“隐藏”，则将阴影绘图设置为“传统隐藏”。\r\n" +
        "该设置允许以单色打印样式打印 3D 模型。\r\n" +
        "但必须禁用视图深度裁剪 (_3dClip)。",
      "Si el estilo es 'Hidden', establezca Shade Plot en 'Legacy Hidden'.\r\n" +
        "Permite imprimir en monocromo, pero desactive _3dClip.",
      "Si le style est « Hidden », réglez Shade Plot sur « Legacy Hidden ».\r\n" +
        "Permet l’impression monochrome, mais désactivez _3dClip.",
      "Görsel stil 'Hidden' ise Shade Plot'u 'Legacy Hidden' yapın.\r\n" +
        "Monokrom baskı sağlar, ancak _3dClip kapatılmalı."  };
    public static readonly string[] Clip3d = {
      "Clip view by depth (3dClip)",
      "Обрезать вид по глубине (_3dClip)",
      "Ritaglia la vista per profondità (3dClip)",
      "Sicht nach Tiefe zuschneiden (3dClip)",
      "按深度裁剪视图 (3dClip)",
      "Recortar por profundidad (3dClip)",
      "Rogner par profondeur (3dClip)",
      "Derinliğe göre kırp (3dClip)" };
    public static readonly string[] Clip3dTip = {
      "Enable 3D clipping (_3dClip) for all views. \r\n" +
        "This setting allows you to crop the view along the Z axis at the edges of the part, \r\n" +
        "and prevent other assemblies from appearing in the view. \r\n" +
        "But 'Legacy Hidden' shade plot will have to be disabled.\r\n" +
        "However, AutoCAD is glitchy and some assembly parts may disappear.",
      "Включать 3D-отсечение (_3dClip) для всех видов. \r\n" +
        "Настройка позволяет обрезать вид по оси Z по краям детали, \r\n" +
        "и избежать попадания других сборок на вид. \r\n" +
        "Но тонирование при печати 'Legacy Hidden' придется отключить. \r\n" +
        "Однако AutoCAD глючит и часть деталей сборки может исчезнуть.",
      "Abilita il ritaglio 3D (3dClip) per tutte le viste. \r\n" +
        "Questa impostazione consente di ritagliare la vista lungo l'asse Z ai bordi del pezzo, \r\n" +
        "e di evitare che altri assiemi appaiano nella vista. \r\n" +
        "Ma il tono di stampa 'Nascosto Legacy' dovrà essere disabilitato. \r\n" +
        "Tuttavia, AutoCAD presenta dei problemi e alcune parti dell'assieme potrebbero scomparire.",
      "3D-Clipping (_3dClip) für alle Ansichten aktivieren.\r\n" +
        "Mit dieser Einstellung können Sie die Ansicht entlang der Z-Achse an den Kanten des Bauteils beschneiden.\r\n" +
        "und verhindern, dass andere Baugruppen in der Ansicht angezeigt werden.\r\n" +
        "Die Darstellung der Schattierung ‚Versteckt‘ (Legacy) muss jedoch deaktiviert werden.\r\n" +
        "AutoCAD ist allerdings fehleranfällig, und einige Baugruppenteile können verschwinden.",
      "为所有视图启用 3D 裁剪 (_3dClip)。\r\n" +
        "此设置允许沿零件边缘沿 Z 轴裁剪视图，\r\n" +
        "并防止其他组件出现在视图中。\r\n" +
        "但必须禁用“传统隐藏”阴影绘图。\r\n" +
        "但是，AutoCAD 存在故障，某些组件部件可能会消失。",
      "Active el recorte 3D para todas las vistas.\r\n" +
        "Permite recortar por Z en los bordes y evita otros ensamblajes.\r\n" +
        "Pero desactive 'Legacy Hidden'. AutoCAD puede ocultar piezas.",
      "Activez le rognage 3D pour toutes les vues.\r\n" +
        "Permet de découper selon Z aux bords et d’éviter d’autres assemblages.\r\n" +
        "Mais désactivez « Legacy Hidden ». AutoCAD peut cacher des pièces.",
      "Tüm görünümler için 3D kırpmayı açın.\r\n" +
        "Parça kenarlarında Z boyunca kırpmayı sağlar ve diğer montajları engeller.\r\n" +
        "Ancak 'Legacy Hidden' kapatılmalıdır. AutoCAD bazı parçaları gizleyebilir." };
    public static readonly string[] FreezeLayers = {
      "Freeze Layers",
      "Заморозить слои",
      "Congela Layers",
      "Layer sperren",
      "冻结图层",
      "Congelar capas",
      "Geler les calques",
      "Katmanları dondur" };
    public static readonly string[] FreezeLayersTip = {
      "List of layers to freeze in all viewports. Layer masks with the * symbol are allowed.",
      "Список слоев, которые надо заморозить во всех вьюпортах. Допустимы маски слоев с символом *",
      "Elenco dei Layer da congelare in tutte le finestre di visualizzazione. \r\n" +
        "Sono consentite le maschere di livello con il simbolo *.",
      "Liste der in allen Ansichtsfenstern zu sperrenden Layer. Ebenenmasken mit dem Symbol * sind zulässig.",
      "要在所有视口中冻结的图层列表。允许使用带有 * 符号的图层蒙版。",
      "Lista de capas a congelar. Se permiten máscaras con *.",
      "Liste des calques à geler. Les masques avec * sont autorisés.",
      "Tüm viewport’larda dondurulacak katmanlar. * maskeleri desteklenir." };

    public static readonly string[] ViewNames = {
      "View Names",
      "Названия видов",
      "Nomi delle viste",
      "Ansichtsname",
      "视图名称",
      "Nombres de vista",
      "Noms des vues",
      "Görünüm adları" };
    public static readonly string[] ViewNamesTip = {
      "Place a block with the view name under each viewport.",
      "Помещать блок с названием вида под каждый вьюпорт.",
      "Posizionare un blocco con il nome della vista in ogni finestra di visualizzazione.",
      "Platzieren Sie einen Block mit dem Ansichtsname in jedem Ansichtsfenster.",
      "在每个视口中放置一个带有视图名称的块。",
      "Coloque un bloque con el nombre de la vista bajo cada viewport.",
      "Placer un bloc avec le nom de la vue sous chaque viewport.",
      "Her viewport’un altına görünüm adı bloğu yerleştirin." };
    public static readonly string[] ViewNamesEnable = {
      "Insert view name blocks",
      "Вставить блоки названий видов",
      "Inserire i blocchi dei nomi delle viste",
      "Ansichtsname-Blöcke einfügen",
      "插入视图名称块",
      "Insertar bloques de nombre de vista",
      "Insérer des blocs de nom de vue",
      "Görünüm adı bloklarını ekle" };
    public static readonly string[] ViewBlockTip = {
      "Select a block from the drawing or DWT template that has attributes for the view name and scale.",
      "Выберите блок из чертежа или DWT-шаблона, в котором есть атрибуты для имени и масштаба вида.",
      "Selezionare un blocco dal disegno o dal modello DWT che abbia attributi per il nome e la scala della vista.",
      "Wählen Sie einen Block aus der Zeichnung oder DWT-Vorlage, der Attribute für den Ansichtsname und den Maßstab enthält.",
      "从图纸或 DWT 模板中选择一个块，该块具有视图名称和比例的属性。",
      "Seleccione un bloque con atributos de nombre y escala de vista.",
      "Sélectionnez un bloc avec des attributs de nom et d’échelle de vue.",
      "Görünüm adı ve ölçek öznitelikli bir blok seçin." };
    public static readonly string[] ViewNameHeight = {
      "Gap for block",
      "Зазор для блока",
      "Spazio per il blocco",
      "Lücke für Block",
      "块间​​隙",
      "Espacio para el bloque",
      "Espace pour le bloc",
      "Blok için boşluk" };
    public static readonly string[] ViewNameHeightTip = {
      "How much space to leave under the view to place the block. \r\n" +
        " If 0, the program will measure the height of the block itself.",
      "Сколько места оставить под видом, для размещения блока. Если 0, то программа сама измерит высоту блока.",
      "Quanto spazio lasciare sotto la vista per posizionare il blocco. \r\n" +
        "Se 0, il programma misurerà l'altezza del blocco stesso.",
      "Wie viel Platz unter der Ansicht zum Platzieren des Blocks gelassen werden soll. \r\n" +
        "Wenn 0, misst das Programm die Höhe des Blocks selbst.",
      "在视图下方留出多少空间以放置块。如果为 0，程序将自行测量块的高度。",
      "Espacio bajo la vista para colocar el bloque.\r\n" +
        "Si es 0, se medirá automáticamente.",
      "Espace sous la vue pour placer le bloc.\r\n" +
        "Si 0, la hauteur du bloc sera mesurée.",
      "Blok için görünüm altında bırakılacak boşluk.\r\n" +
        "0 ise program yüksekliği ölçer." };
    public static readonly string[] OverallDimensions = {
      "Overall dimensions of the assembly",
      "Габаритные размеры сборки",
      "Dimension complessive dell'assieme",
      "Gesamtmaße der Baugruppe",
      "组件的整体尺寸",
      "Dimensiones generales del ensamblaje",
      "Cotes d’encombrement de l’assemblage",
      "Montajın genel ölçüleri" };
    public static readonly string[] OverallDimensionsTip = {
      "Show the overall dimensions of the assembly in two orthogonal views.",
      "Показать габаритные размеры сборки на двух ортогональных видах.",
      "Mostra le dimensioni complessive dell'assieme in due viste ortogonali.",
      "Zeigt die Gesamtmaße der Baugruppe in zwei orthogonalen Ansichten an.",
      "在两个正交视图中显示组件的整体尺寸。",
      "Mostrar las dimensiones generales en dos vistas ortogonales.",
      "Afficher les cotes d’ensemble dans deux vues orthogonales.",
      "Genel ölçüleri iki ortogonal görünümde göster." };
    public static readonly string[] DimView1 = {
      "On view",
      "На виде",
      "In vista",
      "Im Ansicht",
      "用于尺寸的视图",
      "En vista",
      "Sur vue",
      "Görünümde"};
    public static readonly string[] DimView1Tip = {
      "On which of the views to place two overall dimensions of the assembly. Only orthogonal views.",
      "На каком из видов разместить два габаритных размера сборки. Только ортогональные виды.",
      "Su quale delle viste posizionare due dimensioni complessive dell'assieme. Solo viste ortogonali.",
      "Auf welcher der Ansichten zwei Gesamtmaße der Baugruppe platziert werden sollen. Nur orthogonale Ansichten.",
      "在哪个视图上放置组件的两个整体尺寸。仅正交视图。",
      "En qué vista colocar dos cotas generales. Solo ortogonales.",
      "Sur quelle vue placer deux cotes d’ensemble. Vues orthogonales uniquement.",
      "İki genel ölçünün konulacağı görünüm. Sadece ortogonal." };
    public static readonly string[] DimView2 = {
      "3rd dim",
      "3-й габарит",
      "3° dim.",
      "3. Dim.",
      "第三个尺寸",
      "3. cota",
      "3e cote",
      "3. ölçü" };
    public static readonly string[] DimView2Tip ={
      "The view on which to place the third overall dimension. \r\n" +
        "The view must be in the same column or row as the first view.",
      "Вид на котором надо разместить третий габаритный размер. \r\n" +
        "Вид должен быть в том же столбце или в той же строке, что и первый вид.",
      "La vista su cui posizionare la terza dimensione complessiva. \r\n" +
        "La vista deve essere nella stessa colonna o riga della prima vista.",
      "Die Ansicht, auf der die dritte Gesamtmaße platziert werden soll. \r\n" +
        "Die Ansicht muss sich in derselben Spalte oder Zeile wie die erste Ansicht befinden.",
      "放置第三个整体尺寸的视图。 \r\n" +
        "视图必须与第一个视图位于同一列或同一行。",
      "Vista para colocar la tercera cota.\r\n" +
        "Debe estar en la misma columna o fila que la primera.",
      "Vue où placer la troisième cote.\r\n" +
        "Doit être dans la même colonne/ligne que la première.",
      "Üçüncü ölçünün konulacağı görünüm.\r\n" +
        "İlk görünüm ile aynı satır/sütunda olmalıdır." };
    public static readonly string[] PlaceLeaders = {
      "MLeaders from parts",
      "Выноски с деталей",
      "MLeaders dalle parti",
      "Beschriftungen von Teilen",
      "从零件放置标注",
      "MLeaders desde piezas",
      "MLeaders depuis les pièces",
      "Parçalardan MLeader" };
    public static readonly string[] PlaceLeadersTip = {
      "Place Multi-Leaders from each assembly part on one (or two) assembly views.",
      "Расставить выноски (MLeader) от каждой детали сборки на одном (или двух) видах сборки.",
      "Posiziona le didascalie (MLeader) da ogni parte dell'assieme su una (o due) viste dell'assieme.",
      "Platzieren Sie Beschriftungen (MLeader) von jedem Baugruppenteil auf einer (oder zwei) Baugruppenansichten.",
      "在一个（或两个）组件视图上从每个组件零件放置标注（MLeader）。",
      "Colocar MLeaders de cada pieza en una (o dos) vistas de ensamblaje.",
      "Placer les MLeaders de chaque pièce sur une (ou deux) vues d’assemblage.",
      "Her parça için MLeader’ları bir (veya iki) montaj görünümüne yerleştir." };
    public static readonly string[] LeadersView = {
      "View for MLeaders",
      "Вид для выносок",
      "Vista per le didascalie",
      "Ansicht für Beschriftungen",
      "标注视图",
      "Vista para MLeaders",
      "Vue pour MLeaders",
      "MLeader görünümü" };
    public static readonly string[] LeadersViewTip = {
      "The view on which to place callouts (MLeader) from parts. \r\n" +
        "Do not use the same view as for overall dimensions.",
      "Вид, на котором надо разместить выноски (MLeader) с позициями деталей. \r\n" +
        "Не используйте тот же вид, что и для габаритных размеров.",
      "La vista su cui posizionare le didascalie (MLeader) dalle parti. \r\n" +
        "Non utilizzare la stessa vista delle dimensioni complessive.",
      "Die Ansicht, auf der Beschriftungen (MLeader) von Teilen platziert werden sollen. \r\n" +
        "Verwenden Sie nicht dieselbe Ansicht wie für Gesamtmaße.",
      "在其中放置零件标注（MLeader）的视图。 \r\n" +
        "不要使用与整体尺寸相同的视图。",
      "Vista en la que colocar los MLeaders de piezas.\r\n" +
        "No use la misma que para cotas generales.",
      "Vue où placer les MLeaders des pièces.\r\n" +
        "Ne pas utiliser la même que pour les cotes d’ensemble.",
      "Parçalardan MLeader yerleştirilecek görünüm.\r\n" +
        "Genel ölçülerle aynı görünümü kullanmayın." };
    public static readonly string[] LeaderGap = {
      "Gap for MLeaders",
      "Зазор для выносок",
      "Spazio per MLeaders",
      "Lücke für MLeaders",
      "MLeaders 间隙",
      "Espacio para MLeaders",
      "Espace pour MLeaders",
      "MLeader boşluğu"};
    public static readonly string[] LeaderGapTip = {
      "How much space to leave on the side of the view to place callouts.",
      "Сколько оставить места сбоку от вида для размещения выносок.",
      "Quanto spazio lasciare sul lato della vista per posizionare le didascalie.",
      "Wie viel Platz an der Seite der Ansicht zum Platzieren von Beschriftungen gelassen werden soll.",
      "在视图侧面留出多少空间以放置标注。",
      "¿Cuánto espacio dejar en el lateral de la vista para colocar llamadas?",
      "Quelle marge de manœuvre laisser sur le côté de la vue pour placer les annotations ?",
      "Görüş alanının kenarında, açıklama metinlerini yerleştirmek için ne kadar boşluk bırakılmalı?"};
    public static readonly string[] LayoutAttributesTip = {
      "A list of attributes for substitution into all sheet blocks. \r\n" +
        "Each attribute on a new line. Write values after the = sign. \r\n" +
        "You can use all sheet property substitutions, its viewports and objects in viewports.",
      "Список атрибутов для подстановки во все блоки листа. \r\n" +
        "Каждый атрибут в новой строке. Значения пишите после символа =. \r\n" +
        "Можно использовать все подстановки свойств листа, его вьюпортов и объектов во вьюпортах.",
      "Elenco di attributi per la sostituzione in tutti i blocchi del foglio. \r\n" +
        "Ogni attributo su una nuova riga. Scrivi i valori dopo il segno =. \r\n" +
        "È possibile utilizzare tutte le sostituzioni delle proprietà del foglio, i suoi viewport e gli oggetti nei viewport.",
      "Eine Liste von Attributen zur Substitution in alle Blattblöcke. \r\n" +
        "Jedes Attribut in einer neuen Zeile. Schreiben Sie Werte nach dem = Zeichen. \r\n" +
        "Sie können alle Blatt-Eigenschaftenersetzungen, seine Ansichtsfenster und Objekte in Ansichtsfenstern verwenden.",
      "所有图纸块的属性列表。 \r\n" +
        "每个属性占一行。在 = 符号后写值。 \r\n" +
        "您可以使用所有图纸属性替换、其视口和视口中的对象。",
      "Lista de atributos para sustituir en todos los bloques de la hoja.\r\n" +
        "Cada atributo en una línea. Valores tras '='.\r\n" +
        "Puede utilizar todas las sustituciones de propiedades de hoja, sus ventanas gráficas y los objetos en las ventanas gráficas.",
      "Liste d’attributs à substituer dans tous les blocs de la feuille.\r\n" +
        "Un attribut par ligne. Valeurs après '='.\r\n" +
        "Vous pouvez utiliser toutes les substitutions de propriétés de la feuille, ses fenêtres d'affichage et les objets dans les fenêtres d'affichage.",
      "Tüm sayfa bloklarına konulacak öznitelikler listesi.\r\n" +
        "Her satıra bir öznitelik. Değerler '=' sonrası.\r\n" +
        "Sayfa özelliklerinin tümünü, görüntü alanlarını ve görüntü alanlarındaki nesneleri kullanabilirsiniz." };


  }
}