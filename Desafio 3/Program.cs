using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int resultadoSoma = 0;

            //Digite o seu código aqui
            while(x != 0){
                if(x % 2 == 0){
                    for(int i = 0; i < 5; i++){
                        resultadoSoma = resultadoSoma + x;
                        x = x + 2;
                    }
                }
                else{
                    x = x+1;
                    for(int i = 0; i < 5; i++){
                        resultadoSoma = resultadoSoma + x;
                        x = x + 2;
                    }
                }
                Console.WriteLine(resultadoSoma);
                x = int.Parse(Console.ReadLine());
                resultadoSoma = 0;
            }

            }
        }
    }