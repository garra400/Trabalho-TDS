using System;

namespace Models;

public class QuartoLuxo : Quarto
{
    public override decimal CalcularPreco()
    {
        return Preco + 200;
    }
}
