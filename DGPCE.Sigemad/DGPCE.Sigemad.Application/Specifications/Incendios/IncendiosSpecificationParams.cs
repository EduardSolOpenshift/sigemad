﻿namespace DGPCE.Sigemad.Application.Specifications.Incendios;

public class IncendiosSpecificationParams: SpecificationParams
{
    public int? Id { get; set; }
    public int? IdTerritorio { get; set; }
    public int? IdPais { get; set; }
    public int? IdCcaa { get; set; }
    public int? IdProvincia { get; set; }
    public int? IdMunicipio { get; set; }
    public int? IdEstadoSuceso { get; set; }
    public int? IdEstadoIncendio { get; set; }
    public int? IdNivelGravedad { get; set; }
    public int? IdSuperficieAfectada { get; set; }
    public int? IdMovimiento { get; set; }
    public int? IdComparativoFecha { get; set; }
    public DateOnly? FechaInicio { get; set; }
    public DateOnly? FechaFin { get; set; }

}