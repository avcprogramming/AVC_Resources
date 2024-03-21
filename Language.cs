// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
// Ignore Spelling: lcid

using System.Globalization;

namespace AVC
{
  /// <summary>
  /// Список языков на которых могут работать программы AVC
  /// 0 - английский, 
  /// 1 - русский, 
  /// 2 - итальянский, 
  /// 3 - немецкий, 
  /// 4 - китайский
  /// </summary>
  public static class
  Language
  {
    /// <summary>
    /// Код языка Windows
    /// </summary>
    public static int
    WinLCID => CultureInfo.InstalledUICulture.LCID;

    /// <summary>
    /// Номер языка Windows: 
    /// 0 - английский, 1 - русский, 2 - итальянский, 3 - немецкий, 4 - китайский
    /// </summary>
    public static readonly int
    WinNum = Number(WinLCID);

    /// <summary>
    /// Названия языков написанное на этих языках (для переключения языков)
    /// </summary>
    public static readonly string[]
    Names = {
      "English",
      "Русский",
      "Italiano",
      "Deutsch",
      "简体中文" };

    /// <summary>
    /// Названия языков, как оно записано в БД в таблицу клиентов - на английском
    /// </summary>
    public static readonly string[]
    ClientLanguages = {
      "English",
      "Russian",
      "Italian",
      "German",
      "Chinese" };

    /// <summary>
    /// Названия языков MS SQL Server
    /// </summary>
    public static readonly string[]
    MsSqlLanguages = {
      "us_english",
      "русский",
      "Italiano",
      "Deutsch",
      "简体中文" };

    /// <summary>
    /// Двухбуквенный код языка
    /// </summary>
    /// <param name="languageNumber">Номер языка.  0 -> Английский (по умолчанию)</param>
    /// <returns>Двухбуквенный код языка</returns>
    public static string
    Code(int languageNumber) => languageNumber switch { 
      1 => "Ru", 
      2 => "It", 
      3 => "Ge", 
      4 => "Zh", 
      _ => "En" };

    /// <summary>
    /// LCID-код языка
    /// </summary>
    /// <param name="languageNumber">Номер языка.  0 -> Английский (по умолчанию)</param>
    /// <returns>LCID</returns>
    public static int
    Lcid(int languageNumber) => languageNumber switch {
      1 => 1049,
      2 => 1040,
      3 => 1031,
      4 => 2052, 
      _ => 1033 };

    /// <summary>
    /// Номер языка по его LCID.
    /// Номера (от 0) задают порядок языков во всех массивах строк
    /// </summary>
    /// <param name="lcid"></param>
    /// <returns>LCID</returns>
    public static int
    Number(int lcid) => lcid switch {
      1049 => 1,
      1040 => 2,
      1031 => 3,
      2052 => 4, 
      _ => 0 };

  }
}
