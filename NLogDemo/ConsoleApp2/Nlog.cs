using NLog;

namespace ConsoleApp2
{
    internal class Nlog
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void Loginfo(string msg)
        {
            logger.Info(msg);
        }
        public void Logdebug(string msg)
        {
            logger.Debug(msg);
        }
        public void Logerror(string msg)
        {
            logger.Error(msg);
        }
    }
}
