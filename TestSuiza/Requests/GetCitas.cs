﻿using MediatR;
using System.ComponentModel.DataAnnotations;
using TestSuiza.Models;

namespace TestSuiza.DTO
{
    public class GetCitas: IRequest<CitaListItem>
    {
        public string NumeroDocumento { get; set; }

    }
}
