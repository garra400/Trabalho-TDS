namespace Models;

public abstract class Quarto
{
    public int ID { get; set; }

    public string? Tipo { get; set; }	

    public decimal Preco { get; set; }

    public bool Disponivel { get; set; }

    public abstract decimal CalcularPreco();
}
