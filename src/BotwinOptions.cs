namespace Botwin
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// A class that allows you to provide options to configure Botwin
    /// </summary>
    public class BotwinOptions
    {
        /// <summary>
        /// Initializes <see cref="BotwinOptions"/>
        /// </summary>
        /// <param name="before">A global before handler which is invoked before all routes</param>
        /// <param name="after">A global before handler which is invoked after all routes</param>
        public BotwinOptions(Func<HttpContext, Task<bool>> before = null, Func<HttpContext, Task> after = null)
        {
            this.Before = before;
            this.After = after;
        }
        
        /// <summary>
        /// A global before handler which is invoked before all routes
        /// </summary>
        public Func<HttpContext, Task<bool>> Before { get; }

        
        /// <summary>
        /// A global before handler which is invoked after all routes
        /// </summary>
        public Func<HttpContext, Task> After { get; }
    }
}