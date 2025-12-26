// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{
  /// <summary>
  /// Локализация диалога выбора таблицы для вставки данных, извлеченных из чертежа
  /// </summary>
  public static class
  TableSelectL
  {
    public static readonly string[] Part1 = {
      "Select the table for data insertion",
      "Выберите таблицу для вставки данных",
      "Seleziona una tabella per inserire i dati",
      "Wählen Sie die Tabelle zum Einfügen von Daten aus",
      "选择要插入数据的表",
      "Seleccione la tabla para la inserción de datos",
      "Sélectionnez le tableau pour l'insertion de données",
      "Veri ekleme için tabloyu seçin"};

    public static readonly string[] FindGroup = {
      "Find",
      "Найти",
      "Trovare",
      "Finden",
      "寻找",
      "Encontrar",
      "Trouver",
      "Bul"};

    public static readonly string[] FindHint = {
      "A table entitled '{0}' was found in the drawing '{1}'. " +
        "You can use it to insert new data.",
      "В чертеже '{1}' найдена таблица с заголовком '{0}'. " +
        "Можно использовать ее для вставки новых данных.",
      "Trovato nel disegno '{1}' una tabella con il titolo '{0}'. " +
        "Puoi usarlo per inserire nuovi dati.",
      "In der Zeichnung '{1}' wurde eine Tabelle mit dem Titel '{0}' gefunden. " +
        "Sie können es verwenden, um neue Daten einzufügen.",
      "在绘图'{1}'中找到名为'{0}'的表格。 " +
        "您可以使用它来插入新数据。",
      "Se encontró una tabla titulada '{0}' en el dibujo '{1}'. " +
        "Puede usarla para insertar nuevos datos.",
      "Un tableau intitulé '{0}' a été trouvé dans le dessin '{1}'. " +
        "Vous pouvez l'utiliser pour insérer de nouvelles données.",
      "'{1}' çiziminde '{0}' başlıklı bir tablo bulundu. " +
        "Yeni veri eklemek için kullanabilirsiniz."};

    public static readonly string[] FindText = {
      "Use the table found",
      "Использовать найденную таблицу",
      "Usa la tabella trovata",
      "Verwenden Sie die gefundene Tabelle.",
      "使用找到的表。",
      "Usar la tabla encontrada",
      "Utiliser le tableau trouvé",
      "Bulunan tabloyu kullan"};

    public static readonly string[] FindTip = {
      "Click to use found table",
      "Кликните для использования найденной таблицы",
      "Fare clic per utilizzare la tabella trovata",
      "Klicken Sie hier, um die gefundene Tabelle zu verwenden",
      "单击以使用找到的表",
      "Haga clic para usar la tabla encontrada",
      "Cliquez pour utiliser le tableau trouvé",
      "Bulunan tabloyu kullanmak için tıklayın"};

    public static readonly string[] ChoiceGroup = {
      "Choice",
      "Выбрать",
      "Scegliere",
      "Auswahl",
      "选择",
      "Elección",
      "Choix",
      "Seçim"};

    public static readonly string[] ChoiceHint = {
      "Choice one table from the available in drawing using list. " +
        "You can choice a table from the template - then a new layout will be inserted.",
      "Выбрать таблицу из имеющихся. " +
        "Можно выбрать таблицу из шаблона - тогда будет вставлен новый лист.",
      "Seleziona una tabella tra quelle disponibili. " +
        "Puoi selezionare una tabella dal modello, quindi verrà inserito un nuovo foglio.",
      "Wählen Sie eine Tabelle aus der in der Zeichnung verfügbaren Liste aus. " +
        "Sie können eine Tabelle aus der Vorlage auswählen - dann wird ein neues Layout eingefügt.",
      "从绘图中可用的列表中选择一个表格。 " +
        "您可以从模板中选择一个表格 - 然后将插入一个新的布局。",
      "Elija una tabla de las disponibles en el dibujo usando la lista. " +
        "Puede elegir una tabla de la plantilla, entonces se insertará un nuevo diseño.",
      "Choisissez un tableau parmi ceux disponibles dans le dessin en utilisant la liste. " +
        "Vous pouvez choisir un tableau du modèle - alors une nouvelle mise en page sera insérée.",
      "Listeyi kullanarak çizimdeki mevcut tablolardan birini seçin. " +
        "Şablondan bir tablo seçebilirsiniz - o zaman yeni bir düzen eklenecektir."};

    public static readonly string[] ChoiceTip = {
      "Select item from list",
      "Выберите имеющуюся таблицу из списка",
      "Seleziona una tabella esistente dall'elenco",
      "Wählen Sie eine vorhandene Tabelle aus der Liste aus",
      "从列表中选择一个现有表",
      "Seleccione un elemento de la lista",
      "Sélectionnez un élément de la liste",
      "Listeden öğe seçin"};

    public static readonly string[] CreateGroup = {
      "Create",
      "Создать",
      "Creare un",
      "Schaffen",
      "创造",
      "Crear",
      "Créer",
      "Oluştur"};

    public static readonly string[] CreateHint = {
      "Create a new table in the Model or on the layout. " +
        "You can make a copy of the layout.You can insert a layout from the template.",
      "Создать новую таблицу в Модели или на листе. " +
        "Вы можете создать копию листа. Вы можете вставить новый лист из шаблона.",
      "Crea una nuova tabella in Modello o foglio. " +
        "Puoi creare una copia del foglio. Puoi inserire un nuovo foglio dal modello.",
      "Erstellen Sie eine neue Tabelle im Modell oder im Layout. " +
        "Sie können eine Kopie des Layouts erstellen. Sie können ein Layout aus der Vorlage einfügen.",
      "在模型或布局中创建一个新表。您可以复制布局。" +
        "您可以从模板中插入布局。",
      "Cree una nueva tabla en el Modelo o en el diseño. " +
        "Puede hacer una copia del diseño. Puede insertar un diseño desde la plantilla.",
      "Créez un nouveau tableau dans le Modèle ou sur la mise en page. " +
        "Vous pouvez faire une copie de la mise en page. Vous pouvez insérer une mise en page à partir du modèle.",
      "Model'de veya düzende yeni bir tablo oluşturun. " +
        "Düzenin bir kopyasını yapabilirsiniz. Şablondan bir düzen ekleyebilirsiniz."};

    public static readonly string[] CreateTip = {
      "Click to create new table on current layout",
      "Кликните для создания таблицы на текущем листе",
      "Fare clic per creare una nuova tabella nel layout corrente",
      "Klicken Sie hier, um eine neue Tabelle im aktuellen Layout zu erstellen",
      "单击以在当前布局上创建新表格",
      "Haga clic para crear una nueva tabla en el diseño actual",
      "Cliquez pour créer un nouveau tableau dans la mise en page actuelle",
      "Geçerli düzende yeni tablo oluşturmak için tıklayın"};

    public static readonly string[] PickHint = {
      "Specify one of the existing tables. Select Model or layout and then the program asks you to pick the table.",
      "Указать одну из существующих таблиц. Выберите Модель или лист, а затем программа запросит вас выбрать таблицу.",
      "Indica una delle tabelle esistenti. Seleziona Modello o Foglio, quindi il programma ti chiederà di selezionare una tabella.",
      "Geben Sie eine der vorhandenen Tabellen an. Wählen Sie Modell oder Layout und dann fordert Sie das Programm auf, den Tisch auszuwählen.",
      "指定一个现有表。 选择模型或布局，然后程序会要求您选择表格。",
      "Especifique una de las tablas existentes. Seleccione Modelo o diseño y luego el programa le pedirá que elija la tabla.",
      "Spécifiez l'un des tableaux existants. Sélectionnez Modèle ou mise en page, puis le programme vous demandera de choisir le tableau.",
      "Mevcut tablolardan birini belirtin. Model veya düzen seçin ve ardından program tablonuzu seçmenizi isteyecektir."};

    public static readonly string[] PickTip = {
      "Click to select table on current layout",
      "Кликните для указания таблицы на текущем листе (если есть)",
      "Fare clic per indicare la tabella sul foglio corrente (se presente)",
      "Klicken Sie hier, um die Tabelle auf dem aktuellen Blatt anzuzeigen (falls vorhanden).",
      "单击以指示当前工作表上的表格（如果有）",
      "Haga clic para seleccionar la tabla en el diseño actual",
      "Cliquez pour sélectionner le tableau dans la mise en page actuelle",
      "Geçerli düzende tabloyu seçmek için tıklayın"};

    public static readonly string[] FromTemplate = {
      "From template ",
      "Из шаблона ",
      "Dal modello ",
      "Von Vorlage ",
      "从模板 ",
      "Desde plantilla ",
      "Du modèle ",
      "Şablondan "};

    public static readonly string[] CopyOf = {
      "Copy of ",
      "Копия ",
      "Copia ",
      "Kopie von ",
      "备份 ",
      "Copia de ",
      "Copie de ",
      "Kopyası "};

  }
}