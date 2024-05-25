using System.Globalization;

namespace ProblemaExemplo02;

public class Produto
{
    private string _nome;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, double preco, int quantidade)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;

    }

    public Produto(string nome, double preco)
    {
        _nome = nome;
        _preco = preco;
        _quantidade = 8;
    } 


    public string GetNome()
    {
        return _nome;
    }
    public void SetNome(string nome)
    {
        while (nome.Length < 2 || nome == null)
        {
            Console.WriteLine("insira um valor válido para o nome do produto");
            nome = Console.ReadLine();
        }
        _nome = nome;
    }
    public double GetPreco()
    {
        return _preco;
    }
    public int GetQuantidade()
    {
        return _quantidade;
    }

    public double ValorTotalEmEstoque()
    {
        return _preco * _quantidade;
    }
    public void AdicionaProduto(int quantidade)
    {
        _quantidade += quantidade;
    }
    public void RemoveProduto(int quantidade)
    {
        _quantidade -= quantidade;
    }

    public override string ToString()
    {
        CultureInfo cultura = CultureInfo.InvariantCulture;
        return $"Dados do Produto: {_nome}, R$ {_preco.ToString("f2", cultura)}, {_quantidade} unidades, Total R$ {ValorTotalEmEstoque().ToString("f2", cultura)}";
    }
}
