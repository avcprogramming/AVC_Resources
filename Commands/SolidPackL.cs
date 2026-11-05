namespace AVC
{
  public static class SolidPackL
  {
    public static readonly string[][] SolidPackStyleNames = {
/* 0 */ CommandL.SPack,
/* 1 */ CommandL.SPack, };

    public static readonly string[] CurrentStyle = {
      "  SPack-style will be used: {0}",
      "  Будет использован стиль упаковки: {0}",
      "  Sarà usato lo stile SPack: {0}",
      "  Der SPack-Stil wird verwendet: {0}",
      "  将使用SPack样式：{0}",
      "  Se utilizará el estilo SPack: {0}",  // ES
      "  Le style SPack sera utilisé : {0}",  // FR
      "  SPack stili kullanılacak: {0}"};  // TR

    public static readonly string[] Packing = {
      "  Packing",
      "  Упаковка",
      "  Impacchettamento",
      "  Verpacken",
      "  打包",
      "  Empaquetado",  // ES
      "  Empaquetage",  // FR
      "  Paketleme"};  // TR

    public static readonly string[] Select = {
      "  Select 3D solids to pack into blocks",
      "  Выберите 3д-солиды для упаковки в блоки",
      "  Seleziona solidi 3D da impacchettare in blocchi",
      "  Wählen Sie 3D-Körper aus, die in Blöcke verpackt werden sollen",
      "  选择要打包为块的3D实体",
      "  Seleccione sólidos 3D para empaquetar en bloques",  // ES
      "  Sélectionnez les solides 3D à empaqueter dans des blocs",  // FR
      "  Bloklara paketlenecek 3D katıları seçin"};  // TR

    public static readonly string[] StyleNameTip = {
      "Name of the solid packing style",
      "Название стиля упаковки солидов в блоки",
      "Nome dello stile di impacchettamento dei solidi",
      "Name des Stils zum Verpacken von Volumenkörpern",
      "实体打包样式名称",
      "Nombre del estilo de empaquetado de sólidos",  // ES
      "Nom du style d'empaquetage des solides",  // FR
      "Katı paketleme stilinin adı"};  // TR

    public static readonly string[] SeparateMirrorTip = {
      "Create separate blocks for mirrored solids. \r\n" +
        "Otherwise mirrored solids are replaced by a mirrored reference (ScaleX=-1) of the same block",
      "Создавать отдельные блоки для зеркальных солидов. \r\n" +
        "Иначе зеркальные солиды заменяются зеркальной вставкой (ScaleX=-1) того же блока",
      "Crea blocchi separati per i solidi speculari. \r\n" +
        "Altrimenti i solidi speculari vengono sostituiti da un riferimento specchiato (ScaleX=-1) dello stesso blocco",
      "Separate Blöcke für gespiegelte Körper erstellen. \r\n" +
        "Andernfalls werden gespiegelte Körper durch eine gespiegelte Referenz (ScaleX=-1) desselben Blocks ersetzt",
      "为镜像实体创建单独的块。否则镜像实体将被同一块的镜像参照(ScaleX=-1)替换",
      "Crear bloques separados para sólidos reflejados. \r\n" +
        "De lo contrario, se reemplazan por una referencia reflejada (ScaleX=-1) del mismo bloque",  // ES
      "Créer des blocs séparés pour les solides symétriques. \r\n" +
        "Sinon, ils sont remplacés par une référence symétrique (ScaleX=-1) du même bloc",  // FR
      "Aynalanmış katılar için ayrı bloklar oluştur. \r\n" +
        "Aksi halde aynı bloğun aynalanmış referansı (ScaleX=-1) ile değiştirilir"};  // TR

    public static readonly string[] ReplaceSolids = {
      "Replace solids with blocks",
      "Заменять солиды блоками",
      "Sostituisci i solidi con blocchi",
      "Körper durch Blöcke ersetzen",
      "用块替换实体",
      "Reemplazar sólidos por bloques",  // ES
      "Remplacer les solides par des blocs",  // FR
      "Katıları bloklarla değiştir"};  // TR

    public static readonly string[] ReplaceSolidsTip = {
      "Replace the source solids with references to the created blocks. Otherwise only block definitions are created",
      "Заменять исходные солиды вставками созданных блоков. Иначе создаются только определения блоков",
      "Sostituisci i solidi originali con riferimenti ai blocchi creati. Altrimenti vengono create solo le definizioni dei blocchi",
      "Ursprüngliche Körper durch Referenzen der erstellten Blöcke ersetzen. Andernfalls werden nur Blockdefinitionen erstellt",
      "用创建的块参照替换源实体。否则仅创建块定义",
      "Reemplazar los sólidos originales por referencias a los bloques creados. De lo contrario, solo se crean definiciones de bloque",  // ES
      "Remplacer les solides d'origine par des références aux blocs créés. Sinon, seules les définitions de blocs sont créées",  // FR
      "Kaynak katıları oluşturulan blok referanslarıyla değiştir. Aksi halde yalnızca blok tanımları oluşturulur"};  // TR

    public static readonly string[] NameTemplate = {
      "Block name",
      "Имя блока",
      "Nome blocco",
      "Blockname",
      "块名称",
      "Nombre del bloque",  // ES
      "Nom du bloc",  // FR
      "Blok adı"};  // TR

    public static readonly string[] NameTemplateTip = {
      "Block name template with substitutions of solid properties. If the name exists, a number is added",
      "Шаблон имени блока с подстановками свойств солида. Если имя уже существует, добавляется цифра",
      "Modello del nome del blocco con sostituzioni delle proprietà del solido. Se il nome esiste, viene aggiunto un numero",
      "Vorlage für den Blocknamen mit Ersetzungen der Körpereigenschaften. Existiert der Name, wird eine Zahl angehängt",
      "带有实体属性替换的块名称模板。如果名称已存在，则添加数字",
      "Plantilla del nombre del bloque con sustituciones de propiedades del sólido. Si el nombre existe, se añade un número",  // ES
      "Modèle de nom de bloc avec substitutions des propriétés du solide. Si le nom existe, un chiffre est ajouté",  // FR
      "Katı özelliklerinin ikameleriyle blok adı şablonu. Ad mevcutsa bir sayı eklenir"};  // TR

    public static readonly string[] AttrForNames = {
      "Name attributes",
      "Атрибуты имени",
      "Attributi del nome",
      "Namensattribute",
      "名称属性",
      "Atributos de nombre",  // ES
      "Attributs de nom",  // FR
      "Ad öznitelikleri"};  // TR

    public static readonly string[] AttrForNamesTip = {
      "Create the attributes Name, Kind, Sweep, and Texture. Write the information into the block description.\r\n" +
        "The Name and Kind attributes are not created if they are used in the block name template.",
      "Создавать атрибуты Имя, Сорт (Kind), Развертка (Sweep) и Текстура. Записать Информацию в Описание блока.\r\n" +
        "Атрибуты Имя и Сорт не создаются, если они использованы в шаблоне имени блока",
      "Créer les attributs Nom, Type (Kind), Développement (Sweep) et Texture. Écrire les informations dans la description du bloc.\r\n" +
        "Les attributs Nom et Type ne sont pas créés s'ils sont utilisés dans le modèle de nom du bloc.",
      "Erstellen Sie die Attribute Name, Art (Kind), Entwicklung (Sweep) und Textur. Schreiben Sie die Informationen in die Blockbeschreibung.\r\n" +
        "Die Attribute Name und Art werden nicht erstellt, wenn sie in der Blocknamensvorlage verwendet werden.",
      "创建名称、种类（Kind）、展开（Sweep）和纹理属性。将信息写入块描述。\r\n" +
        "如果在块名称模板中使用了名称和种类属性，则不会创建这些属性。",
      "Crear los atributos Nombre, Tipo (Kind), Desarrollo (Sweep) y Textura. Escribir la información en la descripción del bloque.\r\n" +
        "Los atributos Nombre y Tipo no se crean si se utilizan en la plantilla de nombre del bloque.",  // ES
      "Créer les attributs Nom, Type (Kind), Développement (Sweep) et Texture. Écrire les informations dans la description du bloc.\r\n" +
        "Les attributs Nom et Type ne sont pas créés s'ils sont utilisés dans le modèle de nom du bloc.",  // FR
      "Ad, Tür (Kind), Geliştirme (Sweep) ve Doku özniteliklerini oluştur. Bilgileri blok açıklamasına yaz.\r\n" +
        "Ad ve Tür öznitelikleri, blok adı şablonunda kullanılıyorsa oluşturulmaz"};  // TR

    public static readonly string[] AttrForMetric = {
      "Metric attributes",
      "Атрибуты метрики",
      "Attributi metrica",
      "Metrikattribute",
      "度量属性",
      "Atributos de métrica",  // ES
      "Attributs de métrique",  // FR
      "Metrik öznitelikleri"};  // TR

    public static readonly string[] AttrForMetricTip = {
      "Transfer the solid metric (size, area, volume, weight, cost, technology, processing directions) to the block metric and attributes",
      "Переносить метрику солида (размеры, площадь, объём, вес, стоимость, технология, направления обработки) в метрику и атрибуты блока",
      "Trasferisci la metrica del solido (dimensioni, area, volume, peso, costo, tecnologia, direzioni di lavorazione) nella metrica e negli attributi del blocco",
      "Metrik des Körpers (Maße, Fläche, Volumen, Gewicht, Kosten, Technologie, Bearbeitungsrichtungen) in Blockmetrik und Attribute übertragen",
      "将实体度量(尺寸、面积、体积、重量、成本、技术、加工方向)传递到块度量和属性",
      "Transferir la métrica del sólido (tamaño, área, volumen, peso, coste, tecnología, direcciones de procesamiento) a la métrica y atributos del bloque",  // ES
      "Transférer la métrique du solide (dimensions, surface, volume, poids, coût, technologie, directions de traitement) vers la métrique et les attributs du bloc",  // FR
      "Katı metriğini (boyut, alan, hacim, ağırlık, maliyet, teknoloji, işleme yönleri) blok metriğine ve özniteliklerine aktar"};  // TR

    public static readonly string[] AttrForCovers = {
      "Cover and edge attributes",
      "Атрибуты покрытий и кромок",
      "Attributi rivestimenti e bordi",
      "Beschichtungs- und Kantenattribute",
      "覆面和封边属性",
      "Atributos de recubrimientos y cantos",  // ES
      "Attributs de revêtements et chants",  // FR
      "Kaplama ve kenar öznitelikleri"};  // TR

    public static readonly string[] AttrForCoversTip = {
      "Create attributes with materials of the front, rear and 4 edge bandings. Attributes are created only for sides with a material",
      "Создавать атрибуты с материалами фасада, тыла и 4х кромок. Атрибуты создаются только для сторон с материалом",
      "Crea attributi con i materiali di fronte, retro e 4 bordi. Gli attributi vengono creati solo per i lati con materiale",
      "Attribute mit Materialien der Vorder-, Rückseite und 4 Kanten erstellen. Nur für Seiten mit Material",
      "创建正面、背面和4条封边的材料属性。仅为有材料的边创建属性",
      "Crear atributos con materiales del frente, trasera y 4 cantos. Solo para lados con material",  // ES
      "Créer des attributs avec les matériaux de la face, du dos et des 4 chants. Seulement pour les côtés avec matériau",  // FR
      "Ön, arka ve 4 kenar bandının malzemeleriyle öznitelikler oluştur. Yalnızca malzemeli kenarlar için"};  // TR

    public static readonly string[] ExposeSolids = {
      "Expose blocks",
      "Выставить блоки",
      "Esponi blocchi",
      "Blöcke auslegen",
      "展示块",
      "Exponer bloques",  // ES
      "Exposer les blocs",  // FR
      "Blokları sergile"};  // TR

    public static readonly string[] ExposeSolidsTip = {
      "Run the Expose command for all created blocks",
      "Вызвать команду Выставка блоков для всех созданных блоков",
      "Esegui il comando Expose per tutti i blocchi creati",
      "Den Befehl Expose für alle erstellten Blöcke ausführen",
      "对所有创建的块运行展示命令",
      "Ejecutar el comando Expose para todos los bloques creados",  // ES
      "Exécuter la commande Expose pour tous les blocs créés",  // FR
      "Oluşturulan tüm bloklar için Expose komutunu çalıştır"};  // TR

    public static readonly string[] Result = {
      "✔ Blocks created: {0}, solids replaced: {1}",
      "✔ Создано блоков: {0}, заменено солидов: {1}",
      "✔ Blocchi creati: {0}, solidi sostituiti: {1}",
      "✔ Erstellte Blöcke: {0}, ersetzte Körper: {1}",
      "✔ 已创建块：{0}，已替换实体：{1}",
      "✔ Bloques creados: {0}, sólidos reemplazados: {1}",  // ES
      "✔ Blocs créés : {0}, solides remplacés : {1}",  // FR
      "✔ Oluşturulan bloklar: {0}, değiştirilen katılar: {1}"};  // TR

    public static readonly string[] NoSolid = {
      "❌ Not a single 3d-solid with a metric ended up in the virtual table row.",
      "❌ В строку виртуальной таблицы не попало ни одного солида с метрикой.",
      "❌ Nessun solido 3D con metrica è finito nella riga della tabella virtuale.",
      "❌ Kein einziger 3D-Körper mit Metrik ist in der virtuellen Tabellenzeile gelandet.",
      "❌ 没有一个带度量的3D实体进入虚拟表行。",
      "❌ Ningún sólido 3D con métrica terminó en la fila de la tabla virtual.",  // ES
      "❌ Aucun solide 3D avec métrique n'est arrivé dans la ligne du tableau virtuel.",  // FR
      "❌ Sanal tablo satırına metrik ile tek bir 3D katı bile girmedi."};  // TR

    public static readonly string[] NonSolidObj = {
      "❌ The selected object is not a 3d-solid: {0}",
      "❌ Выбранный объект не является 3д-солидом: {0}",
      "❌ L'oggetto selezionato non è un solido 3D: {0}",
      "❌ Das ausgewählte Objekt ist kein 3D-Körper: {0}",
      "❌ 所选对象不是3D实体: {0}",
      "❌ El objeto seleccionado no es un sólido 3D: {0}",  // ES
      "❌ L'objet sélectionné n'est pas un solide 3D: {0}",  // FR
      "❌ Seçilen nesne bir 3D katı değil: {0}"};  // TR

    public static readonly string[] SolidHasNoMetric = {
      "❌ The selected solid has no metric: {0}",
      "❌ У выбранного солида нет метрики: {0}",
      "❌ Il solido selezionato non ha metrica: {0}",
      "❌ Der ausgewählte Körper hat keine Metrik: {0}",
      "❌ 所选实体没有度量: {0}",
      "❌ El sólido seleccionado no tiene métrica: {0}",  // ES
      "❌ Le solide sélectionné n'a pas de métrique: {0}",  // FR
      "❌ Seçilen katının metriği yok: {0}"};  // TR


  }
}
