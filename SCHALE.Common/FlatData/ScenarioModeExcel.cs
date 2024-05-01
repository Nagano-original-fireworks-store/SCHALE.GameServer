// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ScenarioModeExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ScenarioModeExcel GetRootAsScenarioModeExcel(ByteBuffer _bb) { return GetRootAsScenarioModeExcel(_bb, new ScenarioModeExcel()); }
  public static ScenarioModeExcel GetRootAsScenarioModeExcel(ByteBuffer _bb, ScenarioModeExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ScenarioModeExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long ModeId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ScenarioModeTypes ModeType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.ScenarioModeTypes)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ScenarioModeTypes.None; } }
  public SCHALE.Common.FlatData.ScenarioModeSubTypes SubType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ScenarioModeSubTypes)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ScenarioModeSubTypes.None; } }
  public long VolumeId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ChapterId { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EpisodeId { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool Hide { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool Open { get { int o = __p.__offset(18); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool IsContinue { get { int o = __p.__offset(20); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long EpisodeContinueModeId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long FrontScenarioGroupId(int j) { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int FrontScenarioGroupIdLength { get { int o = __p.__offset(24); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetFrontScenarioGroupIdBytes() { return __p.__vector_as_span<long>(24, 8); }
#else
  public ArraySegment<byte>? GetFrontScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(24); }
#endif
  public long[] GetFrontScenarioGroupIdArray() { return __p.__vector_as_array<long>(24); }
  public long StrategyId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroundId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsDefeatBattle { get { int o = __p.__offset(30); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long BattleDuration { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BackScenarioGroupId(int j) { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BackScenarioGroupIdLength { get { int o = __p.__offset(34); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBackScenarioGroupIdBytes() { return __p.__vector_as_span<long>(34, 8); }
#else
  public ArraySegment<byte>? GetBackScenarioGroupIdBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public long[] GetBackScenarioGroupIdArray() { return __p.__vector_as_array<long>(34); }
  public long ClearedModeId(int j) { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ClearedModeIdLength { get { int o = __p.__offset(36); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetClearedModeIdBytes() { return __p.__vector_as_span<long>(36, 8); }
#else
  public ArraySegment<byte>? GetClearedModeIdBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public long[] GetClearedModeIdArray() { return __p.__vector_as_array<long>(36); }
  public long ScenarioModeRewardId { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsScenarioSpecialReward { get { int o = __p.__offset(40); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AccountLevelLimit { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ClearedStageId { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.Club NeedClub { get { int o = __p.__offset(46); return o != 0 ? (SCHALE.Common.FlatData.Club)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.Club.None; } }
  public int NeedClubStudentCount { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public long NeedTSS { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.EventContentType EventContentType { get { int o = __p.__offset(54); return o != 0 ? (SCHALE.Common.FlatData.EventContentType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EventContentType.Stage; } }
  public long EventContentCondition { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentConditionGroup { get { int o = __p.__offset(58); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.StageDifficulty MapDifficulty { get { int o = __p.__offset(60); return o != 0 ? (SCHALE.Common.FlatData.StageDifficulty)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StageDifficulty.None; } }
  public int StepIndex { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int RecommendLevel { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string EventIconParcelPath { get { int o = __p.__offset(66); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEventIconParcelPathBytes() { return __p.__vector_as_span<byte>(66, 1); }
#else
  public ArraySegment<byte>? GetEventIconParcelPathBytes() { return __p.__vector_as_arraysegment(66); }
#endif
  public byte[] GetEventIconParcelPathArray() { return __p.__vector_as_array<byte>(66); }
  public bool Lof { get { int o = __p.__offset(68); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public SCHALE.Common.FlatData.StageTopography StageTopography { get { int o = __p.__offset(70); return o != 0 ? (SCHALE.Common.FlatData.StageTopography)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.StageTopography.Street; } }
  public long FixedEchelonId { get { int o = __p.__offset(72); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string CompleteReportEventName { get { int o = __p.__offset(74); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetCompleteReportEventNameBytes() { return __p.__vector_as_span<byte>(74, 1); }
#else
  public ArraySegment<byte>? GetCompleteReportEventNameBytes() { return __p.__vector_as_arraysegment(74); }
#endif
  public byte[] GetCompleteReportEventNameArray() { return __p.__vector_as_array<byte>(74); }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get { int o = __p.__offset(76); return o != 0 ? (SCHALE.Common.FlatData.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EchelonExtensionType.Base; } }

  public static Offset<SCHALE.Common.FlatData.ScenarioModeExcel> CreateScenarioModeExcel(FlatBufferBuilder builder,
      long ModeId = 0,
      SCHALE.Common.FlatData.ScenarioModeTypes ModeType = SCHALE.Common.FlatData.ScenarioModeTypes.None,
      SCHALE.Common.FlatData.ScenarioModeSubTypes SubType = SCHALE.Common.FlatData.ScenarioModeSubTypes.None,
      long VolumeId = 0,
      long ChapterId = 0,
      long EpisodeId = 0,
      bool Hide = false,
      bool Open = false,
      bool IsContinue = false,
      long EpisodeContinueModeId = 0,
      VectorOffset FrontScenarioGroupIdOffset = default(VectorOffset),
      long StrategyId = 0,
      long GroundId = 0,
      bool IsDefeatBattle = false,
      long BattleDuration = 0,
      VectorOffset BackScenarioGroupIdOffset = default(VectorOffset),
      VectorOffset ClearedModeIdOffset = default(VectorOffset),
      long ScenarioModeRewardId = 0,
      bool IsScenarioSpecialReward = false,
      long AccountLevelLimit = 0,
      long ClearedStageId = 0,
      SCHALE.Common.FlatData.Club NeedClub = SCHALE.Common.FlatData.Club.None,
      int NeedClubStudentCount = 0,
      long NeedTSS = 0,
      long EventContentId = 0,
      SCHALE.Common.FlatData.EventContentType EventContentType = SCHALE.Common.FlatData.EventContentType.Stage,
      long EventContentCondition = 0,
      long EventContentConditionGroup = 0,
      SCHALE.Common.FlatData.StageDifficulty MapDifficulty = SCHALE.Common.FlatData.StageDifficulty.None,
      int StepIndex = 0,
      int RecommendLevel = 0,
      StringOffset EventIconParcelPathOffset = default(StringOffset),
      bool Lof = false,
      SCHALE.Common.FlatData.StageTopography StageTopography = SCHALE.Common.FlatData.StageTopography.Street,
      long FixedEchelonId = 0,
      StringOffset CompleteReportEventNameOffset = default(StringOffset),
      SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base) {
    builder.StartTable(37);
    ScenarioModeExcel.AddFixedEchelonId(builder, FixedEchelonId);
    ScenarioModeExcel.AddEventContentConditionGroup(builder, EventContentConditionGroup);
    ScenarioModeExcel.AddEventContentCondition(builder, EventContentCondition);
    ScenarioModeExcel.AddEventContentId(builder, EventContentId);
    ScenarioModeExcel.AddNeedTSS(builder, NeedTSS);
    ScenarioModeExcel.AddClearedStageId(builder, ClearedStageId);
    ScenarioModeExcel.AddAccountLevelLimit(builder, AccountLevelLimit);
    ScenarioModeExcel.AddScenarioModeRewardId(builder, ScenarioModeRewardId);
    ScenarioModeExcel.AddBattleDuration(builder, BattleDuration);
    ScenarioModeExcel.AddGroundId(builder, GroundId);
    ScenarioModeExcel.AddStrategyId(builder, StrategyId);
    ScenarioModeExcel.AddEpisodeContinueModeId(builder, EpisodeContinueModeId);
    ScenarioModeExcel.AddEpisodeId(builder, EpisodeId);
    ScenarioModeExcel.AddChapterId(builder, ChapterId);
    ScenarioModeExcel.AddVolumeId(builder, VolumeId);
    ScenarioModeExcel.AddModeId(builder, ModeId);
    ScenarioModeExcel.AddEchelonExtensionType(builder, EchelonExtensionType);
    ScenarioModeExcel.AddCompleteReportEventName(builder, CompleteReportEventNameOffset);
    ScenarioModeExcel.AddStageTopography(builder, StageTopography);
    ScenarioModeExcel.AddEventIconParcelPath(builder, EventIconParcelPathOffset);
    ScenarioModeExcel.AddRecommendLevel(builder, RecommendLevel);
    ScenarioModeExcel.AddStepIndex(builder, StepIndex);
    ScenarioModeExcel.AddMapDifficulty(builder, MapDifficulty);
    ScenarioModeExcel.AddEventContentType(builder, EventContentType);
    ScenarioModeExcel.AddNeedClubStudentCount(builder, NeedClubStudentCount);
    ScenarioModeExcel.AddNeedClub(builder, NeedClub);
    ScenarioModeExcel.AddClearedModeId(builder, ClearedModeIdOffset);
    ScenarioModeExcel.AddBackScenarioGroupId(builder, BackScenarioGroupIdOffset);
    ScenarioModeExcel.AddFrontScenarioGroupId(builder, FrontScenarioGroupIdOffset);
    ScenarioModeExcel.AddSubType(builder, SubType);
    ScenarioModeExcel.AddModeType(builder, ModeType);
    ScenarioModeExcel.AddLof(builder, Lof);
    ScenarioModeExcel.AddIsScenarioSpecialReward(builder, IsScenarioSpecialReward);
    ScenarioModeExcel.AddIsDefeatBattle(builder, IsDefeatBattle);
    ScenarioModeExcel.AddIsContinue(builder, IsContinue);
    ScenarioModeExcel.AddOpen(builder, Open);
    ScenarioModeExcel.AddHide(builder, Hide);
    return ScenarioModeExcel.EndScenarioModeExcel(builder);
  }

  public static void StartScenarioModeExcel(FlatBufferBuilder builder) { builder.StartTable(37); }
  public static void AddModeId(FlatBufferBuilder builder, long modeId) { builder.AddLong(0, modeId, 0); }
  public static void AddModeType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioModeTypes modeType) { builder.AddInt(1, (int)modeType, 0); }
  public static void AddSubType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ScenarioModeSubTypes subType) { builder.AddInt(2, (int)subType, 0); }
  public static void AddVolumeId(FlatBufferBuilder builder, long volumeId) { builder.AddLong(3, volumeId, 0); }
  public static void AddChapterId(FlatBufferBuilder builder, long chapterId) { builder.AddLong(4, chapterId, 0); }
  public static void AddEpisodeId(FlatBufferBuilder builder, long episodeId) { builder.AddLong(5, episodeId, 0); }
  public static void AddHide(FlatBufferBuilder builder, bool hide) { builder.AddBool(6, hide, false); }
  public static void AddOpen(FlatBufferBuilder builder, bool open) { builder.AddBool(7, open, false); }
  public static void AddIsContinue(FlatBufferBuilder builder, bool isContinue) { builder.AddBool(8, isContinue, false); }
  public static void AddEpisodeContinueModeId(FlatBufferBuilder builder, long episodeContinueModeId) { builder.AddLong(9, episodeContinueModeId, 0); }
  public static void AddFrontScenarioGroupId(FlatBufferBuilder builder, VectorOffset frontScenarioGroupIdOffset) { builder.AddOffset(10, frontScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateFrontScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateFrontScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFrontScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateFrontScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartFrontScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStrategyId(FlatBufferBuilder builder, long strategyId) { builder.AddLong(11, strategyId, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(12, groundId, 0); }
  public static void AddIsDefeatBattle(FlatBufferBuilder builder, bool isDefeatBattle) { builder.AddBool(13, isDefeatBattle, false); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(14, battleDuration, 0); }
  public static void AddBackScenarioGroupId(FlatBufferBuilder builder, VectorOffset backScenarioGroupIdOffset) { builder.AddOffset(15, backScenarioGroupIdOffset.Value, 0); }
  public static VectorOffset CreateBackScenarioGroupIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBackScenarioGroupIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBackScenarioGroupIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBackScenarioGroupIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBackScenarioGroupIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddClearedModeId(FlatBufferBuilder builder, VectorOffset clearedModeIdOffset) { builder.AddOffset(16, clearedModeIdOffset.Value, 0); }
  public static VectorOffset CreateClearedModeIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateClearedModeIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearedModeIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateClearedModeIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartClearedModeIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddScenarioModeRewardId(FlatBufferBuilder builder, long scenarioModeRewardId) { builder.AddLong(17, scenarioModeRewardId, 0); }
  public static void AddIsScenarioSpecialReward(FlatBufferBuilder builder, bool isScenarioSpecialReward) { builder.AddBool(18, isScenarioSpecialReward, false); }
  public static void AddAccountLevelLimit(FlatBufferBuilder builder, long accountLevelLimit) { builder.AddLong(19, accountLevelLimit, 0); }
  public static void AddClearedStageId(FlatBufferBuilder builder, long clearedStageId) { builder.AddLong(20, clearedStageId, 0); }
  public static void AddNeedClub(FlatBufferBuilder builder, SCHALE.Common.FlatData.Club needClub) { builder.AddInt(21, (int)needClub, 0); }
  public static void AddNeedClubStudentCount(FlatBufferBuilder builder, int needClubStudentCount) { builder.AddInt(22, needClubStudentCount, 0); }
  public static void AddNeedTSS(FlatBufferBuilder builder, long needTSS) { builder.AddLong(23, needTSS, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(24, eventContentId, 0); }
  public static void AddEventContentType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EventContentType eventContentType) { builder.AddInt(25, (int)eventContentType, 0); }
  public static void AddEventContentCondition(FlatBufferBuilder builder, long eventContentCondition) { builder.AddLong(26, eventContentCondition, 0); }
  public static void AddEventContentConditionGroup(FlatBufferBuilder builder, long eventContentConditionGroup) { builder.AddLong(27, eventContentConditionGroup, 0); }
  public static void AddMapDifficulty(FlatBufferBuilder builder, SCHALE.Common.FlatData.StageDifficulty mapDifficulty) { builder.AddInt(28, (int)mapDifficulty, 0); }
  public static void AddStepIndex(FlatBufferBuilder builder, int stepIndex) { builder.AddInt(29, stepIndex, 0); }
  public static void AddRecommendLevel(FlatBufferBuilder builder, int recommendLevel) { builder.AddInt(30, recommendLevel, 0); }
  public static void AddEventIconParcelPath(FlatBufferBuilder builder, StringOffset eventIconParcelPathOffset) { builder.AddOffset(31, eventIconParcelPathOffset.Value, 0); }
  public static void AddLof(FlatBufferBuilder builder, bool lof) { builder.AddBool(32, lof, false); }
  public static void AddStageTopography(FlatBufferBuilder builder, SCHALE.Common.FlatData.StageTopography stageTopography) { builder.AddInt(33, (int)stageTopography, 0); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long fixedEchelonId) { builder.AddLong(34, fixedEchelonId, 0); }
  public static void AddCompleteReportEventName(FlatBufferBuilder builder, StringOffset completeReportEventNameOffset) { builder.AddOffset(35, completeReportEventNameOffset.Value, 0); }
  public static void AddEchelonExtensionType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EchelonExtensionType echelonExtensionType) { builder.AddInt(36, (int)echelonExtensionType, 0); }
  public static Offset<SCHALE.Common.FlatData.ScenarioModeExcel> EndScenarioModeExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ScenarioModeExcel>(o);
  }
  public ScenarioModeExcelT UnPack() {
    var _o = new ScenarioModeExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ScenarioModeExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ScenarioMode");
    _o.ModeId = TableEncryptionService.Convert(this.ModeId, key);
    _o.ModeType = TableEncryptionService.Convert(this.ModeType, key);
    _o.SubType = TableEncryptionService.Convert(this.SubType, key);
    _o.VolumeId = TableEncryptionService.Convert(this.VolumeId, key);
    _o.ChapterId = TableEncryptionService.Convert(this.ChapterId, key);
    _o.EpisodeId = TableEncryptionService.Convert(this.EpisodeId, key);
    _o.Hide = TableEncryptionService.Convert(this.Hide, key);
    _o.Open = TableEncryptionService.Convert(this.Open, key);
    _o.IsContinue = TableEncryptionService.Convert(this.IsContinue, key);
    _o.EpisodeContinueModeId = TableEncryptionService.Convert(this.EpisodeContinueModeId, key);
    _o.FrontScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.FrontScenarioGroupIdLength; ++_j) {_o.FrontScenarioGroupId.Add(TableEncryptionService.Convert(this.FrontScenarioGroupId(_j), key));}
    _o.StrategyId = TableEncryptionService.Convert(this.StrategyId, key);
    _o.GroundId = TableEncryptionService.Convert(this.GroundId, key);
    _o.IsDefeatBattle = TableEncryptionService.Convert(this.IsDefeatBattle, key);
    _o.BattleDuration = TableEncryptionService.Convert(this.BattleDuration, key);
    _o.BackScenarioGroupId = new List<long>();
    for (var _j = 0; _j < this.BackScenarioGroupIdLength; ++_j) {_o.BackScenarioGroupId.Add(TableEncryptionService.Convert(this.BackScenarioGroupId(_j), key));}
    _o.ClearedModeId = new List<long>();
    for (var _j = 0; _j < this.ClearedModeIdLength; ++_j) {_o.ClearedModeId.Add(TableEncryptionService.Convert(this.ClearedModeId(_j), key));}
    _o.ScenarioModeRewardId = TableEncryptionService.Convert(this.ScenarioModeRewardId, key);
    _o.IsScenarioSpecialReward = TableEncryptionService.Convert(this.IsScenarioSpecialReward, key);
    _o.AccountLevelLimit = TableEncryptionService.Convert(this.AccountLevelLimit, key);
    _o.ClearedStageId = TableEncryptionService.Convert(this.ClearedStageId, key);
    _o.NeedClub = TableEncryptionService.Convert(this.NeedClub, key);
    _o.NeedClubStudentCount = TableEncryptionService.Convert(this.NeedClubStudentCount, key);
    _o.NeedTSS = TableEncryptionService.Convert(this.NeedTSS, key);
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.EventContentType = TableEncryptionService.Convert(this.EventContentType, key);
    _o.EventContentCondition = TableEncryptionService.Convert(this.EventContentCondition, key);
    _o.EventContentConditionGroup = TableEncryptionService.Convert(this.EventContentConditionGroup, key);
    _o.MapDifficulty = TableEncryptionService.Convert(this.MapDifficulty, key);
    _o.StepIndex = TableEncryptionService.Convert(this.StepIndex, key);
    _o.RecommendLevel = TableEncryptionService.Convert(this.RecommendLevel, key);
    _o.EventIconParcelPath = TableEncryptionService.Convert(this.EventIconParcelPath, key);
    _o.Lof = TableEncryptionService.Convert(this.Lof, key);
    _o.StageTopography = TableEncryptionService.Convert(this.StageTopography, key);
    _o.FixedEchelonId = TableEncryptionService.Convert(this.FixedEchelonId, key);
    _o.CompleteReportEventName = TableEncryptionService.Convert(this.CompleteReportEventName, key);
    _o.EchelonExtensionType = TableEncryptionService.Convert(this.EchelonExtensionType, key);
  }
  public static Offset<SCHALE.Common.FlatData.ScenarioModeExcel> Pack(FlatBufferBuilder builder, ScenarioModeExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ScenarioModeExcel>);
    var _FrontScenarioGroupId = default(VectorOffset);
    if (_o.FrontScenarioGroupId != null) {
      var __FrontScenarioGroupId = _o.FrontScenarioGroupId.ToArray();
      _FrontScenarioGroupId = CreateFrontScenarioGroupIdVector(builder, __FrontScenarioGroupId);
    }
    var _BackScenarioGroupId = default(VectorOffset);
    if (_o.BackScenarioGroupId != null) {
      var __BackScenarioGroupId = _o.BackScenarioGroupId.ToArray();
      _BackScenarioGroupId = CreateBackScenarioGroupIdVector(builder, __BackScenarioGroupId);
    }
    var _ClearedModeId = default(VectorOffset);
    if (_o.ClearedModeId != null) {
      var __ClearedModeId = _o.ClearedModeId.ToArray();
      _ClearedModeId = CreateClearedModeIdVector(builder, __ClearedModeId);
    }
    var _EventIconParcelPath = _o.EventIconParcelPath == null ? default(StringOffset) : builder.CreateString(_o.EventIconParcelPath);
    var _CompleteReportEventName = _o.CompleteReportEventName == null ? default(StringOffset) : builder.CreateString(_o.CompleteReportEventName);
    return CreateScenarioModeExcel(
      builder,
      _o.ModeId,
      _o.ModeType,
      _o.SubType,
      _o.VolumeId,
      _o.ChapterId,
      _o.EpisodeId,
      _o.Hide,
      _o.Open,
      _o.IsContinue,
      _o.EpisodeContinueModeId,
      _FrontScenarioGroupId,
      _o.StrategyId,
      _o.GroundId,
      _o.IsDefeatBattle,
      _o.BattleDuration,
      _BackScenarioGroupId,
      _ClearedModeId,
      _o.ScenarioModeRewardId,
      _o.IsScenarioSpecialReward,
      _o.AccountLevelLimit,
      _o.ClearedStageId,
      _o.NeedClub,
      _o.NeedClubStudentCount,
      _o.NeedTSS,
      _o.EventContentId,
      _o.EventContentType,
      _o.EventContentCondition,
      _o.EventContentConditionGroup,
      _o.MapDifficulty,
      _o.StepIndex,
      _o.RecommendLevel,
      _EventIconParcelPath,
      _o.Lof,
      _o.StageTopography,
      _o.FixedEchelonId,
      _CompleteReportEventName,
      _o.EchelonExtensionType);
  }
}

public class ScenarioModeExcelT
{
  public long ModeId { get; set; }
  public SCHALE.Common.FlatData.ScenarioModeTypes ModeType { get; set; }
  public SCHALE.Common.FlatData.ScenarioModeSubTypes SubType { get; set; }
  public long VolumeId { get; set; }
  public long ChapterId { get; set; }
  public long EpisodeId { get; set; }
  public bool Hide { get; set; }
  public bool Open { get; set; }
  public bool IsContinue { get; set; }
  public long EpisodeContinueModeId { get; set; }
  public List<long> FrontScenarioGroupId { get; set; }
  public long StrategyId { get; set; }
  public long GroundId { get; set; }
  public bool IsDefeatBattle { get; set; }
  public long BattleDuration { get; set; }
  public List<long> BackScenarioGroupId { get; set; }
  public List<long> ClearedModeId { get; set; }
  public long ScenarioModeRewardId { get; set; }
  public bool IsScenarioSpecialReward { get; set; }
  public long AccountLevelLimit { get; set; }
  public long ClearedStageId { get; set; }
  public SCHALE.Common.FlatData.Club NeedClub { get; set; }
  public int NeedClubStudentCount { get; set; }
  public long NeedTSS { get; set; }
  public long EventContentId { get; set; }
  public SCHALE.Common.FlatData.EventContentType EventContentType { get; set; }
  public long EventContentCondition { get; set; }
  public long EventContentConditionGroup { get; set; }
  public SCHALE.Common.FlatData.StageDifficulty MapDifficulty { get; set; }
  public int StepIndex { get; set; }
  public int RecommendLevel { get; set; }
  public string EventIconParcelPath { get; set; }
  public bool Lof { get; set; }
  public SCHALE.Common.FlatData.StageTopography StageTopography { get; set; }
  public long FixedEchelonId { get; set; }
  public string CompleteReportEventName { get; set; }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get; set; }

  public ScenarioModeExcelT() {
    this.ModeId = 0;
    this.ModeType = SCHALE.Common.FlatData.ScenarioModeTypes.None;
    this.SubType = SCHALE.Common.FlatData.ScenarioModeSubTypes.None;
    this.VolumeId = 0;
    this.ChapterId = 0;
    this.EpisodeId = 0;
    this.Hide = false;
    this.Open = false;
    this.IsContinue = false;
    this.EpisodeContinueModeId = 0;
    this.FrontScenarioGroupId = null;
    this.StrategyId = 0;
    this.GroundId = 0;
    this.IsDefeatBattle = false;
    this.BattleDuration = 0;
    this.BackScenarioGroupId = null;
    this.ClearedModeId = null;
    this.ScenarioModeRewardId = 0;
    this.IsScenarioSpecialReward = false;
    this.AccountLevelLimit = 0;
    this.ClearedStageId = 0;
    this.NeedClub = SCHALE.Common.FlatData.Club.None;
    this.NeedClubStudentCount = 0;
    this.NeedTSS = 0;
    this.EventContentId = 0;
    this.EventContentType = SCHALE.Common.FlatData.EventContentType.Stage;
    this.EventContentCondition = 0;
    this.EventContentConditionGroup = 0;
    this.MapDifficulty = SCHALE.Common.FlatData.StageDifficulty.None;
    this.StepIndex = 0;
    this.RecommendLevel = 0;
    this.EventIconParcelPath = null;
    this.Lof = false;
    this.StageTopography = SCHALE.Common.FlatData.StageTopography.Street;
    this.FixedEchelonId = 0;
    this.CompleteReportEventName = null;
    this.EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base;
  }
}


static public class ScenarioModeExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ModeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*ModeType*/, 4 /*SCHALE.Common.FlatData.ScenarioModeTypes*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*SubType*/, 4 /*SCHALE.Common.FlatData.ScenarioModeSubTypes*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*VolumeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*ChapterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*EpisodeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*Hide*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 18 /*Open*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 20 /*IsContinue*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 22 /*EpisodeContinueModeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 24 /*FrontScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 26 /*StrategyId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*IsDefeatBattle*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 32 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 34 /*BackScenarioGroupId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 36 /*ClearedModeId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 38 /*ScenarioModeRewardId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*IsScenarioSpecialReward*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 42 /*AccountLevelLimit*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 44 /*ClearedStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 46 /*NeedClub*/, 4 /*SCHALE.Common.FlatData.Club*/, 4, false)
      && verifier.VerifyField(tablePos, 48 /*NeedClubStudentCount*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 50 /*NeedTSS*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 52 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 54 /*EventContentType*/, 4 /*SCHALE.Common.FlatData.EventContentType*/, 4, false)
      && verifier.VerifyField(tablePos, 56 /*EventContentCondition*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 58 /*EventContentConditionGroup*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 60 /*MapDifficulty*/, 4 /*SCHALE.Common.FlatData.StageDifficulty*/, 4, false)
      && verifier.VerifyField(tablePos, 62 /*StepIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 64 /*RecommendLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 66 /*EventIconParcelPath*/, false)
      && verifier.VerifyField(tablePos, 68 /*Lof*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 70 /*StageTopography*/, 4 /*SCHALE.Common.FlatData.StageTopography*/, 4, false)
      && verifier.VerifyField(tablePos, 72 /*FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 74 /*CompleteReportEventName*/, false)
      && verifier.VerifyField(tablePos, 76 /*EchelonExtensionType*/, 4 /*SCHALE.Common.FlatData.EchelonExtensionType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}