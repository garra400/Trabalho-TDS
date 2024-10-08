using System;

namespace SistemaHotel.Modelo.Basicas;

public class ReservaModelo
{
    public int ReservaID { get; set; }
    public DateTime DataCheckIn { get; set; }
    public DateTime DataCheckOut { get; set; }


    public ReservaModelo(int reservaID, DateTime dataCheckIn, DateTime dataCheckOut)
    {
        ReservaID = reservaID;
        DataCheckIn = dataCheckIn;
        DataCheckOut = dataCheckOut;
    }

    public ReservaModelo() {}
    public override string ToString()
    {
        return $"[{ReservaID}, {DataCheckIn}, {DataCheckOut}]";
    }

    public override bool Equals(object? obj)
    {
        return obj is ReservaModelo modelo &&
               ReservaID == modelo.ReservaID &&
               DataCheckIn == modelo.DataCheckIn &&
               DataCheckOut == modelo.DataCheckOut;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ReservaID, DataCheckIn, DataCheckOut);
    }
}
