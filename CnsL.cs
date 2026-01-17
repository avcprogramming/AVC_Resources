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
    public static readonly string[] Varies = {
      "*VARIES*",
      "*РАЗЛИЧНЫЕ*",
      "*VARIE*",
      "*VARIIERT*",
      "*变化*",
      "*VARÍA*",
      "*VARIE*",
      "*FARKLIDIR*"};

    public static readonly string[] Information = {
      "Information",
      "Информация",
      "Informazioni",
      "Information",
      "信息",
      "Información",
      "Information",
      "Bilgi"};

    public static readonly string[] Attention = {
      "Attention!",
      "Внимание!",
      "Attenzione!",
      "Achtung!",
      "注意力！",
      "¡Atención!",
      "Attention!",
      "Dikkat!"};

    public static readonly string[] Error = {
      "Error!",
      "Ошибка!",
      "Errore!",
      "Fehler!",
      "错误！",
      "¡Error!",
      "Erreur!",
      "Hata!"};

    public static readonly string[] Query = {
      "Query",
      "Запрос",
      "Scegli",
      "Anfrage",
      "询问",
      "Consulta",
      "Requête",
      "Sorgu"};

    /// <summary>
    /// И для кнопок и для командной строки ✅
    /// </summary>
    public static readonly string[] Ok = {
      "Ok",
      "ОК",
      "Ok",
      "OK",
      "确定(Ok)",
      "Aceptar",
      "OK",
      "Tamam"};

    /// <summary>
    /// Для кнопок. Для опций команд есть CmdLineL.Cancel ❌
    /// </summary>
    public static readonly string[] Cancel = {
      "Cancel",
      "Отменить",
      "Annulla",
      "Abgesagt",
      "取消",
      "Cancelar",
      "Annuler",
      "İptal"};

    /// <summary>
    /// Для кнопок и подстановок. Для командной строки есть другой вариант в CndLineL
    /// </summary>
    public static readonly string[] Yes = {
      "Yes", "Да", "Si", "Ja", "是的", "Sí", "Oui", "Evet"};

    /// <summary>
    /// Для кнопок и подстановок. Для командной строки есть другой вариант в CndLineL
    /// </summary>
    public static readonly string[] No = {
      "No", "Нет", "No", "Nein", "不", "No", "Non", "Hayır"};

    public static readonly string[] Select = {
      "Select",
      "Выбрать",
      "Selezionare",
      "Auswählen",
      "选择",
      "Seleccionar",
      "Sélectionner",
      "Seç"};

    public static readonly string[] Selected = {
      "Selected {0}",
      "Выбрано {0}",
      "Congiunto {0}",
      "Ausgewählt {0}",
      "已选择 {0}",
      "Seleccionado {0}",
      "Sélectionné {0}",
      "Seçildi {0}"};

    public static readonly string[] ReadingObjects = {
      "Reading objects",
      "Чтение объектов",
      "Lettura di oggetti",
      "Objekte lesen",
      "读取对象",
      "Leyendo objetos",
      "Lecture d'objets",
      "Nesneler okunuyor"};

    public static readonly string[] Pick = {
      "Pick",
      "Указать",
      "Specificare",
      "Angeben",
      "指定",
      "Elegir",
      "Choisir",
      "Seç"};

    public static readonly string[] Canceled = {
      "Canceled",
      "Отменено",
      "Annullato",
      "Annulliert",
      "取消了",
      "Cancelado",
      "Annulé",
      "İptal edildi"};

    public static readonly string[] Loading = {
      "Loading...",
      "Загрузка...",
      "Caricamento...",
      "Laden...",
      "正在加载...",
      "Cargando...",
      "Chargement...",
      "Yükleniyor..."};

    public static readonly string[] Loaded = {
      "✅ Loaded",
      "✅ Загружено",
      "✅ Caricato",
      "✅ Geladen",
      "✅ 已加载",
      "✅ Cargado",
      "✅ Chargé",
      "✅ Yüklendi"};

    public static readonly string[] Done = {
      "✅ Done.",
      "✅ Готово.",
      "✅ Fatto.",
      "✅ Getan.",
      "✅ 完成。",
      "✅ Hecho.",
      "✅ Terminé.",
      "✅ Tamamlandı."};

    public static readonly string[] ProcessCompleted = {
      "   ✅ Process completed: {0}..",
      "   ✅ Закончен процесс: {0}.",
      "   ✅ Processo completato: {0}.",
      "   ✅ Prozess abgeschlossen: {0}.",
      "   ✅ 进程完成：{0}。",
      "   ✅ Proceso completado: {0}.",
      "   ✅ Processus terminé: {0}.",
      "   ✅ İşlem tamamlandı: {0}."};

    public static readonly string[] All = {
      "All",
      "Все",
      "Tutti",
      "Alles",
      "全部",
      "Todo",
      "Tout",
      "Tümü"};

    public static readonly string[] Save = {
      "Save",
      "Сохранить",
      "Salva",
      "Speichern",
      "保存",
      "Guardar",
      "Enregistrer",
      "Kaydet"};

    public static readonly string[] Delete = {
      "Delete",
      "Удалить",
      "Eliminare",
      "Löschen",
      "删除",
      "Eliminar",
      "Supprimer",
      "Sil"};

    public static readonly string[] Deleting = {
      "Deleting...",
      "Удаление...",
      "Rimozione...",
      "Entfernung...",
      "移动...",
      "Eliminando...",
      "Suppression...",
      "Siliniyor..."};

    public static readonly string[] Nothing = {
      "Nothing",
      "Ничего",
      "Niente",
      "Nichts",
      "没有",
      "Nada",
      "Rien",
      "Hiçbir şey"};

    public static readonly string[] Check = {
      "Check",
      "Отметьте",
      "Dai un'occhiata",
      "Überprüfen",
      "查看",
      "Verificar",
      "Vérifier",
      "Kontrol et"};

    public static readonly string[] Options = {
      "Options",
      "Настройки",
      "Impostazioni",
      "Einstellungen",
      "选项",
      "Opciones",
      "Options",
      "Seçenekler"};

    public static readonly string[] EscPressed = {
      "Esc was pressed.",
      "Нажат Esc",
      "È stato premuto Esc.",
      "Esc wurde gedrückt.",
      "按下 ESC 键。",
      "Se presionó Esc.",
      "Esc a été pressé.",
      "Esc tuşuna basıldı."};

    public static readonly string[] FileNotFound = {
      "File not found {0}",
      "Нет файла {0}",
      "File non trovato {0}",
      "Datei nicht gefunden {0}",
      "找不到文件 {0}",
      "Archivo no encontrado {0}",
      "Fichier introuvable {0}",
      "Dosya bulunamadı {0}"};

    public static readonly string[] FileSaveErr = {
      "Failed to save file '{0}'.\r\n" +
        "Error {1}",
      "Не удалось сохранить файл '{0}'.\r\n" +
        "Ошибка {1}",
      "Impossibile salvare il file '{0}'.\r\n" +
        "Errore {1}",
      "Fehler beim Speichern der Datei '{0}'.\r\n" +
        "Fehler '{1}'",
      "保存文件失败'{0}'。错误 {1}",
      "No se pudo guardar el archivo '{0}'.\r\n" +
        "Error {1}",
      "Impossible d'enregistrer le fichier '{0}'.\r\n" +
        "Erreur {1}",
      "Dosya kaydedilemedi '{0}'.\r\n" +
        "Hata {1}"};

    public static readonly string[] CannotSend = {
      "Can't send message to programmer.",
      "Не удалось отправить сообщение по почте разработчику.",
      "Impossibile inviare il messaggio al programmatore.",
      "Ich kann keine Nachricht an den Programmentwickler senden.",
      "无法向程序员发送消息。",
      "No se puede enviar el mensaje al programador.",
      "Impossible d'envoyer le message au programmeur.",
      "Programcıya mesaj gönderilemiyor."};

    public static readonly string[] CannotSendMail = {
      "Can't send email message.",
      "Не удалось отправить почтовое сообщение.",
      "Impossibile inviare il messaggio di posta elettronica.",
      "Ich kann keine E-Mail-Nachricht senden.",
      "无法发送电子邮件消息。",
      "No se puede enviar el mensaje de correo electrónico.",
      "Impossible d'envoyer le message électronique.",
      "E-posta mesajı gönderilemiyor."};

    public static readonly string[] ParseLengthErr = {
      "The string cannot be recognized as a size",
      "Строку не получается распознать как размер",
      "La stringa non può essere riconosciuta come una dimensione",
      "Die Zeichenfolge kann nicht als Größe erkannt werden",
      "字符串无法识别为大小",
      "La cadena no puede ser reconocida como un tamaño",
      "La chaîne ne peut pas être reconnue comme une taille",
      "Dize bir boyut olarak tanınamıyor"};

    public static readonly string[] CommandCancel = {
      "\r\n  ❌ Command canceled",
      "\r\n  ❌ Команда отменена",
      "\r\n  ❌ Comando annullato",
      "\r\n  ❌ Vorgang abgebrochen",
      "\r\n  ❌ 命令已取消",
      "\r\n  ❌ Comando cancelado",
      "\r\n  ❌ Commande annulée",
      "\r\n  ❌ Komut iptal edildi"};

    public static readonly string[] Sorry = {
      "Sorry\r\n\r\n----  Under construction ----\r\n",
      "Извините.\r\n\r\n---- Функция пока находится в разработке ----\r\n",
      "Spiacente.\r\n\r\n---- In costruzione ----\r\n",
      "Es tut uns leid.\r\n\r\n---- Im Bau ---\r\n",
      "对不起\r\n\r\n-- 仍在开发中 🚧 --\r\n",
      "Lo siento\r\n\r\n---- En construcción ----\r\n",
      "Désolé\r\n\r\n---- En construction ----\r\n",
      "Üzgünüz\r\n\r\n---- Yapım aşamasında ----\r\n"};

    public static readonly string[] GeneralModelingFailure = {
      "Working with this object is not possible (eGeneralModelingFailure).",
      "Работа с данным объектом невозможна (eGeneralModelingFailure).",
      "Non è possibile lavorare con questo oggetto (eGeneralModelingFailure).",
      "Das Arbeiten mit diesem Objekt ist nicht möglich (eGeneralModelingFailure).",
      "无法使用此对象 (eGeneralModelingFailure)。",
      "No es posible trabajar con este objeto (eGeneralModelingFailure).",
      "Il n'est pas possible de travailler avec cet objet (eGeneralModelingFailure).",
      "Bu nesneyle çalışmak mümkün değil (eGeneralModelingFailure)."};

    public static readonly string[] ErrDoubleTolerance = {
      "Tolerance for type Double must be between 1 to 16 signification decimal digit",
      "Точность для типа Double должна быть от 1 до 16 значащих десятичных цифр",
      "La tolleranza per un Double deve essere da 1 a 16 cifre decimali significative",
      "Die Double Genauigkeit muss zwischen 1 und 16 signifikanten Dezimalstellen liegen.",
      "Double 类型的精度必须在 1 到 16 位有效十进制数字之间",
      "La tolerancia para el tipo Double debe estar entre 1 y 16 dígitos decimales significativos",
      "La tolérance pour le type Double doit être comprise entre 1 et 16 chiffres décimaux significatifs",
      "Double türü için tolerans 1 ile 16 anlamlı ondalık basamak arasında olmalıdır"};

    public static readonly string[] NothingSucceeded = {
      "❌ Nothing succeeded",
      "❌ Ничего не получилось",
      "❌ Niente è riuscito",
      "❌ Nichts war erfolgreich",
      "❌ 没有成功",
      "❌ Nada tuvo éxito",
      "❌ Rien n'a réussi",
      "❌ Hiçbir şey başarılı olmadı"};

    public static readonly string[] Process = {
      "Processing",
      "Обработка",
      "Elaborazione",
      "Verarbeitung",
      "加工",
      "Procesando",
      "Traitement",
      "İşleniyor"};

    public static readonly string[] ProcessedParts = {
      "  Processed {0} parts in {1}s",
      "  Обработано {0} деталей за {1}с",
      "  {0} parti elaborate in {1}s",
      "  Verarbeitete {0} Teile in {1} Sekunden",
      "  在 {1} 秒内处理了 {0} 个对象",
      "  Procesadas {0} piezas en {1}s",
      "  {0} pièces traitées en {1}s",
      "  {1} saniyede {0} parça işlendi"};

    public static readonly string[] ProcessedObjects = {
      "  Processed {0} objects in {1}s",
      "  Обработано {0} объектов за {1}с",
      "  {0} oggetti elaborati in {1} s",
      "  Verarbeitete {0} Objekte in {1}s",
      "  在 {1} 秒内处理了 {0} 个对象",
      "  Procesados {0} objetos en {1}s",
      "  {0} objets traités en {1}s",
      "  {1} saniyede {0} nesne işlendi"};

    public static readonly string[] CreatedObjects = {
      "  {0} objects created in {1}s",
      "  Создано {0} объектов(а) за {1}с",
      "  {0} oggetti creati in {1} secondi",
      "  {0} Objekte in {1} Sekunden erstellt",
      "  {1} 秒内创建 {0} 个对象",
      "  {0} objetos creados en {1}s",
      "  {0} objets créés en {1}s",
      "  {1} saniyede {0} nesne oluşturuldu"};

    public static readonly string[] Saving = {
      "Saving changes",
      "Сохранение изменений",
      "Salvataggio delle modifiche",
      "Änderungen speichern",
      "保存更改",
      "Guardando cambios",
      "Enregistrement des modifications",
      "Değişiklikler kaydediliyor"};

    public static readonly string[] RestartRequired = {
      "Restart required!",
      "Требуется перезагрузка!",
      "Riavvio richiesto!",
      "Neustart erforderlich!",
      "需要重启！",
      "¡Se requiere reiniciar!",
      "Redémarrage requis!",
      "Yeniden başlatma gerekli!"};

    public static readonly string[] DisplayingData = {
      "Displaying data...",
      "Отображение данных...",
      "Visualizzazione dei dati...",
      "Daten anzeigen...",
      "显示数据...",
      "Mostrando datos...",
      "Affichage des données...",
      "Veriler görüntüleniyor..."};

    public static readonly string[] Default = {
      "Default",
      "По умолчанию",
      "Predefinito",
      "Standard",
      "默认",
      "Predeterminado",
      "Par défaut",
      "Varsayılan"};

    public static readonly string[] NoSelected = {
      "Nothing selected",
      "Ничего не выбрано",
      "Niente di selezionato",
      "Nichts ausgewählt",
      "未选择任何内容",
      "Nada seleccionado",
      "Rien de sélectionné",
      "Hiçbir şey seçilmedi"};

    public static readonly string[] SavePrepare = {
      "Checking for Changes",
      "Проверка изменений",
      "Verifica delle modifiche",
      "Änderungen überprüfen",
      "检查更改",
      "Comprobando cambios",
      "Vérification des modifications",
      "Değişiklikler kontrol ediliyor"};

    public static readonly string[] Search = {
      "Search",
      "Поиск",
      "Ricerca",
      "Suche",
      "搜索",
      "Buscar",
      "Rechercher",
      "Ara"};

    public static readonly string[] Properties = {
      "Properties",
      "Свойства",
      "Proprietà",
      "Eigenschaften",
      "特性",
      "Propiedades",
      "Propriétés",
      "Özellikler"};

    public static readonly string[] Actions = {
      "Actions",
      "Действия",
      "Azioni",
      "Aktionen",
      "行动",
      "Acciones",
      "Actions",
      "Eylemler"};

    public static readonly string[] Language = {
      "Language",
      "Язык",
      "Linguaggio",
      "Sprache",
      "语言",
      "Idioma",
      "Langue",
      "Dil"};

  }
}