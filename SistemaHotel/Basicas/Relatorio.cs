using System;

namespace SistemaHotel.Modelo.Basicas;

public class RelatorioModelo
{
    //Deve ser colocado a data
    public int RelatorioID { get; set; } 
    public int TotalQuartos { get; set; }
    public int TotalReservas { get; set; }
    public decimal Faturamento { get; set; }

    public RelatorioModelo(int relatorioID, int totalQuartos, int totalReservas, decimal faturamento)
    {
        RelatorioID = relatorioID;
        TotalQuartos = totalQuartos;
        TotalReservas = totalReservas;
        Faturamento = faturamento;
    }

    public RelatorioModelo() {}
    public override string ToString() {
        return $"[{RelatorioID}, {TotalQuartos}, {TotalReservas}, {Faturamento}]";
    }

    public override bool Equals(object? obj)
    {
        return obj is RelatorioModelo modelo &&
               RelatorioID == modelo.RelatorioID &&
               TotalQuartos == modelo.TotalQuartos &&
               TotalReservas == modelo.TotalReservas &&
               Faturamento == modelo.Faturamento;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(RelatorioID, TotalQuartos, TotalReservas, Faturamento);
    }
}
