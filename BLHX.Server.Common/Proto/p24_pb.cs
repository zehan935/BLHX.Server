// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: p24_pb.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace BLHX.Server.Common.Proto.p24
{

    [global::ProtoBuf.ProtoContract(Name = @"userchallengeinfo")]
    public partial class Userchallengeinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"current_score", IsRequired = true)]
        public uint CurrentScore { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"level", IsRequired = true)]
        public uint Level { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"groupinc_list")]
        public global::System.Collections.Generic.List<Groupinfoinchallenge> GroupincLists { get; set; } = new global::System.Collections.Generic.List<Groupinfoinchallenge>();

        [global::ProtoBuf.ProtoMember(4, Name = @"mode", IsRequired = true)]
        public uint Mode { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"issl", IsRequired = true)]
        public uint Issl { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"season_id", IsRequired = true)]
        public uint SeasonId { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"dungeon_id_list")]
        public global::System.Collections.Generic.List<uint> DungeonIdLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(8, Name = @"buff_list")]
        public global::System.Collections.Generic.List<uint> BuffLists { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"commanderinchallenge")]
    public partial class Commanderinchallenge : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pos", IsRequired = true)]
        public uint Pos { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"commanderinfo", IsRequired = true)]
        public global::BLHX.Server.Common.Proto.common.Commanderinfo Commanderinfo { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_24002")]
    public partial class Cs24002 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"activity_id", IsRequired = true)]
        public uint ActivityId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"group_list")]
        public global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.p12.Groupinfo> GroupLists { get; set; } = new global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.p12.Groupinfo>();

        [global::ProtoBuf.ProtoMember(3, Name = @"mode", IsRequired = true)]
        public uint Mode { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_24004")]
    public partial class Cs24004 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"activity_id", IsRequired = true)]
        public uint ActivityId { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_24011")]
    public partial class Cs24011 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"activity_id", IsRequired = true)]
        public uint ActivityId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"mode", IsRequired = true)]
        public uint Mode { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_24020")]
    public partial class Cs24020 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_24022")]
    public partial class Cs24022 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"challengeids")]
        public global::System.Collections.Generic.List<uint> Challengeids { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"groupinfo")]
    public partial class Groupinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ship_list")]
        public global::System.Collections.Generic.List<uint> ShipLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(3, Name = @"commanders")]
        public global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Commandersinfo> Commanders { get; set; } = new global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Commandersinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"groupinfoinchallenge")]
    public partial class Groupinfoinchallenge : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ships")]
        public global::System.Collections.Generic.List<Shipinchallenge> Ships { get; set; } = new global::System.Collections.Generic.List<Shipinchallenge>();

        [global::ProtoBuf.ProtoMember(3, Name = @"commanders")]
        public global::System.Collections.Generic.List<Commanderinchallenge> Commanders { get; set; } = new global::System.Collections.Generic.List<Commanderinchallenge>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_24003")]
    public partial class Sc24003 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_24005")]
    public partial class Sc24005 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"current_challenge", IsRequired = true)]
        public Userchallengeinfo CurrentChallenge { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"user_challenge")]
        public global::System.Collections.Generic.List<Userchallengeinfo> UserChallenges { get; set; } = new global::System.Collections.Generic.List<Userchallengeinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_24010")]
    public partial class Sc24010 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"score", IsRequired = true)]
        public uint Score { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_24012")]
    public partial class Sc24012 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_24021")]
    public partial class Sc24021 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"times")]
        public global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Kvdata> Times { get; set; } = new global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Kvdata>();

        [global::ProtoBuf.ProtoMember(3, Name = @"awards")]
        public global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Kvdata> Awards { get; set; } = new global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Kvdata>();

        [global::ProtoBuf.ProtoMember(4, Name = @"pass_ids")]
        public global::System.Collections.Generic.List<uint> PassIds { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_24023")]
    public partial class Sc24023 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"drop_list")]
        public global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Dropinfo> DropLists { get; set; } = new global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Dropinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_24100")]
    public partial class Sc24100 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"score", IsRequired = true)]
        public uint Score { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"shipinchallenge")]
    public partial class Shipinchallenge : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"hp_rant", IsRequired = true)]
        public uint HpRant { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"ship_info", IsRequired = true)]
        public global::BLHX.Server.Common.Proto.common.Shipinfo ShipInfo { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
