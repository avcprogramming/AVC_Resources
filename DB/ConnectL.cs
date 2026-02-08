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
      "正在检查与 A>V>C> 服务器的连接. 尝试{0} ...",
      "Comprobando conexión con el servidor A>V>C>. Intento {0} ...",
      "Vérification de la connexion avec le serveur A>V>C>. Tentative {0} ...",
      "A>V>C> sunucusuyla bağlantı kontrol ediliyor. Deneme {0} ..."};

    public static readonly string[] StartConnection = {
      "Trying to connect to the A>V>C> database.",
      "Пытаемся соединится с базой данных A>V>C>.",
      "Tentativo di connessione al database A>V>C>.",
      "Versuch, eine Verbindung zur Datenbank A>V>C> herzustellen.",
      "正在尝试连接到 A>V>C> 数据库.",
      "Intentando conectar con la base de datos A>V>C>.",
      "Tentative de connexion à la base de données A>V>C>.",
      "A>V>C> veritabanına bağlanmaya çalışılıyor."};

    public static readonly string[] Connected = {
      "✅ A>V>C> Database connection to server {1} established. {0:0.##}s",
      "✅ Установлено соединение с базой данных A>V>C> на сервере {1} за {0:0.##}c",
      "✅ Una connessione al database A>V>C> sul server {1} è stata stabilita in {0:0.##}s.",
      "✅ Eine Verbindung zur A>V>C>-Datenbank auf Server {1} wurde in {0:0.##}S hergestellt.",
      "✅ 与服务器 {1} 上的 A>V>C>  数据库的连接在 {0:0.##} 秒内建立。",
      "✅ Conexión a la base de datos A>V>C> en el servidor {1} establecida en {0:0.##}s.",
      "✅ Connexion à la base de données A>V>C> sur le serveur {1} établie en {0:0.##}s.",
      "✅ Sunucu {1} üzerinde A>V>C> veritabanı bağlantısı {0:0.##}s içinde kuruldu."};

    public static readonly string[] NotConnected = {
      "❌ A>V>C> Database connection has not been established.",
      "❌ Не установлено соединение с базой данных A>V>C>.",
      "❌ La connessione al database A>V>C> non è stata stabilita.",
      "❌ Die Verbindung zur A>V>C>-Datenbank wurde nicht hergestellt.",
      "❌ A>V>C> 数据库连接尚未建立。",
      "❌ No se ha establecido conexión con la base de datos A>V>C>.",
      "❌ La connexion à la base de données A>V>C> n'a pas été établie.",
      "❌ A>V>C> veritabanı bağlantısı kurulmadı."};

    public static readonly string[] ConnectionError = {
      "❌ Connection error. {0}",
      "❌ Ошибка соединения. {0}",
      "❌ Errore di connessione. {0}",
      "❌ Verbindungsfehler. {0}",
      "❌ 连接错误。{0}",
      "❌ Error de conexión. {0}",
      "❌ Erreur de connexion. {0}",
      "❌ Bağlantı hatası. {0}"};

    public static readonly string[] LoadPrice = {
      "Loading price list...",
      "Загрузка прайс-листа...",
      "Scarica listino prezzi...",
      "Preisliste herunterladen...",
      "正在加载价目表...",
      "Cargando lista de precios...",
      "Chargement de la liste de prix...",
      "Fiyat listesi yükleniyor..."};

    public static readonly string[] LoadOptions = {
      "Loading options...",
      "Загрузка настроек...",
      "Caricamento delle impostazioni...",
      "Einstellungen werden geladen...",
      "正在加载设置...",
      "Cargando opciones...",
      "Chargement des options...",
      "Seçenekler yükleniyor..."};

    public static readonly string[] LoadVersionLog = {
      "Loading version list...",
      "Загрузка списка версий...",
      "Caricamento dell'elenco delle versioni...",
      "Versionsliste wird geladen...",
      "正在加载版本列表...",
      "Cargando lista de versiones...",
      "Chargement de la liste des versions...",
      "Sürüm listesi yükleniyor..."};

    public static readonly string[] LoadLicenses = {
      "Download the list of licenses and activations...",
      "Загрузка списка лицензий и активаций...",
      "Scarica l'elenco delle licenze e attivazioni...",
      "Laden Sie die Liste der Lizenzen und Aktivierungen herunter...",
      "下载许可证和激活列表...",
      "Descargando lista de licencias y activaciones...",
      "Téléchargement de la liste des licences et activations...",
      "Lisans ve etkinleştirme listesi indiriliyor..."};

    public static readonly string[] LoadClientData = {
      "Loading user data {0}...",
      "Загрузка данных о пользователе {0}...",
      "Caricamento dei dati utente {0}...",
      "Benutzerdaten laden {0}...",
      "正在加载用户数据 {0}...",
      "Cargando datos de usuario {0}...",
      "Chargement des données utilisateur {0}...",
      "Kullanıcı verileri yükleniyor {0}..."};

    public static readonly string[] NoAccessToServerTip = {
      "❌ There is no access to the A>V>C> server.",
      "❌ Нет доступа к серверу A>V>C>.",
      "❌ Non c'è accesso al server A>V>C>.",
      "❌ Es besteht kein Zugriff auf den Server A>V>C>.",
      "❌ 无法访问 A>V>C> 服务器。",
      "❌ No hay acceso al servidor A>V>C>.",
      "❌ Il n'y a pas d'accès au serveur A>V>C>.",
      "❌ A>V>C> sunucusuna erişim yok."};

    public static readonly string[] NoAccessSoonBlockedTip = {
      "There is no access to the A>V>C> server.\r\n" +
        "Without connection to the server, A>V>C> programs will soon be blocked.",
      "Нет доступа к серверу A>V>C>.\r\n" +
        "Без подключения к серверу программы A>V>C> скоро заблокируются.",
      "Non c'è accesso al server A>V>C>.\r\n" +
        "Senza connessione al server, i programmi A>V>C> saranno presto bloccati.",
      "Es besteht kein Zugriff auf den Server A>V>C>.\r\n" +
        "Ohne Verbindung zum Server werden die Programme A>V>C> bald blockiert.",
      "无法访问 A>V>C> 服务器。\r\n" +
        "如果没有连接到服务器，A>V>C> 程序很快就会被阻止。",
      "No hay acceso al servidor A>V>C>.\r\n" +
        "Sin conexión al servidor, los programas A>V>C> pronto serán bloqueados.",
      "Il n'y a pas d'accès au serveur A>V>C>.\r\n" +
        "Sans connexion au serveur, les programmes A>V>C> seront bientôt bloqués.",
      "A>V>C> sunucusuna erişim yok.\r\n" +
        "Sunucuya bağlantı olmadan A>V>C> programları yakında engellenecek."};

    public static readonly string[] NoAccessNoActivateTip = {
      "There is no access to the A>V>C> server.\r\n" +
        "Without connection to the server it is impossible to activate A>V>C> programs.",
      "Нет доступа к серверу A>V>C>.\r\n" +
        "Без связи с сервером невозможно активировать программы A>V>C>.",
      "Non c'è accesso al server A>V>C>.\r\n" +
        "Senza connessione al server non è possibile attivare i programmi A>V>C>.",
      "Es besteht kein Zugriff auf den Server A>V>C>.\r\n" +
        "Ohne Verbindung zum Server ist es nicht möglich, A>V>C>-Programme zu aktivieren.",
      "无法访问 A>V>C> 服务器。\r\n" +
        "如果没有连接到服务器，就无法激活 A>V>C> 程序。",
      "No hay acceso al servidor A>V>C>.\r\n" +
        "Sin conexión al servidor es imposible activar programas A>V>C>.",
      "Il n'y a pas d'accès au serveur A>V>C>.\r\n" +
        "Sans connexion au serveur, il est impossible d'activer les programmes A>V>C>.",
      "A>V>C> sunucusuna erişim yok.\r\n" +
        "Sunucuya bağlantı olmadan A>V>C> programlarını etkinleştirmek imkansız."};

    public static readonly string[] OnlineMode = {
      "Online Mode",
      "Режим Онлайн",
      "Modalità online",
      "Onlinemodus",
      "在线模式",
      "Modo en línea",
      "Mode en ligne",
      "Çevrimiçi Mod"};

    public static readonly string[] OfflineMode = {
      "The program works offline. Access to A>V>C> database is denied.",
      "Программа работает в оффлайн режиме. Нет доступа к базе данных A>V>C>",
      "Il programma funziona offline. L'accesso al database A>V>C> è negato.",
      "Das Programm arbeitet offline. Der Zugriff auf die A>V>C>-Datenbank wird verweigert.",
      "该程序离线工作。 拒绝访问 A>V>C> 数据库。",
      "El programa funciona sin conexión. Acceso a base de datos A>V>C> denegado.",
      "Le programme fonctionne hors ligne. Accès à la base de données A>V>C> refusé.",
      "Program çevrimdışı çalışıyor. A>V>C> veritabanına erişim reddedildi."};

    public static readonly string[] NoAvc = {
      "\r\nPerhaps technical work is underway on the server or access is closed by your administrator.",
      "\r\nВозможно ведутся технические работы на сервере или доступ закрыт вашим администратором.",
      "\r\nForse sono in corso lavori tecnici sul server o l'accesso è stato chiuso dall'amministratore.",
      "\r\nMöglicherweise sind technische Arbeiten am Server im Gange oder der " +
        "Zugriff wird von Ihrem Administrator geschlossen.",
      "\r\n可能服务器上正在进行技术工作，或者您的管理员已关闭访问权限。",
      "\r\nQuizás hay trabajos técnicos en curso en el servidor o el acceso fue cerrado por su administrador.",
      "\r\nPeut-être que des travaux techniques sont en cours sur le serveur ou l'accès est fermé par votre administrateur.",
      "\r\nBelki sunucuda teknik çalışma devam ediyor veya yöneticiniz tarafından erişim kapatılmış."};

    public static readonly string[] NoInternet = {
      "\r\nIt looks like the computer is not connected to the Internet or access is closed by your administrator.",
      "\r\nПохоже компьютер не подключен к интернет или доступ закрыт вашим администратором.",
      "\r\nSembra che il computer non sia connesso a Internet o che l'accesso sia stato chiuso dall'amministratore.",
      "\r\nEs sieht so aus, als ob der Computer nicht mit dem Internet verbunden ist oder " +
        "der Zugriff von Ihrem Administrator geschlossen wird.",
      "\r\n计算机似乎未连接到英特网(Internet)，或者您的管理员已关闭访问权限。",
      "\r\nParece que el ordenador no está conectado a Internet o el acceso está cerrado por su administrador.",
      "\r\nIl semble que l'ordinateur n'est pas connecté à Internet ou que l'accès est fermé par votre administrateur.",
      "\r\nBilgisayar internete bağlı değil gibi görünüyor veya yöneticiniz tarafından erişim kapatılmış."};

    public static readonly string[] NoSQL = {
      "\r\nCheck your internet connection. Disable your firewall. Check the system time. Reload the program.",
      "\r\nПроверьте подключение к интернет. Отключите ваш файервол. Проверьте системное время. Перегрузите программу.",
      "\r\nControlla la tua connessione Internet. Disabilita il firewall. Controlla l'ora di sistema. Ricarica il programma.",
      "\r\nPrüfe deine Internetverbindung. Deaktivieren Sie Ihre Firewall. Überprüfen Sie die Systemzeit. Laden Sie das Programm neu.",
      "\r\n检查您的互联网连接。 禁用防火墙。 检查系统时间。 重新加载程序。",
      "\r\nVerifique su conexión a Internet. Desactive su cortafuegos. Verifique la hora del sistema. Recargue el programa.",
      "\r\nVérifiez votre connexion Internet. Désactivez votre pare-feu. Vérifiez l'heure système. Rechargez le programme.",
      "\r\nİnternet bağlantınızı kontrol edin. Güvenlik duvarınızı devre dışı bırakın. Sistem saatini kontrol edin. Programı yeniden yükleyin."};

    public static readonly string[] NewClient = {
      "User {0} is not registered in the database A>V>C>.\r\nDo you want to register a new user?",
      "Пользователь {0} не зарегистрирован в базе данных A>V>C>.\r\nЗарегистрировать нового пользователя?",
      "L'utente {0} non è registrato nel database A>V>C>.\r\nVuoi registrare un nuovo utente?",
      "Benutzer {0} ist nicht in der Datenbank A>V>C> registriert.\r\nMöchten Sie einen neuen Benutzer registrieren?",
      "用户 {0} 未在数据库 A>VC> 中注册。\r\n您要注册新用户吗？",
      "El usuario {0} no está registrado en la base de datos A>V>C>.\r\n¿Desea registrar un nuevo usuario?",
      "L'utilisateur {0} n'est pas enregistré dans la base de données A>V>C>.\r\nVoulez-vous enregistrer un nouvel utilisateur?",
      "Kullanıcı {0} A>V>C> veritabanında kayıtlı değil.\r\nYeni bir kullanıcı kaydetmek ister misiniz?"};

    public static readonly string[] NewClientRegistered = {
      "User {0} is registered in the A>V>C> database.",
      "Пользователь {0} зарегистрирован в базе данных A>V>C>.",
      "L'utente {0} è registrato nel database A>V>C>.",
      "Benutzer {0} ist in der Datenbank A>V>C> registriert.",
      "用户 {0} 在 A>V>C> 数据库中注册。",
      "El usuario {0} está registrado en la base de datos A>V>C>.",
      "L'utilisateur {0} est enregistré dans la base de données A>V>C>.",
      "Kullanıcı {0} A>V>C> veritabanında kayıtlı."};

    public static readonly string[] ClientUpdated = {
      "✅ Updated user data {0}.",
      "✅ Обновлены данные пользователя {0}.",
      "✅ Dati utente aggiornati {0}",
      "✅ Aktualisierte Benutzerdaten {0}.",
      "✅ 更新了用户数据 {0}。",
      "✅ Datos de usuario actualizados {0}.",
      "✅ Données utilisateur mises à jour {0}.",
      "✅ Kullanıcı verileri güncellendi {0}."};

    public static readonly string[] ActivationError = {
      "Error in the activation process",
      "Ошибка в процессе активации",
      "Errore nel processo di attivazione",
      "Fehler im Aktivierungsprozess",
      "激活过程出错",
      "Error en el proceso de activación",
      "Erreur dans le processus d'activation",
      "Etkinleştirme sürecinde hata"};

    public static readonly string[] ClientUpdateError = {
      "Error while updating user data",
      "Ошибка в процессе обновления данных пользователя",
      "Errore durante l'aggiornamento dei dati utente",
      "Fehler beim Aktualisieren der Benutzerdaten",
      "更新用户数据时出错",
      "Error al actualizar datos de usuario",
      "Erreur lors de la mise à jour des données utilisateur",
      "Kullanıcı verileri güncellenirken hata"};

    public static readonly string[] TooManyClients = {
      "There are suspiciously many users for one workplace.",
      "Подозрительно много пользователей для одного рабочего места.",
      "Ci sono molti utenti sospettosamente per un posto di lavoro.",
      "Es gibt verdächtig viele Benutzer für einen Arbeitsplatz.",
      "一个工作场所有很多用户。",
      "Hay sospechosamente muchos usuarios para un lugar de trabajo.",
      "Il y a étrangement beaucoup d'utilisateurs pour un poste de travail.",
      "Bir işyeri için şüpheli derecede çok kullanıcı var."};

    public static readonly string[] ReadOnlyServer = {
      "The plugin is connected to a backup server. Recording to the server is blocked. " +
        "Update the plugin and try again later.",
      "Плагин подключен к резервному серверу. Запись на сервер заблокирована. " +
        "Обновите плагин и попробуйте позже.",
      "Il plugin è connesso a un server di backup. La registrazione sul server è bloccata. " +
        "Aggiorna il plugin e riprova più tardi.",
      "Das Plugin ist mit einem Backup-Server verbunden. Die Aufzeichnung auf dem Server ist blockiert. " +
        "Aktualisieren Sie das Plugin und versuchen Sie es später erneut.",
      "该插件连接到备份服务器。 记录到服务器被阻止。 更新插件，稍后再试。",
      "El complemento está conectado a un servidor de respaldo. La grabación en el servidor está bloqueada. " +
        "Actualice el complemento e inténtelo de nuevo más tarde.",
      "Le plug-in est connecté à un serveur de sauvegarde. L'enregistrement sur le serveur est bloqué. " +
        "Mettez à jour le plug-in et réessayez plus tard.",
      "Eklenti yedek sunucuya bağlı. Sunucuya kayıt engellenmiş. " +
        "Eklentiyi güncelleyin ve daha sonra tekrar deneyin."};

    public static readonly string[] ShortPassword = {
      "Too short password",
      "Слишком короткий пароль",
      "Password troppo corta",
      "Zu kurzes Passwort",
      "密码太短",
      "Contraseña demasiado corta",
      "Mot de passe trop court",
      "Çok kısa şifre"};

    public static readonly string[] OldPasswordErr = {
      "Old password error",
      "Ошибка в старом пароле",
      "Vecchia password errore",
      "Alter Passwortfehler",
      "旧密码错误",
      "Error de contraseña antigua",
      "Erreur ancien mot de passe",
      "Eski şifre hatası"};

    public static readonly string[] PasswordCheckErr = {
      "No, the password is not correct.",
      "Нет. Пароль не верный.",
      "No, la password non è corretta.",
      "Nein, das Passwort ist nicht korrekt.",
      "不，密码不正确。",
      "No, la contraseña no es correcta.",
      "Non, le mot de passe n'est pas correct.",
      "Hayır, şifre doğru değil."};

    public static readonly string[] PasswordResetInfo = {
      "If you forgot your password, write a password reset request From your mail {0}",
      "Если вы забыли пароль, напишите запрос на сброс пароля с вашей почты {0}",
      "Se hai dimenticato la password, scrivi una richiesta di reimpostazione della password dalla tua posta {0}",
      "Wenn Sie Ihr Passwort vergessen haben, schreiben Sie eine Anfrage zum Zurücksetzen des Passworts " +
        "aus Ihrer Mail {0}",
      "如果您忘记了密码，请从您的邮件 {0} 中写一封密码重置请求",
      "Si olvidó su contraseña, escriba una solicitud de restablecimiento de contraseña desde su correo {0}",
      "Si vous avez oublié votre mot de passe, écrivez une demande de réinitialisation du mot de passe " +
        "depuis votre messagerie {0}",
      "Şifrenizi unuttuysanız, {0} postanızdan şifre sıfırlama isteği yazın"};

    public static readonly string[] PasswordEntryCanceled = {
      "Password entry has been cancelled. " +
        "To connect to the AVC server, you must restart your CAD and enter your password.",
      "Ввод пароля был отменен. " +
        "Для подключения к серверу A>V>C> надо перезагрузить CAD и ввести ваш пароль.",
      "L'immissione della password è stata annullata. " +
        "Per connettersi al server AVC, è necessario riavviare il CAD e inserire la password.",
      "Die Passworteingabe wurde abgebrochen. " +
        "Um sich mit dem AVC-Server zu verbinden, müssen Sie Ihr CAD neu starten und Ihr Passwort eingeben.",
      "密码输入已被取消。 要连接到 AVC 服务器，您必须重新启动 CAD 并输入密码。",
      "La entrada de contraseña ha sido cancelada. " +
        "Para conectarse al servidor AVC, debe reiniciar su CAD e ingresar su contraseña.",
      "La saisie du mot de passe a été annulée. " +
        "Pour vous connecter au serveur AVC, vous devez redémarrer votre CAD et entrer votre mot de passe.",
      "Şifre girişi iptal edildi. " +
        "AVC sunucusuna bağlanmak için CAD'inizi yeniden başlatmalı ve şifrenizi girmelisiniz."};

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
         "在线模式将尽快自动启用。",
      "El programa se ha desconectado. Muchas funciones serán bloqueadas. " +
        "El modo en línea se habilitará automáticamente lo antes posible.",
      "Le programme a été mis hors ligne. De nombreuses fonctions seront bloquées. " +
        "Le mode en ligne sera activé automatiquement dès que possible.",
      "Program çevrimdışı alındı. Birçok fonksiyon engellenecek. " +
        "Çevrimiçi mod mümkün olan en kısa sürede otomatik olarak etkinleştirilecek."};

    public static readonly string[] ConnectionLabelTip = {
      "Connection status with the A>V>C> server. \r\n" +
        "Click to reload all data.",
      "Состояние подключения с серверу A>V>C>. \r\n" +
        "Кликни для перезагрузки всех данных.",
      "Stato della connessione con il server A>V>C>. \r\n" +
        "Fare clic per ricaricare tutti i dati.",
      "Verbindungsstatus mit dem A>V>C>-Server.\r\n" +
        "Klicken Sie hier, um alle Daten neu zu laden.",
      "与服务器 A>V>C> 的连接状态。\r\n" +
        " 单击以重新加载所有数据。",
      "Estado de conexión con el servidor A>V>C>. \r\n" +
        "Haga clic para recargar todos los datos.",
      "État de connexion avec le serveur A>V>C>. \r\n" +
        "Cliquez pour recharger toutes les données.",
      "A>V>C> sunucusuyla bağlantı durumu. \r\n" +
        "Tüm verileri yeniden yüklemek için tıklayın."};

  }
}