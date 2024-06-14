// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/

namespace AVC
{
  public static class 
  BoxFromTableL
  {
    public static readonly string[,] BoxFromTableNames = {
/* 0 */ { CommandL.BoxFromTable[0], CommandL.BoxFromTable[1], CommandL.BoxFromTable[2], CommandL.BoxFromTable[3], CommandL.BoxFromTable[4] },
/* 1 */ { CommandL.BoxFromTable[0], CommandL.BoxFromTable[1], CommandL.BoxFromTable[2], CommandL.BoxFromTable[3], CommandL.BoxFromTable[4] },
        };


    public static readonly string[] SelectSolidOrBlock = {
      "",
      "Выберите солиды-боксы в габарит стены или блоки готовых стен.",
      "",
      "",
      ""};
    public static readonly string[] LineWeightErr = {
      "",
      "Задан несуществующий вес линий {0}",
      "",
      "",
      ""};
    public static readonly string[] LineTypeErr = {
      "",
      "Задан несуществующий тип линий {0}",
      "",
      "",
      ""};
    public static readonly string[] ColorErr = {
      "",
      "Не удалось распознать цвет {0}",
      "",
      "",
      ""};
    public static readonly string[] PLineConversionErr = {
      "",
      "Не удалось построить полилинию по заданным точкам",
      "",
      "",
      ""};
  }
}
