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
         "隐藏的对象在重启后将不可见。",
      "¡Atención! " +  // ES
        "El programa se ha cambiado al modo de guardar la visibilidad de objetos en el archivo dwg " +
        "(ObjectIsolationMode = 1). " +
        "Los objetos ocultos no se volverán visibles después del reinicio.",
      "Attention !! " +  // FR
        "Le programme est passé en mode de sauvegarde de la visibilité des objets dans le fichier dwg " +
        "(ObjectIsolationMode = 1). " +
        "Les objets cachés ne deviendront pas visibles après le redémarrage.",
      "Dikkat!! " +  // TR
        "Program, dwg dosyasındaki nesnelerin görünürlüğünü kaydetme moduna geçti " +
        "(ObjectIsolationMode = 1). " +
        "Gizli nesneler yeniden başlatma sonrasında görünür olmayacaktır."};

    public static readonly string[] Failed = {
      "Failed to switch visibility for object {0}. Visible = {1}",
      "Не получилось переключить видимость у объекта {0}. Visible = {1}",
      "Impossibile cambiare la visibilità per l'oggetto {0}. Visible = {1}",
      "Fehler beim Wechseln der Sichtbarkeit für Objekt {0}. Visible = {1}",
      "无法切换对象 {0} 的可见性。 可见 = {1}",
      "No se pudo cambiar la visibilidad del objeto {0}. Visible = {1}",  // ES
      "Échec du changement de visibilité pour l'objet {0}. Visible = {1}",  // FR
      "Nesne {0} için görünürlük değiştirilemedi. Visible = {1}"    };  // TR

    public static readonly string[] NotAvailable = {
      "The visibility property is not available for object {0}.",
      "Недоступно свойство видимости для объекта  {0}. ",
      "La proprietà visibilità non è disponibile per l'oggetto {0}.",
      "Die Sichtbarkeitseigenschaft ist für das Objekt {0} nicht verfügbar.",
      "对象 {0} 的可见性属性不可用。",
      "La propiedad de visibilidad no está disponible para el objeto {0}.",  // ES
      "La propriété de visibilité n'est pas disponible pour l'objet {0}.",  // FR
      "Görünürlük özelliği nesne {0} için kullanılamıyor."    };  // TR

    public static readonly string[] VarErr = {
      "Can't change the ONJECTINSOLATIONMODE system variable.",
      "Не получается изменить системную переменную ONJECTINSOLATIONMODE.",
      "Impossibile modificare la variabile di sistema ONJECTINSOLATIONMODE.",
      "Die Systemvariable ONJECTINSOLATIONMODE kann nicht geändert werden.",
      "无法更改 ONJECTINSOLATIONMODE 系统变量。",
      "No se puede cambiar la variable del sistema ONJECTINSOLATIONMODE.",  // ES
      "Impossible de modifier la variable système ONJECTINSOLATIONMODE.",  // FR
      "ONJECTINSOLATIONMODE sistem değişkeni değiştirilemiyor."    };  // TR

    public static readonly string[] Count = {
      "  Visibility changed - {0}",
      "  Изменена видимость - {0}",
      "  Visibilità cambiata - {0}",
      "  Sichtbarkeit geändert - {0}",
      "  可见性已更改 - {0}",
      "  Visibilidad cambiada - {0}",  // ES
      "  Visibilité modifiée - {0}",  // FR
      "  Görünürlük değiştirildi - {0}"    };  // TR

  }
}