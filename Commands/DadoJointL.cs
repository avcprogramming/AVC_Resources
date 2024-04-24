// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class
  DadoJointL
  {
    public static readonly string[] Select = {
      "  Select assembly consisting of Solid",
      "  Выберите сборку из деталей типа 3DSolid",
      "  Scegliere un assemblaggio da 3DSolid parts",
      "  Wählen Sie eine Baugruppe aus 3DSolid-Teilen",
      "  选择由零件组成的装配体" };
    public static readonly string[] Nothing = {
      "  Nothing to cut",
      "  Нечего вырезать",
      "  Niente da tagliare",
      "  Nichts zu schneiden",
      "  没什么可剪的" };
    public static readonly string[] Depth = {
      "\n  Dado depth",
      "\n  Глубина паза",
      "\n  Profondità della scanalatura",
      "\n  Rillentiefe",
      "\n  给定深度" };
    public static readonly string[] Finding = {
      "Finding contacts",
      "Поиск контактов",
      "Cerca contatti",
      "Suche nach Kontakten",
      "查找联系人" };
    public static readonly string[] CombinationsErr = {
      "  Too many combinations",
      "  Слишком много комбинаций",
      "  Troppe combinazioni",
      "  Zu viele Kombinationen",
      "  组合太多" };
    public static readonly string[] Least2Err = {
      "  Requires at least 2 solids",
      "  Требуется хотя бы 2 солида",
      "  Richiede almeno 2 solidi",
      "  Benötigt mindestens 2 Volumenkörper",
      "  至少需要 2 个固体" };
    public static readonly string[] Skipping = {
      "  Discovered contact the same planes. Skipping.",
      "  Обнаружен контакт одинаковыми плоскостями. Пропускаем.",
      "  Contatto rilevato dagli stessi aerei. La signorina.",
      "  Kontakt von denselben Flugzeugen erkannt. Überspringen.",
      "  发现接触同一架飞机。 跳过。" };
    public static readonly string[] Contacts = {
      "  Found contacts: {0}",
      "  Найдено контактов: {0}",
      "  Contatti trovati: {0}",
      "  Gefundene Kontakte: {0}",
      "  找到的联系人：{0}" };
    public static readonly string[] Making = {
      "Making joints",
      "Изготовление соединений",
      "Produrre composti",
      "Verbindungen herstellen",
      "制作关节" };
    public static readonly string[] ContinueQuery = {
      "Error: {0}\nContinue?",
      "Ошибка: {0}\nПродолжать?",
      "Errore: {0}\nContinua?",
      "Fehler: {0}\nWeiter?",
      "错误：{0}。\n继续？" };
    public static readonly string[] JointErr = {
      "Failed to connect between parts {0} and {1}",
      "Не получилось сделать соединение между деталями {0} и {1}",
      "Impossibile connettersi tra le parti {0} e {1}",
      "Verbindung zwischen den Teilen {0} und {1} fehlgeschlagen",
      "未能在 {0} 和 {1} 部分之间连接"};
    public static readonly string[] MinAreaKW = {
      "MinArea",
      "МинПлощадь",
      "AreaMinima",
      "MinFläche",
      "最小接触面积(M)" }; //Command line option
    public static readonly string[] MinAreaQuery = {
      "  Ignore the contact area is less than:",
      "  Игнорировать контакты площадью меньше чем:",
      "  Ignora i contatti più piccoli di:",
      "  Kontakte ignorieren, die kleiner sind als:",
      "  忽略接触面积小于："};
    public static readonly string[] SmallContactErr = {
      "  Found the contact is too small. Skipping." ,
      "  Найденный контакт слишком мал. Пропускаем.",
      "  Il contatto trovato è troppo piccolo. La signorina.",
      "  Der gefundene Kontakt ist zu klein. Überspringen.",
      "  发现触点太小。 跳过。"};
    public static readonly string[] Result = {
      "  Made joints: {0}" ,
      "  Сделано соединений: {0}",
      "  Collegamenti effettuati: {0}",
      "  Verbindungen hergestellt: {0}",
      "  制作接头：{0}"};
    public static readonly string[] SettingsInfo = {
      "  Current settings: Depth = {0}, MinArea = {1}, Gap = {2}",
      "  Текущие настройки: Глубина = {0}, МинПлощадь = {1}, Зазор = {2}",
      "  Impostazioni correnti: Profondità = {0}, AreaMinima = {1}, Liquidazione = {2}",
      "  Aktuelle Einstellungen: Tiefe = {0}, Mindestfläche = {1}, Spiel = {2}",
      "  当前设置：深度 = {0}，最小接触面积 = {1}，间隙 = {2}" };
  }
}
