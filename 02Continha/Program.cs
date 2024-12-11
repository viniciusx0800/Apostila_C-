using System;

static double calc (double a, double b , double c, double d, double e, double f)
{
    var calculo = ((a+b)*(c-d)*(e+f))/2 ;

    return calculo; 
}
var soma1 = calc (7,3,15,30.4,0,2);
var soma2 = calc (1,2,10,5.0,2,2);


System.Console.WriteLine("Sou fera nas continhas e o resultado é " + soma1);
System.Console.WriteLine("Sou fera nas continhas e o resultado é " + soma2);

