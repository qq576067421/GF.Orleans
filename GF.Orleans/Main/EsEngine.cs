using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
//using CG.Unity.Common;

namespace GF.Orleans
{
    public struct EsEngineSettings
    {
        public byte NodeType;
        public string NodeTypeString;
        public string ListenIp;
        public int ListenPort;
        public string RootEntityType;
        public bool EnableCoSupersocket;
        public string Log4NetConfigPath;
    }

    public interface IEsEngineListener
    {
        //---------------------------------------------------------------------
        void init();

        //---------------------------------------------------------------------
        void release();
    }

    public sealed class EsEngine
    {
        //---------------------------------------------------------------------
        static EsEngine mInstance;
        IEsEngineListener mListener;

        //---------------------------------------------------------------------
        public static EsEngine Instance { get { return mInstance; } }
        public EsEngineSettings Settings { get; private set; }

        //---------------------------------------------------------------------
        public EsEngine(ref EsEngineSettings settings, IEsEngineListener listener)
        {
        }
    }
}
