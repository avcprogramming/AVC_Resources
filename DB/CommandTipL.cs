// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/


// Ignore Spelling: Dwg Ortho Poly Simp Snn Unhide Det CNC Prg

namespace AVC
{
  /// <summary>
  /// Локализация описаний команд и программ, встроенного магазина программ
  /// </summary>
  public static class
  CommandTipL
  {

    //=====================================================================================================================
    // Program Tips =======================================================================================================

    public static readonly string[] ASimpTip = {
      "Removing unnecessary polyline nodes. " +
        "Horizontal and vertical segments alignment. Closing the polyline.",
      "Удаление лишних узлов полилиний. " +
        "Подравнивание горизонталей и вертикалей. Спрямление сегментов-дуг. Замыкание." ,
      "Rimozione di nodi di polilinea non necessari. " +
        "Allineamento dei segmenti orizzontali e verticali. Chiusura della polilinea.",
      "Entfernen unnötiger Polylinienknoten. " +
        "Horizontale und vertikale Segmentausrichtung. Polylinie schließen.",
      "删除不必要的折线节点。 " +
         "水平和垂直线段对齐。关闭折线。",
      "Eliminación de nodos de polilínea innecesarios. " +
        "Alineación de segmentos horizontales y verticales. Cierre de la polilínea.",
      "Suppression des nœuds de polyligne inutiles. " +
        "Alignement des segments horizontaux et verticaux. Fermeture de la polyligne.",
      "Gereksiz poliçizgi düğümlerinin kaldırılması. " +
        "Yatay ve dikey segmentlerin hizalanması. Poliçizgiyi kapatma."};

    public static readonly string[] AsmTip = {
      "Combine parts into a block assembly. " +
        "Give the block an automatic name based on a pattern with a sequential number. " +
        "Replace the block with a new one while maintaining the attribute values.",
      "Объединить детали в блок-сборку. " +
        "Дать блоку автоматическое имя по шаблону с номером по порядку. " +
        "Подменить блок на новый с сохранением значений атрибутов.",
      "Combina le parti in un assieme di blocco. " +
        "Assegna al blocco un nome automatico basato su uno schema con un numero sequenziale. " +
        "Sostituisci il blocco con uno nuovo mantenendo i valori degli attributi.",
      "Kombinieren Sie Teile zu einer Blockbaugruppe. " +
        "Geben Sie dem Block einen automatischen Namen basierend auf einem Muster mit einer fortlaufenden Nummer. " +
        "Ersetzen Sie den Block durch einen neuen, während Sie die Attributwerte beibehalten.",
      "将零件组合成一个块组件。 " +
         "根据带有序列号的模式为块自动命名。" +
         "在保持属性值的同时用新块替换块。",
      "Combinar piezas en un ensamblaje de bloques. " +
        "Dar al bloque un nombre automático basado en un patrón con número secuencial. " +
        "Reemplazar el bloque con uno nuevo manteniendo los valores de atributos.",
      "Combiner les pièces dans un assemblage de blocs. " +
        "Donner au bloc un nom automatique basé sur un modèle avec un numéro séquentiel. " +
        "Remplacer le bloc par un nouveau tout en conservant les valeurs d'attributs.",
      "Parçaları bir blok montajına birleştirme. " +
        "Bloğa sıralı numaralı bir şablona dayalı otomatik isim verme. " +
        "Öznitelik değerlerini koruyarak bloğu yenisiyle değiştirme."};

    public static readonly string[] AsmCreateTip = {
      "Combine parts into a block assembly. " +
        "Give the block an automatic name based on a pattern with a sequential number.",
      "Объединить детали в блок-сборку. " +
        "Дать блоку автоматическое имя по шаблону с номером по порядку.",
      "Combina le parti in un assieme di blocco. " +
        "Assegna al blocco un nome automatico basato su uno schema con un numero sequenziale.",
      "Kombinieren Sie Teile zu einer Blockbaugruppe. " +
        "Geben Sie dem Block einen automatischen Namen basierend auf einem Muster mit einer fortlaufenden Nummer.",
      "将零件组合成一个块组件。 " +
         "根据带有序列号的模式为块自动命名。",
      "Combinar piezas en un ensamblaje de bloques. " +
        "Dar al bloque un nombre automático basado en un patrón con número secuencial.",
      "Combiner les pièces dans un assemblage de blocs. " +
        "Donner au bloc un nom automatique basé sur un modèle avec un numéro séquentiel.",
      "Parçaları bir blok montajına birleştirme. " +
        "Bloğa sıralı numaralı bir şablona dayalı otomatik isim verme."};

    public static readonly string[] AsmNewTip = {
      "Replace the block with a new one while maintaining the attribute values. " +
        "Give the block an automatic name based on a pattern with a sequential number.",
      "Подменить блок на новый с сохранением значений атрибутов. " +
        "Дать блоку автоматическое имя по шаблону с номером по порядку. ",
      "Sostituisci il blocco con uno nuovo mantenendo i valori degli attributi. " +
        "Assegna al blocco un nome automatico basato su uno schema con un numero sequenziale. ",
      "Ersetzen Sie den Block durch einen neuen, während Sie die Attributwerte beibehalten. " +
        "Geben Sie dem Block einen automatischen Namen basierend auf einem Muster mit einer fortlaufenden Nummer. ",
      "在保持属性值的同时用新的块替换块。 " +
         "根据带有序列号的模式为块自动命名。",
      "Reemplazar el bloque con uno nuevo manteniendo los valores de atributos. " +
        "Dar al bloque un nombre automático basado en un patrón con número secuencial.",
      "Remplacer le bloc par un nouveau tout en conservant les valeurs d'attributs. " +
        "Donner au bloc un nom automatique basé sur un modèle avec un numéro séquentiel.",
      "Öznitelik değerlerini koruyarak bloğu yenisiyle değiştirme. " +
        "Bloğa sıralı numaralı bir şablona dayalı otomatik isim verme."};

    public static readonly string[] AsmDrawTip = {
      "Full automation of assembly drawings for all assembly-blocks in 1 click. " +
        "Copies of assemblies in the model, creation of sheets and viewports, signatures of views, overall dimensions, filling in tables.",
      "Полная автоматизация сборочных чертежей для всех блоков-сборок за 1 клик. " +
        "Копии сборок в модели, создание листов и вьюпортов, подписи видов, габаритные размеры, заполнение таблиц.",
      "Automazione completa dei disegni di assieme per tutti i blocchi di assieme in un solo clic. " +
        "Copie degli assiemi nel modello, creazione di fogli e finestre, firme delle viste, quote di ingombro, compilazione di tabelle.",
      "Vollständige Automatisierung von Baugruppenzeichnungen für alle Baugruppenblöcke mit nur einem Klick. " +
        "Kopien von Baugruppen im Modell, Erstellung von Blättern und Ansichtsfenstern, Signaturen von Ansichten, Gesamtabmessungen, Ausfüllen von Tabellen.",
      "一键即可自动绘制所有装配体模块的装配图。" +
        "在模型中复制装配体，创建图纸和视口，签名视图，标注整体尺寸，填写表格。",
      "Automatización completa de planos de ensamblaje para todos los bloques de ensamblaje en 1 clic. " +
        "Copias de ensamblajes en el modelo, creación de hojas y ventanas gráficas, firmas de vistas, dimensiones generales, llenado de tablas.",
      "Automatisation complète des dessins d'assemblage pour tous les blocs d'assemblage en 1 clic. " +
        "Copies d'assemblages dans le modèle, création de feuilles et de fenêtres, signatures de vues, cotes d'encombrement, remplissage de tableaux.",
      "Tüm montaj blokları için montaj çizimlerinin 1 tıklamayla tam otomasyonu. " +
        "Modelde montaj kopyaları, sayfa ve görünüm penceresi oluşturma, görünüm imzaları, genel boyutlar, tablo doldurma."};

    public static readonly string[] AutoAnnTip = {
      "Automatic inclusion of the Annotation|MD_Annotation layer when creating texts, leaders, dimensions, etc. " +
        "And also disabling snapping and orthogonality.",
      "Автоматическое включение слоя «Аннотации» при создании текстов, выносок, размеров и т.п. " +
        "А так же отключение привязок и ортогональности." ,
      "Inclusione automatica del livello Annotazione durante la creazione di testi, direttrici, quote, ecc. " +
        "Oltre a disabilitare lo snap e l'ortogonalità.",
      "Automatische Einbeziehung der Anmerkungsebene beim Erstellen von Texten, Führungslinien, Bemaßungen usw. " +
        "Sowie das Deaktivieren des Einrastens und der Orthogonalität.",
      "在创建文本、引线、尺寸等时自动包含 Annotation|MD_Annotation 层。" +
         "并且还禁用了捕捉和正交性。",
      "Inclusión automática de la capa Annotation|MD_Annotation al crear textos, directrices, cotas, etc. " +
        "Y también desactivación de referencias a objetos y ortogonalidad.",
      "Inclusion automatique du calque Annotation|MD_Annotation lors de la création de textes, repères, cotes, etc. " +
        "Et également désactivation de l'accrochage et de l'orthogonalité.",
      "Metin, işaret çizgisi, ölçü vb. oluştururken Annotation|MD_Annotation katmanının otomatik dahil edilmesi. " +
        "Ayrıca yakalama ve dik açılılığın devre dışı bırakılması."};

    public static readonly string[] AutoOrthoTip = {
      "Automatic disabling orthogonality when creating texts, leaders, dimensions, etc.",
      "Автоматическое отключение ортогональности при создании текстов, выносок, размеров и т.п." ,
      "Disabilitare automatica l'ortogonalità durante la creazione di testi, direttrici, quote, ecc.",
      "Automatische Deaktivieren der Orthogonalität von Texten, Führungslinien, Bemaßungen usw.",
      "创建文本、引线、尺寸等时自动禁用正交性。",
      "Desactivación automática de la ortogonalidad al crear textos, directrices, cotas, etc.",
      "Désactivation automatique de l'orthogonalité lors de la création de textes, repères, cotes, etc.",
      "Metin, işaret çizgisi, ölçü vb. oluştururken dik açılılığın otomatik devre dışı bırakılması."};

    public static readonly string[] AutoSnapTip = {
      "Automatic disabling snapping when creating texts, leaders, dimensions, etc.",
      "Автоматическое отключение привязок при создании текстов, выносок, размеров и т.п." ,
      "Disabilitare automatica lo snap durante la creazione di testi, direttrici, quote, ecc.",
      "Automatische Deaktivieren des Einrastens von Texten, Führungslinien, Bemaßungen usw.",
      "创建文本、引线、尺寸等时自动禁用捕捉。",
      "Desactivación automática de referencias a objetos al crear textos, directrices, cotas, etc.",
      "Désactivation automatique de l'accrochage lors de la création de textes, repères, cotes, etc.",
      "Metin, işaret çizgisi, ölçü vb. oluştururken yakalamanın otomatik devre dışı bırakılması."};

    public static readonly string[] AutoLngTip = {
      "Keyboard Language automatic switch. " +
        "Command helps to switch the keyboard between English and your native language.",
      "Плагин помогает переключать язык ввода с клавиатуры. " +
        "По командам ввода текстов автоматически включается ваш родной язык. " +
        "По окончании команд – включается английский язык." ,
      "Il plugin aiuta a cambiare la lingua di input della tastiera. " +
        "Quando inserisci comandi di testo, la tua lingua madre viene automaticamente attivata. " +
        "Al termine dei comandi viene attivata la lingua inglese.",
      "Das Plugin hilft beim Umschalten der Tastatureingabesprache. " +
        "Wenn Sie Textbefehle eingeben, wird Ihre Muttersprache automatisch aktiviert. " +
        "Am Ende der Befehle wird die englische Sprache aktiviert.",
      "键盘语言自动切换。 " +
         "命令有助于在英语和您的母语之间切换键盘。",
      "Cambio automático de idioma del teclado. " +
        "El comando ayuda a cambiar el teclado entre inglés y su idioma nativo.",
      "Changement automatique de langue du clavier. " +
        "La commande aide à basculer le clavier entre l'anglais et votre langue maternelle.",
      "Klavye dilinin otomatik değiştirilmesi. " +
        "Komut, klavyeyi İngilizce ve ana diliniz arasında değiştirmeye yardımcı olur."};

    public static readonly string[] AvcOptionsTip = {
      "All A>V>C> plugin settings. User account and licenses.",
      "Все настройки плагинов A>V>C>. Аккаунт пользователя и лицензии.",
      "Tutte le impostazioni del plug-in A>V>C>. Account utente e licenze.",
      "Alle A>V>C>-Plugin-Einstellungen. Benutzerkonto und Lizenzen." ,
      "所有 A>V>C>-插件设置。 用户帐户和许可证。",
      "Todas las configuraciones del complemento A>V>C>. Cuenta de usuario y licencias.",
      "Tous les paramètres du plug-in A>V>C>. Compte utilisateur et licences.",
      "Tüm A>V>C> eklenti ayarları. Kullanıcı hesabı ve lisanslar."};

    public static readonly string[] AvcUpdateTip = {
      "Updating the metric of solids. " +
        "Colorizes solids and faces according to the color of the material. " +
        "Update SmartLeaders.",
      "Обновить метрики всех объектов. " +
        "Раскрасить солиды и их грани в цвета материалов. " +
        "Обновить умные выноски.",
      "Aggiornamento della metrica dei solidi. " +
        "Colora solidi e facce in base al colore del materiale. " +
        "Aggiorna SmartLeaders.",
      "Aktualisieren der Metrik von Feststoffen. " +
        "Färbt Volumenkörper und Flächen entsprechend der Farbe des Materials ein. " +
        "SmartLeader aktualisieren." ,
      "更新固体的度量。 " +
         "根据材质的颜色为实体和面着色。" +
         "更新 SmartLeaders。",
      "Actualización de la métrica de sólidos. " +
        "Colorea sólidos y caras según el color del material. " +
        "Actualizar SmartLeaders.",
      "Mise à jour de la métrique des solides. " +
        "Colore les solides et les faces selon la couleur du matériau. " +
        "Mettre à jour les SmartLeaders.",
      "Katıların metriğinin güncellenmesi. " +
        "Katıları ve yüzeyleri malzeme rengine göre renklendirme. " +
        "SmartLeaders'ı güncelleme."};

    public static readonly string[] BlockMetricTip = {
      "Calculation of block dimensions, the sum of the lengths of all curves, " +
        "area and volume of solids, weight and price of parts. " +
        "Write results to block attributes.",
      "Вычисление габаритов блока, суммы длин всех кривых, " +
        "площади и объема солидов, веса и цены деталей." +
        "Запись результатов в атрибуты блока.",
      "Calcolo delle dimensioni del blocco, somma delle lunghezze di tutte le curve, " +
        "area e volume dei solidi, peso e prezzo delle parti." +
        "Scrivi i risultati per bloccare gli attributi.",
      "Berechnung der Blockabmessungen, der Summe der Längen aller Kurven, " +
        "Fläche und Volumen der Feststoffe, Gewicht und Preis der Teile." +
        "Ergebnisse in Blockattribute schreiben." ,
      "块尺寸的计算，所有曲线长度的总和，" +
         "固体的面积和体积，零件的重量和价格。" +
         "将结果写入块属性。",
      "Cálculo de dimensiones de bloque, suma de longitudes de todas las curvas, " +
        "área y volumen de sólidos, peso y precio de piezas. " +
        "Escribir resultados en atributos de bloque.",
      "Calcul des dimensions du bloc, somme des longueurs de toutes les courbes, " +
        "aire et volume des solides, poids et prix des pièces. " +
        "Écrire les résultats dans les attributs du bloc.",
      "Blok boyutlarının hesaplanması, tüm eğrilerin uzunluklarının toplamı, " +
        "katıların alanı ve hacmi, parçaların ağırlığı ve fiyatı. " +
        "Sonuçları blok özniteliklerine yazma."};

    public static readonly string[] BoxToWallTip = {
      "Create a section of a wooden partition (wall) according to the dimensions of a given solid box",
      "Создать секцию деревянной перегородки (стены) по размерам заданного солида-бокса",
      "Creare una sezione di una parete divisoria in legno (muro) in base alle dimensioni di una determinata scatola solida",
      "Erstellen Sie einen Abschnitt einer hölzernen Trennwand (Wand) entsprechend den Abmessungen eines bestimmten festen Kastens",
      "根据给定实心盒子的尺寸创建木隔板（墙）的一部分",
      "Crear una sección de tabique de madera (pared) según las dimensiones de una caja sólida dada",
      "Créer une section de cloison en bois (mur) selon les dimensions d'une boîte solide donnée",
      "Belirli bir katı kutunun boyutlarına göre ahşap bölme (duvar) bölümü oluşturma"};

    public static readonly string[] BoxToVectorTip = {
      "Create a flat drawing of a wooden partition (wall) according to the dimensions of a given solid-box or block",
      "Создать плоский чертеж деревянной перегородки (стены) по размерам заданного солида-бокса или блока",
      "Crea un disegno piatto di una partizione in legno (muro) " +
        "in base alle dimensioni di una determinata scatola o blocco solido",
      "Erstellen Sie eine flache Zeichnung einer hölzernen Trennwand (Wand) " +
        "entsprechend den Abmessungen eines bestimmten massiven Kastens oder Blocks",
      "根據給定的實心盒子或塊的尺寸創建木質隔間（牆）的平面圖",
      "Crear un dibujo plano de un tabique de madera (pared) según las dimensiones de una caja sólida o bloque dado",
      "Créer un dessin plat d'une cloison en bois (mur) selon les dimensions d'une boîte solide ou d'un bloc donné",
      "Belirli bir katı kutu veya bloğun boyutlarına göre ahşap bölme (duvar) düz çizimi oluşturma"};

    public static readonly string[] BoxFromTableTip = {
      "Create solid boxes and insert blocks based on data From an Excel table",
      "Создать солиды-боксы и расставить блоки по данным из таблицы Excel",
      "Crea scatole solide e disponi i blocchi in base ai dati di una tabella Excel",
      "Erstellen Sie feste Kästchen und ordnen Sie die Blöcke entsprechend den Daten aus einer Excel-Tabelle an.",
      "创建实心框并根据 Excel 表格中的数据排列块。",
      "Crear cajas sólidas e insertar bloques basados en datos de una tabla de Excel",
      "Créer des boîtes solides et insérer des blocs basés sur les données d'un tableau Excel",
      "Excel tablosundaki verilere dayalı olarak katı kutular oluşturma ve bloklar ekleme"};

    public static readonly string[] BUpdateTip = {
      "Replace selected blocks with blocks of the same name From another drawing.",
      "Заменить выбранные блоки на одноименные блоки из другого чертежа." ,
      "Sostituisci i blocchi selezionati con blocchi con lo stesso nome di un altro disegno.",
      "Ersetzen Sie ausgewählte Blöcke durch gleichnamige Blöcke aus einer anderen Zeichnung.",
      "用另一个图形中的同名块替换选定的块。",
      "Reemplazar bloques seleccionados con bloques del mismo nombre de otro dibujo.",
      "Remplacer les blocs sélectionnés par des blocs du même nom d'un autre dessin.",
      "Seçili blokları başka bir çizimden aynı isimdeki bloklarla değiştirme."};

    public static readonly string[] BubenTip = {
      "Try to restore ModelDoc views (created by ViewBase command)",
      "Попытаться восстановить виды ModelDoc (созданные командой ViewBase = ВидБаз)" ,
      "Prova a ripristinare le viste ModelDoc (create dal comando ViewBase)",
      "Versuchen Sie, ModelDoc-Ansichten wiederherzustellen (erstellt durch den Befehl ViewBase).",
      "尝试恢复 ModelDoc 视图（由 ViewBase 命令创建）",
      "Intentar restaurar vistas de ModelDoc (creadas por el comando ViewBase)",
      "Essayer de restaurer les vues ModelDoc (créées par la commande ViewBase)",
      "ModelDoc görünümlerini geri yüklemeyi deneyin (ViewBase komutuyla oluşturulmuş)"};

    public static readonly string[] ChopTip = {
      "Chop a 3d-solid into many pieces. Make ribs and stair-step.",
      "Нарезка твердых тел на равные дольки. " +
        "Ступенчатое заполнение сложных форм. Расстановка ребер." ,
      "Tagliare i solidi a fette uguali. " +
        "Riempimento graduale di moduli complessi. Disposizione delle costole.",
      "Volumenkörpers in gleiche Scheiben schneiden. " +
        "Schrittweises Ausfüllen komplexer Formulare. Anordnung der Rippen.",
      "将固体切成许多块。 " +
         "做肋骨和楼梯。",
      "Cortar un sólido 3D en muchas piezas. Hacer nervaduras y escalones.",
      "Découper un solide 3D en plusieurs morceaux. Créer des nervures et des marches.",
      "3D katıyı birçok parçaya kesme. Kaburga ve basamak yapma."};

    public static readonly string[] ChopEdgeTip = {
      "Chop a 3d-solid into many pieces along a curved edge. Make ribs and stair-step.",
      "Нарезка твердых тел на равные дольки вдоль криволинейного ребра. " +
        "Ступенчатое заполнение сложных форм. Расстановка ребер." ,
      "Affettare i solidi in fette uguali lungo un bordo curvo. " +
        "Compilazione passo di moduli complessi. Disposizione delle costole.",
      "Schneiden von Festkörpern entlang einer gekrümmten Kante in gleiche Scheiben. " +
        "Schrittweises Ausfüllen komplexer Formulare. Anordnung der Rippen.",
      "沿着弯曲的边缘将 3d-solid 切成许多块。 " +
         "做肋骨和楼梯。",
      "Cortar un sólido 3D en muchas piezas a lo largo de un borde curvo. Hacer nervaduras y escalones.",
      "Découper un solide 3D en plusieurs morceaux le long d'un bord incurvé. Créer des nervures et des marches.",
      "3D katıyı kavisli bir kenar boyunca birçok parçaya kesme. Kaburga ve basamak yapma."};

    public static readonly string[] CNumTip = {
      "Numbering of objects by location along a curve, polyline, or spline.",
      "Нумерация объектов по расположению вдоль кривой, полилинии, сплайна." ,
      "Numerazione degli oggetti in base alla posizione all'interno di una curva, polilinea, spline.",
      "Nummerierung von Objekten nach Position innerhalb einer Kurve, Polylinie, Spline.",
      "按曲线、折线、样条线内的位置对对象进行编号。",
      "Numeración de objetos por ubicación a lo largo de una curva, polilínea o spline.",
      "Numérotation des objets par emplacement le long d'une courbe, polyligne ou spline.",
      "Eğri, poliçizgi veya spline boyunca konuma göre nesneleri numaralandırma."};

    public static readonly string[] CPolyTip = {
      "Convert any curves to polylines. Approximation of splines with a given tolerance. " +
        "Projecting 3d curves onto a plane.",
      "Конвертация любых кривых в полилинии. Аппроксимация сплайнов с заданным допуском. " +
        "Проецирование 3d-кривых на плоскость." ,
      "Converti qualsiasi curva in polilinee. Approssimazione di spline con una data tolleranza. " +
        "Proiezione di curve 3d su un piano.",
      "Konvertieren Sie alle Kurven in Polylinien. Approximation von Splines mit einer gegebenen Toleranz. " +
        "Projizieren von 3D-Kurven auf eine Ebene.",
      "将任何曲线转换为多段线。 具有给定公差的样条曲线逼近。 " +
         "将 3d 曲线投影到平面上。",
      "Convertir cualquier curva a polilíneas. Aproximación de splines con una tolerancia dada. " +
        "Proyección de curvas 3D sobre un plano.",
      "Convertir toutes les courbes en polylignes. Approximation de splines avec une tolérance donnée. " +
        "Projection de courbes 3D sur un plan.",
      "Herhangi bir eğriyi poliçizgilere dönüştürme. Belirli bir toleransla spline'ların yaklaşımı. " +
        "3D eğrileri bir düzleme yansıtma."};

    public static readonly string[] CrossPieceTip = {
      "To make the notches in intersecting parts (3D-solids) to connect cross.",
      "Сделать пазы в пересекающихся деталях (солидах) для соединения крестом." ,
      "Creare scanalature nelle parti intersecanti (solidi) per la connessione incrociata.",
      "Machen Sie Nuten in sich kreuzenden Teilen (Volumenkörper) für die Querverbindung.",
      "使相交零件（实体）中的槽口交叉连接。",
      "Hacer muescas en piezas que se cruzan (sólidos 3D) para conectar en cruz.",
      "Faire des encoches dans les pièces qui se croisent (solides 3D) pour connecter en croix.",
      "Kesişen parçalarda (3D katılarda) çapraz bağlantı için çentikler yapma."};

    public static readonly string[] CurveIntTip = {
      "Intersection of closed polylines and curves as regions.",
      "Пересечение замкнутых полилиний и кривых как регионов.",
      "Intersezione di polilinee chiuse e curve come regioni.",
      "Schnittpunkt geschlossener Polylinien und Kurven als Regionen.",
      "作为区域的闭合折线和曲线的交点。",
      "Intersección de polilíneas cerradas y curvas como regiones.",
      "Intersection de polylignes fermées et de courbes en tant que régions.",
      "Kapalı poliçizgilerin ve eğrilerin bölge olarak kesişimi."};

    public static readonly string[] CurveSubTip = {
      "Subtraction of closed polylines and curves as regions. Cutting with open curves.",
      "Вычитание замкнутых полилиний и кривых как регионов. Разрезание разомкнутыми кривыми.",
      "Sottrazione di polilinee e curve chiuse come regioni. Taglio con curve aperte.",
      "Geschlossene Polylinien und Kurven als Regionen subtrahieren. Schneiden mit offenen Kurven.",
      "减去闭合多段线和曲线作为区域。使用开放曲线进行切割。",
      "Resta de polilíneas cerradas y curvas como regiones. Corte con curvas abiertas.",
      "Soustraction de polylignes fermées et de courbes en tant que régions. Découpe avec des courbes ouvertes.",
      "Kapalı poliçizgilerin ve eğrilerin bölge olarak çıkarılması. Açık eğrilerle kesme."};

    public static readonly string[] CurveUnionTip = {
      "Union closed polylines and curves as regions. Join open curves.",
      "Объединение замкнутых полилиний и кривых как регионов. Стыковка разомкнутых кривых.",
      "Combinazione di polilinee e curve chiuse come regioni. Unione di curve aperte.",
      "Geschlossene Polylinien und Kurven als Regionen kombinieren. Offene Kurven verbinden.",
      "将闭合多段线和曲线组合为区域。连接开放曲线。",
      "Unión de polilíneas cerradas y curvas como regiones. Unir curvas abiertas.",
      "Union de polylignes fermées et de courbes en tant que régions. Joindre les courbes ouvertes.",
      "Kapalı poliçizgilerin ve eğrilerin bölge olarak birleştirilmesi. Açık eğrileri birleştirme."};

    public static readonly string[] DadoJointTip = {
      "Formation of dado joinery between 2 contacting solids. Automatic creation dadoes, grooves, pockets, cutouts.",
      "Формирование соединения типа 'паз-шип' на двух соприкасающихся деталях. " +
        "Автоматически делает пазы, канавки, четверти, выборки." ,
      "Formazione di una connessione maschio-femmina su due parti di contatto. " +
        "Crea automaticamente scanalature, scanalature, quarti, tagli.",
      "Bildung einer Nut-Feder-Verbindung an zwei Kontaktteilen. " +
        "Macht automatisch Rillen, Rillen, Viertel, Schnitte.",
      "在两个接触的固体之间形成墙板细木工。 " +
         "自动创建墙裙、凹槽、口袋、切口。",
      "Formación de ensamblaje de espiga y ranura entre 2 sólidos en contacto. Creación automática de ranuras, muescas, rebajes, cortes.",
      "Formation d'assemblage à tenon et mortaise entre 2 solides en contact. Création automatique de rainures, gorges, feuillures, découpes.",
      "2 temas halinde katı arasında zıvana-oluk birleştirmesi oluşturma. Oluk, kanal, çeyrek, kesiklerin otomatik oluşturulması."};

    public static readonly string[] DadoLoopTip =  {
      "Forming a closed polyline for NC-milling dadoes and pockets",
      "Формирование замкнутой полилинии для фрезеровки пазов и выборок на ЧПУ",
      "Formazione di una polilinea chiusa per scanalature, campioni e tasche di fresatura NC",
      "Bildung einer geschlossenen Polylinie zum Fräsen von Nuten und Taschen auf der CNC" ,
      "在 CNC 上形成用于铣槽和选择的闭合折线",
      "Formación de una polilínea cerrada para fresado CNC de ranuras y rebajes",
      "Formation d'une polyligne fermée pour fraisage CNC de rainures et poches",
      "CNC'de oluk ve cep frezeleme için kapalı poliçizgi oluşturma"};

    public static readonly string[] DataTableTip = {
      "Extract properties From any objects, including names and descriptions, attributes, and parameters. " +
        "Writing tables in a drawing, Excel, CSV, XML. Calculation of total results.",
      "Извлечение свойств из любых объектов, включая имена и описания, атрибуты и параметры. " +
        "Запись таблиц в чертеж, Excel, CSV, XML. Подсчет суммарных итогов." ,
      "Estrai proprietà da qualsiasi oggetto, inclusi nomi e descrizione, attributi e parametri. " +
        "Scrittura di tabelle su disegno, Excel, CSV, XML. Calcolo dei totali di riepilogo.",
      "Extrahieren Sie Eigenschaften aus jedem Objekt, einschließlich Namen und Beschreibungen, Attributen und Parametern. " +
        "Schreiben von Tabellen in Zeichnung, Excel, CSV, XML. Berechnung der Gesamtsummen.",
      "从任何对象中提取属性，包括名称和描述、属性和参数。 " +
         "在绘图、Excel、CSV、XML 中编写表格。计算总结果。",
      "Extraer propiedades de cualquier objeto, incluyendo nombres y descripciones, atributos y parámetros. " +
        "Escribir tablas en dibujo, Excel, CSV, XML. Cálculo de resultados totales.",
      "Extraire les propriétés de n'importe quel objet, y compris noms et descriptions, attributs et paramètres. " +
        "Écriture de tableaux dans dessin, Excel, CSV, XML. Calcul des résultats totaux.",
      "Adlar ve açıklamalar, öznitelikler ve parametreler dahil herhangi bir nesneden özellikleri çıkarma. " +
        "Çizim, Excel, CSV, XML'de tablo yazma. Toplam sonuçların hesaplanması."};

    public static readonly string[] DDrawTip = {
      "Full automation of building drawings of all parts 1 click. " +
         "Laying out parts, contours for CNC, creating sheets with viewports, dimensions and annotations, filling in tables.",
      "Полная автоматизация построения чертежей всех деталей 1 клик. " +
        "Выкладка деталей, контуры для ЧПУ, создание листов с вьюпортами, размеры и обозначения, заполнение таблиц.",
      "Automazione completa dei disegni costruttivi di tutte le parti 1 clic." +
         "Disposizione di parti, contorni per CNC, creazione di fogli con finestre, dimensioni e designazioni, riempimento di tabelle.",
      "Vollständige Automatisierung von Bauzeichnungen aller Teile 1 Klick." +
        "Teile auslegen, Konturen für CNC erstellen, Blätter mit Ansichtsfenstern, Maßen und Bezeichnungen erstellen, Tabellen ausfüllen.",
      "所有部分的建筑图纸完全自动化，一键点击。" +
         "为 CNC 布置零件、轮廓，创建带有视口、尺寸和名称的图纸，填写表格。",
      "Automatización completa de planos de construcción de todas las piezas en 1 clic. " +
        "Distribución de piezas, contornos para CNC, creación de hojas con ventanas gráficas, cotas y anotaciones, llenado de tablas.",
      "Automatisation complète des dessins de fabrication de toutes les pièces en 1 clic. " +
        "Mise en page des pièces, contours pour CNC, création de feuilles avec fenêtres, cotes et annotations, remplissage de tableaux.",
      "Tüm parçaların imalat çizimlerinin 1 tıklamayla tam otomasyonu. " +
        "Parça yerleştirme, CNC için konturlar, görünüm pencereleri ile sayfalar oluşturma, boyutlar ve açıklamalar, tablo doldurma."};

    public static readonly string[] DimDetTip = {
      "Arrangement of dimensions and leaders on furniture 3d-solid parts. " +
        "Designations, diameters and positions of drillings. Overall dimensions. Coatings and edge bandings.",
      "Расстановка размеров и выносок на мебельных деталях-солидах. " +
        "Обозначения, диаметры и позиции сверлений. Габариты. Покрытия и кромки." ,
      "Specificare le dimensioni delle parti disposte. Annotazioni di fori e copertine.",
      "Geben Sie die Abmessungen der ausgelegten Teile an. Loch- und Deckelanmerkungen.",
      "家具零件尺寸和引线的排列。 " +
         "钻孔的名称、直径和位置。外形尺寸。涂层和封边条。",
      "Disposición de cotas y directrices en piezas sólidas 3D de muebles. " +
        "Designaciones, diámetros y posiciones de perforaciones. Dimensiones generales. Recubrimientos y cantos.",
      "Disposition de cotes et repères sur pièces solides 3D de meubles. " +
        "Désignations, diamètres et positions de perçages. Cotes d'encombrement. Revêtements et chants.",
      "Mobilya 3D katı parçalarda ölçü ve işaret çizgisi düzenleme. " +
        "Delmelerin isimleri, çapları ve konumları. Genel boyutlar. Kaplamalar ve kenar bantları."};

    public static readonly string[] DimOverallTip = {
      "Get two overall dimensions on all solids and contours by one click.",
      "Простановка двух габаритов на всех солидах и контурах за один клик" ,
      "Impostazione di due dimensioni su tutti i solidi e i contorni con un clic.",
      "Festlegen von zwei Dimensionen für alle Volumenkörper und Konturen mit einem Klick.",
      "一键获取所有实体和轮廓的两个整体尺寸。",
      "Obtener dos dimensiones generales en todos los sólidos y contornos con un clic.",
      "Obtenir deux cotes d'encombrement sur tous les solides et contours en un clic.",
      "Tüm katılarda ve konturlarda tek tıklamayla iki genel boyut alma."};

    public static readonly string[] DrillTip = {
      "1 click - 1000 holes! Command for fast drilling many holes in many 3D-solids.",
      "1 клик - 1000 дырок! Плагин для создания множества отверстий во многих твердых телах одновременно." ,
      "1 clic - 1000 fori! Plugin per creare più fori in molti solidi contemporaneamente.",
      "1 Klick - 1000 Löcher! Plugin zum gleichzeitigen Erstellen mehrerer Löcher in vielen Volumenkörpern.",
      "1 次点击 - 1000 个孔！ 在许多 3D 实体中快速钻孔的命令。",
      "¡1 clic - 1000 agujeros! Comando para perforar rápidamente muchos agujeros en muchos sólidos 3D.",
      "1 clic - 1000 trous ! Commande pour percer rapidement de nombreux trous dans de nombreux solides 3D.",
      "1 tıklama - 1000 delik! Birçok 3D katıda hızlı delik delme komutu."};

    public static readonly string[] DrillTableTip = {
      "List of cylindrical holes in solids. Drilling coordinates and direction. Output to a table or Excel.",
      "Таблица присадки. Список цилиндрических отверстий в солидах. " +
        "Координаты и направление сверления. Вывод в таблицу или в Excel." ,
      "Elenco dei fori cilindrici nei solidi. " +
        "Coordinate e direzione di foratura. Output su una tabella o Excel.",
      "Liste der zylindrischen Löcher in Volumenkörpern. " +
        "Bohrkoordinaten und -richtung. Ausgabe in eine Tabelle oder Excel.",
      "实体中的圆柱孔列表。 " +
         "钻孔坐标和方向。输出到表格或 Excel。",
      "Lista de agujeros cilíndricos en sólidos. Coordenadas y dirección de perforación. Salida a tabla o Excel.",
      "Liste des trous cylindriques dans les solides. Coordonnées et direction de perçage. Sortie vers tableau ou Excel.",
      "Katılardaki silindirik deliklerin listesi. Delme koordinatları ve yönü. Tabloya veya Excel'e çıktı."};

    public static readonly string[] DwgTreeTip = {
      "A panel with a tree-like list of drawing objects. " +
        "All parts, curves, blocks, layers and materials in sorted lists. " +
        "Custom grouping and coloring. " +
        "Zooming and highlighting objects in a drawing.",
      "Панель с древовидным списком объектов чертежа. " +
        "Все детали, кривые, блоки, слои и материалы в сортированных списках. " +
        "Настраиваемая группировка и расцветка. " +
        "Зуммирование и подсветка объектов в чертеже." ,
      "Un pannello con un elenco ad albero di oggetti di disegno. " +
        "Tutte le parti, curve, blocchi, layer e materiali in elenchi ordinati. " +
        "Raggruppamento e colorazione personalizzabili. " +
        "Zoom ed evidenziazione di oggetti in un disegno.",
      "Ein Panel mit einer baumartigen Liste von Zeichnungsobjekten. " +
        "Alle Teile, Kurven, Blöcke, Schichten und Materialien in sortierten Listen. " +
        "Benutzerdefinierte Gruppierung und Farbgebung. " +
        "Zoomen und Hervorheben von Objekten in einer Zeichnung.",
      "具有树状绘图对象列表的面板。 " +
        "排序列表中的所有零件、曲线、块、图层和材质。 " +
        "自定义分组和着色。 缩放并突出显示绘图中的对象。",
      "Panel con lista jerárquica de objetos de dibujo. " +
        "Todas las piezas, curvas, bloques, capas y materiales en listas ordenadas. " +
        "Agrupación y coloración personalizables. " +
        "Zoom y resaltado de objetos en un dibujo.",
      "Panneau avec liste arborescente des objets de dessin. " +
        "Toutes les pièces, courbes, blocs, calques et matériaux dans des listes triées. " +
        "Groupement et coloration personnalisables. " +
        "Zoom et mise en surbrillance des objets dans un dessin.",
      "Çizim nesnelerinin ağaç yapısında listesiyle panel. " +
        "Sıralanmış listelerde tüm parçalar, eğriler, bloklar, katmanlar ve malzemeler. " +
        "Özelleştirilebilir gruplama ve renklendirme. " +
        "Çizimdeki nesneleri yakınlaştırma ve vurgulama."};

    public static readonly string[] DXFExportTip = {
      "Lay details (solids 3d), obtaining flat contours for milling/sawing/drilling on CNC and export of contours in dxf.",
      "Выкладка деталей-солидов, получение контуров для 2d-фрезеровки и экспорт контуров в dxf." ,
      "Disposizione di parti solide, ottenimento di contorni per fresatura 2D ed esportazione di contorni in dxf.",
      "Volumenkörper auslegen, Konturen für das 2D-Fräsen erhalten und Konturen nach dxf exportieren.",
      "放置细节（实体 3d），在 CNC 上获得用于铣削/锯切/钻孔的平面轮廓，并在 dxf 中导出轮廓。",
      "Disposición de piezas (sólidos 3D), obtención de contornos planos para fresado/serrado/perforación en CNC y exportación de contornos en dxf.",
      "Mise en place des pièces (solides 3D), obtention de contours plats pour fraisage/sciage/perçage sur CNC et export des contours en dxf.",
      "Parçaların (3D katılar) yerleştirilmesi, CNC'de frezeleme/kesme/delme için düz konturların elde edilmesi ve konturların dxf'e aktarılması."};

    public static readonly string[] ExposeTip = {
      "Expose all blocks-assemblies in a row. Sign the name and number of blocks.",
      "Выставить все блоки-сборки в ряд. Подписать название и количество блоков.",
      "Imposta tutti i blocchi-assemblies di fila. Firma il nome e il numero di blocchi.",
      "Stellen Sie alle Blöcke-Assemblys in einer Reihe ein. Unterzeichnen Sie den Namen und die Anzahl der Blöcke.",
      "将所有块 - 分配连续设置。 签名名称和块数。",
      "Exponer todos los bloques-ensamblajes en fila. Firmar el nombre y número de bloques.",
      "Exposer tous les blocs-assemblages en ligne. Signer le nom et le nombre de blocs.",
      "Tüm blok-montajları sıraya dizme. Blokların adını ve sayısını imzalama."};

    public static readonly string[] FindNameTip =  {
      "Search for parts and blocks by name, kind and description. Search by mask. Invert the visibility of found objects.",
      "Поиск деталей и блоков по имени, типу и описанию. " +
        "Поиск по маске. Инверсия видимости найденных объектов.",
      "Cerca parti e blocchi per nome, tipo e descrizione. " +
        "Cerca per maschera. Inverte la visibilità degli oggetti trovati.",
      "Suchen Sie nach Teilen und Blöcken nach Name, Typ und Beschreibung. " +
        "Suche nach Maske. Invertieren Sie die Sichtbarkeit gefundener Objekte.",
      "按名称、种类和描述搜索零件和块。 " +
         "按掩码搜索。反转已找到对象的可见性。",
      "Buscar piezas y bloques por nombre, tipo y descripción. Buscar por máscara. Invertir la visibilidad de objetos encontrados.",
      "Rechercher des pièces et des blocs par nom, type et description. Rechercher par masque. Inverser la visibilité des objets trouvés.",
      "Parça ve blokları ad, tür ve açıklamaya göre arama. Maskeye göre arama. Bulunan nesnelerin görünürlüğünü tersine çevirme."};

    public static readonly string[] FilletTip = {
      "Breaks all corners of a polyline and connects the sides with a smooth arc. Able to mate arc segments",
      "Скругление всех углов полилинии." ,
      "Raccorda tutti gli angoli della polilinea.",
      "Verrunden Sie alle Ecken der Polylinie.",
      "打断多段线的所有角并用平滑弧连接边。 能够配合弧段",
      "Redondear todas las esquinas de una polilínea y conectar los lados con un arco suave. Capaz de unir segmentos de arco.",
      "Arrondir tous les coins d'une polyligne et connecter les côtés avec un arc lisse. Capable de raccorder des segments d'arc.",
      "Poliçizginin tüm köşelerini kırma ve kenarları düzgün bir yay ile bağlama. Yay segmentlerini birleştirebilme."};

    public static readonly string[] FixtureTip = {
      "Arrangement of fixtures along joints of solids. RTA fittings, Fasteners, Furniture hinges, Shelf holders, Hardware",
      "Расстановка крепежей на стыке двух деталей: " +
        "эксцентрики, конфирматы, рафиксы, мебельные петли, полкодержатели…" ,
      "Disposizione degli elementi di fissaggio alla giunzione di due parti: " +
        "eccentrici, conferme, Rafix, cerniere per mobili, supporti per mensole ...",
      "Anordnung der Befestigungselemente an der Verbindung zweier Teile: " +
        "Exzenter, Bestätigungen, Rafix, Möbelscharniere, Regalstützen ...",
      "沿固体接头布置固定装置。 " +
         "RTA 配件、紧固件、家具铰链、搁板架、五金",
      "Disposición de herrajes a lo largo de uniones de sólidos. Herrajes RTA, Fijaciones, Bisagras de muebles, Soportes de estantes, Ferretería.",
      "Disposition des ferrures le long des joints de solides. Ferrures RTA, Fixations, Charnières de meubles, Supports d'étagères, Quincaillerie.",
      "Katıların birleşimleri boyunca bağlantı elemanlarının düzenlenmesi. RTA bağlantıları, Tespit elemanları, Mobilya menteşeleri, Raf tutucular, Hırdavat."};

    public static readonly string[] FlatTip = {
      "Generate flat drawing From any AutoCAD objects. Project all on XY",
      "Получить плоский чертеж с любого объекта Автокада. Проецировать все на плоскость XY." ,
      "Ottieni un disegno piatto da qualsiasi oggetto AutoCAD. Proietta tutto sull'aereo XY.",
      "Holen Sie sich eine flache Zeichnung von einem beliebigen AutoCAD-Objekt. " +
        "Projizieren Sie alles auf die XY-Ebene.",
      "从任何 AutoCAD 对象生成平面图。 全部在 XY 上投影.",
      "Generar dibujo plano desde cualquier objeto de AutoCAD. Proyectar todo en XY.",
      "Générer un dessin plat à partir de n'importe quel objet AutoCAD. Projeter tout sur XY.",
      "Herhangi bir AutoCAD nesnesinden düz çizim oluşturma. Tümünü XY üzerine yansıtma."};

    public static readonly string[] HideAvcTip = {
      "Hide AVC palettes From the screen by list. The list can be separated by commas and contain: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Скрыть с экрана палитры AVC по списку. В списке через запятую можно указать: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Nascondi le tavolozze AVC dallo schermo tramite elenco. In un elenco separato da virgole è possibile specificare: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Blenden Sie AVC-Paletten nach Liste auf dem Bildschirm aus. In einer durch Kommas getrennten Liste können Sie Folgendes angeben: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "按列表隐藏屏幕上的 AVC 调色板。在逗号分隔的列表中，您可以指定： AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Ocultar paletas AVC de la pantalla por lista. La lista puede separarse por comas y contener: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Masquer les palettes AVC de l'écran par liste. La liste peut être séparée par des virgules et contenir: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "AVC paletlerini listeye göre ekrandan gizleme. Liste virgülle ayrılabilir ve şunları içerebilir: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List"};

    public static readonly string[] ICTip = {
      "Contours for milling approach in the inside corners",
      "Контуры для захода фрезы во внутренние углы." ,
      "Contorni per l'ingresso della fresa negli angoli interni.",
      "Konturen für den Einstieg des Fräsers in Innenecken.",
      "在内角铣削加工的轮廓.",
      "Contornos para aproximación de fresado en las esquinas interiores.",
      "Contours pour approche de fraisage dans les coins intérieurs.",
      "İç köşelerde freze yaklaşımı için konturlar."};

    public static readonly string[] InfoPaletteTip = {
      "Panel for editing the Info (Description) property for all objects.",
      "Панель для редактирования свойства Инфо(Описание) у всех объектов." ,
      "Pannello per la modifica della proprietà Info (Descrizione) per tutti gli oggetti.",
      "Panel zum Bearbeiten der Info(Beschreibung)-Eigenschaft für alle Objekte.",
      "用于编辑所有对象的信息（描述）属性的面板。",
      "Panel para editar la propiedad Info (Descripción) de todos los objetos.",
      "Panneau pour éditer la propriété Info (Description) pour tous les objets.",
      "Tüm nesneler için Bilgi (Açıklama) özelliğini düzenleme paneli."};

    public static readonly string[] InvertTip = {
      "Isolate selected objects along with those that were previously hidden.",
      "Изолировать выбранные объекты вместе с теми, что были скрыты ранее." ,
      "Isola gli oggetti selezionati insieme a quelli precedentemente nascosti.",
      "Isolieren Sie ausgewählte Objekte zusammen mit den zuvor ausgeblendeten.",
      "将选定对象与之前隐藏的对象隔离开来。",
      "Aislar objetos seleccionados junto con los que estaban previamente ocultos.",
      "Isoler les objets sélectionnés ainsi que ceux qui étaient précédemment masqués.",
      "Seçili nesneleri daha önce gizlenmiş olanlarla birlikte yalıtma."};

    public static readonly string[] GapTip = {
      "Subtraction of solids with a gap.",
      "Вычитание твердых тел с зазором." ,
      "Sottrazione di solidi con uno spazio vuoto.",
      "Subtraktion von Volumenkörpers mit einer Lücke.",
      "减去有间隙的实体。",
      "Resta de sólidos con un espacio.",
      "Soustraction de solides avec un espace.",
      "Boşluklu katıların çıkarılması."};

    public static readonly string[] Kit3dTip = {
      "Software suite for 3d modeling and utilities to speed up work. " +
        "This collection does NOT include work with 2D contours and tables",
      "Комплект программ для 3D-моделирования и утилиты для ускорения работы. " +
        "В это сборник НЕ входит работа с контурами 2D и таблицами" ,
      "Suite software per modellazione 3D e utilità per velocizzare il lavoro. " +
        "Questa raccolta NON include il lavoro con contorni 2D e tabelle",
      "Software-Suite für 3D-Modellierung und Dienstprogramme zur Beschleunigung der Arbeit. " +
        "Diese Sammlung enthält KEINE Arbeiten mit 2D-Konturen und -Tabellen",
      "用于 3D 建模和实用程序的软件套件，可加快工作速度。 " +
         "这个集合不包括使用 2D 轮廓和表格的工作",
      "Suite de software para modelado 3D y utilidades para acelerar el trabajo. " +
        "Esta colección NO incluye trabajo con contornos 2D y tablas.",
      "Suite logicielle pour la modélisation 3D et utilitaires pour accélérer le travail. " +
        "Cette collection N'inclut PAS le travail avec des contours 2D et des tableaux.",
      "3D modelleme ve işi hızlandırmak için araçlar yazılım paketi. " +
        "Bu koleksiyon 2D konturlar ve tablolarla çalışmayı İÇERMEZ."};

    public static readonly string[] Kit2dTip = {
      "A set of programs for working with polylines and other curves, contour optimization for CNC and utilities for speeding up work." +
        "This collection does NOT include work with 3d solids, tables, and annotations.",
      "Комплект программ для работы с полилиниями и другими кривыми, оптимизации контуров для ЧПУ и утилиты для ускорения работы. " +
        "В это сборник НЕ входит работа с солидами, таблицами, аннотациями.",
      "Un set di programmi per lavorare con polilinee e altre curve, ottimizzazione dei contorni per CNC e utilità per velocizzare il lavoro." +
        "Questa raccolta NON include il lavoro con solidi 3D, tabelle e annotazioni.",
      "Eine Reihe von Programmen zum Arbeiten mit Polylinien und anderen Kurven, Konturoptimierung für CNC und Dienstprogramme zur Beschleunigung der Arbeit. " +
        "Diese Sammlung enthält KEINE Arbeiten mit 3D-Volumenkörpern, Tabellen und Anmerkungen.",
      "一组用于处理折线和其他曲线、CNC轮廓优化和加速工作实用程序的程序。" +
        "这个集合不包括使用 3d 实体、表格和注释的工作。",
      "Conjunto de programas para trabajar con polilíneas y otras curvas, optimización de contornos para CNC y utilidades para acelerar el trabajo. " +
        "Esta colección NO incluye trabajo con sólidos 3D, tablas y anotaciones.",
      "Ensemble de programmes pour travailler avec des polylignes et d'autres courbes, optimisation de contours pour CNC et utilitaires pour accélérer le travail. " +
        "Cette collection N'inclut PAS le travail avec des solides 3D, des tableaux et des annotations.",
      "Poliçizgiler ve diğer eğrilerle çalışma, CNC için kontur optimizasyonu ve işi hızlandırmak için araçlar programlar seti. " +
        "Bu koleksiyon 3D katılar, tablolar ve açıklamalarla çalışmayı İÇERMEZ."};

    public static readonly string[] LayTip = {
      "Lay 3D-solids to XY plane. Group and sort list of details. Creating headers.",
      "Выкладка 3D-деталей в плоскость XY. Группировка и сортировка деталей. Создание заголовков." ,
      "Posa solidi 3D sul piano XY. Raggruppa e ordina l'elenco dei dettagli. Creazione di intestazioni.",
      "Legen Sie Volumenkörper auf die XY-Ebene. Gruppieren und sortieren Sie die Liste der Details. Überschriften erstellen.",
      "将 '三维实体'平放到 XY 平面。 对图形进行分组和排序，生成二维图形。可用于后期制作工艺图纸、CNC、等。",
      "Colocar sólidos 3D en el plano XY. Agrupar y ordenar lista de detalles. Crear encabezados.",
      "Placer les solides 3D sur le plan XY. Grouper et trier la liste des détails. Créer des en-têtes.",
      "3D katıları XY düzlemine yerleştirme. Detay listesini gruplama ve sıralama. Başlıklar oluşturma."};

    public static readonly string[] LeaderUpdateTip = {
      "Refresh all or selected Smart Leaders by real objects under the arrow.",
      "Обновить все или выбранные Умные Выноски по реальным объектам под стрелкой." ,
      "Aggiorna tutti o selezionati Leader Intelligente (Smart Leader) con oggetti reali sotto la freccia.",
      "Aktualisieren Sie alle oder ausgewählte Intelligenter Führungslinien (Smart Leader) " +
        "nach realen Objekten unter dem Pfeil.",
      "通过箭头下的真实对象刷新所有或选定的智能引线。",
      "Actualizar todas o las directrices inteligentes seleccionadas según los objetos reales bajo la flecha.",
      "Actualiser tous les repères intelligents ou sélectionnés selon les objets réels sous la flèche.",
      "Tüm veya seçili Akıllı İşaret Çizgilerini ok altındaki gerçek nesnelere göre yenileme."};
    public static readonly string[] MarkTip = {
      "Inserting texts or blocks with part marks in a drawing. Info-Points for data extraction.",
      "Расстановка в чертеже текстов или блоков с обозначениями деталей. Инфо-точки для извлечения данных. " ,
      "Disposizione di testi o blocchi con numeri di parte nel disegno. Infopoint per il recupero dei dati.",
      "Anordnung von Texten oder Blöcken mit Teilenummern in der Zeichnung. Infopoints zum Abrufen von Daten.",
      "在工程图中插入带有零件标记的文本或块。 用于数据提取的信息点。",
      "Insertar textos o bloques con marcas de piezas en un dibujo. Info-Puntos para extracción de datos.",
      "Insérer des textes ou des blocs avec des marques de pièces dans un dessin. Info-Points pour l'extraction de données.",
      "Çizimde parça işaretleri olan metinler veya bloklar ekleme. Veri çıkarma için Bilgi Noktaları."};

    public static readonly string[] KindPaletteTip = {
      "Panel for editing the Kind property for all objects.",
      "Панель для редактирования свойства Сорт у всех объектов." ,
      "Pannello per la modifica della proprietà Tipo per tutti gli oggetti.",
      "Panel zum Bearbeiten der Art-Eigenschaft für alle Objekte.",
      "用于编辑所有对象的 Kind 属性的面板。",
      "Panel para editar la propiedad Tipo de todos los objetos.",
      "Panneau pour éditer la propriété Type pour tous les objets.",
      "Tüm nesneler için Tür özelliğini düzenleme paneli."};

    public static readonly string[] MNumTip = {
      "Write the number to the drawing objects click by click. " +
        "Insert numbers into Text, Leader, Table cell, Block attribute. " +
        "Change the name of a block, solid, polyline or any other object.",
      "Записать номер объектам чертежа клик за кликом. " +
        "Вставить номера в Текст, Выноску, Ячейку таблицы, Атрибут блока. " +
        "Поменять имя блоку, солиду, полилинии или любому другому объекту." ,
      "Scrivi il numero degli oggetti di disegno clic per clic. " +
        "Inserisci i numeri in Testo, Direttrice, Cella di tabella, Attributo di blocco. " +
        "Cambia il nome di un blocco, solido, polilinea o qualsiasi altro oggetto.",
      "Schreiben Sie die Nummer auf die Zeichenobjekte Klick für Klick. " +
        "Fügen Sie Zahlen in Text, Führungslinie, Tabellenzelle, Blockattribut ein. " +
        "Ändern Sie den Namen eines Blocks, Volumenkörpers, einer Polylinie oder eines anderen Objekts.",
      "将编号逐个单击地写入绘图对象。" +
         "在文本、引线、表格单元格、块属性中插入数字。" +
         "更改块、实体、多段线或任何其他对象的名称。",
      "Escribir el número a los objetos de dibujo clic por clic. " +
        "Insertar números en Texto, Directriz, Celda de tabla, Atributo de bloque. " +
        "Cambiar el nombre de un bloque, sólido, polilínea o cualquier otro objeto.",
      "Écrire le numéro aux objets de dessin clic par clic. " +
        "Insérer des numéros dans Texte, Repère, Cellule de tableau, Attribut de bloc. " +
        "Changer le nom d'un bloc, solide, polyligne ou tout autre objet.",
      "Çizim nesnelerine tıklayarak numara yazma. " +
        "Metin, İşaret Çizgisi, Tablo hücresi, Blok özniteliğine numara ekleme. " +
        "Blok, katı, poliçizgi veya diğer herhangi bir nesnenin adını değiştirme."};

    public static readonly string[] MatTableTip = {
      "Extraction of data on materials of solids, materials of their surfaces. " +
        "Lists of materials, coatings, paints, bandings. " +
        "Calculation of material consumption (taking into account scraps), total weight and price. " +
        "Writing tables in a drawing, Excel, CSV, XML.",
      "Извлечение данных о материалах твердых тел (солидов), материалов их поверхностей. " +
        "Списки материалов, покрытий, покрасок, кромок. " +
        "Подсчет расхода материалов с учетом обрезков, суммарный вес и цена. " +
        "Запись таблиц в чертеж, Excel, CSV, XML." ,
      "Estrazione di dati su materiali di solidi, materiali delle loro superfici. " +
        "Elenchi di materiali, rivestimenti, vernici, bordi. Calcolo del consumo di materiale, tenendo conto degli scarti, del peso totale e del prezzo. Scrittura di tabelle su disegno, Excel, CSV, XML.",
      "Extraktion von Daten über Materialien von Volumenkörper, Materialien ihrer Oberflächen. " +
        "Listen von Materialien, Beschichtungen, Farben, Kanten. " +
        "Berechnung des Materialverbrauchs unter Berücksichtigung von Abfällen, Gesamtgewicht und Preis. " +
        "Schreiben von Tabellen in Zeichnung, Excel, CSV, XML.",
      "提取固体材料及其表面材料的数据。 " +
         "材料、涂料、油漆、绑带清单。" +
         "计算材料消耗（考虑到废料）、总重量和价格。" +
         "在绘图、Excel、CSV、XML 中编写表格。",
      "Extracción de datos sobre materiales de sólidos, materiales de sus superficies. " +
        "Listas de materiales, recubrimientos, pinturas, cantos. " +
        "Cálculo de consumo de material (teniendo en cuenta desechos), peso total y precio. " +
        "Escribir tablas en dibujo, Excel, CSV, XML.",
      "Extraction de données sur les matériaux des solides, matériaux de leurs surfaces. " +
        "Listes de matériaux, revêtements, peintures, chants. " +
        "Calcul de la consommation de matériau (en tenant compte des chutes), poids total et prix. " +
        "Écriture de tableaux dans dessin, Excel, CSV, XML.",
      "Katıların malzemeleri, yüzeylerinin malzemeleri hakkında veri çıkarma. " +
        "Malzemeler, kaplamalar, boyalar, bantlar listesi. " +
        "Malzeme tüketimi hesaplama (atıklar dikkate alınarak), toplam ağırlık ve fiyat. " +
        "Çizim, Excel, CSV, XML'de tablo yazma."};

    public static readonly string[] MeshToSolidTip = {
      "Convert Polyface Meshes and regular Meshes to 3D Solids. Connecting of meshes.",
      "Преобразование многогранных сетей (PolyFaceMesh) и обычных сетей (Mesh) в солиды. Объединение сетей.",
      "Converti mesh poliedriche (PolyFaceMesh) e mesh regolari (Mesh) in solide. Consolidamento delle reti.",
      "Konvertieren Sie polyedrische Netze (PolyFaceMesh) und reguläre Netze (Mesh) in Volumenkörper. " +
        "Konsolidierung von Netzwerken.",
      "将多面网格 (PolyFaceMesh) 和普通网格 (Mesh) 转换为实体。 网络统一。",
      "Convertir Mallas Polifaciales y Mallas regulares a Sólidos 3D. Conexión de mallas.",
      "Convertir les Maillages Polyfacettes et les Maillages réguliers en Solides 3D. Connexion de maillages.",
      "Çok Yüzlü Ağları ve normal Ağları 3D Katılara dönüştürme. Ağların birleştirilmesi."};

    public static readonly string[] MeshExplodeTip = {
      "Explode Polyface Meshes and regular Meshes to lines.",
      "Взрывать многогранные сети и обычные сети на линии.",
      "Esplodere mesh polifacciali e mesh regolari in linee.",
      "Explodieren von Polyface Meshes und regulären Meshes zu Linien.",
      "在线上炸开多面体网和规则网。",
      "Explotar Mallas Polifaciales y Mallas regulares a líneas.",
      "Éclater les Maillages Polyfacettes et les Maillages réguliers en lignes.",
      "Çok Yüzlü Ağları ve normal Ağları çizgilere patlama."};

    public static readonly string[] MiterTip = {
      "Cutting the solid along the bisector of the angle of joining of two surfaces.",
      "Разрезание твердого тела (солида) по биссектрисе угла от линейного ребра" ,
      "Taglio del solido 3d lungo la bisettrice dell'angolo di unione di due superfici.",
      "Schneiden des Volumenkörpers entlang der Winkelhalbierenden des Verbindungswinkels zweier Oberflächen.",
      "从直线边沿角平分线切割刚体（实体）",
      "Cortar el sólido a lo largo de la bisectriz del ángulo de unión de dos superficies.",
      "Couper le solide le long de la bissectrice de l'angle de jonction de deux surfaces.",
      "Katıyı iki yüzeyin birleşme açısının açıortayı boyunca kesme."};

    public static readonly string[] MultiSliceTip = {
      "Cutting off many solid surfaces. Creating a Miter joint. " +
        "Modeling columns and walls From particleboard/plywood in 1 click.",
      "Отслоение многих поверхностей солидов. Стыки под ус. " +
        "Моделирование колонн и стен из ДСП за 1 клик." ,
      "Distacco di molte superfici solide. " +
        "Creazione di un giunto ad angolo. Modellazione di colonne e pareti da truciolare in 1 clic.",
      "Schneiden Sie viele Volumenkörpers Oberflächen ab. " +
        "Gehrungsfuge erstellen. Modellierung von Säulen und Wänden aus Spanplatten mit 1 Klick.",
      "许多固体表面的分离。 小胡子下的关节。" +
         "一键从刨花板上建模柱子和墙壁。",
      "Cortar muchas superficies sólidas. Crear una unión a inglete. " +
        "Modelar columnas y paredes de aglomerado/contrachapado en 1 clic.",
      "Découper de nombreuses surfaces solides. Créer un joint à onglet. " +
        "Modéliser des colonnes et des murs en aggloméré/contreplaqué en 1 clic.",
      "Birçok katı yüzeyi kesme. Gönye birleştirme oluşturma. " +
        "Yonga levha/kontrplaktan sütunları ve duvarları 1 tıklamayla modelleme."};

    public static readonly string[] NamePaletteTip = {
      "Panel for editing the Name property for all objects.",
      "Панель для редактирования свойства Имя у всех объектов." ,
      "Pannello per la modifica della proprietà Nome per tutti gli oggetti.",
      "Panel zum Bearbeiten der Name-Eigenschaft für alle Objekte.",
      "用于编辑所有对象的名称属性的面板。",
      "Panel para editar la propiedad Nombre de todos los objetos.",
      "Panneau pour éditer la propriété Nom pour tous les objets.",
      "Tüm nesneler için Ad özelliğini düzenleme paneli."};

    public static readonly string[] NCPTip = {
      "Preparing part contours From 3D solids. " +
        "Polylines for milling, sawing, drilling on CNC with processing parameters in layer names. " +
        "Calling the Dimensions program.",
      "Подготовка контуров деталей по 3D-солидам. " +
        "Полилинии для фрезерования, пиления, сверления на ЧПУ с параметрами обработки в именах слоев. " +
        "Вызов программы расстановки размеров.",
      "Preparazione dei contorni delle parti da solidi 3D. " +
        "Polilinee per fresatura, segagione, foratura su CNC con parametri di lavorazione nei nomi dei layer. " +
        "Chiamando il programma Dimensions.",
      "Erstellen von Teilekonturen aus 3D-Volumenkörpern. " +
        "Polylinien zum Fräsen, Sägen, Bohren auf CNC mit Bearbeitungsparametern in Schichtnamen. " +
        "Aufruf des Dimensionsprogramms.",
      "从 3D 实体准备零件轮廓。 用于在 CNC 上进行铣削、锯切、钻孔的折线，层名称中包含加工参数。 调用维度程序。",
      "Preparar contornos de piezas desde sólidos 3D. " +
        "Polilíneas para fresado, serrado, perforación en CNC con parámetros de procesamiento en nombres de capas. " +
        "Llamar al programa de Dimensiones.",
      "Préparer les contours de pièces à partir de solides 3D. " +
        "Polylignes pour fraisage, sciage, perçage sur CNC avec paramètres de traitement dans les noms de calques. " +
        "Appeler le programme de Dimensions.",
      "3D katılardan parça konturları hazırlama. " +
        "Katman adlarında işleme parametreleri ile CNC'de frezeleme, kesme, delme için poliçizgiler. " +
        "Boyutlar programını çağırma."};

    public static readonly string[] NumberingTip = {
      "Name the drawing objects as sequential numbers.",
      "Дать объектам чертежа имена как номера по порядку. " +
        "Сэкономит время при работе с командами Выкладка, Таблица напилки, Маркировка, Умная выноска.",
      "Assegna un nome agli oggetti di disegno come numeri sequenziali.",
      "Benennen Sie die Zeichnungsobjekte als fortlaufende Nummern." ,
      "将绘图对象名称作为序号。" +
         "在使用布局、锯床、标记、智能引线命令时节省时间。",
      "Nombrar los objetos de dibujo como números secuenciales.",
      "Nommer les objets de dessin comme numéros séquentiels.",
      "Çizim nesnelerini sıralı numaralar olarak adlandırma."};

    public static readonly string[] OffsetManyTip = {
      "A thousand displaced curves in 1 click. " +
        "Repeated and bilateral offset. Layer change. Removing the source.",
      "Тысяча смещенных контуров за 1 клик. " +
        "Повторный и двусторонний офсет. Смена слоя. Удаление исходных." ,
      "Migliaia di percorsi di offset in 1 clic. " +
        "Offset ripetuto e bilaterale. Cambio di strato. Rimozione dell'originale.",
      "Tausende versetzte Pfade mit einem Klick. " +
        "Wiederholter und zweiseitiger Versetz. Layer-wechseln. Original entfernen.",
      "数以千计的偏移轮廓一键点击。 "+
         "重复和双面偏移。图层更改。删除原始。",
      "Mil curvas desplazadas en 1 clic. " +
        "Equidistancia repetida y bilateral. Cambio de capa. Eliminar el origen.",
      "Mille courbes décalées en 1 clic. " +
        "Décalage répété et bilatéral. Changement de calque. Supprimer la source.",
      "1 tıklamada bin kaydırılmış eğri. " +
        "Tekrarlı ve çift taraflı ofset. Katman değişikliği. Kaynağı kaldırma."};

    public static readonly string[] OpenAvcTip = {
      "Open AVC palettes From the list. The list can be separated by commas and contain: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Открыть палитры AVC по списку. В списке через запятую можно указать: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Apri le tavolozze AVC per elenco. In un elenco separato da virgole è possibile specificare: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Öffnen Sie AVC-Paletten nach Liste. In einer durch Kommas getrennten Liste können Sie Folgendes angeben: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "按列表打开 AVC 调色板。在逗号分隔的列表中，您可以指定： AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Abrir paletas AVC desde la lista. La lista puede separarse por comas y contener: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "Ouvrir les palettes AVC à partir de la liste. La liste peut être séparée par des virgules et contenir: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List",
      "AVC paletlerini listeden açma. Liste virgülle ayrılabilir ve şunları içerebilir: AVC,DwgTree,Options,Name,Kind,Info,User0..User19,All,Main,Text,List"};

    public static readonly string[] OSLTip = {
      "Join segments to closed polyline. " +
        "Convert any curves to polylines. Approximation of splines with a given tolerance. Contour optimization.",
      "Формирование замкнутых полилиний из любых кривых. " +
        "Аппроксимация сплайнов с заданным допуском. Чистка и оптимизация контуров." ,
      "Formazione di polilinee chiuse da qualsiasi curva. " +
        "Approssimazione di spline con una data tolleranza. Pulizia e ottimizzazione dei contorni.",
      "Bilden geschlossener Polylinien aus beliebigen Kurven. " +
        "Approximation von Splines mit einer gegebenen Toleranz. Reinigung und Optimierung von Konturen.",
      "从任何曲线形成闭合多段线。 "+
         "具有给定公差的样条曲线逼近。轮廓的清洁和优化。",
      "Unir segmentos a polilínea cerrada. " +
        "Convertir cualquier curva a polilíneas. Aproximación de splines con tolerancia dada. Optimización de contornos.",
      "Joindre les segments à une polyligne fermée. " +
        "Convertir toutes les courbes en polylignes. Approximation de splines avec une tolérance donnée. Optimisation de contours.",
      "Segmentleri kapalı poliçizgiye birleştirme. " +
        "Herhangi bir eğriyi poliçizgilere dönüştürme. Belirli toleransla spline yaklaşımı. Kontur optimizasyonu."};

    public static readonly string[] PageNoTip = {
      "Numbering of drawing sheets in one DWG file. " +
        "Drawing up a table of contents.",
      "Нумерация листов чертежа в одном dwg файле. " +
        "Составление оглавления." ,
      "Numerazione dei fogli di disegno in un file dwg. " +
        "Stesura di un sommario.",
      "Nummerierung der Zeichenblätter in einer DWG-Datei. " +
        "Erstellen eines Inhaltsverzeichnisses.",
      "一个 dwg 文件中的图纸编号。 "+
         "创建标题。",
      "Numeración de hojas de dibujo en un archivo DWG. " +
        "Elaborar una tabla de contenidos.",
      "Numérotation des feuilles de dessin dans un fichier DWG. " +
        "Élaborer une table des matières.",
      "Bir DWG dosyasında çizim sayfalarının numaralandırılması. " +
        "İçindekiler tablosu oluşturma."};

    public static readonly string[] PaletteTip = {
      "New property panel. The NAME property for all objects. " +
        "Creating layers. Size of solids, editing covers and edge bandings. " +
        "Density and price of materials. Adding block attributes. Polyline revers",
      "Новая панель свойств. Имя у всех объектов. " +
        "Размеры солидов. Плотность и цена материалов. Редактирование покрытий и кромок. " +
        "Добавление атрибутов блоков. Реверс полилиний" ,
      "Nuovo pannello delle proprietà. Nome per tutti gli oggetti. " +
        "Le dimensioni del solido. Densità e prezzo dei materiali. Modifica rivestimenti e bordi. " +
        "Aggiunta di attributi di blocco. Polilinee inverse",
      "Neues Eigenschaftenfenster. Name für alle Objekte. " +
        "Die Größen des Volumenkörpers. Dichte und Materialpreis. Bearbeiten von Abdeckungen und Kanten. " +
        "Blockattribute hinzufügen. Polylinien umkehren",
      "新的属性面板。 所有对象的名称。" +
         "固体的大小。材料的密度和价格。涂层和边缘的编辑。" +
         "添加块属性。反向多段线",
      "Nuevo panel de propiedades. La propiedad NOMBRE para todos los objetos. " +
        "Crear capas. Tamaño de sólidos, editar recubrimientos y cantos. " +
        "Densidad y precio de materiales. Agregar atributos de bloque. Invertir polilíneas.",
      "Nouveau panneau de propriétés. La propriété NOM pour tous les objets. " +
        "Créer des calques. Taille des solides, éditer revêtements et chants. " +
        "Densité et prix des matériaux. Ajouter attributs de bloc. Inverser polylignes.",
      "Yeni özellik paneli. Tüm nesneler için AD özelliği. " +
        "Katman oluşturma. Katıların boyutu, kaplama ve kenar bantlarını düzenleme. " +
        "Malzemelerin yoğunluğu ve fiyatı. Blok öznitelikleri ekleme. Poliçizgi ters çevirme."};

    public static readonly string[] PlaceLeadersTip = {
      "Create multileaders with the names of each selected object or for all viewport objects",
      "Создать мультивыноски с именами каждого выбранного объекта или для всех объектов видового экрана" ,
      "Crea multidirettrici con i nomi di ogni oggetto selezionato o per tutti gli oggetti della finestra",
      "Erstellen Sie Multi-Führungslinien mit den Namen jedes ausgewählten Objekts oder für alle Ansichtsfensterobjekte",
      "使用每个选定对象或所有视口对象的名称创建多重引线",
      "Crear directrices múltiples con los nombres de cada objeto seleccionado o para todos los objetos de ventana gráfica.",
      "Créer des repères multiples avec les noms de chaque objet sélectionné ou pour tous les objets de fenêtre.",
      "Her seçili nesnenin veya tüm görünüm penceresi nesnelerinin adlarıyla çoklu işaret çizgileri oluşturma."};

    public static readonly string[] PLineDirTip = {
      "Change the direction of multiple polylines and other curves. Select the starting points of the polylines.",
      "Поменять направление у множества полилиний и других кривых. Выбрать начальные точки полилиний.",
      "Cambiare la direzione di più polilinee e altre curve. Selezionare i punti iniziali delle polilinee.",
      "Ändern Sie die Richtung mehrerer Polylinien und anderer Kurven. Wählen Sie die Startpunkte der Polylinien aus.",
      "更改多个多段线和其他曲线的方向。选择多段线的起点。",
      "Cambiar la dirección de múltiples polilíneas y otras curvas. Seleccionar los puntos iniciales de las polilíneas.",
      "Changer la direction de plusieurs polylignes et autres courbes. Sélectionner les points de départ des polylignes.",
      "Birden fazla poliçizginin ve diğer eğrilerin yönünü değiştirme. Poliçizgilerin başlangıç noktalarını seçme."};

    public static readonly string[] ProTip = {
      "A complete set of all A>V>C> programs: " +
        "Modeling commands, utilities, commands for working with contours, preparing drawings for CNC, " +
        "preparing tables",
      "Полный комплект из всех программ A>V>C>: " +
        "Команды моделирования, утилиты, команды работы с контурами, подготовки чертежей для ЧПУ, подготовки таблиц" ,
      "Un set completo di tutti i programmi A>V>C>: " +
        "comandi di modellazione, utilità, comandi per lavorare con contorni, preparazione di disegni per CNC, " +
        "preparazione di tabelle",
      "Ein vollständiger Satz aller A>V>C>-Programme: " +
        "Modellierungsbefehle, Dienstprogramme, Befehle zum Arbeiten mit Konturen, " +
        "Erstellen von Zeichnungen für die CNC, Vorbereiten von Tabellen",
      "全套所有程序 A>V>C>: " +
         "建模命令、实用程序、用于处理轮廓的命令、为 CNC 准备图纸、准备表格",
      "Un conjunto completo de todos los programas A>V>C>: " +
        "Comandos de modelado, utilidades, comandos para trabajar con contornos, preparar dibujos para CNC, " +
        "preparar tablas.",
      "Un ensemble complet de tous les programmes A>V>C>: " +
        "Commandes de modélisation, utilitaires, commandes pour travailler avec des contours, préparer des dessins pour CNC, " +
        "préparer des tableaux.",
      "Tüm A>V>C> programlarının eksiksiz seti: " +
        "Modelleme komutları, araçlar, konturlarla çalışma komutları, CNC için çizim hazırlama, " +
        "tablo hazırlama."};

    public static readonly string[] PTTTip = {
      "Insert text table From the Windows clipboard into the DWG-table. " +
        "Splitting of long tables into layouts.",
      "Вставка текстовых таблиц из буфера Windows в DWG-таблицу. " +
        "Разбиение длинных таблиц на листы." ,
      "Inserimento di tabelle di testo dagli appunti di Windows nella tabella di DWG. " +
        "Rompere lunghi tavoli in fogli.",
      "Einfügen von Texttabellen aus der Windows-Zwischenablage in die DWG-Tabelle. " +
        "Aufteilen langer Tabellen in Blätter.",
      "将文本表格从 Windows 剪贴板粘贴到 DWG 表格中。" +
         "将长表拆分为工作表。",
      "Insertar tabla de texto desde el portapapeles de Windows en la tabla DWG. " +
        "División de tablas largas en diseños.",
      "Insérer une table de texte depuis le presse-papiers Windows dans la table DWG. " +
        "Division des longues tables en présentations.",
      "Windows panosundan DWG tablosuna metin tablosu ekleme. " +
        "Uzun tabloları düzenlere bölme."};

    public static readonly string[] ReduceWTip = {
      "Cut through windows or pockets in free places of the part to reduce its weight.",
      "Вырезать сквозные окна или выборки (карманы) в свободных местах детали, чтоб уменьшить ее вес.",
      "Tagliare finestre o tasche in punti liberi della parte per ridurne il peso.",
      "Schneiden Sie Fenster oder Taschen an freien Stellen des Teils durch, um sein Gewicht zu reduzieren.",
      "在零件的自由位置切开窗口或口袋以减轻其重量。",
      "Cortar ventanas o bolsillos en lugares libres de la pieza para reducir su peso.",
      "Découper des fenêtres ou des poches dans les endroits libres de la pièce pour réduire son poids.",
      "Parçanın boş yerlerinde ağırlığını azaltmak için pencereler veya cepler kesme."};

    public static readonly string[] RemHolesTip = {
      "Find and remove all cylindrical holes in all solid parts, even inside assembly blocks.",
      "Поиск и удаление всех круглых отверстий во всех деталях-солидах, даже внутри блоков-сборок." ,
      "Trova e rimuovi tutti i fori cilindrici in tutte le parti solide, anche all'interno dei blocchi di assieme.",
      "Finden und entfernen Sie alle zylindrischen Löcher in allen massiven Teilen, sogar innerhalb von Montageblöcken.",
      "查找并移除所有实体零件中的所有圆孔，甚至在块组件内部。",
      "Encontrar y eliminar todos los agujeros cilíndricos en todas las piezas sólidas, incluso dentro de bloques de ensamblaje.",
      "Trouver et supprimer tous les trous cylindriques dans toutes les pièces solides, même à l'intérieur des blocs d'assemblage.",
      "Montaj blokları içinde bile tüm katı parçalardaki tüm silindirik delikleri bulma ve kaldırma."};

    public static readonly string[] SawTip = {
      "The measurement of solids. List of its dimension for sawing|cutting.",
      "Обмер твердых тел. Таблица их размеров для распиловки/раскроя. " +
        "Вставка списков в таблицы Автокада или в Excel." ,
      "Misura di solidi. Tabella delle loro dimensioni per segare / tagliare. " +
        "Inserisci elenchi in tabelle AutoCAD o Excel.",
      "Messung von Volumenkörper. Tabelle ihrer Größen zum Sägen / Schneiden. " +
        "Fügen Sie Listen in AutoCAD-Tabellen oder Excel ein.",
      "测量固体。 用于锯切/切割的尺寸表。"+
         "将列表插入 AutoCAD 表或 Excel。",
      "Medición de sólidos. Lista de sus dimensiones para serrado/corte. " +
        "Insertar listas en tablas de AutoCAD o Excel.",
      "Mesure des solides. Liste de ses dimensions pour sciage/découpe. " +
        "Insérer des listes dans des tableaux AutoCAD ou Excel.",
      "Katıların ölçümü. Kesme/kesim için boyut listesi. " +
        "AutoCAD tablolarına veya Excel'e liste ekleme."};

    public static readonly string[] SawRedTip = {
      "Selected solids are colored depending on the manufacturing technology. " +
        "If the Technology property = Box or Sweep or Saw, then the details are assigned a red color. " +
        "If the Technology  property = Milling, then green.",
      "Окрасить выбранные твердые тела в зависимости от технологии изготовления. " +
        "Если свойство Технология = Бокс или Развертка или Напилка, то деталям присваивается красный цвет. " +
        "Если свойство Технология = Фрезерование, то зеленый.",
      "I solidi selezionati sono colorati a seconda della tecnologia di produzione. " +
        "Se la proprietà Tecnologia = Box o Sweep o Saw, ai dettagli viene assegnato un colore rosso. " +
        "Se la proprietà Tecnologia = Fresatura, allora verde.",
      "Ausgewählte Feststoffe sind je nach Herstellungstechnologie eingefärbt. " +
        "Wenn die Eigenschaft Technologie = Box oder Sweep oder Saw ist, wird den Details eine rote Farbe zugewiesen. " +
        "Wenn die Eigenschaft Technologie = Fräsen, dann grün.",
      "根据制造技术对选定的固体进行着色。" +
         "如果 Technology 属性 = Box 或 Reamer 或 Sawing，则零件被指定为红色。" +
         "如果技术属性 = 铣削，则为绿色。",
      "Los sólidos seleccionados se colorean según la tecnología de fabricación. " +
        "Si la propiedad Tecnología = Box o Sweep o Saw, se asigna color rojo a los detalles. " +
        "Si la propiedad Tecnología = Fresado, entonces verde.",
      "Les solides sélectionnés sont colorés en fonction de la technologie de fabrication. " +
        "Si la propriété Technologie = Box ou Sweep ou Saw, les détails reçoivent une couleur rouge. " +
        "Si la propriété Technologie = Fraisage, alors vert.",
      "Seçili katılar üretim teknolojisine göre renklendiriliyor. " +
        "Teknoloji özelliği = Box veya Sweep veya Saw ise, detaylara kırmızı renk atanır. " +
        "Teknoloji özelliği = Frezeleme ise yeşil."};

    public static readonly string[] SelectSameTip = {
      "Quick select same objects in drawing. " +
        "Search for block by attribute and parameter, Search for solids by face color.",
      "Поиск похожих объектов в чертеже, поиск блоков по атрибутам и параметрам, поиск солидов по цвету граней" ,
      "Cerca oggetti simili in un disegno, cerca blocchi per attributi e parametri, cerca solidi per colore della faccia",
      "Suchen Sie nach ähnlichen Objekten in einer Zeichnung, " +
        "suchen Sie nach Blöcken nach Attributen und Parametern, suchen Sie nach Volumenkörpern nach Gesichtsfarbe",
      "在图纸中搜索相似对象，按属性和参数搜索块，按面颜色搜索实体",
      "Selección rápida de objetos iguales en dibujo. " +
        "Buscar bloque por atributo y parámetro, Buscar sólidos por color de cara.",
      "Sélection rapide des mêmes objets dans le dessin. " +
        "Rechercher un bloc par attribut et paramètre, Rechercher des solides par couleur de face.",
      "Çizimde aynı nesneleri hızlı seçme. " +
        "Öznitelik ve parametreye göre blok arama, Yüz rengine göre katı arama."};

    public static readonly string[] SelectSameAgainTip = {
      "Search for a similar object without queries. " +
        "The search parameters From the last call to the SelectSame command will be used.",
      "Поиск похожего объекта без запросов. " +
        "Используются параметры поиска из последнего вызова команды SelectSame.",
      "Cerca un oggetto simile senza query. " +
        "Verranno utilizzati i parametri di ricerca dell'ultima chiamata al comando SelectSame.",
      "Suchen Sie ohne Abfragen nach einem ähnlichen Objekt. " +
        "Es werden die Suchparameter vom letzten Aufruf des SelectSame-Befehls verwendet.",
      "无需查询即可搜索类似对象。" +
         "正在使用上次调用 SelectSame 命令的搜索参数。",
      "Buscar un objeto similar sin consultas. " +
        "Se utilizarán los parámetros de búsqueda de la última llamada al comando SelectSame.",
      "Rechercher un objet similaire sans requêtes. " +
        "Les paramètres de recherche du dernier appel à la commande SelectSame seront utilisés.",
      "Sorgusuz benzer nesne arama. " +
        "SelectSame komutuna yapılan son çağrıdan arama parametreleri kullanılacak."};

    public static readonly string[] SimpInFilesTip = {
      "Simplify polylines and other curves in many drawings at once.",
      "Упрощение полилиний и других кривых во многих чертежах сразу.",
      "Semplifica polilinee e altre curve in più disegni contemporaneamente.",
      "Vereinfachen Sie Polylinien und andere Kurven in vielen Zeichnungen gleichzeitig.",
      "一次简化多段线和其他图形中的曲线。",
      "Simplificar polilíneas y otras curvas en muchos dibujos a la vez.",
      "Simplifier les polylignes et autres courbes dans plusieurs dessins à la fois.",
      "Birçok çizimde poliçizgileri ve diğer eğrileri aynı anda basitleştirme."};

    public static readonly string[] SliceTip = {
      "Quick and smart similar SLICE command. Delamination (peeling) flat and curved faces of solid.",
      "Быстрый и умный аналог команды Slice (Разрез). " +
        "Отслоение плоских и криволинейных поверхностей твердого тела." ,
      "Una controparte rapida e intelligente del comando Slice." +
        " Delaminazione di superfici piane e curve di un solido.",
      "Ein schnelles und intelligentes Gegenstück zum Kappen-Befehl. " +
        "Delaminierung von flachen und gekrümmten Oberflächen eines Volumenkörpers.",
      "Slice 命令的快速智能模拟。 "+
         "剥离实体的平面和曲面。",
      "Comando SLICE similar rápido e inteligente. Delaminación (pelado) de caras planas y curvas de sólido.",
      "Commande SLICE similaire rapide et intelligente. Délamination (pelage) des faces planes et courbes du solide.",
      "Hızlı ve akıllı benzer SLICE komutu. Katının düz ve kavisli yüzlerinin delaminasyonu (soyulması)."};

    public static readonly string[] SmartLeaderTip = {
      "MLeaders looking for an object under the arrow and fill the text for itself.",
      "Выноски ищут объект под стрелкой и сами заполняют себе текст." ,
      "Multileaders che cercano un oggetto sotto la freccia e riempiono il testo da solo.",
      "Führungslinien suchen nach einem Objekt unter dem Pfeil und füllen den Text für sich aus.",
      "标注在箭头下方查找对象并自行填写文本。",
      "Directrices múltiples que buscan un objeto bajo la flecha y llenan el texto por sí mismas.",
      "Repères multiples qui cherchent un objet sous la flèche et remplissent le texte eux-mêmes.",
      "Ok altındaki nesneyi arayan ve metni kendisi dolduran çoklu işaret çizgileri."};

    public static readonly string[] SnnTip = {
      "Select object without name",
      "Найти и выбрать все объекты, которым забыли дать имя." ,
      "Seleziona oggetto senza nome",
      "Objekt ohne Namen auswählen",
      "查找并选择您忘记命名的所有对象。",
      "Seleccionar objeto sin nombre",
      "Sélectionner un objet sans nom",
      "İsimsiz nesne seçme"};

    public static readonly string[] SolSizeTip = {
      "Measurement of solid, regardless of position in space. " +
        "The resulting dimensions are output to the command line.",
      "Измерение твердого тела независимо от положения в пространстве. " +
        "Полученные размеры выводятся в командную строку." ,
      "Misura del solido, indipendentemente dalla posizione nello spazio. " +
        "Le dimensioni risultanti vengono inviate alla riga di comando.",
      "Messung von Festkörpern, unabhängig von der Position im Raum. " +
        "Die resultierenden Abmessungen werden an die Befehlszeile ausgegeben.",
      "无论在空间中的位置如何，都可以测量刚体。" +
         "生成的尺寸将输出到命令行。",
      "Medición de sólido, independientemente de su posición en el espacio. " +
        "Las dimensiones resultantes se envían a la línea de comandos.",
      "Mesure du solide, quelle que soit sa position dans l'espace. " +
        "Les dimensions résultantes sont envoyées à la ligne de commande.",
      "Uzaydaki konumundan bağımsız olarak katının ölçümü. " +
        "Elde edilen boyutlar komut satırına çıktılanır."};

    public static readonly string[] SolidSubTip = {
      "Subtraction of solids without a gap, preserving face coloring, preserving the subtrahend.",
      "Вычитание твердых тел без зазора, сохранение расцветки граней, сохранение вычитаемого.",
      "Sottrazione di solidi senza spazio, mantenendo la colorazione delle facce, preservando il sottraendo.",
      "Subtraktion von Volumenkörpern ohne Lücke, Erhaltung der Flächenfärbung, Erhaltung des Subtrahenden.",
      "无间隙减去实体，保留面着色，保留被减数。",
      "Resta de sólidos sin espacio, preservando la coloración de caras, preservando el sustraendo.",
      "Soustraction de solides sans espace, préservation de la coloration des faces, préservation du sous-trahend.",
      "Boşluksuz katı çıkarma, yüz renklerini koruma, çıkanı koruma."};

    public static readonly string[] SolidSubPrgTip = {
      "Subtraction, intersection, and union of solids. With or without a gap. Preserving material and face coloring. Preserving source objects and the subtrahend.",
      "Вычитание, пересечение и объединение твердых тел. С зазором или без. Сохранение материала и расцветки граней. Сохранение исходников и вычитаемого.",
      "Sottrazione, intersezione e unione di solidi. Con o senza spazio. Mantenimento della colorazione delle facce. Conservazione degli oggetti sorgente e del sottraendo.",
      "Subtraktion, Schnittmenge und Vereinigung von Volumenkörpern. Mit oder ohne Lücke. Erhaltung der Flächenfärbung. Erhaltung der Quelldatenobjekte und des Subtrahenden.",
      "实体的减法、交集和并集。有间隙或无间隙。保留面部着色。保留源对象和被减数。",
      "Resta, intersección y unión de sólidos. Con o sin espacio. Preservando material y coloración de caras. Preservando objetos fuente y el sustraendo.",
      "Soustraction, intersection et union de solides. Avec ou sans espace. Préservation du matériau et de la coloration des faces. Préservation des objets source et du sous-trahend.",
      "Katıların çıkarma, kesişim ve birleşimi. Boşluklu veya boşluksuz. Malzeme ve yüz renklerini koruma. Kaynak nesneleri ve çıkanı koruma."};

    public static readonly string[] SolidIntTip = {
      "Intersection of solids, preserving face coloring, preserving the source objects.",
      "Пересечение твердых тел, сохранение расцветки граней, сохранение исходников.",
      "Intersezione di solidi, mantenendo la colorazione delle facce, conservando gli oggetti sorgente.",
      "Schnittmenge von Volumenkörpern, Erhaltung der Flächenfärbung, Erhaltung der Quelldatenobjekte.",
      "实体的交集，保留面部着色，保留源对象。",
      "Intersección de sólidos, preservando la coloración de caras, preservando los objetos fuente.",
      "Intersection de solides, préservation de la coloration des faces, préservation des objets source.",
      "Katıların kesişimi, yüz renklerini koruma, kaynak nesneleri koruma."};

    public static readonly string[] SolidUnionTip = {
      "Union of solids, preserving face coloring, preserving the source objects.",
      "Объединение твердых тел, сохранение расцветки граней, сохранение исходников.",
      "Unione di solidi, mantenendo la colorazione delle facce, conservando gli oggetti sorgente.",
      "Vereinigung von Volumenkörpern, Erhaltung der Flächenfärbung, Erhaltung der Quelldatenobjekte.",
      "实体的并集，保留面部着色，保留源对象。",
      "Unión de sólidos, preservando la coloración de caras, preservando los objetos fuente.",
      "Union de solides, préservation de la coloration des faces, préservation des objets source.",
      "Katıların birleşimi, yüz renklerini koruma, kaynak nesneleri koruma."};

    public static readonly string[] StStTip = {
      "Makes a flat solid rung, that is, makes the side faces orthogonal to the front face.",
      "Делает ступеньку из плоского твердого тела, то есть делает боковые грани ортогональными к лицевой грани." ,
      "Crea un piolo solido piatto, ovvero rende le facce laterali ortogonali alla faccia anteriore.",
      "Erzeugt eine flache Volumenkörpers, dh macht die Seitenflächen orthogonal zur Vorderseite.",
      "从平面实体迈出一步，即使侧面与正面正交。",
      "Hace un peldaño sólido plano, es decir, hace las caras laterales ortogonales a la cara frontal.",
      "Crée un barreau solide plat, c'est-à-dire rend les faces latérales orthogonales à la face avant.",
      "Düz katı basamak yapar, yani yan yüzleri ön yüze dik yapar."};

    public static readonly string[] SweepSizeTip = {
      "Measurement of twisted/sweeped solid is similar to SolSize. " +
        "One of the dimensions of the solid is measured along the length of its curved edge.",
      "Измерение искривленного/скрученного твердого тела аналогично SolSize. " +
        "Один из размеров твердого тела измеряется по длине его криволинейного ребра." ,
      "La misurazione del solido contorto/spazzato è simile a SolSize. " +
        "Una delle dimensioni del solido viene misurata lungo la lunghezza del suo bordo curvo.",
      "Die Messung von verdrillten/geschwungenen Festkörpern erfolgt ähnlich wie bei SolSize. " +
        "Eine der Abmessungen des Volumenkörpers wird entlang seiner gekrümmten Kante gemessen.",
      "测量翘曲/扭曲的固体类似于 SolSize。" +
         "固体的尺寸之一是通过其曲线边缘的长度来测量的。",
      "La medición de sólido torcido/barrido es similar a SolSize. " +
        "Una de las dimensiones del sólido se mide a lo largo de la longitud de su borde curvo.",
      "La mesure du solide torsadé/balayé est similaire à SolSize. " +
        "Une des dimensions du solide est mesurée le long de la longueur de son bord incurvé.",
      "Bükülmüş/süpürülmüş katının ölçümü SolSize'a benzer. " +
        "Katının boyutlarından biri kavisli kenarının uzunluğu boyunca ölçülür."};

    public static readonly string[] SumLenTip = {
      "Calculates the sum of the lengths of all selected drawing objects: lines, arcs, and polylines",
      "Вычисляет сумму длин всех выбранных объектов чертежа: линий, дуг и полилиний." ,
      "Calcola la somma delle lunghezze di tutti gli oggetti di disegno selezionati: linee, archi e polilinee",
      "Berechnet die Summe der Längen aller ausgewählten Zeichenobjekte: Linien, Bögen und Polylinien",
      "计算所有选定绘图对象的长度总和：直线、圆弧和多段线。",
      "Calcula la suma de las longitudes de todos los objetos de dibujo seleccionados: líneas, arcos y polilíneas.",
      "Calcule la somme des longueurs de tous les objets de dessin sélectionnés : lignes, arcs et polylignes.",
      "Seçili tüm çizim nesnelerinin uzunluklarının toplamını hesaplar: çizgiler, yaylar ve poliçizgiler."};

    public static readonly string[] SumAreaTip = {
      "Calculates the sum of the areas of all selected drawing objects: " +
        "closed polylines, circles, ellipses, and splines",
      "Вычисляет сумму площадей всех выбранных объектов рисования: " +
        "замкнутых полилиний, окружностей, эллипсов и сплайнов." ,
      "Calcola la somma delle aree di tutti gli oggetti di disegno selezionati: " +
        "polilinee chiuse, cerchi, ellissi e spline",
      "Berechnet die Summe der Flächen aller ausgewählten Zeichenobjekte: " +
        "geschlossene Polylinien, Kreise, Ellipsen und Splines",
      "计算所有选定绘图对象的面积之和：" +
         "闭合的折线、圆、椭圆和样条曲线。",
      "Calcula la suma de las áreas de todos los objetos de dibujo seleccionados: " +
        "polilíneas cerradas, círculos, elipses y splines.",
      "Calcule la somme des aires de tous les objets de dessin sélectionnés : " +
        "polylignes fermées, cercles, ellipses et splines.",
      "Seçili tüm çizim nesnelerinin alanlarının toplamını hesaplar: " +
        "kapalı poliçizgiler, daireler, elipsler ve spline'lar."};

    public static readonly string[] TableFillTip = {
      "Fill in the drawing tables based on its title, extracting data From all sheet views.",
      "Заполнить таблицы чертежа на основе ее заголовка, извлекая данные из всех видов листа.",
      "Compilare le tabelle di disegno in base al titolo, estraendo i dati da tutte le viste del foglio.",
      "Füllen Sie die Zeichnungstabellen basierend auf ihrem Titel aus und extrahieren Sie Daten aus allen Blattansichten.",
      "根据标题填写图纸表，从所有图纸视图中提取数据。",
      "Rellenar las tablas de dibujo basándose en su título, extrayendo datos de todas las vistas de hoja.",
      "Remplir les tableaux de dessin en fonction de leur titre, en extrayant les données de toutes les vues de feuille.",
      "Tüm sayfa görünümlerinden veri çıkararak başlığına göre çizim tablolarını doldurma."};

    public static readonly string[] TableSplitTip = {
      "Splitting of long dwg-tables into layouts.",
      "Разбиение длинных dwg-таблиц на листы (layout)." ,
      "Suddivisione di lunghe tabelle dwg in layout.",
      "Aufteilen langer dwg-Tabellen in Layouts.",
      "将长 dwg 表拆分为工作表（布局）。",
      "División de tablas dwg largas en presentaciones.",
      "Division de longues tables dwg en présentations.",
      "Uzun dwg tablolarını düzenlere bölme."};

    public static readonly string[] TableUpdateTip = {
      "Refill the drawing tables with the old settings, extracting data From the same objects.",
      "Заполнить таблицы чертежа заново со старыми настройками, извлекая данные из тех же объектов." ,
      "Ripopolare le tabelle di disegno con le vecchie impostazioni, estraendo i dati dagli stessi oggetti.",
      "Füllen Sie die Zeichnungstabellen erneut mit den alten Einstellungen und extrahieren Sie Daten aus denselben Objekten.",
      "使用旧设置重新填充绘图表，从相同对象中提取数据。",
      "Rellenar las tablas de dibujo con la configuración antigua, extrayendo datos de los mismos objetos.",
      "Remplir à nouveau les tableaux de dessin avec les anciens paramètres, en extrayant les données des mêmes objets.",
      "Aynı nesnelerden veri çıkararak eski ayarlarla çizim tablolarını yeniden doldurma."};

    public static readonly string[] TabSlotTip = {
      "Modeling the connection of two parts using a series of tabs(pins) at the end of one part " +
        "and a series of slots(dadoes) on the plane of another part.",
      "Моделирование соединения двух деталей с помощью ряда штырей на торце одной детали " +
        "и ряда пазов на плоскости другой детали",
      "Modellazione della connessione di due parti mediante una serie di perni all'estremità di una parte " +
        "e una serie di asole sul piano di un'altra parte.",
      "Modellieren der Verbindung zweier Teile mit einer Reihe von Laschen (Stiften) am Ende eines Teils " +
        "und einer Reihe von Schlitzen auf der Ebene eines anderen Teils.",
      "使用一个零件末端的一系列销和另一个零件平面上的一系列槽对两个零件的连接进行建模。",
      "Modelado de la conexión de dos piezas usando una serie de lengüetas(espigas) al final de una pieza " +
        "y una serie de ranuras en el plano de otra pieza.",
      "Modélisation de la connexion de deux pièces à l'aide d'une série de languettes(tenons) à l'extrémité d'une pièce " +
        "et d'une série de fentes(rainures) sur le plan d'une autre pièce.",
      "Bir parçanın sonunda bir dizi dil(pim) ve başka bir parçanın düzleminde bir dizi yuva kullanarak iki parçanın bağlantısını modelleme."};

    public static readonly string[] TextHeightTip = {
      "Resize the Model Space MultiText and Texts to the scale of the current viewport.",
      "Подогнать размер МультиТекстов пространства модели под масштаб текущего видового экрана." ,
      "Ridimensionare il multitesto dello spazio modello alla scala della finestra corrente.",
      "Ändern Sie die Größe des Model Space MultiText auf den Maßstab des aktuellen Ansichtsfensters.",
      "将模型空间多文本和文本的大小调整为当前视口的比例。",
      "Redimensionar el Texto Múltiple del Espacio Modelo y Textos a la escala de la ventana gráfica actual.",
      "Redimensionner le Texte Multiple de l'Espace Objet et les Textes à l'échelle de la fenêtre actuelle.",
      "Model Alanı Çoklu Metni ve Metinleri geçerli görünüm penceresinin ölçeğine yeniden boyutlandırma."};

    public static readonly string[] TNTTip = {
      "Explosion of assembly. Moving apart solids in space for an illustration of the form of the assembly.",
      "Раздвигание твердых тел в пространстве для получения наглядного вида сборки." ,
      "Espansione di solidi nello spazio per una vista visiva dell'assieme.",
      "Ausdehnen von Volumenkörper im Raum für eine visuelle Ansicht der Baugruppe.",
      "在空间中扩展实体以获得装配体的可视化视图。",
      "Explosión de ensamblaje. Separación de sólidos en el espacio para una ilustración de la forma del ensamblaje.",
      "Explosion d'assemblage. Écartement des solides dans l'espace pour une illustration de la forme de l'assemblage.",
      "Montaj patlaması. Montajın şeklinin gösterimi için uzayda katıları birbirinden ayırma."};

    public static readonly string[] TNTUpdateTip = {
      "Refresh blocks that were exploded by the TNT command.",
      "Обновить блоки, которые были разнесены командой TNT." ,
      "Aggiorna i blocchi che sono stati esplosi dal comando TNT.",
      "Aktualisieren Sie Blöcke, die durch den TNT-Befehl aufgelöst wurden.",
      "更新已被 TNT 团队炸毁的方块。",
      "Actualizar bloques que fueron explotados por el comando TNT.",
      "Actualiser les blocs qui ont été explosés par la commande TNT.",
      "TNT komutuyla patlatılmış blokları yenileme."};

    public static readonly string[] UnhideInvertedTip = {
      "Make all drawing objects visible - " +
        "both those that were hidden by the Invert command and those that were hidden by the usual " +
        "_IsolateObjects and _HideObjects commands.",
      "Сделать видимыми все объекты чертежа — " +
        "как те, что были скрыты командой Invert, так и те, что были скрыты обычными командами " +
        "_IsolateObjects и _HideObjects." ,
      "Rendere visibili tutti gli oggetti del disegno, " +
        "sia quelli nascosti dal comando Inverti che quelli nascosti dai soliti comandi " +
        "_IsolateObjects e _HideObjects.",
      "Machen Sie alle Zeichenobjekte sichtbar - " +
        "sowohl diejenigen, die durch den Befehl Invertieren ausgeblendet wurden, als auch diejenigen, " +
        "die durch die üblichen Befehle _IsolateObjects und _HideObjects ausgeblendet wurden.",
      "使所有绘图对象可见 - " +
         "使用反转命令隐藏的那些，以及使用通常命令隐藏的那些" +
         "_IsolateObjects 和 _HideObjects。",
      "Hacer visibles todos los objetos de dibujo - " +
        "tanto los que fueron ocultados por el comando Invertir como los que fueron ocultados por los comandos habituales " +
        "_IsolateObjects y _HideObjects.",
      "Rendre tous les objets de dessin visibles - " +
        "à la fois ceux qui ont été masqués par la commande Inverser et ceux qui ont été masqués par les commandes habituelles " +
        "_IsolateObjects et _HideObjects.",
      "Tüm çizim nesnelerini görünür yapma - " +
        "hem Ters Çevir komutuyla gizlenenler hem de normal " +
        "_IsolateObjects ve _HideObjects komutlarıyla gizlenenler."};

    public static readonly string[] UnfoldRectTip = {
      "Create a rectangle based on the overall dimensions or on the unfolded dimensions of the solid, if it is marked as Sweep.",
      "Создать прямоугольник по габаритам или по развернутым размерам солида, если он помечен как Развертка.",
      "Creare un rettangolo in base alle quote complessive o alle quote spiegate del solido, se è contrassegnato come Sweep",
      "Erstellt ein Rechteck basierend auf den Gesamtmaßen oder den entfalteten Maßen des Körpers, wenn dieser als Sweep markiert ist.",
      "根据整体尺寸或实体的展开尺寸（如果标记为'扫掠'）创建一个矩形",
      "Crear un rectángulo basado en las dimensiones generales o en las dimensiones desplegadas del sólido, si está marcado como Sweep.",
      "Créer un rectangle basé sur les dimensions d'encombrement ou sur les dimensions dépliées du solide, s'il est marqué comme Sweep.",
      "Sweep olarak işaretlenmişse, genel boyutlara veya katının açılmış boyutlarına göre bir dikdörtgen oluşturma."};

    public static readonly string[] UnpackTip = {
      "Search for blocks in which only one part is packed (solid, polyline...). " +
        "Explosion of these blocks. Transferring the name and attributes of the block to the part.",
      "Поиск блоков, в которых запакована только одна деталь (солид, полилиния...). " +
        "Взрыв этих блоков. Перенос имени и атрибутов блока на деталь." ,
      "Cerca blocchi in cui è imballata solo una parte (solido, polilinea ...). " +
        "Esplosione di questi blocchi. Trasferimento del nome e degli attributi del blocco alla parte.",
      "Suchen Sie nach Blöcken, in denen nur ein Teil verpackt ist (Volumenkörper, Polylinie ...). " +
        "Explosion dieser Blöcke. Übertragen des Namens und der Attribute des Blocks auf das Teil.",
      "搜索仅包含一个部分的块（实心、折线...）。"+
         "这些块的爆炸。将块的名称和属性转移到细节中。",
      "Buscar bloques en los que solo hay una pieza empaquetada (sólido, polilínea...). " +
        "Explosión de estos bloques. Transferir el nombre y atributos del bloque a la pieza.",
      "Rechercher des blocs dans lesquels une seule pièce est emballée (solide, polyligne...). " +
        "Explosion de ces blocs. Transfert du nom et des attributs du bloc vers la pièce.",
      "Yalnızca bir parçanın paketlendiği blokları arama (katı, poliçizgi...). " +
        "Bu blokları patlama. Bloğun adını ve özniteliklerini parçaya aktarma."};

    public static readonly string[] UserPaletteTip = {
      "Open or close individual palettes to edit each custom (user) property",
      "Открыть или закрыть отдельные палитры для редактирования каждого заказного пользовательского свойства",
      "Apri o chiudi singole tavolozze per modificare ciascuna proprietà personalizzata",
      "Öffnen oder schließen Sie einzelne Paletten, um jede benutzerdefinierte Eigenschaft zu bearbeiten",
      "打开或关闭各个调色板以编辑每个自定义属性",
      "Abrir o cerrar paletas individuales para editar cada propiedad personalizada (de usuario).",
      "Ouvrir ou fermer des palettes individuelles pour éditer chaque propriété personnalisée (utilisateur).",
      "Her özel (kullanıcı) özelliğini düzenlemek için ayrı paletleri açma veya kapatma."};

    public static readonly string[] ZoneTip = {
      "Create a closed loop around a curve at a specified distance. Merge several such contours.",
      "Начертить единую замкнутую полилинию вокруг множества линий и кривых на заданном удалении.",
      "Crea una linea chiusa attorno a una curva a una distanza specificata. Unisci diversi di questi contorni.",
      "Erstellen Sie eine geschlossene Schleife um eine Kurve in einem bestimmten Abstand. Führen Sie mehrere solcher Konturen zusammen.",
      "以给定距离围绕曲线创建闭合环。 合并几个这样的轮廓。",
      "Crear un bucle cerrado alrededor de una curva a una distancia especificada. Fusionar varios de estos contornos.",
      "Créer une boucle fermée autour d'une courbe à une distance spécifiée. Fusionner plusieurs de ces contours.",
      "Belirtilen mesafede bir eğri etrafında kapalı bir döngü oluşturma. Birkaç bu tür konturu birleştirme."};

    // ============================================================================================================
    // Button Tips ================================================================================================

    public static readonly string[] HelpTip = {
      "Show documentation page in browser",
      "Показать страницу документации в браузере",
      "Mostra la pagina della documentazione nel browser",
      "Dokumentationsseite im Browser anzeigen",
      "在浏览器中显示文档页面",
      "Mostrar página de documentación en el navegador",
      "Afficher la page de documentation dans le navigateur",
      "Tarayıcıda belge sayfasını göster"};

    public static readonly string[] SaveTip = {
      "Save all settings changes. \r\n" +
        "You don't have to use this button since changes are saved automatically when you change the input field",
      "Сохранить все изменения настроек. \r\n" +
        "Вы можете не использовать данную кнопку так как изменения сохраняются автоматически при смене поля ввода",
      "Salva tutte le modifiche alle impostazioni. \r\n" +
        "Non è necessario utilizzare questo pulsante \r\n" +
        "poiché le modifiche vengono salvate automaticamente quando si modifica il campo di input",
      "Speichern Sie alle Einstellungsänderungen. \r\n" +
        "Sie müssen diese Schaltfläche nicht verwenden, \r\n" +
        "da Änderungen automatisch gespeichert werden, wenn Sie das Eingabefeld ändern",
      "保存所有设置更改。\r\n" +
        "您不必使用此按钮，因为当您更改输入字段时，更改会自动保存",
      "Guardar todos los cambios de configuración. \r\n" +
        "No es necesario usar este botón ya que los cambios se guardan automáticamente al cambiar el campo de entrada",
      "Enregistrer toutes les modifications des paramètres. \r\n" +
        "Vous n'avez pas besoin d'utiliser ce bouton car les modifications sont enregistrées automatiquement lors du changement du champ de saisie",
      "Tüm ayar değişikliklerini kaydet. \r\n" +
        "Giriş alanını değiştirdiğinizde değişiklikler otomatik olarak kaydedildiğinden bu düğmeyi kullanmanıza gerek yok"};

    public static readonly string[] RestoreSettingsTip = {
      "Restore initial settings",
      "Восстановить начальные настройки",
      "Ripristina le impostazioni iniziali",
      "Wiederherstellen der ursprünglichen Einstellungen",
      "重置参数",
      "Restaurar configuración inicial",
      "Restaurer les paramètres initiaux",
      "Başlangıç ayarlarını geri yükle"};

    public static readonly string[] StyleTip = {
      "Style (set of all settings).\r\n" +
        "Key and name.\r\n" +
        "The key is used to quickly switch styles From the command line.",
      "Стиль (набор всех настроек).\r\n" +
        "Ключ и имя.\r\n" +
        "Ключ используется для быстрого переключения стилей из командной строки.",
      "Stile (insieme di tutte le impostazioni).\r\n" +
        "Chiave e nome.\r\n" +
        "La chiave viene utilizzata per cambiare rapidamente gli stili dalla riga di comando.",
      "Stil (Satz aller Einstellungen).\r\n" +
        "Schlüssel und Name.\r\n" +
        "Die Taste wird verwendet, um Stile schnell von der Befehlszeile aus zu wechseln.",
      "设置样式 = 此命令的所有设置集。\r\n"+
        "序号+名称\r\n"+
        "序号自动分配1 到 9 的数字,并用于命令行快速切换样式。\r\n"+
        "您可以修改名称。",
      "Estilo (conjunto de todas las configuraciones).\r\n" +
        "Clave y nombre.\r\n" +
        "La clave se usa para cambiar estilos rápidamente desde la línea de comandos.",
      "Style (ensemble de tous les paramètres).\r\n" +
        "Clé et nom.\r\n" +
        "La clé est utilisée pour changer rapidement de style depuis la ligne de commande.",
      "Stil (tüm ayarlar kümesi).\r\n" +
        "Anahtar ve ad.\r\n" +
        "Anahtar, komut satırından stilleri hızlı değiştirmek için kullanılır."};

    public static readonly string[] StyleAddTip = {
      "Add another style.\r\nThere can be 9 styles in total.\r\n" +
        "The current style settings will be copied.",
      "Добавить еще один стиль.\r\nВсего может быть 9 стилей.\r\n" +
        "Настройки текущего стиля будут скопированы.",
      "Aggiungi un altro stile.\r\nCi possono essere 9 stili in totale.\r\n" +
        "Le impostazioni di stile correnti verranno copiate.",
      "Fügen Sie einen anderen Stil hinzu.\r\nEs kann insgesamt 9 Stile geben.\r\n" +
        "Die aktuellen Stileinstellungen werden kopiert.",
      "添加样式。 最多可以放置9个样式，点添加会复制当前样式为新样式。",
      "Agregar otro estilo.\r\nPuede haber 9 estilos en total.\r\n" +
        "La configuración del estilo actual se copiará.",
      "Ajouter un autre style.\r\nIl peut y avoir 9 styles au total.\r\n" +
        "Les paramètres du style actuel seront copiés.",
      "Başka bir stil ekle.\r\nToplamda 9 stil olabilir.\r\n" +
        "Mevcut stil ayarları kopyalanacak."};

    public static readonly string[] StyleDelTip = {
      "Remove this style",
      "Удалить этот стиль",
      "Rimuovi questo stile",
      "Diesen Stil entfernen",
      "删除当前样式",
      "Eliminar este estilo",
      "Supprimer ce style",
      "Bu stili kaldır"};

    public static readonly string[] SubstitutionsTip = {
      "Paste the substitution in place of the cursor.",
      "Выбор и вставка подстановки в текущую позицию курсора.",
      "Selezionare e inserire una sostituzione nella posizione corrente del cursore.",
      "Wählen Sie eine Vertretung aus und fügen Sie sie an der aktuellen Cursorposition ein.",
      "将替换字符粘贴到光标的位置。",
      "Pegar la sustitución en lugar del cursor.",
      "Coller la substitution à la place du curseur.",
      "İmleç yerine değiştirmeyi yapıştır."};

    public static readonly string[] AddSelectTip = {
      "Add all objects with this property to the selected ones",
      "Добавить все объекты с этим свойством к выбранным",
      "Aggiungi tutti gli oggetti con questa proprietà a quelli selezionati",
      "Alle Objekte mit dieser Eigenschaft zu den ausgewählten hinzufügen",
      "将具有此属性的所有对象添加到选定的图形对象",
      "Agregar todos los objetos con esta propiedad a los seleccionados",
      "Ajouter tous les objets avec cette propriété aux objets sélectionnés",
      "Bu özelliğe sahip tüm nesneleri seçilenlere ekle"};

    public static readonly string[] RemoveSelectTip = {
      "Exclude objects with this property From the selection",
      "Исключить объекты с этим свойством из выбранных",
      "Escludere gli oggetti con questa proprietà dalla selezione",
      "Objekte mit dieser Eigenschaft von der Auswahl ausschließen",
      "从选定的绘图对象中排除具有此属性的对象",
      "Excluir objetos con esta propiedad de la selección",
      "Exclure les objets avec cette propriété de la sélection",
      "Bu özelliğe sahip nesneleri seçimden hariç tut"};

    public static readonly string[] CalculatorTip = {
      "Calculator",
      "Калькулятор",
      "Calcolatore",
      "Taschenrechner",
      "计算器",
      "Calculadora",
      "Calculatrice",
      "Hesap makinesi"};

    public static readonly string[] RemoveAttrTip = {
      "Remove property/attribute",
      "Удалить свойство/атрибут",
      "Rimuovi proprietà/attributo",
      "Eigenschaft/Attribut entfernen",
      "删除属性/属性",
      "Eliminar propiedad/atributo",
      "Supprimer la propriété/attribut",
      "Özellik/öznitelik kaldır"};

    public static readonly string[] IncrementTip = {
      "Increase the field value by one",
      "Увеличить значение поля на единицу",
      "Aumenta il valore del campo di uno",
      "Erhöhen Sie den Feldwert um eins",
      "将字段值加一",
      "Aumentar el valor del campo en uno",
      "Augmenter la valeur du champ d'un",
      "Alan değerini bir artır"};

    public static readonly string[] PropsSaveTip = {
      "Save all changes.\r\n" +
        "You can choose not to use this button. In any case, the changes will be saved\r\n" +
        "when calling any command or when selecting other objects.\r\n" +
        "You can cancel saving by pressing ESC (if the cursor is still in the changed field).",
      "Сохранить все изменения.\r\n" +
        "Вы можете не использовать эту кнопку. В любом случае изменения будут сохранены\r\n" +
        "при вызове любой команды или при выборе других объектов.\r\n" +
        "Отказаться от сохранения можно нажав ESC\r\n" +
        "(если курсор еще остался в измененном поле).",
      "Salva tutte le modifiche.\r\n" +
        "Puoi scegliere di non utilizzare questo pulsante. In ogni caso, le modifiche verranno salvate\r\n" +
        "quando si chiama un comando o si selezionano altri oggetti.\r\n" +
        "È possibile annullare il salvataggio premendo ESC (se il cursore è ancora nel campo modificato).",
      "Alle Änderungen speichern.\r\n" +
        "Sie können diese Schaltfläche nicht verwenden.\r\n" +
        "Die Änderungen werden in jedem Fall gespeichert\r\n" +
        "beim Aufrufen eines Befehls oder beim Auswählen anderer Objekte.\r\n" +
        "Sie können das Speichern mit ESC abbrechen\r\n" +
        "(sofern sich der Cursor noch im geänderten Feld befindet).",
      "保存所有更改。\r\n" +
         "您可以选择不使用此按钮。无论如何，更改都会保存\r\n" +
         "调用任何命令或选择其他对象时。\r\n" +
         "您可以通过按 ESC 取消保存（如果光标仍在更改的字段中）。",
      "Guardar todos los cambios.\r\n" +
        "Puede elegir no usar este botón. En cualquier caso, los cambios se guardarán\r\n" +
        "al llamar a cualquier comando o al seleccionar otros objetos.\r\n" +
        "Puede cancelar el guardado presionando ESC (si el cursor aún está en el campo modificado).",
      "Enregistrer toutes les modifications.\r\n" +
        "Vous pouvez choisir de ne pas utiliser ce bouton. Dans tous les cas, les modifications seront enregistrées\r\n" +
        "lors de l'appel de n'importe quelle commande ou lors de la sélection d'autres objets.\r\n" +
        "Vous pouvez annuler l'enregistrement en appuyant sur ESC (si le curseur est toujours dans le champ modifié).",
      "Tüm değişiklikleri kaydet.\r\n" +
        "Bu düğmeyi kullanmamayı seçebilirsiniz. Her durumda, değişiklikler\r\n" +
        "herhangi bir komut çağrıldığında veya diğer nesneler seçildiğinde kaydedilecektir.\r\n" +
        "ESC tuşuna basarak kaydetmeyi iptal edebilirsiniz (imleç hala değiştirilen alandaysa)."};

    public static readonly string[] PropsOptionsTip = {
      "Palette settings",
      "Настройки палитры",
      "Impostazioni della tavolozza",
      "Paletteneinstellungen",
      "调色板设置",
      "Configuración de paleta",
      "Paramètres de palette",
      "Palet ayarları"};

    public static readonly string[] MatUpdateTip = {
      "Find all solids in the drawing and replace their color with the material color.\r\n" +
        "There is no color change for the Global material.\r\n" +
        "For materials ByLayer and ByBlock, the color is changed to ByLayer and ByBlock.",
      "Найти все солиды чертежа и заменить их цвет на цвет материала.\r\n" +
        "Для материала Global замена цвета не производится.\r\n" +
        "Для материалов ByLayer и ByBlock производится замена цвета на ByLayer и ByBlock.",
      "Trova tutti i solidi nel disegno e sostituisci il loro colore con il colore del materiale.\r\n" +
        "Non vi è alcun cambiamento di colore per il materiale Global.\r\n" +
        "Per i materiali PerLayer e PerBlocco, il colore viene modificato in PerLayer e PerBlocco.",
      "Suchen Sie alle Volumenkörper in der Zeichnung und ersetzen Sie ihre Farbe durch die Materialfarbe.\r\n" +
        "Für das globale Material gibt es keine Farbänderung.\r\n" +
        "Für Materialien VonLayer und ByBlock wird die Farbe in ByLayer und ByBlock geändert.",
      "查找所有蓝图实体并将其颜色替换为材质颜色。\r\n" +
         "全局材质没有颜色替换。\r\n" +
         "对于 ByLayer 和 ByBlock 材质，颜色更改为 ByLayer 和 ByBlock。",
      "Encontrar todos los sólidos en el dibujo y reemplazar su color con el color del material.\r\n" +
        "No hay cambio de color para el material Global.\r\n" +
        "Para materiales PorCapa y PorBloque, el color se cambia a PorCapa y PorBloque.",
      "Trouver tous les solides dans le dessin et remplacer leur couleur par la couleur du matériau.\r\n" +
        "Il n'y a pas de changement de couleur pour le matériau Global.\r\n" +
        "Pour les matériaux ParCalque et ParBloc, la couleur est changée en ParCalque et ParBloc.",
      "Çizimdeki tüm katıları bul ve renklerini malzeme rengiyle değiştir.\r\n" +
        "Global malzeme için renk değişikliği yok.\r\n" +
        "Katmana Göre ve Bloğa Göre malzemeler için renk Katmana Göre ve Bloğa Göre olarak değiştirilir."};

    // =============================================================================================================
    // Option Tabs =================================================================================================

    public static readonly string[] About = {
      "About plug-in",
      "О программе",
      "Informazioni sul A>V>C>",
      "Über das A>V>C>",
      "关于插件",
      "Acerca del complemento",
      "À propos du plug-in",
      "Eklenti hakkında"};

    public static readonly string[] AboutTip = {
      "Information about this program",
      "Информация о данной программе",
      "Informazioni su questo programma",
      "Informationen zu diesem Programm",
      "关于这个程序的信息",
      "Información sobre este programa",
      "Informations sur ce programme",
      "Bu program hakkında bilgi"};

    public static readonly string[] Common = {
      "Common Options",
      "Общие настройки",
      "Impostazioni generali",
      "Allgemeine Einstellungen",
      "常用选项",
      "Opciones comunes",
      "Options communes",
      "Genel Seçenekler"};

    public static readonly string[] CommonTip = {
      "Setting common functions for all commands From A>V>C> plugins.",
      "Настройка общих функций для всех команд из плагинов A>V>C>.",
      "Impostazione di funzioni comuni per tutti i comandi dei plugin A>V>C>.",
      "Festlegen gemeinsamer Funktionen für alle Befehle von A>V>C>-Plugins.",
      "为 A>V>C> 插件中的所有命令设置通用功能。",
      "Configuración de funciones comunes para todos los comandos de complementos A>V>C>.",
      "Configuration des fonctions communes pour toutes les commandes des plug-ins A>V>C>.",
      "A>V>C> eklentilerinden tüm komutlar için ortak fonksiyonları ayarlama."};

    public static readonly string[] Message = {
      "Messages From commands",
      "Сообщения от команд",
      "Messaggi da comandi",
      "Nachrichten von Befehlen",
      "来自命令的消息",
      "Mensajes de comandos",
      "Messages des commandes",
      "Komutlardan mesajlar"};

    public static readonly string[] MessageTip = {
      "Setting up displaying and sending messages From A>V>C> programs",
      "Настройка показа и отправки сообщений от программ A>V>C>",
      "Configurazione della visualizzazione e dell'invio di messaggi da programmi A>V>C>",
      "Einrichten des Anzeigens und Sendens von Nachrichten von A>V>C>-Programmen",
      "设置从 A>V>C> 程序显示和发送消息",
      "Configuración de visualización y envío de mensajes desde programas A>V>C>",
      "Configuration de l'affichage et de l'envoi de messages depuis les programmes A>V>C>",
      "A>V>C> programlarından mesaj görüntüleme ve gönderme ayarları"};

    public static readonly string[] Client = {
      "Account A>V>C>",
      "Учетная запись",
      "Account A>V>C>",
      "Konto A>V>C>",
      "A>V>C> 账户",
      "Cuenta A>V>C>",
      "Compte A>V>C>",
      "Hesap A>V>C>"};

    public static readonly string[] ClientTip = {
      "Setting up a user account for A>V>C> plugins. Switching online mode",
      "Настройка аккаунта пользователя плагинов A>V>C>. Переключение онлайн режима",
      "Configurazione di un account utente per i plug-in A>V>C>. Passaggio alla modalità online",
      "Einrichten eines Benutzerkontos für A>V>C>-Plugins. Online-Modus wechseln",
      "为 A>V>C> 插件设置用户帐户。 切换在线模式",
      "Configuración de una cuenta de usuario para complementos A>V>C>. Cambio a modo en línea",
      "Configuration d'un compte utilisateur pour les plug-ins A>V>C>. Passage en mode en ligne",
      "A>V>C> eklentileri için kullanıcı hesabı kurma. Çevrimiçi moda geçiş"};

    public static readonly string[] Activate = {
      "Activate",
      "Активация",
      "Attivare",
      "Aktivieren Sie",
      "激活",
      "Activar",
      "Activer",
      "Etkinleştir"};

    public static readonly string[] ActivateTip = {
      "Obtaining a license and activating AVC programs",
      "Получение лицензии и активация программ A>V>C>",
      "Ottenere una licenza e attivare i programmi A>V>C>",
      "Erwerb einer Lizenz und Aktivierung von A>V>C>-Programmen",
      "获取许可证并激活 A>V>C> 程序",
      "Obtención de una licencia y activación de programas A>V>C>",
      "Obtention d'une licence et activation des programmes A>V>C>",
      "Lisans alma ve A>V>C> programlarını etkinleştirme"};

    public static readonly string[] AllPrograms = {
      "All Programs",
      "Все программы",
      "Tutti i programmi",
      "Alle Programme",
      "所有程序",
      "Todos los programas",
      "Tous les programmes",
      "Tüm Programlar"};

    public static readonly string[] AllProgramsTip = {
      "A>V>C> software store. Obtaining licenses and activation.",
      "Магазин программ A>V>C>. Получение лицензий и активация.",
      "Negozio di software A>V>C>. Ottenere licenze e attivazione.",
      "A>V>C>-Software-Shop. Beziehen von Lizenzen und Aktivierung.",
      "A>V>C> 软件商店。 获取许可证和激活。",
      "Tienda de software A>V>C>. Obtención de licencias y activación.",
      "Magasin de logiciels A>V>C>. Obtention de licences et activation.",
      "A>V>C> yazılım mağazası. Lisans alma ve etkinleştirme."};

    public static readonly string[] License = {
      "License Management",
      "Лицензии",
      "Licenze",
      "Lizenzverwaltung",
      "许可证管理",
      "Gestión de licencias",
      "Gestion des licences",
      "Lisans Yönetimi"};

    public static readonly string[] LicenseTip = {
      "List of licenses and activations. Transfer of licenses.",
      "Список лицензий и активаций. Перенос лицензий.",
      "Elenco di licenze e attivazioni. Trasferimento di licenze.",
      "Liste der Lizenzen und Aktivierungen. Übertragung von Lizenzen.",
      "许可证和激活列表。 许可证转让。",
      "Lista de licencias y activaciones. Transferencia de licencias.",
      "Liste des licences et activations. Transfert de licences.",
      "Lisans ve etkinleştirme listesi. Lisans transferi."};

    public static readonly string[] UpdaterTip = {
      "Automatic updates of A>V>C> programs.",
      "Автоматические обновления программ A>V>C>.",
      "Aggiornamenti automatici dei programmi A>V>C>.",
      "Automatische Updates von A>V>C>-Programmen.",
      "A>V>C>程序的自动更新。",
      "Actualizaciones automáticas de programas A>V>C>.",
      "Mises à jour automatiques des programmes A>V>C>.",
      "A>V>C> programlarının otomatik güncellemeleri."};

    public static readonly string[] ExportSettings = {
      "Export Settings",
      "Экспорт настроек",
      "Esporta impostazioni",
      "Exporteinstellungen",
      "导出设置",
      "Exportar configuración",
      "Exporter les paramètres",
      "Ayarları Dışa Aktar"};

    public static readonly string[] ExportSettingsTip = {
      "Backup A>V>C> Program Settings",
      "Резервное сохранение настроек программ A>V>C>",
      "Backup delle impostazioni del programma A>V>C>",
      "A>V>C>-Programmeinstellungen sichern",
      "备份 A>V>C> 程序设置",
      "Copia de seguridad de configuración de programas A>V>C>",
      "Sauvegarde des paramètres des programmes A>V>C>",
      "A>V>C> Program Ayarlarını Yedekle"};

    // ======================================================================================
    // Program Sections =======================================================================

    public static readonly string[] Collections = {
      "Collections",
      "Сборники",
      "Collezioni",
      "Sammlungen",
      "收藏品",
      "Colecciones",
      "Collections",
      "Koleksiyonlar"};

    public static readonly string[] Modeling = {
      "Modeling",
      "Моделирование",
      "Modellazione",
      "Modellieren",
      "造型",
      "Modelado",
      "Modélisation",
      "Modelleme"};

    public static readonly string[] Annotations = {
      "Annotations",
      "Аннотации",
      "Annotazioni",
      "Beschriften",
      "注释",
      "Anotaciones",
      "Annotations",
      "Açıklamalar"};

    public static readonly string[] CNC2d = {
      "2D and CNC",
      "2D и ЧПУ",
      "2D e CNC",
      "2D und CNC",
      "二维和数控",
      "2D y CNC",
      "2D et CNC",
      "2D ve CNC"};

    public static readonly string[] Utilities = {
      "Utilities",
      "Утилиты",
      "Utilità",
      "Dienstprogramme",
      "实用程序",
      "Utilidades",
      "Utilitaires",
      "Yardımcı Programlar"};

    public static readonly string[] AllIn1Menu = {
      "All in 1",
      "Всё в 1",
      "Tutto in 1",
      "Alles in 1",
      "全部在 1",
      "Todo en 1",
      "Tout en 1",
      "Hepsi 1'de"};

    public static readonly string[] TextPalettesMenu = {
      "Text Palettes",
      "Текстовые палитры",
      "Tavolozze di testo",
      "Textpaletten",
      "文本调色板",
      "Paletas de texto",
      "Palettes de texte",
      "Metin Paletleri"};

    public static readonly string[] UCS = {
      "UCS",
      "ПСК",
      "UCS",
      "BKS",
      "UCS",
      "CSP",
      "SCU",
      "UCS"};

    public static readonly string[] Modify = {
      "Modify",
      "Редактирование",
      "Modificare",
      "Ändern",
      "修改",
      "Modificar",
      "Modifier",
      "Düzenle"
    };

    public static readonly string[] Draw = {
      "Draw",
      "Черчение",
      "Disegnare",
      "Zeichnen",
      "绘图",
      "Dibujar",
      "Dessiner",
      "Çiz"
    };

    public static readonly string[] SolidEditing = {
      "Solid Editing",
      "3D редактирование",
      "Modifica solidi",
      "Volumenkörper-Bearbeitung",
      "实体编辑",
      "Edición de sólidos",
      "Édition de solides",
      "Katı Düzenleme"
    };

    public static readonly string[] View = {
      "View",
      "Виды",
      "Visualizzazioni",
      "Ansichten",
      "视图",
      "Vistas",          // ES
      "Vues",            // FR
      "Görünümler"};     // TR

    public static readonly string[][] 
    ProgramSections = { Collections, Modeling, PropL.Tables, Annotations, PropL.Blocks, CNC2d, Utilities, AllIn1Menu, TextPalettesMenu, UCS, Draw, Modify, SolidEditing, PropL.Layout, View, PropL.Layers, PropL.Groups };

    // ===================================================================================================
    // ProgramState ======================================================================================

    public static readonly string[] NotInstalled = {
      "Program is not installed",
      "Программа не установлена",
      "Programma non installato",
      "Programm nicht installiert",
      "程序未安装",
      "Programa no instalado",
      "Programme non installé",
      "Program yüklü değil"};

    public static readonly string[] Repeated = {
      "Program not needed (repeated)",
      "Программа не нужна (повторная)",
      "Programma non necessario (ripetuto)",
      "Programm nicht erforderlich (wiederholt)",
      "不需要程序（重复）",
      "Programa no necesario (repetido)",
      "Programme non nécessaire (répété)",
      "Program gerekli değil (tekrarlı)"};

    public static readonly string[] NotNeeded = {
      "The program is not installed and is not needed",
      "Программа не установлена и не нужна",
      "Il programma non è installato e non è necessario",
      "Das Programm ist nicht installiert und wird nicht benötigt.",
      "该程序未安装且不需要",
      "El programa no está instalado y no es necesario",
      "Le programme n'est pas installé et n'est pas nécessaire",
      "Program yüklü değil ve gerekli değil"};

    public static readonly string[] NotActivated = {
      "The program is not activated",
      "Программа не активирована",
      "Il programma non è attivato",
      "Das Programm ist nicht aktiviert",
      "程序未激活",
      "El programa no está activado",
      "Le programme n'est pas activé",
      "Program etkinleştirilmedi"};

    public static readonly string[] Trial = {
      "Trial period",
      "Идет пробный период",
      "Periodo di prova",
      "Probezeit",
      "试用期进行中",
      "Período de prueba",
      "Période d'essai",
      "Deneme süresi"};

    public static readonly string[] Activated = {
      "Activated",
      "Активирована",
      "Programma attivato",
      "Programm aktiviert",
      "程序启动",
      "Activado",
      "Activé",
      "Etkinleştirildi"};

    //=================================================================================
    // Ошибки =========================================================================

    public static readonly string[] MeshTooHardErr = {
      "  Mesh is too hard (more {0} faces)",
      "  Сеть слишком сложная (более {0} граней)",
      "  Mesh è troppo difficile (più di {0} facce)",
      "  Das Netz ist zu komplex (mehr als {0} Gesichter)",
      "  网格太复杂（超过 {0} 个面）",
      "  La malla es demasiado compleja (más de {0} caras)",
      "  Le maillage est trop complexe (plus de {0} faces)",
      "  Ağ çok karmaşık ({0}'den fazla yüz)"};

    public static readonly string[] SolidTooHardErr = {
      "  The solid has too many faces (more than {0}). Coatings and colors will not be processed.",
      "  У солида слишком много граней (более {0}). Покрытия и расцветка не будут обрабатываться.",
      "  Il solido ha troppe facce (più di {0}). Non verranno elaborati rivestimenti e colori.",
      "  Der Volumenkörper hat zu viele Flächen (mehr als {0}). Lacke und Farben werden nicht verarbeitet.",
      "  实体的面太多（超过 {0} 个）。 不会处理涂层和颜色。",
      "  El sólido tiene demasiadas caras (más de {0}). Los recubrimientos y colores no se procesarán.",
      "  Le solide a trop de faces (plus de {0}). Les revêtements et couleurs ne seront pas traités.",
      "  Katı çok fazla yüze sahip ({0}'den fazla). Kaplamalar ve renkler işlenmeyecek."};

  }
}
