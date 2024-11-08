﻿// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class
  FileCopyL
  {

    public static readonly string[] Count = {
      "Failed to copy {0} files. Next try in {1} minutes.",
      "Не удалось скопировать {0} файлов. Следующая попытка через {1} минут.",
      "Impossibile copiare {0} file. Prossimo tentativo tra {1} minuti.",
      "{0}-Dateien konnten nicht kopiert werden. Nächster Versuch in {1} Minuten.",
      "未能复制 {0} 个文件。 {1} 分钟后再试。"};
    public static readonly string[] Break = {
      "The file copying process was forcibly interrupted.",
      "Процесс копирования файлов принудительно прерван.",
      "Il processo di copia dei file è stato interrotto forzatamente.",
      "Der Dateikopiervorgang wurde gewaltsam unterbrochen.",
      "文件复制过程被强行中断。"};
    public static readonly string[] NotCopied = {
      "During the allotted time, it was not possible to copy the file '{0}'.",
      "За отведенное время так и не удалось скопировать файл '{0}'.",
      "Durante il tempo assegnato, non è stato possibile copiare il file '{0}'.",
      "Während der zugewiesenen Zeit war es nicht möglich, die Datei '{0}' zu kopieren.",
      "在分配的时间内，无法复制文件“{0}”。"};
    public static readonly string[] Log = {
      "Message Log",
      "Журнал сообщений",
      "Registro messaggi",
      "Nachrichtenprotokoll",
      "消息日志" };
    public static readonly string[] Tasks = {
      "Copy tasks",
      "Задания копирования",
      "Copia lavori",
      "Jobs kopieren",
      "复制作业" };

    // ============================= Pack7z ==============================================
    public static readonly string[] No7z = {
      "The 7-Zip archiver was not found in the system. Download it from the 7-zip.org website and install it in the default folder {0}",
      "В системе не найден архиватор 7-Zip. Скачайте его с сайта 7-zip.org и установите в папку по умолчанию {0}",
      "L'archiviatore 7-Zip non è stato trovato nel sistema. Scaricalo dal sito web 7-zip.org e installalo nella cartella predefinita {0}",
      "Der 7-Zip-Archivierer wurde im System nicht gefunden. Laden Sie es von der Website 7-zip.org herunter und installieren Sie es im Standardordner {0}",
      "在系统中未找到 7-Zip 存档器。 从 7-zip.org 网站下载并安装到默认文件夹 {0}"};
    public static readonly string[] FatalErr = {
      "Fatal error of the 7zip archiver.",
      "Фатальная ошибка архиватора 7zip",
      "Errore irreversibile dell'archiver 7zip.",
      "Schwerwiegender Fehler des 7zip-Archivierers.",
      "7zip 归档程序的致命错误。"};
    public static readonly string[] ParamErr = {
      "Error in the command line of starting the 7zip archiver",
      "Ошибка в командной строке запуска архиватора 7zip",
      "Errore nella riga di comando dell'avvio dell'archiviatore 7zip",
      "Fehler in der Befehlszeile beim Starten des 7zip-Archivierers",
      "启动 7zip 压缩包的命令行出错"};
    public static readonly string[] UserCanceled = {
      "User canceled unpacking 7zip archive",
      "Пользователь отменил распаковку архива 7zip",
      "L'utente ha annullato la decompressione dell'archivio 7zip",
      "Benutzer hat das Entpacken des 7zip-Archivs abgebrochen",
      "用户取消解压 7zip 存档"};
  }
}
