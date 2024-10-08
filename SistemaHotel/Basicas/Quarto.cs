using System;

namespace SistemaHotel.Modelo.Basicas;

public class QuartoModelo
{


    public int QuartoID { get; set; }
    public string? Desc { get; set; }
    public string? Preco { get; set; }
    public bool Disponibilidade { get; set; }

    public QuartoModelo(int quartoID, string? desc, string? preco, bool disponibilidade)
    {
        QuartoID = quartoID;
        Desc = desc;
        Preco = preco;
        Disponibilidade = disponibilidade;
    }

    public QuartoModelo() {}

    public override string ToString()
    {
        return $"[{QuartoID}, {Desc}, {Preco}]";
    }

    public override bool Equals(object? obj)
    {
        return obj is QuartoModelo modelo &&
               QuartoID == modelo.QuartoID &&
               Desc == modelo.Desc &&
               Preco == modelo.Preco &&
               Disponibilidade == modelo.Disponibilidade;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(QuartoID, Desc, Preco, Disponibilidade);
    }
}
