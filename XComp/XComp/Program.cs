using System;

namespace XComp
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Test game = new Test())
            {
                game.Run();
            }
        }
    }
#endif
}

