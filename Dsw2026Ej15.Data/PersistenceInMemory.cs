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
        _doctors.Add(doctor);
    }
    public List<Doctor> GetAllDoctors()
    {
        return _doctors;
    }

    public Doctor? GetDoctor(Guid doctorId)
    {
        return _doctors.FirstOrDefault(d => d.id == doctorId);
    }

    public Speciality? GetSpecialityById(Guid id)
    {
        return _specialities.FirstOrDefault(s => s.id == id);
    }

    public void UpdateDoctor(Guid doctorId)
    {
        var encontrado = _doctors.FirstOrDefault(d => d.id == doctorId);
        encontrado.IsActive = false;    
    }
    private void LoadSpecialities()
    {
        try
        {
            string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Sources", "specialities.json");
            var json = File.ReadAllText(jsonPath);
            var specialities = JsonSerializer.Deserialize<List<SpecialityDto>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? [];
            _specialities = [.. specialities.Select(s => new Speciality(s.Name, s.Description, s.Id))];
        }
        catch (Exception ex)
        {

        }
    }
}
