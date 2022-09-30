using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAuto {
    public interface Activity {
        /// <summary>
        /// Determines if this activity is currently active and should receive a call to <see cref="Run"/>.
        /// </summary>
        public bool IsActive();

        /// <summary>
        /// Called when this Activity activates due to <see cref="IsActive"/>
        /// </summary>
        /// <returns>Return true to prevent further Activities from executing.</returns>
        public bool Run();

    }
}
