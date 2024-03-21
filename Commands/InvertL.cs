// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  InvertL
  {
    public static readonly string[] ObjectIsolationMode = {
      "Attention!! " +
        "The program is switched to the mode of saving the visibility of objects in the dwg file " +
        "(ObjectIsolationMode = 1). " +
        "Hidden objects will not become visible after reboot." ,
      "Внимание!! " +
        "Программа переключена в режим сохранения видимости объектов в dwg-файле (ObjectIsolationMode =1). " +
        "Скрытые объекты не станут видимыми после перезагрузки.",
      "Attenzione!! " +
        "Il programma passa alla modalità di salvataggio della visibilità degli oggetti nel file dwg " +
        "(ObjectIsolationMode = 1). Gli oggetti nascosti non diventeranno visibili dopo il riavvio.",
      "Beachtung!! " +
        "Das Programm wechselt in den Modus zum Speichern der Sichtbarkeit von Objekten in der DWG-Datei " +
        "(ObjectIsolationMode = 1). " +
        "Versteckte Objekte werden nach dem Neustart nicht sichtbar.",
      "注意力！ " +
         "程序切换到在 dwg 文件中保存对象可见性的模式" +
         "（ObjectIsolationMode = 1）。" +
         "隐藏的对象在重启后将不可见。"};
    public static readonly string[] Failed = {
      "Failed to switch visibility for object {0}. Visible = {1}",
      "Не получилось переключить видимость у объекта {0}. Visible = {1}",
      "Impossibile cambiare la visibilità per l'oggetto {0}. Visible = {1}",
      "Fehler beim Wechseln der Sichtbarkeit für Objekt {0}. Visible = {1}",
      "无法切换对象 {0} 的可见性。 可见 = {1}"    };
    public static readonly string[] NotAvailable = {
      "The visibility property is not available for object {0}.",
      "Недоступно свойство видимости для объекта  {0}. ",
      "La proprietà visibilità non è disponibile per l'oggetto {0}.",
      "Die Sichtbarkeitseigenschaft ist für das Objekt {0} nicht verfügbar.",
      "对象 {0} 的可见性属性不可用。"    };
    public static readonly string[] VarErr = {
      "Can't change the ONJECTINSOLATIONMODE system variable.",
      "Не получается изменить системную переменную ONJECTINSOLATIONMODE.",
      "Impossibile modificare la variabile di sistema ONJECTINSOLATIONMODE.",
      "Die Systemvariable ONJECTINSOLATIONMODE kann nicht geändert werden.",
      "无法更改 ONJECTINSOLATIONMODE 系统变量。"    };
    public static readonly string[] Count = {
      "  Visibility changed - {0}",
      "  Изменена видимость - {0}",
      "  Visibilità cambiata - {0}",
      "  Sichtbarkeit geändert - {0}",
      "  可见性已更改 - {0}"    };

  }
}
