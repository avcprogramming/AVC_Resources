// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class
  FileCopyL
  {
    public static readonly string[] FileCopyVer = {
      "The file copying program for A>V>C> plugins is working: {0}. Version {1}",
      "Работает программа копирования файлов для плагинов A>V>C>: {0}. Версия {1}",
      "Il programma di copia dei file per i plugin A>V>C> funziona: {0}. Versione {1}",
      "Das Programm zum Kopieren von Dateien für A>V>C>-Plugins funktioniert.: {0}. Version {1}",
      "A>V>C>插件的文件复制程序正在运行：{0}。版本 {1}",
      "El programa de copia de archivos para complementos A>V>C> está funcionando: {0}. Versión {1}",
      "Le programme de copie de fichiers pour les plug-ins A>V>C> fonctionne: {0}. Version {1}",
      "A>V>C> eklentileri için dosya kopyalama programı çalışıyor: {0}. Sürüm {1}"};

    public static readonly string[] Count = {
      "Failed to copy {0} files. Next try in {1} minutes.",
      "Не удалось скопировать {0} файлов. Следующая попытка через {1} минут.",
      "Impossibile copiare {0} file. Prossimo tentativo tra {1} minuti.",
      "{0}-Dateien konnten nicht kopiert werden. Nächster Versuch in {1} Minuten.",
      "未能复制 {0} 个文件。 {1} 分钟后再试。",
      "No se pudieron copiar {0} archivos. Próximo intento en {1} minutos.",
      "Impossible de copier {0} fichiers. Prochaine tentative dans {1} minutes.",
      "{0} dosya kopyalanamadı. {1} dakika sonra tekrar deneyin."};

    public static readonly string[] Break = {
      "The file copying process was forcibly interrupted.",
      "Процесс копирования файлов принудительно прерван.",
      "Il processo di copia dei file è stato interrotto forzatamente.",
      "Der Dateikopiervorgang wurde gewaltsam unterbrochen.",
      "文件复制过程被强行中断。",
      "El proceso de copia de archivos fue interrumpido forzosamente.",
      "Le processus de copie de fichiers a été interrompu de force.",
      "Dosya kopyalama işlemi zorla kesildi."};

    public static readonly string[] NotCopied = {
      "During the allotted time, it was not possible to copy the file '{0}'.",
      "За отведенное время так и не удалось скопировать файл '{0}'.",
      "Durante il tempo assegnato, non è stato possibile copiare il file '{0}'.",
      "Während der zugewiesenen Zeit war es nicht möglich, die Datei '{0}' zu kopieren.",
      "在分配的时间内，无法复制文件'{0}'。",
      "Durante el tiempo asignado, no fue posible copiar el archivo '{0}'.",
      "Pendant le temps alloué, il n'a pas été possible de copier le fichier '{0}'.",
      "Ayrılan süre içinde '{0}' dosyası kopyalanamadı."};

    public static readonly string[] Log = {
      "Message Log",
      "Журнал сообщений",
      "Registro messaggi",
      "Nachrichtenprotokoll",
      "消息日志",
      "Registro de mensajes",
      "Journal des messages",
      "Mesaj günlüğü"};

    public static readonly string[] Tasks = {
      "Copy tasks",
      "Задания копирования",
      "Copia lavori",
      "Jobs kopieren",
      "复制作业",
      "Tareas de copia",
      "Tâches de copie",
      "Kopyalama görevleri"};

    // ============================= Pack7z ==============================================
    public static readonly string[] No7z = {
      "The 7-Zip archiver was not found in the system. Download it From the 7-zip.org website and install it in the default folder {0}",
      "В системе не найден архиватор 7-Zip. Скачайте его с сайта 7-zip.org и установите в папку по умолчанию {0}",
      "L'archiviatore 7-Zip non è stato trovato nel sistema. Scaricalo dal sito web 7-zip.org e installalo nella cartella predefinita {0}",
      "Der 7-Zip-Archivierer wurde im System nicht gefunden. Laden Sie es von der Website 7-zip.org herunter und installieren Sie es im Standardordner {0}",
      "在系统中未找到 7-Zip 存档器。 从 7-zip.org 网站下载并安装到默认文件夹 {0}",
      "El archivador 7-Zip no se encontró en el sistema. Descárguelo del sitio web 7-zip.org e instálelo en la carpeta predeterminada {0}",
      "L'archiveur 7-Zip n'a pas été trouvé dans le système. Téléchargez-le depuis le site web 7-zip.org et installez-le dans le dossier par défaut {0}",
      "Sistemde 7-Zip arşivleyici bulunamadı. 7-zip.org web sitesinden indirin ve varsayılan klasöre kurun {0}"};

    public static readonly string[] FatalErr = {
      "Fatal error of the 7zip archiver.",
      "Фатальная ошибка архиватора 7zip",
      "Errore irreversibile dell'archiver 7zip.",
      "Schwerwiegender Fehler des 7zip-Archivierers.",
      "7zip 归档程序的致命错误。",
      "Error fatal del archivador 7zip.",
      "Erreur fatale de l'archiveur 7zip.",
      "7zip arşivleyici önemli hatası."};

    public static readonly string[] ParamErr = {
      "Error in the command line of starting the 7zip archiver",
      "Ошибка в командной строке запуска архиватора 7zip",
      "Errore nella riga di comando dell'avvio dell'archiviatore 7zip",
      "Fehler in der Befehlszeile beim Starten des 7zip-Archivierers",
      "启动 7zip 压缩包的命令行出错",
      "Error en la línea de comandos al iniciar el archivador 7zip",
      "Erreur dans la ligne de commande de démarrage de l'archiveur 7zip",
      "7zip arşivleyiciyi başlatma komut satırında hata"};

    public static readonly string[] UserCanceled = {
      "User canceled unpacking 7zip archive",
      "Пользователь отменил распаковку архива 7zip",
      "L'utente ha annullato la decompressione dell'archivio 7zip",
      "Benutzer hat das Entpacken des 7zip-Archivs abgebrochen",
      "用户取消解压 7zip 存档",
      "El usuario canceló la descompresión del archivo 7zip",
      "L'utilisateur a annulé le déballage de l'archive 7zip",
      "Kullanıcı 7zip arşivinin açılmasını iptal etti"};
  }
}