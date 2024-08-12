// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Cnc Det Dxf Dwg

namespace AVC
{
  public static class
  DxfExportL
  {
    public static readonly string[,] DxfExportStyleNames = {
        {
        CommandL.DXF[0],
        CommandL.DXF[1],
        CommandL.DXF[2],
        CommandL.DXF[3],
        CommandL.DXF[4] } ,
        {
        "Export 2D contours",
        "Экспорт контуров",
        "Esporta contorni 2D",
        "2D-Konturen exportieren",
        "导出 2D 大纲" } ,
        {
        "Export 3D solids",
        "Экспорт солидов",
        "Esporta solidi 3D",
        "3D-Volumenkörper exportieren",
        "导出 3D 实体" } ,
      };

    public static readonly string[] TechErr = {
      "  Perhaps all parts are discarded due to inappropriate manufacturing techniques.",
      "  Возможно все детали отброшены из-за неподходящих технологий изготовления",
      "  Forse tutte le parti vengono scartate a causa di tecniche di produzione inadeguate.",
      "  Möglicherweise werden alle Teile aufgrund ungeeigneter Herstellungstechniken weggeworfen.",
      "  由于制造技术不当，可能所有零件都被丢弃了。"};
    public static readonly string[] LayErr = {
      "Couldn't lay out any details for DXF file",
      "Не удалось выложить ни одной детали для файла DXF",
      "Es konnten keine Details für die DXF-Datei angegeben werden",
      "Es konnten keine Details für die DXF-Datei angegeben werden",
      "无法列出 DXF 文件的任何详细信息" };
    public static readonly string[] NoGroupContour = {
      "Failed to draw any contours of parts of group {0}",
      "Не удалось построить ни одного контура деталей группы {0}",
      "Impossibile disegnare i contorni delle parti del gruppo {0}",
      "Konturen der Teile der Gruppe {0} konnten nicht gezeichnet werden.",
      "未能绘制组 {0} 的任何部分的轮廓" };
    public static readonly string[] NoContour = {
      "Failed to draw the outline of part {0}",
      "Не удалось построить контур детали {0}",
      "Impossibile disegnare il contorno della parte {0}",
      "Fehler beim Zeichnen des Umrisses von Teil {0}",
      "未能绘制部分 {0} 的轮廓" };
    public static readonly string[] RepeatInfo = {
      "Repeat file name {0}.\nThe program will add SameX to the name",
      "Повтор имени файла {0}.\nПрограмма добавит к имени SameX.",
      "Ripeti il ​​nome del file {0}.\nIl programma aggiungerà SameX al nome",
      "Wiederholen Sie den Dateinamen {0}.\nDas Programm fügt dem Namen SameX hinzu",
      "重复文件名 {0}。\n程序会将 SameX 添加到名称中"};
    public static readonly string[] RepeatErr = {
      "Repeat file name {0}.\n" +
        "Dxf file will not be created. Customize the file name template. Use %row% substitution",
      "Повтор имени файла {0}.\n" +
        "Dxf файл не будет создан. Настройте шаблон имени файла. Используйте подстановку %row%",
      "Ripeti il ​​nome del file {0}.\n" +
        "Il file Dxf non verrà creato. Personalizza il modello del nome del file. Usa %row% sostituzioni",
      "Wiederholen Sie den Dateinamen {0}.\n" +
        "Dxf-Datei wird nicht erstellt. Passen Sie die Dateinamenvorlage an. Verwenden Sie %row% Ersetzungen",
      "重复文件名 {0}。\n" +
        "不会创建 Dxf 文件。 自定义文件名模板。 使用 %row% 替换"};
    public static readonly string[] Nothing = {
      "  Nothing to export.",
      "  Нечего экспортировать.",
      "  Niente da esportare.",
      "  Nichts zu exportieren.",
      "  没有什么可出口的。"};
    public static readonly string[] SaveWarning = {
      "You must first save the drawing file.",
      "Требуется сначала сохранить файл чертежа.",
      "È necessario prima salvare il file di disegno.",
      "Sie müssen zuerst die Zeichnungsdatei speichern.",
      "您必须先保存图形文件。" };
    public static readonly string[] Saved = {
      "File saved '{0}'",
      "Сохранен файл '{0}'",
      "File salvato '{0}'",
      "Gespeicherte Datei '{0}'",
      "文件已保存“{0}”" };
    public static readonly string[] NoFile = {
      "No dxf file exported",
      "Не экспортировано ни одного файла dxf",
      "Nessun file dxf esportato",
      "Es wurden keine DXF-Dateien exportiert",
      "没有导出 dxf 文件" };
    public static readonly string[] Exported = {
      "{0} dxf files exported",
      "Экспортировано {0} файлов dxf",
      "{0} file dxf esportati",
      "Exportierte {0} DXF-Dateien",
      "已导出 {0} 个 dxf 文件" };
    public static readonly string[] DirNotExist = {
      "Directory does not exist or is not available",
      "Каталог не существует или недоступен",
      "La directory non esiste o non è disponibile",
      "Verzeichnis existiert nicht oder ist nicht verfügbar",
      "目录不存在或不可用"};

    // Опции командной строки
    public static readonly string[] LayStyleKW = {
      "LAYstyle",
      "LAYcтиль",
      "LAYstile",
      "LAYstil",
      "LAY风格" };
    public static readonly string[] CncStyleKW = {
      "CNCstyle",
      "CNCcтиль",
      "CNCstile",
      "CNCstil",
      "CNC风格" };
    public static readonly string[] DimDetStyleKW = {
      "DIMDETstyle",
      "DIMDETcтиль",
      "DIMDETstile",
      "DIMDETstil",
      "DIMdet风格" };
    public static readonly string[] DxfStyleKW = {
      "DXFstyle",
      "DXFcтиль",
      "DXFstile",
      "DXFstil",
      "DXF风格" };
    public static readonly string[] DDrawStyleKW = {
      "DDRAWstyle",
      "DDRAWcтиль",
      "DDRAWstile",
      "DDRAWstil",
      "DDRAW风格" };

    //============================== Options Box ==============================================
    public static readonly string[] DialogTitle = {
      "DXF Export options",
      "Настройки экспорта в DXF",
      "Opzioni di esportazione DXF",
      "DXF-Exportoptionen",
      "DXF 导出选项"};
    public static readonly string[] StyleNameTip = {
      "The name for this DXFExport-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля Экспорта DXF. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile DXFExport (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen DXFExport-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此 DXFExport 样式（设置集）的名称。 程序中未使用。 只为方便选择。"};
    public static readonly string[] OpenFolderTip = {
      "Select a folder for saving dxf files.",
      "Выбрать папку для сохранения файлов dxf.",
      "Seleziona una cartella per salvare i file dxf.",
      "Wählen Sie einen Ordner zum Speichern von DXF-Dateien.",
      "选择用于保存 dxf 文件的文件夹。"};
    public static readonly string[] Annotate = {
      "Create dimensions",
      "Создать размеры",
      "Crea dimensioni",
      "Dimensionen erstellen",
      "创建尺寸"};
    public static readonly string[] AnnotateTip = {
      "Create all annotations as configured in DimDet command style",
      "Создать все аннотации (размеры и выноски), \r\n" +
        "как настроено в стиле команды 'Размеры для деталировки'",
      "Crea tutte le annotazioni come configurate in stile Dimensioni (DimDet)",
      "Erstellen Sie alle Anmerkungen (Bemaßungen und Führungslinien) \r\n" +
        "wie im Stil des Befehls „Bemaßungen bis ins Detail“(DimDet) konfiguriert",
      "按照 DimDet 命令样式中的配置创建所有注释（“详图尺寸”）"};
    public static readonly string[] DwgFolder = {
      "Dwg Folder",
      "Папка для Dwg",
      "Cartella DWG",
      "Ordner für Dwg",
      "Dwg 文件夹"};
    public static readonly string[] DwgFolderTip = {
      "Create a subfolder named dwg-drawing",
      "Создать подпапку с именем dwg-чертежа",
      "Crea una sottocartella denominata dwg-drawing",
      "Erstellen Sie einen Unterordner namens dwg-drawing",
      "创建一个名为 dwg-drawing 的子文件夹"};
    public static readonly string[] GroupFolders = {
      "Group Folders",
      "Папки групп",
      "Cartelle di gruppo",
      "Ordner gruppieren",
      "组文件夹"};
    public static readonly string[] GroupFoldersTip = {
      "Create folders for groups. \r\n" +
        "Depending on the LAY settings folders for the Layer can be created, \r\n" +
        "they have folders for Material/Color, \r\n" +
        "and they have folders for different Thicknesses of parts.",
      "Создавать папки для групп.\r\n" +
        "В зависимости от настроек Выкладки могут быть созданы папки для Слоя,\r\n" +
        "в них папки для Материала/цвета, а в них папки для разных толщин деталей.",
      "Crea cartelle per gruppi. \r\n" +
        "A seconda del display delle impostazioni è possibile creare cartelle per il layer, \r\n" +
        "ci sono cartelle per Materiale/Colore in loro e hanno cartelle per diversi spessori di parti.",
      "Erstellen Sie Ordner für Gruppen. \r\n" +
        "Abhängig von den LAY-Einstellungen können Ordner für die Ebene erstellt werden, \r\n" +
        "sie haben Ordner für Material/Farbe und sie haben Ordner für unterschiedliche Dicken von Teilen.",
      "为组创建文件夹。 \r\n" +
        "根据可以创建图层的 LAY 设置文件夹，它们具有用于材料/颜色的文件夹，\r\n" +
        "它们具有用于不同零件厚度的文件夹。"};
    public static readonly string[] MultiDetail = {
      "Multi Detail",
      "Много деталей",
      "Multi dettaglio",
      "Viele Details",
      "很多细节"};
    public static readonly string[] MultiDetailTip = {
      "Write the contours of all parts of the group in one dxf-file. \r\n" +
        "If grouping is turned off, then you get 1 dxf file for all parts.",
      "Записывать контуры всех деталей группы в один dxf-файл. \r\n" +
        "Если выключена группировка, то получится 1 файл dxf на все детали.",
      "Scrivi i contorni di tutte le parti del gruppo in un file dxf. \r\n" +
        "Se il raggruppamento è disattivato, ottieni 1 file dxf per tutte le parti.",
      "Schreiben Sie die Konturen aller Teile der Gruppe in eine dxf-Datei. \r\n" +
        "Wenn die Gruppierung ausgeschaltet ist, erhalten Sie 1 dxf-Datei für alle Teile.",
      "将组的所有部分的轮廓写入一个 dxf 文件。 \r\n" +
        "如果分组关闭，那么您将获得所有部分的 1 个 dxf 文件。"};
    public static readonly string[] OpenDXF = {
      "Open DXF",
      "Открыть DXF",
      "Apri DXF",
      "DXF öffnen",
      "打开 DXF"};
    public static readonly string[] OpenDXFTip = {
      "After performing the export, \r\n" +
        "program need to open a DXF file or a window with a list of files",
      "После выполнения экспорта, \r\n" +
        "надо открыть DXF файл или окно со списком файлов",
      "Dopo aver eseguito l'esportazione, \r\n" +
        "è necessario aprire un file DXF o una finestra con un elenco di file",
      "Nach dem Export muss das Programm eine DXF-Datei oder ein Fenster mit einer Liste von Dateien öffnen",
      "执行导出后，程序需要打开一个 DXF 文件或带有文件列表的窗口"};
    public static readonly string[] Replace = {
      "Replace old files",
      "Заменять старые",
      "Sostituisci i vecchi file",
      "Alte Dateien ersetzen",
      "替换旧文件"};
    public static readonly string[] ReplaceTip = {
      "If the dxf file already exists, it must be replaced with a new one. \r\n" +
        "Otherwise, the program will add the version number to the end of the file name.",
      "Если файл dxf уже существует, то его надо заменить на новый. \r\n" +
        "Иначе программа добавит номер версии в конец имени файла.",
      "Se il file dxf esiste già, deve essere sostituito con uno nuovo. \r\n" +
        "In caso contrario, il programma aggiungerà il numero di versione alla fine del nome del file.",
      "Wenn die dxf-Datei bereits vorhanden ist, muss sie durch eine neue ersetzt werden. \r\n" +
        "Andernfalls fügt das Programm die Versionsnummer an das Ende des Dateinamens an.",
      "如果 dxf 文件已经存在，则必须将其替换为新文件。 \r\n" +
        "否则，程序会将版本号添加到文件名的末尾。"};
    public static readonly string[] Version = {
      "DXF version",
      "Версия DXF",
      "Versione DXF",
      "DXF-Version",
      "版本 DXF"};
    public static readonly string[] VersionTip = {
      "Select the dxf file version (file format) for compatibility. \r\n" +
        "If in doubt, use the oldest version.",
      "Выберите версию dxf-файла (формат файла) для совместимости. \r\n" +
        "Если есть сомнения используйте самую старую версию.",
      "Selezionare la versione del file dxf (formato file) per la compatibilità. \r\n" +
        "In caso di dubbio, utilizzare la versione più vecchia.",
      "Wählen Sie aus Kompatibilitätsgründen die dxf-Dateiversion (Dateiformat) aus. \r\n" +
        "Verwenden Sie im Zweifelsfall die älteste Version.",
      "选择 dxf 文件版本（文件格式）以获得兼容性。 \r\n" +
        "如有疑问，请使用最旧的版本。"};
    public static readonly string[] Folder = {
      "Folder",
      "Папка",
      "Cartella",
      "Mappe",
      "文件夹"};
    public static readonly string[] FolderTip = {
      "The name of the folder for saving dxf files. \r\n" +
        "If you leave the field blank, the dwg-drawing folder will be used. \r\n" +
        "You can use substitutions in the folder name.",
      "Имя папки для сохранения файлов dxf. \r\n" +
        "Если оставить поле пустым, то будет использована папка dwg-чертежа. \r\n" +
        "Вы можете использовать подстановки в имени папки.",
      "Il nome della cartella per il salvataggio dei file dxf. \r\n" +
        "Se si lascia vuoto il campo, verrà utilizzata la cartella disegno DWG. \r\n" +
        "È possibile utilizzare le sostituzioni nel nome della  cartella.",
      "Der Name des Ordners zum Speichern von DXF-Dateien. \r\n" +
        "Wenn Sie das Feld leer lassen, wird der dwg-Zeichnungsordner verwendet. \r\n" +
        "Sie können Ersetzungen im Ordnernamen verwenden.",
      "保存 dxf 文件的文件夹的名称。 \r\n" +
        "如果您将该字段留空，将使用 dwg-drawing 文件夹。 \r\n" +
        "您可以在文件夹名称中使用替换。"};
    public static readonly string[] FileNames = {
      "File names",
      "Имена файлов",
      "Nomi di file",
      "Dateinamen",
      "文件名"};
    public static readonly string[] FileNamesTip = {
      "String for you own file name mask.You can use substitutions of detail, drawing and time.\r\n" +
        "Input space string for returning to default file name mask.\r\n" +
        "Program selects a default mask according to the lay sorting setting",
      "Строка для вашей собственной маски имени файла. \r\n" +
        "Вы можете использовать подстановки со свойствами деталей, чертежа и времени. \r\n" +
        "Введите пустую строку для возврата к маске имени файла по умолчанию. Программа выбирает маску по умолчанию в соответствии с настройкой сортировки команды Вкладки (Lay).",
      "La stringa per la tua maschera nome file. \r\n" +
        "È possibile utilizzare le sostituzioni con le parti, il disegno e le proprietà del tempo. \r\n" +
        "Immettere una riga vuota per tornare alla maschera del nome file predefinita. Il programma seleziona la maschera predefinita secondo con l'impostazione delle schede di comando di ordinamento (Lay).",
      "Zeichenfolge für Ihre eigene Dateinamensmaske. \r\n" +
        "Sie können Ersetzungen von Details, Zeichnungen und Zeiten verwenden. \r\n" +
        "Geben Sie eine Leerzeichenfolge ein, um zur Standard-Dateinamensmaske zurückzukehren. Das Programm wählt eine Standardmaske gemäß der Lay-Sortiereinstellung aus",
      "您自己的文件名掩码的字符串。\r\n" +
        "您可以使用细节，图纸和时间的替换。输入空格字符串以返回默认文件名掩码。\r\n" +
        "程序根据布局排序设置选择默认掩码"};
    public static readonly string[] StyleHint = {
      "The command uses the current LAY style to lay out parts and grouping. \r\n" +
        "And to create the contours of parts, the current style of the 'NC Prepare' command is used. \r\n" +
        "And if you need to place dimensions and leaders, \r\n" +
        "then the style of the 'Dimensions for Detailing' command will be used.",
      "Команда использует текущий стиль Выкладки (LAY) для выкладки деталей и группировки. \r\n" +
        "Для создания контуров деталей используется текущий стиль команды 'ЧПУ подготовка'. \r\n" +
        "А если требуется расставить размеры и выноски, \r\n" +
        "то будет использован стиль команды 'Размеры для деталировки'.",
      "Il comando utilizza lo stile di layout corrente per disporre le parti e raggrupparle. \r\n" +
        "E per creare i contorni delle parti, viene utilizzato lo stile corrente del comando 'NC Prepare'. \r\n" +
        "E se è necessario posizionare quote e direttrici, verrà utilizzato lo stile del comando 'Dimensioni''.",
      "Der Befehl verwendet den aktuellen Lay-Stil (LAY) zum Anordnen von Teilen und zum Gruppieren.\r\n" +
        "Und um die Konturen der Teile zu erstellen, wird der aktuelle Stil des Befehls „NC-Vorbereitung“ verwendet. \r\n" +
        "Und wenn Sie Bemaßungen und Führungslinien platzieren müssen, wird der Stil des Befehls „Bemaßungen für Detaillierung“ verwendet.",
      "该命令使用当前的布局样式 (LAY) 来布置零件和分组。\r\n" +
        "并且要创建零件的轮廓，使用当前样式的“NC Prepare”命令。 \r\n" +
        "如果您需要放置尺寸和引线，则将使用“详图尺寸”命令的样式。"};
    public static readonly string[] ExplodeAnnotations = {
      "Explode multi-leaders and multi-line texts",
      "Взорвать выноски и мультитексты",
      "Esplodi multidirettrici e testi multiriga",
      "Explodieren Sie mehrere Führungslinien und mehrzeilige Texte",
      "展开多引线和多行文本"};
    public static readonly string[] ExplodeAnnotationsTip = {
      "Separate multi-leader (MLeader) and multi-line texts (MText) into separate lines and lines. \r\n" +
        "This option will help you export dxf to AlphaCAM.",
      "Разделить выноски (MLeader) и многострочные тексты (MText) на отдельные линии и строки. \r\n" +
        "Эта опция поможет экспортировать dxf в AlphaCAM.",
      "Separa i testi a più direttrici (MLeader) e a più righe (MText) in righe e righe separate. \r\n" +
        "Questa opzione ti aiuterà a esportare dxf in AlphaCAM.",
      "Trennen Sie mehrzeilige (MLeader) und mehrzeilige Texte (MText) in separate Zeilen und Zeilen. \r\n" +
        "Diese Option hilft Ihnen, dxf nach AlphaCAM zu exportieren.",
      "将多引线 (MLeader) 和多行文本 (MText) 分成单独的行和行。 \r\n" +
        "此选项将帮助您将 dxf 导出到 AlphaCAM。"};
    public static readonly string[] ProhibitSpaces = {
      "Prohibit spaces in file name",
      "Запретить пробелы в имени файла",
      "Sopprimi gli spazi nel nome del file",
      "Leerzeichen im Dateinamen unterdrücken",
      "抑制文件名中的空格"};
    public static readonly string[] ProhibitSpacesTip = {
      "Replace all spaces in DXF file name with _ character",
      "Заменять все пробелы в имени DXF-файла на символ _",
      "Sostituisci tutti gli spazi nel nome del file DXF con il carattere _",
      "Ersetzen Sie alle Leerzeichen im DXF-Dateinamen durch das Zeichen _",
      "将 DXF 文件名中的所有空格替换为 _ 字符"};

    //======================================  DXF File List ===============================================
    public static readonly string[] DXFFileList = {
      "DXF File List",
      "Список файлов DXF",
      "Elenco di file DXF",
      "Liste der DXF-Dateien",
      "DXF 文件列表"};
    public static readonly string[] AllFiles = {
      "All Files",
      "Все файлы",
      "Tutti i file",
      "Alle Dateien",
      "所有文件"};
    public static readonly string[] AllFilesTip = {
      "Open all files",
      "Открыть все файлы",
      "Apri tutti i file",
      "Öffnen Sie alle Dateien",
      "打开所有文件"};
    public static readonly string[] FileOpenTip = {
      "Open selected file",
      "Открыть выбранный файл",
      "Apri il file selezionato",
      "Ausgewählte Datei öffnen",
      "打开选定的文件"};
    public static readonly string[] FolderOpenTip = {
      "Open selected folder",
      "Открыть папку выбранного файла",
      "Apri la cartella selezionata",
      "Öffnen Sie den Ordner der ausgewählten Datei",
      "打开所选文件的文件夹"};
    public static readonly string[] DXFFileListHint = {
      "Exported DXF files",
      "Экспортированные файлы DXF",
      "File DXF esportati",
      "Exportierte DXF-Dateien",
      "导出的 DXF 文件"};


  }
}
