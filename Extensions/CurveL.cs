// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  /// <summary>
  /// Локализация методов для работы с 2D объектами, кривыми
  /// </summary>
  public static class
  CurveL
  {
    public static readonly string[] NotPlanar = {
      "Curve is not Planar!",
      "Кривая не плоская!",
      "La curva non è piatta!",
      "Die Kurve ist nicht flach!",
      "曲线不是平面的！",
      "¡La curva no es plana!",
      "La courbe n'est pas plane!",
      "Eğri düzlemsel değil!"};
    
    public static readonly string[] NotSupported = {
      "Curve type {0} not supported",
      "Кривые типа {0} не поддерживаются",
      "Le curve di tipo {0} non sono supportate.",
      "Kurven vom Typ {0} werden nicht unterstützt.",
      "不支持曲线类型 {0}",
      "Tipo de curva {0} no compatible",
      "Type de courbe {0} non pris en charge",
      "Eğri türü {0} desteklenmiyor"};
    
    public static readonly string[] PLineOffsetErr = {
      "Can't offset polyline",
      "Невозможно сделать офсет полилинии",
      "Impossibile spostare la polilinea",
      "Polylinienversatz nicht möglich.",
      "不能偏移多线段",
      "No se puede desplazar la polilínea",
      "Impossible de décaler la polyligne",
      "Çoklu çizgi kaydırılamıyor"};
    
    public static readonly string[] CurveOffsetErr = {
      "Failed to offset",
      "Не удалось сделать офсет",
      "Impossibile compensare",
      "Der Ausgleich ist fehlgeschlagen",
      "抵消失败",
      "Error al desplazar",
      "Échec du décalage",
      "Kaydırma başarısız"};
    
    public static readonly string[] CutCurveErr = {
      "Could not cut curve.",
      "Невозможно разрезать кривую.",
      "Impossibile tagliare la curva.",
      "Kurve kann nicht geschnitten werden.",
      "无法切割曲线。",
      "No se pudo cortar la curva.",
      "Impossible de couper la courbe.",
      "Eğri kesilemedi."};
    
    public static readonly string[] JoinCurveErr = {
      "Failed to connect the curves.",
      "Не получилось соединить кривые.",
      "Impossibile collegare le curve.",
      "Die Kurven konnten nicht verbunden werden.",
      "无法连接曲线。",
      "No se pudieron conectar las curvas.",
      "Impossible de connecter les courbes.",
      "Eğriler bağlanamadı."};
    
    public static readonly string[] ConvertErr = {
      "Impossible convert to curve",
      "Недопустимо преобразование к кривой",
      "Converti impossibile in curva",
      "Ungültige Konvertierung in Kurve",
      "不可能转换成曲线",
      "Imposible convertir a curva",
      "Impossible de convertir en courbe",
      "Eğriye dönüştürme imkansız"};
    
    public static readonly string[] CurveExtentsErr = {
      "Failed to get curve dimensions",
      "Не удалось получить габариты кривой",
      "Impossibile ottenere le dimensioni della curva",
      "Kurvenabmessungen konnten nicht abgerufen werden",
      "无法获取曲线尺寸",
      "No se pudieron obtener las dimensiones de la curva",
      "Impossible d'obtenir les dimensions de la courbe",
      "Eğri boyutları alınamadı"};
    
    public static readonly string[] Required3point = {
      "At least 3 points required",
      "Требуется хотя бы 3 точки",
      "Richiede almeno 3 punti.",
      "Mindestens 3 Punkte erforderlich",
      "至少需要3分",
      "Se requieren al menos 3 puntos",
      "Au moins 3 points requis",
      "En az 3 nokta gerekli"};
    
    public static readonly string[] NotCurve = {
      "\nThis is not a curve!\n",
      "\nЭто не кривая!\n",
      "\nNon è una curva!\n",
      "\nEs ist keine Kurve!\n",
      "\n这不是曲线!\n",
      "\n¡Esto no es una curva!\n",
      "\nCe n'est pas une courbe!\n",
      "\nBu bir eğri değil!\n"};
    
    public static readonly string[] NeedCurve = {
      "The program needs a curve, but {0} is selected.",
      "Программе нужна кривая, а выбран {0}",
      "Il programma necessita di una curva, ma è selezionato {0}.",
      "Das Programm benötigt eine Kurve, aber {0} ist ausgewählt.",
      "程序需要曲线，但选择了{0}。",
      "El programa necesita una curva, pero se seleccionó {0}.",
      "Le programme a besoin d'une courbe, mais {0} est sélectionné.",
      "Program bir eğriye ihtiyaç duyuyor, ancak {0} seçildi."};
    
    public static readonly string[] NeedFiniteCurve = {
      "The program needs a finite curve, but {0} is selected.",
      "Программе нужна конечная кривая, а выбран {0}",
      "Il programma necessita di una curva finale ed è selezionato {0}",
      "Das Programm benötigt eine Endkurve und {0} ist ausgewählt",
      "程序需要最终曲线并选择 {0}",
      "El programa necesita una curva finita, pero se seleccionó {0}.",
      "Le programme a besoin d'une courbe finie, mais {0} est sélectionné.",
      "Program sonlu bir eğriye ihtiyaç duyuyor, ancak {0} seçildi."};
    
    public static readonly string[] SelectCurves = {
      "Select polylines or other curves ",
      "Выберите полилинии или другие кривые ",
      "Seleziona polilinee o altre curve ",
      "Wählen Sie Polylinien oder andere Kurven aus ",
      "选择折线或其他曲线 ",
      "Seleccione polilíneas u otras curvas ",
      "Sélectionnez des polylignes ou d'autres courbes ",
      "Çoklu çizgileri veya diğer eğrileri seçin "};
    
    public static readonly string[] RegionExplodeErr = {
      "Failed to explode the region on the lines. Error {0}",
      "Не удалось взорвать регион на линии. Ошибка {0}",
      "Impossibile far saltare in aria la regione sulla linea. Errore {0}",
      "Der Bereich auf der Leitung konnte nicht gesprengt werden. Fehler {0}",
      "未能炸毁线上区域。 错误{0}",
      "No se pudo descomponer la región en líneas. Error {0}",
      "Impossible d'éclater la région sur les lignes. Erreur {0}",
      "Bölge çizgilere patlatılamadı. Hata {0}"};
    
    public static readonly string[] UnionProcess = {
      "Consolidation of regions",
      "Объединение регионов",
      "Consolidamento delle regioni",
      "Konsolidierung der Regionen",
      "区域合并",
      "Consolidación de regiones",
      "Consolidation des régions",
      "Bölgelerin birleştirilmesi"};
    
    public static readonly string[] RegSubError = {
      "Failed to subtract regions.",
      "Не удалось выполнить вычитание регионов.",
      "La sottrazione della regione non è riuscita.",
      "Die Regionssubtraktion ist fehlgeschlagen.",
      "区域减法失败。",
      "No se pudieron restar las regiones.",
      "Impossible de soustraire les régions.",
      "Bölgeler çıkarılamadı."};
    
    public static readonly string[] RegUnionError = {
      "Failed to union regions.",
      "Не удалось выполнить объединение регионов.",
      "Unione delle regioni non riuscita.",
      "Die Zusammenführung der Region ist fehlgeschlagen.",
      "区域合并失败。",
      "No se pudieron unir las regiones.",
      "Impossible d'unir les régions.",
      "Bölgeler birleştirilemedi."};
    
    public static readonly string[] RegSliceError = {
      "Failed to cut region with open curve.",
      "Не удалось разрезать регион незамкнутой кривой.",
      "Impossibile tagliare la regione con curva aperta.",
      "Bereich mit offener Kurve konnte nicht geschnitten werden.",
      "无法切割具有开放曲线的区域。",
      "No se pudo cortar la región con curva abierta.",
      "Impossible de couper la région avec une courbe ouverte.",
      "Açık eğriyle bölge kesilemedi."};
    
    public static readonly string[] CreateRegionFail = {
      "Error creating region by curve",
      "Не получилось построить регион по кривой",
      "Errore durante la creazione di una regione lungo una curva",
      "Fehler beim Erstellen einer Region entlang einer Kurve",
      "沿曲线创建区域时出错",
      "Error al crear región por curva",
      "Erreur lors de la création d'une région par courbe",
      "Eğriye göre bölge oluşturma hatası"};
    
    public static readonly string[] ConnectProcess = {
      "Building closed polylines",
      "Построение замкнутых полилиний",
      "Costruire polilinee chiuse",
      "Erstellen geschlossener Polylinien",
      "构建闭合折线",
      "Construyendo polilíneas cerradas",
      "Construction de polylignes fermées",
      "Kapalı çoklu çizgiler oluşturuluyor"};
    
    public static readonly string[] SkipOpen = {
      "An open curve will not be processed.",
      "Разомкнутая кривая не будет обработана.",
      "Una curva aperta non verrà elaborata.",
      "Eine offene Kurve wird nicht verarbeitet.",
      "不会处理开放曲线。",
      "Una curva abierta no será procesada.",
      "Une courbe ouverte ne sera pas traitée.",
      "Açık eğri işlenmeyecek."};
    
    public static readonly string[] CreateRegion = {
      "Create regions",
      "Создать регионы",
      "Crea una regione",
      "Erstellen Sie eine Region",
      "创建区域 (Region)",
      "Crear regiones",
      "Créer des régions",
      "Bölge oluştur"};
    
    public static readonly string[] CreateRegionTip = {
      "Save the result as a Region object, not a polyline or spline.",
      "Сохранить результат в виде объекта типа Region, а не полилинии или сплайна.",
      "Salva il risultato come oggetto Regione anziché come polilinea o spline.",
      "Speichern Sie das Ergebnis als Regionsobjekt und nicht als Polylinie oder Spline.",
      "将结果保存为 Region 对象而不是折线或样条线。",
      "Guardar el resultado como objeto Región, no como polilínea o spline.",
      "Enregistrer le résultat en tant qu'objet Région, pas en tant qu'en tant que polyligne ou spline.",
      "Sonucu Bölge nesnesi olarak kaydet, çoklu çizgi veya spline olarak değil."};
    
    public static readonly string[] DeleteSources = {
      "Delete sources",
      "Удалить исходные",
      "Elimina originale",
      "Quellen löschen",
      "删除原始曲线",
      "Eliminar originales",
      "Supprimer les sources",
      "Kaynakları sil"};
    
    public static readonly string[] SaveSources = {
      "Save sources",
      "Сохранять исходные",
      "Mantieni l'originale",
      "Original aufbewahren",
      "保持原有曲线",
      "Guardar originales",
      "Conserver les sources",
      "Kaynakları sakla"};
    
    public static readonly string[] DeleteSourcesTip = {
      "Delete all original lines and curves that were processed.",
      "Удалить все исходные линии и кривые, которые удалось обработать.",
      "Elimina tutte le linee e le curve originali che sono state elaborate.",
      "Löschen Sie alle ursprünglich verarbeiteten Linien und Kurven.",
      "删除所有已处理的原始直线和曲线。",
      "Eliminar todas las líneas y curvas originales que fueron procesadas.",
      "Supprimer toutes les lignes et courbes d'origine qui ont été traitées.",
      "İşlenen tüm orijinal çizgileri ve eğrileri sil."};
  }
}
