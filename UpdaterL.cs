// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Exe Ver

namespace AVC
{
  /// <summary>
  /// Локализация программы автообновлений плагинов Updater
  /// </summary>
  public static class UpdaterL
  {
    public static readonly string[] UpdaterVer = {
      "The A>V>C> plugin automatic update program is running: {0}. Version {1}",
      "Работает программа автоматических обновлений плагинов A>V>C>: {0}. Версия {1}",
      "Il programma di aggiornamento automatico dei plugin A>V>C> è in esecuzione: {0}. Versione {1}",
      "Das automatische Update-Programm für A>V>C>-Plugins läuft: {0}. Version {1}",
      "A>V>C> 插件的自动更新程序正在运行：{0}。版本 {1}" };
     public static readonly string[] UpdateQuery = {
      "There is a new version of {0} {1}.\r\n" +
        "The program can download the update in the background without interfering with your work.\r\n" +
        "Download the update now?",
      "Появилась новая версия {0} {1}.\r\n" +
        "Программа может скачать обновление в фоновом режиме не мешая вам работать.\r\n" +
        "Скачать обновление сейчас?",
      "È disponibile una nuova versione dei {0} {1}.\r\n" +
        "Il programma può scaricare l'aggiornamento in background senza interferire con il tuo lavoro.\r\n" +
        "Scarica subito l'aggiornamento?",
      "Es gibt eine neue Version der {0} {1}.\r\n" +
        "Das Programm kann das Update im Hintergrund herunterladen, ohne Ihre Arbeit zu beeinträchtigen.\r\n" +
        "Update jetzt herunterladen?",
      "{0} {1} 有新版本。\r\n" +
        "程序可以在后台下载更新，而不会干扰您的工作。\r\n" +
        "现在下载更新吗？" };
    public static readonly string[] Refused = {
      "User refused to install version {0}",
      "Пользователь отказался устанавливать версию {0}",
      "L'utente ha rifiutato di installare la versione {0}",
      "Benutzer hat die Installation von Version {0} abgelehnt",
      "用户拒绝安装版本 {0}" };
    public static readonly string[] Download = {
      "Downloading updates {0} from the server...",
      "Загрузка обновлений {0} с сервера...",
      "Download degli aggiornamenti {0} dal server...",
      "Herunterladen von Updates {0} vom Server...",
      "正在从服务器下载更新 {0}..."};
    public static readonly string[] DownloadErr = {
      "Failed to download updates from the server.",
      "Не удалось загрузить обновления с сервера",
      "Impossibile scaricare gli aggiornamenti dal server.",
      "Fehler beim Herunterladen von Updates vom Server.",
      "无法从服务器下载更新。"};
    public static readonly string[] Unzipping = {
      "Unpacking the archive with 7zip...",
      "Распаковка архива программой 7zip...",
      "Disimballare l'archivio con 7zip...",
      "Archiv mit 7zip entpacken...",
      "用 7zip 解压压缩包..."};
    public static readonly string[] Unzipped = {
      "The updates have been successfully unpacked.",
      "Обновления успешно распакованы.",
      "Gli aggiornamenti sono stati decompressi con successo.",
      "Die Updates wurden erfolgreich entpackt.",
      "更新已成功解压缩。"};
    public static readonly string[] NoPlugin = {
      "The update folder for plug-in {0} was not found.",
      "Не найдена папка обновлений для плагина {0}.",
      "La cartella di aggiornamento per il plug-in {0} non è stata trovata.",
      "Der Update-Ordner für das Plugin {0} wurde nicht gefunden.",
      "未找到插件 {0} 的更新文件夹。"};
    public static readonly string[] CopyFiles = {
      "The AVC_FileCopy program is launched to copy {0} files from the temporary folder to the plug-in folders.",
      "Запускается программа AVC_FileCopy для копирования {0} файлов из временной папки в папки плагинов.",
      "Il programma AVC_FileCopy viene avviato per copiare {0} file dalla cartella temporanea alle cartelle dei plug-in.",
      "Das Programm AVC_FileCopy wird gestartet, um {0} -Dateien aus dem temporären Ordner in die Plugin-Ordner zu kopieren.",
      "启动 AVC_FileCopy 程序将 {0} 文件从临时文件夹复制到插件文件夹。"};
    public static readonly string[] FileCopyErr = {
      "Failed to start file copy program AVC_FileCopy.",
      "Не удалось запустить программу копирования файлов AVC_FileCopy.",
      "Impossibile avviare il programma di copia file AVC_FileCopy.",
      "Fehler beim Starten des Dateikopierprogramms AVC_FileCopy.",
      "无法启动文件复制程序 AVC_FileCopy。" };
    public static readonly string[] ResetCAD = {
      "The {0} version {1} is installed.\r\n" +
        "A CAD restart is required.",
      "Установлена версия {0} {1}.\r\n" +
        "Требуется перезагрузка CAD.",
      "La versione del {0} {1} è installata.\r\n" +
        "È necessario riavviare CAD.",
      "Die {0}-Version {1} ist installiert.\r\n" +
        "Ein CAD-Neustart ist erforderlich.",
      "已安装 {0} 版本 {1}。\r\n" +
        "需要重新启动 CAD。" };
    public static readonly string[] ModeNo = {
      "Do not update",
      "Не обновлять",
      "Non aggiornare",
      "Nicht updaten",
      "不更新" };
    public static readonly string[] ModeQuery = {
      "Request",
      "Запрашивать",
      "Richiesta",
      "Anfrage",
      "询问" };
    public static readonly string[] ModeWarning = {
      "Update and alert",
      "Обновить и предупредить",
      "Aggiorna e allerta",
      "Aktualisieren und alarmieren",
      "更新和提醒" };
    public static readonly string[] ModeSilent = {
      "Update silently",
      "Обновить молча",
      "Aggiorna in silenzio",
      "Stumm aktualisieren",
      "后台更新" };
    public static readonly string[] NoNewVersion = {
      "No new version of {0} found.",
      "Не найдено новой версии {0}.",
      "Nessuna nuova versione di {0} trovata.",
      "Keine neue Version der {0} gefunden.",
      "未找到 {0} 的新版本。" };
    public static readonly string[] NeedConnection = {
      "The program works without access to the server. To update, turn on online mode.",
      "Программа работает без доступа к серверу. Для обновления включите онлайн режим.",
      "Il programma funziona senza accesso al server. Per aggiornare, attiva la modalità online.",
      "Das Programm funktioniert ohne Zugriff auf den Server. Aktivieren Sie zum Aktualisieren den Online-Modus.",
      "该程序无需访问服务器即可运行。 要更新，请打开在线模式。" };
    public static readonly string[] UpdaterExeNotExist = {
      "Automatic update program file not found. {0}",
      "Не найден файл программы автоматических обновлений {0}",
      "File del programma di aggiornamento automatico non trovato. {0} ",
      "Automatische Aktualisierungsprogrammdatei nicht gefunden. {0}",
      "未找到自动更新程序文件。 {0}" };
    public static readonly string[] AutoUpdate = {
      "Search for new versions of A>V>C> plugins is enabled.",
      "Включен поиск новых версий плагинов A>V>C>.",
      "La ricerca di nuove versioni dei plugin A>V>C> è abilitata.",
      "Die Suche nach neuen Versionen von A>V>C>-Plugins ist aktiviert.",
      "搜索新版本的 A>V>C> 插件已启用。" };
    public static readonly string[] RunError = {
      "Error starting the update program: {0}",
      "Ошибка при запуске программы обновления: {0}",
      "Errore durante l'avvio del programma di aggiornamento: {0}",
      "Fehler beim Starten des Updaters: {0}",
      "启动更新程序时出错：{0}" };

