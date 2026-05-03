// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация диалога замены пароля
  /// </summary>
  public static class
  PasswordDlgL
  {
    public static readonly string[] PasswordTitle = {
      "🔑 A>V>C> Password",
      "🔑 Замена пароля",
      "🔑 Cambio di password",
      "🔑 Passwortänderung",
      "🔑 密码更改",
      "🔑 Cambio de contraseña",
      "🔑 Changement de mot de passe",
      "🔑 Şifre değişikliği"};

    public static readonly string[] PasswordGenerate = {
      "Generate",
      "Придумать",
      "Venire con",
      "Komm mit",
      "想出",
      "Generar",
      "Générer",
      "Oluştur"};

    public static readonly string[] Reset = {
      "🔑 Reset password",
      "🔑 Сброс пароля",
      "🔑 Reimpostare la password",
      "🔑 Zurücksetzen des Passworts",
      "🔑 重置密码",
      "🔑 Reiniciar contraseña",
      "🔑 Réinitialiser",
      "🔑 Sıfırla"};

    public static readonly string[] ResetTip = {
      "Submit a password reset request. \r\n" +
        "The A>V>C> server will generate a new password for your account and send it to you by email.",
      "Отправить запрос на сброс пароля. \r\n" +
        "Сервер A>V>C> придумает новый пароль для вашего аккаунта и пришлет его вам на почту.",
      "Invia una richiesta di reimpostazione della password. \r\n" +
        "Il server A>V>C> genererà una nuova password per il tuo account e te la invierà via email.",
      "Senden Sie eine Anfrage zum Zurücksetzen des Passworts. \r\n" +
        "Der A>V>C>-Server generiert ein neues Passwort für Ihr Konto und sendet es Ihnen per E-Mail.",
      "提交密码重置请求。 \r\n" +
        "A>V>C> 服务器将为您的帐户生成一个新密码，并通过电子邮件发送给您。",
      "Envíe una solicitud de restablecimiento de contraseña. \r\n" +
        "El servidor A>V>C> generará una nueva contraseña para su cuenta y se la enviará por correo electrónico.",
      "Envoyez une demande de réinitialisation de mot de passe. \r\n" +
        "Le serveur A>V>C> générera un nouveau mot de passe pour votre compte et vous l'enverra par e-mail.",
      "Şifre sıfırlama isteği gönderin. \r\n" +
        "A>V>C> sunucusu hesabınız için yeni bir şifre oluşturacak ve size e-posta ile gönderecektir." };

    public static readonly string[] Reseted = {
      "A password reset request has been sent to the A>V>C> server." +
        "A new password will be emailed to you in a few minutes.\r\n" +
        "If the password doesn't arrive within an hour: \r\n" +
        "  🔑 Check that the specified account matches your real email,\r\n" +
        "  🔑 Check your Spam folder, \r\n" +
        "  🔑 Submit a request to A>V>C> technical support.",
      "На сервер A>V>C> был отправлен запрос на сброс пароля. \r\n" +
        "Через несколько минут новый пароль будет отправлен вам на почту.\r\n" +
        "Если пароль не придет в течение часа: \r\n" +
        "  🔑 проверьте, что указанный аккаунт соответсует вашему реальному eMail, \r\n" +
        "  🔑 проверьте папку Спам, \r\n" +
        "  🔑 напишите запрос в техподдержку A>V>C>.",
      "È stata inviata una richiesta di reimpostazione della password al server A>V>C>. \r\n" +
        "Una nuova password ti sarà inviata via email tra pochi minuti.\r\n" +
        "Se la password non arriva entro un'ora: \r\n" +
        "  🔑 Controlla che l'account specificato corrisponda alla tua email reale, \r\n" +
        "  🔑 Controlla la cartella Spam, \r\n" +
        "  🔑 Invia una richiesta al supporto tecnico A>V>C>.",
      "Eine Anfrage zum Zurücksetzen des Passworts wurde an den A>V>C>-Server gesendet. \r\n" +
        "Ein neues Passwort wird Ihnen in wenigen Minuten per E-Mail zugesandt.\r\n" +
        "Wenn das Passwort nicht innerhalb einer Stunde ankommt: \r\n" +
        "  🔑 Überprüfen Sie, ob das angegebene Konto Ihrer echten E-Mail entspricht, \r\n" +
        "  🔑 Überprüfen Sie Ihren Spam-Ordner, \r\n" +
        "  🔑 Senden Sie eine Anfrage an den technischen Support von A>V>C>.",
      "已向 A>V>C> 服务器发送密码重置请求。 \r\n" +
        "几分钟后，您将通过电子邮件收到一个新密码。\r\n" +
        "如果密码在一小时内没有到达： \r\n" +
        "  🔑 检查指定的帐户是否与您的真实电子邮件匹配， \r\n" +
        "  🔑 检查您的垃圾邮件文件夹， \r\n" +
        "  🔑 向 A>V>C> 技术支持提交请求。",
      "Se ha enviado una solicitud de restablecimiento de contraseña al servidor A>V>C>. \r\n" +
        "Una nueva contraseña se le enviará por correo electrónico en unos minutos.\r\n" +
        "Si la contraseña no llega dentro de una hora: \r\n" +
        "  🔑 Verifique que la cuenta especificada coincida con su correo electrónico real, \r\n" +
        "  🔑 Verifique su carpeta de Spam, \r\n" +
        "  🔑 Envíe una solicitud al soporte técnico de A>V>C>.",
      "Une demande de réinitialisation de mot de passe a été envoyée au serveur A>V>C>. \r\n" +
        "Un nouveau mot de passe vous sera envoyé par e-mail dans quelques minutes.\r\n" +
        "Si le mot de passe n'arrive pas dans une heure: \r\n" +
        "  🔑 Vérifiez que le compte spécifié correspond à votre e-mail réel, \r\n" +
        "  🔑 Vérifiez votre dossier Spam, \r\n" +
        "  🔑 Envoyez une demande au support technique de A>V>C>.",
      "A>V>C> sunucusuna bir şifre sıfırlama isteği gönderildi. \r\n" +
        "Yeni bir şifre size birkaç dakika içinde e-posta ile gönderilecektir.\r\n" +
        "Şifre bir saat içinde gelmezse: \r\n" +
        "  🔑 Belirtilen hesabın gerçek e-postanızla eşleştiğini kontrol edin, \r\n" +
        "  🔑 Spam klasörünüzü kontrol edin, \r\n" +
        "  🔑 A>V>C> teknik desteğine bir istek gönderin."};

    public static readonly string[] PasswordAccount = {
      "A>V>C> Account",
      "Аккаунт A>V>C>",
      "Account A>V>C>",
      "A>V>C>-Konto",
      "A>V>C> 帐户",
      "Cuenta A>V>C>",
      "Compte A>V>C>",
      "A>V>C> Hesabı"};

    public static readonly string[] PasswordTip = {
      "The password will help to hide your data From strangers and prevent the theft of your licenses for the A>V>C> programs. " +
        "Paid programs can be activated only after a password has been created.",
      "Пароль поможет скрыть ваши данные от посторонних и не допустить воровство ваших лицензий на программы A>V>C>. " +
        "Платные программы можно активировать только после создания пароля.",
      "La password ti aiuterà a nascondere i tuoi dati agli estranei e prevenire il furto delle tue licenze per i programmi A>V>C>. " +
        "I programmi a pagamento possono essere attivati ​​solo dopo aver creato una password.",
      "Das Passwort hilft dabei, Ihre Daten vor Fremden zu verbergen und den Diebstahl Ihrer Lizenzen für A>V>C>-Programme zu verhindern. " +
        "Kostenpflichtige Programme können nur nach Erstellung eines Passworts aktiviert werden.",
      "密码将有助于向陌生人隐藏您的数据，并防止 A>V>C> 程序的许可证被盗。 付费程序只能在创建密码后才能激活。",
      "La contraseña ayudará a ocultar sus datos de extraños y evitar el robo de sus licencias para los programas A>V>C>. " +
        "Los programas de pago solo se pueden activar después de crear una contraseña.",
      "Le mot de passe aidera à masquer vos données aux étrangers et à empêcher le vol de vos licences pour les programmes A>V>C>. " +
        "Les programmes payants ne peuvent être activés qu'après la création d'un mot de passe.",
      "Şifre, verilerinizi yabancılardan gizlemeye ve A>V>C> programları için lisanslarınızın çalınmasını önlemeye yardımcı olacaktır. " +
        "Ücretli programlar yalnızca bir şifre oluşturulduktan sonra etkinleştirilebilir."};

    public static readonly string[] NewPassword = {
      "Password",
      "Пароль",
      "Parola d'ordine",
      "Passwort",
      "密码",
      "Contraseña",
      "Mot de passe",
      "Şifre"};

    public static readonly string[] OldPassword = {
      "Old password",
      "Старый пароль",
      "Vecchia password",
      "Altes Kennwort",
      "旧密码",
      "Contraseña anterior",
      "Ancien mot de passe",
      "Eski şifre"};

    public static readonly string[] NewPasswordTip = {
      "Password must contain at least eight any characters.",
      "Пароль должен содержать не менее восьми любых символов.",
      "La password deve contenere almeno otto caratteri qualsiasi.",
      "Das Passwort muss mindestens acht beliebige Zeichen enthalten.",
      "密码必须至少包含八个任意字符。",
      "La contraseña debe contener al menos ocho caracteres.",
      "Le mot de passe doit contenir au moins huit caractères.",
      "Şifre en az sekiz karakter içermelidir."};

    public static readonly string[] PasswordRequest = {
      "If you don't receive a new password from the A>V>C> server, \r\n" +
        "then send a password reset request to avc.programming@gmail.com from your email address {0}.\r\n" +
        "Recovering a lost password can take several days.",
      "Если не приходит новый пароль от сервера A>V>C>, \r\n" +
        "то напишите запрос на сброс пароля на avc.programming@gmail.com с вашей почты {0}. \r\n" +
        "Восстановление утерянного пароля может занять несколько дней.",
      "Se non ricevi una nuova password dal server A>V>C>, \r\n" +
        "invia una richiesta di reimpostazione della password a avc.programming@gmail.com dalla tua email {0}.\r\n" +
        "Il recupero di una password persa può richiedere diversi giorni.",
      "Wenn Sie kein neues Passwort vom A>V>C>-Server erhalten, \r\n" +
        "senden Sie eine Anfrage zum Zurücksetzen des Passworts an avc.programming@gmail.com von Ihrer E-Mail-Adresse {0}.\r\n" +
        "Die Wiederherstellung eines verlorenen Passworts kann mehrere Tage dauern.",
      "如果您没有收到来自 A>V>C> 服务器的新密码，\r\n" +
        "请从您的电子邮件地址 {0} 向 avc.programming@gmail.com 发送密码重置请求。\r\n" +
        "恢复丢失的密码可能需要几天时间。",
      "Si no recibe una nueva contraseña del servidor A>V>C>, \r\n" +
        "envíe una solicitud de restablecimiento de contraseña a avc.programming@gmail.com desde su correo electrónico {0}.\r\n" +
        "Recuperar una contraseña perdida puede llevar varios días.",
      "Si no recibe una nueva contraseña del servidor A>V>C>, \r\n" +
        "envoyez une demande de réinitialisation de mot de passe à avc.programming@gmail.com depuis votre adresse e-mail {0}.\r\n" +
        "La récupération d'un mot de passe perdu peut prendre plusieurs jours.",
      "A>V>C> sunucusundan yeni bir şifre almazsanız, \r\n" +
        "e-posta adresiniz {0} üzerinden avc.programming@gmail.com adresine şifre sıfırlama talebi gönderin.\r\n" +
        "Kayıp bir şifrenin kurtarılması birkaç gün sürebilir."};

    public static readonly string[] PasswordEmptyOrErr = {
      "The password saved on the computer is empty or does not match the password in the A>V>C> database. " +
        "You must enter the correct password.",
      "Сохраненный на компьютере пароль пуст или не совпадает с паролем в базе данных A>V>C>. " +
        "Надо ввести верный пароль.",
      "La password salvata sul computer è vuota o non corrisponde alla password nel database A>V>C>. " +
        "Devi inserire la password corretta.",
      "Das auf dem Computer gespeicherte Kennwort ist leer oder stimmt nicht mit dem Kennwort in " +
        "der A>V>C>-Datenbank überein.. Sie müssen das richtige Passwort eingeben.",
      "电脑上保存的密码为空或与A>V>C>数据库中的密码不匹配。 您必须输入正确的密码。",
      "La contraseña guardada en la computadora está vacía o no coincide con la contraseña en la base de datos A>V>C>. " +
        "Debe ingresar la contraseña correcta.",
      "Le mot de passe enregistré sur l'ordinateur est vide ou ne correspond pas au mot de passe dans la base de données A>V>C>. " +
        "Vous devez entrer le mot de passe correct.",
      "Bilgisayarda kaydedilen şifre boş veya A>V>C> veritabanındaki şifre ile eşleşmiyor. " +
        "Doğru şifreyi girmelisiniz."};

    public static readonly string[] PasswordNeeded = {
      "To work with this account, you need to enter your password.",
      "Для работы с данной учетной записью требуется ввести ваш пароль.",
      "Per lavorare con questo account, devi inserire la tua password.",
      "Um mit diesem Konto arbeiten zu können, müssen Sie ein Passwort eingeben.",
      "要使用此帐户，您需要输入密码。",
      "Para trabajar con esta cuenta, debe ingresar su contraseña.",
      "Pour travailler avec ce compte, vous devez entrer votre mot de passe.",
      "Bu hesapla çalışmak için şifrenizi girmeniz gerekir."};
  }
}