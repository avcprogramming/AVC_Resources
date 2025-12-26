// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Infopoint

namespace AVC
{
  public static class
  MarkL
  {
    public static readonly string[][] MarkStyleNames = {
/* 0 */ CommandL.Mark,
/* 1 */new []{
        "Label Name",
        "Бирка Имя",
        "Etichetta - Nome",
        "Beschriften - Name",
        "标签名",
        "Etiqueta Nombre",                             // ES
        "Étiquette Nom",                               // FR
        "Etiket İsim"},                                // TR
/* 2 */new []{
        "Label Solid Overall Dimensions",
        "Бирка Габариты солида",
        "Etichetta - Dimensioni generali",
        "Beschriften - Gesamtabmessungen",
        "标签尺寸实心",
        "Etiqueta Dimensiones Generales de Sólido",    // ES
        "Étiquette Dimensions Générales du Solide",    // FR
        "Etiket Katı Genel Boyutlar"},                 // TR
/* 3 */new []{
        "InfoPoint Detail",
        "ИнфоТочка Деталь",
        "Punto informazioni - Dettaglio",
        "Infopunkt - Detail",
        "信息点 - 详细信息",
        "Punto de Información Detalle",                // ES
        "Point d'Information Détail",                  // FR
        "Bilgi Noktası Detay"},                        // TR
/* 4 */new []{
        "Number bubble",
        "Пузырь с номером",
        "Bolla di numero",
        "Zahlenblase",
        "泡泡与数字",
        "Burbuja de número",                           // ES
        "Bulle de numéro",                             // FR
        "Numara baloncuğu"},                           // TR
      };

    public static readonly string[] Select = {
      "  Select details to mark and old marks. Or you can select a viewport ",
      "  Выберите объекты для маркировки и старые метки. Можно указать вьюпорт ",
      "  Seleziona i dettagli da Marcatura e i vecchi marchi. Oppure puoi selezionare una viewport ",
      "  Wählen Sie Details zum Markieren und alte Markierungen aus. Oder Sie können ein Viewport auswählen",
      "  选择要标记的细节和旧标记。 或者您可以选择一个视口",
      "  Seleccione detalles para marcar y marcas antiguas. O puede seleccionar una ventana gráfica ",  // ES
      "  Sélectionnez les détails à marquer et les anciennes marques. Ou vous pouvez sélectionner une fenêtre ",  // FR
      "  İşaretlenecek ayrıntıları ve eski işaretleri seçin. Veya bir görünüm penceresi seçebilirsiniz "};  // TR

    public static readonly string[] Creating = {
      "  Creating marks",
      "  Маркировка",
      "  Marcatura",
      "  Markierung",
      "  创建标记",
      "  Creando marcas",                              // ES
      "  Création de marques",                         // FR
      "  İşaretler oluşturuluyor"};                    // TR

    public static readonly string[] NoBlock = {
      "  No block specified",
      "  Не задан блок",
      "  Nessun blocco specificato",
      "  Kein Block angegeben",
      "  未指定块",
      "  No se especificó ningún bloque",              // ES
      "  Aucun bloc spécifié",                         // FR
      "  Blok belirtilmedi"};                          // TR

    public static readonly string[] ErrBlock = {
      "  There is no {0} block in the drawing",
      "  В чертеже нет блока {0}",
      "  Non esiste un blocco {0} nel disegno",
      "  Die Zeichnung enthält keinen {0}-Block",
      "  绘图中没有 {0} 块",
      "  No hay ningún bloque {0} en el dibujo",       // ES
      "  Il n'y a pas de bloc {0} dans le dessin",     // FR
      "  Çizimde {0} bloğu yok"};                      // TR

    public static readonly string[] IPBlockErr = {
      "  Failed to create a block for InfoPoint",
      "  Не получилось создать блок для ИнфоТочки",
      "  Impossibile creare un blocco per Punto Informazioni.",
      "  Fehler beim Erstellen eines Blocks für Infopunkt.",
      "  无法为信息点创建块 (InfoPoint)",
      "  No se pudo crear un bloque para Punto de Información",  // ES
      "  Échec de la création d'un bloc pour Point d'Information",  // FR
      "  Bilgi Noktası için blok oluşturulamadı"};     // TR

    public static readonly string[] RemoveCount = {
      "  Removed {0} old marks.",
      "  Удалено {0} старых меток.",
      "  Rimossi {0} vecchi marcatura.",
      "  {0} alte Markierung entfernt.",
      "  删除了 {0} 个旧标记。",
      "  Se eliminaron {0} marcas antiguas.",          // ES
      "  {0} anciennes marques supprimées.",           // FR
      "  {0} eski işaret kaldırıldı."};                // TR

    public static readonly string[] EmptyMark = {
      "  For object {0}, an empty label is obtained. Change the substitutions in the template.",
      "  Для объекта {0} получилась пустая метка. Поменяйте подстановки в шаблоне.",
      "  Per l'oggetto {0} si ottiene un'etichetta vuota. Modificare le sostituzioni nel modello.",
      "  Für Objekt {0} wird ein leeres Label abgerufen. Ändern Sie die Ersetzungen in der Vorlage.",
      "  对于对象 {0}，获得一个空标签。 更改模板中的替换。",
      "  Para el objeto {0}, se obtiene una etiqueta vacía. Cambie las sustituciones en la plantilla.",  // ES
      "  Pour l'objet {0}, une étiquette vide est obtenue. Modifiez les substitutions dans le modèle.",  // FR
      "  Nesne {0} için boş bir etiket elde edildi. Şablondaki değiştirmeleri değiştirin."};  // TR

    public static readonly string[] GeomExtErr = {
      "Error calculating object dimensions {0}",
      "Ошибка при вычислении габаритов объекта {0}",
      "Errore durante il calcolo delle dimensioni dell'oggetto {0}",
      "Fehler beim Berechnen der Objektabmessungen {0}",
      "计算对象尺寸时出错 {0}",
      "Error al calcular las dimensiones del objeto {0}",  // ES
      "Erreur lors du calcul des dimensions de l'objet {0}",  // FR
      "Nesne boyutları hesaplanırken hata {0}" };      // TR

    public static readonly string[] InfopointDefAttributes = {
      "Name;%n%|Layer;%l%|Length;%len%|Width;%w%|Thickness;%t%|Kind;%k%|Description;%i%",
      "Имя;%n%|Слой;%l%|Длина;%len%|Ширина;%w%|Толщина;%t%|Тип;%k%|Описание;%i%",
      "Nome;%n%|Layer;%l%|Lunghezza;%len%|Larghezza;%w%|Spessore;%t%|Tipo;%k%|Info;%i%",
      "Name;%n%|Layer;%l%|Länge;%len%|Breite;%w%|Dicke;%t%|Art;%k%|Info;%i%",
      "姓名;%n%|图层;%l%|长度;%len%|宽度;%w%|厚度;%t%|亲切;%k%|描述;%i%",
      "Nombre;%n%|Capa;%l%|Longitud;%len%|Ancho;%w%|Espesor;%t%|Tipo;%k%|Descripción;%i%",  // ES
      "Nom;%n%|Calque;%l%|Longueur;%len%|Largeur;%w%|Épaisseur;%t%|Type;%k%|Description;%i%",  // FR
      "Ad;%n%|Katman;%l%|Uzunluk;%len%|Genişlik;%w%|Kalınlık;%t%|Tür;%k%|Açıklama;%i%"};  // TR

    //======================= Dialog Box =============================================================

    public static readonly string[] AddColumnTip = {
      "Select a substitution to insert the new info point attribute at the current position in the list.",
      "Выберите подстановку, чтоб создать новый атрибут инфо-точки втекуце позиции списка.",
      "Selezionare una sostituzione per inserire il nuovo attributo \r\n" +
        "del punto informazioni nella posizione corrente nell'elenco.",
      "Wählen Sie eine Ersetzung aus, \r\n" +
        "um das neue Infopunktattribut an der aktuellen Position in der Liste einzufügen.",
      "选择替换以在列表中的当前位置插入新的信息点属性。",
      "Seleccione una sustitución para insertar el nuevo atributo de punto de información en la posición actual de la lista.",  // ES
      "Sélectionnez une substitution pour insérer le nouvel attribut de point d'information à la position actuelle dans la liste.",  // FR
      "Listedeki geçerli konuma yeni bilgi noktası özniteliğini eklemek için bir değiştirme seçin." };  // TR

    public static readonly string[] DelColumnTip = {
      "Delete current attribute",
      "Удалить текущий атрибут",
      "Elimina l'attributo corrente",
      "Aktuelles Attribut löschen",
      "删除当前属性",
      "Eliminar atributo actual",                      // ES
      "Supprimer l'attribut actuel",                   // FR
      "Geçerli özniteliği sil" };                      // TR

    public static readonly string[] CbBlockTip = {
      "Select a block name from the list.\r\n" +
        "In the list there are only blocks with non-constant attributes.\r\n" +
        "You can insert blocks from the template.",
      "Имя блока, используемого как метка.\r\n" +
        "Блок должен содержать неконстантные атрибуты.\r\n" +
        "Значение по умолчанию у атрибутов может содержать подстановки. \r\n" +
        "Если подстановок нет, то будет использован формат.\r\n" +
        "Можно использовать блок из шаблона.",
      "Seleziona un nome di blocco dall'elenco.\r\n" +
        "Nell'elenco ci sono solo blocchi con attributi non costanti.\r\n" +
        "È possibile inserire blocchi dal modello.",
      "Wählen Sie einen Blocknamen aus der Liste aus.\r\n" +
         "In der Liste gibt es nur Blöcke mit nicht konstanten Attributen.\r\n" +
         "Sie können Blöcke aus der Vorlage einfügen.",
      "从列表中选择一个块名。\r\n" +
         "在列表中只有具有非常量属性的块。\r\n" +
         "您可以从模板中插入块。",
      "Seleccione un nombre de bloque de la lista.\r\n" +  // ES
        "En la lista solo hay bloques con atributos no constantes.\r\n" +
        "Puede insertar bloques desde la plantilla.",
      "Sélectionnez un nom de bloc dans la liste.\r\n" +  // FR
        "Dans la liste, il n'y a que des blocs avec des attributs non constants.\r\n" +
        "Vous pouvez insérer des blocs à partir du modèle.",
      "Listeden bir blok adı seçin.\r\n" +  // TR
        "Listede yalnızca sabit olmayan özniteliklere sahip bloklar vardır.\r\n" +
        "Şablondan bloklar ekleyebilirsiniz." };

    public static readonly string[] DelOldText = {
      "Delete old marks",
      "Удалить старые метки",
      "Elimina i vecchi",
      "Alte Markierungen löschen",
      "删除旧标记",
      "Eliminar marcas antiguas",                      // ES
      "Supprimer les anciennes marques",               // FR
      "Eski işaretleri sil" };                         // TR

    public static readonly string[] DelOldTip = {
      "Delete all old marks with same style.\r\n" +
        "Delete only marks that are among the objects you have selected.\r\n" +
        "When you select a viewport, all marks visible in the model\r\n" +
        "and marks on paper that fall on the viewport will be deleted.",
      "Удалить все старые метки того же стиля.\r\n" +
        "Удаляться только метки, оказавшиеся среди выбранных вами объектов.\r\n" +
        "При выборе вьюпорта будут удалены все метки видимые в модели и метки на бумаге,\r\n" +
        "попавшие на вьюпорт.",
      "Elimina tutti i vecchi segni con lo stesso stile.\r\n" +
        "Elimina solo i segni tra gli oggetti che hai selezionato.\r\n" +
        "Quando si seleziona una finestra, tutti i segni sono visibili nel modello\r\n" +
        "e i segni sulla carta che rientrano nella finestra verranno eliminati.",
      "Alle alten Markierungen mit demselben Stil löschen.\r\n" +
        "Nur Markierungen löschen, die zu den von Ihnen ausgewählten Objekten gehören.\r\n" +
        "Wenn Sie ein Ansichtsfenster auswählen, \r\n" +
        "werden alle im Modell sichtbaren Markierungen und Markierungen auf Papier, \r\n" +
        "die auf das Ansichtsfenster fallen, gelöscht.",
      "删除所有相同样式的旧标记。\r\n" +
         "仅删除所选对象中的标记。\r\n" +
         "当您选择视口时，模型中所有可见的标记和纸上落在视口上的标记都将被删除。",
      "Eliminar todas las marcas antiguas con el mismo estilo.\r\n" +  // ES
        "Eliminar solo las marcas que están entre los objetos que ha seleccionado.\r\n" +
        "Cuando seleccione una ventana gráfica, todas las marcas visibles en el modelo\r\n" +
        "y las marcas en papel que caen en la ventana gráfica se eliminarán.",
      "Supprimer toutes les anciennes marques avec le même style.\r\n" +  // FR
        "Supprimer uniquement les marques qui se trouvent parmi les objets que vous avez sélectionnés.\r\n" +
        "Lorsque vous sélectionnez une fenêtre, toutes les marques visibles dans le modèle\r\n" +
        "et les marques sur papier qui tombent sur la fenêtre seront supprimées.",
      "Aynı stile sahip tüm eski işaretleri silin.\r\n" +  // TR
        "Yalnızca seçtiğiniz nesneler arasındaki işaretleri silin.\r\n" +
        "Bir görünüm penceresi seçtiğinizde, modelde görünen tüm işaretler\r\n" +
        "ve görünüm penceresine düşen kağıt üzerindeki işaretler silinecektir." };

    public static readonly string[] FrameText = {
      "Text Frame",
      "Рамка текста",
      "Cornice di testo",
      "Textrahmen",
      "文字框",
      "Marco de texto",                                // ES
      "Cadre de texte",                                // FR
      "Metin çerçevesi" };                             // TR

    public static readonly string[] FrameTip = {
      "Draw a frame around the text.",
      "Рисовать рамки вокруг бирок",
      "Disegna una cornice attorno al testo.",
      "Ziehen Sie einen Rahmen um den Text.",
      "在文本周围画一个框。",
      "Dibujar un marco alrededor del texto.",         // ES
      "Dessiner un cadre autour du texte.",            // FR
      "Metnin etrafına bir çerçeve çizin." };          // TR

    public static readonly string[] OnPaperText = {
      "On Paper",
      "На бумагу",
      "Su carta",
      "Auf Papier",
      "纸上谈兵",
      "En papel",                                      // ES
      "Sur papier",                                    // FR
      "Kağıt üzerinde" };                              // TR

    public static readonly string[] OnPaperTip = {
      "Insert block into paper space, \r\n" +
        "even if you called the command from the model through the viewport",
      "Вставлять блок в пространство бумаги, \r\n" +
        "даже если вы вызвали команду из модели через вьюпорт",
      "Inserisci il blocco nello spazio carta, \r\n" +
        "anche se hai richiamato il comando dal modello attraverso la finestra.",
      "Block in den Papierbereich einfügen, \r\n" +
        "auch wenn Sie den Befehl vom Modell über das Ansichtsfenster aufgerufen haben",
      "将块插入图纸空间，即使您通过视口从模型调用命令也是如此。",
      "Insertar bloque en el espacio papel, \r\n" +  // ES
        "incluso si llamó al comando desde el modelo a través de la ventana gráfica",
      "Insérer un bloc dans l'espace papier, \r\n" +  // FR
        "même si vous avez appelé la commande depuis le modèle via la fenêtre",
      "Bloğu kağıt alanına ekleyin, \r\n" +  // TR
        "komutu modelden görünüm penceresi aracılığıyla çağırsanız bile" };

    public static readonly string[] OwnLayerText = {
      "Own Layer",
      "Собственный слой",
      "Proprio layer",
      "Eigene Layer",
      "自己的'层'",
      "Capa propia",                                   // ES
      "Calque propre",                                 // FR
      "Kendi katmanı" };                               // TR


    public static readonly string[] OwnLayerTip = {
      "Create a separate layer for the marks of this style. \r\n" +
        "Otherwise, the Annotation layer will be used for the Label and Block,\r\n" +
        "and the Info layer - for the Info-Points.\r\n" +
        "Layer management can be disabled in the Common Options\r\n" +
        "and settings of the Auto-Annotation command.\r\n" +
        "Then the current layer will be used.",
      "Создавать отдельный слой для меток данного стиля. \r\n" +
        "Иначе для Бирок и Блоков будет использован слой Аннотации,\r\n" +
        "а для Инфо-точек - непечатный слой Info.\r\n" +
        "Управление слоями можно отключить в общих настройках и настройках команды Авто-Аннотации.\r\n" +
        "Тогда будет использован текущий слой.",
      "Crea un livello separato per i segni di questo stile.\r\n" +
        "Altrimenti, il livello di annotazione verrà utilizzato per Etichetta e Blocco,\r\n" +
        "e il livello Info - per gli Info-Point.\r\n" +
        "La gestione dei livelli può essere disabilitata nelle Opzioni comuni\r\n" +
        "e impostazioni del comando Annotazione automatica.\r\n" +
        "Quindi verrà utilizzato il layer corrente.",
      "Erstellen Sie eine separate Ebene für die Marken dieses Stils. \r\n" +
         "Andernfalls wird die Anmerkungsebene für die Beschriftung \r\n" +
        "und den Block und die Infoebene für die Infopunkte verwendet.\r\n" +
         "Die Ebenenverwaltung kann in den allgemeinen Optionen \r\n" +
        "und Einstellungen des Befehls 'Automatische Anmerkung' deaktiviert werden.\r\n" +
         "Dann wird die aktuelle Ebene verwendet.",
      "为这种风格的标记创建一个单独的图层。 \r\n" +
         "否则，注释层将用于标签和块，信息层将用于信息点。\r\n" +
         "可以在自动注释命令的常用选项和设置中禁用图层管理。\r\n" +
         "然后将使用当前图层。",
      "Crear una capa separada para las marcas de este estilo. \r\n" +  // ES
        "De lo contrario, la capa de Anotación se utilizará para la Etiqueta y el Bloque,\r\n" +
        "y la capa Info - para los Puntos de Información.\r\n" +
        "La gestión de capas se puede desactivar en las Opciones Comunes\r\n" +
        "y la configuración del comando Anotación Automática.\r\n" +
        "Entonces se utilizará la capa actual.",
      "Créer un calque séparé pour les marques de ce style. \r\n" +  // FR
        "Sinon, le calque Annotation sera utilisé pour l'Étiquette et le Bloc,\r\n" +
        "et le calque Info - pour les Points d'Information.\r\n" +
        "La gestion des calques peut être désactivée dans les Options Communes\r\n" +
        "et les paramètres de la commande Annotation Automatique.\r\n" +
        "Ensuite, le calque actuel sera utilisé.",
      "Bu stilin işaretleri için ayrı bir katman oluşturun. \r\n" +  // TR
        "Aksi takdirde, Etiket ve Blok için Açıklama katmanı,\r\n" +
        "ve Bilgi Noktaları için Bilgi katmanı kullanılacaktır.\r\n" +
        "Katman yönetimi Ortak Seçeneklerde\r\n" +
        "ve Otomatik Açıklama komutunun ayarlarında devre dışı bırakılabilir.\r\n" +
        "O zaman geçerli katman kullanılacaktır."};

    public static readonly string[] SetTip = {
      "Mark style (Set of settings). The key and the name.\r\n" +
        "The key is assigned automatically as a digit from 1 to 9\r\n" +
        "and is used to quickly switch style from the console.\r\n" +
        "You can change the name.",
      "Стиль маркировки (Набор настроек). Ключ и имя.\r\n" +
        "Ключ назначается автоматически как цифра от 1 до 9\r\n" +
        "и может использоваться для переключения стиля из командной строки.\r\n" +
        "Имя вы можете заменить.",
      "Contrassegna stile (set di impostazioni). La chiave e il nome.\r\n" +
        "Il tasto viene assegnato automaticamente come cifra da 1 a 9\r\n" +
        "e viene utilizzato per cambiare rapidamente stile dalla console.\r\n" +
        "Puoi cambiare il nome.",
      "Stil markieren (Einstellungssatz). Der Schlüssel und der Name.\r\n" +
        "Die Taste wird automatisch als Ziffer von 1 bis 9 zugewiesen \r\n" +
        "und dient zum schnellen Umschalten des Stils von der Konsole.\r\n" +
        "Du kannst den Namen ändern.",
      "标记样式（设置集）。 钥匙和名字。\r\n" +
         "该键自动分配为 1 到 9 的数字，用于从控制台快速切换样式。\r\n" +
         "你可以改变名字。",
      "Estilo de marca (Conjunto de configuraciones). La clave y el nombre.\r\n" +  // ES
        "La clave se asigna automáticamente como un dígito del 1 al 9\r\n" +
        "y se usa para cambiar rápidamente el estilo desde la consola.\r\n" +
        "Puede cambiar el nombre.",
      "Style de marque (Ensemble de paramètres). La clé et le nom.\r\n" +  // FR
        "La clé est attribuée automatiquement sous forme de chiffre de 1 à 9\r\n" +
        "et est utilisée pour changer rapidement de style depuis la console.\r\n" +
        "Vous pouvez changer le nom.",
      "İşaret stili (Ayar kümesi). Anahtar ve ad.\r\n" +  // TR
        "Anahtar otomatik olarak 1'den 9'a kadar bir rakam olarak atanır\r\n" +
        "ve konsoldan stili hızla değiştirmek için kullanılır.\r\n" +
        "Adı değiştirebilirsiniz." };

    public static readonly string[] StyleTip = {
      "Label text style.\r\n" +
        "Leave blank to use current style.",
      "Стиль текста. \r\n" +
        "Оставьте пустым, чтоб использовать текущий стиль.",
      "Etichetta lo stile del testo.\r\n" +
        "Lascia vuoto per utilizzare lo stile corrente.",
      "Beschriftungstextstil.\r\n" +
         "Leer lassen, um aktuellen Stil zu verwenden.",
      "标签文字样式。\r\n" +
         "留空以使用当前样式。",
      "Estilo de texto de etiqueta.\r\n" +  // ES
        "Dejar en blanco para usar el estilo actual.",
      "Style de texte d'étiquette.\r\n" +  // FR
        "Laisser vide pour utiliser le style actuel.",
      "Etiket metin stili.\r\n" +  // TR
        "Geçerli stili kullanmak için boş bırakın." };

    public static readonly string[] ZTip = {
      "Project the mark's location on the XY plane of the current coordinate system.",
      "Проецировать точку расположения метки на плоскость XY текущей системы координат.",
      "Proiettare la posizione del segno sul piano XY del sistema di coordinate corrente.",
      "Projizieren Sie die Position der Markierung auf die \r\n" +
        "XY-Ebene des aktuellen Koordinatensystems.",
      "将标记的位置投影到当前坐标系的 XY 平面上。",
      "Proyectar la ubicación de la marca en el plano XY del sistema de coordenadas actual.",  // ES
      "Projeter l'emplacement de la marque sur le plan XY du système de coordonnées actuel.",  // FR
      "İşaretin konumunu geçerli koordinat sisteminin XY düzlemine yansıtın." };  // TR

    public static readonly string[] ColAttrTip = {
      "Attribute Tag",
      "Таг (имя) атрибута блока (инфоточки)",
      "Tag attributo.",
      "Tag (Name) des Blockattributs (Infopoints)",
      "块属性（信息点）的标记（名称）",
      "Etiqueta de atributo",  // ES
      "Balise d'attribut",  // FR
      "Öznitelik etiketi" };  // TR

    public static readonly string[] FormatTip = {
      "Formating string with substitutions.\r\n" +
        "In mask you can use any MText format symbols (like \\P for new line)\r\n" +
        "and you can use object property substitutions.\r\n" +
        "Used for Labels and all block attributes that have no default value.",
      "Строка с подстановками для бирки.\r\n" +
        "Так же этот формат используется для всех атрибутов,\r\n" +
        "у которых нет подстановок в значении по умолчанию.\r\n" +
        "Вместо подстановок будут вставлены свойства маркируемых объектов.\r\n" +
        "Вы можете использовать символы форматирования MText\r\n" +
        "(например, \\P для переноса строки).",
      "Formare una stringa con sostituzioni.\r\n" +
        "Nella maschera è possibile utilizzare qualsiasi simbolo del formato MText\r\n" +
        "(come \\P per la nuova riga) e puoi usare le sostituzioni delle proprietà degli oggetti.\r\n" +
        "Utilizzato per le etichette e tutti gli attributi di blocco che non hanno un valore predefinito.",
      "Zeichenfolge mit Ersetzungen formatieren.\r\n" +
        "In der Maske können Sie alle MText-Formatsymbole (wie \\P für neue Zeile) \r\n" +
        "verwenden und Sie können Objekteigenschaften ersetzen.\r\n" +
        "Wird für Labels und alle Blockattribute verwendet, die keinen Standardwert haben.",
      "用替换格式化字符串。\r\n" +
        "在掩码中，您可以使用任何多行文本格式符号（如 \\P 表示换行符），\r\n" +
        "并且可以使用对象属性替换。\r\n" +
        "用于标签和所有没有默认值的块属性。",
      "Cadena de formato con sustituciones.\r\n" +  // ES
        "En la máscara puede usar cualquier símbolo de formato MText (como \\P para nueva línea)\r\n" +
        "y puede usar sustituciones de propiedades de objetos.\r\n" +
        "Se usa para Etiquetas y todos los atributos de bloque que no tienen valor predeterminado.",
      "Chaîne de formatage avec substitutions.\r\n" +  // FR
        "Dans le masque, vous pouvez utiliser n'importe quel symbole de format MText (comme \\P pour nouvelle ligne)\r\n" +
        "et vous pouvez utiliser des substitutions de propriétés d'objet.\r\n" +
        "Utilisé pour les Étiquettes et tous les attributs de bloc qui n'ont pas de valeur par défaut.",
      "Değiştirmelerle biçimlendirme dizesi.\r\n" +  // TR
        "Maskede herhangi bir MText biçim sembolünü (yeni satır için \\P gibi) kullanabilirsiniz\r\n" +
        "ve nesne özelliği değiştirmelerini kullanabilirsiniz.\r\n" +
        "Etiketler ve varsayılan değeri olmayan tüm blok öznitelikleri için kullanılır." };

    public static readonly string[] ColFormatTip = {
      "Format string with substitutions.",
      "Строка с подстановками для вставки в атрибут блока(инфоточки)",
      "Formattare la stringa con sostituzioni.",
      "Eine Zeichenfolge mit Ersetzungen zum Einfügen in ein Blockattribut (Infopoints)",
      "带有替换项的字符串，用于插入块属性（信息点）",
      "Cadena de formato con sustituciones.",  // ES
      "Chaîne de format avec substitutions.",  // FR
      "Değiştirmeli biçim dizesi." };  // TR

    public static readonly string[] GbBlockTip = {
      "The name of your self-made mark-block.",
      "Имя вашего самодельного блока маркировки.",
      "Il nome del tuo blocco marcatore fatto in casa.",
      "Der Name Ihres hausgemachten Markierungsblocks.",
      "您自制的标记块的名称。",
      "El nombre de su bloque de marca hecho por usted mismo.",  // ES
      "Le nom de votre bloc de marque fait maison.",  // FR
      "Kendi yaptığınız işaret bloğunun adı." };  // TR

    public static readonly string[] GbInfoPointTip = {
      "List of InfoPoint attributes",
      "Список атрибутов для ИнфоТочек",
      "Elenco attributi Info-Point",
      "Liste der Info-Point-Attribute",
      "信息点属性列表",
      "Lista de atributos de Punto de Información",  // ES
      "Liste des attributs de Point d'Information",  // FR
      "Bilgi Noktası öznitelikleri listesi" };  // TR

    public static readonly string[] GbMarkTypeText = {
      "Mark Type",
      "Тип маркировки",
      "Tipo di marcatura",
      "Markierungstyp",
      "标记类型",
      "Tipo de marca",  // ES
      "Type de marque",  // FR
      "İşaret türü" };  // TR

    public static readonly string[] GbMarkTypeTip = {
      "Select the type of marks to create",
      "Выберите один из типов маркировок",
      "Seleziona il tipo di etichetta che desideri creare.",
      "Wählen Sie den Typ der zu erstellenden Markierungen aus",
      "选择要创建的标记类型",
      "Seleccione el tipo de marcas a crear",  // ES
      "Sélectionnez le type de marques à créer",  // FR
      "Oluşturulacak işaret türünü seçin" };  // TR

    public static readonly string[] GbOptionsText = {
      "Mark Options",
      "Опции маркировки",
      "Marcatura opzioni",
      "Optionen markieren",
      "标记选项",
      "Opciones de marca",  // ES
      "Options de marque",  // FR
      "İşaret seçenekleri" };  // TR

    public static readonly string[] GbPositionText = {
      "Mark Positions",
      "Позиция",
      "Posizioni",
      "Positionen",
      "标记位置",
      "Posiciones de marca",  // ES
      "Positions de marque",  // FR
      "İşaret konumları" };  // TR

    public static readonly string[] GbPositionTip = {
      "The location of the marks relative to the described parts.",
      "Положение метки относительно детали",
      "La posizione dei segni relativi alle parti descritte.",
      "Die Position der Markierungen relativ zu den beschriebenen Teilen.",
      "标记相对于所描述部件的位置。",
      "La ubicación de las marcas en relación con las piezas descritas.",  // ES
      "L'emplacement des marques par rapport aux pièces décrites.",  // FR
      "Tarif edilen parçalara göre işaretlerin konumu." };  // TR

    public static readonly string[] GbTextText = {
      "Text options",
      "Настройки текста",
      "Opzioni di testo",
      "Textoptionen",
      "文本选项",
      "Opciones de texto",  // ES
      "Options de texte",  // FR
      "Metin seçenekleri" };  // TR

    public static readonly string[] TextHeightTip = {
      "Text size.\r\n" +
        "Set the value to zero to use the value from the system variable TextSize",
      "Размер текста.\r\n" +
        "Оставьте 0, чтоб использовать системную переменную TextSize",
      "Dimensione del testo.\r\n" +
        "Impostare il valore su zero per utilizzare il valore dalla variabile di sistema TextSize",
      "Textgröße.\r\n" +
        "Setzen Sie den Wert auf Null, \r\n" +
        "um den Wert aus der Systemvariablen TextSize zu verwenden",
      "文字大小。\r\n" +
         "将值设置为零以使用系统变量 TextSize 中的值",
      "Tamaño de texto.\r\n" +  // ES
        "Establezca el valor en cero para usar el valor de la variable del sistema TextSize",
      "Taille du texte.\r\n" +  // FR
        "Définissez la valeur à zéro pour utiliser la valeur de la variable système TextSize",
      "Metin boyutu.\r\n" +  // TR
        "Sistem değişkeni TextSize'dan değeri kullanmak için değeri sıfıra ayarlayın" };

    public static readonly string[] StyleNameTip = {
      "The name for this mark style.\r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Имя стиля маркировки.\r\n" +
        "Нигде не используется.Только для удобства выбора.",
      "Il nome per questo stile di marchio.\r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Markierungsstil.\r\n" +
         "Nicht im Programm verwendet.Nur zur Vereinfachung der Auswahl.",
      "此标记样式的名称。\r\n" +
         "程序中未使用。仅供选择方便。",
      "El nombre para este estilo de marca.\r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia de elección.",
      "Le nom de ce style de marque.\r\n" +  // FR
        "Non utilisé dans le programme. Uniquement pour la commodité du choix.",
      "Bu işaret stili için ad.\r\n" +  // TR
        "Programda kullanılmaz. Sadece seçim kolaylığı için." };

    public static readonly string[] AboveText = {
      "Above",
      "Над",
      "Sopra",
      "Über",
      "以上",
      "Arriba",  // ES
      "Au-dessus",  // FR
      "Yukarıda" };  // TR

    public static readonly string[] AboveTip = {
      "Over the dimensions of the detail.",
      "Над габаритами детали",
      "Oltre le dimensioni del dettaglio.",
      "Über die Dimensionen des Details.",
      "在细节的尺寸上。",
      "Sobre las dimensiones del detalle.",  // ES
      "Au-dessus des dimensions du détail.",  // FR
      "Ayrıntının boyutlarının üzerinde." };  // TR

    public static readonly string[] BlockTip = {
      "Use any your block with non-constant attributes.\r\n" +
        "Block attributes must have default values containing substitutions.\r\n" +
        "If there are no substitutions, then the Format string will be used for the attribute.",
      "Будут созданы выбранные вами блоки.\r\n" +
        "Блоки должны содержать неконстантные атрибуты.\r\n" +
        "В значениях по умолчанию должны быть прописаны подстановки свойств деталей.\r\n" +
        "Если подстановок нет, то для заполнения атрибутов используется шаблон из поля Формат",
      "Usa qualsiasi blocco con attributi non costanti.\r\n" +
        "Gli attributi di blocco devono avere valori predefiniti contenenti sostituzioni.\r\n" +
        "Se non ci sono sostituzioni, verrà utilizzata la stringa Format per l'attributo.",
      "Verwenden Sie einen beliebigen Block mit nicht konstanten Attributen.\r\n" +
         "Blockattribute müssen Standardwerte haben, die Ersetzungen enthalten.\r\n" +
         "Wenn es keine Ersetzungen gibt, \r\n" +
        "wird der Format-String für das Attribut verwendet.",
      "使用任何具有非常量属性的块。\r\n" +
         "块属性必须具有包含替换的默认值。\r\n" +
         "如果没有替换，则格式字符串将用于该属性。",
      "Use cualquier bloque con atributos no constantes.\r\n" +  // ES
        "Los atributos de bloque deben tener valores predeterminados que contengan sustituciones.\r\n" +
        "Si no hay sustituciones, se usará la cadena de Formato para el atributo.",
      "Utilisez n'importe quel bloc avec des attributs non constants.\r\n" +  // FR
        "Les attributs de bloc doivent avoir des valeurs par défaut contenant des substitutions.\r\n" +
        "S'il n'y a pas de substitutions, la chaîne de Format sera utilisée pour l'attribut.",
      "Sabit olmayan özniteliklere sahip herhangi bir bloğunuzu kullanın.\r\n" +  // TR
        "Blok öznitelikleri değiştirmeler içeren varsayılan değerlere sahip olmalıdır.\r\n" +
        "Değiştirme yoksa, öznitelik için Format dizesi kullanılacaktır." };

    public static readonly string[] CenterText = {
      "In the Center",
      "В центре",
      "Al centro",
      "Im Zentrum",
      "在中心",
      "En el centro",  // ES
      "Au centre",  // FR
      "Merkezde" };  // TR

    public static readonly string[] CenterTip = {
      "In the geometric center of the details.",
      "В геометрическом центре детали.",
      "Nel centro geometrico dei dettagli.",
      "Im geometrischen Zentrum der Details.",
      "在细节的几何中心。",
      "En el centro geométrico del detalle.",  // ES
      "Au centre géométrique du détail.",  // FR
      "Ayrıntının geometrik merkezinde." };  // TR

    public static readonly string[] InfoPointText = {
      "InfoPoint",
      "ИнфоТочка",
      "Punto Info",
      "Info-Punkt",
      "信息点",
      "Punto de Información",  // ES
      "Point d'Information",  // FR
      "Bilgi Noktası" };  // TR

    public static readonly string[] InfoPointTip = {
      "Create block - point with invisible attributes.\r\n" +
        "To adjust the display of points, use variables PDMode and PDSize.\r\n" +
        "Info points are useful for extracting data about details (DataExtraction).",
      "Будут созданы блоки с заданным списком невидимых атрибутов.\r\n" +
        "Единственный видимый объект блока - точка.\r\n" +
        "Настройте отображение точек переменными PDMode и PDSize.\r\n" +
        "ИнфоТочки подходят для дальнейшего извлечения данных о деталях (DataExtraction)",
      "Crea un punto di blocco con attributi invisibili.\r\n" +
        "Per regolare la visualizzazione dei punti, utilizzare le variabili PDMode e PDSize.\r\n" +
        "I punti informativi sono utili per l'estrazione di dati sui dettagli (DataExtraction).",
      "Block erstellen - Punkt mit unsichtbaren Attributen.\r\n" +
         "Um die Anzeige von Punkten anzupassen, verwenden Sie die Variablen PDMode und PDSize.\r\n" +
         "Infopunkte sind nützlich, um Daten über Details zu extrahieren (DataExtraction).",
      "创建块 - 具有不可见属性的点。\r\n" +
         "要调整点的显示，请使用变量 PDMode 和 PDSize。\r\n" +
         "信息点可用于提取有关详细信息的数据 (DataExtraction)。",
      "Crear bloque - punto con atributos invisibles.\r\n" +  // ES
        "Para ajustar la visualización de puntos, use las variables PDMode y PDSize.\r\n" +
        "Los puntos de información son útiles para extraer datos sobre detalles (DataExtraction).",
      "Créer un bloc - point avec des attributs invisibles.\r\n" +  // FR
        "Pour ajuster l'affichage des points, utilisez les variables PDMode et PDSize.\r\n" +
        "Les points d'information sont utiles pour extraire des données sur les détails (DataExtraction).",
      "Blok oluştur - görünmez özniteliklere sahip nokta.\r\n" +  // TR
        "Noktaların görüntüsünü ayarlamak için PDMode ve PDSize değişkenlerini kullanın.\r\n" +
        "Bilgi noktaları, ayrıntılar hakkında veri çıkarmak için kullanışlıdır (DataExtraction)." };

    public static readonly string[] LabelText = {
      "Label",
      "Бирка",
      "Etichetta",
      "Etikett",
      "标签",
      "Etiqueta",  // ES
      "Étiquette",  // FR
      "Etiket" };  // TR

    public static readonly string[] LabelTip = {
      "Create visible MText for each detail.\r\n" +
        "Whenever possible texts will be inserted into the space of the paper.\r\n" +
        "Otherwise will be used UCS.",
      "Будут созданы видимые тексты (MText) для каждой детали.\r\n" +
        "По возможности тексты вставляются в пространство бумаги.\r\n" +
        "В модели тексты будут развернуты по текущей системе координат UCS.",
      "Crea MText visibile per ogni dettaglio.\r\n" +
        "Ogni qualvolta possibile, i testi verranno inseriti nello spazio della carta.\r\n" +
        "Altrimenti verrà utilizzato UCS.",
      "Erstellen Sie sichtbaren MText für jedes Detail.\r\n" +
         "Wo immer möglich, werden Texte in den Raum des Papiers eingefügt.\r\n" +
         "Andernfalls wird UCS verwendet.",
      "为每个细节创建可见的多行文字。\r\n" +
         "只要有可能，文本就会被插入到纸张的空间中。\r\n" +
         "否则将使用 UCS。",
      "Crear MText visible para cada detalle.\r\n" +  // ES
        "Siempre que sea posible, los textos se insertarán en el espacio del papel.\r\n" +
        "De lo contrario, se usará UCS.",
      "Créer un MText visible pour chaque détail.\r\n" +  // FR
        "Dans la mesure du possible, les textes seront insérés dans l'espace du papier.\r\n" +
        "Sinon, UCS sera utilisé.",
      "Her ayrıntı için görünür MText oluşturun.\r\n" +  // TR
        "Mümkün olduğunca metinler kağıdın alanına eklenecektir.\r\n" +
        "Aksi takdirde UCS kullanılacaktır." };

    public static readonly string[] UnderText = {
      "Under",
      "Под",
      "Sotto",
      "Unter",
      "在下面",
      "Debajo",  // ES
      "En dessous",  // FR
      "Altında" };  // TR

    public static readonly string[] UnderTip = {
      "Under the dimensions of the detail.",
      "Под габаритами детали",
      "Sotto le dimensioni del dettaglio.",
      "Unter den Abmessungen des Details.",
      "根据细节的尺寸。",
      "Debajo de las dimensiones del detalle.",  // ES
      "En dessous des dimensions du détail.",  // FR
      "Ayrıntının boyutlarının altında." };  // TR
  }
}
