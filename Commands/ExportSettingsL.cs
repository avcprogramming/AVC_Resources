// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  ExportSettingsL
  {
    public static readonly string[] Exported = {
      "Settings exported to file {0}",
      "Настройки экспортированы в файл {0}",
      "Impostazioni esportate nel file {0}",
      "Einstellungen in Datei {0} exportiert",
      "导出到文件 {0} 的设置",
      "Configuración exportada al archivo {0}",         // ES
      "Paramètres exportés vers le fichier {0}",       // FR
      "Ayarlar {0} dosyasına aktarıldı"};              // TR

    public static readonly string[] Imported = {
      "Settings imported from file {0}. \r\n" +
        "There are {1} entries in the registry.",
      "Настройки импортированы из файла {0}. \r\n" +
        "В реестр внесено {1} записей.",
      "Impostazioni importate dal file {0}. \r\n" +
        "Ci sono {1} voci nel registro.",
      "Aus Datei {0} importierte Einstellungen. \r\n" +
        "Es gibt {1} Einträge in der Registrierung.",
      "从文件 {0} 导入的设置. \r\n" +
        "注册表中有 {1} 个条目。",
      "Configuración importada desde el archivo {0}. \r\n" +  // ES
        "Hay {1} entradas en el registro.",
      "Paramètres importés depuis le fichier {0}. \r\n" +  // FR
        "Il y a {1} entrées dans le registre.",
      "{0} dosyasından ayarlar içe aktarıldı. \r\n" +  // TR
        "Kayıt defterinde {1} giriş var."};

    public static readonly string[] Removed = {
      "All settings are removed from the registry.",
      "Все настройки удалены из реестра.",
      "Tutte le impostazioni vengono rimosse dal registro.",
      "Alle Einstellungen werden aus der Registrierung entfernt.",
      "所有设置都从注册表中删除。",
      "Todas las configuraciones se eliminan del registro.",  // ES
      "Tous les paramètres sont supprimés du registre.",  // FR
      "Tüm ayarlar kayıt defterinden kaldırılır."};   // TR

    public static readonly string[] ExportHint =  {
      "You can save all settings of all A>V>C> programs to a file.\r\n" +
        "This file will help you restore settings on a new Windows or other computer, " +
        "synchronize the settings of all your computers, " +
        "use common settings for all engineers in your workgroup.\r\n" +
        "You can set up automatic export and import to a network folder or cloud storage.",
      "Вы можете сохранить все настройки всех программ A>V>C> в файл. \r\n" +
        "Этот файл поможет вам восстановить настройки на новой Windows или другом компьютере, " +
        "синхронизировать настройки всех ваших компьютеров, " +
        "использовать общие настройки у всех инженеров вашей рабочей группы. \r\n" +
        "Вы можете настроить автоматический экспорт и импорт в сетевую папку или облачное хранилище.",
      "È possibile salvare tutte le impostazioni di tutti i programmi A>V>C> in un file.\r\n" +
        "Questo file ti aiuterà a ripristinare le impostazioni su un nuovo computer Windows o altro, " +
        "sincronizzare le impostazioni di tutti i tuoi computer, " +
        "utilizzare impostazioni comuni per tutti gli ingegneri nel tuo gruppo di lavoro.\r\n" +
        "È possibile impostare l'esportazione e l'importazione automatiche in una cartella di rete " +
        "o in un archivio cloud.",
      "Sie können alle Einstellungen aller Programme A>V>C> in einer Datei speichern.\r\n" +
        "Diese Datei hilft Ihnen, die Einstellungen auf einem neuen Windows- oder anderen Computer wiederherzustellen, " +
        "die Einstellungen aller Ihrer Computer zu synchronisieren " +
        "und gemeinsame Einstellungen für alle Ingenieure in Ihrer Arbeitsgruppe zu verwenden.\r\n" +
        "Sie können den automatischen Export und Import in einen Netzwerkordner oder Cloud-Speicher einrichten.",
      "您可以将所有程序 A>V>C> 的所有设置保存到一个文件中。\r\n" +
        "该文件将帮助您在新的 Windows 或其他计算机上恢复设置，同步所有计算机的设置，\r\n" +
        "为工作组中的所有工程师使用通用设置。\r\n" +
        "您可以设置自动导出和导入到网络文件夹或云存储。",
      "Puede guardar todas las configuraciones de todos los programas A>V>C> en un archivo.\r\n" +  // ES
        "Este archivo le ayudará a restaurar la configuración en una nueva computadora Windows u otra, " +
        "sincronizar la configuración de todas sus computadoras, " +
        "usar configuraciones comunes para todos los ingenieros en su grupo de trabajo.\r\n" +
        "Puede configurar la exportación e importación automática a una carpeta de red o almacenamiento en la nube.",
      "Vous pouvez enregistrer tous les paramètres de tous les programmes A>V>C> dans un fichier.\r\n" +  // FR
        "Ce fichier vous aidera à restaurer les paramètres sur un nouvel ordinateur Windows ou autre, " +
        "à synchroniser les paramètres de tous vos ordinateurs, " +
        "à utiliser des paramètres communs pour tous les ingénieurs de votre groupe de travail.\r\n" +
        "Vous pouvez configurer l'exportation et l'importation automatiques vers un dossier réseau ou un stockage cloud.",
      "Tüm A>V>C> programlarının tüm ayarlarını bir dosyaya kaydedebilirsiniz.\r\n" +  // TR
        "Bu dosya, ayarları yeni bir Windows veya başka bir bilgisayarda geri yüklemenize, " +
        "tüm bilgisayarlarınızın ayarlarını senkronize etmenize, " +
        "çalışma grubunuzdaki tüm mühendisler için ortak ayarları kullanmanıza yardımcı olacaktır.\r\n" +
        "Bir ağ klasörüne veya bulut depolamaya otomatik dışa aktarma ve içe aktarma ayarlayabilirsiniz."};

    public static readonly string[] Reset =  {
      "Reset",
      "Сброс настроек",
      "Ripristina",
      "Zurücksetzen",
      "重置",
      "Restablecer",                                   // ES
      "Réinitialiser",                                 // FR
      "Sıfırla"};                                      // TR

    public static readonly string[] ResetTip =  {
      "Reset the settings of all A>V>C> programs to their default values. \r\n" +
        "All A>V>C> settings will be permanently deleted from the Windows registry. \r\n" +
        "Only licenses will remain. Export settings and reset them to find the causes of errors. \r\n" +
        "It is recommended to reset the settings before importing. \r\n" +
        "You can reset the settings of individual programs: use the button in the header of each settings tab.",
      "Вернуть настройки всех программ A>V>C> к значениям по умолчанию. \r\n" +
        "Все настройки A>V>C> будут безвозвратно удалены из реестра Windows. \r\n" +
        "Сохранятся только лицензии.\r\n" +
        "Экспортируйте настройки и сбросьте их для поиска причин ошибок. \r\n" +
        "Рекомендуется сбрасывать настройки перед импортом. \r\n" +
        "Вы можете сбросить настройки отдельных программ: \r\n" +
        "используйте кнопку в заголовке каждой вкладки настроек.",
      "Ripristina le impostazioni di tutti i programmi A>V>C> sui valori predefiniti. \r\n" +
        "Tutte le impostazioni A>V>C> verranno eliminate definitivamente dal registro di Windows. \r\n" +
        "Rimarranno solo le licenze. Esporta le impostazioni e ripristinale per trovare le cause degli errori. \r\n" +
        "Si consiglia di ripristinare le impostazioni prima dell'importazione. \r\n" +
        "È possibile ripristinare le impostazioni dei singoli programmi: \r\n" +
        "utilizzare il pulsante nell'intestazione di ogni scheda delle impostazioni.",
      "Setzen Sie die Einstellungen aller A>V>C>-Programme auf ihre Standardwerte zurück. \r\n" +
        "Alle A>V>C>-Einstellungen werden dauerhaft aus der Windows-Registrierung gelöscht. \r\n" +
        "Es bleiben nur Lizenzen. Einstellungen exportieren und zurücksetzen, um Fehlerursachen zu finden. \r\n" +
        "Es wird empfohlen, die Einstellungen vor dem Import zurückzusetzen. \r\n" +
        "Sie können die Einstellungen einzelner Programme zurücksetzen: \r\n" +
        "Verwenden Sie die Schaltfläche in der Kopfzeile jedes Einstellungsregisters.",
      "将所有程序 A>V>C> 的设置重置为其默认值。 \r\n" +
        "所有 A>V>C> 设置将从 Windows 注册表中永久删除。 \r\n" +
        "只保留许可证。 \r\n" +
        "导出设置并重置它们以查找错误原因。 \r\n" +
        "建议在导入前重置设置。 \r\n" +
        "您可以重置单个程序的设置：使用每个设置选项卡标题中的按钮。",
      "Restablezca la configuración de todos los programas A>V>C> a sus valores predeterminados. \r\n" +  // ES
        "Todas las configuraciones de A>V>C> se eliminarán permanentemente del registro de Windows. \r\n" +
        "Solo quedarán las licencias. Exporte la configuración y restablézcala para encontrar las causas de los errores. \r\n" +
        "Se recomienda restablecer la configuración antes de importar. \r\n" +
        "Puede restablecer la configuración de programas individuales: \r\n" +
        "use el botón en el encabezado de cada pestaña de configuración.",
      "Réinitialisez les paramètres de tous les programmes A>V>C> à leurs valeurs par défaut. \r\n" +  // FR
        "Tous les paramètres A>V>C> seront définitivement supprimés du registre Windows. \r\n" +
        "Seules les licences resteront. Exportez les paramètres et réinitialisez-les pour trouver les causes des erreurs. \r\n" +
        "Il est recommandé de réinitialiser les paramètres avant l'importation. \r\n" +
        "Vous pouvez réinitialiser les paramètres de programmes individuels : \r\n" +
        "utilisez le bouton dans l'en-tête de chaque onglet de paramètres.",
      "Tüm A>V>C> programlarının ayarlarını varsayılan değerlerine sıfırlayın. \r\n" +  // TR
        "Tüm A>V>C> ayarları Windows kayıt defterinden kalıcı olarak silinecektir. \r\n" +
        "Sadece lisanslar kalacaktır. Hataların nedenlerini bulmak için ayarları dışa aktarın ve sıfırlayın. \r\n" +
        "İçe aktarmadan önce ayarları sıfırlamanız önerilir. \r\n" +
        "Bireysel programların ayarlarını sıfırlayabilirsiniz: \r\n" +
        "her ayar sekmesinin başlığındaki düğmeyi kullanın."};

    public static readonly string[] Export =  {
      "Export settings",
      "Экспорт настроек",
      "Esporta impostazioni",
      "Exporteinstellungen",
      "导出设置",
      "Exportar configuración",                        // ES
      "Exporter les paramètres",                       // FR
      "Ayarları dışa aktar"};                          // TR

    public static readonly string[] ExportTip =  {
      "Save settings of all A>V>C> programs to .reg file",
      "Сохранить настройки всех программ A>V>C> в reg-файл",
      "Salva le impostazioni di tutti i programmi A>V>C> nel file .reg",
      "Speichern Sie die Einstellungen aller A>V>C>-Programme in einer .reg-Datei",
      "将所有 A>V>C> 程序的设置保存到 .reg 文件",
      "Guardar la configuración de todos los programas A>V>C> en archivo .reg",  // ES
      "Enregistrer les paramètres de tous les programmes A>V>C> dans un fichier .reg",  // FR
      "Tüm A>V>C> programlarının ayarlarını .reg dosyasına kaydedin"};  // TR

    public static readonly string[] Import =  {
      "Import settings",
      "Импорт настроек",
      "Importa impostazioni",
      "Importeinstellungen",
      "导入设置",
      "Importar configuración",                        // ES
      "Importer les paramètres",                       // FR
      "Ayarları içe aktar"};                           // TR

    public static readonly string[] ImportTip =  {
      "Load all settings from the reg file into the registry. \r\n" +
        "All sections that are in the file will be loaded, not just section A>V>C>.",
      "Загрузить все настройки из reg-файла в реестр. \r\n" +
        "Будут загружены все разделы, которые есть в фале, а не только раздел A>V>C>.",
      "Carica tutte le impostazioni dal file reg nel registro. \r\n" +
        "Verranno caricate tutte le sezioni che sono nel file, non solo la sezione A>V>C>.",
      "Laden Sie alle Einstellungen aus der Reg-Datei in die Registrierung. \r\n" +
        "Alle in der Datei enthaltenen Abschnitte werden geladen, nicht nur Abschnitt A>V>C>.",
      "将 reg 文件中的所有设置加载到注册表中。 \r\n" +
        "将加载文件中的所有部分，而不仅仅是 A>V>C> 部分。",
      "Cargue toda la configuración del archivo reg en el registro. \r\n" +  // ES
        "Se cargarán todas las secciones que están en el archivo, no solo la sección A>V>C>.",
      "Chargez tous les paramètres du fichier reg dans le registre. \r\n" +  // FR
        "Toutes les sections qui se trouvent dans le fichier seront chargées, pas seulement la section A>V>C>.",
      "Reg dosyasındaki tüm ayarları kayıt defterine yükleyin. \r\n" +  // TR
        "Dosyada bulunan tüm bölümler yüklenecektir, sadece A>V>C> bölümü değil."};

    public static readonly string[] ExportAccount =  {
      "A>V>C> account",
      "Аккаунт A>V>C>",
      "Account A>V>C>",
      "A>V>C>-Konto",
      "A>V>C> 帐户",
      "Cuenta A>V>C>",                                 // ES
      "Compte A>V>C>",                                 // FR
      "A>V>C> hesabı"};                                // TR

    public static readonly string[] ExportAccountTip =  {
      "Save and load e-mail and A>V>C> account name. \r\n" +
        "If you use the same settings file for your entire design team, then disable this option.",
      "Сохранять и загружать e-mail и имя учетной записи A>V>C>. \r\n" +
        "Если вы используете один файл настроек во всей вашей команде проектировщиков, то отключите эту опцию.",
      "Salva e carica e-mail e nome account A>V>C>. \r\n" +
        "Se stai utilizzando lo stesso file delle impostazioni per l'intero team di progettazione, \r\n" +
        "disabilita questa opzione.",
      "E-Mail und A>V>C>-Kontonamen speichern und laden. \r\n" +
        "Wenn Sie dieselbe Einstellungsdatei für Ihr gesamtes Designteam verwenden, deaktivieren Sie diese Option.",
      "保存和加载电子邮件和 A>V>C> 帐户名称。 \r\n" +
        "如果您为整个设计团队使用相同的设置文件，请禁用此选项。",
      "Guardar y cargar correo electrónico y nombre de cuenta A>V>C>. \r\n" +  // ES
        "Si usa el mismo archivo de configuración para todo su equipo de diseño, desactive esta opción.",
      "Enregistrer et charger l'e-mail et le nom du compte A>V>C>. \r\n" +  // FR
        "Si vous utilisez le même fichier de paramètres pour toute votre équipe de conception, désactivez cette option.",
      "E-posta ve A>V>C> hesap adını kaydedin ve yükleyin. \r\n" +  // TR
        "Tüm tasarım ekibiniz için aynı ayar dosyasını kullanıyorsanız, bu seçeneği devre dışı bırakın."};

    public static readonly string[] ExportForm =  {
      "Window settings",
      "Настройки окон",
      "Impostazioni della finestra",
      "Fenstereinstellungen",
      "窗口设置",
      "Configuración de ventana",                      // ES
      "Paramètres de la fenêtre",                      // FR
      "Pencere ayarları"};                             // TR

    public static readonly string[] ExportFormTip =  {
      "Save a section with the sizes and arrangement of windows, \r\n" +
        "panels and input forms (those that are not saved by CAD itself). \r\n" +
        "It is recommended to disable if the import will be on devices with different monitor sizes.",
      "Сохранять раздел с размерами и расположением окон, панелей и форм ввода \r\n" +
        "(те, что не сохраняет сам CAD). \r\n" +
        "Рекомендуется отключить, если импорт будет на устройствах с другим размером мониторов.",
      "Salva una sezione con le dimensioni e la disposizione di finestre, \r\n" +
        "pannelli e moduli di input (quelli che non vengono salvati dal CAD stesso). \r\n" +
        "Si consiglia di disabilitare se l'importazione avverrà su dispositivi con monitor di dimensioni diverse.",
      "Speichern Sie einen Abschnitt mit den Größen und Anordnungen von Fenstern, \r\n" +
        "Bedienfeldern und Eingabeformularen (die nicht von CAD selbst gespeichert werden). \r\n" +
        "Es wird empfohlen, dies zu deaktivieren, \r\n" +
        "wenn der Import auf Geräten mit unterschiedlichen Monitorgrößen erfolgen soll.",
      "保存具有窗口、面板和输入表单的大小和排列的部分（那些不是由 CAD 本身保存的）。 \r\n" +
        "如果导入将在具有不同显示器尺寸的设备上进行，建议禁用。",
      "Guardar una sección con los tamaños y disposición de ventanas, \r\n" +  // ES
        "paneles y formularios de entrada (aquellos que no son guardados por CAD mismo). \r\n" +
        "Se recomienda desactivar si la importación será en dispositivos con diferentes tamaños de monitor.",
      "Enregistrer une section avec les tailles et l'arrangement des fenêtres, \r\n" +  // FR
        "panneaux et formulaires de saisie (ceux qui ne sont pas enregistrés par CAD lui-même). \r\n" +
        "Il est recommandé de désactiver si l'importation se fera sur des appareils avec différentes tailles de moniteur.",
      "Pencereler, paneller ve giriş formlarının boyutları ve düzenlemesiyle bir bölüm kaydedin \r\n" +  // TR
        "(CAD'nin kendisi tarafından kaydedilmeyenler). \r\n" +
        "İçe aktarma farklı monitör boyutlarına sahip cihazlarda olacaksa devre dışı bırakmanız önerilir."};

    public static readonly string[] ExportHistory =  {
      "Input history",
      "Истории ввода",
      "Сronologia di input",
      "Eingabeverlauf",
      "输入历史",
      "Historial de entrada",                          // ES
      "Historique de saisie",                          // FR
      "Giriş geçmişi"};                                // TR

    public static readonly string[] ExportHistoryTip =  {
      "Keep a section with lists of last entered values. \r\n" +
        "It is recommended to disable if other users will be importing.",
      "Сохранять раздел со списками последних введенных значений. \r\n" +
        "Рекомендуется отключить, если импортировать будут другие пользователи.",
      "Conserva una sezione con gli elenchi degli ultimi valori inseriti. \r\n" +
        "Si consiglia di disabilitare se verranno importati altri utenti.",
      "Bewahren Sie einen Abschnitt mit Listen der zuletzt eingegebenen Werte auf. \r\n" +
        "Es wird empfohlen, dies zu deaktivieren, wenn andere Benutzer importieren.",
      "保留一个包含最后输入值列表的部分。 \r\n" +
        "如果其他用户将要导入，建议禁用。",
      "Mantener una sección con listas de los últimos valores ingresados. \r\n" +  // ES
        "Se recomienda desactivar si otros usuarios importarán.",
      "Conserver une section avec des listes de dernières valeurs saisies. \r\n" +  // FR
        "Il est recommandé de désactiver si d'autres utilisateurs importeront.",
      "Son girilen değerlerin listeleriyle bir bölüm tutun. \r\n" +  // TR
        "Diğer kullanıcılar içe aktaracaksa devre dışı bırakmanız önerilir."};

    public static readonly string[] ExportUpdater =  {
      "Auto-update settings",
      "Настройки автообновлений",
      "Impostazioni di aggiornamento automatico",
      "Einstellungen für automatische Aktualisierung",
      "自动更新设置",
      "Configuración de actualización automática",     // ES
      "Paramètres de mise à jour automatique",         // FR
      "Otomatik güncelleme ayarları"};                 // TR

    public static readonly string[] ExportUpdaterTip =  {
      "Save and load settings related to the A>V>C> automatic software update system",
      "Сохранять и загружать настройки связанные с системой автоматических обновлений программ A>V>C>",
      "Salva e carica le impostazioni relative al sistema di aggiornamento automatico del software A>V>C>",
      "Speichern und laden Sie Einstellungen im Zusammenhang mit dem automatischen Softwareaktualisierungssystem von A>V>C>",
      "保存和加载与 A>V>C> 自动软件更新系统相关的设置",
      "Guardar y cargar configuraciones relacionadas con el sistema de actualización automática de software A>V>C>",  // ES
      "Enregistrer et charger les paramètres liés au système de mise à jour automatique du logiciel A>V>C>",  // FR
      "A>V>C> otomatik yazılım güncelleme sistemiyle ilgili ayarları kaydedin ve yükleyin"};  // TR

    public static readonly string[] AutoExport =  {
      "Export automatically",
      "Экспортировать автоматически",
      "Esporta automaticamente",
      "Automatisch exportieren",
      "自动导出",
      "Exportar automáticamente",                      // ES
      "Exporter automatiquement",                      // FR
      "Otomatik olarak dışa aktar"};                   // TR

    public static readonly string[] AutoExportTip =  {
      "Save settings to a .reg file each time you exit the settings dialog \r\n" +
        "and before exiting the program. \r\n" +
        "This way you can back up the settings \r\n" +
        "and synchronize the settings with your other computers or with other users.",
      "Сохранять настройки в reg-файл каждый раз, \r\n" +
        "при выходе из диалога настроек и перед выходом из программы. \r\n" +
        "Таким образом вы сможете создать резервную копию настроек \r\n" +
        "и синхронизировать настройки с вашими другими компьютерами или с другими пользователями.",
      "Salva le impostazioni in un file .reg ogni volta che esci dalla finestra di dialogo delle impostazioni \r\n" +
        "e prima di uscire dal programma. \r\n" +
        "In questo modo è possibile eseguire il backup delle impostazioni \r\n" +
        "e sincronizzare le impostazioni con gli altri computer o con altri utenti.",
      "Speichern Sie die Einstellungen jedes Mal in einer .reg-Datei, \r\n" +
        "wenn Sie den Einstellungsdialog verlassen und bevor Sie das Programm beenden. \r\n" +
        "Auf diese Weise können Sie die Einstellungen sichern \r\n" +
        "und die Einstellungen mit Ihren anderen Computern oder mit anderen Benutzern synchronisieren.",
      "每次退出设置对话框和退出程序之前，将设置保存到 .reg 文件。 \r\n" +
        "这样，您可以备份设置并将设置与您的其他计算机或其他用户同步",
      "Guarde la configuración en un archivo .reg cada vez que salga del diálogo de configuración \r\n" +  // ES
        "y antes de salir del programa. \r\n" +
        "De esta manera puede hacer una copia de seguridad de la configuración \r\n" +
        "y sincronizar la configuración con sus otras computadoras o con otros usuarios.",
      "Enregistrez les paramètres dans un fichier .reg à chaque fois que vous quittez la boîte de dialogue des paramètres \r\n" +  // FR
        "et avant de quitter le programme. \r\n" +
        "De cette façon, vous pouvez sauvegarder les paramètres \r\n" +
        "et synchroniser les paramètres avec vos autres ordinateurs ou avec d'autres utilisateurs.",
      "Ayarlar iletişim kutusundan her çıktığınızda \r\n" +  // TR
        "ve programdan çıkmadan önce ayarları bir .reg dosyasına kaydedin. \r\n" +
        "Bu şekilde ayarları yedekleyebilir \r\n" +
        "ve ayarları diğer bilgisayarlarınızla veya diğer kullanıcılarla senkronize edebilirsiniz."};

    public static readonly string[] AutoImport =  {
      "Import automatically",
      "Импортировать автоматически",
      "Importa automaticamente",
      "Automatisch importieren",
      "自动导入",
      "Importar automáticamente",                      // ES
      "Importer automatiquement",                      // FR
      "Otomatik olarak içe aktar"};                    // TR

    public static readonly string[] AutoImportTip =  {
      "Load settings from the .reg file every time you enter the program and when you change the .reg file. \r\n" +
         "For example, the import will start automatically as soon as another user exports a file in the cloud or on the server.",
      "Загружать настройки из reg-файла каждый раз при входе в программу и при изменении reg-файла. \r\n" +
        "Например, импорт начнется автоматически, как только файл в облаке или на сервере экспортирует другой пользователь.",
      "Carica le impostazioni dal file .reg ogni volta che accedi al programma e quando modifichi il file .reg. \r\n" +
         "Ad esempio, l'importazione verrà avviata automaticamente \r\n" +
        "non appena un altro utente esporta un file nel cloud o sul server.",
      "Laden Sie Einstellungen aus der .reg-Datei jedes Mal, wenn Sie das Programm aufrufen und wenn Sie die .reg-Datei ändern. \r\n" +
         "Zum Beispiel startet der Import automatisch, \r\n" +
        "sobald ein anderer Benutzer eine Datei in die Cloud oder auf den Server exportiert.",
      "每次进入程序和更改 .reg 文件时，都从 .reg 文件加载设置。 \r\n" +
         "例如，一旦另一个用户在云或服务器上导出文件，导入就会自动开始。",
      "Cargue la configuración desde el archivo .reg cada vez que ingrese al programa y cuando cambie el archivo .reg. \r\n" +  // ES
         "Por ejemplo, la importación comenzará automáticamente tan pronto como otro usuario exporte un archivo en la nube o en el servidor.",
      "Chargez les paramètres depuis le fichier .reg chaque fois que vous entrez dans le programme et lorsque vous modifiez le fichier .reg. \r\n" +  // FR
         "Par exemple, l'importation démarrera automatiquement dès qu'un autre utilisateur exportera un fichier dans le cloud ou sur le serveur.",
      "Programa her girdiğinizde ve .reg dosyasını değiştirdiğinizde .reg dosyasından ayarları yükleyin. \r\n" +  // TR
         "Örneğin, başka bir kullanıcı bulutta veya sunucuda bir dosyayı dışa aktarır aktarmaz içe aktarma otomatik olarak başlayacaktır."};

    public static readonly string[] MakeImportQuery =  {
      "Import permission request",
      "Запрос разрешения на импорт",
      "Richiesta di autorizzazione all'importazione",
      "Berechtigungsanfrage importieren",
      "进口许可申请",
      "Solicitud de permiso de importación",           // ES
      "Demande d'autorisation d'importation",          // FR
      "İçe aktarma izni talebi"};                      // TR

    public static readonly string[] MakeImportQueryTip =  {
      "Ask for permission to import settings when a new .reg file appears. \r\n" +
        "If the option is disabled, then the settings from the file will \r\n" +
        "be imported without warning as soon as a new .reg file is found.",
      "Запрашивать разрешение на импорт настроек при появлении нового reg-файла. \r\n" +
        "Если опция отключена, то настройки из файла будут \r\n" +
        "импортированы без предупреждения, как только найдется новый reg-файл.",
      "Chiedi l'autorizzazione per importare le impostazioni quando viene visualizzato un nuovo file .reg. \r\n" +
        "Se l'opzione è disabilitata, le impostazioni del file verranno \r\n" +
        "importate senza preavviso non appena viene trovato un nuovo file .reg.",
      "Fragen Sie um Erlaubnis zum Importieren von Einstellungen, wenn eine neue .reg-Datei angezeigt wird. \r\n" +
        "Wenn die Option deaktiviert ist, werden die Einstellungen aus der Datei ohne Warnung importiert, \r\n" +
        "sobald eine neue .reg-Datei gefunden wird.",
      "出现新的 .reg 文件时请求导入设置的权限。 \r\n" +
        "如果该选项被禁用，那么一旦找到新的 .reg 文件，文件中的设置就会被导入而不会发出警告。",
      "Solicite permiso para importar configuraciones cuando aparezca un nuevo archivo .reg. \r\n" +  // ES
        "Si la opción está deshabilitada, entonces la configuración del archivo se \r\n" +
        "importará sin advertencia tan pronto como se encuentre un nuevo archivo .reg.",
      "Demandez l'autorisation d'importer des paramètres lorsqu'un nouveau fichier .reg apparaît. \r\n" +  // FR
        "Si l'option est désactivée, alors les paramètres du fichier seront \r\n" +
        "importés sans avertissement dès qu'un nouveau fichier .reg est trouvé.",
      "Yeni bir .reg dosyası göründüğünde ayarları içe aktarma izni isteyin. \r\n" +  // TR
        "Seçenek devre dışı bırakılırsa, dosyadaki ayarlar \r\n" +
        "yeni bir .reg dosyası bulunur bulunmaz uyarı olmadan içe aktarılacaktır."};

    public static readonly string[] File =  {
      "Folder and file name",
      "Папка и имя файла",
      "Cartella e nome file",
      "Ordner- und Dateiname",
      "文件夹和文件名",
      "Carpeta y nombre de archivo",                   // ES
      "Dossier et nom de fichier",                     // FR
      "Klasör ve dosya adı"};                          // TR

    public static readonly string[] FileTip =  {
      "Path and name of the .reg file for automatically saving and restoring settings. \r\n" +
        "Specify the path on the backup disk, or in the cloud storage folder (Dropbox, Google-disk), \r\n" +
        "or a shared folder on the server of your workgroup.",
      "Путь и имя reg-файл для автоматического сохранения и восстановления настроек. \r\n" +
        "Укажите путь на резервном диске, или в папке облачного хранилища (Dropbox, Google-disk), \r\n" +
        "или общую папку на сервере вашей рабочей группы.",
      "Percorso e nome del file .reg per salvare e ripristinare automaticamente le impostazioni. \r\n" +
        "Specifica il percorso sul disco di backup, o nella cartella di archiviazione cloud (Dropbox, Google-disk) \r\n" +
        "o in una cartella condivisa sul server del tuo gruppo di lavoro.",
      "Pfad und Name der .reg-Datei zum automatischen Speichern und Wiederherstellen von Einstellungen. \r\n" +
        "Geben Sie den Pfad auf dem Sicherungsdatenträger oder im Cloud-Speicherordner (Dropbox, Google-Datenträger) \r\n" +
        "oder einem freigegebenen Ordner auf dem Server Ihrer Arbeitsgruppe an.",
      "用于自动保存和恢复设置的 .reg 文件的路径和名称。 \r\n" +
        "在备份磁盘、云存储文件夹或工作组服务器上的共享文件夹中指定路径。",
      "Ruta y nombre del archivo .reg para guardar y restaurar automáticamente la configuración. \r\n" +  // ES
        "Especifique la ruta en el disco de respaldo, o en la carpeta de almacenamiento en la nube (Dropbox, Google-disk), \r\n" +
        "o una carpeta compartida en el servidor de su grupo de trabajo.",
      "Chemin et nom du fichier .reg pour enregistrer et restaurer automatiquement les paramètres. \r\n" +  // FR
        "Spécifiez le chemin sur le disque de sauvegarde, ou dans le dossier de stockage cloud (Dropbox, Google-disk), \r\n" +
        "ou un dossier partagé sur le serveur de votre groupe de travail.",
      "Ayarları otomatik olarak kaydetmek ve geri yüklemek için .reg dosyasının yolu ve adı. \r\n" +  // TR
        "Yedekleme diskindeki yolu veya bulut depolama klasöründe (Dropbox, Google-disk) \r\n" +
        "veya çalışma grubunuzun sunucusundaki paylaşılan bir klasörü belirtin."};

    public static readonly string[] OpenFolderTip =  {
      "Select a folder to store the settings in the file",
      "Выбрать папку для хранения настроек в файле",
      "Selezionare una cartella in cui memorizzare le impostazioni nel file",
      "Wählen Sie einen Ordner aus, um die Einstellungen in der Datei zu speichern",
      "选择一个文件夹来存储文件中的设置",
      "Seleccione una carpeta para almacenar la configuración en el archivo",  // ES
      "Sélectionnez un dossier pour stocker les paramètres dans le fichier",  // FR
      "Ayarları dosyada saklamak için bir klasör seçin"};  // TR

    public static readonly string[] FileNotFound = {
      "No access to settings file {0}",
      "Нет доступа к файлу с настройками {0}",
      "Nessun accesso al file delle impostazioni {0}",
      "Kein Zugriff auf die Einstellungsdatei {0}",
      "无法访问设置文件 {0}",
      "No hay acceso al archivo de configuración {0}",  // ES
      "Aucun accès au fichier de paramètres {0}",      // FR
      "Ayar dosyasına {0} erişim yok" };               // TR

    public static readonly string[] FileIsNotSet = {
      "The file for automatic import/export of settings is not set",
      "Не задан файл для автоматического импорта/экспорта настроек",
      "Il file per l'importazione/esportazione automatica delle impostazioni non è impostato",
      "Die Datei für den automatischen Import/Export von Einstellungen ist nicht eingestellt",
      "设置的自动导入/导出文件未设置",
      "El archivo para importación/exportación automática de configuración no está establecido",  // ES
      "Le fichier pour l'importation/exportation automatique des paramètres n'est pas défini",  // FR
      "Ayarların otomatik içe/dışa aktarımı için dosya ayarlanmamış" };  // TR

    public static readonly string[] AutoImportFileTest = {
      "Search for updated settings file {0}",
      "Поиск обновленного файла настроек {0}",
      "Cerca il file delle impostazioni aggiornato {0}",
      "Nach aktualisierter Einstellungsdatei {0} suchen",
      "搜索更新的设置文件 {0}",
      "Buscar archivo de configuración actualizado {0}",  // ES
      "Rechercher le fichier de paramètres mis à jour {0}",  // FR
      "Güncellenmiş ayar dosyasını ara {0}" };         // TR

    public static readonly string[] AutoImportStart = {
      "Loading new settings from file {0}...",
      "Загружаются новые настройки из файла {0}...",
      "Caricamento nuove impostazioni dal file {0}...",
      "Laden neuer Einstellungen aus Datei {0}...",
      "正在从文件 {0} 加载新设置...",
      "Cargando nueva configuración desde el archivo {0}...",  // ES
      "Chargement de nouveaux paramètres depuis le fichier {0}...",  // FR
      "{0} dosyasından yeni ayarlar yükleniyor..." };  // TR

    public static readonly string[] ImportQuery = {
      "A new .reg file with settings has been found. Import settings?",
      "Обнаружен новый reg-файл с настройками. Импортировать настройки?",
      "È stato trovato un nuovo file .reg con le impostazioni. Importare le impostazioni?",
      "Eine neue .reg-Datei mit Einstellungen wurde gefunden. Importeinstellungen?",
      "已找到带有设置的新 .reg 文件。 导入设置？",
      "Se ha encontrado un nuevo archivo .reg con configuración. ¿Importar configuración?",  // ES
      "Un nouveau fichier .reg avec des paramètres a été trouvé. Importer les paramètres ?",  // FR
      "Ayarları içeren yeni bir .reg dosyası bulundu. Ayarları içe aktar?" };  // TR

    public static string[] FirstRun = {
      "{0} first launched on this computer.\r\n" +
        "Version {1} is working.\r\nHappy use!\r\n\r\n" +
        "If you have an old REG file with A>V>C> settings, you can restore the settings right now.\r\n\r\n" +
         "Restore settings?",
      "{0} впервые запущен на этом компьютере.\r\n" +
        "Работает версия {1}.\r\nСчастливого использования!\r\n\r\n" +
        "Если у вас есть старый REG-файл с настройками A>V>C>, то вы можете восстановить настройки прямо сейчас.\r\n\r\n" +
        "Восстановить настройки?",
      "{0} avviato per la prima volta su questo computer.\r\n" +
        "La versione {1} funziona.\r\nBuon utilizzo!\r\n\r\n" +
        "Se hai un vecchio file REG con impostazioni A>V>C>, puoi ripristinare le impostazioni adesso.\r\n\r\n" +
         "Ripristinare le impostazioni?",
      "{0} wurde zuerst auf diesem Computer gestartet.\r\n" +
        "Version {1} funktioniert.\r\nViel Spaß beim Gebrauch!\r\n\r\n" +
        "Wenn Sie eine alte REG-Datei mit A>V>C>-Einstellungen haben, können Sie die Einstellungen sofort wiederherstellen.\r\n\r\n" +
         "Einstellungen zurücksetzen?",
      "{0} 首次在此计算机上启动。\r\n" +
        "版本 {1} 正在运行。\r\n祝您使用愉快！\r\n\r\n" +
        "如果你有一个带有 A>V>C> 设置的旧 REG 文件，你可以立即恢复设置。\r\n\r\n" +
         "恢复设置？",
      "{0} iniciado por primera vez en esta computadora.\r\n" +  // ES
        "La versión {1} está funcionando.\r\n¡Feliz uso!\r\n\r\n" +
        "Si tiene un archivo REG antiguo con configuración A>V>C>, puede restaurar la configuración ahora mismo.\r\n\r\n" +
         "¿Restaurar configuración?",
      "{0} lancé pour la première fois sur cet ordinateur.\r\n" +  // FR
        "La version {1} fonctionne.\r\nBonne utilisation !\r\n\r\n" +
        "Si vous avez un ancien fichier REG avec des paramètres A>V>C>, vous pouvez restaurer les paramètres maintenant.\r\n\r\n" +
         "Restaurer les paramètres ?",
      "{0} bu bilgisayarda ilk kez başlatıldı.\r\n" +  // TR
        "Sürüm {1} çalışıyor.\r\nİyi kullanımlar!\r\n\r\n" +
        "A>V>C> ayarlarına sahip eski bir REG dosyanız varsa, ayarları hemen geri yükleyebilirsiniz.\r\n\r\n" +
         "Ayarları geri yükle?"};

    public static string[] NewVersion = {
      "New version launched {0} {1}",
      "Запущена новая версия {0} {1}",
      "New version launched {0} {1}",
      "Neue Version gestartet {0} {1}",
      "新版本发布 {0} {1}",
      "Nueva versión lanzada {0} {1}",                 // ES
      "Nouvelle version lancée {0} {1}",               // FR
      "Yeni sürüm başlatıldı {0} {1}"};                // TR

  }
}