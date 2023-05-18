﻿using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Interfaces
{
    public interface IFeriadoService
    {
        Feriado CreateHolyday(Feriado feriado);
        Feriado GetHolyday(Guid codigo);
        List<Feriado> GetAllHolyday();
        Feriado UpdateHolyday(Feriado feriado);
        Feriado RemoveHolyday(Feriado feriado);
    }
}
