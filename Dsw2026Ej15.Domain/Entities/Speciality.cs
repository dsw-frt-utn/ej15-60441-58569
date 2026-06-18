namespace Dsw2026Ej15.Domain.Entities;

public class Speciality : BaseEntity
{
    string Name { get; init; }
    string Description { get; init; }

    public Speciality (string name, string description, Guid id ) : base(id)
    {
        Name = name;
        Description = description;
    } 


}

