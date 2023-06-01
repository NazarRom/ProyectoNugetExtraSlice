using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNugetExtraSlice.Models
{
    public class ModelCorreoLamdba
    {
        public string Asunto { get; set; }

        public string Email { get; set; }

        public string Body { get; set; }

        public List<Attachment>? Attachments { get; set; }
    }
}
