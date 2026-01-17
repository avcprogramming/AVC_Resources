// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Ent

namespace AVC
{
  public static class
  EntityFilterL
  {
    public static readonly string[] Reading = {
      "Reading object properties",
      "Чтение свойств объектов",
      "Lettura delle proprietà degli oggetti",
      "Lesen von Objekteigenschaften",
      "读取对象属性",
      "Leyendo propiedades de objeto",                  // ES
      "Lecture des propriétés d'objet",                 // FR
      "Nesne özellikleri okunuyor" };                   // TR

    public static readonly string[] ChoiceTip = {
      "Dialog of a choice from the list.",
      "Диалог выбора из списка.",
      "Finestra di dialogo di una scelta dall'elenco.",
      "Dialog einer Auswahl aus der Liste.",
      "从列表中选择一个对话框。",
      "Diálogo de selección de la lista.",              // ES
      "Dialogue de choix dans la liste.",               // FR
      "Listeden seçim için iletişim kutusu."};         // TR

    public static readonly string[] ContinuousOnly = {
      "Continuous linetype only",
      "Только Сплошные линии",
      "Solo tipo di linea 'Continuo'",
      "Nur durchgehender Linientyp",
      "过滤虚线",
      "Solo tipo de línea continua",                    // ES
      "Type de ligne continue uniquement",              // FR
      "Yalnızca sürekli çizgi türü"};                  // TR

    public static readonly string[] ContinuousOnlyTip = {
      "Ignore lines with dashed linetype (hidden, dash, dot...)",
      "Игнорировать объекты с пунктирными типами линий (linetype = hidden, dash, dot...)",
      "Ignora linee con tipo di linea tratteggiata (nascosto, asse ...)",
      "Linien mit gestricheltem Linientyp ignorieren (hidden, dash, dot...)",
      "忽略虚线型的线 (hidden, dash, dot...)",
      "Ignorar líneas con tipo de línea discontinua (oculta, raya, punto...)",  // ES
      "Ignorer les lignes avec type de ligne en pointillés (cachée, tiret, point...)",  // FR
      "Kesikli çizgi türüne sahip çizgileri yoksay (gizli, tire, nokta...)"};  // TR

    public static readonly string[] CountAssemblies = {
      "Count Assemblies",
      "Посчитать сборки",
      "Conta blocchi",
      "Versammlungen zählen",
      "计数组件",
      "Contar ensamblajes",                             // ES
      "Compter les assemblages",                        // FR
      "Montajları say"};                                // TR

    public static readonly string[] CountAssembliesTip = {
      "Calculate and account for how many blocks you have inserted into the model space.\r\n" +
        "The number of parts to be machined will be multiplied by this number of assembly blocks.\r\n" +
        "It doesn't matter how many blocks you select - all blocks of the model will be used for the calculation. \r\n" +
        "Solids in mirror blocks will be mirrored.\r\n" +
        "You can exclude some of the blocks from the count using ignored layers. Blocks of the 'Excluding' layer are always ignored.\r\n" +
        "This option is useful for compiling tables by assembly view when only 1 block is visible in the viewport.",
      "Подсчитать и учесть, сколько блоков вы вставили в пространство модели.\r\n" +
        "Количество обрабатываемых деталей будет помножено на это количество блоков-сборок.\r\n" +
        "Не имеет значения сколько блоков вы выбрали - для расчета будут использованы все блоки модели.\r\n" +
        "Детали-солиды в зеркальных блоках будут отзеркалены.\r\n" +
        "Вы можете исключить из подсчета часть блоков используя игнорируемые слои. Блоки слоя 'Без учета' игнорируются всегда.\r\n" +
        "Данная опция полезна для составления таблиц по сборочному виду, когда во вьюпорте виден только 1 блок.",
      "Conta e tieni conto di quanti blocchi hai inserito nello spazio modello.\r\n" +
        "Il numero di pezzi da lavorare sarà moltiplicato per questo numero di blocchi di montaggio.\r\n" +
        "Non importa quanti blocchi selezioni: tutti i blocchi del modello verranno utilizzati per il calcolo.\r\n" +
        "Le parti solide nei blocchi speculari verranno specchiate.\r\n" +
        "È possibile escludere alcuni blocchi dal conteggio utilizzando i livelli ignorati.\r\n" +
        "Questa opzione è utile per la compilazione di tabelle per vista assieme quando nella vista \r\n" +
        "è visibile solo 1 blocco.",
      "Berechnen und berücksichtigen Sie, wie viele Blöcke Sie in den Modellbereich eingefügt haben.\r\n" +
         "Die Anzahl der zu bearbeitenden Teile wird mit dieser Anzahl der Montageblöcke multipliziert.\r\n" +
         "Egal, wie viele Blöcke Sie auswählen - alle Blöcke des Modells werden für die Berechnung verwendet.\r\n" +
         "Körper in Spiegelblöcken werden gespiegelt.\r\n" +
         "Sie können einige der Blöcke mit ignorierten Layern von der Zählung ausschließen.\r\n" +
         "Diese Option ist nützlich zum Kompilieren von Tabellen nach Baugruppenansicht, \r\n" +
        "wenn nur 1 Block im Ansichtsfenster sichtbar ist.",
      "计算并说明您在模型空间中插入了多少块。\r\n" +
         "要加工的零件数量将乘以这个装配块的数量。\r\n" +
         "无论您选择多少块 - 模型的所有块都将用于计算。\r\n" +
         "镜像块中的实体将被镜像。\r\n" +
         "您可以使用忽略的图层从计数中排除一些块。\r\n" +
         "当视口中只有 1 个块可见时，此选项对于按装配视图编译表很有用。",
      "Calcule y tenga en cuenta cuántos bloques ha insertado en el espacio modelo.\r\n" +  // ES
        "El número de piezas a mecanizar se multiplicará por este número de bloques de ensamblaje.\r\n" +
        "No importa cuántos bloques seleccione: todos los bloques del modelo se usarán para el cálculo. \r\n" +
        "Los sólidos en bloques espejo serán reflejados.\r\n" +
        "Puede excluir algunos bloques del recuento usando capas ignoradas. Los bloques de la capa 'Excluyendo' siempre se ignoran.\r\n" +
        "Esta opción es útil para compilar tablas por vista de ensamblaje cuando solo 1 bloque es visible en la ventana gráfica.",
      "Calculez et tenez compte du nombre de blocs que vous avez insérés dans l'espace modèle.\r\n" +  // FR
        "Le nombre de pièces à usiner sera multiplié par ce nombre de blocs d'assemblage.\r\n" +
        "Peu importe le nombre de blocs que vous sélectionnez - tous les blocs du modèle seront utilisés pour le calcul. \r\n" +
        "Les solides dans les blocs miroir seront mis en miroir.\r\n" +
        "Vous pouvez exclure certains blocs du décompte en utilisant des calques ignorés. Les blocs du calque 'Excluant' sont toujours ignorés.\r\n" +
        "Cette option est utile pour compiler des tableaux par vue d'assemblage lorsque seul 1 bloc est visible dans la fenêtre.",
      "Model alanına kaç blok eklediğinizi hesaplayın ve hesaba katın.\r\n" +  // TR
        "İşlenecek parça sayısı bu montaj bloğu sayısıyla çarpılacaktır.\r\n" +
        "Kaç blok seçtiğiniz önemli değildir - modelin tüm blokları hesaplama için kullanılacaktır. \r\n" +
        "Ayna bloklardaki katılar yansıtılacaktır.\r\n" +
        "Yoksayılan katmanları kullanarak bazı blokları sayımdan hariç tutabilirsiniz. 'Hariç Tutma' katmanının blokları her zaman yoksayılır.\r\n" +
        "Bu seçenek, görünümde yalnızca 1 blok görünür olduğunda montaj görünümüne göre tabloları derlemek için kullanışlıdır."};

    public static readonly string[] ExcludeSelectedAssembly = {
      "Exclude Selected",
      "Исключая выбранные",
      "Escludi selezionati",
      "Ausgewählte ausschließen",
      "排除所选",
      "Excluir seleccionados",                          // ES
      "Exclure sélectionnés",                           // FR
      "Seçilenleri hariç tut"};                         // TR

    public static readonly string[] ExcludeSelectedAssemblyTip = {
      "Exclude from the count those assemblies that you have selected or that are visible in the viewport. \r\n" +
        "Use this option when you have made an extra copy of an assembly \r\n" +
        "just for the assembly view and does not need to be produced.",
      "Исключить из подсчета те сборки, что вы выбрали или которые видны во вьюпорте. \r\n" +
        "Используйте эту опцию, когда вы сделали лишнюю копию сборки\r\n" +
        "только для оформления сборочного вида и ее не надо изготавливать.",
      "Escludere dal conteggio gli assiemi che hai selezionato o che sono visibili nella finestra.\r\n" +
        "Utilizzare questa opzione quando è stata creata una copia aggiuntiva dell'assieme \r\n" +
        "solo per la vista dell'assieme e non è necessario produrla.",
      "Schließen Sie die Baugruppen aus der Zählung aus, \r\n" +
        "die Sie ausgewählt haben oder die im Ansichtsfenster sichtbar sind. "+
        "Verwenden Sie diese Option, \r\n" +
        "wenn Sie eine zusätzliche Kopie einer Baugruppe nur für die Baugruppenansicht erstellt haben \r\n" +
        "und nicht produziert werden müssen.",
      "从计数中排除您已选择或在视口中可见的那些组件。 \r\n" +
         "当您为装配视图制作了额外的装配副本并且不需要生成时，请使用此选项。",
      "Excluir del recuento los ensamblajes que ha seleccionado o que son visibles en la ventana gráfica. \r\n" +  // ES
        "Use esta opción cuando haya hecho una copia adicional de un ensamblaje \r\n" +
        "solo para la vista de ensamblaje y no necesita ser producida.",
      "Exclure du décompte les assemblages que vous avez sélectionnés ou qui sont visibles dans la fenêtre. \r\n" +  // FR
        "Utilisez cette option lorsque vous avez fait une copie supplémentaire d'un assemblage \r\n" +
        "juste pour la vue d'assemblage et qu'elle n'a pas besoin d'être produite.",
      "Seçtiğiniz veya görünümde görünür olan montajları sayımdan hariç tutun. \r\n" +  // TR
        "Yalnızca montaj görünümü için fazladan bir montaj kopyası yaptığınızda \r\n" +
        "ve üretilmesi gerekmediğinde bu seçeneği kullanın."};

    public static readonly string[] InsideAssembly = {
      "Inside Assembly",
      "Внутри сборок",
      "Assemblea interna",
      "Innenmontage",
      "内部组装",
      "Dentro del ensamblaje",                          // ES
      "À l'intérieur de l'assemblage",                  // FR
      "Montaj içinde"};                                 // TR

    public static readonly string[] InsideAssemblyTip = {
      "Read object data inside assembly blocks and arrays.\r\n" +
        "Assemblies are considered simple explodable blocks - not annotative and not dynamic.",
      "Вытаскивать объекты из блоков-сборок.\r\n" +
        "Сборками считаются все простые взрываемые блоки - не аннотативные и не динамические.",
      "Leggere i dati degli oggetti all'interno di blocchi e matrici di assieme.\r\n" +
        "Gli assiemi sono considerati blocchi semplici - non annotativi e non dinamici.",
      "Objektdaten in Assembly-Blöcken und Arrays lesen.\r\n" +
         "Baugruppen werden als einfache explodierbare Blöcke betrachtet – nicht beschriftet und nicht dynamisch.",
      "读取装配块和数组中的对象数据。\r\n" +
         "组件被认为是简单的可爆炸块 - 不是注释性的，也不是动态的。",
      "Leer datos de objetos dentro de bloques y matrices de ensamblaje.\r\n" +  // ES
        "Los ensamblajes se consideran bloques simples explotables - no anotativos y no dinámicos.",
      "Lire les données d'objets à l'intérieur de blocs et de tableaux d'assemblage.\r\n" +  // FR
        "Les assemblages sont considérés comme des blocs simples explosibles - non annotatifs et non dynamiques.",
      "Montaj blokları ve dizileri içindeki nesne verilerini okuyun.\r\n" +  // TR
        "Montajlar basit patlatılabilir bloklar olarak kabul edilir - açıklamalı değil ve dinamik değil."};

    public static readonly string[] NotAnnotations = {
      "Not Annotations",
      "Не аннотации",
      "Non annotazioni",
      "Nicht Anmerkungen",
      "不是注释",
      "No anotaciones",                                 // ES
      "Pas d'annotations",                              // FR
      "Açıklama değil"};                                // TR

    public static readonly string[] NotAnnotationsTip = {
      "Ignore annotations if they fall into the list of selected objects.\r\n" +
        "Will be excluded: \r\n" +
        "- annotation objects (texts, leaders, dimensions, tables, views, hatches)\r\n" +
        "- all objects on the Annotation, Hatching, Axis, Viewport layers\r\n" +
        "- annotative blocks",
      "Игнорировать аннотации, если они попадут в список деталей.\r\n" +
        "Будут исключены:\r\n" +
        "- объекты аннотаций (тексты, выноски, размеры, таблицы, виды, штриховки)\r\n" +
        "- все объекты на слоях Аннотации, Штриховка, Оси, Вьюпорт\r\n" +
        "- аннотативные блоки",
      "Ignora le annotazioni se rientrano nell'elenco degli oggetti selezionati.\r\n" +
        "Saranno esclusi:\r\n" +
        "- oggetti annotazione (testi, direttrici, dimensioni, tabelle, viste, tratteggi)\r\n" +
        "- tutti gli oggetti sui layer Annotazione, Tratteggio, Asse, Viewport\r\n" +
        "- blocchi annotativi",
      "Anmerkungen ignorieren, wenn sie in die Liste der ausgewählten Objekte fallen.\r\n" +
         "Wird ausgeschlossen: \r\n" +
         "- Anmerkungsobjekte (Texte, Führungslinien, Bemaßungen, Tabellen, Ansichten, Schraffuren)\r\n" +
         "- alle Objekte auf den Ebenen Beschriftung, Schraffur, Achse, Ansichtsfenster\r\n" +
         "- Anmerkungsblöcke",
      "如果注释属于选定对象列表，则忽略它们。\r\n" +
         "将被排除：\r\n" +
         "- 注释对象（文本、引线、尺寸、表格、视图、影线）\r\n" +
         "- Annotation、Hatching、Axis、Viewport 图层上的所有对象\r\n" +
         "- 注释块",
      "Ignorar anotaciones si caen en la lista de objetos seleccionados.\r\n" +  // ES
        "Se excluirán: \r\n" +
        "- objetos de anotación (textos, directrices, dimensiones, tablas, vistas, sombreados)\r\n" +
        "- todos los objetos en las capas Anotación, Sombreado, Eje, Ventana gráfica\r\n" +
        "- bloques anotativos",
      "Ignorer les annotations si elles tombent dans la liste des objets sélectionnés.\r\n" +  // FR
        "Seront exclus : \r\n" +
        "- objets d'annotation (textes, lignes de repère, dimensions, tableaux, vues, hachures)\r\n" +
        "- tous les objets sur les calques Annotation, Hachures, Axe, Fenêtre\r\n" +
        "- blocs annotatifs",
      "Seçilen nesneler listesine düşerlerse açıklamaları yoksay.\r\n" +  // TR
        "Hariç tutulacaklar: \r\n" +
        "- açıklama nesneleri (metinler, işaret çizgileri, boyutlar, tablolar, görünümler, taramalar)\r\n" +
        "- Açıklama, Tarama, Eksen, Görünüm katmanlarındaki tüm nesneler\r\n" +
        "- açıklamalı bloklar"};

    public static readonly string[] Unlocked = {
      "Unlocked only",
      "Только разблокированные",
      "Solo sbloccato",
      "Nur entsperrt",
      "仅解锁",
      "Solo desbloqueado",                              // ES
      "Déverrouillé uniquement",                        // FR
      "Yalnızca kilitsiz"};                             // TR

    public static readonly string[] UnlockedTip = {
      "Discard all objects from locked layers. Only work with unlocked ones.",
      "Отбросить все объекты с заблокированных слоев. Работать только с разблокированными.",
      "Elimina tutti gli oggetti dai livelli bloccati. Funziona solo con quelli sbloccati.",
      "Alle Objekte aus gesperrten Ebenen verwerfen. Arbeiten Sie nur mit entsperrten.",
      "丢弃锁定层中的所有对象。 仅适用于未锁定的。",
      "Descartar todos los objetos de capas bloqueadas. Solo trabajar con desbloqueados.",  // ES
      "Jeter tous les objets des calques verrouillés. Ne travailler qu'avec ceux déverrouillés.",  // FR
      "Kilitli katmanlardaki tüm nesneleri at. Yalnızca kilitsiz olanlarla çalışın."};  // TR

    public static readonly string[] EntFilter = {
      "Selected object filter",
      "Фильтр выбора объектов",
      "Filtro oggetto selezionato",
      "Ausgewählter Objektfilter",
      "选定对象过滤器",
      "Filtro de objeto seleccionado",                  // ES
      "Filtre d'objet sélectionné",                     // FR
      "Seçili nesne filtresi"};                         // TR

    public static readonly string[] Classes = {
      "Object types",
      "Типы объектов",
      "Tipi di oggetti",
      "Objekttypen",
      "对象类型",
      "Tipos de objeto",                                // ES
      "Types d'objets",                                 // FR
      "Nesne türleri"};                                 // TR

    public static readonly string[] IgnoredLayers = {
      "Ignored layers",
      "Игнорируемые слои",
      "Layer ignorati",
      "Ignorierte Schichten",
      "忽略的图层",
      "Capas ignoradas",                                // ES
      "Calques ignorés",                                // FR
      "Yoksayılan katmanlar"};                          // TR

    public static readonly string[] Material = {
      "Material filter",
      "Материалы",
      "Filtro materiale",
      "Materialfilter",
      "材料过滤器",
      "Filtro de material",                             // ES
      "Filtre de matériau",                             // FR
      "Malzeme filtresi"};                              // TR

    public static readonly string[] Tech = {
      "Technology filter",
      "Технологии",
      "Filtro tecnologico",
      "Technologiefilter",
      "技术过滤器",
      "Filtro de tecnología",                           // ES
      "Filtre de technologie",                          // FR
      "Teknoloji filtresi"};                            // TR

    public static readonly string[] ClassesTip = {
      "Of all the selected objects, only objects of this type will be used.\r\n" +
        "If the list is empty, all objects will be processed.",
      "Из всех выбранных объектов будут использованы только объекты этого типа. \r\n" +
        "Если список пустой - все объекты будут обрабатываться.",
      "Di tutti gli oggetti selezionati, verranno utilizzati solo oggetti di questo tipo.\r\n" +
         "Se l'elenco è vuoto, tutti gli oggetti verranno elaborati.",
      "Von allen ausgewählten Objekten werden nur Objekte dieses Typs verwendet.\r\n" +
         "Wenn die Liste leer ist, werden alle Objekte verarbeitet.",
      "在所有选定的对象中，将仅使用此类型的对象。\r\n" +
         "如果列表为空，则将处理所有对象。",
      "De todos los objetos seleccionados, solo se usarán objetos de este tipo.\r\n" +  // ES
        "Si la lista está vacía, se procesarán todos los objetos.",
      "De tous les objets sélectionnés, seuls les objets de ce type seront utilisés.\r\n" +  // FR
        "Si la liste est vide, tous les objets seront traités.",
      "Seçilen tüm nesnelerden yalnızca bu türdeki nesneler kullanılacaktır.\r\n" +  // TR
        "Liste boşsa, tüm nesneler işlenecektir."};

    public static readonly string[] IgnoredLayersTip = {
      "List of ignored layer (auxiliary). Comma separated.",
      "Список игнорируемых слоев (вспомогательных).\r\n" +
      "Все объекты с этих слоев, будут исключены из обработки.\r\n" +
      "Разделитель списка - точка с запятой.",
      "Elenco aggiuntivo del layer ignorato (ausiliario). Separato da virgola.",
      "Liste der ignorierten Layer (Hilfslayer). Komma getrennt.",
      "忽略层列表（辅助）。 逗号分隔。",
      "Lista de capas ignoradas (auxiliares). Separadas por comas.",  // ES
      "Liste des calques ignorés (auxiliaires). Séparés par des virgules.",  // FR
      "Yoksayılan katman listesi (yardımcı). Virgülle ayrılmış."};  // TR

    public static readonly string[] MaterialTip = {
      "You can limit the list of materials by appointment.",
      "Вы можете ограничить список материалов по их назначению.",
      "Puoi limitare l'elenco dei materiali in base al loro scopo.",
      "Sie können die Materialliste nach Terminvereinbarung einschränken.",
      "您可以通过预约限制材料清单。",
      "Puede limitar la lista de materiales por cita.",  // ES
      "Vous pouvez limiter la liste des matériaux par rendez-vous.",  // FR
      "Malzeme listesini randevuya göre sınırlayabilirsiniz."};  // TR

    public static readonly string[] TechTip = {
      "You can limit the list of solids according to manufacturing technology.\r\n" +
        "List the technology you need through a semicolon without spaces.\r\n" +
        "Technology names can be corrected in Common Options.\r\n" +
        "Leave the list empty to use all the solid.",
      "Вы можете ограничить список 3D-тел в соответствии с технологией производства.\r\n" +
        "Перечислите нужную вам технологию через точку с запятой без пробелов.\r\n" +
        "Названия технологий могут быть исправлены в общих параметрах.\r\n" +
        "Оставьте список пустым, чтобы обрабатывать все детали.",
      "È possibile limitare l'elenco dei solidi in base alla tecnologia di produzione.\r\n" +
        "Elencare la tecnologia necessaria attraverso un punto e virgola senza spazi.\r\n" +
        "I nomi delle tecnologie possono essere corretti in Opzioni comuni.\r\n" +
        "Lascia vuoto l'elenco per usare tutto il solido.",
      "Sie können die Liste der Feststoffe nach Fertigungstechnologie einschränken.\r\n" +
         "Listen Sie die Technologie, die Sie benötigen, durch ein Semikolon ohne Leerzeichen auf.\r\n" +
         "Technologienamen können in den allgemeinen Optionen korrigiert werden.\r\n" +
         "Lassen Sie die Liste leer, um alle Feststoffe zu verwenden.",
      "您可以根据制造技术限制固体列表。\r\n" +
         "通过不带空格的分号列出您需要的技术。\r\n" +
         "可以在通用选项中更正技术名称。\r\n" +
         "将列表留空以使用所有实体。",
      "Puede limitar la lista de sólidos según la tecnología de fabricación.\r\n" +  // ES
        "Liste la tecnología que necesita mediante punto y coma sin espacios.\r\n" +
        "Los nombres de tecnología se pueden corregir en Opciones comunes.\r\n" +
        "Deje la lista vacía para usar todos los sólidos.",
      "Vous pouvez limiter la liste des solides selon la technologie de fabrication.\r\n" +  // FR
        "Listez la technologie dont vous avez besoin par un point-virgule sans espaces.\r\n" +
        "Les noms de technologie peuvent être corrigés dans les Options communes.\r\n" +
        "Laissez la liste vide pour utiliser tous les solides.",
      "Katıların listesini üretim teknolojisine göre sınırlayabilirsiniz.\r\n" +  // TR
        "İhtiyacınız olan teknolojiyi noktalı virgülle boşluk olmadan listeleyin.\r\n" +
        "Teknoloji adları Ortak Seçenekler'de düzeltilebilir.\r\n" +
        "Tüm katıları kullanmak için listeyi boş bırakın."};

    public static readonly string[] PlanarOnly = {
      "Planar only",
      "Только плоские",
      "Solo planare",
      "Nur planar",
      "仅平面",
      "Solo plano",                                     // ES
      "Planaire uniquement",                            // FR
      "Yalnızca düzlemsel" };                           // TR

    public static readonly string[] PlanarOnlyTip = {
      "Discard polylines and splines that are bent in three dimensions",
      "Отбросить полилинии и сплайны, изогнутые в трех измерениях",
      "Scarta polilinee e spline piegate in tre dimensioni",
      "Verwerfen Sie Polylinien und Splines, die in drei Dimensionen gebogen sind",
      "丢弃在三个维度上弯曲的多段线和样条线",
      "Descartar polilíneas y splines dobladas en tres dimensiones",  // ES
      "Jeter les polylignes et splines courbées en trois dimensions",  // FR
      "Üç boyutta bükülmüş poliçizgileri ve spline'ları at" };  // TR

    public static readonly string[] NotTiny = {
      "Not Tiny",
      "Не крошечные",
      "Non minuscolo",
      "Nicht winzig",
      "不小",
      "No diminutos",                                   // ES
      "Pas minuscules",                                 // FR
      "Küçük değil" };                                  // TR

    public static readonly string[] NotTinyTip = {
      "Discard very short curves. The permissible length is configured in the Common Options with the InSize Tolerance parameter",
      "Отбросить очень короткие кривые. Допустимая длина настраивается в Общих Настройках параметром Линейная Точность",
      "Scartare le curve molto corte. La lunghezza consentita è configurata nelle Opzioni comuni con il parametro Tolleranza lineare.",
      "Verwerfen Sie sehr kurze Kurven. Die zulässige Länge wird in den allgemeinen Optionen mit dem Parameter Lineare Toleranz konfiguriert.",
      "放弃非常短的曲线。 允许的长度在公共选项中使用线性公差参数进行配置。",
      "Descartar curvas muy cortas. La longitud permisible se configura en Opciones comunes con el parámetro Tolerancia InSize",  // ES
      "Jeter les courbes très courtes. La longueur admissible est configurée dans les Options communes avec le paramètre Tolérance InSize",  // FR
      "Çok kısa eğrileri at. İzin verilen uzunluk, Ortak Seçenekler'de InSize Tolerans parametresi ile yapılandırılır" };  // TR

    public static readonly string[] BlockDistorted = {
      "Distorted blocks",
      "Искаженные блоки",
      "Blocchi distorti",
      "Verzerrte Blöcke",
      "扭曲的方块",
      "Bloques distorsionados",                         // ES
      "Blocs déformés",                                 // FR
      "왜곡된 블록"};                                     // TR

    public static readonly string[] BlockDistortedTip = {
      "Process distorted blocks stretched in different directions with different scale factors.",
      "Обрабатывать искаженные блоки, растянутые в разные стороны с разным коэффициентом масштаба",
      "Elabora blocchi distorti allungati in direzioni diverse con diversi fattori di scala.",
      "Verarbeiten Sie verzerrte Blöcke, die in verschiedene Richtungen mit unterschiedlichen Skalierungsfaktoren gestreckt sind.",
      "使用不同的比例因子处理在不同方向拉伸的扭曲块。",
      "Procesar bloques distorsionados estirados en diferentes direcciones con diferentes factores de escala.",  // ES
      "Traiter les blocs déformés étirés dans différentes directions avec différents facteurs d'échelle.",  // FR
      "Farklı yönlerde farklı ölçek faktörleriyle uzatılmış왜곡된 blokları işle."};  // TR

    public static readonly string[] BlockDynamic = {
      "Dynamic blocks",
      "Динамические блоки",
      "Blocchi dinamici",
      "Dynamische Blöcke",
      "动态块",
      "Bloques dinámicos",                              // ES
      "Blocs dynamiques",                               // FR
      "Dinamik bloklar"};                               // TR

    public static readonly string[] BlockDynamicTip = {
      "Process dynamic blocks and parametric components.",
      "Обрабатывать динамические блоки и параметрические компоненты",
      "Elabora blocchi dinamici e componenti parametrici.",
      "Verarbeiten Sie dynamische Blöcke und parametrische Komponenten.",
      "处理动态块和参数组件。",
      "Procesar bloques dinámicos y componentes paramétricos.",  // ES
      "Traiter les blocs dynamiques et les composants paramétriques.",  // FR
      "Dinamik blokları ve parametrik bileşenleri işle."};  // TR

    public static readonly string[] BlockScaled = {
      "Scaled blocks",
      "Масштабированные блоки",
      "Blocchi scalati",
      "Skalierte Blöcke",
      "缩放块",
      "Bloques escalados",                              // ES
      "Blocs mis à l'échelle",                          // FR
      "Ölçeklenmiş bloklar"};                           // TR

    public static readonly string[] BlockScaledTip = {
      "Process scaled blocks",
      "Обрабатывать масштабированные блоки",
      "Elabora blocchi scalati",
      "Prozessskalierte Blöcke",
      "处理缩放块",
      "Procesar bloques escalados",                     // ES
      "Traiter les blocs mis à l'échelle",              // FR
      "Ölçeklenmiş blokları işle"};                     // TR

    public static readonly string[] BlockNamed = {
      "Named blocks only",
      "Только именованные блоки",
      "Solo blocchi nominati",
      "Nur benannte Blöcke",
      "仅命名块",
      "Solo bloques con nombre",                        // ES
      "Blocs nommés uniquement",                        // FR
      "Yalnızca adlandırılmış bloklar"    };            // TR

    public static readonly string[] BlockNamedTip = {
      "Process only named blocks. \r\n" +
        "Unnamed arrays, instances of dynamic blocks, center marks will be ignored. \r\n" +
        "But if working inside assemblies is configured, \r\n" +
        "then objects from arrays will be processed regardless of this setting.",
      "Обрабатывать только именованные блоки. \r\n" +
        "Безымянные массивы, экземпляры динамических блоков, метки центра будут проигнорированы. \r\n" +
        "Но если настроена работа внутри сборок, \r\n" +
        "то объекты из массивов будут обрабатываться независимо от этой настройки.",
      "Elabora solo blocchi denominati. \r\n" +
        "Array senza nome, istanze di blocchi dinamici, segni centrali verranno ignorati. \r\n" +
        "Ma se è configurato il lavoro all'interno degli assiemi, \r\n" +
        "gli oggetti dagli array verranno elaborati indipendentemente da questa impostazione.",
      "Verarbeiten Sie nur benannte Blöcke. \r\n" +
        "Unbenannte Arrays, Instanzen dynamischer Blöcke, Mittelmarken werden ignoriert. \r\n" +
        "Wenn jedoch die Arbeit innerhalb von Baugruppen konfiguriert ist, \r\n" +
        "werden Objekte aus Arrays unabhängig von dieser Einstellung verarbeitet.",
      "仅处理命名块。\r\n" +
        "将忽略未命名的数组、动态块的实例、中心标记。\r\n" +
        "但是如果配置了在装配体内工作，\r\n" +
        "那么无论此设置如何，都将处理数组中的对象。",
      "Procesar solo bloques con nombre. \r\n" +  // ES
        "Se ignorarán matrices sin nombre, instancias de bloques dinámicos, marcas de centro. \r\n" +
        "Pero si se configura trabajar dentro de ensamblajes, \r\n" +
        "los objetos de las matrices se procesarán independientemente de esta configuración.",
      "Traiter uniquement les blocs nommés. \r\n" +  // FR
        "Les tableaux sans nom, les instances de blocs dynamiques, les marques centrales seront ignorés. \r\n" +
        "Mais si le travail à l'intérieur des assemblages est configuré, \r\n" +
        "les objets des tableaux seront traités indépendamment de ce paramètre.",
      "Yalnızca adlandırılmış blokları işle. \r\n" +  // TR
        "Adsız diziler, dinamik blok örnekleri, merkez işaretleri yoksayılacaktır. \r\n" +
        "Ancak montajlar içinde çalışma yapılandırılmışsa, \r\n" +
        "dizilerden nesneler bu ayardan bağımsız olarak işlenecektir."    };

    public static readonly string[] AllFiltered =  {
      "All objects are filtered. Change the selection conditions.",
      "Все объекты отфильтрованы. Смените условия отбора.",
      "Tutti gli oggetti vengono filtrati. Modificare le condizioni di selezione.",
      "Alle Objekte werden gefiltert. Ändern Sie die Auswahlbedingungen.",
      "所有对象都被过滤。 更改选择条件。",
      "Todos los objetos están filtrados. Cambie las condiciones de selección.",  // ES
      "Tous les objets sont filtrés. Modifiez les conditions de sélection.",  // FR
      "Tüm nesneler filtrelendi. Seçim koşullarını değiştirin." };  // TR

    public static readonly string[] Filtered =  {
      "  After filtering, {0} objects were obtained.",
      "  После фильтрации получено {0} объектов.",
      "  Dopo il filtraggio sono stati ottenuti {0} oggetti.",
      "  Nach dem Filtern wurden {0} Objekte erhalten.",
      "  过滤后，得到{0}个对象。",
      "  Después del filtrado, se obtuvieron {0} objetos.",  // ES
      "  Après filtrage, {0} objets ont été obtenus.",  // FR
      "  Filtrelemeden sonra {0} nesne elde edildi." };  // TR

    public static readonly string[] ReadBlocks = {
      "Block reading",
      "Чтение блоков",
      "Blocca la lettura",
      "Blockieren Sie das Lesen",
      "块阅读",
      "Lectura de bloques",                             // ES
      "Lecture de blocs",                               // FR
      "Blok okuma" };                                   // TR

    //=====================================================================================================================
    //=====================================    Warning Messages   =========================================================

    public static readonly string[] MsgClass = {
      "Filtered objects of the wrong type",
      "Отфильтрованы объекты неподходящего типа",
      "Oggetti filtrati del tipo sbagliato",
      "Gefilterte Objekte des falschen Typs",
      "过滤的对象类型错误",
      "Objetos filtrados del tipo incorrecto",          // ES
      "Objets filtrés du mauvais type",                 // FR
      "Yanlış türdeki nesneler filtrelendi"};           // TR

    public static readonly string[] MsgLayer = {
      "Filtered objects from ignored layers",
      "Отфильтрованы объекты с игнорируемых слоев",
      "Oggetti filtrati da livelli ignorati",
      "Gefilterte Objekte aus ignorierten Ebenen",
      "从被忽略的图层中过滤的对象",
      "Objetos filtrados de capas ignoradas",           // ES
      "Objets filtrés de calques ignorés",              // FR
      "Yoksayılan katmanlardan nesneler filtrelendi"};  // TR

    public static readonly string[] MsgAnnotation = {
      "Filtered annotation objects",
      "Отфильтрованы объекты аннотаций",
      "Oggetti annotazione filtrati",
      "Gefilterte Anmerkungsobjekte",
      "过滤的注释对象",
      "Objetos de anotación filtrados",                 // ES
      "Objets d'annotation filtrés",                    // FR
      "Açıklama nesneleri filtrelendi"};                // TR

    public static readonly string[] MsgContinuous = {
      "Filtered objects with non-continuous linetype.",
      "Отфильтрованы объекты не непрерывным типом линий",
      "Oggetti filtrati con tipo di linea non continuo.",
      "Gefilterte Objekte mit nicht kontinuierlichem Linientyp.",
      "具有非连续线型的过滤对象。",
      "Objetos filtrados con tipo de línea no continua.",  // ES
      "Objets filtrés avec type de ligne non continu.",  // FR
      "Sürekli olmayan çizgi türüne sahip nesneler filtrelendi."};  // TR

    public static readonly string[] MsgFrozen = {
      "Invisible objects or objects from a disabled or frozen layer are filtered out.",
      "Отфильтрованы невидимые объекты или объекты с отключенного или замороженного слоя",
      "Gli oggetti invisibili o gli oggetti di un Layer disabilitato o congelato vengono filtrati.",
      "Unsichtbare Objekte oder Objekte aus einer deaktivierten oder eingefrorenen Ebene herausgefiltert",
      "过滤掉不可见的对象或禁用或冻结图层中的对象。",
      "Se filtran objetos invisibles u objetos de una capa deshabilitada o congelada.",  // ES
      "Les objets invisibles ou les objets d'un calque désactivé ou gelé sont filtrés.",  // FR
      "Görünmez nesneler veya devre dışı bırakılmış veya dondurulmuş katmandaki nesneler filtrelendi."};  // TR

    public static readonly string[] MsgLocked = {
      "Filtered objects from a locked layer.",
      "Отфильтрованы объекты с заблокированного слоя",
      "Oggetti filtrati da un livello bloccato.",
      "Gefilterte Objekte aus einer gesperrten Ebene.",
      "从锁定层过滤的对象。",
      "Objetos filtrados de una capa bloqueada.",       // ES
      "Objets filtrés d'un calque verrouillé.",         // FR
      "Kilitli katmandan nesneler filtrelendi."};       // TR

    public static readonly string[] MsgTechnology = {
      "Filtered solids not suitable for manufacturing technology",
      "Отфильтрованы солиды не подходящие по технологии изготовления",
      "Solidi filtrati non adatti alla tecnologia di produzione",
      "Gefilterte Feststoffe nicht fertigungstechnisch geeignet",
      "过滤后的固体不适用于制造技术",
      "Sólidos filtrados no adecuados para tecnología de fabricación",  // ES
      "Solides filtrés non adaptés à la technologie de fabrication",  // FR
      "Üretim teknolojisi için uygun olmayan katılar filtrelendi"};  // TR

    public static readonly string[] MsgMatUse = {
      "Filtered materials that did not fit by type of use",
      "Отфильтрованы материалы не подошедшие по типу использования",
      "Materiali filtrati che non si adattavano al tipo di utilizzo",
      "Gefilterte Materialien, die nicht nach Verwendungsart passten",
      "过滤的不符合使用类型的材料",
      "Materiales filtrados que no se ajustaban por tipo de uso",  // ES
      "Matériaux filtrés qui ne correspondaient pas au type d'utilisation",  // FR
      "Kullanım türüne uymayan malzemeler filtrelendi"};  // TR

    public static readonly string[] MsgBlockDistorted = {
      "The distorted block is filtered (different scales on different axes). " +
        "Processing objects inside the block is not possible.",
      "Отфильтрован искаженный блок (разные масштабы по разным осям). " +
        "Обработка объектов внутри блока невозможна.",
      "Il blocco distorto viene filtrato (diverse scale su diversi assi). " +
        "Non è possibile elaborare oggetti all'interno del blocco.",
      "Der verzerrte Block wird gefiltert (verschiedene Skalen auf verschiedenen Achsen). " +
        "Die Verarbeitung von Objekten innerhalb des Blocks ist nicht möglich.",
      "扭曲的块被过滤（不同轴上的不同比例）。 " +
        "无法处理块内的对象。 过滤后的扭曲块（不同轴上的不同比例）。",
      "El bloque distorsionado está filtrado (diferentes escalas en diferentes ejes). " +  // ES
        "No es posible procesar objetos dentro del bloque.",
      "Le bloc déformé est filtré (échelles différentes sur différents axes). " +  // FR
        "Le traitement des objets à l'intérieur du bloc n'est pas possible.",
      "왜곡된 블록 filtrelendi (farklı eksenlerde farklı ölçekler). " +  // TR
        "Blok içindeki nesneleri işlemek mümkün değildir." };

    public static readonly string[] MsgBlockScaled = {
      "The scaled block is filtered. Measurement of solids inside the block is not possible.",
      "Отфильтрован масштабированный блок. Обмер солидов внутри блока невозможен.",
      "Il blocco scalato viene filtrato. La misurazione dei solidi all'interno del blocco non è possibile.",
      "Der skalierte Block wird gefiltert. Die Messung von Volumenkörpern innerhalb des Blocks ist nicht möglich.",
      "缩放的块被过滤。 无法测量块内的固体。",
      "El bloque escalado está filtrado. No es posible medir sólidos dentro del bloque.",  // ES
      "Le bloc mis à l'échelle est filtré. La mesure des solides à l'intérieur du bloc n'est pas possible.",  // FR
      "Ölçeklenmiş blok filtrelendi. Blok içindeki katıları ölçmek mümkün değildir." };  // TR

    public static readonly string[] MsgBlockDynamic = {
      "Filtered dynamic block or mechanical component.",
      "Отфильтрован динамический блок или компонент Mechanical.",
      "Blocco dinamico filtrato o componente meccanico.",
      "Gefilterter dynamischer Block oder mechanische Komponente.",
      "过滤的动态块或机械组件。",
      "Bloque dinámico o componente mecánico filtrado.",  // ES
      "Bloc dynamique ou composant mécanique filtré.",  // FR
      "Dinamik blok veya mekanik bileşen filtrelendi." };  // TR

    public static readonly string[] MsgBlockMeasureOn = {
      "A block with the Measure = No attribute has been filtered.",
      "Отфильтрован блок с атрибутом Обмерять = Нет.",
      "È stato filtrato un blocco con l'attributo Misura = No.",
      "Ein Block mit dem Attribut Measure = No wurde gefiltert.",
      "具有 措施 = 不 属性的块已被过滤。",
      "Se ha filtrado un bloque con el atributo Medir = No.",  // ES
      "Un bloc avec l'attribut Mesurer = Non a été filtré.",  // FR
      "Ölç = Hayır özniteliğine sahip bir blok filtrelendi." };  // TR

    public static readonly string[] MsgUnnamed = {
      "An unnamed block is filtered (array, table, center mark).",
      "Отфильтрован безымянный блок (массив, таблица, метка центра).",
      "Viene filtrato un blocco senza nome (matrice, tabella, contrassegno centrale).",
      "Ein unbenannter Block wird gefiltert (Array, Tabelle, Mittelpunkt).",
      "过滤一个未命名的块（数组、表格、中心标记）。",
      "Se filtra un bloque sin nombre (matriz, tabla, marca de centro).",  // ES
      "Un bloc sans nom est filtré (tableau, table, marque centrale).",  // FR
      "Adsız bir blok filtrelendi (dizi, tablo, merkez işareti)." };  // TR

    public static readonly string[] MsgNoModelAssembly = {
      "No assembly blocks were found in model space.",
      "В пространстве модели не найдены блоки-сборки.",
      "Non sono stati trovati blocchi di assieme nello spazio modello.",
      "Im Modellbereich wurden keine Montageblöcke gefunden.",
      "在模型空间中未找到装配块。",
      "No se encontraron bloques de ensamblaje en el espacio modelo.",  // ES
      "Aucun bloc d'assemblage n'a été trouvé dans l'espace modèle.",  // FR
      "Model alanında montaj bloğu bulunamadı." };  // TR

    public static readonly string[] PerhapsTech = {
      "  Perhaps all parts are discarded due to inappropriate manufacturing techniques.",
      "  Возможно все детали отброшены из-за неподходящих технологий изготовления",
      "  Forse tutte le parti vengono scartate a causa di tecniche di produzione inadeguate.",
      "  Möglicherweise werden alle Teile aufgrund ungeeigneter Herstellungstechniken weggeworfen.",
      "  由于制造技术不当，可能所有零件都被丢弃。",
      "  Quizás todas las piezas se descarten debido a técnicas de fabricación inapropiadas.",  // ES
      "  Peut-être que toutes les pièces sont rejetées en raison de techniques de fabrication inappropriées.",  // FR
      "  Belki tüm parçalar uygunsuz üretim teknikleri nedeniyle atılmıştır."};  // TR

    public static readonly string[] MsgAssembly = {
      "Filtered block assembly",
      "Отфильтрован блок-сборка",
      "Gruppo blocco filtrato",
      "Gefilterte Blockmontage",
      "过滤块组件",
      "Ensamblaje de bloques filtrado",                 // ES
      "Assemblage de blocs filtré",                     // FR
      "Blok montajı filtrelendi" };                     // TR

    public static readonly string[] MsgProduct = {
      "Filtered block item (block that cannot be exploded)",
      "Отфильтрован блок-изделие (блок, который нельзя взрывать)",
      "Elemento di blocco filtrato (blocco che non può essere esploso)",
      "Gefiltertes Blockelement (Block, der nicht aufgelöst werden kann)",
      "过滤的方块物品（不能爆炸的方块）",
      "Elemento de bloque filtrado (bloque que no se puede explotar)",  // ES
      "Élément de bloc filtré (bloc qui ne peut pas être explosé)",  // FR
      "Blok öğesi filtrelendi (patlatılamayan blok)" };  // TR

    public static readonly string[] MsgBlockAnnotation = {
      "Filtered Annotative block",
      "Отфильтрован аннотативный блок",
      "Blocco annotativo filtrato",
      "Anmerkungsblock herausgefiltert",
      "过滤的注释块",
      "Bloque anotativo filtrado",                      // ES
      "Bloc annotatif filtré",                          // FR
      "Açıklamalı blok filtrelendi" };                  // TR

    public static readonly string[] MsgNotPlanar = {
      "Non-planar curve filtered (curved in 3D)",
      "Отфильтрована не плоская кривая (изогнута в 3D)",
      "Curva non piatta filtrata (curva in 3D)",
      "Nicht flache Kurve gefiltert (gekrümmt in 3D)",
      "过滤非平坦曲线（3D 弯曲）",
      "Curva no plana filtrada (curvada en 3D)",        // ES
      "Courbe non plane filtrée (courbée en 3D)",       // FR
      "Düzlemsel olmayan eğri filtrelendi (3D'de eğri)" };  // TR

    public static readonly string[] MsgTiny = {
      "Tiny object filtered out",
      "Отфильтрован крошечный объект",
      "Piccolo oggetto filtrato",
      "Winziges Objekt herausgefiltert",
      "过滤掉微小物体",
      "Objeto diminuto filtrado",                       // ES
      "Objet minuscule filtré",                         // FR
      "Küçük nesne filtrelendi" };                      // TR

  }
}
