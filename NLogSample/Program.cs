using NLog;
using System;

namespace NLogSample
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Factory.Configuration.Variables.Add("runtime", "string文字列をセットします。");
            logger.Factory.ReconfigExistingLoggers();


            logger.Info("===== Program Info Start =====");
            logger.Info("===== Program Info End =====");

            logger.Warn("===== Program Warn Start =====");
            logger.Warn("===== Program Warn End =====");

            logger.Error("===== Program Error Start =====");
            logger.Error("===== Program Error End =====");

            Console.ReadKey();
        }
    }
}
