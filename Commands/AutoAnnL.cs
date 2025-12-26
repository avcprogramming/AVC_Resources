// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Ortho

namespace AVC
{
  public static class
  AutoAnnL
  {
    public static readonly string[] AutoAnnInfo = {
      "'Annotation' layer auto-switching ",
      "Автоматическое переключение слоя аннотаций ",
      "La commutazione automatica del layer di annotazione è ",
      "Die automatische Layer-Umschaltung zum Beschriften ist ",
      "'注释'层自动切换",
      "Cambio automático de capa 'Anotación' ",      // ES
      "Changement automatique de calque 'Annotation' ",  // FR
      "'Açıklama' katmanı otomatik değiştirme "};   // TR

    public static readonly string[] AutoOrthoInfo = {
      "Auto-ORTHO ",
      "Автоматическое отключение ортогональности (ORTHO) ",
      "Automaticamente l'ortogonalità (Auto-ORTHO) ",
      "Auto-ORTHO ist ",
      "自动禁用正交性 (ORTHO) ",
      "Auto-ORTHO ",                                 // ES
      "Auto-ORTHO ",                                 // FR
      "Otomatik-ORTHO "};                            // TR

    public static readonly string[] AutoSnapInfo = {
      "Auto-OSNAP ",
      "Автоматическое отключение привязок (OSNAP) ",
      "Auto-OSNAP Off è ora ",
      "Auto-OSNAP ist ",
      "自动禁用捕捉 (OSNAP) ",
      "Auto-OSNAP ",                                 // ES
      "Auto-OSNAP ",                                 // FR
      "Otomatik-OSNAP "};                            // TR

    public static readonly string[] On = {
      "ON",
      "включено",
      "attivata",
      "aktiviert",
      "包括",
      "ACTIVADO",                                    // ES
      "ACTIVÉ",                                      // FR
      "AÇIK"};                                       // TR

    public static readonly string[] Off = {
      "OFF",
      "отключено",
      "disattivato",
      "ausgeschaltet",
      "禁用",
      "DESACTIVADO",                                 // ES
      "DÉSACTIVÉ",                                   // FR
      "KAPALI"};                                     // TR

    // ========================= Command line ==============================================
    public static readonly string[] AutoAnnQuery = {
      "\nUse 'Annotation' layer auto switch?",
      "\nВключить авто-переключатель слоя?",
      "\nUtilizzare il sensore di layer?",
      "\nLayer Auto Switcher verwenden?",
      "\n使用'注释'层自动切换？",
      "\n¿Usar cambio automático de capa 'Anotación'?",           // ES
      "\nUtiliser le changement automatique de calque 'Annotation'?",  // FR
      "\n'Açıklama' katmanı otomatik değiştirmeyi kullan?"};     // TR

    public static readonly string[] CommandsKW = {
      "Commands",
      "Команды",
      "Comandi",
      "Befehle",
      "命令(C)",
      "Comandos",                                    // ES
      "Commandes",                                   // FR
      "Komutlar"};                                   // TR

    public static readonly string[] AutoAnnCmdQuery = {
      "\nInput list of command for auto-switch: ",
      "\nВведите список команд для авто-переключения: ",
      "\nImmettere l'elenco di comandi per l'auto-commutazione:",
      "\nEingabeliste des Befehls für Autoswitch:",
      "\n自动切换命令输入列表：",
      "\nIngrese la lista de comandos para el cambio automático: ",  // ES
      "\nEntrez la liste des commandes pour le changement automatique: ",  // FR
      "\nOtomatik değiştirme için komut listesini girin: "};        // TR

    public static readonly string[] AutoOrthoQuery = {
      "\nUse Auto-ORTHO switch?",
      "\nОтключать Орто ?",
      "\nUtilizzare l'opzione Auto-ORTHO?",
      "\nAuto-ORTHO-Schalter verwenden?",
      "\n使用自动正交开关？",
      "\n¿Usar interruptor Auto-ORTHO?",             // ES
      "\nUtiliser le commutateur Auto-ORTHO?",       // FR
      "\nOtomatik-ORTHO anahtarını kullan?"};        // TR

    public static readonly string[] AutoOrthoCmdQuery = {
      "\nInput list of command for Auto-ORTHO: ",
      "\nВведите список команд для Auto-ORTHO: ",
      "\nImmettere un elenco di comandi per Auto-ORTHO: ",
      "\nGeben Sie eine Befehlsliste fur Auto-ORTHO ein: ",
      "\nAuto-ORTHO 命令输入列表：",
      "\nIngrese la lista de comandos para Auto-ORTHO: ",  // ES
      "\nEntrez la liste des commandes pour Auto-ORTHO: ",  // FR
      "\nOtomatik-ORTHO için komut listesini girin: "};    // TR

    public static readonly string[] AutoSnapQuery = {
      "\nUse Auto-OSNAP switch?",
      "\nОтключать привязки ?",
      "\nUtilizzare l'opzione Auto-OSNAP?",
      "\nAuto-OSNAP-Schalter verwenden?",
      "\n自动禁用所有绑定 ?",
      "\n¿Usar interruptor Auto-OSNAP?",             // ES
      "\nUtiliser le commutateur Auto-OSNAP?",       // FR
      "\nOtomatik-OSNAP anahtarını kullan?"};        // TR

    public static readonly string[] AutoSnapCmdQuery = {
      "\nInput list of command for Auto-OSNAP: ",
      "\nВведите список команд для Auto-OSNAP: ",
      "\nImmettere un elenco di comandi per Auto-OSNAP:",
      "\nGeben Sie eine Befehlsliste fur Auto-OSNAP ein: ",
      "\n输入 Auto-OSNAP 的命令列表：",
      "\nIngrese la lista de comandos para Auto-OSNAP: ",  // ES
      "\nEntrez la liste des commandes pour Auto-OSNAP: ",  // FR
      "\nOtomatik-OSNAP için komut listesini girin: "};    // TR

    //========================== Options Dialog =============================
    public static readonly string[] AutoAnnText = {
      "Activate Annotation layer",
      "ВКЛ слой аннотаций",
      "Layer di annotazione ON",
      "Anmerkungsebene aktivieren",
      "激活注释层",
      "Activar capa de Anotación",                   // ES
      "Activer le calque d'Annotation",              // FR
      "Açıklama katmanını etkinleştir"};            // TR

    public static readonly string[] AutoAnnTip = {
      "All new annotation objects (texts, MLeaders, dimensions) \r\n" +
        "will appear on one layer 'Annotation'",
      "Все новые объекты аннотаций (тексты, выноски, размеры) \r\n" +
        "будут создаваться на слое Аннотации",
      "Tutti i nuovi oggetti di annotazione (testi, direttrici, quote) \r\n" +
        "verrà creato sul livello Annotation",
      "Alle neuen Anmerkungsobjekte (Texte, MFührungen, Bemaßungen)\r\n" +
        "werden auf einer Ebene 'Anmerkung' angezeigt.",
      "所有新的注释对象（文本、多引线、尺寸）将出现在一层'注释'上",
      "Todos los nuevos objetos de anotación (textos, directrices múltiples, dimensiones) \r\n" +  // ES
        "aparecerán en una capa 'Anotación'",
      "Tous les nouveaux objets d'annotation (textes, lignes de repère multiples, dimensions) \r\n" +  // FR
        "apparaîtront sur un calque 'Annotation'",
      "Tüm yeni açıklama nesneleri (metinler, çoklu liderler, boyutlar) \r\n" +  // TR
        "bir 'Açıklama' katmanında görünecektir"};

    public static readonly string[] AutoOrthoText = {
      "Turn off ORTHO",
      "ВЫКЛ ортогональность",
      "Ortogonalità OFF",
      "Deaktivieren Sie ORTHO",
      "关闭正交",
      "Desactivar ORTHO",                            // ES
      "Désactiver ORTHO",                            // FR
      "ORTHO'yu kapat"};                             // TR

    public static readonly string[] AutoSnapText = {
      "Turn off SNAP",
      "ВЫКЛ привязки",
      "Attacchi OFF",
      "Schalten Sie SNAP aus",
      "关闭快照",
      "Desactivar SNAP",                             // ES
      "Désactiver SNAP",                             // FR
      "SNAP'i kapat"};                               // TR

    public static readonly string[] AutoSwitchCommandsTip = {
      "The list of commands when called which triggers automatic switching.\r\n" +
        "Don't use a space.\r\n" +
        "The separator is a comma.",
      "Список команд, по которым происходит переключение.\r\n" +
        "Используйте только Английские названия команд.\r\n" +
        "Не используйте пробел. Разделитель - запятая.",
      "Elenco dei comandi mediante i quali avviene la commutazione.\r\n" +
        "Usa solo nomi di squadre inglesi.\r\n" +
        "Non usare uno spazio. Separatore - virgola.",
      "Liste der Befehle, zu denen gewechselt werden soll.\r\n" +
         "Nur englische Commandnamen verwenden.\r\n" +
         "Verwenden Sie kein Leerzeichen. Trennzeichen ist ein Komma.",
      "要切换到的命令列表。\r\n" +
         "只使用英文队名。\r\n" +
         "不要使用空格。分隔符是逗号。",
      "La lista de comandos que al llamarse activa el cambio automático.\r\n" +  // ES
        "No use espacios.\r\n" +
        "El separador es una coma.",
      "La liste des commandes qui, lorsqu'elles sont appelées, déclenchent le changement automatique.\r\n" +  // FR
        "N'utilisez pas d'espace.\r\n" +
        "Le séparateur est une virgule.",
      "Çağrıldığında otomatik değiştirmeyi tetikleyen komutların listesi.\r\n" +  // TR
        "Boşluk kullanmayın.\r\n" +
        "Ayırıcı virgüldür."};

  }
}