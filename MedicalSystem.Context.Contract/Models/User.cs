using MedicalSystem.Context.Contract.Enums;

namespace MedicalSystem.Context.Contract.Models
{
    /// <summary>
    /// Пользователь системы
    /// </summary>
    /// <remarks>
    /// Пользователем является как пациент, так и медицинский работник
    /// </remarks>
    public class User
    {
        public string Fullname { get; set; } = null!;
        public UserType Role { get; set; }
    }
}
