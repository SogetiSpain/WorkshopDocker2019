using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sogeti.WSDocker2019.ComposeService.Models
{
    public class Catalog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }


    }
}
