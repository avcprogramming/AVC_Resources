// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Unselect

namespace AVC
{
  public static class
  QCleaningL
  {
    public static readonly string[] SelectOne = {
      "Select one sample or press ESC",
      "Выберите 1 образец или нажмите ESC",
      "Selezionare un campione o premere ESC",
      "Wählen Sie eine Probe aus oder drücken Sie ESC",
      "选择一个样本或按 ESC",
      "Seleccione una muestra o presione ESC",          // ES
      "Sélectionnez un échantillon ou appuyez sur ESC", // FR
      "Bir örnek seçin veya ESC'ye basın"};            // TR

    public static readonly string[] SelectForUn = {
      "Select sample for unselect",
      "Выберите образец для исключения",
      "Seleziona il campione per deselezionarlo",
      "Wählen Sie eine Probe aus, um die Auswahl aufzuheben",
      "选择要取消选择的样本",
      "Seleccione muestra para deseleccionar",          // ES
      "Sélectionnez un échantillon pour désélectionner", // FR
      "Seçimi kaldırmak için örnek seçin" };           // TR

    public static readonly string[] DeleteKW = {
      "Delete",
      "Удалить",
      "Elimina",
      "Löschen",
      "删除(D)",
      "Eliminar",                                       // ES
      "Supprimer",                                      // FR
      "Sil" };                                          // TR

    public static readonly string[] UnselectKW = {
      "Unselect",
      "Исключить",
      "Deseleziona",
      "AuswahlAufheben",
      "取消选择(U)",
      "Deseleccionar",                                  // ES
      "Désélectionner",                                 // FR
      "SeçimiKaldır" };                                 // TR

    public static readonly string[] ToleranceKW = {
      "Tolerance",
      "Точность",
      "Tolleranza",
      "Toleranz",
      "宽容(T)",
      "Tolerancia",                                     // ES
      "Tolérance",                                      // FR
      "Tolerans" };                                     // TR

    public static readonly string[] ToleranceQuery = {
      "What is the acceptable length comparison error? (or 0)",
      "Какая погрешность сравнения длины допустима? (или 0)",
      "Qual è l'errore di confronto della lunghezza accettabile? (o 0)",
      "Was ist der akzeptable Längenvergleichsfehler? (oder 0)",
      "可接受的长度比较误差是多少？ （或 0）",
      "¿Cuál es el error de comparación de longitud aceptable? (o 0)",  // ES
      "Quelle est l'erreur de comparaison de longueur acceptable ? (ou 0)",  // FR
      "Kabul edilebilir uzunluk karşılaştırma hatası nedir? (veya 0)" };  // TR

    public static readonly string[] Selected = {
      "  Selected {0} objects",
      "  Выбрано {0} объектов",
      "  {0} oggetti selezionati",
      "  Ausgewählte {0} Objekte",
      "  选定的 {0} 个对象",
      "  {0} objetos seleccionados",                   // ES
      "  {0} objets sélectionnés",                     // FR
      "  {0} nesne seçildi" };                         // TR

    public static readonly string[] HighlightErr = {
      "Failed to highlight objects",
      "Сбой подсветки объектов",
      "Impossibile evidenziare gli oggetti",
      "Objekte konnten nicht hervorgehoben werden",
      "未能突出显示对象",
      "No se pudieron resaltar los objetos",           // ES
      "Échec de la mise en évidence des objets",       // FR
      "Nesneler vurgulanamadı" };                      // TR

    public static readonly string[] ToleranceInfo = {
      "  When comparing lengths, an error less than {0} will be ignored",
      "  При сравнении длин будет игнорироваться разница менее {0}",
      "  Quando si confrontano le lunghezze, un errore inferiore a {0} verrà ignorato",
      "  Beim Vergleichen von Längen wird ein Fehler kleiner als {0} ignoriert",
      "  比较长度时，将忽略小于 {0} 的错误",
      "  Al comparar longitudes, se ignorará un error menor que {0}",  // ES
      "  Lors de la comparaison des longueurs, une erreur inférieure à {0} sera ignorée",  // FR
      "  Uzunlukları karşılaştırırken, {0}'dan küçük bir hata göz ardı edilecektir" };  // TR

    public static readonly string[] SpaceErr = {
      "Can't get current space",
      "Сбой при получении текущего пространства",
      "Impossibile ottenere lo spazio corrente",
      "Aktueller Speicherplatz kann nicht abgerufen werden",
      "获取当前空间失败",
      "No se puede obtener el espacio actual",          // ES
      "Impossible d'obtenir l'espace actuel",           // FR
      "Geçerli alan alınamıyor" };                     // TR

    public static readonly string[] Nothing = {
      "There is nothing to look for",
      "Нечего искать",
      "Non c'è niente da cercare",
      "Es gibt nichts zu suchen",
      "没有什么可找的",
      "No hay nada que buscar",                        // ES
      "Il n'y a rien à chercher",                      // FR
      "Aranacak bir şey yok" };                        // TR

    public static readonly string[] Reading = {
      "  Reading all drawing objects",
      "  Считывание всех объектов чертежа",
      "  Lettura di tutti gli oggetti di disegno",
      "  Lettura di tutti gli oggetti di disegno",
      "  读取所有绘图对象",
      "  Leyendo todos los objetos del dibujo",        // ES
      "  Lecture de tous les objets du dessin",        // FR
      "  Tüm çizim nesneleri okunuyor" };              // TR

    public static readonly string[] ReadInfo = {
      "  Objects read: {0} by {1}sec",
      "  Прочитано объектов: {0} за {1}сек",
      "  Oggetti letti: {0} di {1} sec",
      "  Gelesene Objekte: {0} mal {1} Sek",
      "  对象读取：{0} {1} 秒",
      "  Objetos leídos: {0} en {1} seg",              // ES
      "  Objets lus : {0} en {1} sec",                 // FR
      "  Okunan nesneler: {0} {1} saniyede" };         // TR

    public static readonly string[] Found = {
      "  Found {0} objects by {1}sec",
      "  Найдено {0} объектов за {1}сек",
      "  Trovati {0} oggetti per {1} sec",
      "  {0} Objekte um {1} Sek. Gefunden.",
      "  {1} 秒内找到 {0} 个对象",
      "  Se encontraron {0} objetos en {1} seg",       // ES
      "  {0} objets trouvés en {1} sec",               // FR
      "  {1} saniyede {0} nesne bulundu" };            // TR

    public static readonly string[] DeleteInfo = {
      "  Delete {0} objects",
      "  Удалено {0} объектов",
      "  Elimina {0} oggetti",
      "  Löschen Sie {0} Objekte",
      "  删除 {0} 个对象",
      "  {0} objetos eliminados",                      // ES
      "  {0} objets supprimés",                        // FR
      "  {0} nesne silindi" };                         // TR

    public static readonly string[] ZeroLength = {
      "  Found {0} objects of zero length and area",
      "  Найдено {0} объектов нулевой длины и площади",
      "  Trovati {0} oggetti di lunghezza e area zero",
      "  Es wurden {0} Objekte mit einer Länge und Fläche von Null gefunden",
      "  找到 {0} 个长度和面积为零的对象",
      "  Se encontraron {0} objetos de longitud y área cero",  // ES
      "  {0} objets de longueur et de surface nulles trouvés",  // FR
      "  Sıfır uzunluk ve alana sahip {0} nesne bulundu" };  // TR
  }
}