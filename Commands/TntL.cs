// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  public static class
  TntL
  {
    public static readonly string[] SelectAssembly = {
      "  Select assembly consisting of Solid",
      "  Выберите сборку из деталей типа 3DSolid",
      "  Scegliere un assemblaggio da 3DSolid parts",
      "  Wählen Sie eine Baugruppe aus 3DSolid-Teilen",
      "  选择三维实体或装配体",
      "  Seleccione ensamblaje que consiste en sólidos",  // ES
      "  Sélectionnez un assemblage composé de solides",  // FR
      "  Katılardan oluşan montaj seçin"};            // TR

    public static readonly string[] SelectBlocks = {
      "  Select assembly blocks previously created by TNT command",
      "  Выберите блоки-сборки ранее созданные командой TNT",
      "  Seleziona i blocchi di assieme precedentemente creati dal comando TNT",
      "  Wählen Sie Montageblöcke aus, die zuvor mit dem TNT-Befehl erstellt wurden",
      "  选择之前由 TNT 命令创建的装配块",
      "  Seleccione bloques de ensamblaje creados previamente por el comando TNT",  // ES
      "  Sélectionnez les blocs d'assemblage créés précédemment par la commande TNT",  // FR
      "  TNT komutuyla daha önce oluşturulmuş montaj bloklarını seçin" };  // TR

    public static readonly string[] Need2 = {
      "  There is nothing to explode - you need at least 2 parts in the assembly",
      "  Нечего взрывать - нужны хотя бы 2 детали в сборке",
      "  Non c'è niente da far esplodere: sono necessarie almeno 2 parti nell'assemblaggio",
      "  Es gibt nichts zu sprengen – Sie benötigen mindestens 2 Teile für die Baugruppe",
      "  没有什么可以炸毁的 - 装配中至少需要 2 个零件",
      "  No hay nada que explotar: se necesitan al menos 2 piezas en el ensamblaje",  // ES
      "  Il n'y a rien à exploser - vous avez besoin d'au moins 2 pièces dans l'assemblage",  // FR
      "  Patlatacak bir şey yok - montajda en az 2 parçaya ihtiyacınız var" };  // TR

    public static readonly string[] Coordinates = {
      "  Specify the coordinates to insert the exploded assembly",
      "  Укажите координаты, куда вставить взорванную сборку",
      "  Specificare le coordinate per inserire il gruppo soffiato.",
      "  Geben Sie die Koordinaten zum Einfügen der geblasenen Baugruppe an.",
      "  指定插入点",
      "  Especifique las coordenadas para insertar el ensamblaje explotado",  // ES
      "  Spécifiez les coordonnées pour insérer l'assemblage éclaté",  // FR
      "  Patlatılmış montajı eklemek için koordinatları belirtin" };  // TR

    public static readonly string[] Force = {
      "  Set the force of the explosion",
      "  Задайте силу взрыва",
      "  Impostare la forza dell'esplosione",
      "  Stellen Sie die Stärke der Explosion ein",
      "  设置爆炸的力量",
      "  Establezca la fuerza de la explosión",       // ES
      "  Définissez la force de l'explosion",         // FR
      "  Patlamanın gücünü ayarlayın" };              // TR

    public static readonly string[] WorkWith2dKW = {
      "Process2d",
      "Обрабатывать2d",
      "Elaborare2d",
      "Verarbeiten2d",
      "其它对象(P)",
      "Procesar2d",                                    // ES
      "Traiter2d",                                     // FR
      "İşle2d"};                                       // TR

    public static readonly string[] WorkWith2dQuery = {
      "Process 2d-curves and other objects?",
      "Обрабатывать 2d-кривые и прочие объекты?",
      "Elaborare curve 2D e altri oggetti?",
      "2D-Kurven und andere Objekte verarbeiten?",
      "是否处理二维对象和其他对象？",
      "¿Procesar curvas 2D y otros objetos?",          // ES
      "Traiter les courbes 2D et autres objets ?",     // FR
      "2D eğrileri ve diğer nesneleri işle?" };        // TR

    public static readonly string[] WorkWith2dOn = {
      "The program will process 2d curves and all other objects",
      "Программа будет обрабатывать 2d-кривые и все прочие объекты",
      "Il programma elaborerà le curve 2d e tutti gli altri oggetti",
      "Das Programm verarbeitet 2D-Kurven und alle anderen Objekte",
      "该程序将处理二维对象和所有其他对象",
      "El programa procesará curvas 2D y todos los demás objetos",  // ES
      "Le programme traitera les courbes 2D et tous les autres objets",  // FR
      "Program 2D eğrileri ve diğer tüm nesneleri işleyecek" };  // TR

    public static readonly string[] ErrForce = {
      "  Force of the explosion mast be more 0. Value will be used {0}",
      "  Сила взрыва должна быть больше 0. Будет использовано значение {0}",
      "  La forza dell'esplosione deve essere maggiore di 0. Verrà utilizzato il valore: {0}",
      "  Die Explosionskraft muss größer als 0 sein. Der Wert wird verwendet: {0}",
      "  爆炸力必须大于0。将使用 {0}",
      "  La fuerza de la explosión debe ser mayor que 0. Se utilizará el valor {0}",  // ES
      "  La force de l'explosion doit être supérieure à 0. La valeur {0} sera utilisée",  // FR
      "  Patlama gücü 0'dan büyük olmalıdır. {0} değeri kullanılacaktır" };  // TR

    public static readonly string[] CloneErr = {
      "  Oops! Program can't clone solid",
      "  Упс! Не удалось клонировать солид",
      "  Oops! Impossibile clonare la parte",
      "  Ups! Teil konnte nicht geklont werden" ,
      "  哎呀！ 程序无法克隆实体",
      "  ¡Ups! El programa no puede clonar el sólido",  // ES
      "  Oups ! Le programme ne peut pas cloner le solide",  // FR
      "  Eyvah! Program katıyı kopyalayamıyor"};      // TR

    public static readonly string[] CentroidErr = {
      "  Oops! An error occurred while calculating the centroid of solid #{0}: {1}. Solid will be skipped",
      "  Упс! Ошибка во время вычисления центра масс солида №{0}: {1}. Солид будет пропущен",
      "  Ops! Si è verificato un errore durante il calcolo del baricentro del solido #{0}: {1}. Il solido verrà saltato",
      "  Hoppla! Beim Berechnen des Schwerpunkts des Festkörpers #{0} ist ein Fehler aufgetreten: {1}. Solid wird übersprungen",
      "  哎呀！ 计算三维实体 #{0} 的重心时出错: {1}. 三维实体将被跳过",
      "  ¡Ups! Ocurrió un error al calcular el centroide del sólido #{0}: {1}. El sólido será omitido",  // ES
      "  Oups ! Une erreur s'est produite lors du calcul du centroïde du solide #{0} : {1}. Le solide sera ignoré",  // FR
      "  Eyvah! #{0} katının ağırlık merkezini hesaplarken bir hata oluştu: {1}. Katı atlanacak"};  // TR

    public static readonly string[] ExtentsErr = {
      "  Oops! Failed to get the geometric center of object #{0}: {1}. The object will be skipped",
      "  Упс! Не удалось получить геометрический центр объекта №{0}: {1}. Объект будет пропущен",
      "  Ops! Impossibile ottenere il centro geometrico dell'oggetto #{0}: {1}. L'oggetto verrà saltato",
      "  Hoppla! Fehler beim Abrufen des geometrischen Mittelpunkts von Objekt Nr. {0}: {1}. Das Objekt wird übersprungen",
      "  哎呀！ 未能获取对象 #{0} 的几何中心：{1}。 该对象将被跳过",
      "  ¡Ups! No se pudo obtener el centro geométrico del objeto #{0}: {1}. El objeto será omitido",  // ES
      "  Oups ! Échec de l'obtention du centre géométrique de l'objet #{0} : {1}. L'objet sera ignoré",  // FR
      "  Eyvah! #{0} nesnesinin geometrik merkezi alınamadı: {1}. Nesne atlanacak"};  // TR

    public static readonly string[] NoCentroidBlock = {
      "  Block {0} does not contain solids and will be skipped",
      "  Блок {0} не содержит солидов и будет пропущен",
      "  Il blocco {0} non contiene solidi e verrà ignorato",
      "  Block {0} enthält keine Feststoffe und wird übersprungen",
      "  块 {0} 不包含实体，将被跳过",
      "  El bloque {0} no contiene sólidos y será omitido",  // ES
      "  Le bloc {0} ne contient pas de solides et sera ignoré",  // FR
      "  Blok {0} katı içermiyor ve atlanacak"};      // TR

    public static readonly string[] AsmCentroidErr = {
      "  Oops! Failed to calculate assembly center. Perhaps all the solids are filtered",
      "  Упс! Не удалось вычислить центр сборки. Возможно все солиды отфильтрованы",
      "  Ops! Impossibile calcolare il centro di assemblaggio. Forse tutti i solidi sono filtrati",
      "  Hoppla! Montagezentrum konnte nicht berechnet werden. Vielleicht werden alle Feststoffe gefiltert",
      "  哎呀！ 无法计算装配中心。 所选对象中无实体",
      "  ¡Ups! No se pudo calcular el centro del ensamblaje. Quizás todos los sólidos están filtrados",  // ES
      "  Oups ! Échec du calcul du centre d'assemblage. Peut-être que tous les solides sont filtrés",  // FR
      "  Eyvah! Montaj merkezi hesaplanamadı. Belki tüm katılar filtrelenmiş"};  // TR

    public static readonly string[] Done = {
      "Done objects {0}",
      "Разнесено объектов {0}",
      "Parti esplose {0}",
      "Explodierte Objekte {0}",
      "爆炸对象{0}",
      "Objetos explotados {0}",                        // ES
      "Objets éclatés {0}",                            // FR
      "Patlatılan nesneler {0}" };                     // TR

    public static readonly string[] ForceLess1 = {
      "  Force of less than 1. Details to collapse to the assembly center ",
      "  Сила взрыва меньше 1. Детали схлопнутся к центру сборки ",
      "  Forza di esplosione inferiore a 1. Le parti collassano al centro di assemblaggio",
      "  Explosionskraft weniger als 1. Teile fallen zum Montagezentrum zusammen",
      "  爆炸力小于1。零件会收缩到装配中心",
      "  Fuerza menor que 1. Los detalles se contraerán hacia el centro del ensamblaje",  // ES
      "  Force inférieure à 1. Les détails se contracteront vers le centre d'assemblage",  // FR
      "  1'den küçük güç. Parçalar montaj merkezine doğru büzülecek" };  // TR

    public static readonly string[] Force1 = {
      "  Then force is 1 items will remain in place. Value will be used {0}",
      "  При силе взрыва 1 детали останутся на месте. Будет использовано значение {0}",
      "  Con una forza di esplosione pari a 1, le parti rimarranno al loro posto. Verrà utilizzato il valore: {0}",
      "  Bei einer Explosionskraft von 1 bleiben die Teile an Ort und Stelle. Der Wert wird verwendet: {0}",
      "  爆炸力为 1 将保留在原地。 将使用值 {0}",
      "  Cuando la fuerza es 1, los elementos permanecerán en su lugar. Se utilizará el valor {0}",  // ES
      "  Lorsque la force est 1, les éléments resteront en place. La valeur {0} sera utilisée",  // FR
      "  Güç 1 olduğunda öğeler yerinde kalacaktır. {0} değeri kullanılacaktır" };  // TR

    public static readonly string[] Scaled = {
      "The block is scaled or mirrored. TNT will create a block at a 1:1 scale. Use the AsmNew command to create new blocks from scaled ones.",
      "Блок масштабирован или отзеркален. TNT создаст блок в масштабе 1:1. Используйте команду AsmNew для создания новых блоков из масштабированных.",
      "Il blocco viene ridimensionato o specchiato. TNT creerà un blocco in scala 1:1. Utilizzare il comando AsmNew per creare nuovi blocchi da quelli ridimensionati.",
      "Der Block wird skaliert oder gespiegelt. TNT erstellt einen Block im Maßstab 1:1. Verwenden Sie den Befehl AsmNew, um neue Blöcke aus skalierten zu erstellen.",
      "块被缩放或镜像。 TNT 将以 1:1 的比例创建一个块。 使用 AsmNew 命令从缩放的块创建新块。",
      "El bloque está escalado o reflejado. TNT creará un bloque a escala 1:1. Use el comando AsmNew para crear nuevos bloques a partir de los escalados.",  // ES
      "Le bloc est mis à l'échelle ou en miroir. TNT créera un bloc à l'échelle 1:1. Utilisez la commande AsmNew pour créer de nouveaux blocs à partir de ceux mis à l'échelle.",  // FR
      "Blok ölçeklendirilmiş veya aynalı. TNT 1:1 ölçekli bir blok oluşturacaktır. Ölçeklendirilmiş bloklardan yeni bloklar oluşturmak için AsmNew komutunu kullanın." };  // TR

    public static readonly string[] NewBlock = {
      "  New block created: {0}",
      "  Создан новый блок: {0}",
      "  Nuovo blocco creato: {0}",
      "  Neuer Block erstellt: {0}",
      "  已创建新块：{0}",
      "  Nuevo bloque creado: {0}",                    // ES
      "  Nouveau bloc créé : {0}",                     // FR
      "  Yeni blok oluşturuldu: {0}" };                // TR

    public static readonly string[] BlockReplaced = {
      "Replaced content of block {0}",
      "Заменено содержимое блока {0}",
      "Sostituito il contenuto del blocco {0}",
      "Inhalt von Block {0} ersetzt" ,
      "已替换块 {0} 的内容",
      "Contenido reemplazado del bloque {0}",          // ES
      "Contenu remplacé du bloc {0}",                  // FR
      "{0} bloğunun içeriği değiştirildi"};            // TR

    public static readonly string[] BlockPrompt = {
      "Block created by TNT command from block {0}",
      "Блок создан командой TNT из блока {0}",
      "Blocco creato dal comando TNT dal blocco {0}",
      "Block erstellt durch TNT-Befehl aus Block {0}",
      "由 TNT 命令从块 {0} 创建的块",
      "Bloque creado por el comando TNT desde el bloque {0}",  // ES
      "Bloc créé par la commande TNT à partir du bloc {0}",  // FR
      "TNT komutuyla {0} bloğundan oluşturulan blok" };  // TR

    public static readonly string[] PowerPrompt = {
      "TNT command setting - Explosion Force",
      "Настройка команды TNT - сила взрыва",
      "Impostazione del comando TNT - Forza di esplosione",
      "TNT-Befehlseinstellung - Explosionskraft",
      "TNT命令设置-爆炸力",
      "Configuración del comando TNT - Fuerza de explosión",  // ES
      "Paramètre de commande TNT - Force d'explosion",  // FR
      "TNT komutu ayarı - Patlama Gücü" };             // TR

    public static readonly string[] SourcePrompt = {
      "TNT command setting - Source block name",
      "Настройка команды TNT - Имя исходного блока",
      "Impostazione comando TNT - Nome blocco sorgente",
      "TNT-Befehlseinstellung - Quellblockname",
      "TNT 命令设置 - 源块名称",
      "Configuración del comando TNT - Nombre del bloque fuente",  // ES
      "Paramètre de commande TNT - Nom du bloc source",  // FR
      "TNT komutu ayarı - Kaynak blok adı" };          // TR

    public static readonly string[] PowerErr = {
      "Failed to read the value of the force of the explosion in block {0}",
      "Не удалось прочитать значение силы взрыва в блоке {0}",
      "Impossibile leggere il valore della forza dell'esplosione nel blocco {0}",
      "Fehler beim Lesen des Werts der Explosionskraft in Block {0}" ,
      "无法读取块 {0} 中的爆炸力值",
      "No se pudo leer el valor de la fuerza de explosión en el bloque {0}",  // ES
      "Échec de la lecture de la valeur de la force d'explosion dans le bloc {0}",  // FR
      "{0} bloğundaki patlama gücü değeri okunamadı"};  // TR

    public static readonly string[] SourceErr = {
      "Source block not found to update block {0}",
      "Не найден исходный блок для обновления блока {0}",
      "Blocco di origine non trovato per aggiornare il blocco {0}",
      "Quellblock nicht gefunden, um Block {0} zu aktualisieren",
      "未找到更新块 {0} 的源块",
      "Bloque fuente no encontrado para actualizar el bloque {0}",  // ES
      "Bloc source introuvable pour mettre à jour le bloc {0}",  // FR
      "{0} bloğunu güncellemek için kaynak blok bulunamadı" };  // TR

    public static readonly string[] BlockUpdated = {
      "Updated block {0}",
      "Обновлен блок {0}",
      "Blocco aggiornato {0}",
      "Aktualisierter Block {0}",
      "更新块 {0}",
      "Bloque actualizado {0}",                        // ES
      "Bloc mis à jour {0}",                           // FR
      "Güncellenen blok {0}" };                        // TR

    public static readonly string[] UpdateErr = {
      "Failed to update block {0}",
      "Не удалось обновить блок {0}",
      "Impossibile aggiornare il blocco {0}",
      "Fehler beim Aktualisieren des Blocks {0}",
      "未能更新块 {0}",
      "No se pudo actualizar el bloque {0}",           // ES
      "Échec de la mise à jour du bloc {0}",           // FR
      "{0} bloğu güncellenemedi" };                    // TR

    public static readonly string[] Updated = {
      "Updated blocks: {0}",
      "Обновлено блоков: {0}",
      "Blocchi aggiornati: {0}",
      "Aktualisierte Blöcke: {0}",
      "更新块：{0}",
      "Bloques actualizados: {0}",                     // ES
      "Blocs mis à jour : {0}",                        // FR
      "Güncellenen bloklar: {0}" };                    // TR
  }
}