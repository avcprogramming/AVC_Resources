// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  BoxFromTableL
  {
    public static readonly string[,] BoxFromTableNames = {
/* 0 */ { CommandL.BoxFromTable[0], CommandL.BoxFromTable[1], CommandL.BoxFromTable[2], CommandL.BoxFromTable[3], CommandL.BoxFromTable[4] },
/* 1 */ { CommandL.BoxFromTable[0], CommandL.BoxFromTable[1], CommandL.BoxFromTable[2], CommandL.BoxFromTable[3], CommandL.BoxFromTable[4] },
        };

    public static readonly string[] BoxToWallProgress = {
      "Detailing",
      "Деталировка",
      "Dettagli",
      "Detaillierung",
      "細節處理"};
    public static readonly string[] RequestForBox = {
      "We request details for the wall {0} from the web server...",
      "Запрашиваем на web-сервере деталировку для стены {0}...",
      "Richiediamo i dettagli per il muro {0} dal server web...",
      "Wir fordern Details für die Wand {0} vom Webserver an...",
      "我們從網頁伺服器請求牆 {0} 的詳細資料..."};
    public static readonly string[] RequestForVector = {
      "We request flat drawings for wall {0} from the web server...",
      "Запрашиваем на web-сервере плоские чертежи для стены {0}...",
      "Richiediamo disegni piatti per il muro {0} dal server web...",
      "Wir fordern flache Zeichnungen für Wand {0} vom Webserver an...",
      "我們從網頁伺服器請求牆 {0} 的平面圖..."};
    public static readonly string[] RequestError = {
      "Error when requesting to the server.\r\n{0}",
      "Ошибка при запросе на сервер.\r\n{0}",
      "Errore durante la richiesta al server.\r\n{0}",
      "Fehler bei der Anfrage an den Server.\r\n{0}",
      "向伺服器請求時發生錯誤。\r\n{0}"};
    public static readonly string[] ZeroBoxDataError = {
      "Received empty parts list for wall {0}",
      "Получен пустой список деталей для стены {0}",
      "Ricevuto elenco delle parti vuoto per il muro {0}",
      "Leere Teileliste für Wand {0} erhalten",
      "收到牆 {0} 的空零件清單"};
    public static readonly string[] BoxDataReceived = {
      "Data received from the server to create {0} parts for wall {1}",
      "С сервера получены данные для создания {0} деталей для стены {1}",
      "Dati ricevuti dal server per creare {0} parti per il muro {1}",
      "Vom Server empfangene Daten zum Erstellen von {0} Teilen für die Wand {1}",
      "從伺服器接收的數據，用於為牆 {1} 建立 {0} 個部件"};
    public static readonly string[] PlanDataReceived = {
      "Data was received from the server to create the drawing {0}",
      "С сервера получены данные для создания чертежа {0}",
      "I dati sono stati ricevuti dal server per creare il disegno {0}",
      "Vom Server wurden Daten zum Erstellen der Zeichnung {0} empfangen.",
      "已從伺服器接收資料以建立繪圖 {0}"};
    public static readonly string[] ZeroSolidListError = {
      "Failed to create one wall {0} - failed to create any parts",
      "Не удалось создать одну стену {0} - не получилось создать ни одной детали",
      "Impossibile creare un muro {0} - impossibile creare nessuna parte",
      "Eine Wand {0} konnte nicht erstellt werden – es konnten keine Teile erstellt werden",
      "無法建立一堵牆 {0} - 無法建立任何部分"};
    public static readonly string[] ZeroPlanError = {
      "Failed to create drawing {0} - failed to create any objects",
      "Не удалось создать чертеж {0} - не получилось создать ни одного объекта",
      "Impossibile creare il disegno {0}: impossibile creare alcun oggetto",
      "Zeichnung {0} konnte nicht erstellt werden – es konnten keine Objekte erstellt werden",
      "未能建立繪圖 {0} - 未能建立任何對象"};
    public static readonly string[] BoxToWallResult = {
      "Managed to create walls {0}",
      "Удалось создать стен {0}",
      "Gestito per creare muri {0}",
      "Es ist mir gelungen, Wände zu erstellen {0}",
      "成功建造了牆壁{0}"};
    public static readonly string[] BoxToVectorResult = {
      "Successful creation of {0} drawings",
      "Удалось создать чертежей {0}",
      "Creazione riuscita di {0} disegni",
      "Erfolgreiche Erstellung von {0} Zeichnungen",
      "成功建立 {0} 個繪圖"};
    public static readonly string[] BoxtToVectorProgress = {
      "Creating Drawings",
      "Создание чертежей",
      "Creazione di disegni",
      "Zeichnungen erstellen",
      "建立繪圖"};
    public static readonly string[] SelectSolidOrBlock = {
      "Choose solid boxes to fit the wall or blocks of ready-made walls.",
      "Выберите солиды-боксы в габарит стены или блоки готовых стен.",
      "Scegli scatole solide da adattare al muro o blocchi di pareti già pronte.",
      "Wählen Sie feste, an die Wand angepasste Kästen oder Blöcke vorgefertigter Wände.",
      "選擇適合牆壁的實心盒子或現成的牆壁塊。"};
    public static readonly string[] LineWeightErr = {
      "Specified non-existent line weight {0}",
      "Задан несуществующий вес линий {0}",
      "Spessore di linea inesistente specificato {0}",
      "Angegebene nicht vorhandene Linienstärke {0}",
      "指定的不存在的線寬 {0}"};
    public static readonly string[] LineTypeErr = {
      "Specified non-existent linetype {0}",
      "Задан несуществующий тип линий {0}",
      "Tipo di linea {0} inesistente specificato",
      "Angegebener nicht vorhandener Linientyp {0}",
      "指定的不存在線型 {0}"};
    public static readonly string[] ColorErr = {
      "Failed to recognize color {0}",
      "Не удалось распознать цвет {0}",
      "Impossibile riconoscere il colore {0}",
      "Farbe {0} konnte nicht erkannt werden",
      "無法辨識顏色{0}"};
    public static readonly string[] PLineConversionErr = {
      "It was not possible to construct a polyline from the given points",
      "Не удалось построить полилинию по заданным точкам",
      "Non è stato possibile costruire una polilinea utilizzando i punti indicati",
      "Es war nicht möglich, aus den angegebenen Punkten eine Polylinie zu konstruieren",
      "無法從給定點構造折線"};
    public static readonly string[] NullPlanError = {
      "Received empty wall plan {0}",
      "Получен пустой план стены {0}",
      "Ricevuta una planimetria vuota {0}",
      "Leeren Wandplan {0} erhalten",
      "收到空牆平面圖 {0}"};
    public static readonly string[] RequestTime = {
      "The request to the server was processed in {0}s",
      "Запрос к серверу обработан за {0}c",
      "La richiesta al server è stata elaborata in {0}s",
      "Die Anfrage an den Server wurde in {0}s verarbeitet",
      "對伺服器的請求已在 {0} 秒內處理完畢"};
    public static readonly string[] ZeroSizeSolidError = {
      "An attempt to create a size zero solid. Let's skip it.",
      "Попытка создать солид нулевого размера. Пропускаем.",
      "Un tentativo di creare un solido di dimensione zero. Saltiamolo.",
      "Ein Versuch, einen Körper der Größe Null zu erstellen. Lass es uns überspringen.",
      "嘗試建立零尺寸實體。讓我們跳過它。"};
  }
}
