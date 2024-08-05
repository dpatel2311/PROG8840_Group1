namespace Calculator{
    public class Evaluator{
        public static float Eval(string Operator, params float[] Operands){
            float result;
            switch(Operator){
                case "+":
                    result = Add.Eval(Operands[0], Operands[1]);
                    break;
                case "-":
                    result = Subtract.Eval(Operands[0], Operands[1]);
                    break;
                case "*":
                    result = Multiply.Eval(Operands[0], Operands[1]);
                    break;
                case "/":
                    result = Divide.Eval(Operands[0], Operands[1]);
                    break;
                case "@":
                    result = Square.Eval(Operands[0], Operands[1]);
                    break;
                case "%":
                    result = Percentage.Eval(Operands[0], Operands[1]);
                    break;
                case "^":
                    result = Exponent.Eval(Operands[0], Operands[1]);
                    break;
                case "$":
                    result = Absolute.Eval(Operands[0], Operands[1]);
                    break;
                case "~":
                    result = Round.Eval(Operands[0], Operands[1]);
                    break;
                case "!":
                    result = Factorial.Eval(Operands[0], Operands[1]);
                    break;
                case "`":
                    result = Fahrenheit.Eval(Operands[0], Operands[1]);
                    break;
                default:
                    throw new Exception("unimplemented");
            }
            return result;
        }
    }
}