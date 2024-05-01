// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct WorldRaidConditionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static WorldRaidConditionExcel GetRootAsWorldRaidConditionExcel(ByteBuffer _bb) { return GetRootAsWorldRaidConditionExcel(_bb, new WorldRaidConditionExcel()); }
  public static WorldRaidConditionExcel GetRootAsWorldRaidConditionExcel(ByteBuffer _bb, WorldRaidConditionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WorldRaidConditionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string LockUI(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int LockUILength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public bool HideWhenLocked { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AccountLevel { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioModeId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ScenarioModeIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetScenarioModeIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetScenarioModeIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetScenarioModeIdArray() { return __p.__vector_as_array<long>(12); }
  public long CampaignStageID(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int CampaignStageIDLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetCampaignStageIDBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetCampaignStageIDBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetCampaignStageIDArray() { return __p.__vector_as_array<long>(14); }
  public SCHALE.Common.FlatData.MultipleConditionCheckType MultipleConditionCheckType { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.MultipleConditionCheckType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MultipleConditionCheckType.And; } }
  public string AfterWhenDate { get { int o = __p.__offset(18); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAfterWhenDateBytes() { return __p.__vector_as_span<byte>(18, 1); }
#else
  public ArraySegment<byte>? GetAfterWhenDateBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public byte[] GetAfterWhenDateArray() { return __p.__vector_as_array<byte>(18); }
  public long WorldRaidBossKill(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int WorldRaidBossKillLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetWorldRaidBossKillBytes() { return __p.__vector_as_span<long>(20, 8); }
#else
  public ArraySegment<byte>? GetWorldRaidBossKillBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public long[] GetWorldRaidBossKillArray() { return __p.__vector_as_array<long>(20); }

  public static Offset<SCHALE.Common.FlatData.WorldRaidConditionExcel> CreateWorldRaidConditionExcel(FlatBufferBuilder builder,
      long Id = 0,
      VectorOffset LockUIOffset = default(VectorOffset),
      bool HideWhenLocked = false,
      long AccountLevel = 0,
      VectorOffset ScenarioModeIdOffset = default(VectorOffset),
      VectorOffset CampaignStageIDOffset = default(VectorOffset),
      SCHALE.Common.FlatData.MultipleConditionCheckType MultipleConditionCheckType = SCHALE.Common.FlatData.MultipleConditionCheckType.And,
      StringOffset AfterWhenDateOffset = default(StringOffset),
      VectorOffset WorldRaidBossKillOffset = default(VectorOffset)) {
    builder.StartTable(9);
    WorldRaidConditionExcel.AddAccountLevel(builder, AccountLevel);
    WorldRaidConditionExcel.AddId(builder, Id);
    WorldRaidConditionExcel.AddWorldRaidBossKill(builder, WorldRaidBossKillOffset);
    WorldRaidConditionExcel.AddAfterWhenDate(builder, AfterWhenDateOffset);
    WorldRaidConditionExcel.AddMultipleConditionCheckType(builder, MultipleConditionCheckType);
    WorldRaidConditionExcel.AddCampaignStageID(builder, CampaignStageIDOffset);
    WorldRaidConditionExcel.AddScenarioModeId(builder, ScenarioModeIdOffset);
    WorldRaidConditionExcel.AddLockUI(builder, LockUIOffset);
    WorldRaidConditionExcel.AddHideWhenLocked(builder, HideWhenLocked);
    return WorldRaidConditionExcel.EndWorldRaidConditionExcel(builder);
  }

  public static void StartWorldRaidConditionExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddLockUI(FlatBufferBuilder builder, VectorOffset lockUIOffset) { builder.AddOffset(1, lockUIOffset.Value, 0); }
  public static VectorOffset CreateLockUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLockUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHideWhenLocked(FlatBufferBuilder builder, bool hideWhenLocked) { builder.AddBool(2, hideWhenLocked, false); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long accountLevel) { builder.AddLong(3, accountLevel, 0); }
  public static void AddScenarioModeId(FlatBufferBuilder builder, VectorOffset scenarioModeIdOffset) { builder.AddOffset(4, scenarioModeIdOffset.Value, 0); }
  public static VectorOffset CreateScenarioModeIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateScenarioModeIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioModeIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateScenarioModeIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartScenarioModeIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddCampaignStageID(FlatBufferBuilder builder, VectorOffset campaignStageIDOffset) { builder.AddOffset(5, campaignStageIDOffset.Value, 0); }
  public static VectorOffset CreateCampaignStageIDVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateCampaignStageIDVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCampaignStageIDVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateCampaignStageIDVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartCampaignStageIDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddMultipleConditionCheckType(FlatBufferBuilder builder, SCHALE.Common.FlatData.MultipleConditionCheckType multipleConditionCheckType) { builder.AddInt(6, (int)multipleConditionCheckType, 0); }
  public static void AddAfterWhenDate(FlatBufferBuilder builder, StringOffset afterWhenDateOffset) { builder.AddOffset(7, afterWhenDateOffset.Value, 0); }
  public static void AddWorldRaidBossKill(FlatBufferBuilder builder, VectorOffset worldRaidBossKillOffset) { builder.AddOffset(8, worldRaidBossKillOffset.Value, 0); }
  public static VectorOffset CreateWorldRaidBossKillVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateWorldRaidBossKillVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWorldRaidBossKillVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateWorldRaidBossKillVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartWorldRaidBossKillVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.WorldRaidConditionExcel> EndWorldRaidConditionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.WorldRaidConditionExcel>(o);
  }
  public WorldRaidConditionExcelT UnPack() {
    var _o = new WorldRaidConditionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(WorldRaidConditionExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("WorldRaidCondition");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.LockUI = new List<string>();
    for (var _j = 0; _j < this.LockUILength; ++_j) {_o.LockUI.Add(TableEncryptionService.Convert(this.LockUI(_j), key));}
    _o.HideWhenLocked = TableEncryptionService.Convert(this.HideWhenLocked, key);
    _o.AccountLevel = TableEncryptionService.Convert(this.AccountLevel, key);
    _o.ScenarioModeId = new List<long>();
    for (var _j = 0; _j < this.ScenarioModeIdLength; ++_j) {_o.ScenarioModeId.Add(TableEncryptionService.Convert(this.ScenarioModeId(_j), key));}
    _o.CampaignStageID = new List<long>();
    for (var _j = 0; _j < this.CampaignStageIDLength; ++_j) {_o.CampaignStageID.Add(TableEncryptionService.Convert(this.CampaignStageID(_j), key));}
    _o.MultipleConditionCheckType = TableEncryptionService.Convert(this.MultipleConditionCheckType, key);
    _o.AfterWhenDate = TableEncryptionService.Convert(this.AfterWhenDate, key);
    _o.WorldRaidBossKill = new List<long>();
    for (var _j = 0; _j < this.WorldRaidBossKillLength; ++_j) {_o.WorldRaidBossKill.Add(TableEncryptionService.Convert(this.WorldRaidBossKill(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.WorldRaidConditionExcel> Pack(FlatBufferBuilder builder, WorldRaidConditionExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.WorldRaidConditionExcel>);
    var _LockUI = default(VectorOffset);
    if (_o.LockUI != null) {
      var __LockUI = new StringOffset[_o.LockUI.Count];
      for (var _j = 0; _j < __LockUI.Length; ++_j) { __LockUI[_j] = builder.CreateString(_o.LockUI[_j]); }
      _LockUI = CreateLockUIVector(builder, __LockUI);
    }
    var _ScenarioModeId = default(VectorOffset);
    if (_o.ScenarioModeId != null) {
      var __ScenarioModeId = _o.ScenarioModeId.ToArray();
      _ScenarioModeId = CreateScenarioModeIdVector(builder, __ScenarioModeId);
    }
    var _CampaignStageID = default(VectorOffset);
    if (_o.CampaignStageID != null) {
      var __CampaignStageID = _o.CampaignStageID.ToArray();
      _CampaignStageID = CreateCampaignStageIDVector(builder, __CampaignStageID);
    }
    var _AfterWhenDate = _o.AfterWhenDate == null ? default(StringOffset) : builder.CreateString(_o.AfterWhenDate);
    var _WorldRaidBossKill = default(VectorOffset);
    if (_o.WorldRaidBossKill != null) {
      var __WorldRaidBossKill = _o.WorldRaidBossKill.ToArray();
      _WorldRaidBossKill = CreateWorldRaidBossKillVector(builder, __WorldRaidBossKill);
    }
    return CreateWorldRaidConditionExcel(
      builder,
      _o.Id,
      _LockUI,
      _o.HideWhenLocked,
      _o.AccountLevel,
      _ScenarioModeId,
      _CampaignStageID,
      _o.MultipleConditionCheckType,
      _AfterWhenDate,
      _WorldRaidBossKill);
  }
}

public class WorldRaidConditionExcelT
{
  public long Id { get; set; }
  public List<string> LockUI { get; set; }
  public bool HideWhenLocked { get; set; }
  public long AccountLevel { get; set; }
  public List<long> ScenarioModeId { get; set; }
  public List<long> CampaignStageID { get; set; }
  public SCHALE.Common.FlatData.MultipleConditionCheckType MultipleConditionCheckType { get; set; }
  public string AfterWhenDate { get; set; }
  public List<long> WorldRaidBossKill { get; set; }

  public WorldRaidConditionExcelT() {
    this.Id = 0;
    this.LockUI = null;
    this.HideWhenLocked = false;
    this.AccountLevel = 0;
    this.ScenarioModeId = null;
    this.CampaignStageID = null;
    this.MultipleConditionCheckType = SCHALE.Common.FlatData.MultipleConditionCheckType.And;
    this.AfterWhenDate = null;
    this.WorldRaidBossKill = null;
  }
}


static public class WorldRaidConditionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfStrings(tablePos, 6 /*LockUI*/, false)
      && verifier.VerifyField(tablePos, 8 /*HideWhenLocked*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*AccountLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*ScenarioModeId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*CampaignStageID*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 16 /*MultipleConditionCheckType*/, 4 /*SCHALE.Common.FlatData.MultipleConditionCheckType*/, 4, false)
      && verifier.VerifyString(tablePos, 18 /*AfterWhenDate*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*WorldRaidBossKill*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}