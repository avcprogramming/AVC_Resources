// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

using System.Collections.Generic;

namespace AVC
{
  public static class
  PageNoL
  {
    public static readonly HashSet<string> PageNoAttributes = new() {
      "SHEET", "SHEETNO", "PAGE",
      "ЛИСТ", "PAGENO","ЛИСТНОМЕР",
      "PAGINA", "FOGLIO", "NUMERODIFOGLIO",
      "SEITE", "LISTE", "BLATTNUMMER",
      "页", "页码" };
    public static readonly HashSet<string> PageCountAttributes = new() {
      "SHEETCOUNT","PAGECOUNT","PAGES","OF",
      "КОЛИЧЕСТВОЛИСТОВ","ЛИСТОВ","ИЗ",
      "SCHEDADILAVORO","PAGINACOUNT","SCHEDE","DALLA",
      "BLATTZÄHLUNG","SEITEN","VON",
      "页数"};
    public static readonly HashSet<string> PageNameAttributes = new() {
      "TITLE", "SHEETNAME", "SHEETTITLE", "PAGENAME", "DRAWINGNAME", "NAME",
      "ЗАГОЛОВОК", "НАИМЕНОВАНИЕЛИСТА", "ЧЕРТЕЖ", "НАИМЕНОВАНИЕ", "НАЗВАНИЕ",
      "TESTATA", "NOMEDELFOGLIO", "NOMEDELLOSCHEDA", "NOME",
      "TITEL", "BLATTNAME", "BLATTTITEL", "SEITENNAME", "ZEICHNUNGSNAME",
      "标题", "姓名" };

    public static readonly string[] Numbering ={
      "Layout numbering",
      "Нумерация листов",
      "Numerazione del layout",
      "Layoutnummerierung",
      "布局编号"};
    public static readonly string[] NoBlock = {
      "Layout {0} hasn't block for numbering" ,
      "Лист {0} не имеет блока для нумерации",
      "Layout {0} non ha blocco per la numerazione",
      "Layout {0} hat keinen Block für die Nummerierung",
      "布局 {0} 没有阻止编号"};
    public static readonly string[] NoLayout ={
      "None of the layout has block for numbering. The program will look for the blocks in model space.",
      "Ни один лист (layout) не имеет блоков для нумерации. Программа будет искать блоки в пространстве модели.",
      "Nessuno dei layout ha blocco per la numerazione. Il programma cercherà i blocchi nello spazio modello.",
      "Keines der Layouts hat einen Block zur Nummerierung. Das Programm sucht nach den Blöcken im Modellraum.",
      "所有布局都没有编号块。 该程序将在模型空间中寻找块。"};
    public static readonly string[] Copied = {
      "Table of contents copied to clipboard",
      "Оглавление скопировано в буфер",
      "Sommario copiato negli appunti",
      "Inhaltsverzeichnis in die Zwischenablage kopiert",
      "目录已复制到剪贴板" };
    public static readonly string[] NoModelBlock = {
      "None of model-space block has attribute for numbering",
      "Ни один блок из пространства модели не имеет атрибутов для нумерации",
      "Nessuno dei blocchi modello-spazio ha l'attributo per la numerazione",
      "Keiner der Model-Space-Block hat Attribut für die Nummerierung",
      "模型空间块都没有编号属性" };
    public static readonly string[] Content = {
      "Table of contents\n",
      "Содержание\n",
      "Sommario\n",
      "Inhaltsverzeichnis\n",
      "目录\n" };
    public static readonly string[] PageName = {
      "Page\tName\n",
      "Лист\tНаименование\n",
      "Pagina\tNome\n",
      "Seite\tName\n",
      "页面\t名称\n" };
    public static readonly string[] ClipboardErr = {
      "Error while working with the clipboard",
      "Ошибка при работе с буфером обмена",
      "Errore durante il lavoro con gli appunti",
      "Fehler beim Arbeiten mit der Zwischenablage",
      "使用剪贴板时出错" };

    // ================================ Settings Dialog ===================================================

    public static readonly string[] StartTip = {
      "Number for first page",
      "Номер для первой страницы",
      "Numero primo foglio",
      "Nummer für die erste Seite",
      "第一页的编号" };
    public static readonly string[] PageCountText = {
      "Count attribute",
      "Атрибут количества",
      "Attributo quantità",
      "Attribut zählen",
      "页数属性" };
    public static readonly string[] PageNameText = {
      "Title attribute",
      "Атрибут названия",
      "Attributo titolo",
      "Titel Attribut",
      "标题属性" };
    public static readonly string[] NumberText = {
      "Number attribute",
      "Атрибут номера",
      "Attributo numero",
      "Attribut Seitenzahl",
      "页码属性" };
    public static readonly string[] StartText = {
      "Start from",
      "Старт с",
      "Inizia da",
      "Beginne von",
      "从...开始" };
    public static readonly string[] NumberTip = {
      "Tag of attribute with number of sheet.\r\n" +
        "Set space for using default tags\r\n" +
        "(PageNo or SheetNo or Page or Sheet)",
      "Тег атрибута, в который будет записан номер листа.\r\n" +
        "Оставьте поле пустым, чтоб использовать атрибут по-умолчанию \r\n" +
        "(Лист или ЛистНомер)",
      "Un tag di attributo su cui verrà scritto il numero del foglio.\r\n" +
        "Lascia vuoto per utilizzare l'attributo predefinito\r\n" +
        "(PAGINA o FOGLIO o NUMERODIFOGLIO)",
      "Tag des Attributs mit Blattnummer.\r\n" +
         "Platz für die Verwendung von Standard-Tags festlegen\r\n" +
         "(SEITE oder LISTE oder BLATTNUMMER)",
      "带有页数的属性标签。\r\n" +
         "设置使用默认标签的空间\r\n" +
         "PageNo 或 Page 或 页 或 页码）" };
    public static readonly string[] PageCountTip = {
      "Tag of attribute for sheet count.\r\n" +
        "Set space for using default tags\r\n" +
        "(PageCount or SheetCount or Pages or From)",
      "Тег атрибута, в который будет записано общее количество листов.\r\n" +
        "Оставьте поле пустым, чтоб использовать атрибут по-умолчанию\r\n" +
        "(Листов или КоличествоЛистов или Из)",
      "Un tag di attributo su cui verrà scritto il numero totale di fogli.\r\n" +
        "Lascia vuoto per utilizzare l'attributo predefinito\r\n" +
        "(SCHEDADILAVORO o PAGINACOUNT o SCHEDE o DALLA)",
      "Tag des Attributs für die Blattanzahl.\r\n" +
         "Platz für die Verwendung von Standard-Tags festlegen\r\n" +
         "(BLATTZÄHLUNG oder SEITEN oder VON)",
      "页数属性标签。\r\n" +
         "设置使用默认标签的空间\r\n" +
         "(PageCount 或 页数)" };
    public static readonly string[] PageNameTip = {
      "Tag of attribute with sheet name for table of contents.\r\n" +
        "Set space for using default tags\r\n" +
        "(Title or Name or SheetName or SheetTitle or DrawingName)",
      "Тег атрибута, из которого будет извлечено название чертежа для оглавления.\r\n" +
        "Оставьте поле пустым, чтоб использовать атрибут по-умолчанию\r\n" +
        "(Чертеж или НаименованиеЛиста или Заголовок или Наименование или Название)",
      "Tag di attributo da cui estrarre il titolo del disegno per il sommario.\r\n" +
        "Lascia vuoto per utilizzare l'attributo predefinito\r\n" +
        "(TESTATA o NOMEDELFOGLIO o NOMEDELLOSCHEDA o NOME)",
      "Tag des Attributs mit dem Blattnamen für das Inhaltsverzeichnis.\r\n" +
         "Platz für die Verwendung von Standard-Tags festlegen \r\n" +
        "(TITEL oder BLATTNAME oder BLATTTITEL oder SEITENNAME oder ZEICHNUNGSNAME)",
      "带有目录工作表名称的属性标记。\r\n" +
        "设置使用默认标签的空间\r\n" +
        "(Title or Name or 标题 or 姓名)" };

    public static readonly string[] PasteTablePartText = {
      "Table of contents settings",
      "Настройки таблицы оглавления",
      "Impostazioni del sommario",
      "Inhaltsverzeichnis Einstellungen",
      "目录设置" };
    public static readonly string[] StartNoQuery = {
      "Enter the number for the first page",
      "Введите номер для первой страницы",
      "Inserisci il numero per la prima pagina",
      "Geben Sie die Nummer für die erste Seite ein",
      "输入第一页的编号" };
    public static string[] StartQuery = {
      "Request number",
      "Запрашивать номер",
      "Richiedi il numero",
      "Fordern Sie eine Nummer an.",
      "请求第一页的编号" };
    public static string[] StartQueryTip = {
      "Request the starting number each time the command is called. \r\n" +
        "Useful if you always have different starting numbers.",
      "При каждом вызове команды запрашивать стартовый номер. \r\n" +
        "Полезно, если у вас всегда разные стартовые номера.",
      "Richiedi il numero iniziale ogni volta che viene chiamato il comando. \r\n" +
        "Utile se hai sempre numeri iniziali diversi.",
      "Fordern Sie die Startnummer jedes Mal an, wenn der Befehl aufgerufen wird. \r\n" +
        "Nützlich, wenn Sie immer unterschiedliche Startnummern haben.",
      "每次调用命令时请求起始编号。 如果您总是有不同的起始编号，这很有用。" };
  }
}
