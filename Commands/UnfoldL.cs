using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVC
{
  public static class UnfoldL
  {
    public static readonly string[][] UnfoldStyleNames = {
/* 0 */ CommandL.Unfold,
/* 1 */ CommandL.Unfold, };

    public static readonly string[]  CurrentUnfoldStyle = {
      "  Unfold-style will be used: {0}",
      "  Будет использован стиль развертки: {0}",
      "  Unfold-stile sarà usato: {0}",
      "  Der Unfold-stil wird verwendet: {0}",
      "  将使用嵌套(Unfold)样式：{0}",
      "  Se utilizará el estilo Unfold: {0}",  // ES
      "  Le style Unfold sera utilisé : {0}",  // FR
      "  Unfold stili kullanılacak: {0}"};  // TR

    public static readonly string[] InsertPointQuery = {
      "Insertion point of the unfolded contour",
      "Точка вставки развертки",
      "Punto di inserimento del contorno sviluppato",
      "Einfügepunkt der Abwicklung",
      "展开轮廓的插入点",
      "Punto de inserción del contorno desarrollado",  // ES
      "Point d'insertion du contour développé",  // FR
      "Açılım konturunun ekleme noktası"};  // TR

    public static readonly string[] Result = {
      "  Curves created: {0}",
      "  Создано кривых: {0}",
      "  Curve create: {0}",
      "  Erstellte Kurven: {0}",
      "  已创建曲线：{0}",
      "  Curvas creadas: {0}",  // ES
      "  Courbes créées : {0}",  // FR
      "  Oluşturulan eğriler: {0}"};  // TR

    public static readonly string[] AreaDiff = {
      "  Face area {0}, unfolded area {1}, difference {2} ({3}%)",
      "  Площадь поверхности {0}, площадь развертки {1}, отличие {2} ({3}%)",
      "  Area della faccia {0}, area dello sviluppo {1}, differenza {2} ({3}%)",
      "  Flächeninhalt {0}, Abwicklungsfläche {1}, Abweichung {2} ({3}%)",
      "  面面积 {0}，展开面积 {1}，差值 {2}（{3}%）",
      "  Área de la cara {0}, área desarrollada {1}, diferencia {2} ({3}%)",  // ES
      "  Aire de la face {0}, aire du développement {1}, écart {2} ({3}%)",  // FR
      "  Yüzey alanı {0}, açılım alanı {1}, fark {2} ({3}%)"};  // TR

    public static readonly string[] FaceNotSupported = {
      "  This face can not be unfolded. Only planar and cylindrical faces are supported.",
      "  Эту поверхность развернуть невозможно. Поддерживаются только плоские и цилиндрические поверхности.",
      "  Questa faccia non può essere sviluppata. Sono supportate solo facce piane e cilindriche.",
      "  Diese Fläche kann nicht abgewickelt werden. Nur ebene und zylindrische Flächen werden unterstützt.",
      "  无法展开此面。仅支持平面和圆柱面。",
      "  Esta cara no se puede desarrollar. Solo se admiten caras planas y cilíndricas.",  // ES
      "  Cette face ne peut pas être développée. Seules les faces planes et cylindriques sont prises en charge.",  // FR
      "  Bu yüzey açılamıyor. Yalnızca düzlemsel ve silindirik yüzeyler desteklenir."};  // TR
  }
}
