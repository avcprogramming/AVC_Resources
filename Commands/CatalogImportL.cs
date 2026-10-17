// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация импорта свойств из строки веб-каталога (CatalogImport)
  /// Порядок языков: en, ru, it, de, zh, es, fr, tr
  /// </summary>
  public static class
  CatalogImportL
  {
    public static readonly string[] MaterialTip = {
      "Import material properties from the clipboard.\n" +
        "First copy a product line from a supplier's web catalog with the catalog parser.\n" +
        "Name, use, kind, description, dimensions, supplier, article, price, density, hyperlink and image are filled in.\n" +
        "Dimensions in mm, cm, m, inches or feet are converted to drawing units.\n" +
        "Fields with \"-\" are not changed.\n" +
        "The image is set as the material texture and its main color as the material color.",
      "Импорт свойств материала из буфера обмена.\n" +
        "Сначала скопируйте строку товара из веб-каталога поставщика программой-парсером.\n" +
        "Заполняются имя, назначение, вид, описание, размеры, поставщик, артикул, цена, плотность, ссылка и картинка.\n" +
        "Размеры в мм, см, м, дюймах или футах пересчитываются в единицы чертежа.\n" +
        "Поля со значением \"-\" не изменяются.\n" +
        "Картинка назначается текстурой материала, а ее преобладающий цвет - цветом материала.",
      "Importa le proprietà del materiale dagli appunti.\n" +
        "Copiare prima una riga prodotto dal catalogo web del fornitore con il parser.\n" +
        "Vengono compilati nome, uso, tipo, descrizione, dimensioni, fornitore, articolo, prezzo, densità, link e immagine.\n" +
        "Le dimensioni in mm, cm, m, pollici o piedi vengono convertite in unità del disegno.\n" +
        "I campi \"-\" non vengono modificati.\n" +
        "L'immagine diventa la texture del materiale e il suo colore principale il colore del materiale.",
      "Materialeigenschaften aus der Zwischenablage importieren.\n" +
        "Zuerst eine Produktzeile aus dem Webkatalog des Lieferanten mit dem Parser kopieren.\n" +
        "Name, Verwendung, Art, Beschreibung, Abmessungen, Lieferant, Artikel, Preis, Dichte, Hyperlink und Bild werden übernommen.\n" +
        "Maße in mm, cm, m, Zoll oder Fuß werden in Zeichnungseinheiten umgerechnet.\n" +
        "Felder mit \"-\" bleiben unverändert.\n" +
        "Das Bild wird als Materialtextur und seine Hauptfarbe als Materialfarbe gesetzt.",
      "从剪贴板导入材质属性。\n请先用目录解析程序从供应商网络目录复制一行产品数据。\n" +
        "将填写名称、用途、类型、描述、尺寸、供应商、货号、价格、密度、链接和图像。\n" +
        "以 mm、cm、m、英寸或英尺表示的尺寸将换算为图形单位。\n" +
        "值为 \"-\" 的字段不会更改。\n" +
        "图像设为材质纹理，其主色设为材质颜色。",
      "Importar propiedades del material desde el portapapeles.\n" +
        "Primero copie una línea de producto del catálogo web del proveedor con el analizador.\n" +
        "Se rellenan nombre, uso, tipo, descripción, dimensiones, proveedor, artículo, precio, densidad, enlace e imagen.\n" +
        "Las dimensiones en mm, cm, m, pulgadas o pies se convierten a unidades del dibujo.\n" +
        " Los campos con \"-\" no se modifican.\n" +
        "La imagen se asigna como textura del material y su color principal como color del material.",
      "Importer les propriétés du matériau depuis le presse-papiers.\n" +
        "Copiez d'abord une ligne produit du catalogue web du fournisseur avec l'analyseur.\n" +
        "Nom, usage, type, description, dimensions, fournisseur, article, prix, densité, lien et image sont renseignés.\n" +
        "Les dimensions en mm, cm, m, pouces ou pieds sont converties en unités du dessin.\n" +
        "Les champs « - » ne sont pas modifiés.\n" +
        "L'image devient la texture du matériau et sa couleur dominante la couleur du matériau.",
      "Malzeme özelliklerini panodan içe aktar.\n" +
        "Önce ayrıştırıcı ile tedarikçinin web kataloğundan bir ürün satırı kopyalayın.\n" +
        "Ad, kullanım, tür, açıklama, boyutlar, tedarikçi, ürün kodu, fiyat, yoğunluk, bağlantı ve resim doldurulur.\n" +
        "mm, cm, m, inç veya fit cinsinden boyutlar çizim birimlerine dönüştürülür.\n" +
        "\"-\" olan alanlar değiştirilmez.\n" +
        "Resim malzeme dokusu, baskın rengi ise malzeme rengi olarak atanır."};

    public static readonly string[] BlockTip = {
      "Import block properties and attributes from the clipboard.\n" +
        "First copy a product line from a supplier's web catalog with the catalog parser.\n" +
        "Dimensions, price and weight go to the block metric, the product type is set, other fields\n" +
        "(kind, supplier, article, hyperlink, image) are written to constant block attributes;\n" +
        "missing attributes are created.\n" +
        "Dimensions in mm, cm, m, inches or feet are converted to drawing units.\n" +
        "Fields with \"-\" are not changed.",
      "Импорт свойств и атрибутов блока из буфера обмена.\n" +
        "Сначала скопируйте строку товара из веб-каталога поставщика программой-парсером.\n" +
        "Размеры, цена и вес записываются в метрику блока, устанавливается признак изделия, остальные поля\n" +
        "(вид, поставщик, артикул, ссылка, картинка) - в константные атрибуты блока;\n" +
        "недостающие атрибуты создаются.\n" +
        "Размеры в мм, см, м, дюймах или футах пересчитываются в единицы чертежа.\n" +
        "Поля со значением \"-\" не изменяются.",
      "Importa proprietà e attributi del blocco dagli appunti.\n" +
        "Copiare prima una riga prodotto dal catalogo web del fornitore con il parser.\n" +
        "Dimensioni, prezzo e peso vanno nella metrica del blocco, viene impostato il tipo prodotto, gli altri campi\n" +
        "(tipo, fornitore, articolo, link, immagine) vanno negli attributi costanti; gli attributi mancanti vengono creati.\n" +
        "Le dimensioni in mm, cm, m, pollici o piedi vengono convertite in unità del disegno. I campi \"-\" non vengono modificati.",
      "Blockeigenschaften und Attribute aus der Zwischenablage importieren.\n" +
        "Zuerst eine Produktzeile aus dem Webkatalog des Lieferanten mit dem Parser kopieren.\n" +
        "Maße, Preis und Gewicht gehen in die Blockmetrik, der Produkttyp wird gesetzt, andere Felder\n" +
        "(Art, Lieferant, Artikel, Hyperlink, Bild) werden in konstante Blockattribute geschrieben; fehlende Attribute werden erstellt.\n" +
        "Maße in mm, cm, m, Zoll oder Fuß werden in Zeichnungseinheiten umgerechnet. Felder mit \"-\" bleiben unverändert.",
      "从剪贴板导入图块属性和属性值。\n请先用目录解析程序从供应商网络目录复制一行产品数据。\n" +
        "尺寸、价格和重量写入图块度量，设置产品类型，其他字段（类型、供应商、货号、链接、图像）写入图块常量属性；缺少的属性将被创建。\n" +
        "以 mm、cm、m、英寸或英尺表示的尺寸将换算为图形单位。值为 \"-\" 的字段不会更改。",
      "Importar propiedades y atributos del bloque desde el portapapeles.\n" +
        "Primero copie una línea de producto del catálogo web del proveedor con el analizador.\n" +
        "Dimensiones, precio y peso van a la métrica del bloque, se marca como producto, los demás campos\n" +
        " (tipo, proveedor, artículo, enlace, imagen) se escriben en atributos constantes; los atributos que faltan se crean.\n" +
        "Las dimensiones en mm, cm, m, pulgadas o pies se convierten a unidades del dibujo. Los campos con \"-\" no se modifican.",
      "Importer les propriétés et attributs du bloc depuis le presse-papiers.\n" +
        "Copiez d'abord une ligne produit du catalogue web du fournisseur avec l'analyseur.\n" +
        "Dimensions, prix et poids vont dans la métrique du bloc, le type produit est défini, les autres champs \n" +
        "(type, fournisseur, article, lien, image) sont écrits dans les attributs constants ; les attributs manquants sont créés.\n" +
        "Les dimensions en mm, cm, m, pouces ou pieds sont converties en unités du dessin. Les champs « - » ne sont pas modifiés.",
      "Blok özelliklerini ve niteliklerini panodan içe aktar.\n" +
        "Önce ayrıştırıcı ile tedarikçinin web kataloğundan bir ürün satırı kopyalayın.\n" +
        "Boyutlar, fiyat ve ağırlık blok metriğine yazılır, ürün türü ayarlanır, diğer alanlar (tür, tedarikçi, ürün kodu, bağlantı, resim)\n" +
        "sabit blok niteliklerine yazılır; eksik nitelikler oluşturulur.\n" +
        "mm, cm, m, inç veya fit cinsinden boyutlar çizim birimlerine dönüştürülür. \"-\" olan alanlar değiştirilmez."};
    /// <summary>
    /// {0} - количество полей
    /// </summary>
    public static readonly string[] BadClipboard = {
      "The clipboard does not contain a catalog line: {0} Tab-separated fields expected.",
      "Буфер обмена не содержит строку каталога: ожидается {0} полей, разделенных табуляцией.",
      "Gli appunti non contengono una riga di catalogo: previsti {0} campi separati da Tab.",
      "Die Zwischenablage enthält keine Katalogzeile: {0} durch Tab getrennte Felder erwartet.",
      "剪贴板中没有目录行：需要 {0} 个以 Tab 分隔的字段。",
      "El portapapeles no contiene una línea de catálogo: se esperan {0} campos separados por tabulación.",
      "Le presse-papiers ne contient pas de ligne de catalogue : {0} champs séparés par des tabulations attendus.",
      "Pano bir katalog satırı içermiyor: Sekme ile ayrılmış {0} alan bekleniyor."};

    /// <summary>
    /// {0} - номер поля, {1} - имя поля, {2} - значение
    /// </summary>
    public static readonly string[] BadValue = {
      "⚠️ Field {0} \"{1}\": value \"{2}\" not recognized and skipped.",
      "⚠️ Поле {0} \"{1}\": значение \"{2}\" не распознано и пропущено.",
      "⚠️ Campo {0} \"{1}\": valore \"{2}\" non riconosciuto e ignorato.",
      "⚠️ Feld {0} \"{1}\": Wert \"{2}\" nicht erkannt und übersprungen.",
      "⚠️ 字段 {0} \"{1}\"：无法识别值 \"{2}\"，已跳过。",
      "⚠️ Campo {0} \"{1}\": valor \"{2}\" no reconocido y omitido.",
      "⚠️ Champ {0} « {1} » : valeur « {2} » non reconnue et ignorée.",
      "⚠️ Alan {0} \"{1}\": \"{2}\" değeri tanınmadı ve atlandı."};

    /// <summary>
    /// {0} - путь или URL, {1} - сообщение об ошибке
    /// </summary>
    public static readonly string[] ImageFailed = {
      "⚠️ Failed to load image \"{0}\". {1}",
      "⚠️ Не удалось загрузить картинку \"{0}\". {1}",
      "⚠️ Impossibile caricare l'immagine \"{0}\". {1}",
      "⚠️ Bild \"{0}\" konnte nicht geladen werden. {1}",
      "⚠️ 无法加载图像 \"{0}\"。{1}",
      "⚠️ No se pudo cargar la imagen \"{0}\". {1}",
      "⚠️ Impossible de charger l'image « {0} ». {1}",
      "⚠️ \"{0}\" resmi yüklenemedi. {1}"};

    /// <summary>
    /// {0} - имя поля в списке полей
    /// </summary>
    public static readonly string[] UnknownField = {
      "⚠️ Unknown catalog field \"{0}\" will be imported as text.",
      "⚠️ Неизвестное поле каталога \"{0}\" будет импортировано как текст.",
      "⚠️ Campo di catalogo sconosciuto \"{0}\" verrà importato come testo.",
      "⚠️ Unbekanntes Katalogfeld \"{0}\" wird als Text importiert.",
      "⚠️ 未知目录字段 \"{0}\" 将作为文本导入。",
      "⚠️ El campo de catálogo desconocido \"{0}\" se importará como texto.",
      "⚠️ Le champ de catalogue inconnu « {0} » sera importé comme texte.",
      "⚠️ Bilinmeyen katalog alanı \"{0}\" metin olarak içe aktarılacak."};
  }
}
