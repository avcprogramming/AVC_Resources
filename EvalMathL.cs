// A>V>C> avc.programming@gmail.com https://sites.google.com/site/avcplugins/
namespace AVC
{

  public static class 
  EvalMathL
  {
    public static readonly string[] NoVal = {
      "No value associated with {0}",
      "Не задана переменная {0}",
      "Nessun valore associato a {0}",
      "Kein Wert mit verknüpft {0}",
      "变量 {0} 未设置"};
    public static readonly string[] ErrParsing = { 
      "Error calculating expression '{0}' : {1}",
      "Ошибка при вычислении выражения '{0}' : {1}",
      "Errore nel calcolo dell'espressione '{0}' : {1}",
      "Fehler beim Berechnen des Ausdrucks '{0}' : {1}",
      "评估表达式时出错 '{0}' : {1}"};
    public static readonly string[] ErrArg = {
      "Wrong number of arguments to operator {0}",
      "Неверное количество аргументов у оператора {0}",
      "Numero errato di argomenti per l'operatore {0}",
      "Falsche Anzahl von Argumenten für Operator {0}",
      "运算符 {0} 的参数数量无效"};
    public static readonly string[] ErrSeparator = { 
      "Syntax error (not using regional decimal separator?) {0}",
      "Синтаксическая ошибка в выражении (может перепутана точка и запятая?) {0}",
      "Errore di sintassi (non si utilizza il separatore decimale regionale?) {0}",
      "Syntaxfehler (kein regionales Dezimaltrennzeichen verwenden?) {0}",
      "表达式中的语法错误（可能点和逗号混淆了？）{0}" };
    public static readonly string[] ErrOperator = { 
      "Missing operator", 
      "Пропущен оператор", 
      "Operatore mancante", 
      "Fehlender Operator",
      "操作员跳过" };
    public static readonly string[] ErrParenthesis = { 
      "Unbalanced parenthesis", 
      "Скобки не сбалансированы", 
      "Parentesi sbilanciata", 
      "Unausgeglichene Klammern",
      "括号不平衡" };
    public static readonly string[] ErrParRequired = { 
      "Parenthesis required for arguments -> {0}", 
      "Аргумент надо ставить в скобках -> {0}",
      "Parentesi richiesta per gli argomenti -> {0}",
      "Klammer für Argumente erforderlich -> {0}",
      "参数必须在括号中。" };
    public static readonly string[] ErrSyntax = {
      "Syntax error near {0}",
      "Синтаксическая ошибка около {0}",
      "Errore di sintassi vicino a {0}",
      "Syntaxfehler in der Nähe von {0}",
      "{0} 附近的语法错误" };


  }
}
