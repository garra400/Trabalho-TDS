using System;

namespace SistemaHotel.Modelo.Basicas;

public class UsuarioModelo
{
    public int UsuarioID { get; set; }
    public string? RG { get; set; }
    public string? CPF { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public string? Endereco { get; set; }


    public UsuarioModelo(int usuarioID, string? rG, string? cPF, string? nome, string? email, string? telefone, string? endereco)
    {
        UsuarioID = usuarioID;
        RG = rG;
        CPF = cPF;
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Endereco = endereco;
    }

    public UsuarioModelo() {}
    public override string ToString()
    {
        return $"[{UsuarioID}, {RG}, {CPF}, {Email}, {Telefone}, {Endereco}]";
    }

    public override bool Equals(object? obj)
    {
        return obj is UsuarioModelo modelo &&
               UsuarioID == modelo.UsuarioID &&
               RG == modelo.RG &&
               CPF == modelo.CPF &&
               Nome == modelo.Nome &&
               Email == modelo.Email &&
               Telefone == modelo.Telefone &&
               Endereco == modelo.Endereco;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(UsuarioID, RG, CPF, Nome, Email, Telefone, Endereco);
    }
}
