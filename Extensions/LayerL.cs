// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Linetype

namespace AVC
{
  /// <summary>
  /// Локализация методов для работы со слоями.
  /// Названия слоев и типов линий. Важно, чтоб совпадали с названиями в соответствующей локализации AutoCAD
  /// </summary>
  public static class
  LayerL
  {
    // Слой = 图层
    // Тип линий = 线型

    public static readonly string[] LinetypeErr = {
      "{0} linetype not found",
      "{0} тип линий не найден",
      "{0} tipo di linea non trovato",
      "{0} linientyp nicht gefunden",
      "未找到 {0} 个线型"};
    public static readonly string[] LayerErr = {
      "Layer '{0}' not found",
      "Слой '{0}' отсутствует в чертеже",
      "Layer '{0}' non trovato",
      "Layer '{0}' wurde nicht gefunden",
      "未找到图层“{0}”" };
    public static readonly string[] LayerExist = {
      "Layer '{0}' already exist",
      "Слой '{0}' уже есть в чертеже",
      "Layer '{0}' esiste già",
      "Layer '{0}' existiert bereits",
      "图层“{0}”已存在" };
    public static readonly string[] LayerCreated = {
      "  Created layer '{0}'",
      "  Создан слой '{0}'",
      "  Layer creato '{0}'",
      "  Layer erstellen '{0}'",
      "  未找到图层“{0}”" };
    public static readonly string[] ExtRefWarning = {
      "Cannot save layer in xref. Open the external file in a separate window.",
      "Невозможно сохранить слой во внешней ссылке. Откройте внешний файл в отдельном окне.",
      "Impossibile salvare il layer in xrif. Apri il file esterno in una finestra separata.",
      "Layer in xref kann nicht gespeichert werden. Öffnen Sie die externe Datei in einem separaten Fenster.",
      "无法在外部参照中保存图层。 在单独的窗口中打开外部文件。"};
    public static readonly string[] ActivateLayerErr = {
      "Can't activate layer {0}",
      "Не удалось включить слой {0}",
      "Impossibile abilitare il layer {0}",
      "Layer konnte nicht aktiviert werden {0}",
      "未能启用图层 {0}"};
    public static readonly string[] ActivateColorErr = {
      "Failed to enable default color {0}",
      "Не удалось включить цвет по умолчанию {0}",
      "Impossibile abilitare il colore predefinito {0}",
      "Standardfarbe {0} konnte nicht aktiviert werden",
      "未能启用默认颜色 {0}"};
    public static readonly string[] LockedLayer = {
      "Can't modify object. Layer locked",
      "Невозможно модифицировать объект на заблокированном слое",
      "Non è possibile modificare un oggetto su un layer bloccato",
      "Objekt auf gesperrter Ebene kann nicht geändert werden",
      "无法修改锁定图层上的对象"};
    public static readonly string[] ColorNo = {
      "Color #",
      "Цвет №",
      "Colore #",
      "Color #",
      "颜色编号" };

    #region Названия слоев
    // Названия слоев должны соответствовать правилам именования объектов AutoCAD (без спецсимволов)

    public static readonly string[] LayerCenter = {
      "Center",
      "Оси",
      "Assiale",
      "Achse",
      "中心线" };
    public static readonly string[] LayerAnnotation = {
      "Annotation",
      "Аннотация",
      "Annotation",
      "Beschriftung",
      "Annotation" };
    public static readonly string[] LayerOther = {
      "Other",
      "Прочее",
      "Altro",
      "Andere",
      "其他" };
    public static readonly string[] LayerHoles = {
      "Holes",
      "Отверстия",
      "Tagliente",
      "Löcher",
      "孔" };
    public static readonly string DefaultLayerHoles = 
      "Hole,Holes," +
      "Отверстие,Отверстия," +
      "Tagliente," +
      "Löcher," +
      "孔";
    public static readonly string[] LayerFixture = {
      "Fixture",
      "Крепеж",
      "Fissaggio",
      "Befestigungen",
      "家具五金" };
    public static readonly string[] LayerExcluding = {
      "Excluding",
      "Без учета",
      "Escludendo",
      "Ausschließlich",
      "过滤" };

    // следующие названия слоев должны ТОЧНО соответствовать
    // названиям слоев Model Documentation в соответствующей локализации AutoCAD
    public static readonly string[] LayerMDVisible = {
      "MD_Visible",
      "MD_Видимые",
      "MD_Visibile",
      "MD_Sichtbar",
      "MD_可见" };
    public static readonly string[] LayerMDHidden = {
      "MD_Hidden",
      "MD_Скрытие линий",
      "MD_Nascosta",
      "MD_Verdeckt",
      "MD_隐藏" };
    public static readonly string[] LayerMDAnnotation = {
      "MD_Annotation",
      "MD_Аннотация",
      "MD _Annotation",
      "MD_Beschriftung",
      "MD_Annotation" }; // В итальянском AutoCAD - с пробелом!!! В китайском не переведен
    public static readonly string[] LayerMDHatching = {
      "MD_Hatching",
      "MD_Штриховка",
      "MD_Hatching",
      "MD_Schraffur",
      "MD_Hatching" }; // В итальянском и китайском не переведен
    #endregion

    #region названия типов линий
    // названия типов линий должны ТОЧНО совпадать с названиями этих типов линий в соответствующей локализации AutoCAD 
    public static readonly string[] LinetypeBORDER = {
      "BORDER",
      "рант",
      "BORDO",
      "RAND",
      "BORDER" };
    public static readonly string[] LinetypeCENTER = {
      "CENTER2",
      "осевая2",
      "CENTRO2",
      "MITTE2",
      "CENTER2" };
    public static readonly string[] LinetypeDASHED = {
      "DASHED2",
      "штриховая2",
      "TRATTEGGIATA2",
      "STRICHLINIE2",
      "DASHED2" };
    public static readonly string[] LinetypeDASHDOT = {
      "DASHDOT",
      "штрихпунктирная",
      "TRATTOPUNTO",
      "STRICHPUNKT",
      "DASHDOT" };
    public static readonly string[] LinetypeDOT = {
      "DOT",
      "пунктирная",
      "PUNTO",
      "PUNKT",
      "DOT" };
    public static readonly string[] LinetypeHIDDEN = {
      "HIDDEN2",
      "невидимая2",
      "NACOSTA2",
      "VERDECKT2",
      "HIDDEN2" };
    public static readonly string[] LinetypePHANTOM = {
      "PHANTOM",
      "фантом",
      "FANTASMA",
      "PHANTOM",
      "PHANTOM" };
    #endregion

  }
}
