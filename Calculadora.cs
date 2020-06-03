using System;

namespace CalculadoraDesafio
{
    public class Calculadora
    {
        public int Soma;
        public int Subtracao;
        public int Divisao;
        public int Multiplicacao;

/// <summary>
/// Formula para soma 
/// </summary>
/// <returns>resultado da soma</returns>
        public double somar(){
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int Soma = num1 + num2;
            
            return Soma;
        }
/// <summary>
/// Formula para subtração
/// </summary>
/// <returns>resultado da subtração</returns>
        public double subtrair(){
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int Subtracao = num1 - num2;
            
            return Subtracao;
        }

/// <summary>
/// Formula para divisão
/// </summary>
/// <returns>resultado da divisão</returns>        
        public double dividir(){
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int Divisao = num1 / num2;
            
            return Divisao;
        }

/// <summary>
/// Formula para multiplicação
/// </summary>
/// <returns>Resultado da multiplicação</returns>        
        public double multiplicar(){
            
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int Multiplicacao = num1 * num2;
            
            return Multiplicacao;
        }
    }
}