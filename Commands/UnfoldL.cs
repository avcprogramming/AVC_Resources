namespace AVC
{
  public static class UnfoldL
  {
    public static readonly string[][] UnfoldStyleNames = {
/* 0 */ CommandL.Unfold,
/* 1 */ CommandL.Unfold, };

    public static readonly string[]  CurrentUnfoldStyle = {
      "  Unfold-style will be used: {0}",
      "  Будет использован стиль развертки: {0}",
      "  Unfold-stile sarà usato: {0}",
      "  Der Unfold-stil wird verwendet: {0}",
      "  将使用嵌套(Unfold)样式：{0}",
      "  Se utilizará el estilo Unfold: {0}",  // ES
      "  Le style Unfold sera utilisé : {0}",  // FR
      "  Unfold stili kullanılacak: {0}"};  // TR

    public static readonly string[] InsertPointQuery = {
      "Insertion point of the unfolded contour",
      "Точка вставки развертки",
      "Punto di inserimento del contorno sviluppato",
      "Einfügepunkt der Abwicklung",
      "展开轮廓的插入点",
      "Punto de inserción del contorno desarrollado",  // ES
      "Point d'insertion du contour développé",  // FR
      "Açılım konturunun ekleme noktası"};  // TR

    public static readonly string[] Result = {
      "  Curves created: {0}",
      "  Создано кривых: {0}",
      "  Curve create: {0}",
      "  Erstellte Kurven: {0}",
      "  已创建曲线：{0}",
      "  Curvas creadas: {0}",  // ES
      "  Courbes créées : {0}",  // FR
      "  Oluşturulan eğriler: {0}"};  // TR

    public static readonly string[] AreaDiff = {
      "  Face area {0}, unfolded area {1}, difference {2} ({3:0.#}%)",
      "  Площадь поверхности {0}, площадь развертки {1}, отличие {2} ({3:0.#}%)",
      "  Area della faccia {0}, area dello sviluppo {1}, differenza {2} ({3:0.#}%)",
      "  Flächeninhalt {0}, Abwicklungsfläche {1}, Abweichung {2} ({3:0.#}%)",
      "  面面积 {0}，展开面积 {1}，差值 {2}（{3:0.#}%）",
      "  Área de la cara {0}, área desarrollada {1}, diferencia {2} ({3:0.#}%)",  // ES
      "  Aire de la face {0}, aire du développement {1}, écart {2} ({3:0.#}%)",  // FR
      "  Yüzey alanı {0}, açılım alanı {1}, fark {2} ({3:0.#}%)"};  // TR

    public static readonly string[] FaceNotSupported = {
      "This surface cannot be unfolded. Only cylinders, cones, and extruded surfaces are permissible.",
      "Эту поверхность развернуть невозможно. Допустимы только цилиндры, конусы и поверхности вытягивания.",
      "Questa superficie non può essere sviluppata. Sono ammissibili solo cilindri, coni e superfici estruse.",
      "Diese Fläche kann nicht abgewickelt werden. Nur Zylinder, Kegel und extrudierte Flächen sind zulässig.",
      "此曲面无法展开。仅允许使用圆柱体、圆锥体和挤压曲面。",
      "Esta superficie no se puede desplegar. Solo se permiten cilindros, conos y superficies extruidas.",
      "Cette surface ne peut pas être développée. Seuls les cylindres, les cônes et les surfaces extrudées sont autorisés.",
      "Bu yüzey açılılamaz. Sadece silindirler, koniler ve ekstrüde yüzeyler izin verilir." };

    // ==================================================  Dialog  ==========================================================================================================
    #region Dialog

    public static readonly string[] StyleNameTip = {
      "The name for this unfold-style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля развертки. Не используется в работе программы. Только для удобства выбора.",
      "Il nome di questo stile di sviluppo (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Abwicklungs-Stil (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此展开式（设置集）的名称。程序中不使用，仅为便于选择而设。",
      "El nombre de este estilo de desarrollo (conjunto de configuraciones). No se usa en el programa. Solo por conveniencia de elección.",  // ES
      "Le nom de ce style de développement (ensemble de paramètres). Non utilisé dans le programme. Seulement pour la commodité du choix.",  // FR
      "Bu geliştirme stili için ad (ayarlar kümesi). Programda kullanılmaz. Sadece seçim kolaylığı için."};  // TR

    public static readonly string[] UnfoldOptions = { 
      "Unfold options", 
      "Параметры развертки", 
      "Opzioni di sviluppo", 
      "Abwicklungsoptionen", 
      "展开选项", 
      "Opciones de desplegado", 
      "Options de développement", 
      "Açılım seçenekleri" };

    public static readonly string[] UnfoldOptionsTip = { 
      "Options that control how unfolded surfaces are created.", 
      "Параметры, управляющие созданием развертки поверхностей.", 
      "Opzioni che controllano come vengono create le superfici sviluppate.", 
      "Optionen, die steuern, wie abgewickelte Flächen erstellt werden.", 
      "控制展开曲面创建方式的选项。", 
      "Opciones que controlan cómo se crean las superficies desplegadas.", 
      "Options qui contrôlent la création des surfaces développées.", 
      "Açılmış yüzeylerin nasıl oluşturulacağını kontrol eden seçenekler." };

    public static readonly string[] ContiguousFacesTip ={
      "Automatically add adjacent to the selected surfaces,\r\n" +
        "i.e. conjugate without kink (kink not more than 0.1 degrees between tangents).",
      "Автоматически добавлять к выбранным поверхностям смежные, т.е. сопряженные без излома \r\n" +
        "(излом не более 0.1 градуса между касательными).",
      "Aggiungi automaticamente alle superfici selezionate quelle adiacenti,\r\n" +
        "cioè congiunte senza spigolo (spigolo non superiore a 0,1 gradi tra le tangenti).",
      "Automatisch angrenzende Flächen zu den ausgewählten Flächen hinzufügen,\r\n" +
        "d. h. konjugiert ohne Knick (Knick nicht mehr als 0,1 Grad zwischen den Tangenten).",
      "自动将相邻的表面添加到所选表面，即在切线之间没有折痕（折痕不超过 0.1 度）。",
      "Agregar automáticamente a las superficies seleccionadas las adyacentes,\r\n" +
        "es decir, conjugadas sin quiebre (quiebre no más de 0,1 grados entre tangentes).",
      "Ajouter automatiquement aux surfaces sélectionnées les surfaces adjacentes,\r\n" +
        "c'est-à-dire conjuguées sans pli (pli pas plus de 0,1 degrés entre les tangentes).",
      "Seçilen yüzeylere bitişik olanları otomatik olarak ekleyin,\r\n" +
        "yani kırılma olmadan eşlenik (teğetler arasında 0,1 dereceden fazla kırılma yok)." };

    public static readonly string[] StripTriangulation = {
      "Approximate unfolding of ruled surfaces",
      "Примерные развертки линейчатых поверхностей",
      "Sviluppo approssimativo di superfici regolate",
      "Ungefähres Abwickeln von geregelten Flächen",
      "近似展开的规则曲面",
      "Desplegado aproximado de superficies regladas",
      "Développement approximatif de surfaces réglées",
      "Yaklaşık olarak düzenlenmiş yüzeylerin açılması" };

    public static readonly string[] StripTriangulationTip = {
      "Unfold ruled surfaces that cannot be unfolded exactly. \r\n" +
        "The LOFT command creates ruled surfaces by connecting two arbitrary curves with lines. \r\n" +
        "For example, a twisted ribbon — a helicoid. \r\n" +
        "An approximate unfolding will require stretching the material. \r\n" +
        "The program will issue a warning if the stretching is significant.",
      "Разворачивать линейчатые поверхности, которые невозможно развернуть точно. \r\n" +
        "Линейчатые поверхности образует команда LOFT соединяя линиями две произвольные кривые. \r\n" +
        "Например скрученная винтом лента - геликоид. \r\n" +
        "Приближенная развертка потребует растягивать материал. \r\n" +
        "Программа предупредит, если растягивание будет слишком заметным.",
      "Sviluppare superfici regolate che non possono essere sviluppate esattamente. \r\n" +
        "Le superfici regolate sono create dal comando LOFT collegando due curve arbitrarie con linee. \r\n" +
        "Ad esempio, un nastro attorcigliato: un elicoide. \r\n" +
        "Uno sviluppo approssimativo richiederà di allungare il materiale. \r\n" +
        "Il programma emetterà un avviso se l'allungamento è significativo.",
      "Entwickeln Sie geregelte Flächen, die nicht genau entwickelt werden können. \r\n" +
        "Die LOFT-Befehle erzeugen geregelte Flächen, indem sie zwei beliebige Kurven mit Linien verbinden. \r\n" +
        "Zum Beispiel ein verdrehtes Band - ein Helicoid. \r\n" +
        "Eine ungefähre Abwicklung erfordert das Dehnen des Materials. \r\n" +
        "Das Programm gibt eine Warnung aus, wenn die Dehnung erheblich ist.",
      "展开无法精确展开的规则曲面。 \r\n" +
        "LOFT 命令通过用线连接两条任意曲线来创建规则曲面。 \r\n" +
        "例如，扭曲的带子——螺旋面。 \r\n" +
        "近似展开将需要拉伸材料。 \r\n" +
        "如果拉伸很明显，程序将发出警告。",
      "Desplegar superficies regladas que no se pueden desplegar exactamente. \r\n" +
        "El comando LOFT crea superficies regladas conectando dos curvas arbitrarias con líneas. \r\n" +
        "Por ejemplo, una cinta retorcida: un helicoide. \r\n" +
        "Un desplegado aproximado requerirá estirar el material. \r\n" +
        "El programa emitirá una advertencia si el estiramiento es significativo.",
      "Développez des surfaces réglées qui ne peuvent pas être développées exactement. \r\n" +
        "La commande LOFT crée des surfaces réglées en reliant deux courbes arbitraires avec des lignes. \r\n" +
        "Par exemple, un ruban torsadé : un hélicoïde. \r\n" +
        "Un développement approximatif nécessitera d'étirer le matériau. \r\n" +
        "Le programme émettra un avertissement si l'étirement est important.",
      "Tam olarak açılmayan yönlendirilmiş yüzeyleri açın. \r\n" +
        "LOFT komutu, iki rastgele eğriyi çizgilerle bağlayarak yönlendirilmiş yüzeyler oluşturur. \r\n" +
        "Örneğin, bükülmüş bir şerit - bir helikoid. \r\n" +
        "Yaklaşık açma, malzemeyi germeyi gerektirir. \r\n" +
        "Germenin önemli olması durumunda program bir uyarı verecektir." };
    public static readonly string[] CyclicallyTip ={
      "Continue selecting solids and their surfaces for new unfolds until you press ESC.",
      "Зациклить - продолжать выбор солидов и их поверхностей для новых разверток до нажатия ESC.",
      "Continua a selezionare solidi e le loro superfici per nuovi sviluppi fino a quando non premi ESC.",
      "Fahren Sie fort, Solids und deren Flächen für neue Abwicklungen auszuwählen, bis Sie ESC drücken.",
      "继续选择实体及其表面以进行新的展开，直到按下 ESC。",
      "Continúa seleccionando sólidos y sus superficies para nuevos desplegados hasta que presiones ESC.",
      "Continuez à sélectionner des solides et leurs surfaces pour de nouveaux développements jusqu'à ce que vous appuyiez sur ESC.",
      "Yeni açılımlar için katı cisimleri ve yüzeylerini seçmeye devam edin, ESC tuşuna basana kadar." };

    public static readonly string[] ManageLayersTip = { 
      "Assign layers from the current CNC style to unfolded curves.", 
      "Назначать кривым развертки слои из текущего стиля ЧПУ.", 
      "Assegna alle curve sviluppate i livelli dello stile CNC corrente.", 
      "Weist den abgewickelten Kurven die Ebenen des aktuellen CNC-Stils zu.", 
      "将当前 CNC 样式中的图层分配给展开曲线。", 
      "Asigna a las curvas desplegadas las capas del estilo CNC actual.", 
      "Attribue aux courbes développées les calques du style CNC actuel.", 
      "Açılmış eğrilere mevcut CNC stilindeki katmanları atar." };

    public static readonly string[] JointLines = {
      "Joint lines",
      "Линии стыка",
      "Linee di giunzione",
      "Fugenlinien",
      "接缝线",
      "Líneas de unión",
      "Lignes de joint",
      "Birleşim çizgileri" };

    public static readonly string[] JointLinesTip = { 
      "Draw joint lines between contiguous faces.", 
      "Чертить линии сопряжения между смежными поверхностями.", 
      "Disegna le linee di giunzione tra facce contigue.", 
      "Zeichnet Fugenlinien zwischen benachbarten Flächen.", 
      "在相邻面之间绘制接缝线。", 
      "Dibuja líneas de unión entre caras contiguas.", 
      "Dessine les lignes de joint entre faces contiguës.", 
      "Bitişik yüzler arasında birleşim çizgileri çizer." };

    public static readonly string[] IgnoreUcsTip = {
      "Determine the top of the part in the World Coordinate System (WCS) \r\n" +
        "rather than the current User Coordinate System (UCS). \r\n" +
        "Lay out the flat pattern contours in the XY plane of the World Coordinate System.",
      "Определять верх детали в Мировой системе координат (WCS) \r\n" +
        "а не в текущей Пользовательской системе координат (UCS). \r\n" +
        "Размещать контуры плоской развертки в плоскости XY Мировой системы координат.",
      "Determinare la parte superiore del pezzo nel Sistema di Coordinate Mondiale (WCS) \r\n" +
        "piuttosto che nel Sistema di Coordinate Utente (UCS) corrente. \r\n" +
        "Disporre i contorni del modello piatto nel piano XY del Sistema di Coordinate Mondiale.",
      "Bestimmen Sie die Oberseite des Teils im Weltkoordinatensystem (WCS) \r\n" +
        "anstatt im aktuellen Benutzerkoordinatensystem (UCS). \r\n" +
        "Legen Sie die Konturen des Flachmusters in der XY-Ebene des Weltkoordinatensystems an.",
      "在世界坐标系 (WCS) 中确定零件的顶部，而不是在当前用户坐标系 (UCS) 中。 \r\n" +
        "在世界坐标系的 XY 平面中布置平面图案轮廓。",
      "Determine la parte superior de la pieza en el Sistema de Coordenadas Mundial (WCS) \r\n" +
        "en lugar del Sistema de Coordenadas de Usuario (UCS) actual. \r\n" +
        "Coloque los contornos del patrón plano en el plano XY del Sistema de Coordenadas Mundial.",
      "Déterminez le haut de la pièce dans le Système de Coordonnées Mondial (WCS) \r\n" +
        "plutôt que dans le Système de Coordonnées Utilisateur (UCS) actuel. \r\n" +
        "Disposez les contours du motif plat dans le plan XY du Système de Coordonnées Mondial.",
      "Parçanın üstünü Mevcut Kullanıcı Koordinat Sistemi (UCS) yerine Dünya Koordinat Sistemi'nde (WCS) belirleyin. \r\n" +
        "Düz desen konturlarını Dünya Koordinat Sistemi'nin XY düzleminde yerleştirin." };

    #endregion
  }
}
