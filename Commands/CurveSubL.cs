// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  CurveSubL
  {
    public static readonly string[][] CurveSubStyleNames = {
/* 0 */ CommandL.CurveSub,
/* 1 */ new []{
        "Curve Operations",
        "Операции с кривыми",
        "Operazioni sulle curve",
        "Kurvenoperationen",
        "曲线运算",
        "Operaciones con curvas",                                // ES
        "Opérations sur les courbes",                            // FR
        "Eğri işlemleri"  },                                     // TR
/* 2 */ CurveL.SaveSources
    };

    public static readonly string[] SelectSubtrahendCurves = {
      "Select polylines or other curves to subtract ",
      "Выберите вычитаемые полилинии или другие кривые ",
      "Seleziona le polilinee sottratte o altre curve ",
      "Wählen Sie subtrahierte Polylinien oder andere Kurven aus ",
      "选择减去的折线或其他曲线 ",
      "Seleccione polilíneas u otras curvas para restar ",       // ES
      "Sélectionnez des polylignes ou d'autres courbes à soustraire ",  // FR
      "Çıkarılacak çoklu çizgileri veya diğer eğrileri seçin "};  // TR

    public static readonly string[] SameCurve = {
      "  The same object is selected as both the original and the subtracted one.",
      "  Один и тот же объект выбран и как исходный, и как вычитаемый.",
      "  Lo stesso oggetto viene selezionato sia come originale che come sottratto.",
      "  Dasselbe Objekt wird sowohl als Original als auch als Subtrahiertes Objekt ausgewählt." ,
      "  选择同一对象作为原始对象和减去的对象。",
      "  Se seleccionó el mismo objeto como original y como restado.",  // ES
      "  Le même objet est sélectionné à la fois comme original et comme soustrait.",  // FR
      "  Aynı nesne hem orijinal hem de çıkarılan olarak seçildi."};  // TR

    //============================ CurveSubOptionsBox ==============================================

    public static readonly string[] StyleNameTip = {
      "The name for this curve subtraction style (set of settings). \r\n" +
        "Not used in the program. Only for convenience of choice.",
      "Название для этого стиля вычитания кривых. Не используется в работе программы. \r\n" +
        "Только для удобства выбора.",
      "Nome per questo stile di sottrazione delle curve (set di impostazioni). \r\n" +
        "Non utilizzato nel programma. Solo per comodità di scelta.",
      "Bezeichnung für diese Art der Subtraktion von Kurven (Satz von Einstellungen). \r\n" +
        "Wird im Programm nicht verwendet.\r\n" +
        "Nur zur Bequemlichkeit der Wahl.",
      "这种减法曲线风格的名称。 程序中没有使用。 只为方便选择。",
      "El nombre de este estilo de sustracción de curvas (conjunto de configuraciones). \r\n" +  // ES
        "No se usa en el programa. Solo por conveniencia de elección.",
      "Le nom de ce style de soustraction de courbes (ensemble de paramètres). \r\n" +  // FR
        "Non utilisé dans le programme. Seulement pour la commodité du choix.",
      "Bu eğri çıkarma stili için ad (ayar kümesi). \r\n" +  // TR
        "Programda kullanılmaz. Sadece seçim kolaylığı için."};

    public static readonly string[] GapTip = {
      "The program may create a gap between the contours.\r\n" +
        "If you assign a gap greater than 0, \r\n" +
        "the subtracted contour will be offseted outward by this amount.\r\n" +
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
        "默认为 0。",
      "El programa puede crear un espacio entre los contornos.\r\n" +  // ES
        "Si asigna un espacio mayor que 0, \r\n" +
        "el contorno restado se desplazará hacia afuera por esta cantidad.\r\n" +
        "Predeterminado 0.",
      "Le programme peut créer un espace entre les contours.\r\n" +  // FR
        "Si vous attribuez un espace supérieur à 0, \r\n" +
        "le contour soustrait sera décalé vers l'extérieur de ce montant.\r\n" +
        "Par défaut 0.",
      "Program konturlar arasında bir boşluk oluşturabilir.\r\n" +  // TR
        "0'dan büyük bir boşluk atarsanız, \r\n" +
        "çıkarılan kontur bu miktar kadar dışarı doğru kaydırılacaktır.\r\n" +
        "Varsayılan 0."};

    public static readonly string[] ResultLayer = {
      "Result layer",
      "Слой результатов",
      "Layer risultati",
      "Ergebnisebene",
      "结果层",
      "Capa de resultado",                                       // ES
      "Couche de résultat",                                      // FR
      "Sonuç katmanı"};                                          // TR

    public static readonly string[] ResultLayerTip = {
      "Replace the layer of successfully processed objects. \r\n" +
        "When assigning a layer, all properties will be reset to ByLayer. \r\n" +
        "If necessary, the program will create a new layer.",
      "Заменять слой у удачно обработанных объектов. \r\n" +
        "При назначении слоя все свойства будут сброшены на ПоСлою.\r\n" +
        "При необходимости программа создаст новый слой.",
      "Sostituisci il layer degli oggetti elaborati correttamente. \r\n" +
        "Quando si assegna un layer, tutte le proprietà verranno reimpostate su ByLayer. \r\n" +
        "Se necessario, il programma creerà un nuovo livello.",
      "Ersetzen Sie die Ebene erfolgreich verarbeiteter Objekte. \r\n" +
        "Beim Zuweisen einer Ebene werden alle Eigenschaften auf 'Nach Ebene' zurückgesetzt. \r\n" +
        "Bei Bedarf erstellt das Programm eine neue Ebene.",
      "替换成功处理对象的图层。\r\n" +
        "分配图层时，所有属性将重置为 ByLayer。\r\n" +
        "如有必要，程序将创建一个新层。",
      "Reemplazar la capa de objetos procesados ​​correctamente. \r\n" +  // ES
        "Al asignar una capa, todas las propiedades se restablecerán a ByLayer. \r\n" +
        "Si es necesario, el programa creará una nueva capa.",
      "Remplacer la couche des objets traités avec succès. \r\n" +  // FR
        "Lors de l'attribution d'une couche, toutes les propriétés seront réinitialisées à ByLayer. \r\n" +
        "Si nécessaire, le programme créera une nouvelle couche.",
      "Başarıyla işlenen nesnelerin katmanını değiştir. \r\n" +  // TR
        "Bir katman atarken, tüm özellikler ByLayer'a sıfırlanacaktır. \r\n" +
        "Gerekirse, program yeni bir katman oluşturacaktır."};

    public static readonly string[] SubtrahendLayerTip = {
      "Layer for automatic assignment of subtracted objects among all selected ones.",
      "Слой для автоматического назначения вычитаемых объектов среди всех выбранных.",
      "Layer per l'assegnazione automatica degli oggetti sottratti \r\n" +
        "tra tutti quelli selezionati.",
      "Ebene zur automatischen Zuordnung subtrahierter Objekte zu allen ausgewählten Objekten.",
      "用于在所有选定对象之间自动分配减去的对象的图层。",
      "Capa para la asignación automática de objetos restados entre todos los seleccionados.",  // ES
      "Couche pour l'attribution automatique des objets soustraits parmi tous ceux sélectionnés.",  // FR
      "Seçilen tüm nesneler arasında çıkarılan nesnelerin otomatik olarak atanması için katman."};  // TR

    public static readonly string[] SelectByLayer = {
      "Select subtractables by layer",
      "Выбирать вычитаемые по слою",
      "Seleziona sottratto dal layer",
      "Wählen Sie ihre Ebene subtrahiert aus",
      "选择减去其图层",
      "Seleccionar restables por capa",                          // ES
      "Sélectionner les soustractibles par couche",              // FR
      "Katmana göre çıkarılabilenleri seç"};                     // TR

    public static readonly string[] SelectByLayerTip = {
      "Select source and subtracted objects with one query. \r\n" +
        "Subtracted objects will be assigned by their layer.",
      "Выбирать исходные и вычитаемые объекты одним запросом. \r\n" +
        "Вычитаемые объекты будут назначены по их слою.",
      "Seleziona gli oggetti sorgente e sottratti in una query. \r\n" +
        "Gli oggetti sottratti verranno assegnati in base al loro layer.",
      "Wählen Sie Quell- und subtrahierte Objekte in einer Abfrage aus. \r\n" +
        "Subtrahierte Objekte werden anhand ihrer Ebene zugeordnet.",
      "在一个查询中选择源对象和减去的对象。减去的对象将按其图层进行分配。",
      "Seleccionar objetos de origen y restados con una consulta. \r\n" +  // ES
        "Los objetos restados se asignarán por su capa.",
      "Sélectionner les objets source et soustraits avec une seule requête. \r\n" +  // FR
        "Les objets soustraits seront attribués par leur couche.",
      "Kaynak ve çıkarılan nesneleri tek bir sorguyla seç. \r\n" +  // TR
        "Çıkarılan nesneler katmanlarına göre atanacaktır."};

    public static readonly string[] SaveStubTip = {
      "Keep the cut off part of the original contour, \r\n" +
        "that is, the area of ​​intersection of the contours.",
      "Сохранять отрезанную часть исходного контура, \r\n" +
        "то есть область пересечения контуров.",
      "Conserva la parte tagliata del contorno originale, \r\n" +
        "ovvero l'area in cui i contorni si intersecano.",
      "Behalten Sie den abgeschnittenen Teil der ursprünglichen Kontur bei, \r\n" +
        "also den Bereich, in dem sich die Konturen schneiden.",
      "保留原来轮廓被剪掉的部分，即轮廓相交的区域。",
      "Mantener la parte cortada del contorno original, \r\n" +  // ES
        "es decir, el área de intersección de los contornos.",
      "Conserver la partie coupée du contour d'origine, \r\n" +  // FR
        "c'est-à-dire la zone d'intersection des contours.",
      "Orijinal konturun kesilmiş kısmını koru, \r\n" +  // TR
        "yani konturların kesişme alanını."};

    public static readonly string[] WorkWithOpen = {
      "Work with open",
      "Работать с разомкнутыми",
      "Lavora con aperto",
      "Arbeiten Sie mit offen",
      "使用开放曲线",
      "Trabajar con abiertos",                                   // ES
      "Travailler avec ouvert",                                  // FR
      "Açık olanlarla çalış"};                                   // TR

    public static readonly string[] WorkWithOpenTip = {
      "Use open curves to cut contours. \r\n" +
        "If you do not enable this option, open curves will be ignored.",
      "Использовать разомкнутые кривые для разрезания контуров. \r\n" +
        "Если не включить эту опцию , то разомкнутые кривые будут проигнорированы.",
      "Utilizzare curve aperte per tagliare i contorni. \r\n" +
        "Se non si abilita questa opzione, le curve aperte verranno ignorate.",
      "Verwenden Sie offene Kurven, um Konturen zu schneiden. \r\n" +
        "Wenn Sie diese Option nicht aktivieren, werden offene Kurven ignoriert.",
      "使用开放曲线来切割轮廓。如果不启用此选项，则开放曲线将被忽略。",
      "Usar curvas abiertas para cortar contornos. \r\n" +  // ES
        "Si no habilita esta opción, se ignorarán las curvas abiertas.",
      "Utiliser des courbes ouvertes pour couper les contours. \r\n" +  // FR
        "Si vous n'activez pas cette option, les courbes ouvertes seront ignorées.",
      "Konturları kesmek için açık eğrileri kullan. \r\n" +  // TR
        "Bu seçeneği etkinleştirmezseniz, açık eğriler yok sayılacaktır."};

    public static readonly string[] DeleteSubtrahend = {
      "Delete subtrahend",
      "Удалить вычитаемое",
      "Rimuovi il sottraendo",
      "Subtrahend entfernen",
      "删除减数",
      "Eliminar sustraendo",                                     // ES
      "Supprimer le soustrait",                                  // FR
      "Çıkarılanı sil"};                                         // TR

    public static readonly string[] DeleteSubtrahendTip = {
      "Erase curves actually used for subtraction.",
      "Стирать кривые, реально использованные для вычитания.",
      "Cancella le curve effettivamente utilizzate per la sottrazione.",
      "Löschen Sie Kurven, die tatsächlich zur Subtraktion verwendet werden.",
      "删除实际用于减法的曲线。",
      "Borrar curvas realmente utilizadas para la sustracción.",  // ES
      "Effacer les courbes réellement utilisées pour la soustraction.",  // FR
      "Çıkarma için gerçekten kullanılan eğrileri sil."};        // TR


  }
}