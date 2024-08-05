using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator{
    public class Factorial : IBinaryOperator{
        public static float Eval(float lhs, float rhs){
            int factorial = 1;

            for (int i = 1; i <= lhs; i++)

            {

                factorial *= i;

            }
            return factorial;

        }
        
    }
}