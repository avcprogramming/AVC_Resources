// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Popup

namespace AVC
{
  /// <summary>
  /// Локализация типовых сообщений в консоль (информация, ошибки, предупреждения)
  /// </summary>
  public static class
  CnsL
  {
    public static readonly string[]
    Varies = {
      "*VARIES*",
      "*РАЗЛИЧНЫЕ*",
      "*VARIE*",
      "*VARIIERT*",
      "*变化*"};
    public static readonly string[]
    Information = {
      "Information",
      "Информация",
      "Informazioni",
      "Information",
      "信息" };
    public static readonly string[]
    Attention = {
      "Attention!",
      "Внимание!",
      "Attenzione!",
      "Achtung!",
      "注意力！" };
    public static readonly string[]
    Error = {
      "Error!",
      "Ошибка!",
      "Errore!",
      "Fehler!",
      "错误！" };
    public static readonly string[]
    Query = {
      "Query",
      "Запрос",
      "Scegli",
      "Anfrage",
      "询问" };
    /// <summary>
    /// И для кнопок и для командной строки
    /// </summary>
    public static readonly string[]
    Ok = {
      "Ok",
      "ОК",
      "Ok",
      "OK",
      "确定(Ok)" };
    /// <summary>
    /// Для кнопок. Для опций команд есть CmdLineL.Cancel
    /// </summary>
    public static readonly string[]
    Cancel = {
      "Cancel",
      "Отменить",
      "Annulla",
      "Abgesagt",
      "取消" };
    /// <summary>
    /// Для кнопок и подстановок. Для командной строки есть другой вариант в CndLineL
    /// </summary>
    public static readonly string[]
    Yes = { "Yes", "Да", "Si", "Ja", "是的" };
    /// <summary>
    /// Для кнопок и подстановок. Для командной строки есть другой вариант в CndLineL
    /// </summary>
    public static readonly string[]
    No = { "No", "Нет", "No", "Nein", "不" };
    public static readonly string[]
    Select = {
      "Select",
      "Выбрать",
      "Selezionare",
      "Auswählen",
      "选择" };
    public static readonly string[]
    Selected = {
      "Selected {0}",
      "Выбрано {0}",
      "Congiunto {0}",
      "Ausgewählt {0}",
      "已选择 {0}" };
    public static readonly string[]
    ReadingObjects = {
      "Reading objects",
      "Чтение объектов",
      "Lettura di oggetti",
      "Objekte lesen",
      "读取对象" };
    public static readonly string[]
    Pick = {
      "Pick",
      "Указать",
      "Specificare",
      "Angeben",
      "指定" };
    public static readonly string[]
    Canceled = {
      "Canceled",
      "Отменено",
      "Annullato",
      "Annulliert",
      "取消了" };
    public static readonly string[]
    Loading = {
      "Loading...",
      "Загрузка...",
      "Caricamento...",
      "Laden...",
      "正在加载..." };
    public static readonly string[]
    Loaded = {
      "Loaded",
      "Загружено",
      "Caricato",
      "Geladen",
      "已加载" };
    public static readonly string[]
    Done = {
      "Done.",
      "Готово.",
      "Fatto.",
      "Getan.",
      "完成。" };
    public static readonly string[]
    ProcessCompleted = {
      "   ... Process completed: {0}..",
      "   ... Закончен процесс: {0}.",
      "   ... Processo completato: {0}.",
      "   ... Prozess abgeschlossen: {0}.",
      "   ... 进程完成：{0}。"};
    public static readonly string[]
    All = {
      "All",
      "Все",
      "Tutti",
      "Alles",
      "全部" };
    public static readonly string[]
    Save = {
      "Save",
      "Сохранить",
      "Salva",
      "Speichern",
      "保存" };
    public static readonly string[]
    Delete = {
      "Delete",
      "Удалить",
      "Eliminare",
      "Löschen",
      "删除" };
    public static readonly string[]
    Deleting = {
      "Deleting...",
      "Удаление...",
      "Rimozione...",
      "Entfernung...",
      "移动..." };
    public static readonly string[]
    Nothing = {
      "Nothing",
      "Ничего",
      "Niente",
      "Nichts",
      "没有"};
    public static readonly string[]
    Check =  {
      "Check",
      "Отметьте",
      "Dai un'occhiata",
      "Überprüfen",
      "查看"};
    public static readonly string[]
    Options = {
      "Options",
      "Настройки",
      "Impostazioni",
      "Einstellungen",
      "选项" };
    public static readonly string[]
    EscPressed = {
      "Esc was pressed.",
      "Нажат Esc",
      "È stato premuto Esc.",
      "Esc wurde gedrückt.",
      "按下 ESC 键。"};
    public static readonly string[]
    FileNotFound = {
      "File not found {0}",
      "Нет файла {0}",
      "File non trovato {0}",
      "Datei nicht gefunden {0}",
      "找不到文件 {0}" };
    public static readonly string[]
    FileSaveErr = {
      "Failed to save file '{0}'.\r\n" +
        "Error {1}",
      "Не удалось сохранить файл '{0}'.\r\n" +
        "Ошибка {1}",
      "Impossibile salvare il file '{0}'.\r\n" +
        "Errore {1}",
      "Fehler beim Speichern der Datei '{0}'.\r\n" +
        "Fehler '{1}'",
      "保存文件失败“{0}”。错误 {1}" };
    public static readonly string[]
    CannotSend = {
      "Can't send message to programmer." ,
      "Не удалось отправить сообщение по почте разработчику.",
      "Impossibile inviare il messaggio al programmatore.",
      "Ich kann keine Nachricht an den Programmentwickler senden." ,
      "无法向程序员发送消息。"};
    public static readonly string[]
    CannotSendMail = {
      "Can't send email message." ,
      "Не удалось отправить почтовое сообщение.",
      "Impossibile inviare il messaggio di posta elettronica.",
      "Ich kann keine E-Mail-Nachricht senden." ,
      "无法发送电子邮件消息。" };
    public static readonly string[]
    ParseLengthErr = {
      "The string cannot be recognized as a size",
      "Строку не получается распознать как размер",
      "La stringa non può essere riconosciuta come una dimensione",
      "Die Zeichenfolge kann nicht als Größe erkannt werden",
      "字符串无法识别为大小" };
    public static readonly string[]
    CommandCancel = {
      "\r\n  Command canceled",
      "\r\n  Команда отменена",
      "\r\n  Comando annullato",
      "\r\n  Vorgang abgebrochen",
      "\r\n  命令已取消" };
    public static readonly string[]
    Sorry = {
      "Sorry\r\n\r\n----  Under construction ----\r\n",
      "Извините.\r\n\r\n---- Функция пока находится в разработке ----\r\n",
      "Spiacente.\r\n\r\n---- In costruzione ----\r\n",
      "Es tut uns leid.\r\n\r\n---- Im Bau ---\r\n",
      "对不起\r\n\r\n-- 仍在开发中 🚧 --\r\n"};
    public static readonly string[]
    GeneralModelingFailure = {
      "Working with this object is not possible (eGeneralModelingFailure).",
      "Работа с данным объектом невозможна (eGeneralModelingFailure).",
      "Non è possibile lavorare con questo oggetto (eGeneralModelingFailure).",
      "Das Arbeiten mit diesem Objekt ist nicht möglich (eGeneralModelingFailure).",
      "无法使用此对象 (eGeneralModelingFailure)。" };
    public static readonly string[]
    ErrDoubleTolerance ={
      "Tolerance for type Double must be between 1 to 16 signification decimal digit",
      "Точность для типа Double должна быть от 1 до 16 значащих десятичных цифр",
      "La tolleranza per un Double deve essere da 1 a 16 cifre decimali significative",
      "Die Double Genauigkeit muss zwischen 1 und 16 signifikanten Dezimalstellen liegen.",
      "Double 类型的精度必须在 1 到 16 位有效十进制数字之间"};
    public static readonly string[]
    NothingSucceeded = {
      "Nothing succeeded",
      "Ничего не получилось",
      "Niente è riuscito",
      "Nichts war erfolgreich",
      "没有成功" };
    public static readonly string[] Process = {
      "Processing",
      "Обработка",
      "Elaborazione",
      "Verarbeitung",
      "加工"};
    public static readonly string[]
    ProcessedParts = {
      "  Processed {0} parts in {1}s",
      "  Обработано {0} деталей за {1}с",
      "  {0} parti elaborate in {1}s",
      "  Verarbeitete {0} Teile in {1} Sekunden",
      "  在 {1} 秒内处理了 {0} 个对象" };
    public static readonly string[]
    ProcessedObjects = {
      "  Processed {0} objects in {1}s",
      "  Обработано {0} объектов за {1}с",
      "  {0} oggetti elaborati in {1} s",
      "  Verarbeitete {0} Objekte in {1}s",
      "  在 {1} 秒内处理了 {0} 个对象" };
    public static readonly string[]
    CreatedObjects = {
      "  {0} objects created in {1}s",
      "  Создано {0} объектов(а) за {1}с",
      "  {0} oggetti creati in {1} secondi",
      "  {0} Objekte in {1} Sekunden erstellt",
      "  {1} 秒内创建 {0} 个对象" };
    public static readonly string[]
    Saving = {
      "Saving changes",
      "Сохранение изменений",
      "Salvataggio delle modifiche",
      "Änderungen speichern",
      "保存更改" };
    public static readonly string[]
    RestartRequired = {
      "Restart required!",
      "Требуется перезагрузка!",
      "Riavvio richiesto!",
      "Neustart erforderlich!",
      "需要重启！" };
    public static readonly string[]
    DisplayingData = {
      "Displaying data...",
      "Отображение данных...",
      "Visualizzazione dei dati...",
      "Daten anzeigen...",
      "显示数据..." };
    public static readonly string[]
    Language = {
      "Language",
      "Язык",
      "Linguaggio",
      "Sprache",
      "语言"};

  }
}
