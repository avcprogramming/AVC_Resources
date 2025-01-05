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
  /// 4 - китайский упрощенный (КНР)
  /// </summary>
  public static class
  Language
  {
    /// <summary>
    /// Код языка Windows
    /// </summary>
    public static string
    WindowsLanguage => CultureInfo.InstalledUICulture.TwoLetterISOLanguageName; // LCID использовать нельзя потому что он может быть неизвестен для некоторых комбинаций язык-регион

    /// <summary>
    /// Номер языка Windows: 
    /// 0 - английский, 1 - русский, 2 - итальянский, 3 - немецкий, 4 - китайский
    /// </summary>
    public static readonly int
    WinNum = Number(WindowsLanguage);

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
    Code(int languageNumber) => languageNumber switch
    {
      1 => "Ru",
      2 => "It",
      3 => "Ge",
      4 => "Zh",
      _ => "En"
    };

    /// <summary>
    /// LCID-код языка
    /// </summary>
    /// <param name="languageNumber">Номер языка.  0 -> Английский (по умолчанию)</param>
    /// <returns>LCID</returns>
    public static int
    Lcid(int languageNumber) => languageNumber switch
    {
      1 => 1049,
      2 => 1040,
      3 => 1031,
      4 => 2052,
      _ => 1033
    };

    /// <summary>
    /// Номер языка по его LCID независимо от региона.
    /// </summary>
    /// <param name="lcid"></param>
    /// <returns>Номера (от 0) задают порядок языков во всех массивах строк</returns>
    public static int
    Number(int lcid) => lcid switch
    {
      25 or 1049 or 2073 => 1,
      16 or 1040 or 2064 => 2,
      7 or 1031 or 2055 or 3079 or 4103 or 5127 => 3, 
      4 or 2052 or 30724 or 31748 => 4, // упрощенный китайский
      1028 or 4100 or 3076 or 5124 => 4, // традиционный китайский. 1028=Тайвань - точно традиционный. остальные вероятно традиционный, но может и упрощенный
      _ => 0
    };

    /// <summary>
    /// Номер языка по его двухбуквенному обозначению (CultureInfo.TwoLetterISOLanguageName).
    /// </summary>
    /// <param name="langID"></param>
    /// <returns>Номера (от 0) задают порядок языков во всех массивах строк</returns>
    public static int
    Number(string langID) => langID switch
    {
      "ru" => 1,
      "it" => 2,
      "ge" => 3,
      "zh" => 4,
      _ => 0
    };

  }
}
