using Dsw2026Ej15.Data.Dtos;
using Dsw2026Ej15.Domain.Entities;
using Dsw2026Ej15.Domain.Interfaces;
using System.Text.Json;

namespace Dsw2026Ej15.Data;

public class PersistenceInMemory : IPersistence
{
    private List<Speciality> _specialities = [];
    private List<Doctor> _doctors = [];
    public PersistenceInMemory()
    {
        LoadSpecialities();
    }
    public void AddDoctor(Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public void DeleteDoctor(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Doctor> GetAllDoctors()
    {
        throw new NotImplementedException();
    }

    public Doctor? GetDoctor(Guid doctorId)
    {
        throw new NotImplementedException();
    }

    public Speciality? GetSpecialityById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Doctor SetDoctor(Doctor doctor)
    {
        throw new NotImplementedException();
    }
    private void LoadSpecialities()
    {
        
    }
}
