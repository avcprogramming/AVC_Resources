// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Exe Unlimit Lic

namespace AVC
{
  /// <summary>
  /// Локализация лицензий и активаций
  /// </summary>
  public static class
  LicL
  {

    // =========================== license types ====================================================
    public static readonly string[] LicenseTrial = {
      "Trial",
      "Пробная",
      "Prova",
      "Versuch",
      "试用",
      "Prueba",
      "Essai",
      "Deneme"};

    public static readonly string[] LicenseAnnual = {
      "Annual",
      "На год",
      "Annuale",
      "Jährlich",
      "1年",
      "Anual",
      "Annuel",
      "Yıllık"};

    public static readonly string[] LicenseUnlimit = {
      "Unlimit",
      "Навсегда",
      "Illimitata",
      "Unbegrenzte",
      "永久",
      "Ilimitada",
      "Illimitée",
      "Sınırsız"};

    public static readonly string[] LicenseFree = {
      "Free",
      "Бесплатная",
      "Gratuito",
      "Kostenlos",
      "免费",
      "Gratis",
      "Gratuit",
      "Ücretsiz"};

    public static readonly string[] LicenseMultiuser =    {
      "Multi-user",
      "Многопользовательская",
      "Multi-utente",
      "Mehrbenutzer",
      "多用户",
      "Multiusuario",
      "Multi-utilisateur",
      "Çok kullanıcılı"    };

    public static readonly string[] LicenseMaxPlaces = {
      "Number of work places per license",
      "Количество рабочих мест",
      "Numero di postazioni per licenza",
      "Anzahl der Arbeitsplätze pro Lizenz",
      "每个许可证的工作场所数量",
      "Número de puestos de trabajo por licencia",
      "Nombre de postes de travail par licence",
      "Lisans başına çalışma yeri sayısı" };

    public static readonly string[] LicenseTrialTip = {
      "Free use of the program {0} days. " +
        "You can use this type of license only once and cannot be canceled. " +
        "It cannot be used on another computer. Other users of this computer will not be able to try this program. " +
        "Without a connection to the server, this license is blocked.",
      "Бесплатное использование программы {0} дней. " +
        "Этот тип лицензий можно использовать только 1 раз и нельзя отменить. " +
        "Ее нельзя использовать на другом компьютере. Другие пользователи этого компьютера не смогут попробовать эту программу. " +
        "Без соединения с сервером эта лицензия блокируется.",
      "Utilizzo gratuito del programma {0} giorni. " +
        "Questo tipo di licenza può essere utilizzato una sola volta e non può essere annullato. " +
        "Non può essere utilizzato su un altro computer. " +
        "Gli altri utenti di questo computer non potranno provare questo programma. " +
        "Senza una connessione al server, questa licenza è bloccata.",
      "Kostenlose Nutzung des Programms {0} Tage. " +
        "Diese Art von Lizenz kann nur einmal verwendet und nicht storniert werden. " +
        "Es kann nicht auf einem anderen Computer verwendet werden. " +
        "Andere Benutzer dieses Computers können dieses Programm nicht ausprobieren. " +
        "Ohne Verbindung zum Server ist diese Lizenz gesperrt.",
      "免费使用该程序 {0} 天。 您只能使用一次此类许可证，并且不能取消。 它不能在另一台计算机上使用。 " +
        "此计算机的其他用户将无法尝试此程序。 如果没有与服务器的连接，此许可证将被阻止。",
      "Uso gratuito del programa {0} días. " +
        "Solo puede usar este tipo de licencia una vez y no se puede cancelar. " +
        "No se puede usar en otra computadora. Otros usuarios de esta computadora no podrán probar este programa. " +
        "Sin conexión al servidor, esta licencia está bloqueada.",
      "Utilisation gratuite du programme {0} jours. " +
        "Vous ne pouvez utiliser ce type de licence qu'une seule fois et il ne peut pas être annulé. " +
        "Il ne peut pas être utilisé sur un autre ordinateur. Les autres utilisateurs de cet ordinateur ne pourront pas essayer ce programme. " +
        "Sans connexion au serveur, cette licence est bloquée.",
      "Programın {0} gün ücretsiz kullanımı. " +
        "Bu lisans türünü yalnızca bir kez kullanabilirsiniz ve iptal edilemez. " +
        "Başka bir bilgisayarda kullanılamaz. Bu bilgisayarın diğer kullanıcıları bu programı deneyemeyecektir. " +
        "Sunucuya bağlantı olmadan bu lisans engellenir."};

    public static readonly string[] LicenseAnnualTip = {
      "EUR {0:0}. The use of the program is 1 year From today. " +
        "Any version of the program can be activated. All updates are available. " +
        "Activation can be canceled and transferred to another computer. Activating your home computer is free!",
      "{0:0} EUR. Использование программы 1 год с сегодняшнего дня. " +
        "Можно активировать любую версию программы. Доступны все обновления. " +
        "Активацию можно отменить и перенести на другой компьютер. Активация вашего домашнего компьютера – бесплатно!",
      "{0:0} EUR. L'utilizzo del programma è di 1 anno da oggi. È possibile attivare qualsiasi versione del programma. " +
        "Tutti gli aggiornamenti sono disponibili. L'attivazione può essere annullata e trasferita su un altro computer. " +
        "L'attivazione del computer di casa è gratuita!",
      "{0:0} EUR. Die Nutzung des Programms beträgt 1 Jahr ab heute. " +
        "Jede Version des Programms kann aktiviert werden. Alle Updates sind verfügbar. " +
        "Die Aktivierung kann abgebrochen und auf einen anderen Computer übertragen werden. " +
        "Die Aktivierung Ihres Heimcomputers ist kostenlos!",
      "EUR {0:0}。 该程序的使用期限为从今天起 1 年。 可以激活任何版本的程序。 " +
        "所有更新都可用。 可以取消激活并将其转移到另一台计算机。 激活您的家用电脑是免费的！",
      "EUR {0:0}. El uso del programa es de 1 año desde hoy. " +
        "Se puede activar cualquier versión del programa. Todas las actualizaciones están disponibles. " +
        "La activación se puede cancelar y transferir a otra computadora. ¡Activar tu computadora doméstica es gratis!",
      "EUR {0:0}. L'utilisation du programme est de 1 an à partir d'aujourd'hui. " +
        "N'importe quelle version du programme peut être activée. Toutes les mises à jour sont disponibles. " +
        "L'activation peut être annulée et transférée sur un autre ordinateur. L'activation de votre ordinateur personnel est gratuite!",
      "EUR {0:0}. Programın kullanımı bugünden itibaren 1 yıldır. " +
        "Programın herhangi bir sürümü etkinleştirilebilir. Tüm güncellemeler mevcuttur. " +
        "Etkinleştirme iptal edilebilir ve başka bir bilgisayara aktarılabilir. Ev bilgisayarınızı etkinleştirmek ücretsizdir!"};

    public static readonly string[] LicenseUnlimitTip = {
      "EUR {0:0}. Using the current version of the program without time limits. " +
        "All new versions are available for one year. Activation can be canceled and transferred to another computer. " +
        "Activating your home computer is free!",
      "{0:0} EUR. Использование текущей версии программы без ограничений по времени. " +
        "Один год доступны все новые версии. Активацию можно отменить и перенести на другой компьютер. " +
        "Активация вашего домашнего компьютера – бесплатно!",
      "{0:0} EUR. Utilizzo della versione corrente del programma senza limiti di tempo. " +
        "Tutte le nuove versioni sono disponibili per un anno. " +
        "L'attivazione può essere annullata e trasferita su un altro computer. " +
        "L'attivazione del computer di casa è gratuita!",
      "{0:0} EUR. Verwendung der aktuellen Version des Programms ohne zeitliche Begrenzung. " +
        "Alle neuen Versionen sind für ein Jahr verfügbar. " +
        "Die Aktivierung kann abgebrochen und auf einen anderen Computer übertragen werden. " +
        "Die Aktivierung Ihres Heimcomputers ist kostenlos!",
      "EUR {0:0}。 使用当前版本的程序没有时间限制。 所有新版本的有效期为一年。 " +
        "可以取消激活并将其转移到另一台计算机。 激活您的家用电脑是免费的！",
      "EUR {0:0}. Uso de la versión actual del programa sin límites de tiempo. " +
        "Todas las versiones nuevas están disponibles durante un año. La activación se puede cancelar y transferir a otra computadora. " +
        "¡Activar tu computadora doméstica es gratis!",
      "EUR {0:0}. Utilisation de la version actuelle du programme sans limite de temps. " +
        "Toutes les nouvelles versions sont disponibles pendant un an. L'activation peut être annulée et transférée sur un autre ordinateur. " +
        "L'activation de votre ordinateur personnel est gratuite!",
      "EUR {0:0}. Programın mevcut sürümünü zaman sınırı olmadan kullanma. " +
        "Tüm yeni sürümler bir yıl boyunca kullanılabilir. Etkinleştirme iptal edilebilir ve başka bir bilgisayara aktarılabilir. " +
        "Ev bilgisayarınızı etkinleştirmek ücretsizdir!"};

    public static readonly string[] LicenseMultiuserTip = {
      "{0:0} EUR per seat. Annual license for a large company. A single license for all seats simplifies payment and deadline management.",
      "{0:0} EUR за место. Годовая лицензия на крупную фирму. Единая лицензия на все рабочие места упрощает оплату и контроль сроков.",
      "{0:0} EUR per postazione. Licenza annuale per una grande azienda. Una singola licenza per tutte le postazioni semplifica il pagamento e la gestione delle scadenze.",
      "{0:0} EUR pro Arbeitsplatz. Jahreslizenz für ein großes Unternehmen. Eine einzige Lizenz für alle Arbeitsplätze vereinfacht die Zahlung und das Fristenmanagement.",
      "{0:0} 欧元/座。 大型公司的年度许可证。 所有座位的单一许可证简化了付款和截止日期管理。",
      "{0:0} EUR por asiento. Licencia anual para una gran empresa. Una sola licencia para todos los asientos simplifica el pago y la gestión de plazos.",
      "{0:0} EUR par poste. Licence annuelle pour une grande entreprise. Une licence unique pour tous les postes simplifie le paiement et la gestion des délais.",
      "{0:0} EUR oturma başına. Büyük bir şirket için yıllık lisans. Tüm oturumlar için tek bir lisans, ödeme ve son tarih yönetimini basitleştirir."};

    // =========================== License and Activation ===========================================
    public static readonly string[] RequestFile = {
      "Saving code to file",
      "Сохранение кода в файл",
      "Salvataggio del codice su file",
      "Code in Datei speichern",
      "将代码保存到文件",
      "Guardar código en archivo",
      "Enregistrement du code dans un fichier",
      "Kodu dosyaya kaydetme"};

    public static readonly string[] Until = {
      "until",
      "до",
      "fino",
      "bis",
      "直到",
      "hasta",
      "jusqu'à",
      "kadar"};

    public static readonly string[] NoLicense = {
      "You do not have a license to use A>V>C> programs at the {0} workplace",
      "У вас нет лицензий на использование программ A>V>C> на рабочем месте {0}",
      "Non disponi di una licenza per utilizzare programmi sul posto di lavoro {0}",
      "Sie haben keine Lizenz zur Verwendung von Programmen am {0} Arbeitsplatz",
      "您没有在 {0} 工作场所使用 AVC 程序的许可",
      "No tiene una licencia para usar programas A>V>C> en el lugar de trabajo {0}",
      "Vous n'avez pas de licence pour utiliser les programmes A>V>C> sur le lieu de travail {0}",
      "{0} işyerinde A>V>C> programlarını kullanmak için lisansınız yok"};

    public static readonly string[] NoLicenseCommand = {
      "You do not have a license to use programs containing the {0} command at the {1} workplace",
      "У вас нет лицензий на использование программ содержащих команду {0} на рабочем месте {1}",
      "Non disponi di una licenza per utilizzare programmi contenenti il comando {0} sul posto di lavoro {1}",
      "Sie haben keine Lizenz zur Verwendung von Programmen, die den Befehl {0} enthalten, am {1} Arbeitsplatz",
      "您没有在 {1} 工作场所使用包含 {0} 命令的程序的许可证",
      "No tiene una licencia para usar programas que contienen el comando {0} en el lugar de trabajo {1}",
      "Vous n'avez pas de licence pour utiliser des programmes contenant la commande {0} sur le lieu de travail {1}",
      "{1} işyerinde {0} komutunu içeren programları kullanmak için lisansınız yok"};

    public static readonly string[] CannotDeactivate = {
      "Failed to cancel activation. Server reported an error:\r\n\r\n{0}",
      "Не удалось отменить активацию. Сервер сообщил о ошибке:\r\n\r\n{0}",
      "Impossibile annullare l'attivazione. Il server ha segnalato un errore:\r\n\r\n{0}",
      "Aktivierung konnte nicht abgebrochen werden. Der Server hat einen Fehler gemeldet:\r\n\r\n{0}",
      "无法取消激活。 服务器报错：\r\n\r\n{0}",
      "No se pudo cancelar la activación. El servidor informó un error:\r\n\r\n{0}",
      "Échec de l'annulation de l'activation. Le serveur a signalé une erreur:\r\n\r\n{0}",
      "Etkinleştirme iptal edilemedi. Sunucu bir hata bildirdi:\r\n\r\n{0}"};

    public static readonly string[] CannotActivate = {
      "Failed to activate the program. \r\n  {0}",
      "Не удалось активировать программу.\r\n  {0}",
      "Impossibile attivare il programma.\r\n  {0}",
      "Programm konnte nicht aktiviert werden.\r\n  {0}",
      "启动程序失败。\r\n  {0}",
      "No se pudo activar el programa. \r\n  {0}",
      "Échec de l'activation du programme. \r\n  {0}",
      "Program etkinleştirilemedi. \r\n  {0}"};

    public static readonly string[] SuccessActivated = {
      "'{0}' program has been successfully activated.",
      "Программа '{0}' успешно активирована.",
      "Il programma '{0}' è stato attivato con successo.",
      "Programm '{0}' wurde erfolgreich aktiviert.",
      "'{0}'程序已成功激活。",
      "El programa '{0}' se ha activado correctamente.",
      "Le programme '{0}' a été activé avec succès.",
      "'{0}' programı başarıyla etkinleştirildi."};

    public static readonly string[] ProgramForActivate = {
      "Select a program to activate",
      "Выберите программу для активации",
      "Seleziona un programma da attivare",
      "Wählen Sie ein zu aktivierendes Programm aus",
      "选择要激活的程序",
      "Seleccione un programa para activar",
      "Sélectionnez un programme à activer",
      "Etkinleştirilecek bir program seçin"};

    public static readonly string[] TimeCheckErr = {
      "Set the correct time on your computer.",
      "Требуется установить на компьютере корректное время.",
      "Imposta l'ora corretta sul tuo computer.",
      "Stellen Sie die richtige Zeit auf Ihrem Computer ein.",
      "在您的计算机上设置正确的时间。",
      "Configure la hora correcta en su computadora.",
      "Réglez l'heure correcte sur votre ordinateur.",
      "Bilgisayarınızda doğru saati ayarlayın."};

    public static readonly string[] TrialUsed = {
      "The program has already been tested by you.\r\n" +
        "The trial period cannot be reused. Buy a paid license.",
      "Программа уже была вами опробована. Повторное использование пробного периода невозможно.\r\n" +
        "Купите платную лицензию.",
      "Il programma è già stato testato da te. Il periodo di prova non può essere riutilizzato.\r\n" +
        "Acquista una licenza a pagamento.",
      "Das Programm wurde bereits von Ihnen getestet. Die Probezeit kann nicht wiederverwendet werden.\r\n" +
        "Kaufen Sie eine kostenpflichtige Lizenz.",
      "该程序已经过您的测试。 试用期不能重复使用。 购买付费许可证。",
      "El programa ya ha sido probado por usted.\r\n" +
        "El período de prueba no se puede reutilizar. Compre una licencia de pago.",
      "Le programme a déjà été testé par vous.\r\n" +
        "La période d'essai ne peut pas être réutilisée. Achetez une licence payante.",
      "Program zaten sizin tarafınızdan test edildi.\r\n" +
        "Deneme süresi yeniden kullanılamaz. Ücretli bir lisans satın alın."};

    public static readonly string[] AlreadyActivated = {
      "The program {0} is already activated.\r\n" +
        "Prepare enough funds in the account and wait for the license expiration.",
      "Программа {0} уже активирована.\r\n" +
        "Приготовьте достаточно средств на счету и ждите окончания срока лицензии.",
      "Il programma {0} è già attivato.\r\n" +
        "Preparare fondi sufficienti nell'account e attendere la scadenza della licenza.",
      "Das Programm {0} ist bereits aktiviert.\r\n" +
        "Bereiten Sie genügend Guthaben auf dem Konto vor und warten Sie auf den Ablauf der Lizenz.",
      "程序 {0} 已激活。\r\n" +
         "在您的帐户中获得足够的资金并等待许可证到期。",
      "El programa {0} ya está activado.\r\n" +
        "Prepare fondos suficientes en la cuenta y espere la expiración de la licencia.",
      "Le programme {0} est déjà activé.\r\n" +
        "Préparez suffisamment de fonds sur le compte et attendez l'expiration de la licence.",
      "Program {0} zaten etkinleştirildi.\r\n" +
        "Hesapta yeterli fon hazırlayın ve lisansın sona ermesini bekleyin."};

    public static readonly string[] NoPointInActivating = {
      "There is no point in activating the program {0}. " +
        "You already have a license for the program {1}, which contains all these commands.",
      "Нет смысла активировать программу {0}. " +
        "У вас уже есть лицензия на программу {1}, которая содержит все эти команды.",
      "Non ha senso attivare il programma {0}. " +
        "Hai già una licenza per il programma {1}, che contiene tutti questi comandi.",
      "Es macht keinen Sinn, das Programm {0} zu aktivieren. " +
        "Sie haben bereits eine Lizenz für das Programm {1}, das alle diese Befehle enthält.",
      "激活程序 {0} 没有意义。" +
         "您已经拥有包含所有这些命令的软件 {1} 的许可证。",
      "No tiene sentido activar el programa {0}. " +
        "Ya tiene una licencia para el programa {1}, que contiene todos estos comandos.",
      "Il n'y a aucun intérêt à activer le programme {0}. " +
        "Vous avez déjà une licence pour le programme {1}, qui contient toutes ces commandes.",
      "Program {0}'ı etkinleştirmenin bir anlamı yok. " +
        "Zaten tüm bu komutları içeren {1} programı için lisansınız var."};

    public static readonly string[] UnusedLicense = {
      "You have an unused license for program {0}.\r\n" +
        "Use it to activate this computer?",
      "У вас есть неиспользованная лицензия на программу {0}.\r\n" +
        "Использовать ее для активации этого компьютера?",
      "Hai una licenza inutilizzata per il programma {0}.\r\n" +
        "Usalo per attivare questo computer?",
      "Sie haben eine nicht verwendete Lizenz für das Programm {0}.\r\n" +
        "Verwenden Sie es, um diesen Computer zu aktivieren?",
      "您有未使用的程序 {0} 许可证。\r\n" +
         "用它来激活这台电脑？",
      "Tiene una licencia no utilizada para el programa {0}.\r\n" +
        "¿Usarla para activar esta computadora?",
      "Vous avez une licence non utilisée pour le programme {0}.\r\n" +
        "L'utiliser pour activer cet ordinateur?",
      "Program {0} için kullanılmamış bir lisansınız var.\r\n" +
        "Bu bilgisayarı etkinleştirmek için kullanılsın mı?"};

    public static readonly string[] StartTrial = {
      "Start trial period now?\r\n" +
        "You will not be able to re-use the trial period either on other computers or From other " +
        "users of this computer.",
      "Начать пробный период сейчас?\r\n" +
        "Вы не сможете повторно использовать пробный период ни на других компьютерах, " +
        "ни от других пользователей этого компьютера.",
      "Inizia subito la tua prova?\r\n" +
        "Non potrai riutilizzare il periodo di prova né su altri computer né da altri utenti di questo computer.",
      "Starten Sie jetzt Ihre Testversion?\r\n" +
        "Sie können den Testzeitraum weder auf anderen Computern noch von anderen Benutzern dieses " +
        "Computers wiederverwenden.",
      "现在开始试用期吗？\r\n" +
         "您将无法在其他计算机或该计算机的其他用户处重新使用试用期。",
      "¿Iniciar el período de prueba ahora?\r\n" +
        "No podrá reutilizar el período de prueba en otras computadoras ni de otros " +
        "usuarios de esta computadora.",
      "Commencer la période d'essai maintenant?\r\n" +
        "Vous ne pourrez pas réutiliser la période d'essai sur d'autres ordinateurs ou par d'autres " +
        "utilisateurs de cet ordinateur.",
      "Deneme süresini şimdi başlat?\r\n" +
        "Deneme süresini ne başka bilgisayarlarda ne de bu bilgisayarın diğer " +
        "kullanıcılarından yeniden kullanamazsınız."};

    public static readonly string[] PurchaseOffline = {
      "If you do not have a license for the program {1} yet, then EUR {0:0} will be debited From your balance.\r\n" +
        "Continue activating?",
      "Если у вас еще нет лицензии на программу {1}, то с вашего баланса будет списано {0:0} EUR.\r\n" +
        "Продолжить активацию?",
      "Se non hai ancora una licenza per il programma {1}, allora {0:0} EUR verrà addebitato sul tuo saldo.\r\n" +
        "Continuare l'attivazione?",
      "Wenn Sie noch keine Lizenz für das Programm {1} haben, werden {0:0} EUR von Ihrem Guthaben abgebucht.\r\n" +
        "Aktivierung fortsetzen?",
      "如果您还没有 {1} 程序的许可，则将从您的余额中扣除 {0:0} 欧元。\r\n" +
         "继续激活？",
      "Si aún no tiene una licencia para el programa {1}, se debitarán EUR {0:0} de su saldo.\r\n" +
        "¿Continuar activando?",
      "Si vous n'avez pas encore de licence pour le programme {1}, alors EUR {0:0} seront débités de votre solde.\r\n" +
        "Continuer l'activation?",
      "Henüz {1} programı için lisansınız yoksa, bakiyenizden EUR {0:0} düşülecektir.\r\n" +
        "Etkinleştirmeye devam edilsin mi?"};

    public static readonly string[] Purchase = {
      "Your balance will be charged EUR {0:0} for the license for the program {1}. No return possible.\r\n" +
        "Do you confirm?",
      "С вашего баланса будет списано {0:0} EUR за лицензию на программу {1}. Возврат невозможен.\r\n" +
        "Списывать?",
      "Il saldo verrà addebitato EUR {0:0} per una licenza per il programma {1}. Nessun reso possibile.\r\n" +
        "Confermi?",
      "Ihr Guthaben wird mit EUR {0:0} für die Lizenz für das Programm {1} berechnet. Keine Rückgabe möglich.\r\n" +
        "Bestätigen Sie?",
      "{0:0} 欧元将从您的余额中扣除，用于程序 {1} 的许可证。 退货是不可能的。\r\n" +
        "你确认？",
      "Se cargará a su saldo EUR {0:0} por la licencia del programa {1}. No es posible devolución.\r\n" +
        "¿Confirma?",
      "Votre solde sera débité de EUR {0:0} pour la licence du programme {1}. Aucun retour possible.\r\n" +
        "Confirmez-vous?",
      "Bakiyenizden program {1} lisansı için EUR {0:0} tahsil edilecektir. İade mümkün değildir.\r\n" +
        "Onaylıyor musunuz?"};

    public static readonly string[] OldVersion = {
      "Program {0} is too old.\r\n" +
        "It cannot be activated.\r\n" +
        "The latest version is {1}.\r\n" +
        "Update the program.",
      "Программа {0} слишком старая.\r\n" +
        "Ее нельзя активировать.\r\n" +
        "Сейчас актуальна версия - {1}.\r\n" +
        "Обновите программу.",
      "Il programma {0} è troppo vecchio.\r\n" +
        "Non può essere attivato.\r\n" +
        "L'ultima versione è {1}.\r\n" +
        "Aggiorna il programma.",
      "Programm {0} ist zu alt.\r\n" +
        "Es kann nicht aktiviert werden.\r\n" +
        "Die neueste Version ist {1}.\r\n" +
        "Aktualisieren Sie das Programm.",
      "程序 {0} 太旧。 无法激活。\r\n" +
         "最新版本是 {1}。\r\n" +
         "更新程序。",
      "El programa {0} es demasiado antiguo.\r\n" +
        "No se puede activar.\r\n" +
        "La última versión es {1}.\r\n" +
        "Actualice el programa.",
      "Le programme {0} est trop ancien.\r\n" +
        "Il ne peut pas être activé.\r\n" +
        "La dernière version est {1}.\r\n" +
        "Mettez à jour le programme.",
      "Program {0} çok eski.\r\n" +
        "Etkinleştirilemez.\r\n" +
        "En son sürüm {1}.\r\n" +
        "Programı güncelleyin."};

    public static readonly string[] OldVersionForUnlimit = {
      "Program {0} is too old. \r\n" +
        "Bugs found and fixed in this version. It is recommended to buy a new license." ,
      "Программа {0} слишком старая. \r\n" +
        "В этой версии найдены и исправлены ошибки. Рекомендуется купить новую лицензию.",
      "Il programma {0} è troppo vecchio. \r\n" +
        "Bug trovati e corretti in questa versione. Si consiglia di acquistare una nuova licenza.",
      "Programm {0} ist zu alt. Es kann nicht aktiviert werden.\r\n" +
        "In dieser Version wurden Fehler gefunden und behoben. Es wird empfohlen, eine neue Lizenz zu kaufen.",
      "程序 {0} 太旧。 \r\n" +
         "在此版本中发现并修复了错误。 建议购买新的许可证。",
      "El programa {0} es demasiado antiguo. \r\n" +
        "Errores encontrados y corregidos en esta versión. Se recomienda comprar una nueva licencia.",
      "Le programme {0} est trop ancien. \r\n" +
        "Bugs trouvés et corrigés dans cette version. Il est recommandé d'acheter une nouvelle licence.",
      "Program {0} çok eski. \r\n" +
        "Bu sürümde hatalar bulundu ve düzeltildi. Yeni bir lisans satın almanız önerilir."};

    public static readonly string[] FreeRemember = {
      "The '{0}' program is free. But remember that developing, updating and maintaining it is a lot of work.\r\n" +
        "If the program is profitable for you, please share a small amount.",
      "Программа '{0}' бесплатная. Но помните, что ее разработка, обновление и поддержка стоит большого труда.\r\n" +
        "Если программа приносит вам прибыль, пожалуйста, поделитесь небольшой суммой.",
      "Il programma '{0}' è gratuito. Ma ricorda che svilupparlo, aggiornarlo e mantenerlo è molto lavoro.\r\n" +
        "Se il programma è redditizio per te, condividi una piccola somma."  ,
      "Das Programm '{0}' ist kostenlos. Denken Sie jedoch daran, dass das Entwickeln, Aktualisieren und Verwalten viel Arbeit bedeutet.\r\n" +
        "Wenn das Programm für Sie rentabel ist, teilen Sie bitte einen kleinen Betrag.",
      "'{0}'程序是免费的。 但请记住，开发、更新和维护它是一项繁重的工作。\r\n" +
         "如果该计划对您有利，请分享少量。",
      "El programa '{0}' es gratuito. Pero recuerde que desarrollarlo, actualizarlo y mantenerlo es mucho trabajo.\r\n" +
        "Si el programa es rentable para usted, por favor comparta una pequeña cantidad.",
      "Le programme '{0}' est gratuit. Mais rappelez-vous que le développer, le mettre à jour et le maintenir représente beaucoup de travail.\r\n" +
        "Si le programme vous est rentable, veuillez partager un petit montant.",
      "'{0}' programı ücretsizdir. Ancak geliştirmenin, güncellemenin ve bakımının çok iş olduğunu unutmayın.\r\n" +
        "Program sizin için karlıysa, lütfen küçük bir miktar paylaşın."};

    public static readonly string[] ErrorKey = {
      "Error. The key is not suitable for activating this program at this workplace.",
      "Ошибка. Ключ не подходит для активации этой программы на этом рабочем месте.",
      "Errore. La chiave non è adatta per attivare questo programma in questo posto di lavoro.",
      "Error. Der Schlüssel ist nicht zum Aktivieren dieses Programms an diesem Arbeitsplatz geeignet.",
      "错误。 该密钥不适用于在此工作场所激活此程序。",
      "Error. La clave no es adecuada para activar este programa en este lugar de trabajo.",
      "Erreur. La clé ne convient pas pour activer ce programme sur ce lieu de travail.",
      "Hata. Anahtar bu işyerinde bu programı etkinleştirmek için uygun değil."};

    public static readonly string[] NoActivationsToDeactivate = {
      "There is nothing to deactivate.\r\n" +
        "All activations are trial or activated today.\r\n" +
        "They cannot be deleted.",
      "Нечего деактивировать.\r\n" +
        "Все активации пробные или активированы сегодня.\r\n" +
        "Их нельзя удалять.",
      "Non c'è nulla da disattivare.\r\n" +
        "Tutte le attivazioni sono di prova o attivate oggi.\r\n" +
        "Non possono essere eliminati.",
      "Es gibt nichts zu deaktivieren.\r\n" +
        "Alle Aktivierungen sind heute als Testversion oder aktiviert.\r\n" +
        "Sie können nicht gelöscht werden.",
      "没有可停用的内容。\r\n" +
         "今天所有激活都是试用或激活的。\r\n" +
         "它们不能被删除。",
      "No hay nada que desactivar.\r\n" +
        "Todas las activaciones son de prueba o activadas hoy.\r\n" +
        "No se pueden eliminar.",
      "Il n'y a rien à désactiver.\r\n" +
        "Toutes les activations sont d'essai ou activées aujourd'hui.\r\n" +
        "Elles ne peuvent pas être supprimées.",
      "Devre dışı bırakılacak bir şey yok.\r\n" +
        "Tüm etkinleştirmeler deneme veya bugün etkinleştirilmiş.\r\n" +
        "Silinemezler."};

    public static readonly string[] TimeError = {
      "The time on the computer is wrong. Unable to activate AVC programs",
      "На компьютере ошибочное время. Активация программ A>V>C> невозможна",
      "L'ora sul computer è sbagliata. Impossibile attivare i programmi A>V>C>",
      "Die Zeit auf dem Computer ist falsch. Programme A>V>C> können nicht aktiviert werden",
      "电脑上的时间不对。 无法激活 AVC 程序。",
      "La hora en la computadora es incorrecta. No se pueden activar programas AVC",
      "L'heure sur l'ordinateur est incorrecte. Impossible d'activer les programmes AVC",
      "Bilgisayardaki saat yanlış. AVC programları etkinleştirilemiyor"};

    public static readonly string[] TrialTip = {
      "The {0} program is running in trial mode. Days left: {1:0}",
      "Программа {0} работает в пробном режиме. Осталось дней: {1:0}",
      "Il programma {0} è in esecuzione in modalità di prova. Giorni rimasti: {1:0}",
      "Programm {0} wird im Testmodus ausgeführt. Verbleibende Tage: {1:0}",
      "{0} 程序正在试用模式下运行。 剩余天数：{1:0}",
      "El programa {0} se está ejecutando en modo de prueba. Días restantes: {1:0}",
      "Le programme {0} fonctionne en mode d'essai. Jours restants: {1:0}",
      "{0} programı deneme modunda çalışıyor. Kalan gün sayısı: {1:0}"};

    public static readonly string[] EndSoon = {
      "The license for the {0} program expires in {1:0} day(s).\r\n" +
          "Take care of replenishing your balance. " +
          "Program price: {2}",
      "Лицензия на программу {0} заканчивается через {1:0} дня(дней).\r\n" +
          "Позаботьтесь о пополнении вашего баланса. " +
          "Цена программы: {2}",
      "La licenza per il programma {0} scade tra {1:0} giorno/i.\r\n" +
          "Prenditi cura di ripristinare il tuo equilibrio. " +
          "Prezzo del programma: {2}",
      "Die Lizenz für das {0}-Programm läuft in {1:0} Tagen ab.\r\n" +
          "Achten Sie darauf, Ihr Gleichgewicht wieder aufzufüllen. " +
          "Programmpreis: {2}",
      "{0} 程序的许可证将在 {1:0} 天后到期。\r\n" +
         "注意补充你的余额。" +
         "节目价格：{2}",
      "La licencia para el programa {0} expira en {1:0} día(s).\r\n" +
          "Cuide de reponer su saldo. " +
          "Precio del programa: {2}",
      "La licence du programme {0} expire dans {1:0} jour(s).\r\n" +
          "Veillez à recharger votre solde. " +
          "Prix du programme: {2}",
      "{0} programının lisansının süresi {1:0} gün içinde doluyor.\r\n" +
          "Bakiyenizi yenilemeye dikkat edin. " +
          "Program fiyatı: {2}"};

    public static readonly string[] ActivationTitle = {
      "Activation A>V>C>",
      "Активация A>V>C>",
      "Attivazione A>V>C>",
      "Aktivierung A>V>C>",
      "激活 A>V>C>",
      "Activación A>V>C>",
      "Activation A>V>C>",
      "Etkinleştirme A>V>C>"};

    public static readonly string[] LicenseTitle = {
      "License Management",
      "Управление лицензиями",
      "Gestione delle licenze",
      "Lizenzverwaltung",
      "许可证管理",
      "Gestión de licencias",
      "Gestion des licences",
      "Lisans Yönetimi"};

    public static readonly string[] LicenseType = {
      "License Type",
      "Тип лицензии",
      "Tipo di licenza",
      "Lizenz-Typ",
      "许可证类型",
      "Tipo de licencia",
      "Type de licence",
      "Lisans Türü"};

    public static readonly string[] LicenseTip = {
      "You can see all your licenses activated on all your workplaces.\r\n" +
        "If you need to transfer the license to a new workplace, you must first deactivate the old workplace.\r\n" +
        "Select the unwanted workplace From the list and click 'Delete'.\r\n" +
        "Or use the 'Deactivate' button to remove all activations for this workplace.",
      "Вы можете посмотреть все ваши лицензии, активированные на всех ваших компьютерах. \r\n" +
        "Для переноса лицензии на новое рабочее место, следует сначала отменить активацию старого.\r\n" +
        "Выберите ненужную активацию из списка и нажмите 'Удалить'.\r\n" +
        "Или используйте кнопку 'Деактивировать', чтоб удалить все активации этого рабочего места.",
      "Puoi vedere tutte le tue licenze attivate su tutti i tuoi luoghi di lavoro.\r\n" +
         "Se devi trasferire la licenza in un nuovo posto di lavoro, devi prima disattivare il vecchio posto di lavoro.\r\n" +
         "Seleziona il posto di lavoro indesiderato dall'elenco e fai clic su 'Elimina'.\r\n" +
         "Oppure usa il pulsante 'Disattiva' per rimuovere tutte le attivazioni per questo posto di lavoro.",
      "Sie können alle Ihre Lizenzen sehen, die auf allen Ihren Arbeitsplätzen aktiviert sind.\r\n" +
         "Wenn Sie die Lizenz auf einen neuen Arbeitsplatz übertragen müssen, müssen Sie zuerst den alten Arbeitsplatz deaktivieren.\r\n" +
         "Wählen Sie den unerwünschten Arbeitsplatz aus der Liste aus und klicken Sie auf 'Löschen'.\r\n" +
         "Oder verwenden Sie die Schaltfläche 'Deaktivieren', um alle Aktivierungen für diesen Arbeitsplatz zu entfernen.",
      "您可以看到在您的所有工作场所激活的所有许可证。\r\n" +
         "如果您需要将许可证转移到新的工作场所，您必须先停用旧的工作场所。\r\n" +
         "从列表中选择不需要的工作场所，然后单击'删除'。\r\n" +
         "或者使用'停用'按钮删除此工作场所的所有激活。",
      "Puede ver todas sus licencias activadas en todos sus lugares de trabajo.\r\n" +
        "Si necesita transferir la licencia a un nuevo lugar de trabajo, primero debe desactivar el lugar de trabajo antiguo.\r\n" +
        "Seleccione el lugar de trabajo no deseado de la lista y haga clic en 'Eliminar'.\r\n" +
        "O use el botón 'Desactivar' para eliminar todas las activaciones de este lugar de trabajo.",
      "Vous pouvez voir toutes vos licences activées sur tous vos lieux de travail.\r\n" +
        "Si vous devez transférer la licence vers un nouveau lieu de travail, vous devez d'abord désactiver l'ancien lieu de travail.\r\n" +
        "Sélectionnez le lieu de travail indésirable dans la liste et cliquez sur 'Supprimer'.\r\n" +
        "Ou utilisez le bouton 'Désactiver' pour supprimer toutes les activations de ce lieu de travail.",
      "Tüm işyerlerinizde etkinleştirilen tüm lisanslarınızı görebilirsiniz.\r\n" +
        "Lisansı yeni bir işyerine aktarmanız gerekiyorsa, önce eski işyerini devre dışı bırakmalısınız.\r\n" +
        "Listeden istenmeyen işyerini seçin ve 'Sil'e tıklayın.\r\n" +
        "Veya bu işyerinin tüm etkinleştirmelerini kaldırmak için 'Devre Dışı Bırak' düğmesini kullanın."};

    public static readonly string[] Activate = {
      "Activate",
      "Активировать",
      "Attivare",
      "Aktivieren",
      "启用",
      "Activar",
      "Activer",
      "Etkinleştir"};

    public static readonly string[] Deactivate = {
      "Deactivate all",
      "Деактивировать",
      "Disattiva tutto",
      "Deaktivieren",
      "全部停用",
      "Desactivar todo",
      "Désactiver tout",
      "Tümünü devre dışı bırak"};

    public static readonly string[] Activation = {
      "Activation",
      "Активация",
      "Attivazione",
      "Aktivierung",
      "激活",
      "Activación",
      "Activation",
      "Etkinleştirme"};

    public static readonly string[] Activations = {
      "Activations",
      "Активации",
      "Attivazioni",
      "Aktivierungen",
      "激活",
      "Activaciones",
      "Activations",
      "Etkinleştirmeler"};

    public static readonly string[] LicAndActivations = {
      "Licenses and Activations",
      "Лицензии и Активации",
      "Licenze e attivazioni",
      "Lizenzen und Aktivierungen",
      "许可证和激活",
      "Licencias y Activaciones",
      "Licences et Activations",
      "Lisanslar ve Etkinleştirmeler"};

    public static readonly string[] ActivationsTip = {
      "Your activated programs and workplaces. \r\n" +
        "Program / License type and expiration - Activated Computer/User",
      "Все ваши активированные программы и рабочие места. \r\n" +
        "Программа / Тип лицензии и срок - Активированный Компьютер/Пользователь",
      "I tuoi programmi e luoghi di lavoro attivati. \r\n" +
         "Programma / Tipo e scadenza della licenza - Computer/Utente attivato",
      "Ihre aktivierten Programme und Arbeitsplätze. \r\n" +
         "Programm / Lizenztyp und -ablauf - Aktivierter Computer/Benutzer",
      "您激活的程序和工作场所。 \r\n" +
         "程序/许可证类型和到期 - 激活的计算机/用户",
      "Sus programas y lugares de trabajo activados. \r\n" +
        "Programa / Tipo de licencia y vencimiento - Computadora/Usuario activado",
      "Vos programmes et lieux de travail activés. \r\n" +
        "Programme / Type de licence et expiration - Ordinateur/Utilisateur activé",
      "Etkinleştirilen programlarınız ve işyerleriniz. \r\n" +
        "Program / Lisans türü ve son kullanma - Etkinleştirilen Bilgisayar/Kullanıcı"};

    public static readonly string[] Activated = {
      "Activated",
      "Активирована",
      "Attivato",
      "Aktiviert",
      "活性",
      "Activado",
      "Activé",
      "Etkinleştirildi"};

    public static readonly string[] License = {
      "License",
      "Лицензия",
      "Licenza",
      "Lizenz",
      "执照",
      "Licencia",
      "Licence",
      "Lisans"};

    public static readonly string[] Licenses = {
      "Licenses",
      "Лицензии",
      "Licenze",
      "Lizenzen",
      "许可证",
      "Licencias",
      "Licences",
      "Lisanslar"};

    public static readonly string[] LicensesTip = {
      "Your licenses that you have not yet activated. \r\n" +
        "Program / License start date / License type and expiration - Number of unused activations",
      "Все ваши лицензии, которые вы еще не активировали. \r\n" +
        "Программа / Начало лицензии / Тип лицензии и срок - Не использовано активаций",
      "Le tue licenze che non hai ancora attivato. \r\n" +
         "Programma / Data inizio licenza / Tipo e scadenza licenza - Numero di attivazioni non utilizzate",
      "Ihre Lizenzen, die Sie noch nicht aktiviert haben. \r\n" +
         "Programm / Startdatum der Lizenz / Lizenztyp und -ablauf - Anzahl der ungenutzten Aktivierungen",
      "您尚未激活的许可证。 \r\n" +
         "程序/许可证开始日期/许可证类型和到期 - 未使用的激活次数",
      "Sus licencias que aún no ha activado. \r\n" +
        "Programa / Fecha de inicio de licencia / Tipo de licencia y vencimiento - Número de activaciones sin usar",
      "Vos licences que vous n'avez pas encore activées. \r\n" +
        "Programme / Date de début de licence / Type de licence et expiration - Nombre d'activations non utilisées",
      "Henüz etkinleştirmediğiniz lisanslarınız. \r\n" +
        "Program / Lisans başlangıç tarihi / Lisans türü ve son kullanma - Kullanılmamış etkinleştirme sayısı"};

    public static readonly string[] BuyDate = {
      "Buy Date",
      "Куплена",
      "Acquista data",
      "Datum kaufen",
      "购买日期",
      "Fecha de compra",
      "Date d'achat",
      "Satın Alma Tarihi"};

    public static readonly string[] Expiration = {
      "Expiration",
      "Срок",
      "Scadenza",
      "Ablauf",
      "到期",
      "Vencimiento",
      "Expiration",
      "Son Kullanma"};

    public static readonly string[] MaxPlaces = {
      "Max Places",
      "Мест",
      "Posti massimi",
      "Maximale Orte",
      "最多的地方",
      "Lugares máximos",
      "Places max",
      "Maksimum Yer"};

    public static readonly string[] Amount = {
      "Amount",
      "Стоимость",
      "Importo",
      "Menge",
      "数量",
      "Cantidad",
      "Montant",
      "Miktar"};

    public static readonly string[] Receipt = {
      "Receipt",
      "Приход",
      "Ricevuta",
      "Einnahme",
      "收据",
      "Recibo",
      "Reçu",
      "Makbuz"};

    public static readonly string[] Receipts = {
      "Receipts",
      "Приходы",
      "Ricevuti",
      "Einnahme",
      "收据",
      "Recibos",
      "Reçus",
      "Makbuzlar"};

    public static readonly string[] Date = {
      "Date",
      "Дата",
      "Data",
      "Datum",
      "硬件",
      "Fecha",
      "Date",
      "Tarih"};

    public static readonly string[] Wallet = {
      "Wallet",
      "Кошелек",
      "Portafoglio",
      "Brieftasche",
      "钱包",
      "Cartera",
      "Portefeuille",
      "Cüzdan"};

    public static readonly string[] Sender = {
      "Sender",
      "Отправитель",
      "Mittente",
      "Absender",
      "发件人",
      "Remitente",
      "Expéditeur",
      "Gönderen"};

    public static readonly string[] Refill = {
      "Refill",
      "Пополнение",
      "Ricarica",
      "Nachfüllung",
      "笔芯",
      "Recarga",
      "Recharge",
      "Yeniden Doldurma"};

    public static readonly string[] Refills = {
      "Refills",
      "Пополнения",
      "Ricariche",
      "Nachfüllungen",
      "笔芯",
      "Recargas",
      "Recharges",
      "Yeniden Doldurmalar"};

    public static readonly string[] Reason = {
      "Reason",
      "Причина",
      "Motivo",
      "Absender",
      "原因",
      "Razón",
      "Raison",
      "Sebep"};

    public static readonly string[] Workplace = {
      "Workplace",
      "Рабочее место",
      "Posto di lavoro",
      "Arbeitsplatz",
      "工作场所",
      "Lugar de trabajo",
      "Lieu de travail",
      "İşyeri"};

    public static readonly string[] ThisWorkplace = {
      "This workplace",
      "Это рабочее место",
      "Posto di lavoro",
      "Arbeitsplatz",
      "这是一个工作场所",
      "Este lugar de trabajo",
      "Ce lieu de travail",
      "Bu işyeri"};

    public static readonly string[] ActivationSite = {
      "More about activation",
      "Подробнее об активации",
      "Ulteriori informazioni sull'attivazione",
      "Erfahren Sie mehr über die Aktivierung",
      "了解有关激活的更多信息",
      "Más sobre activación",
      "Plus sur l'activation",
      "Etkinleştirme hakkında daha fazla"};

    public static readonly string[] Computer = {
      "Computer",
      "Компьютер",
      "Computer",
      "Computer",
      "电脑",
      "Computadora",
      "Ordinateur",
      "Bilgisayar"};

    public static readonly string[] User = {
      "User",
      "Пользователь",
      "Utente",
      "Benutzer",
      "用户",
      "Usuario",
      "Utilisateur",
      "Kullanıcı"};

    public static readonly string[] Domain = {
      "Domain",
      "Домен",
      "Dominio",
      "Domain",
      "领域",
      "Dominio",
      "Domaine",
      "Alan"};

    public static readonly string[] Hardware = {
      "Hardware",
      "Железо",
      "Hardware",
      "Hardware",
      "硬件",
      "Hardware",
      "Matériel",
      "Donanım"};

    public static readonly string[] RefillReasonDonation = {
      "Donation",
      "Пожертвование", };
    public static readonly string[] RefillReasonTypo = {
      "Fixed a typo",
      "Исправил опечатку", };
    public static readonly string[] RefillReasonBugReport = {
      "Described the error",
      "Описал ошибку", };
    public static readonly string[] RefillReasonTranslation = {
      "Help with translation",
      "Помог с переводом", };
    public static readonly string[] RefillReasonContent = {
      "Created content",
      "Создал контент", };
    public static readonly string[] RefillReasonAttraction = {
      "Attracted a buyer",
      "Привлек покупателя", };
    public static readonly string[] RefillReasonReview = {
      "Published a review",
      "Опубликовал обзор", };
    public static readonly string[] RefillReasonComment = {
      "Posted a comment",
      "Опубликовал комментарий", };
    public static readonly string[] RefillReasonTransfer = {
      "From another account",
      "С другого аккаунта", };
    public static readonly string[] RefillReasonGift = {
      "Gift",
      "Подарок", };

    //==================================================== Для процедуры авто-активации Ambiance.AutoActivate ==============================================================
    public static readonly string[] OfferFree1 = {
      "Activate free {0} program ?",
      "Активировать бесплатную программу {0} ?",
      "Attivare il programma gratuito {0} ?",
      "Kostenloses Programm {0} aktivieren ?",
      "激活免费程序 {0} ?",
      "¿Activar programa gratuito {0}?",
      "Activer le programme gratuit {0}?",
      "Ücretsiz {0} programını etkinleştir?"};

    public static readonly string[] OfferFreeMany = {
      "Activate free A>V>C> programs:\r\n  {0} ?",
      "Активировать бесплатные программы A>V>C>:\r\n  {0} ?",
      "Attiva programmi A>V>C> gratuiti:\r\n  {0} ?",
      "Kostenlose A>V>C>-Programme aktivieren:\r\n  {0} ?",
      "激活免费的 A>V>C> 程序：\r\n  {0} ?",
      "¿Activar programas gratuitos A>V>C>:\r\n  {0}?",
      "Activer les programmes gratuits A>V>C>:\r\n  {0}?",
      "Ücretsiz A>V>C> programlarını etkinleştir:\r\n  {0}?"};

    public static readonly string[] OfferTry1 = {
      "Do you want to start the trial period for the {0} program right now?",
      "Хотите начать пробный период для программы {0} прямо сейчас ?",
      "Vuoi iniziare subito il periodo di prova per il programma {0}?",
      "Möchten Sie den Testzeitraum für das {0}-Programm jetzt starten?",
      "您要立即开始 {0} 程序的试用期吗？",
      "¿Desea iniciar el período de prueba para el programa {0} ahora mismo?",
      "Voulez-vous commencer la période d'essai pour le programme {0} maintenant?",
      "{0} programı için deneme süresini şimdi başlatmak ister misiniz?"};

    public static readonly string[] OfferTryMany = {
      "You can start a trial period for A>V>C> programs:\r\n" +
        "  {0}. \r\n\r\n" +
        "Activate right now?",
      "Можно начать пробный период для программ A>V>C>: \r\n" +
        "  {0}. \r\n\r\n" +
        "Активировать прямо сейчас? ",
      "Puoi iniziare un periodo di prova per i programmi A>V>C>:\r\n" +
        "  {0}. \r\n\r\n" +
        "Attivare adesso?",
      "Sie können einen Testzeitraum für folgende A>V>C>-Programme starten:\r\n" +
        "  {0}. " +
        "\r\n\r\nSofort aktivieren?",
      "您可以开始以下程序 A>V>C> 的试用期：\r\n" +
        "  {0}。 \r\n\r\n" +
        "马上激活？",
      "Puede iniciar un período de prueba para programas A>V>C>:\r\n" +
        "  {0}. \r\n\r\n" +
        "¿Activar ahora mismo?",
      "Vous pouvez commencer une période d'essai pour les programmes A>V>C>:\r\n" +
        "  {0}. \r\n\r\n" +
        "Activer maintenant?",
      "A>V>C> programları için deneme süresi başlatabilirsiniz:\r\n" +
        "  {0}. \r\n\r\n" +
        "Şimdi etkinleştir?"};

    public static readonly string[] OfferActivate1 = {
      "You have a non-activated license for {0}.\r\n\r\n" +
        "Activate?",
      "У вас есть неактивированная лицензия на программу {0}. \r\n\r\n" +
        "Активировать?",
      "Hai una licenza non attivata per {0}.\r\n\r\n" +
        "Attivare?",
      "Sie haben eine nicht aktivierte Lizenz für {0}.\r\n\r\n" +
        "Aktivieren Sie?",
      "您有 {0} 的未激活许可证。\r\n\r\n" +
        "启用？",
      "Tiene una licencia no activada para {0}.\r\n\r\n" +
        "¿Activar?",
      "Vous avez une licence non activée pour {0}.\r\n\r\n" +
        "Activer?",
      "{0} için etkinleştirilmemiş bir lisansınız var.\r\n\r\n" +
        "Etkinleştir?"};

    public static readonly string[] OfferActivateMany = {
      "You have unactivated A>V>C> program licenses:\r\n" +
        "  {0}. \r\n\r\n" +
        "Activate?",
      "У вас есть неактивированные лицензии на программы A>V>C>:\r\n" +
        "  {0}. \r\n\r\n" +
        "Активировать?",
      "Si dispone di licenze software non attivate A>V>C>:\r\n" +
        "  {0}. \r\n\r\n" +
        "Attivare?",
      "Sie haben nicht aktivierte Lizenzen für A>V>C>-Programme:\r\n" +
        "  {0}. \r\n\r\n" +
        "Aktivieren Sie?",
      "您有 A>V>C> 程序的未激活许可证：\r\n" +
        "  {0}。\r\n\r\n" +
        "启用？",
      "Tiene licencias de programas A>V>C> no activadas:\r\n" +
        "  {0}. \r\n\r\n" +
        "¿Activar?",
      "Vous avez des licences de programmes A>V>C> non activées:\r\n" +
        "  {0}. \r\n\r\n" +
        "Activer?",
      "Etkinleştirilmemiş A>V>C> program lisanslarınız var:\r\n" +
        "  {0}. \r\n\r\n" +
        "Etkinleştir?"};

    public static readonly string[] OfferTransfer1 = {
      "Your license for {0} have already been activated elsewhere. \r\n" +
        "But you can remove the activation of another computer to activate this one. \r\n" +
        "Or you can buy another license.",
      "Ваша лицензия на программу {0} уже активирована в другом месте. \r\n" +
        "Но вы можете удалить активацию другого компьютера, чтоб активировать этот. \r\n" +
        "Или вы можете купить еще одну лицензию.",
      "Le tue licenze per il programma {0} sono già state attivate altrove. \r\n" +
        "Ma puoi rimuovere l'attivazione di un altro computer per attivare questo. \r\n" +
        "Oppure puoi acquistare un'altra licenza.",
      "Ihre Lizenzen für das {0}-Programm wurden bereits an anderer Stelle aktiviert. \r\n" +
        "Sie können jedoch die Aktivierung eines anderen Computers entfernen, um diesen zu aktivieren. \r\n" +
        "Oder Sie können eine andere Lizenz kaufen.",
      "您的程序 {0} 的许可证已在别处激活。 \r\n" +
        "但是你可以去掉另一台电脑的激活来激活这台电脑。 \r\n" +
        "或者您可以购买另一个许可证。",
      "Su licencia para {0} ya ha sido activada en otro lugar. \r\n" +
        "Pero puede eliminar la activación de otra computadora para activar esta. \r\n" +
        "O puede comprar otra licencia.",
      "Votre licence pour {0} a déjà été activée ailleurs. \r\n" +
        "Mais vous pouvez supprimer l'activation d'un autre ordinateur pour activer celui-ci. \r\n" +
        "Ou vous pouvez acheter une autre licence.",
      "{0} için lisansınız başka bir yerde zaten etkinleştirilmiş. \r\n" +
        "Ancak bunu etkinleştirmek için başka bir bilgisayarın etkinleştirmesini kaldırabilirsiniz. \r\n" +
        "Veya başka bir lisans satın alabilirsiniz."};

    public static readonly string[] OfferTransferMany = {
      "You have licenses for A>V>C> programs:\r\n " +
        "{0}. \r\n" +
        "But they are all already activated elsewhere.\r\n" +
        "You can remove other computer's activations to activate this one.\r\n" +
        "Or you can buy additional licenses.",
      "У вас есть лицензии на программы A>V>C>:\r\n " +
        "{0}.\r\n" +
        "Но все они уже активирована в другом месте.\r\n" +
        "Вы можете удалить активации другого компьютера, чтоб активировать этот.\r\n" +
        "Или вы можете купить дополнительные лицензии.",
      "Hai le licenze per i programmi A>V>C>:\r\n " +
        "{0}.\r\n" +
        "Ma sono già tutti attivati altrove.\r\n" +
        "Puoi rimuovere le attivazioni di altri computer per attivare questa.\r\n" +
        "Oppure puoi acquistare licenze aggiuntive.",
      "Sie haben Lizenzen für die A>V>C>-Programme:\r\n" +
        "{0}.\r\n" +
        "Aber sie sind alle bereits woanders aktiviert.\r\n" +
        "Sie können die Aktivierungen anderer Computer entfernen,\r\n" +
        "um diesen zu aktivieren.\r\n" +
        "Oder Sie können zusätzliche Lizenzen kaufen.",
      "你有程序 A>V>C> 的许可证吗：\r\n" +
        "{0}。\r\n" +
        "但它们都已经在别处被激活了。\r\n" +
        "您可以删除其他计算机的激活以激活这台计算机。\r\n" +
        "或者您可以购买额外的许可证。",
      "Tiene licencias para programas A>V>C>:\r\n " +
        "{0}. \r\n" +
        "Pero todas ya están activadas en otro lugar.\r\n" +
        "Puede eliminar las activaciones de otras computadoras para activar esta.\r\n" +
        "O puede comprar licencias adicionales.",
      "Vous avez des licences pour les programmes A>V>C>:\r\n " +
        "{0}. \r\n" +
        "Mais elles sont toutes déjà activées ailleurs.\r\n" +
        "Vous pouvez supprimer les activations d'autres ordinateurs pour activer celui-ci.\r\n" +
        "Ou vous pouvez acheter des licences supplémentaires.",
      "A>V>C> programları için lisanslarınız var:\r\n " +
        "{0}. \r\n" +
        "Ancak hepsi zaten başka bir yerde etkinleştirilmiş.\r\n" +
        "Bunu etkinleştirmek için diğer bilgisayarların etkinleştirmelerini kaldırabilirsiniz.\r\n" +
        "Veya ek lisanslar satın alabilirsiniz."};

    public static readonly string[] OfferBuy1 = {
      "Your license for {0} is no longer valid.\r\n" +
        "But you have money on your account to buy a new license.\r\n\r\n" +
        "Pay {1} ?",
      "Ваша лицензия на программу {0} уже не действительна.\r\n" +
        "Но у вас есть деньги на аккаунте для покупки новой лицензии.\r\n\r\n" +
        "Оплатить {1} ?",
      "La tua licenza per {0} non è più valida.\r\n" +
        "Ma hai soldi sul tuo conto per acquistare una nuova licenza.\r\n\r\n" +
        "Pagare {1} ?",
      "Ihre Lizenz für {0} ist nicht mehr gültig.\r\n" +
        "Aber Sie haben Geld auf Ihrem Konto, um eine neue Lizenz zu kaufen.\r\n\r\n" +
        "Zahle {1} ?",
      "您的 {0} 许可证不再有效。\r\n" +
        "但是您帐户上有钱购买新许可证。\r\n\r\n" +
        "支付{1}？",
      "Su licencia para {0} ya no es válida.\r\n" +
        "Pero tiene dinero en su cuenta para comprar una nueva licencia.\r\n\r\n" +
        "¿Pagar {1}?",
      "Votre licence pour {0} n'est plus valide.\r\n" +
        "Mais vous avez de l'argent sur votre compte pour acheter une nouvelle licence.\r\n\r\n" +
        "Payer {1}?",
      "{0} için lisansınız artık geçerli değil.\r\n" +
        "Ancak yeni bir lisans satın almak için hesabınızda para var.\r\n\r\n" +
        "{1} öde?"};

    public static readonly string[] OfferBuyMany = {
      "You had A>V>C> program licenses:\r\n" +
        "{0}.\r\n" +
        "But they are no longer valid.\r\n" +
        "You can use your account balance to purchase new licenses.\r\n\r\n" +
        "Pay {1} ?",
      "У вас были лицензии на программы A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Но все они уже не действительны.\r\n" +
        "Вы можете использовать баланс вашего аккаунта для покупки новых лицензий.\r\n\r\n" +
        "Оплатить {1} ?",
      "Avevi le licenze del programma A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Ma non sono più validi.\r\n" +
        "Puoi utilizzare il saldo del tuo account per acquistare nuove licenze.\r\n\r\n" +
        "Pagare {1} ?",
      "Sie hatten A>V>C>-Programmlizenzen:\r\n" +
        "{0}.\r\n" +
        "Aber sie sind nicht mehr gültig.\r\n" +
        "Sie können Ihr Kontoguthaben verwenden, um neue Lizenzen zu erwerben.\r\n\r\n" +
        "Zahle {1} ?",
      "您拥有程序 A>V>C> 的许可证：\r\n" +
        "{0}。\r\n" +
        "但它们不再有效。\r\n" +
        "您可以使用您的帐户余额购买新的许可证。\r\n\r\n" +
        "支付{1}？",
      "Tenía licencias de programas A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Pero ya no son válidas.\r\n" +
        "Puede usar el saldo de su cuenta para comprar nuevas licencias.\r\n\r\n" +
        "¿Pagar {1}?",
      "Vous aviez des licences de programmes A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Mais elles ne sont plus valides.\r\n" +
        "Vous pouvez utiliser le solde de votre compte pour acheter de nouvelles licences.\r\n\r\n" +
        "Payer {1}?",
      "A>V>C> program lisanslarınız vardı:\r\n" +
        "{0}.\r\n" +
        "Ancak artık geçerli değiller.\r\n" +
        "Yeni lisanslar satın almak için hesap bakiyenizi kullanabilirsiniz.\r\n\r\n" +
        "{1} öde?"};

    public static readonly string[] OfferPay1 = {
      "Your license for {0} is no longer valid.\r\n" +
        "To buy a new license you need to top up your account with {1}",
      "Ваша лицензия на программу {0} уже не действительна.\r\n" +
        "Чтоб купить новую лицензию вам надо пополнить ваш аккаунт на {1}",
      "La tua licenza per {0} non è più valida.\r\n" +
        "Per acquistare una nuova licenza devi ricaricare il tuo account con {1}",
      "Ihre Lizenz für {0} ist nicht mehr gültig.\r\n" +
        "Um eine neue Lizenz zu kaufen, müssen Sie Ihr Konto mit {1} aufladen.",
      "您的 {0} 许可证不再有效。\r\n" +
        "要购买新许可证，您需要使用 {1} 为您的帐户充值",
      "Su licencia para {0} ya no es válida.\r\n" +
        "Para comprar una nueva licencia necesita recargar su cuenta con {1}",
      "Votre licence pour {0} n'est plus valide.\r\n" +
        "Pour acheter une nouvelle licence, vous devez recharger votre compte avec {1}",
      "{0} için lisansınız artık geçerli değil.\r\n" +
        "Yeni bir lisans satın almak için hesabınızı {1} ile doldurmanız gerekiyor"};

    public static readonly string[] OfferPayMany = {
      "You had licenses for A>V>C> programs:\r\n" +
        "{0}.\r\n" +
        "But they are no longer valid.\r\n" +
        "To buy new licenses you need to top up your account with {1} euro",
      "У вас были лицензии на программы A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Но все они уже не действительны.\r\n" +
        "Чтоб купить новые лицензии вам надо пополнить ваш аккаунт на {1} евро",
      "Avevi licenze per i programmi A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Ma non sono più validi.\r\n" +
        "Per acquistare nuove licenze devi ricaricare il tuo account con {1} euro.",
      "Sie hatten Lizenzen für die A>V>C>-Programme:\r\n" +
        "{0}.\r\n" +
        "Aber sie sind nicht mehr gültig.\r\n" +
        "Um neue Lizenzen zu kaufen, müssen Sie Ihr Konto mit {1} Euro aufladen.",
      "您拥有程序 A>V>C> 的许可证：\r\n" +
        "{0}。\r\n" +
        "但它们不再有效。\r\n" +
        "要购买新的许可证，您需要为您的帐户充值 {1} 欧元。",
      "Tenía licencias para programas A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Pero ya no son válidas.\r\n" +
        "Para comprar nuevas licencias necesita recargar su cuenta con {1} euros",
      "Vous aviez des licences pour les programmes A>V>C>:\r\n" +
        "{0}.\r\n" +
        "Mais elles ne sont plus valides.\r\n" +
        "Pour acheter de nouvelles licences, vous devez recharger votre compte avec {1} euros",
      "A>V>C> programları için lisanslarınız vardı:\r\n" +
        "{0}.\r\n" +
        "Ancak artık geçerli değiller.\r\n" +
        "Yeni lisanslar satın almak için hesabınızı {1} euro ile doldurmanız gerekiyor"};

    //============================================= Programs =======================================
    //public static readonly string[] Paid = { "Paid", "Оплачено", "Pagato", "Bezahlt" };

    public static readonly string[] Program = {
      "Program",
      "Программа",
      "Programma",
      "Programm",
      "程序",
      "Programa",
      "Programme",
      "Program"};

    public static readonly string[] ThisProgram = {
      "This program",
      "Эта программа",
      "Questo programma",
      "Dieses Programm",
      "这个节目",
      "Este programa",
      "Ce programme",
      "Bu program"};

    public static readonly string[] Tag = {
      "Tag",
      "Тэг",
      "Etichetta",
      "Schild",
      "标签",
      "Etiqueta",
      "Étiquette",
      "Etiket"};

    public static readonly string[] Description = {
      "Description",
      "Описание",
      "Descrizione",
      "Beschreibung",
      "描述",
      "Descripción",
      "Description",
      "Açıklama"};

    public static readonly string[] Section = {
      "Section",
      "Раздел",
      "Sezione",
      "Abschnitt",
      "部分",
      "Sección",
      "Section",
      "Bölüm"};

    public static readonly string[] CostAnnual = {
      "Cost Annual",
      "Цена за год",
      "Prezzo all'anno",
      "Preis pro Jahr",
      "每年价格",
      "Costo anual",
      "Coût annuel",
      "Yıllık maliyet"};

    public static readonly string[] CostUnlimited = {
      "Cost Unlimited",
      "Цена Навсегда",
      "Prezzo per sempre",
      "Preis für immer",
      "永远的价格",
      "Costo ilimitado",
      "Coût illimité",
      "Sınırsız maliyet"};

    public static readonly string[] VersionMonth = {
      "Version - Month",
      "Версия - Месяц",
      "Versione / Anno",
      "Version / Jahr",
      "版本 / 年",
      "Versión - Mes",
      "Version - Mois",
      "Sürüm - Ay"};

    public static readonly string[] VersionYear = {
      "Version - Year",
      "Версия - Год",
      "Versione/mese",
      "Version / Monat",
      "版本 / 月",
      "Versión - Año",
      "Version - Année",
      "Sürüm - Yıl"};

    public static readonly string[] ProgramsTitle = {
      "A>V>C> Programs",
      "Программы A>V>C>",
      "Programmi A>V>C>",
      "A>V>C>-Programme",
      "A>V>C> 程序",
      "Programas A>V>C>",
      "Programmes A>V>C>",
      "A>V>C> Programları"};

    public static readonly string[] Command = {
      "Command",
      "Команда",
      "Comando",
      "Befehl",
      "命令",
      "Comando",
      "Commande",
      "Komut"};

    public static readonly string[] Commands = {
      "Commands",
      "Команды",
      "Comandi",
      "Befehle",
      "命令",
      "Comandos",
      "Commandes",
      "Komutlar"};

    public static readonly string[] AllPrograms = {
      "Select the program you want to install or activate.",
      "Выберите программу которую вы хотите установить или активировать.",
      "Seleziona il programma che desideri installare o attivare.",
      "Wählen Sie das Programm aus, das Sie installieren oder aktivieren möchten.",
      "选择您要安装或激活的程序。",
      "Seleccione el programa que desea instalar o activar.",
      "Sélectionnez le programme que vous souhaitez installer ou activer.",
      "Yüklemek veya etkinleştirmek istediğiniz programı seçin."};

    public static readonly string[] NoProgram = {
      "All installed A>V>C> programs are already activated",
      "Все установленные программы A>V>C> уже активированы",
      "Tutti i programmi A>V>C> installati sono già attivati",
      "Alle installierten A>V>C>-Programme sind bereits aktiviert",
      "所有已安装的 A>V>C> 程序都已激活",
      "Todos los programas A>V>C> instalados ya están activados",
      "Tous les programmes A>V>C> installés sont déjà activés",
      "Yüklü tüm A>V>C> programları zaten etkinleştirildi"};

    public static readonly string[] OneProgram = {
      "Click on the program icon to activate it.\r\n",
      "Кликните по иконке программы, чтоб активировать ее.\r\n",
      "Fare clic sull'icona del programma per attivarlo.\r\n",
      "Klicken Sie auf das Programmsymbol, um es zu aktivieren.\r\n",
      "单击程序图标以激活它\r\n",
      "Haga clic en el icono del programa para activarlo.\r\n",
      "Cliquez sur l'icône du programme pour l'activer.\r\n",
      "Etkinleştirmek için program simgesine tıklayın.\r\n"};

    public static readonly string[] ProgramQuery4Command = {
      "To use the command {0} you need to activate one of the programs From the list.\r\n",
      "Чтобы использовать команду {0} вам необходимо активировать одну из программ из списка.\r\n",
      "Per utilizzare il comando {0} è necessario attivare uno dei programmi dall'elenco.\r\n",
      "Um den Befehl {0} verwenden zu können, müssen Sie eines der Programme aus der Liste aktivieren.\r\n",
      "要使用命令 {0}，您需要从列表中激活其中一个程序。\r\n",
      "Para usar el comando {0} debe activar uno de los programas de la lista.\r\n",
      "Pour utiliser la commande {0}, vous devez activer l'un des programmes de la liste.\r\n",
      "{0} komutunu kullanmak için listeden programlardan birini etkinleştirmeniz gerekir.\r\n"};

    public static readonly string[] FreeProgram = {
      "Free software also needs to be activated.",
      "Бесплатные программы тоже требуется активировать.",
      "Anche il software gratuito deve essere attivato.",
      "Freie Software muss ebenfalls aktiviert werden.",
      "免费软件也需要激活。",
      "El software gratuito también debe activarse.",
      "Les logiciels gratuits doivent également être activés.",
      "Ücretsiz yazılımın da etkinleştirilmesi gerekir."};

    public static readonly string[] ProgramsHint = {
      "Each program can include several functions or commands.\r\n" +
        "Free software must also be activated.Paid programs can be tried for {0} days.\r\n"+
        "You can ask A>V>C> to sponsor your use of the program in exchange for advertising, " +
        "help with debugging, and translation into your language.",
      "Каждая программа может включать в себя несколько функций или команд.\r\n " +
        "Бесплатные программы тоже надо активировать. Платные программы можно опробовать в течение {0} дней.\r\n " +
        "Вы можете попросить A>V>C> спонсировать ваше использование программы в обмен на рекламу, " +
        "помощь с отладкой и перевод на ваш язык.",
      "Ogni programma può includere diverse funzioni o comandi.\r\n " +
        "È necessario attivare anche il software gratuito.\r\n" +
        "I programmi a pagamento possono essere provati per {0} giorni. " +
        "Puoi chiedere ad A>V>C> di sponsorizzare il tuo utilizzo del programma in cambio di pubblicità, " +
        "aiuto con il debug e traduzione nella tua lingua.",
      "Jedes Programm kann mehrere Funktionen oder Befehle enthalten.\r\n" +
        "Kostenlose Software muss ebenfalls aktiviert sein. " +
        "Bezahlte Programme können {0} Tage lang ausprobiert werden.\r\n" +
        "Sie können A>V>C> bitten, Ihre Nutzung des Programms im Austausch " +
        "für Werbung, Hilfe beim Debuggen und Übersetzung in Ihre Sprache zu sponsern.",
      "每个程序可以包含多个函数或命令。\r\n" +
         "还必须激活免费软件。付费程序可以试用 {0} 天。\r\n"+
         "您可以要求 A>V>C> 赞助您使用该程序，以换取广告、帮助调试和翻译成您的语言。",
      "Cada programa puede incluir varias funciones o comandos.\r\n" +
        "El software gratuito también debe activarse. Los programas de pago se pueden probar durante {0} días.\r\n" +
        "Puede pedirle a A>V>C> que patrocine su uso del programa a cambio de publicidad, " +
        "ayuda con la depuración y traducción a su idioma.",
      "Chaque programme peut inclure plusieurs fonctions ou commandes.\r\n" +
        "Les logiciels gratuits doivent également être activés. Les programmes payants peuvent être essayés pendant {0} jours.\r\n" +
        "Vous pouvez demander à A>V>C> de parrainer votre utilisation du programme en échange de publicité, " +
        "d'aide au débogage et de traduction dans votre langue.",
      "Her program birkaç işlev veya komut içerebilir.\r\n" +
        "Ücretsiz yazılımların da etkinleştirilmesi gerekir. Ücretli programlar {0} gün boyunca denenebilir.\r\n" +
        "A>V>C>'den reklam, hata ayıklama konusunda yardım ve dilinize çeviri karşılığında " +
        "programı kullanmanıza sponsor olmasını isteyebilirsiniz."};

    public static readonly string[] NotNeeded = {
      "There is no point in installing this program.\r\n" +
        "You already have an activated collection with the same commands.",
      "Нет смысла устанавливать эту программу.\r\n" +
        "У вас уже есть активированный сборник с теми же командами.",
      "Non ha senso installare questo programma.\r\n" +
        "Hai già una raccolta attivata con gli stessi comandi.",
      "Es macht keinen Sinn, dieses Programm zu installieren.\r\n" +
        "Sie haben bereits eine aktivierte Sammlung mit denselben Befehlen.",
      "安装这个程序没有意义。\r\n" +
         "你已经有一个使用相同命令的激活集合。",
      "No tiene sentido instalar este programa.\r\n" +
        "Ya tiene una colección activada con los mismos comandos.",
      "Il n'y a aucun intérêt à installer ce programme.\r\n" +
        "Vous avez déjà une collection activée avec les mêmes commandes.",
      "Bu programı yüklemenin bir anlamı yok.\r\n" +
        "Zaten aynı komutlara sahip etkinleştirilmiş bir koleksiyonunuz var."};

    public static readonly string[] Repeated = {
      "It is recommended to uninstall this program. All commands From this program are in your collection.",
      "Рекомендуется удалить эту программу. Все команды из этой программы есть у вас в сборнике.",
      "Si consiglia di disinstallare questo programma. Tutti i comandi di questo programma sono nella tua raccolta.",
      "Es wird empfohlen, dieses Programm zu deinstallieren. " +
        "Alle Befehle dieses Programms befinden sich in Ihrer Sammlung.",
      "建议卸载此程序。 该程序的所有命令都在您的集合中。",
      "Se recomienda desinstalar este programa. Todos los comandos de este programa están en su colección.",
      "Il est recommandé de désinstaller ce programme. Toutes les commandes de ce programme sont dans votre collection.",
      "Bu programı kaldırmanız önerilir. Bu programdaki tüm komutlar koleksiyonunuzda."};

    public static readonly string[] InstallQuery = {
      "Install the '{0}' plugin on this computer?\r\n Close CAD is required.",
      "Установить плагин '{0}' на этот компьютер?\r\n Требуется закрыть CAD.",
      "Installare un plugin '{0}' su questo computer?\r\n È necessario chiudere CAD.",
      "Ein '{0}' Plugin auf diesem Computer installieren?\r\n Ein geschlossenes CAD ist erforderlich.",
      "建议卸载此程序。 此程序的所有命令都在您的集合中。在这台计算机上安装'{0}'插件吗？\r\n 需要关闭 CAD。",
      "¿Instalar el complemento '{0}' en esta computadora?\r\n Se requiere cerrar CAD.",
      "Installer le plug-in '{0}' sur cet ordinateur?\r\n La fermeture de CAD est requise.",
      "Bu bilgisayara '{0}' eklentisi yüklensin mi?\r\n CAD'i kapatmak gereklidir."};

    public static readonly string[] InstallExeNotExist = {
      "Install program file not found. {0}",
      "Не найден файл программы установки {0}",
      "File di installazione non trovato. {0} ",
      "Installationsdatei nicht gefunden. {0}",
      "未找到安装程序文件。 {0}",
      "No se encontró el archivo del programa de instalación. {0}",
      "Fichier du programme d'installation introuvable. {0}",
      "Yükleme programı dosyası bulunamadı. {0}"};

    public static readonly string[] RunError = {
      "Error starting the installer: {0}",
      "Ошибка при запуске программы установки: {0}",
      "Errore durante l'avvio del programma di installazione: {0}",
      "Fehler beim Starten des Installationsprogramms: {0}",
      "启动安装程序时出错：{0}",
      "Error al iniciar el instalador: {0}",
      "Erreur lors du démarrage de l'installateur: {0}",
      "Yükleyici başlatılırken hata: {0}"};

    public static readonly string[] CommandUsed = {
      "Plugin A>V>C> {0} cannot register command named '{1}' because such command is already registered.",
      "Плагин A>V>C> {0} не может зарегистрировать команду с именем '{1}', потому что такая команда уже зарегистрирована. ",
      "Il plug-in A>V>C> {0} non può registrare il comando denominato '{1}' perché tale comando è già registrato.",
      "Plugin A>V>C> {0} kann den Befehl '{1}' nicht registrieren, da dieser Befehl bereits registriert ist.",
      "插件 A>V>C> {0} 无法注册名为'{1}'的命令，因为该命令已注册。",
      "El complemento A>V>C> {0} no puede registrar el comando llamado '{1}' porque ya está registrado.",
      "Le plug-in A>V>C> {0} ne peut pas enregistrer la commande nommée '{1}' car cette commande est déjà enregistrée.",
      "A>V>C> {0} eklentisi '{1}' adlı komutu kaydedemez çünkü bu komut zaten kayıtlı."};

    public static readonly string[] HasStyles = {
      "Managed by styles",
      "Управляется стилями",
      "Gestito da stili",
      "Verwaltet nach Stilen",
      "按样式管理",
      "Gestionado por estilos",
      "Géré par styles",
      "Stiller tarafından yönetilir"};

    public static readonly string[] RegKey = {
      "Registry key",
      "Ключ реестра",
      "Chiave di registro",
      "Registrierungsschlüssel",
      "注册表项",
      "Clave de registro",
      "Clé de registre",
      "Kayıt defteri anahtarı"};

    public static readonly string[] HelpPage = {
      "Help Page",
      "Страница",
      "Pagina di aiuto",
      "Hilfeseite",
      "帮助页面",
      "Página de ayuda",
      "Page d'aide",
      "Yardım Sayfası"};

    //========================== Client ========================================================

    public static readonly string[] Client = {
      "Client",
      "Клиент",
      "Cliente",
      "Klient",
      "客户",
      "Cliente",
      "Client",
      "Müşteri"};

    public static readonly string[] Clients = {
      "Clients",
      "Клиенты",
      "Clienti",
      "Kunden",
      "客户",
      "Clientes",
      "Clients",
      "Müşteriler"};

    public static readonly string[] Mail = {
      "Email",
      "E-mail",
      "E-mail",
      "Email",
      "电子邮件",
      "Correo electrónico",
      "E-mail",
      "E-posta"};

    public static readonly string[] PasswordMd5 = {
      "Password hash",
      "Хэш пароля",
      "Hash della password",
      "Passwort-Hash",
      "密码哈希",
      "Hash de contraseña",
      "Hachage du mot de passe",
      "Şifre hash'i"};

    public static readonly string[] Manager = {
      "Manager",
      "Руководитель",
      "Manager",
      "Manager",
      "经理",
      "Gerente",
      "Manager",
      "Yönetici"};

    public static readonly string[] ManagerTip = {
      "Your project team leader or system administrator.\r\n" +
        "Please enter an email address that is already registered on the A>V>C> server.\r\n" +
        "WARNING! Your manager can transfer funds and licenses from your account! ",
      "Руководитель вашей проектной группы или системный администратор. \r\n" +
        "Укажите e-mail, который уже зарегестрирован на сервере A>V>C>.\r\n" +
        "ВНИМАНИЕ! Руководитель может перемещать деньги и лицензии вашего аккаунта!",
      "Il tuo team leader di progetto o amministratore di sistema. \r\n" +
        "Si prega di inserire un indirizzo e-mail che è già registrato sul server A>V>C>.\r\n" +
        "ATTENZIONE! Il tuo manager può trasferire fondi e licenze dal tuo account!",
      "Ihr Projektteamleiter oder Systemadministrator. \r\n" +
        "Bitte geben Sie eine E-Mail-Adresse ein, die bereits auf dem A>V>C>-Server registriert ist.\r\n" +
        "WARNUNG! Ihr Manager kann Gelder und Lizenzen von Ihrem Konto übertragen!",
      "您的项目团队负责人或系统管理员。 \r\n" +
        "请输入一个已经在 A>V>C> 服务器上注册的电子邮件地址。\r\n" +
        "警告！您的经理可以从您的帐户转移资金和许可证！",
      "El líder de su equipo de proyecto o administrador del sistema. \r\n" +
        "Ingrese una dirección de correo electrónico que ya esté registrada en el servidor A>V>C>.\r\n" +
        "¡ADVERTENCIA! ¡Su gerente puede transferir fondos y licencias de su cuenta!",
      "Votre chef d'équipe de projet ou administrateur système. \r\n" +
        "Veuillez entrer une adresse e-mail qui est déjà enregistrée sur le serveur A>V>C>.\r\n" +
        "ATTENTION! Votre manager peut transférer des fonds et des licences de votre compte!",
      "Proje takım lideriniz veya sistem yöneticiniz. \r\n" +
        "Lütfen A>V>C> sunucusunda zaten kayıtlı olan bir e-posta adresi girin.\r\n" +
        "UYARI! Yöneticiniz hesabınızdaki fonları ve lisansları transfer edebilir!"};

    public static readonly string[] ManagerHint = {
      "You can delegate the management of your balance and licenses to another A>V>C> user.\r\n" +
        "Enter your manager's email or leave the field blank.",
      "Вы можете доверить управление вашим балансом и лицензиями другому пользователю A>V>C>.\r\n" +
        "Укажите email вашего руководителя или оставьте поле пустым.",
      "Puoi delegare la gestione del tuo saldo e delle tue licenze a un altro utente A>V>C>.\r\n" +
        "Inserisci l'e-mail del tuo manager o lascia il campo vuoto.",
      "Sie können die Verwaltung Ihres Guthabens und Ihrer Lizenzen an einen anderen A>V>C>-Benutzer delegieren.\r\n" +
        "Geben Sie die E-Mail-Adresse Ihres Managers ein oder lassen Sie das Feld leer.",
      "您可以将您的余额和许可证的管理权限委托给另一个 A>V>C> 用户。\r\n" +
        "输入您经理的电子邮件或将该字段留空。",
      "Puede delegar la gestión de su saldo y licencias a otro usuario de A>V>C>.\r\n" +
        "Ingrese el correo electrónico de su gerente o deje el campo en blanco.",
      "Vous pouvez déléguer la gestion de votre solde et de vos licences à un autre utilisateur A>V>C>.\r\n" +
        "Entrez l'e-mail de votre manager ou laissez le champ vide.",
      "Bakiye ve lisanslarınızın yönetimini başka bir A>V>C> kullanıcısına devredebilirsiniz.\r\n" +
        "Yöneticinizin e-postasını girin veya alanı boş bırakın."};

    public static readonly string[] Country = {
      "Country",
      "Страна",
      "Paese",
      "Land",
      "国家",
      "País",
      "Pays",
      "Ülke"};

    public static readonly string[] Registered = {
      "Registered",
      "Зарегистрирован",
      "Data di registrazione",
      "Registrierungsdatum",
      "注册日期",
      "Registrado",
      "Enregistré",
      "Kayıtlı"};

    public static readonly string[] RegisteredFromWorkplace = {
      "Registered From Workplace",
      "Регистрация с рабочего места",
      "Registrato da Workplace",
      "Registriert von Workplace",
      "从工作场所注册",
      "Registrado desde el lugar de trabajo",
      "Enregistré depuis le lieu de travail",
      "İşyerinden kaydoldu"};

    public static readonly string[] NeedMail = {
      "You must enter your e-mail on the Account tab",
      "Необходимо ввести ваш e-mail на закладке Учетная Запись",
      "Devi inserire la tua e-mail nella scheda Account",
      "Sie müssen Ihre E-Mail-Adresse eingeben auf der Account Konto",
      "您必须在'帐户'选项卡上输入您的电子邮件",
      "Debe ingresar su correo electrónico en la pestaña Cuenta",
      "Vous devez saisir votre e-mail dans l'onglet Compte",
      "Hesap sekmesine e-postanızı girmelisiniz"};

    public static readonly string[] PasswordErr = {
      "Wrong password.",
      "Пароль неверный.",
      "Password errata.",
      "Falsches Passwort.",
      "密码错误。",
      "Contraseña incorrecta.",
      "Mot de passe incorrect.",
      "Yanlış şifre."};

    public static readonly string[] MailErr = {
      "Error. Please enter a valid email address.",
      "Ошибка. Укажите корректный адрес email.",
      "Errore. Si prega di inserire un indirizzo email valido.",
      "Error. Bitte geben Sie eine gültige E-Mail-Adresse ein.",
      "错误。 请输入有效的电子邮件地址。",
      "Error. Por favor ingrese una dirección de correo electrónico válida.",
      "Erreur. Veuillez entrer une adresse e-mail valide.",
      "Hata. Lütfen geçerli bir e-posta adresi girin."};

    public static readonly string[] NoMail = {
      "The user's e-mail is not specified. Unable to activate A>V>C> programs.",
      "Не указан e-mail пользователя. Невозможно активировать программы A>V>C>.",
      "L'e-mail dell'utente non è specificata. Impossibile attivare i programmi A>V>C>.",
      "Die E-Mail-Adresse des Benutzers ist nicht angegeben. Programme A>V>C> können nicht aktiviert werden.",
      "未指定用户的电子邮件。 无法激活 A>V>C> 程序。",
      "No se especifica el correo electrónico del usuario. No se pueden activar los programas A>V>C>.",
      "L'e-mail de l'utilisateur n'est pas spécifié. Impossible d'activer les programmes A>V>C>.",
      "Kullanıcının e-postası belirtilmemiş. A>V>C> programları etkinleştirilemiyor."};

    public static readonly string[] MailMissing = {
      "User {0} is missing From the database.",
      "Пользователь {0} отсутствует в базе данных.",
      "L'utente {0} non è presente nel database.",
      "L'utente {0} non è presente nel database.",
      "数据库中缺少用户 {0}。",
      "Falta el usuario {0} en la base de datos.",
      "L'utilisateur {0} est absent de la base de données.",
      "Kullanıcı {0} veritabanında eksik."};

    public static readonly string[] ManagerEqMail = {
      "Please enter the email address of another employee in your organization, not your personal email address.\r\n" +
        "If you use the same account for everyone, don't specify the manager's email address at all.",
      "Укажите почту другого сотрудника вашей организации, а не вашу личную. \r\n" +
        "Если вы используете один аккаунт на всех, то не указывайте руководителя вообще.",
      "Si prega di inserire l'indirizzo e-mail di un altro dipendente della tua organizzazione, non il tuo indirizzo e-mail personale.\r\n" +
        "Se usi lo stesso account per tutti, non specificare affatto l'indirizzo e-mail del manager.",
      "Bitte geben Sie die E-Mail-Adresse eines anderen Mitarbeiters in Ihrer Organisation ein, nicht Ihre persönliche E-Mail-Adresse.\r\n" +
        "Wenn Sie dasselbe Konto für alle verwenden, geben Sie die E-Mail-Adresse des Managers überhaupt nicht an.",
      "请输入您组织中另一位员工的电子邮件地址，而不是您的个人电子邮件地址。\r\n" +
        "如果您为每个人使用同一个帐户，请完全不要指定经理的电子邮件地址。",
      "Ingrese la dirección de correo electrónico de otro empleado en su organización, no su dirección de correo electrónico personal.\r\n" +
        "Si usa la misma cuenta para todos, no especifique la dirección de correo electrónico del gerente en absoluto.",
      "Veuillez entrer l'adresse e-mail d'un autre employé de votre organisation, pas votre adresse e-mail personnelle.\r\n" +
        "Si vous utilisez le même compte pour tout le monde, ne spécifiez pas du tout l'adresse e-mail du manager.",
      "Lütfen kişisel e-posta adresiniz değil, kuruluşunuzdaki başka bir çalışanın e-posta adresini girin.\r\n" +
        "Herkes için aynı hesabı kullanıyorsanız, yönetici e-posta adresini hiç belirtmeyin."};

    public static readonly string[] NotEnoughFunds = {
      "There are not enough funds in your account.\r\n" +
        "Refill your account with EUR {0:0}.\r\n" +
        "When paying, enter your e-mail {1}.\r\n" +
        "Then wait until the money is credited to your account (up to three days).\r\n" +
        "Top up?",
      "На вашем счету недостаточно средств.\r\n" +
        "Пополните счет на {0:0} EUR\r\n" +
        "При оплате укажите ваш e-mail {1}.\r\n" +
        "Затем дождитесь, когда деньги поступят на ваш счет (до трех дней).\r\n" +
        "Пополнить?",
      "Non ci sono fondi sufficienti nel tuo account.\r\n" +
        "Riempi il tuo account con {0:0} EUR\r\n" +
        "Quando paghi, inserisci la tua e-mail {1}.\r\n" +
        "Quindi attendi fino a quando il denaro viene accreditato sul tuo account (fino a tre giorni).\r\n" +
        "Riempire? ",
      "Ihr Konto enthält nicht genügend Guthaben.\r\n" +
        "Füllen Sie Ihr Konto mit {0:0} EUR auf.\r\n" +
        "Geben Sie beim Bezahlen Ihre E-Mail-Adresse {1} ein.\r\n" +
        "Warten Sie dann, bis das Geld Ihrem Konto gutgeschrieben wurde (bis zu drei Tage).\r\n" +
        "Aufladen? ",
      "您的帐户中没有足够的资金。\r\n" +
        "为您的帐户充值 {0:0} 欧元。\r\n" +
        "付款时，请输入您的电子邮箱 {1}。\r\n" +
        "然后等到钱存入您的帐户（最多三天）。\r\n" +
        "充值？",
      "No hay fondos suficientes en su cuenta.\r\n" +
        "Recargue su cuenta con EUR {0:0}.\r\n" +
        "Al pagar, ingrese su correo electrónico {1}.\r\n" +
        "Luego espere hasta que el dinero se acredite en su cuenta (hasta tres días).\r\n" +
        "¿Recargar?",
      "Il n'y a pas assez de fonds sur votre compte.\r\n" +
        "Rechargez votre compte avec EUR {0:0}.\r\n" +
        "Lors du paiement, entrez votre e-mail {1}.\r\n" +
        "Attendez ensuite que l'argent soit crédité sur votre compte (jusqu'à trois jours).\r\n" +
        "Recharger?",
      "Hesabınızda yeterli fon yok.\r\n" +
        "Hesabınızı EUR {0:0} ile doldurun.\r\n" +
        "Ödeme yaparken e-postanızı {1} girin.\r\n" +
        "Ardından paranın hesabınıza yatırılmasını bekleyin (üç güne kadar).\r\n" +
        "Yükle?"};

    public static readonly string[] BalanceInfo = {
      "Your account balance: EUR {0:0}",
      "Баланс вашего аккаунта: {0:0} EUR",
      "Saldo del tuo account: {0:0} EUR",
      "Ihr Kontostand: {0:0} EUR",
      "您的帐户余额：欧元 {0:0}",
      "Saldo de su cuenta: EUR {0:0}",
      "Solde de votre compte: EUR {0:0}",
      "Hesap bakiyeniz: EUR {0:0}"};

    public static readonly string[] ChangePassword = {
      "Change password",
      "Сменить пароль",
      "Cambia la password",
      "Ändere das Passwort",
      "密码",
      "Cambiar contraseña",
      "Changer le mot de passe",
      "Şifreyi değiştir"};

    public static readonly string[] AccountBalance = {
      "Account Balance",
      "Баланс учетной записи",
      "Saldo del conto",
      "Kontostand",
      "账户余额",
      "Saldo de cuenta",
      "Solde du compte",
      "Hesap Bakiyesi"};

    public static readonly string[] AccountBalanceClickTip = {
      "Click to reload balance From A>V>C> server",
      "Кликни, чтоб перезагрузить баланс с сервера A>V>C>",
      "Fare clic per ricaricare il saldo dal server A>V>C>",
      "Klicken Sie hier, um das Guthaben vom A>V>C>-Server neu zu laden.",
      "单击可从 A>V>C> 服务器重新加载平衡。",
      "Haga clic para recargar el saldo desde el servidor A>V>C>",
      "Cliquez pour recharger le solde depuis le serveur A>V>C>",
      "A>V>C> sunucusundan bakiyeyi yeniden yüklemek için tıklayın"};

    public static readonly string[] AccountBalanceTip = {
      "A virtual amount that can only be used to activate programs A>V>C>. \r\n" +
        "The amount depends on your donations. " +
        "Also you can ask A>V>C> to sponsor your use of the program in exchange for advertising, " +
        "help with debugging, and translation into your language.",
      "Виртуальная сумма, которую можно использовать только для активации программ A>V>C>. \r\n" +
        "Сумма зависит от ваших пожертвований, покупок в магазинах приложений (Autodesk и др.). " +
        "Также вы можете попросить A>V>C> спонсировать ваше использование программы в обмен на рекламу, " +
        "помощь с отладкой и перевод на ваш язык.",
      "Un importo virtuale che può essere utilizzato solo per attivare i programmi A>V>C>. "+
         "L'importo dipende dalle tue donazioni. " +
        "Inoltre puoi chiedere ad A>V>C> di sponsorizzare il tuo utilizzo del programma in cambio di pubblicità, " +
        "aiuto con il debug e la traduzione nella tua lingua.",
      "Ein virtueller Betrag, der nur zur Aktivierung der Programme A>V>C> verwendet werden kann."+
         "Der Betrag hängt von Ihren Spenden ab. Sie können A>V>C> auch bitten, " +
        "Ihre Nutzung des Programms im Austausch für Werbung, " +
        "Hilfe bei der Fehlersuche und Übersetzung in Ihre Sprache zu sponsern.",
      "只能用于激活程序 A>V>C> 的虚拟数量。 \r\n" +
         "金额取决于您的捐款。您也可以要求 A>V>C> 赞助您使用该程序，以换取广告、帮助调试和翻译成您的语言。",
      "Una cantidad virtual que solo se puede usar para activar programas A>V>C>. \r\n" +
        "La cantidad depende de sus donaciones. " +
        "También puede pedirle a A>V>C> que patrocine su uso del programa a cambio de publicidad, " +
        "ayuda con la depuración y traducción a su idioma.",
      "Un montant virtuel qui ne peut être utilisé que pour activer les programmes A>V>C>. \r\n" +
        "Le montant dépend de vos dons. " +
        "Vous pouvez également demander à A>V>C> de parrainer votre utilisation du programme en échange de publicité, " +
        "d'aide au débogage et de traduction dans votre langue.",
      "Yalnızca A>V>C> programlarını etkinleştirmek için kullanılabilen sanal bir miktar. \r\n" +
        "Miktar bağışlarınıza bağlıdır. " +
        "Ayrıca A>V>C>'den reklam, hata ayıklama konusunda yardım ve dilinize çeviri karşılığında " +
        "programı kullanmanıza sponsor olmasını isteyebilirsiniz."};

    public static readonly string[] YourEmail = {
      "Your Email",
      "Ваш E-mail",
      "La tua email",
      "Deine E-Mail",
      "你的邮箱",
      "Su correo electrónico",
      "Votre e-mail",
      "E-postanız"};

    public static readonly string[] EmailTip = {
      "Enter your real address. \r\n" +
        "Use this address for payment for programs and to write a letter to technical support. \r\n" +
        "Your email address will not be shared with a third party.",
      "Введите ваш действительный адрес электронной почты. \r\n" +
        "Используйте этот адрес при оплате программ и обращениях в техподдержку.",
      "Inserisci il tuo indirizzo e-mail valido. \r\n" +
        "Utilizzare questo indirizzo quando si pagano programmi e si contatta il supporto tecnico.",
      "Bitte geben Sie Ihre gültige E-Mail-Adresse ein. \r\n" +
        "Verwenden Sie diese Adresse, wenn Sie für Programme bezahlen und den technischen Support kontaktieren.",
      "请输入您的有效电子邮件地址。 \r\n" +
        "在为程序付费和联系技术支持时使用此地址。",
      "Ingrese su dirección real. \r\n" +
        "Use esta dirección para el pago de programas y para escribir una carta al soporte técnico. \r\n" +
        "Su dirección de correo electrónico no se compartirá con terceros.",
      "Entrez votre adresse réelle. \r\n" +
        "Utilisez cette adresse pour le paiement des programmes et pour écrire une lettre au support technique. \r\n" +
        "Votre adresse e-mail ne sera pas partagée avec un tiers.",
      "Gerçek adresinizi girin. \r\n" +
        "Bu adresi programlar için ödeme yapmak ve teknik desteğe mektup yazmak için kullanın. \r\n" +
        "E-posta adresiniz üçüncü taraflarla paylaşılmayacaktır."};

    public static readonly string[] YourName = {
      "Your name",
      "Ваше имя",
      "Il tuo nome",
      "Ihr Name",
      "你的名字",
      "Su nombre",
      "Votre nom",
      "Adınız"};

    public static readonly string[] NameTip = {
      "It is advisable (but not required) to indicate your Name and Surname. This data will be used in correspondence.",
      "Можно указать (но необязательно) ваше Имя и Фамилию. Они будут использоваться в переписке.",
      "Puoi inserire (ma non obbligatorio) il tuo nome e cognome. Saranno utilizzati in corrispondenza.",
      "Sie können (aber nicht erforderlich) Ihren Vor- und Nachnamen eingeben. Sie werden in der Korrespondenz verwendet.",
      "您可以输入（但不是必需的）您的名字和姓氏。 它们将用于通信。",
      "Es recomendable (pero no obligatorio) indicar su nombre y apellido. Estos datos se utilizarán en la correspondencia.",
      "Il est conseillé (mais pas obligatoire) d'indiquer votre nom et prénom. Ces données seront utilisées dans la correspondance.",
      "Adınızı ve soyadınızı belirtmeniz tavsiye edilir (ancak gerekli değildir). Bu veriler yazışmalarda kullanılacaktır."};

    public static readonly string[] Account = {
      "A>V>C> Account",
      "Учетная запись A>V>C>",
      "Conto A>V>C>",
      "Konto A>V>C>",
      "账户 A>V>C>",
      "Cuenta A>V>C>",
      "Compte A>V>C>",
      "A>V>C> Hesabı"};

    public static readonly string[] AccountTip = {
      "A>V>C> Programs identify the user by his email address. \r\n" +
        "Without specifying the address, you will not be able to activate the program.",
      "Программы A>V>C> идентифицируют пользователя по его почтовому адресу. \r\n" +
        "Без указания e-mail вы не сможете активировать программу.",
      "I programmi A>V>C> identificano l'utente tramite il suo indirizzo postale. \r\n" +
        "Senza specificare una e-mail, non potrai attivare il programma.",
      "Die Programme A>V>C> identifizieren den Benutzer anhand seiner Postanschrift. \r\n" +
        "Ohne Angabe einer E-Mail-Adresse können Sie das Programm nicht aktivieren.",
      "程序 A>V>C> 通过用户的邮政地址识别用户。 \r\n" +
        "如果不指定电子邮件，您将无法激活该程序。",
      "Los programas A>V>C> identifican al usuario por su dirección de correo electrónico. \r\n" +
        "Sin especificar la dirección, no podrá activar el programa.",
      "Les programmes A>V>C> identifient l'utilisateur par son adresse e-mail. \r\n" +
        "Sans spécifier l'adresse, vous ne pourrez pas activer le programme.",
      "A>V>C> Programları kullanıcıyı e-posta adresine göre tanımlar. \r\n" +
        "Adresi belirtmeden programı etkinleştiremezsiniz."};

    public static readonly string[] TopUp = {
      "Top up balance",
      "Пополнить баланс",
      "Ricarica il saldo",
      "Guthaben aufladen",
      "充值余额",
      "Recargar saldo",
      "Recharger le solde",
      "Bakiye yükle"};

    public static readonly string[] Donate = {
      "Donate",
      "Пожертвовать",
      "Donare",
      "Spenden",
      "捐",
      "Donar",
      "Faire un don",
      "Bağış yap"};

    public static readonly string[] DonateTip = {
      "Donate any small amount to plug-in development. \r\n" +
        "You can make a donation at any time: \r\n" +
        "because you like the plugins A>V>C> and you want to motivate further development,\r\n" +
        "or if you came up with a great new idea or liked the updates in new versions.\r\n" +
        "Remember that all new features and new versions of A>V>C> plugins are provided for free,\r\n" +
        "but require a lot of development effort.",
      "Пожертвуйте любую небольшую сумму на разработку плагинов. \r\n" +
        "Вы можете сделать пожертвование в любой момент: \r\n" +
        "просто потому что вам нравятся плагины A>V>C> и вы хотите мотивировать дальнейшую разработку\r\n" +
        "или если вам пришла в голову прекрасная новая идея или понравились обновления в новых версиях.\r\n" +
        "Помните, что все новые функции и новые версии плагинов A>V>C> предоставляются бесплатно,\r\n" +
        "но требуют много сил для разработки.",
      "Dona una piccola somma per lo sviluppo del plug-in. "+
         "Puoi fare una donazione in qualsiasi momento: \r\n" +
         "perché ti piacciono i plugin A>V>C> e vuoi motivare un ulteriore sviluppo,\r\n" +
         "o se ti è venuta in mente una nuova fantastica idea o ti sono piaciuti gli aggiornamenti nelle nuove versioni.\r\n" +
         "Ricorda che tutte le nuove funzionalità e le nuove versioni dei plug-in A>V>C> sono fornite gratuitamente,\r\n" +
         "ma richiede molto sforzo di sviluppo.",
      "Spenden Sie einen beliebigen kleinen Betrag für die Plug-in-Entwicklung. "+
        "Spenden können Sie jederzeit: \r\n" +
        "weil dir die Plugins A>V>C> gefallen und du zur Weiterentwicklung motivieren möchtest,\r\n" +
        "oder wenn Ihnen eine tolle neue Idee eingefallen ist oder Ihnen die Updates in neuen Versionen gefallen haben.\r\n" +
        "Denken Sie daran, dass alle neuen Funktionen und neuen Versionen von A>V>C>-Plugins \r\n" +
        "kostenlos zur Verfügung gestellt werden,\r\n" +
        "erfordern aber viel Entwicklungsaufwand.",
      "为插件开发捐赠任何少量资金"+
         "您可以随时捐款：\r\n" +
         "因为您喜欢插件 A>V>C> 并且想要激励进一步的开发，\r\n" +
         "或者如果您想出了一个很棒的新想法或喜欢新版本中的更新。"+
         "请记住，A>V>C> 插件的所有新功能和新版本都是免费提供的，但需要大量的开发工作。",
      "Done cualquier pequeña cantidad al desarrollo de complementos. \r\n" +
        "Puede hacer una donación en cualquier momento: \r\n" +
        "porque le gustan los complementos A>V>C> y desea motivar un mayor desarrollo,\r\n" +
        "o si se le ocurrió una gran idea nueva o le gustaron las actualizaciones en nuevas versiones.\r\n" +
        "Recuerde que todas las nuevas funciones y nuevas versiones de los complementos A>V>C> se proporcionan de forma gratuita,\r\n" +
        "pero requieren mucho esfuerzo de desarrollo.",
      "Faites un don de n'importe quel petit montant au développement de plug-ins. \r\n" +
        "Vous pouvez faire un don à tout moment: \r\n" +
        "parce que vous aimez les plug-ins A>V>C> et que vous souhaitez motiver un développement ultérieur,\r\n" +
        "ou si vous avez eu une nouvelle idée géniale ou aimé les mises à jour dans les nouvelles versions.\r\n" +
        "N'oubliez pas que toutes les nouvelles fonctionnalités et nouvelles versions des plug-ins A>V>C> sont fournies gratuitement,\r\n" +
        "mais nécessitent beaucoup d'efforts de développement.",
      "Eklenti geliştirmeye herhangi bir küçük miktar bağışlayın. \r\n" +
        "İstediğiniz zaman bağış yapabilirsiniz: \r\n" +
        "çünkü A>V>C> eklentilerini seviyorsunuz ve daha fazla geliştirmeyi motive etmek istiyorsunuz,\r\n" +
        "veya harika yeni bir fikriniz varsa veya yeni sürümlerdeki güncellemeleri beğendiyseniz.\r\n" +
        "A>V>C> eklentilerinin tüm yeni özelliklerinin ve yeni sürümlerinin ücretsiz olarak sağlandığını unutmayın,\r\n" +
        "ancak çok fazla geliştirme çabası gerektirir."};

    public static readonly string[] Support = {
      "Support avc.programming@gmail.com",
      "Техподдержка avc.programming@gmail.com",
      "Supporto  avc.programming@gmail.com",
      "Die Unterstützung  avc.programming@gmail.com",
      "支持  avc.programming@gmail.com",
      "Soporte avc.programming@gmail.com",
      "Support avc.programming@gmail.com",
      "Destek avc.programming@gmail.com"};

    // ================================================= Offline Activation Dialog ======================================================
    public static readonly string[] OfflineTitle = {
      "Off-line activation",
      "Активация оффлайн",
      "Attivazione offline",
      "Offline-Aktivierung",
      "离线激活",
      "Activación sin conexión",
      "Activation hors ligne",
      "Çevrimdışı etkinleştirme"};

    public static readonly string[] Copy = {
      "Copy to buffer",
      "Копировать в буфер",
      "Copia nel buffer",
      "In Puffer kopieren",
      "复制到缓冲区",
      "Copiar al búfer",
      "Copier dans le tampon",
      "Arabelleğe kopyala"};

    public static readonly string[] Save = {
      "Save to file",
      "Сохранить в файл",
      "Salva su file",
      "Speichern unter",
      "保存到文件",
      "Guardar en archivo",
      "Enregistrer dans un fichier",
      "Dosyaya kaydet"};

    public static readonly string[] OfflineActivateTip = {
      "Wait for the activation key to be sent to your mail. This may take several days. Then call the command and the activation dialog again, enter the key and click OK.",
      "Подождите, пока на вашу почту придет ключ активации. Это может занять несколько дней. Затем снова вызовите команду и диалог активации, введите ключ и нажмите ОК.",
      "Attendi fino a quando la chiave di attivazione non arriva alla tua posta. L'operazione potrebbe richiedere diversi giorni. Quindi richiamare nuovamente il comando e la finestra di dialogo di attivazione, immettere la chiave e fare clic su OK.",
      "Warten Sie, bis Sie den Aktivierungsschlüssel per Post erhalten. Dies kann mehrere Tage dauern. Rufen Sie dann den Befehl und den Aktivierungsdialog erneut auf, geben Sie den Schlüssel ein und klicken Sie auf OK.",
      "等到激活密钥到达您的邮件。 这可能需要几天时间。 然后再次调用命令和激活对话框，输入密钥并单击确定。",
      "Espere a que la clave de activación se envíe a su correo. Esto puede llevar varios días. Luego llame al comando y al diálogo de activación nuevamente, ingrese la clave y haga clic en Aceptar.",
      "Attendez que la clé d'activation soit envoyée à votre courrier. Cela peut prendre plusieurs jours. Appelez ensuite à nouveau la commande et la boîte de dialogue d'activation, entrez la clé et cliquez sur OK.",
      "Etkinleştirme anahtarının postanıza gönderilmesini bekleyin. Bu birkaç gün sürebilir. Ardından komutu ve etkinleştirme iletişim kutusunu tekrar çağırın, anahtarı girin ve Tamam'a tıklayın."};

    public static readonly string[] Key = {
      "Activation key",
      "Ключ активации",
      "Chiave di attivazione",
      "Aktivierungsschlüssel",
      "激活码",
      "Clave de activación",
      "Clé d'activation",
      "Etkinleştirme anahtarı"};

    public static readonly string[] QR = {
      "Alternatively, you can scan this QR code containing the same request code and send it by email From your phone. Use any barcode recognition software. For example, Google Lens.",
      "Как вариант, вы можете отсканировать этот QR - код, содержащий тот же самый код запроса, и отправить его письмом с вашего телефона. Используйте любые программы распознавания штрих - кодов. Например, Google Объектив. Только не надо слать фотографии экрана.",
      "In alternativa, puoi scansionare questo codice QR contenente lo stesso codice di richiesta e inviarlo via email dal tuo telefono. Utilizzare qualsiasi software di riconoscimento dei codici a barre. Ad esempio, Google Lens. Basta non inviare screenshot.",
      "Alternativ können Sie diesen QR-Code mit demselben Anforderungscode scannen und von Ihrem Telefon aus per E-Mail versenden. Verwenden Sie eine beliebige Barcode-Erkennungssoftware. Zum Beispiel Google Lens. Senden Sie einfach keine Screenshots.",
      "或者，您可以扫描包含相同请求代码的二维码，然后通过手机发送电子邮件。 使用任何条码识别软件。 例如，谷歌镜头。 只是不要发送屏幕截图。",
      "Alternativamente, puede escanear este código QR que contiene el mismo código de solicitud y enviarlo por correo electrónico desde su teléfono. Use cualquier software de reconocimiento de códigos de barras. Por ejemplo, Google Lens.",
      "Vous pouvez également scanner ce code QR contenant le même code de demande et l'envoyer par e-mail depuis votre téléphone. Utilisez n'importe quel logiciel de reconnaissance de codes-barres. Par exemple, Google Lens.",
      "Alternatif olarak, aynı istek kodunu içeren bu QR kodunu telefonunuzdan tarayabilir ve e-posta ile gönderebilirsiniz. Herhangi bir barkod tanıma yazılımı kullanın. Örneğin, Google Lens."};

    public static readonly string[] Request = {
      "Request code",
      "Код запроса",
      "Codice richiesto",
      "Anfrage Code",
      "请求代码",
      "Código de solicitud",
      "Code de demande",
      "İstek kodu"};

    public static readonly string[] RequestTip = {
      "Save the request code and send it From your mail to avc.programming@gmail.com",
      "Сохраните код запроса и отправьте его со своей почты на avc.programming@gmail.com",
      "Salva il codice della richiesta e invialo dalla tua mail a avc.programming@gmail.com",
      "Speichern Sie den Anfragecode und senden Sie ihn aus Ihrer Mail an avc.programming@gmail.com",
      "保存请求代码并将其从您的邮件发送到 avc.programming@gmail.com",
      "Guarde el código de solicitud y envíelo desde su correo a avc.programming@gmail.com",
      "Enregistrez le code de demande et envoyez-le depuis votre courrier à avc.programming@gmail.com",
      "İstek kodunu kaydedin ve postanızdan avc.programming@gmail.com'a gönderin"};

    public static readonly string[] OfflineTip = {
      "The program was unable to establish a connection to the A>V>C> database.\r\n" +
        "You can try to activate the program by email From another computer or phone.",
      "Программа не смогла установить соединение с сервером A>V>C>.\r\n" +
        "Вы можете активировать программу по email с другого компьютера или телефона.",
      "Il programma non è stato in grado di stabilire una connessione al database A>V>C>.\r\n" +
         "Puoi provare ad attivare il programma via e-mail da un altro computer o telefono.",
      "Das Programm konnte keine Verbindung zur A>V>C>-Datenbank herstellen.\r\n" +
         "Sie können versuchen, das Programm per E-Mail von einem anderen Computer oder Telefon aus zu aktivieren.",
      "程序无法建立与 A>V>C> 数据库的连接。\r\n" +
         "您可以尝试从另一台计算机或手机通过电子邮件激活该程序。",
      "El programa no pudo establecer una conexión con la base de datos A>V>C>.\r\n" +
        "Puede intentar activar el programa por correo electrónico desde otra computadora o teléfono.",
      "Le programme n'a pas pu établir de connexion à la base de données A>V>C>.\r\n" +
        "Vous pouvez essayer d'activer le programme par e-mail depuis un autre ordinateur ou téléphone.",
      "Program A>V>C> veritabanına bağlantı kuramadı.\r\n" +
        "Programı başka bir bilgisayardan veya telefondan e-posta ile etkinleştirmeyi deneyebilirsiniz."};


    //============================================= Select License Dialog ===================================================
    public static readonly string[] SelectLicenseTitle = {
      "Select license type",
      "Выбор типа лицензии",
      "Selezione di un tipo di licenza",
      "Auswählen eines Lizenztyps",
      "选择许可证类型",
      "Seleccionar tipo de licencia",
      "Sélectionner le type de licence",
      "Lisans türünü seç"};

    public static readonly string[] LicenseTypeQuery = {
      "What license for program {0} do you want to get?",
      "Какую лицензию для программы {0} вы хотите получить?",
      "Quale licenza per il programma {0} desideri ottenere?",
      "Welche Lizenz für das Programm {0} möchten Sie erhalten?",
      "您想获得程序 {0} 的什么许可证？",
      "¿Qué licencia para el programa {0} desea obtener?",
      "Quelle licence pour le programme {0} souhaitez-vous obtenir?",
      "{0} programı için hangi lisansı almak istiyorsunuz?"};

    public static readonly string[] AboutProgram = {
      "More about program",
      "Подробнее о программе",
      "Maggiori informazioni sul programma",
      "Mehr zum Programm",
      "有关该计划的更多信息",
      "Más sobre el programa",
      "Plus d'informations sur le programme",
      "Program hakkında daha fazla"};

    public static readonly string[] Legal = {
      "Legal liability",
      "Обязательства",
      "Responsabilità legale",
      "Gesetzliche Haftung",
      "法律责任",
      "Responsabilidad legal",
      "Responsabilité légale",
      "Yasal sorumluluk"};


  }
}
