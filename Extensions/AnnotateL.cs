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
      "插入布局时出错：模板 '{0}' 不包含布局'{1}'",
      "Error al insertar diseño: la plantilla '{0}' no contiene el diseño '{1}'",
      "Erreur d'insertion de mise en page: le modèle '{0}' ne contient pas la mise en page '{1}'",
      "Düzen ekleme hatası: şablon '{0}' düzeni '{1}' içermiyor"};

    public static readonly string[] LayoutDisplayErr = {
      "Failed to display layout {0}",
      "Не удалось отобразить лист {0}",
      "Impossibile visualizzare il layout {0}",
      "Layout konnte nicht angezeigt werden {0}",
      "未能显示布局 {0}",
      "No se pudo mostrar el diseño {0}",
      "Échec de l'affichage de la mise en page {0}",
      "Düzen {0} görüntülenemedi"};

    public static readonly string[] LayoutAdded = {
      "  Added layout '{0}'",
      "  Добавлен лист '{0}'",
      "  Aggiunto layout '{0}'",
      "  Layout hinzugefügt '{0}'",
      "  添加了布局 '{0}'",
      "  Diseño agregado '{0}'",
      "  Mise en page ajoutée '{0}'",
      "  Düzen eklendi '{0}'"};

    public static readonly string[] LayoutOrder = {
      "Set tab order for new layout {0}",
      "Назначаем новый лист на позицию {0}",
      "Imposta l'ordine di tabulazione per il nuovo layout {0}",
      "Tabulatorreihenfolge für neues Layout festlegen {0}",
      "将新工作表分配到位置 {0}",
      "Establecer orden de pestañas para nuevo diseño {0}",
      "Définir l'ordre des onglets pour la nouvelle mise en page {0}",
      "Yeni düzen için sekme sırası ayarla {0}"};

    public static readonly string[] LayoutTooMany = {
      "Too many layouts. Add more is not possible.",
      "Слишком много листов. Добавлять больше невозможно",
      "Troppi fogli. Aggiungere altro non è possibile",
      "Zu viele Blätter. Mehr hinzufügen ist nicht möglich",
      "床单太多。 无法添加更多",
      "Demasiados diseños. Agregar más no es posible.",
      "Trop de mises en page. Ajouter plus n'est pas possible.",
      "Çok fazla düzen. Daha fazla eklemek mümkün değil."};

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
        "打开文件 {0} 并使用 _Audit 命令进行故障排除",
      "La plantilla está dañada. \r\n" +
        "Abra el archivo {0} y solucione problemas con el comando _Audit",
      "Le modèle est endommagé. \r\n" +
        "Ouvrez le fichier {0} et dépannez avec la commande _Audit",
      "Şablon hasarlı. \r\n" +
        "Dosya {0}'ı açın ve _Audit komutuyla sorun giderin"};

    // ============================= Multi Leader =================================================

    public static readonly string[] LeaderText = {
      "Leader text",
      "Текст выноски",
      "Testo",
      "Text",
      "标注文字",
      "Texto de directriz",
      "Texte de repère",
      "Çıkma metni"};

    // =================================== Text ==================================================
    public static readonly string[] TextStyleErr = {
      "Text style '{0}' not exist. Will use current style",
      "Такого стиля нет '{0}'. Будет использован текущий стиль",
      "Lo stile di testo '{0}' non esiste. Userò lo stile attuale",
      "Der Textstil '{0}' ist nicht vorhanden. Verwendet den aktuellen Stil",
      "文本样式'{0}'不存在。 将使用当前样式",
      "El estilo de texto '{0}' no existe. Se usará el estilo actual",
      "Le style de texte '{0}' n'existe pas. Utilisera le style actuel",
      "Metin stili '{0}' mevcut değil. Geçerli stil kullanılacak"};

    public static string[] UpdatedTexts =  {
      "Updated {0} texts.",
      "Обновлено {0} текстов.",
      "Aggiornato {0} testo.",
      "{0} Texte wurden aktualisiert",
      "更新了 {0} 个文本。",
      "Actualizados {0} textos.",
      "{0} textes mis à jour.",
      "{0} metin güncellendi."};

    public static string[] NoTextInView = {
      "No single non-annotative MText was found in the viewport.",
      "Во вьюпорте не найдено ни одного неаннотативного мультитекста.",
      "Viewport non corrisponde alcun MTesto neannotativnogo.",
      "Im Ansichtsfenster wurde kein einziger nicht annotativer MText gefunden.",
      "在视口中找不到单个非注释性多行文字。",
      "No se encontró ningún MText no anotativo en la ventana gráfica.",
      "Aucun MText non annotatif n'a été trouvé dans la fenêtre.",
      "Görünüm penceresinde tek bir açıklama niteliğinde olmayan MText bulunamadı."};

    // ===================================== Tables ==============================================
    public static readonly string[] CellStyleErr = {
      "Could not assign style to cell",
      "Не получилось назначить стиль ячейке",
      "Non è stato possibile assegnare uno stile a una cella",
      "Der Stil konnte der Zelle nicht zugewiesen werden",
      "未能指定单元格样式",
      "No se pudo asignar estilo a la celda",
      "Impossible d'attribuer un style à la cellule",
      "Hücreye stil atanamadı"};

    public static readonly string[] CellUnmergeErr = {
      "Could not unmerge cells",
      "Не возможно разъединить ячейки",
      "Impossibile separare le celle",
      "Zellen konnten nicht getrennt werden",
      "无法取消合并单元格",
      "No se pudieron separar las celdas",
      "Impossible de séparer les cellules",
      "Hücreler ayrılamadı"};

    public static readonly string[] TableWriteErr = {
      "Can't open Table for write",
      "Не удалось открыть таблицу для записи",
      "Impossibile aprire la tabella per la scrittura",
      "Tabelle zum Schreiben kann nicht geöffnet werden",
      "无法打开表进行写入",
      "No se puede abrir la tabla para escribir",
      "Impossible d'ouvrir le tableau pour l'écriture",
      "Tablo yazma için açılamıyor"};

    public static readonly string[] TableLinked = {
      "The table is linked to Excel. Recording is not possible.",
      "Таблица подключена к Excel. Запись невозможна.",
      "La tabella è collegata a Excel. La registrazione non è possibile.",
      "Die Tabelle ist mit Excel verknüpft. Aufnahme ist nicht möglich.",
      "该表已连接到 Excel。 无法录制。",
      "La tabla está vinculada a Excel. La grabación no es posible.",
      "Le tableau est lié à Excel. L'enregistrement n'est pas possible.",
      "Tablo Excel'e bağlı. Kayıt mümkün değil."};

    public static readonly string[] TableStyleErr = {
      "The table does not contain the necessary standard cell styles (TITLE, HEADER, DATA)",
      "Таблица не содержит необходимых стандартных стилей ячеек (TITLE, HEADER, DATA)",
      "La tabella non contiene gli stili di cella standard necessari (TITLE, HEADER, DATA)",
      "Die Tabelle enthält nicht die erforderlichen Standardzellstile (TITLE, HEADER, DATA).",
      "该表不包含所需的标准单元格样式（TITLE、HEADER、DATA）",
      "La tabla no contiene los estilos de celda estándar necesarios (TITLE, HEADER, DATA)",
      "Le tableau ne contient pas les styles de cellule standard nécessaires (TITLE, HEADER, DATA)",
      "Tablo gerekli standart hücre stillerini içermiyor (TITLE, HEADER, DATA)"};

    public static readonly string[] TableStyleNotExists = {
      "Table style {0} does not exist. The current table style will be used.",
      "Не существует стиль таблиц {0}. Будет использован текущий стиль таблиц.",
      "Lo stile tabella {0} non esiste. Verrà utilizzato lo stile di tabella corrente.",
      "Tabellenstil {0} existiert nicht. Der aktuelle Tabellenstil wird verwendet.",
      "表格样式 {0} 不存在。 将使用当前表格样式。",
      "El estilo de tabla {0} no existe. Se usará el estilo de tabla actual.",
      "Le style de tableau {0} n'existe pas. Le style de tableau actuel sera utilisé.",
      "Tablo stili {0} mevcut değil. Geçerli tablo stili kullanılacak."};

    public static readonly string[] SelectTable = {
      "Select Table",
      "Выберите таблицу",
      "Seleziona tabella",
      "Wählen Sie Tabelle",
      "选择表",
      "Seleccionar tabla",
      "Sélectionner un tableau",
      "Tablo seç"};

    public static readonly string[] EraseData = {
      ". All data will be overwritten",
      ". Все данные будут затерты",
      ". Tutti i dati verranno sovrascritti",
      ". Alle Daten werden überschrieben",
      ". 所有数据将被覆盖",
      ". Todos los datos serán sobrescritos",
      ". Toutes les données seront écrasées",
      ". Tüm veriler üzerine yazılacak"};

    public static readonly string[] NeedTable = {
      "\nNeed selected a Table!\n",
      "\nНужно выбрать таблицу!\n",
      "\nHai selezionato una tavola!\n",
      "\nNeed ausgewählt eine Tabelle!\n",
      "\n您需要选择一张桌子！\n",
      "\n¡Necesita seleccionar una tabla!\n",
      "\nVous devez sélectionner un tableau!\n",
      "\nBir tablo seçmeniz gerekiyor!\n"};

    public static readonly string[] TableInsertionPoint =  {
      "Specify the insertion point of the new table",
      "Укажите точку вставки новой таблицы",
      "Specificare il punto di inserimento della nuova tabella",
      "Geben Sie die Einfügemarke der neuen Tabelle an",
      "指定新表的插入点",
      "Especifique el punto de inserción de la nueva tabla",
      "Spécifiez le point d'insertion du nouveau tableau",
      "Yeni tablonun ekleme noktasını belirtin"};

    public static readonly string[] TableCreateErr = {
       "Could not create new table. Error: {0}",
       "Не удалось создать новую таблицу. Ошибка: {0}",
       "Impossibile creare una nuova tabella. Errore: {0}",
       "Konnte keine neue Tabelle erstellen. Fehler: {0}",
       "创建新表失败。 错误：{0}",
       "No se pudo crear una nueva tabla. Error: {0}",
       "Impossible de créer un nouveau tableau. Erreur: {0}",
       "Yeni tablo oluşturulamadı. Hata: {0}"};

    public static readonly string[] TableBottomToTopErr = {
       "The command does not work with tables with bottom-up filling direction.",
       "Команда не работает с таблицами с направлением заполнения снизу вверх.",
       "Il comando non funziona con le tabelle con direzione di riempimento dal basso verso l'alto.",
       "Der Befehl funktioniert nicht bei Tabellen mit Bottom-Up-Füllrichtung.",
       "该命令不适用于自下而上填充方向的表格。",
       "El comando no funciona con tablas con dirección de llenado de abajo hacia arriba.",
       "La commande ne fonctionne pas avec les tableaux avec direction de remplissage de bas en haut.",
       "Komut, aşağıdan yukarıya doldurma yönüne sahip tablolarla çalışmaz."};

    public static readonly string[] NoFreeSpace = {
       "There is no free space on the sheet even for {0} rows of the table",
       "На листе нет свободного места даже для {0} строк таблицы",
       "Non c'è spazio libero sul foglio anche per {0} righe del tavolo",
       "Es gibt keinen freien Platz auf dem Blatt auch für {0} Zeilen des Tisches",
       "即使表格的 {0} 行，工作表上也没有可用空间",
       "No hay espacio libre en la hoja ni siquiera para {0} filas de la tabla",
       "Il n'y a pas d'espace libre sur la feuille même pour {0} lignes du tableau",
       "Sayfada tablonun {0} satırı için bile boş alan yok"};

    public static readonly string[] TooShortTable = {
       "The table will not be divided into parts, since it has less than 4 rows.",
       "Таблица не будет разделена на части, так как в ней меньше 4х строк.",
       "La tabella non verrà divisa in parti poiché ha meno di 4 righe.",
       "Die Tabelle wird nicht in Teile geteilt, da sie weniger als 4 Zeilen hat.",
       "该表不会被分成多个部分，因为它的行数少于 4 行。",
       "La tabla no se dividirá en partes, ya que tiene menos de 4 filas.",
       "Le tableau ne sera pas divisé en parties, car il a moins de 4 lignes.",
       "Tablo parçalara bölünmeyecek, çünkü 4'ten az satırı var."};

    // ============================== Viewport ================================================
    public static string[] NeedPaper = {
      "The command works only in paper space",
      "Необходимо, чтобы текущим пространством был лист",
      "Comando funziona solo nello spazio del paper",
      "Es ist notwendig, dass der aktuelle Platz ein Blatt ist.",
      "要求当前空间为工作表",
      "El comando funciona solo en el espacio papel",
      "La commande ne fonctionne que dans l'espace papier",
      "Komut yalnızca kağıt alanında çalışır"};

    public static string[] NoViewport = {
      "No viewport found",
      "Не найдено ни одного видового экрана",
      "Non ci sono risultati viewport",
      "Kein Ansichtsfenster gefunden",
      "未找到视口",
      "No se encontró ninguna ventana gráfica",
      "Aucune fenêtre trouvée",
      "Görünüm penceresi bulunamadı"};

    public static string[] ViewportSelect = {
      "Select viewport",
      "Выберите Видовой экран",
      "Selezionare viewport",
      "Ansichtsfenster auswählen",
      "选择视口",
      "Seleccionar ventana gráfica",
      "Sélectionner une fenêtre",
      "Görünüm penceresi seç"};

    public static string[] NeedViewport = {
      "\nMust select viewport\n",
      "\nНеобходимо выбрать видовой экран\n",
      "\nDeve selezionare viewport\n",
      "\nMuss Ansichtsfenster auswählen\n",
      "\n必须选择视口\n",
      "\nDebe seleccionar ventana gráfica\n",
      "\nDoit sélectionner une fenêtre\n",
      "\nGörünüm penceresi seçilmeli\n"};

    public static string[] ViewportNotSelected ={
      "\nThe viewport is not selected. The work of the command was interrupted by the user.",
      "\nНе выбран видовой экран. Работа команды прервана пользователем.",
      "\nNon selezionato viewport. Il lavoro di squadra è interrotta dall'utente.",
      "\nDas Ansichtsfenster ist nicht ausgewählt. Die Arbeit des Befehls wurde vom Benutzer unterbrochen.",
      "\n未选择视口。 该命令的工作被用户中断。",
      "\nNo se seleccionó la ventana gráfica. El trabajo del comando fue interrumpido por el usuario.",
      "\nLa fenêtre n'est pas sélectionnée. Le travail de la commande a été interrompu par l'utilisateur.",
      "\nGörünüm penceresi seçilmedi. Komutun çalışması kullanıcı tarafından kesildi."};

    public static string[] CropErr ={
      "Error in the object that defines the boundaries of the viewport.",
      "Ошибка в объекте задающем границы вьюпорта.",
      "Errore nell'oggetto che definisce i confini della finestra.",
      "Fehler in dem Objekt, das die Grenzen des Ansichtsfensters definiert.",
      "定义视口边界的对象中的错误。",
      "Error en el objeto que define los límites de la ventana gráfica.",
      "Erreur dans l'objet qui définit les limites de la fenêtre.",
      "Görünüm penceresinin sınırlarını tanımlayan nesnede hata."};

    public static string[] PerspectiveWarning = {
      "Perspective viewports not supported",
      "Перспективные видовые экраны не поддерживаются",
      "Viewport prospettiche non supportate",
      "Perspektivische Ansichtsfenster werden nicht unterstützt",
      "不支持透视视口",
      "No se admiten ventanas gráficas en perspectiva",
      "Les fenêtres en perspective ne sont pas prises en charge",
      "Perspektif görünüm pencereleri desteklenmiyor"};

    public static readonly string[] TileModeWarning ={
      "The placement of annotations in the model space is not provided",
      "Простановка аннотаций в пространстве модели не предусмотрена",
      "Il posizionamento delle annotazioni nello spazio modello non è previsto",
      "Die Platzierung von Anmerkungen im Modellbereich ist nicht vorgesehen",
      "未提供模型空间中注释的放置",
      "No se proporciona la colocación de anotaciones en el espacio del modelo",
      "Le placement d'annotations dans l'espace modèle n'est pas prévu",
      "Model alanında açıklama yerleştirilmesi sağlanmamaktadır"};
  }
}