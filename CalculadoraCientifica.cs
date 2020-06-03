using System;

namespace CalculadoraDesafio
{
    public class CalculadoraCientifica : Calculadora
    {
        public int media;

        public int tirarMedia(){
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int media = (num1 + num2)/2 ;
            return media;
        }
    }
}