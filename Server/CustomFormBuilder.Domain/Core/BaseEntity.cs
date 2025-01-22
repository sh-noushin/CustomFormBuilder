using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomFormBuilder.Domain.Core
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
    }
}
