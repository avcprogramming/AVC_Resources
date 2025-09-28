// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Plugin Deselect

namespace AVC
{
  /// <summary>
  /// Локализация сообщений командной строки AutoCAD, типовые сообщения
  /// </summary>
  public static class
  CmdLineL
  {
    /// <summary>
    /// Локализованная строка ByLayer (с учетом языка, предпочитаемого пользователем). 
    /// Используем только BricsCAD, так как в AutoCAD есть  Utilities.GetReservedString(ReservedStringEnumType.ByLayer, true)
    /// </summary>
    public static readonly string[] ByLayer = {
      "ByLayer",
      "ПоСлою",
      "DaLayer",
      "VonLayer",
      "ByLayer" };

    /// <summary>
    /// Локализованная строка ByBlock (с учетом языка, предпочитаемого пользователем)
    /// Используем только BricsCAD, так как в AutoCAD есть  Utilities.GetReservedString
    /// </summary>
    public static readonly string[] ByBlock = {
      "ByBlock",
      "ПоБлоку",
      "DaBlocco",
      "VonBlock",
      "ByBlock" };

    public static readonly string[]
      NoAvailable = {
      "n.a.", "н.д.", "n.d.", "n.v.", "不可用" };
    public static readonly string[]
      DefFileName = {
      "Drawing",
      "Чертеж",
      "Disegno",
      "Zeichnung",
      "Drawing" };
    public static readonly string[]
    Deselect = {
      "\n  Remove objects from selection. ",
      "\n  Удалите объекты из выделения. ",
      "\n  Annullare la scelta. ",
      "\n  Entfernen Sie die Objekte von den markierten. ",
      "\n  从选择中删除对象。"};
    public static readonly string[]
    Select = {
        "\n  Select objects to process. ",
        "\n  Выберите объекты для обработки.  ",
        "\n  Seleziona gli oggetti da elaborare. ",
        "\n  Wählen Sie die zu verarbeitenden Objekte aus. ",
        "\n  选择要处理的对象。 "        };
    public static readonly string[]
    Selected = {
      "  Selected: ",
      "  Выбрано: ",
      "  Selezionato: ",
      "  Ausgewählt: ",
      "  已选择： " };
    public static readonly string[]
    WillBeProcessed = {
      "  Objects will be processed: {0}",
      "  Будет обработано объектов: {0}",
      "  Verranno elaborati i seguenti oggetti: {0}",
      "  Die folgenden Objekte werden verarbeitet: {0}",
      "  将处理以下对象：{0}" };
    public static readonly string[]
    TinkerWith = {
      ". There is something to tinker with...",
      ". Есть над чем потрудиться...",
      ". C'è qualcosa con cui armeggiare...",
      ". Es gibt etwas zu basteln...",
      ". 有事要做..."};
    public static readonly string[]
    NoSelected = {
      "  Nothing selected or all objects inappropriate.",
      "  Ничего не выбрано или все объекты неподходящие.",
      "  Niente di selezionato o tutti gli oggetti inappropriati.",
      "  Nichts ist ausgewählt oder alle Objekte sind ungeeignet.",
      "  未选择任何内容或所有对象都不合适。"};
    public static readonly string[]
    NoViewportSelected = {
      "  No viewport selected",
      "  Не выбран ни один видовой экран",
      "  Nessuna viewport selezionata",
      "  Kein Viewport ausgewählt",
      "  未选择视口"};
    public static readonly string[]
    ErrSolids = {
      "Failing solids: {0}",
      "Сбойных солидов: {0}",
      "Solidi guasti: {0}",
      "Fehlende Volumenkörper: {0}",
      "无法加工的零件数量： {0}"};
    public static readonly string[]
    ErrorCount = {
      "FAILURE: {0}",
      "СБОЕВ: {0}",
      "FALLIMENTO: {0}",
      "VERSAGEN: {0}",
      "失败： {0}"};
    public static readonly string[]
    ModelDoc = {
      "ModelDoc(ViewBase) views not supported",
      "Виды ModelDoc(ВидБаз) не поддерживаются",
      "ModelDoc(ViewBase) visualizzazioni non supportate.",
      "ModelDoc(ViewBase)-Ansichten werden nicht unterstützt.",
      "不支持 ModelDoc(ViewBase) 视图"};
    public static readonly string[]
    FormatErr = {
      "Format is not valid",
      "Неправильный формат",
      "Formato non valido",
      "Ungültiges Format" ,
      "格式无效"};
    public static readonly string[]
    NoTemplate = {
      "No dwt-template",
      "Не задан dwt-шаблон",
      "Non utilizzare il modello-DWT",
      "Keine DWT-Vorlage",
      "未设置绘图 dwt 模板。"};
    public static readonly string[]
    TemplateNoFound = {
      "The template file {0} was not found, or the path was specified incorrectly.",
      "Файл шаблона {0} не найден, либо неверно указан путь.",
      "Il file modello {0} non è stato trovato oppure il percorso è stato specificato in modo errato.",
      "Die Vorlagendatei {0} wurde nicht gefunden oder der Pfad wurde falsch angegeben.",
      "未找到模板文件 {0}，或者路径指定不正确。"};
    public static readonly string[]
    PressESC = {
      "Press ESC to complete",
      "Нажмите ESC для завершения",
      "Premere ESC per completare",
      "Drücken Sie ESC, um den Vorgang abzuschließen",
      "按 ESC 退出。"};
    public static readonly string[]
    StyleUsed = {
      "  Style will be used: {0}",
      "  Будет использован стиль: {0}",
      "  Stile sarà usato: {0}",
      "  Der Stil wird verwendet: {0}",
      "  将使用的样式：{0}"};
    public static readonly string[]
    PaperSpaceOnlyCommand = {
      "This command works only in PaperSpace.",
      "Эта команда работает только в пространстве листа.",
      "Questo comando funziona solo nello spazio carta (PaperSpace).",
      "Dieser Befehl funktioniert nur im Papierbereich (PaperSpace).",
      "此命令仅在图纸空间中有效。"};
    public static readonly string[]
    LockedLayer = {
      "Locked layer object selected",
      "Выбран объект с заблокированного слоя",
      "Oggetto layer bloccato selezionato",
      "Gesperrtes Ebenenobjekt ausgewählt",
      "锁定层中的对象被选中。"};
    public static readonly string[]
    CreateLogErr =     {
      "To write errors to the Windows event log, you need to run the program with elevated privileges once (as Administrator)",
      "Чтоб записывать ошибки в журнал событий Windows требуется один раз запустить программу с повышенными привилегиями (от имени Администратора)",
      "Per scrivere errori nel registro eventi di Windows, è necessario eseguire il programma con privilegi elevati una volta (come Amministratore)",
      "Um Fehler in das Windows-Ereignisprotokoll zu schreiben, müssen Sie das Programm mit erhöhten Berechtigungen einmal ausführen (als Administrator).",
      "要将错误写入 Windows 事件日志，您需要以提升的权限运行程序一次（以管理员身份）"};
    public static readonly string[]
    MessageOptions = {
      "Options for A>V>C> plug-ins messages",
      "Настройка вывода сообщений от плагинов A>V>C>",
      "Opzioni per A>V>C> Plugin messaggi",
      "Optionen für A>V>C> Plug-ins-Meldungen",
      "A>V>C> 插件消息的选项"};
    public static readonly string[]
    SaveMessages = {
      "Save info-messages to Windows events log (Admin rights required). Not recommended",
      "Сохранять информационные сообщения программ A>V>C> в журнале событий Windows (не рекомендуется)",
      "Salva info-messaggi di registro eventi di windows (Diritti di amministratore richiesti. Non raccomandato)",
      "Speichern von Informationsnachrichten der Programme A>V>C> im Windows-Ereignisprotokoll (nicht empfohlen)",
      "将信息消息保存到 Windows 事件日志（需要管理员权限) 不推荐"};
    public static readonly string[]
    ShowWarnings = {
      "Show warning-messages like message window (Recommended)",
      "Выводить предупреждения программ A>V>C> на экране отдельным окном (рекомендуется включить)",
      "Mostra messaggi di Avvertimento (Raccomandato)",
      "Warnungen der Programme A>V>C> in einem separaten Fenster anzeigen (Aktivierung wird empfohlen)",
      "显示警告消息，如消息窗口（推荐）"};
    public static readonly string[]
    ShowError = {
      "Show error-messages like message window (Recommended)",
      "Выводить ошибки программ A>V>C> на экране отдельным окном (рекомендуется включить)",
      "Visualizza gli errori di programma A>V>C> sullo schermo in una finestra separata. (Raccomandato)",
      "Anzeige der Programme A>V>C> in einem separaten Fenster anzeigen (Aktivierung wird empfohlen)",
      "显示错误消息，如消息窗口（推荐）"};
    public static readonly string[]
    SendError = {
      "Send error messages to programmer by e-mail (Recommended)",
      "Отправлять ошибки программ A>V>C> по почте разработчику (рекомендуется включить)",
      "Invia messaggi di errore al programmatore via e-mail (Raccomandato)",
      "Programmfehler senden A>V>C> per E-Mail an den Entwickler (Aktivierung wird empfohlen)",
      "显示错误消息，如消息窗口（推荐）通过电子邮件向程序员发送错误消息（推荐）"};
    public static readonly string[]
    LoadedPlugin = {
      "Plugin  '{0}' V{1}  loaded. ",
      "Плагин '{0}' V{1}  загружен. ",
      "Plugin  '{0}' V{1}  caricato. ",
      "Plugin  '{0}' V{1}  geladen. ",
      "插件“{0}”已加载。 运行版本号 {1}"};
    public static readonly string[]
    SelectFirstPoint = {
      "Select first point on plane",
      "Укажите первую точку плоскости" ,
      "Selezionare primo punto sul piano",
      "Wählen Sie den ersten Punkt der Ebene",
      "选择平面上的第一个点。"};
    public static readonly string[]
    SelectSecondPoint = {
      "Select second point on plane",
      "Укажите вторую точку плоскости",
      "Selezionare secondo punto sul piano",
      "Wählen Sie den zweiten Punkt der Ebene.",
      "选择平面上的第二个点"};
    public static readonly string[]
    SelectThirdPoint = {
      "Select third point on plane",
      "Укажите третью точку плоскости",
      "Selezionare terzo punto sul piano",
      "Wählen Sie den dritten Punkt der Ebene.",
      "选择平面上的第三个点"};
    public static string[] 
    SelectFile = {
      "Select drawing",
      "Выберите чертеж",
      "Seleziona il disegno",
      "Zeichnung auswählen",
      "选择图纸" };
    public static readonly string[]
    NoMaterial = {
      "No material",
      "Нет материала",
      "Nessun materiale",
      "Kein Material",
      "没有材料"};
    public static readonly string[]
    Point4Copy = {
      "Enter point for copy insertion",
      "Укажите точку вставки копии",
      "Specificare il punto di inserimento",
      "Geben Sie die Einfügemarke der Kopie an",
      "输入复制插入点"};
    public static readonly string[]
    FileOpenErr = {
      "Can't read drawing file: {0}",
      "Не удалось прочитать файл чертежа: {0}",
      "Impossibile leggere il file di disegno: {0}" ,
      "Zeichnungsdatei kann nicht gelesen werden: {0}",
      "无法读取绘图文件：{0}" };
    public static readonly string[]
    FileVersionErr = {
      "To read the file you need AutoCAD|BricsCAD newer: {0}",
      "Для чтения файла нужен AutoCAD|BricsCAD по новее: {0}",
      "Per leggere il file è necessario AutoCAD|BricsCAD di più recente: {0}",
      "Um die Datei zu lesen, benötigen Sie AutoCAD|BricsCAD auf neueren: {0}",
      "要读取文件，您需要 AutoCAD|BricsCAD 更新版本：{0}" };
    public static readonly string[]
    PropUpdated = {
      "  Drawing property updated: '{0}' = {1}",
      "  Обновлено свойство чертежа: '{0}' = {1}",
      "  Proprietà disegno aggiornata: '{0}' = {1}",
      "  Zeichnungseigenschaft aktualisiert: '{0}' = {1}",
      "  绘图属性已更新：“{0}”= {1}"};
    public static readonly string[]
    VersionErr = {
      "This command not compatible with this version of AutoCAD|BricsCAD",
      "Команда не совместима с данной версией AutoCAD|BricsCAD",
      "Questo comando non è compatibile con questa versione di AutoCAD|BricsCAD",
      "Dieser Befehl ist nicht mit dieser Version von AutoCAD|BricsCAD kompatibel",
      "此命令与此版本的 AutoCAD|BricsCAD 不兼容"};
    public static readonly string[]
    CreateDrawing = {
      "Creating the new clear drawing",
      "Создаем новый пустой чертеж",
      "Creare un nuovo disegno vuoto",
      "Erstellen Sie eine neue leere Zeichnung",
      "创建一个新的空绘图" };
    public static readonly string[]
    SavingDWG = {
      "Saving new drawing {0}",
      "Сохраняем файл нового чертежа {0}",
      "Salvare il nuovo file di disegno {0}",
      "Speichern Sie die neue Zeichnungsdatei {0}",
      "保存新的绘图文件 {0}" };
    public static readonly string[]
    CUIFileNF = {
      "Menu-file not found {0}",
      "Файл меню не найден {0}",
      "Menu-file non trovato {0}",
      "Menüdatei nicht gefunden {0}",
      "未找到菜单文件 {0}"};
    public static readonly string[]
    CUIUpdate = {
      "Update menu {0}",
      "Обновление меню {0}",
      "Menu aggiorna {0}",
      "Menü Update {0}",
      "更新菜单 {0}" };
    public static readonly string[]
    CUILoadErr = {
      "Can't load menu {0}",
      "Не удалось загрузить меню {0}",
      "Impossibile caricare il menu {0}",
      "Menü konnte nicht geladen werden {0}",
      "无法加载菜单 {0}" };
    public static readonly string[]
    StyleName = {
      "Style name",
      "Имя стиля",
      "Nome stile",
      "Stilname",
      "样式名称"};
    public static readonly string[]
    Unsaved = {
      "Unsaved document",
      "Не сохраненный документ",
      "Documento non salvato",
      "Nicht gespeichertes Dokument",
      "未保存的文件"};
    public static readonly string[] 
    XRefDBError = {
      "Error opening xref drawing {0}",
      "Ошибка открытия чертежа внешней ссылки {0}",
      "Errore durante l'apertura del disegno xrif {0}",
      "Fehler beim Öffnen der XRef-Zeichnung {0}",
      "打开外部参照图形 {0} 时出错" };
    public static readonly string[] 
    XRefCopyError = {
      "Error copying objects from external reference. {0}",
      "Ошибка копирования объектов из внешней ссылки. {0}",
      "Errore durante la copia di oggetti dal riferimento esterno. {0}",
      "Fehler beim Kopieren von Objekten aus externer Referenz. {0}",
      "从外部引用复制对象时出错。 {0}" };
    public static readonly string[] 
    SameFile = {
      "The source file must not be the same as the destination file",
      "Файл-источник не должен совпадать с файлом-назначения",
      "Il file di origine non corrisponde al file di destinazione",
      "Die Quelldatei darf nicht mit der Zieldatei übereinstimmen",
      "源文件不能与目标文件相同。" };

    // ----------------- Command Line Options -----------------------------------------------
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI

    public static readonly string[]
    TuneKW = { "TUNE", "НАстроить", "REGolare", "ANpassen", "设置程序(TUNE)" };
    public static readonly string[]
    SwitchKW = { "SwitchStyle", "ПЕреключитьСтиль", "CAmbiaStile", "StilWechseln", "按编号切换样式(S)" };
    public static readonly string[]
    YesKW = { "Yes", "Да", "Si", "Ja", "是的(Y)" };
    public static readonly string[]
    NoKW = { "No", "Нет", "No", "Nein", "不(N)" };
    public static readonly string[]
    OnKW = { "ON", "ВКЛючить", "ACCendere", "AKTivieren", "打开(ON)" };
    public static readonly string[]
    OffKW = { "OFF", "ОТКлючить", "DISattivare", "DEAKTivieren", "禁用(OFF)" };
    public static readonly string[]
    CancelKW = { "Cancel", "ОТмена", "Annulla", "Stornieren", "取消(C)" }; // Для командной строки. А для кнопок есть CnsL.Cancel
    public static readonly string[]
    InfoToLogKW = { "InfoToLog", "ИнфоВЛог", "InfoPerEntrare", "InfoInLog", "将信息性消息写入协议(I)" };
    public static readonly string[]
    WarningPopupKW = { "WarningPopup", "ПредупрежденияВОкно", "AvvertimentoPopup", "WarnungPopup", "在单独的窗口中显示警告消息(W)" };
    public static readonly string[]
    ErrorPopupKW = { "ErrorPopup", "ОшибкиВОкно", "ErrorePopup", "ErrorPopup", "在单独的窗口中显示错误消息(E)" };
    public static readonly string[]
    SendEMailKW = { "SendEMail", "СлатьПисьма", "InviaUnaEMail", "SendenEMail", "向开发者发送错误消息(S)" };


    public static readonly string[]
    Ideas = {
      "Enter the Idea Contest",
      "Присоединяйтесь к конкурсу идей",
      "Concorso di idee",
      "Ideenwettbewerb",
      "创意大赛"    };
    public static readonly string[]
    IdeasTip = {
      "Are you missing features or settings? Do you need other commands and programs?",
      "Вам не хватает опций для настройки плагинов? У вас есть идеи для новых команд?",
      "Ti mancano funzionalità o impostazioni? Hai bisogno di altri comandi e programmi?",
      "Vermissen Sie Funktionen oder Einstellungen? Benötigen Sie weitere Befehle und Programme?",
      "您是否缺少功能或设置？ 您需要其他命令和程序吗？"    };

  }
}
