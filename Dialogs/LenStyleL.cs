// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация компонента диалогов для настройки форматирования длин и размеров
  /// </summary>
  public static class
  LenStyleL
  {
    public static readonly string[] Meter = {
      "m",
      "м",
      "m",
      "m",
      "米",
      "m",
      "m",
      "m"};

    public static readonly string[] Millimeter = {
      "mm",
      "мм",
      "mm",
      "mm",
      "毫米",
      "mm",
      "mm",
      "mm"};

    public static readonly string[] Inch = {
      "in",
      "дюйм",
      "pollice",
      "zol",
      "英寸",
      "pulgada",
      "pouce",
      "inç"};

    public static readonly string[] Millimeters = {
      "Millimeters",
      "Миллиметры",
      "Millimetri",
      "Millimeter",
      "毫米",
      "Milímetros",
      "Millimètres",
      "Milimetre"};

    public static readonly string[] Inches = {
      "Inches",
      "Дюймы",
      "Pollici",
      "Zoll",
      "英寸",
      "Pulgadas",
      "Pouces",
      "İnç"};

    public static readonly string[] ArabicNumerals = {
      "Arabic Numerals",
      "Арабские цифры",
      "Numeri arabi",
      "Numeri arabi",
      "阿拉伯数字",
      "Números arábigos",
      "Chiffres arabes",
      "Arap rakamları"};

    public static readonly string[] RomanNumerals = {
      "Roman Numerals",
      "Римские цифры",
      "Numeri romani",
      "Römische Zahlen",
      "罗马数字",
      "Números romanos",
      "Chiffres romains",
      "Roma rakamları"};

    public static readonly string[] EnglishAlphabet = {
      "English Alphabet",
      "Английский алфавит",
      "Alfabeto inglese",
      "Englisches Alphabet",
      "英文字母",
      "Alfabeto inglés",
      "Alphabet anglais",
      "İngiliz alfabesi"};

    public static readonly string[] CyrillicAlphabet = {
      "Cyrillic Alphabet",
      "Кириллица",
      "Alfabeto cirillico",
      "Kyrillisches Alphabet",
      "西里尔字母/俄语字母",
      "Alfabeto cirílico",
      "Alphabet cyrillique",
      "Kiril alfabesi"};

    public static readonly string[] AllowSymbols = {
      "Allow Symbols",
      "Спецсимволы",
      "Consenti simboli",
      "Symbole zulassen",
      "允许符号",
      "Permitir símbolos",
      "Autoriser les symboles",
      "Sembollere izin ver"};

    public static readonly string[] AllowSymbolsTip = {
      "Allow the program to use special characters like ¼ ¾ ¾ in USA fractional size formats.\r\n" +
        "And after angles, prices, areas and volumes units of measure will be affixed.\r\n" +
        "Not every font contains such characters.\r\n" +
        "If you get the boxes instead of characters, then you must disable this option or choose a different font.",
      "Использовать в размерах спецсимволы, такие как ¼ ¾ ½.\r\n" +
        "А после углов, цен, площадей и объемов будут проставляться единицы измерения.\r\n" +
        "Невозможно вычислить математические выражения с такими символами.",
      "Consenti al programma di utilizzare caratteri speciali come ¼ ¾ ¾ nei formati frazionari.\r\n" +
         "E dopo gli angoli, i prezzi, le aree e i volumi verranno apposti unità di misura.\r\n" +
         "Non tutti i font contengono tali caratteri.\r\n" +
         "Se ottieni le caselle invece dei caratteri, devi disabilitare questa opzione o scegliere un carattere diverso.",
      "Erlauben Sie dem Programm, Sonderzeichen wie ¼ ¾ ¾ in Bruchformaten zu verwenden.\r\n" +
         "Und nach Winkeln, Preisen, Flächen und Volumen werden Maßeinheiten angebracht.\r\n" +
         "Nicht jede Schriftart enthält solche Zeichen.\r\n" +
         "Wenn Sie Kästchen anstelle von Zeichen erhalten, müssen Sie diese Option deaktivieren oder eine andere Schriftart auswählen.",
      "允许程序在美国小数格式中使用特殊字符，例如 ¼ ¾ ¾。\r\n" +
        "在角度、价格、面积和体积之后，将附加计量单位。\r\n" +
        "并非每种字体都包含这样的字符。\r\n" +
        "如果你得到的是方框而不是字符，那么你必须禁用此选项或选择不同的字体。",
      "Permitir que el programa use caracteres especiales como ¼ ¾ ½ en formatos fraccionarios de tamaño de EE. UU.\r\n" +
        "Y después de ángulos, precios, áreas y volúmenes se añadirán unidades de medida.\r\n" +
        "No todas las fuentes contienen tales caracteres.\r\n" +
        "Si obtiene cuadros en lugar de caracteres, debe deshabilitar esta opción o elegir una fuente diferente.",
      "Autoriser le programme à utiliser des caractères spéciaux comme ¼ ¾ ½ dans les formats fractionnaires de taille américaine.\r\n" +
        "Et après les angles, les prix, les surfaces et les volumes, des unités de mesure seront apposées.\r\n" +
        "Toutes les polices ne contiennent pas de tels caractères.\r\n" +
        "Si vous obtenez des cases au lieu de caractères, vous devez désactiver cette option ou choisir une police différente.",
      "Programın ABD kesirli boyut formatlarında ¼ ¾ ½ gibi özel karakterler kullanmasına izin verin.\r\n" +
        "Ve açılar, fiyatlar, alanlar ve hacimlerden sonra ölçü birimleri eklenecektir.\r\n" +
        "Her yazı tipi bu tür karakterleri içermez.\r\n" +
        "Karakterler yerine kutular alıyorsanız, bu seçeneği devre dışı bırakmalı veya farklı bir yazı tipi seçmelisiniz."};

    public static readonly string[] DotTip = {
      "Replace the decimal point of this symbol. You can use a comma, dot, or any letter.",
      "Заменять десятичную точку на этот символ во всех числах и во всех подстановках.\r\n" +
        "При сохранении файлов CSV и XML важно использовать такой разделитель, как у вас настроен в Windows.\r\n" +
        "А там обычно настроена запятая. Но в dwg-таблицах требуется точка.",
      "Sostituisci il punto decimale con questo carattere in tutti i numeri e in tutte le sostituzioni.\r\n" +
        "Quando si salvano file CSV e XML, è importante utilizzare il delimitatore configurato in Windows.\r\n" +
        "E di solito c'è una virgola impostata. Ma nelle tabelle dwg è richiesto un punto.",
      "Ersetzen Sie den Dezimalpunkt in allen Zahlen und bei allen Substitutionen durch dieses Zeichen.\r\n" +
        "Beim Speichern von CSV- und XML-Dateien ist es wichtig, das Trennzeichen zu verwenden, \r\n" +
        "das Sie in Windows konfiguriert haben.\r\n" +
        "Und es gibt normalerweise ein Komma gesetzt. \r\n" +
        "In DWG-Tabellen ist jedoch ein Punkt erforderlich.",
      "在所有数字和所有替换中，用此字符替换小数点。\r\n" +
        "保存 CSV 和 XML 文件时，使用您在 Windows 中配置的分隔符很重要。\r\n" +
        "通常有一个逗号集。 但在 dwg 表中需要一个点。",
      "Reemplazar el punto decimal de este símbolo. Puede usar una coma, un punto o cualquier letra.\r\n" +
        "Al guardar archivos CSV y XML, es importante usar el delimitador configurado en Windows.\r\n" +
        "Y allí generalmente está configurada una coma. Pero en las tablas dwg se requiere un punto.",
      "Remplacer le point décimal de ce symbole. Vous pouvez utiliser une virgule, un point ou n'importe quelle lettre.\r\n" +
        "Lors de l'enregistrement de fichiers CSV et XML, il est important d'utiliser le délimiteur configuré dans Windows.\r\n" +
        "Et il y a généralement une virgule définie. Mais dans les tables dwg, un point est requis.",
      "Bu sembolün ondalık noktasını değiştirin. Virgül, nokta veya herhangi bir harf kullanabilirsiniz.\r\n" +
        "CSV ve XML dosyalarını kaydederken, Windows'ta yapılandırılan ayırıcıyı kullanmak önemlidir.\r\n" +
        "Ve orada genellikle bir virgül ayarlanmıştır. Ancak dwg tablolarında bir nokta gereklidir."};

    public static readonly string[] UseFields = {
      "Use Fields",
      "Поля",
      "Usa il campo dati",
      "Verwenden Sie Felder",
      "使用字段",
      "Usar campos",
      "Utiliser les champs",
      "Alanları kullan"};

    public static readonly string[] UseFieldsTip = {
      "Use AutoCAD Fields for substitutions. Fields work only in AutoCAD. Disable it when pasting to Excel.",
      "Использовать поля AutoCAD вместо подстановки значений свойств. \r\n" +
        "Поля срабатывают только в таблицах AutoCAD.\r\n" +
        "Отключите, если планируется вставка данных в Excel или любую другую программу.",
      "Utilizzare i campi di AutoCAD|BricsCAD per le sostituzioni.\r\n" +
        "I campi funzionano solo in AutoCAD. Disabilitalo quando si incolla su Excel.",
      "Verwenden Sie AutoCAD-Felder für Ersetzungen. Felder funktionieren nur in AutoCAD. \r\n" +
        "Deaktivieren Sie es beim Einfügen in Excel.",
      "使用 AutoCAD 字段进行替换。 字段仅在 AutoCAD 中有效。 粘贴到 Excel 时禁用它。",
      "Usar campos de AutoCAD para sustituciones. Los campos funcionan solo en AutoCAD. Deshabilítelo al pegar en Excel.",
      "Utiliser les champs AutoCAD pour les substitutions. Les champs fonctionnent uniquement dans AutoCAD. Désactivez-le lors du collage dans Excel.",
      "İkameler için AutoCAD Alanlarını kullanın. Alanlar yalnızca AutoCAD'de çalışır. Excel'e yapıştırırken devre dışı bırakın."};

    public static readonly string[] FormatTip = {
      "Enter string for control the number of decimal places and insignificant zeros.\r\n" +
        "Symbol 0 - any digit or zero. Symbol # - any digit or nothing.\r\n" +
        "Default '0.#' - interpreted like 1 decimal digit after float point if it not 0\r\n" +
        "Additional you can use fractional formats: \r\n" +
        "CU - from current drawing (Set it in Drawing units dialog box)\r\n" +
        "AR - Architectural\r\n" +
        "EN - Engineering\r\n" +
        "FR - Fractional\r\n" +
        "After AR, EN, FR you can write precision (from 0 to 8)",
      "Только для размеров. \r\n" +
        "Можно переопределять в подстановках.\r\n" +
        "Задает сколько знаков после запятой писать и писать ли незначащие нули.\r\n" +
        "В формате используйте символы 0 и #. 0 - это цифра или 0, # - это цифра или ничего. \r\n" +
        "Например, цифра 1.111111 отформатированная 00.00 выведется как 01.11.\r\n" +
        "А отформатированная 0.#### выведется как 1.1111. \r\n" +
        "А цифра 1.2 отформатированная 0.#### выведется как 1.2. \r\n" +
        "Есть специальные форматы: \r\n" +
        "CU - как настроены единицы в текущем чертеже (через диалог Единицы чертежа)\r\n" +
        "AR, EN, FR - американские дробные форматы",
      "Formattare la profondità delle cifre e altre cifre.\r\n" +
        "Quante cifre decimali per scrivere e scrivere zeri insignificanti.\r\n" +
        "Simbolo 0 - qualsiasi cifra o pari a zero .\r\n" +
        "Simbolo # - qualsiasi cifra o nulla. \r\n" +
        "Predefinito '0.#' - interpretato come 1 cifra decimale dopo il punto flottante, se non 0.\r\n" +
        "In agiunta è possibile utilizzare i seguenti formati frazionari: \r\n" +
        "CU - da disegno corrente\r\n" +
        "AR - Architectural\r\n" +
        "IT - Ingegneria\r\n" +
        "FR - frazionale\r\n" +
        "Dopo AR, EN, FR è possibile scrivere precisione (0-8) ",
      "Geben Sie eine Zeichenfolge ein, um die Anzahl der Dezimalstellen und unbedeutenden Nullen zu steuern.\r\n" +
         "Symbol 0 - beliebige Ziffer oder Null. Symbol # - beliebige Ziffer oder nichts.\r\n" +
         "Standard '0.#' – wird wie 1 Dezimalziffer nach dem Fließkomma interpretiert, wenn es nicht 0 ist\r\n" +
         "Zusätzlich können Sie Bruchformate verwenden: \r\n" +
         "CU - aus aktueller Zeichnung (Im Dialogfeld Zeichnungskanäle festlegen)\r\n" +
         "AR - Architektur\r\n" +
         "EN - Engineering\r\n" +
         "FR - Bruchzahl\r\n" +
         "Nach AR, EN, FR können Sie Präzision schreiben (0-8)",
      "输入字符串以控制小数位数和消零。\r\n" +
         "符号 0 - 任何数字或零。符号 # - 任何数字或无。\r\n" +
         "默认 '0.#' - 如果不是 0，则解释为浮点数后的 1 个十进制数字\r\n" +
         "您还可以使用小数格式：\r\n" +
         "CU - 来自当前图纸（在图纸 utits 对话框中设置）\r\n" +
         "AR - 建筑\r\n" +
         "EN - 工程\r\n" +
         "FR - 分数\r\n" +
         "在 AR、EN、FR 之后，您可以写精度 (0-8)",
      "Ingrese una cadena para controlar el número de decimales y ceros insignificantes.\r\n" +
        "Símbolo 0 - cualquier dígito o cero. Símbolo # - cualquier dígito o nada.\r\n" +
        "Predeterminado '0.#' - interpretado como 1 dígito decimal después del punto flotante si no es 0\r\n" +
        "Además, puede usar formatos fraccionarios: \r\n" +
        "CU - del dibujo actual (configúrelo en el cuadro de diálogo Unidades de dibujo)\r\n" +
        "AR - Arquitectónico\r\n" +
        "EN - Ingeniería\r\n" +
        "FR - Fraccional\r\n" +
        "Después de AR, EN, FR puede escribir precisión (de 0 a 8)",
      "Entrez une chaîne pour contrôler le nombre de décimales et de zéros non significatifs.\r\n" +
        "Symbole 0 - n'importe quel chiffre ou zéro. Symbole # - n'importe quel chiffre ou rien.\r\n" +
        "Par défaut '0.#' - interprété comme 1 chiffre décimal après la virgule flottante s'il n'est pas 0\r\n" +
        "De plus, vous pouvez utiliser des formats fractionnaires : \r\n" +
        "CU - du dessin actuel (définissez-le dans la boîte de dialogue Unités de dessin)\r\n" +
        "AR - Architectural\r\n" +
        "EN - Ingénierie\r\n" +
        "FR - Fractionnaire\r\n" +
        "Après AR, EN, FR, vous pouvez écrire la précision (de 0 à 8)",
      "Ondalık basamak sayısını ve önemsiz sıfırları kontrol etmek için dize girin.\r\n" +
        "Sembol 0 - herhangi bir rakam veya sıfır. Sembol # - herhangi bir rakam veya hiçbir şey.\r\n" +
        "Varsayılan '0.#' - 0 değilse kayan noktadan sonra 1 ondalık basamak olarak yorumlanır\r\n" +
        "Ek olarak kesirli formatlar kullanabilirsiniz: \r\n" +
        "CU - mevcut çizimden (Çizim birimleri iletişim kutusunda ayarlayın)\r\n" +
        "AR - Mimari\r\n" +
        "EN - Mühendislik\r\n" +
        "FR - Kesirli\r\n" +
        "AR, EN, FR'den sonra hassasiyet yazabilirsiniz (0'dan 8'e)"};

    public static readonly string[] LenStyle = {
      "Convert number to string",
      "Число к строке",
      "Converti i numeri in stringa",
      "Konvertieren Sie Zahlen in Zeichenfolgen",
      "将数字转换为字符串",
      "Convertir número a cadena",
      "Convertir le nombre en chaîne",
      "Sayıyı dizeye dönüştür"};

    public static readonly string[] Dot = {
      "Decimal separator",
      "Десятичный знак",
      "Punto decimale",
      "Dezimaltrennzeichen",
      "小数分隔符",
      "Separador decimal",
      "Séparateur décimal",
      "Ondalık ayırıcı"};

    public static readonly string[] SizeFormat = {
      "Format for size",
      "Формат размеров",
      "Formato",
      "Format für Größe",
      "尺寸格式",
      "Formato para tamaño",
      "Format pour la taille",
      "Boyut formatı"};
  }
}