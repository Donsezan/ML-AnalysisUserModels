using System;
using System.Collections.Generic;

namespace WindowsFormsMLTest
{
    public static class ProgramEnvironment
    {
        public static string MlServiceLink { get; set; }
        public static List<Func<List<BlobDataContract>, List<BlobDataContract>>> ListOfRule { get; set; }
        public static BlobDataContract FiltrState { get; set; }
        public static bool[] FilterBoolState { get; set; }
    }
}