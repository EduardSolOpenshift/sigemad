﻿using DGPCE.Sigemad.Application.Contracts.Persistence;
using DGPCE.Sigemad.Domain.Modelos;
using MediatR;

namespace DGPCE.Sigemad.Application.Features.ProcedenciasDestinos.Queries.GetProcedenciasDestinosList
{
    public class GetProcedenciasDestinosListQueryHandler : IRequestHandler<GetProcedenciasDestinosListQuery, IReadOnlyList<ProcedenciaDestino>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetProcedenciasDestinosListQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IReadOnlyList<ProcedenciaDestino>> Handle(GetProcedenciasDestinosListQuery request, CancellationToken cancellationToken)
        {
            var procedenciasDestinos = await _unitOfWork.Repository<ProcedenciaDestino>().GetAllAsync();
            return procedenciasDestinos;
        }
    }
}