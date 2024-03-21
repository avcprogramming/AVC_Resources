﻿// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  BlockMetricL
  {
    public static readonly string[,] BMStyleNames = {
/* 0 */ { "Metrics", "Метрика", "Metrica", "Metriken", "指标" },
/* 1 */ { "Metrics", "Метрика", "Metrica", "Metriken", "指标"},
        };

    public static readonly string[] SelectBlock = {
      "Select block",
      "Выберите блок",
      "Seleziona blocco",
      "Block auswählen",
      "选择块"};
    public static readonly string[] AttributeErr = {
      "Invalid attribute name. Illegal characters were used or the name matched another attribute.",
      "Недопустимое имя атрибута. Использованы запрещенные символы или имя совпало с другим атрибутом.",
      "Nome attributo non valido. Sono stati utilizzati caratteri illegali o il nome corrispondeva a un altro attributo.",
      "Ungültiger Attributname. Es wurden unzulässige Zeichen verwendet oder der Name stimmte mit einem anderen Attribut überein.",
      "无效的属性名称。 使用了非法字符或名称与另一个属性匹配。"};

    public static readonly string[] StyleNameTip = {
      "The name for this style. Not used in the program. Only for convenience of choice.",
      "Имя для данного стиля настроек. Не используется в программе. Просто для вашего удобства.",
      "Il nome di questo stile. Non utilizzato nel programma. Solo per comodità di scelta.",
      "Der Name für diesen Stil. nicht im Programm verwendet. Nur zur Bequemlichkeit der Wahl.",
      "此样式的名称。 没有在程序中使用。 只为方便选择。" };
    public static readonly string[] SelectedInfoText = {
      "The filter by object type will be applied only to the selection of measured objects within the blocks.",
      "Фильтр по типу объектов будет применен только для выбора измеряемых объектов внутри блоков.",
      "Il filtro per tipo di oggetto verrà applicato solo per selezionare gli oggetti misurati all'interno dei blocchi.",
      "Der Filter nach Objekttyp wird nur auf die Auswahl von Messobjekten innerhalb der Blöcke angewendet.",
      "按对象类型的过滤器将仅应用于块内测量对象的选择。" };
    public static readonly string[] AttributesText = {
      "Attribute names (tags)",
      "Имена (теги) атрибутов",
      "Nomi degli attributi (tag)",
      "Attributnamen (Tags)",
      "属性名称（标签）" };
    public static readonly string[] AttributesInfo = {
      "The names of the attributes are the same for all styles of the Block Metrics.",
      "Имена (теги) атрибутов одинаковые для всех стилей Метрики Блока.",
      "I nomi (tag) degli attributi sono gli stessi per tutti gli stili di Blocco Metrica.",
      "Die Namen der Attribute sind für alle Stile der Blockmetriken gleich.",
      "块度量命令的所有样式的属性名称都是相同的。" };

    public static readonly string[] Measured = {
      "  Measured {0} blocks",
      "  Обмерено блоков: {0}" ,
      "  {0} blocchi misurati",
      "  {0} Blöcke gemessen.",
      "  测量{0}块。"};

    public static readonly string[] AttributesTip = {
      "Add a list of modifiable attributes to the measured block. \r\n" +
        "Write each attribute on a new line. \r\n" +
        "You can also specify a default value after the = symbol. \r\n" +
        "In the default value, you can use substitutions for block properties, old attributes, or drawing properties.",
      "Добавьте список изменяемых атрибутов к обмеряемому блоку. \r\n" +
        "Каждый атрибут пишите в новой строке. \r\n" +
        "Вы можете так же указать значение по умолчанию после символа =. \r\n" +
        "В значении по умолчанию вы можете использовать подстановки свойств блока, старых атрибутов или свойств чертежа.",
      "Aggiungere un elenco di attributi modificabili al blocco misurato. \r\n" +
        "Scrivi ogni attributo su una nuova riga. \r\n" +
        "È inoltre possibile specificare un valore predefinito dopo il simbolo =. \r\n" +
        "Nel valore predefinito è possibile utilizzare le sostituzioni per le proprietà del blocco, \r\n" +
        "i vecchi attributi o le proprietà del disegno.",
      "Fügen Sie dem gemessenen Block eine Liste änderbarer Attribute hinzu. \r\n" +
        "Schreiben Sie jedes Attribut in eine neue Zeile. \r\n" +
        "Sie können auch einen Standardwert nach dem Symbol = angeben. \r\n" +
        "Im Standardwert können Sie Ersetzungen für Blockeigenschaften, \r\n" +
        "alte Attribute oder Zeichnungseigenschaften verwenden.",
      "将可修改属性列表添加到测量块。 \r\n" +
        "将每个属性写在一个新行上。 \r\n" +
        "您还可以在 = 符号后指定默认值。 \r\n" +
        "在默认值中，您可以使用替换块属性、旧属性或绘图属性。"};
    public static readonly string[] ConstantAttributes = {
      "Constant Attributes",
      "Константные атрибуты",
      "Attributi costanti",
      "Konstante Attribute",
      "常量属性"};
    public static readonly string[] ConstantAttributesTip = {
      "Add a list of constant attributes to the measured block. \r\n" +
        "These attributes have the same value for all references to this block. \r\n" +
        "They will not be visible in the properties panel, but they can be extracted into tables. \r\n" +
        "Write each attribute on a new line. \r\n" +
        "You can also specify a default value after the = symbol. \r\n" +
        "In the default value, you can use substitutions for block properties, old attributes, or drawing properties.",
      "Добавьте список константных атрибутов к обмеряемому блоку. \r\n" +
        "Эти атрибуты имеют одинаковое значение для всех ссылок на этот блок. \r\n" +
        "Они не будут видны в панели свойств, но их можно извлекать в таблицы. \r\n" +
        "Каждый атрибут пишите в новой строке. Вы можете так же указать значение по умолчанию после символа =. \r\n" +
        "В значении по умолчанию вы можете использовать подстановки свойств блока, старых атрибутов или свойств чертежа.",
      "Aggiungere un elenco di attributi costanti al blocco misurato. \r\n" +
        "Questi attributi hanno lo stesso valore per tutti i riferimenti a questo blocco. \r\n" +
        "Non saranno visibili nel pannello delle proprietà, ma potranno essere estratti in tabelle. \r\n" +
        "Scrivi ogni attributo su una nuova riga. \r\n" +
        "È inoltre possibile specificare un valore predefinito dopo il simbolo =. \r\n" +
        "Nel valore predefinito è possibile utilizzare le sostituzioni per le proprietà del blocco, \r\n" +
        "i vecchi attributi o le proprietà del disegno.",
      "Fügen Sie dem gemessenen Block eine Liste konstanter Attribute hinzu. \r\n" +
        "Diese Attribute haben für alle Verweise auf diesen Block den gleichen Wert. \r\n" +
        "Sie sind im Eigenschaftsfenster nicht sichtbar, können aber in Tabellen extrahiert werden. \r\n" +
        "Schreiben Sie jedes Attribut in eine neue Zeile. Sie können auch einen Standardwert nach dem Symbol = angeben. \r\n" +
        "Im Standardwert können Sie Ersetzungen für Blockeigenschaften, \r\n" +
        "alte Attribute oder Zeichnungseigenschaften verwenden.",
      "将常量属性列表添加到被测块。 \r\n" +
        "这些属性对于对该块的所有引用都具有相同的值。 \r\n" +
        "它们在属性面板中不可见，但可以提取到表中。 \r\n" +
        "将每个属性写在一个新行上。 \r\n" +
        "您还可以在 = 符号后指定默认值。 \r\n" +
        "在默认值中，您可以使用替换块属性、旧属性或绘图属性。"};
  }
}
