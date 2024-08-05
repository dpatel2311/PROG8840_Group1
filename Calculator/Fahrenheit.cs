using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator{
    public class Fahrenheit : IBinaryOperator{
        public static float Eval(float lhs, float rhs){
           
            return ((float)(lhs * 1.8))+32;
        }
        
    }
}