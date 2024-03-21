// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using static System.String;

namespace AVC
{
  /// <summary>
  /// Локализация сообщений сервера AVC
  /// </summary>
  public static class 
  ServerL
  {
    public static readonly string[] ReadonlyServer = {
      "This server is readonly. Try updating the plugin.",
      "Этот сервер работает в режиме только для чтения (запасной). Попробуйте обновить плагин.",
      "Questo server è in esecuzione in modalità di sola lettura (riserva). Prova ad aggiornare il plugin.",
      "Dieser Server wird im Nur-Lese-Modus (Spare) ausgeführt. Versuchen Sie, das Plugin zu aktualisieren.",
      "此服务器以只读（备用）模式运行。 尝试更新插件。" };
    public static readonly string[] ParameterNotSet = {
      "Parameter not set",
      "Не задан параметр",
      "Parametro non impostato",
      "Parameter nicht gesetzt",
      "未设置参数" };
    public static readonly string[] ClientNotExists = {
      "Client not exists",
      "Такого клиента не существует",
      "Questo client non esiste.",
      "Dieser Mandant existiert nicht.",
      "此客户端不存在。" };
    public static readonly string[] ProgramNameError = {
      "Program name error",
      "Ошибочное имя программы",
      "Nome programma errato",
      "Falscher Programmname",
      "错误的程序名称" };
    public static readonly string[] NotFree = {
      "The program is not free",
      "Эта программа не бесплатная",
      "Questo programma non è gratuito",
      "Dieses Programm ist nicht kostenlos",
      "这个程序不是免费的" };
    public static readonly string[] NeedPassword = {
      "To activate a paid program, you need to protect your account with a password",
      "Для активации платных программ вы должны защитить свой аккаунт паролем",
      "Per attivare programmi a pagamento, devi proteggere il tuo account con una password",
      "Um kostenpflichtige Programme zu aktivieren, müssen Sie Ihr Konto mit einem Passwort schützen",
      "要激活付费程序，您必须使用密码保护您的帐户" };
    public static readonly string[] WrongPassword = {
      "Wrong password",
      "Пароль неверный",
      "Password errata",
      "Falsches Passwort",
      "密码错误" };
    public static readonly string[] OldVersion = {
      "Too old version",
      "Слишком старая версия",
      "Versione troppo vecchia",
      "Zu alte Version",
      "版本太旧" };
    public static readonly string[] EmptyWorkplace = {
      "Empty workplace",
      "Не указано рабочее место",
      "Lavoro non specificato",
      "Beruf nicht angegeben",
      "未指定作业" };
    public static readonly string[] Activated = {
      "The program has already been activated at this workplace",
      "Программа уже активирована на этом рабочем месте",
      "Il programma è già attivato su questo posto di lavoro",
      "Auf diesem Arbeitsplatz ist das Programm bereits aktiviert",
      "该程序已在此工作场所激活" };
    public static readonly string[] TrialEnded = {
      "You have already used the trial period",
      "Вы уже использовали пробный период",
      "Hai già utilizzato il periodo di prova",
      "Sie haben den Testzeitraum bereits genutzt",
      "您已经使用了试用期" };
    public static readonly string[] TrialUsed = {
      "Someone has already used the trial period on this computer",
      "Кто-то уже использовал пробный период на этом рабочем месте",
      "Qualcuno ha già utilizzato il periodo di prova su questo posto di lavoro",
      "Jemand hat die Probezeit auf diesem Arbeitsplatz bereits genutzt",
      "有人已在此工作场所使用试用期" };
    public static readonly string[] NoMoney = {
      "There are not enough funds in your account",
      "Недостаточно средств на вашем аккаунте",
      "Fondi insufficienti sul tuo conto",
      "Unzureichende Deckung auf Ihrem Konto",
      "您的账户资金不足" };
    public static readonly string[] NullRequest = {
      "Null request",
      "Пустой запрос",
      "Richiesta vuota",
      "Leere Anfrage",
      "空请求" };
    public static readonly string[] DecodingError = {
      "Decoding error",
      "Ошибка расшифровки",
      "Errore di descrizione",
      "Dekodierungsfehler",
      "解密错误" };
    public static readonly string[] NeedInternet = {
      "To activate the trial period, you need to connect the program to an Internet server.",
      "Для активации пробного периода вам надо подключить программу к серверу в интернете.",
      "Per attivare il periodo di prova, è necessario collegare il programma a un server su Internet.",
      "Um die Testphase zu aktivieren, müssen Sie das Programm mit einem Server im Internet verbinden.",
      "要激活试用期，您需要将程序连接到 Internet 上的服务器。" };
    public static readonly string[] ActivationNotFound = {
      "There is no such activation in the database.",
      "В базе данных нет такой активации.",
      "Non esiste tale attivazione nel database.",
      "Es gibt keine solche Aktivierung in der Datenbank.",
      "数据库中没有这样的激活。" };
    public static readonly string[] TrialDeleting = {
      "Trial activations cannot be deleted.",
      "Пробная активация не может быть удалена.",
      "L'attivazione di prova non può essere rimossa.",
      "Die Testaktivierung kann nicht entfernt werden.",
      "无法删除试用激活。" };
    public static readonly string[] LicenseTransfer = {
      "It is not allowed to transfer licenses more than once a day.",
      "Нельзя переносить лицензии по нескольку раз в день.",
      "Non è possibile trasferire le licenze più volte al giorno.",
      "Lizenzen können nicht mehrmals täglich übertragen werden.",
      "您不能每天多次转移许可证。" };
    public static readonly string[] NoAccess = {
      "No access to remove activation. Wrong password.",
      "Нет доступа для удаления активации. Пароль неверный.",
      "Nessun accesso per rimuovere l'attivazione. Password errata.",
      "Kein Zugriff zum Entfernen der Aktivierung. Falsches Passwort.",
      "无权删除激活。 密码错误。" };

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
      Debug.Print($"!! Не найден перевод для серверной строки {english}");
      return english;
    }

  }
}
