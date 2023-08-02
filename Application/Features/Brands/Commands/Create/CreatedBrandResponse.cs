using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;

public class CreatedBrandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public DateTime CreatedDate { get; set; }
}
