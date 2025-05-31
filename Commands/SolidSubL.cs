// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public class SolidSubL
  {
    public static readonly string[,] SolidSubStyleNames = {
/* 0 */ {
        CommandL.SolidSub[0],
        CommandL.SolidSub[1],
        CommandL.SolidSub[2],
        CommandL.SolidSub[3],
        CommandL.SolidSub[4]  },
/* 1 */ {
        "3D-solid Operations",
        "Операции с солидами",
        "Operazioni sui solidi 3D",
        "Volumenkörperoperationen",
        "3D实体操作"  },
/* 2 */ {
        CurveL.SaveSources[0],
        CurveL.SaveSources[1],
        CurveL.SaveSources[2],
        CurveL.SaveSources[3],
        CurveL.SaveSources[4]  },
    };
    public static readonly string[] TotalCount = {
      "  Found parts of all types: {0}. Holes count: {1}. Block-assemblies count: {2}",
      "  Найдено деталей всех типов: {0}. Дырок: {1}. Блоков-сборок: {2}",
      "  Parti trovate di tutti i tipi: {0}. Fori contati: {1}. Conteggio blocchi: {2}",
      "  Fundstücke aller Art: {0}. Anzahl der Löcher: {1}. Anzahl der Blöcke: {2}",
      "  找到所有类型的零件：{0}。 孔数量：{1}。 块数量：{2}" };
    public static readonly string[] SolidCount = {
      "  Subtract from solids: {0}. Subtracted solids: {1}.",
      "  Вычитаем из солидов: {0}. Вычитаемых солидов: {1}.",
      "  Sottrai dai solidi: {0}. Franchigia solida: {1}.",
      "  Von Feststoffen subtrahieren: {0}. Abzugsfähige Festgelder: {1}.",
      "  从实体中减去：{0}。可扣除金额：{1}。" };
    public static readonly string[] SurfaceCount = {
      "  Subtract from surfaces: {0}. Subtracted surfaces: {1}.",
      "  Вычитаем из поверхностей: {0}. Вычитаемых поверхностей: {1}.",
      "  Sottrai dalle superfici: {0}. Superfici sottraibili: {1}.",
      "  Von Oberflächen subtrahieren: {0}. Subtrahierbare Flächen: {1}.",
      "  从表面减去：{0}。可减去曲面：{1}。" };
    public static readonly string[] RegionCount = {
      "  Subtract from regions of one plane: {0}. Subtracted regions on the same plane: {1}.",
      "  Вычитаем из регионов одной плоскости: {0}. Вычитаемых регионов на той же плоскости: {1}.",
      "  Sottrai dalle regioni di un piano: {0}. Regioni sottratte sullo stesso piano: {1}.",
      "  Von Regionen einer Ebene subtrahieren: {0}. Subtrahierte Regionen auf derselben Ebene: {1}.",
      "  从一个平面的区域中减去：{0}。同一平面上减去的区域：{1}。" };
    public static readonly string[] OneSolidErr = {
        "At least two solids are required",
        "Требуется хотя бы два солида",
        "Sono richiesti almeno due solidi",
        "Mindestens zwei Volumenkörper sind erforderlich",
        "至少需要两个实体"    };
    public static readonly string[] OneSurfaceErr = {
        "At least two surfaces are required",
        "Требуется хотя бы две поверхности",
        "Sono richieste almeno due superfici",
        "Mindestens zwei Oberflächen sind erforderlich",
        "至少需要两个表面"    };
    public static readonly string[] OneRegionErr = {
        "At least two regions on the same plane are required",
        "Требуется хотя бы два региона на одной плоскости",
        "Sono richieste almeno due regioni sullo stesso piano",
        "Mindestens zwei Regionen auf derselben Ebene sind erforderlich",
        "至少需要同一平面上的两个区域"    };
    public static readonly string[] OffsetSurfaceErr = {
        "Unable to expand surface to make gap. {0}",
        "Не удалось расширить поверхность, чтоб сделать зазор. {0}",
        "Impossibile espandere la superficie per creare uno spazio. {0}",
        "Die Oberfläche kann nicht erweitert werden, um eine Lücke zu erzeugen. {0}",
        "无法扩大表面来产生间隙。 {0}"    };
    public static readonly string[] MadeSub = {
        "  Subtractions performed: {0}",
        "  Выполнено вычитаний: {0}",
        "  Sottrazioni eseguite: {0}",
        "  Subtraktionen durchgeführt: {0}",
        "  执行的减法次数：{0}"    };
    public static readonly string[] MadeInt = {
        "  Intersections performed: {0}",
        "  Выполнено пересечений: {0}",
        "  Intersezioni eseguite: {0}",
        "  Schnittmengen durchgeführt: {0}",
        "  执行的交集次数：{0}"    };
    public static readonly string[] MadeUnion = {
        "  Unions performed: {0}",
        "  Выполнено объединений: {0}",
        "  Unioni eseguite: {0}",
        "  Vereinigungen durchgeführt: {0}",
        "  执行的联合次数：{0}"    };


    //============================ SolidSubOptionsBox ==============================================

    public static readonly string[] StyleNameTip = {
      "The name for this solid subtraction style (set of settings). \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Название для этого стиля вычитания солидов. Не используется в работе программы. \r\n" +
        "Только для удобства выбора.",
      "Nome per questo stile di sottrazione (set di impostazioni). \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Bezeichnung für diese Art der Subtraktion (Satz von Einstellungen). \r\n" +
        "Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "此减法立体样式的名称。程序中未使用。  只是为了方便选择。"};

    public static readonly string[] GapTip = {
      "The Gap command can create a gap between parts.\r\n" +
          "If you set a gap greater than 0, \r\n" +
          "the subtracted part will be enlarged before subtraction.",
      "Команда Зазор может создать зазор между деталями.\r\n" +
          "Если назначить зазор больше 0, \r\n" +
          "то вычитаемая деталь будет увеличена перед вычитанием.",
      "Il comando Divario può creare uno spazio tra le parti.\r\n" +
          "Se si imposta uno spazio maggiore di 0, \r\n" +
          "la parte sottratta verrà ingrandita prima della sottrazione.",
      "Der Befehl Lücke kann einen Lücke zwischen Teilen erstellen.\r\n" +
          "Wenn Sie einen Lücke größer als 0 festlegen, \r\n" +
          "wird das subtrahierte Teil vor der Subtraktion vergrößert.",
      "“带间隙减法”命令可以在零件之间创建间隙。\r\n" +
          "如果将间隙设置为大于0的值，\r\n" +
          "则被减去的零件会在减法操作前被放大。"   };
    public static readonly string[] DeleteSourcesTip = {
      "Delete source drawing objects",
      "Удалять исходные объекты чертежа",
      "Eliminare gli oggetti di disegno di origine",
      "Ursprüngliche Zeichnungsobjekte löschen",
      "删除源绘图对象"    };
    public static readonly string[] DeleteSubtrahendTip = {
      "Delete subtracted objects in the Subtract and Gap commands",
      "Удалять вычитаемые объекты в командах Вычитание и Зазор",
      "Eliminare gli oggetti sottratti nei comandi Sottrazione e Spazio",
      "Gelöschte Objekte in den Befehlen Subtrahieren und Spalt löschen",
      "删除在减法和间隙命令中被减去的对象"    };
    public static readonly string[] SubFromBlock = {
      "Subtract inside blocks",
      "Вычитать внутри блоков",
      "Sottrarre all'interno dei blocchi",
      "Innerhalb von Blöcken subtrahieren",
      "在块内执行减法"    };
    public static readonly string[] SubFromBlockTip = {
      "Subtract from solids located inside assembly blocks",
      "Вычитать из солидов, находящихся внутри блоков-сборок",
      "Sottrarre da solidi situati all'interno dei blocchi di assemblaggio",
      "Von Volumenkörpern innerhalb von Montageblöcken subtrahieren",
      "从装配块内的实体中执行减法"    };
    public static readonly string[] Split = {
      "Split multisolids",
      "Разделить мультисолиды",
      "Multisolidi divisi",
      "Geteilte Mehrkörper",
      "分割多重实体"    };
    public static readonly string[] SplitTip = {
      "If the result of subtraction or intersection splits a solid into several separate bodies, \r\n" +
          "save each body as a separate solid. \r\n" +
          "This option also works with regions.",
      "Если в результате вычитания или пересечения солид разделился на несколько отдельных тел, \r\n" +
          "то сохранить каждое тело как отдельный солид. \r\n" +
          "Опция работает так же с регионами.",
      "Se il risultato della sottrazione o dell'intersezione divide un solido in più corpi separati, \r\n" +
          "salva ogni corpo come un solido separato. \r\n" +
          "Questa opzione funziona anche con le regioni.",
      "Wenn das Ergebnis der Subtraktion oder des Schnitts einen Volumenkörper in mehrere separate Körper aufteilt, \r\n" +
          "speichern Sie jeden Körper als separaten Volumenkörper. \r\n" +
          "Diese Option funktioniert auch mit Regionen.",
      "如果减法或交集的结果将实体分割成多个独立的部分，\r\n" +
          "则将每个部分保存为单独的实体。\r\n" +
          "此选项也适用于区域。"    };
    public static readonly string[] MeshToSolidTip = {
      "Before starting the commands, convert meshes (SubDMesh, PolygonMesh, PolyfaceMesh), \r\n" +
          "3dFace and Body objects, and polylines with thickness into solids. \r\n" +
          "A license for the MeshToSolid command is required.",
      "Перед началом работы команд преобразовать сети (Mesh, PolygonMesh, PolyfaceMesh), \r\n" +
          "объекты 3dFace, Body, и полилинии с толщиной в солиды. \r\n" +
          "Требуется лицензия на команду MeshToSolid.",
      "Prima di avviare i comandi, convertire le mesh (Mesh, PolygonMesh, PolyfaceMesh), \r\n" +
          "oggetti 3dFace, oggetti Body e polilinee con spessore in solidi. \r\n" +
          "È necessaria una licenza per il comando MeshToSolid.",
      "Vor dem Start der Befehle konvertieren Sie Netze (Mesh, PolygonMesh, PolyfaceMesh), \r\n" +
          "3dFace-Objekte, Body-Objekte und Polylinien mit Dicke in Volumenkörper. \r\n" +
          "Eine Lizenz für den MeshToSolid-Befehl ist erforderlich.",
      "在启动命令之前，将网格（SubDMesh、PolygonMesh、PolyfaceMesh）、3dFace 和 Body 对象以及具有厚度的折线转换为实体。\r\n" +
          "需要 MeshToSolid 命令的许可证。" };
    public static readonly string[] PairwiseIntersection = {
      "Pairwise Intersection",
      "Попарное пересечение",
      "Intersezione a coppie",
      "Paarweise Schnittmenge",
      "成对交集" };
    public static readonly string[] PairwiseIntersectionTip = {
      "Make intersection of each object with each other. \r\n" +
        "If disabled - then search for common place of all objects at once",
      "Делать пересечение каждого объекта с каждым другим. \r\n" +
        "Если отключено - то искать общее место у всех объектов сразу",
      "Fai in modo che ogni oggetto si intersechi con ogni altro. \r\n" +
        "Se disabilitato, cerca una posizione comune per tutti gli oggetti contemporaneamente",
      "Sorgen Sie dafür, dass sich alle Objekte miteinander überschneiden. \r\n" +
        "Wenn deaktiviert, dann suchen Sie nach einem gemeinsamen Speicherort für alle Objekte auf einmal",
      "使每个对象相互交叉。如果禁用，则一次性搜索所有对象的公共位置" };
    public static readonly string[] UnionToSolid = {
      "Union to Solid",
      "Объединение в солид",
      "Unione in solido",
      "Vereinigung zu Solid",
      "联合到实体"};
    public static readonly string[] UnionToSolidTip = {
      "The Union command will search for groups of contacting surfaces and regions and attempt to assemble a solid from each such group.\r\n" +
        "If an existing solid intersects with a group, it will also participate in the creation of a new solid.\r\n" +
        "If it is possible to create a solid, all objects in contact with the group will be deleted.\r\n" +
        "The standard _SurfSculpt command works similarly.",
      "Команда Объединение будет искать группы контактирующих поверхностей и регионов и пытаться собрать солид из каждой такой группы.\r\n" +
        "Если с группой пересечется существующий солид, то он тоже будет участвовать в создании нового солида.\r\n" +
        "Если получится создать солид, то все объекты, контактирующие с группой будут удалены. \r\n" +
        "Аналогично работает стандартная команда _SurfSculpt.",
      "Il comando Unione cercherà gruppi di superfici e regioni in contatto e tenterà di assemblare un solido da ciascun gruppo. \r\n" +
        "Se un solido esistente interseca il gruppo, parteciperà anche alla creazione del nuovo solido. \r\n" +
        "Se è possibile creare un solido, tutti gli oggetti in contatto con il gruppo verranno eliminati. \r\n" +
        "Funziona in modo simile al comando standard _SurfSculpt.",
      "Der Befehl Union sucht nach Gruppen von Kontaktflächen und Regionen und versucht, aus jeder Gruppe einen Volumenkörper zu erstellen. \r\n" +
        "Wenn ein vorhandener Volumenkörper die Gruppe schneidet, wird er ebenfalls an der Erstellung des neuen Volumenkörpers beteiligt. \r\n" +
        "Wenn es gelingt, einen Volumenkörper zu erstellen, werden alle Objekte, die mit der Gruppe in Kontakt stehen, gelöscht. \r\n" +
        "Funktioniert ähnlich wie der Standardbefehl _SurfSculpt.",
      "联合命令将查找接触的表面和区域组，并尝试从每个组组装实体。\r\n" +
        "如果现有实体与组相交，则它也将参与新实体的创建。\r\n" +
        "如果可以创建实体，则将删除与组接触的所有对象。\r\n" +
        "类似于标准命令 _SurfSculpt。"
    };
  }
}
