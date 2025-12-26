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
      "A>V>C> 插件的自动更新程序正在运行：{0}。版本 {1}",
      "El programa de actualización automática de complementos A>V>C> está en ejecución: {0}. Versión {1}",
      "Le programme de mise à jour automatique des plug-ins A>V>C> est en cours d'exécution: {0}. Version {1}",
      "A>V>C> eklenti otomatik güncelleme programı çalışıyor: {0}. Sürüm {1}"};

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
        "现在下载更新吗？",
      "Hay una nueva versión de {0} {1}.\r\n" +
        "El programa puede descargar la actualización en segundo plano sin interferir con su trabajo.\r\n" +
        "¿Descargar la actualización ahora?",
      "Il existe une nouvelle version de {0} {1}.\r\n" +
        "Le programme peut télécharger la mise à jour en arrière-plan sans interférer avec votre travail.\r\n" +
        "Télécharger la mise à jour maintenant?",
      "{0} {1} için yeni bir sürüm mevcut.\r\n" +
        "Program, çalışmanızı engellemeden arka planda güncellemeyi indirebilir.\r\n" +
        "Güncellemeyi şimdi indir?"};

    public static readonly string[] Refused = {
      "User refused to install version {0}",
      "Пользователь отказался устанавливать версию {0}",
      "L'utente ha rifiutato di installare la versione {0}",
      "Benutzer hat die Installation von Version {0} abgelehnt",
      "用户拒绝安装版本 {0}",
      "El usuario rechazó instalar la versión {0}",
      "L'utilisateur a refusé d'installer la version {0}",
      "Kullanıcı {0} sürümünü yüklemeyi reddetti"};

    public static readonly string[] Download = {
      "Downloading updates {0} From the server...",
      "Загрузка обновлений {0} с сервера...",
      "Download degli aggiornamenti {0} dal server...",
      "Herunterladen von Updates {0} vom Server...",
      "正在从服务器下载更新 {0}...",
      "Descargando actualizaciones {0} del servidor...",
      "Téléchargement des mises à jour {0} depuis le serveur...",
      "Sunucudan güncellemeler {0} indiriliyor..."};

    public static readonly string[] DownloadErr = {
      "Failed to download updates From the server.",
      "Не удалось загрузить обновления с сервера",
      "Impossibile scaricare gli aggiornamenti dal server.",
      "Fehler beim Herunterladen von Updates vom Server.",
      "无法从服务器下载更新。",
      "No se pudieron descargar las actualizaciones del servidor.",
      "Impossible de télécharger les mises à jour depuis le serveur.",
      "Sunucudan güncellemeler indirilemedi."};

    public static readonly string[] Unzipping = {
      "Unpacking the archive with 7zip...",
      "Распаковка архива программой 7zip...",
      "Disimballare l'archivio con 7zip...",
      "Archiv mit 7zip entpacken...",
      "用 7zip 解压压缩包...",
      "Descomprimiendo el archivo con 7zip...",
      "Décompression de l'archive avec 7zip...",
      "7zip ile arşiv açılıyor..."};

    public static readonly string[] Unzipped = {
      "The updates have been successfully unpacked.",
      "Обновления успешно распакованы.",
      "Gli aggiornamenti sono stati decompressi con successo.",
      "Die Updates wurden erfolgreich entpackt.",
      "更新已成功解压缩。",
      "Las actualizaciones se han descomprimido correctamente.",
      "Les mises à jour ont été décompressées avec succès.",
      "Güncellemeler başarıyla açıldı."};

    public static readonly string[] NoPlugin = {
      "The update folder for plug-in {0} was not found.",
      "Не найдена папка обновлений для плагина {0}.",
      "La cartella di aggiornamento per il plug-in {0} non è stata trovata.",
      "Der Update-Ordner für das Plugin {0} wurde nicht gefunden.",
      "未找到插件 {0} 的更新文件夹。",
      "No se encontró la carpeta de actualización para el complemento {0}.",
      "Le dossier de mise à jour pour le plug-in {0} est introuvable.",
      "Eklenti {0} için güncelleme klasörü bulunamadı."};

    public static readonly string[] CopyFiles = {
      "The AVC_FileCopy program is launched to copy {0} files From the temporary folder to the plug-in folders.",
      "Запускается программа AVC_FileCopy для копирования {0} файлов из временной папки в папки плагинов.",
      "Il programma AVC_FileCopy viene avviato per copiare {0} file dalla cartella temporanea alle cartelle dei plug-in.",
      "Das Programm AVC_FileCopy wird gestartet, um {0} -Dateien aus dem temporären Ordner in die Plugin-Ordner zu kopieren.",
      "启动 AVC_FileCopy 程序将 {0} 文件从临时文件夹复制到插件文件夹。",
      "Se inicia el programa AVC_FileCopy para copiar {0} archivos desde la carpeta temporal a las carpetas de complementos.",
      "Le programme AVC_FileCopy est lancé pour copier {0} fichiers du dossier temporaire vers les dossiers de plug-ins.",
      "AVC_FileCopy programı, geçici klasörden eklenti klasörlerine {0} dosya kopyalamak için başlatılıyor."};

    public static readonly string[] FileCopyErr = {
      "Failed to start file copy program AVC_FileCopy.",
      "Не удалось запустить программу копирования файлов AVC_FileCopy.",
      "Impossibile avviare il programma di copia file AVC_FileCopy.",
      "Fehler beim Starten des Dateikopierprogramms AVC_FileCopy.",
      "无法启动文件复制程序 AVC_FileCopy。",
      "No se pudo iniciar el programa de copia de archivos AVC_FileCopy.",
      "Impossible de démarrer le programme de copie de fichiers AVC_FileCopy.",
      "Dosya kopyalama programı AVC_FileCopy başlatılamadı."};

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
        "需要重新启动 CAD。",
      "La versión {0} {1} está instalada.\r\n" +
        "Se requiere reiniciar CAD.",
      "La version {0} {1} est installée.\r\n" +
        "Un redémarrage de CAD est requis.",
      "{0} sürüm {1} yüklendi.\r\n" +
        "CAD yeniden başlatma gereklidir."};

    public static readonly string[] ModeNo = {
      "Do not update",
      "Не обновлять",
      "Non aggiornare",
      "Nicht updaten",
      "不更新",
      "No actualizar",
      "Ne pas mettre à jour",
      "Güncelleme"};

    public static readonly string[] ModeQuery = {
      "Request",
      "Запрашивать",
      "Richiesta",
      "Anfrage",
      "询问",
      "Solicitar",
      "Demander",
      "Sor"};

    public static readonly string[] ModeWarning = {
      "Update and alert",
      "Обновить и предупредить",
      "Aggiorna e allerta",
      "Aktualisieren und alarmieren",
      "更新和提醒",
      "Actualizar y alertar",
      "Mettre à jour et alerter",
      "Güncelle ve uyar"};

    public static readonly string[] ModeSilent = {
      "Update silently",
      "Обновить молча",
      "Aggiorna in silenzio",
      "Stumm aktualisieren",
      "后台更新",
      "Actualizar silenciosamente",
      "Mettre à jour silencieusement",
      "Sessizce güncelle"};

    public static readonly string[] NoNewVersion = {
      "No new version of {0} found.",
      "Не найдено новой версии {0}.",
      "Nessuna nuova versione di {0} trovata.",
      "Keine neue Version der {0} gefunden.",
      "未找到 {0} 的新版本。",
      "No se encontró una nueva versión de {0}.",
      "Aucune nouvelle version de {0} trouvée.",
      "{0} için yeni sürüm bulunamadı."};

    public static readonly string[] NeedConnection = {
      "The program works without access to the server. To update, turn on online mode.",
      "Программа работает без доступа к серверу. Для обновления включите онлайн режим.",
      "Il programma funziona senza accesso al server. Per aggiornare, attiva la modalità online.",
      "Das Programm funktioniert ohne Zugriff auf den Server. Aktivieren Sie zum Aktualisieren den Online-Modus.",
      "该程序无需访问服务器即可运行。 要更新，请打开在线模式。",
      "El programa funciona sin acceso al servidor. Para actualizar, active el modo en línea.",
      "Le programme fonctionne sans accès au serveur. Pour mettre à jour, activez le mode en ligne.",
      "Program sunucuya erişim olmadan çalışır. Güncellemek için çevrimiçi modu açın."};

    public static readonly string[] UpdaterExeNotExist = {
      "Automatic update program file not found. {0}",
      "Не найден файл программы автоматических обновлений {0}",
      "File del programma di aggiornamento automatico non trovato. {0} ",
      "Automatische Aktualisierungsprogrammdatei nicht gefunden. {0}",
      "未找到自动更新程序文件。 {0}",
      "No se encontró el archivo del programa de actualización automática. {0}",
      "Fichier du programme de mise à jour automatique introuvable. {0}",
      "Otomatik güncelleme program dosyası bulunamadı. {0}"};

    public static readonly string[] AutoUpdate = {
      "Search for new versions of A>V>C> plugins is enabled.",
      "Включен поиск новых версий плагинов A>V>C>.",
      "La ricerca di nuove versioni dei plugin A>V>C> è abilitata.",
      "Die Suche nach neuen Versionen von A>V>C>-Plugins ist aktiviert.",
      "搜索新版本的 A>V>C> 插件已启用。",
      "La búsqueda de nuevas versiones de complementos A>V>C> está habilitada.",
      "La recherche de nouvelles versions des plug-ins A>V>C> est activée.",
      "A>V>C> eklentilerinin yeni sürümlerini arama etkinleştirildi."};

    public static readonly string[] RunError = {
      "Error starting the update program: {0}",
      "Ошибка при запуске программы обновления: {0}",
      "Errore durante l'avvio del programma di aggiornamento: {0}",
      "Fehler beim Starten des Updaters: {0}",
      "启动更新程序时出错：{0}",
      "Error al iniciar el programa de actualización: {0}",
      "Erreur lors du démarrage du programme de mise à jour: {0}",
      "Güncelleme programını başlatırken hata: {0}"};

    public static readonly string[] PluginInstalledErr = {
      "'{0}' plugin is not installed yet.",
      "Плагин '{0}' еще не установлен.",
      "Il plugin '{0}' non è ancora installato.",
      "Das Plugin '{0}' ist noch nicht installiert.",
      "插件 '{0}' 尚未安装。",
      "El complemento '{0}' aún no está instalado.",
      "Le plug-in '{0}' n'est pas encore installé.",
      "'{0}' eklentisi henüz yüklenmedi."};

    // ====================================== Updater Dialog Box ================================================
    public static readonly string[] UpdaterTip = {
      "Plug-in updates can be downloaded From the server automatically. Or you can choose and install any version.",
      "Обновление плагинов может загружаться с сервера в автоматическом режиме. Или вы можете выбрать и установить любую версию.",
      "Gli aggiornamenti dei plugin possono essere scaricati automaticamente dal server. Oppure puoi scegliere e installare qualsiasi versione.",
      "Plugin-Updates können automatisch vom Server heruntergeladen werden. Oder Sie können eine beliebige Version auswählen und installieren.",
      "插件更新可以自动从服务器下载。 或者您可以选择并安装任何版本。",
      "Las actualizaciones de complementos se pueden descargar del servidor automáticamente. O puede elegir e instalar cualquier versión.",
      "Les mises à jour des plug-ins peuvent être téléchargées automatiquement depuis le serveur. Ou vous pouvez choisir et installer n'importe quelle version.",
      "Eklenti güncellemeleri sunucudan otomatik olarak indirilebilir. Veya herhangi bir sürümü seçip yükleyebilirsiniz."};

    public static readonly string[] Install = {
      "Install",
      "Установить",
      "Installare",
      "Installieren",
      "安装",
      "Instalar",
      "Installer",
      "Yükle"};

    public static readonly string[] Reload = {
      "Versions",
      "Версии",
      "Versioni",
      "Versionen",
      "更新版本列表",
      "Versiones",
      "Versions",
      "Sürümler"};

    public static readonly string[] ReloadTip = {
      "Download the version list From the server again",
      "Загрузить список версий с сервера заново",
      "Scarica nuovamente l'elenco delle versioni dal server",
      "Laden Sie die Versionsliste erneut vom Server herunter.",
      "再次从服务器下载版本列表",
      "Descargar la lista de versiones del servidor nuevamente",
      "Télécharger à nouveau la liste des versions depuis le serveur",
      "Sürüm listesini sunucudan tekrar indir"};

    public static readonly string[] Beta = {
      "Automatically install pre-release(Beta) versions",
      "Автоматически устанавливать предварительные отладочные (Бета) версии",
      "Installa automaticamente le versioni pre-release (Beta).",
      "Vorabversionen (Beta) automatisch installieren.",
      "自动安装测试（Beta）版本",
      "Instalar automáticamente versiones preliminares (Beta)",
      "Installer automatiquement les versions préliminaires (Beta)",
      "Ön sürümleri (Beta) otomatik olarak yükle"};

    public static readonly string[] Downloaded = {
      "Downloaded version",
      "Скачена версия ",
      "Versione scaricata",
      "Heruntergeladene Version",
      "下载版本",
      "Versión descargada",
      "Version téléchargée",
      "İndirilen sürüm"};

    public static readonly string[] Last = {
      "Last version",
      "Последняя версия",
      "Ultima versione",
      "Letzte Version",
      "最新版本",
      "Última versión",
      "Dernière version",
      "Son sürüm"};

    public static readonly string[] UpdaterVersion = {
      "Updater version",
      "Версия Updater",
      "Versione 'Updater'",
      "Updater-Version",
      "更新程序版本",
      "Versión del actualizador",
      "Version de mise à jour",
      "Güncelleyici sürümü"};

    public static readonly string[] PluginVersion = {
      "Plugin version",
      "Версия плагина",
      "Versione del plugin",
      "Plugin-Version",
      "插件版本",
      "Versión del complemento",
      "Version du plug-in",
      "Eklenti sürümü"};

    public static readonly string[] Mode = {
      "Auto-Update Mode",
      "Режим обновлений",
      "Modalità di aggiornamento",
      "Aktualisierungsmodus",
      "更新模式",
      "Modo de actualización automática",
      "Mode de mise à jour automatique",
      "Otomatik güncelleme modu"};

    public static readonly string[] Paid = {
      "You are not licensed for this update.",
      "У вас нет лицензии на это обновление.",
      "Non hai una licenza per questo aggiornamento.",
      "Sie haben keine Lizenz für dieses Update.",
      "您没有此更新的许可证。",
      "No tiene licencia para esta actualización.",
      "Vous n'avez pas de licence pour cette mise à jour.",
      "Bu güncelleme için lisansınız yok."};

    public static readonly string[] Update = {
      "Update",
      "Обновить",
      "Ricaricare",
      "Aktualisierung",
      "刷新",
      "Actualizar",
      "Mettre à jour",
      "Güncelle"};

    public static readonly string[] Attempt = {
      "Attempt",
      "Рискнуть",
      "Tentare",
      "Versuchen",
      "尝试",
      "Intentar",
      "Essayer",
      "Dene"};

    public static readonly string[] Reinstall = {
      "Reinstall",
      "Переустановить",
      "Reinstalla",
      "Neu installieren",
      "重新安装",
      "Reinstalar",
      "Réinstaller",
      "Yeniden yükle"};

    public static readonly string[] Rollback = {
      "Roll back",
      "Откатить",
      "Torna indietro",
      "Rollback",
      "回滚",
      "Revertir",
      "Annuler",
      "Geri al"};

    public static readonly string[] OptionsTab = {
      "Update settings",
      "Настройки обновлений",
      "Aggiorna impostazioni",
      "Update Einstellungen",
      "更新设置",
      "Configuración de actualizaciones",
      "Paramètres de mise à jour",
      "Güncelleme ayarları"};

    public static readonly string[] LogTab = {
      "Message Log",
      "Журнал сообщений",
      "Registro messaggi",
      "Nachrichtenprotokoll",
      "消息日志",
      "Registro de mensajes",
      "Journal des messages",
      "Mesaj günlüğü"};

    public static readonly string[] LoadingPercent = {
      "Loading data... Completed {0}%",
      "Загрузка данных... Выполнено {0}%",
      "Caricamento dati in corso... {0}% completato",
      "Daten werden geladen... {0}% abgeschlossen",
      "正在加载数据... {0}% 已完成",
      "Cargando datos... {0}% completado",
      "Chargement des données... {0}% terminé",
      "Veriler yükleniyor... %{0} tamamlandı"};

    public static readonly string[] SecondTry = {
      "An error occurred while reading data From the server. Second try...",
      "Ошибка при считывании данных с сервера. Вторая попытка...",
      "Si è verificato un errore durante la lettura dei dati dal server. Secondo tentativo...",
      "Beim Lesen von Daten vom Server ist ein Fehler aufgetreten. Zweiter Versuch...",
      "从服务器读取数据时出错。请切换网络供应商。第二次尝试...",
      "Se produjo un error al leer datos del servidor. Segundo intento...",
      "Une erreur s'est produite lors de la lecture des données du serveur. Deuxième tentative...",
      "Sunucudan veri okunurken hata oluştu. İkinci deneme..."};

    public static readonly string[] ThirdTry = {
      "An error occurred while reading data From the server. Third try...",
      "Ошибка при считывании данных с сервера. Третья  попытка...",
      "Si è verificato un errore durante la lettura dei dati dal server. Terzo tentativo...",
      "Beim Lesen von Daten vom Server ist ein Fehler aufgetreten. Dritter Versuch...",
      "从服务器读取数据时出错。请切换网络供应商。第三次尝试...",
      "Se produjo un error al leer datos del servidor. Tercer intento...",
      "Une erreur s'est produite lors de la lecture des données du serveur. Troisième tentative...",
      "Sunucudan veri okunurken hata oluştu. Üçüncü deneme..."};

    public static readonly string[] ArchiveWriting = {
      "Write archive to file {0}...",
      "Запись архива в файл {0}...",
      "Scrivi archivio su file {0}...",
      "Archiv in Datei {0} schreiben...",
      "将存档写入文件 {0}...",
      "Escribir archivo en {0}...",
      "Écrire l'archive dans le fichier {0}...",
      "Arşiv dosyaya yazılıyor {0}..."};

    public static readonly string[] TimerTick = {
      "Timer check for updates...",
      "Проверка обновлений по таймеру...",
      "Controllo aggiornamenti tramite timer...",
      "Timer-Überprüfung auf Updates...",
      "定时检查更新...",
      "Comprobación de actualizaciones por temporizador...",
      "Vérification des mises à jour par minuterie...",
      "Zamanlayıcı güncelleme kontrolü..."};

    public static readonly string[] AutoUpdatesOff = {
      "Automatic update check is disabled.",
      "Автоматическая проверка обновлений отключена.",
      "Il controllo automatico degli aggiornamenti è disabilitato.",
      "Die automatische Update-Prüfung ist deaktiviert.",
      "自动更新检查已禁用。",
      "La comprobación automática de actualizaciones está deshabilitada.",
      "La vérification automatique des mises à jour est désactivée.",
      "Otomatik güncelleme kontrolü devre dışı."};
  }
}