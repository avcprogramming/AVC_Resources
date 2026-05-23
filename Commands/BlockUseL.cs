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
      ".*;!*;Drawing Title;Assembly Title",
      ".*;!*;Штамп*;Заголовок*;Точка*",
      ".*;!*;Titolo disegno;Titolo assemblaggio",
      ".*;!*;Zeichnungstitel;Baugruppentitel",
      ".*;!*;图纸标题;装配标题",
      ".*;!*;Título del dibujo;Título del ensamblaje",
      ".*;!*;Titre du dessin;Titre de l'assemblage",
      ".*;!*;Çizim Başlığı;Montaj Başlığı"};
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

    public static readonly string[] AssemblyGroupTip = {
      "Default conditions for recognizing a block as an Assembly when it has no 'Use' attribute.\n" +
        "You can change this property individually for each block in the A>V>C> Properties Palette.",
      "Условия по умолчанию для распознавания блока как Сборки, если у него нет атрибута 'Use'.\n" +
        "Вы сможете изменить это свойство у каждого блока индивидуально в Палитре Свойств A>V>C>.",
      "Condizioni predefinite per riconoscere un blocco come Assemblaggio quando non ha l'attributo 'Use'.\n" +
        "È possibile modificare questa proprietà singolarmente per ciascun blocco nella tavolozza Proprietà A>V>C>.",
      "Standardbedingungen zur Erkennung eines Blocks als Baugruppe, wenn er kein 'Use'-Attribut hat.\n" +
        "Sie können diese Eigenschaft für jeden Block einzeln in der A>V>C> Eigenschaftenpalette ändern.",
      "当块没有"Use"属性时，将其识别为装配体的默认条件。\n" +
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
      "If enabled, the Explodable property is used to recognize assemblies.\n" +
        "Assembly = block is Explodable (inner structure matters).",
      "Если включено, свойство взрываемости используется для распознавания сборок.\n" +
        "Сборка = блок взрываемый (внутренняя структура имеет значение).",
      "Se abilitato, la proprietà Esplodibile viene usata per riconoscere gli assemblaggi.\n" +
        "Assemblaggio = il blocco è Esplodibile.",
      "Wenn aktiviert, wird die Eigenschaft 'Explodierbar' zur Erkennung von Baugruppen verwendet.\n" +
        "Baugruppe = Block ist explodierbar.",
      "如果启用，可分解属性用于识别装配体。\n" +
        "装配体 = 块是可分解的。",
      "Si está habilitado, la propiedad Explotable se usa para reconocer ensamblajes.\n" +
        "Ensamblaje = el bloque es Explotable.",
      "Si activé, la propriété Explosible est utilisée pour reconnaître les assemblages.\n" +
        "Assemblage = le bloc est Explosible.",
      "Etkinleştirilirse, Patlatılabilir özelliği montajları tanımak için kullanılır.\n" +
        "Montaj = blok Patlatılabilirdir." };

    public static readonly string[] PrdExplodableCheckTip = {
      "If enabled, the Explodable property is used to recognize products.\n" +
        "Product = block is NOT Explodable (treated as a finished item).",
      "Если включено, свойство взрываемости используется для распознавания изделий.\n" +
        "Изделие = блок НЕ взрываемый (считается готовым элементом).",
      "Se abilitato, la proprietà Esplodibile viene usata per riconoscere i prodotti.\n" +
        "Prodotto = il blocco NON è Esplodibile.",
      "Wenn aktiviert, wird die Eigenschaft 'Explodierbar' zur Erkennung von Produkten verwendet.\n" +
        "Produkt = Block ist NICHT explodierbar.",
      "如果启用，可分解属性用于识别产品。\n" +
        "产品 = 块不可分解。",
      "Si está habilitado, la propiedad Explotable se usa para reconocer productos.\n" +
        "Producto = el bloque NO es Explotable.",
      "Si activé, la propriété Explosible est utilisée pour reconnaître les produits.\n" +
        "Produit = le bloc N'est PAS Explosible.",
      "Etkinleştirilirse, Patlatılabilir özelliği ürünleri tanımak için kullanılır.\n" +
        "Ürün = blok Patlatılabilir DEĞİLDİR." };

    public static readonly string[] AsmAnnotativeCheckTip = {
      "If enabled, the Annotative property is used to recognize assemblies.\n" +
        "Assembly = block is NOT Annotative (real-scale structural object).",
      "Если включено, свойство аннотативности используется для распознавания сборок.\n" +
        "Сборка = блок НЕ аннотативный (реальный объект в масштабе чертежа).",
      "Se abilitato, la proprietà Annotativo viene usata per riconoscere gli assemblaggi.\n" +
        "Assemblaggio = il blocco NON è Annotativo.",
      "Wenn aktiviert, wird die Eigenschaft 'Annotativ' zur Erkennung von Baugruppen verwendet.\n" +
        "Baugruppe = Block ist NICHT annotativ.",
      "如果启用，注释性属性用于识别装配体。\n" +
        "装配体 = 块不是注释性的。",
      "Si está habilitado, la propiedad Anotativo se usa para reconocer ensamblajes.\n" +
        "Ensamblaje = el bloque NO es Anotativo.",
      "Si activé, la propriété Annotatif est utilisée pour reconnaître les assemblages.\n" +
        "Assemblage = le bloc N'est PAS Annotatif.",
      "Etkinleştirilirse, Açıklamalı özelliği montajları tanımak için kullanılır.\n" +
        "Montaj = blok Açıklamalı DEĞİLDİR." };

    public static readonly string[] PrdAnnotativeCheckTip = {
      "If enabled, the Annotative property is used to recognize products.\n" +
        "Product = block is NOT Annotative (real-scale purchased item).",
      "Если включено, свойство аннотативности используется для распознавания изделий.\n" +
        "Изделие = блок НЕ аннотативный (реальное покупное изделие в масштабе).",
      "Se abilitato, la proprietà Annotativo viene usata per riconoscere i prodotti.\n" +
        "Prodotto = il blocco NON è Annotativo.",
      "Wenn aktiviert, wird die Eigenschaft 'Annotativ' zur Erkennung von Produkten verwendet.\n" +
        "Produkt = Block ist NICHT annotativ.",
      "如果启用，注释性属性用于识别产品。\n" +
        "产品 = 块不是注释性的。",
      "Si está habilitado, la propiedad Anotativo se usa para reconocer productos.\n" +
        "Producto = el bloque NO es Anotativo.",
      "Si activé, la propriété Annotatif est utilisée pour reconnaître les produits.\n" +
        "Produit = le bloc N'est PAS Annotatif.",
      "Etkinleştirilirse, Açıklamalı özelliği ürünleri tanımak için kullanılır.\n" +
        "Ürün = blok Açıklamalı DEĞİLDİR." };

    public static readonly string[] ExplodableCheck = {
      "Check Explodable",
      "Проверять взрываемость",
      "Controlla Esplodibile",
      "Explodierbar prüfen",
      "检查可分解性",
      "Verificar Explotable",
      "Vérifier Explosible",
      "Patlatılabilir Kontrol Et" };
    public static readonly string[] ExplodableTip = {
      "Block must be Explodable.",
      "Взрываемый блок ",
      "Il blocco deve essere Esplodibile.",
      "Der Block muss explodierbar sein.",
      "块必须是可分解的。",
      "El bloque debe ser Explotable.",
      "Le bloc doit être Explosible.",
      "Blok Patlatılabilir olmalıdır." };
    public static readonly string[] AnnotativeCheck = {
      "Check Annotative",
      "Проверять аннотативность",
      "Controlla Annotativo",
      "Annotativ prüfen",
      "检查注释性",
      "Verificar Anotativo",
      "Vérifier Annotatif",
      "Açıklamalı Kontrol Et" };
    public static readonly string[] AnnotativeTip = {
      "Block must be Annotative.",
      "Блок должен быть аннотативным.",
      "Il blocco deve essere Annotativo.",
      "Der Block muss annotativ sein.",
      "块必须是注释性的。",
      "El bloque debe ser Anotativo.",
      "Le bloc doit être Annotatif.",
      "Blok Açıklamalı olmalıdır." };
    public static readonly string[] ExcludeByName = {
      "Exclude by name",
      "Исключить по имени",
      "Escludi per nome",
      "Nach Name ausschließen",
      "按名称排除",
      "Excluir por nombre",
      "Exclure par nom",
      "Ada göre hariç tut" };
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
    public static readonly string[] DefaultUse = {
      "Default block use",
      "Использование блоков по умолчанию",
      "Uso predefinito del blocco",
      "Standardmäßige Blockverwendung",
      "默认块用途",
      "Uso predeterminado del bloque",
      "Utilisation par défaut du bloc",
      "Varsayılan blok kullanımı" };


  }
}
