using System;
    class Program
    {
        //atributos
        public double peso, altura;
        
         //calculo
         public double calculo()
         {
             return peso / (altura * altura);
         }

         //situacao
         public string situacao(double imc)
         {
             //variavel
             string returno;

             //condicional
            if (imc < 18.5)
            {
                returno = "abaixo do peso";
            }
            else if (imc < 25)
            {
                returno = "peso normal";
            }
            else if (imc < 30)
            {
                returno = "acima do peso";
            }
            else if (imc < 35)
            {
                returno = "obesidade I";
            }
            else if (imc < 40)
            {
                returno = "obesidade II";
            }
            else 
            {
                returno = "obesidade III";
            }

            //retorno
            return returno;

            //mensagem
            void mensagem()
            {
                //obter calculo
                double obterterCalculo = calculo();

                //ober situacao
                string obterSiruacao = situacao(obterterCalculo);

                //mensagem
                Console.WriteLine($"seu imc é de {oberCalculo}");
                Console.WriteLine($"situação é de {oberSituacao}");
            }


         }
    }
