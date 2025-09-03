// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Unmerge

namespace AVC
{
  /// <summary>
  /// Локализация методов для работы с текстами и другими аннотациями
  /// </summary>
  public static class
  AnnotateL
  {
    // ===================================  布局 = layout ====================================================================
    public static readonly string[] NoLayoutErr = {
      "Error layout inserting: template '{0}' does not contain the layout '{1}'",
      "Ошибка вставки листа: шаблон '{0}' не содержит листа '{1}'",
      "Inserimento del layout di errore: il modello '{0}' non contiene il layout '{1}'",
      "Fehler beim Einfügen des Layouts: Die Vorlage '{0}' enthält nicht das Layout '{1}'",
      "插入布局时出错：模板 '{0}' 不包含布局“{1}”"};
    public static readonly string[] LayoutDisplayErr = {
      "Failed to display layout {0}",
      "Не удалось отобразить лист {0}",
      "Impossibile visualizzare il layout {0}",
      "Layout konnte nicht angezeigt werden {0}",
      "未能显示布局 {0}"};
    public static readonly string[] LayoutAdded = {
      "  Added layout '{0}'",
      "  Добавлен лист '{0}'",
      "  Aggiunto layout '{0}'",
      "  Layout hinzugefügt '{0}'",
      "  添加了布局 '{0}'"};
    public static readonly string[] LayoutOrder = {
      "Set tab order for new layout {0}",
      "Назначаем новый лист на позицию {0}",
      "Imposta l'ordine di tabulazione per il nuovo layout {0}",
      "Tabulatorreihenfolge für neues Layout festlegen {0}",
      "将新工作表分配到位置 {0}"};
    public static readonly string[] LayoutTooMany = {
      "Too many layouts. Add more is not possible.",
      "Слишком много листов. Добавлять больше невозможно",
      "Troppi fogli. Aggiungere altro non è possibile",
      "Zu viele Blätter. Mehr hinzufügen ist nicht möglich",
      "床单太多。 无法添加更多"};
    public static readonly string[] TemplateErr = {
      "The template is damaged. \r\n" +
        "Open file {0} and troubleshoot with _Audit command",
      "Шаблон поврежден. \r\n" +
        "Откройте файл {0} и устраните сбои с помощью команды _Audit",
      "Il modello è danneggiato. \r\n" +
        "Apri il file {0} e risolvi i problemi con il comando _Audit",
      "Die Schablone ist beschädigt. \r\n" +
        "Öffnen Sie Datei {0} und beheben Sie Fehler mit dem Befehl _Audit",
      "模板已损坏。\r\n" +
        "打开文件 {0} 并使用 _Audit 命令进行故障排除"};

    // ============================= Multi Leader =================================================

    public static readonly string[] LeaderText = {
      "Leader text",
      "Текст выноски",
      "Testo",
      "Text",
      "标注文字"};

    // =================================== Text ==================================================
    public static readonly string[] TextStyleErr = {
      "Text style '{0}' not exist. Will use current style",
      "Такого стиля нет '{0}'. Будет использован текущий стиль",
      "Lo stile di testo '{0}' non esiste. Userò lo stile attuale",
      "Der Textstil '{0}' ist nicht vorhanden. Verwendet den aktuellen Stil",
      "文本样式“{0}”不存在。 将使用当前样式"};
    public static string[] UpdatedTexts =  {
      "Updated {0} texts.",
      "Обновлено {0} текстов.",
      "Aggiornato {0} testo.",
      "{0} Texte wurden aktualisiert",
      "更新了 {0} 个文本。"};
    public static string[] NoTextInView = {
      "No single non-annotative MText was found in the viewport.",
      "Во вьюпорте не найдено ни одного неаннотативного мультитекста.",
      "Viewport non corrisponde alcun MTesto neannotativnogo.",
      "Im Ansichtsfenster wurde kein einziger nicht annotativer MText gefunden.",
      "在视口中找不到单个非注释性多行文字。"};

    // ===================================== Tables ==============================================
    public static readonly string[] CellStyleErr = {
      "Could not assign style to cell",
      "Не получилось назначить стиль ячейке",
      "Non è stato possibile assegnare uno stile a una cella",
      "Der Stil konnte der Zelle nicht zugewiesen werden",
      "未能指定单元格样式"};
    public static readonly string[] CellUnmergeErr = {
      "Could not unmerge cells",
      "Не возможно разъединить ячейки",
      "Impossibile separare le celle",
      "Zellen konnten nicht getrennt werden",
      "无法取消合并单元格" };
    public static readonly string[] TableWriteErr = {
      "Can't open Table for write",
      "Не удалось открыть таблицу для записи",
      "Impossibile aprire la tabella per la scrittura",
      "Tabelle zum Schreiben kann nicht geöffnet werden",
      "无法打开表进行写入" };
    public static readonly string[] TableLinked = {
      "The table is linked to Excel. Recording is not possible.",
      "Таблица подключена к Excel. Запись невозможна.",
      "La tabella è collegata a Excel. La registrazione non è possibile.",
      "Die Tabelle ist mit Excel verknüpft. Aufnahme ist nicht möglich.",
      "该表已连接到 Excel。 无法录制。" };
    public static readonly string[] TableStyleErr = {
      "The table does not contain the necessary standard cell styles (TITLE, HEADER, DATA)",
      "Таблица не содержит необходимых стандартных стилей ячеек (TITLE, HEADER, DATA)",
      "La tabella non contiene gli stili di cella standard necessari (TITLE, HEADER, DATA)",
      "Die Tabelle enthält nicht die erforderlichen Standardzellstile (TITLE, HEADER, DATA).",
      "该表不包含所需的标准单元格样式（TITLE、HEADER、DATA）" };
    public static readonly string[] TableStyleNotExists = {
      "Table style {0} does not exist. The current table style will be used.",
      "Не существует стиль таблиц {0}. Будет использован текущий стиль таблиц.",
      "Lo stile tabella {0} non esiste. Verrà utilizzato lo stile di tabella corrente.",
      "Tabellenstil {0} existiert nicht. Der aktuelle Tabellenstil wird verwendet.",
      "表格样式 {0} 不存在。 将使用当前表格样式。" };
    public static readonly string[] SelectTable = {
      "Select Table", 
      "Выберите таблицу", 
      "Seleziona tabella", 
      "Wählen Sie Tabelle" ,
      "选择表"};
    public static readonly string[] EraseData = {
      ". All data will be overwritten",
      ". Все данные будут затерты",
      ". Tutti i dati verranno sovrascritti",
      ". Alle Daten werden überschrieben",
      ". 所有数据将被覆盖" };
    public static readonly string[] NeedTable = {
      "\nNeed selected a Table!\n",
      "\nНужно выбрать таблицу!\n",
      "\nHai selezionato una tavola!\n",
      "\nNeed ausgewählt eine Tabelle!\n",
      "\n您需要选择一张桌子！\n" };
    public static readonly string[] TableInsertionPoint =  {
      "Specify the insertion point of the new table",
      "Укажите точку вставки новой таблицы",
      "Specificare il punto di inserimento della nuova tabella",
      "Geben Sie die Einfügemarke der neuen Tabelle an",
      "指定新表的插入点" };
    public static readonly string[] TableCreateErr = {
       "Could not create new table. Error: {0}",
       "Не удалось создать новую таблицу. Ошибка: {0}",
       "Impossibile creare una nuova tabella. Errore: {0}",
       "Konnte keine neue Tabelle erstellen. Fehler: {0}",
       "创建新表失败。 错误：{0}" };
    public static readonly string[] NoFreeSpace = {
       "There is no free space on the sheet even for {0} rows of the table",
       "На листе нет свободного места даже для {0} строк таблицы",
       "Non c'è spazio libero sul foglio anche per {0} righe del tavolo",
       "Es gibt keinen freien Platz auf dem Blatt auch für {0} Zeilen des Tisches",
       "即使表格的 {0} 行，工作表上也没有可用空间" };
    public static readonly string[] TooShortTable = {
       "The table will not be divided into parts, since it has less than 4 rows.",
       "Таблица не будет разделена на части, так как в ней меньше 4х строк.",
       "La tabella non verrà divisa in parti poiché ha meno di 4 righe.",
       "Die Tabelle wird nicht in Teile geteilt, da sie weniger als 4 Zeilen hat.",
       "该表不会被分成多个部分，因为它的行数少于 4 行。" };

    // ============================== Viewport ================================================
    public static string[] NeedPaper = {
      "The command works only in paper space",
      "Необходимо, чтобы текущим пространством был лист",
      "Comando funziona solo nello spazio del paper",
      "Es ist notwendig, dass der aktuelle Platz ein Blatt ist.",
      "要求当前空间为工作表"};
    public static string[] NoViewport = {
      "No viewport found",
      "Не найдено ни одного видового экрана",
      "Non ci sono risultati viewport",
      "Kein Ansichtsfenster gefunden",
      "未找到视口"};
    public static string[] ViewportSelect = {
      "Select viewport",
      "Выберите Видовой экран",
      "Selezionare viewport",
      "Kein Ansichtsfenster gefunden",
      "选择视口"};
    public static string[] NeedViewport = {
      "\nMust select viewport\n",
      "\nНеобходимо выбрать видовой экран\n",
      "\nDeve selezionare viewport\n",
      "\nMuss Ansichtsfenster auswählen\n",
      "\n必须选择视口\n"};
    public static string[] ViewportNotSelected ={
      "\nThe viewport is not selected. The work of the command was interrupted by the user.",
      "\nНе выбран видовой экран. Работа команды прервана пользователем.",
      "\nNon selezionato viewport. Il lavoro di squadra è interrotta dall'utente.",
      "\nDas Ansichtsfenster ist nicht ausgewählt. Die Arbeit des Befehls wurde vom Benutzer unterbrochen.",
      "\n未选择视口。 该命令的工作被用户中断。"};
    public static string[] CropErr ={
      "Error in the object that defines the boundaries of the viewport.",
      "Ошибка в объекте задающем границы вьюпорта.",
      "Errore nell'oggetto che definisce i confini della finestra.",
      "Fehler in dem Objekt, das die Grenzen des Ansichtsfensters definiert.",
      "定义视口边界的对象中的错误。"};
    public static string[] PerspectiveWarning = {
      "Perspective viewports not supported",
      "Перспективные видовые экраны не поддерживаются",
      "Viewport prospettiche non supportate",
      "Perspektivische Ansichtsfenster werden nicht unterstützt",
      "不支持透视视口"};
    public static readonly string[] TileModeWarning ={
      "The placement of annotations in the model space is not provided",
      "Простановка аннотаций в пространстве модели не предусмотрена",
      "Il posizionamento delle annotazioni nello spazio modello non è previsto",
      "Die Platzierung von Anmerkungen im Modellbereich ist nicht vorgesehen",
      "未提供模型空间中注释的放置"};
  }
}
