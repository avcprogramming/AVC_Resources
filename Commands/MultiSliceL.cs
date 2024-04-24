// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  MultiSliceL
  {
    public static readonly string[,] SliceStyleNames = {
        { "Slice", "Отслоение", "Stratifica", "Schälen", "去角质" },
        { "Slice", "Отслоение", "Stratifica", "Schälen", "去角质" },
        { "Shell with Miter Joint", "Оболочка под ус", "Guscio con snodo obliquo", "Schale mit Gehrungsverbindung", "带斜接的外壳" }
      };

    // ================================ Slice Style =====================================
    public static readonly string[] PlaneMethodKW = {
      "PlaneMethod", "ПЛоскостью", "LAereo", "Flugzeugmethode", "平面法(P)" };
    public static readonly string[] SurfaceMethodKW = {
      "SUrfaceMethod", "ПОВерхностью", "SUperficie", "OBerflächenmethode", "表面法(SU)" };
    public static readonly string[] OffsetFaceMethodKW = {
      "OffsetFaceMethod", "СДвигом", "Offset", "OFfsetGesichtsmethode", "偏移面法(O)" };
    public static readonly string[] AllMethodsKW = {
      "3Methods", "3Метода", "3Metodi", "3Methoden", "3种方法" };
    public static readonly string[] KeepSurfaceOnErrorKW = {
      "KeepSurfaceOnError", "СОхранятьПоверхность", "MantenereSuperficie", "SPeichernOberfläche", "保持表面的错误(K)" };
    public static readonly string[] ContiguousKW = {
      "COntiguous", "СМежные", "СOntigue", "BenachbarteOberflächen", "相邻表面(CO)" };
    public static readonly string[] CyclicallyKW = {
      "CYclically", "ЗАциклить", "CIiclicamente", "Zyklisch", "环形(CY)" };
    public static readonly string[] AllKW = {
      "ALL", "ВСЕ", "TUtto", "ALLes", "全部(ALL)" };
    public static readonly string[] AlongKW = {
      "ALOng", "ВДоль", "LUngo", "Entlang", "沿着(ALO)" };
    public static readonly string[] AcrossKW = {
      "ACross", "ПОПерек", "TRasver", "ACross", "穿过(ACR)" };
    public static readonly string[] CutToEdgeKW = {
      "TOEdge", "Указать", "SPecificare", "ANzeigen", "指定导向边(TOE)" };

    public static readonly string[] ThicknessQuery = {
      "  Enter thickness",
      "  Задайте толщину",
      "  Inserisci spessore",
      "  Dicke eingeben",
      "  输入厚度" };
    public static readonly string[] KeepSurfaceQuery ={
      "  Should the secant surface be preserved when a solid could not be cut?",
      "  Сохранять секущую поверхность, когда не удалось разрезать ей солид?",
      "  La superficie secante deve essere preservata quando non è possibile tagliare un corpo solido?",
      "  Um die Sekantenoberfläche zu erhalten, wenn es nicht möglich war, fest zu schneiden?",
      "  当无法切割实体时，是否应该保留割线？"};
    public static readonly string[] ContiguousQuery ={
      "  Handle contiguous surfaces",
      "  Отслаивать смежные поверхности",
      "  Gestire le superfici contigue",
      "  Benachbarte Flächen abziehen",
      "  处理连续表面"};
    public static readonly string[] CyclicallyQuery ={
      "  Query surfaces cyclically until you press ESC",
      "  Запрашивать поверхности циклически до нажатия ESC",
      "  Le query vengono visualizzate ciclicamente fino a quando non si preme ESC",
      "  Fragen Sie Oberflächen zyklisch ab, bis Sie ESC drücken",
      "  循环查询表面，直到您按 ESC"};
    public static readonly string[] MethodPlane = {
      "  Only the cutting plane method will be used",
      "  Будет использован только метод отсечения плоскостью",
      "  Verrà utilizzato solo il metodo di ritaglio piano",
      "  Es wird nur die Beschneidungsmethode verwendet.",
      "  仅使用切割平面法"};
    public static readonly string[] MethodSurface = {
        "  Only the cutting curved surface method will be used",
        "  Будет использован только метод отсечения криволинейной поверхностью",
        "  Verrà utilizzato solo il metodo della superficie curva di taglio",
        "  Es wird nur die Beschneidungsmethode verwendet.",
        "  仅使用切割曲面法"};
    public static readonly string[] MethodOffset = {
        "  Only the face offset method will be used",
        "  Будет использован только метод сдвига грани",
        "  Verrà utilizzato solo il metodo di offset facciale",
        "  Es wird nur die Gesichtsverschiebungsmethode verwendet.",
        "  只会使用面偏移方法"};
    public static readonly string[] MethodAll3 = {
        "  All 3 cutting methods will be used",
        "  Будут использованы все 3 метода отсечения",
        "  Verranno utilizzati tutti e 3 i metodi",
        "  Alle 3 Beschneidungsmethoden werden verwendet.",
        "  将使用所有 3 种切割方法"};
    public static readonly string[] CutNull ={
        "  Auto surface selection not set.",
        "  Не задан автовыбор поверхностей.",
        "  Selezione automatica della superficie non impostata.",
        "  Automatische Oberflächenauswahl nicht eingestellt." ,
        "  未设置自动表面选择."};
    public static readonly string[] CutShellTip ={
        "  Cutting all surfaces (shell).}",
        "  Отслаивание всех поверхностей (оболочка).}",
        "  Taglio di tutte le superfici (guaina).",
        "  Abblättern aller Oberflächen (Schale).}" ,
        "  切割所有表面（外壳)"};
    public static readonly string[] CutXHint ={
        "  Cutting surfaces along the X axis",
        "  Отслаивание поверхностей вдоль оси X",
        "  Taglio di superfici lungo l'asse X",
        "  Abblätternde Oberflächen entlang der X-Achse" ,
        "  沿 X 轴的切割面"};
    public static readonly string[] CutYHint ={
        "  Cutting surfaces along the Y axis",
        "  Отслаивание поверхностей вдоль оси Y",
        "  Taglio di superfici lungo l'asse Y",
        "  Abblätternde Oberflächen entlang der Y-Achse" ,
        "  沿 Y 轴切割表面"};
    public static readonly string[] CutZHint ={
        "  Cutting surfaces along the Z axis",
        "  Отслаивание поверхностей вдоль оси Z",
        "  Taglio di superfici lungo l'asse Z",
        "  Abblätternde Oberflächen entlang der Z-Achse" ,
        " 沿 Z 轴切割表面"};
    public static readonly string[] CutSelected ={
        "  Surfaces selected in advance. Auto select is disabled",
        "  Поверхности выбраны заранее. Автовыбор отключен",
        "  Superfici selezionate in anticipo. La selezione automatica è disabilitata",
        "  Oberflächen im Voraus ausgewählt. Die automatische Auswahl ist deaktiviert" ,
        "  预先选择的表面。 自动选择已禁用"};
    public static readonly string[] ContiguousOn ={
        " The search for contiguous surfaces is on.",
        " Включен поиск смежных.",
        " La ricerca di superfici contigue è inclusa.",
        " Die Suche nach angrenzenden Flächen ist enthalten." ,
        " 搜索连续曲面已打开。"};
    public static readonly string[] MiterHint ={
        "  Cut slices will be miter joined",
        "  Отрезанные дольки будут соединены ПОД УС",
        "  Le sezioni tagliate verranno unite ad angolo",
        "  Geschnittene Scheiben werden auf Gehrung verbunden." ,
        "  切片将斜接"};
    public static readonly string[] LargeToSmallHint ={
        "  Surfaces will be cut starting from large",
        "  Поверхности будут отрезаться начиная с больших",
        "  Le superfici verranno tagliate partendo da grandi",
        "  Oberflächen werden ab groß geschnitten." ,
        "  表面将从大开始切割"};
    public static readonly string[] SmallToLargeHint ={
        "  Surfaces will be cut starting from small",
        "  Поверхности будут отрезаться начиная с маленьких",
        "  Le superfici verranno tagliate partendo da piccole",
        "  Oberflächen werden ausgehend von kleinen geschnitten." ,
        "  表面将从小开始切割"};

    // ======================= MultiSlice ==========================================
    public static readonly string[] Cutting = { "  Cutting", "  Отслоение", "  Stratifica", "  Schneiden", "  分层" };
    public static readonly string[] SelectEdge ={
      "  Select a straight edge to set the direction of the slicing surfaces.",
      "  Выберите прямое ребро, что бы задать направление отслаиваемых поверхностей",
      "  Selezionare un bordo dritto per impostare la direzione delle superfici.",
      "  Wählen Sie eine gerade Kante, um die Richtung der Flächen festzulegen.",
      "  选择一条直边以设置切片曲面的方向。"};
    public static readonly string[] StraightRequired = {
      "  Straight edge required",
      "  Требуется прямое ребро",
      "  Bordo diritto richiesto",
      "  Gerade Kante erforderlich",
      "  需要直边" };
    public static readonly string[] SelectedCount ={
      "  Selected solids: {0}, Surface groups: {1}",
      "  Выбрано солидов: {0}, Групп поверхностей: {1}",
      "  Solidi selezionati: {0}, Gruppi di superficie: {1}",
      "  Ausgewählte Volumenkörper: {0}, Oberflächengruppen: {1}",
      "  选定的实体：{0}，曲面组：{1}"};

    // =========================================== SliceFace ==============================================
    public static readonly string[] NoWork ={
      "No method of slice did not work.",
      "Ни один метод отслоения не сработал. Надо перечерчивать солид заново.",
      "Nessun metodo della fetta non ha funzionato.",
      "Keine einzige Schälmethode hat funktioniert. Der Volumenkörper muss erneut gezeichnet werden.",
      "没有一种剥皮方法有效。 有必要再次重绘实体。" };
    public static readonly string[] SubErr ={
      "Slice subtraction error. Cutting is canceled.",
      "Ошибка построения обрезка. Разрезание отменено.",
      "Errore di sottrazione della fetta. Il taglio è annullato.",
      "Fehler beim Erstellen des Zuschneidens. Das Schneiden wird abgebrochen.",
      "切片减法错误。 取消切割。" };
    public static readonly string[] SubBlankErr ={
      "Failed to subtract a slice from the blank",
      "Не удалось вычесть из заготовки дольку",
      "Impossibile sottrarre una sezione dallo spazio",
      "Fehler beim Subtrahieren eines Slice vom Ernte.",
      "未能从空白中减去切片" };
    public static readonly string[] IntersectErr ={
      "Failed to fix intersections of parts",
      "Не удалось устранить пересечения деталей",
      "Impossibile correggere le intersezioni delle parti",
      "Fehler beim Korrigieren des Schnittpunkts von Teilen",
      "无法修复零件的交点"};
    public static readonly string[] SurfNum = {
      "Process surface number {0}",
      "Обрабатываем поверхность номер {0}",
      "Elaboriamo il numero di superficie {0}",
      "Processing surface number {0}",
      "处理表面编号 {0}"};
    public static readonly string[] NoIntersect ={
      "The cutting plane did not intersect the solid. The thickness may be too large.",
      "Секущая плоскость не пересеклась с телом. Возможно задана слишком большая толщина.",
      "Il piano di taglio non intersecava il solido. Lo spessore potrebbe essere troppo grande.",
      "Die Schnittebene schnitt nicht mit dem Volumenkörper. Möglicherweise ist zu viel Dicke angegeben.",
      "切割平面不与实体相交。 厚度可能太大" };
    public static readonly string[] CopyErr = {
      "Can't copy solid.",
      "Не удалось скопировать солид.",
      "Non è possibile copiare il solido.",
      "Solid konnte nicht Volumenkörper werden.",
      "无法复制实体。" };
    public static readonly string[] OffsetErr ={
      "Face offset method does not work. {0}",
      "Не сработал метод офсета поверхности. {0}",
      "Il metodo di offset facciale non funziona. {0}",
      "Die Oberflächenversatzmethode hat nicht funktioniert. {0}",
      "面部偏移方法不起作用。 {0}"};
    public static readonly string[] NotFlat = {
      "The face is not flat.",
      "Грань не плоская.",
      "La faccia non è piatta.",
      "Das Gesicht ist nicht flach.",
      "脸不平。"};
    public static readonly string[] CuttingErr ={
      "Cutting plane method does not work.",
      "Не сработал метод отрезания плоскостью.",
      "Metodo Poligono slice (piano di taglio) non funziona.",
      "Die ebene Schneidemethode hat nicht funktioniert.",
      "切割平面方法不起作用。"};
    public static readonly string[] CuttingDone = {
      "Cutting plane method worked.",
      "Сработал slice плоскость.",
      "Metodo poligono slice (piano di taglio) riuscito.",
      "Schnittebenenmethode funktioniert.",
      "切割平面方法有效。"};
    public static readonly string[] SurfaceCreateErr = {
      "Can't create surface.",
      "Не получилось создать поверхность.",
      "Non è possibile creare superfici.",
      "Oberfläche konnte nicht erstellt werden.",
      "无法创建曲面。" };
    public static readonly string[] OffsetSurfErr ={
      "Can't create offset surface.",
      "Не получилось создать поверхность с отступом от выбранной.",
      "Non è possibile creare superfici con offset.",
      "Es war nicht möglich, eine von der ausgewählten eingerückte Oberfläche zu erstellen.",
      "无法创建偏移曲面。"};
    public static readonly string[] SurfaceErr ={
      "Cutting curved surface method does not work.",
      "Не сработал метод отрезания криволинейной поверхностью.",
      "Metodo di taglio superficie curva non funziona.",
      "Die Methode des Schneidens mit einer gekrümmten Oberfläche funktionierte nicht.",
      "切割曲面的方法不起作用。"};
    public static readonly string[] SurfaceSaved ={
      "\nCutting surface is saved.",
      "\nСохраняем поверхность реза.",
      "\nSalvare la superficie di taglio.",
      "\nWir speichern eine Schnittfläche.",
      "\n切割面被保存。" };
    public static readonly string[] SurfaceDone ={
      "Curved surface method worked.",
      "Сработал метод отрезания криволинейной поверхностью.",
      "Metodo di superficie curva lavorato.",
      "Die Methode des Schneidens mit einer gekrümmten Oberfläche funktionierte.",
      "曲面法奏效了。"};
    public static readonly string[] OffsetDone ={
      "Face offset method worked.",
      "Сработал метод сдвига грани.",
      "Metodo di offset facciata lavorato.",
      "Die Face-Shift-Methode hat funktioniert.",
      "面部偏移方法有效。"};
    public static readonly string[] ShapeErr ={
      "The cutting plane did not divide the object into 2 parts. The shape of the solid does not allow using this method.",
      "Секущая плоскость не разделила объект на 2 части. Форма тела не позволяет использовать данный метод.",
      "Il piano di taglio non ha diviso l'oggetto in 2 parti. La forma del corpo non consente l'utilizzo di questo metodo.",
      "Die Schnittebene teilte das Objekt nicht in zwei Teile. Die Körperform erlaubt die Verwendung dieser Methode nicht.",
      "切割平面没有将对象分成两部分。 实体的形状不允许使用此方法。" };
    public static readonly string[] SliceCount = {
      "  Made {0} slicing.",
      "  Сделано {0} отслоений.",
      "  Gestito per effettuare {0} tagli.",
      "  {0} Schneiden gemacht",
      "  进行了 {0} 次切片。"};
    public static readonly string[] MiterCount = {
      "  Made {0} miter joints. Failed - {1}",
      "  Сделано {0} стыков под ус. Не удалось - {1}",
      "  Realizzato {0} mitra comune. Non riuscito - {1}",
      "  Gefertigte {0} Gehrungsfugen. Fehlgeschlagen - {1}",
      "  制作了 {0} 个斜接接头。 失败 - {1}" };

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
        "在程序中没有使用。只是为了方便选择。"};
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
        "在任何情况下，每次调用命令时都会请求厚度。"};
    public static readonly string[] ContiguousFaces ={
      "Select Contiguous Faces",
      "Выбрать смежные",
      "Seleziona Facce contigue",
      "Wählen Sie Angrenzende",
      "选择连续的面"};
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
        "不要将此选项与斜接选项一起使用，因为斜接关节程序不知道如何在弯曲边缘上制作关节。"};
    public static readonly string[] Cyclically ={
      "Run Cyclically",
      "Запускать циклически",
      "Esegui ciclicamente",
      "Zyklisch ausführen",
      "循环运行"};
    public static readonly string[] CyclicallyTip ={
      "Continue selecting solids and their surfaces for new cuts until you press ESC.",
      "Зациклить - продолжать выбор солидов и их поверхностей для новых отслоений до нажатия ESC.",
      "Ciclo: continua a selezionare i solidi e le loro superfici per nuove delaminazioni finché non viene premuto ESC.",
      "Schleife - Fahren Sie mit der Auswahl von Festkörpern und deren Oberflächen für neue Delaminierungen fort, bis ESC gedrückt wird.",
      "循环 - 继续选择固体及其表面以进行新的分层，直到按下 ESC。"};
    public static readonly string[] SaveStub ={
      "Save Stub",
      "Сохранять кочерыжку",
      "Salva Stub",
      "Stub speichern",
      "保存存根"};
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
        "普通 A>V>C> 切片 (ASL) 命令始终保留两个实体。"};
    public static readonly string[] SaveSurfaceOnError ={
      "Save Surface On Error",
      "Сохранять поверхность",
      "Conserva la superficie",
      "Oberfläche bewahren",
      "保留表面"};
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
        "您可以修改此曲面并将其用于 _Slice 命令。"};



    public static readonly string[] Method ={
      "Method",
      "Метод отслоения",
      "Metodo",
      "Peel-Methode",
      "剥离法"};
    public static readonly string[] AllMethods ={
      "All 3",
      "Все 3",
      "Tutti 3",
      "Alle 3",
      "全部 3"};
    public static readonly string[] AllMethodsTip ={
      "Try to use all three methods in the following sequence: offset, plane, surface. (default)",
      "Перебирать все три метода автоматически в следующем порядке: Сдвигом, Плоскостью, Поверхностью.",
      "Prova a utilizzare tutti e tre i metodi nella seguente sequenza: offset, piano, superficie. (predefinito)",
      "Versuchen Sie, alle drei Methoden in der folgenden Reihenfolge anzuwenden: Versatz, Ebene, Fläche. (Ursprünglich)",
      "尝试按以下顺序使用所有三种方法：偏移、平面、曲面。 （默认）"};
    public static readonly string[] OffsetMethod ={
      "Offset",
      "Сдвигом",
      "Offset",
      "Versatz",
      "抵消"};
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
        "在大多数情况下，此方法可提供最佳结果。但是，有一些限制。"};
    public static readonly string[] PlaneMethod ={
      "Plane",
      "Плоскостью",
      "Aereo",
      "Flugzeug",
      "飞机"};
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
        "当固体被强烈弯曲时，这可能是不方便的。"};
    public static readonly string[] SurfaceMethod ={
      "Surface",
      "Поверхностью",
      "Superficie",
      "Auftauchen",
      "表面"};
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
        "为避免致命错误，程序会检查实体的有效性，并在无效时警告用户。"};

    public static readonly string[] Select ={
      "Face AutoSelection",
      "Автовыбор поверхностей",
      "Selezione della superficie automatica",
      "Auswahl der automatischen Oberfläche",
      "自动曲面选择"};
    public static readonly string[] SelectTip ={
      "Automatically select solid surfaces for slicing.",
      "Автоматически выбирать поверхности солидов для отслоения.",
      "Seleziona automaticamente le superfici solide da affettare.",
      "Wählen Sie automatisch feste Oberflächen zum Schneiden aus.",
      "自动选择实体曲面进行切片。"};
    public static readonly string[] CutShell ={
      "All = Shell",
      "Все = Оболочка",
      "Tutte le facce",
      "Alle Flächen",
      "所有面 = 壳"};
    public static readonly string[] CutAcross ={
      "Across",
      "Поперек",
      "Attraverso",
      "Über",
      "穿过"};
    public static readonly string[] CutAlongTip ={
        "  Cutting surfaces along the longest straight edge of a part",
        "  Отслаивание поверхностей вдоль самого длинного прямого ребра детали",
        "  Taglio di superfici lungo il bordo diritto più lungo di una parte",
        "  Abblätternde Oberflächen entlang der längsten geraden Kante des Teils" ,
        "  沿零件最长直边切割表面"};
    public static readonly string[] CutAlong ={
      "Along",
      "Вдоль",
      "Lungo",
      "Eine lange",
      "沿着"};
    public static readonly string[] CutAcrossTip ={
        "  Cutting surfaces across the longest straight edge of the part",
        "  Отслаивание поверхностей поперек самого длинного прямого ребра детали",
        "  Taglio di superfici attraverso il bordo rettilineo più lungo della parte",
        "  Abblätternde Oberflächen über die längste gerade Kante des Teils" ,
        "  跨越零件最长直边的切割面"};
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
        "以及圆柱的轴线与坐标轴平行的圆柱表面。"};
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
        "以及圆柱的轴线与坐标轴平行的圆柱表面。"};
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
        "以及圆柱的轴线与坐标轴平行的圆柱表面。"};
    public static readonly string[] CutToEdge ={
        "For a given edge",
        "По заданному ребру",
        "Lungo un dato bordo",
        "Entlang einer bestimmten Kante",
        "沿着给定的边缘"};
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
        "在所有其他实体上，程序将寻找位于同一方向的表面。"};

    public static readonly string[] Processing ={
      "Processing Slices",
      "Обработка долек",
      "Lavorazione a fette",
      "Slice-Verarbeitung",
      "切片处理"};
    public static readonly string[] ProcessingTip ={
      "What to do with slices after cutting.",
      "Что надо сделать с дольками после отслоения.",
      "Cosa si deve fare con le fette dopo averle sbucciate.",
      "Was ist mit den Scheiben nach dem Schälen zu tun?",
      "剥皮后的切片应该怎么做。"};
    public static readonly string[] Unite ={
        "Unite",
        "Склеить",
        "Colla",
        "Kleber",
        "胶水"};
    public static readonly string[] UniteTip ={
        "  Cut slices will be glued together",
        "  Отрезанные дольки будут склеены вместе",
        "  Le fette tagliate verranno incollate insieme",
        "  Geschnittene Scheiben werden zusammengeklebt." ,
        "  切好的片会粘在一起"};
    public static readonly string[] MiterJoint ={
      "Miter Joint",
      "Стык под ус = 45°",
      "Mitre Joint",
      "Gehrungsfuge",
      "斜接"};
    public static readonly string[] MiterTip ={
      "Make miter joint: connections between the slices along the bisector of the joint angle.",
      "Сделать между дольками соединения по биссектрисе угла стыка.",
      "Mitre Joint: collegamenti tra le fette lungo la bisettrice dell'angolo del giunto.",
      "Gehrung herstellen: Verbindungen zwischen den Scheiben entlang der Winkelhalbierenden des Gelenks.",
      "制作斜接：沿关节角平分线的切片之间的连接。"};
    public static readonly string[] LargeToSmall ={
      "Large to Small",
      "От больших",
      "Da grande a piccolo",
      "Groß nach Klein",
      "大到小"};
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
        "关节将保留而无需额外处理。"};
    public static readonly string[] SmallToLarge ={
      "Small to Large",
      "От малых ",
      "Da piccolo a grande",
      "Klein bis Groß",
      "小到大"};
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
        "关节将保留而无需额外处理。"};

    public static readonly string[] Properties ={
      "Slice properties",
      "Свойства дольки",
      "Proprietà della fetta",
      "Slice-Eigenschaften",
      "切片属性"};
    public static readonly string[] LayerTip ={
      "The program can assign this layer to the cut slices. \r\n" +
        "Leave this field empty to make the slices a layer of the original solid.",
      "Программа может назначить этот слой отрезанным долькам. \r\n" +
        "Оставьте поле пустым, чтоб дольки получили слой исходного солида.",
      "Il programma può assegnare questo livello alle fette tagliate.\r\n" +
        "Lascia vuoto questo campo per rendere le fette uno strato del solido originale.",
      "Diese Schicht kann das Programm den geschnittenen Scheiben zuweisen.\r\n" +
        "Lassen Sie dieses Feld leer, um die Scheiben zu einer Schicht des ursprünglichen Volumenkörpers zu machen.",
      "程序可以将此层分配给切割切片。\r\n" +
        "将此字段留空以使切片成为原始实体的一层。"};
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
        "将该字段留空，以便切片接收原始实体的材料。"};
    public static readonly string[] ColorFromFace = {
      "Use face color",
      "Использовать цвет поверхности",
      "Usa il colore della superficie",
      "Verwenden Sie Oberflächenfarbe",
      "使用表面颜色",
    };
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
    };
    public static readonly string[] MaterialFromFace = {
      "Use face material",
      "Использовать материал поверхности",
      "Usa materiale di superficie",
      "Oberflächenmaterial verwenden",
      "使用面材",
    };
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
    };

  }
}
