// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct LocalizeErrorExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static LocalizeErrorExcel GetRootAsLocalizeErrorExcel(ByteBuffer _bb) { return GetRootAsLocalizeErrorExcel(_bb, new LocalizeErrorExcel()); }
  public static LocalizeErrorExcel GetRootAsLocalizeErrorExcel(ByteBuffer _bb, LocalizeErrorExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public LocalizeErrorExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint Key { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public SCHALE.Common.FlatData.WebAPIErrorLevel ErrorLevel { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.WebAPIErrorLevel)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.WebAPIErrorLevel.None; } }
  public string Kr { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetKrBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetKrBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetKrArray() { return __p.__vector_as_array<byte>(8); }
  public string Jp { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetJpBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetJpBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetJpArray() { return __p.__vector_as_array<byte>(10); }

  public static Offset<SCHALE.Common.FlatData.LocalizeErrorExcel> CreateLocalizeErrorExcel(FlatBufferBuilder builder,
      uint Key = 0,
      SCHALE.Common.FlatData.WebAPIErrorLevel ErrorLevel = SCHALE.Common.FlatData.WebAPIErrorLevel.None,
      StringOffset KrOffset = default(StringOffset),
      StringOffset JpOffset = default(StringOffset)) {
    builder.StartTable(4);
    LocalizeErrorExcel.AddJp(builder, JpOffset);
    LocalizeErrorExcel.AddKr(builder, KrOffset);
    LocalizeErrorExcel.AddErrorLevel(builder, ErrorLevel);
    LocalizeErrorExcel.AddKey(builder, Key);
    return LocalizeErrorExcel.EndLocalizeErrorExcel(builder);
  }

  public static void StartLocalizeErrorExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddKey(FlatBufferBuilder builder, uint key) { builder.AddUint(0, key, 0); }
  public static void AddErrorLevel(FlatBufferBuilder builder, SCHALE.Common.FlatData.WebAPIErrorLevel errorLevel) { builder.AddInt(1, (int)errorLevel, 0); }
  public static void AddKr(FlatBufferBuilder builder, StringOffset krOffset) { builder.AddOffset(2, krOffset.Value, 0); }
  public static void AddJp(FlatBufferBuilder builder, StringOffset jpOffset) { builder.AddOffset(3, jpOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.LocalizeErrorExcel> EndLocalizeErrorExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.LocalizeErrorExcel>(o);
  }
  public LocalizeErrorExcelT UnPack() {
    var _o = new LocalizeErrorExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(LocalizeErrorExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("LocalizeError");
    _o.Key = TableEncryptionService.Convert(this.Key, key);
    _o.ErrorLevel = TableEncryptionService.Convert(this.ErrorLevel, key);
    _o.Kr = TableEncryptionService.Convert(this.Kr, key);
    _o.Jp = TableEncryptionService.Convert(this.Jp, key);
  }
  public static Offset<SCHALE.Common.FlatData.LocalizeErrorExcel> Pack(FlatBufferBuilder builder, LocalizeErrorExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.LocalizeErrorExcel>);
    var _Kr = _o.Kr == null ? default(StringOffset) : builder.CreateString(_o.Kr);
    var _Jp = _o.Jp == null ? default(StringOffset) : builder.CreateString(_o.Jp);
    return CreateLocalizeErrorExcel(
      builder,
      _o.Key,
      _o.ErrorLevel,
      _Kr,
      _Jp);
  }
}

public class LocalizeErrorExcelT
{
  public uint Key { get; set; }
  public SCHALE.Common.FlatData.WebAPIErrorLevel ErrorLevel { get; set; }
  public string Kr { get; set; }
  public string Jp { get; set; }

  public LocalizeErrorExcelT() {
    this.Key = 0;
    this.ErrorLevel = SCHALE.Common.FlatData.WebAPIErrorLevel.None;
    this.Kr = null;
    this.Jp = null;
  }
}


static public class LocalizeErrorExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Key*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ErrorLevel*/, 4 /*SCHALE.Common.FlatData.WebAPIErrorLevel*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*Kr*/, false)
      && verifier.VerifyString(tablePos, 10 /*Jp*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}