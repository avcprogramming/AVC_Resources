// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

using System.Collections.Generic;

namespace AVC
{
  public static class
  SelectSameL
  {
    public static readonly string[] Select = {
      "Select original object",
      "Выберите исходный объект",
      "Selezionare oggetto originale",
      "Wählen Sie das Quellobjekt aus",
      "选择原始对象",
      "Seleccione el objeto original",                 // ES
      "Sélectionnez l'objet d'origine",                // FR
      "Orijinal nesneyi seçin"};                       // TR

    public static readonly string[] Exists = {
      "Exists",
      "Есть",
      "Esiste",
      "Existiert",
      "存在",
      "Existe",                                        // ES
      "Existe",                                        // FR
      "Var" };                                         // TR

    public static readonly string[] Tested = {
      "Tested objects: {0}",
      "Проверено объектов: {0}",
      "Oggetti controllato: {0}",
      "Getestete Objekte: {0}",
      "测试对象：{0}",
      "Objetos probados: {0}",                         // ES
      "Objets testés : {0}",                           // FR
      "Test edilen nesneler: {0}" };                   // TR

    public static readonly string[] Found = {
      "Found objects: {0}",
      "Найдено объектов: {0}",
      "Gli oggetti trovati: {0}",
      "Gefundene Objekte: {0}",
      "找到的对象：{0}",
      "Objetos encontrados: {0}",                      // ES
      "Objets trouvés : {0}",                          // FR
      "Bulunan nesneler: {0}" };                       // TR

    public static readonly string[] NeedProp = {
      "First, set at least one property for objects of type {0}",
      "Сначала задайте хотя бы одно искомое свойство для объектов типа {0}",
      "Si prega di specificare almeno una proprietà desiderata per gli oggetti di tipo {0}",
      "Legen Sie zunächst mindestens eine Eigenschaft fest, die Sie für Objekte suchen {0}",
      "首先，为 {0} 类型的对象设置至少一个属性",
      "Primero, establezca al menos una propiedad para objetos del tipo {0}",  // ES
      "Tout d'abord, définissez au moins une propriété pour les objets de type {0}",  // FR
      "İlk olarak, {0} türündeki nesneler için en az bir özellik ayarlayın" };  // TR

    public static readonly string[] NoChecked = {
      "There are no checked properties. Search canceled.",
      "Ни одно свойство не отмечено. Поиск отменен.",
      "No spiccate proprietà. Ricerca annullato.",
      "Keine Eigenschaft ist markiert. Suche abgebrochen",
      "没有选中的属性。 搜索已取消。",
      "No hay propiedades marcadas. Búsqueda cancelada.",  // ES
      "Aucune propriété cochée. Recherche annulée.",  // FR
      "İşaretli özellik yok. Arama iptal edildi." };  // TR


    //=================================== Setting Dialog ====================================================

    public static readonly string[] HideText = {
      "Hide unchecked properties",
      "Скрыть неотмеченные свойства",
      "Nascondere proprietà non controllati",
      "Nicht aktivierte Eigenschaften ausblenden",
      "隐藏未选中的属性",
      "Ocultar propiedades no marcadas",               // ES
      "Masquer les propriétés non cochées",            // FR
      "İşaretlenmemiş özellikleri gizle" };            // TR

    public static readonly string[] InvertText = {
      "Invert Visibility",
      "Инвертировать видимость",
      "Inverti visibilità",
      "Sichtbarkeit umkehren",
      "反转可见性",
      "Invertir visibilidad",                          // ES
      "Inverser la visibilité",                        // FR
      "Görünürlüğü tersine çevir" };                   // TR

    public static readonly string[] InvertTip = {
      "Isolate suitable objects along with those that were previously hidden.",
      "Изолировать подходящие объекты вместе с теми, что были скрыты ранее.",
      "Isolare gli oggetti adatti insieme a quelli precedentemente nascosti.",
      "Isolieren Sie geeignete Objekte zusammen mit denen, die zuvor ausgeblendet wurden.",
      "将合适的对象与之前隐藏的对象隔离开来。",
      "Aislar objetos adecuados junto con los que estaban ocultos anteriormente.",  // ES
      "Isoler les objets appropriés avec ceux qui étaient précédemment masqués.",  // FR
      "Uygun nesneleri daha önce gizlenmiş olanlarla birlikte izole edin." };  // TR

    public static readonly string[] SelectTip = {
      "Find and select suitable objects",
      "Найти и выбрать подходящие объекты",
      "Trova e seleziona gli oggetti adatti",
      "Passende Objekte finden und auswählen",
      "查找并选择合适的对象",
      "Buscar y seleccionar objetos adecuados",        // ES
      "Trouver et sélectionner les objets appropriés", // FR
      "Uygun nesneleri bulun ve seçin" };              // TR

    public static readonly string[] ShowText = {
      "Show all properties",
      "Показать все свойства",
      "Mostra tutte le proprietà",
      "Alle Eigenschaften anzeigen",
      "显示所有属性",
      "Mostrar todas las propiedades",                 // ES
      "Afficher toutes les propriétés",                // FR
      "Tüm özellikleri göster" };                      // TR

    public static readonly string[] AllTip = {
      "Check\\uncheck all properties",
      "Отметить\\снять отметку всех свойств",
      "Selezionare\\deselezionare tutte le proprietà",
      "Aktivieren\\deaktivieren Sie alle Eigenschaften",
      "选中\\取消选中所有属性",
      "Marcar\\desmarcar todas las propiedades",       // ES
      "Cocher\\décocher toutes les propriétés",        // FR
      "Tüm özellikleri işaretle\\işareti kaldır" };   // TR

    public static readonly string[] InViewText = {
      "Search in viewport",
      "Искать на текущем виде",
      "Cerca nella viewport corrente",
      "Suche im Ansichtsfenster",
      "在视口中搜索",
      "Buscar en la ventana gráfica",                  // ES
      "Rechercher dans la fenêtre",                    // FR
      "Görünüm penceresinde ara" };                    // TR

    public static readonly string[] InViewTip = {
      "Select only objects currently visible in the viewport.",
      "Выбирать только объекты видимые сейчас во вьюпорте.",
      "Seleziona solo gli oggetti attualmente visibili nel viewport.",
      "Wählen Sie nur Objekte aus, die derzeit im Ansichtsfenster sichtbar sind.",
      "仅选择当前在视口中可见的对象。",
      "Seleccionar solo objetos actualmente visibles en la ventana gráfica.",  // ES
      "Sélectionner uniquement les objets actuellement visibles dans la fenêtre.",  // FR
      "Yalnızca görünüm penceresinde görünen nesneleri seçin." };  // TR

    public static readonly string[] ZoomObjText = {
      "Zoom model",
      "Зумировать модель",
      "Zoom",
      "Zoom-Modell",
      "缩放模型",
      "Ampliar modelo",                                // ES
      "Zoomer le modèle",                              // FR
      "Modeli yakınlaştır" };                          // TR

    public static readonly string[] ZoomObjTip = {
      "Zoom model to selected objects",
      "Показать найденные объекты во весь экран",
      "Mostra gli oggetti trovati a schermo intero",
      "Gefundene Objekte im Vollbildmodus anzeigen",
      "全屏显示找到的对象",
      "Ampliar modelo a los objetos seleccionados",    // ES
      "Zoomer le modèle sur les objets sélectionnés",  // FR
      "Modeli seçili nesnelere yakınlaştır" };         // TR

    public static readonly string[] HeaderText = {
      "Check the properties of the current object what to look for",
      "Отметьте свойства выбранного объекта, которые нужно искать",
      "Segnare le proprietà che dovranno cercare",
      "Überprüfen Sie die Eigenschaften des aktuellen Objekts, wonach gesucht werden soll",
      "检查当前对象的属性要查找的内容",
      "Marque las propiedades del objeto actual que desea buscar",  // ES
      "Cochez les propriétés de l'objet actuel à rechercher",  // FR
      "Aranacak geçerli nesnenin özelliklerini işaretleyin" };  // TR


    // ======================= Перевод на русский свойств, которых нет в палитре ============================

    public static readonly SortedList<string, string> PropNamesRu = new()
    {
      { "AlignItems", "Выравнивать элементы" },
      { "Associative", "Ассоциативный" },
      { "AlignmentPoint", "Точка привязки" },
      { "Area", "Площадь" },
      { "ActualHeight", "Актуальная высота" },
      { "ActualWidth", "Актуальная ширина" },
      { "Angle", "Угол" },
      { "AngleBetweenItems", "Угол между" },
      { "ArrowSize", "Размер стрелки" },
      { "Attachment", "Выравнивание" },
      { "AxesAngle", "Угол осей" },
      { "BackgroundFill", "Скрытие фона" },
      { "BackgroundColor", "Цвет фона" },
      { "BaseNormal", "Нормаль базы" },
      { "BasePoint", "Базовая точка" },
      { "BlockColor", "Блок: Цвет" },
      { "BlockConnectionType", "Блок: Соединение" },
      { "BlockRotetion", "Блок: Поворот" },
      { "BlockScaling", "Масштабирование" },
      { "BlockTransform", "Матрица трансформации" },
      { "BlockUnit", "Единицы блока" },
      { "BlockName", "В блоке" },
      { "BlockScale", "Блок: Масштаб" },
      { "Bounds", "Рамки" },
      { "BreakEnabled", "Разрешено рвать" },
      { "BreakFlowDirection", "Направление разрыва" },
      { "Center", "Центр" },
      { "Circumference", "Длина окружности" },
      { "Color", "Цвет" },
      { "ColumnCount", "Число столбцов" },
      { "ColumnSpacing", "Шаг столбцов" },
      { "ColumnWidth", "Ширина столбца" },
      { "ColumnGutterWidth", "Ширина зазора столбца" },
      { "Comments", "Информация" },
      { "Component Instance", "Компонент: Экземпляр" },
      { "Component Description", "Компонент: Описание" },
      { "Component Name", "Компонент: Имя" },
      { "Contents", "Содержимое" },
      { "ContentType", "Тип контента" },
      { "ContentsRTF", "Содержимое в RTF" },
      { "Closed", "Замкнутый" },
      { "Degree", "Порядок" },
      { "Delta", "Дельта" },
      { "Diameter", "Диаметр" },
      { "DimensionStyleName", "Размерный стиль" },
      { "Direction", "Направление" },
      { "DoglegLength", "Длина выносной линии" },
      { "Dynamic name", "Динамическое имя" },
      { "Elevation", "Уровень" },
      { "EnableAnnotationScale", "Аннотативный" },
      { "EnableDogleg", "Выносная линия" },
      { "EnableFrameText", "Рамка текста" },
      { "EnableLanding", "Горизонтальная полка" },
      { "EndAngle", "Угол конца" },
      { "EndFitTangent", "Касательная конца" },
      { "EndOffset", "Конечное смещение" },
      { "EndPoint", "Конец" },
      { "Explodable", "Взрываемый" },
      { "ExtendLeaderToText", "Удлинять по тексту" },
      { "FillAngle", "Угол заполнения" },
      { "FitTolerance", "Допуск" },
      { "FlowDirection", "Направление текста" },
      { "GradientAngle", "Градиент Угол" },
      { "GradientName", "Градиент Имя" },
      { "GradientOneColorMode", "Градиент Одноцветный" },
      { "GradientShift", "Градиент Сдвиг" },
      { "GradientType", "Градиент Способ" },
      { "HasAttributeDefinitions", "Имеет атрибуты" },
      { "HasBulges", "Есть дуги" },
      { "HasPreviewIcon", "Имеет иконку" },
      { "HatchObjectType", "Тип заливки" },
      { "HatchStyle", "Стиль островков" },
      { "Height", "Высота" },
      { "Hyperlinks", "Ссылка" },
      { "IsAnonymous", "Анонимный" },
      { "IsDependent", "Зависимый" },
      { "IsDynamicBlock", "Динамический" },
      { "IsFromOverlayReference", "Из перегруженной Ссылки" },
      { "IsFromExternalReference", "Из внешней ссылки" },
      { "IsGradient", "Градиент" },
      { "IsHatch", "Штриховка" },
      { "IsSolidFill", "Заливка" },
      { "IsMirroredInX", "Справа налево" },
      { "IsMirroredInY", "Перевернутый" },
      { "IsOnlyLines", "Только линии" },
      { "IsPlanar", "Плоский" },
      { "IsResolved", "Решенный" },
      { "ItemCount", "Число элементов" },
      { "ItemSpacing", "Шаг элементов" },
      { "Justify", "Выравнивание" },
      { "LandingGap", "Зазор полки" },
      { "Layer", "Слой" },
      { "LeaderCount", "Число выносок" },
      { "LeaderLineColor", "Цвет выноски" },
      { "LeaderLineCount", "Число линий выносок" },
      { "LeaderLineType", "Тип выноски" },
      { "LeaderLineWeight", "Вес линий выноски" },
      { "Length", "Длина" },
      { "LevelCount", "Число уровней" },
      { "LevelSpacing", "Шаг уровней" },
      { "Linetype", "Тип линий" },
      { "LinetypeScale", "Масштаб линий" },
      { "LineSpaceDistance", "Межстрочный интервал" },
      { "LineSpacingFactor", "Межстрочный коэффициент" },
      { "LineSpacingStyle", "Межстрочный стиль" },
      { "LineWeight", "Вес линий" },
      { "Location", "Положение" },
      { "Material", "Материал" },
      { "Measurement", "Измерено" },
      { "Method", "Метод" },
      { "MinorAxis", "Ось малая" },
      { "MinorRadius", "Радиус малый" },
      { "MajorAxis", "Ось большая" },
      { "MajorRadius", "Радиус большой" },
      { "Name", "Имя" },
      { "Normal", "Нормаль" },
      { "NumberOfHatchLines", "Число линий" },
      { "NumberOfLoops", "Число петель" },
      { "NumberOfVertices", "Число вертексов" },
      { "NumChanges", "Изменений" },
      { "NumColumns", "Число колонок" },
      { "NumControlPoints", "Число точек управления" },
      { "NumFitPoints", "Число определяющих точек" },
      { "NumRows", "Число строк" },
      { "Oblique", "Наклон" },
      { "Origin", "Начало" },
      { "PlotStyleName", "Стиль печати" },
      { "Position", "Положение" },
      { "Prefix", "Префикс" },
      { "Radius", "Радиус" },
      { "RadiusRatio", "Соотношение радиусов" },
      { "PathName", "Путь" },
      { "PatternAngle", "Образец Угол" },
      { "PatternDouble", "Образец Двойной" },
      { "PatternName", "Образец Имя" },
      { "PatternScale", "Образец Масштаб" },
      { "PatternSpace", "Образец Интервал" },
      { "PatternType", "Образец Тип" },
      { "RecordHistory", "Запоминать историю" },
      { "RotateItems", "Поворачивать элементы" },
      { "Rotation", "Поворот" },
      { "RowCount", "Число строк" },
      { "RowElevation", "Приращение строк" },
      { "RowSpacing", "Шаг строк" },
      { "Scale", "Масштаб" },
      { "ScaleFactors", "Масштаб" },
      { "ShowBorders", "Рамка текста" },
      { "ShowHistory", "Показывать историю" },
      { "StartAngle", "Угол начала" },
      { "StartFitTangent", "Касательная начала" },
      { "StartOffset", "Конечное смещение" },
      { "StartPoint", "Начало" },
      { "Style", "Стиль" },
      { "Suffix", "Суффикс" },
      { "Text", "Текст" },
      { "TextAlignmentType", "Выравнивание текста" },
      { "TextAngleType", "Текста под угол" },
      { "TextAttachmentDirection", "Тип присоединения" },
      { "TextAttachmentType", "Присоединение слева" },
      { "TextColor", "Цвет текста" },
      { "TextLocation", "Положение текста" },
      { "TextHeight", "Высота текста" },
      { "TextStyle", "Стиль текста" },
      { "TextStyleName", "Стиль" },
      { "TableStyleName", "Стиль таблицы" },
      { "Thickness", "Толщина" },
      { "TotalAngle", "Угол полный" },
      { "Transparency", "Прозрачность" },
      { "Type", "Способ" },
      { "UnitFactor", "Коэффициент единиц" },
      { "Units", "Единицы" },
      { "Visible", "Видимый" },
      { "Volume", "Объем" },
      { "Width", "Ширина" },
      { "WidthFactor", "Коэффициент сжатия" },
      { "XAxisDirection", "Направление X" },
      { "XrefStatus", "Статус внешней ссылки" },
      { "YAxisDirection", "Направление Y" }
    };

  }
}
