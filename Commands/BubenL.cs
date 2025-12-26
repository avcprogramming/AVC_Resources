// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

// Ignore Spelling: Acad

namespace AVC
{
  public static class
  BubenL
  {
    public static readonly string[] NoSource = {
      "View {0} does not have a data source",
      "Вид {0} не имеет источника данных",
      "La vista {0} non ha una fonte dati",
      "Ansicht {0} hat keine Datenquelle",
      "视图 {0} 没有数据源",
      "La vista {0} no tiene una fuente de datos",                // ES
      "La vue {0} n'a pas de source de données",                  // FR
      "Görünüm {0}'ın veri kaynağı yok"};                         // TR

    public static readonly string[] Updated = {
      "Updated blocks and solids: {0}",
      "Обновлено блоков и солидов: {0}",
      "Blocchi e solidi aggiornati: {0}",
      "Aktualisierte Blöcke und Volumenkörper: {0}",
      "已更新的块和实体：{0}",
      "Bloques y sólidos actualizados: {0}",                      // ES
      "Blocs et solides mis à jour : {0}",                        // FR
      "Güncellenen bloklar ve katılar: {0}"};                     // TR

    public static readonly string[] UpdatingAllView = {
      "Update ALL ModelDoc views on all drawing sheets",
      "Обновление ВСЕХ видов ModelDoc на всех листах чертежа",
      "Aggiorna TUTTE le viste ModelDoc su tutti i fogli di disegno",
      "Aktualisieren Sie ALLE ModelDoc-Ansichten auf allen Zeichenblättern",
      "更新所有图纸上的所有 ModelDoc 视图",
      "Actualizar TODAS las vistas ModelDoc en todas las hojas de dibujo",  // ES
      "Mettre à jour TOUTES les vues ModelDoc sur toutes les feuilles de dessin",  // FR
      "Tüm çizim sayfalarındaki TÜM ModelDoc görünümlerini güncelle"};  // TR

    public static readonly string[] Acad2017 = {
      "Fixing mirrored blocks only works in early releases of AutoCAD 2017 and does nothing in other versions.",
      "Исправление зеркальных блоков работает только в ранних релизах AutoCAD 2017 и ничего не дает в других версиях.",
      "La correzione dei blocchi specchiati funziona solo nelle prime versioni di AutoCAD 2017 e non ha alcun effetto nelle altre versioni.",
      "Das Reparieren gespiegelter Blöcke funktioniert nur in frühen Versionen von AutoCAD 2017 und hat in anderen Versionen keine Auswirkungen.",
      "修复镜像块仅适用于 AutoCAD 2017 的早期版本，而在其他版本中不起作用。",
      "La corrección de bloques reflejados solo funciona en las primeras versiones de AutoCAD 2017 y no hace nada en otras versiones.",  // ES
      "La correction des blocs en miroir ne fonctionne que dans les premières versions d'AutoCAD 2017 et ne fait rien dans les autres versions.",  // FR
      "Aynalı blokları düzeltme yalnızca AutoCAD 2017'nin erken sürümlerinde çalışır ve diğer sürümlerde hiçbir şey yapmaz."};  // TR

    public static readonly string[] ViewCount = {
      "Will process {0} views",
      "Будет обработано видов {0}",
      "Elaborerà {0} visualizzazioni",
      "Verarbeitet {0} Ansichten",
      "将处理 {0} 次查看",
      "Se procesarán {0} vistas",                                 // ES
      "Traitera {0} vues",                                        // FR
      "{0} görünüm işlenecek"};                                   // TR

    public static readonly string[] Processing = {
      "Processing views",
      "Обработка видов",
      "Elaborazione di viste",
      "Verarbeitung von Ansichten",
      "处理个视图",
      "Procesando vistas",                                        // ES
      "Traitement des vues",                                      // FR
      "Görünümler işleniyor"};                                    // TR

    public static readonly string[] ViewBorderPointQuery = {
      "Click anywhere above the broken ModelDoc view",
      "Кликните по любой точке над сломанным видом ModelDoc",
      "Fare clic in un punto qualsiasi sopra la vista ModelDoc interrotta",
      "Klicken Sie irgendwo über der beschädigten ModelDoc-Ansicht",
      "单击损坏的 ModelDoc 视图上方的任意位置",
      "Haga clic en cualquier lugar sobre la vista ModelDoc dañada",  // ES
      "Cliquez n'importe où au-dessus de la vue ModelDoc endommagée",  // FR
      "Bozuk ModelDoc görünümünün üzerinde herhangi bir yere tıklayın"};  // TR

    public static readonly string[] NoViewAtPoint = {
      "No visible ModelDoc view found below the given point.",
      "Не найден видимый вид ModelDoc под заданной точкой.",
      "Nessuna vista ModelDoc visibile trovata sotto il punto indicato.",
      "Unterhalb des angegebenen Punkts wurde keine sichtbare ModelDoc-Ansicht gefunden.",
      "在给定点下方未找到可见的 ModelDoc 视图。",
      "No se encontró ninguna vista ModelDoc visible debajo del punto dado.",  // ES
      "Aucune vue ModelDoc visible trouvée sous le point donné.",  // FR
      "Verilen noktanın altında görünür ModelDoc görünümü bulunamadı."};  // TR

    public static readonly string[] LayoutViewsKW = {
      "SHEETViews",
      "ВИДЫЛиста",
      "VISUalizzazioniFogli",
      "ANSICHTENBlätter",
      "此表中的所有物种(SHEET)",
      "VISTasHoja",                                               // ES
      "VUesFeUIlle",                                              // FR
      "SAYfaGörünümleri"};                                        // TR

    public static readonly string[] AllViewsKW = {
      "ALLViews",
      "ВСЕВиды",
      "TUTTELeVisualizzazioni",
      "ALLEAnsichten",
      "所有图纸上的所有视图(ALLV)",
      "TODasLasVistas",                                           // ES
      "TOUtesLesVues",                                            // FR
      "TÜMGörünümler"};                                           // TR

    public static readonly string[] Acad2017KW = {
      "ACAD2017"};

    public static readonly string[] ChangeInBlockKW = {
      "CHANGEInBlock",
      "ИЗМЕНИТЬВБлоке",
      "CAMBIANelBlocco",
      "ÄNDERNImBlock",
      "块内固体的替换(CHA)",
      "CAMBiarEnBloque",                                          // ES
      "CHANgerDansBloc",                                          // FR
      "BLOKtaDEĞiştir"};                                          // TR

    public static readonly string[] CleanBodyKW = {
      "CLEANBody",
      "ОЧИСТИТЬТело",
      "PULISCICorpo",
      "REINIGENKörper",
      "清理模型中的固体(CLE)",
      "LIMpiarCuerpo",                                            // ES
      "NETtoyerCorps",                                            // FR
      "TEMizleGövde"};                                            // TR

    public static readonly string[] Acad2017Query = {
      "Adjust the scale of mirror blocks? (only helps in AutoCAD 2017)",
      "Подправить масштаб зеркальных блоков ? (помогает только в AutoCAD 2017)",
      "Correggere la scala dei blocchi specchiati? (funziona solo in AutoCAD 2017)",
      "Skalierung von gespiegelten Blöcken reparieren? (funktioniert nur in AutoCAD 2017)",
      "修复镜像块的比例？（仅适用于 AutoCAD 2017）",
      "¿Ajustar la escala de los bloques reflejados? (solo ayuda en AutoCAD 2017)",  // ES
      "Ajuster l'échelle des blocs en miroir ? (n'aide que dans AutoCAD 2017)",  // FR
      "Aynalı blokların ölçeğini ayarlansın mı? (yalnızca AutoCAD 2017'de yardımcı olur)"};  // TR

    public static readonly string[] ChangeInBlockQuery = {
      "Replace 3D solids with their copies inside all blocks?",
      "Подменить 3D-солиды на их копии внутри всех блоков?",
      "Sostituire i solidi 3D con le loro copie all'interno di tutti i blocchi?",
      "3D-Körper in allen Blöcken durch Kopien ersetzen?",
      "在所有块中将 3D 实体替换为其副本？",
      "¿Reemplazar sólidos 3D con sus copias dentro de todos los bloques?",  // ES
      "Remplacer les solides 3D par leurs copies dans tous les blocs ?",  // FR
      "Tüm blokların içindeki 3D katıları kopyalarıyla değiştir?"};  // TR

    public static readonly string[] CleanBodyQuery = {
      "Call the procedure for cleaning 3D solids in the model (removing unnecessary faces) ?",
      "Вызвать процедуру очистки 3D-солидов в модели (удаления лишних граней) ?",
      "Chiamare la procedura di pulizia dei solidi 3D nel modello (rimozione di facce inutili) ?",
      "Rufen Sie die 3D-Körper-Reinigungsprozedur im Modell auf (Entfernen unnötiger Flächen) ?",
      "调用清理模型中的 3D 实体（删除不必要的面）的程序？",
      "¿Llamar al procedimiento para limpiar sólidos 3D en el modelo (eliminando caras innecesarias)?",  // ES
      "Appeler la procédure de nettoyage des solides 3D dans le modèle (suppression des faces inutiles) ?",  // FR
      "Modeldeki 3D katıları temizleme prosedürü çağrılsın mı (gereksiz yüzleri kaldırma)?"};  // TR

    public static readonly string[] MirrorBlock = {
      "Mirrored block reference '{0}' inside '{1}'. Scale = {2}",
      "Отзеркаленный блок '{0}' внутри '{1}'. Масштаб = {2}",
      "Riferimento al blocco speculare '{0}' all'interno di '{1}'. Scala = {2}",
      "Gespiegelte Blockreferenz '{0}' innerhalb von '{1}'. Maßstab = {2}",
      "已将块引用'{0}'镜像到'{1}'内。比例 = {2}",
      "Referencia de bloque reflejado '{0}' dentro de '{1}'. Escala = {2}",  // ES
      "Référence de bloc en miroir '{0}' à l'intérieur de '{1}'. Échelle = {2}",  // FR
      "'{1}' içinde aynalı blok referansı '{0}'. Ölçek = {2}"};  // TR

    public static readonly string[] OverRef = {
      "  Over reference on '{0}' inside '{1}'. Scale = {2}",
      "  Другая ссылка на '{0}' внутри '{1}'. Масштаб = {2}",
      "  Riferimento su '{0}' all'interno di '{1}'. Scala = {2}",
      "  Überreferenz auf '{0}' innerhalb von '{1}'. Maßstab = {2}",
      "  '{1}'内'{0}'过度引用。比例 = {2}",
      "  Sobre referencia en '{0}' dentro de '{1}'. Escala = {2}",  // ES
      "  Sur-référence sur '{0}' à l'intérieur de '{1}'. Échelle = {2}",  // FR
      "  '{1}' içinde '{0}' üzerinde aşırı referans. Ölçek = {2}"};  // TR

    public static readonly string[] SetScale = {
      "  Set scale {0}",
      "  Установлен масштаб {0}",
      "  Scala impostata su {0}",
      "  Maßstab eingestellt auf {0}",
      "  比例设置为 {0}",
      "  Escala establecida en {0}",                              // ES
      "  Échelle définie sur {0}",                                // FR
      "  Ölçek {0} olarak ayarlandı"};                            // TR

    public static readonly string[] BadBlock = {
      "Bad block reference {0} '{1}' inside '{2}'.\r\n" +
        "Easiest to kill than cure.",
      "Сбойная вставка блока {0} '{1}' внутри {2}.\r\n" +
        "Проще убить чем лечить.",
      "Riferimento al blocco errato {0} '{1}' all'interno di '{2}'.\r\n"+
        "Più facile da eliminare che da curare.",
      "Fehlerhafte Blockreferenz {0} '{1}' innerhalb von '{2}'.\r\n" +
        "Leichter zu töten als zu heilen.",
      "坏的块引用 {0} '{1}' 在 '{2}' 内。\r\n" +
        "杀死比治愈更容易。",
      "Referencia de bloque incorrecta {0} '{1}' dentro de '{2}'.\r\n" +  // ES
        "Más fácil de eliminar que de curar.",
      "Mauvaise référence de bloc {0} '{1}' à l'intérieur de '{2}'.\r\n" +  // FR
        "Plus facile à supprimer qu'à réparer.",
      "Hatalı blok referansı {0} '{1}' '{2}' içinde.\r\n" +  // TR
        "Tedavi etmekten öldürmek daha kolay."};

  }
}