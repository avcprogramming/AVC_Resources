// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Req

namespace AVC
{
  public static class
  AutoLngL
  {
    public static readonly string[] Switch = {
      "\nUse language auto switch?",
      "\nВключить автопереключатель языка?" ,
      "\nAbilitare il cambio automatico della lingua?",
      "\nSprachautomatik aktivieren?",
      "\n启用自动语言切换？"};
    public static readonly string[] Select = {
      "\nSelect your national language ",
      "\nВыберите ваш родной язык " ,
      "\nScegli la tua lingua madre ",
      "\nWählen Sie Ihre Muttersprache ",
      "\n选择您的国家语言 "};
    public static readonly string[] CommandQuery = {
      "\nInput list of command for autoswitch: ",
      "\nВведите список команд для автопереключения: ",
      "\nImmettere l'elenco di comandi per l'auto-commutazione: ",
      "\nGeben Sie die Liste der Befehle zum automatischen Umschalten ein: ",
      "\n输入自动切换的命令列表："};
    public static readonly string[] CodeErr = {
      "Error language code. Use hex keyboard-layout code",
      "Ошибочный код языка. Используйте шестнадцатеричные коды раскладок клавиатуры",
      "Codice lingua errato. Usa codici di layout tastiera esadecimali",
      "Falscher Sprachcode. Verwenden Sie hexadezimale Tastaturlayoutcodes",
      "错误语言代码。 使用十六进制键盘布局代码" };
    public static readonly string[] AutoSwitchOnOff = {
      "Keyboard language automatic switch ",
      "Автоматическое переключение языка ввода ",
      "Cambia automaticamente la lingua di input ",
      "Eingabesprache automatisch wechseln ",
      "键盘语言自动切换 "};
    public static readonly string[] ToLng = {
      "to language #",
      "включено на язык №",
      "alla lingua #",
      "zur Sprache #",
      "包括每种语言 #" };
    public static readonly string[] LngCodeQuery = {
      "\nEnter the hexadecimal or alphabetic code of language: ",
      "\nВведите шестнадцатеричный или буквенный код языка: ",
      "\nInserisci il codice lingua esadecimale o alfabetico: ",
      "\nGeben Sie den hexadezimalen oder alphabetischen Sprachcode ein:",
      "\n输入十六进制或字母语言代码："};
    //public static readonly string[] NotWork ={
    //  "Language switching will not work in the localized version of AutoCAD|BricsCAD",
    //  "Переключение языка не будет работать в Русской версии Автокада|BricsCAD",
    //  "Il cambio di lingua non funzionerà nella versione localizzata di AutoCAD|BricsCAD",
    //  "Die Sprachumschaltung funktioniert in der lokalisierten VersionYM von AutoCAD|BricsCAD nicht",
    //  "语言切换在 AutoCAD|BricsCAD 的本地化版本中不起作用"};
    public static readonly string[] SameLng = {
      "The same control language and text input language are assigned. Switching language will not work.",
      "Назначен один и тот же язык управления и язык ввода текстов. Переключение языка не будет работать.",
      "Vengono assegnate la stessa lingua di controllo e la stessa lingua di immissione del testo. Cambiare la lingua non funzionerà.",
      "Es wird die gleiche Steuersprache und Texteingabesprache zugewiesen. Das Umschalten der Sprache funktioniert nicht.",
      "分配相同的控制语言和文本输入语言。 切换语言将不起作用。" };
    public static readonly string[] CodeReq = {
      "Language code required",
      "Требуется код языка",
      "Codice lingua richiesto",
      "Sprachcode erforderlich",
      "需要语言代码"};
    public static readonly string[] CommandsReq = {
      "Command list required",
      "Требуется список команд",
      "Elenco dei comandi richiesto",
      "Befehlsliste erforderlich",
      "需要语言代码"};
    public static readonly string[] LocalCode = {
      "Text input language",
      "Язык ввода текстов",
      "Lingua di inserimento del testo",
      "Texteingabesprache",
      "文字输入语言"};
    public static readonly string[] LocalCodeTip = {
      "Keyboard layout code of your native language",
      "Код вашего языка для ввода текстов (русского) ",
      "Codice layout tastiera della tua lingua madre",
      "Tastaturlayoutcode Ihrer Muttersprache",
      "您的母语的键盘布局代码"};
    public static readonly string[] CommandCode = {
      "Command input language",
      "Язык ввода команд",
      "Lingua di input dei comandi",
      "Befehlseingabesprache",
      "命令输入语言"};
    public static readonly string[] CommandCodeTip = {
      "Language code in which you control the program, enter commands and options",
      "Код языка, на котором вы управляете программой, вводите команды и опции",
      "Codice della lingua in cui controlli il programma, inserisci comandi e opzioni",
      "Code der Sprache, in der Sie das Programm steuern, Befehle und Optionen eingeben",
      "您控制程序、输入命令和选项的语言代码"};
    public static readonly string[] CommandsTip = {
      "List of commands that require you to enter texts in your native language.\r\n" +
        "Use English team names. Don't use a space. The separator is a comma.",
      "Список команд, которые требуют ввода текстов на вашем родном языке.\r\n" +
        "Используйте английские названия команд. Не используйте пробел. Разделитель — запятая.",
      "Elenco di comandi che richiedono l'inserimento di testi nella tua lingua madre.\r\n" +
        "Usa i nomi delle squadre in inglese. Non utilizzare uno spazio. Il separatore è una virgola.",
      "Liste der Befehle, bei denen Sie Texte in Ihrer Muttersprache eingeben müssen.\r\n" +
        "Verwenden Sie englische Teamnamen. Verwenden Sie kein Leerzeichen. Das Trennzeichen ist ein Komma.",
      "要求您以母语输入文本的命令列表。 " +
        "使用英文团队名称。 不要使用空格。 分隔符是逗号。"};
    public static readonly string[] CommandsLabel = {
      "Command list for language autoswitch",
      "Список команд для автопереключения языка",
      "Elenco dei comandi per la commutazione automatica della lingua",
      "Befehlsliste für die automatische Sprachumschaltung",
      "语言自动切换命令列表"};
    public static readonly string[] SwitchLng = {
      "Auto switch the keyboard language",
      "Переключать язык клавиатуры",
      "Cambia automaticamente la lingua della tastiera",
      "Automatisches Umschalten der Tastatursprache",
      "自动切换键盘语言"};

    //================================================= Command Line Options ===============================================

    public static readonly string[] LanguageKW = {
      "Language",
      "Язык",
      "Linguaggio",
      "Sprache",
      "语言(L)"};
    public static readonly string[] MainKW = {
      "Main",
      "Главный",
      "Principale",
      "Hauptsächlich",
      "主要的(M)"};
    public static readonly string[] CommandsKW = {
      "Commands",
      "Команды",
      "Comandi",
      "Befehle",
      "命令(C)" };
    public static readonly string[] SystemKW = {
      "System",
      "Системный",
      "Sistema",
      "System",
      "系统语言(S)" };
    public static readonly string[] AnotherKW = {
      "Another",
      "Другой",
      "UnAltro",
      "EinWeiterer",
      "其他(A)" };

  }
}
