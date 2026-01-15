// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public class 
  TitleStyleL
  {
    public static readonly string[] TitleOn = {
      "Make Title",
      "Создать заголовок",
      "Crea intestazione",
      "Titel erstellen",
      "生成标题",
      "Crear título",                                          // ES
      "Créer le titre",                                        // FR
      "Başlık Oluştur" };                                      // TR

    public static readonly string[] TitleOnTip = {
      "Insert title for each drawing.",
      "Вставить текстовый заголовок для каждого чертежа.",
      "Inserisci il titolo per ogni disegno.",
      "Titel für jede Zeichnung einfügen.",
      "为每个图纸插入标题文字。",
      "Insertar título para cada dibujo.",                      // ES
      "Insérer le titre pour chaque dessin.",                   // FR
      "Her çizim için başlık ekle."};                           // TR

    public static readonly string[] TextTip = {
      "A Multiline Text (MText) will be created as the title.",
      "В качестве заголовка будет создан Многострочный текст (MText).",
      "Verrà creato un Testo Multilinea (MText) come titolo.",
      "Ein Mehrzeiliger Text (MText) wird als Titel erstellt.",
      "将创建多行文字（MText）作为标题。",
      "Se creará un Texto Multilínea (MText) como título.",      // ES
      "Un Texte Multiligne (MText) sera créé en tant que titre.", // FR
      "Başlık olarak Çok Satırlı Metin (MText) oluşturulacak."}; // TR

    public static readonly string[] BlockTip = {
      "An existing 2D block will be inserted as a title.",
      "В качестве заголовка будет вставлен существующий 2D блок.",
      "Un blocco 2D esistente verrà inserito come intestazione.",
      "Ein vorhandener 2D-Block wird als Kopfzeile eingefügt.",
      "现有的2D块将作为标题插入。",
      "Se insertará un bloque 2D existente como encabezado.",    // ES
      "Un bloc 2D existant sera inséré en tant qu'en-tête.",     // FR
      "Mevcut bir 2D blok başlık olarak eklenecektir." };       // TR

    public static readonly string[] TextTemplate = {
      "Text Template",
      "Шаблон текста",
      "Modello di testo",
      "Textvorlage",
      "文字模板",
      "Plantilla de texto",                                    // ES
      "Modèle de texte",                                       // FR
      "Metin Şablonu"};                                        // TR

    public static readonly string[] TextTemplateTip = {
      "Title template with substitutions for drawing object properties." +
        "Line breaks and text formatting codes are allowed.",
      "Шаблон заголовка с подстановками свойств объектов чертежа. " +
        "Допустимы переносы строк и коды форматирования теста. ",
      "Modello di titolo con sostituzioni per le proprietà degli oggetti di disegno." +
        "Sono consentiti interruzioni di linea e codici di formattazione del testo.",
      "Titelvorlage mit Ersetzungen für Zeichenobjekteigenschaften." +
        "Zeilenumbrüche und Textformatierungscodes sind zulässig.",
      "带有绘图对象属性替代的标题模板。允许换行和文本格式代码。",
      "Plantilla de título con sustituciones para las propiedades del objeto de dibujo." +
        "Se permiten saltos de línea y códigos de formato de texto.",        // ES
      "Modèle de titre avec substitutions pour les propriétés des objets de dessin." +
        "Les sauts de ligne et les codes de formatage de texte sont autorisés.", // FR
      "Çizim nesnesi özellikleri için ikamelerle başlık şablonu." +
        "Satır sonları ve metin biçimlendirme kodlarına izin verilir."};      // TR

    public static readonly string[] BlockAttributes = {
      "Block Attributes",
      "Атрибуты блока",
      "Attributi del blocco",
      "Blockattribute",
      "块属性",
      "Atributos de bloque",                                   // ES
      "Attributs de bloc",                                    // FR
      "Blok Özellikleri"};                                    // TR

    public static readonly string[] BlockAttributesTip ={
      "A list of attribute names (tags) and values. \r\n" +
        "Each attribute on a new line. Write values after the = sign." ,
      "Список имен (тегов) и значений атрибутов. \r\n" +
        "Каждый атрибут в новой строке. Значения пишите после символа =." ,
      "Elenco di nomi e valori degli attributi. \r\n" +
        "Ogni attributo su una nuova riga. Scrivi i valori dopo il segno =." ,
      "Liste von Attributnamen und -werten. \r\n" +
        "Jedes Attribut in einer neuen Zeile. Schreiben Sie Werte nach dem = Zeichen." ,
      "属性名称和值的列表。 \r\n" +
        "每个属性占一行。在 = 符号后写值。",
      "Lista de nombres y valores de atributos.\r\n" +
        "Uno por línea. Valores tras '='. Se admiten sustituciones.",
      "Liste de noms et valeurs d’attributs.\r\n" +
        "Un par ligne. Valeurs après '='. Substitutions acceptées.",
      "Öznitelik adları ve değerleri listesi.\r\n" +
        "Her satır bir öznitelik. '=' sonrası değeri yazın.\r\n" +
        "Viewport özellik değişimleri desteklenir." };

    public static readonly string[] TextStyle = {
      "Style",
      "Стиль",
      "Stile",
      "Stil",
      "样式",
      "Estilo",                                                  // ES
      "Style",                                                   // FR
      "Stil"};                                                   // TR

    public static readonly string[] TextStyleTip = {
      "Title text style. Set space for use current style.",
      "Стиль текста заголовка. В стилях задается шрифт и размер текста. Оставьте пустым, чтоб использовать текущий стиль текста.",
      "Stile del testo del titolo. Imposta lo spazio per l'uso dello stile corrente.",
      "Titeltextstil. Legen Sie Platz für die Verwendung des aktuellen Stils fest.",
      "文字样式。你可选择其它的文字样式置为当前。",
      "Estilo de texto del título. Deje espacio para usar el estilo actual.",  // ES
      "Style de texte du titre. Définissez un espace pour utiliser le style actuel.",  // FR
      "Başlık metin stili. Mevcut stili kullanmak için boşluk ayarlayın."};  // TR

    public static readonly string[] TextHeightTip = {
      "Text size. Set to 0 to use the _TextSize system variable.",
      "Размер текста.\r\n"+
        "Назначьте 0, чтоб использовать системную переменную _TextSize.",
      "Dimensione del testo. Impostare su 0 per utilizzare la variabile di sistema _TextSize.",
      "Textgröße. Auf 0 setzen, um die Systemvariable _TextSize zu verwenden.",
      "文字高度。设为0以使用系统变量_TextSize。",
      "Tamaño del texto. Establezca en 0 para usar la variable del sistema _TextSize.",  // ES
      "Taille du texte. Définir sur 0 pour utiliser la variable système _TextSize.",  // FR
      "Metin boyutu. _TextSize sistem değişkenini kullanmak için 0 olarak ayarlayın."};  // TR

    public static readonly string[] TextFrame = {
      "Frame",
      "Рамка",
      "Cornice",
      "Textrahmen",
      "文字框",
      "Marco",                                                  // ES
      "Cadre",                                                  // FR
      "Çerçeve"};                                               // TR

    public static readonly string[] TextFrameTip = {
      "Draw a frame around the text.",
      "Прямоугольная рамка вокруг заголовка",
      "Disegna una cornice attorno al testo.",
      "Ziehen Sie einen Rahmen um den Text.",
      "在文字周围生成一个矩形框",
      "Dibujar un marco alrededor del texto.",                   // ES
      "Dessiner un cadre autour du texte.",                      // FR
      "Metin etrafına bir çerçeve çiz."};                        // TR

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
      "Place the title above the drawing.",
      "Разместить заголовок выше над чертежом.",
      "Posiziona il titolo sopra il disegno.",
      "Platzieren Sie den Titel über der Zeichnung.",
      "将标题放置在图纸上方。",
      "Colocar el título encima del dibujo.",          // ES
      "Placer le titre au-dessus du dessin.",          // FR
      "Başlığı çizimin üstüne yerleştir."};            // TR

    public static readonly string[] Center = {
      "Center",
      "По центру",
      "Centro",
      "Center",
      "居中",
      "Centro",                                                  // ES
      "Centre",                                                  // FR
      "Merkez"};                                                 // TR

    public static readonly string[] CenterTip = {
      "Align the center of the title to the center of the drawing.\r\n"+
        "If the title is set to be inside the drawing,\r\n"+
        "then vertical alignment will also be performed.",
      "Выравнивать центр заголовка по центру чертежа.\r\n"+
        "Если настроен заголовок внутри чертежа,\r\n"+
        "то будет производиться и вертикальное выравнивание тоже.",
      "Allinea il centro del titolo al centro del disegno.\r\n"+
        "Se il titolo è impostato per essere all'interno del disegno,\r\n"+
        "verrà eseguito anche l'allineamento verticale.",
      "Richten Sie die Mitte des Titels auf die Mitte der Zeichnung aus.\r\n"+
          "Wenn der Titel so eingestellt ist, dass er sich innerhalb der Zeichnung befindet,\r\n"+
          "wird auch die vertikale Ausrichtung durchgeführt.",
      "将标题的中心对齐到图纸的中心。\r\n"+
        "如果标题设置在图纸内，\r\n"+
        "也将进行垂直对齐。",
      "Alinear el centro del título con el centro del dibujo.\r\n"+
        "Si el título está configurado para estar dentro del dibujo,\r\n"+
        "también se realizará la alineación vertical.",            // ES
      "Aligner le centre du titre au centre du dessin.\r\n"+
        "Si le titre est défini pour être à l'intérieur du dessin,\r\n"+
        "un alignement vertical sera également effectué.",         // FR
      "Başlığın merkezini çizimin merkezine hizalayın.\r\n"+
        "Başlık çizimin içinde olacak şekilde ayarlanmışsa,\r\n"+
        "dikey hizalama da yapılacaktır."};                        // TR

    public static readonly string[] Inside = {
      "Inside",
      "Внутри",
      "Dentro",
      "Innerhalb",
      "内部",
      "Interior",                                                // ES
      "Intérieur",                                               // FR
      "İç"};                                                     // TR

    public static readonly string[] InsideTip = {
      "To place the text inside drawing. \r\n"+
        "The program does not pay attention to the drawings with complex contours and\r\n"+
        "place the text inside the rectangle conditional restricted with dimensions of drawing.\r\n"+
        "If you turn on the rendering mode filled faces of solids, you will not see the headers,\r\n"+
        "as texts will be below solids.",
      "Разместить текст внутри чертежа.\r\n"+
        "Программа не обращает внимания, что перекроет заголовком важные контуры, \r\n"+
        "и размещает текст внутри условного прямоугольника ограничивающего габариты чертежа.\r\n"+
        "Если вы включите режим визуализации с заливкой граней твердых тел,\r\n"+
        "то вы не увидите заголовки, т.к. тексты окажутся под солидами.",
      "Per posizionare il testo all'interno del disegno.\r\n"+
        "Il programma non presta attenzione ai disegni con contorni complessi e\r\n"+
        "posiziona il testo all'interno del rettangolo condizionale limitato dalle dimensioni del disegno.\r\n"+
        "Se si attiva la modalità di rendering delle facce piene dei solidi, non si vedranno le intestazioni,\r\n"+
        "poiché i testi saranno sotto i solidi.",
      "Um den Text innerhalb der Zeichnung zu platzieren.\r\n"+
        "Das Programm achtet nicht auf Zeichnungen mit komplexen Konturen und\r\n"+
        "platziert den Text innerhalb des bedingten Rechtecks, das durch die Abmessungen der Zeichnung eingeschränkt ist.\r\n"+
        "Wenn Sie den Render-Modus für gefüllte Flächen von Solids einschalten, sehen Sie die Überschriften nicht,\r\n"+
        "da die Texte unter den Solids liegen.",
      "将文字放置在图纸内部。\r\n"+
        "程序不考虑复杂轮廓的图纸，\r\n"+
        "并将文字放置在由图纸尺寸限定的矩形区域内。\r\n"+
        "如果你开启实体填充面的渲染模式，\r\n"+
        "你将看不到标题，因为文字会在实体下面。",
      "Para colocar el texto dentro del dibujo.\r\n"+
        "El programa no presta atención a los dibujos con contornos complejos y\r\n"+
        "coloca el texto dentro del rectángulo condicional restringido por las dimensiones del dibujo.\r\n"+
        "Si activa el modo de renderizado de caras rellenas de sólidos, no verá los encabezados,\r\n"+
        "ya que los textos estarán debajo de los sólidos.",          // ES
      "Pour placer le texte à l'intérieur du dessin.\r\n"+
        "Le programme ne fait pas attention aux dessins avec des contours complexes et\r\n"+
        "place le texte à l'intérieur du rectangle conditionnel restreint par les dimensions du dessin.\r\n"+
        "Si vous activez le mode de rendu des faces remplies des solides, vous ne verrez pas les en-têtes,\r\n"+
        "car les textes seront sous les solides.",                    // FR
      "Metni çizimin içine yerleştirmek için.\r\n"+
        "Program, karmaşık konturlara sahip çizimlere dikkat etmez ve\r\n"+
        "metni çizimin boyutlarıyla sınırlanan koşullu dikdörtgenin içine yerleştirir.\r\n"+
        "Katıların dolu yüzlerinin renderleme modunu açarsanız başlıkları görmezsiniz,\r\n"+
        "çünkü metinler katıların altında olacaktır."};              // TR

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
      "Place the title below the drawing.",
      "Разместить заголовок ниже под чертежом.",
      "Posiziona il titolo sotto il disegno.",
      "Platzieren Sie den Titel unter der Zeichnung.",
      "将标题放置在图纸下方。",
      "Colocar el título debajo del dibujo.",         // ES
      "Placer le titre en dessous du dessin.",        // FR
      "Başlığı çizimin altına yerleştir."};           // TR

    public static readonly string[] BlockNameTip = {
      "The name of the block that will be created for the title.\r\n" +
        "The block must already exist in the drawing or DWT template.\r\n" +
        "This must be a 2D block with visible, editable attributes.",
      "Имя блока, который будет создан для заголовка.\r\n" +
        "Блок должен уже существовать в чертеже или в DWT шаблоне.\r\n" +
        "Это должен быть 2D блок с видимыми изменяемыми атрибутами.",
      "Il nome del blocco che verrà creato per l'intestazione.\r\n" +
        "Il blocco deve già esistere nel disegno o nel modello DWT.\r\n" +
        "Deve essere un blocco 2D con attributi visibili e modificabili.",
      "Der Name des Blocks, der für die Kopfzeile erstellt wird.\r\n" +
        "Der Block muss bereits in der Zeichnung oder der DWT-Vorlage vorhanden sein.\r\n" +
        "Dies muss ein 2D-Block mit sichtbaren, bearbeitbaren Attributen sein.",
      "将为标题创建的块的名称。\r\n" +
        "该块必须已存在于图纸或DWT模板中。\r\n" +
        "这必须是一个具有可见、可编辑属性的2D块。",
      "El nombre del bloque que se creará para el encabezado.\r\n" +
        "El bloque ya debe existir en el dibujo o en la plantilla DWT.\r\n" +
        "Debe ser un bloque 2D con atributos visibles y editables.",    // ES
      "Le nom du bloc qui sera créé pour l'en-tête.\r\n" +
        "Le bloc doit déjà exister dans le dessin ou le modèle DWT.\r\n" +
        "Il doit s'agir d'un bloc 2D avec des attributs visibles et modifiables.", // FR
      "Başlık için oluşturulacak bloğun adı.\r\n" +
        "Blok, çizimde veya DWT şablonunda zaten var olmalıdır.\r\n" +
        "Bu, görünür, düzenlenebilir özniteliklere sahip bir 2D blok olmalıdır."}; // TR

    public static readonly string[] TitleGap = {
      "Title space",
      "Отступ заголовка",
      "Rientro dell'intestazione",
      "Überschrift Einzug",
      "标题缩进",
      "Espacio de título",                                       // ES
      "Espace de titre",                                         // FR
      "Başlık boşluğu"};                                         // TR

    public static readonly string[] TitleGapTip = {
      "Space between the title and the drawing.\r\n" +
        "Set to 0 to use an indent equal to the standard text height.",
      "Свободное место между заголовком и чертежом. \r\n" +
        "Назначьте 0, чтоб использовать отступ равный стандартной высоте текста.",
      "Spazio tra il titolo e il disegno.\r\n" +
        "Impostare su 0 per utilizzare un rientro pari all'altezza del testo standard.",
      "Abstand zwischen dem Titel und der Zeichnung.\r\n" +
        "Auf 0 setzen, um einen Einzug zu verwenden, der der Standard-Textgröße entspricht.",
      "标题和图纸之间的空间。\r\n" +
        "设为0以使用等于标准文字高度的缩进。",
      "Espacio entre el título y el dibujo.\r\n" +
        "Establezca en 0 para usar una sangría igual a la altura del texto estándar.", // ES
      "Espace entre le titre et le dessin.\r\n" +
        "Définir sur 0 pour utiliser un retrait égal à la hauteur de texte standard.", // FR
      "Başlık ile çizim arasındaki boşluk.\r\n" +
        "Standart metin yüksekliğine eşit bir girinti kullanmak için 0 olarak ayarlayın."}; // TR

    public static readonly string[] BlockHeight = {
      "Block Height",
      "Высота блока",
      "Altezza del blocco",
      "Blockhöhe",
      "块高度",
      "Altura del bloque",                                      // ES
      "Hauteur du bloc",                                        // FR
      "Blok Yüksekliği" };                                      // TR
  
    public static readonly string[] BlockHeightTip = {
      "The Y position for the title block. \r\n" +
        "If the program doesn't correctly determine the height of the title block,\r\n" +
        "you can set it manually here.\r\n" +
        "Set it to 0 to have the program measure the block's height automatically.",
      "Место по Y для блока-заголовка. \r\n" +
        "На случай, если программа неверно определит высоту блока заголовка,\r\n" +
        "вы можете задать ее вручную здесь.\r\n" +
        "Назначьте 0, чтоб программа сама померила высоту блока.",
      "La posizione Y per il blocco del titolo.\r\n" +
        "Se il programma non determina correttamente l'altezza del blocco del titolo,\r\n" +
        "è possibile impostarla manualmente qui.\r\n" +
        "Impostare su 0 per far misurare automaticamente l'altezza del blocco dal programma.",
      "Die Y-Position für den Titelblock.\r\n" +
        "Wenn das Programm die Höhe des Titelblocks nicht korrekt bestimmt,\r\n" +
        "können Sie sie hier manuell einstellen.\r\n" +
        "Auf 0 setzen, damit das Programm die Blockhöhe automatisch misst.",
      "标题块的Y位置。\r\n" +
        "如果程序无法正确确定标题块的高度，\r\n" +
        "您可以在此手动设置。\r\n" +
        "设为0以让程序自动测量块的高度。",
      "La posición Y para el bloque de título.\r\n" +
        "Si el programa no determina correctamente la altura del bloque de título,\r\n" +
        "puede configurarla manualmente aquí.\r\n" +
        "Establezca en 0 para que el programa mida automáticamente la altura del bloque.", // ES
      "La position Y pour le bloc de titre.\r\n" +
        "Si le programme ne détermine pas correctement la hauteur du bloc de titre,\r\n" +
        "vous pouvez la définir manuellement ici.\r\n" +
        "Définir sur 0 pour que le programme mesure automatiquement la hauteur du bloc.", // FR
      "Başlık bloğu için Y konumu.\r\n" +
        "Program başlık bloğunun yüksekliğini doğru şekilde belirleyemezse,\r\n" +
        "burada manuel olarak ayarlayabilirsiniz.\r\n" +
        "Blok yüksekliğini programın otomatik olarak ölçmesi için 0 olarak ayarlayın."}; // TR

    public static readonly string[] BlockExtentsErr = {
      "Unable to measure the dimensions of block '{0}'. The block will be overlaid on the drawing.",
      "Не удалось измерить размеры блока '{0}'. Блок будет наложен на чертеж.",
      "Impossibile misurare le dimensioni del blocco '{0}'. Il blocco verrà sovrapposto al disegno.",
      "Die Abmessungen des Blocks '{0}' konnten nicht gemessen werden. Der Block wird auf die Zeichnung gelegt.",
      "无法测量块“{0}”的尺寸。该块将覆盖在图纸上。",
      "No se pueden medir las dimensiones del bloque «{0}». Se superpondrá al dibujo.",
      "Impossible de mesurer les dimensions du bloc « {0} ». Le bloc sera superposé au dessin.",
      "‘{0}’ bloğunun ölçüleri alınamadı. Blok çizimin üzerine bindirilecek." };

    public static readonly string[] TextExtentsErr = {
      "Unable to get title text dimensions",
      "Не удалось получить размеры текста заголовка",
      "Impossibile ottenere le dimensioni del testo del titolo",
      "Die Abmessungen des Titeltexts konnten nicht ermittelt werden.",
      "无法获取标题文字的尺寸",
      "No se pueden obtener las dimensiones del texto del título.",
      "Impossible d'obtenir les dimensions du texte du titre.",
      "Başlık metninin ölçüleri alınamadı." };

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

    public static readonly string[] SingleAttrErr = {
      "The program is configured to fill a single block attribute. However, {1} attribute(s) were found in block '{0}'.",
      "Программа настроена на заполнение единственного атрибута. А в блоке '{0}' обнаружено {1} атрибут(ов).", 
      "Il programma è configurato per compilare un singolo attributo di blocco. Tuttavia, sono stati trovati {1} attributi nel blocco '{0}'.",
      "Das Programm ist so konfiguriert, dass ein einzelnes Blockattribut ausgefüllt wird. Im Block '{0}' wurden jedoch {1} Attribute gefunden.",
      "程序配置为填写单个块属性。但是，在块“{0}”中找到了{1}个属性。",
      "El programa está configurado para completar un solo atributo de bloque. Sin embargo, se encontraron {1} atributo(s) en el bloque «{0}».",
      "Le programme est configuré pour remplir un seul attribut de bloc. Cependant, {1} attribut(s) ont été trouvés dans le bloc « {0} ».",
      "Program tek bir blok özniteliğini dolduracak şekilde yapılandırılmıştır. Ancak, '{0}' bloğunda {1} öznitelik bulundu." };


  }
}
