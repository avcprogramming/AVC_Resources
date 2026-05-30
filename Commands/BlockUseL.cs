// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  BlockUseL
  {
    public static readonly string[] DefAssemblyMask = {
      "Asm*",
      "СБ*",
      "Assemblaggio *",
      "Baugruppe *",
      "集会*",
      "Asamblea *",
      "Assemblage *",
      "Montaj#*"};
    public static readonly string[] DefProductMask = {
      "Prd*",
      "Изделие*",
      "Prodotto *",
      "Produkt *",
      "产品*",
      "Producto *",
      "Produit *",
      "Ürün *"};

    public static readonly string[] DefAssemblyExcludeMask = {
      ".*;!Format*;!Label*;Drawing Title;Assembly Title",
      ".*;!Высотная отметка*;!Рамка чертежа*;Штамп*;Заголовок*;Точка*",
      ".*;!Formato*;!Etichetta*;Titolo disegno;Titolo assemblaggio",
      ".*;!Format*;!Beschriftung*;Zeichnungstitel;Baugruppentitel",
      ".*;!格式*;!标签*;图纸标题;装配标题",
      ".*;!Formato*;!Etiqueta*;Título del dibujo;Título del ensamblaje",
      ".*;!Format*;!Étiquette*;Titre du dessin;Titre de l'assemblage",
      ".*;!Biçim*;!Etiket*;Çizim Başlığı;Montaj Başlığı"};
    public static readonly string[] DefProductExcludeMask = {
      "A$*;.*;!*;Drawing Title;Assembly Title",
      "A$*;.*;!*;Штамп*;Заголовок*;Точка*",
      "A$*;.*;!*;Titolo disegno;Titolo assemblaggio",
      "A$*;.*;!*;Zeichnungstitel;Baugruppentitel",
      "A$*;.*;!*;图纸标题;装配标题",
      "A$*;.*;!*;Título del dibujo;Título del ensamblaje",
      "A$*;.*;!*;Titre du dessin;Titre de l'assemblage",
      "A$*;.*;!*;Çizim Başlığı;Montaj Başlığı"};
    public static readonly string[] AttributeInfo = {
      "Block purpose. Only 'Assembly' or 'Product' values ​​are allowed. " +
        "Do not edit this attribute; instead, change the block purpose checkboxes in the A>V>C> Properties Palette.",
      "Назначение блока. Допустимы только значения Assembly или Product. " +
        "Не редактируйте данный атрибут, а меняйте галочки назначения блока в Палитре Свойств A>V>C>.",
      "Scopo del blocco. Sono consentiti solo i valori 'Assembly' o 'Product'. " +
        "Non modificare questo attributo; in alternativa, modificare le caselle di controllo dello scopo del blocco nella tavolozza Proprietà A>V>C>.",
      "Zweck des Blocks. Nur die Werte „Assembly“ oder „Product“ sind zulässig. " +
        "Bearbeiten Sie dieses Attribut nicht; ändern Sie stattdessen die Kontrollkästchen für den Blockzweck in der A>V>C> Eigenschaftenpalette.",
      "块的用途。仅允许“Assembly”或“Product”值。 " +
        "不要编辑此属性，而是更改A>V>C>属性面板中的块用途复选框。",
      "Propósito del bloque. Solo se permiten los valores 'Assembly' o 'Product'. " +
        "No edite este atributo; en su lugar, cambie las casillas de verificación del propósito del bloque en la Paleta de Propiedades A>V>C>.",
      "But du bloc. Seules les valeurs 'Assembly' ou 'Product' sont autorisées. " +
        "Ne modifiez pas cet attribut; au lieu de cela, changez les cases à cocher de l'objectif du bloc dans la palette de propriétés A>V>C>.",
      "Blok amac. Yalnızca 'Assembly' veya 'Product' değerlerine izin verilir. " +
        "Bu özelliği düzenlemeyin; bunun yerine, A>V>C> Özellikler Paletindeki blok amacı onay kutularını değiştirin." };

    //========================================================= BlockUseStyleBox =======================================================================================
    public static readonly string[] DefaultUse = {
      "Default block use",
      "Использование блоков по умолчанию",
      "Uso predefinito del blocco",
      "Standardmäßige Blockverwendung",
      "默认块用途",
      "Uso predeterminado del bloque",
      "Utilisation par défaut du bloc",
      "Varsayılan blok kullanımı" };

    public static readonly string[] AssemblyGroupTip = {
      "Default conditions for recognizing a block as an Assembly when it has no 'Use' attribute.\n" +
        "You can change this property individually for each block in the A>V>C> Properties Palette.",
      "Условия по умолчанию для распознавания блока как Сборки, если у него нет атрибута 'Use'.\n" +
        "Вы сможете изменить это свойство у каждого блока индивидуально в Палитре Свойств A>V>C>.",
      "Condizioni predefinite per riconoscere un blocco come Assemblaggio quando non ha l'attributo 'Use'.\n" +
        "È possibile modificare questa proprietà singolarmente per ciascun blocco nella tavolozza Proprietà A>V>C>.",
      "Standardbedingungen zur Erkennung eines Blocks als Baugruppe, wenn er kein 'Use'-Attribut hat.\n" +
        "Sie können diese Eigenschaft für jeden Block einzeln in der A>V>C> Eigenschaftenpalette ändern.",
      "当块没有'Use'属性时，将其识别为装配体的默认条件。\n" +
        "您可以在 A>V>C> 属性面板中为每个块单独更改此属性。",
      "Condiciones predeterminadas para reconocer un bloque como Ensamblaje cuando no tiene el atributo 'Use'.\n" +
        "Puede cambiar esta propiedad individualmente para cada bloque en la Paleta de Propiedades A>V>C>.",
      "Conditions par défaut pour reconnaître un bloc comme un Assemblage lorsqu'il n'a pas l'attribut 'Use'.\n" +
        "Vous pouvez modifier cette propriété individuellement pour chaque bloc dans la palette Propriétés A>V>C>.",
      "Bir bloğun 'Use' özelliği olmadığında Montaj olarak tanınması için varsayılan koşullar.\n" +
        "Bu özelliği her blok için A>V>C> Özellikler Paleti'nde ayrı ayrı değiştirebilirsiniz." };

    public static readonly string[] ProductGroupTip = {
      "Default conditions for recognizing a block as a Product when it has no 'Use' attribute.\n" +
        "You can change this property individually for each block in the A>V>C> Properties Palette.",
      "Условия по умолчанию для распознавания блока как Изделия, если у него нет атрибута 'Use'.\n" +
        "Вы сможете изменить это свойство у каждого блока индивидуально в Палитре Свойств A>V>C>.",
      "Condizioni predefinite per riconoscere un blocco come Prodotto quando non ha l'attributo 'Use'.\n" +
        "È possibile modificare questa proprietà singolarmente per ciascun blocco nella tavolozza Proprietà A>V>C>.",
      "Standardbedingungen zur Erkennung eines Blocks als Produkt, wenn er kein 'Use'-Attribut hat.\n" +
        "Sie können diese Eigenschaft für jeden Block einzeln in der A>V>C> Eigenschaftenpalette ändern.",
      "当块没有'Use'属性时，将其识别为产品的默认条件。\n" +
        "您可以在 A>V>C> 属性面板中为每个块单独更改此属性。",
      "Condiciones predeterminadas para reconocer un bloque como Producto cuando no tiene el atributo 'Use'.\n" +
        "Puede cambiar esta propiedad individualmente para cada bloque en la Paleta de Propiedades A>V>C>.",
      "Conditions par défaut pour reconnaître un bloc comme un Produit lorsqu'il n'a pas l'attribut 'Use'.\n" +
        "Vous pouvez modifier cette propriété individuellement pour chaque bloc dans la palette Propriétés A>V>C>.",
      "Bir bloğun 'Use' özelliği olmadığında Ürün olarak tanınması için varsayılan koşullar.\n" +
        "Bu özelliği her blok için A>V>C> Özellikler Paleti'nde ayrı ayrı değiştirebilirsiniz." };

    public static readonly string[] AsmExplodableCheckTip = {
      "If enabled, the Explodable property is used to recognize assemblies.",
      "Если включено, свойство взрываемости используется для распознавания сборок.",
      "Se abilitato, la proprietà Esplodibile viene usata per riconoscere gli assemblaggi." ,
      "Wenn aktiviert, wird die Eigenschaft 'Explodierbar' zur Erkennung von Baugruppen verwendet.",
      "如果启用，可分解属性用于识别装配体",
      "Si está habilitado, la propiedad Explotable se usa para reconocer ensamblajes.",
      "Si activé, la propriété Explosible est utilisée pour reconnaître les assemblages." ,
      "Etkinleştirilirse, Patlatılabilir özelliği montajları tanımak için kullanılır." };

    public static readonly string[] PrdExplodableCheckTip = {
      "If enabled, the Explodable property is used to recognize products.",
      "Если включено, свойство взрываемости используется для распознавания изделий.",
      "Se abilitato, la proprietà Esplodibile viene usata per riconoscere i prodotti.",
      "Wenn aktiviert, wird die Eigenschaft 'Explodierbar' zur Erkennung von Produkten verwendet.",
      "如果启用，可分解属性用于识别产品。",
      "Si está habilitado, la propiedad Explotable se usa para reconocer productos.",
      "Si activé, la propriété Explosible est utilisée pour reconnaître les produits.",
      "Etkinleştirilirse, Patlatılabilir özelliği ürünleri tanımak için kullanılır."};

    public static readonly string[] AsmAnnotativeCheckTip = {
      "If enabled, the Annotative property is used to recognize assemblies.",
      "Если включено, свойство аннотативности используется для распознавания сборок.",
      "Se abilitato, la proprietà Annotativo viene usata per riconoscere gli assemblaggi.",
      "Wenn aktiviert, wird die Eigenschaft 'Annotativ' zur Erkennung von Baugruppen verwendet.",
      "如果启用，注释性属性用于识别装配体。",
      "Si está habilitado, la propiedad Anotativo se usa para reconocer ensamblajes.",
      "Si activé, la propriété Annotatif est utilisée pour reconnaître les assemblages.",
      "Etkinleştirilirse, Açıklamalı özelliği montajları tanımak için kullanılır."  };

    public static readonly string[] PrdAnnotativeCheckTip = {
      "If enabled, the Annotative property is used to recognize products.",
      "Если включено, свойство аннотативности используется для распознавания изделий.",
      "Se abilitato, la proprietà Annotativo viene usata per riconoscere i prodotti.",
      "Wenn aktiviert, wird die Eigenschaft 'Annotativ' zur Erkennung von Produkten verwendet.",
      "如果启用，注释性属性用于识别产品。",
      "Si está habilitado, la propiedad Anotativo se usa para reconocer productos.",
      "Si activé, la propriété Annotatif est utilisée pour reconnaître les produits.",
      "Etkinleştirilirse, Açıklamalı özelliği ürünleri tanımak için kullanılır." };

    public static readonly string[] ExplodableCheck = {
      "Check Explodable",
      "Проверять взрываемость",
      "Controlla Esplodibile",
      "Explodierbar prüfen",
      "检查可分解性",
      "Verificar Explotable",
      "Vérifier Explosible",
      "Patlatılabilir Kontrol Et" };
    public static readonly string[] AnnotativeCheck = {
      "Check Annotative",
      "Проверять аннотативность",
      "Controlla Annotativo",
      "Annotativ prüfen",
      "检查注释性",
      "Verificar Anotativo",
      "Vérifier Annotatif",
      "Açıklamalı Kontrol Et" };
    public static readonly string[] AsmExplodableTip = {
      "If this option is enabled, Explodable Blocks will be considered an Assembly. \r\n"+
        "If this option is disabled, Non-Explodable Blocks will be considered an Assembly.",
      "Если включена эта опция, то Взрываемые блоки будут считаться Сборкой. \r\n" +
        "Если отключена эта опция, то НЕ-взрываемые блоки будут считаться Сборкой.",
      "Se questa opzione è abilitata, i blocchi esplosivi saranno considerati un Assemblaggio. \r\n" +
        "Se questa opzione è disabilitata, i blocchi non esplosivi saranno considerati un Assemblaggio.",
      "Wenn diese Option aktiviert ist, werden explodierbare Blöcke als Baugruppe betrachtet. \r\n" +
        "Wenn diese Option deaktiviert ist, werden nicht explodierbare Blöcke als Baugruppe betrachtet.",
      "如果启用此选项，则可分解块将被视为装配体。 \r\n" +
        "如果禁用此选项，则不可分解块将被视为装配体。",
      "Si esta opción está habilitada, los bloques explotables se considerarán un ensamblaje. \r\n" +
        "Si esta opción está deshabilitada, los bloques no explotables se considerarán un ensamblaje.",
      "Si cette option est activée, les blocs explosibles seront considérés comme un assemblage. \r\n" +
        "Si cette option est désactivée, les blocs non explosibles seront considérés comme un assemblage.",
      "Bu seçenek etkinleştirilirse, Patlatılabilir Bloklar bir Montaj olarak kabul edilir. \r\n" +
        "Bu seçenek devre dışı bırakılırsa, Patlatılamaz Bloklar bir Montaj olarak kabul edilir." };
    public static readonly string[] PrdExplodableTip = {
      "If this option is enabled, Explodable Blocks will be considered a Product. \r\n"+
        "If this option is disabled, Non-Explodable Blocks will be considered a Product.",
      "Если включена эта опция, то Взрываемые блоки будут считаться Изделием. \r\n" +
        "Если отключена эта опция, то НЕ-взрываемые блоки будут считаться Изделием.",
      "Se questa opzione è abilitata, i blocchi esplosivi saranno considerati un Prodotto. \r\n" +
        "Se questa opzione è disabilitata, i blocchi non esplosivi saranno considerati un Prodotto.",
      "Wenn diese Option aktiviert ist, werden explodierbare Blöcke als Produkt betrachtet. \r\n" +
        "Wenn diese Option deaktiviert ist, werden nicht explodierbare Blöcke als Produkt betrachtet.",
      "如果启用此选项，则可分解块将被视为产品。 \r\n" +
        "如果禁用此选项，则不可分解块将被视为产品。",
      "Si esta opción está habilitada, los bloques explotables se considerarán un producto. \r\n" +
        "Si esta opción está deshabilitada, los bloques no explotables se considerarán un producto.",
      "Si cette option est activée, les blocs explosibles seront considérés comme un produit. \r\n" +
        "Si cette option est désactivée, les blocs non explosibles seront considérés comme un produit.",
      "Bu seçenek etkinleştirilirse, Patlatılabilir Bloklar bir Ürün olarak kabul edilir. \r\n" +
        "Bu seçenek devre dışı bırakılırsa, Patlatılamaz Bloklar bir Ürün olarak kabul edilir." };

    public static readonly string[] AsmAnnotativeTip = {
      "If this option is enabled, Annotative Blocks will be considered an Assembly. \r\n"+
        "If this option is disabled, Non-Annotative Blocks will be considered an Assembly.",
      "Если включена эта опция, то Аннотативные блоки будут считаться Сборкой. \r\n" +
        "Если отключена эта опция, то НЕ-аннотативные блоки будут считаться Сборкой.",
      "Se questa opzione è abilitata, i blocchi annotativi saranno considerati un Assemblaggio. \r\n" +
        "Se questa opzione è disabilitata, i blocchi non annotativi saranno considerati un Assemblaggio.",
      "Wenn diese Option aktiviert ist, werden annotative Blöcke als Baugruppe betrachtet. \r\n" +
        "Wenn diese Option deaktiviert ist, werden nicht annotative Blöcke als Baugruppe betrachtet.",
      "如果启用此选项，则注释性块将被视为装配体。 \r\n" +
        "如果禁用此选项，则非注释性块将被视为装配体。",
      "Si esta opción está habilitada, los bloques anotativos se considerarán un ensamblaje. \r\n" +
        "Si esta opción está deshabilitada, los bloques no anotativos se considerarán un ensamblaje.",
      "Si cette option est activée, les blocs annotatifs seront considérés comme un assemblage. \r\n" +
        "Si cette option est désactivée, les blocs non annotatifs seront considérés comme un assemblage.",
      "Bu seçenek etkinleştirilirse, Açıklamalı Bloklar bir Montaj olarak kabul edilir. \r\n" +
        "Bu seçenek devre dışı bırakılırsa, Açıklamasız Bloklar bir Montaj olarak kabul edilir." };
    public static readonly string[] PrdAnnotativeTip = {
      "If this option is enabled, Annotative Blocks will be considered an Product. \r\n"+
        "If this option is disabled, Non-Annotative Blocks will be considered an Product.",
      "Если включена эта опция, то Аннотативные блоки будут считаться Изделием. \r\n" +
        "Если отключена эта опция, то НЕ-аннотативные блоки будут считаться Изделием.",
      "Se questa opzione è abilitata, i blocchi annotativi saranno considerati un Prodotto. \r\n" +
        "Se questa opzione è disabilitata, i blocchi non annotativi saranno considerati un Prodotto.",
      "Wenn diese Option aktiviert ist, werden annotative Blöcke als Produkt betrachtet. \r\n" +
        "Wenn diese Option deaktiviert ist, werden nicht annotative Blöcke als Produkt betrachtet.",
      "如果启用此选项，则注释性块将被视为产品。 \r\n" +
        "如果禁用此选项，则非注释性块将被视为产品。",
      "Si esta opción está habilitada, los bloques anotativos se considerarán un producto. \r\n" +
        "Si esta opción está deshabilitada, los bloques no anotativos se considerarán un producto.",
      "Si cette option est activée, les blocs annotatifs seront considérés comme un produit. \r\n" +
        "Si cette option est désactivée, les blocs non annotatifs seront considérés comme un produit.",
      "Bu seçenek etkinleştirilirse, Açıklamalı Bloklar bir Ürün olarak kabul edilir. \r\n" +
        "Bu seçenek devre dışı bırakılırsa, Açıklamasız Bloklar bir Ürün olarak kabul edilir." };
    public static readonly string[] ExcludeByName = {
      "Exclude by name",
      "Исключить по имени",
      "Escludi per nome",
      "Nach Name ausschließen",
      "按名称排除",
      "Excluir por nombre",
      "Exclure par nom",
      "Ada göre hariç tut" };
    public static readonly string[] ExcludeByNameTip = {
      "Ignore blocks whose name matches one of the custom masks.",
      "Игнорировать блоки, у которых имя подходит к одной из настраиваемых масок.",
      "Ignora i blocchi il cui nome corrisponde a una delle maschere personalizzate.",
      "Ignorieren Sie Blöcke, deren Name mit einer der benutzerdefinierten Masken übereinstimmt.",
      "忽略名称与自定义掩码之一匹配的块。",
      "Ignorar los bloques cuyo nombre coincide con una de las máscaras personalizadas.",
      "Ignorer les blocs dont le nom correspond à l'un des masques personnalisés.",
      "Özel maskelerden biriyle adı eşleşen blokları yoksay." };
    public static readonly string[] ExcludeMaskTip = {
      "Comma or semicolon separated masks. Supports * (any chars) and ? (one char). \r\n" +
        "Blocks matching any mask are excluded.",
      "Маски через запятую или точку с запятой. Поддерживаются * (любые символы) и ? (один символ). \r\n" +
        "Блоки совпадающие с любой маской — исключаются.",
      "Maschere separate da virgola o punto e virgola. Supporta * (qualsiasi carattere) e ? (un carattere). \r\n" +
        "I blocchi corrispondenti a qualsiasi maschera vengono esclusi.",
      "Durch Komma oder Semikolon getrennte Masken. Unterstützt * (beliebige Zeichen) und ? (ein Zeichen). \r\n" +
        "Blöcke, die einer Maske entsprechen, werden ausgeschlossen.",
      "用逗号或分号分隔的掩码。支持 *（任意字符）和 ?（一个字符）。匹配任意掩码的块将被排除。",
      "Máscaras separadas por coma o punto y coma. Admite * (cualquier carácter) y ? (un carácter). \r\n " +
        "Los bloques que coincidan con alguna máscara serán excluidos.",
      "Masques séparés par des virgules ou des points-virgules. Prend en charge * (n'importe quel caractère) et ? (un caractère). \r\n" +
        "Les blocs correspondant à un masque sont exclus.",
      "Virgül veya noktalı virgülle ayrılmış maskeler. * (herhangi bir karakter) ve ? (bir karakter) desteklenir. \r\n" +
        "Herhangi bir maske ile eşleşen bloklar hariç tutulur." };



  }
}
