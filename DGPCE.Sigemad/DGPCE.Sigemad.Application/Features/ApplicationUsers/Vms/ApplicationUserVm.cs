﻿

namespace DGPCE.Sigemad.Application.Features.ApplicationUsers.Vms
{
    public class ApplicationUserVm
    {
        public new Guid Id { get; set; }

        public Guid IdentityId { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; } 

        public string Email { get; set; } 
        public string Telefono { get; set; }
    }
}