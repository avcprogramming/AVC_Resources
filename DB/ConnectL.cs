// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  /// <summary>
  /// Локализация процесса подключения к БД AVC
  /// </summary>
  public static class
  ConnectL
  {
    public static readonly string[] SelectServer = {
      "Checking connection with the A>V>C> server. Attempt {0} ...",
      "Проверка связи с сервером A>V>C>. Попытка {0} ...",
      "Verifica connessione con il server A>V>C>. Tentativo {0} ...",
      "Überprüfen der Verbindung zum Server A>V>C>. Versuch {0} ...",
      "正在检查与 A>V>C> 服务器的连接. 尝试{0} ..." };
    public static readonly string[] StartConnection = {
      "Trying to connect to the A>V>C> database.",
      "Пытаемся соединится с базой данных A>V>C>.",
      "Tentativo di connessione al database A>V>C>.",
      "Versuch, eine Verbindung zur Datenbank A>V>C> herzustellen.",
      "正在尝试连接到 A>V>C> 数据库."};
    public static readonly string[] Connected = {
      "A>V>C> Database connection to server {1} established. {0:0.##}s",
      "Установлено соединение с базой данных A>V>C> на сервере {1} за {0:0.##}c",
      "Una connessione al database A>V>C> sul server {1} è stata stabilita in {0:0.##}s.",
      "Eine Verbindung zur A>V>C>-Datenbank auf Server {1} wurde in {0:0.##}S hergestellt.",
      "与服务器 {1} 上的 A>V>C>  数据库的连接在 {0:0.##} 秒内建立。" };
    public static readonly string[] NotConnected = {
      "A>V>C> Database connection has not been established.",
      "Не установлено соединение с базой данных A>V>C>.",
      "La connessione al database A>V>C> non è stata stabilita.",
      "Die Verbindung zur A>V>C>-Datenbank wurde nicht hergestellt.",
      "A>V>C> 数据库连接尚未建立。" };
    public static readonly string[] LoadPrice = {
      "Loading price list...",
      "Загрузка прайс-листа...",
      "Scarica listino prezzi...",
      "Preisliste herunterladen...",
      "正在加载价目表..." };
    public static readonly string[] LoadVersionLog = {
      "Loading version list...",
      "Загрузка списка версий...",
      "Caricamento dell'elenco delle versioni...",
      "Versionsliste wird geladen...",
      "正在加载版本列表..." };
    public static readonly string[] LoadLicenses = {
      "Download the list of licenses and activations...",
      "Загрузка списка лицензий и активаций...",
      "Scarica l'elenco delle licenze e attivazioni...",
      "Laden Sie die Liste der Lizenzen und Aktivierungen herunter...",
      "下载许可证和激活列表..." };
    public static readonly string[] LoadClientData = {
      "Loading user data {0}...",
      "Загрузка данных о пользователе {0}...",
      "Caricamento dei dati utente {0}...",
      "Benutzerdaten laden {0}...",
      "正在加载用户数据 {0}..." };
    public static readonly string[] NotConnectedTip = {
      "There is no access to the A>V>C> server.\r\n" +
        "Without connection to the server, A>V>C> programs will soon be blocked.",
      "Нет доступа к серверу A>V>C>.\r\n" +
        "Без подключения к серверу программы A>V>C> скоро заблокируются.",
      "Non c'è accesso al server A>V>C>.\r\n" +
        "Senza connessione al server, i programmi A>V>C> saranno presto bloccati.",
      "Es besteht kein Zugriff auf den Server A>V>C>.\r\n" +
        "Ohne Verbindung zum Server werden die Programme A>V>C> bald blockiert.",
      "无法访问 A>V>C> 服务器。\r\n" +
        "如果没有连接到服务器，A>V>C> 程序很快就会被阻止。" };
    public static readonly string[] OnlineMode = {
      "Online Mode",
      "Режим Онлайн",
      "Modalità online",
      "Onlinemodus",
      "在线模式" };
    public static readonly string[] OfflineMode = {
      "The program works offline. Access to A>V>C> database is denied.",
      "Программа работает в оффлайн режиме. Нет доступа к базе данных A>V>C>",
      "Il programma funziona offline. L'accesso al database A>V>C> è negato.",
      "Das Programm arbeitet offline. Der Zugriff auf die A>V>C>-Datenbank wird verweigert.",
      "该程序离线工作。 拒绝访问 A>V>C> 数据库。" };
    public static readonly string[] NoAvc = {
      "\r\nPerhaps technical work is underway on the server or access is closed by your administrator.",
      "\r\nВозможно ведутся технические работы на сервере или доступ закрыт вашим администратором.",
      "\r\nForse sono in corso lavori tecnici sul server o l'accesso è stato chiuso dall'amministratore.",
      "\r\nMöglicherweise sind technische Arbeiten am Server im Gange oder der " +
        "Zugriff wird von Ihrem Administrator geschlossen.",
      "r\n可能服务器上正在进行技术工作，或者您的管理员已关闭访问权限。"};
    public static readonly string[] NoInternet = {
      "\r\nIt looks like the computer is not connected to the Internet or access is closed by your administrator.",
      "\r\nПохоже компьютер не подключен к интернет или доступ закрыт вашим администратором.",
      "\r\nSembra che il computer non sia connesso a Internet o che l'accesso sia stato chiuso dall'amministratore.",
      "\r\nEs sieht so aus, als ob der Computer nicht mit dem Internet verbunden ist oder " +
        "der Zugriff von Ihrem Administrator geschlossen wird.",
      "\r\n计算机似乎未连接到英特网(Internet)，或者您的管理员已关闭访问权限。"};
    public static readonly string[] NoSQL = {
      "\r\nCheck your internet connection. Disable your firewall. Check the system time. Reload the program.",
      "\r\nПроверьте подключение к интернет. Отключите ваш файервол. Проверьте системное время. Перегрузите программу.",
      "\r\nControlla la tua connessione Internet. Disabilita il firewall. Controlla l'ora di sistema. Ricarica il programma.",
      "\r\nPrüfe deine Internetverbindung. Deaktivieren Sie Ihre Firewall. Überprüfen Sie die Systemzeit. Laden Sie das Programm neu.",
      "\r\n检查您的互联网连接。 禁用防火墙。 检查系统时间。 重新加载程序。" };
    public static readonly string[] NewClient = {
      "User {0} is not registered in the database A>V>C>.\r\nDo you want to register a new user?",
      "Пользователь {0} не зарегистрирован в базе данных A>V>C>.\r\nЗарегистрировать нового пользователя?",
      "L'utente {0} non è registrato nel database A>V>C>.\r\nVuoi registrare un nuovo utente?",
      "Benutzer {0} ist nicht in der Datenbank A>V>C> registriert.\r\nMöchten Sie einen neuen Benutzer registrieren?",
      "用户 {0} 未在数据库 A>VC> 中注册。\r\n您要注册新用户吗？" };
    public static readonly string[] NewClientRegistered = {
      "User {0} is registered in the A>V>C> database.",
      "Пользователь {0} зарегистрирован в базе данных A>V>C>.",
      "L'utente {0} è registrato nel database A>V>C>.",
      "Benutzer {0} ist in der Datenbank A>V>C> registriert.",
      "用户 {0} 在 A>V>C> 数据库中注册。" };
    public static readonly string[] ClientUpdated = {
      "Updated user data {0}.",
      "Обновлены данные пользователя {0}.",
      "Dati utente aggiornati {0}",
      "Aktualisierte Benutzerdaten {0}.",
      "更新了用户数据 {0}。" };
    public static readonly string[] ActivationError = {
      "Error in the activation process",
      "Ошибка в процессе активации",
      "Errore nel processo di attivazione",
      "Fehler im Aktivierungsprozess",
      "激活过程出错" };
    public static readonly string[] ClientUpdateError = {
      "Error while updating user data",
      "Ошибка в процессе обновления данных пользователя",
      "Errore durante l'aggiornamento dei dati utente",
      "Fehler beim Aktualisieren der Benutzerdaten",
      "更新用户数据时出错" };
    public static readonly string[] TooManyClients = {
      "There are suspiciously many users for one workplace.",
      "Подозрительно много пользователей для одного рабочего места.",
      "Ci sono molti utenti sospettosamente per un posto di lavoro.",
      "Es gibt verdächtig viele Benutzer für einen Arbeitsplatz.",
      "一个工作场所有很多用户。" };
    public static readonly string[] ReadOnlyServer = {
      "The plugin is connected to a backup server. Recording to the server is blocked. " +
        "Update the plugin and try again later.",
      "Плагин подключен к резервному серверу. Запись на сервер заблокирована. " +
        "Обновите плагин и попробуйте позже.",
      "Il plugin è connesso a un server di backup. La registrazione sul server è bloccata. " +
        "Aggiorna il plugin e riprova più tardi.",
      "Das Plugin ist mit einem Backup-Server verbunden. Die Aufzeichnung auf dem Server ist blockiert. " +
        "Aktualisieren Sie das Plugin und versuchen Sie es später erneut.",
      "该插件连接到备份服务器。 记录到服务器被阻止。 更新插件，稍后再试。"    };
    public static readonly string[] ShortPassword = {
      "Too short password",
      "Слишком короткий пароль",
      "Password troppo corta",
      "Zu kurzes Passwort",
      "密码太短" };
    public static readonly string[] OldPasswordErr = {
      "Old password error",
      "Ошибка в старом пароле",
      "Vecchia password errore",
      "Alter Passwortfehler",
      "旧密码错误" };
    public static readonly string[] PasswordCheckErr = {
      "No, the password is not correct.",
      "Нет. Пароль не верный.",
      "No, la password non è corretta.",
      "Nein, das Passwort ist nicht korrekt.",
      "不，密码不正确。" };
    public static readonly string[] PasswordResetInfo = {
      "If you forgot your password, write a password reset request from your mail {0}",
      "Если вы забыли пароль, напишите запрос на сброс пароля с вашей почты {0}",
      "Se hai dimenticato la password, scrivi una richiesta di reimpostazione della password dalla tua posta {0}",
      "Wenn Sie Ihr Passwort vergessen haben, schreiben Sie eine Anfrage zum Zurücksetzen des Passworts " +
        "aus Ihrer Mail {0}",
      "如果您忘记了密码，请从您的邮件 {0} 中写一封密码重置请求"};
    public static readonly string[] PasswordEntryCanceled = {
      "Password entry has been cancelled. " +
        "To connect to the AVC server, you must restart your CAD and enter your password.",
      "Ввод пароля был отменен. " +
        "Для подключения к серверу A>V>C> надо перезагрузить CAD и ввести ваш пароль.",
      "L'immissione della password è stata annullata. " +
        "Per connettersi al server AVC, è necessario riavviare il CAD e inserire la password.",
      "Die Passworteingabe wurde abgebrochen. " +
        "Um sich mit dem AVC-Server zu verbinden, müssen Sie Ihr CAD neu starten und Ihr Passwort eingeben.",
      "密码输入已被取消。 要连接到 AVC 服务器，您必须重新启动 CAD 并输入密码。"};
    public static readonly string[] SwitchToOffline = {
      "The program has been taken offline. Many functions will be blocked. " +
        "Online mode will be enabled automatically as soon as possible.",
      "Программа переведена в автономный режим. Многие функции будут заблокированы. " +
        "Online-режим будет включен автоматически при первой возможности.",
      "Il programma è stato messo offline. Molte funzioni verranno bloccate. " +
        "La modalità online verrà abilitata automaticamente il prima possibile.",
      "Das Programm wurde offline geschaltet. Viele Funktionen werden blockiert. " +
        "Der Online-Modus wird so schnell wie möglich automatisch aktiviert.",
      "该程序已下线。 许多功能将被阻止。 " +
         "在线模式将尽快自动启用。" };

  }
}
