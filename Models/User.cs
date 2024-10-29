


namespace Solucao.Models; 

public class UserModel
{
    public int UserID { get; set; }
    public string? UserRG { get; set; }
    public string? UserCPF { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public string? Password { get; set; } // Nova propriedade para senha

    public UserModel(int userID, string? userRG, string? userCPF, string? name, string? email, string? phone, string? address, string? password)
    {
        UserID = userID;
        UserRG = userRG;
        UserCPF = userCPF;
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
        Password = password;
    }

    public UserModel() {}
    public override string ToString()
    {
        return $"[{UserID}, {UserRG}, {UserCPF}, {Email}, {Phone}, {Address}]";
    }

    public override bool Equals(object? obj)
    {
        return obj is UserModel model &&
               UserID == model.UserID;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(UserID);
    }
}
