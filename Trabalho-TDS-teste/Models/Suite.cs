using System;



namespace Models;

public class Suite : Quarto
{
    public override decimal CalcularPreco()
    {
        return Preco + 100;
    }
}
