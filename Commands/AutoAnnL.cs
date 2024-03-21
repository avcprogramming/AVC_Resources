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
      "'注释'层自动切换" };
    public static readonly string[] AutoOrthoInfo = { 
      "Auto-ORTHO ", 
      "Автоматическое отключение ортогональности (ORTHO) ", 
      "Automaticamente l'ortogonalità (Auto-ORTHO) ", 
      "Auto-ORTHO ist ",
      "自动禁用正交性 (ORTHO) " };
    public static readonly string[] AutoSnapInfo = { 
      "Auto-OSNAP ", 
      "Автоматическое отключение привязок (OSNAP) ", 
      "Auto-OSNAP Off è ora ", 
      "Auto-OSNAP ist ",
      "自动禁用捕捉 (OSNAP) " };
    public static readonly string[] On = { 
      "ON", 
      "включено", 
      "attivata", 
      "aktiviert",
      "包括" };
    public static readonly string[] Off = { 
      "OFF", 
      "отключено", 
      "disattivato", 
      "ausgeschaltet",
      "禁用" };

    // ========================= Command line ==============================================
    public static readonly string[] AutoAnnQuery = { 
      "\nUse 'Annotation' layer auto switch?", 
      "\nВключить авто-переключатель слоя?", 
      "\nUtilizzare il sensore di layer?", 
      "\nLayer Auto Switcher verwenden?",
      "\n使用“注释”层自动切换？"};
    public static readonly string[] CommandsKW = { 
      "Commands", 
      "Команды", 
      "Comandi", 
      "Befehle",
      "命令(C)" };
    public static readonly string[] AutoAnnCmdQuery = { 
      "\nInput list of command for auto-switch: ", 
      "\nВведите список команд для авто-переключения: ", 
      "\nImmettere l'elenco di comandi per l'auto-commutazione:",
      "\nEingabeliste des Befehls für Autoswitch:",
      "\n自动切换命令输入列表：" };
    public static readonly string[] AutoOrthoQuery = { 
      "\nUse Auto-ORTHO switch?", 
      "\nОтключать Орто ?", 
      "\nUtilizzare l'opzione Auto-ORTHO?", 
      "\nAuto-ORTHO-Schalter verwenden?",
      "\n使用自动正交开关？" };
    public static readonly string[] AutoOrthoCmdQuery = { 
      "\nInput list of command for Auto-ORTHO: ", 
      "\nВведите список команд для Auto-ORTHO: ",
      "\nImmettere un elenco di comandi per Auto-ORTHO: ",
      "\nGeben Sie eine Befehlsliste fur Auto-ORTHO ein: ",
      "\nAuto-ORTHO 命令输入列表：" };
    public static readonly string[] AutoSnapQuery = { 
      "\nUse Auto-OSNAP switch?", 
      "\nОтключать привязки ?", 
      "\nUtilizzare l'opzione Auto-OSNAP?", 
      "\nAuto-OSNAP-Schalter verwenden?",
      "\n自动禁用所有绑定 ?" };
    public static readonly string[] AutoSnapCmdQuery = { 
      "\nInput list of command for Auto-OSNAP: ", 
      "\nВведите список команд для Auto-OSNAP: ",
      "\nImmettere un elenco di comandi per Auto-OSNAP:",
      "\nGeben Sie eine Befehlsliste fur Auto-OSNAP ein: ",
      "\n输入 Auto-OSNAP 的命令列表：" };

    //========================== Options Dialog =============================
    public static readonly string[] AutoAnnText = {
      "Activate Annotation layer",
      "ВКЛ слой аннотаций",
      "Layer di annotazione ON",
      "Anmerkungsebene aktivieren",
      "激活注释层"};
public static readonly string[] AutoAnnTip = {
      "All new annotation objects (texts, MLeaders, dimensions) \r\n" +
        "will appear on one layer 'Annotation'",
      "Все новые объекты аннотаций (тексты, выноски, размеры) \r\n" +
        "будут создаваться на слое Аннотации",
      "Tutti i nuovi oggetti di annotazione (testi, direttrici, quote) \r\n" +
        "verrà creato sul livello Annotation",
      "Alle neuen Anmerkungsobjekte (Texte, MFührungen, Bemaßungen)\r\n" +
        "werden auf einer Ebene „Anmerkung“ angezeigt.",
      "所有新的注释对象（文本、多引线、尺寸）将出现在一层“注释”上"};
    public static readonly string[] AutoOrthoText = {
      "Turn off ORTHO",
      "ВЫКЛ ортогональность",
      "Ortogonalità OFF",
      "Deaktivieren Sie ORTHO",
      "关闭正交"};
    public static readonly string[] AutoSnapText = {
      "Turn off SNAP",
      "ВЫКЛ привязки",
      "Attacchi OFF",
      "Schalten Sie SNAP aus",
      "关闭快照"};
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
         "不要使用空格。分隔符是逗号。"};

  }
}
