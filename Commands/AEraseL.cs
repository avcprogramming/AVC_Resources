namespace AVC
{
  public static class AEraseL
  {

    public static readonly string[] NothingSelected = {
      "⚠️ Nothing selected. Select objects in the drawing or check them in DwgTree before calling the command",
      "⚠️ Ничего не выбрано. Выберите объекты в чертеже или отметьте их в DwgTree до вызова команды",
      "⚠️ Nessuna selezione. Selezionare gli oggetti nel disegno o spuntarli in DwgTree prima di avviare il comando",
      "⚠️ Nichts ausgewählt. Wählen Sie vor dem Befehlsaufruf Objekte in der Zeichnung oder markieren Sie sie in DwgTree",
      "⚠️ 未选择任何对象。请在调用命令前在图形中选择对象或在 DwgTree 中勾选",
      "⚠️ No hay nada seleccionado. Seleccione objetos en el dibujo o márquelos en DwgTree antes de ejecutar el comando",
      "⚠️ Rien n'est sélectionné. Sélectionnez des objets dans le dessin ou cochez-les dans DwgTree avant d'appeler la commande",
      "⚠️ Hiçbir şey seçilmedi. Komutu çağırmadan önce çizimde nesne seçin veya DwgTree'de işaretleyin" };

    public static readonly string[] EraseMaterialTip = {
      "Erase selected materials from the drawing (AErase). \r\n" +
        "For objects and layers, these materials will be replaced by the 'Global' material, \r\n" +
        "and the coatings and edge bandings of solids will be removed.",
      "Удалить выбранные материалы из чертежа (AErase). \r\n" +
        "У объектов и слоев эти материалы заменятся на материал 'Global', \r\n" +
        "покрытия и кромки солидов будут удалены.",
      "Elimina i materiali selezionati dal disegno (AErase). \r\n" +
        "Per oggetti e layer, questi materiali saranno sostituiti dal materiale 'Global', \r\n" +
        "e le finiture e bordature dei solidi saranno rimosse.",
      "Ausgewählte Materialien aus der Zeichnung löschen (AErase). \r\n" +
        "Für Objekte und Layer werden diese Materialien durch das Material 'Global' ersetzt, \r\n" +
        "und die Beschichtungen und Kanten von Solids werden entfernt.",
      "从图形中删除所选材质 (AErase)。\r\n" +
        "对于对象和图层，这些材质将被“Global”材质替换，并且将移除实体的涂层和封边。",
      "Eliminar los materiales seleccionados del dibujo (AErase). \r\n" +
        "Para objetos y capas, estos materiales se reemplazarán por el material 'Global', \r\n" +
        "y se eliminarán los recubrimientos y cantos de los sólidos.",
      "Supprimer les matériaux sélectionnés du dessin (AErase). \r\n" +
        "Pour les objets et les calques, ces matériaux seront remplacés par le matériau 'Global', \r\n" +
        "et les revêtements et chants des solides seront supprimés.",
      "Seçili malzemeleri çizimden sil (AErase). \r\n" +
        "Nesneler ve katmanlar için bu malzemeler 'Global' malzeme ile değiştirilecek ve katıların kaplamaları ve kenar bantları kaldırılacaktır." };

    public static readonly string[] EraseLayerTip = {
      "Erase selected layers from the drawing (AErase). \r\n" +
        "All objects on these layers are moved to layer 0, current layer is switched to 0, then the layers are purged. \r\n" +
        "Layers 0, Defpoints and xref-dependent layers cannot be erased",
      "Удалить выбранные слои из чертежа (AErase). \r\n" +
        "Все объекты с этих слоев переносятся на слой 0, текущим становится слой 0, затем слои удаляются. \r\n" +
        "Слои 0, Defpoints и слои внешних ссылок удалить нельзя",
      "Elimina i layer selezionati dal disegno (AErase). \r\n" +
        "Tutti gli oggetti su questi layer vengono spostati sul layer 0, il layer corrente diventa 0, poi i layer vengono eliminati. \r\n" +
        "I layer 0, Defpoints e dipendenti da xref non possono essere eliminati",
      "Ausgewählte Layer aus der Zeichnung löschen (AErase). \r\n" +
        "Alle Objekte dieser Layer werden auf Layer 0 verschoben, Layer 0 wird aktuell, dann werden die Layer bereinigt. \r\n" +
        "Layer 0, Defpoints und XRef-abhängige Layer können nicht gelöscht werden",
      "从图形中删除所选图层 (AErase)。\r\n" +
        "这些图层上的所有对象将移到图层 0，当前图层切换为 0，然后清理图层。\r\n" +
        "图层 0、Defpoints 和外部参照图层不能删除",
      "Eliminar las capas seleccionadas del dibujo (AErase). \r\n" +
        "Todos los objetos de estas capas se mueven a la capa 0, la capa actual pasa a ser 0 y luego las capas se limpian. \r\n" +
        "Las capas 0, Defpoints y dependientes de refX no se pueden eliminar",
      "Supprimer les calques sélectionnés du dessin (AErase). \r\n" +
        "Tous les objets de ces calques sont déplacés sur le calque 0, le calque courant devient 0, puis les calques sont purgés. \r\n" +
        "Les calques 0, Defpoints et dépendants de xréf ne peuvent pas être supprimés",
      "Seçili katmanları çizimden sil (AErase). \r\n" +
        "Bu katmanlardaki tüm nesneler 0 katmanına taşınır, geçerli katman 0 olur, ardından katmanlar temizlenir. \r\n" +
        "0, Defpoints ve dış referans katmanları silinemez" };

    public static readonly string[] EraseGroupTip = {
      "Erase selected selection groups from the drawing (AErase). \r\n" +
        "Only the group definition is removed, the objects of the group remain in the drawing",
      "Удалить выбранные группы совместного выбора из чертежа (AErase). \r\n" +
        "Удаляется только сама группа, объекты группы остаются в чертеже",
      "Elimina i gruppi di selezione selezionati dal disegno (AErase). \r\n" +
        "Viene eliminato solo il gruppo, gli oggetti del gruppo restano nel disegno",
      "Ausgewählte Auswahlgruppen aus der Zeichnung löschen (AErase). \r\n" +
        "Nur die Gruppe wird gelöscht, die Objekte der Gruppe bleiben in der Zeichnung",
      "从图形中删除所选的选择编组 (AErase)。\r\n" +
        "仅删除编组本身，编组中的对象保留在图形中",
      "Eliminar los grupos de selección seleccionados del dibujo (AErase). \r\n" +
        "Solo se elimina el grupo, los objetos del grupo permanecen en el dibujo",
      "Supprimer les groupes de sélection sélectionnés du dessin (AErase). \r\n" +
        "Seul le groupe est supprimé, les objets du groupe restent dans le dessin",
      "Seçili seçim gruplarını çizimden sil (AErase). \r\n" +
        "Yalnızca grup silinir, grubun nesneleri çizimde kalır" };

    public static readonly string[] EraseBlockTip = {
      "Erase selected block definitions from the drawing (AErase). \r\n" +
        "All insertions of these blocks (including nested in other blocks) and anonymous copies of dynamic blocks are erased, \r\n" +
        "then the definitions are purged. Layout blocks and xrefs cannot be erased",
      "Удалить выбранные определения блоков из чертежа (AErase). \r\n" +
        "Удаляются все вхождения этих блоков (в том числе вложенные в другие блоки) и анонимные копии динамических блоков, \r\n" +
        "затем определения блоков. Внешние ссылки удалить нельзя",
      "Elimina le definizioni di blocco selezionate dal disegno (AErase). \r\n" +
        "Vengono eliminati tutti gli inserimenti (anche annidati in altri blocchi) e le copie anonime dei blocchi dinamici, \r\n" +
        "poi le definizioni. I blocchi dei layout e gli xref non possono essere eliminati",
      "Ausgewählte Blockdefinitionen aus der Zeichnung löschen (AErase). \r\n" +
        "Alle Einfügungen (auch in anderen Blöcken verschachtelte) und anonyme Kopien dynamischer Blöcke werden gelöscht, \r\n" +
        "dann die Definitionen bereinigt. Layoutblöcke und XRefs können nicht gelöscht werden",
      "从图形中删除所选块定义 (AErase)。\r\n" +
        "将删除这些块的所有插入（包括嵌套在其他块中的）以及动态块的匿名副本，然后清理块定义。\r\n" +
        "布局块和外部参照不能删除",
      "Eliminar las definiciones de bloque seleccionadas del dibujo (AErase). \r\n" +
        "Se eliminan todas las inserciones (incluso anidadas en otros bloques) y las copias anónimas de bloques dinámicos, \r\n" +
        "luego las definiciones. Los bloques de presentación y las refX no se pueden eliminar",
      "Supprimer les définitions de bloc sélectionnées du dessin (AErase). \r\n" +
        "Toutes les insertions (y compris imbriquées dans d'autres blocs) et les copies anonymes des blocs dynamiques sont supprimées, \r\n" +
        "puis les définitions sont purgées. Les blocs de présentation et les xréfs ne peuvent pas être supprimés",
      "Seçili blok tanımlarını çizimden sil (AErase). \r\n" +
        "Bu blokların tüm eklemeleri (diğer bloklara iç içe olanlar dahil) ve dinamik blokların anonim kopyaları silinir, \r\n" +
        "ardından tanımlar temizlenir. Düzen blokları ve dış referanslar silinemez" };

    public static readonly string[] EraseQuery = {
      "Erase {0} selected objects? \r\n" +
        "All related drawing objects will be modified or erased",
      "Удалить выбранные объекты ({0} шт.)? \r\n" +
        "Все связанные объекты чертежа будут изменены или удалены",
      "Eliminare {0} oggetti selezionati? \r\n" +
        "Tutti gli oggetti collegati del disegno saranno modificati o eliminati",
      "{0} ausgewählte Objekte löschen? \r\n" +
        "Alle zugehörigen Zeichnungsobjekte werden geändert oder gelöscht",
      "删除所选的 {0} 个对象？\r\n" +
        "图形中所有相关对象将被修改或删除",
      "¿Eliminar {0} objetos seleccionados? \r\n" +
        "Todos los objetos relacionados del dibujo se modificarán o eliminarán",
      "Supprimer {0} objets sélectionnés ? \r\n" +
        "Tous les objets liés du dessin seront modifiés ou supprimés",
      "Seçili {0} nesne silinsin mi? \r\n" +
        "Çizimdeki tüm ilgili nesneler değiştirilecek veya silinecek" };

    public static readonly string[] EraseQueryOne = {
      "Erase \"{0}\"? \r\n" +
        "All related drawing objects will be modified or erased",
      "Удалить \"{0}\"? \r\n" +
        "Все связанные объекты чертежа будут изменены или удалены",
      "Eliminare \"{0}\"? \r\n" +
        "Tutti gli oggetti collegati del disegno saranno modificati o eliminati",
      "\"{0}\" löschen? \r\n" +
        "Alle zugehörigen Zeichnungsobjekte werden geändert oder gelöscht",
      "删除 \"{0}\"？\r\n" +
        "图形中所有相关对象将被修改或删除",
      "¿Eliminar \"{0}\"? \r\n" +
        "Todos los objetos relacionados del dibujo se modificarán o eliminarán",
      "Supprimer « {0} » ? \r\n" +
        "Tous les objets liés du dessin seront modifiés ou supprimés",
      "\"{0}\" silinsin mi? \r\n" +
        "Çizimdeki tüm ilgili nesneler değiştirilecek veya silinecek" };

    public static readonly string[] Erasing = {
      "Erasing objects",
      "Удаление объектов",
      "Eliminazione degli oggetti",
      "Objekte werden gelöscht",
      "正在删除对象",
      "Eliminando objetos",
      "Suppression des objets",
      "Nesneler siliniyor" };

    public static readonly string[] AZoomSelected = {
      "Objects to zoom: {0}",
      "Объектов для показа: {0}",
      "Oggetti da visualizzare: {0}",
      "Anzuzeigende Objekte: {0}",
      "要缩放的对象：{0}",
      "Objetos para mostrar: {0}",
      "Objets à afficher : {0}",
      "Gösterilecek nesneler: {0}" };

    public static readonly string[] AEraseSelected = {
      "Objects selected for erasing: {0}",
      "Выбрано объектов для удаления: {0}",
      "Oggetti selezionati per la cancellazione: {0}",
      "Zum Löschen ausgewählte Objekte: {0}",
      "选择要删除的对象：{0}",
      "Objetos seleccionados para borrar: {0}",
      "Objets sélectionnés pour l'effacement : {0}",
      "Silinmek üzere seçilen nesneler: {0}" };

    public static readonly string[] AEraseModified = {
      "Objects modified to replace layer or material: {0}",
      "Изменено объектов для замены слоя или материала: {0}",
      "Oggetti modificati per sostituire layer o materiale: {0}",
      "Geänderte Objekte zum Ersetzen von Layer oder Material: {0}",
      "为替换图层或材质而修改的对象：{0}",
      "Objetos modificados para sustituir capa o material: {0}",
      "Objets modifiés pour remplacer le calque ou le matériau : {0}",
      "Katman veya malzeme değiştirmek için değiştirilen nesneler: {0}" };

    public static readonly string[] AEraseErased = {
      "Objects erased: {0}",
      "Удалено объектов: {0}",
      "Oggetti cancellati: {0}",
      "Gelöschte Objekte: {0}",
      "已删除对象：{0}",
      "Objetos borrados: {0}",
      "Objets effacés : {0}",
      "Silinen nesneler: {0}" };

    public static readonly string[] AEraseErasedOne = {
      "Erased '{0}'",
      "Удален '{0}'",
      "Cancellato '{0}'",
      "'{0}' gelöscht",
      "已删除 '{0}'",
      "Borrado '{0}'",
      "'{0}' effacé",
      "'{0}' silindi" };

    public static readonly string[] AEraseSkipped = {
      "⚠️ {0} objects were not erased: they are in use or cannot be erased",
      "⚠️ Не удалено объектов: {0}. Они используются или не могут быть удалены",
      "⚠️ {0} oggetti non sono stati cancellati: sono in uso o non possono essere cancellati",
      "⚠️ {0} Objekte wurden nicht gelöscht: sie werden verwendet oder können nicht gelöscht werden",
      "⚠️ 未删除 {0} 个对象：它们正在使用或无法删除",
      "⚠️ No se borraron {0} objetos: están en uso o no se pueden borrar",
      "⚠️ {0} objets n'ont pas été effacés : ils sont utilisés ou ne peuvent pas être effacés",
      "⚠️ {0} nesne silinmedi: kullanımda veya silinemez" };

    public static readonly string[] LayerBuiltIn = {
      "Layer '{0}' is a system layer and cannot be erased",
      "Слой '{0}' системный, его нельзя удалить",
      "Il layer '{0}' è di sistema e non può essere cancellato",
      "Layer '{0}' ist ein Systemlayer und kann nicht gelöscht werden",
      "图层 '{0}' 是系统图层，无法删除",
      "La capa '{0}' es del sistema y no se puede borrar",
      "Le calque '{0}' est un calque système et ne peut pas être effacé",
      "'{0}' katmanı sistem katmanıdır ve silinemez" };

    public static readonly string[] LayerDependent = {
      "Layer '{0}' belongs to an external reference and cannot be erased",
      "Слой '{0}' принадлежит внешней ссылке, его нельзя удалить",
      "Il layer '{0}' appartiene a un riferimento esterno e non può essere cancellato",
      "Layer '{0}' gehört zu einer externen Referenz und kann nicht gelöscht werden",
      "图层 '{0}' 属于外部参照，无法删除",
      "La capa '{0}' pertenece a una referencia externa y no se puede borrar",
      "Le calque '{0}' appartient à une référence externe et ne peut pas être effacé",
      "'{0}' katmanı bir dış referansa aittir ve silinemez" };

    public static readonly string[] LayerInUse = {
      "Layer '{0}' cannot be erased: it is still referenced by objects that cannot be moved to layer 0 ({1})",
      "Слой '{0}' нельзя удалить: на него ссылаются объекты, которые не удалось перенести на слой 0 ({1})",
      "Il layer '{0}' non può essere cancellato: è ancora referenziato da oggetti che non possono essere spostati sul layer 0 ({1})",
      "Layer '{0}' kann nicht gelöscht werden: er wird noch von Objekten referenziert, die nicht auf Layer 0 verschoben werden können ({1})",
      "无法删除图层 '{0}'：仍有无法移到图层 0 的对象引用它（{1}）",
      "No se puede borrar la capa '{0}': todavía la referencian objetos que no se pueden mover a la capa 0 ({1})",
      "Le calque '{0}' ne peut pas être effacé : il est encore référencé par des objets impossibles à déplacer sur le calque 0 ({1})",
      "'{0}' katmanı silinemez: katman 0'a taşınamayan nesneler tarafından hâlâ kullanılıyor ({1})" };

    public static readonly string[] MaterialBuiltIn = {
      "Material '{0}' is a system material and cannot be erased",
      "Материал '{0}' системный, его нельзя удалить",
      "Il materiale '{0}' è di sistema e non può essere cancellato",
      "Material '{0}' ist ein Systemmaterial und kann nicht gelöscht werden",
      "材质 '{0}' 是系统材质，无法删除",
      "El material '{0}' es del sistema y no se puede borrar",
      "Le matériau '{0}' est un matériau système et ne peut pas être effacé",
      "'{0}' malzemesi sistem malzemesidir ve silinemez" };

    public static readonly string[] MaterialNoGlobal = {
      "Material '{0}' cannot be erased: there is no Global material in the drawing to replace it",
      "Материал '{0}' нельзя удалить: в чертеже нет материала Global для замены",
      "Il materiale '{0}' non può essere cancellato: nel disegno manca il materiale Global per sostituirlo",
      "Material '{0}' kann nicht gelöscht werden: in der Zeichnung fehlt das Material Global als Ersatz",
      "无法删除材质 '{0}'：图形中没有用于替换的 Global 材质",
      "No se puede borrar el material '{0}': en el dibujo no existe el material Global para sustituirlo",
      "Le matériau '{0}' ne peut pas être effacé : le dessin ne contient pas le matériau Global pour le remplacer",
      "'{0}' malzemesi silinemez: çizimde yerine konacak Global malzemesi yok" };

    public static readonly string[] MaterialInUse = {
      "Material '{0}' cannot be erased: it is still referenced by objects that cannot be switched to Global ({1})",
      "Материал '{0}' нельзя удалить: на него ссылаются объекты, которые не удалось перевести на Global ({1})",
      "Il materiale '{0}' non può essere cancellato: è ancora referenziato da oggetti che non possono passare a Global ({1})",
      "Material '{0}' kann nicht gelöscht werden: er wird noch von Objekten referenziert, die nicht auf Global umgestellt werden können ({1})",
      "无法删除材质 '{0}'：仍有无法切换为 Global 的对象引用它（{1}）",
      "No se puede borrar el material '{0}': todavía lo referencian objetos que no se pueden cambiar a Global ({1})",
      "Le matériau '{0}' ne peut pas être effacé : il est encore référencé par des objets impossibles à passer en Global ({1})",
      "'{0}' malzemesi silinemez: Global'e geçirilemeyen nesneler tarafından hâlâ kullanılıyor ({1})" };

    public static readonly string[] BlockNotNamed = {
      "Block '{0}' is a space, external reference, array, table or other special block and cannot be erased",
      "Блок '{0}' является пространством, внешней ссылкой, массивом, таблицей или другим особым блоком, его нельзя удалить",
      "Il blocco '{0}' è uno spazio, un riferimento esterno, una serie, una tabella o un altro blocco speciale e non può essere cancellato",
      "Block '{0}' ist ein Bereich, eine externe Referenz, eine Anordnung, eine Tabelle oder ein anderer Sonderblock und kann nicht gelöscht werden",
      "块 '{0}' 是空间、外部参照、阵列、表格或其他特殊块，无法删除",
      "El bloque '{0}' es un espacio, una referencia externa, una matriz, una tabla u otro bloque especial y no se puede borrar",
      "Le bloc '{0}' est un espace, une référence externe, un réseau, un tableau ou un autre bloc spécial et ne peut pas être effacé",
      "'{0}' bloğu bir alan, dış referans, dizi, tablo veya başka bir özel bloktur ve silinemez" };

    public static readonly string[] BlockMechanical = {
      "Block '{0}' is a BricsCAD Mechanical component. Delete it in the Mechanical Browser",
      "Блок '{0}' является компонентом BricsCAD Mechanical. Удалите его в Mechanical Browser",
      "Il blocco '{0}' è un componente BricsCAD Mechanical. Eliminarlo nel Mechanical Browser",
      "Block '{0}' ist eine BricsCAD Mechanical-Komponente. Löschen Sie ihn im Mechanical Browser",
      "块 '{0}' 是 BricsCAD Mechanical 组件。请在 Mechanical Browser 中删除",
      "El bloque '{0}' es un componente de BricsCAD Mechanical. Bórrelo en el Mechanical Browser",
      "Le bloc '{0}' est un composant BricsCAD Mechanical. Supprimez-le dans le Mechanical Browser",
      "'{0}' bloğu bir BricsCAD Mechanical bileşenidir. Mechanical Browser'da silin" };

    public static readonly string[] BlockInUse = {
      "Block '{0}' cannot be erased: it is still referenced by other objects",
      "Блок '{0}' нельзя удалить: на него ссылаются другие объекты",
      "Il blocco '{0}' non può essere cancellato: è ancora referenziato da altri oggetti",
      "Block '{0}' kann nicht gelöscht werden: er wird noch von anderen Objekten referenziert",
      "无法删除块 '{0}'：仍被其他对象引用",
      "No se puede borrar el bloque '{0}': todavía lo referencian otros objetos",
      "Le bloc '{0}' ne peut pas être effacé : il est encore référencé par d'autres objets",
      "'{0}' bloğu silinemez: hâlâ başka nesneler tarafından kullanılıyor" };

    public static readonly string[] FilterNotDeletable = {
      "Layer filter '{0}' cannot be deleted",
      "Фильтр слоев '{0}' нельзя удалить",
      "Il filtro layer '{0}' non può essere eliminato",
      "Layerfilter '{0}' kann nicht gelöscht werden",
      "无法删除图层过滤器 '{0}'",
      "No se puede borrar el filtro de capas '{0}'",
      "Le filtre de calques '{0}' ne peut pas être supprimé",
      "'{0}' katman filtresi silinemez" };
  }
}
