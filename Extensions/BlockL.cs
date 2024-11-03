// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация методов для работы с блоками
  /// </summary>
  public static class
  BlockL
  {
    public static readonly string[] LayoutErr = {
      "Sheets, anonymous blocks, and xrefs cannot be used in this command.",
      "Нельзя использовать в этой команде листы, анонимные блоки и внешние ссылки.",
      "Fogli, blocchi anonimi e xrif non possono essere utilizzati in questo comando.",
      "Blätter, anonyme Blöcke und XRefs können in diesem Befehl nicht verwendet werden.",
      "表格、匿名块和外部链接不能在此命令中使用。"};
    public static readonly string[] BlockMissing = {
      "The definition of the block \"{0}\" is missing in the file :\n\r\"{1}\"",
      "Определение блока \"{0}\" отсутствует в файле :\n\r\"{1}\"",
      "Blocco di definizione \"{0}\" manca nel file :\n\r\"{1}\"",
      "Der Definitionsblock \"{0}\" fehlt in der Datei :\n\r\"{1}\"",
      "文件 {1} 中缺少块定义 {0}" };
    public static readonly string[] CannotExplode = {
      "Can't explode block {0}: {1}",
      "Невозможно взорвать блок {0}: {1}",
      "Impossibile esplodere il blocco {0}: {1}",
      "Block kann nicht explodiert werden {0}: {1}",
      "无法分解块 {0}: {1}" };
    public static readonly string[] MechanicalCompErr = {
      "Failed to get Mechanical component properties.\n{0}",
      "Не удалось получить свойства компонента Mechanical.\n{0}",
      "Impossibile ottenere le proprietà dei componenti Meccanici.\n{0}",
      "Mechanische Komponenteneigenschaften konnten nicht ermittelt werden.\n{0}",
      "无法获取机械组件属性。\n{0}" };
    public static readonly string[] CreateBlock = {
      "  Creating a block {0}...",
      "  Создание блока {0}...",
      "  La creazione di blocco {0}...",
      "  Block {0} erstellen...",
      "  块创建 {0}..." };
    public static readonly string[] Itself = {
      "It is inadmissible to copy the block to itself. It is recommended to first explode blocks",
      "Недопустимо копирование блока в самого себя. Рекомендуется сначала взорвать блоки",
      "Blocco copia inaccettabile in sé. Si raccomanda di far saltare in aria prima i blocchi.",
      "Das Kopieren eines Blocks in sich selbst ist nicht zulässig. Es wird empfohlen, zuerst die Blöcke zu sprengen",
      "不允许将块复制到自身。 建议先炸掉方块" };
    public static readonly string[] Optimization = {
      "  Block optimization...",
      "  Оптимизируем блок...",
      "  Ottimizzazione del blocco...",
      "  Wir optimieren den Block...",
      "  优化块..." };
    public static readonly string[] OldPlace = {
      "  Put the block on the old place...",
      "  Вставляем блок на старое место...",
      "  Abbiamo messo il blocco al vecchio posto...",
      "  Wir setzen den Block an der alten Stelle ein...",
      "  将块放回原位..." };
    public static readonly string[] CopingBlock = {
      "Coping the block to new drawing",
      "Копируем блок в новый чертеж",
      "Copiare il nuovo blocco nel disegno",
      "Kopieren Sie den Block in eine neue Zeichnung",
      "将块复制到新图形" };
    public static readonly string[] FileOpenErr = {
      "{0}\nThe block could not be written to file {1}. Is the file open in another window?",
      "{0}\nНе удалось записать блок в файл {1}. Возможно файл открыт в другом окне?",
      "{0}\nImpossibile scrivere blocco nel file {1}. Forse il file è aperto in un'altra finestra?",
      "{0}\nFehler beim Schreiben des Blocks in die Datei {1}. Vielleicht ist die Datei in einem anderen Fenster geöffnet?",
      "{0}\n未能将块写入文件 {1}。 文件是否在另一个窗口中打开？" };
    public static readonly string[] ParameterValueErr = {
      "The value {0} is not suitable for parameter {1}",
      "Значение {0} не подходит для параметра {1}",
      "Il valore {0} non è adatto per il parametro {1}.",
      "Der Wert {0} ist für Parameter {1} nicht geeignet.",
      "值 {0} 不适用于参数 {1}" };
    public static readonly string[] BlockNotFound = {
      "Block '{0}' not found ",
      "Блок '{0}' не найден",
      "Blocco '{0}' non trovato",
      "Block „{0}“ nicht gefunden",
      "未找到块“{0}”" };
    public static readonly string[] ComponentsReading = {
      "Reading all objects in space {0}",
      "Считывание всех объектов пространства {0}",
      "Lettura di tutti gli oggetti nello spazio {0}",
      "Alle Objekte im Weltraum lesen {0}",
      "读取空间 {0} 中的所有对象"    };

  }
}
