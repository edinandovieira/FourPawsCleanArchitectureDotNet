using FourPawsCleanArchitecture.Application.Interfaces;
using FourPawsCleanArchitecture.Domain.Entities;

namespace FourPawsCleanArchitecture.Application.Services
{
    public class FeriadoService : IFeriadoService
    {
        private readonly IFeriadoRepository _feriadorepository;

        public FeriadoService(IFeriadoRepository feriadorepository)
        {
            _feriadorepository = feriadorepository;
        }

        public Feriado CreateHolyday(Feriado feriado)
        {
            feriado.Data = feriado.Data.Date;
            _feriadorepository.CreateHolyday(feriado);
            return feriado;
        }

        public List<Feriado> GetAllHolyday()
        {
            return _feriadorepository.GetAllHolyday();
        }

        public Feriado GetHolyday(Guid codigo)
        {
            return _feriadorepository.GetHolyday(codigo);
        }

        public Feriado RemoveHolyday(Feriado feriado)
        {
            _feriadorepository.RemoveHolyday(feriado);
            return feriado;
        }

        public Feriado UpdateHolyday(Feriado feriado)
        {
            _feriadorepository.UpdateHolyday(feriado);
            return feriado;
        }
    }
}
