// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  FindNameL
  {

    public static readonly string[] Found = {
      "  Tested objects: {0} / After filter {1} / Found objects: {2}",
      "  Проверено объектов: {0} / После фильтра {1} / Найдено объектов: {2}",
      "  Oggetti controllato: {0} / Dopo il filtro {1} / Gli oggetti trovati: {2}",
      "  Getestete Objekte: {0} / Nach dem Filter {1} / Gefundene Objekte: {2}",
      "  测试对象：{0} / 过滤后 {1} / 找到的对象：{2}",
      "  Objetos probados: {0} / Después del filtro {1} / Objetos encontrados: {2}",  // ES
      "  Objets testés : {0} / Après le filtre {1} / Objets trouvés : {2}",  // FR
      "  Test edilen nesneler: {0} / Filtre sonrası {1} / Bulunan nesneler: {2}"};  // TR

    public static readonly string[] LoadOther = {
      "<< Load the rest >>",
      "<< Загрузить остальные >>",
      "<< Carica il resto >>",
      "<< Noch >>",
      "<< 加载其余 >>",
      "<< Cargar el resto >>",                         // ES
      "<< Charger le reste >>",                        // FR
      "<< Geri kalanı yükle >>"};                      // TR

    public static readonly string[] Title = {
      "Search terms",
      "Условия поиска",
      "Termini di ricerca",
      "Suchbegriffe",
      "搜索词",
      "Términos de búsqueda",                          // ES
      "Termes de recherche",                           // FR
      "Arama terimleri" };                             // TR

    public static readonly string[] ResetTip = {
      "Paste * in all fields",
      "Вставить * во все поля",
      "Incolla * in tutti i campi",
      "Fügen Sie * in alle Felder ein",
      "在所有字段中粘贴 *",
      "Pegar * en todos los campos",                   // ES
      "Coller * dans tous les champs",                 // FR
      "Tüm alanlara * yapıştır"};                      // TR

    public static readonly string[] InfoTip = {
      "Info search terms.\r\n" +
        "* - any set of characters in this place.\r\n" +
        "? - any one character in this place.",
      "Условия поиска Информации.\r\n" +
        "* - любой набор символов в этом месте.\r\n" +
        "? - один любой символ в этом месте.",
      "Termini di ricerca delle informazioni.\r\n" +
        "* - qualsiasi set di caratteri in questo posto.\r\n" +
        "? - qualsiasi personaggio in questo posto.",
      "Info-Suchbegriffe.\r\n" +
        "* - beliebiger Zeichensatz an dieser Stelle.\r\n" +
        "? - ein beliebiges Zeichen an diesem Ort.",
      "信息搜索词。\r\n" +
         "* - 此处的任何字符集。\r\n" +
         "? - 这个地方的任何一个角色。",
      "Términos de búsqueda de información.\r\n" +  // ES
        "* - cualquier conjunto de caracteres en este lugar.\r\n" +
        "? - cualquier carácter en este lugar.",
      "Termes de recherche d'informations.\r\n" +  // FR
        "* - n'importe quel ensemble de caractères à cet endroit.\r\n" +
        "? - n'importe quel caractère à cet endroit.",
      "Bilgi arama terimleri.\r\n" +  // TR
        "* - bu yerde herhangi bir karakter kümesi.\r\n" +
        "? - bu yerde herhangi bir karakter."};

    public static readonly string[] KindTip = {
      "Kind search terms. \r\n" +
        "* - any set of characters in this place.\r\n" +
        "? - any one character in this place.",
      "Условия поиска Типа. \r\n" +
        "* - любой набор символов в этом месте.\r\n" +
        "? - один любой символ в этом месте.",
      "Tipo di termini di ricerca.\r\n" +
        "* - qualsiasi set di caratteri in questo posto.\r\n" +
        "? - qualsiasi personaggio in questo posto.",
      "Art-Suchbegriffe.\r\n" +
        "* - beliebiger Zeichensatz an dieser Stelle.\r\n" +
        "? - ein beliebiges Zeichen an diesem Ort.",
      "友好的搜索条件。。\r\n" +
         "* - 此处的任何字符集。\r\n" +
         "? - 这个地方的任何一个角色。",
      "Términos de búsqueda de tipo. \r\n" +  // ES
        "* - cualquier conjunto de caracteres en este lugar.\r\n" +
        "? - cualquier carácter en este lugar.",
      "Termes de recherche de type. \r\n" +  // FR
        "* - n'importe quel ensemble de caractères à cet endroit.\r\n" +
        "? - n'importe quel caractère à cet endroit.",
      "Tür arama terimleri. \r\n" +  // TR
        "* - bu yerde herhangi bir karakter kümesi.\r\n" +
        "? - bu yerde herhangi bir karakter."};

    public static readonly string[] NameTip = {
      "Name search terms. \r\n" +
        "* - any set of characters in this place.\r\n" +
        "? - any one character in this place.\r\n",
      "Условия поиска имени.\r\n" +
        "* - любой набор символов в этом месте.\r\n" +
        "? - один любой символ в этом месте.",
      "Termini di ricerca del nome.\r\n" +
        "* - qualsiasi set di caratteri in questo posto.\r\n" +
        "? - qualsiasi personaggio in questo posto.",
      "Benennen Sie Suchbegriffe.\r\n" +
        "* - beliebiger Zeichensatz an dieser Stelle.\r\n" +
        "? - ein beliebiges Zeichen an diesem Ort.",
      "名称搜索词。\r\n" +
         "* - 此处的任何字符集。\r\n" +
         "? - 这个地方的任何一个角色。",
      "Términos de búsqueda de nombre. \r\n" +  // ES
        "* - cualquier conjunto de caracteres en este lugar.\r\n" +
        "? - cualquier carácter en este lugar.\r\n",
      "Termes de recherche de nom. \r\n" +  // FR
        "* - n'importe quel ensemble de caractères à cet endroit.\r\n" +
        "? - n'importe quel caractère à cet endroit.\r\n",
      "Ad arama terimleri. \r\n" +  // TR
        "* - bu yerde herhangi bir karakter kümesi.\r\n" +
        "? - bu yerde herhangi bir karakter.\r\n"};

  }
}