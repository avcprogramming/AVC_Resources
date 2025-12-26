// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  MultiSliceL
  {
    public static readonly string[] Slice = {
      "Slice",
      "Отслоение",
      "Stratifica",
      "Schälen",
      "去角质",
      "Rebanar",                                       // ES
      "Trancher",                                      // FR
      "Dilimlemek" };                                  // TR

    public static readonly string[][] SliceStyleNames = {
        Slice,
        Slice,
        new []{ "Shell with Miter Joint",
                "Оболочка под ус",
                "Guscio con snodo obliquo",
                "Schale mit Gehrungsverbindung",
                "带斜接的外壳",
                "Carcasa con junta a inglete",          // ES
                "Coque avec joint à onglet",            // FR
                "Gönye eklentili kabuk" }               // TR
      };

    // ================================ Slice Style =====================================
    public static readonly string[] PlaneMethodKW = {
      "PlaneMethod", "ПЛоскостью", "LAereo", "Flugzeugmethode", "平面法(P)",
      "MétodoPLano",                                   // ES
      "MéthodePLan",                                   // FR
      "DÜzlemYöntemi" };                               // TR

    public static readonly string[] SurfaceMethodKW = {
      "SUrfaceMethod", "ПОВерхностью", "SUperficie", "OBerflächenmethode", "表面法(SU)",
      "MétodoSUperficie",                              // ES
      "MéthodeSUrface",                                // FR
      "YÜzeyYöntemi" };                                // TR

    public static readonly string[] OffsetFaceMethodKW = {
      "OffsetFaceMethod", "СДвигом", "Offset", "OFfsetGesichtsmethode", "偏移面法(O)",
      "MétodoOFfsetCara",                              // ES
      "MéthodeOFfsetFace",                             // FR
      "OFsetYüzYöntemi" };                             // TR

    public static readonly string[] AllMethodsKW = {
      "3Methods", "3Метода", "3Metodi", "3Methoden", "3种方法",
      "3Métodos",                                      // ES
      "3Méthodes",                                     // FR
      "3Yöntem" };                                     // TR

    public static readonly string[] KeepSurfaceOnErrorKW = {
      "KeepSurfaceOnError", "СОхранятьПоверхность", "MantenereSuperficie", "SPeichernOberfläche", "保持表面的错误(K)",
      "MAntenersuperficie",                            // ES
      "COnserversurface",                              // FR
      "YÜzeyiKorumak" };                               // TR

    public static readonly string[] ContiguousKW = {
      "COntiguous", "СМежные", "СOntigue", "BenachbarteOberflächen", "相邻表面(CO)",
      "COntiguas",                                     // ES
      "COntigus",                                      // FR
      "Bİtişik" };                                     // TR

    public static readonly string[] CyclicallyKW = {
      "CYclically", "ЗАциклить", "CIiclicamente", "Zyklisch", "环形(CY)",
      "CÍclicamente",                                  // ES
      "CYcliquement",                                  // FR
      "DÖngüsel" };                                    // TR

    public static readonly string[] AllKW = {
      "ALL", "ВСЕ", "TUtto", "ALLes", "全部(ALL)",
      "TODO",                                          // ES
      "TOUT",                                          // FR
      "TÜM" };                                         // TR

    public static readonly string[] AlongKW = {
      "ALOng", "ВДоль", "LUngo", "Entlang", "沿着(ALO)",
      "A LO largo",                                    // ES
      "LE LOng",                                       // FR
      "BOYUNCA" };                                     // TR

    public static readonly string[] AcrossKW = {
      "ACross", "ПОПерек", "TRasver", "ACross", "穿过(ACR)",
      "A TRavés",                                      // ES
      "À TRavers",                                     // FR
      "KARşıya" };                                     // TR

    public static readonly string[] CutToEdgeKW = {
      "TOEdge", "Указать", "SPecificare", "ANzeigen", "指定导向边(TOE)",
      "ESPecificar",                                   // ES
      "SPécifier",                                     // FR
      "BELirtmek" };                                   // TR

    public static readonly string[] ThicknessQuery = {
      "  Enter thickness",
      "  Задайте толщину",
      "  Inserisci spessore",
      "  Dicke eingeben",
      "  输入厚度",
      "  Ingrese el espesor",                          // ES
      "  Entrez l'épaisseur",                          // FR
      "  Kalınlığı girin" };                           // TR

    public static readonly string[] KeepSurfaceQuery ={
      "  Should the secant surface be preserved when a solid could not be cut?",
      "  Сохранять секущую поверхность, когда не удалось разрезать ей солид?",
      "  La superficie secante deve essere preservata quando non è possibile tagliare un corpo solido?",
      "  Um die Sekantenoberfläche zu erhalten, wenn es nicht möglich war, fest zu schneiden?",
      "  当无法切割实体时，是否应该保留割线？",
      "  ¿Debe conservarse la superficie secante cuando no se pudo cortar un sólido?",  // ES
      "  La surface sécante doit-elle être préservée lorsqu'un solide n'a pas pu être coupé ?",  // FR
      "  Bir katı kesilemediğinde sekant yüzey korunmalı mı?"};  // TR

    public static readonly string[] ContiguousQuery ={
      "  Handle contiguous surfaces",
      "  Отслаивать смежные поверхности",
      "  Gestire le superfici contigue",
      "  Benachbarte Flächen abziehen",
      "  处理连续表面",
      "  Manejar superficies contiguas",               // ES
      "  Gérer les surfaces contiguës",                // FR
      "  Bitişik yüzeyleri işle"};                     // TR

    public static readonly string[] CyclicallyQuery ={
      "  Query surfaces cyclically until you press ESC",
      "  Запрашивать поверхности циклически до нажатия ESC",
      "  Le query vengono visualizzate ciclicamente fino a quando non si preme ESC",
      "  Fragen Sie Oberflächen zyklisch ab, bis Sie ESC drücken",
      "  循环查询表面，直到您按 ESC",
      "  Consultar superficies cíclicamente hasta que presione ESC",  // ES
      "  Interroger les surfaces de manière cyclique jusqu'à ce que vous appuyiez sur ESC",  // FR
      "  ESC tuşuna basana kadar yüzeyleri döngüsel olarak sorgula"};  // TR

    public static readonly string[] MethodPlane = {
      "  Only the cutting plane method will be used",
      "  Будет использован только метод отсечения плоскостью",
      "  Verrà utilizzato solo il metodo di ritaglio piano",
      "  Es wird nur die Beschneidungsmethode verwendet.",
      "  仅使用切割平面法",
      "  Solo se utilizará el método de plano de corte",  // ES
      "  Seule la méthode du plan de coupe sera utilisée",  // FR
      "  Yalnızca kesme düzlemi yöntemi kullanılacak"};  // TR

    public static readonly string[] MethodSurface = {
        "  Only the cutting curved surface method will be used",
        "  Будет использован только метод отсечения криволинейной поверхностью",
        "  Verrà utilizzato solo il metodo della superficie curva di taglio",
        "  Es wird nur die Beschneidungsmethode verwendet.",
        "  仅使用切割曲面法",
        "  Solo se utilizará el método de superficie curva de corte",  // ES
        "  Seule la méthode de surface courbe de coupe sera utilisée",  // FR
        "  Yalnızca kesme eğri yüzey yöntemi kullanılacak"};  // TR

    public static readonly string[] MethodOffset = {
        "  Only the face offset method will be used",
        "  Будет использован только метод сдвига грани",
        "  Verrà utilizzato solo il metodo di offset facciale",
        "  Es wird nur die Gesichtsverschiebungsmethode verwendet.",
        "  只会使用面偏移方法",
        "  Solo se utilizará el método de desplazamiento de cara",  // ES
        "  Seule la méthode de décalage de face sera utilisée",  // FR
        "  Yalnızca yüz ofset yöntemi kullanılacak"};  // TR

    public static readonly string[] MethodAll3 = {
        "  All 3 cutting methods will be used",
        "  Будут использованы все 3 метода отсечения",
        "  Verranno utilizzati tutti e 3 i metodi",
        "  Alle 3 Beschneidungsmethoden werden verwendet.",
        "  将使用所有 3 种切割方法",
        "  Se utilizarán los 3 métodos de corte",      // ES
        "  Les 3 méthodes de coupe seront utilisées",  // FR
        "  3 kesme yönteminin tümü kullanılacak"};     // TR

    public static readonly string[] CutNull ={
        "  Auto surface selection not set.",
        "  Не задан автовыбор поверхностей.",
        "  Selezione automatica della superficie non impostata.",
        "  Automatische Oberflächenauswahl nicht eingestellt." ,
        "  未设置自动表面选择.",
        "  Selección automática de superficie no establecida.",  // ES
        "  Sélection automatique de surface non définie.",  // FR
        "  Otomatik yüzey seçimi ayarlanmadı."};       // TR

    public static readonly string[] CutShellTip ={
        "  Cutting all surfaces (shell).}",
        "  Отслаивание всех поверхностей (оболочка).}",
        "  Taglio di tutte le superfici (guaina).",
        "  Abblättern aller Oberflächen (Schale).}" ,
        "  切割所有表面（外壳)",
        "  Cortar todas las superficies (carcasa).",   // ES
        "  Coupe de toutes les surfaces (coque).",     // FR
        "  Tüm yüzeyleri kesme (kabuk)."};             // TR

    public static readonly string[] CutXHint ={
        "  Cutting surfaces along the X axis",
        "  Отслаивание поверхностей вдоль оси X",
        "  Taglio di superfici lungo l'asse X",
        "  Abblätternde Oberflächen entlang der X-Achse" ,
        "  沿 X 轴的切割面",
        "  Cortar superficies a lo largo del eje X",   // ES
        "  Coupe de surfaces le long de l'axe X",      // FR
        "  X ekseni boyunca yüzey kesme"};             // TR

    public static readonly string[] CutYHint ={
        "  Cutting surfaces along the Y axis",
        "  Отслаивание поверхностей вдоль оси Y",
        "  Taglio di superfici lungo l'asse Y",
        "  Abblätternde Oberflächen entlang der Y-Achse" ,
        "  沿 Y 轴切割表面",
        "  Cortar superficies a lo largo del eje Y",   // ES
        "  Coupe de surfaces le long de l'axe Y",      // FR
        "  Y ekseni boyunca yüzey kesme"};             // TR

    public static readonly string[] CutZHint ={
        "  Cutting surfaces along the Z axis",
        "  Отслаивание поверхностей вдоль оси Z",
        "  Taglio di superfici lungo l'asse Z",
        "  Abblätternde Oberflächen entlang der Z-Achse" ,
        " 沿 Z 轴切割表面",
        "  Cortar superficies a lo largo del eje Z",   // ES
        "  Coupe de surfaces le long de l'axe Z",      // FR
        "  Z ekseni boyunca yüzey kesme"};             // TR

    public static readonly string[] CutSelected ={
        "  Surfaces selected in advance. Auto select is disabled",
        "  Поверхности выбраны заранее. Автовыбор отключен",
        "  Superfici selezionate in anticipo. La selezione automatica è disabilitata",
        "  Oberflächen im Voraus ausgewählt. Die automatische Auswahl ist deaktiviert" ,
        "  预先选择的表面。 自动选择已禁用",
        "  Superficies seleccionadas por adelantado. La selección automática está deshabilitada",  // ES
        "  Surfaces sélectionnées à l'avance. La sélection automatique est désactivée",  // FR
        "  Yüzeyler önceden seçildi. Otomatik seçim devre dışı"};  // TR

    public static readonly string[] ContiguousOn ={
        " The search for contiguous surfaces is on.",
        " Включен поиск смежных.",
        " La ricerca di superfici contigue è inclusa.",
        " Die Suche nach angrenzenden Flächen ist enthalten." ,
        " 搜索连续曲面已打开。",
        " La búsqueda de superficies contiguas está activada.",  // ES
        " La recherche de surfaces contiguës est activée.",  // FR
        " Bitişik yüzey arama açık."};                // TR

    public static readonly string[] MiterHint ={
        "  Cut slices will be miter joined",
        "  Отрезанные дольки будут соединены ПОД УС",
        "  Le sezioni tagliate verranno unite ad angolo",
        "  Geschnittene Scheiben werden auf Gehrung verbunden." ,
        "  切片将斜接",
        "  Los cortes se unirán en inglete",           // ES
        "  Les tranches coupées seront jointes en onglet",  // FR
        "  Kesilen dilimler gönye birleştirilecek"};  // TR

    public static readonly string[] LargeToSmallHint ={
        "  Surfaces will be cut starting from large",
        "  Поверхности будут отрезаться начиная с больших",
        "  Le superfici verranno tagliate partendo da grandi",
        "  Oberflächen werden ab groß geschnitten." ,
        "  表面将从大开始切割",
        "  Las superficies se cortarán comenzando desde las grandes",  // ES
        "  Les surfaces seront coupées en commençant par les grandes",  // FR
        "  Yüzeyler büyükten başlayarak kesilecek"};  // TR

    public static readonly string[] SmallToLargeHint ={
        "  Surfaces will be cut starting from small",
        "  Поверхности будут отрезаться начиная с маленьких",
        "  Le superfici verranno tagliate partendo da piccole",
        "  Oberflächen werden ausgehend von kleinen geschnitten." ,
        "  表面将从小开始切割",
        "  Las superficies se cortarán comenzando desde las pequeñas",  // ES
        "  Les surfaces seront coupées en commençant par les petites",  // FR
        "  Yüzeyler küçükten başlayarak kesilecek"};  // TR

    // ======================= MultiSlice ==========================================
    public static readonly string[] Cutting = {
      "  Cutting",
      "  Отслоение",
      "  Stratifica",
      "  Schneiden",
      "  分层",
      "  Cortando",                                    // ES
      "  Découpage",                                   // FR
      "  Kesim yapılıyor" };                           // TR

    public static readonly string[] SelectEdge ={
      "  Select a straight edge to set the direction of the slicing surfaces.",
      "  Выберите прямое ребро, что бы задать направление отслаиваемых поверхностей",
      "  Selezionare un bordo dritto per impostare la direzione delle superfici.",
      "  Wählen Sie eine gerade Kante, um die Richtung der Flächen festzulegen.",
      "  选择一条直边以设置切片曲面的方向。",
      "  Seleccione un borde recto para establecer la dirección de las superficies de corte.",  // ES
      "  Sélectionnez une arête droite pour définir la direction des surfaces de découpe.",  // FR
      "  Kesim yüzeylerinin yönünü ayarlamak için düz bir kenar seçin."};  // TR

    public static readonly string[] StraightRequired = {
      "  Straight edge required",
      "  Требуется прямое ребро",
      "  Bordo diritto richiesto",
      "  Gerade Kante erforderlich",
      "  需要直边",
      "  Se requiere un borde recto",                  // ES
      "  Arête droite requise",                        // FR
      "  Düz kenar gerekli" };                         // TR

    public static readonly string[] SelectedCount ={
      "  Selected solids: {0}, Surface groups: {1}",
      "  Выбрано солидов: {0}, Групп поверхностей: {1}",
      "  Solidi selezionati: {0}, Gruppi di superficie: {1}",
      "  Ausgewählte Volumenkörper: {0}, Oberflächengruppen: {1}",
      "  选定的实体：{0}，曲面组：{1}",
      "  Sólidos seleccionados: {0}, Grupos de superficie: {1}",  // ES
      "  Solides sélectionnés : {0}, Groupes de surfaces : {1}",  // FR
      "  Seçilen katılar: {0}, Yüzey grupları: {1}"};  // TR

    // =========================================== SliceFace ==============================================
    public static readonly string[] NoWork ={
      "No method of slice did not work.",
      "Ни один метод отслоения не сработал. Надо перечерчивать солид заново.",
      "Nessun metodo della fetta non ha funzionato.",
      "Keine einzige Schälmethode hat funktioniert. Der Volumenkörper muss erneut gezeichnet werden.",
      "没有一种剥皮方法有效。 有必要再次重绘实体。",
      "Ningún método de corte funcionó.",               // ES
      "Aucune méthode de découpe n'a fonctionné.",     // FR
      "Hiçbir dilim yöntemi çalışmadı." };             // TR

    public static readonly string[] SubErr ={
      "Slice subtraction error. Cutting is canceled.",
      "Ошибка построения обрезка. Разрезание отменено.",
      "Errore di sottrazione della fetta. Il taglio è annullato.",
      "Fehler beim Erstellen des Zuschneidens. Das Schneiden wird abgebrochen.",
      "切片减法错误。 取消切割。",
      "Error de sustracción de corte. Se cancela el corte.",  // ES
      "Erreur de soustraction de tranche. La découpe est annulée.",  // FR
      "Dilim çıkarma hatası. Kesim iptal edildi." };   // TR

    public static readonly string[] SubBlankErr ={
      "Failed to subtract a slice from the blank",
      "Не удалось вычесть из заготовки дольку",
      "Impossibile sottrarre una sezione dallo spazio",
      "Fehler beim Subtrahieren eines Slice vom Ernte.",
      "未能从空白中减去切片",
      "No se pudo restar un corte del espacio en blanco",  // ES
      "Échec de la soustraction d'une tranche de l'ébauche",  // FR
      "Boş alandan bir dilim çıkarılamadı" };          // TR

    public static readonly string[] IntersectErr ={
      "Failed to fix intersections of parts",
      "Не удалось устранить пересечения деталей",
      "Impossibile correggere le intersezioni delle parti",
      "Fehler beim Korrigieren des Schnittpunkts von Teilen",
      "无法修复零件的交点",
      "No se pudieron corregir las intersecciones de piezas",  // ES
      "Échec de la correction des intersections de pièces",  // FR
      "Parçaların kesişimleri düzeltilemedi"};         // TR

    public static readonly string[] SurfNum = {
      "Process surface number {0}",
      "Обрабатываем поверхность номер {0}",
      "Elaboriamo il numero di superficie {0}",
      "Processing surface number {0}",
      "处理表面编号 {0}",
      "Procesando superficie número {0}",              // ES
      "Traitement de la surface numéro {0}",           // FR
      "İşleniyor yüzey numarası {0}"};                 // TR

    public static readonly string[] NoIntersect ={
      "The cutting plane did not intersect the solid. The thickness may be too large.",
      "Секущая плоскость не пересеклась с телом. Возможно задана слишком большая толщина.",
      "Il piano di taglio non intersecava il solido. Lo spessore potrebbe essere troppo grande.",
      "Die Schnittebene schnitt nicht mit dem Volumenkörper. Möglicherweise ist zu viel Dicke angegeben.",
      "切割平面不与实体相交。 厚度可能太大",
      "El plano de corte no intersectó el sólido. El espesor puede ser demasiado grande.",  // ES
      "Le plan de coupe n'a pas intersecté le solide. L'épaisseur peut être trop grande.",  // FR
      "Kesme düzlemi katı ile kesişmedi. Kalınlık çok büyük olabilir." };  // TR

    public static readonly string[] CopyErr = {
      "Can't copy solid.",
      "Не удалось скопировать солид.",
      "Non è possibile copiare il solido.",
      "Solid konnte nicht Volumenkörper werden.",
      "无法复制实体。",
      "No se puede copiar el sólido.",                 // ES
      "Impossible de copier le solide.",               // FR
      "Katı kopyalanamıyor." };                        // TR

    public static readonly string[] OffsetErr ={
      "Face offset method does not work. {0}",
      "Не сработал метод офсета поверхности. {0}",
      "Il metodo di offset facciale non funziona. {0}",
      "Die Oberflächenversatzmethode hat nicht funktioniert. {0}",
      "面部偏移方法不起作用。 {0}",
      "El método de desplazamiento de cara no funciona. {0}",  // ES
      "La méthode de décalage de face ne fonctionne pas. {0}",  // FR
      "Yüz ofset yöntemi çalışmıyor. {0}"};            // TR

    public static readonly string[] NotFlat = {
      "The face is not flat.",
      "Грань не плоская.",
      "La faccia non è piatta.",
      "Das Gesicht ist nicht flach.",
      "脸不平。",
      "La cara no es plana.",                          // ES
      "La face n'est pas plane.",                      // FR
      "Yüz düz değil."};                               // TR

    public static readonly string[] CuttingErr ={
      "Cutting plane method does not work.",
      "Не сработал метод отрезания плоскостью.",
      "Metodo Poligono slice (piano di taglio) non funziona.",
      "Die ebene Schneidemethode hat nicht funktioniert.",
      "切割平面方法不起作用。",
      "El método de plano de corte no funciona.",      // ES
      "La méthode du plan de coupe ne fonctionne pas.",  // FR
      "Kesme düzlemi yöntemi çalışmıyor."};            // TR

    public static readonly string[] CuttingDone = {
      "Cutting plane method worked.",
      "Сработал slice плоскость.",
      "Metodo poligono slice (piano di taglio) riuscito.",
      "Schnittebenenmethode funktioniert.",
      "切割平面方法有效。",
      "El método de plano de corte funcionó.",         // ES
      "La méthode du plan de coupe a fonctionné.",     // FR
      "Kesme düzlemi yöntemi çalıştı."};               // TR

    public static readonly string[] SurfaceCreateErr = {
      "Can't create surface.",
      "Не получилось создать поверхность.",
      "Non è possibile creare superfici.",
      "Oberfläche konnte nicht erstellt werden.",
      "无法创建曲面。",
      "No se puede crear la superficie.",              // ES
      "Impossible de créer une surface.",              // FR
      "Yüzey oluşturulamıyor." };                      // TR

    public static readonly string[] OffsetSurfErr ={
      "Can't create offset surface.",
      "Не получилось создать поверхность с отступом от выбранной.",
      "Non è possibile creare superfici con offset.",
      "Es war nicht möglich, eine von der ausgewählten eingerückte Oberfläche zu erstellen.",
      "无法创建偏移曲面。",
      "No se puede crear superficie con desplazamiento.",  // ES
      "Impossible de créer une surface décalée.",      // FR
      "Ofset yüzey oluşturulamıyor."};                 // TR

    public static readonly string[] SurfaceErr ={
      "Cutting curved surface method does not work.",
      "Не сработал метод отрезания криволинейной поверхностью.",
      "Metodo di taglio superficie curva non funziona.",
      "Die Methode des Schneidens mit einer gekrümmten Oberfläche funktionierte nicht.",
      "切割曲面的方法不起作用。",
      "El método de superficie curva de corte no funciona.",  // ES
      "La méthode de surface courbe de coupe ne fonctionne pas.",  // FR
      "Kesme eğri yüzey yöntemi çalışmıyor."};         // TR

    public static readonly string[] SurfaceSaved ={
      "\nCutting surface is saved.",
      "\nСохраняем поверхность реза.",
      "\nSalvare la superficie di taglio.",
      "\nWir speichern eine Schnittfläche.",
      "\n切割面被保存。",
      "\nLa superficie de corte se guarda.",           // ES
      "\nLa surface de coupe est enregistrée.",        // FR
      "\nKesim yüzeyi kaydedildi." };                  // TR

    public static readonly string[] SurfaceDone ={
      "Curved surface method worked.",
      "Сработал метод отрезания криволинейной поверхностью.",
      "Metodo di superficie curva lavorato.",
      "Die Methode des Schneidens mit einer gekrümmten Oberfläche funktionierte.",
      "曲面法奏效了。",
      "El método de superficie curva funcionó.",       // ES
      "La méthode de surface courbe a fonctionné.",    // FR
      "Eğri yüzey yöntemi çalıştı."};                  // TR

    public static readonly string[] OffsetDone ={
      "Face offset method worked.",
      "Сработал метод сдвига грани.",
      "Metodo di offset facciata lavorato.",
      "Die Face-Shift-Methode hat funktioniert.",
      "面部偏移方法有效。",
      "El método de desplazamiento de cara funcionó.", // ES
      "La méthode de décalage de face a fonctionné.",  // FR
      "Yüz ofset yöntemi çalıştı."};                   // TR

    public static readonly string[] ShapeErr ={
      "The cutting plane did not divide the object into 2 parts. The shape of the solid does not allow using this method.",
      "Секущая плоскость не разделила объект на 2 части. Форма тела не позволяет использовать данный метод.",
      "Il piano di taglio non ha diviso l'oggetto in 2 parti. La forma del corpo non consente l'utilizzo di questo metodo.",
      "Die Schnittebene teilte das Objekt nicht in zwei Teile. Die Körperform erlaubt die Verwendung dieser Methode nicht.",
      "切割平面没有将对象分成两部分。 实体的形状不允许使用此方法。",
      "El plano de corte no dividió el objeto en 2 partes. La forma del sólido no permite usar este método.",  // ES
      "Le plan de coupe n'a pas divisé l'objet en 2 parties. La forme du solide ne permet pas d'utiliser cette méthode.",  // FR
      "Kesme düzlemi nesneyi 2 parçaya bölmedi. Katının şekli bu yöntemin kullanılmasına izin vermiyor." };  // TR

    public static readonly string[] SliceCount = {
      "  Made {0} slicing.",
      "  Сделано {0} отслоений.",
      "  Gestito per effettuare {0} tagli.",
      "  {0} Schneiden gemacht",
      "  进行了 {0} 次切片。",
      "  Se realizaron {0} cortes.",                   // ES
      "  {0} découpes effectuées.",                    // FR
      "  {0} dilim yapıldı."};                         // TR

    public static readonly string[] MiterCount = {
      "  Made {0} miter joints. Failed - {1}",
      "  Сделано {0} стыков под ус. Не удалось - {1}",
      "  Realizzato {0} mitra comune. Non riuscito - {1}",
      "  Gefertigte {0} Gehrungsfugen. Fehlgeschlagen - {1}",
      "  制作了 {0} 个斜接接头。 失败 - {1}",
      "  Se realizaron {0} uniones en inglete. Fallidas - {1}",  // ES
      "  {0} joints à onglet réalisés. Échecs - {1}",  // FR
      "  {0} gönye birleştirme yapıldı. Başarısız - {1}" };  // TR

    // ============================================ SliceOptionsBox ========================================

    public static readonly string[] StyleNameTip = {
      "The name for this slice-style (set of settings). \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Название для этого стиля команд Отслоения и Мульти-Отслоения. \r\n" +
        "Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile ASL|MSL (set di impostazioni). \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen ASL|MSL (Satz von Einstellungen). \r\n" +
        "Wird im Programm nicht verwendet. Nur zur Bequemlichkeit der Wahl.",
      "此切片样式（设置集）的名称。 \r\n" +
        "在程序中没有使用。只是为了方便选择。",
      "El nombre para este estilo de corte (conjunto de configuraciones). \r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia de elección.",
      "Le nom de ce style de découpe (ensemble de paramètres). \r\n" +  // FR
        "Non utilisé dans le programme. Uniquement pour la commodité du choix.",
      "Bu dilim stili için ad (ayar kümesi). \r\n" +  // TR
        "Programda kullanılmaz. Sadece seçim kolaylığı için."};

    public static readonly string[] ThicknessTip ={
      "The thickness of the cutted slices. \r\n" +
        "In any case, the thickness will be requested each time the command is called.",
      "Толщина отслаиваемой дольки. \r\n" +
        "В любом случае толщина будет запрошена при каждом вызове команды.",
      "Lo spessore delle fette tagliate.\r\n" +
        "Ad ogni richiamo del comando verrà comunque richiesto lo spessore.",
      "Die Dicke der geschnittenen Scheiben.\r\n" +
        "In jedem Fall wird die Dicke bei jedem Aufruf des Befehls abgefragt.",
      "切片的厚度。\r\n" +
        "在任何情况下，每次调用命令时都会请求厚度。",
      "El espesor de los cortes cortados. \r\n" +  // ES
        "En cualquier caso, se solicitará el espesor cada vez que se llame al comando.",
      "L'épaisseur des tranches coupées. \r\n" +  // FR
        "Dans tous les cas, l'épaisseur sera demandée à chaque appel de la commande.",
      "Kesilen dilimlerin kalınlığı. \r\n" +  // TR
        "Her durumda, komut her çağrıldığında kalınlık istenecektir."};

    public static readonly string[] ContiguousFaces ={
      "Select Contiguous Faces",
      "Выбрать смежные",
      "Seleziona Facce contigue",
      "Wählen Sie Angrenzende",
      "选择连续的面",
      "Seleccionar caras contiguas",                   // ES
      "Sélectionner les faces contiguës",              // FR
      "Bitişik yüzleri seç"};                          // TR

    public static readonly string[] ContiguousFacesTip ={
      "Automatically add adjacent to the selected surfaces,\r\n" +
        "i.e. conjugate without kink (kink not more than 0.1 degrees between tangents).\r\n" +
        "Do not use this option in conjunction with the Miter option,\r\n" +
        "since the Miter Joint program does not know how to make joints on curved edges.",
      "Автоматически добавлять к выбранным поверхностям смежные, т.е. сопряженные без излома \r\n" +
        "(излом не более 0.1 градуса между касательными).\r\n" +
        "Не используйте эту опцию совместно с опцией 'Стык под ус',\r\n" +
        "так как программа стыковки под ус не умеет делать стыки на криволинейных ребрах.",
      "Aggiungi automaticamente adiacenti alle superfici selezionate,\r\n" +
        "cioè coniugato senza attorcigliamento (attorcigliamento non superiore a 0,1 gradi tra le tangenti).\r\n" +
        "Non utilizzare questa opzione insieme all'opzione Mitra,\r\n" +
        "poiché il programma Mitre Joint non sa come realizzare giunti su bordi curvi.",
      "Automatisch angrenzend an die ausgewählten Flächen hinzufügen,\r\n" +
        "d.h. konjugieren ohne Knick (Knick nicht mehr als 0,1 Grad zwischen Tangenten).\r\n" +
        "Verwenden Sie diese Option nicht in Verbindung mit der Mitre-Option,\r\n" +
        "da das Gehrungsverbindungsprogramm nicht weiß, wie man Verbindungen an gekrümmten Kanten herstellt.",
      "自动添加相邻的选定曲面，即没有扭结的共轭（切线之间的扭结不超过0.1度）。\r\n" +
        "不要将此选项与斜接选项一起使用，因为斜接关节程序不知道如何在弯曲边缘上制作关节。",
      "Agregar automáticamente adyacente a las superficies seleccionadas,\r\n" +  // ES
        "es decir, conjugado sin torcedura (torcedura no mayor de 0.1 grados entre tangentes).\r\n" +
        "No use esta opción junto con la opción de Inglete,\r\n" +
        "ya que el programa de Unión en Inglete no sabe cómo hacer uniones en bordes curvos.",
      "Ajouter automatiquement adjacentes aux surfaces sélectionnées,\r\n" +  // FR
        "c'est-à-dire conjuguées sans pliure (pliure pas plus de 0,1 degré entre les tangentes).\r\n" +
        "N'utilisez pas cette option avec l'option Onglet,\r\n" +
        "car le programme Joint à Onglet ne sait pas comment faire des joints sur des arêtes courbes.",
      "Seçilen yüzeylere otomatik olarak bitişik ekleyin,\r\n" +  // TR
        "yani bükülme olmadan eşlenik (teğetler arasında 0,1 dereceden fazla olmayan bükülme).\r\n" +
        "Bu seçeneği Gönye seçeneği ile birlikte kullanmayın,\r\n" +
        "çünkü Gönye Ekleme programı eğri kenarlarda nasıl ekleme yapılacağını bilmiyor."};

    public static readonly string[] Cyclically ={
      "Run Cyclically",
      "Запускать циклически",
      "Esegui ciclicamente",
      "Zyklisch ausführen",
      "循环运行",
      "Ejecutar cíclicamente",                         // ES
      "Exécuter de manière cyclique",                  // FR
      "Döngüsel olarak çalıştır"};                     // TR

    public static readonly string[] CyclicallyTip ={
      "Continue selecting solids and their surfaces for new cuts until you press ESC.",
      "Зациклить - продолжать выбор солидов и их поверхностей для новых отслоений до нажатия ESC.",
      "Ciclo: continua a selezionare i solidi e le loro superfici per nuove delaminazioni finché non viene premuto ESC.",
      "Schleife - Fahren Sie mit der Auswahl von Festkörpern und deren Oberflächen für neue Delaminierungen fort, bis ESC gedrückt wird.",
      "循环 - 继续选择固体及其表面以进行新的分层，直到按下 ESC。",
      "Continuar seleccionando sólidos y sus superficies para nuevos cortes hasta que presione ESC.",  // ES
      "Continuer à sélectionner des solides et leurs surfaces pour de nouvelles découpes jusqu'à ce que vous appuyiez sur ESC.",  // FR
      "ESC tuşuna basana kadar yeni kesimler için katıları ve yüzeylerini seçmeye devam edin."};  // TR

    public static readonly string[] SaveStub ={
      "Save Stub",
      "Сохранять кочерыжку",
      "Salva Stub",
      "Stub speichern",
      "保存存根",
      "Guardar muñón",                                 // ES
      "Enregistrer le moignon",                        // FR
      "Güdüğü kaydet"};                                // TR

    public static readonly string[] SaveStubTip ={
      "Leave in the drawing an internal piece of solid remaining after cutting off all surfaces. \r\n" +
        "The option only works with the MultiSlice (MSL) command.\r\n" +
        "Normal A>V>C> Slice (ASL) command always preserves both solids.",
      "Оставить в чертеже внутренний кусок солида, оставшийся после отрезания всех поверхностей.\r\n" +
        "Опция работает только с командой Мульти-Отслоения (MSL).\r\n" +
        "Обычное отслоение (ASL) всегда сохраняет оба тела.",
      "Lascia nel disegno un pezzo interno di solido rimanente dopo aver tagliato tutte le superfici.\r\n" +
        "L'opzione funziona solo con il comando MultiSlice (MSL).\r\n" +
        "Il comando normale A>V>C> Slice (ASL) conserva sempre entrambi i solidi.",
      "Lassen Sie nach dem Abschneiden aller Flächen in der Zeichnung ein inneres Stück Festkörper zurück.\r\n" +
        "Die Option funktioniert nur mit dem Befehl MultiSlice (MSL).\r\n" +
        "Der normale Befehl A>V>C> Slice (ASL) behält immer beide Volumenkörper bei.",
      "切掉所有表面后，在图纸中留下一块内部实体。\r\n" +
        "该选项仅适用于 MultiSlice (MSL) 命令。\r\n" +
        "普通 A>V>C> 切片 (ASL) 命令始终保留两个实体。",
      "Dejar en el dibujo una pieza interna de sólido que queda después de cortar todas las superficies. \r\n" +  // ES
        "La opción solo funciona con el comando MultiSlice (MSL).\r\n" +
        "El comando normal A>V>C> Slice (ASL) siempre conserva ambos sólidos.",
      "Laisser dans le dessin un morceau interne de solide restant après avoir coupé toutes les surfaces. \r\n" +  // FR
        "L'option ne fonctionne qu'avec la commande MultiSlice (MSL).\r\n" +
        "La commande normale A>V>C> Slice (ASL) préserve toujours les deux solides.",
      "Tüm yüzeyler kesildikten sonra çizimde kalan bir iç katı parça bırakın. \r\n" +  // TR
        "Seçenek yalnızca MultiSlice (MSL) komutuyla çalışır.\r\n" +
        "Normal A>V>C> Slice (ASL) komutu her zaman her iki katıyı da korur."};

    public static readonly string[] SaveSurfaceOnError ={
      "Save Surface On Error",
      "Сохранять поверхность",
      "Conserva la superficie",
      "Oberfläche bewahren",
      "保留表面",
      "Guardar superficie en caso de error",           // ES
      "Enregistrer la surface en cas d'erreur",        // FR
      "Hata durumunda yüzeyi kaydet"};                 // TR

    public static readonly string[] SaveSurfaceOnErrorTip ={
      "write in the drawing a curved surface with which the program tried to cut, \r\n" +
        "but the attempt failed.\r\n" +
        "You can modify this surface and use it for the _Slice command.",
      "записать в чертеж криволинейную поверхность, \r\n" +
        "с помощью которой программа пыталась резать, но попытка провалилась.\r\n" +
        "Вы сможете модифицировать эту поверхность и использовать ее для команды _Slice.",
      "scrivi nel disegno una superficie curva con cui il programma ha provato a tagliare,\r\n" +
        "ma il tentativo è fallito.\r\n" +
        "È possibile modificare questa superficie e utilizzarla per il comando _Slice.",
      "schreibe in die Zeichnung eine gekrümmte Fläche, mit der das Programm versucht hat zu schneiden,\r\n" +
        "aber der Versuch scheiterte.\r\n" +
        "Sie können diese Oberfläche ändern und für den Befehl _Slice verwenden.",
      "在图中写下程序试图切割的曲面，但尝试失败了。\r\n" +
        "您可以修改此曲面并将其用于 _Slice 命令。",
      "escribir en el dibujo una superficie curva con la que el programa intentó cortar, \r\n" +  // ES
        "pero el intento falló.\r\n" +
        "Puede modificar esta superficie y usarla para el comando _Slice.",
      "écrire dans le dessin une surface courbe avec laquelle le programme a essayé de couper, \r\n" +  // FR
        "mais la tentative a échoué.\r\n" +
        "Vous pouvez modifier cette surface et l'utiliser pour la commande _Slice.",
      "çizime programın kesmeye çalıştığı eğri bir yüzey yazın, \r\n" +  // TR
        "ancak deneme başarısız oldu.\r\n" +
        "Bu yüzeyi değiştirebilir ve _Slice komutu için kullanabilirsiniz."};



    public static readonly string[] Method ={
      "Method",
      "Метод отслоения",
      "Metodo",
      "Peel-Methode",
      "剥离法",
      "Método",                                        // ES
      "Méthode",                                       // FR
      "Yöntem"};                                       // TR

    public static readonly string[] AllMethods ={
      "All 3",
      "Все 3",
      "Tutti 3",
      "Alle 3",
      "全部 3",
      "Los 3",                                         // ES
      "Les 3",                                         // FR
      "3'ü de"};                                       // TR

    public static readonly string[] AllMethodsTip ={
      "Try to use all three methods in the following sequence: offset, plane, surface. (default)",
      "Перебирать все три метода автоматически в следующем порядке: Сдвигом, Плоскостью, Поверхностью.",
      "Prova a utilizzare tutti e tre i metodi nella seguente sequenza: offset, piano, superficie. (predefinito)",
      "Versuchen Sie, alle drei Methoden in der folgenden Reihenfolge anzuwenden: Versatz, Ebene, Fläche. (Ursprünglich)",
      "尝试按以下顺序使用所有三种方法：偏移、平面、曲面。 （默认）",
      "Intente usar los tres métodos en la siguiente secuencia: desplazamiento, plano, superficie. (predeterminado)",  // ES
      "Essayez d'utiliser les trois méthodes dans l'ordre suivant : décalage, plan, surface. (par défaut)",  // FR
      "Üç yöntemi de şu sırayla kullanmayı deneyin: ofset, düzlem, yüzey. (varsayılan)"};  // TR

    public static readonly string[] OffsetMethod ={
      "Offset",
      "Сдвигом",
      "Offset",
      "Versatz",
      "抵消",
      "Desplazamiento",                                // ES
      "Décalage",                                      // FR
      "Ofset"};                                        // TR

    public static readonly string[] OffsetMethodTip ={
      "The program makes a copy of the solid and offset the selected face inside. \r\n" +
        "Then, a it small copy is subtracted from the original solid.\r\n" +
        "This method gives the best results in most cases.\r\n" +
        "However, there are restrictions.",
      "Программа делает копию солида и сдвигает ему выбранную грань внутрь (делает офсет поверхности).\r\n" +
        "Затем производится вычитание уменьшенной копии из исходного тела.\r\n" +
        "Этот метод дает наилучшие результаты в большинстве случаев.",
      "Il programma esegue una copia del solido e sposta all'interno la faccia selezionata.\r\n" +
        "Quindi, una piccola copia viene sottratta dal solido originale.\r\n" +
        "Questo metodo fornisce i migliori risultati nella maggior parte dei casi.\r\n" +
        "Tuttavia, ci sono delle restrizioni.",
      "Das Programm erstellt eine Kopie des Volumenkörpers und versetzt die ausgewählte Fläche nach innen.\r\n" +
        "Dann wird eine kleine Kopie von dem ursprünglichen Festkörper subtrahiert.\r\n" +
        "Diese Methode liefert in den meisten Fällen die besten Ergebnisse. \r\n" +
        "Allerdings gibt es Einschränkungen.",
      "程序制作实体的副本并在其中偏移选定的面。然后，从原始实体中减去一个很小的副本。\r\n" +
        "在大多数情况下，此方法可提供最佳结果。但是，有一些限制。",
      "El programa hace una copia del sólido y desplaza la cara seleccionada hacia adentro. \r\n" +  // ES
        "Luego, se resta una pequeña copia del sólido original.\r\n" +
        "Este método da los mejores resultados en la mayoría de los casos.\r\n" +
        "Sin embargo, existen restricciones.",
      "Le programme fait une copie du solide et décale la face sélectionnée vers l'intérieur. \r\n" +  // FR
        "Ensuite, une petite copie est soustraite du solide d'origine.\r\n" +
        "Cette méthode donne les meilleurs résultats dans la plupart des cas.\r\n" +
        "Cependant, il y a des restrictions.",
      "Program katının bir kopyasını oluşturur ve seçilen yüzü içe doğru ofsette eder. \r\n" +  // TR
        "Ardından, orijinal katıdan küçük bir kopya çıkarılır.\r\n" +
        "Bu yöntem çoğu durumda en iyi sonuçları verir.\r\n" +
        "Ancak kısıtlamalar vardır."};

    public static readonly string[] PlaneMethod ={
      "Plane",
      "Плоскостью",
      "Aereo",
      "Flugzeug",
      "飞机",
      "Plano",                                         // ES
      "Plan",                                          // FR
      "Düzlem"};                                       // TR

    public static readonly string[] PlaneMethodTip ={
      "The program builds a plane along the selected face, shifts it by a given thickness and cuts the solid by this plane. \r\n" +
        "This is the simplest method, but it is not suitable for curved faces.\r\n" +
        "Another problem is that the solid will be cut through, because the plane is infinite.\r\n" +
        "This can be inconvenient when the solid is strongly bent.",
      "Программа строит плоскость по выбранной грани, сдвигает ее на заданную толщину и разрезает тело этой плоскостью. \r\n" +
        "Это самый простой метод, но он не подходит для гнутых граней.\r\n" +
        "Еще одна проблема - тело будет разрезано на вылет, ведь плоскость бесконечна.\r\n" +
        "Это может быть неудобно, когда деталь сильно изогнута.",
      "Il programma costruisce un piano lungo la faccia selezionata, \r\n" +
        "lo sposta di un determinato spessore e taglia il solido in base a questo piano.\r\n" +
        "Questo è il metodo più semplice, ma non è adatto per facce curve.\r\n" +
        "Un altro problema è che il solido verrà tagliato, perché il piano è infinito.\r\n" +
        "Questo può essere scomodo quando il solido è fortemente piegato.",
      "Das Programm baut eine Ebene entlang der ausgewählten Fläche auf, \r\n" +
        "verschiebt sie um eine bestimmte Dicke und schneidet den Volumenkörper um diese Ebene.\r\n" +
        "Dies ist die einfachste Methode, aber sie ist nicht für gekrümmte Flächen geeignet.\r\n" +
        "Ein weiteres Problem ist, dass der Körper durchgeschnitten wird, da die Ebene unendlich ist.\r\n" +
        "Dies kann unpraktisch sein, wenn der Festkörper stark gebogen ist.",
      "程序沿选定的面构建一个平面，将其移动给定的厚度，并通过该平面切割实体。\r\n" +
        "这是最简单的方法，但不适用于曲面。另一个问题是实体会被切穿，因为平面是无限的。\r\n" +
        "当固体被强烈弯曲时，这可能是不方便的。",
      "El programa construye un plano a lo largo de la cara seleccionada, lo desplaza por un espesor dado y corta el sólido por este plano. \r\n" +  // ES
        "Este es el método más simple, pero no es adecuado para caras curvas.\r\n" +
        "Otro problema es que el sólido se cortará completamente, porque el plano es infinito.\r\n" +
        "Esto puede ser inconveniente cuando el sólido está muy doblado.",
      "Le programme construit un plan le long de la face sélectionnée, le décale d'une épaisseur donnée et coupe le solide par ce plan. \r\n" +  // FR
        "C'est la méthode la plus simple, mais elle ne convient pas aux faces courbes.\r\n" +
        "Un autre problème est que le solide sera coupé à travers, car le plan est infini.\r\n" +
        "Cela peut être gênant lorsque le solide est fortement courbé.",
      "Program seçilen yüz boyunca bir düzlem oluşturur, onu belirli bir kalınlık kadar kaydırır ve katıyı bu düzlemle keser. \r\n" +  // TR
        "Bu en basit yöntemdir, ancak eğri yüzler için uygun değildir.\r\n" +
        "Başka bir sorun da düzlem sonsuz olduğu için katının tamamen kesilecek olmasıdır.\r\n" +
        "Bu, katı güçlü bir şekilde büküldüğünde rahatsız edici olabilir."};

    public static readonly string[] SurfaceMethod ={
      "Surface",
      "Поверхностью",
      "Superficie",
      "Auftauchen",
      "表面",
      "Superficie",                                    // ES
      "Surface",                                       // FR
      "Yüzey"};                                        // TR

    public static readonly string[] SurfaceMethodTip ={
      "The program takes the surface of the face (flat or curvilinear), \r\n" +
        "offset it inward by the thickness and then cuts the body with this surface. \r\n" +
        "Often the surface is not enough to cut the entire solid.\r\n" +
        "Then the program saves the surface in the drawing so that you can complete it and make the cut into a manual one.\r\n" +
        "The method is quite dangerous, program can stop working with a fatal error. Especially older versions of AutoCAD until 2016.\r\n" +
        "To avoid fatal errors, the program checks the validity of the solid and warns the user if it is not valid.",
      "Программа берет поверхность грани (плоскую или криволинейную), \r\n" +
        "сдвигает ее внутрь (offset) на толщину и затем режет тело этой поверхностью.\r\n" +
        "Часто поверхности недостаточно, чтоб разрезать все тело.\r\n" +
        "Тогда программа сохраняет в чертеже поверхность, чтоб вы могли ее достроить и сделать разрез в ручную.\r\n" +
        "Метод довольно опасен, Автокада может прекратить работу с фатальной ошибкой.\r\n" +
        "Особенно старые версии Автокада до 2016.\r\n" +
        "Во избежании фаталов программа проверяет валидность солида и предупреждает пользователя, если он не валидный. ",
      "Il programma prende la superficie della faccia (piatta o curvilinea), \r\n" +
        "la sfalsa verso l'interno dello spessore e quindi taglia il corpo con questa superficie.\r\n" +
        "Spesso la superficie non è sufficiente per tagliare l'intero solido.\r\n" +
        "Quindi il programma salva la superficie nel disegno in modo che tu possa completarla e realizzare il taglio in manuale.\r\n" +
        "Il metodo è piuttosto pericoloso, il programma può smettere di funzionare con un errore fatale. \r\n" +
        "Soprattutto le versioni precedenti di AutoCAD fino al 2016.\r\n" +
        "Per evitare errori fatali, il programma verifica la validità del solido e avverte l'utente se non è valido.",
      "Das Programm nimmt die Oberfläche der Fläche (flach oder krummlinig), \r\n" +
        "versetzt sie um die Dicke nach innen und schneidet dann den Körper mit dieser Oberfläche.\r\n" +
        "Oftmals reicht die Fläche nicht aus, um den gesamten Festkörper zu schneiden.\r\n" +
        "Dann speichert das Programm die Oberfläche in der Zeichnung, damit Sie sie vervollständigen und den Schnitt manuell machen können.\r\n" +
        "Die Methode ist ziemlich gefährlich, das Programm kann mit einem schwerwiegenden Fehler aufhören zu arbeiten. Insbesondere ältere Versionen von AutoCAD bis 2016.\r\n" +
        "Um schwerwiegende Fehler zu vermeiden, überprüft das Programm die Gültigkeit des Festkörpers und warnt den Benutzer, wenn er nicht gültig ist.",
      "该程序采用面的表面（平面或曲线），将其向内偏移厚度，然后用该表面切割身体。\r\n" +
        "通常表面不足以切割整个实体。然后程序将表面保存在图纸中，以便您完成它并将切割变成手动切割。\r\n" +
        "该方法非常危险，程序可能会因致命错误而停止工作。 尤其是 2016 年之前的 AutoCAD 旧版本。\r\n" +
        "为避免致命错误，程序会检查实体的有效性，并在无效时警告用户。",
      "El programa toma la superficie de la cara (plana o curvilínea), \r\n" +  // ES
        "la desplaza hacia adentro por el espesor y luego corta el cuerpo con esta superficie. \r\n" +
        "A menudo, la superficie no es suficiente para cortar todo el sólido.\r\n" +
        "Entonces el programa guarda la superficie en el dibujo para que pueda completarla y hacer el corte manualmente.\r\n" +
        "El método es bastante peligroso, el programa puede dejar de funcionar con un error fatal. Especialmente versiones antiguas de AutoCAD hasta 2016.\r\n" +
        "Para evitar errores fatales, el programa verifica la validez del sólido y advierte al usuario si no es válido.",
      "Le programme prend la surface de la face (plate ou curviligne), \r\n" +  // FR
        "la décale vers l'intérieur de l'épaisseur puis coupe le corps avec cette surface. \r\n" +
        "Souvent, la surface ne suffit pas pour couper tout le solide.\r\n" +
        "Alors le programme enregistre la surface dans le dessin afin que vous puissiez la compléter et faire la coupe manuellement.\r\n" +
        "La méthode est assez dangereuse, le programme peut cesser de fonctionner avec une erreur fatale. Surtout les anciennes versions d'AutoCAD jusqu'en 2016.\r\n" +
        "Pour éviter les erreurs fatales, le programme vérifie la validité du solide et avertit l'utilisateur s'il n'est pas valide.",
      "Program yüzün yüzeyini alır (düz veya eğrisel), \r\n" +  // TR
        "onu kalınlık kadar içe doğru ofsette eder ve ardından vücudu bu yüzeyle keser. \r\n" +
        "Çoğu zaman yüzey tüm katıyı kesmek için yeterli değildir.\r\n" +
        "Ardından program yüzeyi çizime kaydeder, böylece onu tamamlayabilir ve kesimi manuel olarak yapabilirsiniz.\r\n" +
        "Yöntem oldukça tehlikelidir, program önemli bir hatayla çalışmayı durdurabilir. Özellikle 2016'ya kadar eski AutoCAD sürümleri.\r\n" +
        "Önemli hataları önlemek için program katının geçerliliğini kontrol eder ve geçerli değilse kullanıcıyı uyarır."};

    public static readonly string[] Select ={
      "Face AutoSelection",
      "Автовыбор поверхностей",
      "Selezione della superficie automatica",
      "Auswahl der automatischen Oberfläche",
      "自动曲面选择",
      "Selección automática de cara",                  // ES
      "Sélection automatique de face",                 // FR
      "Yüz otomatik seçimi"};                          // TR

    public static readonly string[] SelectTip ={
      "Automatically select solid surfaces for multi-slicing.",
      "Автоматически выбирать поверхности солидов для мульти-отслоения.",
      "Seleziona automaticamente le superfici solide per il multi-slicing.",
      "Wählen Sie automatisch feste Oberflächen für das Multi-Slicing aus.",
      "自动选择实体表面进行多重切片。",
      "Seleccionar automáticamente superficies sólidas para corte múltiple.",  // ES
      "Sélectionner automatiquement les surfaces solides pour la découpe multiple.",  // FR
      "Çoklu dilimleme için otomatik olarak katı yüzeyleri seçin."};  // TR

    public static readonly string[] CutShell ={
      "All = Shell",
      "Все = Оболочка",
      "Tutte le facce",
      "Alle Flächen",
      "所有面 = 壳",
      "Todo = Carcasa",                                // ES
      "Tout = Coque",                                  // FR
      "Tümü = Kabuk"};                                 // TR

    public static readonly string[] CutAcross ={
      "Across",
      "Поперек",
      "Attraverso",
      "Über",
      "穿过",
      "A través",                                      // ES
      "À travers",                                     // FR
      "Karşıya"};                                      // TR

    public static readonly string[] CutAlongTip ={
        "  Cutting surfaces along the longest straight edge of a part",
        "  Отслаивание поверхностей вдоль самого длинного прямого ребра детали",
        "  Taglio di superfici lungo il bordo diritto più lungo di una parte",
        "  Abblätternde Oberflächen entlang der längsten geraden Kante des Teils" ,
        "  沿零件最长直边切割表面",
        "  Cortar superficies a lo largo del borde recto más largo de una pieza",  // ES
        "  Coupe de surfaces le long du bord droit le plus long d'une pièce",  // FR
        "  Bir parçanın en uzun düz kenarı boyunca yüzey kesme"};  // TR

    public static readonly string[] CutAlong ={
      "Along",
      "Вдоль",
      "Lungo",
      "Eine lange",
      "沿着",
      "A lo largo",                                    // ES
      "Le long",                                       // FR
      "Boyunca"};                                      // TR

    public static readonly string[] CutAcrossTip ={
        "  Cutting surfaces across the longest straight edge of the part",
        "  Отслаивание поверхностей поперек самого длинного прямого ребра детали",
        "  Taglio di superfici attraverso il bordo rettilineo più lungo della parte",
        "  Abblätternde Oberflächen über die längste gerade Kante des Teils" ,
        "  跨越零件最长直边的切割面",
        "  Cortar superficies a través del borde recto más largo de la pieza",  // ES
        "  Coupe de surfaces à travers le bord droit le plus long de la pièce",  // FR
        "  Parçanın en uzun düz kenarından yüzey kesme"};  // TR

    public static readonly string[] CutXTip ={
      "Cut faces along a given UCS axis X. \r\n" +
        "All flat surfaces parallel to this coordinate axis will be machined.\r\n" +
        "As well as cylindrical surfaces in which the axis of the cylinder is parallel to the coordinate axis.",
      "Отслоить грани вдоль заданной оси ПСК X. \r\n" +
        "Будут обработаны все плоские поверхности, параллельные этой оси координат.\r\n" +
        "А так же цилиндрические поверхности, у которых ось цилиндра параллельна оси координат.",
      "Taglia le facce lungo un dato asse UCS X.\r\n" +
        "Verranno lavorate tutte le superfici piane parallele a questo asse di coordinate.\r\n" +
        "Così come le superfici cilindriche in cui l'asse del cilindro è parallelo all'asse delle coordinate.",
      "Schnittflächen entlang einer gegebenen BKS-Achse X.\r\n" +
        "Alle ebenen Flächen parallel zu dieser Koordinatenachse werden bearbeitet.\r\n" +
        "Sowie Zylinderflächen, bei denen die Achse des Zylinders parallel zur Koordinatenachse ist.",
      "沿给定 UCS 轴 X 切割面。将加工平行于该坐标轴的所有平面。\r\n" +
        "以及圆柱的轴线与坐标轴平行的圆柱表面。",
      "Cortar caras a lo largo de un eje UCS X dado. \r\n" +  // ES
        "Se mecanizarán todas las superficies planas paralelas a este eje de coordenadas.\r\n" +
        "Así como superficies cilíndricas en las que el eje del cilindro es paralelo al eje de coordenadas.",
      "Couper les faces le long d'un axe UCS X donné. \r\n" +  // FR
        "Toutes les surfaces planes parallèles à cet axe de coordonnées seront usinées.\r\n" +
        "Ainsi que les surfaces cylindriques dans lesquelles l'axe du cylindre est parallèle à l'axe de coordonnées.",
      "Verilen bir UCS X ekseni boyunca yüzleri kesin. \r\n" +  // TR
        "Bu koordinat eksenine paralel tüm düz yüzeyler işlenecektir.\r\n" +
        "Ayrıca silindirin ekseni koordinat eksenine paralel olan silindirik yüzeyler."};

    public static readonly string[] CutYTip ={
      "Cut faces along a given UCS axis Y.\r\n" +
        "All flat surfaces parallel to this coordinate axis will be machined.\r\n" +
        "As well as cylindrical surfaces in which the axis of the cylinder is parallel to the coordinate axis.",
      "Отслоить грани вдоль заданной оси ПСК Y.\r\n" +
        "Будут обработаны все плоские поверхности, параллельные этой оси координат.\r\n" +
        "А так же цилиндрические поверхности, у которых ось цилиндра параллельна оси координат.",
      "Taglia le facce lungo un dato asse UCS Y.\r\n" +
        "Verranno lavorate tutte le superfici piane parallele a questo asse di coordinate.\r\n" +
        "Così come le superfici cilindriche in cui l'asse del cilindro è parallelo all'asse delle coordinate.",
      "Schnittflächen entlang einer gegebenen BKS-Achse Y.\r\n" +
        "Alle ebenen Flächen parallel zu dieser Koordinatenachse werden bearbeitet.\r\n" +
        "Sowie Zylinderflächen, bei denen die Achse des Zylinders parallel zur Koordinatenachse ist.",
      "沿给定 UCS 轴 Y 切割面。将加工平行于该坐标轴的所有平面。\r\n" +
        "以及圆柱的轴线与坐标轴平行的圆柱表面。",
      "Cortar caras a lo largo de un eje UCS Y dado.\r\n" +  // ES
        "Se mecanizarán todas las superficies planas paralelas a este eje de coordenadas.\r\n" +
        "Así como superficies cilíndricas en las que el eje del cilindro es paralelo al eje de coordenadas.",
      "Couper les faces le long d'un axe UCS Y donné.\r\n" +  // FR
        "Toutes les surfaces planes parallèles à cet axe de coordonnées seront usinées.\r\n" +
        "Ainsi que les surfaces cylindriques dans lesquelles l'axe du cylindre est parallèle à l'axe de coordonnées.",
      "Verilen bir UCS Y ekseni boyunca yüzleri kesin.\r\n" +  // TR
        "Bu koordinat eksenine paralel tüm düz yüzeyler işlenecektir.\r\n" +
        "Ayrıca silindirin ekseni koordinat eksenine paralel olan silindirik yüzeyler."};

    public static readonly string[] CutZTip ={
      "Cut faces along a given UCS axis Z. \r\n" +
        "All flat surfaces parallel to this coordinate axis will be machined.\r\n" +
        "As well as cylindrical surfaces in which the axis of the cylinder is parallel to the coordinate axis.",
      "Отслоить грани вдоль заданной оси ПСК Z. \r\n" +
        "Будут обработаны все плоские поверхности, параллельные этой оси координат.\r\n" +
        "А так же цилиндрические поверхности, у которых ось цилиндра параллельна оси координат.",
      "Taglia le facce lungo un dato asse UCS Z.\r\n" +
        "Verranno lavorate tutte le superfici piane parallele a questo asse di coordinate.\r\n" +
        "Così come le superfici cilindriche in cui l'asse del cilindro è parallelo all'asse delle coordinate.",
      "Schnittflächen entlang einer gegebenen BKS-Achse Z.\r\n" +
        "Alle ebenen Flächen parallel zu dieser Koordinatenachse werden bearbeitet.\r\n" +
        "Sowie Zylinderflächen, bei denen die Achse des Zylinders parallel zur Koordinatenachse ist.",
      "沿给定 UCS 轴 Z 切割面。将加工平行于该坐标轴的所有平面。\r\n" +
        "以及圆柱的轴线与坐标轴平行的圆柱表面。",
      "Cortar caras a lo largo de un eje UCS Z dado. \r\n" +  // ES
        "Se mecanizarán todas las superficies planas paralelas a este eje de coordenadas.\r\n" +
        "Así como superficies cilíndricas en las que el eje del cilindro es paralelo al eje de coordenadas.",
      "Couper les faces le long d'un axe UCS Z donné. \r\n" +  // FR
        "Toutes les surfaces planes parallèles à cet axe de coordonnées seront usinées.\r\n" +
        "Ainsi que les surfaces cylindriques dans lesquelles l'axe du cylindre est parallèle à l'axe de coordonnées.",
      "Verilen bir UCS Z ekseni boyunca yüzleri kesin. \r\n" +  // TR
        "Bu koordinat eksenine paralel tüm düz yüzeyler işlenecektir.\r\n" +
        "Ayrıca silindirin ekseni koordinat eksenine paralel olan silindirik yüzeyler."};

    public static readonly string[] CutToEdge ={
        "For a given edge",
        "По заданному ребру",
        "Lungo un dato bordo",
        "Entlang einer bestimmten Kante",
        "沿着给定的边缘",
        "Para un borde dado",                          // ES
        "Pour une arête donnée",                       // FR
        "Belirli bir kenar için"};                     // TR

    public static readonly string[] CutToEdgeTip ={
      "Set the direction of the faces along one of the linear edges.\r\n" +
        "The program will ask the user to select one of the edges on one solid.\r\n" +
        "On all other solids, the program will look for surfaces located in the same direction.",
      "Задать направление граней по одному из линейных ребер. \r\n" +
        "Программа запросит пользователя выбрать одного из ребер на одном солиде.\r\n" +
        "На всех остальных солидах программа будет искать поверхности располагающиеся в том же направлении.",
      "Impostare la direzione delle facce lungo uno dei bordi lineari.\r\n" +
        "Il programma chiederà all'utente di selezionare uno dei bordi su un solido.\r\n" +
        "Su tutti gli altri solidi, il programma cercherà le superfici che si trovano nella stessa direzione.",
      "Legen Sie die Richtung der Flächen entlang einer der linearen Kanten fest.\r\n" +
        "Das Programm fordert den Benutzer auf, eine der Kanten eines Volumenkörpers auszuwählen.\r\n" +
        "Auf allen anderen Körpern sucht das Programm nach Flächen, die in derselben Richtung liegen.",
      "沿其中一条线性边设置面的方向。\r\n" +
        "程序将要求用户在一个实体上选择一个边。\r\n" +
        "在所有其他实体上，程序将寻找位于同一方向的表面。",
      "Establecer la dirección de las caras a lo largo de uno de los bordes lineales.\r\n" +  // ES
        "El programa pedirá al usuario que seleccione uno de los bordes en un sólido.\r\n" +
        "En todos los demás sólidos, el programa buscará superficies ubicadas en la misma dirección.",
      "Définir la direction des faces le long d'une des arêtes linéaires.\r\n" +  // FR
        "Le programme demandera à l'utilisateur de sélectionner l'une des arêtes sur un solide.\r\n" +
        "Sur tous les autres solides, le programme recherchera des surfaces situées dans la même direction.",
      "Doğrusal kenarlardan biri boyunca yüzlerin yönünü ayarlayın.\r\n" +  // TR
        "Program kullanıcıdan bir katı üzerindeki kenarlardan birini seçmesini isteyecektir.\r\n" +
        "Diğer tüm katılarda program aynı yönde bulunan yüzeyleri arayacaktır."};

    public static readonly string[] Processing ={
      "Processing Slices",
      "Обработка долек",
      "Lavorazione a fette",
      "Slice-Verarbeitung",
      "切片处理",
      "Procesamiento de cortes",                       // ES
      "Traitement des tranches",                       // FR
      "Dilim işleme"};                                 // TR

    public static readonly string[] ProcessingTip ={
      "What to do with slices after multi-slicing.",
      "Что надо сделать с дольками после мульти-отслоения.",
      "Cosa fare con le fette dopo averle tagliate più volte.",
      "Was ist mit Slices nach dem Multi-Slicing zu tun?",
      "多重切片后如何处理切片。。",
      "Qué hacer con los cortes después del corte múltiple.",  // ES
      "Que faire avec les tranches après la découpe multiple.",  // FR
      "Çoklu dilimleme sonrasında dilimlerle ne yapılacağı."};  // TR

    public static readonly string[] Unite ={
        "Unite",
        "Склеить",
        "Colla",
        "Kleber",
        "胶水",
        "Unir",                                        // ES
        "Unir",                                        // FR
        "Birleştir"};                                  // TR

    public static readonly string[] UniteTip ={
        "  Cut slices will be glued together",
        "  Отрезанные дольки будут склеены вместе",
        "  Le fette tagliate verranno incollate insieme",
        "  Geschnittene Scheiben werden zusammengeklebt." ,
        "  切好的片会粘在一起",
        "  Los cortes se pegarán juntos",              // ES
        "  Les tranches coupées seront collées ensemble",  // FR
        "  Kesilen dilimler birlikte yapıştırılacak"};  // TR

    public static readonly string[] MiterJoint ={
      "Miter Joint",
      "Стык под ус = 45°",
      "Mitre Joint",
      "Gehrungsfuge",
      "斜接",
      "Unión en inglete",                              // ES
      "Joint à onglet",                                // FR
      "Gönye birleştirme"};                            // TR

    public static readonly string[] MiterTip ={
      "Make miter joint: connections between the slices along the bisector of the joint angle.",
      "Сделать между дольками соединения по биссектрисе угла стыка.",
      "Mitre Joint: collegamenti tra le fette lungo la bisettrice dell'angolo del giunto.",
      "Gehrung herstellen: Verbindungen zwischen den Scheiben entlang der Winkelhalbierenden des Gelenks.",
      "制作斜接：沿关节角平分线的切片之间的连接。",
      "Hacer unión en inglete: conexiones entre los cortes a lo largo de la bisectriz del ángulo de unión.",  // ES
      "Faire un joint à onglet : connexions entre les tranches le long de la bissectrice de l'angle de joint.",  // FR
      "Gönye birleştirme yap: birleştirme açısının açıortayı boyunca dilimler arasında bağlantılar."};  // TR

    public static readonly string[] LargeToSmall ={
      "Large to Small",
      "От больших",
      "Da grande a piccolo",
      "Groß nach Klein",
      "大到小",
      "De grande a pequeño",                           // ES
      "Du grand au petit",                             // FR
      "Büyükten küçüğe"};                              // TR

    public static readonly string[] LargeToSmallTip ={
      "Cut slices sequentially, starting with the largest solid surface.\r\n" +
        "Joints will remain without additional processing.",
      "Отрезать дольки последовательно, начиная с самой большой поверхности солида.\r\n" +
        "Стыки останутся без дополнительной обработки.",
      "Tagliare le fette in sequenza a partire dalla superficie più grande del solido.\r\n" +
        "I giunti rimarranno senza ulteriore elaborazione.",
      "Scheiben nacheinander schneiden ausgehend von der größten Oberfläche des Festkörpers.\r\n" +
        "Fugen bleiben ohne zusätzliche Bearbeitung erhalten.",
      "按顺序切片从实体的最大表面开始。\r\n" +
        "关节将保留而无需额外处理。",
      "Cortar cortes secuencialmente, comenzando con la superficie sólida más grande.\r\n" +  // ES
        "Las uniones permanecerán sin procesamiento adicional.",
      "Couper les tranches séquentiellement, en commençant par la plus grande surface solide.\r\n" +  // FR
        "Les joints resteront sans traitement supplémentaire.",
      "Dilimleri sırayla kesin, en büyük katı yüzeyden başlayarak.\r\n" +  // TR
        "Eklemler ek işlem olmadan kalacaktır."};

    public static readonly string[] SmallToLarge ={
      "Small to Large",
      "От малых ",
      "Da piccolo a grande",
      "Klein bis Groß",
      "小到大",
      "De pequeño a grande",                           // ES
      "Du petit au grand",                             // FR
      "Küçükten büyüğe"};                              // TR

    public static readonly string[] SmallToLargeTip ={
      "Cut slices sequentially, \r\n" +
        "starting with the smallest solid surface.\r\n" +
        "Joints will remain without additional processing.",
      "Отрезать дольки последовательно, начиная с самой маленькой поверхности солида.\r\n" +
        "Стыки останутся без дополнительной обработки.",
      "Tagliare le fette in sequenza, a partire dalla superficie solida più piccola.\r\n" +
        "I giunti rimarranno senza ulteriore elaborazione.",
      "Scheiben nacheinander schneiden, beginnend mit der kleinsten festen Oberfläche.\r\n" +
        "Fugen bleiben ohne zusätzliche Bearbeitung erhalten.",
      "依次切片，从最小的固体表面开始。\r\n" +
        "关节将保留而无需额外处理。",
      "Cortar cortes secuencialmente, \r\n" +  // ES
        "comenzando con la superficie sólida más pequeña.\r\n" +
        "Las uniones permanecerán sin procesamiento adicional.",
      "Couper les tranches séquentiellement, \r\n" +  // FR
        "en commençant par la plus petite surface solide.\r\n" +
        "Les joints resteront sans traitement supplémentaire.",
      "Dilimleri sırayla kesin, \r\n" +  // TR
        "en küçük katı yüzeyden başlayarak.\r\n" +
        "Eklemler ek işlem olmadan kalacaktır."};

    public static readonly string[] Properties ={
      "Slice properties",
      "Свойства дольки",
      "Proprietà della fetta",
      "Slice-Eigenschaften",
      "切片属性",
      "Propiedades del corte",                         // ES
      "Propriétés de la tranche",                      // FR
      "Dilim özellikleri"};                            // TR

    public static readonly string[] LayerTip ={
      "The program can assign this layer to the cut slices. \r\n" +
        "When assigning a layer, all the properties of the slices will be reset to ByLayer, the coloring of the faces will be cleared. \r\n" +
        "Leave this field empty to make the slices a layer of the original solid.",
      "Программа может назначить этот слой отрезанным долькам. \r\n" +
        "При назначении слоя все свойства долек будут сброшены на ПоСлою, раскраска граней очищена. \r\n" +
        "Оставьте поле пустым, чтоб дольки получили слой исходного солида.",
      "Il programma può assegnare questo livello alle fette tagliate.\r\n" +
        "Quando si assegna un layer, tutte le proprietà delle sezioni verranno reimpostate su ByLayer e la colorazione delle facce verrà cancellata. \r\n" +
        "Lascia vuoto questo campo per rendere le fette uno strato del solido originale.",
      "Diese Schicht kann das Programm den geschnittenen Scheiben zuweisen.\r\n" +
        "Beim Zuweisen einer Ebene werden alle Eigenschaften der Slices auf 'Nach Ebene' zurückgesetzt und die Farbgebung der Flächen gelöscht. \r\n" +
        "Lassen Sie dieses Feld leer, um die Scheiben zu einer Schicht des ursprünglichen Volumenkörpers zu machen.",
      "程序可以将此层分配给切割切片。\r\n" +
        "当指定图层时，切片的所有属性将被重置为ByLayer，面的颜色将被清除。 \r\n" +
        "将此字段留空以使切片成为原始实体的一层。",
      "El programa puede asignar esta capa a los cortes cortados. \r\n" +  // ES
        "Al asignar una capa, todas las propiedades de los cortes se restablecerán a PorCapa, se borrará la coloración de las caras. \r\n" +
        "Deje este campo vacío para que los cortes sean una capa del sólido original.",
      "Le programme peut attribuer ce calque aux tranches coupées. \r\n" +  // FR
        "Lors de l'attribution d'un calque, toutes les propriétés des tranches seront réinitialisées sur ParCalque, la coloration des faces sera effacée. \r\n" +
        "Laissez ce champ vide pour que les tranches soient un calque du solide d'origine.",
      "Program bu katmanı kesilen dilimlere atayabilir. \r\n" +  // TR
        "Bir katman atandığında, dilimlerin tüm özellikleri KatmanaGöre'ye sıfırlanacak, yüzlerin renklendirmesi temizlenecektir. \r\n" +
        "Dilimlerin orijinal katının bir katmanı olması için bu alanı boş bırakın."};

    public static readonly string[] MaterialTip ={
      "The program can assign this material to the cut slices. \r\n" +
        "Leave this field empty to make the slices a material of the original solid.",
      "Программа может назначить этот материал отрезанным долькам. \r\n" +
        "Оставьте поле пустым, чтоб дольки получили материал исходного солида.",
      "Il programma può assegnare questo materiale per tagliare le fette.\r\n" +
        "Lascia il campo vuoto in modo che le fette ricevano il materiale del solido originale.",
      "Das Programm kann dieses Material geschnittenen Scheiben zuweisen.\r\n" +
        "Lassen Sie das Feld leer, damit die Scheiben das Material des ursprünglichen Volumenkörpers erhalten.",
      "程序可以将此材料分配给切片。\r\n" +
        "将该字段留空，以便切片接收原始实体的材料。",
      "El programa puede asignar este material a los cortes cortados. \r\n" +  // ES
        "Deje este campo vacío para que los cortes reciban el material del sólido original.",
      "Le programme peut attribuer ce matériau aux tranches coupées. \r\n" +  // FR
        "Laissez ce champ vide pour que les tranches reçoivent le matériau du solide d'origine.",
      "Program bu malzemeyi kesilen dilimlere atayabilir. \r\n" +  // TR
        "Dilimlerin orijinal katının malzemesini alması için bu alanı boş bırakın."};

    public static readonly string[] ColorFromFace = {
      "Use face color",
      "Использовать цвет поверхности",
      "Usa il colore della superficie",
      "Verwenden Sie Oberflächenfarbe",
      "使用表面颜色",
      "Usar color de cara",                            // ES
      "Utiliser la couleur de face",                   // FR
      "Yüz rengini kullan"};                           // TR

    public static readonly string[] ColorFromFaceTip = {
      "If the peeled surface has a color different from the color of the solid, \r\n" +
        "then assign this color to the peeled slice. "+
        "If several adjacent surfaces peel off at once, \r\n" +
        "then they should have the same color.",
      "Если у отслаиваемой поверхности назначен цвет, отличный от цвета солида, \r\n" +
        "то присвоить этот цвет отслоенной дольке. \r\n" +
        "Если отслаивается сразу несколько смежных поверхностей, \r\n" +
        "то у них должен быть один и тот же цвет.",
      "Se la superficie sbucciata ha un colore diverso dal colore del solido, \r\n" +
        "assegna questo colore alla fetta sbucciata. "+
        "Se più superfici adiacenti si staccano contemporaneamente, \r\n" +
        "dovrebbero avere lo stesso colore.",
      "Wenn die geschälte Oberfläche eine andere Farbe als der Körper hat, \r\n" +
        "weisen Sie diese Farbe der geschälten Scheibe zu. "+
        "Wenn sich mehrere benachbarte Flächen auf einmal ablösen, \r\n" +
        "dann sollten sie die gleiche Farbe haben.",
      "如果剥离表面的颜色与实体颜色不同，则将此颜色分配给剥离切片。\r\n" +
         "如果几个相邻的表面同时剥落，那么它们应该具有相同的颜色。",
      "Si la superficie pelada tiene un color diferente al color del sólido, \r\n" +  // ES
        "entonces asigne este color al corte pelado. "+
        "Si varias superficies adyacentes se pelan a la vez, \r\n" +
        "entonces deben tener el mismo color.",
      "Si la surface pelée a une couleur différente de la couleur du solide, \r\n" +  // FR
        "alors attribuez cette couleur à la tranche pelée. "+
        "Si plusieurs surfaces adjacentes se détachent en même temps, \r\n" +
        "alors elles doivent avoir la même couleur.",
      "Soyulan yüzeyin katının renginden farklı bir rengi varsa, \r\n" +  // TR
        "o zaman bu rengi soyulan dilime atayın. "+
        "Birkaç bitişik yüzey aynı anda soyulursa, \r\n" +
        "o zaman aynı renge sahip olmalıdırlar."};

    public static readonly string[] MaterialFromFace = {
      "Use face material",
      "Использовать материал поверхности",
      "Usa materiale di superficie",
      "Oberflächenmaterial verwenden",
      "使用面材",
      "Usar material de cara",                         // ES
      "Utiliser le matériau de face",                  // FR
      "Yüz malzemesini kullan"};                       // TR

    public static readonly string[] MaterialFromFaceTip = {
      "If a material different from the material of the solid is assigned to the peeled surface, \r\n" +
        "then assign this material to the peeled slice. \r\n" +
         "If several adjacent surfaces peel off at once, then they must have the same material.",
      "Если у отслаиваемой поверхности назначен материал, отличный от материала солида, \r\n" +
        "то присвоить этот материал отслоенной дольке. \r\n" +
        "Если отслаивается сразу несколько смежных поверхностей, \r\n" +
        "то у них должен быть один и тот же материал.",
      "Se alla superficie pelata viene assegnato un materiale diverso dal materiale del solido, \r\n" +
        "assegnare questo materiale alla fetta pelata.\r\n" +
         "Se più superfici adiacenti si staccano contemporaneamente, \r\n" +
        "devono avere lo stesso materiale.",
      "Wenn der geschälten Fläche ein anderes Material als das Material des Volumenkörpers zugeordnet ist, \r\n" +
        "dann ordnen Sie dieses Material der geschälten Scheibe zu. \r\n" +
         "Wenn sich mehrere benachbarte Flächen auf einmal ablösen, \r\n" +
        "dann müssen sie aus dem gleichen Material sein.",
      "如果将与实体材料不同的材料分配给剥离表面，则将此材料分配给剥离切片。\r\n" +
         "如果几个相邻的表面同时剥落，那么它们一定是同一种材料。",
      "Si se asigna un material diferente del material del sólido a la superficie pelada, \r\n" +  // ES
        "entonces asigne este material al corte pelado. \r\n" +
         "Si varias superficies adyacentes se pelan a la vez, entonces deben tener el mismo material.",
      "Si un matériau différent du matériau du solide est attribué à la surface pelée, \r\n" +  // FR
        "alors attribuez ce matériau à la tranche pelée. \r\n" +
         "Si plusieurs surfaces adjacentes se détachent en même temps, elles doivent avoir le même matériau.",
      "Soyulan yüzeye katının malzemesinden farklı bir malzeme atanırsa, \r\n" +  // TR
        "o zaman bu malzemeyi soyulan dilime atayın. \r\n" +
         "Birkaç bitişik yüzey aynı anda soyulursa, o zaman aynı malzemeye sahip olmalıdırlar."};

  }
}
