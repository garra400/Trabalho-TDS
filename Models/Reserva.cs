using System;

namespace Models;

public class Reserva
{
    public int Id { get; set; }

    public Quarto Quarto { get; set; }

    public DateTime DataCheckIn { get; set; }

    public DateTime DataCheckOut { get; set; }

    public string Usuario { get; set; }

}
