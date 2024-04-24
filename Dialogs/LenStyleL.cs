// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация копмонента диалогов для настройки форматирования длин и размеров
  /// </summary>
  public static class
  LenStyleL
  {
    public static readonly string[] AllowSymbols = {
      "Allow Symbols",
      "Спецсимволы",
      "Consenti simboli",
      "Symbole zulassen",
      "允许符号"};
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
        "如果你得到的是方框而不是字符，那么你必须禁用此选项或选择不同的字体。"};
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
        "通常有一个逗号集。 但在 dwg 表中需要一个点。"};
    public static readonly string[] UseFields = {
      "Use Fields",
      "Поля",
      "Usa il campo dati",
      "Verwenden Sie Felder",
      "使用字段"};
    public static readonly string[] UseFieldsTip = {
      "Use AutoCAD Fields for substitutions. Fields work only in AutoCAD. Disable it when pasting to Excel.",
      "Использовать поля AutoCAD вместо подстановки значений свойств. \r\n" +
        "Поля срабатывают только в таблицах AutoCAD.\r\n" +
        "Отключите, если планируется вставка данных в Excel или любую другую программу.",
      "Utilizzare i campi di AutoCAD|BricsCAD per le sostituzioni.\r\n" +
        "I campi funzionano solo in AutoCAD. Disabilitalo quando si incolla su Excel.",
      "Verwenden Sie AutoCAD-Felder für Ersetzungen. Felder funktionieren nur in AutoCAD. \r\n" +
        "Deaktivieren Sie es beim Einfügen in Excel.",
      "使用 AutoCAD 字段进行替换。 字段仅在 AutoCAD 中有效。 粘贴到 Excel 时禁用它。"};
    public static readonly string[] FormatTip = {
      "Enter string for control the number of decimal places and insignificant zeros.\r\n" +
        "Symbol 0 - any digit or zero. Symbol # - any digit or nothing.\r\n" +
        "Default “0.#” - interpreted like 1 decimal digit after float point if it not 0\r\n" +
        "Additional you can use fractional formats: \r\n" +
        "CU - from current drawing (Set it in Drawing utits dialog box)\r\n" +
        "AR - Architectural\r\n" +
        "EN - Engineering\r\n" +
        "FR - Fractional\r\n" +
        "After AR, EN, FR you can write precision (0-8)",
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
         "Standard „0.#“ – wird wie 1 Dezimalziffer nach dem Fließkomma interpretiert, wenn es nicht 0 ist\r\n" +
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
         "在 AR、EN、FR 之后，您可以写精度 (0-8)"};
    public static readonly string[] LenStyle = {
      "Convert numbers to string",
      "Число к строке",
      "Converti i numeri in stringa",
      "Konvertieren Sie Zahlen in Zeichenfolgen",
      "将数字转换为字符串"};
    public static readonly string[] Dot = {
      "Decimal separator",
      "Десятичный знак",
      "Punto decimale",
      "Dezimaltrennzeichen",
      "小数分隔符"};
    public static readonly string[] SizeFormat = {
      "Format for size",
      "Формат размеров",
      "Formato",
      "Format für Größe",
      "尺寸格式"};
  }
}
