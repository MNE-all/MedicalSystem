using MedicalSystem.Context.Contract.Enums;

namespace MedicalSystem.Context.Contract.Models
{
    /// <summary>
    /// Сущность документа
    /// </summary>
    /// <remarks>
    /// Хранит медицинский документ пациента
    /// </remarks>
    public class Document : BaseEntity
    {
        public byte[] File { get; set; } = null!;
        public User Owner { get; set; } = null!;
        public DocumentType Type { get; set; }
    }
}
