// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: Ver

namespace AVC
{
  public static class 
  FileL
  {
    public static readonly string[] File = {
      "File",
      "Файл",
      "File",
      "Datei",
      "文件" };
    public static readonly string[] Folder = {
      "Folder",
      "Папка",
      "Cartella",
      "Mappe",
      "文件夹"};
    public static readonly string[] MkDir = {
      "Creating the directory '{0}'",
      "Создается каталог '{0}'",
      "Creazione di una directory '{0}'",
      "Verzeichnis wird erstellt '{0}'",
      "创建目录“{0}”"};
    public static readonly string[] PathNotExists = {
      "The path does not exist or is not available '{0}'",
      "Не существует или недоступен путь '{0}'",
      "Il percorso non esiste o non è disponibile '{0}'",
      "Verzeichnis wird erstellt '{0}'",
      "路径不存在或不可用“{0}”"};
    public static readonly string[] NoFile = {
      "File not specified",
      "Не задан файл",
      "File non specificato.",
      "Datei nicht angegeben.",
      "未指定文件"    };
    public static readonly string[] FileNotExist ={
      "File '{0}' does not exist",
      "Не существует файл '{0}'",
      "Il file '{0}' non esiste.",
      "Datei '{0}' existiert nicht.",
      "文件“{0}”不存在" };
    public static readonly string[] FailedReadFile ={
      "Failed to read file '{0}'\n\t{1}",
      "Не удалось прочитать файл '{0}'.\n\t{1}",
      "Impossibile leggere il file '{0}'.\n\t{1}",
      "Fehler beim Lesen der Datei '{0}'.\n\t{1}" ,
      "未能读取文件“{0}”\n\t{1}"   };
    public static readonly string[] FailedWriteFile ={
      "Failed to write file '{0}'.\n\t{1}",
      "Не удалось записать файл '{0}'.\n\t{1}",
      "Impossibile scrivere il file '{0}'.\n\t{1}",
      "Fehler beim Schreiben der Datei '{0}'.\n\t{1}",
      "无法写入文件“{0}”\n\t{1}"    };
    public static readonly string[] CopyError ={
      "Failed to copy file '{0}'.\n\t{1}",
      "Не удалось скопировать файл '{0}'.\n\t{1}",
      "Impossibile copiare il file '{0}'.\n\t{1}",
      "Fehler beim Kopieren der Datei '{0}'.\n\t{1}" ,
      "无法复制文件“{0}”。\n\t{1}"   };
    public static readonly string[] NotRequireUpdating =    {
      "Doesn't require updating file '{0}'.",
      "Не требует обновлять файл '{0}'.",
      "Non richiede l'aggiornamento del file '{0}'.",
      "Die Datei '{0}' muss nicht aktualisiert werden." ,
      "不需要更新文件“{0}”。"   };
    public static readonly string[] CopyingFile =    {
      "Copying file '{0}' to folder '{1}'.",
      "Копирование файла '{0}' в папку '{1}'.",
      "Copia del file '{0}' nella cartella '{1}'.",
      "Kopieren der Datei '{0}' in den Ordner '{1}'." ,
      "正在将文件“{0}”复制到文件夹“{1}”。"   };
    public static readonly string[] FileCopied ={
      "Successfully copied '{0}' \tto '{1}'",
      "Скопирован файл '{0}' \tв папку '{1}'",
      "Copiato con successo '{0}' \t-> '{1}'",
      "Erfolgreich kopiert '{0}' \t-> '{1}'" ,
      "已成功将“{0}”\t复制到“{1}”"   };
    public static readonly string[] FailedCopy ={
      "Failed to copy file '{0}' \tto folder '{1}'.",
      "Не удалось скопировать файл '{0}' \tв папку '{1}'.",
      "Impossibile copiare il file '{0}' \tnella cartella '{1}'.",
      "Fehler beim Kopieren der Datei '{0}' \tin den Ordner '{1}'." ,
      "无法复制文件“{0}”\tto 文件夹“{1}”。"   };
    public static readonly string[] DelOldVerErr ={
      "Error deleting old versions of file '{0}'",
      "Ошибка удаления старых версий файла '{0}'.",
      "Errore durante l'eliminazione delle vecchie versioni del file '{0}'",
      "Fehler beim Löschen alter Versionen der Datei '{0}'",
      "删除旧版本的文件“{0}”时出错"    };
    public static readonly string[] OldVerErr ={
      "Error moving file '{0}' to OldVersions.\n\t{1}",
      "Ошибка перемещения файла '{0}' в OldVersions.\n\t{1}",
      "Errore durante lo spostamento del file '{0}' in OldVersions.\n\t{1}",
      "Fehler beim Verschieben der Datei '{0}' nach OldVersions.\n\t{1}" ,
      "将文件“{0}”移动到旧版本时出错。\n\t{1}"   };
    public static readonly string[] DelOldFileErr ={
      "Failed to delete old file '{0}'.\n\t{1}",
      "Не получилось удалить старый файл '{0}'.\n\t{1}",
      "Impossibile eliminare il vecchio file '{0}'.\n\t{1}",
      "Fehler beim Löschen der alten Datei '{0}'.\n\t{1}"  ,
      "未能删除旧文件“{0}”。\n\t{1}"  };
    public static readonly string[] ACLCopyError ={
      "Error copying file rights '{0}'.\n\t{1}",
      "Ошибка копирования прав файла '{0}'.\n\t{1}",
      "Errore durante la copia dei diritti del file '{0}'.\n\t{1}",
      "Fehler beim Kopieren der Dateirechte '{0}'.\n\t{1}" ,
      "复制文件权限“{0}”时出错。\n\t{1}"   };
    public static readonly string[] TooLongPath ={
      "Path to folder is too long. On Windows, only 248 characters are allowed. '{0}'",
      "Слишком длинный путь к папке. В Windows допускается только 248 символов. '{0}'",
      "Il percorso della cartella è troppo lungo. Su Windows, sono consentiti solo 248 caratteri. '{0}'",
      "Der Pfad zum Ordner ist zu lang. Unter Windows sind nur 248 Zeichen zulässig. '{0}'" ,
      "文件夹路径太长。 在 Windows 上，只允许 248 个字符。 “{0}”"   };
    public static readonly string[] ClearDirErr = {
      "Failed to clean up folder {0}: {1}",
      "Не удалось почистить папку {0}: {1}",
      "Impossibile pulire la cartella {0}: {1}",
      "Fehler beim Bereinigen des Ordners {0}: {1}",
      "未能清理文件夹 {0}：{1}" };
    public static readonly string[] FileDeleteErr = {
      "Failed to delete file {0}: {1}",
      "Не удалось удалить файл {0}: {1}",
      "Impossibile eliminare il file {0}: {1}",
      "Fehler beim Löschen der Datei {0}: {1}",
      "未能删除文件 {0}：{1}" };
    public static readonly string[] DirDeleteErr = {
      "Failed to delete directory {0}: {1}",
      "Не удалось удалить каталог {0}: {1}",
      "Impossibile eliminare la directory {0}: {1}",
      "Fehler beim Löschen des Verzeichnisses {0}}: {1}",
      "未能删除目录 {0}：{1}" };
    public static readonly string[] DirDeleted = {
      "Deleted directory {0}",
      "Удален каталог {0}",
      "Directory eliminata {0}",
      "Gelöschtes Verzeichnis {0}",
      "已删除目录 {0}" };
    public static readonly string[] DeletePlugin = {
      "Delete old plugin {0}...",
      "Удаление старого плагина {0}...",
      "Rimozione del vecchio plug-in {0}...",
      "Entfernen des alten Plugins {0}...",
      "删除旧插件 {0}..." };
    public static readonly string[] CreateLnkErr = {
      "Failed to create shortcut",
      "Сбой при создании ярлыка",
      "Impossibile creare il collegamento",
      "Verknüpfung konnte nicht erstellt werden",
      "创建快捷方式失败" };
  }
}
