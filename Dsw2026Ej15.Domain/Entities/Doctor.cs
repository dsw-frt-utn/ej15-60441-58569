using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej15.Domain.Entities;

public class Doctor : BaseEntity
{
    string Name { get; init; }
    string LicenseNumber { get; init; }
    public bool IsActive { get; set; }
    public Speciality Speciality { get; private set; }

    public Doctor(string name, string licenseNumber, bool isActive, Speciality speciality, Guid id) : base(id)
    {
        Name = name;
        LicenseNumber = licenseNumber;
        IsActive = isActive;
        Speciality = speciality;
    }
}
