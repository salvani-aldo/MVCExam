using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public static class ModelMapper
    {
        /// <summary>
        /// For mapping from WEB service model to MVC model
        /// </summary>
        /// <typeparam name="Tmodel">Destination</typeparam>
        /// <typeparam name="TMapModel">Source</typeparam>
        /// <param name="input"></param>
        /// <returns></returns>
        public static Tmodel MapToModel<Tmodel, TMapModel>(this TMapModel input)
        {
            Tmodel result = AutoMapper.Mapper.Map<TMapModel, Tmodel>(input);

            return result;
        }
    }
}
