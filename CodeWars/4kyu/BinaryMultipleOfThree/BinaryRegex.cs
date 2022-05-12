using System.Text.RegularExpressions;

namespace CodeWars._4kyu.BinaryMultipleOfThree;

public class BinaryRegex {

    /***
     * ^ - begin, exclude ' '(space)
     * ( ) - group
     * "*" - 0 or more matches
     * $ - end, exclude ' '(space)
     */
    
    public static Regex MultipleOf3() {
        // Regular expression that matches binary inputs that are multiple of 3
        return new Regex("^(0*(1(01*0)*1)*)*$");
    }
}