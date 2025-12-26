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
      "ByLayer",
      "PorCapa",
      "ParCalque",
      "KatmandanGel"};

    /// <summary>
    /// Локализованная строка ByBlock (с учетом языка, предпочитаемого пользователем)
    /// Используем только BricsCAD, так как в AutoCAD есть  Utilities.GetReservedString
    /// </summary>
    public static readonly string[] ByBlock = {
      "ByBlock",
      "ПоБлоку",
      "DaBlocco",
      "VonBlock",
      "ByBlock",
      "PorBloque",
      "ParBloc",
      "BlokUzre"};

    public static readonly string[] NoAvailable = {
      "n.a.",     // EN - not available
      "н.д.",     // RU - нет данных
      "n.d.",     // IT - non disponibile
      "k.A.",     // DE - keine Angabe 
      "不可用",    // ZH - не доступно
      "n.d.",     // ES - no disponible
      "n.d.",     // FR - non disponible
      "yok"       // TR - yok. можно "y.d." - yok/değil
      };

    public static readonly string[] DefFileName = {
      "Drawing",
      "Чертеж",
      "Disegno",
      "Zeichnung",
      "Drawing",
      "Dibujo",
      "Dessin",
      "Çizim"};

    public static readonly string[] Deselect = {
      "\n  Remove objects from selection. ",
      "\n  Удалите объекты из выделения. ",
      "\n  Annullare la scelta. ",
      "\n  Entfernen Sie die Objekte von den markierten. ",
      "\n  从选择中删除对象。",
      "\n  Eliminar objetos de la selección. ",
      "\n  Supprimer les objets de la sélection. ",
      "\n  Nesneleri seçimden kaldır. "};

    public static readonly string[] Select = {
      "\n  Select objects to process. ",
      "\n  Выберите объекты для обработки.  ",
      "\n  Seleziona gli oggetti da elaborare. ",
      "\n  Wählen Sie die zu verarbeitenden Objekte aus. ",
      "\n  选择要处理的对象。 ",
      "\n  Seleccione objetos para procesar. ",
      "\n  Sélectionnez les objets à traiter. ",
      "\n  İşlenecek nesneleri seçin. "};

    public static readonly string[] Selected = {
      "  Selected: ",
      "  Выбрано: ",
      "  Selezionato: ",
      "  Ausgewählt: ",
      "  已选择： ",
      "  Seleccionado: ",
      "  Sélectionné: ",
      "  Seçildi: "};

    public static readonly string[] WillBeProcessed = {
      "  Objects will be processed: {0}",
      "  Будет обработано объектов: {0}",
      "  Verranno elaborati i seguenti oggetti: {0}",
      "  Die folgenden Objekte werden verarbeitet: {0}",
      "  将处理以下对象：{0}",
      "  Se procesarán los objetos: {0}",
      "  Les objets seront traités: {0}",
      "  Nesneler işlenecek: {0}"};

    public static readonly string[] TinkerWith = {
      ". There is something to tinker with...",
      ". Есть над чем потрудиться...",
      ". C'è qualcosa con cui armeggiare...",
      ". Es gibt etwas zu basteln...",
      ". 有事要做...",
      ". Hay algo con lo que trabajar...",
      ". Il y a quelque chose à bricoler...",
      ". Üzerinde çalışılacak bir şey var..."};

    public static readonly string[] NoSelected = {
      "  Nothing selected or all objects inappropriate.",
      "  Ничего не выбрано или все объекты неподходящие.",
      "  Niente di selezionato o tutti gli oggetti inappropriati.",
      "  Nichts ist ausgewählt oder alle Objekte sind ungeeignet.",
      "  未选择任何内容或所有对象都不合适。",
      "  Nada seleccionado o todos los objetos son inapropiados.",
      "  Rien de sélectionné ou tous les objets sont inappropriés.",
      "  Hiçbir şey seçilmedi veya tüm nesneler uygun değil."};

    public static readonly string[] NoViewportSelected = {
      "  No viewport selected",
      "  Не выбран ни один видовой экран",
      "  Nessuna viewport selezionata",
      "  Kein Viewport ausgewählt",
      "  未选择视口",
      "  No se seleccionó ninguna ventana gráfica",
      "  Aucune fenêtre sélectionnée",
      "  Görünüm penceresi seçilmedi"};

    public static readonly string[] ErrSolids = {
      "Failing solids: {0}",
      "Сбойных солидов: {0}",
      "Solidi guasti: {0}",
      "Fehlende Volumenkörper: {0}",
      "无法加工的零件数量： {0}",
      "Sólidos fallidos: {0}",
      "Solides défaillants: {0}",
      "Başarısız katılar: {0}"};

    public static readonly string[] ErrorCount = {
      "FAILURE: {0}",
      "СБОЕВ: {0}",
      "FALLIMENTO: {0}",
      "VERSAGEN: {0}",
      "失败： {0}",
      "FALLA: {0}",
      "ÉCHEC: {0}",
      "BAŞARISIZLIK: {0}"};

    public static readonly string[] ModelDoc = {
      "ModelDoc(ViewBase) views not supported",
      "Виды ModelDoc(ВидБаз) не поддерживаются",
      "ModelDoc(ViewBase) visualizzazioni non supportate.",
      "ModelDoc(ViewBase)-Ansichten werden nicht unterstützt.",
      "不支持 ModelDoc(ViewBase) 视图",
      "Vistas ModelDoc(ViewBase) no compatibles",
      "Vues ModelDoc(ViewBase) non prises en charge",
      "ModelDoc(ViewBase) görünümleri desteklenmiyor"};

    public static readonly string[] FormatErr = {
      "Format is not valid",
      "Неправильный формат",
      "Formato non valido",
      "Ungültiges Format",
      "格式无效",
      "El formato no es válido",
      "Le format n'est pas valide",
      "Format geçerli değil"};

    public static readonly string[] NoTemplate = {
      "No dwt-template",
      "Не задан dwt-шаблон",
      "Non utilizzare il modello-DWT",
      "Keine DWT-Vorlage",
      "未设置绘图 dwt 模板。",
      "No hay plantilla dwt",
      "Pas de modèle dwt",
      "dwt şablonu yok"};

    public static readonly string[] TemplateNoFound = {
      "The template file '{0}' was not found, or the path was specified incorrectly.",
      "Файл шаблона '{0}' не найден, либо неверно указан путь.",
      "Il file modello '{0}' non è stato trovato oppure il percorso è stato specificato in modo errato.",
      "Die Vorlagendatei '{0}' wurde nicht gefunden oder der Pfad wurde falsch angegeben.",
      "未找到模板文件 '{0}'，或者路径指定不正确。",
      "El archivo de plantilla '{0}' no se encontró o la ruta se especificó incorrectamente.",
      "Le fichier modèle '{0}' est introuvable ou le chemin a été spécifié incorrectement.",
      "Şablon dosyası '{0}' bulunamadı veya yol yanlış belirtildi."};

    public static readonly string[] PressESC = {
      "Press ESC to complete",
      "Нажмите ESC для завершения",
      "Premere ESC per completare",
      "Drücken Sie ESC, um den Vorgang abzuschließen",
      "按 ESC 退出。",
      "Presione ESC para completar",
      "Appuyez sur ESC pour terminer",
      "Tamamlamak için ESC tuşuna basın"};

    public static readonly string[] StyleUsed = {
      "  Style will be used: {0}",
      "  Будет использован стиль: {0}",
      "  Stile sarà usato: {0}",
      "  Der Stil wird verwendet: {0}",
      "  将使用的样式：{0}",
      "  Se usará el estilo: {0}",
      "  Le style sera utilisé: {0}",
      "  Stil kullanılacak: {0}"};

    public static readonly string[] PaperSpaceOnlyCommand = {
      "This command works only in PaperSpace.",
      "Эта команда работает только в пространстве листа.",
      "Questo comando funziona solo nello spazio carta (PaperSpace).",
      "Dieser Befehl funktioniert nur im Papierbereich (PaperSpace).",
      "此命令仅在图纸空间中有效。",
      "Este comando funciona solo en el espacio papel.",
      "Cette commande ne fonctionne que dans l'espace papier.",
      "Bu komut yalnızca kağıt alanında çalışır."};

    public static readonly string[] LockedLayer = {
      "Locked layer object selected",
      "Выбран объект с заблокированного слоя",
      "Oggetto layer bloccato selezionato",
      "Gesperrtes Ebenenobjekt ausgewählt",
      "锁定层中的对象被选中。",
      "Objeto de capa bloqueada seleccionado",
      "Objet de calque verrouillé sélectionné",
      "Kilitli katman nesnesi seçildi"};

    public static readonly string[] CreateLogErr = {
      "To write errors to the Windows event log, you need to run the program with elevated privileges once (as Administrator)",
      "Чтоб записывать ошибки в журнал событий Windows требуется один раз запустить программу с повышенными привилегиями (от имени Администратора)",
      "Per scrivere errori nel registro eventi di Windows, è necessario eseguire il programma con privilegi elevati una volta (come Amministratore)",
      "Um Fehler in das Windows-Ereignisprotokoll zu schreiben, müssen Sie das Programm mit erhöhten Berechtigungen einmal ausführen (als Administrator).",
      "要将错误写入 Windows 事件日志，您需要以提升的权限运行程序一次（以管理员身份）",
      "Para escribir errores en el registro de eventos de Windows, debe ejecutar el programa con privilegios elevados una vez (como Administrador)",
      "Pour écrire des erreurs dans le journal des événements Windows, vous devez exécuter le programme avec des privilèges élevés une fois (en tant qu'administrateur)",
      "Windows olay günlüğüne hata yazmak için programı bir kez yükseltilmiş ayrıcalıklarla çalıştırmanız gerekir (Yönetici olarak)"};

    public static readonly string[] MessageOptions = {
      "Options for A>V>C> plug-ins messages",
      "Настройка вывода сообщений от плагинов A>V>C>",
      "Opzioni per A>V>C> Plugin messaggi",
      "Optionen für A>V>C> Plug-ins-Meldungen",
      "A>V>C> 插件消息的选项",
      "Opciones para mensajes de complementos A>V>C>",
      "Options pour les messages des plug-ins A>V>C>",
      "A>V>C> eklentileri mesajları için seçenekler"};

    public static readonly string[] SaveMessages = {
      "Save info-messages to Windows events log (Admin rights required). Not recommended",
      "Сохранять информационные сообщения программ A>V>C> в журнале событий Windows (не рекомендуется)",
      "Salva info-messaggi di registro eventi di windows (Diritti di amministratore richiesti. Non raccomandato)",
      "Speichern von Informationsnachrichten der Programme A>V>C> im Windows-Ereignisprotokoll (nicht empfohlen)",
      "将信息消息保存到 Windows 事件日志（需要管理员权限) 不推荐",
      "Guardar mensajes informativos en el registro de eventos de Windows (se requieren derechos de administrador). No recomendado",
      "Enregistrer les messages d'information dans le journal des événements Windows (droits d'administrateur requis). Non recommandé",
      "Bilgi mesajlarını Windows olay günlüğüne kaydet (Yönetici hakları gereklidir). Önerilmez"};

    public static readonly string[] ShowWarnings = {
      "Show warning-messages like message window (Recommended)",
      "Выводить предупреждения программ A>V>C> на экране отдельным окном (рекомендуется включить)",
      "Mostra messaggi di Avvertimento (Raccomandato)",
      "Warnungen der Programme A>V>C> in einem separaten Fenster anzeigen (Aktivierung wird empfohlen)",
      "显示警告消息，如消息窗口（推荐）",
      "Mostrar mensajes de advertencia como ventana de mensaje (Recomendado)",
      "Afficher les messages d'avertissement comme fenêtre de message (Recommandé)",
      "Uyarı mesajlarını mesaj penceresi gibi göster (Önerilir)"};

    public static readonly string[] ShowError = {
      "Show error-messages like message window (Recommended)",
      "Выводить ошибки программ A>V>C> на экране отдельным окном (рекомендуется включить)",
      "Visualizza gli errori di programma A>V>C> sullo schermo in una finestra separata. (Raccomandato)",
      "Anzeige der Programme A>V>C> in einem separaten Fenster anzeigen (Aktivierung wird empfohlen)",
      "显示错误消息，如消息窗口（推荐）",
      "Mostrar mensajes de error como ventana de mensaje (Recomendado)",
      "Afficher les messages d'erreur comme fenêtre de message (Recommandé)",
      "Hata mesajlarını mesaj penceresi gibi göster (Önerilir)"};

    public static readonly string[] SendError = {
      "Send error messages to programmer by e-mail (Recommended)",
      "Отправлять ошибки программ A>V>C> по почте разработчику (рекомендуется включить)",
      "Invia messaggi di errore al programmatore via e-mail (Raccomandato)",
      "Programmfehler senden A>V>C> per E-Mail an den Entwickler (Aktivierung wird empfohlen)",
      "显示错误消息，如消息窗口（推荐）通过电子邮件向程序员发送错误消息（推荐）",
      "Enviar mensajes de error al programador por correo electrónico (Recomendado)",
      "Envoyer des messages d'erreur au programmeur par e-mail (Recommandé)",
      "Hata mesajlarını e-posta ile programcıya gönder (Önerilir)"};

    public static readonly string[] LoadedPlugin = {
      "Plugin  '{0}' V{1}  loaded. ",
      "Плагин '{0}' V{1}  загружен. ",
      "Plugin  '{0}' V{1}  caricato. ",
      "Plugin  '{0}' V{1}  geladen. ",
      "插件'{0}'已加载。 运行版本号 {1}",
      "Complemento '{0}' V{1} cargado. ",
      "Plug-in '{0}' V{1} chargé. ",
      "Eklenti '{0}' V{1} yüklendi. "};

    public static readonly string[] SelectFirstPoint = {
      "Select first point on plane",
      "Укажите первую точку плоскости",
      "Selezionare primo punto sul piano",
      "Wählen Sie den ersten Punkt der Ebene",
      "选择平面上的第一个点。",
      "Seleccione el primer punto en el plano",
      "Sélectionnez le premier point sur le plan",
      "Düzlem üzerinde ilk noktayı seçin"};

    public static readonly string[] SelectSecondPoint = {
      "Select second point on plane",
      "Укажите вторую точку плоскости",
      "Selezionare secondo punto sul piano",
      "Wählen Sie den zweiten Punkt der Ebene.",
      "选择平面上的第二个点",
      "Seleccione el segundo punto en el plano",
      "Sélectionnez le deuxième point sur le plan",
      "Düzlem üzerinde ikinci noktayı seçin"};

    public static readonly string[] SelectThirdPoint = {
      "Select third point on plane",
      "Укажите третью точку плоскости",
      "Selezionare terzo punto sul piano",
      "Wählen Sie den dritten Punkt der Ebene.",
      "选择平面上的第三个点",
      "Seleccione el tercer punto en el plano",
      "Sélectionnez le troisième point sur le plan",
      "Düzlem üzerinde üçüncü noktayı seçin"};

    public static string[] SelectFile = {
      "Select drawing",
      "Выберите чертеж",
      "Seleziona il disegno",
      "Zeichnung auswählen",
      "选择图纸",
      "Seleccionar dibujo",
      "Sélectionner un dessin",
      "Çizim seç"};

    public static readonly string[] NoMaterial = {
      "No material",
      "Нет материала",
      "Nessun materiale",
      "Kein Material",
      "没有材料",
      "Sin material",
      "Pas de matériau",
      "Malzeme yok"};

    public static readonly string[] Point4Copy = {
      "Enter point for copy insertion",
      "Укажите точку вставки копии",
      "Specificare il punto di inserimento",
      "Geben Sie die Einfügemarke der Kopie an",
      "输入复制插入点",
      "Ingrese el punto para la inserción de copia",
      "Entrez le point d'insertion de copie",
      "Kopya ekleme noktasını girin"};

    public static readonly string[] FileOpenErr = {
      "Can't read drawing file: {0}",
      "Не удалось прочитать файл чертежа: {0}",
      "Impossibile leggere il file di disegno: {0}",
      "Zeichnungsdatei kann nicht gelesen werden: {0}",
      "无法读取绘图文件：{0}",
      "No se puede leer el archivo de dibujo: {0}",
      "Impossible de lire le fichier de dessin: {0}",
      "Çizim dosyası okunamıyor: {0}"};

    public static readonly string[] FileVersionErr = {
      "To read the file you need AutoCAD|BricsCAD newer: {0}",
      "Для чтения файла нужен AutoCAD|BricsCAD по новее: {0}",
      "Per leggere il file è necessario AutoCAD|BricsCAD di più recente: {0}",
      "Um die Datei zu lesen, benötigen Sie AutoCAD|BricsCAD auf neueren: {0}",
      "要读取文件，您需要 AutoCAD|BricsCAD 更新版本：{0}",
      "Para leer el archivo necesita AutoCAD|BricsCAD más nuevo: {0}",
      "Pour lire le fichier, vous avez besoin d'AutoCAD|BricsCAD plus récent: {0}",
      "Dosyayı okumak için daha yeni AutoCAD|BricsCAD'e ihtiyacınız var: {0}"};

    public static readonly string[] PropUpdated = {
      "  Drawing property updated: '{0}' = {1}",
      "  Обновлено свойство чертежа: '{0}' = {1}",
      "  Proprietà disegno aggiornata: '{0}' = {1}",
      "  Zeichnungseigenschaft aktualisiert: '{0}' = {1}",
      "  绘图属性已更新：'{0}'= {1}",
      "  Propiedad de dibujo actualizada: '{0}' = {1}",
      "  Propriété de dessin mise à jour: '{0}' = {1}",
      "  Çizim özelliği güncellendi: '{0}' = {1}"};

    public static readonly string[] VersionErr = {
      "This command not compatible with this version of AutoCAD|BricsCAD",
      "Команда не совместима с данной версией AutoCAD|BricsCAD",
      "Questo comando non è compatibile con questa versione di AutoCAD|BricsCAD",
      "Dieser Befehl ist nicht mit dieser Version von AutoCAD|BricsCAD kompatibel",
      "此命令与此版本的 AutoCAD|BricsCAD 不兼容",
      "Este comando no es compatible con esta versión de AutoCAD|BricsCAD",
      "Cette commande n'est pas compatible avec cette version d'AutoCAD|BricsCAD",
      "Bu komut AutoCAD|BricsCAD'in bu sürümüyle uyumlu değil"};

    public static readonly string[] CreateDrawing = {
      "Creating the new clear drawing",
      "Создаем новый пустой чертеж",
      "Creare un nuovo disegno vuoto",
      "Erstellen Sie eine neue leere Zeichnung",
      "创建一个新的空绘图",
      "Creando el nuevo dibujo vacío",
      "Création du nouveau dessin vierge",
      "Yeni boş çizim oluşturuluyor"};

    public static readonly string[] SavingDWG = {
      "Saving new drawing {0}",
      "Сохраняем файл нового чертежа {0}",
      "Salvare il nuovo file di disegno {0}",
      "Speichern Sie die neue Zeichnungsdatei {0}",
      "保存新的绘图文件 {0}",
      "Guardando nuevo dibujo {0}",
      "Enregistrement du nouveau dessin {0}",
      "Yeni çizim kaydediliyor {0}"};

    public static readonly string[] CUIFileNF = {
      "Menu-file not found {0}",
      "Файл меню не найден {0}",
      "Menu-file non trovato {0}",
      "Menüdatei nicht gefunden {0}",
      "未找到菜单文件 {0}",
      "Archivo de menú no encontrado {0}",
      "Fichier de menu introuvable {0}",
      "Menü dosyası bulunamadı {0}"};

    public static readonly string[] CUIUpdate = {
      "Update menu {0}",
      "Обновление меню {0}",
      "Menu aggiorna {0}",
      "Menü Update {0}",
      "更新菜单 {0}",
      "Actualizar menú {0}",
      "Mettre à jour le menu {0}",
      "Menüyü güncelle {0}"};

    public static readonly string[] CUILoadErr = {
      "Can't load menu {0}",
      "Не удалось загрузить меню {0}",
      "Impossibile caricare il menu {0}",
      "Menü konnte nicht geladen werden {0}",
      "无法加载菜单 {0}",
      "No se puede cargar el menú {0}",
      "Impossible de charger le menu {0}",
      "Menü yüklenemiyor {0}"};

    public static readonly string[] StyleName = {
      "Style name",
      "Имя стиля",
      "Nome stile",
      "Stilname",
      "样式名称",
      "Nombre de estilo",
      "Nom du style",
      "Stil adı"};

    public static readonly string[] Unsaved = {
      "Unsaved document",
      "Не сохраненный документ",
      "Documento non salvato",
      "Nicht gespeichertes Dokument",
      "未保存的文件",
      "Documento no guardado",
      "Document non enregistré",
      "Kaydedilmemiş belge"};

    public static readonly string[] XRefDBError = {
      "Error opening xref drawing {0}",
      "Ошибка открытия чертежа внешней ссылки {0}",
      "Errore durante l'apertura del disegno xrif {0}",
      "Fehler beim Öffnen der XRef-Zeichnung {0}",
      "打开外部参照图形 {0} 时出错",
      "Error al abrir el dibujo de referencia externa {0}",
      "Erreur lors de l'ouverture du dessin xréf {0}",
      "Xref çizimi açılırken hata {0}"};

    public static readonly string[] XRefCopyError = {
      "Error copying objects from external reference. {0}",
      "Ошибка копирования объектов из внешней ссылки. {0}",
      "Errore durante la copia di oggetti dal riferimento esterno. {0}",
      "Fehler beim Kopieren von Objekten aus externer Referenz. {0}",
      "从外部引用复制对象时出错。 {0}",
      "Error al copiar objetos desde la referencia externa. {0}",
      "Erreur lors de la copie d'objets depuis la référence externe. {0}",
      "Harici referanstan nesneler kopyalanırken hata. {0}"};

    public static readonly string[] SameFile = {
      "The source file must not be the same as the destination file",
      "Файл-источник не должен совпадать с файлом-назначения",
      "Il file di origine non corrisponde al file di destinazione",
      "Die Quelldatei darf nicht mit der Zieldatei übereinstimmen",
      "源文件不能与目标文件相同。",
      "El archivo de origen no debe ser el mismo que el archivo de destino",
      "Le fichier source ne doit pas être le même que le fichier de destination",
      "Kaynak dosya, hedef dosyayla aynı olmamalıdır"};

    // ----------------- Command Line Options -----------------------------------------------
    // ----------------- Невидимые опции встроенные в запрос выбора объектов. их невозможно заменить своими опциями - сработают встроенные. На запрос выбора точки или выбора из ключевых слов эти ограничения не действуют.
    // En: W L C B ALL F WP CP G A R M P U AU SI TRACKING TRACK TK TT END MID CEN G NOD QUA INT EXT INS PER TAN NEA APP PAR NON ZVER ZMID ZCEN ZKNO ZPER ZNEA ZNON
    // Ru: Р П С БОКС В Л РМ СМ Г Д И Н Т О А Е СЛ ОТС ТО КОН СЕР ЦЕН Г УЗЕ КВА ПЕР ПРО ТВС НОР КАС БЛИ К ПАР НИЧ ZВЕР ZСЕР ZЦЕН ZУЗЕ ZНОР ZБЛИ ZНИЧ
    // It: F U I R T NT FP IP G AG E M P A AU SI SU O PUNTAMENTO PUNTA PU TT TU FIN MED CEN CE NOD QUA UNT EST INS PER TAN VIC APP PAR N ZVER ZMED ZCEN ZNOD ZPER ZVIC ZNES
    // Ge: F L K QUADER ALLE ZA FP KP G H E M V ZU AU EI SPUR SPU SP TT ENDP MIT M G PUN QUAD SCH HIL BAS LOT TAN NÄC ANP PAR KEI ZSC ZMIT ZZEN ZKNOT ZLOT ZNÄH ZKEI
    // --- далее предположения ИИ:
    // Es: V P C RECUADRO TODO F VP IP P AG R M P A AU SI RASTREO RASTR RAS TT FIN PTC CEN P NOD CUA INT EXT INS PER TAN CERCA APP PAR NO ZVER ZMEDIO ZCEN ZNOD ZPER ZCERCA ZNO
    // Fr: F D C BOITE TOUT FC FP IP D AJ R M P A AU SI REPERAGE REP R TT EXT MIL CEN P NOD QUA INT EXT INS PER TAN PRO APP PAR AUC ZVER ZMIL ZCEN ZNOD ZPER ZPRO ZAUC
    // Tr: нет такого автокада

    public static readonly string[] TuneKW = {
      "TUNE", "НАстроить", "REGolare", "ANpassen", "设置程序(TUNE)",
      "AJUSTAR", "AJUSTER", "AYARLA"};

    public static readonly string[] SwitchKW = {
      "SwitchStyle", "ПЕреключитьСтиль", "CAmbiaStile", "StilWechseln", "按编号切换样式(S)",
      "CambiarEstilo", "ChangerStyle", "StilDeğiştir"};

    public static readonly string[] YesKW = {
      "Yes", "Да", "Si", "Ja", "是的(Y)",
      "Sí", "Oui", "Evet"};

    public static readonly string[] NoKW = {
      "No", "Нет", "No", "Nein", "不(N)",
      "No", "Non", "Hayır"};

    public static readonly string[] OnKW = {
      "ON", "ВКЛючить", "ACCendere", "AKTivieren", "打开(ON)",
      "ACTIVAR", "ACTIVER", "AÇ"};

    public static readonly string[] OffKW = {
      "OFF", "ОТКлючить", "DISattivare", "DEAKTivieren", "禁用(OFF)",
      "DESACTIVAR", "DÉSACTIVER", "KAPAT"};

    public static readonly string[] CancelKW = {
      "Cancel", "ОТмена", "Annulla", "Stornieren", "取消(C)",
      "Cancelar", "Annuler", "İptal"};

    public static readonly string[] InfoToLogKW = {
      "InfoToLog", "ИнфоВЛог", "InfoPerEntrare", "InfoInLog", "将信息性消息写入协议(I)",
      "InfoAlRegistro", "InfoDansJournal", "GünlüğeBilgi"};

    public static readonly string[] WarningPopupKW = {
      "WarningPopup", "ПредупрежденияВОкно", "AvvertimentoPopup", "WarnungPopup", "在单独的窗口中显示警告消息(W)",
      "AdvertenciaVentana", "AvertissementFenêtre", "UyarıPenceresi"};

    public static readonly string[] ErrorPopupKW = {
      "ErrorPopup", "ОшибкиВОкно", "ErrorePopup", "ErrorPopup", "在单独的窗口中显示错误消息(E)",
      "ErrorVentana", "ErreurFenêtre", "HataPenceresi"};

    public static readonly string[] SendEMailKW = {
      "SendEMail", "СлатьПисьма", "InviaUnaEMail", "SendenEMail", "向开发者发送错误消息(S)",
      "EnviarEmail", "EnvoyerEmail", "EmailGönder"};

    public static readonly string[] Ideas = {
      "Enter the Idea Contest",
      "Присоединяйтесь к конкурсу идей",
      "Concorso di idee",
      "Ideenwettbewerb",
      "创意大赛",
      "Participe en el concurso de ideas",
      "Participez au concours d'idées",
      "Fikir yarışmasına katılın"};

    public static readonly string[] IdeasTip = {
      "Are you missing features or settings? Do you need other commands and programs?",
      "Вам не хватает опций для настройки плагинов? У вас есть идеи для новых команд?",
      "Ti mancano funzionalità o impostazioni? Hai bisogno di altri comandi e programmi?",
      "Vermissen Sie Funktionen oder Einstellungen? Benötigen Sie weitere Befehle und Programme?",
      "您是否缺少功能或设置？ 您需要其他命令和程序吗？",
      "¿Le faltan funciones o configuraciones? ¿Necesita otros comandos y programas?",
      "Vous manque-t-il des fonctionnalités ou des paramètres? Avez-vous besoin d'autres commandes et programmes?",
      "Özellikleri veya ayarları mı eksik? Başka komutlara ve programlara mı ihtiyacınız var?"};
  }
}