    // ====================================== Updater Dialog Box ================================================
    public static readonly string[] UpdaterTip = {
      "Plug-in updates can be downloaded from the server automatically. Or you can choose and install any version.",
      "Обновление плагинов может загружаться с сервера в автоматическом режиме. Или вы можете выбрать и установить любую версию.",
      "Gli aggiornamenti dei plugin possono essere scaricati automaticamente dal server. Oppure puoi scegliere e installare qualsiasi versione.",
      "Plugin-Updates können automatisch vom Server heruntergeladen werden. Oder Sie können eine beliebige Version auswählen und installieren.",
      "插件更新可以自动从服务器下载。 或者您可以选择并安装任何版本。"};
    public static readonly string[] Install = {
      "Install",
      "Установить",
      "Installare",
      "Installieren",
      "安装"};
    public static readonly string[] Beta = {
      "Automatically install pre-release(Beta) versions",
      "Автоматически устанавливать предварительные отладочные (Бета) версии",
      "Installa automaticamente le versioni pre-release (Beta).",
      "Vorabversionen (Beta) automatisch installieren.",
      "自动安装测试（Beta）版本"};
    public static readonly string[] Downloaded = {
      "Downloaded version",
      "Скачена версия ",
      "Versione scaricata",
      "Heruntergeladene Version",
      "下载版本"};
    public static readonly string[] Last = {
      "Last version",
      "Последняя версия",
      "Ultima versione",
      "Letzte Version",
      "最新版本"};
    public static readonly string[] UpdaterVersion = {
      "Updater version",
      "Версия Updater",
      "Versione 'Updater'",
      "Updater-Version",
      "更新程序版本"};
    public static readonly string[] PluginVersion = {
      "Plugin version",
      "Версия плагина",
      "Versione del plugin",
      "Plugin-Version",
      "插件版本"};
    public static readonly string[] Mode = {
      "Auto-Update Mode",
      "Режим обновлений",
      "Modalità di aggiornamento",
      "Aktualisierungsmodus",
      "更新模式"};
    public static readonly string[] Paid = {
      "You are not licensed for this update.",
      "У вас нет лицензии на это обновление.",
      "Non hai una licenza per questo aggiornamento.",
      "Sie haben keine Lizenz für dieses Update.",
      "您没有此更新的许可证。"};
    public static readonly string[] Update = {
      "Update",
      "Обновить",
      "Ricaricare",
      "Aktualisierung",
      "刷新"};
    public static readonly string[] Attempt = {
      "Attempt",
      "Рискнуть",
      "Tentare",
      "Versuchen",
      "尝试"};
    public static readonly string[] Reinstall = {
      "Reinstall",
      "Переустановить",
      "Reinstalla",
      "Neu installieren",
      "重新安装"};
    public static readonly string[] Rollback = {
      "Roll back",
      "Откатить",
      "Torna indietro",
      "Rollback",
      "回滚"};
    public static readonly string[] OptionsTab = {
      "Update settings",
      "Настройки обновлений",
      "Aggiorna impostazioni",
      "Update Einstellungen",
      "更新设置"};
    public static readonly string[] LogTab = {
      "Message Log",
      "Журнал сообщений",
      "Registro messaggi",
      "Nachrichtenprotokoll",
      "消息日志" };
    public static readonly string[] LoadingPercent = {
      "Loading data... Completed {0}%",
      "Загрузка данных... Выполнено {0}%",
      "Caricamento dati in corso... {0}% completato",
      "Daten werden geladen... {0}% abgeschlossen",
      "正在加载数据... {0}% 已完成"};
    public static readonly string[] SecondTry = {
      "An error occurred while reading data from the server. Second try...",
      "Ошибка при считывании данных с сервера. Вторая попытка...",
      "Si è verificato un errore durante la lettura dei dati dal server. Secondo tentativo...",
      "Beim Lesen von Daten vom Server ist ein Fehler aufgetreten. Zweiter Versuch...",
      "从服务器读取数据时出错。请切换网络供应商。第二次尝试..." };
    public static readonly string[] ThirdTry = {
      "An error occurred while reading data from the server. Third try...",
      "Ошибка при считывании данных с сервера. Третья  попытка...",
      "Si è verificato un errore durante la lettura dei dati dal server. Terzo tentativo...",
      "Beim Lesen von Daten vom Server ist ein Fehler aufgetreten. Dritter Versuch...",
      "从服务器读取数据时出错。请切换网络供应商。第三次尝试..." };
    public static readonly string[] ArchiveWriting = {
      "Write archive to file {0}...",
      "Запись архива в файл {0}...",
      "Scrivi archivio su file {0}...",
      "Archiv in Datei {0} schreiben...",
      "将存档写入文件 {0}..." };
    public static readonly string[] TimerTick = {
      "{0}. Timer check for updates...",
      "{0}. Проверка обновлений по таймеру...",
      "{0}. Controllo aggiornamenti tramite timer...",
      "{0}. Timer-Überprüfung auf Updates...",
      "{0}. 定时检查更新..." };
  }
}
