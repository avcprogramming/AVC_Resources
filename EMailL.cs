namespace AVC
{
  public static class 
  EMailL
  {

    public static readonly string[] PasswordReset = {
      "The password for the {0} account has been reset.\r\n" +
      "Use temporary password {1}\r\n" +
      "Go to A>V>C> settings (AvcOptions command) and on the 'Account' tab call the password change procedure.\r\n"+
      "Enter a temporary password and create a new one.\r\n"+
      "Save your password in a safe place.",

      "Сброшен пароль учетной записи {0}.\r\n" +
      "Используйте временный пароль {1}\r\n" +
      "Зайдите в настройки A>V>C> (команда AvcOptions) и на закладке 'Учетная запись' (Account) вызовите процедуру замены пароля.\r\n" +
      "Введите временный пароль и придумайте новый.\r\n" +
      "Сохраните пароль в надежном месте.",

      "Reimposta la password per l'account {0}\r\n" +
      "Usa password temporanea {1}\r\n" +
      "Andare nelle impostazioni A>V>C> (comando AvcOptions) e nella scheda 'Account' richiamare la procedura per la modifica della password.\r\n" +
      "Inserisci una password temporanea e creane una nuova.\r\n" +
      "Salva la tua password in un luogo sicuro.",

      "Passwort für Konto {0} zurücksetzen\r\n" +
      "Temporäres Passwort verwenden {1}\r\n" +
      "Gehen Sie zu den A>V>C>-Einstellungen (AvcOptions-Befehl) und rufen Sie auf der Registerkarte 'Konto' die Prozedur zum Ändern des Passworts auf.\r\n" +
      "Geben Sie ein temporäres Passwort ein und erstellen Sie ein neues.\r\n" +
      "Speichern Sie Ihr Passwort an einem sicheren Ort.",

      "{0} 帐户的密码已重置。\r\n" +
       "使用临时密码 {1}\r\n" +
       "转到 A>V>C> 设置（AvcOptions 命令）并在“帐户”选项卡上调用密码更改过程。\r\n"+
       "输入一个临时密码并创建一个新密码。\r\n"+
       "将您的密码保存在安全的地方。",

      "La contraseña de la cuenta {0} ha sido restablecida.\r\n" +
      "Usa la contraseña temporal {1}\r\n" +
      "Ve a la configuración de A>V>C> (comando AvcOptions) y en la pestaña 'Cuenta' inicia el procedimiento de cambio de contraseña.\r\n" +
      "Introduce la contraseña temporal y crea una nueva.\r\n" +
      "Guarda tu contraseña en un lugar seguro.",

      "Le mot de passe du compte {0} a été réinitialisé.\r\n" +
      "Utilisez le mot de passe temporaire {1}\r\n" +
      "Accédez aux paramètres A>V>C> (commande AvcOptions) et, dans l'onglet 'Compte', lancez la procédure de changement de mot de passe.\r\n" +
      "Saisissez le mot de passe temporaire et créez-en un nouveau.\r\n" +
      "Conservez votre mot de passe en lieu sûr.",

      "{0} hesabının parolası sıfırlandı.\r\n" +
      "Geçici parolayı kullanın {1}\r\n" +
      "A>V>C> ayarlarına gidin (AvcOptions komutu) ve 'Hesap' sekmesinde parola değiştirme prosedürünü başlatın.\r\n" +
      "Geçici parolayı girin ve yeni bir parola oluşturun.\r\n" +
      "Parolanızı güvenli bir yerde saklayın."      };

    public static readonly string[] Activated = {
      "The {0} program has been activated offline for the {1} account.\r\n" +
      "License type: {2}. License expiration: {3}.\r\n" +
      "Go to A>V>C> settings (AvcOptions command) and start activating the program again.\r\n" +
      "Then enter the key into the offline activation window.\r\n" +
      "Key: {4}\r\n" +
      "Offline activation has serious limitations. It is recommended to connect your computer to the Internet.",

      "Для учетной записи {0} произведена оффлайн-активация программы {1}.\r\n" +
      "Тип лицензии: {2}. Срок действия лицензии: {3}.\r\n" +
      "Зайдите в настройки A>V>C> (команда AvcOptions) и снова начните активацию программы.\r\n" +
      "Затем введите ключ в окно оффлайн активации.\r\n" +
      "Ключ: {4}\r\n" +
      "Оффлайн активация имеет серьезные ограничения. Рекомендуется подключить ваш компьютер к интернет.",

      "Per l'account {0}, è stata eseguita l'attivazione offline del programma {1}.\r\n" +
      "Tipo di licenza: {2}. La licenza è valida per {3}.\r\n" +
      "Vai alle impostazioni A>V>C> (comando AvcOptions) e ricomincia ad attivare il programma.\r\n" +
      "Quindi inserisci la chiave nella finestra di attivazione offline.\r\n" +
      "Chiave: {4}\r\n" +
      "L'attivazione offline presenta gravi limitazioni. Si consiglia di connettere il computer a Internet.",

      "Für das Konto {0} wurde die Offline-Aktivierung des Programms {1} durchgeführt.\r\n" +
      "Lizenztyp: {2}. Die Lizenz ist gültig für {3}.\r\n" +
      "Gehen Sie zu den A>V>C>-Einstellungen (AvcOptions Befehl) und starten Sie die Aktivierung des Programms erneut.\r\n" +
      "Geben Sie dann den Schlüssel in das Offline-Aktivierungsfenster ein.\r\n" +
      "Schlüssel: {4}\r\n" +
      "Die Offline-Aktivierung weist schwerwiegende Einschränkungen auf. Es wird empfohlen, Ihren Computer mit dem Internet zu verbinden.",

      "{0} 程序已为 {1} 帐户脱机激活。\r\n" +
       "许可证类型：{2}。许可证到期：{3}。\r\n" +
       "转到 A>V>C> 设置（AvcOptions 命令）并再次开始激活程序。\r\n" +
       "然后在离线激活窗口中输入密钥。\r\n" +
       "密钥：{4}\r\n" +
       "离线激活有严重的局限性，建议将电脑连接到互联网。",

      "El programa {0} ha sido activado sin conexión para la cuenta {1}.\r\n" +
      "Tipo de licencia: {2}. Vencimiento de la licencia: {3}.\r\n" +
      "Ve a la configuración de A>V>C> (comando AvcOptions) y vuelve a iniciar la activación del programa.\r\n" +
      "Luego introduce la clave en la ventana de activación sin conexión.\r\n" +
      "Clave: {4}\r\n" +
      "La activación sin conexión tiene limitaciones importantes. Se recomienda conectar el ordenador a Internet.",

      "Le programme {0} a été activé hors ligne pour le compte {1}.\r\n" +
      "Type de licence : {2}. Expiration de la licence : {3}.\r\n" +
      "Accédez aux paramètres A>V>C> (commande AvcOptions) et relancez l'activation du programme.\r\n" +
      "Ensuite, saisissez la clé dans la fenêtre d'activation hors ligne.\r\n" +
      "Clé : {4}\r\n" +
      "L'activation hors ligne comporte de fortes limitations. Il est recommandé de connecter votre ordinateur à Internet.",

      "{0} programı, {1} hesabı için çevrimdışı etkinleştirildi.\r\n" +
      "Lisans türü: {2}. Lisans bitiş tarihi: {3}.\r\n" +
      "A>V>C> ayarlarına gidin (AvcOptions komutu) ve programı yeniden etkinleştirmeyi başlatın.\r\n" +
      "Ardından anahtarı çevrimdışı etkinleştirme penceresine girin.\r\n" +
      "Anahtar: {4}\r\n" +
      "Çevrimdışı etkinleştirmenin ciddi kısıtlamaları vardır. Bilgisayarınızı internete bağlamanız önerilir."};

    public static readonly string[] Hello = {
      "Hello {0}.",
      "Здравствуйте, {0}.",
      "Ciao {0}.",
      "Hallo {0}.",
      "你好{0}。",
      "Hola {0}.",
      "Bonjour {0}.",
      "Merhaba {0}." };

    public static readonly string[] PaymentThanks = {
      "Thank you for your payment!",
      "Спасибо за ваш платеж!",
      "Grazie per il tuo pagamento!",
      "Danke für deine Bezahlung!",
      "谢谢您的付款！",
      "¡Gracias por tu pago!",
      "Merci pour votre paiement !",
      "Ödemeniz için teşekkürler!" };

    public static readonly string[] CanBuyLicense = {
      "{1:0}Euro has been credited to your A>V>C>-account {0}. \r\n" +
        "Specify this account in the plugin settings (AVCOptions command, Account tab). \r\n" +
        "If you do not see an increase in your balance, please check that your account is correct and restart CAD. \r\n" +
        "You can use this money on any A>V>C> plugin. \r\n" +
        "Select the plugin and license type on the All Programs tab.",
      "На ваш A>V>C>-аккаунт {0} зачислено {1:0}Euro.\r\n" +
        "Укажите этот аккаунт в настройках плагинов (команда AVCOptions, вкладка Учетная Запись).\r\n" +
        "Если вы не видите увеличения баланса, то проверьте правильность вашего аккаунта и перезапустите CAD.\r\n" +
        "Вы можете использовать эти деньги на любой плагин AVC. \r\n" +
        "Выбирайте плагин и тип лицензии на вкладке Все программы.",
      "{1:0}L'Euro è stato accreditato sul tuo account A>V>C> {0}. \r\n" +
        "Specificare questo account nelle impostazioni del plugin (comando AVCOptions, scheda Account). \r\n" +
        "Se non vedi un aumento nel tuo saldo, controlla che il tuo account sia corretto e riavvia CAD. \r\n" +
        "Puoi utilizzare questi soldi su qualsiasi plugin A>V>C>. \r\n" +
        "Seleziona il plug-in e il tipo di licenza nella scheda Tutti i programmi.",
      "{1:0}Euro wurde Ihrem A>V>C>-Konto {0} gutgeschrieben. \r\n" +
        "Geben Sie dieses Konto in den Plugin-Einstellungen an (Befehl AVCOptions, Registerkarte Konto). \r\n" +
        "Wenn Sie keine Erhöhung Ihres Guthabens feststellen, überprüfen Sie bitte, ob Ihr Konto korrekt ist, und starten Sie CAD neu. \r\n" +
        "Sie können dieses Geld für jedes A>V>C>-Plugin verwenden. \r\n" +
        "Wählen Sie auf der Registerkarte „Alle Programme“ das Plugin und den Lizenztyp aus.",
      "您的 A>V>C> 帐户 {0} 已存入 {1:0}欧元。\r\n" +
        "在插件设置中指定此帐户（AVCOptions 命令，帐户选项卡）。\r\n" +
        "如果您没有看到余额增加，请检查您的帐户是否正确并重新启动 CAD。\r\n" +
        "你可以用这笔钱购买任何 A>V>C> 插件。\r\n" +
        "在“所有程序”选项卡上选择插件和许可证类型。",
      "Se han acreditado {1:0} euros en tu cuenta A>V>C> {0}.\r\n" +
        "Especifica esta cuenta en la configuración del complemento (comando AVCOptions, pestaña Cuenta).\r\n" +
        "Si no ves un aumento en tu saldo, comprueba que tu cuenta sea correcta y reinicia CAD.\r\n" +
        "Puedes usar este dinero en cualquier complemento A>V>C>.\r\n" +
        "Selecciona el complemento y el tipo de licencia en la pestaña Todos los programas.",
      "{1:0} euros ont été crédités sur votre compte A>V>C> {0}.\r\n" +
        "Indiquez ce compte dans les paramètres du plugin (commande AVCOptions, onglet Compte).\r\n" +
        "Si vous ne constatez pas d'augmentation de votre solde, vérifiez que votre compte est correct et redémarrez le CAD.\r\n" +
        "Vous pouvez utiliser cet argent sur n'importe quel plugin A>V>C>.\r\n" +
        "Sélectionnez le plugin et le type de licence dans l'onglet Tous les programmes.",
      "A>V>C> hesabınız {0}'a {1:0} Euro yatırıldı.\r\n" +
        "Bu hesabı eklenti ayarlarında belirtin (AVCOptions komutu, Hesap sekmesi).\r\n" +
        "Bakiyenizde artış görmüyorsanız hesabınızın doğru olduğunu kontrol edin ve CAD'i yeniden başlatın.\r\n" +
        "Bu parayı herhangi bir A>V>C> eklentisinde kullanabilirsiniz.\r\n" +
        "Tüm Programlar sekmesinde eklentiyi ve lisans türünü seçin." };

    public static readonly string[] ActivationInfo = {
      "An annual license for the program {1} has been issued to your account {2} (cost - {0:0}Euro). \r\n" +
        "Specify this account in the plugin settings (AVCOptions command, Account tab). \r\n" +
        "Restart CAD, run any command From the {1} plugin, and the program will prompt you to activate the license. \r\n" +
        "All you have to do is click OK. No license numbers are required to be entered.\r\n" +
        "More details about activation here: https://sites.google.com/site/avcplugins/activation",
      "На ваш аккаунт {2} выдана годовая лицензия на программу {1} (стоимость - {0:0}Euro). \r\n" +
        "Укажите этот аккаунт в настройках плагинов (команда AVCOptions, вкладка Учетная Запись). \r\n" +
        "Перезагрузите CAD, запустите любую команду из плагина {1}, и программа предложит вам активировать лицензию. \r\n" +
        "Вам останется только нажать ОК. Никаких лицензионных номеров вводить не требуется. \r\n" +
        "Подробнее об активации тут: https://sites.google.com/site/avcprg/activation",
      "Una licenza annuale per il programma {1} è stata rilasciata sul tuo account {2} (costo - {0:0}Euro). \r\n" +
        "Specificare questo account nelle impostazioni del plugin (comando AVCOptions, scheda Account). \r\n" +
        "Riavvia CAD, esegui qualsiasi comando dal plug-in {1} e il programma ti chiederà di attivare la licenza. \r\n" +
        "Tutto quello che devi fare è fare clic su OK. Non è necessario inserire i numeri di licenza. \r\n" +
        "Maggiori dettagli sull'attivazione qui: https://sites.google.com/site/avcplugins/activation",
      "Für Ihr Konto {2} wurde eine Jahreslizenz für das Programm {1} ausgestellt (Kosten - {0:0}Euro). \r\n" +
        "Geben Sie dieses Konto in den Plugin-Einstellungen an (Befehl AVCOptions, Registerkarte Konto). \r\n" +
        "Starten Sie CAD neu, führen Sie einen beliebigen Befehl aus dem {1}-Plugin aus und das Programm fordert Sie auf, die Lizenz zu aktivieren. \r\n" +
        "Alles was Sie tun müssen, ist auf OK zu klicken. Es müssen keine Lizenznummern eingegeben werden. \r\n" +
        "Weitere Details zur Aktivierung hier: https://sites.google.com/site/avcplugins/activation",
      "计划 {1} 的年度许可证已颁发给您的帐户 {2}（费用 - {0:0}欧元）。 \r\n" +
        "在插件设置（AVCOptions 命令，帐户选项卡）中指定此帐户。 \r\n" +
        "重新启动 CAD，运行 {1} 插件中的任何命令，程序将提示您激活许可证。 您所要做的就是单击“确定”。 无需输入许可证号码。 \r\n" +
        "有关激活的更多详细信息，请参见此处：https://sites.google.com/site/avcplugins/activation",
      "Se ha emitido una licencia anual para el programa {1} a tu cuenta {2} (coste - {0:0} euros). \r\n" +
        "Especifica esta cuenta en la configuración del complemento (comando AVCOptions, pestaña Cuenta). \r\n" +
        "Reinicia CAD, ejecuta cualquier comando del complemento {1} y el programa te pedirá que actives la licencia. \r\n" +
        "Solo tienes que pulsar OK. No es necesario introducir números de licencia.\r\n" +
        "Más detalles sobre la activación aquí: https://sites.google.com/site/avcplugins/activation",
      "Une licence annuelle pour le programme {1} a été émise pour votre compte {2} (coût - {0:0} euros). \r\n" +
        "Indiquez ce compte dans les paramètres du plugin (commande AVCOptions, onglet Compte). \r\n" +
        "Redémarrez CAD, exécutez n'importe quelle commande du plugin {1} et le programme vous proposera d'activer la licence. \r\n" +
        "Il vous suffit de cliquer sur OK. Aucun numéro de licence n'est requis.\r\n" +
        "Plus de détails sur l'activation ici : https://sites.google.com/site/avcplugins/activation",
      "{2} hesabınız için {1} programına yıllık lisans verildi (ücret - {0:0} Euro). \r\n" +
        "Bu hesabı eklenti ayarlarında belirtin (AVCOptions komutu, Hesap sekmesi). \r\n" +
        "CAD'i yeniden başlatın, {1} eklentisinden herhangi bir komutu çalıştırın; program lisansı etkinleştirmenizi isteyecektir. \r\n" +
        "Yapmanız gereken sadece OK'ye tıklamak. Lisans numarası girmenize gerek yoktur.\r\n" +
        "Etkinleştirme hakkında daha fazla bilgi: https://sites.google.com/site/avcplugins/activation" };

    public static readonly string[] NoResponse = {
      "Please do not reply to this letter! \r\n" +
        "If you have questions, write to technical support at avc.programming@gmail.com",
      "Пожалуйста не отвечайте на это письмо! \r\n" +
        "Если у вас есть вопросы - пишите в техподдержку на avc.programming@gmail.com",
      "Per favore non rispondere a questa lettera! \r\n" +
        "Se hai domande, scrivi al supporto tecnico a avc.programming@gmail.com",
      "Bitte antworten Sie nicht auf diesen Brief! \r\n" +
        "Wenn Sie Fragen haben, schreiben Sie an den technischen Support unter avc.programming@gmail.com",
      "请不要回复这封信！ \r\n" +
        "如果您有疑问，请写信给技术支持：avc.programming@gmail.com",
      "¡Por favor, no respondas a este correo! \r\n" +
        "Si tienes preguntas, escribe al soporte técnico en avc.programming@gmail.com",
      "Veuillez ne pas répondre à ce message ! \r\n" +
        "Si vous avez des questions, écrivez au support technique à avc.programming@gmail.com",
      "Lütfen bu e-postaya yanıt vermeyin! \r\n" +
        "Sorularınız varsa teknik desteğe yazın: avc.programming@gmail.com" };



  }
}
