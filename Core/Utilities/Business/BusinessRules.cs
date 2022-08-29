using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            List<IResult> results = new List<IResult>();
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                     results.Add(logic);
                }
            }
            return null;
        }
    }
}
