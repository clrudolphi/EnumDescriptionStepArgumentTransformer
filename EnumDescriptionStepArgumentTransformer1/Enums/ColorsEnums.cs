using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDescriptionStepArgumentTransformer1
{
  
    public enum Colors { 
        [Description("Magenta")] Red,
        White,
        [Description("Navy")] Blue
    }

}
