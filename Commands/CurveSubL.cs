// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  CurveSubL
  {
    public static readonly string[,] CurveSubStyleNames = {
/* 0 */ {
        CommandL.CurveSub[0],
        CommandL.CurveSub[1],
        CommandL.CurveSub[2],
        CommandL.CurveSub[3],
        CommandL.CurveSub[4]  },
/* 1 */ {
        CommandL.CurveSub[0],
        CommandL.CurveSub[1],
        CommandL.CurveSub[2],
        CommandL.CurveSub[3],
        CommandL.CurveSub[4]  },
    };

    public static readonly string[] Process = {
      "Processing",
      "Обработка",
      "Elaborazione",
      "Verarbeitung",
      "加工"};
    public static readonly string[] SelectSubtrahendCurves ={
      "Select polylines or other curves to subtract ",
      "Выберите вычитаемые полилинии или другие кривые ",
      "Seleziona le polilinee sottratte o altre curve ",
      "Wählen Sie subtrahierte Polylinien oder andere Kurven aus ",
      "选择减去的折线或其他曲线 " };
    public static readonly string[] SameCurve = {
      "  The same object is selected as both the original and the subtracted one.",
      "  Один и тот же объект выбран и как исходный, и как вычитаемый.",
      "  Lo stesso oggetto viene selezionato sia come originale che come sottratto.",
      "  Dasselbe Objekt wird sowohl als Original als auch als Subtrahiertes Objekt ausgewählt." ,
      "  选择同一对象作为原始对象和减去的对象。"};

    //============================ CurveSubOptionsBox ==============================================

    public static readonly string[] StyleNameTip = {
      "The name for this curve subtraction style (set of settings). Not used in the program. Only for convenience of choice.",
      "Название для этого стиля вычитания кривых. Не используется в работе программы. Только для удобства выбора.",
      "Nome per questo stile di sottrazione delle curve (set di impostazioni). Non utilizzato nel programma. Solo per comodità di scelta.",
      "Bezeichnung für diese Art der Subtraktion von Kurven (Satz von Einstellungen). Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "这种减法曲线风格的名称。 程序中没有使用。 只为方便选择。"};
    public static readonly string[] GapTip = {
      "The program may create a gap between the contours.\r\n" +
        "If you assign a gap greater than 0, \r\n" +
        "the subtracted contour will be shifted outward by this amount.\r\n" +
        "Default 0.",
      "Можно создать зазор между контурами.\r\n" +
        "Если назначить зазор больше 0, \r\n" +
        "то вычитаемый контур будет смещен наружу на это число.\r\n" +
        "По умолчанию 0.",
      "Il programma potrebbe creare uno spazio tra i contorni.\r\n" +
        "Se si assegna uno spazio maggiore di 0, \r\n" +
        "il contorno sottratto verrà spostato verso l'esterno di questo numero. \r\n" +
        "i solidi del foro prima della sottrazione.\r\n" +
        "Predefinito 0.",
      "Sie können eine Lücke zwischen den Konturen erzeugen.\r\n" +
        "Wenn Sie eine Lücke größer als 0 zuweisen, \r\n" +
        "wird die subtrahierte Kontur um diesen Wert nach außen verschoben.\r\n" +
        "Standard 0.",
      "该程序可能会在轮廓之间创建间隙。\r\n" +
        "如果指定大于 0 的间隙，则减去的轮廓将向外移动该数字。" +
        "默认为 0。" };
    public static readonly string[] ResultLayer = {
      "Result layer",
      "Слой результатов",
      "Layer risultati",
      "Ergebnisebene",
      "结果层"    };
    public static readonly string[] ResultLayerTip = {
      "",
      "Заменять слой у удачно обработанных объектов. При необходимости программа создаст новый слой.",
      "",
      "",
      ""    };
    public static readonly string[] SubtrahendLayerTip = {
      "",
      "Слой для автоматического назначения вычитаемых объектов среди всех выбранных.",
      "",
      "",
      ""    };
    public static readonly string[] SelectByLayer = {
      "Select subtractables by layer",
      "Выбирать вычитаемые по слою",
      "Seleziona sottratto dal layer",
      "Wählen Sie ihre Ebene subtrahiert aus",
      "选择减去其图层"    };
    public static readonly string[] SelectByLayerTip = {
      "",
      "Выбирать исходные и вычитаемые объекты одним запросов. Вычитаемые объекты будут назначены по их слою.",
      "",
      "",
      ""    };
    public static readonly string[] SaveStubTip = {
      "",
      "Сохранять отрезанную часть исходного контура, то есть область пересечения контуров.",
      "",
      "",
      ""    };
    public static readonly string[] WorkWithOpen = {
      "Work with open",
      "Работать с разомкнутыми",
      "Lavora con aperto",
      "Arbeiten Sie mit offen",
      "使用开放曲线"    };
    public static readonly string[] WorkWithOpenTip = {
      "",
      "Использовать разомкнутые кривые для разрезания контуров. Если не включить эту опцию , то разомкнутые кривые будут проигнорированы.",
      "",
      "",
      ""    };
    public static readonly string[] DeleteSubtrahend = {
      "Delete subtrahend",
      "Удалить вычитаемое",
      "Rimuovi il sottraendo",
      "Subtrahend entfernen",
      "删除减数"    };
    public static readonly string[] DeleteSubtrahendTip = {
      "Erase curves actually used for subtraction.",
      "Стирать кривые, реально использованные для вычитания.",
      "Cancella le curve effettivamente utilizzate per la sottrazione.",
      "Löschen Sie Kurven, die tatsächlich zur Subtraktion verwendet werden.",
      "删除实际用于减法的曲线。"    };

  }
}
