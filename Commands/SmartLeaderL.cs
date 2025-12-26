// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Subobject

namespace AVC
{
  public static class
  SmartLeaderL
  {
    //==================================== Command Line ===========================================================
    public static readonly string[] SolidTemplateKW = {
      "SolidTemplate",
      "СолидШаблон",
      "SOlidoSchema",
      "SolidMuster",
      "三维实体模板(S)" ,
      "SOlidoPlantilla",                               // ES - SO
      "SOlideModèle",                                  // FR - SO
      "KATıŞablon" };                                  // TR - KAT

    public static readonly string[] BlockTemplateKW = {
      "BlockTemplate",
      "БлокШаблон",
      "BlocchiSchema",
      "BlockMuster",
      "块模板(B)" ,
      "BLOquePlantilla",                               // ES - BLO
      "BLOcModèle",                                    // FR - BLO
      "BLOkŞablon" };                                  // TR - BLO

    public static readonly string[] OtherTemplateKW = {
      "OTherTemplate",
      "ПРочееШаблон",
      "AltroSchema",
      "ANdereMuster",
      "其他对象的模板(O)" ,
      "OTRoPlantilla",                                 // ES - OTR
      "AUTreModèle",                                   // FR - AUT
      "DİĞerŞablon" };                                 // TR - DİĞ

    public static readonly string[] MultiObjectKW = {
      "MultiObject",
      "МногоОбъектов",
      "MultiOggetto",
      "MUltiObjekt",
      "多个对象(M)" ,
      "MULtipleObjeto",                                // ES - MUL
      "MULtiObjet",                                    // FR - MUL
      "ÇOKluNesne" };                                  // TR - ÇOK

    public static readonly string[] FaceOfSolidKW = {
      "FaceOfSolid",
      "ГраниТел",
      "FAcciaDiSolido",
      "Gesicht",
      "三维实体面(F)" ,
      "CARADelSólido",                                 // ES - CARA
      "FACeDeSolide",                                  // FR - FAC
      "YÜZKatı" };                                     // TR - YÜZ

    public static readonly string[] NotAnnotationKW = {
      "NotAnnotation",
      "НеАннотации",
      "NonAnnotazione",
      "KeineAnmerkung" ,
      "排除注释(N)",
      "NOAnotación",                                   // ES - NO
      "PASAnnotation",                                 // FR - PAS
      "ANOtasyonDeğil" };                              // TR - ANO

    public static readonly string[] InBlockKW = {
      "InBlock",
      "ВБлоках",
      "InBlocchi",
      "InBlöcken" ,
      "块内搜索(I)",
      "ENBloque",                                      // ES - EN
      "DANSBloc",                                      // FR - DANS
      "İÇİndeBlok" };                                  // TR - İÇİ

    public static readonly string[] HighlightKW = {
      "Highlight",
      "ПОдсветка",
      "Evidenziare",
      "MArkieren",
      "高亮(H)" ,
      "RESaltar",                                      // ES - RES
      "SURLigner",                                     // FR - SUR
      "VURgulamak" };                                  // TR - VUR

    public static readonly string[] DimensionFormatKW = {
      "DimensionFormat",
      "ФорматРазмеров",
      "FOrmatoDimensionale",
      "Bemaßungsformat",
      "尺寸格式(D)",
      "FORmatoDimensión",                              // ES - FOR
      "TAIlleDimension",                               // FR - TAI
      "ÖLÇüFormatı" };                                 // TR - ÖLÇ

    public static readonly string[] SolidTemplateQuery ={
      "Solid description template with substitutions. Return to default - *",
      "Формат описания солида с подстановками. Возврат к дефолту - *",
      "Modello di descrizione solido con sostituzioni. Torna ai valori predefiniti - *",
      "Volumenkörper Beschreibungsvorlage mit Substitutionen. Zurück zum Standard - *",
      "带有替换的可靠描述格式。 返回默认值 - *",
      "Plantilla de descripción de sólido con sustituciones. Volver al valor predeterminado - *",  // ES
      "Modèle de description de solide avec substitutions. Retour par défaut - *",  // FR
      "İkameli katı açıklama şablonu. Varsayılana dön - *" };  // TR

    public static readonly string[] BlockTemplateQuery ={
      "Block description template. Use %...% for substitute attribute. Return to default - *",
      "Формат описания блока включая подстановки и атрибуты. Возврат к дефолту - *",
      "Modello di descrizione del blocco. Usa %...% per l'attributo sostitutivo. Torna ai valori predefiniti - *",
      "Blockbeschreibungsvorlage. Verwenden Sie %...% als Ersatzattribut. Zurück zum Standard - *" ,
      "块描述格式，包括替换和属性。 返回默认值 - *",
      "Plantilla de descripción de bloque. Use %...% para atributo sustituto. Volver al valor predeterminado - *",  // ES
      "Modèle de description de bloc. Utilisez %...% pour l'attribut de substitution. Retour par défaut - *",  // FR
      "Blok açıklama şablonu. İkame özniteliği için %...% kullanın. Varsayılana dön - *"};  // TR

    public static readonly string[] OtherQuery ={
      "Other objects template with substitutions. Return to default - *",
      "Формат описания прочих объектов с подстановками. Возврат к дефолту - *",
      "Modello di altri oggetti con sostituzioni. Torna ai valori predefiniti - *",
      "Vorlage für andere Objekte mit Ersetzungen. Zurück zum Standard - *",
      "用替换描述其他对象的格式。 返回默认值 - *",
      "Plantilla de otros objetos con sustituciones. Volver al valor predeterminado - *",  // ES
      "Modèle d'autres objets avec substitutions. Retour par défaut - *",  // FR
      "İkameli diğer nesneler şablonu. Varsayılana dön - *" };  // TR

    public static readonly string[] InBlockQuery ={
      "Do find inside blocks and external references?",
      "Искать внутри блоков и внешних ссылок?",
      "Trova blocchi interni e riferimenti esterni?",
      "Finden Sie innere Blöcke und externe Referenzen?",
      "搜索内部块和外部链接？",
      "¿Buscar dentro de bloques y referencias externas?",  // ES
      "Rechercher à l'intérieur des blocs et des références externes ?",  // FR
      "Blokların ve harici referansların içinde ara?" };  // TR

    public static readonly string[] HighlightQuery ={
      "Do highlight a found object?",
      "Подсвечивать найденный объект?",
      "Evidenzia un oggetto trovato?",
      "Markieren Sie ein gefundenes Objekt?",
      "突出显示找到的对象？",
      "¿Resaltar un objeto encontrado?",               // ES
      "Mettre en surbrillance un objet trouvé ?",      // FR
      "Bulunan nesneyi vurgula?" };                    // TR

    public static readonly string[] DimensionFormatQuery ={
      "Enter dimension format. Default - 0.#",
      "Введите формат для размеров. по умолчанию 0.#",
      "Inserisci il formato della dimensione. Predefinito - 0. #",
      "Geben Sie ein Format für die Abmessungen ein. Standard - 0. #",
      "输入尺寸的格式。 默认 0.#",
      "Ingrese el formato de dimensión. Predeterminado - 0.#",  // ES
      "Entrez le format de dimension. Par défaut - 0.#",  // FR
      "Boyut formatını girin. Varsayılan - 0.#" };     // TR

    public static readonly string[] OnInfo = {
      "Smart Leader ON",
      "Умные выноски включены",
      "Smart Leader Permettere",
      "Smart Leader Aktivieren",
      "启用聪明的多重引线",
      "Smart Leader ACTIVADO",                         // ES
      "Smart Leader ACTIVÉ",                           // FR
      "Smart Leader AÇIK" };                           // TR

    public static readonly string[] OffInfo = {
      "Smart Leader OFF",
      "Умные выноски отключены",
      "Smart Leader Spegnere",
      "Smart Leader Deaktivieren",
      "禁用聪明的多重引线",
      "Smart Leader DESACTIVADO",                      // ES
      "Smart Leader DÉSACTIVÉ",                        // FR
      "Smart Leader KAPALI" };                         // TR

    public static readonly string[] NoObject ={
      "No object under leader found",
      "Под выноской нет подходящих объектов",
      "Nessun oggetto trovato sotto la freccia",
      "Kein Objekt unter Pfeil gefunden",
      "标注箭头下没有匹配的对象",
      "No se encontró ningún objeto bajo la directriz",  // ES
      "Aucun objet trouvé sous la ligne de repère",   // FR
      "Açıklama çizgisi altında nesne bulunamadı" };  // TR

    public static readonly string[] NotWork ={
      "Smart Leader did not work",
      "Умная выноска не сработала",
      "Smart Leader non ha funzionato",
      "Smart Leader hat nicht funktioniert",
      "智能标注不起作用",
      "Smart Leader no funcionó",                      // ES
      "Smart Leader n'a pas fonctionné",               // FR
      "Smart Leader çalışmadı" };                      // TR

    public static readonly string[] SubstitutionInfo ={
      "Substitution performed for object #{0:X} to leader #{1:X}",
      "Подстановки выполнены для объекта #{0:X} в выноске #{1:X}",
      "Sostituzioni eseguite per l'oggetto #{0: X} al leader #{1: X}",
      "Ersetzungen für Objekt #{0: X} in Führungslinien#{1: X} durchgeführt",
      "在标注 #{1:X} 中对对象 #{0:X} 进行了替换",
      "Sustitución realizada para el objeto #{0:X} en la directriz #{1:X}",  // ES
      "Substitution effectuée pour l'objet #{0:X} dans la ligne de repère #{1:X}",  // FR
      "#{0:X} nesnesi için #{1:X} açıklama çizgisinde ikame yapıldı" };  // TR

    public static readonly string[] LeaderCount = {
      "Found smart leaders: {0}",
      "Найдено умных выносок: {0}",
      "Smart Leader trovati: {0}",
      "Gefundene Smart Leaders: {0}",
      "找到的智能标注：{0}",
      "Smart Leaders encontrados: {0}",                // ES
      "Smart Leaders trouvés : {0}",                   // FR
      "Bulunan Smart Leader: {0}" };                   // TR

    public static readonly string[] NoLeader = {
      "Smart leaders not found",
      "Не найдено ни одной Умной Выноски",
      "Nessun Smart Leader trovato",
      "Keine Smart Leader gefunden",
      "未找到智能标注",
      "No se encontraron Smart Leaders",               // ES
      "Aucun Smart Leader trouvé",                     // FR
      "Smart Leader bulunamadı" };                     // TR

    public static readonly string[] LeaderUpdatedCount = {
      "Updated leaders: {0}",
      "Обновлено выносок: {0}",
      "Smart Leader aggiornato: {0}",
      "Aktualisiertes durchgeführt: {0}",
      "更新的标注：{0}",
      "Directrices actualizadas: {0}",                 // ES
      "Lignes de repère mises à jour : {0}",           // FR
      "Güncellenen açıklama çizgileri: {0}"};          // TR

    public static readonly string[] FailedCount = {
      "Failed to update: {0}",
      "Не удалось обновить: {0}",
      "Aggiornamento non riuscito: {0}",
      "Fehler beim Aktualisieren: {0}",
      "更新失败：{0}",
      "Error al actualizar: {0}",                      // ES
      "Échec de la mise à jour : {0}",                 // FR
      "Güncelleme başarısız: {0}" };                   // TR

    public static readonly string[] NoProperty ={
      "The object {0} has no required property",
      "Объект {0} не имеет запрошенных свойств",
      "L'oggetto {0} non ha proprietà richieste",
      "Das Objekt {0} hat keine erforderliche Eigenschaft",
      "对象 {0} 没有请求的属性",
      "El objeto {0} no tiene la propiedad requerida",  // ES
      "L'objet {0} n'a pas la propriété requise",      // FR
      "{0} nesnesi gerekli özelliğe sahip değil"};    // TR

    public static readonly string[] Updating = {
      "Updating",
      "Обновление",
      "In aggiornamento",
      "Aktualisierung",
      "更新",
      "Actualizando",                                  // ES
      "Mise à jour",                                   // FR
      "Güncelleniyor" };                               // TR

    public static readonly string[] FindAll ={
      "Find all smart leader in this drawing?",
      "Найти все умные выноски в чертеже?",
      "Trova tutti gli Smart Leader in questo disegno?",
      "Finden Sie alle Smart Leader in dieser Zeichnung?",
      "查找绘图中的所有智能标注？",
      "¿Buscar todos los Smart Leaders en este dibujo?",  // ES
      "Rechercher tous les Smart Leaders dans ce dessin ?",  // FR
      "Bu çizimdeki tüm Smart Leader'ları bul?" };     // TR

    public static readonly string[] SelectLeaders ={
      "Select smart leaders that requires to update",
      "Выберите выноски, которые надо обновить",
      "Seleziona Smart Leader che richiedono l'aggiornamento",
      "Wählen Sie Smart Leaders aus, die aktualisiert werden müssen",
      "选择要更新的标注",
      "Seleccione Smart Leaders que requieren actualización",  // ES
      "Sélectionnez les Smart Leaders qui nécessitent une mise à jour",  // FR
      "Güncellenmesi gereken Smart Leader'ları seçin" };  // TR

    public static readonly string[] Default ={
      "Return to the default template {0}",
      "Возврат к шаблону по умолчанию {0}",
      "Ritorna al modello predefinito {0}",
      "Kehren Sie zur Standardvorlage zurück {0}",
      "返回默认模板 {0}",
      "Volver a la plantilla predeterminada {0}",      // ES
      "Retour au modèle par défaut {0}",               // FR
      "Varsayılan şablona dön {0}" };                  // TR

    public static readonly string[] Activated = {
      "Smart leader activated",
      "Умная выноска активирована",
      "Smart Leader attivato.",
      "Smart Leader aktiviert.",
      "智能标注已激活",
      "Smart Leader activado",                         // ES
      "Smart Leader activé",                           // FR
      "Smart Leader etkinleştirildi" };                // TR

    public static readonly string[] Error ={
      "Error: {0}\n\nWould you like to continue updating the SmartLeaders?",
      "Ошибка: {0}\n\nПродолжить обновление выносок?",
      "Errore: {0}\n\nDesideri continuare ad aggiornare gli SmartLeader?",
      "Fehler: {0}\n\nMöchten Sie die SmartLeaders weiter aktualisieren?",
      "错误： {0}\n\n是否要继续更新标注？",
      "Error: {0}\n\n¿Desea continuar actualizando los Smart Leaders?",  // ES
      "Erreur : {0}\n\nVoulez-vous continuer à mettre à jour les Smart Leaders ?",  // FR
      "Hata: {0}\n\nSmart Leader'ları güncellemeye devam etmek ister misiniz?" };  // TR

    public static readonly string[] MultiObjectQuery ={
      "Do display a description of all the objects that are under the arrow, and not just the top one?",
      "Вывести описание всех объектов, которые окажутся под стрелкой, а не только самого верхнего?",
      "Visualizza una descrizione di tutti gli oggetti che si trovano sotto la freccia e non solo quello in alto?",
      "Zeigen Sie eine Beschreibung aller Objekte an, die sich unter dem Pfeil befinden, und nicht nur des obersten?",
      "显示箭头下方所有对象的描述，而不仅仅是顶部的对象？",
      "¿Mostrar una descripción de todos los objetos que están debajo de la flecha, y no solo el superior?",  // ES
      "Afficher une description de tous les objets sous la flèche, et pas seulement le premier ?",  // FR
      "Okun altındaki tüm nesnelerin açıklamasını göster, sadece en üsttekini değil mi?" };  // TR

    public static readonly string[] FaceOfSolidQuery ={
      "Do we derive the properties of sub-objects inside solids: surfaces, edges?",
      "Выводить свойства под-объектов внутри твердых тел: поверхностей, ребер?",
      "Deriviamo le proprietà dei sotto-oggetti all'interno dei solidi: superfici, bordi?",
      "Leiten wir die Eigenschaften von Unterobjekten innerhalb von Volumenkörpern ab: Oberflächen, Kanten?",
      "显示实体内部子对象的属性：面、边？",
      "¿Derivar las propiedades de los sub-objetos dentro de los sólidos: superficies, aristas?",  // ES
      "Dériver les propriétés des sous-objets à l'intérieur des solides : surfaces, arêtes ?",  // FR
      "Katıların içindeki alt nesnelerin özelliklerini türetelim mi: yüzeyler, kenarlar?" };  // TR

    public static readonly string[] NotAnnotationQuery ={
      "Do ignore all annotations and annotative blocks?",
      "Игнорировать все аннотации и аннотативные блоки?",
      "Ignora tutte le annotazioni e i blocchi annotativi?",
      "Ignorieren Sie alle Anmerkungen und Anmerkungsblöcke?",
      "忽略所有注释和注释块？",
      "¿Ignorar todas las anotaciones y bloques anotativos?",  // ES
      "Ignorer toutes les annotations et les blocs annotatifs ?",  // FR
      "Tüm açıklamaları ve açıklama bloklarını yoksay?" };  // TR

    public static readonly string[] ArrowPosition ={
      "Specify the arrow position for the new leader",
      "Укажите позицию стрелки для новой выноски",
      "Specifica la posizione della freccia",
      "Geben Sie die Pfeilposition an",
      "指定新标注的箭头位置",
      "Especifique la posición de la flecha para la nueva directriz",  // ES
      "Spécifiez la position de la flèche pour la nouvelle ligne de repère",  // FR
      "Yeni açıklama çizgisi için ok konumunu belirtin" };  // TR

    public static readonly string[] TextPosition = {
      "Specify the text position",
      "Укажите позицию текста",
      "Specifica la posizione del testo",
      "Geben Sie die Textposition an",
      "指定文本位置",
      "Especifique la posición del texto",             // ES
      "Spécifiez la position du texte",                // FR
      "Metin konumunu belirtin" };                     // TR

    public static readonly string[] Failed = {
      "Failed to create MLeader",
      "Не удалось создать MLeader",
      "Impossibile creare MLeader",
      "Führungslinien konnte nicht erstellt werden",
      "创建 MLeader 智能标注 失败",
      "Error al crear MLeader",                        // ES
      "Échec de la création de MLeader",               // FR
      "MLeader oluşturulamadı"};                       // TR

    public static readonly string[] PointsErr ={
      "To build a MLeader, you need 2 DIFFERENT points",
      "Для построения выноски требуются 2 РАЗНЫЕ точки",
      "Per costruire un MLeader, hai bisogno di 2 DIVERSI punti.",
      "Um einen Führungslinien zu erstellen, benötigen Sie 2 VERSCHIEDENE Punkte." ,
      "要构建标注，需要 2 个不同的点",
      "Para construir un MLeader, necesita 2 puntos DIFERENTES",  // ES
      "Pour construire un MLeader, vous avez besoin de 2 points DIFFÉRENTS",  // FR
      "MLeader oluşturmak için 2 FARKLI noktaya ihtiyacınız var"};  // TR

    public static readonly string[] SwitchOn = {
      "Smart leaders are disabled in the {0} leader style.\n\rTurn on?",
      "Умные выноски отключены в стиле выносок {0}.\n\nВключить?",
      "I leader intelligenti sono disattivati ​​nello stile di leader {0}.\n\rAccendere?",
      "Intelligente Führungslinien sind im Führungsstil {0} deaktiviert.\n\rAnmachen?",
      "在标注样式 {0} 中禁用智能标注。\n\n启用？",
      "Los Smart Leaders están deshabilitados en el estilo de directriz {0}.\n\r¿Activar?",  // ES
      "Les Smart Leaders sont désactivés dans le style de ligne de repère {0}.\n\rActiver ?",  // FR
      "Smart Leader'lar {0} açıklama çizgisi stilinde devre dışı.\n\rAçmak ister misiniz?" };  // TR

    public static readonly string[] Style = {
      "Options for Smart Leaders for style {0}",
      "Настройка умных выносок для стиля {0}",
      "Opzioni per Smart Leaders per stile {0}",
      "Optionen für Smart Leaders für Stil {0}",
      "为样式 {0} 设置智能标注",
      "Opciones de Smart Leaders para el estilo {0}",  // ES
      "Options de Smart Leaders pour le style {0}",    // FR
      "{0} stili için Smart Leader seçenekleri" };     // TR

    //======================================= Dialog Box ===================================================================

    public static readonly string[] BlinkText = {
      "Blinking highlight",
      "Мерцающая подсветка",
      "Luce lampeggiante",
      "Hintergrundbeleuchtung",
      "闪烁的背光",
      "Resaltado parpadeante",                         // ES
      "Surbrillance clignotante",                      // FR
      "Yanıp sönen vurgulama" };                       // TR

    public static readonly string[] BlinkTip = {
      "The found object will be highlighted in order to avoid errors. \r\n" +
        "You can turn it off if the blinking light prevents you.",
      "Найденный объект будет подсвечен во избежании ошибок. \r\n" +
        "Можно отключить если вам мешает моргание." ,
      "L'oggetto trovato verrà evidenziato per evitare errori. \r\n" +
        "Puoi spegnerlo se la luce lampeggiante te lo impedisce.",
      "Das gefundene Objekt wird hervorgehoben, um Fehler zu vermeiden. \r\n" +
        "Sie können es ausschalten, wenn Sie das Blinken stört.",
      "找到的对象将突出显示以避免错误。 \r\n" +
        "如果闪烁干扰您，您可以将其关闭。",
      "El objeto encontrado se resaltará para evitar errores. \r\n" +  // ES
        "Puede desactivarlo si el parpadeo le molesta.",
      "L'objet trouvé sera mis en surbrillance pour éviter les erreurs. \r\n" +  // FR
        "Vous pouvez le désactiver si le clignotement vous gêne.",
      "Bulunan nesne hataları önlemek için vurgulanacaktır. \r\n" +  // TR
        "Yanıp sönme sizi rahatsız ediyorsa kapatabilirsiniz." };

    public static readonly string[] InBlockText = {
      "Inside blocks",
      "Искать в блоках",
      "Blocchi interni",
      "Suchen Sie in Blöcken",
      "块内搜索",
      "Dentro de bloques",                             // ES
      "À l'intérieur des blocs",                       // FR
      "Blokların içinde" };                            // TR

    public static readonly string[] InBlockTip = {
      "Finding objects inside blocks and external references	",
      "Искать объекты внутри блоков и внешних ссылок",
      "Trovare oggetti all'interno di blocchi e riferimenti esterni",
      "Suche nach Objekten innerhalb von Blöcken und externen Links",
      "搜索块内的对象和外部链接",
      "Buscar objetos dentro de bloques y referencias externas",  // ES
      "Rechercher des objets à l'intérieur des blocs et des références externes",  // FR
      "Blokların ve harici referansların içindeki nesneleri bulma" };  // TR

    public static readonly string[] MultiObjectText = {
      "Many objects",
      "Много объектов",
      "Molti oggetti",
      "Viele Objekte",
      "多个对象",
      "Muchos objetos",                                // ES
      "Plusieurs objets",                              // FR
      "Birçok nesne" };                                // TR

    public static readonly string[] MultiObjectTip = {
      "Output on one leader a description of all the objects that will be under the arrow, \r\n" +
        "and not only the top one.",
      "Вывести на одной ссылке описание всех объектов, которые окажутся под стрелкой, \r\n" +
        "а не только одного самого верхнего.",
      "Emette su una guida una descrizione di tutti gli oggetti quello sarà sotto la freccia, \r\n" +
        "e non solo quella in alto.",
      "Zeigen Sie auf einem Link eine Beschreibung aller Objekte an, \r\n" +
        "die sich unter dem Pfeil befinden, und nicht nur das oberste.",
      "在一个智能标注上显示箭头下方所有对象的描述，\r\n" +
        "而不仅仅是顶部的对象。",
      "Mostrar en una directriz la descripción de todos los objetos bajo la flecha, \r\n" +  // ES
        "y no solo el superior.",
      "Afficher sur une ligne de repère la description de tous les objets sous la flèche, \r\n" +  // FR
        "et pas seulement le premier.",
      "Bir açıklama çizgisinde okun altındaki tüm nesnelerin açıklamasını göster, \r\n" +  // TR
        "sadece en üsttekini değil." };

    public static readonly string[] NativeText = {
      "Native search method",
      "Встроенный поиск",
      "Metodo di ricerca nativo",
      "Native Suchmethode",
      "旧搜索方法",
      "Método de búsqueda nativo",                     // ES
      "Méthode de recherche native",                   // FR
      "Yerel arama yöntemi" };                         // TR

    public static readonly string[] NativeTip = {
      "Use the old method of searching for objects under the leader built into the program. \r\n" +
        "The method does not allow to find many objects at once, it does not allow selecting subobjects.\r\n" +
        "The search depends on the settings of the visual style.\r\n" +
        "However, it works quickly and does not cause fatal errors.\r\n" +
        "This setting is common for all leader styles.",
      "Использовать старый метод поиска объектов под выноской, встроенный в Автокад. \r\n" +
        "Метод не позволяет находить сразу много объектов, не позволяет выбрать подобъекты. \r\n" +
        "Поиск зависит от настроек визуального стиля. \r\n" +
        "Однако работает быстро и не вызывает фатальных ошибок Автокада. Недоступно в БриксКАД. \r\n" +
        "Эта настройка общая для всех стилей выносок.",
      "Usa il vecchio metodo di ricerca di oggetti sotto il leader integrato nel programma. \r\n" +
        "Il metodo non consente di trovare molti oggetti contemporaneamente, non consente di selezionare sottooggetti.\r\n" +
        "La ricerca dipende dalle impostazioni dello stile visivo.\r\n" +
        "Tuttavia, funziona rapidamente e non causa errori irreversibili.\r\n" +
        "Questa impostazione è comune a tutti gli stili direttrice.",
      "Verwenden Sie die alte Methode zur Suche nach Objekten unter dem im Programm integrierten Leader. \r\n" +
        "Die Methode erlaubt es nicht, viele Objekte auf einmal zu finden, sie erlaubt keine Auswahl von Unterobjekten.\r\n" +
        "Die Suche hängt von den Einstellungen des visuellen Stils ab.\r\n" +
        "Aber es funktioniert schnell und verursacht keine fatalen Fehler.\r\n" +
        "Diese Einstellung gilt für alle Führungsstile.",
      "智能标注使用旧的对象搜索方法。\r\n" +
        "该方法不允许一次找到多个对象，也不允许选择子对象(块内对象)。\r\n" +
        "搜索取决于视觉风格的设置。\r\n" +
        "但是，它运行迅速，不会导致致命错误。\r\n" +
        "这种设置适用于所有领导风格。",
      "Utilizar el método antiguo de búsqueda de objetos bajo la directriz integrado en el programa. \r\n" +  // ES
        "El método no permite encontrar muchos objetos a la vez, no permite seleccionar subobjetos.\r\n" +
        "La búsqueda depende de la configuración del estilo visual.\r\n" +
        "Sin embargo, funciona rápidamente y no causa errores fatales.\r\n" +
        "Esta configuración es común para todos los estilos de directriz.",
      "Utiliser l'ancienne méthode de recherche d'objets sous la ligne de repère intégrée au programme. \r\n" +  // FR
        "La méthode ne permet pas de trouver plusieurs objets à la fois, elle ne permet pas de sélectionner des sous-objets.\r\n" +
        "La recherche dépend des paramètres du style visuel.\r\n" +
        "Cependant, elle fonctionne rapidement et ne provoque pas d'erreurs fatales.\r\n" +
        "Ce paramètre est commun à tous les styles de ligne de repère.",
      "Programa yerleşik olarak açıklama çizgisi altındaki nesneleri aramak için eski yöntemi kullanın. \r\n" +  // TR
        "Yöntem aynı anda birçok nesne bulmaya izin vermez, alt nesneleri seçmeye izin vermez.\r\n" +
        "Arama görsel stil ayarlarına bağlıdır.\r\n" +
        "Ancak hızlı çalışır ve ölümcül hatalara neden olmaz.\r\n" +
        "Bu ayar tüm açıklama çizgisi stilleri için ortaktır." };

    public static readonly string[] NotAnnotationsText = {
      "Not Annotations",
      "Не аннотации",
      "Non annotazioni	",
      "Nicht Anmerkungen",
      "排除注释",
      "Sin anotaciones",                               // ES
      "Pas d'annotations",                             // FR
      "Açıklama yok" };                                // TR

    public static readonly string[] NotAnnotationsTip = {
      "Ignore annotations under the leader.\r\n" +
        "Will be excluded: \r\n" +
        "- annotation objects (texts, multi leaders, dimensions, tables, views)\r\n" +
        "- all objects on the Annotation, Hatching, Axis, Viewport layers\r\n" +
        "- annotative blocks",
      "Игнорировать аннотации под выноской. \r\n" +
        "Будут исключены объекты аннотаций \r\n" +
        "(тексты, выноски, размеры, таблицы, виды, штриховки), \r\n" +
        "все объекты на слоях Аннотации, Штриховка, Оси, Viewport \r\n" +
        "и аннотативные блоки.",
      "Ignora le annotazioni sotto la direttrice. \r\n" +
        "Saranno esclusi:\r\n" +
        "- oggetti di annotazione (testi, multi leaders, dimensioni, tabelle, viste)\r\n" +
        "- tutti gli oggetti sui layer Annotation, Hatching, Axis, Viewport\r\n" +
        "- blocchi annotativi",
      "Anmerkungen unter der Führungslinie ignorieren.\r\n" +
        "Ausgeschlossen werden:\r\n" +
        "- Anmerkungsobjekte (Texte, MLeader, Bemaßungen, Tabellen, Ansichten),\r\n" +
        "- alle Objekte auf den Ebenen Beschriftung, Schraffur, Achse, Ansichtsfenster,\r\n" +
        "- abstrakte Blöcke",
      "忽略引线下的注释。\r\n" +
        "忽略对象：\r\n" +
        "- 注释对象（文本、标注 (MLeader)、尺寸、表格、视图），\r\n" +
        "- Annotation、Hatching、Axis、Viewport 图层上的所有对象，\r\n" +
        "- 抽象块",
      "Ignorar anotaciones bajo la directriz.\r\n" +  // ES
        "Se excluirán:\r\n" +
        "- objetos de anotación (textos, directrices múltiples, cotas, tablas, vistas)\r\n" +
        "- todos los objetos en las capas Annotation, Hatching, Axis, Viewport\r\n" +
        "- bloques anotativos",
      "Ignorer les annotations sous la ligne de repère.\r\n" +  // FR
        "Seront exclus :\r\n" +
        "- objets d'annotation (textes, lignes de repère multiples, cotes, tableaux, vues)\r\n" +
        "- tous les objets sur les calques Annotation, Hatching, Axis, Viewport\r\n" +
        "- blocs annotatifs",
      "Açıklama çizgisi altındaki açıklamaları yoksay.\r\n" +  // TR
        "Hariç tutulacaklar:\r\n" +
        "- açıklama nesneleri (metinler, çoklu açıklama çizgileri, boyutlar, tablolar, görünümler)\r\n" +
        "- Annotation, Hatching, Axis, Viewport katmanlarındaki tüm nesneler\r\n" +
        "- açıklama blokları" };

    public static readonly string[] OnText = {
      "Enable Smart Leader",
      "Включить Умные Выноски",
      "Abilita Smart Leader",
      "Aktivieren Sie Smart Leader",
      "启用聪明的多重引线",
      "Habilitar Smart Leader",                        // ES
      "Activer Smart Leader",                          // FR
      "Smart Leader'ı etkinleştir" };                  // TR

    public static readonly string[] OnTextTip = {
      "Enable search for objects under MLeader of this style when creating and editing MLeader. \r\n" +
        "If the option is disabled, then the search and substitution program will not be launched automatically \r\n" +
        "by the _MLD command and when the MLeader are moved.",
      "Выключить поиск объектов под выносками этого стиля при создании и редактировании выносок. \r\n" +
        "Если опция отключена, то программа поиска и подстановки \r\n" +
        "не будет запускаться автоматически по команде _MLD и при перемещениях выносок.",
      "Abilita la ricerca di oggetti in Multi Leader \r\n" +
        "di questo stile durante la creazione e la modifica di Multi Leader. \r\n" +
        "Se l'opzione è disabilitata, il programma di ricerca \r\n" +
        "e sostituzione non verrà avviato automaticamente \r\n" +
        "dal comando _MLD e quando si sposta la Multi Leader.",
      "Aktivieren Sie die Suche nach Objekten unter Multi-Führungslinien dieses Stils, \r\n" +
        "wenn Sie Multi-Führungslinien erstellen und bearbeiten. \r\n" +
        "Wenn die Option deaktiviert ist, \r\n" +
        "wird das Such- und Substitutionsprogramm nicht automatisch durch den Befehl _MLD \r\n" +
        "und beim Verschieben der Multi-Leader gestartet.",
      "创建和编辑多引线时启用在此样式的多引线下搜索对象。 \r\n" +
        "如果禁用该选项，则搜索和替换程序将不会由 _MLD \r\n" +
        "命令自动启动，并且在移动多引线时不会自动启动。",
      "Habilitar la búsqueda de objetos bajo MLeader de este estilo al crear y editar MLeader. \r\n" +  // ES
        "Si la opción está deshabilitada, el programa de búsqueda y sustitución no se iniciará automáticamente \r\n" +
        "con el comando _MLD y cuando se muevan los MLeader.",
      "Activer la recherche d'objets sous MLeader de ce style lors de la création et de la modification de MLeader. \r\n" +  // FR
        "Si l'option est désactivée, le programme de recherche et de substitution ne sera pas lancé automatiquement \r\n" +
        "par la commande _MLD et lors du déplacement des MLeader.",
      "Bu stil MLeader'ı oluştururken ve düzenlerken MLeader altındaki nesneleri aramayı etkinleştir. \r\n" +  // TR
        "Seçenek devre dışı bırakılırsa, arama ve değiştirme programı _MLD komutuyla \r\n" +
        "ve MLeader'lar taşındığında otomatik olarak başlatılmayacaktır." };

    public static readonly string[] UpdateOnEdit = {
      "Update on edit",
      "Обновлять при редактировании",
      "Aggiorna durante la modifica",
      "Beim Bearbeiten aktualisieren",
      "编辑时更新",
      "Actualizar al editar",                          // ES
      "Mettre à jour lors de la modification",         // FR
      "Düzenlerken güncelle" };                        // TR

    public static readonly string[] UpdateOnEditTip = {
      "Whenever you edit a MLeader, the search for objects under the MLeader will be performed again \r\n" +
        "and their properties will be substituted into the MLeader text.",
      "При любом редактировании выноски снова будет выполнен поиск объектов под выноской \r\n" +
        "и подстановка их свойств в текст выноски.",
      "Ogni volta che modifichi una Multi Leader, verrà eseguita nuovamente la ricerca di oggetti sotto la Multi Leader \r\n" +
        "e le loro proprietà verranno sostituite nel testo della Multi Leader.",
      "Jedes Mal, wenn Sie eine Multi-Führungslinie bearbeiten, wird die Suche nach Objekten \r\n" +
        "unter der Multi-Führungslinie erneut durchgeführt \r\n" +
        "und deren Eigenschaften werden in den Text der Multi-Führungslinie eingefügt.",
      "每次编辑多引线时，都会再次执行对多引线下对象的搜索，\r\n" +
        "并将其属性替换为多引线文本。",
      "Cada vez que edite un MLeader, se realizará nuevamente la búsqueda de objetos bajo el MLeader \r\n" +  // ES
        "y sus propiedades se sustituirán en el texto del MLeader.",
      "Chaque fois que vous modifiez un MLeader, la recherche d'objets sous le MLeader sera effectuée à nouveau \r\n" +  // FR
        "et leurs propriétés seront substituées dans le texte du MLeader.",
      "Bir MLeader'ı her düzenlediğinizde, MLeader altındaki nesnelerin aranması yeniden gerçekleştirilecek \r\n" +  // TR
        "ve özellikleri MLeader metnine yerleştirilecektir." };

    public static readonly string[] StyleTip = {
      "Select MultiLeader style to configure it. \r\n" +
        "Use command _MLeaderStyle to add or delete style.",
      "Стиль мультивыноски. \r\n" +
        "Используйте для быстрого переключения всех настроек сразу. \r\n" +
        "Добавить и удалить стиль в этом окне нельзя. \r\n" +
        "Используйте команду _MLeaderStyle",
      "Seleziona lo stile MultiLeader per configurarlo. \r\n" +
        "Utilizza il comando _MLeaderStyle per aggiungere o eliminare lo stile.",
      "Wählen Sie den MultiLeader-Stil aus, um ihn zu konfigurieren. \r\n" +
        "Verwenden Sie den Befehl _MLeaderStyle, um Stile hinzuzufügen oder zu löschen.",
      "选择 MultiLeader 多重引线样式进行配置。 \r\n" +
        "使用命令 _MLeaderStyle 多重引线样式管理器 添加或删除样式。",
      "Seleccione el estilo MultiLeader para configurarlo. \r\n" +  // ES
        "Use el comando _MLeaderStyle para agregar o eliminar estilos.",
      "Sélectionnez le style MultiLeader pour le configurer. \r\n" +  // FR
        "Utilisez la commande _MLeaderStyle pour ajouter ou supprimer un style.",
      "Yapılandırmak için MultiLeader stilini seçin. \r\n" +  // TR
        "Stil eklemek veya silmek için _MLeaderStyle komutunu kullanın." };

    public static readonly string[] SubobjectText = {
      "Face of solid",
      "Поверхности тел",
      "Faccia di solido",
      "Gesicht von 3D-Körper",
      "实体面",
      "Cara del sólido",                               // ES
      "Face du solide",                                // FR
      "Katının yüzü" };                                // TR

    public static readonly string[] SubobjectTip = {
      "Output properties of subobjects: surfaces, edges, vertices of solid.\r\n" +
        "Each face of the solid can have its own color, material, area and perimeter.\r\n" +
        "The rest of the properties will be taken as usual from the solid.\r\n" +
        "Use this option for mark materials of coating, edges, etc.",
      "Выводить свойства подобъектов: \r\n" +
        "поверхностей, ребер, вершин солида. \r\n" +
        "Каждая грань солида может иметь собственные цвет, материал, площадь и периметр.\r\n" +
        "Остальные свойства будут взяты как обычно у солида. \r\n" +
        "Используйте для маркировки материалов покрытия, кромок и т.п.",
      "Proprietà di output dei suboggetti: superfici, bordi, vertici del solido.\r\n" +
        "Ciascuna faccia del solido può avere il proprio colore, materiale, area e perimetro.\r\n" +
        "Il resto delle proprietà verrà preso come al solito dal solido.\r\n" +
        "Utilizzare questa opzione per contrassegnare materiali di rivestimento, bordi, ecc.",
      "Eigenschaften von Unterobjekten anzeigen: \r\n" +
        "Flächen, Kanten, solide Scheitelpunkte. \r\n" +
        "Jede Fläche eines Solids kann ihre eigene Farbe, Material, Fläche und Umfang haben, \r\n" +
        "die restlichen Eigenschaften werden wie gewohnt vom Solid übernommen. \r\n" +
        "Zum Markieren von Beschichtungsmaterialien, Kanten etc.",
      "显示对象的属性：面、边、实体顶点。 \r\n" +
        "三维实体的每个面都可以有自己的颜色、材质、面积和周长。\r\n" +
        "其余属性将照常取自实体。 \r\n" +
        "用于标记涂层材料、边缘等。",
      "Propiedades de salida de subobjetos: superficies, aristas, vértices del sólido.\r\n" +  // ES
        "Cada cara del sólido puede tener su propio color, material, área y perímetro.\r\n" +
        "El resto de las propiedades se tomarán como de costumbre del sólido.\r\n" +
        "Use esta opción para marcar materiales de revestimiento, bordes, etc.",
      "Propriétés de sortie des sous-objets : surfaces, arêtes, sommets du solide.\r\n" +  // FR
        "Chaque face du solide peut avoir sa propre couleur, matériau, surface et périmètre.\r\n" +
        "Le reste des propriétés sera pris comme d'habitude du solide.\r\n" +
        "Utilisez cette option pour marquer les matériaux de revêtement, les bords, etc.",
      "Alt nesnelerin çıktı özellikleri: yüzeyler, kenarlar, katının köşeleri.\r\n" +  // TR
        "Katının her yüzü kendi rengine, malzemesine, alanına ve çevresine sahip olabilir.\r\n" +
        "Özelliklerin geri kalanı her zamanki gibi katıdan alınacaktır.\r\n" +
        "Kaplama malzemelerini, kenarları vb. işaretlemek için bu seçeneği kullanın." };

    public static readonly string[] SeparatorText = {
      "Separator",
      "Разделитель",
      "Separatore",
      "Separator",
      "分隔符",
      "Separador",                                     // ES
      "Séparateur",                                    // FR
      "Ayırıcı" };                                     // TR

    public static readonly string[] SeparatorItems3 = {
      " and ",
      " и ",
      " e ",
      " und ",
      "和",
      " y ",                                           // ES
      " et ",                                          // FR
      " ve " };                                        // TR

    public static readonly string[] SeparatorTip = {
      "Select which symbol to insert between the descriptions of objects \r\n" +
        "when several objects are found under the leader",
      "Выберите из списка или введите символ, \r\n" +
        "который надо вставлять между описаниями объектов, когда найдено несколько объектов под выноской. \r\n" +
        "/P - это символ переноса строки. \r\n" +
        "Не забудьте про необходимые символы пробела.",
      "Seleziona dall'elenco o inserisci un carattere, \r\n" +
         "da inserire tra le descrizioni degli oggetti quando si trovano più oggetti sotto il MultiLeader.\r\n" +
         "/P è il carattere di interruzione di riga. \r\n" +
         "Non dimenticare i caratteri spaziali necessari.",
      "Wählen Sie aus der Liste aus oder geben Sie ein Zeichen ein, \r\n" +
        "das zwischen Funktionsbeschreibungen eingefügt werden soll, \r\n" +
        "wenn mehrere Funktionen unter der Legende gefunden werden. \r\n" +
        "/P ist das Zeilenumbruchzeichen. \r\n" +
        "Vergessen Sie nicht die erforderlichen Leerzeichen.",
      "当在智能标注下找到多个特征时，\r\n" +
        "从列表中选择或输入要在特征描述之间插入的字符。 \r\n" +
        "/P 是换行符。 \r\n" +
        "不要忘记所需的空格字符。",
      "Seleccione qué símbolo insertar entre las descripciones de objetos \r\n" +  // ES
        "cuando se encuentran varios objetos bajo la directriz.\r\n" +
        "/P es el carácter de salto de línea. \r\n" +
        "No olvide los caracteres de espacio necesarios.",
      "Sélectionnez le symbole à insérer entre les descriptions d'objets \r\n" +  // FR
        "lorsque plusieurs objets sont trouvés sous la ligne de repère.\r\n" +
        "/P est le caractère de saut de ligne. \r\n" +
        "N'oubliez pas les caractères d'espace nécessaires.",
      "Açıklama çizgisi altında birkaç nesne bulunduğunda \r\n" +  // TR
        "nesne açıklamaları arasına hangi sembolün ekleneceğini seçin.\r\n" +
        "/P satır sonu karakteridir. \r\n" +
        "Gerekli boşluk karakterlerini unutmayın." };

    public static readonly string[] BlockTip = {
      "Template for block. \r\n" +
        "You can use the attributes and parameters of the block. \r\n" +
        "Write the name (tag) of the attribute or parameter within the characters '%'.",
      "Шаблон для блоков. \r\n" +
        "Кроме обычных подстановок вы можете использовать атрибуты и параметры блока.\r\n" +
        "Напишите имя (тег) атрибута или параметра внутри символов %.",
      "Modello per blocco. \r\n" +
        "È possibile utilizzare gli attributi e i parametri del blocco. \r\n" +
        "Scrivi il nome (tag) dell'attributo o del parametro all'interno dei caratteri '%'.",
      "Vorlage für Block. \r\n" +
        "Sie können die Attribute und Parameter des Blocks verwenden. \r\n" +
        "Schreiben Sie den Namen (Tag) des Attributs oder Parameters innerhalb der Zeichen '%'.",
      "块模板。 \r\n" +
         "可以使用块的属性和参数。\r\n" +
        "将属性或参数的名称（标记）写在字符'%'内。",
      "Plantilla para bloque. \r\n" +  // ES
        "Puede usar los atributos y parámetros del bloque. \r\n" +
        "Escriba el nombre (etiqueta) del atributo o parámetro dentro de los caracteres '%'.",
      "Modèle pour bloc. \r\n" +  // FR
        "Vous pouvez utiliser les attributs et paramètres du bloc. \r\n" +
        "Écrivez le nom (tag) de l'attribut ou du paramètre entre les caractères '%'.",
      "Blok için şablon. \r\n" +  // TR
        "Bloğun özniteliklerini ve parametrelerini kullanabilirsiniz. \r\n" +
        "Özniteliğin veya parametrenin adını (etiketini) '%' karakterlerinin içine yazın." };

    public static readonly string[] OtherToolTip = {
      "Template for all other objects.",
      "Шаблон для всех остальных объектов.",
      "Modello per tutti gli altri oggetti.",
      "Vorlage für alle anderen Objekte.",
      "所有其他对象的模板。",
      "Plantilla para todos los demás objetos.",      // ES
      "Modèle pour tous les autres objets.",          // FR
      "Diğer tüm nesneler için şablon." };            // TR

    public static readonly string[] SolidTip = {
      "String for formatting MultiLeader text for solids.\r\n" +
         "May contain any substitutions of 3d-solid and drawing properties.",
      "Строка для форматирования текста выноски для солидов.\r\n" +
        "Может содержать любые подстановки свойств 3d-солида и чертежа.",
      "Stringa per la formattazione del testo del MultiLeader per i solidi.\r\n" +
         "Può contenere eventuali sostituzioni di proprietà del solido 3d e del progetto.",
      "Zeichenfolge zum Formatieren von MultiLeader-Text für Volumenkörper.\r\n" +
         "Kann beliebige Ersetzungen von 3D-Festkörper- und Blaupausen-Eigenschaften enthalten.",
      "三维实体智能标注文本的字符串。\r\n" +
         "包含三维实体和绘图属性的任何替换。",
      "Cadena para formatear texto de MLeader para sólidos.\r\n" +  // ES
         "Puede contener cualquier sustitución de propiedades de sólido 3D y dibujo.",
      "Chaîne pour formater le texte MLeader pour les solides.\r\n" +  // FR
         "Peut contenir toutes les substitutions de propriétés de solide 3D et de dessin.",
      "Katılar için MultiLeader metni biçimlendirme dizesi.\r\n" +  // TR
         "3D katı ve çizim özelliklerinin herhangi bir ikamesini içerebilir." };

    public static readonly string[] FormatText = {
      "Default format for",
      "Формат по умолчанию для",
      "Formato predefinito per",
      "Das Standardformat für",
      "默认格式",
      "Formato predeterminado para",                   // ES
      "Format par défaut pour",                        // FR
      "Varsayılan format" };                           // TR

    public static readonly string[] FormatToolTip = {
      "These formats will be used if you type '?' or leave the leader empty.",
      "Эти форматы будут использованы если вы введете '?' или если вы оставите выноску пустой.",
      "Questi formati verranno utilizzati se digiti '?' o lasciare vuoto il MultiLeader.",
      "Diese Formate werden verwendet, wenn Sie '?' oder wenn Sie das MultiLeader leer lassen.",
      "如果您输入'?'，将使用这些格式。 或者如果您将标注留空。",
      "Estos formatos se usarán si escribe '?' o deja la directriz vacía.",  // ES
      "Ces formats seront utilisés si vous tapez '?' ou laissez la ligne de repère vide.",  // FR
      "'?' yazarsanız veya açıklama çizgisini boş bırakırsanız bu formatlar kullanılacaktır." };  // TR

    public static readonly string[] BackgroundFill = {
      "Text background fill",
      "Фон текста",
      "Riempimento di sfondo",
      "Texthintergrundfüllung",
      "文本背景填充",
      "Relleno de fondo de texto",                     // ES
      "Remplissage d'arrière-plan du texte",          // FR
      "Metin arka plan dolgusu" };                     // TR

    public static readonly string[] BackgroundFillTip = {
      "Opaque background for leader text.\r\n" +
        "Only for leaders with text, not blocks.\r\n" +
        "Assigned only when creating new leaders.",
      "Непрозрачный фон текста выноски.\r\n" +
        "Только для выносок с текстом, а не с блоком. \r\n" +
        "Назначается только в момент создания новых выносок. ",
      "Sfondo opaco per il testo della guida.\r\n" +
        "Solo per guide con testo, non blocchi.\r\n" +
        "Assegnato solo quando si creano nuove guide.",
      "Undurchsichtiger Hintergrund für Führungslinientext.\r\n" +
        "Nur für Führungslinien mit Text, nicht für Blöcke.\r\n" +
        "Wird nur beim Erstellen neuer Führungslinien zugewiesen.",
      "引线文本的不透明背景。\r\n" +
        "仅适用于带文本的引线，而不适用于块。\r\n" +
        "仅在创建新引线时分配。",
      "Fondo opaco para texto de directriz.\r\n" +  // ES
        "Solo para directrices con texto, no bloques.\r\n" +
        "Asignado solo al crear nuevas directrices.",
      "Arrière-plan opaque pour le texte de ligne de repère.\r\n" +  // FR
        "Uniquement pour les lignes de repère avec texte, pas les blocs.\r\n" +
        "Attribué uniquement lors de la création de nouvelles lignes de repère.",
      "Açıklama çizgisi metni için opak arka plan.\r\n" +  // TR
        "Yalnızca metinli açıklama çizgileri için, bloklar için değil.\r\n" +
        "Yalnızca yeni açıklama çizgileri oluşturulurken atanır." };

    public static readonly string[] DialogTitle = {
      "Smart Leader Options",
      "Настройки Умных Выносок",
      "Opzioni di Leader Intelligente",
      "Intelligenter Führungslinie-Optionen",
      "智能标注。设置选项",
      "Opciones de Smart Leader",                      // ES
      "Options de Smart Leader",                       // FR
      "Smart Leader Seçenekleri"};                     // TR
  }
}