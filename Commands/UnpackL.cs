// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class
  UnpackL
  {
    public static readonly string[] Select = {
      "Select blocks to unpack",
      "Выберите блоки для распаковки",
      "Seleziona i blocchi da decomprimere",
      "Wählen Sie die zu entpackenden Blöcke aus",
      "选择要解压的块",
      "Seleccione bloques para desempaquetar",          // ES
      "Sélectionnez les blocs à déballer",              // FR
      "Açılacak blokları seçin"};                       // TR

    public static readonly string[] Result = {
      "  Blocks Exploded - {0}",
      "  Взорвано блоков - {0}",
      "  Blocchi esplosi - {0}",
      "  Explodierte Blöcke - {0}",
      "  块爆炸 - {0}",
      "  Bloques desempaquetados - {0}",                // ES
      "  Blocs éclatés - {0}",                          // FR
      "  Açılan bloklar - {0}" };                       // TR

    public static readonly string[] SaveErr = {
      "Cannot save xref file '{0}'.\n" +
        "The file is most likely open in another window.",
      "Не получается сохранить файл внешней ссылки '{0}'.\n" +
        "Скорее всего файл открыт в другом окне.",
      "Impossibile salvare il file xrif '{0}'.\n" +
        "Il file è molto probabilmente aperto in un'altra finestra.",
      "XRef-Datei '{0}' kann nicht gespeichert werden.\n" +
        "Die Datei wird höchstwahrscheinlich in einem anderen Fenster geöffnet.",
      "无法保存外部参照文件'{0}'。\n " +
        "该文件很可能在另一个窗口中打开。",
      "No se puede guardar el archivo de referencia externa '{0}'.\n" +  // ES
        "Lo más probable es que el archivo esté abierto en otra ventana.",
      "Impossible d'enregistrer le fichier de référence externe '{0}'.\n" +  // FR
        "Le fichier est probablement ouvert dans une autre fenêtre.",
      "Harici referans dosyası '{0}' kaydedilemiyor.\n" +  // TR
        "Dosya büyük olasılıkla başka bir pencerede açık." };

    public static readonly string[] ExtReadErr = {
      "Failed to process external reference '{0}'",
      "Не получилось обработать внешнюю ссылку '{0}'",
      "Impossibile elaborare il collegamento esterno '{0}'",
      "Fehler beim Verarbeiten des externen Links '{0}'",
      "无法处理外部链接'{0}'",
      "No se pudo procesar la referencia externa '{0}'",  // ES
      "Échec du traitement de la référence externe '{0}'",  // FR
      "Harici referans '{0}' işlenemedi" };             // TR

    public static readonly string[] DestinationPrompt = {
      "Select in which property of the solids to write the name of the unpacked block:",
      "Выберите, в какое свойство солидов записать имя распакованного блока: ",
      "Selezionare in quale proprietà dei solidi scrivere il nome del blocco spacchettato:",
      "Wählen Sie aus, in welche Eigenschaft der Volumenkörper der Name des entpackten Blocks geschrieben werden soll:",
      "选择在实体的哪个属性中写入解压块的名称：",
      "Seleccione en qué propiedad de los sólidos escribir el nombre del bloque desempaquetado:",  // ES
      "Sélectionnez dans quelle propriété des solides écrire le nom du bloc déballé :",  // FR
      "Açılan bloğun adının katıların hangi özelliğine yazılacağını seçin:" };  // TR

    // Опции командной строки
    public static readonly string[] DestinationKW = {
      "DEStination",
      "НАЗначение",
      "DEStinazione",
      "ZIEL",
      "目的地(DES)",
      "DEStino",                                        // ES
      "DEStination",                                    // FR
      "HEDef" };                                        // TR

    public static readonly string[] DestinationNameKW = {
      "Name",
      "ИМЯ",
      "Nome",
      "Name",
      "姓名(N)",
      "Nombre",                                         // ES
      "Nom",                                            // FR
      "İsim" };                                         // TR

    public static readonly string[] DestinationKindKW = {
      "Kind",
      "Сорт",
      "Tipo",
      "Art",
      "种类(K)",
      "Tipo",                                           // ES
      "Type",                                           // FR
      "Tür" };                                          // TR

    public static readonly string[] DestinationInfoKW = {
      "Info",
      "ИНФО",
      "Info",
      "Info",
      "信息(I)",
      "Info",                                           // ES
      "Info",                                           // FR
      "Bilgi" };                                        // TR

    public static readonly string[] DestinationLayerKW = {
      "Layer",
      "Слой",
      "Layer",
      "Layer",
      "图层(L)",
      "Capa",                                           // ES
      "Calque",                                         // FR
      "Katman" };                                       // TR
  }
}