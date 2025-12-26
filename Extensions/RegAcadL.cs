// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Acad

namespace AVC
{
  /// <summary>
  /// Локализация методов для работы с реестром Windows в разделе AutoCAD
  /// </summary>
  public static class
  RegAcadL
  {
    public static readonly string[] AutorunDeleted = {
      "Plugin {0} was already at startup. Delete the old entry.",
      "Плагин {0} уже был в автозагрузке. Удаляем старую запись.",
      "Il plug-in {0} era già all'avvio. Cancelliamo il vecchio record.",
      "Plugin {0} war bereits beim Start. Wir löschen den alten Datensatz.",
      "插件 {0} 已在启动。 删除旧条目。",
      "El complemento {0} ya estaba en el inicio. Eliminar la entrada antigua.",
      "Le plug-in {0} était déjà au démarrage. Supprimer l'ancienne entrée.",
      "Eklenti {0} zaten başlangıçta vardı. Eski girişi sil."};

    public static readonly string[] AutorunRegistered = {
      "Plugin {0} is registered in startup for version '{1}'.",
      "Плагин {0} прописан в автозагрузку для версии '{1}'.",
      "Il plug-in {0} è registrato all'avvio per '{1}'.",
      "Plugin {0} ist beim Start für '{1}' registriert.",
      "插件 {0} 在启动时为版本'{1}'注册。",
      "El complemento {0} está registrado en el inicio para la versión '{1}'.",
      "Le plug-in {0} est enregistré au démarrage pour la version '{1}'.",
      "Eklenti {0}, '{1}' sürümü için başlangıçta kayıtlı."};

    public static readonly string[] KeyNotFound = {
      "Registry key {0} not found",
      "Раздел реестра {0} не найден",
      "Chiave di registro {0} non trovata",
      "Registrierungsschlüssel {0} nicht gefunden",
      "未找到注册表 {0}",
      "Clave de registro {0} no encontrada",
      "Clé de registre {0} introuvable",
      "Kayıt defteri anahtarı {0} bulunamadı"};

    public static readonly string[] AddingAutorun = {
      "Adding {0} to BricsCAD autorun...",
      "Добавление {0} в автозапуск BricsCAD ...",
      "Aggiunta di {0} all'esecuzione automatica di BricsCAD...",
      "{0} zu BricsCAD Autorun hinzugefügt...",
      "将 {0} 添加到 BricsCAD 自动运行...",
      "Agregando {0} al inicio automático de BricsCAD...",
      "Ajout de {0} au démarrage automatique de BricsCAD...",
      "{0} BricsCAD otomatik başlatmaya ekleniyor..."};

    public static readonly string[] FileErr = {
      "Failed to write file {0}: {1}",
      "Не удалось записать файл {0}: {1}",
      "Impossibile scrivere il file {0}: {1}",
      "Fehler beim Schreiben der Datei {0}: {1}",
      "未能写入文件 {0}：{1}",
      "No se pudo escribir el archivo {0}: {1}",
      "Impossible d'écrire le fichier {0}: {1}",
      "Dosya {0} yazılamadı: {1}"};
  }
}