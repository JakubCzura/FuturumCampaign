using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuturumCampaign.Validators
{
    public interface IValidator<T>
    {
        bool Validate(T value);
    }
}
