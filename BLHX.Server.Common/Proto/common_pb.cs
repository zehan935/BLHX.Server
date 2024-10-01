// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: common_pb.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace BLHX.Server.Common.Proto.common
{

    [global::ProtoBuf.ProtoContract(Name = @"appreciationinfo")]
    public partial class Appreciationinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"gallerys")]
        public global::System.Collections.Generic.List<uint> Gallerys { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(2, Name = @"musics")]
        public global::System.Collections.Generic.List<uint> Musics { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(3, Name = @"favor_gallerys")]
        public global::System.Collections.Generic.List<uint> FavorGallerys { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(4, Name = @"favor_musics")]
        public global::System.Collections.Generic.List<uint> FavorMusics { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"attrinfo")]
    public partial class Attrinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"level", IsRequired = true)]
        public uint Level { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"exp", IsRequired = true)]
        public uint Exp { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"buildinfo")]
    public partial class Buildinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"time", IsRequired = true)]
        public uint Time { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"finish_time", IsRequired = true)]
        public uint FinishTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"build_id", IsRequired = true)]
        public uint BuildId { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"collectioninfo")]
    public partial class Collectioninfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"finish_time", IsRequired = true)]
        public uint FinishTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"over_time", IsRequired = true)]
        public uint OverTime { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"ship_id_list")]
        public global::System.Collections.Generic.List<uint> ShipIdLists { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"commanderinfo")]
    public partial class Commanderinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"template_id", IsRequired = true)]
        public uint TemplateId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"level", IsRequired = true)]
        public uint Level { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"exp", IsRequired = true)]
        public uint Exp { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"is_locked", IsRequired = true)]
        public uint IsLocked { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"ability")]
        public global::System.Collections.Generic.List<uint> Abilities { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(7, Name = @"ability_origin")]
        public global::System.Collections.Generic.List<uint> AbilityOrigins { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(8, Name = @"ability_time", IsRequired = true)]
        public uint AbilityTime { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"skill")]
        public global::System.Collections.Generic.List<Skillinfo> Skills { get; set; } = new global::System.Collections.Generic.List<Skillinfo>();

        [global::ProtoBuf.ProtoMember(10, Name = @"used_pt", IsRequired = true)]
        public uint UsedPt { get; set; }

        [global::ProtoBuf.ProtoMember(11, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"rename_time", IsRequired = true)]
        public uint RenameTime { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"home_clean_time")]
        public uint HomeCleanTime
        {
            get => __pbn__HomeCleanTime.GetValueOrDefault();
            set => __pbn__HomeCleanTime = value;
        }
        public bool ShouldSerializeHomeCleanTime() => __pbn__HomeCleanTime != null;
        public void ResetHomeCleanTime() => __pbn__HomeCleanTime = null;
        private uint? __pbn__HomeCleanTime;

        [global::ProtoBuf.ProtoMember(14, Name = @"home_play_time")]
        public uint HomePlayTime
        {
            get => __pbn__HomePlayTime.GetValueOrDefault();
            set => __pbn__HomePlayTime = value;
        }
        public bool ShouldSerializeHomePlayTime() => __pbn__HomePlayTime != null;
        public void ResetHomePlayTime() => __pbn__HomePlayTime = null;
        private uint? __pbn__HomePlayTime;

        [global::ProtoBuf.ProtoMember(15, Name = @"home_feed_time")]
        public uint HomeFeedTime
        {
            get => __pbn__HomeFeedTime.GetValueOrDefault();
            set => __pbn__HomeFeedTime = value;
        }
        public bool ShouldSerializeHomeFeedTime() => __pbn__HomeFeedTime != null;
        public void ResetHomeFeedTime() => __pbn__HomeFeedTime = null;
        private uint? __pbn__HomeFeedTime;

    }

    [global::ProtoBuf.ProtoContract(Name = @"commandersinfo")]
    public partial class Commandersinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pos", IsRequired = true)]
        public uint Pos { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"displayinfo")]
    public partial class Displayinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"icon", IsRequired = true)]
        public uint Icon { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"skin", IsRequired = true)]
        public uint Skin { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"icon_frame", IsRequired = true)]
        public uint IconFrame { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"chat_frame", IsRequired = true)]
        public uint ChatFrame { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"icon_theme", IsRequired = true)]
        public uint IconTheme { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"marry_flag", IsRequired = true)]
        public uint MarryFlag { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"transform_flag", IsRequired = true)]
        public uint TransformFlag { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"dropinfo")]
    public partial class Dropinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"number", IsRequired = true)]
        public uint Number { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"equipskin_info")]
    public partial class EquipskinInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, IsRequired = true)]
        public uint skinId { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"fleetinfo")]
    public partial class Fleetinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"ship_list")]
        public global::System.Collections.Generic.List<uint> ShipLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(3, Name = @"commanders")]
        public global::System.Collections.Generic.List<Commandersinfo> Commanders { get; set; } = new global::System.Collections.Generic.List<Commandersinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"idtimeinfo")]
    public partial class Idtimeinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"time", IsRequired = true)]
        public uint Time { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"item_info")]
    public partial class ItemInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"num", IsRequired = true)]
        public uint Num { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"kvdata")]
    public partial class Kvdata : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key", IsRequired = true)]
        public uint Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value", IsRequired = true)]
        public uint Value { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"kvdata2")]
    public partial class Kvdata2 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"key", IsRequired = true)]
        public uint Key { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"value1", IsRequired = true)]
        public uint Value1 { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"value2", IsRequired = true)]
        public uint Value2 { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"refund_shopinfo")]
    public partial class RefundShopinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"shop_id", IsRequired = true)]
        public uint ShopId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"buy_time", IsRequired = true)]
        public uint BuyTime { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"refund_time", IsRequired = true)]
        public uint RefundTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"shipcoreinfo")]
    public partial class Shipcoreinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"exp", IsRequired = true)]
        public uint Exp { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"model_list")]
        public global::System.Collections.Generic.List<Shipmodelinfo> ModelLists { get; set; } = new global::System.Collections.Generic.List<Shipmodelinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"shipgrouppos")]
    public partial class Shipgrouppos : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"ship_id", IsRequired = true)]
        public uint ShipId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"pos", IsRequired = true)]
        public uint Pos { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"shipinfo")]
    public partial class Shipinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"template_id", IsRequired = true)]
        public uint TemplateId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"level", IsRequired = true)]
        public uint Level { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"exp", IsRequired = true)]
        public uint Exp { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"equip_info_list")]
        public global::System.Collections.Generic.List<EquipskinInfo> EquipInfoLists { get; set; } = new global::System.Collections.Generic.List<EquipskinInfo>();

        [global::ProtoBuf.ProtoMember(6, Name = @"energy", IsRequired = true)]
        public uint Energy { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"state", IsRequired = true)]
        public Shipstate State { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"is_locked", IsRequired = true)]
        public uint IsLocked { get; set; }

        [global::ProtoBuf.ProtoMember(9, Name = @"transform_list")]
        public global::System.Collections.Generic.List<TransformInfo> TransformLists { get; set; } = new global::System.Collections.Generic.List<TransformInfo>();

        [global::ProtoBuf.ProtoMember(10, Name = @"skill_id_list")]
        public global::System.Collections.Generic.List<Shipskill> SkillIdLists { get; set; } = new global::System.Collections.Generic.List<Shipskill>();

        [global::ProtoBuf.ProtoMember(11, Name = @"intimacy", IsRequired = true)]
        public uint Intimacy { get; set; }

        [global::ProtoBuf.ProtoMember(12, Name = @"proficiency", IsRequired = true)]
        public uint Proficiency { get; set; }

        [global::ProtoBuf.ProtoMember(13, Name = @"strength_list")]
        public global::System.Collections.Generic.List<StrengthInfo> StrengthLists { get; set; } = new global::System.Collections.Generic.List<StrengthInfo>();

        [global::ProtoBuf.ProtoMember(14, Name = @"create_time", IsRequired = true)]
        public uint CreateTime { get; set; }

        [global::ProtoBuf.ProtoMember(15, Name = @"skin_id", IsRequired = true)]
        public uint SkinId { get; set; }

        [global::ProtoBuf.ProtoMember(16, Name = @"propose", IsRequired = true)]
        public uint Propose { get; set; }

        [global::ProtoBuf.ProtoMember(17, Name = @"name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Name
        {
            get => __pbn__Name ?? "";
            set => __pbn__Name = value;
        }
        public bool ShouldSerializeName() => __pbn__Name != null;
        public void ResetName() => __pbn__Name = null;
        private string __pbn__Name;

        [global::ProtoBuf.ProtoMember(18, Name = @"change_name_timestamp")]
        public uint ChangeNameTimestamp
        {
            get => __pbn__ChangeNameTimestamp.GetValueOrDefault();
            set => __pbn__ChangeNameTimestamp = value;
        }
        public bool ShouldSerializeChangeNameTimestamp() => __pbn__ChangeNameTimestamp != null;
        public void ResetChangeNameTimestamp() => __pbn__ChangeNameTimestamp = null;
        private uint? __pbn__ChangeNameTimestamp;

        [global::ProtoBuf.ProtoMember(19, Name = @"commanderid", IsRequired = true)]
        public uint Commanderid { get; set; }

        [global::ProtoBuf.ProtoMember(20, Name = @"max_level", IsRequired = true)]
        public uint MaxLevel { get; set; }

        [global::ProtoBuf.ProtoMember(21, Name = @"blue_print_flag", IsRequired = true)]
        public uint BluePrintFlag { get; set; }

        [global::ProtoBuf.ProtoMember(22, Name = @"common_flag")]
        public uint CommonFlag
        {
            get => __pbn__CommonFlag.GetValueOrDefault();
            set => __pbn__CommonFlag = value;
        }
        public bool ShouldSerializeCommonFlag() => __pbn__CommonFlag != null;
        public void ResetCommonFlag() => __pbn__CommonFlag = null;
        private uint? __pbn__CommonFlag;

        [global::ProtoBuf.ProtoMember(23, Name = @"activity_npc", IsRequired = true)]
        public uint ActivityNpc { get; set; }

        [global::ProtoBuf.ProtoMember(24, Name = @"meta_repair_list")]
        public global::System.Collections.Generic.List<uint> MetaRepairLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(25, Name = @"core_list")]
        public global::System.Collections.Generic.List<Shipcoreinfo> CoreLists { get; set; } = new global::System.Collections.Generic.List<Shipcoreinfo>();

        [global::ProtoBuf.ProtoMember(26, Name = @"spweapon")]
        public Spweaponinfo Spweapon { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"shipmodelinfo")]
    public partial class Shipmodelinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"pos", IsRequired = true)]
        public uint Pos { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"shipskill")]
    public partial class Shipskill : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"skill_id", IsRequired = true)]
        public uint SkillId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"skill_lv", IsRequired = true)]
        public uint SkillLv { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"skill_exp", IsRequired = true)]
        public uint SkillExp { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"shipstate")]
    public partial class Shipstate : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"state", IsRequired = true)]
        public uint State { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"state_info_1")]
        public uint StateInfo1
        {
            get => __pbn__StateInfo1.GetValueOrDefault();
            set => __pbn__StateInfo1 = value;
        }
        public bool ShouldSerializeStateInfo1() => __pbn__StateInfo1 != null;
        public void ResetStateInfo1() => __pbn__StateInfo1 = null;
        private uint? __pbn__StateInfo1;

        [global::ProtoBuf.ProtoMember(3, Name = @"state_info_2")]
        public uint StateInfo2
        {
            get => __pbn__StateInfo2.GetValueOrDefault();
            set => __pbn__StateInfo2 = value;
        }
        public bool ShouldSerializeStateInfo2() => __pbn__StateInfo2 != null;
        public void ResetStateInfo2() => __pbn__StateInfo2 = null;
        private uint? __pbn__StateInfo2;

        [global::ProtoBuf.ProtoMember(4, Name = @"state_info_3")]
        public uint StateInfo3
        {
            get => __pbn__StateInfo3.GetValueOrDefault();
            set => __pbn__StateInfo3 = value;
        }
        public bool ShouldSerializeStateInfo3() => __pbn__StateInfo3 != null;
        public void ResetStateInfo3() => __pbn__StateInfo3 = null;
        private uint? __pbn__StateInfo3;

        [global::ProtoBuf.ProtoMember(5, Name = @"state_info_4")]
        public uint StateInfo4
        {
            get => __pbn__StateInfo4.GetValueOrDefault();
            set => __pbn__StateInfo4 = value;
        }
        public bool ShouldSerializeStateInfo4() => __pbn__StateInfo4 != null;
        public void ResetStateInfo4() => __pbn__StateInfo4 = null;
        private uint? __pbn__StateInfo4;

    }

    [global::ProtoBuf.ProtoContract(Name = @"skillinfo")]
    public partial class Skillinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"exp", IsRequired = true)]
        public uint Exp { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"spweaponinfo")]
    public partial class Spweaponinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"template_id", IsRequired = true)]
        public uint TemplateId { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"attr_1", IsRequired = true)]
        public uint Attr1 { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"attr_2", IsRequired = true)]
        public uint Attr2 { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"attr_temp_1", IsRequired = true)]
        public uint AttrTemp1 { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"attr_temp_2", IsRequired = true)]
        public uint AttrTemp2 { get; set; }

        [global::ProtoBuf.ProtoMember(7, Name = @"effect", IsRequired = true)]
        public uint Effect { get; set; }

        [global::ProtoBuf.ProtoMember(8, Name = @"pt", IsRequired = true)]
        public uint Pt { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"strength_info")]
    public partial class StrengthInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"exp", IsRequired = true)]
        public uint Exp { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"taskinfo")]
    public partial class Taskinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"progress", IsRequired = true)]
        public uint Progress { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"accept_time", IsRequired = true)]
        public uint AcceptTime { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"submit_time", IsRequired = true)]
        public uint SubmitTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"transform_info")]
    public partial class TransformInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"level", IsRequired = true)]
        public uint Level { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"usersimpleinfo")]
    public partial class Usersimpleinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"lv", IsRequired = true)]
        public uint Lv { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"display", IsRequired = true)]
        public Displayinfo Display { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
