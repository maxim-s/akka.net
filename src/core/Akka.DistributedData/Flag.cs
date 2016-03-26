// -----------------------------------------------------------------------
//  <copyright file="Flag.cs" company="Akka.NET Project">
//      Copyright (C) 2009-2016 Typesafe Inc. <http://www.typesafe.com>
//      Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
//  </copyright>
// -----------------------------------------------------------------------

namespace Akka.DistributedData
{
    public sealed class Flag : AbstractReplicatedData<Flag>
    {
        private readonly bool _enabled;

        public Flag()
            : this(false)
        { }

        public Flag(bool enabled)
        {
            _enabled = enabled;
        }

        public bool Enabled
        {
            get { return _enabled; }
        }

        public override Flag Merge(Flag other)
        {
            if(other.Enabled)
            {
                return other;
            }
            return this;
        }

        public Flag SwitchOn()
        {
            if(_enabled)
            {
                return this;
            }
            return new Flag(true);
        }

        public override bool Equals(object obj)
        {
            var other = obj as Flag;
            if(other != null)
            {
                return Enabled == other.Enabled;
            }
            return false;
        }
    }

    public sealed class FlagKey : Key<Flag>
    {
        public FlagKey(string id)
            : base(id)
        { }
    }
}
