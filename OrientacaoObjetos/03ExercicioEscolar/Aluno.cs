using System;

class Aluno
{
    // Atributos
    public string nome;
    public double nota1, nota2;

    // metodos (ações)
    // metodo media
    public double media()
    {
        return (nota1 + nota2)/2;
    }

    // metodo situação
    public string situação(double media) // estamos pedindo que o metodo sitiação retorne uma media
    {
        return media >= 7 ? "aprovado" : "reprovado"; //se for (?) "aprovado, se nao (:), "reprovado"
    }
    //metodo mensagem
    public void mensagem() // vai ser void pq nao quero que a menssagem seja armazenada em nenhuma variavel
    {
        // obter media
        double obterMedia = media();

        // obter a situação
        string obterSituacao = situação(obterMedia);

        // mensagem
        Console.WriteLine($"{nome} está {obterSituacao} com media {obterMedia}");
    }



}