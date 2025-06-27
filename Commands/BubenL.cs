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
      "视图 {0} 没有数据源"};
    public static readonly string[] Updated = {
      "Updated blocks and solids: {0}",
      "Обновлено блоков и солидов: {0}",
      "Blocchi e solidi aggiornati: {0}",
      "Aktualisierte Blöcke und Volumenkörper: {0}",
      "已更新的块和实体：{0}"};
    public static readonly string[] UpdatingAllView = {
      "Update ALL ModelDoc views on all drawing sheets",
      "Обновление ВСЕХ видов ModelDoc на всех листах чертежа",
      "Aggiorna TUTTE le viste ModelDoc su tutti i fogli di disegno",
      "Aktualisieren Sie ALLE ModelDoc-Ansichten auf allen Zeichenblättern",
      "更新所有图纸上的所有 ModelDoc 视图"};
    public static readonly string[] Acad2017 = {
      "Fixing mirrored blocks only works in early releases of AutoCAD 2017 and does nothing in other versions.",
      "Исправление зеркальных блоков работает только в ранних релизах AutoCAD 2017 и ничего не дает в других версиях.",
      "La correzione dei blocchi specchiati funziona solo nelle prime versioni di AutoCAD 2017 e non ha alcun effetto nelle altre versioni.",
      "Das Reparieren gespiegelter Blöcke funktioniert nur in frühen Versionen von AutoCAD 2017 und hat in anderen Versionen keine Auswirkungen.",
      "修复镜像块仅适用于 AutoCAD 2017 的早期版本，而在其他版本中不起作用。"};
    public static readonly string[] ViewCount = {
      "Will process {0} views",
      "Будет обработано видов {0}",
      "Elaborerà {0} visualizzazioni",
      "Verarbeitet {0} Ansichten",
      "将处理 {0} 次查看" };
    public static readonly string[] Processing = {
      "Processing views",
      "Обработка видов",
      "Elaborazione di viste",
      "Verarbeitung von Ansichten",
      "处理个视图" };
    public static readonly string[] ViewBorderPointQuery = {
      "Click anywhere above the broken ModelDoc view",
      "Кликните по любой точке над сломанным видом ModelDoc",
      "Fare clic in un punto qualsiasi sopra la vista ModelDoc interrotta",
      "Klicken Sie irgendwo über der beschädigten ModelDoc-Ansicht",
      "单击损坏的 ModelDoc 视图上方的任意位置"  };
    public static readonly string[] NoViewAtPoint =    {
      "No visible ModelDoc view found below the given point.",
      "Не найден видимый вид ModelDoc под заданной точкой.",
      "Nessuna vista ModelDoc visibile trovata sotto il punto indicato.",
      "Unterhalb des angegebenen Punkts wurde keine sichtbare ModelDoc-Ansicht gefunden.",
      "在给定点下方未找到可见的 ModelDoc 视图。"    };
    public static readonly string[] LayoutViewsKW = {
      "SHEETViews",
      "ВИДЫЛиста",
      "VISUalizzazioniFogli",
      "ANSICHTENBlätter",
      "此表中的所有物种(SHEET)" };
    public static readonly string[] AllViewsKW = {
      "ALLViews",
      "ВСЕВиды",
      "TUTTELeVisualizzazioni",
      "ALLEAnsichten",
      "所有图纸上的所有视图(ALLV)"  };
    public static readonly string[] Acad2017KW = {
      "ACAD2017" };
    public static readonly string[] ChangeInBlockKW = {
      "CHANGEInBlock",
      "ИЗМЕНИТЬВБлоке",
      "CAMBIANelBlocco",
      "ÄNDERNImBlock",
      "块内固体的替换(CHA)"  };
    public static readonly string[] CleanBodyKW = {
      "CLEANBody",
      "ОЧИСТИТЬТело",
      "PULISCICorpo",
      "REINIGENKörper",
      "清理模型中的固体(CLE)"  };
    public static readonly string[] Acad2017Query = {
      "Adjust the scale of mirror blocks? (only helps in AutoCAD 2017)",
      "Подправить масштаб зеркальных блоков ? (помогает только в AutoCAD 2017)",
      "Correggere la scala dei blocchi specchiati? (funziona solo in AutoCAD 2017)",
      "Skalierung von gespiegelten Blöcken reparieren? (funktioniert nur in AutoCAD 2017)",
      "修复镜像块的比例？（仅适用于 AutoCAD 2017）" };
    public static readonly string[] ChangeInBlockQuery = {
      "Replace 3D solids with their copies inside all blocks?",
      "Подменить 3D-солиды на их копии внутри всех блоков?",
      "Sostituire i solidi 3D con le loro copie all'interno di tutti i blocchi?",
      "3D-Körper in allen Blöcken durch Kopien ersetzen?",
      "在所有块中将 3D 实体替换为其副本？" };
    public static readonly string[] CleanBodyQuery = {
      "Call the procedure for cleaning 3D solids in the model (removing unnecessary faces) ?",
      "Вызвать процедуру очистки 3D-солидов в модели (удаления лишних граней) ?",
      "Chiamare la procedura di pulizia dei solidi 3D nel modello (rimozione di facce inutili) ?",
      "Rufen Sie die 3D-Körper-Reinigungsprozedur im Modell auf (Entfernen unnötiger Flächen) ?",
      "调用清理模型中的 3D 实体（删除不必要的面）的程序？" };
    public static readonly string[] MirrorBlock = {
      "Mirrored block reference '{0}' inside '{1}'. Scale = {2}",
      "Отзеркаленный блок '{0}' внутри '{1}'. Масштаб = {2}",
      "Riferimento al blocco speculare '{0}' all'interno di '{1}'. Scala = {2}",
      "Gespiegelte Blockreferenz '{0}' innerhalb von '{1}'. Maßstab = {2}",
      "已将块引用“{0}”镜像到“{1}”内。比例 = {2}"};
    public static readonly string[] OverRef = {
      "  Over reference on '{0}' inside '{1}'. Scale = {2}",
      "  Другая ссылка на '{0}' внутри '{1}'. Масштаб = {2}",
      "  Riferimento su '{0}' all'interno di '{1}'. Scala = {2}",
      "  Überreferenz auf '{0}' innerhalb von '{1}'. Maßstab = {2}",
      "  “{1}”内“{0}”过度引用。比例 = {2}"};
    public static readonly string[] SetScale = {
      "  Set scale {0}",
      "  Установлен масштаб {0}",
      "  Scala impostata su {0}",
      "  Maßstab eingestellt auf {0}",
      "  比例设置为 {0}"};
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
        "杀死比治愈更容易。"  };
  
  }
}

