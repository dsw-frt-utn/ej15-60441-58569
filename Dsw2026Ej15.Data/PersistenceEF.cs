using Dsw2026Ej15.Data.Migrations;
using Dsw2026Ej15.Domain.Entities;
using Dsw2026Ej15.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej15.Data;

public class PersistenceEF : IPersistence
{
    private readonly Dsw2026Ej15DbContext _context;
    public PersistenceEF(Dsw2026Ej15DbContext context)
    {
        _context = context;
    }
    public Task AddDoctor(Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Doctor>> GetAllDoctors()
    {
        throw new NotImplementedException();
    }

    public Task<Doctor?> GetDoctor(Guid doctorId)
    {
        throw new NotImplementedException();
    }

    public Task<Speciality?> GetSpecialityById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDoctor(Doctor doctor)
    {
        throw new NotImplementedException();
    }
}
