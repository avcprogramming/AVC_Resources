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
      "  选择三维实体或装配体"};
    public static readonly string[] SelectBlocks = {
      "  Select assembly blocks previously created by TNT command",
      "  Выберите блоки-сборки ранее созданные командой TNT",
      "  Seleziona i blocchi di assieme precedentemente creati dal comando TNT",
      "  Wählen Sie Montageblöcke aus, die zuvor mit dem TNT-Befehl erstellt wurden",
      "  选择之前由 TNT 命令创建的装配块" };
    public static readonly string[] Need2 = {
      "  There is nothing to explode - you need at least 2 parts in the assembly",
      "  Нечего взрывать - нужны хотя бы 2 детали в сборке",
      "  Non c'è niente da far esplodere: sono necessarie almeno 2 parti nell'assemblaggio",
      "  Es gibt nichts zu sprengen – Sie benötigen mindestens 2 Teile für die Baugruppe",
      "  没有什么可以炸毁的 - 装配中至少需要 2 个零件" };
    public static readonly string[] Coordinates = {
      "  Specify the coordinates to insert the exploded assembly",
      "  Укажите координаты, куда вставить взорванную сборку",
      "  Specificare le coordinate per inserire il gruppo soffiato.",
      "  Geben Sie die Koordinaten zum Einfügen der geblasenen Baugruppe an.",
      "  指定插入点" };
    public static readonly string[] Force = {
      "  Set the force of the explosion",
      "  Задайте силу взрыва",
      "  Impostare la forza dell'esplosione",
      "  Stellen Sie die Stärke der Explosion ein",
      "  设置爆炸的力量" };
    public static readonly string[] WorkWith2dKW = {
      "Process2d",
      "Обрабатывать2d",
      "Elaborare2d",
      "Verarbeiten2d",
      "其它对象(P)"};
    public static readonly string[] WorkWith2dQuery = {
      "Process 2d-curves and other objects?",
      "Обрабатывать 2d-кривые и прочие объекты?",
      "Elaborare curve 2D e altri oggetti?",
      "2D-Kurven und andere Objekte verarbeiten?",
      "是否处理二维对象和其他对象？" };
    public static readonly string[] WorkWith2dOn = {
      "The program will process 2d curves and all other objects",
      "Программа будет обрабатывать 2d-кривые и все прочие объекты",
      "Il programma elaborerà le curve 2d e tutti gli altri oggetti",
      "Das Programm verarbeitet 2D-Kurven und alle anderen Objekte",
      "该程序将处理二维对象和所有其他对象" };
    public static readonly string[] ErrForce = {
      "  Force of the explosion mast be more 0. Value will be used {0}",
      "  Сила взрыва должна быть больше 0. Будет использовано значение {0}",
      "  La forza dell'esplosione deve essere maggiore di 0. Verrà utilizzato il valore: {0}",
      "  Die Explosionskraft muss größer als 0 sein. Der Wert wird verwendet: {0}",
      "  爆炸力必须大于0。将使用 {0}" };
    public static readonly string[] CloneErr = {
      "  Oops! Program can't clone solid",
      "  Упс! Не удалось клонировать солид",
      "  Oops! Impossibile clonare la parte",
      "  Ups! Teil konnte nicht geklont werden" ,
      "  哎呀！ 程序无法克隆实体"};
    public static readonly string[] CentroidErr = {
      "  Oops! An error occurred while calculating the centroid of solid #{0}: {1}. Solid will be skipped",
      "  Упс! Ошибка во время вычисления центра масс солида №{0}: {1}. Солид будет пропущен",
      "  Ops! Si è verificato un errore durante il calcolo del baricentro del solido #{0}: {1}. Il solido verrà saltato",
      "  Hoppla! Beim Berechnen des Schwerpunkts des Festkörpers #{0} ist ein Fehler aufgetreten: {1}. Solid wird übersprungen",
      "  哎呀！ 计算三维实体 #{0} 的重心时出错: {1}. 三维实体将被跳过"};
    public static readonly string[] ExtentsErr = {
      "  Oops! Failed to get the geometric center of object #{0}: {1}. The object will be skipped",
      "  Упс! Не удалось получить геометрический центр объекта №{0}: {1}. Объект будет пропущен",
      "  Ops! Impossibile ottenere il centro geometrico dell'oggetto #{0}: {1}. L'oggetto verrà saltato",
      "  Hoppla! Fehler beim Abrufen des geometrischen Mittelpunkts von Objekt Nr. {0}: {1}. Das Objekt wird übersprungen",
      "  哎呀！ 未能获取对象 #{0} 的几何中心：{1}。 该对象将被跳过"};
    public static readonly string[] NoCentroidBlock = {
      "  Block {0} does not contain solids and will be skipped",
      "  Блок {0} не содержит солидов и будет пропущен",
      "  Il blocco {0} non contiene solidi e verrà ignorato",
      "  Block {0} enthält keine Feststoffe und wird übersprungen",
      "  块 {0} 不包含实体，将被跳过"};
    public static readonly string[] AsmCentroidErr = {
      "  Oops! Failed to calculate assembly center. Perhaps all the solids are filtered",
      "  Упс! Не удалось вычислить центр сборки. Возможно все солиды отфильтрованы",
      "  Ops! Impossibile calcolare il centro di assemblaggio. Forse tutti i solidi sono filtrati",
      "  Hoppla! Montagezentrum konnte nicht berechnet werden. Vielleicht werden alle Feststoffe gefiltert",
      "  哎呀！ 无法计算装配中心。 所选对象中无实体"};
    public static readonly string[] Done = {
      "Done objects {0}",
      "Разнесено объектов {0}",
      "Parti esplose {0}",
      "Explodierte Objekte {0}",
      "爆炸对象{0}" };
    public static readonly string[] ForceLess1 = {
      "  Force of less than 1. Details to collapse to the assembly center ",
      "  Сила взрыва меньше 1. Детали схлопнутся к центру сборки ",
      "  Forza di esplosione inferiore a 1. Le parti collassano al centro di assemblaggio",
      "  Explosionskraft weniger als 1. Teile fallen zum Montagezentrum zusammen",
      "  爆炸力小于1。零件会收缩到装配中心" };
    public static readonly string[] Force1 = {
      "  Then force is 1 items will remain in place. Value will be used {0}",
      "  При силе взрыва 1 детали останутся на месте. Будет использовано значение {0}",
      "  Con una forza di esplosione pari a 1, le parti rimarranno al loro posto. Verrà utilizzato il valore: {0}",
      "  Bei einer Explosionskraft von 1 bleiben die Teile an Ort und Stelle. Der Wert wird verwendet: {0}",
      "  爆炸力为 1 将保留在原地。 将使用值 {0}" };
    public static readonly string[] Scaled = {
      "The block is scaled or mirrored. TNT will create a block at a 1:1 scale. Use the AsmNew command to create new blocks from scaled ones.",
      "Блок масштабирован или отзеркален. TNT создаст блок в масштабе 1:1. Используйте команду AsmNew для создания новых блоков из масштабированных.",
      "Il blocco viene ridimensionato o specchiato. TNT creerà un blocco in scala 1:1. Utilizzare il comando AsmNew per creare nuovi blocchi da quelli ridimensionati.",
      "Der Block wird skaliert oder gespiegelt. TNT erstellt einen Block im Maßstab 1:1. Verwenden Sie den Befehl AsmNew, um neue Blöcke aus skalierten zu erstellen.",
      "块被缩放或镜像。 TNT 将以 1:1 的比例创建一个块。 使用 AsmNew 命令从缩放的块创建新块。" };
    public static readonly string[] NewBlock = {
      "  New block created: {0}",
      "  Создан новый блок: {0}",
      "  Nuovo blocco creato: {0}",
      "  Neuer Block erstellt: {0}",
      "  已创建新块：{0}" };
    public static readonly string[] BlockReplaced = {
      "Replaced content of block {0}",
      "Заменено содержимое блока {0}",
      "Sostituito il contenuto del blocco {0}",
      "Inhalt von Block {0} ersetzt" ,
      "已替换块 {0} 的内容"};
    public static readonly string[] BlockPrompt = {
      "Block created by TNT command from block {0}",
      "Блок создан командой TNT из блока {0}",
      "Blocco creato dal comando TNT dal blocco {0}",
      "Block erstellt durch TNT-Befehl aus Block {0}",
      "由 TNT 命令从块 {0} 创建的块" };
    public static readonly string[] PowerPrompt = {
      "TNT command setting - Explosion Force",
      "Настройка команды TNT - сила взрыва",
      "Impostazione del comando TNT - Forza di esplosione",
      "TNT-Befehlseinstellung - Explosionskraft",
      "TNT命令设置-爆炸力" };
    public static readonly string[] SourcePrompt = {
      "TNT command setting - Source block name",
      "Настройка команды TNT - Имя исходного блока",
      "Impostazione comando TNT - Nome blocco sorgente",
      "TNT-Befehlseinstellung - Quellblockname",
      "TNT 命令设置 - 源块名称" };
    public static readonly string[] PowerErr = {
      "Failed to read the value of the force of the explosion in block {0}",
      "Не удалось прочитать значение силы взрыва в блоке {0}",
      "Impossibile leggere il valore della forza dell'esplosione nel blocco {0}",
      "Fehler beim Lesen des Werts der Explosionskraft in Block {0}" ,
      "无法读取块 {0} 中的爆炸力值"};
    public static readonly string[] SourceErr = {
      "Source block not found to update block {0}",
      "Не найден исходный блок для обновления блока {0}",
      "Blocco di origine non trovato per aggiornare il blocco {0}",
      "Quellblock nicht gefunden, um Block {0} zu aktualisieren",
      "未找到更新块 {0} 的源块" };
    public static readonly string[] BlockUpdated = {
      "Updated block {0}",
      "Обновлен блок {0}",
      "Blocco aggiornato {0}",
      "Aktualisierter Block {0}",
      "更新块 {0}" };
    public static readonly string[] UpdateErr = {
      "Failed to update block {0}",
      "Не удалось обновить блок {0}",
      "Impossibile aggiornare il blocco {0}",
      "Fehler beim Aktualisieren des Blocks {0}",
      "未能更新块 {0}" };
    public static readonly string[] Updated = {
      "Updated blocks: {0}",
      "Обновлено блоков: {0}",
      "Blocchi aggiornati: {0}",
      "Aktualisierte Blöcke: {0}",
      "更新块：{0}" };
  }
}
