// -----------------------------------------------------------------------
//  <copyright file="WriteConsistency.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

using System;

namespace Akka.DistributedData
{
    public interface IWriteConsistency
    {
        TimeSpan Timeout { get; }
    }

    public class WriteLocal : IWriteConsistency
    {
        static readonly WriteLocal _instance = new WriteLocal();

        private WriteLocal()
        { }

        public static WriteLocal Instance { get { return _instance; } }

        public TimeSpan Timeout
        {
            get { return TimeSpan.Zero; }
        }

        public override bool Equals(object obj)
        {
            return obj != null && obj is WriteLocal;
        }
    }

    public class WriteTo : IWriteConsistency
    {
        readonly int _n;
        readonly TimeSpan _timeout;

        public WriteTo(int n, TimeSpan timeout)
        {
            if(n < 2)
            {
                throw new ArgumentException("WriteTo requires n > 2, Use WriteLocal for n=1");
            }
            _n = n;
            _timeout = timeout;
        }

        public int N
        {
            get { return _n; }
        }

        public TimeSpan Timeout
        {
            get { return _timeout; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as WriteTo;
            if(other != null)
            {
                return _n == other._n && _timeout == other._timeout;
            }
            return false;
        }
    }

    public class WriteMajority : IWriteConsistency
    {
        readonly TimeSpan _timeout;

        public WriteMajority(TimeSpan timeout)
        {
            _timeout = timeout;
        }

        public TimeSpan Timeout
        {
            get { return _timeout; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as WriteMajority;
            if(other != null)
            {
                return _timeout == other._timeout;
            }
            return false;
        }
    }

    public class WriteAll : IWriteConsistency
    {
        readonly TimeSpan _timeout;

        public WriteAll(TimeSpan timeout)
        {
            _timeout = timeout;
        }

        public TimeSpan Timeout
        {
            get { return _timeout; }
        }

        public override bool Equals(object obj)
        {
            var other = obj as WriteAll;
            if(obj != null)
            {
                return _timeout == other._timeout;
            }
            return false;
        }
    }
}
