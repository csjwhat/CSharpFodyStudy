using Cauldron.Interception;
using System;
using System.IO;
using System.Reflection;

namespace AutoLogger
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class LoggerAttribute : Attribute, IMethodInterceptor
    {
        // ロガーの定義
        log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private string _methodName;
        private string _typeName;

        public void OnEnter(Type declaringType, object instance, MethodBase methodbase, object[] values)
        {
            this._methodName = methodbase.Name;
            this._typeName = declaringType.Name;
            logger.Debug($"OnEnter -> {declaringType.Name} {methodbase.Name} {string.Join(" ", values)}");
        }

        public void OnException(Exception e)
        {
            logger.Debug($"OnException -> {_typeName} {_methodName}");
        }

        public void OnExit()
        {
            logger.Debug($"OnExit -> {_typeName} {_methodName}");
        }
    }
}