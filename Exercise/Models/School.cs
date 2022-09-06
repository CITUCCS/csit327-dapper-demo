using Newtonsoft.Json;

namespace DapperExer1.Models
{
    internal class School
    {
        // TODO: Fill with properties

        /// <summary>
        /// Prints this object as JSON
        /// </summary>
        /// <returns>json string representation of this object</returns>
        public override string ToString()
        {
            return JsonConvert.ToString(this);
        }
    }
}
