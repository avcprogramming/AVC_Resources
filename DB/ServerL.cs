// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using static System.String;

namespace AVC
{
  /// <summary>
  /// Локализация сообщений с сервера AVC.
  /// Английские текст менять нельзя!!  Они зашиты в хранимки SQL 
  /// </summary>
  public static class
  ServerL
  {
    public static readonly string[] ReadonlyServer = {
      "This server is readonly. Try updating the plugin.",
      "Этот сервер работает в режиме только для чтения (запасной). Попробуйте обновить плагин.",
      "Questo server è in esecuzione in modalità di sola lettura (riserva). Prova ad aggiornare il plugin.",
      "Dieser Server wird im Nur-Lese-Modus (Spare) ausgeführt. Versuchen Sie, das Plugin zu aktualisieren.",
      "此服务器以只读（备用）模式运行。 尝试更新插件。",
      "Este servidor se ejecuta en modo de solo lectura (reserva). Intente actualizar el complemento.",
      "Ce serveur fonctionne en mode lecture seule (réserve). Essayez de mettre à jour le plug-in.",
      "Bu sunucu salt okunur (yedek) modda çalışıyor. Eklentiyi güncellemeyi deneyin."};

    public static readonly string[] ParameterNotSet = {
      "Parameter not set",
      "Не задан параметр",
      "Parametro non impostato",
      "Parameter nicht gesetzt",
      "未设置参数",
      "Parámetro no establecido",
      "Paramètre non défini",
      "Parametre ayarlanmadı"};

    public static readonly string[] ClientNotExists = {
      "Client not exists",
      "Такого клиента не существует",
      "Questo client non esiste.",
      "Dieser Mandant existiert nicht.",
      "此客户端不存在。",
      "Este cliente no existe.",
      "Ce client n'existe pas.",
      "Bu müşteri mevcut değil."};

    public static readonly string[] ProgramNameError = {
      "Program name error",
      "Ошибочное имя программы",
      "Nome programma errato",
      "Falscher Programmname",
      "错误的程序名称",
      "Nombre de programa incorrecto",
      "Nom de programme incorrect",
      "Yanlış program adı"};

    public static readonly string[] NotFree = {
      "The program is not free",
      "Эта программа не бесплатная",
      "Questo programma non è gratuito",
      "Dieses Programm ist nicht kostenlos",
      "这个程序不是免费的",
      "Este programa no es gratuito",
      "Ce programme n'est pas gratuit",
      "Bu program ücretsiz değil"};

    public static readonly string[] NeedPassword = {
      "To activate a paid program, you need to protect your account with a password",
      "Для активации платных программ вы должны защитить свой аккаунт паролем",
      "Per attivare programmi a pagamento, devi proteggere il tuo account con una password",
      "Um kostenpflichtige Programme zu aktivieren, müssen Sie Ihr Konto mit einem Passwort schützen",
      "要激活付费程序，您必须使用密码保护您的帐户",
      "Para activar programas de pago, debe proteger su cuenta con una contraseña",
      "Pour activer des programmes payants, vous devez protéger votre compte avec un mot de passe",
      "Ücretli programları etkinleştirmek için hesabınızı bir şifre ile korumalısınız"};

    public static readonly string[] WrongPassword = {
      "Wrong password",
      "Пароль неверный",
      "Password errata",
      "Falsches Passwort",
      "密码错误",
      "Contraseña incorrecta",
      "Mot de passe incorrect",
      "Yanlış şifre"};

    public static readonly string[] OldVersion = {
      "Too old version",
      "Слишком старая версия",
      "Versione troppo vecchia",
      "Zu alte Version",
      "版本太旧",
      "Versión demasiado antigua",
      "Version trop ancienne",
      "Çok eski sürüm"};

    public static readonly string[] EmptyWorkplace = {
      "Empty workplace",
      "Не указано рабочее место",
      "Lavoro non specificato",
      "Beruf nicht angegeben",
      "未指定作业",
      "Lugar de trabajo no especificado",
      "Lieu de travail non spécifié",
      "İşyeri belirtilmedi"};

    public static readonly string[] Activated = {
      "The program has already been activated at this workplace",
      "Программа уже активирована на этом рабочем месте",
      "Il programma è già attivato su questo posto di lavoro",
      "Auf diesem Arbeitsplatz ist das Programm bereits aktiviert",
      "该程序已在此工作场所激活",
      "El programa ya está activado en este lugar de trabajo",
      "Le programme est déjà activé sur ce lieu de travail",
      "Program bu işyerinde zaten etkinleştirildi"};

    public static readonly string[] TrialEnded = {
      "You have already used the trial period",
      "Вы уже использовали пробный период",
      "Hai già utilizzato il periodo di prova",
      "Sie haben den Testzeitraum bereits genutzt",
      "您已经使用了试用期",
      "Ya ha utilizado el período de prueba",
      "Vous avez déjà utilisé la période d'essai",
      "Deneme süresini zaten kullandınız"};

    public static readonly string[] TrialUsed = {
      "Someone has already used the trial period on this computer",
      "Кто-то уже использовал пробный период на этом рабочем месте",
      "Qualcuno ha già utilizzato il periodo di prova su questo posto di lavoro",
      "Jemand hat die Probezeit auf diesem Arbeitsplatz bereits genutzt",
      "有人已在此工作场所使用试用期",
      "Alguien ya usó el período de prueba en este lugar de trabajo",
      "Quelqu'un a déjà utilisé la période d'essai sur ce lieu de travail",
      "Birisi bu işyerinde deneme süresini zaten kullandı"};

    public static readonly string[] NoMoney = {
      "There are not enough funds in your account",
      "Недостаточно средств на вашем аккаунте",
      "Fondi insufficienti sul tuo conto",
      "Unzureichende Deckung auf Ihrem Konto",
      "您的账户资金不足",
      "Fondos insuficientes en su cuenta",
      "Fonds insuffisants sur votre compte",
      "Hesabınızda yetersiz bakiye"};

    public static readonly string[] NullRequest = {
      "Null request",
      "Пустой запрос",
      "Richiesta vuota",
      "Leere Anfrage",
      "空请求",
      "Solicitud vacía",
      "Demande vide",
      "Boş istek"};

    public static readonly string[] DecodingError = {
      "Decoding error",
      "Ошибка расшифровки",
      "Errore di descrizione",
      "Dekodierungsfehler",
      "解密错误",
      "Error de descifrado",
      "Erreur de décodage",
      "Şifre çözme hatası"};

    public static readonly string[] NeedInternet = {
      "To activate the trial period, you need to connect the program to an Internet server.",
      "Для активации пробного периода вам надо подключить программу к серверу в интернете.",
      "Per attivare il periodo di prova, è necessario collegare il programma a un server su Internet.",
      "Um die Testphase zu aktivieren, müssen Sie das Programm mit einem Server im Internet verbinden.",
      "要激活试用期，您需要将程序连接到 Internet 上的服务器。",
      "Para activar el período de prueba, debe conectar el programa a un servidor en Internet.",
      "Pour activer la période d'essai, vous devez connecter le programme à un serveur sur Internet.",
      "Deneme süresini etkinleştirmek için programı İnternet'teki bir sunucuya bağlamanız gerekir."};

    public static readonly string[] ActivationNotFound = {
      "There is no such activation in the database.",
      "В базе данных нет такой активации.",
      "Non esiste tale attivazione nel database.",
      "Es gibt keine solche Aktivierung in der Datenbank.",
      "数据库中没有这样的激活。",
      "No existe tal activación en la base de datos.",
      "Il n'y a pas d'activation de ce type dans la base de données.",
      "Veritabanında böyle bir etkinleştirme yok."};

    public static readonly string[] TrialDeleting = {
      "Trial activations cannot be deleted.",
      "Пробная активация не может быть удалена.",
      "L'attivazione di prova non può essere rimossa.",
      "Die Testaktivierung kann nicht entfernt werden.",
      "无法删除试用激活。",
      "La activación de prueba no se puede eliminar.",
      "L'activation d'essai ne peut pas être supprimée.",
      "Deneme etkinleştirmesi kaldırılamaz."};

    public static readonly string[] LicenseTransfer = {
      "It is not allowed to transfer licenses more than once a day.",
      "Нельзя переносить лицензии по нескольку раз в день.",
      "Non è possibile trasferire le licenze più volte al giorno.",
      "Lizenzen können nicht mehrmals täglich übertragen werden.",
      "您不能每天多次转移许可证。",
      "No está permitido transferir licencias más de una vez al día.",
      "Il n'est pas autorisé de transférer des licences plus d'une fois par jour.",
      "Lisansların günde birden fazla aktarılmasına izin verilmez."};

    public static readonly string[] NoAccess = {
      "No access to remove activation. Wrong password.",
      "Нет доступа для удаления активации. Пароль неверный.",
      "Nessun accesso per rimuovere l'attivazione. Password errata.",
      "Kein Zugriff zum Entfernen der Aktivierung. Falsches Passwort.",
      "无权删除激活。 密码错误。",
      "No hay acceso para eliminar la activación. Contraseña incorrecta.",
      "Pas d'accès pour supprimer l'activation. Mot de passe incorrect.",
      "Etkinleştirmeyi kaldırmak için erişim yok. Yanlış şifre."};

    public static readonly string[] PasswordRequest = {
      "You`ve already requested a password. Please wait for the server`s response.",
      "Вы уже запрашивали пароль. Пожалуйста, дождитесь ответа сервера.",
      "Hai già richiesto una password. Attendi la risposta del server.",
      "Sie haben bereits ein Passwort angefordert. Bitte warten Sie auf die Antwort des Servers.",
      "您已经请求了密码。 请等待服务器的响应。",
      "Ya ha solicitado una contraseña. Espere la respuesta del servidor.",
      "Vous avez déjà demandé un mot de passe. Veuillez attendre la réponse du serveur.",
      "Zaten bir şifre talep ettiniz. Lütfen sunucunun yanıtını bekleyin."};

    public static readonly string[] ManagerNotExists =  {
      "There is no such manager account registered yet",
      "Такой учетной записи руководителя еще не зарегистрировано",
      "Non esiste ancora un account manager registrato",
      "Es gibt noch kein solches Manager-Konto registriert",
      "尚未注册这样的经理帐户",
      "Aún no se ha registrado una cuenta de gerente de este tipo",
      "Il n'existe pas encore de compte de gestionnaire de ce type enregistré",
      "Henüz böyle bir yönetici hesabı kayıtlı değil" };

    public static readonly string[] ManagerLikeMail = {
      "The manager`s email matched the account.",
      "Почта руководителя совпала с учетной записью.",
      "La mail del manager ha corrisposto all'account.",
      "Die E-Mail des Managers stimmte mit dem Konto überein.",
      "经理的电子邮件与帐户匹配。",
      "El correo electrónico del gerente coincidió con la cuenta.",
      "Le mail du manager a correspondu au compte.",
      "Yöneticinin e-postası hesapla eşleşti." };

    public static readonly string[] AmountErr = {
    "The account balance is less than the amount specified for transfer.",
    "Баланс аккаунта меньше указанной суммы для перевода.",
    "Il saldo del conto è inferiore all'importo specificato per il trasferimento.",
    "Der Kontostand ist geringer als der für die Überweisung angegebene Betrag.",
    "帐户余额小于指定的转账金额。",
    "El saldo de la cuenta es menor que el monto especificado para la transferencia.",
    "Le solde du compte est inférieur au montant spécifié pour le transfert.",
    "Hesap bakiyesi, transfer için belirtilen tutardan az." };

    public static readonly string[] LicenseIdErr = {
    "License does not exist or does not belong to the specified client",
    "Лицензия не существует или не принадлежит указанному клиенту",
    "La licenza non esiste o non appartiene al cliente specificato",
    "Die Lizenz existiert nicht oder gehört nicht zum angegebenen Kunden",
    "许可证不存在或不属于指定客户",
    "La licencia no existe o no pertenece al cliente especificado",
    "La licence n'existe pas ou n'appartient pas au client spécifié",
    "Lisans mevcut değil veya belirtilen müşteriye ait değil" };

    public static readonly string[] NoLicense = {
    "No active licenses found to transfer",
    "Не найдено активных лицензий для переноса"        ,
    "Nessuna licenza attiva trovata da trasferire",
    "Keine aktiven Lizenzen zum Übertragen gefunden",
    "未找到要转移的活动许可证",
    "No se encontraron licencias activas para transferir",
    "Aucune licence active trouvée à transférer",
    "Transfer edilecek aktif lisans bulunamadı" };


    public static List<string[]>
    Messages = new();

    static
    ServerL()
    {
      Type th = typeof(ServerL);
      foreach (FieldInfo fi in th.GetFields(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic))
      {
        if (fi.FieldType == typeof(string[]))
          Messages.Add((string[])fi.GetValue(null));
      }
    }

    public static string
    Localize(string english, int languageNumber)
    {
      if (languageNumber <= 0) return english;
      if (IsNullOrWhiteSpace(english)) return "";
      foreach (string[] s in Messages)
        if (languageNumber < s.Length && english.Contains(s[0]))
          return english.Replace(s[0], s[languageNumber]);
      Debug.WriteLine($"!! Не найден перевод для серверной строки {english}");
      return english;
    }

  }
}
