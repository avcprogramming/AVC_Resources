// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/


// Ignore Spelling: Subentity

namespace AVC
{
  /// <summary>
  /// Локализация методов для работы с солидами
  /// </summary>
  public static class
  SolidL
  {
    public static readonly string[] SelectSolids = {
      "  Select solids ",
      "  Выберите солиды ",
      "  Selezionare solidi ",
      "  Volumenkörper auswählen",
      "  选择实体" };
    public static readonly string[] SelectFace = {
      "\nSelect solid face",
      "\nВыберите поверхность солида",
      "\nSeleziona la superficie solida",
      "\nWählen Sie eine Volumenkörper Oberfläche",
      "\n选择三维实体面" };
    public static readonly string[] SelectEdge = {
      "\nSelect solid edge",
      "\nВыберите ребро солида",
      "\nSelezionare spigoli solido",
      "\nWählen Sie eine Volumenkörper Rippe",
      "\n选择三维实体边" };
    public static readonly string[] SelectEdgeErr = {
      "Can't select edge.",
      "Не получилось выбрать ребро.",
      "Impossibile selezionare spigolo.",
      "Kante konnte nicht ausgewählt werden.",
      "无法选择边缘。"};
    public static readonly string[] NoSolid = {
      "Can't get solid.",
      "Нет доступа к солиду.",
      "Non è possibile ottenere solidi.",
      "Kein Zugang zu Volumenkörper.",
      "无法获得三维实体。" };
    public static readonly string[] NeedSolid = {
      "  Need 3d solids",
      "  Программе нужны твердые тела (3d solid)",
      "  Il programma richiede solidi (3d solid)",
      "  Das Programm benötigt Volumenkörper (3d solid)",
      "  需要固体 (3d solid)"};
    public static readonly string[] NeedSolidAndNot = {
      "Need solid. And you have selected: {0}",
      "Нужен солид. А вы вместо этого выбрали: {0}",
      "Hai bisogno di solido. E hai selezionato: {0}",
      "Brauchen Volumenkörper. Und Sie haben ausgewählt: {0}",
      "需要固体。 您已选择：{0}" };
    public static readonly string[] SolidHistory ={
      "Solid history activated. Work its faces is not possible.",
      "У солида включена история. Работа с его поверхностями не возможна.",
      "Cronologia solidi attiva. L’operazione sulle facce non è possibile.",
      "Die Volumenkörper Geschichte ist enthalten. Arbeiten mit seinen Oberflächen sind nicht möglich.",
      "三维实体的历史记录已激活。 无法使用三维实体的面。"};
    public static readonly string[] NoFaceSelected = {
      "None of selected face.",
      "Нет выбранных поверхностей.",
      "Nessuna faccia selezionata.",
      "Keine Oberflächen ausgewählt.",
      "没有选定的面。" };
    public static readonly string[] NeedFace ={
      "It was necessary to click on the surface of the solid. And you have selected: {0}",
      "Надо было кликать по поверхности солида, а выбран: {0}",
      "Era necessario cliccare sulla superficie del solido. Ed è stato selezionato: {0}",
      "Es war notwendig, auf die Oberfläche des Volumenkörper zu klicken und auszuwählen: {0}",
      "请点击三维实体的面。 已选择：{0}"};
    public static readonly string[] NoFace = {
      "Can't select face.",
      "Не получилось выбрать поверхность.",
      "Non è possibile selezionare la faccia.",
      "Oberfläche konnte nicht ausgewählt werden.",
      "无法选择面。" };
    public static readonly string[] NoEdge = {
      "None of selected edge.",
      "Нет выбранных ребер.",
      "Nessuno spigolo selezionato.",
      "Keine Rippen ausgewählt.",
      "没有选定的边。" };
    public static readonly string[] NeedEdge ={
      "Necessary to click on the edge of the solid. And you have selected: {0}",
      "Надо было кликать по ребру солида, а выбран: {0}",
      "Necessario selezionare lo spigolo del solido. È stato selezionato: {0}",
      "Es war notwendig, auf die Kante des Volumenkörpers zu klicken und Folgendes auszuwählen: {0}",
      "需要单击三维实体的边。 已选择：{0}"};
    public static readonly string[] PairErr ={
      "Not found a pair of identical surfaces",
      "Не найдено ни одной пары одинаковых поверхностей",
      "Non trovato una coppia di superfici identiche",
      "Keine passenden Paare gefunden",
      "未找到一对相同的面"};
    public static readonly string[] IsNotSweepErr ={
      "There are no curved faces. The solid cannot be measured as a sweep.",
      "Нет изогнутых поверхностей. Солид нельзя измерить как развертку.",
      "Non ci sono facce curve. Il solido non può essere misurato come uno sweep.",
      "Es gibt keine gekrümmten Flächen. Der Körper kann nicht als Sweep vermessen werden.",
      "该实体没有曲面。因此，不能用扫描的方式来测量该实体。"};
    public static readonly string[] Unsupported ={
      "Unsupported solid type",
      "Не поддерживаемый вид солида",
      "Questo tipo di solido non è supportato",
      "Nicht unterstützter Körpervolumen-Typ",
      "不支持的实体类型"};
    public static readonly string[] ContinueQuery ={
      "\r\nDo you want to try to continue?",
      "\r\nПопробуем продолжить обработку?",
      "\r\nProvare a continuare?",
      "\r\nVersuchen Sie, die Verarbeitung fortzusetzen?",
      "\r\n你想尝试继续处理吗？"};
    public static readonly string[] SolidNotValid ={
      "\r\nOne of the solids is not valid. This could be the reason for the failure. It may be import error. Recommended remodeling.",
      "\r\nОдин из солидов содержит ошибки моделирования. Это могло быть причиной сбоя. Скорее всего тело импортировано из другой программы с ошибками. Рекомендуется моделировать тело заново.",
      "\r\nUno dei solidi contiene errori di modellazione. Questo potrebbe essere il motivo del fallimento. Potrebbe essere un errore di importazione. Si consiglia di rimodellare il solido.",
      "\r\nEiner der Volumenkörper enthält Modellierungsfehler. Dies könnte der Grund für den Fehler sein. Es kann ein Importfehler sein. Empfohlener Umbau.",
      "\r\n其中一个三维实体包含建模错误。 这可能是失败的原因。 这可能是导入错误。 建议重塑三维实体"};
    public static readonly string[] BrepErr = {
      "Can't get BRep from solid.",
      "Не удалось снять BRep с солида.",
      "Impossibile ottenere BRep da solido.",
      "BRep kann nicht von Körpervolumen erhalten.",
      "无法从三维实体中获取 BRep。" };
    public static readonly string[] FaceErr = {
      "Can't get Faces from solid.",
      "Не удалось получить грани солида.",
      "Impossibile ottenere i volti dal solido.",
      "Ich kann keine Gesichter von Körpervolumen bekommen.",
      "无法从三维实体中获取面。"};
    public static readonly string[] SweepErr = {
      "Measurement Sweep failed. ",
      "Обмер развертки не удался. ",
      "Scansione di misura failed. ",
      "Messablauf fehlgeschlagen.",
      "测量扫描失败。" };
    public static string[] EdgeCurveErr = {
      "Can't get Curve from Edge.",
      "Не удалось получить кривую ребра.",
      "Non può ottenere la Curva dal Bordo.",
      "Die Kurve kann nicht von Edge abgerufen werden.",
      "获取边缘曲线失败。" };
    public static string[] EdgeVertexErr = {
      "Can't get Edges from Vertex.",
      "Не удалось получить ребра вертекса.",
      "Non può ottenere Bordi da Vertice.",
      "Kanten können nicht von Vertex abgerufen werden.",
      "无法获取顶点边。" };
    public static readonly string[] VertexErr ={
      "Can't get Vertexes from Loop.",
      "Не удалось получить вершины на петле.",
      "Non può ottenere Vertici da Anello.",
      "Schleifenscheitel konnten nicht abgerufen werden.",
      "无法从循环中获取顶点。"};
    public static readonly string[] EdgeLoopErr ={
      "Can't get Edges from Loop.",
      "Не удалось получить ребра петли.",
      "Non può ottenere Bordi da Anello.",
      "Schleifenränder konnten nicht abgerufen werden.",
      "无法从循环中获取边。"};
    public static readonly string[] LoopErr = {
      "Can't get Loops from Edge. {0}",
      "Не удалось получить петли ребра. {0}",
      "Impossibile ottenere Anello da Bordi. {0}",
      "Konnte keine Rippchen bekommen. {0}",
      "无法从 Edge 获取循环。 {0}"};
    public static readonly string[] EdgeLenErr = {
      "The length of the edge could not be calculated. {0}",
      "Не удалось вычислить длину ребра. {0}",
      "La lunghezza del bordo non può essere calcolata. {0}",
      "Kantenlänge konnte nicht berechnet werden. {0}",
      "无法计算边的长度。 {0}"};
    public static readonly string[] EdgeLinearErr = {
      "The edge must be linear.",
      "Ребро должно быть линейным",
      "Il bordo deve essere lineare.",
      "Die Kante muss linear sein.",
      "边缘必须是线性的。"};
    public static readonly string[] CantCut = {
      "Could not cut solid by miter",
      "Не удалось разрезать солид под ус",
      "Impossibile tagliare il solido",
      "Teil konnte nicht mit der Gehrung geschnitten werden",
      "无法切割三维实体"};
    public static readonly string[] SelectionWrong = {
      "\nYour selection is wrong. Was selected '{0}' and was necessary '{1}'.\n",
      "\nВыбрано не то: '{0}', а надо было выбрать '{1}'.\n",
      "\nSelezione errata. È stato selezionato '{0}' ed era necessario '{1}'.\n",
      "\nIhre Auswahl ist falsch. Wurde '{0}' ausgewählt und war '{1}' notwendig.\n",
      "\n选择错误。 已选择“{0}”需要“{1}”。\n"};
    public static readonly string[] SetSubentityPropertyErr = {
      "Error in assigning solid surface properties: {0}",
      "Ошибка назначения свойства поверхности солида: {0}",
      "Errore nell'assegnazione delle proprietà della superficie solida: {0}",
      "Fehler beim Zuweisen von Solid-Surface-Eigenschaften:Fehler beim Zuweisen von Solid-Surface-Eigenschaften: {0}",
      "指定实体表面属性时出错：{0}" };
    public static readonly string[] MaterialErr = {
      "Failed to assign material to solid {0}",
      "Не удалось присвоить солиду материал {0}",
      "Impossibile assegnare il materiale al solido {0}",
      "Das Material konnte dem Volumenkörper {0} nicht zugewiesen werden.",
      "无法将材料分配给实体 {0}" };
    public static readonly string[] SeparateErr = {
      "Failed to split multisolids into separate bodies. Error: {0}",
      "Не удалось разделить мультисолид на отдельные тела. Ошибка: {0}",
      "Impossibile dividere i multisolidi in corpi separati. Errore: {0}",
      "Multisolids konnten nicht in separate Körper aufgeteilt werden. Fehler: {0}",
      "无法将多实体分割成单独的部分。错误：{0}" };
    public static readonly string[] SubErr = {
      "Failed to perform subtraction. Error: {0}",
      "Не удалось выполнить вычитание. Ошибка: {0}",
      "Impossibile eseguire la sottrazione. Errore: {0}",
      "Subtraktion konnte nicht durchgeführt werden. Fehler: {0}",
      "无法执行减法。错误：{0}"    };
    public static readonly string[] IntErr = {
      "Failed to perform intersection. Error: {0}",
      "Не удалось выполнить пересечение. Ошибка: {0}",
      "Impossibile eseguire l'intersezione. Errore: {0}",
      "Schnitt konnte nicht durchgeführt werden. Fehler: {0}",
      "无法执行交集。错误：{0}"    };
    public static readonly string[] UnionErr = {
      "Failed to perform union. Error: {0}",
      "Не удалось выполнить объединение. Ошибка: {0}",
      "Impossibile eseguire l'unione. Errore: {0}",
      "Vereinigung konnte nicht durchgeführt werden. Fehler: {0}",
      "无法执行联合操作。错误：{0}"    };
    public static readonly string[] OffsetBodyErr = {
      "Failed to expand solid. Error: {0}",
      "Не удалось расширить солид. Ошибка: {0}",
      "Impossibile espandere il solido. Errore: {0}",
      "Die Volumenkörpererweiterung ist fehlgeschlagen. Fehler: {0}",
      "未能扩展实体。。错误：{0}"    };
    public static readonly string[] EmptySolidErr = {
      "Failed to check for an empty object. {0}",
      "Сбой при проверке на объект-пустышку. {0}",
      "Errore durante il controllo di un solido vuoto. {0}",
      "Fehler bei der Überprüfung auf einen leeren Volumenkörper. {0}",
      "检查空实体失败。错误：{0}"  };
    public static readonly string[] SizeErr = {
      "Failed to calculate the size of the object. {0}",
      "Сбой при вычислении размера объекта. {0}",
      "Errore durante il calcolo delle dimensioni dell'oggetto. {0}",
      "Fehler bei der Berechnung der Objektgröße. {0}",
      "计算对象大小失败。错误：{0}" };
    public static readonly string[] CheckInterferenceErr = {
      "Error checking solid intersections. {0}",
      "Сбой при проверке пересечений солидов. {0}",
      "Errore durante il controllo delle intersezioni continue. {0}",
      "Fehler beim Prüfen von festen Schnittpunkten. {0}",
      "检查实体交叉点时出错。错误：{0}" };
  }
}
