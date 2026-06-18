using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej15.Domain.Entities;

public class BaseEntity
{
    public Guid id { get; init; }

    public BaseEntity (Guid id)
    {
        this.id = id;
    }


}
