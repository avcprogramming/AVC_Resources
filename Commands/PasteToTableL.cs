// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Dwg

namespace AVC
{
  /// <summary>
  /// Localization strings for PTT(Paste To Table), TableSplit commands. PasteToTableOptions dialog box
  /// </summary>
  public static class
  PasteToTableL
  {
    // ============================= Paste To Table style ===========================
    public static readonly string[] DestinationTable = {
      "Dwg Table",
      "Dwg Таблица",
      "Dwg Tabella",
      "Dwg Tabelle",
      "Dwg 表",
      "Dwg Tabla",                                     // ES
      "Dwg Tableau",                                   // FR
      "Dwg Tablo"};                                    // TR

    public static readonly string[] DestinationMText = {
      "Dwg MText",
      "Dwg Текст",
      "Dwg Testo",
      "Dwg Text",
      "Dwg 文本",
      "Dwg Texto",                                     // ES
      "Dwg Texte",                                     // FR
      "Dwg Metin" };                                   // TR

    public static readonly string[] DestinationExcel = { "Excel" };

    public static readonly string[] DestinationCSV = {
      "File CSV",
      "Файл CSV",
      "File CSV",
      "Datei CSV",
      "文件 CSV",
      "Archivo CSV",                                   // ES
      "Fichier CSV",                                   // FR
      "CSV Dosyası" };                                 // TR

    public static readonly string[] DestinationXML = {
      "File XML",
      "Файл XML",
      "File XML",
      "Datei XML",
      "文件 XML",
      "Archivo XML",                                   // ES
      "Fichier XML",                                   // FR
      "XML Dosyası" };                                 // TR

    public static readonly string[] DestinationClipboard = {
      "Clipboard",
      "Буфер",
      "Appunti",
      "Zwischenablage",
      "剪贴板",
      "Portapapeles",                                  // ES
      "Presse-papiers",                                // FR
      "Pano" };                                        // TR

    // =============================   Table Split ==================================
    public static readonly string[] Split = {
      "Split table",
      "Разбиение таблицы",
      "Tavolo separato",
      "Split-Tabelle",
      "拆分表",
      "Dividir tabla",                                 // ES
      "Diviser le tableau",                            // FR
      "Tabloyu böl"};                                  // TR

    public static readonly string[] NoSplit = {
      "Could not split the table",
      "Не получилось разделить таблицу",
      "Impossibile dividere la tabella",
      "Die Tabelle konnte nicht geteilt werden",
      "无法拆分表格",
      "No se pudo dividir la tabla",                   // ES
      "Impossible de diviser le tableau",              // FR
      "Tablo bölünemedi" };                            // TR

    public static readonly string[] Divided = {
      "The table is divided into {0} layouts",
      "Таблица разделена на {0} листов",
      "La tabella è divisa in layout di {0}",
      "Die Tabelle ist in {0} Layouts unterteilt",
      "该表分为 {0} 个布局",
      "La tabla está dividida en {0} presentaciones",  // ES
      "Le tableau est divisé en {0} présentations",    // FR
      "Tablo {0} düzene bölündü" };                    // TR

    public static readonly string[] Merge = {
      "Merge table",
      "Объединение таблицы",
      "Unisci tabella",
      "Zusammenführungstabelle",
      "合并表",
      "Combinar tabla",                                // ES
      "Fusionner le tableau",                          // FR
      "Tabloyu birleştir" };                           // TR

    // ============================= Paste To Table ====================================

    public static readonly string[] ClipboardErr = {
      "Error while working with the clipboard: {0}",
      "Ошибка при работе с буфером обмена: {0}",
      "Errore mentre si lavora con gli appunti: {0}",
      "Fehler beim Arbeiten mit der Zwischenablage: {0}",
      "使用剪贴板时出错：{0}",
      "Error al trabajar con el portapapeles: {0}",    // ES
      "Erreur lors du travail avec le presse-papiers : {0}",  // FR
      "Pano ile çalışırken hata: {0}"};                // TR

    public static readonly string[] CopiedToClipboard = {
      "  Results are copied to the clipboard",
      "  Результаты скопированы в буфер",
      "  I risultati vengono copiati negli appunti",
      "  Ergebnisse in die Zwischenablage kopiert.",
      "  结果被复制到剪贴板",
      "  Los resultados se copian al portapapeles",    // ES
      "  Les résultats sont copiés dans le presse-papiers",  // FR
      "  Sonuçlar panoya kopyalandı"};                // TR

    public static readonly string[] Writing = {
      "Writing to table",
      "Запись в таблицу",
      "Scrivere a tavola",
      "Auf den Tisch schreiben",
      "写到表",
      "Escribiendo en la tabla",                       // ES
      "Écriture dans le tableau",                      // FR
      "Tabloya yazma" };                               // TR

    public static readonly string[] SelectTable = {
      "Select Table. All data will be overwritten" ,
      "Выберите таблицу. Все данные будут затерты",
      "Seleziona tabella. Tutti i dati verranno sovrascritti",
      "Wählen Sie Tabelle. Alle Daten werden überschrieben",
      "选择表。 所有数据将被覆盖",
      "Seleccione tabla. Todos los datos serán sobrescritos",  // ES
      "Sélectionnez le tableau. Toutes les données seront écrasées",  // FR
      "Tablo seçin. Tüm veriler üzerine yazılacak" };  // TR

    public static readonly string[] NeedTable = {
      "\nNeed selected a Table!\n",
      "\nНужно выбрать таблицу!\n",
      "\nHai selezionato una tavola!\n",
      "\nNeed ausgewählt eine Tabelle!\n",
      "\n需要选择一个表！\n",
      "\n¡Necesita seleccionar una tabla!\n",           // ES
      "\nVous devez sélectionner un tableau !\n",      // FR
      "\nBir tablo seçmeniz gerekiyor!\n" };           // TR

    public static readonly string[] NoText = {
      "Clipboard not contain text for paste" ,
      "В буфере обмена не содержится текста для вставки",
      "Gli appunti non contengono il testo per la colla",
      "Zwischenablage enthält keinen Text zum Einfügen",
      "剪贴板不包含用于粘贴的文本",
      "El portapapeles no contiene texto para pegar",  // ES
      "Le presse-papiers ne contient pas de texte à coller",  // FR
      "Pano yapıştırılacak metin içermiyor"};          // TR

    public static readonly string[] Inserted = {
      "Inserted data rows {0}",
      "Вставлено строк данных {0}",
      "Le righe di dati inserite {0}",
      "Eingefügte Datenzeilen {0}",
      "插入的数据行 {0}",
      "Filas de datos insertadas {0}",                 // ES
      "Lignes de données insérées {0}",                // FR
      "Eklenen veri satırları {0}" };                  // TR

    public static readonly string[] TableFound = {
      "  A table entitled '{0}' was found in the drawing '{1}'. It will be used to insert new data.",
      "  В чертеже '{1}' найдена таблица с заголовком '{0}'. Она будет использована для вставки новых данных.",
      "  Una tabella intitolata '{0}' è stata trovata nel disegno '{1}'. Sarà utilizzato per inserire nuovi dati.",
      "  Eine Tabelle mit dem Titel '{0}' wurde in der Zeichnung '{1}' gefunden. Es wird verwendet, um neue Daten einzufügen.",
      "  在绘图'{1}'中找到标题为'{0}'的表。 它将用于插入新数据。",
      "  Se encontró una tabla titulada '{0}' en el dibujo '{1}'. Se utilizará para insertar nuevos datos.",  // ES
      "  Un tableau intitulé '{0}' a été trouvé dans le dessin '{1}'. Il sera utilisé pour insérer de nouvelles données.",  // FR
      "  '{1}' çiziminde '{0}' başlıklı bir tablo bulundu. Yeni verileri eklemek için kullanılacaktır." };  // TR

    public static readonly string[] NewKW = {
      "New",
      "НОвая",
      "NUovo",
      "Neu",
      "新的(N)",
      "NUeva",                                         // ES
      "NOuveau",                                       // FR
      "YEni" };                                        // TR

    // ===================================== Dialog Box (продолжение) =======================================================

    public static readonly string[] EditStyleText = {
      "Edit Style",
      "Редактор стиля",
      "Modifica stile",
      "Stil bearbeiten",
      "编辑样式",
      "Editar estilo",                                 // ES
      "Modifier le style",                             // FR
      "Stili düzenle" };                               // TR

    public static readonly string[] EditStyleTip = {
      "Close this window and call the TableStyle command \r\n" +
        "to configure all the parameters of the new dwg-table.",
      "Закрыть это окно и вызвать команду TableStyle, \r\n" +
        "чтобы настроить стиль новой таблицы.",
      "Chiudi questa finestra e chiama il comando TableStyle \r\n" +
        "per configurare tutti i parametri della nuova tabella DWG.",
      "Verlieren Sie dieses Fenster und rufen Sie den Befehl TableStyle auf, \r\n" +
        "um alle Parameter der neuen DWG-Tabelle zu konfigurieren.",
      "丢掉这个窗口，调用 TableStyle 命令配置新 dwg-table 的所有参数。",
      "Cierre esta ventana y llame al comando TableStyle \r\n" +  // ES
        "para configurar todos los parámetros de la nueva tabla dwg.",
      "Fermez cette fenêtre et appelez la commande TableStyle \r\n" +  // FR
        "pour configurer tous les paramètres du nouveau tableau dwg.",
      "Bu pencereyi kapatın ve yeni dwg tablosunun tüm parametrelerini \r\n" +  // TR
        "yapılandırmak için TableStyle komutunu çağırın." };

    public static readonly string[] FileOpenTip = {
      "Select a folder for saving file",
      "Диалог выбора папки для сохранения.",
      "Seleziona una cartella per il salvataggio del file",
      "Wählen Sie einen Ordner zum Speichern der Datei",
      "选择保存文件的文件夹",
      "Seleccione una carpeta para guardar el archivo",  // ES
      "Sélectionnez un dossier pour enregistrer le fichier",  // FR
      "Dosyayı kaydetmek için bir klasör seçin" };     // TR

    public static readonly string[] AdaptWidthText = {
      "Adapt Width",
      "Авто ширина",
      "Adatta larghezza",
      "Breite anpassen",
      "适应宽度",
      "Adaptar ancho",                                 // ES
      "Adapter la largeur",                            // FR
      "Genişliği uyarla" };                            // TR

    public static readonly string[] AdaptWidthTip = {
      "Adapt the width of the columns by content.",
      "Адаптировать ширину колонок по содержимому",
      "Adatta la larghezza delle colonne in base al contenuto.",
      "Passen Sie die Breite der Spalten nach Inhalt an.",
      "按内容调整列的宽度。",
      "Adaptar el ancho de las columnas según el contenido.",  // ES
      "Adapter la largeur des colonnes au contenu.",   // FR
      "Sütunların genişliğini içeriğe göre uyarlayın." };  // TR

    public static readonly string[] ClearCellsText = {
      "Clear Columns",
      "Очищать колонки",
      "Cancella colonne",
      "Spalten löschen",
      "清除列",
      "Limpiar columnas",                              // ES
      "Effacer les colonnes",                          // FR
      "Sütunları temizle" };                           // TR

    public static readonly string[] ClearCellsTip = {
      "If there are more columns in the table than necessary - clear extra cells.",
      "Если в таблице больше столбцов, чем надо - очистить лишние",
      "Se nella tabella sono presenti più colonne del necessario, cancella le celle extra.",
      "Wenn die Tabelle mehr Spalten als nötig enthält, löschen Sie zusätzliche Zellen.",
      "如果表格中的列多于必要的列 - 清除多余的单元格。",
      "Si hay más columnas en la tabla de las necesarias, limpie las celdas adicionales.",  // ES
      "S'il y a plus de colonnes dans le tableau que nécessaire, effacez les cellules supplémentaires.",  // FR
      "Tabloda gerekenden fazla sütun varsa, fazladan hücreleri temizleyin." };  // TR

    public static readonly string[] ClearStyleOverridesText = {
      "Clear Style",
      "Очищать стиль",
      "Stile chiaro",
      "Klarer Stil",
      "清晰的风格",
      "Limpiar estilo",                                // ES
      "Effacer le style",                              // FR
      "Stili temizle" };                               // TR

    public static readonly string[] ClearStyleOverridesTip = {
      "Clear format settings for all table cells. \r\n" +
        "Cell style settings will be used.",
      "Очистить настройки формата всех ячеек таблицы. \r\n" +
        "Будут использованы настройки по стилю ячеек.",
      "Cancella le impostazioni di formato per tutte le celle della tabella. \r\n" +
        "Verranno utilizzate le impostazioni dello stile della cella.",
      "Formateinstellungen für alle Tabellenzellen löschen. \r\n" +
        "Zellenstileinstellungen werden verwendet.",
      "清除所有表格单元格的格式设置。 \r\n" +
        "将使用单元格样式设置。",
      "Borrar la configuración de formato de todas las celdas de la tabla. \r\n" +  // ES
        "Se utilizará la configuración de estilo de celda.",
      "Effacer les paramètres de format de toutes les cellules du tableau. \r\n" +  // FR
        "Les paramètres de style de cellule seront utilisés.",
      "Tüm tablo hücrelerinin biçim ayarlarını temizleyin. \r\n" +  // TR
        "Hücre stili ayarları kullanılacaktır." };

    public static readonly string[] DelEmptyColumns = {
      "Delete empty columns",
      "Удалять пустые столбцы",
      "Rimuovi colonne vuote",
      "Leere Spalten löschen",
      "删除空列",
      "Eliminar columnas vacías",                      // ES
      "Supprimer les colonnes vides",                  // FR
      "Boş sütunları sil" };                           // TR

    public static readonly string[] DelEmptyColumnsTip = {
      "Delete a table column if all values ​​and substitutions are empty.",
      "Удалять колонку таблицы, если все значения и подстановки оказались пустыми.",
      "Elimina una colonna della tabella se tutti i valori e le sostituzioni sono vuoti.",
      "Löschen Sie eine Tabellenspalte, wenn alle Werte und Ersetzungen leer sind.",
      "如果所有值和替换项均为空，则删除表列。",
      "Eliminar una columna de tabla si todos los valores y sustituciones están vacíos.",  // ES
      "Supprimer une colonne de tableau si toutes les valeurs et substitutions sont vides.",  // FR
      "Tüm değerler ve ikameler boşsa bir tablo sütununu silin." };  // TR

    public static readonly string[] DelRowsText = {
      "Delete Rows",
      "Удалять строки",
      "Elimina righe",
      "Zeilen löschen",
      "删除行",
      "Eliminar filas",                                // ES
      "Supprimer les lignes",                          // FR
      "Satırları sil" };                               // TR

    public static readonly string[] DelRowsTip = {
      "If there are more rows in the table than necessary, delete the extra lines.",
      "Если в таблице больше строк, чем надо - удалить лишние строки.",
      "Se nella tabella sono presenti più righe del necessario, eliminare le righe extra.",
      "Wenn die Tabelle mehr Zeilen als nötig enthält, löschen Sie die zusätzlichen Zeilen.",
      "如果表中的行数超过必要行数，请删除多余的行。",
      "Si hay más filas en la tabla de las necesarias, elimine las líneas adicionales.",  // ES
      "S'il y a plus de lignes dans le tableau que nécessaire, supprimez les lignes supplémentaires.",  // FR
      "Tabloda gerekenden fazla satır varsa, fazladan satırları silin." };  // TR

    public static readonly string[] DestinationTip = {
      "Where to insert the received data.",
      "Куда вставлять полученные данные.",
      "Dove inserire i dati ricevuti.",
      "Wo die empfangenen Daten einzufügen sind.",
      "在哪里插入接收到的数据。",
      "Dónde insertar los datos recibidos.",           // ES
      "Où insérer les données reçues.",                // FR
      "Alınan verilerin nereye ekleneceği." };         // TR

    public static readonly string[] DialogText = {
      "Show Dialog",
      "Показ диалога",
      "Mostra di dialogo",
      "Dialog anzeigen",
      "显示对话框",
      "Mostrar diálogo",                               // ES
      "Afficher le dialogue",                          // FR
      "Diyalogu göster" };                             // TR

    public static readonly string[] DialogTip = {
      "Show the dialog for selecting a table before inserting data, \r\n" +
        "or simply query the selection of a table in a drawing.",
      "Показывать диалог выбора таблицы перед вставкой данных.",
      "Mostra la finestra di dialogo per selezionare una tabella prima di inserire dati, \r\n" +
        "o semplicemente interrogare la selezione di una tabella in un disegno.",
      "Zeigen Sie den Dialog zum Auswählen einer Tabelle vor dem Einfügen \r\n" +
        "von Daten an oder fragen Sie einfach die Auswahl einer Tabelle in einer Zeichnung ab.",
      "在插入数据之前显示用于选择表格的对话框，\r\n" +
        "或者只是在图纸中查询表格的选择。",
      "Mostrar el diálogo para seleccionar una tabla antes de insertar datos, \r\n" +  // ES
        "o simplemente consultar la selección de una tabla en un dibujo.",
      "Afficher le dialogue de sélection d'un tableau avant d'insérer des données, \r\n" +  // FR
        "ou simplement interroger la sélection d'un tableau dans un dessin.",
      "Veri eklemeden önce tablo seçme diyalogunu gösterin, \r\n" +  // TR
        "veya basitçe bir çizimdeki tablo seçimini sorgulayın." };

    public static readonly string[] DwgFolderText = {
      "Dwg Folder",
      "Папка Dwg",
      "Dwg Cartella",
      "Dwg-Ordner",
      "Dwg 文件夹",
      "Carpeta Dwg",                                   // ES
      "Dossier Dwg",                                   // FR
      "Dwg Klasörü" };                                 // TR

    public static readonly string[] DwgFolderTip = {
      "Create a subfolder in the specified folder with the same name as the drawing.",
      "Создать в указанной папке подпапку с таким же именем как у чертежа.",
      "Creare una sottocartella nella cartella specificata con lo stesso nome del disegno.",
      "Erstellen Sie im angegebenen Ordner einen Unterordner mit demselben Namen wie die Zeichnung.",
      "在指定文件夹中创建与图形同名的子文件夹。",
      "Crear una subcarpeta en la carpeta especificada con el mismo nombre que el dibujo.",  // ES
      "Créer un sous-dossier dans le dossier spécifié avec le même nom que le dessin.",  // FR
      "Belirtilen klasörde çizimle aynı ada sahip bir alt klasör oluşturun." };  // TR

    public static readonly string[] FrameText = {
      "Text Frame",
      "Рамка текста",
      "Cornice di testo",
      "Textrahmen",
      "文本框",
      "Marco de texto",                                // ES
      "Cadre de texte",                                // FR
      "Metin çerçevesi" };                             // TR

    public static readonly string[] FrameTip = {
      "Draw a frame around the text.",
      "Прямоугольная рамка вокруг текста",
      "Disegna una cornice attorno al testo.",
      "Ziehen Sie einen Rahmen um den Text.",
      "在文本周围画一个框架。",
      "Dibujar un marco alrededor del texto.",         // ES
      "Dessiner un cadre autour du texte.",            // FR
      "Metnin etrafına bir çerçeve çizin." };          // TR

    public static readonly string[] GroupTitlesText = {
      "Group Titles",
      "Имя группы",
      "Titoli di gruppo",
      "Gruppentitel",
      "组标题",
      "Títulos de grupo",                              // ES
      "Titres de groupe",                              // FR
      "Grup başlıkları" };                             // TR

    public static readonly string[] GroupTitlesTip = {
      "Insert rows with group headers before any group. \r\n" +
        "And set cell-style TITLE",
      "Вставлять строки с заголовками групп перед каждой группой. \r\n" +
        "И присвоить строке стиль НАЗВАНИЕ",
      "Inserisci le righe con le intestazioni di gruppo prima di qualsiasi gruppo. \r\n" +
        "E imposta lo stile cella  TITLE",
      "Zeilen mit Gruppenüberschriften vor jeder Gruppe einfügen. \r\n" +
        "Und setzen Sie TITLE im Zellenstil",
      "在任何组之前插入带有组标题的行。 \r\n" +
        "并设置单元格样式的 TITLE",
      "Insertar filas con encabezados de grupo antes de cualquier grupo. \r\n" +  // ES
        "Y establecer el estilo de celda TITLE",
      "Insérer des lignes avec des en-têtes de groupe avant tout groupe. \r\n" +  // FR
        "Et définir le style de cellule TITLE",
      "Herhangi bir gruptan önce grup başlıklarıyla satırlar ekleyin. \r\n" +  // TR
        "Ve hücre stilini TITLE olarak ayarlayın" };

    public static readonly string[] HeadersText = {
      "Headers",
      "Заголовки",
      "Intestazioni",
      "Überschriften",
      "标头",
      "Encabezados",                                   // ES
      "En-têtes",                                      // FR
      "Başlıklar" };                                   // TR

    public static readonly string[] HeadersTip = {
      "Write column headers in second row of table. \r\n" +
        "Set cell-style HEADER",
      "Вставлять заголовки столбцов во вторую строку таблицы. \r\n" +
        "И присвоить стиль ячеек ЗАГОЛОВОК",
      "Scrivi le intestazioni di colonna nella seconda riga della tabella. \r\n" +
        "Imposta lo stile cella HEADER",
      "Schreiben Sie die Spaltenüberschriften in die zweite Zeile der Tabelle. \r\n" +
        "Legen Sie HEADER im Zellenstil fest",
      "在表格的第二行写入列标题。 \r\n" +
        "设置单元格样式的 HEADER",
      "Escribir encabezados de columna en la segunda fila de la tabla. \r\n" +  // ES
        "Establecer el estilo de celda HEADER",
      "Écrire les en-têtes de colonne dans la deuxième ligne du tableau. \r\n" +  // FR
        "Définir le style de cellule HEADER",
      "Tablonun ikinci satırına sütun başlıklarını yazın. \r\n" +  // TR
        "Hücre stilini HEADER olarak ayarlayın" };

    public static readonly string[] HeadersEachGroup = {
      "In each group",
      "В каждой группе",
      "In ogni gruppo",
      "In jeder Gruppe",
      "在每个组中",
      "En cada grupo",                                 // ES
      "Dans chaque groupe",                            // FR
      "Her grupta" };                                  // TR

    public static readonly string[] HeadersEachGroupTip = {
      "Place column headers after the group name and repeat for each data group. \r\n" +
        "If a table has only one group and title is disabled, the group name will become the table title.\r\n" +
        "If grouping is disabled, this setting is ignored.",
      "Расположить заголовки столбцов после имени группы и повторять в каждой группе данных.\r\n" +
        "Если в таблице только одна группа и отключено заглавие, то имя группы станет заглавием таблицы.\r\n" +
        "Если отключена группировка, то настройка игнорируется.",
      "Posizionare le intestazioni delle colonne dopo il nome del gruppo e ripetere per ogni gruppo di dati. \r\n" +
        "Se una tabella ha un solo gruppo e il titolo è disabilitato, il nome del gruppo diventerà il titolo della tabella.\r\n" +
        "Se il raggruppamento è disabilitato, questa impostazione viene ignorata.",
      "Platzieren Sie die Spaltenüberschriften nach dem Gruppennamen und wiederholen Sie sie für jede Datengruppe. \r\n" +
        "Wenn eine Tabelle nur eine Gruppe hat und der Titel deaktiviert ist, wird der Gruppenname zum Tabellentitel.\r\n" +
        "Wenn die Gruppierung deaktiviert ist, wird diese Einstellung ignoriert.",
      "将列标题放在组名之后，并为每个数据组重复。 \r\n" +
        "如果表格只有一个组且标题被禁用，则组名将成为表格标题。\r\n" +
        "如果禁用分组，则忽略此设置。",
      "Colocar encabezados de columna después del nombre del grupo y repetir para cada grupo de datos. \r\n" +  // ES
        "Si una tabla tiene solo un grupo y el título está deshabilitado, el nombre del grupo se convertirá en el título de la tabla.\r\n" +
        "Si la agrupación está deshabilitada, esta configuración se ignora.",
      "Placer les en-têtes de colonne après le nom du groupe et répéter pour chaque groupe de données. \r\n" +  // FR
        "Si un tableau n'a qu'un seul groupe et que le titre est désactivé, le nom du groupe deviendra le titre du tableau.\r\n" +
        "Si le regroupement est désactivé, ce paramètre est ignoré.",
      "Grup adından sonra sütun başlıklarını yerleştirin ve her veri grubu için tekrarlayın. \r\n" +  // TR
        "Bir tabloda yalnızca bir grup varsa ve başlık devre dışı bırakılmışsa, grup adı tablo başlığı olacaktır.\r\n" +
        "Gruplama devre dışı bırakılmışsa, bu ayar göz ardı edilir." };

    public static readonly string[] MergeGroupTitlesText = {
      "Merge Titles",
      "Объединять",
      "Unisci titoli",
      "Titel zusammenführen",
      "合并标题",
      "Combinar títulos",                              // ES
      "Fusionner les titres",                          // FR
      "Başlıkları birleştir" };                        // TR

    public static readonly string[] MergeGroupTitlesTip = {
      "Merge all cells in Title and Group headers rows.",
      "Объединить название таблицы и заголовки групп в одну ячейку.",
      "Unisci tutte le celle nelle righe delle intestazioni Titolo e Gruppo.",
      "Führen Sie alle Zellen in den Titel- und Gruppenkopfzeilen zusammen.",
      "合并标题和组标题行中的所有单元格。",
      "Combinar todas las celdas en las filas de encabezados de título y grupo.",  // ES
      "Fusionner toutes les cellules dans les lignes d'en-têtes de titre et de groupe.",  // FR
      "Başlık ve Grup başlığı satırlarındaki tüm hücreleri birleştirin." };  // TR

    public static readonly string[] OpenFileText = {
      "Open file",
      "Открыть",
      "Apri il file",
      "Datei öffnen",
      "打开文件",
      "Abrir archivo",                                 // ES
      "Ouvrir le fichier",                             // FR
      "Dosyayı aç" };                                  // TR

    public static readonly string[] OpenFileTip = {
      "Run the program associated with this file type.",
      "Запустить программу ассоциированную с данным типом файлов.",
      "Esegui il programma associato a questo tipo di file.",
      "Führen Sie das diesem Dateityp zugeordnete Programm aus.",
      "运行与此文件类型关联的程序。",
      "Ejecutar el programa asociado con este tipo de archivo.",  // ES
      "Exécuter le programme associé à ce type de fichier.",  // FR
      "Bu dosya türüyle ilişkili programı çalıştırın." };  // TR

    public static readonly string[] ReplaceFileText = {
      "Replace old files",
      "Заменять старые файлы",
      "Sostituisci i vecchi file",
      "Alte Dateien ersetzen",
      "替换旧文件",
      "Reemplazar archivos antiguos",                  // ES
      "Remplacer les anciens fichiers",                // FR
      "Eski dosyaları değiştir" };                     // TR

    public static readonly string[] ReplaceFileTip = {
      "If the file already exists, it must be replaced with a new one. \r\n" +
        "Otherwise, the program will add the version number to the end of the file name.",
      "Если файл с таблицей уже существует, то заменить его. \r\n" +
        "Если не включать данную опцию, то программа сохранит старый файл, \r\n" +
        "а у новой таблицы будет дописан номер версии в конце имени.",
      "Se il file esiste già, deve essere sostituito con uno nuovo. \r\n" +
        "Altrimenti, il programma aggiungerà il numero di versione alla fine del nome del file.",
      "Wenn die Datei bereits existiert, muss sie durch eine neue ersetzt werden. \r\n" +
        "Andernfalls fügt das Programm die Versionsnummer an das Ende des Dateinamens an.",
      "如果该文件已经存在，则必须用新文件替换它。 \r\n" +
        "否则，程序会将版本号添加到文件名的末尾。",
      "Si el archivo ya existe, debe ser reemplazado por uno nuevo. \r\n" +  // ES
        "De lo contrario, el programa agregará el número de versión al final del nombre del archivo.",
      "Si le fichier existe déjà, il doit être remplacé par un nouveau. \r\n" +  // FR
        "Sinon, le programme ajoutera le numéro de version à la fin du nom de fichier.",
      "Dosya zaten mevcutsa, yenisiyle değiştirilmelidir. \r\n" +  // TR
        "Aksi takdirde, program dosya adının sonuna sürüm numarasını ekleyecektir." };

    public static readonly string[] SplitText = {
      "Split Table",
      "Разбить таблицу",
      "Tavolo diviso",
      "Split-Tabelle",
      "拆分表",
      "Dividir tabla",                                 // ES
      "Diviser le tableau",                            // FR
      "Tabloyu böl" };                                 // TR

    public static readonly string[] SplitTip = {
      "Split the table into several sheets (layout) if it does not fit into one sheet. \r\n" +
        "The new sheets will be a copy of the table sheet.",
      "Разбить таблицу на несколько листов (layout), если она не лезет в один лист. \r\n" +
        "Новые листы будут копией листа с таблицей.",
      "Dividi la tabella in più fogli (layout) se non si adatta a un foglio. \r\n" +
        "I nuovi fogli saranno una copia del foglio del tavolo.",
      "Teilen Sie die Tabelle in mehrere Blätter (Layout) auf, wenn sie nicht in ein Blatt passt. \r\n" +
        "Die neuen Blätter sind eine Kopie des Tabellenblatts.",
      "如果表格不适合一张纸，请将其拆分为多张纸（布局）。 \r\n" +
        "新工作表将是表格工作表的副本。",
      "Dividir la tabla en varias hojas (presentación) si no cabe en una hoja. \r\n" +  // ES
        "Las nuevas hojas serán una copia de la hoja de la tabla.",
      "Diviser le tableau en plusieurs feuilles (présentation) s'il ne tient pas dans une seule feuille. \r\n" +  // FR
        "Les nouvelles feuilles seront une copie de la feuille de tableau.",
      "Tablo bir sayfaya sığmıyorsa tabloyu birkaç sayfaya (düzen) bölün. \r\n" +  // TR
        "Yeni sayfalar tablo sayfasının bir kopyası olacaktır." };

    public static readonly string[] SplitterText = {
      "Field separator",
      "Разделитель полей",
      "Spaccalegna",
      "Feldtrenner",
      "字段分隔符",
      "Separador de campos",                           // ES
      "Séparateur de champs",                          // FR
      "Alan ayırıcı" };                                // TR

    public static readonly string[] SplitterTip = {
      "A character to separate columns in one row.",
      "Символ для разделения столбцов в каждой строке.",
      "Un personaggio per separare le colonne in una riga.",
      "Ein Zeichen zum Trennen von Spalten in einer Zeile.",
      "用于分隔一行中的列的字符。",
      "Un carácter para separar columnas en una fila.",  // ES
      "Un caractère pour séparer les colonnes dans une ligne.",  // FR
      "Bir satırdaki sütunları ayırmak için bir karakter." };  // TR

    public static readonly string[] TableStyleText = {
      "Style",
      "Стиль",
      "Stile",
      "Stil",
      "风格",
      "Estilo",                                        // ES
      "Style",                                         // FR
      "Stil" };                                        // TR

    public static readonly string[] TableStyleTip = {
      "Style for creating new tables. \r\n" +
        "Leave the field blank to use the current table style.",
      "Стиль для создания новых таблиц. \r\n" +
        "Оставьте поле пустым, чтоб использовать текущий стиль таблиц.",
      "Stile per la creazione di nuove tabelle. \r\n" +
        "Lascia vuoto il campo per utilizzare lo stile di tabella corrente.",
      "Stil zum Erstellen neuer Tabellen. \r\n" +
        "Lassen Sie das Feld leer, um den aktuellen Tabellenstil zu verwenden.",
      "创建新表的样式。 \r\n" +
        "将该字段留空以使用当前表格样式。",
      "Estilo para crear nuevas tablas. \r\n" +  // ES
        "Deje el campo en blanco para usar el estilo de tabla actual.",
      "Style pour créer de nouveaux tableaux. \r\n" +  // FR
        "Laissez le champ vide pour utiliser le style de tableau actuel.",
      "Yeni tablolar oluşturmak için stil. \r\n" +  // TR
        "Geçerli tablo stilini kullanmak için alanı boş bırakın." };

    public static readonly string[] TextStyleText = {
      "Text style",
      "Стиль текста",
      "Stile del testo",
      "Textstil",
      "文字样式",
      "Estilo de texto",                               // ES
      "Style de texte",                                // FR
      "Metin stili" };                                 // TR

    public static readonly string[] TextStyleTip = {
      "Style for creating new MText. \r\n" +
        "Leave the field blank to use the current text style.",
      "Стиль для нового MText. \r\n" +
        "Оставьте поле пустым, чтоб использовать текущий стиль текстов.",
      "Stile per la creazione di nuovi MText. \r\n" +
        "Lascia vuoto il campo per utilizzare lo stile di testo corrente.",
      "Stil zum Erstellen von neuem MText. \r\n" +
        "Lassen Sie das Feld leer, um den aktuellen Textstil zu verwenden.",
      "用于创建新 MText 的样式。 \r\n" +
        "将该字段留空以使用当前文本样式。",
      "Estilo para crear nuevos MText. \r\n" +  // ES
        "Deje el campo en blanco para usar el estilo de texto actual.",
      "Style pour créer de nouveaux MText. \r\n" +  // FR
        "Laissez le champ vide pour utiliser le style de texte actuel.",
      "Yeni MText oluşturmak için stil. \r\n" +  // TR
        "Geçerli metin stilini kullanmak için alanı boş bırakın." };

    public static readonly string[] TitleTip = {
      "Write the table title (name of setting set) in the first row of table. \r\n" +
        "And set cell-style TITLE",
      "Записать заголовок таблицы (имя набора настроек) в первой строке. \r\n" +
        "Присвоить стиль ячеек НАЗВАНИЕ",
      "Scrivi il titolo della tabella (nome del set di impostazioni) nella prima riga della tabella. \r\n" +
        "E imposta lo stile cella TITLE",
      "Schreiben Sie den Tabellentitel (Name des Einstellungssatzes) in die erste Zeile der Tabelle. \r\n" +
        "Und setzen Sie TITLE im Zellenstil",
      "在表的第一行写表标题（设置集的名称）。 \r\n" +
        "并设置单元格样式的 TITLE",
      "Escribir el título de la tabla (nombre del conjunto de configuración) en la primera fila de la tabla. \r\n" +  // ES
        "Y establecer el estilo de celda TITLE",
      "Écrire le titre du tableau (nom du jeu de paramètres) dans la première ligne du tableau. \r\n" +  // FR
        "Et définir le style de cellule TITLE",
      "Tablonun ilk satırına tablo başlığını (ayar kümesi adı) yazın. \r\n" +  // TR
        "Ve hücre stilini TITLE olarak ayarlayın" };

    public static readonly string[] DwgTableText = {
      "DWG Table",
      "DWG-Таблица",
      "DWG Tavolo",
      "DWG-Tabelle",
      "DWG 表",
      "Tabla DWG",                                     // ES
      "Tableau DWG",                                   // FR
      "DWG Tablosu" };                                 // TR

    public static readonly string[] TableAnchor = {
      "Table Anchor Point",
      "Точка привязки таблицы",
      "Punto di ancoraggio",
      "Ankerpunkt",
      "锚点",
      "Punto de anclaje de la tabla",                  // ES
      "Point d'ancrage du tableau",                    // FR
      "Tablo bağlantı noktası" };                      // TR

    public static readonly string[] TableAnchorTip = {
      "This table corner will be used as the base point when inserting a new table. " +
        "And when expanding or contracting the old table, this corner will retain its position.",
      "Этот угол таблицы будет использован как базовая точка при вставке новой таблицы. " +
        "А при расширении/сжатии старой таблицы, этот угол сохранит свое положение.",
      "Questo angolo della tabella sarà utilizzato come punto base durante l'inserimento di una nuova tabella. " +
        "E durante l'espansione o la contrazione della vecchia tabella, questo angolo manterrà la sua posizione.",
      "Diese Tabellenecke wird als Basispunkt beim Einfügen einer neuen Tabelle verwendet. " +
        "Und beim Erweitern oder Verkleinern der alten Tabelle behält diese Ecke ihre Position bei.",
      "插入新表格时，将使用此表格角作为基点。 " +
        "在扩展或收缩旧表时，此角将保留其位置。",
      "Esta esquina de la tabla se utilizará como punto base al insertar una nueva tabla. " +  // ES
        "Y al expandir o contraer la tabla antigua, esta esquina conservará su posición.",
      "Ce coin du tableau sera utilisé comme point de base lors de l'insertion d'un nouveau tableau. " +  // FR
        "Et lors de l'expansion ou de la contraction de l'ancien tableau, ce coin conservera sa position.",
      "Yeni bir tablo eklenirken bu tablo köşesi temel nokta olarak kullanılacaktır. " +  // TR
        "Ve eski tabloyu genişletirken veya daraltırken, bu köşe konumunu koruyacaktır." };

    public static readonly string[] TopLeft = {
      "Top-Left",
      "Верх-Лево",
      "In alto a sinistra",
      "Oben links",
      "左上角",
      "Arriba-Izquierda",                              // ES
      "En haut à gauche",                              // FR
      "Sol üst" };                                     // TR

    public static readonly string[] TopRight = {
      "Top-Right",
      "Верх-Право",
      "In alto a destra",
      "Oben rechts",
      "右上角",
      "Arriba-Derecha",                                // ES
      "En haut à droite",                              // FR
      "Sağ üst" };                                     // TR

    public static readonly string[] BottomLeft = {
      "Bottom-Left",
      "Низ-Лево",
      "In basso a sinistra",
      "Unten links",
      "左下角",
      "Abajo-Izquierda",                               // ES
      "En bas à gauche",                               // FR
      "Sol alt" };                                     // TR

    public static readonly string[] BottomRight = {
      "Bottom-Right",
      "Низ-Право",
      "In basso a destra",
      "Unten rechts",
      "右下角",
      "Abajo-Derecha",                                 // ES
      "En bas à droite",                               // FR
      "Sağ alt" };                                     // TR

    public static readonly string[] CreateFileText = {
      "Create file",
      "Создание файла",
      "Crea file",
      "Erstelle Datei",
      "创建文件",
      "Crear archivo",                                 // ES
      "Créer un fichier",                              // FR
      "Dosya oluştur" };                               // TR

    public static readonly string[] FillingText = {
      "Table filling",
      "Заполнение таблицы",
      "Riempimento da tavola",
      "Tischfüllung",
      "表格填充",
      "Relleno de tabla",                              // ES
      "Remplissage du tableau",                        // FR
      "Tablo doldurma" };                              // TR

    public static readonly string[] TextText = {
      "Text options",
      "Настройка текста",
      "Opzioni di testo",
      "Textoptionen",
      "文本选项",
      "Opciones de texto",                             // ES
      "Options de texte",                              // FR
      "Metin seçenekleri" };                           // TR

    public static readonly string[] DestinationText = {
      "Destination",
      "Назначение",
      "Destinazione",
      "Ziel",
      "目的地",
      "Destino",                                       // ES
      "Destination",                                   // FR
      "Hedef" };                                       // TR

    public static readonly string[] DirTip = {
      "The name of the folder for saving file with table. \r\n" +
        "If you leave the field blank, the dwg-drawing folder will be used.\r\n" +
        "You can use substitutions of drawing in the folder name.",
      "Имя папки для хранения файлов. \r\n" +
        "Если оставить поле пустым, то будет использована папка dwg-файла. \r\n" +
        "В имени папки можно использовать подстановки свойств файла и времени.",
      "Il nome della cartella per il salvataggio del file con la tabella. \r\n" +
        "Se si lascia il campo vuoto, verrà utilizzata la cartella dwg-drawing. \r\n" +
        "È possibile utilizzare le sostituzioni nel nome della cartella.",
      "Der Name des Ordners zum Speichern der Datei mit Tabelle. \r\n" +
        "Wenn Sie das Feld leer lassen, wird der dwg-Zeichnungsordner verwendet. \r\n" +
        "Sie können Zeichnungsersetzungen im Ordnernamen verwenden.",
      "用于保存文件的文件夹的名称。 \r\n" +
        "如果您将该字段留空，将使用 dwg-drawing 文件夹。\r\n" +
        "您可以在文件夹名称中使用图纸替换。",
      "El nombre de la carpeta para guardar el archivo con la tabla. \r\n" +  // ES
        "Si deja el campo en blanco, se utilizará la carpeta del dibujo dwg.\r\n" +
        "Puede usar sustituciones de dibujo en el nombre de la carpeta.",
      "Le nom du dossier pour enregistrer le fichier avec le tableau. \r\n" +  // FR
        "Si vous laissez le champ vide, le dossier du dessin dwg sera utilisé.\r\n" +
        "Vous pouvez utiliser des substitutions de dessin dans le nom du dossier.",
      "Tablo ile dosyayı kaydetmek için klasör adı. \r\n" +  // TR
        "Alanı boş bırakırsanız, dwg-çizim klasörü kullanılacaktır.\r\n" +
        "Klasör adında çizim ikamelerini kullanabilirsiniz." };

    public static readonly string[] FileTip = {
      "String for you own file name mask. \r\n" +
        "You can use substitutions of drawing and time. \r\n" +
        "Input space string for use the dwg-file name and table title.",
      "Строка для вашей собственной маски имени файла. \r\n" +
        "Вы можете использовать подстановки свойств чертежа и времени. \r\n" +
        "Оставьте поле пустым, чтоб использовать имя dwg-файла и заголовок таблицы.",
      "Stringa per la propria maschera del nome file. \r\n" +
        "È possibile utilizzare sostituzioni di disegno e tempo. \r\n" +
        "Stringa di spazio di input per utilizzare il nome dello stile come il nome del file.",
      "String für Ihre eigene Dateinamensmaske. \r\n" +
        "Sie können Substitutionen von Zeichnung und Zeit verwenden. \r\n" +
        "Geben Sie eine Leerzeichenfolge ein, um den Namen der DWG-Datei und den Tabellentitel zu verwenden.",
      "您自己的文件名掩码的字符串。 \r\n" +
        "您可以使用绘图和时间的替换。 \r\n" +
        "用于使用 dwg 文件名和表标题的输入空间字符串。",
      "Cadena para su propia máscara de nombre de archivo. \r\n" +  // ES
        "Puede usar sustituciones de dibujo y tiempo. \r\n" +
        "Cadena de espacio de entrada para usar el nombre del archivo dwg y el título de la tabla.",
      "Chaîne pour votre propre masque de nom de fichier. \r\n" +  // FR
        "Vous pouvez utiliser des substitutions de dessin et de temps. \r\n" +
        "Chaîne d'espace d'entrée pour utiliser le nom de fichier dwg et le titre du tableau.",
      "Kendi dosya adı maskeniz için dize. \r\n" +  // TR
        "Çizim ve zaman ikamelerini kullanabilirsiniz. \r\n" +
        "Dwg dosya adını ve tablo başlığını kullanmak için boşluk dizesi girin." };

    public static readonly string[] HeightTip = {
      "Text size. \r\n" +
        "Set 0 for use system variable TextSize",
      "Размер шрифта. \r\n" +
        "Назначьте 0, чтоб использовать системную переменную TextSize.",
      "Dimensione del testo. \r\n" +
        "Impostare 0 per l'uso del sistema TextSize variabile",
      "Textgröße. \r\n" +
        "Legen Sie 0 fest, um die Systemvariable TextSize zu verwenden",
      "字体大小。 \r\n" +
        "设置 0 使用系统变量 TextSize",
      "Tamaño del texto. \r\n" +  // ES
        "Establezca 0 para usar la variable del sistema TextSize",
      "Taille du texte. \r\n" +  // FR
        "Définir 0 pour utiliser la variable système TextSize",
      "Metin boyutu. \r\n" +  // TR
        "Sistem değişkeni TextSize'ı kullanmak için 0 ayarlayın" };


  }
}
