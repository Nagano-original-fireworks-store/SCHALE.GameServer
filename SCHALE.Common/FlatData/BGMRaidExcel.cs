// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct BGMRaidExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static BGMRaidExcel GetRootAsBGMRaidExcel(ByteBuffer _bb) { return GetRootAsBGMRaidExcel(_bb, new BGMRaidExcel()); }
  public static BGMRaidExcel GetRootAsBGMRaidExcel(ByteBuffer _bb, BGMRaidExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BGMRaidExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long StageId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PhaseIndex { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BGMId { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.BGMRaidExcel> CreateBGMRaidExcel(FlatBufferBuilder builder,
      long StageId = 0,
      long PhaseIndex = 0,
      long BGMId = 0) {
    builder.StartTable(3);
    BGMRaidExcel.AddBGMId(builder, BGMId);
    BGMRaidExcel.AddPhaseIndex(builder, PhaseIndex);
    BGMRaidExcel.AddStageId(builder, StageId);
    return BGMRaidExcel.EndBGMRaidExcel(builder);
  }

  public static void StartBGMRaidExcel(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddStageId(FlatBufferBuilder builder, long stageId) { builder.AddLong(0, stageId, 0); }
  public static void AddPhaseIndex(FlatBufferBuilder builder, long phaseIndex) { builder.AddLong(1, phaseIndex, 0); }
  public static void AddBGMId(FlatBufferBuilder builder, long bGMId) { builder.AddLong(2, bGMId, 0); }
  public static Offset<SCHALE.Common.FlatData.BGMRaidExcel> EndBGMRaidExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.BGMRaidExcel>(o);
  }
  public BGMRaidExcelT UnPack() {
    var _o = new BGMRaidExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BGMRaidExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("BGMRaid");
    _o.StageId = TableEncryptionService.Convert(this.StageId, key);
    _o.PhaseIndex = TableEncryptionService.Convert(this.PhaseIndex, key);
    _o.BGMId = TableEncryptionService.Convert(this.BGMId, key);
  }
  public static Offset<SCHALE.Common.FlatData.BGMRaidExcel> Pack(FlatBufferBuilder builder, BGMRaidExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.BGMRaidExcel>);
    return CreateBGMRaidExcel(
      builder,
      _o.StageId,
      _o.PhaseIndex,
      _o.BGMId);
  }
}

public class BGMRaidExcelT
{
  public long StageId { get; set; }
  public long PhaseIndex { get; set; }
  public long BGMId { get; set; }

  public BGMRaidExcelT() {
    this.StageId = 0;
    this.PhaseIndex = 0;
    this.BGMId = 0;
  }
}


static public class BGMRaidExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*StageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*PhaseIndex*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*BGMId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}