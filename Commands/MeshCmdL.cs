// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  MeshCmdL
  {
    public static string[] Select = {
      "\n Select any meshes",
      "\n Выберите любые сети",
      "\n Selezionare Mesh o PolyfaceMesh",
      "\n Wählen Sie ein beliebiges Netz",
      "\n 选择网格"};
    public static string[] Converting = {
      "Converting",
      "Преобразование",
      "Conversione",
      "Konvertieren",
      "转换" };
    public static string[] Converted = {
      "  Meshes converted: {0}",
      "  Преобразовано сетей: {0}",
      "  Le maglie si sono convertite: {0}",
      "  Netze konvertiert: {0}",
      "  转换的网格：{0}" };
    public static string[] SolidCount = {
      "  Solids created: {0}",
      "  Создано солидов: {0}",
      "  Solido creato: {0}",
      "  Erstellt von Volumenkörpern: {0}",
      "  创建的实体：{0}" };
    public static string[] NoMesh = {
      "  No mesh. Command canceled",
      "  Нет сетей. Команда отменена.",
      "  Nessun Mesh. Comando annullato.",
      "  Kein Netz. Befehl abgebrochen",
      "  没有网格。 命令已取消" };
    public static string[] NotConverted = {
      "  Mesh cannot be converted",
      "  Не-а! Эту сеть автокад конвертировать не может",
      "  L'oggetto non può essere convertito",
      "  Netz kann nicht konvertiert werden!",
      "  网格无法转换" };
    public static string[] NotClosed = {
      "  Mesh is not closed or cannot be converted",
      "  Сеть не замкнута или невозможно конвертировать",
      "  La Mesh non è chiusa o non può essere convertita",
      "  Das Netz ist nicht geschlossen oder kann nicht konvertiert werden",
      "  网格未闭合或无法转换" };
    public static string[] Merge = {
      "Merge meshes",
      "Объединение сетей",
      "Combinazione di mesh poligonali",
      "Polygonnetze kombinieren",
      "合并网格" };
    public static string[] NotCombined = {
      "Failed to join polygon mesh",
      "Не удалось присоединить полигональную сеть",
      "Impossibile unire la mesh poligonale",
      "Polygonnetz konnte nicht verbunden werden",
      "无法加入多边形网格" };

    // =============================================== MeshToSolidOptionsBox ============================================================

    public static string[] Optimize = {
      "Optimize solids",
      "Оптимизировать солиды",
      "Ottimizza i solidi",
      "Volumenkörpern optimieren",
      "优化固体" };
    public static string[] OptimizeTip = {
      "Glue meshes surfaces into one solid plane. \r\n" +
        "It has been noticed that when optimization is enabled, \r\n" +
        "AutoCAD often completely refuses to convert the mesh to solid.",
      "Склеивать поверхности сети в одну плоскость солида. \r\n" +
        "Замечено, что при включенной оптимизации \r\n" +
        "AutoCAD часто вовсе отказывается делать преобразование сети в солид.",
      "La colla unisce le superfici in un piano solido. \r\n" +
        "Si è notato che quando l'ottimizzazione è abilitata, \r\n" +
        "AutoCAD spesso rifiuta completamente di convertire la mesh in solido.",
      "Kleber vernetzt Oberflächen zu einer festen Ebene. \r\n" +
        "Es wurde festgestellt, dass AutoCAD bei aktivierter Optimierung die Konvertierung \r\n" +
        "des Netzes in ein Volumenkörpern häufig vollständig verweigert.",
      "胶水将表面网格化为一个实体平面. \r\n" +
        "人们注意到，当启用优化时，AutoCAD 通常完全拒绝将网格转换为实体。" };
    public static string[] MaxMesh = {
      "Acceptable mesh complexity",
      "Допустимая сложность сети",
      "Complessità della mesh accettabile",
      "Akzeptable Netzkomplexität",
      "可接受的网格复杂度" };
    public static string[] MaxMeshTip = {
      "The number of polygons in the mesh, more than which the mesh will not be processed in AVC commands. \r\n" +
        "Meshes that are too complex will take hours to process, \r\n" +
        "and the solids obtained from them are not suitable for further work. \r\n" +
        "You can assign 0 so that all meshes are processed (and it kill AutoCAD). \r\n" +
        "Remember that you are working in a solid-modeling program \r\n" +
        "and it cannot handle the crazy meshes from the Internet and from 3DS Max.",
      "Количество полигонов в сети, больше которого сеть не будет обрабатываться в командах AVC. \r\n" +
        "Слишком сложные сети будут обрабатываться часами, а полученные из них солиды не пригодны для дальнейшей работы. \r\n" +
        "Можно назначить 0, чтоб обрабатывались все сети (и убить AutoCAD). \r\n" +
        "Помните, что вы работаете в программе твердотельного моделирования \r\n" +
        "и она не может работать с безумными сетями из интернета и из 3DS Max.",
      "Il numero di poligoni nella mesh, oltre il quale la mesh non verrà elaborata nei comandi AVC. \r\n" +
        "Le reti troppo complesse richiederanno ore per essere elaborate \r\n" +
        "e i solidi ottenuti da esse non sono adatti per ulteriori lavori. \r\n" +
        "Puoi assegnare 0 in modo che tutte le mesh vengano elaborate (e uccida AutoCAD). \r\n" +
        "Ricorda che stai lavorando in un programma di modellazione solida \r\n" +
        "e non è in grado di gestire le mesh folli da Internet e da 3DS Max.",
      "Die Anzahl der Polygone im Netz, mehr als die, die das Netz in AVC-Befehlen nicht verarbeitet. \r\n" +
        "Zu komplexe Netze benötigen Stunden für die Bearbeitung \r\n" +
        "und die daraus gewonnenen Feststoffe sind für die weitere Bearbeitung nicht geeignet. \r\n" +
        "Sie können 0 zuweisen, sodass alle Netze verarbeitet werden (und AutoCAD dadurch beendet wird). \r\n" +
        "Denken Sie daran, dass Sie in einem Volumenmodellierungsprogramm arbeiten \r\n" +
        "und dieses die verrückten Netze aus dem Internet und von 3DS Max nicht verarbeiten kann.",
      "网格中的多边形数量，超过该数量网格将不会在 AVC 命令中进行处理。\r\n" +
        "太复杂的网格需要花费数小时来处理，并且从中获得的固体不适合进一步的工作。\r\n" +
        "您可以指定 0，以便处理所有网格（并且它会终止 AutoCAD）。\r\n" +
        "请记住，您正在使用实体建模程序，它无法处理来自 Internet 和 3DS Max 的疯狂网格。" };
    public static string[] SaveMaterials = {
      "Saving Face Materials",
      "Сохранение материалов граней",
      "Salvataggio dei materiali frontali",
      "Einsparung von Obermaterial",
      "节省面材" };
    public static string[] SaveMaterialsTip = {
      "Find polygons on the mesh with it own color or material and try to assign these materials to the solid faces. \r\n" +
        "Finding matches between mesh polygons and solid faces is a very complex and time-consuming procedure. \r\n" +
        "Therefore, enable this option only if you actually assign colors and materials to some polygons.",
      "Найти на сети полигоны с собственным цветом или материалом и попытаться присвоить эти материалы граням солида. \r\n" +
        "Поиск соответствия полигонов сети и граней солида - это очень сложная и долгая процедура. \r\n" +
        "Поэтому, включайте эту опцию только если вы действительно присваиваете цвета и материалы некоторым полигонам.",
      "Trova i poligoni sulla mesh con il proprio colore o materiale e prova ad assegnare questi materiali alle facce solide. \r\n" +
        "Trovare corrispondenze tra poligoni mesh e facce solide \r\n" +
        "è una procedura molto complessa e dispendiosa in termini di tempo. \r\n" +
        "Abilitate quindi questa opzione solo se effettivamente assegnate colori e materiali ad alcuni poligoni.",
      "Suchen Sie im Netz nach Polygonen mit eigener Farbe oder eigenem Material und versuchen Sie, \r\n" +
        "diese Materialien den Volumenkörperflächen zuzuordnen. \r\n" +
        "Das Finden von Übereinstimmungen zwischen Netzpolygonen \r\n" +
        "und Volumenkörperflächen ist ein sehr komplexer und zeitaufwändiger Vorgang. \r\n" +
        "Aktivieren Sie diese Option daher nur, wenn Sie einigen Polygonen tatsächlich Farben und Materialien zuweisen.",
      "在网格上找到具有自己的颜色或材质的多边形，并尝试将这些材质分配给实体面。\r\n" +
        "查找网格多边形和实体面之间的匹配是一个非常复杂且耗时的过程。\r\n" +
        "因此，仅当您实际为某些多边形指定颜色和材质时才启用此选项。" };
  }
}
