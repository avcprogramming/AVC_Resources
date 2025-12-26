// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

using System;
using System.Security.Cryptography;

namespace AVC
{
  public static class
  ExposeL
  {
    public static readonly string[][] ExposeStyleNames = {
/* 0 */ CommandL.Expose,
/* 1 */ CommandL.Expose,
/* 2 */ new []{
        "Separate layers and scales",
        "Разделять слои и масштабы",
        "Strati e scale separati",
        "Separate Ebenen und Skalen",
        "分离层和尺度",
        "Separar capas y escalas",                     // ES
        "Séparer les calques et les échelles",         // FR
        "Katmanları ve ölçekleri ayır" },              // TR
/* 3 */ CommandL.TNT
    };

    public static readonly string[] ExposeStyle = {
      "  Expose-style will be used: {0}",
      "  Будет использован стиль Выставки: {0}",
      "  Allineare-stile sarà usato: {0}",
      "  Der Ordnen-stil wird verwendet: {0}" ,
      "  将使用布局样式（Expose)：{0}",
      "  Se utilizará el estilo Expose: {0}",          // ES
      "  Le style Expose sera utilisé : {0}",          // FR
      "  Expose stili kullanılacak: {0}"};             // TR

    public static readonly string[] Select = {
      "  Select block-assemblies",
      "  Выберите блоки-сборки",
      "  Seleziona i blocchi di assemblaggio",
      "  Montageblöcke auswählen",
      "  选择装配块",
      "  Seleccione bloques de ensamblaje",            // ES
      "  Sélectionnez les blocs d'assemblage",         // FR
      "  Montaj bloklarını seçin"};                    // TR

    public static readonly string[] SpecifyPoint = {
      "  Specify the coordinates to insert exposed assemblies",
      "  Укажите координаты, где начинать выставлять сборки",
      "  Specificare le coordinate dove iniziare a esporre gli assembramenti",
      "  Geben Sie die Koordinaten an, an denen mit dem Ausstellen von Versammlungen begonnen werden soll",
      "  指定开始展示程序集的坐标",
      "  Especifique las coordenadas para insertar ensamblajes expuestos",  // ES
      "  Spécifiez les coordonnées pour insérer des assemblages exposés",  // FR
      "  Açığa çıkarılan montajları eklemek için koordinatları belirtin" };  // TR

    public static readonly string[] StyleSelected = {
      "  Expose-style '{0}' selected",
      "  Выбран стиль выставки '{0}'",
      "  Expose-Stile '{0}' selezionato",
      "  Expose-Stil '{0}' ausgewählt",
      "  选择的样式 {0}",
      "  Estilo Expose '{0}' seleccionado",            // ES
      "  Style Expose '{0}' sélectionné",              // FR
      "  Expose stili '{0}' seçildi"};                 // TR

    public static readonly string[] ExposeErr = {
      "Failed to expose assembly {0}",
      "Не удалось выставить сборку {0}",
      "Impossibile esporre l'assembly {0}",
      "Assembly {0} konnte nicht verfügbar gemacht werden",
      "未能公开程序集 {0}",
      "No se pudo exponer el ensamblaje {0}",          // ES
      "Échec de l'exposition de l'assemblage {0}",    // FR
      "Montaj {0} açığa çıkarılamadı"};               // TR

    // ====================== Options Dialog ======================================================

    public static readonly string[] StyleNameTip = {
      "Name for this Expose-style. \r\n" +
        "Not used in the program. For convenience only.",
      "Название для этого стиля выставки. \r\n" +
        "Не используется в работе программы. Только для удобства выбора.",
      "Nome per questo stile Expose. \r\n" +
        "Non utilizzato nel programma. Solo per comodità.",
      "Name für diesen Expose-Stil. \r\n" +
        "Wird im Programm nicht verwendet. Nur aus Bequemlichkeit." ,
      "此 Expose 样式的名称。 \r\n" +
        "没有在程序中使用。 仅为方便起见。",
      "Nombre para este estilo Expose. \r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia.",
      "Nom pour ce style Expose. \r\n" +  // FR
        "Non utilisé dans le programme. Par commodité seulement.",
      "Bu Expose stili için ad. \r\n" +  // TR
        "Programda kullanılmaz. Sadece kolaylık için."};

    public static readonly string[] MakeTitleTip = {
      "Insert a header into model space for each assembly.",
      "Вставить в модель заголовок для каждой сборки.",
      "Inserire un'intestazione nello spazio modello per ogni assieme.",
      "Fügen Sie für jede Baugruppe eine Kopfzeile in den Modellbereich ein." ,
      "将标题插入到每个装配体的模型空间中。",
      "Insertar un encabezado en el espacio modelo para cada ensamblaje.",  // ES
      "Insérer un en-tête dans l'espace modèle pour chaque assemblage.",  // FR
      "Her montaj için model alanına bir başlık ekleyin."};  // TR

    public static readonly string[] TitleTip = {
      "Assembly header template.\r\n" +
        "Use block-assembly and drawing block property and attribute substitutions.\r\n" +
        "You can add any text and formatting characters (eg \\P - line break).",
      "Шаблон заголовка сборки.\r\n" +
        "Используйте подстановки свойств и атрибутов блока-сборки и чертежа.\r\n" +
        "Вы можете добавить любой текст и символы форматирования (например, \\P - перенос строки).",
      "Modello di intestazione dell'assieme.\r\n" +
        "Utilizza proprietà di assemblaggio di blocchi e blocchi di disegno e sostituzioni di attributi.\r\n" +
        "Puoi aggiungere qualsiasi testo e carattere di formattazione (ad es. \\P - interruzione di riga).",
      "Assembly-Header-Vorlage.\r\n" +
        "Verwenden Sie die Eigenschafts- und Attributersetzungen für Blockmontagen und Zeichnungsblöcke.\r\n" +
        "Sie können beliebigen Text und Formatierungszeichen hinzufügen (zB \\P - Zeilenumbruch)." ,
      "程序集标题模板。\r\n" +
        "使用块装配和绘图块属性和属性替换。\r\n" +
        "您可以添加任何文本和格式字符（例如 \\P - 换行符）。",
      "Plantilla de encabezado de ensamblaje.\r\n" +  // ES
        "Use sustituciones de propiedades y atributos de bloque de ensamblaje y bloque de dibujo.\r\n" +
        "Puede agregar cualquier texto y caracteres de formato (por ejemplo, \\P - salto de línea).",
      "Modèle d'en-tête d'assemblage.\r\n" +  // FR
        "Utilisez les substitutions de propriétés et d'attributs de bloc d'assemblage et de bloc de dessin.\r\n" +
        "Vous pouvez ajouter du texte et des caractères de formatage (par exemple \\P - saut de ligne).",
      "Montaj başlığı şablonu.\r\n" +  // TR
        "Blok montajı ve çizim bloğu özelliği ve öznitelik değiştirmelerini kullanın.\r\n" +
        "Herhangi bir metin ve biçimlendirme karakteri ekleyebilirsiniz (örneğin \\P - satır sonu)."};

    public static readonly string[] TitlePosition = {
      "Position",
      "Расположить",
      "Organizzare",
      "Arrangieren",
      "安排",
      "Posición",                                      // ES
      "Position",                                      // FR
      "Konum" };                                       // TR

    public static readonly string[] Above = {
      "Above",
      "Над",
      "Sopra",
      "Über",
      "多于",
      "Arriba",                                        // ES
      "Au-dessus",                                     // FR
      "Yukarıda" };                                    // TR

    public static readonly string[] AboveTip = {
      "Place the title above the assembly. Title offset from the assembly can be configured.",
      "Разместить заголовок выше над сборкой. Отступ от сборки можно настроить.",
      "Posizionare l'intestazione sopra l'assieme. È possibile configurare l'offset dell'intestazione dall'assieme.",
      "Platzieren Sie den Header über der Baugruppe. Header-Offset von der Assembly kann konfiguriert werden.",
      "将标题放在组件上方。 可以配置标题与程序集的偏移量。",
      "Coloque el título encima del ensamblaje. Se puede configurar el desplazamiento del título desde el ensamblaje.",  // ES
      "Placez le titre au-dessus de l'assemblage. Le décalage du titre par rapport à l'assemblage peut être configuré.",  // FR
      "Başlığı montajın üzerine yerleştirin. Montajdan başlık ofseti yapılandırılabilir." };  // TR

    public static readonly string[] InsideTip = {
      "Place text inside assembly dimensions.\r\n"+
         "If you turn on the render mode with solid face fills,\r\n"+
         "then you won't see the header, because the texts will be under the assembly.",
      "Разместить текст внутри габаритов сборки.\r\n"+
        "Если вы включите режим визуализации с заливкой граней твердых тел,\r\n"+
        "то вы не увидите заголовка, т.к. тексты окажутся под сборкой.",
      "Posizionare il testo all'interno delle quote dell'assieme.\r\n"+
         "Se attivi la modalità di rendering con riempimenti faccia pieni,\r\n"+
         "allora non vedrai l'intestazione, perché i testi saranno sotto l'assemblea.",
      "Text innerhalb der Montageabmessungen platzieren.\r\n"+
         "Wenn Sie den Rendermodus mit einfarbigen Flächenfüllungen aktivieren,\r\n"+
         "Dann sehen Sie die Kopfzeile nicht, weil die Texte unter der Baugruppe stehen." ,
      "将文本放在装配尺寸内，而不是高于装配尺寸。\r\n"+
         "如果您打开带有实体面填充的渲染模式，\r\n"+
         "那么您将看不到标题，因为文本将在集会下。",
      "Coloque el texto dentro de las dimensiones del ensamblaje.\r\n"+  // ES
         "Si activa el modo de renderizado con rellenos de caras sólidas,\r\n"+
         "entonces no verá el encabezado, porque los textos estarán debajo del ensamblaje.",
      "Placez le texte à l'intérieur des dimensions de l'assemblage.\r\n"+  // FR
         "Si vous activez le mode de rendu avec des remplissages de face solides,\r\n"+
         "alors vous ne verrez pas l'en-tête, car les textes seront sous l'assemblage.",
      "Metni montaj boyutlarının içine yerleştirin.\r\n"+  // TR
         "Katı yüz dolguları ile işleme modunu açarsanız,\r\n"+
         "başlığı göremezsiniz çünkü metinler montajın altında olacaktır."};

    public static readonly string[] Below = {
      "Below",
      "Под",
      "Sotto",
      "Unter",
      "在下面",
      "Debajo",                                        // ES
      "En dessous",                                    // FR
      "Aşağıda" };                                     // TR

    public static readonly string[] BelowTip = {
      "Place the title below the assembly. Title offset from the assembly can be configured.",
      "Разместить заголовок ниже под сборкой. Отступ от сборки можно настроить.",
      "Posizionare l'intestazione sotto l'assieme. È possibile configurare l'offset dell'intestazione dall'assieme.",
      "Platzieren Sie die Kopfzeile unter der Baugruppe. Header-Offset von der Assembly kann konfiguriert werden.",
      "将标题放在组件下方。 可以配置标题与程序集的偏移量。",
      "Coloque el título debajo del ensamblaje. Se puede configurar el desplazamiento del título desde el ensamblaje.",  // ES
      "Placez le titre en dessous de l'assemblage. Le décalage du titre par rapport à l'assemblage peut être configuré.",  // FR
      "Başlığı montajın altına yerleştirin. Montajdan başlık ofseti yapılandırılabilir." };  // TR

    public static readonly string[] CenterTip = {
      "Align the center of the header to the center of the assembly dimensions.\r\n"+
         "If the title is inside the part, then vertical centering will be done too.",
      "Выравнивать центр заголовка по центру габаритов сборки.\r\n"+
        "Если заголовок внутри детали, то будет производится и вертикальное центрирование тоже.",
      "Allineare il centro dell'intestazione al centro delle quote dell'assieme.\r\n"+
         "Se il titolo è all'interno della parte, verrà eseguita anche la centratura verticale.",
      "Richten Sie die Mitte des Headers an der Mitte der Montageabmessungen aus.\r\n"+
         "Wenn sich der Titel innerhalb des Teils befindet, wird auch eine vertikale Zentrierung durchgeführt." ,
      "将标题的中心与程序集尺寸的中心对齐。\r\n"+
         "如果标题在部分内部，那么也会进行垂直居中。",
      "Alinear el centro del encabezado con el centro de las dimensiones del ensamblaje.\r\n"+  // ES
         "Si el título está dentro de la pieza, también se realizará el centrado vertical.",
      "Aligner le centre de l'en-tête sur le centre des dimensions de l'assemblage.\r\n"+  // FR
         "Si le titre est à l'intérieur de la pièce, le centrage vertical sera également effectué.",
      "Başlığın merkezini montaj boyutlarının merkezine hizalayın.\r\n"+  // TR
         "Başlık parçanın içindeyse, dikey ortalama da yapılacaktır."};

    public static readonly string[] SpaceX = {
      "X space",
      "Отступ по X",
      "Infuriare su X",
      "Tobend auf X" ,
      "在X上偏移",
      "Espacio X",                                     // ES
      "Espace X",                                      // FR
      "X aralığı"};                                    // TR

    public static readonly string[] SpaceY = {
      "Y space",
      "Отступ по Y",
      "Offset su Y",
      "Offset auf Y" ,
      "在Y上偏移",
      "Espacio Y",                                     // ES
      "Espace Y",                                      // FR
      "Y aralığı"};                                    // TR

    public static readonly string[] SpaceZ = {
      "Z space",
      "Отступ по Z",
      "Offset su Z",
      "Offset auf Z" ,
      "在Z上偏移",
      "Espacio Z",                                     // ES
      "Espace Z",                                      // FR
      "Z aralığı"};                                    // TR

    public static readonly string[] SpaceTip = {
      "Distance between assemblies along one axis. \r\n" +
        "If you specify 0, then the program will indent the size of the assembly size.",
      "Расстояние между сборками по одной оси. \r\n" +
        "Если указать 0, то программа сделает отступ размером с габарит сборки.",
      "Distanza tra gli assiemi lungo un asse. \r\n" +
        "Se si specifica 0, il programma rientrerà la dimensione della dimensione dell'assieme.",
      "Abstand zwischen Baugruppen entlang einer Achse. \r\n" +
        "Wenn Sie 0 angeben, rückt das Programm die Größe der Assemblygröße ein." ,
      "组件之间沿一根轴的距离。 \r\n" +
        "如果指定 0，则程序将缩进程序集的大小。",
      "Distancia entre ensamblajes a lo largo de un eje. \r\n" +  // ES
        "Si especifica 0, el programa sangrará el tamaño del tamaño del ensamblaje.",
      "Distance entre les assemblages le long d'un axe. \r\n" +  // FR
        "Si vous spécifiez 0, le programme indentera la taille de la taille de l'assemblage.",
      "Bir eksen boyunca montajlar arasındaki mesafe. \r\n" +  // TR
        "0 belirtirseniz, program montaj boyutunun boyutunu girintili yapacaktır."};

    public static readonly string[] StepPlusSize = {
      "Add assembly size",
      "Прибавлять размер сборки",
      "Aggiungi la dimensione dell'assieme",
      "Fügen Sie die Montagegröße hinzu" ,
      "添加组件大小",
      "Agregar tamaño de ensamblaje",                  // ES
      "Ajouter la taille de l'assemblage",             // FR
      "Montaj boyutunu ekle"};                         // TR

    public static readonly string[] StepPlusSizeTip = {
      "The distance between assemblies will be equal to the specified space plus the assembly size. \r\n" +
        "If you disable this option, you'll need to specify an indentation much larger than the largest assembly.\r\n" +
        "But the assemblies will be arranged with uniform spacing.",
      "Расстояние между сборками будет равно размеру сборки плюс указанный отступ. \r\n" +
        "Если опцию отключить, то потребуется указать отступ на много больше самой большой сборки.\r\n" +
        "Но зато сборки будут выстроены с равномерным шагом.",
      "La distanza tra gli assiemi sarà pari alla dimensione dell'assieme più il rientro specificato.\r\n" +
        "Se disabiliti questa opzione, dovrai specificare un rientro molto più grande dell'assembly più grande.\r\n" +
        "Tuttavia, gli assembly saranno disposti con una spaziatura uniforme.",
      "Der Abstand zwischen den Baugruppen entspricht der Baugröße plus dem angegebenen Einzug.\r\n" +
        "Wenn Sie diese Option deaktivieren, müssen Sie einen deutlich größeren Einzug als die größte Baugruppe angeben.\r\n" +
        "Die Baugruppen werden jedoch mit gleichmäßigem Abstand angeordnet." ,
      "组件之间的距离将等于组件大小加上指定的缩进。\r\n" +
        "如果禁用此选项，则需要指定比最大组件大得多的缩进。\r\n" +
        "但是，组件将以均匀的间距排列。",
      "La distancia entre ensamblajes será igual al espacio especificado más el tamaño del ensamblaje. \r\n" +  // ES
        "Si desactiva esta opción, deberá especificar una sangría mucho mayor que el ensamblaje más grande.\r\n" +
        "Pero los ensamblajes se organizarán con espaciado uniforme.",
      "La distance entre les assemblages sera égale à l'espace spécifié plus la taille de l'assemblage. \r\n" +  // FR
        "Si vous désactivez cette option, vous devrez spécifier une indentation beaucoup plus grande que le plus grand assemblage.\r\n" +
        "Mais les assemblages seront disposés avec un espacement uniforme.",
      "Montajlar arasındaki mesafe, belirtilen boşluk artı montaj boyutuna eşit olacaktır. \r\n" +  // TR
        "Bu seçeneği devre dışı bırakırsanız, en büyük montajdan çok daha büyük bir girinti belirtmeniz gerekecektir.\r\n" +
        "Ancak montajlar düzgün aralıklarla düzenlenecektir."};

    public static readonly string[] TitleSpaceTip = {
      "Extra padding between header and assembly. \r\n" +
         "Set to 0 to use a padding equal to the height of the title text.\r\n" +
         "Only fires when the title is placed above the assembly, not inside its dimensions.",
      "Дополнительный отступ между заголовком и сборкой. \r\n" +
        "Назначьте 0, чтоб использовать отступ равный высоте текста заголовка.\r\n" +
        "Срабатывает только когда заголовок размещается над сборкой, а не внутри ее габаритов.",
      "Imbottitura extra tra intestazione e assemblaggio. \r\n" +
         "Imposta a 0 per usare un padding uguale all'altezza del testo del titolo.\r\n" +
         "Si attiva solo quando l'intestazione è posizionata sopra l'assieme, non all'interno delle sue dimensioni.",
      "Zusätzliche Polsterung zwischen Header und Baugruppe. \r\n" +
         "Auf 0 setzen, um eine Auffüllung gleich der Höhe des Titeltextes zu verwenden.\r\n" +
         "Wird nur ausgelöst, wenn der Header über der Baugruppe platziert wird, nicht innerhalb ihrer Abmessungen." ,
      "标头和程序集之间的额外填充。 \r\n" +
         "设置为 0 以使用等于标题文本高度的填充。\r\n" +
         "仅当标头位于程序集上方而不是其尺寸内时才会触发。",
      "Relleno adicional entre el encabezado y el ensamblaje. \r\n" +  // ES
         "Establezca en 0 para usar un relleno igual a la altura del texto del título.\r\n" +
         "Solo se activa cuando el título se coloca encima del ensamblaje, no dentro de sus dimensiones.",
      "Remplissage supplémentaire entre l'en-tête et l'assemblage. \r\n" +  // FR
         "Définissez sur 0 pour utiliser un remplissage égal à la hauteur du texte du titre.\r\n" +
         "Ne se déclenche que lorsque le titre est placé au-dessus de l'assemblage, pas à l'intérieur de ses dimensions.",
      "Başlık ve montaj arasında ekstra dolgu. \r\n" +  // TR
         "Başlık metninin yüksekliğine eşit bir dolgu kullanmak için 0'a ayarlayın.\r\n" +
         "Yalnızca başlık montajın üzerine yerleştirildiğinde tetiklenir, boyutlarının içinde değil."};

    public static readonly string[] ExposeFrame = {
      "Exposition frame",
      "Рамка выставки",
      "Esponi in cornice",
      "Im Rahmen aussetzen" ,
      "在框架中曝光",
      "Marco de exposición",                           // ES
      "Cadre d'exposition",                            // FR
      "Sergileme çerçevesi"};                          // TR

    public static readonly string[] ExposeFrameTip = {
      "Draw a polyline around the entire assembly exposition. \r\n" +
        "The non-printable Info layer will be used for the frame.",
      "Начертить полилинию вокруг всей выставки сборок. \r\n" +
        "Для рамки будет использован непечатаемый слой Инфо.",
      "Disegna una polilinea attorno all'intera esposizione dell'assieme. \r\n" +
        "Il livello Info non stampabile verrà utilizzato per la cornice.",
      "Ziehen Sie eine Polylinie um die gesamte Montageausstellung. \r\n" +
        "Für den Rahmen wird die nicht druckbare Info-Ebene verwendet." ,
      "围绕整个装配展览画一条折线。 \r\n" +
        "不可打印的信息层将用于框架。",
      "Dibuje una polilínea alrededor de toda la exposición del ensamblaje. \r\n" +  // ES
        "La capa Info no imprimible se utilizará para el marco.",
      "Dessinez une polyligne autour de toute l'exposition de l'assemblage. \r\n" +  // FR
        "La couche Info non imprimable sera utilisée pour le cadre.",
      "Tüm montaj sergisinin etrafına bir çoklu çizgi çizin. \r\n" +  // TR
        "Çerçeve için yazdırılamayan Bilgi katmanı kullanılacaktır."};

    public static readonly string[] AssemblyFrame = {
      "Assembly frame",
      "Рамка сборки",
      "Assemblaggio in cornice",
      "Baugruppe im Rahmen" ,
      "在框架中组装",
      "Marco de ensamblaje",                           // ES
      "Cadre d'assemblage",                            // FR
      "Montaj çerçevesi"};                             // TR

    public static readonly string[] AssemblyFrameTip = {
      "Draw a polyline around each assembly (including a title). \r\n" +
        "The non-printable Info layer will be used for the frame.",
      "Начертить полилинию вокруг каждой сборки (вместе с заголовком). \r\n" +
        "Для рамки будет использован непечатаемый слой Инфо.",
      "Disegna una polilinea attorno a ciascun assieme (compreso un titolo). \r\n" +
        "Il livello Info non stampabile verrà utilizzato per la cornice.",
      "Zeichnen Sie eine Polylinie um jede Baugruppe (einschließlich eines Titels). \r\n" +
        "Für den Rahmen wird die nicht druckbare Info-Ebene verwendet." ,
      "围绕每个组件（包括标题）绘制多段线。 \r\n" +
        "不可打印的信息层将用于框架。",
      "Dibuje una polilínea alrededor de cada ensamblaje (incluido un título). \r\n" +  // ES
        "La capa Info no imprimible se utilizará para el marco.",
      "Dessinez une polyligne autour de chaque assemblage (y compris un titre). \r\n" +  // FR
        "La couche Info non imprimable sera utilisée pour le cadre.",
      "Her montajın etrafına (başlık dahil) bir çoklu çizgi çizin. \r\n" +  // TR
        "Çerçeve için yazdırılamayan Bilgi katmanı kullanılacaktır."};

    public static readonly string[] FrameSpace = {
      "Frame space",
      "Отступ рамки",
      "Offset del telaio",
      "Rahmenoffset" ,
      "框架间隙",
      "Espacio del marco",                             // ES
      "Espace du cadre",                               // FR
      "Çerçeve boşluğu"};                              // TR

    public static readonly string[] FrameSpaceTip = {
      "The distance from the assembly to the frame and from all assemblies to the frame of the entire exhibition. \r\n" +
        "If you specify 0, then the program will select the indent itself based on the dimensions of the assembly.",
      "Расстояние от сборки до рамки и от всех сборок до рамки всей выставки. \r\n" +
        "Если указать 0, то программа подберет отступ сама на основе размеров сборки.",
      "La distanza dall'assieme al telaio e da tutti gli assemblaggi al telaio dell'intera mostra. \r\n" +
        "Se si specifica 0, il programma selezionerà il rientro stesso in base alle dimensioni dell'assieme.",
      "Der Abstand von der Baugruppe zum Rahmen und von allen Baugruppen zum Rahmen der gesamten Ausstellung. \r\n" +
        "Wenn Sie 0 angeben, wählt das Programm den Einzug selbst basierend auf den Abmessungen der Baugruppe aus." ,
      "从组件到框架以及从所有组件到整个展览框架的距离。 \r\n" +
        "如果您指定 0，则程序将根据装配体的尺寸自行选择缩进。",
      "La distancia desde el ensamblaje hasta el marco y desde todos los ensamblajes hasta el marco de toda la exposición. \r\n" +  // ES
        "Si especifica 0, el programa seleccionará la sangría en función de las dimensiones del ensamblaje.",
      "La distance de l'assemblage au cadre et de tous les assemblages au cadre de toute l'exposition. \r\n" +  // FR
        "Si vous spécifiez 0, le programme sélectionnera lui-même l'indentation en fonction des dimensions de l'assemblage.",
      "Montajdan çerçeveye ve tüm montajlardan tüm serginin çerçevesine olan mesafe. \r\n" +  // TR
        "0 belirtirseniz, program girintiyi montajın boyutlarına göre kendisi seçecektir."};

    public static readonly string[] OptimalInsertPoint = {
      "Choose the best insertion point",
      "Подбирать лучшую точку вставки",
      "Scegli il miglior punto di inserimento",
      "Wählen Sie den besten Einfügepunkt" ,
      "选择最佳插入点",
      "Elegir el mejor punto de inserción",            // ES
      "Choisir le meilleur point d'insertion",         // FR
      "En iyi ekleme noktasını seçin"};                // TR

    public static readonly string[] OptimalInsertPointTip = {
      "Ignore the block's normal insertion point.\r\n" +
        "Search for the minimum (lowest-left) point on assembly objects and insert blocks at this point.\r\n" +
        "This option is useful when assembly blocks are thoughtlessly created \r\n" +
        "and their insertion point is far beyond the assembly details.",
      "Игнорировать обычную точку вставки блока. \r\n" +
        "Искать минимальную (самую нижнюю-левую) точку на объектах сборки и вставлять блоки на этой точке.\r\n" +
        "Эта опция удобна, когда блоки-сборки созданы бездумно \r\n" +
        "и их точка вставки находится далеко за пределами деталей сборки.",
      "Ignora il normale punto di inserimento del blocco.\r\n" +
         "Cerca il punto minimo (in basso a sinistra) sugli oggetti dell'assieme e inserisci i blocchi in questo punto.\r\n" +
         "Questa opzione è utile quando i blocchi di assemblaggio vengono creati senza pensarci \r\n" +
        "e il loro punto di inserimento è molto al di fuori dei dettagli dell'assieme.",
      "Ignorieren Sie den normalen Einfügepunkt des Blocks.\r\n" +
         "Suchen Sie nach dem minimalen Punkt (unten links) auf Montageobjekten und fügen Sie an dieser Stelle Blöcke ein.\r\n" +
         "Diese Option ist nützlich, wenn Montageblöcke gedankenlos erstellt werden \r\n" +
        "und ihr Einfügepunkt weit hinter den Montagedetails liegt." ,
      "忽略块的正常插入点。\r\n" +
         "在装配对象上搜索最小（左下）点并在该点插入块。\r\n" +
         "当不经意地创建装配块并且它们的插入点远离装配细节时，此选项很有用。",
      "Ignorar el punto de inserción normal del bloque.\r\n" +  // ES
         "Busque el punto mínimo (inferior izquierdo) en los objetos de ensamblaje e inserte bloques en este punto.\r\n" +
         "Esta opción es útil cuando los bloques de ensamblaje se crean sin pensar \r\n" +
        "y su punto de inserción está mucho más allá de los detalles del ensamblaje.",
      "Ignorer le point d'insertion normal du bloc.\r\n" +  // FR
         "Recherchez le point minimum (en bas à gauche) sur les objets d'assemblage et insérez des blocs à ce point.\r\n" +
         "Cette option est utile lorsque les blocs d'assemblage sont créés sans réfléchir \r\n" +
        "et que leur point d'insertion est bien au-delà des détails de l'assemblage.",
      "Bloğun normal ekleme noktasını yoksayın.\r\n" +  // TR
         "Montaj nesnelerinde minimum (sol alt) noktayı arayın ve bu noktaya bloklar ekleyin.\r\n" +
         "Bu seçenek, montaj bloklarının düşünmeden oluşturulduğu \r\n" +
        "ve ekleme noktalarının montaj ayrıntılarının çok ötesinde olduğu durumlarda kullanışlıdır."};

    public static readonly string[] OptimalRotation = {
      "Facing forward",
      "Разворачивать фасадом вперед",
      "Rivolto in avanti",
      "Nach vorne gerichtet" ,
      "面向前方",
      "Mirando hacia adelante",                        // ES
      "Tourné vers l'avant",                           // FR
      "Öne dönük"};                                    // TR

    public static readonly string[] OptimalRotationTip = {
      "Rotate the block around the Z-axis so that the largest flat surface is rotated in the opposite direction of the Y-axis.\r\n" +
        "This option is useful when assembly blocks were created thoughtlessly \r\n" +
        "and were initially deployed with facades in different directions.\r\n" +
        "For flat blocks, the longest line will be found and expanded along X.\r\n" +
        "It is not recommended to use the option in complex assemblies, \r\n" +
        "since it will take a long time to sort through all the faces of all solids.",
      "Вращать блок вокруг оси Z, так чтоб наибольшая плоская поверхность была развернута в направлении обратном оси Y.\r\n" +
        "Эта опция удобна, когда блоки-сборки созданы бездумно и были изначально развернуты фасадами в разные стороны.\r\n" +
        "Для плоских блоков будет найдена самая длинная линия и она будет развернута вдоль X.\r\n" +
        "Не рекомендуется использовать опцию в сложных сборках, так как потребуется долго перебирать все грани всех солидов.",
      "Ruota il blocco attorno all'asse Z \r\n" +
        "in modo che la superficie piana più grande venga ruotata nella direzione opposta all'asse Y.\r\n" +
        "Questa opzione è utile quando i blocchi di assemblaggio sono stati creati senza pensarci \r\n" +
        "e sono stati inizialmente distribuiti con facciate in direzioni diverse.\r\n" +
        "Per i blocchi piatti, la linea più lunga verrà trovata ed espansa lungo X.\r\n" +
        "Non è consigliabile utilizzare l'opzione in assiemi complessi, \r\n" +
        "poiché richiederà molto tempo per selezionare tutte le facce di tutti i solidi.",
      "Drehen Sie den Block um die Z-Achse, sodass die größte flache Oberfläche \r\n" +
        "in die entgegengesetzte Richtung der Y-Achse gedreht wird.\r\n" +
         "Diese Option ist sinnvoll, wenn Montageklötze unbedacht erstellt \r\n" +
        "und zunächst mit Fassaden in unterschiedlichen Richtungen eingesetzt wurden.\r\n" +
         "Bei flachen Blöcken wird die längste Linie gefunden und entlang X erweitert.\r\n" +
         "Es wird nicht empfohlen, die Option in komplexen Baugruppen zu verwenden, \r\n" +
        "da es lange dauert, alle Flächen aller Volumenkörper zu durchlaufen." ,
      "围绕 Z 轴旋转块，使最大平面沿 Y 轴的相反方向旋转。\r\n" +
         "当组装块被轻率地创建并且最初部署在不同方向的立面时，这个选项很有用。\r\n" +
         "对于平面块，将找到最长的线并沿 X 展开。\r\n" +
         "不建议在复杂的装配体中使用该选项，因为遍历所有实体的所有面需要很长时间。",
      "Gire el bloque alrededor del eje Z para que la superficie plana más grande gire en la dirección opuesta al eje Y.\r\n" +  // ES
        "Esta opción es útil cuando los bloques de ensamblaje se crearon sin pensar \r\n" +
        "y se implementaron inicialmente con fachadas en diferentes direcciones.\r\n" +
        "Para bloques planos, se encontrará la línea más larga y se expandirá a lo largo de X.\r\n" +
        "No se recomienda usar la opción en ensamblajes complejos, \r\n" +
        "ya que llevará mucho tiempo clasificar todas las caras de todos los sólidos.",
      "Faites pivoter le bloc autour de l'axe Z pour que la plus grande surface plane soit tournée dans la direction opposée à l'axe Y.\r\n" +  // FR
        "Cette option est utile lorsque les blocs d'assemblage ont été créés sans réfléchir \r\n" +
        "et ont été initialement déployés avec des façades dans différentes directions.\r\n" +
        "Pour les blocs plats, la ligne la plus longue sera trouvée et étendue le long de X.\r\n" +
        "Il n'est pas recommandé d'utiliser l'option dans des assemblages complexes, \r\n" +
        "car il faudra beaucoup de temps pour trier toutes les faces de tous les solides.",
      "Bloğu Z ekseni etrafında döndürün, böylece en büyük düz yüzey Y ekseninin ters yönünde döndürülür.\r\n" +  // TR
        "Bu seçenek, montaj bloklarının düşünmeden oluşturulduğu \r\n" +
        "ve başlangıçta farklı yönlerde cephelerle konuşlandırıldığı durumlarda kullanışlıdır.\r\n" +
        "Düz bloklar için en uzun çizgi bulunacak ve X boyunca genişletilecektir.\r\n" +
        "Karmaşık montajlarda seçeneği kullanmanız önerilmez, \r\n" +
        "çünkü tüm katıların tüm yüzlerini sıralamak uzun zaman alacaktır."};

    public static readonly string[] LayerTip = {
      "Assign a layer for exposed blocks (assemblies). If you leave the field empty, then the original layer of the block will be saved.",
      "Назначить слой для выставленных блоков(сборок). Если оставить поле пустым, то сохранится изначальный слой блока.",
      "Assegna un livello per i blocchi esposti (assiemi). Se lasci il campo vuoto, verrà salvato il layer originale del blocco.",
      "Weisen Sie exponierten Blöcken (Baugruppen) eine Ebene zu. Wenn Sie das Feld leer lassen, wird die ursprüngliche Ebene des Blocks gespeichert.",
      "为暴露的块（组件）分配一个层。 如果将该字段留空，则块的原始层将被保存。",
      "Asigne una capa para bloques expuestos (ensamblajes). Si deja el campo vacío, se guardará la capa original del bloque.",  // ES
      "Attribuez un calque aux blocs exposés (assemblages). Si vous laissez le champ vide, le calque d'origine du bloc sera enregistré.",  // FR
      "Açığa çıkarılan bloklar (montajlar) için bir katman atayın. Alanı boş bırakırsanız, bloğun orijinal katmanı kaydedilecektir." };  // TR

    public static readonly string[] TntTip = {
      "Call the TNT command (assembly explosion) and explode the details of each assembly in space.",
      "Вызвать команду TNT (взрыв сборки) и разнести детали каждой сборки в пространстве.",
      "Chiama il comando TNT (esplosione dell'assieme) ed esplodi i dettagli di ogni assieme nello spazio.",
      "Rufen Sie den TNT-Befehl (Montageexplosion) auf und lassen Sie die Details jeder Baugruppe im Weltraum explodieren.",
      "调用TNT命令（装配体爆炸），在空间中对每个装配体的细节进行爆炸。",
      "Llame al comando TNT (explosión de ensamblaje) y explote los detalles de cada ensamblaje en el espacio.",  // ES
      "Appelez la commande TNT (explosion d'assemblage) et explosez les détails de chaque assemblage dans l'espace.",  // FR
      "TNT komutunu (montaj patlaması) çağırın ve her montajın ayrıntılarını uzayda patlayın." };  // TR

  }
}