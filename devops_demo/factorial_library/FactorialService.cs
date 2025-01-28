namespace factorial_library;

public class FactorialService
{
    public static int factorial_function(int n)
    {
        if(n == 0 || n == 1){
            return 1;
        } else{
            return n * factorial_function(n-1);
        }
    }

}
