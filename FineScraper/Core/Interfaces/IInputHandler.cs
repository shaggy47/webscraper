using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FineScraper.Core.Interfaces
{
    interface IInputHandler : IDisposable
    {
        /// <summary>
        /// Property for accessing contents of a loaded resource.
        /// </summary>
        string source { get; }

        /// <summary>
        /// Method loads given resource into memory
        /// </summary>
        /// <param name="uri">Path of a resource to be loaded. It can also signify file path, or a url of a network resource.</param>
        /// <returns></returns>
        bool Load(string uri);


    }
}
