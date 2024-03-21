// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  /// <summary>
  /// Локализация модулей обмера и анализа солидов
  /// </summary>
  public static class SolidMetricL
  {
    public static readonly string[] BrepErr = {
      "Failed to get solid geometry description (bRep).\r\n{0}",
      "Не удалось получить описание геометрии солида (bRep).\r\n{0}",
      "Impossibile ottenere la descrizione della geometria solida (bRep).\r\n{0}",
      "Volumenkörpergeometriebeschreibung (bRep) konnte nicht abgerufen werden.\r\n{0}",
      "无法获取实体几何描述 (bRep)。\r\n{0}"};
    public static readonly string[] IsNotBanding = {
      "Material '{0}' will be ignored in the edge banding calculation. Change its purpose in 'Use' field",
      "Материал '{0}' будет проигнорирован в расчете кромки. Поменяйте ему назначение в поле 'Использование'",
      "Il materiale '{0}' verrà ignorato nel calcolo della bordatura. Cambia il suo scopo nel campo 'Utilizzare'",
      "Material '{0}' wird bei der Kantenstreifenberechnung ignoriert. Ändern Sie den Zweck im Feld 'Verwenden'",
      "边带计算中将忽略材料“{0}”。 在“用法”字段中更改其用途"};
    public static readonly string[] IsNotCover = {
      "Material '{0}' will be ignored in the coverage calculation. Change its assignment in the 'Use' field",
      "Материал '{0}' будет проигнорирован в расчете покрытия. Поменяйте ему назначение в поле 'Использование'",
      "Il materiale '{0}' verrà ignorato nel calcolo della copertura. Cambia la sua assegnazione nel campo 'Utilizzare'",
      "Material '{0}' wird bei der Deckungsberechnung ignoriert. Ändern Sie die Zuordnung im Feld 'Verwenden'",
      "覆盖率计算中将忽略材料“{0}”。 在“用法”字段中更改其分配"};
    public static readonly string[] TooHard = {
      "Solid too complex or crash in bRep API",
      "Тело слишком сложное или сбой в bRep API",
      "Solido troppo complesso o crash nell'API bRep",
      "Volumenkörper zu komplex oder Absturz in der bRep-API",
      "实体太复杂或在 bRep API 中崩溃"};
    public static readonly string[] VolumeErr = {
      "\nCAD program can't get solid volume or solid too small.\r\n" +
        "Recommended to re-draw it.",
      "\nCAD не в состоянии померить объем солида или он слишком маленький.\r\n" +
        "Придется перечертить.",
      "\nCAD non può ottenere il volume del solido oppure il solido è troppo piccolo.\r\n" +
        "Si consiglia di ri-disegnare.",
      "\nCAD kann das Körpervolumen nicht messen oder ist zu klein.\r\n" +
        "Wir müssen neu zeichnen.",
      "\nCAD程序无法获得实体体积或实体太小。\r\n" +
        "建议重新绘制。"};
    public static readonly string[] ComplexSolid = {
      "Measurement is not possible. Solid consists of several separate parts. \r\n" +
        "It is required to call the Separate command (_solidedit _body _separate)",
      "Обмер невозможен. Солид состоит из нескольких отдельных деталей. \r\n" +
        "Требуется вызвать команду Отделить (_solidedit _body _separate)",
      "La misurazione non è possibile. Solid è costituito da più parti separate. \r\n" +
        "È necessario chiamare il comando Separate (_solidedit _body _separate)",
      "Eine Messung ist nicht möglich. Solid besteht aus mehreren separaten Teilen. \r\n" +
        "Es ist erforderlich, den Separate-Befehl aufzurufen (_solidedit _body _separate)",
      "无法进行测量。 固体由几个独立的部分组成。 \r\n" +
        "您需要调用单独的命令（_solidedit _body _separate）"};
    public static readonly string[] MeasureErr = {
      "Failed to measure 3d solid #{0}",
      "Не удалось обмерить 3d-солид #{0}",
      "Impossibile misurare il solido 3d #{0}",
      "3D-Volumenkörper konnte nicht gemessen werden #{0}",
      "无法测量 3d 实体 #{0}"};
    public static readonly string[] EmptyMetricErr = {
      "3d solid #{0} has no metric. Solid excluded from processing.",
      "Нет метрики у 3d-солида #{0}. Солид исключен из обработки.",
      "Il solido 3d #{0} non ha metrica. Solido escluso dalla lavorazione.",
      "3D-Volumenkörper #{0} hat keine Metrik. Feststoff von der Verarbeitung ausgeschlossen.",
      "3d 实体 #{0} 没有度量。 固体排除在处理之外。"};
    public static readonly string[] Measured = {
      "  Measured {0} solids",
      "  Обмерено {0} солидов" ,
      "  Misurati {0} solidi",
      "  Messung {0} Volumenkörper",
      "  测量的 {0} 个固体"};
    public static readonly string[] NoFrontForBendingErr = {
      "3d solid #{0} did not have a flat front side. The edge banding list will not be created.",
      "У 3d-солида #{0} не найдено плоской фасадной стороны. Список торцев не будет создан." ,
      "Il solido 3d #{0} non aveva un lato anteriore piatto. L'elenco dei bordi non verrà creato.",
      "3D-Volumenkörper #{0} hatte keine flache Vorderseite. Die Kantenanleimliste wird nicht erstellt.",
      "3d 实体 #{0} 没有平坦的正面。 不会创建封边列表。"};
    public static readonly string[] BendingListErr = {
      "Failed to list edge bandings for 3d solid #{0}",
      "Не удалось составить список кромок у 3d-солида #{0}" ,
      "Impossibile elencare i bordi per il solido 3d #{0}",
      "Fehler beim Auflisten der Kantenbänder für 3D-Volumenkörper #{0}",
      "未能列出 3d 实体 #{0} 的封边条"};
    public static readonly string[] NoFlatFace = {
      "Solid without flat face.",
      "Тело без плоских граней.",
      "Solido senza faccia piatta.",
      "Volumenkörper ohne flache Kanten.",
      "身体没有平坦的边缘。"};
    public static readonly string[] NoPlane ={
      "Not found the reference plane for measurement solid. Failed solid highlighted in red.",
      "Не найдено базовой плоскости для обмера солида. Сбойный солид выделен красным.",
      "Non trovato il piano di riferimento per la misurazione solida. Solido non riuscito evidenziato in rosso.",
      "Für die Volumenkörpermessung wurde keine Referenzebene gefunden. Der fehlerhafte Volumenkörper ist rot markiert.",
      "未找到用于实体测量的基准平面。 失败的实体以红色突出显示。"};
    public static readonly string[] LayErr = {
      "Can't lay solid to XY.\n{0}",
      "Не удалось выложить солид в XY.\n{0}",
      "Non è possibile porre il solido XY.\n{0}",
      "Volumenkörper konnte nicht in XY gelegt werden.\n{0}",
      "未能在 XY 中放置实体。\n{0}" };
    public static readonly string[] ZeroMatrix = {
      " Zero rotation matrix.",
      " Пустая матрица поворота.",
      " Valore matrice di rotazione Zero",
      " Eine leere Rotationsmatrix.",
      " 空旋转矩阵。"};
    public static readonly string[] PlaneErr = { 
      "The item is not in the XY plane", 
      "Деталь находится не в плоскости XY", 
      "Dettaglio non è nel piano XY", 
      "Das Teil befindet sich nicht in der XY-Ebene",
      "零件不在 XY 平面内" };
    public static readonly string[] BlockNotCreated = { 
      "Block '{0}' not created ", 
      "Блок '{0}' не создан ", 
      "Blocco non creato '{0}'", 
      "Block nicht erstellt '{0}'",
      "未创建块“{0}” " };
    public static readonly string[] ColorErr = { 
      "Can't get color of Face.", 
      "Не удалось получить цвет грани.", 
      "Impossibile ottenere il colore di Surface.", 
      "Die Farbe der Oberfläche kann nicht ermittelt werden.",
      "获取边缘颜色失败。" };
    public static readonly string[,] DefTechno = {    
/* 0 */{"Box", "Бокс", "Parallelepipedo", "Quader","盒子" },
/* 1 */{"Sweep","Развертка","Scansione", "Sweep","扫" },
/* 2 */{"Saw","Напилка","Sega", "Säge","锯" },
/* 3 */{"Milling","Фрезеровка","Fresatura", "Fräsen","铣削" },
/* 4 */{"Double-side", "Двусторонняя", "Due lati", "Doppelseitige","双面" },
/* 5 */{"3D Milling", "3D Фрезеровка","3D Fresatura", "3D Fräsen","3D 铣削" },
/* 6 */{"Unknown", "Не распознано" , "Sconosciuto", "Unbekannte","未知"},
    };

    public static string[,] DefTexture = {
/* 0 */ {"", "", "", "", "" },// {"no_texture", "нет_текстуры", "no_texture", "keine_textur" },
/* 1 */ {"along", "вдоль", "lungo", "entlang", "长向" }, //
/* 2 */ {"across", "поперек", "traverso", "über", "宽向" },
    };

    public static string[] Texture = {
      "<<TEXTURE>>",
      "<<ТЕКСТУРА>>",
      "<<TEXTURE>>",
      "<<TEXTURE>>",
      "<<纹理方向>>" };

    //=========================================== SolSize ===============================================
    public static readonly string[] SweepSize = {
      "Sweep size: {0} x {1} x {2}",
      "Размер развертки: {0} x {1} x {2}",
      "Dimensione scansione: {0} x {1} x {2}",
      "Volumenkörper auswählen: {0} x {1} x {2}",
      "扫描尺寸： {0} x {1} x {2}" };
    public static readonly string[] NothingMeasure = {
      "  Nothing to measure", 
      "  Нечего обмерять", 
      "  Niente da misurare", 
      "  Nichts zu messen",
      "  没有什么可衡量的"};
    public static readonly string[] NoRequireUpdating ={
      "  No solid does not require updating the size",
      "  Ни один солид не требует обновления размеров",
      "  Nessun solido non richiede l'aggiornamento della dimensione",
      "  Kein Volumenkörper erfordert Größenaktualisierungen",
      "  没有实体不需要更新大小" };
    public static readonly string[] SolidWithErrors ={
      "Solid with errors in the structure!",
      "Солид с ошибками в структуре!",
      "Solido con errori nella struttura!",
      "Volumenkörper mit Fehlern in der Struktur!",
      "结构错误的固体！" };
    public static readonly string[] UpdateColor = {
      "Color update", 
      "Обновление цвета", 
      "Aggiornamento del colore", 
      "Farbaktualisierung",
      "颜色更新"};
    public static readonly string[] FindSolids = {
      "Finding objects ...", 
      "Поиск объектов...", 
      "Ricerca di oggetti ...", 
      "Objekte finden ...",
      "寻找对象..." };

  }
}
