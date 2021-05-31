using System.Collections.Generic;
using System.Linq;
using Twelve21.PasswordStorage.Argon;
using Twelve21.PasswordStorage.Utilities;

namespace Argon2Config
{
    public class ConfigRunner
    {

        public List<Argon2CalibrationResult> GetResults(long maxTime = 1000l, int minIterations = 2, Argon2Mode mode = Argon2Mode.Argon2i, int saltAndPassLength = 16, int hashLength = 16, int maxMemoryMB = 64)
        {
            var factory = new Argon2Factory();
            var logger = new Argon2Logger();
            var input = new Argon2CalibrationInput()
            {
                MaximumTime = maxTime,
                DegreeOfParallelism = SystemManagement.GetTotalCpuCores() * 2,
                MinimumIterations = minIterations,
                Mode = mode,
                SaltAndPasswordLength = saltAndPassLength,
                HashLength = hashLength,
                MaxMemory = maxMemoryMB
            };

            var calibrator = new Argon2Calibrator(factory, logger, input);
            return calibrator.Run().ToList();
        }

    }
}
